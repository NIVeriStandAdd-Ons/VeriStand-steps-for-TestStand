using System;
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
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xaml;

namespace OpenWorkspaceDialog
{
    public partial class SelectTargetDialog : Form
    {
        //Veristand Objects Initialize
        private SystemDefinitionBrowser _treeView { get; set; }
        //private SystemDefinitionBrowser _aliasBrowser { get; set; }
        public string SelectedTarget { get; set; }
        public string SysDefPath { get; set; }

        public SelectTargetDialog(string sysDefPath, string target)
        {
            InitializeComponent();

            SysDefPath = sysDefPath;
            SelectedTarget = target;
            //If the file at path FileGlobals.Veristand.SystemDefinitionPath exists and the extension is ".nivssdf" use that System Definition file to initialize the TreeAliasBrowserWF.
            if (System.IO.File.Exists(StringUtilities.unparseFilePathString(SysDefPath)) && System.IO.Path.GetExtension(StringUtilities.unparseFilePathString(SysDefPath)) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the tree
                InitializeListBox(SysDefPath, SelectedTarget);
            }
            //If FileGlobals.Veristand.SystemDefinitionPath is empty or the file does not exist at path FileGlobals.Veristand.SystemDefinitionPath.
            else //(sysDefPath == "" || !System.IO.File.Exists(StringUtilities.unparseFilePathString(sysDefPath)))
            {
                //Do nothing
            }
        }
        private void InitializeListBox(string _sysDefPath, string _selectedTarget)
        {
            SystemDefinition _currentSysDef = new SystemDefinition(StringUtilities.unparseFilePathString(_sysDefPath));
            TravNdMatchNodeTypeFilter targetFilter = new TravNdMatchNodeTypeFilter(NodeType.K_TARGET);
            targetBrowser.SetSystemDefinitionDisplayFilter(ISystemDefinitionBrowserFilterType.K_CUSTOM, targetFilter);
            targetBrowser.StartNode = _currentSysDef.Root.BaseNodeType;
            //Check to see if selected target is empty. 
            //We should not attempt to initialize the TreeALiasBrowserWF with an empty target path.
            if (_selectedTarget != "")
            {
                BaseNode startNode;
                _currentSysDef.Root.GetTargets().FindFirstChildWithName(_selectedTarget, out startNode, true);
                targetBrowser.SetCurrentSelections(new BaseNodeType[]{startNode.BaseNodeType});
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                BaseNodeType[] selection = this.targetBrowser.GetCurrentSelections(false);
                if (selection.Length > 0)
                {
                    this.SelectedTarget = selection[0].Name;
                }
            }
            catch (System.NullReferenceException ex)
            {
                //do nothing
            }
            catch (System.IndexOutOfRangeException ex)
            {
                //do nothing
            }
            this.Close();
        }
  
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SysDefFileBrowse_Click(object sender, EventArgs e)
        {
            OpenSysDefBrowseFileDialog();
        }
        private void openSysDefFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            SysDefPath = openFile.FileName;
            SysDefPath = StringUtilities.parseFilePathString(SysDefPath);
            InitializeListBox(SysDefPath, SelectedTarget);
        }
    }
}
