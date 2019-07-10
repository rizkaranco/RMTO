namespace HPS.Present.TurnCancelComment
{
    partial class TurnCancelCommentEntityForm 

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
            this.TurnCancelComment_nvcLabel = new System.Windows.Forms.Label();
            this.UserGroupID_intLabel = new System.Windows.Forms.Label();
            this.UserGroupID_intNewButton = new System.Windows.Forms.Button();
            this.TurnCancelComment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UserGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(518, 25);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(518, 62);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(518, 99);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(518, 136);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.TurnCancelComment_nvcLabel);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.TurnCancelComment_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 1);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(497, 188);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // TurnCancelComment_nvcLabel
            // 
            this.TurnCancelComment_nvcLabel.AutoSize = true;
            this.TurnCancelComment_nvcLabel.Location = new System.Drawing.Point(353, 30);
            this.TurnCancelComment_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TurnCancelComment_nvcLabel.Name = "TurnCancelComment_nvcLabel";
            this.TurnCancelComment_nvcLabel.Size = new System.Drawing.Size(116, 23);
            this.TurnCancelComment_nvcLabel.TabIndex = 0;
            this.TurnCancelComment_nvcLabel.Text = "توضیحات ابطال نوبت";
            // 
            // UserGroupID_intLabel
            // 
            this.UserGroupID_intLabel.AutoSize = true;
            this.UserGroupID_intLabel.Location = new System.Drawing.Point(353, 144);
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
            this.UserGroupID_intNewButton.Location = new System.Drawing.Point(17, 137);
            this.UserGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroupID_intNewButton.Name = "UserGroupID_intNewButton";
            this.UserGroupID_intNewButton.Size = new System.Drawing.Size(37, 37);
            this.UserGroupID_intNewButton.TabIndex = 2;
            this.UserGroupID_intNewButton.TabStop = false;
            this.UserGroupID_intNewButton.Tag = "گروه جدید";
            this.UserGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.UserGroupID_intNewButton.Click += new System.EventHandler(this.UserGroupID_intNewButton_Click);
            // 
            // TurnCancelComment_nvcTextBox
            // 
            this.TurnCancelComment_nvcTextBox.Location = new System.Drawing.Point(17, 27);
            this.TurnCancelComment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TurnCancelComment_nvcTextBox.MaxLength = 500;
            this.TurnCancelComment_nvcTextBox.Multiline = true;
            this.TurnCancelComment_nvcTextBox.Name = "TurnCancelComment_nvcTextBox";
            this.TurnCancelComment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnCancelComment_nvcTextBox.Size = new System.Drawing.Size(326, 107);
            this.TurnCancelComment_nvcTextBox.TabIndex = 3;
            this.TurnCancelComment_nvcTextBox.Tag = "توضیحات ابطال نوبت";
            this.TurnCancelComment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserGroupID_intComboBox
            // 
            this.UserGroupID_intComboBox.FormattingEnabled = true;
            this.UserGroupID_intComboBox.Location = new System.Drawing.Point(57, 141);
            this.UserGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroupID_intComboBox.Name = "UserGroupID_intComboBox";
            this.UserGroupID_intComboBox.Size = new System.Drawing.Size(286, 31);
            this.UserGroupID_intComboBox.TabIndex = 4;
            this.UserGroupID_intComboBox.Tag = "کروه کاربری";
            // 
            // TurnCancelCommentEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 203);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "TurnCancelCommentEntityForm";
            this.Text = "توضیحات ابطال نوبت";
            this.Load += new System.EventHandler(this.TurnCancelCommentEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label TurnCancelComment_nvcLabel;
        
private System.Windows.Forms.TextBox TurnCancelComment_nvcTextBox;
        
private System.Windows.Forms.Label UserGroupID_intLabel;
       
private System.Windows.Forms.ComboBox UserGroupID_intComboBox;
        
private System.Windows.Forms.Button UserGroupID_intNewButton;
       
        
        
    }
}
