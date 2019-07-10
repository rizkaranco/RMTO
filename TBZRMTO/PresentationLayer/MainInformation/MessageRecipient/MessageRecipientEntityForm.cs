using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.MessageRecipient
{
    public partial class MessageRecipientEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public MessageRecipientEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public MessageRecipientEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void MessageRecipientEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipientFactory = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();
            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T MessageRecipientEntity = MessageRecipientFactory.GetBy((HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys)Key);
            if (MessageRecipientEntity == null)
            {
                throw new HPS.Exceptions.MessageRecipientNotFound();
            }
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref MessageID_bintComboBox, MessageRecipientEntity.MessageID_bint, TypeCode.Int64);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserGroupID_intComboBox, MessageRecipientEntity.UserGroupID_int, TypeCode.Int32);
            MessageRecipientEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
        }

        protected override void Insert()
        {
            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipientFactory = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();

            try
            {
                HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T MessageRecipientEntity = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T();
                MessageRecipientEntity.MessageID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(MessageID_bintComboBox.SelectedValue, TypeCode.Int64);
                MessageRecipientEntity.UserGroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                MessageRecipientEntity.Date_nvc = MessageRecipientFactory.ServerJalaliDate;
                MessageRecipientEntity.Time_nvc = MessageRecipientFactory.ServerTime;

                MessageRecipientFactory.BeginProc();
                MessageRecipientFactory.Insert(MessageRecipientEntity);
                MessageRecipientFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageRecipientID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.MessageRecipientID_int, TypeCode.Int32);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.MessageID_bint, TypeCode.Int64);
                    dr["MessageID_bintMessageTitle_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(MessageID_bintComboBox);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.UserGroupID_int, TypeCode.Int32);
                    dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.StartDate_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.EndDate_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.Time_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.UserName_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                MessageRecipientFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipientFactory = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();
            try
            {
                HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T MessageRecipientEntity = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T();
                MessageRecipientEntity.MessageID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(MessageID_bintComboBox.SelectedValue, TypeCode.Int64);
                MessageRecipientEntity.UserGroupID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                MessageRecipientEntity.Date_nvc = MessageRecipientFactory.ServerJalaliDate;
                MessageRecipientEntity.Time_nvc = MessageRecipientFactory.ServerTime;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    MessageRecipientFactory.BeginProc();
                    MessageRecipientFactory.Update(MessageRecipientEntity, (HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys)Key);
                    MessageRecipientFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageRecipientID_int.ToString() + "='" + ((HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys)Key).MessageRecipientID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["MessageID_bintMessageTitle_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(MessageID_bintComboBox);
                            dr[0]["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);
                            dr[0][HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageRecipientEntity.Time_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageRecipientFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory MessageRecipientFactory = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    MessageRecipientFactory.BeginProc();
                    MessageRecipientFactory.Delete((HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys)Key);
                    MessageRecipientFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageRecipientID_int.ToString() + "='" + ((HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys)Key).MessageRecipientID_int.ToString() + "'");
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
                MessageRecipientFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.MessageBLL.BLLMessage_TFactory MessageID_bintFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();
                DataTable MessageID_bintDataTable = new DataTable();
                MessageID_bintFactory.GetAll(ref MessageID_bintDataTable);
                this.MessageID_bintComboBox.DisplayMember = HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageTitle_nvc.ToString();
                this.MessageID_bintComboBox.ValueMember = HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageID_bint.ToString();
                this.MessageID_bintComboBox.DataSource = MessageID_bintDataTable;
                this.MessageID_bintComboBox.SelectedIndex = -1;

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

        private void MessageID_bintNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Message.MessageEntityForm frm = new HPS.Present.Message.MessageEntityForm((DataTable)MessageID_bintComboBox.DataSource);
            frm.ShowDialog();
        }

        private void UserGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.UserGroup.UserGroupEntityForm frm = new HPS.Present.UserGroup.UserGroupEntityForm((DataTable)UserGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }
    }
}