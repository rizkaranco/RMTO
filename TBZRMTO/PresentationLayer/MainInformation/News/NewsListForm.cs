using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.News
{
    public partial class NewsListForm : Hepsa.Core.PL.BaseListForm
    {
        public NewsListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group NewsGroup = new Hepsa.Core.PL.BaseListForm.Group();
                NewsGroup.AddButton = this.NewButton;
                NewsGroup.DeleteButton = this.DeleteButton;
                NewsGroup.EditButton = this.EditButton;
                NewsGroup.RefreshButton = this.RefreshButton;
                NewsGroup.ExportButton = this.ExportButton;
                NewsGroup.set_Grid(true,true,true, this.NewsGridView);
                NewsGroup.ToolStrip = this.NewsToolStrip;
                NewsGroup.HasFilterControl = true;

            this.Groups.Add(NewsGroup);

        }

         private void NewsListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadNews();
            this.NewsGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadNews()
        {
            try
            {
               HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
               DataTable NewsDataTable= new DataTable();
               NewsFactory.GetAll(ref NewsDataTable);
               this.NewsGridView.DataSource = NewsDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          NewsEntityForm News=new NewsEntityForm((DataTable)this.NewsGridView.DataSource);
          News.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.NewsBLL.BLLNews_TKeys NewsKey= new HPS.BLL.NewsBLL.BLLNews_TKeys();
          NewsKey.NewsID_bint = (Int64?)this.NewsGridView.CurrentRow.Cells["colNewsID_bint"].Value;
          NewsEntityForm News=new NewsEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.NewsGridView.DataSource, NewsKey);
          News.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory=new HPS.BLL.NewsBLL.BLLNews_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.NewsBLL.BLLNews_TFactory News_TFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
            HPS.BLL.NewsBLL.BLLNews_TKeys NewsKey= new HPS.BLL.NewsBLL.BLLNews_TKeys();

            NewsKey.NewsID_bint = (Int64?)NewsGridView.CurrentRow.Cells["colNewsID_bint"].Value;
            NewsFactory.Delete(NewsKey);

            DataRow[] dr=((DataTable)this.NewsGridView.DataSource).Select(HPS.BLL.NewsBLL.BLLNews_T.News_TField.NewsID_bint.ToString() + "='" +NewsKey.NewsID_bint.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.NewsGridView.DataSource).AcceptChanges();
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
                this.LoadNews();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}