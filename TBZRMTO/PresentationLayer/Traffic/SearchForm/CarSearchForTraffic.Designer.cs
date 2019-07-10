namespace HPS.Present.SearchForm
{
    partial class CarSearchForTraffic
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CarCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateColorID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCountry_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionYear_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystemCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.CarCardNumber_nvcTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.SerialPlate_nvcTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.NumberPlate_nvcTextBox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(878, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(30, 23);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(117, 28);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "انصراف";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(30, 58);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 28);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "جستجو (Alt+F3)";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CarCardNumber_nvcTextBox
            // 
            this.CarCardNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCardNumber_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CarCardNumber_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarCardNumber_nvcTextBox.Location = new System.Drawing.Point(191, 29);
            this.CarCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarCardNumber_nvcTextBox.MaxLength = 7;
            this.CarCardNumber_nvcTextBox.Name = "CarCardNumber_nvcTextBox";
            this.CarCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardNumber_nvcTextBox.Size = new System.Drawing.Size(227, 22);
            this.CarCardNumber_nvcTextBox.TabIndex = 24;
            this.CarCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(432, 36);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "شماره كارت هوشمند";
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialPlate_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(557, 65);
            this.SerialPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialPlate_nvcTextBox.MaxLength = 2;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(238, 22);
            this.SerialPlate_nvcTextBox.TabIndex = 22;
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(808, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "سري";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(557, 33);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(235, 22);
            this.NumberPlate_nvcTextBox.TabIndex = 19;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(804, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "شماره پلاك";
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
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colPlateCityID_int,
            this.colPlateColorID_int,
            this.colCountryID_int,
            this.colCountryCode_nvc,
            this.colActive_bit,
            this.colCountry_nvc,
            this.colYearType_nvc,
            this.colProductionYear_int,
            this.colSystem_nvc,
            this.colLaderTypeID_int,
            this.colPlateType_nvc,
            this.colLaderTypeCode_nvc,
            this.colSystemCode_nvc,
            this.colCapacity_int,
            this.colInfractionGroupID_int});
            this.CarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarGridView.Location = new System.Drawing.Point(0, 106);
            this.CarGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowHeadersVisible = false;
            this.CarGridView.Size = new System.Drawing.Size(878, 372);
            this.CarGridView.TabIndex = 9;
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
            this.colCarCardNumber_nvc.Width = 150;
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
            this.colPlateCityID_int.Width = 210;
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
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 50;
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
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            this.colPlateType_nvc.Width = 120;
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
            // CarSearchForTraffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 478);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CarSearchForTraffic";
            this.Text = "اطلاعات خودرو";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarSearchForTraffic_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CarCardNumber_nvcTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateColorID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryCode_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductionYear_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystemCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
    }
}