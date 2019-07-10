namespace HPS.Present.Infraction
    {
    partial class InfractionListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.InfractionGridView = new System.Windows.Forms.DataGridView();
            this.colInfractionID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverNationalCode_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverLicenceNumber_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegisterUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegisterDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegisterTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegiaterComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolverUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolveDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolveTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolveComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPenaltyFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOtherOffender_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfractionToolStrip = new System.Windows.Forms.ToolStrip();
            this.ShowAlltoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompanyID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.SerialPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_nvctextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.InfractionGridView)).BeginInit();
            this.InfractionToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.Text = "جديد";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(28, 28);
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // InfractionGridView
            // 
            this.InfractionGridView.AllowUserToAddRows = false;
            this.InfractionGridView.AllowUserToDeleteRows = false;
            this.InfractionGridView.AllowUserToResizeRows = false;
            this.InfractionGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.InfractionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfractionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfractionID_int,
            this.colInfractionTypeID_int,
            this.colDriverID_bint,
            this.colDriverFirstName_nvc,
            this.colDriverLastName_nvc,
            this.colDriverNationalCode_bint,
            this.colDriverLicenceNumber_int,
            this.colCarID_int,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colPlateCityCode_nvc,
            this.colCompanyID_int,
            this.colCompanyCode_nvc,
            this.colCompanyName_nvc,
            this.colRegisterUserName_nvc,
            this.colRegisterDate_nvc,
            this.colRegisterTime_nvc,
            this.colRegiaterComment_nvc,
            this.colSolverUserName_nvc,
            this.colSolveDate_nvc,
            this.colSolveTime_nvc,
            this.colSolveComment_nvc,
            this.colPenaltyFee_dec,
            this.colOtherOffender_nvc});
            this.InfractionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfractionGridView.Location = new System.Drawing.Point(0, 0);
            this.InfractionGridView.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGridView.MultiSelect = false;
            this.InfractionGridView.Name = "InfractionGridView";
            this.InfractionGridView.ReadOnly = true;
            this.InfractionGridView.RowHeadersVisible = false;
            this.InfractionGridView.Size = new System.Drawing.Size(803, 406);
            this.InfractionGridView.TabIndex = 4;
            // 
            // colInfractionID_int
            // 
            this.colInfractionID_int.DataPropertyName = "InfractionID_int";
            this.colInfractionID_int.HeaderText = "شناسه  تخلفات";
            this.colInfractionID_int.Name = "colInfractionID_int";
            this.colInfractionID_int.ReadOnly = true;
            this.colInfractionID_int.Visible = false;
            // 
            // colInfractionTypeID_int
            // 
            this.colInfractionTypeID_int.DataPropertyName = "InfractionTypeID_intInfractionType_nvc";
            this.colInfractionTypeID_int.HeaderText = " نوع تخلف";
            this.colInfractionTypeID_int.Name = "colInfractionTypeID_int";
            this.colInfractionTypeID_int.ReadOnly = true;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.DataPropertyName = "DriverID_bint";
            this.colDriverID_bint.HeaderText = " راننده";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.ReadOnly = true;
            this.colDriverID_bint.Visible = false;
            // 
            // colDriverFirstName_nvc
            // 
            this.colDriverFirstName_nvc.DataPropertyName = "DriverFirstName_nvc";
            this.colDriverFirstName_nvc.HeaderText = "نام راننده";
            this.colDriverFirstName_nvc.Name = "colDriverFirstName_nvc";
            this.colDriverFirstName_nvc.ReadOnly = true;
            // 
            // colDriverLastName_nvc
            // 
            this.colDriverLastName_nvc.DataPropertyName = "DriverLastName_nvc";
            this.colDriverLastName_nvc.HeaderText = "نام خانوادگی راننده";
            this.colDriverLastName_nvc.Name = "colDriverLastName_nvc";
            this.colDriverLastName_nvc.ReadOnly = true;
            this.colDriverLastName_nvc.Width = 150;
            // 
            // colDriverNationalCode_bint
            // 
            this.colDriverNationalCode_bint.DataPropertyName = "DriverNationalCode_bint";
            this.colDriverNationalCode_bint.HeaderText = "کد ملی";
            this.colDriverNationalCode_bint.Name = "colDriverNationalCode_bint";
            this.colDriverNationalCode_bint.ReadOnly = true;
            // 
            // colDriverLicenceNumber_int
            // 
            this.colDriverLicenceNumber_int.DataPropertyName = "DriverLicenceNumber_int";
            this.colDriverLicenceNumber_int.HeaderText = "شماره گواهینامه";
            this.colDriverLicenceNumber_int.Name = "colDriverLicenceNumber_int";
            this.colDriverLicenceNumber_int.ReadOnly = true;
            this.colDriverLicenceNumber_int.Width = 120;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = " خودرو";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // colPlateCityCode_nvc
            // 
            this.colPlateCityCode_nvc.DataPropertyName = "PlateCityCode_nvc";
            this.colPlateCityCode_nvc.HeaderText = "کد شهر شماره گذاری";
            this.colPlateCityCode_nvc.Name = "colPlateCityCode_nvc";
            this.colPlateCityCode_nvc.ReadOnly = true;
            this.colPlateCityCode_nvc.Width = 150;
            // 
            // colCompanyID_int
            // 
            this.colCompanyID_int.DataPropertyName = "CompanyID_intCompany_nvc";
            this.colCompanyID_int.HeaderText = "شرکت";
            this.colCompanyID_int.Name = "colCompanyID_int";
            this.colCompanyID_int.ReadOnly = true;
            this.colCompanyID_int.Visible = false;
            // 
            // colCompanyCode_nvc
            // 
            this.colCompanyCode_nvc.DataPropertyName = "CompanyCode_nvc";
            this.colCompanyCode_nvc.HeaderText = "کد شرکت";
            this.colCompanyCode_nvc.Name = "colCompanyCode_nvc";
            this.colCompanyCode_nvc.ReadOnly = true;
            // 
            // colCompanyName_nvc
            // 
            this.colCompanyName_nvc.DataPropertyName = "CompanyID_intCompany_nvc";
            this.colCompanyName_nvc.HeaderText = " نام شرکت";
            this.colCompanyName_nvc.Name = "colCompanyName_nvc";
            this.colCompanyName_nvc.ReadOnly = true;
            // 
            // colRegisterUserName_nvc
            // 
            this.colRegisterUserName_nvc.DataPropertyName = "RegisterUserName_nvcUserName_nvc";
            this.colRegisterUserName_nvc.HeaderText = " کاربر ثبت کننده";
            this.colRegisterUserName_nvc.Name = "colRegisterUserName_nvc";
            this.colRegisterUserName_nvc.ReadOnly = true;
            this.colRegisterUserName_nvc.Width = 160;
            // 
            // colRegisterDate_nvc
            // 
            this.colRegisterDate_nvc.DataPropertyName = "RegisterDate_nvc";
            this.colRegisterDate_nvc.HeaderText = "تاریخ ثبت";
            this.colRegisterDate_nvc.Name = "colRegisterDate_nvc";
            this.colRegisterDate_nvc.ReadOnly = true;
            // 
            // colRegisterTime_nvc
            // 
            this.colRegisterTime_nvc.DataPropertyName = "RegisterTime_nvc";
            this.colRegisterTime_nvc.HeaderText = "ساعت ثبت";
            this.colRegisterTime_nvc.Name = "colRegisterTime_nvc";
            this.colRegisterTime_nvc.ReadOnly = true;
            // 
            // colRegiaterComment_nvc
            // 
            this.colRegiaterComment_nvc.DataPropertyName = "RegiaterComment_nvc";
            this.colRegiaterComment_nvc.HeaderText = "توضیحات ثبت";
            this.colRegiaterComment_nvc.Name = "colRegiaterComment_nvc";
            this.colRegiaterComment_nvc.ReadOnly = true;
            this.colRegiaterComment_nvc.Width = 150;
            // 
            // colSolverUserName_nvc
            // 
            this.colSolverUserName_nvc.DataPropertyName = "SolverUserName_nvcUserName_nvc";
            this.colSolverUserName_nvc.HeaderText = " کاربر رفع کننده";
            this.colSolverUserName_nvc.Name = "colSolverUserName_nvc";
            this.colSolverUserName_nvc.ReadOnly = true;
            this.colSolverUserName_nvc.Width = 180;
            // 
            // colSolveDate_nvc
            // 
            this.colSolveDate_nvc.DataPropertyName = "SolveDate_nvc";
            this.colSolveDate_nvc.HeaderText = "تاریخ رفع";
            this.colSolveDate_nvc.Name = "colSolveDate_nvc";
            this.colSolveDate_nvc.ReadOnly = true;
            this.colSolveDate_nvc.Width = 120;
            // 
            // colSolveTime_nvc
            // 
            this.colSolveTime_nvc.DataPropertyName = "SolveTime_nvc";
            this.colSolveTime_nvc.HeaderText = "ساعت رفع";
            this.colSolveTime_nvc.Name = "colSolveTime_nvc";
            this.colSolveTime_nvc.ReadOnly = true;
            this.colSolveTime_nvc.Width = 120;
            // 
            // colSolveComment_nvc
            // 
            this.colSolveComment_nvc.DataPropertyName = "SolveComment_nvc";
            this.colSolveComment_nvc.HeaderText = "توضیحات رفع";
            this.colSolveComment_nvc.Name = "colSolveComment_nvc";
            this.colSolveComment_nvc.ReadOnly = true;
            this.colSolveComment_nvc.Width = 150;
            // 
            // colPenaltyFee_dec
            // 
            this.colPenaltyFee_dec.DataPropertyName = "PenaltyFee_dec";
            this.colPenaltyFee_dec.HeaderText = "مبلغ جریمه";
            this.colPenaltyFee_dec.Name = "colPenaltyFee_dec";
            this.colPenaltyFee_dec.ReadOnly = true;
            // 
            // colOtherOffender_nvc
            // 
            this.colOtherOffender_nvc.DataPropertyName = "OtherOffender_nvcFullName_nvc";
            this.colOtherOffender_nvc.HeaderText = "دیگر متخلفان";
            this.colOtherOffender_nvc.Name = "colOtherOffender_nvc";
            this.colOtherOffender_nvc.ReadOnly = true;
            this.colOtherOffender_nvc.Width = 120;
            // 
            // InfractionToolStrip
            // 
            this.InfractionToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InfractionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton,
            this.ShowAlltoolStripButton});
            this.InfractionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InfractionToolStrip.Name = "InfractionToolStrip";
            this.InfractionToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InfractionToolStrip.Size = new System.Drawing.Size(803, 31);
            this.InfractionToolStrip.TabIndex = 1;
            // 
            // ShowAlltoolStripButton
            // 
            this.ShowAlltoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowAlltoolStripButton.Image = global::HPS.Properties.Resources.AllRecords;
            this.ShowAlltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowAlltoolStripButton.Name = "ShowAlltoolStripButton";
            this.ShowAlltoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ShowAlltoolStripButton.Text = "نمایش همه";
            this.ShowAlltoolStripButton.Click += new System.EventHandler(this.ShowAlltoolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.CompanyID_intComboBox);
            this.groupBox1.Controls.Add(this.CompanyID_intLabel);
            this.groupBox1.Controls.Add(this.SerialPlate_nvctextBox);
            this.groupBox1.Controls.Add(this.NumberPlate_nvctextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lastName_nvctextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(803, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CompanyID_intComboBox
            // 
            this.CompanyID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CompanyID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyID_intComboBox.DropDownHeight = 200;
            this.CompanyID_intComboBox.FormattingEnabled = true;
            this.CompanyID_intComboBox.IntegralHeight = false;
            this.CompanyID_intComboBox.Location = new System.Drawing.Point(99, 16);
            this.CompanyID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intComboBox.Name = "CompanyID_intComboBox";
            this.CompanyID_intComboBox.Size = new System.Drawing.Size(191, 31);
            this.CompanyID_intComboBox.TabIndex = 17;
            this.CompanyID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.CompanyID_intComboBox_SelectionChangeCommitted);
            this.CompanyID_intComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyID_intComboBox_KeyDown);
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Location = new System.Drawing.Point(300, 20);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(45, 23);
            this.CompanyID_intLabel.TabIndex = 16;
            this.CompanyID_intLabel.Text = "شرکت";
            // 
            // SerialPlate_nvctextBox
            // 
            this.SerialPlate_nvctextBox.Location = new System.Drawing.Point(369, 17);
            this.SerialPlate_nvctextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialPlate_nvctextBox.Name = "SerialPlate_nvctextBox";
            this.SerialPlate_nvctextBox.Size = new System.Drawing.Size(32, 30);
            this.SerialPlate_nvctextBox.TabIndex = 2;
            this.SerialPlate_nvctextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlate_nvctextBox_KeyDown);
            // 
            // NumberPlate_nvctextBox
            // 
            this.NumberPlate_nvctextBox.Location = new System.Drawing.Point(403, 17);
            this.NumberPlate_nvctextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberPlate_nvctextBox.Name = "NumberPlate_nvctextBox";
            this.NumberPlate_nvctextBox.Size = new System.Drawing.Size(95, 30);
            this.NumberPlate_nvctextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره پلاک";
            // 
            // lastName_nvctextBox
            // 
            this.lastName_nvctextBox.Location = new System.Drawing.Point(586, 17);
            this.lastName_nvctextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName_nvctextBox.Name = "lastName_nvctextBox";
            this.lastName_nvctextBox.Size = new System.Drawing.Size(134, 30);
            this.lastName_nvctextBox.TabIndex = 0;
            this.lastName_nvctextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastName_nvctextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(722, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام خانوادگی";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.InfractionToolStrip);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.InfractionGridView);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(803, 492);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // InfractionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(803, 492);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(17);
            this.Name = "InfractionListForm";
            this.Text = "لیست تخلفات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfractionListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfractionGridView)).EndInit();
            this.InfractionToolStrip.ResumeLayout(false);
            this.InfractionToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolStrip InfractionToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView InfractionGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastName_nvctextBox;
        private System.Windows.Forms.TextBox NumberPlate_nvctextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SerialPlate_nvctextBox;
        private System.Windows.Forms.ToolStripButton ShowAlltoolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverNationalCode_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverLicenceNumber_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegisterUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegisterDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegisterTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegiaterComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolverUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolveDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolveTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolveComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenaltyFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOtherOffender_nvc;
        private System.Windows.Forms.Label CompanyID_intLabel;
        private System.Windows.Forms.ComboBox CompanyID_intComboBox;
    }

}