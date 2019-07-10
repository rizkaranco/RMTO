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

    public partial class AllInfoByDateReportForm : Form
    {
        public AllInfoByDateReportForm()
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
                ////
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable AllDataTable = new DataTable();
                DataTable LadeAssignmentTable = new DataTable();
                TrafficFactory.TurnAndLadeAssignmentInfoByLaderTypeReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, null, ref AllDataTable);
                TrafficFactory.LadeAssignmentInfoByLaderType(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, null, ref LadeAssignmentTable);
                DataRow[] dr = null;
                foreach (DataRow row in AllDataTable.Rows)
                {
                    dr = LadeAssignmentTable.Select(string.Format(" LaderTypeID_int={0} ", row["LaderTypeID_int"]));
                    if (dr != null && dr.Length > 0)
                    {
                        row["Canceled_int"] = dr[0][2];
                        row["CarCount_int"] = dr[0][3];
                        row["ladBillCount_int"] = dr[0][4];
                        row["LadeRemainedCount_int"] = dr[0][5];
                        row["RemainedPercent_flt"] = dr[0][6];
                    }
                    else
                    {
                        var ladeset = new HashSet<int>(AllDataTable.AsEnumerable().Select(p => Convert.ToInt32(p["LaderTypeID_int"])));
                        var ladeResult = LadeAssignmentTable.AsEnumerable().Where(i => !ladeset.Contains(Convert.ToInt32(i["LaderTypeID_int"]))).ToList();
                        for (int i = 0; i < ladeResult.Count; i++)
                        {
                            row["LaderTypeID_int"] = ladeResult[i]["LaderTypeID_int"];
                            row["LaderType_nvc"] = ladeResult[i]["LaderType_nvc"];
                            row["CarCount_int"] = ladeResult[i]["CarCount_int"];
                            row["ladBillCount_int"] = ladeResult[i]["ladBillCount_int"];
                            row["LadeRemainedCount_int"] = ladeResult[i]["LadeRemainedCount_int"];
                            row["RemainedPercent_flt"] = ladeResult[i]["RemainedPercent_flt"];
                            row["TurnRemainedCount_int"] = 0;
                            AllDataTable.Rows.Add(row);
                        }
                    }
                }

                Int64? AllRemainedCountRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["LadeRemainedCount_int"])).Sum();
                string AllLadeRemaindedCounttxt = AllRemainedCountRecords.HasValue ? AllRemainedCountRecords.ToString() : "0";

                Int64? AllRequestCountRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["CarCount_int"])).Sum();
                string AllRequesttxt = AllRequestCountRecords.HasValue ? AllRequestCountRecords.ToString() : "0";


                Int64? AllLadBillCountRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["LadBillCount_int"])).Sum();
                string AllLadBillxt = AllLadBillCountRecords.HasValue ? AllLadBillCountRecords.ToString() : "0";

                string AllRemainedPercentTxt = "";
                if (Convert.ToInt32(AllRequesttxt) != 0)
                {
                    AllRemainedPercentTxt = (Convert.ToDouble(AllLadeRemaindedCounttxt) * 100 / Convert.ToDouble(AllRequesttxt)).ToString("0.##");
                }
                else
                {
                    AllRemainedPercentTxt = "0";
                }

                DataSet MyDataset = new DataSet();
                MyDataset.Tables.Add(AllDataTable);

                AllInfoByDatestiReport.Dictionary.Synchronize();
                AllInfoByDatestiReport.Dictionary.Databases.Clear();
                AllInfoByDatestiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                AllInfoByDatestiReport.RegData(MyDataset);
                AllInfoByDatestiReport.Compile();
                AllInfoByDatestiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                AllInfoByDatestiReport["date_vc"] = TrafficFactory.ServerJalaliDate + "      " + TrafficFactory.ServerTime;
                AllInfoByDatestiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                AllInfoByDatestiReport["AllRemainedPercentTxt"] = AllRemainedPercentTxt;
                AllInfoByDatestiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                AllInfoByDatestiReport["todate_vc"] = ToDatefaDatePicker.Text;
                AllInfoByDatestiReport["fromTime_vc"] = FromTimeTextBox.Text;
                AllInfoByDatestiReport["toTime_vc"] = ToTimeTextBox.Text;
                AllInfoByDatestiReport.Render();
                stiViewerControl1.Report = AllInfoByDatestiReport;


                ////
                //HPS.Reports.ReportDoc.AllInfoByDateReport rpt = new HPS.Reports.ReportDoc.AllInfoByDateReport(FromDatefaDatePicker.Text,  FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AllInfoByDateReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            //this.FromTimeTextBox.Text = "08:00:00";
            //this.ToTimeTextBox.Text = Factory.ServerTime.ToString();

            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            DataTable LaderTypeID_intDataTable = new DataTable();
            string laderCondition = "[LaderType_T].[Active_bit]='true'";
            LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
            this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
            this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
            this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
            this.LaderTypeID_intComboBox.SelectedIndex = -1;
        }

        private void FromTimetxt_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }
        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void ToTimetxt_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void uiPanel0_SelectedPanelChanged(object sender, Janus.Windows.UI.Dock.PanelActionEventArgs e)
        {

        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void ShowWithChartButton_Click(object sender, EventArgs e)
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

                if (LaderTypeID_intComboBox.SelectedIndex != -1)
                {
                    //HPS.Reports.ReportDoc.AllInInfoByDateChartReport rpt = new HPS.Reports.ReportDoc.AllInInfoByDateChartReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, Convert.ToInt32(LaderTypeID_intComboBox.SelectedValue), LaderTypeID_intComboBox.Text);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //viewer1.Document = rpt.Document;
                    //rpt.Run();
                    AllInInfoByDateChartReportstiReport.Dictionary.Synchronize();
                    AllInInfoByDateChartReportstiReport.Dictionary.Databases.Clear();
                    AllInInfoByDateChartReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                    AllInInfoByDateChartReportstiReport.Compile();
                    HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                    AllInInfoByDateChartReportstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                    AllInInfoByDateChartReportstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                    AllInInfoByDateChartReportstiReport["fromTime_nvc"] = FromTimeTextBox.Text;
                    AllInInfoByDateChartReportstiReport["toTime_nvc"] = ToTimeTextBox.Text;
                    AllInInfoByDateChartReportstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime;
                    AllInInfoByDateChartReportstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                    AllInInfoByDateChartReportstiReport["@fromdate_nvc"] = FromDatefaDatePicker.Text;
                    AllInInfoByDateChartReportstiReport["@todate_nvc"] = ToDatefaDatePicker.Text;
                    AllInInfoByDateChartReportstiReport["@fromtime_nvc"] = FromTimeTextBox.Text;
                    AllInInfoByDateChartReportstiReport["@totime_nvc"] = ToTimeTextBox.Text;
                    AllInInfoByDateChartReportstiReport["@LaderTypeList"] = Convert.ToInt32(LaderTypeID_intComboBox.SelectedValue);
                    AllInInfoByDateChartReportstiReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
                    AllInInfoByDateChartReportstiReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;
                    AllInInfoByDateChartReportstiReport["@FromTime_nvc"] = FromTimeTextBox.Text;
                    AllInInfoByDateChartReportstiReport["@ToTime_nvc"] = ToTimeTextBox.Text;
                    AllInInfoByDateChartReportstiReport["@LaderTypeID_int"] = Convert.ToInt32(LaderTypeID_intComboBox.SelectedValue);
                    AllInInfoByDateChartReportstiReport.Render();
                    AllInInfoByDateChartReportstiReport.Show();
                }
                else
                {
                    throw new ApplicationException("نوع بارگیر را انتخاب نمایید");
                }



            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ExistLaderTypeButtonButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable AllDataTable = new DataTable();
                TrafficFactory.TurnAndLadeAssignmentInfoByLaderTypeReport(FromDatefaDatePicker.Text, FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text, null, ref AllDataTable);
                DataTable dt = new DataTable();

                dt = AllDataTable.DefaultView.ToTable(true, "Ladertype_nvc", "LaderTypeID_int");




                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = dt;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;


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
                    FromTimeTextBox.Text = "00:00:00";
                    ToTimeTextBox.Text = "23:59:59";
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }



    }
}
