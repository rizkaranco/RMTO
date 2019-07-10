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
    public partial class LaderTypeMultiChoose : Hepsa.Core.PL.BaseListForm
    {
        public LaderTypeMultiChoose()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LaderTypeGroup.AddButton = SearchButton;
            LaderTypeGroup.set_Grid(true, true, true, this.LaderTypeGridView);
            LaderTypeGroup.ToolStrip = this.BoxingToolStrip;
            LaderTypeGroup.HasFilterControl = true;

            this.Groups.Add(LaderTypeGroup);
           
        }

        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();

        private void LaderTypeSearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadLaderType();
                this.LaderTypeGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
        List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeList = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            LaderTypeList.Clear();
            //foreach (Janus.Windows.GridEX.GridEXRow item in LaderTypeGridView.GetCheckedRows())
            //{
            //    HPS.BLL.LaderTypeBLL.BLLLaderType_T LadertypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();

            //    LadertypeEntity.LaderTypeID_int = Convert.ToInt32(item.Cells["LaderTypeID_int"].Value);
            //    LadertypeEntity.LaderType_nvc = Convert.ToString(item.Cells["LaderType_nvc"].Value);
            //    LadertypeEntity.LaderTypeCode_nvc = Convert.ToString(item.Cells["LaderTypeCode_nvc"].Value);

            //    LaderTypeList.Add(LadertypeEntity);

            //}
           
                HPS.BLL.LaderTypeBLL.BLLLaderType_T LadertypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                LadertypeEntity.LaderTypeID_int = Convert.ToInt32(LaderTypeGridView.CurrentRow.Cells["LaderTypeID_int"].Value);
                LadertypeEntity.LaderType_nvc = Convert.ToString(LaderTypeGridView.CurrentRow.Cells["LaderType_nvc"].Value);
                LadertypeEntity.LaderTypeCode_nvc = Convert.ToString(LaderTypeGridView.CurrentRow.Cells["LaderTypeCode_nvc"].Value);
                LaderTypeList.Add(LadertypeEntity);
            this.Close();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LaderTypeGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void LaderTypeGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void LoadLaderType()
        {
            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                string Condition = "[LaderType_T].[Active_bit]='true'";
                DataTable LaderTypeDataTable = new DataTable();
                LaderTypeFactory.GetAllByCondition(Condition, ref LaderTypeDataTable);
                this.LaderTypeGridView.DataSource = LaderTypeDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        public HPS.BLL.LaderTypeBLL.BLLLaderType_T SelectedLaderTypeEntity
        {
            get
            {
                return LaderTypeEntity;
            }
        }
        public List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLists
        {
            get
            {
                return LaderTypeList;
            }
        }

 


    }
}
