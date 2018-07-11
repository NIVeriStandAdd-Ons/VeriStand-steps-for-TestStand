namespace OpenWorkspaceDialog
{
    partial class ConfigureLegacyStimulusProfile
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
            this.Browse = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.FilePath_Label = new System.Windows.Forms.Label();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.StopDisconnect = new System.Windows.Forms.CheckBox();
            this.Timeout = new System.Windows.Forms.NumericUpDown();
            this.Timeout_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(380, 21);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FilePath
            // 
            this.FilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath.Location = new System.Drawing.Point(65, 22);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(309, 20);
            this.FilePath.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(243, 137);
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
            this.OK.Location = new System.Drawing.Point(148, 137);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FilePath_Label
            // 
            this.FilePath_Label.AutoSize = true;
            this.FilePath_Label.Location = new System.Drawing.Point(11, 26);
            this.FilePath_Label.Name = "FilePath_Label";
            this.FilePath_Label.Size = new System.Drawing.Size(48, 13);
            this.FilePath_Label.TabIndex = 11;
            this.FilePath_Label.Text = "File Path";
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(65, 50);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(79, 17);
            this.AutoStart.TabIndex = 12;
            this.AutoStart.Text = "Auto Start?";
            this.AutoStart.UseVisualStyleBackColor = true;
            this.AutoStart.CheckedChanged += new System.EventHandler(this.AutoStart_CheckedChanged);
            // 
            // StopDisconnect
            // 
            this.StopDisconnect.AutoSize = true;
            this.StopDisconnect.Location = new System.Drawing.Point(65, 73);
            this.StopDisconnect.Name = "StopDisconnect";
            this.StopDisconnect.Size = new System.Drawing.Size(126, 17);
            this.StopDisconnect.TabIndex = 13;
            this.StopDisconnect.Text = "Stop on Disconnect?";
            this.StopDisconnect.UseVisualStyleBackColor = true;
            this.StopDisconnect.CheckedChanged += new System.EventHandler(this.StopDisconnect_CheckedChanged);
            // 
            // Timeout
            // 
            this.Timeout.Location = new System.Drawing.Point(65, 94);
            this.Timeout.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(120, 20);
            this.Timeout.TabIndex = 2;
            this.Timeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Timeout.ValueChanged += new System.EventHandler(this.Timeout_ValueChanged);
            // 
            // Timeout_Label
            // 
            this.Timeout_Label.AutoSize = true;
            this.Timeout_Label.Location = new System.Drawing.Point(14, 98);
            this.Timeout_Label.Name = "Timeout_Label";
            this.Timeout_Label.Size = new System.Drawing.Size(45, 13);
            this.Timeout_Label.TabIndex = 15;
            this.Timeout_Label.Text = "Timeout";
            // 
            // ConfigureLegacyStimulusProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 172);
            this.Controls.Add(this.Timeout_Label);
            this.Controls.Add(this.Timeout);
            this.Controls.Add(this.StopDisconnect);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.MinimumSize = new System.Drawing.Size(483, 210);
            this.Name = "ConfigureLegacyStimulusProfile";
            this.Text = "Configure Legacy Stimulus Profile";
            ((System.ComponentModel.ISupportInitialize)(this.Timeout)).EndInit();
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
            this.openFileDialog1.Filter = "Veristand Stimulus Profile(*.nivstest)|*.nivstest";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label FilePath_Label;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.Windows.Forms.CheckBox StopDisconnect;
        private System.Windows.Forms.NumericUpDown Timeout;
        private System.Windows.Forms.Label Timeout_Label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}