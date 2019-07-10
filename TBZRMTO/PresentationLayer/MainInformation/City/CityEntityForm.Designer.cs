using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.City
{
    partial class CityEntityForm 

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
            this.CityCode_nvcLabel = new System.Windows.Forms.Label();
            this.City_nvcLabel = new System.Windows.Forms.Label();
            this.TravelTime_intLabel = new System.Windows.Forms.Label();
            this.CityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.City_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.TravelTime_intNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(444, 17);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(444, 50);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(444, 84);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(444, 121);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.CityCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.City_nvcLabel);
            this.DetailGropBox.Controls.Add(this.TravelTime_intLabel);
            this.DetailGropBox.Controls.Add(this.CityCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.City_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.TravelTime_intNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(424, 179);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // CityCode_nvcLabel
            // 
            this.CityCode_nvcLabel.AutoSize = true;
            this.CityCode_nvcLabel.Location = new System.Drawing.Point(345, 29);
            this.CityCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityCode_nvcLabel.Name = "CityCode_nvcLabel";
            this.CityCode_nvcLabel.Size = new System.Drawing.Size(50, 23);
            this.CityCode_nvcLabel.TabIndex = 0;
            this.CityCode_nvcLabel.Text = "کد شهر";
            // 
            // City_nvcLabel
            // 
            this.City_nvcLabel.AutoSize = true;
            this.City_nvcLabel.Location = new System.Drawing.Point(345, 68);
            this.City_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.City_nvcLabel.Name = "City_nvcLabel";
            this.City_nvcLabel.Size = new System.Drawing.Size(52, 23);
            this.City_nvcLabel.TabIndex = 1;
            this.City_nvcLabel.Text = "نام شهر";
            // 
            // TravelTime_intLabel
            // 
            this.TravelTime_intLabel.AutoSize = true;
            this.TravelTime_intLabel.Location = new System.Drawing.Point(345, 106);
            this.TravelTime_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TravelTime_intLabel.Name = "TravelTime_intLabel";
            this.TravelTime_intLabel.Size = new System.Drawing.Size(59, 23);
            this.TravelTime_intLabel.TabIndex = 2;
            this.TravelTime_intLabel.Text = "مدت سفر";
            // 
            // CityCode_nvcTextBox
            // 
            this.CityCode_nvcTextBox.Location = new System.Drawing.Point(13, 27);
            this.CityCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityCode_nvcTextBox.MaxLength = 10;
            this.CityCode_nvcTextBox.Name = "CityCode_nvcTextBox";
            this.CityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityCode_nvcTextBox.Size = new System.Drawing.Size(326, 30);
            this.CityCode_nvcTextBox.TabIndex = 3;
            this.CityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // City_nvcTextBox
            // 
            this.City_nvcTextBox.Location = new System.Drawing.Point(13, 66);
            this.City_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.City_nvcTextBox.MaxLength = 70;
            this.City_nvcTextBox.Name = "City_nvcTextBox";
            this.City_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.City_nvcTextBox.Size = new System.Drawing.Size(326, 30);
            this.City_nvcTextBox.TabIndex = 4;
            this.City_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Location = new System.Drawing.Point(324, 142);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(72, 30);
            this.Active_bitCheckBox.TabIndex = 5;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // TravelTime_intNumericTextBox
            // 
            this.TravelTime_intNumericTextBox.AllowNegative = false;
            this.TravelTime_intNumericTextBox.DigitsInGroup = 0;
            this.TravelTime_intNumericTextBox.Flags = 65536;
            this.TravelTime_intNumericTextBox.Location = new System.Drawing.Point(13, 104);
            this.TravelTime_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TravelTime_intNumericTextBox.MaxDecimalPlaces = 0;
            this.TravelTime_intNumericTextBox.MaxWholeDigits = 155;
            this.TravelTime_intNumericTextBox.Name = "TravelTime_intNumericTextBox";
            this.TravelTime_intNumericTextBox.Prefix = "";
          //  this.TravelTime_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
          //  this.TravelTime_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.TravelTime_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TravelTime_intNumericTextBox.Size = new System.Drawing.Size(326, 30);
            this.TravelTime_intNumericTextBox.TabIndex = 6;
            // 
            // CityEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 194);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "CityEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شهر";
            this.Load += new System.EventHandler(this.CityEntityForm_Load);
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
        
private System.Windows.Forms.Label CityCode_nvcLabel;
private System.Windows.Forms.Label City_nvcLabel;
        
private System.Windows.Forms.TextBox CityCode_nvcTextBox;
private System.Windows.Forms.TextBox City_nvcTextBox;
        
       
        
       
private System.Windows.Forms.Label TravelTime_intLabel;
        
private NumericTextBox TravelTime_intNumericTextBox;
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
    }
}
