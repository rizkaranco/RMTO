using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace HPS.Present.User
{
    public partial class UserEntityForm : Hepsa.Core.PL.BaseEntityForm2
    {

        public UserEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public UserEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.UserBLL.BLLUser_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void UserEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
            HPS.BLL.UserBLL.BLLUser_T UserEntity = UserFactory.GetBy((HPS.BLL.UserBLL.BLLUser_TKeys)Key);
            System.IO.MemoryStream memorystream = new System.IO.MemoryStream();
            if (UserEntity == null)
            {
                throw new HPS.Exceptions.UserNotFound();
            }
            if (UserEntity.Picture_img != null)
            {
                memorystream.Write(UserEntity.Picture_img, 0, UserEntity.Picture_img.Length);
                PictureBox.Image = System.Drawing.Image.FromStream(memorystream);
            }
            else
            {
                PictureBox.Image = HPS.Properties.Resources.user;
            }
            UserName_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.UserName_nvc, TypeCode.String).ToString();
            FullName_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.FullName_nvc, TypeCode.String).ToString();
            Password_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.Password_nvc, TypeCode.String).ToString();
            ConfirmPasswordTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.Password_nvc, TypeCode.String).ToString();
            StartDate_vcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.StartDate_vc, TypeCode.String).ToString();
            ExpireDate_vcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.ExpireDate_vc, TypeCode.String).ToString();
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserGroupID_intComboBox, UserEntity.UserGroupID_int, TypeCode.Int32);
            Active_bitCheckBox.Checked = (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.Active_bit, TypeCode.Boolean);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionGroupID_intComboBox, UserEntity.InfractionGroupID_int, TypeCode.Int32);
            this.Mobile_nvctextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.Mobile_nvc, TypeCode.String).ToString();
            
            if (UserEntity.CompanyID_int != null)
            {
                CompanyID_int = UserEntity.CompanyID_int;
                BLL.CompanyBLL.BLLCompany_TKeys key = new BLL.CompanyBLL.BLLCompany_TKeys();
                key.CompanyID_int = Convert.ToInt32(UserEntity.CompanyID_int);
                BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new BLL.CompanyBLL.BLLCompany_TFactory();
                var Company = CompanyFactory.GetBy(key);
                Company_nvcTextBox.Text = Company.Company_nvc;
            }
            MultiAccess_bitCheckBox.Checked = (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(UserEntity.MultiAccess_bit, TypeCode.Boolean);
        }


        protected override void Insert()
        {
            HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
            if (String.IsNullOrEmpty(UserGroupID_intComboBox.Text))
            {
                throw new ApplicationException("لطفا گروه کاربری را انتخاب نمایید");
            }
            try
            {

                HPS.BLL.UserBLL.BLLUser_T UserEntity = new HPS.BLL.UserBLL.BLLUser_T();
                UserEntity.UserName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UserName_nvcTextBox.Text, TypeCode.String).ToString();
                UserEntity.FullName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FullName_nvcTextBox.Text, TypeCode.String).ToString();
                UserEntity.Password_nvc = Hepsa.Core.Common.Security.MD5(Password_nvcTextBox.Text);
                UserEntity.ConfirmPassword_nvc = Hepsa.Core.Common.Security.MD5(ConfirmPasswordTextBox.Text);
                UserEntity.StartDate_vc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(StartDate_vcTextBox).ToString();
                UserEntity.ExpireDate_vc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ExpireDate_vcTextBox).ToString();
                UserEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                UserEntity.Active_bit = Active_bitCheckBox.Checked;
                UserEntity.CreateDate_nvc = UserFactory.ServerJalaliDate;
                UserEntity.CreateTime_nvc = UserFactory.ServerTime;
                UserEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                UserEntity.CompanyID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_int, TypeCode.Int32) == 0 ? null : (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_int, TypeCode.Int32);
                UserEntity.Mobile_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(this.Mobile_nvctextBox.Text, TypeCode.String).ToString();
                UserEntity.MultiAccess_bit = MultiAccess_bitCheckBox.Checked;
                System.IO.MemoryStream Memorystream = new System.IO.MemoryStream();
                byte[] array;
                if (PictureBox.Image != null)
                {
                    PictureBox.Image.Save(Memorystream, PictureBox.Image.RawFormat);
                    array = Memorystream.ToArray();
                    UserEntity.Picture_img = array;
                }


                UserFactory.BeginProc();
                UserFactory.Insert(UserEntity);
                UserFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.UserName_nvc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.FullName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.FullName_nvc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.Password_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.Password_nvc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.StartDate_vc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.StartDate_vc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.ExpireDate_vc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.ExpireDate_vc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.UserGroupID_int, TypeCode.Int32);
                    dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);
                    if (UserEntity.Picture_img != null)
                    {
                        dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.Picture_img.ToString()] = (byte[])Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.Picture_img, TypeCode.Object);
                    }

                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.Active_bit, TypeCode.Boolean);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.CreateDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.CreateDate_nvc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.CreateTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.CreateTime_nvc, TypeCode.String);
                    dr[HPS.BLL.UserBLL.BLLUser_T.User_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.InfractionGroupID_int, TypeCode.Int32);
                    dr["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                    dr["CompanyID_intCompany_nvc"] = Hepsa.Core.Common.PersentationController.GetEntityValue(Company_nvcTextBox.Text, TypeCode.String);
                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                UserFactory.RollBackProc();
                throw ex;
            }
        }

        HPS.BLL.UserBLL.BLLUser_T user = new HPS.BLL.UserBLL.BLLUser_T();

        protected override void Edit()
        {
            HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();

            try
            {
                HPS.BLL.UserBLL.BLLUser_T UserEntity = UserFactory.GetBy((HPS.BLL.UserBLL.BLLUser_TKeys)this.Key);
                UserEntity.UserName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UserName_nvcTextBox.Text, TypeCode.String).ToString();
                if (Password_nvcTextBox.Text == UserEntity.Password_nvc)
                {
                    UserEntity.Password_nvc = Password_nvcTextBox.Text;
                }
                else
                {
                    UserEntity.Password_nvc = Hepsa.Core.Common.Security.MD5(Password_nvcTextBox.Text);
                }
                if (ConfirmPasswordTextBox.Text == UserEntity.Password_nvc)
                {
                    UserEntity.ConfirmPassword_nvc = ConfirmPasswordTextBox.Text;
                }
                else
                {
                    UserEntity.ConfirmPassword_nvc = Hepsa.Core.Common.Security.MD5(ConfirmPasswordTextBox.Text);
                }
                UserEntity.FullName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FullName_nvcTextBox.Text, TypeCode.String).ToString();
                UserEntity.StartDate_vc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(StartDate_vcTextBox).ToString();
                UserEntity.ExpireDate_vc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ExpireDate_vcTextBox).ToString();
                UserEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                UserEntity.Active_bit = Active_bitCheckBox.Checked;
                UserEntity.CreateDate_nvc = UserFactory.ServerJalaliDate;
                UserEntity.CreateTime_nvc = UserFactory.ServerTime;
                UserEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                UserEntity.Mobile_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(this.Mobile_nvctextBox.Text, TypeCode.String).ToString();


                UserEntity.MultiAccess_bit = MultiAccess_bitCheckBox.Checked;
                UserEntity.CompanyID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyEntity.CompanyID_int, TypeCode.Int32);
                if (CompanyID_int != 0)
                {
                    UserEntity.CompanyID_int = CompanyID_int;
                }
                else
                {
                    if (UserEntity.UserGroupID_int.Value==14)
                    {
                        throw new ApplicationException("شرکت انتخاب نشده است");
                    }
                    UserEntity.CompanyID_int = null;
                }

                System.IO.MemoryStream Memorystream = new System.IO.MemoryStream();
                byte[] array;
                PictureBox.Image.Save(Memorystream, PictureBox.Image.RawFormat);
                array = Memorystream.ToArray();
                UserEntity.Picture_img = array;


                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    UserFactory.BeginProc();
                    UserFactory.Update(UserEntity, (HPS.BLL.UserBLL.BLLUser_TKeys)Key);
                    UserFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString() + "='" + ((HPS.BLL.UserBLL.BLLUser_TKeys)Key).UserName_nvc.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.UserName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.FullName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.FullName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.Password_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.Password_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.StartDate_vc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.StartDate_vc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.ExpireDate_vc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.ExpireDate_vc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.UserGroupID_int, TypeCode.Int32);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.Active_bit, TypeCode.Boolean);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.CreateDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.CreateDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.CreateTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.CreateTime_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.InfractionGroupID_int, TypeCode.Int32);
                            dr[0][HPS.BLL.UserBLL.BLLUser_T.User_TField.CompanyID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserEntity.CompanyID_int, TypeCode.Int32);


                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                UserFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();

            try
            {
                UserFactory.BeginProc();
                UserFactory.Delete((HPS.BLL.UserBLL.BLLUser_TKeys)Key);
                UserFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow[] dr = DataTable.Select(HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString() + "='" + ((HPS.BLL.UserBLL.BLLUser_TKeys)Key).UserName_nvc.ToString() + "'");
                    if (dr.Length > 0)
                    {
                        dr[0].Delete();
                    }
                    DataTable.AcceptChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                UserFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupID_intFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
                string Condition = "[UserGroup_T].[Active_bit]='true'";
                DataTable UserGroupID_intDataTable = new DataTable();
                UserGroupID_intFactory.GetAllByCondition(Condition, ref UserGroupID_intDataTable);
                this.UserGroupID_intComboBox.DisplayMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroup_nvc.ToString();
                this.UserGroupID_intComboBox.ValueMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString();
                this.UserGroupID_intComboBox.DataSource = UserGroupID_intDataTable;
                this.UserGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupID_intFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
                string InfractionGroupCondition = "[InfractionGroup_T].[Active_bit]='true'";
                DataTable InfractionGroupID_intDataTable = new DataTable();
                InfractionGroupID_intFactory.GetAllByCondition(InfractionGroupCondition, ref InfractionGroupID_intDataTable);
                this.InfractionGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.ValueMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.DataSource = InfractionGroupID_intDataTable;
                this.InfractionGroupID_intComboBox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UserGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.UserGroup.UserGroupEntityForm frm = new HPS.Present.UserGroup.UserGroupEntityForm((DataTable)UserGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void InfractionGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionGroup.InfractionGroupEntityForm frm = new HPS.Present.InfractionGroup.InfractionGroupEntityForm((DataTable)InfractionGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void PictureBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Images (*.BMP;*.JPEG;*.TIF;*.TIFF)|*.BMP;*.JPG;*.JPEG;*.TIF;*.TIFF";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PictureBox.Image = System.Drawing.Image.FromFile(openFile.FileName);
            }
        }

        private void PictureDeleteButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = HPS.Properties.Resources.user;
        }

        HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();

        Int32? CompanyID_int = 0;

        private void CompanyID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CompanySearch CompanySearch = new HPS.Present.SearchForm.CompanySearch();
            CompanySearch.ShowDialog();
            if (CompanySearch != null && CompanySearch.SelectedCompanyEntity!=null)
            {
                CompanyEntity = CompanySearch.SelectedCompanyEntity;

                Company_nvcTextBox.Text = CompanyEntity.Company_nvc;
                CompanyID_int = CompanyEntity.CompanyID_int;
            }
        }



    }
}