using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class CarSearch : Hepsa.Core.PL.BaseListForm
    {
        string NumberPlate = string.Empty;
        Int32? PlateCityID = 0;
        string Serialplate = string.Empty;

        public CarSearch()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group CarGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CarGroup.set_Grid(true , false, false, this.CarGridView);
            CarGroup.ToolStrip = this.CarToolStrip;
            CarGroup.HasFilterControl = true;

            this.Groups.Add(CarGroup);
            try
            {
                this.LoadCar();
                this.CarGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        public CarSearch(string NumberPlate_nvc)
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group CarGroupTraffic = new Hepsa.Core.PL.BaseListForm.Group();
            CarGroupTraffic.set_Grid(true, true, true, this.CarGridView);
            CarGroupTraffic.ToolStrip = this.CarToolStrip;
            CarGroupTraffic.HasFilterControl = true;

            this.Groups.Add(CarGroupTraffic);
            this.NumberPlate = NumberPlate_nvc;

            try
            {
                this.LoadCarTraffic();
                this.CarGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        public CarSearch(string NumberPlate_nvc,string SerialPlate_nvc)
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group CarGroupTraffic = new Hepsa.Core.PL.BaseListForm.Group();
            CarGroupTraffic.set_Grid(true, true, true, this.CarGridView);
            CarGroupTraffic.ToolStrip = this.CarToolStrip;
            CarGroupTraffic.HasFilterControl = true;

            this.Groups.Add(CarGroupTraffic);
            this.NumberPlate = NumberPlate_nvc;
            this.Serialplate = SerialPlate_nvc;
            try
            {
                this.LoadCarTrafficWithCard();
                this.CarGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        private void CarSearch_Load(object sender, EventArgs e)
        {
        }
        HPS.BLL.CarBLL.BLLCar_T CarEntity = new HPS.BLL.CarBLL.BLLCar_T();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (CarGridView.CurrentRow != null)
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                HPS.BLL.CarBLL.BLLCar_TKeys CarKey = new HPS.BLL.CarBLL.BLLCar_TKeys();
                CarKey.CarID_int = (Int32)CarGridView.CurrentRow.Cells[colCarID_int.Name].Value;
                CarEntity = CarFactory.GetBy(CarKey);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCar()
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            DataTable CarDataTable = new DataTable();
            CarFactory.GetAll( ref CarDataTable);
            this.CarGridView.DataSource = CarDataTable;
            //HPS.Common.FrequentlyUsedData.CarDataTable.DefaultView.RowFilter = "";
            //this.CarGridView.DataSource = HPS.Common.FrequentlyUsedData.CarDataTable;
        }
        private void LoadCarTraffic()
        {
            try
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                DataTable CarDataTable = new DataTable();
                CarFactory.GetByPlate(NumberPlate, ref CarDataTable);
                this.CarGridView.DataSource = CarDataTable;
                /*if (CarDataTable != null && CarDataTable.Rows.Count > 0)
                    for (int index = 0; index < CarDataTable.Rows.Count; index++)
                    {
                        if ((Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(CarDataTable.Rows[index][this.colSerialPlate_nvc.DataPropertyName], TypeCode.Int32) == 15)
                        {
                            this.CarGridView.Rows[index].Selected = true;
                            break;
                        }
                    }
                this.CarGridView.Update();*/
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        private void LoadCarTrafficWithCard()
        {
            try
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                DataTable CarDataTable = new DataTable();
               // string Condition = "AND Car_T.SerialPlate_nvc='" + Serialplate + "' AND Car_T.NumberPlate_nvc='" + NumberPlate + "' ";
                string Condition = "Car_T.SerialPlate_nvc='" + Serialplate + "' AND Car_T.NumberPlate_nvc='" + NumberPlate + "' ";
                CarFactory.GetAllByConditionWithCardReader(Condition, ref CarDataTable);
                this.CarGridView.DataSource = CarDataTable;

            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        private void CarGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void CarGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        public HPS.BLL.CarBLL.BLLCar_T SelectedCar
        {
            get
            {
                return CarEntity;
            }
        }
    }
}
