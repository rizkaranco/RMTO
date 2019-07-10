using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.DestinationAddress
{
    public partial class DestinationAddressEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public DestinationAddressEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public DestinationAddressEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void DestinationAddressEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();
        HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T DestinationAddressEntity = DestinationAddressFactory.GetBy((HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys)Key);
        if(DestinationAddressEntity ==null)
            {
               throw new HPS.Exceptions.DestinationAddressNotFound();
            }
        DestinationAddress_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DestinationAddressEntity.DestinationAddress_nvc, TypeCode.String));

         }

        protected override void Insert()
         {
        HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();
            try
              {
                  HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T DestinationAddressEntity =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T();
                  DestinationAddressEntity.DestinationAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DestinationAddress_nvcTextBox.Text, TypeCode.String).ToString();

                  DestinationAddressFactory.BeginProc();
                  DestinationAddressFactory.Insert(DestinationAddressEntity);
                  DestinationAddressFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddressID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DestinationAddressEntity.DestinationAddressID_int, TypeCode.Int32);
dr[HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DestinationAddressEntity.DestinationAddress_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 DestinationAddressFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();
            try
              {
                  HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T DestinationAddressEntity =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T();
                  DestinationAddressEntity.DestinationAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DestinationAddress_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  DestinationAddressFactory.BeginProc();
                  DestinationAddressFactory.Update(DestinationAddressEntity,(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys)Key);
                  DestinationAddressFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddressID_int.ToString() + "='" +((HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys)Key).DestinationAddressID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DestinationAddressEntity.DestinationAddress_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   DestinationAddressFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    DestinationAddressFactory.BeginProc();
                    DestinationAddressFactory.Delete((HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys)Key);
                    DestinationAddressFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddressID_int.ToString() + "='" + ((HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys)Key).DestinationAddressID_int.ToString()+"'");
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
                  DestinationAddressFactory.RollBackProc();
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