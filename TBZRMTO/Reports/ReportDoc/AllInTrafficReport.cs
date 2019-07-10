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
    public partial class AllInTrafficReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AllInTrafficReport(string FromDate,string FromTime,string ToDate,string ToTime)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
             try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                TrafficFactory.SelectAllInTrafficReport(FromDate, FromTime, ToDate, ToTime, ref LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
                Cartxt.DataField = "LaderType_nvc";
                Counttxt.DataField = "Count_int";
                CountPercenttxt.DataField = "CountPercent";
                Pricetxt.DataField = "Price_dec";
                PricePercenttxt.DataField = "PricePercent";
                Int64? AllcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["Count_int"]).Sum();
                AllCounttxt.Text = AllcountRecords.HasValue ? AllcountRecords.ToString() : "0";

                decimal? AllPriceRecords = (from row in LaderTypeReportTable.AsEnumerable() select (decimal)row["Price_dec"]).Sum();
                AllPricetxt.Text = AllPriceRecords.HasValue ? AllPriceRecords.ToString() : "0";
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

        private void detail_Format(object sender, EventArgs e)
        {
            Pricetxt.Value = string.Format("{0:#,###}", Pricetxt.Value);
        }
        private void pageFooter_Format(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AllPricetxt.Text) == false)
                AllPricetxt.Text = string.Format("{0:#,###}", decimal.Parse(AllPricetxt.Text));
        }
    }
}
