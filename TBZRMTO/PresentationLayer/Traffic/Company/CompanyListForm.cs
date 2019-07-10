using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Company
{
    public partial class CompanyListForm : Hepsa.Core.PL.BaseListForm
    {
        public CompanyListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group CompanyGroup = new Hepsa.Core.PL.BaseListForm.Group();
                CompanyGroup.AddButton = this.NewButton;
                CompanyGroup.DeleteButton = this.DeleteButton;
                CompanyGroup.EditButton = this.EditButton;
                CompanyGroup.RefreshButton = this.RefreshButton;
                CompanyGroup.ExportButton = this.ExportButton;
                CompanyGroup.set_Grid(true,true,true, this.CompanyGridView);
                CompanyGroup.ToolStrip = this.CompanyToolStrip;
                CompanyGroup.HasFilterControl = true;

            this.Groups.Add(CompanyGroup);

            Hepsa.Core.PL.BaseListForm.Group CompanyMobileGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CompanyMobileGroup.AddButton = this.NewCompanyMobileButton;
            CompanyMobileGroup.DeleteButton = this.DeleteCompanyMobileButton;
            CompanyMobileGroup.EditButton = this.EditCompanyMobileButton;
            CompanyMobileGroup.RefreshButton = this.RefreshCompanyMobileButton;
            CompanyMobileGroup.ExportButton = this.ExportCompanyMobileButton;
            CompanyMobileGroup.set_Grid(true, true, true, this.CompanyMobileGridView);
            CompanyMobileGroup.ToolStrip = this.CompanyMobileToolStrip;
            CompanyMobileGroup.HasFilterControl = true;

            this.Groups.Add(CompanyMobileGroup);

            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure Relation = new GroupRelation.RelationStructure();
            Relation.Group1 = CompanyGroup;
            Relation.HasGroup1ChangeEvent = true;
            Relation.Group1FilterColumn = colCompanyID_int.Name;
            Relation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            Relation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            Relation.Group1BusinessFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory() ;

            Relation.Group2 =CompanyMobileGroup ;
            Relation.HasGroup2ChangeEvent = false;
            Relation.Group2FilterColumn = colCompanyID_int.DataPropertyName;
            Relation.Group2BusinessFactory = new HPS.BLL.BLLCompanyMobile_TFactory();
            Relation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref Relation);


        }

         private void CompanyListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadCompany();
            this.CompanyGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadCompany()
        {
            try
            {
               HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
               DataTable CompanyDataTable= new DataTable();
               CompanyFactory.GetAll(ref CompanyDataTable);
               this.CompanyGridView.DataSource = CompanyDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          CompanyEntityForm Company=new CompanyEntityForm((DataTable)this.CompanyGridView.DataSource);
          Company.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.CompanyBLL.BLLCompany_TKeys CompanyKey= new HPS.BLL.CompanyBLL.BLLCompany_TKeys();
          CompanyKey.CompanyID_int = (Int32)this.CompanyGridView.CurrentRow.Cells["colCompanyID_int"].Value;
          CompanyEntityForm Company=new CompanyEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CompanyGridView.DataSource, CompanyKey);
          Company.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory=new HPS.BLL.CompanyBLL.BLLCompany_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.CompanyBLL.BLLCompany_TFactory Company_TFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
            HPS.BLL.CompanyBLL.BLLCompany_TKeys CompanyKey= new HPS.BLL.CompanyBLL.BLLCompany_TKeys();

            CompanyKey.CompanyID_int = (Int32)CompanyGridView.CurrentRow.Cells["colCompanyID_int"].Value;
            CompanyFactory.Delete(CompanyKey);

            DataRow[] dr=((DataTable)this.CompanyGridView.DataSource).Select(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString() + "='" +CompanyKey.CompanyID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.CompanyGridView.DataSource).AcceptChanges();
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
                this.LoadCompany();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          }

        private void NewCompanyMobileButton_Click(object sender, EventArgs e)
        {
            HPS.Present.CompanyMobileEntityForm CompanyMobile = new HPS.Present.CompanyMobileEntityForm((DataTable)this.CompanyMobileGridView.DataSource,Convert.ToInt32(this.CompanyGridView.CurrentRow.Cells[colCompanyID_int.Name].Value));
            CompanyMobile.ShowDialog();
        }

        private void EditCompanyMobileButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.BLLCompanyMobile_TKeys CompanyMobileKey = new HPS.BLL.BLLCompanyMobile_TKeys();
            CompanyMobileKey.CompanyMobileID_int = (Int32)this.CompanyMobileGridView.CurrentRow.Cells["colCompanyMobileID_int"].Value;
            HPS.Present.CompanyMobileEntityForm CompanyMobile = new HPS.Present.CompanyMobileEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.CompanyMobileGridView.DataSource, CompanyMobileKey);
            CompanyMobile.ShowDialog();
        }

        private void DeleteCompanyMobileButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.BLLCompanyMobile_TFactory CompanyMobileFactory = new HPS.BLL.BLLCompanyMobile_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                {
                    return;
                }


                HPS.BLL.BLLCompanyMobile_TFactory CompanyMobile_TFactory = new HPS.BLL.BLLCompanyMobile_TFactory();
                HPS.BLL.BLLCompanyMobile_TKeys CompanyMobileKey = new HPS.BLL.BLLCompanyMobile_TKeys();

                CompanyMobileKey.CompanyMobileID_int = (Int32)CompanyMobileGridView.CurrentRow.Cells["colCompanyMobileID_int"].Value;
                CompanyMobileFactory.Delete(CompanyMobileKey);

                DataRow[] dr = ((DataTable)this.CompanyMobileGridView.DataSource).Select(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyMobileID_int.ToString() + "='" + CompanyMobileKey.CompanyMobileID_int.ToString() + "'");
                if (dr.Length > 0)
                {
                    dr[0].Delete();
                }
                ((DataTable)this.CompanyMobileGridView.DataSource).AcceptChanges();
            }

            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        } 
     }
}