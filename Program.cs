using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._WIN_
{
	static public class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Trace.AutoFlush = true;
			Trace.TraceInformation("begin program...");

            //_settings.nilnul_dev.srcs.bak_._retVoid.settings._OverrideX.Exe();
            //Properties.Settings.Default.Reload();
            //nilnul.dev.Properties.Settings.Default.Reload();

			Application.EnableVisualStyles(); //required for shortcut keys
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run(new ctr_.retVoid_.startOfPar.shieldsSel.Form1());
			Application.Run(new form_.MDIParent1());

			Trace.TraceInformation("end program...");
		}
	}
}
