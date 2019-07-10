namespace HPS.Present.SearchForm
{
    partial class CompanySearch
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
            this.BoxingToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CompanyGridView = new System.Windows.Forms.DataGridView();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectorName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirectorMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxingToolStrip
            // 
            this.BoxingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BoxingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.BoxingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BoxingToolStrip.Name = "BoxingToolStrip";
            this.BoxingToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BoxingToolStrip.Size = new System.Drawing.Size(831, 31);
            this.BoxingToolStrip.TabIndex = 7;
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = global::HPS.Properties.Resources.Check;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 28);
            this.SearchButton.Text = "جديد";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClosetoolStripButton
            // 
            this.ClosetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClosetoolStripButton.Image = global::HPS.Properties.Resources.Close;
            this.ClosetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClosetoolStripButton.Name = "ClosetoolStripButton";
            this.ClosetoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ClosetoolStripButton.Text = "بستن";
            this.ClosetoolStripButton.Click += new System.EventHandler(this.ClosetoolStripButton_Click);
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
            this.colDirectorName_nvc,
            this.colDirectorMobile_nvc,
            this.colPhone_nvc,
            this.colFax_nvc,
            this.colEmail_nvc,
            this.colWebAddress_nvc,
            this.colActive_bit,
            this.colInfractionGroupID_int});
            this.CompanyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyGridView.Location = new System.Drawing.Point(0, 31);
            this.CompanyGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CompanyGridView.MultiSelect = false;
            this.CompanyGridView.Name = "CompanyGridView";
            this.CompanyGridView.ReadOnly = true;
            this.CompanyGridView.RowHeadersVisible = false;
            this.CompanyGridView.Size = new System.Drawing.Size(831, 407);
            this.CompanyGridView.TabIndex = 8;
            this.CompanyGridView.DoubleClick += new System.EventHandler(this.CompanyGridView_DoubleClick);
            this.CompanyGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyGridView_KeyDown);
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
            this.colCompanyCode_nvc.Width = 90;
            // 
            // colCompany_nvc
            // 
            this.colCompany_nvc.DataPropertyName = "Company_nvc";
            this.colCompany_nvc.HeaderText = "نام شرکت";
            this.colCompany_nvc.Name = "colCompany_nvc";
            this.colCompany_nvc.ReadOnly = true;
            this.colCompany_nvc.Width = 90;
            // 
            // colDirectorName_nvc
            // 
            this.colDirectorName_nvc.DataPropertyName = "DirectorName_nvc";
            this.colDirectorName_nvc.HeaderText = "نام مدیر عامل";
            this.colDirectorName_nvc.Name = "colDirectorName_nvc";
            this.colDirectorName_nvc.ReadOnly = true;
            this.colDirectorName_nvc.Width = 120;
            // 
            // colDirectorMobile_nvc
            // 
            this.colDirectorMobile_nvc.DataPropertyName = "DirectorMobile_nvc";
            this.colDirectorMobile_nvc.HeaderText = "موبایل مدیر عامل";
            this.colDirectorMobile_nvc.Name = "colDirectorMobile_nvc";
            this.colDirectorMobile_nvc.ReadOnly = true;
            this.colDirectorMobile_nvc.Width = 120;
            // 
            // colPhone_nvc
            // 
            this.colPhone_nvc.DataPropertyName = "Phone_nvc";
            this.colPhone_nvc.HeaderText = "تلفن";
            this.colPhone_nvc.Name = "colPhone_nvc";
            this.colPhone_nvc.ReadOnly = true;
            this.colPhone_nvc.Width = 85;
            // 
            // colFax_nvc
            // 
            this.colFax_nvc.DataPropertyName = "Fax_nvc";
            this.colFax_nvc.HeaderText = "فکس";
            this.colFax_nvc.Name = "colFax_nvc";
            this.colFax_nvc.ReadOnly = true;
            this.colFax_nvc.Width = 80;
            // 
            // colEmail_nvc
            // 
            this.colEmail_nvc.DataPropertyName = "Email_nvc";
            this.colEmail_nvc.HeaderText = "پست الکترونیکی";
            this.colEmail_nvc.Name = "colEmail_nvc";
            this.colEmail_nvc.ReadOnly = true;
            this.colEmail_nvc.Width = 120;
            // 
            // colWebAddress_nvc
            // 
            this.colWebAddress_nvc.DataPropertyName = "WebAddress_nvc";
            this.colWebAddress_nvc.HeaderText = "سایت";
            this.colWebAddress_nvc.Name = "colWebAddress_nvc";
            this.colWebAddress_nvc.ReadOnly = true;
            this.colWebAddress_nvc.Width = 95;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 80;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            this.colInfractionGroupID_int.Width = 120;
            // 
            // CompanySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 438);
            this.Controls.Add(this.CompanyGridView);
            this.Controls.Add(this.BoxingToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CompanySearch";
            this.Text = "جستجوی شرکت";
            this.Load += new System.EventHandler(this.CompanySearch_Load);
            this.BoxingToolStrip.ResumeLayout(false);
            this.BoxingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BoxingToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView CompanyGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectorName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectorMobile_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebAddress_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
    }
}