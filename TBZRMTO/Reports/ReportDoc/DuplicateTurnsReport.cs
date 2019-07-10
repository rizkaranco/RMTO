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
    /// Summary description for DuplicateTurnsReport.
    /// </summary>
    public partial class DuplicateTurnsReport : DataDynamics.ActiveReports.ActiveReport
    {

        public DuplicateTurnsReport()
        {
            InitializeComponent();
            BLL.TrafficBLL.BLLTraffic_TFactory trafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable duplicateTurnDataTable = new DataTable();
            trafficFactory.DuplicateTurnsReport(duplicateTurnDataTable);
            this.DataSource=duplicateTurnDataTable;
            InDatetxt.DataField = "Date_nvc";
            TurnDatetxt.DataField = "TurnDate_nvc";
            LastNametxt.DataField = "LastName_nvc";
            FirstNametxt.DataField = "FirstName_nvc";
            NumberPlateTextBox.DataField = "NumberPlate_nvc";
            SerialPlateTextBox.DataField = "SerialPlate_nvc";
            TurnNumbertxt.DataField = "AcceptedTurnNumber_bint";
            SaveUserNametxt.DataField = "UserName_nvc";
            TurnUsertxt.DataField = "TurnUser_nvc";
            DateTextBox.Text = trafficFactory.ServerJalaliDate;
            TimeTextBox.Text = trafficFactory.ServerTime;
            UserNameTextBox.Text = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
        }

        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }
    }
}
