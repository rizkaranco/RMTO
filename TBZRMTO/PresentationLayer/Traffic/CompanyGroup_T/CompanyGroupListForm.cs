using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;


namespace HPS.Present.CompanyGroup
{
    public partial class CompanyGroupListForm : Hepsa.Core.PL.BaseListForm
    {
        public CompanyGroupListForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group CompanyGroupGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CompanyGroupGroup.AddButton = this.NewCompanyGroupButton;
            CompanyGroupGroup.DeleteButton = this.DeleteCompanyGroupButton;
            CompanyGroupGroup.EditButton = this.EditCompanyGroupButton;
            CompanyGroupGroup.RefreshButton = this.RefreshCompanyGroupButton;
            CompanyGroupGroup.ExportButton = this.ExportCompanyGroupButton;
            CompanyGroupGroup.set_Grid(true, true, true, this.CompanyGroupGridView);
            CompanyGroupGroup.ToolStrip = this.CompanyGroupToolStrip;
            CompanyGroupGroup.HasFilterControl = true;

            this.Groups.Add(CompanyGroupGroup);

        }

        private void CompanyGroupListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadCompanyGroup();
                this.CompanyGroupGridView.Focus();
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        private void LoadCompanyGroup()
        {
            try
            {
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroupFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();
                DataTable CompanyGroupDataTable = new DataTable();
                CompanyGroupFactory.GetAll(ref CompanyGroupDataTable);
                this.CompanyGroupGridView.DataSource = CompanyGroupDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void NewCompanyGroupButton_Click(object sender, EventArgs e)
        {
            HPS.Present.CompanyGroup.CompanyGroupEntityForm CompanyGroup = new HPS.Present.CompanyGroup.CompanyGroupEntityForm((DataTable)this.CompanyGroupGridView.DataSource);
            CompanyGroup.ShowDialog();
        }

        private void EditCompanyGroupButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys CompanyGroupKey = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys();
            CompanyGroupKey.GroupID_int = (Int32)this.CompanyGroupGridView.CurrentRow.Cells["colGroupID_int"].Value;
            HPS.Present.CompanyGroup.CompanyGroupEntityForm CompanyGroup = new HPS.Present.CompanyGroup.CompanyGroupEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CompanyGroupGridView.DataSource, CompanyGroupKey);
            CompanyGroup.ShowDialog();
        }

        private void DeleteCompanyGroupButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroupFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                {
                    return;
                }


                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory CompanyGroup_TFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys CompanyGroupKey = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys();

                CompanyGroupKey.GroupID_int = (Int32)CompanyGroupGridView.CurrentRow.Cells["colGroupID_int"].Value;
                CompanyGroupFactory.Delete(CompanyGroupKey);

                DataRow[] dr = ((DataTable)this.CompanyGroupGridView.DataSource).Select(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupID_int.ToString() + "='" + CompanyGroupKey.GroupID_int.ToString() + "'");
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                }
                ((DataTable)this.CompanyGroupGridView.DataSource).AcceptChanges();
            }

            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshCompanyGroupButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadCompanyGroup();
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
    }
}