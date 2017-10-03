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
    public partial class StimulusProfileDialog : Form
    {
        //TestStand Objects
        string stepID;
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        PropertyObject stepPropertyObject;
        public StimulusProfileDialog(SequenceContext _seqContext)
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


            EvaluationTypes eval = seqContext.Engine.NewEvaluationTypes();
            eval.PropertyValueTypeFlags = 0x4;
            stimulusProfilePath_exp.SetValidEvaluationTypes(eval);
            stimulusProfilePath_exp.Context = seqContextPO;
            gatewayIP_exp.SetValidEvaluationTypes(eval);
            gatewayIP_exp.Context = seqContextPO;
            uut_exp.SetValidEvaluationTypes(eval);
            uut_exp.Context = seqContextPO;
            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();

            try
            {
                    this.stimulusProfilePath_exp.Text = StringUtilities.addDoubleQuotesAroundString(stepPropertyObject.GetValString("Veristand.StimulusProfilePath", 0));
                    this.gatewayIP_exp.Text = StringUtilities.addDoubleQuotesAroundString(seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.GatewayIP", 0));
                    this.uut_exp.Text = StringUtilities.addDoubleQuotesAroundString(stepPropertyObject.GetValString("Veristand.UUT", 0));
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                //Variables are not already created. They will be created later
                this.gatewayIP_exp.Text = StringUtilities.addDoubleQuotesAroundString("localhost");
                this.stimulusProfilePath_exp.Text = StringUtilities.addDoubleQuotesAroundString("");
                this.uut_exp.Text = StringUtilities.addDoubleQuotesAroundString("0");

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;     
            this.stimulusProfilePath_exp.Text = StringUtilities.parseFilePathString(openFile.FileName);
           
        }

        private void OK_Click(object sender, EventArgs e)
        {
            stepPropertyObject.SetValString("Veristand.StimulusProfilePath", 0, StringUtilities.addDoubleQuotesAroundString(this.stimulusProfilePath_exp.Text));
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValIDispatch("Veristand.StimulusProfileReference", 1, null);
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.StimulusProfileReference", 0, 0x4400000);

            if (!seqContext.SequenceFile.FileGlobalsDefaultValues.Exists("Veristand.GatewayIP", 0))
            {
                seqContext.SequenceFile.FileGlobalsDefaultValues.NewSubProperty("Veristand.GatewayIP", PropertyValueTypes.PropValType_NamedType, false, "Expression", 1);
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.GatewayIP", 0, 0x4400000);
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.GatewayIP", 0, StringUtilities.addDoubleQuotesAroundString(this.gatewayIP_exp.Text));
            }
            else
            {
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.GatewayIP", 0, StringUtilities.addDoubleQuotesAroundString(this.gatewayIP_exp.Text));
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.GatewayIP", 0, 0x4400000);
            }
            stepPropertyObject.SetValString("Veristand.UUT", 1, StringUtilities.addDoubleQuotesAroundString(this.uut_exp.Text));
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)
            this.Close();
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click_1(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }
    }
}
