namespace ESOResearchNotifier
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
            this.cboCharacter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.cboNotifyStyle = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTimeout = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelResearch = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.notifyMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "ResearchDump.lua";
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "ESO Research Notifier";
            this.notifyIcon1.ContextMenuStrip = this.notifyMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ESO Research Notifier";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
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
            this.menuItemMain.Click += new System.EventHandler(this.menuItemMain_Click);
            // 
            // menuItemMute
            // 
            this.menuItemMute.CheckOnClick = true;
            this.menuItemMute.Name = "menuItemMute";
            this.menuItemMute.Size = new System.Drawing.Size(148, 22);
            this.menuItemMute.Text = "Mute";
            this.menuItemMute.ToolTipText = "Stop notifications from popping up";
            this.menuItemMute.Click += new System.EventHandler(this.menuItemMute_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(148, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.ToolTipText = "Exit Application";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCharacter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character";
            // 
            // cboCharacter
            // 
            this.cboCharacter.FormattingEnabled = true;
            this.cboCharacter.Location = new System.Drawing.Point(120, 46);
            this.cboCharacter.Name = "cboCharacter";
            this.cboCharacter.Size = new System.Drawing.Size(134, 21);
            this.cboCharacter.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cboCharacter, "Currently selected character");
            this.cboCharacter.SelectedIndexChanged += new System.EventHandler(this.cboCharacter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Character";
            this.toolTip1.SetToolTip(this.label2, "Currently selected character");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account";
            this.toolTip1.SetToolTip(this.label1, "Currently selected account");
            // 
            // cboAccount
            // 
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(120, 19);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(134, 21);
            this.cboAccount.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cboAccount, "Currently selected account");
            this.cboAccount.SelectedIndexChanged += new System.EventHandler(this.cboAccount_SelectedIndexChanged);
            // 
            // cboNotifyStyle
            // 
            this.cboNotifyStyle.FormattingEnabled = true;
            this.cboNotifyStyle.Location = new System.Drawing.Point(119, 19);
            this.cboNotifyStyle.Name = "cboNotifyStyle";
            this.cboNotifyStyle.Size = new System.Drawing.Size(134, 21);
            this.cboNotifyStyle.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cboNotifyStyle, "Style of notification; use the test button below");
            this.cboNotifyStyle.SelectedIndexChanged += new System.EventHandler(this.cboNotifyStyle_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTimeout);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboNotifyStyle);
            this.groupBox2.Location = new System.Drawing.Point(278, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 73);
            this.groupBox2.TabIndex = 10000;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notification Appearance";
            // 
            // cboTimeout
            // 
            this.cboTimeout.FormattingEnabled = true;
            this.cboTimeout.Location = new System.Drawing.Point(119, 46);
            this.cboTimeout.Name = "cboTimeout";
            this.cboTimeout.Size = new System.Drawing.Size(134, 21);
            this.cboTimeout.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboTimeout, "Time after which notifications fade if not interacted with (clicking a notificati" +
        "on will always dismiss it instantaneously)");
            this.cboTimeout.SelectedIndexChanged += new System.EventHandler(this.cboTimeout_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notification Timeout";
            this.toolTip1.SetToolTip(this.label4, "Time after which notifications fade if not interacted with (clicking a notificati" +
        "on will always dismiss it instantaneously)");
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notification Style";
            this.toolTip1.SetToolTip(this.label3, "Style of notification; use the test button below");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 10001;
            this.button2.Text = "Test Notification";
            this.toolTip1.SetToolTip(this.button2, "Sends a test notification to verify appearance settings");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(18, 458);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ResearchDump AddOn";
            this.toolTip1.SetToolTip(this.linkLabel1, "ResearchDump provides ESO Research Notifier with the required data. Without it, E" +
        "SO Research Notifier won\'t do anything.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelResearch
            // 
            this.panelResearch.Location = new System.Drawing.Point(12, 91);
            this.panelResearch.Name = "panelResearch";
            this.panelResearch.Size = new System.Drawing.Size(525, 356);
            this.panelResearch.TabIndex = 10002;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(148, 458);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(196, 23);
            this.linkLabel2.TabIndex = 10003;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Special thanks to Tamriel Trade Centre";
            this.toolTip1.SetToolTip(this.linkLabel2, "Lua.dll used for deserialisation kindly provided by TTC");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 488);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.panelResearch);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ESO Research Notifier";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.notifyMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cboCharacter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.ComboBox cboTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FlowLayoutPanel panelResearch;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

