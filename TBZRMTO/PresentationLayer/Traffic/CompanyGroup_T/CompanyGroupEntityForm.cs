using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.CompanyGroup
{
    public partial class CompanyGroupEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CompanyGroupEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public CompanyGroupEntityForm(enmState State, DataTable DataTable, HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void CompanyGroupEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroupFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T CompanyGroupEntity = CompanyGroupFactory.GetBy((HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys)Key);
            if (CompanyGroupEntity == null)
            {
                throw new HPS.Exceptions.CompanyGroupNotFound();
            }
            GroupName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyGroupEntity.GroupName_nvc, TypeCode.String));
        }

        protected override void Insert()
        {
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroupFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();

            try
            {
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T CompanyGroupEntity = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T();
                CompanyGroupEntity.GroupName_nvc =GroupName_nvcTextBox.Text;


                CompanyGroupFactory.BeginProc();
                CompanyGroupFactory.Insert(CompanyGroupEntity);
                CompanyGroupFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyGroupEntity.GroupID_int, TypeCode.Int32);
                    dr[HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyGroupEntity.GroupName_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);


            }
            catch (System.Exception ex)
            {
                CompanyGroupFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroupFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();

            try
            {
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T CompanyGroupEntity = CompanyGroupFactory.GetBy((HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys)Key);
                if (CompanyGroupEntity == null)
                    throw new HPS.Exceptions.CompanyGroupNotFound();
                CompanyGroupEntity.GroupName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(GroupName_nvcTextBox.Text, TypeCode.String).ToString();

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    CompanyGroupFactory.BeginProc();
                    CompanyGroupFactory.Update(CompanyGroupEntity, (HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys)Key);
                    CompanyGroupFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupID_int.ToString() + "='" + ((HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys)Key).GroupID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyGroupEntity.GroupName_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (System.Exception ex)
            {
                CompanyGroupFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroupFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    CompanyGroupFactory.BeginProc();
                    CompanyGroupFactory.Delete((HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys)Key);
                    CompanyGroupFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupID_int.ToString() + "='" + ((HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys)Key).GroupID_int.ToString() + "'");
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
                CompanyGroupFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}