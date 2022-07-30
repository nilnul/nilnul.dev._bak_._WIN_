using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._retVoid_
{
	public partial class _retVoid__ShieldSel : UserControl
	{
		public event Action changed;

		public _retVoid__ShieldSel()
		{
			InitializeComponent();
		}

		private void ShieldSel_Load(object sender, EventArgs e)
		{
			///initialize the text
			///
			this.textBox1.Text = /*null;*/
			(
				nilnul.obj.str._SampleX.Sample(
					nilnul.dev.srcs.bak_._retVoid.SettingX.shields2bak
				) ?? ""
			//??
			//nilnul.dev.srcs.bak_._retVoid.SettingX.srcs1.en.FirstOrDefault()?.ToString()
			);
			validate();



		}
		public bool isValid()
		{
			return nilnul.txt.be_.fs_.Address.Singleton.be_ifArgTrimmed(textBox1.Text ?? "");
		}

		public bool isNotValid()
		{
			return !isValid();
		}
		private void validate()
		{
			//if (DesignMode)
			//{

			//	return;

			//}
			if (isNotValid())
			{
				//return;

				//button1.Enabled = false;
				textBox1.BackColor = Color.Red;
				textBox1.ForeColor = Color.Yellow;

				this.toolTip1.SetToolTip(this.button1, "Address Format incorrect");
			}
			else
			{
				//button1.Enabled = false;
				//button1.UseVisualStyleBackColor = true;//.BackColor = Color..Red;
				textBox1.ForeColor = Color.Empty;
				textBox1.ForeColor = Color.Empty;


				this.toolTip1.SetToolTip(this.button1, "");

			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			validate();
			changed?.Invoke();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var result = folderBrowserDialog1.ShowDialog(this.ParentForm);
			if (result == DialogResult.OK)
			{
				this.textBox1.Text = folderBrowserDialog1.SelectedPath;
			}

		}

		public string txt
		{
			get
			{

				return this.textBox1.Text.Trim();

			}

			set
			{
				this.textBox1.Text = value;
			}

		}

		public string shieldNulable
		{
			get
			{
				if (
					nilnul.txt.be_.fs_.Address.Singleton.be_ifArgTrimmed(textBox1.Text ?? "")
				)
				{
					return this.textBox1.Text.Trim();
				}
				else
				{
					return null;
				}
			}


		}
	}
}
