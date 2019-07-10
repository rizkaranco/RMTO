namespace HPS.Reports.Forms
{
    partial class ServiceStatusReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceStatusReportForm));
            Janus.Windows.GridEX.GridEXLayout ServiceStatusGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.ServiceStatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.TurnPrintButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ServiceStatusGrid = new Janus.Windows.GridEX.GridEX();
            this.ServiceStatusToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceStatusGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceStatusToolStrip
            // 
            this.ServiceStatusToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ServiceStatusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.ExportButton,
            this.toolStripSeparator1,
            this.CloseButton});
            this.ServiceStatusToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ServiceStatusToolStrip.Name = "ServiceStatusToolStrip";
            this.ServiceStatusToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ServiceStatusToolStrip.Size = new System.Drawing.Size(851, 31);
            this.ServiceStatusToolStrip.TabIndex = 0;
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
            this.ExportButton.Text = "خروجی به Excel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // CloseButton
            // 
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = global::HPS.Properties.Resources.Close;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 28);
            this.CloseButton.Text = "بستن";
            this.CloseButton.Click += new System.EventHandler(this.ClosetoolStripButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = global::HPS.Properties.Resources.Print;
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(28, 28);
            this.PrintButton.Text = "چاپ ";
            // 
            // TurnPrintButton
            // 
            this.TurnPrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TurnPrintButton.Image = ((System.Drawing.Image)(resources.GetObject("TurnPrintButton.Image")));
            this.TurnPrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TurnPrintButton.Name = "TurnPrintButton";
            this.TurnPrintButton.Size = new System.Drawing.Size(28, 28);
            this.TurnPrintButton.Text = "چاپ مجدد قبض تأييد نوبت";
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
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("9e453710-0908-4b61-b84a-050f2db9a42f");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("9e453710-0908-4b61-b84a-050f2db9a42f"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 535), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("9e453710-0908-4b61-b84a-050f2db9a42f"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.AllowPanelDrag = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.AllowPanelDrop = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.AllowResize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.CaptionDisplayMode = Janus.Windows.UI.Dock.PanelCaptionDisplayMode.Text;
            this.uiPanel0.CaptionDoubleClickAction = Janus.Windows.UI.Dock.CaptionDoubleClickAction.None;
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 34);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(135, 535);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.ServiceComboBox);
            this.uiPanel0Container.Controls.Add(this.label8);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label9);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 505);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(100, 174);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(16, 23);
            this.DefaulCheckBox.TabIndex = 92;
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
            this.TimeGroupBox.Location = new System.Drawing.Point(2, 174);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(124, 110);
            this.TimeGroupBox.TabIndex = 91;
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
            this.RefreshHourbutton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(8, 298);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 47;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Items.AddRange(new object[] {
            "کنترل تردد",
            "اس ام اس"});
            this.ServiceComboBox.Location = new System.Drawing.Point(2, 40);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(125, 22);
            this.ServiceComboBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(78, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "تا تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "سرویس :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(78, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 42;
            this.label9.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(5, 92);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(119, 20);
            this.FromDatefaDatePicker.TabIndex = 37;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(5, 148);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(119, 20);
            this.ToDatefaDatePicker.TabIndex = 38;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ServiceStatusGrid
            // 
            this.ServiceStatusGrid.AlternatingColors = true;
            this.ServiceStatusGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.ServiceStatusGrid.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>ستون ه" +
    "ا را برای گزوه بندی کشیده و در این قسمت رها کنید</GroupByBoxInfo></LocalizableDa" +
    "ta>";
            ServiceStatusGrid_DesignTimeLayout.LayoutString = resources.GetString("ServiceStatusGrid_DesignTimeLayout.LayoutString");
            this.ServiceStatusGrid.DesignTimeLayout = ServiceStatusGrid_DesignTimeLayout;
            this.ServiceStatusGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceStatusGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ServiceStatusGrid.GroupByBoxVisible = false;
            this.ServiceStatusGrid.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.ServiceStatusGrid.Location = new System.Drawing.Point(138, 34);
            this.ServiceStatusGrid.Margin = new System.Windows.Forms.Padding(5);
            this.ServiceStatusGrid.Name = "ServiceStatusGrid";
            this.ServiceStatusGrid.Size = new System.Drawing.Size(710, 535);
            this.ServiceStatusGrid.TabIndex = 46;
            this.ServiceStatusGrid.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ServiceStatusReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 572);
            this.Controls.Add(this.ServiceStatusGrid);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.ServiceStatusToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17);
            this.Name = "ServiceStatusReportForm";
            this.Text = "لیست وضعیت سرویس ها";
            this.Load += new System.EventHandler(this.ServiceStatusReportForm_Load);
            this.ServiceStatusToolStrip.ResumeLayout(false);
            this.ServiceStatusToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceStatusGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ServiceStatusToolStrip;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.ToolStripButton TurnPrintButton;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.GridEX.GridEX ServiceStatusGrid;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
    }
}