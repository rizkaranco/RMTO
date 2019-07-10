using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present
{
    public partial class CompanyMobileListForm : Hepsa.Core.PL.BaseListForm
    {
        public CompanyMobileListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group CompanyMobileGroup = new Hepsa.Core.PL.BaseListForm.Group();
                CompanyMobileGroup.AddButton = this.NewCompanyMobileButton;
                CompanyMobileGroup.DeleteButton = this.DeleteCompanyMobileButton;
                CompanyMobileGroup.EditButton = this.EditCompanyMobileButton;
                CompanyMobileGroup.RefreshButton = this.RefreshCompanyMobileButton;
                CompanyMobileGroup.ExportButton = this.ExportCompanyMobileButton;
                CompanyMobileGroup.set_Grid(true,true,true, this.CompanyMobileGridView);
                CompanyMobileGroup.ToolStrip = this.CompanyMobileToolStrip;
                CompanyMobileGroup.HasFilterControl = true;

            this.Groups.Add(CompanyMobileGroup);

        }

         private void CompanyMobileListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadCompanyMobile();
            this.CompanyMobileGridView.Focus();
          }
        catch (System.Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadCompanyMobile()
        {
            try
            {
               HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory = new HPS.BLL.BLLCompanyMobile_TFactory();
               DataTable CompanyMobileDataTable= new DataTable();
               CompanyMobileFactory.GetAll(ref CompanyMobileDataTable);
               this.CompanyMobileGridView.DataSource = CompanyMobileDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewCompanyMobileButton_Click(object sender, EventArgs e)
        {
          //CompanyMobileEntityForm CompanyMobile=new CompanyMobileEntityForm((DataTable)this.CompanyMobileGridView.DataSource);
          //CompanyMobile.ShowDialog();
        }

        private void EditCompanyMobileButton_Click(object sender,EventArgs e)
        {
          //HPS.BLL.BLLCompanyMobile_TKeys CompanyMobileKey= new HPS.BLL.BLLCompanyMobile_TKeys();
          //CompanyMobileKey.CompanyMobileID_int = (Int32)this.CompanyMobileGridView.CurrentRow.Cells["colCompanyMobileID_int"].Value;
          //CompanyMobileEntityForm CompanyMobile=new CompanyMobileEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CompanyMobileGridView.DataSource, CompanyMobileKey);
          //CompanyMobile.ShowDialog();
        }

        private void DeleteCompanyMobileButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory=new HPS.BLL.BLLCompanyMobile_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.BLLCompanyMobile_TFactory CompanyMobile_TFactory = new HPS.BLL.BLLCompanyMobile_TFactory();
            HPS.BLL.BLLCompanyMobile_TKeys CompanyMobileKey= new HPS.BLL.BLLCompanyMobile_TKeys();

            CompanyMobileKey.CompanyMobileID_int = (Int32)CompanyMobileGridView.CurrentRow.Cells["colCompanyMobileID_int"].Value;
            CompanyMobileFactory.Delete(CompanyMobileKey);

            DataRow[] dr=((DataTable)this.CompanyMobileGridView.DataSource).Select(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyMobileID_int.ToString() + "='" +CompanyMobileKey.CompanyMobileID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.CompanyMobileGridView.DataSource).AcceptChanges();
            }

            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshCompanyMobileButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.LoadCompanyMobile();
            }
            catch(System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
     }
}