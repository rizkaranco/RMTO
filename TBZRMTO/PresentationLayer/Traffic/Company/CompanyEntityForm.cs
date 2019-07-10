using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Company
{
    public partial class CompanyEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CompanyEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public CompanyEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.CompanyBLL.BLLCompany_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void CompanyEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                    this.FillCombo();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void ShowForm()
        {
            this.FillCombo();
            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
            HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = CompanyFactory.GetBy((HPS.BLL.CompanyBLL.BLLCompany_TKeys)Key);
            if (CompanyEntity == null)
            {
                throw new HPS.Exceptions.CompanyNotFound();
            }
            CompanyCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.CompanyCode_nvc, TypeCode.String));
            Company_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.Company_nvc, TypeCode.String));
            DirectorName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.DirectorName_nvc, TypeCode.String));
            DirectorMobile_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.DirectorMobile_nvc, TypeCode.String));
            Phone_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.Phone_nvc, TypeCode.String));
            Fax_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.Fax_nvc, TypeCode.String));
            Email_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.Email_nvc, TypeCode.String));
            WebAddress_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.WebAddress_nvc, TypeCode.String));
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.Active_bit, TypeCode.Boolean);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionGroupID_intComboBox, CompanyEntity.InfractionGroupID_int, TypeCode.Int32);
            Address_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.Address_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CityID_intComboBox, CompanyEntity.CityID_int, TypeCode.Int32);
            CityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.CityCode_nvc, TypeCode.String));

        }

        protected override void Insert()
        {
            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
            try
            {
                HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();
                CompanyEntity.CompanyCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyCode_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Company_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Company_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.DirectorName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DirectorName_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.DirectorMobile_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DirectorMobile_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Phone_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Phone_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Fax_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Fax_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Email_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Email_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.WebAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(WebAddress_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Active_bit = Active_bitCheckBox.Checked;
                CompanyEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                CompanyEntity.Address_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Address_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.CityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.Int32);
                CompanyEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.GroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyGroupComboBox.SelectedValue, TypeCode.Int32);
                CompanyFactory.BeginProc();
                CompanyFactory.Insert(CompanyEntity);
                CompanyFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.CompanyID_int, TypeCode.Int32);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.CompanyCode_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Company_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.DirectorName_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorMobile_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.DirectorMobile_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Phone_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Phone_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Fax_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Fax_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Email_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Email_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.WebAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.WebAddress_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Active_bit, TypeCode.Boolean);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.InfractionGroupID_int, TypeCode.Int32);
                    dr["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Address_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Address_nvc, TypeCode.String);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.CityID_int, TypeCode.Int32);
                    dr["CityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CityID_intComboBox);
                    dr[HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.CityCode_nvc, TypeCode.String);
                    dr["GroupName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyGroupComboBox);
                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                CompanyFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
            try
            {
                HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();
                CompanyEntity.CompanyCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyCode_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Company_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Company_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.DirectorName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DirectorName_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.DirectorMobile_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DirectorMobile_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Phone_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Phone_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Fax_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Fax_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Email_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Email_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.WebAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(WebAddress_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.Active_bit = Active_bitCheckBox.Checked;
                CompanyEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                CompanyEntity.Address_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Address_nvcTextBox.Text, TypeCode.String).ToString();
                CompanyEntity.CityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.Int32);
                CompanyEntity.CityCode_nvc =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CityEntity.CityCode_nvc, TypeCode.String));
                CompanyEntity.GroupID_int =  (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyGroupComboBox.SelectedValue, TypeCode.Int32);
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    CompanyFactory.BeginProc();
                    CompanyFactory.Update(CompanyEntity, (HPS.BLL.CompanyBLL.BLLCompany_TKeys)Key);
                    CompanyFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString() + "='" + ((HPS.BLL.CompanyBLL.BLLCompany_TKeys)Key).CompanyID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.CompanyCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Company_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.DirectorName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorMobile_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.DirectorMobile_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Phone_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Phone_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Fax_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Fax_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Email_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Email_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.WebAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.WebAddress_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Active_bit, TypeCode.Boolean);
                            dr[0]["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Address_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.Address_nvc, TypeCode.String);
                            dr[0]["CityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CityID_intComboBox);
                            dr[0][HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CompanyEntity.CityCode_nvc, TypeCode.String);
                            dr[0]["GroupName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyGroupComboBox);
                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                CompanyFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    CompanyFactory.BeginProc();
                    CompanyFactory.Delete((HPS.BLL.CompanyBLL.BLLCompany_TKeys)Key);
                    CompanyFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString() + "='" + ((HPS.BLL.CompanyBLL.BLLCompany_TKeys)Key).CompanyID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0].Delete();
                        }
                        DataTable.AcceptChanges();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                CompanyFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupID_intFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
                DataTable InfractionGroupID_intDataTable = new DataTable();
                InfractionGroupID_intFactory.GetAll(ref InfractionGroupID_intDataTable);
                this.InfractionGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString();
                this.InfractionGroupID_intComboBox.ValueMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.DataSource = InfractionGroupID_intDataTable;
                this.InfractionGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CityBLL.BLLCity_TFactory CityID_intFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                DataTable CityID_intDataTable = new DataTable();
                CityID_intFactory.GetAll(ref CityID_intDataTable);
                this.CityID_intComboBox.DisplayMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString();
                this.CityID_intComboBox.ValueMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString();
                this.CityID_intComboBox.DataSource = CityID_intDataTable;
                this.CityID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory GroupID_intFactory = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TFactory();
                DataTable GroupID_intDataTable = new DataTable();
                GroupID_intFactory.GetAll(ref GroupID_intDataTable);
                this.CompanyGroupComboBox.DisplayMember = "GroupName_nvc";
                this.CompanyGroupComboBox.ValueMember = "GroupID_int";
                this.CompanyGroupComboBox.DataSource = GroupID_intDataTable;
                this.CompanyGroupComboBox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InfractionGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionGroup.InfractionGroupEntityForm frm = new HPS.Present.InfractionGroup.InfractionGroupEntityForm((DataTable)InfractionGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }
        HPS.BLL.CityBLL.BLLCity_T CityEntity = new HPS.BLL.CityBLL.BLLCity_T();
        private void CityID_intNewButton_Click(object sender, EventArgs e)
        {

            HPS.Present.SearchForm.CitySearch frm = new HPS.Present.SearchForm.CitySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CityEntity = frm.SelectedCity;
                CityCode_nvcTextBox.Text = CityEntity.CityCode_nvc;
                CityID_intComboBox.Text = CityEntity.City_nvc;
                CityID_intComboBox.Enabled = false;
            }
            else
            {
                CityID_intComboBox.Enabled = true;
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            HPS.Present.CompanyGroup.CompanyGroupEntityForm frmGroup = new CompanyGroup.CompanyGroupEntityForm((DataTable)CompanyGroupComboBox.DataSource);
            frmGroup.ShowDialog();
        }



    }
}