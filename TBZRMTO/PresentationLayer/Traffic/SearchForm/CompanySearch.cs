using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class CompanySearch :Hepsa.Core.PL.BaseListForm
    {
        public CompanySearch()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group CompanyGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CompanyGroup.AddButton = SearchButton;
            CompanyGroup.set_Grid(true, true, true, this.CompanyGridView);
            CompanyGroup.ToolStrip = this.BoxingToolStrip;
            CompanyGroup.HasFilterControl = true;

            this.Groups.Add(CompanyGroup);
        }

        HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();
       
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CompanyGridView.CurrentRow != null)
            {
                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
                HPS.BLL.CompanyBLL.BLLCompany_TKeys CompanyKey = new HPS.BLL.CompanyBLL.BLLCompany_TKeys();
                CompanyKey.CompanyID_int = (Int32)CompanyGridView.CurrentRow.Cells[colCompanyID_int.Name].Value;
                CompanyEntity = CompanyFactory.GetBy(CompanyKey);

                if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyGridView.CurrentRow.Cells[colCompanyID_int.Name].Value, TypeCode.String).ToString()) == false)
                {
                    CompanyEntity.Company_nvc =Convert.ToString( Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyGridView.CurrentRow.Cells[colCompany_nvc.Name].Value, TypeCode.String));
                }
            }
            this.Close();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanySearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadCompany();
                this.CompanyGridView.Focus();
                this.CompanyEntity = null;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
       
        private void LoadCompany()
        {
            try
            {
                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
                string Condition = "[Company_T].[Active_bit]='true'";
                DataTable CompanyDataTable = new DataTable();
                CompanyFactory.GetAllByCondition(Condition, ref CompanyDataTable);
                this.CompanyGridView.DataSource = CompanyDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        public HPS.BLL.CompanyBLL.BLLCompany_T SelectedCompanyEntity
        {
            get
            {
                return CompanyEntity;
            }
        }

        private void CompanyGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void CompanyGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }
    }
}
