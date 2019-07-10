using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.Car
{
    partial class CarEntityForm 

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
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.Active_bit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CarCardDate_nvcLabel = new System.Windows.Forms.Label();
            this.CarCardNumber_nvcLabel = new System.Windows.Forms.Label();
            this.PlateType_nvcLabel = new System.Windows.Forms.Label();
            this.NumberPlate_nvcLabel = new System.Windows.Forms.Label();
            this.SerialPlate_nvcLabel = new System.Windows.Forms.Label();
            this.CountryCode_nvcLabel = new System.Windows.Forms.Label();
            this.YearType_nvcLabel = new System.Windows.Forms.Label();
            this.LaderTypeCode_nvcLabel = new System.Windows.Forms.Label();
            this.SystemCode_nvcLabel = new System.Windows.Forms.Label();
            this.System_nvcLabel = new System.Windows.Forms.Label();
            this.InsertDate_nvcLabel = new System.Windows.Forms.Label();
            this.UpdateDate_nvcLabel = new System.Windows.Forms.Label();
            this.PlateCityID_intLabel = new System.Windows.Forms.Label();
            this.PlateColorID_intLabel = new System.Windows.Forms.Label();
            this.CountryID_intLabel = new System.Windows.Forms.Label();
            this.LaderTypeID_intLabel = new System.Windows.Forms.Label();
            this.InfractionGroupID_intLabel = new System.Windows.Forms.Label();
            this.ProductionYear_intLabel = new System.Windows.Forms.Label();
            this.Capacity_fltLabel = new System.Windows.Forms.Label();
            this.PlateCityID_intNewButton = new System.Windows.Forms.Button();
            this.PlateColorID_intNewButton = new System.Windows.Forms.Button();
            this.CountryID_intNewButton = new System.Windows.Forms.Button();
            this.LaderTypeID_intNewButton = new System.Windows.Forms.Button();
            this.InfractionGroupID_intNewButton = new System.Windows.Forms.Button();
            this.CarCardDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CarCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.PlateType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CountryCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.YearType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LaderTypeCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.SystemCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.System_nvcTextBox = new System.Windows.Forms.TextBox();
            this.InsertDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UpdateDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.PlateCityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.PlateColorID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CountryID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LaderTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.InfractionGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.Deleted_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductionYear_intNumericTextBox = new NumericTextBox();
            this.Capacity_fltNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(470, 13);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.TabIndex = 45;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(470, 48);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndCloseButton.TabIndex = 46;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(470, 84);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DeleteRecordButton.TabIndex = 47;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(470, 120);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CloseFormButton.TabIndex = 48;
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.Active_bit);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.CarCardDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CarCardNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.PlateType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.NumberPlate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.SerialPlate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CountryCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.YearType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LaderTypeCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.SystemCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.System_nvcLabel);
            this.DetailGropBox.Controls.Add(this.InsertDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.UpdateDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.PlateCityID_intLabel);
            this.DetailGropBox.Controls.Add(this.PlateColorID_intLabel);
            this.DetailGropBox.Controls.Add(this.CountryID_intLabel);
            this.DetailGropBox.Controls.Add(this.LaderTypeID_intLabel);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.ProductionYear_intLabel);
            this.DetailGropBox.Controls.Add(this.Capacity_fltLabel);
            this.DetailGropBox.Controls.Add(this.PlateCityID_intNewButton);
            this.DetailGropBox.Controls.Add(this.PlateColorID_intNewButton);
            this.DetailGropBox.Controls.Add(this.CountryID_intNewButton);
            this.DetailGropBox.Controls.Add(this.LaderTypeID_intNewButton);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.CarCardDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CarCardNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.PlateType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.NumberPlate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.SerialPlate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CountryCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.YearType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LaderTypeCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.SystemCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.System_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.InsertDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.UpdateDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.PlateCityID_intComboBox);
            this.DetailGropBox.Controls.Add(this.PlateColorID_intComboBox);
            this.DetailGropBox.Controls.Add(this.CountryID_intComboBox);
            this.DetailGropBox.Controls.Add(this.LaderTypeID_intComboBox);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.Deleted_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.ProductionYear_intNumericTextBox);
            this.DetailGropBox.Controls.Add(this.Capacity_fltNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(449, 633);
            this.DetailGropBox.TabIndex = 1;
            this.DetailGropBox.TabStop = false;
            // 
            // Active_bit
            // 
            this.Active_bit.AutoSize = true;
            this.Active_bit.Checked = true;
            this.Active_bit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Active_bit.Location = new System.Drawing.Point(306, 603);
            this.Active_bit.Name = "Active_bit";
            this.Active_bit.Size = new System.Drawing.Size(15, 14);
            this.Active_bit.TabIndex = 46;
            this.Active_bit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 598);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "فعال";
            // 
            // CarCardDate_nvcLabel
            // 
            this.CarCardDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCardDate_nvcLabel.AutoSize = true;
            this.CarCardDate_nvcLabel.Location = new System.Drawing.Point(334, 59);
            this.CarCardDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarCardDate_nvcLabel.Name = "CarCardDate_nvcLabel";
            this.CarCardDate_nvcLabel.Size = new System.Drawing.Size(98, 23);
            this.CarCardDate_nvcLabel.TabIndex = 0;
            this.CarCardDate_nvcLabel.Text = "تاریخ صدور کارت";
            // 
            // CarCardNumber_nvcLabel
            // 
            this.CarCardNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCardNumber_nvcLabel.AutoSize = true;
            this.CarCardNumber_nvcLabel.Location = new System.Drawing.Point(334, 23);
            this.CarCardNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarCardNumber_nvcLabel.Name = "CarCardNumber_nvcLabel";
            this.CarCardNumber_nvcLabel.Size = new System.Drawing.Size(72, 23);
            this.CarCardNumber_nvcLabel.TabIndex = 2;
            this.CarCardNumber_nvcLabel.Text = "شماره کارت";
            // 
            // PlateType_nvcLabel
            // 
            this.PlateType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateType_nvcLabel.AutoSize = true;
            this.PlateType_nvcLabel.Location = new System.Drawing.Point(334, 521);
            this.PlateType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlateType_nvcLabel.Name = "PlateType_nvcLabel";
            this.PlateType_nvcLabel.Size = new System.Drawing.Size(55, 23);
            this.PlateType_nvcLabel.TabIndex = 4;
            this.PlateType_nvcLabel.Text = "نوع پلاک";
            // 
            // NumberPlate_nvcLabel
            // 
            this.NumberPlate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcLabel.AutoSize = true;
            this.NumberPlate_nvcLabel.Location = new System.Drawing.Point(334, 102);
            this.NumberPlate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumberPlate_nvcLabel.Name = "NumberPlate_nvcLabel";
            this.NumberPlate_nvcLabel.Size = new System.Drawing.Size(70, 23);
            this.NumberPlate_nvcLabel.TabIndex = 6;
            this.NumberPlate_nvcLabel.Text = "شماره پلاک";
            // 
            // SerialPlate_nvcLabel
            // 
            this.SerialPlate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcLabel.AutoSize = true;
            this.SerialPlate_nvcLabel.Location = new System.Drawing.Point(334, 138);
            this.SerialPlate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SerialPlate_nvcLabel.Name = "SerialPlate_nvcLabel";
            this.SerialPlate_nvcLabel.Size = new System.Drawing.Size(66, 23);
            this.SerialPlate_nvcLabel.TabIndex = 8;
            this.SerialPlate_nvcLabel.Text = "سری پلاک";
            // 
            // CountryCode_nvcLabel
            // 
            this.CountryCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCode_nvcLabel.AutoSize = true;
            this.CountryCode_nvcLabel.Location = new System.Drawing.Point(334, 451);
            this.CountryCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CountryCode_nvcLabel.Name = "CountryCode_nvcLabel";
            this.CountryCode_nvcLabel.Size = new System.Drawing.Size(54, 23);
            this.CountryCode_nvcLabel.TabIndex = 19;
            this.CountryCode_nvcLabel.Text = "کد کشور";
            // 
            // YearType_nvcLabel
            // 
            this.YearType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YearType_nvcLabel.AutoSize = true;
            this.YearType_nvcLabel.Location = new System.Drawing.Point(334, 344);
            this.YearType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.YearType_nvcLabel.Name = "YearType_nvcLabel";
            this.YearType_nvcLabel.Size = new System.Drawing.Size(52, 23);
            this.YearType_nvcLabel.TabIndex = 21;
            this.YearType_nvcLabel.Text = "نوع سال";
            // 
            // LaderTypeCode_nvcLabel
            // 
            this.LaderTypeCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeCode_nvcLabel.AutoSize = true;
            this.LaderTypeCode_nvcLabel.Location = new System.Drawing.Point(334, 280);
            this.LaderTypeCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderTypeCode_nvcLabel.Name = "LaderTypeCode_nvcLabel";
            this.LaderTypeCode_nvcLabel.Size = new System.Drawing.Size(75, 23);
            this.LaderTypeCode_nvcLabel.TabIndex = 28;
            this.LaderTypeCode_nvcLabel.Text = "کد نوع بارگیر";
            // 
            // SystemCode_nvcLabel
            // 
            this.SystemCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemCode_nvcLabel.AutoSize = true;
            this.SystemCode_nvcLabel.Location = new System.Drawing.Point(334, 485);
            this.SystemCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SystemCode_nvcLabel.Name = "SystemCode_nvcLabel";
            this.SystemCode_nvcLabel.Size = new System.Drawing.Size(64, 23);
            this.SystemCode_nvcLabel.TabIndex = 30;
            this.SystemCode_nvcLabel.Text = "کد سیستم";
            // 
            // System_nvcLabel
            // 
            this.System_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.System_nvcLabel.AutoSize = true;
            this.System_nvcLabel.Location = new System.Drawing.Point(334, 203);
            this.System_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.System_nvcLabel.Name = "System_nvcLabel";
            this.System_nvcLabel.Size = new System.Drawing.Size(60, 23);
            this.System_nvcLabel.TabIndex = 32;
            this.System_nvcLabel.Text = "نوع وسیله";
            // 
            // InsertDate_nvcLabel
            // 
            this.InsertDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertDate_nvcLabel.AutoSize = true;
            this.InsertDate_nvcLabel.Location = new System.Drawing.Point(270, 816);
            this.InsertDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InsertDate_nvcLabel.Name = "InsertDate_nvcLabel";
            this.InsertDate_nvcLabel.Size = new System.Drawing.Size(109, 23);
            this.InsertDate_nvcLabel.TabIndex = 39;
            this.InsertDate_nvcLabel.Text = "تاريخ ورود اطلاعات";
            // 
            // UpdateDate_nvcLabel
            // 
            this.UpdateDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDate_nvcLabel.AutoSize = true;
            this.UpdateDate_nvcLabel.Location = new System.Drawing.Point(270, 862);
            this.UpdateDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UpdateDate_nvcLabel.Name = "UpdateDate_nvcLabel";
            this.UpdateDate_nvcLabel.Size = new System.Drawing.Size(111, 23);
            this.UpdateDate_nvcLabel.TabIndex = 41;
            this.UpdateDate_nvcLabel.Text = "تاريخ تغيير اطلاعات";
            // 
            // PlateCityID_intLabel
            // 
            this.PlateCityID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityID_intLabel.AutoSize = true;
            this.PlateCityID_intLabel.Location = new System.Drawing.Point(334, 174);
            this.PlateCityID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlateCityID_intLabel.Name = "PlateCityID_intLabel";
            this.PlateCityID_intLabel.Size = new System.Drawing.Size(104, 23);
            this.PlateCityID_intLabel.TabIndex = 10;
            this.PlateCityID_intLabel.Text = "محل شماره گذاری";
            // 
            // PlateColorID_intLabel
            // 
            this.PlateColorID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateColorID_intLabel.AutoSize = true;
            this.PlateColorID_intLabel.Location = new System.Drawing.Point(334, 381);
            this.PlateColorID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlateColorID_intLabel.Name = "PlateColorID_intLabel";
            this.PlateColorID_intLabel.Size = new System.Drawing.Size(60, 23);
            this.PlateColorID_intLabel.TabIndex = 13;
            this.PlateColorID_intLabel.Text = "رنگ پلاک";
            // 
            // CountryID_intLabel
            // 
            this.CountryID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryID_intLabel.AutoSize = true;
            this.CountryID_intLabel.Location = new System.Drawing.Point(334, 417);
            this.CountryID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CountryID_intLabel.Name = "CountryID_intLabel";
            this.CountryID_intLabel.Size = new System.Drawing.Size(76, 23);
            this.CountryID_intLabel.TabIndex = 16;
            this.CountryID_intLabel.Text = "کشور سازنده";
            // 
            // LaderTypeID_intLabel
            // 
            this.LaderTypeID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intLabel.AutoSize = true;
            this.LaderTypeID_intLabel.Location = new System.Drawing.Point(334, 242);
            this.LaderTypeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderTypeID_intLabel.Name = "LaderTypeID_intLabel";
            this.LaderTypeID_intLabel.Size = new System.Drawing.Size(62, 23);
            this.LaderTypeID_intLabel.TabIndex = 25;
            this.LaderTypeID_intLabel.Text = " نوع بارگیر";
            // 
            // InfractionGroupID_intLabel
            // 
            this.InfractionGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroupID_intLabel.AutoSize = true;
            this.InfractionGroupID_intLabel.Location = new System.Drawing.Point(270, 770);
            this.InfractionGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionGroupID_intLabel.Name = "InfractionGroupID_intLabel";
            this.InfractionGroupID_intLabel.Size = new System.Drawing.Size(67, 23);
            this.InfractionGroupID_intLabel.TabIndex = 36;
            this.InfractionGroupID_intLabel.Text = "گروه تخلف";
            // 
            // ProductionYear_intLabel
            // 
            this.ProductionYear_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionYear_intLabel.AutoSize = true;
            this.ProductionYear_intLabel.Location = new System.Drawing.Point(334, 313);
            this.ProductionYear_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductionYear_intLabel.Name = "ProductionYear_intLabel";
            this.ProductionYear_intLabel.Size = new System.Drawing.Size(69, 23);
            this.ProductionYear_intLabel.TabIndex = 23;
            this.ProductionYear_intLabel.Text = "سال ساخت";
            // 
            // Capacity_fltLabel
            // 
            this.Capacity_fltLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Capacity_fltLabel.AutoSize = true;
            this.Capacity_fltLabel.Location = new System.Drawing.Point(334, 559);
            this.Capacity_fltLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Capacity_fltLabel.Name = "Capacity_fltLabel";
            this.Capacity_fltLabel.Size = new System.Drawing.Size(46, 23);
            this.Capacity_fltLabel.TabIndex = 34;
            this.Capacity_fltLabel.Text = "ظرفیت";
            // 
            // PlateCityID_intNewButton
            // 
            this.PlateCityID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.PlateCityID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlateCityID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlateCityID_intNewButton.Location = new System.Drawing.Point(13, 165);
            this.PlateCityID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityID_intNewButton.Name = "PlateCityID_intNewButton";
            this.PlateCityID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.PlateCityID_intNewButton.TabIndex = 12;
            this.PlateCityID_intNewButton.TabStop = false;
            this.PlateCityID_intNewButton.UseVisualStyleBackColor = true;
            this.PlateCityID_intNewButton.Click += new System.EventHandler(this.PlateCityID_intNewButton_Click);
            // 
            // PlateColorID_intNewButton
            // 
            this.PlateColorID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateColorID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.PlateColorID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlateColorID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlateColorID_intNewButton.Location = new System.Drawing.Point(13, 377);
            this.PlateColorID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.PlateColorID_intNewButton.Name = "PlateColorID_intNewButton";
            this.PlateColorID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.PlateColorID_intNewButton.TabIndex = 15;
            this.PlateColorID_intNewButton.TabStop = false;
            this.PlateColorID_intNewButton.UseVisualStyleBackColor = true;
            this.PlateColorID_intNewButton.Click += new System.EventHandler(this.PlateColorID_intNewButton_Click);
            // 
            // CountryID_intNewButton
            // 
            this.CountryID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.CountryID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CountryID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CountryID_intNewButton.Location = new System.Drawing.Point(13, 413);
            this.CountryID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CountryID_intNewButton.Name = "CountryID_intNewButton";
            this.CountryID_intNewButton.Size = new System.Drawing.Size(37, 30);
            this.CountryID_intNewButton.TabIndex = 18;
            this.CountryID_intNewButton.TabStop = false;
            this.CountryID_intNewButton.UseVisualStyleBackColor = true;
            this.CountryID_intNewButton.Click += new System.EventHandler(this.CountryID_intNewButton_Click);
            // 
            // LaderTypeID_intNewButton
            // 
            this.LaderTypeID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.LaderTypeID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderTypeID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderTypeID_intNewButton.Location = new System.Drawing.Point(13, 237);
            this.LaderTypeID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeID_intNewButton.Name = "LaderTypeID_intNewButton";
            this.LaderTypeID_intNewButton.Size = new System.Drawing.Size(37, 32);
            this.LaderTypeID_intNewButton.TabIndex = 27;
            this.LaderTypeID_intNewButton.TabStop = false;
            this.LaderTypeID_intNewButton.UseVisualStyleBackColor = true;
            this.LaderTypeID_intNewButton.Click += new System.EventHandler(this.LaderTypeID_intNewButton_Click);
            // 
            // InfractionGroupID_intNewButton
            // 
            this.InfractionGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.InfractionGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfractionGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfractionGroupID_intNewButton.Location = new System.Drawing.Point(17, 763);
            this.InfractionGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intNewButton.Name = "InfractionGroupID_intNewButton";
            this.InfractionGroupID_intNewButton.Size = new System.Drawing.Size(37, 37);
            this.InfractionGroupID_intNewButton.TabIndex = 38;
            this.InfractionGroupID_intNewButton.TabStop = false;
            this.InfractionGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.InfractionGroupID_intNewButton.Click += new System.EventHandler(this.InfractionGroupID_intNewButton_Click);
            // 
            // CarCardDate_nvcTextBox
            // 
            this.CarCardDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCardDate_nvcTextBox.Location = new System.Drawing.Point(13, 54);
            this.CarCardDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarCardDate_nvcTextBox.MaxLength = 10;
            this.CarCardDate_nvcTextBox.Name = "CarCardDate_nvcTextBox";
            this.CarCardDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardDate_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.CarCardDate_nvcTextBox.TabIndex = 2;
            this.CarCardDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CarCardNumber_nvcTextBox
            // 
            this.CarCardNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCardNumber_nvcTextBox.Location = new System.Drawing.Point(13, 17);
            this.CarCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarCardNumber_nvcTextBox.MaxLength = 10;
            this.CarCardNumber_nvcTextBox.Name = "CarCardNumber_nvcTextBox";
            this.CarCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardNumber_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.CarCardNumber_nvcTextBox.TabIndex = 1;
            this.CarCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CarCardNumber_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CarCardNumber_nvcTextBox_KeyDown);
            // 
            // PlateType_nvcTextBox
            // 
            this.PlateType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateType_nvcTextBox.Location = new System.Drawing.Point(13, 518);
            this.PlateType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateType_nvcTextBox.MaxLength = 50;
            this.PlateType_nvcTextBox.Name = "PlateType_nvcTextBox";
            this.PlateType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlateType_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.PlateType_nvcTextBox.TabIndex = 5;
            this.PlateType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(13, 94);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvcTextBox.MaxLength = 15;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 3;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(13, 129);
            this.SerialPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialPlate_nvcTextBox.MaxLength = 3;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 4;
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CountryCode_nvcTextBox
            // 
            this.CountryCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryCode_nvcTextBox.Location = new System.Drawing.Point(13, 448);
            this.CountryCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CountryCode_nvcTextBox.MaxLength = 10;
            this.CountryCode_nvcTextBox.Name = "CountryCode_nvcTextBox";
            this.CountryCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountryCode_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.CountryCode_nvcTextBox.TabIndex = 20;
            this.CountryCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YearType_nvcTextBox
            // 
            this.YearType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YearType_nvcTextBox.Location = new System.Drawing.Point(13, 341);
            this.YearType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.YearType_nvcTextBox.MaxLength = 50;
            this.YearType_nvcTextBox.Name = "YearType_nvcTextBox";
            this.YearType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YearType_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.YearType_nvcTextBox.TabIndex = 22;
            this.YearType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderTypeCode_nvcTextBox
            // 
            this.LaderTypeCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeCode_nvcTextBox.Location = new System.Drawing.Point(13, 273);
            this.LaderTypeCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeCode_nvcTextBox.MaxLength = 30;
            this.LaderTypeCode_nvcTextBox.Name = "LaderTypeCode_nvcTextBox";
            this.LaderTypeCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderTypeCode_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.LaderTypeCode_nvcTextBox.TabIndex = 29;
            this.LaderTypeCode_nvcTextBox.TabStop = false;
            this.LaderTypeCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SystemCode_nvcTextBox
            // 
            this.SystemCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemCode_nvcTextBox.Location = new System.Drawing.Point(13, 482);
            this.SystemCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SystemCode_nvcTextBox.MaxLength = 50;
            this.SystemCode_nvcTextBox.Name = "SystemCode_nvcTextBox";
            this.SystemCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SystemCode_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.SystemCode_nvcTextBox.TabIndex = 31;
            this.SystemCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // System_nvcTextBox
            // 
            this.System_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.System_nvcTextBox.Location = new System.Drawing.Point(13, 200);
            this.System_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.System_nvcTextBox.MaxLength = 50;
            this.System_nvcTextBox.Name = "System_nvcTextBox";
            this.System_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.System_nvcTextBox.Size = new System.Drawing.Size(311, 30);
            this.System_nvcTextBox.TabIndex = 6;
            this.System_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsertDate_nvcTextBox
            // 
            this.InsertDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertDate_nvcTextBox.Location = new System.Drawing.Point(-201, 810);
            this.InsertDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InsertDate_nvcTextBox.MaxLength = 12;
            this.InsertDate_nvcTextBox.Name = "InsertDate_nvcTextBox";
            this.InsertDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsertDate_nvcTextBox.Size = new System.Drawing.Size(461, 30);
            this.InsertDate_nvcTextBox.TabIndex = 40;
            this.InsertDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UpdateDate_nvcTextBox
            // 
            this.UpdateDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDate_nvcTextBox.Location = new System.Drawing.Point(-201, 856);
            this.UpdateDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateDate_nvcTextBox.MaxLength = 12;
            this.UpdateDate_nvcTextBox.Name = "UpdateDate_nvcTextBox";
            this.UpdateDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateDate_nvcTextBox.Size = new System.Drawing.Size(461, 30);
            this.UpdateDate_nvcTextBox.TabIndex = 42;
            this.UpdateDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlateCityID_intComboBox
            // 
            this.PlateCityID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityID_intComboBox.FormattingEnabled = true;
            this.PlateCityID_intComboBox.Location = new System.Drawing.Point(53, 164);
            this.PlateCityID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityID_intComboBox.Name = "PlateCityID_intComboBox";
            this.PlateCityID_intComboBox.Size = new System.Drawing.Size(271, 31);
            this.PlateCityID_intComboBox.TabIndex = 5;
            // 
            // PlateColorID_intComboBox
            // 
            this.PlateColorID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateColorID_intComboBox.FormattingEnabled = true;
            this.PlateColorID_intComboBox.Location = new System.Drawing.Point(53, 376);
            this.PlateColorID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateColorID_intComboBox.Name = "PlateColorID_intComboBox";
            this.PlateColorID_intComboBox.Size = new System.Drawing.Size(271, 31);
            this.PlateColorID_intComboBox.TabIndex = 8;
            // 
            // CountryID_intComboBox
            // 
            this.CountryID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryID_intComboBox.FormattingEnabled = true;
            this.CountryID_intComboBox.Location = new System.Drawing.Point(53, 412);
            this.CountryID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CountryID_intComboBox.Name = "CountryID_intComboBox";
            this.CountryID_intComboBox.Size = new System.Drawing.Size(271, 31);
            this.CountryID_intComboBox.TabIndex = 17;
            this.CountryID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.CountryID_intComboBox_SelectionChangeCommitted);
            // 
            // LaderTypeID_intComboBox
            // 
            this.LaderTypeID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intComboBox.FormattingEnabled = true;
            this.LaderTypeID_intComboBox.Location = new System.Drawing.Point(53, 237);
            this.LaderTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeID_intComboBox.Name = "LaderTypeID_intComboBox";
            this.LaderTypeID_intComboBox.Size = new System.Drawing.Size(271, 31);
            this.LaderTypeID_intComboBox.TabIndex = 7;
            this.LaderTypeID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.LaderTypeID_intComboBox_SelectionChangeCommitted);
            // 
            // InfractionGroupID_intComboBox
            // 
            this.InfractionGroupID_intComboBox.FormattingEnabled = true;
            this.InfractionGroupID_intComboBox.Location = new System.Drawing.Point(57, 764);
            this.InfractionGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intComboBox.Name = "InfractionGroupID_intComboBox";
            this.InfractionGroupID_intComboBox.Size = new System.Drawing.Size(421, 31);
            this.InfractionGroupID_intComboBox.TabIndex = 37;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Location = new System.Drawing.Point(458, 904);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 43;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // Deleted_bitCheckBox
            // 
            this.Deleted_bitCheckBox.Location = new System.Drawing.Point(458, 945);
            this.Deleted_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Deleted_bitCheckBox.Name = "Deleted_bitCheckBox";
            this.Deleted_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deleted_bitCheckBox.Size = new System.Drawing.Size(133, 30);
            this.Deleted_bitCheckBox.TabIndex = 44;
            this.Deleted_bitCheckBox.Text = "حذف شده";
            this.Deleted_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductionYear_intNumericTextBox
            // 
            this.ProductionYear_intNumericTextBox.AllowNegative = false;
            this.ProductionYear_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductionYear_intNumericTextBox.DigitsInGroup = 0;
            this.ProductionYear_intNumericTextBox.Flags = 65536;
            this.ProductionYear_intNumericTextBox.Location = new System.Drawing.Point(13, 306);
            this.ProductionYear_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProductionYear_intNumericTextBox.MaxDecimalPlaces = 0;
            this.ProductionYear_intNumericTextBox.MaxWholeDigits = 155;
            this.ProductionYear_intNumericTextBox.Name = "ProductionYear_intNumericTextBox";
            this.ProductionYear_intNumericTextBox.Prefix = "";
            //this.ProductionYear_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.ProductionYear_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.ProductionYear_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductionYear_intNumericTextBox.Size = new System.Drawing.Size(311, 30);
            this.ProductionYear_intNumericTextBox.TabIndex = 8;
            // 
            // Capacity_fltNumericTextBox
            // 
            this.Capacity_fltNumericTextBox.AllowNegative = false;
            this.Capacity_fltNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Capacity_fltNumericTextBox.DigitsInGroup = 0;
            this.Capacity_fltNumericTextBox.Flags = 65536;
            this.Capacity_fltNumericTextBox.Location = new System.Drawing.Point(13, 552);
            this.Capacity_fltNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Capacity_fltNumericTextBox.MaxDecimalPlaces = 0;
            this.Capacity_fltNumericTextBox.MaxWholeDigits = 155;
            this.Capacity_fltNumericTextBox.Name = "Capacity_fltNumericTextBox";
            this.Capacity_fltNumericTextBox.Prefix = "";
           // this.Capacity_fltNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.Capacity_fltNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.Capacity_fltNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Capacity_fltNumericTextBox.Size = new System.Drawing.Size(311, 30);
            this.Capacity_fltNumericTextBox.TabIndex = 35;
            this.Capacity_fltNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CarEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 649);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "CarEntityForm";
            this.Load += new System.EventHandler(this.CarEntityForm_Load);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label CarCardDate_nvcLabel;
