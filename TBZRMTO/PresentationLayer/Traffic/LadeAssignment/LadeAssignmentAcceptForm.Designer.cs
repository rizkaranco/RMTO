using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignment
{
    partial class LadeAssignmentAcceptForm
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
            this.LadingTime_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LadingDate_nvcLabel = new System.Windows.Forms.Label();
            this.LadingDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CarCount_intNumericTextBox = new NumericTextBox();
            this.LadingTime_nvcLabel = new System.Windows.Forms.Label();
            this.CarCount_intLabel = new System.Windows.Forms.Label();
            this.CityCode_nvcLabel = new System.Windows.Forms.Label();
            this.CityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.LaderTypeID_intLabel = new System.Windows.Forms.Label();
            this.BoxingID_intLabel = new System.Windows.Forms.Label();
            this.CityID_intLabel = new System.Windows.Forms.Label();
            this.GoodID_intLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.City_vncTextBox = new System.Windows.Forms.TextBox();
            this.Good_nvcTextBox = new System.Windows.Forms.TextBox();
            this.LaderType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Company_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Boxing_nvcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LadingTime_nvcTextBox
            // 
            this.LadingTime_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadingTime_nvcTextBox.Enabled = false;
            this.LadingTime_nvcTextBox.Location = new System.Drawing.Point(116, 52);
            this.LadingTime_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LadingTime_nvcTextBox.Mask = "00:00";
            this.LadingTime_nvcTextBox.Name = "LadingTime_nvcTextBox";
            this.LadingTime_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LadingTime_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.LadingTime_nvcTextBox.TabIndex = 35;
            this.LadingTime_nvcTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // LadingDate_nvcLabel
            // 
            this.LadingDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadingDate_nvcLabel.AutoSize = true;
            this.LadingDate_nvcLabel.Location = new System.Drawing.Point(36, 16);
            this.LadingDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LadingDate_nvcLabel.Name = "LadingDate_nvcLabel";
            this.LadingDate_nvcLabel.Size = new System.Drawing.Size(80, 23);
            this.LadingDate_nvcLabel.TabIndex = 33;
            this.LadingDate_nvcLabel.Text = "تاریخ بارگیری";
            // 
            // LadingDate_nvcTextBox
            // 
            this.LadingDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadingDate_nvcTextBox.Enabled = false;
            this.LadingDate_nvcTextBox.Location = new System.Drawing.Point(116, 14);
            this.LadingDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LadingDate_nvcTextBox.Mask = "0000/00/00";
            this.LadingDate_nvcTextBox.Name = "LadingDate_nvcTextBox";
            this.LadingDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LadingDate_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.LadingDate_nvcTextBox.TabIndex = 32;
            // 
            // CarCount_intNumericTextBox
            // 
            this.CarCount_intNumericTextBox.AllowNegative = false;
            this.CarCount_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCount_intNumericTextBox.DigitsInGroup = 0;
            this.CarCount_intNumericTextBox.Enabled = false;
            this.CarCount_intNumericTextBox.Flags = 65536;
            this.CarCount_intNumericTextBox.Location = new System.Drawing.Point(116, 239);
            this.CarCount_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarCount_intNumericTextBox.MaxDecimalPlaces = 0;
            this.CarCount_intNumericTextBox.MaxWholeDigits = 155;
            this.CarCount_intNumericTextBox.Name = "CarCount_intNumericTextBox";
            this.CarCount_intNumericTextBox.Prefix = "";
          //  this.CarCount_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
          //  this.CarCount_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.CarCount_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCount_intNumericTextBox.Size = new System.Drawing.Size(334, 30);
            this.CarCount_intNumericTextBox.TabIndex = 48;
            this.CarCount_intNumericTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LadingTime_nvcLabel
            // 
            this.LadingTime_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadingTime_nvcLabel.AutoSize = true;
            this.LadingTime_nvcLabel.Location = new System.Drawing.Point(30, 59);
            this.LadingTime_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LadingTime_nvcLabel.Name = "LadingTime_nvcLabel";
            this.LadingTime_nvcLabel.Size = new System.Drawing.Size(86, 23);
            this.LadingTime_nvcLabel.TabIndex = 34;
            this.LadingTime_nvcLabel.Text = "ساعت بارگیری";
            // 
            // CarCount_intLabel
            // 
            this.CarCount_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCount_intLabel.AutoSize = true;
            this.CarCount_intLabel.Location = new System.Drawing.Point(2, 246);
            this.CarCount_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarCount_intLabel.Name = "CarCount_intLabel";
            this.CarCount_intLabel.Size = new System.Drawing.Size(114, 23);
            this.CarCount_intLabel.TabIndex = 49;
            this.CarCount_intLabel.Text = "تعداد خودرو مورد نیاز";
            // 
            // CityCode_nvcLabel
            // 
            this.CityCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCode_nvcLabel.AutoSize = true;
            this.CityCode_nvcLabel.Location = new System.Drawing.Point(38, 133);
            this.CityCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityCode_nvcLabel.Name = "CityCode_nvcLabel";
            this.CityCode_nvcLabel.Size = new System.Drawing.Size(78, 23);
            this.CityCode_nvcLabel.TabIndex = 36;
            this.CityCode_nvcLabel.Text = "کدشهر مقصد";
            // 
            // CityCode_nvcTextBox
            // 
            this.CityCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCode_nvcTextBox.Enabled = false;
            this.CityCode_nvcTextBox.Location = new System.Drawing.Point(116, 126);
            this.CityCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityCode_nvcTextBox.MaxLength = 10;
            this.CityCode_nvcTextBox.Name = "CityCode_nvcTextBox";
            this.CityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityCode_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.CityCode_nvcTextBox.TabIndex = 39;
            this.CityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Location = new System.Drawing.Point(71, 286);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(45, 23);
            this.CompanyID_intLabel.TabIndex = 46;
            this.CompanyID_intLabel.Text = "شرکت";
            // 
            // LaderTypeID_intLabel
            // 
            this.LaderTypeID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intLabel.AutoSize = true;
            this.LaderTypeID_intLabel.Location = new System.Drawing.Point(54, 323);
            this.LaderTypeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderTypeID_intLabel.Name = "LaderTypeID_intLabel";
            this.LaderTypeID_intLabel.Size = new System.Drawing.Size(62, 23);
            this.LaderTypeID_intLabel.TabIndex = 45;
            this.LaderTypeID_intLabel.Text = " نوع بارگیر";
            this.LaderTypeID_intLabel.Visible = false;
            // 
            // BoxingID_intLabel
            // 
            this.BoxingID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxingID_intLabel.AutoSize = true;
            this.BoxingID_intLabel.Location = new System.Drawing.Point(33, 208);
            this.BoxingID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BoxingID_intLabel.Name = "BoxingID_intLabel";
            this.BoxingID_intLabel.Size = new System.Drawing.Size(83, 23);
            this.BoxingID_intLabel.TabIndex = 44;
            this.BoxingID_intLabel.Text = "نوع بسته بندی";
            // 
            // CityID_intLabel
            // 
            this.CityID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intLabel.AutoSize = true;
            this.CityID_intLabel.Location = new System.Drawing.Point(51, 95);
            this.CityID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityID_intLabel.Name = "CityID_intLabel";
            this.CityID_intLabel.Size = new System.Drawing.Size(65, 23);
            this.CityID_intLabel.TabIndex = 42;
            this.CityID_intLabel.Text = "شهر مقصد";
            // 
            // GoodID_intLabel
            // 
            this.GoodID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodID_intLabel.AutoSize = true;
            this.GoodID_intLabel.Location = new System.Drawing.Point(88, 171);
            this.GoodID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GoodID_intLabel.Name = "GoodID_intLabel";
            this.GoodID_intLabel.Size = new System.Drawing.Size(28, 23);
            this.GoodID_intLabel.TabIndex = 43;
            this.GoodID_intLabel.Text = "کالا";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AcceptButton.Location = new System.Drawing.Point(348, 358);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(102, 33);
            this.AcceptButton.TabIndex = 58;
            this.AcceptButton.Text = "تأیید";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // City_vncTextBox
            // 
            this.City_vncTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.City_vncTextBox.Enabled = false;
            this.City_vncTextBox.Location = new System.Drawing.Point(116, 90);
            this.City_vncTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.City_vncTextBox.MaxLength = 10;
            this.City_vncTextBox.Name = "City_vncTextBox";
            this.City_vncTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.City_vncTextBox.Size = new System.Drawing.Size(334, 30);
            this.City_vncTextBox.TabIndex = 39;
            this.City_vncTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Good_nvcTextBox
            // 
            this.Good_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Good_nvcTextBox.Enabled = false;
            this.Good_nvcTextBox.Location = new System.Drawing.Point(116, 164);
            this.Good_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Good_nvcTextBox.MaxLength = 10;
            this.Good_nvcTextBox.Name = "Good_nvcTextBox";
            this.Good_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Good_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.Good_nvcTextBox.TabIndex = 38;
            this.Good_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderType_nvcTextBox
            // 
            this.LaderType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderType_nvcTextBox.Enabled = false;
            this.LaderType_nvcTextBox.Location = new System.Drawing.Point(116, 318);
            this.LaderType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderType_nvcTextBox.MaxLength = 10;
            this.LaderType_nvcTextBox.Name = "LaderType_nvcTextBox";
            this.LaderType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderType_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.LaderType_nvcTextBox.TabIndex = 54;
            this.LaderType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LaderType_nvcTextBox.Visible = false;
            // 
            // Company_nvcTextBox
            // 
            this.Company_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Company_nvcTextBox.Enabled = false;
            this.Company_nvcTextBox.Location = new System.Drawing.Point(116, 280);
            this.Company_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Company_nvcTextBox.MaxLength = 10;
            this.Company_nvcTextBox.Name = "Company_nvcTextBox";
            this.Company_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Company_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.Company_nvcTextBox.TabIndex = 56;
            this.Company_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Boxing_nvcTextBox
            // 
            this.Boxing_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boxing_nvcTextBox.Enabled = false;
            this.Boxing_nvcTextBox.Location = new System.Drawing.Point(116, 203);
            this.Boxing_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Boxing_nvcTextBox.MaxLength = 10;
            this.Boxing_nvcTextBox.Name = "Boxing_nvcTextBox";
            this.Boxing_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Boxing_nvcTextBox.Size = new System.Drawing.Size(334, 30);
            this.Boxing_nvcTextBox.TabIndex = 52;
            this.Boxing_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LadeAssignmentAcceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 405);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.Company_nvcTextBox);
            this.Controls.Add(this.LaderType_nvcTextBox);
            this.Controls.Add(this.Boxing_nvcTextBox);
            this.Controls.Add(this.LadingTime_nvcTextBox);
            this.Controls.Add(this.LadingDate_nvcLabel);
            this.Controls.Add(this.LadingDate_nvcTextBox);
            this.Controls.Add(this.CarCount_intNumericTextBox);
            this.Controls.Add(this.LadingTime_nvcLabel);
            this.Controls.Add(this.CarCount_intLabel);
            this.Controls.Add(this.CityCode_nvcLabel);
            this.Controls.Add(this.Good_nvcTextBox);
            this.Controls.Add(this.City_vncTextBox);
            this.Controls.Add(this.CityCode_nvcTextBox);
            this.Controls.Add(this.CompanyID_intLabel);
            this.Controls.Add(this.LaderTypeID_intLabel);
            this.Controls.Add(this.BoxingID_intLabel);
            this.Controls.Add(this.CityID_intLabel);
            this.Controls.Add(this.GoodID_intLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "LadeAssignmentAcceptForm";
            this.Text = "تأیید اطلاع رسانی بار";
            this.Load += new System.EventHandler(this.LadeAssignmentAcceptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox LadingTime_nvcTextBox;
        private System.Windows.Forms.Label LadingDate_nvcLabel;
        private System.Windows.Forms.MaskedTextBox LadingDate_nvcTextBox;
        private NumericTextBox CarCount_intNumericTextBox;
        private System.Windows.Forms.Label LadingTime_nvcLabel;
        private System.Windows.Forms.Label CarCount_intLabel;
        private System.Windows.Forms.Label CityCode_nvcLabel;
        private System.Windows.Forms.TextBox CityCode_nvcTextBox;
        private System.Windows.Forms.Label CompanyID_intLabel;
        private System.Windows.Forms.Label LaderTypeID_intLabel;
        private System.Windows.Forms.Label BoxingID_intLabel;
        private System.Windows.Forms.Label CityID_intLabel;
        private System.Windows.Forms.Label GoodID_intLabel;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox City_vncTextBox;
        private System.Windows.Forms.TextBox Good_nvcTextBox;
        private System.Windows.Forms.TextBox LaderType_nvcTextBox;
        private System.Windows.Forms.TextBox Company_nvcTextBox;
        private System.Windows.Forms.TextBox Boxing_nvcTextBox;

    }
}