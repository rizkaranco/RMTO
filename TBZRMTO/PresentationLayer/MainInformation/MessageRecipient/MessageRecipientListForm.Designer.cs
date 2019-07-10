namespace HPS.Present.MessageRecipient
    {
    partial class MessageRecipientListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageRecipientListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.MessageRecipientGridView = new System.Windows.Forms.DataGridView();
            this.MessageRecipientToolStrip = new System.Windows.Forms.ToolStrip();
            this.colMessageRecipientID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MessageRecipientGridView)).BeginInit();
            this.MessageRecipientToolStrip.SuspendLayout();
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
            // MessageRecipientGridView
            // 
            this.MessageRecipientGridView.AllowUserToAddRows = false;
            this.MessageRecipientGridView.AllowUserToDeleteRows = false;
            this.MessageRecipientGridView.AllowUserToResizeRows = false;
            this.MessageRecipientGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.MessageRecipientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageRecipientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMessageRecipientID_int,
            this.colMessageID_bint,
            this.colUserGroupID_int,
            this.colStartDate_nvc,
            this.colEndDate_nvc,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colUserName_nvc});
            this.MessageRecipientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageRecipientGridView.Location = new System.Drawing.Point(0, 31);
            this.MessageRecipientGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MessageRecipientGridView.MultiSelect = false;
            this.MessageRecipientGridView.Name = "MessageRecipientGridView";
            this.MessageRecipientGridView.ReadOnly = true;
            this.MessageRecipientGridView.RowHeadersVisible = false;
            this.MessageRecipientGridView.Size = new System.Drawing.Size(744, 395);
            this.MessageRecipientGridView.TabIndex = 0;
            // 
            // MessageRecipientToolStrip
            // 
            this.MessageRecipientToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MessageRecipientToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.MessageRecipientToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MessageRecipientToolStrip.Name = "MessageRecipientToolStrip";
            this.MessageRecipientToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MessageRecipientToolStrip.Size = new System.Drawing.Size(744, 31);
            this.MessageRecipientToolStrip.TabIndex = 1;
            // 
            // colMessageRecipientID_int
            // 
            this.colMessageRecipientID_int.DataPropertyName = "MessageRecipientID_int";
            this.colMessageRecipientID_int.HeaderText = "شناسه دریافت کننده پیام";
            this.colMessageRecipientID_int.Name = "colMessageRecipientID_int";
            this.colMessageRecipientID_int.ReadOnly = true;
            this.colMessageRecipientID_int.Visible = false;
            // 
            // colMessageID_bint
            // 
            this.colMessageID_bint.DataPropertyName = "MessageID_bintMessageTitle_nvc";
            this.colMessageID_bint.HeaderText = "پیام";
            this.colMessageID_bint.Name = "colMessageID_bint";
            this.colMessageID_bint.ReadOnly = true;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه دریافت کننده";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 150;
            // 
            // colStartDate_nvc
            // 
            this.colStartDate_nvc.DataPropertyName = "StartDate_nvc";
            this.colStartDate_nvc.HeaderText = "از تاریخ";
            this.colStartDate_nvc.Name = "colStartDate_nvc";
            this.colStartDate_nvc.ReadOnly = true;
            // 
            // colEndDate_nvc
            // 
            this.colEndDate_nvc.DataPropertyName = "EndDate_nvc";
            this.colEndDate_nvc.HeaderText = "تا تاریخ";
            this.colEndDate_nvc.Name = "colEndDate_nvc";
            this.colEndDate_nvc.ReadOnly = true;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 98;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 98;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 95;
            // 
            // MessageRecipientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(744, 426);
            this.Controls.Add(this.MessageRecipientGridView);
            this.Controls.Add(this.MessageRecipientToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "MessageRecipientListForm";
            this.Text = "لیست گروه دریافت کننده پیام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MessageRecipientListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessageRecipientGridView)).EndInit();
            this.MessageRecipientToolStrip.ResumeLayout(false);
            this.MessageRecipientToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip MessageRecipientToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView MessageRecipientGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageRecipientID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
    }

}