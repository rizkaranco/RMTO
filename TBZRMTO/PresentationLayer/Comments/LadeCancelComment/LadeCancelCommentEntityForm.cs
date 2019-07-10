using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadeCancelComment
{
    public partial class LadeCancelCommentEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public LadeCancelCommentEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public LadeCancelCommentEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void LadeCancelCommentEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T LadeCancelCommentEntity = LadeCancelCommentFactory.GetBy((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys)Key);
            if (LadeCancelCommentEntity == null)
            {
                throw new HPS.Exceptions.LadeCancelCommentNotFound();
            }
            LadeCancelComment_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeCancelCommentEntity.LadeCancelComment_nvc, TypeCode.String).ToString();
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserGroupID_intComboBox, LadeCancelCommentEntity.UserGroupID_int, TypeCode.Int32);

        }

        protected override void Insert()
        {
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
            try
            {
                HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T LadeCancelCommentEntity = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T();
                LadeCancelCommentEntity.LadeCancelComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeCancelComment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeCancelCommentEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                
                LadeCancelCommentFactory.BeginProc();
                LadeCancelCommentFactory.Insert(LadeCancelCommentEntity);
                LadeCancelCommentFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCancelCommentEntity.LadeCanceltCommentID_int, TypeCode.Int32);
                    dr[HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCancelComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCancelCommentEntity.LadeCancelComment_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCancelCommentEntity.UserGroupID_int, TypeCode.Int32);
                    dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                LadeCancelCommentFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
            try
            {
                HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T LadeCancelCommentEntity = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T();
                LadeCancelCommentEntity.LadeCancelComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeCancelComment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeCancelCommentEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    LadeCancelCommentFactory.BeginProc();
                    LadeCancelCommentFactory.Update(LadeCancelCommentEntity, (HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys)Key);
                    LadeCancelCommentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString() + "='" + ((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys)Key).LadeCanceltCommentID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCancelComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCancelCommentEntity.LadeCancelComment_nvc, TypeCode.String);
                            dr[0]["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                LadeCancelCommentFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    LadeCancelCommentFactory.BeginProc();
                    LadeCancelCommentFactory.Delete((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys)Key);
                    LadeCancelCommentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString() + "='" + ((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys)Key).LadeCanceltCommentID_int.ToString() + "'");
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
                LadeCancelCommentFactory.RollBackProc();
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