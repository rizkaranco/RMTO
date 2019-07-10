namespace HPS.Present.AnnouncementTime
{
    partial class AnnouncementTimeEntityForm 

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
            this.EndTime_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTime_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AnnouncementTime_nvcLabel = new System.Windows.Forms.Label();
            this.StartTime_nvcLabel = new System.Windows.Forms.Label();
            this.EndTime_nvcLabel = new System.Windows.Forms.Label();
            this.AnnouncementTime_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(417, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(417, 42);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(417, 106);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(417, 74);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.EndTime_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.StartTime_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.AnnouncementTime_nvcLabel);
            this.DetailGropBox.Controls.Add(this.StartTime_nvcLabel);
            this.DetailGropBox.Controls.Add(this.EndTime_nvcLabel);
            this.DetailGropBox.Controls.Add(this.AnnouncementTime_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(8, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(396, 137);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // EndTime_nvcTextBox
            // 
            this.EndTime_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTime_nvcTextBox.Location = new System.Drawing.Point(9, 94);
            this.EndTime_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EndTime_nvcTextBox.Mask = "00:00";
            this.EndTime_nvcTextBox.Name = "EndTime_nvcTextBox";
            this.EndTime_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndTime_nvcTextBox.Size = new System.Drawing.Size(279, 30);
            this.EndTime_nvcTextBox.TabIndex = 2;
            this.EndTime_nvcTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // StartTime_nvcTextBox
            // 
            this.StartTime_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTime_nvcTextBox.Location = new System.Drawing.Point(9, 58);
            this.StartTime_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.StartTime_nvcTextBox.Mask = "00:00";
            this.StartTime_nvcTextBox.Name = "StartTime_nvcTextBox";
            this.StartTime_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartTime_nvcTextBox.Size = new System.Drawing.Size(279, 30);
            this.StartTime_nvcTextBox.TabIndex = 1;
            this.StartTime_nvcTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // AnnouncementTime_nvcLabel
            // 
            this.AnnouncementTime_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnouncementTime_nvcLabel.AutoSize = true;
            this.AnnouncementTime_nvcLabel.Location = new System.Drawing.Point(299, 28);
            this.AnnouncementTime_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AnnouncementTime_nvcLabel.Name = "AnnouncementTime_nvcLabel";
            this.AnnouncementTime_nvcLabel.Size = new System.Drawing.Size(88, 23);
            this.AnnouncementTime_nvcLabel.TabIndex = 0;
            this.AnnouncementTime_nvcLabel.Text = "اطلاع رسانی بار";
            // 
            // StartTime_nvcLabel
            // 
            this.StartTime_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTime_nvcLabel.AutoSize = true;
            this.StartTime_nvcLabel.Location = new System.Drawing.Point(299, 67);
            this.StartTime_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartTime_nvcLabel.Name = "StartTime_nvcLabel";
            this.StartTime_nvcLabel.Size = new System.Drawing.Size(68, 23);
            this.StartTime_nvcLabel.TabIndex = 1;
            this.StartTime_nvcLabel.Text = "زمان شروع";
            // 
            // EndTime_nvcLabel
            // 
            this.EndTime_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTime_nvcLabel.AutoSize = true;
            this.EndTime_nvcLabel.Location = new System.Drawing.Point(299, 96);
            this.EndTime_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EndTime_nvcLabel.Name = "EndTime_nvcLabel";
            this.EndTime_nvcLabel.Size = new System.Drawing.Size(63, 23);
            this.EndTime_nvcLabel.TabIndex = 2;
            this.EndTime_nvcLabel.Text = "زمان اتمام";
            // 
            // AnnouncementTime_nvcTextBox
            // 
            this.AnnouncementTime_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnouncementTime_nvcTextBox.Location = new System.Drawing.Point(9, 23);
            this.AnnouncementTime_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AnnouncementTime_nvcTextBox.MaxLength = 30;
            this.AnnouncementTime_nvcTextBox.Name = "AnnouncementTime_nvcTextBox";
            this.AnnouncementTime_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnnouncementTime_nvcTextBox.Size = new System.Drawing.Size(279, 30);
            this.AnnouncementTime_nvcTextBox.TabIndex = 0;
            this.AnnouncementTime_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnnouncementTimeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 153);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "AnnouncementTimeEntityForm";
            this.Text = "زمان های اطلاع رسانی بار";
            this.Load += new System.EventHandler(this.AnnouncementTimeEntityForm_Load);
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
        
private System.Windows.Forms.Label AnnouncementTime_nvcLabel;
private System.Windows.Forms.Label StartTime_nvcLabel;
private System.Windows.Forms.Label EndTime_nvcLabel;

private System.Windows.Forms.TextBox AnnouncementTime_nvcTextBox;
private System.Windows.Forms.MaskedTextBox StartTime_nvcTextBox;
private System.Windows.Forms.MaskedTextBox EndTime_nvcTextBox;
        
       
        
       
        
        
    }
}
