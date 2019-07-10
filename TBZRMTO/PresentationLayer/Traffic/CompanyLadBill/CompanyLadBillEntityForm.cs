using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.CompanyLadBill
{
    public partial class CompanyLadBillEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CompanyLadBillEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public CompanyLadBillEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void CompanyLadBillEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T CompanyLadBillEntity = CompanyLadBillFactory.GetBy((HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)Key);
            if (CompanyLadBillEntity == null)
            {
                throw new HPS.Exceptions.CompanyLadBillNotFound();
            }
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CompanyID_intComboBox, CompanyLadBillEntity.CompanyID_int, TypeCode.Int32);
            CompanyCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.CompanyCode_nvc, TypeCode.String));
            Date_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.Date_nvc, TypeCode.String));
            Serial_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.Serial_nvc, TypeCode.String));
            StartNumber_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.StartNumber_int, TypeCode.Int32).ToString();
            EndNumber_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.EndNumber_int, TypeCode.Int32).ToString();
            AssignmentNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.AssignmentNumber_nvc, TypeCode.String));
            DeliveryUserCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.DeliveryUserCode_nvc, TypeCode.String));

        }

        protected override void Insert()
        {
            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
            try
            {
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T CompanyLadBillEntity = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T();
                CompanyLadBillEntity.CompanyID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.Int32);
                CompanyLadBillEntity.CompanyCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyCode_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.Date_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Date_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.Serial_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Serial_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.StartNumber_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StartNumber_intNumericTextBox.NumericText, TypeCode.Int32);
                CompanyLadBillEntity.EndNumber_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(EndNumber_intNumericTextBox.NumericText, TypeCode.Int32);
                CompanyLadBillEntity.AssignmentNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(AssignmentNumber_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.DeliveryUserCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DeliveryUserCode_nvcTextBox.Text, TypeCode.String).ToString();

                CompanyLadBillFactory.BeginProc();
                CompanyLadBillFactory.Insert(CompanyLadBillEntity);
                CompanyLadBillFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyLadBillID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.CompanyLadBillID_bint, TypeCode.Int64);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.CompanyID_int, TypeCode.Int32);
                    dr["CompanyID_intCompany_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyID_intComboBox);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.CompanyCode_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Serial_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.Serial_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.StartNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.StartNumber_int, TypeCode.Int32);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.EndNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.EndNumber_int, TypeCode.Int32);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.AssignmentNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.AssignmentNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.DeliveryUserCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.DeliveryUserCode_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                CompanyLadBillFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
            try
            {
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T CompanyLadBillEntity = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T();
                CompanyLadBillEntity.CompanyID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.Int32);
                CompanyLadBillEntity.CompanyCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyCode_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.Date_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Date_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.Serial_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Serial_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.StartNumber_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StartNumber_intNumericTextBox.NumericText, TypeCode.Int32);
                CompanyLadBillEntity.EndNumber_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(EndNumber_intNumericTextBox.NumericText, TypeCode.Int32);
                CompanyLadBillEntity.AssignmentNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(AssignmentNumber_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyLadBillEntity.DeliveryUserCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DeliveryUserCode_nvcTextBox.Text, TypeCode.String).ToString();

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    CompanyLadBillFactory.BeginProc();
                    CompanyLadBillFactory.Update(CompanyLadBillEntity, (HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)Key);
                    CompanyLadBillFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyLadBillID_bint.ToString() + "='" + ((HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)Key).CompanyLadBillID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["CompanyID_intCompany_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyID_intComboBox);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.CompanyCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Serial_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.Serial_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.StartNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.StartNumber_int, TypeCode.Int32);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.EndNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.EndNumber_int, TypeCode.Int32);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.AssignmentNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.AssignmentNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.DeliveryUserCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyLadBillEntity.DeliveryUserCode_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                CompanyLadBillFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    CompanyLadBillFactory.BeginProc();
                    CompanyLadBillFactory.Delete((HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)Key);
                    CompanyLadBillFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyLadBillID_bint.ToString() + "='" + ((HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)Key).CompanyLadBillID_bint.ToString() + "'");
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
                CompanyLadBillFactory.RollBackProc();
                throw ex;
            }
        }
        DataTable CompanyID_intDataTable = new DataTable();
        private void FillCombo()
        {
            try
            {
                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();

                string CompanyCondition = "[Company_T].[Active_bit]='true'";
                CompanyID_intFactory.GetAllByCondition(CompanyCondition, ref CompanyID_intDataTable);
                DataRow Companydr = CompanyID_intDataTable.NewRow();
                Companydr["CompanyID_int"] = 0;
                CompanyID_intDataTable.Rows.InsertAt(Companydr, 0);
                this.CompanyID_intComboBox.DisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
                this.CompanyID_intComboBox.ValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
                this.CompanyID_intComboBox.DataSource = CompanyID_intDataTable;
                this.CompanyID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();
        private void CompanyID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CompanySearch frm = new HPS.Present.SearchForm.CompanySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CompanyEntity = frm.SelectedCompanyEntity;
                CompanyID_intComboBox.Text = frm.SelectedCompanyEntity.Company_nvc;
                CompanyCode_nvcTextBox.Text = frm.SelectedCompanyEntity.CompanyCode_nvc;
            }
        }

        private void CompanyID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CompanyID_intComboBox.SelectedIndex != -1)
            {

                CompanyEntity.CompanyID_int = (Int32)CompanyID_intComboBox.SelectedValue;
                CompanyEntity.Company_nvc = CompanyID_intDataTable.Rows[Convert.ToInt32(CompanyID_intComboBox.SelectedIndex)]["Company_nvc"].ToString();
                CompanyCode_nvcTextBox.Text = CompanyID_intDataTable.Rows[Convert.ToInt32(CompanyID_intComboBox.SelectedIndex)]["CompanyCode_nvc"].ToString();
            }
        }






    }
}