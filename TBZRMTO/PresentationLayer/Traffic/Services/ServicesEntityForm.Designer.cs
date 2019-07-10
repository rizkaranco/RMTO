namespace HPS.Present.Services
{
    partial class ServicesEntityForm 

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
            this.ServicesType_nvcLabel = new System.Windows.Forms.Label();
            this.ServicesType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Activie_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(467, 11);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(467, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(467, 77);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(467, 110);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.ServicesType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.ServicesType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Activie_bitCheckBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 8);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(436, 94);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // ServicesType_nvcLabel
            // 
            this.ServicesType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesType_nvcLabel.AutoSize = true;
            this.ServicesType_nvcLabel.Location = new System.Drawing.Point(350, 28);
            this.ServicesType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ServicesType_nvcLabel.Name = "ServicesType_nvcLabel";
            this.ServicesType_nvcLabel.Size = new System.Drawing.Size(62, 23);
            this.ServicesType_nvcLabel.TabIndex = 0;
            this.ServicesType_nvcLabel.Text = "نوع خدمت";
            // 
            // ServicesType_nvcTextBox
            // 
            this.ServicesType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesType_nvcTextBox.Location = new System.Drawing.Point(15, 23);
            this.ServicesType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServicesType_nvcTextBox.MaxLength = 100;
            this.ServicesType_nvcTextBox.Name = "ServicesType_nvcTextBox";
            this.ServicesType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServicesType_nvcTextBox.Size = new System.Drawing.Size(325, 30);
            this.ServicesType_nvcTextBox.TabIndex = 1;
            this.ServicesType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Activie_bitCheckBox
            // 
            this.Activie_bitCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Activie_bitCheckBox.Location = new System.Drawing.Point(328, 56);
            this.Activie_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Activie_bitCheckBox.Name = "Activie_bitCheckBox";
            this.Activie_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Activie_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Activie_bitCheckBox.TabIndex = 2;
            this.Activie_bitCheckBox.Text = "فعال";
            this.Activie_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // ServicesEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 150);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "ServicesEntityForm";
            this.Text = "خدمات";
            this.Load += new System.EventHandler(this.ServicesEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label ServicesType_nvcLabel;
        
private System.Windows.Forms.TextBox ServicesType_nvcTextBox;






private System.Windows.Forms.CheckBox Activie_bitCheckBox;
    }
}
