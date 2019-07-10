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
    /// Summary description for CompanyLadeAssignmentDetailReportForm.
    /// </summary>
    public partial class CompanyLadeAssignmentDetailReport : DataDynamics.ActiveReports.ActiveReport
    {

        public CompanyLadeAssignmentDetailReport(string FromDate, string FromTime, string ToDate, string ToTime, String  LaderTypeID, String  CompanyID, String  GoodIDlist, String DestinationCityIDList, String PortPlaceList)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
           
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmenFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmenFactory.SelectCompanyLadeAssignmentDetail(FromDate, FromTime, ToDate, ToTime,LaderTypeID,CompanyID,GoodIDlist,DestinationCityIDList,PortPlaceList,string.Empty, ref LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = LadeAssignmenFactory.ServerJalaliDate;
                Timetxt.Text = LadeAssignmenFactory.ServerTime;
                Companytxt.DataField = "Company_nvc";
                Goodtxt.DataField = "Good_nvc";
                Addresstxt.DataField = "Address_nvc";
                CarCounttxt.DataField = "CarCount_int";
                LaderTypetxt.DataField = "LaderType_nvc";
                PortPlacetxt.DataField = "PortPlaces_nvc";
                PortageFeetxt.DataField = "PortageFee_dec";
                Commenttxt.DataField = "Comment_nvc";
                LadBilltxt.DataField = "LadBillCount_int";
                Remaindertxt.DataField = "RemainderCount_int";

                Int64? AllcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();
                AllCounttxt.Text = AllcountRecords.HasValue ? AllcountRecords.ToString() : "0";

                decimal? AllPriceRecords = (from row in LaderTypeReportTable.AsEnumerable() select (decimal)row["PortageFee_dec"]).Sum();
                AllPricetxt.Text = AllPriceRecords.HasValue ? AllPriceRecords.ToString() : "0";

                Int64? AllLadBillRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadBillCount_int"]).Sum();
                AllLadBilltxt.Text = AllLadBillRecords.HasValue ? AllLadBillRecords.ToString() : "0";

                Int64? AllRemainderCountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["RemainderCount_int"]).Sum();
                AllRemainderCounttxt.Text = AllRemainderCountRecords.HasValue ? AllRemainderCountRecords.ToString() : "0";
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void detail_Format(object sender, EventArgs e)
        {
            PortageFeetxt.Value = string.Format("{0:#,###}", PortageFeetxt.Value);
        }
        private void pageFooter_Format(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AllPricetxt.Text) == false)
                AllPricetxt.Text = string.Format("{0:#,###}", decimal.Parse(AllPricetxt.Text));
        }

        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }
    }
}
