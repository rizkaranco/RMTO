using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Bill
{
    public partial class BillEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public BillEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public BillEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.BillBLL.BLLBill_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void BillEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.BillBLL.BLLBill_TFactory BillFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            HPS.BLL.BillBLL.BLLBill_T BillEntity = BillFactory.GetBy((HPS.BLL.BillBLL.BLLBill_TKeys)Key);
            if (BillEntity == null)
            {
                throw new HPS.Exceptions.BillNotFound();
            }
            BillType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(BillEntity.BillType_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref TrafficTypeID_intComboBox, BillEntity.TrafficTypeID_int, TypeCode.Int32);

        }

        protected override void Insert()
        {
            HPS.BLL.BillBLL.BLLBill_TFactory BillFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            try
            {
                HPS.BLL.BillBLL.BLLBill_T BillEntity = new HPS.BLL.BillBLL.BLLBill_T();
                BillEntity.BillType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BillType_nvcTextBox.Text, TypeCode.String).ToString();
                BillEntity.TrafficTypeID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.Int32);

                BillFactory.BeginProc();
                BillFactory.Insert(BillEntity);
                BillFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillEntity.BillID_int, TypeCode.Int32);
                    dr[HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillEntity.BillType_nvc, TypeCode.String);
                    dr[HPS.BLL.BillBLL.BLLBill_T.Bill_TField.TrafficTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillEntity.TrafficTypeID_int, TypeCode.Int32);
                    dr["TrafficTypeID_intTrafficType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(TrafficTypeID_intComboBox);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                BillFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.BillBLL.BLLBill_TFactory BillFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            try
            {
                HPS.BLL.BillBLL.BLLBill_T BillEntity = new HPS.BLL.BillBLL.BLLBill_T();
                BillEntity.BillType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BillType_nvcTextBox.Text, TypeCode.String).ToString();
                BillEntity.TrafficTypeID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.Int32);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    BillFactory.BeginProc();
                    BillFactory.Update(BillEntity, (HPS.BLL.BillBLL.BLLBill_TKeys)Key);
                    BillFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillID_int.ToString() + "='" + ((HPS.BLL.BillBLL.BLLBill_TKeys)Key).BillID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillEntity.BillType_nvc, TypeCode.String);
                            dr[0]["TrafficTypeID_intTrafficType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(TrafficTypeID_intComboBox);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                BillFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.BillBLL.BLLBill_TFactory BillFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    BillFactory.BeginProc();
                    BillFactory.Delete((HPS.BLL.BillBLL.BLLBill_TKeys)Key);
                    BillFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillID_int.ToString() + "='" + ((HPS.BLL.BillBLL.BLLBill_TKeys)Key).BillID_int.ToString() + "'");
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
                BillFactory.RollBackProc();
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


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}