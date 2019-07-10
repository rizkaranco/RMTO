namespace HPS.Present.LadeAssignment
{
    partial class LadeAssignmentRepeaterForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colOrder_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLaderType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompany_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGood_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBoxingType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortageFee_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight_flt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarCount_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLadBillCount_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainedCount_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("B Zar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("B Mitra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.ColumnHeadersHeight = 83;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrder_int,
            this.colLaderType_nvc,
            this.colCompany_nvc,
            this.colCity_nvc,
            this.colGood_nvc,
            this.colBoxingType_nvc,
            this.colPortageFee_dec,
            this.colComment_nvc,
            this.colWeight_flt,
            this.colCarCount_int,
            this.colLadBillCount_int,
            this.colRemainedCount_int});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Mitra", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 746);
            this.dataGridView1.TabIndex = 0;
            // 
            // colOrder_int
            // 
            this.colOrder_int.DataPropertyName = "Order_int";
            this.colOrder_int.HeaderText = "ردیف";
            this.colOrder_int.Name = "colOrder_int";
            this.colOrder_int.ReadOnly = true;
            this.colOrder_int.Visible = false;
            this.colOrder_int.Width = 50;
            // 
            // colLaderType_nvc
            // 
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colLaderType_nvc.DefaultCellStyle = dataGridViewCellStyle27;
            this.colLaderType_nvc.HeaderText = "نوع بارگیر";
            this.colLaderType_nvc.Name = "colLaderType_nvc";
            this.colLaderType_nvc.ReadOnly = true;
            this.colLaderType_nvc.Width = 120;
            // 
            // colCompany_nvc
            // 
            this.colCompany_nvc.DataPropertyName = "Company_nvc";
            this.colCompany_nvc.HeaderText = "شرکت";
            this.colCompany_nvc.Name = "colCompany_nvc";
            this.colCompany_nvc.ReadOnly = true;
            this.colCompany_nvc.Width = 80;
            // 
            // colCity_nvc
            // 
            this.colCity_nvc.HeaderText = "مقصد";
            this.colCity_nvc.Name = "colCity_nvc";
            this.colCity_nvc.ReadOnly = true;
            // 
            // colGood_nvc
            // 
            this.colGood_nvc.HeaderText = "کالا";
            this.colGood_nvc.Name = "colGood_nvc";
            this.colGood_nvc.ReadOnly = true;
            // 
            // colBoxingType_nvc
            // 
            this.colBoxingType_nvc.DataPropertyName = "BoxingType_nvc";
            this.colBoxingType_nvc.HeaderText = "بسته بندی";
            this.colBoxingType_nvc.Name = "colBoxingType_nvc";
            this.colBoxingType_nvc.ReadOnly = true;
            this.colBoxingType_nvc.Width = 50;
            // 
            // colPortageFee_dec
            // 
            this.colPortageFee_dec.HeaderText = "نرخ حمل";
            this.colPortageFee_dec.Name = "colPortageFee_dec";
            this.colPortageFee_dec.ReadOnly = true;
            this.colPortageFee_dec.Width = 70;
            // 
            // colComment_nvc
            // 
            this.colComment_nvc.HeaderText = "توضیحات";
            this.colComment_nvc.Name = "colComment_nvc";
            this.colComment_nvc.ReadOnly = true;
            this.colComment_nvc.Visible = false;
            this.colComment_nvc.Width = 300;
            // 
            // colWeight_flt
            // 
            dataGridViewCellStyle28.Format = "N0";
            this.colWeight_flt.DefaultCellStyle = dataGridViewCellStyle28;
            this.colWeight_flt.HeaderText = "وزن تا";
            this.colWeight_flt.Name = "colWeight_flt";
            this.colWeight_flt.ReadOnly = true;
            this.colWeight_flt.Visible = false;
            this.colWeight_flt.Width = 90;
            // 
            // colCarCount_int
            // 
            this.colCarCount_int.DataPropertyName = "CarCount_int";
            this.colCarCount_int.HeaderText = "تعداد";
            this.colCarCount_int.Name = "colCarCount_int";
            this.colCarCount_int.ReadOnly = true;
            this.colCarCount_int.Width = 50;
            // 
            // colLadBillCount_int
            // 
            this.colLadBillCount_int.DataPropertyName = "LadBillCount_int";
            this.colLadBillCount_int.HeaderText = "مجوز گرفته";
            this.colLadBillCount_int.Name = "colLadBillCount_int";
            this.colLadBillCount_int.ReadOnly = true;
            this.colLadBillCount_int.Width = 70;
            // 
            // colRemainedCount_int
            // 
            this.colRemainedCount_int.DataPropertyName = "Remained_int";
            this.colRemainedCount_int.HeaderText = "مانده";
            this.colRemainedCount_int.Name = "colRemainedCount_int";
            this.colRemainedCount_int.ReadOnly = true;
            this.colRemainedCount_int.Width = 80;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 499);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1036, 247);
            this.webBrowser1.TabIndex = 2;
            // 
            // LadeAssignmentRepeaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 746);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Mitra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LadeAssignmentRepeaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بارهای اطلاع رسانی شده";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadeAssignmentRepeaterForm_FormClosing);
            this.Load += new System.EventHandler(this.LadeAssignmentRepeaterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrder_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaderType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGood_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBoxingType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortageFee_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight_flt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarCount_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLadBillCount_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemainedCount_int;
        private System.Windows.Forms.WebBrowser webBrowser1;


    }
}