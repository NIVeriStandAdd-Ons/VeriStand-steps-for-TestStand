
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.TestStand.Interop.API;
using System.Text.RegularExpressions;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;


namespace OpenWorkspaceDialog
{
    public partial class ConfigureAlarm : Form
    {
         
        
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        string stepID;
        string alarmName = "";
        string AlarmListFullPath = "";
        PropertyObject stepPropertyObject;
        SystemDefinition currentSysDef;
   
        public ConfigureAlarm(SequenceContext _seqContext)
        {
           
            InitializeComponent();

         
            //Set up Teststand objects
            seqContext = _seqContext;
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;  //Must get sequence context this way for variables to save if teststand is restarted
            propObjectFile = seqFile.AsPropertyObjectFile();
            EvaluationTypes eval = seqContext.Engine.NewEvaluationTypes();
            eval.PropertyValueTypeFlags = 0x4; //set string as the valid evaluation type
            systemDefinitionPath_exp.SetValidEvaluationTypes(eval);
            systemDefinitionPath_exp.Context = seqContextPO;
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            VSDialogs vsdiag = new VSDialogs();
            try
            {
                alarmstate_control.SelectedItem = StringUtilities.removeDoubleQuotesAroundString(stepPropertyObject.GetValString("Veristand.AlarmState", 0));
                alarmName = stepPropertyObject.GetValString("Veristand.AlarmName", 0);
                AlarmListFullPath = stepPropertyObject.GetValString("Veristand.FullAlarmPath", 0);
                systemDefinitionPath_exp.Text = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);//Try to get the specific system definition path associated with this step
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            }
            catch (System.Runtime.InteropServices.COMException)
            {                
                systemDefinitionPath_exp.Text = ""; //If there is no system definition path default to the empty string
            }
            if (System.IO.File.Exists(StringUtilities.unparseFilePathString(systemDefinitionPath_exp.Text)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(systemDefinitionPath_exp.Text)) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the tree
                InitializeListBox(systemDefinitionPath_exp.Text);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
                     
            try
            {
                    string alarmPath = channel_browser.GetCurrentSelections(false)[0].NodePath;
                    stepPropertyObject.SetValString("Veristand.FullAlarmPath", 0, StringUtilities.addDoubleQuotesAroundString(channel_browser.GetCurrentSelections(false)[0].NodePath));
                    Match match = Regex.Match(alarmPath, @"Alarms/([A-Za-z0-9\/-_]+)", RegexOptions.IgnoreCase);
                    string alarmName = match.Groups[1].Value;
                    stepPropertyObject.SetValString("Veristand.AlarmName", 0, StringUtilities.addDoubleQuotesAroundString(alarmName));
                    stepPropertyObject.SetValString("Veristand.AlarmState", 0, StringUtilities.addDoubleQuotesAroundString(alarmstate_control.SelectedItem.ToString()));
             }
             catch (System.NullReferenceException ex)
             {
                 //do nothing
             }
             catch (System.IndexOutOfRangeException ex)
             {
                 //do nothing
             }

            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.SystemDefinitionPath", 1, systemDefinitionPath_exp.Text);//Set system definition path for the Sequence File
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)   
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }

        private void InitializeListBox(string _sysDefPath)
        {
            currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));
            channel_browser.StartNode = currentSysDef.Root.BaseNodeType;
            BaseNode highlightedNode;
       
                if (currentSysDef.Root.FindNodeByPath(StringUtilities.removeDoubleQuotesAroundString(AlarmListFullPath), out highlightedNode))
                {

                    BaseNodeType[] bnArray = { highlightedNode.BaseNodeType };
                    channel_browser.SetCurrentSelections(bnArray);
                }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            systemDefinitionPath_exp.Text = openFile.FileName;
            systemDefinitionPath_exp.Text = StringUtilities.parseFilePathString(systemDefinitionPath_exp.Text);
            InitializeListBox(systemDefinitionPath_exp.Text);

        }
    }
}
    

