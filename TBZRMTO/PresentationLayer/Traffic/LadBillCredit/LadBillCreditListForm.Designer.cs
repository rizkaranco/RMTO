using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.LadBillCredit
    {
    partial class LadBillCreditListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadBillCreditListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Janus.Windows.GridEX.GridEXLayout AcceptedTurnGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.LadeAssignmentToolStrip = new System.Windows.Forms.ToolStrip();
            this.LadBillCredittoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.AllLatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LadeCanelRequesttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LadeAssignmentEdittoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrinterChooseStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LadeAssignmentGridView = new System.Windows.Forms.DataGridView();
            this.Choose_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCount_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortPlaceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoodID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortageFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadeAssignmentID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanceledCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoxingID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnouncementTimeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaderTypeGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SerialPlateTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.TrafficNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.TurnNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.NumberPlateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TurnDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AcceptedTurnGridView = new Janus.Windows.GridEX.GridEX();
            this.label9 = new System.Windows.Forms.Label();
            this.ShortcuttoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LadeAssignmentToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeAssignmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedTurnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LadeAssignmentToolStrip
            // 
            this.LadeAssignmentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadeAssignmentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LadBillCredittoolStripButton,
            this.RefreshButton,
            this.AllLatoolStripButton,
            this.LadeCanelRequesttoolStripButton,
            this.LadeAssignmentEdittoolStripButton,
            this.PrinterChooseStripButton});
            this.LadeAssignmentToolStrip.Location = new System.Drawing.Point(5, 28);
            this.LadeAssignmentToolStrip.Name = "LadeAssignmentToolStrip";
            this.LadeAssignmentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadeAssignmentToolStrip.Size = new System.Drawing.Size(1010, 31);
            this.LadeAssignmentToolStrip.TabIndex = 0;
            this.LadeAssignmentToolStrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeAssignmenToolStrip_KeyDown);
            // 
            // LadBillCredittoolStripButton
            // 
            this.LadBillCredittoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LadBillCredittoolStripButton.Image = global::HPS.Properties.Resources.LadBill;
            this.LadBillCredittoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LadBillCredittoolStripButton.Name = "LadBillCredittoolStripButton";
            this.LadBillCredittoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.LadBillCredittoolStripButton.Text = "تأیید مجوز بارگیری";
            this.LadBillCredittoolStripButton.ToolTipText = "تأیید مجوز بارگیری(F12)";
            this.LadBillCredittoolStripButton.Click += new System.EventHandler(this.LadBillCredittoolStripButton_Click);
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
            // AllLatoolStripButton
            // 
            this.AllLatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllLatoolStripButton.Image = global::HPS.Properties.Resources.AllRecords;
            this.AllLatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllLatoolStripButton.Name = "AllLatoolStripButton";
            this.AllLatoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.AllLatoolStripButton.Text = "نمایش تمام اطلاع رسانی بار تأیید شده";
            this.AllLatoolStripButton.Click += new System.EventHandler(this.AllLatoolStripButton_Click);
            // 
            // LadeCanelRequesttoolStripButton
            // 
            this.LadeCanelRequesttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LadeCanelRequesttoolStripButton.Image = global::HPS.Properties.Resources.ladeCancelRequest;
            this.LadeCanelRequesttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LadeCanelRequesttoolStripButton.Name = "LadeCanelRequesttoolStripButton";
            this.LadeCanelRequesttoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.LadeCanelRequesttoolStripButton.Text = "ثبت درخواست انصراف از اطلاع رسانی بار";
            this.LadeCanelRequesttoolStripButton.Click += new System.EventHandler(this.LadeCanelRequesttoolStripButton_Click);
            // 
            // LadeAssignmentEdittoolStripButton
            // 
            this.LadeAssignmentEdittoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LadeAssignmentEdittoolStripButton.Enabled = false;
            this.LadeAssignmentEdittoolStripButton.Image = global::HPS.Properties.Resources.Edit;
            this.LadeAssignmentEdittoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LadeAssignmentEdittoolStripButton.Name = "LadeAssignmentEdittoolStripButton";
            this.LadeAssignmentEdittoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.LadeAssignmentEdittoolStripButton.Text = "تغییر اطلاع رسانی بار";
            this.LadeAssignmentEdittoolStripButton.Click += new System.EventHandler(this.LadeAssignmentEdittoolStripButton_Click);
            // 
            // PrinterChooseStripButton
            // 
            this.PrinterChooseStripButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrinterChooseStripButton.Image = global::HPS.Properties.Resources.Print_icon;
            this.PrinterChooseStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrinterChooseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrinterChooseStripButton.Name = "PrinterChooseStripButton";
            this.PrinterChooseStripButton.Size = new System.Drawing.Size(107, 28);
            this.PrinterChooseStripButton.Text = "انتخاب چاپگر";
            this.PrinterChooseStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrinterChooseStripButton.Click += new System.EventHandler(this.PrinterChooseStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.LadeAssignmentToolStrip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1020, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاع رسانی بار تأیید شده";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 59);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LadeAssignmentGridView);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LaderTypeGridView);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1010, 427);
            this.splitContainer1.SplitterDistance = 883;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // LadeAssignmentGridView
            // 
            this.LadeAssignmentGridView.AllowUserToAddRows = false;
            this.LadeAssignmentGridView.AllowUserToDeleteRows = false;
            this.LadeAssignmentGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.LadeAssignmentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LadeAssignmentGridView.BackgroundColor = System.Drawing.Color.White;
            this.LadeAssignmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadeAssignmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Choose_bit,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colCompanyID_int,
            this.colCityID_int,
            this.colAddress_nvc,
            this.colCarCount_int,
            this.colPortPlaceID_int,
            this.colGoodID_int,
            this.colPortageFee_dec,
            this.colComment_nvc,
            this.colLadeAssignmentID_bint,
            this.LadBill,
            this.CanceledCar,
            this.colBoxingID_int,
            this.colMinWeight_dec,
            this.colMaxWeight_dec,
            this.colAnnouncementTimeID_int,
            this.colUserName_nvc});
            this.LadeAssignmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadeAssignmentGridView.Location = new System.Drawing.Point(0, 0);
            this.LadeAssignmentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadeAssignmentGridView.MultiSelect = false;
            this.LadeAssignmentGridView.Name = "LadeAssignmentGridView";
            this.LadeAssignmentGridView.ReadOnly = true;
            this.LadeAssignmentGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LadeAssignmentGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.LadeAssignmentGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LadeAssignmentGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LadeAssignmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LadeAssignmentGridView.Size = new System.Drawing.Size(883, 427);
            this.LadeAssignmentGridView.TabIndex = 0;
            this.ShortcuttoolTip.SetToolTip(this.LadeAssignmentGridView, " برای جابه جایی بین دو جدول ازCTRL+Dاستفاده نمایید  ");
            this.LadeAssignmentGridView.SelectionChanged += new System.EventHandler(this.LadeAssignmentGridView_SelectionChanged);
            this.LadeAssignmentGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeAssignmentGridView_KeyDown);
            // 
            // Choose_bit
            // 
            this.Choose_bit.HeaderText = "انتخاب";
            this.Choose_bit.Name = "Choose_bit";
            this.Choose_bit.ReadOnly = true;
            this.Choose_bit.Visible = false;
            this.Choose_bit.Width = 50;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ ثبت";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 80;
            // 
            // colCompanyID_int
            // 
            this.colCompanyID_int.DataPropertyName = "CompanyID_intCompany_nvc";
            this.colCompanyID_int.HeaderText = "شرکت";
            this.colCompanyID_int.Name = "colCompanyID_int";
            this.colCompanyID_int.ReadOnly = true;
            // 
            // colCityID_int
            // 
            this.colCityID_int.DataPropertyName = "CityID_intCity_nvc";
            this.colCityID_int.HeaderText = "شهر مقصد";
            this.colCityID_int.Name = "colCityID_int";
            this.colCityID_int.ReadOnly = true;
            // 
            // colAddress_nvc
            // 
            this.colAddress_nvc.DataPropertyName = "Address_nvc";
            this.colAddress_nvc.HeaderText = "آدرس مقصد";
            this.colAddress_nvc.Name = "colAddress_nvc";
            this.colAddress_nvc.ReadOnly = true;
            // 
            // colCarCount_int
            // 
            this.colCarCount_int.DataPropertyName = "CarCount_int";
            this.colCarCount_int.HeaderText = "تعداد";
            this.colCarCount_int.Name = "colCarCount_int";
            this.colCarCount_int.ReadOnly = true;
            this.colCarCount_int.Width = 50;
            // 
            // colPortPlaceID_int
            // 
            this.colPortPlaceID_int.DataPropertyName = "PortPlaceID_intPortPlaces_nvc";
            this.colPortPlaceID_int.HeaderText = "محل بارگیری";
            this.colPortPlaceID_int.Name = "colPortPlaceID_int";
            this.colPortPlaceID_int.ReadOnly = true;
            this.colPortPlaceID_int.Width = 110;
            // 
            // colGoodID_int
            // 
            this.colGoodID_int.DataPropertyName = "GoodID_intGood_nvc";
            this.colGoodID_int.HeaderText = "کالا";
            this.colGoodID_int.Name = "colGoodID_int";
            this.colGoodID_int.ReadOnly = true;
            this.colGoodID_int.Width = 90;
            // 
            // colPortageFee_dec
            // 
            this.colPortageFee_dec.DataPropertyName = "PortageFee_dec";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colPortageFee_dec.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPortageFee_dec.HeaderText = "نرخ حمل";
            this.colPortageFee_dec.Name = "colPortageFee_dec";
            this.colPortageFee_dec.ReadOnly = true;
            this.colPortageFee_dec.Width = 90;
            // 
            // colComment_nvc
            // 
            this.colComment_nvc.DataPropertyName = "Comment_nvc";
            this.colComment_nvc.HeaderText = "توضیحات";
            this.colComment_nvc.Name = "colComment_nvc";
            this.colComment_nvc.ReadOnly = true;
            this.colComment_nvc.Width = 130;
            // 
            // colLadeAssignmentID_bint
            // 
            this.colLadeAssignmentID_bint.DataPropertyName = "LadeAssignmentID_bint";
            this.colLadeAssignmentID_bint.HeaderText = "شماره بار";
            this.colLadeAssignmentID_bint.Name = "colLadeAssignmentID_bint";
            this.colLadeAssignmentID_bint.ReadOnly = true;
            this.colLadeAssignmentID_bint.Width = 90;
            // 
            // LadBill
            // 
            this.LadBill.DataPropertyName = "LadBill";
            this.LadBill.HeaderText = "تعداد مجوز";
            this.LadBill.Name = "LadBill";
            this.LadBill.ReadOnly = true;
            // 
            // CanceledCar
            // 
            this.CanceledCar.DataPropertyName = "CanceledCar";
            this.CanceledCar.HeaderText = "ت.بارگیر حذف شده";
            this.CanceledCar.Name = "CanceledCar";
            this.CanceledCar.ReadOnly = true;
            this.CanceledCar.Visible = false;
            this.CanceledCar.Width = 160;
            // 
            // colBoxingID_int
            // 
            this.colBoxingID_int.DataPropertyName = "BoxingID_intBoxingType_nvc";
            this.colBoxingID_int.HeaderText = "نوع بسته بندی";
            this.colBoxingID_int.Name = "colBoxingID_int";
            this.colBoxingID_int.ReadOnly = true;
            this.colBoxingID_int.Width = 150;
            // 
            // colMinWeight_dec
            // 
            this.colMinWeight_dec.DataPropertyName = "MinWeight_dec";
            this.colMinWeight_dec.HeaderText = "از وزن";
            this.colMinWeight_dec.Name = "colMinWeight_dec";
            this.colMinWeight_dec.ReadOnly = true;
            // 
            // colMaxWeight_dec
            // 
            this.colMaxWeight_dec.DataPropertyName = "MaxWeight_dec";
            this.colMaxWeight_dec.HeaderText = "تا وزن";
            this.colMaxWeight_dec.Name = "colMaxWeight_dec";
            this.colMaxWeight_dec.ReadOnly = true;
            // 
            // colAnnouncementTimeID_int
            // 
            this.colAnnouncementTimeID_int.DataPropertyName = "AnnouncementTimeID_intAnnouncementTime_nvc";
            this.colAnnouncementTimeID_int.HeaderText = "زمان اطلاع رسانی";
            this.colAnnouncementTimeID_int.Name = "colAnnouncementTimeID_int";
            this.colAnnouncementTimeID_int.ReadOnly = true;
            this.colAnnouncementTimeID_int.Width = 130;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "LadeUser";
            this.colUserName_nvc.HeaderText = "کاربر ثبت کننده";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 120;
            // 
            // LaderTypeGridView
            // 
            this.LaderTypeGridView.AllowUserToAddRows = false;
            this.LaderTypeGridView.AllowUserToDeleteRows = false;
            this.LaderTypeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.LaderTypeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LaderTypeGridView.BackgroundColor = System.Drawing.Color.White;
            this.LaderTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaderTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.LaderType_nvc,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.LaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaderTypeGridView.Location = new System.Drawing.Point(0, 0);
            this.LaderTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeGridView.MultiSelect = false;
            this.LaderTypeGridView.Name = "LaderTypeGridView";
            this.LaderTypeGridView.ReadOnly = true;
            this.LaderTypeGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LaderTypeGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LaderTypeGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.LaderTypeGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.LaderTypeGridView.Size = new System.Drawing.Size(126, 427);
            this.LaderTypeGridView.TabIndex = 0;
            this.LaderTypeGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MultiLaderTypeID_int";
            this.dataGridViewTextBoxColumn5.HeaderText = "شناسه انتخاب چند بارگیر";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // LaderType_nvc
            // 
            this.LaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.LaderType_nvc.HeaderText = "نوع بارگیر";
            this.LaderType_nvc.Name = "LaderType_nvc";
            this.LaderType_nvc.ReadOnly = true;
            this.LaderType_nvc.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LaderTypeID_int";
            this.dataGridViewTextBoxColumn7.HeaderText = "نوع بارگیر";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 220;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LadeAssignmentID_bint";
            this.dataGridViewTextBoxColumn8.HeaderText = "اطلاع رسانی بار";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.SerialPlateTextBox);
            this.groupBox2.Controls.Add(this.TrafficNumberTextBox);
            this.groupBox2.Controls.Add(this.TurnNumberTextBox);
            this.groupBox2.Controls.Add(this.NumberPlateTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TurnDateTextBox);
            this.groupBox2.Controls.Add(this.AcceptedTurnGridView);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 491);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1020, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوبت های تأیید شده";
            // 
            // SerialPlateTextBox
            // 
            this.SerialPlateTextBox.AllowNegative = true;
            this.SerialPlateTextBox.DigitsInGroup = 0;
            this.SerialPlateTextBox.Flags = 0;
            this.SerialPlateTextBox.Location = new System.Drawing.Point(253, 22);
            this.SerialPlateTextBox.MaxDecimalPlaces = 4;
            this.SerialPlateTextBox.MaxWholeDigits = 2;
            this.SerialPlateTextBox.Name = "SerialPlateTextBox";
            this.SerialPlateTextBox.Prefix = "";
            this.SerialPlateTextBox.RangeMax = 0D;
            this.SerialPlateTextBox.RangeMin = 0D;
            this.SerialPlateTextBox.Size = new System.Drawing.Size(44, 30);
            this.SerialPlateTextBox.TabIndex = 12;
            this.SerialPlateTextBox.Visible = false;
            this.SerialPlateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlateTextBox_KeyDown);
            // 
            // TrafficNumberTextBox
            // 
            this.TrafficNumberTextBox.AllowNegative = true;
            this.TrafficNumberTextBox.DigitsInGroup = 0;
            this.TrafficNumberTextBox.Flags = 0;
            this.TrafficNumberTextBox.Location = new System.Drawing.Point(812, 22);
            this.TrafficNumberTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumberTextBox.MaxWholeDigits = 150;
            this.TrafficNumberTextBox.Name = "TrafficNumberTextBox";
            this.TrafficNumberTextBox.Prefix = "";
            this.TrafficNumberTextBox.RangeMax = 0D;
            this.TrafficNumberTextBox.RangeMin = 0D;
            this.TrafficNumberTextBox.Size = new System.Drawing.Size(124, 30);
            this.TrafficNumberTextBox.TabIndex = 9;
            this.TrafficNumberTextBox.TextChanged += new System.EventHandler(this.TrafficNumberTextBox_TextChanged);
            this.TrafficNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficNumberTextBox_KeyDown);
            // 
            // TurnNumberTextBox
            // 
            this.TurnNumberTextBox.AllowNegative = true;
            this.TurnNumberTextBox.DigitsInGroup = 0;
            this.TurnNumberTextBox.Flags = 0;
            this.TurnNumberTextBox.Location = new System.Drawing.Point(534, 22);
            this.TurnNumberTextBox.MaxDecimalPlaces = 4;
            this.TurnNumberTextBox.MaxWholeDigits = 150;
            this.TurnNumberTextBox.Name = "TurnNumberTextBox";
            this.TurnNumberTextBox.Prefix = "";
            this.TurnNumberTextBox.RangeMax = 0D;
            this.TurnNumberTextBox.RangeMin = 0D;
            this.TurnNumberTextBox.Size = new System.Drawing.Size(124, 30);
            this.TurnNumberTextBox.TabIndex = 10;
            this.TurnNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurnNumberTextBox_KeyDown);
            // 
            // NumberPlateTextBox
            // 
            this.NumberPlateTextBox.Location = new System.Drawing.Point(299, 22);
            this.NumberPlateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlateTextBox.Name = "NumberPlateTextBox";
            this.NumberPlateTextBox.Size = new System.Drawing.Size(133, 30);
            this.NumberPlateTextBox.TabIndex = 11;
            this.NumberPlateTextBox.Visible = false;
            this.NumberPlateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberPlateTextBox_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "تاریخ تأیید نوبت";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "شماره پلاک";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(943, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "شماره قبض";
            // 
            // TurnDateTextBox
            // 
            this.TurnDateTextBox.Location = new System.Drawing.Point(24, 23);
            this.TurnDateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnDateTextBox.Mask = "0000/00/00";
            this.TurnDateTextBox.Name = "TurnDateTextBox";
            this.TurnDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnDateTextBox.Size = new System.Drawing.Size(93, 30);
            this.TurnDateTextBox.TabIndex = 13;
            this.TurnDateTextBox.Visible = false;
            this.TurnDateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurnDateTextBox_KeyDown);
            // 
            // AcceptedTurnGridView
            // 
            this.AcceptedTurnGridView.AlternatingColors = true;
            this.AcceptedTurnGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.AcceptedTurnGridView.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>ستون ه" +
    "ا را برای گزوه بندی کشیده و در این قسمت رها کنید</GroupByBoxInfo></LocalizableDa" +
    "ta>";
            this.AcceptedTurnGridView.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.AcceptedTurnGridView.CellToolTipText = "استفاده نمایید  CTRL+D برای جابه جایی بین دو جدول از";
            AcceptedTurnGridView_DesignTimeLayout.LayoutString = resources.GetString("AcceptedTurnGridView_DesignTimeLayout.LayoutString");
            this.AcceptedTurnGridView.DesignTimeLayout = AcceptedTurnGridView_DesignTimeLayout;
            this.AcceptedTurnGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptedTurnGridView.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.AcceptedTurnGridView.GroupByBoxVisible = false;
            this.AcceptedTurnGridView.Location = new System.Drawing.Point(5, 71);
            this.AcceptedTurnGridView.Margin = new System.Windows.Forms.Padding(5);
            this.AcceptedTurnGridView.Name = "AcceptedTurnGridView";
            this.AcceptedTurnGridView.Size = new System.Drawing.Size(1010, 151);
            this.AcceptedTurnGridView.TabIndex = 13;
            this.AcceptedTurnGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcceptedTurnGridView_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(661, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "شماره نوبت تأیید شده";
            // 
            // LadBillCreditListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1020, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LadBillCreditListForm";
            this.Text = "اختصاص مجوز بارگیری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LadBillCreditListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadBillCreditListForm_KeyDown);
            this.LadeAssignmentToolStrip.ResumeLayout(false);
            this.LadeAssignmentToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LadeAssignmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedTurnGridView)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolStrip LadeAssignmentToolStrip;
        private System.Windows.Forms.ToolStripButton LadBillCredittoolStripButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton AllLatoolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView LaderTypeGridView;
        private System.Windows.Forms.ToolStripButton PrinterChooseStripButton;
        private System.Windows.Forms.ToolTip ShortcuttoolTip;
        private System.Windows.Forms.DataGridView LadeAssignmentGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberPlateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TurnDateTextBox;
        private Janus.Windows.GridEX.GridEX AcceptedTurnGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripButton LadeAssignmentEdittoolStripButton;
        private System.Windows.Forms.ToolStripButton LadeCanelRequesttoolStripButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choose_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCount_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortPlaceID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortageFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadeAssignmentID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanceledCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinWeight_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxWeight_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnnouncementTimeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private NumericTextBox TurnNumberTextBox;
        private NumericTextBox TrafficNumberTextBox;
        private NumericTextBox SerialPlateTextBox;
    }

}