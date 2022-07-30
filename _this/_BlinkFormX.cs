using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._bak_._WIN_._this
{
	static public class _BlinkFormX
	{
		[DllImport("user32.dll")]
        public static extern int FlashWindow(IntPtr Hwnd, bool Revert);

		// Add form's resize event to judge whether a form has been minimized or not.


		//private void Form4_Resize(object sender, EventArgs e)

		//{

		//	if (this.WindowState == FormWindowState.Minimized)

		//		FlashWindow(this.Handle, false);

		//}
	}
}
