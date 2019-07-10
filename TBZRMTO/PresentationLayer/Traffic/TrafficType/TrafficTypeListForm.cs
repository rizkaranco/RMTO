using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.TrafficType
{
    public partial class TrafficTypeListForm : Hepsa.Core.PL.BaseListForm
    {
        public TrafficTypeListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group TrafficTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
                TrafficTypeGroup.AddButton = this.NewButton;
                TrafficTypeGroup.DeleteButton = this.DeleteButton;
                TrafficTypeGroup.EditButton = this.EditButton;
                TrafficTypeGroup.RefreshButton = this.RefreshButton;
                TrafficTypeGroup.ExportButton = this.ExportButton;
                TrafficTypeGroup.set_Grid(true,true,true, this.TrafficTypeGridView);
                TrafficTypeGroup.ToolStrip = this.TrafficTypeToolStrip;
                TrafficTypeGroup.HasFilterControl = true;

            this.Groups.Add(TrafficTypeGroup);

        }

         private void TrafficTypeListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadTrafficType();
            this.TrafficTypeGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadTrafficType()
        {
            try
            {
               HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
               DataTable TrafficTypeDataTable= new DataTable();
               TrafficTypeFactory.GetAll(ref TrafficTypeDataTable);
               this.TrafficTypeGridView.DataSource = TrafficTypeDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          TrafficTypeEntityForm TrafficType=new TrafficTypeEntityForm((DataTable)this.TrafficTypeGridView.DataSource);
          TrafficType.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
            string condition = "[TrafficType_T].[TrafficType_nvc]='" + TrafficTypeGridView.CurrentRow.Cells[colTrafficType_nvc.Name].Value + "'";
            List<HPS.BLL.TrafficTypeBLL.BLLTrafficType_T> lst = TrafficTypeFactory.GetAllByCondition(condition);
            int flag = 0;
            foreach (HPS.BLL.TrafficTypeBLL.BLLTrafficType_T item in lst)
            {
                if (item.TrafficTypeID_int==1 || item.TrafficTypeID_int==2)
                {
                    flag = 1;
                }
            }
            if (flag!=1)
            {
                HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys TrafficTypeKey = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys();
                TrafficTypeKey.TrafficTypeID_int = (Int32?)this.TrafficTypeGridView.CurrentRow.Cells["colTrafficTypeID_int"].Value;
                TrafficTypeEntityForm TrafficType = new TrafficTypeEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.TrafficTypeGridView.DataSource, TrafficTypeKey);
                TrafficType.ShowDialog();
            }
          
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory=new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficType_TFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys TrafficTypeKey= new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TKeys();

            TrafficTypeKey.TrafficTypeID_int = (Int32?)TrafficTypeGridView.CurrentRow.Cells["colTrafficTypeID_int"].Value;
            TrafficTypeFactory.Delete(TrafficTypeKey);

            DataRow[] dr=((DataTable)this.TrafficTypeGridView.DataSource).Select(HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString() + "='" +TrafficTypeKey.TrafficTypeID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.TrafficTypeGridView.DataSource).AcceptChanges();
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
                this.LoadTrafficType();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}