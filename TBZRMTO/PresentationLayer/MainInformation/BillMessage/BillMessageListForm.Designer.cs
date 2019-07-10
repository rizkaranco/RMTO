namespace HPS.Present.BillMessage
    {
    partial class BillMessageListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillMessageListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.BillMessageGridView = new System.Windows.Forms.DataGridView();
            this.BillMessageToolStrip = new System.Windows.Forms.ToolStrip();
            this.colBillMessageID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessage_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaloon_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BillMessageGridView)).BeginInit();
            this.BillMessageToolStrip.SuspendLayout();
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
            // BillMessageGridView
            // 
            this.BillMessageGridView.AllowUserToAddRows = false;
            this.BillMessageGridView.AllowUserToDeleteRows = false;
            this.BillMessageGridView.AllowUserToResizeRows = false;
            this.BillMessageGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.BillMessageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillMessageGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillMessageID_int,
            this.colBillID_int,
            this.colMessage_nvc,
            this.colStartDate_nvc,
            this.colEndDate_nvc,
            this.colUserName_nvc,
            this.colSaloon_nvc});
            this.BillMessageGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillMessageGridView.Location = new System.Drawing.Point(0, 31);
            this.BillMessageGridView.Margin = new System.Windows.Forms.Padding(5);
            this.BillMessageGridView.MultiSelect = false;
            this.BillMessageGridView.Name = "BillMessageGridView";
            this.BillMessageGridView.ReadOnly = true;
            this.BillMessageGridView.RowHeadersVisible = false;
            this.BillMessageGridView.Size = new System.Drawing.Size(878, 339);
            this.BillMessageGridView.TabIndex = 0;
            // 
            // BillMessageToolStrip
            // 
            this.BillMessageToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BillMessageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.BillMessageToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BillMessageToolStrip.Name = "BillMessageToolStrip";
            this.BillMessageToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BillMessageToolStrip.Size = new System.Drawing.Size(878, 31);
            this.BillMessageToolStrip.TabIndex = 1;
            // 
            // colBillMessageID_int
            // 
            this.colBillMessageID_int.DataPropertyName = "BillMessageID_int";
            this.colBillMessageID_int.HeaderText = "شناسه پیام قبض";
            this.colBillMessageID_int.Name = "colBillMessageID_int";
            this.colBillMessageID_int.ReadOnly = true;
            this.colBillMessageID_int.Visible = false;
            // 
            // colBillID_int
            // 
            this.colBillID_int.DataPropertyName = "BillID_intBillType_nvc";
            this.colBillID_int.HeaderText = "قبض";
            this.colBillID_int.Name = "colBillID_int";
            this.colBillID_int.ReadOnly = true;
            this.colBillID_int.Width = 144;
            // 
            // colMessage_nvc
            // 
            this.colMessage_nvc.DataPropertyName = "Message_nvc";
            this.colMessage_nvc.HeaderText = "پیام";
            this.colMessage_nvc.Name = "colMessage_nvc";
            this.colMessage_nvc.ReadOnly = true;
            this.colMessage_nvc.Width = 145;
            // 
            // colStartDate_nvc
            // 
            this.colStartDate_nvc.DataPropertyName = "StartDate_nvc";
            this.colStartDate_nvc.HeaderText = "از تاریخ";
            this.colStartDate_nvc.Name = "colStartDate_nvc";
            this.colStartDate_nvc.ReadOnly = true;
            this.colStartDate_nvc.Width = 130;
            // 
            // colEndDate_nvc
            // 
            this.colEndDate_nvc.DataPropertyName = "EndDate_nvc";
            this.colEndDate_nvc.HeaderText = "تا تاریخ";
            this.colEndDate_nvc.Name = "colEndDate_nvc";
            this.colEndDate_nvc.ReadOnly = true;
            this.colEndDate_nvc.Width = 130;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 147;
            // 
            // colSaloon_nvc
            // 
            this.colSaloon_nvc.DataPropertyName = "Saloon_nvc";
            this.colSaloon_nvc.HeaderText = "سالن اطلاع رسانی";
            this.colSaloon_nvc.Name = "colSaloon_nvc";
            this.colSaloon_nvc.ReadOnly = true;
            this.colSaloon_nvc.Width = 180;
            // 
            // BillMessageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(878, 370);
            this.Controls.Add(this.BillMessageGridView);
            this.Controls.Add(this.BillMessageToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "BillMessageListForm";
            this.Text = "لیست پیام قبض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillMessageListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillMessageGridView)).EndInit();
            this.BillMessageToolStrip.ResumeLayout(false);
            this.BillMessageToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip BillMessageToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView BillMessageGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillMessageID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessage_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaloon_nvc;
    }

}