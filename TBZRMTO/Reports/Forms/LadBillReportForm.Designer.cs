using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    partial class LadBillReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadBillReportForm));
            Janus.Windows.GridEX.GridEXLayout ReportGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConditionsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FromLadBillDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToLadBillDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.FromLadingDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.ToLadingDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.LadBillNumber_intLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromLadBillNumber_intNumericTextBox = new NumericTextBox();
            this.ToLadBillNumber_intNumericTextBox = new NumericTextBox();
            this.TrafficTypeID_intLabel = new System.Windows.Forms.Label();
            this.TrafficTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FromLadBillTime_nvc = new System.Windows.Forms.MaskedTextBox();
            this.ToLadBillTime_nvc = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FromLadingTime_nvcTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ToLadingTime_nvcLabel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FromLadingTime_nvcLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LadingDate_nvcLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToSerial_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Serial_nvcLabel = new System.Windows.Forms.Label();
            this.FromSerial_nvcTextBox = new System.Windows.Forms.TextBox();
            this.AnnouncementTimeID_intLabel = new System.Windows.Forms.Label();
            this.AnnouncementTimeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.PortPlaceID_intComboBox = new System.Windows.Forms.ComboBox();
            this.PortPlaceID_intLabel = new System.Windows.Forms.Label();
            this.GoodID_intNewButton = new System.Windows.Forms.Button();
            this.GoodID_intComboBox = new System.Windows.Forms.ComboBox();
            this.GoodID_intLabel = new System.Windows.Forms.Label();
            this.BoxingID_intNewButton = new System.Windows.Forms.Button();
            this.BoxingID_intComboBox = new System.Windows.Forms.ComboBox();
            this.BoxingID_intLabel = new System.Windows.Forms.Label();
            this.LaderTypeID_intNewButton = new System.Windows.Forms.Button();
            this.LaderTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LaderTypeID_intLabel = new System.Windows.Forms.Label();
            this.CityID_intNewButton = new System.Windows.Forms.Button();
            this.CityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CityID_intLabel = new System.Windows.Forms.Label();
            this.DriverCardNumber_bintNumericTextBox = new NumericTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CarCardNumber_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyID_intNewButton = new System.Windows.Forms.Button();
            this.CompanyID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.ReportTabPage = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.gridEXFieldChooserControl1 = new Janus.Windows.GridEX.GridEXFieldChooserControl();
            this.ReportGrid = new Janus.Windows.GridEX.GridEX();
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.tabControl1.SuspendLayout();
            this.ConditionsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ReportTabPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConditionsTabPage);
            this.tabControl1.Controls.Add(this.ReportTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // ConditionsTabPage
            // 
            this.ConditionsTabPage.Controls.Add(this.groupBox2);
            this.ConditionsTabPage.Controls.Add(this.groupBox1);
            this.ConditionsTabPage.Location = new System.Drawing.Point(4, 23);
            this.ConditionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConditionsTabPage.Name = "ConditionsTabPage";
            this.ConditionsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConditionsTabPage.Size = new System.Drawing.Size(992, 573);
            this.ConditionsTabPage.TabIndex = 0;
            this.ConditionsTabPage.Text = "شروط گزارش";
            this.ConditionsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.FromLadBillDatePicker);
            this.groupBox2.Controls.Add(this.ToLadBillDatePicker);
            this.groupBox2.Controls.Add(this.FromLadingDatePicker);
            this.groupBox2.Controls.Add(this.ToLadingDatePicker);
            this.groupBox2.Controls.Add(this.LadBillNumber_intLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FromLadBillNumber_intNumericTextBox);
            this.groupBox2.Controls.Add(this.ToLadBillNumber_intNumericTextBox);
            this.groupBox2.Controls.Add(this.TrafficTypeID_intLabel);
            this.groupBox2.Controls.Add(this.TrafficTypeID_intComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.FromLadBillTime_nvc);
            this.groupBox2.Controls.Add(this.ToLadBillTime_nvc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.FromLadingTime_nvcTextBox);
            this.groupBox2.Controls.Add(this.ToLadingTime_nvcLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.FromLadingTime_nvcLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LadingDate_nvcLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ToSerial_nvcTextBox);
            this.groupBox2.Controls.Add(this.Serial_nvcLabel);
            this.groupBox2.Controls.Add(this.FromSerial_nvcTextBox);
            this.groupBox2.Controls.Add(this.AnnouncementTimeID_intLabel);
            this.groupBox2.Controls.Add(this.AnnouncementTimeID_intComboBox);
            this.groupBox2.Controls.Add(this.PortPlaceID_intComboBox);
            this.groupBox2.Controls.Add(this.PortPlaceID_intLabel);
            this.groupBox2.Controls.Add(this.GoodID_intNewButton);
            this.groupBox2.Controls.Add(this.GoodID_intComboBox);
            this.groupBox2.Controls.Add(this.GoodID_intLabel);
            this.groupBox2.Controls.Add(this.BoxingID_intNewButton);
            this.groupBox2.Controls.Add(this.BoxingID_intComboBox);
            this.groupBox2.Controls.Add(this.BoxingID_intLabel);
            this.groupBox2.Controls.Add(this.LaderTypeID_intNewButton);
            this.groupBox2.Controls.Add(this.LaderTypeID_intComboBox);
            this.groupBox2.Controls.Add(this.LaderTypeID_intLabel);
            this.groupBox2.Controls.Add(this.CityID_intNewButton);
            this.groupBox2.Controls.Add(this.CityID_intComboBox);
            this.groupBox2.Controls.Add(this.CityID_intLabel);
            this.groupBox2.Controls.Add(this.DriverCardNumber_bintNumericTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CarCardNumber_nvcTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CompanyID_intNewButton);
            this.groupBox2.Controls.Add(this.CompanyID_intComboBox);
            this.groupBox2.Controls.Add(this.CompanyID_intLabel);
            this.groupBox2.Location = new System.Drawing.Point(14, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(970, 444);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // FromLadBillDatePicker
            // 
            this.FromLadBillDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLadBillDatePicker.IsDefault = true;
            this.FromLadBillDatePicker.Location = new System.Drawing.Point(278, 211);
            this.FromLadBillDatePicker.Name = "FromLadBillDatePicker";
            this.FromLadBillDatePicker.Size = new System.Drawing.Size(158, 20);
            this.FromLadBillDatePicker.TabIndex = 266;
            this.FromLadBillDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToLadBillDatePicker
            // 
            this.ToLadBillDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLadBillDatePicker.Location = new System.Drawing.Point(278, 249);
            this.ToLadBillDatePicker.Name = "ToLadBillDatePicker";
            this.ToLadBillDatePicker.Size = new System.Drawing.Size(158, 20);
            this.ToLadBillDatePicker.TabIndex = 267;
            this.ToLadBillDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // FromLadingDatePicker
            // 
            this.FromLadingDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLadingDatePicker.IsDefault = true;
            this.FromLadingDatePicker.Location = new System.Drawing.Point(278, 60);
            this.FromLadingDatePicker.Name = "FromLadingDatePicker";
            this.FromLadingDatePicker.Size = new System.Drawing.Size(158, 20);
            this.FromLadingDatePicker.TabIndex = 264;
            this.FromLadingDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // ToLadingDatePicker
            // 
            this.ToLadingDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLadingDatePicker.Location = new System.Drawing.Point(278, 101);
            this.ToLadingDatePicker.Name = "ToLadingDatePicker";
            this.ToLadingDatePicker.Size = new System.Drawing.Size(158, 20);
            this.ToLadingDatePicker.TabIndex = 265;
            this.ToLadingDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // LadBillNumber_intLabel
            // 
            this.LadBillNumber_intLabel.AutoSize = true;
            this.LadBillNumber_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LadBillNumber_intLabel.Location = new System.Drawing.Point(855, 367);
            this.LadBillNumber_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LadBillNumber_intLabel.Name = "LadBillNumber_intLabel";
            this.LadBillNumber_intLabel.Size = new System.Drawing.Size(86, 14);
            this.LadBillNumber_intLabel.TabIndex = 260;
            this.LadBillNumber_intLabel.Text = "بارنامه از شماره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(855, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 262;
            this.label2.Text = "بارنامه تا شماره";
            // 
            // FromLadBillNumber_intNumericTextBox
            // 
            this.FromLadBillNumber_intNumericTextBox.AllowNegative = false;
            this.FromLadBillNumber_intNumericTextBox.DigitsInGroup = 0;
            this.FromLadBillNumber_intNumericTextBox.Flags = 65536;
            this.FromLadBillNumber_intNumericTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLadBillNumber_intNumericTextBox.Location = new System.Drawing.Point(575, 365);
            this.FromLadBillNumber_intNumericTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromLadBillNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.FromLadBillNumber_intNumericTextBox.MaxWholeDigits = 155;
            this.FromLadBillNumber_intNumericTextBox.Name = "FromLadBillNumber_intNumericTextBox";
            this.FromLadBillNumber_intNumericTextBox.Prefix = "";
            //this.FromLadBillNumber_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
            //this.FromLadBillNumber_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.FromLadBillNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromLadBillNumber_intNumericTextBox.Size = new System.Drawing.Size(274, 22);
            this.FromLadBillNumber_intNumericTextBox.TabIndex = 261;
            // 
            // ToLadBillNumber_intNumericTextBox
            // 
            this.ToLadBillNumber_intNumericTextBox.AllowNegative = false;
            this.ToLadBillNumber_intNumericTextBox.DigitsInGroup = 0;
            this.ToLadBillNumber_intNumericTextBox.Flags = 65536;
            this.ToLadBillNumber_intNumericTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLadBillNumber_intNumericTextBox.Location = new System.Drawing.Point(575, 403);
            this.ToLadBillNumber_intNumericTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToLadBillNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.ToLadBillNumber_intNumericTextBox.MaxWholeDigits = 155;
            this.ToLadBillNumber_intNumericTextBox.Name = "ToLadBillNumber_intNumericTextBox";
            this.ToLadBillNumber_intNumericTextBox.Prefix = "";
            //this.ToLadBillNumber_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
            //this.ToLadBillNumber_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.ToLadBillNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToLadBillNumber_intNumericTextBox.Size = new System.Drawing.Size(274, 22);
            this.ToLadBillNumber_intNumericTextBox.TabIndex = 263;
            // 
            // TrafficTypeID_intLabel
            // 
            this.TrafficTypeID_intLabel.AutoSize = true;
            this.TrafficTypeID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficTypeID_intLabel.Location = new System.Drawing.Point(855, 293);
            this.TrafficTypeID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrafficTypeID_intLabel.Name = "TrafficTypeID_intLabel";
            this.TrafficTypeID_intLabel.Size = new System.Drawing.Size(46, 14);
            this.TrafficTypeID_intLabel.TabIndex = 259;
            this.TrafficTypeID_intLabel.Text = "نوع تردد";
            // 
            // TrafficTypeID_intComboBox
            // 
            this.TrafficTypeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TrafficTypeID_intComboBox.FormattingEnabled = true;
            this.TrafficTypeID_intComboBox.Location = new System.Drawing.Point(573, 289);
            this.TrafficTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrafficTypeID_intComboBox.Name = "TrafficTypeID_intComboBox";
            this.TrafficTypeID_intComboBox.Size = new System.Drawing.Size(274, 22);
            this.TrafficTypeID_intComboBox.TabIndex = 258;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(443, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 14);
            this.label6.TabIndex = 236;
            this.label6.Text = "مجوز بارنامه تا ساعت";
            // 
            // FromLadBillTime_nvc
            // 
            this.FromLadBillTime_nvc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLadBillTime_nvc.Location = new System.Drawing.Point(280, 284);
            this.FromLadBillTime_nvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromLadBillTime_nvc.Mask = "00:00";
            this.FromLadBillTime_nvc.Name = "FromLadBillTime_nvc";
            this.FromLadBillTime_nvc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromLadBillTime_nvc.Size = new System.Drawing.Size(156, 22);
            this.FromLadBillTime_nvc.TabIndex = 239;
            this.FromLadBillTime_nvc.ValidatingType = typeof(System.DateTime);
            this.FromLadBillTime_nvc.Click += new System.EventHandler(this.FromLadBillTime_nvc_Click);
            // 
            // ToLadBillTime_nvc
            // 
            this.ToLadBillTime_nvc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLadBillTime_nvc.Location = new System.Drawing.Point(280, 322);
            this.ToLadBillTime_nvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToLadBillTime_nvc.Mask = "00:00";
            this.ToLadBillTime_nvc.Name = "ToLadBillTime_nvc";
            this.ToLadBillTime_nvc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToLadBillTime_nvc.Size = new System.Drawing.Size(156, 22);
            this.ToLadBillTime_nvc.TabIndex = 238;
            this.ToLadBillTime_nvc.ValidatingType = typeof(System.DateTime);
            this.ToLadBillTime_nvc.Click += new System.EventHandler(this.ToLadBillTime_nvc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(443, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 237;
            this.label8.Text = "مجوز بارنامه از ساعت";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(443, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 14);
            this.label9.TabIndex = 234;
            this.label9.Text = "مجوز بارنامه تا تاریخ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(443, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 14);
            this.label10.TabIndex = 235;
            this.label10.Text = "مجوز بارنامه از تاریخ";
            // 
            // FromLadingTime_nvcTextBox
            // 
            this.FromLadingTime_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLadingTime_nvcTextBox.Location = new System.Drawing.Point(280, 137);
            this.FromLadingTime_nvcTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromLadingTime_nvcTextBox.Mask = "00:00";
            this.FromLadingTime_nvcTextBox.Name = "FromLadingTime_nvcTextBox";
            this.FromLadingTime_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromLadingTime_nvcTextBox.Size = new System.Drawing.Size(158, 22);
            this.FromLadingTime_nvcTextBox.TabIndex = 231;
            this.FromLadingTime_nvcTextBox.ValidatingType = typeof(System.DateTime);
            this.FromLadingTime_nvcTextBox.Click += new System.EventHandler(this.FromLadingTime_nvcTextBox_Click);
            // 
            // ToLadingTime_nvcLabel
            // 
            this.ToLadingTime_nvcLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToLadingTime_nvcLabel.Location = new System.Drawing.Point(278, 174);
            this.ToLadingTime_nvcLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToLadingTime_nvcLabel.Mask = "00:00";
            this.ToLadingTime_nvcLabel.Name = "ToLadingTime_nvcLabel";
            this.ToLadingTime_nvcLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToLadingTime_nvcLabel.Size = new System.Drawing.Size(158, 22);
            this.ToLadingTime_nvcLabel.TabIndex = 231;
            this.ToLadingTime_nvcLabel.ValidatingType = typeof(System.DateTime);
            this.ToLadingTime_nvcLabel.Click += new System.EventHandler(this.ToLadingTime_nvcLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(443, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 14);
            this.label5.TabIndex = 230;
            this.label5.Text = "بارگیری تا ساعت";
            // 
            // FromLadingTime_nvcLabel
            // 
            this.FromLadingTime_nvcLabel.AutoSize = true;
            this.FromLadingTime_nvcLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromLadingTime_nvcLabel.Location = new System.Drawing.Point(443, 140);
            this.FromLadingTime_nvcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLadingTime_nvcLabel.Name = "FromLadingTime_nvcLabel";
            this.FromLadingTime_nvcLabel.Size = new System.Drawing.Size(92, 14);
            this.FromLadingTime_nvcLabel.TabIndex = 230;
            this.FromLadingTime_nvcLabel.Text = "بارگیری از ساعت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(443, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 229;
            this.label3.Text = "بارگیری تا تاریخ";
            // 
            // LadingDate_nvcLabel
            // 
            this.LadingDate_nvcLabel.AutoSize = true;
            this.LadingDate_nvcLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LadingDate_nvcLabel.Location = new System.Drawing.Point(443, 66);
            this.LadingDate_nvcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LadingDate_nvcLabel.Name = "LadingDate_nvcLabel";
            this.LadingDate_nvcLabel.Size = new System.Drawing.Size(80, 14);
            this.LadingDate_nvcLabel.TabIndex = 229;
            this.LadingDate_nvcLabel.Text = "بارگیری از تاریخ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(443, 399);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 222;
            this.label1.Text = "بارنامه تا سریال";
            // 
            // ToSerial_nvcTextBox
            // 
            this.ToSerial_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToSerial_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToSerial_nvcTextBox.Location = new System.Drawing.Point(167, 396);
            this.ToSerial_nvcTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToSerial_nvcTextBox.MaxLength = 100;
            this.ToSerial_nvcTextBox.Name = "ToSerial_nvcTextBox";
            this.ToSerial_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToSerial_nvcTextBox.Size = new System.Drawing.Size(274, 22);
            this.ToSerial_nvcTextBox.TabIndex = 223;
            this.ToSerial_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Serial_nvcLabel
            // 
            this.Serial_nvcLabel.AutoSize = true;
            this.Serial_nvcLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Serial_nvcLabel.Location = new System.Drawing.Point(443, 362);
            this.Serial_nvcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Serial_nvcLabel.Name = "Serial_nvcLabel";
            this.Serial_nvcLabel.Size = new System.Drawing.Size(85, 14);
            this.Serial_nvcLabel.TabIndex = 220;
            this.Serial_nvcLabel.Text = "بارنامه از سریال";
            // 
            // FromSerial_nvcTextBox
            // 
            this.FromSerial_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromSerial_nvcTextBox.Location = new System.Drawing.Point(165, 358);
            this.FromSerial_nvcTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromSerial_nvcTextBox.MaxLength = 100;
            this.FromSerial_nvcTextBox.Name = "FromSerial_nvcTextBox";
            this.FromSerial_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromSerial_nvcTextBox.Size = new System.Drawing.Size(273, 22);
            this.FromSerial_nvcTextBox.TabIndex = 221;
            this.FromSerial_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnnouncementTimeID_intLabel
            // 
            this.AnnouncementTimeID_intLabel.AutoSize = true;
            this.AnnouncementTimeID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AnnouncementTimeID_intLabel.Location = new System.Drawing.Point(855, 330);
            this.AnnouncementTimeID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnnouncementTimeID_intLabel.Name = "AnnouncementTimeID_intLabel";
            this.AnnouncementTimeID_intLabel.Size = new System.Drawing.Size(99, 14);
            this.AnnouncementTimeID_intLabel.TabIndex = 219;
            this.AnnouncementTimeID_intLabel.Text = "زمان اطلاع رسانی";
            // 
            // AnnouncementTimeID_intComboBox
            // 
            this.AnnouncementTimeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AnnouncementTimeID_intComboBox.FormattingEnabled = true;
            this.AnnouncementTimeID_intComboBox.Location = new System.Drawing.Point(574, 327);
            this.AnnouncementTimeID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnnouncementTimeID_intComboBox.Name = "AnnouncementTimeID_intComboBox";
            this.AnnouncementTimeID_intComboBox.Size = new System.Drawing.Size(273, 22);
            this.AnnouncementTimeID_intComboBox.TabIndex = 218;
            // 
            // PortPlaceID_intComboBox
            // 
            this.PortPlaceID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PortPlaceID_intComboBox.FormattingEnabled = true;
            this.PortPlaceID_intComboBox.Location = new System.Drawing.Point(165, 25);
            this.PortPlaceID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortPlaceID_intComboBox.Name = "PortPlaceID_intComboBox";
            this.PortPlaceID_intComboBox.Size = new System.Drawing.Size(271, 22);
            this.PortPlaceID_intComboBox.TabIndex = 217;
            this.PortPlaceID_intComboBox.Text = "ز";
            // 
            // PortPlaceID_intLabel
            // 
            this.PortPlaceID_intLabel.AutoSize = true;
            this.PortPlaceID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PortPlaceID_intLabel.Location = new System.Drawing.Point(443, 30);
            this.PortPlaceID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortPlaceID_intLabel.Name = "PortPlaceID_intLabel";
            this.PortPlaceID_intLabel.Size = new System.Drawing.Size(11, 14);
            this.PortPlaceID_intLabel.TabIndex = 216;
            this.PortPlaceID_intLabel.Text = "ز";
            // 
            // GoodID_intNewButton
            // 
            this.GoodID_intNewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoodID_intNewButton.BackgroundImage")));
            this.GoodID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GoodID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoodID_intNewButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GoodID_intNewButton.Location = new System.Drawing.Point(574, 255);
            this.GoodID_intNewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoodID_intNewButton.Name = "GoodID_intNewButton";
            this.GoodID_intNewButton.Size = new System.Drawing.Size(33, 31);
            this.GoodID_intNewButton.TabIndex = 214;
            this.GoodID_intNewButton.TabStop = false;
            this.GoodID_intNewButton.Text = "ز";
            this.GoodID_intNewButton.UseVisualStyleBackColor = true;
            this.GoodID_intNewButton.Click += new System.EventHandler(this.GoodID_intNewButton_Click);
            // 
            // GoodID_intComboBox
            // 
            this.GoodID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GoodID_intComboBox.FormattingEnabled = true;
            this.GoodID_intComboBox.Location = new System.Drawing.Point(610, 252);
            this.GoodID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoodID_intComboBox.Name = "GoodID_intComboBox";
            this.GoodID_intComboBox.Size = new System.Drawing.Size(237, 22);
            this.GoodID_intComboBox.TabIndex = 213;
            this.GoodID_intComboBox.Text = "ز";
            // 
            // GoodID_intLabel
            // 
            this.GoodID_intLabel.AutoSize = true;
            this.GoodID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GoodID_intLabel.Location = new System.Drawing.Point(855, 255);
            this.GoodID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GoodID_intLabel.Name = "GoodID_intLabel";
            this.GoodID_intLabel.Size = new System.Drawing.Size(11, 14);
            this.GoodID_intLabel.TabIndex = 215;
            this.GoodID_intLabel.Text = "ز";
            // 
            // BoxingID_intNewButton
            // 
            this.BoxingID_intNewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxingID_intNewButton.BackgroundImage")));
            this.BoxingID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxingID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxingID_intNewButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BoxingID_intNewButton.Location = new System.Drawing.Point(574, 215);
            this.BoxingID_intNewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxingID_intNewButton.Name = "BoxingID_intNewButton";
            this.BoxingID_intNewButton.Size = new System.Drawing.Size(33, 31);
            this.BoxingID_intNewButton.TabIndex = 211;
            this.BoxingID_intNewButton.TabStop = false;
            this.BoxingID_intNewButton.UseVisualStyleBackColor = true;
            this.BoxingID_intNewButton.Click += new System.EventHandler(this.BoxingID_intNewButton_Click);
            // 
            // BoxingID_intComboBox
            // 
            this.BoxingID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BoxingID_intComboBox.FormattingEnabled = true;
            this.BoxingID_intComboBox.Location = new System.Drawing.Point(611, 214);
            this.BoxingID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxingID_intComboBox.Name = "BoxingID_intComboBox";
            this.BoxingID_intComboBox.Size = new System.Drawing.Size(237, 22);
            this.BoxingID_intComboBox.TabIndex = 210;
            // 
            // BoxingID_intLabel
            // 
            this.BoxingID_intLabel.AutoSize = true;
            this.BoxingID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BoxingID_intLabel.Location = new System.Drawing.Point(855, 217);
            this.BoxingID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BoxingID_intLabel.Name = "BoxingID_intLabel";
            this.BoxingID_intLabel.Size = new System.Drawing.Size(81, 14);
            this.BoxingID_intLabel.TabIndex = 212;
            this.BoxingID_intLabel.Text = "نوع بسته بندی";
            // 
            // LaderTypeID_intNewButton
            // 
            this.LaderTypeID_intNewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaderTypeID_intNewButton.BackgroundImage")));
            this.LaderTypeID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderTypeID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderTypeID_intNewButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intNewButton.Location = new System.Drawing.Point(574, 178);
            this.LaderTypeID_intNewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LaderTypeID_intNewButton.Name = "LaderTypeID_intNewButton";
            this.LaderTypeID_intNewButton.Size = new System.Drawing.Size(33, 31);
            this.LaderTypeID_intNewButton.TabIndex = 209;
            this.LaderTypeID_intNewButton.TabStop = false;
            this.LaderTypeID_intNewButton.UseVisualStyleBackColor = true;
            this.LaderTypeID_intNewButton.Click += new System.EventHandler(this.LaderTypeID_intNewButton_Click);
            // 
            // LaderTypeID_intComboBox
            // 
            this.LaderTypeID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intComboBox.FormattingEnabled = true;
            this.LaderTypeID_intComboBox.Location = new System.Drawing.Point(611, 174);
            this.LaderTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LaderTypeID_intComboBox.Name = "LaderTypeID_intComboBox";
            this.LaderTypeID_intComboBox.Size = new System.Drawing.Size(237, 22);
            this.LaderTypeID_intComboBox.TabIndex = 208;
            // 
            // LaderTypeID_intLabel
            // 
            this.LaderTypeID_intLabel.AutoSize = true;
            this.LaderTypeID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypeID_intLabel.Location = new System.Drawing.Point(855, 179);
            this.LaderTypeID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LaderTypeID_intLabel.Name = "LaderTypeID_intLabel";
            this.LaderTypeID_intLabel.Size = new System.Drawing.Size(56, 14);
            this.LaderTypeID_intLabel.TabIndex = 207;
            this.LaderTypeID_intLabel.Text = " نوع بارگیر";
            // 
            // CityID_intNewButton
            // 
            this.CityID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CityID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CityID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CityID_intNewButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CityID_intNewButton.Location = new System.Drawing.Point(574, 137);
            this.CityID_intNewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CityID_intNewButton.Name = "CityID_intNewButton";
            this.CityID_intNewButton.Size = new System.Drawing.Size(33, 38);
            this.CityID_intNewButton.TabIndex = 205;
            this.CityID_intNewButton.TabStop = false;
            this.CityID_intNewButton.Text = "ز";
            this.CityID_intNewButton.UseVisualStyleBackColor = true;
            this.CityID_intNewButton.Click += new System.EventHandler(this.CityID_intNewButton_Click);
            // 
            // CityID_intComboBox
            // 
            this.CityID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CityID_intComboBox.FormattingEnabled = true;
            this.CityID_intComboBox.Location = new System.Drawing.Point(613, 137);
            this.CityID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CityID_intComboBox.Name = "CityID_intComboBox";
            this.CityID_intComboBox.Size = new System.Drawing.Size(235, 22);
            this.CityID_intComboBox.TabIndex = 204;
            this.CityID_intComboBox.Text = "ز";
            // 
            // CityID_intLabel
            // 
            this.CityID_intLabel.AutoSize = true;
            this.CityID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CityID_intLabel.Location = new System.Drawing.Point(855, 142);
            this.CityID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityID_intLabel.Name = "CityID_intLabel";
            this.CityID_intLabel.Size = new System.Drawing.Size(11, 14);
            this.CityID_intLabel.TabIndex = 206;
            this.CityID_intLabel.Text = "ز";
            // 
            // DriverCardNumber_bintNumericTextBox
            // 
            this.DriverCardNumber_bintNumericTextBox.AllowNegative = false;
            this.DriverCardNumber_bintNumericTextBox.DigitsInGroup = 0;
            this.DriverCardNumber_bintNumericTextBox.Flags = 65536;
            this.DriverCardNumber_bintNumericTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DriverCardNumber_bintNumericTextBox.Location = new System.Drawing.Point(574, 63);
            this.DriverCardNumber_bintNumericTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DriverCardNumber_bintNumericTextBox.MaxDecimalPlaces = 0;
            this.DriverCardNumber_bintNumericTextBox.MaxWholeDigits = 155;
            this.DriverCardNumber_bintNumericTextBox.Name = "DriverCardNumber_bintNumericTextBox";
            this.DriverCardNumber_bintNumericTextBox.Prefix = "";
            //this.DriverCardNumber_bintNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
            //this.DriverCardNumber_bintNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.DriverCardNumber_bintNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_bintNumericTextBox.Size = new System.Drawing.Size(273, 22);
            this.DriverCardNumber_bintNumericTextBox.TabIndex = 201;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(855, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 14);
            this.label7.TabIndex = 203;
            this.label7.Text = "شماره کارت راننده";
            // 
            // CarCardNumber_nvcTextBox
            // 
            this.CarCardNumber_nvcTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CarCardNumber_nvcTextBox.Location = new System.Drawing.Point(575, 100);
            this.CarCardNumber_nvcTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarCardNumber_nvcTextBox.MaxLength = 10;
            this.CarCardNumber_nvcTextBox.Name = "CarCardNumber_nvcTextBox";
            this.CarCardNumber_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCardNumber_nvcTextBox.Size = new System.Drawing.Size(273, 22);
            this.CarCardNumber_nvcTextBox.TabIndex = 200;
            this.CarCardNumber_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(855, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 14);
            this.label4.TabIndex = 202;
            this.label4.Text = "شماره کارت ماشین";
            // 
            // CompanyID_intNewButton
            // 
            this.CompanyID_intNewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompanyID_intNewButton.BackgroundImage")));
            this.CompanyID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompanyID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyID_intNewButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyID_intNewButton.Location = new System.Drawing.Point(574, 25);
            this.CompanyID_intNewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompanyID_intNewButton.Name = "CompanyID_intNewButton";
            this.CompanyID_intNewButton.Size = new System.Drawing.Size(33, 31);
            this.CompanyID_intNewButton.TabIndex = 25;
            this.CompanyID_intNewButton.TabStop = false;
            this.CompanyID_intNewButton.UseVisualStyleBackColor = true;
            this.CompanyID_intNewButton.Click += new System.EventHandler(this.CompanyID_intNewButton_Click);
            // 
            // CompanyID_intComboBox
            // 
            this.CompanyID_intComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyID_intComboBox.FormattingEnabled = true;
            this.CompanyID_intComboBox.Location = new System.Drawing.Point(611, 25);
            this.CompanyID_intComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompanyID_intComboBox.Name = "CompanyID_intComboBox";
            this.CompanyID_intComboBox.Size = new System.Drawing.Size(237, 22);
            this.CompanyID_intComboBox.TabIndex = 24;
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CompanyID_intLabel.Location = new System.Drawing.Point(855, 30);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(41, 14);
            this.CompanyID_intLabel.TabIndex = 23;
            this.CompanyID_intLabel.Text = "شرکت";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ShowButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(970, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(856, 13);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(109, 30);
            this.ShowButton.TabIndex = 9;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ReportTabPage
            // 
            this.ReportTabPage.Controls.Add(this.toolStrip1);
            this.ReportTabPage.Controls.Add(this.gridEXFieldChooserControl1);
            this.ReportTabPage.Controls.Add(this.ReportGrid);
            this.ReportTabPage.Location = new System.Drawing.Point(4, 23);
            this.ReportTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportTabPage.Name = "ReportTabPage";
            this.ReportTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportTabPage.Size = new System.Drawing.Size(992, 573);
            this.ReportTabPage.TabIndex = 1;
            this.ReportTabPage.Text = "نتیجه گزارش";
            this.ReportTabPage.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintButton,
            this.ExportButton});
            this.toolStrip1.Location = new System.Drawing.Point(4, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintButton.Image = global::HPS.Properties.Resources.Print;
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(28, 28);
            this.PrintButton.Text = "چاپ";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(28, 28);
            this.ExportButton.Text = "تبدیل به اكسل";
            this.ExportButton.Visible = false;
            // 
            // gridEXFieldChooserControl1
            // 
            this.gridEXFieldChooserControl1.GridEX = this.ReportGrid;
            this.gridEXFieldChooserControl1.Location = new System.Drawing.Point(842, 37);
            this.gridEXFieldChooserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEXFieldChooserControl1.Name = "gridEXFieldChooserControl1";
            this.gridEXFieldChooserControl1.Size = new System.Drawing.Size(150, 572);
            this.gridEXFieldChooserControl1.TabIndex = 2;
            this.gridEXFieldChooserControl1.Text = "gridEXFieldChooserControl1";
            // 
            // ReportGrid
            // 
            this.ReportGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.ReportGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.ReportGrid.AlternatingColors = true;
            this.ReportGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(253)))));
            this.ReportGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportGrid.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>ستونها" +
    " را برای گروهبندی، كشیده و در اینجا رها كنید</GroupByBoxInfo></LocalizableData>";
            ReportGrid_DesignTimeLayout.LayoutString = resources.GetString("ReportGrid_DesignTimeLayout.LayoutString");
            this.ReportGrid.DesignTimeLayout = ReportGrid_DesignTimeLayout;
            this.ReportGrid.DynamicFiltering = true;
            this.ReportGrid.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info;
            this.ReportGrid.FocusCellFormatStyle.BackColor = System.Drawing.Color.Red;
            this.ReportGrid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ReportGrid.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.ReportGrid.Location = new System.Drawing.Point(5, 37);
            this.ReportGrid.Margin = new System.Windows.Forms.Padding(5);
            this.ReportGrid.Name = "ReportGrid";
            this.ReportGrid.Size = new System.Drawing.Size(839, 530);
            this.ReportGrid.TabIndex = 0;
            this.ReportGrid.TotalRowFormatStyle.BackColor = System.Drawing.SystemColors.Info;
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.GridEX = this.ReportGrid;
            // 
            // LadBillReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.MaximizeBox = false;
            this.Name = "LadBillReportForm";
            this.Text = "گزارش کلی بارنامه هاو بارهای حمل شده";
            this.Load += new System.EventHandler(this.LadBillReportForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ConditionsTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ReportTabPage.ResumeLayout(false);
            this.ReportTabPage.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConditionsTabPage;
        private System.Windows.Forms.TabPage ReportTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Janus.Windows.GridEX.GridEX ReportGrid;
        private Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.Button CompanyID_intNewButton;
        private System.Windows.Forms.ComboBox CompanyID_intComboBox;
        private System.Windows.Forms.Label CompanyID_intLabel;
        private NumericTextBox DriverCardNumber_bintNumericTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CarCardNumber_nvcTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CityID_intNewButton;
        private System.Windows.Forms.ComboBox CityID_intComboBox;
        private System.Windows.Forms.Label CityID_intLabel;
        private System.Windows.Forms.Button LaderTypeID_intNewButton;
        private System.Windows.Forms.ComboBox LaderTypeID_intComboBox;
        private System.Windows.Forms.Label LaderTypeID_intLabel;
        private System.Windows.Forms.Button BoxingID_intNewButton;
        private System.Windows.Forms.ComboBox BoxingID_intComboBox;
        private System.Windows.Forms.Label BoxingID_intLabel;
        private System.Windows.Forms.Button GoodID_intNewButton;
        private System.Windows.Forms.ComboBox GoodID_intComboBox;
        private System.Windows.Forms.Label GoodID_intLabel;
        private System.Windows.Forms.ComboBox PortPlaceID_intComboBox;
        private System.Windows.Forms.Label PortPlaceID_intLabel;
        private System.Windows.Forms.Label AnnouncementTimeID_intLabel;
        private System.Windows.Forms.ComboBox AnnouncementTimeID_intComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ToSerial_nvcTextBox;
        private System.Windows.Forms.Label Serial_nvcLabel;
        private System.Windows.Forms.TextBox FromSerial_nvcTextBox;
        private System.Windows.Forms.Label LadingDate_nvcLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToLadingTime_nvcLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox FromLadingTime_nvcTextBox;
        private System.Windows.Forms.Label FromLadingTime_nvcLabel;
        private System.Windows.Forms.MaskedTextBox ToLadBillTime_nvc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox FromLadBillTime_nvc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TrafficTypeID_intLabel;
        private System.Windows.Forms.ComboBox TrafficTypeID_intComboBox;
        private Janus.Windows.GridEX.GridEXFieldChooserControl gridEXFieldChooserControl1;
        private System.Windows.Forms.Label LadBillNumber_intLabel;
        private System.Windows.Forms.Label label2;
        private NumericTextBox FromLadBillNumber_intNumericTextBox;
        private NumericTextBox ToLadBillNumber_intNumericTextBox;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private FarsiLibrary.Win.Controls.FADatePicker FromLadingDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToLadingDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker FromLadBillDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker ToLadBillDatePicker;
    }
}