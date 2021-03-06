using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.InfractionType
{
    public partial class InfractionTypeEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public InfractionTypeEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public InfractionTypeEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void InfractionTypeEntityForm_Load(object sender, EventArgs e)
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

        protected override void ShowForm()
        {
            this.FillCombo();
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_T InfractionTypeEntity = InfractionTypeFactory.GetBy((HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys)Key);
            if (InfractionTypeEntity == null)
            {
                throw new HPS.Exceptions.InfractionTypeNotFound();
            }
            InfractionType_nvcTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionTypeEntity.InfractionType_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionGroupID_intComboBox, InfractionTypeEntity.InfractionGroupID_int, TypeCode.Int32);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionSurveyGroupID_intComboBox, InfractionTypeEntity.InfractionSurveyGroupID_int, TypeCode.Int32);
            PenaltyFee_decNumericTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionTypeEntity.PenaltyFee_dec, TypeCode.Decimal));
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionTypeEntity.Active_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
            try
            {
                HPS.BLL.InfractionTypeBLL.BLLInfractionType_T InfractionTypeEntity = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_T();
                InfractionTypeEntity.InfractionType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionType_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionTypeEntity.InfractionGroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                InfractionTypeEntity.InfractionSurveyGroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                InfractionTypeEntity.PenaltyFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(PenaltyFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                InfractionTypeEntity.Date_nvc = InfractionTypeFactory.ServerJalaliDate;
                InfractionTypeEntity.Time_nvc = InfractionTypeFactory.ServerTime;
                InfractionTypeEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                InfractionTypeEntity.Active_bit = Active_bitCheckBox.Checked;


                string condition = "InfractionType_T.InfractionType_nvc=N'" + InfractionTypeEntity.InfractionType_nvc + "' AND InfractionType_T.InfractionGroupID_int='" + InfractionTypeEntity .InfractionGroupID_int+ "'";
                List<HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> InfractionTypeList = InfractionTypeFactory.GetAllByCondition(condition);
                if (InfractionTypeList!=null && InfractionTypeList.Count>0)
                {
                    throw new ApplicationException("این نوع تخلف قبلاً ثبت شده است");
                }

                InfractionTypeFactory.BeginProc();
                InfractionTypeFactory.Insert(InfractionTypeEntity);
                InfractionTypeFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.InfractionTypeID_int, TypeCode.Int32);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.InfractionType_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.InfractionGroupID_int, TypeCode.Int32);
                    dr["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionSurveyGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.InfractionSurveyGroupID_int, TypeCode.Int32);
                    dr["InfractionSurveyGroupID_intInfractionSurveyGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionSurveyGroupID_intComboBox);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.PenaltyFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.PenaltyFee_dec, TypeCode.Decimal);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.Time_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.Active_bit, TypeCode.Boolean);
                    dr[HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.UserName_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                InfractionTypeFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
            try
            {
                HPS.BLL.InfractionTypeBLL.BLLInfractionType_T InfractionTypeEntity = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_T();
                InfractionTypeEntity.InfractionType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionType_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionTypeEntity.InfractionGroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                InfractionTypeEntity.InfractionSurveyGroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                InfractionTypeEntity.PenaltyFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(PenaltyFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                InfractionTypeEntity.Date_nvc = InfractionTypeFactory.ServerJalaliDate;
                InfractionTypeEntity.Time_nvc = InfractionTypeFactory.ServerTime;
                InfractionTypeEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                InfractionTypeEntity.Active_bit = Active_bitCheckBox.Checked;

                string condition = "InfractionType_T.InfractionType_nvc=N'" + InfractionTypeEntity.InfractionType_nvc + "' AND InfractionType_T.InfractionGroupID_int='" + InfractionTypeEntity.InfractionGroupID_int + "' AND InfractionType_T.InfractionTypeID_int <> '" + ((HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys)Key).InfractionTypeID_int + "'";
                List<HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> InfractionTypeList = InfractionTypeFactory.GetAllByCondition(condition);
                if (InfractionTypeList != null && InfractionTypeList.Count > 0)
                {
                    throw new ApplicationException("این نوع تخلف قبلاً ثبت شده است");
                } 

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    

                    InfractionTypeFactory.BeginProc();
                    InfractionTypeFactory.Update(InfractionTypeEntity, (HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys)Key);
                    InfractionTypeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString() + "='" + ((HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys)Key).InfractionTypeID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.InfractionType_nvc, TypeCode.String);
                            dr[0]["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                            dr[0]["InfractionSurveyGroupID_intInfractionSurveyGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionSurveyGroupID_intComboBox);
                            dr[0][HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.PenaltyFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.PenaltyFee_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.Time_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionTypeEntity.Active_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                InfractionTypeFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    InfractionTypeFactory.BeginProc();
                    InfractionTypeFactory.Delete((HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys)Key);
                    InfractionTypeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString() + "='" + ((HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys)Key).InfractionTypeID_int.ToString() + "'");
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
                InfractionTypeFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupID_intFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
                string condition = "[InfractionGroup_T].[Active_bit]='true'";
                DataTable InfractionGroupID_intDataTable = new DataTable();
                InfractionGroupID_intFactory.GetAllByCondition(condition,ref InfractionGroupID_intDataTable);
                this.InfractionGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString();
                this.InfractionGroupID_intComboBox.ValueMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.DataSource = InfractionGroupID_intDataTable;
                this.InfractionGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupID_intFactory = new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
                DataTable InfractionSurveyGroupID_intDataTable = new DataTable();
                InfractionSurveyGroupID_intFactory.GetAll(ref InfractionSurveyGroupID_intDataTable);
                this.InfractionSurveyGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroup_nvc.ToString();
                this.InfractionSurveyGroupID_intComboBox.ValueMember = HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString();
                this.InfractionSurveyGroupID_intComboBox.DataSource = InfractionSurveyGroupID_intDataTable;
                this.InfractionSurveyGroupID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InfractionGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionGroup.InfractionGroupEntityForm frm = new HPS.Present.InfractionGroup.InfractionGroupEntityForm((DataTable)InfractionGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void InfractionSurveyGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionSurveyGroup.InfractionSurveyGroupEntityForm frm = new HPS.Present.InfractionSurveyGroup.InfractionSurveyGroupEntityForm((DataTable)InfractionSurveyGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }



    }
}