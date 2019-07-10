using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.Country
{
    public partial class CountryEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CountryEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public CountryEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.CountryBLL.BLLCountry_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void CountryEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory =new HPS.BLL.CountryBLL.BLLCountry_TFactory();
        HPS.BLL.CountryBLL.BLLCountry_T CountryEntity = CountryFactory.GetBy((HPS.BLL.CountryBLL.BLLCountry_TKeys)Key);
        if(CountryEntity ==null)
            {
               throw new HPS.Exceptions.CountryNotFound();
            }
        CountryCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CountryEntity.CountryCode_nvc, TypeCode.String).ToString();
Country_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CountryEntity.Country_nvc, TypeCode.String).ToString();
Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(CountryEntity.Active_bit, TypeCode.Boolean);

         }

        protected override void Insert()
         {
        HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory =new HPS.BLL.CountryBLL.BLLCountry_TFactory();
            try
              {
                  HPS.BLL.CountryBLL.BLLCountry_T CountryEntity =new HPS.BLL.CountryBLL.BLLCountry_T();
                  CountryEntity.CountryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CountryCode_nvcTextBox.Text, TypeCode.String).ToString();
CountryEntity.Country_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Country_nvcTextBox.Text, TypeCode.String).ToString();
CountryEntity.Active_bit = Active_bitCheckBox.Checked;

                  CountryFactory.BeginProc();
                  CountryFactory.Insert(CountryEntity);
                  CountryFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.CountryID_int, TypeCode.Int32);
dr[HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.CountryCode_nvc, TypeCode.String);
dr[HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.Country_nvc, TypeCode.String);
dr[HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.Active_bit, TypeCode.Boolean);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 CountryFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory =new HPS.BLL.CountryBLL.BLLCountry_TFactory();
            try
              {
                  HPS.BLL.CountryBLL.BLLCountry_T CountryEntity =new HPS.BLL.CountryBLL.BLLCountry_T();
                  CountryEntity.CountryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CountryCode_nvcTextBox.Text, TypeCode.String).ToString();
CountryEntity.Country_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Country_nvcTextBox.Text, TypeCode.String).ToString();
CountryEntity.Active_bit = Active_bitCheckBox.Checked;

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  CountryFactory.BeginProc();
                  CountryFactory.Update(CountryEntity,(HPS.BLL.CountryBLL.BLLCountry_TKeys)Key);
                  CountryFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString() + "='" +((HPS.BLL.CountryBLL.BLLCountry_TKeys)Key).CountryID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.CountryCode_nvc, TypeCode.String);
dr[0][HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.Country_nvc, TypeCode.String);
dr[0][HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CountryEntity.Active_bit, TypeCode.Boolean);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   CountryFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory =new HPS.BLL.CountryBLL.BLLCountry_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    CountryFactory.BeginProc();
                    CountryFactory.Delete((HPS.BLL.CountryBLL.BLLCountry_TKeys)Key);
                    CountryFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString() + "='" + ((HPS.BLL.CountryBLL.BLLCountry_TKeys)Key).CountryID_int.ToString()+"'");
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
                  CountryFactory.RollBackProc();
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