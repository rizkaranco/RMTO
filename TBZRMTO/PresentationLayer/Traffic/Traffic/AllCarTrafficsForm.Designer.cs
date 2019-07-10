namespace HPS.Present.Traffic
{
    partial class AllCarTrafficsForm
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
            this.AllCarTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CarTrafficGridView = new System.Windows.Forms.DataGridView();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCredit_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colArea_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllCarTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTrafficGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllCarTrafficToolStrip
            // 
            this.AllCarTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllCarTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClosetoolStripButton});
            this.AllCarTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllCarTrafficToolStrip.Name = "AllCarTrafficToolStrip";
            this.AllCarTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllCarTrafficToolStrip.Size = new System.Drawing.Size(922, 31);
            this.AllCarTrafficToolStrip.TabIndex = 8;
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
            // CarTrafficGridView
            // 
            this.CarTrafficGridView.AllowUserToAddRows = false;
            this.CarTrafficGridView.AllowUserToDeleteRows = false;
            this.CarTrafficGridView.AllowUserToResizeRows = false;
            this.CarTrafficGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CarTrafficGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTrafficGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarID_int,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colTrafficNumber_bint,
            this.colTurnNumber_bint,
            this.colLadBillCredit_int,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colPlateType_nvc,
            this.colIn_bit,
            this.colArea_bit,
            this.colSystem_nvc,
            this.colLaderType_nvc,
            this.colFirstName_nvc,
            this.colLastName_nvc});
            this.CarTrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarTrafficGridView.Location = new System.Drawing.Point(0, 31);
            this.CarTrafficGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CarTrafficGridView.MultiSelect = false;
            this.CarTrafficGridView.Name = "CarTrafficGridView";
            this.CarTrafficGridView.ReadOnly = true;
            this.CarTrafficGridView.RowHeadersVisible = false;
            this.CarTrafficGridView.Size = new System.Drawing.Size(922, 440);
            this.CarTrafficGridView.TabIndex = 12;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه کامیون";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
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
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            // 
            // colIn_bit
            // 
            this.colIn_bit.DataPropertyName = "In_bit";
            this.colIn_bit.HeaderText = "ورود";
            this.colIn_bit.Name = "colIn_bit";
            this.colIn_bit.ReadOnly = true;
            // 
            // colArea_bit
            // 
            this.colArea_bit.DataPropertyName = "Area_bit";
            this.colArea_bit.HeaderText = "حومه";
            this.colArea_bit.Name = "colArea_bit";
            this.colArea_bit.ReadOnly = true;
            this.colArea_bit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colArea_bit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSystem_nvc
            // 
            this.colSystem_nvc.DataPropertyName = "System_nvc";
            this.colSystem_nvc.HeaderText = "نوع وسیله";
            this.colSystem_nvc.Name = "colSystem_nvc";
            this.colSystem_nvc.ReadOnly = true;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
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
            // AllCarTrafficsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 471);
            this.Controls.Add(this.CarTrafficGridView);
            this.Controls.Add(this.AllCarTrafficToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "AllCarTrafficsForm";
            this.Text = "تمام ترددهای کامیون";
            this.Load += new System.EventHandler(this.AllCarTrafficsForm_Load);
            this.AllCarTrafficToolStrip.ResumeLayout(false);
            this.AllCarTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarTrafficGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllCarTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView CarTrafficGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCredit_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIn_bit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colArea_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
    }
}