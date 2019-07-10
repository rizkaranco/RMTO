namespace HPS.Present.SearchForm
{
    partial class PlateCitySearch
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
            this.CityToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PlateCityGridView = new System.Windows.Forms.DataGridView();
            this.colPlateCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CityToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlateCityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CityToolStrip
            // 
            this.CityToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CityToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.CityToolStrip.Location = new System.Drawing.Point(0, 0);
            this.CityToolStrip.Name = "CityToolStrip";
            this.CityToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CityToolStrip.Size = new System.Drawing.Size(694, 31);
            this.CityToolStrip.TabIndex = 4;
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
            // PlateCityGridView
            // 
            this.PlateCityGridView.AllowUserToAddRows = false;
            this.PlateCityGridView.AllowUserToDeleteRows = false;
            this.PlateCityGridView.AllowUserToResizeRows = false;
            this.PlateCityGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.PlateCityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlateCityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlateCityID_int,
            this.colPlateCityCode_nvc,
            this.colPlateCity_nvc,
            this.colActive_bit});
            this.PlateCityGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlateCityGridView.Location = new System.Drawing.Point(0, 31);
            this.PlateCityGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PlateCityGridView.MultiSelect = false;
            this.PlateCityGridView.Name = "PlateCityGridView";
            this.PlateCityGridView.ReadOnly = true;
            this.PlateCityGridView.RowHeadersVisible = false;
            this.PlateCityGridView.Size = new System.Drawing.Size(694, 381);
            this.PlateCityGridView.TabIndex = 5;
            this.PlateCityGridView.DoubleClick += new System.EventHandler(this.PlateCityGridView_DoubleClick);
            this.PlateCityGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlateCityGridView_KeyDown);
            // 
            // colPlateCityID_int
            // 
            this.colPlateCityID_int.DataPropertyName = "PlateCityID_int";
            this.colPlateCityID_int.HeaderText = "شناسه محل شماره گذاری";
            this.colPlateCityID_int.Name = "colPlateCityID_int";
            this.colPlateCityID_int.ReadOnly = true;
            this.colPlateCityID_int.Visible = false;
            // 
            // colPlateCityCode_nvc
            // 
            this.colPlateCityCode_nvc.DataPropertyName = "PlateCityCode_nvc";
            this.colPlateCityCode_nvc.HeaderText = "کد شهر";
            this.colPlateCityCode_nvc.Name = "colPlateCityCode_nvc";
            this.colPlateCityCode_nvc.ReadOnly = true;
            this.colPlateCityCode_nvc.Width = 300;
            // 
            // colPlateCity_nvc
            // 
            this.colPlateCity_nvc.DataPropertyName = "PlateCity_nvc";
            this.colPlateCity_nvc.HeaderText = "نام شهر";
            this.colPlateCity_nvc.Name = "colPlateCity_nvc";
            this.colPlateCity_nvc.ReadOnly = true;
            this.colPlateCity_nvc.Width = 400;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Visible = false;
            this.colActive_bit.Width = 205;
            // 
            // PlateCitySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 412);
            this.Controls.Add(this.PlateCityGridView);
            this.Controls.Add(this.CityToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "PlateCitySearch";
            this.Text = "جستجوی شهرهای شماره گذاری";
            this.Load += new System.EventHandler(this.PlateCitySearch_Load);
            this.CityToolStrip.ResumeLayout(false);
            this.CityToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlateCityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip CityToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView PlateCityGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCity_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }
}