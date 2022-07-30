namespace nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar.shieldSel
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
			this.shields1 = new nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar.retVoid__startOfPar_ShieldSel();
			this.SuspendLayout();
			// 
			// shields1
			// 
			this.shields1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shields1.Location = new System.Drawing.Point(0, 0);
			this.shields1.Name = "shields1";
			this.shields1.Size = new System.Drawing.Size(541, 405);
			this.shields1.TabIndex = 0;
			this.shields1.txt = "";
			this.shields1.started += new System.Action(this.shields1_started);
			this.shields1.finished += new System.Action(this.shields1_finished);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 405);
			this.Controls.Add(this.shields1);
			this.Name = "Form1";
			this.Text = "bak_.Shields";
			this.ResumeLayout(false);

		}

		#endregion

		private nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar.retVoid__startOfPar_ShieldSel shields1;
	}
}