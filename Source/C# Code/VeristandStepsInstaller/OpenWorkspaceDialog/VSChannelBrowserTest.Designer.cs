namespace OpenWorkspaceDialog
{
using NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand;
using NationalInstruments.VeriStand.SystemStorage;
    using System.Drawing;
    partial class VSChannelBrowserTest
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
            this.treeBrowserWF1 = new NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeBrowserWF();
            this.SuspendLayout();
            // 
            // treeBrowserWF1
            // 
            this.treeBrowserWF1.Location = new System.Drawing.Point(20, 56);
            this.treeBrowserWF1.MultipleSelection = false;
            this.treeBrowserWF1.Name = "treeBrowserWF1";
            this.treeBrowserWF1.ShowCheckBox = false;
            this.treeBrowserWF1.Size = new System.Drawing.Size(507, 234);
            this.treeBrowserWF1.StartNode = null;
            this.treeBrowserWF1.TabIndex = 0;
            // 
            // VSChannelBrowserTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 399);
            this.Controls.Add(this.treeBrowserWF1);
            this.Name = "VSChannelBrowserTest";
            this.Text = "VSChannelBrowserTest";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeBrowserWF treeBrowser;
        private TreeBrowserWF treeBrowserWF1;
    }
}