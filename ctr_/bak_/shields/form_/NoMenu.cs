using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.shields.form_
{
	public partial class NoMenu : Form
	{
		public event Action started;
		public event Action finished;

		public NoMenu()
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

		private void retVoid__startOfPar_ShieldsSel11_finished()
		{
			enableCtr();
			finished?.Invoke();
			//_this._BlinkFormX.FlashWindow(this.Handle, false);

		}

		private void retVoid__startOfPar_ShieldsSel11_started()
		{
			disableCtr();

		}
	}
}
