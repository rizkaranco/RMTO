using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Province
{
    public partial class ProvinceEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public ProvinceEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public ProvinceEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.ProvinceBLL.BLLProvince_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void ProvinceEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.ProvinceBLL.BLLProvince_TFactory ProvinceFactory = new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();
            HPS.BLL.ProvinceBLL.BLLProvince_T ProvinceEntity = ProvinceFactory.GetBy((HPS.BLL.ProvinceBLL.BLLProvince_TKeys)Key);
            if (ProvinceEntity == null)
            {
                throw new HPS.Exceptions.ProvinceNotFound();
            }
            ProvinceCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ProvinceEntity.ProvinceCode_nvc, TypeCode.String).ToString();
            Province_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ProvinceEntity.Province_nvc, TypeCode.String).ToString();
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(ProvinceEntity.Active_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.ProvinceBLL.BLLProvince_TFactory ProvinceFactory = new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();
            try
            {
                HPS.BLL.ProvinceBLL.BLLProvince_T ProvinceEntity = new HPS.BLL.ProvinceBLL.BLLProvince_T();
                ProvinceEntity.ProvinceCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ProvinceCode_nvcTextBox.Text, TypeCode.String).ToString();
                ProvinceEntity.Province_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Province_nvcTextBox.Text, TypeCode.String).ToString();
                ProvinceEntity.Active_bit = Active_bitCheckBox.Checked;

                ProvinceFactory.BeginProc();
                ProvinceFactory.Insert(ProvinceEntity);
                ProvinceFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Province_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.Province_int, TypeCode.Int32);
                    dr[HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.ProvinceCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.ProvinceCode_nvc, TypeCode.String);
                    dr[HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Province_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.Province_nvc, TypeCode.String);
                    dr[HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.Active_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                ProvinceFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.ProvinceBLL.BLLProvince_TFactory ProvinceFactory = new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();
            try
            {
                HPS.BLL.ProvinceBLL.BLLProvince_T ProvinceEntity = new HPS.BLL.ProvinceBLL.BLLProvince_T();
                ProvinceEntity.ProvinceCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ProvinceCode_nvcTextBox.Text, TypeCode.String).ToString();
                ProvinceEntity.Province_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Province_nvcTextBox.Text, TypeCode.String).ToString();
                ProvinceEntity.Active_bit = Active_bitCheckBox.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    ProvinceFactory.BeginProc();
                    ProvinceFactory.Update(ProvinceEntity, (HPS.BLL.ProvinceBLL.BLLProvince_TKeys)Key);
                    ProvinceFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Province_int.ToString() + "='" + ((HPS.BLL.ProvinceBLL.BLLProvince_TKeys)Key).Province_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.ProvinceCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.ProvinceCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Province_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.Province_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ProvinceEntity.Active_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                ProvinceFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.ProvinceBLL.BLLProvince_TFactory ProvinceFactory = new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    ProvinceFactory.BeginProc();
                    ProvinceFactory.Delete((HPS.BLL.ProvinceBLL.BLLProvince_TKeys)Key);
                    ProvinceFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Province_int.ToString() + "='" + ((HPS.BLL.ProvinceBLL.BLLProvince_TKeys)Key).Province_int.ToString() + "'");
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
                ProvinceFactory.RollBackProc();
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