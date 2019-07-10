namespace HPS.Reports.Forms
{
    partial class TrafficPicturesForm
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
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.TrafficPicturesToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExportExelButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TrafficPicturesGridView = new System.Windows.Forms.DataGridView();
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.DefaulCheckBox = new Janus.Windows.EditControls.UICheckBox();
            this.TimeGroupBox = new System.Windows.Forms.GroupBox();
            this.FromTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RefreshHourbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ToDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatefaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowButton = new Janus.Windows.EditControls.UIButton();
            this.colplateNumber_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colplateSerial_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colplateColor_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldate_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltime_vc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlateType_nvc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colinOutID_bint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            this.TrafficPicturesToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficPicturesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            this.TimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("b9b10a8c-3830-4599-9fa8-6881a2b770b3");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("b9b10a8c-3830-4599-9fa8-6881a2b770b3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(170, 362), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("10f011f8-639e-4d14-94a8-e004c6881aff"), new System.Drawing.Point(813, 407), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // TrafficPicturesToolStrip
            // 
            this.TrafficPicturesToolStrip.AutoSize = false;
            this.TrafficPicturesToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TrafficPicturesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportExelButton});
            this.TrafficPicturesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TrafficPicturesToolStrip.Name = "TrafficPicturesToolStrip";
            this.TrafficPicturesToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TrafficPicturesToolStrip.Size = new System.Drawing.Size(979, 30);
            this.TrafficPicturesToolStrip.TabIndex = 92;
            // 
            // ExportExelButton
            // 
            this.ExportExelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportExelButton.Image = global::HPS.Properties.Resources.Excel;
            this.ExportExelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportExelButton.Name = "ExportExelButton";
            this.ExportExelButton.Size = new System.Drawing.Size(28, 23);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.Location = new System.Drawing.Point(0, 177);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(164, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 93;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "عکس";
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // TrafficPicturesGridView
            // 
            this.TrafficPicturesGridView.AllowUserToAddRows = false;
            this.TrafficPicturesGridView.AllowUserToDeleteRows = false;
            this.TrafficPicturesGridView.AllowUserToResizeRows = false;
            this.TrafficPicturesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(173)))), ((int)(((byte)(219)))));
            this.TrafficPicturesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrafficPicturesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colplateNumber_nvc,
            this.colplateSerial_vc,
            this.colplateColor_nvc,
            this.coldate_vc,
            this.coltime_vc,
            this.colPlateType_nvc,
            this.colinOutID_bint});
            this.TrafficPicturesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafficPicturesGridView.Location = new System.Drawing.Point(173, 33);
            this.TrafficPicturesGridView.MultiSelect = false;
            this.TrafficPicturesGridView.Name = "TrafficPicturesGridView";
            this.TrafficPicturesGridView.ReadOnly = true;
            this.TrafficPicturesGridView.RowHeadersVisible = false;
            this.TrafficPicturesGridView.Size = new System.Drawing.Size(803, 362);
            this.TrafficPicturesGridView.TabIndex = 96;
            this.TrafficPicturesGridView.SelectionChanged += new System.EventHandler(this.TrafficPicturesGridView_SelectionChanged);
            // 
            // uiPanel0
            // 
            this.uiPanel0.CaptionVisible = Janus.Windows.UI.InheritableBoolean.True;
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 33);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(170, 362);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.ShowButton);
            this.uiPanel0Container.Controls.Add(this.DefaulCheckBox);
            this.uiPanel0Container.Controls.Add(this.TimeGroupBox);
            this.uiPanel0Container.Controls.Add(this.ToDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.FromDatefaDatePicker);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.pictureBox);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 24);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(164, 337);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // DefaulCheckBox
            // 
            this.DefaulCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DefaulCheckBox.Location = new System.Drawing.Point(128, 54);
            this.DefaulCheckBox.Name = "DefaulCheckBox";
            this.DefaulCheckBox.Size = new System.Drawing.Size(17, 23);
            this.DefaulCheckBox.TabIndex = 98;
            this.DefaulCheckBox.ToolTipText = "ساعات بین 00:00:00 و 23:59:59";
            // 
            // TimeGroupBox
            // 
            this.TimeGroupBox.Controls.Add(this.FromTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.RefreshHourbutton);
            this.TimeGroupBox.Controls.Add(this.label3);
            this.TimeGroupBox.Controls.Add(this.ToTimeTextBox);
            this.TimeGroupBox.Controls.Add(this.label4);
            this.TimeGroupBox.Enabled = false;
            this.TimeGroupBox.Location = new System.Drawing.Point(3, 56);
            this.TimeGroupBox.Name = "TimeGroupBox";
            this.TimeGroupBox.Size = new System.Drawing.Size(155, 74);
            this.TimeGroupBox.TabIndex = 99;
            this.TimeGroupBox.TabStop = false;
            // 
            // FromTimeTextBox
            // 
            this.FromTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromTimeTextBox.Location = new System.Drawing.Point(34, 20);
            this.FromTimeTextBox.Mask = "00:00:00";
            this.FromTimeTextBox.Name = "FromTimeTextBox";
            this.FromTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromTimeTextBox.Size = new System.Drawing.Size(60, 22);
            this.FromTimeTextBox.TabIndex = 59;
            this.FromTimeTextBox.Text = "000000";
            // 
            // RefreshHourbutton
            // 
            this.RefreshHourbutton.Image = global::HPS.Properties.Resources.Refresh16;
            this.RefreshHourbutton.Location = new System.Drawing.Point(3, 40);
            this.RefreshHourbutton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshHourbutton.Name = "RefreshHourbutton";
            this.RefreshHourbutton.Size = new System.Drawing.Size(24, 24);
            this.RefreshHourbutton.TabIndex = 61;
            this.RefreshHourbutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(92, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 65;
            this.label3.Text = "از ساعت :";
            // 
            // ToTimeTextBox
            // 
            this.ToTimeTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToTimeTextBox.Location = new System.Drawing.Point(34, 43);
            this.ToTimeTextBox.Mask = "00:00:00";
            this.ToTimeTextBox.Name = "ToTimeTextBox";
            this.ToTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToTimeTextBox.Size = new System.Drawing.Size(60, 22);
            this.ToTimeTextBox.TabIndex = 60;
            this.ToTimeTextBox.Text = "235959";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(92, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 66;
            this.label4.Text = "تا ساعت :";
            // 
            // ToDatefaDatePicker
            // 
            this.ToDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ToDatefaDatePicker.Location = new System.Drawing.Point(3, 34);
            this.ToDatefaDatePicker.Name = "ToDatefaDatePicker";
            this.ToDatefaDatePicker.Size = new System.Drawing.Size(110, 20);
            this.ToDatefaDatePicker.TabIndex = 97;
            this.ToDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 94;
            this.label1.Text = "از تاریخ :";
            // 
            // FromDatefaDatePicker
            // 
            this.FromDatefaDatePicker.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDatefaDatePicker.Location = new System.Drawing.Point(2, 6);
            this.FromDatefaDatePicker.Name = "FromDatefaDatePicker";
            this.FromDatefaDatePicker.Size = new System.Drawing.Size(110, 20);
            this.FromDatefaDatePicker.TabIndex = 96;
            this.FromDatefaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(113, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "تا تاریخ :";
            // 
            // ShowButton
            // 
            this.ShowButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ShowButton.Location = new System.Drawing.Point(24, 135);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(2);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(108, 29);
            this.ShowButton.TabIndex = 100;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // colplateNumber_nvc
            // 
            this.colplateNumber_nvc.DataPropertyName = "plateNumber_nvc";
            this.colplateNumber_nvc.HeaderText = "شماره پلاک";
            this.colplateNumber_nvc.Name = "colplateNumber_nvc";
            this.colplateNumber_nvc.ReadOnly = true;
            this.colplateNumber_nvc.Width = 200;
            // 
            // colplateSerial_vc
            // 
            this.colplateSerial_vc.DataPropertyName = "plateSerial_vc";
            this.colplateSerial_vc.HeaderText = "سری پلاک";
            this.colplateSerial_vc.Name = "colplateSerial_vc";
            this.colplateSerial_vc.ReadOnly = true;
            this.colplateSerial_vc.Width = 150;
            // 
            // colplateColor_nvc
            // 
            this.colplateColor_nvc.DataPropertyName = "plateColor_nvc";
            this.colplateColor_nvc.HeaderText = "رنگ پلاک";
            this.colplateColor_nvc.Name = "colplateColor_nvc";
            this.colplateColor_nvc.ReadOnly = true;
            this.colplateColor_nvc.Width = 150;
            // 
            // coldate_vc
            // 
            this.coldate_vc.DataPropertyName = "date_vc";
            this.coldate_vc.HeaderText = "تاریخ";
            this.coldate_vc.Name = "coldate_vc";
            this.coldate_vc.ReadOnly = true;
            // 
            // coltime_vc
            // 
            this.coltime_vc.DataPropertyName = "time_vc";
            this.coltime_vc.HeaderText = "ساعت";
            this.coltime_vc.Name = "coltime_vc";
            this.coltime_vc.ReadOnly = true;
            // 
            // colPlateType_nvc
            // 
            this.colPlateType_nvc.DataPropertyName = "Gate_nvc";
            this.colPlateType_nvc.HeaderText = "نوع تردد";
            this.colPlateType_nvc.Name = "colPlateType_nvc";
            this.colPlateType_nvc.ReadOnly = true;
            // 
            // colinOutID_bint
            // 
            this.colinOutID_bint.DataPropertyName = "inOutID_bint";
            this.colinOutID_bint.HeaderText = "inOutID_bint";
            this.colinOutID_bint.Name = "colinOutID_bint";
            this.colinOutID_bint.ReadOnly = true;
            this.colinOutID_bint.Visible = false;
            // 
            // TrafficPicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 398);
            this.Controls.Add(this.TrafficPicturesGridView);
            this.Controls.Add(this.uiPanel0);
            this.Controls.Add(this.TrafficPicturesToolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TrafficPicturesForm";
            this.Text = "نمایش تردد ورود خروج";
            this.Load += new System.EventHandler(this.TrafficPicturesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            this.TrafficPicturesToolStrip.ResumeLayout(false);
            this.TrafficPicturesToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficPicturesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            this.TimeGroupBox.ResumeLayout(false);
            this.TimeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private System.Windows.Forms.ToolStrip TrafficPicturesToolStrip;
        private System.Windows.Forms.ToolStripButton ExportExelButton;
        internal System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView TrafficPicturesGridView;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.EditControls.UICheckBox DefaulCheckBox;
        private System.Windows.Forms.GroupBox TimeGroupBox;
        private System.Windows.Forms.MaskedTextBox FromTimeTextBox;
        private System.Windows.Forms.Button RefreshHourbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ToTimeTextBox;
        private System.Windows.Forms.Label label4;
        private FarsiLibrary.Win.Controls.FADatePicker ToDatefaDatePicker;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker FromDatefaDatePicker;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIButton ShowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colplateNumber_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colplateSerial_vc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colplateColor_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldate_vc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltime_vc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlateType_nvc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colinOutID_bint;
    }
}