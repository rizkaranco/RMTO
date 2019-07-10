using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.Good
{
    public partial class GoodEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public GoodEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public GoodEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.GoodBLL.BLLGood_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void GoodEntityForm_Load(object sender,EventArgs e)
        {
            try
            {
                if(this.State == enmFormState.Add)
                    this.FillCombo();

            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
         }

         protected override void ShowForm()
         {
            this.FillCombo();
        HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory =new HPS.BLL.GoodBLL.BLLGood_TFactory();
        HPS.BLL.GoodBLL.BLLGood_T GoodEntity = GoodFactory.GetBy((HPS.BLL.GoodBLL.BLLGood_TKeys)Key);
        if(GoodEntity ==null)
            {
               throw new HPS.Exceptions.GoodNotFound();
            }
        GoodCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(GoodEntity.GoodCode_nvc, TypeCode.String).ToString();
Good_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(GoodEntity.Good_nvc, TypeCode.String).ToString();
Avtive_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(GoodEntity.Avtive_bit, TypeCode.Boolean);

         }

        protected override void Insert()
         {
        HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory =new HPS.BLL.GoodBLL.BLLGood_TFactory();
            try
              {
                  HPS.BLL.GoodBLL.BLLGood_T GoodEntity =new HPS.BLL.GoodBLL.BLLGood_T();
                  GoodEntity.GoodCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(GoodCode_nvcTextBox.Text, TypeCode.String).ToString();
GoodEntity.Good_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Good_nvcTextBox.Text, TypeCode.String).ToString();
GoodEntity.Avtive_bit = Avtive_bitCheckBox.Checked;

                  GoodFactory.BeginProc();
                  GoodFactory.Insert(GoodEntity);
                  GoodFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.GoodID_int, TypeCode.Int32);
dr[HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.GoodCode_nvc, TypeCode.String);
dr[HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Good_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.Good_nvc, TypeCode.String);
dr[HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Avtive_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.Avtive_bit, TypeCode.Boolean);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 GoodFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory =new HPS.BLL.GoodBLL.BLLGood_TFactory();
            try
              {
                  HPS.BLL.GoodBLL.BLLGood_T GoodEntity =new HPS.BLL.GoodBLL.BLLGood_T();
                  GoodEntity.GoodCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(GoodCode_nvcTextBox.Text, TypeCode.String).ToString();
GoodEntity.Good_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Good_nvcTextBox.Text, TypeCode.String).ToString();
GoodEntity.Avtive_bit = Avtive_bitCheckBox.Checked;

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  GoodFactory.BeginProc();
                  GoodFactory.Update(GoodEntity,(HPS.BLL.GoodBLL.BLLGood_TKeys)Key);
                  GoodFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString() + "='" +((HPS.BLL.GoodBLL.BLLGood_TKeys)Key).GoodID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.GoodCode_nvc, TypeCode.String);
dr[0][HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Good_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.Good_nvc, TypeCode.String);
dr[0][HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Avtive_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(GoodEntity.Avtive_bit, TypeCode.Boolean);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   GoodFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory =new HPS.BLL.GoodBLL.BLLGood_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    GoodFactory.BeginProc();
                    GoodFactory.Delete((HPS.BLL.GoodBLL.BLLGood_TKeys)Key);
                    GoodFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString() + "='" + ((HPS.BLL.GoodBLL.BLLGood_TKeys)Key).GoodID_int.ToString()+"'");
                    if(dr.Length > 0)
                      {
                        dr[0].Delete();
                      }
                    DataTable.AcceptChanges();
                  }
                this.Close();
               }
             }
            catch(Exception ex)
             {
                  GoodFactory.RollBackProc();
                throw ex;
             }
        }

        private void FillCombo()
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    

    }
}