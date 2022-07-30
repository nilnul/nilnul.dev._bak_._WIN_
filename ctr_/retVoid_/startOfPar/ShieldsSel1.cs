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
	public partial class retVoid__startOfPar_ShieldsSel1 : UserControl
	{

		public event Action started;
		public event Action finished;

		public retVoid__startOfPar_ShieldsSel1()
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

			startOfPar1.bak(
				this.address_shields__NonblankLines1.parsed.Values.Select(x => x.ToString())
			//nilnul.txts_.StrCollectionX.ToEnumable( nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak)
			//
			);

			//startCtr.bak(nilnul.txts_.StrCollectionX.ToEnumable( nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak));

			//throw new NotImplementedException();
		}

		public string txt
		{
			get
			{
				return this.address_shields__NonblankLines1.txt;
				//return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate( this.address_shields__NonblankLines1.parsed.Values.Select(x=>x.ToString())
				//);
			}
			set
			{
				this.address_shields__NonblankLines1.txt = value;
			}
		}



		private void validate()
		{
			if (this.address_shields__NonblankLines1.hasErr)
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
			this.address_shields__NonblankLines1.txt = nilnul.txt.accumulate_._LineSeparatedX.ToWinLines(
				nilnul.obj.str.op_.unary_._ShuffleX.Op(

					 nilnul.dev.bak.Properties.Settings.Default.shields2Bak ?? new  System.Collections.Specialized.StringCollection()
				).Cast<string>().ToArray()
				
			);

		}

		private void address_shields__NonblankLines1_txtChanged(object sender, EventArgs e)
		{
			if (this.address_shields__NonblankLines1.hasErr)
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