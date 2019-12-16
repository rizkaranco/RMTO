using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

namespace HPS.Present.Login
{
    public partial class Login : Hepsa.Core.PL.BaseForm
    {
        public Login()
        {
            InitializeComponent();
        }

        HPS.BLL.BLLYear_T YearEntity=new BLL.BLLYear_T();

        private void Login_Load(object sender, EventArgs e)
        {
          
            string s = Hepsa.Core.Common.ApplicationInfo.MacAddress;

            if (string.IsNullOrEmpty(Hepsa.Core.Common.ConnectionString.ConnectionString  ))
            {
                HPS.Present.SQL.SQLConnectionManager sqlManager = new HPS.Present.SQL.SQLConnectionManager(HPS.Present.SQL.SQLConnectionManager.enumCloseMode.EndProgram);
                sqlManager.ShowDialog();
            }
            HPS.BLL.BLLYear_T year = null;
            Hepsa.Core.Common.ConnectionString.DataBase = Properties.Settings.Default.DataBaseName; 
            try
            {
                LoadFiscalYearCombo();
            }
            catch (Exception ex)
            {
                HPS.Present.SQL.SQLConnectionManager sqlManager = new HPS.Present.SQL.SQLConnectionManager(HPS.Present.SQL.SQLConnectionManager.enumCloseMode.EndProgram);
                sqlManager.ShowDialog();
                LoadFiscalYearCombo();
            }
            
            if (HPS.Common.CurrentUser.Year !=null)
            {
                YearEntity = HPS.Common.CurrentUser.Year;
                HPS.Common.CurrentUser.Year = null;
            }
            

            //while (true)
            //{
                HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                try
                {
                    HPS.BLL.VersionBLL.BLLVersion_TFactory VersionFactory = new HPS.BLL.VersionBLL.BLLVersion_TFactory();
                    string DBVersion_nvc = string.Empty;
                    VersionFactory.SelectLastOldVersion(out DBVersion_nvc);

                    string APPVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
                    APPVersion = APPVersion.Substring(0, APPVersion.Length - 2);
                    string[] splitedVersion = APPVersion.Split('.');
                    if (splitedVersion[1].Length == 1)
                    {
                        splitedVersion[1] = "0" + splitedVersion[1];
                    }
                    if (splitedVersion[2].Length == 1)
                    {
                        splitedVersion[2] = "0" + splitedVersion[2];
                    }
                    APPVersion = splitedVersion[0] + "/" + splitedVersion[1] + "/" + splitedVersion[2];
                    if (string.IsNullOrEmpty(DBVersion_nvc))
                    {
                        HPS.BLL.VersionBLL.BLLVersion_T VersionEntity = new HPS.BLL.VersionBLL.BLLVersion_T();
                        VersionEntity.Version_nvc = APPVersion;
                        VersionEntity.Date_nvc = VersionFactory.ServerJalaliDate;
                        VersionEntity.Time_nvc = VersionFactory.ServerTime;
                        VersionFactory.Insert(VersionEntity);
                    }
                    else
                    {
                    // \\172.24.129.5\exe\
                    // \\192.168.200.50\exe\
                    // 
                    if (DBVersion_nvc.CompareTo(APPVersion) > 0)
                    {
                        throw new ApplicationException("نسخه اجرایی شما قدیمی است لطفاً به روز رسانی نمایید");
                    }
                    else if (DBVersion_nvc.CompareTo(APPVersion) < 0)
                    {
                        HPS.BLL.VersionBLL.BLLVersion_T VersionEntity = new HPS.BLL.VersionBLL.BLLVersion_T();
                        VersionEntity.Version_nvc = APPVersion;
                        VersionEntity.Date_nvc = VersionFactory.ServerJalaliDate;
                        VersionEntity.Time_nvc = VersionFactory.ServerTime;
                        VersionFactory.Insert(VersionEntity);
                    }
                }
                if (YearEntity != null)
                    {
                        HPS.Common.CurrentUser.Year = YearEntity;
                    }
        //              If FiscalYearEntity IsNot Nothing Then
        //    HPS.Common.CurrentUser.FiscalYear = FiscalYearEntity
        //End If


                }
                catch (Exception ex)
                {
                    if (ex.Message == "The ConnectionString property has not been initialized.")
                    {
                        HPS.Present.SQL.SQLConnectionManager sqlManager = new HPS.Present.SQL.SQLConnectionManager(HPS.Present.SQL.SQLConnectionManager.enumCloseMode.EndProgram);
                        sqlManager.ShowDialog();
                    }
                    else
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                        Environment.Exit(0);
                    }
                }
                finally
                {
                   
                }
            //}
            try
            {
                //TINYLib.Tiny tinylock = new TINYLib.Tiny();
                ////tinylock.ServerIP = Hepsa.Core.Common.ConnectionString.Server;
                //tinylock.Initialize = true;
                //if (tinylock.TinyErrCode != 0)
                //{
                //    throw new ApplicationException("خطا در اتصال به قفل");
                //}
                //tinylock.UserPassWord = "98EA9D6A1DA3863459D326371E92688";
                //tinylock.ShowTinyInfo = true;
                //if (tinylock.TinyErrCode != 0)
                //    throw new ApplicationException("خطا در اتصال به قفل");
                //if (tinylock.SerialNumber != "2039-8806-1473")
                //    throw new ApplicationException("قفل مورد استفاده نامعتبر می باشد");
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                Environment.Exit(0);
            }
        }

