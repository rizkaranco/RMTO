namespace HPS.Reports.Forms
{
    partial class LederTypeCountReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Janus.Windows.GridEX.GridEXLayout LaderTypecheckedComboBox_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LederTypeCountReportForm));
            this.ExistsLaderTypeGridView = new System.Windows.Forms.DataGridView();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.LaderTypecheckedComboBox = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChartShowButton = new Janus.Windows.EditControls.UIButton();
            this.WithDateButton = new Janus.Windows.EditControls.UIButton();
            this.ExistLaderTypeButtonButton = new Janus.Windows.EditControls.UIButton();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.LederTypeCountReportstiReport = new Stimulsoft.Report.StiReport();
            this.LaderTypeCountChartstiReport = new Stimulsoft.Report.StiReport();
            this.LaderTypeCountWithDateReportstiReport = new Stimulsoft.Report.StiReport();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            ((System.ComponentModel.ISupportInitialize)(this.ExistsLaderTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExistsLaderTypeGridView
            // 
            this.ExistsLaderTypeGridView.AllowUserToAddRows = false;
            this.ExistsLaderTypeGridView.AllowUserToDeleteRows = false;
            this.ExistsLaderTypeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.ExistsLaderTypeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExistsLaderTypeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ExistsLaderTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExistsLaderTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLaderType_nvc});
            this.ExistsLaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExistsLaderTypeGridView.Location = new System.Drawing.Point(138, 3);
            this.ExistsLaderTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.ExistsLaderTypeGridView.Name = "ExistsLaderTypeGridView";
            this.ExistsLaderTypeGridView.ReadOnly = true;
            this.ExistsLaderTypeGridView.RowHeadersVisible = false;
            this.ExistsLaderTypeGridView.Size = new System.Drawing.Size(843, 576);
            this.ExistsLaderTypeGridView.TabIndex = 8;
            this.ExistsLaderTypeGridView.Visible = false;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نام بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 908;
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("1e9751fa-e4b3-4c0a-99df-d0bedfe54b19");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("1e9751fa-e4b3-4c0a-99df-d0bedfe54b19"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 576), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("1e9751fa-e4b3-4c0a-99df-d0bedfe54b19"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiPanel0.Size = new System.Drawing.Size(135, 576);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.LaderTypecheckedComboBox);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.ChartShowButton);
            this.uiPanel0Container.Controls.Add(this.WithDateButton);
            this.uiPanel0Container.Controls.Add(this.ExistLaderTypeButtonButton);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 546);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // LaderTypecheckedComboBox
            // 
            LaderTypecheckedComboBox_DesignTimeLayout.LayoutString = resources.GetString("LaderTypecheckedComboBox_DesignTimeLayout.LayoutString");
            this.LaderTypecheckedComboBox.DesignTimeLayout = LaderTypecheckedComboBox_DesignTimeLayout;
            this.LaderTypecheckedComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaderTypecheckedComboBox.Location = new System.Drawing.Point(10, 272);
            this.LaderTypecheckedComboBox.Name = "LaderTypecheckedComboBox";
            this.LaderTypecheckedComboBox.SaveSettings = false;
            this.LaderTypecheckedComboBox.Size = new System.Drawing.Size(107, 22);
            this.LaderTypecheckedComboBox.TabIndex = 96;
            this.LaderTypecheckedComboBox.ValuesDataMember = null;
            this.LaderTypecheckedComboBox.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.LaderTypecheckedComboBox.CheckedValuesChanged += new System.EventHandler(this.LaderTypecheckedComboBox_CheckedValuesChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(67, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 93;
            this.label5.Text = "نوع بارگیر";
            // 
            // ChartShowButton
            // 
            this.ChartShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChartShowButton.Location = new System.Drawing.Point(11, 347);
            this.ChartShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChartShowButton.Name = "ChartShowButton";
            this.ChartShowButton.Size = new System.Drawing.Size(108, 29);
            this.ChartShowButton.TabIndex = 95;
            this.ChartShowButton.Text = "نمایش نموداری";
            this.ChartShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ChartShowButton.Click += new System.EventHandler(this.ChartShowButton_Click);
            // 
            // WithDateButton
            // 
            this.WithDateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WithDateButton.Location = new System.Drawing.Point(5, 387);
            this.WithDateButton.Margin = new System.Windows.Forms.Padding(2);
            this.WithDateButton.Name = "WithDateButton";
            this.WithDateButton.Size = new System.Drawing.Size(120, 29);
            this.WithDateButton.TabIndex = 94;
            this.WithDateButton.Text = "نمایش به تفکیک تاریخ";
            this.WithDateButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.WithDateButton.Click += new System.EventHandler(this.WithDateButton_Click);
            // 
            // ExistLaderTypeButtonButton
            // 
            this.ExistLaderTypeButtonButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ExistLaderTypeButtonButton.Location = new System.Drawing.Point(10, 225);
            this.ExistLaderTypeButtonButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExistLaderTypeButtonButton.Name = "ExistLaderTypeButtonButton";
            this.ExistLaderTypeButtonButton.Size = new System.Drawing.Size(108, 29);
            this.ExistLaderTypeButtonButton.TabIndex = 90;
            this.ExistLaderTypeButtonButton.Text = "بارگیرهای موجود";
            this.ExistLaderTypeButtonButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ExistLaderTypeButtonButton.Click += new System.EventHandler(this.ExistsLaderyTypeButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(10, 307);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 92;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(101, 107);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 89;
            this.DefaulCheckBox.ToolTipText = "ساعات بین 00:00:00 و 23:59:59";
            this.DefaulCheckBox.CheckedChanged += new System.EventHandler(this.DefaulCheckBox_CheckedChanged);
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.FromTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.RefreshHourbutton);
            this.TimeGroupBox.Controls.Add(this.label3);
            this.TimeGroupBox.Controls.Add(this.ToTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.label4);
            this.TimeGroupBox.Enabled = false;
            this.TimeGroupBox.Location = new System.Drawing.Point(3, 105);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(124, 110);
            this.TimeGroupBox.TabIndex = 88;
            this.TimeGroupBox.TabStop = false;
            // 
            // FromTimeTextBox
            // 
            this.FromTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTimeTextBox.Location = new System.Drawing.Point(3, 20);
            this.FromTimeTextBox.Mask = "00:00:00";
            this.FromTimeTextBox.Name = "FromTimeTextBox";
            this.FromTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromTimeTextBox.Size = new System.Drawing.Size(60, 22);
            this.FromTimeTextBox.TabIndex = 59;
            this.FromTimeTextBox.Text = "000000";
            this.FromTimeTextBox.Click += new System.EventHandler(this.FromTimeTextBox_Click);
            // 
            // RefreshHourbutton
            // 
            this.RefreshHourbutton.Image = global::HPS.Properties.Resources.Refresh16;
            this.RefreshHourbutton.Location = new System.Drawing.Point(3, 80);
            this.RefreshHourbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshHourbutton.Name = "RefreshHourbutton";
            this.RefreshHourbutton.Size = new System.Drawing.Size(24, 24);
            this.RefreshHourbutton.TabIndex = 61;
            this.RefreshHourbutton.UseVisualStyleBackColor = true;
            this.RefreshHourbutton.Click += new System.EventHandler(this.RefreshHourbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(61, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 65;
            this.label3.Text = "از ساعت :";
            // 
            // ToTimeTextBox
            // 
            this.ToTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTimeTextBox.Location = new System.Drawing.Point(3, 53);
            this.ToTimeTextBox.Mask = "00:00:00";
            this.ToTimeTextBox.Name = "ToTimeTextBox";
            this.ToTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToTimeTextBox.Size = new System.Drawing.Size(60, 22);
            this.ToTimeTextBox.TabIndex = 60;
            this.ToTimeTextBox.Text = "235959";
            this.ToTimeTextBox.Click += new System.EventHandler(this.ToTimeTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(61, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "تا ساعت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(82, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 87;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(82, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 86;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(10, 27);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.FromDatefaDatePicker.TabIndex = 84;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(10, 79);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.ToDatefaDatePicker.TabIndex = 85;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // LederTypeCountReportstiReport
            // 
            this.LederTypeCountReportstiReport.CookieContainer = null;
            this.LederTypeCountReportstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.LederTypeCountReportstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.LederTypeCountReportstiReport.ReportAlias = "Report";
            this.LederTypeCountReportstiReport.ReportGuid = "41307165947a44e189c18dabf69a60af";
            this.LederTypeCountReportstiReport.ReportImage = null;
            this.LederTypeCountReportstiReport.ReportName = "Report";
            this.LederTypeCountReportstiReport.ReportSource = resources.GetString("LederTypeCountReportstiReport.ReportSource");
            this.LederTypeCountReportstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.LederTypeCountReportstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.LederTypeCountReportstiReport.UseProgressInThread = false;
            // 
            // LaderTypeCountChartstiReport
            // 
            this.LaderTypeCountChartstiReport.CookieContainer = null;
            this.LaderTypeCountChartstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.LaderTypeCountChartstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.LaderTypeCountChartstiReport.ReportAlias = "Report";
            this.LaderTypeCountChartstiReport.ReportGuid = "305f15a97f614948a6f1446dce65b000";
            this.LaderTypeCountChartstiReport.ReportImage = null;
            this.LaderTypeCountChartstiReport.ReportName = "Report";
            this.LaderTypeCountChartstiReport.ReportSource = resources.GetString("LaderTypeCountChartstiReport.ReportSource");
            this.LaderTypeCountChartstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.LaderTypeCountChartstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.LaderTypeCountChartstiReport.UseProgressInThread = false;
            // 
            // LaderTypeCountWithDateReportstiReport
            // 
            this.LaderTypeCountWithDateReportstiReport.CookieContainer = null;
            this.LaderTypeCountWithDateReportstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.LaderTypeCountWithDateReportstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.LaderTypeCountWithDateReportstiReport.ReportAlias = "Report";
            this.LaderTypeCountWithDateReportstiReport.ReportGuid = "1d412059cc9f40e38bdf2d9fe3ff52cd";
            this.LaderTypeCountWithDateReportstiReport.ReportImage = null;
            this.LaderTypeCountWithDateReportstiReport.ReportName = "Report";
            this.LaderTypeCountWithDateReportstiReport.ReportSource = resources.GetString("LaderTypeCountWithDateReportstiReport.ReportSource");
            this.LaderTypeCountWithDateReportstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.LaderTypeCountWithDateReportstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.LaderTypeCountWithDateReportstiReport.UseProgressInThread = false;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(138, 3);
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
            this.stiViewerControl1.Size = new System.Drawing.Size(843, 576);
            this.stiViewerControl1.TabIndex = 9;
            this.stiViewerControl1.Load += new System.EventHandler(this.stiViewerControl1_Load);
            // 
            // LederTypeCountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.ExistsLaderTypeGridView);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "LederTypeCountReportForm";
            this.Text = "تعداد مجوز(حواله) های صادر شده و جا مانده بر اساس انواع بارگیر";
            this.Load += new System.EventHandler(this.LederTypeCountReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExistsLaderTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExistsLaderTypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton ExistLaderTypeButtonButton;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private Janus.Windows.EditControls.UIButton ChartShowButton;
        private Janus.Windows.EditControls.UIButton WithDateButton;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox LaderTypecheckedComboBox;
        private Stimulsoft.Report.StiReport LederTypeCountReportstiReport;
        private Stimulsoft.Report.StiReport LaderTypeCountChartstiReport;
        private Stimulsoft.Report.StiReport LaderTypeCountWithDateReportstiReport;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}