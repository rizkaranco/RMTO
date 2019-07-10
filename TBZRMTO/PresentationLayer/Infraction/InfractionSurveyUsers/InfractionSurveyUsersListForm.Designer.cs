namespace HPS.Present.InfractionSurveyUsers
    {
    partial class InfractionSurveyUsersListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionSurveyUsersListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.InfractionSurveyUsersGridView = new System.Windows.Forms.DataGridView();
            this.colInfractionSurveyUsersID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionSurveyGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfractionSurveyUsersToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.InfractionSurveyUsersGridView)).BeginInit();
            this.InfractionSurveyUsersToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(28, 28);
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
            this.ExportButton.Text = "انتقال به اکسل";
            // 
            // InfractionSurveyUsersGridView
            // 
            this.InfractionSurveyUsersGridView.AllowUserToAddRows = false;
            this.InfractionSurveyUsersGridView.AllowUserToDeleteRows = false;
            this.InfractionSurveyUsersGridView.AllowUserToResizeRows = false;
            this.InfractionSurveyUsersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.InfractionSurveyUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfractionSurveyUsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfractionSurveyUsersID_int,
            this.colUserName_nvc,
            this.colInfractionSurveyGroupID_int});
            this.InfractionSurveyUsersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfractionSurveyUsersGridView.Location = new System.Drawing.Point(0, 31);
            this.InfractionSurveyUsersGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.InfractionSurveyUsersGridView.MultiSelect = false;
            this.InfractionSurveyUsersGridView.Name = "InfractionSurveyUsersGridView";
            this.InfractionSurveyUsersGridView.ReadOnly = true;
            this.InfractionSurveyUsersGridView.RowHeadersVisible = false;
            this.InfractionSurveyUsersGridView.Size = new System.Drawing.Size(700, 409);
            this.InfractionSurveyUsersGridView.TabIndex = 0;
            // 
            // colInfractionSurveyUsersID_int
            // 
            this.colInfractionSurveyUsersID_int.DataPropertyName = "InfractionSurveyUsersID_int";
            this.colInfractionSurveyUsersID_int.HeaderText = "شناسه کاربران بررسی تخلفات";
            this.colInfractionSurveyUsersID_int.Name = "colInfractionSurveyUsersID_int";
            this.colInfractionSurveyUsersID_int.ReadOnly = true;
            this.colInfractionSurveyUsersID_int.Visible = false;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvcUserName_nvc";
            this.colUserName_nvc.HeaderText = "نام کاربر";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Width = 349;
            // 
            // colInfractionSurveyGroupID_int
            // 
            this.colInfractionSurveyGroupID_int.DataPropertyName = "InfractionSurveyGroupID_intInfractionSurveyGroup_nvc";
            this.colInfractionSurveyGroupID_int.HeaderText = "گروه برسی تخلفات";
            this.colInfractionSurveyGroupID_int.Name = "colInfractionSurveyGroupID_int";
            this.colInfractionSurveyGroupID_int.ReadOnly = true;
            this.colInfractionSurveyGroupID_int.Width = 348;
            // 
            // InfractionSurveyUsersToolStrip
            // 
            this.InfractionSurveyUsersToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InfractionSurveyUsersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.InfractionSurveyUsersToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InfractionSurveyUsersToolStrip.Name = "InfractionSurveyUsersToolStrip";
            this.InfractionSurveyUsersToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InfractionSurveyUsersToolStrip.Size = new System.Drawing.Size(700, 31);
            this.InfractionSurveyUsersToolStrip.TabIndex = 1;
            // 
            // InfractionSurveyUsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.InfractionSurveyUsersGridView);
            this.Controls.Add(this.InfractionSurveyUsersToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "InfractionSurveyUsersListForm";
            this.Text = "لیست کاربران بررسی تخلفات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfractionSurveyUsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfractionSurveyUsersGridView)).EndInit();
            this.InfractionSurveyUsersToolStrip.ResumeLayout(false);
            this.InfractionSurveyUsersToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip InfractionSurveyUsersToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView InfractionSurveyUsersGridView;
        
private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionSurveyUsersID_int;
private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionSurveyGroupID_int;
    }

}