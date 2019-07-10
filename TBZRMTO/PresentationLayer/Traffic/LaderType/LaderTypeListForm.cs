using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.LaderType
{
    public partial class LaderTypeListForm : Hepsa.Core.PL.BaseListForm
    {
        public LaderTypeListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
                LaderTypeGroup.AddButton = this.NewButton;
                LaderTypeGroup.DeleteButton = this.DeleteButton;
                LaderTypeGroup.EditButton = this.EditButton;
                LaderTypeGroup.RefreshButton = this.RefreshButton;
                LaderTypeGroup.ExportButton = this.ExportButton;
                LaderTypeGroup.set_Grid(true,true,true, this.LaderTypeGridView);
                LaderTypeGroup.ToolStrip = this.LaderTypeToolStrip;
                LaderTypeGroup.HasFilterControl = true;

            this.Groups.Add(LaderTypeGroup);

        }

         private void LaderTypeListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadLaderType();
            this.LaderTypeGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadLaderType()
        {
            try
            {
               HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
               DataTable LaderTypeDataTable= new DataTable();
               LaderTypeFactory.GetAll(ref LaderTypeDataTable);
               this.LaderTypeGridView.DataSource = LaderTypeDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          LaderTypeEntityForm LaderType=new LaderTypeEntityForm((DataTable)this.LaderTypeGridView.DataSource);
          LaderType.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey= new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
          LaderTypeKey.LaderTypeID_int = (Int32)this.LaderTypeGridView.CurrentRow.Cells["colLaderTypeID_int"].Value;
          LaderTypeEntityForm LaderType=new LaderTypeEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LaderTypeGridView.DataSource, LaderTypeKey);
          LaderType.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory=new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderType_TFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey= new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();

            LaderTypeKey.LaderTypeID_int = (Int32)LaderTypeGridView.CurrentRow.Cells["colLaderTypeID_int"].Value;
            LaderTypeFactory.Delete(LaderTypeKey);

            DataRow[] dr=((DataTable)this.LaderTypeGridView.DataSource).Select(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString() + "='" +LaderTypeKey.LaderTypeID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.LaderTypeGridView.DataSource).AcceptChanges();
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
                this.LoadLaderType();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
         } 
     }
}