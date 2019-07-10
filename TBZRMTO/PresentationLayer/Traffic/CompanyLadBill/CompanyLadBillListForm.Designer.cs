namespace HPS.Present.CompanyLadBill
    {
    partial class CompanyLadBillListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyLadBillListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CompanyLadBillGridView = new System.Windows.Forms.DataGridView();
            this.colCompanyLadBillID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartNumber_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndNumber_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignmentNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryUserCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyLadBillToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLadBillGridView)).BeginInit();
            this.CompanyLadBillToolStrip.SuspendLayout();
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
            // CompanyLadBillGridView
            // 
            this.CompanyLadBillGridView.AllowUserToAddRows = false;
            this.CompanyLadBillGridView.AllowUserToDeleteRows = false;
            this.CompanyLadBillGridView.AllowUserToResizeRows = false;
            this.CompanyLadBillGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CompanyLadBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyLadBillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyLadBillID_bint,
            this.colCompanyID_int,
            this.colCompanyCode_nvc,
            this.colDate_nvc,
            this.colSerial_nvc,
            this.colStartNumber_int,
            this.colEndNumber_int,
            this.colAssignmentNumber_nvc,
            this.colDeliveryUserCode_nvc});
            this.CompanyLadBillGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyLadBillGridView.Location = new System.Drawing.Point(0, 31);
            this.CompanyLadBillGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CompanyLadBillGridView.MultiSelect = false;
            this.CompanyLadBillGridView.Name = "CompanyLadBillGridView";
            this.CompanyLadBillGridView.ReadOnly = true;
            this.CompanyLadBillGridView.RowHeadersVisible = false;
            this.CompanyLadBillGridView.Size = new System.Drawing.Size(854, 415);
            this.CompanyLadBillGridView.TabIndex = 0;
            // 
            // colCompanyLadBillID_bint
            // 
            this.colCompanyLadBillID_bint.DataPropertyName = "CompanyLadBillID_bint";
            this.colCompanyLadBillID_bint.HeaderText = "شناسه بارنامه";
            this.colCompanyLadBillID_bint.Name = "colCompanyLadBillID_bint";
            this.colCompanyLadBillID_bint.ReadOnly = true;
            this.colCompanyLadBillID_bint.Visible = false;
            // 
            // colCompanyID_int
            // 
            this.colCompanyID_int.DataPropertyName = "CompanyID_intCompany_nvc";
            this.colCompanyID_int.HeaderText = "شرکت";
            this.colCompanyID_int.Name = "colCompanyID_int";
            this.colCompanyID_int.ReadOnly = true;
            // 
            // colCompanyCode_nvc
            // 
            this.colCompanyCode_nvc.DataPropertyName = "CompanyCode_nvc";
            this.colCompanyCode_nvc.HeaderText = "کد شرکت";
            this.colCompanyCode_nvc.Name = "colCompanyCode_nvc";
            this.colCompanyCode_nvc.ReadOnly = true;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ تحویل";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            // 
            // colSerial_nvc
            // 
            this.colSerial_nvc.DataPropertyName = "Serial_nvc";
            this.colSerial_nvc.HeaderText = "سریال";
            this.colSerial_nvc.Name = "colSerial_nvc";
            this.colSerial_nvc.ReadOnly = true;
            // 
            // colStartNumber_int
            // 
            this.colStartNumber_int.DataPropertyName = "StartNumber_int";
            this.colStartNumber_int.HeaderText = " از شماره ";
            this.colStartNumber_int.Name = "colStartNumber_int";
            this.colStartNumber_int.ReadOnly = true;
            // 
            // colEndNumber_int
            // 
            this.colEndNumber_int.DataPropertyName = "EndNumber_int";
            this.colEndNumber_int.HeaderText = "تا شماره";
            this.colEndNumber_int.Name = "colEndNumber_int";
            this.colEndNumber_int.ReadOnly = true;
            // 
            // colAssignmentNumber_nvc
            // 
            this.colAssignmentNumber_nvc.DataPropertyName = "AssignmentNumber_nvc";
            this.colAssignmentNumber_nvc.HeaderText = "شماره حواله";
            this.colAssignmentNumber_nvc.Name = "colAssignmentNumber_nvc";
            this.colAssignmentNumber_nvc.ReadOnly = true;
            // 
            // colDeliveryUserCode_nvc
            // 
            this.colDeliveryUserCode_nvc.DataPropertyName = "DeliveryUserCode_nvc";
            this.colDeliveryUserCode_nvc.HeaderText = "کد تحویل دهنده";
            this.colDeliveryUserCode_nvc.Name = "colDeliveryUserCode_nvc";
            this.colDeliveryUserCode_nvc.ReadOnly = true;
            this.colDeliveryUserCode_nvc.Width = 150;
            // 
            // CompanyLadBillToolStrip
            // 
            this.CompanyLadBillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CompanyLadBillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.CompanyLadBillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CompanyLadBillToolStrip.Name = "CompanyLadBillToolStrip";
            this.CompanyLadBillToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CompanyLadBillToolStrip.Size = new System.Drawing.Size(854, 31);
            this.CompanyLadBillToolStrip.TabIndex = 1;
            // 
            // CompanyLadBillListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(854, 446);
            this.Controls.Add(this.CompanyLadBillGridView);
            this.Controls.Add(this.CompanyLadBillToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CompanyLadBillListForm";
            this.Text = "لیت بارنامه های تحویلی به شرکت ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyLadBillListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLadBillGridView)).EndInit();
            this.CompanyLadBillToolStrip.ResumeLayout(false);
            this.CompanyLadBillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CompanyLadBillToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView CompanyLadBillGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyLadBillID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartNumber_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndNumber_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignmentNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryUserCode_nvc;
    }

}