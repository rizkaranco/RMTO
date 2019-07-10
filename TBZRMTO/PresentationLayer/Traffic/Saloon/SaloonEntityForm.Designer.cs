using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.Saloon
{
    partial class SaloonEntityForm 

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
            this.SaloonTabControl = new System.Windows.Forms.TabControl();
            this.SaloonTapPage = new System.Windows.Forms.TabPage();
            this.Name_nvcLabel = new System.Windows.Forms.Label();
            this.TurnDistinictAfterCredit_intLabel = new System.Windows.Forms.Label();
            this.TurnNumberInLadeAnnouncement_intLabel = new System.Windows.Forms.Label();
            this.Saloon_nvcTextBox = new System.Windows.Forms.TextBox();
            this.TurnDistinictAfterCredit_intNumericTextBox = new NumericTextBox();
            this.TurnNumberInLadeAnnouncement_intNumericTextBox = new NumericTextBox();
            this.LaderTypeTabPage = new System.Windows.Forms.TabPage();
            this.lstLaderTypeCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SaloonTabControl.SuspendLayout();
            this.SaloonTapPage.SuspendLayout();
            this.LaderTypeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(510, 9);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(510, 45);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(510, 82);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(510, 117);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaloonTabControl
            // 
            this.SaloonTabControl.Controls.Add(this.SaloonTapPage);
            this.SaloonTabControl.Controls.Add(this.LaderTypeTabPage);
            this.SaloonTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaloonTabControl.Location = new System.Drawing.Point(0, 0);
            this.SaloonTabControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SaloonTabControl.Name = "SaloonTabControl";
            this.SaloonTabControl.RightToLeftLayout = true;
            this.SaloonTabControl.SelectedIndex = 0;
            this.SaloonTabControl.Size = new System.Drawing.Size(500, 292);
            this.SaloonTabControl.TabIndex = 7;
            // 
            // SaloonTapPage
            // 
            this.SaloonTapPage.Controls.Add(this.Name_nvcLabel);
            this.SaloonTapPage.Controls.Add(this.TurnDistinictAfterCredit_intLabel);
            this.SaloonTapPage.Controls.Add(this.TurnNumberInLadeAnnouncement_intLabel);
            this.SaloonTapPage.Controls.Add(this.Saloon_nvcTextBox);
            this.SaloonTapPage.Controls.Add(this.TurnDistinictAfterCredit_intNumericTextBox);
            this.SaloonTapPage.Controls.Add(this.TurnNumberInLadeAnnouncement_intNumericTextBox);
            this.SaloonTapPage.Location = new System.Drawing.Point(4, 32);
            this.SaloonTapPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SaloonTapPage.Name = "SaloonTapPage";
            this.SaloonTapPage.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SaloonTapPage.Size = new System.Drawing.Size(492, 256);
            this.SaloonTapPage.TabIndex = 0;
            this.SaloonTapPage.Text = "سالن های بارگیری";
            this.SaloonTapPage.UseVisualStyleBackColor = true;
            // 
            // Name_nvcLabel
            // 
            this.Name_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_nvcLabel.AutoSize = true;
            this.Name_nvcLabel.Location = new System.Drawing.Point(326, 32);
            this.Name_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Name_nvcLabel.Name = "Name_nvcLabel";
            this.Name_nvcLabel.Size = new System.Drawing.Size(56, 23);
            this.Name_nvcLabel.TabIndex = 6;
            this.Name_nvcLabel.Text = "نام سالن";
            // 
            // TurnDistinictAfterCredit_intLabel
            // 
            this.TurnDistinictAfterCredit_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnDistinictAfterCredit_intLabel.AutoSize = true;
            this.TurnDistinictAfterCredit_intLabel.Location = new System.Drawing.Point(326, 101);
            this.TurnDistinictAfterCredit_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TurnDistinictAfterCredit_intLabel.Name = "TurnDistinictAfterCredit_intLabel";
            this.TurnDistinictAfterCredit_intLabel.Size = new System.Drawing.Size(147, 23);
            this.TurnDistinictAfterCredit_intLabel.TabIndex = 7;
            this.TurnDistinictAfterCredit_intLabel.Text = "فاصله بین نوبتهابعداز اعتبار ";
            // 
            // TurnNumberInLadeAnnouncement_intLabel
            // 
            this.TurnNumberInLadeAnnouncement_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnNumberInLadeAnnouncement_intLabel.AutoSize = true;
            this.TurnNumberInLadeAnnouncement_intLabel.Location = new System.Drawing.Point(326, 170);
            this.TurnNumberInLadeAnnouncement_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TurnNumberInLadeAnnouncement_intLabel.Name = "TurnNumberInLadeAnnouncement_intLabel";
            this.TurnNumberInLadeAnnouncement_intLabel.Size = new System.Drawing.Size(164, 23);
            this.TurnNumberInLadeAnnouncement_intLabel.TabIndex = 8;
            this.TurnNumberInLadeAnnouncement_intLabel.Text = "تعدادمجاز نوبت در هر اعلان بار";
            // 
            // Saloon_nvcTextBox
            // 
            this.Saloon_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Saloon_nvcTextBox.Location = new System.Drawing.Point(13, 26);
            this.Saloon_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Saloon_nvcTextBox.MaxLength = 50;
            this.Saloon_nvcTextBox.Name = "Saloon_nvcTextBox";
            this.Saloon_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Saloon_nvcTextBox.Size = new System.Drawing.Size(302, 30);
            this.Saloon_nvcTextBox.TabIndex = 9;
            this.Saloon_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TurnDistinictAfterCredit_intNumericTextBox
            // 
            this.TurnDistinictAfterCredit_intNumericTextBox.AllowNegative = false;
            this.TurnDistinictAfterCredit_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnDistinictAfterCredit_intNumericTextBox.DigitsInGroup = 0;
            this.TurnDistinictAfterCredit_intNumericTextBox.Flags = 65536;
            this.TurnDistinictAfterCredit_intNumericTextBox.Location = new System.Drawing.Point(13, 94);
            this.TurnDistinictAfterCredit_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TurnDistinictAfterCredit_intNumericTextBox.MaxDecimalPlaces = 0;
            this.TurnDistinictAfterCredit_intNumericTextBox.MaxWholeDigits = 155;
            this.TurnDistinictAfterCredit_intNumericTextBox.Name = "TurnDistinictAfterCredit_intNumericTextBox";
            this.TurnDistinictAfterCredit_intNumericTextBox.Prefix = "";
          //  this.TurnDistinictAfterCredit_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
           // this.TurnDistinictAfterCredit_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.TurnDistinictAfterCredit_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnDistinictAfterCredit_intNumericTextBox.Size = new System.Drawing.Size(302, 30);
            this.TurnDistinictAfterCredit_intNumericTextBox.TabIndex = 10;
            // 
            // TurnNumberInLadeAnnouncement_intNumericTextBox
            // 
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.AllowNegative = false;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.DigitsInGroup = 0;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Flags = 65536;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Location = new System.Drawing.Point(13, 161);
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.MaxDecimalPlaces = 0;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.MaxWholeDigits = 155;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Name = "TurnNumberInLadeAnnouncement_intNumericTextBox";
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Prefix = "";
         //   this.TurnNumberInLadeAnnouncement_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308;
          //  this.TurnNumberInLadeAnnouncement_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.Size = new System.Drawing.Size(302, 30);
            this.TurnNumberInLadeAnnouncement_intNumericTextBox.TabIndex = 11;
            // 
            // LaderTypeTabPage
            // 
            this.LaderTypeTabPage.Controls.Add(this.lstLaderTypeCheckBox);
            this.LaderTypeTabPage.Location = new System.Drawing.Point(4, 32);
            this.LaderTypeTabPage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LaderTypeTabPage.Name = "LaderTypeTabPage";
            this.LaderTypeTabPage.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LaderTypeTabPage.Size = new System.Drawing.Size(492, 256);
            this.LaderTypeTabPage.TabIndex = 1;
            this.LaderTypeTabPage.Text = "انواع بارگیری";
            this.LaderTypeTabPage.UseVisualStyleBackColor = true;
            // 
            // lstLaderTypeCheckBox
            // 
            this.lstLaderTypeCheckBox.CheckOnClick = true;
            this.lstLaderTypeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLaderTypeCheckBox.FormattingEnabled = true;
            this.lstLaderTypeCheckBox.Location = new System.Drawing.Point(5, 5);
            this.lstLaderTypeCheckBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstLaderTypeCheckBox.Name = "lstLaderTypeCheckBox";
            this.lstLaderTypeCheckBox.Size = new System.Drawing.Size(482, 229);
            this.lstLaderTypeCheckBox.TabIndex = 0;
            // 
            // SaloonEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 292);
            this.Controls.Add(this.SaloonTabControl);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "SaloonEntityForm";
            this.Text = "سالن اطلاع رسانی بار";
            this.Load += new System.EventHandler(this.SaloonEntityForm_Load);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaloonTabControl, 0);
            this.SaloonTabControl.ResumeLayout(false);
            this.SaloonTapPage.ResumeLayout(false);
            this.SaloonTapPage.PerformLayout();
            this.LaderTypeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl SaloonTabControl;
        private System.Windows.Forms.TabPage SaloonTapPage;
        private System.Windows.Forms.Label Name_nvcLabel;
        private System.Windows.Forms.Label TurnDistinictAfterCredit_intLabel;
        private System.Windows.Forms.Label TurnNumberInLadeAnnouncement_intLabel;
        private System.Windows.Forms.TextBox Saloon_nvcTextBox;
        private NumericTextBox TurnDistinictAfterCredit_intNumericTextBox;
        private NumericTextBox TurnNumberInLadeAnnouncement_intNumericTextBox;
        private System.Windows.Forms.TabPage LaderTypeTabPage;
        private System.Windows.Forms.CheckedListBox lstLaderTypeCheckBox;



    }
}
