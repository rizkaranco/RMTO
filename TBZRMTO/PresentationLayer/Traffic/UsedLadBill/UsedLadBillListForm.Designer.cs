namespace HPS.Present.UsedLadBill
    {
    partial class UsedLadBillListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsedLadBillListForm));
            Janus.Windows.GridEX.GridEXLayout LadBillWithTrafficGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout CompanyLadBillGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.UsedLadBillToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.UsedLadBillStripButton = new System.Windows.Forms.ToolStripButton();
            this.LadBillWithTrafficGridView = new Janus.Windows.GridEX.GridEX();
            this.CompanyLadBillToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshCmpanyLadBillButton = new System.Windows.Forms.ToolStripButton();
            this.CompanyLadBillGridView = new Janus.Windows.GridEX.GridEX();
            this.UsedLadBillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadBillWithTrafficGridView)).BeginInit();
            this.CompanyLadBillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLadBillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.Text = "حذف";
            // 
            // UsedLadBillToolStrip
            // 
            this.UsedLadBillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.UsedLadBillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteButton,
            this.RefreshButton,
            this.UsedLadBillStripButton});
            this.UsedLadBillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.UsedLadBillToolStrip.Name = "UsedLadBillToolStrip";
            this.UsedLadBillToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.UsedLadBillToolStrip.Size = new System.Drawing.Size(842, 31);
            this.UsedLadBillToolStrip.TabIndex = 1;
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
            // UsedLadBillStripButton
            // 
            this.UsedLadBillStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UsedLadBillStripButton.Image = global::HPS.Properties.Resources.ConfirmVoucher;
            this.UsedLadBillStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsedLadBillStripButton.Name = "UsedLadBillStripButton";
            this.UsedLadBillStripButton.Size = new System.Drawing.Size(28, 28);
            this.UsedLadBillStripButton.Text = "بارنامه های استفاده شده";
            this.UsedLadBillStripButton.Click += new System.EventHandler(this.UsedLadBillToolStripButton_Click);
            // 
            // LadBillWithTrafficGridView
            // 
            this.LadBillWithTrafficGridView.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.LadBillWithTrafficGridView.AlternatingColors = true;
            this.LadBillWithTrafficGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            LadBillWithTrafficGridView_DesignTimeLayout.LayoutString = resources.GetString("LadBillWithTrafficGridView_DesignTimeLayout.LayoutString");
            this.LadBillWithTrafficGridView.DesignTimeLayout = LadBillWithTrafficGridView_DesignTimeLayout;
            this.LadBillWithTrafficGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.LadBillWithTrafficGridView.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.LadBillWithTrafficGridView.GroupByBoxVisible = false;
            this.LadBillWithTrafficGridView.Location = new System.Drawing.Point(0, 31);
            this.LadBillWithTrafficGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LadBillWithTrafficGridView.Name = "LadBillWithTrafficGridView";
            this.LadBillWithTrafficGridView.Size = new System.Drawing.Size(842, 278);
            this.LadBillWithTrafficGridView.TabIndex = 4;
            this.LadBillWithTrafficGridView.SelectionChanged += new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);
            // 
            // CompanyLadBillToolStrip
            // 
            this.CompanyLadBillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CompanyLadBillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshCmpanyLadBillButton});
            this.CompanyLadBillToolStrip.Location = new System.Drawing.Point(0, 309);
            this.CompanyLadBillToolStrip.Name = "CompanyLadBillToolStrip";
            this.CompanyLadBillToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CompanyLadBillToolStrip.Size = new System.Drawing.Size(842, 31);
            this.CompanyLadBillToolStrip.TabIndex = 6;
            // 
            // RefreshCmpanyLadBillButton
            // 
            this.RefreshCmpanyLadBillButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshCmpanyLadBillButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshCmpanyLadBillButton.Image")));
            this.RefreshCmpanyLadBillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshCmpanyLadBillButton.Name = "RefreshCmpanyLadBillButton";
            this.RefreshCmpanyLadBillButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshCmpanyLadBillButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshCmpanyLadBillButton.Click += new System.EventHandler(this.RefreshCmpanyLadBillButton_Click);
            // 
            // CompanyLadBillGridView
            // 
            this.CompanyLadBillGridView.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.CompanyLadBillGridView.AlternatingColors = true;
            this.CompanyLadBillGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            CompanyLadBillGridView_DesignTimeLayout.LayoutString = resources.GetString("CompanyLadBillGridView_DesignTimeLayout.LayoutString");
            this.CompanyLadBillGridView.DesignTimeLayout = CompanyLadBillGridView_DesignTimeLayout;
            this.CompanyLadBillGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyLadBillGridView.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyLadBillGridView.GroupByBoxVisible = false;
            this.CompanyLadBillGridView.Location = new System.Drawing.Point(0, 340);
            this.CompanyLadBillGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CompanyLadBillGridView.Name = "CompanyLadBillGridView";
            this.CompanyLadBillGridView.Size = new System.Drawing.Size(842, 278);
            this.CompanyLadBillGridView.TabIndex = 7;
            // 
            // UsedLadBillListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(842, 618);
            this.Controls.Add(this.CompanyLadBillGridView);
            this.Controls.Add(this.CompanyLadBillToolStrip);
            this.Controls.Add(this.LadBillWithTrafficGridView);
            this.Controls.Add(this.UsedLadBillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "UsedLadBillListForm";
            this.Text = "اختصاص بارنامه های داده شده به شرکت به رانندگان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UsedLadBillListForm_Load);
            this.UsedLadBillToolStrip.ResumeLayout(false);
            this.UsedLadBillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadBillWithTrafficGridView)).EndInit();
            this.CompanyLadBillToolStrip.ResumeLayout(false);
            this.CompanyLadBillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLadBillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip UsedLadBillToolStrip;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton UsedLadBillStripButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private Janus.Windows.GridEX.GridEX LadBillWithTrafficGridView;
        private System.Windows.Forms.ToolStrip CompanyLadBillToolStrip;
        private System.Windows.Forms.ToolStripButton RefreshCmpanyLadBillButton;
        private Janus.Windows.GridEX.GridEX CompanyLadBillGridView;
    }

}