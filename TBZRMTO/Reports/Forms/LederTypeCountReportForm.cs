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
    public partial class LederTypeCountReportForm : Hepsa.Core.PL.BaseForm
    {
        public LederTypeCountReportForm()
        {
            InitializeComponent();
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExistsLaderTypeGridView.Visible = false;

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
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);
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

                object[]  LaderTypeList=new object[100];
                string LaderTypeList_nvc = string.Empty;
                int index = 0;
                LaderTypeList = LaderTypecheckedComboBox.CheckedValues;
                if (LaderTypeList != null)
                {
                    foreach (object obj in LaderTypeList)
                    {
                        LaderTypeList_nvc = string.Format("{0},{1}", LaderTypeList_nvc, LaderTypeList[index].ToString());
                        index += 1;
                    }
                    LaderTypeList_nvc = LaderTypeList_nvc.Substring(1, LaderTypeList_nvc.Length - 1);

                }
                //HPS.Reports.ReportDoc.LaderTypeCountReport rpt = new HPS.Reports.ReportDoc.LaderTypeCountReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();

                //پر کردن دیتا تیبل
                //HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                //DataTable LaderTypeReportTable = new DataTable();
                //DataSet LaderTypeDataSet = new DataSet();
                //LadeAssignmentFactory.SelectLaderTypeCountReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox .Text, LaderTypeList_nvc, ref LaderTypeReportTable);
                ////اضافه کردن ستون جدید به جدول
                //if (LaderTypeReportTable != null && LaderTypeReportTable.Rows.Count > 0)
                //{
                //    LaderTypeReportTable.Columns.Add("RemainedPercent");
                //    foreach (DataRow row in LaderTypeReportTable.Rows)
                //    {
                //        double RemainedPercent = (Convert.ToDouble(row["RemainderCar_int"]) * 100) / Convert.ToDouble(row["CarCount_int"]);

                //        row["RemainedPercent"] = RemainedPercent.ToString("0.##");
                //    }
                //}
                //Int64? AllLadeAssignmentcount = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CarCount_int"]).Sum();

                //Int64? AllLadBillcountRecords = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["LadBill"]).Sum();

                //Int64? allcanceledByCompany = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CanceledByCompany"]).Sum();

                //Int64? allcanceledByLadBillCanceled = (from row in LaderTypeReportTable.AsEnumerable() select (Int32)row["CanceledByLadBillCanceled"]).Sum();

                ////AllRemainderCounttxt.Text = (Convert.ToInt64(AllLadeAssignmentcount) - Convert.ToInt64(AllLadBillcountRecords) - Convert.ToInt64(allcanceledByCompany) - Convert.ToInt64(allcanceledByLadBillCanceled)).ToString(); //Allremaindercount.HasValue ? Allremaindercount.ToString() : "0";

                //AllRemainedPercenttxt.Text = ((Convert.ToDouble(AllRemainderCounttxt.Text)) * 100 / (Convert.ToDouble(AllLadeAssignmentCountxt.Text))).ToString("0.##");
       
                //اضافه کردن دیتاتیبل به دیتا ست
                //LaderTypeDataSet.Tables.Add(LaderTypeReportTable.Copy());
                //کدهای استیمیول
                LederTypeCountReportstiReport.Dictionary.Synchronize();
                LederTypeCountReportstiReport.Dictionary.Databases.Clear();
                LederTypeCountReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LederTypeCountReportstiReport.Compile();
                LederTypeCountReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                //مقدار دهی متغیرها
                LederTypeCountReportstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                LederTypeCountReportstiReport["fromTime_nvc"] = FromTimeTextBox.Text;
                LederTypeCountReportstiReport["toTime_nvc"] = ToTimeTextBox.Text;
                LederTypeCountReportstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                LederTypeCountReportstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                LederTypeCountReportstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                LederTypeCountReportstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                LederTypeCountReportstiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                LederTypeCountReportstiReport["@totime_nvc"] = ToTimeTextBox.Text;
                LederTypeCountReportstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                if (!(LaderTypeList_nvc == ""))
                {
                    LederTypeCountReportstiReport["@LaderTypeList"] = LaderTypeList_nvc;
                }
                //LederTypeCountReportstiReport["@CompanyID_int"] = FromDatefaDatePicker.Text;
                //LederTypeCountReportstiReport["@GoodIDList_nvc"] = FromTimeTextBox.Text;
                //LederTypeCountReportstiReport["@DestinationCityIDList_nvc"] = ToTimeTextBox.Text;
                //LederTypeCountReportstiReport["@PortPlaceIDList_nvc"] = ToDatefaDatePicker.Text;
                //LederTypeCountReportstiReport["@OrderColumns_nvc"] = LaderTypeList_nvc;
                LederTypeCountReportstiReport.Render();
                //LederTypeCountReportstiReport.Show();
                stiViewerControl1.Report = LederTypeCountReportstiReport;



            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void WithDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExistsLaderTypeGridView.Visible = false;
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
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);
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


                object[] LaderTypeList = new object[100];
                string LaderTypeList_nvc = string.Empty;
                int index = 0;
                LaderTypeList = LaderTypecheckedComboBox.CheckedValues;
                if (LaderTypeList != null)
                {
                    foreach (object obj in LaderTypeList)
                    {
                        LaderTypeList_nvc = string.Format("{0},{1}", LaderTypeList_nvc, LaderTypeList[index].ToString());
                        index += 1;
                    }
                    LaderTypeList_nvc = LaderTypeList_nvc.Substring(1, LaderTypeList_nvc.Length - 1);

                }

                //HPS.Reports.ReportDoc.LaderTypeCountWithDateReport rpt = new HPS.Reports.ReportDoc.LaderTypeCountWithDateReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();
                //HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                //DataTable LaderTypeReportTable = new DataTable();
                //LadeAssignmentFactory.SelectLaderTypeCountWithDateReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, FromTimeTextBox.Text, ToTimeTextBox .Text, LaderTypeList_nvc, ref LaderTypeReportTable);
                //DataSet LaderTypeCountWithDate = new DataSet();

                //اضافه کردن دیتاتیبل به دیتا ست
                //کدهای استیمیول
               //LaderTypeCountWithDateReportstiReport.Dictionary.Synchronize();
               //LaderTypeCountWithDateReportstiReport.Dictionary.Databases.Clone();
               //LaderTypeCountWithDateReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
               //LaderTypeCountWithDateReportstiReport.Compile();
               //HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
               // //مقدار دهی متغیرها
               //LaderTypeCountWithDateReportstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
               //LaderTypeCountWithDateReportstiReport["fromTime_nvc"] = FromTimeTextBox.Text;
               //LaderTypeCountWithDateReportstiReport["toTime_nvc"] = ToTimeTextBox.Text;
               //LaderTypeCountWithDateReportstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
               //LaderTypeCountWithDateReportstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
               //LaderTypeCountWithDateReportstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
               //LaderTypeCountWithDateReportstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
               //LaderTypeCountWithDateReportstiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
               //LaderTypeCountWithDateReportstiReport["@totime_nvc"] = ToTimeTextBox.Text;
               //LaderTypeCountWithDateReportstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
               //LaderTypeCountWithDateReportstiReport["@LaderTypeList"] = LaderTypeList_nvc;
               //LaderTypeCountWithDateReportstiReport.Render();
               //LaderTypeCountWithDateReportstiReport.Show();


                LaderTypeCountWithDateReportstiReport.Dictionary.Synchronize();
                LaderTypeCountWithDateReportstiReport.Dictionary.Databases.Clear();
                LaderTypeCountWithDateReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LaderTypeCountWithDateReportstiReport.Compile();
                LaderTypeCountWithDateReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                LaderTypeCountWithDateReportstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                LaderTypeCountWithDateReportstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                LaderTypeCountWithDateReportstiReport["fromTime_nvc"] = FromTimeTextBox.Text;
                LaderTypeCountWithDateReportstiReport["toTime_nvc"] = ToTimeTextBox.Text;
                LaderTypeCountWithDateReportstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                LaderTypeCountWithDateReportstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                LaderTypeCountWithDateReportstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                LaderTypeCountWithDateReportstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                LaderTypeCountWithDateReportstiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                LaderTypeCountWithDateReportstiReport["@totime_nvc"] = ToTimeTextBox.Text;
                LaderTypeCountWithDateReportstiReport["@LaderTypeList"] = LaderTypeList_nvc;
                LaderTypeCountWithDateReportstiReport.Render();
               //this.stiViewerControl1.Report =  LaderTypeCountWithDateReportstiReport;
                LaderTypeCountWithDateReportstiReport.Show();

                
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LederTypeCountReportForm_Load(object sender, EventArgs e)
        {
            this.FillCombo();
        }

        private void FillCombo()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            DataTable LaderTypeDataTable =new DataTable() ;
            LaderTypeFactory.GetAll(ref LaderTypeDataTable);
            this.LaderTypecheckedComboBox.DropDownDataSource = LaderTypeDataTable;
            this.LaderTypecheckedComboBox.DropDownDataMember = "LaderType_T";
            this.LaderTypecheckedComboBox.DropDownDisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
            this.LaderTypecheckedComboBox.DropDownValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
            LaderTypecheckedComboBox.RetrieveStructure();
            LaderTypecheckedComboBox.DropDownList.Columns[1].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[2].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[4].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[5].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[6].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[7].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[8].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[9].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[3].Caption = "نوع بارگیر";
            LaderTypecheckedComboBox.DropDownList.Columns[3].Width = 300;


            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderTypeFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderTypeFactory.ServerJalaliDate);

            
        }

        private void ChartShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExistsLaderTypeGridView.Visible = false;
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
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);
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


                object[] LaderTypeList = new object[100];
                string LaderTypeList_nvc = string.Empty;
                int index = 0;
                LaderTypeList = LaderTypecheckedComboBox.CheckedValues;
                if (LaderTypeList != null)
                {
                    foreach (object obj in LaderTypeList)
                    {
                        LaderTypeList_nvc = string.Format("{0},{1}", LaderTypeList_nvc, LaderTypeList[index].ToString());
                        index += 1;
                    }
                    LaderTypeList_nvc = LaderTypeList_nvc.Substring(1, LaderTypeList_nvc.Length - 1);

                }
                if (string.IsNullOrEmpty(LaderTypeList_nvc))
                {
                    throw new ApplicationException("نوع بارگیر انتخاب نشده است");
                }

                if (LaderTypecheckedComboBox.CheckedValues.Length>1)
                {
                    throw new ApplicationException("یک بارگیر را انتخاب کنید");
                }

                //HPS.Reports.ReportDoc.LaderTypeCountChart rpt = new HPS.Reports.ReportDoc.LaderTypeCountChart(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();

                LaderTypeCountChartstiReport.Dictionary.Synchronize();
                LaderTypeCountChartstiReport.Dictionary.Databases.Clear();
                LaderTypeCountChartstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LaderTypeCountChartstiReport.Compile();
                LaderTypeCountChartstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                LaderTypeCountChartstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                LaderTypeCountChartstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                LaderTypeCountChartstiReport["fromTime_nvc"] = FromTimeTextBox.Text;
                LaderTypeCountChartstiReport["toTime_nvc"] = ToTimeTextBox.Text;
                LaderTypeCountChartstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                LaderTypeCountChartstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                LaderTypeCountChartstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                LaderTypeCountChartstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                LaderTypeCountChartstiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                LaderTypeCountChartstiReport["@totime_nvc"] = ToTimeTextBox.Text;
                LaderTypeCountChartstiReport["@LaderTypeList"] = LaderTypeList_nvc;
                LaderTypeCountChartstiReport.Render();
                //this.stiViewerControl1.Report =  LaderTypeCountChartstiReport;
                LaderTypeCountChartstiReport.Show();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ExistsLaderyTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmentFactory.SelectLaderTypeCountWithDateReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, string.Empty, ref LaderTypeReportTable);
                DataTable dt = new DataTable();
                dt = LaderTypeReportTable.DefaultView.ToTable(true, "Ladertype_nvc", "LaderTypeID_int");
                this.LaderTypecheckedComboBox.DropDownDataSource = null;
                this.LaderTypecheckedComboBox.DropDownDataSource = dt;
                this.LaderTypecheckedComboBox.DropDownDataMember = "LaderType_T";
                this.LaderTypecheckedComboBox.DropDownDisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypecheckedComboBox.DropDownValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                LaderTypecheckedComboBox.RetrieveStructure();
                LaderTypecheckedComboBox.DropDownList.Columns[2].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[1].Caption = "نوع بارگیر";
                LaderTypecheckedComboBox.DropDownList.Columns[1].Width = 300;

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

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void LaderTypecheckedComboBox_CheckedValuesChanged(object sender, EventArgs e)
        {

        }

        private void stiViewerControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
