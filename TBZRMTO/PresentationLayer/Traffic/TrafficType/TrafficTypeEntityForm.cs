using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.TrafficType
{
    public partial class TrafficTypeEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public TrafficTypeEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public TrafficTypeEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void TrafficTypeEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_T TrafficTypeEntity = TrafficTypeFactory.GetBy((HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys)Key);
            if (TrafficTypeEntity == null)
            {
                throw new HPS.Exceptions.TrafficTypeNotFound();
            }

            TrafficType_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeEntity.TrafficType_nvc, TypeCode.String).ToString();

        }

        protected override void Insert()
        {
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
            try
            {
                HPS.BLL.TrafficTypeBLL.BLLTrafficType_T TrafficTypeEntity = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_T();
                TrafficTypeEntity.TrafficType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficType_nvcTextBox.Text, TypeCode.String).ToString();

                TrafficTypeFactory.BeginProc();
                TrafficTypeFactory.Insert(TrafficTypeEntity);
                TrafficTypeFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficTypeEntity.TrafficTypeID_int, TypeCode.Int32);
                    dr[HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficTypeEntity.TrafficType_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                TrafficTypeFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
            try
            {
                HPS.BLL.TrafficTypeBLL.BLLTrafficType_T TrafficTypeEntity = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_T();
                TrafficTypeEntity.TrafficType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficType_nvcTextBox.Text, TypeCode.String).ToString();
                

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    TrafficTypeFactory.BeginProc();
                    TrafficTypeFactory.Update(TrafficTypeEntity, (HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys)Key);
                    TrafficTypeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString() + "='" + ((HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys)Key).TrafficTypeID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficTypeEntity.TrafficType_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                TrafficTypeFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    TrafficTypeFactory.BeginProc();
                    TrafficTypeFactory.Delete((HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys)Key);
                    TrafficTypeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString() + "='" + ((HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys)Key).TrafficTypeID_int.ToString() + "'");
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
                TrafficTypeFactory.RollBackProc();
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