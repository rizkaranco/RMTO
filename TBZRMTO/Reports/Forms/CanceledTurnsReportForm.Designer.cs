namespace HPS.Reports.Forms
{
    partial class CanceledTurnsReportForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanceledTurnsReportForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.CanceledTurnsGridView = new System.Windows.Forms.DataGridView();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnCancelCommment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptedTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnUser_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnManagementTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnCancelCommantID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExportToExcelStripButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintCanceledButton = new System.Windows.Forms.ToolStripButton();
            this.AllCanceledTurnstiReport = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanceledTurnsGridView)).BeginInit();
            this.AllTrafficToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(71, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(71, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "از تاریخ :";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(7, 104);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(112, 20);
            this.ToDatefaDatePicker.TabIndex = 40;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(7, 40);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(112, 20);
            this.FromDatefaDatePicker.TabIndex = 39;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("67746ad4-2c93-46cf-8ee9-ca1cbba9b563");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("67746ad4-2c93-46cf-8ee9-ca1cbba9b563"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 575), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("67746ad4-2c93-46cf-8ee9-ca1cbba9b563"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(135, 575);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 545);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(98, 128);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 68;
            this.DefaulCheckBox.ToolTipText = "ساعات بین 00:00:00 و 23:59:59";
            this.DefaulCheckBox.CheckedChanged += new System.EventHandler(this.DefaulCheckBox_CheckedChanged);
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.FromTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.RefreshHourbutton);
            this.TimeGroupBox.Controls.Add(this.label3);
            this.TimeGroupBox.Controls.Add(this.ToTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.label4);
            this.TimeGroupBox.Enabled = false;
            this.TimeGroupBox.Location = new System.Drawing.Point(2, 128);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(124, 110);
            this.TimeGroupBox.TabIndex = 69;
            this.TimeGroupBox.TabStop = false;
            // 
            // FromTimeTextBox
            // 
            this.FromTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTimeTextBox.Location = new System.Drawing.Point(3, 20);
            this.FromTimeTextBox.Mask = "00:00:00";
            this.FromTimeTextBox.Name = "FromTimeTextBox";
            this.FromTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromTimeTextBox.Size = new System.Drawing.Size(60, 22);
            this.FromTimeTextBox.TabIndex = 59;
            this.FromTimeTextBox.Text = "000000";
            this.FromTimeTextBox.Click += new System.EventHandler(this.FromTimetxt_Click);
            // 
            // RefreshHourbutton
            // 
            this.RefreshHourbutton.Image = global::HPS.Properties.Resources.Refresh16;
            this.RefreshHourbutton.Location = new System.Drawing.Point(3, 80);
            this.RefreshHourbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshHourbutton.Name = "RefreshHourbutton";
            this.RefreshHourbutton.Size = new System.Drawing.Size(24, 24);
            this.RefreshHourbutton.TabIndex = 61;
            this.RefreshHourbutton.UseVisualStyleBackColor = true;
            this.RefreshHourbutton.Click += new System.EventHandler(this.RefreshHourbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(61, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 65;
            this.label3.Text = "از ساعت :";
            // 
            // ToTimeTextBox
            // 
            this.ToTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTimeTextBox.Location = new System.Drawing.Point(3, 53);
            this.ToTimeTextBox.Mask = "00:00:00";
            this.ToTimeTextBox.Name = "ToTimeTextBox";
            this.ToTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToTimeTextBox.Size = new System.Drawing.Size(60, 22);
            this.ToTimeTextBox.TabIndex = 60;
            this.ToTimeTextBox.Text = "235959";
            this.ToTimeTextBox.Click += new System.EventHandler(this.ToTimetxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(61, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "تا ساعت :";
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(10, 247);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(109, 27);
            this.ShowButton.TabIndex = 41;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // CanceledTurnsGridView
            // 
            this.CanceledTurnsGridView.AllowUserToAddRows = false;
            this.CanceledTurnsGridView.AllowUserToDeleteRows = false;
            this.CanceledTurnsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.CanceledTurnsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CanceledTurnsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.CanceledTurnsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CanceledTurnsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate_nvc,
            this.colTime_nvc,
            this.colTurnCancelCommment_nvc,
            this.colUserName_nvc,
            this.AcceptedTurnNumber_bint,
            this.colTurnDate_nvc,
            this.colTurnTime_nvc,
            this.colTurnUser_nvc,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colLaderType_nvc,
            this.colTrafficNumber_bint,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colLaderTypeID_int,
            this.colTurnManagementTrafficID_bint,
            this.colTurnCancelCommantID_int});
            this.CanceledTurnsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanceledTurnsGridView.Location = new System.Drawing.Point(138, 34);
            this.CanceledTurnsGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CanceledTurnsGridView.MultiSelect = false;
            this.CanceledTurnsGridView.Name = "CanceledTurnsGridView";
            this.CanceledTurnsGridView.ReadOnly = true;
            this.CanceledTurnsGridView.RowHeadersVisible = false;
            this.CanceledTurnsGridView.Size = new System.Drawing.Size(843, 575);
            this.CanceledTurnsGridView.TabIndex = 5;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ ابطال";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت ابطال";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 97;
            // 
            // colTurnCancelCommment_nvc
            // 
            this.colTurnCancelCommment_nvc.DataPropertyName = "TurnCancelCommantID_intTurnCancelCommant_nvc";
            this.colTurnCancelCommment_nvc.HeaderText = "توضیحات ابطال";
            this.colTurnCancelCommment_nvc.Name = "colTurnCancelCommment_nvc";
            this.colTurnCancelCommment_nvc.ReadOnly = true;
            this.colTurnCancelCommment_nvc.Width = 200;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "TMUser";
            this.colUserName_nvc.HeaderText = "کاربر ابطال";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            // 
            // AcceptedTurnNumber_bint
            // 
            this.AcceptedTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.AcceptedTurnNumber_bint.HeaderText = "ش.نوبت تأیید شده";
            this.AcceptedTurnNumber_bint.Name = "AcceptedTurnNumber_bint";
            this.AcceptedTurnNumber_bint.ReadOnly = true;
            this.AcceptedTurnNumber_bint.Width = 140;
            // 
            // colTurnDate_nvc
            // 
            this.colTurnDate_nvc.DataPropertyName = "TurnDate_nvc";
            this.colTurnDate_nvc.HeaderText = "تاریخ تأیید";
            this.colTurnDate_nvc.Name = "colTurnDate_nvc";
            this.colTurnDate_nvc.ReadOnly = true;
            // 
            // colTurnTime_nvc
            // 
            this.colTurnTime_nvc.DataPropertyName = "TurnTime_nvc";
            this.colTurnTime_nvc.HeaderText = "ساعت تأیید";
            this.colTurnTime_nvc.Name = "colTurnTime_nvc";
            this.colTurnTime_nvc.ReadOnly = true;
            // 
            // colTurnUser_nvc
            // 
            this.colTurnUser_nvc.DataPropertyName = "TurnUser_nvc";
            this.colTurnUser_nvc.HeaderText = "کاربر تأیید ";
            this.colTurnUser_nvc.Name = "colTurnUser_nvc";
            this.colTurnUser_nvc.ReadOnly = true;
            this.colTurnUser_nvc.Width = 120;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک ";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری ";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            this.colSerialPlate_nvc.Width = 40;
            // 
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
            // 
            // colTrafficNumber_bint
            // 
            this.colTrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.colTrafficNumber_bint.HeaderText = "شماره قبض";
            this.colTrafficNumber_bint.Name = "colTrafficNumber_bint";
            this.colTrafficNumber_bint.ReadOnly = true;
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
            this.colLastName_nvc.Width = 120;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // colTurnManagementTrafficID_bint
            // 
            this.colTurnManagementTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTurnManagementTrafficID_bint.HeaderText = "شناسه تردد ";
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
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToExcelStripButton,
            this.ClosetoolStripButton,
            this.PrintCanceledButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(984, 31);
            this.AllTrafficToolStrip.TabIndex = 10;
            // 
            // ExportToExcelStripButton
            // 
            this.ExportToExcelStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportToExcelStripButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportToExcelStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcelStripButton.Name = "ExportToExcelStripButton";
            this.ExportToExcelStripButton.Size = new System.Drawing.Size(28, 28);
            this.ExportToExcelStripButton.Text = "انتقال به excel";
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
            // PrintCanceledButton
            // 
            this.PrintCanceledButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintCanceledButton.Image = global::HPS.Properties.Resources.Print;
            this.PrintCanceledButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintCanceledButton.Name = "PrintCanceledButton";
            this.PrintCanceledButton.Size = new System.Drawing.Size(28, 28);
            this.PrintCanceledButton.Text = "چاپ";
            this.PrintCanceledButton.Click += new System.EventHandler(this.PrintCanceledButton_Click);
            // 
            // AllCanceledTurnstiReport
            // 
            this.AllCanceledTurnstiReport.CookieContainer = null;
            this.AllCanceledTurnstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.AllCanceledTurnstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.AllCanceledTurnstiReport.ReportAlias = "Report";
            this.AllCanceledTurnstiReport.ReportGuid = "5fae9fe21381450380abbb8c1bc7c032";
            this.AllCanceledTurnstiReport.ReportName = "Report";
            this.AllCanceledTurnstiReport.ReportSource = resources.GetString("AllCanceledTurnstiReport.ReportSource");
            this.AllCanceledTurnstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.AllCanceledTurnstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.AllCanceledTurnstiReport.UseProgressInThread = false;
            // 
            // CanceledTurnsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.CanceledTurnsGridView);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Name = "CanceledTurnsReportForm";
            this.Text = "گزارش نوبت های باطل شده";
            this.Load += new System.EventHandler(this.AllInReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanceledTurnsGridView)).EndInit();
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.DataGridView CanceledTurnsGridView;
        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton ExportToExcelStripButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnCancelCommment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceptedTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnUser_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnManagementTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnCancelCommantID_int;
        private Stimulsoft.Report.StiReport AllCanceledTurnstiReport;
        private System.Windows.Forms.ToolStripButton PrintCanceledButton;
    }
}