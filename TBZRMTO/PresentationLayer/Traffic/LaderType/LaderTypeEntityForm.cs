using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LaderType
{
    public partial class LaderTypeEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public LaderTypeEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public LaderTypeEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void LaderTypeEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = LaderTypeFactory.GetBy((HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys)Key);
            if (LaderTypeEntity == null)
            {
                throw new HPS.Exceptions.LaderTypeNotFound();
            }
            LaderTypeCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeEntity.LaderTypeCode_nvc, TypeCode.String).ToString();
            LaderType_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeEntity.LaderType_nvc, TypeCode.String).ToString();
            MinTruckWeight_decNumericTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeEntity.MinTruckWeight_dec, TypeCode.Decimal));
            MaxTruckWeight_decNumericTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeEntity.MaxTruckWeight_dec, TypeCode.Decimal));
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeEntity.Active_bit, TypeCode.Boolean);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderPivotGroupID_intComboBox, LaderTypeEntity.LaderPivotGroupID_int, TypeCode.Int32);
            TurnCancelCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeEntity.TurnCancel_bit, TypeCode.Boolean);
        }

        protected override void Insert()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                LaderTypeEntity.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();
                LaderTypeEntity.LaderType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderType_nvcTextBox.Text, TypeCode.String).ToString();
                LaderTypeEntity.MinTruckWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MinTruckWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LaderTypeEntity.MaxTruckWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MaxTruckWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LaderTypeEntity.Active_bit = Active_bitCheckBox.Checked;
                LaderTypeEntity.LaderPivotGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                LaderTypeEntity.TurnCancel_bit = TurnCancelCheckBox.Checked;

                LaderTypeFactory.BeginProc();
                LaderTypeFactory.Insert(LaderTypeEntity);
                LaderTypeFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.LaderTypeID_int, TypeCode.Int32);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.LaderTypeCode_nvc, TypeCode.String);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.LaderType_nvc, TypeCode.String);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MinTruckWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.MinTruckWeight_dec, TypeCode.Decimal);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MaxTruckWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.MaxTruckWeight_dec, TypeCode.Decimal);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.Active_bit, TypeCode.Boolean);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.SaloonID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.SaloonID_int, TypeCode.Int32);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderPivotGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.LaderPivotGroupID_int, TypeCode.Int32);
                    dr["LaderPivotGroupID_intLaderPivotGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderPivotGroupID_intComboBox);
                    dr[HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.TurnCancel_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.TurnCancel_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                LaderTypeFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                LaderTypeEntity.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();
                LaderTypeEntity.LaderType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderType_nvcTextBox.Text, TypeCode.String).ToString();
                LaderTypeEntity.MinTruckWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MinTruckWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LaderTypeEntity.MaxTruckWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MaxTruckWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LaderTypeEntity.Active_bit = Active_bitCheckBox.Checked;
                LaderTypeEntity.LaderPivotGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                LaderTypeEntity.TurnCancel_bit = TurnCancelCheckBox.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    LaderTypeFactory.BeginProc();
                    LaderTypeFactory.Update(LaderTypeEntity, (HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys)Key);
                    LaderTypeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString() + "='" + ((HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys)Key).LaderTypeID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.LaderTypeCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.LaderType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MinTruckWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.MinTruckWeight_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MaxTruckWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.MaxTruckWeight_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.Active_bit, TypeCode.Boolean);
                            dr[0]["LaderPivotGroupID_intLaderPivotGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderPivotGroupID_intComboBox);
                            dr[0][HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.TurnCancel_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderTypeEntity.TurnCancel_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                LaderTypeFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    LaderTypeFactory.BeginProc();
                    LaderTypeFactory.Delete((HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys)Key);
                    LaderTypeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString() + "='" + ((HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys)Key).LaderTypeID_int.ToString() + "'");
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
                LaderTypeFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupID_intFactory = new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
                DataTable LaderPivotGroupID_intDataTable = new DataTable();
                LaderPivotGroupID_intFactory.GetAll(ref LaderPivotGroupID_intDataTable);
                this.LaderPivotGroupID_intComboBox.DisplayMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString();
                this.LaderPivotGroupID_intComboBox.ValueMember = HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString();
                this.LaderPivotGroupID_intComboBox.DataSource = LaderPivotGroupID_intDataTable;
                this.LaderPivotGroupID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LaderPivotGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.LaderPivotGroup.LaderPivotGroupEntityForm frm = new HPS.Present.LaderPivotGroup.LaderPivotGroupEntityForm((DataTable)LaderPivotGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }



    }
}