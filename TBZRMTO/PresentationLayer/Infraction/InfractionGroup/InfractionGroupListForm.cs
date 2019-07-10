using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.InfractionGroup
{
    public partial class InfractionGroupListForm : Hepsa.Core.PL.BaseListForm
    {
        public InfractionGroupListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group InfractionGroupGroup = new Hepsa.Core.PL.BaseListForm.Group();
                InfractionGroupGroup.AddButton = this.NewButton;
                InfractionGroupGroup.DeleteButton = this.DeleteButton;
                InfractionGroupGroup.EditButton = this.EditButton;
                InfractionGroupGroup.RefreshButton = this.RefreshButton;
                InfractionGroupGroup.ExportButton = this.ExportButton;
                InfractionGroupGroup.set_Grid(true,true,true, this.InfractionGroupGridView);
                InfractionGroupGroup.ToolStrip = this.InfractionGroupToolStrip;
                InfractionGroupGroup.HasFilterControl = true;

            this.Groups.Add(InfractionGroupGroup);

        }

         private void InfractionGroupListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadInfractionGroup();
            this.InfractionGroupGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadInfractionGroup()
        {
            try
            {
               HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
               DataTable InfractionGroupDataTable= new DataTable();
               InfractionGroupFactory.GetAll(ref InfractionGroupDataTable);
               this.InfractionGroupGridView.DataSource = InfractionGroupDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          InfractionGroupEntityForm InfractionGroup=new InfractionGroupEntityForm((DataTable)this.InfractionGroupGridView.DataSource);
          InfractionGroup.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys InfractionGroupKey= new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys();
          InfractionGroupKey.InfractionGroupID_int = (Int32?)this.InfractionGroupGridView.CurrentRow.Cells["colInfractionGroupID_int"].Value;
          InfractionGroupEntityForm InfractionGroup=new InfractionGroupEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.InfractionGroupGridView.DataSource, InfractionGroupKey);
          InfractionGroup.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupFactory=new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroup_TFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
            HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys InfractionGroupKey= new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TKeys();

            InfractionGroupKey.InfractionGroupID_int = (Int32?)InfractionGroupGridView.CurrentRow.Cells["colInfractionGroupID_int"].Value;
            InfractionGroupFactory.Delete(InfractionGroupKey);

            DataRow[] dr=((DataTable)this.InfractionGroupGridView.DataSource).Select(HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString() + "='" +InfractionGroupKey.InfractionGroupID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.InfractionGroupGridView.DataSource).AcceptChanges();
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
                this.LoadInfractionGroup();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}