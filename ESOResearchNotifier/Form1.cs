using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ToastNotifications;

namespace ESOResearchNotifier
{
    public partial class Form1 : Form
    {
        private enum NotificationType { Balloon, Toast };
        private enum CraftingType { Stable = 0, Blacksmithing = 1, Clothier = 2, Woodworking = 6};
        private int[] BlacksmithingTypes = { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
        private int[] ClothierTypes = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private int[] WoodworkingTypes = { 0, 0, 0, 0, 0, 1 };
        private string[] WeaponTraits = { "Powered", "Charged", "Precise", "Infused", "Defending", "Training", "Sharpened", "Decisive", "Nirnhoned" };
        private string[] ArmourTraits = { "Sturdy", "Impenetrable", "Reinforced", "Well-Fitted", "Training", "Infused", "Prosperous", "Divines", "Nirnhoned" };
        private bool Mute = false;

        public Form1()
        {
            InitializeComponent();

            cboTimeout.Items.Add(new ComboboxItem("1 second", 1000));
            cboTimeout.Items.Add(new ComboboxItem("3 seconds", 3000));
            cboTimeout.Items.Add(new ComboboxItem("5 seconds", 5000));
            cboTimeout.Items.Add(new ComboboxItem("8 seconds", 8000));
            cboTimeout.Items.Add(new ComboboxItem("10 seconds", 10000));
            cboTimeout.SelectedIndex = 2;

            cboNotifyStyle.Items.Add(new ComboboxItem("Balloon", NotificationType.Balloon));
            cboNotifyStyle.Items.Add(new ComboboxItem("Toast", NotificationType.Toast));
            cboNotifyStyle.SelectedIndex = 0;

            fileSystemWatcher1.Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Elder Scrolls Online\\live\\SavedVariables");

            ReadDump();
        }

        private void ShowNotification(string Content)
        {
            if (!Mute)
            {
                ComboboxItem NotifyStyle = (ComboboxItem)cboNotifyStyle.SelectedItem;
                ComboboxItem Timeout = (ComboboxItem)cboTimeout.SelectedItem;

                if ((NotificationType)NotifyStyle.Value == NotificationType.Balloon)
                {
                    notifyIcon1.BalloonTipText = Content;
                    notifyIcon1.ShowBalloonTip((int)Timeout.Value);
                }
                else if ((NotificationType)NotifyStyle.Value == NotificationType.Toast)
                {
                    Notification toastNotification = new Notification("ESO Research Notifier", Content, (int)Timeout.Value, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Up);
                    toastNotification.Show();
                }
            }
        }

        private void ReadDump()
        {
            if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Elder Scrolls Online\\live\\SavedVariables\\ResearchDump.lua")))
            {
                MessageBox.Show("Please run the ResearchDump addon first and /reloadui to generate utilisable data");
                return;
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            ReadDump();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menuItemMute_Click(object sender, EventArgs e)
        {
            Mute = chkMute.Checked = menuItemMute.Checked;
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            Mute = menuItemMute.Checked = chkMute.Checked;
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                this.ShowInTaskbar = false;
            }
            else
            {
                this.ShowInTaskbar = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowNotification("This is a test.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gobbo1008/ResearchDump/releases/latest");
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboboxItem() : this(null, null)
        {
        }

        public ComboboxItem(string Text, object Value)
        {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}