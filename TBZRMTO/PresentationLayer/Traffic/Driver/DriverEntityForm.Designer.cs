using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.Driver
{
    partial class DriverEntityForm 

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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mobile_nvctextBox = new System.Windows.Forms.TextBox();
            this.DriverCardDate_nvcLabel = new System.Windows.Forms.Label();
            this.DriverCardNumber_nvcLabel = new System.Windows.Forms.Label();
            this.DriverType_nvcLabel = new System.Windows.Forms.Label();
            this.FirstName_nvcLabel = new System.Windows.Forms.Label();
            this.LastName_nvcLabel = new System.Windows.Forms.Label();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.InsuranceNumber_nvcLabel = new System.Windows.Forms.Label();
            this.CityCode_nvcLabel = new System.Windows.Forms.Label();
            this.licenceNumber_nvcLabel = new System.Windows.Forms.Label();
            this.LicenceType_nvcLabel = new System.Windows.Forms.Label();
            this.LiceniceDate_nvcLabel = new System.Windows.Forms.Label();
            this.ActivityScope_nvcLabel = new System.Windows.Forms.Label();
            this.DocNumber_nvcLabel = new System.Windows.Forms.Label();
            this.InsertDate_nvcLabel = new System.Windows.Forms.Label();
            this.UpdateDate_nvcLabel = new System.Windows.Forms.Label();
            this.CityID_intLabel = new System.Windows.Forms.Label();
            this.LicenceCityID_intLabel = new System.Windows.Forms.Label();
            this.InfractionGroupID_intLabel = new System.Windows.Forms.Label();
            this.NationalCode_intLabel = new System.Windows.Forms.Label();
            this.CityID_intNewButton = new System.Windows.Forms.Button();
            this.LicenceCityID_intNewButton = new System.Windows.Forms.Button();
            this.InfractionGroupID_intNewButton = new System.Windows.Forms.Button();
            this.DriverCardDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DriverCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DriverType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.InsuranceNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.licenceNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LicenceType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LiceniceDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.ActivityScope_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DocNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.InsertDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UpdateDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LicenceCityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.InfractionGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.Deleted_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.NationalCode_intNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(493, 14);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(493, 46);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(493, 78);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(493, 112);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.Active_bit);
            this.DetailGropBox.Controls.Add(this.label2);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.Mobile_nvctextBox);
            this.DetailGropBox.Controls.Add(this.DriverCardDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DriverCardNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DriverType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.FirstName_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LastName_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.InsuranceNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CityCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.licenceNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LicenceType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LiceniceDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.ActivityScope_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DocNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.InsertDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.UpdateDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CityID_intLabel);
            this.DetailGropBox.Controls.Add(this.LicenceCityID_intLabel);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.NationalCode_intLabel);
            this.DetailGropBox.Controls.Add(this.CityID_intNewButton);
            this.DetailGropBox.Controls.Add(this.LicenceCityID_intNewButton);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.DriverCardDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.DriverCardNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.DriverType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.FirstName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LastName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.InsuranceNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CityCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.licenceNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LicenceType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LiceniceDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.ActivityScope_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.DocNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.InsertDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.UpdateDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CityID_intComboBox);
            this.DetailGropBox.Controls.Add(this.LicenceCityID_intComboBox);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.Deleted_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.NationalCode_intNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(460, 647);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // Active_bit
            // 
            this.Active_bit.AutoSize = true;
            this.Active_bit.Location = new System.Drawing.Point(315, 616);
            this.Active_bit.Name = "Active_bit";
            this.Active_bit.Size = new System.Drawing.Size(15, 14);
            this.Active_bit.TabIndex = 43;
            this.Active_bit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 611);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "فعال";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 577);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "شماره موبایل";
            // 
            // Mobile_nvctextBox
            // 
            this.Mobile_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mobile_nvctextBox.Location = new System.Drawing.Point(15, 575);
            this.Mobile_nvctextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Mobile_nvctextBox.MaxLength = 20;
            this.Mobile_nvctextBox.Name = "Mobile_nvctextBox";
            this.Mobile_nvctextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mobile_nvctextBox.Size = new System.Drawing.Size(314, 30);
            this.Mobile_nvctextBox.TabIndex = 41;
            this.Mobile_nvctextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverCardDate_nvcLabel
            // 
            this.DriverCardDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardDate_nvcLabel.AutoSize = true;
            this.DriverCardDate_nvcLabel.Location = new System.Drawing.Point(341, 32);
            this.DriverCardDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardDate_nvcLabel.Name = "DriverCardDate_nvcLabel";
            this.DriverCardDate_nvcLabel.Size = new System.Drawing.Size(98, 23);
            this.DriverCardDate_nvcLabel.TabIndex = 0;
            this.DriverCardDate_nvcLabel.Text = "تاریخ صدور کارت";
            // 
            // DriverCardNumber_nvcLabel
            // 
            this.DriverCardNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_nvcLabel.AutoSize = true;
            this.DriverCardNumber_nvcLabel.Location = new System.Drawing.Point(341, 66);
            this.DriverCardNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardNumber_nvcLabel.Name = "DriverCardNumber_nvcLabel";
            this.DriverCardNumber_nvcLabel.Size = new System.Drawing.Size(103, 23);
            this.DriverCardNumber_nvcLabel.TabIndex = 1;
            this.DriverCardNumber_nvcLabel.Text = "شماره کارت راننده";
            // 
            // DriverType_nvcLabel
            // 
            this.DriverType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverType_nvcLabel.AutoSize = true;
            this.DriverType_nvcLabel.Location = new System.Drawing.Point(341, 100);
            this.DriverType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverType_nvcLabel.Name = "DriverType_nvcLabel";
            this.DriverType_nvcLabel.Size = new System.Drawing.Size(58, 23);
            this.DriverType_nvcLabel.TabIndex = 2;
            this.DriverType_nvcLabel.Text = "نوع راننده";
            // 
            // FirstName_nvcLabel
            // 
            this.FirstName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcLabel.AutoSize = true;
            this.FirstName_nvcLabel.Location = new System.Drawing.Point(341, 134);
            this.FirstName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstName_nvcLabel.Name = "FirstName_nvcLabel";
            this.FirstName_nvcLabel.Size = new System.Drawing.Size(25, 23);
            this.FirstName_nvcLabel.TabIndex = 3;
            this.FirstName_nvcLabel.Text = "نام";
            // 
            // LastName_nvcLabel
            // 
            this.LastName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcLabel.AutoSize = true;
            this.LastName_nvcLabel.Location = new System.Drawing.Point(341, 168);
            this.LastName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LastName_nvcLabel.Name = "LastName_nvcLabel";
            this.LastName_nvcLabel.Size = new System.Drawing.Size(74, 23);
            this.LastName_nvcLabel.TabIndex = 4;
            this.LastName_nvcLabel.Text = "نام خانوادگی";
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Location = new System.Drawing.Point(442, 858);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 38;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // InsuranceNumber_nvcLabel
            // 
            this.InsuranceNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsuranceNumber_nvcLabel.AutoSize = true;
            this.InsuranceNumber_nvcLabel.Location = new System.Drawing.Point(341, 202);
            this.InsuranceNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InsuranceNumber_nvcLabel.Name = "InsuranceNumber_nvcLabel";
            this.InsuranceNumber_nvcLabel.Size = new System.Drawing.Size(66, 23);
            this.InsuranceNumber_nvcLabel.TabIndex = 5;
            this.InsuranceNumber_nvcLabel.Text = "شماره بیمه";
            // 
            // CityCode_nvcLabel
            // 
            this.CityCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCode_nvcLabel.AutoSize = true;
            this.CityCode_nvcLabel.Location = new System.Drawing.Point(341, 270);
            this.CityCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityCode_nvcLabel.Name = "CityCode_nvcLabel";
            this.CityCode_nvcLabel.Size = new System.Drawing.Size(118, 23);
            this.CityCode_nvcLabel.TabIndex = 6;
            this.CityCode_nvcLabel.Text = "کد شهر محل سکونت";
            // 
            // licenceNumber_nvcLabel
            // 
            this.licenceNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenceNumber_nvcLabel.AutoSize = true;
            this.licenceNumber_nvcLabel.Location = new System.Drawing.Point(341, 304);
            this.licenceNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.licenceNumber_nvcLabel.Name = "licenceNumber_nvcLabel";
            this.licenceNumber_nvcLabel.Size = new System.Drawing.Size(90, 23);
            this.licenceNumber_nvcLabel.TabIndex = 7;
            this.licenceNumber_nvcLabel.Text = "شماره گواهینامه";
            // 
            // LicenceType_nvcLabel
            // 
            this.LicenceType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceType_nvcLabel.AutoSize = true;
            this.LicenceType_nvcLabel.Location = new System.Drawing.Point(341, 372);
            this.LicenceType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LicenceType_nvcLabel.Name = "LicenceType_nvcLabel";
            this.LicenceType_nvcLabel.Size = new System.Drawing.Size(75, 23);
            this.LicenceType_nvcLabel.TabIndex = 8;
            this.LicenceType_nvcLabel.Text = "نوع گواهینامه";
            // 
            // LiceniceDate_nvcLabel
            // 
            this.LiceniceDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LiceniceDate_nvcLabel.AutoSize = true;
            this.LiceniceDate_nvcLabel.Location = new System.Drawing.Point(341, 406);
            this.LiceniceDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LiceniceDate_nvcLabel.Name = "LiceniceDate_nvcLabel";
            this.LiceniceDate_nvcLabel.Size = new System.Drawing.Size(116, 23);
            this.LiceniceDate_nvcLabel.TabIndex = 9;
            this.LiceniceDate_nvcLabel.Text = "تاریخ صدور گواهینامه";
            // 
            // ActivityScope_nvcLabel
            // 
            this.ActivityScope_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivityScope_nvcLabel.AutoSize = true;
            this.ActivityScope_nvcLabel.Location = new System.Drawing.Point(341, 440);
            this.ActivityScope_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ActivityScope_nvcLabel.Name = "ActivityScope_nvcLabel";
            this.ActivityScope_nvcLabel.Size = new System.Drawing.Size(72, 23);
            this.ActivityScope_nvcLabel.TabIndex = 10;
            this.ActivityScope_nvcLabel.Text = "حوزه فعالیت";
            // 
            // DocNumber_nvcLabel
            // 
            this.DocNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocNumber_nvcLabel.AutoSize = true;
            this.DocNumber_nvcLabel.Location = new System.Drawing.Point(341, 542);
            this.DocNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DocNumber_nvcLabel.Name = "DocNumber_nvcLabel";
            this.DocNumber_nvcLabel.Size = new System.Drawing.Size(78, 23);
            this.DocNumber_nvcLabel.TabIndex = 11;
            this.DocNumber_nvcLabel.Text = "شماره پرونده";
            // 
            // InsertDate_nvcLabel
            // 
            this.InsertDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertDate_nvcLabel.AutoSize = true;
            this.InsertDate_nvcLabel.Location = new System.Drawing.Point(263, 770);
            this.InsertDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InsertDate_nvcLabel.Name = "InsertDate_nvcLabel";
            this.InsertDate_nvcLabel.Size = new System.Drawing.Size(109, 23);
            this.InsertDate_nvcLabel.TabIndex = 12;
            this.InsertDate_nvcLabel.Text = "تاريخ ورود اطلاعات";
            // 
            // UpdateDate_nvcLabel
            // 
            this.UpdateDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDate_nvcLabel.AutoSize = true;
            this.UpdateDate_nvcLabel.Location = new System.Drawing.Point(263, 816);
            this.UpdateDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UpdateDate_nvcLabel.Name = "UpdateDate_nvcLabel";
            this.UpdateDate_nvcLabel.Size = new System.Drawing.Size(111, 23);
            this.UpdateDate_nvcLabel.TabIndex = 13;
            this.UpdateDate_nvcLabel.Text = "تاريخ تغيير اطلاعات";
            // 
            // CityID_intLabel
            // 
            this.CityID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intLabel.AutoSize = true;
            this.CityID_intLabel.Location = new System.Drawing.Point(341, 236);
            this.CityID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityID_intLabel.Name = "CityID_intLabel";
            this.CityID_intLabel.Size = new System.Drawing.Size(102, 23);
            this.CityID_intLabel.TabIndex = 14;
            this.CityID_intLabel.Text = "شهر محل سکونت";
            // 
            // LicenceCityID_intLabel
            // 
            this.LicenceCityID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceCityID_intLabel.AutoSize = true;
            this.LicenceCityID_intLabel.Location = new System.Drawing.Point(341, 338);
            this.LicenceCityID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LicenceCityID_intLabel.Name = "LicenceCityID_intLabel";
            this.LicenceCityID_intLabel.Size = new System.Drawing.Size(113, 23);
            this.LicenceCityID_intLabel.TabIndex = 15;
            this.LicenceCityID_intLabel.Text = "محل صدور گواهینامه";
            // 
            // InfractionGroupID_intLabel
            // 
            this.InfractionGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroupID_intLabel.AutoSize = true;
            this.InfractionGroupID_intLabel.Location = new System.Drawing.Point(341, 508);
            this.InfractionGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionGroupID_intLabel.Name = "InfractionGroupID_intLabel";
            this.InfractionGroupID_intLabel.Size = new System.Drawing.Size(67, 23);
            this.InfractionGroupID_intLabel.TabIndex = 16;
            this.InfractionGroupID_intLabel.Text = "گروه تخلف";
            // 
            // NationalCode_intLabel
            // 
            this.NationalCode_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCode_intLabel.AutoSize = true;
            this.NationalCode_intLabel.Location = new System.Drawing.Point(341, 474);
            this.NationalCode_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NationalCode_intLabel.Name = "NationalCode_intLabel";
            this.NationalCode_intLabel.Size = new System.Drawing.Size(44, 23);
            this.NationalCode_intLabel.TabIndex = 17;
            this.NationalCode_intLabel.Text = "کد ملی";
            // 
            // CityID_intNewButton
            // 
            this.CityID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.CityID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CityID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CityID_intNewButton.Location = new System.Drawing.Point(15, 230);
            this.CityID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CityID_intNewButton.Name = "CityID_intNewButton";
            this.CityID_intNewButton.Size = new System.Drawing.Size(37, 30);
            this.CityID_intNewButton.TabIndex = 18;
            this.CityID_intNewButton.TabStop = false;
            this.CityID_intNewButton.UseVisualStyleBackColor = true;
            this.CityID_intNewButton.Click += new System.EventHandler(this.CityID_intNewButton_Click);
            // 
            // LicenceCityID_intNewButton
            // 
            this.LicenceCityID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceCityID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.LicenceCityID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LicenceCityID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LicenceCityID_intNewButton.Location = new System.Drawing.Point(15, 334);
            this.LicenceCityID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LicenceCityID_intNewButton.Name = "LicenceCityID_intNewButton";
            this.LicenceCityID_intNewButton.Size = new System.Drawing.Size(37, 30);
            this.LicenceCityID_intNewButton.TabIndex = 19;
            this.LicenceCityID_intNewButton.TabStop = false;
            this.LicenceCityID_intNewButton.UseVisualStyleBackColor = true;
            this.LicenceCityID_intNewButton.Click += new System.EventHandler(this.LicenceCityID_intNewButton_Click);
            // 
            // InfractionGroupID_intNewButton
            // 
            this.InfractionGroupID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.InfractionGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfractionGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfractionGroupID_intNewButton.Location = new System.Drawing.Point(15, 505);
            this.InfractionGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intNewButton.Name = "InfractionGroupID_intNewButton";
            this.InfractionGroupID_intNewButton.Size = new System.Drawing.Size(37, 30);
            this.InfractionGroupID_intNewButton.TabIndex = 20;
            this.InfractionGroupID_intNewButton.TabStop = false;
            this.InfractionGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.InfractionGroupID_intNewButton.Click += new System.EventHandler(this.InfractionGroupID_intNewButton_Click);
            // 
            // DriverCardDate_nvcTextBox
            // 
            this.DriverCardDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardDate_nvcTextBox.Location = new System.Drawing.Point(15, 27);
            this.DriverCardDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardDate_nvcTextBox.MaxLength = 10;
            this.DriverCardDate_nvcTextBox.Name = "DriverCardDate_nvcTextBox";
            this.DriverCardDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardDate_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.DriverCardDate_nvcTextBox.TabIndex = 0;
            this.DriverCardDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverCardNumber_nvcTextBox
            // 
            this.DriverCardNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_nvcTextBox.Location = new System.Drawing.Point(15, 61);
            this.DriverCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardNumber_nvcTextBox.MaxLength = 10;
            this.DriverCardNumber_nvcTextBox.Name = "DriverCardNumber_nvcTextBox";
            this.DriverCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.DriverCardNumber_nvcTextBox.TabIndex = 1;
            this.DriverCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverType_nvcTextBox
            // 
            this.DriverType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverType_nvcTextBox.Location = new System.Drawing.Point(15, 95);
            this.DriverType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverType_nvcTextBox.MaxLength = 50;
            this.DriverType_nvcTextBox.Name = "DriverType_nvcTextBox";
            this.DriverType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverType_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.DriverType_nvcTextBox.TabIndex = 2;
            this.DriverType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstName_nvcTextBox
            // 
            this.FirstName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcTextBox.Location = new System.Drawing.Point(15, 129);
            this.FirstName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FirstName_nvcTextBox.MaxLength = 50;
            this.FirstName_nvcTextBox.Name = "FirstName_nvcTextBox";
            this.FirstName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstName_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.FirstName_nvcTextBox.TabIndex = 3;
            this.FirstName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LastName_nvcTextBox
            // 
            this.LastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcTextBox.Location = new System.Drawing.Point(15, 163);
            this.LastName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastName_nvcTextBox.MaxLength = 50;
            this.LastName_nvcTextBox.Name = "LastName_nvcTextBox";
            this.LastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.LastName_nvcTextBox.TabIndex = 4;
            this.LastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsuranceNumber_nvcTextBox
            // 
            this.InsuranceNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsuranceNumber_nvcTextBox.Location = new System.Drawing.Point(15, 197);
            this.InsuranceNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InsuranceNumber_nvcTextBox.MaxLength = 15;
            this.InsuranceNumber_nvcTextBox.Name = "InsuranceNumber_nvcTextBox";
            this.InsuranceNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsuranceNumber_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.InsuranceNumber_nvcTextBox.TabIndex = 5;
            this.InsuranceNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CityCode_nvcTextBox
            // 
            this.CityCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCode_nvcTextBox.Location = new System.Drawing.Point(15, 266);
            this.CityCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityCode_nvcTextBox.MaxLength = 10;
            this.CityCode_nvcTextBox.Name = "CityCode_nvcTextBox";
            this.CityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityCode_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.CityCode_nvcTextBox.TabIndex = 7;
            this.CityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // licenceNumber_nvcTextBox
            // 
            this.licenceNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenceNumber_nvcTextBox.Location = new System.Drawing.Point(15, 300);
            this.licenceNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.licenceNumber_nvcTextBox.MaxLength = 20;
            this.licenceNumber_nvcTextBox.Name = "licenceNumber_nvcTextBox";
            this.licenceNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.licenceNumber_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.licenceNumber_nvcTextBox.TabIndex = 8;
            this.licenceNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LicenceType_nvcTextBox
            // 
            this.LicenceType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceType_nvcTextBox.Location = new System.Drawing.Point(15, 369);
            this.LicenceType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LicenceType_nvcTextBox.MaxLength = 50;
            this.LicenceType_nvcTextBox.Name = "LicenceType_nvcTextBox";
            this.LicenceType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LicenceType_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.LicenceType_nvcTextBox.TabIndex = 10;
            this.LicenceType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LiceniceDate_nvcTextBox
            // 
            this.LiceniceDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LiceniceDate_nvcTextBox.Location = new System.Drawing.Point(15, 403);
            this.LiceniceDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LiceniceDate_nvcTextBox.MaxLength = 10;
            this.LiceniceDate_nvcTextBox.Name = "LiceniceDate_nvcTextBox";
            this.LiceniceDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LiceniceDate_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.LiceniceDate_nvcTextBox.TabIndex = 11;
            this.LiceniceDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ActivityScope_nvcTextBox
            // 
            this.ActivityScope_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivityScope_nvcTextBox.Location = new System.Drawing.Point(15, 437);
            this.ActivityScope_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ActivityScope_nvcTextBox.MaxLength = 50;
            this.ActivityScope_nvcTextBox.Name = "ActivityScope_nvcTextBox";
            this.ActivityScope_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActivityScope_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.ActivityScope_nvcTextBox.TabIndex = 12;
            this.ActivityScope_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DocNumber_nvcTextBox
            // 
            this.DocNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DocNumber_nvcTextBox.Location = new System.Drawing.Point(15, 540);
            this.DocNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DocNumber_nvcTextBox.MaxLength = 20;
            this.DocNumber_nvcTextBox.Name = "DocNumber_nvcTextBox";
            this.DocNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DocNumber_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.DocNumber_nvcTextBox.TabIndex = 15;
            this.DocNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsertDate_nvcTextBox
            // 
            this.InsertDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertDate_nvcTextBox.Location = new System.Drawing.Point(-190, 764);
            this.InsertDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InsertDate_nvcTextBox.MaxLength = 12;
            this.InsertDate_nvcTextBox.Name = "InsertDate_nvcTextBox";
            this.InsertDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsertDate_nvcTextBox.Size = new System.Drawing.Size(442, 30);
            this.InsertDate_nvcTextBox.TabIndex = 33;
            this.InsertDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UpdateDate_nvcTextBox
            // 
            this.UpdateDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateDate_nvcTextBox.Location = new System.Drawing.Point(-190, 810);
            this.UpdateDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateDate_nvcTextBox.MaxLength = 12;
            this.UpdateDate_nvcTextBox.Name = "UpdateDate_nvcTextBox";
            this.UpdateDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateDate_nvcTextBox.Size = new System.Drawing.Size(442, 30);
            this.UpdateDate_nvcTextBox.TabIndex = 34;
            this.UpdateDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CityID_intComboBox
            // 
            this.CityID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intComboBox.FormattingEnabled = true;
            this.CityID_intComboBox.Location = new System.Drawing.Point(55, 231);
            this.CityID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityID_intComboBox.Name = "CityID_intComboBox";
            this.CityID_intComboBox.Size = new System.Drawing.Size(274, 31);
            this.CityID_intComboBox.TabIndex = 6;
            this.CityID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.CityID_intComboBox_SelectionChangeCommitted);
            // 
            // LicenceCityID_intComboBox
            // 
            this.LicenceCityID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceCityID_intComboBox.FormattingEnabled = true;
            this.LicenceCityID_intComboBox.Location = new System.Drawing.Point(55, 334);
            this.LicenceCityID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LicenceCityID_intComboBox.Name = "LicenceCityID_intComboBox";
            this.LicenceCityID_intComboBox.Size = new System.Drawing.Size(274, 31);
            this.LicenceCityID_intComboBox.TabIndex = 9;
            // 
            // InfractionGroupID_intComboBox
            // 
            this.InfractionGroupID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroupID_intComboBox.FormattingEnabled = true;
            this.InfractionGroupID_intComboBox.Location = new System.Drawing.Point(54, 505);
            this.InfractionGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intComboBox.Name = "InfractionGroupID_intComboBox";
            this.InfractionGroupID_intComboBox.Size = new System.Drawing.Size(274, 31);
            this.InfractionGroupID_intComboBox.TabIndex = 14;
            // 
            // Deleted_bitCheckBox
            // 
            this.Deleted_bitCheckBox.Location = new System.Drawing.Point(440, 897);
            this.Deleted_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Deleted_bitCheckBox.Name = "Deleted_bitCheckBox";
            this.Deleted_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deleted_bitCheckBox.Size = new System.Drawing.Size(133, 30);
            this.Deleted_bitCheckBox.TabIndex = 39;
            this.Deleted_bitCheckBox.Text = "حذف شده";
            this.Deleted_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // NationalCode_intNumericTextBox
            // 
            this.NationalCode_intNumericTextBox.AllowNegative = false;
            this.NationalCode_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCode_intNumericTextBox.DigitsInGroup = 0;
            this.NationalCode_intNumericTextBox.Flags = 65536;
            this.NationalCode_intNumericTextBox.Location = new System.Drawing.Point(15, 471);
            this.NationalCode_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NationalCode_intNumericTextBox.MaxDecimalPlaces = 0;
            this.NationalCode_intNumericTextBox.MaxWholeDigits = 155;
            this.NationalCode_intNumericTextBox.Name = "NationalCode_intNumericTextBox";
            this.NationalCode_intNumericTextBox.Prefix = "";
          //  this.NationalCode_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
