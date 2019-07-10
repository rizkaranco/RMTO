using HamrahanSystem.TextBox;
using System.Windows.Forms;
namespace HPS.Present.TurnManagement
    {
    partial class TurnManagementListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnManagementListForm));
            this.TurnManagementGridView = new System.Windows.Forms.DataGridView();
            this.colTurnManagementID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCreditID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnManagementTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnCancelCommantID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnCancelCommment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptedTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManagementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManagementTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnManagementToolStrip = new System.Windows.Forms.ToolStrip();
            this.CurrentTurnStripButton = new System.Windows.Forms.ToolStripButton();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.CanceledTurnFromLadbilltoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CloceButton = new System.Windows.Forms.ToolStripButton();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Trafficnumberlabel = new System.Windows.Forms.Label();
            this.ToDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FromDate_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrafficNumberTextBox = new NumericTextBox();
            this.AcceptedTurnNumberTextBox = new NumericTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.TurnManagementGridView)).BeginInit();
            this.TurnManagementToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TurnManagementGridView
            // 
            this.TurnManagementGridView.AllowUserToAddRows = false;
            this.TurnManagementGridView.AllowUserToDeleteRows = false;
            this.TurnManagementGridView.AllowUserToResizeRows = false;
            this.TurnManagementGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TurnManagementGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TurnManagementGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTurnManagementID_int,
            this.colLadBillCreditID_int,
            this.colTurnManagementTrafficID_bint,
            this.colTurnCancelCommantID_int,
            this.colTurnCancelCommment_nvc,
            this.colReturn_bit,
            this.colTrafficNumber_bint,
            this.TurnNumber_bint,
            this.AcceptedTurnNumber_bint,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colLaderTypeID_int,
            this.colLaderType_nvc,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colManagementDate,
            this.colManagementTime,
            this.colUserName_nvc});
            this.TurnManagementGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurnManagementGridView.Location = new System.Drawing.Point(0, 97);
            this.TurnManagementGridView.Margin = new System.Windows.Forms.Padding(5);
            this.TurnManagementGridView.MultiSelect = false;
            this.TurnManagementGridView.Name = "TurnManagementGridView";
            this.TurnManagementGridView.ReadOnly = true;
            this.TurnManagementGridView.RowHeadersVisible = false;
            this.TurnManagementGridView.Size = new System.Drawing.Size(917, 388);
            this.TurnManagementGridView.TabIndex = 0;
            // 
            // colTurnManagementID_int
            // 
            this.colTurnManagementID_int.DataPropertyName = "TurnManagementID_int";
            this.colTurnManagementID_int.HeaderText = "شناسه مدیریت نوبت";
            this.colTurnManagementID_int.Name = "colTurnManagementID_int";
            this.colTurnManagementID_int.ReadOnly = true;
            this.colTurnManagementID_int.Visible = false;
            // 
            // colLadBillCreditID_int
            // 
            this.colLadBillCreditID_int.DataPropertyName = "LadBillCreditID_int";
            this.colLadBillCreditID_int.HeaderText = "LadBillCreditID_int";
            this.colLadBillCreditID_int.Name = "colLadBillCreditID_int";
            this.colLadBillCreditID_int.ReadOnly = true;
            this.colLadBillCreditID_int.Visible = false;
            // 
            // colTurnManagementTrafficID_bint
            // 
            this.colTurnManagementTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTurnManagementTrafficID_bint.HeaderText = "تردد مدیریت نوبت";
            this.colTurnManagementTrafficID_bint.Name = "colTurnManagementTrafficID_bint";
            this.colTurnManagementTrafficID_bint.ReadOnly = true;
            this.colTurnManagementTrafficID_bint.Visible = false;
            // 
            // colTurnCancelCommantID_int
            // 
            this.colTurnCancelCommantID_int.DataPropertyName = "TurnCancelCommmentID_int";
            this.colTurnCancelCommantID_int.HeaderText = "توضیحات ابطال نوبت";
            this.colTurnCancelCommantID_int.Name = "colTurnCancelCommantID_int";
            this.colTurnCancelCommantID_int.ReadOnly = true;
            this.colTurnCancelCommantID_int.Visible = false;
            // 
            // colTurnCancelCommment_nvc
            // 
            this.colTurnCancelCommment_nvc.DataPropertyName = "TurnCancelCommantID_intTurnCancelCommant_nvc";
            this.colTurnCancelCommment_nvc.HeaderText = "توضیحات ابطال نوبت";
            this.colTurnCancelCommment_nvc.Name = "colTurnCancelCommment_nvc";
            this.colTurnCancelCommment_nvc.ReadOnly = true;
            this.colTurnCancelCommment_nvc.Width = 200;
            // 
            // colReturn_bit
            // 
            this.colReturn_bit.DataPropertyName = "Return_bit";
            this.colReturn_bit.HeaderText = "احیای نوبت";
            this.colReturn_bit.Name = "colReturn_bit";
            this.colReturn_bit.ReadOnly = true;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
            // 
            // TurnNumber_bint
            // 
            this.TurnNumber_bint.DataPropertyName = "TurnNumber_bint";
            this.TurnNumber_bint.HeaderText = "نوبت رزرو";
            this.TurnNumber_bint.Name = "TurnNumber_bint";
            this.TurnNumber_bint.ReadOnly = true;
            this.TurnNumber_bint.Width = 90;
            // 
            // AcceptedTurnNumber_bint
            // 
            this.AcceptedTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.AcceptedTurnNumber_bint.HeaderText = "ش.نوبت تأیید شده";
            this.AcceptedTurnNumber_bint.Name = "AcceptedTurnNumber_bint";
            this.AcceptedTurnNumber_bint.ReadOnly = true;
            this.AcceptedTurnNumber_bint.Width = 140;
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
            this.colLastName_nvc.Width = 110;
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
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ  ورود";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت ورود";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 97;
            // 
            // colManagementDate
            // 
            this.colManagementDate.DataPropertyName = "ManagementDate";
            this.colManagementDate.HeaderText = "تاریخ ابطال";
            this.colManagementDate.Name = "colManagementDate";
            this.colManagementDate.ReadOnly = true;
            // 
            // colManagementTime
            // 
            this.colManagementTime.DataPropertyName = "ManagementTime";
            this.colManagementTime.HeaderText = "ساعت ابطال";
            this.colManagementTime.Name = "colManagementTime";
            this.colManagementTime.ReadOnly = true;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "TMUser";
            this.colUserName_nvc.HeaderText = "کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            // 
            // TurnManagementToolStrip
            // 
            this.TurnManagementToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TurnManagementToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentTurnStripButton,
            this.NewButton,
            this.EditButton,
            this.CanceledTurnFromLadbilltoolStripButton,
            this.DeleteButton,
            this.RefreshButton,
            this.CancelButton,
            this.ExportButton,
            this.CloceButton});
            this.TurnManagementToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TurnManagementToolStrip.Name = "TurnManagementToolStrip";
            this.TurnManagementToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TurnManagementToolStrip.Size = new System.Drawing.Size(917, 31);
            this.TurnManagementToolStrip.TabIndex = 1;
            // 
            // CurrentTurnStripButton
            // 
            this.CurrentTurnStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrentTurnStripButton.Image = global::HPS.Properties.Resources.AllRecords;
            this.CurrentTurnStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrentTurnStripButton.Name = "CurrentTurnStripButton";
            this.CurrentTurnStripButton.Size = new System.Drawing.Size(28, 28);
            this.CurrentTurnStripButton.Text = "تمامی نوبت ها";
            this.CurrentTurnStripButton.Click += new System.EventHandler(this.CurrentTurnStripButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = global::HPS.Properties.Resources._new;
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
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CanceledTurnFromLadbilltoolStripButton
            // 
            this.CanceledTurnFromLadbilltoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CanceledTurnFromLadbilltoolStripButton.Image = global::HPS.Properties.Resources.list;
            this.CanceledTurnFromLadbilltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CanceledTurnFromLadbilltoolStripButton.Name = "CanceledTurnFromLadbilltoolStripButton";
            this.CanceledTurnFromLadbilltoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.CanceledTurnFromLadbilltoolStripButton.Text = "نمایش نوبت های باطل شده در ابطال مجوز";
            this.CanceledTurnFromLadbilltoolStripButton.Visible = false;
            this.CanceledTurnFromLadbilltoolStripButton.Click += new System.EventHandler(this.CanceledTurnFromLadbilltoolStripButton_Click);
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
            // CloceButton
            // 
            this.CloceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloceButton.Image = global::HPS.Properties.Resources.Close;
            this.CloceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloceButton.Name = "CloceButton";
            this.CloceButton.Size = new System.Drawing.Size(28, 28);
            this.CloceButton.Text = "بستن";
            this.CloceButton.Click += new System.EventHandler(this.CloceButton_Click);
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(290, 22);
            this.SerialPlate_nvcTextBox.MaxLength = 2;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(45, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 3;
            this.SerialPlate_nvcTextBox.Tag = "شماره پلاك";
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SerialPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlate_nvcTextBox_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "شماره نوبت تأیید شده";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(339, 22);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(108, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 2;
            this.NumberPlate_nvcTextBox.Tag = "شماره پلاك";
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(448, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 42;
            this.label15.Text = "شماره پلاك";
            // 
            // Trafficnumberlabel
            // 
            this.Trafficnumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trafficnumberlabel.AutoSize = true;
            this.Trafficnumberlabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Trafficnumberlabel.Location = new System.Drawing.Point(844, 26);
            this.Trafficnumberlabel.Name = "Trafficnumberlabel";
            this.Trafficnumberlabel.Size = new System.Drawing.Size(71, 23);
            this.Trafficnumberlabel.TabIndex = 41;
            this.Trafficnumberlabel.Text = "شماره قبض";
            // 
            // ToDate_nvcTextBox
            // 
            this.ToDate_nvcTextBox.Location = new System.Drawing.Point(6, 22);
            this.ToDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ToDate_nvcTextBox.Mask = "0000/00/00";
            this.ToDate_nvcTextBox.Name = "ToDate_nvcTextBox";
            this.ToDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToDate_nvcTextBox.Size = new System.Drawing.Size(91, 30);
            this.ToDate_nvcTextBox.TabIndex = 56;
            this.ToDate_nvcTextBox.Click += new System.EventHandler(this.ToDate_nvcTextBox_Click);
            this.ToDate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToDate_nvcTextBox_KeyDown);
            // 
            // FromDate_nvcTextBox
            // 
            this.FromDate_nvcTextBox.Location = new System.Drawing.Point(148, 22);
            this.FromDate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FromDate_nvcTextBox.Mask = "0000/00/00";
            this.FromDate_nvcTextBox.Name = "FromDate_nvcTextBox";
            this.FromDate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDate_nvcTextBox.Size = new System.Drawing.Size(91, 30);
            this.FromDate_nvcTextBox.TabIndex = 55;
            this.FromDate_nvcTextBox.Click += new System.EventHandler(this.FromDate_nvcTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "از تاریخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 57;
            this.label2.Text = "تا تاریخ";
            // 
            // TrafficNumberTextBox
            // 
            this.TrafficNumberTextBox.AllowNegative = true;
            this.TrafficNumberTextBox.DigitsInGroup = 0;
            this.TrafficNumberTextBox.Flags = 0;
            this.TrafficNumberTextBox.Location = new System.Drawing.Point(743, 22);
            this.TrafficNumberTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumberTextBox.MaxWholeDigits = 9;
            this.TrafficNumberTextBox.Name = "TrafficNumberTextBox";
            this.TrafficNumberTextBox.Prefix = "";
            //this.TrafficNumberTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
            //this.TrafficNumberTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.TrafficNumberTextBox.Size = new System.Drawing.Size(100, 30);
            this.TrafficNumberTextBox.TabIndex = 59;
            this.TrafficNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficNumberTextBox_KeyDown);
            // 
            // AcceptedTurnNumberTextBox
            // 
            this.AcceptedTurnNumberTextBox.AllowNegative = true;
            this.AcceptedTurnNumberTextBox.DigitsInGroup = 0;
            this.AcceptedTurnNumberTextBox.Flags = 0;
            this.AcceptedTurnNumberTextBox.Location = new System.Drawing.Point(518, 22);
            this.AcceptedTurnNumberTextBox.MaxDecimalPlaces = 4;
            this.AcceptedTurnNumberTextBox.MaxWholeDigits = 9;
            this.AcceptedTurnNumberTextBox.Name = "AcceptedTurnNumberTextBox";
            this.AcceptedTurnNumberTextBox.Prefix = "";
            //this.AcceptedTurnNumberTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
            //this.AcceptedTurnNumberTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.AcceptedTurnNumberTextBox.Size = new System.Drawing.Size(100, 30);
            this.AcceptedTurnNumberTextBox.TabIndex = 60;
            this.AcceptedTurnNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcceptedTurnNumberTextBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Trafficnumberlabel);
            this.groupBox1.Controls.Add(this.ToDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.AcceptedTurnNumberTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromDate_nvcTextBox);
            this.groupBox1.Controls.Add(this.TrafficNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.SerialPlate_nvcTextBox);
            this.groupBox1.Controls.Add(this.NumberPlate_nvcTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 66);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelButton.Image = global::HPS.Properties.Resources.Cancel;
            this.CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(28, 28);
            this.CancelButton.Text = "ابطال نوبت";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TurnManagementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 485);
            this.Controls.Add(this.TurnManagementGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TurnManagementToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "TurnManagementListForm";
            this.Text = "لیست مدیریت نوبت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TurnManagementListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TurnManagementGridView)).EndInit();
            this.TurnManagementToolStrip.ResumeLayout(false);
            this.TurnManagementToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip TurnManagementToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView TurnManagementGridView;
        private System.Windows.Forms.ToolStripButton CanceledTurnFromLadbilltoolStripButton;
        private System.Windows.Forms.ToolStripButton CloceButton;
        private System.Windows.Forms.ToolStripButton CurrentTurnStripButton;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Trafficnumberlabel;
        private System.Windows.Forms.MaskedTextBox ToDate_nvcTextBox;
        private System.Windows.Forms.MaskedTextBox FromDate_nvcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NumericTextBox TrafficNumberTextBox;
        private NumericTextBox AcceptedTurnNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnManagementID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCreditID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnManagementTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnCancelCommantID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnCancelCommment_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReturn_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptedTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagementTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.ToolStripButton CancelButton;
    }

}