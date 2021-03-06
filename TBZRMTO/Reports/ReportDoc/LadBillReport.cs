using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Collections.Generic;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for LadBillReport.
    /// </summary>
    public partial class LadBillReport : DataDynamics.ActiveReports.ActiveReport
    {

        public LadBillReport(Int32 LadBillCreditID, int again)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys LadBillKey = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
            LadBillKey.LadBillCreditID_int = LadBillCreditID;
            DataTable LadBillLadeAssignmentDataTable = new DataTable();
            LadBillCreditFactory.GetAllLadeAssignment(LadBillKey, ref LadBillLadeAssignmentDataTable);
            if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["DriverCardNumber_nvc"].ToString()))
            {
                DriverCardNumebrtxt.Text = " کارت هوشمند راننده: " + LadBillLadeAssignmentDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();

            }
            else
            {
                DriverCardNumebrtxt.Text = " کارت هوشمند راننده:فاقد كارت ";

            }
            if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString()))
            {
                CarCardNumbertxt.Text = " کارت هوشمند کامیون : " + LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString();

            }
            else
            {
                CarCardNumbertxt.Text = " کارت هوشمند کامیون :فاقد كارت ";

            }

            DriverMobileNumber_nvctxt.Text = string.Format("موبایل راننده: {0}", LadBillLadeAssignmentDataTable.Rows[0]["DriverMobileNumber_nvc"].ToString());
            Companytxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["CompanyID_intCompany_nvc"].ToString() + "(" + LadBillLadeAssignmentDataTable.Rows[0]["CompanyCode_nvc"].ToString() + ")" + "(" + LadBillLadeAssignmentDataTable.Rows[0]["Phone_nvc"].ToString() + ")"; //Cmp_nvc
            LaderTypetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LaderTypeID_intLaderType_nvc"].ToString();
            Boxingtxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["BoxingID_intBoxingType_nvc"].ToString(); //LaderType
            NumberPlatetxt.Text = Hepsa.Core.Common.PersentationController.CorrectNumberPlate(LadBillLadeAssignmentDataTable.Rows[0]["NumberPlate_nvc"].ToString()) + " - " + LadBillLadeAssignmentDataTable.Rows[0]["PlateCity_nvc"].ToString() + LadBillLadeAssignmentDataTable.Rows[0]["SerialPlate_nvc"].ToString(); //Plaque
            DriverNametxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["DriverName"].ToString(); //Driver
            LicenceNumbertxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["licenceNumber_int"].ToString(); //LicenceNumber
            LicenceCitytxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LicenceCityID_intCity_nvc"].ToString(); //LicenceCity
            Goodtxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["GoodID_intGood_nvc"].ToString(); //Good
            LadingDatetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadingDate_nvc"].ToString(); //
            Destinationtxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["CityID_intCity_nvc"].ToString() + "-" + LadBillLadeAssignmentDataTable.Rows[0]["Address_nvc"].ToString();
            HamrahanSystem.TextBox.NumericTextBox txt = new HamrahanSystem.TextBox.NumericTextBox();
            txt.DigitsInGroup = 3;
            txt.Text = LadBillLadeAssignmentDataTable.Rows[0]["PortageFee_dec"].ToString();
            PortageFeetxt.Text = txt.Text;
            Commenttxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["AssignmentComment_nvc"].ToString();
            Datetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillDate"].ToString();
            Timetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillTime"].ToString();
            TurnNumbertxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["AcceptedTurnNumber_bint"].ToString();
            LadBillNumbertxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillCreditID_int"].ToString();
            UserNametxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["LadBillUser"].ToString();
            PortPlacetxt.Text = LadBillLadeAssignmentDataTable.Rows[0]["PortPlaceID_intPortPlaces_nvc"].ToString();
            MinWeightTextBox.Text = "از وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MinWeight_dec"].ToString();
            MaxWeightTextBox.Text = "تا وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MaxWeight_dec"].ToString();
            TrafficNumberTextBox.Text = LadBillLadeAssignmentDataTable.Rows[0]["TrafficNumber_bint"].ToString();

            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessage_TFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessage_TList = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
            string Condition = string.Format("TrafficType_T.TrafficTypeID_int=9 AND [BillMessage_T].StartDate_nvc<='{0}' AND [BillMessage_T].[EndDate_nvc]>='{0}' ", BillMessage_TFactory.ServerJalaliDate);
            BillMessage_TList = BillMessage_TFactory.GetAllByCondition(Condition);
            if (BillMessage_TList != null && BillMessage_TList.Count > 0)
            {
                BillMessageTextBox.Text = BillMessage_TList[0].Message_nvc;
            }
            if (again != 1)
            {
                if (LadBillLadeAssignmentDataTable.Rows[0]["LadeDate"].ToString().CompareTo(LadBillCreditFactory.ServerJalaliDate) < 0)
                {
                    RemaintextBox.Visible = true;
                }
                else
                    RemaintextBox.Visible = false;
            }

            AgainDatetxt.Text = LadBillCreditFactory.ServerJalaliDate;
            AgainTimetxt.Text = LadBillCreditFactory.ServerTime;
            if (again == 1)
            {
                Againtxt.Visible = true;
                txtDate.Visible = true;
                AgainDatetxt.Visible = true;
                txtTime.Visible = true;
                AgainTimetxt.Visible = true;
                txtuser.Visible = true;
                AgainUsertxt.Visible = true;
                AgainUsertxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
            }
        }

    }
}
