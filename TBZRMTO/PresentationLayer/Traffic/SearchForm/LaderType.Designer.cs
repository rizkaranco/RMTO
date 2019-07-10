namespace HPS.Present.SearchForm
{
    partial class LaderTypeSearch
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
            this.LaderTypeGridView = new System.Windows.Forms.DataGridView();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinTruckWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTruckWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSaloonID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderPivotGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).BeginInit();
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
            this.BoxingToolStrip.Size = new System.Drawing.Size(694, 31);
            this.BoxingToolStrip.TabIndex = 6;
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
            // LaderTypeGridView
            // 
            this.LaderTypeGridView.AllowUserToAddRows = false;
            this.LaderTypeGridView.AllowUserToDeleteRows = false;
            this.LaderTypeGridView.AllowUserToResizeRows = false;
            this.LaderTypeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LaderTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaderTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLaderTypeID_int,
            this.colLaderTypeCode_nvc,
            this.colLaderType_nvc,
            this.colMinTruckWeight_dec,
            this.colMaxTruckWeight_dec,
            this.colActive_bit,
            this.colSaloonID_int,
            this.colLaderPivotGroupID_int});
            this.LaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaderTypeGridView.Location = new System.Drawing.Point(0, 31);
            this.LaderTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeGridView.Name = "LaderTypeGridView";
            this.LaderTypeGridView.ReadOnly = true;
            this.LaderTypeGridView.RowHeadersVisible = false;
            this.LaderTypeGridView.Size = new System.Drawing.Size(694, 381);
            this.LaderTypeGridView.TabIndex = 7;
            this.LaderTypeGridView.DoubleClick += new System.EventHandler(this.LaderTypeGridView_DoubleClick);
            this.LaderTypeGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaderTypeGridView_KeyDown);
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه  نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colLaderTypeCode_nvc
            // 
            this.colLaderTypeCode_nvc.DataPropertyName = "LaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.HeaderText = "کد بارگیر";
            this.colLaderTypeCode_nvc.Name = "colLaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.ReadOnly = true;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نام بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 200;
            // 
            // colMinTruckWeight_dec
            // 
            this.colMinTruckWeight_dec.DataPropertyName = "MinTruckWeight_dec";
            this.colMinTruckWeight_dec.HeaderText = "حداقل وزن بارگیر";
            this.colMinTruckWeight_dec.Name = "colMinTruckWeight_dec";
            this.colMinTruckWeight_dec.ReadOnly = true;
            this.colMinTruckWeight_dec.Width = 150;
            // 
            // colMaxTruckWeight_dec
            // 
            this.colMaxTruckWeight_dec.DataPropertyName = "MaxTruckWeight_dec";
            this.colMaxTruckWeight_dec.HeaderText = "حداکثر وزن بارگیر";
            this.colMaxTruckWeight_dec.Name = "colMaxTruckWeight_dec";
            this.colMaxTruckWeight_dec.ReadOnly = true;
            this.colMaxTruckWeight_dec.Width = 150;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Visible = false;
            this.colActive_bit.Width = 90;
            // 
            // colSaloonID_int
            // 
            this.colSaloonID_int.DataPropertyName = "SaloonID_int";
            this.colSaloonID_int.HeaderText = "سالن اطلاع رسانی بار";
            this.colSaloonID_int.Name = "colSaloonID_int";
            this.colSaloonID_int.ReadOnly = true;
            this.colSaloonID_int.Visible = false;
            this.colSaloonID_int.Width = 135;
            // 
            // colLaderPivotGroupID_int
            // 
            this.colLaderPivotGroupID_int.DataPropertyName = "LaderPivotGroupID_intLaderPivotGroup_nvc";
            this.colLaderPivotGroupID_int.HeaderText = "تعداد محور";
            this.colLaderPivotGroupID_int.Name = "colLaderPivotGroupID_int";
            this.colLaderPivotGroupID_int.ReadOnly = true;
            // 
            // LaderTypeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 412);
            this.Controls.Add(this.LaderTypeGridView);
            this.Controls.Add(this.BoxingToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LaderTypeSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " جستجوی انواع بارگیر";
            this.Load += new System.EventHandler(this.LaderTypeSearch_Load);
            this.BoxingToolStrip.ResumeLayout(false);
            this.BoxingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BoxingToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView LaderTypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinTruckWeight_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTruckWeight_dec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaloonID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroupID_int;
    }
}