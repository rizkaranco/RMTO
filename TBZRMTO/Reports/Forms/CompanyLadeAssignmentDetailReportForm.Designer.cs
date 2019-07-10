namespace HPS.Reports.Forms
{
    partial class CompanyLadeAssignmentDetailReportForm
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
            Janus.Windows.GridEX.GridEXLayout destinationCityGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyLadeAssignmentDetailReportForm));
            Janus.Windows.GridEX.GridEXLayout portPlaceGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout goodGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout laderTypeGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout companyGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.destinationCityGrid = new Janus.Windows.GridEX.GridEX();
            this.portPlaceGrid = new Janus.Windows.GridEX.GridEX();
            this.goodGrid = new Janus.Windows.GridEX.GridEX();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.laderTypeGrid = new Janus.Windows.GridEX.GridEX();
            this.companyGrid = new Janus.Windows.GridEX.GridEX();
            this.CompanyLadeAssignmentDetailReportstiReport = new Stimulsoft.Report.StiReport();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.groupBox1.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationCityGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portPlaceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laderTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(1099, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(1100, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "تا تاریخ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowButton);
            this.groupBox1.Controls.Add(this.ToDatefaDatePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DefaulCheckBox);
            this.groupBox1.Controls.Add(this.TimeGroupBox);
            this.groupBox1.Controls.Add(this.destinationCityGrid);
            this.groupBox1.Controls.Add(this.portPlaceGrid);
            this.groupBox1.Controls.Add(this.goodGrid);
            this.groupBox1.Controls.Add(this.FromDatefaDatePicker);
            this.groupBox1.Controls.Add(this.laderTypeGrid);
            this.groupBox1.Controls.Add(this.companyGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1179, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(10, 71);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 72;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(995, 31);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(105, 20);
            this.ToDatefaDatePicker.TabIndex = 2;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(1123, 45);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 71;
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
            this.TimeGroupBox.Location = new System.Drawing.Point(994, 45);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(154, 57);
            this.TimeGroupBox.TabIndex = 70;
            this.TimeGroupBox.TabStop = false;
            // 
            // FromTimeTextBox
            // 
            this.FromTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTimeTextBox.Location = new System.Drawing.Point(34, 10);
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
            this.RefreshHourbutton.Location = new System.Drawing.Point(8, 31);
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
            this.label3.Location = new System.Drawing.Point(92, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 65;
            this.label3.Text = "از ساعت :";
            // 
            // ToTimeTextBox
            // 
            this.ToTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTimeTextBox.Location = new System.Drawing.Point(34, 32);
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
            this.label4.Location = new System.Drawing.Point(92, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "تا ساعت :";
            // 
            // destinationCityGrid
            // 
            this.destinationCityGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.destinationCityGrid.AlternatingColors = true;
            this.destinationCityGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            destinationCityGrid_DesignTimeLayout.LayoutString = resources.GetString("destinationCityGrid_DesignTimeLayout.LayoutString");
            this.destinationCityGrid.DesignTimeLayout = destinationCityGrid_DesignTimeLayout;
            this.destinationCityGrid.DynamicFiltering = true;
            this.destinationCityGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.destinationCityGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.destinationCityGrid.GroupByBoxVisible = false;
            this.destinationCityGrid.Location = new System.Drawing.Point(127, 15);
            this.destinationCityGrid.Name = "destinationCityGrid";
            this.destinationCityGrid.Size = new System.Drawing.Size(174, 88);
            this.destinationCityGrid.TabIndex = 8;
            // 
            // portPlaceGrid
            // 
            this.portPlaceGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.portPlaceGrid.AlternatingColors = true;
            this.portPlaceGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            portPlaceGrid_DesignTimeLayout.LayoutString = resources.GetString("portPlaceGrid_DesignTimeLayout.LayoutString");
            this.portPlaceGrid.DesignTimeLayout = portPlaceGrid_DesignTimeLayout;
            this.portPlaceGrid.DynamicFiltering = true;
            this.portPlaceGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.portPlaceGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.portPlaceGrid.GroupByBoxVisible = false;
            this.portPlaceGrid.Location = new System.Drawing.Point(307, 15);
            this.portPlaceGrid.Name = "portPlaceGrid";
            this.portPlaceGrid.Size = new System.Drawing.Size(174, 88);
            this.portPlaceGrid.TabIndex = 7;
            // 
            // goodGrid
            // 
            this.goodGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.goodGrid.AlternatingColors = true;
            this.goodGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            goodGrid_DesignTimeLayout.LayoutString = resources.GetString("goodGrid_DesignTimeLayout.LayoutString");
            this.goodGrid.DesignTimeLayout = goodGrid_DesignTimeLayout;
            this.goodGrid.DynamicFiltering = true;
            this.goodGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.goodGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.goodGrid.GroupByBoxVisible = false;
            this.goodGrid.Location = new System.Drawing.Point(487, 15);
            this.goodGrid.Name = "goodGrid";
            this.goodGrid.Size = new System.Drawing.Size(142, 88);
            this.goodGrid.TabIndex = 6;
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(994, 10);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(105, 20);
            this.FromDatefaDatePicker.TabIndex = 0;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // laderTypeGrid
            // 
            this.laderTypeGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.laderTypeGrid.AlternatingColors = true;
            this.laderTypeGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            laderTypeGrid_DesignTimeLayout.LayoutString = resources.GetString("laderTypeGrid_DesignTimeLayout.LayoutString");
            this.laderTypeGrid.DesignTimeLayout = laderTypeGrid_DesignTimeLayout;
            this.laderTypeGrid.DynamicFiltering = true;
            this.laderTypeGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.laderTypeGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.laderTypeGrid.GroupByBoxVisible = false;
            this.laderTypeGrid.Location = new System.Drawing.Point(635, 15);
            this.laderTypeGrid.Name = "laderTypeGrid";
            this.laderTypeGrid.Size = new System.Drawing.Size(174, 88);
            this.laderTypeGrid.TabIndex = 5;
            // 
            // companyGrid
            // 
            this.companyGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.companyGrid.AlternatingColors = true;
            this.companyGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            companyGrid_DesignTimeLayout.LayoutString = resources.GetString("companyGrid_DesignTimeLayout.LayoutString");
            this.companyGrid.DesignTimeLayout = companyGrid_DesignTimeLayout;
            this.companyGrid.DynamicFiltering = true;
            this.companyGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.companyGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.companyGrid.GroupByBoxVisible = false;
            this.companyGrid.Location = new System.Drawing.Point(815, 12);
            this.companyGrid.Name = "companyGrid";
            this.companyGrid.Size = new System.Drawing.Size(174, 88);
            this.companyGrid.TabIndex = 4;
            // 
            // CompanyLadeAssignmentDetailReportstiReport
            // 
            this.CompanyLadeAssignmentDetailReportstiReport.CookieContainer = null;
            this.CompanyLadeAssignmentDetailReportstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.CompanyLadeAssignmentDetailReportstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.CompanyLadeAssignmentDetailReportstiReport.ReportAlias = "Report";
            this.CompanyLadeAssignmentDetailReportstiReport.ReportGuid = "60d10a5f763b49adb0ab6faae5032976";
            this.CompanyLadeAssignmentDetailReportstiReport.ReportName = "Report";
            this.CompanyLadeAssignmentDetailReportstiReport.ReportSource = resources.GetString("CompanyLadeAssignmentDetailReportstiReport.ReportSource");
            this.CompanyLadeAssignmentDetailReportstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.CompanyLadeAssignmentDetailReportstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.CompanyLadeAssignmentDetailReportstiReport.UseProgressInThread = false;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(0, 106);
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
            this.stiViewerControl1.Size = new System.Drawing.Size(1179, 456);
            this.stiViewerControl1.TabIndex = 4;
            // 
            // CompanyLadeAssignmentDetailReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 562);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "CompanyLadeAssignmentDetailReportForm";
            this.Text = "گزارش انجمن صنفی شرکتها و مؤسسات";
            this.Load += new System.EventHandler(this.CompanyLadeAssignmentDetailReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationCityGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portPlaceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laderTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Janus.Windows.GridEX.GridEX companyGrid;
        private Janus.Windows.GridEX.GridEX laderTypeGrid;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.GridEX.GridEX goodGrid;
        private Janus.Windows.GridEX.GridEX portPlaceGrid;
        private Janus.Windows.GridEX.GridEX destinationCityGrid;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private Stimulsoft.Report.StiReport CompanyLadeAssignmentDetailReportstiReport;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}