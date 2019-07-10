using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.DriverSpecification
{
    partial class DriverSpecificationEntityForm 

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
            this.DriverGropBox = new System.Windows.Forms.GroupBox();
            this.LicenceEnd_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HealthCardEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.HealthCardEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DriverCardNumber_nvcLabel = new System.Windows.Forms.Label();
            this.FirstName_nvcLabel = new System.Windows.Forms.Label();
            this.LastName_nvcLabel = new System.Windows.Forms.Label();
            this.licenceNumber_nvcLabel = new System.Windows.Forms.Label();
            this.ClassID_intLabel = new System.Windows.Forms.Label();
            this.NationalCode_intLabel = new System.Windows.Forms.Label();
            this.ClassID_intNewButton = new System.Windows.Forms.Button();
            this.DriverCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.ClassID_intComboBox = new System.Windows.Forms.ComboBox();
            this.licenceNumber_nvcTextBox = new NumericTextBox();
            this.NationalCode_intNumericTextBox = new NumericTextBox();
            this.DriverCardSharjeEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DriverCardSharjeEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            this.CarGroupBox = new System.Windows.Forms.GroupBox();
            this.InsuranceEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CarExaminationEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CarExaminationEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.InsuranceEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.CarControlButton = new System.Windows.Forms.Button();
            this.DriverControlbutton = new System.Windows.Forms.Button();
            this.DriverGropBox.SuspendLayout();
            this.CarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(342, 298);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.Visible = false;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(380, 32);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(380, 55);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DeleteRecordButton.Visible = false;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(382, 155);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DriverGropBox
            // 
            this.DriverGropBox.Controls.Add(this.DriverControlbutton);
            this.DriverGropBox.Controls.Add(this.LicenceEnd_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.label1);
            this.DriverGropBox.Controls.Add(this.HealthCardEndDate_nvcLabel);
            this.DriverGropBox.Controls.Add(this.HealthCardEndDate_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.Editbutton);
            this.DriverGropBox.Controls.Add(this.DriverCardNumber_nvcLabel);
            this.DriverGropBox.Controls.Add(this.FirstName_nvcLabel);
            this.DriverGropBox.Controls.Add(this.LastName_nvcLabel);
            this.DriverGropBox.Controls.Add(this.licenceNumber_nvcLabel);
            this.DriverGropBox.Controls.Add(this.ClassID_intLabel);
            this.DriverGropBox.Controls.Add(this.NationalCode_intLabel);
            this.DriverGropBox.Controls.Add(this.ClassID_intNewButton);
            this.DriverGropBox.Controls.Add(this.DriverCardNumber_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.FirstName_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.LastName_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.ClassID_intComboBox);
            this.DriverGropBox.Controls.Add(this.licenceNumber_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.NationalCode_intNumericTextBox);
            this.DriverGropBox.Controls.Add(this.DriverCardSharjeEndDate_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.DriverCardSharjeEndDate_nvcLabel);
            this.DriverGropBox.Location = new System.Drawing.Point(9, 3);
            this.DriverGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverGropBox.Name = "DriverGropBox";
            this.DriverGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DriverGropBox.Size = new System.Drawing.Size(595, 342);
            this.DriverGropBox.TabIndex = 0;
            this.DriverGropBox.TabStop = false;
            this.DriverGropBox.Text = "اطلاعات راننده";
            // 
            // LicenceEnd_nvcTextBox
            // 
            this.LicenceEnd_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceEnd_nvcTextBox.Location = new System.Drawing.Point(122, 193);
            this.LicenceEnd_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LicenceEnd_nvcTextBox.Mask = "0000/00/00";
            this.LicenceEnd_nvcTextBox.Name = "LicenceEnd_nvcTextBox";
            this.LicenceEnd_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LicenceEnd_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.LicenceEnd_nvcTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "تاريخ اتمام گواهینامه";
            // 
            // HealthCardEndDate_nvcLabel
            // 
            this.HealthCardEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthCardEndDate_nvcLabel.AutoSize = true;
            this.HealthCardEndDate_nvcLabel.Location = new System.Drawing.Point(414, 232);
            this.HealthCardEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HealthCardEndDate_nvcLabel.Name = "HealthCardEndDate_nvcLabel";
            this.HealthCardEndDate_nvcLabel.Size = new System.Drawing.Size(165, 23);
            this.HealthCardEndDate_nvcLabel.TabIndex = 74;
            this.HealthCardEndDate_nvcLabel.Text = "تاريخ اتمام اعتبار کارت سلامت";
            // 
            // HealthCardEndDate_nvcTextBox
            // 
            this.HealthCardEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthCardEndDate_nvcTextBox.Location = new System.Drawing.Point(122, 228);
            this.HealthCardEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.HealthCardEndDate_nvcTextBox.Mask = "0000/00/00";
            this.HealthCardEndDate_nvcTextBox.Name = "HealthCardEndDate_nvcTextBox";
            this.HealthCardEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HealthCardEndDate_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.HealthCardEndDate_nvcTextBox.TabIndex = 5;
            // 
            // DriverCardNumber_nvcLabel
            // 
            this.DriverCardNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_nvcLabel.AutoSize = true;
            this.DriverCardNumber_nvcLabel.Location = new System.Drawing.Point(414, 22);
            this.DriverCardNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardNumber_nvcLabel.Name = "DriverCardNumber_nvcLabel";
            this.DriverCardNumber_nvcLabel.Size = new System.Drawing.Size(103, 23);
            this.DriverCardNumber_nvcLabel.TabIndex = 45;
            this.DriverCardNumber_nvcLabel.Text = "شماره كارت راننده";
            // 
            // FirstName_nvcLabel
            // 
            this.FirstName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcLabel.AutoSize = true;
            this.FirstName_nvcLabel.Location = new System.Drawing.Point(414, 57);
            this.FirstName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstName_nvcLabel.Name = "FirstName_nvcLabel";
            this.FirstName_nvcLabel.Size = new System.Drawing.Size(25, 23);
            this.FirstName_nvcLabel.TabIndex = 47;
            this.FirstName_nvcLabel.Text = "نام";
            // 
            // LastName_nvcLabel
            // 
            this.LastName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcLabel.AutoSize = true;
            this.LastName_nvcLabel.Location = new System.Drawing.Point(414, 92);
            this.LastName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LastName_nvcLabel.Name = "LastName_nvcLabel";
            this.LastName_nvcLabel.Size = new System.Drawing.Size(74, 23);
            this.LastName_nvcLabel.TabIndex = 48;
            this.LastName_nvcLabel.Text = "نام خانوادگي";
            // 
            // licenceNumber_nvcLabel
            // 
            this.licenceNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenceNumber_nvcLabel.AutoSize = true;
            this.licenceNumber_nvcLabel.Location = new System.Drawing.Point(414, 162);
            this.licenceNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.licenceNumber_nvcLabel.Name = "licenceNumber_nvcLabel";
            this.licenceNumber_nvcLabel.Size = new System.Drawing.Size(90, 23);
            this.licenceNumber_nvcLabel.TabIndex = 50;
            this.licenceNumber_nvcLabel.Text = "شماره گواهينامه";
            // 
            // ClassID_intLabel
            // 
            this.ClassID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassID_intLabel.AutoSize = true;
            this.ClassID_intLabel.Location = new System.Drawing.Point(414, 302);
            this.ClassID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ClassID_intLabel.Name = "ClassID_intLabel";
            this.ClassID_intLabel.Size = new System.Drawing.Size(107, 23);
            this.ClassID_intLabel.TabIndex = 65;
            this.ClassID_intLabel.Text = "كلاس هاي آموزشي";
            // 
            // NationalCode_intLabel
            // 
            this.NationalCode_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCode_intLabel.AutoSize = true;
            this.NationalCode_intLabel.Location = new System.Drawing.Point(414, 127);
            this.NationalCode_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NationalCode_intLabel.Name = "NationalCode_intLabel";
            this.NationalCode_intLabel.Size = new System.Drawing.Size(44, 23);
            this.NationalCode_intLabel.TabIndex = 68;
            this.NationalCode_intLabel.Text = "كد ملي";
            // 
            // ClassID_intNewButton
            // 
            this.ClassID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.ClassID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClassID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClassID_intNewButton.Location = new System.Drawing.Point(122, 296);
            this.ClassID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClassID_intNewButton.Name = "ClassID_intNewButton";
            this.ClassID_intNewButton.Size = new System.Drawing.Size(37, 33);
            this.ClassID_intNewButton.TabIndex = 8;
            this.ClassID_intNewButton.TabStop = false;
            this.ClassID_intNewButton.UseVisualStyleBackColor = true;
            this.ClassID_intNewButton.Click += new System.EventHandler(this.ClassID_intNewButton_Click);
            // 
            // DriverCardNumber_nvcTextBox
            // 
            this.DriverCardNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_nvcTextBox.Location = new System.Drawing.Point(122, 18);
            this.DriverCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardNumber_nvcTextBox.MaxLength = 10;
            this.DriverCardNumber_nvcTextBox.Name = "DriverCardNumber_nvcTextBox";
            this.DriverCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.DriverCardNumber_nvcTextBox.TabIndex = 0;
            this.DriverCardNumber_nvcTextBox.TabStop = false;
            this.DriverCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstName_nvcTextBox
            // 
            this.FirstName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcTextBox.Location = new System.Drawing.Point(122, 53);
            this.FirstName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FirstName_nvcTextBox.MaxLength = 50;
            this.FirstName_nvcTextBox.Name = "FirstName_nvcTextBox";
            this.FirstName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstName_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.FirstName_nvcTextBox.TabIndex = 0;
            this.FirstName_nvcTextBox.TabStop = false;
            this.FirstName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LastName_nvcTextBox
            // 
            this.LastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcTextBox.Location = new System.Drawing.Point(122, 88);
            this.LastName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastName_nvcTextBox.MaxLength = 50;
            this.LastName_nvcTextBox.Name = "LastName_nvcTextBox";
            this.LastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.LastName_nvcTextBox.TabIndex = 1;
            this.LastName_nvcTextBox.TabStop = false;
            this.LastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClassID_intComboBox
            // 
            this.ClassID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassID_intComboBox.FormattingEnabled = true;
            this.ClassID_intComboBox.Location = new System.Drawing.Point(162, 298);
            this.ClassID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ClassID_intComboBox.Name = "ClassID_intComboBox";
            this.ClassID_intComboBox.Size = new System.Drawing.Size(248, 31);
            this.ClassID_intComboBox.TabIndex = 7;
            // 
            // licenceNumber_nvcTextBox
            // 
            this.licenceNumber_nvcTextBox.AllowNegative = false;
            this.licenceNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenceNumber_nvcTextBox.DigitsInGroup = 0;
            this.licenceNumber_nvcTextBox.Flags = 65536;
            this.licenceNumber_nvcTextBox.Location = new System.Drawing.Point(122, 158);
            this.licenceNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.licenceNumber_nvcTextBox.MaxDecimalPlaces = 0;
            this.licenceNumber_nvcTextBox.MaxWholeDigits = 25;
            this.licenceNumber_nvcTextBox.Name = "licenceNumber_nvcTextBox";
            this.licenceNumber_nvcTextBox.Prefix = "";
          //  this.licenceNumber_nvcTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.licenceNumber_nvcTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.licenceNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.licenceNumber_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.licenceNumber_nvcTextBox.TabIndex = 2;
            this.licenceNumber_nvcTextBox.TabStop = false;
            // 
            // NationalCode_intNumericTextBox
            // 
            this.NationalCode_intNumericTextBox.AllowNegative = false;
            this.NationalCode_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCode_intNumericTextBox.DigitsInGroup = 0;
            this.NationalCode_intNumericTextBox.Flags = 65536;
            this.NationalCode_intNumericTextBox.Location = new System.Drawing.Point(122, 123);
            this.NationalCode_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NationalCode_intNumericTextBox.MaxDecimalPlaces = 0;
            this.NationalCode_intNumericTextBox.MaxWholeDigits = 155;
            this.NationalCode_intNumericTextBox.Name = "NationalCode_intNumericTextBox";
            this.NationalCode_intNumericTextBox.Prefix = "";
          //  this.NationalCode_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.NationalCode_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.NationalCode_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NationalCode_intNumericTextBox.Size = new System.Drawing.Size(288, 30);
            this.NationalCode_intNumericTextBox.TabIndex = 2;
            this.NationalCode_intNumericTextBox.TabStop = false;
            // 
            // DriverCardSharjeEndDate_nvcTextBox
            // 
            this.DriverCardSharjeEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardSharjeEndDate_nvcTextBox.Location = new System.Drawing.Point(122, 263);
            this.DriverCardSharjeEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardSharjeEndDate_nvcTextBox.Mask = "0000/00/00";
            this.DriverCardSharjeEndDate_nvcTextBox.Name = "DriverCardSharjeEndDate_nvcTextBox";
            this.DriverCardSharjeEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardSharjeEndDate_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.DriverCardSharjeEndDate_nvcTextBox.TabIndex = 6;
            // 
            // DriverCardSharjeEndDate_nvcLabel
            // 
            this.DriverCardSharjeEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardSharjeEndDate_nvcLabel.AutoSize = true;
            this.DriverCardSharjeEndDate_nvcLabel.Location = new System.Drawing.Point(412, 267);
            this.DriverCardSharjeEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardSharjeEndDate_nvcLabel.Name = "DriverCardSharjeEndDate_nvcLabel";
            this.DriverCardSharjeEndDate_nvcLabel.Size = new System.Drawing.Size(167, 23);
            this.DriverCardSharjeEndDate_nvcLabel.TabIndex = 11;
            this.DriverCardSharjeEndDate_nvcLabel.Text = "تاريخ اتمام شارژ كارت هوشمند";
            // 
            // Editbutton
            // 
            this.Editbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Editbutton.Location = new System.Drawing.Point(14, 57);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(100, 32);
            this.Editbutton.TabIndex = 4;
            this.Editbutton.Text = "تغییرات";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Visible = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // CarGroupBox
            // 
            this.CarGroupBox.Controls.Add(this.CarControlButton);
            this.CarGroupBox.Controls.Add(this.InsuranceEndDate_nvcTextBox);
            this.CarGroupBox.Controls.Add(this.CarExaminationEndDate_nvcTextBox);
            this.CarGroupBox.Controls.Add(this.CarExaminationEndDate_nvcLabel);
            this.CarGroupBox.Controls.Add(this.InsuranceEndDate_nvcLabel);
            this.CarGroupBox.Location = new System.Drawing.Point(9, 355);
            this.CarGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarGroupBox.Name = "CarGroupBox";
            this.CarGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CarGroupBox.Size = new System.Drawing.Size(595, 101);
            this.CarGroupBox.TabIndex = 1;
            this.CarGroupBox.TabStop = false;
            this.CarGroupBox.Text = "اطلاعات ناوگان";
            // 
            // InsuranceEndDate_nvcTextBox
            // 
            this.InsuranceEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsuranceEndDate_nvcTextBox.Location = new System.Drawing.Point(122, 33);
            this.InsuranceEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InsuranceEndDate_nvcTextBox.Mask = "0000/00/00";
            this.InsuranceEndDate_nvcTextBox.Name = "InsuranceEndDate_nvcTextBox";
            this.InsuranceEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsuranceEndDate_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.InsuranceEndDate_nvcTextBox.TabIndex = 0;
            // 
            // CarExaminationEndDate_nvcTextBox
            // 
            this.CarExaminationEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarExaminationEndDate_nvcTextBox.Location = new System.Drawing.Point(122, 68);
            this.CarExaminationEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarExaminationEndDate_nvcTextBox.Mask = "0000/00/00";
            this.CarExaminationEndDate_nvcTextBox.Name = "CarExaminationEndDate_nvcTextBox";
            this.CarExaminationEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarExaminationEndDate_nvcTextBox.Size = new System.Drawing.Size(288, 30);
            this.CarExaminationEndDate_nvcTextBox.TabIndex = 1;
            // 
            // CarExaminationEndDate_nvcLabel
            // 
            this.CarExaminationEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarExaminationEndDate_nvcLabel.AutoSize = true;
            this.CarExaminationEndDate_nvcLabel.Location = new System.Drawing.Point(412, 71);
            this.CarExaminationEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarExaminationEndDate_nvcLabel.Name = "CarExaminationEndDate_nvcLabel";
            this.CarExaminationEndDate_nvcLabel.Size = new System.Drawing.Size(99, 23);
            this.CarExaminationEndDate_nvcLabel.TabIndex = 61;
            this.CarExaminationEndDate_nvcLabel.Text = "تاريخ اتمام معاينه";
            // 
            // InsuranceEndDate_nvcLabel
            // 
            this.InsuranceEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsuranceEndDate_nvcLabel.AutoSize = true;
            this.InsuranceEndDate_nvcLabel.Location = new System.Drawing.Point(414, 36);
            this.InsuranceEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InsuranceEndDate_nvcLabel.Name = "InsuranceEndDate_nvcLabel";
            this.InsuranceEndDate_nvcLabel.Size = new System.Drawing.Size(90, 23);
            this.InsuranceEndDate_nvcLabel.TabIndex = 62;
            this.InsuranceEndDate_nvcLabel.Text = "تاريخ اتمام بيمه";
            // 
            // CarControlButton
            // 
            this.CarControlButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarControlButton.Location = new System.Drawing.Point(3, 66);
            this.CarControlButton.Name = "CarControlButton";
            this.CarControlButton.Size = new System.Drawing.Size(112, 30);
            this.CarControlButton.TabIndex = 78;
            this.CarControlButton.Tag = "کنترل";
            this.CarControlButton.Text = "ثبت مدارک  ناوگان";
            this.CarControlButton.UseVisualStyleBackColor = true;
            this.CarControlButton.Click += new System.EventHandler(this.CarControlButton_Click);
            // 
            // DriverControlbutton
            // 
            this.DriverControlbutton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverControlbutton.Location = new System.Drawing.Point(8, 300);
            this.DriverControlbutton.Name = "DriverControlbutton";
            this.DriverControlbutton.Size = new System.Drawing.Size(106, 29);
            this.DriverControlbutton.TabIndex = 77;
            this.DriverControlbutton.Tag = "کنترل راننده";
            this.DriverControlbutton.Text = "ثبت مدارک راننده";
            this.DriverControlbutton.UseVisualStyleBackColor = true;
            this.DriverControlbutton.Click += new System.EventHandler(this.DriverControlbutton_Click);
            // 
            // DriverSpecificationEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 461);
            this.Controls.Add(this.CarGroupBox);
            this.Controls.Add(this.DriverGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "DriverSpecificationEntityForm";
            this.Text = "کنترل مدارک راننده";
            this.Load += new System.EventHandler(this.DriverSpecificationEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DriverGropBox, 0);
            this.Controls.SetChildIndex(this.CarGroupBox, 0);
            this.DriverGropBox.ResumeLayout(false);
            this.DriverGropBox.PerformLayout();
            this.CarGroupBox.ResumeLayout(false);
            this.CarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DriverGropBox;
        private System.Windows.Forms.Label DriverCardSharjeEndDate_nvcLabel;
private System.Windows.Forms.MaskedTextBox DriverCardSharjeEndDate_nvcTextBox;
private System.Windows.Forms.Button Editbutton;
private System.Windows.Forms.Label HealthCardEndDate_nvcLabel;
private System.Windows.Forms.MaskedTextBox HealthCardEndDate_nvcTextBox;
private System.Windows.Forms.Label DriverCardNumber_nvcLabel;
private System.Windows.Forms.Label FirstName_nvcLabel;
private System.Windows.Forms.Label LastName_nvcLabel;
private System.Windows.Forms.Label licenceNumber_nvcLabel;
private System.Windows.Forms.Label ClassID_intLabel;
private System.Windows.Forms.Label NationalCode_intLabel;
private System.Windows.Forms.Button ClassID_intNewButton;
private System.Windows.Forms.TextBox DriverCardNumber_nvcTextBox;
private System.Windows.Forms.TextBox FirstName_nvcTextBox;
private System.Windows.Forms.TextBox LastName_nvcTextBox;
private System.Windows.Forms.ComboBox ClassID_intComboBox;
private NumericTextBox NationalCode_intNumericTextBox;
private System.Windows.Forms.MaskedTextBox LicenceEnd_nvcTextBox;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.GroupBox CarGroupBox;
private System.Windows.Forms.MaskedTextBox InsuranceEndDate_nvcTextBox;
private System.Windows.Forms.MaskedTextBox CarExaminationEndDate_nvcTextBox;
private System.Windows.Forms.Label CarExaminationEndDate_nvcLabel;
private System.Windows.Forms.Label InsuranceEndDate_nvcLabel;
private NumericTextBox licenceNumber_nvcTextBox;
private System.Windows.Forms.Button DriverControlbutton;
private System.Windows.Forms.Button CarControlButton;
    }
}
