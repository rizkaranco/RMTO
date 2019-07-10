namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for NewActiveReport1.
    /// </summary>
    partial class NewActiveReport1
    {
        private DataDynamics.ActiveReports.PageHeader pageHeader;
        private DataDynamics.ActiveReports.Detail detail;
        private DataDynamics.ActiveReports.PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NewActiveReport1));
            DataDynamics.ActiveReports.Chart.ChartArea chartArea2 = new DataDynamics.ActiveReports.Chart.ChartArea();
            DataDynamics.ActiveReports.Chart.Axis axis6 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis7 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis8 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis9 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis10 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Legend legend2 = new DataDynamics.ActiveReports.Chart.Legend();
            DataDynamics.ActiveReports.Chart.Title title5 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Title title6 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Series series4 = new DataDynamics.ActiveReports.Chart.Series();
            DataDynamics.ActiveReports.Chart.Series series5 = new DataDynamics.ActiveReports.Chart.Series();
            DataDynamics.ActiveReports.Chart.Series series6 = new DataDynamics.ActiveReports.Chart.Series();
            DataDynamics.ActiveReports.Chart.Title title7 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Title title8 = new DataDynamics.ActiveReports.Chart.Title();
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.chartControl1 = new DataDynamics.ActiveReports.ChartControl();
            this.checkBox1 = new DataDynamics.ActiveReports.CheckBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.label1 = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Height = 0.25F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.chartControl1,
            this.checkBox1,
            this.label1});
            this.detail.Height = 2.520866F;
            this.detail.Name = "detail";
            // 
            // chartControl1
            // 
            this.chartControl1.AutoRefresh = true;
            this.chartControl1.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.SteelBlue);
            chartArea2.AntiAliasMode = DataDynamics.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
            axis6.AxisType = DataDynamics.ActiveReports.Chart.AxisType.Categorical;
            axis6.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis6.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
            axis6.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis6.SmartLabels = false;
            axis6.Title = "Axis X";
            axis6.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis7.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis7.LabelsGap = 0;
            axis7.LabelsVisible = false;
            axis7.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis7.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis7.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis7.Position = 0D;
            axis7.TickOffset = 0D;
            axis7.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis7.Visible = false;
            axis8.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis8.LabelsVisible = false;
            axis8.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis8.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis8.Position = 0D;
            axis8.Title = "Axis Y";
            axis8.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), -90F);
            axis9.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis9.LabelsVisible = false;
            axis9.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis9.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis9.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis9.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis9.Visible = false;
            axis10.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis10.LabelsGap = 0;
            axis10.LabelsVisible = false;
            axis10.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis10.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis10.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis10.Position = 0D;
            axis10.TickOffset = 0D;
            axis10.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis10.Visible = false;
            chartArea2.Axes.AddRange(new DataDynamics.ActiveReports.Chart.AxisBase[] {
            axis6,
            axis7,
            axis8,
            axis9,
            axis10});
            chartArea2.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
            chartArea2.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            chartArea2.Light = new DataDynamics.ActiveReports.Chart.Light(new DataDynamics.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), DataDynamics.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3F);
            chartArea2.Name = "defaultArea";
            chartArea2.Projection = new DataDynamics.ActiveReports.Chart.Projection(DataDynamics.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1F, 0.1F);
            this.chartControl1.ChartAreas.AddRange(new DataDynamics.ActiveReports.Chart.ChartArea[] {
            chartArea2});
            this.chartControl1.ChartBorder = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            this.chartControl1.ColorPalette = DataDynamics.ActiveReports.Chart.ColorPalette.Autumn;
            this.chartControl1.Height = 1.75F;
            this.chartControl1.Left = 0.1767716F;
            legend2.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Right;
            legend2.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, ((byte)(128)));
            legend2.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(), 0, System.Drawing.Color.Black);
            legend2.DockArea = chartArea2;
            title5.Backdrop = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
            title5.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title5.DockArea = null;
            title5.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title5.Name = "";
            title5.Text = "";
            legend2.Footer = title5;
            title6.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black);
            title6.DockArea = null;
            title6.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title6.Name = "";
            title6.Text = "Legend";
            legend2.Header = title6;
            legend2.LabelsFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            legend2.Name = "defaultLegend";
            this.chartControl1.Legends.AddRange(new DataDynamics.ActiveReports.Chart.Legend[] {
            legend2});
            this.chartControl1.Name = "chartControl1";
            series4.AxisX = axis6;
            series4.AxisY = axis8;
            series4.ChartArea = chartArea2;
            series4.Legend = legend2;
            series4.LegendText = "";
            series4.Name = "Series1";
            series4.Properties = new DataDynamics.ActiveReports.Chart.CustomProperties(new DataDynamics.ActiveReports.Chart.KeyValuePair[] {
            new DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Cylinder)});
            series4.Type = DataDynamics.ActiveReports.Chart.ChartType.Bar3D;
            series4.ValueMembersY = null;
            series4.ValueMemberX = null;
            series5.AxisX = axis6;
            series5.AxisY = axis8;
            series5.ChartArea = chartArea2;
            series5.Legend = legend2;
            series5.LegendText = "";
            series5.Name = "Series2";
            series5.Properties = new DataDynamics.ActiveReports.Chart.CustomProperties(new DataDynamics.ActiveReports.Chart.KeyValuePair[] {
            new DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Cylinder)});
            series5.Type = DataDynamics.ActiveReports.Chart.ChartType.Bar3D;
            series5.ValueMembersY = null;
            series5.ValueMemberX = null;
            series6.AxisX = axis6;
            series6.AxisY = axis8;
            series6.ChartArea = chartArea2;
            series6.Legend = legend2;
            series6.LegendText = "";
            series6.Name = "Series3";
            series6.Properties = new DataDynamics.ActiveReports.Chart.CustomProperties(new DataDynamics.ActiveReports.Chart.KeyValuePair[] {
            new DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Cylinder)});
            series6.Type = DataDynamics.ActiveReports.Chart.ChartType.Bar3D;
            series6.ValueMembersY = null;
            series6.ValueMemberX = null;
            this.chartControl1.Series.AddRange(new DataDynamics.ActiveReports.Chart.Series[] {
            series4,
            series5,
            series6});
            title7.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Center;
            title7.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title7.DockArea = null;
            title7.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title7.Name = "header";
            title7.Text = "Chart title";
            title8.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title8.DockArea = null;
            title8.Docking = DataDynamics.ActiveReports.Chart.DockType.Bottom;
            title8.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title8.Name = "footer";
            title8.Text = "Chart Footer";
            this.chartControl1.Titles.AddRange(new DataDynamics.ActiveReports.Chart.Title[] {
            title7,
            title8});
            this.chartControl1.Top = 0.2917323F;
            this.chartControl1.UIOptions = DataDynamics.ActiveReports.Chart.UIOptions.ForceHitTesting;
            this.chartControl1.Width = 3F;
            // 
            // checkBox1
            // 
            this.checkBox1.Height = 0.2F;
            this.checkBox1.Left = 3.698F;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Style = "";
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.Top = 1.562F;
            this.checkBox1.Width = 1F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0.25F;
            this.pageFooter.Name = "pageFooter";
            // 
            // label1
            // 
            this.label1.Height = 0.2F;
            this.label1.HyperLink = null;
            this.label1.Left = 3.844F;
            this.label1.Name = "label1";
            this.label1.Style = "";
            this.label1.Text = "label1";
            this.label1.Top = 0.459F;
            this.label1.Width = 1F;
            // 
            // NewActiveReport1
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6.5F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.ChartControl chartControl1;
        private DataDynamics.ActiveReports.CheckBox checkBox1;
        private DataDynamics.ActiveReports.Label label1;
    }
}
