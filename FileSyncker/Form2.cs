using Microsoft.Win32;
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
using System.Xml.Serialization;

namespace FileSyncker
{
    public enum FileStatus
    {
        Directory,
        File
    }
    public enum SynckAction
    {
        /// <summary>
        /// 同期済み
        /// </summary>
        Synced,
        /// <summary>
        /// 消去
        /// </summary>
        Deleted,
        /// <summary>
        /// 例外１
        /// </summary>
        UnauthorizedAccessException,
        /// <summary>
        /// 例外２
        /// </summary>
        PathTooLongException,
        /// <summary>
        /// 例外３
        /// </summary>
        IOExpection,

    }
    public enum SyncState
    {
        /// <summary>
        /// ファイルを消去中
        /// </summary>
        Deleating,
        /// <summary>
        /// ファイルをコピー中
        /// </summary>
        Coping,
        /// <summary>
        /// 同期中に例外が発生した
        /// </summary>
        Error,
    }

    public partial class Form2 : Form
    {
        #region グローバル変数
        /// <summary>
        /// 同期するファイルのフルパス
        /// </summary>
        private string SourcePathName;
        /// <summary>
        /// 同期先のフルパス
        /// </summary>
        private string DestPathName;
        /// <summary>
        /// タスクトレイに格納されているか
        /// </summary>
        private bool TaskTrayFlag = true;
        /// <summary>
        /// 同期中であるか
        /// </summary>
        private bool SyncingFlag = false;
        /// <summary>
        /// 同期の結果
        /// </summary>
        private SyncState SyncStatus;
        /// <summary>
        /// 消去すべきリスト
        /// </summary>
        private List<FileStatusStructure> DeleteFileList = new List<FileStatusStructure>();
        /// <summary>
        /// 同期すべきリスト
        /// </summary>
        private List<FileStatusStructure> CopyFileList   = new List<FileStatusStructure>();
        /// <summary>
        ///　例外が発生したリスト
        /// </summary>
        private List<FileStatusStructure> ExceptionList  = new List<FileStatusStructure>();
        /// <summary>
        /// 設定を格納する構造体
        /// </summary>
        public Settings AppSettings;
        /// <summary>
        /// メニューを表示するためのインスタンス
        /// </summary>
        public Menu MenuWindow;
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ssp">同期先の Fullpath</param>
        /// <param name="dsp">同期元の Fullpath</param>
        public Form2(string ssp, string dsp)
        {
            InitializeComponent();
            AppSettings = new Settings();
            SourcePathName = ssp;
            DestPathName = dsp;
            AppSettings = Settings.ImportSettingFile();
            SetCheckBox();
            //コントロールの背景に透明色を指定できるようにする
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        /// <summary>
        /// 設定をデフォルトにする
        /// </summary>
        private void SetDefaultConf()
        {
            AppSettings.DrawLogFile = false;
            AppSettings.HousingTray = true;
            AppSettings.Notice = true;
            AppSettings.StartOnBoot = false;
            AppSettings.SyncIntervalFlag = false;
            
        }
        /// <summary>
        /// フォームを閉じるときのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TaskTrayFlag && AppSettings.HousingTray)
            {
                notifyIcon.Visible = true;
                this.Visible = false;
                e.Cancel = true;
                return;
            }
            try
            {
                Settings.ExportSettingFile(AppSettings);
            }
            catch (IOException)
            {
                MessageBox.Show("ログファイルが開かれているためログの書き込みができませんでした",
                     "FileSync",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            catch (Exception){ }

            if (AppSettings.DrawLogFile)
            {
                ExportLogFile();
            }
        }

        /// <summary>
        /// ログを書き出す
        /// </summary>
        public void ExportLogFile()
        {
            string SavePath = Directory.GetCurrentDirectory() + @"\LogFile";
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            ListView.ListViewItemCollection lv = listView1.Items;
            string SaveFile = SavePath + @"\log_" + DateTime.Today.ToShortDateString().Replace("/","") + @".log";
            try
            {
                using (StreamWriter sr = new StreamWriter(SaveFile, true))
                {
                    foreach (ListViewItem item in lv)
                    {
                        sr.WriteLine(string.Format("{0} {1} {2}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text));
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("ログファイルが開かれているためログの書き込みができませんでした",
                    "FileSync", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error );
            }
            catch (Exception) { }
        }

        /// <summary>
        /// 同期するラベルの変更（Menuから使用）
        /// </summary>
        public void SetLabelName(string ssp, string dsp)
        {
            SourcePathName = ssp;
            DestPathName = dsp;
            CopyPathLabel.Text = ssp + " : 監視中";
            label4.Text = dsp;
        }

        /// <summary>
        /// タイマーの有効にする（Menuから使用）
        /// </summary>
        /// <param name="flag"></param>
        public void SetTimerEnabled(bool flag)
        {
            timer1.Enabled = flag;
        }


        private void label1_MouseEnter(object sender, EventArgs e)
        {
            CopyPathLabel.ForeColor = SystemColors.Highlight;
        }

        private void CopyPathLabel_MouseLeave(object sender, EventArgs e)
        {
            CopyPathLabel.ForeColor = SystemColors.ControlText;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            //監視中のパネル操作
            CopyPathLabel.Text = SourcePathName + " : 監視中";

            timer1.Enabled = true;

            ///デフォルトをTabPanelに
            pictureBox1.BackColor = Color.RoyalBlue;
            MenuLabel1.ForeColor = Color.Beige;
            TabPanel.Visible = false;
            DisplaySyncPanel.Visible = true;
            //タブ１のテキスト変更
            label4.Text = DestPathName;

            //タイマーのインターバル変更
            if (AppSettings.SyncIntervalFlag)
            {
                timer1.Interval = AppSettings.SyncInterval * 1000;
            }

            //設定の同期間隔設定のチェックされていなかったらnumericUpDown1を無効に
            if (!AppSettings.SyncIntervalFlag)
            {
                numericUpDown1.Enabled = false;
            }
            //透明化プロパティ設定

            /*親コントロール設定*/
            pictureBox1.Controls.Add(MenuLabel1);
            pictureBox2.Controls.Add(MenuLabel2);
            pictureBox3.Controls.Add(MenuLabel3);


        }

        /// <summary>
        /// エクスプローラ起動
        /// </summary>
        private void CopyPathLabel_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", SourcePathName);
        }

        /// <summary>
        /// タイマーイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Action func =async () =>
            {          
                timer1.Enabled = false;
                //同期先、同期元のディレクトリがあるか確認
                if (!Directory.Exists(SourcePathName) || !Directory.Exists(DestPathName))
                {
                    MessageBox.Show("同期元または同期先のファイルがアクセスできなくなりました。選択しなおしてください"
                        , "FileSync"
                        , MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    timer1.Enabled = false;
                    MenuWindow = new Menu();
                    MenuWindow.SetMainWindow(this);
                    MenuWindow.ShowDialog();
                    return;
                }
                await Task.Run(() => GetSyncOfFileList(SourcePathName,DestPathName));//GetSyncOfFileListはグローバル変数に格納される

                SyncingFlag = true;
                bool flag = false;
                if (CopyFileList.Count != 0 || DeleteFileList.Count != 0)
                {
                    //Expectionリストに一致するものは恒久的にコピーも消去も行わない                
                    IEnumerable<string> SourceList = ExceptionList.Select(s => s.SourcePath);
                    CopyFileList = CopyFileList.Where(w => !SourceList.Contains(w.SourcePath)).ToList();
                    DeleteFileList = DeleteFileList.Where(w => !SourceList.Contains(w.SourcePath)).ToList();

                    #region dictionaryを使う方法
                    //var dic = CopyFileList.Zip(Enumerable.Range(0, CopyFileList.Count - 1), (n, s) => new { n, s }).ToDictionary(d => d.n.SourcePath,d => d.s);
                    //try
                    //{

                    //}
                    //catch (Exception)
                    //{


                    //}
                    #endregion

                    if (CopyFileList.Count != 0 || DeleteFileList.Count != 0)
                    {
                        //同期変更ボタンを非表示
                        button1.Visible = false;
                        progressBar1.Visible = true;
                        flag = true;
                        if(pictureBox2.BackColor == Color.RoyalBlue)
                        {
                            pictureBox2.Image = Properties.Resources.sync_iconGif_backgroundColor_bule;
                            pictureBox7.Image = Properties.Resources.Icon;
                        }
                        else
                        {

                            pictureBox2.Image = Properties.Resources.sync_iconGif_backgroundColor_white;
                            pictureBox7.Image = Properties.Resources.Icon;
                        }
                        await Task.Run(() => CopyAndDeleateOfFile(CopyFileList, DeleteFileList));
                        progressBar1.Visible = false;
                        button1.Visible = true;
                    }
                }
                //同期が発生した場合の処理
                if (flag)
                {
                    if (AppSettings.Notice && SyncStatus != SyncState.Error)
                    {
                        notifyIcon.BalloonTipText = "同期が完了しました";
                        notifyIcon.ShowBalloonTip(500);
                    }
                }
                flag = false;
                pictureBox2.Image = Properties.Resources.sync_icon;//pictureBox2をもとの画像に戻す
                pictureBox7.Image = Properties.Resources.MenuIcon;
                SyncingFlag = false;

                // 配列全消去
                CopyFileList.Clear();
                DeleteFileList.Clear();
                timer1.Enabled = true;
            };

            func();
            
        }

        #region コントロールに対する操作
        delegate void DrawListView1Delegate(FileStatusStructure text, SynckAction flag,string size);

        /// <summary>
        /// ListView1に文字列を挿入する
        /// </summary>
        /// <param name="text">フルパス</param>
        /// <param name="action">アクションで指定する振る舞い</param>
        private void DrawListView1(FileStatusStructure text,SynckAction flag,string size)
        {
            string action = "例外";
            switch (flag)
            {
                case SynckAction.Synced:
                    action = "同期済み";
                    break;
                case SynckAction.Deleted:
                    action = "消去しました";
                    break;
                case SynckAction.IOExpection:
                    action = "ほかのプロセスが使用中のためスルーしました"; 
                    break;
            }
            string splitTest = SplitString(text);
            listView1.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString("yyyy/MM/dd HH:mm"), splitTest, action, size }));
        }

        delegate void DrawListView2Delegate(FileStatusStructure text, SynckAction flag);
        /// <summary>
        /// ListView2に文字列を挿入する
        /// </summary>
        /// <param name="text">フルパス</param>
        /// <param name="action">アクションで指定する振る舞い</param>
        private void DrawListView2(FileStatusStructure text, SynckAction flag)
        {
            string action = "例外";
            switch (flag)
            {
                case SynckAction.PathTooLongException:
                    action = "コピー元のパス名が長すぎます";
                    break;
                case SynckAction.UnauthorizedAccessException:
                    action = "コピー元に必要なアクセス許可がありません";
                    break;
            }
            string splitText = SplitString(text);
            listView2.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString("yyyy/MM/dd HH:mm"), splitText, action}));
        }

