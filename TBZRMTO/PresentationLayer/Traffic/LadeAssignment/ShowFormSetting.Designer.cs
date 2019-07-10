using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignment
{
    partial class ShowFormSetting
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
            Janus.Windows.GridEX.GridEXLayout LaderTypeGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFormSetting));
            this.TimerTime_intTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.MinWeight_decLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CheckAllbutton = new System.Windows.Forms.Button();
            this.LaderTypeGridView = new Janus.Windows.GridEX.GridEX();
            this.CommentShowTimeTextBox = new HamrahanSystem.TextBox.NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerTime_intTextBox
            // 
            this.TimerTime_intTextBox.AllowNegative = true;
            this.TimerTime_intTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerTime_intTextBox.DigitsInGroup = 0;
            this.TimerTime_intTextBox.Flags = 0;
            this.TimerTime_intTextBox.Location = new System.Drawing.Point(86, 17);
            this.TimerTime_intTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TimerTime_intTextBox.MaxDecimalPlaces = 4;
            this.TimerTime_intTextBox.MaxWholeDigits = 9;
            this.TimerTime_intTextBox.Name = "TimerTime_intTextBox";
            this.TimerTime_intTextBox.Prefix = "";
            this.TimerTime_intTextBox.RangeMax = 0;
            this.TimerTime_intTextBox.RangeMin = 0;
            this.TimerTime_intTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimerTime_intTextBox.Size = new System.Drawing.Size(105, 30);
            this.TimerTime_intTextBox.TabIndex = 1;
            // 
            // MinWeight_decLabel
            // 
            this.MinWeight_decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinWeight_decLabel.AutoSize = true;
            this.MinWeight_decLabel.Location = new System.Drawing.Point(15, 21);
            this.MinWeight_decLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MinWeight_decLabel.Name = "MinWeight_decLabel";
            this.MinWeight_decLabel.Size = new System.Drawing.Size(72, 23);
            this.MinWeight_decLabel.TabIndex = 0;
            this.MinWeight_decLabel.Text = "زمان نمایش";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ثانیه";
            // 
            // ShowButton
            // 
            this.ShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowButton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.ShowButton.Location = new System.Drawing.Point(612, 16);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 33);
            this.ShowButton.TabIndex = 6;
            this.ShowButton.Text = "نمایش";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // CheckAllbutton
            // 
            this.CheckAllbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckAllbutton.Font = new System.Drawing.Font("B Mitra", 11.25F, System.Drawing.FontStyle.Bold);
            this.CheckAllbutton.Location = new System.Drawing.Point(482, 16);
            this.CheckAllbutton.Margin = new System.Windows.Forms.Padding(5);
            this.CheckAllbutton.Name = "CheckAllbutton";
            this.CheckAllbutton.Size = new System.Drawing.Size(129, 33);
            this.CheckAllbutton.TabIndex = 5;
            this.CheckAllbutton.Text = "انتخاب تمام موارد";
            this.CheckAllbutton.UseVisualStyleBackColor = true;
            this.CheckAllbutton.Click += new System.EventHandler(this.CheckAllbutton_Click);
            // 
            // LaderTypeGridView
            // 
            this.LaderTypeGridView.AlternatingColors = true;
            this.LaderTypeGridView.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.AliceBlue;
            LaderTypeGridView_DesignTimeLayout.LayoutString = resources.GetString("LaderTypeGridView_DesignTimeLayout.LayoutString");
            this.LaderTypeGridView.DesignTimeLayout = LaderTypeGridView_DesignTimeLayout;
            this.LaderTypeGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LaderTypeGridView.GroupByBoxVisible = false;
            this.LaderTypeGridView.Location = new System.Drawing.Point(0, 59);
            this.LaderTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LaderTypeGridView.Name = "LaderTypeGridView";
            this.LaderTypeGridView.Size = new System.Drawing.Size(701, 342);
            this.LaderTypeGridView.TabIndex = 7;
            // 
            // CommentShowTimeTextBox
            // 
            this.CommentShowTimeTextBox.AllowNegative = true;
            this.CommentShowTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentShowTimeTextBox.DigitsInGroup = 0;
            this.CommentShowTimeTextBox.Flags = 0;
            this.CommentShowTimeTextBox.Location = new System.Drawing.Point(346, 17);
            this.CommentShowTimeTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CommentShowTimeTextBox.MaxDecimalPlaces = 4;
            this.CommentShowTimeTextBox.MaxWholeDigits = 9;
            this.CommentShowTimeTextBox.Name = "CommentShowTimeTextBox";
            this.CommentShowTimeTextBox.Prefix = "";
            this.CommentShowTimeTextBox.RangeMax = 0;
            this.CommentShowTimeTextBox.RangeMin = 0;
            this.CommentShowTimeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentShowTimeTextBox.Size = new System.Drawing.Size(105, 30);
            this.CommentShowTimeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "سرعت گردش پیام";
            // 
            // ShowFormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 401);
            this.Controls.Add(this.CommentShowTimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LaderTypeGridView);
            this.Controls.Add(this.CheckAllbutton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerTime_intTextBox);
            this.Controls.Add(this.MinWeight_decLabel);
            this.Name = "ShowFormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات نمایش اطلاع رسانی بارها";
            this.Load += new System.EventHandler(this.ShowFormSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShowFormSetting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LaderTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MinWeight_decLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button CheckAllbutton;
        private Janus.Windows.GridEX.GridEX LaderTypeGridView;
        private System.Windows.Forms.Label label3;
        private NumericTextBox TimerTime_intTextBox;
        private NumericTextBox CommentShowTimeTextBox;
    }
}