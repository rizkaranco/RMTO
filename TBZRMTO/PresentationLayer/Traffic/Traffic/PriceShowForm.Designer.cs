using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    partial class PriceShowForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTextBox = new NumericTextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Zar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "ريال مبلغ دریافتی از راننده می باشد";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.AllowNegative = false;
            this.PriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.DigitsInGroup = 3;
            this.PriceTextBox.Flags = 65536;
            this.PriceTextBox.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PriceTextBox.Location = new System.Drawing.Point(11, 9);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PriceTextBox.MaxDecimalPlaces = 0;
            this.PriceTextBox.MaxWholeDigits = 155;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Prefix = "";
          //  this.PriceTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
          //  this.PriceTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.PriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceTextBox.Size = new System.Drawing.Size(168, 43);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.TabStop = false;
            this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AcceptButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptButton.Location = new System.Drawing.Point(227, 58);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(89, 28);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "تأیید";
            this.AcceptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // PriceShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(519, 100);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "PriceShowForm";
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private NumericTextBox PriceTextBox;
        private System.Windows.Forms.Button AcceptButton;
    }
}