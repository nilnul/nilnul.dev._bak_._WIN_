using System;
using System.Threading;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_.module_
{
	public partial class bak__module_Div : UserControl
	{
		public event Action started;
		public event Action finished;

		public bak__module_Div()
		{
			InitializeComponent();
			ini();
			validate();
		}

		void ini()
		{
			this.moduleInSlnBySub1.txt = nilnul.dev.srcs.bak_._retVoid.SettingX.module2bak;

		}

		public string txt
		{
			get => this.moduleInSlnBySub1.txt;
			set => this.moduleInSlnBySub1.txt = value;
		}

		private void validate()
		{
			if (
				this.moduleInSlnBySub1.validity
			)
			{
				//this.Enabled = true;
				this.bak___module__start_Cancel1.enable();//.Enabled = false;
			}
			else
			{

				//this.Enabled = false;
				this.bak___module__start_Cancel1.disable();//.Enabled = true;//.enable();
			}
		}

		private void ctr_Load(object sender, EventArgs e)
		{
		}
		void trig()
		{
		}

		void on()
		{
			validate();
			trig();

		}
		private void module1_changedReportable()
		{
			on();
		}

		private void module1_Load(object sender, EventArgs e)
		{
			;
		}

		private void bak___module__start_Cancel1_start()
		{
			this.bak___module__start_Cancel1.bak(
				this.moduleInSlnBySub1.module.ToString()
			);
		}

		private void bak___module__Start1_Load(object sender, EventArgs e)
		{

		}

		private void bak___module__Start1_finished()
		{
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.module2bak = this.moduleInSlnBySub1.txt;

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

			this.moduleInSlnBySub1.Enabled = true;


			this.finished?.Invoke();

		}

		private void bak___module__Start1_started()
		{
			this.moduleInSlnBySub1.disable();
			started?.Invoke();

		}
	}
}