namespace nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar
{
	partial class retVoid__startOfPar_ShieldSel
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
			this.startCtr = new nilnul._dev_._bak_._WIN_.ctr_.retVoid_.StartOfPar();
			this.shieldSel1 = new nilnul._dev_._bak_._WIN_.ctr_._retVoid_._retVoid__ShieldSel();
			this.SuspendLayout();
			// 
			// startCtr
			// 
			this.startCtr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.startCtr.Location = new System.Drawing.Point(3, 39);
			this.startCtr.Name = "startCtr";
			this.startCtr.Size = new System.Drawing.Size(436, 288);
			this.startCtr.TabIndex = 0;
			this.startCtr.started += new System.Action(this.startCtr_started);
			this.startCtr.finished += new System.Action(this.startCtr_finished);
			this.startCtr.start += new System.Action(this.startCtr_start);
			// 
			// shieldSel1
			// 
			this.shieldSel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.shieldSel1.Location = new System.Drawing.Point(3, 3);
			this.shieldSel1.Name = "shieldSel1";
			this.shieldSel1.Size = new System.Drawing.Size(436, 33);
			this.shieldSel1.TabIndex = 1;
			this.shieldSel1.txt = "";
			this.shieldSel1.changed += new System.Action(this.shieldSel1_changed);
			this.shieldSel1.Load += new System.EventHandler(this.shieldSel1_Load);
			// 
			// ctr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.shieldSel1);
			this.Controls.Add(this.startCtr);
			this.Name = "ctr";
			this.Size = new System.Drawing.Size(442, 330);
			this.Load += new System.EventHandler(this.ctr_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private StartOfPar startCtr;
		private _retVoid_._retVoid__ShieldSel shieldSel1;
	}
}
