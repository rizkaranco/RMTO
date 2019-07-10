namespace HPS.Present.UserGroup
{
    partial class UserGroupEntityForm 

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
            this.ReversePermissionsButton = new System.Windows.Forms.Button();
            this.ClearAllPermissionsButton = new System.Windows.Forms.Button();
            this.SelectAllPermissionsButton = new System.Windows.Forms.Button();
            this.PermisionTabControl = new System.Windows.Forms.TabControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Active_bitCheckBox = new System.Windows.Forms.CheckBox();
            this.UserGroup_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DetailGropBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(618, 21);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(618, 58);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(618, 95);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(618, 132);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.ReversePermissionsButton);
            this.DetailGropBox.Controls.Add(this.ClearAllPermissionsButton);
            this.DetailGropBox.Controls.Add(this.SelectAllPermissionsButton);
            this.DetailGropBox.Controls.Add(this.PermisionTabControl);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 11);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(575, 327);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // ReversePermissionsButton
            // 
            this.ReversePermissionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReversePermissionsButton.Location = new System.Drawing.Point(202, 27);
            this.ReversePermissionsButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReversePermissionsButton.Name = "ReversePermissionsButton";
            this.ReversePermissionsButton.Size = new System.Drawing.Size(116, 34);
            this.ReversePermissionsButton.TabIndex = 9;
            this.ReversePermissionsButton.Text = "انتخاب معکوس";
            this.ReversePermissionsButton.UseVisualStyleBackColor = true;
            this.ReversePermissionsButton.Click += new System.EventHandler(this.ReversePermissionsButton_Click);
            // 
            // ClearAllPermissionsButton
            // 
            this.ClearAllPermissionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllPermissionsButton.Location = new System.Drawing.Point(325, 27);
            this.ClearAllPermissionsButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClearAllPermissionsButton.Name = "ClearAllPermissionsButton";
            this.ClearAllPermissionsButton.Size = new System.Drawing.Size(116, 34);
            this.ClearAllPermissionsButton.TabIndex = 8;
            this.ClearAllPermissionsButton.Text = "حذف همه";
            this.ClearAllPermissionsButton.UseVisualStyleBackColor = true;
            this.ClearAllPermissionsButton.Click += new System.EventHandler(this.ClearAllPermissionsButton_Click);
            // 
            // SelectAllPermissionsButton
            // 
            this.SelectAllPermissionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllPermissionsButton.Location = new System.Drawing.Point(449, 27);
            this.SelectAllPermissionsButton.Margin = new System.Windows.Forms.Padding(5);
            this.SelectAllPermissionsButton.Name = "SelectAllPermissionsButton";
            this.SelectAllPermissionsButton.Size = new System.Drawing.Size(116, 34);
            this.SelectAllPermissionsButton.TabIndex = 7;
            this.SelectAllPermissionsButton.Text = "انتخاب همه";
            this.SelectAllPermissionsButton.UseVisualStyleBackColor = true;
            this.SelectAllPermissionsButton.Click += new System.EventHandler(this.SelectAllPermissionsButton_Click);
            // 
            // PermisionTabControl
            // 
            this.PermisionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PermisionTabControl.Location = new System.Drawing.Point(14, 71);
            this.PermisionTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.PermisionTabControl.Name = "PermisionTabControl";
            this.PermisionTabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PermisionTabControl.RightToLeftLayout = true;
            this.PermisionTabControl.SelectedIndex = 0;
            this.PermisionTabControl.Size = new System.Drawing.Size(551, 246);
            this.PermisionTabControl.TabIndex = 5;
            this.PermisionTabControl.Tag = "دستزسی ها";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 386);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Active_bitCheckBox);
            this.tabPage1.Controls.Add(this.UserGroup_nvcTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(590, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تعریف گروه کاربری";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Active_bitCheckBox
            // 
            this.Active_bitCheckBox.Location = new System.Drawing.Point(372, 80);
            this.Active_bitCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.Active_bitCheckBox.Name = "Active_bitCheckBox";
            this.Active_bitCheckBox.Size = new System.Drawing.Size(98, 30);
            this.Active_bitCheckBox.TabIndex = 10;
            this.Active_bitCheckBox.Tag = "فعال";
            this.Active_bitCheckBox.Text = "فعال";
            this.Active_bitCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserGroup_nvcTextBox
            // 
            this.UserGroup_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserGroup_nvcTextBox.Location = new System.Drawing.Point(10, 27);
            this.UserGroup_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroup_nvcTextBox.MaxLength = 45;
            this.UserGroup_nvcTextBox.Name = "UserGroup_nvcTextBox";
            this.UserGroup_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserGroup_nvcTextBox.Size = new System.Drawing.Size(460, 30);
            this.UserGroup_nvcTextBox.TabIndex = 9;
            this.UserGroup_nvcTextBox.Tag = "نام گروه";
            this.UserGroup_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام گروه";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DetailGropBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(590, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تعیین محدودیت ها";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UserGroupEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 420);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "UserGroupEntityForm";
            this.Text = "تعریف گروه کاربری";
            this.Load += new System.EventHandler(this.UserGroupEntityForm_Load);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
internal System.Windows.Forms.TabControl PermisionTabControl;
internal System.Windows.Forms.Button ReversePermissionsButton;
internal System.Windows.Forms.Button ClearAllPermissionsButton;
internal System.Windows.Forms.Button SelectAllPermissionsButton;
private System.Windows.Forms.TabControl tabControl1;
private System.Windows.Forms.TabPage tabPage1;
private System.Windows.Forms.TabPage tabPage2;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox UserGroup_nvcTextBox;
private System.Windows.Forms.CheckBox Active_bitCheckBox;
    }
}
