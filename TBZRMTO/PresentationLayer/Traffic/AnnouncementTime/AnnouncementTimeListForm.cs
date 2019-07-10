using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.AnnouncementTime
{
    public partial class AnnouncementTimeListForm : Hepsa.Core.PL.BaseListForm
    {
        public AnnouncementTimeListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group AnnouncementTimeGroup = new Hepsa.Core.PL.BaseListForm.Group();
                AnnouncementTimeGroup.AddButton = this.NewButton;
                AnnouncementTimeGroup.DeleteButton = this.DeleteButton;
                AnnouncementTimeGroup.EditButton = this.EditButton;
                AnnouncementTimeGroup.RefreshButton = this.RefreshButton;
                AnnouncementTimeGroup.ExportButton = this.ExportButton;
                AnnouncementTimeGroup.set_Grid(true,true,true, this.AnnouncementTimeGridView);
                AnnouncementTimeGroup.ToolStrip = this.AnnouncementTimeToolStrip;
                AnnouncementTimeGroup.HasFilterControl = true;

            this.Groups.Add(AnnouncementTimeGroup);

        }

         private void AnnouncementTimeListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadAnnouncementTime();
            this.AnnouncementTimeGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadAnnouncementTime()
        {
            try
            {
               HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();
               DataTable AnnouncementTimeDataTable= new DataTable();
               AnnouncementTimeFactory.GetAll(ref AnnouncementTimeDataTable);
               this.AnnouncementTimeGridView.DataSource = AnnouncementTimeDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          AnnouncementTimeEntityForm AnnouncementTime=new AnnouncementTimeEntityForm((DataTable)this.AnnouncementTimeGridView.DataSource);
          AnnouncementTime.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys AnnouncementTimeKey= new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys();
          AnnouncementTimeKey.AnnouncementTimeID_int = (Int32?)this.AnnouncementTimeGridView.CurrentRow.Cells["colAnnouncementTimeID_int"].Value;
          AnnouncementTimeEntityForm AnnouncementTime=new AnnouncementTimeEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.AnnouncementTimeGridView.DataSource, AnnouncementTimeKey);
          AnnouncementTime.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeFactory=new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTime_TFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();
            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys AnnouncementTimeKey= new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys();

            AnnouncementTimeKey.AnnouncementTimeID_int = (Int32?)AnnouncementTimeGridView.CurrentRow.Cells["colAnnouncementTimeID_int"].Value;
            AnnouncementTimeFactory.Delete(AnnouncementTimeKey);

            DataRow[] dr=((DataTable)this.AnnouncementTimeGridView.DataSource).Select(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTimeID_int.ToString() + "='" +AnnouncementTimeKey.AnnouncementTimeID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.AnnouncementTimeGridView.DataSource).AcceptChanges();
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
                this.LoadAnnouncementTime();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}