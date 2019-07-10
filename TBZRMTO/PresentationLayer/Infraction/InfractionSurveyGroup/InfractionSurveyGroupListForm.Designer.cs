namespace HPS.Present.InfractionSurveyGroup
    {
    partial class InfractionSurveyGroupListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionSurveyGroupListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.InfractionSurveyGroupGridView = new System.Windows.Forms.DataGridView();
            this.colInfractionSurveyGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionSurveyGroup_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfractionSurveyGroupToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.InfractionSurveyGroupGridView)).BeginInit();
            this.InfractionSurveyGroupToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
            this.NewButton.Tag = "جديد";
            this.NewButton.Text = "جديد";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(28, 28);
            this.EditButton.Tag = "ويرايش";
            this.EditButton.Text = "ويرايش";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.ExportButton.Tag = "انتقال به اکسل";
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // InfractionSurveyGroupGridView
            // 
            this.InfractionSurveyGroupGridView.AllowUserToAddRows = false;
            this.InfractionSurveyGroupGridView.AllowUserToDeleteRows = false;
            this.InfractionSurveyGroupGridView.AllowUserToResizeRows = false;
            this.InfractionSurveyGroupGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InfractionSurveyGroupGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.InfractionSurveyGroupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfractionSurveyGroupGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfractionSurveyGroupID_int,
            this.colInfractionSurveyGroup_nvc});
            this.InfractionSurveyGroupGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfractionSurveyGroupGridView.Location = new System.Drawing.Point(0, 31);
            this.InfractionSurveyGroupGridView.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionSurveyGroupGridView.MultiSelect = false;
            this.InfractionSurveyGroupGridView.Name = "InfractionSurveyGroupGridView";
            this.InfractionSurveyGroupGridView.ReadOnly = true;
            this.InfractionSurveyGroupGridView.RowHeadersVisible = false;
            this.InfractionSurveyGroupGridView.Size = new System.Drawing.Size(700, 409);
            this.InfractionSurveyGroupGridView.TabIndex = 0;
            // 
            // colInfractionSurveyGroupID_int
            // 
            this.colInfractionSurveyGroupID_int.DataPropertyName = "InfractionSurveyGroupID_int";
            this.colInfractionSurveyGroupID_int.HeaderText = "شناسه گروه بررسی تخلفات";
            this.colInfractionSurveyGroupID_int.Name = "colInfractionSurveyGroupID_int";
            this.colInfractionSurveyGroupID_int.ReadOnly = true;
            this.colInfractionSurveyGroupID_int.Visible = false;
            // 
            // colInfractionSurveyGroup_nvc
            // 
            this.colInfractionSurveyGroup_nvc.DataPropertyName = "InfractionSurveyGroup_nvc";
            this.colInfractionSurveyGroup_nvc.HeaderText = "نام گروه";
            this.colInfractionSurveyGroup_nvc.Name = "colInfractionSurveyGroup_nvc";
            this.colInfractionSurveyGroup_nvc.ReadOnly = true;
            // 
            // InfractionSurveyGroupToolStrip
            // 
            this.InfractionSurveyGroupToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InfractionSurveyGroupToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.InfractionSurveyGroupToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InfractionSurveyGroupToolStrip.Name = "InfractionSurveyGroupToolStrip";
            this.InfractionSurveyGroupToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InfractionSurveyGroupToolStrip.Size = new System.Drawing.Size(700, 31);
            this.InfractionSurveyGroupToolStrip.TabIndex = 1;
            // 
            // InfractionSurveyGroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.InfractionSurveyGroupGridView);
            this.Controls.Add(this.InfractionSurveyGroupToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "InfractionSurveyGroupListForm";
            this.Text = "لیست گروه بررسی تخلف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfractionSurveyGroupListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfractionSurveyGroupGridView)).EndInit();
            this.InfractionSurveyGroupToolStrip.ResumeLayout(false);
            this.InfractionSurveyGroupToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip InfractionSurveyGroupToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView InfractionSurveyGroupGridView;
        
private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionSurveyGroupID_int;
private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionSurveyGroup_nvc;
    }

}