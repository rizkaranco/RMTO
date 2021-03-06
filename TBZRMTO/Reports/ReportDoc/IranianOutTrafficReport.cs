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
    /// Summary description for OutTrafficReport.
    /// </summary>
    public partial class IranianOutTrafficReport : DataDynamics.ActiveReports.ActiveReport
    {

        public IranianOutTrafficReport(string FromDate, string ToDate, string TrafficType, string FromTime, string ToTime, string FromTrafficNumber, string ToTrafficNumber, string PivotGroupID, string LaderTypeID, string ServicesID, string TurnAccepted)
        {
            InitializeComponent();
            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TrafficDataTable = new DataTable();


            TrafficFactory.SelectByFieldReportAllTraffic(FromDate + ' ' + FromTime, ToDate + ' ' + ToTime, FromTrafficNumber, ToTrafficNumber, PivotGroupID, LaderTypeID, TrafficType, "0", null, ServicesID, TurnAccepted, ref TrafficDataTable);
       
            this.DataSource=TrafficDataTable;
            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            TurnNumbertxt.DataField = "TurnNumber_bint";
            TrafficNumbertxt.DataField = "TrafficNumber_bint";
            NumberPlateTextBox.DataField = "NumberPlate_nvc";
            PlateCitytxt.DataField = "PlateCityID_intPlateCity_nvc";
            SerialPlateTextBox.DataField = "SerialPlate_nvc";
            CarCardNumbertxt.DataField = "CarCardNumber_nvc";
            DriverCardNumbertxt.DataField = "DriverCardNumber_nvc";
            Pricetxt.DataField = "Price_dec";
            Usertxt.DataField = "UserName_nvc";
            TrafficTypetxt.DataField = "InText";
           
            Services_nvctxt.DataField = "ServiceID_intServiceType_nvc";
          //  ExtraPricetxt.DataField = "extraprice";
            DataRow[] dr = null;
            dr = null;
            dr = TrafficDataTable.Select("WithLade_bit='True'");
            AllWithLadetxt.Text = (dr != null ? dr.Length.ToString() : "0");

            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;
            if (!string.IsNullOrEmpty(PivotGroupID))
            {
                if (Convert.ToInt16(PivotGroupID) == 1)
                {
                    PivotGrouptxt.Text = "دو محور";
                }
                else
                {
                    PivotGrouptxt.Text = "سه محور به بالا";
                }
            }
            PivotGrouptxt.Text = "تمام کاميون ها";

             if (!string.IsNullOrEmpty(LaderTypeID))
                {
                    PivotGrouptxt.Visible = false;
                    LaderTypeHeadertxt.Visible = true;
                    LaderTypeHeadertxt.DataField = "LaderTypeID_intLaderType_nvc";
                }

            decimal? AllCount =(from row in TrafficDataTable.AsEnumerable() select (decimal)row["Price_dec"]).Count();
            AllRecordstxt.Text = AllCount.HasValue ? AllCount.ToString() : "0";

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

        private void IranianOutTrafficReport_ReportStart(object sender, EventArgs e)
        {

        }
    }
}
