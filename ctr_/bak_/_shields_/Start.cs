using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_._retVoid_
{
	public partial class bak___shields__Start : UserControl
	{
		public event Action click;
		public event Action finished;

		public bak___shields__Start()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			click?.Invoke();

			//var folders = new nilnul.fs.folders_.Disjoint(

			//);


		}

		public void disable()
		{
			this.button1.Enabled = false;
		}
		public void enable()
		{
			this.button1.Enabled = true;
		}

		public async void begin(
			IEnumerable<string> shieldsInAddresses
			,
			CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null
		)
		{
			this.button1.Text = "Suspend";
			this.button1.Enabled = false;

			Trace.TraceInformation($"begin baking srcs:{nilnul.fs.address.str._PhraseX.Phrase(shieldsInAddresses)}...");

			//nilnul.dev.srcs.bak_._retVoid._CfgX.ParentForm = this.ParentForm.Handle;
			var save = new nilnul.fs.addresses_.disjoint.deV_.bak.Save(

						cancel
						//,this.ParentForm.Handle		// for the parent window of credUI
						,
						git
			);
			try
			{
				save.cfg.notify += Cfg_notify;

				await Task.Factory.StartNew(
						() =>
						save.exe(shieldsInAddresses
							)
				//,
				//cancel

				//	,
				//TaskCreationOptions.AttachedToParent
				//,
				//TaskScheduler.Current
				); /*Parent propagates exceptions thrown by child tasks.	No*/

			}
			catch (AggregateException ex)
			{
				Trace.TraceError($" when tasks are complete: { ex.Flatten().InnerExceptions}");

			}
			catch (Exception e)
			{
				Trace.TraceError($" when tasks are complete, the exception : { e}");
				throw;
			}
			finally
			{
				this.button1.Enabled = true;

				this.button1.Text = "Renew";
				save.cfg.notify -= Cfg_notify;

				finished?.Invoke();

			}

			//t.ContinueWith((x)=> {
			//});
		}

		public event Action<string> notify;
		private void Cfg_notify(string obj)
		{
			notify?.Invoke(obj);
		}
	}
}
