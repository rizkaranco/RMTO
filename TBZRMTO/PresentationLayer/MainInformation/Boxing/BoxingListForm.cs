using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Boxing
{
    public partial class BoxingListForm : Hepsa.Core.PL.BaseListForm
    {
        public BoxingListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group BoxingGroup = new Hepsa.Core.PL.BaseListForm.Group();
                BoxingGroup.AddButton = this.NewButton;
                BoxingGroup.DeleteButton = this.DeleteButton;
                BoxingGroup.EditButton = this.EditButton;
                BoxingGroup.RefreshButton = this.RefreshButton;
                BoxingGroup.ExportButton = this.ExportButton;
                BoxingGroup.set_Grid(true,true,true, this.BoxingGridView);
                BoxingGroup.ToolStrip = this.BoxingToolStrip;
                BoxingGroup.HasFilterControl = true;

            this.Groups.Add(BoxingGroup);

        }

         private void BoxingListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadBoxing();
            this.BoxingGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadBoxing()
        {
            try
            {
               HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
               DataTable BoxingDataTable= new DataTable();
               BoxingFactory.GetAll(ref BoxingDataTable);
               this.BoxingGridView.DataSource = BoxingDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          BoxingEntityForm Boxing=new BoxingEntityForm((DataTable)this.BoxingGridView.DataSource);
          Boxing.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.BoxingBLL.BLLBoxing_TKeys BoxingKey= new HPS.BLL.BoxingBLL.BLLBoxing_TKeys();
          BoxingKey.BoxingID_int = (Int32?)this.BoxingGridView.CurrentRow.Cells["colBoxingID_int"].Value;
          BoxingEntityForm Boxing=new BoxingEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.BoxingGridView.DataSource, BoxingKey);
          Boxing.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory=new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.BoxingBLL.BLLBoxing_TFactory Boxing_TFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
            HPS.BLL.BoxingBLL.BLLBoxing_TKeys BoxingKey= new HPS.BLL.BoxingBLL.BLLBoxing_TKeys();

            BoxingKey.BoxingID_int = (Int32?)BoxingGridView.CurrentRow.Cells["colBoxingID_int"].Value;
            BoxingFactory.Delete(BoxingKey);

            DataRow[] dr=((DataTable)this.BoxingGridView.DataSource).Select(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString() + "='" +BoxingKey.BoxingID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.BoxingGridView.DataSource).AcceptChanges();
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
                this.LoadBoxing();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}