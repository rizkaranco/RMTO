namespace HPS.Present.News
{
    partial class NewsEntityForm 

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
            this.EndDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Title_nvcLabel = new System.Windows.Forms.Label();
            this.News_nvcLabel = new System.Windows.Forms.Label();
            this.StartDate_nvcLabel = new System.Windows.Forms.Label();
            this.EndDate_nvcLabel = new System.Windows.Forms.Label();
            this.Title_nvcTextBox = new System.Windows.Forms.TextBox();
            this.News_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(519, 8);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(519, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(519, 80);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(519, 116);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.EndDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.StartDate_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Title_nvcLabel);
            this.DetailGropBox.Controls.Add(this.News_nvcLabel);
            this.DetailGropBox.Controls.Add(this.StartDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.EndDate_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Title_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.News_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(11, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(497, 250);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // EndDate_nvcTextBox
            // 
            this.EndDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDate_nvcTextBox.Location = new System.Drawing.Point(14, 207);
            this.EndDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.EndDate_nvcTextBox.Mask = "0000/00/00";
            this.EndDate_nvcTextBox.Name = "EndDate_nvcTextBox";
            this.EndDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EndDate_nvcTextBox.Size = new System.Drawing.Size(349, 30);
            this.EndDate_nvcTextBox.TabIndex = 3;
            this.EndDate_nvcTextBox.Tag = "تا تاریخ";
            // 
            // StartDate_nvcTextBox
            // 
            this.StartDate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDate_nvcTextBox.Location = new System.Drawing.Point(14, 170);
            this.StartDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.StartDate_nvcTextBox.Mask = "0000/00/00";
            this.StartDate_nvcTextBox.Name = "StartDate_nvcTextBox";
            this.StartDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartDate_nvcTextBox.Size = new System.Drawing.Size(349, 30);
            this.StartDate_nvcTextBox.TabIndex = 2;
            this.StartDate_nvcTextBox.Tag = "از تاریخ";
            // 
            // Title_nvcLabel
            // 
            this.Title_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_nvcLabel.AutoSize = true;
            this.Title_nvcLabel.Location = new System.Drawing.Point(373, 32);
            this.Title_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title_nvcLabel.Name = "Title_nvcLabel";
            this.Title_nvcLabel.Size = new System.Drawing.Size(62, 23);
            this.Title_nvcLabel.TabIndex = 0;
            this.Title_nvcLabel.Text = "عنوان خبر";
            // 
            // News_nvcLabel
            // 
            this.News_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.News_nvcLabel.AutoSize = true;
            this.News_nvcLabel.Location = new System.Drawing.Point(373, 70);
            this.News_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.News_nvcLabel.Name = "News_nvcLabel";
            this.News_nvcLabel.Size = new System.Drawing.Size(52, 23);
            this.News_nvcLabel.TabIndex = 1;
            this.News_nvcLabel.Text = "متن خبر";
            // 
            // StartDate_nvcLabel
            // 
            this.StartDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDate_nvcLabel.AutoSize = true;
            this.StartDate_nvcLabel.Location = new System.Drawing.Point(373, 175);
            this.StartDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartDate_nvcLabel.Name = "StartDate_nvcLabel";
            this.StartDate_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.StartDate_nvcLabel.TabIndex = 2;
            this.StartDate_nvcLabel.Text = "از تاریخ";
            // 
            // EndDate_nvcLabel
            // 
            this.EndDate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDate_nvcLabel.AutoSize = true;
            this.EndDate_nvcLabel.Location = new System.Drawing.Point(373, 214);
            this.EndDate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EndDate_nvcLabel.Name = "EndDate_nvcLabel";
            this.EndDate_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.EndDate_nvcLabel.TabIndex = 3;
            this.EndDate_nvcLabel.Text = "تا تاریخ";
            // 
            // Title_nvcTextBox
            // 
            this.Title_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_nvcTextBox.Location = new System.Drawing.Point(14, 27);
            this.Title_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Title_nvcTextBox.MaxLength = 100;
            this.Title_nvcTextBox.Name = "Title_nvcTextBox";
            this.Title_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title_nvcTextBox.Size = new System.Drawing.Size(349, 30);
            this.Title_nvcTextBox.TabIndex = 0;
            this.Title_nvcTextBox.Tag = "عنوان خبر";
            this.Title_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // News_nvcTextBox
            // 
            this.News_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.News_nvcTextBox.Location = new System.Drawing.Point(14, 65);
            this.News_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.News_nvcTextBox.MaxLength = 1000;
            this.News_nvcTextBox.Multiline = true;
            this.News_nvcTextBox.Name = "News_nvcTextBox";
            this.News_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.News_nvcTextBox.Size = new System.Drawing.Size(349, 98);
            this.News_nvcTextBox.TabIndex = 1;
            this.News_nvcTextBox.Tag = "متن خبر";
            this.News_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewsEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 265);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "NewsEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اخبار";
            this.Load += new System.EventHandler(this.NewsEntityForm_Load);
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
        
private System.Windows.Forms.Label Title_nvcLabel;
private System.Windows.Forms.Label News_nvcLabel;
private System.Windows.Forms.Label StartDate_nvcLabel;
private System.Windows.Forms.Label EndDate_nvcLabel;
        
private System.Windows.Forms.TextBox Title_nvcTextBox;
private System.Windows.Forms.TextBox News_nvcTextBox;
private System.Windows.Forms.MaskedTextBox EndDate_nvcTextBox;
private System.Windows.Forms.MaskedTextBox StartDate_nvcTextBox;
        
       
        
       
        
        
    }
}
