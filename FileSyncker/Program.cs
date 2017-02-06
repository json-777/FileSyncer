using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSyncker
{
    static class Program
    {

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string SyncSelectPath = "";
            string SyncPath = "";
                      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string SavePath = Directory.GetCurrentDirectory() + @"\SaveFile";
            string buff;
            bool flag = false;
            if (Directory.Exists(SavePath))
            {
                if (File.Exists(SavePath + @"\DirectoryConf.csv"))
                {
                    using (StreamReader sr = new StreamReader(SavePath + @"\DirectoryConf.csv"))
                    {
                        string s = "";
                        if ((s = sr.ReadLine()) != null)
                        {
                            if (Directory.Exists(s))
                            {
                                buff = s;
                                if ((s = sr.ReadLine()) != null)
                                {
                                    if (Directory.Exists(s))
                                    {
                                        SyncSelectPath = s;
                                        SyncPath = buff;
                                        flag = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (flag)
            {
                Application.Run(new Form2(SyncPath, SyncSelectPath));
            }
            else
            {
                Application.Run(new Menu());
            }
        }
    }
}
