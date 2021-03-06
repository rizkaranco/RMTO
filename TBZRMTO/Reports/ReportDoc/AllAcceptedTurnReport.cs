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
    /// Summary description for AllAcceptedTurnReport.
    /// </summary>
    public partial class AllAcceptedTurnReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AllAcceptedTurnReport(string FromDate, string ToDate,bool WithProductionYear)
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
                string Condition =string.Empty;
                if (WithProductionYear == true)
                {
                    Condition = "[T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1 AND (T1.TurnDate_nvc>='" + FromDatetxt.Text + "') AND (T1.TurnDate_nvc<='" + ToDate + "') AND T1.ProductionYear_int IS NOT NULL";
                }
                else
                {
                    Condition = "[T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1 AND (T1.TurnDate_nvc>='" + FromDatetxt.Text + "') AND (T1.TurnDate_nvc<='" + ToDate + "')";
                }
                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.SelectAcceptedTurns(TrafficDataTable, Condition);
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
                Usertxt.DataField = "UserName_nvc";
                FirstNametxt.DataField = "FirstName_nvc";
                LastNametxt.DataField = "LastName_nvc";
                TurnAcceptedchk.DataField = "TurnAccepted_bit";
                TurnAcceptedNumbertxt.DataField = "AcceptedTurnNumber_bint";
                TurnAcceptedDatetxt.DataField = "TurnDate_nvc";
                TurnAcceptedTimetxt.DataField = "TurnTime_nvc";
                LaderTypetxt.DataField = "LaderTypeID_intLaderType_nvc";
                DateTextBox.Text = TrafficFactory.ServerJalaliDate;
                TimeTextBox.Text = TrafficFactory.ServerTime;
                UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                PivotGrouptxt.Text = "تمامی کامیون ها";
                ProductionYeartxt.DataField = "ProductionYear_int";
                
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
