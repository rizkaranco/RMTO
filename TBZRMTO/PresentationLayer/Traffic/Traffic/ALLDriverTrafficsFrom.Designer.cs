namespace HPS.Present.Traffic
{
    partial class AllDriverTrafficsFrom
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
            this.AllDriverTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DriverTrafficGridView = new System.Windows.Forms.DataGridView();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCredit_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllDriverTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverTrafficGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllDriverTrafficToolStrip
            // 
            this.AllDriverTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllDriverTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClosetoolStripButton});
            this.AllDriverTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllDriverTrafficToolStrip.Name = "AllDriverTrafficToolStrip";
            this.AllDriverTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllDriverTrafficToolStrip.Size = new System.Drawing.Size(863, 31);
            this.AllDriverTrafficToolStrip.TabIndex = 7;
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
            // DriverTrafficGridView
            // 
            this.DriverTrafficGridView.AllowUserToAddRows = false;
            this.DriverTrafficGridView.AllowUserToDeleteRows = false;
            this.DriverTrafficGridView.AllowUserToResizeRows = false;
            this.DriverTrafficGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.DriverTrafficGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverTrafficGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverID_bint,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colTrafficNumber_bint,
            this.colTurnNumber_bint,
            this.colLadBillCredit_int,
            this.colNumberPlate_nvc,
            this.colSystem_nvc});
            this.DriverTrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverTrafficGridView.Location = new System.Drawing.Point(0, 31);
            this.DriverTrafficGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DriverTrafficGridView.MultiSelect = false;
            this.DriverTrafficGridView.Name = "DriverTrafficGridView";
            this.DriverTrafficGridView.ReadOnly = true;
            this.DriverTrafficGridView.RowHeadersVisible = false;
            this.DriverTrafficGridView.Size = new System.Drawing.Size(863, 394);
            this.DriverTrafficGridView.TabIndex = 11;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.DataPropertyName = "DriverID_bint";
            this.colDriverID_bint.HeaderText = "شناسه راننده";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.ReadOnly = true;
            this.colDriverID_bint.Visible = false;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 120;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            // 
            // colFirstName_nvc
            // 
            this.colFirstName_nvc.DataPropertyName = "FirstName_nvc";
            this.colFirstName_nvc.HeaderText = "نام";
            this.colFirstName_nvc.Name = "colFirstName_nvc";
            this.colFirstName_nvc.ReadOnly = true;
            // 
            // colLastName_nvc
            // 
            this.colLastName_nvc.DataPropertyName = "LastName_nvc";
            this.colLastName_nvc.HeaderText = "نام خانوادگی";
            this.colLastName_nvc.Name = "colLastName_nvc";
            this.colLastName_nvc.ReadOnly = true;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "TurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "شماره نوبت";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
            // 
            // colLadBillCredit_int
            // 
            this.colLadBillCredit_int.DataPropertyName = "LadBillCredit_int";
            this.colLadBillCredit_int.HeaderText = "شماره مجوز";
            this.colLadBillCredit_int.Name = "colLadBillCredit_int";
            this.colLadBillCredit_int.ReadOnly = true;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک کامیون";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 150;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نوع وسیله";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            // 
            // AllDriverTrafficsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 425);
            this.Controls.Add(this.DriverTrafficGridView);
            this.Controls.Add(this.AllDriverTrafficToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "AllDriverTrafficsFrom";
            this.Text = "کل ترددهای راننده";
            this.Load += new System.EventHandler(this.DriverAllTrafficsFrom_Load);
            this.AllDriverTrafficToolStrip.ResumeLayout(false);
            this.AllDriverTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverTrafficGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllDriverTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView DriverTrafficGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCredit_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
    }
}