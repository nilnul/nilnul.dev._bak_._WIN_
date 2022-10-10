using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilnul.dev._bak_._WIN_.form_
{
	public partial class MDIParent1 : Form
	{
		//_bak_._CTR_.ctr_.bak_.module.Form1 moduleBakForm=new ctr_.bak_.module.Form1();


		private int childFormNumber = 0;

		public MDIParent1()
		{
			InitializeComponent();
			procMngers.MdiParent = this;

			//moduleBakForm.FormClosed += ModuleBakForm_FormClosed;
			//moduleBakForm.MdiParent = this;

		}

		private void ShieldsBakForm_finished()
		{
			flash();
		}

		private void ShieldsBakForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			//this.shieldsToolStripMenuItem.Enabled = true;
			//this.moduleToolStripMenuItem.Enabled = true;

		}

		//private void ModuleBakForm_FormClosed(object sender, FormClosedEventArgs e)
		//{
		//	this.shieldsToolStripMenuItem.Enabled = true;
		//	this.moduleToolStripMenuItem.Enabled = true;


		//}



		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Window " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStrip.Visible = toolBarToolStripMenuItem.Checked;
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		//[Obsolete()]
		//private void shieldToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	moduleToolStripMenuItem.Enabled = false;
		//	shieldsToolStripMenuItem.Enabled = false;
		//	shieldToolStripMenuItem.Enabled = false;

		//	var childForm =new ctr_.bak_.shield.Form1();
		//	childForm.FormClosed += ChildForm_FormClosed;	
		//	childForm.MdiParent = this;
		//	childForm.Text = "Shied Bak";// + childFormNumber++;
		//	childForm.Show();

		//}

		//private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
		//{

		//		moduleToolStripMenuItem.Enabled = true;
		//	shieldsToolStripMenuItem.Enabled = true;
		//	shieldToolStripMenuItem.Enabled = true;
		////throw new NotImplementedException();
		//}

		//ctr_.bak_.module_.div.Form1 moduleBySub;

		//private void subToolStripMenuItem_Click(object sender, EventArgs e)
		//{

		//	moduleBySub = moduleBySub ?? new ctr_.bak_.module_.div.Form1();
		//	var childForm = moduleBySub;
		//	childForm.MdiParent = this;
		//	childForm.Text = "ModuleBySub Bak";// + childFormNumber++;
		//	childForm.Show();

		//}

		//private void topToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	shieldsToolStripMenuItem.Enabled = false;
		//	moduleToolStripMenuItem.Enabled = false;

		//	moduleBakForm = moduleBakForm ?? new _bak_._CTR_.ctr_.bak_.module.Form1();
		//	var childForm = moduleBakForm;
		//	childForm.MdiParent = this;
		//	childForm.Text = "Module Bak";// + childFormNumber++;
		//	childForm.Show();

		//}

		public void flash() {
			_this._BlinkFormX.FlashWindow(this.Handle, false);

		}

		private void shieldsToolStripMenuItem1_Click(object sender, EventArgs e)
		{

			_CTR_.ctr_.bak_.shields.form_.NoMenu shieldsBakForm = new _CTR_.ctr_.bak_.shields.form_.NoMenu() { Dock = DockStyle.Fill };

			shieldsBakForm.finished += ShieldsBakForm_finished;
			shieldsBakForm.Text = "Shieds Bak";// + childFormNumber++;
			shieldsBakForm.MdiParent = this;

			shieldsBakForm.FormClosed += ShieldsBakForm_FormClosed;
			shieldsBakForm.WindowState = FormWindowState.Maximized;
			shieldsBakForm.Show();




		}

		private void cfgSrcsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//nilnul.dev._bak_._WIN_.ctr_._cfg_.srcs.Form1 cfg_srcs = new ctr_._cfg_.srcs.Form1();
			var cfg_srcs = new
				nilnul._dev_._CTR4WIN_.srcs.ok.Form_disjoint

				//nilnul._dev_._CTR4WIN_.srcs.ok.Form1
				();


			cfg_srcs.Text = "srcs";

			cfg_srcs.MdiParent = this;

			cfg_srcs.Show();
			cfg_srcs.WindowState = FormWindowState.Maximized;


		}
		private void bakSrcsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var f = new nilnul.dev._bak_._CTR_.ctr_.bak_.srcs.statused.Form1()
			{
				Dock = DockStyle.Fill
			};
			/// as user might change the shields to something other than srcs, hence we don't change the title to "Bakking srcs"


			f.MdiParent = this;

			f.WindowState = FormWindowState.Maximized;


			f.Show();

		}



		private void bakedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.Controls.Add(new _CTR_.ctr_._cfg_.ShieldsBaked() { Dock = DockStyle.Fill });

			f.MdiParent = this;
			f.Show();
		}

		private void modulesBakedToolStripMenuItem_Click(object sender, EventArgs e)
		{

			var f = new Form();
			f.Controls.Add(
				new _CTR_.ctr_._cfg_.ModulesBaked() { Dock = DockStyle.Fill }
				);

			f.MdiParent = this;
			f.Show();



		}

		private void bakToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.Controls.Add(
				new _CTR_.ctr_._cfg_.Shields2Bak() { Dock = DockStyle.Fill }
				);

			f.MdiParent = this;

			f.Show();

		}

		private void shieldToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.Controls.Add(
				new _CTR_.ctr_.bak_.bak__Shield() { Dock = DockStyle.Fill }
				);

			f.MdiParent = this;

			f.WindowState = FormWindowState.Normal;
			f.Dock = DockStyle.None;
			f.Anchor = AnchorStyles.None;
			f.StartPosition = FormStartPosition.CenterScreen; //https://stackoverflow.com/questions/1228120/how-to-make-mdichild-load-at-the-center-of-mdiparent-window .CenterParent;

			//f.Show(this); // exception. note we have already assigned Mdiparent
			f.Show();

		}

		private void moduleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.Controls.Add(
				new _CTR_.ctr_.bak_.bak__Module() { Dock = DockStyle.Fill }
				);

			f.MdiParent = this;

			f.Show();

		}

		private void byDivToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.Controls.Add(
				new _CTR_.ctr_.bak_.module_.bak__module_Div() { Dock = DockStyle.Fill }
				);

			f.MdiParent = this;

			f.Show();


		}

		//private void semaphoreToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	var f = new Form();
		//	f.Controls.Add(
		//		new ctr_._cfg_.sema._cfg__sema_Save(){ Dock = DockStyle.Fill }
		//	);

		//	f.MdiParent = this;

		//	f.Show();


		//}

		private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
		{
			nilnul.dev.bak.Properties.Settings.Default.Save();

		}

		private void SemaphoreToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.MdiParent = this;
			f.Controls.Add(
				new _CTR_.ctr_._cfg_.sema._cfg__sema_Save() { Dock = DockStyle.Fill }
			);

			f.WindowState = FormWindowState.Maximized;
			f.Show();

			//f.WindowState = FormWindowState.Maximized;

		}

		private void lastLog_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var filename = nilnul.app.trace.listener_.file_.templatedName_.BlockQuoted.Instances.LastOrDefault();
			if (filename != default)
			{
				var spear = nilnul.fs.address_.spear_.ParentDoc.Create_ofContainerAsAddress(
					Application.StartupPath
					,
					filename.filename
				);
				nilnul.fs.file._ExeX.Exe(spear);

			}
		}

		private void PushErrAsWarnIfGeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new Form();
			f.Controls.Add(
				new _CTR_.ctr_._cfg_.pushErrAs._cfg__pushErrAs_Save() { Dock = DockStyle.Fill }
			);

			f.MdiParent = this;

			f.Show();


		}

		private void VsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new nilnul.fs._git_._WIN_CTR_.svr_._vs_._ok_.Form1() { Dock = DockStyle.Fill }
			;
			f.WindowState = FormWindowState.Maximized;
			f.MdiParent = this;

			f.Show();

		}




		private void LurkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new nilnul._win_._CTR4WIN_.prog.run.lurk.ok.notice.Form1();// { Dock = DockStyle.Fill };
			f.MdiParent = this;
			f.Show();

		}


		private void accToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new nilnul.fs._git_._WIN_CTR_.svr_.vs.prefix.ok.Form1();// { Dock = DockStyle.Fill };
			f.MdiParent = this;
			f.Show();

		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var f = new AboutBox1();
			//f.MdiParent = this;
			//f.ShowInTaskbar = false;
			f.ShowDialog();
		}
		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void toolStripMenuItem1toClose_Click(object sender, EventArgs e)
		{
			this.ExitToolsStripMenuItem_Click(sender, e);
		}

		private void UpgradeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var msger = new _nilnul_._CTR4WIN_.msg.Form1();
			msger.MdiParent = this;

			msger.Show();

			msger.msg = "force upgrading all...";

			nilnul.fs.git.Properties.Settings.Default.Upgrade();
			nilnul.dev.Properties.Settings.Default.Upgrade();
			nilnul.dev.bak.Properties.Settings.Default.Upgrade();

			msger.msg = "done";
			this.statusStrip.Text = "upgraded";

			msger.Close();
		}
		private void upgradeToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			UpgradeToolStripMenuItem_Click(sender, e);
		}

		_win_._CTR4WIN_.proc.mngers.ProcessesForm procMngers = nilnul._win_._CTR4WIN_.proc.mngers.FormX.ProcMangerEs;
		private void toolStripMenuItem3procs_Click(object sender, EventArgs e)
		{
			_win_._CTR4WIN_.proc.mngers.ProcessesForm f = procMngers;
			f.FormClosing += procMngerEs_FormClosing;
			//f.MdiParent = this;
			f.Show();
		}

		private void procMngerEs_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			procMngers.Hide();
		}

		private void 公开服务器等ToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

		
			var f = new nilnul.fs._git_._WIN_CTR_.svr.client.repo.names_.dict_.pub.feed.ok.Form1() { Dock = DockStyle.Fill };
			f.MdiParent = this;
			f.Show();


		}

		private void clientsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

		
			var f = new nilnul.fs._git_._WIN_CTR_.svr.client.titleds.ok.Form1() { Dock = DockStyle.Fill };
			f.MdiParent = this;
			f.Show();
		}

		private void git地址ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
