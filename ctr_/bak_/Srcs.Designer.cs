namespace nilnul._dev_._bak_._WIN_.ctr_.bak_
{
	partial class ctr__bak__Srcs
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
			this.startOfPar1 = new nilnul._dev_._bak_._WIN_.ctr_.retVoid_.StartOfPar();
			this.address_shields__NonblankLines1 = new nilnul._fs_._WIN_CTR_.addresses_.addresses_Disjoint();
			this.SuspendLayout();
			// 
			// startOfPar1
			// 
			this.startOfPar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.startOfPar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.startOfPar1.Location = new System.Drawing.Point(0, 439);
			this.startOfPar1.Name = "startOfPar1";
			this.startOfPar1.Size = new System.Drawing.Size(685, 94);
			this.startOfPar1.TabIndex = 0;
			this.startOfPar1.started += new System.Action(this.startCtr_started);
			this.startOfPar1.finished += new System.Action(this.startCtr_finished);
			this.startOfPar1.start += new System.Action(this.startCtr_start);
			this.startOfPar1.notify += new System.Action<string>(this.StartOfPar1_notify);
			this.startOfPar1.Load += new System.EventHandler(this.startOfPar1_Load);
			// 
			// address_shields__NonblankLines1
			// 
			this.address_shields__NonblankLines1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.address_shields__NonblankLines1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.address_shields__NonblankLines1.Location = new System.Drawing.Point(3, 2);
			this.address_shields__NonblankLines1.Name = "address_shields__NonblankLines1";
			this.address_shields__NonblankLines1.Size = new System.Drawing.Size(679, 431);
			this.address_shields__NonblankLines1.TabIndex = 1;
			this.address_shields__NonblankLines1.val = "";
			this.address_shields__NonblankLines1.report += new System.Action(this.shieldSel1_changed);
			this.address_shields__NonblankLines1.Load += new System.EventHandler(this.address_shields__NonblankLines1_Load);
			// 
			// ctr__bak__Srcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.address_shields__NonblankLines1);
			this.Controls.Add(this.startOfPar1);
			this.Name = "ctr__bak__Srcs";
			this.Size = new System.Drawing.Size(685, 536);
			this.Load += new System.EventHandler(this.ctr_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private retVoid_.StartOfPar startOfPar1;
		private _fs_._WIN_CTR_.addresses_.addresses_Disjoint address_shields__NonblankLines1;
	}
}
