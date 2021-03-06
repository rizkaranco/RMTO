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
    /// Summary description for IranianTrafficEditReport.
    /// </summary>
    public partial class IranianTrafficEditReport : DataDynamics.ActiveReports.ActiveReport
    {

        public IranianTrafficEditReport(HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = TrafficFactory.GetBy(TrafficKey);
            DateTextBox.Text = TrafficEntityrpt.Date_nvc;
            TimeTextBox.Text = TrafficEntityrpt.Time_nvc;
            TrafficNumbertxt.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            TurnNumbertxt.Text = TrafficEntityrpt.TurnNumber_bint.ToString();
            HPS.BLL.ServicesBLL.BLLServices_TFactory servicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            HPS.BLL.ServicesBLL.BLLServices_TKeys ServicesKey = new HPS.BLL.ServicesBLL.BLLServices_TKeys();
            ServicesKey.ServicesID_int = TrafficEntityrpt.ServiceID_int;
            HPS.BLL.ServicesBLL.BLLServices_T ServicesEntity = new HPS.BLL.ServicesBLL.BLLServices_T();
            ServicesEntity = servicesFactory.GetBy(ServicesKey);
            Servicestxt.Text = " مراجعه به : " + ServicesEntity.ServicesType_nvc;
            DriverNametxt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntityrpt.LaderTypeID_int + "'";
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = laderTypeFactory.GetAllByCondition(LaderTypecondition);
            if (LaderTypeLst != null)
            {
                CarTypetxt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc;
            }
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlatecityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Platecitykey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
            Platecitykey.PlateCityID_int = TrafficEntityrpt.PlateCityID_int;
            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
            PlateCityEntity = PlatecityFactory.GetBy(Platecitykey);
            if (PlateCityEntity != null)
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;

            }
            else
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;

            }
            if (TrafficEntityrpt.WithLade_bit == true)
            {
                WithLadetxt.Text = "وضعیت : " + "با بار" + "(" + TrafficEntityrpt.Comment_nvc + ") ";
            }
            else
            {
                WithLadetxt.Text = "وضعیت : " + "بدون بار";
            }
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
            //AllowableHourtxt.Text = TrafficEntityrpt.AllowableHour_int.ToString();
            //txt.Text = TrafficEntityrpt.Fee_dec.ToString();
            //Feetxt.Text = txt.Text;
            //ExtraHourtxt.Text = TrafficEntityrpt.ExtraHour_int.ToString();

           // txt.Text = TrafficEntityrpt.ExtraHourFee_dec.ToString();
            //ExtraHourFeetxt.Text = txt.Text;
            UserNametxt.Text = TrafficEntityrpt.UserName_nvc;
            TrafficNumberbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            if (TrafficEntityrpt.TurnAccepted_bit == false && TrafficEntityrpt.TurnHour_int != null)
            {
                TurnNumberAllerttxt.Text = " شماره نوبت شما رزرو می باشد لطفاً تا " + TrafficEntityrpt.TurnHour_int.ToString() + " ساعت نسبت به تأیید آن اقدام نمایید";
            }
        }
    }
}
