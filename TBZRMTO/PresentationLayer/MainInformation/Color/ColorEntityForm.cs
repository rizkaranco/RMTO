using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.Color
{
    public partial class ColorEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public ColorEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public ColorEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.ColorBLL.BLLColor_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void ColorEntityForm_Load(object sender,EventArgs e)
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
        HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory =new HPS.BLL.ColorBLL.BLLColor_TFactory();
        HPS.BLL.ColorBLL.BLLColor_T ColorEntity = ColorFactory.GetBy((HPS.BLL.ColorBLL.BLLColor_TKeys)Key);
        if(ColorEntity ==null)
            {
               throw new HPS.Exceptions.ColorNotFound();
            }
        Color_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(ColorEntity.Color_nvc, TypeCode.String));
ColorCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(ColorEntity.ColorCode_nvc, TypeCode.String));

         }

        protected override void Insert()
         {
        HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory =new HPS.BLL.ColorBLL.BLLColor_TFactory();
            try
              {
                  HPS.BLL.ColorBLL.BLLColor_T ColorEntity =new HPS.BLL.ColorBLL.BLLColor_T();
                  ColorEntity.Color_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Color_nvcTextBox.Text, TypeCode.String).ToString();
ColorEntity.ColorCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ColorCode_nvcTextBox.Text, TypeCode.String).ToString();

                  ColorFactory.BeginProc();
                  ColorFactory.Insert(ColorEntity);
                  ColorFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ColorEntity.ColorID_int, TypeCode.Int32);
dr[HPS.BLL.ColorBLL.BLLColor_T.Color_TField.Color_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ColorEntity.Color_nvc, TypeCode.String);
dr[HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ColorEntity.ColorCode_nvc, TypeCode.String);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 ColorFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory =new HPS.BLL.ColorBLL.BLLColor_TFactory();
            try
              {
                  HPS.BLL.ColorBLL.BLLColor_T ColorEntity =new HPS.BLL.ColorBLL.BLLColor_T();
                  ColorEntity.Color_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Color_nvcTextBox.Text, TypeCode.String).ToString();
ColorEntity.ColorCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ColorCode_nvcTextBox.Text, TypeCode.String).ToString();

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  ColorFactory.BeginProc();
                  ColorFactory.Update(ColorEntity,(HPS.BLL.ColorBLL.BLLColor_TKeys)Key);
                  ColorFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorID_int.ToString() + "='" +((HPS.BLL.ColorBLL.BLLColor_TKeys)Key).ColorID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.ColorBLL.BLLColor_T.Color_TField.Color_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ColorEntity.Color_nvc, TypeCode.String);
dr[0][HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ColorEntity.ColorCode_nvc, TypeCode.String);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   ColorFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory =new HPS.BLL.ColorBLL.BLLColor_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    ColorFactory.BeginProc();
                    ColorFactory.Delete((HPS.BLL.ColorBLL.BLLColor_TKeys)Key);
                    ColorFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorID_int.ToString() + "='" + ((HPS.BLL.ColorBLL.BLLColor_TKeys)Key).ColorID_int.ToString()+"'");
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
                  ColorFactory.RollBackProc();
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