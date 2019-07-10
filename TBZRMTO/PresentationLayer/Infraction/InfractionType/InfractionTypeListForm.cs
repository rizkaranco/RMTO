using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.InfractionType
{
    public partial class InfractionTypeListForm : Hepsa.Core.PL.BaseListForm
    {
        public InfractionTypeListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group InfractionTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
                InfractionTypeGroup.AddButton = this.NewButton;
                InfractionTypeGroup.DeleteButton = this.DeleteButton;
                InfractionTypeGroup.EditButton = this.EditButton;
                InfractionTypeGroup.RefreshButton = this.RefreshButton;
                InfractionTypeGroup.ExportButton = this.ExportButton;
                InfractionTypeGroup.set_Grid(true,true,true, this.InfractionTypeGridView);
                InfractionTypeGroup.ToolStrip = this.InfractionTypeToolStrip;
                InfractionTypeGroup.HasFilterControl = true;

            this.Groups.Add(InfractionTypeGroup);

        }

         private void InfractionTypeListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadInfractionType();
            this.InfractionTypeGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadInfractionType()
        {
            try
            {
               HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
               DataTable InfractionTypeDataTable= new DataTable();
               InfractionTypeFactory.GetAll(ref InfractionTypeDataTable);
               this.InfractionTypeGridView.DataSource = InfractionTypeDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          InfractionTypeEntityForm InfractionType=new InfractionTypeEntityForm((DataTable)this.InfractionTypeGridView.DataSource);
          InfractionType.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys InfractionTypeKey= new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys();
          InfractionTypeKey.InfractionTypeID_int = (Int32?)this.InfractionTypeGridView.CurrentRow.Cells["colInfractionTypeID_int"].Value;
          InfractionTypeEntityForm InfractionType=new InfractionTypeEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.InfractionTypeGridView.DataSource, InfractionTypeKey);
          InfractionType.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory=new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionType_TFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys InfractionTypeKey= new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys();

            InfractionTypeKey.InfractionTypeID_int = (Int32?)InfractionTypeGridView.CurrentRow.Cells["colInfractionTypeID_int"].Value;
            InfractionTypeFactory.Delete(InfractionTypeKey);

            DataRow[] dr=((DataTable)this.InfractionTypeGridView.DataSource).Select(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString() + "='" +InfractionTypeKey.InfractionTypeID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.InfractionTypeGridView.DataSource).AcceptChanges();
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
                this.LoadInfractionType();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}