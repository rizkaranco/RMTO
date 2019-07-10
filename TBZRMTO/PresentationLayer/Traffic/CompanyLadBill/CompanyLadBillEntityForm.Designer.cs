using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.CompanyLadBill
{
    partial class CompanyLadBillEntityForm 

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
            this.CompanyID_intNewButton = new System.Windows.Forms.Button();
            this.Date_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CompanyCode_nvcLabel = new System.Windows.Forms.Label();
            this.Date_nvcLabel = new System.Windows.Forms.Label();
            this.Serial_nvcLabel = new System.Windows.Forms.Label();
            this.AssignmentNumber_nvcLabel = new System.Windows.Forms.Label();
            this.DeliveryUserCode_nvcLabel = new System.Windows.Forms.Label();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.StartNumber_intLabel = new System.Windows.Forms.Label();
            this.EndNumber_intLabel = new System.Windows.Forms.Label();
            this.CompanyCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Serial_nvcTextBox = new System.Windows.Forms.TextBox();
            this.AssignmentNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryUserCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CompanyID_intComboBox = new System.Windows.Forms.ComboBox();
            this.StartNumber_intNumericTextBox = new NumericTextBox();
            this.EndNumber_intNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(463, 9);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(463, 41);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(463, 73);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(463, 105);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.CompanyID_intNewButton);
            this.DetailGropBox.Controls.Add(this.Date_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CompanyCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Date_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Serial_nvcLabel);
            this.DetailGropBox.Controls.Add(this.AssignmentNumber_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DeliveryUserCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CompanyID_intLabel);
            this.DetailGropBox.Controls.Add(this.StartNumber_intLabel);
            this.DetailGropBox.Controls.Add(this.EndNumber_intLabel);
            this.DetailGropBox.Controls.Add(this.CompanyCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Serial_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.AssignmentNumber_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.DeliveryUserCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CompanyID_intComboBox);
            this.DetailGropBox.Controls.Add(this.StartNumber_intNumericTextBox);
            this.DetailGropBox.Controls.Add(this.EndNumber_intNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(438, 318);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // CompanyID_intNewButton
            // 
            this.CompanyID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.CompanyID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompanyID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyID_intNewButton.Location = new System.Drawing.Point(16, 24);
            this.CompanyID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intNewButton.Name = "CompanyID_intNewButton";
            this.CompanyID_intNewButton.Size = new System.Drawing.Size(32, 31);
            this.CompanyID_intNewButton.TabIndex = 23;
            this.CompanyID_intNewButton.TabStop = false;
            this.CompanyID_intNewButton.UseVisualStyleBackColor = true;
            this.CompanyID_intNewButton.Click += new System.EventHandler(this.CompanyID_intNewButton_Click);
            // 
            // Date_nvcTextBox
            // 
            this.Date_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_nvcTextBox.Location = new System.Drawing.Point(16, 94);
            this.Date_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Date_nvcTextBox.Mask = "0000/00/00";
            this.Date_nvcTextBox.Name = "Date_nvcTextBox";
            this.Date_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_nvcTextBox.Size = new System.Drawing.Size(313, 30);
            this.Date_nvcTextBox.TabIndex = 2;
            // 
            // CompanyCode_nvcLabel
            // 
            this.CompanyCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyCode_nvcLabel.AutoSize = true;
            this.CompanyCode_nvcLabel.Location = new System.Drawing.Point(341, 64);
            this.CompanyCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyCode_nvcLabel.Name = "CompanyCode_nvcLabel";
            this.CompanyCode_nvcLabel.Size = new System.Drawing.Size(61, 23);
            this.CompanyCode_nvcLabel.TabIndex = 0;
            this.CompanyCode_nvcLabel.Text = "کد شرکت";
            // 
            // Date_nvcLabel
            // 
            this.Date_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_nvcLabel.AutoSize = true;
            this.Date_nvcLabel.Location = new System.Drawing.Point(341, 100);
            this.Date_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Date_nvcLabel.Name = "Date_nvcLabel";
            this.Date_nvcLabel.Size = new System.Drawing.Size(73, 23);
            this.Date_nvcLabel.TabIndex = 1;
            this.Date_nvcLabel.Text = "تاریخ تحویل";
            // 
            // Serial_nvcLabel
            // 
            this.Serial_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Serial_nvcLabel.AutoSize = true;
            this.Serial_nvcLabel.Location = new System.Drawing.Point(341, 136);
            this.Serial_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Serial_nvcLabel.Name = "Serial_nvcLabel";
            this.Serial_nvcLabel.Size = new System.Drawing.Size(43, 23);
            this.Serial_nvcLabel.TabIndex = 2;
            this.Serial_nvcLabel.Text = "سریال";
            // 
            // AssignmentNumber_nvcLabel
            // 
            this.AssignmentNumber_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignmentNumber_nvcLabel.AutoSize = true;
            this.AssignmentNumber_nvcLabel.Location = new System.Drawing.Point(341, 244);
            this.AssignmentNumber_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AssignmentNumber_nvcLabel.Name = "AssignmentNumber_nvcLabel";
            this.AssignmentNumber_nvcLabel.Size = new System.Drawing.Size(72, 23);
            this.AssignmentNumber_nvcLabel.TabIndex = 3;
            this.AssignmentNumber_nvcLabel.Text = "شماره حواله";
            // 
            // DeliveryUserCode_nvcLabel
            // 
            this.DeliveryUserCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryUserCode_nvcLabel.AutoSize = true;
            this.DeliveryUserCode_nvcLabel.Location = new System.Drawing.Point(341, 280);
            this.DeliveryUserCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DeliveryUserCode_nvcLabel.Name = "DeliveryUserCode_nvcLabel";
            this.DeliveryUserCode_nvcLabel.Size = new System.Drawing.Size(91, 23);
            this.DeliveryUserCode_nvcLabel.TabIndex = 4;
            this.DeliveryUserCode_nvcLabel.Text = "کد تحویل دهنده";
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Location = new System.Drawing.Point(341, 28);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(45, 23);
            this.CompanyID_intLabel.TabIndex = 5;
            this.CompanyID_intLabel.Text = "شرکت";
            // 
            // StartNumber_intLabel
            // 
            this.StartNumber_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartNumber_intLabel.AutoSize = true;
            this.StartNumber_intLabel.Location = new System.Drawing.Point(341, 172);
            this.StartNumber_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartNumber_intLabel.Name = "StartNumber_intLabel";
            this.StartNumber_intLabel.Size = new System.Drawing.Size(59, 23);
            this.StartNumber_intLabel.TabIndex = 6;
            this.StartNumber_intLabel.Text = " از شماره ";
            // 
            // EndNumber_intLabel
            // 
            this.EndNumber_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndNumber_intLabel.AutoSize = true;
            this.EndNumber_intLabel.Location = new System.Drawing.Point(341, 208);
            this.EndNumber_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EndNumber_intLabel.Name = "EndNumber_intLabel";
            this.EndNumber_intLabel.Size = new System.Drawing.Size(53, 23);
            this.EndNumber_intLabel.TabIndex = 7;
            this.EndNumber_intLabel.Text = "تا شماره";
            // 
            // CompanyCode_nvcTextBox
            // 
            this.CompanyCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyCode_nvcTextBox.Enabled = false;
            this.CompanyCode_nvcTextBox.Location = new System.Drawing.Point(15, 59);
            this.CompanyCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyCode_nvcTextBox.MaxLength = 10;
            this.CompanyCode_nvcTextBox.Name = "CompanyCode_nvcTextBox";
            this.CompanyCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyCode_nvcTextBox.Size = new System.Drawing.Size(315, 30);
            this.CompanyCode_nvcTextBox.TabIndex = 1;
            this.CompanyCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Serial_nvcTextBox
            // 
            this.Serial_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Serial_nvcTextBox.Location = new System.Drawing.Point(15, 129);
            this.Serial_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Serial_nvcTextBox.MaxLength = 100;
            this.Serial_nvcTextBox.Name = "Serial_nvcTextBox";
            this.Serial_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Serial_nvcTextBox.Size = new System.Drawing.Size(315, 30);
            this.Serial_nvcTextBox.TabIndex = 3;
            this.Serial_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AssignmentNumber_nvcTextBox
            // 
            this.AssignmentNumber_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignmentNumber_nvcTextBox.Location = new System.Drawing.Point(15, 234);
            this.AssignmentNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.AssignmentNumber_nvcTextBox.MaxLength = 15;
            this.AssignmentNumber_nvcTextBox.Name = "AssignmentNumber_nvcTextBox";
            this.AssignmentNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AssignmentNumber_nvcTextBox.Size = new System.Drawing.Size(315, 30);
            this.AssignmentNumber_nvcTextBox.TabIndex = 6;
            this.AssignmentNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DeliveryUserCode_nvcTextBox
            // 
            this.DeliveryUserCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryUserCode_nvcTextBox.Location = new System.Drawing.Point(15, 269);
            this.DeliveryUserCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DeliveryUserCode_nvcTextBox.MaxLength = 5;
            this.DeliveryUserCode_nvcTextBox.Name = "DeliveryUserCode_nvcTextBox";
            this.DeliveryUserCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeliveryUserCode_nvcTextBox.Size = new System.Drawing.Size(315, 30);
            this.DeliveryUserCode_nvcTextBox.TabIndex = 7;
            this.DeliveryUserCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CompanyID_intComboBox
            // 
            this.CompanyID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyID_intComboBox.FormattingEnabled = true;
            this.CompanyID_intComboBox.Location = new System.Drawing.Point(55, 23);
            this.CompanyID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intComboBox.Name = "CompanyID_intComboBox";
            this.CompanyID_intComboBox.Size = new System.Drawing.Size(275, 31);
            this.CompanyID_intComboBox.TabIndex = 0;
            this.CompanyID_intComboBox.SelectedValueChanged += new System.EventHandler(this.CompanyID_intComboBox_SelectedValueChanged);
            // 
            // StartNumber_intNumericTextBox
            // 
            this.StartNumber_intNumericTextBox.AllowNegative = false;
            this.StartNumber_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartNumber_intNumericTextBox.DigitsInGroup = 0;
            this.StartNumber_intNumericTextBox.Flags = 65536;
            this.StartNumber_intNumericTextBox.Location = new System.Drawing.Point(15, 164);
            this.StartNumber_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StartNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.StartNumber_intNumericTextBox.MaxWholeDigits = 155;
            this.StartNumber_intNumericTextBox.Name = "StartNumber_intNumericTextBox";
            this.StartNumber_intNumericTextBox.Prefix = "";
          //  this.StartNumber_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
          //  this.StartNumber_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.StartNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartNumber_intNumericTextBox.Size = new System.Drawing.Size(315, 30);
            this.StartNumber_intNumericTextBox.TabIndex = 4;
            // 
            // EndNumber_intNumericTextBox
            // 
            this.EndNumber_intNumericTextBox.AllowNegative = false;
            this.EndNumber_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndNumber_intNumericTextBox.DigitsInGroup = 0;
            this.EndNumber_intNumericTextBox.Flags = 65536;
            this.EndNumber_intNumericTextBox.Location = new System.Drawing.Point(15, 199);
            this.EndNumber_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EndNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.EndNumber_intNumericTextBox.MaxWholeDigits = 155;
            this.EndNumber_intNumericTextBox.Name = "EndNumber_intNumericTextBox";
            this.EndNumber_intNumericTextBox.Prefix = "";
          //  this.EndNumber_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
           // this.EndNumber_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.EndNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndNumber_intNumericTextBox.Size = new System.Drawing.Size(315, 30);
            this.EndNumber_intNumericTextBox.TabIndex = 5;
            // 
            // CompanyLadBillEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 334);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "CompanyLadBillEntityForm";
            this.Text = "بارنامه های تحویلی به شرکت ها";
            this.Load += new System.EventHandler(this.CompanyLadBillEntityForm_Load);
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
        
private System.Windows.Forms.Label CompanyCode_nvcLabel;
private System.Windows.Forms.Label Date_nvcLabel;
private System.Windows.Forms.Label Serial_nvcLabel;
private System.Windows.Forms.Label AssignmentNumber_nvcLabel;
private System.Windows.Forms.Label DeliveryUserCode_nvcLabel;

private System.Windows.Forms.TextBox CompanyCode_nvcTextBox;
private System.Windows.Forms.TextBox Serial_nvcTextBox;
private System.Windows.Forms.TextBox AssignmentNumber_nvcTextBox;
private System.Windows.Forms.TextBox DeliveryUserCode_nvcTextBox;
        
private System.Windows.Forms.Label CompanyID_intLabel;

private System.Windows.Forms.ComboBox CompanyID_intComboBox;
       
private System.Windows.Forms.Label StartNumber_intLabel;
private System.Windows.Forms.Label EndNumber_intLabel;
        
private NumericTextBox StartNumber_intNumericTextBox;
private NumericTextBox EndNumber_intNumericTextBox;
private System.Windows.Forms.MaskedTextBox Date_nvcTextBox;
private System.Windows.Forms.Button CompanyID_intNewButton;
        
    }
}
