using System;
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
    public partial class NativeChannelSelectionDialog : Form
    {
       
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        string stepID;
        string selectedChannelName = "";
        string ModelListFullPath = "";
        PropertyObject stepPropertyObject;
        SystemDefinition currentSysDef;
        public enum ChannelType { paramChannel, faultChannel, writableChannel, readableChannel };
        ChannelType channelType;
        public string sysDefPath;
        public NativeChannelSelectionDialog(SequenceContext _seqContext, ChannelType _channelType)
        {
            InitializeComponent();
            channelType = _channelType;

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
            EvaluationTypes evalNumeric = seqContext.Engine.NewEvaluationTypes();
            evalNumeric.PropertyValueTypeFlags = 0x2; //Set valid evaluation types to number
            value_exp.SetValidEvaluationTypes(evalNumeric);
            value_exp.Context = seqContextPO;
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            VSDialogs vsdiag = new VSDialogs();
            try
            {
                value_exp.Text = stepPropertyObject.GetValString("Veristand.ValueToSet", 0);
                selectedChannelName = stepPropertyObject.GetValString("Veristand.ChannelName", 0);
                sysDefPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);//Try to get the specific system definition path associated with this step
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
                if (sysDefPath == null)
                {
                    sysDefPath = "";
                }
                if (channelType == ChannelType.paramChannel)
                {
                    ModelListFullPath = stepPropertyObject.GetValString("Veristand.FullChannelPath", 0);
                }
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                selectedChannelName = "";
            }
            catch (System.NullReferenceException ex)
            {
                //Do Nothing
            }

            if (sysDefPath != null)
            {
                if (System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sysDefPath)) == ".nivssdf")
                {
                    //File exists with correct extension so try and populate the tree
                    InitializeListBox(sysDefPath);
                }
            }
        }

        private void InitializeListBox(string _sysDefPath)
        {
            currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));       
            BaseNode highlightedNode;
            switch (channelType)
            {
                case ChannelType.faultChannel:
                    channel_browser.DisplayFilter = ISystemDefinitionBrowserFilterType.K_CHAN_FAULT;
                    channel_browser.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
                case ChannelType.readableChannel:
                    channel_browser.DisplayFilter = ISystemDefinitionBrowserFilterType.K_CHAN_R;
                    channel_browser.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
                case ChannelType.writableChannel:
                    channel_browser.DisplayFilter = ISystemDefinitionBrowserFilterType.K_CHAN_W;
                    channel_browser.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
                case ChannelType.paramChannel:
                    channel_browser.DisplayFilter = ISystemDefinitionBrowserFilterType.K_ALL;
                    channel_browser.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
            }
            if (channelType == ChannelType.paramChannel)
            {
                if (currentSysDef.Root.FindNodeByPath(StringUtilities.removeDoubleQuotesAroundString(ModelListFullPath), out highlightedNode))
                {
                    BaseNodeType[] bnArray = { highlightedNode.BaseNodeType };
                    channel_browser.SetCurrentSelections(bnArray);
                }
            }
            else
            {
                if (currentSysDef.Root.FindNodeByPath(StringUtilities.removeDoubleQuotesAroundString(selectedChannelName), out highlightedNode))
                {
                    BaseNodeType[] bnArray = { highlightedNode.BaseNodeType };
                    channel_browser.SetCurrentSelections(bnArray);
                }
            }
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            sysDefPath = openFile.FileName;
            sysDefPath = StringUtilities.parseFilePathString(sysDefPath);
            InitializeListBox(sysDefPath);
        }
       

        private void OK_Click(object sender, EventArgs e)
        {
            stepPropertyObject.SetValString("Veristand.ValueToSet", 1, value_exp.Text);
            if (channelType == ChannelType.paramChannel)
            {
                try
                {
                    stepPropertyObject.SetValString("Veristand.FullChannelPath", 0, StringUtilities.addDoubleQuotesAroundString(channel_browser.GetCurrentSelections(false)[0].NodePath));
                    //Parse the channel list name to get the proper format for a model parameter
                    string input = channel_browser.GetCurrentSelections(false)[0].NodePath;
                    BaseNode modelNode;
                    currentSysDef.Root.FindNodeByPath(input, out modelNode);
                    string modelPath = ((ModelParameter)modelNode).Expression;
                    Match match = Regex.Match(input, @"Targets/([A-Za-z0-9\-_ ()]+)/", RegexOptions.IgnoreCase);
                    string targetName = match.Groups[1].Value;                  
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, StringUtilities.addDoubleQuotesAroundString(modelPath));
                    
                    stepPropertyObject.SetValString("Veristand.TargetName", 0, StringUtilities.addDoubleQuotesAroundString(targetName));
                }
                catch (System.NullReferenceException ex)
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, "");
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, "");
                }
            }
            else
            {
                try
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, StringUtilities.addDoubleQuotesAroundString(channel_browser.GetCurrentSelections(false)[0].NodePath));
                }
                catch (System.NullReferenceException ex)
                {
                    //do nothing
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    //do nothing
                }
            }
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.SystemDefinitionPath", 1, sysDefPath);//Set system definition path for this step
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)   
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
