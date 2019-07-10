namespace HPS.Present.PortPlaces
{
    partial class PortPlacesEntityForm 

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
            this.PortPlaces_nvcLabel = new System.Windows.Forms.Label();
            this.PortPlaces_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(462, 12);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(462, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(462, 74);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(462, 108);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.PortPlaces_nvcLabel);
            this.DetailGropBox.Controls.Add(this.PortPlaces_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 8);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(436, 105);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // PortPlaces_nvcLabel
            // 
            this.PortPlaces_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortPlaces_nvcLabel.AutoSize = true;
            this.PortPlaces_nvcLabel.Location = new System.Drawing.Point(346, 29);
            this.PortPlaces_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PortPlaces_nvcLabel.Name = "PortPlaces_nvcLabel";
            this.PortPlaces_nvcLabel.Size = new System.Drawing.Size(80, 23);
            this.PortPlaces_nvcLabel.TabIndex = 0;
            this.PortPlaces_nvcLabel.Text = " محل بارگیری";
            // 
            // PortPlaces_nvcTextBox
            // 
            this.PortPlaces_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortPlaces_nvcTextBox.Location = new System.Drawing.Point(12, 24);
            this.PortPlaces_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PortPlaces_nvcTextBox.MaxLength = 100;
            this.PortPlaces_nvcTextBox.Name = "PortPlaces_nvcTextBox";
            this.PortPlaces_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PortPlaces_nvcTextBox.Size = new System.Drawing.Size(331, 30);
            this.PortPlaces_nvcTextBox.TabIndex = 1;
            this.PortPlaces_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Active_bitCheckBox.Location = new System.Drawing.Point(331, 62);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(55, 30);
            this.Active_bitCheckBox.TabIndex = 2;
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // PortPlacesEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 147);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "PortPlacesEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محل بارگیری";
            this.Load += new System.EventHandler(this.PortPlacesEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label PortPlaces_nvcLabel;
        
private System.Windows.Forms.TextBox PortPlaces_nvcTextBox;
        
       
        
       
        
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
    }
}
