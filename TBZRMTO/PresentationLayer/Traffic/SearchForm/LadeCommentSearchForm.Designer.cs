namespace HPS.Present.SearchForm
{
    partial class LadeCommentSearchForm
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
            Janus.Windows.GridEX.GridEXLayout LadeCommentGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadeCommentSearchForm));
            this.LadeCommentToolStrip = new System.Windows.Forms.ToolStrip();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LadeCommentGridView = new Janus.Windows.GridEX.GridEX();
            this.LadeCommentToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeCommentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LadeCommentToolStrip
            // 
            this.LadeCommentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadeCommentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchButton,
            this.ClosetoolStripButton});
            this.LadeCommentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LadeCommentToolStrip.Name = "LadeCommentToolStrip";
            this.LadeCommentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadeCommentToolStrip.Size = new System.Drawing.Size(705, 31);
            this.LadeCommentToolStrip.TabIndex = 1;
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
            // LadeCommentGridView
            // 
            this.LadeCommentGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            LadeCommentGridView_DesignTimeLayout.LayoutString = resources.GetString("LadeCommentGridView_DesignTimeLayout.LayoutString");
            this.LadeCommentGridView.DesignTimeLayout = LadeCommentGridView_DesignTimeLayout;
            this.LadeCommentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadeCommentGridView.GroupByBoxVisible = false;
            this.LadeCommentGridView.Location = new System.Drawing.Point(0, 31);
            this.LadeCommentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadeCommentGridView.Name = "LadeCommentGridView";
            this.LadeCommentGridView.Size = new System.Drawing.Size(705, 360);
            this.LadeCommentGridView.TabIndex = 0;
            this.LadeCommentGridView.DoubleClick += new System.EventHandler(this.LadeCommentGridView_DoubleClick);
            this.LadeCommentGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeCommentGridView_KeyDown);
            this.LadeCommentGridView.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.LadeCommentGridView_FormattingRow);
            // 
            // LadeCommentSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 391);
            this.Controls.Add(this.LadeCommentGridView);
            this.Controls.Add(this.LadeCommentToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LadeCommentSearchForm";
            this.Text = "جستجوی توضیحات پیش فرض اطلاع رسانی بار";
            this.Load += new System.EventHandler(this.LadeCommentSearchForm_Load);
            this.LadeCommentToolStrip.ResumeLayout(false);
            this.LadeCommentToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeCommentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip LadeCommentToolStrip;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private Janus.Windows.GridEX.GridEX LadeCommentGridView;
    }
}