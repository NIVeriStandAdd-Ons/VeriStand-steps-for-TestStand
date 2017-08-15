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
using NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi;
using NationalInstruments.VeriStand.Data;
using System.Collections.Concurrent;
namespace OpenWorkspaceDialog
{
    public partial class ConfigureRTSequence : Form
    {
       string StimProfilePathStr;
       public const int maxNumberOfSequences = 100;
    
        SequenceCallInfo seqCallInfo;
        SequenceCallInfo[] seqCallInfoArray = new SequenceCallInfo[maxNumberOfSequences];
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        PropertyObject stepPropertyObject;
        bool autostart;
        
       
        uint timeout;
        int selectedSequence;
        string stepID;
        ConcurrentQueue<SequenceCallInfo[]> cq;  //Queue used to pass objects back to calling thread
        string[] sequenceNames;
        string[] parameterTypes;
        string[] parameterValues;
        string[] parameterNames;
        
        int numSequences;
        public ConfigureRTSequence(SequenceContext _seqContext, ConcurrentQueue<SequenceCallInfo[]> _cq)
        {
            
            InitializeComponent();
           
            seqContext = _seqContext;      
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;
            propObjectFile = seqFile.AsPropertyObjectFile();
            VSDialogs vsdiag= new VSDialogs();
            
            cq = _cq;
            selectedSequence = 0;
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
                
            
            //Get old values if they exist
            try
            {
                autostart = stepPropertyObject.GetValBoolean("Veristand.StimProfAutoStart", 0);
                this.auto_start.Checked = autostart;
                timeout = (uint)stepPropertyObject.GetValNumber("Veristand.StimProfTimeout", 0);           
                this.rtseq_timeout.Value = timeout;
                this.sessionName_Control.Text = stepPropertyObject.GetValString("Veristand.RTSessionName", 0);
                sequenceNames =Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.SequenceNames", 0),o=>o.ToString());
                parameterValues = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.ParamValues", 0),o=>o.ToString());
                parameterTypes = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.ParamTypes", 0),o=>o.ToString());
                parameterNames = Array.ConvertAll((object[])stepPropertyObject.GetValVariant("Veristand.ParamNames", 0), o => o.ToString());        
                numSequences = (int)stepPropertyObject.GetValNumber("Veristand.RTNumSequences", 0);
                try
                {

                    InitializeDataGridView(sequenceNames[0], parameterValues, parameterTypes, numSequences, 0); //Initialize the data grid with the previously selected data
                    this.FilePath.Text = sequenceNames[0];
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
                
                autostart = false;
                StimProfilePathStr = "";
                this.auto_start.Checked = autostart;
                this.FilePath.Text = StimProfilePathStr;
                timeout = 1000;
                this.rtseq_timeout.Value = timeout;
                this.sessionName_Control.Text = "Session 1";

            }
            
            
        }

        private void rtseq_timeout_ValueChanged(object sender, EventArgs e)
        {
           timeout=(uint)rtseq_timeout.Value;
        }

        private void auto_start_CheckedChanged(object sender, EventArgs e)
        {
            autostart = this.auto_start.Checked;
        }

  
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            StimProfilePathStr = openFile.FileName;
            this.FilePath.Text = StimProfilePathStr;
            InitializeDataGridView(StimProfilePathStr, parameterValues, parameterTypes,numSequences, selectedSequence);
            
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProcessSequenceParameters()
        {
            SequenceParameterAssignmentInfo[] seqParametersInfo = new SequenceParameterAssignmentInfo[this.dataGridView1.Rows.Count];
            string text = "";
            bool allFieldsComplete = true;
            string paramValuesExpString = "{";
            string paramNamesExpString = "{";
            string paramTypesExpString = "{";

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
               
                if (this.dataGridView1[1, i].Value != null && this.dataGridView1[2, i].Value != null)
                {
                    paramNamesExpString+=this.dataGridView1[0, i].Value.ToString()+",";
                    paramValuesExpString += this.dataGridView1[2, i].Value.ToString() + ",";
                    paramTypesExpString += this.dataGridView1[1, i].Value.ToString() + ",";
                    try
                    {
                        switch (this.dataGridView1[1, i].Value.ToString())
                        {//Initialize the correct type of parameter based on the Users Type setting
                            case "Path":
                                SystemDefinitionChannelResource sysDefChannel = new SystemDefinitionChannelResource(this.dataGridView1[2, i].Value.ToString());
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), sysDefChannel);

                                break;
                            case "Boolean":
                                BooleanValue boolVal = new BooleanValue(Convert.ToBoolean(this.dataGridView1[2, i].Value.ToString()));
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), boolVal);
                                break;
                            case "Double":
                                DoubleValue doubleVal = new DoubleValue(Convert.ToDouble(this.dataGridView1[2, i].Value.ToString()));
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), doubleVal);
                                break;
                            case "I32":
                                I32Value i32Val = new I32Value(Convert.ToInt32(this.dataGridView1[2, i].Value.ToString()));
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), i32Val);
                                break;
                            case "I64":
                                I64Value i64Val = new I64Value(Convert.ToInt64(this.dataGridView1[2, i].Value.ToString()));
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), i64Val);
                                break;
                            case "U32":
                                U32Value u32Val = new U32Value(Convert.ToUInt32(this.dataGridView1[2, i].Value.ToString()));
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), u32Val);
                                break;
                            case "U64":
                                U64Value u64Val = new U64Value(Convert.ToUInt64(this.dataGridView1[2, i].Value.ToString()));
                                seqParametersInfo[i] = new SequenceParameterAssignmentInfo(this.dataGridView1[0, i].Value.ToString(), u64Val);
                                break;
                        }
                    }
                    catch (System.FormatException ex)
                    {
                        //Incorrect datatype was entered in the RT sequence window
                        VSDialogs dialogs = new VSDialogs();
                        dialogs.ShowWarningDialog(ex.Message + "------" + ex.StackTrace);
                    }
                }
                else
                {
                    allFieldsComplete = false;
                    
                }

            }
           
           
          

            //If sequence information already exists for the selected sequence replace it. If not insert new elements into array

            if (allFieldsComplete&&StimProfilePathStr!="")
            {//Only try to create an seqCallInfo object if all fields have been initialized
             
                //Create SequenceCallInfo Object 
                seqCallInfo = new SequenceCallInfo(StimProfilePathStr, "", seqParametersInfo, false, 1000);

                insertIntoArray(ref seqCallInfoArray, selectedSequence, seqCallInfo);
                paramValuesExpString = paramValuesExpString.Remove(paramValuesExpString.Length - 1) + "}";  //remove trailing comma and add in a clsoing }
                paramNamesExpString = paramNamesExpString.Remove(paramNamesExpString.Length - 1) + "}";
                paramTypesExpString = paramTypesExpString.Remove(paramTypesExpString.Length - 1) + "}";

                insertIntoArray(ref parameterValues, selectedSequence, paramValuesExpString);
                insertIntoArray(ref parameterNames, selectedSequence, paramNamesExpString);
                insertIntoArray(ref parameterTypes, selectedSequence, paramTypesExpString);
            }
            else
            {
                VSDialogs dialogs = new VSDialogs();
                dialogs.ShowWarningDialog("Active sequence information not processesed because not all parameters have been specified");
            }
            
        }
        private static bool isNotNull(SequenceCallInfo n)
        {
            return n != null;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            
            //Setting Variables this way is necessary for them to persist when TestStand Closes and is Opened again
            ProcessSequenceParameters();
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValIDispatch("Veristand.StimulusProfileReference", 1, null);
            stepPropertyObject.SetValBoolean("Veristand.StimProfAutoStart", 1, autostart);
            stepPropertyObject.SetValNumber("Veristand.StimProfTimeout", 1, timeout);
            stepPropertyObject.SetValString("Veristand.RTSessionName", 1, this.sessionName_Control.Text);
            stepPropertyObject.SetValVariant("Veristand.ParamNames", 0, parameterNames);
            stepPropertyObject.SetValVariant("Veristand.SequenceNames", 0, sequenceNames);
            stepPropertyObject.SetValVariant("Veristand.ParamValues", 0, parameterValues);
            stepPropertyObject.SetValVariant("Veristand.ParamTypes", 0, parameterTypes);
           
            
            try
            {            
                seqCallInfoArray = Array.FindAll(seqCallInfoArray, isNotNull).ToArray();//return all non-null entries
                stepPropertyObject.SetValNumber("Veristand.RTNumSequences", 1, (uint)seqCallInfoArray.Length);
                cq.Enqueue(seqCallInfoArray); //Send the sequence call info object back to the original thread so it can be returned to TestStand
                //The normal method I had been using of setting the object directly in TestStand through ActiveX does not work for this object
                //type because it could not be converted properly 
                
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                VSDialogs dialogs = new VSDialogs();
                dialogs.ShowWarningDialog(ex.Message + "------" + ex.StackTrace);
            }
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)     
            this.Close(); //Close the form
        }
      
        private void sequenceSelector_Control_ValueChanged(object sender, EventArgs e)
        {
            List<string> seqNamesList = sequenceNames.ToList();
            try
            {
                seqNamesList.RemoveAt(selectedSequence);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //No element currently in the list
            }
            seqNamesList.Insert(selectedSequence, this.FilePath.Text);
            sequenceNames = seqNamesList.ToArray();
            ProcessSequenceParameters(); //Save the information about the previous selection
            selectedSequence = (int)this.sequenceSelector_Control.Value;       
            try
            {
                //Populate the data value grid with what we know
                this.FilePath.Text = sequenceNames[selectedSequence];
                StimProfilePathStr = sequenceNames[selectedSequence];
                InitializeDataGridView(sequenceNames[selectedSequence], parameterValues, parameterTypes, numSequences, selectedSequence);
            }
            catch(System.IndexOutOfRangeException ex)
            {
                InitializeDataGridView("", parameterValues, parameterTypes, numSequences, selectedSequence);
                this.FilePath.Text = "";
                StimProfilePathStr = "";
            }
    
        }

        private void FilePath_TextChanged(object sender, EventArgs e)
        {
            StimProfilePathStr = this.FilePath.Text;
            if(System.IO.File.Exists(StimProfilePathStr)) //Check to see if the currently entered path is a valid filename
            {
                string extension = System.IO.Path.GetExtension(StimProfilePathStr);
                if (extension == ".csv" || extension == ".nivsseq") //Check to make sure we have a valid file extension
                {
                    insertIntoArray(ref sequenceNames, selectedSequence, this.FilePath.Text);
                    
                    InitializeDataGridView(StimProfilePathStr, parameterValues, parameterTypes, numSequences, selectedSequence);  //Fill grid in with current file data
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
            InitializeDataGridView("", parameterValues, parameterTypes, numSequences, selectedSequence);  //Clear the grid
            this.FilePath.Text = "";  
            deleteElementFromArray(ref seqCallInfoArray,selectedSequence);
            deleteElementFromArray(ref parameterValues,selectedSequence);
            deleteElementFromArray(ref parameterNames, selectedSequence);
            deleteElementFromArray(ref  parameterTypes, selectedSequence);
            deleteElementFromArray(ref  sequenceNames, selectedSequence);
            
        }

       
    }
}
