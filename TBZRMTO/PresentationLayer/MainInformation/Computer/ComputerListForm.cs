using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Computer
{
    public partial class ComputerListForm : Hepsa.Core.PL.BaseListForm
    {
        public ComputerListForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group ComputerGroup = new Hepsa.Core.PL.BaseListForm.Group();
            ComputerGroup.AddButton = this.NewButton;
            ComputerGroup.DeleteButton = this.DeleteButton;
            ComputerGroup.EditButton = this.EditButton;
            ComputerGroup.RefreshButton = this.RefreshButton;
            ComputerGroup.ExportButton = this.ExportButton;
            ComputerGroup.set_Grid(true, true, true, this.ComputerGridView);
            ComputerGroup.ToolStrip = this.ComputerToolStrip;
            ComputerGroup.HasFilterControl = true;

            this.Groups.Add(ComputerGroup);

        }

        private void ComputerListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadComputer();
                DeleteButton.Visible = true;
                this.ComputerGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        private void LoadComputer()
        {
            try
            {
                HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
                DataTable ComputerDataTable = new DataTable();
                ComputerFactory.GetAll(ref ComputerDataTable);
                ComputerDataTable = ComputerDataTable.Select("deleted_bit=false").CopyToDataTable();
                this.ComputerGridView.DataSource = ComputerDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ComputerEntityForm Computer = new ComputerEntityForm((DataTable)this.ComputerGridView.DataSource);
            Computer.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.ComputerBLL.BLLComputer_TKeys ComputerKey = new HPS.BLL.ComputerBLL.BLLComputer_TKeys();
            ComputerKey.ComputerID_int = (Int32?)this.ComputerGridView.CurrentRow.Cells["colComputerID_int"].Value;
            ComputerEntityForm Computer = new ComputerEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.ComputerGridView.DataSource, ComputerKey);
            Computer.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                {
                    return;
                }


                HPS.BLL.ComputerBLL.BLLComputer_TFactory Computer_TFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
                HPS.BLL.ComputerBLL.BLLComputer_TKeys ComputerKey = new HPS.BLL.ComputerBLL.BLLComputer_TKeys();

                ComputerKey.ComputerID_int = (Int32?)ComputerGridView.CurrentRow.Cells["colComputerID_int"].Value;
                ComputerFactory.Delete(ComputerKey);

                DataRow[] dr = ((DataTable)this.ComputerGridView.DataSource).Select(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.ComputerID_int.ToString() + "='" + ComputerKey.ComputerID_int.ToString() + "'");
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                }
            ((DataTable)this.ComputerGridView.DataSource).AcceptChanges();
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
                this.LoadComputer();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ComputerManyEntityForm Computer = new ComputerManyEntityForm((DataTable)this.ComputerGridView.DataSource);
            if (Computer.ShowDialog() == DialogResult.OK)
            {
                this.RefreshButton.PerformClick();
            }
        }

        private void EditAllButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.ComputerBLL.BLLComputer_TKeys ComputerKey = new HPS.BLL.ComputerBLL.BLLComputer_TKeys();
            ComputerKey.ComputerID_int = (int?)this.ComputerGridView.CurrentRow.Cells[colComputerID_int.Name].Value;
            ComputerManyEntityForm computer = new ComputerManyEntityForm(BaseEntityParentForm.enmState.Edit, (DataTable)this.ComputerGridView.DataSource, ComputerKey);
            computer._MacAddress_nvc = ComputerGridView.CurrentRow.Cells[colMacAddress_nvc.Name].Value.ToString();
            if (computer.ShowDialog() == DialogResult.OK)
            {
                this.RefreshButton.PerformClick();
            }
        }
    }
}