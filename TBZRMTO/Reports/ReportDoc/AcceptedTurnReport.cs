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
    /// Summary description for AcceptedTurnReport.
    /// </summary>
    public partial class AcceptedTurnReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AcceptedTurnReport(Int64 TrafficID_bint)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            TrafficKey.TrafficID_bint = TrafficID_bint;
            TrafficEntityrpt = TrafficFactory.GetBy(TrafficKey);

            AcceptedDateTextBox.Text = TrafficEntityrpt.TurnDate_nvc;
            
            AcceptedTimeTextBox.Text = TrafficEntityrpt.TurnTime_nvc;

            InDateTextBox.Text = TrafficEntityrpt.Date_nvc;

            InTimeTextBox.Text = TrafficEntityrpt.Time_nvc;

            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;

            InDatetext2Box.Text = TrafficEntityrpt.Date_nvc;
            InTimetext2Box.Text = TrafficEntityrpt.Time_nvc;

            if (TrafficEntityrpt.AcceptedTurnNumber_bint.HasValue)
            {
                TurnNumber2txt.Text = "شماره نوبت : " + TrafficEntityrpt.AcceptedTurnNumber_bint.ToString();
                TurnNumbertxt.Text = "شماره نوبت : " + TrafficEntityrpt.AcceptedTurnNumber_bint.ToString();
            }
            else
            {
                TurnNumber2txt.Text = "شماره نوبت رزرو : " + TrafficEntityrpt.TurnNumber_bint.ToString();
                TurnNumbertxt.Text = "شماره نوبت رزرو : " + TrafficEntityrpt.TurnNumber_bint.ToString();
            }

            TrafficNumbertxt.Text = "شماره قبض : " + TrafficEntityrpt.TrafficNumber_bint.ToString();
            TrafficNumber2txt.Text = "شماره قبض : " + TrafficEntityrpt.TrafficNumber_bint.ToString();

            DriverNametxt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;
            DriverName2txt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;

            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntityrpt.LaderTypeID_int + "'";
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = laderTypeFactory.GetAllByCondition(LaderTypecondition);
            if (LaderTypeLst != null)
            {
                CarTypetxt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc; //+ "- کد:" + LaderTypeLst[0].LaderTypeID_int.ToString() ;
                CarType2txt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc;
            }
             HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlatecityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Platecitykey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
            Platecitykey.PlateCityID_int = TrafficEntityrpt.PlateCityID_int;
            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
            PlateCityEntity = PlatecityFactory.GetBy(Platecitykey);

            if (PlateCityEntity != null)
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;
                NumberPlate2txt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;
            }
            else
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
                NumberPlate2txt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
            }
           
            DriverCardNumbertxt.Text ="شماره كارت راننده :" +TrafficEntityrpt.DriverCardNumber_nvc;
            
            CarCardNumbertxt.Text = "شماره كارت كاميون :" + TrafficEntityrpt.CarCardNumber_nvc;
           
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
                Pricetxt.Text = " مبلغ دریافت شده هنگام ورود " + txt.Text + "  ريال می باشد";
            }
            UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
            if (!string.IsNullOrEmpty(TrafficEntityrpt.AcceptedTurnComment_nvc))
            {
                if (TrafficEntityrpt.Area_bit)
                {
                    Commenttxt.Text = "توضيحات : " + TrafficEntityrpt.AcceptedTurnComment_nvc + " حومه";
                }
                else
                {
                    Commenttxt.Text = "توضيحات : " + TrafficEntityrpt.AcceptedTurnComment_nvc;
                }
            }
            else
            {
                if (TrafficEntityrpt.Area_bit)
                {
                    Commenttxt.Text = "حومه";
                }
            }
            TrafficNumberbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            TrafficNumber_intbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            if (!TrafficEntityrpt.DriverOffline_bit)
            {
                OfflineReadtxt.Text = "آنلاین";
            }
            else
            {
                OfflineReadtxt.Text = "آفلاین";
            }
            //////////////
            if (TrafficEntityrpt.TurnPrinted_bit == true)
            {
                this.txtPrintedAgain.Visible = true;
            }
            else
            {
                this.txtPrintedAgain.Visible = false;
                try
                {                
                    TrafficKey.TrafficID_bint = TrafficEntityrpt.TrafficID_bint;
                    TrafficEntityrpt.TurnPrinted_bit = true;
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

        public AcceptedTurnReport(HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
            //HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            //TrafficKey.TrafficID_bint = TrafficID_bint;
            //TrafficEntityrpt = TrafficFactory.GetBy(TrafficKey);

            AcceptedDateTextBox.Text = TrafficEntityrpt.TurnDate_nvc;

            AcceptedTimeTextBox.Text = TrafficEntityrpt.TurnTime_nvc;

            InDateTextBox.Text = TrafficEntityrpt.Date_nvc;
            InTimeTextBox.Text = TrafficEntityrpt.Time_nvc;
            
            InDatetext2Box.Text = TrafficEntityrpt.Date_nvc;
            InTimetext2Box.Text = TrafficEntityrpt.Time_nvc;
            
            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;

            if (TrafficEntityrpt.AcceptedTurnNumber_bint.HasValue)
            {
                TurnNumber2txt.Text = "شماره نوبت : " + TrafficEntityrpt.AcceptedTurnNumber_bint.ToString();
                TurnNumbertxt.Text = "شماره نوبت : " + TrafficEntityrpt.AcceptedTurnNumber_bint.ToString();
            }
            else
            {
                TurnNumber2txt.Text = "شماره نوبت رزرو : " + TrafficEntityrpt.TurnNumber_bint.ToString();
                TurnNumbertxt.Text = "شماره نوبت رزرو : " + TrafficEntityrpt.TurnNumber_bint.ToString();
            }
            

            TrafficNumbertxt.Text = "شماره قبض : " + TrafficEntityrpt.TrafficNumber_bint.ToString();
            TrafficNumber2txt.Text = "شماره قبض : " + TrafficEntityrpt.TrafficNumber_bint.ToString();

            DriverNametxt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;
            DriverName2txt.Text = " نام راننده : " + TrafficEntityrpt.FirstName_nvc + " " + TrafficEntityrpt.LastName_nvc;

            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntityrpt.LaderTypeID_int + "'";
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = laderTypeFactory.GetAllByCondition(LaderTypecondition);
            if (LaderTypeLst != null)
            {
                CarTypetxt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc; //+ "- کد:" + LaderTypeLst[0].LaderTypeID_int.ToString() ;
                CarType2txt.Text = "نوع وسیله : " + TrafficEntityrpt.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc;
            }
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlatecityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Platecitykey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
            Platecitykey.PlateCityID_int = TrafficEntityrpt.PlateCityID_int;
            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
            PlateCityEntity = PlatecityFactory.GetBy(Platecitykey);

            if (PlateCityEntity != null)
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;
                NumberPlate2txt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntityrpt.SerialPlate_nvc;
            }
            else
            {
                NumberPlatetxt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
                NumberPlate2txt.Text = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntityrpt.NumberPlate_nvc) + " - " + TrafficEntityrpt.SerialPlate_nvc;
            }


            DriverCardNumbertxt.Text = "شماره كارت راننده :" + TrafficEntityrpt.DriverCardNumber_nvc;

            CarCardNumbertxt.Text = "شماره كارت كاميون :" + TrafficEntityrpt.CarCardNumber_nvc;

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
                Pricetxt.Text = " مبلغ دریافت شده هنگام ورود " + txt.Text + "  ريال می باشد";
            }
            UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
            if (!string.IsNullOrEmpty(TrafficEntityrpt.AcceptedTurnComment_nvc))
            {
                if (TrafficEntityrpt.Area_bit)
                {
                    Commenttxt.Text = "توضيحات : " + TrafficEntityrpt.AcceptedTurnComment_nvc + " حومه";
                }
                else
                {
                    Commenttxt.Text = "توضيحات : " + TrafficEntityrpt.AcceptedTurnComment_nvc;
                }
            }
            else
            {
                if (TrafficEntityrpt.Area_bit)
                {
                    Commenttxt.Text = "حومه";
                }
            }
            TrafficNumberbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            TrafficNumber_intbarcode.Text = TrafficEntityrpt.TrafficNumber_bint.ToString();
            //if (!TrafficEntityrpt.DriverOffline_bit)
            //{
            //    OfflineReadtxt.Text = "آنلاین";
            //}
            //else
            //{
            //    OfflineReadtxt.Text = "آفلاین";
            //}
            //////////////
            HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1002;
            SettingEntity = settingsFactory.GetBy(SettingKey);
            AllowableHourtxt.Text = SettingEntity.Value_nvc; //TrafficEntityrpt.AllowableHour_int.ToString();
            Feetxt.Text = txt.Text;
            ExtraHourtxt.Text = TrafficEntityrpt.ExtraHour_int.ToString();

            //if (TrafficEntityrpt.WithFlat_bit==true)
            //{
            //txt.Text = TrafficEntityrpt.ExtraHourFee_dec.ToString();
            //}
            ExtraHourFeetxt.Text = TrafficEntityrpt.ExtraHourFee_dec.ToString();
            //////////////
            if (TrafficEntityrpt.TurnPrinted_bit == true)
            {
                this.txtPrintedAgain.Visible = true;
                UserNametxt.Text = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
            }
            else
            {
                this.txtPrintedAgain.Visible = false;
                try
                {
                    TrafficKey.TrafficID_bint = TrafficEntityrpt.TrafficID_bint;
                    TrafficEntityrpt.TurnPrinted_bit = true;
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
