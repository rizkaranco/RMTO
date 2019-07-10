using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{

    public partial class CanceledTurnsReportForm : Hepsa.Core.PL.BaseListForm
    {
        public CanceledTurnsReportForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, false, false, this.CanceledTurnsGridView);
            TrafficGroup.ExportButton = this.ExportToExcelStripButton;
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);
        }

        private void AllInReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.BillBLL.BLLBill_TFactory Factory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            //  ToTimeTextBox.Text = Factory.ServerTime.ToString();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
        }



        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)))
                {
                    throw new ApplicationException("تا ساعت خالی است");
                }
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);

                Hepsa.Core.Validation.TimeRule<string> FromTimeValidator = new Hepsa.Core.Validation.TimeRule<string>("FromTime", "از ساعت", null, null);
                if (FromTimeValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)) == false)
                {
                    throw new ApplicationException(FromTimeValidator.Description);
                }

                Hepsa.Core.Validation.TimeRule<string> ToTimeValidator = new Hepsa.Core.Validation.TimeRule<string>("ToTime", "تا ساعت", null, null);
                if (ToTimeValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)) == false)
                {
                    throw new ApplicationException(ToTimeValidator.Description);
                }

                DataTable CanceledTurnsTable = new DataTable();
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new BLL.TrafficBLL.BLLTraffic_TFactory();
                TrafficFactory.SelectCanceledTurns(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, FromTimeTextBox.Text, ToTimeTextBox.Text, CanceledTurnsTable);
                CanceledTurnsGridView.DataSource = CanceledTurnsTable;

               
                //AllCanceledTurnstiReport.Show();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromTimetxt_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToTimetxt_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.BillBLL.BLLBill_TFactory Factory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void DefaulCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (DefaulCheckBox.Checked)
                {
                    TimeGroupBox.Enabled = true;
                    RefreshHourbutton.PerformClick();
                }
                else
                {
                    TimeGroupBox.Enabled = false;
                    FromTimeTextBox.Text = "00:00:00";
                    ToTimeTextBox.Text = "23:59:59";
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintCanceledButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = string.Empty;
                AllCanceledTurnstiReport.Dictionary.Synchronize();
                AllCanceledTurnstiReport.Dictionary.Databases.Clear();
                AllCanceledTurnstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                AllCanceledTurnstiReport.Compile();
                AllCanceledTurnstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                AllCanceledTurnstiReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
                AllCanceledTurnstiReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;
                AllCanceledTurnstiReport["@FromTime_nvc"] = FromTimeTextBox.Text;
                AllCanceledTurnstiReport["@ToTime_nvc"] = ToTimeTextBox.Text;
                AllCanceledTurnstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                AllCanceledTurnstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                AllCanceledTurnstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                AllCanceledTurnstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;

                AllCanceledTurnstiReport.Render();
                AllCanceledTurnstiReport.Show();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
