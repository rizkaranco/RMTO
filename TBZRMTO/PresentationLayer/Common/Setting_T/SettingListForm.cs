using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HPS.Present.Common.Setting_T
{
    public partial class SettingListForm : Hepsa.Core.PL.BaseListForm
    {
        public SettingListForm()
        {
            InitializeComponent();
            this.EnglishControls.Add(userNameTextBox.Name, this.userNameTextBox);
            this.EnglishControls.Add(this.passwordTextBox.Name, this.passwordTextBox);
            this.EnglishControls.Add(this.dataBaseNameTextBox.Name, this.dataBaseNameTextBox);
            this.EnglishControls.Add(this.serverNameTextBox.Name, this.serverNameTextBox);
        }

        private void SettingListForm_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }
        private void LoadSetting()
        {
            try
            {

                if (Hepsa.Core.Common.CurrentUser.User.UserName_nvc != "admin" && Hepsa.Core.Common.CurrentUser.User.UserName_nvc != "backup")
                {
                    if (tabControl1.TabPages.Count > 1)
                    {
                        tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                        tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                    }
                }
                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                DataTable SettingDataTable = new DataTable();
                SettingFactory.GetAllFormated(ref SettingDataTable);
                this.SettingDataGrid.AutoGenerateColumns = false;
                this.SettingDataGrid.DataSource = SettingDataTable;

            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                 if (SettingDataGrid.CurrentRow !=null )
                 {
                     HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey=new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                     SettingKey.SettingID_int = (Int32)SettingDataGrid.CurrentRow.Cells["colSettingID_int"].Value;
                     HPS.Present.Common.Setting_T.SettingEntityForm frm = new SettingEntityForm(SettingKey);
                     frm.ShowDialog();
                     this.RefreshButton.PerformClick();
                 }
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadSetting();
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void SettingDataGrid_DoubleClick(object sender, EventArgs e)
        {
            this.EditButton.PerformClick();
        }

         private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Common.EncryptUserPass Encrytion = new HPS.Common.EncryptUserPass();
                if (!string.IsNullOrEmpty(serverNameTextBox.Text) && !string.IsNullOrEmpty(userNameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text) && !string.IsNullOrEmpty(dataBaseNameTextBox.Text))
                {
                    string dataTosave = string.Format("{0}&{1}&{2}&{3}&{4}", serverNameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, dataBaseNameTextBox.Text,CompanyServerIPTextBox.Text);
                    using (Rijndael myRijndael = Rijndael.Create())
                    {
                        // Encrypt the string to an array of bytes.
                        byte[] encrypted = Encrytion.EncryptStringToBytes(dataTosave, myRijndael.Key, myRijndael.IV);
                        System.IO.FileStream stream = new System.IO.FileStream(String.Format("{0}\\DefaultSetting.xml", Application.StartupPath), System.IO.FileMode.Create, System.IO.FileAccess.Write);

                        stream.Write(encrypted, 0, encrypted.Length);
                        stream.Close();
                        //Hepsa.Core.Common.MessageBox.InformationMessage("ثبت شد");
                        this.Close();
                    }
                }
                else
                {
                    throw new ApplicationException("اطلاعات پایگاه داده خالی است");
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

         private void previouseSettingButton_Click(object sender, EventArgs e)
         {
             try
             {
                 FileInfo file = new System.IO.FileInfo(String.Format("{0}\\DefaultSetting.xml", Application.StartupPath));
                 if (file.Exists == false)
                 {
                     return;
                 }
                 else
                 {
                     HPS.Common.EncryptUserPass Encrytionclass = new HPS.Common.EncryptUserPass();
                     byte[] readFile = File.ReadAllBytes(String.Format("{0}\\DefaultSetting.xml", Application.StartupPath));

                     string readFromFile = string.Empty;
                     readFromFile = Encrytionclass.DecryptUserPassword(readFile);
                     string[] slpitedParts = null;
                     slpitedParts = readFromFile.Split('&');

                     if (!string.IsNullOrEmpty(slpitedParts[0]))
                     {
                         serverNameTextBox.Text = slpitedParts[0];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[1]))
                     {
                         userNameTextBox.Text = slpitedParts[1];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[2]))
                     {
                         passwordTextBox.Text = slpitedParts[2];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[3]))
                     {
                         this.dataBaseNameTextBox.Text = slpitedParts[3];
                     }
                    if (!string.IsNullOrEmpty(slpitedParts[4]))
                    {
                        this.CompanyServerIPTextBox.Text = slpitedParts[4];
                    }
                }
             }
             catch (Exception ex)
             {
                 Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
             }
         }

         private void smsSaveButton_Click(object sender, EventArgs e)
         {
             try
             {
                 if (!string.IsNullOrEmpty(serverNameTextBox.Text) && !string.IsNullOrEmpty(userNameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text) && !string.IsNullOrEmpty(dataBaseNameTextBox.Text) && !string.IsNullOrEmpty(smsUserNameTextBox.Text) && !string.IsNullOrEmpty(smsPasswordTextBox.Text) && !string.IsNullOrEmpty(smsNumberTextBox.Text))
                 {
                     HPS.Common.EncryptUserPass Encrytion = new HPS.Common.EncryptUserPass();
                     string dataTosave = string.Format("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}", serverNameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, dataBaseNameTextBox.Text, smsUserNameTextBox.Text, smsPasswordTextBox.Text, smsNumberTextBox.Text,receivesMessageTimeExpiredTextBox.Text);
                     using (Rijndael myRijndael = Rijndael.Create())
                     {
                         // Encrypt the string to an array of bytes.
                         byte[] encrypted = Encrytion.EncryptStringToBytes(dataTosave, myRijndael.Key, myRijndael.IV);
                         System.IO.FileStream stream = new System.IO.FileStream(String.Format("{0}\\smsDefaultSetting.xml", Application.StartupPath), System.IO.FileMode.Create, System.IO.FileAccess.Write);

                         stream.Write(encrypted, 0, encrypted.Length);
                         stream.Close();
                         //Hepsa.Core.Common.MessageBox.InformationMessage("ثبت شد");
                         this.Close();
                     }
                 }
                 else
                 {
                     throw new ApplicationException("اطلاعات پایگاه داده یا پیام کوتاه خالی است");
                 }
             }
             catch (Exception ex)
             {
                 Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
             }
         }

         private void smsShowSettingButton_Click(object sender, EventArgs e)
         {
             try
             {
                 FileInfo file = new System.IO.FileInfo(String.Format("{0}\\smsDefaultSetting.xml", Application.StartupPath));
                 if (file.Exists == false)
                 {
                     return;
                 }
                 else
                 {
                     HPS.Common.EncryptUserPass Encrytionclass = new HPS.Common.EncryptUserPass();
                     byte[] readFile = File.ReadAllBytes(String.Format("{0}\\smsDefaultSetting.xml", Application.StartupPath));

                     string readFromFile = string.Empty;
                     readFromFile = Encrytionclass.DecryptUserPassword(readFile);
                     string[] slpitedParts = null;
                     slpitedParts = readFromFile.Split('&');

                     if (!string.IsNullOrEmpty(slpitedParts[0]))
                     {
                         serverNameTextBox.Text = slpitedParts[0];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[1]))
                     {
                         userNameTextBox.Text = slpitedParts[1];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[2]))
                     {
                         passwordTextBox.Text = slpitedParts[2];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[3]))
                     {
                         this.dataBaseNameTextBox.Text = slpitedParts[3];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[4]))
                     {
                         this.smsUserNameTextBox.Text = slpitedParts[4];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[5]))
                     {
                         this.smsPasswordTextBox.Text = slpitedParts[5];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[6]))
                     {
                         this.smsNumberTextBox.Text = slpitedParts[6];
                     }
                     if (!string.IsNullOrEmpty(slpitedParts[7]))
                     {
                         this.receivesMessageTimeExpiredTextBox.Text = slpitedParts[7];
                     }
                     //(string)Hepsa.Core.Common.PersentationController.GetEntityValue(ds.Tables["ConnectionString"].Rows[0]["DataBase"], TypeCode.String);
                 }
             }
             catch (Exception ex)
             {
                 Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
             }
         }
    }
}
