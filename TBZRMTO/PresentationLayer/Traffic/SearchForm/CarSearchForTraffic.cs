using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class CarSearchForTraffic : Hepsa.Core.PL.BaseListForm

    {
        public CarSearchForTraffic()
        {
            InitializeComponent();
            Group cargroup = new Group();
            cargroup.set_Grid(true, true, true, this.CarGridView);
            cargroup.HasFilterControl = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SerarchCar();
            this.DialogResult = DialogResult.OK;
        }

        private void CarGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearhGrid();
            }
        }

        private void CarGridView_DoubleClick(object sender, EventArgs e)
        {
            SearhGrid();
        }

        private void SerarchCar()
        {
            try
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                DataTable CarDataTable = new DataTable();
                string Condition = ""; 
                if(!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    Condition="Car_T.SerialPlate_nvc='" + SerialPlate_nvcTextBox.Text + "'";
                }
                else if (string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    Condition = "Car_T.NumberPlate_nvc='" + NumberPlate_nvcTextBox.Text + "'";
                }
                else if (string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    Condition = "Car_T.CarCardnumber_nvc='" + CarCardNumber_nvcTextBox.Text + "'";
                }
                else if (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    Condition = "Car_T.SerialPlate_nvc='" + SerialPlate_nvcTextBox.Text + "' AND Car_T.NumberPlate_nvc='" + NumberPlate_nvcTextBox.Text + "'";
                }
                else if (string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    Condition = "Car_T.NumberPlate_nvc='" + NumberPlate_nvcTextBox.Text + "' AND Car_T.CarCardnumber_nvc='" + CarCardNumber_nvcTextBox.Text + "'";
                }
                else if (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    Condition = "Car_T.SerialPlate_nvc='" + SerialPlate_nvcTextBox.Text + "' AND Car_T.CarCardnumber_nvc='" + CarCardNumber_nvcTextBox.Text + "'";
                }
                else
                {
                    Condition = "Car_T.SerialPlate_nvc='" + SerialPlate_nvcTextBox.Text + "' AND Car_T.CarCardnumber_nvc='" + CarCardNumber_nvcTextBox.Text + "' AND Car_T.NumberPlate_nvc='" + NumberPlate_nvcTextBox.Text + "'";
                }
                CarFactory.GetAllByConditionWithCardReader(Condition, ref CarDataTable);
                this.CarGridView.DataSource = CarDataTable;

            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        HPS.BLL.CarBLL.BLLCar_T CarEntity = new HPS.BLL.CarBLL.BLLCar_T();
        private void SearhGrid()
        {
            if (CarGridView.CurrentRow != null)
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                HPS.BLL.CarBLL.BLLCar_TKeys CarKey = new HPS.BLL.CarBLL.BLLCar_TKeys();
                CarKey.CarID_int = (Int32)CarGridView.CurrentRow.Cells[colCarID_int.Name].Value;
                CarEntity = CarFactory.GetBy(CarKey);
            }
            this.Close();
        }

        public HPS.BLL.CarBLL.BLLCar_T SelectedCar
        {
            get
            {
                return CarEntity;
            }
        }

        private void CarSearchForTraffic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode==Keys.F3)
            {
                this.SearchButton.PerformClick();
            }
        }
    }
}
