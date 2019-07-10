using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.Boundry
{
    public partial class BoundryEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public BoundryEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public BoundryEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.BoundryBLL.BLLBoundry_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void BoundryEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory =new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();
        HPS.BLL.BoundryBLL.BLLBoundry_T BoundryEntity = BoundryFactory.GetBy((HPS.BLL.BoundryBLL.BLLBoundry_TKeys)Key);
        if(BoundryEntity ==null)
            {
               throw new HPS.Exceptions.BoundryNotFound();
            }
        BoundryCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(BoundryEntity.BoundryCode_nvc, TypeCode.String));
Boundry_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(BoundryEntity.Boundry_nvc, TypeCode.String));

         }

        protected override void Insert()
         {
        HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory =new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();
            try
              {
                  HPS.BLL.BoundryBLL.BLLBoundry_T BoundryEntity =new HPS.BLL.BoundryBLL.BLLBoundry_T();
                  BoundryEntity.BoundryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoundryCode_nvcTextBox.Text, TypeCode.String).ToString();
BoundryEntity.Boundry_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Boundry_nvcTextBox.Text, TypeCode.String).ToString();

                  BoundryFactory.BeginProc();
                  BoundryFactory.Insert(BoundryEntity);
                  BoundryFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoundryEntity.BoundryID_int, TypeCode.Int32);
dr[HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoundryEntity.BoundryCode_nvc, TypeCode.String);
dr[HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.Boundry_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoundryEntity.Boundry_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 BoundryFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory =new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();
            try
              {
                  HPS.BLL.BoundryBLL.BLLBoundry_T BoundryEntity =new HPS.BLL.BoundryBLL.BLLBoundry_T();
                  BoundryEntity.BoundryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoundryCode_nvcTextBox.Text, TypeCode.String).ToString();
BoundryEntity.Boundry_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Boundry_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  BoundryFactory.BeginProc();
                  BoundryFactory.Update(BoundryEntity,(HPS.BLL.BoundryBLL.BLLBoundry_TKeys)Key);
                  BoundryFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryID_int.ToString() + "='" +((HPS.BLL.BoundryBLL.BLLBoundry_TKeys)Key).BoundryID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoundryEntity.BoundryCode_nvc, TypeCode.String);
dr[0][HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.Boundry_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BoundryEntity.Boundry_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   BoundryFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory =new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    BoundryFactory.BeginProc();
                    BoundryFactory.Delete((HPS.BLL.BoundryBLL.BLLBoundry_TKeys)Key);
                    BoundryFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryID_int.ToString() + "='" + ((HPS.BLL.BoundryBLL.BLLBoundry_TKeys)Key).BoundryID_int.ToString()+"'");
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
                  BoundryFactory.RollBackProc();
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