using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.BillMessage
{
    public partial class BillMessageListForm : Hepsa.Core.PL.BaseListForm
    {
        public BillMessageListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group BillMessageGroup = new Hepsa.Core.PL.BaseListForm.Group();
                BillMessageGroup.AddButton = this.NewButton;
                BillMessageGroup.DeleteButton = this.DeleteButton;
                BillMessageGroup.EditButton = this.EditButton;
                BillMessageGroup.RefreshButton = this.RefreshButton;
                BillMessageGroup.ExportButton = this.ExportButton;
                BillMessageGroup.set_Grid(true,true,true, this.BillMessageGridView);
                BillMessageGroup.ToolStrip = this.BillMessageToolStrip;
                BillMessageGroup.HasFilterControl = true;

            this.Groups.Add(BillMessageGroup);

        }

         private void BillMessageListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadBillMessage();
            this.BillMessageGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadBillMessage()
        {
            try
            {
               HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
               DataTable BillMessageDataTable= new DataTable();
               BillMessageFactory.GetAll(ref BillMessageDataTable);
               this.BillMessageGridView.DataSource = BillMessageDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          BillMessageEntityForm BillMessage=new BillMessageEntityForm((DataTable)this.BillMessageGridView.DataSource);
          BillMessage.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys BillMessageKey= new HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys();
          BillMessageKey.BillMessageID_int = (Int32?)this.BillMessageGridView.CurrentRow.Cells["colBillMessageID_int"].Value;
          BillMessageEntityForm BillMessage=new BillMessageEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.BillMessageGridView.DataSource, BillMessageKey);
          BillMessage.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory=new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessage_TFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys BillMessageKey= new HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys();

            BillMessageKey.BillMessageID_int = (Int32?)BillMessageGridView.CurrentRow.Cells["colBillMessageID_int"].Value;
            BillMessageFactory.Delete(BillMessageKey);

            DataRow[] dr=((DataTable)this.BillMessageGridView.DataSource).Select(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillMessageID_int.ToString() + "='" +BillMessageKey.BillMessageID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.BillMessageGridView.DataSource).AcceptChanges();
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
                this.LoadBillMessage();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}