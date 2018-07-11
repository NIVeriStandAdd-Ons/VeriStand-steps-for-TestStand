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
    public partial class SetMultipleChannelsDialog : Form
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
        public enum ChannelType { paramChannel, faultChannel, writableChannel, readableChannel };
        ChannelType channelType;
        string sysDefPath;
        public BaseNodeType[] baseNodeArray;
        public BaseNode baseNodeElement;

        public SetMultipleChannelsDialog(SequenceContext _seqContext, ChannelType _channelType)
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
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
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            
            //Set up dialog objects
            sysDefPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);//Get the System Definition path for the Client Sequence File. Create it if it does not exist.
            channelNamesList.AddRange(stepPropertyObject.GetValVariant("VeriStand.ChannelNames", 0));//Get ChannelNames array of strings.
            channelValuesArray = stepPropertyObject.GetValVariant("VeriStand.ValuesToSet", 0);//Get ValuesToSet array of numbers
            channelType = _channelType;
            VSDialogs vsdiag = new VSDialogs();

            //If the file at path FileGlobals.Veristand.SystemDefinitionPath exists and the extension is ".nivssdf" use that System Definition file to initialize the list of channels in the dataGridView1
            if (System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sysDefPath)) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the tree
                InitializeTableView(sysDefPath, channelNamesList, channelValuesArray);
            }
            //If FileGlobals.Veristand.SystemDefinitionPath is empty or the file does not exist at path FileGlobals.Veristand.SystemDefinitionPath.
            else //(sysDefPath == "" || !System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)))
            {
                //Do nothing
            }
        }

        //Handle UI flickers during resizing
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleParam = base.CreateParams;
        //        handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
        //        return handleParam;
        //    }
        //}
        private void OK_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.RowCount > 1)
            {
                channelNamesList.Clear();
                Array.Resize(ref channelValuesArray, tableLayoutPanel1.RowCount-1);
                for (int i = 1; i < this.tableLayoutPanel1.RowCount; i++)
                {
                    if (this.tableLayoutPanel1.GetControlFromPosition(0, i) != null && this.tableLayoutPanel1.GetControlFromPosition(1, i) != null)
                    {
                        //AxExpressionEdit currentValueExpression = (AxExpressionEdit)tableLayoutPanel1.GetControlFromPosition(1, i);
                        //string valueString = currentValueExpression.Text;
                        Label currentChannelNameLabel = (Label)tableLayoutPanel1.GetControlFromPosition(0, i);
                        channelNamesList.Add(currentChannelNameLabel.Text);
                        TextBox currentValueTextBox = (TextBox)tableLayoutPanel1.GetControlFromPosition(1, i);
                        double dbl; dbl = float.Parse(currentValueTextBox.Text);
                        channelValuesArray[i - 1] = dbl;
                    }
                }
                stepPropertyObject.SetValVariant("VeriStand.ChannelNames", 0, channelNamesList.ToArray());
                stepPropertyObject.SetValVariant("VeriStand.ValuesToSet", 0, channelValuesArray);
                propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save  (dirty dot*) 
            }
            this.Close(); //Close the form
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetMultipleChannelsDialog_MouseEnter(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.CanFocus)
            {
                tableLayoutPanel1.Focus();
            }
        }
    }
}