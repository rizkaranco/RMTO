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
    /// Summary description for LadBillCreditReport.
    /// </summary>
    public partial class LadBillCreditReport : DataDynamics.ActiveReports.ActiveReport
    {

        public LadBillCreditReport(string FromDate, string ToDate, bool productionYear)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            string condition = string.Empty;
            if (productionYear == true)
            {
                condition = "LadBillCredit_T.Date_nvc>='" + FromDate + "' AND LadBillCredit_T.Date_nvc<='" + ToDate + "' AND Traffic_T.ProductionYear_int IS NOT NULL AND Canceled_bit=0";
            }
            else
            {
                condition = "LadBillCredit_T.Date_nvc>='" + FromDate + "' AND LadBillCredit_T.Date_nvc<='" + ToDate + "'";
            }

            DataTable LadBillCreditDataTable = new DataTable();
            LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
            Fillfields(LadBillCreditDataTable);
            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;
            DateTextBox.Text = LadBillFactory.ServerJalaliDate;
            TimeTextBox.Text = LadBillFactory.ServerTime;
        }

        public LadBillCreditReport(string FromDate, string ToDate,string CompanyList,string LaderTypeList,string OrderColumns,string NumberPlate_nvc,string SerialPlate_nvc,string CarCardNumber_nvc,string DriverCardNumber_nvc)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            string condition = string.Empty;
            condition = "LadBillCredit_T.Date_nvc>='" + FromDate + "' AND LadBillCredit_T.Date_nvc<='" + ToDate + "' AND Canceled_bit=0 ";
            if (!string.IsNullOrEmpty(CompanyList))
            {
                condition += " AND LadeAssignment_T.CompanyID_int IN ( " + CompanyList+" ) " ;
            }
            if (!string.IsNullOrEmpty(LaderTypeList))
            {
                condition += " AND Traffic_T.LaderTypeID_int IN ( " + LaderTypeList+ " ) ";
            }
            if (!string.IsNullOrEmpty(NumberPlate_nvc)&& (!string.IsNullOrEmpty(SerialPlate_nvc)))
            {
                condition += " AND Traffic_T.NumberPlate_nvc = '" + NumberPlate_nvc + "'  AND Traffic_T.SerialPlate_nvc ="+ SerialPlate_nvc ;
            }
            if (!string.IsNullOrEmpty(CarCardNumber_nvc ))
            {
                condition += " AND Traffic_T.CarCardNumber_nvc = " + CarCardNumber_nvc ;
            }
             if (!string.IsNullOrEmpty(DriverCardNumber_nvc ))
            {
                condition += " AND Traffic_T.DriverCardNumber_nvc = " + DriverCardNumber_nvc ;
            }
            if (!string.IsNullOrEmpty(OrderColumns))
            {
                condition += " ORDER BY " + OrderColumns;
            }
            else
            {
                condition += " ORDER BY LadBillCreditID_int ";
            }
            DataTable LadBillCreditDataTable = new DataTable();
            LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
            Fillfields(LadBillCreditDataTable);
            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;
            DateTextBox.Text = LadBillFactory.ServerJalaliDate;
            TimeTextBox.Text = LadBillFactory.ServerTime;
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {

        }
        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;          
        }


        private void Fillfields(DataTable LadBillCreditDataTable)
        {
            if (LadBillCreditDataTable != null && LadBillCreditDataTable.Rows.Count > 0)
            {
                LadBillCreditDataTable.Columns.Add("WaitingDay");
                foreach (DataRow row in LadBillCreditDataTable.Rows)
                {
                    Hepsa.Core.Common.MyDateTime TurnDate = new Hepsa.Core.Common.MyDateTime(row["TurnDate_nvc"].ToString());
                    string GeorgianTurnDate = TurnDate.MyDate.ToString("yyyy/MM/dd");// +" " + row["TurnTime_nvc"].ToString();
                    DateTime TurnDateTime = DateTime.Parse(GeorgianTurnDate);


                    Hepsa.Core.Common.MyDateTime LadBillDate = new Hepsa.Core.Common.MyDateTime(row["LadBillDate_nvc"].ToString());
                    string GeorgianLadBillDate = LadBillDate.MyDate.ToString("yyyy/MM/dd");// +" " + row["LadBillTime_nvc"].ToString();
                    DateTime LadBillDateTime = DateTime.Parse(GeorgianLadBillDate);

                    TimeSpan WaitindDayTimeSpan = LadBillDateTime.Subtract(TurnDateTime);
                    int WaitindDay = WaitindDayTimeSpan.Days;
                 
                    row["WaitingDay"] = WaitindDay;
                }
                this.DataSource = LadBillCreditDataTable;
                this.LadBillCreditDatetxt.DataField = "LadBillDate_nvc";
                LadBillCreditTimetxt.DataField = "LadBillTime_nvc";
                LadBillNumbertxt.DataField = "LadBillCreditID_int";
                TurnNumbertxt.DataField = "AcceptedTurnNumber_bint";
                LaderTypetxt.DataField = "LaderTypeID_intLaderType_nvc";
                CarNumbertxt.DataField = "NumberPlate";
                CarCardNumbertxt.DataField = "CarCardNumber_nvc";
                DriverCardNumbertxt.DataField = "DriverCardNumber_nvc";
                Companytxt.DataField = "CompanyID_intCompany_nvc";
                Goodtxt.DataField = "GoodID_intGood_nvc";
                PortPlacetxt.DataField = "PortPlaceID_intPortPlaces_nvc";
                Citytxt.DataField = "CityID_intCity_nvc";
                Commenttxt.DataField = "Comment_nvc";
                Usertxt.DataField = "LBUser";
                Pricetxt.DataField = "PortageFee_dec";
                TurnDatetxt.DataField = "TurnDate_nvc";
                TurnHourtxt.DataField = "TurnTime_nvc";
                DriverNametxt.DataField = "DriverName";
                WaitingDaytxt.DataField = "WaitingDay";
                
                UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

                Int64? AllRequestCountRecords = LadBillCreditDataTable.Rows.Count;
                AllCounttextBox.Text = AllRequestCountRecords.HasValue ? AllRequestCountRecords.ToString() : "0";

            }
        }
    }
}
