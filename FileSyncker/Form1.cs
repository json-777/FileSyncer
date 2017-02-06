using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSyncker
{

    public partial class Menu : Form
    {
        #region グローバル変数
        /// <summary>
        /// 同期元のフルパス
        /// </summary>
        private string SourcePathName;
        /// <summary>
        /// 同期先のフルパス
        /// </summary>
        private string DestPathName;
        /// <summary>
        /// メインクラス
        /// </summary>
        #endregion

        public Form2 Main;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// メインのフォームを操作できるようにする
        /// </summary>
        /// <param name="main">Form2 のインスタンス</param>
        public void SetMainWindow(Form2 main)
        {
            Main = main;
        }
        /// <summary>
        /// 参照ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
            if (Directory.Exists(ShowPathTextBox.Text))
            {
                SourcePathName = ShowPathTextBox.Text;
                NextBotton.Enabled = true;
            }
        }
        /// <summary>
        /// [次へ]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBotton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.メニュー2;
            SyncPathPanel2.Visible = true;
            NextBotton.Enabled = false;
            BackBotton.Enabled = true;
        }
        /// <summary>
        /// テクストボックス変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(ShowPathTextBox.Text))
            {
                SourcePathName = ShowPathTextBox.Text;
                NextBotton.Enabled = true;
            }
            else
            {
                NextBotton.Enabled = false;
            }
        }
        /// <summary>
        /// テクストボックス２変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(ShowPathTextBox.Text))
            {
                SourcePathName = ShowPathTextBox.Text;
                NextBotton.Enabled = true;
            }
            else
            {
                NextBotton.Enabled = false;
            }
        }
        /// <summary>
        /// [次へ]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBotton2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                //同期対象フォルダと同期先フォルダが一致している場合
                ShowPathTextBox2.Text = folderBrowserDialog.SelectedPath;
                if (folderBrowserDialog.SelectedPath.CompareTo(SourcePathName) == 0)
                {
                    MessageBox.Show(
                            "同期対象フォルダと同期先フォルダが一致しています",
                            "FileSyncer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    SelectBotton2_Click(null, null);
                    return;
                }

                if (Directory.Exists(ShowPathTextBox2.Text))
                {
                    SyncStartButton.Visible = true;
                    DestPathName = folderBrowserDialog.SelectedPath;
                    NextBotton.Enabled = false;
                    //同期先のパスをグローバル変数に格納
                    DestPathName = ShowPathTextBox2.Text;
                    //ディレクトリまたはファイルが存在していたらメッセージを表示
                    string[] files = Directory.GetFiles(DestPathName);
                    string[] dirs = Directory.GetDirectories(DestPathName);
                    if (files.Length != 0 || dirs.Length != 0)
                    {
                        DialogResult result = MessageBox.Show(
                            "同期先にファイルまたはディレクトリが存在します。\n上書きしますか？",
                            "FileSyncer",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                            //同期先パスをグローバル変数へ格納
                            DestPathName = folderBrowserDialog.SelectedPath;
                            SyncStartButton.Visible = true;
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            SyncStartButton.Visible = false;
                        }
                        else
                        {
                            //もう一度ダイアログを表示
                            SyncStartButton.Visible = false;
                            SelectBotton2_Click(null, null);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 同期をスタートさせる（メインメニューを表示）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SyncStartButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Save();//同期先と同期元をファイルに保存
            //メインメニューのインスタンスを生成
            if (Main == null)
            {
                Main = new Form2(SourcePathName, DestPathName);
            }
            Main.SetLabelName(SourcePathName, DestPathName);
            Main.SetTimerEnabled(true);
            if(Main.Visible == false)
            {
                Main.ShowDialog();
            }
        }
        /// <summary>
        /// 同期先と同期元をファイルに保存する（カレントディレクトリ\SaveFile\DirectoryConf.csv）
        /// </summary>
        private void Save()
        {
            string SavePath = Directory.GetCurrentDirectory() + @"\SaveFile";
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            using (StreamWriter sw = new StreamWriter(SavePath + @"\DirectoryConf.csv"))
            {
                sw.WriteLine(SourcePathName);
                sw.WriteLine(DestPathName);
            }
        }
        /// <summary>
        /// [戻る]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBotton_Click(object sender, EventArgs e)
        {
            SyncPathPanel2.Visible = false;
            BackBotton.Enabled = false;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Main != null && Main.Visible)
            {
                Main.SetTimerEnabled(true);
            }
        }
    }
}
