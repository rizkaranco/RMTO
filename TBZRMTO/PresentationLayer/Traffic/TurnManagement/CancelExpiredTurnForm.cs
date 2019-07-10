using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.TurnManagement
{
    public partial class CancelExpiredTurnForm : Hepsa.Core.PL.BaseForm
    {
        public CancelExpiredTurnForm()
        {
            InitializeComponent();
        }

        private void FromDateTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }
      
        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == true)
            {
                try
                {
                    if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromDateTextBox)))
                    {
                        throw new ApplicationException("از تاریخ خالی است");
                    }

                    if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromDateTextBox)) == false)
                    {
                        Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                        if (FromDateValidator.Validate(Hepsa.Core.Common.PersentationController.GetEntityValue(FromDateTextBox.Text, TypeCode.String).ToString()) == false)
                            throw new ApplicationException(FromDateValidator.Description);

                    }

                    object[] LaderTypeList = new object[100];
                    string LaderTypeList_nvc = string.Empty;
                    int index = 0;
                    LaderTypeList = LaderTypecheckedComboBox.CheckedValues;
                    if (LaderTypeList != null)
                    {
                        foreach (object obj in LaderTypeList)
                        {
                            LaderTypeList_nvc = string.Format("{0},{1}", LaderTypeList_nvc, LaderTypeList[index].ToString());
                            index += 1;
                        }
                        LaderTypeList_nvc = LaderTypeList_nvc.Substring(1, LaderTypeList_nvc.Length - 1);

                    }

                    if (string.IsNullOrEmpty(LaderTypeList_nvc))
                    {
                        throw new ApplicationException("نوع بارگیر انتخاب نشده است");
                    }

                    int ExecuteCount = -1;
                    ExecuteCount = CancelTimeExpiredTurns(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromDateTextBox), LaderTypeList_nvc);
                    if (ExecuteCount >= 0)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage(string.Format("تعداد {0} نوبت باطل شد", ExecuteCount.ToString()));
                    }


                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
            }
        }

        private void AutomaticCancelButton_Click(object sender, EventArgs e)
        {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == true)
            {
                try
                {
                    int ExecuteCount = -1;
                    ExecuteCount = CancelTimeExpiredTurns(string.Empty,string.Empty);
                    if (ExecuteCount >= 0)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage(string.Format("تعداد {0} نوبت باطل شد", ExecuteCount.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
            }
        }

        private Int32 CancelTimeExpiredTurns(string Date_nvc,string LaderTypeID_nvc)
        {
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1008;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            int Canceledrowcount = -1;
                if (string.IsNullOrEmpty(LaderTypeID_nvc) && string.IsNullOrEmpty(Date_nvc))
                {
                    Canceledrowcount = DoCancelOperation(string.Empty,string.Empty);
                }
                else
                {
                    Canceledrowcount = DoCancelOperation(Date_nvc,LaderTypeID_nvc);
                }
                
            return Canceledrowcount;
        }

        private Int32 DoCancelOperation(string Date_nvc,string LaderTypeID_nvc)
        {
            string CancelDate=string.Empty;
            if (string.IsNullOrEmpty(Date_nvc))
            {
                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();

                SettingKey.SettingID_int = 1003;
                SettingEntity = SettingFactory.GetBy(SettingKey);

                Hepsa.Core.Common.MyDateTime CurrentDate = new Hepsa.Core.Common.MyDateTime(SettingFactory.ServerJalaliDate);
                string CancelTime = SettingFactory.ServerTime;
                string CurrentDateTime = CurrentDate.MyDate.ToString("yyyy/MM/dd") + " " + CancelTime;

                DateTime SubtractedDate = DateTime.Parse(CurrentDateTime);
                SubtractedDate = SubtractedDate.AddHours(-Int32.Parse(SettingEntity.Value_nvc));

                CancelDate = new Hepsa.Core.Common.MyDateTime(SubtractedDate).ConvertToPersianShortDate();
            }
            else
            {
                CancelDate = Date_nvc;
            }
        

            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T TurnCancelCommentEntity = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T();
            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys TurnCancelCommentKey = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys();
            TurnCancelCommentKey.TurnCancelCommentID_int = 40;
            TurnCancelCommentEntity = TurnCancelCommentFactory.GetBy(TurnCancelCommentKey);
            HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable AcceptedTurnsWithoutLadBillDataTable = new DataTable();
            if (string.IsNullOrEmpty(LaderTypeID_nvc))
            {
                TrafficFactory.SelectInTurnAcceptedForDelete(CancelDate, string.Empty, AcceptedTurnsWithoutLadBillDataTable);
            }
            else
            {
                TrafficFactory.SelectInTurnAcceptedForDelete(CancelDate, LaderTypeID_nvc, AcceptedTurnsWithoutLadBillDataTable);
            }
            
            int rowcount = -1;
            if (AcceptedTurnsWithoutLadBillDataTable != null && AcceptedTurnsWithoutLadBillDataTable.Rows.Count > 0)
            {
                rowcount = AcceptedTurnsWithoutLadBillDataTable.Rows.Count;
                foreach (DataRow row in AcceptedTurnsWithoutLadBillDataTable.Rows)
                {
                    HPS.BLL.TurnManagementBLL.BLLTurnManagement_T TurnManagementEntity = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
                    TurnManagementEntity.TurnCancelCommantID_int = TurnCancelCommentEntity.TurnCancelCommentID_int;
                    TurnManagementEntity.TurnCancelCommment_nvc = TurnCancelCommentEntity.TurnCancelComment_nvc;
                    TurnManagementEntity.Return_bit = false;
                    TurnManagementEntity.Date_nvc = TurnManagementFactory.ServerJalaliDate;
                    TurnManagementEntity.Time_nvc = TurnManagementFactory.ServerTime;
                    TurnManagementEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    TurnManagementEntity.TrafficID_bint = Convert.ToInt64(row["TrafficID_bint"]);
                    TurnManagementFactory.BeginProc();
                    TurnManagementFactory.Insert(TurnManagementEntity);
                    TurnManagementFactory.CommitProc();
                }
            }
            return rowcount;
        }

        private void CancelExpiredTurnForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillCombo();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FillCombo()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            DataTable LaderTypeID_intDataTable = new DataTable();
            string laderCondition = "[LaderType_T].[Active_bit]='true'";
            LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
            this.LaderTypecheckedComboBox.DropDownDataSource = LaderTypeID_intDataTable;
            this.LaderTypecheckedComboBox.DropDownDataMember = "LaderType_T";
            this.LaderTypecheckedComboBox.DropDownDisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
            this.LaderTypecheckedComboBox.DropDownValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
            LaderTypecheckedComboBox.RetrieveStructure();
            LaderTypecheckedComboBox.DropDownList.Columns[1].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[2].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[4].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[3].Caption = "بارگیر";
            LaderTypecheckedComboBox.DropDownList.Columns[3].Width = 300;
            LaderTypecheckedComboBox.DropDownList.Columns[5].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[6].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[7].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[8].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[9].Visible = false;
            LaderTypecheckedComboBox.DropDownList.Columns[10].Visible = false;
        }

    }
}
