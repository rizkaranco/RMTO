using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for AvgAgeReport.
    /// </summary>
    public partial class AvgAgeReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AvgAgeReport(string FromDate, string FromTime, string ToDate, string ToTime)
        {
            InitializeComponent();
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                TrafficFactory.SelectAvgAgeReport(FromDate, FromTime, ToDate, ToTime, ref LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
                AgeAvgtextBox.DataField = "Average";

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
