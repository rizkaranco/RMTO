using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present
{
    public partial class CompanyMobileEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        private Int32 _CompanyID_int;
        public CompanyMobileEntityForm(DataTable DataTable,Int32 CompanyID_int)
            : base(DataTable)
        {
            InitializeComponent();
            _CompanyID_int = CompanyID_int;
        }

        public CompanyMobileEntityForm(enmState State, DataTable DataTable, HPS.BLL.BLLCompanyMobile_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void CompanyMobileEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void ShowForm()
        {
            HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory = new HPS.BLL.BLLCompanyMobile_TFactory();
            HPS.BLL.BLLCompanyMobile_T CompanyMobileEntity = CompanyMobileFactory.GetBy((HPS.BLL.BLLCompanyMobile_TKeys)Key);
            if (CompanyMobileEntity == null)
            {
                throw new HPS.Exceptions.CompanyMobileNotFound();
            }
            MobileNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyMobileEntity.MobileNumber_nvc, TypeCode.String));
            FirstName_nvcTextBox.Text = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyMobileEntity.FirstName_nvc, TypeCode.String);
            LastName_nvcTextBox.Text = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyMobileEntity.LastName_nvc, TypeCode.String);
            Active_bitCheckBox.Checked = (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyMobileEntity.Active_bit, TypeCode.Boolean);
        }

        protected override void Insert()
        {
            HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory = new HPS.BLL.BLLCompanyMobile_TFactory();

            try
            {
                HPS.BLL.BLLCompanyMobile_T CompanyMobileEntity = new HPS.BLL.BLLCompanyMobile_T();
                CompanyMobileEntity.MobileNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MobileNumber_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyMobileEntity.FirstName_nvc=(string)Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String);
                CompanyMobileEntity.LastName_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String);
                CompanyMobileEntity.Active_bit = (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(Active_bitCheckBox.Checked, TypeCode.Boolean);
                CompanyMobileEntity.CompanyID_int =this._CompanyID_int;

                CompanyMobileFactory.BeginProc();
                CompanyMobileFactory.Insert(CompanyMobileEntity);
                CompanyMobileFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyMobileID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.CompanyMobileID_int, TypeCode.Int32);
                    dr[HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.MobileNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.MobileNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.FirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.FirstName_nvc, TypeCode.String);
                    dr[HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.LastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.LastName_nvc, TypeCode.String);
                    dr[HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.Active_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);


            }
            catch (System.Exception ex)
            {
                CompanyMobileFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory = new HPS.BLL.BLLCompanyMobile_TFactory();

            try
            {
                HPS.BLL.BLLCompanyMobile_T CompanyMobileEntity = CompanyMobileFactory.GetBy((HPS.BLL.BLLCompanyMobile_TKeys)Key);
                if (CompanyMobileEntity == null)
                    throw new HPS.Exceptions.CompanyMobileNotFound();
                CompanyMobileEntity.MobileNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MobileNumber_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyMobileEntity.FirstName_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String);
                CompanyMobileEntity.LastName_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String);
                CompanyMobileEntity.Active_bit = (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(Active_bitCheckBox.Checked, TypeCode.Boolean);

                
                    CompanyMobileFactory.BeginProc();
                    CompanyMobileFactory.Update(CompanyMobileEntity, (HPS.BLL.BLLCompanyMobile_TKeys)Key);
                    CompanyMobileFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyMobileID_int.ToString() + "='" + ((HPS.BLL.BLLCompanyMobile_TKeys)Key).CompanyMobileID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.MobileNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.MobileNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.FirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.FirstName_nvc, TypeCode.String);
                           dr[0][HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.LastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.LastName_nvc, TypeCode.String);
                           dr[0][HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyMobileEntity.Active_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                
            }
            catch (System.Exception ex)
            {
                CompanyMobileFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory = new HPS.BLL.BLLCompanyMobile_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage()  == true)
                {
                    CompanyMobileFactory.BeginProc();
                    CompanyMobileFactory.Delete((HPS.BLL.BLLCompanyMobile_TKeys)Key);
                    CompanyMobileFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyMobileID_int.ToString() + "='" + ((HPS.BLL.BLLCompanyMobile_TKeys)Key).CompanyMobileID_int.ToString() + "'");
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
                CompanyMobileFactory.RollBackProc();
                throw ex;
            }
        }

    }
}