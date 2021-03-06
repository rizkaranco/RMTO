using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignmentCacelRequest
{
    public partial class LadeAssignmentCacelRequestEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys _LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();

        public LadeAssignmentCacelRequestEntityForm(DataTable DataTable,HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey)
            : base(DataTable)
        {
            InitializeComponent();
            _LadeAssignmentKey = LadeAssignmentKey;
        }

        public LadeAssignmentCacelRequestEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys Key, HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey)
            : base(State, DataTable,Key)
        {
            InitializeComponent();
            _LadeAssignmentKey = LadeAssignmentKey;

        }

        private void LadeAssignmentCacelRequestEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                {
                    HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory factory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
                    RequestDate_nvcTextBox.Text = factory.ServerJalaliDate;
                    RequestTime_nvcTextBox.Text = factory.ServerTime;
                    RequestDate_nvcTextBox.Enabled = true;
                    RequestTime_nvcTextBox.Enabled = true;
                    RequestUserName_nvcComboBox.Enabled = true;
                    this.FillCombo();
                    this.FillCheckListBox();
                }
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
            this.FillCheckListBox();

            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T LadeAssignmentCacelRequestEntity = LadeAssignmentCacelRequestFactory.GetBy((HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys)Key);
            if (LadeAssignmentCacelRequestEntity == null)
            {
                throw new HPS.Exceptions.LadeAssignmentCacelRequestNotFound();
            }
            AcceptedDate_nvcTextBox.Enabled = true;
            AcceptedTime_nvcTextBox.Enabled = true;
            AcceptedUserName_nvcComboBox.Enabled = true;
            AcceptedDate_nvcTextBox.Text = LadeAssignmentCacelRequestFactory.ServerJalaliDate;
            AcceptedTime_nvcTextBox.Text = LadeAssignmentCacelRequestFactory.ServerTime;

            RequestDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCacelRequestEntity.ResuestDate_nvc, TypeCode.String));
            RequestTime_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCacelRequestEntity.RequestTime_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref RequestUserName_nvcComboBox, LadeAssignmentCacelRequestEntity.RequestUserName_nvc, TypeCode.String);
            //AcceptedDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCacelRequestEntity.AcceptedDate_nvc, TypeCode.String));
            //AcceptedTime_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCacelRequestEntity.AcceptedTime_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref AcceptedUserName_nvcComboBox, LadeAssignmentCacelRequestEntity.AcceptedUserName_nvc, TypeCode.String);
            Comment_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCacelRequestEntity.Comment_nvc, TypeCode.String));

            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeCancelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
            List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> LadeCancelRequestList = LadeCancelRequestFactory.GetAllBy(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint, ((HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)_LadeAssignmentKey).LadeAssignmentID_bint);
            if (LadeCancelRequestList != null && LadeCancelRequestList.Count > 0)
            {
                for (int i = 0; i < LadeCancelCommentID_intCheckList.Items.Count; i++)
                {

                    if (LadeCancelRequestList.FindAll(lca => lca.LadeAssignmentCancelRequestID_int == ((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T)LadeCancelCommentID_intCheckList.Items[i]).LadeCanceltCommentID_int).Count > 0)
                    {
                        LadeCancelCommentID_intCheckList.SetItemChecked(i, true);
                    }
                    else
                    {
                        LadeCancelCommentID_intCheckList.SetItemChecked(i, false);
                    }
                }
            }

        }

        protected override void Insert()
        {
            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
            try
            {
                HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T LadeAssignmentCacelRequestEntity = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();
                LadeAssignmentCacelRequestEntity.ResuestDate_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(RequestDate_nvcTextBox); //GetEntityValue(ResuestDate_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.RequestTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(RequestTime_nvcTextBox); //GetEntityValue(RequestTime_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.RequestUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(RequestUserName_nvcComboBox.SelectedValue, TypeCode.String);
                LadeAssignmentCacelRequestEntity.AcceptedDate_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(AcceptedDate_nvcTextBox); //GetEntityValue(AcceptedDate_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.AcceptedTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(AcceptedTime_nvcTextBox); //GetEntityValue(AcceptedTime_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.AcceptedUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedUserName_nvcComboBox.SelectedValue, TypeCode.String);
                LadeAssignmentCacelRequestEntity.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.LadeAssignmentID_bint =(Int64)_LadeAssignmentKey.LadeAssignmentID_bint;
                LadeAssignmentCacelRequestFactory.BeginProc();
                LadeAssignmentCacelRequestFactory.Insert(LadeAssignmentCacelRequestEntity);

                HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory LadeAssignmentCancelCommentFactory = new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory();
                //////////////////////////////
                for (int i = 0; i < LadeCancelCommentID_intCheckList.CheckedItems.Count; i++)
                {
                    HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T LadeAssignmentCancelCommentEntity = new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T();
                    LadeAssignmentCancelCommentEntity.LadeAssignmentCancelRequestID_int = LadeAssignmentCacelRequestEntity.LadeAssignmentCancelRequestID_int;
                    LadeAssignmentCancelCommentEntity.LadeCancelCommentID_int = (Int32)((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T)this.LadeCancelCommentID_intCheckList.CheckedItems[i]).LadeCanceltCommentID_int;
                    LadeAssignmentCancelCommentEntity.LadeCancelComment_nvc = ((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T)this.LadeCancelCommentID_intCheckList.CheckedItems[i]).LadeCancelComment_nvc;
                    LadeAssignmentCancelCommentEntity.Date_nvc = LadeAssignmentCancelCommentFactory.ServerJalaliDate;
                    LadeAssignmentCancelCommentEntity.Time_nvc = LadeAssignmentCancelCommentFactory.ServerTime;
                    LadeAssignmentCancelCommentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                    LadeAssignmentCancelCommentFactory.Insert(LadeAssignmentCancelCommentEntity);
                }

                /////////////////////////////

                
                LadeAssignmentCacelRequestFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentCancelRequestID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.LadeAssignmentCancelRequestID_int, TypeCode.Int32);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.ResuestDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.ResuestDate_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.RequestTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.RequestTime_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.RequestUserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.RequestUserName_nvc, TypeCode.String);
                    dr["RequestUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(RequestUserName_nvcComboBox);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.AcceptedDate_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.AcceptedTime_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedUserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.AcceptedUserName_nvc, TypeCode.String);
                    dr["AcceptedUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(AcceptedUserName_nvcComboBox);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.Comment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.Comment_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.LadeAssignmentID_bint, TypeCode.Int64);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                LadeAssignmentCacelRequestFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
            try
            {
                HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T LadeAssignmentCacelRequestEntity = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();
                LadeAssignmentCacelRequestEntity.ResuestDate_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(RequestDate_nvcTextBox); //GetEntityValue(ResuestDate_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.RequestTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(RequestTime_nvcTextBox); //GetEntityValue(RequestTime_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.RequestUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(RequestUserName_nvcComboBox.SelectedValue, TypeCode.String);
                LadeAssignmentCacelRequestEntity.AcceptedDate_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(AcceptedDate_nvcTextBox);  //.GetEntityValue(AcceptedDate_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.AcceptedTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(AcceptedTime_nvcTextBox); //.GetEntityValue(AcceptedTime_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.AcceptedUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedUserName_nvcComboBox.SelectedValue, TypeCode.String);
                LadeAssignmentCacelRequestEntity.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentCacelRequestEntity.LadeAssignmentID_bint = (Int64)_LadeAssignmentKey.LadeAssignmentID_bint;
                if (LadeAssignmentCacelRequestEntity.AcceptedDate_nvc.CompareTo(LadeAssignmentCacelRequestFactory.ServerJalaliDate)<0)
                {
                    throw new ApplicationException("تاریخ قبول درخواست نمی تواند قبل از تاریخ امروز باشد");
                }
               
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    LadeAssignmentCacelRequestFactory.BeginProc();
                    LadeAssignmentCacelRequestFactory.Update(LadeAssignmentCacelRequestEntity,(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys)Key);

                    HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory LadeAssignmentCancelCommentFactory = new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TFactory();
                    //////////////////////////////
                    for (int i = 0; i < LadeCancelCommentID_intCheckList.CheckedItems.Count; i++)
                    {
                        HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T LadeAssignmentCancelCommentEntity = new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T();
                        HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T LACacelRequestEntity = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();

                        LACacelRequestEntity = LadeAssignmentCacelRequestFactory.GetBy((HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys)Key);
                        LadeAssignmentCancelCommentEntity.LadeAssignmentCancelRequestID_int = LACacelRequestEntity.LadeAssignmentCancelRequestID_int;
                        LadeAssignmentCancelCommentEntity.LadeCancelCommentID_int = (Int32)((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T)this.LadeCancelCommentID_intCheckList.CheckedItems[i]).LadeCanceltCommentID_int;
                        LadeAssignmentCancelCommentEntity.LadeCancelComment_nvc = ((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T)this.LadeCancelCommentID_intCheckList.CheckedItems[i]).LadeCancelComment_nvc;
                        LadeAssignmentCancelCommentEntity.Date_nvc = LadeAssignmentCancelCommentFactory.ServerJalaliDate;
                        LadeAssignmentCancelCommentEntity.Time_nvc = LadeAssignmentCancelCommentFactory.ServerTime;
                        LadeAssignmentCancelCommentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                        LadeAssignmentCancelCommentFactory.Insert(LadeAssignmentCancelCommentEntity);
                    }

                    /////////////////////////////


                    LadeAssignmentCacelRequestFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentCancelRequestID_int.ToString() + "='" + ((HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys)Key).LadeAssignmentCancelRequestID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.ResuestDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.ResuestDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.RequestTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.RequestTime_nvc, TypeCode.String);
                            dr[0]["RequestUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(RequestUserName_nvcComboBox);
                            dr[0][HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.AcceptedDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.AcceptedTime_nvc, TypeCode.String);
                            dr[0]["AcceptedUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(AcceptedUserName_nvcComboBox);
                            dr[0][HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.Comment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentCacelRequestEntity.Comment_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                LadeAssignmentCacelRequestFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    LadeAssignmentCacelRequestFactory.BeginProc();
                    LadeAssignmentCacelRequestFactory.Delete((HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys)Key);
                    LadeAssignmentCacelRequestFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentCancelRequestID_int.ToString() + "='" + ((HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys)Key).LadeAssignmentCancelRequestID_int.ToString() + "'");
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
                LadeAssignmentCacelRequestFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserBLL.BLLUser_TFactory RequestUserName_nvcFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable RequestUserName_nvcDataTable = new DataTable();
                RequestUserName_nvcFactory.GetAll(ref RequestUserName_nvcDataTable);
                this.RequestUserName_nvcComboBox.DisplayMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.RequestUserName_nvcComboBox.ValueMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.RequestUserName_nvcComboBox.DataSource = RequestUserName_nvcDataTable;
                this.RequestUserName_nvcComboBox.SelectedIndex = -1;

                HPS.BLL.UserBLL.BLLUser_TFactory AcceptedUserName_nvcFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable AcceptedUserName_nvcDataTable = new DataTable();
                AcceptedUserName_nvcFactory.GetAll(ref AcceptedUserName_nvcDataTable);
                this.AcceptedUserName_nvcComboBox.DisplayMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.AcceptedUserName_nvcComboBox.ValueMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.AcceptedUserName_nvcComboBox.DataSource = AcceptedUserName_nvcDataTable;
                this.AcceptedUserName_nvcComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RequestUserName_nvcNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.User.UserEntityForm frm = new HPS.Present.User.UserEntityForm((DataTable)RequestUserName_nvcComboBox.DataSource);
            frm.ShowDialog();
        }

        private void AcceptedUserName_nvcNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.User.UserEntityForm frm = new HPS.Present.User.UserEntityForm((DataTable)AcceptedUserName_nvcComboBox.DataSource);
            frm.ShowDialog();
        }

        private void FillCheckListBox()
        {
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
            try
            {
                List<HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> LadeCancelCommentList = LadeCancelCommentFactory.GetAll();

                if (LadeCancelCommentList != null && LadeCancelCommentList.Count > 0)
                {
                    foreach (HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T item in LadeCancelCommentList)
                    {
                        LadeCancelCommentID_intCheckList.Items.Add(item, false);
                    }
                }
                this.LadeCancelCommentID_intCheckList.GetType().GetProperty("DisplayMember").SetValue(this.LadeCancelCommentID_intCheckList, HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCancelComment_nvc.ToString(), null);
                this.LadeCancelCommentID_intCheckList.GetType().GetProperty("ValueMember").SetValue(this.LadeCancelCommentID_intCheckList, HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString(), null);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

    }
}