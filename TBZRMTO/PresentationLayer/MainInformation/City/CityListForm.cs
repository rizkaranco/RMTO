using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.City
{
    public partial class CityListForm : Hepsa.Core.PL.BaseListForm
    {
        public CityListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group CityGroup = new Hepsa.Core.PL.BaseListForm.Group();
                CityGroup.AddButton = this.NewButton;
                CityGroup.DeleteButton = this.DeleteButton;
                CityGroup.EditButton = this.EditButton;
                CityGroup.RefreshButton = this.RefreshButton;
                CityGroup.ExportButton = this.ExportButton;
                CityGroup.set_Grid(true,true,true, this.CityGridView);
                CityGroup.ToolStrip = this.CityToolStrip;
                CityGroup.HasFilterControl = true;

            this.Groups.Add(CityGroup);

        }

         private void CityListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadCity();
            this.CityGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadCity()
        {
            try
            {
               HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
               DataTable CityDataTable= new DataTable();
               CityFactory.GetAll(ref CityDataTable);
               this.CityGridView.DataSource = CityDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          CityEntityForm City=new CityEntityForm((DataTable)this.CityGridView.DataSource);
          City.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.CityBLL.BLLCity_TKeys CityKey= new HPS.BLL.CityBLL.BLLCity_TKeys();
          CityKey.CityID_int = (Int32?)this.CityGridView.CurrentRow.Cells["colCityID_int"].Value;
          CityEntityForm City=new CityEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CityGridView.DataSource, CityKey);
          City.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.CityBLL.BLLCity_TFactory CityFactory=new HPS.BLL.CityBLL.BLLCity_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.CityBLL.BLLCity_TFactory City_TFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            HPS.BLL.CityBLL.BLLCity_TKeys CityKey= new HPS.BLL.CityBLL.BLLCity_TKeys();

            CityKey.CityID_int = (Int32?)CityGridView.CurrentRow.Cells["colCityID_int"].Value;
            CityFactory.Delete(CityKey);

            DataRow[] dr=((DataTable)this.CityGridView.DataSource).Select(HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString() + "='" +CityKey.CityID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.CityGridView.DataSource).AcceptChanges();
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
                this.LoadCity();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}