namespace HPS.Present.SearchForm
{
    partial class LaderTypeMultiChoose
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
            Janus.Windows.GridEX.GridEXLayout LaderTypeGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaderTypeMultiChoose));
            this.BoxingToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LaderTypeGridView = new Janus.Windows.GridEX.GridEX();
            this.BoxingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxingToolStrip
            // 
            this.BoxingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BoxingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.BoxingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BoxingToolStrip.Name = "BoxingToolStrip";
            this.BoxingToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.BoxingToolStrip.Size = new System.Drawing.Size(693, 31);
            this.BoxingToolStrip.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = global::HPS.Properties.Resources.Check;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 28);
            this.SearchButton.Text = "جديد";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            // LaderTypeGridView
            // 
            LaderTypeGridView_DesignTimeLayout.LayoutString = resources.GetString("LaderTypeGridView_DesignTimeLayout.LayoutString");
            this.LaderTypeGridView.DesignTimeLayout = LaderTypeGridView_DesignTimeLayout;
            this.LaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaderTypeGridView.GroupByBoxVisible = false;
            this.LaderTypeGridView.Location = new System.Drawing.Point(0, 31);
            this.LaderTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeGridView.Name = "LaderTypeGridView";
            this.LaderTypeGridView.Size = new System.Drawing.Size(693, 424);
            this.LaderTypeGridView.TabIndex = 8;
            this.LaderTypeGridView.DoubleClick += new System.EventHandler(this.LaderTypeGridView_DoubleClick);
            this.LaderTypeGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaderTypeGridView_KeyDown);
            // 
            // LaderTypeMultiChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 455);
            this.Controls.Add(this.LaderTypeGridView);
            this.Controls.Add(this.BoxingToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LaderTypeMultiChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " جستجوی انواع بارگیر";
            this.Load += new System.EventHandler(this.LaderTypeSearch_Load);
            this.BoxingToolStrip.ResumeLayout(false);
            this.BoxingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip BoxingToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private Janus.Windows.GridEX.GridEX LaderTypeGridView;
    }
}