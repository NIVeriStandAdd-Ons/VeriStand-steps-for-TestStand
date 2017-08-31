using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenWorkspaceDialog
{
    public partial class WarningForm : Form
    {
        public WarningForm(string text)
        {
            InitializeComponent();
            this.richTextBox1.Text = text;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
