using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.ChargePrice
{
    public partial class ChargePriceListForm : Hepsa.Core.PL.BaseListForm
    {
        public ChargePriceListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group ChargePriceGroup = new Hepsa.Core.PL.BaseListForm.Group();
                ChargePriceGroup.AddButton = this.NewButton;
                ChargePriceGroup.DeleteButton = this.DeleteButton;
                ChargePriceGroup.EditButton = this.EditButton;
                ChargePriceGroup.RefreshButton = this.RefreshButton;
                ChargePriceGroup.ExportButton = this.ExportButton;
                ChargePriceGroup.set_Grid(true,true,true, this.ChargePriceGridView);
                ChargePriceGroup.ToolStrip = this.ChargePriceToolStrip;
                ChargePriceGroup.HasFilterControl = true;

            this.Groups.Add(ChargePriceGroup);

        }

         private void ChargePriceListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadChargePrice();
            this.ChargePriceGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadChargePrice()
        {
            try
            {
               HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePriceFactory = new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();
               DataTable ChargePriceDataTable= new DataTable();
               ChargePriceFactory.GetAll(ref ChargePriceDataTable);
               this.ChargePriceGridView.DataSource = ChargePriceDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          ChargePriceEntityForm ChargePrice=new ChargePriceEntityForm((DataTable)this.ChargePriceGridView.DataSource);
          ChargePrice.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys ChargePriceKey= new HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys();
          ChargePriceKey.ChargePriceID_int = (Int32?)this.ChargePriceGridView.CurrentRow.Cells["colChargePriceID_int"].Value;
          ChargePriceEntityForm ChargePrice=new ChargePriceEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.ChargePriceGridView.DataSource, ChargePriceKey);
          ChargePrice.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePriceFactory=new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory ChargePrice_TFactory = new HPS.BLL.ChargePriceBLL.BLLChargePrice_TFactory();
            HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys ChargePriceKey= new HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys();

            ChargePriceKey.ChargePriceID_int = (Int32?)ChargePriceGridView.CurrentRow.Cells["colChargePriceID_int"].Value;
            ChargePriceFactory.Delete(ChargePriceKey);

            DataRow[] dr=((DataTable)this.ChargePriceGridView.DataSource).Select(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.ChargePriceID_int.ToString() + "='" +ChargePriceKey.ChargePriceID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.ChargePriceGridView.DataSource).AcceptChanges();
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.LoadChargePrice();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}