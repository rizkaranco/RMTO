namespace HPS.Present.Bill
{
    partial class BillEntityForm 

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
            this.BillType_nvcLabel = new System.Windows.Forms.Label();
            this.TrafficTypeID_intLabel = new System.Windows.Forms.Label();
            this.BillType_nvcTextBox = new System.Windows.Forms.TextBox();
            this.TrafficTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(448, 14);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(448, 46);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(448, 79);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(448, 112);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.BillType_nvcLabel);
            this.DetailGropBox.Controls.Add(this.TrafficTypeID_intLabel);
            this.DetailGropBox.Controls.Add(this.BillType_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.TrafficTypeID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(11, 9);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(423, 127);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // BillType_nvcLabel
            // 
            this.BillType_nvcLabel.AutoSize = true;
            this.BillType_nvcLabel.Location = new System.Drawing.Point(349, 77);
            this.BillType_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BillType_nvcLabel.Name = "BillType_nvcLabel";
            this.BillType_nvcLabel.Size = new System.Drawing.Size(56, 23);
            this.BillType_nvcLabel.TabIndex = 0;
            this.BillType_nvcLabel.Text = "نوع قبض";
            // 
            // TrafficTypeID_intLabel
            // 
            this.TrafficTypeID_intLabel.AutoSize = true;
            this.TrafficTypeID_intLabel.Location = new System.Drawing.Point(349, 36);
            this.TrafficTypeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TrafficTypeID_intLabel.Name = "TrafficTypeID_intLabel";
            this.TrafficTypeID_intLabel.Size = new System.Drawing.Size(64, 23);
            this.TrafficTypeID_intLabel.TabIndex = 1;
            this.TrafficTypeID_intLabel.Text = "گروه قبض";
            // 
            // BillType_nvcTextBox
            // 
            this.BillType_nvcTextBox.Location = new System.Drawing.Point(10, 70);
            this.BillType_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.BillType_nvcTextBox.MaxLength = 50;
            this.BillType_nvcTextBox.Name = "BillType_nvcTextBox";
            this.BillType_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BillType_nvcTextBox.Size = new System.Drawing.Size(338, 30);
            this.BillType_nvcTextBox.TabIndex = 3;
            this.BillType_nvcTextBox.Tag = "نوع قبض";
            this.BillType_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrafficTypeID_intComboBox
            // 
            this.TrafficTypeID_intComboBox.FormattingEnabled = true;
            this.TrafficTypeID_intComboBox.Location = new System.Drawing.Point(10, 29);
            this.TrafficTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficTypeID_intComboBox.Name = "TrafficTypeID_intComboBox";
            this.TrafficTypeID_intComboBox.Size = new System.Drawing.Size(338, 31);
            this.TrafficTypeID_intComboBox.TabIndex = 4;
            this.TrafficTypeID_intComboBox.Tag = "نوع تردد";
            // 
            // BillEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 150);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "BillEntityForm";
            this.Text = "قبض";
            this.Load += new System.EventHandler(this.BillEntityForm_Load);
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
        
private System.Windows.Forms.Label BillType_nvcLabel;
        
private System.Windows.Forms.TextBox BillType_nvcTextBox;
        
private System.Windows.Forms.Label TrafficTypeID_intLabel;

private System.Windows.Forms.ComboBox TrafficTypeID_intComboBox;
       
        
        
    }
}
