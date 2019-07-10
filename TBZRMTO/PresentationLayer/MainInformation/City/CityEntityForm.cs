using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.City
{
    public partial class CityEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CityEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public CityEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.CityBLL.BLLCity_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void CityEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            HPS.BLL.CityBLL.BLLCity_T CityEntity = CityFactory.GetBy((HPS.BLL.CityBLL.BLLCity_TKeys)Key);
            if (CityEntity == null)
            {
                throw new HPS.Exceptions.CityNotFound();
            }
            CityCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CityEntity.CityCode_nvc, TypeCode.String).ToString();
            City_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CityEntity.City_nvc, TypeCode.String).ToString();
            TravelTime_intNumericTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CityEntity.TravelTime_int, TypeCode.Int32));
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(CityEntity.Active_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            try
            {
                HPS.BLL.CityBLL.BLLCity_T CityEntity = new HPS.BLL.CityBLL.BLLCity_T();
                CityEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                CityEntity.City_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(City_nvcTextBox.Text, TypeCode.String).ToString();
                CityEntity.TravelTime_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TravelTime_intNumericTextBox.NumericText, TypeCode.Int32);
                CityEntity.Active_bit = Active_bitCheckBox.Checked;

                CityFactory.BeginProc();
                CityFactory.Insert(CityEntity);
                CityFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.CityID_int, TypeCode.Int32);
                    dr[HPS.BLL.CityBLL.BLLCity_T.City_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.CityCode_nvc, TypeCode.String);
                    dr[HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.City_nvc, TypeCode.String);
                    dr[HPS.BLL.CityBLL.BLLCity_T.City_TField.TravelTime_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.TravelTime_int, TypeCode.Int32);
                    dr[HPS.BLL.CityBLL.BLLCity_T.City_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.Active_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                CityFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            try
            {
                HPS.BLL.CityBLL.BLLCity_T CityEntity = new HPS.BLL.CityBLL.BLLCity_T();
                CityEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                CityEntity.City_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(City_nvcTextBox.Text, TypeCode.String).ToString();
                CityEntity.TravelTime_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TravelTime_intNumericTextBox.NumericText, TypeCode.Int32);
                CityEntity.Active_bit = Active_bitCheckBox.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    CityFactory.BeginProc();
                    CityFactory.Update(CityEntity, (HPS.BLL.CityBLL.BLLCity_TKeys)Key);
                    CityFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString() + "='" + ((HPS.BLL.CityBLL.BLLCity_TKeys)Key).CityID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.CityBLL.BLLCity_T.City_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.CityCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.City_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CityBLL.BLLCity_T.City_TField.TravelTime_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.TravelTime_int, TypeCode.Int32);
                            dr[0][HPS.BLL.CityBLL.BLLCity_T.City_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CityEntity.Active_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                CityFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    CityFactory.BeginProc();
                    CityFactory.Delete((HPS.BLL.CityBLL.BLLCity_TKeys)Key);
                    CityFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString() + "='" + ((HPS.BLL.CityBLL.BLLCity_TKeys)Key).CityID_int.ToString() + "'");
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
                CityFactory.RollBackProc();
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