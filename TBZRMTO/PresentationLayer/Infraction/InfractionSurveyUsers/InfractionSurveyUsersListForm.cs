using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.InfractionSurveyUsers
{
    public partial class InfractionSurveyUsersListForm : Hepsa.Core.PL.BaseListForm
    {
        public InfractionSurveyUsersListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group InfractionSurveyUsersGroup = new Hepsa.Core.PL.BaseListForm.Group();
                InfractionSurveyUsersGroup.AddButton = this.NewButton;
                InfractionSurveyUsersGroup.DeleteButton = this.DeleteButton;
                InfractionSurveyUsersGroup.EditButton = this.EditButton;
                InfractionSurveyUsersGroup.RefreshButton = this.RefreshButton;
                InfractionSurveyUsersGroup.ExportButton = this.ExportButton;
                InfractionSurveyUsersGroup.set_Grid(true,true,true, this.InfractionSurveyUsersGridView);
                InfractionSurveyUsersGroup.ToolStrip = this.InfractionSurveyUsersToolStrip;
                InfractionSurveyUsersGroup.HasFilterControl = true;

            this.Groups.Add(InfractionSurveyUsersGroup);

        }

         private void InfractionSurveyUsersListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadInfractionSurveyUsers();
            this.InfractionSurveyUsersGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadInfractionSurveyUsers()
        {
            try
            {
               HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsersFactory = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();
               DataTable InfractionSurveyUsersDataTable= new DataTable();
               InfractionSurveyUsersFactory.GetAll(ref InfractionSurveyUsersDataTable);
               this.InfractionSurveyUsersGridView.DataSource = InfractionSurveyUsersDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          InfractionSurveyUsersEntityForm InfractionSurveyUsers=new InfractionSurveyUsersEntityForm((DataTable)this.InfractionSurveyUsersGridView.DataSource);
          InfractionSurveyUsers.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys InfractionSurveyUsersKey= new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys();
          InfractionSurveyUsersKey.InfractionSurveyUsersID_int = (Int32)this.InfractionSurveyUsersGridView.CurrentRow.Cells["colInfractionSurveyUsersID_int"].Value;
          InfractionSurveyUsersEntityForm InfractionSurveyUsers=new InfractionSurveyUsersEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.InfractionSurveyUsersGridView.DataSource, InfractionSurveyUsersKey);
          InfractionSurveyUsers.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsersFactory=new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsers_TFactory = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();
            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys InfractionSurveyUsersKey= new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys();

            InfractionSurveyUsersKey.InfractionSurveyUsersID_int = (Int32)InfractionSurveyUsersGridView.CurrentRow.Cells["colInfractionSurveyUsersID_int"].Value;
            InfractionSurveyUsersFactory.Delete(InfractionSurveyUsersKey);

            DataRow[] dr=((DataTable)this.InfractionSurveyUsersGridView.DataSource).Select(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyUsersID_int.ToString() + "='" +InfractionSurveyUsersKey.InfractionSurveyUsersID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.InfractionSurveyUsersGridView.DataSource).AcceptChanges();
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
                this.LoadInfractionSurveyUsers();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}