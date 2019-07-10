namespace HPS.Present.CarSystem
{
    partial class CarSystemEntityForm 

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
            this.CarSystem_nvcLabel = new System.Windows.Forms.Label();
            this.CarSystem_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(433, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(433, 47);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(433, 81);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(433, 113);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.CarSystem_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CarSystem_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 10);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(408, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // CarSystem_nvcLabel
            // 
            this.CarSystem_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarSystem_nvcLabel.AutoSize = true;
            this.CarSystem_nvcLabel.Location = new System.Drawing.Point(350, 34);
            this.CarSystem_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarSystem_nvcLabel.Name = "CarSystem_nvcLabel";
            this.CarSystem_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.CarSystem_nvcLabel.TabIndex = 0;
            this.CarSystem_nvcLabel.Text = "سیستم";
            // 
            // CarSystem_nvcTextBox
            // 
            this.CarSystem_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarSystem_nvcTextBox.Location = new System.Drawing.Point(13, 29);
            this.CarSystem_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CarSystem_nvcTextBox.MaxLength = 100;
            this.CarSystem_nvcTextBox.Name = "CarSystem_nvcTextBox";
            this.CarSystem_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarSystem_nvcTextBox.Size = new System.Drawing.Size(326, 30);
            this.CarSystem_nvcTextBox.TabIndex = 1;
            this.CarSystem_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CarSystemEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 150);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "CarSystemEntityForm";
            this.Text = "سیستم سواری";
            this.Load += new System.EventHandler(this.CarSystemEntityForm_Load);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label CarSystem_nvcLabel;
        
private System.Windows.Forms.TextBox CarSystem_nvcTextBox;
        
       
        
       
        
        
    }
}
