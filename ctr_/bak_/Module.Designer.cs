using nilnul._dev_._bak_._WIN_.ctr_.retVoid_;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_
{
	partial class bak__Module
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
			this.module1 = new nilnul.fs._git_._WIN_CTR_.Module();
			this.bak___module__start_Cancel1 = new nilnul._dev_._bak_._WIN_.ctr_.bak_._module_.start.bak___module__start_Cancel();
			this.SuspendLayout();
			// 
			// module1
			// 
			this.module1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.module1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.module1.Location = new System.Drawing.Point(0, 3);
			this.module1.Name = "module1";
			this.module1.Size = new System.Drawing.Size(654, 122);
			this.module1.TabIndex = 1;
			this.module1.txt = "";
			this.module1.txtChanged += new System.EventHandler(this.module1_txtChanged);
			this.module1.Load += new System.EventHandler(this.module1_Load);
			// 
			// bak___module__Start1
			// 
			this.bak___module__start_Cancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bak___module__start_Cancel1.Location = new System.Drawing.Point(0, 131);
			this.bak___module__start_Cancel1.Name = "bak___module__Start1";
			this.bak___module__start_Cancel1.Size = new System.Drawing.Size(654, 38);
			this.bak___module__start_Cancel1.TabIndex = 2;
			this.bak___module__start_Cancel1.started += new System.Action(this.bak___module__Start1_started);
			this.bak___module__start_Cancel1.finished += new System.Action(this.bak___module__Start1_finished);
			this.bak___module__start_Cancel1.start += new System.Action(this.bak___module__start_Cancel1_start);
			this.bak___module__start_Cancel1.Load += new System.EventHandler(this.bak___module__Start1_Load);
			// 
			// bak__Module
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bak___module__start_Cancel1);
			this.Controls.Add(this.module1);
			this.Name = "bak__Module";
			this.Size = new System.Drawing.Size(654, 169);
			this.Load += new System.EventHandler(this.ctr_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private nilnul.fs._git_._WIN_CTR_.Module module1;
		private _module_.start.bak___module__start_Cancel bak___module__start_Cancel1;
	}
}
