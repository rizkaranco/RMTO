using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class ViewerForm : Form
    {
        //private string _Type;
        //public string Type
        //{
        //    get { return _Type; }
        //    set { _Type = value; }
        //}

        //private Int32 _LadBIillCreditID;
        //public Int32 LadBIillCreditID
        //{
        //    get
        //    {
        //        return _LadBIillCreditID;
        //    }
        //    set
        //    {
        //        _LadBIillCreditID = value;
        //    }
        //}

        public ViewerForm(int again, int LadBIillCreditID)
        {
            InitializeComponent();

            ////////////////HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            ////////////////HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys LadBillKey = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
            ////////////////LadBillKey.LadBillCreditID_int = LadBillCreditID;
            ////////////////DataTable LadBillLadeAssignmentDataTable = new DataTable();
            ////////////////LadBillCreditFactory.GetAllLadeAssignment(LadBillKey, ref LadBillLadeAssignmentDataTable);
            ////////////////if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["DriverCardNumber_nvc"].ToString()))
            ////////////////{
            ////////////////    DriverCardNumebrtxt.Text = " کارت هوشمند راننده: " + LadBillLadeAssignmentDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();

            ////////////////}
            ////////////////else
            ////////////////{
            ////////////////    DriverCardNumebrtxt.Text = " کارت هوشمند راننده:فاقد كارت ";

            ////////////////}
            ////////////////if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString()))
            ////////////////{
            ////////////////    CarCardNumbertxt.Text = " کارت هوشمند کامیون : " + LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString();

            ////////////////}
            ////////////////else
            ////////////////{
            ////////////////    CarCardNumbertxt.Text = " کارت هوشمند کامیون :فاقد كارت ";

            ////////////////}

            ////////////////DriverMobileNumber_nvctxt.Text = string.Format("موبایل راننده: {0}", LadBillLadeAssignmentDataTable.Rows[0]["DriverMobileNumber_nvc"].ToString());
            ////////////////Companytxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["CompanyID_intCompany_nvc"].ToString() + "(" + LadBillLadeAssignmentDataTable.Rows[0]["CompanyCode_nvc"].ToString() + ")" + "(" + LadBillLadeAssignmentDataTable.Rows[0]["Phone_nvc"].ToString() + ")"; //Cmp_nvc
            ////////////////LaderTypetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LaderTypeID_intLaderType_nvc"].ToString();
            ////////////////Boxingtxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["BoxingID_intBoxingType_nvc"].ToString(); //LaderType
            ////////////////NumberPlatetxt.Text = Hepsa.Core.Common.PersentationController.CorrectNumberPlate(LadBillLadeAssignmentDataTable.Rows[0]["NumberPlate_nvc"].ToString()) + " - " + LadBillLadeAssignmentDataTable.Rows[0]["PlateCity_nvc"].ToString() + LadBillLadeAssignmentDataTable.Rows[0]["SerialPlate_nvc"].ToString(); //Plaque
            ////////////////DriverNametxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["DriverName"].ToString(); //Driver
            ////////////////LicenceNumbertxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["licenceNumber_int"].ToString(); //LicenceNumber
            ////////////////LicenceCitytxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LicenceCityID_intCity_nvc"].ToString(); //LicenceCity
            ////////////////Goodtxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["GoodID_intGood_nvc"].ToString(); //Good
            ////////////////LadingDatetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadingDate_nvc"].ToString(); //
            ////////////////Destinationtxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["CityID_intCity_nvc"].ToString() + "-" + LadBillLadeAssignmentDataTable.Rows[0]["Address_nvc"].ToString();
            ////////////////HamrahanSystem.NumericTextBox txt = new HamrahanSystem.NumericTextBox();
            ////////////////txt.DigitsInGroup = 3;
            ////////////////txt.Text = LadBillLadeAssignmentDataTable.Rows[0]["PortageFee_dec"].ToString();
            ////////////////PortageFeetxt.Text = txt.Text;
            ////////////////Commenttxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["AssignmentComment_nvc"].ToString();
            ////////////////Datetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillDate"].ToString();
            ////////////////Timetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillTime"].ToString();
            ////////////////TurnNumbertxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["AcceptedTurnNumber_bint"].ToString();
            ////////////////LadBillNumbertxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillCreditID_int"].ToString();
            ////////////////UserNametxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillUser"].ToString();
            ////////////////PortPlacetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["PortPlaceID_intPortPlaces_nvc"].ToString();
            ////////////////MinWeightTextBox.Text = "از وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MinWeight_dec"].ToString();
            ////////////////MaxWeightTextBox.Text = "تا وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MaxWeight_dec"].ToString();
            ////////////////TrafficNumberTextBox.Text = LadBillLadeAssignmentDataTable.Rows[0]["TrafficNumber_bint"].ToString();

            ////////////////HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessage_TFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            ////////////////List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessage_TList = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
            ////////////////string Condition = string.Format("TrafficType_T.TrafficTypeID_int=9 AND [BillMessage_T].StartDate_nvc<='{0}' AND [BillMessage_T].[EndDate_nvc]>='{0}' ", BillMessage_TFactory.ServerJalaliDate);
            ////////////////BillMessage_TList = BillMessage_TFactory.GetAllByCondition(Condition);
            ////////////////if (BillMessage_TList != null && BillMessage_TList.Count > 0)
            ////////////////{
            ////////////////    BillMessageTextBox.Text = BillMessage_TList[0].Message_nvc;
            ////////////////}
            ////////////////if (again != 1)
            ////////////////{
            ////////////////    if (LadBillLadeAssignmentDataTable.Rows[0]["LadeDate"].ToString().CompareTo(LadBillCreditFactory.ServerJalaliDate) < 0)
            ////////////////    {
            ////////////////        RemaintextBox.Visible = true;
            ////////////////    }
            ////////////////    else
            ////////////////        RemaintextBox.Visible = false;
            ////////////////}

            ////////////////AgainDatetxt.Text = LadBillCreditFactory.ServerJalaliDate;
            ////////////////AgainTimetxt.Text = LadBillCreditFactory.ServerTime;
            ////////////////if (again == 1)
            ////////////////{
            ////////////////    Againtxt.Visible = true;
            ////////////////    txtDate.Visible = true;
            ////////////////    AgainDatetxt.Visible = true;
            ////////////////    txtTime.Visible = true;
            ////////////////    AgainTimetxt.Visible = true;
            ////////////////    txtuser.Visible = true;
            ////////////////    AgainUsertxt.Visible = true;
            ////////////////    AgainUsertxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
            ////////////////}
            //HPS.Reports.ReportDoc.LadBillReport rpt = new HPS.Reports.ReportDoc.LadBillReport(LadBIillCreditID, again);
            //stiViewerControl1.Document = rpt.Document;
            //rpt.Document.Printer.PrinterName = string.Empty;
            //rpt.Document.Printer.PaperSize.Height = 14;
            //rpt.Document.Printer.PaperSize.Width = 17;

            //stiViewerControl1.Document.Printer.PrinterSettings.Copies = 3;
            //stiViewerControl1.Document = rpt.Document;
            //rpt.Run();
        }

        //private DataDynamics.ActiveReports.ActiveReport _Doc;
        //public ViewerForm(DataDynamics.ActiveReports.ActiveReport Doc)
        //{
        //    InitializeComponent();
        //    this._Doc = Doc;
        //}

        private string _type;
        //public ViewerForm(string fromDate_nvc, string toDate_nvc)
        //{
        //    InitializeComponent();

        //    HPS.Reports.ReportDoc.LadBillCreditReport rpt = new HPS.Reports.ReportDoc.LadBillCreditReport(fromDate_nvc, toDate_nvc, true);
        //    viewer1.Document = rpt.Document;
        //    rpt.Run();
        //}

        public ViewerForm(string type)
        {
            InitializeComponent();
            this._type = type;
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {

            switch (_type)
            {
                case "dublicateTurns":
                      BLL.TrafficBLL.BLLTraffic_TFactory trafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable duplicateTurnDataTable = new DataTable();
            trafficFactory.DuplicateTurnsReport(duplicateTurnDataTable);
            //duplicateTurnDataTable;
           
            //DateTextBox.Text = trafficFactory.ServerJalaliDate;
            //TimeTextBox.Text = trafficFactory.ServerTime;
            //UserNameTextBox.Text = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                    //HPS.Reports.ReportDoc.DuplicateTurnsReport rpt = new HPS.Reports.ReportDoc.DuplicateTurnsReport();
                    //stiViewerControl1.Document = rpt.Document;
                   
                    break;

            }

        }
    }
}
