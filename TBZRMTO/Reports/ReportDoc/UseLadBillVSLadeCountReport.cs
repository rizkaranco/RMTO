using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Linq;


namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for AllInReport.
    /// </summary>
    public partial class UseLadBillVSLadeCountReport : DataDynamics.ActiveReports.ActiveReport
    {

        public UseLadBillVSLadeCountReport(string FromDate, string ToDate, string CompanyCodeList_nvc, string LaderTypeCodeList_nvc,DataView UsedLadBillDT)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                this.DataSource = UsedLadBillDT;
               
                FromDatetxt.Text = FromDate;
                ToDatetxt.Text = ToDate;
                UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = LadeAssignmentFactory.ServerJalaliDate;
                Timetxt.Text = LadeAssignmentFactory.ServerTime;

                CompanyCode_nvctxt.DataField = "CompanyCodeAndName";
                LedBillCount_inttxt.DataField = "LadBillCount_int";
                CarCount_inttxt.DataField = "CarCount_int";
                UsedLadBillCount_inttxt.DataField = "UsedLadBill_int";
                LaderType_nvctxt.DataField = "LaderType_nvc";
                LadBillCountPercent_dectxt.DataField = "LadBillCountPercent_dec";
                CarCountPercent_dectxt.DataField = "CarCountPercent_dec";

                if (UsedLadBillDT != null && UsedLadBillDT.ToTable().Rows.Count>0)
                {
                    decimal? AllRequestCountRecords = (from row in UsedLadBillDT.ToTable().AsEnumerable() select (decimal)row["CarCount_int"]).Sum();
                    AllCarCount_inttxt.Text = AllRequestCountRecords.HasValue ? AllRequestCountRecords.ToString() : "0";


                    decimal? AllUsedLadBillCountRecords = (from row in UsedLadBillDT.ToTable().AsEnumerable() select (decimal)row["UsedLadBill_int"]).Sum();
                    AllUsedLadBillCount_inttxt.Text = AllUsedLadBillCountRecords.HasValue ? AllUsedLadBillCountRecords.ToString() : "0";

                    decimal? AllLadBillCountRecords = (from row in UsedLadBillDT.ToTable().AsEnumerable() select (decimal)row["LadBillCount_int"]).Sum();
                    AllLadBillCount_inttxt.Text = AllLadBillCountRecords.HasValue ? AllLadBillCountRecords.ToString() : "0";


                    decimal? AllLadBillCountPercent = (from row in UsedLadBillDT.ToTable().AsEnumerable() select (decimal)row["LadBillCountPercent_dec"]).Sum();
                    AllLadBillCountPercent_dectxt.Text = (AllLadBillCountPercent.Value / UsedLadBillDT.ToTable().Rows.Count).ToString("0.##");

                    decimal? AllCarCountPercent = (from row in UsedLadBillDT.ToTable().AsEnumerable() select (decimal)row["CarCountPercent_dec"]).Sum();
                    AllCarCountPercent_dectxt.Text = (AllCarCountPercent.Value / UsedLadBillDT.ToTable().Rows.Count).ToString("0.##"); //(Convert.ToDouble(AllCarCount_inttxt.Text) * 100 / Convert.ToDouble(AllUsedLadBillCount_inttxt.Text)).ToString("0.##");

                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void detail_Format(object sender, EventArgs e)
        {
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
           
        }

        int Row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = Row.ToString();
            Row++;
        }
    }
}
