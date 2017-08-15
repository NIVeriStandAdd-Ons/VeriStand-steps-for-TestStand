using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;
using NationalInstruments.VeriStand.Data;
using System.Collections.Concurrent;
using NationalInstruments.TestStand.Interop.UI.Ax;

namespace OpenWorkspaceDialog
{
    partial class SetMultipleChannelsDialogDGV
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
        void InitializeDataGridView(string _sysDefPath, List<string> _channelNamesList, double[] _channelValuesArray, bool reset)
        {
            currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));
            Root currentSysDefRoot = currentSysDef.Root;

            //Check to see if Step.VeriStand.ChannelNames[] not empty. 
            //We should not attempt to initialize the dataGridView1 with an empty set of ChannelNames.
            if (channelNamesList.Count == 0)
            {
                this.dataGridView1.Rows.Clear();//Empty the table
                this.noChannelsLabel.BringToFront();
                this.noChannelsLabel.Visible = true;
            }

            if (channelNamesList.Count > 0 && reset)
            {
                this.dataGridView1.Rows.Clear();//Empty the table
                this.noChannelsLabel.Visible = false;
                currentSysDefRoot.FindNodeByPath(channelNamesList.ElementAt(0), out baseNodeElement);
                if (baseNodeElement != null)
                {
                    if (baseNodeArray.Length == channelNamesList.Count)
                    {
                        for (int i = 0; i < channelNamesList.Count; i++)
                        {
                            currentSysDefRoot.FindNodeByPath(channelNamesList.ElementAt(i), out baseNodeElement);
                            baseNodeArray[i] = baseNodeElement.BaseNodeType;
                            if (baseNodeElement != null)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1[0, i].Value = channelNamesList.ElementAt(i);
                                dataGridView1[1, i].Value = channelValuesArray[i];
                            }
                        }
                    }
                    else
                    {
                        Array.Resize(ref baseNodeArray, channelNamesList.Count);
                        for (int i = 0; i < channelNamesList.Count; i++)
                        {
                            currentSysDefRoot.FindNodeByPath(channelNamesList.ElementAt(i), out baseNodeElement);
                            baseNodeArray[i] = baseNodeElement.BaseNodeType;
                            if (baseNodeElement != null)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1[0, i].Value = channelNamesList.ElementAt(i);
                                dataGridView1[1, i].Value = channelValuesArray[i];
                            }
                        }
                    }
                }
            }

            if (channelNamesList.Count > 0 && !reset)
            {
                this.dataGridView1.Rows.Clear();
                this.noChannelsLabel.Visible = false;

                for (int i = 0; i < channelNamesList.Count; i++)
                {
                    int foundIndex = channelNamesListOld.IndexOf(channelNamesList.ElementAt(i));
                    if (foundIndex >= 0)
                    {
                        channelValuesArray[i] = channelValuesArrayOld[foundIndex];
                        dataGridView1.Rows.Add();
                        dataGridView1[0, i].Value = channelNamesList.ElementAt(i);
                        dataGridView1[1, i].Value = channelValuesArray[i];
                    }
                    else
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1[0, i].Value = channelNamesList.ElementAt(i);
                        dataGridView1[1, i].Value = 0;
                    }
                }
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectChannels_Button = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.noChannelsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectChannels_Button
            // 
            this.selectChannels_Button.Location = new System.Drawing.Point(12, 10);
            this.selectChannels_Button.MaximumSize = new System.Drawing.Size(111, 23);
            this.selectChannels_Button.MinimumSize = new System.Drawing.Size(111, 23);
            this.selectChannels_Button.Name = "selectChannels_Button";
            this.selectChannels_Button.Size = new System.Drawing.Size(111, 23);
            this.selectChannels_Button.TabIndex = 1;
            this.selectChannels_Button.Text = "Select Channels...";
            this.selectChannels_Button.UseVisualStyleBackColor = true;
            this.selectChannels_Button.Click += new System.EventHandler(this.SelectChannels_button_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(319, 288);
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
            this.OK.Location = new System.Drawing.Point(223, 288);
            this.OK.MaximumSize = new System.Drawing.Size(75, 23);
            this.OK.MinimumSize = new System.Drawing.Size(75, 23);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 22;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // noChannelsLabel
            // 
            this.noChannelsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noChannelsLabel.AutoSize = true;
            this.noChannelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noChannelsLabel.Location = new System.Drawing.Point(129, 13);
            this.noChannelsLabel.Name = "noChannelsLabel";
            this.noChannelsLabel.Size = new System.Drawing.Size(286, 16);
            this.noChannelsLabel.TabIndex = 25;
            this.noChannelsLabel.Text = "No channels selected. Please select channels.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChannelName,
            this.ChannelValue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 243);
            this.dataGridView1.TabIndex = 26;
            // 
            // ChannelName
            // 
            this.ChannelName.HeaderText = "Channel Name";
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.ReadOnly = true;
            // 
            // ChannelValue
            // 
            this.ChannelValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ChannelValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.ChannelValue.HeaderText = "Channel Value";
            this.ChannelValue.Name = "ChannelValue";
            this.ChannelValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChannelValue.Width = 82;
            // 
            // SetMultipleChannelsDialogDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 323);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.noChannelsLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.selectChannels_Button);
            this.MinimumSize = new System.Drawing.Size(632, 361);
            this.Name = "SetMultipleChannelsDialogDGV";
            this.Text = "Set Multiple Channels";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectChannels_Button;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label noChannelsLabel;
        private DataGridView dataGridView1;
        private SelectChannelsDialog OpenSelectChannelsDialog;
        private DataGridViewTextBoxColumn ChannelName;
        private DataGridViewTextBoxColumn ChannelValue;
    }
}