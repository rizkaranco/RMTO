using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.InfractionSurveyGroup
{
    public partial class InfractionSurveyGroupListForm : Hepsa.Core.PL.BaseListForm
    {
        public InfractionSurveyGroupListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group InfractionSurveyGroupGroup = new Hepsa.Core.PL.BaseListForm.Group();
                InfractionSurveyGroupGroup.AddButton = this.NewButton;
                InfractionSurveyGroupGroup.DeleteButton = this.DeleteButton;
                InfractionSurveyGroupGroup.EditButton = this.EditButton;
                InfractionSurveyGroupGroup.RefreshButton = this.RefreshButton;
                InfractionSurveyGroupGroup.ExportButton = this.ExportButton;
                InfractionSurveyGroupGroup.set_Grid(true,true,true, this.InfractionSurveyGroupGridView);
                InfractionSurveyGroupGroup.ToolStrip = this.InfractionSurveyGroupToolStrip;
                InfractionSurveyGroupGroup.HasFilterControl = true;

            this.Groups.Add(InfractionSurveyGroupGroup);

        }

         private void InfractionSurveyGroupListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadInfractionSurveyGroup();
            this.InfractionSurveyGroupGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadInfractionSurveyGroup()
        {
            try
            {
               HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupFactory = new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
               DataTable InfractionSurveyGroupDataTable= new DataTable();
               InfractionSurveyGroupFactory.GetAll(ref InfractionSurveyGroupDataTable);
               this.InfractionSurveyGroupGridView.DataSource = InfractionSurveyGroupDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          InfractionSurveyGroupEntityForm InfractionSurveyGroup=new InfractionSurveyGroupEntityForm((DataTable)this.InfractionSurveyGroupGridView.DataSource);
          InfractionSurveyGroup.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys InfractionSurveyGroupKey= new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys();
          InfractionSurveyGroupKey.InfractionSurveyGroupID_int = (Int32?)this.InfractionSurveyGroupGridView.CurrentRow.Cells["colInfractionSurveyGroupID_int"].Value;
          InfractionSurveyGroupEntityForm InfractionSurveyGroup=new InfractionSurveyGroupEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.InfractionSurveyGroupGridView.DataSource, InfractionSurveyGroupKey);
          InfractionSurveyGroup.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupFactory=new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroup_TFactory = new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
            HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys InfractionSurveyGroupKey= new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TKeys();

            InfractionSurveyGroupKey.InfractionSurveyGroupID_int = (Int32?)InfractionSurveyGroupGridView.CurrentRow.Cells["colInfractionSurveyGroupID_int"].Value;
            InfractionSurveyGroupFactory.Delete(InfractionSurveyGroupKey);

            DataRow[] dr=((DataTable)this.InfractionSurveyGroupGridView.DataSource).Select(HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString() + "='" +InfractionSurveyGroupKey.InfractionSurveyGroupID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.InfractionSurveyGroupGridView.DataSource).AcceptChanges();
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
                this.LoadInfractionSurveyGroup();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}