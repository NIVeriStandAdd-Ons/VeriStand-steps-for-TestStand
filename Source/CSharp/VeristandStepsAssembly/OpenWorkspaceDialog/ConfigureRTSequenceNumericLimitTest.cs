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
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi;
using NationalInstruments.VeriStand.Data;
using System.Collections.Concurrent;
using NationalInstruments.TestStand.Interop.UI.Ax;
namespace OpenWorkspaceDialog
{
    public partial class ConfigureRTSequenceNumericLimit : Form
    {
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        PropertyObject stepPropertyObject;
        public string sysDefPath, target;
        public SystemDefinition currentSysDef;
        public string selectedNodePath, returnParamDataType;

        string stepID;
        string sequenceFileExp;
        string[] parameterTypesArray;
        string[] parameterValuesArray;
        string[] parameterNamesArray;

        public ConfigureRTSequenceNumericLimit(SequenceContext _seqContext)
        {
            InitializeComponent();
            returnParamDataType = "";
            seqContext = _seqContext;
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;
            propObjectFile = seqFile.AsPropertyObjectFile();
            EvaluationTypes eval = seqContext.Engine.NewEvaluationTypes();
            eval.PropertyValueTypeFlags = 0x4; //set string as the valid evaluation type
            FilePath.SetValidEvaluationTypes(eval);
            FilePath.Context = seqContextPO;
            EvaluationTypes evalNumeric = seqContext.Engine.NewEvaluationTypes();
            VSDialogs vsdiag = new VSDialogs();
            int timeoutValue = 0;

            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
                
            
            //Get old values if they exist
            try
            {
                timeoutValue = (int)stepPropertyObject.GetValNumber("Veristand.Timeout", 0);
                target = stepPropertyObject.GetValString("Veristand.Target", 0);
                sequenceFileExp = stepPropertyObject.GetValString("Veristand.SequenceFilePath", 0);
                parameterValuesArray = StringUtilities.expressionArrayToStringArray(stepPropertyObject.GetValVariant("Veristand.ParamValuesArray", 0));
                parameterTypesArray = StringUtilities.expressionArrayToStringArray(stepPropertyObject.GetValVariant("Veristand.ParamTypesArray", 0));
                parameterNamesArray = StringUtilities.expressionArrayToStringArray(stepPropertyObject.GetValVariant("Veristand.ParamNamesArray", 0));
                sysDefPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);

                if (sysDefPath != null && sysDefPath != "")
                {
                    try
                    {
                        currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(sysDefPath));
                    }

                    catch (System.ArgumentException ex)
                    {
                        //Do Nothing
                    }
                }

                try
                {
                    this.Timeout.Value = timeoutValue;
                    this.targetString.Text = target;
                    EventHandler handler = new EventHandler(this.FilePath_TextChanged);
                    /* Disable FilePath_TextChanged event. We need to disable the FilePath_TextChanged event 
                    because when the dialog is launching, the System Definition Path variable from TestStand will 
                    be populated to the FilePath control. Once it is populated, the FilePath control's event will fire, 
                    thus it will try to reload the table. We don't want the table to load twice every time the dialog is launched. */

                    this.FilePath.Change -= handler;

                    // Change the File Path

                    this.FilePath.Text = sequenceFileExp;

                    // Re-enable FilePath_TextChanged event

                    this.FilePath.Change += handler;
                    //If the file at path FileGlobals.Veristand.SystemDefinitionPath exists and the extension is ".nivssdf" use that System Definition file to initialize the TreeAliasBrowserWF.
                    if (System.IO.File.Exists(StringUtilities.unparseFilePathString(sequenceFileExp)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sequenceFileExp)) == ".nivsseq")
                    {
                        //File exists with correct extension so try and populate the tree
                        InitializeTableView(_seqContext, sequenceFileExp, parameterValuesArray, parameterTypesArray, false); //Initialize the data grid with the previously selected data
                    }
                    ////If FileGlobals.Veristand.SystemDefinitionPath is empty or the file does not exist at path FileGlobals.Veristand.SystemDefinitionPath.
                    else //(sysDefPath == "" || !System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)))
                    {
                        //Clear the grid
                        InitializeTableView(_seqContext, "", parameterValuesArray, parameterTypesArray, true);
                    }
                    
                }
                catch (System.ArgumentException ex)
                {
                    //Intentially do nothing
                }
                catch (IndexOutOfRangeException ex)
                {
                    //no sequences, don't need to initialize the data grid
                }      
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                //Variables are not already created in TestStand. They will be created later
                vsdiag.ShowWarningDialog(ex.Message + "------" + ex.StackTrace);

