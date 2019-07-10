namespace HPS.Present.LaderPivotGroup
{
    partial class LaderPivotGroupEntityForm 

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
            this.LaderPivotGroup_nvcLabel = new System.Windows.Forms.Label();
            this.LaderPivotGroup_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(448, 12);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(448, 46);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(448, 80);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(448, 114);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.LaderPivotGroup_nvcLabel);
            this.DetailGropBox.Controls.Add(this.LaderPivotGroup_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(424, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // LaderPivotGroup_nvcLabel
            // 
            this.LaderPivotGroup_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroup_nvcLabel.AutoSize = true;
            this.LaderPivotGroup_nvcLabel.Location = new System.Drawing.Point(318, 29);
            this.LaderPivotGroup_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroup_nvcLabel.Name = "LaderPivotGroup_nvcLabel";
            this.LaderPivotGroup_nvcLabel.Size = new System.Drawing.Size(93, 23);
            this.LaderPivotGroup_nvcLabel.TabIndex = 0;
            this.LaderPivotGroup_nvcLabel.Text = "گروه انواع بارگیر";
            // 
            // LaderPivotGroup_nvcTextBox
            // 
            this.LaderPivotGroup_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroup_nvcTextBox.Location = new System.Drawing.Point(11, 24);
            this.LaderPivotGroup_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LaderPivotGroup_nvcTextBox.MaxLength = 50;
            this.LaderPivotGroup_nvcTextBox.Name = "LaderPivotGroup_nvcTextBox";
            this.LaderPivotGroup_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderPivotGroup_nvcTextBox.Size = new System.Drawing.Size(296, 30);
            this.LaderPivotGroup_nvcTextBox.TabIndex = 1;
            this.LaderPivotGroup_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LaderPivotGroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 153);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "LaderPivotGroupEntityForm";
            this.Text = "گروه انواع بارگیر";
            this.Load += new System.EventHandler(this.LaderPivotGroupEntityForm_Load);
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
        
private System.Windows.Forms.Label LaderPivotGroup_nvcLabel;
        
private System.Windows.Forms.TextBox LaderPivotGroup_nvcTextBox;
        
       
        
       
        
        
    }
}
