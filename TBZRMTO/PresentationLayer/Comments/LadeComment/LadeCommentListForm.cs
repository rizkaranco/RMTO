using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.LadeComment
{
    public partial class LadeCommentListForm : Hepsa.Core.PL.BaseListForm
    {
        public LadeCommentListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group LadeCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
                LadeCommentGroup.AddButton = this.NewButton;
                LadeCommentGroup.DeleteButton = this.DeleteButton;
                LadeCommentGroup.EditButton = this.EditButton;
                LadeCommentGroup.RefreshButton = this.RefreshButton;
                LadeCommentGroup.ExportButton = this.ExportButton;
                LadeCommentGroup.set_Grid(true,true,true, this.LadeCommentGridView);
                LadeCommentGroup.ToolStrip = this.LadeCommentToolStrip;
                LadeCommentGroup.HasFilterControl = true;

            this.Groups.Add(LadeCommentGroup);

        }

         private void LadeCommentListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadLadeComment();
            this.LadeCommentGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadLadeComment()
        {
            try
            {
               HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
               DataTable LadeCommentDataTable= new DataTable();
               LadeCommentFactory.GetAll(ref LadeCommentDataTable);
               this.LadeCommentGridView.DataSource = LadeCommentDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          LadeCommentEntityForm LadeComment=new LadeCommentEntityForm((DataTable)this.LadeCommentGridView.DataSource);
          LadeComment.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys LadeCommentKey= new HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys();
          LadeCommentKey.LadeCommentID_int = (Int32?)this.LadeCommentGridView.CurrentRow.Cells["colLadeCommentID_int"].Value;
          LadeCommentEntityForm LadeComment=new LadeCommentEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LadeCommentGridView.DataSource, LadeCommentKey);
          LadeComment.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory=new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeComment_TFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
            HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys LadeCommentKey= new HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys();

            LadeCommentKey.LadeCommentID_int = (Int32?)LadeCommentGridView.CurrentRow.Cells["colLadeCommentID_int"].Value;
            LadeCommentFactory.Delete(LadeCommentKey);

            DataRow[] dr=((DataTable)this.LadeCommentGridView.DataSource).Select(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString() + "='" +LadeCommentKey.LadeCommentID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.LadeCommentGridView.DataSource).AcceptChanges();
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
                this.LoadLadeComment();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}