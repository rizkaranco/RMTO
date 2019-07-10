using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.UsedLadBill
{
    partial class UsedLadBillEntityForm 

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
            this.label7 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DriverName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Serial_nvcLabel = new System.Windows.Forms.Label();
            this.Comment_nvcLabel = new System.Windows.Forms.Label();
            this.LadBillNumber_intLabel = new System.Windows.Forms.Label();
            this.Serial_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Comment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.StartNumber_intTextBox = new NumericTextBox();
            this.LadBillNumber_intNumericTextBox = new NumericTextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(420, 14);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.Visible = false;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(420, 48);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(420, 82);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(420, 116);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.label7);
            this.DetailGropBox.Controls.Add(this.NumberPlate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.label15);
            this.DetailGropBox.Controls.Add(this.DriverName_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.Serial_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Comment_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LadBillNumber_intLabel);
            this.DetailGropBox.Controls.Add(this.Serial_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Comment_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.StartNumber_intTextBox);
            this.DetailGropBox.Controls.Add(this.LadBillNumber_intNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(15, 4);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(393, 300);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(313, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "نام راننده";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Enabled = false;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(11, 127);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(298, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 19;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(313, 134);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "شماره پلاك";
            // 
            // DriverName_nvcTextBox
            // 
            this.DriverName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverName_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DriverName_nvcTextBox.Enabled = false;
            this.DriverName_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverName_nvcTextBox.Location = new System.Drawing.Point(11, 90);
            this.DriverName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DriverName_nvcTextBox.MaxLength = 50;
            this.DriverName_nvcTextBox.Name = "DriverName_nvcTextBox";
            this.DriverName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverName_nvcTextBox.Size = new System.Drawing.Size(298, 30);
            this.DriverName_nvcTextBox.TabIndex = 11;
            this.DriverName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "شماره شروع";
            // 
            // Serial_nvcLabel
            // 
            this.Serial_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Serial_nvcLabel.AutoSize = true;
            this.Serial_nvcLabel.Location = new System.Drawing.Point(314, 27);
            this.Serial_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Serial_nvcLabel.Name = "Serial_nvcLabel";
            this.Serial_nvcLabel.Size = new System.Drawing.Size(43, 23);
            this.Serial_nvcLabel.TabIndex = 0;
            this.Serial_nvcLabel.Text = "سریال";
            // 
            // Comment_nvcLabel
            // 
            this.Comment_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_nvcLabel.AutoSize = true;
            this.Comment_nvcLabel.Location = new System.Drawing.Point(313, 209);
            this.Comment_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Comment_nvcLabel.Name = "Comment_nvcLabel";
            this.Comment_nvcLabel.Size = new System.Drawing.Size(44, 23);
            this.Comment_nvcLabel.TabIndex = 1;
            this.Comment_nvcLabel.Text = "توضیح";
            // 
            // LadBillNumber_intLabel
            // 
            this.LadBillNumber_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadBillNumber_intLabel.AutoSize = true;
            this.LadBillNumber_intLabel.Location = new System.Drawing.Point(313, 172);
            this.LadBillNumber_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LadBillNumber_intLabel.Name = "LadBillNumber_intLabel";
            this.LadBillNumber_intLabel.Size = new System.Drawing.Size(76, 23);
            this.LadBillNumber_intLabel.TabIndex = 4;
            this.LadBillNumber_intLabel.Text = "شماره بارنامه";
            // 
            // Serial_nvcTextBox
            // 
            this.Serial_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Serial_nvcTextBox.Enabled = false;
            this.Serial_nvcTextBox.Location = new System.Drawing.Point(12, 20);
            this.Serial_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Serial_nvcTextBox.MaxLength = 100;
            this.Serial_nvcTextBox.Name = "Serial_nvcTextBox";
            this.Serial_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Serial_nvcTextBox.Size = new System.Drawing.Size(298, 30);
            this.Serial_nvcTextBox.TabIndex = 5;
            this.Serial_nvcTextBox.TabStop = false;
            this.Serial_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Comment_nvcTextBox
            // 
            this.Comment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_nvcTextBox.Location = new System.Drawing.Point(11, 202);
            this.Comment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Comment_nvcTextBox.MaxLength = 1000;
            this.Comment_nvcTextBox.Multiline = true;
            this.Comment_nvcTextBox.Name = "Comment_nvcTextBox";
            this.Comment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Comment_nvcTextBox.Size = new System.Drawing.Size(298, 84);
            this.Comment_nvcTextBox.TabIndex = 1;
            this.Comment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartNumber_intTextBox
            // 
            this.StartNumber_intTextBox.AllowNegative = false;
            this.StartNumber_intTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartNumber_intTextBox.DigitsInGroup = 0;
            this.StartNumber_intTextBox.Enabled = false;
            this.StartNumber_intTextBox.Flags = 65536;
            this.StartNumber_intTextBox.Location = new System.Drawing.Point(11, 54);
            this.StartNumber_intTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StartNumber_intTextBox.MaxDecimalPlaces = 0;
            this.StartNumber_intTextBox.MaxWholeDigits = 155;
            this.StartNumber_intTextBox.Name = "StartNumber_intTextBox";
            this.StartNumber_intTextBox.Prefix = "";
            //this.StartNumber_intTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
            //this.StartNumber_intTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.StartNumber_intTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartNumber_intTextBox.Size = new System.Drawing.Size(298, 30);
            this.StartNumber_intTextBox.TabIndex = 9;
            this.StartNumber_intTextBox.TabStop = false;
            // 
            // LadBillNumber_intNumericTextBox
            // 
            this.LadBillNumber_intNumericTextBox.AllowNegative = false;
            this.LadBillNumber_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadBillNumber_intNumericTextBox.DigitsInGroup = 0;
            this.LadBillNumber_intNumericTextBox.Flags = 65536;
            this.LadBillNumber_intNumericTextBox.Location = new System.Drawing.Point(11, 165);
            this.LadBillNumber_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LadBillNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.LadBillNumber_intNumericTextBox.MaxLength = 9;
            this.LadBillNumber_intNumericTextBox.MaxWholeDigits = 155;
            this.LadBillNumber_intNumericTextBox.Name = "LadBillNumber_intNumericTextBox";
            this.LadBillNumber_intNumericTextBox.Prefix = "";
            //this.LadBillNumber_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
            //this.LadBillNumber_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.LadBillNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LadBillNumber_intNumericTextBox.Size = new System.Drawing.Size(298, 30);
            this.LadBillNumber_intNumericTextBox.TabIndex = 0;
            // 
            // UsedLadBillEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 317);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "UsedLadBillEntityForm";
            this.Text = "بارنامه تحویلی به راننده";
            this.Load += new System.EventHandler(this.UsedLadBillEntityForm_Load);
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
        
private System.Windows.Forms.Label Serial_nvcLabel;
private System.Windows.Forms.Label Comment_nvcLabel;
        
private System.Windows.Forms.TextBox Serial_nvcTextBox;
private System.Windows.Forms.TextBox Comment_nvcTextBox;
        
       
        
       
private System.Windows.Forms.Label LadBillNumber_intLabel;
        
private NumericTextBox LadBillNumber_intNumericTextBox;
private System.Windows.Forms.Label label1;
private NumericTextBox StartNumber_intTextBox;
private System.Windows.Forms.TextBox DriverName_nvcTextBox;
private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
private System.Windows.Forms.Label label15;
private System.Windows.Forms.Label label7;
        
    }
}
