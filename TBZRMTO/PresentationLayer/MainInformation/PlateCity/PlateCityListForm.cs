using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.PlateCity
{
    public partial class PlateCityListForm : Hepsa.Core.PL.BaseListForm
    {
        public PlateCityListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group PlateCityGroup = new Hepsa.Core.PL.BaseListForm.Group();
                PlateCityGroup.AddButton = this.NewButton;
                PlateCityGroup.DeleteButton = this.DeleteButton;
                PlateCityGroup.EditButton = this.EditButton;
                PlateCityGroup.RefreshButton = this.RefreshButton;
                PlateCityGroup.ExportButton = this.ExportButton;
                PlateCityGroup.set_Grid(true,true,true, this.PlateCityGridView);
                PlateCityGroup.ToolStrip = this.PlateCityToolStrip;
                PlateCityGroup.HasFilterControl = true;

            this.Groups.Add(PlateCityGroup);

        }

         private void PlateCityListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadPlateCity();
            this.PlateCityGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadPlateCity()
        {
            try
            {
               HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
               DataTable PlateCityDataTable= new DataTable();
               PlateCityFactory.GetAll(ref PlateCityDataTable);
               this.PlateCityGridView.DataSource = PlateCityDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          PlateCityEntityForm PlateCity=new PlateCityEntityForm((DataTable)this.PlateCityGridView.DataSource);
          PlateCity.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey= new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
          PlateCityKey.PlateCityID_int = (Int32?)this.PlateCityGridView.CurrentRow.Cells["colPlateCityID_int"].Value;
          PlateCityEntityForm PlateCity=new PlateCityEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.PlateCityGridView.DataSource, PlateCityKey);
          PlateCity.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory=new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCity_TFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey= new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();

            PlateCityKey.PlateCityID_int = (Int32?)PlateCityGridView.CurrentRow.Cells["colPlateCityID_int"].Value;
            PlateCityFactory.Delete(PlateCityKey);

            DataRow[] dr=((DataTable)this.PlateCityGridView.DataSource).Select(HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString() + "='" +PlateCityKey.PlateCityID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.PlateCityGridView.DataSource).AcceptChanges();
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
                this.LoadPlateCity();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}