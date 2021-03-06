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
    /// Summary description for IranianInTrafficReport.
    /// </summary>
    public partial class IranianInTrafficReport : DataDynamics.ActiveReports.ActiveReport
    {

        public IranianInTrafficReport(string FromDate, string ToDate, string TrafficType, string FromTime, string ToTime, string FromTrafficNumber, string ToTrafficNumber, string PivotGroupID, string LaderTypeID,string ServicesID,string TurnAccepted)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
                 try
            {
                FromDatetxt.Text = FromDate;
                ToDatetxt.Text = ToDate;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficDataTable = new DataTable();
                string Condition=string.Empty;

                TrafficFactory.SelectByFieldReportAllTraffic(FromDate + ' ' + FromTime, ToDate + ' ' + ToTime, FromTrafficNumber, ToTrafficNumber, PivotGroupID, LaderTypeID, TrafficType,"1",null,ServicesID,TurnAccepted, ref TrafficDataTable);
               
                this.DataSource = TrafficDataTable;
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
                
                FirstNametxt.DataField = "FirstName_nvc";
                LastNametxt.DataField = "LastName_nvc";
                //TurnAcceptedchk.DataField = "TurnAccepted_bit";
                TurnAcceptedNumbertxt.DataField = "AcceptedTurnNumber_bint";
                TurnAcceptedDatetxt.DataField = "TurnDate_nvc";
                TurnAcceptedTimetxt.DataField = "TurnTime_nvc";
                WithLadeChkBox.DataField = "WithLade_bit";
                LaderTypetxt.DataField = "LaderTypeID_intLaderType_nvc";
                Services_nvctxt.DataField = "ServiceID_intServiceType_nvc";
                TurnUsertxt.DataField = "TurnUser_nvc";
                DateTextBox.Text = TrafficFactory.ServerJalaliDate;
                TimeTextBox.Text = TrafficFactory.ServerTime;
                UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;


                if (!string.IsNullOrEmpty(PivotGroupID))
                {
                    if (Convert.ToInt32(PivotGroupID) == 1)
                    {
                        PivotGrouptxt.Text = "دو محور";
                    }

                    else if (Convert.ToInt32(PivotGroupID) == 2)
                    {
                        PivotGrouptxt.Text = "سه محور به بالا";
                    }
                }

                else
                {
                    PivotGrouptxt.Text = "تمامی کامیون ها";
                }
                if (!string.IsNullOrEmpty(LaderTypeID))
                {
                    PivotGrouptxt.Visible = false;
                    LaderTypeHeadertxt.Visible = true;
                    LaderTypeHeadertxt.DataField = "LaderTypeID_intLaderType_nvc";
                }
                
                AllRecordstxt.Text = Rowtxt.ToString();

                DataRow[] dr = null;

                dr = TrafficDataTable.Select("TurnAccepted_bit = 'True'");
                this.AllAcceptedTurn.Text = (dr != null) ? dr.Length.ToString() : "0";

                dr = null;
                dr = TrafficDataTable.Select("TurnNumber_bint <> AcceptedTurnNumber_bint");
                this.AllAcceptedAfterTrueHour.Text = (dr != null ? dr.Length.ToString() : "0");
                dr = null;
                dr = TrafficDataTable.Select("CarCardNumber_nvc is Null Or CarCardNumber_nvc = ''");
                AllCarsWithoutCard.Text = (dr != null ? dr.Length.ToString() : "0");
                dr = null;
                dr = TrafficDataTable.Select("DriverCardNumber_nvc is Null Or DriverCardNumber_nvc = ''");
                AllDriverwithoutCard.Text = (dr != null ? dr.Length.ToString() : "0");
                dr = null;
                dr = TrafficDataTable.Select("WithLade_bit='True'");
                AllWithLadetxt.Text = (dr != null ? dr.Length.ToString() : "0");


                decimal? AllPrice = (from row in TrafficDataTable.AsEnumerable() select (decimal)row["Price_dec"]).Sum();
                AllPricetxt.Text = AllPrice.HasValue ? AllPrice.ToString() : "0";
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

       
        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;

        }
    }
}
