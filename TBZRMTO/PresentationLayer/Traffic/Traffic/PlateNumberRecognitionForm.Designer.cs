namespace HPS.Present.Traffic
{
    partial class PlateNumberRecognitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlateNumberRecognitionForm));
            this.button1 = new System.Windows.Forms.Button();
            this.axVitaminCtrl1 = new AxVITAMINDECODERLib.AxVitaminCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.axVitaminCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axVitaminCtrl1
            // 
            this.axVitaminCtrl1.Enabled = true;
            this.axVitaminCtrl1.Location = new System.Drawing.Point(0, 0);
            this.axVitaminCtrl1.Name = "axVitaminCtrl1";
            this.axVitaminCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVitaminCtrl1.OcxState")));
            this.axVitaminCtrl1.Size = new System.Drawing.Size(414, 350);
            this.axVitaminCtrl1.TabIndex = 50;
            // 
            // PlateNumberRecognitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 350);
            this.Controls.Add(this.axVitaminCtrl1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "PlateNumberRecognitionForm";
            this.Text = "تشخیص پلاک";
            this.Activated += new System.EventHandler(this.PlateNumberRecognitionForm_Activated);
            this.Load += new System.EventHandler(this.PlateNumberRecognitionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVitaminCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private AxVITAMINDECODERLib.AxVitaminCtrl axVitaminCtrl1;
    }
}