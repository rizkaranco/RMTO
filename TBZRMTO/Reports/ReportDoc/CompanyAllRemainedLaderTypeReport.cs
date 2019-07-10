using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Linq;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for CompanyAllRemainedLaderTypeReport.
    /// </summary>
    public partial class CompanyAllRemainedLaderTypeReport : DataDynamics.ActiveReports.ActiveReport
    {

        public CompanyAllRemainedLaderTypeReport(string FromDate, string FromTime, string ToDate, string ToTime, string LaderTypeList_nvc,string CompanyList_nvc, String  GoodIDlist, String DestinationCityIDList, String PortPlaceList)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmentFactory.SelectCompanyRemainedReport(FromDate, FromTime, ToDate, ToTime, LaderTypeList_nvc, CompanyList_nvc, GoodIDlist, DestinationCityIDList, PortPlaceList, LaderTypeReportTable);
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
                        double RemainedPercent = (Convert.ToDouble(row["RemainedCount_int"]) * 100) / Convert.ToDouble(row["CarCount_int"]);

                        row["RemainedPercent"] = RemainedPercent.ToString("0.##");
                    }
                 
                    LaderType_nvctxt.DataField = "LaderType_nvc";
                    Company_nvctxt.DataField = "Company_nvc";
                    LadeAssignmentCounttxt.DataField = "CarCount_int";
                    LadBillCounttxt.DataField = "LadBillCount_int";
                    RemainderCounttxt.DataField = "RemainedCount_int";
                    canceledByCompanytxt.DataField = "CanceledByCompany";
                    canceledByLadBillCanceledtxt.DataField = "CanceledByLadBillCanceled";
                    RemainedCountPercenttxt.DataField = "RemainedPercent";
                    Int64? AllLadeAssignmentcount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();
                    AllLadeAssignmentCountxt.Text = AllLadeAssignmentcount.HasValue ? AllLadeAssignmentcount.ToString() : "0";

                    Int64? AllLadBillcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadBillCount_int"]).Sum();
                    AllLadBillCounttxt.Text = AllLadBillcountRecords.HasValue ? AllLadBillcountRecords.ToString() : "0";

                    Int64? Allremaindercount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["RemainedCount_int"]).Sum();
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
