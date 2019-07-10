namespace HPS.Present.LadBillCancelComment
    {
    partial class LadBillCancelCommentListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadBillCancelCommentListForm));
            this.LadBillCancelCommentGridView = new System.Windows.Forms.DataGridView();
            this.colLadBillCancelCommentID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadbillCancelComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadBillCancelCommentToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.LadBillCancelCommentGridView)).BeginInit();
            this.LadBillCancelCommentToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LadBillCancelCommentGridView
            // 
            this.LadBillCancelCommentGridView.AllowUserToAddRows = false;
            this.LadBillCancelCommentGridView.AllowUserToDeleteRows = false;
            this.LadBillCancelCommentGridView.AllowUserToResizeRows = false;
            this.LadBillCancelCommentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LadBillCancelCommentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadBillCancelCommentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadBillCancelCommentID_int,
            this.colLadbillCancelComment_nvc,
            this.colUserGroupID_int});
            this.LadBillCancelCommentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadBillCancelCommentGridView.Location = new System.Drawing.Point(0, 31);
            this.LadBillCancelCommentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadBillCancelCommentGridView.MultiSelect = false;
            this.LadBillCancelCommentGridView.Name = "LadBillCancelCommentGridView";
            this.LadBillCancelCommentGridView.ReadOnly = true;
            this.LadBillCancelCommentGridView.RowHeadersVisible = false;
            this.LadBillCancelCommentGridView.Size = new System.Drawing.Size(700, 409);
            this.LadBillCancelCommentGridView.TabIndex = 0;
            // 
            // colLadBillCancelCommentID_int
            // 
            this.colLadBillCancelCommentID_int.DataPropertyName = "LadBillCancelCommentID_int";
            this.colLadBillCancelCommentID_int.HeaderText = "شناسه ابطال مجوز";
            this.colLadBillCancelCommentID_int.Name = "colLadBillCancelCommentID_int";
            this.colLadBillCancelCommentID_int.ReadOnly = true;
            this.colLadBillCancelCommentID_int.Visible = false;
            // 
            // colLadbillCancelComment_nvc
            // 
            this.colLadbillCancelComment_nvc.DataPropertyName = "LadbillCancelComment_nvc";
            this.colLadbillCancelComment_nvc.HeaderText = "توضیحات ابطال مجوز";
            this.colLadbillCancelComment_nvc.Name = "colLadbillCancelComment_nvc";
            this.colLadbillCancelComment_nvc.ReadOnly = true;
            this.colLadbillCancelComment_nvc.Width = 400;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه کاربری";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 300;
            // 
            // LadBillCancelCommentToolStrip
            // 
            this.LadBillCancelCommentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadBillCancelCommentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.LadBillCancelCommentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LadBillCancelCommentToolStrip.Name = "LadBillCancelCommentToolStrip";
            this.LadBillCancelCommentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadBillCancelCommentToolStrip.Size = new System.Drawing.Size(700, 31);
            this.LadBillCancelCommentToolStrip.TabIndex = 1;
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
            this.ExportButton.Tag = "انتقای به اکسل";
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // LadBillCancelCommentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.LadBillCancelCommentGridView);
            this.Controls.Add(this.LadBillCancelCommentToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LadBillCancelCommentListForm";
            this.Text = "لیست توضیحات ابطال مجوز";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LadBillCancelCommentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LadBillCancelCommentGridView)).EndInit();
            this.LadBillCancelCommentToolStrip.ResumeLayout(false);
            this.LadBillCancelCommentToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip LadBillCancelCommentToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView LadBillCancelCommentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCancelCommentID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadbillCancelComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
    }

}