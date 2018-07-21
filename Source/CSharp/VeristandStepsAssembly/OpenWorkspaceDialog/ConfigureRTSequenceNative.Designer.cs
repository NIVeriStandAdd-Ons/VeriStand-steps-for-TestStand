using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.VeriStand.RealTimeSequenceDefinitionApi;
using NationalInstruments.TestStand.Interop.API;
using NationalInstruments.TestStand.Interop.UI.Ax;
using NationalInstruments.VeriStand.ClientAPI;
using NationalInstruments.VeriStand.SystemDefinitionAPI;
using NationalInstruments.VeriStand.SystemStorageUI;
using NationalInstruments.VeriStand.SystemStorage;
using NationalInstruments.VeriStand.Data;

namespace OpenWorkspaceDialog
{
    partial class ConfigureRTSequenceNative
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

        void SetExpressionEvalTypeByParameterType(ref NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit expEdit, string parameterType)
        {
            EvaluationTypes eval = seqContext.Engine.NewEvaluationTypes();
            switch (parameterType)
            {//Initialize the correct type of parameter based on the Users Type setting
                case "Path":
                    eval.PropertyValueTypeFlags = 0x4; //set string as the valid evaluation type                               
                    break;
                case "Boolean":
                    eval.PropertyValueTypeFlags = 0x1; //boolean type
                    break;
                case "Double":
                case "I32":
                case "I64":
                case "U32":
                case "U64":
                    eval.PropertyValueTypeFlags = 0x2; //numeric type
                    break;
                default:
                    eval.PropertyValueTypeFlags = 0x4;
                    break;

            }
            expEdit.SetValidEvaluationTypes(eval);

        }
        void InitializeTableView(SequenceContext _seqContext,string fileExp,string[] _parameterValues,string[] _parameterTypes, bool reset)
        {
            //MessageBox.Show(reset.ToString());
            PropertyObject seqContextPO;
            seqContextPO = _seqContext.AsPropertyObject();
            string filePath = StringUtilities.unparseFilePathString(fileExp);
            this.OpenSelectSingleChannelsDialog = new SelectSingleChannelPanel(this);
            string[] comboBoxParameterTypes = {"Path", "Boolean", "Double", "I32", "I64", "U32", "U64"};
            this.tableLayoutPanel1.Controls.Clear();//Empty the table
            //Add in the column headers
            this.tableLayoutPanel1.Controls.Add(this.ParameterNameTitle_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ParameterTypeTitle_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ParameterValueTitle_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectChannelTitle_label, 3, 0);
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.RowCount = 1;
            TableLayoutRowStyleCollection rowStyles = this.tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in rowStyles)
            {
                if (style.SizeType == SizeType.Percent)
                {
                    style.SizeType = SizeType.AutoSize;
                }
            }

