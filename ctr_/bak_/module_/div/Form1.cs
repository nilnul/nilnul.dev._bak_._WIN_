using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.module_.div
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		

		

		public void disableCtr()
		{
			this.ControlBox = false;

		}
		public void enableCtr()
		{
			this.ControlBox = true;

		}

		private void bak__Module1_finished()
		{
			enableCtr();
			_this._BlinkFormX.FlashWindow(this.Handle, false);

		}

		private void bak__Module1_started()
		{
			disableCtr();

		}
	}
}
