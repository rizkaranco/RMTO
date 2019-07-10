using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.VerifiedCars
{
    public partial class VerifiedCarsEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public VerifiedCarsEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public VerifiedCarsEntityForm(enmState State, DataTable DataTable, HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys Key)
           : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void VerifiedCarsEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                    this.FillCombo();


            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void ShowForm()
        {
            this.FillCombo();
            HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();
            BLL.VerifiedCarsBLL.BLLVerifiedCars_T VerifiedCarsEntity = VerifiedCarsFactory.GetBy((BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys)Key);
            //if (VerifiedCarsEntity == null)
            //{
            //    throw new TBZRMTO.Exception.VerifiedCarsNotFound();
            //}
            NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(VerifiedCarsEntity.NumberPlate_nvc, TypeCode.String));
            SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(VerifiedCarsEntity.SerialPlate_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CompanyID_intComboBox, VerifiedCarsEntity.CompanyID_int, TypeCode.Int32);
            FullName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(VerifiedCarsEntity.FullName_nvc, TypeCode.String));
            Unit_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(VerifiedCarsEntity.Unit_nvc, TypeCode.String));

        }

        protected override void Insert()
        {
            BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();

            try
            {
                BLL.VerifiedCarsBLL.BLLVerifiedCars_T VerifiedCarsEntity = new BLL.VerifiedCarsBLL.BLLVerifiedCars_T();
                VerifiedCarsEntity.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                VerifiedCarsEntity.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                VerifiedCarsEntity.CompanyID_int =Convert.ToInt32(CompanyID_intComboBox.SelectedValue);
                VerifiedCarsEntity.FullName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FullName_nvcTextBox.Text, TypeCode.String).ToString();
                VerifiedCarsEntity.Unit_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Unit_nvcTextBox.Text, TypeCode.String).ToString();

                VerifiedCarsFactory.BeginProc();
                VerifiedCarsFactory.Insert(VerifiedCarsEntity);
                VerifiedCarsFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.VerifiedCarID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.VerifiedCarID_int, TypeCode.Int32);
                    dr[BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.NumberPlate_nvc, TypeCode.String);
                    dr[BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.SerialPlate_nvc, TypeCode.String);
                    dr["Company_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyID_intComboBox);
                    dr[BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.FullName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.FullName_nvc, TypeCode.String);
                    dr[BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.Unit_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.Unit_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);


            }
            catch (System.Exception ex)
            {
                VerifiedCarsFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();

            try
            {
                BLL.VerifiedCarsBLL.BLLVerifiedCars_T VerifiedCarsEntity = VerifiedCarsFactory.GetBy((BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys)Key);
                //if (VerifiedCarsEntity == null)
                //    throw new TBZRMTO.Exception.VerifiedCarsNotFound();
                VerifiedCarsEntity.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                VerifiedCarsEntity.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                VerifiedCarsEntity.CompanyID_int = Convert.ToInt32(CompanyID_intComboBox.SelectedValue);
                VerifiedCarsEntity.FullName_nvc= Hepsa.Core.Common.PersentationController.GetEntityValue(FullName_nvcTextBox.Text, TypeCode.String).ToString();
                VerifiedCarsEntity.Unit_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Unit_nvcTextBox.Text, TypeCode.String).ToString();

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    VerifiedCarsFactory.BeginProc();
                    VerifiedCarsFactory.Update(VerifiedCarsEntity, (BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys)Key);
                    VerifiedCarsFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.VerifiedCarID_int.ToString() + "='" + ((BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys)Key).VerifiedCarID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.VerifiedCarID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.VerifiedCarID_int, TypeCode.Int32);
                            dr[0][BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.NumberPlate_nvc, TypeCode.String);
                            dr[0][BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.SerialPlate_nvc, TypeCode.String);
                            dr[0]["Company_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyID_intComboBox);
                            dr[0][BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.FullName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.FullName_nvc, TypeCode.String);
                            dr[0][BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.Unit_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(VerifiedCarsEntity.Unit_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (System.Exception ex)
            {
                VerifiedCarsFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    VerifiedCarsFactory.BeginProc();
                    VerifiedCarsFactory.Delete((BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys)Key);
                    VerifiedCarsFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.VerifiedCarID_int.ToString() + "='" + ((BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys)Key).VerifiedCarID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0].Delete();
                        }
                        DataTable.AcceptChanges();
                    }
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                VerifiedCarsFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                DataTable CompanyID_intDataTable = new DataTable();
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
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void CompanyID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CompanySearch frm = new HPS.Present.SearchForm.CompanySearch();
            frm.ShowDialog();
            if (frm != null && frm.SelectedCompanyEntity != null)
            {
                CompanyID_intComboBox.Text = frm.SelectedCompanyEntity.Company_nvc;
                //CompanyCode_nvcTextBox.Text = frm.SelectedCompanyEntity.CompanyCode_nvc;
            }
        }
    }
}