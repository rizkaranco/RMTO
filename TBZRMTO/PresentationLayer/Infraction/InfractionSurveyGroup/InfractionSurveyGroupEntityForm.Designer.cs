namespace HPS.Present.InfractionSurveyGroup
{
    partial class InfractionSurveyGroupEntityForm 

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
            this.InfractionSurveyGroup_nvcLabel = new System.Windows.Forms.Label();
            this.InfractionSurveyGroup_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(447, 11);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(447, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(447, 77);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(447, 110);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.InfractionSurveyGroup_nvcLabel);
            this.DetailGropBox.Controls.Add(this.InfractionSurveyGroup_nvcTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 14);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(415, 81);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // InfractionSurveyGroup_nvcLabel
            // 
            this.InfractionSurveyGroup_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionSurveyGroup_nvcLabel.AutoSize = true;
            this.InfractionSurveyGroup_nvcLabel.Location = new System.Drawing.Point(350, 33);
            this.InfractionSurveyGroup_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionSurveyGroup_nvcLabel.Name = "InfractionSurveyGroup_nvcLabel";
            this.InfractionSurveyGroup_nvcLabel.Size = new System.Drawing.Size(53, 23);
            this.InfractionSurveyGroup_nvcLabel.TabIndex = 0;
            this.InfractionSurveyGroup_nvcLabel.Text = "نام گروه";
            // 
            // InfractionSurveyGroup_nvcTextBox
            // 
            this.InfractionSurveyGroup_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionSurveyGroup_nvcTextBox.Location = new System.Drawing.Point(10, 28);
            this.InfractionSurveyGroup_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionSurveyGroup_nvcTextBox.MaxLength = 50;
            this.InfractionSurveyGroup_nvcTextBox.Name = "InfractionSurveyGroup_nvcTextBox";
            this.InfractionSurveyGroup_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfractionSurveyGroup_nvcTextBox.Size = new System.Drawing.Size(337, 30);
            this.InfractionSurveyGroup_nvcTextBox.TabIndex = 1;
            this.InfractionSurveyGroup_nvcTextBox.Tag = "نام گروه";
            this.InfractionSurveyGroup_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InfractionSurveyGroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 149);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "InfractionSurveyGroupEntityForm";
            this.Text = "گروه بررسی تخلف";
            this.Load += new System.EventHandler(this.InfractionSurveyGroupEntityForm_Load);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        
private System.Windows.Forms.Label InfractionSurveyGroup_nvcLabel;
        
private System.Windows.Forms.TextBox InfractionSurveyGroup_nvcTextBox;
        
       
        
       
        
        
    }
}
