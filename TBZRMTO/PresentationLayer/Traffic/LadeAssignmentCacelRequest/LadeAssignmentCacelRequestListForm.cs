using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.LadeAssignmentCacelRequest
{
    public partial class LadeAssignmentCacelRequestListForm : Hepsa.Core.PL.BaseListForm
    {
        public LadeAssignmentCacelRequestListForm()
        {
            InitializeComponent();
            LaderTypeGridView.AutoGenerateColumns = false;
            Group LadeAssignmentGroup = new Group();
            LadeAssignmentGroup.GroupName = "LadeAssignmentGroup";
            LadeAssignmentGroup.set_Grid(true, true, true, this.LadeAssignmentGridView);
            LadeAssignmentGroup.HasFilterControl = true;
            LadeAssignmentGroup.ToolStrip = LadeAssignmentCacelRequestToolStrip;
            this.Groups.Add(LadeAssignmentGroup);

            Hepsa.Core.PL.BaseListForm.Group LadeAssignmentCancelRequestGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeAssignmentCancelRequestGroup.GroupName = "LadeAssignmentCancelRequestGroup";
            LadeAssignmentCancelRequestGroup.AddButton = this.NewButton;
            LadeAssignmentCancelRequestGroup.DeleteButton = this.DeleteButton;
            LadeAssignmentCancelRequestGroup.EditButton = this.EditButton;
            LadeAssignmentCancelRequestGroup.RefreshButton = this.RefreshButton;
            LadeAssignmentCancelRequestGroup.ExportButton = this.ExportButton;
            LadeAssignmentCancelRequestGroup.set_Grid(true, true, true, this.LadeAssignmentCacelRequestGridView);
            LadeAssignmentCancelRequestGroup.HasFilterControl = true;
            this.Groups.Add(LadeAssignmentCancelRequestGroup);

            Hepsa.Core.PL.BaseListForm.Group LadeCancelCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeCancelCommentGroup.GroupName = "LadeCancelCommentGroup";
            LadeCancelCommentGroup.set_Grid(true, true, true, LadeAssignmentCancelRequestCommentGridView);
            LadeCancelCommentGroup.HasFilterControl = false;
            this.Groups.Add(LadeCancelCommentGroup);

            Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LaderTypeGroup.GroupName = "LaderTypeGroup";
            LaderTypeGroup.AddButton = null;
            LaderTypeGroup.DeleteButton = null;
            LaderTypeGroup.EditButton = null;
            LaderTypeGroup.RefreshButton = null;
            LaderTypeGroup.set_Grid(false, false, true, this.LaderTypeGridView);
            this.Groups.Add(LaderTypeGroup);


            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure LadeAssignmentRelation = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            LadeAssignmentRelation.Group1 = LadeAssignmentGroup;
            LadeAssignmentRelation.HasGroup1ChangeEvent = true;
            LadeAssignmentRelation.Group1FilterColumn = colLadeAssignmentID_bint.Name;
            LadeAssignmentRelation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            LadeAssignmentRelation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            LadeAssignmentRelation.Group1BusinessFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();

            LadeAssignmentRelation.Group2 = LadeAssignmentCancelRequestGroup;
            LadeAssignmentRelation.HasGroup2ChangeEvent = false;
            LadeAssignmentRelation.Group2FilterColumn = colLadeAssignmentID_bint.DataPropertyName;
            LadeAssignmentRelation.Group2BusinessFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
            LadeAssignmentRelation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref LadeAssignmentRelation);


            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure LadeAssignmentCancelRelation = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            LadeAssignmentCancelRelation.Group1 = LadeAssignmentCancelRequestGroup;
            LadeAssignmentCancelRelation.HasGroup1ChangeEvent = true;
            LadeAssignmentCancelRelation.Group1FilterColumn = colLadeAssignmentCancelRequestID_int.Name;
            LadeAssignmentCancelRelation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            LadeAssignmentCancelRelation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            LadeAssignmentCancelRelation.Group1BusinessFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();

            LadeAssignmentCancelRelation.Group2 = LadeCancelCommentGroup;
            LadeAssignmentCancelRelation.HasGroup2ChangeEvent = false;
            LadeAssignmentCancelRelation.Group2FilterColumn = colLadeAssignmentCancelRequestID_int.DataPropertyName;
            LadeAssignmentCancelRelation.Group2BusinessFactory = new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory();
            LadeAssignmentCancelRelation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref LadeAssignmentCancelRelation);


            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure LadeAssignmentRelation2 = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            LadeAssignmentRelation2.Group1 = LadeAssignmentGroup;
            LadeAssignmentRelation2.HasGroup1ChangeEvent = true;
            LadeAssignmentRelation2.Group1FilterColumn = colLadeAssignmentID_bint.Name;
            LadeAssignmentRelation2.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            LadeAssignmentRelation2.Group1RelationType = GroupRelation.enmRelationType.Eual;
            LadeAssignmentRelation2.Group1BusinessFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();

            LadeAssignmentRelation2.Group2 = LaderTypeGroup;
            LadeAssignmentRelation2.HasGroup2ChangeEvent = false;
            LadeAssignmentRelation2.Group2FilterColumn = colLadeAssignmentID_bint.DataPropertyName;
            LadeAssignmentRelation2.Group2BusinessFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
            LadeAssignmentRelation2.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref LadeAssignmentRelation2);


        }

         private void LadeAssignmentCacelRequestListForm_Load(object sender, EventArgs e)
       {
            try
          {
           
              LoadLadeAssignment();
           
            this.LadeAssignmentCacelRequestGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }

         private void LoadLadeAssignmentCancelRequestComment()
         {
             try
             {
                 HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory LadeAssignmentCancelRequestCommentFactory = new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory();
                 DataTable LadeAssignmentCancelRequestCommentDataTable = new DataTable();
                 LadeAssignmentCancelRequestCommentFactory.GetAll(ref LadeAssignmentCancelRequestCommentDataTable);
                 this.LadeAssignmentCancelRequestCommentGridView.DataSource = LadeAssignmentCancelRequestCommentDataTable;
             }
             catch (System.Exception ex)
             {
                 throw ex;
             }

         }


         private void LoadLadeAssignment()
         {
             try
             {
                 HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                 DataTable LadeAssignmentDataTable = new DataTable();
                 LadeAssignmentFactory.GetAll(ref LadeAssignmentDataTable,LadeAssignmentFactory.ServerJalaliDate,0);
                 this.LadeAssignmentGridView.DataSource = LadeAssignmentDataTable;
             }
             catch (System.Exception ex)
             {
                 throw ex;
             }

         }


         private void LoadLadeAssignmentCacelRequest()
        {
            try
            {
               HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
               DataTable LadeAssignmentCacelRequestDataTable= new DataTable();
               LadeAssignmentCacelRequestFactory.GetAll(ref LadeAssignmentCacelRequestDataTable);
               this.LadeAssignmentCacelRequestGridView.DataSource = LadeAssignmentCacelRequestDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
            LadeAssignmentKey.LadeAssignmentID_bint =(Int64?)this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value;
          LadeAssignmentCacelRequestEntityForm LadeAssignmentCacelRequest=new LadeAssignmentCacelRequestEntityForm((DataTable)this.LadeAssignmentCacelRequestGridView.DataSource,LadeAssignmentKey);
          LadeAssignmentCacelRequest.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys LadeAssignmentCacelRequestKey= new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys();
          LadeAssignmentCacelRequestKey.LadeAssignmentCancelRequestID_int = (Int32)this.LadeAssignmentCacelRequestGridView.CurrentRow.Cells["colLadeAssignmentCancelRequestID_int"].Value;
          HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
          LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value;
          LadeAssignmentCacelRequestEntityForm LadeAssignmentCacelRequest = new LadeAssignmentCacelRequestEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LadeAssignmentCacelRequestGridView.DataSource, LadeAssignmentCacelRequestKey, LadeAssignmentKey);
          LadeAssignmentCacelRequest.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory=new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequest_TFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys LadeAssignmentCacelRequestKey= new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys();

            LadeAssignmentCacelRequestKey.LadeAssignmentCancelRequestID_int = (Int32)LadeAssignmentCacelRequestGridView.CurrentRow.Cells["colLadeAssignmentCancelRequestID_int"].Value;
            LadeAssignmentCacelRequestFactory.Delete(LadeAssignmentCacelRequestKey);

            DataRow[] dr=((DataTable)this.LadeAssignmentCacelRequestGridView.DataSource).Select(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentCancelRequestID_int.ToString() + "='" +LadeAssignmentCacelRequestKey.LadeAssignmentCancelRequestID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.LadeAssignmentCacelRequestGridView.DataSource).AcceptChanges();
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
                this.LoadLadeAssignmentCacelRequest();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          }

        private void LadeAssignmentCancelRequestCommentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LadeAssignmentCacelRequestGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllLatoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadLadeAssignmentCacelRequest();
                LoadLadeAssignmentCancelRequestComment();
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LadeAssignmentDataTable = new DataTable();
                LadeAssignmentFactory.GetAll(ref LadeAssignmentDataTable);
                this.LadeAssignmentGridView.DataSource = LadeAssignmentDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        } 
     }
}