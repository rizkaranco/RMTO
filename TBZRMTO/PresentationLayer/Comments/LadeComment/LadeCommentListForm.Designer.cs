namespace HPS.Present.LadeComment
    {
    partial class LadeCommentListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadeCommentListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.LadeCommentGridView = new System.Windows.Forms.DataGridView();
            this.LadeCommentToolStrip = new System.Windows.Forms.ToolStrip();
            this.colLadeCommentID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadeComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LadeCommentGridView)).BeginInit();
            this.LadeCommentToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.Tag = "جدید";
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
            this.EditButton.Tag = "تغییرات";
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::HPS.Properties.Resources.Delete;
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
            this.ExportButton.Tag = "انتقال به اکسل";
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // LadeCommentGridView
            // 
            this.LadeCommentGridView.AllowUserToAddRows = false;
            this.LadeCommentGridView.AllowUserToDeleteRows = false;
            this.LadeCommentGridView.AllowUserToResizeRows = false;
            this.LadeCommentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LadeCommentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadeCommentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadeCommentID_int,
            this.colLadeComment_nvc,
            this.colUserGroupID_int});
            this.LadeCommentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadeCommentGridView.Location = new System.Drawing.Point(0, 31);
            this.LadeCommentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadeCommentGridView.MultiSelect = false;
            this.LadeCommentGridView.Name = "LadeCommentGridView";
            this.LadeCommentGridView.ReadOnly = true;
            this.LadeCommentGridView.RowHeadersVisible = false;
            this.LadeCommentGridView.Size = new System.Drawing.Size(700, 409);
            this.LadeCommentGridView.TabIndex = 0;
            // 
            // LadeCommentToolStrip
            // 
            this.LadeCommentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadeCommentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.LadeCommentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LadeCommentToolStrip.Name = "LadeCommentToolStrip";
            this.LadeCommentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadeCommentToolStrip.Size = new System.Drawing.Size(700, 31);
            this.LadeCommentToolStrip.TabIndex = 1;
            // 
            // colLadeCommentID_int
            // 
            this.colLadeCommentID_int.DataPropertyName = "LadeCommentID_int";
            this.colLadeCommentID_int.HeaderText = "شناسه توضیحات اطلاع رسانی بار";
            this.colLadeCommentID_int.Name = "colLadeCommentID_int";
            this.colLadeCommentID_int.ReadOnly = true;
            this.colLadeCommentID_int.Visible = false;
            // 
            // colLadeComment_nvc
            // 
            this.colLadeComment_nvc.DataPropertyName = "LadeComment_nvc";
            this.colLadeComment_nvc.HeaderText = "توضیحات اطلاع رسانی بار";
            this.colLadeComment_nvc.Name = "colLadeComment_nvc";
            this.colLadeComment_nvc.ReadOnly = true;
            this.colLadeComment_nvc.Width = 400;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه کاربری";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 300;
            // 
            // LadeCommentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.LadeCommentGridView);
            this.Controls.Add(this.LadeCommentToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LadeCommentListForm";
            this.Text = "لیست توضیحات اطلاع رسانی بار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LadeCommentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LadeCommentGridView)).EndInit();
            this.LadeCommentToolStrip.ResumeLayout(false);
            this.LadeCommentToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip LadeCommentToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView LadeCommentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadeCommentID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadeComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
    }

}