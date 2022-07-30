using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Specialized;

namespace nilnul._dev_._bak_._WIN_.ctr_.retVoid_
{
	public partial class StartOfPar : UserControl
	{
		public event Action started;
		public event Action finished;

		public event Action start;

		public StartOfPar()
		{
			InitializeComponent();
		}

		private void showCancel()
		{
			this.start1.Hide();
			this.cancel1.Show();
			this.cancel1.Dock = DockStyle.Fill;
		}

		/// <summary>
		/// 
		/// </summary>
		/// shall be disposed. or it will be disposed with this control.
		public CancellationTokenSource source = new CancellationTokenSource();


		//private void Form1_Load(object sender, EventArgs e)
		//{

		//}

		private void start1_Load(object sender, EventArgs e)
		{
			//this.start1.click += start1_click;
			
		}



		//public string shield { get; set; }

		public void bak(IEnumerable<string> shieldAddresses)
		{
			var shields2bak = shieldAddresses?? nilnul.dev.Properties.Settings.Default.srcs.Cast<string>()??new string[0];


			started?.Invoke();

			showCancel();
			source = new CancellationTokenSource();// if we reuse the old cancel src, when we renew after pausing, a task canncled exception will be thrown

			//start1.notify += Start1_notify;
			start1.begin(
				(shields2bak)
				,
				source.Token
			);

			//var task=Task.Run(()=>start1.begin(folders2bak, source.Token  ));

			//task.ContinueWith((t) => {
			//	cancel1.btnCancelled();
			//});


			//throw new NotImplementedException();

			//start1.finished += start1_finished;

		}
		public event Action<string> notify;
		private void Start1_notify(string obj)
		{
			notify?.Invoke(obj);
			//throw new NotImplementedException();
		}

		//public void bak() {
		//	var shields2bak = nilnul.dev.srcs.bak_._retVoid.SettingX.shields2bak;
		//	bak(shields2bak.Cast<string>());
		//}

		private void start1_click()
		{
			//bak();
			start?.Invoke();

			//var shields2bak = nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Properties[nameof(nilnul.dev.srcs.bak_._retVoid.Settings1.shields2bak)].DefaultValue as StringCollection;


		}

		public void reshowStart()
		{
			this.cancel1.Hide();
			//this.start1.enable();
			this.start1.Show();
			this.start1.Dock = DockStyle.Fill;

		}

		private void start1_finished()
		{
			this.Text = "Finished!";
			this.BackColor = Color.Beige;
			reshowStart();
			this.cancel1.reset();
			finished?.Invoke();


		}

		public void disable() {
			this.start1.disable();
		}
		public void enable() {
			this.start1.enable();
		}
		private void cancel1_Load(object sender, EventArgs e)
		{
			//cancel1.click += cancel1_click;
		}

		private void cancel1_click()
		{
			cancel1.cancel(source);
			//throw new NotImplementedException();
		}

		
	}
}
