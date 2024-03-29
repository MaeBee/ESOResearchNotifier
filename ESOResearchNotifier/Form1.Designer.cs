﻿namespace ESOResearchNotifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new ESOResearchNotifier.FixedTreeView();
            this.cboNotifyStyle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTimeout = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelResearch = new System.Windows.Forms.Panel();
            this.btnSortDefault = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.prgUpdate = new System.Windows.Forms.ProgressBar();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.chkRiding = new System.Windows.Forms.CheckBox();
            this.chkBlacksmithing = new System.Windows.Forms.CheckBox();
            this.chkClothier = new System.Windows.Forms.CheckBox();
            this.chkWoodworking = new System.Windows.Forms.CheckBox();
            this.chkJewelry = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.notifyMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "ResearchDump.lua";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.FileSystemWatcher1_Changed);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "ESO Research Notifier";
            this.notifyIcon1.ContextMenuStrip = this.notifyMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ESO Research Notifier";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // notifyMenuStrip1
            // 
            this.notifyMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMain,
            this.menuItemMute,
            this.menuItemExit});
            this.notifyMenuStrip1.Name = "notifyMenuStrip1";
            this.notifyMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // menuItemMain
            // 
            this.menuItemMain.DoubleClickEnabled = true;
            this.menuItemMain.Name = "menuItemMain";
            this.menuItemMain.Size = new System.Drawing.Size(148, 22);
            this.menuItemMain.Text = "Main Window";
            this.menuItemMain.ToolTipText = "Show the main window";
            this.menuItemMain.Click += new System.EventHandler(this.MenuItemMain_Click);
            // 
            // menuItemMute
            // 
            this.menuItemMute.CheckOnClick = true;
            this.menuItemMute.Name = "menuItemMute";
            this.menuItemMute.Size = new System.Drawing.Size(148, 22);
            this.menuItemMute.Text = "Mute";
            this.menuItemMute.ToolTipText = "Stop notifications from popping up";
            this.menuItemMute.Click += new System.EventHandler(this.MenuItemMute_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(148, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.ToolTipText = "Exit Application";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(685, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 189);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characters";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(254, 170);
            this.treeView1.TabIndex = 21;
            this.toolTip1.SetToolTip(this.treeView1, "Select the characters you want to track here. If an account or character does not" +
        " show up here, make sure to log in with that character whilst running the Resear" +
        "chDump addon at least once.");
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // cboNotifyStyle
            // 
            this.cboNotifyStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNotifyStyle.FormattingEnabled = true;
            this.cboNotifyStyle.Location = new System.Drawing.Point(119, 19);
            this.cboNotifyStyle.Name = "cboNotifyStyle";
            this.cboNotifyStyle.Size = new System.Drawing.Size(134, 21);
            this.cboNotifyStyle.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cboNotifyStyle, "Style of notification; use the test button below");
            this.cboNotifyStyle.SelectedIndexChanged += new System.EventHandler(this.cboNotifyStyle_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboTimeout);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboNotifyStyle);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(685, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 102);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification Appearance";
            // 
            // cboTimeout
            // 
            this.cboTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeout.FormattingEnabled = true;
            this.cboTimeout.Location = new System.Drawing.Point(119, 46);
            this.cboTimeout.Name = "cboTimeout";
            this.cboTimeout.Size = new System.Drawing.Size(134, 21);
            this.cboTimeout.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cboTimeout, "Time after which notifications fade if not interacted with (clicking a notificati" +
        "on will always dismiss it instantaneously)");
            this.cboTimeout.SelectedIndexChanged += new System.EventHandler(this.cboTimeout_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Notification Timeout";
            this.toolTip1.SetToolTip(this.label4, "Time after which notifications fade if not interacted with (clicking a notificati" +
        "on will always dismiss it instantaneously)");
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Notification Style";
            this.toolTip1.SetToolTip(this.label3, "Style of notification; use the test button below");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Test Notification";
            this.toolTip1.SetToolTip(this.button2, "Sends a test notification to verify appearance settings");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Location = new System.Drawing.Point(685, 424);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 23);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ResearchDump AddOn";
            this.toolTip1.SetToolTip(this.linkLabel1, "ResearchDump provides ESO Research Notifier with the required data. Without it, E" +
        "SO Research Notifier won\'t do anything.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.Location = new System.Drawing.Point(685, 456);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(196, 23);
            this.linkLabel2.TabIndex = 31;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Special thanks to Tamriel Trade Centre";
            this.toolTip1.SetToolTip(this.linkLabel2, "Lua.dll used for deserialisation kindly provided by TTC");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panelResearch);
            this.groupBox3.Controls.Add(this.btnSortDefault);
            this.groupBox3.Controls.Add(this.btnSortName);
            this.groupBox3.Controls.Add(this.btnSortTime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblDone);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 464);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Research";
            // 
            // panelResearch
            // 
            this.panelResearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResearch.AutoScroll = true;
            this.panelResearch.BackColor = System.Drawing.SystemColors.Control;
            this.panelResearch.Location = new System.Drawing.Point(7, 46);
            this.panelResearch.Name = "panelResearch";
            this.panelResearch.Size = new System.Drawing.Size(654, 412);
            this.panelResearch.TabIndex = 7;
            // 
            // btnSortDefault
            // 
            this.btnSortDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortDefault.Location = new System.Drawing.Point(581, 17);
            this.btnSortDefault.Name = "btnSortDefault";
            this.btnSortDefault.Size = new System.Drawing.Size(80, 23);
            this.btnSortDefault.TabIndex = 6;
            this.btnSortDefault.Text = "Reset Sorting";
            this.btnSortDefault.UseVisualStyleBackColor = true;
            this.btnSortDefault.Click += new System.EventHandler(this.btnSortDefault_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(138, 17);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(39, 23);
            this.btnSortName.TabIndex = 2;
            this.btnSortName.Text = "Sort";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortTime
            // 
            this.btnSortTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortTime.Location = new System.Drawing.Point(363, 17);
            this.btnSortTime.Name = "btnSortTime";
            this.btnSortTime.Size = new System.Drawing.Size(39, 23);
            this.btnSortTime.TabIndex = 4;
            this.btnSortTime.Text = "Sort";
            this.btnSortTime.UseVisualStyleBackColor = true;
            this.btnSortTime.Click += new System.EventHandler(this.btnSortTime_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Progress";
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.Location = new System.Drawing.Point(286, 22);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(71, 20);
            this.lblDone.TabIndex = 3;
            this.lblDone.Text = "Finish Time";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Character and Item";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(838, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update Available!";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // prgUpdate
            // 
            this.prgUpdate.Enabled = false;
            this.prgUpdate.Location = new System.Drawing.Point(838, 419);
            this.prgUpdate.Name = "prgUpdate";
            this.prgUpdate.Size = new System.Drawing.Size(100, 23);
            this.prgUpdate.TabIndex = 0;
            this.prgUpdate.Visible = false;
            // 
            // grpFilters
            // 
            this.grpFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilters.Controls.Add(this.chkJewelry);
            this.grpFilters.Controls.Add(this.chkWoodworking);
            this.grpFilters.Controls.Add(this.chkClothier);
            this.grpFilters.Controls.Add(this.chkBlacksmithing);
            this.grpFilters.Controls.Add(this.chkRiding);
            this.grpFilters.Location = new System.Drawing.Point(685, 315);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(260, 98);
            this.grpFilters.TabIndex = 22;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filter";
            // 
            // chkRiding
            // 
            this.chkRiding.AutoSize = true;
            this.chkRiding.Checked = true;
            this.chkRiding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRiding.Location = new System.Drawing.Point(6, 19);
            this.chkRiding.Name = "chkRiding";
            this.chkRiding.Size = new System.Drawing.Size(56, 17);
            this.chkRiding.TabIndex = 0;
            this.chkRiding.Tag = "0";
            this.chkRiding.Text = "Riding";
            this.chkRiding.UseVisualStyleBackColor = true;
            this.chkRiding.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkBlacksmithing
            // 
            this.chkBlacksmithing.AutoSize = true;
            this.chkBlacksmithing.Checked = true;
            this.chkBlacksmithing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlacksmithing.Location = new System.Drawing.Point(6, 33);
            this.chkBlacksmithing.Name = "chkBlacksmithing";
            this.chkBlacksmithing.Size = new System.Drawing.Size(91, 17);
            this.chkBlacksmithing.TabIndex = 1;
            this.chkBlacksmithing.Tag = "1";
            this.chkBlacksmithing.Text = "Blacksmithing";
            this.chkBlacksmithing.UseVisualStyleBackColor = true;
            this.chkBlacksmithing.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkClothier
            // 
            this.chkClothier.AutoSize = true;
            this.chkClothier.Checked = true;
            this.chkClothier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClothier.Location = new System.Drawing.Point(6, 47);
            this.chkClothier.Name = "chkClothier";
            this.chkClothier.Size = new System.Drawing.Size(61, 17);
            this.chkClothier.TabIndex = 2;
            this.chkClothier.Tag = "2";
            this.chkClothier.Text = "Clothier";
            this.chkClothier.UseVisualStyleBackColor = true;
            this.chkClothier.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkWoodworking
            // 
            this.chkWoodworking.AutoSize = true;
            this.chkWoodworking.Checked = true;
            this.chkWoodworking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWoodworking.Location = new System.Drawing.Point(6, 61);
            this.chkWoodworking.Name = "chkWoodworking";
            this.chkWoodworking.Size = new System.Drawing.Size(92, 17);
            this.chkWoodworking.TabIndex = 3;
            this.chkWoodworking.Tag = "6";
            this.chkWoodworking.Text = "Woodworking";
            this.chkWoodworking.UseVisualStyleBackColor = true;
            this.chkWoodworking.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // chkJewelry
            // 
            this.chkJewelry.AutoSize = true;
            this.chkJewelry.Checked = true;
            this.chkJewelry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJewelry.Location = new System.Drawing.Point(6, 75);
            this.chkJewelry.Name = "chkJewelry";
            this.chkJewelry.Size = new System.Drawing.Size(61, 17);
            this.chkJewelry.TabIndex = 4;
            this.chkJewelry.Tag = "7";
            this.chkJewelry.Text = "Jewelry";
            this.chkJewelry.UseVisualStyleBackColor = true;
            this.chkJewelry.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 488);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.prgUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ESO Research Notifier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.notifyMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemMute;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNotifyStyle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private FixedTreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSortTime;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortDefault;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ProgressBar prgUpdate;
        private System.Windows.Forms.Panel panelResearch;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.CheckBox chkBlacksmithing;
        private System.Windows.Forms.CheckBox chkRiding;
        private System.Windows.Forms.CheckBox chkJewelry;
        private System.Windows.Forms.CheckBox chkWoodworking;
        private System.Windows.Forms.CheckBox chkClothier;
    }
}

