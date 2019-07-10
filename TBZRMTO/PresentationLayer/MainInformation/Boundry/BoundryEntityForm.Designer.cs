namespace HPS.Present.Boundry
{
    partial class BoundryEntityForm 

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
            this.BoundryCode_nvcLabel = new System.Windows.Forms.Label();
            this.Boundry_nvcLabel = new System.Windows.Forms.Label();
            this.BoundryCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Boundry_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(435, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(435, 42);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(435, 74);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(435, 106);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.BoundryCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Boundry_nvcLabel);
            this.DetailGropBox.Controls.Add(this.BoundryCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Boundry_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(15, 6);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(407, 127);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // BoundryCode_nvcLabel
            // 
            this.BoundryCode_nvcLabel.AutoSize = true;
            this.BoundryCode_nvcLabel.Location = new System.Drawing.Point(355, 30);
            this.BoundryCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BoundryCode_nvcLabel.Name = "BoundryCode_nvcLabel";
            this.BoundryCode_nvcLabel.Size = new System.Drawing.Size(43, 23);
            this.BoundryCode_nvcLabel.TabIndex = 0;
            this.BoundryCode_nvcLabel.Text = "کد مرز";
            // 
            // Boundry_nvcLabel
            // 
            this.Boundry_nvcLabel.AutoSize = true;
            this.Boundry_nvcLabel.Location = new System.Drawing.Point(355, 76);
            this.Boundry_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Boundry_nvcLabel.Name = "Boundry_nvcLabel";
            this.Boundry_nvcLabel.Size = new System.Drawing.Size(45, 23);
            this.Boundry_nvcLabel.TabIndex = 1;
            this.Boundry_nvcLabel.Text = "نام مرز";
            // 
            // BoundryCode_nvcTextBox
            // 
            this.BoundryCode_nvcTextBox.Location = new System.Drawing.Point(17, 27);
            this.BoundryCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BoundryCode_nvcTextBox.MaxLength = 50;
            this.BoundryCode_nvcTextBox.Name = "BoundryCode_nvcTextBox";
            this.BoundryCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoundryCode_nvcTextBox.Size = new System.Drawing.Size(328, 30);
            this.BoundryCode_nvcTextBox.TabIndex = 2;
            this.BoundryCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Boundry_nvcTextBox
            // 
            this.Boundry_nvcTextBox.Location = new System.Drawing.Point(17, 73);
            this.Boundry_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Boundry_nvcTextBox.MaxLength = 50;
            this.Boundry_nvcTextBox.Name = "Boundry_nvcTextBox";
            this.Boundry_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Boundry_nvcTextBox.Size = new System.Drawing.Size(328, 30);
            this.Boundry_nvcTextBox.TabIndex = 3;
            this.Boundry_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BoundryEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 145);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "BoundryEntityForm";
            this.Text = "مرزها";
            this.Load += new System.EventHandler(this.BoundryEntityForm_Load);
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
        
private System.Windows.Forms.Label BoundryCode_nvcLabel;
private System.Windows.Forms.Label Boundry_nvcLabel;
        
private System.Windows.Forms.TextBox BoundryCode_nvcTextBox;
private System.Windows.Forms.TextBox Boundry_nvcTextBox;
        
       
        
       
        
        
    }
}
