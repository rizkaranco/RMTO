using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.MessageRecipient
{
    public partial class MessageRecipientListForm : Hepsa.Core.PL.BaseListForm
    {
        public MessageRecipientListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group MessageRecipientGroup = new Hepsa.Core.PL.BaseListForm.Group();
                MessageRecipientGroup.AddButton = this.NewButton;
                MessageRecipientGroup.DeleteButton = this.DeleteButton;
                MessageRecipientGroup.EditButton = this.EditButton;
                MessageRecipientGroup.RefreshButton = this.RefreshButton;
                MessageRecipientGroup.ExportButton = this.ExportButton;
                MessageRecipientGroup.set_Grid(true,true,true, this.MessageRecipientGridView);
                MessageRecipientGroup.ToolStrip = this.MessageRecipientToolStrip;
                MessageRecipientGroup.HasFilterControl = true;

            this.Groups.Add(MessageRecipientGroup);

        }

         private void MessageRecipientListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadMessageRecipient();
            this.MessageRecipientGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadMessageRecipient()
        {
            try
            {
               HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipientFactory = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();
               DataTable MessageRecipientDataTable= new DataTable();
               MessageRecipientFactory.GetAll(ref MessageRecipientDataTable);
               this.MessageRecipientGridView.DataSource = MessageRecipientDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          MessageRecipientEntityForm MessageRecipient=new MessageRecipientEntityForm((DataTable)this.MessageRecipientGridView.DataSource);
          MessageRecipient.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys MessageRecipientKey= new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys();
          MessageRecipientKey.MessageRecipientID_int = (Int32?)this.MessageRecipientGridView.CurrentRow.Cells["colMessageRecipientID_int"].Value;
          MessageRecipientEntityForm MessageRecipient=new MessageRecipientEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.MessageRecipientGridView.DataSource, MessageRecipientKey);
          MessageRecipient.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipientFactory=new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipient_TFactory = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();
            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys MessageRecipientKey= new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys();

            MessageRecipientKey.MessageRecipientID_int = (Int32?)MessageRecipientGridView.CurrentRow.Cells["colMessageRecipientID_int"].Value;
            MessageRecipientFactory.Delete(MessageRecipientKey);

            DataRow[] dr=((DataTable)this.MessageRecipientGridView.DataSource).Select(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageRecipientID_int.ToString() + "='" +MessageRecipientKey.MessageRecipientID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.MessageRecipientGridView.DataSource).AcceptChanges();
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
                this.LoadMessageRecipient();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}