using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Bill
{
    public partial class BillListForm : Hepsa.Core.PL.BaseListForm
    {
        public BillListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group BillGroup = new Hepsa.Core.PL.BaseListForm.Group();
                BillGroup.AddButton = this.NewButton;
                BillGroup.DeleteButton = this.DeleteButton;
                BillGroup.EditButton = this.EditButton;
                BillGroup.RefreshButton = this.RefreshButton;
                BillGroup.ExportButton = this.ExportButton;
                BillGroup.set_Grid(true,true,true, this.BillGridView);
                BillGroup.ToolStrip = this.BillToolStrip;
                BillGroup.HasFilterControl = true;

            this.Groups.Add(BillGroup);

        }

         private void BillListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadBill();
            this.BillGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadBill()
        {
            try
            {
               HPS.BLL.BillBLL.BLLBill_TFactory BillFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();
               DataTable BillDataTable= new DataTable();
               BillFactory.GetAll(ref BillDataTable);
               this.BillGridView.DataSource = BillDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          BillEntityForm Bill=new BillEntityForm((DataTable)this.BillGridView.DataSource);
          Bill.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.BillBLL.BLLBill_TKeys BillKey= new HPS.BLL.BillBLL.BLLBill_TKeys();
          BillKey.BillID_int = (Int32)this.BillGridView.CurrentRow.Cells["colBillID_int"].Value;
          BillEntityForm Bill=new BillEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.BillGridView.DataSource, BillKey);
          Bill.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.BillBLL.BLLBill_TFactory BillFactory=new HPS.BLL.BillBLL.BLLBill_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.BillBLL.BLLBill_TFactory Bill_TFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();
            HPS.BLL.BillBLL.BLLBill_TKeys BillKey= new HPS.BLL.BillBLL.BLLBill_TKeys();

            BillKey.BillID_int = (Int32)BillGridView.CurrentRow.Cells["colBillID_int"].Value;
            BillFactory.Delete(BillKey);

            DataRow[] dr=((DataTable)this.BillGridView.DataSource).Select(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillID_int.ToString() + "='" +BillKey.BillID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.BillGridView.DataSource).AcceptChanges();
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
                this.LoadBill();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}