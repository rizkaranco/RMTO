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
    /// Summary description for IranianInNotOutTrafficReport.
    /// </summary>
    public partial class IranianInNotOutTrafficReport : DataDynamics.ActiveReports.ActiveReport
    {

        public IranianInNotOutTrafficReport(string FromDate, string ToDate, int TrafficType, int? PivotGroupID, int? ServicesID)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            FromDatetxt.Text = FromDate;
            ToDatetxt.Text = ToDate;

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TrafficDataTable = new DataTable();
            string Condition = string.Empty;
            if (ServicesID.HasValue)
            {
                if (PivotGroupID.HasValue)
                {
                    Condition = String.Format("(T1.TrafficTypeID_int='1') AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}') AND (LaderPivotGroup_T.LaderPivotGroupID_int={2}) AND (T1.ServiceID_int={3})", FromDate, ToDate, PivotGroupID, ServicesID);
                }
                else
                {
                    Condition = String.Format("(T1.TrafficTypeID_int='1') AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}') AND (T1.ServiceID_int={2})", FromDate, ToDate, ServicesID);
                }

            }
            else
            {
                if (PivotGroupID.HasValue)
                {
                    Condition = String.Format("(T1.TrafficTypeID_int='1') AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}') AND (LaderPivotGroup_T.LaderPivotGroupID_int={2})", FromDate, ToDate, PivotGroupID);
                }
                else
                {
                    Condition = String.Format("(T1.TrafficTypeID_int='1') AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}')", FromDate, ToDate);
                }
            }

            TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(Condition,ref TrafficDataTable);

            TrafficDataTable.Columns.Add(new DataColumn("AllPayment_dec", typeof(decimal)));
            TrafficDataTable.Columns.Add(new DataColumn("Remained_dec", typeof(decimal)));

            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
            string stopFeeCondition = string.Empty;
            var stopFeeFactory = new BLL.StopFeeBLL.BLLStopFee_TFactory();
            BLL.StopFeeBLL.BLLStopFee_T oldStopFeeEntity = null;
            BLL.StopFeeBLL.BLLStopFee_TKeys stopFeeKey = null;
            BLL.LaderTypeBLL.BLLLaderType_T laderTypeEntity = null;
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            DataTable TrafficInWithladBillDataTable = null;
            DataTable TrafficInDatatable = null;
            HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = null;
            HPS.BLL.SettingsBLL.BLLSetting_T TurnHourSettingEntity = null;
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = null;

            foreach (DataRow row in TrafficDataTable.Rows)
            {
               
                DataTable LaderTypeDataTable = new DataTable();
                try
                {
                    oldStopFeeEntity = new BLL.StopFeeBLL.BLLStopFee_T();
                    stopFeeKey = new BLL.StopFeeBLL.BLLStopFee_TKeys();
                    stopFeeKey.StopFeeID_int = Convert.ToInt32(row["StopFeeID_int"]);
                    oldStopFeeEntity = stopFeeFactory.GetBy(stopFeeKey);
                    if ((Int32)row["TrafficTypeID_int"] == 1)
                    {
                        laderTypeEntity = new BLL.LaderTypeBLL.BLLLaderType_T();
                        LaderTypeKey.LaderTypeID_int = Convert.ToInt32(row["LaderTypeID_int"]);
                        laderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                        stopFeeCondition = string.Format(" StartDate_nvc>'{0}' AND StopFee_T.TrafficTypeID_int={1} AND StopFee_T.ServicesID_int={2} AND StopFee_T.LaderPivotGroupID_int={3}", oldStopFeeEntity.EndDate_nvc, Convert.ToInt32(row["TrafficTypeID_int"]), Convert.ToInt32(row["ServiceID_int"]), laderTypeEntity.LaderPivotGroupID_int);
                    }
                    else
                    {
                        stopFeeCondition = string.Format(" StartDate_nvc>'{0}' AND StopFee_T.TrafficTypeID_int={1}", oldStopFeeEntity.StartDate_nvc, Convert.ToInt32(row["TrafficTypeID_int"]));
                    }
                    var newStopFeeTable = new DataTable();
                    stopFeeFactory.GetAllByCondition(stopFeeCondition, ref newStopFeeTable);

                    Hepsa.Core.Common.MyDateTime InDateTime = new Hepsa.Core.Common.MyDateTime(row["Date_nvc"].ToString());
                    Hepsa.Core.Common.MyDateTime OutDateTime = new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate);

                    string InDate = InDateTime.MyDate.ToString("yyyy/MM/dd");//+ " " +  InTime_nvcTextBox.Text;
                    string OutDate = OutDateTime.MyDate.ToString("yyyy/MM/dd");// + " " +  Time_nvcTextBox.Text;


                    if (InDate.Length == 16)
                        InDate += ":00";
                    else if (InDate.Length > 19)
                        InDate = InDate.Substring(0, 19);

                    if (OutDate.Length == 16)
                        OutDate += ":00";
                    else if (OutDate.Length > 19)
                        OutDate = OutDate.Substring(0, 19);



                    decimal Price =Convert.ToDecimal(row["Fee_dec"]);
                    if (Convert.ToInt32(row["ServiceID_int"] )== 2)
                    {
                        Price = row["Fee_dec"] != null ? Convert.ToInt32(row["Fee_dec"]) : 0;
                    }
                    string incondition = "Traffic_T.TrafficNumber_bint='" + row["TrafficNumber_bint"].ToString() + "'";
                    Condition = string.Format("Traffic_T.TurnNumber_bint='{0}' And Traffic_T.TrafficNumber_bint<>{1}", row["TurnNumber_bint"], row["TrafficNumber_bint"].ToString());
                    TrafficInWithladBillDataTable = new DataTable();
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(incondition, ref TrafficInWithladBillDataTable);
                    
                    TrafficInDatatable = new DataTable();
                    TrafficFactory.GetAllByCondition(Condition, ref TrafficInDatatable);
                    
                    SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                    SettingKey.SettingID_int = 1002;
                    TurnHourSettingEntity = settingsFactory.GetBy(SettingKey);

                    if (TrafficInDatatable.Rows.Count > 0)
                    {
                        DateTime TrafficDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficInDatatable.Rows[0]["Date_nvc"].ToString())).MyDate.ToString("yyyy/MM/dd") + " " + TrafficInDatatable.Rows[0]["Time_nvc"].ToString());
                        Int32 Allowablehour = Convert.ToInt32(TurnHourSettingEntity.Value_nvc);
                        if (TrafficFactory.ServerDate <= TrafficDate.AddHours(Allowablehour))
                        {
                            if (TrafficInWithladBillDataTable.Rows.Count == 0)
                            {
                                Price = 0;
                            }
                        }
                    }

                    decimal Balanced = 0;
                    TimeSpan ts = new TimeSpan();
                    if (newStopFeeTable != null && newStopFeeTable.Rows.Count > 0)
                    {
                        //Hepsa.Core.Common.MyDateTime stopFeeMiladiEndDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["EndDate_nvc"].ToString());
                        //string stopFeeEndDate_nvc = stopFeeMiladiEndDate_nvc.MyDate.ToString("yyyy/MM/dd");
                        Hepsa.Core.Common.MyDateTime stopFeeMiladiEndDate_nvc = new Hepsa.Core.Common.MyDateTime(oldStopFeeEntity.EndDate_nvc);
                        string stopFeeEndDate_nvc = stopFeeMiladiEndDate_nvc.MyDate.ToString("yyyy/MM/dd");
                        ts = DateTime.Parse(stopFeeEndDate_nvc).Subtract(DateTime.Parse(InDate));

                        if (Convert.ToBoolean(row["TurnAccepted_bit"]) == true)
                        {
                            double ExtraHour = ts.TotalHours;
                            SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                            SettingKey.SettingID_int = 1002;
                            SettingEntity = settingsFactory.GetBy(SettingKey);
                            ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                            if (ExtraHour > 0)
                            {
                                ///محاسبه مازاد بر اساس قیمت قبلی از ورود تا شروع قیمت جدید
                                int days = (int)(ExtraHour / Convert.ToInt32(row["ExtraHour_int"]));
                                Price += Math.Floor(((decimal)(days)) *  Convert.ToDecimal(row["ExtraHourFee_dec"]));
                            }

                            Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                            string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");
                          TimeSpan  ExtaTS = DateTime.Parse(newStopFeeStartDate_nvc).Subtract(DateTime.Parse(InDate));
                         double ExtraExtraHour = ExtaTS.TotalHours;
                         if (ExtraExtraHour < Convert.ToDouble(SettingEntity.Value_nvc))
                         {
                             ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                             if (ExtraHour >= 0)
                                 ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(InDate));
                           else
                               ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(InDate));


                             ExtraHour = ts.TotalHours-Convert.ToDouble(SettingEntity.Value_nvc);
                             if (ExtraHour >= 0)
                             {
                                 Int32 days = Convert.ToInt32((ExtraHour / Convert.ToInt32(newStopFeeTable.Rows[0]["ExtraHour_int"])));
                                 Price += Math.Floor((Convert.ToDecimal((days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"])));
                             }
                         }
                         else
                         {

                             ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                             //Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                             //string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");
                             //ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                             if (ExtraHour > 0)
                                 ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                             else
                                 ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));

                             ExtraHour = ts.TotalHours;
                             if (ExtraHour > 0)
                             {
                                 Int32 days = Convert.ToInt32((ExtraHour / Convert.ToInt32(newStopFeeTable.Rows[0]["ExtraHour_int"])));
                                 Price += Math.Floor((Convert.ToDecimal((days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"])));
                             }
                         }
                        }
                        else
                        {
                            if (Convert.ToDecimal(row["ExtraHourFee_dec"]) != 0)
                            {
                                ///محاسبه مازاد بر اساس قیمت قبلی از ورود تا شروع قیمت جدید
                                double ExtraHour = ts.TotalHours - Convert.ToDouble(row["AllowableHour_int"]);
                                int days =Convert.ToInt32((ExtraHour / Convert.ToInt32(row["ExtraHour_int"])));
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(row["ExtraHourFee_dec"]));

                                ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                                Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                                string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");
                                ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                                ExtraHour = ts.TotalHours;
                                days = (int)(ExtraHour / (int)newStopFeeTable.Rows[0]["ExtraHour_int"]);
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"]));
                            }
                        }
                    }
                    else
                    {
                        ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(InDate));

                        if (ts.TotalHours > Convert.ToInt32(row["AllowableHour_int"]))
                        {
                            if ( Convert.ToBoolean(row["TurnAccepted_bit"]) == true)
                            {
                                double ExtraHour = ts.TotalHours;
                                SettingEntity = new BLL.SettingsBLL.BLLSetting_T();
                                SettingKey.SettingID_int = 1002;
                                SettingEntity = settingsFactory.GetBy(SettingKey);
                                ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                                if (ExtraHour > 0)
                                {
                                    int days = (int)(ExtraHour / Convert.ToInt32(row["ExtraHour_int"]));
                                    Price += Math.Floor(((decimal)(days)) *  Convert.ToDecimal(row["ExtraHourFee_dec"]));
                                }
                                //else
                                //{
                                //    Price = 0;
                                //}
                            }
                            else
                            {
                                if (Convert.ToDecimal(row["ExtraHourFee_dec"])!= 0)
                                {
                                    double ExtraHour = ts.TotalHours - Convert.ToDouble(row["AllowableHour_int"]);
                                    int days = (int)(ExtraHour / Convert.ToInt32(row["ExtraHour_int"]));
                                    Price += Math.Floor(((decimal)(days)) *  Convert.ToDecimal(row["ExtraHourFee_dec"]));
                                }
                            }

                        }
                    }
                    
                    row["AllPayment_dec"] = Convert.ToString(Price);//+ Balanced
                    if (Price == Balanced)
                    {
                        row["Remained_dec"] = "0";
                    }
                    else
                    {
                        row["Remained_dec"] = Price - Convert.ToDecimal(row["Price_dec"]);//
                    }
                    if ((Price - Balanced) < 0)
                    {
                        row["Remained_dec"] = Convert.ToDecimal(row["Price_dec"]);
                    }
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
            } //AllPayment_dec

             DataSource = TrafficDataTable;
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
            LastNametxt.DataField = "FullName_nvc";
            TurnAcceptedchk.DataField = "TurnAccepted_bit";
            ServiceType_nvctxt.DataField = "ServiceID_intServiceType_nvc";
            DriverCardNumbertxt.DataField = "DriverInfraction_nvc";
            CarInfractiontxt.DataField = "CarInfraction_nvc";
            payment_dectxt.DataField = "AllPayment_dec";
            remained_dectxt.DataField = "Remained_dec";
            DateTextBox.Text = TrafficFactory.ServerJalaliDate;
            TimeTextBox.Text = TrafficFactory.ServerTime;
            UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

            decimal? AllPrice = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Price_dec"]).Sum();
            AllPricetxt.Text = AllPrice.HasValue ? AllPrice.ToString() : "0";

            decimal? AllPayment_dec = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["AllPayment_dec"]).Sum();
            allPayment_dectxt.Text = AllPayment_dec.HasValue ? AllPayment_dec.ToString() : "0";

            decimal? AllRemained_dec = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Remained_dec"]).Sum();
            allRemained_dectxt.Text = AllRemained_dec.HasValue ? AllRemained_dec.ToString() : "0";

        }

        //public IranianInNotOutTrafficReport(string FromDate, string ToDate, int TrafficType, int PivotGroupID)
        //{
        //    //
        //    // Required for Windows Form Designer support
        //    //
        //    InitializeComponent();

        //    FromDatetxt.Text = FromDate;
        //    ToDatetxt.Text = ToDate;

        //    HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
        //    DataTable TrafficDataTable = new DataTable();
        //    string Condition = "(T1.TrafficTypeID_int='1') AND (T1.Date_nvc>='" + FromDatetxt.Text + "') AND (T1.Date_nvc<='" + ToDate + "') AND (LaderPivotGroup_T.LaderPivotGroupID_int='"+PivotGroupID+"')";
        //    TrafficFactory.GetAllByConditionAllInTraffic(Condition, ref TrafficDataTable);
        //     DataSource = TrafficDataTable;
        //    Datetxt.DataField = "Date_nvc";
        //    Timetxt.DataField = "Time_nvc";
        //    TurnNumbertxt.DataField = "TurnNumber_bint";
        //    TrafficNumbertxt.DataField = "TrafficNumber_bint";
        //    NumberPlateTextBox.DataField = "NumberPlate_nvc";
        //    PlateCitytxt.DataField = "PlateCityID_intPlateCity_nvc";
        //    SerialPlateTextBox.DataField = "SerialPlate_nvc";
        //    CarCardNumbertxt.DataField = "CarCardNumber_nvc";
        //    DriverCardNumbertxt.DataField = "DriverCardNumber_nvc";
        //    Pricetxt.DataField = "Price_dec";
        //    Usertxt.DataField = "UserName_nvc";
        //    LastNametxt.DataField = "FullName_nvc";
        //    TurnAcceptedchk.DataField = "TurnAccepted_bit";
        //    ServiceType_nvctxt.DataField = "ServiceID_intServiceType_nvc";
        //    DateTextBox.Text = TrafficFactory.ServerJalaliDate;
        //    TimeTextBox.Text = TrafficFactory.ServerTime;
        //    UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;

        //    decimal? AllPrice = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Price_dec"]).Sum();
        //    AllPricetxt.Text = AllPrice.HasValue ? AllPrice.ToString() : "0";
        //}
        
        
        int row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = row.ToString();
            row++;
        }

        private void detail_Format(object sender, EventArgs e)
        {
            Pricetxt.Value = string.Format("{0:#,###}", Pricetxt.Value);
        }
        private void pageFooter_Format(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AllPricetxt.Text) == false)
                AllPricetxt.Text = string.Format("{0:#,###}", decimal.Parse(AllPricetxt.Text));
        }

        private void FillTraffic()
        {
            
        }
    }
}
