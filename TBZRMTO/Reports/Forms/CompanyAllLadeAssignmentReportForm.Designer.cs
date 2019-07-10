namespace HPS.Reports.Forms
{
    partial class CompanyAllLadeAssignmentedReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyAllLadeAssignmentedReport));
            this.CompanyID_intShowButton = new System.Windows.Forms.Button();
            this.CompanyID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.CompanyAllLadeAssignmentedstiReport = new Stimulsoft.Report.StiReport();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyID_intShowButton
            // 
            this.CompanyID_intShowButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CompanyID_intShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompanyID_intShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyID_intShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyID_intShowButton.Location = new System.Drawing.Point(9, 112);
            this.CompanyID_intShowButton.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intShowButton.Name = "CompanyID_intShowButton";
            this.CompanyID_intShowButton.Size = new System.Drawing.Size(32, 31);
            this.CompanyID_intShowButton.TabIndex = 3;
            this.CompanyID_intShowButton.TabStop = false;
            this.CompanyID_intShowButton.UseVisualStyleBackColor = true;
            this.CompanyID_intShowButton.Click += new System.EventHandler(this.CompanyID_intShowButton_Click);
            // 
            // CompanyID_intComboBox
            // 
            this.CompanyID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyID_intComboBox.FormattingEnabled = true;
            this.CompanyID_intComboBox.Location = new System.Drawing.Point(5, 148);
            this.CompanyID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intComboBox.Name = "CompanyID_intComboBox";
            this.CompanyID_intComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanyID_intComboBox.Size = new System.Drawing.Size(121, 22);
            this.CompanyID_intComboBox.TabIndex = 2;
            this.CompanyID_intComboBox.SelectedValueChanged += new System.EventHandler(this.CompanyID_intComboBox_SelectedValueChanged);
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyID_intLabel.Location = new System.Drawing.Point(76, 120);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(49, 14);
            this.CompanyID_intLabel.TabIndex = 28;
            this.CompanyID_intLabel.Text = "شرکت :";
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("5e44682a-50d6-41c2-a6cf-166a95c6b414");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("5e44682a-50d6-41c2-a6cf-166a95c6b414"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 556), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("5e44682a-50d6-41c2-a6cf-166a95c6b414"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
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
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.CompanyID_intShowButton);
            this.uiPanel0Container.Controls.Add(this.CompanyID_intComboBox);
            this.uiPanel0Container.Controls.Add(this.CompanyID_intLabel);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 526);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(78, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(5, 32);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(121, 20);
            this.FromDatefaDatePicker.TabIndex = 35;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(5, 84);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(121, 20);
            this.ToDatefaDatePicker.TabIndex = 36;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(11, 194);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 29;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // CompanyAllLadeAssignmentedstiReport
            // 
            this.CompanyAllLadeAssignmentedstiReport.CookieContainer = null;
            this.CompanyAllLadeAssignmentedstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.CompanyAllLadeAssignmentedstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.CompanyAllLadeAssignmentedstiReport.ReportAlias = "Report";
            this.CompanyAllLadeAssignmentedstiReport.ReportGuid = "4c87b63b93fd4badb7d792ca043e77c7";
            this.CompanyAllLadeAssignmentedstiReport.ReportImage = null;
            this.CompanyAllLadeAssignmentedstiReport.ReportName = "Report";
            this.CompanyAllLadeAssignmentedstiReport.ReportSource = resources.GetString("CompanyAllLadeAssignmentedstiReport.ReportSource");
            this.CompanyAllLadeAssignmentedstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.CompanyAllLadeAssignmentedstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.CompanyAllLadeAssignmentedstiReport.UseProgressInThread = false;
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
            this.stiViewerControl1.TabIndex = 5;
            // 
            // CompanyAllLadeAssignmentedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CompanyAllLadeAssignmentedReport";
            this.Text = "اطلاع رسانی بار توسط شرکت";
            this.Load += new System.EventHandler(this.OutTrafficReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CompanyID_intShowButton;
        private System.Windows.Forms.ComboBox CompanyID_intComboBox;
        private System.Windows.Forms.Label CompanyID_intLabel;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Stimulsoft.Report.StiReport CompanyAllLadeAssignmentedstiReport;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}