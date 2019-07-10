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
    public partial class CarLadeBillReportForm : Form
    {
        public CarLadeBillReportForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        { try
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

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            CarLadeBillstiReport.Dictionary.Synchronize();
            CarLadeBillstiReport.Dictionary.Databases.Clear();
            CarLadeBillstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
            CarLadeBillstiReport.Compile();
                CarLadeBillstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
            CarLadeBillstiReport["date_vc"] = TrafficFactory.ServerJalaliDate + " " + TrafficFactory.ServerTime;
            CarLadeBillstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
            CarLadeBillstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
            CarLadeBillstiReport["todate_vc"] = ToDatefaDatePicker.Text;
            CarLadeBillstiReport["fromTime_vc"] = FromTimeTextBox.Text;
            CarLadeBillstiReport["toTime_vc"] = ToTimeTextBox.Text;

            CarLadeBillstiReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
            CarLadeBillstiReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;
            CarLadeBillstiReport["@FromTime_nvc"] = FromTimeTextBox.Text;
            CarLadeBillstiReport["@ToTime_nvc"] = ToTimeTextBox.Text;

            if (string.IsNullOrEmpty(LaderTypeList_nvc))
                CarLadeBillstiReport["@LaderTypeID_nvc"] = DBNull.Value;
            else
                CarLadeBillstiReport["@LaderTypeID_nvc"] = Convert.ToString(LaderTypeList_nvc);

            if (string.IsNullOrEmpty(CarSerialnumbertextBox.Text))
                CarLadeBillstiReport["@SerialPlate_nvc"] = DBNull.Value;
            else
                CarLadeBillstiReport["@SerialPlate_nvc"] = CarSerialnumbertextBox.Text;

            if (string.IsNullOrEmpty(NumberPlate_nvctextBox.Text))
                CarLadeBillstiReport["@NumberPlate_nvc"] = DBNull.Value;
            else
                CarLadeBillstiReport["@NumberPlate_nvc"] = NumberPlate_nvctextBox.Text;
            //@CarCardNumber_nvc
            if (string.IsNullOrEmpty(CarCardNumber_nvctextBox.Text))
                CarLadeBillstiReport["@CarCardNumber_nvc"] = DBNull.Value;
            else
                CarLadeBillstiReport["@CarCardNumber_nvc"] = CarCardNumber_nvctextBox.Text;
            CarLadeBillstiReport.Render();
            stiViewerControl1.Report = CarLadeBillstiReport;
            }
        catch (Exception ex)
        {
            Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
        }
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime;
        }

        private void DefaulCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DefaulCheckBox.Checked)
                TimeGroupBox.Enabled = true;
            else
                TimeGroupBox.Enabled = false;
        }

        private void CarLadeBillReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);

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
        }
    }
}
