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
    public partial class TrafficPictures : Hepsa.Core.PL.BaseListForm
    {
        public TrafficPictures()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group TrafficPicturesGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficPicturesGroup.set_Grid(true, false, false, this.TrafficPicturesGridView);
            TrafficPicturesGroup.ToolStrip = this.TrafficPicturesToolStrip;
            TrafficPicturesGroup.HasFilterControl = true;
            this.Groups.Add(TrafficPicturesGroup);

            Hepsa.Core.PL.BaseListForm.Group InOutTimesGroup = new Hepsa.Core.PL.BaseListForm.Group();
            InOutTimesGroup.set_Grid(true, false, false, this.InOutTimesGrid);
            //InOutTimesGroup.ExportButton = this.ExportToExcelStripButton;
            InOutTimesGroup.ToolStrip = this.InOutToolStrip;
            InOutTimesGroup.HasFilterControl = true;
            this.Groups.Add(InOutTimesGroup);

            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure TrafficPicturesRelation = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            TrafficPicturesRelation.Group1 = TrafficPicturesGroup;
            TrafficPicturesRelation.HasGroup1ChangeEvent = true;
            TrafficPicturesRelation.Group1FilterColumn = "plateNumberID_bint";
            TrafficPicturesRelation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            TrafficPicturesRelation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            TrafficPicturesRelation.Group1BusinessFactory = new HPS.BLL.BLLPlateNumber_TFactory();
            TrafficPicturesRelation.Group2 = InOutTimesGroup;
            TrafficPicturesRelation.HasGroup2ChangeEvent = false;
            TrafficPicturesRelation.Group2FilterColumn = "plateNumberID_bint";
            TrafficPicturesRelation.Group2BusinessFactory = new HPS.BLL.BLLInOut_TFactory();
            TrafficPicturesRelation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref TrafficPicturesRelation);
        }

        private void TrafficPictures_Load(object sender, EventArgs e)
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
                string condition = string.Format(" Date_vc>='{0}' AND Date_vc<='{1}' AND Time_vc>='{2}' AND Time_vc<='{3}' ", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text,  FromTimeTextBox.Text, ToTimeTextBox.Text);
                DataTable trafficPicturesTable = new DataTable();
                plateNumberFatory.GetAllByCondition(condition, ref trafficPicturesTable);
                TrafficPicturesGridView.SetDataBinding(trafficPicturesTable, "trafficPicturesTable");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);              
            }
        }

        private void RefreshHourbutton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory Factory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            this.ToTimeTextBox.Text = Factory.ServerTime;
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
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void InOutTimesGrid_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TFactory InOutPicturesFactory = new BLL.InOutPicturesBLL.BLLInOutPictures_TFactory();
                List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> InOutPicturesList = new List<BLL.InOutPicturesBLL.BLLInOutPictures_T>();
                InOutPicturesList=InOutPicturesFactory.GetAllBy(BLL.InOutPicturesBLL.BLLInOutPictures_T.InOutPictures_TField.inOutID_bint,InOutTimesGrid.CurrentRow.Cells["inOutID_bint"].Value);

                if (InOutPicturesList != null && InOutPicturesList.Count>0)
                {
                    if (InOutPicturesList[0].picture_vbnry != null)
                    {
                        System.IO.MemoryStream pictureMemoryStream = new System.IO.MemoryStream();
                        pictureMemoryStream.Write(InOutPicturesList[0].picture_vbnry, 0, InOutPicturesList[0].picture_vbnry.Length);
                        pictureBox.Image = System.Drawing.Image.FromStream(pictureMemoryStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
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
