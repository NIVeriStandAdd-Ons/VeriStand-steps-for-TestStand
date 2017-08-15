using NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi;
namespace OpenWorkspaceDialog
{
    partial class ConfigureRTSequence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

     

     
        void InitializeDataGridView(string filepath,string[] _parameterValues,string[] _parameterTypes, int _numSequences,int sequenceNumber)
        {
            this.dataGridView1.Rows.Clear(); //Empty the grid
            if (filepath != null && filepath != ""&&System.IO.File.Exists(filepath))  //Don't try to initialize with a blank filepath
            {
                try
                {
                    RealTimeSequence newRTSeq = new RealTimeSequence(filepath);
                    ParameterDeclaration[] seqParam = newRTSeq.Variables.Parameters.Variables;
                    int n = 0;
                    string[] currentSeqParamValues;
                    string[] currentSeqParamTypes;
                    this.dataGridView1.Rows.Add(seqParam.Length);
                    try
                    {
                        currentSeqParamValues = StringUtilities.expressionArrayToStringArray(_parameterValues[sequenceNumber]);
                        currentSeqParamTypes = StringUtilities.expressionArrayToStringArray(_parameterTypes[sequenceNumber]);
                    }
                    catch (System.IndexOutOfRangeException ex)
                    {
                        currentSeqParamValues = new string[0];
                        currentSeqParamTypes= new string[0];
                    }
                    foreach (ParameterDeclaration param in seqParam)
                    {
                        
                        this.dataGridView1[0, n].Value = param.Identifier;
                        try
                        {
                            if (n < currentSeqParamTypes.Length && n < currentSeqParamValues.Length)
                            {
                                this.dataGridView1[2, n].Value = currentSeqParamValues[n];
                                this.dataGridView1[1, n].Value = currentSeqParamTypes[n];
                            }
                        }
                        catch (System.Runtime.InteropServices.COMException ex)
                        {
                            //Intentionally do nothing for now. Might want to add a dialog here in the future
                        }
                        catch (System.NullReferenceException ex)
                        {
                        }
                        n++;
                    }
                }
                catch (System.ArgumentException)
                {
                    VSDialogs dialogs = new VSDialogs();
                    dialogs.ShowWarningDialog("Invalid Filepath:"+filepath);
                }
            }
             
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParameterType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath_Label = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.auto_start = new System.Windows.Forms.CheckBox();
            this.Timeout_Label = new System.Windows.Forms.Label();
            this.rtseq_timeout = new System.Windows.Forms.NumericUpDown();
            this.sessionName_Control = new System.Windows.Forms.TextBox();
            this.sessionName_label = new System.Windows.Forms.Label();
            this.sessionNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sequenceSelector_Control = new System.Windows.Forms.NumericUpDown();
            this.clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtseq_timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceSelector_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterName,
            this.ParameterType,
            this.ParameterValue});
            this.dataGridView1.Location = new System.Drawing.Point(16, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 244);
            this.dataGridView1.TabIndex = 6;
            // 
            // ParameterName
            // 
            this.ParameterName.Frozen = true;
            this.ParameterName.HeaderText = "Parameter Name";
            this.ParameterName.Name = "ParameterName";
            this.ParameterName.ReadOnly = true;
            // 
            // ParameterType
            // 
            this.ParameterType.HeaderText = "ParameterType";
            this.ParameterType.Items.AddRange(new object[] {
            "Path",
            "Boolean",
            "Double",
            "I32",
            "I64",
            "U32",
            "U64"});
            this.ParameterType.Name = "ParameterType";
            this.ParameterType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ParameterType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ParameterType.ToolTipText = "Type of Parameter [Path,Double,Boolean,I32,I64,U32,U64]";
            // 
            // ParameterValue
            // 
            this.ParameterValue.HeaderText = "Value";
            this.ParameterValue.Name = "ParameterValue";
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Location = new System.Drawing.Point(39, 17);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(100, 13);
            this.FilePath_Label.TabIndex = 16;
            this.FilePath_Label.Text = "Sequence File Path";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(414, 12);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(73, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(145, 13);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(263, 20);
            this.FilePath.TabIndex = 0;
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(291, 411);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(194, 411);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // auto_start
            // 
            this.auto_start.AutoSize = true;
            this.auto_start.Location = new System.Drawing.Point(145, 71);
            this.auto_start.Name = "auto_start";
            this.auto_start.Size = new System.Drawing.Size(79, 17);
            this.auto_start.TabIndex = 17;
            this.auto_start.Text = "Auto Start?";
            this.auto_start.UseVisualStyleBackColor = true;
            this.auto_start.CheckedChanged += new System.EventHandler(this.auto_start_CheckedChanged);
            // 
            // Timeout_Label
            // 
            this.Timeout_Label.AutoSize = true;
            this.Timeout_Label.Location = new System.Drawing.Point(94, 127);
            this.Timeout_Label.Name = "Timeout_Label";
            this.Timeout_Label.Size = new System.Drawing.Size(45, 13);
            this.Timeout_Label.TabIndex = 18;
            this.Timeout_Label.Text = "Timeout";
            // 
            // rtseq_timeout
            // 
            this.rtseq_timeout.Location = new System.Drawing.Point(145, 123);
            this.rtseq_timeout.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.rtseq_timeout.Name = "rtseq_timeout";
            this.rtseq_timeout.Size = new System.Drawing.Size(61, 20);
            this.rtseq_timeout.TabIndex = 5;
            this.rtseq_timeout.TabStop = false;
            this.rtseq_timeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rtseq_timeout.ValueChanged += new System.EventHandler(this.rtseq_timeout_ValueChanged);
            // 
            // sessionName_Control
            // 
            this.sessionName_Control.Location = new System.Drawing.Point(145, 94);
            this.sessionName_Control.Name = "sessionName_Control";
            this.sessionName_Control.Size = new System.Drawing.Size(263, 20);
            this.sessionName_Control.TabIndex = 4;
            this.sessionName_Control.Text = "Session1";
            this.sessionNameToolTip.SetToolTip(this.sessionName_Control, "Set the name for the Stimulus Profile Session");
            // 
            // sessionName_label
            // 
            this.sessionName_label.AutoSize = true;
            this.sessionName_label.Location = new System.Drawing.Point(56, 97);
            this.sessionName_label.Name = "sessionName_label";
            this.sessionName_label.Size = new System.Drawing.Size(75, 13);
            this.sessionName_label.TabIndex = 16;
            this.sessionName_label.Text = "Session Name";
            // 
            // sequenceSelector_Control
            // 
            this.sequenceSelector_Control.Location = new System.Drawing.Point(145, 45);
            this.sequenceSelector_Control.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.sequenceSelector_Control.Name = "sequenceSelector_Control";
            this.sequenceSelector_Control.Size = new System.Drawing.Size(61, 20);
            this.sequenceSelector_Control.TabIndex = 2;
            this.sequenceSelector_Control.ValueChanged += new System.EventHandler(this.sequenceSelector_Control_ValueChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(414, 51);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(73, 23);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sequence Number";
            // 
            // ConfigureRTSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.sequenceSelector_Control);
            this.Controls.Add(this.rtseq_timeout);
            this.Controls.Add(this.Timeout_Label);
            this.Controls.Add(this.auto_start);
            this.Controls.Add(this.sessionName_label);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.sessionName_Control);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(576, 484);
            this.Name = "ConfigureRTSequence";
            this.Text = "Configure Real Time Sequence";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtseq_timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceSelector_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OpenBrowseFileDialog()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.DefaultExt = ".nivsseq";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select Veristand Stimulus Profile File";
            this.openFileDialog1.Filter = "Veristand RT Sequence(*.nivsseq)|*.nivsseq|Comma Separated Value(*.csv)|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
   
       

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label FilePath_Label;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox auto_start;
        private System.Windows.Forms.Label Timeout_Label;
        private System.Windows.Forms.NumericUpDown rtseq_timeout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ParameterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterValue;
        private System.Windows.Forms.TextBox sessionName_Control;
        private System.Windows.Forms.Label sessionName_label;
        private System.Windows.Forms.ToolTip sessionNameToolTip;
        private System.Windows.Forms.NumericUpDown sequenceSelector_Control;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label1;
    }
   
}