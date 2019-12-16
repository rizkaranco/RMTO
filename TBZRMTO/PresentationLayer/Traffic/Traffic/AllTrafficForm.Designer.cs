using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    partial class AllTrafficForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTrafficForm));
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.AllCurrentTrafficButton = new System.Windows.Forms.ToolStripButton();
            this.DriverSpecificationButton = new System.Windows.Forms.ToolStripButton();
            this.CarSpecificationButton = new System.Windows.Forms.ToolStripButton();
            this.InNotOutStripButton = new System.Windows.Forms.ToolStripButton();
            this.AllInStripButton = new System.Windows.Forms.ToolStripButton();
            this.AllTrafficStripButton = new System.Windows.Forms.ToolStripButton();
            this.InTrafficPictureShowButton = new System.Windows.Forms.ToolStripButton();
            this.EditStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportToExcelStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintTrafficButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TrafficGridView = new System.Windows.Forms.DataGridView();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnAccepted_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colArea_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLadeReturn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLadBillCredit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTurnCanceled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LadBillCanceled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTurnReturened = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colServicesType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCameraPlateNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCameraSerialPlate_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalCode_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnUser_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurncancelUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditDate_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditTime_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trafficnumberlabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BooleanComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FalseradioButton = new System.Windows.Forms.RadioButton();
            this.TrueradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.carCardNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.SerialPlate_nvcTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.driverCardNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.AcceptedTurnNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.TrafficNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.AllTrafficstiReport = new Stimulsoft.Report.StiReport();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintButton,
            this.RefreshButton,
            this.AllCurrentTrafficButton,
            this.DriverSpecificationButton,
            this.CarSpecificationButton,
            this.InNotOutStripButton,
            this.AllInStripButton,
            this.AllTrafficStripButton,
            this.InTrafficPictureShowButton,
            this.EditStripButton,
            this.ExportToExcelStripButton,
            this.PrintTrafficButton,
            this.ClosetoolStripButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(1111, 35);
            this.AllTrafficToolStrip.TabIndex = 9;
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = global::HPS.Properties.Resources.Print;
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(28, 32);
            this.PrintButton.Text = "چاپ قبض";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 32);
            this.RefreshButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AllCurrentTrafficButton
            // 
            this.AllCurrentTrafficButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllCurrentTrafficButton.Image = global::HPS.Properties.Resources.today;
            this.AllCurrentTrafficButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllCurrentTrafficButton.Name = "AllCurrentTrafficButton";
            this.AllCurrentTrafficButton.Size = new System.Drawing.Size(28, 32);
            this.AllCurrentTrafficButton.Text = "کل ترددهای امروز";
            this.AllCurrentTrafficButton.Click += new System.EventHandler(this.AllCurrentTrafficButton_Click);
            // 
            // DriverSpecificationButton
            // 
            this.DriverSpecificationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DriverSpecificationButton.Image = global::HPS.Properties.Resources.control;
            this.DriverSpecificationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DriverSpecificationButton.Name = "DriverSpecificationButton";
            this.DriverSpecificationButton.Size = new System.Drawing.Size(28, 32);
            this.DriverSpecificationButton.Text = "کنترل اطلاعات راننده";
            this.DriverSpecificationButton.Click += new System.EventHandler(this.DriverSpecificationButton_Click);
            // 
            // CarSpecificationButton
            // 
            this.CarSpecificationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CarSpecificationButton.Image = global::HPS.Properties.Resources.Lader;
            this.CarSpecificationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CarSpecificationButton.Name = "CarSpecificationButton";
            this.CarSpecificationButton.Size = new System.Drawing.Size(28, 32);
            this.CarSpecificationButton.Text = "کنترل اطلاعات ناوگان";
            this.CarSpecificationButton.Click += new System.EventHandler(this.CarSpecificationButton_Click);
            // 
            // InNotOutStripButton
            // 
            this.InNotOutStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InNotOutStripButton.Image = global::HPS.Properties.Resources._in;
            this.InNotOutStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InNotOutStripButton.Name = "InNotOutStripButton";
            this.InNotOutStripButton.Size = new System.Drawing.Size(28, 32);
            this.InNotOutStripButton.Text = "ورودی های خارج نشده امروز";
            this.InNotOutStripButton.Click += new System.EventHandler(this.InNotOutStripButton_Click);
            // 
            // AllInStripButton
            // 
            this.AllInStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllInStripButton.Image = global::HPS.Properties.Resources.AllIn;
            this.AllInStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllInStripButton.Name = "AllInStripButton";
            this.AllInStripButton.Size = new System.Drawing.Size(28, 32);
            this.AllInStripButton.Text = " کل ورودی های خارج نشده";
            this.AllInStripButton.Click += new System.EventHandler(this.AllInStripButton_Click);
            // 
            // AllTrafficStripButton
            // 
            this.AllTrafficStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllTrafficStripButton.Image = global::HPS.Properties.Resources.AllRecords;
            this.AllTrafficStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllTrafficStripButton.Name = "AllTrafficStripButton";
            this.AllTrafficStripButton.Size = new System.Drawing.Size(28, 32);
            this.AllTrafficStripButton.Text = "نمایش کل ترددها";
            this.AllTrafficStripButton.Click += new System.EventHandler(this.AllTrafficStripButton_Click);
            // 
            // InTrafficPictureShowButton
            // 
            this.InTrafficPictureShowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InTrafficPictureShowButton.Image = global::HPS.Properties.Resources.Search_Images_icon;
            this.InTrafficPictureShowButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InTrafficPictureShowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InTrafficPictureShowButton.Name = "InTrafficPictureShowButton";
            this.InTrafficPictureShowButton.Size = new System.Drawing.Size(32, 32);
            this.InTrafficPictureShowButton.Tag = "InTrafficPictureShowButton";
            this.InTrafficPictureShowButton.Click += new System.EventHandler(this.InTrafficPictureShowButton_Click);
            // 
            // EditStripButton
            // 
            this.EditStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditStripButton.Image = global::HPS.Properties.Resources.Edit;
            this.EditStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditStripButton.Name = "EditStripButton";
            this.EditStripButton.Size = new System.Drawing.Size(28, 32);
            this.EditStripButton.Text = "ویرایش";
            this.EditStripButton.Click += new System.EventHandler(this.EditStripButton_Click);
            // 
            // ExportToExcelStripButton
            // 
            this.ExportToExcelStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportToExcelStripButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportToExcelStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcelStripButton.Name = "ExportToExcelStripButton";
            this.ExportToExcelStripButton.Size = new System.Drawing.Size(28, 32);
            this.ExportToExcelStripButton.Text = "انتقال به excel";
            // 
            // PrintTrafficButton
            // 
            this.PrintTrafficButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintTrafficButton.Image = global::HPS.Properties.Resources.Print_icon;
            this.PrintTrafficButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintTrafficButton.Name = "PrintTrafficButton";
            this.PrintTrafficButton.Size = new System.Drawing.Size(28, 32);
            this.PrintTrafficButton.Text = "چاپ ترددهای ایرانی";
            this.PrintTrafficButton.Click += new System.EventHandler(this.PrintTrafficButton_Click);
            // 
            // ClosetoolStripButton
            // 
            this.ClosetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClosetoolStripButton.Image = global::HPS.Properties.Resources.Close;
            this.ClosetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClosetoolStripButton.Name = "ClosetoolStripButton";
            this.ClosetoolStripButton.Size = new System.Drawing.Size(28, 32);
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
            this.colDate_nvc,
            this.colTime_nvc,
            this.colNumberPlate_nvc,
            this.colPlateCity_nvc,
            this.colSerialPlate_nvc,
            this.colTrafficNumber_bint,
            this.TurnNumber_bint,
            this.colTurnNumber_bint,
            this.colTurnAccepted_bit,
            this.colArea_bit,
            this.colLadeReturn_bit,
            this.colLadBillCredit,
            this.colTurnCanceled,
            this.LadBillCanceled,
            this.colTurnReturened,
            this.colServicesType_nvc,
            this.colInText,
            this.colLaderType_nvc,
            this.colCameraPlateNumber_nvc,
            this.colCameraSerialPlate_int,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colDriverMobile_nvc,
            this.colNationalCode_int,
            this.colSystem_nvc,
            this.colDriverCardNumber_nvc,
            this.colCarCardNumber_nvc,
            this.colUserName_nvc,
            this.TurnUser_nvc,
            this.TurncancelUser,
            this.colTurnDate_nvc,
            this.colTurnTime_nvc,
            this.colEditUserName_nvc,
            this.colEditDate_vc,
            this.colEditTime_vc,
            this.Duration});
            this.TrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficGridView.Location = new System.Drawing.Point(0, 155);
            this.TrafficGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrafficGridView.MultiSelect = false;
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.ReadOnly = true;
            this.TrafficGridView.RowHeadersVisible = false;
            this.TrafficGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TrafficGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrafficGridView.Size = new System.Drawing.Size(1111, 459);
            this.TrafficGridView.TabIndex = 13;
            this.TrafficGridView.Sorted += new System.EventHandler(this.TrafficGridView_Sorted);
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 85;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 70;
            // 
            // colPlateCity_nvc
            // 
            this.colPlateCity_nvc.DataPropertyName = "PlateCityID_intPlateCity_nvc";
            this.colPlateCity_nvc.HeaderText = "شهر پلاک";
            this.colPlateCity_nvc.Name = "colPlateCity_nvc";
            this.colPlateCity_nvc.ReadOnly = true;
            this.colPlateCity_nvc.Width = 55;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            this.colSerialPlate_nvc.Width = 45;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
            this.colTrafficNumber_bint.Width = 70;
            // 
            // TurnNumber_bint
            // 
            this.TurnNumber_bint.DataPropertyName = "TurnNumber_bint";
            this.TurnNumber_bint.HeaderText = "نوبت رزرو";
            this.TurnNumber_bint.Name = "TurnNumber_bint";
            this.TurnNumber_bint.ReadOnly = true;
            this.TurnNumber_bint.Width = 70;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "نوبت تأییدی";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
            this.colTurnNumber_bint.Width = 70;
            // 
            // colTurnAccepted_bit
            // 
            this.colTurnAccepted_bit.DataPropertyName = "TurnAccepted_bit";
            this.colTurnAccepted_bit.HeaderText = "تأیید نوبت";
            this.colTurnAccepted_bit.Name = "colTurnAccepted_bit";
            this.colTurnAccepted_bit.ReadOnly = true;
            this.colTurnAccepted_bit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTurnAccepted_bit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTurnAccepted_bit.Width = 50;
            // 
            // colArea_bit
            // 
            this.colArea_bit.DataPropertyName = "Area_bit";
            this.colArea_bit.HeaderText = "شهری";
            this.colArea_bit.Name = "colArea_bit";
            this.colArea_bit.ReadOnly = true;
            this.colArea_bit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colArea_bit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colArea_bit.Width = 40;
            // 
            // colLadeReturn_bit
            // 
            this.colLadeReturn_bit.DataPropertyName = "LadeReturn_bit";
            this.colLadeReturn_bit.HeaderText = "برگشت از بار";
            this.colLadeReturn_bit.Name = "colLadeReturn_bit";
            this.colLadeReturn_bit.ReadOnly = true;
            this.colLadeReturn_bit.Width = 50;
            // 
            // colLadBillCredit
            // 
            this.colLadBillCredit.DataPropertyName = "LadBillCredit";
            this.colLadBillCredit.HeaderText = "مجوز";
            this.colLadBillCredit.Name = "colLadBillCredit";
            this.colLadBillCredit.ReadOnly = true;
            this.colLadBillCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colLadBillCredit.Width = 40;
            // 
            // colTurnCanceled
            // 
            this.colTurnCanceled.DataPropertyName = "TurnCanceled";
            this.colTurnCanceled.HeaderText = "ابطال نوبت";
            this.colTurnCanceled.Name = "colTurnCanceled";
            this.colTurnCanceled.ReadOnly = true;
            this.colTurnCanceled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTurnCanceled.Width = 45;
            // 
            // LadBillCanceled
            // 
            this.LadBillCanceled.DataPropertyName = "LadBillCanceled";
            this.LadBillCanceled.HeaderText = "ابطال مجوز";
            this.LadBillCanceled.Name = "LadBillCanceled";
            this.LadBillCanceled.ReadOnly = true;
            this.LadBillCanceled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LadBillCanceled.Width = 45;
            // 
            // colTurnReturened
            // 
            this.colTurnReturened.DataPropertyName = "TurnReturned";
            this.colTurnReturened.HeaderText = "احیای نوبت";
            this.colTurnReturened.Name = "colTurnReturened";
            this.colTurnReturened.ReadOnly = true;
            this.colTurnReturened.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTurnReturened.Width = 45;
            // 
            // colServicesType_nvc
            // 
            this.colServicesType_nvc.DataPropertyName = "ServiceID_intServiceType_nvc";
            this.colServicesType_nvc.HeaderText = "مراجعه به";
            this.colServicesType_nvc.Name = "colServicesType_nvc";
            this.colServicesType_nvc.ReadOnly = true;
            this.colServicesType_nvc.Width = 70;
            // 
            // colInText
            // 
            this.colInText.DataPropertyName = "InText";
            this.colInText.HeaderText = "نوع تردد";
            this.colInText.Name = "colInText";
            this.colInText.ReadOnly = true;
            this.colInText.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInText.Width = 60;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
            // 
            // colCameraPlateNumber_nvc
            // 
            this.colCameraPlateNumber_nvc.DataPropertyName = "CameraPlateNumber_nvc";
            this.colCameraPlateNumber_nvc.HeaderText = "شماره پلاک دوربین";
            this.colCameraPlateNumber_nvc.Name = "colCameraPlateNumber_nvc";
            this.colCameraPlateNumber_nvc.ReadOnly = true;
            this.colCameraPlateNumber_nvc.Width = 80;
            // 
            // colCameraSerialPlate_int
            // 
            this.colCameraSerialPlate_int.DataPropertyName = "CameraSerialPlate_int";
            this.colCameraSerialPlate_int.HeaderText = "سریال دوربین";
            this.colCameraSerialPlate_int.Name = "colCameraSerialPlate_int";
            this.colCameraSerialPlate_int.ReadOnly = true;
            this.colCameraSerialPlate_int.Width = 50;
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
            this.colLastName_nvc.Width = 110;
            // 
            // colDriverMobile_nvc
            // 
            this.colDriverMobile_nvc.DataPropertyName = "DriverMobileNumber_nvc";
            this.colDriverMobile_nvc.HeaderText = "شماره موبایل";
            this.colDriverMobile_nvc.Name = "colDriverMobile_nvc";
            this.colDriverMobile_nvc.ReadOnly = true;
            this.colDriverMobile_nvc.Width = 120;
            // 
            // colNationalCode_int
            // 
            this.colNationalCode_int.DataPropertyName = "NationalCode_int";
            this.colNationalCode_int.HeaderText = "کد ملی";
            this.colNationalCode_int.Name = "colNationalCode_int";
            this.colNationalCode_int.ReadOnly = true;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نوع وسیله";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            // 
            // colDriverCardNumber_nvc
            // 
            this.colDriverCardNumber_nvc.DataPropertyName = "DriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.HeaderText = "ش.ک.راننده";
            this.colDriverCardNumber_nvc.Name = "colDriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.ReadOnly = true;
            this.colDriverCardNumber_nvc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDriverCardNumber_nvc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDriverCardNumber_nvc.Width = 120;
            // 
            // colCarCardNumber_nvc
            // 
            this.colCarCardNumber_nvc.DataPropertyName = "CarCardNumber_nvc";
            this.colCarCardNumber_nvc.HeaderText = "ش.ک.خودرو";
            this.colCarCardNumber_nvc.Name = "colCarCardNumber_nvc";
            this.colCarCardNumber_nvc.ReadOnly = true;
            this.colCarCardNumber_nvc.Width = 120;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 110;
            // 
            // TurnUser_nvc
            // 
            this.TurnUser_nvc.DataPropertyName = "TurnUser_nvc";
            this.TurnUser_nvc.HeaderText = "كاربر ثبت نوبت";
            this.TurnUser_nvc.Name = "TurnUser_nvc";
            this.TurnUser_nvc.ReadOnly = true;
            this.TurnUser_nvc.Width = 130;
            // 
            // TurncancelUser
            // 
            this.TurncancelUser.DataPropertyName = "TurncancelUser";
            this.TurncancelUser.HeaderText = "كاربر ابطال نوبت";
            this.TurncancelUser.Name = "TurncancelUser";
            this.TurncancelUser.ReadOnly = true;
            this.TurncancelUser.Width = 140;
            // 
            // colTurnDate_nvc
            // 
            this.colTurnDate_nvc.DataPropertyName = "TurnDate_nvc";
            this.colTurnDate_nvc.HeaderText = "تاریخ تأیید نوبت";
            this.colTurnDate_nvc.Name = "colTurnDate_nvc";
            this.colTurnDate_nvc.ReadOnly = true;
            // 
            // colTurnTime_nvc
            // 
            this.colTurnTime_nvc.DataPropertyName = "TurnTime_nvc";
            this.colTurnTime_nvc.HeaderText = "ساعت تأیید نویت";
            this.colTurnTime_nvc.Name = "colTurnTime_nvc";
            this.colTurnTime_nvc.ReadOnly = true;
            // 
            // colEditUserName_nvc
            // 
            this.colEditUserName_nvc.DataPropertyName = "EditUserName_nvc";
            this.colEditUserName_nvc.HeaderText = "کاربر ویرایش ";
            this.colEditUserName_nvc.Name = "colEditUserName_nvc";
            this.colEditUserName_nvc.ReadOnly = true;
            // 
            // colEditDate_vc
            // 
            this.colEditDate_vc.DataPropertyName = "EditDate_vc";
            this.colEditDate_vc.HeaderText = "تاریخ ویرایش";
            this.colEditDate_vc.Name = "colEditDate_vc";
            this.colEditDate_vc.ReadOnly = true;
            // 
            // colEditTime_vc
            // 
            this.colEditTime_vc.DataPropertyName = "EditTime_vc";
            this.colEditTime_vc.HeaderText = "زمان ویرایش";
            this.colEditTime_vc.Name = "colEditTime_vc";
            this.colEditTime_vc.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Visible = false;
            // 
            // Trafficnumberlabel
            // 
            this.Trafficnumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Trafficnumberlabel.AutoSize = true;
            this.Trafficnumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Trafficnumberlabel.Location = new System.Drawing.Point(810, 31);
            this.Trafficnumberlabel.Name = "Trafficnumberlabel";
            this.Trafficnumberlabel.Size = new System.Drawing.Size(84, 20);
            this.Trafficnumberlabel.TabIndex = 48;
            this.Trafficnumberlabel.Text = "شماره قبض";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(620, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "شماره پلاك";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(517, 26);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(102, 26);
            this.NumberPlate_nvcTextBox.TabIndex = 4;
            this.NumberPlate_nvcTextBox.Tag = "شماره پلاك";
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(810, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "ش نوبت تأیید شده";
            // 
            // BooleanComboBox
            // 
            this.BooleanComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BooleanComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BooleanComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BooleanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BooleanComboBox.FormattingEnabled = true;
            this.BooleanComboBox.Location = new System.Drawing.Point(486, 68);
            this.BooleanComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BooleanComboBox.Name = "BooleanComboBox";
            this.BooleanComboBox.Size = new System.Drawing.Size(133, 28);
            this.BooleanComboBox.TabIndex = 6;
            this.BooleanComboBox.TabStop = false;
            this.BooleanComboBox.SelectedValueChanged += new System.EventHandler(this.BooleanComboBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(620, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "مقادیر ";
            // 
            // FalseradioButton
            // 
            this.FalseradioButton.AutoSize = true;
            this.FalseradioButton.Location = new System.Drawing.Point(8, 16);
            this.FalseradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FalseradioButton.Name = "FalseradioButton";
            this.FalseradioButton.Size = new System.Drawing.Size(63, 24);
            this.FalseradioButton.TabIndex = 1;
            this.FalseradioButton.Text = "ندارد";
            this.FalseradioButton.UseVisualStyleBackColor = true;
            this.FalseradioButton.CheckedChanged += new System.EventHandler(this.FalseradioButton_CheckedChanged);
            // 
            // TrueradioButton
            // 
            this.TrueradioButton.Location = new System.Drawing.Point(99, 16);
            this.TrueradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrueradioButton.Name = "TrueradioButton";
            this.TrueradioButton.Size = new System.Drawing.Size(64, 27);
            this.TrueradioButton.TabIndex = 0;
            this.TrueradioButton.Text = "دارد";
            this.TrueradioButton.UseVisualStyleBackColor = true;
            this.TrueradioButton.CheckedChanged += new System.EventHandler(this.TrueradioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TrueradioButton);
            this.groupBox1.Controls.Add(this.FalseradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(282, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(196, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(402, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "نام خانوادگی";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lastNameTextBox.Location = new System.Drawing.Point(282, 26);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.MaxLength = 40;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastNameTextBox.Size = new System.Drawing.Size(118, 26);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.Tag = "شماره پلاك";
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(195, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "کارت راننده";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(196, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "کارت ناوگان";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1049, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "تا تاریخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1049, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "از تاریخ";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(931, 72);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(119, 23);
            this.ToDatefaDatePicker.TabIndex = 1;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            this.ToDatefaDatePicker.SelectedDateTimeChanged += new System.EventHandler(this.ToDatefaDatePicker_SelectedDateTimeChanged);
            this.ToDatefaDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToDatefaDatePicker_KeyDown);
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(931, 31);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(119, 23);
            this.FromDatefaDatePicker.TabIndex = 0;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            this.FromDatefaDatePicker.SelectedDateTimeChanged += new System.EventHandler(this.FromDatefaDatePicker_SelectedDateTimeChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowButton);
            this.groupBox2.Controls.Add(this.lastNameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.carCardNumberTextBox);
            this.groupBox2.Controls.Add(this.SerialPlate_nvcTextBox);
            this.groupBox2.Controls.Add(this.driverCardNumberTextBox);
            this.groupBox2.Controls.Add(this.AcceptedTurnNumberTextBox);
            this.groupBox2.Controls.Add(this.FromDatefaDatePicker);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.TrafficNumberTextBox);
            this.groupBox2.Controls.Add(this.ToDatefaDatePicker);
            this.groupBox2.Controls.Add(this.Trafficnumberlabel);
            this.groupBox2.Controls.Add(this.BooleanComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumberPlate_nvcTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(1111, 120);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.ShowButton.Location = new System.Drawing.Point(2, 65);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(78, 38);
            this.ShowButton.TabIndex = 65;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // carCardNumberTextBox
            // 
            this.carCardNumberTextBox.AllowNegative = true;
            this.carCardNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carCardNumberTextBox.DigitsInGroup = 0;
            this.carCardNumberTextBox.Flags = 0;
            this.carCardNumberTextBox.Location = new System.Drawing.Point(83, 66);
            this.carCardNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carCardNumberTextBox.MaxDecimalPlaces = 0;
            this.carCardNumberTextBox.MaxWholeDigits = 7;
            this.carCardNumberTextBox.Name = "carCardNumberTextBox";
            this.carCardNumberTextBox.Prefix = "";
            this.carCardNumberTextBox.RangeMax = 0D;
            this.carCardNumberTextBox.RangeMin = 0D;
            this.carCardNumberTextBox.Size = new System.Drawing.Size(113, 35);
            this.carCardNumberTextBox.TabIndex = 10;
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.AllowNegative = true;
            this.SerialPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcTextBox.DigitsInGroup = 0;
            this.SerialPlate_nvcTextBox.Flags = 0;
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(486, 26);
            this.SerialPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPlate_nvcTextBox.MaxDecimalPlaces = 4;
            this.SerialPlate_nvcTextBox.MaxWholeDigits = 2;
            this.SerialPlate_nvcTextBox.Multiline = true;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.Prefix = "";
            this.SerialPlate_nvcTextBox.RangeMax = 0D;
            this.SerialPlate_nvcTextBox.RangeMin = 0D;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(29, 26);
            this.SerialPlate_nvcTextBox.TabIndex = 5;
            this.SerialPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlate_nvcTextBox_KeyDown);
            // 
            // driverCardNumberTextBox
            // 
            this.driverCardNumberTextBox.AllowNegative = true;
            this.driverCardNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.driverCardNumberTextBox.DigitsInGroup = 0;
            this.driverCardNumberTextBox.Flags = 0;
            this.driverCardNumberTextBox.Location = new System.Drawing.Point(83, 23);
            this.driverCardNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.driverCardNumberTextBox.MaxDecimalPlaces = 0;
            this.driverCardNumberTextBox.MaxWholeDigits = 7;
            this.driverCardNumberTextBox.Name = "driverCardNumberTextBox";
            this.driverCardNumberTextBox.Prefix = "";
            this.driverCardNumberTextBox.RangeMax = 0D;
            this.driverCardNumberTextBox.RangeMin = 0D;
            this.driverCardNumberTextBox.Size = new System.Drawing.Size(113, 35);
            this.driverCardNumberTextBox.TabIndex = 9;
            // 
            // AcceptedTurnNumberTextBox
            // 
            this.AcceptedTurnNumberTextBox.AllowNegative = true;
            this.AcceptedTurnNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptedTurnNumberTextBox.DigitsInGroup = 0;
            this.AcceptedTurnNumberTextBox.Flags = 0;
            this.AcceptedTurnNumberTextBox.Location = new System.Drawing.Point(691, 66);
            this.AcceptedTurnNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AcceptedTurnNumberTextBox.MaxDecimalPlaces = 4;
            this.AcceptedTurnNumberTextBox.MaxWholeDigits = 9;
            this.AcceptedTurnNumberTextBox.Name = "AcceptedTurnNumberTextBox";
            this.AcceptedTurnNumberTextBox.Prefix = "";
            this.AcceptedTurnNumberTextBox.RangeMax = 0D;
            this.AcceptedTurnNumberTextBox.RangeMin = 0D;
            this.AcceptedTurnNumberTextBox.Size = new System.Drawing.Size(116, 35);
            this.AcceptedTurnNumberTextBox.TabIndex = 3;
            this.AcceptedTurnNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcceptedTurnNumberTextBox_KeyDown);
            // 
            // TrafficNumberTextBox
            // 
            this.TrafficNumberTextBox.AllowNegative = true;
            this.TrafficNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficNumberTextBox.DigitsInGroup = 0;
            this.TrafficNumberTextBox.Flags = 0;
            this.TrafficNumberTextBox.Location = new System.Drawing.Point(691, 23);
            this.TrafficNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrafficNumberTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumberTextBox.MaxWholeDigits = 9;
            this.TrafficNumberTextBox.Name = "TrafficNumberTextBox";
            this.TrafficNumberTextBox.Prefix = "";
            this.TrafficNumberTextBox.RangeMax = 0D;
            this.TrafficNumberTextBox.RangeMin = 0D;
            this.TrafficNumberTextBox.Size = new System.Drawing.Size(116, 35);
            this.TrafficNumberTextBox.TabIndex = 2;
            this.TrafficNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficNumberTextBox_KeyDown);
            // 
            // AllTrafficstiReport
            // 
            this.AllTrafficstiReport.CookieContainer = null;
            this.AllTrafficstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.AllTrafficstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.AllTrafficstiReport.ReportAlias = "Report";
            this.AllTrafficstiReport.ReportGuid = "cdc32ffab751467b91a39af7ec169055";
            this.AllTrafficstiReport.ReportImage = null;
            this.AllTrafficstiReport.ReportName = "Report";
            this.AllTrafficstiReport.ReportSource = resources.GetString("AllTrafficstiReport.ReportSource");
            this.AllTrafficstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.AllTrafficstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.AllTrafficstiReport.UseProgressInThread = false;
            // 
            // AllTrafficForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 614);
            this.Controls.Add(this.TrafficGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.Name = "AllTrafficForm";
            this.Text = "تمام ترددها";
            this.Load += new System.EventHandler(this.AllTrafficForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllTrafficForm_KeyDown);
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView TrafficGridView;
        private System.Windows.Forms.ToolStripButton InNotOutStripButton;
        private System.Windows.Forms.ToolStripButton EditStripButton;
        private System.Windows.Forms.ToolStripButton AllTrafficStripButton;
        private System.Windows.Forms.ToolStripButton AllInStripButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton AllCurrentTrafficButton;
        private System.Windows.Forms.ToolStripButton ExportToExcelStripButton;
        private System.Windows.Forms.Label Trafficnumberlabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BooleanComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton FalseradioButton;
        private System.Windows.Forms.RadioButton TrueradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private NumericTextBox driverCardNumberTextBox;
        private NumericTextBox carCardNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private NumericTextBox TrafficNumberTextBox;
        private NumericTextBox SerialPlate_nvcTextBox;
        private NumericTextBox AcceptedTurnNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton DriverSpecificationButton;
        private System.Windows.Forms.ToolStripButton CarSpecificationButton;
        private System.Windows.Forms.ToolStripButton InTrafficPictureShowButton;
        private System.Windows.Forms.ToolStripButton PrintTrafficButton;
        private Stimulsoft.Report.StiReport AllTrafficstiReport;
        private Button ShowButton;
        private DataGridViewTextBoxColumn colTrafficID_bint;
        private DataGridViewTextBoxColumn colDate_nvc;
        private DataGridViewTextBoxColumn colTime_nvc;
        private DataGridViewTextBoxColumn colNumberPlate_nvc;
        private DataGridViewTextBoxColumn colPlateCity_nvc;
        private DataGridViewTextBoxColumn colSerialPlate_nvc;
        private DataGridViewTextBoxColumn colTrafficNumber_bint;
        private DataGridViewTextBoxColumn TurnNumber_bint;
        private DataGridViewTextBoxColumn colTurnNumber_bint;
        private DataGridViewCheckBoxColumn colTurnAccepted_bit;
        private DataGridViewCheckBoxColumn colArea_bit;
        private DataGridViewCheckBoxColumn colLadeReturn_bit;
        private DataGridViewCheckBoxColumn colLadBillCredit;
        private DataGridViewCheckBoxColumn colTurnCanceled;
        private DataGridViewCheckBoxColumn LadBillCanceled;
        private DataGridViewCheckBoxColumn colTurnReturened;
        private DataGridViewTextBoxColumn colServicesType_nvc;
        private DataGridViewTextBoxColumn colInText;
        private DataGridViewTextBoxColumn colLaderType_nvc;
        private DataGridViewTextBoxColumn colCameraPlateNumber_nvc;
        private DataGridViewTextBoxColumn colCameraSerialPlate_int;
        private DataGridViewTextBoxColumn colFirstName_nvc;
        private DataGridViewTextBoxColumn colLastName_nvc;
        private DataGridViewTextBoxColumn colDriverMobile_nvc;
        private DataGridViewTextBoxColumn colNationalCode_int;
        private DataGridViewTextBoxColumn colSystem_nvc;
        private DataGridViewTextBoxColumn colDriverCardNumber_nvc;
        private DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private DataGridViewTextBoxColumn colUserName_nvc;
        private DataGridViewTextBoxColumn TurnUser_nvc;
        private DataGridViewTextBoxColumn TurncancelUser;
        private DataGridViewTextBoxColumn colTurnDate_nvc;
        private DataGridViewTextBoxColumn colTurnTime_nvc;
        private DataGridViewTextBoxColumn colEditUserName_nvc;
        private DataGridViewTextBoxColumn colEditDate_vc;
        private DataGridViewTextBoxColumn colEditTime_vc;
        private DataGridViewTextBoxColumn Duration;
    }
}