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
    public partial class OutTrafficReportForm : Hepsa.Core.PL.BaseForm
    {
        private int _TrafficType = 0;
        public OutTrafficReportForm(int TrafficType)
        {
            InitializeComponent();
            this._TrafficType = TrafficType;
            if (_TrafficType == 2 || _TrafficType == 0)
            {
                groupBox1.Visible = false;
        
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            if (_TrafficType == 1)
            {
                //IranianOutTrafiicstiReport
                string Turn = string.Empty;
                //////////////
                //HPS.Reports.ReportDoc.IranianOutTrafficReport rpt = new HPS.Reports.ReportDoc.IranianOutTrafficReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, "1", FromTimeTextBox.Text, ToTimeTextBox.Text, FromTrafficNumbertxt.Text, ToTrafficNumbertxt.Text, Convert.ToString(LaderPivotGroupID_intComboBox.SelectedValue), Convert.ToString(LaderTypeID_intComboBox.SelectedValue), Convert.ToString(ServicescomboBox.SelectedValue), Turn);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();
                IranianOutTrafiicstiReport.Dictionary.Synchronize();
                IranianOutTrafiicstiReport.Dictionary.Databases.Clear();
                IranianOutTrafiicstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                IranianOutTrafiicstiReport.Compile();
                IranianOutTrafiicstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                IranianOutTrafiicstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                IranianOutTrafiicstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                IranianOutTrafiicstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                IranianOutTrafiicstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                IranianOutTrafiicstiReport["fromTrafficNumber"] = FromTrafficNumbertxt.Text;
                IranianOutTrafiicstiReport["toTrafficNumber"] = ToTrafficNumbertxt.Text;
                IranianOutTrafiicstiReport["FromTime_vc"] = FromTimeTextBox.Text;
                IranianOutTrafiicstiReport["ToTime_vc"] = ToTimeTextBox.Text;
                if (string.IsNullOrEmpty(FromDatefaDatePicker.Text))
                    IranianOutTrafiicstiReport["@FromDateTime_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@FromDateTime_nvc"] = FromDatefaDatePicker.Text + ' ' + FromTimeTextBox.Text;
                if (string.IsNullOrEmpty(ToDatefaDatePicker.Text))
                    IranianOutTrafiicstiReport["@ToDateTime_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@ToDateTime_nvc"] = ToDatefaDatePicker.Text + ' ' + ToTimeTextBox.Text;
                if (string.IsNullOrEmpty(FromTrafficNumbertxt.Text))
                    IranianOutTrafiicstiReport["@FromTrafficNumber_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@FromTrafficNumber_nvc"] = FromTrafficNumbertxt.Text;
                if (string.IsNullOrEmpty(ToTrafficNumbertxt.Text))
                    IranianOutTrafiicstiReport["@ToTrafficNumber_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@ToTrafficNumber_nvc"] = ToTrafficNumbertxt.Text;
                if (LaderPivotGroupID_intComboBox.SelectedValue == null)
                    IranianOutTrafiicstiReport["@LaderPivotGroupID_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@LaderPivotGroupID_nvc"] = LaderPivotGroupID_intComboBox.SelectedValue;
                if (LaderTypeID_intComboBox.SelectedValue == null)
                    IranianOutTrafiicstiReport["@LaderTypeID_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@LaderTypeID_nvc"] = LaderTypeID_intComboBox.SelectedValue;
                if (ServicescomboBox.SelectedValue == null)
                    IranianOutTrafiicstiReport["@ServiceID_nvc"] = DBNull.Value;
                else
                    IranianOutTrafiicstiReport["@ServiceID_nvc"] = ServicescomboBox.SelectedValue;
                IranianOutTrafiicstiReport["@TrafficTypeID_nvc"] = 1;

                IranianOutTrafiicstiReport["@TrafficInbit_nvc"] = DBNull.Value;

                IranianOutTrafiicstiReport["@TrafficOutbit_nvc"] = 1;

                IranianOutTrafiicstiReport["@TurnAccepted_nvc"] = Turn;

                if (LaderPivotGroupID_intComboBox.SelectedValue != null)
                {
                    if (Convert.ToInt32(LaderPivotGroupID_intComboBox.SelectedValue) == 1)
                    {
                        IranianOutTrafiicstiReport["LaderTypeHeadertxt"] = "(دو محور)";
                    }

                    else if (Convert.ToInt32(LaderPivotGroupID_intComboBox.SelectedValue) == 2)
                    {
                        IranianOutTrafiicstiReport["LaderTypeHeadertxt"] = "(سه محور به بالا)";
                    }
                }
                else
                {
                    IranianOutTrafiicstiReport["LaderTypeHeadertxt"] = "(تمامی کامیون ها)";
                }
                if (LaderTypeID_intComboBox.SelectedValue != null)
                {
                    IranianOutTrafiicstiReport["LaderTypeHeadertxt"] = (string)Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(this.LaderTypeID_intComboBox);
                }
                IranianOutTrafiicstiReport.Render();
                this.stiViewerControl1.Report = IranianOutTrafiicstiReport;
            }
            if (_TrafficType == 2)
            {
                //HPS.Reports.ReportDoc.ForeignOutTrafficReport rpt = new HPS.Reports.ReportDoc.ForeignOutTrafficReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, FromTimeTextBox.Text, ToTimeTextBox.Text, FromTrafficNumbertxt.Text, ToTrafficNumbertxt.Text);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();
                string Condition = string.Empty;
                string FromTime = FromTimeTextBox.Text;
                string ToTime = ToTimeTextBox.Text;
                string FromTrafficNumber = FromTrafficNumbertxt.Text;
                string ToTrafficNumber = ToTrafficNumbertxt.Text;
                string FromDate = FromDatefaDatePicker.Text;
                string ToDate = ToDatefaDatePicker.Text;
                if (!(string.IsNullOrEmpty(FromTrafficNumbertxt.Text) && string.IsNullOrEmpty(ToTrafficNumbertxt.Text)) && (string.IsNullOrEmpty(FromTimeTextBox.Text) && string.IsNullOrEmpty(ToTime )))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                }
                else if (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime) && (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "')";
                }
                else if (!(string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc+ ' ' +T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "')";
                }

                else if (!((string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int='2') AND (T.Date_nvc + ' ' + T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                }
                    ForeignOutTrafficstiReport.Dictionary.Synchronize();
                    ForeignOutTrafficstiReport.Dictionary.Databases.Clear();
                    ForeignOutTrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                    ForeignOutTrafficstiReport.Compile();
                ForeignOutTrafficstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                ForeignOutTrafficstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                    ForeignOutTrafficstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                    ForeignOutTrafficstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                    ForeignOutTrafficstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                    ForeignOutTrafficstiReport["fromTrafficNumber"] = FromTrafficNumbertxt.Text;
                    ForeignOutTrafficstiReport["toTrafficNumber"] = ToTrafficNumbertxt.Text;
                    ForeignOutTrafficstiReport["FromTime_vc"] = FromTimeTextBox.Text;
                    ForeignOutTrafficstiReport["ToTime_vc"] = ToTimeTextBox.Text;
                    ForeignOutTrafficstiReport["@Condition"] = Condition;
                    ForeignOutTrafficstiReport.Render();
                    this.stiViewerControl1.Report = ForeignOutTrafficstiReport; 
            }
            if (_TrafficType==0)
            {
            //    HPS.Reports.ReportDoc.OtherOutReport rpt = new HPS.Reports.ReportDoc.OtherOutReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, FromTimeTextBox.Text, ToTimeTextBox.Text, FromTrafficNumbertxt.Text, ToTrafficNumbertxt.Text);
            //    rpt.Document.Printer.PrinterName = string.Empty;
            //    viewer1.Document = rpt.Document;
            //    rpt.Run();



                string Condition = string.Empty;
                string FromTime = FromTimeTextBox.Text;
                string ToTime = ToTimeTextBox.Text;
                string FromTrafficNumber = FromTrafficNumbertxt.Text;
                string ToTrafficNumber = ToTrafficNumbertxt.Text;
                string FromDate = FromDatefaDatePicker.Text;
                string ToDate = ToDatefaDatePicker.Text;
                //if (!(string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)) && (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)))
                //{
                //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                //}
                //else if (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime) && (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                //{
                //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "')";
                //}
                //else if (!(string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber))
                //{
                //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc+ ' ' +T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "')";
                //}

                //else if (!((string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                //{
                //    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc + ' ' + T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                //}


                if (!(string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)) && (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                }
                else if (string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime) && (string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc>='" + FromDate + "') AND (T.Date_nvc<='" + ToDate + "')";
                }
                else if (!(string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc+ ' ' +T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "')";
                }

                else if (!((string.IsNullOrEmpty(FromTime) && string.IsNullOrEmpty(ToTime)) && string.IsNullOrEmpty(FromTrafficNumber) && string.IsNullOrEmpty(ToTrafficNumber)))
                {
                    Condition = "(T.In_bit='False') AND (T.TrafficTypeID_int<>'1') AND (T.TrafficTypeID_int<>'2') AND (T.Date_nvc + ' ' + T.Time_nvc>='" + FromDate + ' ' + FromTime + "' ) AND (T.Date_nvc + ' ' + T.Time_nvc<='" + ToDate + ' ' + ToTime + "') AND (T.TrafficNumber_bint>='" + FromTrafficNumber + "') AND (T.TrafficNumber_bint<='" + ToTrafficNumber + "')";
                }
                OtherOutTrafficStiReport.Dictionary.Synchronize();
                OtherOutTrafficStiReport.Dictionary.Databases.Clear();
                OtherOutTrafficStiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                OtherOutTrafficStiReport.Compile();
                OtherOutTrafficStiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                OtherOutTrafficStiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                OtherOutTrafficStiReport["todate_vc"] = ToDatefaDatePicker.Text;
                OtherOutTrafficStiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                OtherOutTrafficStiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                OtherOutTrafficStiReport["fromTrafficNumber"] = FromTrafficNumbertxt.Text;
                OtherOutTrafficStiReport["toTrafficNumber"] = ToTrafficNumbertxt.Text;
                OtherOutTrafficStiReport["FromTime_vc"] = FromTimeTextBox.Text;
                OtherOutTrafficStiReport["ToTime_vc"] = ToTimeTextBox.Text;
                OtherOutTrafficStiReport["@Condition"] = Condition;
                OtherOutTrafficStiReport.Render();
                this.stiViewerControl1.Report = OtherOutTrafficStiReport; 
            }
        }

        private void OutTrafficReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                 FillCombo();
              
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
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

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DataTable LaderTypeID_intDataTable = new DataTable();
                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;


                HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
                DataTable ServicesDataTable = new DataTable();
                string condition = "[Services_T].[Activie_bit]='true'";
                ServicesFactory.GetAllByCondition(condition, ref ServicesDataTable);
                ServicescomboBox.DataSource = ServicesDataTable;
                ServicescomboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
                ServicescomboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
                ServicescomboBox.SelectedIndex = -1;

                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(ServicesFactory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(ServicesFactory.ServerJalaliDate);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LaderPivotGroupID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AllIranianCarRadioButton.Checked = false;
        }

        private void AllIranianCarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AllIranianCarRadioButton.Checked == true)
            {
                LaderPivotGroupID_intComboBox.SelectedIndex = -1;
            }
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

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }
    }
}
