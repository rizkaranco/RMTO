namespace HPS.Reports.Forms
{
    partial class ActiveTurnsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveTurnsReportForm));
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.TurnPrintButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TrafficGridView = new System.Windows.Forms.DataGridView();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillMessageID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHourFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowableHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionYear_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnUser_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicesType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithLade_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.ExportButton,
            this.toolStripSeparator1,
            this.CloseButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(1018, 31);
            this.AllTrafficToolStrip.TabIndex = 0;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.ClosetoolStripButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = global::HPS.Properties.Resources.Print;
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(28, 28);
            this.PrintButton.Text = "چاپ ";
            // 
            // TurnPrintButton
            // 
            this.TurnPrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TurnPrintButton.Image = ((System.Drawing.Image)(resources.GetObject("TurnPrintButton.Image")));
            this.TurnPrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TurnPrintButton.Name = "TurnPrintButton";
            this.TurnPrintButton.Size = new System.Drawing.Size(28, 28);
            this.TurnPrintButton.Text = "چاپ مجدد قبض تأييد نوبت";
            // 
            // ClosetoolStripButton
            // 
            this.ClosetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClosetoolStripButton.Image = global::HPS.Properties.Resources.Close;
            this.ClosetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClosetoolStripButton.Name = "ClosetoolStripButton";
            this.ClosetoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ClosetoolStripButton.Text = "بستن";
            this.ClosetoolStripButton.Click += new System.EventHandler(this.ClosetoolStripButton_Click);
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
            this.TrafficGridView.Location = new System.Drawing.Point(138, 34);
            this.TrafficGridView.MultiSelect = false;
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.ReadOnly = true;
            this.TrafficGridView.RowHeadersVisible = false;
            this.TrafficGridView.Size = new System.Drawing.Size(877, 585);
            this.TrafficGridView.TabIndex = 15;
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // TurnDate_nvc
            // 
            this.TurnDate_nvc.DataPropertyName = "TurnDate_nvc";
            this.TurnDate_nvc.HeaderText = "تاریخ تأیید ";
            this.TurnDate_nvc.Name = "TurnDate_nvc";
            this.TurnDate_nvc.ReadOnly = true;
            // 
            // TurnTime_nvc
            // 
            this.TurnTime_nvc.DataPropertyName = "TurnTime_nvc";
            this.TurnTime_nvc.HeaderText = "ساعت تأیید ";
            this.TurnTime_nvc.Name = "TurnTime_nvc";
            this.TurnTime_nvc.ReadOnly = true;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه کامیون";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // colBillMessageID_int
            // 
            this.colBillMessageID_int.DataPropertyName = "BillMessageID_int";
            this.colBillMessageID_int.HeaderText = "پیام";
            this.colBillMessageID_int.Name = "colBillMessageID_int";
            this.colBillMessageID_int.ReadOnly = true;
            this.colBillMessageID_int.Visible = false;
            // 
            // colComment_nvc
            // 
            this.colComment_nvc.DataPropertyName = "Comment_nvc";
            this.colComment_nvc.HeaderText = "توضیحات";
            this.colComment_nvc.Name = "colComment_nvc";
            this.colComment_nvc.ReadOnly = true;
            this.colComment_nvc.Visible = false;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Visible = false;
            // 
            // colExtraHourFee_dec
            // 
            this.colExtraHourFee_dec.DataPropertyName = "ExtraHourFee_dec";
            this.colExtraHourFee_dec.HeaderText = "مبلغ اضافه ساعت";
            this.colExtraHourFee_dec.Name = "colExtraHourFee_dec";
            this.colExtraHourFee_dec.ReadOnly = true;
            this.colExtraHourFee_dec.Visible = false;
            // 
            // colExtraHour_int
            // 
            this.colExtraHour_int.DataPropertyName = "ExtraHour_int";
            this.colExtraHour_int.HeaderText = "مدت اضافه";
            this.colExtraHour_int.Name = "colExtraHour_int";
            this.colExtraHour_int.ReadOnly = true;
            this.colExtraHour_int.Visible = false;
            // 
            // colFee_dec
            // 
            this.colFee_dec.DataPropertyName = "Fee_dec";
            this.colFee_dec.HeaderText = "هزینه";
            this.colFee_dec.Name = "colFee_dec";
            this.colFee_dec.ReadOnly = true;
            this.colFee_dec.Visible = false;
            // 
            // colAllowableHour_int
            // 
            this.colAllowableHour_int.DataPropertyName = "AllowableHour_int";
            this.colAllowableHour_int.HeaderText = "ساعت مجاز";
            this.colAllowableHour_int.Name = "colAllowableHour_int";
            this.colAllowableHour_int.ReadOnly = true;
            this.colAllowableHour_int.Visible = false;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ ورود";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 90;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت ورود";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 90;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "ش.نوبت تأیید";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
            this.colTurnNumber_bint.Width = 115;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
            // 
            // colFirstName_nvc
            // 
            this.colFirstName_nvc.DataPropertyName = "FirstName_nvc";
            this.colFirstName_nvc.HeaderText = "نام";
            this.colFirstName_nvc.Name = "colFirstName_nvc";
            this.colFirstName_nvc.ReadOnly = true;
            // 
            // colLastName_nvc
            // 
            this.colLastName_nvc.DataPropertyName = "LastName_nvc";
            this.colLastName_nvc.HeaderText = "نام خانوادگی";
            this.colLastName_nvc.Name = "colLastName_nvc";
            this.colLastName_nvc.ReadOnly = true;
            // 
            // colDriverMobile_nvc
            // 
            this.colDriverMobile_nvc.DataPropertyName = "DriverMobileNumber_nvc";
            this.colDriverMobile_nvc.HeaderText = "شماره موبایل";
            this.colDriverMobile_nvc.Name = "colDriverMobile_nvc";
            this.colDriverMobile_nvc.ReadOnly = true;
            this.colDriverMobile_nvc.Width = 120;
            // 
            // colProductionYear_int
            // 
            this.colProductionYear_int.DataPropertyName = "ProductionYear_int";
            this.colProductionYear_int.HeaderText = "سال ساخت";
            this.colProductionYear_int.Name = "colProductionYear_int";
            this.colProductionYear_int.ReadOnly = true;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 150;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // TurnUser_nvc
            // 
            this.TurnUser_nvc.DataPropertyName = "TurnUser_nvc";
            this.TurnUser_nvc.HeaderText = "کاربر ثبت کننده نوبت";
            this.TurnUser_nvc.Name = "TurnUser_nvc";
            this.TurnUser_nvc.ReadOnly = true;
            this.TurnUser_nvc.Width = 150;
            // 
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            // 
            // colServiceID_int
            // 
            this.colServiceID_int.DataPropertyName = "ServiceID_int";
            this.colServiceID_int.HeaderText = "خدمات";
            this.colServiceID_int.Name = "colServiceID_int";
            this.colServiceID_int.ReadOnly = true;
            this.colServiceID_int.Visible = false;
            // 
            // colServicesType_nvc
            // 
            this.colServicesType_nvc.DataPropertyName = "ServiceID_intServiceType_nvc";
            this.colServicesType_nvc.HeaderText = "مراجعه به";
            this.colServicesType_nvc.Name = "colServicesType_nvc";
            this.colServicesType_nvc.ReadOnly = true;
            // 
            // colIn_bit
            // 
            this.colIn_bit.DataPropertyName = "In_bit";
            this.colIn_bit.HeaderText = "ورود";
            this.colIn_bit.Name = "colIn_bit";
            this.colIn_bit.ReadOnly = true;
            // 
            // colWithLade_bit
            // 
            this.colWithLade_bit.DataPropertyName = "WithLade_bit";
            this.colWithLade_bit.HeaderText = "با بار";
            this.colWithLade_bit.Name = "colWithLade_bit";
            this.colWithLade_bit.ReadOnly = true;
            this.colWithLade_bit.Visible = false;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نوع وسیله";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colPrice_dec
            // 
            this.colPrice_dec.DataPropertyName = "Price_dec";
            this.colPrice_dec.HeaderText = "مبلغ";
            this.colPrice_dec.Name = "colPrice_dec";
            this.colPrice_dec.ReadOnly = true;
            this.colPrice_dec.Visible = false;
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("9e453710-0908-4b61-b84a-050f2db9a42f");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("9e453710-0908-4b61-b84a-050f2db9a42f"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 585), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("9e453710-0908-4b61-b84a-050f2db9a42f"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.AllowPanelDrag = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.AllowPanelDrop = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.AllowResize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.CaptionDisplayMode = Janus.Windows.UI.Dock.PanelCaptionDisplayMode.Text;
            this.uiPanel0.CaptionDoubleClickAction = Janus.Windows.UI.Dock.CaptionDoubleClickAction.None;
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(135, 585);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 561);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(100, 118);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 62;
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
            this.TimeGroupBox.Location = new System.Drawing.Point(2, 118);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(124, 110);
            this.TimeGroupBox.TabIndex = 67;
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
            this.FromTimeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.FromTimeTextBox_MaskInputRejected);
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
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(7, 244);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 56;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(5, 31);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(118, 20);
            this.FromDatefaDatePicker.TabIndex = 57;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 64;
            this.label2.Text = "تا تاریخ :";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(5, 87);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(118, 20);
            this.ToDatefaDatePicker.TabIndex = 58;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 63;
            this.label1.Text = "از تاریخ :";
            // 
            // ActiveTurnsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 622);
            this.Controls.Add(this.TrafficGridView);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.Name = "ActiveTurnsReportForm";
            this.Text = "لیست نوبت های فعال";
            this.Load += new System.EventHandler(this.ActiveTurnsReportForm_Load);
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView TrafficGridView;
        private System.Windows.Forms.ToolStripButton TurnPrintButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.Button RefreshHourbutton;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Label label2;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficID_bint;
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