namespace HPS.Present.CarSystem
    {
    partial class CarSystemListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSystemListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CarSystemGridView = new System.Windows.Forms.DataGridView();
            this.CarSystemToolStrip = new System.Windows.Forms.ToolStrip();
            this.colCarSystemID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CarSystemGridView)).BeginInit();
            this.CarSystemToolStrip.SuspendLayout();
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
            // CarSystemGridView
            // 
            this.CarSystemGridView.AllowUserToAddRows = false;
            this.CarSystemGridView.AllowUserToDeleteRows = false;
            this.CarSystemGridView.AllowUserToResizeRows = false;
            this.CarSystemGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CarSystemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarSystemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarSystemID_int,
            this.colCarSystem_nvc});
            this.CarSystemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarSystemGridView.Location = new System.Drawing.Point(0, 31);
            this.CarSystemGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CarSystemGridView.MultiSelect = false;
            this.CarSystemGridView.Name = "CarSystemGridView";
            this.CarSystemGridView.ReadOnly = true;
            this.CarSystemGridView.RowHeadersVisible = false;
            this.CarSystemGridView.Size = new System.Drawing.Size(690, 409);
            this.CarSystemGridView.TabIndex = 0;
            // 
            // CarSystemToolStrip
            // 
            this.CarSystemToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CarSystemToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.CarSystemToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CarSystemToolStrip.Name = "CarSystemToolStrip";
            this.CarSystemToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CarSystemToolStrip.Size = new System.Drawing.Size(690, 31);
            this.CarSystemToolStrip.TabIndex = 1;
            // 
            // colCarSystemID_int
            // 
            this.colCarSystemID_int.DataPropertyName = "CarSystemID_int";
            this.colCarSystemID_int.HeaderText = "شناسه سیستم";
            this.colCarSystemID_int.Name = "colCarSystemID_int";
            this.colCarSystemID_int.ReadOnly = true;
            this.colCarSystemID_int.Visible = false;
            // 
            // colCarSystem_nvc
            // 
            this.colCarSystem_nvc.DataPropertyName = "CarSystem_nvc";
            this.colCarSystem_nvc.HeaderText = "سیستم";
            this.colCarSystem_nvc.Name = "colCarSystem_nvc";
            this.colCarSystem_nvc.ReadOnly = true;
            this.colCarSystem_nvc.Width = 690;
            // 
            // CarSystemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(690, 440);
            this.Controls.Add(this.CarSystemGridView);
            this.Controls.Add(this.CarSystemToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CarSystemListForm";
            this.Text = "لیست سیستم سواری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarSystemListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarSystemGridView)).EndInit();
            this.CarSystemToolStrip.ResumeLayout(false);
            this.CarSystemToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CarSystemToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView CarSystemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarSystemID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarSystem_nvc;
    }

}