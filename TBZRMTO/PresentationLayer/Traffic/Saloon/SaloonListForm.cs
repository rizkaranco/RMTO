using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Saloon
{
    public partial class SaloonListForm : Hepsa.Core.PL.BaseListForm
    {
        public SaloonListForm()
        {            
            this.InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group SaloonGroup = new Hepsa.Core.PL.BaseListForm.Group();
            SaloonGroup.AddButton = this.NewButton;
            SaloonGroup.DeleteButton = this.DeleteButton;
            SaloonGroup.EditButton = this.EditButton;
            SaloonGroup.RefreshButton = this.RefreshButton;
            SaloonGroup.ExportButton = this.ExportButton;
            SaloonGroup.set_Grid(true, true, true, this.SaloonGridView);
            SaloonGroup.ToolStrip = this.SaloonToolStrip;
            SaloonGroup.HasFilterControl = true;
            this.Groups.Add(SaloonGroup);
            
            Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LaderTypeGroup.set_Grid(true, true, true, this.LaderTypeGridView);
            LaderTypeGroup.HasFilterControl = false;
            this.Groups.Add(LaderTypeGroup);
            
            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure SaloonRelation = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            SaloonRelation.Group1 = SaloonGroup;
            SaloonRelation.HasGroup1ChangeEvent = true;
            SaloonRelation.Group1FilterColumn = colSaloonID_int.Name;
            SaloonRelation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            SaloonRelation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            SaloonRelation.Group1BusinessFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
                       
            SaloonRelation.Group2 = LaderTypeGroup;
            SaloonRelation.HasGroup2ChangeEvent = false;
            SaloonRelation.Group2FilterColumn = colSaloonID_int.DataPropertyName;
            SaloonRelation.Group2BusinessFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            SaloonRelation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;

            this.Relation.Add(ref SaloonRelation);
        }



        private void SaloonListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadSaloon();
                this.SaloonGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }

        private void LoadSaloon()
        {
            try
            {

                HPS.BLL.SaloonBLL.BLLSaloon_TFactory SaloonFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
                DataTable SaloonDataTable = new DataTable();
                SaloonFactory.GetAll(ref SaloonDataTable);
                this.SaloonGridView.DataSource = SaloonDataTable;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SaloonEntityForm Saloon = new SaloonEntityForm((DataTable)this.SaloonGridView.DataSource);
            Saloon.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {  
            HPS.BLL.SaloonBLL.BLLSaloon_TKeys SaloonKey = new HPS.BLL.SaloonBLL.BLLSaloon_TKeys();
            if(this.SaloonGridView.SelectedRows.Count > 0)
            SaloonKey.SaloonID_int = (Int32)this.SaloonGridView.CurrentRow.Cells["colSaloonID_int"].Value;
            SaloonEntityForm Saloon = new SaloonEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.SaloonGridView.DataSource, SaloonKey);
            Saloon.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.SaloonBLL.BLLSaloon_TFactory SaloonFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
            HPS.BLL.SaloonBLL.BLLSaloon_TKeys SaloonKey = new HPS.BLL.SaloonBLL.BLLSaloon_TKeys();
            try
            {
                if (this.SaloonGridView.SelectedRows.Count > 0) 
                    if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                    {
                        return;
                    }
                             
                SaloonKey.SaloonID_int = (Int32)SaloonGridView.SelectedRows[0].Cells["colSaloonID_int"].Value;
           
                SaloonFactory.Delete(SaloonKey);
                if ((DataTable)this.SaloonGridView.DataSource != null)
                {
                    DataRow[] dr = ((DataTable)this.SaloonGridView.DataSource).Select(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString() + "=" + SaloonKey.SaloonID_int.ToString()+ "");
                    if (dr.Length > 0)
                    {
                        dr[0].Delete();
                    }
                    ((DataTable)this.SaloonGridView.DataSource).AcceptChanges();
                }  

            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadSaloon();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

    }
}