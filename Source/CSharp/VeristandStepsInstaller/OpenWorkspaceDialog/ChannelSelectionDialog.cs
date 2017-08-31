
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
using System.Text.RegularExpressions;
namespace OpenWorkspaceDialog
{
    public partial class ChannelSelectionDialog : Form
    {
        string SystemDefinitionPath = "";
        SequenceContext seqContext;
        PropertyObject seqContextPO;
        Sequence selectedTSSequence;
        SequenceFile seqFile;
        PropertyObject permSeqContext;
        Step selectedTSStep;
        PropertyObjectFile propObjectFile;
        string stepID;
        string selectedChannelName = "";
        TreeNode[] treeNodes;
        double channelValue = 0;
        bool ModelList;
        PropertyObject stepPropertyObject;
        public ChannelSelectionDialog()
        {
            InitializeComponent();
        }
        public ChannelSelectionDialog(SequenceContext _seqContext,bool _ModelList)
        {
            ModelList = _ModelList;
            InitializeComponent();

         
            //Set up Teststand objects
            seqContext = _seqContext;
            seqContextPO = seqContext.AsPropertyObject();
            selectedTSSequence = seqContext.SelectedSequences[0];
            selectedTSStep = seqContext.SelectedSteps[0];
            stepID = selectedTSStep.UniqueStepId;
            seqFile = selectedTSSequence.SequenceFile;
            permSeqContext = selectedTSSequence.Locals;  //Must get sequence context this way for variables to save if teststand is restarted
            propObjectFile = seqFile.AsPropertyObjectFile();


            stepPropertyObject = selectedTSSequence.GetStepByUniqueId(stepID).AsPropertyObject();
            try
            {
                channelValue = stepPropertyObject.GetValNumber("Veristand.ValueToSet", 0);
                selectedChannelName = stepPropertyObject.GetValString("Veristand.ChannelName", 0);
                SystemDefinitionPath = seqContext.SequenceFile.FileGlobalsDefaultValues.GetValString("Veristand.SystemDefinitionPath", 1);//Try to get the specific system definition path associated with this step
                seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
                this.SystemDefinitionPathControl.Text = SystemDefinitionPath;
                this.set_value_control.Value =(decimal) channelValue;
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                selectedChannelName = "";
                SystemDefinitionPath = ""; //If there is no system definition path default to the empty string
                this.SystemDefinitionPathControl.Text = SystemDefinitionPath;
            }
            if (System.IO.File.Exists(SystemDefinitionPath) && System.IO.Path.GetExtension(SystemDefinitionPath) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the grid
                TreeNodeCollection tempTreeNodeCollection = InitializeListBox(SystemDefinitionPath);
                treeNodes=new TreeNode[tempTreeNodeCollection.Count];
                tempTreeNodeCollection.CopyTo(treeNodes,0) ;
            }
            if (selectedChannelName != "")
            {
                
                TreeNode[] foundNodes=this.ChannelSelection.Nodes.Find(selectedChannelName, true);
               
                if(foundNodes.Length>0)
                {
                    
                    this.ChannelSelection.SelectedNode = foundNodes[0];//Only one node should match exactly
                    this.ChannelSelection.HideSelection = false;
                    this.ChannelSelection.SelectedNode.BackColor = Color.Violet;
                    this.ChannelSelection.Focus();//This does not seem to be working
                }
                
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            stepPropertyObject.SetValNumber("Veristand.ValueToSet", 0, (double)this.set_value_control.Value);
            if (ModelList) 
            {
                //Parse the channel list name to get the proper format for a model parameter
                string input = this.ChannelSelection.SelectedNode.Text;
                Match match = Regex.Match(input, @"Targets/([ A-Za-z0-9\-_]+)/", RegexOptions.IgnoreCase);
                string targetName = match.Groups[1].Value;
                match = Regex.Match(input, @"Models/([ A-Za-z0-9\-_]+)/Parameters", RegexOptions.IgnoreCase);
                string modelName = match.Groups[1].Value;
                match = Regex.Match(input, @"Parameters/([ A-Za-z0-9\/-_]+)", RegexOptions.IgnoreCase);
                string parameterName = match.Groups[1].Value;
                if (parameterName.Contains('/'))
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, modelName + "/" + parameterName);
                }
                else
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, parameterName);
                }
                stepPropertyObject.SetValString("Veristand.TargetName", 0, targetName);
            }
            else
            {
                try
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, this.ChannelSelection.SelectedNode.Text);
                }
                catch (System.NullReferenceException ex)
                {
                    stepPropertyObject.SetValString("Veristand.ChannelName", 0, "");
                }
            }
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetValString("Veristand.SystemDefinitionPath", 1, SystemDefinitionPath);//Set system definition path for the Sequence File
            seqContext.SequenceFile.FileGlobalsDefaultValues.SetFlags("Veristand.SystemDefinitionPath", 0, 0x4400000);
            propObjectFile.IncChangeCount();  //Sets the flag that means the sequence has changes to save (dirty dot*)   
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openFile = (OpenFileDialog)sender;
            SystemDefinitionPath = openFile.FileName;
            this.SystemDefinitionPathControl.Text = SystemDefinitionPath;
            TreeNodeCollection tempTreeNodeCollection = InitializeListBox(SystemDefinitionPath);
            treeNodes=new TreeNode[tempTreeNodeCollection.Count];
            tempTreeNodeCollection.CopyTo(treeNodes,0) ;
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenBrowseFileDialog();
        }

        private void SystemDefinitionPathControl_TextChanged(object sender, EventArgs e)
        {
            SystemDefinitionPath = this.SystemDefinitionPathControl.Text;
            if (System.IO.File.Exists(SystemDefinitionPath) && System.IO.Path.GetExtension(SystemDefinitionPath) == ".nivssdf")
            {
                //File exists with correct extension so try and populate the grid
                TreeNodeCollection tempTreeNodeCollection = InitializeListBox(SystemDefinitionPath);
                treeNodes=new TreeNode[tempTreeNodeCollection.Count];
                tempTreeNodeCollection.CopyTo(treeNodes,0) ;

            }
        }

        private void filter_channels_control_TextChanged(object sender, EventArgs e)
        {
            //When the user changes the text in the filter control update the tree
            
            string filterText=this.filter_channels_control.Text;
            if (treeNodes != null)
            {
                ArrayList filteredNodes = filterByName(treeNodes, filterText);
                this.ChannelSelection.Nodes.Clear();
                foreach (TreeNode treeNode in filteredNodes)
                {
                    this.ChannelSelection.Nodes.Add(treeNode);
                }
            }

        }
        private ArrayList filterByName(TreeNode[] nodesToFilter,string filterText)
        {
            //Filter the array so that it only contains items which have a name containing what is in filterText
            ArrayList filteredNodes = new ArrayList();
            foreach (TreeNode currentNode in nodesToFilter)
            {
                if(currentNode.Name.Contains(filterText))
                {
                    filteredNodes.Add(currentNode);
                }

            }
                return filteredNodes;
        }
       

     

       


     
    }
}
