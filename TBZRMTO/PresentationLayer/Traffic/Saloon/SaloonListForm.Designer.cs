namespace HPS.Present.Saloon
    {
    partial class SaloonListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaloonListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.SaloonGridView = new System.Windows.Forms.DataGridView();
            this.colSaloonID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaloon_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnDistinictAfterCredit_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumberInLadeAnnouncement_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaloonToolStrip = new System.Windows.Forms.ToolStrip();
            this.LaderTypeGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinTruckWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTruckWeight_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderPivotGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SaloonGridView)).BeginInit();
            this.SaloonToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // SaloonGridView
            // 
            this.SaloonGridView.AllowUserToAddRows = false;
            this.SaloonGridView.AllowUserToDeleteRows = false;
            this.SaloonGridView.AllowUserToResizeRows = false;
            this.SaloonGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.SaloonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaloonGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaloonID_int,
            this.colSaloon_nvc,
            this.colTurnDistinictAfterCredit_int,
            this.colTurnNumberInLadeAnnouncement_int});
            this.SaloonGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaloonGridView.Location = new System.Drawing.Point(0, 0);
            this.SaloonGridView.Margin = new System.Windows.Forms.Padding(0);
            this.SaloonGridView.MultiSelect = false;
            this.SaloonGridView.Name = "SaloonGridView";
            this.SaloonGridView.ReadOnly = true;
            this.SaloonGridView.RowHeadersVisible = false;
            this.SaloonGridView.Size = new System.Drawing.Size(561, 413);
            this.SaloonGridView.TabIndex = 0;
            // 
            // colSaloonID_int
            // 
            this.colSaloonID_int.DataPropertyName = "SaloonID_int";
            this.colSaloonID_int.HeaderText = "شناسه سالن اعلان بار";
            this.colSaloonID_int.Name = "colSaloonID_int";
            this.colSaloonID_int.ReadOnly = true;
            this.colSaloonID_int.Visible = false;
            // 
            // colSaloon_nvc
            // 
            this.colSaloon_nvc.DataPropertyName = "Saloon_nvc";
            this.colSaloon_nvc.FillWeight = 6.902962F;
            this.colSaloon_nvc.HeaderText = "نام سالن";
            this.colSaloon_nvc.Name = "colSaloon_nvc";
            this.colSaloon_nvc.ReadOnly = true;
            this.colSaloon_nvc.Width = 180;
            // 
            // colTurnDistinictAfterCredit_int
            // 
            this.colTurnDistinictAfterCredit_int.DataPropertyName = "TurnDistinictAfterCredit_int";
            this.colTurnDistinictAfterCredit_int.FillWeight = 8.409369F;
            this.colTurnDistinictAfterCredit_int.HeaderText = "فاصله بین نوبتهابعداز اعتبار ";
            this.colTurnDistinictAfterCredit_int.Name = "colTurnDistinictAfterCredit_int";
            this.colTurnDistinictAfterCredit_int.ReadOnly = true;
            this.colTurnDistinictAfterCredit_int.Width = 180;
            // 
            // colTurnNumberInLadeAnnouncement_int
            // 
            this.colTurnNumberInLadeAnnouncement_int.DataPropertyName = "TurnNumberInLadeAnnouncement_int";
            this.colTurnNumberInLadeAnnouncement_int.FillWeight = 15.78591F;
            this.colTurnNumberInLadeAnnouncement_int.HeaderText = "تعدادمجاز نوبت در هر اعلان بار";
            this.colTurnNumberInLadeAnnouncement_int.Name = "colTurnNumberInLadeAnnouncement_int";
            this.colTurnNumberInLadeAnnouncement_int.ReadOnly = true;
            this.colTurnNumberInLadeAnnouncement_int.Width = 200;
            // 
            // SaloonToolStrip
            // 
            this.SaloonToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SaloonToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.SaloonToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SaloonToolStrip.Name = "SaloonToolStrip";
            this.SaloonToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.SaloonToolStrip.Size = new System.Drawing.Size(761, 31);
            this.SaloonToolStrip.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2,
            this.colLaderPivotGroupID_int});
            this.LaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaderTypeGridView.Location = new System.Drawing.Point(0, 0);
            this.LaderTypeGridView.Margin = new System.Windows.Forms.Padding(0);
            this.LaderTypeGridView.MultiSelect = false;
            this.LaderTypeGridView.Name = "LaderTypeGridView";
            this.LaderTypeGridView.ReadOnly = true;
            this.LaderTypeGridView.RowHeadersVisible = false;
            this.LaderTypeGridView.Size = new System.Drawing.Size(198, 413);
            this.LaderTypeGridView.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SaloonGridView);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LaderTypeGridView);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(761, 413);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 4;
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
            this.colLaderTypeCode_nvc.Visible = false;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نام بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 135;
            // 
            // colMinTruckWeight_dec
            // 
            this.colMinTruckWeight_dec.DataPropertyName = "MinTruckWeight_dec";
            this.colMinTruckWeight_dec.HeaderText = "حداقل وزن بارگیر";
            this.colMinTruckWeight_dec.Name = "colMinTruckWeight_dec";
            this.colMinTruckWeight_dec.ReadOnly = true;
            this.colMinTruckWeight_dec.Visible = false;
            // 
            // colMaxTruckWeight_dec
            // 
            this.colMaxTruckWeight_dec.DataPropertyName = "MaxTruckWeight_dec";
            this.colMaxTruckWeight_dec.HeaderText = "حداکثر وزن بارگیر";
            this.colMaxTruckWeight_dec.Name = "colMaxTruckWeight_dec";
            this.colMaxTruckWeight_dec.ReadOnly = true;
            this.colMaxTruckWeight_dec.Visible = false;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 73;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SaloonID_int";
            this.dataGridViewTextBoxColumn2.HeaderText = "سالن اطلاع رسانی بار";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // colLaderPivotGroupID_int
            // 
            this.colLaderPivotGroupID_int.DataPropertyName = "LaderPivotGroupID_intLaderPivotGroup_nvc";
            this.colLaderPivotGroupID_int.HeaderText = "تعداد محور";
            this.colLaderPivotGroupID_int.Name = "colLaderPivotGroupID_int";
            this.colLaderPivotGroupID_int.ReadOnly = true;
            this.colLaderPivotGroupID_int.Visible = false;
            // 
            // SaloonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(761, 444);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.SaloonToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "SaloonListForm";
            this.Text = "سالن اطلاع رسانی بار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaloonListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaloonGridView)).EndInit();
            this.SaloonToolStrip.ResumeLayout(false);
            this.SaloonToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip SaloonToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView SaloonGridView;
        private System.Windows.Forms.DataGridView LaderTypeGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaloonID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaloon_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnDistinictAfterCredit_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumberInLadeAnnouncement_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinTruckWeight_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTruckWeight_dec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroupID_int;
    }

}