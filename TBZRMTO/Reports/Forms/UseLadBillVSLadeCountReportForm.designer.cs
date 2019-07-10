namespace HPS.Reports.Forms
{
    partial class UseLadBillVSLadeCountReportForm
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
            Janus.Windows.GridEX.GridEXLayout laderTypeGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout companyGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseLadBillVSLadeCountReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.LastDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyGroupComboBox = new System.Windows.Forms.ComboBox();
            this.laderTypeGrid = new Janus.Windows.GridEX.GridEX();
            this.companyGrid = new Janus.Windows.GridEX.GridEX();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SumPanel = new System.Windows.Forms.Panel();
            this.AllLadBillCountPercent_decLabel = new System.Windows.Forms.Label();
            this.AllCarCountPercent_decLabel = new System.Windows.Forms.Label();
            this.AllUsedLadBillCount_fltLabel = new System.Windows.Forms.Label();
            this.AllLadBillCount_fltLabel = new System.Windows.Forms.Label();
            this.AllCarCount_fltlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrintstripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.UseLadBillVSLadeCountReportstiReport = new Stimulsoft.Report.StiReport();
            this.LadeAssignmentInfoGridView = new System.Windows.Forms.DataGridView();
            this.colCompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCount_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCount_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsedLadBill_flt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCountPercent_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCountPercent_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel1Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laderTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGrid)).BeginInit();
            this.SumPanel.SuspendLayout();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeAssignmentInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("2af8d3f9-ca1b-4184-a7d9-5fcb30c19260");
            this.uiPanel0.StaticGroup = true;
            this.uiPanel1.Id = new System.Guid("5179c281-9952-4de8-af5d-3add84f3c8f8");
            this.uiPanel0.Panels.Add(this.uiPanel1);
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("2af8d3f9-ca1b-4184-a7d9-5fcb30c19260"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Left, true, new System.Drawing.Size(160, 522), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("5179c281-9952-4de8-af5d-3add84f3c8f8"), new System.Guid("2af8d3f9-ca1b-4184-a7d9-5fcb30c19260"), 98, true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("daf67ab6-b893-4a1f-8b70-b8406321e960"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, true, new System.Drawing.Point(944, 445), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("decc94a0-f2b8-4680-bd07-88609ae0177a"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, true, new System.Drawing.Point(912, 431), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("2af8d3f9-ca1b-4184-a7d9-5fcb30c19260"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, true, new System.Drawing.Point(895, 404), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("5179c281-9952-4de8-af5d-3add84f3c8f8"), new System.Guid("2af8d3f9-ca1b-4184-a7d9-5fcb30c19260"), 142, false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.AllowPanelDrag = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.AllowPanelDrop = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.AllowResize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.FloatingLocation = new System.Drawing.Point(895, 404);
            this.uiPanel0.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiPanel0.Size = new System.Drawing.Size(160, 522);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel1
            // 
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(0, 22);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(156, 500);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Panel 1";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.LastDateLabel);
            this.uiPanel1Container.Controls.Add(this.label5);
            this.uiPanel1Container.Controls.Add(this.label4);
            this.uiPanel1Container.Controls.Add(this.CompanyGroupComboBox);
            this.uiPanel1Container.Controls.Add(this.laderTypeGrid);
            this.uiPanel1Container.Controls.Add(this.companyGrid);
            this.uiPanel1Container.Controls.Add(this.ShowButton);
            this.uiPanel1Container.Controls.Add(this.label2);
            this.uiPanel1Container.Controls.Add(this.label1);
            this.uiPanel1Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel1Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel1Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 1);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(154, 498);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // LastDateLabel
            // 
            this.LastDateLabel.AutoSize = true;
            this.LastDateLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastDateLabel.Location = new System.Drawing.Point(4, 473);
            this.LastDateLabel.Name = "LastDateLabel";
            this.LastDateLabel.Size = new System.Drawing.Size(0, 17);
            this.LastDateLabel.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(-2, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 14);
            this.label5.TabIndex = 74;
            this.label5.Text = "آخرین تاریخ به روز رسانی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(52, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 73;
            this.label4.Text = "گروه شرکت ها :";
            // 
            // CompanyGroupComboBox
            // 
            this.CompanyGroupComboBox.FormattingEnabled = true;
            this.CompanyGroupComboBox.Location = new System.Drawing.Point(10, 111);
            this.CompanyGroupComboBox.Name = "CompanyGroupComboBox";
            this.CompanyGroupComboBox.Size = new System.Drawing.Size(135, 22);
            this.CompanyGroupComboBox.TabIndex = 72;
            this.CompanyGroupComboBox.SelectionChangeCommitted += new System.EventHandler(this.CompanyGroupComboBox_SelectionChangeCommitted);
            // 
            // laderTypeGrid
            // 
            this.laderTypeGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.laderTypeGrid.AlternatingColors = true;
            this.laderTypeGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            laderTypeGrid_DesignTimeLayout.LayoutString = resources.GetString("laderTypeGrid_DesignTimeLayout.LayoutString");
            this.laderTypeGrid.DesignTimeLayout = laderTypeGrid_DesignTimeLayout;
            this.laderTypeGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.laderTypeGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.laderTypeGrid.GroupByBoxVisible = false;
            this.laderTypeGrid.Location = new System.Drawing.Point(4, 277);
            this.laderTypeGrid.Margin = new System.Windows.Forms.Padding(4);
            this.laderTypeGrid.Name = "laderTypeGrid";
            this.laderTypeGrid.Size = new System.Drawing.Size(147, 135);
            this.laderTypeGrid.TabIndex = 71;
            // 
            // companyGrid
            // 
            this.companyGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.companyGrid.AlternatingColors = true;
            this.companyGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            companyGrid_DesignTimeLayout.LayoutString = resources.GetString("companyGrid_DesignTimeLayout.LayoutString");
            this.companyGrid.DesignTimeLayout = companyGrid_DesignTimeLayout;
            this.companyGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.companyGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.companyGrid.GroupByBoxVisible = false;
            this.companyGrid.Location = new System.Drawing.Point(4, 139);
            this.companyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.companyGrid.Name = "companyGrid";
            this.companyGrid.Size = new System.Drawing.Size(147, 135);
            this.companyGrid.TabIndex = 70;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(29, 417);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(94, 32);
            this.ShowButton.TabIndex = 8;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(94, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(94, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(10, 21);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(135, 21);
            this.FromDatefaDatePicker.TabIndex = 0;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(10, 67);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(135, 21);
            this.ToDatefaDatePicker.TabIndex = 1;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // SumPanel
            // 
            this.SumPanel.Controls.Add(this.AllLadBillCountPercent_decLabel);
            this.SumPanel.Controls.Add(this.AllCarCountPercent_decLabel);
            this.SumPanel.Controls.Add(this.AllUsedLadBillCount_fltLabel);
            this.SumPanel.Controls.Add(this.AllLadBillCount_fltLabel);
            this.SumPanel.Controls.Add(this.AllCarCount_fltlabel);
            this.SumPanel.Controls.Add(this.label3);
            this.SumPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SumPanel.Location = new System.Drawing.Point(0, 559);
            this.SumPanel.Name = "SumPanel";
            this.SumPanel.Size = new System.Drawing.Size(1010, 41);
            this.SumPanel.TabIndex = 42;
            // 
            // AllLadBillCountPercent_decLabel
            // 
            this.AllLadBillCountPercent_decLabel.AutoSize = true;
            this.AllLadBillCountPercent_decLabel.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllLadBillCountPercent_decLabel.Location = new System.Drawing.Point(45, 6);
            this.AllLadBillCountPercent_decLabel.Name = "AllLadBillCountPercent_decLabel";
            this.AllLadBillCountPercent_decLabel.Size = new System.Drawing.Size(0, 29);
            this.AllLadBillCountPercent_decLabel.TabIndex = 48;
            // 
            // AllCarCountPercent_decLabel
            // 
            this.AllCarCountPercent_decLabel.AutoSize = true;
            this.AllCarCountPercent_decLabel.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllCarCountPercent_decLabel.Location = new System.Drawing.Point(255, 6);
            this.AllCarCountPercent_decLabel.Name = "AllCarCountPercent_decLabel";
            this.AllCarCountPercent_decLabel.Size = new System.Drawing.Size(0, 29);
            this.AllCarCountPercent_decLabel.TabIndex = 47;
            // 
            // AllUsedLadBillCount_fltLabel
            // 
            this.AllUsedLadBillCount_fltLabel.AutoSize = true;
            this.AllUsedLadBillCount_fltLabel.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllUsedLadBillCount_fltLabel.Location = new System.Drawing.Point(454, 6);
            this.AllUsedLadBillCount_fltLabel.Name = "AllUsedLadBillCount_fltLabel";
            this.AllUsedLadBillCount_fltLabel.Size = new System.Drawing.Size(0, 29);
            this.AllUsedLadBillCount_fltLabel.TabIndex = 46;
            // 
            // AllLadBillCount_fltLabel
            // 
            this.AllLadBillCount_fltLabel.AutoSize = true;
            this.AllLadBillCount_fltLabel.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllLadBillCount_fltLabel.Location = new System.Drawing.Point(634, 6);
            this.AllLadBillCount_fltLabel.Name = "AllLadBillCount_fltLabel";
            this.AllLadBillCount_fltLabel.Size = new System.Drawing.Size(0, 29);
            this.AllLadBillCount_fltLabel.TabIndex = 45;
            // 
            // AllCarCount_fltlabel
            // 
            this.AllCarCount_fltlabel.AutoSize = true;
            this.AllCarCount_fltlabel.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllCarCount_fltlabel.Location = new System.Drawing.Point(780, 6);
            this.AllCarCount_fltlabel.Name = "AllCarCount_fltlabel";
            this.AllCarCount_fltlabel.Size = new System.Drawing.Size(0, 29);
            this.AllCarCount_fltlabel.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Lotus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(958, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "جمع";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrintstripButton
            // 
            this.PrintstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintstripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintstripButton.Image")));
            this.PrintstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintstripButton.Name = "PrintstripButton";
            this.PrintstripButton.Size = new System.Drawing.Size(28, 28);
            this.PrintstripButton.Text = "چاپ";
            this.PrintstripButton.Click += new System.EventHandler(this.PrintstripButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(28, 28);
            this.ExportButton.Text = "خروجی اکسل";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintstripButton,
            this.ExportButton,
            this.CloseButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(1010, 31);
            this.AllTrafficToolStrip.TabIndex = 40;
            // 
            // UseLadBillVSLadeCountReportstiReport
            // 
            this.UseLadBillVSLadeCountReportstiReport.CookieContainer = null;
            this.UseLadBillVSLadeCountReportstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.UseLadBillVSLadeCountReportstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.UseLadBillVSLadeCountReportstiReport.ReportAlias = "Report";
            this.UseLadBillVSLadeCountReportstiReport.ReportGuid = "278c67a289a740e8ba47f8ab423f5aa1";
            this.UseLadBillVSLadeCountReportstiReport.ReportName = "Report";
            this.UseLadBillVSLadeCountReportstiReport.ReportSource = resources.GetString("UseLadBillVSLadeCountReportstiReport.ReportSource");
            this.UseLadBillVSLadeCountReportstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.UseLadBillVSLadeCountReportstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.UseLadBillVSLadeCountReportstiReport.UseProgressInThread = false;
            // 
            // LadeAssignmentInfoGridView
            // 
            this.LadeAssignmentInfoGridView.AllowUserToAddRows = false;
            this.LadeAssignmentInfoGridView.AllowUserToDeleteRows = false;
            this.LadeAssignmentInfoGridView.AllowUserToResizeRows = false;
            this.LadeAssignmentInfoGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LadeAssignmentInfoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LadeAssignmentInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadeAssignmentInfoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompany_nvc,
            this.colLaderType_nvc,
            this.colCarCount_int,
            this.colLadBillCount_int,
            this.colUsedLadBill_flt,
            this.colCarCountPercent_dec,
            this.colLadBillCountPercent_dec});
            this.LadeAssignmentInfoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadeAssignmentInfoGridView.Location = new System.Drawing.Point(163, 34);
            this.LadeAssignmentInfoGridView.MultiSelect = false;
            this.LadeAssignmentInfoGridView.Name = "LadeAssignmentInfoGridView";
            this.LadeAssignmentInfoGridView.ReadOnly = true;
            this.LadeAssignmentInfoGridView.RowHeadersVisible = false;
            this.LadeAssignmentInfoGridView.Size = new System.Drawing.Size(844, 522);
            this.LadeAssignmentInfoGridView.TabIndex = 43;
            // 
            // colCompany_nvc
            // 
            this.colCompany_nvc.DataPropertyName = "CompanyCodeAndName";
            this.colCompany_nvc.HeaderText = "نام و کد شرکت";
            this.colCompany_nvc.Name = "colCompany_nvc";
            this.colCompany_nvc.ReadOnly = true;
            this.colCompany_nvc.Width = 172;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع و کد بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 173;
            // 
            // colCarCount_int
            // 
            this.colCarCount_int.DataPropertyName = "CarCount_int";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCarCount_int.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCarCount_int.HeaderText = "تعداد درخواستی";
            this.colCarCount_int.Name = "colCarCount_int";
            this.colCarCount_int.ReadOnly = true;
            // 
            // colLadBillCount_int
            // 
            this.colLadBillCount_int.DataPropertyName = "LadBillCount_int";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLadBillCount_int.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLadBillCount_int.HeaderText = "تعداد مجوز(حواله) صادر شده";
            this.colLadBillCount_int.Name = "colLadBillCount_int";
            this.colLadBillCount_int.ReadOnly = true;
            // 
            // colUsedLadBill_flt
            // 
            this.colUsedLadBill_flt.DataPropertyName = "UsedLadBill_int";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUsedLadBill_flt.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUsedLadBill_flt.HeaderText = "تعداد بارنامه";
            this.colUsedLadBill_flt.Name = "colUsedLadBill_flt";
            this.colUsedLadBill_flt.ReadOnly = true;
            // 
            // colCarCountPercent_dec
            // 
            this.colCarCountPercent_dec.DataPropertyName = "CarCountPercent_dec";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCarCountPercent_dec.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCarCountPercent_dec.HeaderText = "درصد درخواستی به بارنامه";
            this.colCarCountPercent_dec.Name = "colCarCountPercent_dec";
            this.colCarCountPercent_dec.ReadOnly = true;
            // 
            // colLadBillCountPercent_dec
            // 
            this.colLadBillCountPercent_dec.DataPropertyName = "LadBillCountPercent_dec";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLadBillCountPercent_dec.DefaultCellStyle = dataGridViewCellStyle6;
            this.colLadBillCountPercent_dec.HeaderText = "درصد مجوز (حواله)صادره به بارنامه";
            this.colLadBillCountPercent_dec.Name = "colLadBillCountPercent_dec";
            this.colLadBillCountPercent_dec.ReadOnly = true;
            // 
            // UseLadBillVSLadeCountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 600);
            this.Controls.Add(this.LadeAssignmentInfoGridView);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Controls.Add(this.SumPanel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "UseLadBillVSLadeCountReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش مغایرت کامیون های درخواستی شرکت ها از پایانه بار با بارنامه های صادره";
            this.Load += new System.EventHandler(this.AllInfoByDateReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1Container.ResumeLayout(false);
            this.uiPanel1Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laderTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGrid)).EndInit();
            this.SumPanel.ResumeLayout(false);
            this.SumPanel.PerformLayout();
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeAssignmentInfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.UI.Dock.UIPanelGroup uiPanel0;
        private Janus.Windows.UI.Dock.UIPanel uiPanel1;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel1Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private Janus.Windows.GridEX.GridEX companyGrid;
        private Janus.Windows.GridEX.GridEX laderTypeGrid;
        private System.Windows.Forms.Panel SumPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AllCarCount_fltlabel;
        private System.Windows.Forms.Label AllUsedLadBillCount_fltLabel;
        private System.Windows.Forms.Label AllLadBillCount_fltLabel;
        private System.Windows.Forms.Label AllCarCountPercent_decLabel;
        private System.Windows.Forms.Label AllLadBillCountPercent_decLabel;
        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrintstripButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CompanyGroupComboBox;
        private System.Windows.Forms.Label LastDateLabel;
        private System.Windows.Forms.Label label5;
        private Stimulsoft.Report.StiReport UseLadBillVSLadeCountReportstiReport;
        private System.Windows.Forms.DataGridView LadeAssignmentInfoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCount_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCount_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsedLadBill_flt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCountPercent_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCountPercent_dec;
    }
}