        /// <summary>
        /// 文字列を任意系に切り取る
        /// </summary>
        /// <param name="text">フルパス</param>
        /// <returns>対象ファイルパス以降を返す</returns>
        private string SplitString(FileStatusStructure text)
        {
            string[] SplitString = SourcePathName.Split(Path.DirectorySeparatorChar);
            string DleateString = SourcePathName.Replace(SplitString[SplitString.Length - 1], "");
            return text.SourcePath.Replace(DleateString, "").Replace(@"\",@"/");
        }
      
        delegate void DrawProgressbarDelegate(int value);
        /// <summary>
        /// プログレスバーに値を入力する
        /// </summary>
        /// <param name="value"></param>
        private void DrawProgressbar(int value)
        {
            if(value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("","値が無効です");
            }
            progressBar1.Value = value;
            progressBar1.Update();
        }
        #endregion

        #region ファイル操作関係

        /// <summary>
        /// ファイル同期する(別スレッド動作)
        /// </summary>
        /// <param name="sourceDirName">同期元のファイル（FullPath）</param>
        /// <param name="destDirName">同期するのファイル（FullPath</param>
        public void GetSyncOfFileList(string sourceDirName, string destDirName)
        {
            GetSyncOfFileListRecursive(sourceDirName, destDirName);
        }

        /// <summary>
        /// ファイルを同期する再帰関数
        /// </summary>
        /// <param name="sourceDirName">同期元のファイル（FullPath）</param>
        /// <param name="destDirName">同期するのファイル（FullPath</param>
        private void GetSyncOfFileListRecursive(string sourceDirName, string destDirName)
        {
            if (!Directory.Exists(destDirName))
            {
                CopyFileList.Add(new FileStatusStructure(FileStatus.Directory, sourceDirName, destDirName));
            }

            //コピー先のディレクトリ名に末尾に\をつける
            if (destDirName[destDirName.Length - 1] != Path.AltDirectorySeparatorChar)
            {
                destDirName += Path.AltDirectorySeparatorChar;
            }

            //コピー元のディレクトリにあるファイル名をコピー
            string[] files = Directory.GetFiles(sourceDirName);

            foreach (string f in files)
            {
                string destFileName = destDirName + Path.GetFileName(f);
                //コピー先にファイルが存在し、
                //コピー元より更新日時が古い時はコピーする
                if (!File.Exists(destFileName) || File.GetLastWriteTime(destFileName) < File.GetLastWriteTime(f))
                {
                    CopyFileList.Add(new FileStatusStructure(FileStatus.File, f, destDirName));
                }
            }
            //コピー先にあってコピー元にないファイルを削除

            GetDeleatOfFileList(sourceDirName, destDirName);

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
            {
                GetSyncOfFileListRecursive(dir, destDirName + Path.GetFileName(dir));
            }

        }

        /// <summary>
        /// destDirNameにありsourceDirNameにないファイルを削除する
        /// </summary>
        /// <param name="sourceDirName">比較先のフォルダ</param>
        /// <param name="destDirName">比較もとのフォルダ</param>
        private void GetDeleatOfFileList(string sourceDirName, string destDirName)
        {
            if (!Directory.Exists(destDirName))
            {
                return;
            }
            //sourceDirNameの末尾に"\"をつける
            if (sourceDirName[sourceDirName.Length - 1] != Path.DirectorySeparatorChar)
            {
                sourceDirName = sourceDirName + Path.DirectorySeparatorChar;
            }

            string[] files = Directory.GetFiles(destDirName);
            foreach (var file in files)
            {
                if (!File.Exists(sourceDirName + Path.GetFileName(file)))
                {
                    DeleteFileList.Add(new FileStatusStructure(FileStatus.File, file, file));
                }
            }

            string[] folders = Directory.GetDirectories(destDirName);
            foreach (string folder in folders)
            {
                if (!Directory.Exists(sourceDirName + Path.GetFileName(folder)))
                {
                    DeleteFileList.Add(new FileStatusStructure(FileStatus.Directory, folder, folder));
                }
            }
        }

        /// <param name="DeleateFileList"></param>
        public void CopyAndDeleateOfFile(List<FileStatusStructure> CopyFileList, List<FileStatusStructure> DeleateFileList)
        {
          
            CopyOfFile(CopyFileList);
            DeleteOfFile(DeleateFileList);
        }

        /// <summary>
        /// 指定したファイルを全てコピーする
        /// </summary>
        /// <param name="CopyFileList"></param>
        public void CopyOfFile(List<FileStatusStructure> CopyFileList)
        {
            //全体のファイル数を計算
            double wholeVlue = CopyFileList.Count(c => c.Status == FileStatus.File);

            double count = 0;//プログレスバー用

            SyncStatus = SyncState.Coping;
            string filesize = "0KB";
            DrawListView1Delegate ListView1InvokeData = new DrawListView1Delegate(DrawListView1);
            foreach (var item in CopyFileList)
            {                
                if (item.Status == FileStatus.Directory)
                {
                    //対象がディレクトリであったら
                    try
                    {
                        if (!Directory.Exists(item.DestPath))
                        {   
                            Directory.CreateDirectory(item.DestPath);
                            //属性もコピー
                            File.SetAttributes(item.DestPath, File.GetAttributes(item.SourcePath));
                            this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.Synced, filesize});//listViewに書き込み
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        SyncStatus = SyncState.Error;
                        ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                        DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                        this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.UnauthorizedAccessException });
                    }
                    catch (PathTooLongException)
                    {
                        SyncStatus = SyncState.Error;
                        ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                        DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                        this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.PathTooLongException });
                    }
                    catch (IOException)
                    {
                        SyncStatus = SyncState.Error;
                        this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.IOExpection, filesize });
                        continue;
                    }
                    catch (Exception)
                    {
                        SyncStatus = SyncState.Error;
                        return;
                    }
                }
                else  //対象がファイルであったら
                {
                    DrawProgressbarDelegate DrawProgressbarInvokeData = new DrawProgressbarDelegate(DrawProgressbar);
                    try
                    {
                        count++;
                        FileInfo fi = new FileInfo(item.SourcePath);
                        filesize = (fi.Length / 1024).ToString() + "KB";
                        File.Copy(item.SourcePath, item.DestPath + Path.GetFileName(item.SourcePath), true);
                        this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.Synced, filesize });
                        double value = (count / wholeVlue * 100);
                        this.Invoke(DrawProgressbarInvokeData, new object[] {(int)value });
                    }
                    catch (UnauthorizedAccessException)
                    {
                        SyncStatus = SyncState.Error;
                        ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                        DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                        this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.UnauthorizedAccessException });
                    }
                    catch (PathTooLongException)
                    {
                        SyncStatus = SyncState.Error;
                        ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                        DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                        this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.PathTooLongException });
                    }
                    catch (IOException)
                    {
                        SyncStatus = SyncState.Error;
                        this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.IOExpection, filesize });
                        continue;
                    }
                    catch (Exception)
                    {
                        SyncStatus = SyncState.Error;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 指定したファイルを消去する
        /// </summary>
        /// <param name="DeleateFileList"></param>
        public void DeleteOfFile(List<FileStatusStructure> DeleateFileList)
        {
            SyncStatus = SyncState.Deleating;
            DrawListView1Delegate ListView1InvokeData = new DrawListView1Delegate(DrawListView1);

            foreach (var item in DeleateFileList)
            {
                if(item.Status == FileStatus.Directory)
                {
                    if (!Directory.Exists(item.DestPath))
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            string filesize = "0KB";
                            Directory.Delete(item.DestPath,true);
                            this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.Deleted,filesize });
                        }
                        catch (UnauthorizedAccessException)
                        {
                            SyncStatus = SyncState.Error;
                            ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                            DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                            this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.UnauthorizedAccessException });
                        }
                        catch (PathTooLongException)
                        {
                            SyncStatus = SyncState.Error;
                            ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                            DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                            this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.PathTooLongException });
                        }
                        catch (IOException)
                        {
                            SyncStatus = SyncState.Error;
                            this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.IOExpection, "0KB" });
                            continue;
                        }
                        catch (Exception)
                        {
                            SyncStatus = SyncState.Error;
                            return;
                        }
                    }
                }
                else
                {
                  
                    try
                    {
                        FileInfo fi = new FileInfo(item.DestPath);
                        string filesize = (fi.Length / 1024).ToString() + "KB";
                        File.Delete(item.DestPath);
                        this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.Deleted,filesize });
                    }
                    catch (UnauthorizedAccessException)
                    {
                        SyncStatus = SyncState.Error;
                        ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                        DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                        this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.UnauthorizedAccessException });
                    }
                    catch (PathTooLongException)
                    {
                        SyncStatus = SyncState.Error;
                        ExceptionList.Add(new FileStatusStructure(FileStatus.Directory, item.SourcePath, null));
                        DrawListView2Delegate ListView2InvokeData = new DrawListView2Delegate(DrawListView2);
                        this.Invoke(ListView2InvokeData, new object[] { item, SynckAction.PathTooLongException });
                    }
                    catch (IOException)
                    {
                        SyncStatus = SyncState.Error;
                        this.Invoke(ListView1InvokeData, new object[] { item, SynckAction.IOExpection, "0KB" });
                        continue;
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
        }


        #endregion

        #region 設定が変更されたときのイベント群

        /// <summary>
        /// システム起動設定
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.StartOnBoot = checkBox1.Checked;
        }
        /// <summary>
        /// 通知設定
        /// </summary>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Notice = checkBox2.Checked;
        }
        /// <summary>
        /// 同期間隔（フラグ）
        /// </summary>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.SyncIntervalFlag = checkBox3.Checked;
            if (AppSettings.SyncIntervalFlag)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
            }
        }

        /// <summary>
        /// 同期間隔の設定
        /// </summary>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            AppSettings.SyncInterval = (int)numericUpDown1.Value;
            if (AppSettings.SyncIntervalFlag)
            {
                timer1.Interval = AppSettings.SyncInterval * 1000;
            }
            timer1.Enabled = true;
        }

        /// <summary>
        /// ログの設定
        /// </summary>
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.DrawLogFile = checkBox6.Checked;
        }
        /// <summary>
        /// トレイ格納設定
        /// </summary>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.HousingTray = checkBox4.Checked;
        }

        /// <summary>
        /// 設定メニューのチェックボックスをセットする
        /// </summary>
        private void SetCheckBox()
        {
            checkBox1.Checked = AppSettings.StartOnBoot;
            checkBox2.Checked = AppSettings.Notice;
            checkBox3.Checked = AppSettings.SyncIntervalFlag;
            checkBox6.Checked = AppSettings.DrawLogFile;
            checkBox4.Checked = AppSettings.HousingTray;
        }




        #endregion

        #region メニュー操作
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;

            MenuLabel1.ForeColor = Color.Beige;
            MenuLabel2.ForeColor = Color.Black;
            MenuLabel3.ForeColor = Color.Black;

            TabPanel.Visible = false;
            DisplaySyncPanel.Visible = true;
            ConfigurationPanel.Visible = false;

            if (SyncingFlag)
            {
                pictureBox2.Image = Properties.Resources.sync_iconGif_backgroundColor_white;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox3.BackColor = Color.White;

            MenuLabel1.ForeColor = Color.Black;
            MenuLabel2.ForeColor = Color.Beige;
            MenuLabel3.ForeColor = Color.Black;

            TabPanel.Visible = true;
            DisplaySyncPanel.Visible = false;
            ConfigurationPanel.Visible = false;
            if (SyncingFlag)
            {
                pictureBox2.Image = Properties.Resources.sync_iconGif_backgroundColor_bule;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.RoyalBlue;

            MenuLabel1.ForeColor = Color.Black;
            MenuLabel2.ForeColor = Color.Black;
            MenuLabel3.ForeColor = Color.Beige;

            TabPanel.Visible = false;
            DisplaySyncPanel.Visible = false;
            ConfigurationPanel.Visible = true;
            if (SyncingFlag)
            {
                pictureBox2.Image = Properties.Resources.sync_iconGif_backgroundColor_white;
            }
        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MenuWindow = new Menu();
            MenuWindow.SetMainWindow(this);
            MenuWindow.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitBotton_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            this.Visible = false;
        }

        private void 終了xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskTrayFlag = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", Directory.GetCurrentDirectory() + @"\LogFile");

        }
   
        /// <summary>
        /// CurrentUserのRunにアプリケーションの実行ファイルパスを登録する
        /// </summary>
        private static void SetCurrentVersionRun()
        {
            //Runキーを開く
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true);
            //値の名前に製品名、値のデータに実行ファイルのパスを指定し、書き込む
            regkey.SetValue(Application.ProductName, Application.ExecutablePath);
            //閉じる
            regkey.Close();
        }

        private void FolderManagementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", DestPathName);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
           label4.ForeColor = SystemColors.Highlight;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ControlText;
        }
    }

    public class FileStatusStructure
    {
        public FileStatus Status { get; set; }
        public string SourcePath { get; set; }
        public string DestPath 　{ get; set; }

        public FileStatusStructure(FileStatus s, string sPath, string dPath)
        {
            Status = s;
            SourcePath = sPath;
            DestPath = dPath;
        }

    }

    public class Settings
    {
        #region プロパティ
        /// <summary>
        ///　スタートアップを行うか
        /// </summary>
        public bool StartOnBoot      { get; set; } = false;
        /// <summary>
        /// 通知を行うか
        /// </summary>
        public bool Notice           { get; set; } = true;
        /// <summary>
        /// 同期する時間
        /// </summary>
        public int  SyncInterval     { get; set; } = 6;
        /// <summary>
        /// 同期する時間を決定するか
        /// </summary>
        public bool SyncIntervalFlag { get; set; } = false;
        /// <summary>
        /// 設定ファイルを残すか
        /// </summary>
        public bool DrawLogFile      { get; set; } = true;
        /// <summary>
        /// トレイに格納するか
        /// </summary>
        public bool HousingTray      { get; set; } = true;
        #endregion

        /// <summary>
        /// 設定ファイルのエクスポートを行う
        /// </summary>
        /// <param name="conf">設定が格納されているクラス</param>
        public static void ExportSettingFile(Settings conf) 
        {
            //シリアライザーの作成
            XmlSerializer serializer = new XmlSerializer(typeof(Settings));
            //ファイルを開く
            string SavePath = Directory.GetCurrentDirectory() + @"\SettingFiles";
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(SavePath + @"\Settings.config", false, new UTF8Encoding(false)))
                {
                    serializer.Serialize(sw, conf);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        /// <summary>
        /// 設定ファイルのインポートを行う
        /// </summary>
        /// <returns>設定が格納されている Settings クラスを返す（インポートできなかった場合は初期化された Settings クラスを返す）</returns>
        public static Settings ImportSettingFile()
        {
            string SettingFilePath = Directory.GetCurrentDirectory() + @"\SettingFiles\Settings.config";
            if (!File.Exists(SettingFilePath))
            {
                return new Settings();
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (StreamReader sr = new StreamReader(SettingFilePath, new UTF8Encoding(false)))
                {
                    return (Settings)serializer.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

