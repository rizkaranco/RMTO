using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class ServiceStatusReportForm : Hepsa.Core.PL.BaseListForm
    {
        HPS.Main mainfrm = new HPS.Main();

        public ServiceStatusReportForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group LoadServiceStatusGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LoadServiceStatusGroup.set_Grid(true, true, true, this.ServiceStatusGrid);
            LoadServiceStatusGroup.ToolStrip = this.ServiceStatusToolStrip;
            LoadServiceStatusGroup.HasFilterControl = true;
            LoadServiceStatusGroup.ExportButton = this.ExportButton;
            this.Groups.Add(LoadServiceStatusGroup);

            try
            {
                this.ServiceStatusGrid.Focus();
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
            LoadServiceStatus();
        }

        private void LoadServiceStatus()
        {
            try
            {
                HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TFactory ServiceStatusFactory = new HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TFactory();
                DataTable ServiceStatusTable = new DataTable();
                int SoftwareCode_int = 0;
                if (ServiceComboBox.SelectedIndex == 0)
                {
                    SoftwareCode_int = 1;
                }
                else if (ServiceComboBox.SelectedIndex == 1)
                {
                    SoftwareCode_int = 2;
                }
                string condition = string.Format(" DisconnectDate_vc+' '+DisconnectTime_vc>='{0}' AND DisconnectDate_vc+' '+DisconnectTime_vc<='{1}' AND SoftwareCode_int={2} ", FromDatefaDatePicker.Text + " " +(FromTimeTextBox.Text), ToDatefaDatePicker.Text + " " + (ToTimeTextBox.Text), SoftwareCode_int);
                ServiceStatusFactory.GetAllByCondition(condition, ref ServiceStatusTable);
                this.ServiceStatusGrid.SetDataBinding(ServiceStatusTable, "ServiceStatusTable");
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
                LoadServiceStatus();

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

        private void ServiceStatusReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                //this.FromTimeTextBox.Text = "08:00:00";
                //this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ToTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void FromTimeTextBox_Click(object sender, EventArgs e)
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
