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
    public partial class InServiceTypeWithPivoteReportForm :Hepsa.Core.PL.BaseForm
    {
        public InServiceTypeWithPivoteReportForm()
        {
            InitializeComponent();
           
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
                //HPS.Reports.ReportDoc.InServiceTypeWithPivoteReport rpt = new HPS.Reports.ReportDoc.InServiceTypeWithPivoteReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run();
                
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                InServiceTypeWithPivotestiReport.Dictionary.Synchronize();
                InServiceTypeWithPivotestiReport.Dictionary.Databases.Clear();
               InServiceTypeWithPivotestiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                InServiceTypeWithPivotestiReport.Compile();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                InServiceTypeWithPivotestiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                InServiceTypeWithPivotestiReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
                InServiceTypeWithPivotestiReport["@FromTime_nvc"] = FromTimeTextBox.Text;
                InServiceTypeWithPivotestiReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;
                InServiceTypeWithPivotestiReport["@ToTime_nvc"] = ToTimeTextBox.Text;
                InServiceTypeWithPivotestiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                InServiceTypeWithPivotestiReport["todate_vc"] = ToDatefaDatePicker.Text;
                InServiceTypeWithPivotestiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                InServiceTypeWithPivotestiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                InServiceTypeWithPivotestiReport["FromTime_vc"] = FromTimeTextBox.Text;
                InServiceTypeWithPivotestiReport["ToTime_vc"] = ToTimeTextBox.Text;
                InServiceTypeWithPivotestiReport.Render();
                this.stiViewerControl1.Report = InServiceTypeWithPivotestiReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
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

        private void FromTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void InServiceTypeWithPivoteReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
        }
    }
}
