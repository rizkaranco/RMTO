using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.User
{
    public partial class UserListForm : Hepsa.Core.PL.BaseListForm
    {
        public UserListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group UserGroup = new Hepsa.Core.PL.BaseListForm.Group();
                UserGroup.AddButton = this.NewButton;
                UserGroup.DeleteButton = this.DeleteButton;
                UserGroup.EditButton = this.EditButton;
                UserGroup.RefreshButton = this.RefreshButton;
                UserGroup.ExportButton = this.ExportButton;
                UserGroup.set_Grid(true,true,true, this.UserGridView);
                UserGroup.ToolStrip = this.UserToolStrip;
                UserGroup.HasFilterControl = true;

            this.Groups.Add(UserGroup);

        }

         private void UserListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadUser();
            this.UserGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadUser()
        {
            try
            {
               HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
               DataTable UserDataTable= new DataTable();
               UserFactory.GetAll(ref UserDataTable);
               this.UserGridView.DataSource = UserDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          UserEntityForm User=new UserEntityForm((DataTable)this.UserGridView.DataSource);
          User.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.UserBLL.BLLUser_TKeys UserKey= new HPS.BLL.UserBLL.BLLUser_TKeys();
          UserKey.UserName_nvc = (String)this.UserGridView.CurrentRow.Cells["colUserName_nvc"].Value;
          UserEntityForm User=new UserEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.UserGridView.DataSource, UserKey);
          User.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.UserBLL.BLLUser_TFactory UserFactory=new HPS.BLL.UserBLL.BLLUser_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.UserBLL.BLLUser_TFactory User_TFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
            HPS.BLL.UserBLL.BLLUser_TKeys UserKey= new HPS.BLL.UserBLL.BLLUser_TKeys();

            UserKey.UserName_nvc = (String)UserGridView.CurrentRow.Cells["colUserName_nvc"].Value;
            UserFactory.Delete(UserKey);

            DataRow[] dr=((DataTable)this.UserGridView.DataSource).Select(HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString() + "='" +UserKey.UserName_nvc.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.UserGridView.DataSource).AcceptChanges();
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
                this.LoadUser();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}