//this.NationalCode_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.NationalCode_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NationalCode_intNumericTextBox.Size = new System.Drawing.Size(314, 30);
            this.NationalCode_intNumericTextBox.TabIndex = 13;
            // 
            // DriverEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 659);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "DriverEntityForm";
            this.Text = "راننده";
            this.Load += new System.EventHandler(this.DriverEntityForm_Load);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label DriverCardDate_nvcLabel;
private System.Windows.Forms.Label DriverCardNumber_nvcLabel;
private System.Windows.Forms.Label DriverType_nvcLabel;
private System.Windows.Forms.Label FirstName_nvcLabel;
private System.Windows.Forms.Label LastName_nvcLabel;
private System.Windows.Forms.Label InsuranceNumber_nvcLabel;
private System.Windows.Forms.Label CityCode_nvcLabel;
private System.Windows.Forms.Label licenceNumber_nvcLabel;
private System.Windows.Forms.Label LicenceType_nvcLabel;
private System.Windows.Forms.Label LiceniceDate_nvcLabel;
private System.Windows.Forms.Label ActivityScope_nvcLabel;
private System.Windows.Forms.Label DocNumber_nvcLabel;
private System.Windows.Forms.Label InsertDate_nvcLabel;
private System.Windows.Forms.Label UpdateDate_nvcLabel;
        
