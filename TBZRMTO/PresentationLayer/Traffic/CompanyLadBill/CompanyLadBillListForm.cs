using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.CompanyLadBill
{
    public partial class CompanyLadBillListForm : Hepsa.Core.PL.BaseListForm
    {
        public CompanyLadBillListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group CompanyLadBillGroup = new Hepsa.Core.PL.BaseListForm.Group();
                CompanyLadBillGroup.AddButton = this.NewButton;
                CompanyLadBillGroup.DeleteButton = this.DeleteButton;
                CompanyLadBillGroup.EditButton = this.EditButton;
                CompanyLadBillGroup.RefreshButton = this.RefreshButton;
                CompanyLadBillGroup.ExportButton = this.ExportButton;
                CompanyLadBillGroup.set_Grid(true,true,true, this.CompanyLadBillGridView);
                CompanyLadBillGroup.ToolStrip = this.CompanyLadBillToolStrip;
                CompanyLadBillGroup.HasFilterControl = true;

            this.Groups.Add(CompanyLadBillGroup);

        }

         private void CompanyLadBillListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadCompanyLadBill();
            this.CompanyLadBillGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadCompanyLadBill()
        {
            try
            {
               HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
               DataTable CompanyLadBillDataTable= new DataTable();
               CompanyLadBillFactory.GetAll(ref CompanyLadBillDataTable);
               this.CompanyLadBillGridView.DataSource = CompanyLadBillDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          CompanyLadBillEntityForm CompanyLadBill=new CompanyLadBillEntityForm((DataTable)this.CompanyLadBillGridView.DataSource);
          CompanyLadBill.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys CompanyLadBillKey= new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys();
          CompanyLadBillKey.CompanyLadBillID_bint = (Int64)this.CompanyLadBillGridView.CurrentRow.Cells["colCompanyLadBillID_bint"].Value;
          CompanyLadBillEntityForm CompanyLadBill=new CompanyLadBillEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CompanyLadBillGridView.DataSource, CompanyLadBillKey);
          CompanyLadBill.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory=new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBill_TFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
            HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys CompanyLadBillKey= new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys();

            CompanyLadBillKey.CompanyLadBillID_bint = (Int64)CompanyLadBillGridView.CurrentRow.Cells["colCompanyLadBillID_bint"].Value;
            CompanyLadBillFactory.Delete(CompanyLadBillKey);

            DataRow[] dr=((DataTable)this.CompanyLadBillGridView.DataSource).Select(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyLadBillID_bint.ToString() + "='" +CompanyLadBillKey.CompanyLadBillID_bint.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.CompanyLadBillGridView.DataSource).AcceptChanges();
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
                this.LoadCompanyLadBill();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}