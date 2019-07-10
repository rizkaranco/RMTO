using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace  HPS.Present.TurnCancelComment
{
    public partial class TurnCancelCommentEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public TurnCancelCommentEntityForm(DataTable DataTable)
            :base(DataTable)
        {
            InitializeComponent();
        }

         public TurnCancelCommentEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State,DataTable DataTable,HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys Key )
            :base(State,DataTable,Key)
         {
            InitializeComponent();
         }

         private void TurnCancelCommentEntityForm_Load(object sender,EventArgs e)
        {
            try
            {
                if(this.State == enmFormState.Add)
                    this.FillCombo();

            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
         }

         protected override void ShowForm()
         {
            this.FillCombo();
        HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
        HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T TurnCancelCommentEntity = TurnCancelCommentFactory.GetBy((HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys)Key);
        if(TurnCancelCommentEntity ==null)
            {
               throw new HPS.Exceptions.TurnCancelCommentNotFound();
            }
        TurnCancelComment_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(TurnCancelCommentEntity.TurnCancelComment_nvc, TypeCode.String).ToString();
Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref UserGroupID_intComboBox, TurnCancelCommentEntity.UserGroupID_int, TypeCode.Int32);

         }

        protected override void Insert()
         {
        HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
            try
              {
                  HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T TurnCancelCommentEntity =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T();
                  TurnCancelCommentEntity.TurnCancelComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(TurnCancelComment_nvcTextBox.Text, TypeCode.String).ToString();
TurnCancelCommentEntity.UserGroupID_int =(Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

                  TurnCancelCommentFactory.BeginProc();
                  TurnCancelCommentFactory.Insert(TurnCancelCommentEntity);
                  TurnCancelCommentFactory.CommitProc();
                 if(DataTable !=null)
                    {
                       DataRow dr= this.DataTable.NewRow();
                       dr[HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelCommentID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnCancelCommentEntity.TurnCancelCommentID_int, TypeCode.Int32);
dr[HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnCancelCommentEntity.TurnCancelComment_nvc, TypeCode.String);
dr[HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnCancelCommentEntity.UserGroupID_int, TypeCode.Int32);
dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                       DataTable.Rows.Add(dr);
                       DataTable.AcceptChanges();
                    }
                     this.ClearForm(this);
              }
            catch(Exception ex)
              {
                 TurnCancelCommentFactory.RollBackProc();
                 throw ex;
              }
         }

        protected override void Edit()
        {
            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
            try
              {
                  HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T TurnCancelCommentEntity =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T();
                  TurnCancelCommentEntity.TurnCancelComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(TurnCancelComment_nvcTextBox.Text, TypeCode.String).ToString();
TurnCancelCommentEntity.UserGroupID_int =(Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupID_intComboBox.SelectedValue, TypeCode.Int32);

               if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                 {
                  TurnCancelCommentFactory.BeginProc();
                  TurnCancelCommentFactory.Update(TurnCancelCommentEntity,(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys)Key);
                  TurnCancelCommentFactory.CommitProc();
                if(DataTable!=null)
                  {
                      DataRow[] dr= DataTable.Select(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelCommentID_int.ToString() + "='" +((HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys)Key).TurnCancelCommentID_int.ToString()+ "'");
                     if(dr.Length > 0)
                     {
                        dr[0][HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnCancelCommentEntity.TurnCancelComment_nvc, TypeCode.String);
dr[0]["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                     }
                    DataTable.AcceptChanges();
                  }
                }
              }
            catch(Exception ex)
              {
                   TurnCancelCommentFactory.RollBackProc();
                   throw ex;
              }

         }

        protected override void Delete()
        {
                HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();

            try
             {
                  if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                    {
                    TurnCancelCommentFactory.BeginProc();
                    TurnCancelCommentFactory.Delete((HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys)Key);
                    TurnCancelCommentFactory.CommitProc();
                if(DataTable!=null)
                  {
                        DataRow[] dr= DataTable.Select(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelCommentID_int.ToString() + "='" + ((HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys)Key).TurnCancelCommentID_int.ToString()+"'");
                    if(dr.Length > 0)
                      {
                        dr[0].Delete();
                      }
                    DataTable.AcceptChanges();
                  }
                this.Close();
               }
             }
            catch(Exception ex)
             {
                  TurnCancelCommentFactory.RollBackProc();
                throw ex;
             }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupID_intFactory =new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
DataTable UserGroupID_intDataTable=new  DataTable();
UserGroupID_intFactory.GetAll(ref UserGroupID_intDataTable);
this.UserGroupID_intComboBox.DisplayMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroup_nvc.ToString();
this.UserGroupID_intComboBox.ValueMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString();
this.UserGroupID_intComboBox.DataSource = UserGroupID_intDataTable;
this.UserGroupID_intComboBox.SelectedIndex = -1;


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    private void UserGroupID_intNewButton_Click(object sender, EventArgs e) 
{
    HPS.Present.UserGroup.UserGroupEntityForm frm =new HPS.Present.UserGroup.UserGroupEntityForm((DataTable)UserGroupID_intComboBox.DataSource);
    frm.ShowDialog();
}



    }
}