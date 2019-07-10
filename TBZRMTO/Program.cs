using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HPS.Present.Login;
using System.Reflection;
using System.Diagnostics;
using System.Threading;


namespace HPS.TBZRMTO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        //[STAThread]
        //static void Main()
        //{
        //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-IR");

            //    if (mutex.WaitOne(TimeSpan.Zero, true))
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);
            //        Application.Run(get());
            //        mutex.ReleaseMutex();
            //    }
            //    else
            //    {
            //        MessageBox.Show("only one instance at a time");
            //    }
            //}
            //private static Form get()
            //{
            //    if (new Login().ShowDialog() != DialogResult.OK)
            //    {
            //        Application.Exit();
            //        return null;
            //    }
            //    else
            //    {
            //        Hepsa.Core.Common.ApplicationInfo.MainForm = new Main();
            //        return new Main();
            //    }
            //}
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-IR");
            //Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Hepsa.Core.Common.ApplicationInfo.MainForm = new Main();
            Hepsa.Core.Common.ApplicationInfo.ProgramName = Hepsa.Core.Common.ApplicationInfo.MainForm.Text;

            HPS.Present.Login.Login frmLogin = new Login();
            if (frmLogin.ShowDialog() != DialogResult.OK)
                Application.Exit();
            else
                Application.Run(new Main());
        }
    }
}
