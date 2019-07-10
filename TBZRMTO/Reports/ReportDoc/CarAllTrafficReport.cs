using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for CarAllTrafficReport.
    /// </summary>
    public partial class CarAllTrafficReport : DataDynamics.ActiveReports.ActiveReport
    {

        public CarAllTrafficReport(string FromDate, string Todate, string NumberPlate, string SerialPlate, string CarCardNumber)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = Todate;
            CarCardNumbertxt.Text = CarCardNumber;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string TrafficCondition = string.Empty;

            if (!string.IsNullOrEmpty(NumberPlate) && !string.IsNullOrEmpty(SerialPlate))
            {
                TrafficCondition += string.Format(" T.NumberPlate_nvc='{0}' AND T.SerialPlate_nvc='{1}' ", NumberPlate, SerialPlate);

                if (!string.IsNullOrEmpty(CarCardNumber))
                {
                    TrafficCondition += string.Format(" AND T.CarCardNumber_nvc={0} ", CarCardNumber);
                }
            }
            else if (!string.IsNullOrEmpty(CarCardNumber))
                {
                    TrafficCondition += string.Format(" T.CarCardNumber_nvc={0} ", CarCardNumber);
                }

            if (!string.IsNullOrEmpty(FromDate) && !string.IsNullOrEmpty(Todate))
            {
                TrafficCondition += string.Format(" AND T.Date_nvc>='{0}' AND T.Date_nvc<='{1}' ", FromDate, Todate);
            }
            DataTable CarTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
            this.DataSource = CarTrafficDatatable;
            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;
           

            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            InTextTextBox.DataField = "InText";
            TurnNumbertxt.DataField = "TurnNumber_bint";
            TrafficNumbertxt.DataField = "TrafficNumber_bint";
            DriverCardNumbertxt.DataField = "DriverCardNumber_nvc";
            FullNameTextBox.DataField = "FullName_nvc";
            //FirstNameTextBox.DataField = "FirstName_nvc";
            //LastNameTextBox.DataField = "LastName_nvc";
            Pricetxt.DataField = "Price_dec";
            Usertxt.DataField = "UserName_nvc";
            PlateTypetxt.DataField = "PlateType_nvc";
            NumberPlateTextBox.Text = NumberPlate + "-";
            SerialPlateTextBox.Text = SerialPlate;
            AllPricetxt.DataField = "Price_dec";
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
