using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.Infraction
{
    partial class InfractionEntityForm 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfractionEntityForm));
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.OtherOffender_nvcNewButton = new System.Windows.Forms.Button();
            this.RegiaterComment_nvcLabel = new System.Windows.Forms.Label();
            this.SolveComment_nvcLabel = new System.Windows.Forms.Label();
            this.OtherOffender_nvcLabel = new System.Windows.Forms.Label();
            this.PenaltyFee_decLabel = new System.Windows.Forms.Label();
            this.RegiaterComment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.SolveComment_nvcTextBox = new System.Windows.Forms.TextBox();
            this.OtherOffender_nvcComboBox = new System.Windows.Forms.ComboBox();
            this.PenaltyFee_decNumericTextBox = new NumericTextBox();
            this.InfractionTypeID_intLabel = new System.Windows.Forms.Label();
            this.InfractionTypeID_intComboBox = new System.Windows.Forms.ComboBox();
            this.InfractionGroupID_intLabel = new System.Windows.Forms.Label();
            this.InfractionGroupID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CargroupBox = new System.Windows.Forms.GroupBox();
            this.PlateCityID_intComboBox = new System.Windows.Forms.ComboBox();
            this.PlateCity_nvcBottun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CarID_intNewButton = new System.Windows.Forms.Button();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.PlateCityCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.NumberPlate_nvcLabel = new System.Windows.Forms.Label();
            this.SerialPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.SerialPlate_nvcLabel = new System.Windows.Forms.Label();
            this.PlateCityCode_nvcLabel = new System.Windows.Forms.Label();
            this.DrivergroupBox = new System.Windows.Forms.GroupBox();
            this.DriverCardNumber_bintLabel = new System.Windows.Forms.Label();
            this.DriverID_bintNewButton = new System.Windows.Forms.Button();
            this.DriverNationalCode_bintNumericTextBox = new NumericTextBox();
            this.DriverCardNumber_bintTextBox = new System.Windows.Forms.TextBox();
            this.DriverLicenceNumber_intNumericTextBox = new NumericTextBox();
            this.DriverLastName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DriverFirstName_nvcLabel = new System.Windows.Forms.Label();
            this.DriverFirstName_nvcTextBox = new System.Windows.Forms.TextBox();
            this.DriverNationalCode_bintLabel = new System.Windows.Forms.Label();
            this.DriverLastName_nvcLabel = new System.Windows.Forms.Label();
            this.DriverLicenceNumber_intLabel = new System.Windows.Forms.Label();
            this.CompanygroupBox = new System.Windows.Forms.GroupBox();
            this.CompanyID_intNewButton = new System.Windows.Forms.Button();
            this.CompanyID_intComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyCode_nvcLabel = new System.Windows.Forms.Label();
            this.CompanyCode_nvcTextBox = new System.Windows.Forms.TextBox();
            this.CompanyID_intLabel = new System.Windows.Forms.Label();
            this.InfractionTypeNewButton = new System.Windows.Forms.Button();
            this.TrafficgroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommentControl_nvctextBox = new System.Windows.Forms.TextBox();
            this.Exit_bitcheckBox = new System.Windows.Forms.CheckBox();
            this.TurnAccept_bitcheckBox = new System.Windows.Forms.CheckBox();
            this.TurnSave_bitcheckBox = new System.Windows.Forms.CheckBox();
            this.TrafficcheckBox = new System.Windows.Forms.CheckBox();
            this.DetailGropBox.SuspendLayout();
            this.CargroupBox.SuspendLayout();
            this.DrivergroupBox.SuspendLayout();
            this.CompanygroupBox.SuspendLayout();
            this.TrafficgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(805, 458);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndNextButton.TabIndex = 6;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(707, 458);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.SaveAndCloseButton.TabIndex = 7;
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(607, 458);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DeleteRecordButton.TabIndex = 9;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(507, 458);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CloseFormButton.TabIndex = 8;
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailGropBox.Controls.Add(this.OtherOffender_nvcNewButton);
            this.DetailGropBox.Controls.Add(this.RegiaterComment_nvcLabel);
            this.DetailGropBox.Controls.Add(this.SolveComment_nvcLabel);
            this.DetailGropBox.Controls.Add(this.OtherOffender_nvcLabel);
            this.DetailGropBox.Controls.Add(this.PenaltyFee_decLabel);
            this.DetailGropBox.Controls.Add(this.RegiaterComment_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.SolveComment_nvcTextBox);
            this.DetailGropBox.Controls.Add(this.OtherOffender_nvcComboBox);
            this.DetailGropBox.Controls.Add(this.PenaltyFee_decNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(481, 91);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(417, 194);
            this.DetailGropBox.TabIndex = 5;
            this.DetailGropBox.TabStop = false;
            // 
            // OtherOffender_nvcNewButton
            // 
            this.OtherOffender_nvcNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OtherOffender_nvcNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.OtherOffender_nvcNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OtherOffender_nvcNewButton.Enabled = false;
            this.OtherOffender_nvcNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OtherOffender_nvcNewButton.Location = new System.Drawing.Point(10, 151);
            this.OtherOffender_nvcNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.OtherOffender_nvcNewButton.Name = "OtherOffender_nvcNewButton";
            this.OtherOffender_nvcNewButton.Size = new System.Drawing.Size(37, 31);
            this.OtherOffender_nvcNewButton.TabIndex = 22;
            this.OtherOffender_nvcNewButton.TabStop = false;
            this.OtherOffender_nvcNewButton.UseVisualStyleBackColor = true;
            this.OtherOffender_nvcNewButton.Click += new System.EventHandler(this.OtherOffender_nvcNewButton_Click);
            // 
            // RegiaterComment_nvcLabel
            // 
            this.RegiaterComment_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegiaterComment_nvcLabel.AutoSize = true;
            this.RegiaterComment_nvcLabel.Location = new System.Drawing.Point(324, 22);
            this.RegiaterComment_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RegiaterComment_nvcLabel.Name = "RegiaterComment_nvcLabel";
            this.RegiaterComment_nvcLabel.Size = new System.Drawing.Size(83, 23);
            this.RegiaterComment_nvcLabel.TabIndex = 9;
            this.RegiaterComment_nvcLabel.Text = "توضیحات ثبت";
            // 
            // SolveComment_nvcLabel
            // 
            this.SolveComment_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveComment_nvcLabel.AutoSize = true;
            this.SolveComment_nvcLabel.Location = new System.Drawing.Point(324, 73);
            this.SolveComment_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SolveComment_nvcLabel.Name = "SolveComment_nvcLabel";
            this.SolveComment_nvcLabel.Size = new System.Drawing.Size(82, 23);
            this.SolveComment_nvcLabel.TabIndex = 12;
            this.SolveComment_nvcLabel.Text = "توضیحات رفع";
            // 
            // OtherOffender_nvcLabel
            // 
            this.OtherOffender_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OtherOffender_nvcLabel.AutoSize = true;
            this.OtherOffender_nvcLabel.Location = new System.Drawing.Point(323, 158);
            this.OtherOffender_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OtherOffender_nvcLabel.Name = "OtherOffender_nvcLabel";
            this.OtherOffender_nvcLabel.Size = new System.Drawing.Size(78, 23);
            this.OtherOffender_nvcLabel.TabIndex = 17;
            this.OtherOffender_nvcLabel.Text = "دیگر متخلفان";
            // 
            // PenaltyFee_decLabel
            // 
            this.PenaltyFee_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PenaltyFee_decLabel.AutoSize = true;
            this.PenaltyFee_decLabel.Location = new System.Drawing.Point(323, 120);
            this.PenaltyFee_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PenaltyFee_decLabel.Name = "PenaltyFee_decLabel";
            this.PenaltyFee_decLabel.Size = new System.Drawing.Size(67, 23);
            this.PenaltyFee_decLabel.TabIndex = 21;
            this.PenaltyFee_decLabel.Text = "مبلغ جریمه";
            // 
            // RegiaterComment_nvcTextBox
            // 
            this.RegiaterComment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegiaterComment_nvcTextBox.Location = new System.Drawing.Point(10, 18);
            this.RegiaterComment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.RegiaterComment_nvcTextBox.MaxLength = 500;
            this.RegiaterComment_nvcTextBox.Multiline = true;
            this.RegiaterComment_nvcTextBox.Name = "RegiaterComment_nvcTextBox";
            this.RegiaterComment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegiaterComment_nvcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RegiaterComment_nvcTextBox.Size = new System.Drawing.Size(312, 44);
            this.RegiaterComment_nvcTextBox.TabIndex = 4;
            this.RegiaterComment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SolveComment_nvcTextBox
            // 
            this.SolveComment_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SolveComment_nvcTextBox.Location = new System.Drawing.Point(10, 68);
            this.SolveComment_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SolveComment_nvcTextBox.MaxLength = 500;
            this.SolveComment_nvcTextBox.Multiline = true;
            this.SolveComment_nvcTextBox.Name = "SolveComment_nvcTextBox";
            this.SolveComment_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SolveComment_nvcTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SolveComment_nvcTextBox.Size = new System.Drawing.Size(312, 44);
            this.SolveComment_nvcTextBox.TabIndex = 9;
            this.SolveComment_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OtherOffender_nvcComboBox
            // 
            this.OtherOffender_nvcComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OtherOffender_nvcComboBox.Enabled = false;
            this.OtherOffender_nvcComboBox.FormattingEnabled = true;
            this.OtherOffender_nvcComboBox.Location = new System.Drawing.Point(51, 151);
            this.OtherOffender_nvcComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.OtherOffender_nvcComboBox.Name = "OtherOffender_nvcComboBox";
            this.OtherOffender_nvcComboBox.Size = new System.Drawing.Size(271, 31);
            this.OtherOffender_nvcComboBox.TabIndex = 11;
            // 
            // PenaltyFee_decNumericTextBox
            // 
            this.PenaltyFee_decNumericTextBox.AllowNegative = false;
            this.PenaltyFee_decNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PenaltyFee_decNumericTextBox.DigitsInGroup = 0;
            this.PenaltyFee_decNumericTextBox.Enabled = false;
            this.PenaltyFee_decNumericTextBox.Flags = 65536;
            this.PenaltyFee_decNumericTextBox.Location = new System.Drawing.Point(10, 116);
            this.PenaltyFee_decNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PenaltyFee_decNumericTextBox.MaxDecimalPlaces = 0;
            this.PenaltyFee_decNumericTextBox.MaxWholeDigits = 155;
            this.PenaltyFee_decNumericTextBox.Name = "PenaltyFee_decNumericTextBox";
            this.PenaltyFee_decNumericTextBox.Prefix = "";
           // this.PenaltyFee_decNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.PenaltyFee_decNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.PenaltyFee_decNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PenaltyFee_decNumericTextBox.Size = new System.Drawing.Size(312, 30);
            this.PenaltyFee_decNumericTextBox.TabIndex = 10;
            // 
            // InfractionTypeID_intLabel
            // 
            this.InfractionTypeID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionTypeID_intLabel.AutoSize = true;
            this.InfractionTypeID_intLabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InfractionTypeID_intLabel.Location = new System.Drawing.Point(80, 56);
            this.InfractionTypeID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionTypeID_intLabel.Name = "InfractionTypeID_intLabel";
            this.InfractionTypeID_intLabel.Size = new System.Drawing.Size(62, 23);
            this.InfractionTypeID_intLabel.TabIndex = 13;
            this.InfractionTypeID_intLabel.Text = " نوع تخلف";
            this.InfractionTypeID_intLabel.Click += new System.EventHandler(this.InfractionTypeID_intLabel_Click);
            // 
            // InfractionTypeID_intComboBox
            // 
            this.InfractionTypeID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionTypeID_intComboBox.FormattingEnabled = true;
            this.InfractionTypeID_intComboBox.Location = new System.Drawing.Point(151, 52);
            this.InfractionTypeID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionTypeID_intComboBox.Name = "InfractionTypeID_intComboBox";
            this.InfractionTypeID_intComboBox.Size = new System.Drawing.Size(273, 31);
            this.InfractionTypeID_intComboBox.TabIndex = 1;
            this.InfractionTypeID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.InfractionTypeID_intComboBox_SelectionChangeCommitted);
            // 
            // InfractionGroupID_intLabel
            // 
            this.InfractionGroupID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroupID_intLabel.AutoSize = true;
            this.InfractionGroupID_intLabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InfractionGroupID_intLabel.Location = new System.Drawing.Point(76, 13);
            this.InfractionGroupID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfractionGroupID_intLabel.Name = "InfractionGroupID_intLabel";
            this.InfractionGroupID_intLabel.Size = new System.Drawing.Size(67, 23);
            this.InfractionGroupID_intLabel.TabIndex = 44;
            this.InfractionGroupID_intLabel.Text = "گروه تخلف";
            this.InfractionGroupID_intLabel.Click += new System.EventHandler(this.InfractionGroupID_intLabel_Click);
            // 
            // InfractionGroupID_intComboBox
            // 
            this.InfractionGroupID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionGroupID_intComboBox.FormattingEnabled = true;
            this.InfractionGroupID_intComboBox.Location = new System.Drawing.Point(153, 10);
            this.InfractionGroupID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionGroupID_intComboBox.Name = "InfractionGroupID_intComboBox";
            this.InfractionGroupID_intComboBox.Size = new System.Drawing.Size(312, 31);
            this.InfractionGroupID_intComboBox.TabIndex = 0;
            this.InfractionGroupID_intComboBox.SelectedIndexChanged += new System.EventHandler(this.InfractionGroupID_intComboBox_SelectedIndexChanged);
            this.InfractionGroupID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.InfractionGroupID_intComboBox_SelectionChangeCommitted);
            // 
            // CargroupBox
            // 
            this.CargroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CargroupBox.Controls.Add(this.PlateCityID_intComboBox);
            this.CargroupBox.Controls.Add(this.PlateCity_nvcBottun);
            this.CargroupBox.Controls.Add(this.label1);
            this.CargroupBox.Controls.Add(this.CarID_intNewButton);
            this.CargroupBox.Controls.Add(this.NumberPlate_nvcTextBox);
            this.CargroupBox.Controls.Add(this.PlateCityCode_nvcTextBox);
            this.CargroupBox.Controls.Add(this.NumberPlate_nvcLabel);
            this.CargroupBox.Controls.Add(this.SerialPlate_nvcTextBox);
            this.CargroupBox.Controls.Add(this.SerialPlate_nvcLabel);
            this.CargroupBox.Controls.Add(this.PlateCityCode_nvcLabel);
            this.CargroupBox.Enabled = false;
            this.CargroupBox.Location = new System.Drawing.Point(14, 310);
            this.CargroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.CargroupBox.Name = "CargroupBox";
            this.CargroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CargroupBox.Size = new System.Drawing.Size(453, 181);
            this.CargroupBox.TabIndex = 3;
            this.CargroupBox.TabStop = false;
            this.CargroupBox.Text = "ناوگان";
            // 
            // PlateCityID_intComboBox
            // 
            this.PlateCityID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PlateCityID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PlateCityID_intComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.PlateCityID_intComboBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCityID_intComboBox.FormattingEnabled = true;
            this.PlateCityID_intComboBox.Location = new System.Drawing.Point(50, 97);
            this.PlateCityID_intComboBox.Name = "PlateCityID_intComboBox";
            this.PlateCityID_intComboBox.Size = new System.Drawing.Size(269, 31);
            this.PlateCityID_intComboBox.TabIndex = 34;
            this.PlateCityID_intComboBox.Tag = "شهر شماره گذاري";
            this.PlateCityID_intComboBox.SelectedValueChanged += new System.EventHandler(this.PlateCityID_intComboBox_SelectedValueChanged);
            // 
            // PlateCity_nvcBottun
            // 
            this.PlateCity_nvcBottun.BackColor = System.Drawing.Color.Transparent;
            this.PlateCity_nvcBottun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlateCity_nvcBottun.BackgroundImage")));
            this.PlateCity_nvcBottun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlateCity_nvcBottun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlateCity_nvcBottun.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PlateCity_nvcBottun.Location = new System.Drawing.Point(11, 97);
            this.PlateCity_nvcBottun.Name = "PlateCity_nvcBottun";
            this.PlateCity_nvcBottun.Size = new System.Drawing.Size(31, 28);
            this.PlateCity_nvcBottun.TabIndex = 35;
            this.PlateCity_nvcBottun.TabStop = false;
            this.PlateCity_nvcBottun.UseVisualStyleBackColor = false;
            this.PlateCity_nvcBottun.Click += new System.EventHandler(this.PlateCity_nvcBottun_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "شهر شماره گذاری";
            // 
            // CarID_intNewButton
            // 
            this.CarID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CarID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CarID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CarID_intNewButton.Location = new System.Drawing.Point(9, 26);
            this.CarID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CarID_intNewButton.Name = "CarID_intNewButton";
            this.CarID_intNewButton.Size = new System.Drawing.Size(33, 30);
            this.CarID_intNewButton.TabIndex = 1;
            this.CarID_intNewButton.TabStop = false;
            this.CarID_intNewButton.UseVisualStyleBackColor = true;
            this.CarID_intNewButton.Click += new System.EventHandler(this.CarID_intNewButton_Click);
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(49, 26);
            this.NumberPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.NumberPlate_nvcTextBox.MaxLength = 50;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(270, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 0;
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberPlate_nvcTextBox.TextChanged += new System.EventHandler(this.NumberPlate_nvcTextBox_TextChanged);
            this.NumberPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberPlate_nvcTextBox_KeyDown);
            // 
            // PlateCityCode_nvcTextBox
            // 
            this.PlateCityCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityCode_nvcTextBox.Enabled = false;
            this.PlateCityCode_nvcTextBox.Location = new System.Drawing.Point(9, 134);
            this.PlateCityCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.PlateCityCode_nvcTextBox.MaxLength = 10;
            this.PlateCityCode_nvcTextBox.Name = "PlateCityCode_nvcTextBox";
            this.PlateCityCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlateCityCode_nvcTextBox.Size = new System.Drawing.Size(310, 30);
            this.PlateCityCode_nvcTextBox.TabIndex = 4;
            this.PlateCityCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberPlate_nvcLabel
            // 
            this.NumberPlate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcLabel.AutoSize = true;
            this.NumberPlate_nvcLabel.Location = new System.Drawing.Point(331, 30);
            this.NumberPlate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumberPlate_nvcLabel.Name = "NumberPlate_nvcLabel";
            this.NumberPlate_nvcLabel.Size = new System.Drawing.Size(70, 23);
            this.NumberPlate_nvcLabel.TabIndex = 2;
            this.NumberPlate_nvcLabel.Text = "شماره پلاک";
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(9, 62);
            this.SerialPlate_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialPlate_nvcTextBox.MaxLength = 3;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(310, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 2;
            this.SerialPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SerialPlate_nvcLabel
            // 
            this.SerialPlate_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerialPlate_nvcLabel.AutoSize = true;
            this.SerialPlate_nvcLabel.Location = new System.Drawing.Point(331, 66);
            this.SerialPlate_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SerialPlate_nvcLabel.Name = "SerialPlate_nvcLabel";
            this.SerialPlate_nvcLabel.Size = new System.Drawing.Size(66, 23);
            this.SerialPlate_nvcLabel.TabIndex = 3;
            this.SerialPlate_nvcLabel.Text = "سری پلاک";
            // 
            // PlateCityCode_nvcLabel
            // 
            this.PlateCityCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlateCityCode_nvcLabel.AutoSize = true;
            this.PlateCityCode_nvcLabel.Location = new System.Drawing.Point(331, 138);
            this.PlateCityCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlateCityCode_nvcLabel.Name = "PlateCityCode_nvcLabel";
            this.PlateCityCode_nvcLabel.Size = new System.Drawing.Size(120, 23);
            this.PlateCityCode_nvcLabel.TabIndex = 4;
            this.PlateCityCode_nvcLabel.Text = "کد شهر شماره گذاری";
            // 
            // DrivergroupBox
            // 
            this.DrivergroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrivergroupBox.Controls.Add(this.DriverCardNumber_bintLabel);
            this.DrivergroupBox.Controls.Add(this.DriverID_bintNewButton);
            this.DrivergroupBox.Controls.Add(this.DriverNationalCode_bintNumericTextBox);
            this.DrivergroupBox.Controls.Add(this.DriverCardNumber_bintTextBox);
            this.DrivergroupBox.Controls.Add(this.DriverLicenceNumber_intNumericTextBox);
            this.DrivergroupBox.Controls.Add(this.DriverLastName_nvcTextBox);
            this.DrivergroupBox.Controls.Add(this.DriverFirstName_nvcLabel);
            this.DrivergroupBox.Controls.Add(this.DriverFirstName_nvcTextBox);
            this.DrivergroupBox.Controls.Add(this.DriverNationalCode_bintLabel);
            this.DrivergroupBox.Controls.Add(this.DriverLastName_nvcLabel);
            this.DrivergroupBox.Controls.Add(this.DriverLicenceNumber_intLabel);
            this.DrivergroupBox.Enabled = false;
            this.DrivergroupBox.Location = new System.Drawing.Point(13, 88);
            this.DrivergroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.DrivergroupBox.Name = "DrivergroupBox";
            this.DrivergroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.DrivergroupBox.Size = new System.Drawing.Size(453, 223);
            this.DrivergroupBox.TabIndex = 2;
            this.DrivergroupBox.TabStop = false;
            this.DrivergroupBox.Text = "راننده";
            // 
            // DriverCardNumber_bintLabel
            // 
            this.DriverCardNumber_bintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_bintLabel.AutoSize = true;
            this.DriverCardNumber_bintLabel.Location = new System.Drawing.Point(331, 37);
            this.DriverCardNumber_bintLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverCardNumber_bintLabel.Name = "DriverCardNumber_bintLabel";
            this.DriverCardNumber_bintLabel.Size = new System.Drawing.Size(103, 23);
            this.DriverCardNumber_bintLabel.TabIndex = 49;
            this.DriverCardNumber_bintLabel.Text = "شماره کارت راننده";
            // 
            // DriverID_bintNewButton
            // 
            this.DriverID_bintNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverID_bintNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.DriverID_bintNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DriverID_bintNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DriverID_bintNewButton.Location = new System.Drawing.Point(9, 33);
            this.DriverID_bintNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.DriverID_bintNewButton.Name = "DriverID_bintNewButton";
            this.DriverID_bintNewButton.Size = new System.Drawing.Size(33, 32);
            this.DriverID_bintNewButton.TabIndex = 1;
            this.DriverID_bintNewButton.TabStop = false;
            this.DriverID_bintNewButton.UseVisualStyleBackColor = true;
            this.DriverID_bintNewButton.Click += new System.EventHandler(this.DriverID_bintNewButton_Click);
            // 
            // DriverNationalCode_bintNumericTextBox
            // 
            this.DriverNationalCode_bintNumericTextBox.AllowNegative = false;
            this.DriverNationalCode_bintNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverNationalCode_bintNumericTextBox.DigitsInGroup = 0;
            this.DriverNationalCode_bintNumericTextBox.Flags = 65536;
            this.DriverNationalCode_bintNumericTextBox.Location = new System.Drawing.Point(9, 183);
            this.DriverNationalCode_bintNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverNationalCode_bintNumericTextBox.MaxDecimalPlaces = 0;
            this.DriverNationalCode_bintNumericTextBox.MaxWholeDigits = 155;
            this.DriverNationalCode_bintNumericTextBox.Name = "DriverNationalCode_bintNumericTextBox";
            this.DriverNationalCode_bintNumericTextBox.Prefix = "";
          //  this.DriverNationalCode_bintNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.DriverNationalCode_bintNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.DriverNationalCode_bintNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverNationalCode_bintNumericTextBox.Size = new System.Drawing.Size(312, 30);
            this.DriverNationalCode_bintNumericTextBox.TabIndex = 5;
            // 
            // DriverCardNumber_bintTextBox
            // 
            this.DriverCardNumber_bintTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverCardNumber_bintTextBox.Location = new System.Drawing.Point(49, 33);
            this.DriverCardNumber_bintTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverCardNumber_bintTextBox.MaxLength = 50;
            this.DriverCardNumber_bintTextBox.Name = "DriverCardNumber_bintTextBox";
            this.DriverCardNumber_bintTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverCardNumber_bintTextBox.Size = new System.Drawing.Size(272, 30);
            this.DriverCardNumber_bintTextBox.TabIndex = 0;
            this.DriverCardNumber_bintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DriverCardNumber_bintTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DriverCardNumber_bintTextBox_KeyDown);
            // 
            // DriverLicenceNumber_intNumericTextBox
            // 
            this.DriverLicenceNumber_intNumericTextBox.AllowNegative = false;
            this.DriverLicenceNumber_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverLicenceNumber_intNumericTextBox.DigitsInGroup = 0;
            this.DriverLicenceNumber_intNumericTextBox.Flags = 65536;
            this.DriverLicenceNumber_intNumericTextBox.Location = new System.Drawing.Point(9, 145);
            this.DriverLicenceNumber_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverLicenceNumber_intNumericTextBox.MaxDecimalPlaces = 0;
            this.DriverLicenceNumber_intNumericTextBox.MaxWholeDigits = 158;
            this.DriverLicenceNumber_intNumericTextBox.Name = "DriverLicenceNumber_intNumericTextBox";
            this.DriverLicenceNumber_intNumericTextBox.Prefix = "";
            //this.DriverLicenceNumber_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.DriverLicenceNumber_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.DriverLicenceNumber_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverLicenceNumber_intNumericTextBox.Size = new System.Drawing.Size(312, 30);
            this.DriverLicenceNumber_intNumericTextBox.TabIndex = 4;
            // 
            // DriverLastName_nvcTextBox
            // 
            this.DriverLastName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverLastName_nvcTextBox.Location = new System.Drawing.Point(9, 107);
            this.DriverLastName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverLastName_nvcTextBox.MaxLength = 200;
            this.DriverLastName_nvcTextBox.Name = "DriverLastName_nvcTextBox";
            this.DriverLastName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverLastName_nvcTextBox.Size = new System.Drawing.Size(312, 30);
            this.DriverLastName_nvcTextBox.TabIndex = 3;
            this.DriverLastName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverFirstName_nvcLabel
            // 
            this.DriverFirstName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverFirstName_nvcLabel.AutoSize = true;
            this.DriverFirstName_nvcLabel.Location = new System.Drawing.Point(331, 71);
            this.DriverFirstName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverFirstName_nvcLabel.Name = "DriverFirstName_nvcLabel";
            this.DriverFirstName_nvcLabel.Size = new System.Drawing.Size(56, 23);
            this.DriverFirstName_nvcLabel.TabIndex = 0;
            this.DriverFirstName_nvcLabel.Text = "نام راننده";
            // 
            // DriverFirstName_nvcTextBox
            // 
            this.DriverFirstName_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverFirstName_nvcTextBox.Location = new System.Drawing.Point(9, 70);
            this.DriverFirstName_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DriverFirstName_nvcTextBox.MaxLength = 100;
            this.DriverFirstName_nvcTextBox.Name = "DriverFirstName_nvcTextBox";
            this.DriverFirstName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DriverFirstName_nvcTextBox.Size = new System.Drawing.Size(312, 30);
            this.DriverFirstName_nvcTextBox.TabIndex = 2;
            this.DriverFirstName_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DriverNationalCode_bintLabel
            // 
            this.DriverNationalCode_bintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverNationalCode_bintLabel.AutoSize = true;
            this.DriverNationalCode_bintLabel.Location = new System.Drawing.Point(331, 184);
            this.DriverNationalCode_bintLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverNationalCode_bintLabel.Name = "DriverNationalCode_bintLabel";
            this.DriverNationalCode_bintLabel.Size = new System.Drawing.Size(44, 23);
            this.DriverNationalCode_bintLabel.TabIndex = 20;
            this.DriverNationalCode_bintLabel.Text = "کد ملی";
            // 
            // DriverLastName_nvcLabel
            // 
            this.DriverLastName_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverLastName_nvcLabel.AutoSize = true;
            this.DriverLastName_nvcLabel.Location = new System.Drawing.Point(331, 108);
            this.DriverLastName_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverLastName_nvcLabel.Name = "DriverLastName_nvcLabel";
            this.DriverLastName_nvcLabel.Size = new System.Drawing.Size(105, 23);
            this.DriverLastName_nvcLabel.TabIndex = 1;
            this.DriverLastName_nvcLabel.Text = "نام خانوادگی راننده";
            // 
            // DriverLicenceNumber_intLabel
            // 
            this.DriverLicenceNumber_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverLicenceNumber_intLabel.AutoSize = true;
            this.DriverLicenceNumber_intLabel.Location = new System.Drawing.Point(331, 146);
            this.DriverLicenceNumber_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DriverLicenceNumber_intLabel.Name = "DriverLicenceNumber_intLabel";
            this.DriverLicenceNumber_intLabel.Size = new System.Drawing.Size(90, 23);
            this.DriverLicenceNumber_intLabel.TabIndex = 19;
            this.DriverLicenceNumber_intLabel.Text = "شماره گواهینامه";
            // 
            // CompanygroupBox
            // 
            this.CompanygroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanygroupBox.Controls.Add(this.CompanyID_intNewButton);
            this.CompanygroupBox.Controls.Add(this.CompanyID_intComboBox);
            this.CompanygroupBox.Controls.Add(this.CompanyCode_nvcLabel);
            this.CompanygroupBox.Controls.Add(this.CompanyCode_nvcTextBox);
            this.CompanygroupBox.Controls.Add(this.CompanyID_intLabel);
            this.CompanygroupBox.Enabled = false;
            this.CompanygroupBox.Location = new System.Drawing.Point(483, 7);
            this.CompanygroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanygroupBox.Name = "CompanygroupBox";
            this.CompanygroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.CompanygroupBox.Size = new System.Drawing.Size(417, 89);
            this.CompanygroupBox.TabIndex = 4;
            this.CompanygroupBox.TabStop = false;
            this.CompanygroupBox.Text = "شرکت";
            // 
            // CompanyID_intNewButton
            // 
            this.CompanyID_intNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intNewButton.BackgroundImage = global::HPS.Properties.Resources.Search;
            this.CompanyID_intNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompanyID_intNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyID_intNewButton.Location = new System.Drawing.Point(11, 17);
            this.CompanyID_intNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intNewButton.Name = "CompanyID_intNewButton";
            this.CompanyID_intNewButton.Size = new System.Drawing.Size(35, 31);
            this.CompanyID_intNewButton.TabIndex = 1;
            this.CompanyID_intNewButton.TabStop = false;
            this.CompanyID_intNewButton.UseVisualStyleBackColor = true;
            this.CompanyID_intNewButton.Click += new System.EventHandler(this.CompanyID_intNewButton_Click);
            // 
            // CompanyID_intComboBox
            // 
            this.CompanyID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyID_intComboBox.DropDownHeight = 200;
            this.CompanyID_intComboBox.FormattingEnabled = true;
            this.CompanyID_intComboBox.IntegralHeight = false;
            this.CompanyID_intComboBox.Location = new System.Drawing.Point(52, 17);
            this.CompanyID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyID_intComboBox.Name = "CompanyID_intComboBox";
            this.CompanyID_intComboBox.Size = new System.Drawing.Size(271, 31);
            this.CompanyID_intComboBox.TabIndex = 0;
            this.CompanyID_intComboBox.SelectionChangeCommitted += new System.EventHandler(this.CompanyID_intComboBox_SelectionChangeCommitted);
            // 
            // CompanyCode_nvcLabel
            // 
            this.CompanyCode_nvcLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyCode_nvcLabel.AutoSize = true;
            this.CompanyCode_nvcLabel.Location = new System.Drawing.Point(325, 56);
            this.CompanyCode_nvcLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyCode_nvcLabel.Name = "CompanyCode_nvcLabel";
            this.CompanyCode_nvcLabel.Size = new System.Drawing.Size(61, 23);
            this.CompanyCode_nvcLabel.TabIndex = 5;
            this.CompanyCode_nvcLabel.Text = "کد شرکت";
            // 
            // CompanyCode_nvcTextBox
            // 
            this.CompanyCode_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyCode_nvcTextBox.Location = new System.Drawing.Point(11, 52);
            this.CompanyCode_nvcTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyCode_nvcTextBox.MaxLength = 50;
            this.CompanyCode_nvcTextBox.Name = "CompanyCode_nvcTextBox";
            this.CompanyCode_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CompanyCode_nvcTextBox.Size = new System.Drawing.Size(312, 30);
            this.CompanyCode_nvcTextBox.TabIndex = 2;
            this.CompanyCode_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CompanyID_intLabel
            // 
            this.CompanyID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyID_intLabel.AutoSize = true;
            this.CompanyID_intLabel.Location = new System.Drawing.Point(325, 21);
            this.CompanyID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CompanyID_intLabel.Name = "CompanyID_intLabel";
            this.CompanyID_intLabel.Size = new System.Drawing.Size(45, 23);
            this.CompanyID_intLabel.TabIndex = 14;
            this.CompanyID_intLabel.Text = "شرکت";
            // 
            // InfractionTypeNewButton
            // 
            this.InfractionTypeNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfractionTypeNewButton.BackgroundImage = global::HPS.Properties.Resources.New_Window;
            this.InfractionTypeNewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfractionTypeNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfractionTypeNewButton.Location = new System.Drawing.Point(428, 50);
            this.InfractionTypeNewButton.Margin = new System.Windows.Forms.Padding(5);
            this.InfractionTypeNewButton.Name = "InfractionTypeNewButton";
            this.InfractionTypeNewButton.Size = new System.Drawing.Size(37, 35);
            this.InfractionTypeNewButton.TabIndex = 23;
            this.InfractionTypeNewButton.TabStop = false;
            this.InfractionTypeNewButton.UseVisualStyleBackColor = true;
            this.InfractionTypeNewButton.Click += new System.EventHandler(this.InfractionTypeNewButton_Click);
            // 
            // TrafficgroupBox
            // 
            this.TrafficgroupBox.Controls.Add(this.label2);
            this.TrafficgroupBox.Controls.Add(this.CommentControl_nvctextBox);
            this.TrafficgroupBox.Controls.Add(this.Exit_bitcheckBox);
            this.TrafficgroupBox.Controls.Add(this.TurnAccept_bitcheckBox);
            this.TrafficgroupBox.Controls.Add(this.TurnSave_bitcheckBox);
            this.TrafficgroupBox.Controls.Add(this.TrafficcheckBox);
            this.TrafficgroupBox.Location = new System.Drawing.Point(481, 281);
            this.TrafficgroupBox.Name = "TrafficgroupBox";
            this.TrafficgroupBox.Size = new System.Drawing.Size(417, 165);
            this.TrafficgroupBox.TabIndex = 45;
            this.TrafficgroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "توضیحات کنترلی";
            // 
            // CommentControl_nvctextBox
            // 
            this.CommentControl_nvctextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentControl_nvctextBox.Location = new System.Drawing.Point(10, 93);
            this.CommentControl_nvctextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CommentControl_nvctextBox.MaxLength = 500;
            this.CommentControl_nvctextBox.Multiline = true;
            this.CommentControl_nvctextBox.Name = "CommentControl_nvctextBox";
            this.CommentControl_nvctextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentControl_nvctextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommentControl_nvctextBox.Size = new System.Drawing.Size(312, 44);
            this.CommentControl_nvctextBox.TabIndex = 23;
            this.CommentControl_nvctextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Exit_bitcheckBox
            // 
            this.Exit_bitcheckBox.AutoSize = true;
            this.Exit_bitcheckBox.Location = new System.Drawing.Point(37, 56);
            this.Exit_bitcheckBox.Name = "Exit_bitcheckBox";
            this.Exit_bitcheckBox.Size = new System.Drawing.Size(118, 27);
            this.Exit_bitcheckBox.TabIndex = 3;
            this.Exit_bitcheckBox.Text = "جلوگیری از خروج";
            this.Exit_bitcheckBox.UseVisualStyleBackColor = true;
            // 
            // TurnAccept_bitcheckBox
            // 
            this.TurnAccept_bitcheckBox.AutoSize = true;
            this.TurnAccept_bitcheckBox.Location = new System.Drawing.Point(51, 21);
            this.TurnAccept_bitcheckBox.Name = "TurnAccept_bitcheckBox";
            this.TurnAccept_bitcheckBox.Size = new System.Drawing.Size(104, 27);
            this.TurnAccept_bitcheckBox.TabIndex = 2;
            this.TurnAccept_bitcheckBox.Text = "عدم تایید نوبت";
            this.TurnAccept_bitcheckBox.UseVisualStyleBackColor = true;
            // 
            // TurnSave_bitcheckBox
            // 
            this.TurnSave_bitcheckBox.AutoSize = true;
            this.TurnSave_bitcheckBox.Location = new System.Drawing.Point(270, 56);
            this.TurnSave_bitcheckBox.Name = "TurnSave_bitcheckBox";
            this.TurnSave_bitcheckBox.Size = new System.Drawing.Size(101, 27);
            this.TurnSave_bitcheckBox.TabIndex = 1;
            this.TurnSave_bitcheckBox.Text = "عدم ثبت نوبت";
            this.TurnSave_bitcheckBox.UseVisualStyleBackColor = true;
            // 
            // TrafficcheckBox
            // 
            this.TrafficcheckBox.AutoSize = true;
            this.TrafficcheckBox.Location = new System.Drawing.Point(207, 21);
            this.TrafficcheckBox.Name = "TrafficcheckBox";
            this.TrafficcheckBox.Size = new System.Drawing.Size(164, 27);
            this.TrafficcheckBox.TabIndex = 0;
            this.TrafficcheckBox.Text = "خطا هنگام ورود به پارکینگ";
            this.TrafficcheckBox.UseVisualStyleBackColor = true;
            // 
            // InfractionEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 504);
            this.Controls.Add(this.TrafficgroupBox);
            this.Controls.Add(this.InfractionTypeNewButton);
            this.Controls.Add(this.CompanygroupBox);
            this.Controls.Add(this.CargroupBox);
            this.Controls.Add(this.DrivergroupBox);
            this.Controls.Add(this.InfractionGroupID_intLabel);
            this.Controls.Add(this.DetailGropBox);
            this.Controls.Add(this.InfractionGroupID_intComboBox);
            this.Controls.Add(this.InfractionTypeID_intLabel);
            this.Controls.Add(this.InfractionTypeID_intComboBox);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "InfractionEntityForm";
            this.Text = "ثبت تخلفات";
            this.Load += new System.EventHandler(this.InfractionEntityForm_Load);
            this.Controls.SetChildIndex(this.InfractionTypeID_intComboBox, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.InfractionTypeID_intLabel, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.InfractionGroupID_intComboBox, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.Controls.SetChildIndex(this.InfractionGroupID_intLabel, 0);
            this.Controls.SetChildIndex(this.DrivergroupBox, 0);
            this.Controls.SetChildIndex(this.CargroupBox, 0);
            this.Controls.SetChildIndex(this.CompanygroupBox, 0);
            this.Controls.SetChildIndex(this.InfractionTypeNewButton, 0);
            this.Controls.SetChildIndex(this.TrafficgroupBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.CargroupBox.ResumeLayout(false);
            this.CargroupBox.PerformLayout();
            this.DrivergroupBox.ResumeLayout(false);
            this.DrivergroupBox.PerformLayout();
            this.CompanygroupBox.ResumeLayout(false);
            this.CompanygroupBox.PerformLayout();
            this.TrafficgroupBox.ResumeLayout(false);
            this.TrafficgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;
        private System.Windows.Forms.Label RegiaterComment_nvcLabel;
private System.Windows.Forms.Label SolveComment_nvcLabel;
private System.Windows.Forms.TextBox RegiaterComment_nvcTextBox;
private System.Windows.Forms.TextBox SolveComment_nvcTextBox;

private System.Windows.Forms.Label InfractionTypeID_intLabel;
private System.Windows.Forms.Label OtherOffender_nvcLabel;

private System.Windows.Forms.ComboBox InfractionTypeID_intComboBox;
private System.Windows.Forms.ComboBox OtherOffender_nvcComboBox;
private System.Windows.Forms.Label PenaltyFee_decLabel;
private NumericTextBox PenaltyFee_decNumericTextBox;
private System.Windows.Forms.Label InfractionGroupID_intLabel;
private System.Windows.Forms.ComboBox InfractionGroupID_intComboBox;
private System.Windows.Forms.GroupBox CargroupBox;
private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
private System.Windows.Forms.TextBox PlateCityCode_nvcTextBox;
private System.Windows.Forms.Label NumberPlate_nvcLabel;
private System.Windows.Forms.TextBox SerialPlate_nvcTextBox;
private System.Windows.Forms.Label SerialPlate_nvcLabel;
private System.Windows.Forms.Label PlateCityCode_nvcLabel;
private System.Windows.Forms.GroupBox DrivergroupBox;
private System.Windows.Forms.Label DriverCardNumber_bintLabel;
private System.Windows.Forms.Button DriverID_bintNewButton;
private NumericTextBox DriverNationalCode_bintNumericTextBox;
private System.Windows.Forms.TextBox DriverCardNumber_bintTextBox;
private NumericTextBox DriverLicenceNumber_intNumericTextBox;
private System.Windows.Forms.TextBox DriverLastName_nvcTextBox;
private System.Windows.Forms.Label DriverFirstName_nvcLabel;
private System.Windows.Forms.TextBox DriverFirstName_nvcTextBox;
private System.Windows.Forms.Label DriverNationalCode_bintLabel;
private System.Windows.Forms.Label DriverLastName_nvcLabel;
private System.Windows.Forms.Label DriverLicenceNumber_intLabel;
private System.Windows.Forms.GroupBox CompanygroupBox;
private System.Windows.Forms.ComboBox CompanyID_intComboBox;
private System.Windows.Forms.Label CompanyCode_nvcLabel;
private System.Windows.Forms.TextBox CompanyCode_nvcTextBox;
private System.Windows.Forms.Label CompanyID_intLabel;
private System.Windows.Forms.Button CarID_intNewButton;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Button CompanyID_intNewButton;
private System.Windows.Forms.Button OtherOffender_nvcNewButton;
private System.Windows.Forms.Button InfractionTypeNewButton;
private System.Windows.Forms.ComboBox PlateCityID_intComboBox;
private System.Windows.Forms.Button PlateCity_nvcBottun;
private System.Windows.Forms.GroupBox TrafficgroupBox;
private System.Windows.Forms.CheckBox Exit_bitcheckBox;
private System.Windows.Forms.CheckBox TurnAccept_bitcheckBox;
private System.Windows.Forms.CheckBox TurnSave_bitcheckBox;
private System.Windows.Forms.CheckBox TrafficcheckBox;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox CommentControl_nvctextBox;
        
    }
}
