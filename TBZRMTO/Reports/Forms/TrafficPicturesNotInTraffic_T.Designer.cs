namespace HPS.Reports.Forms
{
    partial class TrafficPicturesNotInTraffic_T
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
            Janus.Windows.GridEX.GridEXLayout InOutTimesGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout TrafficPicturesGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficPicturesNotInTraffic_T));
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InOutTimesGrid = new Janus.Windows.GridEX.GridEX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TrafficPicturesToolStrip = new System.Windows.Forms.ToolStrip();
            this.InOutToolStrip = new System.Windows.Forms.ToolStrip();
            this.TrafficPicturesGridView = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InOutTimesGrid)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficPicturesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.Location = new System.Drawing.Point(0, 344);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(990, 220);
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
            this.InOutTimesGrid.Location = new System.Drawing.Point(0, 25);
            this.InOutTimesGrid.Margin = new System.Windows.Forms.Padding(5);
            this.InOutTimesGrid.Name = "InOutTimesGrid";
            this.InOutTimesGrid.Size = new System.Drawing.Size(432, 313);
            this.InOutTimesGrid.TabIndex = 25;
            this.InOutTimesGrid.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
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
            this.splitContainer1.Size = new System.Drawing.Size(984, 338);
            this.splitContainer1.SplitterDistance = 548;
            this.splitContainer1.TabIndex = 26;
            // 
            // TrafficPicturesToolStrip
            // 
            this.TrafficPicturesToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrafficPicturesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TrafficPicturesToolStrip.Name = "TrafficPicturesToolStrip";
            this.TrafficPicturesToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TrafficPicturesToolStrip.Size = new System.Drawing.Size(548, 25);
            this.TrafficPicturesToolStrip.TabIndex = 15;
            // 
            // InOutToolStrip
            // 
            this.InOutToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InOutToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InOutToolStrip.Name = "InOutToolStrip";
            this.InOutToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InOutToolStrip.Size = new System.Drawing.Size(432, 25);
            this.InOutToolStrip.TabIndex = 26;
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
            this.TrafficPicturesGridView.Size = new System.Drawing.Size(548, 313);
            this.TrafficPicturesGridView.TabIndex = 16;
            this.TrafficPicturesGridView.VisualStyleAreas.HeadersStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // TrafficPicturesNotInTraffic_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 564);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox);
            this.Name = "TrafficPicturesNotInTraffic_T";
            this.Text = "تصاویر ترددها";
            this.Load += new System.EventHandler(this.TrafficPicturesNotInTraffic_T_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InOutTimesGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrafficPicturesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        internal System.Windows.Forms.PictureBox pictureBox;
        private Janus.Windows.GridEX.GridEX InOutTimesGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip TrafficPicturesToolStrip;
        private System.Windows.Forms.ToolStrip InOutToolStrip;
        private Janus.Windows.GridEX.GridEX TrafficPicturesGridView;
    }
}