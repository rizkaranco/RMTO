using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DT = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;
using EX= Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace HPS.Reports.Forms
{
    public partial class InTrafficReportForm : Hepsa.Core.PL.BaseForm
    {
        private int _TrafficType = 0;
        public InTrafficReportForm(int TrafficType)
        {
            InitializeComponent();
            this._TrafficType = TrafficType;
            if (_TrafficType==2)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                
            }
            else if (_TrafficType == 0)
            {
                TrafficTypeID_intComboBox.Visible = true;
                label9.Visible = true;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        DT.DataTable ExportExcelDt = new DT.DataTable();
        private void ShowButton_Click(object sender, EventArgs e)
        {

            BLL.TrafficBLL.BLLTraffic_TFactory factory = new BLL.TrafficBLL.BLLTraffic_TFactory();

            DT.DataTable dt;

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
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }

                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)))
                {
                    throw new ApplicationException("تا ساعت خالی است");
                }

                Hepsa.Core.Validation.TimeRule<string> FromTimeValidator = new Hepsa.Core.Validation.TimeRule<string>("FromTime", "از ساعت", null, null);
                if (FromTimeValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)) == false)
                {
                    throw new ApplicationException(FromTimeValidator.Description);
                }

                Hepsa.Core.Validation.TimeRule<string> ToTimeValidator = new Hepsa.Core.Validation.TimeRule<string>("ToTime", "تا ساعت", null, null);
                if (ToTimeValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)) == false)
                {
                    throw new ApplicationException(ToTimeValidator.Description);
                }

                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);
           

                if (_TrafficType == 1)
                {
                    string Turn = string.Empty;
                    if (TurnAcceptedradioButton.Checked == true)
                    {
                        Turn = "Traffic_T.TurnAccepted_bit=1 ";
                    }
                   else if (AllTurnradioButton.Checked == true)
                    {
                        Turn = "Traffic_T.TurnAccepted_bit IS NULL";
                    }
                    if (!string.IsNullOrEmpty(Turn))
                    {
                        Turn +=" AND ";
                    }

                    Turn += " Traffic_T.TrafficNumber_bint NOT IN (SELECT trafficNumber_bint  FROM   Traffic_T  WHERE  Traffic_T.Out_bit = 1 AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc >= '" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "') AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc <='" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "') )  AND Traffic_T.TrafficNumber_bint NOT IN (SELECT trafficNumber_bint  FROM   Traffic_T  WHERE  Traffic_T.TemporaryOut_bit = 1 AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc >= '" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "') AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc <='" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "')) AND ";

                    //HPS.Reports.ReportDoc.IranianInTrafficReport rpt = new HPS.Reports.ReportDoc.IranianInTrafficReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, "1", FromTimeTextBox.Text, ToTimeTextBox.Text, FromTrafficNumbertxt.Text, ToTrafficNumbertxt.Text,
                    //    Convert.ToString(LaderPivotGroupID_intComboBox.SelectedValue), Convert.ToString(LaderTypeID_intComboBox.SelectedValue), Convert.ToString(ServicescomboBox.SelectedValue), Turn);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //viewer1.Document = rpt.Document;
                    //rpt.Run();
                    
                    IranianInTrafficstiReport.Dictionary.Synchronize();
                    IranianInTrafficstiReport.Dictionary.Databases.Clear();
                    IranianInTrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                    IranianInTrafficstiReport.Compile();
                    IranianInTrafficstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                    HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                    IranianInTrafficstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                    IranianInTrafficstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                    IranianInTrafficstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                    IranianInTrafficstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                    IranianInTrafficstiReport["fromTrafficNumber"] = FromTrafficNumbertxt.Text;
                    IranianInTrafficstiReport["toTrafficNumber"] = ToTrafficNumbertxt.Text;
                    IranianInTrafficstiReport["FromTime_vc"] = FromTimeTextBox.Text;
                    IranianInTrafficstiReport["ToTime_vc"] = ToTimeTextBox.Text;
                    if (string.IsNullOrEmpty(FromDatefaDatePicker.Text))
                        IranianInTrafficstiReport["@FromDateTime_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@FromDateTime_nvc"] = FromDatefaDatePicker.Text + ' ' + FromTimeTextBox.Text;

                    if (string.IsNullOrEmpty(ToDatefaDatePicker.Text))
                        IranianInTrafficstiReport["@ToDateTime_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@ToDateTime_nvc"] = ToDatefaDatePicker.Text + ' ' + ToTimeTextBox.Text;

                    if (string.IsNullOrEmpty(FromTrafficNumbertxt.Text))
                        IranianInTrafficstiReport["@FromTrafficNumber_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@FromTrafficNumber_nvc"] = FromTrafficNumbertxt.Text;

                    if (string.IsNullOrEmpty(ToTrafficNumbertxt.Text))
                        IranianInTrafficstiReport["@ToTrafficNumber_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@ToTrafficNumber_nvc"] = ToTrafficNumbertxt.Text;

                    if (LaderPivotGroupID_intComboBox.SelectedValue == null)
                        IranianInTrafficstiReport["@LaderPivotGroupID_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@LaderPivotGroupID_nvc"] = LaderPivotGroupID_intComboBox.SelectedValue;
                    //@LaderTypeID_nvc
                    if (LaderTypeID_intComboBox.SelectedValue == null)
                        IranianInTrafficstiReport["@LaderTypeID_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@LaderTypeID_nvc"] = LaderTypeID_intComboBox.SelectedValue;
                    //@ServiceID_nvc
                    if (ServicescomboBox.SelectedValue == null)
                        IranianInTrafficstiReport["@ServiceID_nvc"] = DBNull.Value;
                    else
                        IranianInTrafficstiReport["@ServiceID_nvc"] = ServicescomboBox.SelectedValue;
                    //                @TrafficTypeID_nvc  ,
                    IranianInTrafficstiReport["@TrafficTypeID_nvc"] = 1;

                    IranianInTrafficstiReport["@TrafficInbit_nvc"] = 1;

                    IranianInTrafficstiReport["@TrafficOutbit_nvc"] = DBNull.Value;

                    IranianInTrafficstiReport["@TurnAccepted_nvc"] = Turn;

                    if (LaderPivotGroupID_intComboBox.SelectedValue != null)
                    {
                        if (Convert.ToInt32(LaderPivotGroupID_intComboBox.SelectedValue) == 1)
                        {
                            IranianInTrafficstiReport["PivotGrouptxt"] = "(دو محور)";
                        }

                        else if (Convert.ToInt32(LaderPivotGroupID_intComboBox.SelectedValue) == 2)
                        {
                            IranianInTrafficstiReport["PivotGrouptxt"] = "(سه محور به بالا)";
                        }
                    }

                    else
                    {
                        IranianInTrafficstiReport["PivotGrouptxt"] = "(تمامی کامیون ها)";
                    }
                    if (LaderTypeID_intComboBox.SelectedValue != null)
                    {
                        IranianInTrafficstiReport["PivotGrouptxt"] = (string)Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(this.LaderTypeID_intComboBox);
                    }

                    IranianInTrafficstiReport.Render();
                    stiViewerControl1.Report = IranianInTrafficstiReport;

                    dt = new DT.DataTable();
                    ExportExcelDt = new System.Data.DataTable();
                    factory.ReportSelectByFieds(
                        IranianInTrafficstiReport["@FromDateTime_nvc"],
                        IranianInTrafficstiReport["@ToDateTime_nvc"],
                        IranianInTrafficstiReport["@FromTrafficNumber_nvc"],
                        IranianInTrafficstiReport["@ToTrafficNumber_nvc"],
                        IranianInTrafficstiReport["@LaderPivotGroupID_nvc"],
                        IranianInTrafficstiReport["@LaderTypeID_nvc"],
                        IranianInTrafficstiReport["@TrafficTypeID_nvc"],
                        IranianInTrafficstiReport["@TrafficInbit_nvc"],
                        IranianInTrafficstiReport["@TrafficOutbit_nvc"],
                        IranianInTrafficstiReport["@ServiceID_nvc"],
                         Turn, ref dt);

                    Dictionary<string, string> Columns = new Dictionary<string, string>();
                    Columns.Add("TrafficNumber_bint", "شماره قبض");
                    Columns.Add("TurnNumber_bint", "شماره نوبت");
                    Columns.Add("DriverCardNumber_nvc", "شماره کارت راننده ");
                    Columns.Add("carCardNumber_nvc", "شماره کارت ناوگان");
                    Columns.Add("FirstName_nvc", "نام راننده");
                    Columns.Add("LastName_nvc", "نام خانوادگی راننده");
                    Columns.Add("NumberPlate_nvc", "شماره پلاک");
                    Columns.Add("UserName_nvc", "کاربر");
                    Columns.Add("Date_nvc", "تاریخ ورود");
                    Columns.Add("Time_nvc", "زمان ورود");
                    Columns.Add("EditUserName_nvc", "کاربر تایید کننده");
                    Columns.Add("TurnDate_nvc", "ترایخ نوبت");
                    Columns.Add("TurnTime_nvc", "زمان نوبت");
                    Columns.Add("PriceNoTax_dec", "مبلغ");
                    Columns.Add("PriceTax_dec", "ارزش افزوده");
                    Columns.Add("Price_dec", "مبلغ دریافتی");
                    Columns.Add("WithLade_bit", "با بار");
                    Columns.Add("ServiceID_intServiceType_nvc", "مراجعه به");

                    foreach (var col in Columns)
                    {
                        ExportExcelDt.Columns.Add(col.Value,col.Key.EndsWith("_bit") ? typeof(bool) : typeof(string));
                    }

                    DataRow dr;
                    
                    for (int i = 0; i <= dt.Rows.Count-1;i++)
                    {
                        dr = ExportExcelDt.NewRow();
                        for (int j=0;j<Columns.Count;j++)
                          dr[j] = dt.Rows[i][Columns.Keys.ElementAt(j)];

                        ExportExcelDt.Rows.Add(dr);
                    }
                    
                    
                   
                    //gridControl1.DataSource = dt;
                    //gridView1.Columns.Clear();
                    ////gridView1.PopulateColumns();

                    //GridColumn column;
                    //int x = 0;
                    //foreach (DataColumn i in dt.Columns)
                    //{
                    //    x++;
                    //    if (x == 6)
                    //        break;
                    //    column = new GridColumn() { FieldName = i.ColumnName,Width = 200,MinWidth = 200,MaxWidth = 200};
                    //    Columns.Add();
                    //}
                    //gridView1.PopulateColumns(Columns);
                    //gridView1.RefreshData();
                    //foreach (GridColumn clm in gridView1.Columns)
                    //{
                    //    clm.Width  = clm.MinWidth = clm.MaxWidth = 200;
                    //}


                }
                if (_TrafficType == 2)
                {
                    //HPS.Reports.ReportDoc.ForeignInTrafficReport rpt = new HPS.Reports.ReportDoc.ForeignInTrafficReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, 2, FromTimeTextBox.Text, ToTimeTextBox.Text, FromTrafficNumbertxt.Text, ToTrafficNumbertxt.Text);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //viewer1.Document = rpt.Document;
                    //rpt.Run();
                    HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                    DT.DataTable TrafficDataTable = new DT.DataTable();
                    string Condition = string.Empty;
                    string FromTime = FromTimeTextBox.Text;
                    string ToTime = ToTimeTextBox.Text;
                    string FromTrafficNumber = FromTrafficNumbertxt.Text;
                    string ToTrafficNumber = ToTrafficNumbertxt.Text;
                    string FromDate = FromDatefaDatePicker.Text;
                    string ToDate = ToDatefaDatePicker.Text;
                    if (!(string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)) && (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)))
                    {
                        Condition = "(T.In_bit='True') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                    }
                    else if (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime) && (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                    {
                        Condition = "(T.In_bit='True') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "')";
                    }
                    else if (!(string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber))
                    {
                        Condition = "(T.In_bit='True') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc+ ' ' +T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "')";
                    }

                    else if (!((string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                    {
                        Condition = "(T.In_bit='True') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc + ' ' + T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                    }

                    dt = new DT.DataTable();
                    ExportExcelDt = new System.Data.DataTable();
                    ForeignInTrafficReportStiReport.Dictionary.Synchronize();
                    ForeignInTrafficReportStiReport.Dictionary.Databases.Clear();
                    ForeignInTrafficReportStiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                    ForeignInTrafficReportStiReport.Compile();
                    ForeignInTrafficReportStiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                    HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                    ForeignInTrafficReportStiReport["@Condition"] = Condition;
                    ForeignInTrafficReportStiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                    ForeignInTrafficReportStiReport["todate_vc"] = ToDatefaDatePicker.Text;
                    ForeignInTrafficReportStiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                    ForeignInTrafficReportStiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                    ForeignInTrafficReportStiReport["fromTrafficNumber"] = FromTrafficNumbertxt.Text;
                    ForeignInTrafficReportStiReport["toTrafficNumber"] = ToTrafficNumbertxt.Text;
                    ForeignInTrafficReportStiReport["FromTime_vc"] = FromTimeTextBox.Text;
                    ForeignInTrafficReportStiReport["ToTime_vc"] = ToTimeTextBox.Text;
                    ForeignInTrafficReportStiReport.Render();
                    stiViewerControl1.Report = ForeignInTrafficReportStiReport;
                    factory.GetAllByConditionAllTraffic(Condition, ref dt);

                    Dictionary<string, string> Columns = new Dictionary<string, string>();
                    Columns.Add("TrafficNumber_bint", "شماره قبض");
                    //Columns.Add("TurnNumber_bint", "شماره نوبت");
                    //Columns.Add("DriverCardNumber_nvc", "شماره کارت راننده ");
                    //Columns.Add("carCardNumber_nvc", "شماره کارت ناوگان");
                    Columns.Add("FirstName_nvc", "نام راننده");
                    Columns.Add("LastName_nvc", "نام خانوادگی راننده");
                    Columns.Add("NumberPlate_nvc", "شماره پلاک");
                    Columns.Add("UserName_nvc", "کاربر");
                    Columns.Add("Date_nvc", "تاریخ ورود");
                    Columns.Add("Time_nvc", "زمان ورود");
                    Columns.Add("EditUserName_nvc", "کاربر تایید کننده");
                    //Columns.Add("TurnDate_nvc", "تاریخ نوبت");
                    //Columns.Add("TurnTime_nvc", "زمان نوبت");
                    Columns.Add("PriceNoTax_dec", "مبلغ");
                    Columns.Add("PriceTax_dec", "ارزش افزوده");
                    Columns.Add("Price_dec", "مبلغ دریافتی");
                    Columns.Add("WithLade_bit", "با بار");
                    Columns.Add("ServiceID_intServiceType_nvc", "مراجعه به");

                    foreach (var col in Columns)
                    {
                        ExportExcelDt.Columns.Add(col.Value, col.Key.EndsWith("_bit") ? typeof(bool) : typeof(string));
                    }

                    DataRow dr;

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        dr = ExportExcelDt.NewRow();
                        for (int j = 0; j < Columns.Count; j++)
                            dr[j] = dt.Rows[i][Columns.Keys.ElementAt(j)];

                        ExportExcelDt.Rows.Add(dr);
                    }
                }
                if (_TrafficType == 0)
                {
                    string turn = string.Empty;
                    turn = " Traffic_T.TrafficNumber_bint NOT IN (SELECT trafficNumber_bint  FROM   Traffic_T  WHERE  Traffic_T.Out_bit = 1 AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc >= '" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "') AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc <='" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "'))  AND Traffic_T.TrafficNumber_bint NOT IN (SELECT trafficNumber_bint  FROM   Traffic_T  WHERE  Traffic_T.TemporaryOut_bit = 1 AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc >= '" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "') AND (Traffic_T.Date_nvc + ' ' + Traffic_T.Time_nvc <='" + FromDatefaDatePicker.Text + " " + ToDatefaDatePicker.Text + "')) AND ";
                    //HPS.Reports.ReportDoc.OtherInReport rpt = new HPS.Reports.ReportDoc.OtherInReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, FromTimeTextBox.Text,
                    //    ToTimeTextBox.Text, FromTrafficNumbertxt.Text, ToTrafficNumbertxt.Text, Convert.ToString(TrafficTypeID_intComboBox.SelectedValue), Convert.ToString(ServicescomboBox.SelectedValue), turn);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //viewer1.Document = rpt.Document;
                    //rpt.Run();

                    OtherInTrafficStiReport.Dictionary.Synchronize();
                    OtherInTrafficStiReport.Dictionary.Databases.Clear();
                    OtherInTrafficStiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                    OtherInTrafficStiReport.Compile();
                    OtherInTrafficStiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                    HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                    OtherInTrafficStiReport["@FromDateTime_nvc"] = FromDatefaDatePicker.Text + ' ' + FromTimeTextBox.Text;
                    OtherInTrafficStiReport["@ToDateTime_nvc"] =ToDatefaDatePicker.Text+ ' ' + ToTimeTextBox.Text;
                    if (string.IsNullOrEmpty( FromTrafficNumbertxt.Text))
                        OtherInTrafficStiReport["@FromTrafficNumber_nvc"] = DBNull.Value;
                    else
                        OtherInTrafficStiReport["@FromTrafficNumber_nvc"] = FromTrafficNumbertxt.Text;

                    if (string.IsNullOrEmpty(ToTrafficNumbertxt.Text))
                        OtherInTrafficStiReport["@ToTrafficNumber_nvc"] = DBNull.Value;
                    else
                        OtherInTrafficStiReport["@ToTrafficNumber_nvc"] = ToTrafficNumbertxt.Text;

                        OtherInTrafficStiReport["@LaderPivotGroupID_nvc"] =DBNull.Value;
                        OtherInTrafficStiReport["@LaderTypeID_nvc"] =DBNull.Value;
                        OtherInTrafficStiReport["@TrafficTypeID_nvc"] =Convert.ToString(TrafficTypeID_intComboBox.SelectedValue);
                        OtherInTrafficStiReport["@TrafficInbit_nvc"] ="1";
                        OtherInTrafficStiReport["@TrafficOutbit_nvc"] =DBNull.Value;

                        if (string.IsNullOrEmpty(Convert.ToString(ServicescomboBox.SelectedValue)))
                            OtherInTrafficStiReport["@ServiceID_nvc"] = DBNull.Value;
                    else
                        OtherInTrafficStiReport["@ServiceID_nvc"] = Convert.ToString(ServicescomboBox.SelectedValue);

                     OtherInTrafficStiReport["@TurnAccepted_nvc"] = turn;
                    OtherInTrafficStiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                    OtherInTrafficStiReport["todate_vc"] = ToDatefaDatePicker.Text;
                    OtherInTrafficStiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                    OtherInTrafficStiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                    OtherInTrafficStiReport["FromTime_vc"] = FromTimeTextBox.Text;
                    OtherInTrafficStiReport["ToTime_vc"] = ToTimeTextBox.Text;
                    OtherInTrafficStiReport.Render();
                    stiViewerControl1.Report = OtherInTrafficStiReport;




                    dt = new DT.DataTable();
                    ExportExcelDt = new System.Data.DataTable();
                    factory.ReportSelectByFieds(
                        OtherInTrafficStiReport["@FromDateTime_nvc"],
                        OtherInTrafficStiReport["@ToDateTime_nvc"],
                        OtherInTrafficStiReport["@FromTrafficNumber_nvc"],
                        OtherInTrafficStiReport["@ToTrafficNumber_nvc"],
                        OtherInTrafficStiReport["@LaderPivotGroupID_nvc"],
                        OtherInTrafficStiReport["@LaderTypeID_nvc"],
                        OtherInTrafficStiReport["@TrafficTypeID_nvc"],
                        OtherInTrafficStiReport["@TrafficInbit_nvc"],
                        OtherInTrafficStiReport["@TrafficOutbit_nvc"],
                        OtherInTrafficStiReport["@ServiceID_nvc"],
                         "", ref dt);


                    Dictionary<string, string> Columns = new Dictionary<string, string>();
                    Columns.Add("TrafficNumber_bint", "شماره قبض");
                    //Columns.Add("TurnNumber_bint", "شماره نوبت");
                    //Columns.Add("DriverCardNumber_nvc", "شماره کارت راننده ");
                    //Columns.Add("carCardNumber_nvc", "شماره کارت ناوگان");
                    Columns.Add("FirstName_nvc", "نام راننده");
                    Columns.Add("LastName_nvc", "نام خانوادگی راننده");
                    Columns.Add("NumberPlate_nvc", "شماره پلاک");
                    Columns.Add("UserName_nvc", "کاربر");
                    Columns.Add("Date_nvc", "تاریخ ورود");
                    Columns.Add("Time_nvc", "زمان ورود");
                    // Columns.Add("EditUserName_nvc", "کاربر تایید کننده");
                    //Columns.Add("TurnDate_nvc", "تاریخ نوبت");
                    //Columns.Add("TurnTime_nvc", "زمان نوبت");
                    Columns.Add("PriceNoTax_dec", "مبلغ");
                    Columns.Add("PriceTax_dec", "ارزش افزوده");
                    Columns.Add("Price_dec", "مبلغ دریافتی");
                   // Columns.Add("WithLade_bit", "با بار");
                    Columns.Add("ServiceID_intServiceType_nvc", "مراجعه به");

                    foreach (var col in Columns)
                    {
                        ExportExcelDt.Columns.Add(col.Value, col.Key.EndsWith("_bit") ? typeof(bool) : typeof(string));
                    }

                    DataRow dr;

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        dr = ExportExcelDt.NewRow();
                        for (int j = 0; j < Columns.Count; j++)
                            dr[j] = dt.Rows[i][Columns.Keys.ElementAt(j)];

                        ExportExcelDt.Rows.Add(dr);
                    }

                }


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            
        }


        void CreateExcel(DT.DataTable dtTable, string PathFileName)
        {
            try
            {
                
                var excel = new EX.Excel.Application { Visible = false };
                var misValue = System.Reflection.Missing.Value;
                var wb = excel.Workbooks.Add(misValue);
                //var wb = excel.Workbooks.Open(PathFileName);
               
                EX.Excel.Worksheet sh = wb.Sheets.Add();
                sh.Name = "گزارش";
                string Headers = "ABCDEFGHIJKLMNOPQRSTUVWXZ";
                int index = 0;
                
                foreach (DataColumn column in dtTable.Columns)
                {
                    if (index >= Headers.Length)
                        break;
                    sh.Cells[1, Headers[index].ToString()].Value2 = column.ColumnName;
                    index++;
                }

                /* Insert Rows */
                object x;
                for (int i = 0; i < dtTable.Rows.Count; i++)
                {
                    for (int j = 0; j < index; j++)
                    {
                        x = dtTable.Rows[i][j];
                        if (x.GetType() == typeof(bool))
                        {
                            if ((bool)x)
                                sh.Cells[i + 2, Headers[j].ToString()].Value2 = "بله";
                            else
                                sh.Cells[i + 2, Headers[j].ToString()].Value2 = "خیر";
                        }
                        else
                            sh.Cells[i + 2, Headers[j].ToString()].Value2 = dtTable.Rows[i][j];

                    }
                }

                wb.SaveAs(PathFileName, EX.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, EX.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                wb.Close(true);
                excel.Quit();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void InTrafficReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillCombo();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        
        private void FillCombo()
        {
            try
            {
                HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupID_intFactory = new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
                DT.DataTable LaderPivotGroupID_intDataTable = new DT.DataTable();
                LaderPivotGroupID_intFactory.GetAll(ref LaderPivotGroupID_intDataTable);
                this.LaderPivotGroupID_intComboBox.DisplayMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString();
                this.LaderPivotGroupID_intComboBox.ValueMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString();
                this.LaderPivotGroupID_intComboBox.DataSource = LaderPivotGroupID_intDataTable;
                this.LaderPivotGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DT.DataTable LaderTypeID_intDataTable = new DT.DataTable();
                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
                DT.DataTable ServicesDataTable = new DT.DataTable();
                string condition = "[Services_T].[Activie_bit]='true'";
                ServicesFactory.GetAllByCondition(condition, ref ServicesDataTable);
                ServicescomboBox.DataSource = ServicesDataTable;
                ServicescomboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
                ServicescomboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
                ServicescomboBox.SelectedIndex = -1;


                HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
                string TrafficTypeCondition = "[TrafficType_T].[TrafficTypeID_int]!=1 And [TrafficType_T].[TrafficTypeID_int]!=2";
                DT.DataTable TrafficTypeDataTable = new DT.DataTable();
                TrafficTypeFactory.GetAllByCondition(TrafficTypeCondition, ref TrafficTypeDataTable);
                TrafficTypeID_intComboBox.DataSource = TrafficTypeDataTable;
                TrafficTypeID_intComboBox.DisplayMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString();
                TrafficTypeID_intComboBox.ValueMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString();
                TrafficTypeID_intComboBox.SelectedIndex = 0;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AllIranianCarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AllIranianCarRadioButton.Checked==true)
            {
                LaderPivotGroupID_intComboBox.SelectedIndex = -1;
            }
        }

        private void LaderPivotGroupID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AllIranianCarRadioButton.Checked = false;
        }

        private void LaderType_nvcSearchButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.LaderTypeSearch frm = new HPS.Present.SearchForm.LaderTypeSearch();
            frm.ShowDialog();
            try
            {
                if (frm != null)
                {
                    LaderTypeID_intComboBox.Text = frm.SelectedLaderTypeEntity.LaderType_nvc;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void DefaulCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (DefaulCheckBox.Checked)
                {
                    TimeGroupBox.Enabled = true;
                    RefreshHourbutton.PerformClick();
                }
                else
                {
                    TimeGroupBox.Enabled = false;
                    FromTimeTextBox.Text = "00:00:00";
                    ToTimeTextBox.Text = "23:59:59";
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void ExportExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "*.xlx | Excel File";

            if (save.ShowDialog() == DialogResult.OK)
            {
                CreateExcel(ExportExcelDt,save.FileName);
            }
        }
    }
}
