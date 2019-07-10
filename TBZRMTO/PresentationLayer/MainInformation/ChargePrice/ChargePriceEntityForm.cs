using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.ChargePrice
{
    public partial class ChargePriceEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public ChargePriceEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public ChargePriceEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void ChargePriceEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePriceFactory = new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();
            HPS.BLL.ChargePriceBLL.BLLChargePrice_T ChargePriceEntity = ChargePriceFactory.GetBy((HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys)Key);
            if (ChargePriceEntity == null)
            {
                throw new HPS.Exceptions.ChargePriceNotFound();
            }
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref DriverID_bintComboBox, ChargePriceEntity.DriverID_bint, TypeCode.Int64);
            DriverName_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.DriverName_nvc, TypeCode.String).ToString();
            DriverCardNumber_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.DriverCardNumber_nvc, TypeCode.String).ToString();
            Price_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.Price_dec, TypeCode.Decimal).ToString();
            Date_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.Date_nvc, TypeCode.String).ToString();
            Time_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.Time_nvc, TypeCode.String).ToString();
            UserName_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.UserName_nvc, TypeCode.String).ToString();
            Description_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ChargePriceEntity.Description_nvc, TypeCode.String).ToString();

        }

        protected override void Insert()
        {
            HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePriceFactory = new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();
            try
            {
                HPS.BLL.ChargePriceBLL.BLLChargePrice_T ChargePriceEntity = new HPS.BLL.ChargePriceBLL.BLLChargePrice_T();
                ChargePriceEntity.DriverID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverID_bintComboBox.SelectedValue, TypeCode.Int64);
                ChargePriceEntity.DriverName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverName_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.Price_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(Price_decNumericTextBox.NumericText, TypeCode.Decimal);
                ChargePriceEntity.Date_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Date_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.Time_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Time_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.UserName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UserName_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.Description_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Description_nvcTextBox.Text, TypeCode.String).ToString();

                ChargePriceFactory.BeginProc();
                ChargePriceFactory.Insert(ChargePriceEntity);
                ChargePriceFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.ChargePriceID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.ChargePriceID_int, TypeCode.Int32);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.DriverID_bint, TypeCode.Int64);
                    dr["DriverID_bintFirstName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(DriverID_bintComboBox);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.DriverName_nvc, TypeCode.String);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.DriverCardNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Price_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Price_dec, TypeCode.Decimal);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Time_nvc, TypeCode.String);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.UserName_nvc, TypeCode.String);
                    dr[HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Description_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Description_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                ChargePriceFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePriceFactory = new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();
            try
            {
                HPS.BLL.ChargePriceBLL.BLLChargePrice_T ChargePriceEntity = new HPS.BLL.ChargePriceBLL.BLLChargePrice_T();
                ChargePriceEntity.DriverID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverID_bintComboBox.SelectedValue, TypeCode.Int64);
                ChargePriceEntity.DriverName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverName_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.Price_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(Price_decNumericTextBox.NumericText, TypeCode.Decimal);
                ChargePriceEntity.Date_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Date_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.Time_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Time_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.UserName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UserName_nvcTextBox.Text, TypeCode.String).ToString();
                ChargePriceEntity.Description_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Description_nvcTextBox.Text, TypeCode.String).ToString();

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    ChargePriceFactory.BeginProc();
                    ChargePriceFactory.Update(ChargePriceEntity, (HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys)Key);
                    ChargePriceFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.ChargePriceID_int.ToString() + "='" + ((HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys)Key).ChargePriceID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["DriverID_bintFirstName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(DriverID_bintComboBox);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.DriverName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.DriverCardNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Price_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Price_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Time_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.UserName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Description_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ChargePriceEntity.Description_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                ChargePriceFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePriceFactory = new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    ChargePriceFactory.BeginProc();
                    ChargePriceFactory.Delete((HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys)Key);
                    ChargePriceFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.ChargePriceID_int.ToString() + "='" + ((HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys)Key).ChargePriceID_int.ToString() + "'");
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
                ChargePriceFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverID_bintFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DataTable DriverID_bintDataTable = new DataTable();
                DriverID_bintFactory.GetAll(ref DriverID_bintDataTable);
                this.DriverID_bintComboBox.DisplayMember = HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.FirstName_nvc.ToString();
                this.DriverID_bintComboBox.ValueMember = HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverID_bint.ToString();
                this.DriverID_bintComboBox.DataSource = DriverID_bintDataTable;
                this.DriverID_bintComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DriverID_bintNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Driver.DriverEntityForm frm = new HPS.Present.Driver.DriverEntityForm((DataTable)DriverID_bintComboBox.DataSource);
            frm.ShowDialog();
        }



    }
}