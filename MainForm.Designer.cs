namespace remote_csgo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ScanResultBox = new System.Windows.Forms.ListBox();
            this.DoScanButton = new System.Windows.Forms.Button();
            this.VirtualConsoleBox = new System.Windows.Forms.RichTextBox();
            this.PortLowBox = new System.Windows.Forms.NumericUpDown();
            this.PortUpBox = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoopDelayLabel = new System.Windows.Forms.Label();
            this.LoopDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.CurrentCFGLabel = new System.Windows.Forms.Label();
            this.ScanStatusLabel = new System.Windows.Forms.Label();
            this.CmdMacrosButton = new System.Windows.Forms.Button();
            this.LoopCmdButton = new System.Windows.Forms.CheckBox();
            this.RunCfgAllButton = new System.Windows.Forms.Button();
            this.RunCfgSelectedButton = new System.Windows.Forms.Button();
            this.LoadCFGButton = new System.Windows.Forms.Button();
            this.RunScriptButton = new System.Windows.Forms.CheckBox();
            this.LoadCmdScriptButton = new System.Windows.Forms.Button();
            this.FilterSelectedCheckBox = new System.Windows.Forms.CheckBox();
            this.RemoveAllCsgoButton = new System.Windows.Forms.Button();
            this.RemoveSelectedCsgo = new System.Windows.Forms.Button();
            this.ConnectedCsgoLabel = new System.Windows.Forms.Label();
            this.ListenerListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddAllButton = new System.Windows.Forms.Button();
            this.AddResultButton = new System.Windows.Forms.Button();
            this.CmdSelectedButton = new System.Windows.Forms.Button();
            this.CmdAllButton = new System.Windows.Forms.Button();
            this.VirtualConsoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HostNameLabel = new System.Windows.Forms.Label();
            this.HostNameBox = new System.Windows.Forms.TextBox();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdLoopTextBox = new System.Windows.Forms.Timer(this.components);
            this.LoopCmdAllButton = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.LoopCmdSelectedButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PortLowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortUpBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopDelayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanResultBox
            // 
            this.ScanResultBox.BackColor = System.Drawing.Color.DimGray;
            this.ScanResultBox.FormattingEnabled = true;
            this.ScanResultBox.ItemHeight = 19;
            this.ScanResultBox.Location = new System.Drawing.Point(4, 23);
            this.ScanResultBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScanResultBox.Name = "ScanResultBox";
            this.ScanResultBox.Size = new System.Drawing.Size(260, 156);
            this.ScanResultBox.TabIndex = 0;
            // 
            // DoScanButton
            // 
            this.DoScanButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoScanButton.Location = new System.Drawing.Point(4, 338);
            this.DoScanButton.Margin = new System.Windows.Forms.Padding(4);
            this.DoScanButton.Name = "DoScanButton";
            this.DoScanButton.Size = new System.Drawing.Size(260, 34);
            this.DoScanButton.TabIndex = 1;
            this.DoScanButton.Text = "Scan";
            this.DoScanButton.UseVisualStyleBackColor = true;
            this.DoScanButton.Click += new System.EventHandler(this.DoScanButton_Click);
            // 
            // VirtualConsoleBox
            // 
            this.VirtualConsoleBox.BackColor = System.Drawing.Color.Black;
            this.VirtualConsoleBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirtualConsoleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VirtualConsoleBox.Location = new System.Drawing.Point(539, 23);
            this.VirtualConsoleBox.Margin = new System.Windows.Forms.Padding(4);
            this.VirtualConsoleBox.Name = "VirtualConsoleBox";
            this.VirtualConsoleBox.Size = new System.Drawing.Size(387, 203);
            this.VirtualConsoleBox.TabIndex = 2;
            this.VirtualConsoleBox.Text = "";
            // 
            // PortLowBox
            // 
            this.PortLowBox.Location = new System.Drawing.Point(92, 231);
            this.PortLowBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortLowBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PortLowBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortLowBox.Name = "PortLowBox";
            this.PortLowBox.Size = new System.Drawing.Size(72, 26);
            this.PortLowBox.TabIndex = 3;
            this.PortLowBox.Value = new decimal(new int[] {
            8880,
            0,
            0,
            0});
            this.PortLowBox.ValueChanged += new System.EventHandler(this.PortLowBox_ValueChanged);
            // 
            // PortUpBox
            // 
            this.PortUpBox.Location = new System.Drawing.Point(92, 265);
            this.PortUpBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortUpBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PortUpBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PortUpBox.Name = "PortUpBox";
            this.PortUpBox.Size = new System.Drawing.Size(71, 26);
            this.PortUpBox.TabIndex = 4;
            this.PortUpBox.Value = new decimal(new int[] {
            8890,
            0,
            0,
            0});
            this.PortUpBox.ValueChanged += new System.EventHandler(this.PortUpBox_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.LoopCmdSelectedButton);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.LoopCmdAllButton);
            this.panel1.Controls.Add(this.LoopDelayLabel);
            this.panel1.Controls.Add(this.LoopDelayUpDown);
            this.panel1.Controls.Add(this.CurrentCFGLabel);
            this.panel1.Controls.Add(this.ScanStatusLabel);
            this.panel1.Controls.Add(this.CmdMacrosButton);
            this.panel1.Controls.Add(this.LoopCmdButton);
            this.panel1.Controls.Add(this.RunCfgAllButton);
            this.panel1.Controls.Add(this.RunCfgSelectedButton);
            this.panel1.Controls.Add(this.LoadCFGButton);
            this.panel1.Controls.Add(this.RunScriptButton);
            this.panel1.Controls.Add(this.LoadCmdScriptButton);
            this.panel1.Controls.Add(this.FilterSelectedCheckBox);
            this.panel1.Controls.Add(this.RemoveAllCsgoButton);
            this.panel1.Controls.Add(this.RemoveSelectedCsgo);
            this.panel1.Controls.Add(this.ConnectedCsgoLabel);
            this.panel1.Controls.Add(this.ListenerListBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddAllButton);
            this.panel1.Controls.Add(this.AddResultButton);
            this.panel1.Controls.Add(this.CmdSelectedButton);
            this.panel1.Controls.Add(this.CmdAllButton);
            this.panel1.Controls.Add(this.VirtualConsoleRichTextBox);
            this.panel1.Controls.Add(this.HostNameLabel);
            this.panel1.Controls.Add(this.HostNameBox);
            this.panel1.Controls.Add(this.ConsoleLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VirtualConsoleBox);
            this.panel1.Controls.Add(this.PortUpBox);
            this.panel1.Controls.Add(this.ScanResultBox);
            this.panel1.Controls.Add(this.PortLowBox);
            this.panel1.Controls.Add(this.DoScanButton);
            this.panel1.Location = new System.Drawing.Point(30, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 443);
            this.panel1.TabIndex = 5;
            // 
            // LoopDelayLabel
            // 
            this.LoopDelayLabel.AutoSize = true;
            this.LoopDelayLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopDelayLabel.Location = new System.Drawing.Point(795, 333);
            this.LoopDelayLabel.Name = "LoopDelayLabel";
            this.LoopDelayLabel.Size = new System.Drawing.Size(98, 14);
            this.LoopDelayLabel.TabIndex = 32;
            this.LoopDelayLabel.Text = "Loop Delay Ms";
            // 
            // LoopDelayUpDown
            // 
            this.LoopDelayUpDown.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopDelayUpDown.Location = new System.Drawing.Point(895, 331);
            this.LoopDelayUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.LoopDelayUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.LoopDelayUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopDelayUpDown.Name = "LoopDelayUpDown";
            this.LoopDelayUpDown.Size = new System.Drawing.Size(51, 20);
            this.LoopDelayUpDown.TabIndex = 31;
            this.LoopDelayUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LoopDelayUpDown.ValueChanged += new System.EventHandler(this.LoopDelayUpDown_ValueChanged);
            // 
            // CurrentCFGLabel
            // 
            this.CurrentCFGLabel.AutoSize = true;
            this.CurrentCFGLabel.Location = new System.Drawing.Point(323, 392);
            this.CurrentCFGLabel.Name = "CurrentCFGLabel";
            this.CurrentCFGLabel.Size = new System.Drawing.Size(162, 19);
            this.CurrentCFGLabel.TabIndex = 30;
            this.CurrentCFGLabel.Text = "Current Cfg: None";
            // 
            // ScanStatusLabel
            // 
            this.ScanStatusLabel.AutoSize = true;
            this.ScanStatusLabel.Location = new System.Drawing.Point(66, 376);
            this.ScanStatusLabel.Name = "ScanStatusLabel";
            this.ScanStatusLabel.Size = new System.Drawing.Size(117, 19);
            this.ScanStatusLabel.TabIndex = 29;
            this.ScanStatusLabel.Text = "Scan Left: 0";
            // 
            // CmdMacrosButton
            // 
            this.CmdMacrosButton.Enabled = false;
            this.CmdMacrosButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMacrosButton.Location = new System.Drawing.Point(539, 362);
            this.CmdMacrosButton.Margin = new System.Windows.Forms.Padding(4);
            this.CmdMacrosButton.Name = "CmdMacrosButton";
            this.CmdMacrosButton.Size = new System.Drawing.Size(139, 26);
            this.CmdMacrosButton.TabIndex = 28;
            this.CmdMacrosButton.Text = "Cmd Macros";
            this.CmdMacrosButton.UseVisualStyleBackColor = true;
            this.CmdMacrosButton.Click += new System.EventHandler(this.CmdMacrosButton_Click);
            // 
            // LoopCmdButton
            // 
            this.LoopCmdButton.AutoSize = true;
            this.LoopCmdButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopCmdButton.Location = new System.Drawing.Point(700, 332);
            this.LoopCmdButton.Name = "LoopCmdButton";
            this.LoopCmdButton.Size = new System.Drawing.Size(89, 19);
            this.LoopCmdButton.TabIndex = 27;
            this.LoopCmdButton.Text = "Loop Cmd?";
            this.LoopCmdButton.UseVisualStyleBackColor = true;
            this.LoopCmdButton.CheckedChanged += new System.EventHandler(this.LoopCmdButton_CheckedChanged);
            // 
            // RunCfgAllButton
            // 
            this.RunCfgAllButton.Enabled = false;
            this.RunCfgAllButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunCfgAllButton.Location = new System.Drawing.Point(312, 362);
            this.RunCfgAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.RunCfgAllButton.Name = "RunCfgAllButton";
            this.RunCfgAllButton.Size = new System.Drawing.Size(193, 26);
            this.RunCfgAllButton.TabIndex = 26;
            this.RunCfgAllButton.Text = "Run CFG All";
            this.RunCfgAllButton.UseVisualStyleBackColor = true;
            this.RunCfgAllButton.Click += new System.EventHandler(this.RunCfgAllButton_Click);
            // 
            // RunCfgSelectedButton
            // 
            this.RunCfgSelectedButton.Enabled = false;
            this.RunCfgSelectedButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunCfgSelectedButton.Location = new System.Drawing.Point(312, 332);
            this.RunCfgSelectedButton.Margin = new System.Windows.Forms.Padding(4);
            this.RunCfgSelectedButton.Name = "RunCfgSelectedButton";
            this.RunCfgSelectedButton.Size = new System.Drawing.Size(193, 26);
            this.RunCfgSelectedButton.TabIndex = 25;
            this.RunCfgSelectedButton.Text = "Run CFG Selected";
            this.RunCfgSelectedButton.UseVisualStyleBackColor = true;
            this.RunCfgSelectedButton.Click += new System.EventHandler(this.RunCfgSelectedButton_Click);
            // 
            // LoadCFGButton
            // 
            this.LoadCFGButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCFGButton.Location = new System.Drawing.Point(312, 303);
            this.LoadCFGButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadCFGButton.Name = "LoadCFGButton";
            this.LoadCFGButton.Size = new System.Drawing.Size(193, 26);
            this.LoadCFGButton.TabIndex = 24;
            this.LoadCFGButton.Text = "Load CFG";
            this.LoadCFGButton.UseVisualStyleBackColor = true;
            this.LoadCFGButton.Click += new System.EventHandler(this.LoadCFGButton_Click);
            // 
            // RunScriptButton
            // 
            this.RunScriptButton.AutoSize = true;
            this.RunScriptButton.Enabled = false;
            this.RunScriptButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunScriptButton.Location = new System.Drawing.Point(552, 395);
            this.RunScriptButton.Name = "RunScriptButton";
            this.RunScriptButton.Size = new System.Drawing.Size(131, 19);
            this.RunScriptButton.TabIndex = 23;
            this.RunScriptButton.Text = "Run Script All?";
            this.RunScriptButton.UseVisualStyleBackColor = true;
            // 
            // LoadCmdScriptButton
            // 
            this.LoadCmdScriptButton.Enabled = false;
            this.LoadCmdScriptButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCmdScriptButton.Location = new System.Drawing.Point(539, 332);
            this.LoadCmdScriptButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadCmdScriptButton.Name = "LoadCmdScriptButton";
            this.LoadCmdScriptButton.Size = new System.Drawing.Size(139, 26);
            this.LoadCmdScriptButton.TabIndex = 22;
            this.LoadCmdScriptButton.Text = "Load Cmd Script";
            this.LoadCmdScriptButton.UseVisualStyleBackColor = true;
            // 
            // FilterSelectedCheckBox
            // 
            this.FilterSelectedCheckBox.AutoSize = true;
            this.FilterSelectedCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterSelectedCheckBox.Location = new System.Drawing.Point(327, 254);
            this.FilterSelectedCheckBox.Name = "FilterSelectedCheckBox";
            this.FilterSelectedCheckBox.Size = new System.Drawing.Size(138, 19);
            this.FilterSelectedCheckBox.TabIndex = 21;
            this.FilterSelectedCheckBox.Text = "Filter Selected?";
            this.FilterSelectedCheckBox.UseVisualStyleBackColor = true;
            this.FilterSelectedCheckBox.CheckedChanged += new System.EventHandler(this.FilterSelectedCheckBox_CheckedChanged);
            // 
            // RemoveAllCsgoButton
            // 
            this.RemoveAllCsgoButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAllCsgoButton.Location = new System.Drawing.Point(302, 221);
            this.RemoveAllCsgoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveAllCsgoButton.Name = "RemoveAllCsgoButton";
            this.RemoveAllCsgoButton.Size = new System.Drawing.Size(195, 26);
            this.RemoveAllCsgoButton.TabIndex = 20;
            this.RemoveAllCsgoButton.Text = "Remove All";
            this.RemoveAllCsgoButton.UseVisualStyleBackColor = true;
            this.RemoveAllCsgoButton.Click += new System.EventHandler(this.RemoveAllCsgoButton_Click);
            // 
            // RemoveSelectedCsgo
            // 
            this.RemoveSelectedCsgo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedCsgo.Location = new System.Drawing.Point(302, 187);
            this.RemoveSelectedCsgo.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveSelectedCsgo.Name = "RemoveSelectedCsgo";
            this.RemoveSelectedCsgo.Size = new System.Drawing.Size(195, 26);
            this.RemoveSelectedCsgo.TabIndex = 19;
            this.RemoveSelectedCsgo.Text = "Remove Selected";
            this.RemoveSelectedCsgo.UseVisualStyleBackColor = true;
            this.RemoveSelectedCsgo.Click += new System.EventHandler(this.RemoveSelectedCsgo_Click);
            // 
            // ConnectedCsgoLabel
            // 
            this.ConnectedCsgoLabel.AutoSize = true;
            this.ConnectedCsgoLabel.Location = new System.Drawing.Point(298, 0);
            this.ConnectedCsgoLabel.Name = "ConnectedCsgoLabel";
            this.ConnectedCsgoLabel.Size = new System.Drawing.Size(207, 19);
            this.ConnectedCsgoLabel.TabIndex = 18;
            this.ConnectedCsgoLabel.Text = "Connected-Csgo-Clients";
            // 
            // ListenerListBox
            // 
            this.ListenerListBox.BackColor = System.Drawing.Color.DimGray;
            this.ListenerListBox.FormattingEnabled = true;
            this.ListenerListBox.ItemHeight = 19;
            this.ListenerListBox.Location = new System.Drawing.Point(302, 23);
            this.ListenerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ListenerListBox.Name = "ListenerListBox";
            this.ListenerListBox.Size = new System.Drawing.Size(195, 156);
            this.ListenerListBox.TabIndex = 17;
            this.ListenerListBox.SelectedIndexChanged += new System.EventHandler(this.ListenerListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Scan-Results";
            // 
            // AddAllButton
            // 
            this.AddAllButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAllButton.Location = new System.Drawing.Point(128, 187);
            this.AddAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddAllButton.Name = "AddAllButton";
            this.AddAllButton.Size = new System.Drawing.Size(136, 34);
            this.AddAllButton.TabIndex = 14;
            this.AddAllButton.Text = "Add All";
            this.AddAllButton.UseVisualStyleBackColor = true;
            this.AddAllButton.Click += new System.EventHandler(this.AddAllButton_Click);
            // 
            // AddResultButton
            // 
            this.AddResultButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResultButton.Location = new System.Drawing.Point(8, 187);
            this.AddResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddResultButton.Name = "AddResultButton";
            this.AddResultButton.Size = new System.Drawing.Size(112, 34);
            this.AddResultButton.TabIndex = 13;
            this.AddResultButton.Text = "Add Result";
            this.AddResultButton.UseVisualStyleBackColor = true;
            this.AddResultButton.Click += new System.EventHandler(this.AddResultButton_Click);
            // 
            // CmdSelectedButton
            // 
            this.CmdSelectedButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSelectedButton.Location = new System.Drawing.Point(539, 298);
            this.CmdSelectedButton.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSelectedButton.Name = "CmdSelectedButton";
            this.CmdSelectedButton.Size = new System.Drawing.Size(139, 26);
            this.CmdSelectedButton.TabIndex = 12;
            this.CmdSelectedButton.Text = "Cmd Selected";
            this.CmdSelectedButton.UseVisualStyleBackColor = true;
            this.CmdSelectedButton.Click += new System.EventHandler(this.CmdSelectedButton_Click);
            // 
            // CmdAllButton
            // 
            this.CmdAllButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAllButton.Location = new System.Drawing.Point(686, 298);
            this.CmdAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAllButton.Name = "CmdAllButton";
            this.CmdAllButton.Size = new System.Drawing.Size(141, 26);
            this.CmdAllButton.TabIndex = 11;
            this.CmdAllButton.Text = "Cmd All";
            this.CmdAllButton.UseVisualStyleBackColor = true;
            this.CmdAllButton.Click += new System.EventHandler(this.CmdAllButton_Click);
            // 
            // VirtualConsoleRichTextBox
            // 
            this.VirtualConsoleRichTextBox.Location = new System.Drawing.Point(539, 233);
            this.VirtualConsoleRichTextBox.Name = "VirtualConsoleRichTextBox";
            this.VirtualConsoleRichTextBox.Size = new System.Drawing.Size(387, 58);
            this.VirtualConsoleRichTextBox.TabIndex = 10;
            this.VirtualConsoleRichTextBox.Text = "";
            // 
            // HostNameLabel
            // 
            this.HostNameLabel.AutoSize = true;
            this.HostNameLabel.Location = new System.Drawing.Point(3, 301);
            this.HostNameLabel.Name = "HostNameLabel";
            this.HostNameLabel.Size = new System.Drawing.Size(90, 19);
            this.HostNameLabel.TabIndex = 9;
            this.HostNameLabel.Text = "Host Name";
            // 
            // HostNameBox
            // 
            this.HostNameBox.Location = new System.Drawing.Point(92, 298);
            this.HostNameBox.Name = "HostNameBox";
            this.HostNameBox.Size = new System.Drawing.Size(172, 26);
            this.HostNameBox.TabIndex = 8;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(657, 0);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(144, 19);
            this.ConsoleLabel.TabIndex = 7;
            this.ConsoleLabel.Text = "Virtual Console";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port-Up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port-Low";
            // 
            // CmdLoopTextBox
            // 
            this.CmdLoopTextBox.Interval = 10;
            this.CmdLoopTextBox.Tick += new System.EventHandler(this.CmdLoopTextBox_Tick);
            // 
            // LoopCmdAllButton
            // 
            this.LoopCmdAllButton.AutoSize = true;
            this.LoopCmdAllButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopCmdAllButton.Location = new System.Drawing.Point(700, 353);
            this.LoopCmdAllButton.Name = "LoopCmdAllButton";
            this.LoopCmdAllButton.Size = new System.Drawing.Size(117, 19);
            this.LoopCmdAllButton.TabIndex = 33;
            this.LoopCmdAllButton.Text = "Loop Cmd All?";
            this.LoopCmdAllButton.UseVisualStyleBackColor = true;
            this.LoopCmdAllButton.CheckedChanged += new System.EventHandler(this.LoopCmdAllButton_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(552, 413);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(166, 19);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "Run Script Selected?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // LoopCmdSelectedButton
            // 
            this.LoopCmdSelectedButton.AutoSize = true;
            this.LoopCmdSelectedButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopCmdSelectedButton.Location = new System.Drawing.Point(700, 369);
            this.LoopCmdSelectedButton.Name = "LoopCmdSelectedButton";
            this.LoopCmdSelectedButton.Size = new System.Drawing.Size(152, 19);
            this.LoopCmdSelectedButton.TabIndex = 35;
            this.LoopCmdSelectedButton.Text = "Loop Cmd Selected?";
            this.LoopCmdSelectedButton.UseVisualStyleBackColor = true;
            this.LoopCmdSelectedButton.CheckedChanged += new System.EventHandler(this.LoopCmdSelectedButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 491);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main CSGO Controller [Glaxnet Solutions]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedAPp);
            ((System.ComponentModel.ISupportInitialize)(this.PortLowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortUpBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopDelayUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ScanResultBox;
        private System.Windows.Forms.Button DoScanButton;
        private System.Windows.Forms.RichTextBox VirtualConsoleBox;
        private System.Windows.Forms.NumericUpDown PortLowBox;
        private System.Windows.Forms.NumericUpDown PortUpBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HostNameLabel;
        private System.Windows.Forms.TextBox HostNameBox;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Button CmdSelectedButton;
        private System.Windows.Forms.Button CmdAllButton;
        private System.Windows.Forms.RichTextBox VirtualConsoleRichTextBox;
        private System.Windows.Forms.Button AddResultButton;
        private System.Windows.Forms.Button AddAllButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ConnectedCsgoLabel;
        private System.Windows.Forms.ListBox ListenerListBox;
        private System.Windows.Forms.Button RemoveAllCsgoButton;
        private System.Windows.Forms.Button RemoveSelectedCsgo;
        private System.Windows.Forms.CheckBox FilterSelectedCheckBox;
        private System.Windows.Forms.Button RunCfgAllButton;
        private System.Windows.Forms.Button RunCfgSelectedButton;
        private System.Windows.Forms.Button LoadCFGButton;
        private System.Windows.Forms.CheckBox RunScriptButton;
        private System.Windows.Forms.Button LoadCmdScriptButton;
        private System.Windows.Forms.CheckBox LoopCmdButton;
        private System.Windows.Forms.Button CmdMacrosButton;
        private System.Windows.Forms.Label ScanStatusLabel;
        private System.Windows.Forms.Label CurrentCFGLabel;
        private System.Windows.Forms.Label LoopDelayLabel;
        private System.Windows.Forms.NumericUpDown LoopDelayUpDown;
        private System.Windows.Forms.Timer CmdLoopTextBox;
        private System.Windows.Forms.CheckBox LoopCmdAllButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox LoopCmdSelectedButton;
    }
}

