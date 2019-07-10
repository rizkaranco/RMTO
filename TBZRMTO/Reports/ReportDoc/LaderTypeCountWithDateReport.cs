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
    /// Summary description for LaderTypeCountWithDateReport.
    /// </summary>
    public partial class LaderTypeCountWithDateReport : DataDynamics.ActiveReports.ActiveReport
    {

        public LaderTypeCountWithDateReport(string FromDate, string FromTime, string ToDate, string ToTime, String LaderTypeList_nvc)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmentFactory.SelectLaderTypeCountWithDateReport(FromDate, FromTime, ToDate, ToTime, LaderTypeList_nvc, ref LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = LadeAssignmentFactory.ServerJalaliDate;
                Timetxt.Text = LadeAssignmentFactory.ServerTime;
                if (LaderTypeReportTable != null && LaderTypeReportTable.Rows.Count > 0)
                {

                    LaderTypeReportTable.Columns.Add("RemainedPercent");
                    foreach (DataRow row in LaderTypeReportTable.Rows)
                    {
                        double RemainedPercent = (Convert.ToDouble(row["RemainderCar_int"]) * 100) / Convert.ToDouble(row["CarCount_int"]);

                        row["RemainedPercent"] = RemainedPercent.ToString("0.##"); //AllLadeAssignmentGroupCountxt
                    }
                 
                    LaderTypetxt.DataField = "LaderType_nvc";
                    LadeAssignmentCounttxt.DataField = "CarCount_int";
                    LadBillCounttxt.DataField = "LadBill";
                    Date_nvctxt.DataField = "LadeDate_nvc";
                    RemainderCounttxt.DataField = "RemainderCar_int";
                    RemainedCountPercenttxt.DataField = "RemainedPercent";
                    canceledByCompanytxt.DataField = "CanceledByCompany";
                    canceledByLadBillCanceledtxt.DataField = "CanceledByLadBillCanceled";
                    Int64? AllLadeAssignmentcount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();
                    AllLadeAssignmentCountxt.Text = AllLadeAssignmentcount.HasValue ? AllLadeAssignmentcount.ToString() : "0";

                    Int64? AllLadBillcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadBill"]).Sum();
                    AllLadBillCounttxt.Text = AllLadBillcountRecords.HasValue ? AllLadBillcountRecords.ToString() : "0";

                    Int64? Allremaindercount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["RemainderCar_int"]).Sum();
                    AllRemainderCounttxt.Text = Allremaindercount.HasValue ? Allremaindercount.ToString() : "0";

                    Int64? allcanceledByCompany = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CanceledByCompany"]).Sum();
                    allCanceledByCompanytxt.Text = allcanceledByCompany.HasValue ? allcanceledByCompany.ToString() : "0";

                    Int64? allcanceledByLadBillCanceled = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CanceledByLadBillCanceled"]).Sum();
                    allCanceledByLadBillCanceledtxt.Text = allcanceledByLadBillCanceled.HasValue ? allcanceledByLadBillCanceled.ToString() : "0";

                    AllRemainedPercenttxt.Text = ((Convert.ToDouble(AllRemainderCounttxt.Text)) * 100 / (Convert.ToDouble(AllLadeAssignmentCountxt.Text))).ToString("0.##");

                }
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

        private void groupFooter1_BeforePrint(object sender, EventArgs e)
        {
            AllRemainedGroupPercenttxt.Text = ((Convert.ToDouble(AllRemainderGroupCounttxt.Text)) * 100 / (Convert.ToDouble(AllLadeAssignmentGroupCountxt.Text))).ToString("0.##");

        }
    }
}
