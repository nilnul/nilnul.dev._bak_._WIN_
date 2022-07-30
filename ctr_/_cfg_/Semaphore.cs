using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_
{
	public partial class _cfg__Semaphore : UserControl
	{
		public _cfg__Semaphore()
		{

			InitializeComponent();
			//load the settings
			this.numericUpDown1.Value = nilnul.dev.bak.Properties.SettingsX.Semaphore;

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			 nilnul.dev.bak.Properties.Settings.Default.semaphore= (int)this.numericUpDown1.Value ;


		}
		public decimal val {
			get {
				return this.numericUpDown1.Value;
			}
			set {
				this.numericUpDown1.Value = value;
			}
		}
	}
}
