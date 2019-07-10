using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present
{
    partial class CompanyMobileEntityForm 

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
            this.LastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MobileNumber_nvcLabel = new System.Windows.Forms.Label();
            this.MobileNumber_nvcTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(492, 18);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(492, 52);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(492, 87);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(492, 121);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.MobileNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LastName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.FirstName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Controls.Add(this.label2);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.MobileNumber_nvcLabel);
            this.DetailGropBox.Location = new System.Drawing.Point(2, -8);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(482, 167);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // LastName_nvcTextBox
            // 
            this.LastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvcTextBox.Location = new System.Drawing.Point(101, 90);
            this.LastName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LastName_nvcTextBox.MaxLength = 11;
            this.LastName_nvcTextBox.Name = "LastName_nvcTextBox";
            this.LastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastName_nvcTextBox.Size = new System.Drawing.Size(260, 30);
            this.LastName_nvcTextBox.TabIndex = 2;
            this.LastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirstName_nvcTextBox
            // 
            this.FirstName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName_nvcTextBox.Location = new System.Drawing.Point(101, 55);
            this.FirstName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FirstName_nvcTextBox.MaxLength = 11;
            this.FirstName_nvcTextBox.Name = "FirstName_nvcTextBox";
            this.FirstName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstName_nvcTextBox.Size = new System.Drawing.Size(260, 30);
            this.FirstName_nvcTextBox.TabIndex = 1;
            this.FirstName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.AutoSize = true;
            this.Active_bitCheckBox.Checked = true;
            this.Active_bitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Active_bitCheckBox.Location = new System.Drawing.Point(349, 129);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(52, 27);
            this.Active_bitCheckBox.TabIndex = 3;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            // 
            // MobileNumber_nvcLabel
            // 
            this.MobileNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MobileNumber_nvcLabel.AutoSize = true;
            this.MobileNumber_nvcLabel.Location = new System.Drawing.Point(367, 24);
            this.MobileNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MobileNumber_nvcLabel.Name = "MobileNumber_nvcLabel";
            this.MobileNumber_nvcLabel.Size = new System.Drawing.Size(76, 23);
            this.MobileNumber_nvcLabel.TabIndex = 0;
            this.MobileNumber_nvcLabel.Text = "شماره موبایل";
            // 
            // MobileNumber_nvcTextBox
            // 
            this.MobileNumber_nvcTextBox.AllowNegative = true;
            this.MobileNumber_nvcTextBox.DigitsInGroup = 0;
            this.MobileNumber_nvcTextBox.Flags = 0;
            this.MobileNumber_nvcTextBox.Location = new System.Drawing.Point(101, 20);
            this.MobileNumber_nvcTextBox.MaxDecimalPlaces = 4;
            this.MobileNumber_nvcTextBox.MaxWholeDigits = 151;
            this.MobileNumber_nvcTextBox.Name = "MobileNumber_nvcTextBox";
            this.MobileNumber_nvcTextBox.Prefix = "";
            //this.MobileNumber_nvcTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
           // this.MobileNumber_nvcTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.MobileNumber_nvcTextBox.Size = new System.Drawing.Size(260, 30);
            this.MobileNumber_nvcTextBox.TabIndex = 0;
            // 
            // CompanyMobileEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 162);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "CompanyMobileEntityForm";
            this.Load += new System.EventHandler(this.CompanyMobileEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;

        private System.Windows.Forms.Label MobileNumber_nvcLabel;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox LastName_nvcTextBox;
private System.Windows.Forms.TextBox FirstName_nvcTextBox;
private System.Windows.Forms.CheckBox Active_bitCheckBox;
private System.Windows.Forms.Label label2;
private NumericTextBox MobileNumber_nvcTextBox;
        
       
        
       
        
        
        
        
        
        
        
        
        
    }
}
