using System;
using System.Threading;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_
{
	/// <summary>
	///  module in src
	/// </summary>
	public partial class bak__Module : UserControl
	{
		public event Action started;
		public event Action finished;


		public bak__Module()
		{
			InitializeComponent();
		}

		public string txt
		{
			get => this.module1.txt;//return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate( this.address_shields__NonblankLines1.parsed.Values.Select(x=>x.ToString())//);
			set => this.module1.txt = value;
		}



		private void validate()
		{
			if (this.module1.hasErr
			)
			{

				this.bak___module__start_Cancel1.disable();//.Enabled = false;
			}
			else if (
				!nilnul.fs.address_.shield.be_.deV_._SrcDestinationX.Be(this.module1.parsed.top.en.address.en)	 //src cannot be taken as the module here
			)
			{
				this.bak___module__start_Cancel1.disable();//.Enabled = false;

			}
			else
			{
				/// all progenators upto the src is not checked for being unjoint0not; in orther words, we "coerced" this as a legal module.
				/// in fact we didnot check "link0not", or "neglect0not", which is how coersion works.
				/// 
				this.bak___module__start_Cancel1.enable();//.Enabled = true;//.enable();
			}
		}

		private void ctr_Load(object sender, EventArgs e)
		{
			validate();
		}



		private void module1_txtChanged(object sender, EventArgs e)
		{
			validate();

		}

		private void module1_Load(object sender, EventArgs e)
		{
			this.module1.txt = nilnul.dev.srcs.bak_._retVoid.SettingX.module2bak;
		}

		private void bak___module__start_Cancel1_start()
		{
			this.bak___module__start_Cancel1.bak(
				this.module1.parsed.ToString()
			);
		}

		private void bak___module__Start1_Load(object sender, EventArgs e)
		{
		}

		private void bak___module__Start1_finished()
		{
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.module2bak = this.module1.txt;

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();
			this.finished?.Invoke();
		}

		private void bak___module__Start1_started()
		{
			started?.Invoke();
		}
	}
}