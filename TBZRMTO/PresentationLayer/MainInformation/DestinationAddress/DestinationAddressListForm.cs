using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.DestinationAddress
{
    public partial class DestinationAddressListForm : Hepsa.Core.PL.BaseListForm
    {
        public DestinationAddressListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group DestinationAddressGroup = new Hepsa.Core.PL.BaseListForm.Group();
                DestinationAddressGroup.AddButton = this.NewButton;
                DestinationAddressGroup.DeleteButton = this.DeleteButton;
                DestinationAddressGroup.EditButton = this.EditButton;
                DestinationAddressGroup.RefreshButton = this.RefreshButton;
                DestinationAddressGroup.ExportButton = this.ExportButton;
                DestinationAddressGroup.set_Grid(true,true,true, this.DestinationAddressGridView);
                DestinationAddressGroup.ToolStrip = this.DestinationAddressToolStrip;
                DestinationAddressGroup.HasFilterControl = true;

            this.Groups.Add(DestinationAddressGroup);

        }

         private void DestinationAddressListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadDestinationAddress();
            this.DestinationAddressGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadDestinationAddress()
        {
            try
            {
               HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory = new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();
               DataTable DestinationAddressDataTable= new DataTable();
               DestinationAddressFactory.GetAll(ref DestinationAddressDataTable);
               this.DestinationAddressGridView.DataSource = DestinationAddressDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          DestinationAddressEntityForm DestinationAddress=new DestinationAddressEntityForm((DataTable)this.DestinationAddressGridView.DataSource);
          DestinationAddress.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys DestinationAddressKey= new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys();
          DestinationAddressKey.DestinationAddressID_int = (Int32)this.DestinationAddressGridView.CurrentRow.Cells["colDestinationAddressID_int"].Value;
          DestinationAddressEntityForm DestinationAddress=new DestinationAddressEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.DestinationAddressGridView.DataSource, DestinationAddressKey);
          DestinationAddress.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory=new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddress_TFactory = new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();
            HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys DestinationAddressKey= new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys();

            DestinationAddressKey.DestinationAddressID_int = (Int32)DestinationAddressGridView.CurrentRow.Cells["colDestinationAddressID_int"].Value;
            DestinationAddressFactory.Delete(DestinationAddressKey);

            DataRow[] dr=((DataTable)this.DestinationAddressGridView.DataSource).Select(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddressID_int.ToString() + "='" +DestinationAddressKey.DestinationAddressID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.DestinationAddressGridView.DataSource).AcceptChanges();
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
                this.LoadDestinationAddress();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}