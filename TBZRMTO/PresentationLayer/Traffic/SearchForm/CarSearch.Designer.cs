namespace HPS.Present.SearchForm
{
    partial class CarSearch
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
            this.CarToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateColorID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionYear_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystemCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CarToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CarToolStrip
            // 
            this.CarToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.CarToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CarToolStrip.Name = "CarToolStrip";
            this.CarToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CarToolStrip.Size = new System.Drawing.Size(799, 31);
            this.CarToolStrip.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = global::HPS.Properties.Resources.Check;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 28);
            this.SearchButton.Text = "جديد";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            // CarGridView
            // 
            this.CarGridView.AllowUserToAddRows = false;
            this.CarGridView.AllowUserToDeleteRows = false;
            this.CarGridView.AllowUserToResizeRows = false;
            this.CarGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarID_int,
            this.colCardDate_nvc,
            this.colCarCardNumber_nvc,
            this.colPlateType_nvc,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colPlateCityID_int,
            this.colPlateColorID_int,
            this.colCountryID_int,
            this.colCountryCode_nvc,
            this.colCountry_nvc,
            this.colYearType_nvc,
            this.colProductionYear_int,
            this.colSystem_nvc,
            this.colLaderTypeID_int,
            this.colLaderTypeCode_nvc,
            this.colSystemCode_nvc,
            this.colCapacity_int,
            this.colInfractionGroupID_int,
            this.colActive_bit});
            this.CarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarGridView.Location = new System.Drawing.Point(0, 31);
            this.CarGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowHeadersVisible = false;
            this.CarGridView.Size = new System.Drawing.Size(799, 421);
            this.CarGridView.TabIndex = 8;
            this.CarGridView.DoubleClick += new System.EventHandler(this.CarGridView_DoubleClick);
            this.CarGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarGridView_KeyDown);
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه خودرو";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // colCardDate_nvc
            // 
            this.colCardDate_nvc.DataPropertyName = "CarCardDate_nvc";
            this.colCardDate_nvc.HeaderText = "تاریخ صدور کارت";
            this.colCardDate_nvc.Name = "colCardDate_nvc";
            this.colCardDate_nvc.ReadOnly = true;
            this.colCardDate_nvc.Visible = false;
            this.colCardDate_nvc.Width = 110;
            // 
            // colCarCardNumber_nvc
            // 
            this.colCarCardNumber_nvc.DataPropertyName = "CarCardNumber_nvc";
            this.colCarCardNumber_nvc.HeaderText = "شماره کارت";
            this.colCarCardNumber_nvc.Name = "colCarCardNumber_nvc";
            this.colCarCardNumber_nvc.ReadOnly = true;
            this.colCarCardNumber_nvc.Width = 120;
            // 
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            this.colPlateType_nvc.Width = 120;
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
            this.colSerialPlate_nvc.Width = 90;
            // 
            // colPlateCityID_int
            // 
            this.colPlateCityID_int.DataPropertyName = "PlateCityID_intPlateCity_nvc";
            this.colPlateCityID_int.HeaderText = "محل شماره گذاری";
            this.colPlateCityID_int.Name = "colPlateCityID_int";
            this.colPlateCityID_int.ReadOnly = true;
            this.colPlateCityID_int.Width = 150;
            // 
            // colPlateColorID_int
            // 
            this.colPlateColorID_int.DataPropertyName = "PlateColorID_intColor_nvc";
            this.colPlateColorID_int.HeaderText = "رنگ پلاک";
            this.colPlateColorID_int.Name = "colPlateColorID_int";
            this.colPlateColorID_int.ReadOnly = true;
            this.colPlateColorID_int.Visible = false;
            this.colPlateColorID_int.Width = 85;
            // 
            // colCountryID_int
            // 
            this.colCountryID_int.DataPropertyName = "CountryID_intCountry_nvc";
            this.colCountryID_int.HeaderText = "کشور سازنده";
            this.colCountryID_int.Name = "colCountryID_int";
            this.colCountryID_int.ReadOnly = true;
            this.colCountryID_int.Visible = false;
            this.colCountryID_int.Width = 120;
            // 
            // colCountryCode_nvc
            // 
            this.colCountryCode_nvc.DataPropertyName = "CountryCode_nvc";
            this.colCountryCode_nvc.HeaderText = "کد کشور";
            this.colCountryCode_nvc.Name = "colCountryCode_nvc";
            this.colCountryCode_nvc.ReadOnly = true;
            this.colCountryCode_nvc.Visible = false;
            this.colCountryCode_nvc.Width = 85;
            // 
            // colCountry_nvc
            // 
            this.colCountry_nvc.DataPropertyName = "Country_nvc";
            this.colCountry_nvc.HeaderText = "نام کشور سازنده";
            this.colCountry_nvc.Name = "colCountry_nvc";
            this.colCountry_nvc.ReadOnly = true;
            this.colCountry_nvc.Visible = false;
            this.colCountry_nvc.Width = 120;
            // 
            // colYearType_nvc
            // 
            this.colYearType_nvc.DataPropertyName = "YearType_nvc";
            this.colYearType_nvc.HeaderText = "نوع سال";
            this.colYearType_nvc.Name = "colYearType_nvc";
            this.colYearType_nvc.ReadOnly = true;
            this.colYearType_nvc.Visible = false;
            this.colYearType_nvc.Width = 90;
            // 
            // colProductionYear_int
            // 
            this.colProductionYear_int.DataPropertyName = "ProductionYear_int";
            this.colProductionYear_int.HeaderText = "سال ساخت";
            this.colProductionYear_int.Name = "colProductionYear_int";
            this.colProductionYear_int.ReadOnly = true;
            this.colProductionYear_int.Visible = false;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نام سیستم";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            this.colSystem_nvc.Width = 120;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderTypeID_int.HeaderText = " نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            this.colLaderTypeID_int.Width = 90;
            // 
            // colLaderTypeCode_nvc
            // 
            this.colLaderTypeCode_nvc.DataPropertyName = "LaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.HeaderText = "کد نوع بارگیر";
            this.colLaderTypeCode_nvc.Name = "colLaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.ReadOnly = true;
            this.colLaderTypeCode_nvc.Visible = false;
            this.colLaderTypeCode_nvc.Width = 110;
            // 
            // colSystemCode_nvc
            // 
            this.colSystemCode_nvc.DataPropertyName = "SystemCode_nvc";
            this.colSystemCode_nvc.HeaderText = "کد سیستم";
            this.colSystemCode_nvc.Name = "colSystemCode_nvc";
            this.colSystemCode_nvc.ReadOnly = true;
            this.colSystemCode_nvc.Visible = false;
            // 
            // colCapacity_int
            // 
            this.colCapacity_int.DataPropertyName = "Capacity_flt";
            this.colCapacity_int.HeaderText = "ظرفیت";
            this.colCapacity_int.Name = "colCapacity_int";
            this.colCapacity_int.ReadOnly = true;
            this.colCapacity_int.Visible = false;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            this.colInfractionGroupID_int.Visible = false;
            this.colInfractionGroupID_int.Width = 90;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            // 
            // CarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 452);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.CarToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CarSearch";
            this.Text = "جستجوی خودرو";
            this.Load += new System.EventHandler(this.CarSearch_Load);
            this.CarToolStrip.ResumeLayout(false);
            this.CarToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip CarToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateColorID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductionYear_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystemCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }
}