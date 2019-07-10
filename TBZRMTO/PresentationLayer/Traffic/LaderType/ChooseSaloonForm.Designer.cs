namespace HPS.Present.LaderType
{
    partial class ChooseSaloonForm
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
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.SaloonID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(453, 14);
            this.SaveAndNextButton.Visible = false;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(453, 14);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(453, 54);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(453, 54);
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(283, 35);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(81, 23);
            this.LaderPivotGroupID_intLabel.TabIndex = 2;
            this.LaderPivotGroupID_intLabel.Text = "سالن بارگیری";
            // 
            // SaloonID_intComboBox
            // 
            this.SaloonID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaloonID_intComboBox.FormattingEnabled = true;
            this.SaloonID_intComboBox.Location = new System.Drawing.Point(10, 29);
            this.SaloonID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.SaloonID_intComboBox.Name = "SaloonID_intComboBox";
            this.SaloonID_intComboBox.Size = new System.Drawing.Size(259, 31);
            this.SaloonID_intComboBox.TabIndex = 8;
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.SaloonID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(14, 28);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(401, 82);
            this.DetailGropBox.TabIndex = 6;
            this.DetailGropBox.TabStop = false;
            // 
            // ChooseSaloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 177);
            this.Controls.Add(this.DetailGropBox);
            this.Name = "ChooseSaloonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب سالن بارگیری جاری";
            this.Load += new System.EventHandler(this.ChooseSaloonForm_Load);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
        private System.Windows.Forms.ComboBox SaloonID_intComboBox;
        private System.Windows.Forms.GroupBox DetailGropBox;

    }
}