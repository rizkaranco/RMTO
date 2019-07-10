namespace HPS.Present.SearchForm
{
    partial class CitySearch
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
            this.CityGridView = new System.Windows.Forms.DataGridView();
            this.CityToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colCityID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTravelTime_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CityGridView)).BeginInit();
            this.CityToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CityGridView
            // 
            this.CityGridView.AllowUserToAddRows = false;
            this.CityGridView.AllowUserToDeleteRows = false;
            this.CityGridView.AllowUserToResizeRows = false;
            this.CityGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CityGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCityID_int,
            this.colCityCode_nvc,
            this.colCity_nvc,
            this.colTravelTime_int,
            this.colActive_bit});
            this.CityGridView.Location = new System.Drawing.Point(0, 36);
            this.CityGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CityGridView.MultiSelect = false;
            this.CityGridView.Name = "CityGridView";
            this.CityGridView.ReadOnly = true;
            this.CityGridView.RowHeadersVisible = false;
            this.CityGridView.Size = new System.Drawing.Size(694, 377);
            this.CityGridView.TabIndex = 2;
            this.CityGridView.DoubleClick += new System.EventHandler(this.CityGridView_DoubleClick);
            this.CityGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityGridView_KeyDown);
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
            this.CityToolStrip.TabIndex = 3;
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
            // colCityID_int
            // 
            this.colCityID_int.DataPropertyName = "CityID_int";
            this.colCityID_int.HeaderText = "شناسه شهر";
            this.colCityID_int.Name = "colCityID_int";
            this.colCityID_int.ReadOnly = true;
            this.colCityID_int.Visible = false;
            // 
            // colCityCode_nvc
            // 
            this.colCityCode_nvc.DataPropertyName = "CityCode_nvc";
            this.colCityCode_nvc.HeaderText = "کد شهر";
            this.colCityCode_nvc.Name = "colCityCode_nvc";
            this.colCityCode_nvc.ReadOnly = true;
            this.colCityCode_nvc.Width = 220;
            // 
            // colCity_nvc
            // 
            this.colCity_nvc.DataPropertyName = "City_nvc";
            this.colCity_nvc.HeaderText = "نام شهر";
            this.colCity_nvc.Name = "colCity_nvc";
            this.colCity_nvc.ReadOnly = true;
            this.colCity_nvc.Width = 300;
            // 
            // colTravelTime_int
            // 
            this.colTravelTime_int.DataPropertyName = "TravelTime_int";
            this.colTravelTime_int.HeaderText = "مدت سفر";
            this.colTravelTime_int.Name = "colTravelTime_int";
            this.colTravelTime_int.ReadOnly = true;
            this.colTravelTime_int.Width = 174;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Visible = false;
            this.colActive_bit.Width = 174;
            // 
            // CitySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 412);
            this.Controls.Add(this.CityGridView);
            this.Controls.Add(this.CityToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CitySearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجوی شهر";
            this.Load += new System.EventHandler(this.CitySearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CityGridView)).EndInit();
            this.CityToolStrip.ResumeLayout(false);
            this.CityToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CityGridView;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStrip CityToolStrip;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTravelTime_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
    }
}