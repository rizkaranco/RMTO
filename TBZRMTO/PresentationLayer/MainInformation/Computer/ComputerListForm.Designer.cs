namespace HPS.Present.Computer
    {
    partial class ComputerListForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerListForm));
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.ComputerGridView = new System.Windows.Forms.DataGridView();
            this.colComputerID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComputer_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMacAddress_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMessageLED_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUserGroupID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.EditAllButton = new System.Windows.Forms.ToolStripButton();
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerGridView)).BeginInit();
            this.ComputerToolStrip.SuspendLayout();
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
            // ComputerGridView
            // 
            this.ComputerGridView.AllowUserToAddRows = false;
            this.ComputerGridView.AllowUserToDeleteRows = false;
            this.ComputerGridView.AllowUserToResizeRows = false;
            this.ComputerGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ComputerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colComputerID_int,
            this.colComputer_nvc,
            this.colIPAddress_nvc,
            this.colMacAddress_nvc,
            this.colMessageLED_nvc,
            this.colActive_bit,
            this.colUserGroupID_int});
            this.ComputerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputerGridView.Location = new System.Drawing.Point(0, 31);
            this.ComputerGridView.Margin = new System.Windows.Forms.Padding(5);
            this.ComputerGridView.MultiSelect = false;
            this.ComputerGridView.Name = "ComputerGridView";
            this.ComputerGridView.ReadOnly = true;
            this.ComputerGridView.RowHeadersVisible = false;
            this.ComputerGridView.Size = new System.Drawing.Size(730, 385);
            this.ComputerGridView.TabIndex = 0;
            // 
            // colComputerID_int
            // 
            this.colComputerID_int.DataPropertyName = "ComputerID_int";
            this.colComputerID_int.HeaderText = "شناسه رایانه";
            this.colComputerID_int.Name = "colComputerID_int";
            this.colComputerID_int.ReadOnly = true;
            this.colComputerID_int.Visible = false;
            // 
            // colComputer_nvc
            // 
            this.colComputer_nvc.DataPropertyName = "Computer_nvc";
            this.colComputer_nvc.HeaderText = "نام رایانه";
            this.colComputer_nvc.Name = "colComputer_nvc";
            this.colComputer_nvc.ReadOnly = true;
            this.colComputer_nvc.Width = 110;
            // 
            // colIPAddress_nvc
            // 
            this.colIPAddress_nvc.DataPropertyName = "IPAddress_nvc";
            this.colIPAddress_nvc.HeaderText = "آدرس IP";
            this.colIPAddress_nvc.Name = "colIPAddress_nvc";
            this.colIPAddress_nvc.ReadOnly = true;
            this.colIPAddress_nvc.Width = 110;
            // 
            // colMacAddress_nvc
            // 
            this.colMacAddress_nvc.DataPropertyName = "MacAddress_nvc";
            this.colMacAddress_nvc.HeaderText = "آدرس Mac";
            this.colMacAddress_nvc.Name = "colMacAddress_nvc";
            this.colMacAddress_nvc.ReadOnly = true;
            this.colMacAddress_nvc.Width = 125;
            // 
            // colMessageLED_nvc
            // 
            this.colMessageLED_nvc.DataPropertyName = "MessageLED_nvc";
            this.colMessageLED_nvc.HeaderText = "پیام نمایشگر LED";
            this.colMessageLED_nvc.Name = "colMessageLED_nvc";
            this.colMessageLED_nvc.ReadOnly = true;
            this.colMessageLED_nvc.Width = 150;
            // 
            // colActive_bit
            // 
            this.colActive_bit.DataPropertyName = "Active_bit";
            this.colActive_bit.HeaderText = "فعال";
            this.colActive_bit.Name = "colActive_bit";
            this.colActive_bit.ReadOnly = true;
            this.colActive_bit.Width = 116;
            // 
            // colUserGroupID_int
            // 
            this.colUserGroupID_int.DataPropertyName = "UserGroupID_intUserGroup_nvc";
            this.colUserGroupID_int.HeaderText = "گروه رایانه";
            this.colUserGroupID_int.Name = "colUserGroupID_int";
            this.colUserGroupID_int.ReadOnly = true;
            this.colUserGroupID_int.Width = 116;
            // 
            // ComputerToolStrip
            // 
            this.ComputerToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ComputerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.toolStripButton1,
            this.EditButton,
            this.EditAllButton,
            this.DeleteButton,
            this.RefreshButton,
            this.ExportButton});
            this.ComputerToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ComputerToolStrip.Name = "ComputerToolStrip";
            this.ComputerToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ComputerToolStrip.Size = new System.Drawing.Size(730, 31);
            this.ComputerToolStrip.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::HPS.Properties.Resources.Add2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "افزودن دسته جمعی";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // EditAllButton
            // 
            this.EditAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditAllButton.Image = global::HPS.Properties.Resources.DeselectAll;
            this.EditAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditAllButton.Name = "EditAllButton";
            this.EditAllButton.Size = new System.Drawing.Size(28, 28);
            this.EditAllButton.Text = "ویرایش دسته جمعی";
            this.EditAllButton.Click += new System.EventHandler(this.EditAllButton_Click);
            // 
            // ComputerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(730, 416);
            this.Controls.Add(this.ComputerGridView);
            this.Controls.Add(this.ComputerToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "ComputerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست رایانه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ComputerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerGridView)).EndInit();
            this.ComputerToolStrip.ResumeLayout(false);
            this.ComputerToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip ComputerToolStrip;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.DataGridView ComputerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComputerID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComputer_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPAddress_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMacAddress_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMessageLED_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserGroupID_int;
        private Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton EditAllButton;
    }

}