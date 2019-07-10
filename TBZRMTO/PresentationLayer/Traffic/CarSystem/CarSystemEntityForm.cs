using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.CarSystem
{
    public partial class CarSystemEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CarSystemEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public CarSystemEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void CarSystemEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory =new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
        HPS.BLL.CarSystemBLL.BLLCarSystem_T CarSystemEntity = CarSystemFactory.GetBy((HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys)Key);
        if(CarSystemEntity ==null)
            {
               throw new HPS.Exceptions.CarSystemNotFound();
            }
        CarSystem_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarSystemEntity.CarSystem_nvc, TypeCode.String));

         }

        protected override void Insert()
         {
        HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory =new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
            try
              {
                  HPS.BLL.CarSystemBLL.BLLCarSystem_T CarSystemEntity =new HPS.BLL.CarSystemBLL.BLLCarSystem_T();
                  CarSystemEntity.CarSystem_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarSystem_nvcTextBox.Text, TypeCode.String).ToString();

                  CarSystemFactory.BeginProc();
                  CarSystemFactory.Insert(CarSystemEntity);
                  CarSystemFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystemID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarSystemEntity.CarSystemID_int, TypeCode.Int32);
dr[HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystem_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarSystemEntity.CarSystem_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 CarSystemFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory =new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
            try
              {
                  HPS.BLL.CarSystemBLL.BLLCarSystem_T CarSystemEntity =new HPS.BLL.CarSystemBLL.BLLCarSystem_T();
                  CarSystemEntity.CarSystem_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarSystem_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  CarSystemFactory.BeginProc();
                  CarSystemFactory.Update(CarSystemEntity,(HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys)Key);
                  CarSystemFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystemID_int.ToString() + "='" +((HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys)Key).CarSystemID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystem_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarSystemEntity.CarSystem_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   CarSystemFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory =new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    CarSystemFactory.BeginProc();
                    CarSystemFactory.Delete((HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys)Key);
                    CarSystemFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystemID_int.ToString() + "='" + ((HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys)Key).CarSystemID_int.ToString()+"'");
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
                  CarSystemFactory.RollBackProc();
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