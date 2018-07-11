using System.Windows.Forms;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using System.Collections;
using System.Text.RegularExpressions;
namespace OpenWorkspaceDialog
{
    partial class ConfigureAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureAlarm));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Browse = new System.Windows.Forms.Button();
            this.SystemDefinitionPathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alarmstate_control = new System.Windows.Forms.ComboBox();
            this.channel_browser = new NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeBrowserWF();
            this.systemDefinitionPath_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefinitionPath_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(312, 403);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(207, 403);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(476, 353);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SystemDefinitionPathLabel
            // 
            this.SystemDefinitionPathLabel.AutoSize = true;
            this.SystemDefinitionPathLabel.Location = new System.Drawing.Point(43, 358);
            this.SystemDefinitionPathLabel.Name = "SystemDefinitionPathLabel";
            this.SystemDefinitionPathLabel.Size = new System.Drawing.Size(113, 13);
            this.SystemDefinitionPathLabel.TabIndex = 12;
            this.SystemDefinitionPathLabel.Text = "System Definition Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alarm State";
            // 
            // alarmstate_control
            // 
            this.alarmstate_control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmstate_control.FormattingEnabled = true;
            this.alarmstate_control.Items.AddRange(new object[] {
            "Disabled",
            "Enabled",
            "Tripped",
            "Delayed Trip",
            "Indicate"});
            this.alarmstate_control.Location = new System.Drawing.Point(162, 328);
            this.alarmstate_control.Name = "alarmstate_control";
            this.alarmstate_control.Size = new System.Drawing.Size(137, 21);
            this.alarmstate_control.TabIndex = 2;
            // 
            // channel_browser
            // 
            this.channel_browser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channel_browser.Location = new System.Drawing.Point(12, 12);
            this.channel_browser.MultipleSelection = false;
            this.channel_browser.Name = "channel_browser";
            this.channel_browser.ShowCheckBox = false;
            this.channel_browser.Size = new System.Drawing.Size(570, 301);
            this.channel_browser.StartNode = null;
            this.channel_browser.TabIndex = 16;
            // 
            // systemDefinitionPath_exp
            // 
            this.systemDefinitionPath_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemDefinitionPath_exp.Location = new System.Drawing.Point(162, 355);
            this.systemDefinitionPath_exp.Name = "systemDefinitionPath_exp";
            this.systemDefinitionPath_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("systemDefinitionPath_exp.OcxState")));
            this.systemDefinitionPath_exp.Size = new System.Drawing.Size(308, 19);
            this.systemDefinitionPath_exp.TabIndex = 17;
            // 
            // ConfigureAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 438);
            this.Controls.Add(this.systemDefinitionPath_exp);
            this.Controls.Add(this.channel_browser);
            this.Controls.Add(this.alarmstate_control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SystemDefinitionPathLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.MinimumSize = new System.Drawing.Size(610, 476);
            this.Name = "ConfigureAlarm";
            this.Text = "Select Channel";
            ((System.ComponentModel.ISupportInitialize)(this.systemDefinitionPath_exp)).EndInit();
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

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private Button Browse;
        private Label SystemDefinitionPathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Label label1;
        private ComboBox alarmstate_control;
        private NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper.TreeBrowserWF channel_browser;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit systemDefinitionPath_exp;
    }
 }
