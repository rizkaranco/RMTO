using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.LadBillCancelComment
{
    public partial class LadBillCancelCommentListForm : Hepsa.Core.PL.BaseListForm
    {
        public LadBillCancelCommentListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group LadBillCancelCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
                LadBillCancelCommentGroup.AddButton = this.NewButton;
                LadBillCancelCommentGroup.DeleteButton = this.DeleteButton;
                LadBillCancelCommentGroup.EditButton = this.EditButton;
                LadBillCancelCommentGroup.RefreshButton = this.RefreshButton;
                LadBillCancelCommentGroup.ExportButton = this.ExportButton;
                LadBillCancelCommentGroup.set_Grid(true,true,true, this.LadBillCancelCommentGridView);
                LadBillCancelCommentGroup.ToolStrip = this.LadBillCancelCommentToolStrip;
                LadBillCancelCommentGroup.HasFilterControl = true;

            this.Groups.Add(LadBillCancelCommentGroup);

        }

         private void LadBillCancelCommentListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadLadBillCancelComment();
            this.LadBillCancelCommentGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadLadBillCancelComment()
        {
            try
            {
               HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();
               DataTable LadBillCancelCommentDataTable= new DataTable();
               LadBillCancelCommentFactory.GetAll(ref LadBillCancelCommentDataTable);
               this.LadBillCancelCommentGridView.DataSource = LadBillCancelCommentDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          LadBillCancelCommentEntityForm LadBillCancelComment=new LadBillCancelCommentEntityForm((DataTable)this.LadBillCancelCommentGridView.DataSource);
          LadBillCancelComment.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys LadBillCancelCommentKey= new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys();
          LadBillCancelCommentKey.LadBillCancelCommentID_int = (Int32)this.LadBillCancelCommentGridView.CurrentRow.Cells["colLadBillCancelCommentID_int"].Value;
          LadBillCancelCommentEntityForm LadBillCancelComment=new LadBillCancelCommentEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LadBillCancelCommentGridView.DataSource, LadBillCancelCommentKey);
          LadBillCancelComment.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory=new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelComment_TFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys LadBillCancelCommentKey= new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys();

            LadBillCancelCommentKey.LadBillCancelCommentID_int = (Int32)LadBillCancelCommentGridView.CurrentRow.Cells["colLadBillCancelCommentID_int"].Value;
            LadBillCancelCommentFactory.Delete(LadBillCancelCommentKey);

            DataRow[] dr=((DataTable)this.LadBillCancelCommentGridView.DataSource).Select(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadBillCancelCommentID_int.ToString() + "='" +LadBillCancelCommentKey.LadBillCancelCommentID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.LadBillCancelCommentGridView.DataSource).AcceptChanges();
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
                this.LoadLadBillCancelComment();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}