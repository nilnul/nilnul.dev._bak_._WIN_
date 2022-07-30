using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.retVoid_.startOfPar
{
	public partial class retVoid__startOfPar_ShieldSel : UserControl
	{

		public event Action started;
		public event Action finished;

		public retVoid__startOfPar_ShieldSel()
		{
			InitializeComponent();
			//this.startCtr.started += startCtr_started;
			//this.startCtr.finished += startCtr_finished;
			
		}

		private void startCtr_finished()
		{
			this.finished?.Invoke();
			//throw new NotImplementedException();
		}

		private void startCtr_started()
		{
			started?.Invoke();
			//throw new NotImplementedException();
		}


		private void startCtr_start()
		{
			startCtr.bak(new[] { this.shieldSel1.shieldNulable });

			//throw new NotImplementedException();
		}

		public string txt {
			get {
				return this.shieldSel1.txt;
			}
			set {
				this.shieldSel1.txt = value;
			}
		}

		

		private void validate() {
			if (this.shieldSel1.isNotValid())
			{
				this.startCtr.disable();
			}
			else
			{
				this.startCtr.enable();
			}
		}

		private void ctr_Load(object sender, EventArgs e)
		{
			validate();
		}

		private void shieldSel1_Load(object sender, EventArgs e)
		{
			//this.shieldSel1.changed += shieldSel1_changed;
		}

		private void shieldSel1_changed()
		{
			validate();
			//throw new NotImplementedException();
		}

		
	}
}