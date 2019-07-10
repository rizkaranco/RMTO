
namespace HPS.Present.VerifiedCars
{
    partial class VerifiedCarsListForm

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
            this.NewVerifiedCarsButton = new System.Windows.Forms.ToolStripButton();
            this.EditVerifiedCarsButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteVerifiedCarsButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshVerifiedCarsButton = new System.Windows.Forms.ToolStripButton();
            this.ExportVerifiedCarsButton = new System.Windows.Forms.ToolStripButton();
            this.VerifiedCarsGridView = new System.Windows.Forms.DataGridView();
            this.VerifiedCarsToolStrip = new System.Windows.Forms.ToolStrip();
            this.colVerifiedCarID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VerifiedCarsGridView)).BeginInit();
            this.VerifiedCarsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewVerifiedCarsButton
            // 
            this.NewVerifiedCarsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewVerifiedCarsButton.Image = global::HPS.Properties.Resources.Add;
            this.NewVerifiedCarsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewVerifiedCarsButton.Name = "NewVerifiedCarsButton";
            this.NewVerifiedCarsButton.Size = new System.Drawing.Size(28, 28);
            this.NewVerifiedCarsButton.Text = "جديد";
            this.NewVerifiedCarsButton.Click += new System.EventHandler(this.NewVerifiedCarsButton_Click);
            // 
            // EditVerifiedCarsButton
            // 
            this.EditVerifiedCarsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditVerifiedCarsButton.Image = global::HPS.Properties.Resources.Edit;
            this.EditVerifiedCarsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditVerifiedCarsButton.Name = "EditVerifiedCarsButton";
            this.EditVerifiedCarsButton.Size = new System.Drawing.Size(28, 28);
            this.EditVerifiedCarsButton.Text = "ويرايش";
            this.EditVerifiedCarsButton.Click += new System.EventHandler(this.EditVerifiedCarsButton_Click);
            // 
            // DeleteVerifiedCarsButton
            // 
            this.DeleteVerifiedCarsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteVerifiedCarsButton.Image = global::HPS.Properties.Resources.Delete;
            this.DeleteVerifiedCarsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteVerifiedCarsButton.Name = "DeleteVerifiedCarsButton";
            this.DeleteVerifiedCarsButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteVerifiedCarsButton.Text = "حذف";
            this.DeleteVerifiedCarsButton.Click += new System.EventHandler(this.DeleteVerifiedCarsButton_Click);
            // 
            // RefreshVerifiedCarsButton
            // 
            this.RefreshVerifiedCarsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshVerifiedCarsButton.Image = global::HPS.Properties.Resources.Refresh;
            this.RefreshVerifiedCarsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshVerifiedCarsButton.Name = "RefreshVerifiedCarsButton";
            this.RefreshVerifiedCarsButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshVerifiedCarsButton.Text = "بازیابی مجدد اطلاعات";
            this.RefreshVerifiedCarsButton.Click += new System.EventHandler(this.RefreshVerifiedCarsButton_Click);
            // 
            // ExportVerifiedCarsButton
            // 
            this.ExportVerifiedCarsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportVerifiedCarsButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportVerifiedCarsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportVerifiedCarsButton.Name = "ExportVerifiedCarsButton";
            this.ExportVerifiedCarsButton.Size = new System.Drawing.Size(28, 28);
            this.ExportVerifiedCarsButton.Text = "انتقال به اکسل";
            // 
            // VerifiedCarsGridView
            // 
            this.VerifiedCarsGridView.AllowUserToAddRows = false;
            this.VerifiedCarsGridView.AllowUserToDeleteRows = false;
            this.VerifiedCarsGridView.AllowUserToResizeRows = false;
            this.VerifiedCarsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VerifiedCarsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.VerifiedCarsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerifiedCarsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVerifiedCarID_int,
            this.Company_nvc,
            this.colCompanyID_int,
            this.colNumberPlate_nvc,
            this.colSerialPlate_nvc,
            this.colDate_vc,
            this.FullName_nvc,
            this.Unit_nvc});
            this.VerifiedCarsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerifiedCarsGridView.Location = new System.Drawing.Point(0, 31);
            this.VerifiedCarsGridView.Margin = new System.Windows.Forms.Padding(5);
            this.VerifiedCarsGridView.MultiSelect = false;
            this.VerifiedCarsGridView.Name = "VerifiedCarsGridView";
            this.VerifiedCarsGridView.ReadOnly = true;
            this.VerifiedCarsGridView.RowHeadersVisible = false;
            this.VerifiedCarsGridView.Size = new System.Drawing.Size(767, 415);
            this.VerifiedCarsGridView.TabIndex = 0;
            // 
            // VerifiedCarsToolStrip
            // 
            this.VerifiedCarsToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.VerifiedCarsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewVerifiedCarsButton,
            this.EditVerifiedCarsButton,
            this.DeleteVerifiedCarsButton,
            this.RefreshVerifiedCarsButton,
            this.ExportVerifiedCarsButton});
            this.VerifiedCarsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.VerifiedCarsToolStrip.Name = "VerifiedCarsToolStrip";
            this.VerifiedCarsToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.VerifiedCarsToolStrip.Size = new System.Drawing.Size(767, 31);
            this.VerifiedCarsToolStrip.TabIndex = 1;
            // 
            // colVerifiedCarID_int
            // 
            this.colVerifiedCarID_int.DataPropertyName = "VerifiedCarID_int";
            this.colVerifiedCarID_int.HeaderText = "VerifiedCarID_int";
            this.colVerifiedCarID_int.Name = "colVerifiedCarID_int";
            this.colVerifiedCarID_int.ReadOnly = true;
            this.colVerifiedCarID_int.Visible = false;
            // 
            // Company_nvc
            // 
            this.Company_nvc.DataPropertyName = "Company_nvc";
            this.Company_nvc.HeaderText = "شرکت";
            this.Company_nvc.Name = "Company_nvc";
            this.Company_nvc.ReadOnly = true;
            // 
            // colCompanyID_int
            // 
            this.colCompanyID_int.DataPropertyName = "CompanyID_int";
            this.colCompanyID_int.HeaderText = "CompanyID_int";
            this.colCompanyID_int.Name = "colCompanyID_int";
            this.colCompanyID_int.ReadOnly = true;
            this.colCompanyID_int.Visible = false;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سری";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // colDate_vc
            // 
            this.colDate_vc.DataPropertyName = "Date_vc";
            this.colDate_vc.HeaderText = "Datetime_dt";
            this.colDate_vc.Name = "colDate_vc";
            this.colDate_vc.ReadOnly = true;
            this.colDate_vc.Visible = false;
            // 
            // FullName_nvc
            // 
            this.FullName_nvc.DataPropertyName = "FullName_nvc";
            this.FullName_nvc.HeaderText = "نام و نام خانوادگی";
            this.FullName_nvc.Name = "FullName_nvc";
            this.FullName_nvc.ReadOnly = true;
            // 
            // Unit_nvc
            // 
            this.Unit_nvc.DataPropertyName = "Unit_nvc";
            this.Unit_nvc.HeaderText = "واحد/سمت";
            this.Unit_nvc.Name = "Unit_nvc";
            this.Unit_nvc.ReadOnly = true;
            // 
            // VerifiedCarsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(767, 446);
            this.Controls.Add(this.VerifiedCarsGridView);
            this.Controls.Add(this.VerifiedCarsToolStrip);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "VerifiedCarsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " فهرست ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VerifiedCarsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VerifiedCarsGridView)).EndInit();
            this.VerifiedCarsToolStrip.ResumeLayout(false);
            this.VerifiedCarsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip VerifiedCarsToolStrip;
        private System.Windows.Forms.ToolStripButton NewVerifiedCarsButton;
        private System.Windows.Forms.ToolStripButton EditVerifiedCarsButton;
        private System.Windows.Forms.ToolStripButton DeleteVerifiedCarsButton;
        private System.Windows.Forms.ToolStripButton RefreshVerifiedCarsButton;
        private System.Windows.Forms.ToolStripButton ExportVerifiedCarsButton;
        private System.Windows.Forms.DataGridView VerifiedCarsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerifiedCarID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate_vc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_nvc;
    }

}