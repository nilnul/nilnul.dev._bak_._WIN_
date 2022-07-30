using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_
{
	[Obsolete(nameof(nilnul._dev_._CTR4WIN_.Srcs_disjoint))]
	public partial class _cfg__Srcs : UserControl
	{
		public _cfg__Srcs()
		{
			InitializeComponent();
		}

		private void address_shields__NonblankLines1_Load(object sender, EventArgs e)
		{
			this.address_shields__NonblankLines1.txt = nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(
				nilnul.dev.Srcs3.CfgedAsTxts.OrderBy(
					x => x, nilnul.fs.address.nulable.comp_.Cn.Singleton
				)
			);
		}

		private void address_shields__NonblankLines1_txtChanged(object sender, EventArgs e)
		{
			if (this.address_shields__NonblankLines1.hasErr)
			{
				this.button1.Enabled = false;
			}
			else
			{
				this.button1.Enabled = true;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			nilnul.dev.Properties.Settings.Default.srcs = nilnul.txts_.StrCollectionX.FroEnumable(
				this.address_shields__NonblankLines1.parsed.Values.Select(
					x =>
					nilnul.fs.address_.shield_._AddressX1.Txt(
						x.ToString()
					)
				)
			);


			nilnul.dev.Properties.Settings.Default.Save();

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.srcs = nilnul.dev.Properties.Settings.Default.srcs;

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

			this.button1.Text = "Saved";

		}
	}
}
