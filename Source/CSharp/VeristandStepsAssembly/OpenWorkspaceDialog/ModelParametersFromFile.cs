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
namespace OpenWorkspaceDialog
{
    public partial class ModelParametersFromFile : Form
    {
        string stepID;
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        PropertyObject stepPropertyObject;
        public ModelParametersFromFile(SequenceContext _seqContext)
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
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            EvaluationTypes evalString = seqContext.Engine.NewEvaluationTypes();
            evalString.PropertyValueTypeFlags = 0x4; //set string as the valid evaluation type
            target_exp.SetValidEvaluationTypes(evalString);
            target_exp.Context = seqContextPO;
            EvaluationTypes evalStringArray = seqContext.Engine.NewEvaluationTypes();
            evalStringArray.PropertyValueTypeFlags = 0x100; //set string array as the valid evaluation type
            parameterfile_exp.SetValidEvaluationTypes(evalStringArray);
            parameterfile_exp.Context = seqContextPO;
            //Get old values if they exist
            try
            {
                this.parameterfile_exp.Text = stepPropertyObject.GetValString("Veristand.ModelParameterFilepath", 0);
                this.target_exp.Text = stepPropertyObject.GetValString("Veristand.TargetName", 0);
                
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                //Variables are not already created. They will be created later
                this.parameterfile_exp.Text = "";
                this.target_exp.Text = "";

            }
        }

        private void OK_Click(object sender, EventArgs e)
        {          
            stepPropertyObject.SetValString("Veristand.ModelParameterFilepath", 1, this.parameterfile_exp.Text);
            stepPropertyObject.SetValString("Veristand.TargetName", 1, this.target_exp.Text);
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
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            this.parameterfile_exp.Text = StringUtilities.stringArrayToExpressionArray(new string[] {StringUtilities.parseFilePathString(openFile.FileName)});
        }

 

       
    }
}
