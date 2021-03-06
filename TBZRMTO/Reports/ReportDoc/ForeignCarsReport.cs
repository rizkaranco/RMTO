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
    /// Summary description for ForeignCarsReport.
    /// </summary>
    public partial class ForeignCarsReport : DataDynamics.ActiveReports.ActiveReport
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
        public ForeignCarsReport(HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.TrafficEntityrpt = TrafficEntity;

            DateTextBox.Text = TrafficEntityrpt.Date_nvc;
            TimeTextBox.Text = TrafficEntityrpt.Time_nvc;
            TrafficNumbertxt.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            DriverNametxt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntityrpt.LaderTypeID_int + "'";
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = laderTypeFactory.GetAllByCondition(LaderTypecondition);
            if (LaderTypeLst != null)
            {
                CarTypetxt.Text = "نوع وسيله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc;
            }
            if (!string.IsNullOrEmpty(TrafficEntityrpt.SerialPlate_nvc))
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
            }
            else
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc);
            }
           
            if (TrafficEntityrpt.WithLade_bit == true)
            {
                WithLadetxt.Text = "وضعیت : " + "با بار" + "(" + TrafficEntityrpt.Comment_nvc + ") ";
            }
            else
            {
                WithLadetxt.Text = "وضعیت : " + "بدون بار";
            }
            HamrahanSystem.TextBox.NumericTextBox txt = new HamrahanSystem.TextBox.NumericTextBox();
            txt.DigitsInGroup = 3;
            if (TrafficEntityrpt.Price_dec != null)
            {
                txt.Text = TrafficEntityrpt.Price_dec.ToString();
                Pricetxt.Text = " مبلغ دریافتی هنگام ورود " + txt.Text +"  ريال می باشد";
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
