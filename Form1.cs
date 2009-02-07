using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading;


namespace PALer
{
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusBarPanelMsg = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanelProgress = new System.Windows.Forms.StatusBarPanel();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemFileExit = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItemHelpReadme = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemHelpWeb = new System.Windows.Forms.MenuItem();
			this.menuItemHelpBug = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemHelpVerInfo = new System.Windows.Forms.MenuItem();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.textBox_a = new System.Windows.Forms.TextBox();
			this.textBox_b = new System.Windows.Forms.TextBox();
			this.textBox_o = new System.Windows.Forms.TextBox();
			this.buttonAopen = new System.Windows.Forms.Button();
			this.buttonBopen = new System.Windows.Forms.Button();
			this.buttonOsave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown_B2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_B1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_A2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_A1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonGen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.buttonAbort = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelMsg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelProgress)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusBar
			// 
			this.statusBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.statusBar.Location = new System.Drawing.Point(0, 240);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.statusBarPanelMsg,
																						 this.statusBarPanelProgress});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(310, 20);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 0;
			this.statusBar.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.statusBar_DrawItem);
			// 
			// statusBarPanelMsg
			// 
			this.statusBarPanelMsg.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanelMsg.Width = 155;
			// 
			// statusBarPanelProgress
			// 
			this.statusBarPanelProgress.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanelProgress.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.statusBarPanelProgress.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
			this.statusBarPanelProgress.Width = 155;
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItemFile,
																					 this.menuItemHelp});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemFileExit});
			this.menuItemFile.Text = "ファイル (&F)";
			// 
			// menuItemFileExit
			// 
			this.menuItemFileExit.Index = 0;
			this.menuItemFileExit.Text = "終了 (&X)";
			this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Index = 1;
			this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemHelpReadme,
																						 this.menuItem3,
																						 this.menuItemHelpWeb,
																						 this.menuItemHelpBug,
																						 this.menuItem1,
																						 this.menuItemHelpVerInfo});
			this.menuItemHelp.Text = "ヘルプ (&H)";
			// 
			// menuItemHelpReadme
			// 
			this.menuItemHelpReadme.Index = 0;
			this.menuItemHelpReadme.Text = "付属のテキストを開く (&R)";
			this.menuItemHelpReadme.Click += new System.EventHandler(this.menuItemHelpReadme_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuItemHelpWeb
			// 
			this.menuItemHelpWeb.Index = 2;
			this.menuItemHelpWeb.Text = "作者のウェブサイトを開く (&V)";
			this.menuItemHelpWeb.Click += new System.EventHandler(this.menuItemHelpWeb_Click);
			// 
			// menuItemHelpBug
			// 
			this.menuItemHelpBug.Index = 3;
			this.menuItemHelpBug.Text = "バグ報告をする (&B)";
			this.menuItemHelpBug.Click += new System.EventHandler(this.menuItemHelpBug_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 4;
			this.menuItem1.Text = "-";
			// 
			// menuItemHelpVerInfo
			// 
			this.menuItemHelpVerInfo.Index = 5;
			this.menuItemHelpVerInfo.Text = "バージョン情報 (&A)";
			this.menuItemHelpVerInfo.Click += new System.EventHandler(this.menuItemHelpVerInfo_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(304, 256);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(4, 4);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 1;
			// 
			// textBox_a
			// 
			this.textBox_a.Location = new System.Drawing.Point(104, 20);
			this.textBox_a.Name = "textBox_a";
			this.textBox_a.Size = new System.Drawing.Size(140, 19);
			this.textBox_a.TabIndex = 4;
			this.textBox_a.Text = "";
			this.toolTip.SetToolTip(this.textBox_a, textBox_a.Text);
			// 
			// textBox_b
			// 
			this.textBox_b.Location = new System.Drawing.Point(104, 44);
			this.textBox_b.Name = "textBox_b";
			this.textBox_b.Size = new System.Drawing.Size(140, 19);
			this.textBox_b.TabIndex = 5;
			this.textBox_b.Text = "";
			this.toolTip.SetToolTip(this.textBox_b, textBox_b.Text);
			// 
			// textBox_o
			// 
			this.textBox_o.Location = new System.Drawing.Point(104, 68);
			this.textBox_o.Name = "textBox_o";
			this.textBox_o.Size = new System.Drawing.Size(140, 19);
			this.textBox_o.TabIndex = 6;
			this.textBox_o.Text = "";
			this.toolTip.SetToolTip(this.textBox_o, textBox_o.Text);
			// 
			// buttonAopen
			// 
			this.buttonAopen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonAopen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAopen.Location = new System.Drawing.Point(248, 20);
			this.buttonAopen.Name = "buttonAopen";
			this.buttonAopen.Size = new System.Drawing.Size(20, 19);
			this.buttonAopen.TabIndex = 7;
			this.buttonAopen.Text = "...";
			this.toolTip.SetToolTip(this.buttonAopen, "ボタンクリックでBMSを開きます。");
			this.buttonAopen.Click += new System.EventHandler(this.buttonAopen_Click);
			// 
			// buttonBopen
			// 
			this.buttonBopen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonBopen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonBopen.Location = new System.Drawing.Point(248, 44);
			this.buttonBopen.Name = "buttonBopen";
			this.buttonBopen.Size = new System.Drawing.Size(20, 19);
			this.buttonBopen.TabIndex = 8;
			this.buttonBopen.Text = "...";
			this.toolTip.SetToolTip(this.buttonBopen, "ボタンクリックでBMSを開きます。");
			this.buttonBopen.Click += new System.EventHandler(this.buttonBopen_Click);
			// 
			// buttonOsave
			// 
			this.buttonOsave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonOsave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOsave.Location = new System.Drawing.Point(248, 68);
			this.buttonOsave.Name = "buttonOsave";
			this.buttonOsave.Size = new System.Drawing.Size(20, 19);
			this.buttonOsave.TabIndex = 8;
			this.buttonOsave.Text = "...";
			this.toolTip.SetToolTip(this.buttonOsave, "ボタンクリックでBMSを開きます。");
			this.buttonOsave.Click += new System.EventHandler(this.buttonOsave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "BMSファイル α";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "BMSファイル β";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "出力ファイル";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox_b);
			this.groupBox1.Controls.Add(this.buttonBopen);
			this.groupBox1.Controls.Add(this.textBox_o);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.buttonAopen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox_a);
			this.groupBox1.Controls.Add(this.buttonOsave);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 100);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ファイル";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown_B2);
			this.groupBox2.Controls.Add(this.numericUpDown_B1);
			this.groupBox2.Controls.Add(this.numericUpDown_A2);
			this.groupBox2.Controls.Add(this.numericUpDown_A1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(12, 120);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(284, 76);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "設定";
			// 
			// numericUpDown_B2
			// 
			this.numericUpDown_B2.Location = new System.Drawing.Point(200, 44);
			this.numericUpDown_B2.Maximum = new System.Decimal(new int[] {
																			 256,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_B2.Minimum = new System.Decimal(new int[] {
																			 2,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_B2.Name = "numericUpDown_B2";
			this.numericUpDown_B2.ReadOnly = true;
			this.numericUpDown_B2.Size = new System.Drawing.Size(68, 19);
			this.numericUpDown_B2.TabIndex = 6;
			this.numericUpDown_B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_B2.Value = new System.Decimal(new int[] {
																		   4,
																		   0,
																		   0,
																		   0});
			this.numericUpDown_B2.ValueChanged += new System.EventHandler(this.numericUpDown_B2_ValueChanged);
			// 
			// numericUpDown_B1
			// 
			this.numericUpDown_B1.Location = new System.Drawing.Point(104, 44);
			this.numericUpDown_B1.Maximum = new System.Decimal(new int[] {
																			 3,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_B1.Minimum = new System.Decimal(new int[] {
																			 1,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_B1.Name = "numericUpDown_B1";
			this.numericUpDown_B1.ReadOnly = true;
			this.numericUpDown_B1.Size = new System.Drawing.Size(68, 19);
			this.numericUpDown_B1.TabIndex = 5;
			this.numericUpDown_B1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_B1.Value = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown_B1.ValueChanged += new System.EventHandler(this.numericUpDown_B1_ValueChanged);
			// 
			// numericUpDown_A2
			// 
			this.numericUpDown_A2.Location = new System.Drawing.Point(200, 20);
			this.numericUpDown_A2.Maximum = new System.Decimal(new int[] {
																			 256,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_A2.Minimum = new System.Decimal(new int[] {
																			 2,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_A2.Name = "numericUpDown_A2";
			this.numericUpDown_A2.ReadOnly = true;
			this.numericUpDown_A2.Size = new System.Drawing.Size(68, 19);
			this.numericUpDown_A2.TabIndex = 4;
			this.numericUpDown_A2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_A2.Value = new System.Decimal(new int[] {
																		   4,
																		   0,
																		   0,
																		   0});
			this.numericUpDown_A2.ValueChanged += new System.EventHandler(this.numericUpDown_A2_ValueChanged);
			// 
			// numericUpDown_A1
			// 
			this.numericUpDown_A1.Location = new System.Drawing.Point(104, 20);
			this.numericUpDown_A1.Maximum = new System.Decimal(new int[] {
																			 3,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_A1.Minimum = new System.Decimal(new int[] {
																			 1,
																			 0,
																			 0,
																			 0});
			this.numericUpDown_A1.Name = "numericUpDown_A1";
			this.numericUpDown_A1.ReadOnly = true;
			this.numericUpDown_A1.Size = new System.Drawing.Size(68, 19);
			this.numericUpDown_A1.TabIndex = 3;
			this.numericUpDown_A1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown_A1.Value = new System.Decimal(new int[] {
																		   3,
																		   0,
																		   0,
																		   0});
			this.numericUpDown_A1.ValueChanged += new System.EventHandler(this.numericUpDown_A1_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "αの出現率";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "βの出現率";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(180, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "/";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(180, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(11, 15);
			this.label7.TabIndex = 2;
			this.label7.Text = "/";
			// 
			// buttonGen
			// 
			this.buttonGen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonGen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonGen.Location = new System.Drawing.Point(12, 208);
			this.buttonGen.Name = "buttonGen";
			this.buttonGen.Size = new System.Drawing.Size(284, 23);
			this.buttonGen.TabIndex = 12;
			this.buttonGen.Text = "生成";
			this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
			// 
			// buttonAbort
			// 
			this.buttonAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonAbort.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAbort.Location = new System.Drawing.Point(12, 208);
			this.buttonAbort.Name = "buttonAbort";
			this.buttonAbort.Size = new System.Drawing.Size(284, 23);
			this.buttonAbort.TabIndex = 13;
			this.buttonAbort.Text = "中断";
			this.buttonAbort.Visible = false;
			this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonGen;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.CancelButton = this.buttonAbort;
			this.ClientSize = new System.Drawing.Size(310, 260);
			this.Controls.Add(this.buttonAbort);
			this.Controls.Add(this.buttonGen);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.statusBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelMsg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanelProgress)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItemFile;
		private System.Windows.Forms.MenuItem menuItemFileExit;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemHelpVerInfo;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarPanelMsg;
		private System.Windows.Forms.StatusBarPanel statusBarPanelProgress;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonGen;
		private System.Windows.Forms.TextBox textBox_a;
		private System.Windows.Forms.TextBox textBox_b;
		private System.Windows.Forms.TextBox textBox_o;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDown_A1;
		private System.Windows.Forms.NumericUpDown numericUpDown_A2;
		private System.Windows.Forms.NumericUpDown numericUpDown_B1;
		private System.Windows.Forms.NumericUpDown numericUpDown_B2;
		private System.Windows.Forms.Button buttonAopen;
		private System.Windows.Forms.Button buttonBopen;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button buttonOsave;
		private System.Windows.Forms.Button buttonAbort;

		string title = "P.A.L.er 0.1";
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemHelpReadme;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemHelpWeb;
		private System.Windows.Forms.MenuItem menuItemHelpBug;
		Thread thread_1;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.Text = title;
			this.Font = SystemInformation.MenuFont;

			/*this.Opacity = 0;
			this.Refresh();
			for(float i = 0 ; i  <= 1 ; i += 0.015F)
			{
				this.Opacity = i;
			}*/
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			/*
			for(float i = 1 ; i  >= 0 ; i -= 0.015F)
			{
				this.Opacity = i;
			}*/
		}

		private void menuItemFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItemHelpVerInfo_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(title + "\nCopyright 2004 nulltask.\n\nThanks to:\nRuzeea, testers, users..." ,
				"About P.A.L.er");
		}

		private void statusBar_DrawItem(object sender, System.Windows.Forms.StatusBarDrawItemEventArgs sbdevent)
		{
			if (sbdevent.Panel == this.statusBarPanelProgress)
			{
				StatusBar sb = (StatusBar)sender;
				Rectangle rect = sbdevent.Bounds;
				this.progressBar.SetBounds(sb.Location.X + rect.X, sb.Location.Y + rect.Y, 
					rect.Width, rect.Height);
			}

		}

		private void numericUpDown_A1_ValueChanged(object sender, System.EventArgs e)
		{
			if(numericUpDown_B1.Value != 1)
			numericUpDown_B1.Value = numericUpDown_B2.Value - numericUpDown_A1.Value;
		}

		private void numericUpDown_B1_ValueChanged(object sender, System.EventArgs e)
		{
			if(numericUpDown_A1.Value != 1)
			numericUpDown_A1.Value = numericUpDown_A2.Value - numericUpDown_B1.Value;
		}

		private void numericUpDown_A2_ValueChanged(object sender, System.EventArgs e)
		{

			if(numericUpDown_A1.Value >= numericUpDown_A2.Value)
			{
				numericUpDown_A1.Value = numericUpDown_A2.Value - 1;
			}
			numericUpDown_A1.Maximum = numericUpDown_A2.Value - 1;

			if(numericUpDown_B1.Value >= numericUpDown_A2.Value)
			{
				numericUpDown_B1.Value = numericUpDown_A2.Value - 1;
			}
			numericUpDown_B1.Maximum = numericUpDown_A2.Value - 1;

			decimal w = 0;
			w = numericUpDown_A2.Value;
			numericUpDown_B2.Value = w;
			numericUpDown_A1.Value = numericUpDown_B2.Value - numericUpDown_B1.Value;
			numericUpDown_B1.Value = numericUpDown_A2.Value - numericUpDown_A1.Value;
		}

		private void numericUpDown_B2_ValueChanged(object sender, System.EventArgs e)
		{
			if(numericUpDown_A1.Value >= numericUpDown_A2.Value)
			{
				numericUpDown_A1.Value = numericUpDown_A2.Value - 1;
			}
			numericUpDown_A1.Maximum = numericUpDown_A2.Value - 1;

			if(numericUpDown_B1.Value >= numericUpDown_A2.Value)
			{
				numericUpDown_B1.Value = numericUpDown_A2.Value - 1;
			}
			numericUpDown_B1.Maximum = numericUpDown_A2.Value - 1;

			decimal w = 0;
			w = numericUpDown_B2.Value;
			numericUpDown_A2.Value = w;
			numericUpDown_A1.Value = numericUpDown_B2.Value - numericUpDown_B1.Value;
			numericUpDown_B1.Value = numericUpDown_A2.Value - numericUpDown_A1.Value;
		}

		private void buttonAopen_Click(object sender, System.EventArgs e)
		{
			// 以下の３行は オプション（なくてもＯＫ）
			openFileDialog1.Title = "BMSファイルを開く" ;  // タイトルバーの文字列
			// openFileDialog1.InitialDirectory = "???" ;  // 最初に表示されるディレクトリ
			openFileDialog1.Filter = "BMSファイル (*.bms;*.bme;*.bml;*.pms)|*.bms;*.bme;*.bml;*.pms" ;  //「ファイルの種類」を指定

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox_a.Text = openFileDialog1.FileName ;
			}
		}

		private void buttonBopen_Click(object sender, System.EventArgs e)
		{
			// 以下の３行は オプション（なくてもＯＫ）
			openFileDialog1.Title = "BMSファイルを開く" ;  // タイトルバーの文字列
			// openFileDialog1.InitialDirectory = "???" ;  // 最初に表示されるディレクトリ
			openFileDialog1.Filter = "BMSファイル (*.bms;*.bme;*.bml;*.pms)|*.bms;*.bme;*.bml;*.pms" ;  //「ファイルの種類」を指定

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox_b.Text = openFileDialog1.FileName ;
			}
		}

		private void buttonOsave_Click(object sender, System.EventArgs e)
		{
			// 以下の３行は オプション（なくてもＯＫ）
			saveFileDialog1.Title = "BMSファイルを保存" ;  // タイトルバーの文字列
			// saveFileDialog1.InitialDirectory = "???" ;  // 最初に表示されるディレクトリ
			saveFileDialog1.Filter = "BMSファイル (*.bms;*.bme;*.bml;*.pms)|*.bms;*.bme;*.bml;*.pms" ;  //「ファイルの種類」を指定

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox_o.Text = saveFileDialog1.FileName ;
			}
		}

		private void func_1()
		{
			
			if(textBox_a.Text == "" || textBox_b.Text == "" || textBox_o.Text == "")
			{
				MessageBox.Show("BMSを開いていないか、保存先を指定していません。","エラー");
			}
			else if (File.Exists(textBox_a.Text) == false || File.Exists(textBox_b.Text) == false)
			{
				MessageBox.Show("指定したファイルが存在しません。","エラー");
			}
			else
			{
				string a_header = "";
				string a_data = "";
				string b_data = "";
				string out_string = "";

				progressBar.Maximum = (int)numericUpDown_A2.Value + 3;

				#region αからヘッダ・データ部取出し
				// しょり
				statusBarPanelMsg.Text = "ヘッダ・データ部を読み込み中";
				StreamReader reader = new StreamReader(textBox_a.Text,System.Text.Encoding.Default);
				string line;
				while((line = reader.ReadLine()) != null)
				{
					if(line.ToLower().StartsWith("#player")
						|| line.ToLower().StartsWith("#genre")
						|| line.ToLower().StartsWith("#title")
						|| line.ToLower().StartsWith("#artist")
						|| line.ToLower().StartsWith("#maker")
						|| line.ToLower().StartsWith("#bpm")
						|| line.ToLower().StartsWith("#exbpm")
						|| line.ToLower().StartsWith("#playlevel")
						|| line.ToLower().StartsWith("#rank")
						|| line.ToLower().StartsWith("#defexrank")
						|| line.ToLower().StartsWith("#exrank")
						|| line.ToLower().StartsWith("#volwav")
						|| line.ToLower().StartsWith("#total")
						|| line.ToLower().StartsWith("#lntype")
						|| line.ToLower().StartsWith("#lnobj")
						|| line.ToLower().StartsWith("#oct/fp")
						|| line.ToLower().StartsWith("#option")
						|| line.ToLower().StartsWith("#text")
						|| line.ToLower().StartsWith("#comment")
						|| line.ToLower().StartsWith("#wav")
						|| line.ToLower().StartsWith("#exwav")
						|| line.ToLower().StartsWith("#cdda")
						|| line.ToLower().StartsWith("#midifile")
						|| line.ToLower().StartsWith("#bmp")
						|| line.ToLower().StartsWith("#exbmp")
						|| line.ToLower().StartsWith("#bga")
						|| line.ToLower().StartsWith("#@bga")
						|| line.ToLower().StartsWith("#backbmp")
						|| line.ToLower().StartsWith("#poorbga")
						|| line.ToLower().StartsWith("#swbga")
						|| line.ToLower().StartsWith("#banner")
						|| line.ToLower().StartsWith("#argb")
						|| line.ToLower().StartsWith("#stagefile")
						|| line.ToLower().StartsWith("#videofile")
						|| line.ToLower().StartsWith("#videof/s")
						|| line.ToLower().StartsWith("#vodeocolors")
						|| line.ToLower().StartsWith("#videodly")
						|| line.ToLower().StartsWith("#stop")
						|| line.ToLower().StartsWith("#stp")
						|| line.ToLower().StartsWith("#extchr")
						|| line.ToLower().StartsWith("#materialswav")
						|| line.ToLower().StartsWith("#materialsbmp")
						|| line.ToLower().StartsWith("#charfile")
						|| line.ToLower().StartsWith("%url")
						|| line.ToLower().StartsWith("%mail")
						|| line.ToLower().StartsWith("#divideprop")
						|| line.ToLower().StartsWith("#song")
						)
					{
						a_header += line + "\r\n";
						Thread.Sleep(0);
					}

					if((Regex.Match(line, "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
					{
						a_data += line + "\r\n";
						Thread.Sleep(0);
					}
				}
				reader.Close();
				progressBar.Value++;
				#endregion

				#region βからデータ部取出し
				StreamReader reader1 = new StreamReader(textBox_b.Text,System.Text.Encoding.Default);
				while((line = reader1.ReadLine()) != null)
				{
					if((Regex.Match(line, "#[0-9][0-9][0-9][A-Z_0-9][A-Z_0-9][:]")).Success == true)
					{
						b_data += line + "\r\n";
						Thread.Sleep(0);
					}
				}
				reader1.Close();
				progressBar.Value++;
				#endregion

				#region 合成
				statusBarPanelMsg.Text = "合成中... (0 / " + numericUpDown_A2.Value.ToString() + ")";
				int ifcnt = 1;
				out_string += "#random " + numericUpDown_A2.Value.ToString() + "\r\n";
				out_string += a_header;
				for(decimal i = 0; i < numericUpDown_A1.Value; i++)
				{
					out_string += "#if " 
						+ ifcnt.ToString() 
						+ "\r\n" + a_data 
						+ "#endif\r\n";
					ifcnt++;
					statusBarPanelMsg.Text = "合成中... (" + ifcnt.ToString() + " / " + numericUpDown_A2.Value.ToString() + ")";
					progressBar.Value++;
					Thread.Sleep(0);
				}
				for(decimal i = 0; i < numericUpDown_B1.Value; i++)
				{
					out_string += "#if " 
						+ ifcnt.ToString() 
						+ "\r\n" + b_data 
						+ "#endif\r\n";
					ifcnt++;
					statusBarPanelMsg.Text = "合成中... (" + ifcnt.ToString() + " / " + numericUpDown_A2.Value.ToString() + ")";
					progressBar.Value++;
					Thread.Sleep(0);
				}
				#endregion

				#region 書き出し
				statusBarPanelMsg.Text = "保存中...";
				try
				{
					StreamWriter writer = new StreamWriter(textBox_o.Text,false,System.Text.Encoding.Default);
					writer.Write(out_string);
					writer.Close();
					progressBar.Value++;

					MessageBox.Show("生成に成功しました。","実行結果");
				}
				catch
				{
					MessageBox.Show("保存中にエラーが発生しました。","エラー");
				}
				#endregion

				statusBarPanelMsg.Text = "";
			}
			buttonGen.Visible = true;
			buttonAbort.Visible = false;
			menuItemFileExit.Enabled = true;
			progressBar.Value = 0;
		}

		private void buttonGen_Click(object sender, System.EventArgs e)
		{
			buttonGen.Visible = false;
			buttonAbort.Visible = true;
			menuItemFileExit.Enabled = false;

			thread_1 = new Thread(new ThreadStart(func_1)) ;  // スレッドの宣言
			thread_1.Start() ;                                // スレッドの起動
		}

		private void buttonAbort_Click(object sender, System.EventArgs e)
		{
			thread_1.Abort() ;
			MessageBox.Show("中断しました。","実行結果");
			buttonGen.Visible = true;
			buttonAbort.Visible = false;
			menuItemFileExit.Enabled = true;

			statusBarPanelMsg.Text = "";
			progressBar.Value = 0;
		}

		private void menuItemHelpReadme_Click(object sender, System.EventArgs e)
		{
			if (File.Exists(Application.StartupPath + @"\PALer.txt"))
			{
				System.Diagnostics.Process.Start(Application.StartupPath + @"\PALer.txt");
			}
			else
			{
				MessageBox.Show("リ、リードミーがないじゃないか！\nな、なんてこった！！！！","エラー");
			}
		}

		private void menuItemHelpWeb_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.bz/");
		}

		private void menuItemHelpBug_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.bz/cgi-bin/patio/patio.cgi?mode=view&no=4");
		}
	}
}
