namespace HPS.Present.DestinationAddress
{
    partial class DestinationAddressEntityForm 

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
            this.DestinationAddress_nvcLabel = new System.Windows.Forms.Label();
            this.DestinationAddress_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(494, 14);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(494, 48);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(494, 82);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(494, 116);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.DestinationAddress_nvcLabel);
            this.DetailGropBox.Controls.Add(this.DestinationAddress_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 14);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(467, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // DestinationAddress_nvcLabel
            // 
            this.DestinationAddress_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationAddress_nvcLabel.AutoSize = true;
            this.DestinationAddress_nvcLabel.Location = new System.Drawing.Point(387, 38);
            this.DestinationAddress_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DestinationAddress_nvcLabel.Name = "DestinationAddress_nvcLabel";
            this.DestinationAddress_nvcLabel.Size = new System.Drawing.Size(71, 23);
            this.DestinationAddress_nvcLabel.TabIndex = 0;
            this.DestinationAddress_nvcLabel.Text = "آدرس مقصد";
            // 
            // DestinationAddress_nvcTextBox
            // 
            this.DestinationAddress_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationAddress_nvcTextBox.Location = new System.Drawing.Point(10, 33);
            this.DestinationAddress_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DestinationAddress_nvcTextBox.MaxLength = 300;
            this.DestinationAddress_nvcTextBox.Name = "DestinationAddress_nvcTextBox";
            this.DestinationAddress_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DestinationAddress_nvcTextBox.Size = new System.Drawing.Size(367, 30);
            this.DestinationAddress_nvcTextBox.TabIndex = 1;
            this.DestinationAddress_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DestinationAddressEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 158);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "DestinationAddressEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آدرس مقصد";
            this.Load += new System.EventHandler(this.DestinationAddressEntityForm_Load);
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
        
private System.Windows.Forms.Label DestinationAddress_nvcLabel;
        
private System.Windows.Forms.TextBox DestinationAddress_nvcTextBox;
        
       
        
       
        
        
    }
}
