using nilnul._dev_._bak_._WIN_.ctr_.retVoid_;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_
{
	partial class bak__Shield
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
			this.shield1 = new nilnul._fs_._WIN_CTR_.address_.Shield();
			this.bak___shield__start_Cancel1 = new nilnul._dev_._bak_._WIN_.ctr_.bak_._shield_.start.bak___shield__start_Cancel();
			this.SuspendLayout();
			// 
			// shield1
			// 
			this.shield1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.shield1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.shield1.Location = new System.Drawing.Point(0, 3);
			this.shield1.Name = "shield1";
			this.shield1.Size = new System.Drawing.Size(654, 122);
			this.shield1.TabIndex = 1;
			this.shield1.txt = "C:\\WINDOWS\\system32";
			this.shield1.Load += new System.EventHandler(this.shield1_Load);
			this.shield1.changed += Shield1_changed;
			// 
			// bak___module__start_Cancel1
			// 
			this.bak___shield__start_Cancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bak___shield__start_Cancel1.Location = new System.Drawing.Point(0, 131);
			this.bak___shield__start_Cancel1.Name = "bak___module__start_Cancel1";
			this.bak___shield__start_Cancel1.Size = new System.Drawing.Size(654, 38);
			this.bak___shield__start_Cancel1.TabIndex = 2;
			this.bak___shield__start_Cancel1.started += new System.Action(this.bak___shield__Start1_started);
			this.bak___shield__start_Cancel1.finished += new System.Action(this.bak___shield__Start1_finished);
			this.bak___shield__start_Cancel1.start += new System.Action(this.bak___shield__start_Cancel1_start);
			this.bak___shield__start_Cancel1.Load += new System.EventHandler(this.bak___shield__Start1_Load);
			// 
			// bak__Shield
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bak___shield__start_Cancel1);
			this.Controls.Add(this.shield1);
			this.Name = "bak__Shield";
			this.Size = new System.Drawing.Size(654, 169);
			this.Load += new System.EventHandler(this.ctr_Load);
			this.ResumeLayout(false);

		}

		private void Shield1_changed()
		{
			validate();
		}

		#endregion
		private _fs_._WIN_CTR_.address_.Shield shield1;

		private _shield_.start.bak___shield__start_Cancel bak___shield__start_Cancel1;
	}
}
