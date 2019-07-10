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
    public partial class LastTurnNumberAndRemaindCountByLaderTypeForm : Hepsa.Core.PL.BaseForm
    {
        public LastTurnNumberAndRemaindCountByLaderTypeForm()
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
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);

                //HPS.Reports.ReportDoc.LastTurnNumberAndRemaindCountByLaderTypeReport report = new HPS.Reports.ReportDoc.LastTurnNumberAndRemaindCountByLaderTypeReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                //report.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = report.Document;
                //report.Run();
                LastTurnNumberAndRemaindCountByLaderTypeReport.Dictionary.Synchronize();
                LastTurnNumberAndRemaindCountByLaderTypeReport.Dictionary.Databases.Clear();
                LastTurnNumberAndRemaindCountByLaderTypeReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LastTurnNumberAndRemaindCountByLaderTypeReport.Compile();
                LastTurnNumberAndRemaindCountByLaderTypeReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                LastTurnNumberAndRemaindCountByLaderTypeReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                LastTurnNumberAndRemaindCountByLaderTypeReport["todate_vc"] = ToDatefaDatePicker.Text;
                LastTurnNumberAndRemaindCountByLaderTypeReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                LastTurnNumberAndRemaindCountByLaderTypeReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                LastTurnNumberAndRemaindCountByLaderTypeReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
                LastTurnNumberAndRemaindCountByLaderTypeReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;
                LastTurnNumberAndRemaindCountByLaderTypeReport.Render();
                this.stiViewerControl1.Report = LastTurnNumberAndRemaindCountByLaderTypeReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void LastTurnNumberAndRemaindCountByLaderTypeForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);

        }
    }
}
