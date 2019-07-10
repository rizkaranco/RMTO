using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.LaderType
{
    partial class LaderTypeEntityForm 

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
            this.TurnCancelCheckBox = new System.Windows.Forms.CheckBox();
            this.LaderTypeCode_nvcLabel = new System.Windows.Forms.Label();
            this.LaderType_nvcLabel = new System.Windows.Forms.Label();
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.MinTruckWeight_decLabel = new System.Windows.Forms.Label();
            this.MaxTruckWeight_decLabel = new System.Windows.Forms.Label();
            this.LaderPivotGroupID_intNewButton = new System.Windows.Forms.Button();
            this.LaderTypeCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LaderType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LaderPivotGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.MinTruckWeight_decNumericTextBox = new NumericTextBox();
            this.MaxTruckWeight_decNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(444, 14);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(444, 46);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(444, 79);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(444, 114);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.TurnCancelCheckBox);
            this.DetailGropBox.Controls.Add(this.LaderTypeCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LaderType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.MinTruckWeight_decLabel);
            this.DetailGropBox.Controls.Add(this.MaxTruckWeight_decLabel);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.LaderTypeCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LaderType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.MinTruckWeight_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.MaxTruckWeight_decNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(12, -1);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(421, 278);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // TurnCancelCheckBox
            // 
            this.TurnCancelCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnCancelCheckBox.Location = new System.Drawing.Point(300, 197);
            this.TurnCancelCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnCancelCheckBox.Name = "TurnCancelCheckBox";
            this.TurnCancelCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnCancelCheckBox.Size = new System.Drawing.Size(98, 30);
            this.TurnCancelCheckBox.TabIndex = 12;
            this.TurnCancelCheckBox.Text = "ابطال نوبت";
            this.TurnCancelCheckBox.UseVisualStyleBackColor = true;
            // 
            // LaderTypeCode_nvcLabel
            // 
            this.LaderTypeCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeCode_nvcLabel.AutoSize = true;
            this.LaderTypeCode_nvcLabel.Location = new System.Drawing.Point(315, 31);
            this.LaderTypeCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderTypeCode_nvcLabel.Name = "LaderTypeCode_nvcLabel";
            this.LaderTypeCode_nvcLabel.Size = new System.Drawing.Size(55, 23);
            this.LaderTypeCode_nvcLabel.TabIndex = 0;
            this.LaderTypeCode_nvcLabel.Text = "کد بارگیر";
            // 
            // LaderType_nvcLabel
            // 
            this.LaderType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderType_nvcLabel.AutoSize = true;
            this.LaderType_nvcLabel.Location = new System.Drawing.Point(315, 65);
            this.LaderType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderType_nvcLabel.Name = "LaderType_nvcLabel";
            this.LaderType_nvcLabel.Size = new System.Drawing.Size(57, 23);
            this.LaderType_nvcLabel.TabIndex = 1;
            this.LaderType_nvcLabel.Text = "نام بارگیر";
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(315, 241);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(65, 23);
            this.LaderPivotGroupID_intLabel.TabIndex = 2;
            this.LaderPivotGroupID_intLabel.Text = "تعداد محور";
            // 
            // MinTruckWeight_decLabel
            // 
            this.MinTruckWeight_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinTruckWeight_decLabel.AutoSize = true;
            this.MinTruckWeight_decLabel.Location = new System.Drawing.Point(315, 100);
            this.MinTruckWeight_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MinTruckWeight_decLabel.Name = "MinTruckWeight_decLabel";
            this.MinTruckWeight_decLabel.Size = new System.Drawing.Size(98, 23);
            this.MinTruckWeight_decLabel.TabIndex = 3;
            this.MinTruckWeight_decLabel.Text = "حداقل وزن بارگیر";
            // 
            // MaxTruckWeight_decLabel
            // 
            this.MaxTruckWeight_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTruckWeight_decLabel.AutoSize = true;
            this.MaxTruckWeight_decLabel.Location = new System.Drawing.Point(315, 135);
            this.MaxTruckWeight_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MaxTruckWeight_decLabel.Name = "MaxTruckWeight_decLabel";
            this.MaxTruckWeight_decLabel.Size = new System.Drawing.Size(101, 23);
            this.MaxTruckWeight_decLabel.TabIndex = 4;
            this.MaxTruckWeight_decLabel.Text = "حداکثر وزن بارگیر";
            // 
            // LaderPivotGroupID_intNewButton
            // 
            this.LaderPivotGroupID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.LaderPivotGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderPivotGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderPivotGroupID_intNewButton.Location = new System.Drawing.Point(11, 237);
            this.LaderPivotGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupID_intNewButton.Name = "LaderPivotGroupID_intNewButton";
            this.LaderPivotGroupID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.LaderPivotGroupID_intNewButton.TabIndex = 5;
            this.LaderPivotGroupID_intNewButton.TabStop = false;
            this.LaderPivotGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.LaderPivotGroupID_intNewButton.Click += new System.EventHandler(this.LaderPivotGroupID_intNewButton_Click);
            // 
            // LaderTypeCode_nvcTextBox
            // 
            this.LaderTypeCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeCode_nvcTextBox.Location = new System.Drawing.Point(14, 27);
            this.LaderTypeCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeCode_nvcTextBox.MaxLength = 10;
            this.LaderTypeCode_nvcTextBox.Name = "LaderTypeCode_nvcTextBox";
            this.LaderTypeCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderTypeCode_nvcTextBox.Size = new System.Drawing.Size(299, 30);
            this.LaderTypeCode_nvcTextBox.TabIndex = 6;
            this.LaderTypeCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderType_nvcTextBox
            // 
            this.LaderType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderType_nvcTextBox.Location = new System.Drawing.Point(14, 61);
            this.LaderType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderType_nvcTextBox.MaxLength = 50;
            this.LaderType_nvcTextBox.Name = "LaderType_nvcTextBox";
            this.LaderType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderType_nvcTextBox.Size = new System.Drawing.Size(299, 30);
            this.LaderType_nvcTextBox.TabIndex = 7;
            this.LaderType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderPivotGroupID_intComboBox
            // 
            this.LaderPivotGroupID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intComboBox.FormattingEnabled = true;
            this.LaderPivotGroupID_intComboBox.Location = new System.Drawing.Point(54, 237);
            this.LaderPivotGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupID_intComboBox.Name = "LaderPivotGroupID_intComboBox";
            this.LaderPivotGroupID_intComboBox.Size = new System.Drawing.Size(259, 31);
            this.LaderPivotGroupID_intComboBox.TabIndex = 8;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Active_bitCheckBox.Location = new System.Drawing.Point(300, 164);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 9;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinTruckWeight_decNumericTextBox
            // 
            this.MinTruckWeight_decNumericTextBox.AllowNegative = false;
            this.MinTruckWeight_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinTruckWeight_decNumericTextBox.DigitsInGroup = 0;
            this.MinTruckWeight_decNumericTextBox.Flags = 65536;
            this.MinTruckWeight_decNumericTextBox.Location = new System.Drawing.Point(14, 96);
            this.MinTruckWeight_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MinTruckWeight_decNumericTextBox.MaxDecimalPlaces = 0;
            this.MinTruckWeight_decNumericTextBox.MaxWholeDigits = 155;
            this.MinTruckWeight_decNumericTextBox.Name = "MinTruckWeight_decNumericTextBox";
            this.MinTruckWeight_decNumericTextBox.Prefix = "";
          //  this.MinTruckWeight_decNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
         //   this.MinTruckWeight_decNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.MinTruckWeight_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinTruckWeight_decNumericTextBox.Size = new System.Drawing.Size(299, 30);
            this.MinTruckWeight_decNumericTextBox.TabIndex = 10;
            // 
            // MaxTruckWeight_decNumericTextBox
            // 
            this.MaxTruckWeight_decNumericTextBox.AllowNegative = false;
            this.MaxTruckWeight_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTruckWeight_decNumericTextBox.DigitsInGroup = 0;
            this.MaxTruckWeight_decNumericTextBox.Flags = 65536;
            this.MaxTruckWeight_decNumericTextBox.Location = new System.Drawing.Point(14, 131);
            this.MaxTruckWeight_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MaxTruckWeight_decNumericTextBox.MaxDecimalPlaces = 0;
            this.MaxTruckWeight_decNumericTextBox.MaxWholeDigits = 155;
            this.MaxTruckWeight_decNumericTextBox.Name = "MaxTruckWeight_decNumericTextBox";
            this.MaxTruckWeight_decNumericTextBox.Prefix = "";
          //  this.MaxTruckWeight_decNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.MaxTruckWeight_decNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.MaxTruckWeight_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxTruckWeight_decNumericTextBox.Size = new System.Drawing.Size(299, 30);
            this.MaxTruckWeight_decNumericTextBox.TabIndex = 11;
            // 
            // LaderTypeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 283);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "LaderTypeEntityForm";
            this.Text = "انواع بارگیر";
            this.Load += new System.EventHandler(this.LaderTypeEntityForm_Load);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label LaderTypeCode_nvcLabel;
private System.Windows.Forms.Label LaderType_nvcLabel;
        
private System.Windows.Forms.TextBox LaderTypeCode_nvcTextBox;
private System.Windows.Forms.TextBox LaderType_nvcTextBox;
        
private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
       
private System.Windows.Forms.ComboBox LaderPivotGroupID_intComboBox;
        
private System.Windows.Forms.Button LaderPivotGroupID_intNewButton;
       
private System.Windows.Forms.Label MinTruckWeight_decLabel;
private System.Windows.Forms.Label MaxTruckWeight_decLabel;
        
private NumericTextBox MinTruckWeight_decNumericTextBox;
private NumericTextBox MaxTruckWeight_decNumericTextBox;
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
private System.Windows.Forms.CheckBox TurnCancelCheckBox;
    }
}
