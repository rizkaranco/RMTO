using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Common.Setting_T
{
    public partial class SettingEntityForm : Form
    {
        HPS.BLL.SettingsBLL.BLLSetting_TKeys _SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
        HPS.BLL.SettingsBLL.BLLSetting_T _SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
        HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactoy = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();

        public SettingEntityForm(HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey)
        {
            InitializeComponent();
            this._SettingKey = SettingKey;
        }

        private void SettingEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                _SettingEntity = SettingFactoy.GetBy(this._SettingKey);
                if (_SettingEntity != null)
                {
                    CreateFormInterface();
                    //Setting_nvclabel.Text = _SettingEntity.Setting_nvc;
                    //Value_nvctextBox.Text = _SettingEntity.Value_nvc;
                    //Point pnt = new Point(Setting_nvclabel.Location.X + 35 - Setting_nvclabel.Width, Setting_nvclabel.Location.Y);
                    //Setting_nvclabel.Location = pnt;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CreateFormInterface()

        { 
        _SettingEntity= SettingFactoy.GetBy(_SettingKey);
            try

            {
                if (_SettingEntity != null)
                {
                    if (_SettingEntity.Boolean_bit.HasValue && _SettingEntity.Boolean_bit.Value)
                        CreateCheckBox();

                    else if (_SettingEntity.Numeric_bit.HasValue && _SettingEntity.Numeric_bit.Value)
                        CreateNumericTextBox();
                    //else if (_SettingEntity.Shortcutkey_bit.HasValue && _SettingEntity.Shortcutkey_bit.Value)
                    //    CreateShortCut();
                    else if (_SettingEntity.Text_bit.HasValue && _SettingEntity.Text_bit.Value)
                            CreateTextBox();
                    }

            }
            catch (Exception ex)
            {

                throw ex;
            }
           

            }

        private void CreateNumericTextBox()
        {

            Label lbl = new Label()
            { Text = _SettingEntity.Setting_nvc
            , Top = 18
            , AutoSize = true
            };

            SettingGroupBox.Controls.Add(lbl);

            HamrahanSystem.TextBox.NumericTextBox txt = new HamrahanSystem.TextBox.NumericTextBox()
            {
                MaxLength = 9
            ,MaxWholeDigits = 19
            ,MaxDecimalPlaces = 9
            ,Text = _SettingEntity.Value_nvc
            ,Name = "TextBox" + _SettingEntity.SettingID_int
            ,Width = 150
            ,Top = 16
            ,Left = 6
            };
            SettingGroupBox.Controls.Add(txt);
            txt.TextChanged += new EventHandler(Numerictxt_TextChanged);

            this.Width = lbl.PreferredWidth + txt.Width + 30;
            lbl.Left = txt.Right;

        }

        private void Numerictxt_TextChanged(object sender, EventArgs e)
        {
            _SettingEntity.Value_nvc = ((TextBox)sender).Text;

        }

        private void CreateCheckBox()
        {
            CheckBox myCheckBox = new CheckBox() {  Text = _SettingEntity.Setting_nvc
            ,Name = "CheckBox" + _SettingEntity.SettingID_int
            ,AutoSize = true
            ,Top = 16
            ,Left = 10
            };
            SettingGroupBox.Controls.Add(myCheckBox);

            if (String.IsNullOrEmpty(_SettingEntity.Value_nvc) || Int32.Parse(_SettingEntity.Value_nvc) == 0)
                myCheckBox.Checked = false;
            else
                myCheckBox.Checked = true;
            myCheckBox.CheckedChanged += new EventHandler(CheckBox_CheckedChange);
            this.Width = myCheckBox.PreferredSize.Width + 30;
        }

        private void CheckBox_CheckedChange(object sender, EventArgs e)
        {
            _SettingEntity.Value_nvc = (((CheckBox)sender).Checked ? "1": "0");
        }

        private void CreateTextBox()
        {

            Label lbl = new Label();
            SettingGroupBox.Controls.Add(lbl);

            lbl.Text = _SettingEntity.Setting_nvc;
            lbl.Top = 18;
            lbl.AutoSize = true;


            TextBox txt = new TextBox()
            {
                Text = _SettingEntity.Value_nvc
                ,
                Name = "TextBox" + _SettingEntity.SettingID_int
                ,
                Width = _SettingEntity.Value_nvc.Length * 3 + 100
                ,
                Top = 16
                ,
                Left = 6
            };
            SettingGroupBox.Controls.Add(txt);
            txt.TextChanged += new EventHandler(txt_TextChanged);
            this.Width = lbl.PreferredWidth + txt.Width + 30;
            lbl.Left = txt.Right;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            _SettingEntity.Value_nvc = ((TextBox)sender).Text;
       
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SettingEntity.Text_bit.HasValue && _SettingEntity.Text_bit.Value)
                {

                }
                //_SettingEntity.Value_nvc = Value_nvctextBox.Text;
                SettingFactoy.BeginProc();
                SettingFactoy.Update(_SettingEntity, _SettingKey);
                SettingFactoy.CommitProc();
                this.Close();
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            

        }
        
    }
}
