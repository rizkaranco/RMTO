namespace HPS.Reports.Forms
{
    partial class AcceptedTurnWithoutLadBillCreditReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptedTurnWithoutLadBillCreditReportForm));
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.TurnPrintstripButton = new System.Windows.Forms.ToolStripButton();
            this.PrinterSelectionButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.TrafficGridView = new System.Windows.Forms.DataGridView();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnUser_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIn_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName_nvctextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.AcceptedTurnNumber_binttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ShowwithConditionbutton = new Janus.Windows.EditControls.UIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TrafficNumber_binttextBox = new System.Windows.Forms.TextBox();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TurnPrintstripButton,
            this.PrinterSelectionButton,
            this.CloseButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(1024, 31);
            this.AllTrafficToolStrip.TabIndex = 0;
            // 
            // TurnPrintstripButton
            // 
            this.TurnPrintstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TurnPrintstripButton.Image = ((System.Drawing.Image)(resources.GetObject("TurnPrintstripButton.Image")));
            this.TurnPrintstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TurnPrintstripButton.Name = "TurnPrintstripButton";
            this.TurnPrintstripButton.Size = new System.Drawing.Size(28, 28);
            this.TurnPrintstripButton.Text = "نمایش مانده نوبت به تفکیک بارگیر";
            this.TurnPrintstripButton.Click += new System.EventHandler(this.TurnPrintstripButton_Click);
            // 
            // PrinterSelectionButton
            // 
            this.PrinterSelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrinterSelectionButton.Image = global::HPS.Properties.Resources.Cancel;
            this.PrinterSelectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrinterSelectionButton.Name = "PrinterSelectionButton";
            this.PrinterSelectionButton.Size = new System.Drawing.Size(28, 28);
            this.PrinterSelectionButton.Text = "انصراف";
            this.PrinterSelectionButton.Click += new System.EventHandler(this.PrinterSelectionButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TrafficGridView
            // 
            this.TrafficGridView.AllowUserToAddRows = false;
            this.TrafficGridView.AllowUserToDeleteRows = false;
            this.TrafficGridView.AllowUserToResizeRows = false;
            this.TrafficGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TrafficGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrafficGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrafficID_bint,
            this.TurnDate_nvc,
            this.TurnTime_nvc,
            this.colCarID_int,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colTurnNumber_bint,
            this.colTrafficNumber_bint,
            this.colFirstName_nvc,
            this.colLastName_nvc,
            this.colNumberPlate_nvc,
            this.TurnUser_nvc,
            this.colSerialPlate_nvc,
            this.colPlateType_nvc,
            this.colIn_bit,
            this.colLaderType_nvc,
            this.colLaderTypeID_int});
            this.TrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficGridView.Location = new System.Drawing.Point(138, 34);
            this.TrafficGridView.MultiSelect = false;
            this.TrafficGridView.Name = "TrafficGridView";
            this.TrafficGridView.ReadOnly = true;
            this.TrafficGridView.RowHeadersVisible = false;
            this.TrafficGridView.Size = new System.Drawing.Size(883, 613);
            this.TrafficGridView.TabIndex = 15;
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // TurnDate_nvc
            // 
            this.TurnDate_nvc.DataPropertyName = "TurnDate_nvc";
            this.TurnDate_nvc.HeaderText = "تاریخ تأیید ";
            this.TurnDate_nvc.Name = "TurnDate_nvc";
            this.TurnDate_nvc.ReadOnly = true;
            // 
            // TurnTime_nvc
            // 
            this.TurnTime_nvc.DataPropertyName = "TurnTime_nvc";
            this.TurnTime_nvc.HeaderText = "ساعت تأیید ";
            this.TurnTime_nvc.Name = "TurnTime_nvc";
            this.TurnTime_nvc.ReadOnly = true;
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
            this.colDate_nvc.HeaderText = "تاریخ ورود";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Width = 90;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت ورود";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Width = 90;
            // 
            // colTurnNumber_bint
            // 
            this.colTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.colTurnNumber_bint.HeaderText = "ش.نوبت تأیید";
            this.colTurnNumber_bint.Name = "colTurnNumber_bint";
            this.colTurnNumber_bint.ReadOnly = true;
            this.colTurnNumber_bint.Width = 115;
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
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 150;
            // 
            // TurnUser_nvc
            // 
            this.TurnUser_nvc.DataPropertyName = "TurnUser_nvc";
            this.TurnUser_nvc.HeaderText = "کاربر ثبت نوبت";
            this.TurnUser_nvc.Name = "TurnUser_nvc";
            this.TurnUser_nvc.ReadOnly = true;
            this.TurnUser_nvc.Width = 120;
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
            // colLaderType_nvc
            // 
            this.colLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 150;
            // 
            // colLaderTypeID_int
            // 
            this.colLaderTypeID_int.DataPropertyName = "LaderTypeID_int";
            this.colLaderTypeID_int.HeaderText = "شناسه نوع بارگیر";
            this.colLaderTypeID_int.Name = "colLaderTypeID_int";
            this.colLaderTypeID_int.ReadOnly = true;
            this.colLaderTypeID_int.Visible = false;
            // 
            // LastName_nvctextBox
            // 
            this.LastName_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LastName_nvctextBox.Location = new System.Drawing.Point(19, 277);
            this.LastName_nvctextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastName_nvctextBox.Name = "LastName_nvctextBox";
            this.LastName_nvctextBox.Size = new System.Drawing.Size(102, 22);
            this.LastName_nvctextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(43, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "نام خانوادگی :";
            // 
            // SerialPlate_nvctextBox
            // 
            this.SerialPlate_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvctextBox.Location = new System.Drawing.Point(18, 224);
            this.SerialPlate_nvctextBox.Margin = new System.Windows.Forms.Padding(1);
            this.SerialPlate_nvctextBox.Name = "SerialPlate_nvctextBox";
            this.SerialPlate_nvctextBox.Size = new System.Drawing.Size(30, 22);
            this.SerialPlate_nvctextBox.TabIndex = 5;
            // 
            // NumberPlate_nvctextBox
            // 
            this.NumberPlate_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvctextBox.Location = new System.Drawing.Point(51, 224);
            this.NumberPlate_nvctextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NumberPlate_nvctextBox.Name = "NumberPlate_nvctextBox";
            this.NumberPlate_nvctextBox.Size = new System.Drawing.Size(70, 22);
            this.NumberPlate_nvctextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(48, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "شماره پلاک :";
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label.Location = new System.Drawing.Point(48, 153);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 14);
            this.label.TabIndex = 7;
            this.label.Text = "شماره قبض :";
            // 
            // AcceptedTurnNumber_binttextBox
            // 
            this.AcceptedTurnNumber_binttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptedTurnNumber_binttextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AcceptedTurnNumber_binttextBox.Location = new System.Drawing.Point(19, 123);
            this.AcceptedTurnNumber_binttextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AcceptedTurnNumber_binttextBox.Name = "AcceptedTurnNumber_binttextBox";
            this.AcceptedTurnNumber_binttextBox.Size = new System.Drawing.Size(102, 22);
            this.AcceptedTurnNumber_binttextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(49, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره نوبت :";
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("3c1807a8-42e8-4148-a27e-86e575694676");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("3c1807a8-42e8-4148-a27e-86e575694676"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 613), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("3c1807a8-42e8-4148-a27e-86e575694676"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(135, 613);
            this.uiPanel0.TabIndex = 0;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ShowwithConditionbutton);
            this.uiPanel0Container.Controls.Add(this.label6);
            this.uiPanel0Container.Controls.Add(this.LastName_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.label7);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.SerialPlate_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.NumberPlate_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.AcceptedTurnNumber_binttextBox);
            this.uiPanel0Container.Controls.Add(this.label4);
            this.uiPanel0Container.Controls.Add(this.label3);
            this.uiPanel0Container.Controls.Add(this.TrafficNumber_binttextBox);
            this.uiPanel0Container.Controls.Add(this.label);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 589);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(5, 21);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(118, 20);
            this.FromDatefaDatePicker.TabIndex = 0;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(5, 74);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(118, 20);
            this.ToDatefaDatePicker.TabIndex = 1;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ShowwithConditionbutton
            // 
            this.ShowwithConditionbutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowwithConditionbutton.Location = new System.Drawing.Point(19, 315);
            this.ShowwithConditionbutton.Margin = new System.Windows.Forms.Padding(1);
            this.ShowwithConditionbutton.Name = "ShowwithConditionbutton";
            this.ShowwithConditionbutton.Size = new System.Drawing.Size(102, 29);
            this.ShowwithConditionbutton.TabIndex = 7;
            this.ShowwithConditionbutton.Text = "نمایش";
            this.ShowwithConditionbutton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowwithConditionbutton.Click += new System.EventHandler(this.ShowwithConditionbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(75, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 47;
            this.label6.Text = "تا تاریخ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(75, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "از تاریخ :";
            // 
            // TrafficNumber_binttextBox
            // 
            this.TrafficNumber_binttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficNumber_binttextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficNumber_binttextBox.Location = new System.Drawing.Point(19, 172);
            this.TrafficNumber_binttextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TrafficNumber_binttextBox.Name = "TrafficNumber_binttextBox";
            this.TrafficNumber_binttextBox.Size = new System.Drawing.Size(102, 22);
            this.TrafficNumber_binttextBox.TabIndex = 3;
            // 
            // AcceptedTurnWithoutLadBillCreditReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this.TrafficGridView);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AcceptedTurnWithoutLadBillCreditReportForm";
            this.Text = "لیست نوبت های تأیید شده مجوز نگرفته";
            this.Load += new System.EventHandler(this.AcceptedTurnWithoutLadBillCreditReportForm_Load);
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrinterSelectionButton;
        private System.Windows.Forms.ToolStripButton TurnPrintstripButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.DataGridView TrafficGridView;
        private System.Windows.Forms.TextBox LastName_nvctextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SerialPlate_nvctextBox;
        private System.Windows.Forms.TextBox NumberPlate_nvctextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox AcceptedTurnNumber_binttextBox;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TrafficNumber_binttextBox;
        private Janus.Windows.EditControls.UIButton ShowwithConditionbutton;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnUser_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIn_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_int;
    }
}