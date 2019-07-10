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
    public partial class AcceptedTurnWithoutLadBillCreditDevidedByLaderTypeAndDateForm : Form
    {
        public AcceptedTurnWithoutLadBillCreditDevidedByLaderTypeAndDateForm()
        {
            InitializeComponent();
        }

        private void AcceptedTurnWithoutLadBillCreditDevidedByLaderTypeAndDateForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.BillBLL.BLLBill_TFactory Factory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate.ToString());
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate.ToString());
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }

                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)))
                {
                    throw new ApplicationException("تا ساعت خالی است");
                }

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

                //HPS.Reports.ReportDoc.AcceptedTurnNumberRemainedByLaderTypeCountWithDateReport report = new HPS.Reports.ReportDoc.AcceptedTurnNumberRemainedByLaderTypeCountWithDateReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, FromTimeTextBox.Text, ToTimeTextBox.Text);
                //report.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = report.Document;
                //report.Run();
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport.Dictionary.Synchronize();
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport.Dictionary.Databases.Clear();
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport.Compile();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["todate_vc"] = ToDatefaDatePicker.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["fromtime_vc"] = FromTimeTextBox.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["totime_vc"] = ToTimeTextBox.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["@FromTime_nvc"] = FromTimeTextBox.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport["@Totime_nvc"] = ToTimeTextBox.Text;
                AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport.Render();
                this.stiViewerControl1.Report = AcceptedTurnNumberRemainedByLaderTypeCountWithDateStiReport;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }
        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
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
    }
}
