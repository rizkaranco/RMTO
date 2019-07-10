using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace HPS.Reports.Forms
{
    public partial class TurnAcceptedAreaForm : Hepsa.Core.PL.BaseListForm
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();

        HPS.Main mainfrm = new HPS.Main();
        private bool WithProductionYear = false;
        public TurnAcceptedAreaForm()
        {
            InitializeComponent();
            this.TrafficGridView.AutoGenerateColumns = false;
            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, true, true, this.TrafficGridView);
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;
            TrafficGroup.ExportButton = this.ExportButton;
            this.Groups.Add(TrafficGroup);
            try
            {
                this.TrafficGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void ShowwithConditionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = string.Format("[T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1  And T1.Area_bit=1");
                if (!FromDatefaDatePicker.IsNull)
                {
                    Condition += string.Format("  And T1.TurnDate_nvc >= '{0}'", FromDatefaDatePicker.Text);
                }
                if (!ToDatefaDatePicker.IsNull)
                {
                    Condition += string.Format("  And T1.TurnDate_nvc <= '{0}'", ToDatefaDatePicker.Text);
                }
                if (string.IsNullOrEmpty(AcceptedTurnNumber_binttextBox.Text) == false)
                {
                    Condition += string.Format(" And T1.AcceptedTurnNumber_bint = {0}", AcceptedTurnNumber_binttextBox.Text);
                }
                if (string.IsNullOrEmpty(TrafficNumber_binttextBox.Text) == false)
                {
                    Condition += string.Format(" And T1.TrafficNumber_bint = {0}", TrafficNumber_binttextBox.Text);
                }
                if (string.IsNullOrEmpty(NumberPlate_nvctextBox.Text) == false)
                {
                    Condition += string.Format(" And T1.NumberPlate_nvc =N'{0}'", NumberPlate_nvctextBox.Text);
                }
                if (string.IsNullOrEmpty(SerialPlate_nvctextBox.Text) == false)
                {
                    Condition += string.Format(" And T1.SerialPlate_nvc ='{0}'", SerialPlate_nvctextBox.Text);
                }
                if (string.IsNullOrEmpty(LastName_nvctextBox.Text) == false)
                {
                    Condition += string.Format("  And LastName_nvc like N'%{0}%'", LastName_nvctextBox.Text);
                }

                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.SelectAcceptedTurns(TrafficDataTable, Condition);
                this.TrafficGridView.DataSource = TrafficDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            //////////////////
           
        }

        private void TurnAcceptedAreaForm_Load(object sender, EventArgs e)
        {

            LoadAllTrafficArea();
        }

        private void LoadAllTrafficArea()
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = string.Format("[T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1 And T1.TurnDate_nvc='{0}'", TrafficFactory.ServerJalaliDate.ToString());
                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.GetAllByConditionAllInTrafficArea(Condition, ref TrafficDataTable);
                this.TrafficGridView.DataSource = TrafficDataTable;

                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);

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
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }
                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);

                string Condition = string.Empty;
                if (WithProductionYear == true)
                {
                    Condition = "T1.TurnDate_nvc>='" + FromDatefaDatePicker + "' AND T1.TurnDate_nvc<='" + ToDatefaDatePicker.Text + "' And T1.Area_bit=1 AND T1.ProductionYear_int IS NOT NULL";
                }
                else
                {
                    Condition = "T1.TurnDate_nvc>='" + FromDatefaDatePicker.Text + "' AND T1.TurnDate_nvc<='" + ToDatefaDatePicker.Text + " And T1.Area_bit=1'";

                }
                if (!string.IsNullOrEmpty(AcceptedTurnNumber_binttextBox.Text))
                {
                    Condition = string.Format("  T1.AcceptedTurnNumber_bint={0} And T1.Area_bit=1 ", AcceptedTurnNumber_binttextBox.Text);
                }
                if (!string.IsNullOrEmpty(TrafficNumber_binttextBox.Text))
                {
                    Condition = string.Format("  T1.TrafficNumber_bint={0} And T1.Area_bit=1", TrafficNumber_binttextBox.Text);
                }
                if (!string.IsNullOrEmpty(NumberPlate_nvctextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvctextBox.Text))
                {
                    Condition = string.Format(" T1.NumberPlate_nvc ='{0}' AND T1.SerialPlate_nvc='{1}' And T1.Area_bit=1", NumberPlate_nvctextBox.Text, SerialPlate_nvctextBox.Text);
                }
                if (!string.IsNullOrEmpty(LastName_nvctextBox.Text))
                {
                    Condition = string.Format(" LastName_nvc LIKE '%{0}%' And T1.Area_bit=1", LastName_nvctextBox.Text);
                }
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.SelectAcceptedTurns(TrafficDataTable, Condition);
                this.TrafficGridView.DataSource = TrafficDataTable;
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

        private void PrinterSelectionButton_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings s = new HPS.Properties.Settings();
                s.PrinterName = dlg.PrinterSettings.PrinterName;
                s.Save();
            }
        }

        private void PrintStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (FromDatefaDatePicker.IsNull)
                //{
                //    throw new ApplicationException("از تاریخ خالی است");
                //}
                //else if (ToDatefaDatePicker.IsNull)
                //{
                //    throw new ApplicationException("تا تاریخ خالی است");
                //}
                //Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                //if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                //    throw new ApplicationException(FromDateValidator.Description);

                //Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                //if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                //    throw new ApplicationException(ToDateValidator.Description);

               //HPS.Reports.ReportDoc.AllAcceptedTurnReport rpt = null;


                //if (WithProductionYear == true)
                //{
                //    rpt = new HPS.Reports.ReportDoc.AllAcceptedTurnReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, true);
                //    rpt.Document.Printer.PrinterName = string.Empty;
                //    rpt.Run();
                //}
                //else
                //{
                //    rpt = new HPS.Reports.ReportDoc.AllAcceptedTurnReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, false);
                //    rpt.Document.Printer.PrinterName = string.Empty;
                //    rpt.Run();
                //}


                //Properties.Settings s = new HPS.Properties.Settings();
                //if (string.IsNullOrEmpty(s.PrinterName))
                //{
                //    rpt.Document.Print(true, true, true);
                //}
                //else
                //{
                //    rpt.Document.Printer.PrinterName = s.PrinterName;
                //    rpt.Document.Print(false, true, true);
                //}
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = string.Empty;
                if (WithProductionYear == true)
                {
                    Condition = " T1.Area_bit=1 And [T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1 AND (T1.TurnDate_nvc>='" + FromDatefaDatePicker.Text + "') AND (T1.TurnDate_nvc<='" + ToDatefaDatePicker.Text + "') AND T1.ProductionYear_int IS NOT NULL";
                }
                else
                {
                    Condition = "T1.Area_bit=1 And [T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1 AND (T1.TurnDate_nvc>='" + FromDatefaDatePicker.Text + "') AND (T1.TurnDate_nvc<='" + ToDatefaDatePicker.Text + "')";
                }

                AllAcceptedTurnstiReport.Dictionary.Synchronize();
                AllAcceptedTurnstiReport.Dictionary.Databases.Clear();
                AllAcceptedTurnstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                AllAcceptedTurnstiReport.Compile();
                AllAcceptedTurnstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                AllAcceptedTurnstiReport["fromdate_vc"] = FromDatefaDatePicker.Text;
                AllAcceptedTurnstiReport["todate_vc"] = ToDatefaDatePicker.Text;
                AllAcceptedTurnstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
                AllAcceptedTurnstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                AllAcceptedTurnstiReport["fromTrafficNumber"] = TrafficNumber_binttextBox.Text;

                AllAcceptedTurnstiReport["@condition_nvc"] = Condition;

                AllAcceptedTurnstiReport.Render();
                HPS.Reports.Forms.StimulViewer frm = new StimulViewer(AllAcceptedTurnstiReport);
                frm.Show();
                //Properties.Settings s = new HPS.Properties.Settings();
                //System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                //if (string.IsNullOrEmpty(s.PrinterName))
                //    AllAcceptedTurnstiReport.Print(true);
                //else
                //{
                //    PrinterSetting.PrinterName = s.PrinterName;
                //    AllAcceptedTurnstiReport.Print(false, PrinterSetting);
                //}

                //this.Close();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void TurnPrintstripButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                string condition = "LadBillCredit_T.TrafficID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value, TypeCode.Int64) + "' or (LadBillCredit_T.LadBillCreditID_int is not null and LadBillCredit_T.Canceled_bit=0 AND LadBillCredit_T.Turn_bit is not NULL)";
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);

                if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                {
                    bool? ladturn = LadBillCreditList[LadBillCreditList.Count - 1].Turn_bit;
                    if (LadBillCreditList[LadBillCreditList.Count - 1].Canceled_bit == false || (LadBillCreditList[LadBillCreditList.Count - 1].Canceled_bit == true && ladturn == false))
                    {
                        throw new ApplicationException("نوبت مورد نظر مجوز گرفته است");
                    }

                }
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                string conditionTurnManagement = string.Format("TurnManagement_T.TrafficID_bint='{0}' ", Hepsa.Core.Common.PersentationController.GetEntityValue(this.TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value, TypeCode.Int64));
                DataTable TurnManagementTable = new DataTable();
                TurnManagementFactory.GetAllByCondition(conditionTurnManagement, ref TurnManagementTable);
                if (TurnManagementTable != null && TurnManagementTable.Rows.Count > 0)
                {
                    if (TurnManagementTable.Rows[TurnManagementTable.Rows.Count - 1]["Return_bit"].ToString() == "False")
                    {
                        throw new ApplicationException("نوبت مورد نظر باطل شده است");
                    }

                }
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityrpt = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                TrafficKey.TrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value, TypeCode.Int64);
                TrafficEntityrpt = TrafficFactory.GetBy(TrafficKey);

                HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntityrpt, false, false);
                frm.ShowDialog();
                //

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void WithProductionYearStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                WithProductionYear = true;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = "[T1].[TurnAccepted_bit]='true' AND [T1].[TrafficTypeID_int]=1 AND ProductionYear_int IS NOT NULL";
                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.GetAllByConditionAllInTrafficArea (Condition, ref TrafficDataTable);
                this.TrafficGridView.DataSource = TrafficDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadAllTrafficArea();
        }
    }
}
