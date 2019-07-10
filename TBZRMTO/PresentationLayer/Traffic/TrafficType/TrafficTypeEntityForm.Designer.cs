namespace HPS.Present.TrafficType
{
    partial class TrafficTypeEntityForm 

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
            this.TrafficType_nvcLabel = new System.Windows.Forms.Label();
            this.TrafficType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(404, 7);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(404, 39);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(404, 71);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(404, 103);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.TrafficType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.TrafficType_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(11, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(382, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // TrafficType_nvcLabel
            // 
            this.TrafficType_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficType_nvcLabel.AutoSize = true;
            this.TrafficType_nvcLabel.Location = new System.Drawing.Point(321, 36);
            this.TrafficType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TrafficType_nvcLabel.Name = "TrafficType_nvcLabel";
            this.TrafficType_nvcLabel.Size = new System.Drawing.Size(53, 23);
            this.TrafficType_nvcLabel.TabIndex = 0;
            this.TrafficType_nvcLabel.Text = "نوع تردد";
            // 
            // TrafficType_nvcTextBox
            // 
            this.TrafficType_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficType_nvcTextBox.Location = new System.Drawing.Point(13, 33);
            this.TrafficType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TrafficType_nvcTextBox.MaxLength = 100;
            this.TrafficType_nvcTextBox.Name = "TrafficType_nvcTextBox";
            this.TrafficType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrafficType_nvcTextBox.Size = new System.Drawing.Size(298, 30);
            this.TrafficType_nvcTextBox.TabIndex = 1;
            this.TrafficType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrafficTypeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 145);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "TrafficTypeEntityForm";
            this.Text = "نوع تردد";
            this.Load += new System.EventHandler(this.TrafficTypeEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label TrafficType_nvcLabel;
        
private System.Windows.Forms.TextBox TrafficType_nvcTextBox;
        
       
        
       
        
        
    }
}
