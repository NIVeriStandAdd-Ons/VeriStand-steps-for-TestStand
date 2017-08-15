using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xaml;

namespace OpenWorkspaceDialog
{
    public partial class ConfigureLoggingFile : Form
    {
        //TestStand Objects Initiliaze
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        string stepID;
        PropertyObject stepPropertyObject;
        //Veristand Objects Initialize
        SystemDefinition currentSysDef;
        public string[] channelList; //consider making this into an array of channel names to handle when you enable the Channel Browser for checkbox support
        public enum ChannelType { paramChannel, faultChannel, writableChannel, readableChannel };
        ChannelType channelType;
        public string fileDescription;  //stepPropertyObject.GetValString("Veristand.Advanced.fieDescription", 1);
        string sysDefPath;
        public SystemDefinitionBrowser _treeView { get; set; }
        public SystemDefinitionBrowser _aliasBrowser { get; set; }
        public BaseNodeType[] baseNodeArray;
        public BaseNode baseNodeElement;
        public List<string> filePropertyNames = new List<string>();
        public List<string> filePropertyValues = new List<string>();

        public ConfigureLoggingFile(SequenceContext _seqContext, ChannelType _channelType)
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
            LogFilePath_exp.SetValidEvaluationTypes(eval);
            LogFilePath_exp.Context = seqContextPO;
            EvaluationTypes evalNumeric = seqContext.Engine.NewEvaluationTypes();
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();

            //Set up dialog objects
            sysDefPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);//Get the System Definition path for the Client Sequence File. Create it if it does not exist.
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            channelList = stepPropertyObject.GetValVariant("Veristand.ChannelPaths", 0);//Get ChannelPaths array of strings.
            LogFilePath_exp.Text = stepPropertyObject.GetValString("Veristand.LogFilePath", 0);//Try to get the Log File Path associated with this step
            SegmentFileSize_boolean.Checked = stepPropertyObject.GetValBoolean("Veristand.FileSegmenting", 0);//Get the boolean for Segmenting File Size option
            FileSegmentSize_num.Value = (int)stepPropertyObject.GetValNumber("Veristand.FileSegmentingSize", 0);//Get the File Segment Size value
            fileDescription = stepPropertyObject.GetValString("Veristand.FileDescription", 0);//Get the File Description advanced property
            filePropertyNames.AddRange(stepPropertyObject.GetValVariant("Veristand.FilePropertyNames", 0));
            filePropertyValues.AddRange(stepPropertyObject.GetValVariant("Veristand.FilePropertyValues", 0));
            channelType = _channelType;
            if (stepPropertyObject.GetValInterface("Veristand.BaseNodeArray", 0) != null)
            {
                baseNodeArray = (BaseNodeType[])stepPropertyObject.GetValInterface("Veristand.BaseNodeArray", 0);//Get the BaseNodeArray from TestStand and cast to a BaseNodeType[]
            }
                else
            {
                baseNodeArray = new BaseNodeType[0];
            }

            // These changes are in the 2014 VeriStand trunk so as soon as we start using that assembly we should revert these changes.
            // This is a hack for now to get check boxes on the Windows Form TreeAliasBrowserWF.

            Type TreeAliasBrowser = typeof(StorageChannelAndAliasBrowser);
            FieldInfo m_ChanAliasWPFElement = typeof(NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF).GetField(
                "m_ChanAliasWPFElement",
                BindingFlags.NonPublic |
                BindingFlags.Instance);
            FieldInfo aliasBrowserInfo = TreeAliasBrowser.GetField(
                "AliasTab",
                BindingFlags.NonPublic |
                BindingFlags.Instance);
            FieldInfo treeviewInfo = TreeAliasBrowser.GetField(
              "TreeView",
              BindingFlags.NonPublic |
              BindingFlags.Instance);
            var topLevelBrowser = (StorageChannelAndAliasBrowser)m_ChanAliasWPFElement.GetValue(loggingChannelSelection);
            this._aliasBrowser = (SystemDefinitionBrowser)aliasBrowserInfo.GetValue(topLevelBrowser);
            this._treeView = (SystemDefinitionBrowser)treeviewInfo.GetValue(topLevelBrowser);
            this._aliasBrowser.ShowCheckBox = true;
            this._treeView.ShowCheckBox = true;

