namespace HPS.Present.SearchForm
{
    partial class GoodSearch
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
            this.GoodGridView = new System.Windows.Forms.DataGridView();
            this.colGoodID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoodCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGood_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvtive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GoodToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GoodGridView)).BeginInit();
            this.GoodToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.GoodGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GoodGridView.Location = new System.Drawing.Point(0, 34);
            this.GoodGridView.Margin = new System.Windows.Forms.Padding(5);
            this.GoodGridView.MultiSelect = false;
            this.GoodGridView.Name = "GoodGridView";
            this.GoodGridView.ReadOnly = true;
            this.GoodGridView.RowHeadersVisible = false;
            this.GoodGridView.Size = new System.Drawing.Size(695, 378);
            this.GoodGridView.TabIndex = 2;
            this.GoodGridView.DoubleClick += new System.EventHandler(this.GoodGridView_DoubleClick);
            this.GoodGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoodGridView_KeyDown);
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
            this.colGoodCode_nvc.Width = 300;
            // 
            // colGood_nvc
            // 
            this.colGood_nvc.DataPropertyName = "Good_nvc";
            this.colGood_nvc.HeaderText = "نام کالا";
            this.colGood_nvc.Name = "colGood_nvc";
            this.colGood_nvc.ReadOnly = true;
            this.colGood_nvc.Width = 400;
            // 
            // colAvtive_bit
            // 
            this.colAvtive_bit.DataPropertyName = "Avtive_bit";
            this.colAvtive_bit.HeaderText = "فعال";
            this.colAvtive_bit.Name = "colAvtive_bit";
            this.colAvtive_bit.ReadOnly = true;
            this.colAvtive_bit.Visible = false;
            this.colAvtive_bit.Width = 230;
            // 
            // GoodToolStrip
            // 
            this.GoodToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.GoodToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.GoodToolStrip.Location = new System.Drawing.Point(0, 0);
            this.GoodToolStrip.Name = "GoodToolStrip";
            this.GoodToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.GoodToolStrip.Size = new System.Drawing.Size(695, 31);
            this.GoodToolStrip.TabIndex = 4;
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
            // GoodSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 412);
            this.Controls.Add(this.GoodToolStrip);
            this.Controls.Add(this.GoodGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "GoodSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی کالا";
            this.Load += new System.EventHandler(this.GoodSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoodGridView)).EndInit();
            this.GoodToolStrip.ResumeLayout(false);
            this.GoodToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GoodGridView;
        private System.Windows.Forms.ToolStrip GoodToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGood_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAvtive_bit;
    }
}