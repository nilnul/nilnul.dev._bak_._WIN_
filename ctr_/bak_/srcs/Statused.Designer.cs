
namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.srcs
{
	partial class bak__srcs_Statused
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.ctr__bak__Srcs1 = new nilnul._dev_._bak_._WIN_.ctr_.bak_.ctr__bak__Srcs();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.ctr__bak__Srcs1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
			this.splitContainer1.Size = new System.Drawing.Size(406, 328);
			this.splitContainer1.SplitterDistance = 212;
			this.splitContainer1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(406, 112);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// ctr__bak__Srcs1
			// 
			this.ctr__bak__Srcs1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ctr__bak__Srcs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctr__bak__Srcs1.Location = new System.Drawing.Point(0, 0);
			this.ctr__bak__Srcs1.Name = "ctr__bak__Srcs1";
			this.ctr__bak__Srcs1.Size = new System.Drawing.Size(406, 212);
			this.ctr__bak__Srcs1.TabIndex = 0;
			this.ctr__bak__Srcs1.txt = "";
			this.ctr__bak__Srcs1.started += new System.Action(this.retVoid__startOfPar_ShieldsSel11_started);
			this.ctr__bak__Srcs1.finished += new System.Action(this.retVoid__startOfPar_ShieldsSel11_finished);
			this.ctr__bak__Srcs1.notify += new System.Action<string>(this.ctr__bak__Srcs1_notify);
			// 
			// Statused
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "Statused";
			this.Size = new System.Drawing.Size(406, 328);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private ctr__bak__Srcs ctr__bak__Srcs1;
	}
}
