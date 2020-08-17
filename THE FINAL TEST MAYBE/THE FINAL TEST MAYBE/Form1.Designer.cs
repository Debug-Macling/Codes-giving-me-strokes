namespace THE_FINAL_TEST_MAYBE
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inMeetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bathroomBreakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Controls";
            this.notifyIcon1.BalloonTipTitle = "BlinkLight";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BlinkLight";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableToolStripMenuItem,
            this.awayToolStripMenuItem,
            this.busyToolStripMenuItem,
            this.inMeetingToolStripMenuItem,
            this.bathroomBreakToolStripMenuItem,
            this.languageSettingsToolStripMenuItem,
            this.powerOffToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 158);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources._1f7e2_IZA_icon;
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            this.availableToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.availableToolStripMenuItem.Text = "Available";
            this.availableToolStripMenuItem.Click += new System.EventHandler(this.availableToolStripMenuItem_Click);
            this.availableToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.availableToolStripMenuItem_Paint);
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources._1f7e1_Pla_icon;
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            this.awayToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.awayToolStripMenuItem.Text = "Away";
            this.awayToolStripMenuItem.Click += new System.EventHandler(this.awayToolStripMenuItem_Click);
            // 
            // busyToolStripMenuItem
            // 
            this.busyToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources.red_circle_small__svg_Bwj_icon;
            this.busyToolStripMenuItem.Name = "busyToolStripMenuItem";
            this.busyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.busyToolStripMenuItem.Text = "Busy";
            this.busyToolStripMenuItem.Click += new System.EventHandler(this.busyToolStripMenuItem_Click);
            // 
            // inMeetingToolStripMenuItem
            // 
            this.inMeetingToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources._1f7e0_fGf_icon;
            this.inMeetingToolStripMenuItem.Name = "inMeetingToolStripMenuItem";
            this.inMeetingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.inMeetingToolStripMenuItem.Text = "In meeting";
            this.inMeetingToolStripMenuItem.Click += new System.EventHandler(this.inMeetingToolStripMenuItem_Click);
            // 
            // bathroomBreakToolStripMenuItem
            // 
            this.bathroomBreakToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources._1200px_light_blue_circle_svg_9rQ_icon;
            this.bathroomBreakToolStripMenuItem.Name = "bathroomBreakToolStripMenuItem";
            this.bathroomBreakToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bathroomBreakToolStripMenuItem.Text = "Bathroom break";
            this.bathroomBreakToolStripMenuItem.Click += new System.EventHandler(this.bathroomBreakToolStripMenuItem_Click);
            // 
            // languageSettingsToolStripMenuItem
            // 
            this.languageSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.DeutschToolStripMenuItem});
            this.languageSettingsToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources.icon_ios7_gear_512_6Bh_icon;
            this.languageSettingsToolStripMenuItem.Name = "languageSettingsToolStripMenuItem";
            this.languageSettingsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.languageSettingsToolStripMenuItem.Text = "Language Settings";
            this.languageSettingsToolStripMenuItem.Click += new System.EventHandler(this.languageSettingsToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.frenchToolStripMenuItem.Text = "Français";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // DeutschToolStripMenuItem
            // 
            this.DeutschToolStripMenuItem.Name = "DeutschToolStripMenuItem";
            this.DeutschToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.DeutschToolStripMenuItem.Text = "Deutsch";
            this.DeutschToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // powerOffToolStripMenuItem
            // 
            this.powerOffToolStripMenuItem.Image = global::THE_FINAL_TEST_MAYBE.Properties.Resources.cross_24_512_pDX_icon;
            this.powerOffToolStripMenuItem.Name = "powerOffToolStripMenuItem";
            this.powerOffToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.powerOffToolStripMenuItem.Text = "Power off";
            this.powerOffToolStripMenuItem.Click += new System.EventHandler(this.powerOffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 334);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Blinklight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inMeetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bathroomBreakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerOffToolStripMenuItem;
    }
}

