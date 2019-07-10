using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.TurnManagement
{
    partial class TrafficWithoutTurnAllowadedForm
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
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.TurnallowdedButton = new System.Windows.Forms.ToolStripButton();
            this.CurrentTurnNotAcceptedStripButton = new System.Windows.Forms.ToolStripButton();
            this.AllTurntoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TrafficGridView = new System.Windows.Forms.DataGridView();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalCode_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicesType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithLade_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trafficnumberlabel = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ToDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FromDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrafficNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.TurnNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.SerialPlate_nvcTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TurnallowdedButton,
            this.CurrentTurnNotAcceptedStripButton,
            this.AllTurntoolStripButton,
            this.RefreshButton,
            this.ClosetoolStripButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(918, 31);
            this.AllTrafficToolStrip.TabIndex = 9;
            // 
            // TurnallowdedButton
            // 
            this.TurnallowdedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TurnallowdedButton.Image = global::HPS.Properties.Resources.LadBill;
            this.TurnallowdedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TurnallowdedButton.Name = "TurnallowdedButton";
            this.TurnallowdedButton.Size = new System.Drawing.Size(28, 28);
            this.TurnallowdedButton.Text = "تأیید نوبت";
            this.TurnallowdedButton.ToolTipText = "تأیید نوبتIns";
            this.TurnallowdedButton.Click += new System.EventHandler(this.TurnallowdedButton_Click);
            // 
            // CurrentTurnNotAcceptedStripButton
            // 
            this.CurrentTurnNotAcceptedStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrentTurnNotAcceptedStripButton.Image = global::HPS.Properties.Resources._in;
            this.CurrentTurnNotAcceptedStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrentTurnNotAcceptedStripButton.Name = "CurrentTurnNotAcceptedStripButton";
            this.CurrentTurnNotAcceptedStripButton.Size = new System.Drawing.Size(28, 28);
            this.CurrentTurnNotAcceptedStripButton.Text = "نوبت های تأیید نشده امروز";
            this.CurrentTurnNotAcceptedStripButton.Click += new System.EventHandler(this.CurrentTurnNotAcceptedStripButton_Click);
            // 
            // AllTurntoolStripButton
            // 
            this.AllTurntoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllTurntoolStripButton.Image = global::HPS.Properties.Resources.papelero;
            this.AllTurntoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllTurntoolStripButton.Name = "AllTurntoolStripButton";
            this.AllTurntoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.AllTurntoolStripButton.Text = "نمایش کل نوبت ها";
            this.AllTurntoolStripButton.ToolTipText = "نمایش کل نوبت ها Shift+A";
            this.AllTurntoolStripButton.Click += new System.EventHandler(this.AllTurntoolStripButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::HPS.Properties.Resources.Refresh;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.colCarID_int,
            this.colDriverID_bint,
            this.colNationalCode_int,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colTurnNumber_bint,
            this.colTrafficNumber_bint,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colLaderType_nvc,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colPlateCity_nvc,
            this.colServiceID_int,
            this.colServicesType_nvc,
            this.colIn_bit,
            this.colWithLade_bit,
            this.colSystem_nvc,
            this.colLaderTypeID_int,
            this.colCarCardNumber_nvc});
            this.TrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficGridView.Location = new System.Drawing.Point(0, 98);
            this.TrafficGridView.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficGridView.MultiSelect = false;
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.ReadOnly = true;
            this.TrafficGridView.RowHeadersVisible = false;
            this.TrafficGridView.Size = new System.Drawing.Size(918, 365);
            this.TrafficGridView.TabIndex = 13;
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه ناوگان";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.DataPropertyName = "DriverID_bint";
            this.colDriverID_bint.HeaderText = "شناسه راننده";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.ReadOnly = true;
            this.colDriverID_bint.Visible = false;
            // 
            // colNationalCode_int
            // 
            this.colNationalCode_int.DataPropertyName = "NationalCode_int";
            this.colNationalCode_int.HeaderText = "کد ملی";
            this.colNationalCode_int.Name = "colNationalCode_int";
            this.colNationalCode_int.ReadOnly = true;
            this.colNationalCode_int.Visible = false;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ ورود";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 120;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت ورود";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "TurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "شماره نوبت";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
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
            this.colLastName_nvc.Width = 120;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 130;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 110;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // colPlateCity_nvc
            // 
            this.colPlateCity_nvc.DataPropertyName = "PlateCityID_intPlateCity_nvc";
            this.colPlateCity_nvc.HeaderText = "شهر شماره گذاری";
            this.colPlateCity_nvc.Name = "colPlateCity_nvc";
            this.colPlateCity_nvc.ReadOnly = true;
            this.colPlateCity_nvc.Width = 135;
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
            this.colServicesType_nvc.HeaderText = "خدمات";
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
            // colCarCardNumber_nvc
            // 
            this.colCarCardNumber_nvc.DataPropertyName = "CarCardNumber_nvc";
            this.colCarCardNumber_nvc.HeaderText = "شماره کارت ماشین";
            this.colCarCardNumber_nvc.Name = "colCarCardNumber_nvc";
            this.colCarCardNumber_nvc.ReadOnly = true;
            this.colCarCardNumber_nvc.Visible = false;
            // 
            // Trafficnumberlabel
            // 
            this.Trafficnumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trafficnumberlabel.AutoSize = true;
            this.Trafficnumberlabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Trafficnumberlabel.Location = new System.Drawing.Point(832, 26);
            this.Trafficnumberlabel.Name = "Trafficnumberlabel";
            this.Trafficnumberlabel.Size = new System.Drawing.Size(71, 23);
            this.Trafficnumberlabel.TabIndex = 33;
            this.Trafficnumberlabel.Text = "شماره قبض";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(345, 22);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(131, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 2;
            this.NumberPlate_nvcTextBox.Tag = "شماره پلاك";
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(474, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "شماره پلاك";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(663, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "شماره نوبت";
            // 
            // ToDate_nvcTextBox
            // 
            this.ToDate_nvcTextBox.Location = new System.Drawing.Point(12, 22);
            this.ToDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ToDate_nvcTextBox.Mask = "0000/00/00";
            this.ToDate_nvcTextBox.Name = "ToDate_nvcTextBox";
            this.ToDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToDate_nvcTextBox.Size = new System.Drawing.Size(91, 30);
            this.ToDate_nvcTextBox.TabIndex = 5;
            this.ToDate_nvcTextBox.Click += new System.EventHandler(this.ToDate_nvcTextBox_Click);
            this.ToDate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToDate_nvcTextBox_KeyDown);
            // 
            // FromDate_nvcTextBox
            // 
            this.FromDate_nvcTextBox.Location = new System.Drawing.Point(160, 22);
            this.FromDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FromDate_nvcTextBox.Mask = "0000/00/00";
            this.FromDate_nvcTextBox.Name = "FromDate_nvcTextBox";
            this.FromDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDate_nvcTextBox.Size = new System.Drawing.Size(91, 30);
            this.FromDate_nvcTextBox.TabIndex = 4;
            this.FromDate_nvcTextBox.Click += new System.EventHandler(this.ToDate_nvcTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 62;
            this.label1.Text = "از تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "تا تاریخ";
            // 
            // TrafficNumberTextBox
            // 
            this.TrafficNumberTextBox.AllowNegative = true;
            this.TrafficNumberTextBox.DigitsInGroup = 0;
            this.TrafficNumberTextBox.Flags = 0;
            this.TrafficNumberTextBox.Location = new System.Drawing.Point(735, 22);
            this.TrafficNumberTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumberTextBox.MaxWholeDigits = 9;
            this.TrafficNumberTextBox.Name = "TrafficNumberTextBox";
            this.TrafficNumberTextBox.Prefix = "";
            this.TrafficNumberTextBox.RangeMax = 0;
            this.TrafficNumberTextBox.RangeMin = 0;
            this.TrafficNumberTextBox.Size = new System.Drawing.Size(95, 30);
            this.TrafficNumberTextBox.TabIndex = 0;
            this.TrafficNumberTextBox.Tag = "شماره قبض";
            this.TrafficNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficNumberTextBox_KeyDown);
            // 
            // TurnNumberTextBox
            // 
            this.TurnNumberTextBox.AllowNegative = true;
            this.TurnNumberTextBox.DigitsInGroup = 0;
            this.TurnNumberTextBox.Flags = 0;
            this.TurnNumberTextBox.Location = new System.Drawing.Point(549, 22);
            this.TurnNumberTextBox.MaxDecimalPlaces = 4;
            this.TurnNumberTextBox.MaxWholeDigits = 9;
            this.TurnNumberTextBox.Name = "TurnNumberTextBox";
            this.TurnNumberTextBox.Prefix = "";
            this.TurnNumberTextBox.RangeMax = 0;
            this.TurnNumberTextBox.RangeMin = 0;
            this.TurnNumberTextBox.Size = new System.Drawing.Size(111, 30);
            this.TurnNumberTextBox.TabIndex = 1;
            this.TurnNumberTextBox.Tag = "شماره نوبت";
            this.TurnNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurnNumberTextBox_KeyDown);
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.AllowNegative = true;
            this.SerialPlate_nvcTextBox.DigitsInGroup = 0;
            this.SerialPlate_nvcTextBox.Flags = 0;
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(305, 22);
            this.SerialPlate_nvcTextBox.MaxDecimalPlaces = 0;
            this.SerialPlate_nvcTextBox.MaxWholeDigits = 2;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.Prefix = "";
            this.SerialPlate_nvcTextBox.RangeMax = 0;
            this.SerialPlate_nvcTextBox.RangeMin = 0;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(36, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 3;
            this.SerialPlate_nvcTextBox.Tag = "سری پلاک";
            this.SerialPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlate_nvcTextBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumberPlate_nvcTextBox);
            this.groupBox1.Controls.Add(this.TrafficNumberTextBox);
            this.groupBox1.Controls.Add(this.Trafficnumberlabel);
            this.groupBox1.Controls.Add(this.ToDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.SerialPlate_nvcTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TurnNumberTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(918, 67);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // TrafficWithoutTurnAllowadedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 463);
            this.Controls.Add(this.TrafficGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "TrafficWithoutTurnAllowadedForm";
            this.Text = "لیست نوبت های تأیید نشده";
            this.Load += new System.EventHandler(this.AllTrafficForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficWithoutTurnAllowadedForm_KeyDown);
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton TurnallowdedButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView TrafficGridView;
        private System.Windows.Forms.ToolStripButton AllTurntoolStripButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.Label Trafficnumberlabel;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton CurrentTurnNotAcceptedStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalCode_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicesType_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIn_bit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithLade_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private System.Windows.Forms.MaskedTextBox ToDate_nvcTextBox;
        private System.Windows.Forms.MaskedTextBox FromDate_nvcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NumericTextBox TrafficNumberTextBox;
        private NumericTextBox TurnNumberTextBox;
        private NumericTextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}