namespace HPS.Present.SMS
{
    partial class SendTextToDiriversForm
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
            this.colDriverID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChecked_bit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFullName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverSearchtextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTextrichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversdataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(525, 535);
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
            this.tabPage1.Size = new System.Drawing.Size(517, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "رانندگان";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(164, 12);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(141, 21);
            this.SearchtextBox.TabIndex = 2;
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(78, 7);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(74, 28);
            this.Showbutton.TabIndex = 3;
            this.Showbutton.Text = "نمایش";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // ShowAllbutton
            // 
            this.ShowAllbutton.Location = new System.Drawing.Point(4, 7);
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
            this.OperatorcomboBox.Location = new System.Drawing.Point(308, 12);
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
            this.FieldNamecomboBox.Location = new System.Drawing.Point(412, 12);
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
            this.label1.Location = new System.Drawing.Point(468, 44);
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
            this.DriverSelectButton.Location = new System.Drawing.Point(488, 480);
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
            this.DriversdataGridView.Location = new System.Drawing.Point(6, 68);
            this.DriversdataGridView.Name = "DriversdataGridView";
            this.DriversdataGridView.RowHeadersVisible = false;
            this.DriversdataGridView.Size = new System.Drawing.Size(505, 410);
            this.DriversdataGridView.TabIndex = 7;
            // 
            // colDriverID_bint
            // 
            this.colDriverID_bint.HeaderText = "colDriverID_bint";
            this.colDriverID_bint.Name = "colDriverID_bint";
            this.colDriverID_bint.Visible = false;
            // 
            // colMobile_nvc
            // 
            this.colMobile_nvc.DataPropertyName = "Mobile_nvc";
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
            this.colFullName_nvc.Width = 420;
            // 
            // DriverSearchtextBox
            // 
            this.DriverSearchtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverSearchtextBox.Location = new System.Drawing.Point(6, 41);
            this.DriverSearchtextBox.Name = "DriverSearchtextBox";
            this.DriverSearchtextBox.Size = new System.Drawing.Size(457, 21);
            this.DriverSearchtextBox.TabIndex = 6;
            this.DriverSearchtextBox.TextChanged += new System.EventHandler(this.DriverSearchtextBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Cancelbutton);
            this.tabPage2.Controls.Add(this.Sendbutton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.MessageTextrichTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "متن پیام";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(362, 475);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 31);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "انصراف";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(437, 475);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(75, 31);
            this.Sendbutton.TabIndex = 2;
            this.Sendbutton.Text = "ارسال";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "متن پیام را در  قسمت زیر وارد کنید";
            // 
            // MessageTextrichTextBox
            // 
            this.MessageTextrichTextBox.Location = new System.Drawing.Point(6, 25);
            this.MessageTextrichTextBox.Name = "MessageTextrichTextBox";
            this.MessageTextrichTextBox.Size = new System.Drawing.Size(505, 444);
            this.MessageTextrichTextBox.TabIndex = 0;
            this.MessageTextrichTextBox.Text = "";
            // 
            // SendTextToDiriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 535);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendTextToDiriversForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ارسال متن به رانندگان";
            this.Load += new System.EventHandler(this.SendTextToDiriversForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriversdataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox DriverSearchtextBox;
        private System.Windows.Forms.DataGridView DriversdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MessageTextrichTextBox;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Sendbutton;
        internal System.Windows.Forms.Button DriverSelectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile_nvc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName_nvc;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Button ShowAllbutton;
        private System.Windows.Forms.ComboBox OperatorcomboBox;
        private System.Windows.Forms.ComboBox FieldNamecomboBox;
    }
}