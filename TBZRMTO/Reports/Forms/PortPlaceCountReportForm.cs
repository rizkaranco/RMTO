using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report.Dictionary;

namespace HPS.Reports.Forms
{
    public partial class PortPlaceCountReportForm : Form
    {
        public PortPlaceCountReportForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
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

                object[] PortPlaceList = new object[100];
                string PortPlaceList_nvc = string.Empty;
                int index = 0;
                PortPlaceList = portPlacecheckedComboBox.CheckedValues;
                if (PortPlaceList != null)
                {
                    foreach (object obj in PortPlaceList)
                    {
                        PortPlaceList_nvc = string.Format("{0},{1}", PortPlaceList_nvc, PortPlaceList[index].ToString());
                        index += 1;
                    }
                    PortPlaceList_nvc = PortPlaceList_nvc.Substring(1, PortPlaceList_nvc.Length - 1);

                }

                PortPlacestiReport.Dictionary.Synchronize();
                PortPlacestiReport.Dictionary.Databases.Clear();
                PortPlacestiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                PortPlacestiReport.Compile();
                PortPlacestiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                PortPlacestiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                PortPlacestiReport["todate_vc"] = ToDatefaDatePicker.Text;
                PortPlacestiReport["fromtime_nvc"] = FromTimeTextBox.Text;
                PortPlacestiReport["totime_nvc"] = ToTimeTextBox.Text;
                PortPlacestiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate;
                PortPlacestiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;

                PortPlacestiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                PortPlacestiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                PortPlacestiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                PortPlacestiReport["@totime_nvc"] = ToTimeTextBox.Text;

                if (PortPlaceList_nvc == string.Empty)
                    PortPlacestiReport["@PortPlaceList"] = DBNull.Value;
                else
                    PortPlacestiReport["@PortPlaceList"] = PortPlaceList_nvc;

                PortPlacestiReport.Render();
                stiViewerControl1.Report = PortPlacestiReport;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }


        private void PortPlaceCountReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            DataTable PortPlaceDataTable = new DataTable();
            PortPlaceFactory.GetAll(ref PortPlaceDataTable);
            this.portPlacecheckedComboBox.DropDownDataSource = PortPlaceDataTable;

            this.portPlacecheckedComboBox.DropDownDataMember = "PortPlace_T";
            this.portPlacecheckedComboBox.DropDownDisplayMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString();
            this.portPlacecheckedComboBox.DropDownValueMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString();
            portPlacecheckedComboBox.RetrieveStructure();
            portPlacecheckedComboBox.DropDownList.Columns[1].Visible = false;
            portPlacecheckedComboBox.DropDownList.Columns[3].Visible = false;
            portPlacecheckedComboBox.DropDownList.Columns[2].Caption = "محل بارگیری";
            portPlacecheckedComboBox.DropDownList.Columns[2].Width = 300;


            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(PortPlaceFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(PortPlaceFactory.ServerJalaliDate);
        }

        private void ExistLaderTypeButtonButton_Click(object sender, EventArgs e)
        {
            try
            {
                //HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                //DataTable PortPlaceReportTable = new DataTable();
                //LadeAssignmentFactory.SelectLaderTypeCountWithDateReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, string.Empty, ref LaderTypeReportTable);
                //DataTable dt = new DataTable();
                //dt = PortPlaceReportTable.DefaultView.ToTable(true, "PortPlaces_nvc", "PortPlacesID_int");
                //this.portPlacecheckedComboBox.DropDownDataSource = null;
                //this.portPlacecheckedComboBox.DropDownDataSource = dt;
                //this.portPlacecheckedComboBox.DropDownDataMember = "PortPlaces_T";
                //this.portPlacecheckedComboBox.DropDownDisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                //this.portPlacecheckedComboBox.DropDownValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                //portPlacecheckedComboBox.RetrieveStructure();
                //portPlacecheckedComboBox.DropDownList.Columns[2].Visible = false;
                //portPlacecheckedComboBox.DropDownList.Columns[1].Caption = "محل بارگیری";
                //portPlacecheckedComboBox.DropDownList.Columns[1].Width = 300;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void DefaulCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DefaulCheckBox.Checked)
                TimeGroupBox.Enabled = true;
            else
                TimeGroupBox.Enabled = false;
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime;
        }
    }
}
