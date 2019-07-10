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

    public partial class UseLadBillVSLadeCountReportForm : Hepsa.Core.PL.BaseListForm
    {
        public UseLadBillVSLadeCountReportForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.ExportButton = this.ExportButton;
            TrafficGroup.set_Grid(true, true, true, this.LadeAssignmentInfoGridView);
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);
        }



        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                LadeAssignmentInfoGridView.Visible = true;
                SumPanel.Visible = true;

                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }

                string CompanyCodeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in companyGrid.GetCheckedRows())
                {
                    CompanyCodeList_nvc += itm.Cells["CompanyCode_nvc"].Value.ToString() + ",";
                }
                if (CompanyCodeList_nvc.EndsWith(","))
                {
                    CompanyCodeList_nvc = CompanyCodeList_nvc.Remove(CompanyCodeList_nvc.Length - 1);
                }

                string LaderTypeCodeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeCodeList_nvc += itm.Cells["LaderTypeCode_nvc"].Value.ToString() + ",";
                }
                if (LaderTypeCodeList_nvc.EndsWith(","))
                {
                    LaderTypeCodeList_nvc = LaderTypeCodeList_nvc.Remove(LaderTypeCodeList_nvc.Length - 1);
                }

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable UsedLadBillDataTable = new DataTable();
                LadeAssignmentFactory.SelectUsedLadBill(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, CompanyCodeList_nvc, LaderTypeCodeList_nvc, UsedLadBillDataTable);
                LadeAssignmentInfoGridView.DataSource = UsedLadBillDataTable;
                if (UsedLadBillDataTable != null && UsedLadBillDataTable.Rows.Count > 0)
                {
                    decimal UsedLadBill_dec = (decimal)UsedLadBillDataTable.Compute("Sum(UsedLadBill_int)", "True");
                    AllCarCount_fltlabel.Text = "تعداد درخواستی : " + ((decimal)UsedLadBillDataTable.Compute("Sum(CarCount_int)", "True")).ToString("0.##");
                    AllLadBillCount_fltLabel.Text = " تعداد مجوز صادره : " + ((decimal)UsedLadBillDataTable.Compute("Sum(LadBillCount_int)", "True")).ToString("0.##");
                    AllUsedLadBillCount_fltLabel.Text = "تعداد بار نامه : " + ((decimal)UsedLadBillDataTable.Compute("Sum(UsedLadBill_int)", "True")).ToString("0.##");
                    if (UsedLadBill_dec != 0)
                    {
                        AllCarCountPercent_decLabel.Text = "درصد درخواستی به بار نامه : " + (((decimal)UsedLadBillDataTable.Compute("Sum(CarCount_int)", "True") * 100 / UsedLadBill_dec).ToString("0.##"));
                        //AllCarCountPercent_decLabel.Text= "درصد درخواستی به بار نامه:"+(((decimal)UsedLadBillDataTable.Compute("Sum(CarCountPercent_dec)", "True") / UsedLadBillDataTable.Rows.Count).ToString("0.##"));
                        AllLadBillCountPercent_decLabel.Text = "درصد مجوز صادره به بارنامه : " + (((decimal)UsedLadBillDataTable.Compute("Sum(LadBillCount_int)", "True") * 100 / UsedLadBill_dec).ToString("0.##"));
                    }
                    else
                    {
                        AllCarCountPercent_decLabel.Text = "درصد درخواستی به بار نامه :0";
                        AllLadBillCountPercent_decLabel.Text = "درصد مجوز صادره به بارنامه :0";
                    }
                }
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
            laderTypeGrid.SetDataBinding(LaderTypeID_intDataTable, "LaderTypeID_intDataTable");

            //CompanyGroupComboBox Fill.
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory GroupID_intFatory = new BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();
            DataTable GroupID_intDataTable = new DataTable();
            GroupID_intFatory.GetAll(ref GroupID_intDataTable);
            this.CompanyGroupComboBox.DisplayMember = "GroupName_nvc";
            this.CompanyGroupComboBox.ValueMember = "GroupID_int";
            this.CompanyGroupComboBox.DataSource = GroupID_intDataTable;
            this.CompanyGroupComboBox.SelectedIndex = -1;

            var LadeAssignmentFactory = new BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            string LastDate_vc = string.Empty;
            LadeAssignmentFactory.SelectLastPerBarnameDate(out LastDate_vc);
            LastDateLabel.Text = LastDate_vc;

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

                string LaderTypeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeList_nvc += itm.Cells["LaderTypeID_int"].Value.ToString() + ",";
                }
                if (LaderTypeList_nvc.EndsWith(","))
                {
                    LaderTypeList_nvc = LaderTypeList_nvc.Remove(LaderTypeList_nvc.Length - 1);
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
                //HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                //DataTable AllDataTable = new DataTable();
                //TrafficFactory.TurnAndLadeAssignmentInfoByLaderTypeReport(FromDatefaDatePicker.Text,  FromTimeTextBox.Text, ToDatefaDatePicker.Text, ToTimeTextBox.Text,null, ref AllDataTable);
                //DataTable dt = new DataTable();
                //dt = AllDataTable.DefaultView.ToTable(true, "Ladertype_nvc", "LaderTypeID_int");



            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintstripButton_Click(object sender, EventArgs e)
        {
            try
            {
                LadeAssignmentInfoGridView.Visible = false;
                SumPanel.Visible = false;
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }


                string CompanyCodeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in companyGrid.GetCheckedRows())
                {
                    CompanyCodeList_nvc += itm.Cells["CompanyCode_nvc"].Value.ToString() + ",";
                }
                if (CompanyCodeList_nvc.EndsWith(","))
                {
                    CompanyCodeList_nvc = CompanyCodeList_nvc.Remove(CompanyCodeList_nvc.Length - 1);
                }

                string LaderTypeCodeList_nvc = string.Empty;
                foreach (Janus.Windows.GridEX.GridEXRow itm in laderTypeGrid.GetCheckedRows())
                {
                    LaderTypeCodeList_nvc += itm.Cells["LaderTypeCode_nvc"].Value.ToString() + ",";
                }
                if (LaderTypeCodeList_nvc.EndsWith(","))
                {
                    LaderTypeCodeList_nvc = LaderTypeCodeList_nvc.Remove(LaderTypeCodeList_nvc.Length - 1);
                }


                //HPS.Reports.ReportDoc.UseLadBillVSLadeCountReport rpt = new HPS.Reports.ReportDoc.UseLadBillVSLadeCountReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, CompanyCodeList_nvc, LaderTypeCodeList_nvc, ((DataTable)LadeAssignmentInfoGridView.DataSource).DefaultView);
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();

                UseLadBillVSLadeCountReportstiReport.Dictionary.Synchronize();
                UseLadBillVSLadeCountReportstiReport.Dictionary.Databases.Clear();
                UseLadBillVSLadeCountReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                UseLadBillVSLadeCountReportstiReport.Compile();
                UseLadBillVSLadeCountReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                //مقدار دهی متغیرها
                UseLadBillVSLadeCountReportstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                UseLadBillVSLadeCountReportstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                UseLadBillVSLadeCountReportstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                UseLadBillVSLadeCountReportstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
               
                UseLadBillVSLadeCountReportstiReport.Render();
                UseLadBillVSLadeCountReportstiReport.Show();

            }
            catch (Exception ex)
            {
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }

        private void LadeAssignmentInfoGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double? colLadBill = (double?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentInfoGridView.Rows[e.RowIndex].Cells[this.colLadBillCountPercent_dec.Name].Value, TypeCode.Double);
            if (colLadBill.HasValue && colLadBill > 100)
            {
                e.CellStyle.BackColor = Color.LightPink;
     
            }
        }

        private void LadeAssignmentInfoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompanyGroupComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                 DataTable CompanyID_intDataTable = new DataTable();
            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
            string CompanyCondition = string.Format("[Company_T].[Active_bit]='true' AND Company_T.GroupID_int={0}",CompanyGroupComboBox.SelectedValue);
            CompanyID_intFactory.GetAllByCondition(CompanyCondition, ref CompanyID_intDataTable);
            companyGrid.SetDataBinding(CompanyID_intDataTable, "CompanyID_intDataTable");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }



    }
}
