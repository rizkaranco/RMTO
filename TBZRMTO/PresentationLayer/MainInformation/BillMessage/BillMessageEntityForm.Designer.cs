namespace HPS.Present.BillMessage
{
    partial class BillMessageEntityForm
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
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.SaloonID_intComboBox = new System.Windows.Forms.ComboBox();
            this.ShowInSaloncheckBox = new System.Windows.Forms.CheckBox();
            this.EndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Message_nvcLabel = new System.Windows.Forms.Label();
            this.StartDate_nvcLabel = new System.Windows.Forms.Label();
            this.EndDate_nvcLabel = new System.Windows.Forms.Label();
            this.BillID_intLabel = new System.Windows.Forms.Label();
            this.Message_nvcTextBox = new System.Windows.Forms.TextBox();
            this.BillID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(487, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.TabIndex = 0;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(487, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndCloseButton.TabIndex = 1;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(487, 78);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DeleteRecordButton.TabIndex = 2;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(487, 112);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CloseFormButton.TabIndex = 3;
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.SaloonID_intComboBox);
            this.DetailGropBox.Controls.Add(this.ShowInSaloncheckBox);
            this.DetailGropBox.Controls.Add(this.EndDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.StartDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Message_nvcLabel);
            this.DetailGropBox.Controls.Add(this.StartDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.EndDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.BillID_intLabel);
            this.DetailGropBox.Controls.Add(this.Message_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.BillID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(15, 1);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(458, 283);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(372, 59);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(81, 23);
            this.LaderPivotGroupID_intLabel.TabIndex = 9;
            this.LaderPivotGroupID_intLabel.Text = "سالن بارگیری";
            this.LaderPivotGroupID_intLabel.Visible = false;
            // 
            // SaloonID_intComboBox
            // 
            this.SaloonID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaloonID_intComboBox.FormattingEnabled = true;
            this.SaloonID_intComboBox.Location = new System.Drawing.Point(13, 55);
            this.SaloonID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.SaloonID_intComboBox.Name = "SaloonID_intComboBox";
            this.SaloonID_intComboBox.Size = new System.Drawing.Size(360, 31);
            this.SaloonID_intComboBox.TabIndex = 10;
            this.SaloonID_intComboBox.Visible = false;
            // 
            // ShowInSaloncheckBox
            // 
            this.ShowInSaloncheckBox.AutoSize = true;
            this.ShowInSaloncheckBox.Location = new System.Drawing.Point(13, 22);
            this.ShowInSaloncheckBox.Name = "ShowInSaloncheckBox";
            this.ShowInSaloncheckBox.Size = new System.Drawing.Size(175, 27);
            this.ShowInSaloncheckBox.TabIndex = 5;
            this.ShowInSaloncheckBox.Text = "نمایش در اطلاع رسانی سالن";
            this.ShowInSaloncheckBox.UseVisualStyleBackColor = true;
            this.ShowInSaloncheckBox.CheckedChanged += new System.EventHandler(this.ShowInSaloncheckBox_CheckedChanged);
            // 
            // EndDate_nvcTextBox
            // 
            this.EndDate_nvcTextBox.Location = new System.Drawing.Point(13, 244);
            this.EndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EndDate_nvcTextBox.Mask = "0000/00/00";
            this.EndDate_nvcTextBox.Name = "EndDate_nvcTextBox";
            this.EndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDate_nvcTextBox.Size = new System.Drawing.Size(94, 30);
            this.EndDate_nvcTextBox.TabIndex = 4;
            this.EndDate_nvcTextBox.Tag = "تا تاریخ";
            // 
            // StartDate_nvcTextBox
            // 
            this.StartDate_nvcTextBox.Location = new System.Drawing.Point(279, 243);
            this.StartDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StartDate_nvcTextBox.Mask = "0000/00/00";
            this.StartDate_nvcTextBox.Name = "StartDate_nvcTextBox";
            this.StartDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDate_nvcTextBox.Size = new System.Drawing.Size(94, 30);
            this.StartDate_nvcTextBox.TabIndex = 3;
            this.StartDate_nvcTextBox.Tag = "از تاریخ";
            this.StartDate_nvcTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.StartDate_nvcTextBox_MaskInputRejected);
            // 
            // Message_nvcLabel
            // 
            this.Message_nvcLabel.AutoSize = true;
            this.Message_nvcLabel.Location = new System.Drawing.Point(372, 97);
            this.Message_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Message_nvcLabel.Name = "Message_nvcLabel";
            this.Message_nvcLabel.Size = new System.Drawing.Size(30, 23);
            this.Message_nvcLabel.TabIndex = 0;
            this.Message_nvcLabel.Text = "پیام";
            // 
            // StartDate_nvcLabel
            // 
            this.StartDate_nvcLabel.AutoSize = true;
            this.StartDate_nvcLabel.Location = new System.Drawing.Point(372, 244);
            this.StartDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartDate_nvcLabel.Name = "StartDate_nvcLabel";
            this.StartDate_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.StartDate_nvcLabel.TabIndex = 1;
            this.StartDate_nvcLabel.Text = "از تاریخ";
            // 
            // EndDate_nvcLabel
            // 
            this.EndDate_nvcLabel.AutoSize = true;
            this.EndDate_nvcLabel.Location = new System.Drawing.Point(113, 247);
            this.EndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EndDate_nvcLabel.Name = "EndDate_nvcLabel";
            this.EndDate_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.EndDate_nvcLabel.TabIndex = 2;
            this.EndDate_nvcLabel.Text = "تا تاریخ";
            // 
            // BillID_intLabel
            // 
            this.BillID_intLabel.AutoSize = true;
            this.BillID_intLabel.Location = new System.Drawing.Point(372, 21);
            this.BillID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BillID_intLabel.Name = "BillID_intLabel";
            this.BillID_intLabel.Size = new System.Drawing.Size(36, 23);
            this.BillID_intLabel.TabIndex = 3;
            this.BillID_intLabel.Text = "قبض";
            // 
            // Message_nvcTextBox
            // 
            this.Message_nvcTextBox.Location = new System.Drawing.Point(13, 96);
            this.Message_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Message_nvcTextBox.MaxLength = 1000;
            this.Message_nvcTextBox.Multiline = true;
            this.Message_nvcTextBox.Name = "Message_nvcTextBox";
            this.Message_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Message_nvcTextBox.Size = new System.Drawing.Size(360, 138);
            this.Message_nvcTextBox.TabIndex = 2;
            this.Message_nvcTextBox.Tag = "پیام";
            this.Message_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BillID_intComboBox
            // 
            this.BillID_intComboBox.FormattingEnabled = true;
            this.BillID_intComboBox.Location = new System.Drawing.Point(194, 20);
            this.BillID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.BillID_intComboBox.MaxDropDownItems = 15;
            this.BillID_intComboBox.Name = "BillID_intComboBox";
            this.BillID_intComboBox.Size = new System.Drawing.Size(179, 31);
            this.BillID_intComboBox.TabIndex = 0;
            this.BillID_intComboBox.Tag = "قبض";
            // 
            // BillMessageEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 291);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "BillMessageEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیام قبض";
            this.Load += new System.EventHandler(this.BillMessageEntityForm_Load);
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

        private System.Windows.Forms.Label Message_nvcLabel;
        private System.Windows.Forms.Label StartDate_nvcLabel;
        private System.Windows.Forms.Label EndDate_nvcLabel;

        private System.Windows.Forms.TextBox Message_nvcTextBox;

        private System.Windows.Forms.Label BillID_intLabel;

        private System.Windows.Forms.ComboBox BillID_intComboBox;
        private System.Windows.Forms.MaskedTextBox EndDate_nvcTextBox;
        private System.Windows.Forms.MaskedTextBox StartDate_nvcTextBox;
        private System.Windows.Forms.CheckBox ShowInSaloncheckBox;
        private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
        private System.Windows.Forms.ComboBox SaloonID_intComboBox;



    }
}