            if (filePath != null && filePath != "" && System.IO.File.Exists(filePath))  //Don't try to initialize with a blank filepath
            {
                try
                {
                    RealTimeSequence newRTSeq = new RealTimeSequence(filePath);
                    ParameterDeclaration[] seqParam = newRTSeq.Variables.Parameters.Variables;
                    string parameterValueElement;
                    ReturnDeclaration returnParam = newRTSeq.Variables.ReturnType;
                    string returnParamType = returnParam.DataType.ToString();
                    returnParamDataType = returnParamType;

                    if (!reset)
                    {
                        this.tableLayoutPanel1.RowCount = seqParam.Length + 1; //Need rows for the header and one row for each parameter

                        if (seqParam.Length != _parameterValues.Length)
                        {
                            VSDialogs vsdialog = new VSDialogs();
                            vsdialog.ShowWarningDialog("It appears that the Real-Time Sequence has changed. Please reload the file by clicking \"Browse...\".");
                        }

                        if (seqParam.Length == _parameterValues.Length && seqParam.Length > 0 && _parameterValues.Length > 0)
                        {
                            for (int i = 0; i < seqParam.Length; i++)
                            {
                                ParameterDeclaration param = seqParam[i];
                                System.Windows.Forms.Label currentNameLabel = new System.Windows.Forms.Label();
                                System.Windows.Forms.ComboBox currentTypeComboBox = new System.Windows.Forms.ComboBox();
                                currentTypeComboBox.Enabled = false;
                                NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit currentExpression = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();

                                if (param.EvaluationMethod == EvaluationMethod.ByReference)
                                {
                                    parameterValueElement = StringUtilities.removeDoubleQuotesAroundString(_parameterValues[i]);
                                    if (param.DefaultAssignment.Channel.ToString() == parameterValueElement)
                                    {
                                        int rowToAddControl = i + 1;
                                        currentNameLabel.Text = param.Identifier;
                                        currentNameLabel.AutoSize = true;
                                        this.tableLayoutPanel1.Controls.Add(currentNameLabel, 0, rowToAddControl);
                                        currentTypeComboBox.Items.AddRange(comboBoxParameterTypes);
                                        currentTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ParameterTypeChanged);

                                        currentExpression.Visible = true;
                                        currentExpression.Dock = DockStyle.Fill;
                                        this.tableLayoutPanel1.Controls.Add(currentExpression, 2, rowToAddControl);
                                        currentExpression.Parent = tableLayoutPanel1;
                                        string handle = currentExpression.Handle.ToString();//force creation of the handle

                                        System.Windows.Forms.Button selectChannelButton = new System.Windows.Forms.Button();
                                        selectChannelButton.Text = "Browse...";
                                        selectChannelButton.Enabled = false;
                                        selectChannelButton.Click += new System.EventHandler(selectChannelButton_Click);
                                        selectChannelButton.Parent = this.tableLayoutPanel1;
                                        this.tableLayoutPanel1.Controls.Add(selectChannelButton, 3, rowToAddControl);

                                        currentExpression.CreateControl();
                                        currentExpression.Context = seqContextPO;
                                        currentExpression.SyntaxHighlightingEnabled = true;
                                        currentExpression.Style = NationalInstruments.TestStand.Interop.UI.ExpressionEditStyles.ExpressionEditStyle_Edit;
                                        currentExpression.TextType = NationalInstruments.TestStand.Interop.UI.TextTypes.TextType_Expression;
                                        currentExpression.Text = StringUtilities.addDoubleQuotesAroundString(param.DefaultAssignment.Channel.ToString());//Just use the DefaultAssignment if they are the same.

                                        this.tableLayoutPanel1.GetControlFromPosition(3, rowToAddControl).Enabled = true;

                                        currentTypeComboBox.SelectedText = "Path";
                                        this.tableLayoutPanel1.Controls.Add(currentTypeComboBox, 1, rowToAddControl);
                                    }
                                    else
                                    {
                                        int rowToAddControl = i + 1;
                                        currentNameLabel.Text = param.Identifier;
                                        currentNameLabel.AutoSize = true;
                                        this.tableLayoutPanel1.Controls.Add(currentNameLabel, 0, rowToAddControl);
                                        currentTypeComboBox.Items.AddRange(comboBoxParameterTypes);
                                        currentTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ParameterTypeChanged);

                                        currentExpression.Visible = true;
                                        currentExpression.Dock = DockStyle.Fill;
                                        this.tableLayoutPanel1.Controls.Add(currentExpression, 2, rowToAddControl);
                                        currentExpression.Parent = tableLayoutPanel1;
                                        string handle = currentExpression.Handle.ToString();//force creation of the handle

                                        System.Windows.Forms.Button selectChannelButton = new System.Windows.Forms.Button();
                                        selectChannelButton.Text = "Browse...";
                                        selectChannelButton.Enabled = false;
                                        selectChannelButton.Click += new System.EventHandler(selectChannelButton_Click);
                                        selectChannelButton.Parent = this.tableLayoutPanel1;
                                        this.tableLayoutPanel1.Controls.Add(selectChannelButton, 3, rowToAddControl);

                                        currentExpression.CreateControl();
                                        currentExpression.Context = seqContextPO;
                                        currentExpression.SyntaxHighlightingEnabled = true;
                                        currentExpression.Style = NationalInstruments.TestStand.Interop.UI.ExpressionEditStyles.ExpressionEditStyle_Edit;
                                        currentExpression.TextType = NationalInstruments.TestStand.Interop.UI.TextTypes.TextType_Expression;
                                        currentExpression.Text = StringUtilities.addDoubleQuotesAroundString(parameterValueElement);//Use the value from TestStand instead of the DefaultAssignment if they are not the same.

                                        this.tableLayoutPanel1.GetControlFromPosition(3, rowToAddControl).Enabled = true;

                                        currentTypeComboBox.SelectedText = "Path";
                                        this.tableLayoutPanel1.Controls.Add(currentTypeComboBox, 1, rowToAddControl);
                                    }
                                }
                                else
                                {
                                    parameterValueElement = StringUtilities.removeDoubleQuotesAroundString(_parameterValues[i]);
                                    if (param.DefaultAssignment.ToString() == parameterValueElement)
                                    {

                                        int rowToAddControl = i + 1;
                                        currentNameLabel.Text = param.Identifier;
                                        currentNameLabel.AutoSize = true;
                                        this.tableLayoutPanel1.Controls.Add(currentNameLabel, 0, rowToAddControl);
                                        currentTypeComboBox.Items.AddRange(comboBoxParameterTypes);
                                        currentTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ParameterTypeChanged);

                                        currentExpression.Visible = true;
                                        currentExpression.Dock = DockStyle.Fill;
                                        this.tableLayoutPanel1.Controls.Add(currentExpression, 2, rowToAddControl);
                                        currentExpression.Parent = tableLayoutPanel1;
                                        string handle = currentExpression.Handle.ToString();//force creation of the handle

                                        System.Windows.Forms.Button selectChannelButton = new System.Windows.Forms.Button();
                                        selectChannelButton.Text = "Browse...";
                                        selectChannelButton.Enabled = false;
                                        selectChannelButton.Click += new System.EventHandler(selectChannelButton_Click);
                                        selectChannelButton.Parent = this.tableLayoutPanel1;
                                        this.tableLayoutPanel1.Controls.Add(selectChannelButton, 3, rowToAddControl);

                                        currentExpression.CreateControl();
                                        currentExpression.Context = seqContextPO;
                                        currentExpression.SyntaxHighlightingEnabled = true;
                                        currentExpression.Style = NationalInstruments.TestStand.Interop.UI.ExpressionEditStyles.ExpressionEditStyle_Edit;
                                        currentExpression.TextType = NationalInstruments.TestStand.Interop.UI.TextTypes.TextType_Expression;
                                        currentExpression.Text = param.DefaultAssignment.ToString();//Just use the DefaultAssignment if they are the same.

                                        this.tableLayoutPanel1.GetControlFromPosition(3, rowToAddControl).Enabled = false;
                                        switch (param.DefaultValue.Type.ToString())
                                        {
                                            case "Double":
                                                currentTypeComboBox.SelectedText = "Double";
                                                break;
                                            case "UInt64":
                                                currentTypeComboBox.SelectedText = "U64";
                                                break;
                                            case "Int64":
                                                currentTypeComboBox.SelectedText = "I64";
                                                break;
                                            case "UInt32":
                                                currentTypeComboBox.SelectedText = "U32";
                                                break;
                                            case "Int32":
                                                currentTypeComboBox.SelectedText = "I32";
                                                break;
                                            case "Boolean":
                                                currentTypeComboBox.SelectedText = "Boolean";
                                                break;
                                        }
                                        this.tableLayoutPanel1.Controls.Add(currentTypeComboBox, 1, rowToAddControl);
                                    }
                                    else
                                    {
                                        int rowToAddControl = i + 1;
                                        currentNameLabel.Text = param.Identifier;
                                        currentNameLabel.AutoSize = true;
                                        this.tableLayoutPanel1.Controls.Add(currentNameLabel, 0, rowToAddControl);
                                        currentTypeComboBox.Items.AddRange(comboBoxParameterTypes);
                                        currentTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ParameterTypeChanged);

                                        currentExpression.Visible = true;
                                        currentExpression.Dock = DockStyle.Fill;
                                        this.tableLayoutPanel1.Controls.Add(currentExpression, 2, rowToAddControl);
                                        currentExpression.Parent = tableLayoutPanel1;
                                        string handle = currentExpression.Handle.ToString();//force creation of the handle

                                        System.Windows.Forms.Button selectChannelButton = new System.Windows.Forms.Button();
                                        selectChannelButton.Text = "Browse...";
                                        selectChannelButton.Enabled = false;
                                        selectChannelButton.Click += new System.EventHandler(selectChannelButton_Click);
                                        selectChannelButton.Parent = this.tableLayoutPanel1;
                                        this.tableLayoutPanel1.Controls.Add(selectChannelButton, 3, rowToAddControl);

                                        currentExpression.CreateControl();
                                        currentExpression.Context = seqContextPO;
                                        currentExpression.SyntaxHighlightingEnabled = true;
                                        currentExpression.Style = NationalInstruments.TestStand.Interop.UI.ExpressionEditStyles.ExpressionEditStyle_Edit;
                                        currentExpression.TextType = NationalInstruments.TestStand.Interop.UI.TextTypes.TextType_Expression;
                                        currentExpression.Text = parameterValueElement;//Use the value from TestStand instead of the DefaultAssignment if they are not the same.

                                        this.tableLayoutPanel1.GetControlFromPosition(3, rowToAddControl).Enabled = false;
                                        switch (param.DefaultValue.Type.ToString())
                                        {
                                            case "Double":
                                                currentTypeComboBox.SelectedText = "Double";
                                                break;
                                            case "UInt64":
                                                currentTypeComboBox.SelectedText = "U64";
                                                break;
                                            case "Int64":
                                                currentTypeComboBox.SelectedText = "I64";
                                                break;
                                            case "UInt32":
                                                currentTypeComboBox.SelectedText = "U32";
                                                break;
                                            case "Int32":
                                                currentTypeComboBox.SelectedText = "I32";
                                                break;
                                            case "Boolean":
                                                currentTypeComboBox.SelectedText = "Boolean";
                                                break;
                                        }
                                        this.tableLayoutPanel1.Controls.Add(currentTypeComboBox, 1, rowToAddControl);
                                    }
                                    //switch (param.DefaultValue.Type.ToString())
                                    //{
                                    //    case "Double":
                                    //        currentTypeComboBox.SelectedText = "Double";
                                    //        break;
                                    //    case "UInt64":
                                    //        currentTypeComboBox.SelectedText = "U64";
                                    //        break;
                                    //    case "Int64":
                                    //        currentTypeComboBox.SelectedText = "I64";
                                    //        break;
                                    //    case "UInt32":
                                    //        currentTypeComboBox.SelectedText = "U32";
                                    //        break;
                                    //    case "Int32":
                                    //        currentTypeComboBox.SelectedText = "I32";
                                    //        break;
                                    //    case "Boolean":
                                    //        currentTypeComboBox.SelectedText = "Boolean";
                                    //        break;
                                    //}
                                }
                            }
                        }
                    }

                    if (reset)
                    {
                        this.tableLayoutPanel1.RowCount = seqParam.Length + 1; //Need rows for the header and one row for each parameter

                        if (seqParam.Length > 0)
                        {
                            this.tableLayoutPanel1.AutoSize = true;
                            int n = 1;

                            foreach (ParameterDeclaration param in seqParam)
                            {
                                System.Windows.Forms.Label currentNameLabel = new System.Windows.Forms.Label();
                                currentNameLabel.Text = param.Identifier;
                                currentNameLabel.AutoSize = true;
                                this.tableLayoutPanel1.Controls.Add(currentNameLabel, 0, n);
                                System.Windows.Forms.ComboBox currentTypeComboBox = new System.Windows.Forms.ComboBox();
                                currentTypeComboBox.Items.AddRange(comboBoxParameterTypes);
                                currentTypeComboBox.SelectedValueChanged += new System.EventHandler(this.ParameterTypeChanged);
                                currentTypeComboBox.Enabled = false;
                                NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit currentExpression = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
                                currentExpression.Visible = true;
                                currentExpression.Dock = DockStyle.Fill;
                                this.tableLayoutPanel1.Controls.Add(currentExpression, 2, n);
                                currentExpression.Parent = tableLayoutPanel1;
                                string handle = currentExpression.Handle.ToString();//force creation of the handle
                                System.Windows.Forms.Button selectChannelButton = new System.Windows.Forms.Button();
                                selectChannelButton.Text = "Browse...";
                                selectChannelButton.Enabled = false;
                                selectChannelButton.Click += new System.EventHandler(selectChannelButton_Click);
                                selectChannelButton.Parent = this.tableLayoutPanel1;
                                this.tableLayoutPanel1.Controls.Add(selectChannelButton, 3, n);
                                currentExpression.CreateControl();
                                currentExpression.Context = seqContextPO;
                                currentExpression.SyntaxHighlightingEnabled = true;
                                currentExpression.Style = NationalInstruments.TestStand.Interop.UI.ExpressionEditStyles.ExpressionEditStyle_Edit;
                                currentExpression.TextType = NationalInstruments.TestStand.Interop.UI.TextTypes.TextType_Expression;


                                if (param.EvaluationMethod == EvaluationMethod.ByReference)
                                {
                                    currentTypeComboBox.SelectedText = "Path";
                                    currentExpression.Text = StringUtilities.addDoubleQuotesAroundString(param.DefaultAssignment.Channel.ToString());
                                    this.tableLayoutPanel1.GetControlFromPosition(3, n).Enabled = true;
                                }
                                else
                                {
                                    switch (param.DefaultValue.Type.ToString())
                                    {
                                        case "Double":
                                            currentTypeComboBox.SelectedText = "Double";
                                            break;
                                        case "UInt64":
                                            currentTypeComboBox.SelectedText = "U64";
                                            break;
                                        case "Int64":
                                            currentTypeComboBox.SelectedText = "I64";
                                            break;
                                        case "UInt32":
                                            currentTypeComboBox.SelectedText = "U32";
                                            break;
                                        case "Int32":
                                            currentTypeComboBox.SelectedText = "I32";
                                            break;
                                        case "Boolean":
                                            currentTypeComboBox.SelectedText = "Boolean";
                                            break;
                                    }
                                    currentExpression.Text = param.DefaultAssignment.ToString();
                                }
                                this.tableLayoutPanel1.Controls.Add(currentTypeComboBox, 1, n);
                                n++;
                            }
                        }
                    }
                    }

                catch (System.ArgumentException)
                {
                    VSDialogs dialogs = new VSDialogs();
                    dialogs.ShowWarningDialog("Invalid Filepath:" + filePath);
                }
            }
        }

        void selectChannelButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point startingPoint;
            startingPoint = clickedButton.PointToScreen(new Point(0, clickedButton.Height));
            this.OpenSelectSingleChannelsDialog.Location = startingPoint;
            this.OpenSelectSingleChannelsDialog.ShowDialog();
            TableLayoutPanelCellPosition buttonPosition = tableLayoutPanel1.GetPositionFromControl(clickedButton);
            this.tableLayoutPanel1.GetControlFromPosition(2, buttonPosition.Row).Text = selectedNodePath;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureRTSequenceNative));
            this.FilePath_Label = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.sessionNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clear_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ParameterNameTitle_label = new System.Windows.Forms.Label();
            this.ParameterTypeTitle_label = new System.Windows.Forms.Label();
            this.ParameterValueTitle_label = new System.Windows.Forms.Label();
            this.SelectChannelTitle_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilePath = new NationalInstruments.TestStand.Interop.UI.Ax.AxExpressionEdit();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.Timeout = new System.Windows.Forms.NumericUpDown();
            this.TargetSelect = new System.Windows.Forms.Button();
            this.targetString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePath_Label
            // 
            resources.ApplyResources(this.FilePath_Label, "FilePath_Label");
            this.FilePath_Label.Name = "FilePath_Label";
            // 
            // Browse
            // 
            resources.ApplyResources(this.Browse, "Browse");
            this.Browse.Name = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            resources.ApplyResources(this.OK, "OK");
            this.OK.Name = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // clear_button
            // 
            resources.ApplyResources(this.clear_button, "clear_button");
            this.clear_button.Name = "clear_button";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.ParameterNameTitle_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ParameterTypeTitle_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ParameterValueTitle_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectChannelTitle_label, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Clicked);
            // 
            // ParameterNameTitle_label
            // 
            resources.ApplyResources(this.ParameterNameTitle_label, "ParameterNameTitle_label");
            this.ParameterNameTitle_label.Name = "ParameterNameTitle_label";
            // 
            // ParameterTypeTitle_label
            // 
            resources.ApplyResources(this.ParameterTypeTitle_label, "ParameterTypeTitle_label");
            this.ParameterTypeTitle_label.Name = "ParameterTypeTitle_label";
            // 
            // ParameterValueTitle_label
            // 
            resources.ApplyResources(this.ParameterValueTitle_label, "ParameterValueTitle_label");
            this.ParameterValueTitle_label.Name = "ParameterValueTitle_label";
            // 
            // SelectChannelTitle_label
            // 
            resources.ApplyResources(this.SelectChannelTitle_label, "SelectChannelTitle_label");
            this.SelectChannelTitle_label.Name = "SelectChannelTitle_label";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.FilePath);
            this.panel2.Name = "panel2";
            // 
            // FilePath
            // 
            resources.ApplyResources(this.FilePath, "FilePath");
            this.FilePath.Name = "FilePath";
            this.FilePath.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("FilePath.OcxState")));
            this.FilePath.Change += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // TimeoutLabel
            // 
            resources.ApplyResources(this.TimeoutLabel, "TimeoutLabel");
            this.TimeoutLabel.Name = "TimeoutLabel";
            // 
            // Timeout
            // 
            resources.ApplyResources(this.Timeout, "Timeout");
            this.Timeout.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Timeout.Name = "Timeout";
            // 
            // TargetSelect
            // 
            resources.ApplyResources(this.TargetSelect, "TargetSelect");
            this.TargetSelect.Name = "TargetSelect";
            this.TargetSelect.UseVisualStyleBackColor = true;
            this.TargetSelect.Click += new System.EventHandler(this.TargetSelect_Click);
            // 
            // targetString
            // 
            resources.ApplyResources(this.targetString, "targetString");
            this.targetString.Name = "targetString";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ConfigureRTSequenceNative
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.targetString);
            this.Controls.Add(this.TargetSelect);
            this.Controls.Add(this.Timeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeoutLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.FilePath_Label);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "ConfigureRTSequenceNative";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfigureRTSequenceNative_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OpenBrowseFileDialog()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.DefaultExt = ".nivsseq";
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select Veristand Stimulus Profile File";
            this.openFileDialog1.Filter = "Veristand RT Sequence(*.nivsseq)|*.nivsseq|Comma Separated Value(*.csv)|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            this.openFileDialog1.ShowDialog();
        }
        private System.Windows.Forms.Label FilePath_Label;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip sessionNameToolTip;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ParameterNameTitle_label;
        private System.Windows.Forms.Label ParameterTypeTitle_label;
        private System.Windows.Forms.Label ParameterValueTitle_label;
        private Label SelectChannelTitle_label;
        public SelectSingleChannelPanel OpenSelectSingleChannelsDialog;
        private Panel panel1;
        private AxExpressionEdit FilePath;
        private Panel panel2;
        private Label TimeoutLabel;
        private NumericUpDown Timeout;
        private Button TargetSelect;
        private TextBox targetString;
        private Label label1;
    }
   
}