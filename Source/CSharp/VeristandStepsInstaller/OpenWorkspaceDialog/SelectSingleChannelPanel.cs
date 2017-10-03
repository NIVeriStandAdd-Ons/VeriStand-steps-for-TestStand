using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;

namespace OpenWorkspaceDialog
{
    public partial class SelectSingleChannelPanel : Form
    {
        ConfigureRTSequenceNative CallingFormGlobal;
        string projectPath;
        SystemDefinition currentSysDef;

        public SelectSingleChannelPanel(ConfigureRTSequenceNative CallingForm, ISystemDefinitionBrowserFilterType filter = ISystemDefinitionBrowserFilterType.K_ALL)
        {
            InitializeComponent();
            CallingFormGlobal = CallingForm;
            currentSysDef = CallingFormGlobal.currentSysDef;
            treeAliasBrowserWF1.DisplayFilter = ISystemDefinitionBrowserFilterType.K_ALL; //ChannelType.paramChannel
            try
            {
                treeAliasBrowserWF1.StartNode = currentSysDef.Root.BaseNodeType;
            }
            catch (System.ArgumentException ex)
            {
                //Do Nothing
            }
            catch (System.NullReferenceException ex)
            {
                //Do Nothing
            }
        }

        private void treeAliasBrowserWF1_OnDblClicked(NationalInstruments.VeriStand.SystemStorage.BaseNodeType dblClickedItem)
        {
            {
                string selectedNodePath = StringUtilities.addDoubleQuotesAroundString(treeAliasBrowserWF1.GetCurrentSelection(false).NodePath);
                if (selectedNodePath == "")
                { }
                else
                {
                    CallingFormGlobal.selectedNodePath = selectedNodePath;
                }
                this.Close();
            }

            //private void SelectSingleChannelPanel_FormClosing(object sender, FormClosingEventArgs e)
            //{
            //    if (treeAliasBrowserWF1.GetCurrentSelections(false).Length != 0)
            //    {
            //        string selectedNodePath = StringUtilities.addDoubleQuotesAroundString(treeAliasBrowserWF1.GetCurrentSelections(false)[0].NodePath);
            //        if (selectedNodePath == "")
            //        { }
            //        else
            //        {
            //            CallingFormGlobal.selectedNodePath = selectedNodePath;
            //        }
            //    }
            //}
        }
    }
}
