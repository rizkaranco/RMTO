using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class DriverSearch : Hepsa.Core.PL.BaseListForm
    {
        public DriverSearch()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group DriverGroup = new Hepsa.Core.PL.BaseListForm.Group();
            DriverGroup.set_Grid(true, false, false, this.DriverGridView);
            DriverGroup.ToolStrip = this.DriverToolStrip;
            DriverGroup.HasFilterControl = true;

            this.Groups.Add(DriverGroup);
            try
            {
                LoadDriver();
                this.DriverGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        string _DriverCardNumber = string.Empty;
        
        public DriverSearch(string DriverCardNumber)
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group DriverGroup = new Hepsa.Core.PL.BaseListForm.Group();
            DriverGroup.set_Grid(true, false, false, this.DriverGridView);
            DriverGroup.ToolStrip = this.DriverToolStrip;
            DriverGroup.HasFilterControl = true;

            this.Groups.Add(DriverGroup);
            this._DriverCardNumber = DriverCardNumber;
            try
            {
                this.DriverGridView.Focus();
                LoadDiverTraffic();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void LoadDiverTraffic()
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory  DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DataTable DriverDataTable = new DataTable();
                DriverFactory.GetByCardNumber(_DriverCardNumber, ref DriverDataTable);
                this.DriverGridView.DataSource = DriverDataTable;

            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = new HPS.BLL.DriverBLL.BLLDriver_T();
      
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DriverGridView.CurrentRow != null)
                {
                    HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                    HPS.BLL.DriverBLL.BLLDriver_TKeys DriverKey = new HPS.BLL.DriverBLL.BLLDriver_TKeys();
                    DriverKey.DriverID_bint = (Int64)DriverGridView.CurrentRow.Cells[colDriverID_bint.Name].Value;
                    DriverEntity = DriverFactory.GetBy(DriverKey);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void DriverSearch_Load(object sender, EventArgs e)
        {
            LoadDriver();
        }

        private void LoadDriver()
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DataTable DriverDataTable = new DataTable();
                DriverFactory.GetAll(ref DriverDataTable);
                this.DriverGridView.DataSource = DriverDataTable;
                //
                //HPS.Common.FrequentlyUsedData.CarDataTable.DefaultView.RowFilter = "";
                //this.DriverGridView.DataSource = HPS.Common.FrequentlyUsedData.DriverDataTable;

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void DriverGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void DriverGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }
     
        public HPS.BLL.DriverBLL.BLLDriver_T SelectedDriver
        {
            get
            {
                return DriverEntity;
            }
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        public HPS.BLL.DriverBLL.BLLDriver_T DriverSelected
        {
            get
            {
                return DriverEntity;
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadDriver();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
    }
}
