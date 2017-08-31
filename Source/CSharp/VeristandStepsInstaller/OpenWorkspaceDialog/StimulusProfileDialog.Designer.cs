namespace OpenWorkspaceDialog
{
    partial class StimulusProfileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StimulusProfileDialog));
            this.stimulusProfilePath_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.SystemDefinitionPathLabel = new System.Windows.Forms.Label();
            this.gatewayIP_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.GatewayIPLabel = new System.Windows.Forms.Label();
            this.uut_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stimulusProfilePath_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayIP_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uut_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // stimulusProfilePath_exp
            // 
            this.stimulusProfilePath_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stimulusProfilePath_exp.Location = new System.Drawing.Point(123, 45);
            this.stimulusProfilePath_exp.Name = "stimulusProfilePath_exp";
            this.stimulusProfilePath_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("stimulusProfilePath_exp.OcxState")));
            this.stimulusProfilePath_exp.Size = new System.Drawing.Size(317, 19);
            this.stimulusProfilePath_exp.TabIndex = 16;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(283, 142);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(186, 142);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 13;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(457, 43);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 12;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click_1);
            // 
            // SystemDefinitionPathLabel
            // 
            this.SystemDefinitionPathLabel.AutoSize = true;
            this.SystemDefinitionPathLabel.Location = new System.Drawing.Point(9, 48);
            this.SystemDefinitionPathLabel.Name = "SystemDefinitionPathLabel";
            this.SystemDefinitionPathLabel.Size = new System.Drawing.Size(103, 13);
            this.SystemDefinitionPathLabel.TabIndex = 15;
            this.SystemDefinitionPathLabel.Text = "Stimulus Profile Path";
            // 
            // gatewayIP_exp
            // 
            this.gatewayIP_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gatewayIP_exp.Location = new System.Drawing.Point(123, 9);
            this.gatewayIP_exp.Name = "gatewayIP_exp";
            this.gatewayIP_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gatewayIP_exp.OcxState")));
            this.gatewayIP_exp.Size = new System.Drawing.Size(317, 19);
            this.gatewayIP_exp.TabIndex = 18;
            // 
            // GatewayIPLabel
            // 
            this.GatewayIPLabel.AutoSize = true;
            this.GatewayIPLabel.Location = new System.Drawing.Point(57, 12);
            this.GatewayIPLabel.Name = "GatewayIPLabel";
            this.GatewayIPLabel.Size = new System.Drawing.Size(59, 13);
            this.GatewayIPLabel.TabIndex = 17;
            this.GatewayIPLabel.Text = "GatewayIP";
            // 
            // uut_exp
            // 
            this.uut_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uut_exp.Location = new System.Drawing.Point(123, 84);
            this.uut_exp.Name = "uut_exp";
            this.uut_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("uut_exp.OcxState")));
            this.uut_exp.Size = new System.Drawing.Size(317, 19);
            this.uut_exp.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "UUT";
            // 
            // StimulusProfileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uut_exp);
            this.Controls.Add(this.gatewayIP_exp);
            this.Controls.Add(this.GatewayIPLabel);
            this.Controls.Add(this.stimulusProfilePath_exp);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SystemDefinitionPathLabel);
            this.MinimumSize = new System.Drawing.Size(560, 215);
            this.Name = "StimulusProfileDialog";
            this.Text = "Stimulus Profile Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.stimulusProfilePath_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayIP_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uut_exp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void OpenBrowseFileDialog()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.DefaultExt = ".nivsproj";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select Veristand Stimulus Profile File";
            this.openFileDialog1.Filter = "Veristand Stimulus Profile(*.nivsstimprof)|*.nivsstimprof";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
        #endregion

        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit stimulusProfilePath_exp;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label SystemDefinitionPathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit gatewayIP_exp;
        private System.Windows.Forms.Label GatewayIPLabel;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit uut_exp;
        private System.Windows.Forms.Label label1;
    }
}