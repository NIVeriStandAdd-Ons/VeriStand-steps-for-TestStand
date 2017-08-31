using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;
using System.Reflection;
using System.Text.RegularExpressions;

namespace OpenWorkspaceDialog
{
    public partial class AdvancedLoggingProperties : Form
    {
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        string stepID;
        PropertyObject stepPropertyObject;
        ConfigureLoggingFile CallingFormGlobal;
        public List<string> filePropertyNames;
        public List<string> filePropertyValues;
//        public string dataGridView_ToolTipText = 
//@"Lists the File Properties written to the TDMS log file.
//
//For each property, the following information is stored:
//Name (string)
//Data type (tdsDataType)
//Value (strings are encoded in UTF-8 Unicode).
//
//Strings in TDMS files can be null-terminated, but since the length
//information is stored, the null terminator will be ignored when
//you read from the file.";

        public AdvancedLoggingProperties(SequenceContext _seqContext, ConfigureLoggingFile CallingForm)
        {
            InitializeComponent();
            CallingFormGlobal = CallingForm;
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
            FileDescription_text.Text = CallingForm.fileDescription;
            filePropertyNames = CallingFormGlobal.filePropertyNames;
            filePropertyValues = CallingFormGlobal.filePropertyValues;

            InitializeFilePropertiesDataGridView();
            VSDialogs vsdiag = new VSDialogs();
            //this.OK.Click +=new EventHandler(OK_Click,new EventArgs(_fileAuthor));
        }
        private void InitializeFilePropertiesDataGridView()
        {
            this.dataGridView1.Rows.Clear(); //Empty the grid
            if (filePropertyNames.Count > 0)  //Don't try to initialize with an empty FilePropertyNames array
            {
                for (int i = 0; i < filePropertyNames.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, i].Value = filePropertyNames[i];
                }
                for (int i = 0; i < filePropertyValues.Count; i++)
                {
                    dataGridView1[1, i].Value = filePropertyValues[i];
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            CallingFormGlobal.fileDescription = FileDescription_text.Text;
            CallingFormGlobal.filePropertyNames.Clear();
            CallingFormGlobal.filePropertyValues.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow != true && dataGridView1[0, i].Value != null && dataGridView1[1, i].Value != null)
                {
                    CallingFormGlobal.filePropertyNames.Add(dataGridView1[0, i].Value.ToString());
                    CallingFormGlobal.filePropertyValues.Add(dataGridView1[1, i].Value.ToString());
                }
            }

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFileProperty_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            if (dataGridView1.CanFocus)
            {
                dataGridView1.Focus();
            }

        }

        private void removeFileProperty_button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
            
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (r.IsNewRow != true)
                {
                    dataGridView1.Rows.Remove(r);
                }
            }
        }
    }
}
