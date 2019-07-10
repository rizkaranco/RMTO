using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present
{
    partial class CancelLadBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelLadBillForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LadBillCreditToolStrip = new System.Windows.Forms.ToolStrip();
            this.CancelationButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.CurrentLadBillButton = new System.Windows.Forms.ToolStripButton();
            this.AllLadeBilltoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LadBillWithTrafficGridView = new System.Windows.Forms.DataGridView();
            this.LadBillCreditCancelCommentGridView = new System.Windows.Forms.DataGridView();
            this.colLadBillCreditCancelCommentID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCreditCancelID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCancelCommentID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadbillCancelComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberPlate_nvcTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Trafficnumberlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LadBillCreditTextBox = new NumericTextBox();
            this.AcceptedTurnNumberTextBox = new NumericTextBox();
            this.SerialPlate_nvcTextBox = new NumericTextBox();
            this.TrafficNumberTextBox = new NumericTextBox();
            this.LadeAssignmentIDTextBox = new NumericTextBox();
            this.LadeAssignmentID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrafficID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanceled_bit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLADate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLATime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadBillCreditID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrafficNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcceptedTurnNumber_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialPlate_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderTypeID_intLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverCardNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoodID_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID_intCompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodID_intGood_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortageFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortPlaceID_intPortPlaces_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCityID_intCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanceledUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadBillCreditToolStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadBillWithTrafficGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LadBillCreditCancelCommentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LadBillCreditToolStrip
            // 
            this.LadBillCreditToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.LadBillCreditToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelationButton,
            this.RefreshButton,
            this.CurrentLadBillButton,
            this.AllLadeBilltoolStripButton});
            this.LadBillCreditToolStrip.Location = new System.Drawing.Point(0, 0);
            this.LadBillCreditToolStrip.Name = "LadBillCreditToolStrip";
            this.LadBillCreditToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.LadBillCreditToolStrip.Size = new System.Drawing.Size(943, 31);
            this.LadBillCreditToolStrip.TabIndex = 6;
            // 
            // CancelationButton
            // 
            this.CancelationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelationButton.Image = global::HPS.Properties.Resources.Cancel;
            this.CancelationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelationButton.Name = "CancelationButton";
            this.CancelationButton.Size = new System.Drawing.Size(28, 28);
            this.CancelationButton.Text = "ابطال مجوز بارگیری";
            this.CancelationButton.Click += new System.EventHandler(this.CancelationButton_Click);
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
            // CurrentLadBillButton
            // 
            this.CurrentLadBillButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurrentLadBillButton.Image = global::HPS.Properties.Resources.today;
            this.CurrentLadBillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurrentLadBillButton.Name = "CurrentLadBillButton";
            this.CurrentLadBillButton.Size = new System.Drawing.Size(28, 28);
            this.CurrentLadBillButton.Text = "مجوز های روز جاری";
            this.CurrentLadBillButton.Click += new System.EventHandler(this.CurrentLadBillButton_Click);
            // 
            // AllLadeBilltoolStripButton
            // 
            this.AllLadeBilltoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AllLadeBilltoolStripButton.Image = global::HPS.Properties.Resources.AllRecords;
            this.AllLadeBilltoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllLadeBilltoolStripButton.Name = "AllLadeBilltoolStripButton";
            this.AllLadeBilltoolStripButton.Size = new System.Drawing.Size(28, 28);
            this.AllLadeBilltoolStripButton.Text = "نمایش تمام مجوزهای داده شده";
            this.AllLadeBilltoolStripButton.Click += new System.EventHandler(this.AllLadeBilltoolStripButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 88);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LadBillWithTrafficGridView);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LadBillCreditCancelCommentGridView);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(943, 434);
            this.splitContainer1.SplitterDistance = 767;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 5;
            // 
            // LadBillWithTrafficGridView
            // 
            this.LadBillWithTrafficGridView.AllowUserToAddRows = false;
            this.LadBillWithTrafficGridView.AllowUserToDeleteRows = false;
            this.LadBillWithTrafficGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.LadBillWithTrafficGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LadBillWithTrafficGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LadBillWithTrafficGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadBillWithTrafficGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LadeAssignmentID_bint,
            this.ServiceID_int,
            this.colTrafficID_bint,
            this.colCanceled_bit,
            this.colLADate,
            this.colLATime,
            this.colLadBillDate,
            this.colLadBillTime,
            this.LadBillCreditID_int,
            this.TrafficNumber_bint,
            this.colAcceptedTurnNumber_bint,
            this.colNumberPlate_nvc,
            this.colPlateCity_nvc,
            this.colSerialPlate_nvc,
            this.colLaderTypeID_intLaderType_nvc,
            this.colCarCardNumber_nvc,
            this.colDriverName,
            this.colDriverCardNumber_nvc,
            this.colGoodID_int,
            this.colCompanyID_intCompany_nvc,
            this.GoodID_intGood_nvc,
            this.colPortageFee_dec,
            this.colPortPlaceID_intPortPlaces_nvc,
            this.colCityID_intCity_nvc,
            this.LadeUser,
            this.colUserName_nvc,
            this.CanceledUserName});
            this.LadBillWithTrafficGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadBillWithTrafficGridView.Location = new System.Drawing.Point(0, 0);
            this.LadBillWithTrafficGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadBillWithTrafficGridView.MultiSelect = false;
            this.LadBillWithTrafficGridView.Name = "LadBillWithTrafficGridView";
            this.LadBillWithTrafficGridView.ReadOnly = true;
            this.LadBillWithTrafficGridView.RowHeadersVisible = false;
            this.LadBillWithTrafficGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LadBillWithTrafficGridView.Size = new System.Drawing.Size(767, 434);
            this.LadBillWithTrafficGridView.TabIndex = 0;
            this.LadBillWithTrafficGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LadBillWithTrafficGridView_CellFormatting);
            this.LadBillWithTrafficGridView.SelectionChanged += new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);
            // 
            // LadBillCreditCancelCommentGridView
            // 
            this.LadBillCreditCancelCommentGridView.AllowUserToAddRows = false;
            this.LadBillCreditCancelCommentGridView.AllowUserToDeleteRows = false;
            this.LadBillCreditCancelCommentGridView.AllowUserToResizeRows = false;
            this.LadBillCreditCancelCommentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.LadBillCreditCancelCommentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LadBillCreditCancelCommentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLadBillCreditCancelCommentID_int,
            this.colLadBillCreditCancelID_int,
            this.colLadBillCancelCommentID_int,
            this.colLadbillCancelComment_nvc,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.LadBillCreditCancelCommentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LadBillCreditCancelCommentGridView.Location = new System.Drawing.Point(0, 0);
            this.LadBillCreditCancelCommentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LadBillCreditCancelCommentGridView.MultiSelect = false;
            this.LadBillCreditCancelCommentGridView.Name = "LadBillCreditCancelCommentGridView";
            this.LadBillCreditCancelCommentGridView.ReadOnly = true;
            this.LadBillCreditCancelCommentGridView.RowHeadersVisible = false;
            this.LadBillCreditCancelCommentGridView.Size = new System.Drawing.Size(175, 434);
            this.LadBillCreditCancelCommentGridView.TabIndex = 0;
            // 
            // colLadBillCreditCancelCommentID_int
            // 
            this.colLadBillCreditCancelCommentID_int.DataPropertyName = "LadBillCreditCancelCommentID_int";
            this.colLadBillCreditCancelCommentID_int.HeaderText = "شناسه توضیحات ابطال های مجوز";
            this.colLadBillCreditCancelCommentID_int.Name = "colLadBillCreditCancelCommentID_int";
            this.colLadBillCreditCancelCommentID_int.ReadOnly = true;
            this.colLadBillCreditCancelCommentID_int.Visible = false;
            // 
            // colLadBillCreditCancelID_int
            // 
            this.colLadBillCreditCancelID_int.DataPropertyName = "LadBillCreditCancelID_int";
            this.colLadBillCreditCancelID_int.HeaderText = "ابطال مجوز";
            this.colLadBillCreditCancelID_int.Name = "colLadBillCreditCancelID_int";
            this.colLadBillCreditCancelID_int.ReadOnly = true;
            this.colLadBillCreditCancelID_int.Visible = false;
            // 
            // colLadBillCancelCommentID_int
            // 
            this.colLadBillCancelCommentID_int.DataPropertyName = "LadBillCancelCommentID_intLadbillCancelComment_nvc";
            this.colLadBillCancelCommentID_int.HeaderText = "توضیحات ابطال مجوز";
            this.colLadBillCancelCommentID_int.Name = "colLadBillCancelCommentID_int";
            this.colLadBillCancelCommentID_int.ReadOnly = true;
            this.colLadBillCancelCommentID_int.Width = 200;
            // 
            // colLadbillCancelComment_nvc
            // 
            this.colLadbillCancelComment_nvc.DataPropertyName = "LadbillCancelComment_nvc";
            this.colLadbillCancelComment_nvc.HeaderText = "توضیحات ابطال مجوز";
            this.colLadbillCancelComment_nvc.Name = "colLadbillCancelComment_nvc";
            this.colLadbillCancelComment_nvc.ReadOnly = true;
            this.colLadbillCancelComment_nvc.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date_nvc";
            this.dataGridViewTextBoxColumn1.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Time_nvc";
            this.dataGridViewTextBoxColumn2.HeaderText = "ساعت";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserName_nvcUserName_nvc";
            this.dataGridViewTextBoxColumn3.HeaderText = "کاربر";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "شماره نوبت تأیید شده";
            // 
            // NumberPlate_nvcTextBox
            // 
            this.NumberPlate_nvcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPlate_nvcTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumberPlate_nvcTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumberPlate_nvcTextBox.Location = new System.Drawing.Point(475, 48);
            this.NumberPlate_nvcTextBox.MaxLength = 6;
            this.NumberPlate_nvcTextBox.Name = "NumberPlate_nvcTextBox";
            this.NumberPlate_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberPlate_nvcTextBox.Size = new System.Drawing.Size(94, 30);
            this.NumberPlate_nvcTextBox.TabIndex = 2;
            this.NumberPlate_nvcTextBox.Tag = "شماره پلاك";
            this.NumberPlate_nvcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(403, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 56;
            this.label15.Text = "شماره پلاك";
            // 
            // Trafficnumberlabel
            // 
            this.Trafficnumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trafficnumberlabel.AutoSize = true;
            this.Trafficnumberlabel.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Trafficnumberlabel.Location = new System.Drawing.Point(608, 52);
            this.Trafficnumberlabel.Name = "Trafficnumberlabel";
            this.Trafficnumberlabel.Size = new System.Drawing.Size(71, 23);
            this.Trafficnumberlabel.TabIndex = 55;
            this.Trafficnumberlabel.Text = "شماره قبض";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(777, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "شماره بار";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "شماره مجوز";
            // 
            // LadBillCreditTextBox
            // 
            this.LadBillCreditTextBox.AllowNegative = true;
            this.LadBillCreditTextBox.DigitsInGroup = 0;
            this.LadBillCreditTextBox.Flags = 0;
            this.LadBillCreditTextBox.Location = new System.Drawing.Point(81, 48);
            this.LadBillCreditTextBox.MaxDecimalPlaces = 4;
            this.LadBillCreditTextBox.MaxWholeDigits = 9;
            this.LadBillCreditTextBox.Name = "LadBillCreditTextBox";
            this.LadBillCreditTextBox.Prefix = "";
          //  this.LadBillCreditTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.LadBillCreditTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.LadBillCreditTextBox.Size = new System.Drawing.Size(92, 30);
            this.LadBillCreditTextBox.TabIndex = 0;
            this.LadBillCreditTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadBillCreditTextBox_KeyDown);
            // 
            // AcceptedTurnNumberTextBox
            // 
            this.AcceptedTurnNumberTextBox.AllowNegative = true;
            this.AcceptedTurnNumberTextBox.DigitsInGroup = 0;
            this.AcceptedTurnNumberTextBox.Flags = 0;
            this.AcceptedTurnNumberTextBox.Location = new System.Drawing.Point(305, 48);
            this.AcceptedTurnNumberTextBox.MaxDecimalPlaces = 4;
            this.AcceptedTurnNumberTextBox.MaxWholeDigits = 9;
            this.AcceptedTurnNumberTextBox.Name = "AcceptedTurnNumberTextBox";
            this.AcceptedTurnNumberTextBox.Prefix = "";
          //  this.AcceptedTurnNumberTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.AcceptedTurnNumberTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.AcceptedTurnNumberTextBox.Size = new System.Drawing.Size(92, 30);
            this.AcceptedTurnNumberTextBox.TabIndex = 1;
            this.AcceptedTurnNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AcceptedTurnNumberTextBox_KeyDown);
            // 
            // SerialPlate_nvcTextBox
            // 
            this.SerialPlate_nvcTextBox.AllowNegative = true;
            this.SerialPlate_nvcTextBox.DigitsInGroup = 0;
            this.SerialPlate_nvcTextBox.Flags = 0;
            this.SerialPlate_nvcTextBox.Location = new System.Drawing.Point(571, 48);
            this.SerialPlate_nvcTextBox.MaxDecimalPlaces = 4;
            this.SerialPlate_nvcTextBox.MaxWholeDigits = 9;
            this.SerialPlate_nvcTextBox.Name = "SerialPlate_nvcTextBox";
            this.SerialPlate_nvcTextBox.Prefix = "";
           // this.SerialPlate_nvcTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.SerialPlate_nvcTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.SerialPlate_nvcTextBox.Size = new System.Drawing.Size(31, 30);
            this.SerialPlate_nvcTextBox.TabIndex = 3;
            this.SerialPlate_nvcTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPlate_nvcTextBox_KeyDown);
            // 
            // TrafficNumberTextBox
            // 
            this.TrafficNumberTextBox.AllowNegative = true;
            this.TrafficNumberTextBox.DigitsInGroup = 0;
            this.TrafficNumberTextBox.Flags = 0;
            this.TrafficNumberTextBox.Location = new System.Drawing.Point(679, 45);
            this.TrafficNumberTextBox.MaxDecimalPlaces = 4;
            this.TrafficNumberTextBox.MaxWholeDigits = 9;
            this.TrafficNumberTextBox.Name = "TrafficNumberTextBox";
            this.TrafficNumberTextBox.Prefix = "";
           // this.TrafficNumberTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.TrafficNumberTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.TrafficNumberTextBox.Size = new System.Drawing.Size(92, 30);
            this.TrafficNumberTextBox.TabIndex = 4;
            this.TrafficNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrafficNumberTextBox_KeyDown);
            // 
            // LadeAssignmentIDTextBox
            // 
            this.LadeAssignmentIDTextBox.AllowNegative = true;
            this.LadeAssignmentIDTextBox.DigitsInGroup = 0;
            this.LadeAssignmentIDTextBox.Flags = 0;
            this.LadeAssignmentIDTextBox.Location = new System.Drawing.Point(836, 45);
            this.LadeAssignmentIDTextBox.MaxDecimalPlaces = 4;
            this.LadeAssignmentIDTextBox.MaxWholeDigits = 9;
            this.LadeAssignmentIDTextBox.Name = "LadeAssignmentIDTextBox";
            this.LadeAssignmentIDTextBox.Prefix = "";
          //  this.LadeAssignmentIDTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
          //  this.LadeAssignmentIDTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.LadeAssignmentIDTextBox.Size = new System.Drawing.Size(92, 30);
            this.LadeAssignmentIDTextBox.TabIndex = 5;
            this.LadeAssignmentIDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LadeAssignmentIDTextBox_KeyDown);
            // 
            // LadeAssignmentID_bint
            // 
            this.LadeAssignmentID_bint.DataPropertyName = "LadeAssignmentID_bint";
            this.LadeAssignmentID_bint.HeaderText = "شماره بار";
            this.LadeAssignmentID_bint.Name = "LadeAssignmentID_bint";
            this.LadeAssignmentID_bint.ReadOnly = true;
            // 
            // ServiceID_int
            // 
            this.ServiceID_int.DataPropertyName = "ServiceID_int";
            this.ServiceID_int.HeaderText = "شناسه نوع مراجعه";
            this.ServiceID_int.Name = "ServiceID_int";
            this.ServiceID_int.ReadOnly = true;
            this.ServiceID_int.Visible = false;
            // 
            // colTrafficID_bint
            // 
            this.colTrafficID_bint.DataPropertyName = "TrafficID_bint";
            this.colTrafficID_bint.HeaderText = "شناسه تردد";
            this.colTrafficID_bint.Name = "colTrafficID_bint";
            this.colTrafficID_bint.ReadOnly = true;
            this.colTrafficID_bint.Visible = false;
            // 
            // colCanceled_bit
            // 
            this.colCanceled_bit.DataPropertyName = "Canceled_bit";
            this.colCanceled_bit.HeaderText = "ابطال مجوز";
            this.colCanceled_bit.Name = "colCanceled_bit";
            this.colCanceled_bit.ReadOnly = true;
            this.colCanceled_bit.Visible = false;
            // 
            // colLADate
            // 
            this.colLADate.DataPropertyName = "LADate_nvc";
            this.colLADate.HeaderText = "تاریخ ثبت بار";
            this.colLADate.Name = "colLADate";
            this.colLADate.ReadOnly = true;
            this.colLADate.Width = 110;
            // 
            // colLATime
            // 
            this.colLATime.DataPropertyName = "LATime_nvc";
            this.colLATime.HeaderText = "ساعت ثبت بار";
            this.colLATime.Name = "colLATime";
            this.colLATime.ReadOnly = true;
            this.colLATime.Width = 110;
            // 
            // colLadBillDate
            // 
            this.colLadBillDate.DataPropertyName = "LadBillDate_nvc";
            this.colLadBillDate.HeaderText = "تاریخ ";
            this.colLadBillDate.Name = "colLadBillDate";
            this.colLadBillDate.ReadOnly = true;
            this.colLadBillDate.Width = 90;
            // 
            // colLadBillTime
            // 
            this.colLadBillTime.DataPropertyName = "LadBillTime_nvc";
            this.colLadBillTime.HeaderText = "ساعت";
            this.colLadBillTime.Name = "colLadBillTime";
            this.colLadBillTime.ReadOnly = true;
            this.colLadBillTime.Width = 70;
            // 
            // LadBillCreditID_int
            // 
            this.LadBillCreditID_int.DataPropertyName = "LadBillCreditID_int";
            this.LadBillCreditID_int.HeaderText = "شماره مجوز";
            this.LadBillCreditID_int.Name = "LadBillCreditID_int";
            this.LadBillCreditID_int.ReadOnly = true;
            // 
            // TrafficNumber_bint
            // 
            this.TrafficNumber_bint.DataPropertyName = "TrafficNumber_bint";
            this.TrafficNumber_bint.HeaderText = "شماره قبض";
            this.TrafficNumber_bint.Name = "TrafficNumber_bint";
            this.TrafficNumber_bint.ReadOnly = true;
            // 
            // colAcceptedTurnNumber_bint
            // 
            this.colAcceptedTurnNumber_bint.DataPropertyName = "AcceptedTurnNumber_bint";
            this.colAcceptedTurnNumber_bint.HeaderText = "نوبت تأییدی";
            this.colAcceptedTurnNumber_bint.Name = "colAcceptedTurnNumber_bint";
            this.colAcceptedTurnNumber_bint.ReadOnly = true;
            // 
            // colNumberPlate_nvc
            // 
            this.colNumberPlate_nvc.DataPropertyName = "NumberPlate_nvc";
            this.colNumberPlate_nvc.HeaderText = "شماره پلاک";
            this.colNumberPlate_nvc.Name = "colNumberPlate_nvc";
            this.colNumberPlate_nvc.ReadOnly = true;
            this.colNumberPlate_nvc.Width = 110;
            // 
            // colPlateCity_nvc
            // 
            this.colPlateCity_nvc.DataPropertyName = "PlateCity_nvc";
            this.colPlateCity_nvc.HeaderText = "شهرشماره گذاری";
            this.colPlateCity_nvc.Name = "colPlateCity_nvc";
            this.colPlateCity_nvc.ReadOnly = true;
            this.colPlateCity_nvc.Width = 130;
            // 
            // colSerialPlate_nvc
            // 
            this.colSerialPlate_nvc.DataPropertyName = "SerialPlate_nvc";
            this.colSerialPlate_nvc.HeaderText = "سریال";
            this.colSerialPlate_nvc.Name = "colSerialPlate_nvc";
            this.colSerialPlate_nvc.ReadOnly = true;
            // 
            // colLaderTypeID_intLaderType_nvc
            // 
            this.colLaderTypeID_intLaderType_nvc.DataPropertyName = "LaderTypeID_intLaderType_nvc";
            this.colLaderTypeID_intLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderTypeID_intLaderType_nvc.Name = "colLaderTypeID_intLaderType_nvc";
            this.colLaderTypeID_intLaderType_nvc.ReadOnly = true;
            // 
            // colCarCardNumber_nvc
            // 
            this.colCarCardNumber_nvc.DataPropertyName = "CarCardNumber_nvc";
            this.colCarCardNumber_nvc.HeaderText = "ش.ک.کامیون";
            this.colCarCardNumber_nvc.Name = "colCarCardNumber_nvc";
            this.colCarCardNumber_nvc.ReadOnly = true;
            this.colCarCardNumber_nvc.Width = 110;
            // 
            // colDriverName
            // 
            this.colDriverName.DataPropertyName = "DriverName";
            this.colDriverName.HeaderText = "نام راننده";
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.ReadOnly = true;
            // 
            // colDriverCardNumber_nvc
            // 
            this.colDriverCardNumber_nvc.DataPropertyName = "DriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.HeaderText = "ش.ک.راننده";
            this.colDriverCardNumber_nvc.Name = "colDriverCardNumber_nvc";
            this.colDriverCardNumber_nvc.ReadOnly = true;
            this.colDriverCardNumber_nvc.Width = 110;
            // 
            // colGoodID_int
            // 
            this.colGoodID_int.DataPropertyName = "GoodID_intGood_nvc";
            this.colGoodID_int.HeaderText = "کالا";
            this.colGoodID_int.Name = "colGoodID_int";
            this.colGoodID_int.ReadOnly = true;
            this.colGoodID_int.Visible = false;
            this.colGoodID_int.Width = 53;
            // 
            // colCompanyID_intCompany_nvc
            // 
            this.colCompanyID_intCompany_nvc.DataPropertyName = "CompanyID_intCompany_nvc";
            this.colCompanyID_intCompany_nvc.HeaderText = "شرکت";
            this.colCompanyID_intCompany_nvc.Name = "colCompanyID_intCompany_nvc";
            this.colCompanyID_intCompany_nvc.ReadOnly = true;
            // 
            // GoodID_intGood_nvc
            // 
            this.GoodID_intGood_nvc.DataPropertyName = "GoodID_intGood_nvc";
            this.GoodID_intGood_nvc.HeaderText = "کالا";
            this.GoodID_intGood_nvc.Name = "GoodID_intGood_nvc";
            this.GoodID_intGood_nvc.ReadOnly = true;
            this.GoodID_intGood_nvc.Width = 70;
            // 
            // colPortageFee_dec
            // 
            this.colPortageFee_dec.DataPropertyName = "PortageFee_dec";
            this.colPortageFee_dec.HeaderText = "نرخ حمل";
            this.colPortageFee_dec.Name = "colPortageFee_dec";
            this.colPortageFee_dec.ReadOnly = true;
            // 
            // colPortPlaceID_intPortPlaces_nvc
            // 
            this.colPortPlaceID_intPortPlaces_nvc.DataPropertyName = "PortPlaceID_intPortPlaces_nvc";
            this.colPortPlaceID_intPortPlaces_nvc.HeaderText = "محل بارگیری";
            this.colPortPlaceID_intPortPlaces_nvc.Name = "colPortPlaceID_intPortPlaces_nvc";
            this.colPortPlaceID_intPortPlaces_nvc.ReadOnly = true;
            this.colPortPlaceID_intPortPlaces_nvc.Width = 107;
            // 
            // colCityID_intCity_nvc
            // 
            this.colCityID_intCity_nvc.DataPropertyName = "CityID_intCity_nvc";
            this.colCityID_intCity_nvc.HeaderText = "شهر مقصد";
            this.colCityID_intCity_nvc.Name = "colCityID_intCity_nvc";
            this.colCityID_intCity_nvc.ReadOnly = true;
            // 
            // LadeUser
            // 
            this.LadeUser.DataPropertyName = "LadeUser";
            this.LadeUser.HeaderText = "کاربر ثبت بار";
            this.LadeUser.Name = "LadeUser";
            this.LadeUser.ReadOnly = true;
            // 
            // colUserName_nvc
            // 
            this.colUserName_nvc.DataPropertyName = "LBUser";
            this.colUserName_nvc.HeaderText = "کاربر مجوز";
            this.colUserName_nvc.Name = "colUserName_nvc";
            this.colUserName_nvc.ReadOnly = true;
            // 
            // CanceledUserName
            // 
            this.CanceledUserName.DataPropertyName = "CanceledUserName";
            this.CanceledUserName.HeaderText = "کاربر ابطال مجوز";
            this.CanceledUserName.Name = "CanceledUserName";
            this.CanceledUserName.ReadOnly = true;
            this.CanceledUserName.Width = 130;
            // 
            // CancelLadBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 522);
            this.Controls.Add(this.SerialPlate_nvcTextBox);
            this.Controls.Add(this.LadeAssignmentIDTextBox);
            this.Controls.Add(this.TrafficNumberTextBox);
            this.Controls.Add(this.AcceptedTurnNumberTextBox);
            this.Controls.Add(this.LadBillCreditTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumberPlate_nvcTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Trafficnumberlabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.LadBillCreditToolStrip);
            this.Margin = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Name = "CancelLadBillForm";
            this.Text = "لیست مجوزها برای ابطال";
            this.Load += new System.EventHandler(this.CancelLadBillForm_Load);
            this.LadBillCreditToolStrip.ResumeLayout(false);
            this.LadBillCreditToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LadBillWithTrafficGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LadBillCreditCancelCommentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip LadBillCreditToolStrip;
        private System.Windows.Forms.ToolStripButton CancelationButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton AllLadeBilltoolStripButton;
        private System.Windows.Forms.DataGridView LadBillWithTrafficGridView;
        private System.Windows.Forms.DataGridView LadBillCreditCancelCommentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCreditCancelCommentID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCreditCancelID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCancelCommentID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadbillCancelComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberPlate_nvcTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label Trafficnumberlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton CurrentLadBillButton;
        private System.Windows.Forms.Label label1;
        private NumericTextBox LadBillCreditTextBox;
        private NumericTextBox AcceptedTurnNumberTextBox;
        private NumericTextBox SerialPlate_nvcTextBox;
        private NumericTextBox TrafficNumberTextBox;
        private NumericTextBox LadeAssignmentIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadeAssignmentID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrafficID_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanceled_bit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLADate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLATime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadBillCreditID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrafficNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcceptedTurnNumber_bint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialPlate_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderTypeID_intLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverCardNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoodID_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID_intCompany_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodID_intGood_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortageFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortPlaceID_intPortPlaces_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCityID_intCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanceledUserName;
    }
}