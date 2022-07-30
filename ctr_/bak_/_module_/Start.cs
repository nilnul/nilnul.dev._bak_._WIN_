using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_._module_
{
	public partial class bak___module__Start : UserControl
	{
		public event Action click;
		public event Action finished;

		public bak___module__Start()
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

		public async void begin(string _moduleInsideSln, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			this.button1.Text = "Suspend";
			this.button1.Enabled = false;

			Trace.TraceInformation($"begin baking :{_moduleInsideSln}...");

			nilnul.dev.srcs.bak_._retVoid._CfgX.ParentForm = this.ParentForm.Handle;
			try
			{
				await Task.Factory.StartNew(
						() => new nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone.Bak_srcsInAddresses(
								fs.addresses_.disjoint.deV_._bak.io_._CfgX.Create_bakedNone(cancel, git)
						)._exe(
								_moduleInsideSln
								,
								new System.Collections.Concurrent.ConcurrentBag<fs._address.DivI>()
								,
								new System.Collections.Concurrent.ConcurrentBag<fs._address.DivI>()
						)
				//,
				//cancel


				);

			}
			catch (AggregateException ex)
			{
				Trace.TraceError($" when tasks are complete: { ex.Flatten().InnerExceptions}");

			}
			catch (OperationCanceledException ex) {
				Trace.TraceError($" task cancelled { ex}");

			}
			catch (Exception e)
			{
				Trace.TraceError($" when tasks are complete, the exception : { e}");
				//throw;
			}
			finally
			{
				this.button1.Enabled = true;

				this.button1.Text = "Renew";
				finished?.Invoke();

			}

			//t.ContinueWith((x)=> {
			//});
		}

		internal void reset()
		{
				this.button1.Enabled = true;

				this.button1.Text = "Start";

		}
	}
}
