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
    /// Summary description for CompanyAllLadeAssignmented.
    /// </summary>
    public partial class CompanyAllLadeAssignmentedReport : DataDynamics.ActiveReports.ActiveReport
    {

        public CompanyAllLadeAssignmentedReport(string FromDate,string Todate,int CompanyID)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = Todate;
            DateTextBox.Text = LadeAssignmentFactory.ServerJalaliDate;
            TimeTextBox.Text = LadeAssignmentFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

            DataTable LadeAssignmentDataTable = new DataTable();
            string Condition = "LadeAssignment_T.Date_nvc>='" + FromDate + "' AND LadeAssignment_T.Date_nvc<='" + Todate + "' AND LadeAssignment_T.CompanyID_int='" + CompanyID + "'";
            LadeAssignmentFactory.GetAllByConditionReport(Condition, ref LadeAssignmentDataTable);
            this.DataSource = LadeAssignmentDataTable;
           
            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            LadingDatetxt.DataField = "LadingDate_nvc";
            Companytxt.DataField = "CompanyID_intCompany_nvc";
            CompanyCodetxt.DataField = "CompanyCode_nvc";
            Citytxt.DataField = "CityID_intCity_nvc";
            Goodtxt.DataField = "GoodID_intGood_nvc";
            Boxingtxt.DataField = "BoxingID_intBoxingType_nvc";
            PortageFeetxt.DataField = "PortageFee_dec";
            LaderTypetxt.DataField = "LaderTypeID_intLaderType_nvc";
            CarCounttxt.DataField = "CarCount_int";
            CanceledCarCounttxt.DataField = "CanceledCar";
            Canceledchk.DataField = "CanceledAssignment";
            PortPlacetxt.DataField = "PortPlaceID_intPortPlaces_nvc";
            //AllRecordstxt.Text = Rowtxt.ToString();

            Int64? CarCount = (from row in LadeAssignmentDataTable.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();
            AllCartxt.Text = CarCount.HasValue ? CarCount.ToString() : "0";

            Int64? CanceledCarCount = (from row in LadeAssignmentDataTable.AsEnumerable() select (Int32)row["CanceledCar"]).Sum();
            AllCancelCartxt.Text = CanceledCarCount.HasValue ? CanceledCarCount.ToString() : "0";

            Int64? AllPortageFee = (from row in LadeAssignmentDataTable.AsEnumerable() select Convert.ToInt64(row["PortageFee_dec"])).Sum();
            AllPortagefeetxt.Text = AllPortageFee.HasValue ? AllPortageFee.ToString() : "0";

            Int64? AllCanceledLadeAssignment = (from row in LadeAssignmentDataTable.AsEnumerable() where Convert.ToBoolean(row["CanceledAssignment"]) == true select row["CanceledAssignment"]).Count();
            AllCanceledLadeAssignmenttxt.Text = AllCanceledLadeAssignment.HasValue ? AllCanceledLadeAssignment.ToString() : "0";

            
        }

        public CompanyAllLadeAssignmentedReport(string FromDate, string Todate)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = Todate;
            DateTextBox.Text = LadeAssignmentFactory.ServerJalaliDate;
            TimeTextBox.Text = LadeAssignmentFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

            DataTable LadeAssignmentDataTable = new DataTable();
            string Condition = "LadeAssignment_T.Date_nvc>='" + FromDate + "' AND LadeAssignment_T.Date_nvc<='" + Todate + "'";
            LadeAssignmentFactory.GetAllByConditionReport(Condition, ref LadeAssignmentDataTable);
            this.DataSource = LadeAssignmentDataTable;

            Datetxt.DataField = "Date_nvc";
            Timetxt.DataField = "Time_nvc";
            LadingDatetxt.DataField = "LadingDate_nvc";
            Companytxt.DataField = "CompanyID_intCompany_nvc";
            CompanyCodetxt.DataField = "CompanyCode_nvc";
            Citytxt.DataField = "CityID_intCity_nvc";
            Goodtxt.DataField = "GoodID_intGood_nvc";
            Boxingtxt.DataField = "BoxingID_intBoxingType_nvc";
            PortageFeetxt.DataField = "PortageFee_dec";
            LaderTypetxt.DataField = "LaderTypeID_intLaderType_nvc";
            CarCounttxt.DataField = "CarCount_int";
            CanceledCarCounttxt.DataField = "CanceledCar";
            Canceledchk.DataField = "CanceledAssignment";
            PortPlacetxt.DataField = "PortPlaceID_intPortPlaces_nvc";
            CancelCommenttxt.DataField = "LadeCancelComment_nvc";
            
          //  AllRecordstxt.Text = Rowtxt.ToString();

            //Int64? AllRecords = (from row in LadeAssignmentDataTable.AsEnumerable() select (Int32)row["CarCount_int"]).Count();
            //AllRecordstxt.Text = AllRecords.HasValue ? AllRecords.ToString() : "0";

            Int64? CarCount = (from row in LadeAssignmentDataTable.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();
            AllCartxt.Text = CarCount.HasValue ? CarCount.ToString() : "0";

            Int64? CanceledCarCount = (from row in LadeAssignmentDataTable.AsEnumerable() select (Int32)row["CanceledCar"]).Sum();
            AllCancelCartxt.Text = CanceledCarCount.HasValue ? CanceledCarCount.ToString() : "0";

            Int64? AllPortageFee = (from row in LadeAssignmentDataTable.AsEnumerable() select Convert.ToInt64(row["PortageFee_dec"])).Sum();
            AllPortagefeetxt.Text = AllPortageFee.HasValue ? AllPortageFee.ToString() : "0";

            Int64? AllCanceledLadeAssignment = (from row in LadeAssignmentDataTable.AsEnumerable() where Convert.ToBoolean(row["CanceledAssignment"]) == true select row["CanceledAssignment"]).Count();
            AllCanceledLadeAssignmenttxt.Text = AllCanceledLadeAssignment.HasValue ? AllCanceledLadeAssignment.ToString() : "0";
        }
        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {

        }
    }
}
