namespace ESOResearchNotifier
{
    partial class ResearchItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.prgTime = new System.Windows.Forms.ProgressBar();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.lblDone = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item - Trait - TimeLeft";
            // 
            // prgTime
            // 
            this.prgTime.Location = new System.Drawing.Point(314, 3);
            this.prgTime.Name = "prgTime";
            this.prgTime.Size = new System.Drawing.Size(189, 23);
            this.prgTime.TabIndex = 1;
            // 
            // timerTick
            // 
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // lblDone
            // 
            this.lblDone.Location = new System.Drawing.Point(183, 6);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(125, 20);
            this.lblDone.TabIndex = 2;
            this.lblDone.Text = "FinishTime";
            // 
            // ResearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.prgTime);
            this.Controls.Add(this.lblName);
            this.Name = "ResearchItem";
            this.Size = new System.Drawing.Size(525, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar prgTime;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
