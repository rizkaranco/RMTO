using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SMS
{
    
    public partial class LogintoSmsSystemForm : Form
    {
        private Boolean _True_bit;
        public  Boolean True_bit
        {
            get
            {
                return this._True_bit;
            }
        }
        public LogintoSmsSystemForm()
        {
            InitializeComponent();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            String Pass = string.Empty;
            string UserName = string.Empty;
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            SettingKey.SettingID_int = 1005;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            UserName = SettingEntity.Value_nvc;
            SettingKey.SettingID_int = 1006;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            Pass = SettingEntity.Value_nvc;
            if (UserName_nvctextBox.Text == UserName && PasswordtextBox.Text == Pass)
            {
                this._True_bit = true;
                this.Close();
            }
            else
            {
                this._True_bit = false;
                Hepsa.Core.Common.MessageBox.ErrorMessage("نام کاربری و رمز عبور اشتباه می باشد");
            }
        }
    }
}
