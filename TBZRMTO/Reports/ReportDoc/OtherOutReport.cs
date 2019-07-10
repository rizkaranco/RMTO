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
    /// Summary description for OtherOutReport.
    /// </summary>
    public partial class OtherOutReport : DataDynamics.ActiveReports.ActiveReport
    {

        public OtherOutReport(string FromDate, string ToDate, string FromTime, string ToTime, string FromTrafficNumber, string ToTrafficNumber)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TrafficDataTable = new DataTable();
            string Condition = string.Empty;
            //if (!(string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)) && (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)))
            //{
            //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2')  AND (T.Date_nvc>='" + FromDatetxt.Text + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.Time_nvc>='" + FromTime + "') AND (T.Time_nvc<='" + ToTime + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
            //}
            //if (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber) && !((string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber))))
            //{
            //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2')  AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.Time_nvc>='" + FromTime + "') AND (T.Time_nvc<='" + ToTime + "')";
            //}
            //else if (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime) || (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
            //{
            //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2')  AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "')";
            //}

            if (!(string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)) && (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)))
            {
                Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
            }
            else if (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime) && (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
            {
                Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "')";
            }
            else if (!(string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber))
            {
                Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc+ ' ' +T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "')";
            }

            else if (!((string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
            {
                Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc + ' ' + T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
            }
            TrafficFactory.GetAllByConditionAllTraffic(Condition, ref TrafficDataTable);
            this.DataSource = TrafficDataTable;
            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            TrafficNumbertxt.DataField = "TrafficNumber_bint";
            NumberPlateTextBox.DataField = "NumberPlate_nvc";
            PlateCitytxt.DataField = "PlateCityID_intPlateCity_nvc";
            SerialPlateTextBox.DataField = "SerialPlate_nvc";
            Pricetxt.DataField = "Price_dec";
            Usertxt.DataField = "UserName_nvc";
            AllPricetxt.DataField = "Price_dec";
            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;
        }
        private int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }
    }
}
