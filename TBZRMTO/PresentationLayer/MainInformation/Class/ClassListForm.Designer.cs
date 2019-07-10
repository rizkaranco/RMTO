namespace HPS.Present.Class
    {
    partial class ClassListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ClassGridView = new System.Windows.Forms.DataGridView();
            this.ClassToolStrip = new System.Windows.Forms.ToolStrip();
            this.colClassID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClassGridView)).BeginInit();
            this.ClassToolStrip.SuspendLayout();
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
            this.EditButton.Size = new System.Drawing.Size(23, 22);
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
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
            // ClassGridView
            // 
            this.ClassGridView.AllowUserToAddRows = false;
            this.ClassGridView.AllowUserToDeleteRows = false;
            this.ClassGridView.AllowUserToResizeRows = false;
            this.ClassGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClassGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClassID_int,
            this.colClassName_nvc});
            this.ClassGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassGridView.Location = new System.Drawing.Point(0, 31);
            this.ClassGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ClassGridView.MultiSelect = false;
            this.ClassGridView.Name = "ClassGridView";
            this.ClassGridView.ReadOnly = true;
            this.ClassGridView.RowHeadersVisible = false;
            this.ClassGridView.Size = new System.Drawing.Size(703, 409);
            this.ClassGridView.TabIndex = 0;
            // 
            // ClassToolStrip
            // 
            this.ClassToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ClassToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.ClassToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ClassToolStrip.Name = "ClassToolStrip";
            this.ClassToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ClassToolStrip.Size = new System.Drawing.Size(703, 31);
            this.ClassToolStrip.TabIndex = 1;
            // 
            // colClassID_int
            // 
            this.colClassID_int.DataPropertyName = "ClassID_int";
            this.colClassID_int.HeaderText = "شناسه كلاس";
            this.colClassID_int.Name = "colClassID_int";
            this.colClassID_int.ReadOnly = true;
            this.colClassID_int.Visible = false;
            // 
            // colClassName_nvc
            // 
            this.colClassName_nvc.DataPropertyName = "ClassName_nvc";
            this.colClassName_nvc.HeaderText = "نام كلاس";
            this.colClassName_nvc.Name = "colClassName_nvc";
            this.colClassName_nvc.ReadOnly = true;
            this.colClassName_nvc.Width = 700;
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(703, 440);
            this.Controls.Add(this.ClassGridView);
            this.Controls.Add(this.ClassToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "ClassListForm";
            this.Text = "لیست کلاس های آموزشی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClassListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassGridView)).EndInit();
            this.ClassToolStrip.ResumeLayout(false);
            this.ClassToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip ClassToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView ClassGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName_nvc;
    }

}