namespace HPS.Present.SMS
{
    partial class SMSLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSLogForm));
            this.SmsLogToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ClosetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SMSGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FromDatetextBox = new FarsiLibrary.Win.Controls.FADatePicker();
            this.TodatetextBox = new FarsiLibrary.Win.Controls.FADatePicker();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SMSBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.colMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivedMessage_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSendMessage_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentDate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentTime_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmsLogToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SMSGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SmsLogToolStrip
            // 
            this.SmsLogToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SmsLogToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.ClosetoolStripButton});
            this.SmsLogToolStrip.Location = new System.Drawing.Point(0, 0);
            this.SmsLogToolStrip.Name = "SmsLogToolStrip";
            this.SmsLogToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.SmsLogToolStrip.Size = new System.Drawing.Size(796, 31);
            this.SmsLogToolStrip.TabIndex = 10;
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(28, 28);
            this.RefreshButton.Text = "بازیابی مجدد اطلاعات";
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
            // SMSGridView
            // 
            this.SMSGridView.AllowUserToAddRows = false;
            this.SMSGridView.AllowUserToDeleteRows = false;
            this.SMSGridView.AllowUserToResizeRows = false;
            this.SMSGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SMSGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.SMSGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SMSGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMobile_nvc,
            this.colReceivedMessage_nvc,
            this.colSendMessage_nvc,
            this.colName_nvc,
            this.colCurrentDate_nvc,
            this.colCurrentTime_nvc});
            this.SMSGridView.Location = new System.Drawing.Point(0, 97);
            this.SMSGridView.Margin = new System.Windows.Forms.Padding(5);
            this.SMSGridView.MultiSelect = false;
            this.SMSGridView.Name = "SMSGridView";
            this.SMSGridView.ReadOnly = true;
            this.SMSGridView.RowHeadersVisible = false;
            this.SMSGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SMSGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SMSGridView.Size = new System.Drawing.Size(620, 361);
            this.SMSGridView.TabIndex = 14;
            this.SMSGridView.SelectionChanged += new System.EventHandler(this.SMSGridView_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FromDatetextBox);
            this.groupBox1.Controls.Add(this.TodatetextBox);
            this.groupBox1.Controls.Add(this.Searchbutton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // FromDatetextBox
            // 
            this.FromDatetextBox.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatetextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FromDatetextBox.Location = new System.Drawing.Point(518, 24);
            this.FromDatetextBox.Name = "FromDatetextBox";
            this.FromDatetextBox.Size = new System.Drawing.Size(189, 20);
            this.FromDatetextBox.TabIndex = 30;
            this.FromDatetextBox.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // TodatetextBox
            // 
            this.TodatetextBox.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TodatetextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TodatetextBox.Location = new System.Drawing.Point(263, 24);
            this.TodatetextBox.Name = "TodatetextBox";
            this.TodatetextBox.Size = new System.Drawing.Size(189, 20);
            this.TodatetextBox.TabIndex = 29;
            this.TodatetextBox.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("B Mitra", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Searchbutton.Location = new System.Drawing.Point(6, 17);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(78, 33);
            this.Searchbutton.TabIndex = 9;
            this.Searchbutton.Text = "نمایش";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mitra", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(458, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(712, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "از تاریخ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Mitra", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(632, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "متن پیام ارسالی";
            // 
            // SMSBodyTextBox
            // 
            this.SMSBodyTextBox.Location = new System.Drawing.Point(632, 128);
            this.SMSBodyTextBox.Name = "SMSBodyTextBox";
            this.SMSBodyTextBox.Size = new System.Drawing.Size(156, 310);
            this.SMSBodyTextBox.TabIndex = 17;
            this.SMSBodyTextBox.Text = "";
            // 
            // colMobile_nvc
            // 
            this.colMobile_nvc.DataPropertyName = "Mobile_nvc";
            this.colMobile_nvc.HeaderText = "شماره فرستنده";
            this.colMobile_nvc.Name = "colMobile_nvc";
            this.colMobile_nvc.ReadOnly = true;
            this.colMobile_nvc.Width = 180;
            // 
            // colReceivedMessage_nvc
            // 
            this.colReceivedMessage_nvc.DataPropertyName = "ReceivedMessage_nvc";
            this.colReceivedMessage_nvc.HeaderText = "پیام دریافتی";
            this.colReceivedMessage_nvc.Name = "colReceivedMessage_nvc";
            this.colReceivedMessage_nvc.ReadOnly = true;
            // 
            // colSendMessage_nvc
            // 
            this.colSendMessage_nvc.DataPropertyName = "SendMessage_nvc";
            this.colSendMessage_nvc.HeaderText = "پیام ارسالی";
            this.colSendMessage_nvc.Name = "colSendMessage_nvc";
            this.colSendMessage_nvc.ReadOnly = true;
            this.colSendMessage_nvc.Visible = false;
            // 
            // colName_nvc
            // 
            this.colName_nvc.DataPropertyName = "Name_nvc";
            this.colName_nvc.HeaderText = "مشخصات";
            this.colName_nvc.Name = "colName_nvc";
            this.colName_nvc.ReadOnly = true;
            this.colName_nvc.Width = 120;
            // 
            // colCurrentDate_nvc
            // 
            this.colCurrentDate_nvc.DataPropertyName = "CurrentDate_nvc";
            this.colCurrentDate_nvc.HeaderText = "تاریخ ارسال";
            this.colCurrentDate_nvc.Name = "colCurrentDate_nvc";
            this.colCurrentDate_nvc.ReadOnly = true;
            // 
            // colCurrentTime_nvc
            // 
            this.colCurrentTime_nvc.DataPropertyName = "CurrentTime_nvc";
            this.colCurrentTime_nvc.HeaderText = "ساعت ارسال";
            this.colCurrentTime_nvc.Name = "colCurrentTime_nvc";
            this.colCurrentTime_nvc.ReadOnly = true;
            this.colCurrentTime_nvc.Width = 120;
            // 
            // SMSLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 440);
            this.Controls.Add(this.SMSBodyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SMSGridView);
            this.Controls.Add(this.SmsLogToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SMSLogForm";
            this.Text = "تاریخچه پیام  کوتاه ها";
            this.Load += new System.EventHandler(this.SMSLogForm_Load);
            this.SmsLogToolStrip.ResumeLayout(false);
            this.SmsLogToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SMSGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip SmsLogToolStrip;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton ClosetoolStripButton;
        private System.Windows.Forms.DataGridView SMSGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox SMSBodyTextBox;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatetextBox;
        private FarsiLibrary.Win.Controls.FADatePicker TodatetextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivedMessage_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSendMessage_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentDate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentTime_nvc;
    }
}