namespace HPS.Present.Color
{
    partial class ColorEntityForm 

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
            this.Color_nvcLabel = new System.Windows.Forms.Label();
            this.ColorCode_nvcLabel = new System.Windows.Forms.Label();
            this.Color_nvcTextBox = new System.Windows.Forms.TextBox();
            this.ColorCode_nvcTextBox = new System.Windows.Forms.TextBox();
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
            this.DeleteRecordButton.Location = new System.Drawing.Point(478, 78);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(478, 111);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.Color_nvcLabel);
            this.DetailGropBox.Controls.Add(this.ColorCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.Color_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.ColorCode_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(413, 127);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // Color_nvcLabel
            // 
            this.Color_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Color_nvcLabel.AutoSize = true;
            this.Color_nvcLabel.Location = new System.Drawing.Point(354, 40);
            this.Color_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Color_nvcLabel.Name = "Color_nvcLabel";
            this.Color_nvcLabel.Size = new System.Drawing.Size(32, 23);
            this.Color_nvcLabel.TabIndex = 0;
            this.Color_nvcLabel.Text = "رنگ";
            // 
            // ColorCode_nvcLabel
            // 
            this.ColorCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorCode_nvcLabel.AutoSize = true;
            this.ColorCode_nvcLabel.Location = new System.Drawing.Point(354, 86);
            this.ColorCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ColorCode_nvcLabel.Name = "ColorCode_nvcLabel";
            this.ColorCode_nvcLabel.Size = new System.Drawing.Size(48, 23);
            this.ColorCode_nvcLabel.TabIndex = 1;
            this.ColorCode_nvcLabel.Text = "کد رنگ";
            // 
            // Color_nvcTextBox
            // 
            this.Color_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Color_nvcTextBox.Location = new System.Drawing.Point(11, 33);
            this.Color_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Color_nvcTextBox.MaxLength = 50;
            this.Color_nvcTextBox.Name = "Color_nvcTextBox";
            this.Color_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Color_nvcTextBox.Size = new System.Drawing.Size(333, 30);
            this.Color_nvcTextBox.TabIndex = 2;
            this.Color_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ColorCode_nvcTextBox
            // 
            this.ColorCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorCode_nvcTextBox.Location = new System.Drawing.Point(11, 79);
            this.ColorCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ColorCode_nvcTextBox.MaxLength = 50;
            this.ColorCode_nvcTextBox.Name = "ColorCode_nvcTextBox";
            this.ColorCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorCode_nvcTextBox.Size = new System.Drawing.Size(333, 30);
            this.ColorCode_nvcTextBox.TabIndex = 3;
            this.ColorCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ColorEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 153);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "ColorEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رنگ ها";
            this.Load += new System.EventHandler(this.ColorEntityForm_Load);
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
        
private System.Windows.Forms.Label Color_nvcLabel;
private System.Windows.Forms.Label ColorCode_nvcLabel;
        
private System.Windows.Forms.TextBox Color_nvcTextBox;
private System.Windows.Forms.TextBox ColorCode_nvcTextBox;
        
       
        
       
        
        
    }
}
