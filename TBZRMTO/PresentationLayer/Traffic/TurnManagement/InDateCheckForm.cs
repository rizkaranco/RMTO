using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.TurnManagement
{
    public partial class InDateCheckForm : Hepsa.Core.PL.BaseForm
    {
        public InDateCheckForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                  BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new BLL.SettingsBLL.BLLSetting_TKeys();
            BLL.SettingsBLL.BLLSetting_T SettingEntity = new BLL.SettingsBLL.BLLSetting_T();
            BLL.SettingsBLL.BLLSetting_TFactory SettingsFactory = new BLL.SettingsBLL.BLLSetting_TFactory();
            SettingKey.SettingID_int = 1009;
            SettingEntity.SettingID_int = 1009;
            SettingEntity.Value_nvc = FromDatefaDatePicker.Text;
            SettingEntity.Setting_nvc = "تاریخ شروع چک کردن داشتن نوبت فعال در ورود";
            SettingsFactory.Update(SettingEntity, SettingKey);
            this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void InDateCheckForm_Load(object sender, EventArgs e)
        {
            try
            {
                BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new BLL.SettingsBLL.BLLSetting_TKeys();
                BLL.SettingsBLL.BLLSetting_T SettingEntity = new BLL.SettingsBLL.BLLSetting_T();
                BLL.SettingsBLL.BLLSetting_TFactory SettingsFactory = new BLL.SettingsBLL.BLLSetting_TFactory();
                SettingKey.SettingID_int = 1009;
                SettingEntity = SettingsFactory.GetBy(SettingKey);
                 FromDatefaDatePicker.Text=SettingEntity.Value_nvc ;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

    }
}
