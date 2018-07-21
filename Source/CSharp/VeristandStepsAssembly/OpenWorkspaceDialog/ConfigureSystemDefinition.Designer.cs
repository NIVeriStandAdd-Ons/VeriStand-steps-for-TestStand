namespace OpenWorkspaceDialog
{
    partial class ConfigureSystemDefinition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureSystemDefinition));
            this.Browse = new System.Windows.Forms.Button();
            this.SystemDefinitionPathLabel = new System.Windows.Forms.Label();
            this.GatewayIPLabel = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.systemDefinitionPath_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.deploysysdef_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefinitionPath_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deploysysdef_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(430, 53);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SystemDefinitionPathLabel
            // 
            this.SystemDefinitionPathLabel.AutoSize = true;
            this.SystemDefinitionPathLabel.Location = new System.Drawing.Point(40, 58);
            this.SystemDefinitionPathLabel.Name = "SystemDefinitionPathLabel";
            this.SystemDefinitionPathLabel.Size = new System.Drawing.Size(113, 13);
            this.SystemDefinitionPathLabel.TabIndex = 9;
            this.SystemDefinitionPathLabel.Text = "System Definition Path";
            // 
            // GatewayIPLabel
            // 
            this.GatewayIPLabel.AutoSize = true;
            this.GatewayIPLabel.Location = new System.Drawing.Point(23, 24);
            this.GatewayIPLabel.Name = "GatewayIPLabel";
            this.GatewayIPLabel.Size = new System.Drawing.Size(130, 13);
            this.GatewayIPLabel.TabIndex = 8;
            this.GatewayIPLabel.Text = "Deploy System Definition?";
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(172, 103);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(269, 103);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // systemDefinitionPath_exp
            // 
            this.systemDefinitionPath_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemDefinitionPath_exp.Location = new System.Drawing.Point(159, 55);
            this.systemDefinitionPath_exp.Name = "systemDefinitionPath_exp";
            this.systemDefinitionPath_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("systemDefinitionPath_exp.OcxState")));
            this.systemDefinitionPath_exp.Size = new System.Drawing.Size(265, 19);
            this.systemDefinitionPath_exp.TabIndex = 11;
            this.systemDefinitionPath_exp.Change += new System.EventHandler(this.systemDefinitionPath_exp_Change);
            // 
            // deploysysdef_exp
            // 
            this.deploysysdef_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deploysysdef_exp.Location = new System.Drawing.Point(159, 21);
            this.deploysysdef_exp.Name = "deploysysdef_exp";
            this.deploysysdef_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("deploysysdef_exp.OcxState")));
            this.deploysysdef_exp.Size = new System.Drawing.Size(265, 19);
            this.deploysysdef_exp.TabIndex = 10;
            // 
            // ConfigureSystemDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 138);
            this.Controls.Add(this.systemDefinitionPath_exp);
            this.Controls.Add(this.deploysysdef_exp);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SystemDefinitionPathLabel);
            this.Controls.Add(this.GatewayIPLabel);
            this.MinimumSize = new System.Drawing.Size(533, 176);
            this.Name = "ConfigureSystemDefinition";
            this.Text = "System Definition Settings";
            ((System.ComponentModel.ISupportInitialize)(this.systemDefinitionPath_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deploysysdef_exp)).EndInit();
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
            this.openFileDialog1.Title = "Select Veristand System Definition File";
            this.openFileDialog1.Filter = "Veristand System Definition(*.nivssdf)|*.nivssdf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label SystemDefinitionPathLabel;
        private System.Windows.Forms.Label GatewayIPLabel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit deploysysdef_exp;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit systemDefinitionPath_exp;
    }
}