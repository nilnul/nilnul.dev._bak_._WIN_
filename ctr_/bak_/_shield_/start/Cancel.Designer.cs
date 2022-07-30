namespace nilnul._dev_._bak_._WIN_.ctr_.bak_._shield_.start
{
	partial class bak___shield__start_Cancel
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
			this.start1 = new nilnul._dev_._bak_._WIN_.ctr_.bak_._shield_.bak___shield__Start();
			this.cancel1 = new nilnul._dev_._bak_._WIN_.ctr_._retVoid_.Cancel();
			this.SuspendLayout();
			// 
			// start1
			// 
			this.start1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.start1.Location = new System.Drawing.Point(0, 0);
			this.start1.Name = "start1";
			this.start1.Size = new System.Drawing.Size(322, 253);
			this.start1.TabIndex = 1;
			this.start1.click += new System.Action(this.start1_click);
			this.start1.finished += new System.Action(this.start1_finished);
			this.start1.Load += new System.EventHandler(this.start1_Load);
			// 
			// cancel1
			// 
			this.cancel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cancel1.Location = new System.Drawing.Point(0, 0);
			this.cancel1.Name = "cancel1";
			this.cancel1.Size = new System.Drawing.Size(322, 253);
			this.cancel1.TabIndex = 0;
			this.cancel1.Visible = false;
			this.cancel1.click += new System.Action(this.cancel1_click);
			this.cancel1.Load += new System.EventHandler(this.cancel1_Load);
			// 
			// StartOfPar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.start1);
			this.Controls.Add(this.cancel1);
			this.Name = "StartOfPar";
			this.Size = new System.Drawing.Size(322, 253);
			this.ResumeLayout(false);

		}

		#endregion

		private _retVoid_.Cancel cancel1;
		private bak___shield__Start start1;
	}
}
