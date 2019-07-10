namespace HPS.Present.SMS
{
    partial class SendNewsToDiriversForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Showbutton = new System.Windows.Forms.Button();
            this.ShowAllbutton = new System.Windows.Forms.Button();
            this.OperatorcomboBox = new System.Windows.Forms.ComboBox();
            this.FieldNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DriverSelectButton = new System.Windows.Forms.Button();
            this.DriversdataGridView = new System.Windows.Forms.DataGridView();
            this.DriverSearchtextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NewsReversbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NewsSearchtextBox = new System.Windows.Forms.TextBox();
            this.NewsdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNews_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChecked_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFullName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversdataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SearchtextBox);
            this.tabPage1.Controls.Add(this.Showbutton);
            this.tabPage1.Controls.Add(this.ShowAllbutton);
            this.tabPage1.Controls.Add(this.OperatorcomboBox);
            this.tabPage1.Controls.Add(this.FieldNamecomboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DriverSelectButton);
            this.tabPage1.Controls.Add(this.DriversdataGridView);
            this.tabPage1.Controls.Add(this.DriverSearchtextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "رانندگان";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(166, 14);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(141, 21);
            this.SearchtextBox.TabIndex = 2;
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(80, 9);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(74, 28);
            this.Showbutton.TabIndex = 3;
            this.Showbutton.Text = "نمایش";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // ShowAllbutton
            // 
            this.ShowAllbutton.Location = new System.Drawing.Point(6, 9);
            this.ShowAllbutton.Name = "ShowAllbutton";
            this.ShowAllbutton.Size = new System.Drawing.Size(74, 28);
            this.ShowAllbutton.TabIndex = 4;
            this.ShowAllbutton.Text = "نمایش همه";
            this.ShowAllbutton.UseVisualStyleBackColor = true;
            this.ShowAllbutton.Click += new System.EventHandler(this.ShowAllbutton_Click);
            // 
            // OperatorcomboBox
            // 
            this.OperatorcomboBox.FormattingEnabled = true;
            this.OperatorcomboBox.Items.AddRange(new object[] {
            "مساوی",
            "شامل",
            "ناشامل",
            "کوچکتر",
            "بزرگتر"});
            this.OperatorcomboBox.Location = new System.Drawing.Point(310, 14);
            this.OperatorcomboBox.Name = "OperatorcomboBox";
            this.OperatorcomboBox.Size = new System.Drawing.Size(102, 21);
            this.OperatorcomboBox.TabIndex = 1;
            // 
            // FieldNamecomboBox
            // 
            this.FieldNamecomboBox.FormattingEnabled = true;
            this.FieldNamecomboBox.Items.AddRange(new object[] {
            "نام",
            "نام خانوادگی",
            "شماره موبایل",
            "کد ملی",
            "شماره کارت"});
            this.FieldNamecomboBox.Location = new System.Drawing.Point(414, 14);
            this.FieldNamecomboBox.Name = "FieldNamecomboBox";
            this.FieldNamecomboBox.Size = new System.Drawing.Size(102, 21);
            this.FieldNamecomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "جستجو";
            // 
            // DriverSelectButton
            // 
            this.DriverSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverSelectButton.BackgroundImage = global::HPS.Properties.Resources.InverseSelectDown;
            this.DriverSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DriverSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DriverSelectButton.Location = new System.Drawing.Point(493, 505);
            this.DriverSelectButton.Name = "DriverSelectButton";
            this.DriverSelectButton.Size = new System.Drawing.Size(20, 23);
            this.DriverSelectButton.TabIndex = 8;
            this.DriverSelectButton.UseVisualStyleBackColor = true;
            this.DriverSelectButton.Click += new System.EventHandler(this.DriverSelectButton_Click);
            // 
            // DriversdataGridView
            // 
            this.DriversdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DriversdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DriversdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriversdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDriverID_bint,
            this.colMobile_nvc,
            this.colChecked_bit,
            this.colFullName_nvc});
            this.DriversdataGridView.Location = new System.Drawing.Point(6, 72);
            this.DriversdataGridView.Name = "DriversdataGridView";
            this.DriversdataGridView.RowHeadersVisible = false;
            this.DriversdataGridView.Size = new System.Drawing.Size(507, 430);
            this.DriversdataGridView.TabIndex = 7;
            // 
            // DriverSearchtextBox
            // 
            this.DriverSearchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverSearchtextBox.Location = new System.Drawing.Point(6, 45);
            this.DriverSearchtextBox.Name = "DriverSearchtextBox";
            this.DriverSearchtextBox.Size = new System.Drawing.Size(459, 21);
            this.DriverSearchtextBox.TabIndex = 6;
            this.DriverSearchtextBox.TextChanged += new System.EventHandler(this.DriverSearchtextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NewsReversbutton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.NewsSearchtextBox);
            this.tabPage2.Controls.Add(this.NewsdataGridView);
            this.tabPage2.Controls.Add(this.Cancelbutton);
            this.tabPage2.Controls.Add(this.Sendbutton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "لیست اخبار";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewsReversbutton
            // 
            this.NewsReversbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsReversbutton.BackgroundImage = global::HPS.Properties.Resources.InverseSelectDown;
            this.NewsReversbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewsReversbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewsReversbutton.Location = new System.Drawing.Point(494, 501);
            this.NewsReversbutton.Name = "NewsReversbutton";
            this.NewsReversbutton.Size = new System.Drawing.Size(20, 23);
            this.NewsReversbutton.TabIndex = 10;
            this.NewsReversbutton.UseVisualStyleBackColor = true;
            this.NewsReversbutton.Click += new System.EventHandler(this.NewsReversbutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "جستجو";
            // 
            // NewsSearchtextBox
            // 
            this.NewsSearchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsSearchtextBox.Location = new System.Drawing.Point(7, 6);
            this.NewsSearchtextBox.Name = "NewsSearchtextBox";
            this.NewsSearchtextBox.Size = new System.Drawing.Size(459, 21);
            this.NewsSearchtextBox.TabIndex = 8;
            this.NewsSearchtextBox.TextChanged += new System.EventHandler(this.NewsSearchtextBox_TextChanged);
            // 
            // NewsdataGridView
            // 
            this.NewsdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.colNews_nvc});
            this.NewsdataGridView.Location = new System.Drawing.Point(7, 31);
            this.NewsdataGridView.Name = "NewsdataGridView";
            this.NewsdataGridView.RowHeadersVisible = false;
            this.NewsdataGridView.Size = new System.Drawing.Size(507, 456);
            this.NewsdataGridView.TabIndex = 4;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Checked_bit";
            this.dataGridViewCheckBoxColumn1.HeaderText = "انتخاب";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title_nvc";
            this.dataGridViewTextBoxColumn3.HeaderText = "عنوان خبر";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 450;
            // 
            // colNews_nvc
            // 
            this.colNews_nvc.DataPropertyName = "News_nvc";
            this.colNews_nvc.HeaderText = "colNews_nvc";
            this.colNews_nvc.Name = "colNews_nvc";
            this.colNews_nvc.Visible = false;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(7, 493);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 31);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "انصراف";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(82, 493);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 31);
            this.Sendbutton.TabIndex = 2;
            this.Sendbutton.Text = "ارسال";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.HeaderText = "colDriverID_bint";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.Visible = false;
            // 
            // colMobile_nvc
            // 
            this.colMobile_nvc.DataPropertyName = "DriverMobileNumber_nvc";
            this.colMobile_nvc.HeaderText = "colMobile_nvc";
            this.colMobile_nvc.Name = "colMobile_nvc";
            this.colMobile_nvc.Visible = false;
            // 
            // colChecked_bit
            // 
            this.colChecked_bit.DataPropertyName = "Checked_bit";
            this.colChecked_bit.HeaderText = "انتخاب";
            this.colChecked_bit.Name = "colChecked_bit";
            this.colChecked_bit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChecked_bit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colChecked_bit.Width = 45;
            // 
            // colFullName_nvc
            // 
            this.colFullName_nvc.DataPropertyName = "FullName_nvc";
            this.colFullName_nvc.HeaderText = "نام و نام خانوادگی";
            this.colFullName_nvc.Name = "colFullName_nvc";
            this.colFullName_nvc.Width = 450;
            // 
            // SendNewsToDiriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 558);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendNewsToDiriversForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ارسال اخبار به رانندگان";
            this.Load += new System.EventHandler(this.SendNewsToDiriversForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversdataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox DriverSearchtextBox;
        private System.Windows.Forms.DataGridView DriversdataGridView;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Sendbutton;
        internal System.Windows.Forms.Button DriverSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView NewsdataGridView;
        internal System.Windows.Forms.Button NewsReversbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewsSearchtextBox;
        private System.Windows.Forms.ComboBox FieldNamecomboBox;
        private System.Windows.Forms.ComboBox OperatorcomboBox;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button ShowAllbutton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNews_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName_nvc;
    }
}