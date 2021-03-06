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
    /// Summary description for ForeignInNotOutReport.
    /// </summary>
    public partial class ForeignInNotOutReport : DataDynamics.ActiveReports.ActiveReport
    {

        public ForeignInNotOutReport(string FromDate, string ToDate, int TrafficType)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
           
            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TrafficDataTable = new DataTable();
            string Condition = "(T1.TrafficTypeID_int='2') AND (T1.Date_nvc>='" + FromDatetxt.Text + "') AND (T1.Date_nvc<='" + ToDate + "')";
            TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(Condition, ref TrafficDataTable);
            this.DataSource = TrafficDataTable;
            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            TrafficNumbertxt.DataField = "TrafficNumber_bint";
            NumberPlateTextBox.DataField = "NumberPlate_nvc";
            SerialPlateTextBox.DataField = "SerialPlate_nvc";
            Pricetxt.DataField = "Price_dec";
            Usertxt.DataField = "UserName_nvc";          
            FirstNametxt.DataField = "FirstName_nvc";
            LastNametxt.DataField = "LastName_nvc";
            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

            decimal? AllPrice = (from row in TrafficDataTable.AsEnumerable() select (decimal)row["Price_dec"]).Sum();
            AllPricetxt.Text = AllPrice.HasValue ? AllPrice.ToString() : "0";
        }
        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
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
