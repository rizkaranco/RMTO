using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.UserGroup
{
    public partial class UserGroupListForm : Hepsa.Core.PL.BaseListForm
    {
        public UserGroupListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group UserGroupGroup = new Hepsa.Core.PL.BaseListForm.Group();
                UserGroupGroup.AddButton = this.NewButton;
                UserGroupGroup.DeleteButton = this.DeleteButton;
                UserGroupGroup.EditButton = this.EditButton;
                UserGroupGroup.RefreshButton = this.RefreshButton;
                UserGroupGroup.ExportButton = this.ExportButton;
                UserGroupGroup.set_Grid(true,true,true, this.UserGroupGridView);
                UserGroupGroup.ToolStrip = this.UserGroupToolStrip;
                UserGroupGroup.HasFilterControl = true;

            this.Groups.Add(UserGroupGroup);

        }

         private void UserGroupListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadUserGroup();
            this.UserGroupGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadUserGroup()
        {
            try
            {
               HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
               DataTable UserGroupDataTable= new DataTable();
               UserGroupFactory.GetAll(ref UserGroupDataTable);
               this.UserGroupGridView.DataSource = UserGroupDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          UserGroupEntityForm UserGroup=new UserGroupEntityForm((DataTable)this.UserGroupGridView.DataSource);
          UserGroup.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys UserGroupKey= new HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys();
          UserGroupKey.UserGroupID_int = (Int32?)this.UserGroupGridView.CurrentRow.Cells["colUserGroupID_int"].Value;
          UserGroupEntityForm UserGroup=new UserGroupEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.UserGroupGridView.DataSource, UserGroupKey);
          UserGroup.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory=new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroup_TFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
            HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys UserGroupKey= new HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys();

            UserGroupKey.UserGroupID_int = (Int32?)UserGroupGridView.CurrentRow.Cells["colUserGroupID_int"].Value;
            UserGroupFactory.Delete(UserGroupKey);

            DataRow[] dr=((DataTable)this.UserGroupGridView.DataSource).Select(HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString() + "='" +UserGroupKey.UserGroupID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.UserGroupGridView.DataSource).AcceptChanges();
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
                this.LoadUserGroup();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}