namespace HPS.Present.LaderType
    {
    partial class LaderTypeListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaderTypeListForm));
            this.LaderTypeGridView = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.LaderTypeToolStrip = new System.Windows.Forms.ToolStrip();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTruckWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinTruckWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTurnCancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSaloonID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderPivotGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).BeginInit();
            this.LaderTypeToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.colMaxTruckWeight_dec,
            this.colMinTruckWeight_dec,
            this.colActive_bit,
            this.colTurnCancel,
            this.colSaloonID_int,
            this.colLaderPivotGroupID_int});
            this.LaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaderTypeGridView.Location = new System.Drawing.Point(0, 31);
            this.LaderTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeGridView.MultiSelect = false;
            this.LaderTypeGridView.Name = "LaderTypeGridView";
            this.LaderTypeGridView.ReadOnly = true;
            this.LaderTypeGridView.RowHeadersVisible = false;
            this.LaderTypeGridView.Size = new System.Drawing.Size(913, 429);
            this.LaderTypeGridView.TabIndex = 0;
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
            // LaderTypeToolStrip
            // 
            this.LaderTypeToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LaderTypeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.LaderTypeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LaderTypeToolStrip.Name = "LaderTypeToolStrip";
            this.LaderTypeToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LaderTypeToolStrip.Size = new System.Drawing.Size(913, 31);
            this.LaderTypeToolStrip.TabIndex = 1;
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
            this.colLaderTypeCode_nvc.FillWeight = 0.6084248F;
            this.colLaderTypeCode_nvc.HeaderText = "کد بارگیر";
            this.colLaderTypeCode_nvc.Name = "colLaderTypeCode_nvc";
            this.colLaderTypeCode_nvc.ReadOnly = true;
            this.colLaderTypeCode_nvc.Width = 120;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderType_nvc";
            this.colLaderType_nvc.FillWeight = 523.8578F;
            this.colLaderType_nvc.HeaderText = "نام بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 180;
            // 
            // colMaxTruckWeight_dec
            // 
            this.colMaxTruckWeight_dec.DataPropertyName = "MaxTruckWeight_dec";
            this.colMaxTruckWeight_dec.FillWeight = 14.40569F;
            this.colMaxTruckWeight_dec.HeaderText = "حداکثر وزن بارگیر";
            this.colMaxTruckWeight_dec.Name = "colMaxTruckWeight_dec";
            this.colMaxTruckWeight_dec.ReadOnly = true;
            this.colMaxTruckWeight_dec.Width = 150;
            // 
            // colMinTruckWeight_dec
            // 
            this.colMinTruckWeight_dec.DataPropertyName = "MinTruckWeight_dec";
            this.colMinTruckWeight_dec.FillWeight = 58.43952F;
            this.colMinTruckWeight_dec.HeaderText = "حداقل وزن بارگیر";
            this.colMinTruckWeight_dec.Name = "colMinTruckWeight_dec";
            this.colMinTruckWeight_dec.ReadOnly = true;
            this.colMinTruckWeight_dec.Width = 150;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.FillWeight = 2.080085F;
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 90;
            // 
            // colTurnCancel
            // 
            this.colTurnCancel.DataPropertyName = "TurnCancel_bit";
            this.colTurnCancel.HeaderText = "ابطال نوبت";
            this.colTurnCancel.Name = "colTurnCancel";
            this.colTurnCancel.ReadOnly = true;
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
            this.colLaderPivotGroupID_int.FillWeight = 0.6084248F;
            this.colLaderPivotGroupID_int.HeaderText = "گروه محور";
            this.colLaderPivotGroupID_int.Name = "colLaderPivotGroupID_int";
            this.colLaderPivotGroupID_int.ReadOnly = true;
            this.colLaderPivotGroupID_int.Width = 120;
            // 
            // LaderTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(913, 460);
            this.Controls.Add(this.LaderTypeGridView);
            this.Controls.Add(this.LaderTypeToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LaderTypeListForm";
            this.Text = "لیست انواع بارگیر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LaderTypeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).EndInit();
            this.LaderTypeToolStrip.ResumeLayout(false);
            this.LaderTypeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip LaderTypeToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView LaderTypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTruckWeight_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinTruckWeight_dec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTurnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaloonID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroupID_int;
    }

}