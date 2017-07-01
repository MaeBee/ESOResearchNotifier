using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESOResearchNotifier
{
    public partial class ResearchItem : UserControl
    {
        public event EventHandler ResearchDone;

        public enum CraftingType { Stable = 0, Blacksmithing = 1, Clothier = 2, Woodworking = 6 };
        public int[] BlacksmithingTypes = { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
        public string[] BlacksmithNames = { "Axe", "Mace", "Sword", "Battle Axe", "Maul", "Greatsword", "Dagger", "Cuirass", "Sabatons", "Gauntlets", "Helm", "Greaves", "Pauldron", "Girdle" };
        public int[] ClothierTypes = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        public string[] ClothierNames = { "Robe", "Shoes", "Gloves", "Hat", "Breeches", "Epaulets", "Sash", "Jack", "Boots", "Bracers", "Helmet", "Guards", "Arm Cops", "Belt" };
        public int[] WoodworkingTypes = { 0, 0, 0, 0, 0, 1 };
        public string[] WoodworkingNames = { "Bow", "Inferno Staff", "Ice Staff", "Lightning Staff", "Restoration Staff", "Shield" };
        public string[,] Traits  = {{ "Powered", "Charged", "Precise", "Infused", "Defending", "Training", "Sharpened", "Decisive", "Nirnhoned" }, { "Sturdy", "Impenetrable", "Reinforced", "Well-Fitted", "Training", "Infused", "Prosperous", "Divines", "Nirnhoned" }};

        public CraftingType CraftingDiscipline { get; set; }
        public int ItemIndex { get; set; } = -1;
        public string ItemName
        {
            get
            {
                switch(CraftingDiscipline)
                {
                    case CraftingType.Stable:
                        return "Riding";
                    case CraftingType.Blacksmithing:
                        return BlacksmithNames[ItemIndex];
                    case CraftingType.Clothier:
                        return ClothierNames[ItemIndex];
                    case CraftingType.Woodworking:
                        return WoodworkingNames[ItemIndex];
                    default:
                        return null;
                }
            }
        }
        public int TraitIndex { get; set; } = -1;
        public string TraitName
        {
            get
            {
                switch (CraftingDiscipline)
                {
                    case CraftingType.Stable:
                        return "Cooldown";
                    case CraftingType.Blacksmithing:
                        return Traits[BlacksmithingTypes[ItemIndex], TraitIndex];
                    case CraftingType.Clothier:
                        return Traits[ClothierTypes[ItemIndex], TraitIndex];
                    case CraftingType.Woodworking:
                        return Traits[WoodworkingTypes[ItemIndex], TraitIndex];
                    default:
                        return null;
                }
            }
        }
        public TimeSpan Duration { get; set; }
        public DateTime FinishTime { get; set; }

        public TimeSpan TimeLeft
        {
            get
            {
                return FinishTime - DateTime.Now;
            }
        }

        public string TimeLeftString
        {
            get
            {
                return TimeLeft.Days + "d " + TimeLeft.Hours + "h " + TimeLeft.Minutes + "m " + TimeLeft.Seconds + "s left";
            }
        }

        public TimeSpan TimeDone
        {
            get
            {
                return Duration - TimeLeft;
            }
        }

        private void SetLabelText()
        {
            string Text = null;
            Text += ItemName;
            if (Text != null)
            {
                Text += " - ";
            }
            Text += TraitName;
            Text += " - ";
            Text += TimeLeftString;
            lblName.Text = Text;
            lblDone.Text = FinishTime.ToString();
        }

        public ResearchItem()
        {
            InitializeComponent();
        }

        public void Setup()
        {
            if (!timerTick.Enabled)
            {
                timerTick.Start();
            }
            if (TimeLeft.TotalSeconds <= 0)
            {
                if (this.ResearchDone != null)
                {
                    this.ResearchDone(this, new EventArgs());
                }
                return;
            }
            //MessageBox.Show(((int)((TimeDone.TotalSeconds / Duration.TotalSeconds) * 100)).ToString());
            prgTime.Value = (int)((TimeDone.TotalSeconds / Duration.TotalSeconds) * 100);
            SetLabelText();
            Update();
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            Setup();
        }
    }
}
