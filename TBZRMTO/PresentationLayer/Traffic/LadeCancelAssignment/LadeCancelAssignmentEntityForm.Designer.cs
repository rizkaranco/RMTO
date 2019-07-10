using HamrahanSystem.TextBox;
using System.Windows.Forms;

namespace HPS.Present.LadeCancelAssignment
{
    partial class LadeCancelAssignmentEntityForm 

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
            this.DetailGropBox = new System.Windows.Forms.GroupBox();
            this.LadeCancelCommentID_intComboBox = new System.Windows.Forms.ComboBox();
            this.LadeCancelCommentID_intLabel = new System.Windows.Forms.Label();
            this.Count_intLabel = new System.Windows.Forms.Label();
            this.Count_intNumericTextBox = new NumericTextBox();
            this.LadeCancelCommentID_intCheckList = new System.Windows.Forms.CheckedListBox();
            this.DetailGropBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveAndNextButton
            // 
            this.SaveAndNextButton.Location = new System.Drawing.Point(569, 12);
            this.SaveAndNextButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Location = new System.Drawing.Point(569, 50);
            this.SaveAndCloseButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Location = new System.Drawing.Point(569, 88);
            this.DeleteRecordButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(569, 126);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            // 
            // DetailGropBox
            // 
            this.DetailGropBox.Controls.Add(this.LadeCancelCommentID_intComboBox);
            this.DetailGropBox.Controls.Add(this.LadeCancelCommentID_intLabel);
            this.DetailGropBox.Controls.Add(this.Count_intLabel);
            this.DetailGropBox.Controls.Add(this.Count_intNumericTextBox);
            this.DetailGropBox.Location = new System.Drawing.Point(10, 2);
            this.DetailGropBox.Margin = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Name = "DetailGropBox";
            this.DetailGropBox.Padding = new System.Windows.Forms.Padding(5);
            this.DetailGropBox.Size = new System.Drawing.Size(548, 179);
            this.DetailGropBox.TabIndex = 0;
            this.DetailGropBox.TabStop = false;
            // 
            // LadeCancelCommentID_intComboBox
            // 
            this.LadeCancelCommentID_intComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadeCancelCommentID_intComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LadeCancelCommentID_intComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LadeCancelCommentID_intComboBox.FormattingEnabled = true;
            this.LadeCancelCommentID_intComboBox.Location = new System.Drawing.Point(10, 44);
            this.LadeCancelCommentID_intComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.LadeCancelCommentID_intComboBox.MaxDropDownItems = 14;
            this.LadeCancelCommentID_intComboBox.Name = "LadeCancelCommentID_intComboBox";
            this.LadeCancelCommentID_intComboBox.Size = new System.Drawing.Size(332, 31);
            this.LadeCancelCommentID_intComboBox.TabIndex = 0;
            // 
            // LadeCancelCommentID_intLabel
            // 
            this.LadeCancelCommentID_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadeCancelCommentID_intLabel.Location = new System.Drawing.Point(356, 28);
            this.LadeCancelCommentID_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LadeCancelCommentID_intLabel.Name = "LadeCancelCommentID_intLabel";
            this.LadeCancelCommentID_intLabel.Size = new System.Drawing.Size(183, 60);
            this.LadeCancelCommentID_intLabel.TabIndex = 2;
            this.LadeCancelCommentID_intLabel.Text = "توضیحات ابطال اطلاع رسانی بار ";
            this.LadeCancelCommentID_intLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Count_intLabel
            // 
            this.Count_intLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Count_intLabel.AutoSize = true;
            this.Count_intLabel.Location = new System.Drawing.Point(352, 88);
            this.Count_intLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Count_intLabel.Name = "Count_intLabel";
            this.Count_intLabel.Size = new System.Drawing.Size(106, 23);
            this.Count_intLabel.TabIndex = 3;
            this.Count_intLabel.Text = "تعداد ماشین حذفی";
            // 
            // Count_intNumericTextBox
            // 
            this.Count_intNumericTextBox.AllowNegative = false;
            this.Count_intNumericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Count_intNumericTextBox.DigitsInGroup = 0;
            this.Count_intNumericTextBox.Flags = 65536;
            this.Count_intNumericTextBox.Location = new System.Drawing.Point(10, 88);
            this.Count_intNumericTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Count_intNumericTextBox.MaxDecimalPlaces = 0;
            this.Count_intNumericTextBox.MaxWholeDigits = 155;
            this.Count_intNumericTextBox.Name = "Count_intNumericTextBox";
            this.Count_intNumericTextBox.Prefix = "";
          //  this.Count_intNumericTextBox.RangeMax =0 ; // 1.7976931348623157E+308D;
           // this.Count_intNumericTextBox.RangeMin =0 ; // -1.7976931348623157E+308D;
            this.Count_intNumericTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Count_intNumericTextBox.Size = new System.Drawing.Size(332, 30);
            this.Count_intNumericTextBox.TabIndex = 1;
            // 
            // LadeCancelCommentID_intCheckList
            // 
            this.LadeCancelCommentID_intCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LadeCancelCommentID_intCheckList.CheckOnClick = true;
            this.LadeCancelCommentID_intCheckList.FormattingEnabled = true;
            this.LadeCancelCommentID_intCheckList.Location = new System.Drawing.Point(337, 172);
            this.LadeCancelCommentID_intCheckList.Margin = new System.Windows.Forms.Padding(5);
            this.LadeCancelCommentID_intCheckList.Name = "LadeCancelCommentID_intCheckList";
            this.LadeCancelCommentID_intCheckList.Size = new System.Drawing.Size(332, 104);
            this.LadeCancelCommentID_intCheckList.TabIndex = 1;
            this.LadeCancelCommentID_intCheckList.Visible = false;
            // 
            // LadeCancelAssignmentEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 192);
            this.Controls.Add(this.DetailGropBox);
            this.Controls.Add(this.LadeCancelCommentID_intCheckList);
            this.Margin = new System.Windows.Forms.Padding(28);
            this.Name = "LadeCancelAssignmentEntityForm";
            this.Text = "ابطال اطلاع رسانی بار";
            this.Load += new System.EventHandler(this.LadeCancelAssignmentEntityForm_Load);
            this.Controls.SetChildIndex(this.LadeCancelCommentID_intCheckList, 0);
            this.Controls.SetChildIndex(this.DeleteRecordButton, 0);
            this.Controls.SetChildIndex(this.SaveAndCloseButton, 0);
            this.Controls.SetChildIndex(this.CloseFormButton, 0);
            this.Controls.SetChildIndex(this.SaveAndNextButton, 0);
            this.Controls.SetChildIndex(this.DetailGropBox, 0);
            this.DetailGropBox.ResumeLayout(false);
            this.DetailGropBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox DetailGropBox;

        private System.Windows.Forms.Label LadeCancelCommentID_intLabel;
       
private System.Windows.Forms.Label Count_intLabel;
        
private NumericTextBox Count_intNumericTextBox;
private System.Windows.Forms.CheckedListBox LadeCancelCommentID_intCheckList;
private System.Windows.Forms.ComboBox LadeCancelCommentID_intComboBox;
        
    }
}
