namespace HPS.Present.Common.Setting_T
{
    partial class SettingListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SettingToolStrip = new System.Windows.Forms.ToolStrip();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.publicTabPage = new System.Windows.Forms.TabPage();
            this.SettingDataGrid = new System.Windows.Forms.DataGridView();
            this.colSettingID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSetting_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormattedValue_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbTabPage = new System.Windows.Forms.TabPage();
            this.previouseSettingButton = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.dataBaseNameTextBox = new System.Windows.Forms.TextBox();
            this.DatabeseNameLabel = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.smsTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.receivesMessageTimeExpiredTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.smsNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.smsShowSettingButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.smsSaveButton = new System.Windows.Forms.Button();
            this.smsUserNameTextBox = new System.Windows.Forms.TextBox();
            this.smsPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CompanyServerIPTextBox = new System.Windows.Forms.TextBox();
            this.SettingToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.publicTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGrid)).BeginInit();
            this.dbTabPage.SuspendLayout();
            this.smsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingToolStrip
            // 
            this.SettingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SettingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditButton,
            this.RefreshButton});
            this.SettingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SettingToolStrip.Name = "SettingToolStrip";
            this.SettingToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.SettingToolStrip.Size = new System.Drawing.Size(814, 31);
            this.SettingToolStrip.TabIndex = 9;
            this.SettingToolStrip.Text = "ToolStrip2";
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = global::HPS.Properties.Resources.Edit;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(28, 28);
            this.EditButton.Text = "ویرایش تنظيمات انتخاب شده";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::HPS.Properties.Resources.Refresh;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.publicTabPage);
            this.tabControl1.Controls.Add(this.dbTabPage);
            this.tabControl1.Controls.Add(this.smsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 510);
            this.tabControl1.TabIndex = 10;
            // 
            // publicTabPage
            // 
            this.publicTabPage.Controls.Add(this.SettingDataGrid);
            this.publicTabPage.Location = new System.Drawing.Point(4, 32);
            this.publicTabPage.Name = "publicTabPage";
            this.publicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.publicTabPage.Size = new System.Drawing.Size(806, 474);
            this.publicTabPage.TabIndex = 0;
            this.publicTabPage.Text = "عمومی";
            this.publicTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingDataGrid
            // 
            this.SettingDataGrid.AllowUserToAddRows = false;
            this.SettingDataGrid.AllowUserToDeleteRows = false;
            this.SettingDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(236)))), ((int)(((byte)(253)))));
            this.SettingDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SettingDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.SettingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSettingID_int,
            this.colSetting_nvc,
            this.colFormattedValue_nvc,
            this.colDescription_nvc});
            this.SettingDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingDataGrid.Location = new System.Drawing.Point(3, 3);
            this.SettingDataGrid.Margin = new System.Windows.Forms.Padding(5);
            this.SettingDataGrid.MultiSelect = false;
            this.SettingDataGrid.Name = "SettingDataGrid";
            this.SettingDataGrid.ReadOnly = true;
            this.SettingDataGrid.RowHeadersVisible = false;
            this.SettingDataGrid.Size = new System.Drawing.Size(800, 468);
            this.SettingDataGrid.TabIndex = 13;
            // 
            // colSettingID_int
            // 
            this.colSettingID_int.DataPropertyName = "SettingID_int";
            this.colSettingID_int.HeaderText = "شناسه تنظيمات";
            this.colSettingID_int.Name = "colSettingID_int";
            this.colSettingID_int.ReadOnly = true;
            this.colSettingID_int.Visible = false;
            // 
            // colSetting_nvc
            // 
            this.colSetting_nvc.DataPropertyName = "Setting_nvc";
            this.colSetting_nvc.HeaderText = "عنوان تنظيمات";
            this.colSetting_nvc.Name = "colSetting_nvc";
            this.colSetting_nvc.ReadOnly = true;
            this.colSetting_nvc.Width = 397;
            // 
            // colFormattedValue_nvc
            // 
            this.colFormattedValue_nvc.DataPropertyName = "FormattedValue_nvc";
            this.colFormattedValue_nvc.HeaderText = "مقدار";
            this.colFormattedValue_nvc.Name = "colFormattedValue_nvc";
            this.colFormattedValue_nvc.ReadOnly = true;
            // 
            // colDescription_nvc
            // 
            this.colDescription_nvc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription_nvc.DataPropertyName = "Description_nvc";
            this.colDescription_nvc.HeaderText = "توضیح";
            this.colDescription_nvc.Name = "colDescription_nvc";
            this.colDescription_nvc.ReadOnly = true;
            // 
            // dbTabPage
            // 
            this.dbTabPage.Controls.Add(this.previouseSettingButton);
            this.dbTabPage.Controls.Add(this.Label9);
            this.dbTabPage.Controls.Add(this.dataBaseNameTextBox);
            this.dbTabPage.Controls.Add(this.DatabeseNameLabel);
            this.dbTabPage.Controls.Add(this.CompanyServerIPTextBox);
            this.dbTabPage.Controls.Add(this.label7);
            this.dbTabPage.Controls.Add(this.serverNameTextBox);
            this.dbTabPage.Controls.Add(this.ServerNameLabel);
            this.dbTabPage.Controls.Add(this.SaveButton);
            this.dbTabPage.Controls.Add(this.userNameTextBox);
            this.dbTabPage.Controls.Add(this.passwordTextBox);
            this.dbTabPage.Controls.Add(this.PasswordLabel);
            this.dbTabPage.Controls.Add(this.UserNameLabel);
            this.dbTabPage.Location = new System.Drawing.Point(4, 32);
            this.dbTabPage.Name = "dbTabPage";
            this.dbTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dbTabPage.Size = new System.Drawing.Size(806, 474);
            this.dbTabPage.TabIndex = 1;
            this.dbTabPage.Text = "پایگاه داده";
            this.dbTabPage.UseVisualStyleBackColor = true;
            // 
            // previouseSettingButton
            // 
            this.previouseSettingButton.Location = new System.Drawing.Point(124, 251);
            this.previouseSettingButton.Margin = new System.Windows.Forms.Padding(5);
            this.previouseSettingButton.Name = "previouseSettingButton";
            this.previouseSettingButton.Size = new System.Drawing.Size(83, 30);
            this.previouseSettingButton.TabIndex = 52;
            this.previouseSettingButton.Tag = "";
            this.previouseSettingButton.Text = "نمایش";
            this.previouseSettingButton.UseVisualStyleBackColor = true;
            this.previouseSettingButton.Click += new System.EventHandler(this.previouseSettingButton_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label9.Location = new System.Drawing.Point(4, 222);
            this.Label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(595, 23);
            this.Label9.TabIndex = 51;
            this.Label9.Text = "_________________________________________________________________";
            // 
            // dataBaseNameTextBox
            // 
            this.dataBaseNameTextBox.Location = new System.Drawing.Point(32, 168);
            this.dataBaseNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.dataBaseNameTextBox.Name = "dataBaseNameTextBox";
            this.dataBaseNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataBaseNameTextBox.Size = new System.Drawing.Size(449, 30);
            this.dataBaseNameTextBox.TabIndex = 50;
            this.dataBaseNameTextBox.Tag = "نام پایگاه داده";
            // 
            // DatabeseNameLabel
            // 
            this.DatabeseNameLabel.AutoSize = true;
            this.DatabeseNameLabel.Location = new System.Drawing.Point(484, 172);
            this.DatabeseNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DatabeseNameLabel.Name = "DatabeseNameLabel";
            this.DatabeseNameLabel.Size = new System.Drawing.Size(81, 23);
            this.DatabeseNameLabel.TabIndex = 49;
            this.DatabeseNameLabel.Text = "نام پایگاه داده";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(32, 20);
            this.serverNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverNameTextBox.Size = new System.Drawing.Size(449, 30);
            this.serverNameTextBox.TabIndex = 48;
            this.serverNameTextBox.Tag = "نام و/یا IP سرور";
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Location = new System.Drawing.Point(484, 24);
            this.ServerNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(96, 23);
            this.ServerNameLabel.TabIndex = 47;
            this.ServerNameLabel.Text = "نام و/یا IP سرور";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(31, 251);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 30);
            this.SaveButton.TabIndex = 46;
            this.SaveButton.Tag = "";
            this.SaveButton.Text = "ثبت";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(32, 94);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameTextBox.Size = new System.Drawing.Size(449, 30);
            this.userNameTextBox.TabIndex = 43;
            this.userNameTextBox.Tag = "شناسه کاربری";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(32, 131);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.Size = new System.Drawing.Size(449, 30);
            this.passwordTextBox.TabIndex = 44;
            this.passwordTextBox.Tag = "گذر واژه";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(484, 135);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 23);
            this.PasswordLabel.TabIndex = 42;
            this.PasswordLabel.Text = "گذر واژه";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(484, 98);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(64, 23);
            this.UserNameLabel.TabIndex = 41;
            this.UserNameLabel.Text = "نام کاربری";
            // 
            // smsTabPage
            // 
            this.smsTabPage.Controls.Add(this.label6);
            this.smsTabPage.Controls.Add(this.receivesMessageTimeExpiredTextBox);
            this.smsTabPage.Controls.Add(this.label5);
            this.smsTabPage.Controls.Add(this.smsNumberTextBox);
            this.smsTabPage.Controls.Add(this.label4);
            this.smsTabPage.Controls.Add(this.smsShowSettingButton);
            this.smsTabPage.Controls.Add(this.label3);
            this.smsTabPage.Controls.Add(this.smsSaveButton);
            this.smsTabPage.Controls.Add(this.smsUserNameTextBox);
            this.smsTabPage.Controls.Add(this.smsPasswordTextBox);
            this.smsTabPage.Controls.Add(this.label1);
            this.smsTabPage.Controls.Add(this.label2);
            this.smsTabPage.Location = new System.Drawing.Point(4, 32);
            this.smsTabPage.Name = "smsTabPage";
            this.smsTabPage.Size = new System.Drawing.Size(806, 474);
            this.smsTabPage.TabIndex = 2;
            this.smsTabPage.Text = "پیام کوتاه";
            this.smsTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "ساعت";
            // 
            // receivesMessageTimeExpiredTextBox
            // 
            this.receivesMessageTimeExpiredTextBox.Location = new System.Drawing.Point(73, 134);
            this.receivesMessageTimeExpiredTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.receivesMessageTimeExpiredTextBox.Name = "receivesMessageTimeExpiredTextBox";
            this.receivesMessageTimeExpiredTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.receivesMessageTimeExpiredTextBox.Size = new System.Drawing.Size(320, 30);
            this.receivesMessageTimeExpiredTextBox.TabIndex = 59;
            this.receivesMessageTimeExpiredTextBox.Tag = "گذر واژه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "زمان انقضای اس ام اس های دریافتی";
            // 
            // smsNumberTextBox
            // 
            this.smsNumberTextBox.Location = new System.Drawing.Point(32, 94);
            this.smsNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.smsNumberTextBox.Name = "smsNumberTextBox";
            this.smsNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smsNumberTextBox.Size = new System.Drawing.Size(361, 30);
            this.smsNumberTextBox.TabIndex = 57;
            this.smsNumberTextBox.Tag = "گذر واژه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "شماره پیام کوتاه";
            // 
            // smsShowSettingButton
            // 
            this.smsShowSettingButton.Location = new System.Drawing.Point(124, 251);
            this.smsShowSettingButton.Margin = new System.Windows.Forms.Padding(5);
            this.smsShowSettingButton.Name = "smsShowSettingButton";
            this.smsShowSettingButton.Size = new System.Drawing.Size(83, 30);
            this.smsShowSettingButton.TabIndex = 55;
            this.smsShowSettingButton.Tag = "";
            this.smsShowSettingButton.Text = "نمایش";
            this.smsShowSettingButton.UseVisualStyleBackColor = true;
            this.smsShowSettingButton.Click += new System.EventHandler(this.smsShowSettingButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(4, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(595, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "_________________________________________________________________";
            // 
            // smsSaveButton
            // 
            this.smsSaveButton.Location = new System.Drawing.Point(31, 251);
            this.smsSaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.smsSaveButton.Name = "smsSaveButton";
            this.smsSaveButton.Size = new System.Drawing.Size(83, 30);
            this.smsSaveButton.TabIndex = 53;
            this.smsSaveButton.Tag = "";
            this.smsSaveButton.Text = "ثبت";
            this.smsSaveButton.UseVisualStyleBackColor = true;
            this.smsSaveButton.Click += new System.EventHandler(this.smsSaveButton_Click);
            // 
            // smsUserNameTextBox
            // 
            this.smsUserNameTextBox.Location = new System.Drawing.Point(32, 20);
            this.smsUserNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.smsUserNameTextBox.Name = "smsUserNameTextBox";
            this.smsUserNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smsUserNameTextBox.Size = new System.Drawing.Size(361, 30);
            this.smsUserNameTextBox.TabIndex = 47;
            this.smsUserNameTextBox.Tag = "شناسه کاربری";
            // 
            // smsPasswordTextBox
            // 
            this.smsPasswordTextBox.Location = new System.Drawing.Point(32, 57);
            this.smsPasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.smsPasswordTextBox.Name = "smsPasswordTextBox";
            this.smsPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smsPasswordTextBox.Size = new System.Drawing.Size(361, 30);
            this.smsPasswordTextBox.TabIndex = 48;
            this.smsPasswordTextBox.Tag = "گذر واژه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "گذر واژه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "نام کاربری";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "IP سرور برای شرکت ها";
            // 
            // CompanyServerIPTextBox
            // 
            this.CompanyServerIPTextBox.Location = new System.Drawing.Point(32, 57);
            this.CompanyServerIPTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyServerIPTextBox.Name = "CompanyServerIPTextBox";
            this.CompanyServerIPTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyServerIPTextBox.Size = new System.Drawing.Size(449, 30);
            this.CompanyServerIPTextBox.TabIndex = 48;
            this.CompanyServerIPTextBox.Tag = "نام و/یا IP سرور";
            // 
            // SettingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SettingToolStrip);
            this.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SettingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.SettingListForm_Load);
            this.SettingToolStrip.ResumeLayout(false);
            this.SettingToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.publicTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingDataGrid)).EndInit();
            this.dbTabPage.ResumeLayout(false);
            this.dbTabPage.PerformLayout();
            this.smsTabPage.ResumeLayout(false);
            this.smsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip SettingToolStrip;
        internal System.Windows.Forms.ToolStripButton EditButton;
        internal System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage publicTabPage;
        internal System.Windows.Forms.DataGridView SettingDataGrid;
        private System.Windows.Forms.TabPage dbTabPage;
        internal System.Windows.Forms.TextBox userNameTextBox;
        internal System.Windows.Forms.TextBox passwordTextBox;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UserNameLabel;
        internal System.Windows.Forms.Button SaveButton;
        internal System.Windows.Forms.TextBox serverNameTextBox;
        internal System.Windows.Forms.Label ServerNameLabel;
        internal System.Windows.Forms.TextBox dataBaseNameTextBox;
        internal System.Windows.Forms.Label DatabeseNameLabel;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TabPage smsTabPage;
        internal System.Windows.Forms.Button previouseSettingButton;
        internal System.Windows.Forms.TextBox smsUserNameTextBox;
        internal System.Windows.Forms.TextBox smsPasswordTextBox;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button smsShowSettingButton;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button smsSaveButton;
        internal System.Windows.Forms.TextBox smsNumberTextBox;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox receivesMessageTimeExpiredTextBox;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSettingID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSetting_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormattedValue_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription_nvc;
        internal System.Windows.Forms.TextBox CompanyServerIPTextBox;
        internal System.Windows.Forms.Label label7;
    }
}