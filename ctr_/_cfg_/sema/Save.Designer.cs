namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_.sema
{
	partial class _cfg__sema_Save
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
			this._cfg__Semaphore1 = new nilnul._dev_._bak_._WIN_.ctr_._cfg_._cfg__Semaphore();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.Save = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _cfg__Semaphore1
			// 
			this._cfg__Semaphore1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._cfg__Semaphore1.Location = new System.Drawing.Point(3, 3);
			this._cfg__Semaphore1.Name = "_cfg__Semaphore1";
			this._cfg__Semaphore1.Size = new System.Drawing.Size(147, 24);
			this._cfg__Semaphore1.TabIndex = 0;
			//this._cfg__Semaphore1.val = new decimal(new int[] {
   //         4,
   //         0,
   //         0,
   //         0});
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this._cfg__Semaphore1);
			this.flowLayoutPanel1.Controls.Add(this.Save);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(148, 56);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(3, 33);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(142, 23);
			this.Save.TabIndex = 1;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// _cfg__sema_Save
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "_cfg__sema_Save";
			this.Size = new System.Drawing.Size(148, 56);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private _cfg__Semaphore _cfg__Semaphore1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button Save;
	}
}
