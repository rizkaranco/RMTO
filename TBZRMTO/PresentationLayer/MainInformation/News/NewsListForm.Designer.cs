namespace HPS.Present.News
    {
    partial class NewsListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.NewsGridView = new System.Windows.Forms.DataGridView();
            this.colNewsID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNews_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewsToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.NewsGridView)).BeginInit();
            this.NewsToolStrip.SuspendLayout();
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
            // NewsGridView
            // 
            this.NewsGridView.AllowUserToAddRows = false;
            this.NewsGridView.AllowUserToDeleteRows = false;
            this.NewsGridView.AllowUserToResizeRows = false;
            this.NewsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.NewsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNewsID_bint,
            this.colTitle_nvc,
            this.colNews_nvc,
            this.colStartDate_nvc,
            this.colEndDate_nvc,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colUserName_nvc});
            this.NewsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewsGridView.Location = new System.Drawing.Point(0, 31);
            this.NewsGridView.Margin = new System.Windows.Forms.Padding(5);
            this.NewsGridView.MultiSelect = false;
            this.NewsGridView.Name = "NewsGridView";
            this.NewsGridView.ReadOnly = true;
            this.NewsGridView.RowHeadersVisible = false;
            this.NewsGridView.Size = new System.Drawing.Size(700, 419);
            this.NewsGridView.TabIndex = 0;
            // 
            // colNewsID_bint
            // 
            this.colNewsID_bint.DataPropertyName = "NewsID_bint";
            this.colNewsID_bint.HeaderText = "شناسه اخبار";
            this.colNewsID_bint.Name = "colNewsID_bint";
            this.colNewsID_bint.ReadOnly = true;
            this.colNewsID_bint.Visible = false;
            // 
            // colTitle_nvc
            // 
            this.colTitle_nvc.DataPropertyName = "Title_nvc";
            this.colTitle_nvc.HeaderText = "عنوان خبر";
            this.colTitle_nvc.Name = "colTitle_nvc";
            this.colTitle_nvc.ReadOnly = true;
            this.colTitle_nvc.Width = 150;
            // 
            // colNews_nvc
            // 
            this.colNews_nvc.DataPropertyName = "News_nvc";
            this.colNews_nvc.HeaderText = "متن خبر";
            this.colNews_nvc.Name = "colNews_nvc";
            this.colNews_nvc.ReadOnly = true;
            this.colNews_nvc.Width = 250;
            // 
            // colStartDate_nvc
            // 
            this.colStartDate_nvc.DataPropertyName = "StartDate_nvc";
            this.colStartDate_nvc.HeaderText = "از تاریخ";
            this.colStartDate_nvc.Name = "colStartDate_nvc";
            this.colStartDate_nvc.ReadOnly = true;
            this.colStartDate_nvc.Width = 150;
            // 
            // colEndDate_nvc
            // 
            this.colEndDate_nvc.DataPropertyName = "EndDate_nvc";
            this.colEndDate_nvc.HeaderText = "تا تاریخ";
            this.colEndDate_nvc.Name = "colEndDate_nvc";
            this.colEndDate_nvc.ReadOnly = true;
            this.colEndDate_nvc.Width = 150;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Visible = false;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Visible = false;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Visible = false;
            // 
            // NewsToolStrip
            // 
            this.NewsToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NewsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.NewsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.NewsToolStrip.Name = "NewsToolStrip";
            this.NewsToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.NewsToolStrip.Size = new System.Drawing.Size(700, 31);
            this.NewsToolStrip.TabIndex = 1;
            // 
            // NewsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.NewsGridView);
            this.Controls.Add(this.NewsToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "NewsListForm";
            this.Text = "لیست اخبار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewsGridView)).EndInit();
            this.NewsToolStrip.ResumeLayout(false);
            this.NewsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip NewsToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView NewsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewsID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNews_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
    }

}