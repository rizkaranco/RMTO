using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    partial class OtherCarsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherCarsForm));
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Comment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.TrafficTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.PriceWithTax_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.LastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mobile_vcTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChoosePrinterButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.System_nvcCombobox = new System.Windows.Forms.ComboBox();
            this.ServicesID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceWithoutTax_decnumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTax_decnumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.Trafficnumberlabel = new System.Windows.Forms.Label();
            this.TrafficNumbertextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PlateCityCode_nvcLabel = new System.Windows.Forms.Label();
            this.PlateCityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.PlateCityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.NumberPlateReadingButton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FurtherBillButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.captureOtherTrafficCameraTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SerialPlate_nvcTextBoxCamera = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvcTextBoxCamera = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.CameraGroupBox = new System.Windows.Forms.GroupBox();
            this.Cam2RadioButton = new System.Windows.Forms.RadioButton();
            this.Cam1RadioButton = new System.Windows.Forms.RadioButton();
            this.axVLCPlugin22 = new AxAXVLC.AxVLCPlugin2();
            this.NumberPlateReadingEditStateButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.CameraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(292, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "نوع وسيله";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(292, 121);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 13;
            this.label15.Text = "شماره پلاك";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(31, 117);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(256, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 6;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(292, 397);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 23);
            this.label16.TabIndex = 281;
            this.label16.Text = "توضیحات";
            // 
            // Comment_nvcTextBox
            // 
            this.Comment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Comment_nvcTextBox.Location = new System.Drawing.Point(31, 392);
            this.Comment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Comment_nvcTextBox.MaxLength = 50;
            this.Comment_nvcTextBox.Multiline = true;
            this.Comment_nvcTextBox.Name = "Comment_nvcTextBox";
            this.Comment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Comment_nvcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Comment_nvcTextBox.Size = new System.Drawing.Size(256, 46);
            this.Comment_nvcTextBox.TabIndex = 14;
            this.Comment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrafficTypeID_intComboBox
            // 
            this.TrafficTypeID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficTypeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrafficTypeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TrafficTypeID_intComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrafficTypeID_intComboBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficTypeID_intComboBox.FormattingEnabled = true;
            this.TrafficTypeID_intComboBox.Location = new System.Drawing.Point(31, 47);
            this.TrafficTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficTypeID_intComboBox.Name = "TrafficTypeID_intComboBox";
            this.TrafficTypeID_intComboBox.Size = new System.Drawing.Size(256, 31);
            this.TrafficTypeID_intComboBox.TabIndex = 4;
            this.TrafficTypeID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.TrafficTypeID_intComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(292, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 288;
            this.label1.Text = "نوع تردد";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label29.Location = new System.Drawing.Point(292, 293);
            this.label29.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 23);
            this.label29.TabIndex = 290;
            this.label29.Text = "مبلغ";
            // 
            // PriceWithTax_decNumericTextBox
            // 
            this.PriceWithTax_decNumericTextBox.AllowNegative = false;
            this.PriceWithTax_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceWithTax_decNumericTextBox.DigitsInGroup = 3;
            this.PriceWithTax_decNumericTextBox.Enabled = false;
            this.PriceWithTax_decNumericTextBox.Flags = 65536;
            this.PriceWithTax_decNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PriceWithTax_decNumericTextBox.Location = new System.Drawing.Point(31, 357);
            this.PriceWithTax_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PriceWithTax_decNumericTextBox.MaxDecimalPlaces = 0;
            this.PriceWithTax_decNumericTextBox.MaxWholeDigits = 155;
            this.PriceWithTax_decNumericTextBox.Name = "PriceWithTax_decNumericTextBox";
            this.PriceWithTax_decNumericTextBox.Prefix = "";
            this.PriceWithTax_decNumericTextBox.RangeMax = 0;
            this.PriceWithTax_decNumericTextBox.RangeMin = 0;
            this.PriceWithTax_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceWithTax_decNumericTextBox.Size = new System.Drawing.Size(256, 30);
            this.PriceWithTax_decNumericTextBox.TabIndex = 13;
            // 
            // CorrectButton
            // 
            this.CorrectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorrectButton.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CorrectButton.Location = new System.Drawing.Point(31, 289);
            this.CorrectButton.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(78, 30);
            this.CorrectButton.TabIndex = 9;
            this.CorrectButton.TabStop = false;
            this.CorrectButton.Text = "تصحیح مبلغ";
            this.CorrectButton.UseVisualStyleBackColor = true;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // LastName_nvcTextBox
            // 
            this.LastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastName_nvcTextBox.Location = new System.Drawing.Point(31, 49);
            this.LastName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastName_nvcTextBox.MaxLength = 20;
            this.LastName_nvcTextBox.Name = "LastName_nvcTextBox";
            this.LastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_nvcTextBox.Size = new System.Drawing.Size(256, 30);
            this.LastName_nvcTextBox.TabIndex = 1;
            this.LastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstName_nvcTextBox
            // 
            this.FirstName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FirstName_nvcTextBox.Location = new System.Drawing.Point(31, 14);
            this.FirstName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FirstName_nvcTextBox.MaxLength = 20;
            this.FirstName_nvcTextBox.Name = "FirstName_nvcTextBox";
            this.FirstName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstName_nvcTextBox.Size = new System.Drawing.Size(256, 30);
            this.FirstName_nvcTextBox.TabIndex = 0;
            this.FirstName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(292, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 295;
            this.label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(292, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 296;
            this.label4.Text = "نام";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mobile_vcTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.FirstName_nvcTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LastName_nvcTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(272, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(409, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "راننده";
            // 
            // Mobile_vcTextBox
            // 
            this.Mobile_vcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mobile_vcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Mobile_vcTextBox.Location = new System.Drawing.Point(31, 89);
            this.Mobile_vcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Mobile_vcTextBox.MaxLength = 20;
            this.Mobile_vcTextBox.Name = "Mobile_vcTextBox";
            this.Mobile_vcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mobile_vcTextBox.Size = new System.Drawing.Size(256, 30);
            this.Mobile_vcTextBox.TabIndex = 2;
            this.Mobile_vcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(292, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 298;
            this.label6.Text = "تلفن همراه";
            // 
            // ChoosePrinterButton
            // 
            this.ChoosePrinterButton.Location = new System.Drawing.Point(239, 605);
            this.ChoosePrinterButton.Margin = new System.Windows.Forms.Padding(5);
            this.ChoosePrinterButton.Name = "ChoosePrinterButton";
            this.ChoosePrinterButton.Size = new System.Drawing.Size(106, 29);
            this.ChoosePrinterButton.TabIndex = 2;
            this.ChoosePrinterButton.TabStop = false;
            this.ChoosePrinterButton.Text = "انتخاب چاپگر";
            this.ChoosePrinterButton.UseVisualStyleBackColor = true;
            this.ChoosePrinterButton.Click += new System.EventHandler(this.ChoosePrinterButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.System_nvcCombobox);
            this.groupBox2.Controls.Add(this.ServicesID_intComboBox);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.SerialPlate_nvcTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PriceWithoutTax_decnumericTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PriceTax_decnumericTextBox);
            this.groupBox2.Controls.Add(this.Trafficnumberlabel);
            this.groupBox2.Controls.Add(this.TrafficNumbertextBox);
            this.groupBox2.Controls.Add(this.TrafficTypeID_intComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CorrectButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.PlateCityCode_nvcLabel);
            this.groupBox2.Controls.Add(this.NumberPlate_nvcTextBox);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.PriceWithTax_decNumericTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.PlateCityID_intComboBox);
            this.groupBox2.Controls.Add(this.PlateCityCode_nvcTextBox);
            this.groupBox2.Controls.Add(this.Comment_nvcTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(272, 155);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(409, 446);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "خودرو";
            // 
            // System_nvcCombobox
            // 
            this.System_nvcCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.System_nvcCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.System_nvcCombobox.BackColor = System.Drawing.SystemColors.Window;
            this.System_nvcCombobox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.System_nvcCombobox.FormattingEnabled = true;
            this.System_nvcCombobox.Location = new System.Drawing.Point(31, 254);
            this.System_nvcCombobox.Name = "System_nvcCombobox";
            this.System_nvcCombobox.Size = new System.Drawing.Size(256, 31);
            this.System_nvcCombobox.TabIndex = 10;
            this.System_nvcCombobox.Tag = "نوع وسيله";
            // 
            // ServicesID_intComboBox
            // 
            this.ServicesID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesID_intComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServicesID_intComboBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ServicesID_intComboBox.FormattingEnabled = true;
            this.ServicesID_intComboBox.Location = new System.Drawing.Point(31, 83);
            this.ServicesID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServicesID_intComboBox.Name = "ServicesID_intComboBox";
            this.ServicesID_intComboBox.Size = new System.Drawing.Size(256, 31);
            this.ServicesID_intComboBox.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label30.Location = new System.Drawing.Point(293, 86);
            this.label30.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 23);
            this.label30.TabIndex = 314;
            this.label30.Text = "مراجعه به";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(292, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 23);
            this.label10.TabIndex = 312;
            this.label10.Text = "سري";
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(31, 152);
            this.SerialPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialPlate_nvcTextBox.MaxLength = 2;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(256, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 7;
            this.SerialPlate_nvcTextBox.Text = "15";
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SerialPlate_nvcTextBox.Leave += new System.EventHandler(this.SerialPlate_nvcTextBox_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(292, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 310;
            this.label5.Text = "مبلغ دریافتی ";
            // 
            // PriceWithoutTax_decnumericTextBox
            // 
            this.PriceWithoutTax_decnumericTextBox.AllowNegative = false;
            this.PriceWithoutTax_decnumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceWithoutTax_decnumericTextBox.DigitsInGroup = 3;
            this.PriceWithoutTax_decnumericTextBox.Enabled = false;
            this.PriceWithoutTax_decnumericTextBox.Flags = 65536;
            this.PriceWithoutTax_decnumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PriceWithoutTax_decnumericTextBox.Location = new System.Drawing.Point(109, 289);
            this.PriceWithoutTax_decnumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PriceWithoutTax_decnumericTextBox.MaxDecimalPlaces = 0;
            this.PriceWithoutTax_decnumericTextBox.MaxWholeDigits = 155;
            this.PriceWithoutTax_decnumericTextBox.Name = "PriceWithoutTax_decnumericTextBox";
            this.PriceWithoutTax_decnumericTextBox.Prefix = "";
            this.PriceWithoutTax_decnumericTextBox.RangeMax = 0;
            this.PriceWithoutTax_decnumericTextBox.RangeMin = 0;
            this.PriceWithoutTax_decnumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceWithoutTax_decnumericTextBox.Size = new System.Drawing.Size(178, 30);
            this.PriceWithoutTax_decnumericTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(292, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 308;
            this.label2.Text = "ارزش افزوده";
            // 
            // PriceTax_decnumericTextBox
            // 
            this.PriceTax_decnumericTextBox.AllowNegative = false;
            this.PriceTax_decnumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTax_decnumericTextBox.DigitsInGroup = 3;
            this.PriceTax_decnumericTextBox.Enabled = false;
            this.PriceTax_decnumericTextBox.Flags = 65536;
            this.PriceTax_decnumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PriceTax_decnumericTextBox.Location = new System.Drawing.Point(31, 323);
            this.PriceTax_decnumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PriceTax_decnumericTextBox.MaxDecimalPlaces = 0;
            this.PriceTax_decnumericTextBox.MaxWholeDigits = 155;
            this.PriceTax_decnumericTextBox.Name = "PriceTax_decnumericTextBox";
            this.PriceTax_decnumericTextBox.Prefix = "";
            this.PriceTax_decnumericTextBox.RangeMax = 0;
            this.PriceTax_decnumericTextBox.RangeMin = 0;
            this.PriceTax_decnumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceTax_decnumericTextBox.Size = new System.Drawing.Size(256, 30);
            this.PriceTax_decnumericTextBox.TabIndex = 12;
            // 
            // Trafficnumberlabel
            // 
            this.Trafficnumberlabel.AutoSize = true;
            this.Trafficnumberlabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Trafficnumberlabel.Location = new System.Drawing.Point(292, 17);
            this.Trafficnumberlabel.Name = "Trafficnumberlabel";
            this.Trafficnumberlabel.Size = new System.Drawing.Size(71, 23);
            this.Trafficnumberlabel.TabIndex = 306;
            this.Trafficnumberlabel.Text = "شماره قبض";
            this.Trafficnumberlabel.Visible = false;
            // 
            // TrafficNumbertextBox
            // 
            this.TrafficNumbertextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TrafficNumbertextBox.Enabled = false;
            this.TrafficNumbertextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficNumbertextBox.Location = new System.Drawing.Point(31, 13);
            this.TrafficNumbertextBox.MaxLength = 7;
            this.TrafficNumbertextBox.Name = "TrafficNumbertextBox";
            this.TrafficNumbertextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrafficNumbertextBox.Size = new System.Drawing.Size(256, 30);
            this.TrafficNumbertextBox.TabIndex = 3;
            this.TrafficNumbertextBox.TabStop = false;
            this.TrafficNumbertextBox.Tag = "شماره قبض";
            this.TrafficNumbertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TrafficNumbertextBox.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(292, 190);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "شهر شماره گذاري";
            // 
            // PlateCityCode_nvcLabel
            // 
            this.PlateCityCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityCode_nvcLabel.AutoSize = true;
            this.PlateCityCode_nvcLabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityCode_nvcLabel.Location = new System.Drawing.Point(292, 225);
            this.PlateCityCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlateCityCode_nvcLabel.Name = "PlateCityCode_nvcLabel";
            this.PlateCityCode_nvcLabel.Size = new System.Drawing.Size(50, 23);
            this.PlateCityCode_nvcLabel.TabIndex = 274;
            this.PlateCityCode_nvcLabel.Text = "کد شهر";
            // 
            // PlateCityID_intComboBox
            // 
            this.PlateCityID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PlateCityID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PlateCityID_intComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlateCityID_intComboBox.Enabled = false;
            this.PlateCityID_intComboBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityID_intComboBox.FormattingEnabled = true;
            this.PlateCityID_intComboBox.Location = new System.Drawing.Point(31, 186);
            this.PlateCityID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityID_intComboBox.Name = "PlateCityID_intComboBox";
            this.PlateCityID_intComboBox.Size = new System.Drawing.Size(256, 31);
            this.PlateCityID_intComboBox.TabIndex = 8;
            this.PlateCityID_intComboBox.SelectedValueChanged += new System.EventHandler(this.PlateCityID_intComboBox_SelectedValueChanged);
            // 
            // PlateCityCode_nvcTextBox
            // 
            this.PlateCityCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityCode_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlateCityCode_nvcTextBox.Enabled = false;
            this.PlateCityCode_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityCode_nvcTextBox.Location = new System.Drawing.Point(31, 221);
            this.PlateCityCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityCode_nvcTextBox.MaxLength = 10;
            this.PlateCityCode_nvcTextBox.Name = "PlateCityCode_nvcTextBox";
            this.PlateCityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlateCityCode_nvcTextBox.Size = new System.Drawing.Size(256, 30);
            this.PlateCityCode_nvcTextBox.TabIndex = 9;
            this.PlateCityCode_nvcTextBox.Text = "11320002";
            this.PlateCityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberPlateReadingButton
            // 
            this.NumberPlateReadingButton.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlateReadingButton.Location = new System.Drawing.Point(65, 399);
            this.NumberPlateReadingButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.NumberPlateReadingButton.Name = "NumberPlateReadingButton";
            this.NumberPlateReadingButton.Size = new System.Drawing.Size(109, 29);
            this.NumberPlateReadingButton.TabIndex = 307;
            this.NumberPlateReadingButton.TabStop = false;
            this.NumberPlateReadingButton.Text = "خواندن پلاک (F7)";
            this.NumberPlateReadingButton.UseVisualStyleBackColor = true;
            this.NumberPlateReadingButton.Click += new System.EventHandler(this.NumberPlateReadingButton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Enabled = false;
            this.Editbutton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Editbutton.Location = new System.Drawing.Point(578, 605);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(106, 29);
            this.Editbutton.TabIndex = 46;
            this.Editbutton.Text = "تغییرات";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            this.Editbutton.MouseHover += new System.EventHandler(this.Editbutton_MouseHover);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PreviousButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PreviousButton.Location = new System.Drawing.Point(466, 605);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(106, 29);
            this.PreviousButton.TabIndex = 41;
            this.PreviousButton.Text = "قبلی";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            this.PreviousButton.MouseHover += new System.EventHandler(this.PreviousButton_MouseHover);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextButton.Location = new System.Drawing.Point(354, 605);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(106, 29);
            this.NextButton.TabIndex = 40;
            this.NextButton.Text = "بعدی";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseHover += new System.EventHandler(this.NextButton_MouseHover);
            // 
            // FurtherBillButton
            // 
            this.FurtherBillButton.Enabled = false;
            this.FurtherBillButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FurtherBillButton.Location = new System.Drawing.Point(127, 605);
            this.FurtherBillButton.Name = "FurtherBillButton";
            this.FurtherBillButton.Size = new System.Drawing.Size(106, 29);
            this.FurtherBillButton.TabIndex = 42;
            this.FurtherBillButton.Text = "چاپ مجدد قبض";
            this.FurtherBillButton.UseVisualStyleBackColor = true;
            this.FurtherBillButton.Click += new System.EventHandler(this.FurtherBillButton_Click);
            this.FurtherBillButton.MouseHover += new System.EventHandler(this.FurtherBillButton_MouseHover);
            // 
            // NewButton
            // 
            this.NewButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NewButton.Enabled = false;
            this.NewButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewButton.Location = new System.Drawing.Point(13, 605);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(106, 29);
            this.NewButton.TabIndex = 45;
            this.NewButton.Text = "جدید";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            this.NewButton.MouseHover += new System.EventHandler(this.NewButton_MouseHover);
            // 
            // captureOtherTrafficCameraTimer
            // 
            this.captureOtherTrafficCameraTimer.Interval = 1600;
            this.captureOtherTrafficCameraTimer.Tick += new System.EventHandler(this.captureOtherTrafficCameraTimer_Tick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(11, 253);
            this.textBox2.MaxLength = 6;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(255, 35);
            this.textBox2.TabIndex = 309;
            this.textBox2.Tag = "شماره پلاك";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialPlate_nvcTextBoxCamera
            // 
            this.SerialPlate_nvcTextBoxCamera.BackColor = System.Drawing.SystemColors.Window;
            this.SerialPlate_nvcTextBoxCamera.Enabled = false;
            this.SerialPlate_nvcTextBoxCamera.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBoxCamera.Location = new System.Drawing.Point(80, 498);
            this.SerialPlate_nvcTextBoxCamera.MaxLength = 2;
            this.SerialPlate_nvcTextBoxCamera.Name = "SerialPlate_nvcTextBoxCamera";
            this.SerialPlate_nvcTextBoxCamera.ReadOnly = true;
            this.SerialPlate_nvcTextBoxCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBoxCamera.Size = new System.Drawing.Size(163, 30);
            this.SerialPlate_nvcTextBoxCamera.TabIndex = 313;
            this.SerialPlate_nvcTextBoxCamera.Tag = "سري";
            this.SerialPlate_nvcTextBoxCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberPlate_nvcTextBoxCamera
            // 
            this.NumberPlate_nvcTextBoxCamera.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBoxCamera.Enabled = false;
            this.NumberPlate_nvcTextBoxCamera.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBoxCamera.Location = new System.Drawing.Point(80, 456);
            this.NumberPlate_nvcTextBoxCamera.MaxLength = 6;
            this.NumberPlate_nvcTextBoxCamera.Name = "NumberPlate_nvcTextBoxCamera";
            this.NumberPlate_nvcTextBoxCamera.ReadOnly = true;
            this.NumberPlate_nvcTextBoxCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBoxCamera.Size = new System.Drawing.Size(163, 30);
            this.NumberPlate_nvcTextBoxCamera.TabIndex = 311;
            this.NumberPlate_nvcTextBoxCamera.Tag = "شماره پلاك";
            this.NumberPlate_nvcTextBoxCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(36, 502);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 23);
            this.label18.TabIndex = 312;
            this.label18.Text = "سري";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(4, 460);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 23);
            this.label19.TabIndex = 310;
            this.label19.Text = "شماره پلاك";
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(8, 41);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(256, 240);
            this.axVLCPlugin21.TabIndex = 314;
            // 
            // CameraGroupBox
            // 
            this.CameraGroupBox.Controls.Add(this.Cam2RadioButton);
            this.CameraGroupBox.Controls.Add(this.Cam1RadioButton);
            this.CameraGroupBox.Location = new System.Drawing.Point(8, 287);
            this.CameraGroupBox.Name = "CameraGroupBox";
            this.CameraGroupBox.Size = new System.Drawing.Size(255, 102);
            this.CameraGroupBox.TabIndex = 315;
            this.CameraGroupBox.TabStop = false;
            this.CameraGroupBox.Text = "انتخاب دوربین";
            // 
            // Cam2RadioButton
            // 
            this.Cam2RadioButton.AutoSize = true;
            this.Cam2RadioButton.Location = new System.Drawing.Point(133, 62);
            this.Cam2RadioButton.Name = "Cam2RadioButton";
            this.Cam2RadioButton.Size = new System.Drawing.Size(100, 27);
            this.Cam2RadioButton.TabIndex = 1;
            this.Cam2RadioButton.TabStop = true;
            this.Cam2RadioButton.Text = "ورود سواری 2";
            this.Cam2RadioButton.UseVisualStyleBackColor = true;
            this.Cam2RadioButton.CheckedChanged += new System.EventHandler(this.Cam2RadioButton_CheckedChanged);
            // 
            // Cam1RadioButton
            // 
            this.Cam1RadioButton.AutoSize = true;
            this.Cam1RadioButton.Location = new System.Drawing.Point(133, 29);
            this.Cam1RadioButton.Name = "Cam1RadioButton";
            this.Cam1RadioButton.Size = new System.Drawing.Size(100, 27);
            this.Cam1RadioButton.TabIndex = 0;
            this.Cam1RadioButton.TabStop = true;
            this.Cam1RadioButton.Text = "ورود سواری 1";
            this.Cam1RadioButton.UseVisualStyleBackColor = true;
            this.Cam1RadioButton.CheckedChanged += new System.EventHandler(this.Cam1RadioButton_CheckedChanged);
            // 
            // axVLCPlugin22
            // 
            this.axVLCPlugin22.Enabled = true;
            this.axVLCPlugin22.Location = new System.Drawing.Point(8, 41);
            this.axVLCPlugin22.Name = "axVLCPlugin22";
            this.axVLCPlugin22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin22.OcxState")));
            this.axVLCPlugin22.Size = new System.Drawing.Size(255, 240);
            this.axVLCPlugin22.TabIndex = 316;
            // 
            // NumberPlateReadingEditStateButton
            // 
            this.NumberPlateReadingEditStateButton.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlateReadingEditStateButton.Location = new System.Drawing.Point(65, 399);
            this.NumberPlateReadingEditStateButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.NumberPlateReadingEditStateButton.Name = "NumberPlateReadingEditStateButton";
            this.NumberPlateReadingEditStateButton.Size = new System.Drawing.Size(109, 29);
            this.NumberPlateReadingEditStateButton.TabIndex = 317;
            this.NumberPlateReadingEditStateButton.Text = "خواندن و ثبت پلاک";
            this.NumberPlateReadingEditStateButton.UseVisualStyleBackColor = true;
            this.NumberPlateReadingEditStateButton.Visible = false;
            this.NumberPlateReadingEditStateButton.Click += new System.EventHandler(this.NumberPlateReadingEditStateButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(8, 41);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 240);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 318;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "عکس";
            this.pictureBox.Visible = false;
            // 
            // OtherCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(722, 639);
            this.Controls.Add(this.NumberPlateReadingEditStateButton);
            this.Controls.Add(this.axVLCPlugin22);
            this.Controls.Add(this.CameraGroupBox);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.NumberPlateReadingButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SerialPlate_nvcTextBoxCamera);
            this.Controls.Add(this.NumberPlate_nvcTextBoxCamera);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FurtherBillButton);
            this.Controls.Add(this.ChoosePrinterButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(28);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherCarsForm";
            this.Text = "ورود سواری و سایر خودروها به پايانه بار";
            this.Load += new System.EventHandler(this.OtherCarsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OtherCarsForm_KeyDown);
            this.Controls.SetChildIndex(this.pictureBox, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.ChoosePrinterButton, 0);
            this.Controls.SetChildIndex(this.FurtherBillButton, 0);
            this.Controls.SetChildIndex(this.NextButton, 0);
            this.Controls.SetChildIndex(this.PreviousButton, 0);
            this.Controls.SetChildIndex(this.Editbutton, 0);
            this.Controls.SetChildIndex(this.NewButton, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.NumberPlate_nvcTextBoxCamera, 0);
            this.Controls.SetChildIndex(this.SerialPlate_nvcTextBoxCamera, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.NumberPlateReadingButton, 0);
            this.Controls.SetChildIndex(this.axVLCPlugin21, 0);
            this.Controls.SetChildIndex(this.CameraGroupBox, 0);
            this.Controls.SetChildIndex(this.axVLCPlugin22, 0);
            this.Controls.SetChildIndex(this.NumberPlateReadingEditStateButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.CameraGroupBox.ResumeLayout(false);
            this.CameraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Comment_nvcTextBox;
        private System.Windows.Forms.ComboBox TrafficTypeID_intComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label29;
        private NumericTextBox PriceWithTax_decNumericTextBox;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.TextBox LastName_nvcTextBox;
        private System.Windows.Forms.TextBox FirstName_nvcTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ChoosePrinterButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label PlateCityCode_nvcLabel;
        private System.Windows.Forms.ComboBox PlateCityID_intComboBox;
        private System.Windows.Forms.TextBox PlateCityCode_nvcTextBox;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button FurtherBillButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label Trafficnumberlabel;
        private System.Windows.Forms.TextBox TrafficNumbertextBox;
        private System.Windows.Forms.Button NumberPlateReadingButton;
        private System.Windows.Forms.Timer captureOtherTrafficCameraTimer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBoxCamera;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBoxCamera;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private NumericTextBox PriceWithoutTax_decnumericTextBox;
        private System.Windows.Forms.Label label2;
        private NumericTextBox PriceTax_decnumericTextBox;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.TextBox Mobile_vcTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.ComboBox ServicesID_intComboBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox CameraGroupBox;
        private System.Windows.Forms.RadioButton Cam2RadioButton;
        private System.Windows.Forms.RadioButton Cam1RadioButton;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin22;
        private Button NumberPlateReadingEditStateButton;
        internal PictureBox pictureBox;
        private ComboBox System_nvcCombobox;
    }
}