                sequenceFileExp = "";
                this.FilePath.Text = sequenceFileExp;
            }
        }

        //Handle UI flickers during resizing
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void ParameterTypeChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox changedComboBox = (ComboBox)sender;
                TableLayoutPanelCellPosition comboBoxPosition = tableLayoutPanel1.GetPositionFromControl(changedComboBox);
                AxExpressionEdit comboBoxExpEdit = (AxExpressionEdit)tableLayoutPanel1.GetControlFromPosition(2, comboBoxPosition.Row);
                System.Windows.Forms.Button currentBrowseButton = (Button)tableLayoutPanel1.GetControlFromPosition(3, comboBoxPosition.Row);
                VSDialogs vsdiag = new VSDialogs();
                string comboBoxSelectedItem = changedComboBox.SelectedItem.ToString();
                SetExpressionEvalTypeByParameterType(ref comboBoxExpEdit, comboBoxSelectedItem);
                if (comboBoxSelectedItem == "Path")
                {
                    currentBrowseButton.Enabled = true;
                }
                else
                {
                    currentBrowseButton.Enabled = false;
                }
            }
            catch (System.NullReferenceException ex)
            {
                VSDialogs vsdiag = new VSDialogs();
                vsdiag.ShowWarningDialog("Parameter Type Changed Null Reference Exception");
            }
          
        }
  
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            sequenceFileExp = openFile.FileName;
            this.FilePath.Text = StringUtilities.parseFilePathString(sequenceFileExp);
            InitializeTableView(seqContext, sequenceFileExp, parameterValuesArray, parameterTypesArray, true);
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ProcessSequenceParameters()
        {
            bool errorStatus = false;
            Array.Resize(ref parameterNamesArray, 0);
            Array.Resize(ref parameterTypesArray, 0);
            Array.Resize(ref parameterValuesArray, 0);

            if (this.tableLayoutPanel1.RowCount > 1)
            {
                for (int i = 1; i < this.tableLayoutPanel1.RowCount; i++)
                {

                    //if (this.tableLayoutPanel1.GetControlFromPosition(1, i) != null && this.tableLayoutPanel1.GetControlFromPosition(2, i) != null)
                    //{
                        Label currentNameLabel = (Label)tableLayoutPanel1.GetControlFromPosition(0, i);
                        ComboBox currentTypeComboBox = (ComboBox)tableLayoutPanel1.GetControlFromPosition(1, i);
                        AxExpressionEdit currentValueExpression = (AxExpressionEdit)tableLayoutPanel1.GetControlFromPosition(2, i);
                    try
                    {
                        if (currentTypeComboBox != null & currentValueExpression != null)
                        {
                            if (currentTypeComboBox.Text != "" && currentValueExpression.Text != "")
                            {
                                insertIntoArray(ref parameterNamesArray, i - 1, StringUtilities.addDoubleQuotesAroundString(currentNameLabel.Text));
                                insertIntoArray(ref parameterTypesArray, i - 1, StringUtilities.addDoubleQuotesAroundString(currentTypeComboBox.Text.ToString()));
                                insertIntoArray(ref parameterValuesArray, i - 1, currentValueExpression.Text);
                            }
                        
                            if (sequenceFileExp == "" || currentTypeComboBox.Text == "" || currentValueExpression.Text == "")
                            {
                                errorStatus = true;
                            }
                        }
                    }
                    catch (System.NullReferenceException ex)
                    {
                        //do nothing                   
                    }
                }
            }

            return errorStatus;
        }

        private static bool isNotNull(SequenceCallInfo n)
        {
            return n != null;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            
            //Setting Variables this way is necessary for them to persist when TestStand Closes and is Opened again
            if (!ProcessSequenceParameters())
            {
                try
                {
                    stepPropertyObject.SetValNumber("Veristand.Timeout", 0, (double)Timeout.Value);
                    stepPropertyObject.SetValString("Veristand.Target", 0, target);
                    seqContext.SequenceFile.FileGlobalsDefaultValues.SetValIDispatch("Veristand.StimulusProfileReference", 1, null);
                    seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.StimulusProfileReference", 0, 0x4400000);
                    stepPropertyObject.SetValVariant("Veristand.SequenceFilePath", 0, StringUtilities.parseFilePathString(sequenceFileExp));
                    stepPropertyObject.SetValVariant("Veristand.ParamNamesArray", 0, StringUtilities.stringArrayToExpressionArray(parameterNamesArray));
                    stepPropertyObject.SetValVariant("Veristand.ParamValuesArray", 0, StringUtilities.stringArrayToExpressionArray(parameterValuesArray));
                    stepPropertyObject.SetValVariant("Veristand.ParamTypesArray", 0, StringUtilities.stringArrayToExpressionArray(parameterTypesArray));
                    stepPropertyObject.SetValString("Veristand.NumericDataType", 0, StringUtilities.addDoubleQuotesAroundString(returnParamDataType));
                    propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*) 
                }
                catch (System.NullReferenceException ex)
                {
                    //do nothing
                }
                catch (System.ArgumentNullException ex)
                {
                    //do nothing
                }
                this.Close(); //Close the form
            }
            else
            {
                VSDialogs dialogs = new VSDialogs();
                dialogs.ShowWarningDialog("Please specify all Parameters.");
            }
        }

        private void FilePath_TextChanged(object sender, EventArgs e)
        {
            sequenceFileExp = this.FilePath.Text;
            if(System.IO.File.Exists(StringUtilities.unparseFilePathString(sequenceFileExp))) //Check to see if the currently entered path is a valid filename
            {
                string extension = System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(sequenceFileExp));
                if (extension == ".csv" || extension == ".nivsseq") //Check to make sure we have a valid file extension
                {
                    InitializeTableView(seqContext, sequenceFileExp, parameterValuesArray, parameterTypesArray, true);  //Fill grid in with current file data
                }
                else
                {
                    VSDialogs dialogs = new VSDialogs();
                    dialogs.ShowWarningDialog("Invalid File Extension:"+extension+"\n Please select a .csv or .nivsseq file");
                }
            }
        }
        void insertIntoArray<T>(ref T[] inputArray,int index, T element)
        {
            List<T> inputList = inputArray.ToList();
            try
            {
                inputList.RemoveAt(index);
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //No element currently in the list
            }
            try
            {
                inputList.Insert(index, element);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                
            }
            
            inputArray = inputList.ToArray();
        }
        void deleteElementFromArray<T>(ref T[] inputArray, int index)
        {
            List<T> inputList = inputArray.ToList();
            try
            {
                inputList.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //No element currently in the list
            }
            inputArray = inputList.ToArray();
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            InitializeTableView(seqContext, "", parameterValuesArray, parameterTypesArray, true);  //Clear the grid
            this.tableLayoutPanel1.RowCount = 1;
            TableLayoutRowStyleCollection rowStyles = this.tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in rowStyles)
            {
                if (style.SizeType == SizeType.AutoSize)
                {
                    style.SizeType = SizeType.Percent;
                }
            }
            this.FilePath.Text = "";
            this.returnParameterTextBox1.Text = "";
            Array.Resize(ref parameterValuesArray,0);
            Array.Resize(ref parameterNamesArray, 0);
            Array.Resize(ref  parameterTypesArray, 0);
        }

        private void tableLayoutPanel1_Clicked(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel1.CanFocus)
                this.tableLayoutPanel1.Focus();
        }

        private void ConfigureRTSequenceNative_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.tableLayoutPanel1.CanFocus)
                this.tableLayoutPanel1.Focus();
        }

        private void TargetSelect_Click(object sender, EventArgs e)
        {
            SelectTargetDialog dialog = new SelectTargetDialog(sysDefPath, target);
            dialog.ShowDialog();
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("VeriStand.SystemDefinitionPath", 1, dialog.SysDefPath);
            target = dialog.SelectedTarget;
            targetString.Text = target;
            sysDefPath = dialog.SysDefPath;
        }
    }
}
