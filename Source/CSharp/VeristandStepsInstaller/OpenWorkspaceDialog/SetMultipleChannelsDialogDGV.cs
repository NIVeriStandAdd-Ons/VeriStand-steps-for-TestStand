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

namespace OpenWorkspaceDialog
{
    public partial class SetMultipleChannelsDialogDGV : Form
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
        public double[] channelValuesArray;
        public List<string> channelNamesListOld = new List<string>();
        public double[] channelValuesArrayOld;
        public enum ChannelType { paramChannel, faultChannel, writableChannel, readableChannel };
        public ChannelType channelType;
        public string sysDefPath;
        public BaseNodeType[] baseNodeArray;
        public BaseNode baseNodeElement;

        public SetMultipleChannelsDialogDGV(SequenceContext _seqContext, ChannelType _channelType)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            //Set up Teststand objects
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
            channelValuesArray = stepPropertyObject.GetValVariant("VeriStand.ValuesToSet", 0);//Get ValuesToSet array of numbers
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

            //If the file at path FileGlobals.Veristand.SystemDefinitionPath exists and the extension is ".nivssdf" use that System Definition file to initialize the list of channels in the dataGridView1
            if (System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sysDefPath)) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the tree
                InitializeDataGridView(sysDefPath, channelNamesList, channelValuesArray, true);
            }
            //If FileGlobals.Veristand.SystemDefinitionPath is empty or the file does not exist at path FileGlobals.Veristand.SystemDefinitionPath.
            else //(sysDefPath == "" || !System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)))
            {
                //Do nothing
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                channelNamesList.Clear();
                Array.Resize(ref channelValuesArray, this.dataGridView1.Rows.Count);
                for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    if (this.dataGridView1[0, i].Value != null /*&& this.dataGridView1[1, i].Value != null*/)
                    {
                        channelNamesList.Add(this.dataGridView1[0, i].Value.ToString());
                        channelValuesArray[i] = Convert.ToDouble(this.dataGridView1[1, i].Value);
                    }
                }
            }
            stepPropertyObject.SetValVariant("VeriStand.ChannelNames", 0, channelNamesList.ToArray());
            stepPropertyObject.SetValVariant("VeriStand.ValuesToSet", 0, channelValuesArray);
            stepPropertyObject.SetValInterface("VeriStand.BaseNodeArray", 0, baseNodeArray);
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("VeriStand.SystemDefinitionPath", 1, sysDefPath);
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save  (dirty dot*)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(seqContext);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(seqContextPO);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(selectedTSSequence);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(seqFile);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(permSeqContext);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(selectedTSStep);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(propObjectFile);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(stepPropertyObject);
            seqContext = null;
            seqContextPO = null;
            selectedTSSequence = null;
            seqFile = null;
            permSeqContext = null;
            selectedTSStep = null;
            propObjectFile = null;
            stepPropertyObject = null;
            this.Close(); //Close the form
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectChannels_button_Click(object sender, EventArgs e)
        {
            channelNamesListOld.Clear();
            Array.Resize(ref channelValuesArrayOld, this.dataGridView1.Rows.Count);

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1[0, i].Value != null /*&& this.dataGridView1[1, i].Value != null*/)
                {
                    channelNamesListOld.Add(this.dataGridView1[0, i].Value.ToString());
                    channelValuesArrayOld[i] = Convert.ToDouble(this.dataGridView1[1, i].Value);
                }
            }
            this.OpenSelectChannelsDialog = new SelectChannelsDialog(this);
            this.OpenSelectChannelsDialog.ShowDialog();

            //If the file at path FileGlobals.Veristand.SystemDefinitionPath exists and the extension is ".nivssdf" use that System Definition file to initialize the list of channels in the dataGridView1
            if (System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sysDefPath)) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the tree
                InitializeDataGridView(sysDefPath, channelNamesList, channelValuesArray, false);
            }
            //If FileGlobals.Veristand.SystemDefinitionPath is empty or the file does not exist at path FileGlobals.Veristand.SystemDefinitionPath.
            else //(sysDefPath == "" || !System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)))
            {
                //Do nothing
            }
        }
    }
}