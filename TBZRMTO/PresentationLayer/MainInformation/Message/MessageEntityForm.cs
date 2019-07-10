using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Message
{
    public partial class MessageEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public MessageEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public MessageEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.MessageBLL.BLLMessage_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void MessageEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.MessageBLL.BLLMessage_TFactory MessageFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();
            HPS.BLL.MessageBLL.BLLMessage_T MessageEntity = MessageFactory.GetBy((HPS.BLL.MessageBLL.BLLMessage_TKeys)Key);
            if (MessageEntity == null)
            {
                throw new HPS.Exceptions.MessageNotFound();
            }
            MessageTitle_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageEntity.MessageTitle_nvc, TypeCode.String).ToString();
            Message_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageEntity.Message_nvc, TypeCode.String).ToString();
            StartDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageEntity.StartDate_nvc, TypeCode.String).ToString();
            EndDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageEntity.EndDate_nvc, TypeCode.String).ToString();
      //    Visited_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(MessageEntity.Visited_bit, TypeCode.Boolean);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref RecipientUserName_nvcComboBox, MessageEntity.RecipientUserName_nvc, TypeCode.String);

        }
        Hepsa.Core.Common.MyDateTime date = new Hepsa.Core.Common.MyDateTime(DateTime.Now);
        protected override void Insert()
        {
            HPS.BLL.MessageBLL.BLLMessage_TFactory MessageFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();
            try
            {
                HPS.BLL.MessageBLL.BLLMessage_T MessageEntity = new HPS.BLL.MessageBLL.BLLMessage_T();
                MessageEntity.MessageTitle_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageTitle_nvcTextBox.Text, TypeCode.String).ToString();
                MessageEntity.Message_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Message_nvcTextBox.Text, TypeCode.String).ToString();
                MessageEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                MessageEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
   ///             MessageEntity.Visited_bit = Visited_bitCheckBox.Checked;
                MessageEntity.RecipientUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(RecipientUserName_nvcComboBox.SelectedValue, TypeCode.String);
                MessageEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                MessageEntity.Date_nvc = date.ConvertToPersianShortDate();
                MessageEntity.Time_nvc = date.Time;

                MessageFactory.BeginProc();
                MessageFactory.Insert(MessageEntity);
                MessageFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.MessageID_bint, TypeCode.Int64);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageTitle_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.MessageTitle_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Message_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Message_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.StartDate_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.EndDate_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Visited_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Visited_bit, TypeCode.Boolean);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.RecipientUserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.RecipientUserName_nvc, TypeCode.String);
                    dr["RecipientUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(RecipientUserName_nvcComboBox);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Time_nvc, TypeCode.String);
                    dr[HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.UserName_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                MessageFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.MessageBLL.BLLMessage_TFactory MessageFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();
            try
            {
                HPS.BLL.MessageBLL.BLLMessage_T MessageEntity = new HPS.BLL.MessageBLL.BLLMessage_T();
                MessageEntity.MessageTitle_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageTitle_nvcTextBox.Text, TypeCode.String).ToString();
                MessageEntity.Message_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Message_nvcTextBox.Text, TypeCode.String).ToString();
                MessageEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                MessageEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
  ////              MessageEntity.Visited_bit = Visited_bitCheckBox.Checked;
                MessageEntity.RecipientUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(RecipientUserName_nvcComboBox.SelectedValue, TypeCode.String);
                MessageEntity.Date_nvc = date.MyDate.ToShortDateString() ;
                MessageEntity.Time_nvc = date.Time;
                MessageEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    MessageFactory.BeginProc();
                    MessageFactory.Update(MessageEntity, (HPS.BLL.MessageBLL.BLLMessage_TKeys)Key);
                    MessageFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageID_bint.ToString() + "='" + ((HPS.BLL.MessageBLL.BLLMessage_TKeys)Key).MessageID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageTitle_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.MessageTitle_nvc, TypeCode.String);
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Message_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Message_nvc, TypeCode.String);
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.StartDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.EndDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Visited_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Visited_bit, TypeCode.Boolean);
                            dr[0]["RecipientUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(RecipientUserName_nvcComboBox);
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(MessageEntity.Time_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.MessageBLL.BLLMessage_TFactory MessageFactory = new HPS.BLL.MessageBLL.BLLMessage_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    MessageFactory.BeginProc();
                    MessageFactory.Delete((HPS.BLL.MessageBLL.BLLMessage_TKeys)Key);
                    MessageFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageID_bint.ToString() + "='" + ((HPS.BLL.MessageBLL.BLLMessage_TKeys)Key).MessageID_bint.ToString() + "'");
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
                MessageFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserBLL.BLLUser_TFactory RecipientUserName_nvcFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable RecipientUserName_nvcDataTable = new DataTable();
                RecipientUserName_nvcFactory.GetAll(ref RecipientUserName_nvcDataTable);
                this.RecipientUserName_nvcComboBox.DisplayMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.RecipientUserName_nvcComboBox.ValueMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.RecipientUserName_nvcComboBox.DataSource = RecipientUserName_nvcDataTable;
                this.RecipientUserName_nvcComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RecipientUserName_nvcNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.User.UserEntityForm frm = new HPS.Present.User.UserEntityForm((DataTable)RecipientUserName_nvcComboBox.DataSource);
            frm.ShowDialog();
        }



    }
}