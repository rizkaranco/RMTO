namespace HPS.Present.Company
    {
    partial class CompanyListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CompanyGridView = new System.Windows.Forms.DataGridView();
            this.CompanyToolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CompanyMobileGridView = new System.Windows.Forms.DataGridView();
            this.colCompanyMobileID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CompanyMobileToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.EditCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.ExportCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectorName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectorMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).BeginInit();
            this.CompanyToolStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyMobileGridView)).BeginInit();
            this.CompanyMobileToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
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
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // CompanyGridView
            // 
            this.CompanyGridView.AllowUserToAddRows = false;
            this.CompanyGridView.AllowUserToDeleteRows = false;
            this.CompanyGridView.AllowUserToResizeRows = false;
            this.CompanyGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CompanyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyID_int,
            this.colCompanyCode_nvc,
            this.colCompany_nvc,
            this.colGroupName_nvc,
            this.colDirectorName_nvc,
            this.colDirectorMobile_nvc,
            this.colPhone_nvc,
            this.colFax_nvc,
            this.colEmail_nvc,
            this.colWebAddress_nvc,
            this.colActive_bit,
            this.colInfractionGroupID_int,
            this.colAddress_nvc,
            this.colCityID_int,
            this.colCityCode_nvc});
            this.CompanyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyGridView.Location = new System.Drawing.Point(0, 31);
            this.CompanyGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyGridView.MultiSelect = false;
            this.CompanyGridView.Name = "CompanyGridView";
            this.CompanyGridView.ReadOnly = true;
            this.CompanyGridView.RowHeadersVisible = false;
            this.CompanyGridView.Size = new System.Drawing.Size(610, 589);
            this.CompanyGridView.TabIndex = 0;
            // 
            // CompanyToolStrip
            // 
            this.CompanyToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CompanyToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.CompanyToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CompanyToolStrip.Name = "CompanyToolStrip";
            this.CompanyToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CompanyToolStrip.Size = new System.Drawing.Size(610, 31);
            this.CompanyToolStrip.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CompanyGridView);
            this.splitContainer1.Panel1.Controls.Add(this.CompanyToolStrip);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CompanyMobileGridView);
            this.splitContainer1.Panel2.Controls.Add(this.CompanyMobileToolStrip);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1000, 620);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // CompanyMobileGridView
            // 
            this.CompanyMobileGridView.AllowUserToAddRows = false;
            this.CompanyMobileGridView.AllowUserToDeleteRows = false;
            this.CompanyMobileGridView.AllowUserToResizeRows = false;
            this.CompanyMobileGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CompanyMobileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyMobileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyMobileID_int,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colMobileNumber_nvc,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colMobileActive_bit});
            this.CompanyMobileGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyMobileGridView.Location = new System.Drawing.Point(0, 31);
            this.CompanyMobileGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyMobileGridView.MultiSelect = false;
            this.CompanyMobileGridView.Name = "CompanyMobileGridView";
            this.CompanyMobileGridView.ReadOnly = true;
            this.CompanyMobileGridView.RowHeadersVisible = false;
            this.CompanyMobileGridView.Size = new System.Drawing.Size(389, 589);
            this.CompanyMobileGridView.TabIndex = 3;
            // 
            // colCompanyMobileID_int
            // 
            this.colCompanyMobileID_int.DataPropertyName = "CompanyMobileID_int";
            this.colCompanyMobileID_int.HeaderText = "شناسه موبایل شرکت";
            this.colCompanyMobileID_int.Name = "colCompanyMobileID_int";
            this.colCompanyMobileID_int.ReadOnly = true;
            this.colCompanyMobileID_int.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Company_nvc";
            this.dataGridViewTextBoxColumn1.HeaderText = "شرکت";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyID_int";
            this.dataGridViewTextBoxColumn2.HeaderText = "شناسه شرکت";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // colMobileNumber_nvc
            // 
            this.colMobileNumber_nvc.DataPropertyName = "MobileNumber_nvc";
            this.colMobileNumber_nvc.HeaderText = "شماره موبایل";
            this.colMobileNumber_nvc.Name = "colMobileNumber_nvc";
            this.colMobileNumber_nvc.ReadOnly = true;
            this.colMobileNumber_nvc.Width = 140;
            // 
            // colFirstName_nvc
            // 
            this.colFirstName_nvc.DataPropertyName = "FirstName_nvc";
            this.colFirstName_nvc.HeaderText = "نام";
            this.colFirstName_nvc.Name = "colFirstName_nvc";
            this.colFirstName_nvc.ReadOnly = true;
            this.colFirstName_nvc.Width = 90;
            // 
            // colLastName_nvc
            // 
            this.colLastName_nvc.DataPropertyName = "LastName_nvc";
            this.colLastName_nvc.HeaderText = "نام خانوادگی";
            this.colLastName_nvc.Name = "colLastName_nvc";
            this.colLastName_nvc.ReadOnly = true;
            this.colLastName_nvc.Width = 120;
            // 
            // colMobileActive_bit
            // 
            this.colMobileActive_bit.DataPropertyName = "Active_bit";
            this.colMobileActive_bit.HeaderText = "فعال";
            this.colMobileActive_bit.Name = "colMobileActive_bit";
            this.colMobileActive_bit.ReadOnly = true;
            this.colMobileActive_bit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMobileActive_bit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMobileActive_bit.Width = 50;
            // 
            // CompanyMobileToolStrip
            // 
            this.CompanyMobileToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CompanyMobileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCompanyMobileButton,
            this.EditCompanyMobileButton,
            this.DeleteCompanyMobileButton,
            this.RefreshCompanyMobileButton,
            this.ExportCompanyMobileButton,
            this.CloseButton});
            this.CompanyMobileToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CompanyMobileToolStrip.Name = "CompanyMobileToolStrip";
            this.CompanyMobileToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CompanyMobileToolStrip.Size = new System.Drawing.Size(389, 31);
            this.CompanyMobileToolStrip.TabIndex = 2;
            // 
            // NewCompanyMobileButton
            // 
            this.NewCompanyMobileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewCompanyMobileButton.Image = global::HPS.Properties.Resources.Add;
            this.NewCompanyMobileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewCompanyMobileButton.Name = "NewCompanyMobileButton";
            this.NewCompanyMobileButton.Size = new System.Drawing.Size(28, 28);
            this.NewCompanyMobileButton.Text = "جديد";
            this.NewCompanyMobileButton.Click += new System.EventHandler(this.NewCompanyMobileButton_Click);
            // 
            // EditCompanyMobileButton
            // 
            this.EditCompanyMobileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditCompanyMobileButton.Image = global::HPS.Properties.Resources.Edit;
            this.EditCompanyMobileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCompanyMobileButton.Name = "EditCompanyMobileButton";
            this.EditCompanyMobileButton.Size = new System.Drawing.Size(28, 28);
            this.EditCompanyMobileButton.Text = "ويرايش";
            this.EditCompanyMobileButton.Click += new System.EventHandler(this.EditCompanyMobileButton_Click);
            // 
            // DeleteCompanyMobileButton
            // 
            this.DeleteCompanyMobileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCompanyMobileButton.Image = global::HPS.Properties.Resources.Delete;
            this.DeleteCompanyMobileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCompanyMobileButton.Name = "DeleteCompanyMobileButton";
            this.DeleteCompanyMobileButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteCompanyMobileButton.Text = "حذف";
            this.DeleteCompanyMobileButton.Click += new System.EventHandler(this.DeleteCompanyMobileButton_Click);
            // 
            // RefreshCompanyMobileButton
            // 
            this.RefreshCompanyMobileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshCompanyMobileButton.Image = global::HPS.Properties.Resources.Refresh;
            this.RefreshCompanyMobileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshCompanyMobileButton.Name = "RefreshCompanyMobileButton";
            this.RefreshCompanyMobileButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshCompanyMobileButton.Text = "بازیابی مجدد اطلاعات";
            // 
            // ExportCompanyMobileButton
            // 
            this.ExportCompanyMobileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportCompanyMobileButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportCompanyMobileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportCompanyMobileButton.Name = "ExportCompanyMobileButton";
            this.ExportCompanyMobileButton.Size = new System.Drawing.Size(28, 28);
            this.ExportCompanyMobileButton.Text = "انتقال به اکسل";
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            this.CloseButton.Visible = false;
            // 
            // colCompanyID_int
            // 
            this.colCompanyID_int.DataPropertyName = "CompanyID_int";
            this.colCompanyID_int.HeaderText = "شناسه شرکت/موسسه";
            this.colCompanyID_int.Name = "colCompanyID_int";
            this.colCompanyID_int.ReadOnly = true;
            this.colCompanyID_int.Visible = false;
            // 
            // colCompanyCode_nvc
            // 
            this.colCompanyCode_nvc.DataPropertyName = "CompanyCode_nvc";
            this.colCompanyCode_nvc.HeaderText = "کد شرکت";
            this.colCompanyCode_nvc.Name = "colCompanyCode_nvc";
            this.colCompanyCode_nvc.ReadOnly = true;
            // 
            // colCompany_nvc
            // 
            this.colCompany_nvc.DataPropertyName = "Company_nvc";
            this.colCompany_nvc.HeaderText = "نام شرکت";
            this.colCompany_nvc.Name = "colCompany_nvc";
            this.colCompany_nvc.ReadOnly = true;
            // 
            // colGroupName_nvc
            // 
            this.colGroupName_nvc.DataPropertyName = "GroupName_nvc";
            this.colGroupName_nvc.HeaderText = "گروه شرکت";
            this.colGroupName_nvc.Name = "colGroupName_nvc";
            this.colGroupName_nvc.ReadOnly = true;
            // 
            // colDirectorName_nvc
            // 
            this.colDirectorName_nvc.DataPropertyName = "DirectorName_nvc";
            this.colDirectorName_nvc.HeaderText = "نام مدیر عامل";
            this.colDirectorName_nvc.Name = "colDirectorName_nvc";
            this.colDirectorName_nvc.ReadOnly = true;
            this.colDirectorName_nvc.Width = 150;
            // 
            // colDirectorMobile_nvc
            // 
            this.colDirectorMobile_nvc.DataPropertyName = "DirectorMobile_nvc";
            this.colDirectorMobile_nvc.HeaderText = "موبایل مدیر عامل";
            this.colDirectorMobile_nvc.Name = "colDirectorMobile_nvc";
            this.colDirectorMobile_nvc.ReadOnly = true;
            this.colDirectorMobile_nvc.Width = 150;
            // 
            // colPhone_nvc
            // 
            this.colPhone_nvc.DataPropertyName = "Phone_nvc";
            this.colPhone_nvc.HeaderText = "تلفن";
            this.colPhone_nvc.Name = "colPhone_nvc";
            this.colPhone_nvc.ReadOnly = true;
            // 
            // colFax_nvc
            // 
            this.colFax_nvc.DataPropertyName = "Fax_nvc";
            this.colFax_nvc.HeaderText = "فکس";
            this.colFax_nvc.Name = "colFax_nvc";
            this.colFax_nvc.ReadOnly = true;
            // 
            // colEmail_nvc
            // 
            this.colEmail_nvc.DataPropertyName = "Email_nvc";
            this.colEmail_nvc.HeaderText = "پست الکترونیکی";
            this.colEmail_nvc.Name = "colEmail_nvc";
            this.colEmail_nvc.ReadOnly = true;
            this.colEmail_nvc.Width = 140;
            // 
            // colWebAddress_nvc
            // 
            this.colWebAddress_nvc.DataPropertyName = "WebAddress_nvc";
            this.colWebAddress_nvc.HeaderText = "سایت";
            this.colWebAddress_nvc.Name = "colWebAddress_nvc";
            this.colWebAddress_nvc.ReadOnly = true;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            // 
            // colAddress_nvc
            // 
            this.colAddress_nvc.DataPropertyName = "Address_nvc";
            this.colAddress_nvc.HeaderText = "آدرس";
            this.colAddress_nvc.Name = "colAddress_nvc";
            this.colAddress_nvc.ReadOnly = true;
            // 
            // colCityID_int
            // 
            this.colCityID_int.DataPropertyName = "CityID_intCity_nvc";
            this.colCityID_int.HeaderText = "شهر";
            this.colCityID_int.Name = "colCityID_int";
            this.colCityID_int.ReadOnly = true;
            // 
            // colCityCode_nvc
            // 
            this.colCityCode_nvc.DataPropertyName = "CityCode_nvc";
            this.colCityCode_nvc.HeaderText = "کد شهر";
            this.colCityCode_nvc.Name = "colCityCode_nvc";
            this.colCityCode_nvc.ReadOnly = true;
            // 
            // CompanyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(17);
            this.Name = "CompanyListForm";
            this.Text = "لیست شرکت/مؤسسه حمل ونقل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).EndInit();
            this.CompanyToolStrip.ResumeLayout(false);
            this.CompanyToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyMobileGridView)).EndInit();
            this.CompanyMobileToolStrip.ResumeLayout(false);
            this.CompanyMobileToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ToolStrip CompanyToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView CompanyGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip CompanyMobileToolStrip;
        private System.Windows.Forms.ToolStripButton NewCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton EditCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton DeleteCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton RefreshCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton ExportCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.DataGridView CompanyMobileGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyMobileID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobileNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMobileActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectorName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectorMobile_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebAddress_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityCode_nvc;
    }

}