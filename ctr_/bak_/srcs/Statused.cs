using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.srcs
{
	public partial class bak__srcs_Statused : UserControl
	{

		public event Action started;
		public event Action finished;

		public bak__srcs_Statused()
		{
			InitializeComponent();
		}





		private void retVoid__startOfPar_ShieldsSel11_finished()
		{
			finished?.Invoke();
			//_this._BlinkFormX.FlashWindow(this.Handle, false);

		}

		private void retVoid__startOfPar_ShieldsSel11_started()
		{
			started?.Invoke();
			this.richTextBox1.Clear();
		}
		private void __ctr__bak__Srcs1_notify___assumeSameThread(string obj)
		{
			this.richTextBox1.SuspendLayout();
			this.richTextBox1.AppendText(obj);
			this.richTextBox1.AppendText(Environment.NewLine);

			//richTextBox1.Select(richTextBox1.Text.Length, 0);
			//richTextBox1.ScrollToCaret();
			this.richTextBox1.ResumeLayout();
		}

		private void ctr__bak__Srcs1_notify(string obj)
		{
			///RichTextBox is designed for large amounts of text, TextBox is not.
			///

			if (richTextBox1.InvokeRequired)
			{

				this.richTextBox1.Invoke(
					new Action
					(
						() => __ctr__bak__Srcs1_notify___assumeSameThread(obj)
					)
				);
			}
			else
			{
				__ctr__bak__Srcs1_notify___assumeSameThread(obj);
			}
		}
	}

}
