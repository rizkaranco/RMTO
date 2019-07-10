namespace HPS.Present.Message
    {
    partial class MessageListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.MessageGridView = new System.Windows.Forms.DataGridView();
            this.colMessageID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageTitle_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVisited_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRecipientUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.MessageGridView)).BeginInit();
            this.MessageToolStrip.SuspendLayout();
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
            // MessageGridView
            // 
            this.MessageGridView.AllowUserToAddRows = false;
            this.MessageGridView.AllowUserToDeleteRows = false;
            this.MessageGridView.AllowUserToResizeRows = false;
            this.MessageGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.MessageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMessageID_bint,
            this.colMessageTitle_nvc,
            this.colMessage_nvc,
            this.colStartDate_nvc,
            this.colEndDate_nvc,
            this.colVisited_bit,
            this.colRecipientUserName_nvc,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colUserName_nvc});
            this.MessageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageGridView.Location = new System.Drawing.Point(0, 31);
            this.MessageGridView.Margin = new System.Windows.Forms.Padding(5);
            this.MessageGridView.MultiSelect = false;
            this.MessageGridView.Name = "MessageGridView";
            this.MessageGridView.ReadOnly = true;
            this.MessageGridView.RowHeadersVisible = false;
            this.MessageGridView.Size = new System.Drawing.Size(729, 395);
            this.MessageGridView.TabIndex = 0;
            // 
            // colMessageID_bint
            // 
            this.colMessageID_bint.DataPropertyName = "MessageID_bint";
            this.colMessageID_bint.HeaderText = "شناسه پيام";
            this.colMessageID_bint.Name = "colMessageID_bint";
            this.colMessageID_bint.ReadOnly = true;
            this.colMessageID_bint.Visible = false;
            // 
            // colMessageTitle_nvc
            // 
            this.colMessageTitle_nvc.DataPropertyName = "MessageTitle_nvc";
            this.colMessageTitle_nvc.HeaderText = "عنوان پيام";
            this.colMessageTitle_nvc.Name = "colMessageTitle_nvc";
            this.colMessageTitle_nvc.ReadOnly = true;
            // 
            // colMessage_nvc
            // 
            this.colMessage_nvc.DataPropertyName = "Message_nvc";
            this.colMessage_nvc.HeaderText = "متن پيام";
            this.colMessage_nvc.Name = "colMessage_nvc";
            this.colMessage_nvc.ReadOnly = true;
            this.colMessage_nvc.Width = 245;
            // 
            // colStartDate_nvc
            // 
            this.colStartDate_nvc.DataPropertyName = "StartDate_nvc";
            this.colStartDate_nvc.HeaderText = "از تاریخ";
            this.colStartDate_nvc.Name = "colStartDate_nvc";
            this.colStartDate_nvc.ReadOnly = true;
            this.colStartDate_nvc.Width = 115;
            // 
            // colEndDate_nvc
            // 
            this.colEndDate_nvc.DataPropertyName = "EndDate_nvc";
            this.colEndDate_nvc.HeaderText = "تا تاریخ";
            this.colEndDate_nvc.Name = "colEndDate_nvc";
            this.colEndDate_nvc.ReadOnly = true;
            this.colEndDate_nvc.Width = 116;
            // 
            // colVisited_bit
            // 
            this.colVisited_bit.DataPropertyName = "Visited_bit";
            this.colVisited_bit.HeaderText = "خوانده شده";
            this.colVisited_bit.Name = "colVisited_bit";
            this.colVisited_bit.ReadOnly = true;
            this.colVisited_bit.Visible = false;
            this.colVisited_bit.Width = 116;
            // 
            // colRecipientUserName_nvc
            // 
            this.colRecipientUserName_nvc.DataPropertyName = "RecipientUserName_nvcUserName_nvc";
            this.colRecipientUserName_nvc.HeaderText = "کاربر دریافت کننده";
            this.colRecipientUserName_nvc.Name = "colRecipientUserName_nvc";
            this.colRecipientUserName_nvc.ReadOnly = true;
            this.colRecipientUserName_nvc.Width = 150;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاريخ";
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
            // MessageToolStrip
            // 
            this.MessageToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MessageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.MessageToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MessageToolStrip.Name = "MessageToolStrip";
            this.MessageToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.MessageToolStrip.Size = new System.Drawing.Size(729, 31);
            this.MessageToolStrip.TabIndex = 1;
            // 
            // MessageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(729, 426);
            this.Controls.Add(this.MessageGridView);
            this.Controls.Add(this.MessageToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "MessageListForm";
            this.Text = "لیست پیام";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MessageListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessageGridView)).EndInit();
            this.MessageToolStrip.ResumeLayout(false);
            this.MessageToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip MessageToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView MessageGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageTitle_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colVisited_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecipientUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
    }

}