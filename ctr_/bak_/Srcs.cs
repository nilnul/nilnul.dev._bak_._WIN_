using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul._dev_._bak_._WIN_.ctr_.bak_
{
	public partial class ctr__bak__Srcs : UserControl
	{

		public event Action started;
		public event Action finished;

		public ctr__bak__Srcs()
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
			string[] txts;
			//if (checkBoxShieldsNotBaked.Checked)
			//{
			//	if (
			//				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsNotBaked==null

			//		)
			//	{
			//		nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsNotBaked = new System.Collections.Specialized.StringCollection();


			//	}

			//	nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsNotBaked.AddRange(
			//		this.address_shields__NonblankLines1.parsed.Values.Select(x=>x.ToString()).ToArray()
			//	);

			//}

			//if (checkBoxModulesNotBaked.Checked)
			//{
			//	if (
			//				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesNotBakedInside==null

			//		)
			//	{
			//		nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesNotBakedInside= new System.Collections.Specialized.StringCollection();

			//	}

			//	nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesNotBakedInside.AddRange(
			//		this.address_shields__NonblankLines1.parsed.Values.Select(x=>x.ToString()).ToArray()
			//	);

			//}

			//startOfPar1.notify += StartOfPar1_notify;

			startOfPar1.bak(
				this.address_shields__NonblankLines1.valAsDisjointAddresses.toOriginal().Select(x => x.ToString())
			//nilnul.txts_.StrCollectionX.ToEnumable( nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak)
			//
			);

			//startCtr.bak(nilnul.txts_.StrCollectionX.ToEnumable( nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak));

			//throw new NotImplementedException();
		}
		public event Action<string> notify;
		private void StartOfPar1_notify(string obj)
		{
			notify?.Invoke(obj);
			//throw new NotImplementedException();
		}

		public string txt
		{
			get
			{
				return this.address_shields__NonblankLines1.val;
				//return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate( this.address_shields__NonblankLines1.parsed.Values.Select(x=>x.ToString())
				//);
			}
			set
			{
				this.address_shields__NonblankLines1.val = value;
			}
		}



		private void validate()
		{
			if (this.address_shields__NonblankLines1.beErr)
			{
				this.startOfPar1.disable();
			}
			else
			{
				this.startOfPar1.enable();
			}
		}

		private void ctr_Load(object sender, EventArgs e)
		{
			validate();
		}



		private void shieldSel1_changed()
		{
			validate();
			//throw new NotImplementedException();
		}

		private void address_shields__NonblankLines1_Load(object sender, EventArgs e)
		{
			this.address_shields__NonblankLines1.val = nilnul.txt.accumulate_._LineSeparatedX.ToWinLines(
				nilnul.obj.str.op_.unary_._ShuffleX.Op(

					 nilnul.dev.Properties.Settings.Default.srcs ?? new System.Collections.Specialized.StringCollection()
				).Cast<string>().ToArray()

			);

		}

		private void address_shields__NonblankLines1_txtChanged()
		{
			if (this.address_shields__NonblankLines1.beErr)
			{
				this.startOfPar1.disable();
			}
			else
			{
				this.startOfPar1.enable();

			}
		}

		private void startOfPar1_Load(object sender, EventArgs e)
		{

		}
	}
}