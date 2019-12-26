using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignment
{
    partial class LadeAssignmentEntityForm
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
            this.CityCode_nvcLabel = new System.Windows.Forms.Label();
            this.Address_nvcLabel = new System.Windows.Forms.Label();
            this.AnnouncementTimeID_intLabel = new System.Windows.Forms.Label();
            this.CityID_intLabel = new System.Windows.Forms.Label();
            this.GoodID_intLabel = new System.Windows.Forms.Label();
            this.BoxingID_intLabel = new System.Windows.Forms.Label();
            this.PortPlaceID_intLabel = new System.Windows.Forms.Label();
            this.LaderTypeID_intLabel = new System.Windows.Forms.Label();
            this.MinWeight_decLabel = new System.Windows.Forms.Label();
            this.MaxWeight_decLabel = new System.Windows.Forms.Label();
            this.PortageFee_decLabel = new System.Windows.Forms.Label();
            this.CityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.Conditin_nvcTextBox = new System.Windows.Forms.TextBox();
            this.AnnouncementTimeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.GoodID_intComboBox = new System.Windows.Forms.ComboBox();
            this.BoxingID_intComboBox = new System.Windows.Forms.ComboBox();
            this.PortPlaceID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LaderTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.MinWeight_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.MaxWeight_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.PortageFee_decNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.CityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Comment_nvcLabel = new System.Windows.Forms.Label();
            this.CommentSearchbutton = new System.Windows.Forms.Button();
            this.CarCount_intNumericTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.Comment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CarCount_intLabel = new System.Windows.Forms.Label();
            this.LadeComments_nvcListBox = new System.Windows.Forms.ListBox();
            this.DestinationAddressID_intNewButton = new System.Windows.Forms.Button();
            this.DestinationAddressID_intComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxingCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyID_intNewButton = new System.Windows.Forms.Button();
            this.LaderTypeID_intNewButton = new System.Windows.Forms.Button();
            this.GoodID_intNewButton = new System.Windows.Forms.Button();
            this.CityID_intNewButton = new System.Windows.Forms.Button();
            this.BoxingID_intNewButton = new System.Windows.Forms.Button();
            this.CompanyID_intComboBox = new System.Windows.Forms.ComboBox();
            this.GoodCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.CommentAddbutton = new System.Windows.Forms.Button();
            this.LadeCommentDeletebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LadeCommentID_intComboBox = new System.Windows.Forms.ComboBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(846, 25);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.Click += new System.EventHandler(this.SaveAndNextButton_Click);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(846, 63);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(846, 101);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(846, 139);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CityCode_nvcLabel
            // 
            this.CityCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCode_nvcLabel.AutoSize = true;
            this.CityCode_nvcLabel.Location = new System.Drawing.Point(723, 179);
            this.CityCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityCode_nvcLabel.Name = "CityCode_nvcLabel";
            this.CityCode_nvcLabel.Size = new System.Drawing.Size(78, 23);
            this.CityCode_nvcLabel.TabIndex = 56;
            this.CityCode_nvcLabel.Text = "کدشهر مقصد";
            // 
            // Address_nvcLabel
            // 
            this.Address_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_nvcLabel.AutoSize = true;
            this.Address_nvcLabel.Location = new System.Drawing.Point(723, 216);
            this.Address_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Address_nvcLabel.Name = "Address_nvcLabel";
            this.Address_nvcLabel.Size = new System.Drawing.Size(71, 23);
            this.Address_nvcLabel.TabIndex = 52;
            this.Address_nvcLabel.Text = "آدرس مقصد";
            // 
            // AnnouncementTimeID_intLabel
            // 
            this.AnnouncementTimeID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnouncementTimeID_intLabel.AutoSize = true;
            this.AnnouncementTimeID_intLabel.Location = new System.Drawing.Point(723, 28);
            this.AnnouncementTimeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AnnouncementTimeID_intLabel.Name = "AnnouncementTimeID_intLabel";
            this.AnnouncementTimeID_intLabel.Size = new System.Drawing.Size(100, 23);
            this.AnnouncementTimeID_intLabel.TabIndex = 69;
            this.AnnouncementTimeID_intLabel.Text = "زمان اطلاع رسانی";
            // 
            // CityID_intLabel
            // 
            this.CityID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intLabel.AutoSize = true;
            this.CityID_intLabel.Location = new System.Drawing.Point(723, 141);
            this.CityID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CityID_intLabel.Name = "CityID_intLabel";
            this.CityID_intLabel.Size = new System.Drawing.Size(65, 23);
            this.CityID_intLabel.TabIndex = 64;
            this.CityID_intLabel.Text = "شهر مقصد";
            // 
            // GoodID_intLabel
            // 
            this.GoodID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodID_intLabel.AutoSize = true;
            this.GoodID_intLabel.Location = new System.Drawing.Point(724, 254);
            this.GoodID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GoodID_intLabel.Name = "GoodID_intLabel";
            this.GoodID_intLabel.Size = new System.Drawing.Size(28, 23);
            this.GoodID_intLabel.TabIndex = 56;
            this.GoodID_intLabel.Text = "کالا";
            // 
            // BoxingID_intLabel
            // 
            this.BoxingID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxingID_intLabel.AutoSize = true;
            this.BoxingID_intLabel.Location = new System.Drawing.Point(723, 329);
            this.BoxingID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BoxingID_intLabel.Name = "BoxingID_intLabel";
            this.BoxingID_intLabel.Size = new System.Drawing.Size(83, 23);
            this.BoxingID_intLabel.TabIndex = 52;
            this.BoxingID_intLabel.Text = "نوع بسته بندی";
            // 
            // PortPlaceID_intLabel
            // 
            this.PortPlaceID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortPlaceID_intLabel.AutoSize = true;
            this.PortPlaceID_intLabel.Location = new System.Drawing.Point(285, 125);
            this.PortPlaceID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PortPlaceID_intLabel.Name = "PortPlaceID_intLabel";
            this.PortPlaceID_intLabel.Size = new System.Drawing.Size(77, 23);
            this.PortPlaceID_intLabel.TabIndex = 70;
            this.PortPlaceID_intLabel.Text = "محل بارگیری";
            // 
            // LaderTypeID_intLabel
            // 
            this.LaderTypeID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intLabel.AutoSize = true;
            this.LaderTypeID_intLabel.Location = new System.Drawing.Point(284, 201);
            this.LaderTypeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LaderTypeID_intLabel.Name = "LaderTypeID_intLabel";
            this.LaderTypeID_intLabel.Size = new System.Drawing.Size(62, 23);
            this.LaderTypeID_intLabel.TabIndex = 70;
            this.LaderTypeID_intLabel.Text = " نوع بارگیر";
            // 
            // MinWeight_decLabel
            // 
            this.MinWeight_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinWeight_decLabel.AutoSize = true;
            this.MinWeight_decLabel.Location = new System.Drawing.Point(283, 20);
            this.MinWeight_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MinWeight_decLabel.Name = "MinWeight_decLabel";
            this.MinWeight_decLabel.Size = new System.Drawing.Size(42, 23);
            this.MinWeight_decLabel.TabIndex = 75;
            this.MinWeight_decLabel.Text = "از وزن";
            // 
            // MaxWeight_decLabel
            // 
            this.MaxWeight_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxWeight_decLabel.AutoSize = true;
            this.MaxWeight_decLabel.Location = new System.Drawing.Point(283, 55);
            this.MaxWeight_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MaxWeight_decLabel.Name = "MaxWeight_decLabel";
            this.MaxWeight_decLabel.Size = new System.Drawing.Size(42, 23);
            this.MaxWeight_decLabel.TabIndex = 78;
            this.MaxWeight_decLabel.Text = "تا وزن";
            // 
            // PortageFee_decLabel
            // 
            this.PortageFee_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortageFee_decLabel.AutoSize = true;
            this.PortageFee_decLabel.Location = new System.Drawing.Point(285, 90);
            this.PortageFee_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PortageFee_decLabel.Name = "PortageFee_decLabel";
            this.PortageFee_decLabel.Size = new System.Drawing.Size(56, 23);
            this.PortageFee_decLabel.TabIndex = 79;
            this.PortageFee_decLabel.Text = "نرخ حمل";
            // 
            // CityCode_nvcTextBox
            // 
            this.CityCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityCode_nvcTextBox.Enabled = false;
            this.CityCode_nvcTextBox.Location = new System.Drawing.Point(446, 175);
            this.CityCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityCode_nvcTextBox.MaxLength = 10;
            this.CityCode_nvcTextBox.Name = "CityCode_nvcTextBox";
            this.CityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityCode_nvcTextBox.Size = new System.Drawing.Size(276, 30);
            this.CityCode_nvcTextBox.TabIndex = 4;
            this.CityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Conditin_nvcTextBox
            // 
            this.Conditin_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Conditin_nvcTextBox.Location = new System.Drawing.Point(-206, 403);
            this.Conditin_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Conditin_nvcTextBox.MaxLength = 300;
            this.Conditin_nvcTextBox.Name = "Conditin_nvcTextBox";
            this.Conditin_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Conditin_nvcTextBox.Size = new System.Drawing.Size(113, 30);
            this.Conditin_nvcTextBox.TabIndex = 22;
            this.Conditin_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Conditin_nvcTextBox.Visible = false;
            // 
            // AnnouncementTimeID_intComboBox
            // 
            this.AnnouncementTimeID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnnouncementTimeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AnnouncementTimeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AnnouncementTimeID_intComboBox.FormattingEnabled = true;
            this.AnnouncementTimeID_intComboBox.Location = new System.Drawing.Point(446, 24);
            this.AnnouncementTimeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.AnnouncementTimeID_intComboBox.Name = "AnnouncementTimeID_intComboBox";
            this.AnnouncementTimeID_intComboBox.Size = new System.Drawing.Size(276, 31);
            this.AnnouncementTimeID_intComboBox.TabIndex = 0;
            // 
            // GoodID_intComboBox
            // 
            this.GoodID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GoodID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GoodID_intComboBox.DropDownHeight = 200;
            this.GoodID_intComboBox.FormattingEnabled = true;
            this.GoodID_intComboBox.IntegralHeight = false;
            this.GoodID_intComboBox.Location = new System.Drawing.Point(484, 250);
            this.GoodID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.GoodID_intComboBox.Name = "GoodID_intComboBox";
            this.GoodID_intComboBox.Size = new System.Drawing.Size(238, 31);
            this.GoodID_intComboBox.TabIndex = 6;
            this.GoodID_intComboBox.SelectedValueChanged += new System.EventHandler(this.GoodID_intComboBox_SelectedValueChanged);
            // 
            // BoxingID_intComboBox
            // 
            this.BoxingID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxingID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BoxingID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxingID_intComboBox.DropDownHeight = 200;
            this.BoxingID_intComboBox.FormattingEnabled = true;
            this.BoxingID_intComboBox.IntegralHeight = false;
            this.BoxingID_intComboBox.Location = new System.Drawing.Point(484, 325);
            this.BoxingID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.BoxingID_intComboBox.Name = "BoxingID_intComboBox";
            this.BoxingID_intComboBox.Size = new System.Drawing.Size(238, 31);
            this.BoxingID_intComboBox.TabIndex = 8;
            this.BoxingID_intComboBox.SelectedValueChanged += new System.EventHandler(this.BoxingID_intComboBox_SelectedValueChanged);
            this.BoxingID_intComboBox.Leave += new System.EventHandler(this.BoxingID_intComboBox_Leave);
            // 
            // PortPlaceID_intComboBox
            // 
            this.PortPlaceID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortPlaceID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PortPlaceID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PortPlaceID_intComboBox.DropDownHeight = 200;
            this.PortPlaceID_intComboBox.FormattingEnabled = true;
            this.PortPlaceID_intComboBox.IntegralHeight = false;
            this.PortPlaceID_intComboBox.Location = new System.Drawing.Point(6, 121);
            this.PortPlaceID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.PortPlaceID_intComboBox.Name = "PortPlaceID_intComboBox";
            this.PortPlaceID_intComboBox.Size = new System.Drawing.Size(276, 31);
            this.PortPlaceID_intComboBox.TabIndex = 13;
            // 
            // LaderTypeID_intComboBox
            // 
            this.LaderTypeID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LaderTypeID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LaderTypeID_intComboBox.DropDownHeight = 200;
            this.LaderTypeID_intComboBox.FormattingEnabled = true;
            this.LaderTypeID_intComboBox.IntegralHeight = false;
            this.LaderTypeID_intComboBox.Location = new System.Drawing.Point(46, 197);
            this.LaderTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeID_intComboBox.MaxDropDownItems = 14;
            this.LaderTypeID_intComboBox.Name = "LaderTypeID_intComboBox";
            this.LaderTypeID_intComboBox.Size = new System.Drawing.Size(236, 31);
            this.LaderTypeID_intComboBox.TabIndex = 15;
            this.LaderTypeID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.LaderTypeID_intComboBox_SelectionChangeCommitted);
            this.LaderTypeID_intComboBox.SelectedValueChanged += new System.EventHandler(this.LaderTypeID_intComboBox_SelectedValueChanged);
            this.LaderTypeID_intComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaderTypeID_intComboBox_KeyDown);
            // 
            // MinWeight_decNumericTextBox
            // 
            this.MinWeight_decNumericTextBox.AllowNegative = false;
            this.MinWeight_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinWeight_decNumericTextBox.DigitsInGroup = 0;
            this.MinWeight_decNumericTextBox.Flags = 65536;
            this.MinWeight_decNumericTextBox.Location = new System.Drawing.Point(4, 16);
            this.MinWeight_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MinWeight_decNumericTextBox.MaxDecimalPlaces = 0;
            this.MinWeight_decNumericTextBox.MaxWholeDigits = 155;
            this.MinWeight_decNumericTextBox.Name = "MinWeight_decNumericTextBox";
            this.MinWeight_decNumericTextBox.Prefix = "";
            this.MinWeight_decNumericTextBox.RangeMax = 0D;
            this.MinWeight_decNumericTextBox.RangeMin = 0D;
            this.MinWeight_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinWeight_decNumericTextBox.Size = new System.Drawing.Size(278, 30);
            this.MinWeight_decNumericTextBox.TabIndex = 10;
            this.MinWeight_decNumericTextBox.TextChanged += new System.EventHandler(this.MinWeight_decNumericTextBox_TextChanged);
            // 
            // MaxWeight_decNumericTextBox
            // 
            this.MaxWeight_decNumericTextBox.AllowNegative = false;
            this.MaxWeight_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxWeight_decNumericTextBox.DigitsInGroup = 0;
            this.MaxWeight_decNumericTextBox.Flags = 65536;
            this.MaxWeight_decNumericTextBox.Location = new System.Drawing.Point(4, 51);
            this.MaxWeight_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.MaxWeight_decNumericTextBox.MaxDecimalPlaces = 0;
            this.MaxWeight_decNumericTextBox.MaxWholeDigits = 155;
            this.MaxWeight_decNumericTextBox.Name = "MaxWeight_decNumericTextBox";
            this.MaxWeight_decNumericTextBox.Prefix = "";
            this.MaxWeight_decNumericTextBox.RangeMax = 0D;
            this.MaxWeight_decNumericTextBox.RangeMin = 0D;
            this.MaxWeight_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxWeight_decNumericTextBox.Size = new System.Drawing.Size(278, 30);
            this.MaxWeight_decNumericTextBox.TabIndex = 11;
            // 
            // PortageFee_decNumericTextBox
            // 
            this.PortageFee_decNumericTextBox.AllowNegative = false;
            this.PortageFee_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortageFee_decNumericTextBox.DigitsInGroup = 3;
            this.PortageFee_decNumericTextBox.Flags = 65536;
            this.PortageFee_decNumericTextBox.Location = new System.Drawing.Point(6, 86);
            this.PortageFee_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PortageFee_decNumericTextBox.MaxDecimalPlaces = 0;
            this.PortageFee_decNumericTextBox.MaxWholeDigits = 155;
            this.PortageFee_decNumericTextBox.Name = "PortageFee_decNumericTextBox";
            this.PortageFee_decNumericTextBox.Prefix = "";
            this.PortageFee_decNumericTextBox.RangeMax = 0D;
            this.PortageFee_decNumericTextBox.RangeMin = 0D;
            this.PortageFee_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PortageFee_decNumericTextBox.Size = new System.Drawing.Size(276, 30);
            this.PortageFee_decNumericTextBox.TabIndex = 12;
            // 
            // CityID_intComboBox
            // 
            this.CityID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CityID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CityID_intComboBox.DropDownHeight = 200;
            this.CityID_intComboBox.FormattingEnabled = true;
            this.CityID_intComboBox.IntegralHeight = false;
            this.CityID_intComboBox.Location = new System.Drawing.Point(484, 137);
            this.CityID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CityID_intComboBox.Name = "CityID_intComboBox";
            this.CityID_intComboBox.Size = new System.Drawing.Size(238, 31);
            this.CityID_intComboBox.TabIndex = 3;
            this.CityID_intComboBox.SelectedValueChanged += new System.EventHandler(this.CityID_intComboBox_SelectedValueChanged);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.NewButton);
            this.DetailGropBox.Controls.Add(this.Nextbutton);
            this.DetailGropBox.Controls.Add(this.Previousbutton);
            this.DetailGropBox.Controls.Add(this.Editbutton);
            this.DetailGropBox.Controls.Add(this.Comment_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CommentSearchbutton);
            this.DetailGropBox.Controls.Add(this.CarCount_intNumericTextBox);
            this.DetailGropBox.Controls.Add(this.Comment_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CarCount_intLabel);
            this.DetailGropBox.Controls.Add(this.LadeComments_nvcListBox);
            this.DetailGropBox.Controls.Add(this.DestinationAddressID_intNewButton);
            this.DetailGropBox.Controls.Add(this.DestinationAddressID_intComboBox);
            this.DetailGropBox.Controls.Add(this.label4);
            this.DetailGropBox.Controls.Add(this.CompanyCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.label2);
            this.DetailGropBox.Controls.Add(this.BoxingCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.label1);
            this.DetailGropBox.Controls.Add(this.CompanyID_intNewButton);
            this.DetailGropBox.Controls.Add(this.LaderTypeID_intNewButton);
            this.DetailGropBox.Controls.Add(this.GoodID_intNewButton);
            this.DetailGropBox.Controls.Add(this.CityID_intNewButton);
            this.DetailGropBox.Controls.Add(this.BoxingID_intNewButton);
            this.DetailGropBox.Controls.Add(this.PortageFee_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.MaxWeight_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.CityCode_nvcLabel);
            this.DetailGropBox.Controls.Add(this.MinWeight_decNumericTextBox);
            this.DetailGropBox.Controls.Add(this.PortageFee_decLabel);
            this.DetailGropBox.Controls.Add(this.Address_nvcLabel);
            this.DetailGropBox.Controls.Add(this.CompanyID_intComboBox);
            this.DetailGropBox.Controls.Add(this.MaxWeight_decLabel);
            this.DetailGropBox.Controls.Add(this.GoodCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.CityCode_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.LaderTypeID_intComboBox);
            this.DetailGropBox.Controls.Add(this.MinWeight_decLabel);
            this.DetailGropBox.Controls.Add(this.PortPlaceID_intComboBox);
            this.DetailGropBox.Controls.Add(this.CompanyID_intLabel);
            this.DetailGropBox.Controls.Add(this.Conditin_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.BoxingID_intComboBox);
            this.DetailGropBox.Controls.Add(this.LaderTypeID_intLabel);
            this.DetailGropBox.Controls.Add(this.GoodID_intComboBox);
            this.DetailGropBox.Controls.Add(this.PortPlaceID_intLabel);
            this.DetailGropBox.Controls.Add(this.AnnouncementTimeID_intLabel);
            this.DetailGropBox.Controls.Add(this.CityID_intComboBox);
            this.DetailGropBox.Controls.Add(this.BoxingID_intLabel);
            this.DetailGropBox.Controls.Add(this.CityID_intLabel);
            this.DetailGropBox.Controls.Add(this.AnnouncementTimeID_intComboBox);
            this.DetailGropBox.Controls.Add(this.GoodID_intLabel);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(826, 484);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NewButton.Location = new System.Drawing.Point(8, 445);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 26);
            this.NewButton.TabIndex = 25;
            this.NewButton.Text = "جدید";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Visible = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            this.NewButton.MouseHover += new System.EventHandler(this.NewButton_MouseHover);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Nextbutton.Location = new System.Drawing.Point(218, 445);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(66, 26);
            this.Nextbutton.TabIndex = 22;
            this.Nextbutton.Text = "بعدی";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Visible = false;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            this.Nextbutton.MouseHover += new System.EventHandler(this.Nextbutton_MouseHover);
            // 
            // Previousbutton
            // 
            this.Previousbutton.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Previousbutton.Location = new System.Drawing.Point(147, 445);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(66, 26);
            this.Previousbutton.TabIndex = 23;
            this.Previousbutton.Text = "قبلی";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Visible = false;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            this.Previousbutton.MouseHover += new System.EventHandler(this.Previousbutton_MouseHover);
            // 
            // Editbutton
            // 
            this.Editbutton.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Editbutton.Location = new System.Drawing.Point(78, 445);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(66, 26);
            this.Editbutton.TabIndex = 24;
            this.Editbutton.Text = "تغییرات";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            this.Editbutton.MouseHover += new System.EventHandler(this.Editbutton_MouseHover);
            // 
            // Comment_nvcLabel
            // 
            this.Comment_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_nvcLabel.AutoSize = true;
            this.Comment_nvcLabel.Location = new System.Drawing.Point(285, 249);
            this.Comment_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Comment_nvcLabel.Name = "Comment_nvcLabel";
            this.Comment_nvcLabel.Size = new System.Drawing.Size(60, 23);
            this.Comment_nvcLabel.TabIndex = 91;
            this.Comment_nvcLabel.Text = "توضیحات";
            // 
            // CommentSearchbutton
            // 
            this.CommentSearchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentSearchbutton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CommentSearchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CommentSearchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CommentSearchbutton.Location = new System.Drawing.Point(292, 277);
            this.CommentSearchbutton.Margin = new System.Windows.Forms.Padding(5);
            this.CommentSearchbutton.Name = "CommentSearchbutton";
            this.CommentSearchbutton.Size = new System.Drawing.Size(32, 32);
            this.CommentSearchbutton.TabIndex = 17;
            this.CommentSearchbutton.TabStop = false;
            this.CommentSearchbutton.UseVisualStyleBackColor = true;
            this.CommentSearchbutton.Click += new System.EventHandler(this.CommentSearchbutton_Click);
            this.CommentSearchbutton.MouseHover += new System.EventHandler(this.CommentSearchbutton_MouseHover);
            // 
            // CarCount_intNumericTextBox
            // 
            this.CarCount_intNumericTextBox.AllowNegative = false;
            this.CarCount_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCount_intNumericTextBox.DigitsInGroup = 0;
            this.CarCount_intNumericTextBox.Flags = 65536;
            this.CarCount_intNumericTextBox.Location = new System.Drawing.Point(7, 157);
            this.CarCount_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CarCount_intNumericTextBox.MaxDecimalPlaces = 0;
            this.CarCount_intNumericTextBox.MaxWholeDigits = 3;
            this.CarCount_intNumericTextBox.Name = "CarCount_intNumericTextBox";
            this.CarCount_intNumericTextBox.Prefix = "";
            this.CarCount_intNumericTextBox.RangeMax = 0D;
            this.CarCount_intNumericTextBox.RangeMin = 0D;
            this.CarCount_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CarCount_intNumericTextBox.Size = new System.Drawing.Size(276, 30);
            this.CarCount_intNumericTextBox.TabIndex = 14;
            // 
            // Comment_nvcTextBox
            // 
            this.Comment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_nvcTextBox.Location = new System.Drawing.Point(10, 239);
            this.Comment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Comment_nvcTextBox.MaxLength = 500;
            this.Comment_nvcTextBox.Multiline = true;
            this.Comment_nvcTextBox.Name = "Comment_nvcTextBox";
            this.Comment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Comment_nvcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Comment_nvcTextBox.Size = new System.Drawing.Size(274, 89);
            this.Comment_nvcTextBox.TabIndex = 18;
            this.Comment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CarCount_intLabel
            // 
            this.CarCount_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarCount_intLabel.AutoSize = true;
            this.CarCount_intLabel.Location = new System.Drawing.Point(285, 161);
            this.CarCount_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CarCount_intLabel.Name = "CarCount_intLabel";
            this.CarCount_intLabel.Size = new System.Drawing.Size(114, 23);
            this.CarCount_intLabel.TabIndex = 89;
            this.CarCount_intLabel.Text = "تعداد خودرو مورد نیاز";
            // 
            // LadeComments_nvcListBox
            // 
            this.LadeComments_nvcListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadeComments_nvcListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LadeComments_nvcListBox.FormattingEnabled = true;
            this.LadeComments_nvcListBox.ItemHeight = 23;
            this.LadeComments_nvcListBox.Location = new System.Drawing.Point(446, 403);
            this.LadeComments_nvcListBox.Margin = new System.Windows.Forms.Padding(5);
            this.LadeComments_nvcListBox.Name = "LadeComments_nvcListBox";
            this.LadeComments_nvcListBox.Size = new System.Drawing.Size(276, 71);
            this.LadeComments_nvcListBox.TabIndex = 19;
            this.LadeComments_nvcListBox.TabStop = false;
            this.LadeComments_nvcListBox.Visible = false;
            // 
            // DestinationAddressID_intNewButton
            // 
            this.DestinationAddressID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationAddressID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.DestinationAddressID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DestinationAddressID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DestinationAddressID_intNewButton.Location = new System.Drawing.Point(448, 211);
            this.DestinationAddressID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.DestinationAddressID_intNewButton.Name = "DestinationAddressID_intNewButton";
            this.DestinationAddressID_intNewButton.Size = new System.Drawing.Size(31, 33);
            this.DestinationAddressID_intNewButton.TabIndex = 7;
            this.DestinationAddressID_intNewButton.TabStop = false;
            this.DestinationAddressID_intNewButton.UseVisualStyleBackColor = true;
            this.DestinationAddressID_intNewButton.Click += new System.EventHandler(this.DestinationAddressID_intNewButton_Click);
            // 
            // DestinationAddressID_intComboBox
            // 
            this.DestinationAddressID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationAddressID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DestinationAddressID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DestinationAddressID_intComboBox.DropDownHeight = 200;
            this.DestinationAddressID_intComboBox.FormattingEnabled = true;
            this.DestinationAddressID_intComboBox.IntegralHeight = false;
            this.DestinationAddressID_intComboBox.Location = new System.Drawing.Point(484, 212);
            this.DestinationAddressID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.DestinationAddressID_intComboBox.Name = "DestinationAddressID_intComboBox";
            this.DestinationAddressID_intComboBox.Size = new System.Drawing.Size(238, 31);
            this.DestinationAddressID_intComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "کد شرکت";
            // 
            // CompanyCode_nvcTextBox
            // 
            this.CompanyCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyCode_nvcTextBox.Enabled = false;
            this.CompanyCode_nvcTextBox.Location = new System.Drawing.Point(446, 100);
            this.CompanyCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyCode_nvcTextBox.MaxLength = 10;
            this.CompanyCode_nvcTextBox.Name = "CompanyCode_nvcTextBox";
            this.CompanyCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyCode_nvcTextBox.Size = new System.Drawing.Size(276, 30);
            this.CompanyCode_nvcTextBox.TabIndex = 2;
            this.CompanyCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "کد نوع بسته بندی";
            // 
            // BoxingCode_nvcTextBox
            // 
            this.BoxingCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxingCode_nvcTextBox.Enabled = false;
            this.BoxingCode_nvcTextBox.Location = new System.Drawing.Point(446, 363);
            this.BoxingCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.BoxingCode_nvcTextBox.MaxLength = 10;
            this.BoxingCode_nvcTextBox.Name = "BoxingCode_nvcTextBox";
            this.BoxingCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxingCode_nvcTextBox.Size = new System.Drawing.Size(276, 30);
            this.BoxingCode_nvcTextBox.TabIndex = 9;
            this.BoxingCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = " کد کالا";
            // 
            // CompanyID_intNewButton
            // 
            this.CompanyID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CompanyID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompanyID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyID_intNewButton.Location = new System.Drawing.Point(446, 62);
            this.CompanyID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intNewButton.Name = "CompanyID_intNewButton";
            this.CompanyID_intNewButton.Size = new System.Drawing.Size(32, 31);
            this.CompanyID_intNewButton.TabIndex = 22;
            this.CompanyID_intNewButton.TabStop = false;
            this.CompanyID_intNewButton.UseVisualStyleBackColor = true;
            this.CompanyID_intNewButton.Click += new System.EventHandler(this.CompanyID_intNewButton_Click);
            // 
            // LaderTypeID_intNewButton
            // 
            this.LaderTypeID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaderTypeID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.LaderTypeID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LaderTypeID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaderTypeID_intNewButton.Location = new System.Drawing.Point(7, 196);
            this.LaderTypeID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeID_intNewButton.Name = "LaderTypeID_intNewButton";
            this.LaderTypeID_intNewButton.Size = new System.Drawing.Size(32, 32);
            this.LaderTypeID_intNewButton.TabIndex = 19;
            this.LaderTypeID_intNewButton.TabStop = false;
            this.LaderTypeID_intNewButton.UseVisualStyleBackColor = true;
            this.LaderTypeID_intNewButton.Click += new System.EventHandler(this.LaderTypeID_intNewButton_Click);
            // 
            // GoodID_intNewButton
            // 
            this.GoodID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.GoodID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GoodID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoodID_intNewButton.Location = new System.Drawing.Point(447, 250);
            this.GoodID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.GoodID_intNewButton.Name = "GoodID_intNewButton";
            this.GoodID_intNewButton.Size = new System.Drawing.Size(32, 31);
            this.GoodID_intNewButton.TabIndex = 9;
            this.GoodID_intNewButton.TabStop = false;
            this.GoodID_intNewButton.UseVisualStyleBackColor = true;
            this.GoodID_intNewButton.Click += new System.EventHandler(this.GoodID_intNewButton_Click);
            // 
            // CityID_intNewButton
            // 
            this.CityID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CityID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CityID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CityID_intNewButton.Location = new System.Drawing.Point(446, 137);
            this.CityID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CityID_intNewButton.Name = "CityID_intNewButton";
            this.CityID_intNewButton.Size = new System.Drawing.Size(32, 31);
            this.CityID_intNewButton.TabIndex = 5;
            this.CityID_intNewButton.TabStop = false;
            this.CityID_intNewButton.UseVisualStyleBackColor = true;
            this.CityID_intNewButton.Click += new System.EventHandler(this.CityID_intNewButton_Click);
            // 
            // BoxingID_intNewButton
            // 
            this.BoxingID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxingID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.BoxingID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BoxingID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxingID_intNewButton.Location = new System.Drawing.Point(447, 324);
            this.BoxingID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.BoxingID_intNewButton.Name = "BoxingID_intNewButton";
            this.BoxingID_intNewButton.Size = new System.Drawing.Size(32, 33);
            this.BoxingID_intNewButton.TabIndex = 12;
            this.BoxingID_intNewButton.TabStop = false;
            this.BoxingID_intNewButton.UseVisualStyleBackColor = true;
            this.BoxingID_intNewButton.Click += new System.EventHandler(this.BoxingID_intNewButton_Click);
            // 
            // CompanyID_intComboBox
            // 
            this.CompanyID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyID_intComboBox.DropDownHeight = 200;
            this.CompanyID_intComboBox.FormattingEnabled = true;
            this.CompanyID_intComboBox.IntegralHeight = false;
            this.CompanyID_intComboBox.Location = new System.Drawing.Point(484, 62);
            this.CompanyID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intComboBox.Name = "CompanyID_intComboBox";
            this.CompanyID_intComboBox.Size = new System.Drawing.Size(238, 31);
            this.CompanyID_intComboBox.TabIndex = 1;
            this.CompanyID_intComboBox.SelectedValueChanged += new System.EventHandler(this.CompanyID_intComboBox_SelectedValueChanged);
            // 
            // GoodCode_nvcTextBox
            // 
            this.GoodCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodCode_nvcTextBox.Enabled = false;
            this.GoodCode_nvcTextBox.Location = new System.Drawing.Point(446, 288);
            this.GoodCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GoodCode_nvcTextBox.MaxLength = 10;
            this.GoodCode_nvcTextBox.Name = "GoodCode_nvcTextBox";
            this.GoodCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoodCode_nvcTextBox.Size = new System.Drawing.Size(276, 30);
            this.GoodCode_nvcTextBox.TabIndex = 7;
            this.GoodCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Location = new System.Drawing.Point(723, 66);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(45, 23);
            this.CompanyID_intLabel.TabIndex = 68;
            this.CompanyID_intLabel.Text = "شرکت";
            // 
            // CommentAddbutton
            // 
            this.CommentAddbutton.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CommentAddbutton.Location = new System.Drawing.Point(850, 401);
            this.CommentAddbutton.Name = "CommentAddbutton";
            this.CommentAddbutton.Size = new System.Drawing.Size(110, 26);
            this.CommentAddbutton.TabIndex = 16;
            this.CommentAddbutton.Text = "افزودن Shift+C";
            this.CommentAddbutton.UseVisualStyleBackColor = true;
            this.CommentAddbutton.Visible = false;
            this.CommentAddbutton.Click += new System.EventHandler(this.CommentAddbutton_Click);
            this.CommentAddbutton.MouseHover += new System.EventHandler(this.CommentAddbutton_MouseHover);
            // 
            // LadeCommentDeletebutton
            // 
            this.LadeCommentDeletebutton.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LadeCommentDeletebutton.Location = new System.Drawing.Point(850, 369);
            this.LadeCommentDeletebutton.Name = "LadeCommentDeletebutton";
            this.LadeCommentDeletebutton.Size = new System.Drawing.Size(110, 26);
            this.LadeCommentDeletebutton.TabIndex = 17;
            this.LadeCommentDeletebutton.Text = "حذف آیتم ها Alt+C";
            this.LadeCommentDeletebutton.UseVisualStyleBackColor = true;
            this.LadeCommentDeletebutton.Visible = false;
            this.LadeCommentDeletebutton.Click += new System.EventHandler(this.LadeCommentDeletebutton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(840, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "توضیحات پیش فرض";
            this.label5.Visible = false;
            // 
            // LadeCommentID_intComboBox
            // 
            this.LadeCommentID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadeCommentID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LadeCommentID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LadeCommentID_intComboBox.Enabled = false;
            this.LadeCommentID_intComboBox.FormattingEnabled = true;
            this.LadeCommentID_intComboBox.Location = new System.Drawing.Point(875, 271);
            this.LadeCommentID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LadeCommentID_intComboBox.MaxDropDownItems = 14;
            this.LadeCommentID_intComboBox.Name = "LadeCommentID_intComboBox";
            this.LadeCommentID_intComboBox.Size = new System.Drawing.Size(74, 31);
            this.LadeCommentID_intComboBox.TabIndex = 17;
            this.LadeCommentID_intComboBox.Visible = false;
            this.LadeCommentID_intComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeCommentID_intComboBox_KeyDown);
            // 
            // LadeAssignmentEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 500);
            this.Controls.Add(this.DetailGropBox);
            this.Controls.Add(this.LadeCommentID_intComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LadeCommentDeletebutton);
            this.Controls.Add(this.CommentAddbutton);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "LadeAssignmentEntityForm";
            this.Text = "اطلاع رسانی بار شرکت";
            this.Load += new System.EventHandler(this.LadeAssignmentEntityForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeAssignmentEntityForm_KeyDown);
            this.Controls.SetChildIndex(this.CommentAddbutton, 0);
            this.Controls.SetChildIndex(this.LadeCommentDeletebutton, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.LadeCommentID_intComboBox, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label CityCode_nvcLabel;
        private System.Windows.Forms.Label Address_nvcLabel;
        private System.Windows.Forms.TextBox CityCode_nvcTextBox;
        private System.Windows.Forms.TextBox Conditin_nvcTextBox;

        private System.Windows.Forms.Label AnnouncementTimeID_intLabel;
        private System.Windows.Forms.Label CityID_intLabel;
        private System.Windows.Forms.Label GoodID_intLabel;
        private System.Windows.Forms.Label BoxingID_intLabel;
        private System.Windows.Forms.Label PortPlaceID_intLabel;
        private System.Windows.Forms.Label LaderTypeID_intLabel;

        private System.Windows.Forms.ComboBox AnnouncementTimeID_intComboBox;
        private System.Windows.Forms.ComboBox GoodID_intComboBox;
        private System.Windows.Forms.ComboBox BoxingID_intComboBox;
        private System.Windows.Forms.ComboBox PortPlaceID_intComboBox;
        private System.Windows.Forms.ComboBox LaderTypeID_intComboBox;
        private System.Windows.Forms.Button CityID_intNewButton;
        private System.Windows.Forms.Button GoodID_intNewButton;
        private System.Windows.Forms.Button BoxingID_intNewButton;
        private System.Windows.Forms.Button LaderTypeID_intNewButton;

        private System.Windows.Forms.Label MinWeight_decLabel;
        private System.Windows.Forms.Label MaxWeight_decLabel;
        private System.Windows.Forms.Label PortageFee_decLabel;

        private NumericTextBox MinWeight_decNumericTextBox;
        private NumericTextBox MaxWeight_decNumericTextBox;
        private NumericTextBox PortageFee_decNumericTextBox;
        private System.Windows.Forms.ComboBox CityID_intComboBox;
        private System.Windows.Forms.GroupBox DetailGropBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GoodCode_nvcTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxingCode_nvcTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CompanyCode_nvcTextBox;
        private System.Windows.Forms.Button CompanyID_intNewButton;
        private System.Windows.Forms.ComboBox CompanyID_intComboBox;
        private System.Windows.Forms.Label CompanyID_intLabel;
        private System.Windows.Forms.ComboBox DestinationAddressID_intComboBox;
        private System.Windows.Forms.Button DestinationAddressID_intNewButton;
        private System.Windows.Forms.Label Comment_nvcLabel;
        private System.Windows.Forms.TextBox Comment_nvcTextBox;
        private NumericTextBox CarCount_intNumericTextBox;
        private System.Windows.Forms.Label CarCount_intLabel;
        private System.Windows.Forms.ListBox LadeComments_nvcListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LadeCommentID_intComboBox;
        private System.Windows.Forms.Button CommentSearchbutton;
        private System.Windows.Forms.Button CommentAddbutton;
        private System.Windows.Forms.Button LadeCommentDeletebutton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Editbutton;

    }
}
