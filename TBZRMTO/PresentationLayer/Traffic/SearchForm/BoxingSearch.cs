using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class BoxingSearch :Hepsa.Core.PL.BaseListForm
    {
        public BoxingSearch()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group BoxingGroup = new Hepsa.Core.PL.BaseListForm.Group();
            BoxingGroup.AddButton = SearchButton;
            BoxingGroup.set_Grid(true, true, true, this.BoxingGridView);
            BoxingGroup.ToolStrip = this.BoxingToolStrip;
            BoxingGroup.HasFilterControl = true;

            this.Groups.Add(BoxingGroup);
        }
      
        HPS.BLL.BoxingBLL.BLLBoxing_T BoxingEntity = new HPS.BLL.BoxingBLL.BLLBoxing_T();

        private void BoxingSearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadBoxing();
                this.BoxingGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (BoxingGridView.CurrentRow != null)
            {
                HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
                HPS.BLL.BoxingBLL.BLLBoxing_TKeys BoxingKey = new HPS.BLL.BoxingBLL.BLLBoxing_TKeys();
                BoxingKey.BoxingID_int = (Int32)BoxingGridView.CurrentRow.Cells[colBoxingID_int.Name].Value;
                BoxingEntity = BoxingFactory.GetBy(BoxingKey);

                if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingGridView.CurrentRow.Cells[colBoxingID_int.Name].Value, TypeCode.String).ToString()) == false)
                {
                    BoxingEntity.BoxingType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingGridView.CurrentRow.Cells[colBoxingType_nvc.Name].Value, TypeCode.String).ToString();
                }
            }
            this.Close();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoxingGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void BoxingGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }
       
        private void LoadBoxing()
        {
            try
            {
                HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
                string Condition = "[Boxing_T].[Active_bit]='true'";
                DataTable BoxingDataTable = new DataTable();
                BoxingFactory.GetAllByCondition(Condition, ref BoxingDataTable);
                this.BoxingGridView.DataSource = BoxingDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
      
        public HPS.BLL.BoxingBLL.BLLBoxing_T SelectedBoxingEntity
        {
            get
            {
                return BoxingEntity;
            }
        }
    }
}
