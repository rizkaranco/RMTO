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
    public partial class CitySearch : Hepsa.Core.PL.BaseListForm
    {
        public CitySearch()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group CityGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CityGroup.AddButton = SearchButton;
            CityGroup.set_Grid(true, true, true, this.CityGridView);
            CityGroup.ToolStrip = this.CityToolStrip;
            CityGroup.HasFilterControl = true;

            this.Groups.Add(CityGroup);
        }
        HPS.BLL.CityBLL.BLLCity_T CityEntity = new HPS.BLL.CityBLL.BLLCity_T();

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CityGridView.CurrentRow != null)
            {
                HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                HPS.BLL.CityBLL.BLLCity_TKeys CityKey = new HPS.BLL.CityBLL.BLLCity_TKeys();
                CityKey.CityID_int = (Int32)CityGridView.CurrentRow.Cells[colCityID_int.Name].Value;
                CityEntity = CityFactory.GetBy(CityKey);

                if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetEntityValue(CityGridView.CurrentRow.Cells[colCityID_int.Name].Value, TypeCode.String).ToString()) == false)
                {
                    CityEntity.City_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityGridView.CurrentRow.Cells[colCity_nvc.Name].Value, TypeCode.String).ToString();
                    CityEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityGridView.CurrentRow.Cells[colCityCode_nvc.Name].Value, TypeCode.String).ToString();
                }
            }
            this.Close();
        }

        private void CitySearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadCity();
                this.CityGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
        private void LoadCity()
        {
            try
            {
                HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                string Condition = "[City_T].[Active_bit]='true'";
                DataTable CityDataTable=new DataTable();
                CityFactory.GetAllByCondition(Condition,ref CityDataTable);
                this.CityGridView.DataSource = CityDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CityGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void CityGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }
  
        public  HPS.BLL.CityBLL.BLLCity_T SelectedCity
        {
            get
            {
                 return CityEntity;
            }
        }
    }
}
