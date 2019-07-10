namespace HPS.Reports.Forms
{
    partial class CarAllTrafficForm
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
            Janus.Windows.GridEX.GridEXLayout CarAllTrafficfoGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarAllTrafficForm));
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CarCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.PrintstripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.CarAllTrafficfoGridView = new Janus.Windows.GridEX.GridEX();
            this.CarAllTrafficstiReport = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarAllTrafficfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(41, 138);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvcTextBox.MaxLength = 25;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(84, 22);
            this.NumberPlate_nvcTextBox.TabIndex = 0;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(52, 110);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 14);
            this.label15.TabIndex = 20;
            this.label15.Text = "شماره پلاك :";
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SerialPlate_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(10, 138);
            this.SerialPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialPlate_nvcTextBox.MaxLength = 3;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(30, 22);
            this.SerialPlate_nvcTextBox.TabIndex = 4;
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CarCardNumber_nvcTextBox
            // 
            this.CarCardNumber_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CarCardNumber_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarCardNumber_nvcTextBox.Location = new System.Drawing.Point(13, 208);
            this.CarCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarCardNumber_nvcTextBox.MaxLength = 10;
            this.CarCardNumber_nvcTextBox.Name = "CarCardNumber_nvcTextBox";
            this.CarCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardNumber_nvcTextBox.Size = new System.Drawing.Size(112, 22);
            this.CarCardNumber_nvcTextBox.TabIndex = 1;
            this.CarCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(1, 174);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 14);
            this.label14.TabIndex = 25;
            this.label14.Text = "شماره كارت هوشمند :";
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("27d1f25c-35f1-4bb7-b1f1-146afc74ee32");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("27d1f25c-35f1-4bb7-b1f1-146afc74ee32"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 525), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("27d1f25c-35f1-4bb7-b1f1-146afc74ee32"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(135, 525);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label15);
            this.uiPanel0Container.Controls.Add(this.NumberPlate_nvcTextBox);
            this.uiPanel0Container.Controls.Add(this.SerialPlate_nvcTextBox);
            this.uiPanel0Container.Controls.Add(this.CarCardNumber_nvcTextBox);
            this.uiPanel0Container.Controls.Add(this.label14);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 495);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(10, 249);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 39;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(77, 62);
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
            this.label1.Location = new System.Drawing.Point(77, 9);
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
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(10, 29);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.FromDatefaDatePicker.TabIndex = 35;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(10, 81);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(115, 20);
            this.ToDatefaDatePicker.TabIndex = 36;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintstripButton,
            this.ExportButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(984, 31);
            this.AllTrafficToolStrip.TabIndex = 41;
            // 
            // PrintstripButton
            // 
            this.PrintstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintstripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintstripButton.Image")));
            this.PrintstripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintstripButton.Name = "PrintstripButton";
            this.PrintstripButton.Size = new System.Drawing.Size(28, 28);
            this.PrintstripButton.Text = "چاپ";
            this.PrintstripButton.Click += new System.EventHandler(this.PrintstripButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(28, 28);
            this.ExportButton.Text = "خروجی اکسل";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(138, 34);
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
            this.stiViewerControl1.Size = new System.Drawing.Size(843, 525);
            this.stiViewerControl1.TabIndex = 43;
            // 
            // CarAllTrafficfoGridView
            // 
            this.CarAllTrafficfoGridView.AlternatingColors = true;
            this.CarAllTrafficfoGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            CarAllTrafficfoGridView_DesignTimeLayout.LayoutString = resources.GetString("CarAllTrafficfoGridView_DesignTimeLayout.LayoutString");
            this.CarAllTrafficfoGridView.DesignTimeLayout = CarAllTrafficfoGridView_DesignTimeLayout;
            this.CarAllTrafficfoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarAllTrafficfoGridView.GroupByBoxVisible = false;
            this.CarAllTrafficfoGridView.Location = new System.Drawing.Point(138, 34);
            this.CarAllTrafficfoGridView.Name = "CarAllTrafficfoGridView";
            this.CarAllTrafficfoGridView.Size = new System.Drawing.Size(843, 525);
            this.CarAllTrafficfoGridView.TabIndex = 42;
            this.CarAllTrafficfoGridView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.CarAllTrafficfoGridView.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.CarAllTrafficfoGridView_FormattingRow);
            // 
            // CarAllTrafficstiReport
            // 
            this.CarAllTrafficstiReport.CookieContainer = null;
            this.CarAllTrafficstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.CarAllTrafficstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.CarAllTrafficstiReport.ReportAlias = "Report";
            this.CarAllTrafficstiReport.ReportGuid = "5ea743a9f6d64ccda34837e7eaf6f6a4";
            this.CarAllTrafficstiReport.ReportName = "Report";
            this.CarAllTrafficstiReport.ReportSource = resources.GetString("CarAllTrafficstiReport.ReportSource");
            this.CarAllTrafficstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.CarAllTrafficstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.CarAllTrafficstiReport.UseProgressInThread = false;
            // 
            // CarAllTrafficForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.CarAllTrafficfoGridView);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CarAllTrafficForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کارکرد کامیون ";
            this.Load += new System.EventHandler(this.CarAllTrafficForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarAllTrafficfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
        private System.Windows.Forms.TextBox CarCardNumber_nvcTextBox;
        private System.Windows.Forms.Label label14;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrintstripButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private Janus.Windows.GridEX.GridEX CarAllTrafficfoGridView;
        private Stimulsoft.Report.StiReport CarAllTrafficstiReport;
    }
}