namespace HPS.Present.Common
{
    partial class ExportDataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BasicDataFilePathTextBox = new System.Windows.Forms.TextBox();
            this.BasicDataBrowsButton = new System.Windows.Forms.Button();
            this.ConvertBotton = new System.Windows.Forms.Button();
            this.BasicDataGroupBox = new System.Windows.Forms.GroupBox();
            this.BasicDataClearButton = new System.Windows.Forms.Button();
            this.GoodComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.PlateCityComboBox = new System.Windows.Forms.ComboBox();
            this.BoxingComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LaderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DriverGroupBox = new System.Windows.Forms.GroupBox();
            this.DriverClearButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.DriverFilePathTextBox = new System.Windows.Forms.TextBox();
            this.DriverBrowsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarClearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CarFilePathTextBox = new System.Windows.Forms.TextBox();
            this.CarBrowsButton = new System.Windows.Forms.Button();
            this.BasicDataGroupBox.SuspendLayout();
            this.DriverGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسیر فایل اکسس ";
            // 
            // BasicDataFilePathTextBox
            // 
            this.BasicDataFilePathTextBox.Location = new System.Drawing.Point(73, 32);
            this.BasicDataFilePathTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.BasicDataFilePathTextBox.Name = "BasicDataFilePathTextBox";
            this.BasicDataFilePathTextBox.ReadOnly = true;
            this.BasicDataFilePathTextBox.Size = new System.Drawing.Size(457, 30);
            this.BasicDataFilePathTextBox.TabIndex = 1;
            // 
            // BasicDataBrowsButton
            // 
            this.BasicDataBrowsButton.BackgroundImage = global::HPS.Properties.Resources.Browse;
            this.BasicDataBrowsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BasicDataBrowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasicDataBrowsButton.Location = new System.Drawing.Point(41, 32);
            this.BasicDataBrowsButton.Margin = new System.Windows.Forms.Padding(5);
            this.BasicDataBrowsButton.Name = "BasicDataBrowsButton";
            this.BasicDataBrowsButton.Size = new System.Drawing.Size(30, 30);
            this.BasicDataBrowsButton.TabIndex = 2;
            this.BasicDataBrowsButton.UseVisualStyleBackColor = true;
            this.BasicDataBrowsButton.Click += new System.EventHandler(this.BasicDataBrowsButton_Click);
            // 
            // ConvertBotton
            // 
            this.ConvertBotton.Location = new System.Drawing.Point(533, 342);
            this.ConvertBotton.Margin = new System.Windows.Forms.Padding(5);
            this.ConvertBotton.Name = "ConvertBotton";
            this.ConvertBotton.Size = new System.Drawing.Size(125, 41);
            this.ConvertBotton.TabIndex = 3;
            this.ConvertBotton.Text = "تبدیل";
            this.ConvertBotton.UseVisualStyleBackColor = true;
            this.ConvertBotton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // BasicDataGroupBox
            // 
            this.BasicDataGroupBox.Controls.Add(this.BasicDataClearButton);
            this.BasicDataGroupBox.Controls.Add(this.GoodComboBox);
            this.BasicDataGroupBox.Controls.Add(this.CityComboBox);
            this.BasicDataGroupBox.Controls.Add(this.PlateCityComboBox);
            this.BasicDataGroupBox.Controls.Add(this.BoxingComboBox);
            this.BasicDataGroupBox.Controls.Add(this.label7);
            this.BasicDataGroupBox.Controls.Add(this.label6);
            this.BasicDataGroupBox.Controls.Add(this.label5);
            this.BasicDataGroupBox.Controls.Add(this.label4);
            this.BasicDataGroupBox.Controls.Add(this.LaderTypeComboBox);
            this.BasicDataGroupBox.Controls.Add(this.label3);
            this.BasicDataGroupBox.Controls.Add(this.label1);
            this.BasicDataGroupBox.Controls.Add(this.BasicDataFilePathTextBox);
            this.BasicDataGroupBox.Controls.Add(this.BasicDataBrowsButton);
            this.BasicDataGroupBox.Location = new System.Drawing.Point(9, 3);
            this.BasicDataGroupBox.Name = "BasicDataGroupBox";
            this.BasicDataGroupBox.Size = new System.Drawing.Size(649, 180);
            this.BasicDataGroupBox.TabIndex = 0;
            this.BasicDataGroupBox.TabStop = false;
            this.BasicDataGroupBox.Text = "اطلاعات پایه";
            // 
            // BasicDataClearButton
            // 
            this.BasicDataClearButton.BackgroundImage = global::HPS.Properties.Resources.Delete;
            this.BasicDataClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BasicDataClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasicDataClearButton.Location = new System.Drawing.Point(8, 32);
            this.BasicDataClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.BasicDataClearButton.Name = "BasicDataClearButton";
            this.BasicDataClearButton.Size = new System.Drawing.Size(30, 30);
            this.BasicDataClearButton.TabIndex = 3;
            this.BasicDataClearButton.UseVisualStyleBackColor = true;
            this.BasicDataClearButton.Click += new System.EventHandler(this.BasicDataClearButton_Click);
            // 
            // GoodComboBox
            // 
            this.GoodComboBox.FormattingEnabled = true;
            this.GoodComboBox.Location = new System.Drawing.Point(8, 103);
            this.GoodComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.GoodComboBox.Name = "GoodComboBox";
            this.GoodComboBox.Size = new System.Drawing.Size(209, 31);
            this.GoodComboBox.TabIndex = 11;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(321, 103);
            this.CityComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(209, 31);
            this.CityComboBox.TabIndex = 9;
            // 
            // PlateCityComboBox
            // 
            this.PlateCityComboBox.FormattingEnabled = true;
            this.PlateCityComboBox.Location = new System.Drawing.Point(321, 139);
            this.PlateCityComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityComboBox.Name = "PlateCityComboBox";
            this.PlateCityComboBox.Size = new System.Drawing.Size(209, 31);
            this.PlateCityComboBox.TabIndex = 13;
            // 
            // BoxingComboBox
            // 
            this.BoxingComboBox.FormattingEnabled = true;
            this.BoxingComboBox.Location = new System.Drawing.Point(8, 67);
            this.BoxingComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.BoxingComboBox.Name = "BoxingComboBox";
            this.BoxingComboBox.Size = new System.Drawing.Size(209, 31);
            this.BoxingComboBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "کالا";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "شهر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "نوع بسته بندی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "شهر شماره گذاری";
            // 
            // LaderTypeComboBox
            // 
            this.LaderTypeComboBox.FormattingEnabled = true;
            this.LaderTypeComboBox.Location = new System.Drawing.Point(321, 67);
            this.LaderTypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeComboBox.Name = "LaderTypeComboBox";
            this.LaderTypeComboBox.Size = new System.Drawing.Size(209, 31);
            this.LaderTypeComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع بارگیر";
            // 
            // DriverGroupBox
            // 
            this.DriverGroupBox.Controls.Add(this.DriverClearButton);
            this.DriverGroupBox.Controls.Add(this.label12);
            this.DriverGroupBox.Controls.Add(this.DriverFilePathTextBox);
            this.DriverGroupBox.Controls.Add(this.DriverBrowsButton);
            this.DriverGroupBox.Location = new System.Drawing.Point(9, 185);
            this.DriverGroupBox.Name = "DriverGroupBox";
            this.DriverGroupBox.Size = new System.Drawing.Size(649, 73);
            this.DriverGroupBox.TabIndex = 1;
            this.DriverGroupBox.TabStop = false;
            this.DriverGroupBox.Text = "اطلاعات راننده";
            // 
            // DriverClearButton
            // 
            this.DriverClearButton.BackgroundImage = global::HPS.Properties.Resources.Delete;
            this.DriverClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DriverClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverClearButton.Location = new System.Drawing.Point(8, 32);
            this.DriverClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.DriverClearButton.Name = "DriverClearButton";
            this.DriverClearButton.Size = new System.Drawing.Size(30, 30);
            this.DriverClearButton.TabIndex = 3;
            this.DriverClearButton.UseVisualStyleBackColor = true;
            this.DriverClearButton.Click += new System.EventHandler(this.DriverClearButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "مسیر فایل اکسس ";
            // 
            // DriverFilePathTextBox
            // 
            this.DriverFilePathTextBox.Location = new System.Drawing.Point(73, 32);
            this.DriverFilePathTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverFilePathTextBox.Name = "DriverFilePathTextBox";
            this.DriverFilePathTextBox.ReadOnly = true;
            this.DriverFilePathTextBox.Size = new System.Drawing.Size(457, 30);
            this.DriverFilePathTextBox.TabIndex = 1;
            // 
            // DriverBrowsButton
            // 
            this.DriverBrowsButton.BackgroundImage = global::HPS.Properties.Resources.Browse;
            this.DriverBrowsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DriverBrowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DriverBrowsButton.Location = new System.Drawing.Point(41, 32);
            this.DriverBrowsButton.Margin = new System.Windows.Forms.Padding(5);
            this.DriverBrowsButton.Name = "DriverBrowsButton";
            this.DriverBrowsButton.Size = new System.Drawing.Size(30, 30);
            this.DriverBrowsButton.TabIndex = 2;
            this.DriverBrowsButton.UseVisualStyleBackColor = true;
            this.DriverBrowsButton.Click += new System.EventHandler(this.DriverBrowsButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarClearButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CarFilePathTextBox);
            this.groupBox2.Controls.Add(this.CarBrowsButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات ناوگان";
            // 
            // CarClearButton
            // 
            this.CarClearButton.BackgroundImage = global::HPS.Properties.Resources.Delete;
            this.CarClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarClearButton.Location = new System.Drawing.Point(8, 32);
            this.CarClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.CarClearButton.Name = "CarClearButton";
            this.CarClearButton.Size = new System.Drawing.Size(30, 30);
            this.CarClearButton.TabIndex = 3;
            this.CarClearButton.UseVisualStyleBackColor = true;
            this.CarClearButton.Click += new System.EventHandler(this.CarClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "مسیر فایل اکسس ";
            // 
            // CarFilePathTextBox
            // 
            this.CarFilePathTextBox.Location = new System.Drawing.Point(73, 32);
            this.CarFilePathTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarFilePathTextBox.Name = "CarFilePathTextBox";
            this.CarFilePathTextBox.ReadOnly = true;
            this.CarFilePathTextBox.Size = new System.Drawing.Size(457, 30);
            this.CarFilePathTextBox.TabIndex = 1;
            // 
            // CarBrowsButton
            // 
            this.CarBrowsButton.BackgroundImage = global::HPS.Properties.Resources.Browse;
            this.CarBrowsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarBrowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarBrowsButton.Location = new System.Drawing.Point(41, 32);
            this.CarBrowsButton.Margin = new System.Windows.Forms.Padding(5);
            this.CarBrowsButton.Name = "CarBrowsButton";
            this.CarBrowsButton.Size = new System.Drawing.Size(30, 30);
            this.CarBrowsButton.TabIndex = 2;
            this.CarBrowsButton.UseVisualStyleBackColor = true;
            this.CarBrowsButton.Click += new System.EventHandler(this.CarBrowsButton_Click);
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DriverGroupBox);
            this.Controls.Add(this.BasicDataGroupBox);
            this.Controls.Add(this.ConvertBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "ExportDataForm";
            this.Text = "انتقال دادها از Access";
            this.BasicDataGroupBox.ResumeLayout(false);
            this.BasicDataGroupBox.PerformLayout();
            this.DriverGroupBox.ResumeLayout(false);
            this.DriverGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BasicDataFilePathTextBox;
        private System.Windows.Forms.Button BasicDataBrowsButton;
        private System.Windows.Forms.Button ConvertBotton;
        private System.Windows.Forms.GroupBox BasicDataGroupBox;
        private System.Windows.Forms.ComboBox BoxingComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LaderTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GoodComboBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.ComboBox PlateCityComboBox;
        private System.Windows.Forms.GroupBox DriverGroupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DriverFilePathTextBox;
        private System.Windows.Forms.Button DriverBrowsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarFilePathTextBox;
        private System.Windows.Forms.Button CarBrowsButton;
        private System.Windows.Forms.Button BasicDataClearButton;
        private System.Windows.Forms.Button DriverClearButton;
        private System.Windows.Forms.Button CarClearButton;
    }
}