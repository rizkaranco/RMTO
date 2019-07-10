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
    /// Summary description for OtherInReport.
    /// </summary>
    public partial class OtherInReport : DataDynamics.ActiveReports.ActiveReport
    {
        int row = 1;
        public OtherInReport(string FromDate, string ToDate, string FromTime, string ToTime, string FromTrafficNumber, string ToTrafficNumber,string TrafficTypeID,string serviceID,string Turn)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TrafficDataTable = new DataTable();

            TrafficFactory.SelectByFieldReportAllTraffic(FromDate + ' ' + FromTime, ToDate + ' ' + ToTime, FromTrafficNumber, ToTrafficNumber, "", "", TrafficTypeID, "1", null, serviceID, Turn, ref TrafficDataTable);

            this.DataSource = TrafficDataTable;
            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            TrafficNumbertxt.DataField = "TrafficNumber_bint";
            NumberPlateTextBox.DataField = "NumberPlate_nvc";
            PlateCitytxt.DataField = "PlateCityID_intPlateCity_nvc";
            SerialPlateTextBox.DataField = "SerialPlate_nvc";
            Pricetxt.DataField = "Price_dec";
            Usertxt.DataField = "UserName_nvc";
           
            Services_nvctxt.DataField = "ServiceID_intServiceType_nvc";
            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;


            decimal? AllPrice = (from priceRow in TrafficDataTable.AsEnumerable() select (decimal?)priceRow["Price_dec"]).Sum();
            AllPricetxt.Text = AllPrice.HasValue ? AllPrice.ToString() : "0";

            decimal? Allcount = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Price_dec"]).Count();
            AllRecordstxt.Text = Allcount.HasValue ? Allcount.ToString() : "0";
            
        }
       
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }

        private void detail_Format(object sender, EventArgs e)
        {

        }
    }
}
