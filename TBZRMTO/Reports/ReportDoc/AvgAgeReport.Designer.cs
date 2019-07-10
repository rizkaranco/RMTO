namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for AvgAgeReport.
    /// </summary>
    partial class AvgAgeReport
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AvgAgeReport));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.shape1 = new DataDynamics.ActiveReports.Shape();
            this.shape2 = new DataDynamics.ActiveReports.Shape();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.UserNametxt = new DataDynamics.ActiveReports.TextBox();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.FromDatetxt = new DataDynamics.ActiveReports.TextBox();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.ToDatetxt = new DataDynamics.ActiveReports.TextBox();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.FromTimetxt = new DataDynamics.ActiveReports.TextBox();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.ToTimetxt = new DataDynamics.ActiveReports.TextBox();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.Datetxt = new DataDynamics.ActiveReports.TextBox();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.Timetxt = new DataDynamics.ActiveReports.TextBox();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.shape3 = new DataDynamics.ActiveReports.Shape();
            this.AgeAvgtextBox = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNametxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDatetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDatetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromTimetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToTimetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeAvgtextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.shape1,
            this.shape2,
            this.label10,
            this.label2,
            this.UserNametxt,
            this.label1,
            this.FromDatetxt,
            this.label3,
            this.ToDatetxt,
            this.label4,
            this.FromTimetxt,
            this.label5,
            this.ToTimetxt,
            this.label6,
            this.Datetxt,
            this.label7,
            this.label8,
            this.Timetxt});
            this.pageHeader.Height = 2.052083F;
            this.pageHeader.Name = "pageHeader";
            // 
            // shape1
            // 
            this.shape1.Height = 1.520834F;
            this.shape1.Left = 0.125F;
            this.shape1.Name = "shape1";
            this.shape1.RoundingRadius = 9.999999F;
            this.shape1.Top = 0F;
            this.shape1.Width = 3.885417F;
            // 
            // shape2
            // 
            this.shape2.BackColor = System.Drawing.Color.Gainsboro;
            this.shape2.Height = 0.3020833F;
            this.shape2.Left = 0.6562497F;
            this.shape2.Name = "shape2";
            this.shape2.RoundingRadius = 9.999999F;
            this.shape2.Top = 1.739584F;
            this.shape2.Width = 2.6875F;
            // 
            // label10
            // 
            this.label10.Height = 0.2395834F;
            this.label10.HyperLink = null;
            this.label10.Left = 1.125F;
            this.label10.Name = "label10";
            this.label10.RightToLeft = true;
            this.label10.Style = "font-family: B Mitra; font-size: 11.25pt; font-weight: bold; text-align: center; " +
    "vertical-align: middle; ddo-char-set: 178";
            this.label10.Text = "میانگین سال ساخت ناوگان";
            this.label10.Top = 1.770834F;
            this.label10.Width = 1.760417F;
            // 
            // label2
            // 
            this.label2.Height = 0.1979167F;
            this.label2.HyperLink = null;
            this.label2.Left = 2.791667F;
            this.label2.Name = "label2";
            this.label2.RightToLeft = true;
            this.label2.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label2.Text = "تهیه کننده :";
            this.label2.Top = 0.9583333F;
            this.label2.Width = 0.59375F;
            // 
            // UserNametxt
            // 
            this.UserNametxt.Height = 0.1979167F;
            this.UserNametxt.Left = 1.958334F;
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.RightToLeft = true;
            this.UserNametxt.Style = "font-family: B Nazanin; font-size: 9.75pt; text-align: left; ddo-char-set: 178";
            this.UserNametxt.Text = "textBox1";
            this.UserNametxt.Top = 0.9479167F;
            this.UserNametxt.Width = 0.7083333F;
            // 
            // label1
            // 
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Height = 0.3333333F;
            this.label1.HyperLink = null;
            this.label1.Left = 1.135415F;
            this.label1.Name = "label1";
            this.label1.Style = "font-family: B Mitra; font-size: 12pt; font-weight: bold; text-align: right; ddo-" +
    "char-set: 178";
            this.label1.Text = "گزارش میانگین سال ساخت ناوگان ورودی";
            this.label1.Top = 0.06250004F;
            this.label1.Width = 2.104166F;
            // 
            // FromDatetxt
            // 
            this.FromDatetxt.Height = 0.1979167F;
            this.FromDatetxt.Left = 2.032809F;
            this.FromDatetxt.Name = "FromDatetxt";
            this.FromDatetxt.RightToLeft = true;
            this.FromDatetxt.Style = "font-family: B Nazanin; font-size: 9.75pt; ddo-char-set: 178";
            this.FromDatetxt.Text = "textBox1";
            this.FromDatetxt.Top = 0.4375F;
            this.FromDatetxt.Width = 0.6338583F;
            // 
            // label3
            // 
            this.label3.Height = 0.1979167F;
            this.label3.HyperLink = null;
            this.label3.Left = 2.927084F;
            this.label3.Name = "label3";
            this.label3.RightToLeft = true;
            this.label3.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label3.Text = "از تاریخ :";
            this.label3.Top = 0.4375F;
            this.label3.Width = 0.4583333F;
            // 
            // ToDatetxt
            // 
            this.ToDatetxt.Height = 0.1979167F;
            this.ToDatetxt.Left = 0.7916667F;
            this.ToDatetxt.Name = "ToDatetxt";
            this.ToDatetxt.RightToLeft = true;
            this.ToDatetxt.Style = "font-family: B Nazanin; font-size: 9.75pt; ddo-char-set: 178";
            this.ToDatetxt.Text = "1389/05/15";
            this.ToDatetxt.Top = 0.4166667F;
            this.ToDatetxt.Width = 0.6354167F;
            // 
            // label4
            // 
            this.label4.Height = 0.1979167F;
            this.label4.HyperLink = null;
            this.label4.Left = 1.4375F;
            this.label4.Name = "label4";
            this.label4.RightToLeft = true;
            this.label4.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label4.Text = "تا تاریخ :";
            this.label4.Top = 0.4166667F;
            this.label4.Width = 0.4479167F;
            // 
            // FromTimetxt
            // 
            this.FromTimetxt.Height = 0.1979167F;
            this.FromTimetxt.Left = 2.197917F;
            this.FromTimetxt.Name = "FromTimetxt";
            this.FromTimetxt.RightToLeft = true;
            this.FromTimetxt.Style = "font-family: B Nazanin; font-size: 9.75pt; ddo-char-set: 178";
            this.FromTimetxt.Text = "textBox1";
            this.FromTimetxt.Top = 0.6979167F;
            this.FromTimetxt.Width = 0.46875F;
            // 
            // label5
            // 
            this.label5.Height = 0.1979167F;
            this.label5.HyperLink = null;
            this.label5.Left = 2.968751F;
            this.label5.Name = "label5";
            this.label5.RightToLeft = true;
            this.label5.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label5.Text = "ساعت :";
            this.label5.Top = 0.6979167F;
            this.label5.Width = 0.4166667F;
            // 
            // ToTimetxt
            // 
            this.ToTimetxt.Height = 0.1979167F;
            this.ToTimetxt.Left = 0.9583334F;
            this.ToTimetxt.Name = "ToTimetxt";
            this.ToTimetxt.RightToLeft = true;
            this.ToTimetxt.Style = "font-family: B Nazanin; font-size: 9.75pt; ddo-char-set: 178";
            this.ToTimetxt.Text = "15:15:15";
            this.ToTimetxt.Top = 0.6979167F;
            this.ToTimetxt.Width = 0.46875F;
            // 
            // label6
            // 
            this.label6.Height = 0.1979167F;
            this.label6.HyperLink = null;
            this.label6.Left = 1.489583F;
            this.label6.Name = "label6";
            this.label6.RightToLeft = true;
            this.label6.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label6.Text = "ساعت :";
            this.label6.Top = 1.208333F;
            this.label6.Width = 0.3958333F;
            // 
            // Datetxt
            // 
            this.Datetxt.Height = 0.1979167F;
            this.Datetxt.Left = 2.03125F;
            this.Datetxt.Name = "Datetxt";
            this.Datetxt.RightToLeft = true;
            this.Datetxt.Style = "font-family: B Nazanin; font-size: 9.75pt; text-align: left; ddo-char-set: 178";
            this.Datetxt.Text = "textBox1";
            this.Datetxt.Top = 1.208333F;
            this.Datetxt.Width = 0.6354167F;
            // 
            // label7
            // 
            this.label7.Height = 0.1979167F;
            this.label7.HyperLink = null;
            this.label7.Left = 3.041667F;
            this.label7.Name = "label7";
            this.label7.RightToLeft = true;
            this.label7.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label7.Text = "تاریخ :";
            this.label7.Top = 1.208333F;
            this.label7.Width = 0.34375F;
            // 
            // label8
            // 
            this.label8.Height = 0.1979167F;
            this.label8.HyperLink = null;
            this.label8.Left = 1.489583F;
            this.label8.Name = "label8";
            this.label8.RightToLeft = true;
            this.label8.Style = "font-family: B Mitra; font-size: 9.75pt; font-weight: bold; ddo-char-set: 178";
            this.label8.Text = "ساعت :";
            this.label8.Top = 0.6979167F;
            this.label8.Width = 0.3958333F;
            // 
            // Timetxt
            // 
            this.Timetxt.Height = 0.1979167F;
            this.Timetxt.Left = 0.8020834F;
            this.Timetxt.Name = "Timetxt";
            this.Timetxt.RightToLeft = true;
            this.Timetxt.Style = "font-family: B Nazanin; font-size: 9.75pt; text-align: left; ddo-char-set: 178";
            this.Timetxt.Text = "textBox1";
            this.Timetxt.Top = 1.208333F;
            this.Timetxt.Width = 0.625F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.shape3,
            this.AgeAvgtextBox});
            this.detail.Height = 0.3125F;
            this.detail.Name = "detail";
            // 
            // shape3
            // 
            this.shape3.Height = 0.2708333F;
            this.shape3.Left = 0.6562497F;
            this.shape3.Name = "shape3";
            this.shape3.RoundingRadius = 9.999999F;
            this.shape3.Top = 0F;
            this.shape3.Width = 2.6875F;
            // 
            // AgeAvgtextBox
            // 
            this.AgeAvgtextBox.Height = 0.1979167F;
            this.AgeAvgtextBox.Left = 1.427083F;
            this.AgeAvgtextBox.Name = "AgeAvgtextBox";
            this.AgeAvgtextBox.RightToLeft = true;
            this.AgeAvgtextBox.Style = "font-family: B Nazanin; font-size: 9.75pt; text-align: center; ddo-char-set: 178";
            this.AgeAvgtextBox.Text = null;
            this.AgeAvgtextBox.Top = 0.03125F;
            this.AgeAvgtextBox.Width = 1.260417F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0.01041667F;
            this.pageFooter.Name = "pageFooter";
            // 
            // AvgAgeReport
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0.3937007F;
            this.PageSettings.Margins.Left = 0.7874016F;
            this.PageSettings.Margins.Right = 0.7874016F;
            this.PageSettings.Margins.Top = 0.7874016F;
            this.PageSettings.PaperHeight = 8.267716F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.PageSettings.PaperWidth = 5.826772F;
            this.PrintWidth = 4.145833F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNametxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDatetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDatetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromTimetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToTimetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeAvgtextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Shape shape2;
        private DataDynamics.ActiveReports.Label label10;
        private DataDynamics.ActiveReports.Shape shape3;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.TextBox UserNametxt;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Shape shape1;
        private DataDynamics.ActiveReports.TextBox FromDatetxt;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.TextBox ToDatetxt;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.TextBox FromTimetxt;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.TextBox ToTimetxt;
        private DataDynamics.ActiveReports.Label label6;
        private DataDynamics.ActiveReports.TextBox Datetxt;
        private DataDynamics.ActiveReports.Label label7;
        private DataDynamics.ActiveReports.Label label8;
        private DataDynamics.ActiveReports.TextBox Timetxt;
        private DataDynamics.ActiveReports.TextBox AgeAvgtextBox;
    }
}
