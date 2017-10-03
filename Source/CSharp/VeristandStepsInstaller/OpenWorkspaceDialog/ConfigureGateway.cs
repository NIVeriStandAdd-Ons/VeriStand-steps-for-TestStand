using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.ClientAPI;
namespace OpenWorkspaceDialog
{
    public partial class ConfigureGateway : Form
    {
        string gatewayIP = StringUtilities.addDoubleQuotesAroundString("localhost");
        string projectPathStr = StringUtilities.addDoubleQuotesAroundString("");
        string username = "";
        string password = "";
        string sysDefPath;

        //TestStand Objects
        string stepID;
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        PropertyObject stepPropertyObject;
        PropertyObject SeqContextFileGlobals;
        
        public ConfigureGateway(SequenceContext _seqContext)
        {
            //Initialize Windows form
            InitializeComponent();

            //Set up Teststand objects
            seqContext = _seqContext;
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;  //Must get sequence context this way for variables to save if teststand is restarted
            SeqContextFileGlobals = selectedTSSequence.SequenceFile.FileGlobalsDefaultValues;
            propObjectFile = seqFile.AsPropertyObjectFile();
            stepPropertyObject=selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            //Get old values if they exist
            username_exp.Context = seqContextPO;      
            EvaluationTypes eval=seqContext.Engine.NewEvaluationTypes();
            eval.PropertyValueTypeFlags = 0x4;//Strings are valid
            EvaluationTypes evalBool = seqContext.Engine.NewEvaluationTypes();
            evalBool.PropertyValueTypeFlags = 0x1;//Booleans are valid
            username_exp.SetValidEvaluationTypes(eval);
            password_exp.SetValidEvaluationTypes(eval);
            gatewayIP_exp.SetValidEvaluationTypes(eval);
            projectpath_exp.SetValidEvaluationTypes(eval);
            visible_exp.SetValidEvaluationTypes(evalBool);
            password_exp.Context=seqContextPO;
            gatewayIP_exp.Context = seqContextPO;
            projectpath_exp.Context=seqContextPO;
            visible_exp.Context = seqContextPO;
            try
            {
                EventHandler gatewaychangehandler = new EventHandler(this.gatewayIP_exp_Change);
                this.gatewayIP_exp.Change -= gatewaychangehandler;
                gatewayIP = StringUtilities.addDoubleQuotesAroundString(seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.GatewayIP", 0));
                this.gatewayIP_exp.Text = gatewayIP;
                this.gatewayIP_exp.Change += gatewaychangehandler;

                EventHandler projchangehandler = new EventHandler(this.projectpath_exp_Change);
                this.projectpath_exp.Change -= projchangehandler;
                projectPathStr = StringUtilities.addDoubleQuotesAroundString(seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.ProjectPath", 0));
                this.projectpath_exp.Text = projectPathStr;
                this.projectpath_exp.Change += projchangehandler;

                username=seqContextPO.GetValString("Step.Veristand.username",0);
                this.username_exp.Text = username;
                password = seqContextPO.GetValString("Step.Veristand.password", 0);
                this.password_exp.Text = password;
                visible_exp.Text = seqContextPO.GetValString("Step.Veristand.Visible", 0);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                //Variables are not already created. They will be created later
                EventHandler gatewaychangehandler = new EventHandler(this.gatewayIP_exp_Change);
                this.gatewayIP_exp.Change += gatewaychangehandler;
                gatewayIP = "localhost";
                this.gatewayIP_exp.Text = gatewayIP;
                this.gatewayIP_exp.Change += gatewaychangehandler;

                EventHandler projchangehandler = new EventHandler(this.projectpath_exp_Change);
                this.projectpath_exp.Change -= projchangehandler;
                projectPathStr = "";
                this.projectpath_exp.Text = projectPathStr;
                this.projectpath_exp.Change += projchangehandler;

                this. password_exp.Text = "";
                this.username_exp.Text = "";
            }
        }

        private void Gateway_IP_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            gatewayIP = tb.Text;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Make or Set all specified variables in TestStand
            /*Set variables needed for other steps in System Definition and Project since these steps are guaranteed to be called first*/
            permSeqContext.SetValIDispatch("Veristand.VSDialogs", 1, null);
            /*Set variables needed for project */
           
            SeqContextFileGlobals.SetValString("Veristand.GatewayIP", 0, gatewayIP);
            SeqContextFileGlobals.SetValString("Veristand.ProjectPath", 0, projectpath_exp.Text);
            stepPropertyObject.SetValString("Veristand.username", 0, username);
            stepPropertyObject.SetValString("Veristand.password", 0, password);
            stepPropertyObject.SetValString("Veristand.Visible", 0, visible_exp.Text);
            string nodoublequotes = StringUtilities.removeDoubleQuotesAroundString(projectpath_exp.Text);
            string projectpathclean = StringUtilities.unparseFilePathString(nodoublequotes);

            if (projectpath_exp.Text == "" || !System.IO.File.Exists(projectpathclean) || System.IO.Path.GetExtension(projectpathclean) != ".nivsproj")
            {
                SeqContextFileGlobals.SetValString("Veristand.SystemDefinitionPath", 1, "");
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            }

            if (System.IO.File.Exists(projectpathclean) && System.IO.Path.GetExtension(projectpathclean) == ".nivsproj")
            {
                string projectFileText = System.IO.File.ReadAllText(StringUtilities.removeDoubleQuotesAroundString(projectpath_exp.Text));
                string sysDefGUIDPattern = "b9227a5b-2770-4a62-8621-ac414d4124fb.*\n.*\n.*\n.*\n.*\n.*\n.*\n.*\n.*";
                string pathTypePattern = "DependentFile Type=\"";
                string pathPattern = "Path=\"";
                string endpattern = "\".*";

                Regex sysDefGUIDRegX = new Regex(sysDefGUIDPattern);
                Regex pathTypePatternRegx = new Regex(pathTypePattern);
                Regex filePathPatternRegx = new Regex(pathPattern);
                Regex endpatternRegx = new Regex(endpattern);

                string sysDefFileInfo = sysDefGUIDRegX.Match(projectFileText).ToString();
                string[] dependentFileTypeArray = pathTypePatternRegx.Split(sysDefFileInfo);
                string [] pathPatternArray = endpatternRegx.Split(dependentFileTypeArray[1]);

                string[] messyFilePathArray = filePathPatternRegx.Split(sysDefFileInfo);
                string[] cleanFilePathArray = endpatternRegx.Split(messyFilePathArray[1]);

                switch (pathPatternArray[0])
                {
                    case "Relative":
                        {
                            string projectDirectory = System.IO.Path.GetDirectoryName(projectpathclean);
                            sysDefPath = System.IO.Path.Combine(projectDirectory, cleanFilePathArray[0]);
                            break;
                        }
                    case "Absolute":
                        {
                            sysDefPath = cleanFilePathArray[0];
                            break;
                        }
                    case "To Common Doc Dir":
                        {
                            string publicDocumentsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
                            sysDefPath = System.IO.Path.Combine(publicDocumentsPath, "National Instruments", "VeriStand 2014", cleanFilePathArray[0]);
                            break;
                        }
                    case "":
                        {

                            break;
                        }
                }
                SeqContextFileGlobals.SetValString("Veristand.SystemDefinitionPath", 1, sysDefPath);
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            }

            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)    
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            projectPathStr=openFile.FileName;
            projectpath_exp.Text = projectPathStr;
            parseProjectPathString();
        }

        private void gatewayIP_exp_Change(object sender, EventArgs e)
        {
            gatewayIP = gatewayIP_exp.Text;
        }
        private void parseProjectPathString()
        {
            string pattern = @"(?<!\\)(?:((\\\\)*)\\)(?![\\/{])";  //change any single  backslash to a double backslash so it parses correctly in TestStand   
            Regex rgx = new Regex(pattern);
            projectPathStr = projectpath_exp.Text;
            projectPathStr = rgx.Replace(projectPathStr, @"\\");
            if (projectPathStr.First() != '"')
            {
                projectPathStr = "\"" + projectPathStr + "\"";
            }
            projectpath_exp.Text = projectPathStr;
        }
        private void projectpath_exp_Change(object sender, EventArgs e)
        {
           // parseProjectPathString();
        }

        private void username_exp_Change(object sender, EventArgs e)
        {
            username = username_exp.Text;
        }

        private void password_exp_Change(object sender, EventArgs e)
        {
            password = password_exp.Text;
        }
    }
}
