using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.ChargePrice
{
    partial class ChargePriceEntityForm 

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
            this.DriverName_nvcLabel = new System.Windows.Forms.Label();
            this.DriverCardNumber_nvcLabel = new System.Windows.Forms.Label();
            this.Date_nvcLabel = new System.Windows.Forms.Label();
            this.Time_nvcLabel = new System.Windows.Forms.Label();
            this.UserName_nvcLabel = new System.Windows.Forms.Label();
            this.Description_nvcLabel = new System.Windows.Forms.Label();
            this.DriverID_bintLabel = new System.Windows.Forms.Label();
            this.Price_decLabel = new System.Windows.Forms.Label();
            this.DriverID_bintNewButton = new System.Windows.Forms.Button();
            this.DriverName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DriverCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Date_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Time_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UserName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Description_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DriverID_bintComboBox = new System.Windows.Forms.ComboBox();
            this.Price_decNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(518, 14);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(519, 49);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(519, 84);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(519, 117);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.DriverName_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DriverCardNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Date_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Time_nvcLabel);
            this.DetailGropBox.Controls.Add(this.UserName_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Description_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DriverID_bintLabel);
            this.DetailGropBox.Controls.Add(this.Price_decLabel);
            this.DetailGropBox.Controls.Add(this.DriverID_bintNewButton);
            this.DetailGropBox.Controls.Add(this.DriverName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.DriverCardNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Date_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Time_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.UserName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Description_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.DriverID_bintComboBox);
            this.DetailGropBox.Controls.Add(this.Price_decNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(9, 1);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(498, 394);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // DriverName_nvcLabel
            // 
            this.DriverName_nvcLabel.AutoSize = true;
            this.DriverName_nvcLabel.Location = new System.Drawing.Point(389, 67);
            this.DriverName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverName_nvcLabel.Name = "DriverName_nvcLabel";
            this.DriverName_nvcLabel.Size = new System.Drawing.Size(56, 23);
            this.DriverName_nvcLabel.TabIndex = 0;
            this.DriverName_nvcLabel.Text = "نام راننده";
            // 
            // DriverCardNumber_nvcLabel
            // 
            this.DriverCardNumber_nvcLabel.AutoSize = true;
            this.DriverCardNumber_nvcLabel.Location = new System.Drawing.Point(389, 106);
            this.DriverCardNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardNumber_nvcLabel.Name = "DriverCardNumber_nvcLabel";
            this.DriverCardNumber_nvcLabel.Size = new System.Drawing.Size(103, 23);
            this.DriverCardNumber_nvcLabel.TabIndex = 1;
            this.DriverCardNumber_nvcLabel.Text = "شماره کارت راننده";
            // 
            // Date_nvcLabel
            // 
            this.Date_nvcLabel.AutoSize = true;
            this.Date_nvcLabel.Location = new System.Drawing.Point(389, 179);
            this.Date_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Date_nvcLabel.Name = "Date_nvcLabel";
            this.Date_nvcLabel.Size = new System.Drawing.Size(37, 23);
            this.Date_nvcLabel.TabIndex = 2;
            this.Date_nvcLabel.Text = "تاریخ";
            // 
            // Time_nvcLabel
            // 
            this.Time_nvcLabel.AutoSize = true;
            this.Time_nvcLabel.Location = new System.Drawing.Point(389, 216);
            this.Time_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Time_nvcLabel.Name = "Time_nvcLabel";
            this.Time_nvcLabel.Size = new System.Drawing.Size(43, 23);
            this.Time_nvcLabel.TabIndex = 3;
            this.Time_nvcLabel.Text = "ساعت";
            // 
            // UserName_nvcLabel
            // 
            this.UserName_nvcLabel.AutoSize = true;
            this.UserName_nvcLabel.Location = new System.Drawing.Point(389, 255);
            this.UserName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserName_nvcLabel.Name = "UserName_nvcLabel";
            this.UserName_nvcLabel.Size = new System.Drawing.Size(35, 23);
            this.UserName_nvcLabel.TabIndex = 4;
            this.UserName_nvcLabel.Text = "کاربر";
            // 
            // Description_nvcLabel
            // 
            this.Description_nvcLabel.AutoSize = true;
            this.Description_nvcLabel.Location = new System.Drawing.Point(389, 294);
            this.Description_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Description_nvcLabel.Name = "Description_nvcLabel";
            this.Description_nvcLabel.Size = new System.Drawing.Size(60, 23);
            this.Description_nvcLabel.TabIndex = 5;
            this.Description_nvcLabel.Text = "توضیحات";
            // 
            // DriverID_bintLabel
            // 
            this.DriverID_bintLabel.AutoSize = true;
            this.DriverID_bintLabel.Location = new System.Drawing.Point(389, 30);
            this.DriverID_bintLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverID_bintLabel.Name = "DriverID_bintLabel";
            this.DriverID_bintLabel.Size = new System.Drawing.Size(38, 23);
            this.DriverID_bintLabel.TabIndex = 6;
            this.DriverID_bintLabel.Text = "راننده";
            // 
            // Price_decLabel
            // 
            this.Price_decLabel.AutoSize = true;
            this.Price_decLabel.Location = new System.Drawing.Point(389, 142);
            this.Price_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Price_decLabel.Name = "Price_decLabel";
            this.Price_decLabel.Size = new System.Drawing.Size(59, 23);
            this.Price_decLabel.TabIndex = 7;
            this.Price_decLabel.Text = "مبلغ شارژ";
            // 
            // DriverID_bintNewButton
            // 
            this.DriverID_bintNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.DriverID_bintNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DriverID_bintNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DriverID_bintNewButton.Location = new System.Drawing.Point(17, 27);
            this.DriverID_bintNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.DriverID_bintNewButton.Name = "DriverID_bintNewButton";
            this.DriverID_bintNewButton.Size = new System.Drawing.Size(37, 37);
            this.DriverID_bintNewButton.TabIndex = 8;
            this.DriverID_bintNewButton.TabStop = false;
            this.DriverID_bintNewButton.UseVisualStyleBackColor = true;
            this.DriverID_bintNewButton.Click += new System.EventHandler(this.DriverID_bintNewButton_Click);
            // 
            // DriverName_nvcTextBox
            // 
            this.DriverName_nvcTextBox.Location = new System.Drawing.Point(17, 64);
            this.DriverName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverName_nvcTextBox.MaxLength = 200;
            this.DriverName_nvcTextBox.Name = "DriverName_nvcTextBox";
            this.DriverName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverName_nvcTextBox.Size = new System.Drawing.Size(362, 30);
            this.DriverName_nvcTextBox.TabIndex = 1;
            this.DriverName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverCardNumber_nvcTextBox
            // 
            this.DriverCardNumber_nvcTextBox.Location = new System.Drawing.Point(17, 103);
            this.DriverCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardNumber_nvcTextBox.MaxLength = 50;
            this.DriverCardNumber_nvcTextBox.Name = "DriverCardNumber_nvcTextBox";
            this.DriverCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_nvcTextBox.Size = new System.Drawing.Size(362, 30);
            this.DriverCardNumber_nvcTextBox.TabIndex = 2;
            this.DriverCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Date_nvcTextBox
            // 
            this.Date_nvcTextBox.Location = new System.Drawing.Point(17, 176);
            this.Date_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Date_nvcTextBox.MaxLength = 10;
            this.Date_nvcTextBox.Name = "Date_nvcTextBox";
            this.Date_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_nvcTextBox.Size = new System.Drawing.Size(362, 30);
            this.Date_nvcTextBox.TabIndex = 4;
            this.Date_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Time_nvcTextBox
            // 
            this.Time_nvcTextBox.Location = new System.Drawing.Point(17, 213);
            this.Time_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Time_nvcTextBox.MaxLength = 10;
            this.Time_nvcTextBox.Name = "Time_nvcTextBox";
            this.Time_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Time_nvcTextBox.Size = new System.Drawing.Size(362, 30);
            this.Time_nvcTextBox.TabIndex = 5;
            this.Time_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserName_nvcTextBox
            // 
            this.UserName_nvcTextBox.Location = new System.Drawing.Point(17, 252);
            this.UserName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserName_nvcTextBox.MaxLength = 100;
            this.UserName_nvcTextBox.Name = "UserName_nvcTextBox";
            this.UserName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserName_nvcTextBox.Size = new System.Drawing.Size(362, 30);
            this.UserName_nvcTextBox.TabIndex = 6;
            this.UserName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Description_nvcTextBox
            // 
            this.Description_nvcTextBox.Location = new System.Drawing.Point(17, 291);
            this.Description_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Description_nvcTextBox.MaxLength = 500;
            this.Description_nvcTextBox.Multiline = true;
            this.Description_nvcTextBox.Name = "Description_nvcTextBox";
            this.Description_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Description_nvcTextBox.Size = new System.Drawing.Size(362, 88);
            this.Description_nvcTextBox.TabIndex = 7;
            this.Description_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverID_bintComboBox
            // 
            this.DriverID_bintComboBox.FormattingEnabled = true;
            this.DriverID_bintComboBox.Location = new System.Drawing.Point(57, 27);
            this.DriverID_bintComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverID_bintComboBox.Name = "DriverID_bintComboBox";
            this.DriverID_bintComboBox.Size = new System.Drawing.Size(322, 31);
            this.DriverID_bintComboBox.TabIndex = 0;
            // 
            // Price_decNumericTextBox
            // 
            this.Price_decNumericTextBox.AllowNegative = false;
            this.Price_decNumericTextBox.DigitsInGroup = 0;
            this.Price_decNumericTextBox.Flags = 65536;
            this.Price_decNumericTextBox.Location = new System.Drawing.Point(17, 139);
            this.Price_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Price_decNumericTextBox.MaxDecimalPlaces = 0;
            this.Price_decNumericTextBox.MaxWholeDigits = 155;
            this.Price_decNumericTextBox.Name = "Price_decNumericTextBox";
            this.Price_decNumericTextBox.Prefix = "";
//this.Price_decNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
           // this.Price_decNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.Price_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Price_decNumericTextBox.Size = new System.Drawing.Size(362, 30);
            this.Price_decNumericTextBox.TabIndex = 3;
            // 
            // ChargePriceEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 408);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "ChargePriceEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شارژ مالی";
            this.Load += new System.EventHandler(this.ChargePriceEntityForm_Load);
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
        
private System.Windows.Forms.Label DriverName_nvcLabel;
private System.Windows.Forms.Label DriverCardNumber_nvcLabel;
private System.Windows.Forms.Label Date_nvcLabel;
private System.Windows.Forms.Label Time_nvcLabel;
private System.Windows.Forms.Label UserName_nvcLabel;
private System.Windows.Forms.Label Description_nvcLabel;
        
private System.Windows.Forms.TextBox DriverName_nvcTextBox;
private System.Windows.Forms.TextBox DriverCardNumber_nvcTextBox;
private System.Windows.Forms.TextBox Date_nvcTextBox;
private System.Windows.Forms.TextBox Time_nvcTextBox;
private System.Windows.Forms.TextBox UserName_nvcTextBox;
private System.Windows.Forms.TextBox Description_nvcTextBox;
        
private System.Windows.Forms.Label DriverID_bintLabel;
       
private System.Windows.Forms.ComboBox DriverID_bintComboBox;
        
private System.Windows.Forms.Button DriverID_bintNewButton;
       
private System.Windows.Forms.Label Price_decLabel;
        
private NumericTextBox Price_decNumericTextBox;
        
    }
}
