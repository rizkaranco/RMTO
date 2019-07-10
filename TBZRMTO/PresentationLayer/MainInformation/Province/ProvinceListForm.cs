using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Province
{
    public partial class ProvinceListForm : Hepsa.Core.PL.BaseListForm
    {
        public ProvinceListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group ProvinceGroup = new Hepsa.Core.PL.BaseListForm.Group();
                ProvinceGroup.AddButton = this.NewButton;
                ProvinceGroup.DeleteButton = this.DeleteButton;
                ProvinceGroup.EditButton = this.EditButton;
                ProvinceGroup.RefreshButton = this.RefreshButton;
                ProvinceGroup.ExportButton = this.ExportButton;
                ProvinceGroup.set_Grid(true,true,true, this.ProvinceGridView);
                ProvinceGroup.ToolStrip = this.ProvinceToolStrip;
                ProvinceGroup.HasFilterControl = true;

            this.Groups.Add(ProvinceGroup);

        }

         private void ProvinceListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadProvince();
            this.ProvinceGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadProvince()
        {
            try
            {
               HPS.BLL.ProvinceBLL.BLLProvince_TFactory ProvinceFactory = new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();
               DataTable ProvinceDataTable= new DataTable();
               ProvinceFactory.GetAll(ref ProvinceDataTable);
               this.ProvinceGridView.DataSource = ProvinceDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          ProvinceEntityForm Province=new ProvinceEntityForm((DataTable)this.ProvinceGridView.DataSource);
          Province.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.ProvinceBLL.BLLProvince_TKeys ProvinceKey= new HPS.BLL.ProvinceBLL.BLLProvince_TKeys();
          ProvinceKey.Province_int = (Int32?)this.ProvinceGridView.CurrentRow.Cells["colProvince_int"].Value;
          ProvinceEntityForm Province=new ProvinceEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.ProvinceGridView.DataSource, ProvinceKey);
          Province.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.ProvinceBLL.BLLProvince_TFactory ProvinceFactory=new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.ProvinceBLL.BLLProvince_TFactory Province_TFactory = new HPS.BLL.ProvinceBLL.BLLProvince_TFactory();
            HPS.BLL.ProvinceBLL.BLLProvince_TKeys ProvinceKey= new HPS.BLL.ProvinceBLL.BLLProvince_TKeys();

            ProvinceKey.Province_int = (Int32?)ProvinceGridView.CurrentRow.Cells["colProvince_int"].Value;
            ProvinceFactory.Delete(ProvinceKey);

            DataRow[] dr=((DataTable)this.ProvinceGridView.DataSource).Select(HPS.BLL.ProvinceBLL.BLLProvince_T.Province_TField.Province_int.ToString() + "='" +ProvinceKey.Province_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.ProvinceGridView.DataSource).AcceptChanges();
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
                this.LoadProvince();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}