private System.Windows.Forms.TextBox DriverCardDate_nvcTextBox;
private System.Windows.Forms.TextBox DriverCardNumber_nvcTextBox;
private System.Windows.Forms.TextBox DriverType_nvcTextBox;
private System.Windows.Forms.TextBox FirstName_nvcTextBox;
private System.Windows.Forms.TextBox LastName_nvcTextBox;
private System.Windows.Forms.TextBox InsuranceNumber_nvcTextBox;
private System.Windows.Forms.TextBox CityCode_nvcTextBox;
private System.Windows.Forms.TextBox licenceNumber_nvcTextBox;
private System.Windows.Forms.TextBox LicenceType_nvcTextBox;
private System.Windows.Forms.TextBox LiceniceDate_nvcTextBox;
private System.Windows.Forms.TextBox ActivityScope_nvcTextBox;
private System.Windows.Forms.TextBox DocNumber_nvcTextBox;
private System.Windows.Forms.TextBox InsertDate_nvcTextBox;
private System.Windows.Forms.TextBox UpdateDate_nvcTextBox;
        
private System.Windows.Forms.Label CityID_intLabel;
private System.Windows.Forms.Label LicenceCityID_intLabel;
private System.Windows.Forms.Label InfractionGroupID_intLabel;
       
private System.Windows.Forms.ComboBox CityID_intComboBox;
private System.Windows.Forms.ComboBox LicenceCityID_intComboBox;
private System.Windows.Forms.ComboBox InfractionGroupID_intComboBox;
        
private System.Windows.Forms.Button CityID_intNewButton;
private System.Windows.Forms.Button LicenceCityID_intNewButton;
private System.Windows.Forms.Button InfractionGroupID_intNewButton;
       
private System.Windows.Forms.Label NationalCode_intLabel;
        
private NumericTextBox NationalCode_intNumericTextBox;
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
private System.Windows.Forms.CheckBox Deleted_bitCheckBox;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox Mobile_nvctextBox;
private System.Windows.Forms.CheckBox Active_bit;
private System.Windows.Forms.Label label2;
    }
}
