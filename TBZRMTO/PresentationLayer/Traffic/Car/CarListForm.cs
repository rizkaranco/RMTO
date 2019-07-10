using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Car
{
    public partial class CarListForm : Hepsa.Core.PL.BaseListForm
    {
        public CarListForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group CarGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CarGroup.AddButton = this.NewButton;
            CarGroup.DeleteButton = this.DeleteButton;
            CarGroup.EditButton = this.EditButton;
            CarGroup.RefreshButton = this.RefreshButton;
            CarGroup.ExportButton = this.ExportButton;
            CarGroup.set_Grid(true, true, true, this.CarGridView);
            CarGroup.ToolStrip = this.CarToolStrip;
            CarGroup.HasFilterControl = true;

            this.Groups.Add(CarGroup);

        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            try
            {
                //  this.LoadCar();
                this.CarGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        private string Filters()
        {

            string TrafficCondition = string.Empty;
            if (!string.IsNullOrEmpty(CarCardNumebrTextBox.Text))
            {
                TrafficCondition = string.Format(" CarCardNumber_nvc='{0}' ", CarCardNumebrTextBox.Text);
            }
            if (!string.IsNullOrEmpty(PlateSerialTextBox.Text) && !string.IsNullOrEmpty(PlateNumberTextBox.Text))
            {
                TrafficCondition = string.Format("{0} and NumberPlate_nvc='{1}' and SerialPlate_nvc='{2}'", TrafficCondition, PlateNumberTextBox.Text, PlateSerialTextBox.Text);
            }
            if (TrafficCondition.Substring(0, 4).ToLower() == " and")
            {
                TrafficCondition = TrafficCondition.Remove(0, 4);
            }
            return TrafficCondition;
        }

        private void LoadAllCars()
        {
            try
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                DataTable CarDataTable = new DataTable();
                CarFactory.GetAll(ref CarDataTable);
                this.CarGridView.DataSource = CarDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        private void LoadCar()
        {
            try
            {
                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                DataTable CarDataTable = new DataTable();
                CarFactory.GetAllByCondition(Filters(), ref CarDataTable);
                this.CarGridView.DataSource = CarDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            CarEntityForm Car = new CarEntityForm((DataTable)this.CarGridView.DataSource);
            Car.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.CarBLL.BLLCar_TKeys CarKey = new HPS.BLL.CarBLL.BLLCar_TKeys();
            CarKey.CarID_int = (Int32)this.CarGridView.CurrentRow.Cells["colCarID_int"].Value;
            CarEntityForm Car = new CarEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CarGridView.DataSource, CarKey);
            Car.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                {
                    return;
                }


                HPS.BLL.CarBLL.BLLCar_TFactory Car_TFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                HPS.BLL.CarBLL.BLLCar_TKeys CarKey = new HPS.BLL.CarBLL.BLLCar_TKeys();

                CarKey.CarID_int = (Int32)CarGridView.CurrentRow.Cells["colCarID_int"].Value;
                CarFactory.Delete(CarKey);

                DataRow[] dr = ((DataTable)this.CarGridView.DataSource).Select(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarID_int.ToString() + "='" + CarKey.CarID_int.ToString() + "'");
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                }
                ((DataTable)this.CarGridView.DataSource).AcceptChanges();
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAllCars();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CarCardNumebrTextBox.Text)|| !(string.IsNullOrEmpty(PlateNumberTextBox.Text) || string.IsNullOrEmpty(PlateSerialTextBox.Text)))
                {
                    LoadCar();
                }
                else
                {
                    MessageBox.Show("لطفااطلاعات را وارد نمایید");
                }
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}