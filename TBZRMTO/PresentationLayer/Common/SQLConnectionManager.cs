using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace HPS.Present.SQL
{
    public partial class SQLConnectionManager : Hepsa.Core.PL.BaseForm
    {
        public enum enumCloseMode
        {
            CloseForm,
            EndProgram
        }

        private enumCloseMode _CloseMode;

        public SQLConnectionManager(enumCloseMode CloseMode)
        {
            InitializeComponent();
            this.EnglishControls.Add(UserNameTextBox.Name, this.UserNameTextBox);
            this.EnglishControls.Add(this.PasswordTextBox.Name, this.PasswordTextBox);
            this.EnglishControls.Add(this.DataBaseNameTextBox.Name, this.DataBaseNameTextBox);
            this.EnglishControls.Add(this.ServerNameTextBox.Name, this.ServerNameTextBox);
            this._CloseMode = CloseMode;
            if (this._CloseMode == enumCloseMode.EndProgram)
                this.CloseButton.Text = "خروج";
            this.DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ServerNameTextBox.Text) || string.IsNullOrEmpty(DataBaseNameTextBox.Text) || string.IsNullOrEmpty(UserNameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    throw new ApplicationException("مشخصات اتصال به پایگاه داده را وارد نمایید");
                }
                Hepsa.Core.Common.ConnectionString.UserName = this.UserNameTextBox.Text;
                Hepsa.Core.Common.ConnectionString.Password = this.PasswordTextBox.Text;
                Hepsa.Core.Common.ConnectionString.DataBase = this.DataBaseNameTextBox.Text;
                Hepsa.Core.Common.ConnectionString.Server = this.ServerNameTextBox.Text;

                //HPS.Properties.Settings setting = new HPS.Properties.Settings();
                //if (!string.IsNullOrEmpty(ServerNameTextBox.Text))
                //{
                //    setting.ServerName = ServerNameTextBox.Text;
                //}
                //if (!string.IsNullOrEmpty(UserNameTextBox.Text))
                //{
                //    setting.DataBaseUserName = UserNameTextBox.Text;
                //}
                //if (!string.IsNullOrEmpty(PasswordTextBox.Text))
                //{
                //    setting.DataBasePassword = PasswordTextBox.Text;
                //}
                //if (!string.IsNullOrEmpty(DataBaseNameTextBox.Text))
                //{
                //    setting.DataBaseName = DataBaseNameTextBox.Text;
                //}

                if (!string.IsNullOrEmpty(DataBaseNameTextBox.Text))
                {
                    Properties.Settings.Default.DataBaseName = DataBaseNameTextBox.Text;
                }

                Hepsa.Core.Common.ConnectionString.AuthenticationMode = Hepsa.Core.Common.ConnectionString.enmAuthenticationMode.SQLServerAuthentication;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void SQLConnectionManager_Load(object sender, EventArgs e)
        {
            this.UserNameTextBox.Text = Hepsa.Core.Common.ConnectionString.UserName;
            this.PasswordTextBox.Text = Hepsa.Core.Common.ConnectionString.Password;
            this.DataBaseNameTextBox.Text = Hepsa.Core.Common.ConnectionString.DataBase;
            this.ServerNameTextBox.Text = Hepsa.Core.Common.ConnectionString.Server;
            //if (Hepsa.Core.Common.ConnectionString.AuthenticationMode == Hepsa.Core.Common.ConnectionString.enmAuthenticationMode.SQLServerAuthentication)
            //    this.SQLServerAuthenticationRadioButton.Checked = true;
            //else
            //    this.WindowsAuthenticationRadioButton.Checked = true;
        }

        private void WindowsAuthenticationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.WindowsAuthenticationRadioButton.Checked == true)
            //{
            //    this.UserNameTextBox.Clear();
            //    this.PasswordTextBox.Clear();
            //    //this.UserNameTextBox.Enabled = false;
            //    //this.PasswordTextBox.Enabled = false;
            //    //this.UserNameLabel.Enabled = false;
            //    //this.PasswordLabel.Enabled = false;
            //}
            //else
            //{
            this.UserNameTextBox.Text = "sa";
            //this.PasswordTextBox.Text = "sa123";
            //this.UserNameTextBox.Enabled = true;
            //this.PasswordTextBox.Enabled = true;
            this.UserNameLabel.Enabled = true;
            this.PasswordLabel.Enabled = true;
            ////}
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            if (this._CloseMode == enumCloseMode.EndProgram)
                Environment.Exit(0);
            else
                this.Close();
        }

        private void SQLConnectionManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel && this._CloseMode == enumCloseMode.EndProgram)
                Environment.Exit(0);
        }

        private void Defaultbutton_Click(object sender, EventArgs e)
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
                        ServerNameTextBox.Text = slpitedParts[0];
                    }
                    if (!string.IsNullOrEmpty(slpitedParts[1]))
                    {
                        UserNameTextBox.Text = slpitedParts[1];
                    }
                    if (!string.IsNullOrEmpty(slpitedParts[2]))
                    {
                        PasswordTextBox.Text = slpitedParts[2];
                    }
                    if (!string.IsNullOrEmpty(slpitedParts[3]))
                    {
                        this.DataBaseNameTextBox.Text = slpitedParts[3];
                    }
                    //(string)Hepsa.Core.Common.PersentationController.GetEntityValue(ds.Tables["ConnectionString"].Rows[0]["DataBase"], TypeCode.String);
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CompanyIPDefaultButton_Click(object sender, EventArgs e)
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

                    if (!string.IsNullOrEmpty(slpitedParts[4]))
                    {
                        ServerNameTextBox.Text = slpitedParts[4];
                    }
                    if (!string.IsNullOrEmpty(slpitedParts[1]))
                    {
                        UserNameTextBox.Text = slpitedParts[1];
                    }
                    if (!string.IsNullOrEmpty(slpitedParts[2]))
                    {
                        PasswordTextBox.Text = slpitedParts[2];
                    }
                    if (!string.IsNullOrEmpty(slpitedParts[3]))
                    {
                        this.DataBaseNameTextBox.Text = slpitedParts[3];
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
