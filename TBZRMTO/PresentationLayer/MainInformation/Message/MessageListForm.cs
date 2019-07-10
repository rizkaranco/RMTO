using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Message
{
    public partial class MessageListForm : Hepsa.Core.PL.BaseListForm
    {
        public MessageListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group MessageGroup = new Hepsa.Core.PL.BaseListForm.Group();
                MessageGroup.AddButton = this.NewButton;
                MessageGroup.DeleteButton = this.DeleteButton;
                MessageGroup.EditButton = this.EditButton;
                MessageGroup.RefreshButton = this.RefreshButton;
                MessageGroup.ExportButton = this.ExportButton;
                MessageGroup.set_Grid(true,true,true, this.MessageGridView);
                MessageGroup.ToolStrip = this.MessageToolStrip;
                MessageGroup.HasFilterControl = true;

            this.Groups.Add(MessageGroup);

        }

         private void MessageListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadMessage();
            this.MessageGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadMessage()
        {
            try
            {
               HPS.BLL.MessageBLL.BLLMessage_TFactory MessageFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();
               DataTable MessageDataTable= new DataTable();
               MessageFactory.GetAll(ref MessageDataTable);
               this.MessageGridView.DataSource = MessageDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          MessageEntityForm Message=new MessageEntityForm((DataTable)this.MessageGridView.DataSource);
          Message.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.MessageBLL.BLLMessage_TKeys MessageKey= new HPS.BLL.MessageBLL.BLLMessage_TKeys();
          MessageKey.MessageID_bint = (Int64?)this.MessageGridView.CurrentRow.Cells["colMessageID_bint"].Value;
          MessageEntityForm Message=new MessageEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.MessageGridView.DataSource, MessageKey);
          Message.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.MessageBLL.BLLMessage_TFactory MessageFactory=new HPS.BLL.MessageBLL.BLLMessage_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.MessageBLL.BLLMessage_TFactory Message_TFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();
            HPS.BLL.MessageBLL.BLLMessage_TKeys MessageKey= new HPS.BLL.MessageBLL.BLLMessage_TKeys();

            MessageKey.MessageID_bint = (Int64?)MessageGridView.CurrentRow.Cells["colMessageID_bint"].Value;
            MessageFactory.Delete(MessageKey);

            DataRow[] dr=((DataTable)this.MessageGridView.DataSource).Select(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageID_bint.ToString() + "='" +MessageKey.MessageID_bint.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.MessageGridView.DataSource).AcceptChanges();
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
                this.LoadMessage();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}