private System.Windows.Forms.Label CarCardNumber_nvcLabel;
private System.Windows.Forms.Label PlateType_nvcLabel;
private System.Windows.Forms.Label NumberPlate_nvcLabel;
private System.Windows.Forms.Label SerialPlate_nvcLabel;
private System.Windows.Forms.Label CountryCode_nvcLabel;
private System.Windows.Forms.Label YearType_nvcLabel;
private System.Windows.Forms.Label LaderTypeCode_nvcLabel;
private System.Windows.Forms.Label SystemCode_nvcLabel;
private System.Windows.Forms.Label System_nvcLabel;
private System.Windows.Forms.Label InsertDate_nvcLabel;
private System.Windows.Forms.Label UpdateDate_nvcLabel;
        
private System.Windows.Forms.TextBox CarCardDate_nvcTextBox;
private System.Windows.Forms.TextBox CarCardNumber_nvcTextBox;
private System.Windows.Forms.TextBox PlateType_nvcTextBox;
private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
private System.Windows.Forms.TextBox CountryCode_nvcTextBox;
private System.Windows.Forms.TextBox YearType_nvcTextBox;
private System.Windows.Forms.TextBox LaderTypeCode_nvcTextBox;
private System.Windows.Forms.TextBox SystemCode_nvcTextBox;
private System.Windows.Forms.TextBox System_nvcTextBox;
private System.Windows.Forms.TextBox InsertDate_nvcTextBox;
private System.Windows.Forms.TextBox UpdateDate_nvcTextBox;
        
