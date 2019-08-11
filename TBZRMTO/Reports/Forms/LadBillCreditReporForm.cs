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
    public partial class LadBillCreditReporForm : Hepsa.Core.PL.BaseForm
    {
        public LadBillCreditReporForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                DataTable LadBillCreditDataTable = new DataTable();
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(Hepsa.Core.Common.PersentationController.GetEntityValue(FromDatefaDatePicker.Text, TypeCode.String).ToString()) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(Hepsa.Core.Common.PersentationController.GetEntityValue(ToDatefaDatePicker.Text, TypeCode.String).ToString()) == false)
                    throw new ApplicationException(ToDateValidator.Description);

                ///Select Company and LaderType
                object[] CompanyList = new object[300];
                string CompanyList_nvc = string.Empty;
                int index = 0;
                CompanyList = CompanyID_intcheckedComboBox.CheckedValues;
                if (CompanyList != null)
                {
                    foreach (object obj in CompanyList)
                    {
                        CompanyList_nvc = string.Format("{0},{1}", CompanyList_nvc, CompanyList[index].ToString());
                        index += 1;
                    }
                    CompanyList_nvc = CompanyList_nvc.Substring(1, CompanyList_nvc.Length - 1);

                }

                object[] LaderTypeList = new object[300];
                string LaderTypeList_nvc = string.Empty;
                index = 0;
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

                string OrderColumns_nvc = string.Empty;
                if (Order1ComboBox.SelectedIndex!=0 )
                {
                    OrderColumns_nvc = ((DataRowView)Order1ComboBox.SelectedItem)["ColumnName"].ToString();
                }
                if (Order2ComboBox.SelectedIndex != 0)
                {
                    OrderColumns_nvc += " , " + ((DataRowView)Order2ComboBox.SelectedItem)["ColumnName"].ToString();
                }
                if (Order3ComboBox.SelectedIndex != 0)
                {
                    OrderColumns_nvc += " , " + ((DataRowView)Order3ComboBox.SelectedItem)["ColumnName"].ToString();
                }
                if (Order4ComboBox.SelectedIndex != 0)
                {
                    OrderColumns_nvc += " , " + ((DataRowView)Order4ComboBox.SelectedItem)["ColumnName"].ToString();
                }
                if (Order5ComboBox.SelectedIndex != 0)
                {
                    OrderColumns_nvc += " , " + ((DataRowView)Order5ComboBox.SelectedItem)["ColumnName"].ToString();
                }

                if (OrderColumns_nvc.EndsWith(" , "))
                {
                    OrderColumns_nvc = OrderColumns_nvc.Remove(OrderColumns_nvc.Length - 2, 2);
                }
                ///Call Report
                //HPS.Reports.ReportDoc.LadBillCreditReport rpt = new HPS.Reports.ReportDoc.LadBillCreditReport(this.FromDatefaDatePicker.Text, this.ToDatefaDatePicker.Text, CompanyList_nvc, LaderTypeList_nvc, OrderColumns_nvc, this.NumberPlate_nvcTextBox.Text, this.SerialPlate_nvcTextBox.Text, this.CarCardNumber_nvcTextBox.Text, this.DriverCardNumber_nvcTextBox.Text);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run();

                string condition = string.Empty;
            condition = "LadBillCredit_T.Date_nvc>='" + FromDatefaDatePicker.Text + "' AND LadBillCredit_T.Date_nvc<='" + ToDatefaDatePicker.Text + "' AND Canceled_bit=0 ";
                if (!string.IsNullOrEmpty(CompanyList_nvc))
                {
                    condition += " AND LadeAssignment_T.CompanyID_int IN ( " + CompanyList_nvc + " ) ";
                }
                if (!string.IsNullOrEmpty(LaderTypeList_nvc))
                {
                    condition += " AND Traffic_T.LaderTypeID_int IN ( " + LaderTypeList_nvc + " ) ";
                }
                if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text)))
                {
                    condition += " AND Traffic_T.NumberPlate_nvc = '" + NumberPlate_nvcTextBox.Text + "'  AND Traffic_T.SerialPlate_nvc =" + SerialPlate_nvcTextBox.Text;
                }
                if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    condition += " AND Traffic_T.CarCardNumber_nvc = " + CarCardNumber_nvcTextBox.Text;
                }
                if (!string.IsNullOrEmpty(DriverCardNumber_nvcTextBox.Text))
                {
                    condition += " AND Traffic_T.DriverCardNumber_nvc = " + DriverCardNumber_nvcTextBox.Text;
                }
                if (!string.IsNullOrEmpty(Days_intTextBox.Text))
                {
                    // تعداد روز هایی که راندگان در صف مانده اند
                    // روز های انتظار
                    condition += " AND datediff(day,dbo.ShamsiToMiladi(Traffic_T.Date_nvc),dbo.ShamsiToMiladi(LadBillCredit_T.Date_nvc)) <= " + Days_intTextBox.Text;
                }
                if (!string.IsNullOrEmpty(OrderColumns_nvc))
                {
                    condition += " ORDER BY " + OrderColumns_nvc;
                }
                else
                {
                    condition += " ORDER BY LadBillCreditID_int ";
                }
              
                LadBillCreditReportstiReport.Dictionary.Synchronize();
                LadBillCreditReportstiReport.Dictionary.Databases.Clear();
                LadBillCreditReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LadBillCreditReportstiReport.Compile();
                LadBillCreditReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                LadBillCreditReportstiReport["FromDate_vc"] = FromDatefaDatePicker.Text;
                LadBillCreditReportstiReport["ToDate_vc"] = ToDatefaDatePicker.Text;
                LadBillCreditReportstiReport["FromTime_vc"] = FromDatefaDatePicker.Text;
                LadBillCreditReportstiReport["ToTime_vc"] = ToDatefaDatePicker.Text;
                LadBillCreditReportstiReport["Date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                LadBillCreditReportstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                LadBillCreditReportstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                LadBillCreditReportstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                LadBillCreditReportstiReport["@fromtime_nvc"] = FromDatefaDatePicker.Text;
                LadBillCreditReportstiReport["@totime_nvc"] = ToDatefaDatePicker.Text;
                LadBillCreditReportstiReport["@Condition"] = condition;
                LadBillCreditReportstiReport.Render();
                stiViewerControl1.Report = LadBillCreditReportstiReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadBillCreditReporForm_Load(object sender, EventArgs e)
        {
            try
            {               
                this.FillCombo();
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
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DataTable LaderTypeID_intDataTable = new DataTable();
                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                this.LaderTypecheckedComboBox.DropDownDataSource = LaderTypeID_intDataTable;
                this.LaderTypecheckedComboBox.DropDownDataMember = "LaderType_T";
                this.LaderTypecheckedComboBox.DropDownDisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypecheckedComboBox.DropDownValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                LaderTypecheckedComboBox.RetrieveStructure();
                LaderTypecheckedComboBox.DropDownList.Columns[1].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[2].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[4].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[3].Caption = "بارگیر";
                LaderTypecheckedComboBox.DropDownList.Columns[3].Width = 300;
                LaderTypecheckedComboBox.DropDownList.Columns[5].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[6].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[7].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[8].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[9].Visible = false;
                LaderTypecheckedComboBox.DropDownList.Columns[10].Visible = false;


                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
                DataTable CompanyID_intDataTable = new DataTable();
                string CompanyCondition = "[Company_T].[Active_bit]='true'";
                CompanyID_intFactory.GetAllByCondition(CompanyCondition, ref CompanyID_intDataTable);
                DataRow Companydr = CompanyID_intDataTable.NewRow();
                //Companydr["CompanyID_int"] = 0;
                //CompanyID_intDataTable.Rows.InsertAt(Companydr, 0);
                this.CompanyID_intcheckedComboBox.DropDownDataSource = CompanyID_intDataTable;
                this.CompanyID_intcheckedComboBox.DropDownDataMember = "Company_T";
                this.CompanyID_intcheckedComboBox.DropDownDisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
                this.CompanyID_intcheckedComboBox.DropDownValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
                CompanyID_intcheckedComboBox.RetrieveStructure();
                CompanyID_intcheckedComboBox.DropDownList.Columns[1].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[2].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[4].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[3].Caption = "شرکت";
                CompanyID_intcheckedComboBox.DropDownList.Columns[3].Width = 300;
                CompanyID_intcheckedComboBox.DropDownList.Columns[5].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[6].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[7].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[8].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[9].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[10].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[11].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[12].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[13].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[14].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[15].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[16].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[17].Visible = false;
                CompanyID_intcheckedComboBox.DropDownList.Columns[18].Visible = false;


                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                DataTable LadbillOrder1Table=new DataTable();
                LadBillCreditFactory.SelectLadBillCreditOrderColumn(LadbillOrder1Table);
                DataRow emptyRow1 = LadbillOrder1Table.NewRow();
                LadbillOrder1Table.Rows.InsertAt(emptyRow1, 0);
                this.Order1ComboBox.DisplayMember = "PropertyValue";
                this.Order1ComboBox.ValueMember = "ColumnName";
                this.Order1ComboBox.DataSource = LadbillOrder1Table;
                this.Order1ComboBox.SelectedIndex = 0;

                DataTable LadbillOrder2Table = new DataTable();
                LadBillCreditFactory.SelectLadBillCreditOrderColumn(LadbillOrder2Table);
                DataRow emptyRow2 = LadbillOrder2Table.NewRow();
                LadbillOrder2Table.Rows.InsertAt(emptyRow2, 0);
                this.Order2ComboBox.DisplayMember = "PropertyValue";
                this.Order2ComboBox.ValueMember = "ColumnName";
                this.Order2ComboBox.DataSource = LadbillOrder2Table;
                this.Order2ComboBox.SelectedIndex = 0;

                DataTable LadbillOrder3Table = new DataTable();
                LadBillCreditFactory.SelectLadBillCreditOrderColumn(LadbillOrder3Table);
                DataRow emptyRow3 = LadbillOrder3Table.NewRow();
                LadbillOrder3Table.Rows.InsertAt(emptyRow3, 0);
                this.Order3ComboBox.DisplayMember = "PropertyValue";
                this.Order3ComboBox.ValueMember = "ColumnName";
                this.Order3ComboBox.DataSource = LadbillOrder3Table;
                this.Order3ComboBox.SelectedIndex = 0;

                DataTable LadbillOrder4Table = new DataTable();
                LadBillCreditFactory.SelectLadBillCreditOrderColumn(LadbillOrder4Table);
                DataRow emptyRow4 = LadbillOrder4Table.NewRow();
                LadbillOrder4Table.Rows.InsertAt(emptyRow4, 0);
                this.Order4ComboBox.DisplayMember = "PropertyValue";
                this.Order4ComboBox.ValueMember = "ColumnName";
                this.Order4ComboBox.DataSource = LadbillOrder4Table;
                this.Order4ComboBox.SelectedIndex = 0;

                DataTable LadbillOrder5Table = new DataTable();
                LadBillCreditFactory.SelectLadBillCreditOrderColumn(LadbillOrder5Table);
                DataRow emptyRow5 = LadbillOrder5Table.NewRow();
                LadbillOrder5Table.Rows.InsertAt(emptyRow5, 0);
                this.Order5ComboBox.DisplayMember = "PropertyValue";
                this.Order5ComboBox.ValueMember = "ColumnName";
                this.Order5ComboBox.DataSource = LadbillOrder5Table;
                this.Order5ComboBox.SelectedIndex = 0;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
