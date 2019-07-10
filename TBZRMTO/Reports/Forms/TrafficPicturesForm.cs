using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class TrafficPicturesForm : Hepsa.Core.PL.BaseListForm
    {
        public TrafficPicturesForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, true, true, this.TrafficPicturesGridView);
            TrafficGroup.ToolStrip = this.TrafficPicturesToolStrip;
            TrafficGroup.HasFilterControl = true;
            TrafficGroup.ExportButton = this.ExportExelButton;
            this.Groups.Add(TrafficGroup);

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

        private void FromTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToTimeTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime;
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

                HPS.BLL.BLLPlateNumber_TFactory plateNumberFatory = new BLL.BLLPlateNumber_TFactory();
                DataTable trafficPicturesTable = new DataTable();
                plateNumberFatory.SelectInout(FromDatefaDatePicker.Text,FromTimeTextBox.Text,ToDatefaDatePicker.Text,ToTimeTextBox.Text,trafficPicturesTable);
                //TrafficPicturesGridView.SetDataBinding(trafficPicturesTable, "trafficPicturesTable");
                TrafficPicturesGridView.DataSource = trafficPicturesTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void TrafficPicturesForm_Load(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(Factory.ServerJalaliDate);
                           }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        System.IO.MemoryStream pictureMemoryStream = new System.IO.MemoryStream();
        private void TrafficPicturesGridView_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                FillGrig();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            TrafficPicturesFullScreanForm frm = new TrafficPicturesFullScreanForm(pictureMemoryStream);
            frm.ShowDialog();
        }

        private void TrafficPicturesGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                FillGrig();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FillGrig()
        {
            HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TFactory InOutPicturesFactory = new BLL.InOutPicturesBLL.BLLInOutPictures_TFactory();
            List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> InOutPicturesList = new List<BLL.InOutPicturesBLL.BLLInOutPictures_T>();
            InOutPicturesList = InOutPicturesFactory.GetAllBy(BLL.InOutPicturesBLL.BLLInOutPictures_T.InOutPictures_TField.inOutID_bint, TrafficPicturesGridView.CurrentRow.Cells[colinOutID_bint.Name].Value);

            if (InOutPicturesList != null && InOutPicturesList.Count > 0)
            {
                if (InOutPicturesList[0].picture_vbnry != null)
                {
                    System.IO.MemoryStream pictureMemoryStream = new System.IO.MemoryStream();
                    pictureMemoryStream.Write(InOutPicturesList[0].picture_vbnry, 0, InOutPicturesList[0].picture_vbnry.Length);
                    pictureBox.Image = System.Drawing.Image.FromStream(pictureMemoryStream);
                }
            }
        }     
    }
}
