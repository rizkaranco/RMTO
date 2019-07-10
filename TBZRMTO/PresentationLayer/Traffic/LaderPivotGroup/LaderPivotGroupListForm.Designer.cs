namespace HPS.Present.LaderPivotGroup
    {
    partial class LaderPivotGroupListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaderPivotGroupListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.LaderPivotGroupGridView = new System.Windows.Forms.DataGridView();
            this.colLaderPivotGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderPivotGroup_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaderPivotGroupToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.LaderPivotGroupGridView)).BeginInit();
            this.LaderPivotGroupToolStrip.SuspendLayout();
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
            // LaderPivotGroupGridView
            // 
            this.LaderPivotGroupGridView.AllowUserToAddRows = false;
            this.LaderPivotGroupGridView.AllowUserToDeleteRows = false;
            this.LaderPivotGroupGridView.AllowUserToResizeRows = false;
            this.LaderPivotGroupGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LaderPivotGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaderPivotGroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLaderPivotGroupID_int,
            this.colLaderPivotGroup_nvc});
            this.LaderPivotGroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaderPivotGroupGridView.Location = new System.Drawing.Point(0, 31);
            this.LaderPivotGroupGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupGridView.MultiSelect = false;
            this.LaderPivotGroupGridView.Name = "LaderPivotGroupGridView";
            this.LaderPivotGroupGridView.ReadOnly = true;
            this.LaderPivotGroupGridView.RowHeadersVisible = false;
            this.LaderPivotGroupGridView.Size = new System.Drawing.Size(695, 439);
            this.LaderPivotGroupGridView.TabIndex = 0;
            // 
            // colLaderPivotGroupID_int
            // 
            this.colLaderPivotGroupID_int.DataPropertyName = "LaderPivotGroupID_int";
            this.colLaderPivotGroupID_int.HeaderText = "شناسه گروه انواع بارگیر";
            this.colLaderPivotGroupID_int.Name = "colLaderPivotGroupID_int";
            this.colLaderPivotGroupID_int.ReadOnly = true;
            this.colLaderPivotGroupID_int.Visible = false;
            // 
            // colLaderPivotGroup_nvc
            // 
            this.colLaderPivotGroup_nvc.DataPropertyName = "LaderPivotGroup_nvc";
            this.colLaderPivotGroup_nvc.HeaderText = "گروه انواع بارگیر";
            this.colLaderPivotGroup_nvc.Name = "colLaderPivotGroup_nvc";
            this.colLaderPivotGroup_nvc.ReadOnly = true;
            this.colLaderPivotGroup_nvc.Width = 696;
            // 
            // LaderPivotGroupToolStrip
            // 
            this.LaderPivotGroupToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LaderPivotGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.LaderPivotGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LaderPivotGroupToolStrip.Name = "LaderPivotGroupToolStrip";
            this.LaderPivotGroupToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LaderPivotGroupToolStrip.Size = new System.Drawing.Size(695, 31);
            this.LaderPivotGroupToolStrip.TabIndex = 1;
            // 
            // LaderPivotGroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(695, 470);
            this.Controls.Add(this.LaderPivotGroupGridView);
            this.Controls.Add(this.LaderPivotGroupToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LaderPivotGroupListForm";
            this.Text = "لیست گروه انواع بارگیر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaderPivotGroupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaderPivotGroupGridView)).EndInit();
            this.LaderPivotGroupToolStrip.ResumeLayout(false);
            this.LaderPivotGroupToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip LaderPivotGroupToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView LaderPivotGroupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroup_nvc;
    }

}