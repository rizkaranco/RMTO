namespace HPS.Present.InfractionType
    {
    partial class InfractionTypeListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionTypeListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.InfractionTypeGridView = new System.Windows.Forms.DataGridView();
            this.colInfractionTypeID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfractionSurveyGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPenaltyFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfractionTypeToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.InfractionTypeGridView)).BeginInit();
            this.InfractionTypeToolStrip.SuspendLayout();
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
            // InfractionTypeGridView
            // 
            this.InfractionTypeGridView.AllowUserToAddRows = false;
            this.InfractionTypeGridView.AllowUserToDeleteRows = false;
            this.InfractionTypeGridView.AllowUserToResizeRows = false;
            this.InfractionTypeGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.InfractionTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfractionTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfractionTypeID_int,
            this.colInfractionType_nvc,
            this.colInfractionGroupID_int,
            this.colInfractionSurveyGroupID_int,
            this.colPenaltyFee_dec,
            this.colDate_nvc,
            this.colTime_nvc,
            this.colActive_bit,
            this.colUserName_nvc});
            this.InfractionTypeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfractionTypeGridView.Location = new System.Drawing.Point(0, 31);
            this.InfractionTypeGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.InfractionTypeGridView.MultiSelect = false;
            this.InfractionTypeGridView.Name = "InfractionTypeGridView";
            this.InfractionTypeGridView.ReadOnly = true;
            this.InfractionTypeGridView.RowHeadersVisible = false;
            this.InfractionTypeGridView.Size = new System.Drawing.Size(700, 409);
            this.InfractionTypeGridView.TabIndex = 0;
            // 
            // colInfractionTypeID_int
            // 
            this.colInfractionTypeID_int.DataPropertyName = "InfractionTypeID_int";
            this.colInfractionTypeID_int.HeaderText = "شناسه  نوع تخلف";
            this.colInfractionTypeID_int.Name = "colInfractionTypeID_int";
            this.colInfractionTypeID_int.ReadOnly = true;
            this.colInfractionTypeID_int.Visible = false;
            // 
            // colInfractionType_nvc
            // 
            this.colInfractionType_nvc.DataPropertyName = "InfractionType_nvc";
            this.colInfractionType_nvc.HeaderText = "نوع تخلف";
            this.colInfractionType_nvc.Name = "colInfractionType_nvc";
            this.colInfractionType_nvc.ReadOnly = true;
            this.colInfractionType_nvc.Width = 300;
            // 
            // colInfractionGroupID_int
            // 
            this.colInfractionGroupID_int.DataPropertyName = "InfractionGroupID_intInfractionGroup_nvc";
            this.colInfractionGroupID_int.HeaderText = "گروه تخلف";
            this.colInfractionGroupID_int.Name = "colInfractionGroupID_int";
            this.colInfractionGroupID_int.ReadOnly = true;
            this.colInfractionGroupID_int.Width = 200;
            // 
            // colInfractionSurveyGroupID_int
            // 
            this.colInfractionSurveyGroupID_int.DataPropertyName = "InfractionSurveyGroupID_intInfractionSurveyGroup_nvc";
            this.colInfractionSurveyGroupID_int.HeaderText = "گروه بررسی تخلفات";
            this.colInfractionSurveyGroupID_int.Name = "colInfractionSurveyGroupID_int";
            this.colInfractionSurveyGroupID_int.ReadOnly = true;
            this.colInfractionSurveyGroupID_int.Width = 220;
            // 
            // colPenaltyFee_dec
            // 
            this.colPenaltyFee_dec.DataPropertyName = "PenaltyFee_dec";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colPenaltyFee_dec.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPenaltyFee_dec.HeaderText = "مبلغ جریمه";
            this.colPenaltyFee_dec.Name = "colPenaltyFee_dec";
            this.colPenaltyFee_dec.ReadOnly = true;
            // 
            // colDate_nvc
            // 
            this.colDate_nvc.DataPropertyName = "Date_nvc";
            this.colDate_nvc.HeaderText = "تاریخ";
            this.colDate_nvc.Name = "colDate_nvc";
            this.colDate_nvc.ReadOnly = true;
            this.colDate_nvc.Visible = false;
            this.colDate_nvc.Width = 71;
            // 
            // colTime_nvc
            // 
            this.colTime_nvc.DataPropertyName = "Time_nvc";
            this.colTime_nvc.HeaderText = "ساعت";
            this.colTime_nvc.Name = "colTime_nvc";
            this.colTime_nvc.ReadOnly = true;
            this.colTime_nvc.Visible = false;
            this.colTime_nvc.Width = 72;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 70;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "UserName_nvc";
            this.colUserName_nvc.HeaderText = "کاربر ثبت کننده";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            this.colUserName_nvc.Visible = false;
            this.colUserName_nvc.Width = 150;
            // 
            // InfractionTypeToolStrip
            // 
            this.InfractionTypeToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.InfractionTypeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.EditButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.InfractionTypeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InfractionTypeToolStrip.Name = "InfractionTypeToolStrip";
            this.InfractionTypeToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InfractionTypeToolStrip.Size = new System.Drawing.Size(700, 31);
            this.InfractionTypeToolStrip.TabIndex = 1;
            // 
            // InfractionTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.InfractionTypeGridView);
            this.Controls.Add(this.InfractionTypeToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "InfractionTypeListForm";
            this.Text = "لیست انواع تخلف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfractionTypeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfractionTypeGridView)).EndInit();
            this.InfractionTypeToolStrip.ResumeLayout(false);
            this.InfractionTypeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip InfractionTypeToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView InfractionTypeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionTypeID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfractionSurveyGroupID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenaltyFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
    }

}