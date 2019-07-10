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
    /// Summary description for UserLadeDetailReport.
    /// </summary>
    public partial class UserLadeDetailReport : DataDynamics.ActiveReports.ActiveReport
    {

        public UserLadeDetailReport(string FromDate, string FromTime, string ToDate, string ToTime)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmentFactory.SelectLadeUserDetailReport(FromDate, FromTime, ToDate, ToTime, ref LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = LadeAssignmentFactory.ServerJalaliDate;
                Timetxt.Text = LadeAssignmentFactory.ServerTime;
                UserName_nvctxt.DataField = "UserName_nvc";
                LadeAssignmentCounttxt.DataField = "LadeAssignmentCount";
                LadBillCounttxt.DataField = "LadBillCount";
                CanceledLabillCounttxt.DataField = "LadeBillCancelCount";

                Int64? AllLadeAssignmentcount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadeAssignmentCount"]).Sum();
                AllLadeAssignmentCountxt.Text = AllLadeAssignmentcount.HasValue ? AllLadeAssignmentcount.ToString() : "0";

                Int64? AllLadBillcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadBillCount"]).Sum();
                AllLadBillCounttxt.Text = AllLadBillcountRecords.HasValue ? AllLadBillcountRecords.ToString() : "0";

                Int64? Allremaindercount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadeBillCancelCount"]).Sum();
                AllCanceledLadBillCounttxt.Text = Allremaindercount.HasValue ? Allremaindercount.ToString() : "0";
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }
    }
}
