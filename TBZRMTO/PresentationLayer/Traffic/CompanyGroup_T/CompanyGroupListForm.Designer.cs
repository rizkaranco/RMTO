namespace HPS.Present.CompanyGroup
    {
    partial class CompanyGroupListForm 

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
            this.NewCompanyGroupButton = new System.Windows.Forms.ToolStripButton();
            this.EditCompanyGroupButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteCompanyGroupButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshCompanyGroupButton = new System.Windows.Forms.ToolStripButton();
            this.ExportCompanyGroupButton = new System.Windows.Forms.ToolStripButton();
            this.CompanyGroupGridView = new System.Windows.Forms.DataGridView();
            this.CompanyGroupToolStrip = new System.Windows.Forms.ToolStrip();
            this.colGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGroupGridView)).BeginInit();
            this.CompanyGroupToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewCompanyGroupButton
            // 
            this.NewCompanyGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewCompanyGroupButton.Image = global::HPS.Properties.Resources.Add;
            this.NewCompanyGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewCompanyGroupButton.Name = "NewCompanyGroupButton";
            this.NewCompanyGroupButton.Size = new System.Drawing.Size(28, 28);
            this.NewCompanyGroupButton.Text = "جديد";
            this.NewCompanyGroupButton.Click += new System.EventHandler(this.NewCompanyGroupButton_Click);
            // 
            // EditCompanyGroupButton
            // 
            this.EditCompanyGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditCompanyGroupButton.Image = global::HPS.Properties.Resources.Edit;
            this.EditCompanyGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCompanyGroupButton.Name = "EditCompanyGroupButton";
            this.EditCompanyGroupButton.Size = new System.Drawing.Size(28, 28);
            this.EditCompanyGroupButton.Text = "ويرايش";
            this.EditCompanyGroupButton.Click += new System.EventHandler(this.EditCompanyGroupButton_Click);
            // 
            // DeleteCompanyGroupButton
            // 
            this.DeleteCompanyGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCompanyGroupButton.Image = global::HPS.Properties.Resources.Delete;
            this.DeleteCompanyGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCompanyGroupButton.Name = "DeleteCompanyGroupButton";
            this.DeleteCompanyGroupButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteCompanyGroupButton.Text = "حذف";
            this.DeleteCompanyGroupButton.Click += new System.EventHandler(this.DeleteCompanyGroupButton_Click);
            // 
            // RefreshCompanyGroupButton
            // 
            this.RefreshCompanyGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshCompanyGroupButton.Image = global::HPS.Properties.Resources.Refresh;
            this.RefreshCompanyGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshCompanyGroupButton.Name = "RefreshCompanyGroupButton";
            this.RefreshCompanyGroupButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshCompanyGroupButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshCompanyGroupButton.Click += new System.EventHandler(this.RefreshCompanyGroupButton_Click);
            // 
            // ExportCompanyGroupButton
            // 
            this.ExportCompanyGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportCompanyGroupButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportCompanyGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportCompanyGroupButton.Name = "ExportCompanyGroupButton";
            this.ExportCompanyGroupButton.Size = new System.Drawing.Size(28, 28);
            this.ExportCompanyGroupButton.Text = "انتقال به اکسل";
            // 
            // CompanyGroupGridView
            // 
            this.CompanyGroupGridView.AllowUserToAddRows = false;
            this.CompanyGroupGridView.AllowUserToDeleteRows = false;
            this.CompanyGroupGridView.AllowUserToResizeRows = false;
            this.CompanyGroupGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CompanyGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyGroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupID_int,
            this.colGroupName_nvc});
            this.CompanyGroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyGroupGridView.Location = new System.Drawing.Point(0, 31);
            this.CompanyGroupGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CompanyGroupGridView.MultiSelect = false;
            this.CompanyGroupGridView.Name = "CompanyGroupGridView";
            this.CompanyGroupGridView.ReadOnly = true;
            this.CompanyGroupGridView.RowHeadersVisible = false;
            this.CompanyGroupGridView.Size = new System.Drawing.Size(604, 377);
            this.CompanyGroupGridView.TabIndex = 0;
            // 
            // CompanyGroupToolStrip
            // 
            this.CompanyGroupToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CompanyGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCompanyGroupButton,
            this.EditCompanyGroupButton,
            this.DeleteCompanyGroupButton,
            this.RefreshCompanyGroupButton,
            this.ExportCompanyGroupButton});
            this.CompanyGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CompanyGroupToolStrip.Name = "CompanyGroupToolStrip";
            this.CompanyGroupToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CompanyGroupToolStrip.Size = new System.Drawing.Size(604, 31);
            this.CompanyGroupToolStrip.TabIndex = 1;
            // 
            // colGroupID_int
            // 
            this.colGroupID_int.DataPropertyName = "GroupID_int";
            this.colGroupID_int.HeaderText = "گروه";
            this.colGroupID_int.Name = "colGroupID_int";
            this.colGroupID_int.ReadOnly = true;
            this.colGroupID_int.Visible = false;
            // 
            // colGroupName_nvc
            // 
            this.colGroupName_nvc.DataPropertyName = "GroupName_nvc";
            this.colGroupName_nvc.HeaderText = "نام گروه";
            this.colGroupName_nvc.Name = "colGroupName_nvc";
            this.colGroupName_nvc.ReadOnly = true;
            this.colGroupName_nvc.Width = 600;
            // 
            // CompanyGroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(604, 408);
            this.Controls.Add(this.CompanyGroupGridView);
            this.Controls.Add(this.CompanyGroupToolStrip);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "CompanyGroupListForm";
            this.Text = "گروه شرکت ها فهرست ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyGroupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyGroupGridView)).EndInit();
            this.CompanyGroupToolStrip.ResumeLayout(false);
            this.CompanyGroupToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip CompanyGroupToolStrip;
        private System.Windows.Forms.ToolStripButton NewCompanyGroupButton;
        private System.Windows.Forms.ToolStripButton EditCompanyGroupButton;
        private System.Windows.Forms.ToolStripButton DeleteCompanyGroupButton;
        private System.Windows.Forms.ToolStripButton RefreshCompanyGroupButton;
        private System.Windows.Forms.ToolStripButton ExportCompanyGroupButton;
        private System.Windows.Forms.DataGridView CompanyGroupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName_nvc;
    }

}