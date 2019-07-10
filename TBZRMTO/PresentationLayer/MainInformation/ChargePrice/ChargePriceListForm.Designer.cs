namespace HPS.Present.ChargePrice
    {
    partial class ChargePriceListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargePriceListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ChargePriceGridView = new System.Windows.Forms.DataGridView();
            this.ChargePriceToolStrip = new System.Windows.Forms.ToolStrip();
            this.colChargePriceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChargePriceGridView)).BeginInit();
            this.ChargePriceToolStrip.SuspendLayout();
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
            // ChargePriceGridView
            // 
            this.ChargePriceGridView.AllowUserToAddRows = false;
            this.ChargePriceGridView.AllowUserToDeleteRows = false;
            this.ChargePriceGridView.AllowUserToResizeRows = false;
            this.ChargePriceGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ChargePriceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChargePriceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChargePriceID_int,
            this.colDriverID_bint,
            this.colDriverName_nvc,
            this.colDriverCardNumber_nvc,
            this.colPrice_dec,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colUserName_nvc,
            this.colDescription_nvc});
            this.ChargePriceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChargePriceGridView.Location = new System.Drawing.Point(0, 31);
            this.ChargePriceGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ChargePriceGridView.MultiSelect = false;
            this.ChargePriceGridView.Name = "ChargePriceGridView";
            this.ChargePriceGridView.ReadOnly = true;
            this.ChargePriceGridView.RowHeadersVisible = false;
            this.ChargePriceGridView.Size = new System.Drawing.Size(748, 440);
            this.ChargePriceGridView.TabIndex = 0;
            // 
            // ChargePriceToolStrip
            // 
            this.ChargePriceToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ChargePriceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.ChargePriceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ChargePriceToolStrip.Name = "ChargePriceToolStrip";
            this.ChargePriceToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ChargePriceToolStrip.Size = new System.Drawing.Size(748, 31);
            this.ChargePriceToolStrip.TabIndex = 1;
            // 
            // colChargePriceID_int
            // 
            this.colChargePriceID_int.DataPropertyName = "ChargePriceID_int";
            this.colChargePriceID_int.HeaderText = "شارژ مالی";
            this.colChargePriceID_int.Name = "colChargePriceID_int";
            this.colChargePriceID_int.ReadOnly = true;
            this.colChargePriceID_int.Visible = false;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.DataPropertyName = "DriverID_bintFirstName_nvc";
            this.colDriverID_bint.HeaderText = "راننده";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.ReadOnly = true;
            this.colDriverID_bint.Width = 86;
            // 
            // colDriverName_nvc
            // 
            this.colDriverName_nvc.DataPropertyName = "DriverName_nvc";
            this.colDriverName_nvc.HeaderText = "نام راننده";
            this.colDriverName_nvc.Name = "colDriverName_nvc";
            this.colDriverName_nvc.ReadOnly = true;
            this.colDriverName_nvc.Width = 90;
            // 
            // colDriverCardNumber_nvc
            // 
            this.colDriverCardNumber_nvc.DataPropertyName = "DriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.HeaderText = "شماره کارت راننده";
            this.colDriverCardNumber_nvc.Name = "colDriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.ReadOnly = true;
            this.colDriverCardNumber_nvc.Width = 150;
            // 
            // colPrice_dec
            // 
            this.colPrice_dec.DataPropertyName = "Price_dec";
            this.colPrice_dec.HeaderText = "مبلغ شارژ";
            this.colPrice_dec.Name = "colPrice_dec";
            this.colPrice_dec.ReadOnly = true;
            this.colPrice_dec.Width = 95;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 80;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 80;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 75;
            // 
            // colDescription_nvc
            // 
            this.colDescription_nvc.DataPropertyName = "Description_nvc";
            this.colDescription_nvc.HeaderText = "توضیحات";
            this.colDescription_nvc.Name = "colDescription_nvc";
            this.colDescription_nvc.ReadOnly = true;
            this.colDescription_nvc.Width = 90;
            // 
            // ChargePriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(748, 471);
            this.Controls.Add(this.ChargePriceGridView);
            this.Controls.Add(this.ChargePriceToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "ChargePriceListForm";
            this.Text = "لیست شارژ مالی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChargePriceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChargePriceGridView)).EndInit();
            this.ChargePriceToolStrip.ResumeLayout(false);
            this.ChargePriceToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip ChargePriceToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView ChargePriceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargePriceID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription_nvc;
    }

}