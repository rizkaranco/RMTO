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
    public partial class CompanyRemainderLadeReportForm : Hepsa.Core.PL.BaseForm
    {
        public CompanyRemainderLadeReportForm()
        {
            InitializeComponent();
        }

        DataTable CompanyID_intDataTable = new DataTable();
        HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();

        private void CompanyRemainderLadeReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LaderType_nvcSearchButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.LaderTypeSearch frm = new HPS.Present.SearchForm.LaderTypeSearch();
            frm.ShowDialog();
            try
            {

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
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


                string CompanyList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in companyGrid.GetCheckedRows())
                {
                    CompanyList_nvc += itm.Cells["CompanyID_int"].Value.ToString() + ",";
                }
                if (CompanyList_nvc.EndsWith(","))
                {
                    CompanyList_nvc = CompanyList_nvc.Remove(CompanyList_nvc.Length - 1);
                }
                companyGrid.UnCheckAllRecords();

                string LaderTypeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeList_nvc += itm.Cells["LaderTypeID_int"].Value.ToString() + ",";
                }
                if (LaderTypeList_nvc.EndsWith(","))
                {
                    LaderTypeList_nvc = LaderTypeList_nvc.Remove(LaderTypeList_nvc.Length - 1);
                }
                laderTypeGrid.UnCheckAllRecords();

                //////create Order list
                string OrderColumns_nvc = string.Empty;

                OrderColumns_nvc = " T1.LadeDate_nvc ";
                bool justRemained = false;
                if (JustRemainedCheckBox.Checked)
                {
                    justRemained = true;
                }
                string GoodList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in goodGrid.GetCheckedRows())
                {
                    GoodList_nvc += itm.Cells["GoodID_int"].Value.ToString() + ",";
                }
                if (GoodList_nvc.EndsWith(","))
                {
                    GoodList_nvc = GoodList_nvc.Remove(GoodList_nvc.Length - 1);
                }
                goodGrid.UnCheckAllRecords();

                string PortPlaceList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in portPlaceGrid.GetCheckedRows())
                {
                    PortPlaceList_nvc += itm.Cells["PortPlacesID_int"].Value.ToString() + ",";
                }
                if (PortPlaceList_nvc.EndsWith(","))
                {
                    PortPlaceList_nvc = PortPlaceList_nvc.Remove(PortPlaceList_nvc.Length - 1);
                }
                portPlaceGrid.UnCheckAllRecords();

                string DestinationCityList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in destinationCityGrid.GetCheckedRows())
                {
                    DestinationCityList_nvc += itm.Cells["CityID_int"].Value.ToString() + ",";
                }
                if (DestinationCityList_nvc.EndsWith(","))
                {
                    DestinationCityList_nvc = DestinationCityList_nvc.Remove(DestinationCityList_nvc.Length - 1);
                }
                destinationCityGrid.UnCheckAllRecords();
                ////////////////////////////////////////
                //HPS.Reports.ReportDoc.CompanyRemanedLadBillWithDateReport rpt = new HPS.Reports.ReportDoc.CompanyRemanedLadBillWithDateReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, OrderColumns_nvc, justRemained, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run();

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmenFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                DataSet LaderTypeDataset = new DataSet();
                LadeAssignmenFactory.SelectCompanyLadeAssignmentDetail(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc, OrderColumns_nvc, ref LaderTypeReportTable);
                DataTable dt = null;
                if (JustRemainedCheckBox.Checked)
                {
                    LaderTypeReportTable.DefaultView.RowFilter = "RemainderCount_int <>0";
                    dt = LaderTypeReportTable.DefaultView.ToTable();


                }
                else if (JustCanceledCheckBox.Checked)
                {
                    LaderTypeReportTable.DefaultView.RowFilter = "CanceledByCompany <>0 OR CanceledByLadBillCanceled<>0";
                    dt = LaderTypeReportTable.DefaultView.ToTable();
                }
                else
                    dt = LaderTypeReportTable;

                dt.Columns.Add("RemainedPercent");
                foreach (DataRow row in dt.Rows)
                {
                    double RemainedPercent = (Convert.ToDouble(row["RemainderCount_int"]) * 100) / (Convert.ToDouble(row["CarCount_int"]));
                    row["RemainedPercent"] = RemainedPercent.ToString("0.##");
                }
                LaderTypeDataset.Tables.Add(dt.Copy());
                CompanyRemanedLadBillStiReport.Dictionary.Synchronize();
                CompanyRemanedLadBillStiReport.Dictionary.Databases.Clear();
                CompanyRemanedLadBillStiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                CompanyRemanedLadBillStiReport.RegData(LaderTypeDataset);
                CompanyRemanedLadBillStiReport.Compile();
                CompanyRemanedLadBillStiReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                CompanyRemanedLadBillStiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                CompanyRemanedLadBillStiReport["fromTime_nvc"] = FromTimeTextBox.Text;
                CompanyRemanedLadBillStiReport["toTime_nvc"] = ToTimeTextBox.Text;
                CompanyRemanedLadBillStiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                CompanyRemanedLadBillStiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                CompanyRemanedLadBillStiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                if (JustRemainedCheckBox.Checked)
                {
                    CompanyRemanedLadBillStiReport["title_nvc"] = "بارهای جامانده شرکت های حمل و نقل";
                }
                else if (JustCanceledCheckBox.Checked)
                {
                    CompanyRemanedLadBillStiReport["title_nvc"] = "بارهای ابطالی شرکت های حمل و نقل";
                }
                else
                    CompanyRemanedLadBillStiReport["title_nvc"] = "بارهای درخواستی و جامانده شرکت های حمل و نقل";
                //
                //CompanyRemanedLadBillStiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                //CompanyRemanedLadBillStiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                //CompanyRemanedLadBillStiReport["@totime_nvc"] = ToTimeTextBox.Text;
                //CompanyRemanedLadBillStiReport["@todate_nvc"] = ToDatefaDatePicker.Text;

                //if (string.IsNullOrEmpty(LaderTypeList_nvc))
                //    CompanyRemanedLadBillStiReport["@LaderTypeID_int"] = DBNull.Value;
                //else
                //    CompanyRemanedLadBillStiReport["@LaderTypeID_int"] = LaderTypeList_nvc;

                //if (string.IsNullOrEmpty(CompanyList_nvc))
                //    CompanyRemanedLadBillStiReport["@CompanyID_int"] = DBNull.Value;
                //else
                //    CompanyRemanedLadBillStiReport["@CompanyID_int"] = CompanyList_nvc;

                //if (string.IsNullOrEmpty(GoodList_nvc))
                //    CompanyRemanedLadBillStiReport["@GoodIDList_nvc"] = DBNull.Value;
                //else
                //    CompanyRemanedLadBillStiReport["@GoodIDList_nvc"] = GoodList_nvc;

                //if (string.IsNullOrEmpty(DestinationCityList_nvc))
                //    CompanyRemanedLadBillStiReport["@DestinationCityIDList_nvc"] = DBNull.Value;
                //else
                //    CompanyRemanedLadBillStiReport["@DestinationCityIDList_nvc"] = DestinationCityList_nvc;

                //if (string.IsNullOrEmpty(PortPlaceList_nvc))
                //    CompanyRemanedLadBillStiReport["@PortPlaceIDList_nvc"] = DBNull.Value;
                //else
                //    CompanyRemanedLadBillStiReport["@PortPlaceIDList_nvc"] = PortPlaceList_nvc;

                //if (string.IsNullOrEmpty(OrderColumns_nvc))
                //    CompanyRemanedLadBillStiReport["@OrderColumns_nvc"] = DBNull.Value;
                //else
                //    CompanyRemanedLadBillStiReport["@OrderColumns_nvc"] = OrderColumns_nvc;

                CompanyRemanedLadBillStiReport.Render();
                stiViewerControl1.Report = CompanyRemanedLadBillStiReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CompanyID_intShowButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CompanyID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FillGrid()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            DataTable LaderTypeID_intDataTable = new DataTable();
            string laderCondition = "[LaderType_T].[Active_bit]='true'";
            LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
            laderTypeGrid.SetDataBinding(LaderTypeID_intDataTable, "LaderTypeID_intDataTable");

            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
            string CompanyCondition = "[Company_T].[Active_bit]='true'";
            CompanyID_intFactory.GetAllByCondition(CompanyCondition, ref CompanyID_intDataTable);
            companyGrid.SetDataBinding(CompanyID_intDataTable, "CompanyID_intDataTable");

            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            DataTable LadbillOrder1Table = new DataTable();
            LadBillCreditFactory.SelectCompanyRemainedLadBillReportOrderColumns(LadbillOrder1Table);
            DataRow emptyRow1 = LadbillOrder1Table.NewRow();
            LadbillOrder1Table.Rows.InsertAt(emptyRow1, 0);
            this.Order1ComboBox.DisplayMember = "PropertyValue";
            this.Order1ComboBox.ValueMember = "ColumnName";
            this.Order1ComboBox.DataSource = LadbillOrder1Table;
            this.Order1ComboBox.SelectedIndex = 0;

            DataTable LadbillOrder2Table = new DataTable();
            LadBillCreditFactory.SelectCompanyRemainedLadBillReportOrderColumns(LadbillOrder2Table);
            DataRow emptyRow2 = LadbillOrder2Table.NewRow();
            LadbillOrder2Table.Rows.InsertAt(emptyRow2, 0);
            this.Order2ComboBox.DisplayMember = "PropertyValue";
            this.Order2ComboBox.ValueMember = "ColumnName";
            this.Order2ComboBox.DataSource = LadbillOrder2Table;
            this.Order2ComboBox.SelectedIndex = 0;

            DataTable LadbillOrder3Table = new DataTable();
            LadBillCreditFactory.SelectCompanyRemainedLadBillReportOrderColumns(LadbillOrder3Table);
            DataRow emptyRow3 = LadbillOrder3Table.NewRow();
            LadbillOrder3Table.Rows.InsertAt(emptyRow3, 0);
            this.Order3ComboBox.DisplayMember = "PropertyValue";
            this.Order3ComboBox.ValueMember = "ColumnName";
            this.Order3ComboBox.DataSource = LadbillOrder3Table;
            this.Order3ComboBox.SelectedIndex = 0;

            DataTable LadbillOrder4Table = new DataTable();
            LadBillCreditFactory.SelectCompanyRemainedLadBillReportOrderColumns(LadbillOrder4Table);
            DataRow emptyRow4 = LadbillOrder4Table.NewRow();
            LadbillOrder4Table.Rows.InsertAt(emptyRow4, 0);
            this.Order4ComboBox.DisplayMember = "PropertyValue";
            this.Order4ComboBox.ValueMember = "ColumnName";
            this.Order4ComboBox.DataSource = LadbillOrder4Table;
            this.Order4ComboBox.SelectedIndex = 0;

            DataTable LadbillOrder5Table = new DataTable();
            LadBillCreditFactory.SelectCompanyRemainedLadBillReportOrderColumns(LadbillOrder5Table);
            DataRow emptyRow5 = LadbillOrder5Table.NewRow();
            LadbillOrder5Table.Rows.InsertAt(emptyRow5, 0);
            this.Order5ComboBox.DisplayMember = "PropertyValue";
            this.Order5ComboBox.ValueMember = "ColumnName";
            this.Order5ComboBox.DataSource = LadbillOrder5Table;
            this.Order5ComboBox.SelectedIndex = 0;

            HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
            DataTable GoodID_intDataTable = new DataTable();
            GoodFactory.GetAll(ref GoodID_intDataTable);
            goodGrid.SetDataBinding(GoodID_intDataTable, "GoodID_intDataTable");

            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            DataTable PortPlaceID_intDataTable = new DataTable();
            string PortPlacesCondition = "[PortPlaces_T].[Active_bit]='true'";
            PortPlaceFactory.GetAllByCondition(PortPlacesCondition, ref PortPlaceID_intDataTable);
            portPlaceGrid.SetDataBinding(PortPlaceID_intDataTable, "PortPlaceID_intDataTable");

            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            DataTable DestinationCityID_intDataTable = new DataTable();
            string CityCondition = "[City_T].[Active_bit]='true'";
            CityFactory.GetAllByCondition(CityCondition, ref DestinationCityID_intDataTable);
            destinationCityGrid.SetDataBinding(DestinationCityID_intDataTable, "DestinationCityID_intDataTable");

            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(CompanyID_intFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(CompanyID_intFactory.ServerJalaliDate);
            //FromTimeTextBox.Text = "08:00:00";
            // ToTimeTextBox.Text = CompanyID_intFactory.ServerTime;
        }

        private void ShowWithDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
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


                string CompanyList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in companyGrid.GetCheckedRows())
                {
                    CompanyList_nvc += itm.Cells["CompanyID_int"].Value.ToString() + ",";
                }
                if (CompanyList_nvc.EndsWith(","))
                {
                    CompanyList_nvc = CompanyList_nvc.Remove(CompanyList_nvc.Length - 1);
                }
                companyGrid.UnCheckAllRecords();

                string LaderTypeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeList_nvc += itm.Cells["LaderTypeID_int"].Value.ToString() + ",";
                }
                if (LaderTypeList_nvc.EndsWith(","))
                {
                    LaderTypeList_nvc = LaderTypeList_nvc.Remove(LaderTypeList_nvc.Length - 1);
                }
                laderTypeGrid.UnCheckAllRecords();

                //////create Order list
                string OrderColumns_nvc = string.Empty;

                OrderColumns_nvc = " T1.LadeDate_nvc ";
                bool justRemained = false;
                if (JustRemainedCheckBox.Checked)
                {
                    justRemained = true;
                }
                string GoodList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in goodGrid.GetCheckedRows())
                {
                    GoodList_nvc += itm.Cells["GoodID_int"].Value.ToString() + ",";
                }
                if (GoodList_nvc.EndsWith(","))
                {
                    GoodList_nvc = GoodList_nvc.Remove(GoodList_nvc.Length - 1);
                }
                goodGrid.UnCheckAllRecords();

                string PortPlaceList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in portPlaceGrid.GetCheckedRows())
                {
                    PortPlaceList_nvc += itm.Cells["PortPlacesID_int"].Value.ToString() + ",";
                }
                if (PortPlaceList_nvc.EndsWith(","))
                {
                    PortPlaceList_nvc = PortPlaceList_nvc.Remove(PortPlaceList_nvc.Length - 1);
                }
                portPlaceGrid.UnCheckAllRecords();

                string DestinationCityList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in destinationCityGrid.GetCheckedRows())
                {
                    DestinationCityList_nvc += itm.Cells["CityID_int"].Value.ToString() + ",";
                }
                if (DestinationCityList_nvc.EndsWith(","))
                {
                    DestinationCityList_nvc = DestinationCityList_nvc.Remove(DestinationCityList_nvc.Length - 1);
                }
                destinationCityGrid.UnCheckAllRecords();
                ////////////////////////////////////////
                //HPS.Reports.ReportDoc.CompanyRemanedLadBillWithDateReport rpt = new HPS.Reports.ReportDoc.CompanyRemanedLadBillWithDateReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, OrderColumns_nvc, justRemained, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run();

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmenFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                DataSet LaderTypeDataset = new DataSet();
                LadeAssignmenFactory.SelectCompanyLadeAssignmentDetail(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc, OrderColumns_nvc, ref LaderTypeReportTable);
                DataTable dt = null;
                if (JustRemainedCheckBox.Checked)
                {
                    LaderTypeReportTable.DefaultView.RowFilter = "RemainderCount_int <>0";
                    dt = LaderTypeReportTable.DefaultView.ToTable();


                }
                else if (JustCanceledCheckBox.Checked)
                {
                    LaderTypeReportTable.DefaultView.RowFilter = "CanceledByCompany <>0 OR CanceledByLadBillCanceled<>0";
                    dt = LaderTypeReportTable.DefaultView.ToTable();
                }
                else
                    dt = LaderTypeReportTable;

                dt.Columns.Add("RemainedPercent");
                foreach (DataRow row in dt.Rows)
                {
                    double RemainedPercent = (Convert.ToDouble(row["RemainderCount_int"]) * 100) / (Convert.ToDouble(row["CarCount_int"]));
                    row["RemainedPercent"] = RemainedPercent.ToString("0.##");
                }
                LaderTypeDataset.Tables.Add(dt.Copy());
                CompanyRemainedLadBillWithDatestiReport.Dictionary.Synchronize();
                CompanyRemainedLadBillWithDatestiReport.Dictionary.Databases.Clear();
                CompanyRemainedLadBillWithDatestiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                CompanyRemainedLadBillWithDatestiReport.RegData(LaderTypeDataset);
                CompanyRemainedLadBillWithDatestiReport.Compile();
                CompanyRemainedLadBillWithDatestiReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                CompanyRemainedLadBillWithDatestiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                CompanyRemainedLadBillWithDatestiReport["fromTime_nvc"] = FromTimeTextBox.Text;
                CompanyRemainedLadBillWithDatestiReport["toTime_nvc"] = ToTimeTextBox.Text;
                CompanyRemainedLadBillWithDatestiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                CompanyRemainedLadBillWithDatestiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                CompanyRemainedLadBillWithDatestiReport["Username_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                if (JustRemainedCheckBox.Checked)
                {
                    CompanyRemainedLadBillWithDatestiReport["title_nvc"] = "بارهای جامانده شرکت های حمل و نقل";
                }
                else if (JustCanceledCheckBox.Checked)
                {
                    CompanyRemainedLadBillWithDatestiReport["title_nvc"] = "بارهای ابطالی شرکت های حمل و نقل";
                }
                else
                    CompanyRemainedLadBillWithDatestiReport["title_nvc"] = "بارهای درخواستی و جامانده شرکت های حمل و نقل";
 
                CompanyRemainedLadBillWithDatestiReport.Render();
                stiViewerControl1.Report = CompanyRemainedLadBillWithDatestiReport;

                ExportToExcelButton.Enabled = true;
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

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.ShowDialog();
                if (!string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    HPS.BLL.CompanyBLL.BLLCompany_TFactory factory = new BLL.CompanyBLL.BLLCompany_TFactory();
                    string fileName_nvc = string.Format("{0}.xls", folderBrowserDialog.SelectedPath + "\\" + factory.ServerJalaliDate.Replace("/", "") + factory.ServerTime.Replace(":", ""));
                    //xlsExport1.Export(viewer1.Document, fileName_nvc);
                    Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات با موفقیت انتقال داده شد");
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void CompanyRemainedButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
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


                string CompanyList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in companyGrid.GetCheckedRows())
                {
                    CompanyList_nvc += itm.Cells["CompanyID_int"].Value.ToString() + ",";
                }
                if (CompanyList_nvc.EndsWith(","))
                {
                    CompanyList_nvc = CompanyList_nvc.Remove(CompanyList_nvc.Length - 1);
                }

                string LaderTypeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeList_nvc += itm.Cells["LaderTypeID_int"].Value.ToString() + ",";
                }
                if (LaderTypeList_nvc.EndsWith(","))
                {
                    LaderTypeList_nvc = LaderTypeList_nvc.Remove(LaderTypeList_nvc.Length - 1);
                }

                string GoodList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in goodGrid.GetCheckedRows())
                {
                    GoodList_nvc += itm.Cells["GoodID_int"].Value.ToString() + ",";
                }
                if (GoodList_nvc.EndsWith(","))
                {
                    GoodList_nvc = GoodList_nvc.Remove(GoodList_nvc.Length - 1);
                }
                goodGrid.UnCheckAllRecords();

                string PortPlaceList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in portPlaceGrid.GetCheckedRows())
                {
                    PortPlaceList_nvc += itm.Cells["PortPlacesID_int"].Value.ToString() + ",";
                }
                if (PortPlaceList_nvc.EndsWith(","))
                {
                    PortPlaceList_nvc = PortPlaceList_nvc.Remove(PortPlaceList_nvc.Length - 1);
                }
                portPlaceGrid.UnCheckAllRecords();

                string DestinationCityList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in destinationCityGrid.GetCheckedRows())
                {
                    DestinationCityList_nvc += itm.Cells["CityID_int"].Value.ToString() + ",";
                }
                if (DestinationCityList_nvc.EndsWith(","))
                {
                    DestinationCityList_nvc = DestinationCityList_nvc.Remove(DestinationCityList_nvc.Length - 1);
                }
                destinationCityGrid.UnCheckAllRecords();
                ////////////////////////////////////////
                //HPS.Reports.ReportDoc.CompanyAllRemainedLaderTypeReport rpt = new HPS.Reports.ReportDoc.CompanyAllRemainedLaderTypeReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run(); 
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                GeneralReport.Dictionary.Synchronize();
                GeneralReport.Dictionary.Databases.Clear();
                GeneralReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                GeneralReport.Compile();
                GeneralReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                GeneralReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                GeneralReport["fromTime_nvc"] = FromTimeTextBox.Text;
                GeneralReport["toTime_nvc"] = ToTimeTextBox.Text;
                GeneralReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                GeneralReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                GeneralReport["Username_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                GeneralReport["title_nvc"] = "لیست بارهای درخواستی و جامانده شرکت های حمل و نقل";
                ExportToExcelButton.Enabled = true;
                GeneralReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                GeneralReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                GeneralReport["@totime_nvc"] = ToTimeTextBox.Text;
                GeneralReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                if (string.IsNullOrEmpty(LaderTypeList_nvc))
                    GeneralReport["@LaderTypeID_nvc"] = DBNull.Value;
                else
                    GeneralReport["@LaderTypeID_nvc"] = LaderTypeList_nvc;

                if (string.IsNullOrEmpty(CompanyList_nvc))
                    GeneralReport["@CompanyID_nvc"] = DBNull.Value;
                else
                    GeneralReport["@CompanyID_nvc"] = CompanyList_nvc;

                if (string.IsNullOrEmpty(GoodList_nvc))
                    GeneralReport["@GoodIDList_nvc"] = DBNull.Value;
                else
                    GeneralReport["@GoodIDList_nvc"] = GoodList_nvc;

                if (string.IsNullOrEmpty(DestinationCityList_nvc))
                    GeneralReport["@DestinationCityIDList_nvc"] = DBNull.Value;
                else
                    GeneralReport["@DestinationCityIDList_nvc"] = DestinationCityList_nvc;

                if (string.IsNullOrEmpty(PortPlaceList_nvc))
                    GeneralReport["@PortPlaceIDList_nvc"] = DBNull.Value;
                else
                    GeneralReport["@PortPlaceIDList_nvc"] = PortPlaceList_nvc;
               
                GeneralReport.Render();
                stiViewerControl1.Report = GeneralReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            ToTimeTextBox.Text = Factory.ServerTime;
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

        private void JustCanceledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JustCanceledCheckBox.Checked)
            {
                JustRemainedCheckBox.Checked = false;
            }

        }

        private void JustRemainedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JustRemainedCheckBox.Checked)
            {
                JustCanceledCheckBox.Checked = false;
            }
        }

        private void WithLaderTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
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


                string CompanyList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in companyGrid.GetCheckedRows())
                {
                    CompanyList_nvc += itm.Cells["CompanyID_int"].Value.ToString() + ",";
                }
                if (CompanyList_nvc.EndsWith(","))
                {
                    CompanyList_nvc = CompanyList_nvc.Remove(CompanyList_nvc.Length - 1);
                }

                string LaderTypeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeList_nvc += itm.Cells["LaderTypeID_int"].Value.ToString() + ",";
                }
                if (LaderTypeList_nvc.EndsWith(","))
                {
                    LaderTypeList_nvc = LaderTypeList_nvc.Remove(LaderTypeList_nvc.Length - 1);
                }

                string GoodList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in goodGrid.GetCheckedRows())
                {
                    GoodList_nvc += itm.Cells["GoodID_int"].Value.ToString() + ",";
                }
                if (GoodList_nvc.EndsWith(","))
                {
                    GoodList_nvc = GoodList_nvc.Remove(GoodList_nvc.Length - 1);
                }
                goodGrid.UnCheckAllRecords();

                string PortPlaceList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in portPlaceGrid.GetCheckedRows())
                {
                    PortPlaceList_nvc += itm.Cells["PortPlacesID_int"].Value.ToString() + ",";
                }
                if (PortPlaceList_nvc.EndsWith(","))
                {
                    PortPlaceList_nvc = PortPlaceList_nvc.Remove(PortPlaceList_nvc.Length - 1);
                }
                portPlaceGrid.UnCheckAllRecords();

                string DestinationCityList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in destinationCityGrid.GetCheckedRows())
                {
                    DestinationCityList_nvc += itm.Cells["CityID_int"].Value.ToString() + ",";
                }
                if (DestinationCityList_nvc.EndsWith(","))
                {
                    DestinationCityList_nvc = DestinationCityList_nvc.Remove(DestinationCityList_nvc.Length - 1);
                }
                destinationCityGrid.UnCheckAllRecords();
                ////////////////////////////////////////
                //HPS.Reports.ReportDoc.CompanyAllRemainedLaderTypeReport rpt = new HPS.Reports.ReportDoc.CompanyAllRemainedLaderTypeReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run(); 
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                GeneralwithLaderTypeReport.Dictionary.Synchronize();
                GeneralwithLaderTypeReport.Dictionary.Databases.Clear();
                GeneralwithLaderTypeReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                GeneralwithLaderTypeReport.Compile();
                GeneralwithLaderTypeReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                GeneralwithLaderTypeReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                GeneralwithLaderTypeReport["fromTime_nvc"] = FromTimeTextBox.Text;
                GeneralwithLaderTypeReport["toTime_nvc"] = ToTimeTextBox.Text;
                GeneralwithLaderTypeReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                GeneralwithLaderTypeReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                GeneralwithLaderTypeReport["Username_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                GeneralwithLaderTypeReport["title_nvc"] = "بارهای جامانده شرکت های حمل و نقل به تفکیک انواع بارگیر";
                ExportToExcelButton.Enabled = true;
                GeneralwithLaderTypeReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                GeneralwithLaderTypeReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                GeneralwithLaderTypeReport["@totime_nvc"] = ToTimeTextBox.Text;
                GeneralwithLaderTypeReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                if (string.IsNullOrEmpty(LaderTypeList_nvc))
                    GeneralwithLaderTypeReport["@LaderTypeID_nvc"] = DBNull.Value;
                else
                    GeneralwithLaderTypeReport["@LaderTypeID_nvc"] = LaderTypeList_nvc;

                if (string.IsNullOrEmpty(CompanyList_nvc))
                    GeneralwithLaderTypeReport["@CompanyID_nvc"] = DBNull.Value;
                else
                    GeneralwithLaderTypeReport["@CompanyID_nvc"] = CompanyList_nvc;

                if (string.IsNullOrEmpty(GoodList_nvc))
                    GeneralwithLaderTypeReport["@GoodIDList_nvc"] = DBNull.Value;
                else
                    GeneralwithLaderTypeReport["@GoodIDList_nvc"] = GoodList_nvc;

                if (string.IsNullOrEmpty(DestinationCityList_nvc))
                    GeneralwithLaderTypeReport["@DestinationCityIDList_nvc"] = DBNull.Value;
                else
                    GeneralwithLaderTypeReport["@DestinationCityIDList_nvc"] = DestinationCityList_nvc;

                if (string.IsNullOrEmpty(PortPlaceList_nvc))
                    GeneralwithLaderTypeReport["@PortPlaceIDList_nvc"] = DBNull.Value;
                else
                    GeneralwithLaderTypeReport["@PortPlaceIDList_nvc"] = PortPlaceList_nvc;

                GeneralwithLaderTypeReport.Render();
                stiViewerControl1.Report = GeneralwithLaderTypeReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
