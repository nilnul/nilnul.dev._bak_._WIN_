using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._cfg_
{
	public partial class ModulesNotBaked : UserControl
	{
		public ModulesNotBaked()
		{
			InitializeComponent();
		}

		private void address_shields__NonblankLines1_Load(object sender, EventArgs e)
		{
			this.address_shields__NonblankLines1.txt = nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(
				nilnul.dev.srcs.bak_._retVoid.SettingX.ModulesNotBakedInside.OrderBy(
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
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesNotBakedInside= nilnul.txts_.StrCollectionX.FroEnumable(
				this.address_shields__NonblankLines1.parsed.Values.Select(
					x =>
					nilnul.fs.address_.shield_._AddressX1.Txt(
						x.ToString()
					)
				)
			);
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();
			this.button1.Text = "Saved";

		}
	}
}
