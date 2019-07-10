namespace HPS.Present.Country
    {
    partial class CountryListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CountryGridView = new System.Windows.Forms.DataGridView();
            this.colCountryID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountryCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountry_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CountryToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.CountryGridView)).BeginInit();
            this.CountryToolStrip.SuspendLayout();
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
            // CountryGridView
            // 
            this.CountryGridView.AllowUserToAddRows = false;
            this.CountryGridView.AllowUserToDeleteRows = false;
            this.CountryGridView.AllowUserToResizeRows = false;
            this.CountryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CountryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CountryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCountryID_int,
            this.colCountryCode_nvc,
            this.colCountry_nvc,
            this.colActive_bit});
            this.CountryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CountryGridView.Location = new System.Drawing.Point(0, 31);
            this.CountryGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CountryGridView.MultiSelect = false;
            this.CountryGridView.Name = "CountryGridView";
            this.CountryGridView.ReadOnly = true;
            this.CountryGridView.RowHeadersVisible = false;
            this.CountryGridView.Size = new System.Drawing.Size(698, 401);
            this.CountryGridView.TabIndex = 0;
            // 
            // colCountryID_int
            // 
            this.colCountryID_int.DataPropertyName = "CountryID_int";
            this.colCountryID_int.HeaderText = "شناسه کشور";
            this.colCountryID_int.Name = "colCountryID_int";
            this.colCountryID_int.ReadOnly = true;
            this.colCountryID_int.Visible = false;
            // 
            // colCountryCode_nvc
            // 
            this.colCountryCode_nvc.DataPropertyName = "CountryCode_nvc";
            this.colCountryCode_nvc.HeaderText = "کد کشور";
            this.colCountryCode_nvc.Name = "colCountryCode_nvc";
            this.colCountryCode_nvc.ReadOnly = true;
            this.colCountryCode_nvc.Width = 228;
            // 
            // colCountry_nvc
            // 
            this.colCountry_nvc.DataPropertyName = "Country_nvc";
            this.colCountry_nvc.HeaderText = "نام کشور";
            this.colCountry_nvc.Name = "colCountry_nvc";
            this.colCountry_nvc.ReadOnly = true;
            this.colCountry_nvc.Width = 235;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 232;
            // 
            // CountryToolStrip
            // 
            this.CountryToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CountryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.CountryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CountryToolStrip.Name = "CountryToolStrip";
            this.CountryToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CountryToolStrip.Size = new System.Drawing.Size(698, 31);
            this.CountryToolStrip.TabIndex = 1;
            // 
            // CountryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(698, 432);
            this.Controls.Add(this.CountryGridView);
            this.Controls.Add(this.CountryToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CountryListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کشور";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CountryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountryGridView)).EndInit();
            this.CountryToolStrip.ResumeLayout(false);
            this.CountryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CountryToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView CountryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}