namespace HPS.Present.MessageRecipient
{
    partial class MessageRecipientEntityForm 

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
            this.MessageID_bintLabel = new System.Windows.Forms.Label();
            this.UserGroupID_intLabel = new System.Windows.Forms.Label();
            this.MessageID_bintNewButton = new System.Windows.Forms.Button();
            this.UserGroupID_intNewButton = new System.Windows.Forms.Button();
            this.MessageID_bintComboBox = new System.Windows.Forms.ComboBox();
            this.UserGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(508, 10);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(508, 44);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(508, 77);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(508, 110);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.MessageID_bintLabel);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intLabel);
            this.DetailGropBox.Controls.Add(this.MessageID_bintNewButton);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intNewButton);
            this.DetailGropBox.Controls.Add(this.MessageID_bintComboBox);
            this.DetailGropBox.Controls.Add(this.UserGroupID_intComboBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DetailGropBox.Size = new System.Drawing.Size(482, 134);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // MessageID_bintLabel
            // 
            this.MessageID_bintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageID_bintLabel.AutoSize = true;
            this.MessageID_bintLabel.Location = new System.Drawing.Point(368, 33);
            this.MessageID_bintLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MessageID_bintLabel.Name = "MessageID_bintLabel";
            this.MessageID_bintLabel.Size = new System.Drawing.Size(30, 23);
            this.MessageID_bintLabel.TabIndex = 4;
            this.MessageID_bintLabel.Text = "پیام";
            // 
            // UserGroupID_intLabel
            // 
            this.UserGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroupID_intLabel.AutoSize = true;
            this.UserGroupID_intLabel.Location = new System.Drawing.Point(368, 79);
            this.UserGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserGroupID_intLabel.Name = "UserGroupID_intLabel";
            this.UserGroupID_intLabel.Size = new System.Drawing.Size(104, 23);
            this.UserGroupID_intLabel.TabIndex = 5;
            this.UserGroupID_intLabel.Text = "گروه دریافت کننده";
            // 
            // MessageID_bintNewButton
            // 
            this.MessageID_bintNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageID_bintNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.MessageID_bintNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MessageID_bintNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MessageID_bintNewButton.Location = new System.Drawing.Point(10, 27);
            this.MessageID_bintNewButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MessageID_bintNewButton.Name = "MessageID_bintNewButton";
            this.MessageID_bintNewButton.Size = new System.Drawing.Size(37, 31);
            this.MessageID_bintNewButton.TabIndex = 6;
            this.MessageID_bintNewButton.TabStop = false;
            this.MessageID_bintNewButton.UseVisualStyleBackColor = true;
            this.MessageID_bintNewButton.Click += new System.EventHandler(this.MessageID_bintNewButton_Click);
            // 
            // UserGroupID_intNewButton
            // 
            this.UserGroupID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroupID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.UserGroupID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UserGroupID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserGroupID_intNewButton.Location = new System.Drawing.Point(10, 73);
            this.UserGroupID_intNewButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserGroupID_intNewButton.Name = "UserGroupID_intNewButton";
            this.UserGroupID_intNewButton.Size = new System.Drawing.Size(37, 32);
            this.UserGroupID_intNewButton.TabIndex = 7;
            this.UserGroupID_intNewButton.TabStop = false;
            this.UserGroupID_intNewButton.UseVisualStyleBackColor = true;
            this.UserGroupID_intNewButton.Click += new System.EventHandler(this.UserGroupID_intNewButton_Click);
            // 
            // MessageID_bintComboBox
            // 
            this.MessageID_bintComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageID_bintComboBox.FormattingEnabled = true;
            this.MessageID_bintComboBox.Location = new System.Drawing.Point(57, 28);
            this.MessageID_bintComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MessageID_bintComboBox.Name = "MessageID_bintComboBox";
            this.MessageID_bintComboBox.Size = new System.Drawing.Size(300, 31);
            this.MessageID_bintComboBox.TabIndex = 12;
            // 
            // UserGroupID_intComboBox
            // 
            this.UserGroupID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroupID_intComboBox.FormattingEnabled = true;
            this.UserGroupID_intComboBox.Location = new System.Drawing.Point(57, 74);
            this.UserGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserGroupID_intComboBox.Name = "UserGroupID_intComboBox";
            this.UserGroupID_intComboBox.Size = new System.Drawing.Size(300, 31);
            this.UserGroupID_intComboBox.TabIndex = 13;
            // 
            // MessageRecipientEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 148);
            this.Controls.Add(this.DetailGropBox);
            this.Margin = new System.Windows.Forms.Padding(28, 28, 28, 28);
            this.Name = "MessageRecipientEntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گروه دریافت کننده پیام";
            this.Load += new System.EventHandler(this.MessageRecipientEntityForm_Load);
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
        
private System.Windows.Forms.Label MessageID_bintLabel;
private System.Windows.Forms.Label UserGroupID_intLabel;
       
private System.Windows.Forms.ComboBox MessageID_bintComboBox;
private System.Windows.Forms.ComboBox UserGroupID_intComboBox;
        
private System.Windows.Forms.Button MessageID_bintNewButton;
private System.Windows.Forms.Button UserGroupID_intNewButton;
       
        
        
    }
}
