namespace HPS.Present.UserGroup
    {
    partial class UserGroupListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGroupListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.UserGroupGridView = new System.Windows.Forms.DataGridView();
            this.UserGroupToolStrip = new System.Windows.Forms.ToolStrip();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroup_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermission_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupGridView)).BeginInit();
            this.UserGroupToolStrip.SuspendLayout();
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
            // UserGroupGridView
            // 
            this.UserGroupGridView.AllowUserToAddRows = false;
            this.UserGroupGridView.AllowUserToDeleteRows = false;
            this.UserGroupGridView.AllowUserToResizeRows = false;
            this.UserGroupGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.UserGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserGroupID_int,
            this.colUserGroup_nvc,
            this.colPermission_nvc,
            this.colActive_bit});
            this.UserGroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGroupGridView.Location = new System.Drawing.Point(0, 31);
            this.UserGroupGridView.Margin = new System.Windows.Forms.Padding(5);
            this.UserGroupGridView.MultiSelect = false;
            this.UserGroupGridView.Name = "UserGroupGridView";
            this.UserGroupGridView.ReadOnly = true;
            this.UserGroupGridView.RowHeadersVisible = false;
            this.UserGroupGridView.Size = new System.Drawing.Size(694, 386);
            this.UserGroupGridView.TabIndex = 0;
            // 
            // UserGroupToolStrip
            // 
            this.UserGroupToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UserGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.UserGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.UserGroupToolStrip.Name = "UserGroupToolStrip";
            this.UserGroupToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.UserGroupToolStrip.Size = new System.Drawing.Size(694, 31);
            this.UserGroupToolStrip.TabIndex = 1;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_int";
            this.colUserGroupID_int.HeaderText = "شناسه گروه کاربری";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Visible = false;
            // 
            // colUserGroup_nvc
            // 
            this.colUserGroup_nvc.DataPropertyName = "UserGroup_nvc";
            this.colUserGroup_nvc.HeaderText = "گروه کاربری";
            this.colUserGroup_nvc.Name = "colUserGroup_nvc";
            this.colUserGroup_nvc.ReadOnly = true;
            this.colUserGroup_nvc.Width = 500;
            // 
            // colPermission_nvc
            // 
            this.colPermission_nvc.DataPropertyName = "Permission_nvc";
            this.colPermission_nvc.HeaderText = "دسترسی";
            this.colPermission_nvc.Name = "colPermission_nvc";
            this.colPermission_nvc.ReadOnly = true;
            this.colPermission_nvc.Visible = false;
            this.colPermission_nvc.Width = 346;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 200;
            // 
            // UserGroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(694, 417);
            this.Controls.Add(this.UserGroupGridView);
            this.Controls.Add(this.UserGroupToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "UserGroupListForm";
            this.Text = "لیست گروه کاربری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserGroupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserGroupGridView)).EndInit();
            this.UserGroupToolStrip.ResumeLayout(false);
            this.UserGroupToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip UserGroupToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView UserGroupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroup_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermission_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}