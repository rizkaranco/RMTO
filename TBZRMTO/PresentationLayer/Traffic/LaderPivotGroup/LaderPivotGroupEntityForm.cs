using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.LaderPivotGroup
{
    public partial class LaderPivotGroupEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public LaderPivotGroupEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public LaderPivotGroupEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void LaderPivotGroupEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupFactory =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
        HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T LaderPivotGroupEntity = LaderPivotGroupFactory.GetBy((HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys)Key);
        if(LaderPivotGroupEntity ==null)
            {
               throw new HPS.Exceptions.LaderPivotGroupNotFound();
            }
        LaderPivotGroup_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroupEntity.LaderPivotGroup_nvc, TypeCode.String).ToString();

         }

        protected override void Insert()
         {
        HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupFactory =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
            try
              {
                  HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T LaderPivotGroupEntity =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T();
                  LaderPivotGroupEntity.LaderPivotGroup_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroup_nvcTextBox.Text, TypeCode.String).ToString();

                  LaderPivotGroupFactory.BeginProc();
                  LaderPivotGroupFactory.Insert(LaderPivotGroupEntity);
                  LaderPivotGroupFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderPivotGroupEntity.LaderPivotGroupID_int, TypeCode.Int32);
dr[HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderPivotGroupEntity.LaderPivotGroup_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 LaderPivotGroupFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupFactory =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
            try
              {
                  HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T LaderPivotGroupEntity =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T();
                  LaderPivotGroupEntity.LaderPivotGroup_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderPivotGroup_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  LaderPivotGroupFactory.BeginProc();
                  LaderPivotGroupFactory.Update(LaderPivotGroupEntity,(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys)Key);
                  LaderPivotGroupFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString() + "='" +((HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys)Key).LaderPivotGroupID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LaderPivotGroupEntity.LaderPivotGroup_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   LaderPivotGroupFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupFactory =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    LaderPivotGroupFactory.BeginProc();
                    LaderPivotGroupFactory.Delete((HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys)Key);
                    LaderPivotGroupFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString() + "='" + ((HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys)Key).LaderPivotGroupID_int.ToString()+"'");
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
                  LaderPivotGroupFactory.RollBackProc();
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