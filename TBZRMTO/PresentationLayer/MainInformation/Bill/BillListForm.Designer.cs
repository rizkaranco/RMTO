namespace HPS.Present.Bill
    {
    partial class BillListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.colBillID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.BillToolStrip.SuspendLayout();
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
            // BillGridView
            // 
            this.BillGridView.AllowUserToAddRows = false;
            this.BillGridView.AllowUserToDeleteRows = false;
            this.BillGridView.AllowUserToResizeRows = false;
            this.BillGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBillID_int,
            this.colBillType_nvc,
            this.colTrafficTypeID_int});
            this.BillGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillGridView.Location = new System.Drawing.Point(0, 31);
            this.BillGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BillGridView.MultiSelect = false;
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.ReadOnly = true;
            this.BillGridView.RowHeadersVisible = false;
            this.BillGridView.Size = new System.Drawing.Size(700, 409);
            this.BillGridView.TabIndex = 0;
            // 
            // colBillID_int
            // 
            this.colBillID_int.DataPropertyName = "BillID_int";
            this.colBillID_int.HeaderText = "شناسه قبض";
            this.colBillID_int.Name = "colBillID_int";
            this.colBillID_int.ReadOnly = true;
            this.colBillID_int.Visible = false;
            // 
            // colBillType_nvc
            // 
            this.colBillType_nvc.DataPropertyName = "BillType_nvc";
            this.colBillType_nvc.HeaderText = "نوع قبض";
            this.colBillType_nvc.Name = "colBillType_nvc";
            this.colBillType_nvc.ReadOnly = true;
            this.colBillType_nvc.Width = 450;
            // 
            // colTrafficTypeID_int
            // 
            this.colTrafficTypeID_int.DataPropertyName = "TrafficTypeID_intTrafficType_nvc";
            this.colTrafficTypeID_int.HeaderText = "نوع تردد";
            this.colTrafficTypeID_int.Name = "colTrafficTypeID_int";
            this.colTrafficTypeID_int.ReadOnly = true;
            this.colTrafficTypeID_int.Width = 250;
            // 
            // BillToolStrip
            // 
            this.BillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.BillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BillToolStrip.Name = "BillToolStrip";
            this.BillToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BillToolStrip.Size = new System.Drawing.Size(700, 31);
            this.BillToolStrip.TabIndex = 1;
            // 
            // BillListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.BillToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "BillListForm";
            this.Text = "لیست قبض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.BillToolStrip.ResumeLayout(false);
            this.BillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip BillToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficTypeID_int;
    }

}