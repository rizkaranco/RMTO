using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadeComment
{
    public partial class LadeCommentEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public LadeCommentEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public LadeCommentEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void LadeCommentEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
            HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = LadeCommentFactory.GetBy((HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys)Key);
            if (LadeCommentEntity == null)
            {
                throw new HPS.Exceptions.LadeCommentNotFound();
            }
            LadeComment_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeCommentEntity.LadeComment_nvc, TypeCode.String).ToString();
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserGroupID_intComboBox, LadeCommentEntity.UserGroupID_int, TypeCode.Int32);

        }

        protected override void Insert()
        {
            HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
            try
            {
                HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
                LadeCommentEntity.LadeComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeComment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeCommentEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                LadeCommentFactory.BeginProc();
                LadeCommentFactory.Insert(LadeCommentEntity);
                LadeCommentFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCommentEntity.LadeCommentID_int, TypeCode.Int32);
                    dr[HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCommentEntity.LadeComment_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCommentEntity.UserGroupID_int, TypeCode.Int32);
                    dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                LadeCommentFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
            try
            {
                HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
                LadeCommentEntity.LadeComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeComment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeCommentEntity.UserGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    LadeCommentFactory.BeginProc();
                    LadeCommentFactory.Update(LadeCommentEntity, (HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys)Key);
                    LadeCommentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString() + "='" + ((HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys)Key).LadeCommentID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeCommentEntity.LadeComment_nvc, TypeCode.String);
                            dr[0]["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                LadeCommentFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    LadeCommentFactory.BeginProc();
                    LadeCommentFactory.Delete((HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys)Key);
                    LadeCommentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString() + "='" + ((HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys)Key).LadeCommentID_int.ToString() + "'");
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
                LadeCommentFactory.RollBackProc();
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