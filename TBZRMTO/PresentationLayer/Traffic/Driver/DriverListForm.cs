using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Driver
{
    public partial class DriverListForm : Hepsa.Core.PL.BaseListForm
    {
        public DriverListForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group DriverGroup = new Hepsa.Core.PL.BaseListForm.Group();
            DriverGroup.AddButton = this.NewButton;
            DriverGroup.DeleteButton = this.DeleteButton;
            DriverGroup.EditButton = this.EditButton;
            DriverGroup.RefreshButton = this.RefreshButton;
            DriverGroup.ExportButton = this.ExportButton;
            DriverGroup.set_Grid(true, true, true, this.DriverGridView);
            DriverGroup.ToolStrip = this.DriverToolStrip;
            DriverGroup.HasFilterControl = true;

            this.Groups.Add(DriverGroup);

        }

        private void DriverListForm_Load(object sender, EventArgs e)
        {
            try
            {
                //this.LoadDriver();
                this.DriverGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        private void LoadDriver()
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DataTable DriverDataTable = new DataTable();
                DriverFactory.GetAllByCondition(Filters(), ref DriverDataTable);
                this.DriverGridView.DataSource = DriverDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        private void LoadAllDrivers()
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DataTable DriverDataTable = new DataTable();
                DriverFactory.GetAll( ref DriverDataTable);
                this.DriverGridView.DataSource = DriverDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            DriverEntityForm Driver = new DriverEntityForm((DataTable)this.DriverGridView.DataSource);
            Driver.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.DriverBLL.BLLDriver_TKeys DriverKey = new HPS.BLL.DriverBLL.BLLDriver_TKeys();
            DriverKey.DriverID_bint = (Int64)this.DriverGridView.CurrentRow.Cells["colDriverID_bint"].Value;
            DriverEntityForm Driver = new DriverEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.DriverGridView.DataSource, DriverKey);
            Driver.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                {
                    return;
                }


                HPS.BLL.DriverBLL.BLLDriver_TFactory Driver_TFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                HPS.BLL.DriverBLL.BLLDriver_TKeys DriverKey = new HPS.BLL.DriverBLL.BLLDriver_TKeys();

                DriverKey.DriverID_bint = (Int64)DriverGridView.CurrentRow.Cells["colDriverID_bint"].Value;
                DriverFactory.Delete(DriverKey);

                DataRow[] dr = ((DataTable)this.DriverGridView.DataSource).Select(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverID_bint.ToString() + "='" + DriverKey.DriverID_bint.ToString() + "'");
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                }
            ((DataTable)this.DriverGridView.DataSource).AcceptChanges();
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        private string Filters()
        {

            string TrafficCondition = string.Empty;
            if (!string.IsNullOrEmpty(DriverCardNumebrTextBox.Text))
            {
                TrafficCondition = string.Format(" DriverCardNumber_nvc='{1}' ", TrafficCondition, DriverCardNumebrTextBox.Text);
            }
            if (!string.IsNullOrEmpty(NationalCodeTextBox.Text))
            {
                TrafficCondition = string.Format("{0} and NationalCode_int={1} ", TrafficCondition, NationalCodeTextBox.Text);
            }
            if (!string.IsNullOrEmpty(MobileTextBox.Text))
            {
                TrafficCondition = string.Format("{0} and Mobile_nvc='{1}' ", TrafficCondition, MobileTextBox.Text);
            }
            if (!string.IsNullOrEmpty(FamilyTextBox.Text))
            {
                TrafficCondition = string.Format("{0} and LastName_nvc='{1}' ", TrafficCondition, FamilyTextBox.Text);
            }
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                TrafficCondition = string.Format("{0} and FirstName_nvc='{1}' ", TrafficCondition, NameTextBox.Text);
            }
            if (TrafficCondition.Substring(0, 4).ToLower() == " and")
            {
                TrafficCondition = TrafficCondition.Remove(0, 4);
            }
            return TrafficCondition;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAllDrivers();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DriverCardNumebrTextBox.Text) || !string.IsNullOrEmpty(NationalCodeTextBox.Text) || !string.IsNullOrEmpty(MobileTextBox.Text) || !string.IsNullOrEmpty(NameTextBox.Text) || !string.IsNullOrEmpty(FamilyTextBox.Text))
            {
                try
                {
                    LoadDriver();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("لطفا اطلاعات جستجو را وارد نمایید");
            }




        }
    }
}