namespace HPS.Present.LadeCancelComment
    {
    partial class LadeCancelCommentListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadeCancelCommentListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.LadeCancelCommentGridView = new System.Windows.Forms.DataGridView();
            this.colLadeCanceltCommentID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadeCancelComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadeCancelCommentToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.LadeCancelCommentGridView)).BeginInit();
            this.LadeCancelCommentToolStrip.SuspendLayout();
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
            // LadeCancelCommentGridView
            // 
            this.LadeCancelCommentGridView.AllowUserToAddRows = false;
            this.LadeCancelCommentGridView.AllowUserToDeleteRows = false;
            this.LadeCancelCommentGridView.AllowUserToResizeRows = false;
            this.LadeCancelCommentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LadeCancelCommentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadeCancelCommentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadeCanceltCommentID_int,
            this.colLadeCancelComment_nvc,
            this.colUserGroupID_int});
            this.LadeCancelCommentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadeCancelCommentGridView.Location = new System.Drawing.Point(0, 31);
            this.LadeCancelCommentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadeCancelCommentGridView.MultiSelect = false;
            this.LadeCancelCommentGridView.Name = "LadeCancelCommentGridView";
            this.LadeCancelCommentGridView.ReadOnly = true;
            this.LadeCancelCommentGridView.RowHeadersVisible = false;
            this.LadeCancelCommentGridView.Size = new System.Drawing.Size(700, 409);
            this.LadeCancelCommentGridView.TabIndex = 0;
            // 
            // colLadeCanceltCommentID_int
            // 
            this.colLadeCanceltCommentID_int.DataPropertyName = "LadeCanceltCommentID_int";
            this.colLadeCanceltCommentID_int.HeaderText = "شناسه توضیحات انصراف از اطلاع رسانی بار";
            this.colLadeCanceltCommentID_int.Name = "colLadeCanceltCommentID_int";
            this.colLadeCanceltCommentID_int.ReadOnly = true;
            this.colLadeCanceltCommentID_int.Visible = false;
            // 
            // colLadeCancelComment_nvc
            // 
            this.colLadeCancelComment_nvc.DataPropertyName = "LadeCancelComment_nvc";
            this.colLadeCancelComment_nvc.HeaderText = "توضیحات انصراف از اطلاع رسانی بار";
            this.colLadeCancelComment_nvc.Name = "colLadeCancelComment_nvc";
            this.colLadeCancelComment_nvc.ReadOnly = true;
            this.colLadeCancelComment_nvc.Width = 400;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه کاربری";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 300;
            // 
            // LadeCancelCommentToolStrip
            // 
            this.LadeCancelCommentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadeCancelCommentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.LadeCancelCommentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LadeCancelCommentToolStrip.Name = "LadeCancelCommentToolStrip";
            this.LadeCancelCommentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadeCancelCommentToolStrip.Size = new System.Drawing.Size(700, 31);
            this.LadeCancelCommentToolStrip.TabIndex = 1;
            this.LadeCancelCommentToolStrip.Text = "لیست توضیحات انصراف از اطلاع رسانی بار";
            // 
            // LadeCancelCommentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.LadeCancelCommentGridView);
            this.Controls.Add(this.LadeCancelCommentToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LadeCancelCommentListForm";
            this.Text = "ایست توضیحات انصراف از اطلاع رسانی بار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LadeCancelCommentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LadeCancelCommentGridView)).EndInit();
            this.LadeCancelCommentToolStrip.ResumeLayout(false);
            this.LadeCancelCommentToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip LadeCancelCommentToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView LadeCancelCommentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadeCanceltCommentID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadeCancelComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
    }

}