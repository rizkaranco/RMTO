namespace HPS.Present.TurnManagement
{
    partial class CancelExpiredTurnForm
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
            Janus.Windows.GridEX.GridEXLayout LaderTypecheckedComboBox_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelExpiredTurnForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FromDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AutomaticCancelButton = new System.Windows.Forms.Button();
            this.LaderTypecheckedComboBox = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "از تاریخ";
            // 
            // FromDateTextBox
            // 
            this.FromDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDateTextBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FromDateTextBox.Location = new System.Drawing.Point(80, 14);
            this.FromDateTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.FromDateTextBox.Mask = "0000/00/00";
            this.FromDateTextBox.Name = "FromDateTextBox";
            this.FromDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDateTextBox.Size = new System.Drawing.Size(97, 30);
            this.FromDateTextBox.TabIndex = 4;
            this.FromDateTextBox.Click += new System.EventHandler(this.FromDateTextBox_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(187, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "به قبل";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(36, 131);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 31);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "ابطال دستی";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AutomaticCancelButton
            // 
            this.AutomaticCancelButton.Location = new System.Drawing.Point(147, 131);
            this.AutomaticCancelButton.Name = "AutomaticCancelButton";
            this.AutomaticCancelButton.Size = new System.Drawing.Size(252, 31);
            this.AutomaticCancelButton.TabIndex = 7;
            this.AutomaticCancelButton.Text = "ابطال تمام بارگیرها با ساعت پیش فرض";
            this.AutomaticCancelButton.UseVisualStyleBackColor = true;
            this.AutomaticCancelButton.Click += new System.EventHandler(this.AutomaticCancelButton_Click);
            // 
            // LaderTypecheckedComboBox
            // 
            this.LaderTypecheckedComboBox.ButtonCancelText = "انصراف";
            this.LaderTypecheckedComboBox.ButtonOKText = "تأیید";
            LaderTypecheckedComboBox_DesignTimeLayout.LayoutString = resources.GetString("LaderTypecheckedComboBox_DesignTimeLayout.LayoutString");
            this.LaderTypecheckedComboBox.DesignTimeLayout = LaderTypecheckedComboBox_DesignTimeLayout;
            this.LaderTypecheckedComboBox.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LaderTypecheckedComboBox.Location = new System.Drawing.Point(80, 51);
            this.LaderTypecheckedComboBox.Name = "LaderTypecheckedComboBox";
            this.LaderTypecheckedComboBox.SaveSettings = false;
            this.LaderTypecheckedComboBox.Size = new System.Drawing.Size(300, 30);
            this.LaderTypecheckedComboBox.TabIndex = 54;
            this.LaderTypecheckedComboBox.ValuesDataMember = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(15, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = " نوع بارگیر";
            // 
            // CancelExpiredTurnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 173);
            this.Controls.Add(this.LaderTypecheckedComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AutomaticCancelButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromDateTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelExpiredTurnForm";
            this.Text = "ابطال دستی نوبت های تاریخ گذشته";
            this.Load += new System.EventHandler(this.CancelExpiredTurnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox FromDateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AutomaticCancelButton;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox LaderTypecheckedComboBox;
        private System.Windows.Forms.Label label7;
    }
}