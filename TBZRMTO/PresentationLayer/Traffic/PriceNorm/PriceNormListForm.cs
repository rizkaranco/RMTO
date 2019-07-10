using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.PriceNorm
{
    public partial class PriceNormListForm : Hepsa.Core.PL.BaseListForm
    {
        public PriceNormListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group PriceNormGroup = new Hepsa.Core.PL.BaseListForm.Group();
                PriceNormGroup.AddButton = this.NewButton;
                PriceNormGroup.EditButton = this.EditButton;
                PriceNormGroup.RefreshButton = this.RefreshButton;
                PriceNormGroup.ExportButton = this.ExportButton;
                PriceNormGroup.set_Grid(true,true,true, this.PriceNormGridView);
                PriceNormGroup.ToolStrip = this.PriceNormToolStrip;
                PriceNormGroup.HasFilterControl = true;

            this.Groups.Add(PriceNormGroup);

        }

         private void PriceNormListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadPriceNorm();
            this.PriceNormGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadPriceNorm()
        {
            try
            {
               HPS.BLL.PriceNormBLL.BLLPriceNorm_TFactory PriceNormFactory = new HPS.BLL.PriceNormBLL.BLLPriceNorm_TFactory();
               DataTable PriceNormDataTable= new DataTable();
               PriceNormFactory.GetAll(ref PriceNormDataTable);
               this.PriceNormGridView.DataSource = PriceNormDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          //PriceNormEntityForm PriceNorm=new PriceNormEntityForm((DataTable)this.PriceNormGridView.DataSource);
          //PriceNorm.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          //HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys PriceNormKey= new HPS.BLL.PriceNormBLL.BLLPriceNorm_TKeys();
          //PriceNormKey.PriceNormID_int = (Int32)this.PriceNormGridView.CurrentRow.Cells["colPriceNormID_int"].Value;
          //PriceNormEntityForm PriceNorm=new PriceNormEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.PriceNormGridView.DataSource, PriceNormKey);
          //PriceNorm.ShowDialog();
        }

        

        private void RefreshButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.LoadPriceNorm();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}