namespace HPS.Present.Good
    {
    partial class GoodListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.GoodGridView = new System.Windows.Forms.DataGridView();
            this.colGoodID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoodCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGood_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvtive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GoodToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.GoodGridView)).BeginInit();
            this.GoodToolStrip.SuspendLayout();
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
            // GoodGridView
            // 
            this.GoodGridView.AllowUserToAddRows = false;
            this.GoodGridView.AllowUserToDeleteRows = false;
            this.GoodGridView.AllowUserToResizeRows = false;
            this.GoodGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.GoodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGoodID_int,
            this.colGoodCode_nvc,
            this.colGood_nvc,
            this.colAvtive_bit});
            this.GoodGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoodGridView.Location = new System.Drawing.Point(0, 31);
            this.GoodGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GoodGridView.MultiSelect = false;
            this.GoodGridView.Name = "GoodGridView";
            this.GoodGridView.ReadOnly = true;
            this.GoodGridView.RowHeadersVisible = false;
            this.GoodGridView.Size = new System.Drawing.Size(697, 408);
            this.GoodGridView.TabIndex = 0;
            // 
            // colGoodID_int
            // 
            this.colGoodID_int.DataPropertyName = "GoodID_int";
            this.colGoodID_int.HeaderText = "شناسه کالا";
            this.colGoodID_int.Name = "colGoodID_int";
            this.colGoodID_int.ReadOnly = true;
            this.colGoodID_int.Visible = false;
            // 
            // colGoodCode_nvc
            // 
            this.colGoodCode_nvc.DataPropertyName = "GoodCode_nvc";
            this.colGoodCode_nvc.HeaderText = "کد کالا";
            this.colGoodCode_nvc.Name = "colGoodCode_nvc";
            this.colGoodCode_nvc.ReadOnly = true;
            this.colGoodCode_nvc.Width = 230;
            // 
            // colGood_nvc
            // 
            this.colGood_nvc.DataPropertyName = "Good_nvc";
            this.colGood_nvc.HeaderText = "نام کالا";
            this.colGood_nvc.Name = "colGood_nvc";
            this.colGood_nvc.ReadOnly = true;
            this.colGood_nvc.Width = 235;
            // 
            // colAvtive_bit
            // 
            this.colAvtive_bit.DataPropertyName = "Avtive_bit";
            this.colAvtive_bit.HeaderText = "فعال";
            this.colAvtive_bit.Name = "colAvtive_bit";
            this.colAvtive_bit.ReadOnly = true;
            this.colAvtive_bit.Width = 230;
            // 
            // GoodToolStrip
            // 
            this.GoodToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.GoodToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.GoodToolStrip.Location = new System.Drawing.Point(0, 0);
            this.GoodToolStrip.Name = "GoodToolStrip";
            this.GoodToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.GoodToolStrip.Size = new System.Drawing.Size(697, 31);
            this.GoodToolStrip.TabIndex = 1;
            // 
            // GoodListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(697, 439);
            this.Controls.Add(this.GoodGridView);
            this.Controls.Add(this.GoodToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "GoodListForm";
            this.Text = "لیست کالا";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GoodListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodGridView)).EndInit();
            this.GoodToolStrip.ResumeLayout(false);
            this.GoodToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip GoodToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView GoodGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGood_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAvtive_bit;
    }

}