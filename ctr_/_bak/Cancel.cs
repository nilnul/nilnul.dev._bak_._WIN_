using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace nilnul._dev_._bak_._WIN_.ctr_._retVoid_
{
	public partial class Cancel : UserControl
	{
		public event Action click;
		public Cancel()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			click?.Invoke();

		}

		public void btnCancelled() {
			button1.Text = "cancelled";
		}


		public void reset() {
			button1.Text = "Cancel";
			button1.Enabled = true;

		}

		public void cancel(CancellationTokenSource cancel) {
			button1.Text = "cancelling...";
			button1.Enabled = false;
			cancel.Cancel();

			//button1.Text = "cancelled";
		}
	}
}
