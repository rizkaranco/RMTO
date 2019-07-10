using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.TurnManagement
{
    partial class TurnAcceptionForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarCardNumber_nvcTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.YearType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LaderTypeCode_nvcLabel = new System.Windows.Forms.Label();
            this.LaderTypeCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.PlateCityCode_nvcLabel = new System.Windows.Forms.Label();
            this.PlateCityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductionYear_intNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.CarCardDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.System_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LaderTypeID_intTextBox = new System.Windows.Forms.TextBox();
            this.PlateCityID_intTextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Area_bitcheckBox = new System.Windows.Forms.CheckBox();
            this.Mobile_nvcnumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DriverCardNumber_bintNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.LastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.NationalCode_intNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.ClassID_intLabel = new System.Windows.Forms.Label();
            this.DriverCardDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.ClassID_intComboBox = new System.Windows.Forms.ComboBox();
            this.licenceNumber_intNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.WithoutCardcheckBox = new System.Windows.Forms.CheckBox();
            this.DriverType_nvc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PriceCorrectButon = new System.Windows.Forms.Button();
            this.AcceptedTurnComment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.WithLade_bitRadioButton = new System.Windows.Forms.RadioButton();
            this.numericTextBox2 = new HamrahanSystem.TextBox.NumericTextBox();
            this.Price_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.Comment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HorseRradioButton = new System.Windows.Forms.RadioButton();
            this.WithFlatRadioButton = new System.Windows.Forms.RadioButton();
            this.ServicesID_intTextBox = new System.Windows.Forms.TextBox();
            this.TurnAccepted_bit_bitButton = new System.Windows.Forms.Button();
            this.ChoosePrinterButton = new System.Windows.Forms.Button();
            this.Controlbutton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.Trafficnumberlabel = new System.Windows.Forms.Label();
            this.TrafficNumbertextBox = new System.Windows.Forms.TextBox();
            this.TurnAccepted_bitWithoutPrintButton = new System.Windows.Forms.Button();
            this.CarControlButton = new System.Windows.Forms.Button();
            this.DriverGropBox = new System.Windows.Forms.GroupBox();
            this.ShowSpecificationButton = new System.Windows.Forms.Button();
            this.LicenceEnd_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.HealthCardEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.HealthCardEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DriverCardSharjeEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DriverCardSharjeEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.CarGroupBox = new System.Windows.Forms.GroupBox();
            this.CarInfoShowButton = new System.Windows.Forms.Button();
            this.InsuranceEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CarExaminationEndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CarExaminationEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.InsuranceEndDate_nvcLabel = new System.Windows.Forms.Label();
            this.InTrafficPictureShowButton = new System.Windows.Forms.Button();
            this.AcceptTimeExpiredTurnsButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.DriverGropBox.SuspendLayout();
            this.CarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(148, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "نوع وسيله";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(419, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "سري";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(419, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "شهر شماره گذاري";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(148, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "تاريخ صدور";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(419, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "سال ساخت";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(148, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "شماره كارت هوشمند";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(419, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "شماره پلاك";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CarCardNumber_nvcTextBox);
            this.groupBox2.Controls.Add(this.YearType_nvcTextBox);
            this.groupBox2.Controls.Add(this.LaderTypeCode_nvcLabel);
            this.groupBox2.Controls.Add(this.LaderTypeCode_nvcTextBox);
            this.groupBox2.Controls.Add(this.PlateCityCode_nvcLabel);
            this.groupBox2.Controls.Add(this.PlateCityCode_nvcTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ProductionYear_intNumericTextBox);
            this.groupBox2.Controls.Add(this.CarCardDate_nvcTextBox);
            this.groupBox2.Controls.Add(this.SerialPlate_nvcTextBox);
            this.groupBox2.Controls.Add(this.System_nvcTextBox);
            this.groupBox2.Controls.Add(this.LaderTypeID_intTextBox);
            this.groupBox2.Controls.Add(this.PlateCityID_intTextBox);
            this.groupBox2.Controls.Add(this.NumberPlate_nvcTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(14, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کامیون";
            // 
            // CarCardNumber_nvcTextBox
            // 
            this.CarCardNumber_nvcTextBox.AllowNegative = false;
            this.CarCardNumber_nvcTextBox.DigitsInGroup = 0;
            this.CarCardNumber_nvcTextBox.Flags = 65536;
            this.CarCardNumber_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.CarCardNumber_nvcTextBox.Location = new System.Drawing.Point(8, 14);
            this.CarCardNumber_nvcTextBox.MaxDecimalPlaces = 0;
            this.CarCardNumber_nvcTextBox.MaxLength = 7;
            this.CarCardNumber_nvcTextBox.MaxWholeDigits = 7;
            this.CarCardNumber_nvcTextBox.Name = "CarCardNumber_nvcTextBox";
            this.CarCardNumber_nvcTextBox.Prefix = "";
            this.CarCardNumber_nvcTextBox.RangeMax = 0;
            this.CarCardNumber_nvcTextBox.RangeMin = 0;
            this.CarCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardNumber_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.CarCardNumber_nvcTextBox.TabIndex = 1;
            this.CarCardNumber_nvcTextBox.Leave += new System.EventHandler(this.CarCardNumber_nvcTextBox_Leave);
            // 
            // YearType_nvcTextBox
            // 
            this.YearType_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.YearType_nvcTextBox.Enabled = false;
            this.YearType_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.YearType_nvcTextBox.Location = new System.Drawing.Point(284, 152);
            this.YearType_nvcTextBox.MaxLength = 50;
            this.YearType_nvcTextBox.Name = "YearType_nvcTextBox";
            this.YearType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.YearType_nvcTextBox.Size = new System.Drawing.Size(77, 30);
            this.YearType_nvcTextBox.TabIndex = 9;
            this.YearType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderTypeCode_nvcLabel
            // 
            this.LaderTypeCode_nvcLabel.AutoSize = true;
            this.LaderTypeCode_nvcLabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeCode_nvcLabel.Location = new System.Drawing.Point(148, 120);
            this.LaderTypeCode_nvcLabel.Name = "LaderTypeCode_nvcLabel";
            this.LaderTypeCode_nvcLabel.Size = new System.Drawing.Size(75, 23);
            this.LaderTypeCode_nvcLabel.TabIndex = 14;
            this.LaderTypeCode_nvcLabel.Text = "کد نوع بارگیر";
            // 
            // LaderTypeCode_nvcTextBox
            // 
            this.LaderTypeCode_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LaderTypeCode_nvcTextBox.Enabled = false;
            this.LaderTypeCode_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeCode_nvcTextBox.Location = new System.Drawing.Point(7, 116);
            this.LaderTypeCode_nvcTextBox.MaxLength = 10;
            this.LaderTypeCode_nvcTextBox.Name = "LaderTypeCode_nvcTextBox";
            this.LaderTypeCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderTypeCode_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.LaderTypeCode_nvcTextBox.TabIndex = 7;
            this.LaderTypeCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlateCityCode_nvcLabel
            // 
            this.PlateCityCode_nvcLabel.AutoSize = true;
            this.PlateCityCode_nvcLabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityCode_nvcLabel.Location = new System.Drawing.Point(419, 89);
            this.PlateCityCode_nvcLabel.Name = "PlateCityCode_nvcLabel";
            this.PlateCityCode_nvcLabel.Size = new System.Drawing.Size(50, 23);
            this.PlateCityCode_nvcLabel.TabIndex = 8;
            this.PlateCityCode_nvcLabel.Text = "کد شهر";
            // 
            // PlateCityCode_nvcTextBox
            // 
            this.PlateCityCode_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlateCityCode_nvcTextBox.Enabled = false;
            this.PlateCityCode_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityCode_nvcTextBox.Location = new System.Drawing.Point(282, 85);
            this.PlateCityCode_nvcTextBox.MaxLength = 10;
            this.PlateCityCode_nvcTextBox.Name = "PlateCityCode_nvcTextBox";
            this.PlateCityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlateCityCode_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.PlateCityCode_nvcTextBox.TabIndex = 4;
            this.PlateCityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(148, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = " نوع بارگیر";
            // 
            // ProductionYear_intNumericTextBox
            // 
            this.ProductionYear_intNumericTextBox.AllowNegative = false;
            this.ProductionYear_intNumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ProductionYear_intNumericTextBox.DigitsInGroup = 0;
            this.ProductionYear_intNumericTextBox.Enabled = false;
            this.ProductionYear_intNumericTextBox.Flags = 65536;
            this.ProductionYear_intNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProductionYear_intNumericTextBox.Location = new System.Drawing.Point(364, 152);
            this.ProductionYear_intNumericTextBox.MaxDecimalPlaces = 0;
            this.ProductionYear_intNumericTextBox.MaxWholeDigits = 155;
            this.ProductionYear_intNumericTextBox.Name = "ProductionYear_intNumericTextBox";
            this.ProductionYear_intNumericTextBox.Prefix = "";
            this.ProductionYear_intNumericTextBox.RangeMax = 0;
            this.ProductionYear_intNumericTextBox.RangeMin = 0;
            this.ProductionYear_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductionYear_intNumericTextBox.Size = new System.Drawing.Size(47, 30);
            this.ProductionYear_intNumericTextBox.TabIndex = 8;
            // 
            // CarCardDate_nvcTextBox
            // 
            this.CarCardDate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CarCardDate_nvcTextBox.Enabled = false;
            this.CarCardDate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarCardDate_nvcTextBox.Location = new System.Drawing.Point(7, 49);
            this.CarCardDate_nvcTextBox.MaxLength = 10;
            this.CarCardDate_nvcTextBox.Name = "CarCardDate_nvcTextBox";
            this.CarCardDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardDate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.CarCardDate_nvcTextBox.TabIndex = 3;
            this.CarCardDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialPlate_nvcTextBox.Enabled = false;
            this.SerialPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(282, 119);
            this.SerialPlate_nvcTextBox.MaxLength = 3;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 6;
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // System_nvcTextBox
            // 
            this.System_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.System_nvcTextBox.Enabled = false;
            this.System_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.System_nvcTextBox.Location = new System.Drawing.Point(7, 149);
            this.System_nvcTextBox.MaxLength = 3;
            this.System_nvcTextBox.Name = "System_nvcTextBox";
            this.System_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.System_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.System_nvcTextBox.TabIndex = 10;
            this.System_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderTypeID_intTextBox
            // 
            this.LaderTypeID_intTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LaderTypeID_intTextBox.Enabled = false;
            this.LaderTypeID_intTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intTextBox.Location = new System.Drawing.Point(7, 82);
            this.LaderTypeID_intTextBox.MaxLength = 3;
            this.LaderTypeID_intTextBox.Name = "LaderTypeID_intTextBox";
            this.LaderTypeID_intTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderTypeID_intTextBox.Size = new System.Drawing.Size(130, 30);
            this.LaderTypeID_intTextBox.TabIndex = 5;
            this.LaderTypeID_intTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlateCityID_intTextBox
            // 
            this.PlateCityID_intTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlateCityID_intTextBox.Enabled = false;
            this.PlateCityID_intTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityID_intTextBox.Location = new System.Drawing.Point(282, 52);
            this.PlateCityID_intTextBox.MaxLength = 3;
            this.PlateCityID_intTextBox.Name = "PlateCityID_intTextBox";
            this.PlateCityID_intTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlateCityID_intTextBox.Size = new System.Drawing.Size(130, 30);
            this.PlateCityID_intTextBox.TabIndex = 2;
            this.PlateCityID_intTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Enabled = false;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(282, 17);
            this.NumberPlate_nvcTextBox.MaxLength = 3;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 0;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(643, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "نوع راننده";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(351, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "تاريخ صدور";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(139, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "كد ملي";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(142, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "نام";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(139, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "شماره گواهينامه";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(142, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "نام خانوادگي";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(352, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "شماره كارت هوشمند";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.Area_bitcheckBox);
            this.groupBox1.Controls.Add(this.Mobile_nvcnumericTextBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.DriverCardNumber_bintNumericTextBox);
            this.groupBox1.Controls.Add(this.LastName_nvcTextBox);
            this.groupBox1.Controls.Add(this.FirstName_nvcTextBox);
            this.groupBox1.Controls.Add(this.NationalCode_intNumericTextBox);
            this.groupBox1.Controls.Add(this.ClassID_intLabel);
            this.groupBox1.Controls.Add(this.DriverCardDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.ClassID_intComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "راننده";
            // 
            // Area_bitcheckBox
            // 
            this.Area_bitcheckBox.AutoSize = true;
            this.Area_bitcheckBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.Area_bitcheckBox.Location = new System.Drawing.Point(335, 145);
            this.Area_bitcheckBox.Name = "Area_bitcheckBox";
            this.Area_bitcheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Area_bitcheckBox.Size = new System.Drawing.Size(55, 27);
            this.Area_bitcheckBox.TabIndex = 7;
            this.Area_bitcheckBox.Text = "حومه";
            this.Area_bitcheckBox.UseVisualStyleBackColor = true;
            this.Area_bitcheckBox.Visible = false;
            // 
            // Mobile_nvcnumericTextBox
            // 
            this.Mobile_nvcnumericTextBox.AllowNegative = false;
            this.Mobile_nvcnumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mobile_nvcnumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Mobile_nvcnumericTextBox.DigitsInGroup = 0;
            this.Mobile_nvcnumericTextBox.Flags = 65536;
            this.Mobile_nvcnumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Mobile_nvcnumericTextBox.Location = new System.Drawing.Point(218, 104);
            this.Mobile_nvcnumericTextBox.MaxDecimalPlaces = 0;
            this.Mobile_nvcnumericTextBox.MaxLength = 11;
            this.Mobile_nvcnumericTextBox.MaxWholeDigits = 155;
            this.Mobile_nvcnumericTextBox.Name = "Mobile_nvcnumericTextBox";
            this.Mobile_nvcnumericTextBox.Prefix = "";
            this.Mobile_nvcnumericTextBox.RangeMax = 0;
            this.Mobile_nvcnumericTextBox.RangeMin = 0;
            this.Mobile_nvcnumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mobile_nvcnumericTextBox.Size = new System.Drawing.Size(130, 30);
            this.Mobile_nvcnumericTextBox.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(351, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 23);
            this.label18.TabIndex = 14;
            this.label18.Text = "شماره موبایل";
            // 
            // DriverCardNumber_bintNumericTextBox
            // 
            this.DriverCardNumber_bintNumericTextBox.AllowNegative = false;
            this.DriverCardNumber_bintNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_bintNumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DriverCardNumber_bintNumericTextBox.DigitsInGroup = 0;
            this.DriverCardNumber_bintNumericTextBox.Flags = 65536;
            this.DriverCardNumber_bintNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverCardNumber_bintNumericTextBox.Location = new System.Drawing.Point(218, 22);
            this.DriverCardNumber_bintNumericTextBox.MaxDecimalPlaces = 0;
            this.DriverCardNumber_bintNumericTextBox.MaxLength = 7;
            this.DriverCardNumber_bintNumericTextBox.MaxWholeDigits = 7;
            this.DriverCardNumber_bintNumericTextBox.Name = "DriverCardNumber_bintNumericTextBox";
            this.DriverCardNumber_bintNumericTextBox.Prefix = "";
            this.DriverCardNumber_bintNumericTextBox.RangeMax = 0;
            this.DriverCardNumber_bintNumericTextBox.RangeMin = 0;
            this.DriverCardNumber_bintNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_bintNumericTextBox.Size = new System.Drawing.Size(130, 30);
            this.DriverCardNumber_bintNumericTextBox.TabIndex = 0;
            this.DriverCardNumber_bintNumericTextBox.Leave += new System.EventHandler(this.DriverCardNumber_bintNumericTextBox_Leave);
            // 
            // LastName_nvcTextBox
            // 
            this.LastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LastName_nvcTextBox.Enabled = false;
            this.LastName_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastName_nvcTextBox.Location = new System.Drawing.Point(6, 64);
            this.LastName_nvcTextBox.MaxLength = 50;
            this.LastName_nvcTextBox.Name = "LastName_nvcTextBox";
            this.LastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.LastName_nvcTextBox.TabIndex = 3;
            this.LastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstName_nvcTextBox
            // 
            this.FirstName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.FirstName_nvcTextBox.Enabled = false;
            this.FirstName_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FirstName_nvcTextBox.Location = new System.Drawing.Point(6, 22);
            this.FirstName_nvcTextBox.MaxLength = 50;
            this.FirstName_nvcTextBox.Name = "FirstName_nvcTextBox";
            this.FirstName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstName_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.FirstName_nvcTextBox.TabIndex = 1;
            this.FirstName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NationalCode_intNumericTextBox
            // 
            this.NationalCode_intNumericTextBox.AllowNegative = false;
            this.NationalCode_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCode_intNumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NationalCode_intNumericTextBox.DigitsInGroup = 0;
            this.NationalCode_intNumericTextBox.Enabled = false;
            this.NationalCode_intNumericTextBox.Flags = 65536;
            this.NationalCode_intNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NationalCode_intNumericTextBox.Location = new System.Drawing.Point(6, 108);
            this.NationalCode_intNumericTextBox.MaxDecimalPlaces = 0;
            this.NationalCode_intNumericTextBox.MaxWholeDigits = 155;
            this.NationalCode_intNumericTextBox.Name = "NationalCode_intNumericTextBox";
            this.NationalCode_intNumericTextBox.Prefix = "";
            this.NationalCode_intNumericTextBox.RangeMax = 0;
            this.NationalCode_intNumericTextBox.RangeMin = 0;
            this.NationalCode_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NationalCode_intNumericTextBox.Size = new System.Drawing.Size(130, 30);
            this.NationalCode_intNumericTextBox.TabIndex = 5;
            // 
            // ClassID_intLabel
            // 
            this.ClassID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassID_intLabel.AutoSize = true;
            this.ClassID_intLabel.Location = new System.Drawing.Point(160, 161);
            this.ClassID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ClassID_intLabel.Name = "ClassID_intLabel";
            this.ClassID_intLabel.Size = new System.Drawing.Size(131, 16);
            this.ClassID_intLabel.TabIndex = 65;
            this.ClassID_intLabel.Text = "كلاس هاي آموزشي";
            this.ClassID_intLabel.Visible = false;
            // 
            // DriverCardDate_nvcTextBox
            // 
            this.DriverCardDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardDate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DriverCardDate_nvcTextBox.Enabled = false;
            this.DriverCardDate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverCardDate_nvcTextBox.Location = new System.Drawing.Point(218, 62);
            this.DriverCardDate_nvcTextBox.MaxLength = 10;
            this.DriverCardDate_nvcTextBox.Name = "DriverCardDate_nvcTextBox";
            this.DriverCardDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardDate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.DriverCardDate_nvcTextBox.TabIndex = 2;
            this.DriverCardDate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClassID_intComboBox
            // 
            this.ClassID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassID_intComboBox.FormattingEnabled = true;
            this.ClassID_intComboBox.Location = new System.Drawing.Point(28, 161);
            this.ClassID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ClassID_intComboBox.Name = "ClassID_intComboBox";
            this.ClassID_intComboBox.Size = new System.Drawing.Size(130, 24);
            this.ClassID_intComboBox.TabIndex = 3;
            this.ClassID_intComboBox.Visible = false;
            // 
            // licenceNumber_intNumericTextBox
            // 
            this.licenceNumber_intNumericTextBox.AllowNegative = false;
            this.licenceNumber_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenceNumber_intNumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.licenceNumber_intNumericTextBox.DigitsInGroup = 0;
            this.licenceNumber_intNumericTextBox.Flags = 65536;
            this.licenceNumber_intNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.licenceNumber_intNumericTextBox.Location = new System.Drawing.Point(8, 56);
            this.licenceNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.licenceNumber_intNumericTextBox.MaxWholeDigits = 158;
            this.licenceNumber_intNumericTextBox.Name = "licenceNumber_intNumericTextBox";
            this.licenceNumber_intNumericTextBox.Prefix = "";
            this.licenceNumber_intNumericTextBox.RangeMax = 0;
            this.licenceNumber_intNumericTextBox.RangeMin = 0;
            this.licenceNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.licenceNumber_intNumericTextBox.Size = new System.Drawing.Size(130, 30);
            this.licenceNumber_intNumericTextBox.TabIndex = 1;
            // 
            // WithoutCardcheckBox
            // 
            this.WithoutCardcheckBox.AutoSize = true;
            this.WithoutCardcheckBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WithoutCardcheckBox.Location = new System.Drawing.Point(52, -2);
            this.WithoutCardcheckBox.Name = "WithoutCardcheckBox";
            this.WithoutCardcheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WithoutCardcheckBox.Size = new System.Drawing.Size(157, 27);
            this.WithoutCardcheckBox.TabIndex = 0;
            this.WithoutCardcheckBox.TabStop = false;
            this.WithoutCardcheckBox.Text = "راننده فاقد كارت هوشمند ";
            this.WithoutCardcheckBox.UseVisualStyleBackColor = true;
            this.WithoutCardcheckBox.Visible = false;
            this.WithoutCardcheckBox.CheckedChanged += new System.EventHandler(this.WithoutCardcheckBox_CheckedChanged);
            // 
            // DriverType_nvc
            // 
            this.DriverType_nvc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverType_nvc.BackColor = System.Drawing.SystemColors.Window;
            this.DriverType_nvc.Enabled = false;
            this.DriverType_nvc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverType_nvc.Location = new System.Drawing.Point(703, 11);
            this.DriverType_nvc.MaxLength = 50;
            this.DriverType_nvc.Name = "DriverType_nvc";
            this.DriverType_nvc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverType_nvc.Size = new System.Drawing.Size(62, 22);
            this.DriverType_nvc.TabIndex = 4;
            this.DriverType_nvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DriverType_nvc.Visible = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(664, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 23);
            this.label16.TabIndex = 3;
            this.label16.Text = "توضیحات";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label30.Location = new System.Drawing.Point(660, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 23);
            this.label30.TabIndex = 0;
            this.label30.Text = "مراجعه به";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PriceCorrectButon);
            this.groupBox3.Controls.Add(this.AcceptedTurnComment_nvcTextBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.Price_decNumericTextBox);
            this.groupBox3.Controls.Add(this.Comment_nvcTextBox);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.ServicesID_intTextBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(14, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 185);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // PriceCorrectButon
            // 
            this.PriceCorrectButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceCorrectButon.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PriceCorrectButon.Location = new System.Drawing.Point(106, 94);
            this.PriceCorrectButon.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PriceCorrectButon.Name = "PriceCorrectButon";
            this.PriceCorrectButon.Size = new System.Drawing.Size(67, 30);
            this.PriceCorrectButon.TabIndex = 10;
            this.PriceCorrectButon.TabStop = false;
            this.PriceCorrectButon.Text = "تصحیح مبلغ";
            this.PriceCorrectButon.UseVisualStyleBackColor = true;
            this.PriceCorrectButon.Visible = false;
            this.PriceCorrectButon.Click += new System.EventHandler(this.PriceCorrectButon_Click);
            // 
            // AcceptedTurnComment_nvcTextBox
            // 
            this.AcceptedTurnComment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptedTurnComment_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AcceptedTurnComment_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AcceptedTurnComment_nvcTextBox.Location = new System.Drawing.Point(106, 131);
            this.AcceptedTurnComment_nvcTextBox.MaxLength = 32750;
            this.AcceptedTurnComment_nvcTextBox.Multiline = true;
            this.AcceptedTurnComment_nvcTextBox.Name = "AcceptedTurnComment_nvcTextBox";
            this.AcceptedTurnComment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AcceptedTurnComment_nvcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AcceptedTurnComment_nvcTextBox.Size = new System.Drawing.Size(550, 47);
            this.AcceptedTurnComment_nvcTextBox.TabIndex = 1;
            this.AcceptedTurnComment_nvcTextBox.Tag = "توضیحات";
            this.AcceptedTurnComment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(660, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "توضیحات ثبت نوبت";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.WithLade_bitRadioButton);
            this.groupBox5.Controls.Add(this.numericTextBox2);
            this.groupBox5.Enabled = false;
            this.groupBox5.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox5.Location = new System.Drawing.Point(107, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 42);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(69, 27);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "بدون بار";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // WithLade_bitRadioButton
            // 
            this.WithLade_bitRadioButton.AutoSize = true;
            this.WithLade_bitRadioButton.Location = new System.Drawing.Point(127, 13);
            this.WithLade_bitRadioButton.Name = "WithLade_bitRadioButton";
            this.WithLade_bitRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WithLade_bitRadioButton.Size = new System.Drawing.Size(50, 27);
            this.WithLade_bitRadioButton.TabIndex = 0;
            this.WithLade_bitRadioButton.Text = "با بار";
            this.WithLade_bitRadioButton.UseVisualStyleBackColor = true;
            // 
            // numericTextBox2
            // 
            this.numericTextBox2.AllowNegative = false;
            this.numericTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTextBox2.DigitsInGroup = 3;
            this.numericTextBox2.Enabled = false;
            this.numericTextBox2.Flags = 65536;
            this.numericTextBox2.Location = new System.Drawing.Point(14, 48);
            this.numericTextBox2.MaxDecimalPlaces = 0;
            this.numericTextBox2.MaxWholeDigits = 155;
            this.numericTextBox2.Name = "numericTextBox2";
            this.numericTextBox2.Prefix = "";
            this.numericTextBox2.RangeMax = 0;
            this.numericTextBox2.RangeMin = 0;
            this.numericTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericTextBox2.Size = new System.Drawing.Size(186, 30);
            this.numericTextBox2.TabIndex = 2;
            // 
            // Price_decNumericTextBox
            // 
            this.Price_decNumericTextBox.AllowNegative = false;
            this.Price_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Price_decNumericTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Price_decNumericTextBox.DigitsInGroup = 3;
            this.Price_decNumericTextBox.Enabled = false;
            this.Price_decNumericTextBox.Flags = 65536;
            this.Price_decNumericTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Price_decNumericTextBox.Location = new System.Drawing.Point(176, 94);
            this.Price_decNumericTextBox.MaxDecimalPlaces = 0;
            this.Price_decNumericTextBox.MaxWholeDigits = 155;
            this.Price_decNumericTextBox.Name = "Price_decNumericTextBox";
            this.Price_decNumericTextBox.Prefix = "";
            this.Price_decNumericTextBox.RangeMax = 0;
            this.Price_decNumericTextBox.RangeMin = 0;
            this.Price_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Price_decNumericTextBox.Size = new System.Drawing.Size(130, 30);
            this.Price_decNumericTextBox.TabIndex = 7;
            this.Price_decNumericTextBox.Visible = false;
            // 
            // Comment_nvcTextBox
            // 
            this.Comment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Comment_nvcTextBox.Enabled = false;
            this.Comment_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Comment_nvcTextBox.Location = new System.Drawing.Point(457, 57);
            this.Comment_nvcTextBox.MaxLength = 3;
            this.Comment_nvcTextBox.Multiline = true;
            this.Comment_nvcTextBox.Name = "Comment_nvcTextBox";
            this.Comment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Comment_nvcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Comment_nvcTextBox.Size = new System.Drawing.Size(200, 67);
            this.Comment_nvcTextBox.TabIndex = 4;
            this.Comment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label29.Location = new System.Drawing.Point(312, 101);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 23);
            this.label29.TabIndex = 6;
            this.label29.Text = "مبلغ دریافتی ";
            this.label29.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.HorseRradioButton);
            this.groupBox4.Controls.Add(this.WithFlatRadioButton);
            this.groupBox4.Enabled = false;
            this.groupBox4.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(107, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 42);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // HorseRradioButton
            // 
            this.HorseRradioButton.AutoSize = true;
            this.HorseRradioButton.Location = new System.Drawing.Point(17, 13);
            this.HorseRradioButton.Name = "HorseRradioButton";
            this.HorseRradioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HorseRradioButton.Size = new System.Drawing.Size(78, 27);
            this.HorseRradioButton.TabIndex = 1;
            this.HorseRradioButton.TabStop = true;
            this.HorseRradioButton.Text = "بدون کفی";
            this.HorseRradioButton.UseVisualStyleBackColor = true;
            // 
            // WithFlatRadioButton
            // 
            this.WithFlatRadioButton.AutoSize = true;
            this.WithFlatRadioButton.Checked = true;
            this.WithFlatRadioButton.Location = new System.Drawing.Point(116, 13);
            this.WithFlatRadioButton.Name = "WithFlatRadioButton";
            this.WithFlatRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WithFlatRadioButton.Size = new System.Drawing.Size(59, 27);
            this.WithFlatRadioButton.TabIndex = 0;
            this.WithFlatRadioButton.TabStop = true;
            this.WithFlatRadioButton.Text = "با کفی";
            this.WithFlatRadioButton.UseVisualStyleBackColor = true;
            // 
            // ServicesID_intTextBox
            // 
            this.ServicesID_intTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesID_intTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ServicesID_intTextBox.Enabled = false;
            this.ServicesID_intTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ServicesID_intTextBox.Location = new System.Drawing.Point(457, 14);
            this.ServicesID_intTextBox.MaxLength = 10;
            this.ServicesID_intTextBox.Name = "ServicesID_intTextBox";
            this.ServicesID_intTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServicesID_intTextBox.Size = new System.Drawing.Size(200, 30);
            this.ServicesID_intTextBox.TabIndex = 1;
            this.ServicesID_intTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TurnAccepted_bit_bitButton
            // 
            this.TurnAccepted_bit_bitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnAccepted_bit_bitButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TurnAccepted_bit_bitButton.Location = new System.Drawing.Point(466, 611);
            this.TurnAccepted_bit_bitButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TurnAccepted_bit_bitButton.Name = "TurnAccepted_bit_bitButton";
            this.TurnAccepted_bit_bitButton.Size = new System.Drawing.Size(106, 29);
            this.TurnAccepted_bit_bitButton.TabIndex = 11;
            this.TurnAccepted_bit_bitButton.Tag = "تأیید نوبت";
            this.TurnAccepted_bit_bitButton.Text = "تأیید نوبت و چاپ";
            this.toolTip1.SetToolTip(this.TurnAccepted_bit_bitButton, "F12");
            this.TurnAccepted_bit_bitButton.UseVisualStyleBackColor = true;
            this.TurnAccepted_bit_bitButton.Click += new System.EventHandler(this.TurnAccepted_bitButton_Click);
            // 
            // ChoosePrinterButton
            // 
            this.ChoosePrinterButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ChoosePrinterButton.Location = new System.Drawing.Point(373, 611);
            this.ChoosePrinterButton.Name = "ChoosePrinterButton";
            this.ChoosePrinterButton.Size = new System.Drawing.Size(91, 29);
            this.ChoosePrinterButton.TabIndex = 9;
            this.ChoosePrinterButton.Text = "انتخاب چاپگر";
            this.toolTip1.SetToolTip(this.ChoosePrinterButton, "F8");
            this.ChoosePrinterButton.UseVisualStyleBackColor = true;
            this.ChoosePrinterButton.Click += new System.EventHandler(this.ChoosePrinterButton_Click);
            // 
            // Controlbutton
            // 
            this.Controlbutton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Controlbutton.Location = new System.Drawing.Point(11, 175);
            this.Controlbutton.Name = "Controlbutton";
            this.Controlbutton.Size = new System.Drawing.Size(141, 29);
            this.Controlbutton.TabIndex = 4;
            this.Controlbutton.Tag = "کنترل";
            this.Controlbutton.Text = "ثبت مدارک کنترلی راننده";
            this.Controlbutton.UseVisualStyleBackColor = true;
            this.Controlbutton.Click += new System.EventHandler(this.Controlbutton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PreviousButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PreviousButton.Location = new System.Drawing.Point(291, 611);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(80, 29);
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.Text = "قبلی";
            this.toolTip1.SetToolTip(this.PreviousButton, "Page Down");
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NextButton.Location = new System.Drawing.Point(209, 611);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(80, 29);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "بعدی";
            this.toolTip1.SetToolTip(this.NextButton, "Page Up");
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Trafficnumberlabel
            // 
            this.Trafficnumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trafficnumberlabel.AutoSize = true;
            this.Trafficnumberlabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Trafficnumberlabel.Location = new System.Drawing.Point(215, 10);
            this.Trafficnumberlabel.Name = "Trafficnumberlabel";
            this.Trafficnumberlabel.Size = new System.Drawing.Size(71, 23);
            this.Trafficnumberlabel.TabIndex = 0;
            this.Trafficnumberlabel.Text = "شماره قبض";
            // 
            // TrafficNumbertextBox
            // 
            this.TrafficNumbertextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficNumbertextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TrafficNumbertextBox.Enabled = false;
            this.TrafficNumbertextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficNumbertextBox.Location = new System.Drawing.Point(296, 3);
            this.TrafficNumbertextBox.MaxLength = 7;
            this.TrafficNumbertextBox.Name = "TrafficNumbertextBox";
            this.TrafficNumbertextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrafficNumbertextBox.Size = new System.Drawing.Size(189, 30);
            this.TrafficNumbertextBox.TabIndex = 1;
            this.TrafficNumbertextBox.Tag = "شماره قبض";
            this.TrafficNumbertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TurnAccepted_bitWithoutPrintButton
            // 
            this.TurnAccepted_bitWithoutPrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnAccepted_bitWithoutPrintButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TurnAccepted_bitWithoutPrintButton.Location = new System.Drawing.Point(574, 611);
            this.TurnAccepted_bitWithoutPrintButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TurnAccepted_bitWithoutPrintButton.Name = "TurnAccepted_bitWithoutPrintButton";
            this.TurnAccepted_bitWithoutPrintButton.Size = new System.Drawing.Size(66, 29);
            this.TurnAccepted_bitWithoutPrintButton.TabIndex = 12;
            this.TurnAccepted_bitWithoutPrintButton.Tag = "تأیید نوبت";
            this.TurnAccepted_bitWithoutPrintButton.Text = "تأیید نوبت ";
            this.toolTip1.SetToolTip(this.TurnAccepted_bitWithoutPrintButton, "F4");
            this.TurnAccepted_bitWithoutPrintButton.UseVisualStyleBackColor = true;
            this.TurnAccepted_bitWithoutPrintButton.Click += new System.EventHandler(this.TurnAccepted_bitWithoutPrintButton_Click);
            // 
            // CarControlButton
            // 
            this.CarControlButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarControlButton.Location = new System.Drawing.Point(7, 146);
            this.CarControlButton.Name = "CarControlButton";
            this.CarControlButton.Size = new System.Drawing.Size(152, 29);
            this.CarControlButton.TabIndex = 13;
            this.CarControlButton.Tag = "کنترل";
            this.CarControlButton.Text = "ثبت مدارک  کنترلی  ناوگان";
            this.CarControlButton.UseVisualStyleBackColor = true;
            this.CarControlButton.Click += new System.EventHandler(this.CarControlButton_Click);
            // 
            // DriverGropBox
            // 
            this.DriverGropBox.Controls.Add(this.ShowSpecificationButton);
            this.DriverGropBox.Controls.Add(this.LicenceEnd_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.label19);
            this.DriverGropBox.Controls.Add(this.HealthCardEndDate_nvcLabel);
            this.DriverGropBox.Controls.Add(this.licenceNumber_intNumericTextBox);
            this.DriverGropBox.Controls.Add(this.HealthCardEndDate_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.Controlbutton);
            this.DriverGropBox.Controls.Add(this.DriverCardSharjeEndDate_nvcTextBox);
            this.DriverGropBox.Controls.Add(this.DriverCardSharjeEndDate_nvcLabel);
            this.DriverGropBox.Controls.Add(this.label2);
            this.DriverGropBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverGropBox.ForeColor = System.Drawing.Color.Teal;
            this.DriverGropBox.Location = new System.Drawing.Point(489, 24);
            this.DriverGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverGropBox.Name = "DriverGropBox";
            this.DriverGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DriverGropBox.Size = new System.Drawing.Size(309, 212);
            this.DriverGropBox.TabIndex = 1;
            this.DriverGropBox.TabStop = false;
            this.DriverGropBox.Text = "کنترل مدارک";
            // 
            // ShowSpecificationButton
            // 
            this.ShowSpecificationButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowSpecificationButton.Location = new System.Drawing.Point(154, 175);
            this.ShowSpecificationButton.Name = "ShowSpecificationButton";
            this.ShowSpecificationButton.Size = new System.Drawing.Size(63, 29);
            this.ShowSpecificationButton.TabIndex = 5;
            this.ShowSpecificationButton.Tag = "مشاهده مدارک راننده";
            this.ShowSpecificationButton.Text = "مشاهده";
            this.toolTip1.SetToolTip(this.ShowSpecificationButton, "F3");
            this.ShowSpecificationButton.UseVisualStyleBackColor = true;
            this.ShowSpecificationButton.Click += new System.EventHandler(this.ShowSpecificationButton_Click);
            // 
            // LicenceEnd_nvcTextBox
            // 
            this.LicenceEnd_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceEnd_nvcTextBox.Location = new System.Drawing.Point(8, 19);
            this.LicenceEnd_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LicenceEnd_nvcTextBox.Mask = "0000/00/00";
            this.LicenceEnd_nvcTextBox.Name = "LicenceEnd_nvcTextBox";
            this.LicenceEnd_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LicenceEnd_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.LicenceEnd_nvcTextBox.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 23);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 23);
            this.label19.TabIndex = 76;
            this.label19.Text = "تاريخ اتمام گواهینامه";
            // 
            // HealthCardEndDate_nvcLabel
            // 
            this.HealthCardEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthCardEndDate_nvcLabel.AutoSize = true;
            this.HealthCardEndDate_nvcLabel.Location = new System.Drawing.Point(139, 97);
            this.HealthCardEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HealthCardEndDate_nvcLabel.Name = "HealthCardEndDate_nvcLabel";
            this.HealthCardEndDate_nvcLabel.Size = new System.Drawing.Size(165, 23);
            this.HealthCardEndDate_nvcLabel.TabIndex = 74;
            this.HealthCardEndDate_nvcLabel.Text = "تاريخ اتمام اعتبار کارت سلامت";
            // 
            // HealthCardEndDate_nvcTextBox
            // 
            this.HealthCardEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthCardEndDate_nvcTextBox.Location = new System.Drawing.Point(7, 93);
            this.HealthCardEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.HealthCardEndDate_nvcTextBox.Mask = "0000/00/00";
            this.HealthCardEndDate_nvcTextBox.Name = "HealthCardEndDate_nvcTextBox";
            this.HealthCardEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HealthCardEndDate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.HealthCardEndDate_nvcTextBox.TabIndex = 2;
            // 
            // DriverCardSharjeEndDate_nvcTextBox
            // 
            this.DriverCardSharjeEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardSharjeEndDate_nvcTextBox.Location = new System.Drawing.Point(6, 130);
            this.DriverCardSharjeEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardSharjeEndDate_nvcTextBox.Mask = "0000/00/00";
            this.DriverCardSharjeEndDate_nvcTextBox.Name = "DriverCardSharjeEndDate_nvcTextBox";
            this.DriverCardSharjeEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardSharjeEndDate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.DriverCardSharjeEndDate_nvcTextBox.TabIndex = 3;
            // 
            // DriverCardSharjeEndDate_nvcLabel
            // 
            this.DriverCardSharjeEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardSharjeEndDate_nvcLabel.AutoSize = true;
            this.DriverCardSharjeEndDate_nvcLabel.Location = new System.Drawing.Point(138, 134);
            this.DriverCardSharjeEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardSharjeEndDate_nvcLabel.Name = "DriverCardSharjeEndDate_nvcLabel";
            this.DriverCardSharjeEndDate_nvcLabel.Size = new System.Drawing.Size(167, 23);
            this.DriverCardSharjeEndDate_nvcLabel.TabIndex = 11;
            this.DriverCardSharjeEndDate_nvcLabel.Text = "تاريخ اتمام شارژ كارت هوشمند";
            // 
            // CarGroupBox
            // 
            this.CarGroupBox.Controls.Add(this.CarInfoShowButton);
            this.CarGroupBox.Controls.Add(this.InsuranceEndDate_nvcTextBox);
            this.CarGroupBox.Controls.Add(this.CarExaminationEndDate_nvcTextBox);
            this.CarGroupBox.Controls.Add(this.CarControlButton);
            this.CarGroupBox.Controls.Add(this.CarExaminationEndDate_nvcLabel);
            this.CarGroupBox.Controls.Add(this.InsuranceEndDate_nvcLabel);
            this.CarGroupBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarGroupBox.ForeColor = System.Drawing.Color.Teal;
            this.CarGroupBox.Location = new System.Drawing.Point(546, 239);
            this.CarGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarGroupBox.Name = "CarGroupBox";
            this.CarGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CarGroupBox.Size = new System.Drawing.Size(252, 184);
            this.CarGroupBox.TabIndex = 3;
            this.CarGroupBox.TabStop = false;
            this.CarGroupBox.Text = "کنترل مدارک ناوگان";
            // 
            // CarInfoShowButton
            // 
            this.CarInfoShowButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarInfoShowButton.Location = new System.Drawing.Point(159, 146);
            this.CarInfoShowButton.Name = "CarInfoShowButton";
            this.CarInfoShowButton.Size = new System.Drawing.Size(63, 29);
            this.CarInfoShowButton.TabIndex = 78;
            this.CarInfoShowButton.Tag = "مشاهده مدارک ناوگان";
            this.CarInfoShowButton.Text = "مشاهده";
            this.CarInfoShowButton.UseVisualStyleBackColor = true;
            this.CarInfoShowButton.Click += new System.EventHandler(this.CarInfoShowButton_Click);
            // 
            // InsuranceEndDate_nvcTextBox
            // 
            this.InsuranceEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsuranceEndDate_nvcTextBox.Location = new System.Drawing.Point(7, 39);
            this.InsuranceEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InsuranceEndDate_nvcTextBox.Mask = "0000/00/00";
            this.InsuranceEndDate_nvcTextBox.Name = "InsuranceEndDate_nvcTextBox";
            this.InsuranceEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InsuranceEndDate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.InsuranceEndDate_nvcTextBox.TabIndex = 0;
            // 
            // CarExaminationEndDate_nvcTextBox
            // 
            this.CarExaminationEndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarExaminationEndDate_nvcTextBox.Location = new System.Drawing.Point(7, 74);
            this.CarExaminationEndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarExaminationEndDate_nvcTextBox.Mask = "0000/00/00";
            this.CarExaminationEndDate_nvcTextBox.Name = "CarExaminationEndDate_nvcTextBox";
            this.CarExaminationEndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarExaminationEndDate_nvcTextBox.Size = new System.Drawing.Size(130, 30);
            this.CarExaminationEndDate_nvcTextBox.TabIndex = 1;
            // 
            // CarExaminationEndDate_nvcLabel
            // 
            this.CarExaminationEndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarExaminationEndDate_nvcLabel.AutoSize = true;
            this.CarExaminationEndDate_nvcLabel.Location = new System.Drawing.Point(139, 77);
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
            this.InsuranceEndDate_nvcLabel.Location = new System.Drawing.Point(139, 42);
            this.InsuranceEndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InsuranceEndDate_nvcLabel.Name = "InsuranceEndDate_nvcLabel";
            this.InsuranceEndDate_nvcLabel.Size = new System.Drawing.Size(90, 23);
            this.InsuranceEndDate_nvcLabel.TabIndex = 62;
            this.InsuranceEndDate_nvcLabel.Text = "تاريخ اتمام بيمه";
            // 
            // InTrafficPictureShowButton
            // 
            this.InTrafficPictureShowButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InTrafficPictureShowButton.Location = new System.Drawing.Point(58, 611);
            this.InTrafficPictureShowButton.Name = "InTrafficPictureShowButton";
            this.InTrafficPictureShowButton.Size = new System.Drawing.Size(149, 29);
            this.InTrafficPictureShowButton.TabIndex = 13;
            this.InTrafficPictureShowButton.Text = "نمایش تصویر ورود(F7)";
            this.InTrafficPictureShowButton.UseVisualStyleBackColor = true;
            this.InTrafficPictureShowButton.Click += new System.EventHandler(this.InTrafficPictureShowButton_Click);
            // 
            // AcceptTimeExpiredTurnsButton
            // 
            this.AcceptTimeExpiredTurnsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptTimeExpiredTurnsButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AcceptTimeExpiredTurnsButton.Location = new System.Drawing.Point(642, 611);
            this.AcceptTimeExpiredTurnsButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.AcceptTimeExpiredTurnsButton.Name = "AcceptTimeExpiredTurnsButton";
            this.AcceptTimeExpiredTurnsButton.Size = new System.Drawing.Size(109, 29);
            this.AcceptTimeExpiredTurnsButton.TabIndex = 13;
            this.AcceptTimeExpiredTurnsButton.Tag = "تأیید تاریخ گذشته";
            this.AcceptTimeExpiredTurnsButton.Text = "تأیید تاریخ گذشته";
            this.toolTip1.SetToolTip(this.AcceptTimeExpiredTurnsButton, "F6");
            this.AcceptTimeExpiredTurnsButton.UseVisualStyleBackColor = true;
            this.AcceptTimeExpiredTurnsButton.Click += new System.EventHandler(this.AcceptTimeExpiredTurnsButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 300;
            // 
            // TurnAcceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(809, 644);
            this.Controls.Add(this.AcceptTimeExpiredTurnsButton);
            this.Controls.Add(this.InTrafficPictureShowButton);
            this.Controls.Add(this.CarGroupBox);
            this.Controls.Add(this.TrafficNumbertextBox);
            this.Controls.Add(this.DriverGropBox);
            this.Controls.Add(this.TurnAccepted_bitWithoutPrintButton);
            this.Controls.Add(this.Trafficnumberlabel);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.WithoutCardcheckBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChoosePrinterButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TurnAccepted_bit_bitButton);
            this.Controls.Add(this.DriverType_nvc);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TurnAcceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تردد کامیون ایرانی";
            this.Load += new System.EventHandler(this.IranianTruckEntityForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurnAcceptionForm_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.DriverGropBox.ResumeLayout(false);
            this.DriverGropBox.PerformLayout();
            this.CarGroupBox.ResumeLayout(false);
            this.CarGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DriverCardDate_nvcTextBox;
        private System.Windows.Forms.TextBox DriverType_nvc;
        private NumericTextBox NationalCode_intNumericTextBox;
        private System.Windows.Forms.TextBox LastName_nvcTextBox;
        private System.Windows.Forms.TextBox FirstName_nvcTextBox;
        private NumericTextBox licenceNumber_intNumericTextBox;
        private System.Windows.Forms.TextBox CarCardDate_nvcTextBox;
        private NumericTextBox ProductionYear_intNumericTextBox;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LaderTypeCode_nvcLabel;
        private System.Windows.Forms.TextBox LaderTypeCode_nvcTextBox;
        private System.Windows.Forms.Label PlateCityCode_nvcLabel;
        private System.Windows.Forms.TextBox PlateCityCode_nvcTextBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton WithFlatRadioButton;
        private System.Windows.Forms.RadioButton HorseRradioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton WithLade_bitRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox YearType_nvcTextBox;
        private System.Windows.Forms.Button TurnAccepted_bit_bitButton;
        private NumericTextBox numericTextBox2;
        private System.Windows.Forms.TextBox PlateCityID_intTextBox;
        private System.Windows.Forms.TextBox System_nvcTextBox;
        private System.Windows.Forms.TextBox LaderTypeID_intTextBox;
        private NumericTextBox Price_decNumericTextBox;
        private System.Windows.Forms.TextBox Comment_nvcTextBox;
        private NumericTextBox DriverCardNumber_bintNumericTextBox;
        private System.Windows.Forms.TextBox AcceptedTurnComment_nvcTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ServicesID_intTextBox;
        private System.Windows.Forms.Button ChoosePrinterButton;
        private System.Windows.Forms.Button Controlbutton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox WithoutCardcheckBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label Trafficnumberlabel;
        private System.Windows.Forms.TextBox TrafficNumbertextBox;
        private System.Windows.Forms.Button PriceCorrectButon;
        private NumericTextBox Mobile_nvcnumericTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox Area_bitcheckBox;
        private System.Windows.Forms.Button TurnAccepted_bitWithoutPrintButton;
        private NumericTextBox CarCardNumber_nvcTextBox;
        private System.Windows.Forms.Button CarControlButton;
        private System.Windows.Forms.GroupBox DriverGropBox;
        private System.Windows.Forms.MaskedTextBox LicenceEnd_nvcTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label HealthCardEndDate_nvcLabel;
        private System.Windows.Forms.MaskedTextBox HealthCardEndDate_nvcTextBox;
        private System.Windows.Forms.Label ClassID_intLabel;
        private System.Windows.Forms.ComboBox ClassID_intComboBox;
        private System.Windows.Forms.MaskedTextBox DriverCardSharjeEndDate_nvcTextBox;
        private System.Windows.Forms.Label DriverCardSharjeEndDate_nvcLabel;
        private System.Windows.Forms.GroupBox CarGroupBox;
        private System.Windows.Forms.MaskedTextBox InsuranceEndDate_nvcTextBox;
        private System.Windows.Forms.MaskedTextBox CarExaminationEndDate_nvcTextBox;
        private System.Windows.Forms.Label CarExaminationEndDate_nvcLabel;
        private System.Windows.Forms.Label InsuranceEndDate_nvcLabel;
        private System.Windows.Forms.Button ShowSpecificationButton;
        private System.Windows.Forms.Button CarInfoShowButton;
        private System.Windows.Forms.Button InTrafficPictureShowButton;
        private System.Windows.Forms.Button AcceptTimeExpiredTurnsButton;
        private ToolTip toolTip1;
    }
}