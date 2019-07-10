namespace HPS.Present.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Label1 = new System.Windows.Forms.Label();
            this.RememberMyPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.FiscalYearLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.UserName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.Password_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.HeaderPictureBox = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 240);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 23);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "F1: راهنما";
            // 
            // RememberMyPasswordCheckBox
            // 
            this.RememberMyPasswordCheckBox.AutoSize = true;
            this.RememberMyPasswordCheckBox.Location = new System.Drawing.Point(302, 193);
            this.RememberMyPasswordCheckBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RememberMyPasswordCheckBox.Name = "RememberMyPasswordCheckBox";
            this.RememberMyPasswordCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RememberMyPasswordCheckBox.Size = new System.Drawing.Size(162, 27);
            this.RememberMyPasswordCheckBox.TabIndex = 9;
            this.RememberMyPasswordCheckBox.Tag = "گذر واژه مرا به خاطر بسپار";
            this.RememberMyPasswordCheckBox.Text = "گذر واژه مرا به خاطر بسپار";
            this.RememberMyPasswordCheckBox.UseVisualStyleBackColor = true;
            this.RememberMyPasswordCheckBox.Visible = false;
            this.RememberMyPasswordCheckBox.CheckedChanged += new System.EventHandler(this.RememberMyPasswordCheckBox_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.YearComboBox);
            this.GroupBox1.Controls.Add(this.FiscalYearLabel);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.CaptionLabel);
            this.GroupBox1.Controls.Add(this.AcceptButton);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.RememberMyPasswordCheckBox);
            this.GroupBox1.Controls.Add(this.RememberMeCheckBox);
            this.GroupBox1.Controls.Add(this.UserPictureBox);
            this.GroupBox1.Controls.Add(this.CloseFormButton);
            this.GroupBox1.Controls.Add(this.UserName_nvcTextBox);
            this.GroupBox1.Controls.Add(this.PasswordLabel);
            this.GroupBox1.Controls.Add(this.UserNameLabel);
            this.GroupBox1.Controls.Add(this.Password_nvcTextBox);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Location = new System.Drawing.Point(5, 84);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox1.Size = new System.Drawing.Size(532, 276);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            // 
            // YearComboBox
            // 
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(125, 46);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(339, 31);
            this.YearComboBox.TabIndex = 26;
            this.YearComboBox.SelectionChangeCommitted += new System.EventHandler(this.YearComboBox_SelectionChangeCommitted);
            this.YearComboBox.SelectedValueChanged += new System.EventHandler(this.YearComboBox_SelectedValueChanged);
            // 
            // FiscalYearLabel
            // 
            this.FiscalYearLabel.AutoSize = true;
            this.FiscalYearLabel.Location = new System.Drawing.Point(472, 50);
            this.FiscalYearLabel.Name = "FiscalYearLabel";
            this.FiscalYearLabel.Size = new System.Drawing.Size(35, 23);
            this.FiscalYearLabel.TabIndex = 25;
            this.FiscalYearLabel.Text = "سال ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(2, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 3);
            this.label3.TabIndex = 24;
            this.label3.Text = "__________________________________________________________________";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 3);
            this.label2.TabIndex = 23;
            this.label2.Text = "__________________________________________________________________";
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Location = new System.Drawing.Point(245, 15);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(232, 23);
            this.CaptionLabel.TabIndex = 22;
            this.CaptionLabel.Text = "شرکت و سال مالی مورد نظر را انتخاب نمایید";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(430, 236);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(87, 29);
            this.AcceptButton.TabIndex = 11;
            this.AcceptButton.Tag = "ورود";
            this.AcceptButton.Text = "ورود";
            this.AcceptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.Location = new System.Drawing.Point(347, 164);
            this.RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RememberMeCheckBox.Size = new System.Drawing.Size(117, 27);
            this.RememberMeCheckBox.TabIndex = 8;
            this.RememberMeCheckBox.Tag = "مرا به خاطر بسپار";
            this.RememberMeCheckBox.Text = "مرا به خاطر بسپار";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            this.RememberMeCheckBox.CheckedChanged += new System.EventHandler(this.RememberMeCheckBox_CheckedChanged);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.Location = new System.Drawing.Point(16, 98);
            this.UserPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(85, 122);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 12;
            this.UserPictureBox.TabStop = false;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(336, 236);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(87, 29);
            this.CloseFormButton.TabIndex = 12;
            this.CloseFormButton.Tag = "انصراف";
            this.CloseFormButton.Text = "انصراف";
            this.CloseFormButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // UserName_nvcTextBox
            // 
            this.UserName_nvcTextBox.Location = new System.Drawing.Point(125, 100);
            this.UserName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserName_nvcTextBox.MaxLength = 100;
            this.UserName_nvcTextBox.Name = "UserName_nvcTextBox";
            this.UserName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserName_nvcTextBox.Size = new System.Drawing.Size(339, 30);
            this.UserName_nvcTextBox.TabIndex = 1;
            this.UserName_nvcTextBox.Tag = "نام کاربری";
            this.UserName_nvcTextBox.Leave += new System.EventHandler(this.UserName_nvcTextBox_Leave);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(474, 135);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PasswordLabel.Size = new System.Drawing.Size(52, 23);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "گذر واژه";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(474, 104);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserNameLabel.Size = new System.Drawing.Size(53, 23);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "نام کاربر";
            // 
            // Password_nvcTextBox
            // 
            this.Password_nvcTextBox.Location = new System.Drawing.Point(125, 132);
            this.Password_nvcTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Password_nvcTextBox.MaxLength = 100;
            this.Password_nvcTextBox.Name = "Password_nvcTextBox";
            this.Password_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Password_nvcTextBox.Size = new System.Drawing.Size(339, 30);
            this.Password_nvcTextBox.TabIndex = 3;
            this.Password_nvcTextBox.Tag = "گذر واژه";
            this.Password_nvcTextBox.UseSystemPasswordChar = true;
            // 
            // Label5
            // 
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label5.Location = new System.Drawing.Point(2, 227);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(528, 3);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "__________________________________________________________________";
            // 
            // HeaderPictureBox
            // 
            this.HeaderPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPictureBox.Image = global::HPS.Properties.Resources.RMTOLogo1;
            this.HeaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.HeaderPictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HeaderPictureBox.Name = "HeaderPictureBox";
            this.HeaderPictureBox.Size = new System.Drawing.Size(541, 82);
            this.HeaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeaderPictureBox.TabIndex = 21;
            this.HeaderPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 364);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.HeaderPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ورود به سیستم";
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.Login_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox RememberMyPasswordCheckBox;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox RememberMeCheckBox;
        internal System.Windows.Forms.PictureBox UserPictureBox;
        internal System.Windows.Forms.Button CloseFormButton;
        internal System.Windows.Forms.Button AcceptButton;
        internal System.Windows.Forms.TextBox UserName_nvcTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UserNameLabel;
        internal System.Windows.Forms.TextBox Password_nvcTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.PictureBox HeaderPictureBox;
        internal System.Windows.Forms.Label FiscalYearLabel;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
    }
}