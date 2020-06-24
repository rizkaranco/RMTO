namespace HPS.Reports.Forms
{
    partial class InNotOutTrafficReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InNotOutTrafficReportForm));
            this.LaderPivotGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.AllIranianCarRadioButton = new System.Windows.Forms.RadioButton();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.LaderTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowByLaderTypeButton = new Janus.Windows.EditControls.UIButton();
            this.ServicesComboBox = new System.Windows.Forms.ComboBox();
            this.TrafficTypeComboBox = new System.Windows.Forms.ComboBox();
            this.devicesLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllCountButton = new Janus.Windows.EditControls.UIButton();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.InNotOutTrafficByLaderTypestiReport = new Stimulsoft.Report.StiReport();
            this.InNotOutTrafficstiReport = new Stimulsoft.Report.StiReport();
            this.IranianInNotOutStiReport = new Stimulsoft.Report.StiReport();
            this.ForeignInNotOutstiReport = new Stimulsoft.Report.StiReport();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.OtherInNotOutReportstiReport = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaderPivotGroupID_intComboBox
            // 
            this.LaderPivotGroupID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderPivotGroupID_intComboBox.FormattingEnabled = true;
            this.LaderPivotGroupID_intComboBox.Location = new System.Drawing.Point(4, 74);
            this.LaderPivotGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupID_intComboBox.Name = "LaderPivotGroupID_intComboBox";
            this.LaderPivotGroupID_intComboBox.Size = new System.Drawing.Size(115, 22);
            this.LaderPivotGroupID_intComboBox.TabIndex = 1;
            this.LaderPivotGroupID_intComboBox.SelectedIndexChanged += new System.EventHandler(this.LaderPivotGroupID_intComboBox_SelectedIndexChanged);
            this.LaderPivotGroupID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.LaderPivotGroupID_intComboBox_SelectionChangeCommitted);
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(60, 55);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(59, 14);
            this.LaderPivotGroupID_intLabel.TabIndex = 24;
            this.LaderPivotGroupID_intLabel.Text = "تعداد محور";
            // 
            // AllIranianCarRadioButton
            // 
            this.AllIranianCarRadioButton.AutoSize = true;
            this.AllIranianCarRadioButton.Checked = true;
            this.AllIranianCarRadioButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllIranianCarRadioButton.Location = new System.Drawing.Point(23, 19);
            this.AllIranianCarRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.AllIranianCarRadioButton.Name = "AllIranianCarRadioButton";
            this.AllIranianCarRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllIranianCarRadioButton.Size = new System.Drawing.Size(96, 18);
            this.AllIranianCarRadioButton.TabIndex = 0;
            this.AllIranianCarRadioButton.TabStop = true;
            this.AllIranianCarRadioButton.Text = "تمامی محورها";
            this.AllIranianCarRadioButton.UseVisualStyleBackColor = true;
            this.AllIranianCarRadioButton.CheckedChanged += new System.EventHandler(this.AllIranianCarRadioButton_CheckedChanged);
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("fd2542a5-c56b-4294-b554-6901a1669fbd");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("fd2542a5-c56b-4294-b554-6901a1669fbd"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(185, 556), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("fd2542a5-c56b-4294-b554-6901a1669fbd"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiPanel0.Size = new System.Drawing.Size(185, 556);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.LaderTypeID_intComboBox);
            this.uiPanel0Container.Controls.Add(this.label7);
            this.uiPanel0Container.Controls.Add(this.ShowByLaderTypeButton);
            this.uiPanel0Container.Controls.Add(this.ServicesComboBox);
            this.uiPanel0Container.Controls.Add(this.TrafficTypeComboBox);
            this.uiPanel0Container.Controls.Add(this.devicesLable);
            this.uiPanel0Container.Controls.Add(this.label3);
            this.uiPanel0Container.Controls.Add(this.groupBox1);
            this.uiPanel0Container.Controls.Add(this.AllCountButton);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(179, 526);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // LaderTypeID_intComboBox
            // 
            this.LaderTypeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LaderTypeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LaderTypeID_intComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.LaderTypeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intComboBox.FormattingEnabled = true;
            this.LaderTypeID_intComboBox.Location = new System.Drawing.Point(10, 238);
            this.LaderTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeID_intComboBox.Name = "LaderTypeID_intComboBox";
            this.LaderTypeID_intComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LaderTypeID_intComboBox.Size = new System.Drawing.Size(115, 22);
            this.LaderTypeID_intComboBox.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(68, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 48;
            this.label7.Text = "نوع بارگیر :";
            // 
            // ShowByLaderTypeButton
            // 
            this.ShowByLaderTypeButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowByLaderTypeButton.Location = new System.Drawing.Point(14, 433);
            this.ShowByLaderTypeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowByLaderTypeButton.Name = "ShowByLaderTypeButton";
            this.ShowByLaderTypeButton.Size = new System.Drawing.Size(108, 54);
            this.ShowByLaderTypeButton.TabIndex = 46;
            this.ShowByLaderTypeButton.Text = "نمایش تعداد براساس بارگیر و سواری";
            this.ShowByLaderTypeButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowByLaderTypeButton.Click += new System.EventHandler(this.ShowByLaderTypeButton_Click);
            // 
            // ServicesComboBox
            // 
            this.ServicesComboBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ServicesComboBox.FormattingEnabled = true;
            this.ServicesComboBox.Location = new System.Drawing.Point(10, 192);
            this.ServicesComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServicesComboBox.Name = "ServicesComboBox";
            this.ServicesComboBox.Size = new System.Drawing.Size(115, 22);
            this.ServicesComboBox.TabIndex = 45;
            // 
            // TrafficTypeComboBox
            // 
            this.TrafficTypeComboBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TrafficTypeComboBox.FormattingEnabled = true;
            this.TrafficTypeComboBox.ItemHeight = 14;
            this.TrafficTypeComboBox.Items.AddRange(new object[] {
            "ایرانی",
            "خارجی ",
            "سواری",
            "متفرقه"});
            this.TrafficTypeComboBox.Location = new System.Drawing.Point(10, 130);
            this.TrafficTypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficTypeComboBox.Name = "TrafficTypeComboBox";
            this.TrafficTypeComboBox.Size = new System.Drawing.Size(115, 22);
            this.TrafficTypeComboBox.TabIndex = 43;
            this.TrafficTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.devicesComboBox_SelectionChangeCommitted);
            // 
            // devicesLable
            // 
            this.devicesLable.AutoSize = true;
            this.devicesLable.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.devicesLable.Location = new System.Drawing.Point(82, 111);
            this.devicesLable.Name = "devicesLable";
            this.devicesLable.Size = new System.Drawing.Size(46, 14);
            this.devicesLable.TabIndex = 42;
            this.devicesLable.Text = "نوع تردد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 44;
            this.label3.Text = "مراجعه به ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllIranianCarRadioButton);
            this.groupBox1.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.groupBox1.Controls.Add(this.LaderPivotGroupID_intComboBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 104);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // AllCountButton
            // 
            this.AllCountButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllCountButton.Location = new System.Drawing.Point(14, 400);
            this.AllCountButton.Margin = new System.Windows.Forms.Padding(2);
            this.AllCountButton.Name = "AllCountButton";
            this.AllCountButton.Size = new System.Drawing.Size(108, 29);
            this.AllCountButton.TabIndex = 40;
            this.AllCountButton.Text = "نمایش تعداد";
            this.AllCountButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.AllCountButton.Click += new System.EventHandler(this.AllCountButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(14, 367);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 39;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(82, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "تا تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(10, 26);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.FromDatefaDatePicker.TabIndex = 35;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(82, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "از تاریخ :";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(10, 78);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.ToDatefaDatePicker.TabIndex = 36;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // InNotOutTrafficByLaderTypestiReport
            // 
            this.InNotOutTrafficByLaderTypestiReport.CookieContainer = null;
            this.InNotOutTrafficByLaderTypestiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.InNotOutTrafficByLaderTypestiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.InNotOutTrafficByLaderTypestiReport.ReportAlias = "Report";
            this.InNotOutTrafficByLaderTypestiReport.ReportGuid = "8c122d264502441ea4e0836c2da0f18f";
            this.InNotOutTrafficByLaderTypestiReport.ReportImage = null;
            this.InNotOutTrafficByLaderTypestiReport.ReportName = "Report";
            this.InNotOutTrafficByLaderTypestiReport.ReportSource = resources.GetString("InNotOutTrafficByLaderTypestiReport.ReportSource");
            this.InNotOutTrafficByLaderTypestiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.InNotOutTrafficByLaderTypestiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.InNotOutTrafficByLaderTypestiReport.UseProgressInThread = false;
            // 
            // InNotOutTrafficstiReport
            // 
            this.InNotOutTrafficstiReport.CookieContainer = null;
            this.InNotOutTrafficstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.InNotOutTrafficstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.InNotOutTrafficstiReport.ReportAlias = "Report";
            this.InNotOutTrafficstiReport.ReportGuid = "45e1e8084f874a8b8eb4c993eba24321";
            this.InNotOutTrafficstiReport.ReportImage = null;
            this.InNotOutTrafficstiReport.ReportName = "Report";
            this.InNotOutTrafficstiReport.ReportSource = resources.GetString("InNotOutTrafficstiReport.ReportSource");
            this.InNotOutTrafficstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.InNotOutTrafficstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.InNotOutTrafficstiReport.UseProgressInThread = false;
            // 
            // IranianInNotOutStiReport
            // 
            this.IranianInNotOutStiReport.CookieContainer = null;
            this.IranianInNotOutStiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.IranianInNotOutStiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.IranianInNotOutStiReport.ReportAlias = "Report";
            this.IranianInNotOutStiReport.ReportGuid = "32cf90faf9d64b96b32ada6753ffc6a1";
            this.IranianInNotOutStiReport.ReportImage = null;
            this.IranianInNotOutStiReport.ReportName = "Report";
            this.IranianInNotOutStiReport.ReportSource = resources.GetString("IranianInNotOutStiReport.ReportSource");
            this.IranianInNotOutStiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.IranianInNotOutStiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.IranianInNotOutStiReport.UseProgressInThread = false;
            // 
            // ForeignInNotOutstiReport
            // 
            this.ForeignInNotOutstiReport.CookieContainer = null;
            this.ForeignInNotOutstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ForeignInNotOutstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.ForeignInNotOutstiReport.ReportAlias = "Report";
            this.ForeignInNotOutstiReport.ReportGuid = "d18e6415b7ec4cbcb0d29de966e9c798";
            this.ForeignInNotOutstiReport.ReportImage = null;
            this.ForeignInNotOutstiReport.ReportName = "Report";
            this.ForeignInNotOutstiReport.ReportSource = resources.GetString("ForeignInNotOutstiReport.ReportSource");
            this.ForeignInNotOutstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ForeignInNotOutstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.ForeignInNotOutstiReport.UseProgressInThread = false;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(188, 3);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowBookmarksPanel = false;
            this.stiViewerControl1.ShowCloseButton = false;
            this.stiViewerControl1.ShowContextMenu = false;
            this.stiViewerControl1.ShowDotMatrixModeButton = false;
            this.stiViewerControl1.ShowEditor = false;
            this.stiViewerControl1.ShowFind = false;
            this.stiViewerControl1.ShowOpen = false;
            this.stiViewerControl1.ShowPageDelete = false;
            this.stiViewerControl1.ShowPageDesign = false;
            this.stiViewerControl1.ShowPageNew = false;
            this.stiViewerControl1.ShowPageSize = false;
            this.stiViewerControl1.ShowSaveDocumentFile = false;
            this.stiViewerControl1.ShowSendEMail = false;
            this.stiViewerControl1.ShowSendEMailDocumentFile = false;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(851, 556);
            this.stiViewerControl1.TabIndex = 6;
            // 
            // OtherInNotOutReportstiReport
            // 
            this.OtherInNotOutReportstiReport.CookieContainer = null;
            this.OtherInNotOutReportstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.OtherInNotOutReportstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.OtherInNotOutReportstiReport.ReportAlias = "Report";
            this.OtherInNotOutReportstiReport.ReportGuid = "1b585234afba44eba8c34c367494fa8c";
            this.OtherInNotOutReportstiReport.ReportImage = null;
            this.OtherInNotOutReportstiReport.ReportName = "Report";
            this.OtherInNotOutReportstiReport.ReportSource = resources.GetString("OtherInNotOutReportstiReport.ReportSource");
            this.OtherInNotOutReportstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.OtherInNotOutReportstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.OtherInNotOutReportstiReport.UseProgressInThread = false;
            // 
            // InNotOutTrafficReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 562);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "InNotOutTrafficReportForm";
            this.Text = "گزارش كاميون هاي ايراني ورودي  به  پاركينگ  خارج نشده";
            this.Load += new System.EventHandler(this.InTrafficReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LaderPivotGroupID_intComboBox;
        private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
        private System.Windows.Forms.RadioButton AllIranianCarRadioButton;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Label label2;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton AllCountButton;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label devicesLable;
        private System.Windows.Forms.ComboBox ServicesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TrafficTypeComboBox;
        private Stimulsoft.Report.StiReport InNotOutTrafficByLaderTypestiReport;
        private Stimulsoft.Report.StiReport InNotOutTrafficstiReport;
        private Janus.Windows.EditControls.UIButton ShowByLaderTypeButton;
        private System.Windows.Forms.ComboBox LaderTypeID_intComboBox;
        private System.Windows.Forms.Label label7;
        private Stimulsoft.Report.StiReport IranianInNotOutStiReport;
        private Stimulsoft.Report.StiReport ForeignInNotOutstiReport;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private Stimulsoft.Report.StiReport OtherInNotOutReportstiReport;
    }
}