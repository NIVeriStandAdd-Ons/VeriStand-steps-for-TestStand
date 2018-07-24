/* Configure Legacy Stimulus Profile
 * This dialog sets the calls for a Legacy Stimulus Profile (.nivstest)
 * 
 * 
 * */

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
    public partial class ConfigureLegacyStimulusProfile : Form
    {
        string StimProfilePathStr;
        bool autostart;
        bool stopOnDisconnect;
        uint timeout;

       //TestStand Variables
        string stepID;
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
     

        public ConfigureLegacyStimulusProfile(SequenceContext _seqContext)
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

            //Get old values if they exist
            try
            {
                autostart = seqContextPO.GetValBoolean("Locals.Veristand.StimProfAutoStart"+stepID, 0);
                this.AutoStart.Checked = autostart;
                StimProfilePathStr = seqContextPO.GetValString("Locals.Veristand.StimProfPath" + stepID, 0);
                this.FilePath.Text = StimProfilePathStr;
                timeout = (uint)seqContextPO.GetValNumber("Locals.Veristand.StimProfTimeout" + stepID, 0);
                this.Timeout.Value = timeout;
                stopOnDisconnect = seqContextPO.GetValBoolean("Locals.Veristand.StimProfStopOnDisconnect" + stepID, 0);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                //Variables are not already created in TestStand. They will be created later
                autostart = false;
                StimProfilePathStr = "";
                this.AutoStart.Checked = autostart;
                this.FilePath.Text = StimProfilePathStr;
                timeout = 1000;
                this.Timeout.Value = timeout;
                stopOnDisconnect = false;
                this.StopDisconnect.Checked = stopOnDisconnect;

            }
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            permSeqContext.SetValIDispatch("Veristand.StimulusProfileReference" + stepID, 1, null);
            permSeqContext.SetValBoolean("Veristand.StimProfAutoStart" + stepID, 1, autostart);
            permSeqContext.SetValString("Veristand.StimProfPath" + stepID, 1, StimProfilePathStr);
            permSeqContext.SetValNumber("Veristand.StimProfTimeout" + stepID, 1, timeout);
            permSeqContext.SetValBoolean("Veristand.StimProfStopOnDisconnect" + stepID, 1, stopOnDisconnect);
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

        private void AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            autostart = this.AutoStart.Checked;
        }

        private void StopDisconnect_CheckedChanged(object sender, EventArgs e)
        {
            stopOnDisconnect = this.StopDisconnect.Checked;
        }

        private void Timeout_ValueChanged(object sender, EventArgs e)
        {
            timeout = (uint)this.Timeout.Value;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            StimProfilePathStr = openFile.FileName;
            this.FilePath.Text = StimProfilePathStr;
         
        }
       

    
    }
}
