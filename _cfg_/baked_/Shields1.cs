using System;
using System.Linq;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_._cfg_.baked_
{
	public partial class Shields1 : UserControl
	{
		public Shields1()
		{
			InitializeComponent();
		}

		private void address_shields__NonblankLines1_Load(object sender, EventArgs e)
		{
			this.address_shields__NonblankLines1.txt = nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(

			nilnul.txts_.StrCollectionX.ToEnumable(
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak
			).OrderBy(x=>).ToArray()
		);
		}
	}
}
