namespace HPS.Present.LadeAssignment
{
    partial class LadeAssignmentWithoutAcceptedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadeAssignmentWithoutAcceptedForm));
            Janus.Windows.GridEX.GridEXLayout LadeAssignmentGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.LadeAssignmentToolStrip = new System.Windows.Forms.ToolStrip();
            this.ChooseLadeAssignmentAcceptedButton = new System.Windows.Forms.ToolStripButton();
            this.SelectAlltoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LadeAssignmentAcceptedButton = new System.Windows.Forms.ToolStripButton();
            this.AllLadeAssignmenttoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LadeAssignmentGridView = new Janus.Windows.GridEX.GridEX();
            this.LadeAssignmentToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeAssignmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LadeAssignmentToolStrip
            // 
            this.LadeAssignmentToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadeAssignmentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseLadeAssignmentAcceptedButton,
            this.SelectAlltoolStripButton,
            this.LadeAssignmentAcceptedButton,
            this.AllLadeAssignmenttoolStripButton,
            this.RefreshButton,
            this.ClosetoolStripButton});
            this.LadeAssignmentToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LadeAssignmentToolStrip.Name = "LadeAssignmentToolStrip";
            this.LadeAssignmentToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadeAssignmentToolStrip.Size = new System.Drawing.Size(1139, 31);
            this.LadeAssignmentToolStrip.TabIndex = 10;
            this.LadeAssignmentToolStrip.Text = "انتخاب چند گزینه ای";
            // 
            // ChooseLadeAssignmentAcceptedButton
            // 
            this.ChooseLadeAssignmentAcceptedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChooseLadeAssignmentAcceptedButton.Image = global::HPS.Properties.Resources.table_sql_check;
            this.ChooseLadeAssignmentAcceptedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChooseLadeAssignmentAcceptedButton.Name = "ChooseLadeAssignmentAcceptedButton";
            this.ChooseLadeAssignmentAcceptedButton.Size = new System.Drawing.Size(28, 28);
            this.ChooseLadeAssignmentAcceptedButton.Text = " تأیید  انتخاب چند گزینه ای";
            this.ChooseLadeAssignmentAcceptedButton.Click += new System.EventHandler(this.ChooseLadeAssignmentAcceptedButton_Click);
            // 
            // SelectAlltoolStripButton
            // 
            this.SelectAlltoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectAlltoolStripButton.Image = global::HPS.Properties.Resources.selection_all;
            this.SelectAlltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAlltoolStripButton.Name = "SelectAlltoolStripButton";
            this.SelectAlltoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.SelectAlltoolStripButton.Text = "انتخاب تمام گزینه ها";
            this.SelectAlltoolStripButton.Click += new System.EventHandler(this.SelectAlltoolStripButton_Click);
            // 
            // LadeAssignmentAcceptedButton
            // 
            this.LadeAssignmentAcceptedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LadeAssignmentAcceptedButton.Image = global::HPS.Properties.Resources.LadBill;
            this.LadeAssignmentAcceptedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LadeAssignmentAcceptedButton.Name = "LadeAssignmentAcceptedButton";
            this.LadeAssignmentAcceptedButton.Size = new System.Drawing.Size(28, 28);
            this.LadeAssignmentAcceptedButton.Text = "تأیید اطلاع رسانی بار";
            this.LadeAssignmentAcceptedButton.Visible = false;
            this.LadeAssignmentAcceptedButton.Click += new System.EventHandler(this.LadeAssignmentAcceptedButton_Click);
            // 
            // AllLadeAssignmenttoolStripButton
            // 
            this.AllLadeAssignmenttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllLadeAssignmenttoolStripButton.Image = global::HPS.Properties.Resources.AllRecords;
            this.AllLadeAssignmenttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllLadeAssignmenttoolStripButton.Name = "AllLadeAssignmenttoolStripButton";
            this.AllLadeAssignmenttoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.AllLadeAssignmenttoolStripButton.Text = "نمایش کل اطلاع رسانی بار تأیید نشده";
            this.AllLadeAssignmenttoolStripButton.Click += new System.EventHandler(this.AllLadeAssignmenttoolStripButton_Click);
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
            // LadeAssignmentGridView
            // 
            this.LadeAssignmentGridView.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.LadeAssignmentGridView.AlternatingColors = true;
            this.LadeAssignmentGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.LadeAssignmentGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LadeAssignmentGridView.BlendColor = System.Drawing.Color.White;
            LadeAssignmentGridView_DesignTimeLayout.LayoutString = resources.GetString("LadeAssignmentGridView_DesignTimeLayout.LayoutString");
            this.LadeAssignmentGridView.DesignTimeLayout = LadeAssignmentGridView_DesignTimeLayout;
            this.LadeAssignmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadeAssignmentGridView.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.LadeAssignmentGridView.GroupByBoxVisible = false;
            this.LadeAssignmentGridView.Location = new System.Drawing.Point(0, 31);
            this.LadeAssignmentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadeAssignmentGridView.Name = "LadeAssignmentGridView";
            this.LadeAssignmentGridView.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty;
            this.LadeAssignmentGridView.SelectedFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.LadeAssignmentGridView.SelectedFormatStyle.ForeColor = System.Drawing.Color.Empty;
            this.LadeAssignmentGridView.Size = new System.Drawing.Size(1139, 428);
            this.LadeAssignmentGridView.TabIndex = 14;
            this.LadeAssignmentGridView.RowCheckStateChanged += new Janus.Windows.GridEX.RowCheckStateChangeEventHandler(this.LadeAssignmentGridView_RowCheckStateChanged);
            // 
            // LadeAssignmentWithoutAcceptedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 459);
            this.Controls.Add(this.LadeAssignmentGridView);
            this.Controls.Add(this.LadeAssignmentToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "LadeAssignmentWithoutAcceptedForm";
            this.Text = "لیست اطلاع رسانی بار تأیید نشده";
            this.Load += new System.EventHandler(this.LadeAssignmentWithoutAcceptedForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeAssignmentWithoutAcceptedForm_KeyDown);
            this.LadeAssignmentToolStrip.ResumeLayout(false);
            this.LadeAssignmentToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadeAssignmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip LadeAssignmentToolStrip;
        private System.Windows.Forms.ToolStripButton ChooseLadeAssignmentAcceptedButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.ToolStripButton AllLadeAssignmenttoolStripButton;
        private System.Windows.Forms.ToolStripButton LadeAssignmentAcceptedButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton SelectAlltoolStripButton;
        private Janus.Windows.GridEX.GridEX LadeAssignmentGridView;
    }
}