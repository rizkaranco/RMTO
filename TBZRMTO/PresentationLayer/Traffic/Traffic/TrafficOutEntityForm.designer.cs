using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.TrafficOut
{
    partial class TrafficOutEntityForm
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
            Janus.Windows.GridEX.GridEXLayout TrafficGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficOutEntityForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TurnDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UserName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Time_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Date_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Remainder_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.Balanced_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.Payable_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.PlateNo_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Car_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Driver_nvcTextBox = new System.Windows.Forms.TextBox();
            this.InDate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.TurnNumber_bintNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.InTime_nvcTextBox = new System.Windows.Forms.TextBox();
            this.TrafficNumber_bintNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TrafficNumber_bintlabel = new System.Windows.Forms.Label();
            this.TemporaryOutcheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AllOutbutton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TrafficNumberTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.SerialPlate_nvcTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.NumberPlateReadingButton = new System.Windows.Forms.Button();
            this.TrafficGridView = new Janus.Windows.GridEX.GridEX();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvcTextBoxCamera = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SerialPlate_nvcTextBoxCamera = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Cam2RadioButton = new System.Windows.Forms.RadioButton();
            this.Cam1RadioButton = new System.Windows.Forms.RadioButton();
            this.axVLCPlugin22 = new AxAXVLC.AxVLCPlugin2();
            this.ActiveCameraPlateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveAndNextButton.Location = new System.Drawing.Point(796, 448);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.TabIndex = 3;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(796, 481);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndCloseButton.TabIndex = 4;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRecordButton.Location = new System.Drawing.Point(796, 516);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DeleteRecordButton.TabIndex = 5;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseFormButton.Location = new System.Drawing.Point(796, 549);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CloseFormButton.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TurnDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.UserName_nvcTextBox);
            this.groupBox1.Controls.Add(this.Time_nvcTextBox);
            this.groupBox1.Controls.Add(this.Date_nvcTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Remainder_decNumericTextBox);
            this.groupBox1.Controls.Add(this.Balanced_decNumericTextBox);
            this.groupBox1.Controls.Add(this.Payable_decNumericTextBox);
            this.groupBox1.Controls.Add(this.PlateNo_nvcTextBox);
            this.groupBox1.Controls.Add(this.Car_nvcTextBox);
            this.groupBox1.Controls.Add(this.Driver_nvcTextBox);
            this.groupBox1.Controls.Add(this.InDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.TurnNumber_bintNumericTextBox);
            this.groupBox1.Controls.Add(this.InTime_nvcTextBox);
            this.groupBox1.Controls.Add(this.TrafficNumber_bintNumericTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TrafficNumber_bintlabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 393);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(739, 279);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(632, 240);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 23);
            this.label16.TabIndex = 37;
            this.label16.Text = "تاريخ تأیید نوبت";
            // 
            // TurnDate_nvcTextBox
            // 
            this.TurnDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnDate_nvcTextBox.Location = new System.Drawing.Point(396, 236);
            this.TurnDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnDate_nvcTextBox.Name = "TurnDate_nvcTextBox";
            this.TurnDate_nvcTextBox.ReadOnly = true;
            this.TurnDate_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.TurnDate_nvcTextBox.TabIndex = 36;
            this.TurnDate_nvcTextBox.TabStop = false;
            // 
            // UserName_nvcTextBox
            // 
            this.UserName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName_nvcTextBox.Location = new System.Drawing.Point(19, 236);
            this.UserName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserName_nvcTextBox.Name = "UserName_nvcTextBox";
            this.UserName_nvcTextBox.ReadOnly = true;
            this.UserName_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.UserName_nvcTextBox.TabIndex = 13;
            this.UserName_nvcTextBox.TabStop = false;
            // 
            // Time_nvcTextBox
            // 
            this.Time_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Time_nvcTextBox.Location = new System.Drawing.Point(19, 20);
            this.Time_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Time_nvcTextBox.Name = "Time_nvcTextBox";
            this.Time_nvcTextBox.ReadOnly = true;
            this.Time_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.Time_nvcTextBox.TabIndex = 6;
            this.Time_nvcTextBox.TabStop = false;
            // 
            // Date_nvcTextBox
            // 
            this.Date_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_nvcTextBox.Location = new System.Drawing.Point(396, 20);
            this.Date_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Date_nvcTextBox.Name = "Date_nvcTextBox";
            this.Date_nvcTextBox.ReadOnly = true;
            this.Date_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.Date_nvcTextBox.TabIndex = 0;
            this.Date_nvcTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "تاريخ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "ساعت";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "كاربر";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "مانده";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "مبلغ دریافتی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "مبلغ قابل پرداخت";
            // 
            // Remainder_decNumericTextBox
            // 
            this.Remainder_decNumericTextBox.AllowNegative = false;
            this.Remainder_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Remainder_decNumericTextBox.DigitsInGroup = 3;
            this.Remainder_decNumericTextBox.Flags = 65536;
            this.Remainder_decNumericTextBox.Location = new System.Drawing.Point(19, 200);
            this.Remainder_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Remainder_decNumericTextBox.MaxDecimalPlaces = 4;
            this.Remainder_decNumericTextBox.MaxWholeDigits = 9;
            this.Remainder_decNumericTextBox.Name = "Remainder_decNumericTextBox";
            this.Remainder_decNumericTextBox.Prefix = "";
            this.Remainder_decNumericTextBox.RangeMax =0;
            this.Remainder_decNumericTextBox.RangeMin = 0;
            this.Remainder_decNumericTextBox.ReadOnly = true;
            this.Remainder_decNumericTextBox.Size = new System.Drawing.Size(234, 30);
            this.Remainder_decNumericTextBox.TabIndex = 12;
            this.Remainder_decNumericTextBox.TabStop = false;
            // 
            // Balanced_decNumericTextBox
            // 
            this.Balanced_decNumericTextBox.AllowNegative = false;
            this.Balanced_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Balanced_decNumericTextBox.DigitsInGroup = 3;
            this.Balanced_decNumericTextBox.Flags = 65536;
            this.Balanced_decNumericTextBox.Location = new System.Drawing.Point(19, 164);
            this.Balanced_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Balanced_decNumericTextBox.MaxDecimalPlaces = 4;
            this.Balanced_decNumericTextBox.MaxWholeDigits = 9;
            this.Balanced_decNumericTextBox.Name = "Balanced_decNumericTextBox";
            this.Balanced_decNumericTextBox.Prefix = "";
            this.Balanced_decNumericTextBox.RangeMax = 0;
            this.Balanced_decNumericTextBox.RangeMin = 0;
            this.Balanced_decNumericTextBox.ReadOnly = true;
            this.Balanced_decNumericTextBox.Size = new System.Drawing.Size(234, 30);
            this.Balanced_decNumericTextBox.TabIndex = 11;
            this.Balanced_decNumericTextBox.TabStop = false;
            // 
            // Payable_decNumericTextBox
            // 
            this.Payable_decNumericTextBox.AllowNegative = false;
            this.Payable_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Payable_decNumericTextBox.DigitsInGroup = 3;
            this.Payable_decNumericTextBox.Flags = 65536;
            this.Payable_decNumericTextBox.Location = new System.Drawing.Point(19, 128);
            this.Payable_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Payable_decNumericTextBox.MaxDecimalPlaces = 4;
            this.Payable_decNumericTextBox.MaxWholeDigits = 9;
            this.Payable_decNumericTextBox.Name = "Payable_decNumericTextBox";
            this.Payable_decNumericTextBox.Prefix = "";
            this.Payable_decNumericTextBox.RangeMax = 0;
            this.Payable_decNumericTextBox.RangeMin = 0;
            this.Payable_decNumericTextBox.ReadOnly = true;
            this.Payable_decNumericTextBox.Size = new System.Drawing.Size(234, 30);
            this.Payable_decNumericTextBox.TabIndex = 10;
            this.Payable_decNumericTextBox.TabStop = false;
            // 
            // PlateNo_nvcTextBox
            // 
            this.PlateNo_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateNo_nvcTextBox.Location = new System.Drawing.Point(396, 200);
            this.PlateNo_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateNo_nvcTextBox.Name = "PlateNo_nvcTextBox";
            this.PlateNo_nvcTextBox.ReadOnly = true;
            this.PlateNo_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.PlateNo_nvcTextBox.TabIndex = 5;
            this.PlateNo_nvcTextBox.TabStop = false;
            // 
            // Car_nvcTextBox
            // 
            this.Car_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Car_nvcTextBox.Location = new System.Drawing.Point(396, 164);
            this.Car_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Car_nvcTextBox.Name = "Car_nvcTextBox";
            this.Car_nvcTextBox.ReadOnly = true;
            this.Car_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.Car_nvcTextBox.TabIndex = 4;
            this.Car_nvcTextBox.TabStop = false;
            // 
            // Driver_nvcTextBox
            // 
            this.Driver_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Driver_nvcTextBox.Location = new System.Drawing.Point(396, 128);
            this.Driver_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Driver_nvcTextBox.Name = "Driver_nvcTextBox";
            this.Driver_nvcTextBox.ReadOnly = true;
            this.Driver_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.Driver_nvcTextBox.TabIndex = 3;
            this.Driver_nvcTextBox.TabStop = false;
            // 
            // InDate_nvcTextBox
            // 
            this.InDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InDate_nvcTextBox.Location = new System.Drawing.Point(396, 56);
            this.InDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InDate_nvcTextBox.Name = "InDate_nvcTextBox";
            this.InDate_nvcTextBox.ReadOnly = true;
            this.InDate_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.InDate_nvcTextBox.TabIndex = 2;
            this.InDate_nvcTextBox.TabStop = false;
            // 
            // TurnNumber_bintNumericTextBox
            // 
            this.TurnNumber_bintNumericTextBox.AllowNegative = true;
            this.TurnNumber_bintNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnNumber_bintNumericTextBox.DigitsInGroup = 0;
            this.TurnNumber_bintNumericTextBox.Flags = 0;
            this.TurnNumber_bintNumericTextBox.Location = new System.Drawing.Point(19, 92);
            this.TurnNumber_bintNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnNumber_bintNumericTextBox.MaxDecimalPlaces = 4;
            this.TurnNumber_bintNumericTextBox.MaxWholeDigits = 9;
            this.TurnNumber_bintNumericTextBox.Name = "TurnNumber_bintNumericTextBox";
            this.TurnNumber_bintNumericTextBox.Prefix = "";
            this.TurnNumber_bintNumericTextBox.RangeMax = 0;
            this.TurnNumber_bintNumericTextBox.RangeMin = 0;
            this.TurnNumber_bintNumericTextBox.ReadOnly = true;
            this.TurnNumber_bintNumericTextBox.Size = new System.Drawing.Size(234, 30);
            this.TurnNumber_bintNumericTextBox.TabIndex = 7;
            this.TurnNumber_bintNumericTextBox.TabStop = false;
            // 
            // InTime_nvcTextBox
            // 
            this.InTime_nvcTextBox.AcceptsReturn = true;
            this.InTime_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InTime_nvcTextBox.Location = new System.Drawing.Point(19, 56);
            this.InTime_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InTime_nvcTextBox.Name = "InTime_nvcTextBox";
            this.InTime_nvcTextBox.ReadOnly = true;
            this.InTime_nvcTextBox.Size = new System.Drawing.Size(234, 30);
            this.InTime_nvcTextBox.TabIndex = 9;
            this.InTime_nvcTextBox.TabStop = false;
            // 
            // TrafficNumber_bintNumericTextBox
            // 
            this.TrafficNumber_bintNumericTextBox.AllowNegative = false;
            this.TrafficNumber_bintNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficNumber_bintNumericTextBox.DigitsInGroup = 0;
            this.TrafficNumber_bintNumericTextBox.Flags = 65536;
            this.TrafficNumber_bintNumericTextBox.Location = new System.Drawing.Point(396, 92);
            this.TrafficNumber_bintNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficNumber_bintNumericTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumber_bintNumericTextBox.MaxWholeDigits = 9;
            this.TrafficNumber_bintNumericTextBox.Name = "TrafficNumber_bintNumericTextBox";
            this.TrafficNumber_bintNumericTextBox.Prefix = "";
            this.TrafficNumber_bintNumericTextBox.RangeMax = 0;
            this.TrafficNumber_bintNumericTextBox.RangeMin = 0;
            this.TrafficNumber_bintNumericTextBox.ReadOnly = true;
            this.TrafficNumber_bintNumericTextBox.Size = new System.Drawing.Size(234, 30);
            this.TrafficNumber_bintNumericTextBox.TabIndex = 1;
            this.TrafficNumber_bintNumericTextBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "تاريخ ورود";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "ساعت ورود";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(632, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "خودرو";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(632, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "شماره پلاک";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "راننده";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "شماره نوبت";
            // 
            // TrafficNumber_bintlabel
            // 
            this.TrafficNumber_bintlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficNumber_bintlabel.AutoSize = true;
            this.TrafficNumber_bintlabel.Location = new System.Drawing.Point(632, 96);
            this.TrafficNumber_bintlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TrafficNumber_bintlabel.Name = "TrafficNumber_bintlabel";
            this.TrafficNumber_bintlabel.Size = new System.Drawing.Size(71, 23);
            this.TrafficNumber_bintlabel.TabIndex = 4;
            this.TrafficNumber_bintlabel.Text = "شماره قبض";
            // 
            // TemporaryOutcheckBox
            // 
            this.TemporaryOutcheckBox.AutoSize = true;
            this.TemporaryOutcheckBox.Location = new System.Drawing.Point(801, 415);
            this.TemporaryOutcheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.TemporaryOutcheckBox.Name = "TemporaryOutcheckBox";
            this.TemporaryOutcheckBox.Size = new System.Drawing.Size(90, 27);
            this.TemporaryOutcheckBox.TabIndex = 2;
            this.TemporaryOutcheckBox.Text = "خروج موقت";
            this.TemporaryOutcheckBox.UseVisualStyleBackColor = true;
            this.TemporaryOutcheckBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "شماره قبض";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(294, 14);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(115, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 1;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberPlate_nvcTextBox_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(220, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "شماره پلاك";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(421, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "سري";
            // 
            // AllOutbutton
            // 
            this.AllOutbutton.Location = new System.Drawing.Point(788, 14);
            this.AllOutbutton.Name = "AllOutbutton";
            this.AllOutbutton.Size = new System.Drawing.Size(104, 30);
            this.AllOutbutton.TabIndex = 4;
            this.AllOutbutton.Text = "نمایش کل خروج ها";
            this.AllOutbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AllOutbutton.UseVisualStyleBackColor = true;
            this.AllOutbutton.Click += new System.EventHandler(this.AllOutbutton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(679, 14);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 30);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TrafficNumberTextBox
            // 
            this.TrafficNumberTextBox.AllowNegative = true;
            this.TrafficNumberTextBox.DigitsInGroup = 0;
            this.TrafficNumberTextBox.Flags = 0;
            this.TrafficNumberTextBox.Location = new System.Drawing.Point(86, 14);
            this.TrafficNumberTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumberTextBox.MaxWholeDigits = 9;
            this.TrafficNumberTextBox.Name = "TrafficNumberTextBox";
            this.TrafficNumberTextBox.Prefix = "";
            this.TrafficNumberTextBox.RangeMax = 0;
            this.TrafficNumberTextBox.RangeMin = 0;
            this.TrafficNumberTextBox.Size = new System.Drawing.Size(108, 30);
            this.TrafficNumberTextBox.TabIndex = 0;
            this.TrafficNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficNumbertxt_KeyDown);
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.AllowNegative = true;
            this.SerialPlate_nvcTextBox.DigitsInGroup = 0;
            this.SerialPlate_nvcTextBox.Flags = 0;
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(467, 14);
            this.SerialPlate_nvcTextBox.MaxDecimalPlaces = 4;
            this.SerialPlate_nvcTextBox.MaxWholeDigits = 2;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.Prefix = "";
            this.SerialPlate_nvcTextBox.RangeMax = 0;
            this.SerialPlate_nvcTextBox.RangeMin = 0;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(36, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 2;
            this.SerialPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlate_nvcTextBox_KeyDown);
            // 
            // NumberPlateReadingButton
            // 
            this.NumberPlateReadingButton.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlateReadingButton.Location = new System.Drawing.Point(553, 15);
            this.NumberPlateReadingButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.NumberPlateReadingButton.Name = "NumberPlateReadingButton";
            this.NumberPlateReadingButton.Size = new System.Drawing.Size(120, 29);
            this.NumberPlateReadingButton.TabIndex = 28;
            this.NumberPlateReadingButton.TabStop = false;
            this.NumberPlateReadingButton.Text = "گرفتن عکس(F7)";
            this.NumberPlateReadingButton.UseVisualStyleBackColor = true;
            this.NumberPlateReadingButton.Click += new System.EventHandler(this.NumberPlateReadingButton_Click);
            // 
            // TrafficGridView
            // 
            this.TrafficGridView.AlternatingColors = true;
            this.TrafficGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.TrafficGridView.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>ستون ه" +
    "ا را برای گزوه بندی کشیده و در این قسمت رها کنید</GroupByBoxInfo></LocalizableDa" +
    "ta>";
            TrafficGridView_DesignTimeLayout.LayoutString = resources.GetString("TrafficGridView_DesignTimeLayout.LayoutString");
            this.TrafficGridView.DesignTimeLayout = TrafficGridView_DesignTimeLayout;
            this.TrafficGridView.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.TrafficGridView.GroupByBoxVisible = false;
            this.TrafficGridView.Location = new System.Drawing.Point(4, 148);
            this.TrafficGridView.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.Size = new System.Drawing.Size(637, 208);
            this.TrafficGridView.TabIndex = 29;
            this.TrafficGridView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.TrafficGridView.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.TrafficGridView_RowDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(650, 283);
            this.textBox2.MaxLength = 6;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(255, 35);
            this.textBox2.TabIndex = 52;
            this.textBox2.Tag = "شماره پلاك";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberPlate_nvcTextBoxCamera
            // 
            this.NumberPlate_nvcTextBoxCamera.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBoxCamera.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBoxCamera.Location = new System.Drawing.Point(260, 364);
            this.NumberPlate_nvcTextBoxCamera.MaxLength = 6;
            this.NumberPlate_nvcTextBoxCamera.Name = "NumberPlate_nvcTextBoxCamera";
            this.NumberPlate_nvcTextBoxCamera.ReadOnly = true;
            this.NumberPlate_nvcTextBoxCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBoxCamera.Size = new System.Drawing.Size(140, 30);
            this.NumberPlate_nvcTextBoxCamera.TabIndex = 55;
            this.NumberPlate_nvcTextBoxCamera.Tag = "";
            this.NumberPlate_nvcTextBoxCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(149, 368);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 23);
            this.label19.TabIndex = 54;
            this.label19.Text = "شماره پلاك دوربین";
            // 
            // SerialPlate_nvcTextBoxCamera
            // 
            this.SerialPlate_nvcTextBoxCamera.BackColor = System.Drawing.SystemColors.Window;
            this.SerialPlate_nvcTextBoxCamera.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBoxCamera.Location = new System.Drawing.Point(481, 364);
            this.SerialPlate_nvcTextBoxCamera.MaxLength = 2;
            this.SerialPlate_nvcTextBoxCamera.Name = "SerialPlate_nvcTextBoxCamera";
            this.SerialPlate_nvcTextBoxCamera.ReadOnly = true;
            this.SerialPlate_nvcTextBoxCamera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBoxCamera.Size = new System.Drawing.Size(53, 30);
            this.SerialPlate_nvcTextBoxCamera.TabIndex = 57;
            this.SerialPlate_nvcTextBoxCamera.Tag = "";
            this.SerialPlate_nvcTextBoxCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(406, 368);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 23);
            this.label18.TabIndex = 56;
            this.label18.Text = "سري دوربین";
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(650, 148);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(255, 240);
            this.axVLCPlugin21.TabIndex = 315;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Cam2RadioButton);
            this.groupBox6.Controls.Add(this.Cam1RadioButton);
            this.groupBox6.Location = new System.Drawing.Point(553, 50);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 90);
            this.groupBox6.TabIndex = 317;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "انتخاب دوربین";
            // 
            // Cam2RadioButton
            // 
            this.Cam2RadioButton.AutoSize = true;
            this.Cam2RadioButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cam2RadioButton.Location = new System.Drawing.Point(217, 51);
            this.Cam2RadioButton.Name = "Cam2RadioButton";
            this.Cam2RadioButton.Size = new System.Drawing.Size(109, 27);
            this.Cam2RadioButton.TabIndex = 1;
            this.Cam2RadioButton.TabStop = true;
            this.Cam2RadioButton.Text = "دوربین شماره 2";
            this.Cam2RadioButton.UseVisualStyleBackColor = true;
            this.Cam2RadioButton.CheckedChanged += new System.EventHandler(this.Cam2RadioButton_CheckedChanged);
            // 
            // Cam1RadioButton
            // 
            this.Cam1RadioButton.AutoSize = true;
            this.Cam1RadioButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cam1RadioButton.Location = new System.Drawing.Point(215, 18);
            this.Cam1RadioButton.Name = "Cam1RadioButton";
            this.Cam1RadioButton.Size = new System.Drawing.Size(110, 27);
            this.Cam1RadioButton.TabIndex = 0;
            this.Cam1RadioButton.TabStop = true;
            this.Cam1RadioButton.Text = "دوریین شماره 1";
            this.Cam1RadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cam1RadioButton.UseVisualStyleBackColor = true;
            this.Cam1RadioButton.CheckedChanged += new System.EventHandler(this.Cam1RadioButton_CheckedChanged);
            // 
            // axVLCPlugin22
            // 
            this.axVLCPlugin22.Enabled = true;
            this.axVLCPlugin22.Location = new System.Drawing.Point(650, 148);
            this.axVLCPlugin22.Name = "axVLCPlugin22";
            this.axVLCPlugin22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin22.OcxState")));
            this.axVLCPlugin22.Size = new System.Drawing.Size(255, 240);
            this.axVLCPlugin22.TabIndex = 318;
            // 
            // ActiveCameraPlateButton
            // 
            this.ActiveCameraPlateButton.Location = new System.Drawing.Point(553, 361);
            this.ActiveCameraPlateButton.Name = "ActiveCameraPlateButton";
            this.ActiveCameraPlateButton.Size = new System.Drawing.Size(88, 30);
            this.ActiveCameraPlateButton.TabIndex = 319;
            this.ActiveCameraPlateButton.Text = "فعال کردن";
            this.ActiveCameraPlateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ActiveCameraPlateButton.UseVisualStyleBackColor = true;
            this.ActiveCameraPlateButton.Click += new System.EventHandler(this.ActiveCameraPlateButton_Click);
            // 
            // TrafficOutEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 683);
            this.Controls.Add(this.ActiveCameraPlateButton);
            this.Controls.Add(this.axVLCPlugin22);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.SerialPlate_nvcTextBoxCamera);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.NumberPlate_nvcTextBoxCamera);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TrafficGridView);
            this.Controls.Add(this.NumberPlateReadingButton);
            this.Controls.Add(this.SerialPlate_nvcTextBox);
            this.Controls.Add(this.TrafficNumberTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AllOutbutton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NumberPlate_nvcTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TemporaryOutcheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.MinimizeBox = false;
            this.Name = "TrafficOutEntityForm";
            this.Text = "خروج از پایانه بار";
            this.Load += new System.EventHandler(this.TrafficOutEntityForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficOutEntityForm_KeyDown);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.TemporaryOutcheckBox, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.NumberPlate_nvcTextBox, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.AllOutbutton, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.TrafficNumberTextBox, 0);
            this.Controls.SetChildIndex(this.SerialPlate_nvcTextBox, 0);
            this.Controls.SetChildIndex(this.NumberPlateReadingButton, 0);
            this.Controls.SetChildIndex(this.TrafficGridView, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.NumberPlate_nvcTextBoxCamera, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.SerialPlate_nvcTextBoxCamera, 0);
            this.Controls.SetChildIndex(this.axVLCPlugin21, 0);
            this.Controls.SetChildIndex(this.groupBox6, 0);
            this.Controls.SetChildIndex(this.axVLCPlugin22, 0);
            this.Controls.SetChildIndex(this.ActiveCameraPlateButton, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TrafficNumber_bintlabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InTime_nvcTextBox;
        private NumericTextBox TrafficNumber_bintNumericTextBox;
        private System.Windows.Forms.TextBox InDate_nvcTextBox;
        private NumericTextBox TurnNumber_bintNumericTextBox;
        private System.Windows.Forms.TextBox PlateNo_nvcTextBox;
        private System.Windows.Forms.TextBox Car_nvcTextBox;
        private System.Windows.Forms.TextBox Driver_nvcTextBox;
        private NumericTextBox Payable_decNumericTextBox;
        private NumericTextBox Remainder_decNumericTextBox;
        private NumericTextBox Balanced_decNumericTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TemporaryOutcheckBox;
        private System.Windows.Forms.TextBox UserName_nvcTextBox;
        private System.Windows.Forms.TextBox Time_nvcTextBox;
        private System.Windows.Forms.TextBox Date_nvcTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AllOutbutton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TurnDate_nvcTextBox;
        private System.Windows.Forms.Button SearchButton;
        private NumericTextBox TrafficNumberTextBox;
        private NumericTextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.Button NumberPlateReadingButton;
        private Janus.Windows.GridEX.GridEX TrafficGridView;
        private System.Windows.Forms.TextBox textBox2;
      
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBoxCamera;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBoxCamera;
        private System.Windows.Forms.Label label18;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton Cam2RadioButton;
        private System.Windows.Forms.RadioButton Cam1RadioButton;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin22;
        private Button ActiveCameraPlateButton;
    }
}