using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.StopFee
{
    public partial class StopFeeListForm : Hepsa.Core.PL.BaseListForm
    {
        public StopFeeListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group StopFeeGroup = new Hepsa.Core.PL.BaseListForm.Group();
                StopFeeGroup.AddButton = this.NewButton;
                StopFeeGroup.DeleteButton = this.DeleteButton;
                StopFeeGroup.EditButton = this.EditButton;
                StopFeeGroup.RefreshButton = this.RefreshButton;
                StopFeeGroup.ExportButton = this.ExportButton;
                StopFeeGroup.set_Grid(true,true,true, this.StopFeeGridView);
                StopFeeGroup.ToolStrip = this.StopFeeToolStrip;
                StopFeeGroup.HasFilterControl = true;

            this.Groups.Add(StopFeeGroup);

        }

         private void StopFeeListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadStopFee();
            this.StopFeeGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadStopFee()
        {
            try
            {
               HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
               DataTable StopFeeDataTable= new DataTable();
               StopFeeFactory.GetAll(ref StopFeeDataTable);
               this.StopFeeGridView.DataSource = StopFeeDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          StopFeeEntityForm StopFee=new StopFeeEntityForm((DataTable)this.StopFeeGridView.DataSource);
          StopFee.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.StopFeeBLL.BLLStopFee_TKeys StopFeeKey= new HPS.BLL.StopFeeBLL.BLLStopFee_TKeys();
          StopFeeKey.StopFeeID_int = (Int32)this.StopFeeGridView.CurrentRow.Cells["colStopFeeID_int"].Value;
          StopFeeEntityForm StopFee=new StopFeeEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.StopFeeGridView.DataSource, StopFeeKey);
          StopFee.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory=new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFee_TFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            HPS.BLL.StopFeeBLL.BLLStopFee_TKeys StopFeeKey= new HPS.BLL.StopFeeBLL.BLLStopFee_TKeys();

            StopFeeKey.StopFeeID_int = (Int32)StopFeeGridView.CurrentRow.Cells["colStopFeeID_int"].Value;
            StopFeeFactory.Delete(StopFeeKey);

            DataRow[] dr=((DataTable)this.StopFeeGridView.DataSource).Select(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StopFeeID_int.ToString() + "='" +StopFeeKey.StopFeeID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.StopFeeGridView.DataSource).AcceptChanges();
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
                this.LoadStopFee();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}