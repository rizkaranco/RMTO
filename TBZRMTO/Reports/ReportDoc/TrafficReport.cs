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
    /// Summary description for TrafficReport.
    /// </summary>
    public partial class TrafficReport : DataDynamics.ActiveReports.ActiveReport
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
        public TrafficReport(HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


            this.TrafficEntityrpt = TrafficEntity;

            InDateTextBox.Text = TrafficEntityrpt.Date_nvc;
            InTimeTextBox.Text = TrafficEntityrpt.Time_nvc;

            //InDatetext2Box.Text = TrafficEntityrpt.Date_nvc;
            //InTimetext2Box.Text = TrafficEntityrpt.Time_nvc;
        
            TrafficNumbertxt.Text ="شماره قبض :   "+ TrafficEntityrpt.TrafficNumber_bint.ToString();
            //TrafficNumber2txt.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            //DriverName2txt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;

            if (TrafficEntityrpt.ServiceID_int == 2)
            {
                if (TrafficEntityrpt.TurnAccepted_bit == true)
                {
                    //نوبت تأیید شده داره
                    TurnNumbertxt.Text = "شماره نوبت :   " +Convert.ToString(TrafficEntityrpt.AcceptedTurnNumber_bint);
                    //AcceptedDate2TextBox.Text = TrafficEntityrpt.TurnDate_nvc;
                    //AcceptedTime2TextBox.Text = TrafficEntityrpt.TurnTime_nvc;
                    //TurnNumber2txt.Text = TrafficEntityrpt.AcceptedTurnNumber_bint.ToString();
             
                }
                else
                {
                    //نوبت تأیید شده ندارد
                    TurnNumbertxt.Text = "شماره نوبت رزرو :   " + Convert.ToString(TrafficEntityrpt.TurnNumber_bint);
                }
            }
            else
            {
                // (عدم نمایش نوبت (مراجعه به غیر از نوبت 
               
                TurnNumbertxt.Visible = false;
                TurnNumberAllerttxt.Visible = false;

            }

            //DriverCardNumber2txt.Text = "شماره كارت راننده :" + TrafficEntityrpt.DriverCardNumber_nvc;
            //CarCardNumber2txt.Text = "شماره كارت كاميون :" + TrafficEntityrpt.CarCardNumber_nvc;


            HPS.BLL.ServicesBLL.BLLServices_TFactory servicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            HPS.BLL.ServicesBLL.BLLServices_TKeys ServicesKey = new HPS.BLL.ServicesBLL.BLLServices_TKeys();
            ServicesKey.ServicesID_int = TrafficEntity.ServiceID_int;
            DateTextBox.Text = servicesFactory.ServerJalaliDate;
            TimeTextBox.Text = servicesFactory.ServerTime;
            HPS.BLL.ServicesBLL.BLLServices_T ServicesEntity = new HPS.BLL.ServicesBLL.BLLServices_T();
            ServicesEntity = servicesFactory.GetBy(ServicesKey);
            Servicestxt.Text = " قبض مراجعه به : " + ServicesEntity.ServicesType_nvc;
            DriverNametxt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntityrpt.LaderTypeID_int + "'";
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = laderTypeFactory.GetAllByCondition(LaderTypecondition);
            if (LaderTypeLst != null)
            {
                CarTypetxt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc;
                //CarType2txt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc; //+ "- کد:" + LaderTypeLst[0].LaderTypeID_int.ToString() ;

            }
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlatecityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Platecitykey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
            Platecitykey.PlateCityID_int = TrafficEntityrpt.PlateCityID_int;
            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
            PlateCityEntity = PlatecityFactory.GetBy(Platecitykey);
            if (PlateCityEntity != null)
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;
                //NumberPlate2txt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;
            }
            else
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
                //NumberPlate2txt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
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
                Pricetxt.Text = " مبلغ دریافتی هنگام ورود " + txt.Text + "  ريا ل می باشد";
            }

            HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1002;
            SettingEntity = settingsFactory.GetBy(SettingKey);
            if (TrafficEntityrpt.ServiceID_int == 2)
            {
                AllowableHourtxt.Text = SettingEntity.Value_nvc; //TrafficEntityrpt.AllowableHour_int.ToString();
            }
            else
            {
                AllowableHourtxt.Text = TrafficEntityrpt.AllowableHour_int.ToString();
            }
            txt.Text = TrafficEntityrpt.Fee_dec.ToString();
            Feetxt.Text = txt.Text;
            ExtraHourtxt.Text = TrafficEntityrpt.ExtraHour_int.ToString();
            //if (TrafficEntityrpt.WithFlat_bit==true)
            //{
            //txt.Text = TrafficEntityrpt.ExtraHourFee_dec.ToString();
            //}
            txt.Text = TrafficEntityrpt.ExtraHourFee_dec.ToString();
            ExtraHourFeetxt.Text = txt.Text;
            UserNametxt.Text = TrafficEntityrpt.UserName_nvc;
            TrafficNumberbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            if (TrafficEntityrpt.TurnHour_int != null)
            {
                TurnNumberAllerttxt.Text = " شماره نوبت شما رزرو می باشد لطفاً تا " + TrafficEntityrpt.TurnHour_int.ToString() + " ساعت نسبت به تأیید آن اقدام نمایید";
            }
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
