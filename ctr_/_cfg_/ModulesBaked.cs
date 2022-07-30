using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_
{
	public partial class ModulesBaked : UserControl
	{
		public ModulesBaked()
		{
			InitializeComponent();
		}

		private void address_shields__NonblankLines1_Load(object sender, EventArgs e)
		{
			this.address_shields__NonblankLines1.txt = nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(
				nilnul.dev.bak.Properties.SettingsX.modulesBaked.OrderBy(
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
			nilnul.dev.bak.Properties.Settings.Default.modulesBaked = nilnul.txts_.StrCollectionX.FroEnumable(
				this.address_shields__NonblankLines1.parsed.Values.Select(
					x =>
					nilnul.fs.address_.shield_._AddressX1.Txt(
						x.ToString()
					)
				)
			);

			nilnul.dev.bak.Properties.Settings.Default.Save();

			this.button1.Text = "Saved";

		}
	}
}
