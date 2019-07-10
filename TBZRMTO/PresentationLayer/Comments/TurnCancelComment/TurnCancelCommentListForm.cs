using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.TurnCancelComment
{
    public partial class TurnCancelCommentListForm : Hepsa.Core.PL.BaseListForm
    {
        public TurnCancelCommentListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group TurnCancelCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
                TurnCancelCommentGroup.AddButton = this.NewButton;
                TurnCancelCommentGroup.DeleteButton = this.DeleteButton;
                TurnCancelCommentGroup.EditButton = this.EditButton;
                TurnCancelCommentGroup.RefreshButton = this.RefreshButton;
                TurnCancelCommentGroup.ExportButton = this.ExportButton;
                TurnCancelCommentGroup.set_Grid(true,true,true, this.TurnCancelCommentGridView);
                TurnCancelCommentGroup.ToolStrip = this.TurnCancelCommentToolStrip;
                TurnCancelCommentGroup.HasFilterControl = true;

            this.Groups.Add(TurnCancelCommentGroup);

        }

         private void TurnCancelCommentListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadTurnCancelComment();
            this.TurnCancelCommentGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadTurnCancelComment()
        {
            try
            {
               HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
               DataTable TurnCancelCommentDataTable= new DataTable();
               TurnCancelCommentFactory.GetAll(ref TurnCancelCommentDataTable);
               this.TurnCancelCommentGridView.DataSource = TurnCancelCommentDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          TurnCancelCommentEntityForm TurnCancelComment=new TurnCancelCommentEntityForm((DataTable)this.TurnCancelCommentGridView.DataSource);
          TurnCancelComment.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys TurnCancelCommentKey= new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys();
          TurnCancelCommentKey.TurnCancelCommentID_int = (Int32?)this.TurnCancelCommentGridView.CurrentRow.Cells["colTurnCancelCommentID_int"].Value;
          TurnCancelCommentEntityForm TurnCancelComment=new TurnCancelCommentEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.TurnCancelCommentGridView.DataSource, TurnCancelCommentKey);
          TurnCancelComment.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory=new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelComment_TFactory = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys TurnCancelCommentKey= new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys();

            TurnCancelCommentKey.TurnCancelCommentID_int = (Int32?)TurnCancelCommentGridView.CurrentRow.Cells["colTurnCancelCommentID_int"].Value;
            TurnCancelCommentFactory.Delete(TurnCancelCommentKey);

            DataRow[] dr=((DataTable)this.TurnCancelCommentGridView.DataSource).Select(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelCommentID_int.ToString() + "='" +TurnCancelCommentKey.TurnCancelCommentID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.TurnCancelCommentGridView.DataSource).AcceptChanges();
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
                this.LoadTurnCancelComment();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}