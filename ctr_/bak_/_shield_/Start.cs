using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_._shield_
{
	public partial class bak___shield__Start : UserControl
	{
		public event Action click;
		public event Action finished;

		public bak___shield__Start()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			click?.Invoke();

			//var folders = new nilnul.fs.folders_.Disjoint(

			//);


		}

		public void disable(string button = null)
		{
			this.button1.Enabled = false;
			if (button!=null)
			{
				this.button1.Text = button;
			}
		}
		public void enable()
		{
			this.button1.Enabled = true;
			this.button1.Text = "Ok";
		}

		public async void begin(string shieldInSrc, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			this.button1.Text = "Suspend";
			this.button1.Enabled = false;

			Trace.TraceInformation($"begin baking :{shieldInSrc}...");

			//nilnul.dev.srcs.bak_._retVoid._CfgX.ParentForm = this.ParentForm.Handle;
			try
			{
				await Task.Factory.StartNew(
						() =>
						{
							//new nilnul.fs.address_.shield_.dev_.insideSrc.Bak(
							//	fs.address_.shields.dev_._bak.io_._CfgX.Create_bakedNone(cancel, git)
							//).exe(
							//	shieldInSrc

							//);
							new nilnul.fs.addresses_._disjoint.item.deV_.Bak(
								 fs.addresses_.disjoint.deV_._bak.io_._CfgX.Create_bakedNone(cancel, git)
							).vod_ofAddress(
								shieldInSrc

							);
						}
						,
						cancel


				); 

			}
			catch (AggregateException ex)
			{
				Trace.TraceError($" when tasks are complete: { ex.Flatten().InnerExceptions}");

			}
			catch (Exception e) //operation cancelled
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
	}
}
