namespace HPS.Reports.Forms
{
    partial class TurnAcceptedAreaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnAcceptedAreaForm));
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.PrinterSelectionButton = new System.Windows.Forms.ToolStripButton();
            this.PrintStripButton = new System.Windows.Forms.ToolStripButton();
            this.TurnPrintstripButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.WithProductionYearStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.LastName_nvctextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TrafficNumber_binttextBox = new System.Windows.Forms.TextBox();
            this.ShowwithConditionbutton = new Janus.Windows.EditControls.UIButton();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.AcceptedTurnNumber_binttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AllAcceptedTurnstiReport = new Stimulsoft.Report.StiReport();
            this.colPrice_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWithLade_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colServicesType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnUser_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionYear_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowableHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHourFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillMessageID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrafficGridView = new System.Windows.Forms.DataGridView();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrinterSelectionButton,
            this.PrintStripButton,
            this.TurnPrintstripButton,
            this.RefreshButton,
            this.ExportButton,
            this.WithProductionYearStripButton,
            this.toolStripSeparator1,
            this.ShowButton,
            this.CloseButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(984, 31);
            this.AllTrafficToolStrip.TabIndex = 4;
            // 
            // PrinterSelectionButton
            // 
            this.PrinterSelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrinterSelectionButton.Image = ((System.Drawing.Image)(resources.GetObject("PrinterSelectionButton.Image")));
            this.PrinterSelectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrinterSelectionButton.Name = "PrinterSelectionButton";
            this.PrinterSelectionButton.Size = new System.Drawing.Size(28, 28);
            this.PrinterSelectionButton.Text = "انتخاب چاپگر";
            this.PrinterSelectionButton.Click += new System.EventHandler(this.PrinterSelectionButton_Click);
            // 
            // PrintStripButton
            // 
            this.PrintStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintStripButton.Image = global::HPS.Properties.Resources.Print;
            this.PrintStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintStripButton.Name = "PrintStripButton";
            this.PrintStripButton.Size = new System.Drawing.Size(28, 28);
            this.PrintStripButton.Text = "چاپ ";
            this.PrintStripButton.Click += new System.EventHandler(this.PrintStripButton_Click);
            // 
            // TurnPrintstripButton
            // 
            this.TurnPrintstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TurnPrintstripButton.Image = ((System.Drawing.Image)(resources.GetObject("TurnPrintstripButton.Image")));
            this.TurnPrintstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TurnPrintstripButton.Name = "TurnPrintstripButton";
            this.TurnPrintstripButton.Size = new System.Drawing.Size(28, 28);
            this.TurnPrintstripButton.Text = "چاپ مجدد قبض تأييد نوبت";
            this.TurnPrintstripButton.Click += new System.EventHandler(this.TurnPrintstripButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(28, 28);
            this.ExportButton.Text = "خروجی به Excel";
            // 
            // WithProductionYearStripButton
            // 
            this.WithProductionYearStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WithProductionYearStripButton.Image = global::HPS.Properties.Resources.ProductionYear;
            this.WithProductionYearStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WithProductionYearStripButton.Name = "WithProductionYearStripButton";
            this.WithProductionYearStripButton.Size = new System.Drawing.Size(28, 28);
            this.WithProductionYearStripButton.Text = "با سال ساخت و باطل نشده ها";
            this.WithProductionYearStripButton.Click += new System.EventHandler(this.WithProductionYearStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // ShowButton
            // 
            this.ShowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowButton.Image = global::HPS.Properties.Resources.showWithDate;
            this.ShowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(28, 28);
            this.ShowButton.Text = "نمایش با تاریخ ها";
            this.ShowButton.Visible = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
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
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("d1572150-02e7-4a57-a7e2-2e888dbc0988");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("d1572150-02e7-4a57-a7e2-2e888dbc0988"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(185, 457), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("d1572150-02e7-4a57-a7e2-2e888dbc0988"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Margin = new System.Windows.Forms.Padding(5);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(185, 457);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.LastName_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.SerialPlate_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.NumberPlate_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.label4);
            this.uiPanel0Container.Controls.Add(this.TrafficNumber_binttextBox);
            this.uiPanel0Container.Controls.Add(this.ShowwithConditionbutton);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.AcceptedTurnNumber_binttextBox);
            this.uiPanel0Container.Controls.Add(this.label3);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Margin = new System.Windows.Forms.Padding(5);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(179, 427);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // LastName_nvctextBox
            // 
            this.LastName_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastName_nvctextBox.Location = new System.Drawing.Point(17, 293);
            this.LastName_nvctextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastName_nvctextBox.Name = "LastName_nvctextBox";
            this.LastName_nvctextBox.Size = new System.Drawing.Size(134, 22);
            this.LastName_nvctextBox.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(104, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 101;
            this.label5.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(128, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 105;
            this.label1.Text = "از تاریخ :";
            // 
            // SerialPlate_nvctextBox
            // 
            this.SerialPlate_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvctextBox.Location = new System.Drawing.Point(17, 236);
            this.SerialPlate_nvctextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialPlate_nvctextBox.Name = "SerialPlate_nvctextBox";
            this.SerialPlate_nvctextBox.Size = new System.Drawing.Size(41, 22);
            this.SerialPlate_nvctextBox.TabIndex = 100;
            // 
            // NumberPlate_nvctextBox
            // 
            this.NumberPlate_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvctextBox.Location = new System.Drawing.Point(61, 236);
            this.NumberPlate_nvctextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvctextBox.Name = "NumberPlate_nvctextBox";
            this.NumberPlate_nvctextBox.Size = new System.Drawing.Size(90, 22);
            this.NumberPlate_nvctextBox.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(109, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 98;
            this.label4.Text = "شماره پلاک";
            // 
            // TrafficNumber_binttextBox
            // 
            this.TrafficNumber_binttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficNumber_binttextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficNumber_binttextBox.Location = new System.Drawing.Point(17, 179);
            this.TrafficNumber_binttextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficNumber_binttextBox.Name = "TrafficNumber_binttextBox";
            this.TrafficNumber_binttextBox.Size = new System.Drawing.Size(134, 22);
            this.TrafficNumber_binttextBox.TabIndex = 97;
            // 
            // ShowwithConditionbutton
            // 
            this.ShowwithConditionbutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowwithConditionbutton.Location = new System.Drawing.Point(40, 337);
            this.ShowwithConditionbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowwithConditionbutton.Name = "ShowwithConditionbutton";
            this.ShowwithConditionbutton.Size = new System.Drawing.Size(111, 34);
            this.ShowwithConditionbutton.TabIndex = 107;
            this.ShowwithConditionbutton.Text = "نمایش";
            this.ShowwithConditionbutton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowwithConditionbutton.Click += new System.EventHandler(this.ShowwithConditionbutton_Click);
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(17, 23);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(134, 20);
            this.FromDatefaDatePicker.TabIndex = 103;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(128, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 106;
            this.label2.Text = "تا تاریخ :";
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label.Location = new System.Drawing.Point(109, 160);
            this.label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 14);
            this.label.TabIndex = 96;
            this.label.Text = "شماره قبض";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(17, 67);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(134, 20);
            this.ToDatefaDatePicker.TabIndex = 104;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // AcceptedTurnNumber_binttextBox
            // 
            this.AcceptedTurnNumber_binttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptedTurnNumber_binttextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AcceptedTurnNumber_binttextBox.Location = new System.Drawing.Point(17, 122);
            this.AcceptedTurnNumber_binttextBox.Margin = new System.Windows.Forms.Padding(5);
            this.AcceptedTurnNumber_binttextBox.Name = "AcceptedTurnNumber_binttextBox";
            this.AcceptedTurnNumber_binttextBox.Size = new System.Drawing.Size(134, 22);
            this.AcceptedTurnNumber_binttextBox.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(110, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 94;
            this.label3.Text = "شماره نوبت";
            // 
            // AllAcceptedTurnstiReport
            // 
            this.AllAcceptedTurnstiReport.CookieContainer = null;
            this.AllAcceptedTurnstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.AllAcceptedTurnstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.AllAcceptedTurnstiReport.ReportAlias = "Report";
            this.AllAcceptedTurnstiReport.ReportGuid = "861ffa8773044fe0810610cc12e84af9";
            this.AllAcceptedTurnstiReport.ReportName = "Report";
            this.AllAcceptedTurnstiReport.ReportSource = resources.GetString("AllAcceptedTurnstiReport.ReportSource");
            this.AllAcceptedTurnstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.AllAcceptedTurnstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.AllAcceptedTurnstiReport.UseProgressInThread = false;
            // 
            // colPrice_dec
            // 
            this.colPrice_dec.DataPropertyName = "Price_dec";
            this.colPrice_dec.HeaderText = "مبلغ";
            this.colPrice_dec.Name = "colPrice_dec";
            this.colPrice_dec.ReadOnly = true;
            this.colPrice_dec.Visible = false;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نوع وسیله";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            // 
            // colWithLade_bit
            // 
            this.colWithLade_bit.DataPropertyName = "WithLade_bit";
            this.colWithLade_bit.HeaderText = "با بار";
            this.colWithLade_bit.Name = "colWithLade_bit";
            this.colWithLade_bit.ReadOnly = true;
            this.colWithLade_bit.Visible = false;
            // 
            // colIn_bit
            // 
            this.colIn_bit.DataPropertyName = "In_bit";
            this.colIn_bit.HeaderText = "ورود";
            this.colIn_bit.Name = "colIn_bit";
            this.colIn_bit.ReadOnly = true;
            // 
            // colServicesType_nvc
            // 
            this.colServicesType_nvc.DataPropertyName = "ServiceID_intServiceType_nvc";
            this.colServicesType_nvc.HeaderText = "مراجعه به";
            this.colServicesType_nvc.Name = "colServicesType_nvc";
            this.colServicesType_nvc.ReadOnly = true;
            // 
            // colServiceID_int
            // 
            this.colServiceID_int.DataPropertyName = "ServiceID_int";
            this.colServiceID_int.HeaderText = "خدمات";
            this.colServiceID_int.Name = "colServiceID_int";
            this.colServiceID_int.ReadOnly = true;
            this.colServiceID_int.Visible = false;
            // 
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            // 
            // TurnUser_nvc
            // 
            this.TurnUser_nvc.DataPropertyName = "TurnUser_nvc";
            this.TurnUser_nvc.HeaderText = "کاربر ثبت کننده نوبت";
            this.TurnUser_nvc.Name = "TurnUser_nvc";
            this.TurnUser_nvc.ReadOnly = true;
            this.TurnUser_nvc.Width = 150;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 150;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
            // 
            // colProductionYear_int
            // 
            this.colProductionYear_int.DataPropertyName = "ProductionYear_int";
            this.colProductionYear_int.HeaderText = "سال ساخت";
            this.colProductionYear_int.Name = "colProductionYear_int";
            this.colProductionYear_int.ReadOnly = true;
            // 
            // colDriverMobile_nvc
            // 
            this.colDriverMobile_nvc.DataPropertyName = "DriverMobileNumber_nvc";
            this.colDriverMobile_nvc.HeaderText = "شماره موبایل";
            this.colDriverMobile_nvc.Name = "colDriverMobile_nvc";
            this.colDriverMobile_nvc.ReadOnly = true;
            this.colDriverMobile_nvc.Width = 120;
            // 
            // colLastName_nvc
            // 
            this.colLastName_nvc.DataPropertyName = "LastName_nvc";
            this.colLastName_nvc.HeaderText = "نام خانوادگی";
            this.colLastName_nvc.Name = "colLastName_nvc";
            this.colLastName_nvc.ReadOnly = true;
            // 
            // colFirstName_nvc
            // 
            this.colFirstName_nvc.DataPropertyName = "FirstName_nvc";
            this.colFirstName_nvc.HeaderText = "نام";
            this.colFirstName_nvc.Name = "colFirstName_nvc";
            this.colFirstName_nvc.ReadOnly = true;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "ش.نوبت تأیید";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
            this.colTurnNumber_bint.Width = 115;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت ورود";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ ورود";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 120;
            // 
            // colAllowableHour_int
            // 
            this.colAllowableHour_int.DataPropertyName = "AllowableHour_int";
            this.colAllowableHour_int.HeaderText = "ساعت مجاز";
            this.colAllowableHour_int.Name = "colAllowableHour_int";
            this.colAllowableHour_int.ReadOnly = true;
            this.colAllowableHour_int.Visible = false;
            // 
            // colFee_dec
            // 
            this.colFee_dec.DataPropertyName = "Fee_dec";
            this.colFee_dec.HeaderText = "هزینه";
            this.colFee_dec.Name = "colFee_dec";
            this.colFee_dec.ReadOnly = true;
            this.colFee_dec.Visible = false;
            // 
            // colExtraHour_int
            // 
            this.colExtraHour_int.DataPropertyName = "ExtraHour_int";
            this.colExtraHour_int.HeaderText = "مدت اضافه";
            this.colExtraHour_int.Name = "colExtraHour_int";
            this.colExtraHour_int.ReadOnly = true;
            this.colExtraHour_int.Visible = false;
            // 
            // colExtraHourFee_dec
            // 
            this.colExtraHourFee_dec.DataPropertyName = "ExtraHourFee_dec";
            this.colExtraHourFee_dec.HeaderText = "مبلغ اضافه ساعت";
            this.colExtraHourFee_dec.Name = "colExtraHourFee_dec";
            this.colExtraHourFee_dec.ReadOnly = true;
            this.colExtraHourFee_dec.Visible = false;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Visible = false;
            // 
            // colComment_nvc
            // 
            this.colComment_nvc.DataPropertyName = "Comment_nvc";
            this.colComment_nvc.HeaderText = "توضیحات";
            this.colComment_nvc.Name = "colComment_nvc";
            this.colComment_nvc.ReadOnly = true;
            this.colComment_nvc.Visible = false;
            // 
            // colBillMessageID_int
            // 
            this.colBillMessageID_int.DataPropertyName = "BillMessageID_int";
            this.colBillMessageID_int.HeaderText = "پیام";
            this.colBillMessageID_int.Name = "colBillMessageID_int";
            this.colBillMessageID_int.ReadOnly = true;
            this.colBillMessageID_int.Visible = false;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه کامیون";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // TurnTime_nvc
            // 
            this.TurnTime_nvc.DataPropertyName = "TurnTime_nvc";
            this.TurnTime_nvc.HeaderText = "ساعت تأیید ";
            this.TurnTime_nvc.Name = "TurnTime_nvc";
            this.TurnTime_nvc.ReadOnly = true;
            // 
            // TurnDate_nvc
            // 
            this.TurnDate_nvc.DataPropertyName = "TurnDate_nvc";
            this.TurnDate_nvc.HeaderText = "تاریخ تأیید ";
            this.TurnDate_nvc.Name = "TurnDate_nvc";
            this.TurnDate_nvc.ReadOnly = true;
            // 
            // Area_bit
            // 
            this.Area_bit.DataPropertyName = "Area_bit";
            this.Area_bit.HeaderText = "شهری";
            this.Area_bit.Name = "Area_bit";
            this.Area_bit.ReadOnly = true;
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // TrafficGridView
            // 
            this.TrafficGridView.AllowUserToAddRows = false;
            this.TrafficGridView.AllowUserToDeleteRows = false;
            this.TrafficGridView.AllowUserToResizeRows = false;
            this.TrafficGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TrafficGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrafficGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrafficID_bint,
            this.Area_bit,
            this.TurnDate_nvc,
            this.TurnTime_nvc,
            this.colCarID_int,
            this.colBillMessageID_int,
            this.colComment_nvc,
            this.colUserName_nvc,
            this.colExtraHourFee_dec,
            this.colExtraHour_int,
            this.colFee_dec,
            this.colAllowableHour_int,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colTurnNumber_bint,
            this.colTrafficNumber_bint,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colDriverMobile_nvc,
            this.colProductionYear_int,
            this.colLaderType_nvc,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.TurnUser_nvc,
            this.colPlateType_nvc,
            this.colServiceID_int,
            this.colServicesType_nvc,
            this.colIn_bit,
            this.colWithLade_bit,
            this.colSystem_nvc,
            this.colLaderTypeID_int,
            this.colPrice_dec});
            this.TrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficGridView.Location = new System.Drawing.Point(188, 34);
            this.TrafficGridView.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.TrafficGridView.MultiSelect = false;
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.ReadOnly = true;
            this.TrafficGridView.RowHeadersVisible = false;
            this.TrafficGridView.Size = new System.Drawing.Size(793, 457);
            this.TrafficGridView.TabIndex = 17;
            // 
            // TurnAcceptedAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 494);
            this.Controls.Add(this.TrafficGridView);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "TurnAcceptedAreaForm";
            this.Text = "لیست نوبت های تایید شده شهری";
            this.Load += new System.EventHandler(this.TurnAcceptedAreaForm_Load);
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrinterSelectionButton;
        private System.Windows.Forms.ToolStripButton PrintStripButton;
        private System.Windows.Forms.ToolStripButton TurnPrintstripButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripButton WithProductionYearStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ShowButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.TextBox LastName_nvctextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SerialPlate_nvctextBox;
        private System.Windows.Forms.TextBox NumberPlate_nvctextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TrafficNumber_binttextBox;
        private Janus.Windows.EditControls.UIButton ShowwithConditionbutton;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private System.Windows.Forms.TextBox AcceptedTurnNumber_binttextBox;
        private System.Windows.Forms.Label label3;
        private Stimulsoft.Report.StiReport AllAcceptedTurnstiReport;
        private System.Windows.Forms.DataGridView TrafficGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficID_bint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Area_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillMessageID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraHourFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowableHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverMobile_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductionYear_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnUser_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicesType_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIn_bit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithLade_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice_dec;
    }
}