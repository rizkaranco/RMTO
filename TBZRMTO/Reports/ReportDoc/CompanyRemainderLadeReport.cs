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
    /// Summary description for RemaindedLadesOfCompanies.
    /// </summary>
    public partial class CompanyRemainderLadeReport : DataDynamics.ActiveReports.ActiveReport
    {

        public CompanyRemainderLadeReport(string FromDate, string FromTime, string ToDate, string ToTime, String LaderTypeID, String CompanyID, string OrderColumns_nvc,bool JustRemained, String  GoodIDlist, String DestinationCityIDList, String PortPlaceList)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmenFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmenFactory.SelectCompanyLadeAssignmentDetail(FromDate, FromTime, ToDate, ToTime, LaderTypeID, CompanyID, GoodIDlist, DestinationCityIDList, PortPlaceList, OrderColumns_nvc, ref LaderTypeReportTable);
                LaderTypeReportTable.DefaultView.RowFilter = "RemainderCount_int <>0";
                DataTable dt = null;
                if (JustRemained)
                {
                    dt = LaderTypeReportTable.DefaultView.ToTable();
                }
                else
                {
                    dt = LaderTypeReportTable;
                }
                 
                this.DataSource = dt;
                dt.Columns.Add("RemainedPercent");
                foreach (DataRow row  in dt.Rows)
                {
                    double RemainedPercent = (Convert.ToDouble(row["RemainderCount_int"]) * 100) / (Convert.ToDouble(row["CarCount_int"]));
                    row["RemainedPercent"] = RemainedPercent.ToString("0.##");
                }
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
                LaderTypetxt.DataField = "LaderType_nvc";
                PortPlacetxt.DataField = "PortPlaces_nvc";
                PortageFeetxt.DataField = "PortageFee_dec";
                Commenttxt.DataField = "Comment_nvc";
                Remaindertxt.DataField = "RemainderCount_int";
                AllRequestTextBox.DataField = "CarCount_int";
                LadeDatetxt.DataField = "Date_nvc";
                RemainedPercenttxt.DataField = "RemainedPercent";
                CanceledByCompanytxt.DataField = "CanceledByCompany";
                CanceledByLadBillCanceledtxt.DataField = "CanceledByLadBillCanceled";

                decimal? AllPriceRecords = (from row in dt.AsEnumerable() select (decimal)row["PortageFee_dec"]).Sum();
                AllPricetxt.Text = AllPriceRecords.HasValue ? AllPriceRecords.ToString() : "0";


                Int64? AllRemainderCountRecords = (from row in dt.AsEnumerable() select (Int32)row["RemainderCount_int"]).Sum();
                AllRemainderCounttxt.Text = AllRemainderCountRecords.HasValue ? AllRemainderCountRecords.ToString() : "0";

                Int64? AllRequestCountRecords = (from row in dt.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();
                AllRequesttxt.Text = AllRequestCountRecords.HasValue ? AllRequestCountRecords.ToString() : "0";

                Int64? AllCanceledByCompany = (from row in dt.AsEnumerable() select (Int32)row["CanceledByCompany"]).Sum();
                AllCanceledByCompanytxt.Text = AllCanceledByCompany.HasValue ? AllCanceledByCompany.ToString() : "0";

                Int64? AllCanceledByLadBillCanceled = (from row in dt.AsEnumerable() select (Int32)row["CanceledByLadBillCanceled"]).Sum();
                AllCanceledByLadBillCanceledtxt.Text = AllCanceledByLadBillCanceled.HasValue ? AllCanceledByLadBillCanceled.ToString() : "0";

                AllPercentTxt.Text = (Convert.ToDouble(AllRemainderCounttxt.Text) * 100 / Convert.ToDouble(AllRequesttxt.Text)).ToString("0.##");
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        
        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }

        private void detail_Format(object sender, EventArgs e)
        {
            PortageFeetxt.Value = string.Format("{0:#,###}", PortageFeetxt.Value);
        }
        private void pageFooter_Format(object sender, EventArgs e)
        {
           
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AllPricetxt.Text) == false)
                AllPricetxt.Text = string.Format("{0:#,###}", decimal.Parse(AllPricetxt.Text));
        }
    }
}
