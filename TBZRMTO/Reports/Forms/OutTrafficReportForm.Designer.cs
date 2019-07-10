namespace HPS.Reports.Forms
{
    partial class OutTrafficReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutTrafficReportForm));
            this.ToTrafficNumbertxt = new System.Windows.Forms.TextBox();
            this.FromTrafficNumbertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ServicescomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiButton1 = new Janus.Windows.EditControls.UIButton();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ForeignOutTrafficstiReport = new Stimulsoft.Report.StiReport();
            this.OtherOutTrafficStiReport = new Stimulsoft.Report.StiReport();
            this.LaderType_nvcSearchButton = new System.Windows.Forms.Button();
            this.AllIranianCarRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.LaderTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LaderPivotGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.IranianOutTrafiicstiReport = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToTrafficNumbertxt
            // 
            this.ToTrafficNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTrafficNumbertxt.Location = new System.Drawing.Point(15, 274);
            this.ToTrafficNumbertxt.Margin = new System.Windows.Forms.Padding(5);
            this.ToTrafficNumbertxt.Name = "ToTrafficNumbertxt";
            this.ToTrafficNumbertxt.Size = new System.Drawing.Size(111, 22);
            this.ToTrafficNumbertxt.TabIndex = 5;
            // 
            // FromTrafficNumbertxt
            // 
            this.FromTrafficNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTrafficNumbertxt.Location = new System.Drawing.Point(15, 230);
            this.FromTrafficNumbertxt.Margin = new System.Windows.Forms.Padding(5);
            this.FromTrafficNumbertxt.Name = "FromTrafficNumbertxt";
            this.FromTrafficNumbertxt.Size = new System.Drawing.Size(111, 22);
            this.FromTrafficNumbertxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(48, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 42;
            this.label6.Text = "تا قبض شماره";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(48, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 41;
            this.label5.Text = "از قبض شماره";
            // 
            // ServicescomboBox
            // 
            this.ServicescomboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ServicescomboBox.FormattingEnabled = true;
            this.ServicescomboBox.Location = new System.Drawing.Point(15, 318);
            this.ServicescomboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServicescomboBox.Name = "ServicescomboBox";
            this.ServicescomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ServicescomboBox.Size = new System.Drawing.Size(111, 22);
            this.ServicescomboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(70, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 14);
            this.label8.TabIndex = 44;
            this.label8.Text = "مراجعه به";
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("d39e4336-4c10-4101-8cc2-27ed14e0e0d5");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("d39e4336-4c10-4101-8cc2-27ed14e0e0d5"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 556), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("d39e4336-4c10-4101-8cc2-27ed14e0e0d5"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiPanel0.Size = new System.Drawing.Size(135, 556);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.uiButton1);
            this.uiPanel0Container.Controls.Add(this.FromTrafficNumbertxt);
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.label8);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.ServicescomboBox);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label6);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToTrafficNumbertxt);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 526);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiButton1
            // 
            this.uiButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiButton1.Location = new System.Drawing.Point(12, 490);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(108, 29);
            this.uiButton1.TabIndex = 90;
            this.uiButton1.Text = "نمایش";
            this.uiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.uiButton1.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(100, 103);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 89;
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
            this.TimeGroupBox.Location = new System.Drawing.Point(2, 101);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(124, 110);
            this.TimeGroupBox.TabIndex = 88;
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
            this.FromTimeTextBox.Click += new System.EventHandler(this.FromTimeTextBox_Click);
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
            this.ToTimeTextBox.Click += new System.EventHandler(this.ToTimeTextBox_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(81, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 87;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(81, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 86;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(9, 23);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.FromDatefaDatePicker.TabIndex = 84;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(9, 75);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.ToDatefaDatePicker.TabIndex = 85;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ForeignOutTrafficstiReport
            // 
            this.ForeignOutTrafficstiReport.CookieContainer = null;
            this.ForeignOutTrafficstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ForeignOutTrafficstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.ForeignOutTrafficstiReport.ReportAlias = "Report";
            this.ForeignOutTrafficstiReport.ReportGuid = "cd5fe1ce965d45bf81f95ab80aee7630";
            this.ForeignOutTrafficstiReport.ReportName = "Report";
            this.ForeignOutTrafficstiReport.ReportSource = resources.GetString("ForeignOutTrafficstiReport.ReportSource");
            this.ForeignOutTrafficstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ForeignOutTrafficstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.ForeignOutTrafficstiReport.UseProgressInThread = false;
            // 
            // OtherOutTrafficStiReport
            // 
            this.OtherOutTrafficStiReport.CookieContainer = null;
            this.OtherOutTrafficStiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.OtherOutTrafficStiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.OtherOutTrafficStiReport.ReportAlias = "Report";
            this.OtherOutTrafficStiReport.ReportGuid = "51b720d70db741d2bbde04343185bb32";
            this.OtherOutTrafficStiReport.ReportName = "Report";
            this.OtherOutTrafficStiReport.ReportSource = resources.GetString("OtherOutTrafficStiReport.ReportSource");
            this.OtherOutTrafficStiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.OtherOutTrafficStiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.OtherOutTrafficStiReport.UseProgressInThread = false;
            // 
            // LaderType_nvcSearchButton
            // 
            this.LaderType_nvcSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.LaderType_nvcSearchButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.LaderType_nvcSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderType_nvcSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderType_nvcSearchButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderType_nvcSearchButton.Location = new System.Drawing.Point(13, 113);
            this.LaderType_nvcSearchButton.Margin = new System.Windows.Forms.Padding(5);
            this.LaderType_nvcSearchButton.Name = "LaderType_nvcSearchButton";
            this.LaderType_nvcSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderType_nvcSearchButton.Size = new System.Drawing.Size(32, 31);
            this.LaderType_nvcSearchButton.TabIndex = 3;
            this.LaderType_nvcSearchButton.TabStop = false;
            this.LaderType_nvcSearchButton.UseVisualStyleBackColor = false;
            this.LaderType_nvcSearchButton.Click += new System.EventHandler(this.LaderType_nvcSearchButton_Click);
            // 
            // AllIranianCarRadioButton
            // 
            this.AllIranianCarRadioButton.AutoSize = true;
            this.AllIranianCarRadioButton.Checked = true;
            this.AllIranianCarRadioButton.Location = new System.Drawing.Point(9, 12);
            this.AllIranianCarRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.AllIranianCarRadioButton.Name = "AllIranianCarRadioButton";
            this.AllIranianCarRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllIranianCarRadioButton.Size = new System.Drawing.Size(110, 18);
            this.AllIranianCarRadioButton.TabIndex = 0;
            this.AllIranianCarRadioButton.TabStop = true;
            this.AllIranianCarRadioButton.Text = "تمامی کامیون ها";
            this.AllIranianCarRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(59, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = " نوع بارگیر";
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(59, 33);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(59, 14);
            this.LaderPivotGroupID_intLabel.TabIndex = 24;
            this.LaderPivotGroupID_intLabel.Text = "تعداد محور";
            // 
            // LaderTypeID_intComboBox
            // 
            this.LaderTypeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LaderTypeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LaderTypeID_intComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.LaderTypeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intComboBox.FormattingEnabled = true;
            this.LaderTypeID_intComboBox.Location = new System.Drawing.Point(10, 89);
            this.LaderTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeID_intComboBox.Name = "LaderTypeID_intComboBox";
            this.LaderTypeID_intComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LaderTypeID_intComboBox.Size = new System.Drawing.Size(111, 22);
            this.LaderTypeID_intComboBox.TabIndex = 2;
            // 
            // LaderPivotGroupID_intComboBox
            // 
            this.LaderPivotGroupID_intComboBox.FormattingEnabled = true;
            this.LaderPivotGroupID_intComboBox.Location = new System.Drawing.Point(10, 52);
            this.LaderPivotGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderPivotGroupID_intComboBox.Name = "LaderPivotGroupID_intComboBox";
            this.LaderPivotGroupID_intComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LaderPivotGroupID_intComboBox.Size = new System.Drawing.Size(111, 22);
            this.LaderPivotGroupID_intComboBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LaderPivotGroupID_intComboBox);
            this.groupBox1.Controls.Add(this.LaderTypeID_intComboBox);
            this.groupBox1.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AllIranianCarRadioButton);
            this.groupBox1.Controls.Add(this.LaderType_nvcSearchButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 371);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(123, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(138, 3);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowBookmarksPanel = false;
            this.stiViewerControl1.ShowCloseButton = false;
            this.stiViewerControl1.ShowContextMenu = false;
            this.stiViewerControl1.ShowDotMatrixModeButton = false;
            this.stiViewerControl1.ShowEditor = false;
            this.stiViewerControl1.ShowFind = false;
            this.stiViewerControl1.ShowOpen = false;
            this.stiViewerControl1.ShowPageDelete = false;
            this.stiViewerControl1.ShowPageDesign = false;
            this.stiViewerControl1.ShowPageNew = false;
            this.stiViewerControl1.ShowPageSize = false;
            this.stiViewerControl1.ShowSaveDocumentFile = false;
            this.stiViewerControl1.ShowSendEMail = false;
            this.stiViewerControl1.ShowSendEMailDocumentFile = false;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(843, 556);
            this.stiViewerControl1.TabIndex = 8;
            // 
            // IranianOutTrafiicstiReport
            // 
            this.IranianOutTrafiicstiReport.CookieContainer = null;
            this.IranianOutTrafiicstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.IranianOutTrafiicstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.IranianOutTrafiicstiReport.ReportAlias = "Report";
            this.IranianOutTrafiicstiReport.ReportGuid = "f0ab5775efb44fbda45e911adbe63e9f";
            this.IranianOutTrafiicstiReport.ReportName = "Report";
            this.IranianOutTrafiicstiReport.ReportSource = resources.GetString("IranianOutTrafiicstiReport.ReportSource");
            this.IranianOutTrafiicstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.IranianOutTrafiicstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.IranianOutTrafiicstiReport.UseProgressInThread = false;
            // 
            // OutTrafficReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "OutTrafficReportForm";
            this.Text = "گزارش كاميون هاي ايراني خروجي از پاركينگ  ";
            this.Load += new System.EventHandler(this.OutTrafficReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ToTrafficNumbertxt;
        private System.Windows.Forms.TextBox FromTrafficNumbertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ServicescomboBox;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton uiButton1;
        private Stimulsoft.Report.StiReport ForeignOutTrafficstiReport;
        private Stimulsoft.Report.StiReport OtherOutTrafficStiReport;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox LaderPivotGroupID_intComboBox;
        private System.Windows.Forms.ComboBox LaderTypeID_intComboBox;
        private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton AllIranianCarRadioButton;
        private System.Windows.Forms.Button LaderType_nvcSearchButton;
        private Stimulsoft.Report.StiReport IranianOutTrafiicstiReport;
    }
}