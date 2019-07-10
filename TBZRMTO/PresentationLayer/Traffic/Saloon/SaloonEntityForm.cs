using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Saloon
{
    public partial class SaloonEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {

        public SaloonEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public SaloonEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.SaloonBLL.BLLSaloon_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void SaloonEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                    this.FillListBox();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void ShowForm()
        {
            HPS.BLL.SaloonBLL.BLLSaloon_TFactory SaloonFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
            HPS.BLL.SaloonBLL.BLLSaloon_T SaloonEntity = SaloonFactory.GetBy((HPS.BLL.SaloonBLL.BLLSaloon_TKeys)Key);

            this.FillListBox();

            if (SaloonEntity == null)
            {
                throw new Exceptions.SaloonNotFound();
            }
            Saloon_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonEntity.Saloon_nvc, TypeCode.String).ToString();
            TurnDistinictAfterCredit_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonEntity.TurnDistinictAfterCredit_int, TypeCode.Int32).ToString();
            TurnNumberInLadeAnnouncement_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonEntity.TurnNumberInLadeAnnouncement_int, TypeCode.Int32).ToString();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeList = LaderTypeFactory.GetAllBy(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.SaloonID_int, SaloonEntity.SaloonID_int);
            if (LaderTypeList != null && LaderTypeList.Count > 0)
            {
                for (int i = 0; i < lstLaderTypeCheckBox.Items.Count; i++)
                {
                    if (LaderTypeList.FindAll(c => c.LaderTypeID_int == (((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.Items[i]).LaderTypeID_int)).Count > 0)
                    {
                        this.lstLaderTypeCheckBox.SetItemChecked(i, true);
                    }
                    else
                        this.lstLaderTypeCheckBox.SetItemChecked(i, false);
                }
            }
        }

        protected override void Insert()
        {
            HPS.BLL.SaloonBLL.BLLSaloon_TFactory SaloonFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
            try
            {
                HPS.BLL.SaloonBLL.BLLSaloon_T SaloonEntity = new HPS.BLL.SaloonBLL.BLLSaloon_T();
                SaloonEntity.Saloon_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Saloon_nvcTextBox.Text, TypeCode.String).ToString();
                SaloonEntity.TurnDistinictAfterCredit_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnDistinictAfterCredit_intNumericTextBox.NumericText, TypeCode.Int32);
                SaloonEntity.TurnNumberInLadeAnnouncement_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNumberInLadeAnnouncement_intNumericTextBox.NumericText, TypeCode.Int32);

                SaloonFactory.BeginProc();
                SaloonFactory.Insert(SaloonEntity);
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();

                for (int i = 0; i < lstLaderTypeCheckBox.CheckedItems.Count; i++)
                {
                    ((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.CheckedItems[i]).SaloonID_int = SaloonEntity.SaloonID_int;
                    LaderTypeKey.LaderTypeID_int = ((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.CheckedItems[i]).LaderTypeID_int;
                    LaderTypeFactory.Update(((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.CheckedItems[i]), LaderTypeKey);
                }

                 SaloonFactory.CommitProc();

                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.SaloonID_int, TypeCode.Int32);
                    dr[HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.Saloon_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.Saloon_nvc, TypeCode.String);
                    dr[HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.TurnDistinictAfterCredit_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.TurnDistinictAfterCredit_int, TypeCode.Int32);
                    dr[HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.TurnNumberInLadeAnnouncement_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.TurnNumberInLadeAnnouncement_int, TypeCode.Int32);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                SaloonFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {  
         HPS.BLL.SaloonBLL.BLLSaloon_TFactory SaloonFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
            try
            {
                HPS.BLL.SaloonBLL.BLLSaloon_T SaloonEntity = new HPS.BLL.SaloonBLL.BLLSaloon_T();
                SaloonEntity.SaloonID_int = ((HPS.BLL.SaloonBLL.BLLSaloon_TKeys)Key).SaloonID_int;
                SaloonEntity.Saloon_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Saloon_nvcTextBox.Text, TypeCode.String).ToString();
                SaloonEntity.TurnDistinictAfterCredit_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnDistinictAfterCredit_intNumericTextBox.NumericText, TypeCode.Int32);
                SaloonEntity.TurnNumberInLadeAnnouncement_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNumberInLadeAnnouncement_intNumericTextBox.NumericText, TypeCode.Int32);


                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    SaloonFactory.BeginProc();
                    SaloonFactory.Update(SaloonEntity, (HPS.BLL.SaloonBLL.BLLSaloon_TKeys)Key);
                    HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                    HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                    foreach (HPS.BLL.LaderTypeBLL.BLLLaderType_T item in LaderTypeFactory.GetAllBy(BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.SaloonID_int,SaloonEntity.SaloonID_int))
                    {
                        item.SaloonID_int = null;
                        LaderTypeKey.LaderTypeID_int = item.LaderTypeID_int;
                        LaderTypeFactory.Update(item, LaderTypeKey);
                    }
                    foreach (HPS.BLL.LaderTypeBLL.BLLLaderType_T item in lstLaderTypeCheckBox.CheckedItems)
                    {
                        item.SaloonID_int = SaloonEntity.SaloonID_int;
                        LaderTypeKey.LaderTypeID_int = item.LaderTypeID_int;
                        LaderTypeFactory.Update(item, LaderTypeKey);
                    }
                    //for (int i = 0; i < lstLaderTypeCheckBox.CheckedItems.Count; i++)
                    //{
                    //    ((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.CheckedItems[i]).SaloonID_int = SaloonEntity.SaloonID_int;
                    //    LaderTypeKey.LaderTypeID_int = ((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.CheckedItems[i]).LaderTypeID_int;
                    //    LaderTypeFactory.Update(((HPS.BLL.LaderTypeBLL.BLLLaderType_T)this.lstLaderTypeCheckBox.CheckedItems[i]), LaderTypeKey);
                    //}
                    SaloonFactory.CommitProc();

                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString() + " = " + ((HPS.BLL.SaloonBLL.BLLSaloon_TKeys)Key).SaloonID_int.ToString() + "");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.SaloonID_int, TypeCode.Int32);
                            dr[0][HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.Saloon_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.Saloon_nvc, TypeCode.String);
                            dr[0][HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.TurnDistinictAfterCredit_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.TurnDistinictAfterCredit_int, TypeCode.Int32);
                            dr[0][HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.TurnNumberInLadeAnnouncement_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(SaloonEntity.TurnNumberInLadeAnnouncement_int, TypeCode.Int32);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                SaloonFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Delete()
        {
            HPS.BLL.SaloonBLL.BLLSaloon_TFactory SaloonFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                {
                    return;
                }
                SaloonFactory.BeginProc();
                SaloonFactory.Delete((HPS.BLL.SaloonBLL.BLLSaloon_TKeys)Key);
                SaloonFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow[] dr = DataTable.Select(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString() + " = " + ((HPS.BLL.SaloonBLL.BLLSaloon_TKeys)Key).SaloonID_int.ToString() + "");
                    if (dr.Length > 0)
                    {
                        dr[0].Delete();
                    }
                    DataTable.AcceptChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                SaloonFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillListBox()
        {
             HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            try
            {
                String Condition = "[LaderType_T].[SaloonID_int] Is Null";
                if (this.State != enmFormState.Add && this.Key != null)
                    Condition += " Or [LaderType_T].[SaloonID_int]= " + ((HPS.BLL.SaloonBLL.BLLSaloon_TKeys)this.Key).SaloonID_int.ToString();
                List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeList = LaderTypeFactory.GetAllByCondition(Condition);

                if (LaderTypeList != null && LaderTypeList.Count > 0)
                {
                    foreach (HPS.BLL.LaderTypeBLL.BLLLaderType_T item in LaderTypeList)
                    {
                        lstLaderTypeCheckBox.Items.Add(item, false);
                    }
                }
                this.lstLaderTypeCheckBox.GetType().GetProperty("DisplayMember").SetValue(this.lstLaderTypeCheckBox, HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString(), null);
                this.lstLaderTypeCheckBox.GetType().GetProperty("ValueMember").SetValue(this.lstLaderTypeCheckBox, HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString(), null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}