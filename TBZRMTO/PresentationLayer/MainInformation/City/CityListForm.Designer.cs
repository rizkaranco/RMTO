namespace HPS.Present.City
    {
    partial class CityListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CityGridView = new System.Windows.Forms.DataGridView();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelTime_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CityToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.CityGridView)).BeginInit();
            this.CityToolStrip.SuspendLayout();
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
            this.EditButton.Size = new System.Drawing.Size(23, 22);
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
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
            // CityGridView
            // 
            this.CityGridView.AllowUserToAddRows = false;
            this.CityGridView.AllowUserToDeleteRows = false;
            this.CityGridView.AllowUserToResizeRows = false;
            this.CityGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCityID_int,
            this.colCityCode_nvc,
            this.colCity_nvc,
            this.colTravelTime_int,
            this.colActive_bit});
            this.CityGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityGridView.Location = new System.Drawing.Point(0, 31);
            this.CityGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CityGridView.MultiSelect = false;
            this.CityGridView.Name = "CityGridView";
            this.CityGridView.ReadOnly = true;
            this.CityGridView.RowHeadersVisible = false;
            this.CityGridView.Size = new System.Drawing.Size(706, 404);
            this.CityGridView.TabIndex = 0;
            // 
            // colCityID_int
            // 
            this.colCityID_int.DataPropertyName = "CityID_int";
            this.colCityID_int.HeaderText = "شناسه شهر";
            this.colCityID_int.Name = "colCityID_int";
            this.colCityID_int.ReadOnly = true;
            this.colCityID_int.Visible = false;
            // 
            // colCityCode_nvc
            // 
            this.colCityCode_nvc.DataPropertyName = "CityCode_nvc";
            this.colCityCode_nvc.HeaderText = "کد شهر";
            this.colCityCode_nvc.Name = "colCityCode_nvc";
            this.colCityCode_nvc.ReadOnly = true;
            this.colCityCode_nvc.Width = 174;
            // 
            // colCity_nvc
            // 
            this.colCity_nvc.DataPropertyName = "City_nvc";
            this.colCity_nvc.HeaderText = "نام شهر";
            this.colCity_nvc.Name = "colCity_nvc";
            this.colCity_nvc.ReadOnly = true;
            this.colCity_nvc.Width = 180;
            // 
            // colTravelTime_int
            // 
            this.colTravelTime_int.DataPropertyName = "TravelTime_int";
            this.colTravelTime_int.HeaderText = "مدت سفر";
            this.colTravelTime_int.Name = "colTravelTime_int";
            this.colTravelTime_int.ReadOnly = true;
            this.colTravelTime_int.Width = 174;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 174;
            // 
            // CityToolStrip
            // 
            this.CityToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CityToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.CityToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CityToolStrip.Name = "CityToolStrip";
            this.CityToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CityToolStrip.Size = new System.Drawing.Size(706, 31);
            this.CityToolStrip.TabIndex = 1;
            // 
            // CityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(706, 435);
            this.Controls.Add(this.CityGridView);
            this.Controls.Add(this.CityToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CityListForm";
            this.Text = "لیست شهرها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CityListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGridView)).EndInit();
            this.CityToolStrip.ResumeLayout(false);
            this.CityToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CityToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView CityGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelTime_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}