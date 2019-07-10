using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Infraction
{
    public partial class InfractionListForm : Hepsa.Core.PL.BaseListForm
    {
        public InfractionListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group InfractionGroup = new Hepsa.Core.PL.BaseListForm.Group();
                InfractionGroup.AddButton = this.NewButton;
                InfractionGroup.DeleteButton = this.DeleteButton;
                InfractionGroup.EditButton = this.EditButton;
                InfractionGroup.RefreshButton = this.RefreshButton;
                InfractionGroup.ExportButton = this.ExportButton;
                InfractionGroup.set_Grid(true,true,true, this.InfractionGridView);
                InfractionGroup.ToolStrip = this.InfractionToolStrip;
                InfractionGroup.HasFilterControl = true;

            this.Groups.Add(InfractionGroup);

        }

         private void InfractionListForm_Load(object sender, EventArgs e)
       {
            try
          {
              HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
              DataTable CompanyID_intDataTable = new DataTable();
              string companyCondition = "Company_T.Active_bit='True'";
              CompanyID_intFactory.GetAllByCondition(companyCondition, ref CompanyID_intDataTable);
              this.CompanyID_intComboBox.DisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
              this.CompanyID_intComboBox.ValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
              this.CompanyID_intComboBox.DataSource = CompanyID_intDataTable;
              this.CompanyID_intComboBox.SelectedIndex = -1;
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadInfraction()
        {
            try
            {
               HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
               DataTable InfractionDataTable= new DataTable();
               InfractionFactory.GetAll(ref InfractionDataTable);
               this.InfractionGridView.DataSource = InfractionDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {

            
          InfractionEntityForm Infraction=new InfractionEntityForm((DataTable)this.InfractionGridView.DataSource);
          Infraction.ShowDialog();
        }
         private bool registered = false;
        private void EditButton_Click(object sender,EventArgs e)
        {
            try
            {
                HPS.BLL.InfractionBLL.BLLInfraction_TKeys InfractionKey = new HPS.BLL.InfractionBLL.BLLInfraction_TKeys();
                InfractionKey.InfractionID_int = (Int32)this.InfractionGridView.CurrentRow.Cells["colInfractionID_int"].Value;
                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                HPS.BLL.InfractionBLL.BLLInfraction_T InfractionEntity = InfractionFactory.GetBy(InfractionKey);
                if (!string.IsNullOrEmpty(InfractionEntity.RegisterUserName_nvc) && !string.IsNullOrEmpty(InfractionEntity.RegisterDate_nvc))
                {
                    registered = true;
                }
                InfractionEntityForm Infraction = new InfractionEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.InfractionGridView.DataSource, InfractionKey, registered);
                Infraction.ShowDialog();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory=new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.InfractionBLL.BLLInfraction_TFactory Infraction_TFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
            HPS.BLL.InfractionBLL.BLLInfraction_TKeys InfractionKey= new HPS.BLL.InfractionBLL.BLLInfraction_TKeys();

            InfractionKey.InfractionID_int = (Int32)InfractionGridView.CurrentRow.Cells["colInfractionID_int"].Value;
            InfractionFactory.Delete(InfractionKey);

            DataRow[] dr=((DataTable)this.InfractionGridView.DataSource).Select(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionID_int.ToString() + "='" +InfractionKey.InfractionID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.InfractionGridView.DataSource).AcceptChanges();
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
                this.LoadInfraction();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          }

        private void ShowAlltoolStripButton_Click(object sender, EventArgs e)
        {
            this.LoadInfraction();
            SerialPlate_nvctextBox.Text = string.Empty;
            NumberPlate_nvctextBox.Text = string.Empty;
            lastName_nvctextBox.Text = string.Empty;
        }

        private void lastName_nvctextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(lastName_nvctextBox.Text)==false )
                {
                    HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                    DataTable InfractionDataTable = new DataTable();
                    InfractionFactory.GetAllByCondition(string.Format("[Infraction_T].DriverLastName_nvc Like N'%{0}%'",lastName_nvctextBox.Text),ref  InfractionDataTable);
                    this.InfractionGridView.DataSource = InfractionDataTable;
                    SerialPlate_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                }
             

            }
        }

        private void SerialPlate_nvctextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(SerialPlate_nvctextBox.Text)==false || string.IsNullOrEmpty(NumberPlate_nvctextBox.Text)==false )
                {
                    HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                    DataTable InfractionDataTable = new DataTable();
                    InfractionFactory.GetAllByCondition(string.Format("[Infraction_T].SerialPlate_nvc Like N'%{0}%' And [Infraction_T].NumberPlate_nvc Like N'%{1}%'", SerialPlate_nvctextBox.Text,NumberPlate_nvctextBox.Text),ref InfractionDataTable);
                    this.InfractionGridView.DataSource = InfractionDataTable;
                    lastName_nvctextBox.Text = string.Empty;
                   
                }


            }
        }

        private void CompanyID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CompanyID_intComboBox.SelectedValue!=null)
            {
                   HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                    DataTable InfractionDataTable = new DataTable();
                    InfractionFactory.GetAllByCondition(string.Format("[Infraction_T].CompanyID_int ={0} ", CompanyID_intComboBox.SelectedValue), ref  InfractionDataTable);
                    this.InfractionGridView.DataSource = InfractionDataTable;
                    lastName_nvctextBox.Text = string.Empty;
                    SerialPlate_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
            }
        }

        private void CompanyID_intComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (CompanyID_intComboBox.SelectedValue != null)
                {
                    HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                    DataTable InfractionDataTable = new DataTable();
                    InfractionFactory.GetAllByCondition(string.Format("[Infraction_T].CompanyID_int ={0} ", CompanyID_intComboBox.SelectedValue), ref  InfractionDataTable);
                    this.InfractionGridView.DataSource = InfractionDataTable;
                    lastName_nvctextBox.Text = string.Empty;
                    SerialPlate_nvctextBox.Text = string.Empty;
                    NumberPlate_nvctextBox.Text = string.Empty;
                }
            }
        } 
     }
}