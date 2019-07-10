using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.InfractionSurveyGroup
{
    public partial class InfractionSurveyGroupEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public InfractionSurveyGroupEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public InfractionSurveyGroupEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void InfractionSurveyGroupEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupFactory =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
        HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T InfractionSurveyGroupEntity = InfractionSurveyGroupFactory.GetBy((HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys)Key);
        if(InfractionSurveyGroupEntity ==null)
            {
               throw new HPS.Exceptions.InfractionSurveyGroupNotFound();
            }
        InfractionSurveyGroup_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroupEntity.InfractionSurveyGroup_nvc, TypeCode.String).ToString();

         }

        protected override void Insert()
         {
        HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupFactory =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
            try
              {
                  HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T InfractionSurveyGroupEntity =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T();
                  InfractionSurveyGroupEntity.InfractionSurveyGroup_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroup_nvcTextBox.Text, TypeCode.String).ToString();

                  InfractionSurveyGroupFactory.BeginProc();
                  InfractionSurveyGroupFactory.Insert(InfractionSurveyGroupEntity);
                  InfractionSurveyGroupFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionSurveyGroupEntity.InfractionSurveyGroupID_int, TypeCode.Int32);
dr[HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionSurveyGroupEntity.InfractionSurveyGroup_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 InfractionSurveyGroupFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupFactory =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
            try
              {
                  HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T InfractionSurveyGroupEntity =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T();
                  InfractionSurveyGroupEntity.InfractionSurveyGroup_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroup_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  InfractionSurveyGroupFactory.BeginProc();
                  InfractionSurveyGroupFactory.Update(InfractionSurveyGroupEntity,(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys)Key);
                  InfractionSurveyGroupFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString() + "='" +((HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys)Key).InfractionSurveyGroupID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionSurveyGroupEntity.InfractionSurveyGroup_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   InfractionSurveyGroupFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupFactory =new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    InfractionSurveyGroupFactory.BeginProc();
                    InfractionSurveyGroupFactory.Delete((HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys)Key);
                    InfractionSurveyGroupFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString() + "='" + ((HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys)Key).InfractionSurveyGroupID_int.ToString()+"'");
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
                  InfractionSurveyGroupFactory.RollBackProc();
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