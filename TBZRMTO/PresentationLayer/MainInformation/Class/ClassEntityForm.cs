using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.Class
{
    public partial class ClassEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public ClassEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public ClassEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.ClassBLL.BLLClass_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void ClassEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.ClassBLL.BLLClass_TFactory ClassFactory =new HPS.BLL.ClassBLL.BLLClass_TFactory();
        HPS.BLL.ClassBLL.BLLClass_T ClassEntity = ClassFactory.GetBy((HPS.BLL.ClassBLL.BLLClass_TKeys)Key);
        if(ClassEntity ==null)
            {
               throw new HPS.Exceptions.ClassNotFound();
            }
        ClassName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(ClassEntity.ClassName_nvc, TypeCode.String));

         }

        protected override void Insert()
         {
        HPS.BLL.ClassBLL.BLLClass_TFactory ClassFactory =new HPS.BLL.ClassBLL.BLLClass_TFactory();
            try
              {
                  HPS.BLL.ClassBLL.BLLClass_T ClassEntity =new HPS.BLL.ClassBLL.BLLClass_T();
                  ClassEntity.ClassName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ClassName_nvcTextBox.Text, TypeCode.String).ToString();

                  ClassFactory.BeginProc();
                  ClassFactory.Insert(ClassEntity);
                  ClassFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ClassEntity.ClassID_int, TypeCode.Int32);
dr[HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ClassEntity.ClassName_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 ClassFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.ClassBLL.BLLClass_TFactory ClassFactory =new HPS.BLL.ClassBLL.BLLClass_TFactory();
            try
              {
                  HPS.BLL.ClassBLL.BLLClass_T ClassEntity =new HPS.BLL.ClassBLL.BLLClass_T();
                  ClassEntity.ClassName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ClassName_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  ClassFactory.BeginProc();
                  ClassFactory.Update(ClassEntity,(HPS.BLL.ClassBLL.BLLClass_TKeys)Key);
                  ClassFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassID_int.ToString() + "='" +((HPS.BLL.ClassBLL.BLLClass_TKeys)Key).ClassID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ClassEntity.ClassName_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   ClassFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.ClassBLL.BLLClass_TFactory ClassFactory =new HPS.BLL.ClassBLL.BLLClass_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    ClassFactory.BeginProc();
                    ClassFactory.Delete((HPS.BLL.ClassBLL.BLLClass_TKeys)Key);
                    ClassFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassID_int.ToString() + "='" + ((HPS.BLL.ClassBLL.BLLClass_TKeys)Key).ClassID_int.ToString()+"'");
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
                  ClassFactory.RollBackProc();
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