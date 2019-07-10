namespace HPS.Present.Traffic
{
    partial class AllOutForm
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
            this.TrafficGridView = new System.Windows.Forms.DataGridView();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSystem_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServicesType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderPivotGroup_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcceptedTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnAccepted_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTurnHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillMessageID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHourFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowableHour_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWithLade_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCityCode_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalCode_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrafficGridView
            // 
            this.TrafficGridView.AllowUserToAddRows = false;
            this.TrafficGridView.AllowUserToDeleteRows = false;
            this.TrafficGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(252)))));
            this.TrafficGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrafficGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TrafficGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrafficGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrafficID_bint,
            this.colMaxTrafficID_bint,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colTrafficNumber_bint,
            this.colNumberPlate_nvc,
            this.colPlateCity_nvc,
            this.colSerialPlate_nvc,
            this.colSystem_nvc,
            this.colLaderType_nvc,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colServicesType_nvc,
            this.colLaderPivotGroup_nvc,
            this.colTurnNumber_bint,
            this.colAcceptedTurnNumber_bint,
            this.colTurnAccepted_bit,
            this.colTurnHour_int,
            this.colInText,
            this.colCarID_int,
            this.colBillMessageID_int,
            this.colComment_nvc,
            this.colUserName_nvc,
            this.colExtraHourFee_dec,
            this.colExtraHour_int,
            this.colFee_dec,
            this.colAllowableHour_int,
            this.colPlateType_nvc,
            this.colServiceID_int,
            this.colWithLade_bit,
            this.colLaderTypeID_int,
            this.colPrice_dec,
            this.colPlateCityCode_nvc,
            this.colDriverCardNumber_nvc,
            this.colCarCardNumber_nvc,
            this.colDriverID_bint,
            this.colNationalCode_int});
            this.TrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TrafficGridView.Location = new System.Drawing.Point(0, 31);
            this.TrafficGridView.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficGridView.MultiSelect = false;
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.ReadOnly = true;
            this.TrafficGridView.RowHeadersVisible = false;
            this.TrafficGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrafficGridView.Size = new System.Drawing.Size(891, 374);
            this.TrafficGridView.TabIndex = 12;
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // colMaxTrafficID_bint
            // 
            this.colMaxTrafficID_bint.DataPropertyName = "MaxTrafficID_bint";
            this.colMaxTrafficID_bint.HeaderText = "شناسه آخرین تردد خودرو";
            this.colMaxTrafficID_bint.Name = "colMaxTrafficID_bint";
            this.colMaxTrafficID_bint.ReadOnly = true;
            this.colMaxTrafficID_bint.Visible = false;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 90;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 80;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک ";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            // 
            // colPlateCity_nvc
            // 
            this.colPlateCity_nvc.DataPropertyName = "PlateCityID_intPlateCity_nvc";
            this.colPlateCity_nvc.HeaderText = "شهر شماره گذاری";
            this.colPlateCity_nvc.Name = "colPlateCity_nvc";
            this.colPlateCity_nvc.ReadOnly = true;
            this.colPlateCity_nvc.Width = 130;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری پلاک";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
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
            // colServicesType_nvc
            // 
            this.colServicesType_nvc.DataPropertyName = "ServiceID_intServiceType_nvc";
            this.colServicesType_nvc.HeaderText = "مراجعه به";
            this.colServicesType_nvc.Name = "colServicesType_nvc";
            this.colServicesType_nvc.ReadOnly = true;
            // 
            // colLaderPivotGroup_nvc
            // 
            this.colLaderPivotGroup_nvc.DataPropertyName = "LaderPivotGroupID_intLaderPivotGroup_nvc";
            this.colLaderPivotGroup_nvc.HeaderText = "گروه بارگير";
            this.colLaderPivotGroup_nvc.Name = "colLaderPivotGroup_nvc";
            this.colLaderPivotGroup_nvc.ReadOnly = true;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "TurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "شماره نوبت";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
            // 
            // colAcceptedTurnNumber_bint
            // 
            this.colAcceptedTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.colAcceptedTurnNumber_bint.HeaderText = "شماره نوبت تأیید شده";
            this.colAcceptedTurnNumber_bint.Name = "colAcceptedTurnNumber_bint";
            this.colAcceptedTurnNumber_bint.ReadOnly = true;
            this.colAcceptedTurnNumber_bint.Width = 150;
            // 
            // colTurnAccepted_bit
            // 
            this.colTurnAccepted_bit.DataPropertyName = "TurnAccepted_bit";
            this.colTurnAccepted_bit.HeaderText = "تأیید نوبت";
            this.colTurnAccepted_bit.Name = "colTurnAccepted_bit";
            this.colTurnAccepted_bit.ReadOnly = true;
            this.colTurnAccepted_bit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTurnAccepted_bit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTurnHour_int
            // 
            this.colTurnHour_int.DataPropertyName = "TurnHour_int";
            this.colTurnHour_int.HeaderText = "ساعت مجاز نوبت";
            this.colTurnHour_int.Name = "colTurnHour_int";
            this.colTurnHour_int.ReadOnly = true;
            this.colTurnHour_int.Visible = false;
            // 
            // colInText
            // 
            this.colInText.DataPropertyName = "InText";
            this.colInText.HeaderText = "نوع تردد";
            this.colInText.Name = "colInText";
            this.colInText.ReadOnly = true;
            this.colInText.Visible = false;
            this.colInText.Width = 70;
            // 
            // colCarID_int
            // 
            this.colCarID_int.DataPropertyName = "CarID_int";
            this.colCarID_int.HeaderText = "شناسه کامیون";
            this.colCarID_int.Name = "colCarID_int";
            this.colCarID_int.ReadOnly = true;
            this.colCarID_int.Visible = false;
            // 
            // colBillMessageID_int
            // 
            this.colBillMessageID_int.DataPropertyName = "BillMessageID_int";
            this.colBillMessageID_int.HeaderText = "پیام";
            this.colBillMessageID_int.Name = "colBillMessageID_int";
            this.colBillMessageID_int.ReadOnly = true;
            this.colBillMessageID_int.Visible = false;
            // 
            // colComment_nvc
            // 
            this.colComment_nvc.DataPropertyName = "Comment_nvc";
            this.colComment_nvc.HeaderText = "توضیحات";
            this.colComment_nvc.Name = "colComment_nvc";
            this.colComment_nvc.ReadOnly = true;
            this.colComment_nvc.Visible = false;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Visible = false;
            // 
            // colExtraHourFee_dec
            // 
            this.colExtraHourFee_dec.DataPropertyName = "ExtraHourFee_dec";
            this.colExtraHourFee_dec.HeaderText = "مبلغ اضافه ساعت";
            this.colExtraHourFee_dec.Name = "colExtraHourFee_dec";
            this.colExtraHourFee_dec.ReadOnly = true;
            this.colExtraHourFee_dec.Visible = false;
            // 
            // colExtraHour_int
            // 
            this.colExtraHour_int.DataPropertyName = "ExtraHour_int";
            this.colExtraHour_int.HeaderText = "مدت اضافه";
            this.colExtraHour_int.Name = "colExtraHour_int";
            this.colExtraHour_int.ReadOnly = true;
            this.colExtraHour_int.Visible = false;
            // 
            // colFee_dec
            // 
            this.colFee_dec.DataPropertyName = "Fee_dec";
            this.colFee_dec.HeaderText = "هزینه";
            this.colFee_dec.Name = "colFee_dec";
            this.colFee_dec.ReadOnly = true;
            this.colFee_dec.Visible = false;
            // 
            // colAllowableHour_int
            // 
            this.colAllowableHour_int.DataPropertyName = "AllowableHour_int";
            this.colAllowableHour_int.HeaderText = "ساعت مجاز";
            this.colAllowableHour_int.Name = "colAllowableHour_int";
            this.colAllowableHour_int.ReadOnly = true;
            this.colAllowableHour_int.Visible = false;
            // 
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "PlateType_nvc";
            this.colPlateType_nvc.HeaderText = "نوع پلاک";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            this.colPlateType_nvc.Visible = false;
            // 
            // colServiceID_int
            // 
            this.colServiceID_int.DataPropertyName = "ServiceID_int";
            this.colServiceID_int.HeaderText = "خدمات";
            this.colServiceID_int.Name = "colServiceID_int";
            this.colServiceID_int.ReadOnly = true;
            this.colServiceID_int.Visible = false;
            // 
            // colWithLade_bit
            // 
            this.colWithLade_bit.DataPropertyName = "WithLade_bit";
            this.colWithLade_bit.HeaderText = "با بار";
            this.colWithLade_bit.Name = "colWithLade_bit";
            this.colWithLade_bit.ReadOnly = true;
            this.colWithLade_bit.Visible = false;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colPrice_dec
            // 
            this.colPrice_dec.DataPropertyName = "Price_dec";
            this.colPrice_dec.HeaderText = "مبلغ";
            this.colPrice_dec.Name = "colPrice_dec";
            this.colPrice_dec.ReadOnly = true;
            this.colPrice_dec.Visible = false;
            // 
            // colPlateCityCode_nvc
            // 
            this.colPlateCityCode_nvc.DataPropertyName = "PlateCityCode_nvc";
            this.colPlateCityCode_nvc.HeaderText = "کد شهر شماره گذاری";
            this.colPlateCityCode_nvc.Name = "colPlateCityCode_nvc";
            this.colPlateCityCode_nvc.ReadOnly = true;
            this.colPlateCityCode_nvc.Visible = false;
            // 
            // colDriverCardNumber_nvc
            // 
            this.colDriverCardNumber_nvc.DataPropertyName = "DriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.HeaderText = " شماره کارت راننده";
            this.colDriverCardNumber_nvc.Name = "colDriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.ReadOnly = true;
            this.colDriverCardNumber_nvc.Visible = false;
            // 
            // colCarCardNumber_nvc
            // 
            this.colCarCardNumber_nvc.DataPropertyName = "CarCardNumber_nvc";
            this.colCarCardNumber_nvc.HeaderText = " شماره کارت ماشین";
            this.colCarCardNumber_nvc.Name = "colCarCardNumber_nvc";
            this.colCarCardNumber_nvc.ReadOnly = true;
            this.colCarCardNumber_nvc.Visible = false;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.DataPropertyName = "DriverID_bint";
            this.colDriverID_bint.HeaderText = "شناره راننده";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.ReadOnly = true;
            this.colDriverID_bint.Visible = false;
            // 
            // colNationalCode_int
            // 
            this.colNationalCode_int.DataPropertyName = "NationalCode_int";
            this.colNationalCode_int.HeaderText = "کد ملی";
            this.colNationalCode_int.Name = "colNationalCode_int";
            this.colNationalCode_int.ReadOnly = true;
            this.colNationalCode_int.Visible = false;
            // 
            // AllOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 405);
            this.Controls.Add(this.TrafficGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "AllOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کل خروج ها";
            this.Load += new System.EventHandler(this.AllOutForm_Load);
            this.Controls.SetChildIndex(this.TrafficGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TrafficGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSystem_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServicesType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderPivotGroup_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcceptedTurnNumber_bint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTurnAccepted_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillMessageID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraHourFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowableHour_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID_int;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithLade_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCityCode_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalCode_int;
    }
}