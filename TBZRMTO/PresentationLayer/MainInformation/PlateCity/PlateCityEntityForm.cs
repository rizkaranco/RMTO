using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.PlateCity
{
    public partial class PlateCityEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public PlateCityEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public PlateCityEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void PlateCityEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory =new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
        HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy((HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys)Key);
        if(PlateCityEntity ==null)
            {
               throw new HPS.Exceptions.PlateCityNotFound();
            }
        PlateCityCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityEntity.PlateCityCode_nvc, TypeCode.String).ToString();
PlateCity_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityEntity.PlateCity_nvc, TypeCode.String).ToString();
Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityEntity.Active_bit, TypeCode.Boolean);

         }

        protected override void Insert()
         {
        HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory =new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            try
              {
                  HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity =new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
                  PlateCityEntity.PlateCityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityCode_nvcTextBox.Text, TypeCode.String).ToString();
PlateCityEntity.PlateCity_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCity_nvcTextBox.Text, TypeCode.String).ToString();
PlateCityEntity.Active_bit = Active_bitCheckBox.Checked;

                  PlateCityFactory.BeginProc();
                  PlateCityFactory.Insert(PlateCityEntity);
                  PlateCityFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.PlateCityID_int, TypeCode.Int32);
dr[HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.PlateCityCode_nvc, TypeCode.String);
dr[HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCity_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.PlateCity_nvc, TypeCode.String);
dr[HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.Active_bit, TypeCode.Boolean);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 PlateCityFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory =new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            try
              {
                  HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity =new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
                  PlateCityEntity.PlateCityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityCode_nvcTextBox.Text, TypeCode.String).ToString();
PlateCityEntity.PlateCity_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCity_nvcTextBox.Text, TypeCode.String).ToString();
PlateCityEntity.Active_bit = Active_bitCheckBox.Checked;

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  PlateCityFactory.BeginProc();
                  PlateCityFactory.Update(PlateCityEntity,(HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys)Key);
                  PlateCityFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString() + "='" +((HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys)Key).PlateCityID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.PlateCityCode_nvc, TypeCode.String);
dr[0][HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCity_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.PlateCity_nvc, TypeCode.String);
dr[0][HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PlateCityEntity.Active_bit, TypeCode.Boolean);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   PlateCityFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory =new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    PlateCityFactory.BeginProc();
                    PlateCityFactory.Delete((HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys)Key);
                    PlateCityFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString() + "='" + ((HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys)Key).PlateCityID_int.ToString()+"'");
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
                  PlateCityFactory.RollBackProc();
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