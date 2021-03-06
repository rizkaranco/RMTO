﻿namespace HPS.Reports.Forms
{
    partial class InTrafficReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InTrafficReportForm));
            this.AllIranianCarRadioButton = new System.Windows.Forms.RadioButton();
            this.LaderPivotGroupID_intLabel = new System.Windows.Forms.Label();
            this.LaderPivotGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FromTrafficNumbertxt = new System.Windows.Forms.TextBox();
            this.ToTrafficNumbertxt = new System.Windows.Forms.TextBox();
            this.LaderTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LaderType_nvcSearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrafficTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ServicescomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AllTurnradioButton = new System.Windows.Forms.RadioButton();
            this.TurnAcceptedradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExportExcelButton = new Janus.Windows.EditControls.UIButton();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.IranianInTrafficstiReport = new Stimulsoft.Report.StiReport();
            this.ForeignInTrafficReportStiReport = new Stimulsoft.Report.StiReport();
            this.OtherInTrafficStiReport = new Stimulsoft.Report.StiReport();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllIranianCarRadioButton
            // 
            this.AllIranianCarRadioButton.AutoSize = true;
            this.AllIranianCarRadioButton.Checked = true;
            this.AllIranianCarRadioButton.Location = new System.Drawing.Point(214, 15);
            this.AllIranianCarRadioButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AllIranianCarRadioButton.Name = "AllIranianCarRadioButton";
            this.AllIranianCarRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllIranianCarRadioButton.Size = new System.Drawing.Size(144, 22);
            this.AllIranianCarRadioButton.TabIndex = 0;
            this.AllIranianCarRadioButton.TabStop = true;
            this.AllIranianCarRadioButton.Text = "تمامی کامیون ها :";
            this.AllIranianCarRadioButton.UseVisualStyleBackColor = true;
            this.AllIranianCarRadioButton.CheckedChanged += new System.EventHandler(this.AllIranianCarRadioButton_CheckedChanged);
            // 
            // LaderPivotGroupID_intLabel
            // 
            this.LaderPivotGroupID_intLabel.AutoSize = true;
            this.LaderPivotGroupID_intLabel.Location = new System.Drawing.Point(286, 66);
            this.LaderPivotGroupID_intLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LaderPivotGroupID_intLabel.Name = "LaderPivotGroupID_intLabel";
            this.LaderPivotGroupID_intLabel.Size = new System.Drawing.Size(83, 18);
            this.LaderPivotGroupID_intLabel.TabIndex = 24;
            this.LaderPivotGroupID_intLabel.Text = "تعداد محور :";
            // 
            // LaderPivotGroupID_intComboBox
            // 
            this.LaderPivotGroupID_intComboBox.FormattingEnabled = true;
            this.LaderPivotGroupID_intComboBox.Location = new System.Drawing.Point(50, 61);
            this.LaderPivotGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.LaderPivotGroupID_intComboBox.Name = "LaderPivotGroupID_intComboBox";
            this.LaderPivotGroupID_intComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LaderPivotGroupID_intComboBox.Size = new System.Drawing.Size(230, 26);
            this.LaderPivotGroupID_intComboBox.TabIndex = 0;
            this.LaderPivotGroupID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.LaderPivotGroupID_intComboBox_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(850, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "از قبض شماره :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(850, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "تا قبض شماره :";
            // 
            // FromTrafficNumbertxt
            // 
            this.FromTrafficNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTrafficNumbertxt.Location = new System.Drawing.Point(674, 32);
            this.FromTrafficNumbertxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.FromTrafficNumbertxt.Name = "FromTrafficNumbertxt";
            this.FromTrafficNumbertxt.Size = new System.Drawing.Size(174, 26);
            this.FromTrafficNumbertxt.TabIndex = 4;
            // 
            // ToTrafficNumbertxt
            // 
            this.ToTrafficNumbertxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTrafficNumbertxt.Location = new System.Drawing.Point(674, 79);
            this.ToTrafficNumbertxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ToTrafficNumbertxt.Name = "ToTrafficNumbertxt";
            this.ToTrafficNumbertxt.Size = new System.Drawing.Size(174, 26);
            this.ToTrafficNumbertxt.TabIndex = 5;
            // 
            // LaderTypeID_intComboBox
            // 
            this.LaderTypeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LaderTypeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LaderTypeID_intComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.LaderTypeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intComboBox.FormattingEnabled = true;
            this.LaderTypeID_intComboBox.Location = new System.Drawing.Point(50, 103);
            this.LaderTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.LaderTypeID_intComboBox.Name = "LaderTypeID_intComboBox";
            this.LaderTypeID_intComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LaderTypeID_intComboBox.Size = new System.Drawing.Size(230, 26);
            this.LaderTypeID_intComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(286, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "نوع بارگیر :";
            // 
            // LaderType_nvcSearchButton
            // 
            this.LaderType_nvcSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.LaderType_nvcSearchButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.LaderType_nvcSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderType_nvcSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderType_nvcSearchButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderType_nvcSearchButton.Location = new System.Drawing.Point(7, 100);
            this.LaderType_nvcSearchButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.LaderType_nvcSearchButton.Name = "LaderType_nvcSearchButton";
            this.LaderType_nvcSearchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LaderType_nvcSearchButton.Size = new System.Drawing.Size(38, 39);
            this.LaderType_nvcSearchButton.TabIndex = 2;
            this.LaderType_nvcSearchButton.TabStop = false;
            this.LaderType_nvcSearchButton.UseVisualStyleBackColor = false;
            this.LaderType_nvcSearchButton.Click += new System.EventHandler(this.LaderType_nvcSearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LaderPivotGroupID_intComboBox);
            this.groupBox1.Controls.Add(this.LaderTypeID_intComboBox);
            this.groupBox1.Controls.Add(this.LaderPivotGroupID_intLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AllIranianCarRadioButton);
            this.groupBox1.Controls.Add(this.LaderType_nvcSearchButton);
            this.groupBox1.Controls.Add(this.TrafficTypeID_intComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(262, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(406, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // TrafficTypeID_intComboBox
            // 
            this.TrafficTypeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TrafficTypeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TrafficTypeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficTypeID_intComboBox.FormattingEnabled = true;
            this.TrafficTypeID_intComboBox.Location = new System.Drawing.Point(50, 21);
            this.TrafficTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TrafficTypeID_intComboBox.Name = "TrafficTypeID_intComboBox";
            this.TrafficTypeID_intComboBox.Size = new System.Drawing.Size(238, 26);
            this.TrafficTypeID_intComboBox.TabIndex = 9;
            this.TrafficTypeID_intComboBox.TabStop = false;
            this.TrafficTypeID_intComboBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(850, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "مراجعه به :";
            // 
            // ServicescomboBox
            // 
            this.ServicescomboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ServicescomboBox.FormattingEnabled = true;
            this.ServicescomboBox.Location = new System.Drawing.Point(674, 126);
            this.ServicescomboBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ServicescomboBox.Name = "ServicescomboBox";
            this.ServicescomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ServicescomboBox.Size = new System.Drawing.Size(174, 26);
            this.ServicescomboBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AllTurnradioButton);
            this.groupBox2.Controls.Add(this.TurnAcceptedradioButton);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(34, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox2.Size = new System.Drawing.Size(216, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // AllTurnradioButton
            // 
            this.AllTurnradioButton.AutoSize = true;
            this.AllTurnradioButton.Location = new System.Drawing.Point(17, 61);
            this.AllTurnradioButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AllTurnradioButton.Name = "AllTurnradioButton";
            this.AllTurnradioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllTurnradioButton.Size = new System.Drawing.Size(160, 22);
            this.AllTurnradioButton.TabIndex = 2;
            this.AllTurnradioButton.Text = "نوبت های تأیید نشده";
            this.AllTurnradioButton.UseVisualStyleBackColor = true;
            // 
            // TurnAcceptedradioButton
            // 
            this.TurnAcceptedradioButton.AutoSize = true;
            this.TurnAcceptedradioButton.Location = new System.Drawing.Point(17, 24);
            this.TurnAcceptedradioButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TurnAcceptedradioButton.Name = "TurnAcceptedradioButton";
            this.TurnAcceptedradioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TurnAcceptedradioButton.Size = new System.Drawing.Size(155, 22);
            this.TurnAcceptedradioButton.TabIndex = 0;
            this.TurnAcceptedradioButton.Text = "نوبت های تأیید شده";
            this.TurnAcceptedradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExportExcelButton);
            this.groupBox3.Controls.Add(this.ShowButton);
            this.groupBox3.Controls.Add(this.DefaulCheckBox);
            this.groupBox3.Controls.Add(this.TimeGroupBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.FromDatefaDatePicker);
            this.groupBox3.Controls.Add(this.ToDatefaDatePicker);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ServicescomboBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.ToTrafficNumbertxt);
            this.groupBox3.Controls.Add(this.FromTrafficNumbertxt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox3.Size = new System.Drawing.Size(1181, 203);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // ExportExcelButton
            // 
            this.ExportExcelButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ExportExcelButton.Location = new System.Drawing.Point(34, 130);
            this.ExportExcelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExportExcelButton.Name = "ExportExcelButton";
            this.ExportExcelButton.Size = new System.Drawing.Size(115, 37);
            this.ExportExcelButton.TabIndex = 297;
            this.ExportExcelButton.Text = "خروجی Excel";
            this.ExportExcelButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ExportExcelButton.Click += new System.EventHandler(this.ExportExcelButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(152, 130);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(91, 37);
            this.ShowButton.TabIndex = 297;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(1126, 82);
            this.DefaulCheckBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(20, 29);
            this.DefaulCheckBox.TabIndex = 296;
            this.DefaulCheckBox.ToolTipText = "ساعات بین 00:00:00 و 23:59:59";
            this.DefaulCheckBox.CheckedChanged += new System.EventHandler(this.DefaulCheckBox_CheckedChanged);
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.FromTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.RefreshHourbutton);
            this.TimeGroupBox.Controls.Add(this.label3);
            this.TimeGroupBox.Controls.Add(this.ToTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.label4);
            this.TimeGroupBox.Enabled = false;
            this.TimeGroupBox.Location = new System.Drawing.Point(952, 79);
            this.TimeGroupBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TimeGroupBox.Size = new System.Drawing.Size(210, 91);
            this.TimeGroupBox.TabIndex = 295;
            this.TimeGroupBox.TabStop = false;
            // 
            // FromTimeTextBox
            // 
            this.FromTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTimeTextBox.Location = new System.Drawing.Point(50, 26);
            this.FromTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FromTimeTextBox.Mask = "00:00:00";
            this.FromTimeTextBox.Name = "FromTimeTextBox";
            this.FromTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromTimeTextBox.Size = new System.Drawing.Size(71, 26);
            this.FromTimeTextBox.TabIndex = 59;
            this.FromTimeTextBox.Text = "000000";
            this.FromTimeTextBox.Click += new System.EventHandler(this.FromTimeTextBox_Click);
            // 
            // RefreshHourbutton
            // 
            this.RefreshHourbutton.Image = global::HPS.Properties.Resources.Refresh16;
            this.RefreshHourbutton.Location = new System.Drawing.Point(7, 55);
            this.RefreshHourbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RefreshHourbutton.Name = "RefreshHourbutton";
            this.RefreshHourbutton.Size = new System.Drawing.Size(29, 32);
            this.RefreshHourbutton.TabIndex = 61;
            this.RefreshHourbutton.UseVisualStyleBackColor = true;
            this.RefreshHourbutton.Click += new System.EventHandler(this.RefreshHourbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(132, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "از ساعت :";
            // 
            // ToTimeTextBox
            // 
            this.ToTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTimeTextBox.Location = new System.Drawing.Point(50, 58);
            this.ToTimeTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ToTimeTextBox.Mask = "00:00:00";
            this.ToTimeTextBox.Name = "ToTimeTextBox";
            this.ToTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToTimeTextBox.Size = new System.Drawing.Size(71, 26);
            this.ToTimeTextBox.TabIndex = 60;
            this.ToTimeTextBox.Text = "235959";
            this.ToTimeTextBox.Click += new System.EventHandler(this.ToTimeTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(132, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "تا ساعت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1104, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 294;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1104, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 293;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.IsDefault = true;
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(952, 20);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(138, 25);
            this.FromDatefaDatePicker.TabIndex = 291;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(952, 54);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(138, 25);
            this.ToDatefaDatePicker.TabIndex = 292;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(613, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 290;
            this.label9.Text = "نوع تردد :";
            this.label9.Visible = false;
            // 
            // IranianInTrafficstiReport
            // 
            this.IranianInTrafficstiReport.CookieContainer = null;
            this.IranianInTrafficstiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.IranianInTrafficstiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.IranianInTrafficstiReport.ReportAlias = "Report";
            this.IranianInTrafficstiReport.ReportGuid = "9e8910f8e8494be3a5526cb5a6ec8aa9";
            this.IranianInTrafficstiReport.ReportImage = null;
            this.IranianInTrafficstiReport.ReportName = "Report";
            this.IranianInTrafficstiReport.ReportSource = resources.GetString("IranianInTrafficstiReport.ReportSource");
            this.IranianInTrafficstiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.IranianInTrafficstiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.IranianInTrafficstiReport.UseProgressInThread = false;
            // 
            // ForeignInTrafficReportStiReport
            // 
            this.ForeignInTrafficReportStiReport.CookieContainer = null;
            this.ForeignInTrafficReportStiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ForeignInTrafficReportStiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.ForeignInTrafficReportStiReport.ReportAlias = "Report";
            this.ForeignInTrafficReportStiReport.ReportGuid = "9037c67910af464e9bc3acf4be383ee8";
            this.ForeignInTrafficReportStiReport.ReportImage = null;
            this.ForeignInTrafficReportStiReport.ReportName = "Report";
            this.ForeignInTrafficReportStiReport.ReportSource = resources.GetString("ForeignInTrafficReportStiReport.ReportSource");
            this.ForeignInTrafficReportStiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ForeignInTrafficReportStiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.ForeignInTrafficReportStiReport.UseProgressInThread = false;
            // 
            // OtherInTrafficStiReport
            // 
            this.OtherInTrafficStiReport.CookieContainer = null;
            this.OtherInTrafficStiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.OtherInTrafficStiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.OtherInTrafficStiReport.ReportAlias = "Report";
            this.OtherInTrafficStiReport.ReportGuid = "5deed85bdbde4985bdc30d38b50832a0";
            this.OtherInTrafficStiReport.ReportImage = null;
            this.OtherInTrafficStiReport.ReportName = "Report";
            this.OtherInTrafficStiReport.ReportSource = resources.GetString("OtherInTrafficStiReport.ReportSource");
            this.OtherInTrafficStiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.OtherInTrafficStiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.OtherInTrafficStiReport.UseProgressInThread = false;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(0, 203);
            this.stiViewerControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowBookmarksPanel = false;
            this.stiViewerControl1.ShowCloseButton = false;
            this.stiViewerControl1.ShowContextMenu = false;
            this.stiViewerControl1.ShowDotMatrixModeButton = false;
            this.stiViewerControl1.ShowEditor = false;
            this.stiViewerControl1.ShowFind = false;
            this.stiViewerControl1.ShowOpen = false;
            this.stiViewerControl1.ShowPageDelete = false;
            this.stiViewerControl1.ShowPageDesign = false;
            this.stiViewerControl1.ShowPageNew = false;
            this.stiViewerControl1.ShowPageSize = false;
            this.stiViewerControl1.ShowSaveDocumentFile = false;
            this.stiViewerControl1.ShowSendEMail = false;
            this.stiViewerControl1.ShowSendEMailDocumentFile = false;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(1181, 506);
            this.stiViewerControl1.TabIndex = 37;
            // 
            // InTrafficReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 709);
            this.Controls.Add(this.stiViewerControl1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Name = "InTrafficReportForm";
            this.Text = "گزارش كاميون های ايراني ورودي به  پاركينگ  ";
            this.Load += new System.EventHandler(this.InTrafficReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton AllIranianCarRadioButton;
        private System.Windows.Forms.Label LaderPivotGroupID_intLabel;
        private System.Windows.Forms.ComboBox LaderPivotGroupID_intComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FromTrafficNumbertxt;
        private System.Windows.Forms.TextBox ToTrafficNumbertxt;
        private System.Windows.Forms.ComboBox LaderTypeID_intComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LaderType_nvcSearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ServicescomboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AllTurnradioButton;
        private System.Windows.Forms.RadioButton TurnAcceptedradioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TrafficTypeID_intComboBox;
        private System.Windows.Forms.Label label9;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private Stimulsoft.Report.StiReport IranianInTrafficstiReport;
        private Stimulsoft.Report.StiReport ForeignInTrafficReportStiReport;
        private Stimulsoft.Report.StiReport OtherInTrafficStiReport;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private Janus.Windows.EditControls.UIButton ExportExcelButton;
    }
}