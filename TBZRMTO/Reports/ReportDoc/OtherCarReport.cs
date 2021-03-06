using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Collections.Generic;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for OtherCarReport.
    /// </summary>
    public partial class OtherCarReport : DataDynamics.ActiveReports.ActiveReport
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
        public OtherCarReport(HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


            DateTextBox.Text = TrafficEntityrpt.Date_nvc;
            TimeTextBox.Text = TrafficEntityrpt.Time_nvc;
            TrafficNumbertxt.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            Servicestxt.Text = " مراجعه به : " + TrafficEntityrpt.Services_nvc;
            CarTypetxt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc;
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlatecityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
            PlateCityKey.PlateCityID_int = TrafficEntityrpt.PlateCityID_int;
            PlatecityEntity = PlateCityFactory.GetBy(PlateCityKey);
            NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlatecityEntity.PlateCity_nvc+ " " + TrafficEntityrpt.SerialPlate_nvc;
            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            if (TrafficEntityrpt.BillMessageID_int == 0 || TrafficEntityrpt.BillMessageID_int == null)
            {

            }
            else
            {
                string Billcondition = "[BillMessage_T].[BillMessageID_int]=" + TrafficEntityrpt.BillMessageID_int;
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillLst = BillFactory.GetAllByCondition(Billcondition);
                if (BillLst != null)
                {
                    Messagetxt.Text = BillLst[0].Message_nvc;
                }
            }
            HamrahanSystem.TextBox.NumericTextBox txt = new HamrahanSystem.TextBox.NumericTextBox();
            txt.DigitsInGroup = 3;
            if (TrafficEntityrpt.Price_dec != null)
            {
                txt.Text = TrafficEntityrpt.Price_dec.ToString();
                Pricetxt.Text = " مبلغ دریافتی هنگام ورود " + txt.Text + "  ريال می باشد";
            }
            AllowableHourtxt.Text = TrafficEntityrpt.AllowableHour_int.ToString();          
            ExtraHourtxt.Text = TrafficEntityrpt.ExtraHour_int.ToString();
            txt.Text = TrafficEntityrpt.Fee_dec.ToString();
            Feetxt.Text = txt.Text;
            txt.Text = TrafficEntityrpt.ExtraHourFee_dec.ToString();
            ExtraHourFeetxt.Text = txt.Text;
            UserNametxt.Text = TrafficEntityrpt.UserName_nvc;
            TrafficNumberbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();

            if (TrafficEntityrpt.Printed_bit == true)
            {
                this.txtPrintedAgain.Visible = true;
            }
            else
            {
                this.txtPrintedAgain.Visible = false;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                try
                {
                    HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                    TrafficKey.TrafficID_bint = TrafficEntityrpt.TrafficID_bint;
                    TrafficEntityrpt.Printed_bit = true;
                    TrafficFactory.BeginProc();
                    TrafficFactory.Update(TrafficEntityrpt, TrafficKey);
                    TrafficFactory.CommitProc();
                }
                catch (Exception ex)
                {
                    TrafficFactory.RollBackProc();
                    throw ex;
                }
            }
        }

    }
}
