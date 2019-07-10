using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Linq;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for LaderTypeRemainedAcceptedTurnNumberCountWithDateReport.
    /// </summary>
    public partial class AcceptedTurnNumberRemainedByLaderTypeCountWithDateReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AcceptedTurnNumberRemainedByLaderTypeCountWithDateReport(string FromDate,string FromTime,string ToTime, string ToDate)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                TrafficFactory.SelectRemainedAcceptedTurnNumberByLaderTypeWithDateReport(FromDate, ToDate,FromTime,ToTime, LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                ToDatetxt.Text = ToDate;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
                LaderType_nvctxt.DataField = "LaderType_nvc";
                Counttxt.DataField = "RemainedCount_int";
                Date_nvctxt.DataField = "Date_nvc";
                Int64? AllcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int64)row["RemainedCount_int"]).Sum();
                AllCounttxt.Text = AllcountRecords.HasValue ? AllcountRecords.ToString() : "0";


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        int Row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = Row.ToString();
            Row++;
        }
    }
}
