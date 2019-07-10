namespace HPS.Present.Driver
    {
    partial class DriverListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.DriverGridView = new System.Windows.Forms.DataGridView();
            this.DriverToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.FamilyTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.DriverCardNumebrTextBox = new System.Windows.Forms.TextBox();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalCode_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collicenceNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenceCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsertDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsuranceNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenceType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLiceniceDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivityScope_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeleted_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).BeginInit();
            this.DriverToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // DriverGridView
            // 
            this.DriverGridView.AllowUserToAddRows = false;
            this.DriverGridView.AllowUserToDeleteRows = false;
            this.DriverGridView.AllowUserToResizeRows = false;
            this.DriverGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.DriverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverID_bint,
            this.colDriverCardNumber_nvc,
            this.colLastName_nvc,
            this.colFirstName_nvc,
            this.colMobile_nvc,
            this.colNationalCode_int,
            this.collicenceNumber_nvc,
            this.colLicenceCityID_int,
            this.colDocNumber_nvc,
            this.colInsertDate_nvc,
            this.colUpdateDate_nvc,
            this.colDriverCardDate_nvc,
            this.colDriverType_nvc,
            this.colInsuranceNumber_nvc,
            this.colCityID_int,
            this.colCityCode_nvc,
            this.colLicenceType_nvc,
            this.colLiceniceDate_nvc,
            this.colActivityScope_nvc,
            this.colActive_bit,
            this.colInfractionGroupID_int,
            this.colDeleted_bit});
            this.DriverGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverGridView.Location = new System.Drawing.Point(0, 138);
            this.DriverGridView.Margin = new System.Windows.Forms.Padding(5);
            this.DriverGridView.MultiSelect = false;
            this.DriverGridView.Name = "DriverGridView";
            this.DriverGridView.ReadOnly = true;
            this.DriverGridView.RowHeadersVisible = false;
            this.DriverGridView.Size = new System.Drawing.Size(847, 314);
            this.DriverGridView.TabIndex = 0;
            // 
            // DriverToolStrip
            // 
            this.DriverToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DriverToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.DriverToolStrip.Location = new System.Drawing.Point(0, 0);
            this.DriverToolStrip.Name = "DriverToolStrip";
            this.DriverToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.DriverToolStrip.Size = new System.Drawing.Size(847, 31);
            this.DriverToolStrip.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MobileTextBox);
            this.groupBox1.Controls.Add(this.FamilyTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.NationalCodeTextBox);
            this.groupBox1.Controls.Add(this.DriverCardNumebrTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(106, 55);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(128, 30);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "موبایل";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "نام خانوادگی";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "نام";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "کد ملی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "شماره کارت هوشمند";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MobileTextBox.Location = new System.Drawing.Point(106, 16);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(128, 30);
            this.MobileTextBox.TabIndex = 2;
            // 
            // FamilyTextBox
            // 
            this.FamilyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FamilyTextBox.Location = new System.Drawing.Point(348, 52);
            this.FamilyTextBox.Name = "FamilyTextBox";
            this.FamilyTextBox.Size = new System.Drawing.Size(128, 30);
            this.FamilyTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(596, 52);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(128, 30);
            this.NameTextBox.TabIndex = 3;
            // 
            // NationalCodeTextBox
            // 
            this.NationalCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCodeTextBox.Location = new System.Drawing.Point(348, 16);
            this.NationalCodeTextBox.Name = "NationalCodeTextBox";
            this.NationalCodeTextBox.Size = new System.Drawing.Size(128, 30);
            this.NationalCodeTextBox.TabIndex = 1;
            // 
            // DriverCardNumebrTextBox
            // 
            this.DriverCardNumebrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumebrTextBox.Location = new System.Drawing.Point(596, 16);
            this.DriverCardNumebrTextBox.Name = "DriverCardNumebrTextBox";
            this.DriverCardNumebrTextBox.Size = new System.Drawing.Size(128, 30);
            this.DriverCardNumebrTextBox.TabIndex = 0;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.DataPropertyName = "DriverID_bint";
            this.colDriverID_bint.HeaderText = "شناسه راننده";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.ReadOnly = true;
            this.colDriverID_bint.Visible = false;
            // 
            // colDriverCardNumber_nvc
            // 
            this.colDriverCardNumber_nvc.DataPropertyName = "DriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.HeaderText = "شماره کارت";
            this.colDriverCardNumber_nvc.Name = "colDriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.ReadOnly = true;
            // 
            // colLastName_nvc
            // 
            this.colLastName_nvc.DataPropertyName = "LastName_nvc";
            this.colLastName_nvc.HeaderText = "نام خانوادگی";
            this.colLastName_nvc.Name = "colLastName_nvc";
            this.colLastName_nvc.ReadOnly = true;
            this.colLastName_nvc.Width = 150;
            // 
            // colFirstName_nvc
            // 
            this.colFirstName_nvc.DataPropertyName = "FirstName_nvc";
            this.colFirstName_nvc.HeaderText = "نام";
            this.colFirstName_nvc.Name = "colFirstName_nvc";
            this.colFirstName_nvc.ReadOnly = true;
            // 
            // colMobile_nvc
            // 
            this.colMobile_nvc.DataPropertyName = "Mobile_nvc";
            this.colMobile_nvc.HeaderText = "موبایل";
            this.colMobile_nvc.Name = "colMobile_nvc";
            this.colMobile_nvc.ReadOnly = true;
            // 
            // colNationalCode_int
            // 
            this.colNationalCode_int.DataPropertyName = "NationalCode_int";
            this.colNationalCode_int.HeaderText = "کد ملی";
            this.colNationalCode_int.Name = "colNationalCode_int";
            this.colNationalCode_int.ReadOnly = true;
            // 
            // collicenceNumber_nvc
            // 
            this.collicenceNumber_nvc.DataPropertyName = "licenceNumber_nvc";
            this.collicenceNumber_nvc.HeaderText = "شماره گواهینامه";
            this.collicenceNumber_nvc.Name = "collicenceNumber_nvc";
            this.collicenceNumber_nvc.ReadOnly = true;
            this.collicenceNumber_nvc.Width = 120;
            // 
            // colLicenceCityID_int
            // 
            this.colLicenceCityID_int.DataPropertyName = "LicenceCityID_intCity_nvc";
            this.colLicenceCityID_int.HeaderText = "محل صدور گواهینامه";
            this.colLicenceCityID_int.Name = "colLicenceCityID_int";
            this.colLicenceCityID_int.ReadOnly = true;
            this.colLicenceCityID_int.Width = 150;
            // 
            // colDocNumber_nvc
            // 
            this.colDocNumber_nvc.DataPropertyName = "DocNumber_nvc";
            this.colDocNumber_nvc.HeaderText = "شماره پرونده";
            this.colDocNumber_nvc.Name = "colDocNumber_nvc";
            this.colDocNumber_nvc.ReadOnly = true;
            this.colDocNumber_nvc.Width = 140;
            // 
            // colInsertDate_nvc
            // 
            this.colInsertDate_nvc.DataPropertyName = "InsertDate_nvc";
            this.colInsertDate_nvc.HeaderText = "تاريخ ورود اطلاعات";
            this.colInsertDate_nvc.Name = "colInsertDate_nvc";
            this.colInsertDate_nvc.ReadOnly = true;
            this.colInsertDate_nvc.Width = 150;
            // 
            // colUpdateDate_nvc
            // 
            this.colUpdateDate_nvc.DataPropertyName = "UpdateDate_nvc";
            this.colUpdateDate_nvc.HeaderText = "تاريخ تغيير اطلاعات";
            this.colUpdateDate_nvc.Name = "colUpdateDate_nvc";
            this.colUpdateDate_nvc.ReadOnly = true;
            this.colUpdateDate_nvc.Width = 150;
            // 
            // colDriverCardDate_nvc
            // 
            this.colDriverCardDate_nvc.DataPropertyName = "DriverCardDate_nvc";
            this.colDriverCardDate_nvc.HeaderText = "تاریخ صدور کارت";
            this.colDriverCardDate_nvc.Name = "colDriverCardDate_nvc";
            this.colDriverCardDate_nvc.ReadOnly = true;
            this.colDriverCardDate_nvc.Width = 130;
            // 
            // colDriverType_nvc
            // 
            this.colDriverType_nvc.DataPropertyName = "DriverType_nvc";
            this.colDriverType_nvc.HeaderText = "نوع راننده";
            this.colDriverType_nvc.Name = "colDriverType_nvc";
            this.colDriverType_nvc.ReadOnly = true;
            this.colDriverType_nvc.Visible = false;
            // 
            // colInsuranceNumber_nvc
            // 
            this.colInsuranceNumber_nvc.DataPropertyName = "InsuranceNumber_nvc";
            this.colInsuranceNumber_nvc.HeaderText = "شماره بیمه";
            this.colInsuranceNumber_nvc.Name = "colInsuranceNumber_nvc";
            this.colInsuranceNumber_nvc.ReadOnly = true;
            this.colInsuranceNumber_nvc.Visible = false;
            // 
            // colCityID_int
            // 
            this.colCityID_int.DataPropertyName = "CityID_intCity_nvc";
            this.colCityID_int.HeaderText = "شهر محل سکونت";
            this.colCityID_int.Name = "colCityID_int";
            this.colCityID_int.ReadOnly = true;
            this.colCityID_int.Visible = false;
            // 
            // colCityCode_nvc
            // 
            this.colCityCode_nvc.DataPropertyName = "CityCode_nvc";
            this.colCityCode_nvc.HeaderText = "کد شهر محل سکونت";
            this.colCityCode_nvc.Name = "colCityCode_nvc";
            this.colCityCode_nvc.ReadOnly = true;
            this.colCityCode_nvc.Visible = false;
            // 
            // colLicenceType_nvc
            // 
            this.colLicenceType_nvc.DataPropertyName = "LicenceType_nvc";
            this.colLicenceType_nvc.HeaderText = "نوع گواهینامه";
            this.colLicenceType_nvc.Name = "colLicenceType_nvc";
            this.colLicenceType_nvc.ReadOnly = true;
            this.colLicenceType_nvc.Visible = false;
            // 
            // colLiceniceDate_nvc
            // 
            this.colLiceniceDate_nvc.DataPropertyName = "LiceniceDate_nvc";
            this.colLiceniceDate_nvc.HeaderText = "تاریخ صدور گواهینامه";
            this.colLiceniceDate_nvc.Name = "colLiceniceDate_nvc";
            this.colLiceniceDate_nvc.ReadOnly = true;
            this.colLiceniceDate_nvc.Visible = false;
            // 
            // colActivityScope_nvc
            // 
            this.colActivityScope_nvc.DataPropertyName = "ActivityScope_nvc";
            this.colActivityScope_nvc.HeaderText = "حوزه فعالیت";
            this.colActivityScope_nvc.Name = "colActivityScope_nvc";
            this.colActivityScope_nvc.ReadOnly = true;
            this.colActivityScope_nvc.Visible = false;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            // 
            // colDeleted_bit
            // 
            this.colDeleted_bit.DataPropertyName = "Deleted_bit";
            this.colDeleted_bit.HeaderText = "حذف شده";
            this.colDeleted_bit.Name = "colDeleted_bit";
            this.colDeleted_bit.ReadOnly = true;
            this.colDeleted_bit.Visible = false;
            // 
            // DriverListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(847, 452);
            this.Controls.Add(this.DriverGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DriverToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "DriverListForm";
            this.Text = "لیست راننده (کارت هوشمند)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DriverListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).EndInit();
            this.DriverToolStrip.ResumeLayout(false);
            this.DriverToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip DriverToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView DriverGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.TextBox FamilyTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NationalCodeTextBox;
        private System.Windows.Forms.TextBox DriverCardNumebrTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalCode_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn collicenceNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenceCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsertDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsuranceNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenceType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLiceniceDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivityScope_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDeleted_bit;
    }

}