private System.Windows.Forms.Label PlateCityID_intLabel;
private System.Windows.Forms.Label PlateColorID_intLabel;
private System.Windows.Forms.Label CountryID_intLabel;
private System.Windows.Forms.Label LaderTypeID_intLabel;
private System.Windows.Forms.Label InfractionGroupID_intLabel;
       
private System.Windows.Forms.ComboBox PlateCityID_intComboBox;
private System.Windows.Forms.ComboBox PlateColorID_intComboBox;
private System.Windows.Forms.ComboBox CountryID_intComboBox;
private System.Windows.Forms.ComboBox LaderTypeID_intComboBox;
private System.Windows.Forms.ComboBox InfractionGroupID_intComboBox;
        
private System.Windows.Forms.Button PlateCityID_intNewButton;
private System.Windows.Forms.Button PlateColorID_intNewButton;
private System.Windows.Forms.Button CountryID_intNewButton;
private System.Windows.Forms.Button LaderTypeID_intNewButton;
private System.Windows.Forms.Button InfractionGroupID_intNewButton;
       
private System.Windows.Forms.Label ProductionYear_intLabel;
private System.Windows.Forms.Label Capacity_fltLabel;
        
private NumericTextBox ProductionYear_intNumericTextBox;
private NumericTextBox Capacity_fltNumericTextBox;
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
private System.Windows.Forms.CheckBox Deleted_bitCheckBox;
private System.Windows.Forms.CheckBox Active_bit;
private System.Windows.Forms.Label label1;
    }
}
