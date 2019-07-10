namespace HPS.Present.TurnCancelComment
    {
    partial class TurnCancelCommentListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnCancelCommentListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.TurnCancelCommentGridView = new System.Windows.Forms.DataGridView();
            this.TurnCancelCommentToolStrip = new System.Windows.Forms.ToolStrip();
            this.colTurnCancelCommentID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnCancelComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TurnCancelCommentGridView)).BeginInit();
            this.TurnCancelCommentToolStrip.SuspendLayout();
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
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // TurnCancelCommentGridView
            // 
            this.TurnCancelCommentGridView.AllowUserToAddRows = false;
            this.TurnCancelCommentGridView.AllowUserToDeleteRows = false;
            this.TurnCancelCommentGridView.AllowUserToResizeRows = false;
            this.TurnCancelCommentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TurnCancelCommentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnCancelCommentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTurnCancelCommentID_int,
            this.colTurnCancelComment_nvc,
            this.colUserGroupID_int});
            this.TurnCancelCommentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurnCancelCommentGridView.Location = new System.Drawing.Point(0, 31);
            this.TurnCancelCommentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.TurnCancelCommentGridView.MultiSelect = false;
            this.TurnCancelCommentGridView.Name = "TurnCancelCommentGridView";
            this.TurnCancelCommentGridView.ReadOnly = true;
            this.TurnCancelCommentGridView.RowHeadersVisible = false;
            this.TurnCancelCommentGridView.Size = new System.Drawing.Size(700, 409);
            this.TurnCancelCommentGridView.TabIndex = 0;
            // 
            // TurnCancelCommentToolStrip
            // 
            this.TurnCancelCommentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TurnCancelCommentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.TurnCancelCommentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TurnCancelCommentToolStrip.Name = "TurnCancelCommentToolStrip";
            this.TurnCancelCommentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TurnCancelCommentToolStrip.Size = new System.Drawing.Size(700, 31);
            this.TurnCancelCommentToolStrip.TabIndex = 1;
            // 
            // colTurnCancelCommentID_int
            // 
            this.colTurnCancelCommentID_int.DataPropertyName = "TurnCancelCommentID_int";
            this.colTurnCancelCommentID_int.HeaderText = " شناسه توضیحات ابطال نوبت";
            this.colTurnCancelCommentID_int.Name = "colTurnCancelCommentID_int";
            this.colTurnCancelCommentID_int.ReadOnly = true;
            this.colTurnCancelCommentID_int.Visible = false;
            // 
            // colTurnCancelComment_nvc
            // 
            this.colTurnCancelComment_nvc.DataPropertyName = "TurnCancelComment_nvc";
            this.colTurnCancelComment_nvc.HeaderText = "توضیحات ابطال نوبت";
            this.colTurnCancelComment_nvc.Name = "colTurnCancelComment_nvc";
            this.colTurnCancelComment_nvc.ReadOnly = true;
            this.colTurnCancelComment_nvc.Width = 400;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه کاربری";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 300;
            // 
            // TurnCancelCommentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.TurnCancelCommentGridView);
            this.Controls.Add(this.TurnCancelCommentToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "TurnCancelCommentListForm";
            this.Text = "لسیت توضیحات ابطال نوبت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TurnCancelCommentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TurnCancelCommentGridView)).EndInit();
            this.TurnCancelCommentToolStrip.ResumeLayout(false);
            this.TurnCancelCommentToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip TurnCancelCommentToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView TurnCancelCommentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnCancelCommentID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnCancelComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
    }

}