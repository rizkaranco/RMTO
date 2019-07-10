namespace HPS.Present.Boxing
    {
    partial class BoxingListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxingListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.BoxingGridView = new System.Windows.Forms.DataGridView();
            this.colBoxingID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoxingCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoxingType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BoxingToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.BoxingGridView)).BeginInit();
            this.BoxingToolStrip.SuspendLayout();
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
            // BoxingGridView
            // 
            this.BoxingGridView.AllowUserToAddRows = false;
            this.BoxingGridView.AllowUserToDeleteRows = false;
            this.BoxingGridView.AllowUserToResizeRows = false;
            this.BoxingGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.BoxingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoxingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBoxingID_int,
            this.colBoxingCode_nvc,
            this.colBoxingType_nvc,
            this.colActive_bit});
            this.BoxingGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxingGridView.Location = new System.Drawing.Point(0, 31);
            this.BoxingGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BoxingGridView.MultiSelect = false;
            this.BoxingGridView.Name = "BoxingGridView";
            this.BoxingGridView.ReadOnly = true;
            this.BoxingGridView.RowHeadersVisible = false;
            this.BoxingGridView.Size = new System.Drawing.Size(697, 409);
            this.BoxingGridView.TabIndex = 0;
            // 
            // colBoxingID_int
            // 
            this.colBoxingID_int.DataPropertyName = "BoxingID_int";
            this.colBoxingID_int.HeaderText = "شناسه دسته بندی";
            this.colBoxingID_int.Name = "colBoxingID_int";
            this.colBoxingID_int.ReadOnly = true;
            this.colBoxingID_int.Visible = false;
            // 
            // colBoxingCode_nvc
            // 
            this.colBoxingCode_nvc.DataPropertyName = "BoxingCode_nvc";
            this.colBoxingCode_nvc.HeaderText = "کد بسته بندی";
            this.colBoxingCode_nvc.Name = "colBoxingCode_nvc";
            this.colBoxingCode_nvc.ReadOnly = true;
            this.colBoxingCode_nvc.Width = 250;
            // 
            // colBoxingType_nvc
            // 
            this.colBoxingType_nvc.DataPropertyName = "BoxingType_nvc";
            this.colBoxingType_nvc.HeaderText = " نوع بسته بندی";
            this.colBoxingType_nvc.Name = "colBoxingType_nvc";
            this.colBoxingType_nvc.ReadOnly = true;
            this.colBoxingType_nvc.Width = 250;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 195;
            // 
            // BoxingToolStrip
            // 
            this.BoxingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BoxingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.BoxingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BoxingToolStrip.Name = "BoxingToolStrip";
            this.BoxingToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BoxingToolStrip.Size = new System.Drawing.Size(697, 31);
            this.BoxingToolStrip.TabIndex = 1;
            // 
            // BoxingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(697, 440);
            this.Controls.Add(this.BoxingGridView);
            this.Controls.Add(this.BoxingToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "BoxingListForm";
            this.Text = "لیست بسته بندی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BoxingListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxingGridView)).EndInit();
            this.BoxingToolStrip.ResumeLayout(false);
            this.BoxingToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip BoxingToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView BoxingGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingType_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}