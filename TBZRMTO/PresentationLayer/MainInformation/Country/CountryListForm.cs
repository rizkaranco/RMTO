using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Country
{
    public partial class CountryListForm : Hepsa.Core.PL.BaseListForm
    {
        public CountryListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group CountryGroup = new Hepsa.Core.PL.BaseListForm.Group();
                CountryGroup.AddButton = this.NewButton;
                CountryGroup.DeleteButton = this.DeleteButton;
                CountryGroup.EditButton = this.EditButton;
                CountryGroup.RefreshButton = this.RefreshButton;
                CountryGroup.ExportButton = this.ExportButton;
                CountryGroup.set_Grid(true,true,true, this.CountryGridView);
                CountryGroup.ToolStrip = this.CountryToolStrip;
                CountryGroup.HasFilterControl = true;

            this.Groups.Add(CountryGroup);

        }

         private void CountryListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadCountry();
            this.CountryGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadCountry()
        {
            try
            {
               HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
               DataTable CountryDataTable= new DataTable();
               CountryFactory.GetAll(ref CountryDataTable);
               this.CountryGridView.DataSource = CountryDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          CountryEntityForm Country=new CountryEntityForm((DataTable)this.CountryGridView.DataSource);
          Country.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.CountryBLL.BLLCountry_TKeys CountryKey= new HPS.BLL.CountryBLL.BLLCountry_TKeys();
          CountryKey.CountryID_int = (Int32?)this.CountryGridView.CurrentRow.Cells["colCountryID_int"].Value;
          CountryEntityForm Country=new CountryEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CountryGridView.DataSource, CountryKey);
          Country.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory=new HPS.BLL.CountryBLL.BLLCountry_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.CountryBLL.BLLCountry_TFactory Country_TFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
            HPS.BLL.CountryBLL.BLLCountry_TKeys CountryKey= new HPS.BLL.CountryBLL.BLLCountry_TKeys();

            CountryKey.CountryID_int = (Int32?)CountryGridView.CurrentRow.Cells["colCountryID_int"].Value;
            CountryFactory.Delete(CountryKey);

            DataRow[] dr=((DataTable)this.CountryGridView.DataSource).Select(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString() + "='" +CountryKey.CountryID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.CountryGridView.DataSource).AcceptChanges();
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
                this.LoadCountry();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}