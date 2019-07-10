using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.LaderPivotGroup
{
    public partial class LaderPivotGroupListForm : Hepsa.Core.PL.BaseListForm
    {
        public LaderPivotGroupListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group LaderPivotGroupGroup = new Hepsa.Core.PL.BaseListForm.Group();
                LaderPivotGroupGroup.AddButton = this.NewButton;
                LaderPivotGroupGroup.DeleteButton = this.DeleteButton;
                LaderPivotGroupGroup.EditButton = this.EditButton;
                LaderPivotGroupGroup.RefreshButton = this.RefreshButton;
                LaderPivotGroupGroup.ExportButton = this.ExportButton;
                LaderPivotGroupGroup.set_Grid(true,true,true, this.LaderPivotGroupGridView);
                LaderPivotGroupGroup.ToolStrip = this.LaderPivotGroupToolStrip;
                LaderPivotGroupGroup.HasFilterControl = true;

            this.Groups.Add(LaderPivotGroupGroup);

        }

         private void LaderPivotGroupListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadLaderPivotGroup();
            this.LaderPivotGroupGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadLaderPivotGroup()
        {
            try
            {
               HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupFactory = new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
               DataTable LaderPivotGroupDataTable= new DataTable();
               LaderPivotGroupFactory.GetAll(ref LaderPivotGroupDataTable);
               this.LaderPivotGroupGridView.DataSource = LaderPivotGroupDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          LaderPivotGroupEntityForm LaderPivotGroup=new LaderPivotGroupEntityForm((DataTable)this.LaderPivotGroupGridView.DataSource);
          LaderPivotGroup.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys LaderPivotGroupKey= new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys();
          LaderPivotGroupKey.LaderPivotGroupID_int = (Int32?)this.LaderPivotGroupGridView.CurrentRow.Cells["colLaderPivotGroupID_int"].Value;
          LaderPivotGroupEntityForm LaderPivotGroup=new LaderPivotGroupEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LaderPivotGroupGridView.DataSource, LaderPivotGroupKey);
          LaderPivotGroup.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroupFactory=new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory LaderPivotGroup_TFactory = new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TFactory();
            HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys LaderPivotGroupKey= new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys();

            LaderPivotGroupKey.LaderPivotGroupID_int = (Int32?)LaderPivotGroupGridView.CurrentRow.Cells["colLaderPivotGroupID_int"].Value;
            LaderPivotGroupFactory.Delete(LaderPivotGroupKey);

            DataRow[] dr=((DataTable)this.LaderPivotGroupGridView.DataSource).Select(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString() + "='" +LaderPivotGroupKey.LaderPivotGroupID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.LaderPivotGroupGridView.DataSource).AcceptChanges();
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
                this.LoadLaderPivotGroup();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}