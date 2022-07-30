using System;
using System.Threading;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_
{
	public partial class bak__Shield : UserControl
	{
		public event Action started;
		public event Action finished;


		public bak__Shield()
		{
			InitializeComponent();
			validate();
		}

		public string txt
		{
			//get => this.module1.txt;//return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate( this.address_shields__NonblankLines1.parsed.Values.Select(x=>x.ToString())//);
			set => this.shield1.txt = value;
		}
		private void validate()
		{
			if (
				this.shield1.isNotValid()
			)
			{
				this.bak___shield__start_Cancel1.disable("invalid format");//.Enabled = false;
			}
			else if (
				!nilnul.fs.address_.shield.be_.dev_._InSrcX.Be(this.shield1.shieldNulable)
			)
			{
				this.bak___shield__start_Cancel1.disable("not in src");//.Enabled = false;
			}
			else
			{
				this.bak___shield__start_Cancel1.enable();//.Enabled = true;//.enable();
			}
		}

		private void ctr_Load(object sender, EventArgs e)
		{
			validate();
		}

		private void shield1_txtChanged()
		{
			validate();

		}

		private void shield1_Load(object sender, EventArgs e)
		{
			this.shield1.txt = nilnul.dev._bak_._WIN_.Properties.Settings.Default.lastAddress;//.dev.srcs.bak_._retVoid.SettingX.module2bak;

		}



		private void bak___shield__start_Cancel1_start()
		{
			nilnul.dev._bak_._WIN_.Properties.Settings.Default.lastAddress = this.shield1.txt;
			nilnul.dev._bak_._WIN_.Properties.Settings.Default.Save();
			this.bak___shield__start_Cancel1.bak(
				this.shield1.shieldNulable


			);


		}

		private void bak___shield__Start1_Load(object sender, EventArgs e)
		{

		}

		private void bak___shield__Start1_finished()
		{
			this.finished?.Invoke();

		}

		private void bak___shield__Start1_started()
		{
			started?.Invoke();

		}
	}
}