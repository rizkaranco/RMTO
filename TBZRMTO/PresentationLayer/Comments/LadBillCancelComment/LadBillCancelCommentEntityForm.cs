using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadBillCancelComment
{
    public partial class LadBillCancelCommentEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public LadBillCancelCommentEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public LadBillCancelCommentEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void LadBillCancelCommentEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T LadBillCancelCommentEntity = LadBillCancelCommentFactory.GetBy((HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys)Key);
            if (LadBillCancelCommentEntity == null)
            {
                throw new HPS.Exceptions.LadBillCancelCommentNotFound();
            }
            LadbillCancelComment_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillCancelCommentEntity.LadbillCancelComment_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserGroupID_intComboBox, LadBillCancelCommentEntity.UserGroupID_int, TypeCode.Int32);

        }

        protected override void Insert()
        {
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();
            try
            {
                HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T LadBillCancelCommentEntity = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T();
                LadBillCancelCommentEntity.LadbillCancelComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadbillCancelComment_nvcTextBox.Text, TypeCode.String).ToString();
                LadBillCancelCommentEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                LadBillCancelCommentFactory.BeginProc();
                LadBillCancelCommentFactory.Insert(LadBillCancelCommentEntity);
                LadBillCancelCommentFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadBillCancelCommentID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadBillCancelCommentEntity.LadBillCancelCommentID_int, TypeCode.Int32);
                    dr[HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadbillCancelComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadBillCancelCommentEntity.LadbillCancelComment_nvc, TypeCode.String);
                    dr[HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadBillCancelCommentEntity.UserGroupID_int, TypeCode.Int32);
                    dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                LadBillCancelCommentFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();
            try
            {
                HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T LadBillCancelCommentEntity = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T();
                LadBillCancelCommentEntity.LadbillCancelComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadbillCancelComment_nvcTextBox.Text, TypeCode.String).ToString();
                LadBillCancelCommentEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    LadBillCancelCommentFactory.BeginProc();
                    LadBillCancelCommentFactory.Update(LadBillCancelCommentEntity, (HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys)Key);
                    LadBillCancelCommentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadBillCancelCommentID_int.ToString() + "='" + ((HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys)Key).LadBillCancelCommentID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadbillCancelComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadBillCancelCommentEntity.LadbillCancelComment_nvc, TypeCode.String);
                            dr[0]["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                LadBillCancelCommentFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory LadBillCancelCommentFactory = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    LadBillCancelCommentFactory.BeginProc();
                    LadBillCancelCommentFactory.Delete((HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys)Key);
                    LadBillCancelCommentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadBillCancelCommentID_int.ToString() + "='" + ((HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys)Key).LadBillCancelCommentID_int.ToString() + "'");
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
                LadBillCancelCommentFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupID_intFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
                DataTable UserGroupID_intDataTable = new DataTable();
                UserGroupID_intFactory.GetAll(ref UserGroupID_intDataTable);
                this.UserGroupID_intComboBox.DisplayMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroup_nvc.ToString();
                this.UserGroupID_intComboBox.ValueMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString();
                this.UserGroupID_intComboBox.DataSource = UserGroupID_intDataTable;
                this.UserGroupID_intComboBox.SelectedIndex = -1;


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



    }
}