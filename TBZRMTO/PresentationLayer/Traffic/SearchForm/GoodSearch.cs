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
    public partial class GoodSearch : Hepsa.Core.PL.BaseListForm
    {
        public GoodSearch()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group GoodGroup = new Hepsa.Core.PL.BaseListForm.Group();
            GoodGroup.AddButton = SearchButton;
            GoodGroup.set_Grid(true, true, true, this.GoodGridView);
            GoodGroup.ToolStrip = this.GoodToolStrip;
            GoodGroup.HasFilterControl = true;

            this.Groups.Add(GoodGroup);
        }
        HPS.BLL.GoodBLL.BLLGood_T GoodEntity = new HPS.BLL.GoodBLL.BLLGood_T();
        private void GoodSearch_Load(object sender, EventArgs e)
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (GoodGridView.CurrentRow != null)
            {
                HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
                HPS.BLL.GoodBLL.BLLGood_TKeys GoodKey = new HPS.BLL.GoodBLL.BLLGood_TKeys();
                GoodKey.GoodID_int = (Int32)GoodGridView.CurrentRow.Cells[colGoodID_int.Name].Value;
                GoodEntity = GoodFactory.GetBy(GoodKey);

                if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetEntityValue(GoodGridView.CurrentRow.Cells[colGoodID_int.Name].Value, TypeCode.String).ToString()) == false)
                {
                    GoodEntity.Good_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(GoodGridView.CurrentRow.Cells[colGood_nvc.Name].Value, TypeCode.String).ToString();
                    GoodEntity.GoodCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(GoodGridView.CurrentRow.Cells[colGoodCode_nvc.Name].Value, TypeCode.String).ToString();
                }
            }
            this.Close();

        }
        private void LoadGood()
        {
            try
            {
                HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
                string Condition = "[Good_T].[Avtive_bit]='true'";
                DataTable GoodDataTabale = new DataTable();
                 GoodFactory.GetAllByCondition(Condition,ref GoodDataTabale);
                 this.GoodGridView.DataSource = GoodDataTabale;
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

        private void GoodGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void GoodGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }


        }
        public HPS.BLL.GoodBLL.BLLGood_T SelectedGoodEntity
        {
            get
            {
                return GoodEntity;
            }
        }
    }
}
