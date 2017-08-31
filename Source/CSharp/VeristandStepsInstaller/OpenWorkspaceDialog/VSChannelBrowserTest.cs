using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.VeriStand.SystemStorageUI.WinFormsWrapper;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand;
using NationalInstruments.VeriStand.SystemStorage;
namespace OpenWorkspaceDialog
{
    public partial class VSChannelBrowserTest : Form
    {
        public VSChannelBrowserTest()
        {
            InitializeComponent();
           SystemDefinition sysDef = new SystemDefinition("C:\\Users\\kfort\\Desktop\\2011 chan test.nivssdf");      
           // TreeBrowserWF treeBrowser = new TreeBrowserWF();
          //  treeBrowser.Size = new Size(70, 70);
          //  treeBrowser.Anchor = AnchorStyles.Top;
           treeBrowserWF1.StartNode = sysDef.Root.BaseNodeType;
           
           // treeBrowser.Visible = true;
           // treeBrowser.Show();
            

        }
    }
}
