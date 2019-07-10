namespace HPS.Present.DestinationAddress
    {
    partial class DestinationAddressListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestinationAddressListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.DestinationAddressGridView = new System.Windows.Forms.DataGridView();
            this.DestinationAddressToolStrip = new System.Windows.Forms.ToolStrip();
            this.colDestinationAddressID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestinationAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationAddressGridView)).BeginInit();
            this.DestinationAddressToolStrip.SuspendLayout();
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
            // DestinationAddressGridView
            // 
            this.DestinationAddressGridView.AllowUserToAddRows = false;
            this.DestinationAddressGridView.AllowUserToDeleteRows = false;
            this.DestinationAddressGridView.AllowUserToResizeRows = false;
            this.DestinationAddressGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.DestinationAddressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationAddressGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDestinationAddressID_int,
            this.colDestinationAddress_nvc});
            this.DestinationAddressGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DestinationAddressGridView.Location = new System.Drawing.Point(0, 31);
            this.DestinationAddressGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DestinationAddressGridView.MultiSelect = false;
            this.DestinationAddressGridView.Name = "DestinationAddressGridView";
            this.DestinationAddressGridView.ReadOnly = true;
            this.DestinationAddressGridView.RowHeadersVisible = false;
            this.DestinationAddressGridView.Size = new System.Drawing.Size(700, 409);
            this.DestinationAddressGridView.TabIndex = 0;
            // 
            // DestinationAddressToolStrip
            // 
            this.DestinationAddressToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.DestinationAddressToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.DestinationAddressToolStrip.Location = new System.Drawing.Point(0, 0);
            this.DestinationAddressToolStrip.Name = "DestinationAddressToolStrip";
            this.DestinationAddressToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.DestinationAddressToolStrip.Size = new System.Drawing.Size(700, 31);
            this.DestinationAddressToolStrip.TabIndex = 1;
            // 
            // colDestinationAddressID_int
            // 
            this.colDestinationAddressID_int.DataPropertyName = "DestinationAddressID_int";
            this.colDestinationAddressID_int.HeaderText = "شناسه آدرس مقصد";
            this.colDestinationAddressID_int.Name = "colDestinationAddressID_int";
            this.colDestinationAddressID_int.ReadOnly = true;
            this.colDestinationAddressID_int.Visible = false;
            // 
            // colDestinationAddress_nvc
            // 
            this.colDestinationAddress_nvc.DataPropertyName = "DestinationAddress_nvc";
            this.colDestinationAddress_nvc.HeaderText = "آدرس مقصد";
            this.colDestinationAddress_nvc.Name = "colDestinationAddress_nvc";
            this.colDestinationAddress_nvc.ReadOnly = true;
            this.colDestinationAddress_nvc.Width = 700;
            // 
            // DestinationAddressListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.DestinationAddressGridView);
            this.Controls.Add(this.DestinationAddressToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "DestinationAddressListForm";
            this.Text = "لیست آدرس مقصد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DestinationAddressListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationAddressGridView)).EndInit();
            this.DestinationAddressToolStrip.ResumeLayout(false);
            this.DestinationAddressToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip DestinationAddressToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView DestinationAddressGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinationAddressID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinationAddress_nvc;
    }

}