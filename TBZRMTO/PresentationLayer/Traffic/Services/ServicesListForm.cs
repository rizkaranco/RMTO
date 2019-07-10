using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Services
{
    public partial class ServicesListForm : Hepsa.Core.PL.BaseListForm
    {
        public ServicesListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group ServicesGroup = new Hepsa.Core.PL.BaseListForm.Group();
                ServicesGroup.AddButton = this.NewButton;
                ServicesGroup.DeleteButton = this.DeleteButton;
                ServicesGroup.EditButton = this.EditButton;
                ServicesGroup.RefreshButton = this.RefreshButton;
                ServicesGroup.ExportButton = this.ExportButton;
                ServicesGroup.set_Grid(true,true,true, this.ServicesGridView);
                ServicesGroup.ToolStrip = this.ServicesToolStrip;
                ServicesGroup.HasFilterControl = true;

            this.Groups.Add(ServicesGroup);

        }

         private void ServicesListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadServices();
            this.ServicesGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadServices()
        {
            try
            {
               HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
               DataTable ServicesDataTable= new DataTable();
               ServicesFactory.GetAll(ref ServicesDataTable);
               this.ServicesGridView.DataSource = ServicesDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          ServicesEntityForm Services=new ServicesEntityForm((DataTable)this.ServicesGridView.DataSource);
          Services.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.ServicesBLL.BLLServices_TKeys ServicesKey= new HPS.BLL.ServicesBLL.BLLServices_TKeys();
          ServicesKey.ServicesID_int = (Int32?)this.ServicesGridView.CurrentRow.Cells["colServicesID_int"].Value;
          ServicesEntityForm Services=new ServicesEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.ServicesGridView.DataSource, ServicesKey);
          Services.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory=new HPS.BLL.ServicesBLL.BLLServices_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.ServicesBLL.BLLServices_TFactory Services_TFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            HPS.BLL.ServicesBLL.BLLServices_TKeys ServicesKey= new HPS.BLL.ServicesBLL.BLLServices_TKeys();

            ServicesKey.ServicesID_int = (Int32?)ServicesGridView.CurrentRow.Cells["colServicesID_int"].Value;
            ServicesFactory.Delete(ServicesKey);

            DataRow[] dr=((DataTable)this.ServicesGridView.DataSource).Select(HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString() + "='" +ServicesKey.ServicesID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.ServicesGridView.DataSource).AcceptChanges();
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
                this.LoadServices();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}