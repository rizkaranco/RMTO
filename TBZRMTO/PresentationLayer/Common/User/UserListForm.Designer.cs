namespace HPS.Present.User
    {
    partial class UserListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpireDate_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPicture_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.UserToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.Tag = "جدید";
            this.NewButton.Text = "جديد";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(28, 28);
            this.EditButton.Tag = "تغییرات";
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(28, 28);
            this.ExportButton.Tag = "انتقال به اکسل";
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // UserGridView
            // 
            this.UserGridView.AllowUserToAddRows = false;
            this.UserGridView.AllowUserToDeleteRows = false;
            this.UserGridView.AllowUserToResizeRows = false;
            this.UserGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName_nvc,
            this.colFullName_nvc,
            this.colPassword_nvc,
            this.colStartDate_vc,
            this.colExpireDate_vc,
            this.colUserGroupID_int,
            this.colPicture_img,
            this.colActive_bit,
            this.colInfractionGroupID_int,
            this.colCreateDate_nvc,
            this.colCreateTime_nvc,
            this.colCompany_nvc});
            this.UserGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGridView.Location = new System.Drawing.Point(0, 31);
            this.UserGridView.Margin = new System.Windows.Forms.Padding(5);
            this.UserGridView.MultiSelect = false;
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.ReadOnly = true;
            this.UserGridView.RowHeadersVisible = false;
            this.UserGridView.Size = new System.Drawing.Size(779, 409);
            this.UserGridView.TabIndex = 0;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "شناسه کاربری";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 116;
            // 
            // colFullName_nvc
            // 
            this.colFullName_nvc.DataPropertyName = "FullName_nvc";
            this.colFullName_nvc.HeaderText = "نام و نام خانوادگی";
            this.colFullName_nvc.Name = "colFullName_nvc";
            this.colFullName_nvc.ReadOnly = true;
            this.colFullName_nvc.Visible = false;
            this.colFullName_nvc.Width = 64;
            // 
            // colPassword_nvc
            // 
            this.colPassword_nvc.DataPropertyName = "Password_nvc";
            this.colPassword_nvc.HeaderText = "کلمه عبور";
            this.colPassword_nvc.Name = "colPassword_nvc";
            this.colPassword_nvc.ReadOnly = true;
            this.colPassword_nvc.Visible = false;
            this.colPassword_nvc.Width = 63;
            // 
            // colStartDate_vc
            // 
            this.colStartDate_vc.DataPropertyName = "StartDate_vc";
            this.colStartDate_vc.HeaderText = "تاریخ شروع اعتبار";
            this.colStartDate_vc.Name = "colStartDate_vc";
            this.colStartDate_vc.ReadOnly = true;
            this.colStartDate_vc.Width = 125;
            // 
            // colExpireDate_vc
            // 
            this.colExpireDate_vc.DataPropertyName = "ExpireDate_vc";
            this.colExpireDate_vc.HeaderText = "تاریخ پایان اعتبار";
            this.colExpireDate_vc.Name = "colExpireDate_vc";
            this.colExpireDate_vc.ReadOnly = true;
            this.colExpireDate_vc.Width = 125;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه کاربری";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 117;
            // 
            // colPicture_img
            // 
            this.colPicture_img.DataPropertyName = "Picture_img";
            this.colPicture_img.HeaderText = "تصویر کاربر";
            this.colPicture_img.Name = "colPicture_img";
            this.colPicture_img.ReadOnly = true;
            this.colPicture_img.Visible = false;
            this.colPicture_img.Width = 64;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 116;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            this.colInfractionGroupID_int.Width = 116;
            // 
            // colCreateDate_nvc
            // 
            this.colCreateDate_nvc.DataPropertyName = "CreateDate_nvc";
            this.colCreateDate_nvc.HeaderText = "تاریخ ایجاد";
            this.colCreateDate_nvc.Name = "colCreateDate_nvc";
            this.colCreateDate_nvc.ReadOnly = true;
            // 
            // colCreateTime_nvc
            // 
            this.colCreateTime_nvc.DataPropertyName = "CreateTime_nvc";
            this.colCreateTime_nvc.HeaderText = "ساعت ایجاد";
            this.colCreateTime_nvc.Name = "colCreateTime_nvc";
            this.colCreateTime_nvc.ReadOnly = true;
            // 
            // colCompany_nvc
            // 
            this.colCompany_nvc.DataPropertyName = "CompanyID_intCompany_nvc";
            this.colCompany_nvc.HeaderText = "شرکت";
            this.colCompany_nvc.Name = "colCompany_nvc";
            this.colCompany_nvc.ReadOnly = true;
            // 
            // UserToolStrip
            // 
            this.UserToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.UserToolStrip.Location = new System.Drawing.Point(0, 0);
            this.UserToolStrip.Name = "UserToolStrip";
            this.UserToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.UserToolStrip.Size = new System.Drawing.Size(779, 31);
            this.UserToolStrip.TabIndex = 1;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(779, 440);
            this.Controls.Add(this.UserGridView);
            this.Controls.Add(this.UserToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "UserListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کاربر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.UserToolStrip.ResumeLayout(false);
            this.UserToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip UserToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate_vc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpireDate_vc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPicture_img;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany_nvc;
    }

}