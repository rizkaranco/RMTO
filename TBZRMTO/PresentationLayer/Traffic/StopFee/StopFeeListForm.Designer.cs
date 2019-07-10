namespace HPS.Present.StopFee
    {
    partial class StopFeeListForm 

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.StopFeeGridView = new System.Windows.Forms.DataGridView();
            this.StopFeeToolStrip = new System.Windows.Forms.ToolStrip();
            this.colStopFeeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAllowedHoure_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHourFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderPivotGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWithLadeExtraHourFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicesID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnNotLadBillExtraHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnNotLadBillExtraHourFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StopFeeGridView)).BeginInit();
            this.StopFeeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = global::HPS.Properties.Resources.Add;
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.Text = "جديد";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = global::HPS.Properties.Resources.Edit;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(28, 28);
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::HPS.Properties.Resources.Delete;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::HPS.Properties.Resources.Refresh;
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
            // StopFeeGridView
            // 
            this.StopFeeGridView.AllowUserToAddRows = false;
            this.StopFeeGridView.AllowUserToDeleteRows = false;
            this.StopFeeGridView.AllowUserToResizeRows = false;
            this.StopFeeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.StopFeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StopFeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStopFeeID_int,
            this.Tax_bit,
            this.colAllowedHoure_int,
            this.colFee_dec,
            this.colExtraHour_int,
            this.colExtraHourFee_dec,
            this.colTrafficTypeID_int,
            this.colLaderPivotGroupID_int,
            this.colStartDate_nvc,
            this.colEndDate_nvc,
            this.colWithLadeExtraHourFee_dec,
            this.colServicesID_int,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colUserName_nvc,
            this.TurnNotLadBillExtraHour_int,
            this.TurnNotLadBillExtraHourFee_dec});
            this.StopFeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopFeeGridView.Location = new System.Drawing.Point(0, 31);
            this.StopFeeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.StopFeeGridView.MultiSelect = false;
            this.StopFeeGridView.Name = "StopFeeGridView";
            this.StopFeeGridView.ReadOnly = true;
            this.StopFeeGridView.RowHeadersVisible = false;
            this.StopFeeGridView.Size = new System.Drawing.Size(1044, 386);
            this.StopFeeGridView.TabIndex = 0;
            // 
            // StopFeeToolStrip
            // 
            this.StopFeeToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StopFeeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.StopFeeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.StopFeeToolStrip.Name = "StopFeeToolStrip";
            this.StopFeeToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.StopFeeToolStrip.Size = new System.Drawing.Size(1044, 31);
            this.StopFeeToolStrip.TabIndex = 1;
            // 
            // colStopFeeID_int
            // 
            this.colStopFeeID_int.DataPropertyName = "StopFeeID_int";
            this.colStopFeeID_int.HeaderText = "شناسه هزینه ماندن در پارکینگ";
            this.colStopFeeID_int.Name = "colStopFeeID_int";
            this.colStopFeeID_int.ReadOnly = true;
            this.colStopFeeID_int.Visible = false;
            // 
            // Tax_bit
            // 
            this.Tax_bit.DataPropertyName = "Tax_bit";
            this.Tax_bit.HeaderText = "ارزش افزوده";
            this.Tax_bit.Name = "Tax_bit";
            this.Tax_bit.ReadOnly = true;
            // 
            // colAllowedHoure_int
            // 
            this.colAllowedHoure_int.DataPropertyName = "AllowedHoure_int";
            this.colAllowedHoure_int.HeaderText = "ساعت مجاز";
            this.colAllowedHoure_int.Name = "colAllowedHoure_int";
            this.colAllowedHoure_int.ReadOnly = true;
            // 
            // colFee_dec
            // 
            this.colFee_dec.DataPropertyName = "Fee_dec";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colFee_dec.DefaultCellStyle = dataGridViewCellStyle1;
            this.colFee_dec.HeaderText = "هزینه";
            this.colFee_dec.Name = "colFee_dec";
            this.colFee_dec.ReadOnly = true;
            // 
            // colExtraHour_int
            // 
            this.colExtraHour_int.DataPropertyName = "ExtraHour_int";
            this.colExtraHour_int.HeaderText = "اضافه ساعت";
            this.colExtraHour_int.Name = "colExtraHour_int";
            this.colExtraHour_int.ReadOnly = true;
            // 
            // colExtraHourFee_dec
            // 
            this.colExtraHourFee_dec.DataPropertyName = "ExtraHourFee_dec";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colExtraHourFee_dec.DefaultCellStyle = dataGridViewCellStyle2;
            this.colExtraHourFee_dec.HeaderText = "هزینه اضافه ساعت";
            this.colExtraHourFee_dec.Name = "colExtraHourFee_dec";
            this.colExtraHourFee_dec.ReadOnly = true;
            this.colExtraHourFee_dec.Width = 150;
            // 
            // colTrafficTypeID_int
            // 
            this.colTrafficTypeID_int.DataPropertyName = "TrafficTypeID_intTrafficType_nvc";
            this.colTrafficTypeID_int.HeaderText = "نوع تردد";
            this.colTrafficTypeID_int.Name = "colTrafficTypeID_int";
            this.colTrafficTypeID_int.ReadOnly = true;
            // 
            // colLaderPivotGroupID_int
            // 
            this.colLaderPivotGroupID_int.DataPropertyName = "LaderPivotGroupID_intLaderPivotGroup_nvc";
            this.colLaderPivotGroupID_int.HeaderText = "محور بارگیر";
            this.colLaderPivotGroupID_int.Name = "colLaderPivotGroupID_int";
            this.colLaderPivotGroupID_int.ReadOnly = true;
            // 
            // colStartDate_nvc
            // 
            this.colStartDate_nvc.DataPropertyName = "StartDate_nvc";
            this.colStartDate_nvc.HeaderText = "از تاریخ";
            this.colStartDate_nvc.Name = "colStartDate_nvc";
            this.colStartDate_nvc.ReadOnly = true;
            // 
            // colEndDate_nvc
            // 
            this.colEndDate_nvc.DataPropertyName = "EndDate_nvc";
            this.colEndDate_nvc.HeaderText = "تا تاریخ";
            this.colEndDate_nvc.Name = "colEndDate_nvc";
            this.colEndDate_nvc.ReadOnly = true;
            // 
            // colWithLadeExtraHourFee_dec
            // 
            this.colWithLadeExtraHourFee_dec.DataPropertyName = "WithLadeExtraHourFee_dec";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colWithLadeExtraHourFee_dec.DefaultCellStyle = dataGridViewCellStyle3;
            this.colWithLadeExtraHourFee_dec.HeaderText = "هزينه اضافه ساعت با بار";
            this.colWithLadeExtraHourFee_dec.Name = "colWithLadeExtraHourFee_dec";
            this.colWithLadeExtraHourFee_dec.ReadOnly = true;
            this.colWithLadeExtraHourFee_dec.Width = 160;
            // 
            // colServicesID_int
            // 
            this.colServicesID_int.DataPropertyName = "ServicesID_intServicesType_nvc";
            this.colServicesID_int.HeaderText = "مراجعه به";
            this.colServicesID_int.Name = "colServicesID_int";
            this.colServicesID_int.ReadOnly = true;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Visible = false;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Visible = false;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Visible = false;
            this.colUserName_nvc.Width = 80;
            // 
            // TurnNotLadBillExtraHour_int
            // 
            this.TurnNotLadBillExtraHour_int.DataPropertyName = "TurnNotLadBillExtraHour_int";
            this.TurnNotLadBillExtraHour_int.HeaderText = "ساعت مجاز نوبت بدون مجوز";
            this.TurnNotLadBillExtraHour_int.Name = "TurnNotLadBillExtraHour_int";
            this.TurnNotLadBillExtraHour_int.ReadOnly = true;
            this.TurnNotLadBillExtraHour_int.Width = 150;
            // 
            // TurnNotLadBillExtraHourFee_dec
            // 
            this.TurnNotLadBillExtraHourFee_dec.DataPropertyName = "TurnNotLadBillExtraHourFee_dec";
            this.TurnNotLadBillExtraHourFee_dec.HeaderText = "مبلغ نوبت بدون مجوز";
            this.TurnNotLadBillExtraHourFee_dec.Name = "TurnNotLadBillExtraHourFee_dec";
            this.TurnNotLadBillExtraHourFee_dec.ReadOnly = true;
            this.TurnNotLadBillExtraHourFee_dec.Width = 130;
            // 
            // StopFeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1044, 417);
            this.Controls.Add(this.StopFeeGridView);
            this.Controls.Add(this.StopFeeToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "StopFeeListForm";
            this.Text = "لیست حق پارکینگ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StopFeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StopFeeGridView)).EndInit();
            this.StopFeeToolStrip.ResumeLayout(false);
            this.StopFeeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip StopFeeToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView StopFeeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStopFeeID_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tax_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowedHoure_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraHourFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWithLadeExtraHourFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicesID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnNotLadBillExtraHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnNotLadBillExtraHourFee_dec;
    }

}