namespace OpenWorkspaceDialog
{
    partial class SelectChannelsDialog
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
            this.loggingChannelSelection = new NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF();
            this.systemDefinitionFile_button = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggingChannelSelection
            // 
            this.loggingChannelSelection.AliasView = true;
            this.loggingChannelSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggingChannelSelection.Location = new System.Drawing.Point(12, 12);
            this.loggingChannelSelection.MultipleSelection = false;
            this.loggingChannelSelection.Name = "loggingChannelSelection";
            this.loggingChannelSelection.Size = new System.Drawing.Size(416, 233);
            this.loggingChannelSelection.StartNode = null;
            this.loggingChannelSelection.TabIndex = 1;
            // 
            // systemDefinitionFile_button
            // 
            this.systemDefinitionFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemDefinitionFile_button.Location = new System.Drawing.Point(12, 251);
            this.systemDefinitionFile_button.MaximumSize = new System.Drawing.Size(75, 23);
            this.systemDefinitionFile_button.MinimumSize = new System.Drawing.Size(75, 23);
            this.systemDefinitionFile_button.Name = "systemDefinitionFile_button";
            this.systemDefinitionFile_button.Size = new System.Drawing.Size(75, 23);
            this.systemDefinitionFile_button.TabIndex = 19;
            this.systemDefinitionFile_button.Text = "&Browse...";
            this.systemDefinitionFile_button.UseVisualStyleBackColor = true;
            this.systemDefinitionFile_button.Click += new System.EventHandler(this.SysDefFileBrowse_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(231, 291);
            this.Cancel.MaximumSize = new System.Drawing.Size(75, 23);
            this.Cancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(135, 291);
            this.OK.MaximumSize = new System.Drawing.Size(75, 23);
            this.OK.MinimumSize = new System.Drawing.Size(75, 23);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 22;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SelectChannelsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.systemDefinitionFile_button);
            this.Controls.Add(this.loggingChannelSelection);
            this.MinimumSize = new System.Drawing.Size(456, 364);
            this.Name = "SelectChannelsDialog";
            this.Text = "Select Channels Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private void OpenSysDefBrowseFileDialog()
        {
            this.openSysDefFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openSysDefFileDialog1.FileName = "";
            this.openSysDefFileDialog1.AddExtension = true;
            this.openSysDefFileDialog1.CheckFileExists = true;
            this.openSysDefFileDialog1.DefaultExt = "";
            this.openSysDefFileDialog1.Multiselect = false;
            this.openSysDefFileDialog1.Title = "Select Veristand System Definition File";
            this.openSysDefFileDialog1.Filter = "Veristand System Definition(*.nivssdf)|*.nivssdf";
            this.openSysDefFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openSysDefFileDialog1_FileOk);
            this.openSysDefFileDialog1.ShowDialog();
        }
        private NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF loggingChannelSelection;
        private System.Windows.Forms.Button systemDefinitionFile_button;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.OpenFileDialog openSysDefFileDialog1;
    }
}