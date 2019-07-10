namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for TruckUsedLadBillReport.
    /// </summary>
    partial class TruckUsedLadBillReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckUsedLadBillReport));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.label22 = new DataDynamics.ActiveReports.Label();
            this.picture1 = new DataDynamics.ActiveReports.Picture();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label22,
            this.picture1,
            this.label1});
            this.pageHeader.Height = 1.53125F;
            this.pageHeader.Name = "pageHeader";
            // 
            // label22
            // 
            this.label22.Height = 0.3645833F;
            this.label22.HyperLink = null;
            this.label22.Left = 2.020866F;
            this.label22.Name = "label22";
            this.label22.Style = "font-family: B Zar; font-size: 14pt; font-weight: bold; text-align: right; ddo-ch" +
    "ar-set: 178";
            this.label22.Text = "اداره کل حمل و نقل و پایانه های آذربایجان شرقی";
            this.label22.Top = 0.1043307F;
            this.label22.Width = 3.562499F;
            // 
            // picture1
            // 
            this.picture1.Height = 0.8958333F;
            this.picture1.ImageData = ((System.IO.Stream)(resources.GetObject("picture1.ImageData")));
            this.picture1.Left = 6.948032F;
            this.picture1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picture1.Name = "picture1";
            this.picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch;
            this.picture1.Top = 0.1043307F;
            this.picture1.Width = 0.8645833F;
            // 
            // label1
            // 
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Height = 0.3854167F;
            this.label1.HyperLink = null;
            this.label1.Left = 1.484252F;
            this.label1.Name = "label1";
            this.label1.Style = "background-color: #DFEAFD; font-family: B Titr; font-size: 14pt; font-weight: bol" +
    "d; text-align: center; ddo-char-set: 178";
            this.label1.Text = "بارنامه های صادر شده برای کامیون از آخرین نوبت تایید شده";
            this.label1.Top = 0.5417323F;
            this.label1.Width = 4.593717F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Height = 1.010417F;
            this.detail.Name = "detail";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 1.041667F;
            this.pageFooter.Name = "pageFooter";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Height = 0.3958333F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // groupFooter1
            // 
            this.groupFooter1.Height = 0.7395834F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // TruckUsedLadBillReport
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 8.395834F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.label22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.Label label22;
        private DataDynamics.ActiveReports.Picture picture1;
        private DataDynamics.ActiveReports.Label label1;
    }
}
