using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.CancelLadBillCreditComment
{
    public partial class CancelLadBillCreditCommentForm : Hepsa.Core.PL.BaseForm
    {
        private HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys _Key = null;
        private HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys _LaKey = null;
        private HPS.BLL.TrafficBLL.BLLTraffic_TKeys _TrafficKey = null;
        private DataTable _dataTable = null;

        public CancelLadBillCreditCommentForm(DataTable dataTable, HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys Key, HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LaKey,HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey)
        {
            InitializeComponent();
            this._Key = Key;
            this._dataTable = dataTable;
            this._LaKey = LaKey;
            this._TrafficKey = TrafficKey;
        }


        private void CancelLadBillCreditCommentForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadCheckListBox();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TFactory LadBillCreditCancelCommentFactory = new HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TFactory();

            try
            {
                if (LadBillCreditCancelCommentID_intCheckedListBox.CheckedItems.Count == 0)
                {
                    throw new ApplicationException("توضیحات ابطال مجوز انتخاب نشده است");
                }

                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T LadBillCreditEntity = LadBillCreditFactory.GetBy(this._Key);
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                if (LadBillCreditEntity == null)
                    throw new HPS.Exceptions.LadBillCreditNotFound();
                LadBillCreditEntity.Canceled_bit = true;
                LadBillCreditEntity.CanceledComment_nvc = this.LadBillCreditCancelComment_nvcTextBox.Text;
                LadBillCreditEntity.CanceledDate_nvc = LadBillCreditFactory.ServerJalaliDate;
                LadBillCreditEntity.CanceledTime_nvc = LadBillCreditFactory.ServerTime;
                LadBillCreditEntity.CanceledUserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                if (TurnLeftRadioButton.Checked == true)
                {
                    LadBillCreditEntity.Turn_bit = true;
                }
                else if (TurnCancelRadioButton.Checked == true)
                {
                    LadBillCreditEntity.Turn_bit = false;
                   
                }
                if (LadBillCreditEntity.Turn_bit.HasValue == false)
                {
                    throw new ApplicationException("وضعیت نوبت را تعیین نمایید ");
                }
                if (LadeAssignmentLeftradioButton.Checked == false && LadeAssginmentCancelradioButton.Checked == false && OtherRemainedCancelRadioButton.Checked==false)
                {
                    throw new ApplicationException("وضعیت اطلاع رسانی را تعیین نمایید ");
                }
                string strSelect = string.Format("TrafficID_bint='{0}'", _TrafficKey.TrafficID_bint);
                DataRow[] drSelect = _dataTable.Select(strSelect);
                DataTable TrafficStatusDataTable = new DataTable();
                if (drSelect != null && drSelect.Length > 0)
                {
                    LadBillCreditFactory.GetLastStatusForCancelLadBillCredit((string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["NumberPlate_nvc"], TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["SerialPlate_nvc"], TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["CarCardNumber_nvc"], TypeCode.String), TrafficStatusDataTable);
                }
                if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                {
                    bool? HasTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasTurn_bit"], TypeCode.Boolean);
                    bool? TurnReturn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                    bool? TurnCanceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                    bool? HasLadBillCredit_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasLadBillCredit_bit"], TypeCode.Boolean);
                    bool? LadBillCreditCancel_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                    bool? LadBillCreditTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                    bool? TurnAccepted_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);
                    Int64? AcceptedTurnNumber_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["AcceptedTurnNumber_bint"], TypeCode.Int64);
                  //  DateTime TrafficDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficEntity.Date_nvc)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficEntity.Time_nvc);

                    #region  Conditions
                    if ((Int32)drSelect[0]["ServiceID_int"] == 2)
                    {
                        if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                        {
                            if (HasTurn_bit.HasValue == false || HasTurn_bit == true)
                            {
                                if (TurnAccepted_bit.HasValue && TurnAccepted_bit == true)
                                {
                                   
                                    if (TurnCanceled_bit.HasValue && TurnCanceled_bit == true)
                                    {
                                        throw new ApplicationException("این نوبت باطل شده است");
                                    }
                                    else
                                    {
                                        if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                                        {
 
                                            if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == false)
                                            {
                                                if (LadBillCreditTurn_bit.HasValue && LadBillCreditTurn_bit == true)
                                                {
                                                    //محاسبه مدت مجاز سفر
                                                    DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                                    DataTable TrafficDataTable = new DataTable();
                                                    if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                                    {
                                                        Int32 _CityTravelHour = 0;
                                                        if (!string.IsNullOrEmpty(TrafficDataTable.Rows[0]["TravelTime_int"].ToString()))
                                                        {
                                                            _CityTravelHour = Convert.ToInt32(TrafficDataTable.Rows[0]["TravelTime_int"].ToString());
                                                        }
                                                        ///////////////
                                                        string _OutDate = TrafficDataTable.Rows[0]["Date_nvc"].ToString();
                                                        string _OutTime = TrafficDataTable.Rows[0]["Time_nvc"].ToString();
                                                        DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);

                                                        if (TrafficDataTable.Rows[0]["Out_bit"].ToString() == "False")
                                                        {
                                                            TimeSpan date = NowDate - OutDate;
                                                            if (date.TotalHours < _CityTravelHour)
                                                            {
                                                                throw new ApplicationException("مدت مجاز سفر برای این کامیون تمام نشده است و امکان ادامه عملیات ممکن نیست");
                                                            }
                                                        }
                                                    }

                                                }
                                                else
                                                {
                                                    if (TurnLeftRadioButton.Checked)
                                                    { 
                                                    DataTable TurnStatusDataTable = new DataTable();
                                                        //*************اگر خودرو خارج شده باشد اجازه حفظ نوبت را نداشته باشد93/06/10
                                                   List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, drSelect[0]["TrafficNumber_bint"]);
                                                    if (TrafficList.Count > 0 && TrafficList != null)
                                                            {
                                                                foreach (HPS.BLL.TrafficBLL.BLLTraffic_T item in TrafficList)
                                                                {
                                                                    if (item.Out_bit == true)
                                                                    {
                                                                        //LadBillCreditEntity.Turn_bit = false;
                                                                        Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو خارج شده است، امکان حفظ نوبت وجود ندارد");
                                                                        return;
                                                                    }
                                                                }
                                                            }

                                                  
                                                        //BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new BLL.SettingsBLL.BLLSetting_TKeys();
                                                        //BLL.SettingsBLL.BLLSetting_T SettingEntity = new BLL.SettingsBLL.BLLSetting_T();
                                                        //BLL.SettingsBLL.BLLSetting_TFactory SettingsFactory = new BLL.SettingsBLL.BLLSetting_TFactory();
                                                        //SettingKey.SettingID_int = 1009;
                                                        //SettingEntity = SettingsFactory.GetBy(SettingKey);
                                                        //TrafficFactory.SelectActiveTurnsForInTraffic(drSelect[0]["NumberPlate_nvc"].ToString(), drSelect[0]["SerialPlate_nvc"].ToString(), SettingEntity.Value_nvc, "00:00:00", TrafficFactory.ServerJalaliDate, "23:59:59", TurnStatusDataTable);

                                                        TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["NumberPlate_nvc"], TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["SerialPlate_nvc"], TypeCode.String), TurnStatusDataTable);
                                                        if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                        {
                                                            if ((bool?)(Hepsa.Core.Common.PersentationController.GetEntityValue(TurnStatusDataTable.Rows[0]["Canceled_bit"], TypeCode.Boolean)) != false)
                                                            {
                                                                throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                                            }
                                                        }
                                                        DataTable LadBillCreditTrafficStatusDataTable = new DataTable();
                                                        LadBillCreditFactory.GetLadBillCreditTrafficStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["NumberPlate_nvc"], TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["SerialPlate_nvc"], TypeCode.String), LadBillCreditTrafficStatusDataTable);
                                                        if (LadBillCreditTrafficStatusDataTable != null && LadBillCreditTrafficStatusDataTable.Rows.Count > 0)
                                                        {
                                                            int? LadBillCredit = (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillCreditTrafficStatusDataTable.Rows[0]["LadBillCreditID_int"], TypeCode.Int32);
                                                            int? TurnCancelComment = (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillCreditTrafficStatusDataTable.Rows[0]["TurnCancelCommantID_int"], TypeCode.Int32);
                                                            bool? Turnaccepted = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillCreditTrafficStatusDataTable.Rows[0]["Turnaccepted_bit"], TypeCode.Boolean);
                                                            

                                                            string strHas2LadBill = string.Format("TrafficID_bint='{0}'", drSelect[0]["TrafficID_bint"]);
                                                            string strSecondStatus = string.Format("TrafficID_bint>'{0}'", drSelect[0]["TrafficID_bint"]);
                                                            DataRow[] drHas2LadBill = LadBillCreditTrafficStatusDataTable.Select(strHas2LadBill);
                                                            DataRow[] drSecondStatus = LadBillCreditTrafficStatusDataTable.Select(strSecondStatus);
                                                            if (drHas2LadBill != null && drHas2LadBill.Length > 0)
                                                            {
                                                                if (drSecondStatus != null && drSecondStatus.Length > 0)
                                                                {
                                                                    int? LadBillCreditSecond = (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(drSecondStatus[0]["LadBillCreditID_int"], TypeCode.Int32);
                                                                    int? TurnCancelCommentSecond = (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(drSecondStatus[0]["TurnCancelCommantID_int"], TypeCode.Int32);
                                                                    bool? TurnacceptedSecond = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(drSecondStatus[0]["Turnaccepted_bit"], TypeCode.Boolean);
                                                                    if (TurnacceptedSecond.HasValue && TurnacceptedSecond == true)
                                                                    { 
                                                                        if (LadBillCreditSecond.HasValue)
                                                                        {
                                                                            throw new ApplicationException(string.Format("این ناوگان به شماره نوبت< {0} >و شماره قبض< {1} >مجوز گرفته است", drSecondStatus[0]["AcceptedTurnNumber_bint"], drSecondStatus[0]["TrafficNumber_bint"]));
                                                                        }
                                                                        else
                                                                        {
                                                                            if (TurnCancelCommentSecond.HasValue == false)
                                                                            {
                                                                                throw new ApplicationException(string.Format("این ناوگان داراي شماره نوبت تأييد شده< {0} >مي باشد", drSecondStatus[0]["AcceptedTurnNumber_bint"], drSecondStatus[0]["TrafficNumber_bint"]));
                                                                            }
                                                                        }
                                                                    }

                                                                }

                                                            }
                                                            else
                                                            {
                                                                DataTable TurnTtatusDataTable = new DataTable();
                                                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["NumberPlate_nvc"], TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["SerialPlate_nvc"], TypeCode.String), TurnTtatusDataTable);
                                                                if (TurnTtatusDataTable != null && TurnTtatusDataTable.Rows.Count > 0)
                                                                {
                                                                    if ((bool?)(Hepsa.Core.Common.PersentationController.GetEntityValue(TurnStatusDataTable.Rows[0]["Canceled_bit"], TypeCode.Boolean)) != false)
                                                                    {
                                                                        throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                                                    }
                                                                }
                                                            }
                                                        }

                                                    }
                                                    else
                                                    {
                                                         if (TurnCancelRadioButton.Checked == true)
                                                            {
                                                                LadBillCreditEntity.Turn_bit = false;
                                                                //*************اگر خودرو خارج نشده باشد اجازه ابطال را نداشته باشد94/10/01
                                                                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficOutList = TrafficFactory.GetAllByCondition(string.Format("[Traffic_T].Out_bit=1 and [Traffic_T].TrafficNumber_bint={0}", drSelect[0]["TrafficNumber_bint"].ToString()));
                                                                if (TrafficOutList.Count ==0)
                                                                {
                                                                    Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو خارج نشده است، امکان ابطال وجود ندارد");
                                                                     return;
                                                                }
                                                            }
                                                        //ابطال نوبت 
                                                        HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                                                        HPS.BLL.TurnManagementBLL.BLLTurnManagement_T TurnManagementEntity = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
                                                        TurnManagementEntity.TurnCancelCommantID_int = 11;
                                                        TurnManagementEntity.TurnCancelCommment_nvc = "ابطال نوبت هنگام ابطال مجوز";
                                                        TurnManagementEntity.Return_bit = false;
                                                        TurnManagementEntity.Date_nvc = TurnManagementFactory.ServerJalaliDate;
                                                        TurnManagementEntity.Time_nvc = TurnManagementFactory.ServerTime;
                                                        TurnManagementEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                                                        TurnManagementEntity.TrafficID_bint = (Int64?)drSelect[0]["TrafficID_bint"];
                                                        TurnManagementFactory.Insert(TurnManagementEntity);

                                                    }
                                                }
                                            }
                                            else
                                            {
                                                DataTable TurnStatusDataTable = new DataTable();
                                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["NumberPlate_nvc"], TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["SerialPlate_nvc"], TypeCode.String), TurnStatusDataTable);
                                                if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                {
                                                    throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (TurnLeftRadioButton.Checked)
                                            {
                                                throw new ApplicationException(string.Format("این ناوگان دارای شماره نوبت تأیید شده {0} می باشد ومجوز نگرفته است", AcceptedTurnNumber_bint));
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();
                                    TrafficFactory.GetLastStatusForAcceptTurn((Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(drSelect[0]["TrafficID_bint"], TypeCode.Int64), TrafficStatusForAcceptTurnDataTable);
                                    if (TrafficStatusForAcceptTurnDataTable != null && TrafficStatusForAcceptTurnDataTable.Rows.Count > 0)
                                    {
                                        throw new ApplicationException(string.Format("این ناوگان دارای شماره نوبت تأیید شده {0} می باشد ومجوز نگرفته است", TrafficStatusForAcceptTurnDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                    }

                                }
                            }
                        }
                        else
                        {
                            throw new ApplicationException("نوبت معتبر ندارد");
                        }
                    }
                    #endregion
                }



                LadBillCreditFactory.BeginProc();
                
                if (LadeAssginmentCancelradioButton.Checked)
                {
                    //ابطال اطلاع رسانی بار
                    
                    LadBillCreditFactory.Update(LadBillCreditEntity, this._Key);
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T LadeCancelAssignmentEntity = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T();
                    LadeCancelAssignmentEntity.LadeAssignmentID_bint = _LaKey.LadeAssignmentID_bint.Value;
                    LadeCancelAssignmentEntity.LadeCancelCommentID_int = 6;
                    LadeCancelAssignmentEntity.LadeCancelComment_nvc = "ابطال اطلاع رسانی بار هنگام ابطال مجوز";
                    LadeCancelAssignmentEntity.Count_int = 1;
                    LadeCancelAssignmentEntity.Date_nvc = LadeCancelAssignmentFactory.ServerJalaliDate;
                    LadeCancelAssignmentEntity.Time_nvc = LadeCancelAssignmentFactory.ServerTime;
                    LadeCancelAssignmentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    LadeCancelAssignmentFactory.Insert(LadeCancelAssignmentEntity);
                }

                else if (OtherRemainedCancelRadioButton.Checked)
                {
                    //ابطال اطلاع رسانی بار و باقی  مانده ها
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T LadeCancelAssignmentEntity = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T();
                    BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                    DataTable remainedLadeAssignmentTable = new DataTable();
                    string condition = string.Format("LadeAssignmentID_bint={0}", _LaKey.LadeAssignmentID_bint.Value);
                    LadeAssignmentFactory.SelectRemainedDetailSelectByCondition(condition, remainedLadeAssignmentTable);
                    int remaindCount_int = 0;
                    if (remainedLadeAssignmentTable != null && remainedLadeAssignmentTable.Rows.Count > 0)
                    {
                        remaindCount_int = (Int32)remainedLadeAssignmentTable.Rows[remainedLadeAssignmentTable.Rows.Count - 1]["RemainderCount_int"];
                    }
                    LadBillCreditFactory.Update(LadBillCreditEntity, this._Key);
                    LadeCancelAssignmentEntity.LadeAssignmentID_bint = _LaKey.LadeAssignmentID_bint.Value;
                    LadeCancelAssignmentEntity.LadeCancelCommentID_int = 6;
                    LadeCancelAssignmentEntity.LadeCancelComment_nvc = "ابطال اطلاع رسانی بار هنگام ابطال مجوز";
                    LadeCancelAssignmentEntity.Count_int = remaindCount_int + 1;
                    LadeCancelAssignmentEntity.Date_nvc = LadeCancelAssignmentFactory.ServerJalaliDate;
                    LadeCancelAssignmentEntity.Time_nvc = LadeCancelAssignmentFactory.ServerTime;
                    LadeCancelAssignmentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    LadeCancelAssignmentFactory.Insert(LadeCancelAssignmentEntity);
                }
                else
                {
                    LadBillCreditFactory.Update(LadBillCreditEntity, this._Key);
                }

                //ابطال مجوز 

                for (int index = 0; index < this.LadBillCreditCancelCommentID_intCheckedListBox.CheckedItems.Count; index++)
                {
                    HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T LadBillCreditCancelCommentEntity = new HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T();
                    LadBillCreditCancelCommentEntity.LadBillCreditID_int = this._Key.LadBillCreditID_int;
                    LadBillCreditCancelCommentEntity.LadBillCancelCommentID_int = ((HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T)this.LadBillCreditCancelCommentID_intCheckedListBox.CheckedItems[index]).LadBillCancelCommentID_int;
                    LadBillCreditCancelCommentEntity.LadbillCancelComment_nvc = ((HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T)this.LadBillCreditCancelCommentID_intCheckedListBox.CheckedItems[index]).LadbillCancelComment_nvc;
                    LadBillCreditCancelCommentFactory.Insert(LadBillCreditCancelCommentEntity);
                }

                LadBillCreditFactory.CommitProc();

                if (this._dataTable != null)
                {
                    DataRow[] dr = this._dataTable.Select(string.Format("LadBillCreditID_int = {0}", this._Key.LadBillCreditID_int));
                    if (dr != null && dr.Length > 0)
                        dr[0]["Canceled_bit"] = true;
                    this._dataTable.AcceptChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                LadBillCreditFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }


        private void LoadCheckListBox()
        {
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();
            DataTable LadBillCreditCancelDataTable = new DataTable();
            try
            {
                this.LadBillCreditCancelCommentID_intCheckedListBox.Items.Clear();

                List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> lst = LadBillCancelCommentFactory.GetAll();
                if (lst != null && lst.Count > 0)
                    foreach (HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T itm in lst)
                        this.LadBillCreditCancelCommentID_intCheckedListBox.Items.Add(itm, false);
                this.LadBillCreditCancelCommentID_intCheckedListBox.DisplayMember = HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadbillCancelComment_nvc.ToString();
                this.LadBillCreditCancelCommentID_intCheckedListBox.ValueMember = HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadBillCancelCommentID_int.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
