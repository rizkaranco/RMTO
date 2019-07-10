namespace HPS.Present.Boxing
{
    partial class BoxingEntityForm 

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
            this.BoxingCode_nvcLabel = new System.Windows.Forms.Label();
            this.BoxingType_nvcLabel = new System.Windows.Forms.Label();
            this.BoxingCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.BoxingType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(475, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(475, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(475, 78);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(475, 112);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.BoxingCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.BoxingType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.BoxingCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.BoxingType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Location = new System.Drawing.Point(9, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(454, 143);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // BoxingCode_nvcLabel
            // 
            this.BoxingCode_nvcLabel.AutoSize = true;
            this.BoxingCode_nvcLabel.Location = new System.Drawing.Point(360, 29);
            this.BoxingCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BoxingCode_nvcLabel.Name = "BoxingCode_nvcLabel";
            this.BoxingCode_nvcLabel.Size = new System.Drawing.Size(79, 23);
            this.BoxingCode_nvcLabel.TabIndex = 0;
            this.BoxingCode_nvcLabel.Text = "کد بسته بندی";
            // 
            // BoxingType_nvcLabel
            // 
            this.BoxingType_nvcLabel.AutoSize = true;
            this.BoxingType_nvcLabel.Location = new System.Drawing.Point(360, 75);
            this.BoxingType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BoxingType_nvcLabel.Name = "BoxingType_nvcLabel";
            this.BoxingType_nvcLabel.Size = new System.Drawing.Size(86, 23);
            this.BoxingType_nvcLabel.TabIndex = 1;
            this.BoxingType_nvcLabel.Text = " نوع بسته بندی";
            // 
            // BoxingCode_nvcTextBox
            // 
            this.BoxingCode_nvcTextBox.Location = new System.Drawing.Point(17, 27);
            this.BoxingCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BoxingCode_nvcTextBox.MaxLength = 10;
            this.BoxingCode_nvcTextBox.Name = "BoxingCode_nvcTextBox";
            this.BoxingCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxingCode_nvcTextBox.Size = new System.Drawing.Size(341, 30);
            this.BoxingCode_nvcTextBox.TabIndex = 2;
            this.BoxingCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BoxingType_nvcTextBox
            // 
            this.BoxingType_nvcTextBox.Location = new System.Drawing.Point(17, 73);
            this.BoxingType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BoxingType_nvcTextBox.MaxLength = 50;
            this.BoxingType_nvcTextBox.Name = "BoxingType_nvcTextBox";
            this.BoxingType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxingType_nvcTextBox.Size = new System.Drawing.Size(341, 30);
            this.BoxingType_nvcTextBox.TabIndex = 3;
            this.BoxingType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Location = new System.Drawing.Point(345, 110);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 4;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // BoxingEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 156);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "BoxingEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بسته بندی";
            this.Load += new System.EventHandler(this.BoxingEntityForm_Load);
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
        
private System.Windows.Forms.Label BoxingCode_nvcLabel;
private System.Windows.Forms.Label BoxingType_nvcLabel;
        
private System.Windows.Forms.TextBox BoxingCode_nvcTextBox;
private System.Windows.Forms.TextBox BoxingType_nvcTextBox;
        
       
        
       
        
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
    }
}
