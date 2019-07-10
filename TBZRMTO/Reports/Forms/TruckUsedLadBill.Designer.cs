namespace HPS.Reports.ReportDoc
{
    partial class TruckUsedLadBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckUsedLadBill));
            this.AllTrafficToolStrip = new System.Windows.Forms.ToolStrip();
            this.PrintstripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.AllTrafficToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTrafficToolStrip
            // 
            this.AllTrafficToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.AllTrafficToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintstripButton,
            this.ExportButton,
            this.CloseButton});
            this.AllTrafficToolStrip.Location = new System.Drawing.Point(0, 0);
            this.AllTrafficToolStrip.Name = "AllTrafficToolStrip";
            this.AllTrafficToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.AllTrafficToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllTrafficToolStrip.Size = new System.Drawing.Size(897, 31);
            this.AllTrafficToolStrip.TabIndex = 43;
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
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("891e9863-b103-4611-b5f1-7f8862e75206");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("891e9863-b103-4611-b5f1-7f8862e75206"), Janus.Windows.UI.Dock.PanelDockStyle.Right, new System.Drawing.Size(152, 415), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("891e9863-b103-4611-b5f1-7f8862e75206"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(742, 34);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiPanel0.Size = new System.Drawing.Size(152, 415);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Panel 0";
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(5, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(146, 391);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.IgnoreApplyStyle = false;
            this.stiViewerControl1.Location = new System.Drawing.Point(3, 34);
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
            this.stiViewerControl1.Size = new System.Drawing.Size(739, 415);
            this.stiViewerControl1.TabIndex = 44;
            // 
            // TruckUsedLadBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 452);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.AllTrafficToolStrip);
            this.Name = "TruckUsedLadBill";
            this.Text = "TruckUsedLadBill";
            this.Load += new System.EventHandler(this.TruckUsedLadBill_Load);
            this.AllTrafficToolStrip.ResumeLayout(false);
            this.AllTrafficToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip AllTrafficToolStrip;
        private System.Windows.Forms.ToolStripButton PrintstripButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}