using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace OpenWorkspaceDialog
{
    partial class ConfigureLoggingFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureLoggingFile));
            this.loggingChannelSelection = new NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF();
            this.LogFilePathLabel = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SegmentFileSize_boolean = new System.Windows.Forms.CheckBox();
            this.FileSegmentSize_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvancedLoggingProperties_button = new System.Windows.Forms.Button();
            this.systemDefinitionFile_button = new System.Windows.Forms.Button();
            this.systemDefinitionFile_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.LogFilePath_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FileSegmentSize_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogFilePath_exp)).BeginInit();
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
            // this.loggingChannelSelection.ShowCheckBox = false; **ADC: Commenting this out because this property does not exist in older SystemStorageUI assembly. 
            this.loggingChannelSelection.Size = new System.Drawing.Size(490, 244);
            this.loggingChannelSelection.StartNode = null;
            this.loggingChannelSelection.TabIndex = 0;
            // 
            // LogFilePathLabel
            // 
            this.LogFilePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFilePathLabel.AutoSize = true;
            this.LogFilePathLabel.Location = new System.Drawing.Point(12, 345);
            this.LogFilePathLabel.Name = "LogFilePathLabel";
            this.LogFilePathLabel.Size = new System.Drawing.Size(69, 13);
            this.LogFilePathLabel.TabIndex = 19;
            this.LogFilePathLabel.Text = "Log File Path";
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(427, 340);
            this.Browse.MaximumSize = new System.Drawing.Size(75, 23);
            this.Browse.MinimumSize = new System.Drawing.Size(75, 23);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 18;
            this.Browse.Text = "&Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(271, 390);
            this.Cancel.MaximumSize = new System.Drawing.Size(75, 23);
            this.Cancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(175, 390);
            this.OK.MaximumSize = new System.Drawing.Size(75, 23);
            this.OK.MinimumSize = new System.Drawing.Size(75, 23);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 20;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SegmentFileSize_boolean
            // 
            this.SegmentFileSize_boolean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SegmentFileSize_boolean.AutoSize = true;
            this.SegmentFileSize_boolean.Location = new System.Drawing.Point(12, 304);
            this.SegmentFileSize_boolean.MinimumSize = new System.Drawing.Size(179, 17);
            this.SegmentFileSize_boolean.Name = "SegmentFileSize_boolean";
            this.SegmentFileSize_boolean.Size = new System.Drawing.Size(179, 17);
            this.SegmentFileSize_boolean.TabIndex = 22;
            this.SegmentFileSize_boolean.Text = "Segment File According to Size?";
            this.SegmentFileSize_boolean.UseVisualStyleBackColor = true;
            this.SegmentFileSize_boolean.CheckedChanged += new System.EventHandler(this.SegmentFileSize_boolean_CheckedChanged);
            // 
            // FileSegmentSize_num
            // 
            this.FileSegmentSize_num.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSegmentSize_num.Location = new System.Drawing.Point(329, 301);
            this.FileSegmentSize_num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FileSegmentSize_num.MaximumSize = new System.Drawing.Size(127, 0);
            this.FileSegmentSize_num.MinimumSize = new System.Drawing.Size(127, 0);
            this.FileSegmentSize_num.Name = "FileSegmentSize_num";
            this.FileSegmentSize_num.Size = new System.Drawing.Size(127, 20);
            this.FileSegmentSize_num.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "File Segmenting Size (MB)";
            // 
            // AdvancedLoggingProperties_button
            // 
            this.AdvancedLoggingProperties_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedLoggingProperties_button.Location = new System.Drawing.Point(362, 390);
            this.AdvancedLoggingProperties_button.MaximumSize = new System.Drawing.Size(143, 23);
            this.AdvancedLoggingProperties_button.MinimumSize = new System.Drawing.Size(143, 23);
            this.AdvancedLoggingProperties_button.Name = "AdvancedLoggingProperties_button";
            this.AdvancedLoggingProperties_button.Size = new System.Drawing.Size(143, 23);
            this.AdvancedLoggingProperties_button.TabIndex = 18;
            this.AdvancedLoggingProperties_button.Text = "&Advanced Properties...";
            this.AdvancedLoggingProperties_button.UseVisualStyleBackColor = true;
            this.AdvancedLoggingProperties_button.Click += new System.EventHandler(this.AdvancedLoggingProperties_button_Click);
            // 
            // systemDefinitionFile_button
            // 
            this.systemDefinitionFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemDefinitionFile_button.Location = new System.Drawing.Point(12, 262);
            this.systemDefinitionFile_button.MaximumSize = new System.Drawing.Size(75, 23);
            this.systemDefinitionFile_button.MinimumSize = new System.Drawing.Size(75, 23);
            this.systemDefinitionFile_button.Name = "systemDefinitionFile_button";
            this.systemDefinitionFile_button.Size = new System.Drawing.Size(75, 23);
            this.systemDefinitionFile_button.TabIndex = 18;
            this.systemDefinitionFile_button.Text = "&Browse...";
            this.systemDefinitionFile_tooltip.SetToolTip(this.systemDefinitionFile_button, "System Definition File");
            this.systemDefinitionFile_button.UseVisualStyleBackColor = true;
            this.systemDefinitionFile_button.Click += new System.EventHandler(this.SysDefFileBrowse_Click);
            // 
            // LogFilePath_exp
            // 
            this.LogFilePath_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFilePath_exp.Location = new System.Drawing.Point(87, 342);
            this.LogFilePath_exp.Name = "LogFilePath_exp";
            this.LogFilePath_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LogFilePath_exp.OcxState")));
            this.LogFilePath_exp.Size = new System.Drawing.Size(334, 19);
            this.LogFilePath_exp.TabIndex = 17;
            // 
            // ConfigureLoggingFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileSegmentSize_num);
            this.Controls.Add(this.SegmentFileSize_boolean);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.LogFilePathLabel);
            this.Controls.Add(this.AdvancedLoggingProperties_button);
            this.Controls.Add(this.systemDefinitionFile_button);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.LogFilePath_exp);
            this.Controls.Add(this.loggingChannelSelection);
            this.MinimumSize = new System.Drawing.Size(536, 460);
            this.Name = "ConfigureLoggingFile";
            this.Text = "Configure Logging File";
            ((System.ComponentModel.ISupportInitialize)(this.FileSegmentSize_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogFilePath_exp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeAliasBrowserWF loggingChannelSelection;
        private System.Windows.Forms.Label LogFilePathLabel;
        private System.Windows.Forms.Button Browse;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit LogFilePath_exp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AdvancedLoggingProperties OpenAdvancedLoggingPropertiesDialog1;
        private System.Windows.Forms.OpenFileDialog openSysDefFileDialog1;
        private void OpenBrowseFileDialog()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.DefaultExt = ".tdms";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select Veristand Log File";
            this.openFileDialog1.Filter = "NI TDMS (*.tdms)|*.tdms|All files (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
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
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox SegmentFileSize_boolean;
        private System.Windows.Forms.NumericUpDown FileSegmentSize_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdvancedLoggingProperties_button;
        private System.Windows.Forms.Button systemDefinitionFile_button;
        private System.Windows.Forms.ToolTip systemDefinitionFile_tooltip;
    }
}