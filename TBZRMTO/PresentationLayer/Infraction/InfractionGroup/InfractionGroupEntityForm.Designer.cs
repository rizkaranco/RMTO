namespace HPS.Present.InfractionGroup
{
    partial class InfractionGroupEntityForm 

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
            this.InfractionGroup_nvcLabel = new System.Windows.Forms.Label();
            this.InfractionGroup_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(448, 9);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(448, 42);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(448, 76);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(448, 111);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.InfractionGroup_nvcLabel);
            this.DetailGropBox.Controls.Add(this.InfractionGroup_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 3);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(429, 105);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // InfractionGroup_nvcLabel
            // 
            this.InfractionGroup_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroup_nvcLabel.AutoSize = true;
            this.InfractionGroup_nvcLabel.Location = new System.Drawing.Point(324, 28);
            this.InfractionGroup_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionGroup_nvcLabel.Name = "InfractionGroup_nvcLabel";
            this.InfractionGroup_nvcLabel.Size = new System.Drawing.Size(100, 23);
            this.InfractionGroup_nvcLabel.TabIndex = 0;
            this.InfractionGroup_nvcLabel.Tag = "عنوان گروه تخلف";
            this.InfractionGroup_nvcLabel.Text = "عنوان گروه تخلف";
            // 
            // InfractionGroup_nvcTextBox
            // 
            this.InfractionGroup_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroup_nvcTextBox.Location = new System.Drawing.Point(8, 25);
            this.InfractionGroup_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroup_nvcTextBox.MaxLength = 50;
            this.InfractionGroup_nvcTextBox.Name = "InfractionGroup_nvcTextBox";
            this.InfractionGroup_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfractionGroup_nvcTextBox.Size = new System.Drawing.Size(314, 30);
            this.InfractionGroup_nvcTextBox.TabIndex = 1;
            this.InfractionGroup_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Active_bitCheckBox.Location = new System.Drawing.Point(309, 65);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 2;
            this.Active_bitCheckBox.Tag = "فعال";
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // InfractionGroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 149);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "InfractionGroupEntityForm";
            this.Text = "گروه تخلف";
            this.Load += new System.EventHandler(this.InfractionGroupEntityForm_Load);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label InfractionGroup_nvcLabel;
        
private System.Windows.Forms.TextBox InfractionGroup_nvcTextBox;
        
       
        
       
        
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
    }
}
