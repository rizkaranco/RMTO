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
    public partial class CompanyLadeAssignmentDetailReportForm : Hepsa.Core.PL.BaseForm
    {
        public CompanyLadeAssignmentDetailReportForm()
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


                //HPS.Reports.ReportDoc.CompanyLadeAssignmentDetailReport rpt = new HPS.Reports.ReportDoc.CompanyLadeAssignmentDetailReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, LaderTypeList_nvc, CompanyList_nvc, GoodList_nvc, DestinationCityList_nvc, PortPlaceList_nvc);
                //viewer1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Run();

                CompanyLadeAssignmentDetailReportstiReport.Dictionary.Synchronize();
                CompanyLadeAssignmentDetailReportstiReport.Dictionary.Databases.Clear();
                CompanyLadeAssignmentDetailReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                CompanyLadeAssignmentDetailReportstiReport.Compile();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                CompanyLadeAssignmentDetailReportstiReport["organ"]= new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                CompanyLadeAssignmentDetailReportstiReport["FromDate_vc"] = FromDatefaDatePicker.Text;
                CompanyLadeAssignmentDetailReportstiReport["ToDate_vc"] = ToDatefaDatePicker.Text;
                CompanyLadeAssignmentDetailReportstiReport["FromTime_vc"] = FromTimeTextBox.Text;
                CompanyLadeAssignmentDetailReportstiReport["ToTime_vc"] = ToTimeTextBox.Text;
                CompanyLadeAssignmentDetailReportstiReport["Date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                CompanyLadeAssignmentDetailReportstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                CompanyLadeAssignmentDetailReportstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                CompanyLadeAssignmentDetailReportstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                CompanyLadeAssignmentDetailReportstiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                CompanyLadeAssignmentDetailReportstiReport["@totime_nvc"] = ToTimeTextBox.Text;
              
                if (string.IsNullOrEmpty(LaderTypeList_nvc))
                    CompanyLadeAssignmentDetailReportstiReport["@LaderTypeID_int"] = DBNull.Value;
                else
                    CompanyLadeAssignmentDetailReportstiReport["@LaderTypeID_int"] = LaderTypeList_nvc;

                if (string.IsNullOrEmpty(CompanyList_nvc))
                    CompanyLadeAssignmentDetailReportstiReport["@CompanyID_int"] = DBNull.Value;
                else
                    CompanyLadeAssignmentDetailReportstiReport["@CompanyID_int"] = CompanyList_nvc;

                if (string.IsNullOrEmpty(GoodList_nvc))
                    CompanyLadeAssignmentDetailReportstiReport["@GoodIDList_nvc"] = DBNull.Value;
                else
                    CompanyLadeAssignmentDetailReportstiReport["@GoodIDList_nvc"] = GoodList_nvc;

                if (string.IsNullOrEmpty(DestinationCityList_nvc))
                    CompanyLadeAssignmentDetailReportstiReport["@DestinationCityIDList_nvc"] = DBNull.Value;
                else
                    CompanyLadeAssignmentDetailReportstiReport["@DestinationCityIDList_nvc"] = DestinationCityList_nvc;

                if (string.IsNullOrEmpty(PortPlaceList_nvc))
                    CompanyLadeAssignmentDetailReportstiReport["@PortPlaceIDList_nvc"] = DBNull.Value;
                else
                    CompanyLadeAssignmentDetailReportstiReport["@PortPlaceIDList_nvc"] = PortPlaceList_nvc;

                CompanyLadeAssignmentDetailReportstiReport["@OrderColumns_nvc"] = DBNull.Value;

                CompanyLadeAssignmentDetailReportstiReport.Render();
                this.stiViewerControl1.Report = CompanyLadeAssignmentDetailReportstiReport;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        DataTable CompanyID_intDataTable = new DataTable();

        private void CompanyLadeAssignmentDetailReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.FillGrid();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FillGrid()
        {
            try
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

                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(CityFactory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(CityFactory.ServerJalaliDate);
                //this.FromTimeTextBox.Text = "08:00:00";
                //this.ToTimeTextBox.Text = CityFactory.ServerTime;

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
    }
}
