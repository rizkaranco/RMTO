namespace HPS.Present.Common.Setting_T
{
    partial class SettingEntityForm
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
            this.SettingGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingGroupBox
            // 
            this.SettingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingGroupBox.Location = new System.Drawing.Point(2, -3);
            this.SettingGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SettingGroupBox.Name = "SettingGroupBox";
            this.SettingGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SettingGroupBox.Size = new System.Drawing.Size(520, 96);
            this.SettingGroupBox.TabIndex = 2;
            this.SettingGroupBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(408, 100);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "ثبت";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingEntityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(524, 141);
            this.Controls.Add(this.SettingGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("B Mitra", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingEntityForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.SettingEntityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox SettingGroupBox;
        internal System.Windows.Forms.Button SaveButton;
    }
}