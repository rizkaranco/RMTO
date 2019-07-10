using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.PortPlaces
{
    public partial class PortPlacesEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public PortPlacesEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public PortPlacesEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void PortPlacesEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory =new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
        HPS.BLL.PortPlacesBLL.BLLPortPlaces_T PortPlacesEntity = PortPlacesFactory.GetBy((HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys)Key);
        if(PortPlacesEntity ==null)
            {
               throw new HPS.Exceptions.PortPlacesNotFound();
            }
        PortPlaces_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlacesEntity.PortPlaces_nvc, TypeCode.String).ToString();
Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlacesEntity.Active_bit, TypeCode.Boolean);

         }

        protected override void Insert()
         {
        HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory =new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            try
              {
                  HPS.BLL.PortPlacesBLL.BLLPortPlaces_T PortPlacesEntity =new HPS.BLL.PortPlacesBLL.BLLPortPlaces_T();
                  PortPlacesEntity.PortPlaces_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaces_nvcTextBox.Text, TypeCode.String).ToString();
PortPlacesEntity.Active_bit = Active_bitCheckBox.Checked;

                  PortPlacesFactory.BeginProc();
                  PortPlacesFactory.Insert(PortPlacesEntity);
                  PortPlacesFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PortPlacesEntity.PortPlacesID_int, TypeCode.Int32);
dr[HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PortPlacesEntity.PortPlaces_nvc, TypeCode.String);
dr[HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PortPlacesEntity.Active_bit, TypeCode.Boolean);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 PortPlacesFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory =new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            try
              {
                  HPS.BLL.PortPlacesBLL.BLLPortPlaces_T PortPlacesEntity =new HPS.BLL.PortPlacesBLL.BLLPortPlaces_T();
                  PortPlacesEntity.PortPlaces_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaces_nvcTextBox.Text, TypeCode.String).ToString();
PortPlacesEntity.Active_bit = Active_bitCheckBox.Checked;

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  PortPlacesFactory.BeginProc();
                  PortPlacesFactory.Update(PortPlacesEntity,(HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys)Key);
                  PortPlacesFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString() + "='" +((HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys)Key).PortPlacesID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PortPlacesEntity.PortPlaces_nvc, TypeCode.String);
dr[0][HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(PortPlacesEntity.Active_bit, TypeCode.Boolean);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   PortPlacesFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory =new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    PortPlacesFactory.BeginProc();
                    PortPlacesFactory.Delete((HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys)Key);
                    PortPlacesFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString() + "='" + ((HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys)Key).PortPlacesID_int.ToString()+"'");
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
                  PortPlacesFactory.RollBackProc();
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