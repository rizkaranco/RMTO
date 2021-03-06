using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.StopFee
{
    public partial class StopFeeEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public StopFeeEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public StopFeeEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.StopFeeBLL.BLLStopFee_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void StopFeeEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                    this.FillCombo();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private string start = string.Empty;
        private string end = string.Empty;
        protected override void ShowForm()
        {
            this.FillCombo();
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            HPS.BLL.StopFeeBLL.BLLStopFee_T StopFeeEntity = StopFeeFactory.GetBy((HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key);
            if (StopFeeEntity == null)
            {
                throw new HPS.Exceptions.StopFeeNotFound();
            }

            List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeDateList = StopFeeFactory.GetAllBy(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StopFeeID_int, ((HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key).StopFeeID_int);
            if (StopFeeDateList != null && StopFeeDateList.Count > 0)
            {
                DateTime startDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(StopFeeDateList[0].StartDate_nvc)).MyDate.ToString("yyyy/MM/dd"));
                DateTime startDateNow = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(StartDate_nvcTextBox.Text)).MyDate.ToString("yyyy/MM/dd"));
                DateTime endDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(StopFeeDateList[0].EndDate_nvc)).MyDate.ToString("yyyy/MM/dd"));
                DateTime endDateNow = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(EndDate_nvcTextBox.Text)).MyDate.ToString("yyyy/MM/dd"));
                DateTime DateServer = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(StopFeeFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd"));
                if ((DateServer >= startDate) || DateServer >= endDate)
                {
                    StartDate_nvcTextBox.Enabled = false;
                    Fee_decNumericTextBox.Enabled = false;
                    AllowedHoure_intNumericTextBox.Enabled = false;
                    ExtraHour_intNumericTextBox.Enabled = false;
                    ExtraHourFee_decNumericTextBox.Enabled = false;
                    TrafficTypeID_intComboBox.Enabled = false;
                    TrafficTypeID_intNewButton.Enabled = false;
                    LaderPivotGroupID_intComboBox.Enabled = false;
                    LaderPivotGroupID_intNewButton.Enabled = false;
                    WithLadeExtraHourFee_decNumericTextBox.Enabled = false;
                    ServicesID_intComboBox.Enabled = false;
                }
                if (DateServer >= endDate)
                {
                    EndDate_nvcTextBox.Enabled = false;
                }
            }

            AllowedHoure_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.AllowedHoure_int, TypeCode.Int32).ToString();
            Fee_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.Fee_dec, TypeCode.Decimal).ToString();
            ExtraHour_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.ExtraHour_int, TypeCode.Int32).ToString();
            ExtraHourFee_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.ExtraHourFee_dec, TypeCode.Decimal));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref TrafficTypeID_intComboBox, StopFeeEntity.TrafficTypeID_int, TypeCode.Int32);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderPivotGroupID_intComboBox, StopFeeEntity.LaderPivotGroupID_int, TypeCode.Int32);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, StopFeeEntity.ServicesID_int,TypeCode.Int32);
            StartDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.StartDate_nvc, TypeCode.String).ToString();
            EndDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.EndDate_nvc, TypeCode.String).ToString();
            WithLadeExtraHourFee_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.WithLadeExtraHourFee_dec, TypeCode.Decimal));
            start = StopFeeEntity.StartDate_nvc;
            end = StopFeeEntity.EndDate_nvc;
            Tax_bitcheckBox.Checked = StopFeeEntity.Tax_bit;
            TurnNotLadBillExtraHour_intTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.TurnNotLadBillExtraHour_int, TypeCode.Int32).ToString();
            TurnNotLadBillExtraHourFee_decTextBox.Text =Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeEntity.TurnNotLadBillExtraHourFee_dec, TypeCode.Decimal).ToString();

        }

        protected override void Insert()
        {
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            try
            {
                HPS.BLL.StopFeeBLL.BLLStopFee_T StopFeeEntity = new HPS.BLL.StopFeeBLL.BLLStopFee_T();
                StopFeeEntity.AllowedHoure_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(AllowedHoure_intNumericTextBox.NumericText, TypeCode.Int32);
                StopFeeEntity.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(Fee_decNumericTextBox.NumericText, TypeCode.Decimal);
                StopFeeEntity.ExtraHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ExtraHour_intNumericTextBox.NumericText, TypeCode.Int32);
                StopFeeEntity.ExtraHourFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(ExtraHourFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                StopFeeEntity.WithLadeExtraHourFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(WithLadeExtraHourFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                StopFeeEntity.TrafficTypeID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                StopFeeEntity.LaderPivotGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                StopFeeEntity.ServicesID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesID_intComboBox.SelectedValue, TypeCode.Int32);
                StopFeeEntity.Tax_bit = Tax_bitcheckBox.Checked;
                StopFeeEntity.TurnNotLadBillExtraHour_int= (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNotLadBillExtraHour_intTextBox.Text, TypeCode.Int32);
                StopFeeEntity.TurnNotLadBillExtraHourFee_dec= (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNotLadBillExtraHourFee_decTextBox.NumericText, TypeCode.Decimal);
                if (StartDate_nvcTextBox.Enabled && StartDate_nvcTextBox.Text.CompareTo(StopFeeFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ شروع نمی تواند کوچکتر از تاریخ جاری باشد");
                }

                if (EndDate_nvcTextBox.Enabled && EndDate_nvcTextBox.Text.CompareTo(StopFeeFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ اتمام نمی تواند کوچکتر از تاریخ جاری باشد");
                }//, StopFeeEntity.ServicesID_int.HasValue ? StopFeeEntity.ServicesID_int.ToString() : "NULL"  AND StopFee_T.ServicesID_int='{3}'
                string Condition = string.Empty;
                if (StopFeeEntity.WithLadeExtraHourFee_dec.HasValue==false)
                {
                    Condition = string.Format("StopFee_T.TrafficTypeID_int='{0}' And StopFee_T.LaderPivotGroupID_int='{1}' AND StopFee_T.WithLadeExtraHourFee_dec is NULL ", StopFeeEntity.TrafficTypeID_int, StopFeeEntity.LaderPivotGroupID_int);
                }
                else
                {
                    Condition = string.Format("StopFee_T.TrafficTypeID_int='{0}' And StopFee_T.LaderPivotGroupID_int='{1}' AND StopFee_T.WithLadeExtraHourFee_dec is not null ", StopFeeEntity.TrafficTypeID_int, StopFeeEntity.LaderPivotGroupID_int);
                }
                if (StopFeeEntity.ExtraHourFee_dec.HasValue)
                {
                    Condition += string.Format(" AND StopFee_T.ExtraHourFee_dec IS NOT Null");
                }
                else
                {
                    Condition += string.Format(" AND StopFee_T.ExtraHourFee_dec Is Null ");
                }
                if (StopFeeEntity.ServicesID_int.HasValue == false)
                {
                    Condition += " AND StopFee_T.ServicesID_int Is Null";
                }
                else
                {
                    Condition += string.Format(" AND StopFee_T.ServicesID_int={0}", StopFeeEntity.ServicesID_int);
                }
              
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeDateList = StopFeeFactory.GetAllByCondition(Condition);
                if (StopFeeDateList != null && StopFeeDateList.Count > 0)
                {
                    foreach (HPS.BLL.StopFeeBLL.BLLStopFee_T item in StopFeeDateList)
                    {
                        if (!(StartDate_nvcTextBox.Text.CompareTo(item.EndDate_nvc) > 0 || EndDate_nvcTextBox.Text.CompareTo(item.StartDate_nvc) < 0))
                        {
                            throw new ApplicationException("براي تاريخ وارد شده حق پاركينگ تعريف شده است");
                        }
                    }
                }

                StopFeeEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                StopFeeEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
                StopFeeEntity.Date_nvc = StopFeeFactory.ServerJalaliDate;
                StopFeeEntity.Time_nvc = StopFeeFactory.ServerTime;
                StopFeeEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                StopFeeFactory.BeginProc();
                StopFeeFactory.Insert(StopFeeEntity);
                StopFeeFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StopFeeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.StopFeeID_int, TypeCode.Int32);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.AllowedHoure_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.AllowedHoure_int, TypeCode.Int32);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Fee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.Fee_dec, TypeCode.Decimal);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHour_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.ExtraHour_int, TypeCode.Int32);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHourFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.ExtraHourFee_dec, TypeCode.Decimal);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TrafficTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.TrafficTypeID_int, TypeCode.Int32);
                    dr["TrafficTypeID_intTrafficType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(TrafficTypeID_intComboBox);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.LaderPivotGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.LaderPivotGroupID_int, TypeCode.Int32);
                    dr["LaderPivotGroupID_intLaderPivotGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderPivotGroupID_intComboBox);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.StartDate_nvc, TypeCode.String);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.EndDate_nvc, TypeCode.String);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.Time_nvc, TypeCode.String);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.UserName_nvc, TypeCode.String);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.WithLadeExtraHourFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.WithLadeExtraHourFee_dec, TypeCode.Decimal);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ServicesID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.ServicesID_int, TypeCode.Int32);
                    dr["ServicesID_intServicesType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(ServicesID_intComboBox);
                    dr["Tax_bit"] = Hepsa.Core.Common.PersentationController.GetCheckBoxValue(Tax_bitcheckBox.Checked);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHour_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.TurnNotLadBillExtraHour_int, TypeCode.Int32);
                    dr[HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHourFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.TurnNotLadBillExtraHourFee_dec, TypeCode.Decimal);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                StopFeeFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            try
            {
                HPS.BLL.StopFeeBLL.BLLStopFee_T StopFeeEntity = new HPS.BLL.StopFeeBLL.BLLStopFee_T();
                StopFeeEntity.AllowedHoure_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(AllowedHoure_intNumericTextBox.NumericText, TypeCode.Int32);
                StopFeeEntity.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(Fee_decNumericTextBox.NumericText, TypeCode.Decimal);
                StopFeeEntity.ExtraHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ExtraHour_intNumericTextBox.NumericText, TypeCode.Int32);
                StopFeeEntity.ExtraHourFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(ExtraHourFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                StopFeeEntity.TrafficTypeID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                StopFeeEntity.LaderPivotGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                StopFeeEntity.ServicesID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesID_intComboBox.SelectedValue, TypeCode.Int32);
                StopFeeEntity.Tax_bit = Tax_bitcheckBox.Checked;
                if (StartDate_nvcTextBox.Enabled && StartDate_nvcTextBox.Text.CompareTo(StopFeeFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ شروع نمی تواند کوچکتر از تاریخ جاری باشد");
                }

                if (EndDate_nvcTextBox.Enabled && EndDate_nvcTextBox.Text.CompareTo(StopFeeFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ اتمام نمی تواند کوچکتر از تاریخ جاری باشد");
                }
                string Condition = string.Format("StopFee_T.TrafficTypeID_int='{0}' And StopFee_T.LaderPivotGroupID_int='{1}' And StopFee_T.StopFeeID_int<>{2} AND StopFee_T.WithLadeExtraHourFee_dec={3}  AND StopFee_T.ServicesID_int={4}", StopFeeEntity.TrafficTypeID_int, StopFeeEntity.LaderPivotGroupID_int, ((HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key).StopFeeID_int.ToString(), StopFeeEntity.WithLadeExtraHourFee_dec.HasValue ? StopFeeEntity.WithLadeExtraHourFee_dec.ToString() : "NULL",StopFeeEntity.ServicesID_int.HasValue?StopFeeEntity.ServicesID_int.ToString():"NULL");
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeDateList = StopFeeFactory.GetAllByCondition(Condition);
                if (StopFeeDateList != null && StopFeeDateList.Count > 0)
                {
                    foreach (HPS.BLL.StopFeeBLL.BLLStopFee_T item in StopFeeDateList)
                    {
                        if (!(StartDate_nvcTextBox.Text.CompareTo(item.EndDate_nvc) > 0 || EndDate_nvcTextBox.Text.CompareTo(item.StartDate_nvc) < 0))
                        {
                            throw new ApplicationException("براي تاريخ وارد شده حق پاركينگ تعريف شده است");
                        }
                    }
                }
                StopFeeEntity.TurnNotLadBillExtraHour_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNotLadBillExtraHour_intTextBox.Text, TypeCode.Int32);
                StopFeeEntity.TurnNotLadBillExtraHourFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNotLadBillExtraHourFee_decTextBox.NumericText, TypeCode.Decimal);

                StopFeeEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                StopFeeEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
                StopFeeEntity.Date_nvc = StopFeeFactory.ServerJalaliDate;
                StopFeeEntity.Time_nvc = StopFeeFactory.ServerTime;
                StopFeeEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                StopFeeEntity.WithLadeExtraHourFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(WithLadeExtraHourFee_decNumericTextBox.NumericText, TypeCode.Decimal);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    StopFeeFactory.BeginProc();
                    StopFeeFactory.Update(StopFeeEntity, (HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key);
                    StopFeeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StopFeeID_int.ToString() + "='" + ((HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key).StopFeeID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.AllowedHoure_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.AllowedHoure_int, TypeCode.Int32);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Fee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.Fee_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHour_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.ExtraHour_int, TypeCode.Int32);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHourFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.ExtraHourFee_dec, TypeCode.Decimal);
                            dr[0]["TrafficTypeID_intTrafficType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(TrafficTypeID_intComboBox);
                            dr[0]["LaderPivotGroupID_intLaderPivotGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderPivotGroupID_intComboBox);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.StartDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.EndDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.Time_nvc, TypeCode.String);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.WithLadeExtraHourFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.WithLadeExtraHourFee_dec, TypeCode.Decimal);
                            dr[0]["ServicesID_intServicesType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(ServicesID_intComboBox);
                            dr[0]["Tax_bit"] = Hepsa.Core.Common.PersentationController.GetCheckBoxValue(Tax_bitcheckBox.Checked);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHour_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.TurnNotLadBillExtraHour_int, TypeCode.Int32);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHourFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(StopFeeEntity.TurnNotLadBillExtraHourFee_dec, TypeCode.Decimal);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                StopFeeFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    StopFeeFactory.BeginProc();
                    StopFeeFactory.Delete((HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key);
                    StopFeeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StopFeeID_int.ToString() + "='" + ((HPS.BLL.StopFeeBLL.BLLStopFee_TKeys)Key).StopFeeID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0].Delete();
                        }
                        DataTable.AcceptChanges();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                StopFeeFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeID_intFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
                DataTable TrafficTypeID_intDataTable = new DataTable();
                TrafficTypeID_intFactory.GetAll(ref TrafficTypeID_intDataTable);
                this.TrafficTypeID_intComboBox.DisplayMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString();
                this.TrafficTypeID_intComboBox.ValueMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString();
                this.TrafficTypeID_intComboBox.DataSource = TrafficTypeID_intDataTable;
                this.TrafficTypeID_intComboBox.SelectedIndex = -1;
               
                
                HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupID_intFactory = new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
                DataTable LaderPivotGroupID_intDataTable = new DataTable();
                LaderPivotGroupID_intFactory.GetAll(ref LaderPivotGroupID_intDataTable);
                this.LaderPivotGroupID_intComboBox.DisplayMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString();
                this.LaderPivotGroupID_intComboBox.ValueMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString();
                this.LaderPivotGroupID_intComboBox.DataSource = LaderPivotGroupID_intDataTable;
                this.LaderPivotGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesID_intFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
                DataTable ServicesID_intDataTable = new DataTable();
                ServicesID_intFactory.GetAll(ref ServicesID_intDataTable);
                this.ServicesID_intComboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
                this.ServicesID_intComboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
                this.ServicesID_intComboBox.DataSource = ServicesID_intDataTable;
                this.ServicesID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TrafficTypeID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.TrafficType.TrafficTypeEntityForm frm = new HPS.Present.TrafficType.TrafficTypeEntityForm((DataTable)TrafficTypeID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void LaderPivotGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.LaderPivotGroup.LaderPivotGroupEntityForm frm = new HPS.Present.LaderPivotGroup.LaderPivotGroupEntityForm((DataTable)LaderPivotGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void ServicesID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Services.ServicesEntityForm frm = new HPS.Present.Services.ServicesEntityForm((DataTable)ServicesID_intComboBox.DataSource);
            frm.ShowDialog();
        }

    }
}