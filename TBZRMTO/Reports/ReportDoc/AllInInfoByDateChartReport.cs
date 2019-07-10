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
    /// Summary description for AllInInfoByDateChartReport.
    /// </summary>
    public partial class AllInInfoByDateChartReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AllInInfoByDateChartReport(string FromDate, string FromTime, string ToDate, string ToTime,Int32? LaderTypeID_int,string LaderType_nvc)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                UserNametxt.Text = HPS.Common.CurrentUser.user.UserName_nvc;

               
                /////FILL Chart COntrol 1
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LaderTypeReportTable = new DataTable();
                LadeAssignmentFactory.SelectLaderTypeCountWithDateReport(FromDate, FromTime, ToDate, ToTime, LaderTypeID_int.ToString(), ref LaderTypeReportTable);
                chartControl1.DataSource = LaderTypeReportTable;
                LaderTypetxt.Text = LaderType_nvc;

                this.chartControl1.Series[0].ValueMemberX = LaderTypeReportTable.Columns["LadeDate_nvc"].ColumnName;

                this.chartControl1.Series[0].ValueMembersY = LaderTypeReportTable.Columns["CarCount_int"].ColumnName;
                this.chartControl1.Series[1].ValueMembersY = LaderTypeReportTable.Columns["LadBill"].ColumnName;
                this.chartControl1.Series[2].ValueMembersY = LaderTypeReportTable.Columns["RemainderCar_int"].ColumnName;
                this.chartControl1.Series[3].ValueMembersY = LaderTypeReportTable.Columns["RemainedPercent_flt"].ColumnName;

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

                DataDynamics.ActiveReports.Chart.Graphics.Backdrop bdrop3 = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop();
                bdrop3.Style = BackdropStyle.Solid;
                bdrop3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
                bdrop3.Alpha = 255;

                this.chartControl1.Series[0].Backdrop = bdrop0;
                this.chartControl1.Series[1].Backdrop = bdrop1;
                this.chartControl1.Series[2].Backdrop = bdrop2;
                this.chartControl1.Series[3].Backdrop = bdrop3;


                this.chartControl1.ChartAreas[0].Axes["AxisY"].SmartLabels = false;
                this.chartControl1.ChartAreas[0].Axes["AxisY"].MajorTick.Step = 1;
                this.chartControl1.ChartAreas[0].Axes["AxisY"].LabelsVisible = true;
                this.chartControl1.ChartAreas[0].Axes["AxisY"].MajorTick.GridLine = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.AliceBlue, 1);
                this.chartControl1.ChartAreas[0].Axes["AxisY"].MajorTick.Visible = true;

                this.chartControl1.ChartAreas[0].Axes[0].LabelFont.Angle = 290;

                /////FILL Waiting Chart
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable AllDataTable = new DataTable();
                TrafficFactory.WaitingLaderTypesReport(FromDate, FromTime, ToDate, ToTime, LaderTypeID_int, ref AllDataTable);
                this.DataSource = AllDataTable;
                WaitingLaderTypeschartControl.DataSource = AllDataTable;

                this.WaitingLaderTypeschartControl.Series[0].ValueMemberX = AllDataTable.Columns["Date_nvc"].ColumnName;
               
                this.WaitingLaderTypeschartControl.Series[0].ValueMembersY = AllDataTable.Columns["TurnRemainedCount_int"].ColumnName;
 

                DataDynamics.ActiveReports.Chart.Graphics.Backdrop wbdrop0 = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop();
                wbdrop0.Style = BackdropStyle.Solid;
                wbdrop0.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(249)))), ((int)(((byte)(115)))));
                wbdrop0.Alpha = 255;

                this.WaitingLaderTypeschartControl.Series[0].Backdrop = wbdrop0;



                this.WaitingLaderTypeschartControl.ChartAreas[0].Axes["AxisY"].SmartLabels = false;
                this.WaitingLaderTypeschartControl.ChartAreas[0].Axes["AxisY"].MajorTick.Step = 1;
                this.WaitingLaderTypeschartControl.ChartAreas[0].Axes["AxisY"].LabelsVisible = true;
                this.WaitingLaderTypeschartControl.ChartAreas[0].Axes["AxisY"].MajorTick.GridLine = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.AliceBlue, 1);
                this.WaitingLaderTypeschartControl.ChartAreas[0].Axes["AxisY"].MajorTick.Visible = true;

                this.WaitingLaderTypeschartControl.ChartAreas[0].Axes[0].LabelFont.Angle = 290;

                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
               

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }


        }
    }
}
