namespace OpenWorkspaceDialog
{
    partial class ConfigureGateway
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureGateway));
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.GatewayIPLabel = new System.Windows.Forms.Label();
            this.ProjectPathLabel = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.gatewayIP_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.projectpath_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.username_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.password_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.visible_exp = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gatewayIP_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpath_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visible_exp)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OK.Location = new System.Drawing.Point(162, 234);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.Location = new System.Drawing.Point(263, 234);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // GatewayIPLabel
            // 
            this.GatewayIPLabel.AutoSize = true;
            this.GatewayIPLabel.Location = new System.Drawing.Point(10, 27);
            this.GatewayIPLabel.Name = "GatewayIPLabel";
            this.GatewayIPLabel.Size = new System.Drawing.Size(59, 13);
            this.GatewayIPLabel.TabIndex = 3;
            this.GatewayIPLabel.Text = "GatewayIP";
            // 
            // ProjectPathLabel
            // 
            this.ProjectPathLabel.AutoSize = true;
            this.ProjectPathLabel.Location = new System.Drawing.Point(10, 61);
            this.ProjectPathLabel.Name = "ProjectPathLabel";
            this.ProjectPathLabel.Size = new System.Drawing.Size(62, 13);
            this.ProjectPathLabel.TabIndex = 4;
            this.ProjectPathLabel.Text = "ProjectPath";
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(413, 56);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(10, 98);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 134);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // gatewayIP_exp
            // 
            this.gatewayIP_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gatewayIP_exp.Location = new System.Drawing.Point(75, 27);
            this.gatewayIP_exp.Name = "gatewayIP_exp";
            this.gatewayIP_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gatewayIP_exp.OcxState")));
            this.gatewayIP_exp.Size = new System.Drawing.Size(332, 19);
            this.gatewayIP_exp.TabIndex = 9;
            this.gatewayIP_exp.Change += new System.EventHandler(this.gatewayIP_exp_Change);
            // 
            // projectpath_exp
            // 
            this.projectpath_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectpath_exp.Location = new System.Drawing.Point(75, 58);
            this.projectpath_exp.Name = "projectpath_exp";
            this.projectpath_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("projectpath_exp.OcxState")));
            this.projectpath_exp.Size = new System.Drawing.Size(332, 19);
            this.projectpath_exp.TabIndex = 10;
            this.projectpath_exp.Change += new System.EventHandler(this.projectpath_exp_Change);
            // 
            // username_exp
            // 
            this.username_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_exp.Location = new System.Drawing.Point(75, 98);
            this.username_exp.Name = "username_exp";
            this.username_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("username_exp.OcxState")));
            this.username_exp.Size = new System.Drawing.Size(332, 19);
            this.username_exp.TabIndex = 11;
            this.username_exp.Change += new System.EventHandler(this.username_exp_Change);
            // 
            // password_exp
            // 
            this.password_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_exp.Location = new System.Drawing.Point(75, 134);
            this.password_exp.Name = "password_exp";
            this.password_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("password_exp.OcxState")));
            this.password_exp.Size = new System.Drawing.Size(332, 19);
            this.password_exp.TabIndex = 12;
            this.password_exp.Change += new System.EventHandler(this.password_exp_Change);
            // 
            // visible_exp
            // 
            this.visible_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visible_exp.Location = new System.Drawing.Point(75, 171);
            this.visible_exp.Name = "visible_exp";
            this.visible_exp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visible_exp.OcxState")));
            this.visible_exp.Size = new System.Drawing.Size(332, 19);
            this.visible_exp.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Visible";
            // 
            // ConfigureGateway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visible_exp);
            this.Controls.Add(this.password_exp);
            this.Controls.Add(this.username_exp);
            this.Controls.Add(this.projectpath_exp);
            this.Controls.Add(this.gatewayIP_exp);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.ProjectPathLabel);
            this.Controls.Add(this.GatewayIPLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.MinimumSize = new System.Drawing.Size(516, 307);
            this.Name = "ConfigureGateway";
            this.Text = "Configure Gateway";
            ((System.ComponentModel.ISupportInitialize)(this.gatewayIP_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectpath_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visible_exp)).EndInit();
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
            this.openFileDialog1.Title = "Select Veristand Project File";
            this.openFileDialog1.Filter = "Veristand Project(*.nivsproj)|*.nivsproj";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label GatewayIPLabel;
        private System.Windows.Forms.Label ProjectPathLabel;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit gatewayIP_exp;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit projectpath_exp;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit username_exp;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit password_exp;
        private NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit visible_exp;
        private System.Windows.Forms.Label label1;
    }

}

