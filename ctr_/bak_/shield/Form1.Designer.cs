namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.shield
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
			this.bak__Shield1 = new nilnul._dev_._bak_._WIN_.ctr_.bak_.bak__Shield();
			this.SuspendLayout();
			// 
			// bak__Module1
			// 
			this.bak__Shield1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bak__Shield1.Location = new System.Drawing.Point(0, 0);
			this.bak__Shield1.Name = "bak__Shield1";
			this.bak__Shield1.Size = new System.Drawing.Size(541, 405);
			this.bak__Shield1.TabIndex = 0;
			this.bak__Shield1.txt = "";
			this.bak__Shield1.started += Bak__Shield1_started;
			this.bak__Shield1.finished += Bak__Shield1_finished;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 405);
			this.Controls.Add(this.bak__Shield1);
			this.Name = "Form1";
			this.Text = "bak_.Shield";
			this.ResumeLayout(false);

		}

		private void Bak__Shield1_started()
		{
			disableCtr();

		}

		private void Bak__Shield1_finished()
		{
			enableCtr();
		}

		#endregion

		private bak__Shield bak__Shield1;
	}
}