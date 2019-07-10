namespace HPS.Present.SearchForm
{
    partial class BoxingSearch
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
            this.BoxingToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BoxingGridView = new System.Windows.Forms.DataGridView();
            this.colBoxingID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoxingCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoxingType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BoxingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxingToolStrip
            // 
            this.BoxingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BoxingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.BoxingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BoxingToolStrip.Name = "BoxingToolStrip";
            this.BoxingToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BoxingToolStrip.Size = new System.Drawing.Size(697, 31);
            this.BoxingToolStrip.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = global::HPS.Properties.Resources.Check;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 28);
            this.SearchButton.Text = "جديد";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClosetoolStripButton
            // 
            this.ClosetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClosetoolStripButton.Image = global::HPS.Properties.Resources.Close;
            this.ClosetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClosetoolStripButton.Name = "ClosetoolStripButton";
            this.ClosetoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ClosetoolStripButton.Text = "بستن";
            this.ClosetoolStripButton.Click += new System.EventHandler(this.ClosetoolStripButton_Click);
            // 
            // BoxingGridView
            // 
            this.BoxingGridView.AllowUserToAddRows = false;
            this.BoxingGridView.AllowUserToDeleteRows = false;
            this.BoxingGridView.AllowUserToResizeRows = false;
            this.BoxingGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.BoxingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoxingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBoxingID_int,
            this.colBoxingCode_nvc,
            this.colBoxingType_nvc,
            this.colActive_bit});
            this.BoxingGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxingGridView.Location = new System.Drawing.Point(0, 31);
            this.BoxingGridView.Margin = new System.Windows.Forms.Padding(5);
            this.BoxingGridView.MultiSelect = false;
            this.BoxingGridView.Name = "BoxingGridView";
            this.BoxingGridView.ReadOnly = true;
            this.BoxingGridView.RowHeadersVisible = false;
            this.BoxingGridView.Size = new System.Drawing.Size(697, 385);
            this.BoxingGridView.TabIndex = 6;
            this.BoxingGridView.DoubleClick += new System.EventHandler(this.BoxingGridView_DoubleClick);
            this.BoxingGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BoxingGridView_KeyDown);
            // 
            // colBoxingID_int
            // 
            this.colBoxingID_int.DataPropertyName = "BoxingID_int";
            this.colBoxingID_int.HeaderText = "شناسه دسته بندی";
            this.colBoxingID_int.Name = "colBoxingID_int";
            this.colBoxingID_int.ReadOnly = true;
            this.colBoxingID_int.Visible = false;
            // 
            // colBoxingCode_nvc
            // 
            this.colBoxingCode_nvc.DataPropertyName = "BoxingCode_nvc";
            this.colBoxingCode_nvc.HeaderText = "کد بسته بندی";
            this.colBoxingCode_nvc.Name = "colBoxingCode_nvc";
            this.colBoxingCode_nvc.ReadOnly = true;
            this.colBoxingCode_nvc.Width = 250;
            // 
            // colBoxingType_nvc
            // 
            this.colBoxingType_nvc.DataPropertyName = "BoxingType_nvc";
            this.colBoxingType_nvc.HeaderText = " نوع بسته بندی";
            this.colBoxingType_nvc.Name = "colBoxingType_nvc";
            this.colBoxingType_nvc.ReadOnly = true;
            this.colBoxingType_nvc.Width = 250;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 195;
            // 
            // BoxingSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 416);
            this.Controls.Add(this.BoxingGridView);
            this.Controls.Add(this.BoxingToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "BoxingSearch";
            this.Text = "جستجوی بسته بندی";
            this.Load += new System.EventHandler(this.BoxingSearch_Load);
            this.BoxingToolStrip.ResumeLayout(false);
            this.BoxingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BoxingToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView BoxingGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingType_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }
}