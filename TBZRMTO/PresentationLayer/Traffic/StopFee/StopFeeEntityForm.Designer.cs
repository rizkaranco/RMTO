using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.StopFee
{
    partial class StopFeeEntityForm 

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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TurnNotLadBillExtraHour_intTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.TurnNotLadBillExtraHourFee_decTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tax_bitcheckBox = new System.Windows.Forms.CheckBox();
            this.AllowedHoure_intNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.Fee_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.ExtraHour_intNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.WithLadeExtraHourFee_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.ExtraHourFee_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.EndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartDate_nvcLabel = new System.Windows.Forms.Label();
            this.EndDate_nvcLabel = new System.Windows.Forms.Label();
            this.TrafficTypeID_intLabel = new System.Windows.Forms.Label();
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.ServicesID_intLabel = new System.Windows.Forms.Label();
            this.AllowedHoure_intLabel = new System.Windows.Forms.Label();
            this.Fee_decLabel = new System.Windows.Forms.Label();
            this.ExtraHour_intLabel = new System.Windows.Forms.Label();
            this.ExtraHourFee_decLabel = new System.Windows.Forms.Label();
            this.WithLadeExtraHourFee_decLabel = new System.Windows.Forms.Label();
            this.TrafficTypeID_intNewButton = new System.Windows.Forms.Button();
            this.LaderPivotGroupID_intNewButton = new System.Windows.Forms.Button();
            this.ServicesID_intNewButton = new System.Windows.Forms.Button();
            this.TrafficTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LaderPivotGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.ServicesID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(539, 17);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(539, 48);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(539, 79);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(539, 110);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.checkBox1);
            this.DetailGropBox.Controls.Add(this.TurnNotLadBillExtraHour_intTextBox);
            this.DetailGropBox.Controls.Add(this.TurnNotLadBillExtraHourFee_decTextBox);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.label2);
            this.DetailGropBox.Controls.Add(this.Tax_bitcheckBox);
            this.DetailGropBox.Controls.Add(this.AllowedHoure_intNumericTextBox);
            this.DetailGropBox.Controls.Add(this.Fee_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.ExtraHour_intNumericTextBox);
            this.DetailGropBox.Controls.Add(this.WithLadeExtraHourFee_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.ExtraHourFee_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.EndDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.StartDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.StartDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.EndDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.TrafficTypeID_intLabel);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.ServicesID_intLabel);
            this.DetailGropBox.Controls.Add(this.AllowedHoure_intLabel);
            this.DetailGropBox.Controls.Add(this.Fee_decLabel);
            this.DetailGropBox.Controls.Add(this.ExtraHour_intLabel);
            this.DetailGropBox.Controls.Add(this.ExtraHourFee_decLabel);
            this.DetailGropBox.Controls.Add(this.WithLadeExtraHourFee_decLabel);
            this.DetailGropBox.Controls.Add(this.TrafficTypeID_intNewButton);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.ServicesID_intNewButton);
            this.DetailGropBox.Controls.Add(this.TrafficTypeID_intComboBox);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.ServicesID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(3, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(523, 470);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 716);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 27);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "ارزش افزوده";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TurnNotLadBillExtraHour_intTextBox
            // 
            this.TurnNotLadBillExtraHour_intTextBox.AllowNegative = false;
            this.TurnNotLadBillExtraHour_intTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnNotLadBillExtraHour_intTextBox.DigitsInGroup = 0;
            this.TurnNotLadBillExtraHour_intTextBox.Flags = 65536;
            this.TurnNotLadBillExtraHour_intTextBox.Location = new System.Drawing.Point(8, 374);
            this.TurnNotLadBillExtraHour_intTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnNotLadBillExtraHour_intTextBox.MaxDecimalPlaces = 0;
            this.TurnNotLadBillExtraHour_intTextBox.MaxWholeDigits = 155;
            this.TurnNotLadBillExtraHour_intTextBox.Name = "TurnNotLadBillExtraHour_intTextBox";
            this.TurnNotLadBillExtraHour_intTextBox.Prefix = "";
            this.TurnNotLadBillExtraHour_intTextBox.RangeMax = 0D;
            this.TurnNotLadBillExtraHour_intTextBox.RangeMin = 0D;
            this.TurnNotLadBillExtraHour_intTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnNotLadBillExtraHour_intTextBox.Size = new System.Drawing.Size(331, 30);
            this.TurnNotLadBillExtraHour_intTextBox.TabIndex = 14;
            // 
            // TurnNotLadBillExtraHourFee_decTextBox
            // 
            this.TurnNotLadBillExtraHourFee_decTextBox.AllowNegative = false;
            this.TurnNotLadBillExtraHourFee_decTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnNotLadBillExtraHourFee_decTextBox.DigitsInGroup = 3;
            this.TurnNotLadBillExtraHourFee_decTextBox.Flags = 65536;
            this.TurnNotLadBillExtraHourFee_decTextBox.Location = new System.Drawing.Point(9, 408);
            this.TurnNotLadBillExtraHourFee_decTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnNotLadBillExtraHourFee_decTextBox.MaxDecimalPlaces = 0;
            this.TurnNotLadBillExtraHourFee_decTextBox.MaxWholeDigits = 155;
            this.TurnNotLadBillExtraHourFee_decTextBox.Name = "TurnNotLadBillExtraHourFee_decTextBox";
            this.TurnNotLadBillExtraHourFee_decTextBox.Prefix = "";
            this.TurnNotLadBillExtraHourFee_decTextBox.RangeMax = 0D;
            this.TurnNotLadBillExtraHourFee_decTextBox.RangeMin = 0D;
            this.TurnNotLadBillExtraHourFee_decTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnNotLadBillExtraHourFee_decTextBox.Size = new System.Drawing.Size(331, 30);
            this.TurnNotLadBillExtraHourFee_decTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "ساعت مجاز نوبت بدون مجوز";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "مبلغ اضافه ساعت نوبت بدون مجوز";
            // 
            // Tax_bitcheckBox
            // 
            this.Tax_bitcheckBox.AutoSize = true;
            this.Tax_bitcheckBox.Location = new System.Drawing.Point(247, 443);
            this.Tax_bitcheckBox.Name = "Tax_bitcheckBox";
            this.Tax_bitcheckBox.Size = new System.Drawing.Size(94, 27);
            this.Tax_bitcheckBox.TabIndex = 13;
            this.Tax_bitcheckBox.Text = "ارزش افزوده";
            this.Tax_bitcheckBox.UseVisualStyleBackColor = true;
            // 
            // AllowedHoure_intNumericTextBox
            // 
            this.AllowedHoure_intNumericTextBox.AllowNegative = false;
            this.AllowedHoure_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowedHoure_intNumericTextBox.DigitsInGroup = 0;
            this.AllowedHoure_intNumericTextBox.Flags = 65536;
            this.AllowedHoure_intNumericTextBox.Location = new System.Drawing.Point(8, 31);
            this.AllowedHoure_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.AllowedHoure_intNumericTextBox.MaxDecimalPlaces = 0;
            this.AllowedHoure_intNumericTextBox.MaxWholeDigits = 155;
            this.AllowedHoure_intNumericTextBox.Name = "AllowedHoure_intNumericTextBox";
            this.AllowedHoure_intNumericTextBox.Prefix = "";
            this.AllowedHoure_intNumericTextBox.RangeMax = 0D;
            this.AllowedHoure_intNumericTextBox.RangeMin = 0D;
            this.AllowedHoure_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllowedHoure_intNumericTextBox.Size = new System.Drawing.Size(331, 30);
            this.AllowedHoure_intNumericTextBox.TabIndex = 0;
            // 
            // Fee_decNumericTextBox
            // 
            this.Fee_decNumericTextBox.AllowNegative = false;
            this.Fee_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fee_decNumericTextBox.DigitsInGroup = 3;
            this.Fee_decNumericTextBox.Flags = 65536;
            this.Fee_decNumericTextBox.Location = new System.Drawing.Point(8, 65);
            this.Fee_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Fee_decNumericTextBox.MaxDecimalPlaces = 0;
            this.Fee_decNumericTextBox.MaxWholeDigits = 155;
            this.Fee_decNumericTextBox.Name = "Fee_decNumericTextBox";
            this.Fee_decNumericTextBox.Prefix = "";
            this.Fee_decNumericTextBox.RangeMax = 0D;
            this.Fee_decNumericTextBox.RangeMin = 0D;
            this.Fee_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fee_decNumericTextBox.Size = new System.Drawing.Size(331, 30);
            this.Fee_decNumericTextBox.TabIndex = 1;
            // 
            // ExtraHour_intNumericTextBox
            // 
            this.ExtraHour_intNumericTextBox.AllowNegative = false;
            this.ExtraHour_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraHour_intNumericTextBox.DigitsInGroup = 0;
            this.ExtraHour_intNumericTextBox.Flags = 65536;
            this.ExtraHour_intNumericTextBox.Location = new System.Drawing.Point(8, 99);
            this.ExtraHour_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ExtraHour_intNumericTextBox.MaxDecimalPlaces = 0;
            this.ExtraHour_intNumericTextBox.MaxWholeDigits = 155;
            this.ExtraHour_intNumericTextBox.Name = "ExtraHour_intNumericTextBox";
            this.ExtraHour_intNumericTextBox.Prefix = "";
            this.ExtraHour_intNumericTextBox.RangeMax = 0D;
            this.ExtraHour_intNumericTextBox.RangeMin = 0D;
            this.ExtraHour_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExtraHour_intNumericTextBox.Size = new System.Drawing.Size(331, 30);
            this.ExtraHour_intNumericTextBox.TabIndex = 2;
            // 
            // WithLadeExtraHourFee_decNumericTextBox
            // 
            this.WithLadeExtraHourFee_decNumericTextBox.AllowNegative = false;
            this.WithLadeExtraHourFee_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WithLadeExtraHourFee_decNumericTextBox.DigitsInGroup = 4;
            this.WithLadeExtraHourFee_decNumericTextBox.Flags = 65536;
            this.WithLadeExtraHourFee_decNumericTextBox.Location = new System.Drawing.Point(8, 167);
            this.WithLadeExtraHourFee_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.WithLadeExtraHourFee_decNumericTextBox.MaxDecimalPlaces = 0;
            this.WithLadeExtraHourFee_decNumericTextBox.MaxWholeDigits = 155;
            this.WithLadeExtraHourFee_decNumericTextBox.Name = "WithLadeExtraHourFee_decNumericTextBox";
            this.WithLadeExtraHourFee_decNumericTextBox.Prefix = "";
            this.WithLadeExtraHourFee_decNumericTextBox.RangeMax = 0D;
            this.WithLadeExtraHourFee_decNumericTextBox.RangeMin = 0D;
            this.WithLadeExtraHourFee_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WithLadeExtraHourFee_decNumericTextBox.Size = new System.Drawing.Size(331, 30);
            this.WithLadeExtraHourFee_decNumericTextBox.TabIndex = 4;
            // 
            // ExtraHourFee_decNumericTextBox
            // 
            this.ExtraHourFee_decNumericTextBox.AllowNegative = false;
            this.ExtraHourFee_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraHourFee_decNumericTextBox.DigitsInGroup = 3;
            this.ExtraHourFee_decNumericTextBox.Flags = 65536;
            this.ExtraHourFee_decNumericTextBox.Location = new System.Drawing.Point(8, 133);
            this.ExtraHourFee_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ExtraHourFee_decNumericTextBox.MaxDecimalPlaces = 0;
            this.ExtraHourFee_decNumericTextBox.MaxWholeDigits = 155;
            this.ExtraHourFee_decNumericTextBox.Name = "ExtraHourFee_decNumericTextBox";
            this.ExtraHourFee_decNumericTextBox.Prefix = "";
            this.ExtraHourFee_decNumericTextBox.RangeMax = 0D;
            this.ExtraHourFee_decNumericTextBox.RangeMin = 0D;
            this.ExtraHourFee_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExtraHourFee_decNumericTextBox.Size = new System.Drawing.Size(331, 30);
            this.ExtraHourFee_decNumericTextBox.TabIndex = 3;
            // 
            // EndDate_nvcTextBox
            // 
            this.EndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDate_nvcTextBox.Location = new System.Drawing.Point(9, 340);
            this.EndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EndDate_nvcTextBox.Mask = "0000/00/00";
            this.EndDate_nvcTextBox.Name = "EndDate_nvcTextBox";
            this.EndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDate_nvcTextBox.Size = new System.Drawing.Size(331, 30);
            this.EndDate_nvcTextBox.TabIndex = 9;
            // 
            // StartDate_nvcTextBox
            // 
            this.StartDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDate_nvcTextBox.Location = new System.Drawing.Point(9, 306);
            this.StartDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StartDate_nvcTextBox.Mask = "0000/00/00";
            this.StartDate_nvcTextBox.Name = "StartDate_nvcTextBox";
            this.StartDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDate_nvcTextBox.Size = new System.Drawing.Size(331, 30);
            this.StartDate_nvcTextBox.TabIndex = 8;
            // 
            // StartDate_nvcLabel
            // 
            this.StartDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDate_nvcLabel.AutoSize = true;
            this.StartDate_nvcLabel.Location = new System.Drawing.Point(345, 307);
            this.StartDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartDate_nvcLabel.Name = "StartDate_nvcLabel";
            this.StartDate_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.StartDate_nvcLabel.TabIndex = 0;
            this.StartDate_nvcLabel.Text = "از تاریخ";
            // 
            // EndDate_nvcLabel
            // 
            this.EndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDate_nvcLabel.AutoSize = true;
            this.EndDate_nvcLabel.Location = new System.Drawing.Point(345, 341);
            this.EndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EndDate_nvcLabel.Name = "EndDate_nvcLabel";
            this.EndDate_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.EndDate_nvcLabel.TabIndex = 1;
            this.EndDate_nvcLabel.Text = "تا تاریخ";
            // 
            // TrafficTypeID_intLabel
            // 
            this.TrafficTypeID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficTypeID_intLabel.AutoSize = true;
            this.TrafficTypeID_intLabel.Location = new System.Drawing.Point(345, 208);
            this.TrafficTypeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TrafficTypeID_intLabel.Name = "TrafficTypeID_intLabel";
            this.TrafficTypeID_intLabel.Size = new System.Drawing.Size(53, 23);
            this.TrafficTypeID_intLabel.TabIndex = 4;
            this.TrafficTypeID_intLabel.Text = "نوع تردد";
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(345, 239);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(68, 23);
            this.LaderPivotGroupID_intLabel.TabIndex = 5;
            this.LaderPivotGroupID_intLabel.Text = "محور بارگیر";
            // 
            // ServicesID_intLabel
            // 
            this.ServicesID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesID_intLabel.AutoSize = true;
            this.ServicesID_intLabel.Location = new System.Drawing.Point(345, 273);
            this.ServicesID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ServicesID_intLabel.Name = "ServicesID_intLabel";
            this.ServicesID_intLabel.Size = new System.Drawing.Size(59, 23);
            this.ServicesID_intLabel.TabIndex = 6;
            this.ServicesID_intLabel.Text = "مراجعه به";
            // 
            // AllowedHoure_intLabel
            // 
            this.AllowedHoure_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowedHoure_intLabel.AutoSize = true;
            this.AllowedHoure_intLabel.Location = new System.Drawing.Point(345, 35);
            this.AllowedHoure_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AllowedHoure_intLabel.Name = "AllowedHoure_intLabel";
            this.AllowedHoure_intLabel.Size = new System.Drawing.Size(70, 23);
            this.AllowedHoure_intLabel.TabIndex = 7;
            this.AllowedHoure_intLabel.Text = "ساعت مجاز";
            // 
            // Fee_decLabel
            // 
            this.Fee_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fee_decLabel.AutoSize = true;
            this.Fee_decLabel.Location = new System.Drawing.Point(345, 69);
            this.Fee_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Fee_decLabel.Name = "Fee_decLabel";
            this.Fee_decLabel.Size = new System.Drawing.Size(38, 23);
            this.Fee_decLabel.TabIndex = 8;
            this.Fee_decLabel.Text = "هزینه";
            // 
            // ExtraHour_intLabel
            // 
            this.ExtraHour_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraHour_intLabel.AutoSize = true;
            this.ExtraHour_intLabel.Location = new System.Drawing.Point(345, 103);
            this.ExtraHour_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ExtraHour_intLabel.Name = "ExtraHour_intLabel";
            this.ExtraHour_intLabel.Size = new System.Drawing.Size(75, 23);
            this.ExtraHour_intLabel.TabIndex = 9;
            this.ExtraHour_intLabel.Text = "اضافه ساعت";
            // 
            // ExtraHourFee_decLabel
            // 
            this.ExtraHourFee_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraHourFee_decLabel.AutoSize = true;
            this.ExtraHourFee_decLabel.Location = new System.Drawing.Point(345, 137);
            this.ExtraHourFee_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ExtraHourFee_decLabel.Name = "ExtraHourFee_decLabel";
            this.ExtraHourFee_decLabel.Size = new System.Drawing.Size(106, 23);
            this.ExtraHourFee_decLabel.TabIndex = 10;
            this.ExtraHourFee_decLabel.Text = "هزینه اضافه ساعت";
            // 
            // WithLadeExtraHourFee_decLabel
            // 
            this.WithLadeExtraHourFee_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WithLadeExtraHourFee_decLabel.AutoSize = true;
            this.WithLadeExtraHourFee_decLabel.Location = new System.Drawing.Point(345, 171);
            this.WithLadeExtraHourFee_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WithLadeExtraHourFee_decLabel.Name = "WithLadeExtraHourFee_decLabel";
            this.WithLadeExtraHourFee_decLabel.Size = new System.Drawing.Size(131, 23);
            this.WithLadeExtraHourFee_decLabel.TabIndex = 11;
            this.WithLadeExtraHourFee_decLabel.Text = "هزينه اضافه ساعت با بار";
            // 
            // TrafficTypeID_intNewButton
            // 
            this.TrafficTypeID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficTypeID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.TrafficTypeID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TrafficTypeID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TrafficTypeID_intNewButton.Location = new System.Drawing.Point(8, 201);
            this.TrafficTypeID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficTypeID_intNewButton.Name = "TrafficTypeID_intNewButton";
            this.TrafficTypeID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.TrafficTypeID_intNewButton.TabIndex = 10;
            this.TrafficTypeID_intNewButton.TabStop = false;
            this.TrafficTypeID_intNewButton.UseVisualStyleBackColor = true;
            this.TrafficTypeID_intNewButton.Click += new System.EventHandler(this.TrafficTypeID_intNewButton_Click);
            // 
            // LaderPivotGroupID_intNewButton
            // 
            this.LaderPivotGroupID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.LaderPivotGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderPivotGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderPivotGroupID_intNewButton.Location = new System.Drawing.Point(8, 235);
            this.LaderPivotGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupID_intNewButton.Name = "LaderPivotGroupID_intNewButton";
            this.LaderPivotGroupID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.LaderPivotGroupID_intNewButton.TabIndex = 11;
            this.LaderPivotGroupID_intNewButton.TabStop = false;
            this.LaderPivotGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.LaderPivotGroupID_intNewButton.Click += new System.EventHandler(this.LaderPivotGroupID_intNewButton_Click);
            // 
            // ServicesID_intNewButton
            // 
            this.ServicesID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.ServicesID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ServicesID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ServicesID_intNewButton.Location = new System.Drawing.Point(8, 271);
            this.ServicesID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.ServicesID_intNewButton.Name = "ServicesID_intNewButton";
            this.ServicesID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.ServicesID_intNewButton.TabIndex = 12;
            this.ServicesID_intNewButton.TabStop = false;
            this.ServicesID_intNewButton.UseVisualStyleBackColor = true;
            this.ServicesID_intNewButton.Click += new System.EventHandler(this.ServicesID_intNewButton_Click);
            // 
            // TrafficTypeID_intComboBox
            // 
            this.TrafficTypeID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficTypeID_intComboBox.FormattingEnabled = true;
            this.TrafficTypeID_intComboBox.Location = new System.Drawing.Point(49, 201);
            this.TrafficTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficTypeID_intComboBox.Name = "TrafficTypeID_intComboBox";
            this.TrafficTypeID_intComboBox.Size = new System.Drawing.Size(290, 31);
            this.TrafficTypeID_intComboBox.TabIndex = 5;
            // 
            // LaderPivotGroupID_intComboBox
            // 
            this.LaderPivotGroupID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intComboBox.FormattingEnabled = true;
            this.LaderPivotGroupID_intComboBox.Location = new System.Drawing.Point(48, 236);
            this.LaderPivotGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupID_intComboBox.Name = "LaderPivotGroupID_intComboBox";
            this.LaderPivotGroupID_intComboBox.Size = new System.Drawing.Size(291, 31);
            this.LaderPivotGroupID_intComboBox.TabIndex = 6;
            // 
            // ServicesID_intComboBox
            // 
            this.ServicesID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesID_intComboBox.FormattingEnabled = true;
            this.ServicesID_intComboBox.Location = new System.Drawing.Point(48, 271);
            this.ServicesID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServicesID_intComboBox.Name = "ServicesID_intComboBox";
            this.ServicesID_intComboBox.Size = new System.Drawing.Size(291, 31);
            this.ServicesID_intComboBox.TabIndex = 7;
            // 
            // StopFeeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 486);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "StopFeeEntityForm";
            this.Text = "حق پارکینگ";
            this.Load += new System.EventHandler(this.StopFeeEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label StartDate_nvcLabel;
private System.Windows.Forms.Label EndDate_nvcLabel;
        
private System.Windows.Forms.Label TrafficTypeID_intLabel;
private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
private System.Windows.Forms.Label ServicesID_intLabel;
       
private System.Windows.Forms.ComboBox TrafficTypeID_intComboBox;
private System.Windows.Forms.ComboBox LaderPivotGroupID_intComboBox;
private System.Windows.Forms.ComboBox ServicesID_intComboBox;
        
private System.Windows.Forms.Button TrafficTypeID_intNewButton;
private System.Windows.Forms.Button LaderPivotGroupID_intNewButton;
private System.Windows.Forms.Button ServicesID_intNewButton;
       
private System.Windows.Forms.Label AllowedHoure_intLabel;
private System.Windows.Forms.Label Fee_decLabel;
private System.Windows.Forms.Label ExtraHour_intLabel;
private System.Windows.Forms.Label ExtraHourFee_decLabel;
private System.Windows.Forms.Label WithLadeExtraHourFee_decLabel;
private System.Windows.Forms.MaskedTextBox EndDate_nvcTextBox;
private System.Windows.Forms.MaskedTextBox StartDate_nvcTextBox;
private NumericTextBox AllowedHoure_intNumericTextBox;
private NumericTextBox Fee_decNumericTextBox;
private NumericTextBox ExtraHour_intNumericTextBox;
private NumericTextBox WithLadeExtraHourFee_decNumericTextBox;
private NumericTextBox ExtraHourFee_decNumericTextBox;
private System.Windows.Forms.CheckBox Tax_bitcheckBox;
        private CheckBox checkBox1;
        private NumericTextBox TurnNotLadBillExtraHour_intTextBox;
        private NumericTextBox TurnNotLadBillExtraHourFee_decTextBox;
        private Label label1;
        private Label label2;
    }
}
