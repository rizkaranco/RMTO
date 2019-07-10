using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Good
{
    public partial class GoodListForm : Hepsa.Core.PL.BaseListForm
    {
        public GoodListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group GoodGroup = new Hepsa.Core.PL.BaseListForm.Group();
                GoodGroup.AddButton = this.NewButton;
                GoodGroup.DeleteButton = this.DeleteButton;
                GoodGroup.EditButton = this.EditButton;
                GoodGroup.RefreshButton = this.RefreshButton;
                GoodGroup.ExportButton = this.ExportButton;
                GoodGroup.set_Grid(true,true,true, this.GoodGridView);
                GoodGroup.ToolStrip = this.GoodToolStrip;
                GoodGroup.HasFilterControl = true;

            this.Groups.Add(GoodGroup);

        }

         private void GoodListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadGood();
            this.GoodGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadGood()
        {
            try
            {
               HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
               DataTable GoodDataTable= new DataTable();
               GoodFactory.GetAll(ref GoodDataTable);
               this.GoodGridView.DataSource = GoodDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          GoodEntityForm Good=new GoodEntityForm((DataTable)this.GoodGridView.DataSource);
          Good.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.GoodBLL.BLLGood_TKeys GoodKey= new HPS.BLL.GoodBLL.BLLGood_TKeys();
          GoodKey.GoodID_int = (Int32?)this.GoodGridView.CurrentRow.Cells["colGoodID_int"].Value;
          GoodEntityForm Good=new GoodEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.GoodGridView.DataSource, GoodKey);
          Good.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory=new HPS.BLL.GoodBLL.BLLGood_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.GoodBLL.BLLGood_TFactory Good_TFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
            HPS.BLL.GoodBLL.BLLGood_TKeys GoodKey= new HPS.BLL.GoodBLL.BLLGood_TKeys();

            GoodKey.GoodID_int = (Int32?)GoodGridView.CurrentRow.Cells["colGoodID_int"].Value;
            GoodFactory.Delete(GoodKey);

            DataRow[] dr=((DataTable)this.GoodGridView.DataSource).Select(HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString() + "='" +GoodKey.GoodID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.GoodGridView.DataSource).AcceptChanges();
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
                this.LoadGood();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}