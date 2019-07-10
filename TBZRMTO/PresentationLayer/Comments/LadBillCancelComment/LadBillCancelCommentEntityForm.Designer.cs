namespace HPS.Present.LadBillCancelComment
{
    partial class LadBillCancelCommentEntityForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadBillCancelCommentEntityForm));
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.LadbillCancelComment_nvcLabel = new System.Windows.Forms.Label();
            this.UserGroupID_intLabel = new System.Windows.Forms.Label();
            this.UserGroupID_intNewButton = new System.Windows.Forms.Button();
            this.LadbillCancelComment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UserGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(525, 25);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(526, 60);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(526, 95);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(526, 130);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.LadbillCancelComment_nvcLabel);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.LadbillCancelComment_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(8, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(511, 177);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // LadbillCancelComment_nvcLabel
            // 
            this.LadbillCancelComment_nvcLabel.AutoSize = true;
            this.LadbillCancelComment_nvcLabel.Location = new System.Drawing.Point(391, 32);
            this.LadbillCancelComment_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LadbillCancelComment_nvcLabel.Name = "LadbillCancelComment_nvcLabel";
            this.LadbillCancelComment_nvcLabel.Size = new System.Drawing.Size(118, 23);
            this.LadbillCancelComment_nvcLabel.TabIndex = 0;
            this.LadbillCancelComment_nvcLabel.Text = "توضیحات ابطال مجوز";
            // 
            // UserGroupID_intLabel
            // 
            this.UserGroupID_intLabel.AutoSize = true;
            this.UserGroupID_intLabel.Location = new System.Drawing.Point(391, 138);
            this.UserGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserGroupID_intLabel.Name = "UserGroupID_intLabel";
            this.UserGroupID_intLabel.Size = new System.Drawing.Size(74, 23);
            this.UserGroupID_intLabel.TabIndex = 1;
            this.UserGroupID_intLabel.Text = "گروه کاربری";
            // 
            // UserGroupID_intNewButton
            // 
            this.UserGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window; 
            this.UserGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserGroupID_intNewButton.Location = new System.Drawing.Point(15, 133);
            this.UserGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroupID_intNewButton.Name = "UserGroupID_intNewButton";
            this.UserGroupID_intNewButton.Size = new System.Drawing.Size(37, 31);
            this.UserGroupID_intNewButton.TabIndex = 2;
            this.UserGroupID_intNewButton.TabStop = false;
            this.UserGroupID_intNewButton.Tag = "گروه جدید در توضیحات ابطلال مجوز";
            this.UserGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.UserGroupID_intNewButton.Click += new System.EventHandler(this.UserGroupID_intNewButton_Click);
            // 
            // LadbillCancelComment_nvcTextBox
            // 
            this.LadbillCancelComment_nvcTextBox.Location = new System.Drawing.Point(14, 27);
            this.LadbillCancelComment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.LadbillCancelComment_nvcTextBox.MaxLength = 500;
            this.LadbillCancelComment_nvcTextBox.Multiline = true;
            this.LadbillCancelComment_nvcTextBox.Name = "LadbillCancelComment_nvcTextBox";
            this.LadbillCancelComment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LadbillCancelComment_nvcTextBox.Size = new System.Drawing.Size(373, 100);
            this.LadbillCancelComment_nvcTextBox.TabIndex = 3;
            this.LadbillCancelComment_nvcTextBox.Tag = "توضیحات ابطال مجوز";
            this.LadbillCancelComment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserGroupID_intComboBox
            // 
            this.UserGroupID_intComboBox.FormattingEnabled = true;
            this.UserGroupID_intComboBox.Location = new System.Drawing.Point(55, 133);
            this.UserGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroupID_intComboBox.Name = "UserGroupID_intComboBox";
            this.UserGroupID_intComboBox.Size = new System.Drawing.Size(333, 31);
            this.UserGroupID_intComboBox.TabIndex = 4;
            this.UserGroupID_intComboBox.Tag = "گروه کاربری";
            // 
            // LadBillCancelCommentEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 193);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "LadBillCancelCommentEntityForm";
            this.Text = "توضیحات ابطال مجوز";
            this.Load += new System.EventHandler(this.LadBillCancelCommentEntityForm_Load);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label LadbillCancelComment_nvcLabel;
        
private System.Windows.Forms.TextBox LadbillCancelComment_nvcTextBox;
        
private System.Windows.Forms.Label UserGroupID_intLabel;
       
private System.Windows.Forms.ComboBox UserGroupID_intComboBox;
        
private System.Windows.Forms.Button UserGroupID_intNewButton;
       
        
        
    }
}
