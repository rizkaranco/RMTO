namespace HPS.Present.InfractionGroup
    {
    partial class InfractionGroupListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionGroupListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.InfractionGroupGridView = new System.Windows.Forms.DataGridView();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionGroup_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InfractionGroupToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.InfractionGroupGridView)).BeginInit();
            this.InfractionGroupToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.Tag = "جديد";
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
            this.EditButton.Tag = "ويرايش";
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
            this.ExportButton.Tag = "انتقال به اکسل";
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // InfractionGroupGridView
            // 
            this.InfractionGroupGridView.AllowUserToAddRows = false;
            this.InfractionGroupGridView.AllowUserToDeleteRows = false;
            this.InfractionGroupGridView.AllowUserToResizeRows = false;
            this.InfractionGroupGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.InfractionGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfractionGroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfractionGroupID_int,
            this.colInfractionGroup_nvc,
            this.colActive_bit});
            this.InfractionGroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfractionGroupGridView.Location = new System.Drawing.Point(0, 31);
            this.InfractionGroupGridView.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupGridView.MultiSelect = false;
            this.InfractionGroupGridView.Name = "InfractionGroupGridView";
            this.InfractionGroupGridView.ReadOnly = true;
            this.InfractionGroupGridView.RowHeadersVisible = false;
            this.InfractionGroupGridView.Size = new System.Drawing.Size(700, 409);
            this.InfractionGroupGridView.TabIndex = 0;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_int";
            this.colInfractionGroupID_int.HeaderText = "شناسه گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            this.colInfractionGroupID_int.Visible = false;
            // 
            // colInfractionGroup_nvc
            // 
            this.colInfractionGroup_nvc.DataPropertyName = "InfractionGroup_nvc";
            this.colInfractionGroup_nvc.HeaderText = "عنوان گروه تخلف";
            this.colInfractionGroup_nvc.Name = "colInfractionGroup_nvc";
            this.colInfractionGroup_nvc.ReadOnly = true;
            this.colInfractionGroup_nvc.Width = 355;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 348;
            // 
            // InfractionGroupToolStrip
            // 
            this.InfractionGroupToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InfractionGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.InfractionGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InfractionGroupToolStrip.Name = "InfractionGroupToolStrip";
            this.InfractionGroupToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InfractionGroupToolStrip.Size = new System.Drawing.Size(700, 31);
            this.InfractionGroupToolStrip.TabIndex = 1;
            // 
            // InfractionGroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.InfractionGroupGridView);
            this.Controls.Add(this.InfractionGroupToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "InfractionGroupListForm";
            this.Text = "لیست گروه تخلف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfractionGroupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfractionGroupGridView)).EndInit();
            this.InfractionGroupToolStrip.ResumeLayout(false);
            this.InfractionGroupToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip InfractionGroupToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView InfractionGroupGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroup_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }

}