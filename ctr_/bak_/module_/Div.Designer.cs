using nilnul._dev_._bak_._WIN_.ctr_.retVoid_;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.module_
{
	partial class bak__module_Div
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
			this.moduleInSlnBySub1 = new nilnul._dev_._CTR4WIN_.sln.div_.module_.sln_div__module__OvSub();
			this.bak___module__start_Cancel1 = new nilnul._dev_._bak_._WIN_.ctr_.bak_._module_.start.bak___module__start_Cancel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// moduleInSlnBySub1
			// 
			this.moduleInSlnBySub1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.moduleInSlnBySub1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.moduleInSlnBySub1.Location = new System.Drawing.Point(3, 3);
			this.moduleInSlnBySub1.Name = "moduleInSlnBySub1";
			this.moduleInSlnBySub1.Size = new System.Drawing.Size(648, 119);
			this.moduleInSlnBySub1.TabIndex = 1;
			this.moduleInSlnBySub1.txt = "";
			this.moduleInSlnBySub1.Load += new System.EventHandler(this.module1_Load);
			this.moduleInSlnBySub1.changedReportable+= (this.module1_changedReportable);
			// 
			// bak___module__start_Cancel1
			// 
			this.bak___module__start_Cancel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bak___module__start_Cancel1.Location = new System.Drawing.Point(3, 128);
			this.bak___module__start_Cancel1.Name = "bak___module__start_Cancel1";
			this.bak___module__start_Cancel1.Size = new System.Drawing.Size(648, 38);
			this.bak___module__start_Cancel1.TabIndex = 2;
			this.bak___module__start_Cancel1.started += new System.Action(this.bak___module__Start1_started);
			this.bak___module__start_Cancel1.finished += new System.Action(this.bak___module__Start1_finished);
			this.bak___module__start_Cancel1.start += new System.Action(this.bak___module__start_Cancel1_start);
			this.bak___module__start_Cancel1.Load += new System.EventHandler(this.bak___module__Start1_Load);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.bak___module__start_Cancel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.moduleInSlnBySub1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 169);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// bak__module_Div
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "bak__module_Div";
			this.Size = new System.Drawing.Size(654, 169);
			this.Load += new System.EventHandler(this.ctr_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private nilnul._dev_._CTR4WIN_.sln.div_.module_.sln_div__module__OvSub moduleInSlnBySub1;
		private _module_.start.bak___module__start_Cancel bak___module__start_Cancel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
