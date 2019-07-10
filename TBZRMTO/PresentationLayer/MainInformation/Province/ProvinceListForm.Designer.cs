namespace HPS.Present.Province
    {
    partial class ProvinceListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvinceListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ProvinceGridView = new System.Windows.Forms.DataGridView();
            this.colProvince_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvinceCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvince_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProvinceToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ProvinceGridView)).BeginInit();
            this.ProvinceToolStrip.SuspendLayout();
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
            this.DeleteButton.Image = global::HPS.Properties.Resources.Delete;
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
            // ProvinceGridView
            // 
            this.ProvinceGridView.AllowUserToAddRows = false;
            this.ProvinceGridView.AllowUserToDeleteRows = false;
            this.ProvinceGridView.AllowUserToResizeRows = false;
            this.ProvinceGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ProvinceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvinceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProvince_int,
            this.colProvinceCode_nvc,
            this.colProvince_nvc,
            this.colActive_bit});
            this.ProvinceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProvinceGridView.Location = new System.Drawing.Point(0, 31);
            this.ProvinceGridView.Margin = new System.Windows.Forms.Padding(5);
            this.ProvinceGridView.MultiSelect = false;
            this.ProvinceGridView.Name = "ProvinceGridView";
            this.ProvinceGridView.ReadOnly = true;
            this.ProvinceGridView.RowHeadersVisible = false;
            this.ProvinceGridView.Size = new System.Drawing.Size(695, 383);
            this.ProvinceGridView.TabIndex = 0;
            // 
            // colProvince_int
            // 
            this.colProvince_int.DataPropertyName = "Province_int";
            this.colProvince_int.HeaderText = "شناسه استان";
            this.colProvince_int.Name = "colProvince_int";
            this.colProvince_int.ReadOnly = true;
            this.colProvince_int.Visible = false;
            // 
            // colProvinceCode_nvc
            // 
            this.colProvinceCode_nvc.DataPropertyName = "ProvinceCode_nvc";
            this.colProvinceCode_nvc.HeaderText = "کد استان";
            this.colProvinceCode_nvc.Name = "colProvinceCode_nvc";
            this.colProvinceCode_nvc.ReadOnly = true;
            this.colProvinceCode_nvc.Width = 230;
            // 
            // colProvince_nvc
            // 
            this.colProvince_nvc.DataPropertyName = "Province_nvc";
            this.colProvince_nvc.HeaderText = "نام استان";
            this.colProvince_nvc.Name = "colProvince_nvc";
            this.colProvince_nvc.ReadOnly = true;
            this.colProvince_nvc.Width = 250;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 215;
            // 
            // ProvinceToolStrip
            // 
            this.ProvinceToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProvinceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.ProvinceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ProvinceToolStrip.Name = "ProvinceToolStrip";
            this.ProvinceToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ProvinceToolStrip.Size = new System.Drawing.Size(695, 31);
            this.ProvinceToolStrip.TabIndex = 1;
            // 
            // ProvinceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(695, 414);
            this.Controls.Add(this.ProvinceGridView);
            this.Controls.Add(this.ProvinceToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "ProvinceListForm";
            this.Text = "لیست استان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProvinceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProvinceGridView)).EndInit();
            this.ProvinceToolStrip.ResumeLayout(false);
            this.ProvinceToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip ProvinceToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView ProvinceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvince_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvinceCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvince_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}