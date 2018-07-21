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
    public partial class ConfigureSystemDefinition : Form
    {
        string SystemDefinitionPath;
        string gatewayIP;
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
        bool deploying = true;
        public ConfigureSystemDefinition(SequenceContext _seqContext,bool _deploying)
        {
            InitializeComponent();

          //Set up Teststand objects
            deploying = _deploying;
            seqContext = _seqContext;
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;  //Must get sequence context this way for variables to save if teststand is restarted
            propObjectFile = seqFile.AsPropertyObjectFile();


            EvaluationTypes eval = seqContext.Engine.NewEvaluationTypes();
            eval.PropertyValueTypeFlags = 0x4;
            EvaluationTypes evalBool = seqContext.Engine.NewEvaluationTypes();
            evalBool.PropertyValueTypeFlags = 0x1;//Booleans are valid
            deploysysdef_exp.SetValidEvaluationTypes(evalBool);
            systemDefinitionPath_exp.SetValidEvaluationTypes(eval);
            deploysysdef_exp.Context = seqContextPO;
            systemDefinitionPath_exp.Context = seqContextPO;
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            if (!deploying)
            {
                this.systemDefinitionPath_exp.Visible = false;
                this.SystemDefinitionPathLabel.Visible = false;
                this.Browse.Visible = false;
            }
            //Get old variable values if they exist
            try
            {
                deploysysdef_exp.Text = stepPropertyObject.GetValString("Veristand.DeploySystemDefinition", 0);
                if (deploying)
                {
                    SystemDefinitionPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);
                    seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
                    this.systemDefinitionPath_exp.Text = SystemDefinitionPath;
                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                //Variables are not already created. They will be created later
                deploysysdef_exp.Text = "True";
                SystemDefinitionPath = "";
                this.systemDefinitionPath_exp.Text = SystemDefinitionPath;

            }           
        }
       private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            SystemDefinitionPath = openFile.FileName;
            this.systemDefinitionPath_exp.Text = SystemDefinitionPath;
            parseSystemDefinitionPathString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Make or Set all specified variables in TestStand
            /*Set variables needed for other steps in System Definition and Project since these steps are guaranteed to be called first*/
            stepPropertyObject.SetValString("Veristand.DeploySystemDefinition", 1, deploysysdef_exp.Text);
            if (deploying)
            {
                permSeqContext.SetValIDispatch("Veristand.VSDialogs", 1, null);
                
                /*Set Variables needed for system definition*/
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.SystemDefinitionPath", 1, SystemDefinitionPath);//Set the system definition path for this step
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
                
            }  
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)    
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void parseSystemDefinitionPathString()
        {
            string pattern = @"(?<!\\)(?:((\\\\)*)\\)(?![\\/{])";  //change any single  backslash to a double backslash so it parses correctly in TestStand   
            Regex rgx = new Regex(pattern);
            SystemDefinitionPath = systemDefinitionPath_exp.Text;
            SystemDefinitionPath = rgx.Replace(SystemDefinitionPath, @"\\");
            if (SystemDefinitionPath.First() != '"')
            {
                SystemDefinitionPath = "\"" + SystemDefinitionPath + "\"";
            }
            systemDefinitionPath_exp.Text = SystemDefinitionPath;
        }


        private void systemDefinitionPath_exp_Change(object sender, EventArgs e)
        {
            SystemDefinitionPath = systemDefinitionPath_exp.Text;
            parseSystemDefinitionPathString();
        }
    }
}
