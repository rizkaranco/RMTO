namespace HPS.Present.Car
    {
    partial class CarListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionYear_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity_flt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsertDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateColorID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystemCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDeleted_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CarToolStrip = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlateSerialTextBox = new System.Windows.Forms.TextBox();
            this.PlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.CarCardNumebrTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.CarToolStrip.SuspendLayout();
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
            // CarGridView
            // 
            this.CarGridView.AllowUserToAddRows = false;
            this.CarGridView.AllowUserToDeleteRows = false;
            this.CarGridView.AllowUserToResizeRows = false;
            this.CarGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarID_int,
            this.colCarCardNumber_nvc,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colPlateCityID_int,
            this.colCountryID_int,
            this.colProductionYear_int,
            this.colYearType_nvc,
            this.colSystem_nvc,
            this.colCapacity_flt,
            this.colInsertDate_nvc,
            this.colUpdateDate_nvc,
            this.colPlateType_nvc,
            this.colCarCardDate_nvc,
            this.colPlateColorID_int,
            this.colCountryCode_nvc,
            this.colCountry_nvc,
            this.colLaderTypeID_int,
            this.colLaderTypeCode_nvc,
            this.colSystemCode_nvc,
            this.colInfractionGroupID_int,
            this.colActive_bit,
            this.colDeleted_bit});
            this.CarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarGridView.Location = new System.Drawing.Point(0, 92);
            this.CarGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowHeadersVisible = false;
            this.CarGridView.Size = new System.Drawing.Size(775, 393);
            this.CarGridView.TabIndex = 0;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه خودرو";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // colCarCardNumber_nvc
            // 
            this.colCarCardNumber_nvc.DataPropertyName = "CarCardNumber_nvc";
            this.colCarCardNumber_nvc.HeaderText = "شماره کارت";
            this.colCarCardNumber_nvc.Name = "colCarCardNumber_nvc";
            this.colCarCardNumber_nvc.ReadOnly = true;
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
            // colPlateCityID_int
            // 
            this.colPlateCityID_int.DataPropertyName = "PlateCityID_intPlateCity_nvc";
            this.colPlateCityID_int.HeaderText = "محل شماره گذاری";
            this.colPlateCityID_int.Name = "colPlateCityID_int";
            this.colPlateCityID_int.ReadOnly = true;
            this.colPlateCityID_int.Width = 150;
            // 
            // colCountryID_int
            // 
            this.colCountryID_int.DataPropertyName = "CountryID_intCountry_nvc";
            this.colCountryID_int.HeaderText = "کشور سازنده";
            this.colCountryID_int.Name = "colCountryID_int";
            this.colCountryID_int.ReadOnly = true;
            this.colCountryID_int.Width = 120;
            // 
            // colProductionYear_int
            // 
            this.colProductionYear_int.DataPropertyName = "ProductionYear_int";
            this.colProductionYear_int.HeaderText = "سال ساخت";
            this.colProductionYear_int.Name = "colProductionYear_int";
            this.colProductionYear_int.ReadOnly = true;
            // 
            // colYearType_nvc
            // 
            this.colYearType_nvc.DataPropertyName = "YearType_nvc";
            this.colYearType_nvc.HeaderText = "نوع سال";
            this.colYearType_nvc.Name = "colYearType_nvc";
            this.colYearType_nvc.ReadOnly = true;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نام سیستم";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            // 
            // colCapacity_flt
            // 
            this.colCapacity_flt.DataPropertyName = "Capacity_flt";
            this.colCapacity_flt.HeaderText = "ظرفیت";
            this.colCapacity_flt.Name = "colCapacity_flt";
            this.colCapacity_flt.ReadOnly = true;
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
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            this.colPlateType_nvc.Visible = false;
            // 
            // colCarCardDate_nvc
            // 
            this.colCarCardDate_nvc.DataPropertyName = "CarCardDate_nvc";
            this.colCarCardDate_nvc.HeaderText = "تاریخ صدور کارت";
            this.colCarCardDate_nvc.Name = "colCarCardDate_nvc";
            this.colCarCardDate_nvc.ReadOnly = true;
            this.colCarCardDate_nvc.Visible = false;
            // 
            // colPlateColorID_int
            // 
            this.colPlateColorID_int.DataPropertyName = "PlateColorID_intColor_nvc";
            this.colPlateColorID_int.HeaderText = "رنگ پلاک";
            this.colPlateColorID_int.Name = "colPlateColorID_int";
            this.colPlateColorID_int.ReadOnly = true;
            this.colPlateColorID_int.Visible = false;
            // 
            // colCountryCode_nvc
            // 
            this.colCountryCode_nvc.DataPropertyName = "CountryCode_nvc";
            this.colCountryCode_nvc.HeaderText = "کد کشور";
            this.colCountryCode_nvc.Name = "colCountryCode_nvc";
            this.colCountryCode_nvc.ReadOnly = true;
            this.colCountryCode_nvc.Visible = false;
            // 
            // colCountry_nvc
            // 
            this.colCountry_nvc.DataPropertyName = "Country_nvc";
            this.colCountry_nvc.HeaderText = "نام کشور سازنده";
            this.colCountry_nvc.Name = "colCountry_nvc";
            this.colCountry_nvc.ReadOnly = true;
            this.colCountry_nvc.Visible = false;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderTypeID_int.HeaderText = " نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colLaderTypeCode_nvc
            // 
            this.colLaderTypeCode_nvc.DataPropertyName = "LaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.HeaderText = "کد نوع بارگیر";
            this.colLaderTypeCode_nvc.Name = "colLaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.ReadOnly = true;
            this.colLaderTypeCode_nvc.Visible = false;
            // 
            // colSystemCode_nvc
            // 
            this.colSystemCode_nvc.DataPropertyName = "SystemCode_nvc";
            this.colSystemCode_nvc.HeaderText = "کد سیستم";
            this.colSystemCode_nvc.Name = "colSystemCode_nvc";
            this.colSystemCode_nvc.ReadOnly = true;
            this.colSystemCode_nvc.Visible = false;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            // 
            // colDeleted_bit
            // 
            this.colDeleted_bit.DataPropertyName = "Deleted_bit";
            this.colDeleted_bit.HeaderText = "حذف شده";
            this.colDeleted_bit.Name = "colDeleted_bit";
            this.colDeleted_bit.ReadOnly = true;
            // 
            // CarToolStrip
            // 
            this.CarToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.CarToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CarToolStrip.Name = "CarToolStrip";
            this.CarToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CarToolStrip.Size = new System.Drawing.Size(775, 31);
            this.CarToolStrip.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PlateSerialTextBox);
            this.groupBox1.Controls.Add(this.PlateNumberTextBox);
            this.groupBox1.Controls.Add(this.CarCardNumebrTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(56, 19);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(128, 30);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "جستجو";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "شماره کارت هوشمند";
            // 
            // PlateSerialTextBox
            // 
            this.PlateSerialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateSerialTextBox.Location = new System.Drawing.Point(276, 16);
            this.PlateSerialTextBox.Name = "PlateSerialTextBox";
            this.PlateSerialTextBox.Size = new System.Drawing.Size(34, 30);
            this.PlateSerialTextBox.TabIndex = 2;
            // 
            // PlateNumberTextBox
            // 
            this.PlateNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateNumberTextBox.Location = new System.Drawing.Point(316, 16);
            this.PlateNumberTextBox.Name = "PlateNumberTextBox";
            this.PlateNumberTextBox.Size = new System.Drawing.Size(88, 30);
            this.PlateNumberTextBox.TabIndex = 1;
            // 
            // CarCardNumebrTextBox
            // 
            this.CarCardNumebrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCardNumebrTextBox.Location = new System.Drawing.Point(524, 16);
            this.CarCardNumebrTextBox.Name = "CarCardNumebrTextBox";
            this.CarCardNumebrTextBox.Size = new System.Drawing.Size(128, 30);
            this.CarCardNumebrTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "شماره پلاک";
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(775, 485);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CarToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CarListForm";
            this.Text = "لیست کامیون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.CarToolStrip.ResumeLayout(false);
            this.CarToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CarToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductionYear_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity_flt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsertDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateColorID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystemCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDeleted_bit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlateSerialTextBox;
        private System.Windows.Forms.TextBox PlateNumberTextBox;
        private System.Windows.Forms.TextBox CarCardNumebrTextBox;
    }

}