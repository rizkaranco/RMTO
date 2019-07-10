namespace HPS.Present.TrafficType
    {
    partial class TrafficTypeListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficTypeListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.TrafficTypeGridView = new System.Windows.Forms.DataGridView();
            this.colTrafficTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrafficTypeToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficTypeGridView)).BeginInit();
            this.TrafficTypeToolStrip.SuspendLayout();
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
            // TrafficTypeGridView
            // 
            this.TrafficTypeGridView.AllowUserToAddRows = false;
            this.TrafficTypeGridView.AllowUserToDeleteRows = false;
            this.TrafficTypeGridView.AllowUserToResizeRows = false;
            this.TrafficTypeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TrafficTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrafficTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrafficTypeID_int,
            this.colTrafficType_nvc});
            this.TrafficTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficTypeGridView.Location = new System.Drawing.Point(0, 31);
            this.TrafficTypeGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TrafficTypeGridView.MultiSelect = false;
            this.TrafficTypeGridView.Name = "TrafficTypeGridView";
            this.TrafficTypeGridView.ReadOnly = true;
            this.TrafficTypeGridView.RowHeadersVisible = false;
            this.TrafficTypeGridView.Size = new System.Drawing.Size(696, 369);
            this.TrafficTypeGridView.TabIndex = 0;
            // 
            // colTrafficTypeID_int
            // 
            this.colTrafficTypeID_int.DataPropertyName = "TrafficTypeID_int";
            this.colTrafficTypeID_int.HeaderText = "شناسه نوع تردد";
            this.colTrafficTypeID_int.Name = "colTrafficTypeID_int";
            this.colTrafficTypeID_int.ReadOnly = true;
            this.colTrafficTypeID_int.Visible = false;
            // 
            // colTrafficType_nvc
            // 
            this.colTrafficType_nvc.DataPropertyName = "TrafficType_nvc";
            this.colTrafficType_nvc.HeaderText = "نوع تردد";
            this.colTrafficType_nvc.Name = "colTrafficType_nvc";
            this.colTrafficType_nvc.ReadOnly = true;
            this.colTrafficType_nvc.Width = 697;
            // 
            // TrafficTypeToolStrip
            // 
            this.TrafficTypeToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrafficTypeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.TrafficTypeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TrafficTypeToolStrip.Name = "TrafficTypeToolStrip";
            this.TrafficTypeToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TrafficTypeToolStrip.Size = new System.Drawing.Size(696, 31);
            this.TrafficTypeToolStrip.TabIndex = 1;
            // 
            // TrafficTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(696, 400);
            this.Controls.Add(this.TrafficTypeGridView);
            this.Controls.Add(this.TrafficTypeToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "TrafficTypeListForm";
            this.Text = "لیست نوع تردد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrafficTypeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrafficTypeGridView)).EndInit();
            this.TrafficTypeToolStrip.ResumeLayout(false);
            this.TrafficTypeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip TrafficTypeToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView TrafficTypeGridView;
        
private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficTypeID_int;
private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficType_nvc;
    }

}