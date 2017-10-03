namespace OpenWorkspaceDialog
{
    partial class ModelParametersFromFile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelParametersFromFile));
            this.Browse = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.parameter_file_label = new System.Windows.Forms.Label();
            this.target_label = new System.Windows.Forms.Label();
            this.target_explanation = new System.Windows.Forms.Label();
            this.target_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.parameterfile_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            ((System.ComponentModel.ISupportInitialize)(this.target_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterfile_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(342, 18);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(228, 138);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(131, 138);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // parameter_file_label
            // 
            this.parameter_file_label.AutoSize = true;
            this.parameter_file_label.Location = new System.Drawing.Point(16, 23);
            this.parameter_file_label.Name = "parameter_file_label";
            this.parameter_file_label.Size = new System.Drawing.Size(74, 13);
            this.parameter_file_label.TabIndex = 11;
            this.parameter_file_label.Text = "Parameter File";
            // 
            // target_label
            // 
            this.target_label.AutoSize = true;
            this.target_label.Location = new System.Drawing.Point(21, 62);
            this.target_label.Name = "target_label";
            this.target_label.Size = new System.Drawing.Size(69, 13);
            this.target_label.TabIndex = 12;
            this.target_label.Text = "Target Name";
            // 
            // target_explanation
            // 
            this.target_explanation.AutoSize = true;
            this.target_explanation.Location = new System.Drawing.Point(93, 87);
            this.target_explanation.Name = "target_explanation";
            this.target_explanation.Size = new System.Drawing.Size(302, 13);
            this.target_explanation.TabIndex = 14;
            this.target_explanation.Text = "Name of target as defined in System Definition (e.g. \'Controller\')";
            // 
            // target_exp
            // 
            this.target_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.target_exp.Location = new System.Drawing.Point(96, 56);
            this.target_exp.Name = "target_exp";
            this.target_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("target_exp.OcxState")));
            this.target_exp.Size = new System.Drawing.Size(240, 19);
            this.target_exp.TabIndex = 15;
            // 
            // parameterfile_exp
            // 
            this.parameterfile_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameterfile_exp.Location = new System.Drawing.Point(93, 20);
            this.parameterfile_exp.Name = "parameterfile_exp";
            this.parameterfile_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("parameterfile_exp.OcxState")));
            this.parameterfile_exp.Size = new System.Drawing.Size(243, 19);
            this.parameterfile_exp.TabIndex = 16;
            // 
            // ModelParametersFromFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 173);
            this.Controls.Add(this.parameterfile_exp);
            this.Controls.Add(this.target_exp);
            this.Controls.Add(this.target_explanation);
            this.Controls.Add(this.target_label);
            this.Controls.Add(this.parameter_file_label);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.MinimumSize = new System.Drawing.Size(450, 211);
            this.Name = "ModelParametersFromFile";
            this.Text = "Model Parameters From File";
            ((System.ComponentModel.ISupportInitialize)(this.target_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterfile_exp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void OpenBrowseFileDialog()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.DefaultExt = ".nivsproj";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select Veristand Project File";
            this.openFileDialog1.Filter = "Veristand Model Parameter File(*.m)|*.m";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label parameter_file_label;
        private System.Windows.Forms.Label target_label;
        private System.Windows.Forms.Label target_explanation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit target_exp;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit parameterfile_exp;
    }
}