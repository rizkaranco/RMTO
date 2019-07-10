namespace HPS.Present.Class
{
    partial class ClassEntityForm 

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
            this.ClassName_nvcLabel = new System.Windows.Forms.Label();
            this.ClassName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(478, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(478, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(478, 81);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(478, 118);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.ClassName_nvcLabel);
            this.DetailGropBox.Controls.Add(this.ClassName_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(452, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // ClassName_nvcLabel
            // 
            this.ClassName_nvcLabel.AutoSize = true;
            this.ClassName_nvcLabel.Location = new System.Drawing.Point(376, 30);
            this.ClassName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ClassName_nvcLabel.Name = "ClassName_nvcLabel";
            this.ClassName_nvcLabel.Size = new System.Drawing.Size(59, 23);
            this.ClassName_nvcLabel.TabIndex = 0;
            this.ClassName_nvcLabel.Text = "نام كلاس";
            // 
            // ClassName_nvcTextBox
            // 
            this.ClassName_nvcTextBox.Location = new System.Drawing.Point(13, 27);
            this.ClassName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ClassName_nvcTextBox.MaxLength = 150;
            this.ClassName_nvcTextBox.Name = "ClassName_nvcTextBox";
            this.ClassName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClassName_nvcTextBox.Size = new System.Drawing.Size(353, 30);
            this.ClassName_nvcTextBox.TabIndex = 1;
            this.ClassName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClassEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 156);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "ClassEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کلاس های آموزشی";
            this.Load += new System.EventHandler(this.ClassEntityForm_Load);
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
        
private System.Windows.Forms.Label ClassName_nvcLabel;
        
private System.Windows.Forms.TextBox ClassName_nvcTextBox;
        
       
        
       
        
        
    }
}
