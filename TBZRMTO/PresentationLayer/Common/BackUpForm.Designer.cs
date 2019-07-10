namespace HPS.Present.Common
{
    partial class BackUpForm
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
            this.RestoreButton = new System.Windows.Forms.Button();
            this.BackUpbutton = new System.Windows.Forms.Button();
            this.BackUpPathtextBox = new System.Windows.Forms.TextBox();
            this.BackUpPathbutton = new System.Windows.Forms.Button();
            this.RestoreopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(184, 75);
            this.RestoreButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RestoreButton.Size = new System.Drawing.Size(180, 52);
            this.RestoreButton.TabIndex = 1;
            this.RestoreButton.Text = "بازیابی پشتیبان";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // BackUpbutton
            // 
            this.BackUpbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackUpbutton.Location = new System.Drawing.Point(464, 15);
            this.BackUpbutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackUpbutton.Name = "BackUpbutton";
            this.BackUpbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackUpbutton.Size = new System.Drawing.Size(92, 30);
            this.BackUpbutton.TabIndex = 4;
            this.BackUpbutton.Text = "ایجاد پشتیبان";
            this.BackUpbutton.UseVisualStyleBackColor = true;
            this.BackUpbutton.Click += new System.EventHandler(this.BackUpbutton_Click);
            // 
            // BackUpPathtextBox
            // 
            this.BackUpPathtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackUpPathtextBox.Location = new System.Drawing.Point(89, 16);
            this.BackUpPathtextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackUpPathtextBox.Name = "BackUpPathtextBox";
            this.BackUpPathtextBox.Size = new System.Drawing.Size(365, 30);
            this.BackUpPathtextBox.TabIndex = 5;
            this.BackUpPathtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BackUpPathbutton
            // 
            this.BackUpPathbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackUpPathbutton.Location = new System.Drawing.Point(6, 16);
            this.BackUpPathbutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackUpPathbutton.Name = "BackUpPathbutton";
            this.BackUpPathbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackUpPathbutton.Size = new System.Drawing.Size(73, 30);
            this.BackUpPathbutton.TabIndex = 3;
            this.BackUpPathbutton.Text = "مسیر فایل";
            this.BackUpPathbutton.UseVisualStyleBackColor = true;
            this.BackUpPathbutton.Click += new System.EventHandler(this.BackUpPathbutton_Click);
            // 
            // RestoreopenFileDialog
            // 
            this.RestoreopenFileDialog.FileName = "RestoreopenFileDialog";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 2);
            this.label1.TabIndex = 7;
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(561, 144);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackUpbutton);
            this.Controls.Add(this.BackUpPathtextBox);
            this.Controls.Add(this.BackUpPathbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "BackUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد پشتیبان و بازیابی";
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button BackUpbutton;
        private System.Windows.Forms.TextBox BackUpPathtextBox;
        private System.Windows.Forms.Button BackUpPathbutton;
        private System.Windows.Forms.OpenFileDialog RestoreopenFileDialog;
        private System.Windows.Forms.Label label1;

    }
}