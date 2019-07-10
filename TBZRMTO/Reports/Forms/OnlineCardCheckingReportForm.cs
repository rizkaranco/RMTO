using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class OnlineCardCheckingReportForm : Hepsa.Core.PL.BaseListForm
    {
        HPS.Main mainfrm = new HPS.Main();

        public OnlineCardCheckingReportForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group LoadOnlineCardCheckingGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LoadOnlineCardCheckingGroup.set_Grid(true, true, true, this.OnlineCardCheckingGrid);
            LoadOnlineCardCheckingGroup.ToolStrip = this.OnlineCardCheckingToolStrip;
            LoadOnlineCardCheckingGroup.HasFilterControl = true;
            LoadOnlineCardCheckingGroup.ExportButton = this.ExportButton;
            this.Groups.Add(LoadOnlineCardCheckingGroup);

            try
            {
                this.OnlineCardCheckingGrid.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadOnlineCardChecking();
        }

        private void LoadOnlineCardChecking()
        {
            try
            {
                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                DataTable CardCheckingLogTable = new DataTable();
                string condition = string.Format( " Date_vc+' '+Time_vc>='{0}' AND Date_vc+' '+Time_vc<='{1}'",FromDatefaDatePicker.Text+" "+FromTimeTextBox.Text,ToDatefaDatePicker.Text+" "+ToTimeTextBox.Text );
                CardCheckingLogFactory.GetAllByCondition(condition, ref CardCheckingLogTable);
                this.OnlineCardCheckingGrid.SetDataBinding(CardCheckingLogTable, "CardCheckingLogTable");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("از تاریخ خالی است");
                }
                else if (ToDatefaDatePicker.IsNull)
                {
                    throw new ApplicationException("تا تاریخ خالی است");
                }
                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)))
                {
                    throw new ApplicationException("از ساعت خالی است");
                }

                else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)))
                {
                    throw new ApplicationException("تا ساعت خالی است");
                }

                Hepsa.Core.Validation.TimeRule<string> FromTimeValidator = new Hepsa.Core.Validation.TimeRule<string>("FromTime", "از ساعت", null, null);
                if (FromTimeValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromTimeTextBox)) == false)
                {
                    throw new ApplicationException(FromTimeValidator.Description);
                }

                Hepsa.Core.Validation.TimeRule<string> ToTimeValidator = new Hepsa.Core.Validation.TimeRule<string>("ToTime", "تا ساعت", null, null);
                if (ToTimeValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToTimeTextBox)) == false)
                {
                    throw new ApplicationException(ToTimeValidator.Description);
                }
                LoadOnlineCardChecking();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
        }

        private void OnlineCardCheckingReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ToTime_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void FromTime_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void DefaulCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (DefaulCheckBox.Checked)
                {
                    TimeGroupBox.Enabled = true;
                    RefreshHourbutton.PerformClick();
                }
                else
                {
                    TimeGroupBox.Enabled = false;
                    FromTimeTextBox.Text = "00:00:00";
                    ToTimeTextBox.Text = "23:59:59";
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

    }
}
