using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    partial class DriverSearchForTraffic
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
            this.DriverCardNumber_bintNumericTextBox = new NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NationalCode_intNumericTextBox = new NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverCardNumber_bintNumericTextBox
            // 
            this.DriverCardNumber_bintNumericTextBox.AllowNegative = false;
            this.DriverCardNumber_bintNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_bintNumericTextBox.DigitsInGroup = 0;
            this.DriverCardNumber_bintNumericTextBox.Flags = 65536;
            this.DriverCardNumber_bintNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverCardNumber_bintNumericTextBox.Location = new System.Drawing.Point(566, 32);
            this.DriverCardNumber_bintNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardNumber_bintNumericTextBox.MaxDecimalPlaces = 0;
            this.DriverCardNumber_bintNumericTextBox.MaxLength = 7;
            this.DriverCardNumber_bintNumericTextBox.MaxWholeDigits = 155;
            this.DriverCardNumber_bintNumericTextBox.Name = "DriverCardNumber_bintNumericTextBox";
            this.DriverCardNumber_bintNumericTextBox.Prefix = "";
          //  this.DriverCardNumber_bintNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.DriverCardNumber_bintNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.DriverCardNumber_bintNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_bintNumericTextBox.Size = new System.Drawing.Size(296, 30);
            this.DriverCardNumber_bintNumericTextBox.TabIndex = 0;
            this.DriverCardNumber_bintNumericTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DriverCardNumber_bintNumericTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(873, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره كارت هوشمند";
            // 
            // DocNumber_nvcTextBox
            // 
            this.DocNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocNumber_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DocNumber_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DocNumber_nvcTextBox.Location = new System.Drawing.Point(168, 32);
            this.DocNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DocNumber_nvcTextBox.MaxLength = 50;
            this.DocNumber_nvcTextBox.Name = "DocNumber_nvcTextBox";
            this.DocNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DocNumber_nvcTextBox.Size = new System.Drawing.Size(296, 30);
            this.DocNumber_nvcTextBox.TabIndex = 2;
            this.DocNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DocNumber_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocNumber_nvcTextBox_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(473, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "شماره پرونده";
            // 
            // LastName_nvcTextBox
            // 
            this.LastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LastName_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastName_nvcTextBox.Location = new System.Drawing.Point(168, 72);
            this.LastName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastName_nvcTextBox.MaxLength = 50;
            this.LastName_nvcTextBox.Name = "LastName_nvcTextBox";
            this.LastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_nvcTextBox.Size = new System.Drawing.Size(296, 30);
            this.LastName_nvcTextBox.TabIndex = 3;
            this.LastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LastName_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LastName_nvcTextBox_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(473, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "نام خانوادگي";
            // 
            // NationalCode_intNumericTextBox
            // 
            this.NationalCode_intNumericTextBox.AllowNegative = false;
            this.NationalCode_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCode_intNumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NationalCode_intNumericTextBox.DigitsInGroup = 0;
            this.NationalCode_intNumericTextBox.Flags = 65536;
            this.NationalCode_intNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NationalCode_intNumericTextBox.Location = new System.Drawing.Point(566, 72);
            this.NationalCode_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NationalCode_intNumericTextBox.MaxDecimalPlaces = 0;
            this.NationalCode_intNumericTextBox.MaxLength = 10;
            this.NationalCode_intNumericTextBox.MaxWholeDigits = 155;
            this.NationalCode_intNumericTextBox.Name = "NationalCode_intNumericTextBox";
            this.NationalCode_intNumericTextBox.Prefix = "";
          //  this.NationalCode_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.NationalCode_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.NationalCode_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NationalCode_intNumericTextBox.Size = new System.Drawing.Size(296, 30);
            this.NationalCode_intNumericTextBox.TabIndex = 1;
            this.NationalCode_intNumericTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NationalCode_intNumericTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(873, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "كد ملي";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.NationalCode_intNumericTextBox);
            this.groupBox1.Controls.Add(this.DocNumber_nvcTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LastName_nvcTextBox);
            this.groupBox1.Controls.Add(this.DriverCardNumber_bintNumericTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(998, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(36, 32);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(115, 31);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "انصراف";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(36, 72);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 31);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "جستجو (Alt+F3)";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.DriverGridView.Location = new System.Drawing.Point(0, 123);
            this.DriverGridView.Margin = new System.Windows.Forms.Padding(5);
            this.DriverGridView.MultiSelect = false;
            this.DriverGridView.Name = "DriverGridView";
            this.DriverGridView.ReadOnly = true;
            this.DriverGridView.RowHeadersVisible = false;
            this.DriverGridView.Size = new System.Drawing.Size(998, 353);
            this.DriverGridView.TabIndex = 19;
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
            // DriverSearchForTraffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 476);
            this.Controls.Add(this.DriverGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "DriverSearchForTraffic";
            this.Text = "اطلاعات راننده";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DriverSearchForTraffic_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericTextBox DriverCardNumber_bintNumericTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocNumber_nvcTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastName_nvcTextBox;
        private System.Windows.Forms.Label label8;
        private NumericTextBox NationalCode_intNumericTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DriverGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseButton;
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