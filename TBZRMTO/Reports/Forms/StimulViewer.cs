using HamrahanSystem.TextBox;
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
    public partial class StimulViewer : Form
    {
        Stimulsoft.Report.StiReport _sti = new Stimulsoft.Report.StiReport();
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new BLL.TrafficBLL.BLLTraffic_T();
        private Boolean? _Traffic_bit = null;
        private Boolean? _Othercar_bit = null;
        private string _type;
        private int _again = 0;
        private int _LadBIillCreditID;

        public StimulViewer(Stimulsoft.Report.StiReport sti)
        {
            InitializeComponent();
            _sti = sti;
        }

        public StimulViewer(HPS.BLL.TrafficBLL.BLLTraffic_T _TrafficEntity, Boolean Traffic_bit, Boolean Othercar_bit)
        {
            InitializeComponent();
            TrafficEntity = _TrafficEntity;
            _Traffic_bit = Traffic_bit;
            _Othercar_bit = Othercar_bit;
        }

        public StimulViewer(int again, int LadBIillCreditID)
        {
            InitializeComponent();
            _again = again;
            _LadBIillCreditID = LadBIillCreditID;
            //AgainPrintDate_vc
            //AgainPrintTime_vc
            //AgainPrintUser_vnc
            //MobileNumber_vc
            //Date_vc
            //Time_vc
            //LadBillNumber_bint
            //TurnNumber_bint
            //TrafficNumber_bint
            //DriverCardNumber_vc
            //CarCardNumber_vc
            //MinWeight_flt
            //MaxWeight_flt
            //Company_nvc
            //Remained_bit
            //Again_bit
            //LaderType_nvc
            //PlateNumber_nvc
            //DriverName_nvc
            //LicenceNumber_bint
            //LicenceCity_nvc
            //Good_nvc
            //PortPlace_nvc
            //AssignmentDate_vc
            //Destination_nvc
            //Boxing_nvc
            //PortajeFee_dec
            //AssignmentComment_nvc
            //UserName_nvc
            //Comment_nvc
            //BillMessage_nvc
        }

        public StimulViewer(string type)
        {
            InitializeComponent();
            _type = type;
        }

        private void StimulViewer_Load(object sender, EventArgs e)
        {
            //try
            //{
                  if (_Traffic_bit == false && _Othercar_bit == false)
            {
                AcceptedTurnstiReport.Dictionary.Synchronize();
                AcceptedTurnstiReport.Dictionary.Databases.Clear();
                AcceptedTurnstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                AcceptedTurnstiReport.Compile();
                AcceptedTurnstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                if (TrafficEntity.BillMessageID_int == 0 || TrafficEntity.BillMessageID_int == null)
                {

                }
                else
                {
                    string Billcondition = "[BillMessage_T].[BillMessageID_int]=" + TrafficEntity.BillMessageID_int;
                    List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillLst = BillFactory.GetAllByCondition(Billcondition);
                    if (BillLst != null)
                    {
                        AcceptedTurnstiReport["Messagetxt"] = BillLst[0].Message_nvc;
                        AcceptedTurnstiReport["Message_bit"] = true;
                    }
                    else
                        AcceptedTurnstiReport["Message_bit"] = false;
                }
                NumericTextBox txt = new NumericTextBox();
                txt.DigitsInGroup = 3;
                if (TrafficEntity.Price_dec != null)
                {
                    txt.Text = TrafficEntity.Price_dec.ToString();
                    AcceptedTurnstiReport["Price_nvc"] = " مبلغ دریافت شده هنگام ورود " + txt.Text + "  ريال می باشد";
                }
                if (TrafficEntity.Price_dec != null)
                {
                    AcceptedTurnstiReport["PricewithOutTax_nvc"] = (TrafficEntity.Price_dec - TrafficEntity.PriceTax_dec).ToString();
                }

                if (!string.IsNullOrEmpty(TrafficEntity.AcceptedTurnComment_nvc))
                {
                    if (TrafficEntity.Area_bit)
                    {
                        AcceptedTurnstiReport["Comment_nvc"] = "توضيحات : " + TrafficEntity.AcceptedTurnComment_nvc;// +" حومه";
                    }
                    else
                    {
                        AcceptedTurnstiReport["Comment_nvc"] = "توضيحات : " + TrafficEntity.AcceptedTurnComment_nvc;
                    }
                }
                else
                {
                    //if (TrafficEntity.Area_bit)
                    //{
                    //    AcceptedTurnstiReport["Comment_nvc"] = "حومه";
                    //}
                }
                if (TrafficEntity.TurnPrinted_bit == true)
                {
                    AcceptedTurnstiReport["PrintedAgain_nvc"] = "المثنی";
                }
                else
                {
                    AcceptedTurnstiReport["PrintedAgain_nvc"] = "";
                }

                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlatecityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Platecitykey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                Platecitykey.PlateCityID_int = TrafficEntity.PlateCityID_int;
                HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
                PlateCityEntity = PlatecityFactory.GetBy(Platecitykey);

                if (PlateCityEntity != null)
                {
                    AcceptedTurnstiReport["Number_nvc"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntity.SerialPlate_nvc;
                }
                else
                {
                    AcceptedTurnstiReport["Number_nvc"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc) + " - " + TrafficEntity.SerialPlate_nvc;
                }

                if (TrafficEntity.LadeReturn_bit == true)
                {
                    AcceptedTurnstiReport["TurnNumber"] = "برگشت از بار";
                }
                else
                {
                    if (TrafficEntity.AcceptedTurnNumber_bint.HasValue)
                    {
                        AcceptedTurnstiReport["TurnNumber"] = "شماره نوبت : " + TrafficEntity.AcceptedTurnNumber_bint.ToString();
                    }
                    else
                    {
                        AcceptedTurnstiReport["TurnNumber"] = "شماره نوبت رزرو : " + TrafficEntity.TurnNumber_bint.ToString();
                    }
                }

                AcceptedTurnstiReport["TrafficNumber"] = " شماره قبض پارکینگ: " + TrafficEntity.TrafficNumber_bint.ToString();


                AcceptedTurnstiReport["InDate_vc"] = TrafficEntity.Date_nvc;
                AcceptedTurnstiReport["InTime_vc"] = TrafficEntity.Time_nvc;
                AcceptedTurnstiReport["Time_vc"] = PortPlaceFactory.ServerTime;
                AcceptedTurnstiReport["Date_vc"] = PortPlaceFactory.ServerJalaliDate;
                AcceptedTurnstiReport["username_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;


                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntity.LaderTypeID_int + "'";

                AcceptedTurnstiReport["@TrafficID_bint"] = TrafficEntity.TrafficID_bint;
                AcceptedTurnstiReport["@Condition"] = LaderTypecondition;
                AcceptedTurnstiReport.Render();

                Properties.Settings s = new HPS.Properties.Settings();
                System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                if (string.IsNullOrEmpty(s.PrinterName))
                    AcceptedTurnstiReport.Print(true);
                else
                {
                    PrinterSetting.PrinterName = s.PrinterName;
                    AcceptedTurnstiReport.Print(false, PrinterSetting);
                }

                this.Close();
            }

            else if (_Traffic_bit == true && _Othercar_bit == false)
            {

                TrafficstiReport.Dictionary.Synchronize();
                TrafficstiReport.Dictionary.Databases.Clear();
                TrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                TrafficstiReport.Compile();
                TrafficstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                if (TrafficEntity.BillMessageID_int == 0 || TrafficEntity.BillMessageID_int == null)
                {

                }
                else
                {
                    string Billcondition = "[BillMessage_T].[BillMessageID_int]=" + TrafficEntity.BillMessageID_int;
                    List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillLst = BillFactory.GetAllByCondition(Billcondition);
                    if (BillLst != null)
                    {
                        TrafficstiReport["Messagetxt"] = BillLst[0].Message_nvc;
                        TrafficstiReport["Message_bit"] = true;
                    }
                    else
                        TrafficstiReport["Message_bit"] = false;
                }
                NumericTextBox txt = new NumericTextBox();
                txt.DigitsInGroup = 3;
                if (TrafficEntity.Price_dec != null)
                {
                    txt.Text = TrafficEntity.Price_dec.ToString();
                    TrafficstiReport["Price_nvc"] = " مبلغ دریافت شده هنگام ورود " + txt.Text + "  ريال می باشد";
                }

                if (!string.IsNullOrEmpty(TrafficEntity.AcceptedTurnComment_nvc))
                {
                    if (TrafficEntity.Area_bit)
                    {
                        TrafficstiReport["Comment_nvc"] = "توضيحات : " + TrafficEntity.AcceptedTurnComment_nvc;// +" حومه";
                    }
                    else
                    {
                        TrafficstiReport["Comment_nvc"] = "توضيحات : " + TrafficEntity.AcceptedTurnComment_nvc;
                    }
                }
                else
                {
                    //if (TrafficEntity.Area_bit)
                    //{
                    //    TrafficstiReport["Comment_nvc"] = "حومه";
                    //}
                }
                if (TrafficEntity.TurnPrinted_bit == true)
                {
                    TrafficstiReport["PrintedAgain_nvc"] = "المثنی";
                }
                else
                {
                    TrafficstiReport["PrintedAgain_nvc"] = "";
                }

                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlatecityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Platecitykey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                Platecitykey.PlateCityID_int = TrafficEntity.PlateCityID_int;
                HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
                PlateCityEntity = PlatecityFactory.GetBy(Platecitykey);

                if (PlateCityEntity != null)
                {
                    TrafficstiReport["Number_nvc"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc) + " - " + PlateCityEntity.PlateCity_nvc + " " + TrafficEntity.SerialPlate_nvc;
                }
                else
                {
                    TrafficstiReport["Number_nvc"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc) + " - " + TrafficEntity.SerialPlate_nvc;
                }


                if (TrafficEntity.ServiceID_int == 2)
                {
                    if (TrafficEntity.TurnAccepted_bit == true)
                    {
                        //نوبت تأیید شده داره
                        TrafficstiReport["TurnNumber"] = "شماره نوبت :   " + Convert.ToString(TrafficEntity.AcceptedTurnNumber_bint);
                        //AcceptedDate2TextBox.Text = TrafficEntityrpt.TurnDate_nvc;
                        //AcceptedTime2TextBox.Text = TrafficEntityrpt.TurnTime_nvc;
                        //TurnNumber2txt.Text = TrafficEntityrpt.AcceptedTurnNumber_bint.ToString();

                    }
                    else
                    {
                        //نوبت تأیید شده ندارد
                        TrafficstiReport["TurnNumber"] = "شماره نوبت رزرو :   " + Convert.ToString(TrafficEntity.TurnNumber_bint);
                    }
                }
                else
                {
                    // (عدم نمایش نوبت (مراجعه به غیر از نوبت 
                    TrafficstiReport["TurnNumber"] = "";
                }

                TrafficstiReport["TrafficNumber"] = "شماره قبض پارکینگ : " + TrafficEntity.TrafficNumber_bint.ToString();

                HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1002;
                SettingEntity = settingsFactory.GetBy(SettingKey);
                if (TrafficEntity.ServiceID_int == 2)
                {
                    TrafficstiReport["TAllowableHour"] = SettingEntity.Value_nvc; //TrafficEntityrpt.AllowableHour_int.ToString();
                }
                else
                {
                    TrafficstiReport["TAllowableHour"] = TrafficEntity.AllowableHour_int.ToString();
                }



                HPS.BLL.ServicesBLL.BLLServices_TFactory servicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
                HPS.BLL.ServicesBLL.BLLServices_TKeys ServicesKey = new HPS.BLL.ServicesBLL.BLLServices_TKeys();
                ServicesKey.ServicesID_int = TrafficEntity.ServiceID_int;
                HPS.BLL.ServicesBLL.BLLServices_T ServicesEntity = new HPS.BLL.ServicesBLL.BLLServices_T();
                ServicesEntity = servicesFactory.GetBy(ServicesKey);
                TrafficstiReport["system_nvc"] = " قبض مراجعه به : " + ServicesEntity.ServicesType_nvc;

                if (TrafficEntity.WithLade_bit == true)
                {
                    TrafficstiReport["WithLade_nvc"] = "وضعیت : " + "با بار" + "(" + TrafficEntity.Comment_nvc + ") ";
                }
                else
                {
                    TrafficstiReport["WithLade_nvc"] = "وضعیت : " + "بدون بار";
                }

                if (TrafficEntity.TurnHour_int != null)
                {
                    TrafficstiReport["TurnNumberAllert_nvc"] = " شماره نوبت شما رزرو می باشد لطفاً تا " + TrafficEntity.TurnHour_int.ToString() + " ساعت نسبت به تأیید آن اقدام نمایید";
                }


                TrafficstiReport["InDate_vc"] = TrafficEntity.Date_nvc;
                TrafficstiReport["InTime_vc"] = TrafficEntity.Time_nvc;
                TrafficstiReport["Time_vc"] = PortPlaceFactory.ServerTime;
                TrafficstiReport["Date_vc"] = PortPlaceFactory.ServerJalaliDate;
                TrafficstiReport["username_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;


                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntity.LaderTypeID_int + "'";

                TrafficstiReport["@TrafficID_bint"] = TrafficEntity.TrafficID_bint;
                TrafficstiReport["@Condition"] = LaderTypecondition;
                TrafficstiReport.Render();

                Properties.Settings s = new HPS.Properties.Settings();
                System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                if (string.IsNullOrEmpty(s.PrinterName))
                    TrafficstiReport.Print(true);
                else
                {
                    PrinterSetting.PrinterName = s.PrinterName;
                    TrafficstiReport.Print(false, PrinterSetting);
                }

                this.Close();
            }
            //سواری وغیره
            else if (_Traffic_bit == false && _Othercar_bit == true)
            {

                //HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                OtherCarstiReport.Dictionary.Synchronize();
                OtherCarstiReport.Dictionary.Databases.Clear();
                OtherCarstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                OtherCarstiReport.Compile();
                OtherCarstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                OtherCarstiReport["DateTextBox"] = TrafficEntity.Date_nvc;
                OtherCarstiReport["TimeTextBox"] = TrafficEntity.Time_nvc;
                OtherCarstiReport["TrafficNumbertxt"] = TrafficEntity.TrafficNumber_bint.ToString();
                OtherCarstiReport["Servicestxt"] = " مراجعه به : " + TrafficEntity.Services_nvc;
                OtherCarstiReport["CarTypetxt"] = "نوع وسیله : " + TrafficEntity.System_nvc;
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                HPS.BLL.PlateCityBLL.BLLPlateCity_T PlatecityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                PlateCityKey.PlateCityID_int = TrafficEntity.PlateCityID_int;
                PlatecityEntity = PlateCityFactory.GetBy(PlateCityKey);
                OtherCarstiReport["NumberPlatetxt"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc) + " - " + PlatecityEntity.PlateCity_nvc + " " + TrafficEntity.SerialPlate_nvc;
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                if (TrafficEntity.BillMessageID_int == 0 || TrafficEntity.BillMessageID_int == null)
                {
                    OtherCarstiReport["Messagetxt"] = "";
                }
                else
                {
                    string Billcondition = "[BillMessage_T].[BillMessageID_int]=" + TrafficEntity.BillMessageID_int;
                    List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillLst = BillFactory.GetAllByCondition(Billcondition);
                    if (BillLst != null)
                    {
                        OtherCarstiReport["Messagetxt"] = BillLst[0].Message_nvc;
                    }
                    else
                        OtherCarstiReport["Messagetxt"] = "";

                }

                NumericTextBox txt = new NumericTextBox();
                txt.DigitsInGroup = 3;
                if (TrafficEntity.Price_dec != null)
                {
                    txt.Text = TrafficEntity.Price_dec.ToString();
                    OtherCarstiReport["Pricetxt"] = " مبلغ دریافتی هنگام ورود " + txt.Text + "  ريال می باشد";
                }
                OtherCarstiReport["AllowableHourtxt"] = TrafficEntity.AllowableHour_int.ToString();
                OtherCarstiReport["ExtraHourtxt"] = TrafficEntity.ExtraHour_int.ToString();
                txt.Text = TrafficEntity.Fee_dec.ToString();
                OtherCarstiReport["Feetxt"] = txt.Text;
                txt.Text = TrafficEntity.ExtraHourFee_dec.ToString();
                OtherCarstiReport["ExtraHourFeetxt"] = txt.Text;
                OtherCarstiReport["UserNametxt"] = TrafficEntity.UserName_nvc;
                OtherCarstiReport["TrafficNumberbarcode"] = TrafficEntity.TrafficNumber_bint.ToString();

                if (TrafficEntity.Printed_bit == true)
                {
                    OtherCarstiReport["txtPrintedAgain"] = "المثنی";
                }
                else
                {
                    OtherCarstiReport["txtPrintedAgain"] = "";
                }

                //DriverName_nvc
                OtherCarstiReport["DriverName_nvc"] = "نام راننده : " + TrafficEntity.FirstName_nvc + " " + TrafficEntity.LastName_nvc;
                OtherCarstiReport["Fee_dec"] = TrafficEntity.Fee_dec.ToString();
                OtherCarstiReport["PriceTax_dec"] = TrafficEntity.PriceTax_dec.ToString();
                OtherCarstiReport.Render();

                Properties.Settings s = new HPS.Properties.Settings();
                System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                if (string.IsNullOrEmpty(s.PrinterName))
                    OtherCarstiReport.Print(true);
                else
                {
                    PrinterSetting.PrinterName = s.PrinterName;
                    OtherCarstiReport.Print(false, PrinterSetting);
                }

                this.Close();
            }
            //خارجی
            else if (_Traffic_bit == true && _Othercar_bit == true)
            {

                //HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                ForeignCarstiReport.Dictionary.Synchronize();
                ForeignCarstiReport.Dictionary.Databases.Clear();
                ForeignCarstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                ForeignCarstiReport.Compile();
                ForeignCarstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                ForeignCarstiReport["DateTextBox"] = TrafficEntity.Date_nvc;
                ForeignCarstiReport["TimeTextBox"] = TrafficEntity.Time_nvc;
                ForeignCarstiReport["TrafficNumbertxt"] = TrafficEntity.TrafficNumber_bint.ToString();
                ForeignCarstiReport["DriverNametxt"] = " نام راننده : " + TrafficEntity.FirstName_nvc + " " + TrafficEntity.LastName_nvc;
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory laderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                string LaderTypecondition = "[LaderType_T].[LaderTypeID_int]='" + TrafficEntity.LaderTypeID_int + "'";
                List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = laderTypeFactory.GetAllByCondition(LaderTypecondition);
                if (LaderTypeLst != null)
                {
                    ForeignCarstiReport["CarTypetxt"] = "نوع وسيله : " + TrafficEntity.System_nvc + "-  " + LaderTypeLst[0].LaderType_nvc;
                }
                if (!string.IsNullOrEmpty(TrafficEntity.SerialPlate_nvc))
                {
                    ForeignCarstiReport["NumberPlatetxt"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc) + " - " + TrafficEntity.SerialPlate_nvc;
                }
                else
                {
                    ForeignCarstiReport["NumberPlatetxt"] = "شماره پلاک : " + Hepsa.Core.Common.PersentationController.CorrectNumberPlate(TrafficEntity.NumberPlate_nvc);
                }

                if (TrafficEntity.WithLade_bit == true)
                {
                    ForeignCarstiReport["WithLadetxt"] = "وضعیت : " + "با بار" + "(" + TrafficEntity.Comment_nvc + ") ";
                }
                else
                {
                    ForeignCarstiReport["WithLadetxt"] = "وضعیت : " + "بدون بار";
                }
                NumericTextBox txt = new NumericTextBox();
                txt.DigitsInGroup = 3;
                if (TrafficEntity.Price_dec != null)
                {
                    txt.Text = TrafficEntity.Price_dec.ToString();
                    ForeignCarstiReport["Pricetxt"] = " مبلغ دریافتی هنگام ورود " + txt.Text + "  ريال می باشد";
                }
                ForeignCarstiReport["AllowableHourtxt"] = TrafficEntity.AllowableHour_int.ToString();
                ForeignCarstiReport["ExtraHourtxt"] = TrafficEntity.ExtraHour_int.ToString();
                txt.Text = TrafficEntity.Fee_dec.ToString();
                ForeignCarstiReport["Feetxt"] = txt.Text;
                txt.Text = TrafficEntity.ExtraHourFee_dec.ToString();
                ForeignCarstiReport["ExtraHourFeetxt"] = txt.Text;
                ForeignCarstiReport["UserNametxt"] = TrafficEntity.UserName_nvc;
                ForeignCarstiReport["TrafficNumberbarcode"] = TrafficEntity.TrafficNumber_bint.ToString();
                if (TrafficEntity.Printed_bit == true)
                {
                    ForeignCarstiReport["txtPrintedAgain"] = "المثنی";
                }
                else
                {
                    ForeignCarstiReport["txtPrintedAgain"] = "";
                }
                ForeignCarstiReport["Fee_dec"] = TrafficEntity.Fee_dec.ToString();
                ForeignCarstiReport["PriceTax_dec"] = TrafficEntity.PriceTax_dec.ToString();
                ForeignCarstiReport.Render();

                Properties.Settings s = new HPS.Properties.Settings();
                System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                if (string.IsNullOrEmpty(s.PrinterName))
                    ForeignCarstiReport.Print(true);
                else
                {
                    PrinterSetting.PrinterName = s.PrinterName;
                    ForeignCarstiReport.Print(false, PrinterSetting);
                }

                this.Close();
            }
                  else if (_type == "dublicateTurns")
            {
                BLL.TrafficBLL.BLLTraffic_TFactory trafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable duplicateTurnDataTable = new DataTable();
                trafficFactory.DuplicateTurnsReport(duplicateTurnDataTable);
                stiViewerControl1.Report = _sti;


                DuplicateTurnsReport.Dictionary.Synchronize();
                DuplicateTurnsReport.Dictionary.Databases.Clear();
                DuplicateTurnsReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                DuplicateTurnsReport.Compile();
                DuplicateTurnsReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                DuplicateTurnsReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                DuplicateTurnsReport["userName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                DuplicateTurnsReport.Render();
                DuplicateTurnsReport.Show();
            }
            else if (_again == 1)
            {
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys LadBillKey = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
                LadBillKey.LadBillCreditID_int = _LadBIillCreditID;
                DataTable LadBillLadeAssignmentDataTable = new DataTable();
                LadBillCreditFactory.GetAllLadeAssignment(LadBillKey, ref LadBillLadeAssignmentDataTable);
                Stimulsoft.Report.StiReport LadBillReportstiReport = new Stimulsoft.Report.StiReport();
                LadBillReportstiReport.Load(Application.StartupPath + "\\LadBillCredit.mrt");
                LadBillReportstiReport.Dictionary.Synchronize();
                LadBillReportstiReport.Dictionary.Databases.Clear();
                LadBillReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LadBillReportstiReport.Compile();
            LadBillReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["DriverCardNumber_nvc"].ToString()))
                {
                    LadBillReportstiReport["DriverCardNumber_vc"] = " کارت هوشمند راننده: " + LadBillLadeAssignmentDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                }
                else
                {
                    LadBillReportstiReport["DriverCardNumber_vc"] = " کارت هوشمند راننده:فاقد كارت ";
                }
                if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString()))
                {
                    LadBillReportstiReport["CarCardNumber_vc"] = " کارت هوشمند کامیون : " + LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                }
                else
                {
                    LadBillReportstiReport["CarCardNumber_vc"] = " کارت هوشمند کامیون :فاقد كارت ";
                }

                LadBillReportstiReport["MobileNumber_vc"] = string.Format("موبایل راننده: {0}", LadBillLadeAssignmentDataTable.Rows[0]["DriverMobileNumber_nvc"].ToString());
                LadBillReportstiReport["Company_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["CompanyID_intCompany_nvc"].ToString() + "(" + LadBillLadeAssignmentDataTable.Rows[0]["CompanyCode_nvc"].ToString() + ")" + "(" + LadBillLadeAssignmentDataTable.Rows[0]["Phone_nvc"].ToString() + ")"; //Cmp_nvc
                LadBillReportstiReport["LaderType_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["LaderTypeID_intLaderType_nvc"].ToString();
                LadBillReportstiReport["Boxing_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["BoxingID_intBoxingType_nvc"].ToString(); //LaderType
                LadBillReportstiReport["PlateNumber_nvc"] = Hepsa.Core.Common.PersentationController.CorrectNumberPlate(LadBillLadeAssignmentDataTable.Rows[0]["NumberPlate_nvc"].ToString()) + " - " + LadBillLadeAssignmentDataTable.Rows[0]["PlateCity_nvc"].ToString() + LadBillLadeAssignmentDataTable.Rows[0]["SerialPlate_nvc"].ToString(); //Plaque
                LadBillReportstiReport["DriverName_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["DriverName"].ToString(); //Driver
                LadBillReportstiReport["LicenceNumber_bint"] =(LadBillLadeAssignmentDataTable.Rows[0]["licenceNumber_int"]!= DBNull.Value?Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["licenceNumber_int"]):0); //LicenceNumber
                LadBillReportstiReport["LicenceCity_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["LicenceCityID_intCity_nvc"].ToString(); //LicenceCity
                LadBillReportstiReport["Good_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["GoodID_intGood_nvc"].ToString(); //Good
                LadBillReportstiReport["Date_vc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadingDate_nvc"].ToString(); //
                LadBillReportstiReport["Destination_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["CityID_intCity_nvc"].ToString() + "-" + LadBillLadeAssignmentDataTable.Rows[0]["Address_nvc"].ToString();
                LadBillReportstiReport["PortajeFee_dec"] = LadBillLadeAssignmentDataTable.Rows[0]["PortageFee_dec"].ToString();
                LadBillReportstiReport["AssignmentComment_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["AssignmentComment_nvc"].ToString();
                LadBillReportstiReport["Date_vc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadBillDate"].ToString();
                LadBillReportstiReport["Time_vc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadBillTime"].ToString();
                LadBillReportstiReport["TurnNumber_bint"] = Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["AcceptedTurnNumber_bint"]);
                LadBillReportstiReport["LadBillNumber_bint"] = Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["LadBillCreditID_int"]);
                LadBillReportstiReport["UserName_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadBillUser"].ToString();
                LadBillReportstiReport["PortPlace_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["PortPlaceID_intPortPlaces_nvc"].ToString();
                LadBillReportstiReport["MinWeight_nvc"] = "از وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MinWeight_dec"];
                LadBillReportstiReport["MaxWeight_nvc"] = "تا وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MaxWeight_dec"];
                LadBillReportstiReport["TrafficNumber_bint"] = Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["TrafficNumber_bint"]);
                LadBillReportstiReport["System_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["System_nvc"].ToString();
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessage_TFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessage_TList = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
                string Condition = string.Format("TrafficType_T.TrafficTypeID_int=9 AND [BillMessage_T].StartDate_nvc<='{0}' AND [BillMessage_T].[EndDate_nvc]>='{0}' ", BillMessage_TFactory.ServerJalaliDate);
                BillMessage_TList = BillMessage_TFactory.GetAllByCondition(Condition);
                if (BillMessage_TList != null && BillMessage_TList.Count > 0)
                {
                    LadBillReportstiReport["BillMessage_nvc"] = BillMessage_TList[0].Message_nvc;
                }
                if (_again != 1)
                {
                    if (LadBillLadeAssignmentDataTable.Rows[0]["LadeDate"].ToString().CompareTo(LadBillCreditFactory.ServerJalaliDate) < 0)
                    {
                        LadBillReportstiReport["Remained_bit"] = true;
                    }
                    else
                        LadBillReportstiReport["Remained_bit"] = false;
                }

                if (_again == 1)
                {
                    LadBillReportstiReport["Again_bit"] = true;
                    LadBillReportstiReport["AgainPrintDate_vc"] = LadBillCreditFactory.ServerJalaliDate;
                    LadBillReportstiReport["AgainPrintTime_vc"] = LadBillCreditFactory.ServerTime;
                    LadBillReportstiReport["AgainPrintUser_vnc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                }
                LadBillReportstiReport.Render();
                Properties.Settings s = new HPS.Properties.Settings();
                System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                if (string.IsNullOrEmpty(s.PrinterName))
                {
                    LadBillReportstiReport.PrinterSettings.Copies = 3;
                    LadBillReportstiReport.Print(true);
                }
                    
                else
                {
                    LadBillReportstiReport.PrinterSettings.Copies = 3;
                    PrinterSetting.PrinterName = s.PrinterName;
                    LadBillReportstiReport.Print(false, PrinterSetting);
                }
            }
                  else
                  {
                      stiViewerControl1.Report = _sti;

                  }
                  this.Close();
            }
        
            //catch (Exception ex)
            //{
                
            //    throw ex;
           //}
        //}
    }
}
