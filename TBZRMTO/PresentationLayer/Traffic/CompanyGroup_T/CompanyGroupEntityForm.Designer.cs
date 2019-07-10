namespace HPS.Present.CompanyGroup
{
    partial class CompanyGroupEntityForm 

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
            this.GroupName_nvcLabel = new System.Windows.Forms.Label();
            this.GroupName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(455, 21);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.Size = new System.Drawing.Size(81, 30);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(455, 53);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndCloseButton.Size = new System.Drawing.Size(81, 30);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(455, 85);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DeleteRecordButton.Size = new System.Drawing.Size(81, 30);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(455, 117);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CloseFormButton.Size = new System.Drawing.Size(81, 30);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.GroupName_nvcLabel);
            this.DetailGropBox.Controls.Add(this.GroupName_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(25, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(404, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // GroupName_nvcLabel
            // 
            this.GroupName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName_nvcLabel.AutoSize = true;
            this.GroupName_nvcLabel.Location = new System.Drawing.Point(336, 32);
            this.GroupName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GroupName_nvcLabel.Name = "GroupName_nvcLabel";
            this.GroupName_nvcLabel.Size = new System.Drawing.Size(53, 23);
            this.GroupName_nvcLabel.TabIndex = 0;
            this.GroupName_nvcLabel.Text = "نام گروه";
            // 
            // GroupName_nvcTextBox
            // 
            this.GroupName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName_nvcTextBox.Location = new System.Drawing.Point(27, 29);
            this.GroupName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GroupName_nvcTextBox.MaxLength = 50;
            this.GroupName_nvcTextBox.Name = "GroupName_nvcTextBox";
            this.GroupName_nvcTextBox.Size = new System.Drawing.Size(299, 30);
            this.GroupName_nvcTextBox.TabIndex = 1;
            // 
            // CompanyGroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 156);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
            this.Name = "CompanyGroupEntityForm";
            this.Text = "گروه شرکت ها";
            this.Load += new System.EventHandler(this.CompanyGroupEntityForm_Load);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label GroupName_nvcLabel;
        
private System.Windows.Forms.TextBox GroupName_nvcTextBox;
        
       
        
       
        
        
        
        
        
        
        
        
        
    }
}
