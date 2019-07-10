namespace HPS.Reports.Forms
{
    partial class CarLadBillAndCancelAndTurnReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarLadBillAndCancelAndTurnReportForm));
            Janus.Windows.GridEX.GridEXLayout LaderTypecheckedComboBox_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.CarLadeBillstiReport = new Stimulsoft.Report.StiReport();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DriverWithDuplicateCarCheckBox = new System.Windows.Forms.CheckBox();
            this.DriverCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LaderTypecheckedComboBox = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CarCardNumber_nvctextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CarSerialnumbertextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvctextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.DriverWithDuplicateCarReport = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarLadeBillstiReport
            // 
            this.CarLadeBillstiReport.CookieContainer = null;
            this.CarLadeBillstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.CarLadeBillstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.CarLadeBillstiReport.ReportAlias = "Report";
            this.CarLadeBillstiReport.ReportGuid = "acf35c54658f47b69ec51466714391fe";
            this.CarLadeBillstiReport.ReportName = "Report";
            this.CarLadeBillstiReport.ReportSource = resources.GetString("CarLadeBillstiReport.ReportSource");
            this.CarLadeBillstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.CarLadeBillstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.CarLadeBillstiReport.UseProgressInThread = false;
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("fd1b89e3-1d51-4b7f-ac9d-681a1748e21f");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("fd1b89e3-1d51-4b7f-ac9d-681a1748e21f"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(170, 575), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("fd1b89e3-1d51-4b7f-ac9d-681a1748e21f"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(170, 575);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.DriverWithDuplicateCarCheckBox);
            this.uiPanel0Container.Controls.Add(this.DriverCardNumber_nvcTextBox);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.textBox1);
            this.uiPanel0Container.Controls.Add(this.label6);
            this.uiPanel0Container.Controls.Add(this.LaderTypecheckedComboBox);
            this.uiPanel0Container.Controls.Add(this.label7);
            this.uiPanel0Container.Controls.Add(this.CarCardNumber_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.label16);
            this.uiPanel0Container.Controls.Add(this.CarSerialnumbertextBox);
            this.uiPanel0Container.Controls.Add(this.NumberPlate_nvctextBox);
            this.uiPanel0Container.Controls.Add(this.label18);
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(164, 551);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DriverWithDuplicateCarCheckBox
            // 
            this.DriverWithDuplicateCarCheckBox.AutoSize = true;
            this.DriverWithDuplicateCarCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverWithDuplicateCarCheckBox.Location = new System.Drawing.Point(6, 474);
            this.DriverWithDuplicateCarCheckBox.Name = "DriverWithDuplicateCarCheckBox";
            this.DriverWithDuplicateCarCheckBox.Size = new System.Drawing.Size(154, 18);
            this.DriverWithDuplicateCarCheckBox.TabIndex = 107;
            this.DriverWithDuplicateCarCheckBox.Text = "راننده دارای ناوگان مختلف";
            this.DriverWithDuplicateCarCheckBox.UseVisualStyleBackColor = true;
            // 
            // DriverCardNumber_nvcTextBox
            // 
            this.DriverCardNumber_nvcTextBox.Location = new System.Drawing.Point(23, 449);
            this.DriverCardNumber_nvcTextBox.Name = "DriverCardNumber_nvcTextBox";
            this.DriverCardNumber_nvcTextBox.Size = new System.Drawing.Size(119, 20);
            this.DriverCardNumber_nvcTextBox.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 105;
            this.label5.Text = "شماره کارت راننده:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(22, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(41, 385);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(110, 14);
            this.label6.TabIndex = 103;
            this.label6.Text = "شماره کارت ناوگان :";
            // 
            // LaderTypecheckedComboBox
            // 
            LaderTypecheckedComboBox_DesignTimeLayout.LayoutString = resources.GetString("LaderTypecheckedComboBox_DesignTimeLayout.LayoutString");
            this.LaderTypecheckedComboBox.DesignTimeLayout = LaderTypecheckedComboBox_DesignTimeLayout;
            this.LaderTypecheckedComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaderTypecheckedComboBox.Location = new System.Drawing.Point(13, 253);
            this.LaderTypecheckedComboBox.Name = "LaderTypecheckedComboBox";
            this.LaderTypecheckedComboBox.SaveSettings = false;
            this.LaderTypecheckedComboBox.Size = new System.Drawing.Size(134, 22);
            this.LaderTypecheckedComboBox.TabIndex = 98;
            this.LaderTypecheckedComboBox.ValuesDataMember = null;
            this.LaderTypecheckedComboBox.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(91, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 99;
            this.label7.Text = " نوع بارگیر";
            // 
            // CarCardNumber_nvctextBox
            // 
            this.CarCardNumber_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarCardNumber_nvctextBox.Location = new System.Drawing.Point(21, 353);
            this.CarCardNumber_nvctextBox.Name = "CarCardNumber_nvctextBox";
            this.CarCardNumber_nvctextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CarCardNumber_nvctextBox.Size = new System.Drawing.Size(118, 22);
            this.CarCardNumber_nvctextBox.TabIndex = 97;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(40, 334);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(110, 14);
            this.label16.TabIndex = 96;
            this.label16.Text = "شماره کارت ناوگان :";
            // 
            // CarSerialnumbertextBox
            // 
            this.CarSerialnumbertextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarSerialnumbertextBox.Location = new System.Drawing.Point(21, 301);
            this.CarSerialnumbertextBox.Name = "CarSerialnumbertextBox";
            this.CarSerialnumbertextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CarSerialnumbertextBox.Size = new System.Drawing.Size(35, 22);
            this.CarSerialnumbertextBox.TabIndex = 95;
            // 
            // NumberPlate_nvctextBox
            // 
            this.NumberPlate_nvctextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvctextBox.Location = new System.Drawing.Point(56, 301);
            this.NumberPlate_nvctextBox.Name = "NumberPlate_nvctextBox";
            this.NumberPlate_nvctextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumberPlate_nvctextBox.Size = new System.Drawing.Size(83, 22);
            this.NumberPlate_nvctextBox.TabIndex = 94;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(38, 284);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(106, 14);
            this.label18.TabIndex = 93;
            this.label18.Text = "شماره پلاک سری :";
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(123, 107);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 90;
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
            this.TimeGroupBox.Location = new System.Drawing.Point(17, 120);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(124, 110);
            this.TimeGroupBox.TabIndex = 89;
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
            this.ShowButton.Location = new System.Drawing.Point(21, 515);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 72;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(102, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 49;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(102, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "از تاریخ :";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(13, 84);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(119, 20);
            this.ToDatefaDatePicker.TabIndex = 47;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(13, 35);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(119, 20);
            this.FromDatefaDatePicker.TabIndex = 46;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(173, 3);
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
            this.stiViewerControl1.Size = new System.Drawing.Size(733, 575);
            this.stiViewerControl1.TabIndex = 5;
            // 
            // DriverWithDuplicateCarReport
            // 
            this.DriverWithDuplicateCarReport.CookieContainer = null;
            this.DriverWithDuplicateCarReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.DriverWithDuplicateCarReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.DriverWithDuplicateCarReport.ReportAlias = "Report";
            this.DriverWithDuplicateCarReport.ReportGuid = "6c98adbcfef549aca237bafd289820f0";
            this.DriverWithDuplicateCarReport.ReportName = "Report";
            this.DriverWithDuplicateCarReport.ReportSource = resources.GetString("DriverWithDuplicateCarReport.ReportSource");
            this.DriverWithDuplicateCarReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.DriverWithDuplicateCarReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.DriverWithDuplicateCarReport.UseProgressInThread = false;
            // 
            // CarLadBillAndCancelAndTurnReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 581);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.uiPanel0);
            this.Name = "CarLadBillAndCancelAndTurnReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "گزارش تعداد مجوزهای صادر شده/نوبت های  ابطالی برای کامیون";
            this.Load += new System.EventHandler(this.CarLadeBillReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.StiReport CarLadeBillstiReport;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.TextBox CarSerialnumbertextBox;
        private System.Windows.Forms.TextBox NumberPlate_nvctextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CarCardNumber_nvctextBox;
        private System.Windows.Forms.Label label16;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox LaderTypecheckedComboBox;
        private System.Windows.Forms.Label label7;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private System.Windows.Forms.CheckBox DriverWithDuplicateCarCheckBox;
        private System.Windows.Forms.TextBox DriverCardNumber_nvcTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private Stimulsoft.Report.StiReport DriverWithDuplicateCarReport;
    }
}