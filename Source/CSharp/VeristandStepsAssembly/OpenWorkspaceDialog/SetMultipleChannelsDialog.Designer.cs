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
    partial class SetMultipleChannelsDialog
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
        void InitializeTableView(string _sysDefPath, List<string> _channelNamesList, double[] _channelValuesArray)
        {
            this.tableLayoutPanel1.Controls.Clear();//Empty the table
            //Add in the column headers
            this.tableLayoutPanel1.Controls.Add(this.ChannelNamesTitle_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChannelValuesTitle_label, 1, 0);

            currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));

            //Check to see if Step.VeriStand.ChannelNames[] not empty. 
            //We should not attempt to initialize the dataGridView1 with an empty set of ChannelNames.
            if (channelNamesList.Count == 0)
            {
                this.tableLayoutPanel1.RowCount = 1;
                this.noChannelsLabel.BringToFront();
                this.noChannelsLabel.Visible = true;
                this.tableLayoutPanel1.AutoSize = true;
                System.Drawing.Size tableLayoutPanel1MinSize = new System.Drawing.Size();
                tableLayoutPanel1MinSize.Height = 0;
                tableLayoutPanel1MinSize.Width = 0;
                this.tableLayoutPanel1.MinimumSize = tableLayoutPanel1MinSize;
            }

            if (channelNamesList.Count > 0)
            {
                //if (channelNamesList.Count <= 8)
                //{
                    this.noChannelsLabel.Visible = false;
                    TableLayoutRowStyleCollection rowStyles = this.tableLayoutPanel1.RowStyles;
                    foreach (RowStyle style in rowStyles)
                    {
                        if (style.SizeType == SizeType.Percent)
                        {
                            style.SizeType = SizeType.AutoSize;
                        }
                    }
                    this.tableLayoutPanel1.AutoSize = true;
                    System.Drawing.Size tableLayoutPanel1MinSize = new System.Drawing.Size();
                    tableLayoutPanel1MinSize.Height = 0;
                    tableLayoutPanel1MinSize.Width = 0;
                    this.tableLayoutPanel1.MinimumSize = tableLayoutPanel1MinSize;
                    this.tableLayoutPanel1.RowCount = channelNamesList.Count + 1; //Need rows for the header and one row for each channel.

                    for (int i = 0; i < channelNamesList.Count; i++)
                    {
                        Label currentChannelNameLabel = new System.Windows.Forms.Label();
                        currentChannelNameLabel.Text = channelNamesList.ElementAt(i);
                        this.tableLayoutPanel1.Controls.Add(currentChannelNameLabel, 0, i + 1);
                        currentChannelNameLabel.AutoSize = true;

                        TextBox currentValueTextBox = new System.Windows.Forms.TextBox();
                        currentValueTextBox.Text = channelValuesArray.ElementAt(i).ToString();
                        this.tableLayoutPanel1.Controls.Add(currentValueTextBox, 1, i + 1);
                        currentValueTextBox.Dock = DockStyle.Fill;

                        //NumericUpDown currentValueNumUpDown = new System.Windows.Forms.NumericUpDown();
                        //currentValueNumUpDown.Value = (int)channelValuesArray.ElementAt(i);
                        //this.tableLayoutPanel1.Controls.Add(currentValueNumUpDown, 1, i + 1);
                        //currentValueNumUpDown.AutoSize = true;
                    }
                    Root currentSysDefRoot = currentSysDef.Root;
                    currentSysDefRoot.FindNodeByPath(channelNamesList[0], out baseNodeElement);
                //}
                //else if (channelNamesList.Count > 8)
                //{
                //    this.noChannelsLabel.Visible = false;
                //    this.tableLayoutPanel1.AutoSize = true;
                //    TableLayoutRowStyleCollection rowStyles = this.tableLayoutPanel1.RowStyles;
                //    foreach (RowStyle style in rowStyles)
                //    {
                //        if (style.SizeType == SizeType.Percent)
                //        {
                //            style.SizeType = SizeType.AutoSize;
                //        }
                //    }
                //    this.tableLayoutPanel1.RowCount = channelNamesList.Count + 1; //Need rows for the header and one row for each channel.

                //    for (int i = 0; i < channelNamesList.Count; i++)
                //    {
                //        Label currentChannelNameLabel = new System.Windows.Forms.Label();
                //        currentChannelNameLabel.Text = channelNamesList.ElementAt(i);
                //        this.tableLayoutPanel1.Controls.Add(currentChannelNameLabel, 0, i + 1);
                //        currentChannelNameLabel.AutoSize = true;

                //        NumericUpDown currentValueNumUpDown = new System.Windows.Forms.NumericUpDown();
                //        currentValueNumUpDown.Value = (int)channelValuesArray.ElementAt(i);
                //        this.tableLayoutPanel1.Controls.Add(currentValueNumUpDown, 1, i + 1);
                //        currentValueNumUpDown.AutoSize = true;
                //    }
                //    Root currentSysDefRoot = currentSysDef.Root;
                //    currentSysDefRoot.FindNodeByPath(channelNamesList[0], out baseNodeElement);
                //}
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.selectChannels_Button = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goToNode = new System.Windows.Forms.ToolStripMenuItem();
            this.ChannelNamesTitle_label = new System.Windows.Forms.Label();
            this.ChannelValuesTitle_label = new System.Windows.Forms.Label();
            this.noChannelsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ContextMenuStrip = this.tableLayoutPanelContextMenu;
            this.tableLayoutPanel1.Controls.Add(this.ChannelNamesTitle_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChannelValuesTitle_label, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 229);
            this.tableLayoutPanel1.TabIndex = 24;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.SetMultipleChannelsDialog_MouseEnter);
            // 
            // tableLayoutPanelContextMenu
            // 
            this.tableLayoutPanelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToNode});
            this.tableLayoutPanelContextMenu.Name = "tableLayoutPanelContextMenu";
            this.tableLayoutPanelContextMenu.Size = new System.Drawing.Size(179, 26);
            // 
            // goToNode
            // 
            this.goToNode.Name = "goToNode";
            this.goToNode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.goToNode.Size = new System.Drawing.Size(178, 22);
            this.goToNode.Text = "Find Node...";
            // 
            // ChannelNamesTitle_label
            // 
            this.ChannelNamesTitle_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChannelNamesTitle_label.AutoSize = true;
            this.ChannelNamesTitle_label.Location = new System.Drawing.Point(222, 3);
            this.ChannelNamesTitle_label.Name = "ChannelNamesTitle_label";
            this.ChannelNamesTitle_label.Size = new System.Drawing.Size(77, 13);
            this.ChannelNamesTitle_label.TabIndex = 0;
            this.ChannelNamesTitle_label.Text = "Channel Name";
            this.ChannelNamesTitle_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChannelValuesTitle_label
            // 
            this.ChannelValuesTitle_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChannelValuesTitle_label.AutoSize = true;
            this.ChannelValuesTitle_label.Location = new System.Drawing.Point(550, 3);
            this.ChannelValuesTitle_label.Name = "ChannelValuesTitle_label";
            this.ChannelValuesTitle_label.Size = new System.Drawing.Size(34, 13);
            this.ChannelValuesTitle_label.TabIndex = 1;
            this.ChannelValuesTitle_label.Text = "Value";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.MinimumSize = new System.Drawing.Size(615, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 229);
            this.panel1.TabIndex = 26;
            // 
            // SetMultipleChannelsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 323);
            this.Controls.Add(this.noChannelsLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.selectChannels_Button);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(632, 361);
            this.Name = "SetMultipleChannelsDialog";
            this.Text = "Set Multiple Channels";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectChannels_Button;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip tableLayoutPanelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem goToNode;
        private System.Windows.Forms.Label ChannelNamesTitle_label;
        private System.Windows.Forms.Label ChannelValuesTitle_label;
        private System.Windows.Forms.Label noChannelsLabel;
        private Panel panel1;
    }
}