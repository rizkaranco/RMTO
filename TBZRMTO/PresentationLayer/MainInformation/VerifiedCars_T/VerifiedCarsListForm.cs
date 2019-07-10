using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.VerifiedCars
{
    public partial class VerifiedCarsListForm : Hepsa.Core.PL.BaseListForm
    {
        public VerifiedCarsListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group VerifiedCarsGroup = new Hepsa.Core.PL.BaseListForm.Group();
                VerifiedCarsGroup.AddButton = this.NewVerifiedCarsButton;
                VerifiedCarsGroup.EditButton = this.EditVerifiedCarsButton;
                VerifiedCarsGroup.RefreshButton = this.RefreshVerifiedCarsButton;
                VerifiedCarsGroup.ExportButton = this.ExportVerifiedCarsButton;
                VerifiedCarsGroup.set_Grid(true,true,true, this.VerifiedCarsGridView);
                VerifiedCarsGroup.ToolStrip = this.VerifiedCarsToolStrip;
                VerifiedCarsGroup.HasFilterControl = true;

            this.Groups.Add(VerifiedCarsGroup);

        }

         private void VerifiedCarsListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadVerifiedCars();
            this.VerifiedCarsGridView.Focus();
          }
        catch (System.Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadVerifiedCars()
        {
            try
            {
               BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();
               DataTable VerifiedCarsDataTable= new DataTable();
               VerifiedCarsFactory.GetAll(ref VerifiedCarsDataTable);
               this.VerifiedCarsGridView.DataSource = VerifiedCarsDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewVerifiedCarsButton_Click(object sender, EventArgs e)
        {
          VerifiedCarsEntityForm VerifiedCars=new VerifiedCarsEntityForm((DataTable)this.VerifiedCarsGridView.DataSource);
          VerifiedCars.ShowDialog();
        }

        private void EditVerifiedCarsButton_Click(object sender,EventArgs e)
        {
          BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys VerifiedCarsKey= new BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys();
          VerifiedCarsKey.VerifiedCarID_int = (Int32)this.VerifiedCarsGridView.CurrentRow.Cells["colVerifiedCarID_int"].Value;
          VerifiedCarsEntityForm VerifiedCars=new VerifiedCarsEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.VerifiedCarsGridView.DataSource, VerifiedCarsKey);
          VerifiedCars.ShowDialog();
        }

        private void DeleteVerifiedCarsButton_Click(object sender,EventArgs e)
        {
        BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCarsFactory=new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifiedCars_TFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();
            BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys VerifiedCarsKey= new BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys();

            VerifiedCarsKey.VerifiedCarID_int = (Int32)VerifiedCarsGridView.CurrentRow.Cells["colVerifiedCarID_int"].Value;
            VerifiedCarsFactory.Delete(VerifiedCarsKey);

            DataRow[] dr=((DataTable)this.VerifiedCarsGridView.DataSource).Select(BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.VerifiedCarID_int.ToString() + "='" +VerifiedCarsKey.VerifiedCarID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.VerifiedCarsGridView.DataSource).AcceptChanges();
            }

            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshVerifiedCarsButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.LoadVerifiedCars();
            }
            catch(System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}