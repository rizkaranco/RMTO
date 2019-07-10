using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.LadeCancelComment
{
    public partial class LadeCancelCommentListForm : Hepsa.Core.PL.BaseListForm
    {
        public LadeCancelCommentListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group LadeCancelCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
                LadeCancelCommentGroup.AddButton = this.NewButton;
                LadeCancelCommentGroup.DeleteButton = this.DeleteButton;
                LadeCancelCommentGroup.EditButton = this.EditButton;
                LadeCancelCommentGroup.RefreshButton = this.RefreshButton;
                LadeCancelCommentGroup.ExportButton = this.ExportButton;
                LadeCancelCommentGroup.set_Grid(true,true,true, this.LadeCancelCommentGridView);
                LadeCancelCommentGroup.ToolStrip = this.LadeCancelCommentToolStrip;
                LadeCancelCommentGroup.HasFilterControl = true;

            this.Groups.Add(LadeCancelCommentGroup);

        }

         private void LadeCancelCommentListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadLadeCancelComment();
            this.LadeCancelCommentGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadLadeCancelComment()
        {
            try
            {
               HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
               DataTable LadeCancelCommentDataTable= new DataTable();
               LadeCancelCommentFactory.GetAll(ref LadeCancelCommentDataTable);
               this.LadeCancelCommentGridView.DataSource = LadeCancelCommentDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          LadeCancelCommentEntityForm LadeCancelComment=new LadeCancelCommentEntityForm((DataTable)this.LadeCancelCommentGridView.DataSource);
          LadeCancelComment.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys LadeCancelCommentKey= new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys();
          LadeCancelCommentKey.LadeCanceltCommentID_int = (Int32?)this.LadeCancelCommentGridView.CurrentRow.Cells["colLadeCanceltCommentID_int"].Value;
          LadeCancelCommentEntityForm LadeCancelComment=new LadeCancelCommentEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LadeCancelCommentGridView.DataSource, LadeCancelCommentKey);
          LadeCancelComment.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory=new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelComment_TFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys LadeCancelCommentKey= new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys();

            LadeCancelCommentKey.LadeCanceltCommentID_int = (Int32?)LadeCancelCommentGridView.CurrentRow.Cells["colLadeCanceltCommentID_int"].Value;
            LadeCancelCommentFactory.Delete(LadeCancelCommentKey);

            DataRow[] dr=((DataTable)this.LadeCancelCommentGridView.DataSource).Select(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString() + "='" +LadeCancelCommentKey.LadeCanceltCommentID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.LadeCancelCommentGridView.DataSource).AcceptChanges();
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
                this.LoadLadeCancelComment();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}