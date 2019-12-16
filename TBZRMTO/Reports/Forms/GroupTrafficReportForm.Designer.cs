namespace HPS.Reports.Forms
{
    partial class GroupTrafficReportForm
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
            Janus.Windows.GridEX.GridEXLayout ServicescheckedComboBox_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupTrafficReportForm));
            Janus.Windows.GridEX.GridEXLayout LaderTypecheckedComboBox_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.ServicescheckedComboBox = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.LaderTypecheckedComboBox = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.FromTrafficNumbertxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ToTrafficNumbertxt = new System.Windows.Forms.TextBox();
            this.OutTrafficradioButton = new System.Windows.Forms.RadioButton();
            this.InTrafficradioButton = new System.Windows.Forms.RadioButton();
            this.uiButton1 = new Janus.Windows.EditControls.UIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupTrafficstiReport = new Stimulsoft.Report.StiReport();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("0e0bbecf-fc46-4dc9-825b-282c32768ca5");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("0e0bbecf-fc46-4dc9-825b-282c32768ca5"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(267, 687), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("0e0bbecf-fc46-4dc9-825b-282c32768ca5"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Margin = new System.Windows.Forms.Padding(4);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(267, 687);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.ServicescheckedComboBox);
            this.uiPanel0Container.Controls.Add(this.LaderTypecheckedComboBox);
            this.uiPanel0Container.Controls.Add(this.FromTrafficNumbertxt);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.label6);
            this.uiPanel0Container.Controls.Add(this.ToTrafficNumbertxt);
            this.uiPanel0Container.Controls.Add(this.OutTrafficradioButton);
            this.uiPanel0Container.Controls.Add(this.InTrafficradioButton);
            this.uiPanel0Container.Controls.Add(this.uiButton1);
            this.uiPanel0Container.Controls.Add(this.label8);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label7);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Margin = new System.Windows.Forms.Padding(4);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(261, 663);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(188, 110);
            this.DefaulCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(28, 28);
            this.DefaulCheckBox.TabIndex = 2;
            this.DefaulCheckBox.ToolTipText = "ساعات بین 00:00:00 و 23:59:59";
            this.DefaulCheckBox.CheckedChanged += new System.EventHandler(this.DefaulCheckBox_CheckedChanged);
            // 
            // ServicescheckedComboBox
            // 
            ServicescheckedComboBox_DesignTimeLayout.LayoutString = resources.GetString("ServicescheckedComboBox_DesignTimeLayout.LayoutString");
            this.ServicescheckedComboBox.DesignTimeLayout = ServicescheckedComboBox_DesignTimeLayout;
            this.ServicescheckedComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicescheckedComboBox.Location = new System.Drawing.Point(29, 464);
            this.ServicescheckedComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServicescheckedComboBox.Name = "ServicescheckedComboBox";
            this.ServicescheckedComboBox.SaveSettings = false;
            this.ServicescheckedComboBox.Size = new System.Drawing.Size(199, 26);
            this.ServicescheckedComboBox.TabIndex = 7;
            this.ServicescheckedComboBox.ValuesDataMember = null;
            this.ServicescheckedComboBox.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // LaderTypecheckedComboBox
            // 
            LaderTypecheckedComboBox_DesignTimeLayout.LayoutString = resources.GetString("LaderTypecheckedComboBox_DesignTimeLayout.LayoutString");
            this.LaderTypecheckedComboBox.DesignTimeLayout = LaderTypecheckedComboBox_DesignTimeLayout;
            this.LaderTypecheckedComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaderTypecheckedComboBox.Location = new System.Drawing.Point(29, 521);
            this.LaderTypecheckedComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LaderTypecheckedComboBox.Name = "LaderTypecheckedComboBox";
            this.LaderTypecheckedComboBox.SaveSettings = false;
            this.LaderTypecheckedComboBox.Size = new System.Drawing.Size(199, 26);
            this.LaderTypecheckedComboBox.TabIndex = 8;
            this.LaderTypecheckedComboBox.ValuesDataMember = null;
            this.LaderTypecheckedComboBox.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // FromTrafficNumbertxt
            // 
            this.FromTrafficNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTrafficNumbertxt.Location = new System.Drawing.Point(29, 343);
            this.FromTrafficNumbertxt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.FromTrafficNumbertxt.Name = "FromTrafficNumbertxt";
            this.FromTrafficNumbertxt.Size = new System.Drawing.Size(197, 26);
            this.FromTrafficNumbertxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(121, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 110;
            this.label5.Text = "از قبض شماره";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(121, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 111;
            this.label6.Text = "تا قبض شماره";
            // 
            // ToTrafficNumbertxt
            // 
            this.ToTrafficNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTrafficNumbertxt.Location = new System.Drawing.Point(29, 398);
            this.ToTrafficNumbertxt.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ToTrafficNumbertxt.Name = "ToTrafficNumbertxt";
            this.ToTrafficNumbertxt.Size = new System.Drawing.Size(197, 26);
            this.ToTrafficNumbertxt.TabIndex = 6;
            // 
            // OutTrafficradioButton
            // 
            this.OutTrafficradioButton.AutoSize = true;
            this.OutTrafficradioButton.Checked = true;
            this.OutTrafficradioButton.Location = new System.Drawing.Point(135, 289);
            this.OutTrafficradioButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.OutTrafficradioButton.Name = "OutTrafficradioButton";
            this.OutTrafficradioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutTrafficradioButton.Size = new System.Drawing.Size(58, 21);
            this.OutTrafficradioButton.TabIndex = 4;
            this.OutTrafficradioButton.TabStop = true;
            this.OutTrafficradioButton.Text = "خروج";
            this.OutTrafficradioButton.UseVisualStyleBackColor = true;
            // 
            // InTrafficradioButton
            // 
            this.InTrafficradioButton.AutoSize = true;
            this.InTrafficradioButton.Checked = true;
            this.InTrafficradioButton.Location = new System.Drawing.Point(140, 257);
            this.InTrafficradioButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.InTrafficradioButton.Name = "InTrafficradioButton";
            this.InTrafficradioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InTrafficradioButton.Size = new System.Drawing.Size(53, 21);
            this.InTrafficradioButton.TabIndex = 3;
            this.InTrafficradioButton.TabStop = true;
            this.InTrafficradioButton.Text = "ورود";
            this.InTrafficradioButton.UseVisualStyleBackColor = true;
            // 
            // uiButton1
            // 
            this.uiButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiButton1.Location = new System.Drawing.Point(67, 571);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(144, 36);
            this.uiButton1.TabIndex = 9;
            this.uiButton1.Text = "نمایش";
            this.uiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(151, 443);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 99;
            this.label8.Text = "مراجعه به";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(161, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 103;
            this.label2.Text = "تا تاریخ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(147, 500);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 96;
            this.label7.Text = " نوع بارگیر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(161, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 102;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(29, 27);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(199, 25);
            this.FromDatefaDatePicker.TabIndex = 0;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(29, 84);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(199, 25);
            this.ToDatefaDatePicker.TabIndex = 1;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.FromTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.RefreshHourbutton);
            this.TimeGroupBox.Controls.Add(this.label3);
            this.TimeGroupBox.Controls.Add(this.ToTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.label4);
            this.TimeGroupBox.Enabled = false;
            this.TimeGroupBox.Location = new System.Drawing.Point(45, 117);
            this.TimeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TimeGroupBox.Size = new System.Drawing.Size(165, 135);
            this.TimeGroupBox.TabIndex = 104;
            this.TimeGroupBox.TabStop = false;
            // 
            // FromTimeTextBox
            // 
            this.FromTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTimeTextBox.Location = new System.Drawing.Point(4, 25);
            this.FromTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FromTimeTextBox.Mask = "00:00:00";
            this.FromTimeTextBox.Name = "FromTimeTextBox";
            this.FromTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromTimeTextBox.Size = new System.Drawing.Size(79, 26);
            this.FromTimeTextBox.TabIndex = 0;
            this.FromTimeTextBox.Text = "000000";
            // 
            // RefreshHourbutton
            // 
            this.RefreshHourbutton.Image = global::HPS.Properties.Resources.Refresh16;
            this.RefreshHourbutton.Location = new System.Drawing.Point(4, 98);
            this.RefreshHourbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshHourbutton.Name = "RefreshHourbutton";
            this.RefreshHourbutton.Size = new System.Drawing.Size(32, 30);
            this.RefreshHourbutton.TabIndex = 2;
            this.RefreshHourbutton.UseVisualStyleBackColor = true;
            this.RefreshHourbutton.Click += new System.EventHandler(this.RefreshHourbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(81, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "از ساعت :";
            // 
            // ToTimeTextBox
            // 
            this.ToTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTimeTextBox.Location = new System.Drawing.Point(4, 65);
            this.ToTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ToTimeTextBox.Mask = "00:00:00";
            this.ToTimeTextBox.Name = "ToTimeTextBox";
            this.ToTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToTimeTextBox.Size = new System.Drawing.Size(79, 26);
            this.ToTimeTextBox.TabIndex = 1;
            this.ToTimeTextBox.Text = "235959";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(81, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "تا ساعت :";
            // 
            // GroupTrafficstiReport
            // 
            this.GroupTrafficstiReport.CookieContainer = null;
            this.GroupTrafficstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.GroupTrafficstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.GroupTrafficstiReport.ReportAlias = "Report";
            this.GroupTrafficstiReport.ReportGuid = "eb05292f0d824b279d1e15c61ed25a28";
            this.GroupTrafficstiReport.ReportImage = null;
            this.GroupTrafficstiReport.ReportName = "Report";
            this.GroupTrafficstiReport.ReportSource = resources.GetString("GroupTrafficstiReport.ReportSource");
            this.GroupTrafficstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.GroupTrafficstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.GroupTrafficstiReport.UseProgressInThread = false;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(270, 3);
            this.stiViewerControl1.Margin = new System.Windows.Forms.Padding(4);
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
            this.stiViewerControl1.Size = new System.Drawing.Size(1004, 687);
            this.stiViewerControl1.TabIndex = 6;
            // 
            // GroupTrafficReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 693);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GroupTrafficReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "گزارش ورودی و خروجی";
            this.Load += new System.EventHandler(this.GroupTrafficReportForm_Load);
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

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UIButton uiButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Stimulsoft.Report.StiReport GroupTrafficstiReport;
        private System.Windows.Forms.RadioButton OutTrafficradioButton;
        private System.Windows.Forms.RadioButton InTrafficradioButton;
        private System.Windows.Forms.TextBox FromTrafficNumbertxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ToTrafficNumbertxt;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox LaderTypecheckedComboBox;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox ServicescheckedComboBox;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}