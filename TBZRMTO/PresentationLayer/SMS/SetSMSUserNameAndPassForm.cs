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
    public partial class SetSMSUserNameAndPassForm : Form
    {
        public SetSMSUserNameAndPassForm()
        {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNametextBox.Text) || string.IsNullOrEmpty(PasstextBox.Text) )
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("لطفا نام کاربری و رمز عبور را وارد کنید");
                return;
            }
            else
            {

                
                
                //Password_nvc = Hepsa.Core.Common.Security.MD5(PasstextBox.Text);
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1005;
                SettingEntity=SettingFactory.GetBy(SettingKey);
                SettingEntity.Value_nvc = UserNametextBox.Text;
                SettingFactory.Update(SettingEntity, SettingKey);
               
                SettingKey.SettingID_int = 1006;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                SettingEntity.Value_nvc = PasstextBox.Text;
                SettingFactory.Update(SettingEntity, SettingKey);
               
                //SettingEntity.Value_nvc = Hepsa.Core.Common.Security.MD5(NewPasstextBox.Text);
                Hepsa.Core.Common.MessageBox.InformationMessage("رمز عبور جدید ثبت شد");
                this.Close();
                
            }
            

        }
    }
}
