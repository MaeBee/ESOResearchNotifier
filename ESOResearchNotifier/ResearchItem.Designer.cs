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
            this.timerDone = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item - Trait - TimeLeft";
            // 
            // prgTime
            // 
            this.prgTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prgTime.Location = new System.Drawing.Point(421, 3);
            this.prgTime.Name = "prgTime";
            this.prgTime.Size = new System.Drawing.Size(225, 23);
            this.prgTime.TabIndex = 1;
            // 
            // timerTick
            // 
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDone.Location = new System.Drawing.Point(290, 6);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(125, 20);
            this.lblDone.TabIndex = 2;
            this.lblDone.Text = "FinishTime";
            // 
            // timerDone
            // 
            this.timerDone.Tick += new System.EventHandler(this.timerDone_Tick);
            // 
            // ResearchItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.prgTime);
            this.Controls.Add(this.lblName);
            this.Name = "ResearchItem";
            this.Size = new System.Drawing.Size(649, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar prgTime;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerDone;
    }
}
