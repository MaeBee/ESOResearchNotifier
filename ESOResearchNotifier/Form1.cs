using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ToastNotifications;
using Lua;

namespace ESOResearchNotifier
{

    public partial class Form1 : Form
    {
        private enum NotificationType { Balloon, Toast };
        private bool Mute = false;
        private string SavedVars = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Elder Scrolls Online\\live\\SavedVariables");
        private Dictionary<string, string> Config = new Dictionary<string, string>();
        private string ConfigPath = Application.StartupPath + "\\ESOResearchNotifier.xml";

        public Form1()
        {
            InitializeComponent();
            Config = XML.ReadData(ConfigPath);

            bool timeoutfound = false;
            cboTimeout.Items.Add(new ComboboxItem("1 second", 1000));
            cboTimeout.Items.Add(new ComboboxItem("3 seconds", 3000));
            cboTimeout.Items.Add(new ComboboxItem("5 seconds", 5000));
            cboTimeout.Items.Add(new ComboboxItem("8 seconds", 8000));
            cboTimeout.Items.Add(new ComboboxItem("10 seconds", 10000));
            if (Config.ContainsKey("notifytimeout"))
            {
                foreach (ComboboxItem item in cboTimeout.Items)
                {
                    if (item.Text == Config["notifytimeout"])
                    {
                        timeoutfound = true;
                        cboTimeout.SelectedItem = item;
                        break;
                    }
                }
            }
            if (!timeoutfound)
            {
                cboTimeout.SelectedIndex = 2;
            }

            bool notifystylefound = false;
            cboNotifyStyle.Items.Add(new ComboboxItem("Balloon", NotificationType.Balloon));
            cboNotifyStyle.Items.Add(new ComboboxItem("Toast", NotificationType.Toast));
            if (Config.ContainsKey("notifystyle"))
            {
                foreach (ComboboxItem item in cboNotifyStyle.Items)
                {
                    if (item.Text == Config["notifystyle"])
                    {
                        notifystylefound = true;
                        cboNotifyStyle.SelectedItem = item;
                        break;
                    }
                }
            }
            if (!notifystylefound)
            {
                cboNotifyStyle.SelectedIndex = 0;
            }

            if (Config.ContainsKey("mute"))
            {
                menuItemMute.Checked = Convert.ToBoolean(Config["mute"]);
            }

            fileSystemWatcher1.Path = SavedVars;

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

        private void ResearchDone(object sender, EventArgs e)
        {
            ResearchItem Item = (ResearchItem)sender;
            ShowNotification(Item.ItemName + " - " + Item.TraitName + " has finished for " + ((ComboboxItem)cboCharacter.SelectedItem).Text + "!");
            panelResearch.Controls.Remove(Item);
        }

        private void ReadDump()
        {
            if (!File.Exists(SavedVars + "\\ResearchDump.lua"))
            {
                MessageBox.Show("Please run the ResearchDump addon first and /reloadui to generate utilisable data");
                return;
            }
            string sTable = File.ReadAllText(SavedVars + "\\ResearchDump.lua");
            Dictionary<string, object> dTable = new Dictionary<string, object>();
            LuaSerializer Reader = new LuaSerializer();
            dTable = (Dictionary<string, object>)Reader.Deserialize(sTable).Value;

            string debugstring = "";
            cboAccount.Items.Clear();
            foreach (KeyValuePair<string, object> dAccount in (Dictionary<string, object>)dTable["Default"])
            {
                cboAccount.Items.Add(new ComboboxItem(dAccount.Key, (Dictionary<string, object>)dAccount.Value));
                debugstring += dAccount.Key + " = " + dAccount.Value + "\r\n";
            }
            if(cboAccount.Items.Count == 0)
            {
                MessageBox.Show("No valid data could be found. Please run the ResearchDump addon and /reloadui.\r\nIf the problem persists, delete " + SavedVars + "\\ResearchDump.lua and run the addon.\r\nIf the problem still persists, please file an issue on GitHub, attaching your ResearchDump.lua.");
            }
            else
            {
                bool found = false;
                if (Config.ContainsKey("selectedaccount"))
                {
                    foreach (ComboboxItem item in cboAccount.Items)
                    {
                        if (item.Text == Config["selectedaccount"])
                        {
                            found = true;
                            cboAccount.SelectedItem = item;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    cboAccount.SelectedIndex = 0;
                }
            }
            //MessageBox.Show(debugstring);
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            ReadDump();
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menuItemMute_Click(object sender, EventArgs e)
        {
            Mute = menuItemMute.Checked;
            Config["mute"] = Mute.ToString();
            XML.WriteData(ConfigPath, Config);
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

        private void cboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResearch.Controls.Clear();
            cboCharacter.Items.Clear();
            ComboboxItem selectedAccount = (ComboboxItem)cboAccount.SelectedItem;
            Config["selectedaccount"] = selectedAccount.Text;
            XML.WriteData(ConfigPath, Config);
            foreach (KeyValuePair<string, object> accountCharacters in (Dictionary<string, object>)selectedAccount.Value)
            {
                cboCharacter.Items.Add(new ComboboxItem(accountCharacters.Key, (Dictionary<string, object>)accountCharacters.Value));
            }
            if (cboCharacter.Items.Count == 0)
            {
                MessageBox.Show("No valid data could be found. Please run the ResearchDump addon and /reloadui.\r\nIf the problem persists, delete " + SavedVars + "\\ResearchDump.lua and run the addon.\r\nIf the problem still persists, please file an issue on GitHub, attaching your ResearchDump.lua.");
            }
            else
            {
                bool found = false;
                if (Config.ContainsKey("selectedchar"))
                {
                    foreach (ComboboxItem item in cboCharacter.Items)
                    {
                        if (item.Text == Config["selectedchar"])
                        {
                            found = true;
                            cboCharacter.SelectedItem = item;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    cboCharacter.SelectedIndex = 0;
                }
            }
        }

        private void cboCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResearch.Controls.Clear();
            ComboboxItem selectedCharacter = (ComboboxItem)cboCharacter.SelectedItem;
            Config["selectedchar"] = selectedCharacter.Text;
            XML.WriteData(ConfigPath, Config);
            foreach (KeyValuePair<string, object> CraftingDiscipline in (Dictionary<string, object>)selectedCharacter.Value)
            {
                if (CraftingDiscipline.Key == "0")
                {
                    ResearchItem tItem = new ResearchItem();
                    tItem.CraftingDiscipline = ResearchItem.CraftingType.Stable;
                    DateTime FinishTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    FinishTime = FinishTime.AddSeconds(Convert.ToDouble(CraftingDiscipline.Value)).ToLocalTime();
                    tItem.FinishTime = FinishTime;
                    tItem.Duration = new TimeSpan(20, 0, 0);
                    if (tItem.TimeLeft.Ticks > 0)
                    {
                        tItem.ResearchDone += new EventHandler(ResearchDone);
                        tItem.Setup();
                        panelResearch.Controls.Add(tItem);
                    }
                }
                else if(CraftingDiscipline.Key != "version")
                {
                    ResearchItem.CraftingType craftType = (ResearchItem.CraftingType)Convert.ToInt32(CraftingDiscipline.Key);
                    foreach (KeyValuePair<string, object> item in (Dictionary<string, object>)CraftingDiscipline.Value)
                    {
                        int itemIndex = Convert.ToInt32(item.Key) - 1;
                        foreach (KeyValuePair<string, object> trait in (Dictionary<string, object>)item.Value)
                        {
                            int traitIndex = Convert.ToInt32(trait.Key) - 1;
                            double finishTime = 0;
                            double duration = 0;
                            foreach (KeyValuePair<string, object> variable in (Dictionary<string, object>)trait.Value)
                            {
                                if (variable.Key == "finishTime")
                                {
                                    finishTime = Convert.ToDouble(variable.Value);
                                }
                                else if (variable.Key == "duration")
                                {
                                    duration = Convert.ToDouble(variable.Value);
                                }
                            }
                            if (finishTime > 0)
                            {
                                ResearchItem tItem = new ResearchItem();
                                tItem.CraftingDiscipline = craftType;
                                DateTime FinishTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                                FinishTime = FinishTime.AddSeconds(finishTime).ToLocalTime();
                                tItem.FinishTime = FinishTime;
                                DateTime durationHelper = new DateTime();
                                durationHelper = durationHelper.AddSeconds(duration);
                                tItem.Duration = durationHelper - DateTime.MinValue;
                                tItem.TraitIndex = traitIndex;
                                tItem.ItemIndex = itemIndex;
                                if (tItem.TimeLeft.Ticks > 0)
                                {
                                    // MessageBox.Show(tItem.CraftingDiscipline.ToString() + " - " + tItem.ItemName + " - " + tItem.TraitName + " " + tItem.TimeLeftString);
                                    tItem.ResearchDone += new EventHandler(ResearchDone);
                                    tItem.Setup();
                                    panelResearch.Controls.Add(tItem);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tamrieltradecentre.com/");
        }

        private void cboNotifyStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem notifyStyle = (ComboboxItem)cboNotifyStyle.SelectedItem;
            Config["notifystyle"] = notifyStyle.Text;
            XML.WriteData(ConfigPath, Config);
        }

        private void cboTimeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem notifyTimeout = (ComboboxItem)cboTimeout.SelectedItem;
            Config["notifytimeout"] = notifyTimeout.Text;
            XML.WriteData(ConfigPath, Config);
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