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
    /// Summary description for InServiceTypeWithPivoteReport.
    /// </summary>
    public partial class InServiceTypeWithPivoteReport : DataDynamics.ActiveReports.ActiveReport
    {

        public InServiceTypeWithPivoteReport(string FromDate, string FromTime, string ToDate, string ToTime)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                TrafficFactory.SelectAllInServiceTypeWithPivotReport(FromDate, FromTime, ToDate, ToTime,LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
                ServicesTypetxt.DataField = "TrafficType_nvc";
                CountWithLadetxt.DataField = "CountWithlade";
                Pivottxt.DataField = "LaderPivotGroup_nvc";
                // CountWithoutLadetxt.DataField = "Countwithoutlade";
                Pricetxt.DataField = "Price_dec";

                Int64? AllcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CountWithlade"]).Sum();
                AllCountwithLadetxt.Text = AllcountRecords.HasValue ? AllcountRecords.ToString() : "0";

                //Int64? AllcountWithoutLadeRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["Countwithoutlade"]).Sum();
                //AllCountWithoutLadetxt.Text = AllcountWithoutLadeRecords.HasValue ? AllcountWithoutLadeRecords.ToString() : "0";

                decimal? AllPriceRecords = (from row in LaderTypeReportTable.AsEnumerable() select (decimal)row["Price_dec"]).Sum();
                AllPricetxt.Text = AllPriceRecords.HasValue ? AllPriceRecords.ToString() : "0";
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void detail_Format(object sender, EventArgs e)
        {
            Pricetxt.Value = string.Format("{0:N0}", Pricetxt.Value);
        }

        int Row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = Row.ToString();
            Row++;
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AllPricetxt.Text) == false)
                AllPricetxt.Text = string.Format("{0:N0}", decimal.Parse(AllPricetxt.Text));
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AllPriceWithPivottxt.Text) == false)
                AllPriceWithPivottxt.Text = string.Format("{0:N0}", decimal.Parse(AllPriceWithPivottxt.Text));
        }
    }
}
