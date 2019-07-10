namespace HPS.Reports.Forms
{
    partial class TrafficPictures
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
            Janus.Windows.GridEX.GridEXLayout TrafficPicturesGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficPictures));
            Janus.Windows.GridEX.GridEXLayout InOutTimesGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.TrafficPicturesGridView = new Janus.Windows.GridEX.GridEX();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InOutTimesGrid = new Janus.Windows.GridEX.GridEX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TrafficPicturesToolStrip = new System.Windows.Forms.ToolStrip();
            this.InOutToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficPicturesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InOutTimesGrid)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanelManager1.UseCompatibleTextRendering = false;
            this.uiPanel0.Id = new System.Guid("8af8f342-fb6d-4a2e-a968-4482950c630d");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("8af8f342-fb6d-4a2e-a968-4482950c630d"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(135, 309), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("8af8f342-fb6d-4a2e-a968-4482950c630d"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.CaptionDisplayMode = Janus.Windows.UI.Dock.PanelCaptionDisplayMode.Image;
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(135, 309);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Panel 0";
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 29);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(129, 279);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(100, 107);
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
            this.TimeGroupBox.Location = new System.Drawing.Point(2, 107);
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
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(14, 233);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 6;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(77, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(77, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(5, 30);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(118, 20);
            this.FromDatefaDatePicker.TabIndex = 0;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(5, 86);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(118, 20);
            this.ToDatefaDatePicker.TabIndex = 1;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // TrafficPicturesGridView
            // 
            this.TrafficPicturesGridView.AlternatingColors = true;
            this.TrafficPicturesGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.TrafficPicturesGridView.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>ستون ه" +
    "ا را برای گزوه بندی کشیده و در این قسمت رها کنید</GroupByBoxInfo></LocalizableDa" +
    "ta>";
            TrafficPicturesGridView_DesignTimeLayout.LayoutString = resources.GetString("TrafficPicturesGridView_DesignTimeLayout.LayoutString");
            this.TrafficPicturesGridView.DesignTimeLayout = TrafficPicturesGridView_DesignTimeLayout;
            this.TrafficPicturesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficPicturesGridView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficPicturesGridView.GroupByBoxVisible = false;
            this.TrafficPicturesGridView.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.TrafficPicturesGridView.Location = new System.Drawing.Point(0, 25);
            this.TrafficPicturesGridView.Margin = new System.Windows.Forms.Padding(5);
            this.TrafficPicturesGridView.Name = "TrafficPicturesGridView";
            this.TrafficPicturesGridView.Size = new System.Drawing.Size(471, 284);
            this.TrafficPicturesGridView.TabIndex = 14;
            this.TrafficPicturesGridView.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.Location = new System.Drawing.Point(0, 315);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1026, 285);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "عکس";
            // 
            // InOutTimesGrid
            // 
            this.InOutTimesGrid.AlternatingColors = true;
            this.InOutTimesGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.InOutTimesGrid.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>ستون ه" +
    "ا را برای گزوه بندی کشیده و در این قسمت رها کنید</GroupByBoxInfo></LocalizableDa" +
    "ta>";
            InOutTimesGrid_DesignTimeLayout.LayoutString = resources.GetString("InOutTimesGrid_DesignTimeLayout.LayoutString");
            this.InOutTimesGrid.DesignTimeLayout = InOutTimesGrid_DesignTimeLayout;
            this.InOutTimesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InOutTimesGrid.Font = new System.Drawing.Font("Tahoma", 9F);
            this.InOutTimesGrid.GroupByBoxVisible = false;
            this.InOutTimesGrid.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.InOutTimesGrid.Location = new System.Drawing.Point(0, 25);
            this.InOutTimesGrid.Margin = new System.Windows.Forms.Padding(5);
            this.InOutTimesGrid.Name = "InOutTimesGrid";
            this.InOutTimesGrid.Size = new System.Drawing.Size(410, 284);
            this.InOutTimesGrid.TabIndex = 25;
            this.InOutTimesGrid.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.InOutTimesGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.InOutTimesGrid_RowDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(138, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TrafficPicturesGridView);
            this.splitContainer1.Panel1.Controls.Add(this.TrafficPicturesToolStrip);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.InOutTimesGrid);
            this.splitContainer1.Panel2.Controls.Add(this.InOutToolStrip);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(885, 309);
            this.splitContainer1.SplitterDistance = 471;
            this.splitContainer1.TabIndex = 26;
            // 
            // TrafficPicturesToolStrip
            // 
            this.TrafficPicturesToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrafficPicturesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TrafficPicturesToolStrip.Name = "TrafficPicturesToolStrip";
            this.TrafficPicturesToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TrafficPicturesToolStrip.Size = new System.Drawing.Size(471, 25);
            this.TrafficPicturesToolStrip.TabIndex = 15;
            // 
            // InOutToolStrip
            // 
            this.InOutToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InOutToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InOutToolStrip.Name = "InOutToolStrip";
            this.InOutToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InOutToolStrip.Size = new System.Drawing.Size(410, 25);
            this.InOutToolStrip.TabIndex = 26;
            // 
            // TrafficPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1026, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.pictureBox);
            this.Name = "TrafficPictures";
            this.Text = "تصاویر ترددها";
            this.Load += new System.EventHandler(this.TrafficPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficPicturesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InOutTimesGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private Janus.Windows.GridEX.GridEX TrafficPicturesGridView;
        internal System.Windows.Forms.PictureBox pictureBox;
        private Janus.Windows.GridEX.GridEX InOutTimesGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip TrafficPicturesToolStrip;
        private System.Windows.Forms.ToolStrip InOutToolStrip;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
    }
}