using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class PlateCitySearch : Hepsa.Core.PL.BaseListForm
    {
        public PlateCitySearch()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group PlateCityGroup = new Hepsa.Core.PL.BaseListForm.Group();
            PlateCityGroup.AddButton = SearchButton;
            PlateCityGroup.set_Grid(true, true, true, this.PlateCityGridView);
            PlateCityGroup.ToolStrip = this.CityToolStrip;
            PlateCityGroup.HasFilterControl = true;

            this.Groups.Add(PlateCityGroup);
        }
        HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity=new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (PlateCityGridView.CurrentRow != null)
            {
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                PlateCityKey.PlateCityID_int = (Int32)PlateCityGridView.CurrentRow.Cells[colPlateCityID_int.Name].Value;
                PlateCityEntity= PlateCityFactory.GetBy(PlateCityKey);

                if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityGridView.CurrentRow.Cells[colPlateCityID_int.Name].Value, TypeCode.String).ToString()) == false)
                {
                    PlateCityEntity.PlateCity_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityGridView.CurrentRow.Cells[colPlateCity_nvc.Name].Value, TypeCode.String).ToString();
                    PlateCityEntity.PlateCityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityGridView.CurrentRow.Cells[colPlateCityCode_nvc.Name].Value, TypeCode.String).ToString();
                    PlateCityEntity.PlateCityID_int =(Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityGridView.CurrentRow.Cells[colPlateCityID_int.Name].Value, TypeCode.Int32);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlateCityGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void PlateCityGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }
        public HPS.BLL.PlateCityBLL.BLLPlateCity_T SelectedPlateCity
        {
            get
            {
                return PlateCityEntity;
            }
        }
        private void LoadPlateCity()
        {
            try
            {
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();

                string Condition = "[PlateCity_T].[Active_bit]='true'";
                DataTable PlateCityDataTable = new DataTable();
                PlateCityFactory.GetAllByCondition(Condition, ref PlateCityDataTable);
                this.PlateCityGridView.DataSource = PlateCityDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void PlateCitySearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadPlateCity();
                this.PlateCityGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
    }
}
