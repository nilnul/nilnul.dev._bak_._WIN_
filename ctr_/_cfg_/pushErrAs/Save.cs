using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_.pushErrAs
{
	public partial class _cfg__pushErrAs_Save : UserControl
	{
		public _cfg__pushErrAs_Save()
		{
			InitializeComponent();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				nilnul.dev.bak.Properties.Settings.Default.pushErrsAsWarningIfSuccessesGe = (uint)(_cfg__PushErrAsWarnIfSuccessesGe1.val);
				nilnul.dev.bak.Properties.Settings.Default.Save();

			}
			catch (Exception ex)
			{

				throw;
			}
		}
	}
}
