using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Updater
{
    public partial class Form1 : Form
    {
        private bool UpdatePerformed = false;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            progressBar1.Value = 0;
            textBox1.Text = "";
            int TimeElapsed = 0;
            if (Process.GetProcessesByName("ESOResearchNotifier").Length > 0)
            {
                textBox1.Text += "Main process still running; waiting...\r\n";
                while ((Process.GetProcessesByName("ESOResearchNotifier").Length > 0) || (TimeElapsed < 10000))
                {
                    string output = "";
                    foreach (var process in Process.GetProcessesByName("ESOResearchNotifier"))
                    {
                        output += process.ProcessName + " - " + process.Id + "\r\n";
                    }
                    MessageBox.Show(output + Process.GetProcessesByName("ESOResearchNotifier").Length.ToString());
                    Thread.Sleep(500);
                    TimeElapsed += 500;
                }
                if (TimeElapsed >= 10000)
                {
                    textBox1.Text += "Main process still running; 10s timeout.\r\nPlease terminate all instances of the main process manually and run Updater.exe.\r\nDone.";
                    return;
                }
            }
            textBox1.Text += "Unpacking update:\r\n";
            ZipArchive UpdateArchive = ZipFile.OpenRead(Application.StartupPath + "\\ESOResearchNotifier.zip");
            progressBar1.Maximum = UpdateArchive.Entries.Count;
            foreach (ZipArchiveEntry UpdateEntry in UpdateArchive.Entries)
            {
                if (UpdateEntry.Name.Contains(".") && !UpdateEntry.Name.EndsWith("Updater.exe"))
                {
                    textBox1.Text += "  " + UpdateEntry.FullName.Substring(20).Replace("/", "\\") + "\r\n";
                    UpdateEntry.ExtractToFile(Application.StartupPath + "\\" + UpdateEntry.FullName.Substring(20).Replace("/", "\\"), true);
                    progressBar1.PerformStep();
                }
            }
            UpdateArchive.Dispose();
            UpdatePerformed = true;
            textBox1.Text += "Update complete.\r\nDone.";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UpdatePerformed)
            {
                Process.Start("ESOResearchNotifier.exe");
            }
        }
    }
}
