using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.CarSystem
{
    public partial class CarSystemListForm : Hepsa.Core.PL.BaseListForm
    {
        public CarSystemListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group CarSystemGroup = new Hepsa.Core.PL.BaseListForm.Group();
                CarSystemGroup.AddButton = this.NewButton;
                CarSystemGroup.DeleteButton = this.DeleteButton;
                CarSystemGroup.EditButton = this.EditButton;
                CarSystemGroup.RefreshButton = this.RefreshButton;
                CarSystemGroup.ExportButton = this.ExportButton;
                CarSystemGroup.set_Grid(true,true,true, this.CarSystemGridView);
                CarSystemGroup.ToolStrip = this.CarSystemToolStrip;
                CarSystemGroup.HasFilterControl = true;

            this.Groups.Add(CarSystemGroup);

        }

         private void CarSystemListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadCarSystem();
            this.CarSystemGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadCarSystem()
        {
            try
            {
               HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory = new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
               DataTable CarSystemDataTable= new DataTable();
               CarSystemFactory.GetAll(ref CarSystemDataTable);
               this.CarSystemGridView.DataSource = CarSystemDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          CarSystemEntityForm CarSystem=new CarSystemEntityForm((DataTable)this.CarSystemGridView.DataSource);
          CarSystem.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys CarSystemKey= new HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys();
          CarSystemKey.CarSystemID_int = (Int32)this.CarSystemGridView.CurrentRow.Cells["colCarSystemID_int"].Value;
          CarSystemEntityForm CarSystem=new CarSystemEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CarSystemGridView.DataSource, CarSystemKey);
          CarSystem.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory=new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystem_TFactory = new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
            HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys CarSystemKey= new HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys();

            CarSystemKey.CarSystemID_int = (Int32)CarSystemGridView.CurrentRow.Cells["colCarSystemID_int"].Value;
            CarSystemFactory.Delete(CarSystemKey);

            DataRow[] dr=((DataTable)this.CarSystemGridView.DataSource).Select(HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystemID_int.ToString() + "='" +CarSystemKey.CarSystemID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.CarSystemGridView.DataSource).AcceptChanges();
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.LoadCarSystem();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}