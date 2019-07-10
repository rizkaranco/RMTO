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
    public partial class GroupTrafficReportForm : Form
    {
        public GroupTrafficReportForm()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {


                if ((FromDatefaDatePicker.IsNull) && (string.IsNullOrEmpty(FromTrafficNumbertxt.Text) || string.IsNullOrEmpty(ToTrafficNumbertxt.Text)))
                {
                    throw new ApplicationException("از  تاریخ خالی است");
                }
                else if ((ToDatefaDatePicker.IsNull && (string.IsNullOrEmpty(FromTrafficNumbertxt.Text) || string.IsNullOrEmpty(ToTrafficNumbertxt.Text))))
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


                object[] ServiceList = new object[100];
                string ServiceList_nvc = string.Empty;
                int Serviceindex = 0;
                ServiceList = this.ServicescheckedComboBox.CheckedValues;
                if (ServiceList != null)
                {
                    foreach (object obj in ServiceList)
                    {
                        ServiceList_nvc = string.Format("{0},{1}", ServiceList_nvc, ServiceList[Serviceindex].ToString());
                        Serviceindex += 1;
                    }
                    ServiceList_nvc = ServiceList_nvc.Substring(1, ServiceList_nvc.Length - 1);

                }

                GroupTrafficstiReport.Dictionary.Synchronize();
                GroupTrafficstiReport.Dictionary.Databases.Clear();
                GroupTrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                GroupTrafficstiReport.Compile();
                GroupTrafficstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                GroupTrafficstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                GroupTrafficstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                GroupTrafficstiReport["fromtime_nvc"] = FromTimeTextBox.Text;
                GroupTrafficstiReport["totime_nvc"] = ToTimeTextBox.Text;
                GroupTrafficstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate;
                GroupTrafficstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                GroupTrafficstiReport["fromTrafficNumber"] = FromTrafficNumbertxt.Text;
                GroupTrafficstiReport["toTrafficNumber"] = ToTrafficNumbertxt.Text;
                if (string.IsNullOrEmpty(FromDatefaDatePicker.Text))
                    GroupTrafficstiReport["@FromDateTime_nvc"] = DBNull.Value;
                else
                    GroupTrafficstiReport["@FromDateTime_nvc"] = FromDatefaDatePicker.Text + ' ' + FromTimeTextBox.Text;

                if (string.IsNullOrEmpty(ToDatefaDatePicker.Text))
                    GroupTrafficstiReport["@ToDateTime_nvc"] = DBNull.Value;
                else
                    GroupTrafficstiReport["@ToDateTime_nvc"] = ToDatefaDatePicker.Text + ' ' + ToTimeTextBox.Text;

                if (string.IsNullOrEmpty(LaderTypeList_nvc))
                    GroupTrafficstiReport["@LaderTypeID_nvc"] = DBNull.Value;
                else
                    GroupTrafficstiReport["@LaderTypeID_nvc"] = Convert.ToString(LaderTypeList_nvc);
                if (InTrafficradioButton.Checked)
                {
                    GroupTrafficstiReport["@TrafficInbit_nvc"] = 1;
                    GroupTrafficstiReport["@TrafficOutbit_nvc"] = DBNull.Value;
                    GroupTrafficstiReport["TrafficType"] = "ورودی";
                }
                else if (OutTrafficradioButton.Checked)
                {
                    GroupTrafficstiReport["@TrafficInbit_nvc"] = DBNull.Value;
                    GroupTrafficstiReport["@TrafficOutbit_nvc"] = 1;
                    GroupTrafficstiReport["TrafficType"] = "خروجی";
                }
                else
                    MessageBox.Show("نوع تردد ورودی یا خروجی بایستی انتخاب شود");

                if (string.IsNullOrEmpty(ServiceList_nvc))
                    GroupTrafficstiReport["@ServiceID_nvc"] = DBNull.Value;
                else
                    GroupTrafficstiReport["@ServiceID_nvc"] = Convert.ToString(ServiceList_nvc);

                if (string.IsNullOrEmpty(FromTrafficNumbertxt.Text))
                    GroupTrafficstiReport["@FromTrafficNumber_nvc"] = DBNull.Value;
                else
                    GroupTrafficstiReport["@FromTrafficNumber_nvc"] = FromTrafficNumbertxt.Text;

                if (string.IsNullOrEmpty(ToTrafficNumbertxt.Text))
                    GroupTrafficstiReport["@ToTrafficNumber_nvc"] = DBNull.Value;
                else
                    GroupTrafficstiReport["@ToTrafficNumber_nvc"] = ToTrafficNumbertxt.Text;

                GroupTrafficstiReport.Render();
                stiViewerControl1.Report = GroupTrafficstiReport;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void GroupTrafficReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            DataTable LaderTypeDataTable = new DataTable();
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
            LaderTypecheckedComboBox.DropDownList.Columns[10].Caption = "تعداد محور";
            LaderTypecheckedComboBox.DropDownList.Columns[3].Width = 300;

            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            DataTable ServicesDataTable = new DataTable();
            string condition = "[Services_T].[Activie_bit]='true'";
            ServicesFactory.GetAllByCondition(condition, ref ServicesDataTable);
            ServicescheckedComboBox.DropDownDataSource = ServicesDataTable;
            ServicescheckedComboBox.DropDownDataMember = "";
            ServicescheckedComboBox.DropDownDisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
            ServicescheckedComboBox.DropDownValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
            ServicescheckedComboBox.RetrieveStructure();
            ServicescheckedComboBox.DropDownList.Columns[1].Visible = false;
            ServicescheckedComboBox.DropDownList.Columns[3].Visible = false;
            ServicescheckedComboBox.DropDownList.Columns[2].Caption = "نوع مراجعه";
            ServicescheckedComboBox.DropDownList.Columns[2].Width = 300;

            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderTypeFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderTypeFactory.ServerJalaliDate);
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
