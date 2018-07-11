namespace OpenWorkspaceDialog
{
    partial class ConfigureSequenceName
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
            this.sequenceName_label = new System.Windows.Forms.Label();
            this.sequenceName_Control = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sequenceNumber_control = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceNumber_control)).BeginInit();
            this.SuspendLayout();
            // 
            // sequenceName_label
            // 
            this.sequenceName_label.AutoSize = true;
            this.sequenceName_label.Location = new System.Drawing.Point(38, 35);
            this.sequenceName_label.Name = "sequenceName_label";
            this.sequenceName_label.Size = new System.Drawing.Size(87, 13);
            this.sequenceName_label.TabIndex = 0;
            this.sequenceName_label.Text = "Sequence Name";
            // 
            // sequenceName_Control
            // 
            this.sequenceName_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceName_Control.Location = new System.Drawing.Point(131, 32);
            this.sequenceName_Control.Name = "sequenceName_Control";
            this.sequenceName_Control.Size = new System.Drawing.Size(314, 20);
            this.sequenceName_Control.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nSequence names can be found by using the\r\nGet Sequence Names function. ";
            // 
            // ok_button
            // 
            this.ok_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ok_button.Location = new System.Drawing.Point(139, 149);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel_button.Location = new System.Drawing.Point(242, 149);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sequence Number";
            // 
            // sequenceNumber_control
            // 
            this.sequenceNumber_control.Location = new System.Drawing.Point(131, 97);
            this.sequenceNumber_control.Name = "sequenceNumber_control";
            this.sequenceNumber_control.Size = new System.Drawing.Size(120, 20);
            this.sequenceNumber_control.TabIndex = 4;
            this.sequenceNumber_control.ValueChanged += new System.EventHandler(this.sequenceNumber_control_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specify the name or number of the sequence to operate on. ";
            // 
            // ConfigureSequenceName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sequenceNumber_control);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.sequenceName_Control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sequenceName_label);
            this.MinimumSize = new System.Drawing.Size(473, 222);
            this.Name = "ConfigureSequenceName";
            this.Text = "Configure Sequence Name";
            ((System.ComponentModel.ISupportInitialize)(this.sequenceNumber_control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sequenceName_label;
        private System.Windows.Forms.TextBox sequenceName_Control;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sequenceNumber_control;
        private System.Windows.Forms.Label label3;
    }
}