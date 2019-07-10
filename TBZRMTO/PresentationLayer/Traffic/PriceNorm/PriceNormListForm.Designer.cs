namespace HPS.Present.PriceNorm
    {
    partial class PriceNormListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceNormListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.PriceNormGridView = new System.Windows.Forms.DataGridView();
            this.colPriceNormID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoodID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOldPrice_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOriginCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceNormToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNormGridView)).BeginInit();
            this.PriceNormToolStrip.SuspendLayout();
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
            // PriceNormGridView
            // 
            this.PriceNormGridView.AllowUserToAddRows = false;
            this.PriceNormGridView.AllowUserToDeleteRows = false;
            this.PriceNormGridView.AllowUserToResizeRows = false;
            this.PriceNormGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.PriceNormGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceNormGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPriceNormID_int,
            this.colCityID_int,
            this.colLaderTypeID_int,
            this.colGoodID_int,
            this.colPrice_dec,
            this.colOldPrice_dec,
            this.colCreateDate_nvc,
            this.colUpdateDate_nvc,
            this.colOriginCityID_int});
            this.PriceNormGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceNormGridView.Location = new System.Drawing.Point(0, 31);
            this.PriceNormGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PriceNormGridView.MultiSelect = false;
            this.PriceNormGridView.Name = "PriceNormGridView";
            this.PriceNormGridView.ReadOnly = true;
            this.PriceNormGridView.RowHeadersVisible = false;
            this.PriceNormGridView.Size = new System.Drawing.Size(804, 445);
            this.PriceNormGridView.TabIndex = 0;
            this.PriceNormGridView.Tag = "لیست نرخ عرف";
            // 
            // colPriceNormID_int
            // 
            this.colPriceNormID_int.DataPropertyName = "PriceNormID_int";
            this.colPriceNormID_int.HeaderText = "شناسه هزینه";
            this.colPriceNormID_int.Name = "colPriceNormID_int";
            this.colPriceNormID_int.ReadOnly = true;
            this.colPriceNormID_int.Visible = false;
            // 
            // colCityID_int
            // 
            this.colCityID_int.DataPropertyName = "CityID_intCity_nvc";
            this.colCityID_int.HeaderText = "شهر مقصد";
            this.colCityID_int.Name = "colCityID_int";
            this.colCityID_int.ReadOnly = true;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderTypeID_int.HeaderText = " نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            // 
            // colGoodID_int
            // 
            this.colGoodID_int.DataPropertyName = "GoodID_intGood_nvc";
            this.colGoodID_int.HeaderText = "کالا";
            this.colGoodID_int.Name = "colGoodID_int";
            this.colGoodID_int.ReadOnly = true;
            // 
            // colPrice_dec
            // 
            this.colPrice_dec.DataPropertyName = "Price_dec";
            this.colPrice_dec.HeaderText = "نرخ";
            this.colPrice_dec.Name = "colPrice_dec";
            this.colPrice_dec.ReadOnly = true;
            // 
            // colOldPrice_dec
            // 
            this.colOldPrice_dec.DataPropertyName = "OldPrice_dec";
            this.colOldPrice_dec.HeaderText = "نرخ قبلی";
            this.colOldPrice_dec.Name = "colOldPrice_dec";
            this.colOldPrice_dec.ReadOnly = true;
            // 
            // colCreateDate_nvc
            // 
            this.colCreateDate_nvc.DataPropertyName = "CreateDate_nvc";
            this.colCreateDate_nvc.HeaderText = "تاریخ ایجاد";
            this.colCreateDate_nvc.Name = "colCreateDate_nvc";
            this.colCreateDate_nvc.ReadOnly = true;
            // 
            // colUpdateDate_nvc
            // 
            this.colUpdateDate_nvc.DataPropertyName = "UpdateDate_nvc";
            this.colUpdateDate_nvc.HeaderText = "تاریخ به روز رسانی";
            this.colUpdateDate_nvc.Name = "colUpdateDate_nvc";
            this.colUpdateDate_nvc.ReadOnly = true;
            this.colUpdateDate_nvc.Width = 150;
            // 
            // colOriginCityID_int
            // 
            this.colOriginCityID_int.DataPropertyName = "OriginCityID_intCity_nvc";
            this.colOriginCityID_int.HeaderText = "شهر مبدأ";
            this.colOriginCityID_int.Name = "colOriginCityID_int";
            this.colOriginCityID_int.ReadOnly = true;
            // 
            // PriceNormToolStrip
            // 
            this.PriceNormToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PriceNormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.RefreshButton,
            this.ExportButton});
            this.PriceNormToolStrip.Location = new System.Drawing.Point(0, 0);
            this.PriceNormToolStrip.Name = "PriceNormToolStrip";
            this.PriceNormToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.PriceNormToolStrip.Size = new System.Drawing.Size(804, 31);
            this.PriceNormToolStrip.TabIndex = 1;
            // 
            // PriceNormListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(804, 476);
            this.Controls.Add(this.PriceNormGridView);
            this.Controls.Add(this.PriceNormToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "PriceNormListForm";
            this.Text = "لیست نرخ عرف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PriceNormListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceNormGridView)).EndInit();
            this.PriceNormToolStrip.ResumeLayout(false);
            this.PriceNormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip PriceNormToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView PriceNormGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceNormID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOldPrice_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOriginCityID_int;
    }

}