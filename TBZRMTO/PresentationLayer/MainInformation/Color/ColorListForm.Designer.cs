namespace HPS.Present.Color
    {
    partial class ColorListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ColorGridView = new System.Windows.Forms.DataGridView();
            this.colColorID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColorCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridView)).BeginInit();
            this.ColorToolStrip.SuspendLayout();
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
            // ColorGridView
            // 
            this.ColorGridView.AllowUserToAddRows = false;
            this.ColorGridView.AllowUserToDeleteRows = false;
            this.ColorGridView.AllowUserToResizeRows = false;
            this.ColorGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ColorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColorID_int,
            this.colColor_nvc,
            this.colColorCode_nvc});
            this.ColorGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorGridView.Location = new System.Drawing.Point(0, 31);
            this.ColorGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ColorGridView.MultiSelect = false;
            this.ColorGridView.Name = "ColorGridView";
            this.ColorGridView.ReadOnly = true;
            this.ColorGridView.RowHeadersVisible = false;
            this.ColorGridView.Size = new System.Drawing.Size(699, 411);
            this.ColorGridView.TabIndex = 0;
            // 
            // colColorID_int
            // 
            this.colColorID_int.DataPropertyName = "ColorID_int";
            this.colColorID_int.HeaderText = "شناسه رنگ";
            this.colColorID_int.Name = "colColorID_int";
            this.colColorID_int.ReadOnly = true;
            this.colColorID_int.Visible = false;
            // 
            // colColor_nvc
            // 
            this.colColor_nvc.DataPropertyName = "Color_nvc";
            this.colColor_nvc.HeaderText = "رنگ";
            this.colColor_nvc.Name = "colColor_nvc";
            this.colColor_nvc.ReadOnly = true;
            this.colColor_nvc.Width = 400;
            // 
            // colColorCode_nvc
            // 
            this.colColorCode_nvc.DataPropertyName = "ColorCode_nvc";
            this.colColorCode_nvc.HeaderText = "کد رنگ";
            this.colColorCode_nvc.Name = "colColorCode_nvc";
            this.colColorCode_nvc.ReadOnly = true;
            this.colColorCode_nvc.Width = 300;
            // 
            // ColorToolStrip
            // 
            this.ColorToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ColorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.ColorToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ColorToolStrip.Name = "ColorToolStrip";
            this.ColorToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ColorToolStrip.Size = new System.Drawing.Size(699, 31);
            this.ColorToolStrip.TabIndex = 1;
            // 
            // ColorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(699, 442);
            this.Controls.Add(this.ColorGridView);
            this.Controls.Add(this.ColorToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "ColorListForm";
            this.Text = "لیست رنگ ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ColorListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorGridView)).EndInit();
            this.ColorToolStrip.ResumeLayout(false);
            this.ColorToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip ColorToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView ColorGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorCode_nvc;
    }

}