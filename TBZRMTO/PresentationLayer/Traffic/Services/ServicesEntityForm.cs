using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Services
{
    public partial class ServicesEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public ServicesEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public ServicesEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.ServicesBLL.BLLServices_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void ServicesEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            HPS.BLL.ServicesBLL.BLLServices_T ServicesEntity = ServicesFactory.GetBy((HPS.BLL.ServicesBLL.BLLServices_TKeys)Key);
            if (ServicesEntity == null)
            {
                throw new HPS.Exceptions.ServicesNotFound();
            }
            ServicesType_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesEntity.ServicesType_nvc, TypeCode.String).ToString();
            Activie_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesEntity.Activie_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            try
            {
                HPS.BLL.ServicesBLL.BLLServices_T ServicesEntity = new HPS.BLL.ServicesBLL.BLLServices_T();
                ServicesEntity.ServicesType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesType_nvcTextBox.Text, TypeCode.String).ToString();
                ServicesEntity.Activie_bit = Activie_bitCheckBox.Checked;

                ServicesFactory.BeginProc();
                ServicesFactory.Insert(ServicesEntity);
                ServicesFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ServicesEntity.ServicesID_int, TypeCode.Int32);
                    dr[HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ServicesEntity.ServicesType_nvc, TypeCode.String);
                    dr[HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.Activie_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ServicesEntity.Activie_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                ServicesFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            try
            {
                HPS.BLL.ServicesBLL.BLLServices_T ServicesEntity = new HPS.BLL.ServicesBLL.BLLServices_T();
                ServicesEntity.ServicesType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesType_nvcTextBox.Text, TypeCode.String).ToString();
                ServicesEntity.Activie_bit = Activie_bitCheckBox.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    ServicesFactory.BeginProc();
                    ServicesFactory.Update(ServicesEntity, (HPS.BLL.ServicesBLL.BLLServices_TKeys)Key);
                    ServicesFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString() + "='" + ((HPS.BLL.ServicesBLL.BLLServices_TKeys)Key).ServicesID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ServicesEntity.ServicesType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.Activie_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ServicesEntity.Activie_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                ServicesFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    ServicesFactory.BeginProc();
                    ServicesFactory.Delete((HPS.BLL.ServicesBLL.BLLServices_TKeys)Key);
                    ServicesFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString() + "='" + ((HPS.BLL.ServicesBLL.BLLServices_TKeys)Key).ServicesID_int.ToString() + "'");
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
                ServicesFactory.RollBackProc();
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