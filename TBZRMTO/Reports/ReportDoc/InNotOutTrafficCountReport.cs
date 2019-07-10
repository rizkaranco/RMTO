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
    /// Summary description for InNotOutTrafficCountReport.
    /// </summary>
    public partial class InNotOutTrafficCountReport : DataDynamics.ActiveReports.ActiveReport
    {

        public InNotOutTrafficCountReport(int TrafficTypeID_int)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //FromDatetxt.Text = FromDate;
            //ToDatetxt.Text = ToDate;
            UserNameTextBox.Text = Common.CurrentUser.user.UserName_nvc;

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TrafficDataTable = new DataTable();
            TrafficFactory.SelectInNotOutCount(TrafficTypeID_int, TrafficDataTable);
            this.DataSource = TrafficDataTable;
            Datetxt.Text = TrafficFactory.ServerJalaliDate;
            Timetxt.Text = TrafficFactory.ServerTime;
            PlateNumber_nvctxt.DataField = "plateNumber_nvc";
            InCount_inttxt.DataField = "InCount_int";
            LastInDate_nvctxt.DataField = "LastInDate_nvc";
            ServiceType_nvctxt.DataField = "ServiceID_intServiceType_nvc";
        }

        int Row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = Row.ToString();
            Row++;
        }
    }
}
