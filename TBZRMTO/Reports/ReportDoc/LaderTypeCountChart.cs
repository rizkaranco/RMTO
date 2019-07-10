using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using DataDynamics.ActiveReports.Chart.Graphics;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for LaderTypeCountChart.
    /// </summary>
    public partial class LaderTypeCountChart : DataDynamics.ActiveReports.ActiveReport
    {

        public LaderTypeCountChart(string FromDate, string FromTime, string ToDate, string ToTime, string LaderTypeList)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmentFactory.SelectLaderTypeCountWithDateReport(FromDate, FromTime, ToDate, ToTime, LaderTypeList, ref LaderTypeReportTable);
                this.DataSource = LaderTypeReportTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = LadeAssignmentFactory.ServerJalaliDate;
                Timetxt.Text = LadeAssignmentFactory.ServerTime;
                LaderTypetxt.DataField = "LaderType_nvc";

                chartControl1.DataSource = LaderTypeReportTable;


                this.chartControl1.Series[0].ValueMemberX = LaderTypeReportTable.Columns["LadeDate_nvc"].ColumnName;

                this.chartControl1.Series[0].ValueMembersY = LaderTypeReportTable.Columns["CarCount_int"].ColumnName;
                this.chartControl1.Series[1].ValueMembersY = LaderTypeReportTable.Columns["LadBill"].ColumnName;
                this.chartControl1.Series[2].ValueMembersY = LaderTypeReportTable.Columns["RemainderCar_int"].ColumnName;

                DataDynamics.ActiveReports.Chart.Graphics.Backdrop bdrop0 = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop();
                bdrop0.Style = BackdropStyle.Solid;
                bdrop0.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(249)))), ((int)(((byte)(115)))));
                bdrop0.Alpha = 255;

                DataDynamics.ActiveReports.Chart.Graphics.Backdrop bdrop1 = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop();
                bdrop1.Style = BackdropStyle.Solid;
                bdrop1.Color = System.Drawing.Color.Yellow;
                bdrop1.Alpha = 255;

                DataDynamics.ActiveReports.Chart.Graphics.Backdrop bdrop2 = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop();
                bdrop2.Style = BackdropStyle.Solid;
                bdrop2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
                bdrop2.Alpha = 255;

                this.chartControl1.Series[0].Backdrop = bdrop0;
                this.chartControl1.Series[1].Backdrop = bdrop1;
                this.chartControl1.Series[2].Backdrop = bdrop2;


                this.chartControl1.ChartAreas[0].Axes["AxisY"].SmartLabels = false;
                this.chartControl1.ChartAreas[0].Axes["AxisY"].MajorTick.Step = 1;
                this.chartControl1.ChartAreas[0].Axes["AxisY"].LabelsVisible = true;
                this.chartControl1.ChartAreas[0].Axes["AxisY"].MajorTick.GridLine = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.AliceBlue, 1);
                this.chartControl1.ChartAreas[0].Axes["AxisY"].MajorTick.Visible = true;

                this.chartControl1.ChartAreas[0].Axes[0].LabelFont.Angle = 270;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        private void LaderTypeCountChart_ReportStart(object sender, System.EventArgs eArgs)
        {
           
        }

        private void detail_Format(object sender, EventArgs e)
        {

        }

       
    }
}
