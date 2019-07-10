namespace HPS.Present.SearchForm
{
    partial class DriverSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverSearch));
            this.DriverToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DriverGridView = new System.Windows.Forms.DataGridView();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalCode_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collicenceNumber_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenceCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsuranceNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenceType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLiceniceDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivityScope_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverToolStrip
            // 
            this.DriverToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DriverToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.RefreshButton,
            this.ClosetoolStripButton});
            this.DriverToolStrip.Location = new System.Drawing.Point(0, 0);
            this.DriverToolStrip.Name = "DriverToolStrip";
            this.DriverToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.DriverToolStrip.Size = new System.Drawing.Size(741, 31);
            this.DriverToolStrip.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = global::HPS.Properties.Resources.Check;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 28);
            this.SearchButton.Text = "تأیید";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.colNationalCode_int,
            this.collicenceNumber_int,
            this.colLicenceCityID_int,
            this.colDriverCardDate_nvc,
            this.colDocNumber_nvc,
            this.colDriverType_nvc,
            this.colInsuranceNumber_nvc,
            this.colCityID_int,
            this.colCityCode_nvc,
            this.colLicenceType_nvc,
            this.colLiceniceDate_nvc,
            this.colActivityScope_nvc,
            this.colActive_bit,
            this.colInfractionGroupID_int});
            this.DriverGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverGridView.Location = new System.Drawing.Point(0, 31);
            this.DriverGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DriverGridView.MultiSelect = false;
            this.DriverGridView.Name = "DriverGridView";
            this.DriverGridView.ReadOnly = true;
            this.DriverGridView.RowHeadersVisible = false;
            this.DriverGridView.Size = new System.Drawing.Size(741, 431);
            this.DriverGridView.TabIndex = 10;
            this.DriverGridView.DoubleClick += new System.EventHandler(this.DriverGridView_DoubleClick);
            this.DriverGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DriverGridView_KeyDown);
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
            this.colDriverCardNumber_nvc.HeaderText = "شماره کارت راننده";
            this.colDriverCardNumber_nvc.Name = "colDriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.ReadOnly = true;
            this.colDriverCardNumber_nvc.Width = 150;
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
            this.colFirstName_nvc.Width = 120;
            // 
            // colNationalCode_int
            // 
            this.colNationalCode_int.DataPropertyName = "NationalCode_int";
            this.colNationalCode_int.HeaderText = "کد ملی";
            this.colNationalCode_int.Name = "colNationalCode_int";
            this.colNationalCode_int.ReadOnly = true;
            // 
            // collicenceNumber_int
            // 
            this.collicenceNumber_int.DataPropertyName = "licenceNumber_nvc";
            this.collicenceNumber_int.HeaderText = "شماره گواهینامه";
            this.collicenceNumber_int.Name = "collicenceNumber_int";
            this.collicenceNumber_int.ReadOnly = true;
            this.collicenceNumber_int.Width = 120;
            // 
            // colLicenceCityID_int
            // 
            this.colLicenceCityID_int.DataPropertyName = "LicenceCityID_intCity_nvc";
            this.colLicenceCityID_int.HeaderText = "محل صدور گواهینامه";
            this.colLicenceCityID_int.Name = "colLicenceCityID_int";
            this.colLicenceCityID_int.ReadOnly = true;
            this.colLicenceCityID_int.Width = 150;
            // 
            // colDriverCardDate_nvc
            // 
            this.colDriverCardDate_nvc.DataPropertyName = "DriverCardDate_nvc";
            this.colDriverCardDate_nvc.HeaderText = "تاریخ صدور کارت";
            this.colDriverCardDate_nvc.Name = "colDriverCardDate_nvc";
            this.colDriverCardDate_nvc.ReadOnly = true;
            this.colDriverCardDate_nvc.Width = 150;
            // 
            // colDocNumber_nvc
            // 
            this.colDocNumber_nvc.DataPropertyName = "DocNumber_nvc";
            this.colDocNumber_nvc.HeaderText = "شماره پرونده";
            this.colDocNumber_nvc.Name = "colDocNumber_nvc";
            this.colDocNumber_nvc.ReadOnly = true;
            this.colDocNumber_nvc.Width = 120;
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
            this.colCityID_int.Width = 150;
            // 
            // colCityCode_nvc
            // 
            this.colCityCode_nvc.DataPropertyName = "CityCode_nvc";
            this.colCityCode_nvc.HeaderText = "کد شهر محل سکونت";
            this.colCityCode_nvc.Name = "colCityCode_nvc";
            this.colCityCode_nvc.ReadOnly = true;
            this.colCityCode_nvc.Visible = false;
            this.colCityCode_nvc.Width = 150;
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
            this.colLiceniceDate_nvc.Width = 200;
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
            this.colActive_bit.Visible = false;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_int";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            this.colInfractionGroupID_int.Visible = false;
            // 
            // DriverSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 462);
            this.Controls.Add(this.DriverGridView);
            this.Controls.Add(this.DriverToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "DriverSearch";
            this.Text = "جستجوی راننده";
            this.Load += new System.EventHandler(this.DriverSearch_Load);
            this.DriverToolStrip.ResumeLayout(false);
            this.DriverToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip DriverToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView DriverGridView;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalCode_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn collicenceNumber_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenceCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsuranceNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenceType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLiceniceDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivityScope_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;

    }
}