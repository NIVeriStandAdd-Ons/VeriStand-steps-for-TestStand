using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi;
using System.Collections;
namespace OpenWorkspaceDialog
{
    public partial class ConfigureSequenceName : Form
    {
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        string stepID;
        SequenceCallInfo[] seqCallInfoArray;
        string[] allSequenceNames;
        public ConfigureSequenceName(SequenceContext _seqContext)
        {
            InitializeComponent();

            seqContext = _seqContext;
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;  
            seqContextPO = selectedTSSequence.Locals;
            int thisStepIndex = selectedTSStep.StepIndex;
            propObjectFile = seqFile.AsPropertyObjectFile();
            try
            {

                this.sequenceName_Control.Text = seqContextPO.GetValString("Veristand." + stepID + "RTSequenceName", 0);
               
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                //If variables don't exist set default values
                this.sequenceName_Control.Text = "";
                
            }
            int count=thisStepIndex;
            bool found=false;
            while(count>=0&&found==false)
            {
                Step currentStep=selectedTSSequence.GetStep(count, StepGroups.StepGroup_Main);
                if (currentStep.Name == "Open and Deploy RT Sequence") //This will need to change if the name of the Open RT Sequence Name Step Changes
                {
                    //this is the open RTSequence step that is the closes previous to this step name configuration
                    string openRTSequenceStepID = currentStep.UniqueStepId;
                    VSDialogs vsdiags = new VSDialogs();
                    try //When this does and does not exist is different from the RTSequenceName so it needs its own Try/Catch block
                    {
                 
                        seqCallInfoArray = vsdiags.ReinitializeSequenceCallInfo(seqContext, openRTSequenceStepID);//Get the sequence info created by the Open RT Sequence Step
                        allSequenceNames = ParseNamesFromSequenceCallInfo(seqCallInfoArray);//Populate the parsed list of sequence names
                        if (allSequenceNames.Length > 0)
                        {
                            if (allSequenceNames[0] != null)
                            {
                                //Set the sequence name control to the first name we parsed
                                this.sequenceName_Control.Text = allSequenceNames[0];
                            }
                            else
                            {
                                this.sequenceName_Control.Text = "";
                            }
                        }

                    }
                    catch (System.Runtime.InteropServices.COMException)
                    {
                        seqCallInfoArray = null;
                    }
                }
                count--;
            }
           

        }
   
        private string[] ParseNamesFromSequenceCallInfo(SequenceCallInfo[] seqCallInfoArr)
        {
            //Gets the sequence names from the sequence call info
            //This is found by parsing the list of sequences to find duplicate sequences and incrementing the instance number for each duplicate
            try
            {
                
                string[] sequenceNames = new string[seqCallInfoArray.Length];
                Hashtable seqNameTable = new Hashtable();
                int count = 0;
                foreach (SequenceCallInfo seqInfo in seqCallInfoArray)
                {
                    string fullSequencePath = seqInfo.SequencePath;
                    string sequenceName = Path.GetFileNameWithoutExtension(fullSequencePath);
                    if (seqNameTable.ContainsKey(sequenceName))
                    {
                        int instance = (int)seqNameTable[sequenceName];
                        instance++;
                        seqNameTable[sequenceName] = instance;
                        sequenceNames[count] = sequenceName + ":" + instance.ToString();
                    }
                    else
                    {
                        seqNameTable.Add(sequenceName, 1);
                        sequenceNames[count] = sequenceName + ":1";
                    }
                    count++;
                }
                return sequenceNames;
            }
            catch (System.NullReferenceException ex)
            {
                VSDialogs dialogs = new VSDialogs();
                dialogs.ShowWarningDialog("RT Sequence Information Not Found\n\n" + ex.Message + "------" + ex.StackTrace);
                string[] name = { "No Sequence Found" };
                return name;
            }
           
        }
  

        private void ok_button_Click(object sender, EventArgs e)
        {

            seqContextPO.SetValString("Veristand." + stepID + "RTSequenceName", 1, this.sequenceName_Control.Text);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)    
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sequenceNumber_control_ValueChanged(object sender, EventArgs e)
        {
            if (allSequenceNames.Length > sequenceNumber_control.Value)
            {
                if (allSequenceNames[(uint)sequenceNumber_control.Value] != null)
                {
                    //Set the sequence name control to the first name we parsed
                    this.sequenceName_Control.Text = allSequenceNames[(uint)sequenceNumber_control.Value];
                }
                else
                {
                    this.sequenceName_Control.Text = "";
                }
            }
            else
            {
                this.sequenceName_Control.Text = "";
            }
        }

       
    }
}
