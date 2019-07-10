using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.InfractionGroup
{
    public partial class InfractionGroupEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public InfractionGroupEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public InfractionGroupEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void InfractionGroupEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T InfractionGroupEntity = InfractionGroupFactory.GetBy((HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys)Key);
            if (InfractionGroupEntity == null)
            {
                throw new HPS.Exceptions.InfractionGroupNotFound();
            }
            InfractionGroup_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupEntity.InfractionGroup_nvc, TypeCode.String).ToString();
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupEntity.Active_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
            try
            {
                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T InfractionGroupEntity = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T();
                InfractionGroupEntity.InfractionGroup_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroup_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionGroupEntity.Active_bit = Active_bitCheckBox.Checked;

                InfractionGroupFactory.BeginProc();
                InfractionGroupFactory.Insert(InfractionGroupEntity);
                InfractionGroupFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionGroupEntity.InfractionGroupID_int, TypeCode.Int32);
                    dr[HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionGroupEntity.InfractionGroup_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionGroupEntity.Active_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                InfractionGroupFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
            try
            {
                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T InfractionGroupEntity = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T();
                InfractionGroupEntity.InfractionGroup_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroup_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionGroupEntity.Active_bit = Active_bitCheckBox.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    InfractionGroupFactory.BeginProc();
                    InfractionGroupFactory.Update(InfractionGroupEntity, (HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys)Key);
                    InfractionGroupFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString() + "='" + ((HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys)Key).InfractionGroupID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionGroupEntity.InfractionGroup_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionGroupEntity.Active_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                InfractionGroupFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    InfractionGroupFactory.BeginProc();
                    InfractionGroupFactory.Delete((HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys)Key);
                    InfractionGroupFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString() + "='" + ((HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys)Key).InfractionGroupID_int.ToString() + "'");
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
                InfractionGroupFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}