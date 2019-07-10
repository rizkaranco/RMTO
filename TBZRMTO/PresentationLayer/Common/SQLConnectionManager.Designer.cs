namespace HPS.Present.SQL
{
    partial class SQLConnectionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLConnectionManager));
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DataBaseNameTextBox = new System.Windows.Forms.TextBox();
            this.DatabeseNameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.AuthenticationMode = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.Defaultbutton = new System.Windows.Forms.Button();
            this.CompanyIPDefaultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(91, 349);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 30);
            this.CloseButton.TabIndex = 46;
            this.CloseButton.Tag = "لغو";
            this.CloseButton.Text = "لغو";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(17, 349);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(65, 30);
            this.SaveButton.TabIndex = 45;
            this.SaveButton.Tag = "تایید";
            this.SaveButton.Text = "تایید";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataBaseNameTextBox
            // 
            this.DataBaseNameTextBox.Location = new System.Drawing.Point(168, 297);
            this.DataBaseNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DataBaseNameTextBox.Name = "DataBaseNameTextBox";
            this.DataBaseNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataBaseNameTextBox.Size = new System.Drawing.Size(294, 30);
            this.DataBaseNameTextBox.TabIndex = 43;
            this.DataBaseNameTextBox.Tag = "نام پایگاه داده";
            // 
            // DatabeseNameLabel
            // 
            this.DatabeseNameLabel.AutoSize = true;
            this.DatabeseNameLabel.Location = new System.Drawing.Point(20, 303);
            this.DatabeseNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DatabeseNameLabel.Name = "DatabeseNameLabel";
            this.DatabeseNameLabel.Size = new System.Drawing.Size(81, 23);
            this.DatabeseNameLabel.TabIndex = 42;
            this.DatabeseNameLabel.Text = "نام پایگاه داده";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(168, 239);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordTextBox.Size = new System.Drawing.Size(294, 30);
            this.PasswordTextBox.TabIndex = 40;
            this.PasswordTextBox.Tag = "گذر واژه";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(36, 246);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 23);
            this.PasswordLabel.TabIndex = 39;
            this.PasswordLabel.Text = "گذر واژه";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(36, 210);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(64, 23);
            this.UserNameLabel.TabIndex = 37;
            this.UserNameLabel.Text = "نام کاربری";
            // 
            // AuthenticationMode
            // 
            this.AuthenticationMode.AutoSize = true;
            this.AuthenticationMode.Location = new System.Drawing.Point(20, 172);
            this.AuthenticationMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AuthenticationMode.Name = "AuthenticationMode";
            this.AuthenticationMode.Size = new System.Drawing.Size(163, 23);
            this.AuthenticationMode.TabIndex = 34;
            this.AuthenticationMode.Text = "نام کاربر و رمز عبور پایگاه داده";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatusLabel.Location = new System.Drawing.Point(98, 28);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(455, 62);
            this.StatusLabel.TabIndex = 29;
            this.StatusLabel.Text = "تنظیمات مربوط به ایجاد اتصال به پایگاه داده را مشخص نمایید.";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(4, 19);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(78, 80);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 47;
            this.LogoPictureBox.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label4.Location = new System.Drawing.Point(-6, 92);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(496, 23);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "______________________________________________________";
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(168, 123);
            this.ServerNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.PasswordChar = '*';
            this.ServerNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ServerNameTextBox.Size = new System.Drawing.Size(294, 30);
            this.ServerNameTextBox.TabIndex = 32;
            this.ServerNameTextBox.Tag = "نام و/یا IP سرور";
            this.ServerNameTextBox.UseSystemPasswordChar = true;
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Location = new System.Drawing.Point(7, 128);
            this.ServerNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(96, 23);
            this.ServerNameLabel.TabIndex = 31;
            this.ServerNameLabel.Text = "نام و/یا IP سرور";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label6.Location = new System.Drawing.Point(-6, 149);
            this.Label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(496, 23);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "______________________________________________________";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label7.Location = new System.Drawing.Point(-6, 265);
            this.Label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(496, 23);
            this.Label7.TabIndex = 41;
            this.Label7.Text = "______________________________________________________";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label9.Location = new System.Drawing.Point(-6, 321);
            this.Label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(496, 23);
            this.Label9.TabIndex = 44;
            this.Label9.Text = "______________________________________________________";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(168, 203);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '*';
            this.UserNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserNameTextBox.Size = new System.Drawing.Size(294, 30);
            this.UserNameTextBox.TabIndex = 40;
            this.UserNameTextBox.Tag = "شناسه کاربری";
            this.UserNameTextBox.UseSystemPasswordChar = true;
            // 
            // Defaultbutton
            // 
            this.Defaultbutton.Location = new System.Drawing.Point(350, 349);
            this.Defaultbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Defaultbutton.Name = "Defaultbutton";
            this.Defaultbutton.Size = new System.Drawing.Size(128, 30);
            this.Defaultbutton.TabIndex = 48;
            this.Defaultbutton.Text = "تنظيمات پيش فرض";
            this.Defaultbutton.UseVisualStyleBackColor = true;
            this.Defaultbutton.Click += new System.EventHandler(this.Defaultbutton_Click);
            // 
            // CompanyIPDefaultButton
            // 
            this.CompanyIPDefaultButton.Location = new System.Drawing.Point(165, 349);
            this.CompanyIPDefaultButton.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyIPDefaultButton.Name = "CompanyIPDefaultButton";
            this.CompanyIPDefaultButton.Size = new System.Drawing.Size(176, 30);
            this.CompanyIPDefaultButton.TabIndex = 48;
            this.CompanyIPDefaultButton.Text = "تنظيمات پيش فرض شرکت ها";
            this.CompanyIPDefaultButton.UseVisualStyleBackColor = true;
            this.CompanyIPDefaultButton.Click += new System.EventHandler(this.CompanyIPDefaultButton_Click);
            // 
            // SQLConnectionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this.CompanyIPDefaultButton);
            this.Controls.Add(this.Defaultbutton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataBaseNameTextBox);
            this.Controls.Add(this.DatabeseNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.AuthenticationMode);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ServerNameTextBox);
            this.Controls.Add(this.ServerNameLabel);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SQLConnectionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات اتصال به پایگاه داده";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLConnectionManager_FormClosing);
            this.Load += new System.EventHandler(this.SQLConnectionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.Button SaveButton;
        internal System.Windows.Forms.TextBox DataBaseNameTextBox;
        internal System.Windows.Forms.Label DatabeseNameLabel;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UserNameLabel;
        internal System.Windows.Forms.Label AuthenticationMode;
        internal System.Windows.Forms.Label StatusLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox ServerNameTextBox;
        internal System.Windows.Forms.Label ServerNameLabel;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button Defaultbutton;
        private System.Windows.Forms.Button CompanyIPDefaultButton;
    }
}