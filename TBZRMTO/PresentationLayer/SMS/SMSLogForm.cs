using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SMS
{
    public partial class SMSLogForm : Hepsa.Core.PL.BaseListForm
    {
        public SMSLogForm()
        {
            InitializeComponent();


            this.SMSGridView.AutoGenerateColumns = false;

            Hepsa.Core.PL.BaseListForm.Group SmsLogGroup = new Hepsa.Core.PL.BaseListForm.Group();
            SmsLogGroup.set_Grid(true, false, false, this.SMSGridView);
            SmsLogGroup.RefreshButton = this.RefreshButton;        
            SmsLogGroup.ToolStrip = this.SmsLogToolStrip;
            SmsLogGroup.HasFilterControl = true;

            this.Groups.Add(SmsLogGroup);
            
        }

        private void SMSGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SMSGridView.CurrentRow != null)
            {
                this.SMSBodyTextBox.Text = SMSGridView.CurrentRow.Cells["colSendMessage_nvc"].Value.ToString();
            }
        }

        private void SMSLogForm_Load(object sender, EventArgs e)
        {
            
            HPS.BLL.BLLSmsInfo_TFactory SmsFactory = new HPS.BLL.BLLSmsInfo_TFactory();
            FromDatetextBox.Text = SmsFactory.ServerJalaliDate.ToString();
            TodatetextBox.Text = SmsFactory.ServerJalaliDate.ToString();
            LoadSMSLog();
        }

        private void LoadSMSLog()
        {
            try
            {
                HPS.BLL.BLLSmsInfo_TFactory SmsFactory = new HPS.BLL.BLLSmsInfo_TFactory();
                DataTable smsLogDataTable = new DataTable();

                Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (FromDateValidator.Validate(FromDatetextBox.Text) == false)
                    throw new ApplicationException(FromDateValidator.Description);

                Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                if (ToDateValidator.Validate(TodatetextBox.Text) == false)
                    throw new ApplicationException(ToDateValidator.Description);

                SmsFactory.SelectSmsLog(FromDatetextBox.Text, TodatetextBox.Text, smsLogDataTable);
                this.SMSGridView.DataSource = smsLogDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            LoadSMSLog();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FromDatetextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }
        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void TodatetextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

    }
}