        private void LoadFiscalYearCombo()
        {
            HPS.BLL.BLLYear_TFactory YearFactory = new HPS.BLL.BLLYear_TFactory();
            DataTable YearsDataTable = new DataTable();
            YearFactory.GetAll(ref YearsDataTable);
            YearComboBox.DataSource = YearsDataTable;
            YearComboBox.DisplayMember = HPS.BLL.BLLYear_T.Year_TField.Year_nvc.ToString();
            YearComboBox.ValueMember = HPS.BLL.BLLYear_T.Year_TField.YearID_int.ToString();
            YearComboBox.SelectedIndex = -1;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.FiscalYearID))
            {
                YearComboBox.SelectedValue = Properties.Settings.Default.FiscalYearID;
            }
            if (YearComboBox.SelectedValue != null)
            {
                ShowSetting();
            }
        }
        private bool CheckComputerRegistration(HPS.BLL.UserBLL.BLLUser_T user)
        {
            if (!((new HPS.BLL.SettingsBLL.BLLSetting_TFactory()).GetBy(new BLL.SettingsBLL.BLLSetting_TKeys(){ SettingID_int=1028}).Value_nvc=="1"))
            {
                return true;
            }
            HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
            //TODO: فیلد پاک شده بررسی نمیشد
            string ComputerCondition = "[Computer_T].[MacAddress_nvc]='" + Hepsa.Core.Common.ApplicationInfo.MacAddress + "' and [Computer_T].[Computer_nvc]='" + user.UserName_nvc + "' and [Computer_T].[active_bit]=1 and Deleted_bit=0";
            List<HPS.BLL.ComputerBLL.BLLComputer_T> ComputerList = ComputerFactory.GetAllByCondition(ComputerCondition);
            if (ComputerList != null && ComputerList.Count > 0)
            {
                return true;
            }
            return false;
        }
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                Hepsa.Core.BLL.BLLUserLogin_T UserLogin = new Hepsa.Core.BLL.BLLUserLogin_T();
                UserLogin.UserName_nvc = this.UserName_nvcTextBox.Text;
                UserLogin.Password_nvc = Hepsa.Core.Common.Security.MD5(this.Password_nvcTextBox.Text);
                HPS.BLL.UserBLL.BLLUser_T UserEntity = UserFactory.Login(UserLogin);
                var OnlineUserEntity = new HPS.BLL.OnlineUserBLL.BLLOnlineUser_T();
                var OnlineUserFactory = new HPS.BLL.OnlineUserBLL.BLLOnlineUser_TFactory();
                if (!CheckComputerRegistration(UserEntity))
                {
                    throw new ApplicationException("این کامپیوتر مجاز به استفاده از سیستم نمی باشد");
                }

                if (UserEntity != null)
                {
                    HPS.Common.CurrentUser.user = UserEntity;
                    if (Hepsa.Core.Common.ApplicationInfo.MainForm != null)
                    {
                        this.SaveSetting();
                        this.makeLog();
                        //--hp>

                        var onlineUsertable = new DataTable();
                        OnlineUserFactory.GetAllByCondition(string.Format("[OnlineUser_T].[UserName_nvc]='{0}' and LoginDate_vc='{1}' AND LogOutDate_vc IS NULL ", HPS.Common.CurrentUser.user.UserName_nvc, OnlineUserFactory.ServerJalaliDate), ref onlineUsertable);
                        if (onlineUsertable!= null && onlineUsertable.Rows.Count>1 && (UserEntity.MultiAccess_bit == false))
                        {
                            throw new ApplicationException("حساب کاربری شما در سیستم دیگر در حال استفاده می باشد ");
                        }
                        //--<hp
                        OnlineUserEntity.UserName_nvc = UserEntity.UserName_nvc;
                        OnlineUserEntity.LoginDate_vc = OnlineUserFactory.ServerJalaliDate;
                        OnlineUserEntity.LoginTime_vc = OnlineUserFactory.ServerTime;
                        OnlineUserEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                        OnlineUserFactory.Insert(OnlineUserEntity);
                        HPS.Common.CurrentUser.user.OnlineUserID_int = OnlineUserEntity.OnlineUserID_int;

                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void makeLog()
        {
            Hepsa.Core.BLL.BLLLog_TFactory logFatctory = new Hepsa.Core.BLL.BLLLog_TFactory();
            Hepsa.Core.BLL.BLLLog_T logEntity = new Hepsa.Core.BLL.BLLLog_T();
            Hepsa.Core.PL.BaseEntityParentForm BEPF = new Hepsa.Core.PL.BaseEntityParentForm();
            logEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
            logEntity.ActionID_int = 8;
            logEntity.Date_nvc = logFatctory.ServerJalaliDate;
            logEntity.Time_nvc = logFatctory.ServerTime;
            logEntity.MacAddress_nvc = HPS.Common.FrequentlyUsedData.MacAddress();
            logEntity.IPAddress_nvc = HPS.Common.FrequentlyUsedData.IpAddress();
            logEntity.Body_nvc = "<TR><TD> نام کاربری </TD><TD>" + UserName_nvcTextBox.Text + "</TD></TR>";
            if (RememberMeCheckBox.Checked)
            {
                logEntity.Body_nvc += "<TR><TD> مرا به خاطر بسپار </TD><TD>√</TD></TR>";
            }
            //if (RememberMyPasswordCheckBox.Checked)
            //{
            //    logEntity.Body_nvc += "<TR><TD> گذر واژه مرا به خاطر بسپار </TD><TD>√</TD></TR>";
            //}

            logEntity.FormText_nvc = this.Text;
            logFatctory.Insert(logEntity);
        }

        private void SaveSetting()
        {
            if (this.RememberMeCheckBox.Checked)
                Properties.Settings.Default.UserName = this.UserName_nvcTextBox.Text;
            else
                Properties.Settings.Default.UserName = string.Empty;
            if (this.RememberMyPasswordCheckBox.Checked)
                //Properties.Settings.Default.Password = this.Password_nvcTextBox.Text;
            //else
                Properties.Settings.Default.Password = string.Empty;
            Properties.Settings.Default.Save();
        }

        private void ShowSetting()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                this.UserName_nvcTextBox.Text = Properties.Settings.Default.UserName;
                this.RememberMeCheckBox.Checked = true;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                //this.Password_nvcTextBox.Text = Properties.Settings.Default.Password;
                //this.RememberMyPasswordCheckBox.Checked = true;
            }
           
            if (YearComboBox.SelectedValue!=null)
            {
                Hepsa.Core.Common.ConnectionString.DataBase = ((DataRowView)YearComboBox.SelectedItem).Row["Database_nvc"].ToString();
            }
            this.UserName_nvcTextBox_Leave(this.UserName_nvcTextBox, new EventArgs());

        }

        private void RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RememberMyPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RememberMyPasswordCheckBox.Checked)
            //    this.RememberMeCheckBox.Checked = true;
        }

        private void UserName_nvcTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                UserName_nvcTextBox.Text = UserName_nvcTextBox.Text.Replace("ی", "ي").Replace("ک", "ك");
                if (YearComboBox.SelectedValue!=null)
                {
                    BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                    BLL.UserBLL.BLLUser_TKeys UserKey = new HPS.BLL.UserBLL.BLLUser_TKeys();
                    UserKey.UserName_nvc = this.UserName_nvcTextBox.Text;
                    BLL.UserBLL.BLLUser_T UserEntity = UserFactory.GetBy(UserKey);
                    if (UserEntity != null)
                    {
                        if (UserEntity.Picture_img != null)
                        {
                            System.IO.MemoryStream MemoryStream = new System.IO.MemoryStream();
                            MemoryStream.Write(UserEntity.Picture_img, 0, UserEntity.Picture_img.Length - 1);
                            UserPictureBox.Image = System.Drawing.Image.FromStream(MemoryStream);
                        }

                    }
                    else
                    {
                        this.UserPictureBox.Image = Properties.Resources.Login;
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FiscalYearComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void YearComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (YearComboBox.SelectedValue!=null)
            {
                Hepsa.Core.Common.ConnectionString.DataBase = ((DataRowView)YearComboBox.SelectedItem).Row["Database_nvc"].ToString();
                //Hepsa.Core.Common.ConnectionString.DataBase = "TBZRMTODB97";

                Properties.Settings.Default.FiscalYearID = YearComboBox.SelectedValue.ToString();
            }
        }

        private void YearComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
