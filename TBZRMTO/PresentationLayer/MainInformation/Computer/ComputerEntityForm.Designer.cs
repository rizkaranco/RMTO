namespace HPS.Present.Computer
{
    partial class ComputerEntityForm 

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
            this.GetMacButton = new System.Windows.Forms.Button();
            this.GetIPButton = new System.Windows.Forms.Button();
            this.Computer_nvcComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MacTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.Computer_nvcLabel = new System.Windows.Forms.Label();
            this.MessageLED_nvcLabel = new System.Windows.Forms.Label();
            this.UserGroupID_intLabel = new System.Windows.Forms.Label();
            this.MessageLED_nvcTextBox = new System.Windows.Forms.TextBox();
            this.UserGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(520, 13);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(520, 47);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(520, 80);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(520, 115);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.GetMacButton);
            this.DetailGropBox.Controls.Add(this.GetIPButton);
            this.DetailGropBox.Controls.Add(this.Computer_nvcComboBox);
            this.DetailGropBox.Controls.Add(this.label2);
            this.DetailGropBox.Controls.Add(this.MacTextBox);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.IPTextBox);
            this.DetailGropBox.Controls.Add(this.Computer_nvcLabel);
            this.DetailGropBox.Controls.Add(this.MessageLED_nvcLabel);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.MessageLED_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intComboBox);
            this.DetailGropBox.Controls.Add(this.Active_bitCheckBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(492, 276);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // GetMacButton
            // 
            this.GetMacButton.Location = new System.Drawing.Point(8, 220);
            this.GetMacButton.Name = "GetMacButton";
            this.GetMacButton.Size = new System.Drawing.Size(89, 30);
            this.GetMacButton.TabIndex = 12;
            this.GetMacButton.Text = "دریافت";
            this.GetMacButton.UseVisualStyleBackColor = true;
            this.GetMacButton.Click += new System.EventHandler(this.GetMacButton_Click);
            // 
            // GetIPButton
            // 
            this.GetIPButton.Location = new System.Drawing.Point(8, 180);
            this.GetIPButton.Name = "GetIPButton";
            this.GetIPButton.Size = new System.Drawing.Size(89, 30);
            this.GetIPButton.TabIndex = 11;
            this.GetIPButton.Text = "دریافت";
            this.GetIPButton.UseVisualStyleBackColor = true;
            this.GetIPButton.Click += new System.EventHandler(this.GetIPButton_Click);
            // 
            // Computer_nvcComboBox
            // 
            this.Computer_nvcComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Computer_nvcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Computer_nvcComboBox.FormattingEnabled = true;
            this.Computer_nvcComboBox.Location = new System.Drawing.Point(11, 27);
            this.Computer_nvcComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.Computer_nvcComboBox.Name = "Computer_nvcComboBox";
            this.Computer_nvcComboBox.Size = new System.Drawing.Size(359, 31);
            this.Computer_nvcComboBox.TabIndex = 10;
            this.Computer_nvcComboBox.Tag = "گروه رایانه";
            this.Computer_nvcComboBox.SelectionChangeCommitted += new System.EventHandler(this.Computer_nvcComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "آدرس مک";
            // 
            // MacTextBox
            // 
            this.MacTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MacTextBox.Location = new System.Drawing.Point(105, 220);
            this.MacTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MacTextBox.MaxLength = 50;
            this.MacTextBox.Name = "MacTextBox";
            this.MacTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MacTextBox.Size = new System.Drawing.Size(265, 30);
            this.MacTextBox.TabIndex = 9;
            this.MacTextBox.Tag = "";
            this.MacTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "آدرس آی پی";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Location = new System.Drawing.Point(105, 180);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.IPTextBox.MaxLength = 50;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IPTextBox.Size = new System.Drawing.Size(265, 30);
            this.IPTextBox.TabIndex = 7;
            this.IPTextBox.Tag = "";
            this.IPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Computer_nvcLabel
            // 
            this.Computer_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Computer_nvcLabel.AutoSize = true;
            this.Computer_nvcLabel.Location = new System.Drawing.Point(374, 30);
            this.Computer_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Computer_nvcLabel.Name = "Computer_nvcLabel";
            this.Computer_nvcLabel.Size = new System.Drawing.Size(53, 23);
            this.Computer_nvcLabel.TabIndex = 0;
            this.Computer_nvcLabel.Text = "نام کاربر";
            // 
            // MessageLED_nvcLabel
            // 
            this.MessageLED_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLED_nvcLabel.AutoSize = true;
            this.MessageLED_nvcLabel.Location = new System.Drawing.Point(374, 145);
            this.MessageLED_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MessageLED_nvcLabel.Name = "MessageLED_nvcLabel";
            this.MessageLED_nvcLabel.Size = new System.Drawing.Size(111, 23);
            this.MessageLED_nvcLabel.TabIndex = 3;
            this.MessageLED_nvcLabel.Text = "پیام نمایشگر LED";
            // 
            // UserGroupID_intLabel
            // 
            this.UserGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroupID_intLabel.AutoSize = true;
            this.UserGroupID_intLabel.Location = new System.Drawing.Point(374, 107);
            this.UserGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserGroupID_intLabel.Name = "UserGroupID_intLabel";
            this.UserGroupID_intLabel.Size = new System.Drawing.Size(64, 23);
            this.UserGroupID_intLabel.TabIndex = 4;
            this.UserGroupID_intLabel.Text = "گروه رایانه";
            // 
            // MessageLED_nvcTextBox
            // 
            this.MessageLED_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLED_nvcTextBox.Location = new System.Drawing.Point(11, 140);
            this.MessageLED_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MessageLED_nvcTextBox.MaxLength = 50;
            this.MessageLED_nvcTextBox.Name = "MessageLED_nvcTextBox";
            this.MessageLED_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageLED_nvcTextBox.Size = new System.Drawing.Size(359, 30);
            this.MessageLED_nvcTextBox.TabIndex = 5;
            this.MessageLED_nvcTextBox.Tag = "پیام نمایشگر";
            this.MessageLED_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserGroupID_intComboBox
            // 
            this.UserGroupID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroupID_intComboBox.Enabled = false;
            this.UserGroupID_intComboBox.FormattingEnabled = true;
            this.UserGroupID_intComboBox.Location = new System.Drawing.Point(11, 99);
            this.UserGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroupID_intComboBox.Name = "UserGroupID_intComboBox";
            this.UserGroupID_intComboBox.Size = new System.Drawing.Size(359, 31);
            this.UserGroupID_intComboBox.TabIndex = 3;
            this.UserGroupID_intComboBox.Tag = "گروه رایانه";
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Active_bitCheckBox.Location = new System.Drawing.Point(361, 59);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 2;
            this.Active_bitCheckBox.Tag = "فعال";
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputerEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 285);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "ComputerEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رایانه";
            this.Load += new System.EventHandler(this.ComputerEntityForm_Load);
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

        private System.Windows.Forms.Label Computer_nvcLabel;
        private System.Windows.Forms.Label MessageLED_nvcLabel;
private System.Windows.Forms.TextBox MessageLED_nvcTextBox;
        
private System.Windows.Forms.Label UserGroupID_intLabel;
       
private System.Windows.Forms.ComboBox UserGroupID_intComboBox;
       
        
        
private System.Windows.Forms.CheckBox Active_bitCheckBox;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox MacTextBox;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox IPTextBox;
private System.Windows.Forms.ComboBox Computer_nvcComboBox;
private System.Windows.Forms.Button GetMacButton;
private System.Windows.Forms.Button GetIPButton;
    }
}
