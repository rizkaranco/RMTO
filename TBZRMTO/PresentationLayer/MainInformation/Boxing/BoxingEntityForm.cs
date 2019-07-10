using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Boxing
{
    public partial class BoxingEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public BoxingEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public BoxingEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.BoxingBLL.BLLBoxing_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void BoxingEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
            HPS.BLL.BoxingBLL.BLLBoxing_T BoxingEntity = BoxingFactory.GetBy((HPS.BLL.BoxingBLL.BLLBoxing_TKeys)Key);
            if (BoxingEntity == null)
            {
                throw new HPS.Exceptions.BoxingNotFound();
            }
            BoxingCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingEntity.BoxingCode_nvc, TypeCode.String).ToString();
            BoxingType_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingEntity.BoxingType_nvc, TypeCode.String).ToString();
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingEntity.Active_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
            try
            {
                HPS.BLL.BoxingBLL.BLLBoxing_T BoxingEntity = new HPS.BLL.BoxingBLL.BLLBoxing_T();
                BoxingEntity.BoxingCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingCode_nvcTextBox.Text, TypeCode.String).ToString();
                BoxingEntity.BoxingType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingType_nvcTextBox.Text, TypeCode.String).ToString();
                BoxingEntity.Active_bit = Active_bitCheckBox.Checked;

                BoxingFactory.BeginProc();
                BoxingFactory.Insert(BoxingEntity);
                BoxingFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.BoxingID_int, TypeCode.Int32);
                    dr[HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.BoxingCode_nvc, TypeCode.String);
                    dr[HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.BoxingType_nvc, TypeCode.String);
                    dr[HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.Active_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                BoxingFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
            try
            {
                HPS.BLL.BoxingBLL.BLLBoxing_T BoxingEntity = new HPS.BLL.BoxingBLL.BLLBoxing_T();
                BoxingEntity.BoxingCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingCode_nvcTextBox.Text, TypeCode.String).ToString();
                BoxingEntity.BoxingType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingType_nvcTextBox.Text, TypeCode.String).ToString();
                BoxingEntity.Active_bit = Active_bitCheckBox.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    BoxingFactory.BeginProc();
                    BoxingFactory.Update(BoxingEntity, (HPS.BLL.BoxingBLL.BLLBoxing_TKeys)Key);
                    BoxingFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString() + "='" + ((HPS.BLL.BoxingBLL.BLLBoxing_TKeys)Key).BoxingID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.BoxingCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.BoxingType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoxingEntity.Active_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                BoxingFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    BoxingFactory.BeginProc();
                    BoxingFactory.Delete((HPS.BLL.BoxingBLL.BLLBoxing_TKeys)Key);
                    BoxingFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString() + "='" + ((HPS.BLL.BoxingBLL.BLLBoxing_TKeys)Key).BoxingID_int.ToString() + "'");
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
                BoxingFactory.RollBackProc();
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