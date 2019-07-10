using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
//using Microsoft.SqlServer.Management.Smo;
//using Microsoft.SqlServer.Management.Common;
using System.IO;
using Microsoft.Win32;
using System.Data.SqlClient;


namespace HPS.Present.Common
{
    public partial class BackUpForm : Hepsa.Core.PL.BaseForm
    {
        public BackUpForm()
        {
            InitializeComponent();
        }
       
        private void BackUpPathbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.CityBLL.BLLCity_TFactory Factory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string[] DateArr = Factory.ServerJalaliDate.Split(new char[] { '/' });
            string[] TimeArr = Factory.ServerTime.Split(new char[] { ':' });
            string DateTime = DateArr[0] + DateArr[1] + DateArr[2] + TimeArr[0] + TimeArr[1] + TimeArr[2];
            BackUpPathtextBox.Text = fbd.SelectedPath +"\\"+ DateTime + ".bak";
            if (string.IsNullOrEmpty(fbd.SelectedPath))
            {
                BackUpPathtextBox.Text = string.Empty;
            }
        }
        
        private void BackUpbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(BackUpPathtextBox.Text))
                {
                    throw new ApplicationException ("مسیر فایل خالی است");
                }
                else
                {
                    System.Threading.Thread th = new System.Threading.Thread(DoBackUp);
                    th.IsBackground = true;
                    th.Start();
                }
                BackUpbutton.Enabled = false;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
      
        private void DoBackUp()
        {
            try
            {
                HPS.BLL.Common.BackUp_TFactory BackUpFactory = new HPS.BLL.Common.BackUp_TFactory();
                BackUpFactory.BackUp(BackUpPathtextBox.Text);
                Hepsa.Core.Common.MessageBox.InformationMessage("پشتیبان گیری با موفقیت انجام شد");
                this.Close();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                BackUpbutton.Enabled = true;
            }

        }

        private void DoRestore()
        {
            try
            {
                string filename = string.Empty;
                HPS.BLL.Common.BackUp_TFactory BackUpFactory = new HPS.BLL.Common.BackUp_TFactory();


                if ((this.RestoreopenFileDialog.FileName != "") && (this.RestoreopenFileDialog.FileName != "RestoreopenFileDialog"))
                {
                    filename = RestoreopenFileDialog.FileName;
                    RestoreButton.Enabled = false;
                    BackUpFactory.Restore(filename);
                    Hepsa.Core.Common.MessageBox.InformationMessage("بازیابی با موفقیت انجام شد");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void enablebutton()
        {
            BackUpPathbutton.Enabled = true;
            BackUpbutton.Enabled = true;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            try
            {

                this.RestoreopenFileDialog.ShowDialog();
                HPS.Present.Common.LoadingMessage frm = new HPS.Present.Common.LoadingMessage();
                frm.Show();
                Application.DoEvents();  
                DoRestore();
                frm.Close();
               
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
