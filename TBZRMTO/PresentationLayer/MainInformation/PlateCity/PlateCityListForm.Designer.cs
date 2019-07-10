namespace HPS.Present.PlateCity
    {
    partial class PlateCityListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlateCityListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.PlateCityGridView = new System.Windows.Forms.DataGridView();
            this.colPlateCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PlateCityToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.PlateCityGridView)).BeginInit();
            this.PlateCityToolStrip.SuspendLayout();
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
            // PlateCityGridView
            // 
            this.PlateCityGridView.AllowUserToAddRows = false;
            this.PlateCityGridView.AllowUserToDeleteRows = false;
            this.PlateCityGridView.AllowUserToResizeRows = false;
            this.PlateCityGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.PlateCityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlateCityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlateCityID_int,
            this.colPlateCityCode_nvc,
            this.colPlateCity_nvc,
            this.colActive_bit});
            this.PlateCityGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlateCityGridView.Location = new System.Drawing.Point(0, 31);
            this.PlateCityGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityGridView.MultiSelect = false;
            this.PlateCityGridView.Name = "PlateCityGridView";
            this.PlateCityGridView.ReadOnly = true;
            this.PlateCityGridView.RowHeadersVisible = false;
            this.PlateCityGridView.Size = new System.Drawing.Size(700, 409);
            this.PlateCityGridView.TabIndex = 0;
            // 
            // colPlateCityID_int
            // 
            this.colPlateCityID_int.DataPropertyName = "PlateCityID_int";
            this.colPlateCityID_int.HeaderText = "شناسه محل شماره گذاری";
            this.colPlateCityID_int.Name = "colPlateCityID_int";
            this.colPlateCityID_int.ReadOnly = true;
            this.colPlateCityID_int.Visible = false;
            // 
            // colPlateCityCode_nvc
            // 
            this.colPlateCityCode_nvc.DataPropertyName = "PlateCityCode_nvc";
            this.colPlateCityCode_nvc.HeaderText = "کد شهر";
            this.colPlateCityCode_nvc.Name = "colPlateCityCode_nvc";
            this.colPlateCityCode_nvc.ReadOnly = true;
            this.colPlateCityCode_nvc.Width = 232;
            // 
            // colPlateCity_nvc
            // 
            this.colPlateCity_nvc.DataPropertyName = "PlateCity_nvc";
            this.colPlateCity_nvc.HeaderText = "نام شهر";
            this.colPlateCity_nvc.Name = "colPlateCity_nvc";
            this.colPlateCity_nvc.ReadOnly = true;
            this.colPlateCity_nvc.Width = 260;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 205;
            // 
            // PlateCityToolStrip
            // 
            this.PlateCityToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PlateCityToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.PlateCityToolStrip.Location = new System.Drawing.Point(0, 0);
            this.PlateCityToolStrip.Name = "PlateCityToolStrip";
            this.PlateCityToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.PlateCityToolStrip.Size = new System.Drawing.Size(700, 31);
            this.PlateCityToolStrip.TabIndex = 1;
            // 
            // PlateCityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.PlateCityGridView);
            this.Controls.Add(this.PlateCityToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "PlateCityListForm";
            this.Text = "لیست شهر شماره گذاری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlateCityListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlateCityGridView)).EndInit();
            this.PlateCityToolStrip.ResumeLayout(false);
            this.PlateCityToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip PlateCityToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView PlateCityGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCity_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}