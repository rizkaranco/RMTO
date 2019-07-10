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
    public partial class DriverSearchForTraffic : Hepsa.Core.PL.BaseListForm
    {
        public DriverSearchForTraffic()
        {
            InitializeComponent();


            Hepsa.Core.PL.BaseListForm.Group DriverGroup = new Hepsa.Core.PL.BaseListForm.Group();
            DriverGroup.set_Grid(true, true, true, this.DriverGridView);
            DriverGroup.HasFilterControl = true;

            this.Groups.Add(DriverGroup);
        }

        private void DriverCardNumber_bintNumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Enter && !string.IsNullOrEmpty(DriverCardNumber_bintNumericTextBox.Text))
            //{
            //    Search();
            //}

        }

        private void NationalCode_intNumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text))
            //{
            //    Search();
            //}
        }

        private void DocNumber_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(DocNumber_nvcTextBox.Text))
            //{
            //    Search();
            //}
        }

        private void LastName_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(LastName_nvcTextBox.Text))
            //{
            //    Search();
            //}
        }

        private void Search()
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DataTable DriverDataTable = new DataTable();
                DriverFactory.GetAllByConditionSearch(DriverCardNumber_bintNumericTextBox.NumericText,DocNumber_nvcTextBox.Text,Convert.ToInt64(NationalCode_intNumericTextBox.NumericText),LastName_nvcTextBox.Text, ref DriverDataTable);
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
            Search();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Searchgrid()
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
    
        public HPS.BLL.DriverBLL.BLLDriver_T SelectedDriver
        {
            get
            {
                return DriverEntity;
            }
        }

        private void DriverGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searchgrid();
            }
        }

        private void DriverGridView_DoubleClick(object sender, EventArgs e)
        {
            Searchgrid();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverSearchForTraffic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode==Keys.F3)
            {
                this.SearchButton.PerformClick();
            }
        }
      
    }
}
