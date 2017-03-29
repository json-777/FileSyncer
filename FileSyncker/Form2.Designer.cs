namespace FileSyncker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ConfigurationPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.DisplaySyncPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FolderManagementPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CopyPathLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.TabPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel1 = new System.Windows.Forms.Panel();
            this.MenuLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel4 = new System.Windows.Forms.Panel();
            this.MenuPanel3 = new System.Windows.Forms.Panel();
            this.MenuLabel3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MenuPanel2 = new System.Windows.Forms.Panel();
            this.MenuLabel2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuPanel5 = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ExitBotton = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ConfigurationPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.DisplaySyncPanel.SuspendLayout();
            this.FolderManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.TabPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.MenuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "チェックマーク.ico");
            this.imageList1.Images.SetKeyName(1, "2865.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FileSyncer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了xToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(192, 26);
            // 
            // 終了xToolStripMenuItem
            // 
            this.終了xToolStripMenuItem.Name = "終了xToolStripMenuItem";
            this.終了xToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.終了xToolStripMenuItem.Text = "アプリケーションを終了(&X)";
            this.終了xToolStripMenuItem.Click += new System.EventHandler(this.終了xToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.MainPanel, 5);
            this.MainPanel.Controls.Add(this.ConfigurationPanel);
            this.MainPanel.Controls.Add(this.DisplaySyncPanel);
            this.MainPanel.Controls.Add(this.TabPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 79);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(697, 384);
            this.MainPanel.TabIndex = 4;
            // 
            // ConfigurationPanel
            // 
            this.ConfigurationPanel.Controls.Add(this.groupBox2);
            this.ConfigurationPanel.Controls.Add(this.groupBox1);
            this.ConfigurationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationPanel.Location = new System.Drawing.Point(0, 0);
            this.ConfigurationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ConfigurationPanel.Name = "ConfigurationPanel";
            this.ConfigurationPanel.Size = new System.Drawing.Size(697, 384);
            this.ConfigurationPanel.TabIndex = 4;
            this.ConfigurationPanel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Location = new System.Drawing.Point(11, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "詳細設定";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "秒";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "エクスプローラで表示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(507, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(58, 19);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(386, 30);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 16);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "同期間隔を設定する";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(29, 29);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(94, 16);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "ログを書き出す";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一般設定";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(386, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 16);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "通知を表示";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "システム起動時に起動";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(29, 62);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 16);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "トレイに格納する";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // DisplaySyncPanel
            // 
            this.DisplaySyncPanel.Controls.Add(this.label4);
            this.DisplaySyncPanel.Controls.Add(this.FolderManagementPanel);
            this.DisplaySyncPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplaySyncPanel.Location = new System.Drawing.Point(0, 0);
            this.DisplaySyncPanel.Name = "DisplaySyncPanel";
            this.DisplaySyncPanel.Size = new System.Drawing.Size(697, 384);
            this.DisplaySyncPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "text";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // FolderManagementPanel
            // 
            this.FolderManagementPanel.BackColor = System.Drawing.Color.White;
            this.FolderManagementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderManagementPanel.Controls.Add(this.progressBar1);
            this.FolderManagementPanel.Controls.Add(this.CopyPathLabel);
            this.FolderManagementPanel.Controls.Add(this.button1);
            this.FolderManagementPanel.Controls.Add(this.label3);
            this.FolderManagementPanel.Controls.Add(this.pictureBox7);
            this.FolderManagementPanel.Location = new System.Drawing.Point(7, 43);
            this.FolderManagementPanel.Name = "FolderManagementPanel";
            this.FolderManagementPanel.Size = new System.Drawing.Size(680, 331);
            this.FolderManagementPanel.TabIndex = 2;
            this.FolderManagementPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FolderManagementPanel_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(117, 58);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(118, 10);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // CopyPathLabel
            // 
            this.CopyPathLabel.AutoSize = true;
            this.CopyPathLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyPathLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CopyPathLabel.Location = new System.Drawing.Point(118, 11);
            this.CopyPathLabel.Name = "CopyPathLabel";
            this.CopyPathLabel.Size = new System.Drawing.Size(39, 16);
            this.CopyPathLabel.TabIndex = 0;
            this.CopyPathLabel.Text = "text";
            this.CopyPathLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CopyPathLabel_MouseClick);
            this.CopyPathLabel.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.CopyPathLabel.MouseLeave += new System.EventHandler(this.CopyPathLabel_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "同期元：同期先を変更";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "ローカルフォルダを同期中";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FileSyncker.Properties.Resources.MenuIcon;
            this.pictureBox7.Location = new System.Drawing.Point(17, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(94, 83);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.tabControl);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Location = new System.Drawing.Point(0, 0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.Size = new System.Drawing.Size(697, 384);
            this.TabPanel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 4);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(697, 381);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 352);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "同期";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "同期状況を表示します";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(3, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 322);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "時刻";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ファイル名";
            this.columnHeader9.Width = 124;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "アクション";
            this.columnHeader10.Width = 173;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "サイズ";
            this.columnHeader11.Width = 401;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(689, 352);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "未同期";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(1, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "無視またはエラーとなったファイルを表示します";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Location = new System.Drawing.Point(3, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(686, 322);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "時刻";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ファイル名";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "アクション";
            this.columnHeader3.Width = 173;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.93375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.24921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40694F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.6877F));
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BottomPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.72868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.5814F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.544469F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MenuPanel1
            // 
            this.MenuPanel1.BackColor = System.Drawing.Color.White;
            this.MenuPanel1.Controls.Add(this.MenuLabel1);
            this.MenuPanel1.Controls.Add(this.pictureBox1);
            this.MenuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel1.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel1.Name = "MenuPanel1";
            this.MenuPanel1.Size = new System.Drawing.Size(91, 76);
            this.MenuPanel1.TabIndex = 16;
            // 
            // MenuLabel1
            // 
            this.MenuLabel1.AutoSize = true;
            this.MenuLabel1.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.MenuLabel1.ForeColor = System.Drawing.Color.Black;
            this.MenuLabel1.Location = new System.Drawing.Point(25, 62);
            this.MenuLabel1.Name = "MenuLabel1";
            this.MenuLabel1.Size = new System.Drawing.Size(39, 12);
            this.MenuLabel1.TabIndex = 1;
            this.MenuLabel1.Text = "ファイル";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FileSyncker.Properties.Resources.file_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuPanel4
            // 
            this.MenuPanel4.BackColor = System.Drawing.Color.White;
            this.MenuPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel4.Location = new System.Drawing.Point(279, 0);
            this.MenuPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel4.Name = "MenuPanel4";
            this.MenuPanel4.Size = new System.Drawing.Size(94, 76);
            this.MenuPanel4.TabIndex = 19;
            // 
            // MenuPanel3
            // 
            this.MenuPanel3.BackColor = System.Drawing.Color.White;
            this.MenuPanel3.Controls.Add(this.MenuLabel3);
            this.MenuPanel3.Controls.Add(this.pictureBox3);
            this.MenuPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel3.Location = new System.Drawing.Point(186, 0);
            this.MenuPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel3.Name = "MenuPanel3";
            this.MenuPanel3.Size = new System.Drawing.Size(93, 76);
            this.MenuPanel3.TabIndex = 18;
            // 
            // MenuLabel3
            // 
            this.MenuLabel3.AutoSize = true;
            this.MenuLabel3.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel3.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.MenuLabel3.ForeColor = System.Drawing.Color.Black;
            this.MenuLabel3.Location = new System.Drawing.Point(31, 61);
            this.MenuLabel3.Name = "MenuLabel3";
            this.MenuLabel3.Size = new System.Drawing.Size(29, 12);
            this.MenuLabel3.TabIndex = 3;
            this.MenuLabel3.Text = "一般";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::FileSyncker.Properties.Resources.config_icon;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MenuPanel2
            // 
            this.MenuPanel2.BackColor = System.Drawing.Color.White;
            this.MenuPanel2.Controls.Add(this.MenuLabel2);
            this.MenuPanel2.Controls.Add(this.pictureBox2);
            this.MenuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel2.Location = new System.Drawing.Point(91, 0);
            this.MenuPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel2.Name = "MenuPanel2";
            this.MenuPanel2.Size = new System.Drawing.Size(95, 76);
            this.MenuPanel2.TabIndex = 17;
            // 
            // MenuLabel2
            // 
            this.MenuLabel2.AutoSize = true;
            this.MenuLabel2.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.MenuLabel2.ForeColor = System.Drawing.Color.Black;
            this.MenuLabel2.Location = new System.Drawing.Point(32, 62);
            this.MenuLabel2.Name = "MenuLabel2";
            this.MenuLabel2.Size = new System.Drawing.Size(29, 12);
            this.MenuLabel2.TabIndex = 3;
            this.MenuLabel2.Text = "同期";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::FileSyncker.Properties.Resources.sync_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MenuPanel5
            // 
            this.MenuPanel5.BackColor = System.Drawing.Color.White;
            this.MenuPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel5.Location = new System.Drawing.Point(373, 0);
            this.MenuPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel5.Name = "MenuPanel5";
            this.MenuPanel5.Size = new System.Drawing.Size(330, 76);
            this.MenuPanel5.TabIndex = 15;
            // 
            // BottomPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BottomPanel, 5);
            this.BottomPanel.Controls.Add(this.ExitBotton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 466);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(703, 50);
            this.BottomPanel.TabIndex = 20;
            // 
            // ExitBotton
            // 
            this.ExitBotton.Location = new System.Drawing.Point(592, 15);
            this.ExitBotton.Name = "ExitBotton";
            this.ExitBotton.Size = new System.Drawing.Size(98, 23);
            this.ExitBotton.TabIndex = 0;
            this.ExitBotton.Text = "ウィンドウを閉じる";
            this.ExitBotton.UseVisualStyleBackColor = true;
            this.ExitBotton.Click += new System.EventHandler(this.ExitBotton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "FileSyncer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.contextMenuStrip.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ConfigurationPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DisplaySyncPanel.ResumeLayout(false);
            this.DisplaySyncPanel.PerformLayout();
            this.FolderManagementPanel.ResumeLayout(false);
            this.FolderManagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.TabPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MenuPanel1.ResumeLayout(false);
            this.MenuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuPanel3.ResumeLayout(false);
            this.MenuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.MenuPanel2.ResumeLayout(false);
            this.MenuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 終了xToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel MenuPanel4;
        private System.Windows.Forms.Panel MenuPanel3;
        private System.Windows.Forms.Panel MenuPanel2;
        private System.Windows.Forms.Panel MenuPanel1;
        private System.Windows.Forms.Label MenuLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ConfigurationPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel TabPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel DisplaySyncPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel FolderManagementPanel;
        private System.Windows.Forms.Label CopyPathLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel MenuPanel5;
        private System.Windows.Forms.Label MenuLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MenuLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ExitBotton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}