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
    public partial class AcceptedTurnWithoutLadBillCreditReportForm : Hepsa.Core.PL.BaseListForm
    {
        public AcceptedTurnWithoutLadBillCreditReportForm()
        {
            InitializeComponent();
            this.TrafficGridView.AutoGenerateColumns = false;

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, true, true, this.TrafficGridView);
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);
        }

        private void AcceptedTurnWithoutLadBillCreditReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);

                DataTable TrafficDataTable = new DataTable(); 
                TrafficFactory.SelectTurnAcceptedWithFields(ref TrafficDataTable, "", "", "", "", TrafficFactory.ServerJalaliDate, TrafficFactory.ServerJalaliDate, "");
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

        private void ShowwithConditionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string AcceptedTurnNumber_nvc = string.Empty;
                string TrafficNumber_nvc = string.Empty;
                string NumberPlate_nvc = string.Empty;
                string SerialPlate_nvc = string.Empty;
                string FromDate_nvc = string.Empty;
                string ToDate_nvc = string.Empty;
                string LastName_nvc = string.Empty;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                if (!FromDatefaDatePicker.IsNull)
                {
                    FromDate_nvc = FromDatefaDatePicker.Text;
                }
                 if (!ToDatefaDatePicker.IsNull)
                {
                    ToDate_nvc = ToDatefaDatePicker.Text;
                }
                if (string.IsNullOrEmpty(AcceptedTurnNumber_binttextBox.Text) == false)
                {
                    AcceptedTurnNumber_nvc = AcceptedTurnNumber_binttextBox.Text;
                }
                if (string.IsNullOrEmpty(TrafficNumber_binttextBox.Text) == false)
                {
                    TrafficNumber_nvc = TrafficNumber_binttextBox.Text;
                }
                if (string.IsNullOrEmpty(NumberPlate_nvctextBox.Text) == false)
                {
                    NumberPlate_nvc = NumberPlate_nvctextBox.Text;
                }
                if (string.IsNullOrEmpty(SerialPlate_nvctextBox.Text) == false)
                {
                    SerialPlate_nvc = SerialPlate_nvctextBox.Text;
                }
                if (string.IsNullOrEmpty(LastName_nvctextBox.Text) == false)
                {
                    LastName_nvc = LastName_nvctextBox.Text;
                }
                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.SelectTurnAcceptedWithFields(ref TrafficDataTable, AcceptedTurnNumber_nvc, TrafficNumber_nvc, NumberPlate_nvc, SerialPlate_nvc, FromDate_nvc, ToDate_nvc, LastName_nvc);
                this.TrafficGridView.DataSource = TrafficDataTable;
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

                //TrafficGridView.Visible = false;
                //ShowwithConditionbutton.Visible = false;

                //HPS.Reports.ReportDoc.AcceptedTurnNumberRemainedByLaderTypeCountReport report = new HPS.Reports.ReportDoc.AcceptedTurnNumberRemainedByLaderTypeCountReport(FromDateTextBox.Text, ToDateTextBox.Text);
                //report.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = report.Document;
                //report.Run();

               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport.Dictionary.Synchronize();
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport.Dictionary.Databases.Clone();
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport.Compile();
               // HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
               // //مقدار دهی متغیرها
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
               //// AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["fromTime_nvc"] = FromTimeTextBox.Text;
               //// AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["toTime_nvc"] = ToTimeTextBox.Text;
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["@FromDate_nvc"] = FromDatefaDatePicker.Text;
               //// AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["@FromTime_nvc"] = FromTimeTextBox.Text;
               //// AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["@ToTime_nvc"] = ToTimeTextBox.Text;
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport["@ToDate_nvc"] = ToDatefaDatePicker.Text;

                
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport.Render();
               // AcceptedTurnNumberRemainedByLaderTypeCountWithDateReportstiReport.Show();


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void PrinterSelectionButton_Click(object sender, EventArgs e)
        {
            ShowwithConditionbutton.Visible = true;
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(TrafficFactory.ServerJalaliDate);
        }

        private void FromDateTextBox_Click(object sender, EventArgs e)
        {
            SetMaskedTextBoxFocus(sender, e);
        }

        private void ToDateTextBox_Click(object sender, EventArgs e)
        {
            SetMaskedTextBoxFocus(sender, e);
        }

        private void SetMaskedTextBoxFocus(object sender, EventArgs e)
        {
            var MaskTextBox = (MaskedTextBox)sender;
            MaskTextBox.Focus();
        }

        private void LaderTypeRemainedWithDateStripButton_Click(object sender, EventArgs e)
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

               

               
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
