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
    public partial class LadBillReportForm : Hepsa.Core.PL.BaseListForm
    {
        public LadBillReportForm()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            gridEXPrintDocument1.PrepareDocument();
            PrintDialog dlg = new PrintDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                gridEXPrintDocument1.PrinterSettings = dlg.PrinterSettings;
            }
            gridEXPrintDocument1.Print();
        }

        private void LadBillReportForm_Load(object sender, EventArgs e)
        {
            FillCombo();
        }
        private void FillCombo()
        {
            try
            {
                HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeID_intFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();
                DataTable AnnouncementTimeID_intDataTable = new DataTable();
                AnnouncementTimeID_intFactory.GetAll(ref AnnouncementTimeID_intDataTable);
                this.AnnouncementTimeID_intComboBox.DisplayMember = HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTime_nvc.ToString();
                this.AnnouncementTimeID_intComboBox.ValueMember = HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTimeID_int.ToString();
                this.AnnouncementTimeID_intComboBox.DataSource = AnnouncementTimeID_intDataTable;
                this.AnnouncementTimeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CityBLL.BLLCity_TFactory CityID_intFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                DataTable CityID_intDataTable = new DataTable();
                CityID_intFactory.GetAll(ref CityID_intDataTable);
                this.CityID_intComboBox.DisplayMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString();
                this.CityID_intComboBox.ValueMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString();
                this.CityID_intComboBox.DataSource = CityID_intDataTable;
                this.CityID_intComboBox.SelectedIndex = -1;

                HPS.BLL.GoodBLL.BLLGood_TFactory GoodID_intFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
                DataTable GoodID_intDataTable = new DataTable();
                GoodID_intFactory.GetAll(ref GoodID_intDataTable);
                this.GoodID_intComboBox.DisplayMember = HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Good_nvc.ToString();
                this.GoodID_intComboBox.ValueMember = HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString();
                this.GoodID_intComboBox.DataSource = GoodID_intDataTable;
                this.GoodID_intComboBox.SelectedIndex = -1;

                HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingID_intFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
                DataTable BoxingID_intDataTable = new DataTable();
                BoxingID_intFactory.GetAll(ref BoxingID_intDataTable);
                this.BoxingID_intComboBox.DisplayMember = HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingType_nvc.ToString();
                this.BoxingID_intComboBox.ValueMember = HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString();
                this.BoxingID_intComboBox.DataSource = BoxingID_intDataTable;
                this.BoxingID_intComboBox.SelectedIndex = -1;

                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceID_intFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                DataTable PortPlaceID_intDataTable = new DataTable();
                PortPlaceID_intFactory.GetAll(ref PortPlaceID_intDataTable);
                this.PortPlaceID_intComboBox.DisplayMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString();
                this.PortPlaceID_intComboBox.ValueMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString();
                this.PortPlaceID_intComboBox.DataSource = PortPlaceID_intDataTable;
                this.PortPlaceID_intComboBox.SelectedIndex = -1;

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DataTable LaderTypeID_intDataTable = new DataTable();
                LaderTypeID_intFactory.GetAll(ref LaderTypeID_intDataTable);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
                DataTable CompanyID_intDataTable = new DataTable();
                CompanyID_intFactory.GetAll(ref CompanyID_intDataTable);
                this.CompanyID_intComboBox.DisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
                this.CompanyID_intComboBox.ValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
                this.CompanyID_intComboBox.DataSource = CompanyID_intDataTable;
                this.CompanyID_intComboBox.SelectedIndex = -1;

                HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeID_intFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
                DataTable TrafficTypeID_intDataTable = new DataTable();
                TrafficTypeID_intFactory.GetAll(ref TrafficTypeID_intDataTable);
                this.TrafficTypeID_intComboBox.DisplayMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString();
                this.TrafficTypeID_intComboBox.ValueMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString();
                this.TrafficTypeID_intComboBox.DataSource = TrafficTypeID_intDataTable;
                this.TrafficTypeID_intComboBox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CompanyID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CompanySearch frm = new HPS.Present.SearchForm.CompanySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CompanyID_intComboBox.Text = frm.SelectedCompanyEntity.Company_nvc;
            }
        }

        HPS.BLL.CityBLL.BLLCity_T CityEntity = new HPS.BLL.CityBLL.BLLCity_T();
        private void CityID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CitySearch frm = new HPS.Present.SearchForm.CitySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CityEntity = frm.SelectedCity;

                CityID_intComboBox.Text = CityEntity.City_nvc;

            }
        }

        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
        private void LaderTypeID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.LaderTypeSearch frm = new HPS.Present.SearchForm.LaderTypeSearch();
            frm.ShowDialog();
            if (frm != null)
            {
                LaderTypeEntity = frm.SelectedLaderTypeEntity;

                LaderTypeID_intComboBox.Text = LaderTypeEntity.LaderType_nvc;
            }
        }

        HPS.BLL.BoxingBLL.BLLBoxing_T BoxingEntity = new HPS.BLL.BoxingBLL.BLLBoxing_T();
        private void BoxingID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.BoxingSearch frm = new HPS.Present.SearchForm.BoxingSearch();
            frm.ShowDialog();
            if (frm != null)
            {
                BoxingEntity = frm.SelectedBoxingEntity;

                BoxingID_intComboBox.Text = BoxingEntity.BoxingType_nvc;
            }
        }

        HPS.BLL.GoodBLL.BLLGood_T GoodEntity = new HPS.BLL.GoodBLL.BLLGood_T();
        private void GoodID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.GoodSearch frm = new HPS.Present.SearchForm.GoodSearch();
            frm.ShowDialog();
            if (frm != null)
            {
                GoodEntity = frm.SelectedGoodEntity;

                GoodID_intComboBox.Text = GoodEntity.Good_nvc;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            DataTable ReportDataTable = new DataTable();
            HPS.BLL.Reports.LadBillReportBLL LadBillReportEntity = new HPS.BLL.Reports.LadBillReportBLL();
            LadBillReportEntity.CompanyID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.DriverCardNumber_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_bintNumericTextBox.NumericText, TypeCode.String);
            LadBillReportEntity.CarCardNumber_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(CarCardNumber_nvcTextBox.Text, TypeCode.String);
            LadBillReportEntity.CityID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.LaderTypeID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.BoxingID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.GoodID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(GoodID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.TrafficTypeID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.AnnouncementTimeID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(AnnouncementTimeID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.FromSerial_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(FromSerial_nvcTextBox.Text, TypeCode.String);
            LadBillReportEntity.ToSerial_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(ToSerial_nvcTextBox.Text, TypeCode.String);
            LadBillReportEntity.FromLadBillNumber_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(FromLadBillNumber_intNumericTextBox.NumericText, TypeCode.Int32);
            LadBillReportEntity.ToLadBillNumber_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(ToLadBillNumber_intNumericTextBox.NumericText, TypeCode.Int32);
            LadBillReportEntity.PortPlaceID_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaceID_intComboBox.SelectedValue, TypeCode.String);
            LadBillReportEntity.FromLadingDate_nvc = FromLadingDatePicker.Text;
            LadBillReportEntity.ToLadingDate_nvc = ToLadingDatePicker.Text;
            LadBillReportEntity.FromLadingTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromLadingTime_nvcTextBox);
            LadBillReportEntity.FromLadBillDate_nvc = FromLadBillDatePicker.Text;
            LadBillReportEntity.ToLadBillDate_nvc = ToLadingDatePicker.Text;
            LadBillReportEntity.FromLadBillTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromLadBillTime_nvc);
            LadBillReportEntity.ToLadBillTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToLadBillTime_nvc);
            HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory ReportFactory = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory();

            ReportFactory.SelectReport(LadBillReportEntity, ref ReportDataTable);
            ReportGrid.SetDataBinding(ReportDataTable, "ReportDataTable");
            this.tabControl1.SelectedTab = this.ReportTabPage;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }

        private void FromLadingTime_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToLadingTime_nvcLabel_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void FromLadBillTime_nvc_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToLadBillTime_nvc_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }
    }
}