            //If the file at path FileGlobals.Veristand.SystemDefinitionPath exists and the extension is ".nivssdf" use that System Definition file to initialize the TreeAliasBrowserWF.
                if (System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sysDefPath)) == ".nivssdf")
                {
                    //File exists with correct extension so try and populate the tree
                    InitializeListBox(sysDefPath);
                }
                //If FileGlobals.Veristand.SystemDefinitionPath is empty or the file does not exist at path FileGlobals.Veristand.SystemDefinitionPath.
                else //(sysDefPath == "" || !System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)))
                {
                    //Do nothing
                }
             VSDialogs vsdiag = new VSDialogs();
        }
        private void InitializeListBox(string _sysDefPath)
        {
            currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));
            //if (baseNodeArray != null)
            //{
            //    //Root currentSysDefRoot = currentSysDef.Root;
            //    //for (int i = 0; i < channelList.Length; i++)
            //    //{
            //    //    currentSysDefRoot.FindNodeByPath(channelList[i], out baseNodeElement);
            //    //    baseNodeArray[i] = baseNodeElement.BaseNodeType;
            //    //}
            //}
            switch (channelType)
            {
                case ChannelType.faultChannel:
                    loggingChannelSelection.DisplayFilter = ISystemDefinitionBrowserFilterType.K_CHAN_FAULT;
                    loggingChannelSelection.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
                case ChannelType.readableChannel:
                    loggingChannelSelection.DisplayFilter = ISystemDefinitionBrowserFilterType.K_CHAN_R;
                    loggingChannelSelection.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
                case ChannelType.writableChannel:
                    loggingChannelSelection.DisplayFilter = ISystemDefinitionBrowserFilterType.K_CHAN_W;
                    loggingChannelSelection.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
                case ChannelType.paramChannel:
                    loggingChannelSelection.DisplayFilter = ISystemDefinitionBrowserFilterType.K_ALL;
                    loggingChannelSelection.StartNode = currentSysDef.Root.BaseNodeType;
                    break;
            }
            //Check to see if Step.Veristand.ChannelPath[] not empty. 
            //We should not attempt to initialize the TreeALiasBrowserWF with an empty set of ChannelPaths.
            if (channelList.Length > 0)
            {
                Root currentSysDefRoot = currentSysDef.Root;
                currentSysDefRoot.FindNodeByPath(channelList[0], out baseNodeElement);
                if (baseNodeElement != null)
                {
                    if (baseNodeArray.Length == channelList.Length)
                    {
                        for (int i = 0; i < channelList.Length; i++)
                        {
                            currentSysDefRoot.FindNodeByPath(channelList[i], out baseNodeElement);
                            baseNodeArray[i] = baseNodeElement.BaseNodeType;
                        }
                    }
                    else
                    {
                        //Consider make this code clear the array first and then resize to the correct length.
                        Array.Resize(ref baseNodeArray, channelList.Length);
                        for (int i = 0; i < channelList.Length; i++)
                        {
                            currentSysDefRoot.FindNodeByPath(channelList[i], out baseNodeElement);
                            baseNodeArray[i] = baseNodeElement.BaseNodeType;
                        }
                    }
                    this._aliasBrowser.SetCheckBoxSelections(baseNodeArray);
                    this._treeView.SetCheckBoxSelections(baseNodeArray);
                }
            }
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }
        private void SysDefFileBrowse_Click(object sender, EventArgs e)
        {
            OpenSysDefBrowseFileDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            LogFilePath_exp.Text = openFile.FileName;
            LogFilePath_exp.Text = StringUtilities.parseFilePathString(LogFilePath_exp.Text);//Cpnsider making all paths relative to the VeriStand Project
        }
        private void openSysDefFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            sysDefPath = openFile.FileName;
            sysDefPath = StringUtilities.parseFilePathString(sysDefPath);
            InitializeListBox(sysDefPath);
        }
        private void AdvancedLoggingProperties_button_Click(object sender, EventArgs e)
        {
            this.OpenAdvancedLoggingPropertiesDialog1 = new AdvancedLoggingProperties(seqContext, this);
            this.OpenAdvancedLoggingPropertiesDialog1.ShowDialog();
        }
        private void OK_Click(object sender, EventArgs e)
        {
                try
                {
                    BaseNodeType[] selections =
                        this._aliasBrowser.GetCheckBoxSelections(false)
                            .Concat(this._treeView.GetCheckBoxSelections(false))
                            .ToArray();
                    channelList = (from selection in selections where selection is NationalInstruments.VeriStand.SystemStorage.ChannelType|| selection is AliasType select selection.NodePath).ToArray();
                    stepPropertyObject.SetValVariant("Veristand.ChannelPaths", 0, channelList);
                    stepPropertyObject.SetValInterface("Veristand.BaseNodeArray", 0, selections);
                    stepPropertyObject.SetValString("Veristand.LogFilePath", 0, LogFilePath_exp.Text);
                    stepPropertyObject.SetValBoolean("Veristand.FileSegmenting", 0, SegmentFileSize_boolean.Checked);
                    stepPropertyObject.SetValNumber("Veristand.FileSegmentingSize", 0, (int)FileSegmentSize_num.Value);
                    stepPropertyObject.SetValString("Veristand.FileDescription", 0, fileDescription);
                    seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.SystemDefinitionPath", 1, sysDefPath);
                    seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
                    stepPropertyObject.SetValVariant("Veristand.FilePropertyNames", 0, filePropertyNames.ToArray());
                    stepPropertyObject.SetValVariant("Veristand.FilePropertyValues", 0, filePropertyValues.ToArray());
                }
                catch (System.NullReferenceException ex)
                {
                    //do nothing
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    //do nothing
                }
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)   
            this.Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SegmentFileSize_boolean_CheckedChanged(object sender, EventArgs e)
        {

        }
     }
}

