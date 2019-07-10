using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class ActiveTurnsReportForm : Hepsa.Core.PL.BaseListForm
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();

        HPS.Main mainfrm = new HPS.Main();
        private bool WithProductionYear = false;
        public ActiveTurnsReportForm()
        {
            InitializeComponent();

            this.TrafficGridView.AutoGenerateColumns = false;
            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, true, true, this.TrafficGridView);
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;
            TrafficGroup.ExportButton = this.ExportButton;
            this.Groups.Add(TrafficGroup);


            try
            {
                this.TrafficGridView.Focus();
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
            LoadActiveTurns();
        }

        private void LoadActiveTurns()
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficDataTable = new DataTable();
                TrafficFactory.SelectActiveTurns(FromDatefaDatePicker.Text,FromTimeTextBox.Text, ToDatefaDatePicker.Text,  ToTimeTextBox.Text, TrafficDataTable);
                this.TrafficGridView.DataSource = TrafficDataTable;
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
                LoadActiveTurns();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromDateTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        //private void ToDateTextBox_Click(object sender, EventArgs e)
        //{
        //    MaskedTextBoxSetFocus(sender, e);
        //}

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

        private void ActiveTurnsReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.Enabled = false;
                //this.FromTimeTextBox.Text = "08:00:00";
                //this.ToTimeTextBox.Text = Factory.ServerTime.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void FromTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToTimeTextBox_Click(object sender, EventArgs e)
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

        private void FromTimeTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
