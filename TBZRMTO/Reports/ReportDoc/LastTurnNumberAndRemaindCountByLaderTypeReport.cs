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
    /// Summary description for LaderTypeReport.
    /// </summary>
    public partial class LastTurnNumberAndRemaindCountByLaderTypeReport : DataDynamics.ActiveReports.ActiveReport
    {

        public LastTurnNumberAndRemaindCountByLaderTypeReport(string FromDate, string ToDate)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
             try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                TrafficFactory.SelectRemainedLaderTypeCountReport(FromDate, ToDate, LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                ToDatetxt.Text = ToDate;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
                LaderType_nvctxt.DataField = "LaderType_nvc";
                Counttxt.DataField = "RemainedLaderTypeCount_int";
                LastTurnNumberWithLadBilltxt.DataField = "LastTurnNumberWithLadeBill_bint";
                CurrentAcceptedTurnNumbertxt.DataField = "CurrentAcceptedTurnNumber_bint";
                CurrentDatetxt.DataField = "CurrentDate_nvc";
                LadBillDatetxt.DataField = "LadBillDate_nvc";

                Int64? AllcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["RemainedLaderTypeCount_int"]).Sum();
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
