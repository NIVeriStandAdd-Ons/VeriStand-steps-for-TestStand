using System.Windows.Forms;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using System.Collections;
namespace OpenWorkspaceDialog
{
    partial class ChannelSelectionDialog
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.ChannelSelection = new System.Windows.Forms.TreeView();
            this.Browse = new System.Windows.Forms.Button();
            this.SystemDefinitionPathControl = new System.Windows.Forms.TextBox();
            this.SystemDefinitionPathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.set_value_control = new System.Windows.Forms.NumericUpDown();
            this.filternames_label = new System.Windows.Forms.Label();
            this.filter_channels_control = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.set_value_control)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(309, 373);
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
            this.OK.Location = new System.Drawing.Point(210, 373);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ChannelSelection
            // 
            this.ChannelSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelSelection.Location = new System.Drawing.Point(12, 38);
            this.ChannelSelection.Name = "ChannelSelection";
            this.ChannelSelection.Size = new System.Drawing.Size(570, 256);
            this.ChannelSelection.TabIndex = 1;
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(507, 328);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SystemDefinitionPathControl
            // 
            this.SystemDefinitionPathControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemDefinitionPathControl.Location = new System.Drawing.Point(142, 329);
            this.SystemDefinitionPathControl.Name = "SystemDefinitionPathControl";
            this.SystemDefinitionPathControl.Size = new System.Drawing.Size(359, 20);
            this.SystemDefinitionPathControl.TabIndex = 3;
            this.SystemDefinitionPathControl.TextChanged += new System.EventHandler(this.SystemDefinitionPathControl_TextChanged);
            // 
            // SystemDefinitionPathLabel
            // 
            this.SystemDefinitionPathLabel.AutoSize = true;
            this.SystemDefinitionPathLabel.Location = new System.Drawing.Point(16, 333);
            this.SystemDefinitionPathLabel.Name = "SystemDefinitionPathLabel";
            this.SystemDefinitionPathLabel.Size = new System.Drawing.Size(113, 13);
            this.SystemDefinitionPathLabel.TabIndex = 12;
            this.SystemDefinitionPathLabel.Text = "System Definition Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Value (For Set Channel)";
            // 
            // set_value_control
            // 
            this.set_value_control.DecimalPlaces = 4;
            this.set_value_control.Location = new System.Drawing.Point(142, 304);
            this.set_value_control.Maximum = new decimal(new int[] {
            386808035,
            -1125814378,
            35537,
            0});
            this.set_value_control.Minimum = new decimal(new int[] {
            373700835,
            -1916526989,
            3,
            -2147483648});
            this.set_value_control.Name = "set_value_control";
            this.set_value_control.Size = new System.Drawing.Size(120, 20);
            this.set_value_control.TabIndex = 2;
            // 
            // filternames_label
            // 
            this.filternames_label.AutoSize = true;
            this.filternames_label.Location = new System.Drawing.Point(14, 16);
            this.filternames_label.Name = "filternames_label";
            this.filternames_label.Size = new System.Drawing.Size(76, 13);
            this.filternames_label.TabIndex = 17;
            this.filternames_label.Text = "Filter Channels";
            // 
            // filter_channels_control
            // 
            this.filter_channels_control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_channels_control.Location = new System.Drawing.Point(97, 12);
            this.filter_channels_control.Name = "filter_channels_control";
            this.filter_channels_control.Size = new System.Drawing.Size(287, 20);
            this.filter_channels_control.TabIndex = 0;
            this.filter_channels_control.TextChanged += new System.EventHandler(this.filter_channels_control_TextChanged);
            // 
            // ChannelSelectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 408);
            this.Controls.Add(this.filter_channels_control);
            this.Controls.Add(this.filternames_label);
            this.Controls.Add(this.set_value_control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SystemDefinitionPathControl);
            this.Controls.Add(this.SystemDefinitionPathLabel);
            this.Controls.Add(this.ChannelSelection);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.MinimumSize = new System.Drawing.Size(610, 446);
            this.Name = "ChannelSelectionDialog";
            this.Text = "Select Channel";
            ((System.ComponentModel.ISupportInitialize)(this.set_value_control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        TreeNodeCollection InitializeListBox(string systemDefinitionPath) //Fill the list box with all the possible channel selections
        {
          
                SystemDefinition sysDef = new SystemDefinition(systemDefinitionPath);
                ArrayList channelNames = new ArrayList();
                string nodeName = "";
                TreeNode nodeToAdd;

                BaseNode[] rootChildren = sysDef.Root.GetChildren();
                channelNames = GetChannels(rootChildren, channelNames);
                foreach (string channelName in channelNames)
                {
                    nodeToAdd = new TreeNode(channelName);
                    nodeToAdd.Name = channelName;
                    if (this.ChannelSelection.Nodes.Find(channelName, true).Length == 0)
                    {
                        this.ChannelSelection.Nodes.Add(nodeToAdd);
                    }
                }
                return this.ChannelSelection.Nodes;
            
         

           
            
        }
        ArrayList GetChannels(BaseNode[] nodes,ArrayList channelNames)  //Get every leaf in the tree- these are the channels
        {
            
            foreach (BaseNode node in nodes)
            {
                
                BaseNode[] children=node.GetChildren();
                if (children.Length == 0)
                {
                   
                    channelNames.Add(node.NodePath);
                }
                else
                {
                    GetChannels(children, channelNames);
                }
            }
            return channelNames;
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
        private TreeView ChannelSelection;
        private Button Browse;
        private TextBox SystemDefinitionPathControl;
        private Label SystemDefinitionPathLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Label label1;
        private NumericUpDown set_value_control;
        private Label filternames_label;
        private TextBox filter_channels_control;
    }
}