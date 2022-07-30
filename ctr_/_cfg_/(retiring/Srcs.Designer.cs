namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_
{
	partial class _cfg__Srcs
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
			this.address_shields__NonblankLines1 = new nilnul._fs_._WIN_CTR_.address_.shields_.address_shields__NonblankLines();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// address_shields__NonblankLines1
			// 
			this.address_shields__NonblankLines1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.address_shields__NonblankLines1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.address_shields__NonblankLines1.Location = new System.Drawing.Point(0, 0);
			this.address_shields__NonblankLines1.Name = "address_shields__NonblankLines1";
			this.address_shields__NonblankLines1.Size = new System.Drawing.Size(601, 428);
			this.address_shields__NonblankLines1.TabIndex = 0;
			this.address_shields__NonblankLines1.txt = "";
			this.address_shields__NonblankLines1.txtChanged += new System.EventHandler(this.address_shields__NonblankLines1_txtChanged);
			this.address_shields__NonblankLines1.Load += new System.EventHandler(this.address_shields__NonblankLines1_Load);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(0, 434);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(604, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ModulesBaked
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.address_shields__NonblankLines1);
			this.Name = "ModulesBaked";
			this.Size = new System.Drawing.Size(604, 471);
			this.ResumeLayout(false);

		}

		#endregion

		private _fs_._WIN_CTR_.address_.shields_.address_shields__NonblankLines address_shields__NonblankLines1;
		private System.Windows.Forms.Button button1;
	}
}
