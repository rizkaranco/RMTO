using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Boundry
{
    public partial class BoundryListForm : Hepsa.Core.PL.BaseListForm
    {
        public BoundryListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group BoundryGroup = new Hepsa.Core.PL.BaseListForm.Group();
                BoundryGroup.AddButton = this.NewButton;
                BoundryGroup.DeleteButton = this.DeleteButton;
                BoundryGroup.EditButton = this.EditButton;
                BoundryGroup.RefreshButton = this.RefreshButton;
                BoundryGroup.ExportButton = this.ExportButton;
                BoundryGroup.set_Grid(true,true,true, this.BoundryGridView);
                BoundryGroup.ToolStrip = this.BoundryToolStrip;
                BoundryGroup.HasFilterControl = true;

            this.Groups.Add(BoundryGroup);

        }

         private void BoundryListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadBoundry();
            this.BoundryGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadBoundry()
        {
            try
            {
               HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory = new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();
               DataTable BoundryDataTable= new DataTable();
               BoundryFactory.GetAll(ref BoundryDataTable);
               this.BoundryGridView.DataSource = BoundryDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          BoundryEntityForm Boundry=new BoundryEntityForm((DataTable)this.BoundryGridView.DataSource);
          Boundry.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.BoundryBLL.BLLBoundry_TKeys BoundryKey= new HPS.BLL.BoundryBLL.BLLBoundry_TKeys();
          BoundryKey.BoundryID_int = (Int32)this.BoundryGridView.CurrentRow.Cells["colBoundryID_int"].Value;
          BoundryEntityForm Boundry=new BoundryEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.BoundryGridView.DataSource, BoundryKey);
          Boundry.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory=new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.BoundryBLL.BLLBoundry_TFactory Boundry_TFactory = new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();
            HPS.BLL.BoundryBLL.BLLBoundry_TKeys BoundryKey= new HPS.BLL.BoundryBLL.BLLBoundry_TKeys();

            BoundryKey.BoundryID_int = (Int32)BoundryGridView.CurrentRow.Cells["colBoundryID_int"].Value;
            BoundryFactory.Delete(BoundryKey);

            DataRow[] dr=((DataTable)this.BoundryGridView.DataSource).Select(HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryID_int.ToString() + "='" +BoundryKey.BoundryID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.BoundryGridView.DataSource).AcceptChanges();
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
                this.LoadBoundry();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}