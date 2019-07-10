namespace HPS.Present.PortPlaces
    {
    partial class PortPlacesListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortPlacesListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.PortPlacesGridView = new System.Windows.Forms.DataGridView();
            this.colPortPlacesID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortPlaces_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PortPlacesToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.PortPlacesGridView)).BeginInit();
            this.PortPlacesToolStrip.SuspendLayout();
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
            // PortPlacesGridView
            // 
            this.PortPlacesGridView.AllowUserToAddRows = false;
            this.PortPlacesGridView.AllowUserToDeleteRows = false;
            this.PortPlacesGridView.AllowUserToResizeRows = false;
            this.PortPlacesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.PortPlacesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PortPlacesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPortPlacesID_int,
            this.colPortPlaces_nvc,
            this.colActive_bit});
            this.PortPlacesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortPlacesGridView.Location = new System.Drawing.Point(0, 31);
            this.PortPlacesGridView.Margin = new System.Windows.Forms.Padding(5);
            this.PortPlacesGridView.MultiSelect = false;
            this.PortPlacesGridView.Name = "PortPlacesGridView";
            this.PortPlacesGridView.ReadOnly = true;
            this.PortPlacesGridView.RowHeadersVisible = false;
            this.PortPlacesGridView.Size = new System.Drawing.Size(699, 373);
            this.PortPlacesGridView.TabIndex = 0;
            // 
            // colPortPlacesID_int
            // 
            this.colPortPlacesID_int.DataPropertyName = "PortPlacesID_int";
            this.colPortPlacesID_int.HeaderText = "شناسه محل بارگیری";
            this.colPortPlacesID_int.Name = "colPortPlacesID_int";
            this.colPortPlacesID_int.ReadOnly = true;
            this.colPortPlacesID_int.Visible = false;
            // 
            // colPortPlaces_nvc
            // 
            this.colPortPlaces_nvc.DataPropertyName = "PortPlaces_nvc";
            this.colPortPlaces_nvc.HeaderText = " محل بارگیری";
            this.colPortPlaces_nvc.Name = "colPortPlaces_nvc";
            this.colPortPlaces_nvc.ReadOnly = true;
            this.colPortPlaces_nvc.Width = 349;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 348;
            // 
            // PortPlacesToolStrip
            // 
            this.PortPlacesToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PortPlacesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.PortPlacesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.PortPlacesToolStrip.Name = "PortPlacesToolStrip";
            this.PortPlacesToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.PortPlacesToolStrip.Size = new System.Drawing.Size(699, 31);
            this.PortPlacesToolStrip.TabIndex = 1;
            // 
            // PortPlacesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(699, 404);
            this.Controls.Add(this.PortPlacesGridView);
            this.Controls.Add(this.PortPlacesToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "PortPlacesListForm";
            this.Text = "لیست محل بارگیری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PortPlacesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PortPlacesGridView)).EndInit();
            this.PortPlacesToolStrip.ResumeLayout(false);
            this.PortPlacesToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip PortPlacesToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView PortPlacesGridView;
        
private System.Windows.Forms.DataGridViewTextBoxColumn colPortPlacesID_int;
private System.Windows.Forms.DataGridViewTextBoxColumn colPortPlaces_nvc;
private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}