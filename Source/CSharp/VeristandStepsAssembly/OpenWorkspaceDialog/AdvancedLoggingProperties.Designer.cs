namespace OpenWorkspaceDialog
{
    partial class AdvancedLoggingProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedLoggingProperties));
            this.FileProperties_label = new System.Windows.Forms.Label();
            this.FileDescription_text = new System.Windows.Forms.TextBox();
            this.FileDescription_label = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.addFileProperty_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Property_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Property_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeFileProperty_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileProperties_label
            // 
            this.FileProperties_label.AutoSize = true;
            this.FileProperties_label.Location = new System.Drawing.Point(117, 143);
            this.FileProperties_label.Name = "FileProperties_label";
            this.FileProperties_label.Size = new System.Drawing.Size(73, 13);
            this.FileProperties_label.TabIndex = 1;
            this.FileProperties_label.Text = "File Properties";
            this.toolTip1.SetToolTip(this.FileProperties_label, resources.GetString("FileProperties_label.ToolTip"));
            // 
            // FileDescription_text
            // 
            this.FileDescription_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileDescription_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileDescription_text.Location = new System.Drawing.Point(15, 26);
            this.FileDescription_text.MinimumSize = new System.Drawing.Size(484, 93);
            this.FileDescription_text.Multiline = true;
            this.FileDescription_text.Name = "FileDescription_text";
            this.FileDescription_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileDescription_text.Size = new System.Drawing.Size(484, 93);
            this.FileDescription_text.TabIndex = 2;
            // 
            // FileDescription_label
            // 
            this.FileDescription_label.AutoSize = true;
            this.FileDescription_label.Location = new System.Drawing.Point(12, 10);
            this.FileDescription_label.Name = "FileDescription_label";
            this.FileDescription_label.Size = new System.Drawing.Size(79, 13);
            this.FileDescription_label.TabIndex = 1;
            this.FileDescription_label.Text = "File Description";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(261, 323);
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
            this.OK.Location = new System.Drawing.Point(165, 323);
            this.OK.MaximumSize = new System.Drawing.Size(75, 23);
            this.OK.MinimumSize = new System.Drawing.Size(75, 23);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 22;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // addFileProperty_button
            // 
            this.addFileProperty_button.Location = new System.Drawing.Point(12, 159);
            this.addFileProperty_button.MaximumSize = new System.Drawing.Size(102, 23);
            this.addFileProperty_button.MinimumSize = new System.Drawing.Size(102, 23);
            this.addFileProperty_button.Name = "addFileProperty_button";
            this.addFileProperty_button.Size = new System.Drawing.Size(102, 23);
            this.addFileProperty_button.TabIndex = 24;
            this.addFileProperty_button.Text = "Add Property";
            this.toolTip1.SetToolTip(this.addFileProperty_button, "Inserts a new File Property entry into the File Properties table.");
            this.addFileProperty_button.UseVisualStyleBackColor = true;
            this.addFileProperty_button.Click += new System.EventHandler(this.addFileProperty_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property_Name,
            this.Property_Value});
            this.dataGridView1.Location = new System.Drawing.Point(120, 159);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(379, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 149);
            this.dataGridView1.TabIndex = 25;
            this.toolTip1.SetToolTip(this.dataGridView1, resources.GetString("dataGridView1.ToolTip"));
            // 
            // Property_Name
            // 
            this.Property_Name.HeaderText = "Property Name";
            this.Property_Name.Name = "Property_Name";
            // 
            // Property_Value
            // 
            this.Property_Value.HeaderText = "Property Value";
            this.Property_Value.Name = "Property_Value";
            // 
            // removeFileProperty_button
            // 
            this.removeFileProperty_button.Location = new System.Drawing.Point(12, 188);
            this.removeFileProperty_button.MaximumSize = new System.Drawing.Size(102, 23);
            this.removeFileProperty_button.MinimumSize = new System.Drawing.Size(102, 23);
            this.removeFileProperty_button.Name = "removeFileProperty_button";
            this.removeFileProperty_button.Size = new System.Drawing.Size(102, 23);
            this.removeFileProperty_button.TabIndex = 24;
            this.removeFileProperty_button.Text = "Remove Property";
            this.toolTip1.SetToolTip(this.removeFileProperty_button, "Removes the selected row(s) from the File Properties table.");
            this.removeFileProperty_button.UseVisualStyleBackColor = true;
            this.removeFileProperty_button.Click += new System.EventHandler(this.removeFileProperty_button_Click);
            // 
            // AdvancedLoggingProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 358);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeFileProperty_button);
            this.Controls.Add(this.addFileProperty_button);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.FileDescription_text);
            this.Controls.Add(this.FileDescription_label);
            this.Controls.Add(this.FileProperties_label);
            this.MinimumSize = new System.Drawing.Size(517, 396);
            this.Name = "AdvancedLoggingProperties";
            this.Text = "Advanced Logging Properties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileProperties_label;
        private System.Windows.Forms.TextBox FileDescription_text;
        private System.Windows.Forms.Label FileDescription_label;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button addFileProperty_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeFileProperty_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property_Value;
    }
}