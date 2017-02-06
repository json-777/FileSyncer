namespace FileSyncker
{
    partial class Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SyncPathPanel = new System.Windows.Forms.Panel();
            this.SyncPathPanel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectBotton2 = new System.Windows.Forms.Button();
            this.ShowPathTextBox2 = new System.Windows.Forms.TextBox();
            this.SyncLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowPathTextBox = new System.Windows.Forms.TextBox();
            this.BackBotton = new System.Windows.Forms.Button();
            this.NextBotton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SyncStartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SyncPathPanel.SuspendLayout();
            this.SyncPathPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SyncPathPanel
            // 
            this.SyncPathPanel.Controls.Add(this.SyncPathPanel2);
            this.SyncPathPanel.Controls.Add(this.SyncLabel);
            this.SyncPathPanel.Controls.Add(this.button1);
            this.SyncPathPanel.Controls.Add(this.ShowPathTextBox);
            this.SyncPathPanel.Location = new System.Drawing.Point(12, 109);
            this.SyncPathPanel.Name = "SyncPathPanel";
            this.SyncPathPanel.Size = new System.Drawing.Size(480, 101);
            this.SyncPathPanel.TabIndex = 5;
            // 
            // SyncPathPanel2
            // 
            this.SyncPathPanel2.Controls.Add(this.label1);
            this.SyncPathPanel2.Controls.Add(this.SelectBotton2);
            this.SyncPathPanel2.Controls.Add(this.ShowPathTextBox2);
            this.SyncPathPanel2.Location = new System.Drawing.Point(0, 0);
            this.SyncPathPanel2.Name = "SyncPathPanel2";
            this.SyncPathPanel2.Size = new System.Drawing.Size(480, 101);
            this.SyncPathPanel2.TabIndex = 6;
            this.SyncPathPanel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "同期先のファイル";
            // 
            // SelectBotton2
            // 
            this.SelectBotton2.Location = new System.Drawing.Point(318, 29);
            this.SelectBotton2.Name = "SelectBotton2";
            this.SelectBotton2.Size = new System.Drawing.Size(52, 23);
            this.SelectBotton2.TabIndex = 1;
            this.SelectBotton2.Text = "参照...";
            this.SelectBotton2.UseVisualStyleBackColor = true;
            this.SelectBotton2.Click += new System.EventHandler(this.SelectBotton2_Click);
            // 
            // ShowPathTextBox2
            // 
            this.ShowPathTextBox2.Location = new System.Drawing.Point(88, 31);
            this.ShowPathTextBox2.Name = "ShowPathTextBox2";
            this.ShowPathTextBox2.Size = new System.Drawing.Size(217, 19);
            this.ShowPathTextBox2.TabIndex = 0;
            this.ShowPathTextBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SyncLabel
            // 
            this.SyncLabel.AutoSize = true;
            this.SyncLabel.Location = new System.Drawing.Point(23, 16);
            this.SyncLabel.Name = "SyncLabel";
            this.SyncLabel.Size = new System.Drawing.Size(82, 12);
            this.SyncLabel.TabIndex = 2;
            this.SyncLabel.Text = "同期するファイル";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "参照...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPathTextBox
            // 
            this.ShowPathTextBox.Location = new System.Drawing.Point(88, 31);
            this.ShowPathTextBox.Name = "ShowPathTextBox";
            this.ShowPathTextBox.Size = new System.Drawing.Size(217, 19);
            this.ShowPathTextBox.TabIndex = 0;
            this.ShowPathTextBox.TextChanged += new System.EventHandler(this.ShowPathTextBox_TextChanged);
            // 
            // BackBotton
            // 
            this.BackBotton.Enabled = false;
            this.BackBotton.Location = new System.Drawing.Point(330, 226);
            this.BackBotton.Name = "BackBotton";
            this.BackBotton.Size = new System.Drawing.Size(75, 23);
            this.BackBotton.TabIndex = 2;
            this.BackBotton.Text = "前へ";
            this.BackBotton.UseVisualStyleBackColor = true;
            this.BackBotton.Click += new System.EventHandler(this.BackBotton_Click);
            // 
            // NextBotton
            // 
            this.NextBotton.Enabled = false;
            this.NextBotton.Location = new System.Drawing.Point(417, 226);
            this.NextBotton.Name = "NextBotton";
            this.NextBotton.Size = new System.Drawing.Size(75, 23);
            this.NextBotton.TabIndex = 1;
            this.NextBotton.Text = "次へ";
            this.NextBotton.UseVisualStyleBackColor = true;
            this.NextBotton.Click += new System.EventHandler(this.NextBotton_Click);
            // 
            // SyncStartButton
            // 
            this.SyncStartButton.Location = new System.Drawing.Point(417, 226);
            this.SyncStartButton.Name = "SyncStartButton";
            this.SyncStartButton.Size = new System.Drawing.Size(75, 23);
            this.SyncStartButton.TabIndex = 6;
            this.SyncStartButton.Text = "同期の開始";
            this.SyncStartButton.UseVisualStyleBackColor = true;
            this.SyncStartButton.Visible = false;
            this.SyncStartButton.Click += new System.EventHandler(this.SyncStartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::FileSyncker.Properties.Resources.メニュー１;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 103);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.SyncStartButton);
            this.Controls.Add(this.NextBotton);
            this.Controls.Add(this.SyncPathPanel);
            this.Controls.Add(this.BackBotton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "FileSyncer";
            this.SyncPathPanel.ResumeLayout(false);
            this.SyncPathPanel.PerformLayout();
            this.SyncPathPanel2.ResumeLayout(false);
            this.SyncPathPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SyncPathPanel;
        private System.Windows.Forms.Label SyncLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ShowPathTextBox;
        private System.Windows.Forms.Button BackBotton;
        private System.Windows.Forms.Button NextBotton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel SyncPathPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectBotton2;
        private System.Windows.Forms.TextBox ShowPathTextBox2;
        private System.Windows.Forms.Button SyncStartButton;
    }
}

