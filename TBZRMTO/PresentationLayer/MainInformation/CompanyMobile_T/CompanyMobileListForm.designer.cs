namespace HPS.Present
    {
    partial class CompanyMobileListForm 

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
            this.NewCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.EditCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.ExportCompanyMobileButton = new System.Windows.Forms.ToolStripButton();
            this.CompanyMobileGridView = new System.Windows.Forms.DataGridView();
            this.colCompanyMobileID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyMobileToolStrip = new System.Windows.Forms.ToolStrip();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyMobileGridView)).BeginInit();
            this.CompanyMobileToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.RefreshCompanyMobileButton.Click += new System.EventHandler(this.RefreshCompanyMobileButton_Click);
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
            // CompanyMobileGridView
            // 
            this.CompanyMobileGridView.AllowUserToAddRows = false;
            this.CompanyMobileGridView.AllowUserToDeleteRows = false;
            this.CompanyMobileGridView.AllowUserToResizeRows = false;
            this.CompanyMobileGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CompanyMobileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyMobileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyMobileID_int,
            this.colcompany_nvc,
            this.colCompanyID_int,
            this.colMobileNumber_nvc});
            this.CompanyMobileGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyMobileGridView.Location = new System.Drawing.Point(0, 31);
            this.CompanyMobileGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CompanyMobileGridView.MultiSelect = false;
            this.CompanyMobileGridView.Name = "CompanyMobileGridView";
            this.CompanyMobileGridView.ReadOnly = true;
            this.CompanyMobileGridView.RowHeadersVisible = false;
            this.CompanyMobileGridView.Size = new System.Drawing.Size(384, 711);
            this.CompanyMobileGridView.TabIndex = 0;
            // 
            // colCompanyMobileID_int
            // 
            this.colCompanyMobileID_int.DataPropertyName = "CompanyMobileID_int";
            this.colCompanyMobileID_int.HeaderText = "شناسه موبایل شرکت";
            this.colCompanyMobileID_int.Name = "colCompanyMobileID_int";
            this.colCompanyMobileID_int.ReadOnly = true;
            this.colCompanyMobileID_int.Visible = false;
            // 
            // colcompany_nvc
            // 
            this.colcompany_nvc.DataPropertyName = "Company_nvc";
            this.colcompany_nvc.HeaderText = "شرکت";
            this.colcompany_nvc.Name = "colcompany_nvc";
            this.colcompany_nvc.ReadOnly = true;
            this.colcompany_nvc.Width = 200;
            // 
            // colCompanyID_int
            // 
            this.colCompanyID_int.DataPropertyName = "CompanyID_int";
            this.colCompanyID_int.HeaderText = "شناسه شرکت";
            this.colCompanyID_int.Name = "colCompanyID_int";
            this.colCompanyID_int.ReadOnly = true;
            this.colCompanyID_int.Visible = false;
            // 
            // colMobileNumber_nvc
            // 
            this.colMobileNumber_nvc.DataPropertyName = "MobileNumber_nvc";
            this.colMobileNumber_nvc.HeaderText = "شماره موبایل";
            this.colMobileNumber_nvc.Name = "colMobileNumber_nvc";
            this.colMobileNumber_nvc.ReadOnly = true;
            this.colMobileNumber_nvc.Width = 180;
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
            this.CompanyMobileToolStrip.Size = new System.Drawing.Size(384, 31);
            this.CompanyMobileToolStrip.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CompanyMobileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(384, 742);
            this.Controls.Add(this.CompanyMobileGridView);
            this.Controls.Add(this.CompanyMobileToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 17, 17, 17);
            this.Name = "CompanyMobileListForm";
            this.Text = " فهرست ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyMobileListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyMobileGridView)).EndInit();
            this.CompanyMobileToolStrip.ResumeLayout(false);
            this.CompanyMobileToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CompanyMobileToolStrip;
        private System.Windows.Forms.ToolStripButton NewCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton EditCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton DeleteCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton RefreshCompanyMobileButton;
        private System.Windows.Forms.ToolStripButton ExportCompanyMobileButton;
        private System.Windows.Forms.DataGridView CompanyMobileGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyMobileID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcompany_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobileNumber_nvc;
        private System.Windows.Forms.ToolStripButton CloseButton;
    }

}