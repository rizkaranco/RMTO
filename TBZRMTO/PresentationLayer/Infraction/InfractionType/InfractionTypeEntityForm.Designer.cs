using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.InfractionType
{
    partial class InfractionTypeEntityForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionTypeEntityForm));
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.InfractionGroupID_intLabel = new System.Windows.Forms.Label();
            this.InfractionGroupID_intNewButton = new System.Windows.Forms.Button();
            this.InfractionGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.InfractionType_nvcLabel = new System.Windows.Forms.Label();
            this.InfractionSurveyGroupID_intLabel = new System.Windows.Forms.Label();
            this.PenaltyFee_decLabel = new System.Windows.Forms.Label();
            this.InfractionSurveyGroupID_intNewButton = new System.Windows.Forms.Button();
            this.InfractionType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.InfractionSurveyGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.PenaltyFee_decNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(537, 22);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(537, 55);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(537, 88);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(537, 122);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.InfractionGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.InfractionType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.InfractionSurveyGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.PenaltyFee_decLabel);
            this.DetailGropBox.Controls.Add(this.InfractionSurveyGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.InfractionType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.InfractionSurveyGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.PenaltyFee_decNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 5);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(513, 212);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // InfractionGroupID_intLabel
            // 
            this.InfractionGroupID_intLabel.AutoSize = true;
            this.InfractionGroupID_intLabel.Location = new System.Drawing.Point(397, 32);
            this.InfractionGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionGroupID_intLabel.Name = "InfractionGroupID_intLabel";
            this.InfractionGroupID_intLabel.Size = new System.Drawing.Size(67, 23);
            this.InfractionGroupID_intLabel.TabIndex = 7;
            this.InfractionGroupID_intLabel.Text = "گروه تخلف";
            // 
            // InfractionGroupID_intNewButton
            // 
            this.InfractionGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.InfractionGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfractionGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfractionGroupID_intNewButton.Image = ((System.Drawing.Image)(resources.GetObject("InfractionGroupID_intNewButton.Image")));
            this.InfractionGroupID_intNewButton.Location = new System.Drawing.Point(17, 23);
            this.InfractionGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intNewButton.Name = "InfractionGroupID_intNewButton";
            this.InfractionGroupID_intNewButton.Size = new System.Drawing.Size(37, 37);
            this.InfractionGroupID_intNewButton.TabIndex = 1;
            this.InfractionGroupID_intNewButton.TabStop = false;
            this.InfractionGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.InfractionGroupID_intNewButton.Click += new System.EventHandler(this.InfractionGroupID_intNewButton_Click);
            // 
            // InfractionGroupID_intComboBox
            // 
            this.InfractionGroupID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.InfractionGroupID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.InfractionGroupID_intComboBox.FormattingEnabled = true;
            this.InfractionGroupID_intComboBox.Location = new System.Drawing.Point(57, 23);
            this.InfractionGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intComboBox.Name = "InfractionGroupID_intComboBox";
            this.InfractionGroupID_intComboBox.Size = new System.Drawing.Size(335, 31);
            this.InfractionGroupID_intComboBox.TabIndex = 0;
            // 
            // InfractionType_nvcLabel
            // 
            this.InfractionType_nvcLabel.AutoSize = true;
            this.InfractionType_nvcLabel.Location = new System.Drawing.Point(397, 67);
            this.InfractionType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionType_nvcLabel.Name = "InfractionType_nvcLabel";
            this.InfractionType_nvcLabel.Size = new System.Drawing.Size(59, 23);
            this.InfractionType_nvcLabel.TabIndex = 9;
            this.InfractionType_nvcLabel.Text = "نوع تخلف";
            // 
            // InfractionSurveyGroupID_intLabel
            // 
            this.InfractionSurveyGroupID_intLabel.AutoSize = true;
            this.InfractionSurveyGroupID_intLabel.Location = new System.Drawing.Point(397, 102);
            this.InfractionSurveyGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionSurveyGroupID_intLabel.Name = "InfractionSurveyGroupID_intLabel";
            this.InfractionSurveyGroupID_intLabel.Size = new System.Drawing.Size(114, 23);
            this.InfractionSurveyGroupID_intLabel.TabIndex = 10;
            this.InfractionSurveyGroupID_intLabel.Text = "گروه بررسی تخلفات";
            // 
            // PenaltyFee_decLabel
            // 
            this.PenaltyFee_decLabel.AutoSize = true;
            this.PenaltyFee_decLabel.Location = new System.Drawing.Point(397, 137);
            this.PenaltyFee_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PenaltyFee_decLabel.Name = "PenaltyFee_decLabel";
            this.PenaltyFee_decLabel.Size = new System.Drawing.Size(67, 23);
            this.PenaltyFee_decLabel.TabIndex = 11;
            this.PenaltyFee_decLabel.Text = "مبلغ جریمه";
            // 
            // InfractionSurveyGroupID_intNewButton
            // 
            this.InfractionSurveyGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.InfractionSurveyGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfractionSurveyGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfractionSurveyGroupID_intNewButton.Image = ((System.Drawing.Image)(resources.GetObject("InfractionSurveyGroupID_intNewButton.Image")));
            this.InfractionSurveyGroupID_intNewButton.Location = new System.Drawing.Point(17, 95);
            this.InfractionSurveyGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionSurveyGroupID_intNewButton.Name = "InfractionSurveyGroupID_intNewButton";
            this.InfractionSurveyGroupID_intNewButton.Size = new System.Drawing.Size(37, 37);
            this.InfractionSurveyGroupID_intNewButton.TabIndex = 4;
            this.InfractionSurveyGroupID_intNewButton.TabStop = false;
            this.InfractionSurveyGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.InfractionSurveyGroupID_intNewButton.Click += new System.EventHandler(this.InfractionSurveyGroupID_intNewButton_Click);
            // 
            // InfractionType_nvcTextBox
            // 
            this.InfractionType_nvcTextBox.Location = new System.Drawing.Point(17, 61);
            this.InfractionType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionType_nvcTextBox.MaxLength = 50;
            this.InfractionType_nvcTextBox.Name = "InfractionType_nvcTextBox";
            this.InfractionType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfractionType_nvcTextBox.Size = new System.Drawing.Size(375, 30);
            this.InfractionType_nvcTextBox.TabIndex = 2;
            this.InfractionType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InfractionSurveyGroupID_intComboBox
            // 
            this.InfractionSurveyGroupID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.InfractionSurveyGroupID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.InfractionSurveyGroupID_intComboBox.FormattingEnabled = true;
            this.InfractionSurveyGroupID_intComboBox.Location = new System.Drawing.Point(57, 98);
            this.InfractionSurveyGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionSurveyGroupID_intComboBox.Name = "InfractionSurveyGroupID_intComboBox";
            this.InfractionSurveyGroupID_intComboBox.Size = new System.Drawing.Size(335, 31);
            this.InfractionSurveyGroupID_intComboBox.TabIndex = 3;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Location = new System.Drawing.Point(381, 172);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 6;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // PenaltyFee_decNumericTextBox
            // 
            this.PenaltyFee_decNumericTextBox.AllowNegative = false;
            this.PenaltyFee_decNumericTextBox.DigitsInGroup = 3;
            this.PenaltyFee_decNumericTextBox.Flags = 65536;
            this.PenaltyFee_decNumericTextBox.Location = new System.Drawing.Point(17, 136);
            this.PenaltyFee_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PenaltyFee_decNumericTextBox.MaxDecimalPlaces = 0;
            this.PenaltyFee_decNumericTextBox.MaxWholeDigits = 155;
            this.PenaltyFee_decNumericTextBox.Name = "PenaltyFee_decNumericTextBox";
            this.PenaltyFee_decNumericTextBox.Prefix = "";
           // this.PenaltyFee_decNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
           // this.PenaltyFee_decNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.PenaltyFee_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PenaltyFee_decNumericTextBox.Size = new System.Drawing.Size(375, 30);
            this.PenaltyFee_decNumericTextBox.TabIndex = 5;
            // 
            // InfractionTypeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 227);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "InfractionTypeEntityForm";
            this.Text = "انواع تخلف";
            this.Load += new System.EventHandler(this.InfractionTypeEntityForm_Load);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;

        private System.Windows.Forms.Label InfractionType_nvcLabel;

        private System.Windows.Forms.TextBox InfractionType_nvcTextBox;
        private System.Windows.Forms.Label InfractionSurveyGroupID_intLabel;
        private System.Windows.Forms.ComboBox InfractionSurveyGroupID_intComboBox;
private System.Windows.Forms.Button InfractionSurveyGroupID_intNewButton;
       
private System.Windows.Forms.Label PenaltyFee_decLabel;
        
private NumericTextBox PenaltyFee_decNumericTextBox;
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
private System.Windows.Forms.Label InfractionGroupID_intLabel;
private System.Windows.Forms.Button InfractionGroupID_intNewButton;
private System.Windows.Forms.ComboBox InfractionGroupID_intComboBox;
    }
}
