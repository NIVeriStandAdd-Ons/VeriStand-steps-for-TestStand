namespace OpenWorkspaceDialog
{
    partial class SelectSingleChannelPanel
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
            this.treeAliasBrowserWF1 = new NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF();
            this.SuspendLayout();
            // 
            // treeAliasBrowserWF1
            // 
            this.treeAliasBrowserWF1.AliasView = true;
            this.treeAliasBrowserWF1.AutoScroll = true;
            this.treeAliasBrowserWF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAliasBrowserWF1.Location = new System.Drawing.Point(0, 0);
            this.treeAliasBrowserWF1.MultipleSelection = false;
            this.treeAliasBrowserWF1.Name = "treeAliasBrowserWF1";
            this.treeAliasBrowserWF1.Size = new System.Drawing.Size(365, 299);
            this.treeAliasBrowserWF1.StartNode = null;
            this.treeAliasBrowserWF1.TabIndex = 0;
            this.treeAliasBrowserWF1.OnDblClicked += new NationalInstruments.VeriStand.SystemStorageUI.DOnItemDblClicked(this.treeAliasBrowserWF1_OnDblClicked);
            // 
            // SelectSingleChannelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 299);
            this.Controls.Add(this.treeAliasBrowserWF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(381, 333);
            this.Name = "SelectSingleChannelPanel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select Channel";
            this.TopMost = true;
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectSingleChannelPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF treeAliasBrowserWF1;

    }
}