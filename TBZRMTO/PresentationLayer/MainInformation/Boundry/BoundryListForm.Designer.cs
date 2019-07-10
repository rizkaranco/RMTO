namespace HPS.Present.Boundry
    {
    partial class BoundryListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoundryListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.BoundryGridView = new System.Windows.Forms.DataGridView();
            this.colBoundryID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoundryCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoundry_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoundryToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.BoundryGridView)).BeginInit();
            this.BoundryToolStrip.SuspendLayout();
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
            // BoundryGridView
            // 
            this.BoundryGridView.AllowUserToAddRows = false;
            this.BoundryGridView.AllowUserToDeleteRows = false;
            this.BoundryGridView.AllowUserToResizeRows = false;
            this.BoundryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.BoundryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoundryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBoundryID_int,
            this.colBoundryCode_nvc,
            this.colBoundry_nvc});
            this.BoundryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoundryGridView.Location = new System.Drawing.Point(0, 31);
            this.BoundryGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BoundryGridView.MultiSelect = false;
            this.BoundryGridView.Name = "BoundryGridView";
            this.BoundryGridView.ReadOnly = true;
            this.BoundryGridView.RowHeadersVisible = false;
            this.BoundryGridView.Size = new System.Drawing.Size(700, 409);
            this.BoundryGridView.TabIndex = 0;
            // 
            // colBoundryID_int
            // 
            this.colBoundryID_int.DataPropertyName = "BoundryID_int";
            this.colBoundryID_int.HeaderText = "شناسه مرز";
            this.colBoundryID_int.Name = "colBoundryID_int";
            this.colBoundryID_int.ReadOnly = true;
            this.colBoundryID_int.Visible = false;
            // 
            // colBoundryCode_nvc
            // 
            this.colBoundryCode_nvc.DataPropertyName = "BoundryCode_nvc";
            this.colBoundryCode_nvc.HeaderText = "کد مرز";
            this.colBoundryCode_nvc.Name = "colBoundryCode_nvc";
            this.colBoundryCode_nvc.ReadOnly = true;
            this.colBoundryCode_nvc.Width = 200;
            // 
            // colBoundry_nvc
            // 
            this.colBoundry_nvc.DataPropertyName = "Boundry_nvc";
            this.colBoundry_nvc.HeaderText = "نام مرز";
            this.colBoundry_nvc.Name = "colBoundry_nvc";
            this.colBoundry_nvc.ReadOnly = true;
            this.colBoundry_nvc.Width = 500;
            // 
            // BoundryToolStrip
            // 
            this.BoundryToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BoundryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.BoundryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BoundryToolStrip.Name = "BoundryToolStrip";
            this.BoundryToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BoundryToolStrip.Size = new System.Drawing.Size(700, 31);
            this.BoundryToolStrip.TabIndex = 1;
            // 
            // BoundryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.BoundryGridView);
            this.Controls.Add(this.BoundryToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "BoundryListForm";
            this.Text = "لیست مرزها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BoundryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoundryGridView)).EndInit();
            this.BoundryToolStrip.ResumeLayout(false);
            this.BoundryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip BoundryToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView BoundryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoundryID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoundryCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoundry_nvc;
    }

}