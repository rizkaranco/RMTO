using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace HPS.Reports.Forms
{
    public partial class AllLadBillReport : Hepsa.Core.PL.BaseListForm
    {
        private bool WithProductionYear = false;

        public AllLadBillReport()
        {
            InitializeComponent();

            this.LadBillWithTrafficGridView.AutoGenerateColumns = false;
            Hepsa.Core.PL.BaseListForm.Group LadBillCreditGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadBillCreditGroup.set_Grid(true, false, true, this.LadBillWithTrafficGridView);
            LadBillCreditGroup.ToolStrip = this.LadBillCreditToolStrip;
            LadBillCreditGroup.RefreshButton = RefreshButton;
            LadBillCreditGroup.ExportButton = this.ExportButton;
            LadBillCreditGroup.HasFilterControl = true;
            this.Groups.Add(LadBillCreditGroup);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (WithProductionYear == true && !FromDatefaDatePicker.IsNull && !ToDatefaDatePicker.IsNull)
                //{
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                string condition = string.Empty;

                if (!string.IsNullOrEmpty(ToDatefaDatePicker.Text) && !string.IsNullOrEmpty(FromDatefaDatePicker.Text))
                {
                    condition = string.Format(" LadBillCredit_T.Date_nvc>='{0}' And LadBillCredit_T.Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                }

                if (!string.IsNullOrEmpty(LadBillCrediteID_binttextBox.Text))
                {
                    condition += string.Format(" OR LadBillCredit_T.LadBillCreditID_int='{0}'", LadBillCrediteID_binttextBox.Text);
                }

                if (!string.IsNullOrEmpty(AcceptedTurnNumber_binttextBox.Text))
                {
                    condition += string.Format(" OR Traffic_T.AcceptedTurnNumber_bint='{0}'", AcceptedTurnNumber_binttextBox.Text);
                }

                if (!string.IsNullOrEmpty(DriverCardNumber_nvctextBox.Text))
                {
                    condition += string.Format(" OR  Driver_T.DriverCardNumber_nvc='{0}'", DriverCardNumber_nvctextBox.Text);
                }

                if (!string.IsNullOrEmpty(NationalCode_inttextBox.Text))
                {
                    condition += string.Format(" OR Driver_T.NationalCode_int='{0}'", NationalCode_inttextBox.Text);
                }
                if (!string.IsNullOrEmpty(DriverLastName_nvctextBox.Text))
                {
                    condition += string.Format(" OR Driver_T.LastName_nvc='{0}'", DriverLastName_nvctextBox.Text);
                }
                if (!string.IsNullOrEmpty(CarSerialnumbertextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvctextBox.Text))
                {
                    condition += string.Format(" OR Car_T.NumberPlate_nvc='{0}' And Car_T.SerialPlate_nvc = '{1}'", NumberPlate_nvctextBox.Text, CarSerialnumbertextBox.Text);
                }

                LadBillCreditReportstiReport.Dictionary.Synchronize();
                LadBillCreditReportstiReport.Dictionary.Databases.Clear();
                LadBillCreditReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                LadBillCreditReportstiReport.Compile();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                LadBillCreditReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
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
                LadBillWithTrafficGridView.Visible = false;
                stiViewerControl1.Visible = true;
                stiViewerControl1.Report = LadBillCreditReportstiReport;
                //}
                //else
                //{
                //    HPS.Reports.Forms.LadBillCreditReporForm frm = new LadBillCreditReporForm();
                //    frm.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllLadBillReport_Load(object sender, EventArgs e)
        {
            LoadAllLadBill();
            if (HPS.Common.CurrentUser.user.UserGroupID_int != 1)
            {
                LadBillWithTrafficGridView.Columns["LadeUser"].Visible = false;
            }
        }
        private void LoadAllLadBill()
        {
            try
            {

                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LadBillFactory.ServerJalaliDate);
                ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LadBillFactory.ServerJalaliDate);
                DataTable LadeAssignmentDataTable = new DataTable();
                LadBillFactory.GetAllWithTrafficLadBillCredit(ref LadeAssignmentDataTable, LadBillFactory.ServerJalaliDate);
                LadBillWithTrafficGridView.Visible = true;
                stiViewerControl1.Visible = false;
                this.LadBillWithTrafficGridView.DataSource = LadeAssignmentDataTable;
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void LadBillReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Reports.Forms.StimulViewer frm = new StimulViewer(1, (Int32)this.LadBillWithTrafficGridView.CurrentRow.Cells["LadBillCreditID_int"].Value);
                frm.ShowDialog();
                //stiViewerControl1.Document = rpt.Document;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //rpt.Document.Printer.PaperSize.Height = 14;
                //rpt.Document.Printer.PaperSize.Width = 17;

                //stiViewerControl1.Document.Printer.PrinterSettings.Copies = 3;
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
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                DataTable LadBillCreditDataTable = new DataTable();
                ////////////////////////////////////////////////////////////////////////////////
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }
                ////////////////////////////////////////////////////////////////////////////////

                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);
                string condition = string.Empty;

                condition = string.Format(" LadBillCredit_T.Date_nvc>='{0}' And LadBillCredit_T.Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);



                if (WithProductionYear == true)
                {
                    condition += " And ProductionYear_int IS NOT NULL AND Canceled_bit=0";

                }
                LadBillWithTrafficGridView.Visible = true;
                stiViewerControl1.Visible = false;
                LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                LadBillWithTrafficGridView.DataSource = null;
                LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromDateTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadAllLadBill();
        }

        private void AllLadBilltoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                DataTable LadeAssignmentDataTable = new DataTable();
                LadBillFactory.GetAllWithTrafficLadBillCredit(ref LadeAssignmentDataTable, null);
                LadBillWithTrafficGridView.Visible = true;
                stiViewerControl1.Visible = false;
                this.LadBillWithTrafficGridView.DataSource = LadeAssignmentDataTable;
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadBillWithTrafficGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool? Canceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadBillWithTrafficGridView.Rows[e.RowIndex].Cells[this.colCanceled_bit.Name].Value, TypeCode.Boolean);
            if (Canceled_bit.HasValue && Canceled_bit == true)
            {
                e.CellStyle.BackColor = Color.LightPink;
            }
        }

        private void WithProductionYearStripButton_Click(object sender, EventArgs e)
        {
            WithProductionYear = true;
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            DataTable LadBillCreditDataTable = new DataTable();
            string condition = "Traffic_T.ProductionYear_int IS NOT NULL AND Canceled_bit=0";
            LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
            LadBillWithTrafficGridView.Visible = true;
            stiViewerControl1.Visible = false;
            LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
        }

        private void LadBillCrediteID_binttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(LadBillCrediteID_binttextBox.Text) == false)
                {
                    DriverCardNumber_nvctextBox.Text = string.Empty;
                    AcceptedTurnNumber_binttextBox.Text = string.Empty;
                    NationalCode_inttextBox.Text = string.Empty;
                    DriverLastName_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                    CarSerialnumbertextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();

                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    string condition = string.Empty;
                    condition = string.Format(" LadBillCredit_T.LadBillCreditID_int='{0}'", LadBillCrediteID_binttextBox.Text);
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
        }

        private void AcceptedTurnNumber_binttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(AcceptedTurnNumber_binttextBox.Text) == false)
                {
                    DriverCardNumber_nvctextBox.Text = string.Empty;
                    LadBillCrediteID_binttextBox.Text = string.Empty;
                    NationalCode_inttextBox.Text = string.Empty;
                    DriverLastName_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                    CarSerialnumbertextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    string condition = string.Empty;
                    condition = string.Format(" Traffic_T.AcceptedTurnNumber_bint='{0}'", AcceptedTurnNumber_binttextBox.Text);
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
        }

        private void DriverCardNumber_nvctextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(DriverCardNumber_nvctextBox.Text) == false)
                {
                    AcceptedTurnNumber_binttextBox.Text = string.Empty;
                    LadBillCrediteID_binttextBox.Text = string.Empty;
                    NationalCode_inttextBox.Text = string.Empty;
                    DriverLastName_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                    CarSerialnumbertextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    string condition = string.Empty;
                    condition = string.Format(" Driver_T.DriverCardNumber_nvc='{0}'", DriverCardNumber_nvctextBox.Text);
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
        }

        private void NationalCode_inttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(NationalCode_inttextBox.Text) == false)
                {
                    AcceptedTurnNumber_binttextBox.Text = string.Empty;
                    LadBillCrediteID_binttextBox.Text = string.Empty;
                    DriverCardNumber_nvctextBox.Text = string.Empty;
                    DriverLastName_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                    CarSerialnumbertextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    string condition = string.Empty;
                    condition = string.Format(" Driver_T.NationalCode_int='{0}'", NationalCode_inttextBox.Text);
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
        }

        private void DriverLastName_nvctextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(DriverLastName_nvctextBox.Text) == false)
                {
                    AcceptedTurnNumber_binttextBox.Text = string.Empty;
                    LadBillCrediteID_binttextBox.Text = string.Empty;
                    DriverCardNumber_nvctextBox.Text = string.Empty;
                    NationalCode_inttextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                    CarSerialnumbertextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    string condition = string.Empty;
                    condition = string.Format(" Driver_T.LastName_nvc='{0}'", DriverLastName_nvctextBox.Text);
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
        }

        private void NumberPlate_nvctextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CarSerialnumbertextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(NumberPlate_nvctextBox.Text) == false && string.IsNullOrEmpty(CarSerialnumbertextBox.Text) == false)
                {
                    AcceptedTurnNumber_binttextBox.Text = string.Empty;
                    LadBillCrediteID_binttextBox.Text = string.Empty;
                    DriverCardNumber_nvctextBox.Text = string.Empty;
                    DriverLastName_nvctextBox.Text = string.Empty;
                    NationalCode_inttextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    string condition = string.Empty;
                    condition = string.Format(" Car_T.NumberPlate_nvc='{0}' And Car_T.SerialPlate_nvc = '{1}'", NumberPlate_nvctextBox.Text, CarSerialnumbertextBox.Text);
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
        }

        private void FromDateTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToDateTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void ToDatefaDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    DataTable LadBillCreditDataTable = new DataTable();
                    ////////////////////////////////////////////////////////////////////////////////
                    if (FromDatefaDatePicker.IsNull)
                    {
                        throw new ApplicationException("از تاریخ خالی است");
                    }
                    else if (ToDatefaDatePicker.IsNull)
                    {
                        throw new ApplicationException("تا تاریخ خالی است");
                    }
                    ////////////////////////////////////////////////////////////////////////////////

                    Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                    if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                        throw new ApplicationException(FromDateValidator.Description);

                    Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                    if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                        throw new ApplicationException(ToDateValidator.Description);
                    string condition = string.Empty;

                    condition = string.Format(" LadBillCredit_T.Date_nvc>='{0}' And LadBillCredit_T.Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);



                    if (WithProductionYear == true)
                    {
                        condition += " And ProductionYear_int IS NOT NULL AND Canceled_bit=0";

                    }

                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                    LadBillWithTrafficGridView.DataSource = null;
                    LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ShowConditionButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                string condition = string.Empty;

                if (!string.IsNullOrEmpty(ToDatefaDatePicker.Text) && !string.IsNullOrEmpty(FromDatefaDatePicker.Text))
                {
                    condition = string.Format(" LadBillCredit_T.Date_nvc>='{0}' And LadBillCredit_T.Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                }

                if (!string.IsNullOrEmpty(LadBillCrediteID_binttextBox.Text))
                {
                    condition += string.Format(" OR LadBillCredit_T.LadBillCreditID_int='{0}'", LadBillCrediteID_binttextBox.Text);
                }

                if (!string.IsNullOrEmpty(AcceptedTurnNumber_binttextBox.Text))
                {
                    condition += string.Format(" OR Traffic_T.AcceptedTurnNumber_bint='{0}'", AcceptedTurnNumber_binttextBox.Text);
                }

                if (!string.IsNullOrEmpty(DriverCardNumber_nvctextBox.Text))
                {
                    condition += string.Format(" OR  Driver_T.DriverCardNumber_nvc='{0}'", DriverCardNumber_nvctextBox.Text);
                }

                if (!string.IsNullOrEmpty(NationalCode_inttextBox.Text))
                {
                    condition += string.Format(" OR Driver_T.NationalCode_int='{0}'", NationalCode_inttextBox.Text);
                }
                if (!string.IsNullOrEmpty(DriverLastName_nvctextBox.Text))
                {
                    condition += string.Format(" OR Driver_T.LastName_nvc='{0}'", DriverLastName_nvctextBox.Text);
                }
                if (!string.IsNullOrEmpty(CarSerialnumbertextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvctextBox.Text))
                {
                    condition += string.Format(" OR Car_T.NumberPlate_nvc='{0}' And Car_T.SerialPlate_nvc = '{1}'", NumberPlate_nvctextBox.Text, CarSerialnumbertextBox.Text);
                }
                DataTable LadBillCreditDataTable = new DataTable();
                LadBillWithTrafficGridView.Visible = true;
                stiViewerControl1.Visible = false;
                LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(condition, ref LadBillCreditDataTable);
                LadBillWithTrafficGridView.DataSource = null;
                LadBillWithTrafficGridView.DataSource = LadBillCreditDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }




}
