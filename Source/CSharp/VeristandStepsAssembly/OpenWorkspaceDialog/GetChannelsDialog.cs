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
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;
using NationalInstruments.VeriStand.Data;
using System.Collections.Concurrent;
using NationalInstruments.TestStand.Interop.UI.Ax;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xaml;

namespace OpenWorkspaceDialog
{
    public partial class GetChannelsDialog : Form
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
        public List<string> channelNamesList = new List<string>();
        public enum ChannelType { paramChannel, faultChannel, writableChannel, readableChannel };
        public ChannelType channelType;
        public string sysDefPath;
        public BaseNodeType[] baseNodeArray;
        public BaseNode baseNodeElement;

        public GetChannelsDialog(SequenceContext _seqContext, ChannelType _channelType)
        {
            InitializeComponent();
            seqContext = _seqContext;
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;  //Must get sequence context this way for variables to save if teststand is restarted
            propObjectFile = seqFile.AsPropertyObjectFile();
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            //Set up dialog objects
            sysDefPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);//Get the System Definition path for the Client Sequence File. Create it if it does not exist.
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            channelNamesList.AddRange(stepPropertyObject.GetValVariant("VeriStand.ChannelNames", 0));//Get ChannelNames array of strings.
            channelType = _channelType;

            if (baseNodeArray != null)
            {
                baseNodeArray = (BaseNodeType[])stepPropertyObject.GetValInterface("Veristand.BaseNodeArray", 0);//Get the BaseNodeArray from TestStand and cast to a BaseNodeType[]
            }
            else
            {
                baseNodeArray = new BaseNodeType[0];
            }

            VSDialogs vsdiag = new VSDialogs();
            this.loggingChannelSelection.ShowCheckBox = true;

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
        }
        private void InitializeListBox(string _sysDefPath)
        {
            currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));

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
            if (channelNamesList.Count > 0)
            {
                Root currentSysDefRoot = currentSysDef.Root;
                currentSysDefRoot.FindNodeByPath(channelNamesList.ElementAt(0), out baseNodeElement);
                if (baseNodeElement != null)
                {
                    if (baseNodeArray.Length == channelNamesList.Count)
                    {
                        for (int i = 0; i < channelNamesList.Count; i++)
                        {
                            currentSysDefRoot.FindNodeByPath(channelNamesList.ElementAt(i), out baseNodeElement);
                            baseNodeArray[i] = baseNodeElement.BaseNodeType;
                        }
                    }
                    else
                    {
                        Array.Resize(ref baseNodeArray, channelNamesList.Count);
                        for (int i = 0; i < channelNamesList.Count; i++)
                        {
                            currentSysDefRoot.FindNodeByPath(channelNamesList.ElementAt(i), out baseNodeElement);
                            baseNodeArray[i] = baseNodeElement.BaseNodeType;
                        }
                    }
                    this.loggingChannelSelection.SetCheckBoxSelections(baseNodeArray);
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                BaseNodeType[] selections =
                    this.loggingChannelSelection.GetCheckBoxSelections(false)
                        .ToArray();
                channelNamesList.Clear();
                if (selections.Length > 0)
                {
                    channelNamesList.AddRange(from selection in selections where selection is NationalInstruments.VeriStand.SystemStorage.ChannelType || selection is AliasType select selection.NodePath);
                    stepPropertyObject.SetValVariant("VeriStand.ChannelNames", 0, channelNamesList.ToArray());
                    baseNodeArray = selections;
                    stepPropertyObject.SetValInterface("VeriStand.BaseNodeArray", 0, baseNodeArray);
                }

                }
                catch (System.NullReferenceException ex)
                {
                    //do nothing
                }
                catch (System.IndexOutOfRangeException ex)
                {
                    //do nothing
                }

            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.SystemDefinitionPath", 1, sysDefPath);
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save  (dirty dot*)
            this.baseNodeElement.BaseNodeType.Dispose();
            foreach (BaseNodeType baseNode in this.baseNodeArray)
            {
                baseNode.Dispose();
            }
            this.Close(); //Close the form

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SysDefFileBrowse_Click(object sender, EventArgs e)
        {
            OpenSysDefBrowseFileDialog();
        }
        private void openSysDefFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            sysDefPath = openFile.FileName;
            sysDefPath = StringUtilities.parseFilePathString(sysDefPath);
            InitializeListBox(sysDefPath);
        }
    }
}
