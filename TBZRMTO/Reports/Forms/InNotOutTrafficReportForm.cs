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
    public partial class InNotOutTrafficReportForm : Hepsa.Core.PL.BaseForm
    {
        private int _TrafficType = 0;
        private int _Service = 0;
        public InNotOutTrafficReportForm(int TrafficType)
        {
            InitializeComponent();
            this._TrafficType = TrafficType;
            if (_TrafficType == 2 || _TrafficType == 3 || _TrafficType == 8)
            {
                groupBox1.Visible = false;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }

                if (TrafficTypeComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("نوع تردد را انتخاب کنید");
                }
                else
                {
                  

                        string FromDate = FromDatefaDatePicker.Text;
                        int ServicesID = Convert.ToInt32(ServicesComboBox.SelectedValue);
                        string ToDate = ToDatefaDatePicker.Text;
                        int PivotGroupID = Convert.ToInt32(LaderPivotGroupID_intComboBox.SelectedValue);

                        DataTable TrafficDataTable = new DataTable();
                        string Condition = string.Empty;
                        if (ServicesID != 0)
                        {
                            if (PivotGroupID != 0)
                            {
                                Condition = String.Format("(T1.TrafficTypeID_int={4}) AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}') AND (LaderPivotGroup_T.LaderPivotGroupID_int={2}) AND (T1.ServiceID_int={3})", FromDate, ToDate, PivotGroupID, ServicesID, Convert.ToInt32(TrafficTypeComboBox.SelectedValue));
                            }
                            else
                            {
                                Condition = String.Format("(T1.TrafficTypeID_int={3}) AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}') AND (T1.ServiceID_int={2})", FromDate, ToDate, ServicesID, Convert.ToInt32(TrafficTypeComboBox.SelectedValue));
                            }

                        }
                        else
                        {
                            if (PivotGroupID != 0)
                            {
                                Condition = String.Format("(T1.TrafficTypeID_int={3}) AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}') AND (LaderPivotGroup_T.LaderPivotGroupID_int={2})", FromDate, ToDate, PivotGroupID, Convert.ToInt32(TrafficTypeComboBox.SelectedValue));
                            }
                            else
                            {
                                Condition = String.Format("(T1.TrafficTypeID_int={2}) AND (T1.Date_nvc>='{0}') AND (T1.Date_nvc<='{1}')", FromDate, ToDate, Convert.ToInt32(TrafficTypeComboBox.SelectedValue));
                            }
                        }

                        TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(Condition, ref TrafficDataTable);

                        TrafficDataTable.Columns.Add(new DataColumn("AllPayment_dec", typeof(decimal)));
                        TrafficDataTable.Columns.Add(new DataColumn("Remained_dec", typeof(decimal)));

                        CalcPrice(TrafficDataTable);

                        if ((Int32)TrafficTypeComboBox.SelectedValue == 1)
                        {
                            IranianInNotOutStiReport.Dictionary.Synchronize();
                            IranianInNotOutStiReport.Dictionary.Databases.Clear();
                            IranianInNotOutStiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                            IranianInNotOutStiReport.RegData(TrafficDataTable);
                            IranianInNotOutStiReport.Compile();
                            IranianInNotOutStiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                            decimal? AllPrice = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Price_dec"]).Sum();
                            IranianInNotOutStiReport["AllPricetxt"] = AllPrice.HasValue ? AllPrice.ToString() : "0";

                            decimal? AllPayment_dec = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["AllPayment_dec"]).Sum();
                            IranianInNotOutStiReport["allPayment_dectxt"] = AllPayment_dec.HasValue ? AllPayment_dec.ToString() : "0";

                            decimal? AllRemained_dec = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Remained_dec"]).Sum();
                            IranianInNotOutStiReport["allRemained_dectxt"] = AllRemained_dec.HasValue ? AllRemained_dec.ToString() : "0";

                            IranianInNotOutStiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                            IranianInNotOutStiReport["todate_vc"] = ToDatefaDatePicker.Text;
                            IranianInNotOutStiReport["date_vc"] = TrafficFactory.ServerJalaliDate + "   " + TrafficFactory.ServerTime; ;
                            IranianInNotOutStiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                            IranianInNotOutStiReport.Render();
                            stiViewerControl1.Report = null;
                            stiViewerControl1.Report = IranianInNotOutStiReport;

                        }
                        else if ((Int32)TrafficTypeComboBox.SelectedValue == 2)
                        {
                            Condition = string.Empty;
                            Condition = "(T1.TrafficTypeID_int='2') AND (T1.Date_nvc>='" + FromDatefaDatePicker.Text + "') AND (T1.Date_nvc<='" + ToDatefaDatePicker.Text + "')";
                            ForeignInNotOutstiReport.Dictionary.Synchronize();
                            ForeignInNotOutstiReport.Dictionary.Databases.Clear();
                            ForeignInNotOutstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                            ForeignInNotOutstiReport.Compile();
                            ForeignInNotOutstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                            ForeignInNotOutstiReport["@Condition"] = Condition;
                            ForeignInNotOutstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                            ForeignInNotOutstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                            ForeignInNotOutstiReport["date_vc"] = TrafficFactory.ServerJalaliDate + "   " + TrafficFactory.ServerTime; ;
                            ForeignInNotOutstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                            ForeignInNotOutstiReport.Render();
                            stiViewerControl1.Report = null;
                            stiViewerControl1.Report = ForeignInNotOutstiReport;
                        }
                        else if ((Int32)TrafficTypeComboBox.SelectedValue == 3 || (Int32)TrafficTypeComboBox.SelectedValue == 8)
                        {

                            OtherInNotOutReportstiReport.RegData(TrafficDataTable);
                            OtherInNotOutReportstiReport.Compile();
                            decimal? AllPrice = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Price_dec"]).Sum();
                            OtherInNotOutReportstiReport["AllPricetxt"] = AllPrice.HasValue ? AllPrice.ToString() : "0";

                            decimal? AllPayment_dec = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["AllPayment_dec"]).Sum();
                            OtherInNotOutReportstiReport["allPayment_dectxt"] = AllPayment_dec.HasValue ? AllPayment_dec.ToString() : "0";

                            decimal? AllRemained_dec = (from row in TrafficDataTable.AsEnumerable() select (decimal?)row["Remained_dec"]).Sum();
                            OtherInNotOutReportstiReport["allRemained_dectxt"] = AllRemained_dec.HasValue ? AllRemained_dec.ToString() : "0";

                            OtherInNotOutReportstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                            OtherInNotOutReportstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                            OtherInNotOutReportstiReport["date_vc"] = TrafficFactory.ServerJalaliDate + "   " + TrafficFactory.ServerTime; ;
                            OtherInNotOutReportstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                            OtherInNotOutReportstiReport.Render();
                            stiViewerControl1.Report = null;
                            stiViewerControl1.Report = OtherInNotOutReportstiReport;
                        }
                   
                }
            }
            
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void InTrafficReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillCombo();
                ServicesComboBox.Enabled = false;

            }
            catch
            {
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupID_intFactory = new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
                DataTable LaderPivotGroupID_intDataTable = new DataTable();
                LaderPivotGroupID_intFactory.GetAll(ref LaderPivotGroupID_intDataTable);
                this.LaderPivotGroupID_intComboBox.DisplayMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString();
                this.LaderPivotGroupID_intComboBox.ValueMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString();
                this.LaderPivotGroupID_intComboBox.DataSource = LaderPivotGroupID_intDataTable;
                this.LaderPivotGroupID_intComboBox.SelectedIndex = -1;
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderPivotGroupID_intFactory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderPivotGroupID_intFactory.ServerJalaliDate);

                HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
                DataTable ServicesDataTable = new DataTable();
                string condition = "[Services_T].[Activie_bit]='true'";
                ServicesFactory.GetAllByCondition(condition, ref ServicesDataTable);
                ServicesComboBox.DataSource = ServicesDataTable;
                ServicesComboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
                ServicesComboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
                ServicesComboBox.SelectedIndex = -1;

                HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
                DataTable TrafficTypeDataTable = new DataTable();
                TrafficTypeFactory.GetAllByCondition("[TrafficType_T].[TrafficTypeID_int] in (1,2,3,8)", ref TrafficTypeDataTable);
                TrafficTypeComboBox.DisplayMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString();
                TrafficTypeComboBox.ValueMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString();
                TrafficTypeComboBox.DataSource = TrafficTypeDataTable;
                TrafficTypeComboBox.SelectedIndex = -1;

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DataTable LaderTypeID_intDataTable = new DataTable();
                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AllIranianCarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AllIranianCarRadioButton.Checked == true)
            {
                LaderPivotGroupID_intComboBox.SelectedIndex = -1;
            }
        }

        private void LaderPivotGroupID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AllIranianCarRadioButton.Checked = false;
        }

        private void AllCountButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrafficTypeComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("نوع تردد را انتخاب کنید");
                }
                else 
                {
                    HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                    InNotOutTrafficstiReport.Dictionary.Synchronize();
                    InNotOutTrafficstiReport.Dictionary.Databases.Clear();
                    InNotOutTrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                    InNotOutTrafficstiReport.Compile();
                    InNotOutTrafficstiReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                    InNotOutTrafficstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + " " + PortPlaceFactory.ServerTime;
                    InNotOutTrafficstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                    InNotOutTrafficstiReport["@TrafficTypeID_int"] = (Int32)TrafficTypeComboBox.SelectedValue;
                   
                    InNotOutTrafficstiReport.Render();
                    stiViewerControl1.Report = InNotOutTrafficstiReport;
                    //if ((Int32)TrafficTypeComboBox.SelectedValue == 1)
                    //{
                    //    HPS.Reports.ReportDoc.InNotOutTrafficCountReport rpt = new HPS.Reports.ReportDoc.InNotOutTrafficCountReport(1);
                    //    rpt.Document.Printer.PrinterName = string.Empty;
                    //    viewer1.Document = rpt.Document;
                    //    rpt.Run();

                
                    //}
                    //if ((Int32)TrafficTypeComboBox.SelectedValue == 2||(Int32)TrafficTypeComboBox.SelectedValue == 3 || (Int32)TrafficTypeComboBox.SelectedValue == 8)
                    //{
                    //    HPS.Reports.ReportDoc.InNotOutTrafficCountReport rpt = new HPS.Reports.ReportDoc.InNotOutTrafficCountReport(2);
                    //    rpt.Document.Printer.PrinterName = string.Empty;
                    //    viewer1.Document = rpt.Document;
                    //    rpt.Run();
                        

                    //}
                    //else if ((Int32)TrafficTypeComboBox.SelectedValue == 3 || (Int32)TrafficTypeComboBox.SelectedValue == 8)
                    //{
                    //    HPS.Reports.ReportDoc.InNotOutTrafficCountReport rpt = new HPS.Reports.ReportDoc.InNotOutTrafficCountReport((Int32)TrafficTypeComboBox.SelectedValue);
                    //    rpt.Document.Printer.PrinterName = string.Empty;
                    //    viewer1.Document = rpt.Document;
                    //    rpt.Run();
                    //}
                }
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        
        }

        private void LaderPivotGroupID_intComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void devicesComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TrafficTypeComboBox.SelectedIndex == 0)
            {
                ServicesComboBox.Enabled = true;
            }
            else
            {
                ServicesComboBox.Enabled = false;
                ServicesComboBox.SelectedIndex = -1;
            }

        }

        private void ShowByLaderTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                    HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                   
                        InNotOutTrafficByLaderTypestiReport.Dictionary.Synchronize();
                        InNotOutTrafficByLaderTypestiReport.Dictionary.Databases.Clear();
                        InNotOutTrafficByLaderTypestiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                        InNotOutTrafficByLaderTypestiReport.Compile();
                        InNotOutTrafficByLaderTypestiReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                        InNotOutTrafficByLaderTypestiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + " " + PortPlaceFactory.ServerTime;
                        InNotOutTrafficByLaderTypestiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                        //InNotOutTrafficByLaderTypestiReport["@TrafficTypeID_int"] = (Int32)TrafficTypeComboBox.SelectedValue;
                        //if (ServicesComboBox.SelectedIndex == -1)
                        //{
                        //    InNotOutTrafficByLaderTypestiReport["@ServicesID_int"] = DBNull.Value;
                        //}
                        //else
                        //{
                        //    InNotOutTrafficByLaderTypestiReport["@ServicesID_int"] = (Int32)ServicesComboBox.SelectedValue;
                        //}
                        //if (LaderPivotGroupID_intComboBox.SelectedIndex == -1 || AllIranianCarRadioButton.Checked)
                        //{
                        //    InNotOutTrafficByLaderTypestiReport["@LaderPivotGroupID_int"] = DBNull.Value;
                        //}
                        //else
                        //{
                        //    InNotOutTrafficByLaderTypestiReport["@LaderPivotGroupID_int"] = (Int32)LaderPivotGroupID_intComboBox.SelectedValue;
                        //}
                        //if (LaderTypeID_intComboBox.SelectedIndex == -1 )
                        //{
                        //    InNotOutTrafficByLaderTypestiReport["@LaderTypeID_int"] = DBNull.Value;
                        //}
                        //else
                        //{
                        //    InNotOutTrafficByLaderTypestiReport["@LaderTypeID_int"] = (Int32)LaderTypeID_intComboBox.SelectedValue;
                        //}
                        
                        InNotOutTrafficByLaderTypestiReport.Render();
                        stiViewerControl1.Report = InNotOutTrafficByLaderTypestiReport;

               
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        
        }

        private void CalcPrice(DataTable TrafficDataTable)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
            DataTable LaderTypeDataTable = new DataTable();

            var stopFeeFactory = new BLL.StopFeeBLL.BLLStopFee_TFactory();
            var oldStopFeeEntity = new BLL.StopFeeBLL.BLLStopFee_T();
            var stopFeeKey = new BLL.StopFeeBLL.BLLStopFee_TKeys();
            string stopFeeCondition = string.Empty;
            decimal Price = 0;
            decimal pricTax = 0;
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_T TaxSettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            DataTable TrafficInWithladBillDataTable ;
            DataTable newStopFeeTable ;
            DataTable TrafficInDatatable ;
            string incondition = string.Empty;
            string Condition = string.Empty;
            try
            {
                foreach (DataRow item in TrafficDataTable.Rows)
                {
                    Hepsa.Core.Common.MyDateTime InDateTime = new Hepsa.Core.Common.MyDateTime(item["Date_nvc"].ToString());
                    Hepsa.Core.Common.MyDateTime OutDateTime = new Hepsa.Core.Common.MyDateTime(LaderTypeFactory.ServerJalaliDate);

                    string InDate = InDateTime.MyDate.ToString("yyyy/MM/dd");
                    string OutDate = OutDateTime.MyDate.ToString("yyyy/MM/dd");


                    if (InDate.Length == 16)
                        InDate += ":00";
                    else if (InDate.Length > 19)
                        InDate = InDate.Substring(0, 19);

                    if (OutDate.Length == 16)
                        OutDate += ":00";
                    else if (OutDate.Length > 19)
                        OutDate = OutDate.Substring(0, 19);

                    SettingKey.SettingID_int = 1011;
                    TaxSettingEntity = SettingFactory.GetBy(SettingKey);
                    
                    stopFeeKey.StopFeeID_int =Convert.ToInt32(item["StopFeeID_int"]);
                    oldStopFeeEntity = stopFeeFactory.GetBy(stopFeeKey);
                    if (oldStopFeeEntity.Tax_bit)
                    {
                        Price = Convert.ToDecimal(item["Fee_dec"]) * Int32.Parse(TaxSettingEntity.Value_nvc) / 100 + Convert.ToInt32(item["Fee_dec"]);
                        if (Convert.ToInt32(item["ServiceID_int"]) == 2)
                        {
                            Price = Math.Round((Convert.ToDecimal(item["Fee_dec"]) != 0 ? Convert.ToDecimal(item["Fee_dec"]) * Int32.Parse(TaxSettingEntity.Value_nvc) / 100 + Convert.ToDecimal(item["Fee_dec"]) : 0), 0, MidpointRounding.AwayFromZero);
                        }
                    }
                    else
                    {
                        Price = Convert.ToDecimal(item["Fee_dec"]);
                        if (Convert.ToInt32(item["ServiceID_int"]) == 2)
                        {
                            Price = Math.Round((Convert.ToDecimal(item["Fee_dec"]) != 0 ? Convert.ToDecimal(item["Fee_dec"]) : 0), 0, MidpointRounding.AwayFromZero);
                        }
                    }
                    incondition = string.Empty;
                    incondition = "Traffic_T.TrafficNumber_bint='" +item["TrafficNumber_bint"].ToString() + "'";
                    Condition = string.Empty;
                    Condition = string.Format("Traffic_T.TurnNumber_bint='{0}' And Traffic_T.TrafficNumber_bint<>{1}", item["TurnNumber_bint"].ToString(), item["TrafficNumber_bint"].ToString());
                    TrafficInWithladBillDataTable = new DataTable();
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(incondition, ref TrafficInWithladBillDataTable);
                    TrafficInDatatable = new DataTable();
                    TrafficFactory.GetAllByCondition(Condition, ref TrafficInDatatable);
                    SettingKey.SettingID_int = 1001;
                    SettingEntity = SettingFactory.GetBy(SettingKey);
                    if (TrafficInDatatable.Rows.Count > 0)
                    {
                        DateTime TrafficDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficInDatatable.Rows[0]["Date_nvc"].ToString())).MyDate.ToString("yyyy/MM/dd") + " " + TrafficInDatatable.Rows[0]["Time_nvc"].ToString());
                        Int32 Allowablehour = Convert.ToInt32(SettingEntity.Value_nvc);
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

                    if (Convert.ToInt32(item["TrafficTypeID_int"]) == 1)
                    {
                        var laderTypeEntity = new BLL.LaderTypeBLL.BLLLaderType_T();
                        LaderTypeKey.LaderTypeID_int =Convert.ToInt32(item["LaderTypeID_int"]);
                        laderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                        stopFeeCondition = string.Format(" StartDate_nvc>'{0}' AND StopFee_T.TrafficTypeID_int={1} AND StopFee_T.ServicesID_int={2} AND StopFee_T.LaderPivotGroupID_int={3}", oldStopFeeEntity.EndDate_nvc, Convert.ToInt32(item["TrafficTypeID_int"]), Convert.ToInt32(item["ServiceID_int"]), laderTypeEntity.LaderPivotGroupID_int);
                    }
                    else
                    {
                        stopFeeCondition = string.Format(" StartDate_nvc>'{0}' AND StopFee_T.TrafficTypeID_int={1}", oldStopFeeEntity.StartDate_nvc, Convert.ToInt32(item["TrafficTypeID_int"]));
                    }
                    newStopFeeTable = new DataTable();
                    stopFeeFactory.GetAllByCondition(stopFeeCondition, ref newStopFeeTable);

                    if (newStopFeeTable != null && newStopFeeTable.Rows.Count > 0)
                    {
                        Hepsa.Core.Common.MyDateTime stopFeeMiladiEndDate_nvc = new Hepsa.Core.Common.MyDateTime(oldStopFeeEntity.EndDate_nvc);
                        string stopFeeEndDate_nvc = stopFeeMiladiEndDate_nvc.MyDate.ToString("yyyy/MM/dd");
                        ts = DateTime.Parse(stopFeeEndDate_nvc).Subtract(DateTime.Parse(InDate));

                        if (Convert.ToBoolean(Convert.ToBoolean(item["TurnAccepted_bit"])) == true)
                        {
                            double ExtraHour = ts.TotalHours;                          
                            SettingKey.SettingID_int = 1002;
                            SettingEntity = SettingFactory.GetBy(SettingKey);
                            ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                            if (ExtraHour > 0)
                            {
                                ///محاسبه مازاد بر اساس قیمت قبلی از ورود تا شروع قیمت جدید
                                int days = (int)(ExtraHour / Convert.ToInt32(item["ExtraHour_int"]));
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(item["ExtraHourFee_dec"]));
                            }

                            Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                            string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");
                            TimeSpan ExtaTS = DateTime.Parse(newStopFeeStartDate_nvc).Subtract(DateTime.Parse(InDate));
                            double ExtraExtraHour = ExtaTS.TotalHours;
                            if (ExtraExtraHour < Convert.ToDouble(SettingEntity.Value_nvc))
                            {
                                ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                                if (ExtraHour >= 0)
                                    ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(InDate));
                                else
                                    ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(InDate));


                                ExtraHour = ts.TotalHours - Convert.ToDouble(SettingEntity.Value_nvc);
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
                            if (Convert.ToDecimal(item["ExtraHourFee_dec"]) != 0)
                            {
                                ///محاسبه مازاد بر اساس قیمت قبلی از ورود تا شروع قیمت جدید
                                double ExtraHour = ts.TotalHours - Convert.ToDouble(item["AllowableHour_int"]);
                                int days = Convert.ToInt32((ExtraHour / Convert.ToInt32(item["ExtraHour_int"])));
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(item["ExtraHourFee_dec"]));

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

                        if (ts.TotalHours > Convert.ToInt32(item["AllowableHour_int"]))
                        {
                            if (item["TurnAccepted_bit"] != DBNull.Value && Convert.ToBoolean(item["TurnAccepted_bit"]) == true)
                            {
                                double ExtraHour = ts.TotalHours;
                                SettingKey.SettingID_int = 1002;
                                SettingEntity =SettingFactory.GetBy(SettingKey);
                                if (Convert.ToDecimal(item["Price_dec"]) != 0)
                                {
                                    ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                                }

                                if (ExtraHour > 0)
                                {
                                    int days = (int)(ExtraHour / Convert.ToInt32(item["ExtraHour_int"]));
                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(item["ExtraHourFee_dec"]));
                                }

                                else
                                {
                                    Price = 0;
                                }
                            }
                            else
                            {
                                if (Convert.ToInt32(item["ExtraHourFee_dec"]) != 0)
                                {
                                    double ExtraHour = ts.TotalHours - Convert.ToDouble(item["AllowableHour_int"]);
                                    int days = (int)(ExtraHour / Convert.ToInt32(item["ExtraHour_int"]));
                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(item["ExtraHourFee_dec"]));
                                }
                            }

                        }
                    }
                    Price = Convert.ToDecimal(RoundNumber(Convert.ToDouble(Price)));
                    Balanced = Convert.ToDecimal(RoundNumber(Convert.ToDouble(Balanced)));
                    if (item["Price_dec"]!=DBNull.Value)
                        Balanced = Convert.ToDecimal(item["Price_dec"]);

                    item["AllPayment_dec"]= Convert.ToString(Price);  //Payable_dec
                    //this.Balanced_decNumericTextBox.Text = Convert.ToString(Balanced);
                    if (Price == Balanced)
                    {
                        item["Remained_dec"] = "0";
                    }
                    else
                    {
                        pricTax = 0;
                        if (oldStopFeeEntity.Tax_bit)
                        {
                            item["Remained_dec"] = Convert.ToString((Price - Balanced));//
                            pricTax = (Price - Balanced) * Int32.Parse(TaxSettingEntity.Value_nvc) / 100;
                        }
                        else
                            item["Remained_dec"] = Convert.ToString((Price - Balanced));//
                    }
                    if ((Price - Balanced) < 0)
                    {
                        pricTax = 0;
                        if (oldStopFeeEntity.Tax_bit)
                        {
                            item["Remained_dec"] = Convert.ToString((Price));
                            pricTax = (Price) * Int32.Parse(TaxSettingEntity.Value_nvc) / 100;
                        }
                        else
                            item["Remained_dec"] = Convert.ToString((Price));
                    }

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        private double RoundNumber(double number)
        {
            number = Math.Round(number);

            if (number > 5000)
            {
                double khord = number % 5000;
                if (khord == 0)
                {
                    return number;
                }
                else if (khord > 0 && khord < 2499)
                {
                    return number - khord;
                }
                else if (khord > 2500 && khord < 5000)
                {
                    return number - khord + 5000;
                }
                else
                {
                    return number;
                }
            }
            else
            {
                return number;
            }
        }

    }
}


