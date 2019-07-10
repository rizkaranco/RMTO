namespace HPS.Present.AnnouncementTime
    {
    partial class AnnouncementTimeListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnouncementTimeListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.AnnouncementTimeGridView = new System.Windows.Forms.DataGridView();
            this.colAnnouncementTimeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnnouncementTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnouncementTimeToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.AnnouncementTimeGridView)).BeginInit();
            this.AnnouncementTimeToolStrip.SuspendLayout();
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
            // AnnouncementTimeGridView
            // 
            this.AnnouncementTimeGridView.AllowUserToAddRows = false;
            this.AnnouncementTimeGridView.AllowUserToDeleteRows = false;
            this.AnnouncementTimeGridView.AllowUserToResizeRows = false;
            this.AnnouncementTimeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.AnnouncementTimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnnouncementTimeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnnouncementTimeID_int,
            this.colAnnouncementTime_nvc,
            this.colStartTime_nvc,
            this.colEndTime_nvc});
            this.AnnouncementTimeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnouncementTimeGridView.Location = new System.Drawing.Point(0, 31);
            this.AnnouncementTimeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.AnnouncementTimeGridView.MultiSelect = false;
            this.AnnouncementTimeGridView.Name = "AnnouncementTimeGridView";
            this.AnnouncementTimeGridView.ReadOnly = true;
            this.AnnouncementTimeGridView.RowHeadersVisible = false;
            this.AnnouncementTimeGridView.Size = new System.Drawing.Size(699, 402);
            this.AnnouncementTimeGridView.TabIndex = 0;
            // 
            // colAnnouncementTimeID_int
            // 
            this.colAnnouncementTimeID_int.DataPropertyName = "AnnouncementTimeID_int";
            this.colAnnouncementTimeID_int.HeaderText = "شناسه اطلاع رسانی بار";
            this.colAnnouncementTimeID_int.Name = "colAnnouncementTimeID_int";
            this.colAnnouncementTimeID_int.ReadOnly = true;
            this.colAnnouncementTimeID_int.Visible = false;
            // 
            // colAnnouncementTime_nvc
            // 
            this.colAnnouncementTime_nvc.DataPropertyName = "AnnouncementTime_nvc";
            this.colAnnouncementTime_nvc.HeaderText = "اطلاع رسانی بار";
            this.colAnnouncementTime_nvc.Name = "colAnnouncementTime_nvc";
            this.colAnnouncementTime_nvc.ReadOnly = true;
            this.colAnnouncementTime_nvc.Width = 232;
            // 
            // colStartTime_nvc
            // 
            this.colStartTime_nvc.DataPropertyName = "StartTime_nvc";
            this.colStartTime_nvc.HeaderText = "زمان شروع";
            this.colStartTime_nvc.Name = "colStartTime_nvc";
            this.colStartTime_nvc.ReadOnly = true;
            this.colStartTime_nvc.Width = 233;
            // 
            // colEndTime_nvc
            // 
            this.colEndTime_nvc.DataPropertyName = "EndTime_nvc";
            this.colEndTime_nvc.HeaderText = "زمان اتمام";
            this.colEndTime_nvc.Name = "colEndTime_nvc";
            this.colEndTime_nvc.ReadOnly = true;
            this.colEndTime_nvc.Width = 232;
            // 
            // AnnouncementTimeToolStrip
            // 
            this.AnnouncementTimeToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AnnouncementTimeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.AnnouncementTimeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AnnouncementTimeToolStrip.Name = "AnnouncementTimeToolStrip";
            this.AnnouncementTimeToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AnnouncementTimeToolStrip.Size = new System.Drawing.Size(699, 31);
            this.AnnouncementTimeToolStrip.TabIndex = 1;
            // 
            // AnnouncementTimeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(699, 433);
            this.Controls.Add(this.AnnouncementTimeGridView);
            this.Controls.Add(this.AnnouncementTimeToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "AnnouncementTimeListForm";
            this.Text = "لیست زمانهای اطلاع رسانی بار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnnouncementTimeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnnouncementTimeGridView)).EndInit();
            this.AnnouncementTimeToolStrip.ResumeLayout(false);
            this.AnnouncementTimeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip AnnouncementTimeToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView AnnouncementTimeGridView;
        
private System.Windows.Forms.DataGridViewTextBoxColumn colAnnouncementTimeID_int;
private System.Windows.Forms.DataGridViewTextBoxColumn colAnnouncementTime_nvc;
private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime_nvc;
private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime_nvc;
    }

}