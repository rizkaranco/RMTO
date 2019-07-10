using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Class
{
    public partial class ClassListForm : Hepsa.Core.PL.BaseListForm
    {
        public ClassListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group ClassGroup = new Hepsa.Core.PL.BaseListForm.Group();
                ClassGroup.AddButton = this.NewButton;
                ClassGroup.DeleteButton = this.DeleteButton;
                ClassGroup.EditButton = this.EditButton;
                ClassGroup.RefreshButton = this.RefreshButton;
                ClassGroup.ExportButton = this.ExportButton;
                ClassGroup.set_Grid(true,true,true, this.ClassGridView);
                ClassGroup.ToolStrip = this.ClassToolStrip;
                ClassGroup.HasFilterControl = true;

            this.Groups.Add(ClassGroup);

        }

         private void ClassListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadClass();
            this.ClassGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadClass()
        {
            try
            {
               HPS.BLL.ClassBLL.BLLClass_TFactory ClassFactory = new HPS.BLL.ClassBLL.BLLClass_TFactory();
               DataTable ClassDataTable= new DataTable();
               ClassFactory.GetAll(ref ClassDataTable);
               this.ClassGridView.DataSource = ClassDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          ClassEntityForm Class=new ClassEntityForm((DataTable)this.ClassGridView.DataSource);
          Class.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.ClassBLL.BLLClass_TKeys ClassKey= new HPS.BLL.ClassBLL.BLLClass_TKeys();
          ClassKey.ClassID_int = (Int32)this.ClassGridView.CurrentRow.Cells["colClassID_int"].Value;
          ClassEntityForm Class=new ClassEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.ClassGridView.DataSource, ClassKey);
          Class.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.ClassBLL.BLLClass_TFactory ClassFactory=new HPS.BLL.ClassBLL.BLLClass_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.ClassBLL.BLLClass_TFactory Class_TFactory = new HPS.BLL.ClassBLL.BLLClass_TFactory();
            HPS.BLL.ClassBLL.BLLClass_TKeys ClassKey= new HPS.BLL.ClassBLL.BLLClass_TKeys();

            ClassKey.ClassID_int = (Int32)ClassGridView.CurrentRow.Cells["colClassID_int"].Value;
            ClassFactory.Delete(ClassKey);

            DataRow[] dr=((DataTable)this.ClassGridView.DataSource).Select(HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassID_int.ToString() + "='" +ClassKey.ClassID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.ClassGridView.DataSource).AcceptChanges();
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
                this.LoadClass();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}