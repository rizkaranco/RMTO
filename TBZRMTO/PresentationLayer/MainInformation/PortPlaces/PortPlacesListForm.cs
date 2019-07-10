using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.PortPlaces
{
    public partial class PortPlacesListForm : Hepsa.Core.PL.BaseListForm
    {
        public PortPlacesListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group PortPlacesGroup = new Hepsa.Core.PL.BaseListForm.Group();
                PortPlacesGroup.AddButton = this.NewButton;
                PortPlacesGroup.DeleteButton = this.DeleteButton;
                PortPlacesGroup.EditButton = this.EditButton;
                PortPlacesGroup.RefreshButton = this.RefreshButton;
                PortPlacesGroup.ExportButton = this.ExportButton;
                PortPlacesGroup.set_Grid(true,true,true, this.PortPlacesGridView);
                PortPlacesGroup.ToolStrip = this.PortPlacesToolStrip;
                PortPlacesGroup.HasFilterControl = true;

            this.Groups.Add(PortPlacesGroup);

        }

         private void PortPlacesListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadPortPlaces();
            this.PortPlacesGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadPortPlaces()
        {
            try
            {
               HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
               DataTable PortPlacesDataTable= new DataTable();
               PortPlacesFactory.GetAll(ref PortPlacesDataTable);
               this.PortPlacesGridView.DataSource = PortPlacesDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          PortPlacesEntityForm PortPlaces=new PortPlacesEntityForm((DataTable)this.PortPlacesGridView.DataSource);
          PortPlaces.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys PortPlacesKey= new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys();
          PortPlacesKey.PortPlacesID_int = (Int32?)this.PortPlacesGridView.CurrentRow.Cells["colPortPlacesID_int"].Value;
          PortPlacesEntityForm PortPlaces=new PortPlacesEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.PortPlacesGridView.DataSource, PortPlacesKey);
          PortPlaces.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlacesFactory=new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaces_TFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys PortPlacesKey= new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys();

            PortPlacesKey.PortPlacesID_int = (Int32?)PortPlacesGridView.CurrentRow.Cells["colPortPlacesID_int"].Value;
            PortPlacesFactory.Delete(PortPlacesKey);

            DataRow[] dr=((DataTable)this.PortPlacesGridView.DataSource).Select(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString() + "='" +PortPlacesKey.PortPlacesID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.PortPlacesGridView.DataSource).AcceptChanges();
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
                this.LoadPortPlaces();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}