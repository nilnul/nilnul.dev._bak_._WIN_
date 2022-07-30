namespace nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar.shieldsSel
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
			this.shields1 = new nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar.retVoid__startOfPar_ShieldsSel1();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shieldsBakedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modulesBakedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.shieldsNotBakedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modulesNotBakedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// shields1
			// 
			this.shields1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shields1.Location = new System.Drawing.Point(0, 0);
			this.shields1.Name = "shields1";
			this.shields1.Size = new System.Drawing.Size(541, 380);
			this.shields1.TabIndex = 0;
			this.shields1.txt = "";
			this.shields1.started += new System.Action(this.shields1_started);
			this.shields1.finished += new System.Action(this.shields1_finished);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.bakToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(541, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 开始ToolStripMenuItem
			// 
			this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cfgToolStripMenuItem});
			this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
			this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.开始ToolStripMenuItem.Text = "开始";
			// 
			// cfgToolStripMenuItem
			// 
			this.cfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.shieldsBakedToolStripMenuItem,
            this.shieldsNotBakedToolStripMenuItem,
            this.modulesBakedToolStripMenuItem,
            this.modulesNotBakedToolStripMenuItem});
			this.cfgToolStripMenuItem.Name = "cfgToolStripMenuItem";
			this.cfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cfgToolStripMenuItem.Text = "_Cfg_";
			// 
			// shieldsBakedToolStripMenuItem
			// 
			this.shieldsBakedToolStripMenuItem.Name = "shieldsBakedToolStripMenuItem";
			this.shieldsBakedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.shieldsBakedToolStripMenuItem.Text = "ShieldsBaked";
			this.shieldsBakedToolStripMenuItem.Click += new System.EventHandler(this.shieldsBakedToolStripMenuItem_Click);
			// 
			// modulesBakedToolStripMenuItem
			// 
			this.modulesBakedToolStripMenuItem.Name = "modulesBakedToolStripMenuItem";
			this.modulesBakedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.modulesBakedToolStripMenuItem.Text = "ModulesBaked";
			this.modulesBakedToolStripMenuItem.Click += new System.EventHandler(this.modulesBakedToolStripMenuItem_Click);
			// 
			// bakToolStripMenuItem
			// 
			this.bakToolStripMenuItem.Name = "bakToolStripMenuItem";
			this.bakToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
			this.bakToolStripMenuItem.Text = "Bak";
			this.bakToolStripMenuItem.Click += new System.EventHandler(this.bakToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.shields1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(541, 380);
			this.panel1.TabIndex = 2;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "Srcs";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// shieldsNotBakedToolStripMenuItem
			// 
			this.shieldsNotBakedToolStripMenuItem.Name = "shieldsNotBakedToolStripMenuItem";
			this.shieldsNotBakedToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.shieldsNotBakedToolStripMenuItem.Text = "ShieldsNotBaked";
			this.shieldsNotBakedToolStripMenuItem.Click += new System.EventHandler(this.shieldsNotBakedToolStripMenuItem_Click);
			// 
			// modulesNotBakedToolStripMenuItem
			// 
			this.modulesNotBakedToolStripMenuItem.Name = "modulesNotBakedToolStripMenuItem";
			this.modulesNotBakedToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.modulesNotBakedToolStripMenuItem.Text = "ModulesNotBaked";
			this.modulesNotBakedToolStripMenuItem.Click += new System.EventHandler(this.modulesNotBakedToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 405);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "bak_.Shields";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar.retVoid__startOfPar_ShieldsSel1 shields1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cfgToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shieldsBakedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bakToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem modulesBakedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem shieldsNotBakedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modulesNotBakedToolStripMenuItem;
	}
}