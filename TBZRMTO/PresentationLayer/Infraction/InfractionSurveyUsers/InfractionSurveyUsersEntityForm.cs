using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.InfractionSurveyUsers
{
    public partial class InfractionSurveyUsersEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public InfractionSurveyUsersEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public InfractionSurveyUsersEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void InfractionSurveyUsersEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsersFactory = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();
            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T InfractionSurveyUsersEntity = InfractionSurveyUsersFactory.GetBy((HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys)Key);
            if (InfractionSurveyUsersEntity == null)
            {
                throw new HPS.Exceptions.InfractionSurveyUsersNotFound();
            }
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserName_nvcComboBox, InfractionSurveyUsersEntity.UserName_nvc, TypeCode.String);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionSurveyGroupID_intComboBox, InfractionSurveyUsersEntity.InfractionSurveyGroupID_int, TypeCode.Int32);

        }

        protected override void Insert()
        {
            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsersFactory = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();
            try
            {
                HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T InfractionSurveyUsersEntity = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T();
                InfractionSurveyUsersEntity.UserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(UserName_nvcComboBox.SelectedValue, TypeCode.String);
                InfractionSurveyUsersEntity.InfractionSurveyGroupID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                InfractionSurveyUsersFactory.BeginProc();
                InfractionSurveyUsersFactory.Insert(InfractionSurveyUsersEntity);
                InfractionSurveyUsersFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyUsersID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionSurveyUsersEntity.InfractionSurveyUsersID_int, TypeCode.Int32);
                    dr[HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionSurveyUsersEntity.UserName_nvc, TypeCode.String);
                    dr["UserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserName_nvcComboBox);
                    dr[HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionSurveyUsersEntity.InfractionSurveyGroupID_int, TypeCode.Int32);
                    dr["InfractionSurveyGroupID_intInfractionSurveyGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionSurveyGroupID_intComboBox);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                InfractionSurveyUsersFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsersFactory = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();
            try
            {
                HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T InfractionSurveyUsersEntity = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T();
                InfractionSurveyUsersEntity.UserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(UserName_nvcComboBox.SelectedValue, TypeCode.String);
                InfractionSurveyUsersEntity.InfractionSurveyGroupID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionSurveyGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    InfractionSurveyUsersFactory.BeginProc();
                    InfractionSurveyUsersFactory.Update(InfractionSurveyUsersEntity, (HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys)Key);
                    InfractionSurveyUsersFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyUsersID_int.ToString() + "='" + ((HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys)Key).InfractionSurveyUsersID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["UserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserName_nvcComboBox);
                            dr[0]["InfractionSurveyGroupID_intInfractionSurveyGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionSurveyGroupID_intComboBox);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                InfractionSurveyUsersFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory InfractionSurveyUsersFactory = new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    InfractionSurveyUsersFactory.BeginProc();
                    InfractionSurveyUsersFactory.Delete((HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys)Key);
                    InfractionSurveyUsersFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyUsersID_int.ToString() + "='" + ((HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys)Key).InfractionSurveyUsersID_int.ToString() + "'");
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
                InfractionSurveyUsersFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserBLL.BLLUser_TFactory UserName_nvcFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable UserName_nvcDataTable = new DataTable();
                UserName_nvcFactory.GetAll(ref UserName_nvcDataTable);
                this.UserName_nvcComboBox.DisplayMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.UserName_nvcComboBox.ValueMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.UserName_nvcComboBox.DataSource = UserName_nvcDataTable;
                this.UserName_nvcComboBox.SelectedIndex = -1;

                HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory InfractionSurveyGroupID_intFactory = new HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_TFactory();
                DataTable InfractionSurveyGroupID_intDataTable = new DataTable();
                InfractionSurveyGroupID_intFactory.GetAll(ref InfractionSurveyGroupID_intDataTable);
                this.InfractionSurveyGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroup_nvc.ToString();
                this.InfractionSurveyGroupID_intComboBox.ValueMember = HPS.BLL.InfractionSurveyGroupBLL.BLLInfractionSurveyGroup_T.InfractionSurveyGroup_TField.InfractionSurveyGroupID_int.ToString();
                this.InfractionSurveyGroupID_intComboBox.DataSource = InfractionSurveyGroupID_intDataTable;
                this.InfractionSurveyGroupID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UserName_nvcNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.User.UserEntityForm frm = new HPS.Present.User.UserEntityForm((DataTable)UserName_nvcComboBox.DataSource);
            frm.ShowDialog();
        }

        private void InfractionSurveyGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionSurveyGroup.InfractionSurveyGroupEntityForm frm = new HPS.Present.InfractionSurveyGroup.InfractionSurveyGroupEntityForm((DataTable)InfractionSurveyGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }



    }
}