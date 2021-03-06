using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;
using System.Linq;

namespace HPS.Present.LadeAssignment
{
    public partial class LadeAssignmentListForm : Hepsa.Core.PL.BaseListForm
    {
        public LadeAssignmentListForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group LadeAssignmentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeAssignmentGroup.GroupName = "LadeAssignmentGroup";
            LadeAssignmentGroup.AddButton = this.NewButton;
            LadeAssignmentGroup.DeleteButton = this.DeleteButton;
            LadeAssignmentGroup.EditButton = this.EditButton;
            LadeAssignmentGroup.RefreshButton = this.RefreshButton;
            LadeAssignmentGroup.set_Grid(true, true, true, this.LadeAssignmentGridView);
            LadeAssignmentGroup.ToolStrip = this.LadeAssignmentToolStrip;
            LadeAssignmentGroup.HasFilterControl = true;
            this.Groups.Add(LadeAssignmentGroup);

            Hepsa.Core.PL.BaseListForm.Group LadeAssignmentCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeAssignmentCommentGroup.AddButton = null;
            LadeAssignmentCommentGroup.DeleteButton = null;
            LadeAssignmentCommentGroup.EditButton = null;
            LadeAssignmentCommentGroup.RefreshButton = null;
            LadeAssignmentCommentGroup.set_Grid(true, true, true, this.LadeAssignmentCommentGridView);
            this.Groups.Add(LadeAssignmentCommentGroup);

            Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LaderTypeGroup.AddButton = null;
            LaderTypeGroup.DeleteButton = null;
            LaderTypeGroup.EditButton = null;
            LaderTypeGroup.RefreshButton = null;
            LaderTypeGroup.set_Grid(true, true, true, this.LaderTypeGridView);
            this.Groups.Add(LaderTypeGroup);
            


            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure LadeAssignmentRelation = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            LadeAssignmentRelation.Group1 = LadeAssignmentGroup;
            LadeAssignmentRelation.HasGroup1ChangeEvent = true;
            LadeAssignmentRelation.Group1FilterColumn = colLadeAssignmentID_bint.Name;
            LadeAssignmentRelation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            LadeAssignmentRelation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            LadeAssignmentRelation.Group1BusinessFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();

            LadeAssignmentRelation.Group2 = LadeAssignmentCommentGroup;
            LadeAssignmentRelation.HasGroup2ChangeEvent = false;
            LadeAssignmentRelation.Group2FilterColumn = colLadeAssignmentID_bint.DataPropertyName;
            LadeAssignmentRelation.Group2BusinessFactory = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory();
            LadeAssignmentRelation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref LadeAssignmentRelation);


            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure LadeAssignmentRelation2 = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            LadeAssignmentRelation2.Group1 = LadeAssignmentGroup;
            LadeAssignmentRelation2.HasGroup1ChangeEvent = true;
            LadeAssignmentRelation2.Group1FilterColumn = colLadeAssignmentID_bint.Name;
            LadeAssignmentRelation2.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            LadeAssignmentRelation2.Group1RelationType = GroupRelation.enmRelationType.Eual;
            LadeAssignmentRelation2.Group1BusinessFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();

            LadeAssignmentRelation2.Group2 = LaderTypeGroup;
            LadeAssignmentRelation2.HasGroup2ChangeEvent = false;
            LadeAssignmentRelation2.Group2FilterColumn = colLadeAssignmentID_bint.DataPropertyName;
            LadeAssignmentRelation2.Group2BusinessFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
            LadeAssignmentRelation2.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref LadeAssignmentRelation2);



        }

        private void LadeAssignmentListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.FillCombo();
                this.LoadLadeAssignment();
                this.LadeAssignmentGridView.Focus();
                if (HPS.Common.CurrentUser.user.UserGroupID_int!=1)
                {
                    LadeAssignmentGridView.Columns["colUserName_nvc"].Visible = false;
                    LadeAssignmentGridView.Columns["EditUserName_nvc"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
      
        private void LoadLadeAssignment()
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LadeAssignmentDataTable = new DataTable();
                Properties.Settings Setting = new HPS.Properties.Settings();
                LadeAssignmentFactory.GetAll(ref LadeAssignmentDataTable, LadeAssignmentFactory.ServerJalaliDate,Setting.SaloonID_int);
                this.LadeAssignmentGridView.DataSource = LadeAssignmentDataTable;
                this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LadeAssignmentFactory.ServerJalaliDate);
                this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LadeAssignmentFactory.ServerJalaliDate);

            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            LadeAssignmentEntityForm LadeAssignment = new LadeAssignmentEntityForm((DataTable)this.LadeAssignmentGridView.DataSource);
            LadeAssignment.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool CanNotChangeType;

                    if (this.LadeAssignmentGridView.CurrentRow.Cells["colCarCount_int"].Value.ToString() != this.LadeAssignmentGridView.CurrentRow.Cells["colRemainedCar"].Value.ToString())
                    {
                        CanNotChangeType = false;
                    }
                    else
                    {
                        CanNotChangeType = true;
                    }

                bool CanNotChangeCount = false;
                BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells["colLadeAssignmentID_bint"].Value;
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKey);



                if (LadeAssignmentEntity.Accepted_bit == true)
                {
                    ///Select ladbillcredit
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64) + "' or (LadBillCredit_T.LadBillCreditID_int is not null and LadBillCredit_T.Canceled_bit=0 AND LadBillCredit_T.Turn_bit is not NULL) order by [LadBillCredit_T].[LadBillCreditID_int] desc";
                    List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
                    ///Select canceleced
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
                    List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelList = new List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T>();
                    LadeCancelList = LadeCancelFactory.GetAllByCondition(string.Format("LadeCancelAssignment_T.LadeAssignmentID_bint={0} order by [LadeCancelAssignment_T].[LadeCancelAssignmentID_int] desc", Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64)));
                    ///select Remained
                    DataTable remainedLadeAssignmentTable = new DataTable();
                    string RemainedCondition = string.Format("LadeAssignmentID_bint={0}", Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64));
                    LadeAssignmentFactory.SelectRemainedDetailSelectByCondition(RemainedCondition, remainedLadeAssignmentTable);
                    int remaindCount_int = 0;
                    if (remainedLadeAssignmentTable != null && remainedLadeAssignmentTable.Rows.Count > 0)
                    {
                        remaindCount_int = (Int32)remainedLadeAssignmentTable.Rows[remainedLadeAssignmentTable.Rows.Count - 1]["RemainderCount_int"];
                    }

                    if (LadeCancelList != null && LadeCancelList.Count > 0)
                    {
                        if (LadeCancelList[0].Count_int != null && remaindCount_int == 0)
                        {
                            throw new ApplicationException("این اطلاع رسانی باطل شده است  و تعداد مانده ها صفر می باشد");
                        }
                        else
                        {
                            CanNotChangeCount = true;
                        }
                    }

                    if (remaindCount_int == 0)
                    {
                        throw new ApplicationException("بار مورد نظر مجوز گرفته است");
                    }
                    else
                    {
                        CanNotChangeCount = true;


                    }


                   
                    // مدير هميشه ميتواند تعداد را تغيير دهد

                    HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
                    DataTable LadeAssignmentCacelRequestDataTable = new DataTable();
                    LadeAssignmentCacelRequestFactory.GetAllBy(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint, ref LadeAssignmentCacelRequestDataTable);

                    if (!(LadeAssignmentCacelRequestDataTable != null && LadeAssignmentCacelRequestDataTable.Rows.Count > 0 && HPS.Common.CurrentUser.user.CompanyID_int.HasValue == false))
                        throw new ApplicationException("این اطلاع رسانی بار تأیید شده است و قابل تغییر نمی باشد");

                    if (string.IsNullOrEmpty(LadeAssignmentCacelRequestDataTable.Rows[0]["AcceptedDate_nvc"].ToString()))
                    {
                        throw new ApplicationException("درخواست انصراف یا اعمال تغییرات قبول نشده است");
                    }
                }

                else
                {

                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64) + "' or (LadBillCredit_T.LadBillCreditID_int is not null and LadBillCredit_T.Canceled_bit=0 AND LadBillCredit_T.Turn_bit is not NULL) order by [LadBillCredit_T].[LadBillCreditID_int] desc";
                    List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
                    ///Select canceleced
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
                    List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelList = new List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T>();
                    LadeCancelList = LadeCancelFactory.GetAllByCondition(string.Format("LadeCancelAssignment_T.LadeAssignmentID_bint={0} order by [LadeCancelAssignment_T].[LadeCancelAssignmentID_int] desc", Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64)));
                    ///select Remained
                    DataTable remainedLadeAssignmentTable = new DataTable();
                    string RemainedCondition = string.Format("LadeAssignmentID_bint={0}", Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64));
                    LadeAssignmentFactory.SelectRemainedDetailSelectByCondition(RemainedCondition, remainedLadeAssignmentTable);
                    int remaindCount_int = 0;
                    if (remainedLadeAssignmentTable != null && remainedLadeAssignmentTable.Rows.Count > 0)
                    {
                        remaindCount_int = (Int32)remainedLadeAssignmentTable.Rows[remainedLadeAssignmentTable.Rows.Count - 1]["RemainderCount_int"];
                    }

                    if (LadeCancelList != null && LadeCancelList.Count > 0)
                    {
                        if (LadeCancelList[0].Count_int != null && remaindCount_int == 0)
                        {
                            //throw new ApplicationException("این اطلاع رسانی باطل شده است  و تعداد مانده ها صفر می باشد");
                        }
                        else
                        {
                            CanNotChangeCount = true;
                        }
                    }

                    if (remaindCount_int == 0)
                    {
                       // throw new ApplicationException("بار مورد نظر مجوز گرفته است");
                    }
                    else
                    {
                        CanNotChangeCount = true;
                    }

                    // در صورتي كه تعداد مجوز هاي 0 باشد ميتواند ويرايش صورت گيرد
                    if (this.LadeAssignmentGridView.CurrentRow.Cells["colLadBill"].Value.ToString() == "0")
                        CanNotChangeCount = false;

                    if (int.Parse(this.LadeAssignmentGridView.CurrentRow.Cells["colLadBill"].Value.ToString()) > 0)
                        CanNotChangeCount = true;
                }

                if (HPS.Common.CurrentUser.user.UserGroupID_int == 1)
                {
                    CanNotChangeCount = false;
                }
                LadeAssignmentEntityForm LadeAssignment = new LadeAssignmentEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LadeAssignmentGridView.DataSource, LadeAssignmentKey,CanNotChangeCount,CanNotChangeType);
                LadeAssignment.ShowDialog();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignment_TFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
            try
            {

                if (LadeAssignmentGridView.SelectedRows.Count > 0)
                {
                    if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
                    {
                        return;
                    }


                    LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)LadeAssignmentGridView.CurrentRow.Cells["colLadeAssignmentID_bint"].Value;
                    LadeAssignment_TFactory.Delete(LadeAssignmentKey);

                    DataRow[] dr = ((DataTable)this.LadeAssignmentGridView.DataSource).Select(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint.ToString() + "='" + LadeAssignmentKey.LadeAssignmentID_bint.ToString() + "'");
                    if (dr.Length > 0)
                    {
                        dr[0].Delete();
                    }
                    ((DataTable)this.LadeAssignmentGridView.DataSource).AcceptChanges();
                }
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadLadeAssignment();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

      
        private void LoadLadeAssignmentComment()
        {
            try
            {
                HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory LadeAssignmentCommentFactory = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory();
                DataTable LadeAssignmentCommentDataTable = new DataTable();
                LadeAssignmentCommentFactory.GetAll(ref LadeAssignmentCommentDataTable);
                this.LadeAssignmentCommentGridView.DataSource = LadeAssignmentCommentDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void LadeAssignmentCommentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LadeCancelStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells["colLadeAssignmentID_bint"].Value;
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKey);
                if (LadeAssignmentEntity.Accepted_bit == true)
                {
                    HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
                    DataTable LadeAssignmentCacelRequestDataTable = new DataTable();
                    LadeAssignmentCacelRequestFactory.GetAllBy(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint, ref LadeAssignmentCacelRequestDataTable);
                    if (!(LadeAssignmentCacelRequestDataTable != null && LadeAssignmentCacelRequestDataTable.Rows.Count > 0 && HPS.Common.CurrentUser.user.CompanyID_int.HasValue == false))
                        throw new ApplicationException("این اطلاع سرانی بار تأیید شده است و قابل تغییر نمی باشد");
                    if (string.IsNullOrEmpty(LadeAssignmentCacelRequestDataTable.Rows[0]["AcceptedDate_nvc"].ToString()))
                    {
                        throw new ApplicationException("درخواست انصراف یا اعمال تغییرات قبول نشده است");
                    }
                }

                DataTable remainedLadeAssignmentTable = new DataTable();
                string remainedCarCondition = string.Format("LadeAssignmentID_bint={0}", Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64));
                LadeAssignmentFactory.SelectRemainedDetailSelectByCondition(remainedCarCondition, remainedLadeAssignmentTable);
                int remaindCount_int = 0;
                if (remainedLadeAssignmentTable != null && remainedLadeAssignmentTable.Rows.Count > 0)
                {
                    remaindCount_int = (Int32)remainedLadeAssignmentTable.Rows[remainedLadeAssignmentTable.Rows.Count - 1]["RemainderCount_int"];
                }

                if (remaindCount_int == 0)
                {
                    string LadeCancelCondition = string.Format("LadeCancelAssignment_T.LadeAssignmentID_bint={0}", Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64));
                    List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelList = LadeCancelAssignmentFactory.GetAllByCondition(LadeCancelCondition);
                    if (LadeCancelList != null && LadeCancelList.Count > 0)
                    {
                        throw new ApplicationException("بار مورد نظر باطل شده است");
                    }
                    else
                    {
                        HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                        string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64) + "' and LadBillCredit_T.LadBillCreditID_int is not null and LadBillCredit_T.Canceled_bit=0 ";
                        List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = new List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T>();
                        LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);

                        if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                        {
                            throw new ApplicationException("بار مورد نظر مجوز گرفته است");
                        }
                    }
                }
                HPS.Present.LadeCancelAssignment.LadeCancelAssignmentEntityForm LadeCancelAssignment = new HPS.Present.LadeCancelAssignment.LadeCancelAssignmentEntityForm(LadeAssignmentKey);
                LadeCancelAssignment.ShowDialog();
                LadeAssignmentGridView_SelectionChanged(this.LadeAssignmentCommentGridView, null);
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadeAssignmentGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (this.LadeAssignmentGridView.CurrentRow == null)
                    return;
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells["colLadeAssignmentID_bint"].Value;
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64) + "' or(LadBillCredit_T.LadBillCreditID_int is not null and LadBillCredit_T.Canceled_bit=0 AND LadBillCredit_T.Turn_bit is not NULL)";
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
                int LadBillCreditCount = 0;
                int canceledLadBillCreditCount = 0;
                if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                {
                    LadBillCreditCount = LadBillCreditList.Count;
                    canceledLadBillCreditCount = LadBillCreditList.FindAll(itm => itm.Canceled_bit.Value == true).Count;
                }

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> LadeAssignmentList = LadeAssignmentFactory.GetAllBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint, (Int64)LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value);
                int CarCount = (int)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colCarCount_int.Name].Value, TypeCode.Int32);

                if (LadeAssignmentList != null && LadeAssignmentList.Count > 0)
                {
                    HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
                    DataTable LadeCancelAssignmentTable = new DataTable();
                    LadeCancelAssignmentFactory.GetAllBy(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint, ref LadeCancelAssignmentTable);
                    if (LadeCancelAssignmentTable != null && LadeCancelAssignmentTable.Rows.Count > 0)
                    {
                        Int32? Canceled = (from row in LadeCancelAssignmentTable.AsEnumerable() select (Int32)row["Count_int"]).Sum();
                        if (CarCount - LadBillCreditCount - Canceled >= 0)
                        {

                            LadeCancelStripButton.Enabled = true;
                        }
                        else
                        {

                                LadeCancelStripButton.Enabled = false;
                     
                        }

                    }
                    else
                    {
                        if (CarCount - LadBillCreditCount - canceledLadBillCreditCount !=0 )
                        {

                            LadeCancelStripButton.Enabled = true;
                        }
                        else
                        {

                                LadeCancelStripButton.Enabled = false;
                       
                        }
                    }

                }
                int remaine = 0;
                int.TryParse(LadeAssignmentGridView.CurrentRow.Cells["colRemainedCar"].Value.ToString(), out remaine);
                
                    if (remaine>0)
                    {
                        LadeCancelStripButton.Enabled = true;
                    }
                

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AllLatoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LadeAssignmentDataTable = new DataTable();
                Properties.Settings Setting=new HPS.Properties.Settings();
                LadeAssignmentFactory.GetAll(ref LadeAssignmentDataTable, null,Setting.SaloonID_int);
                this.LadeAssignmentGridView.DataSource = LadeAssignmentDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        DataTable CompanyID_intDataTable = new DataTable();

        private void FillCombo()
        {
            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DataTable LaderTypeID_intDataTable = new DataTable();
                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();

                string CompanyCondition = "[Company_T].[Active_bit]='true'";
                CompanyID_intFactory.GetAllByCondition(CompanyCondition, ref CompanyID_intDataTable);
                //DataRow Companydr = CompanyID_intDataTable.NewRow();
                //Companydr["CompanyID_int"] = 0;
                //CompanyID_intDataTable.Rows.InsertAt(Companydr, 0);
                this.CompanyID_intComboBox.DisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
                this.CompanyID_intComboBox.ValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
                this.CompanyID_intComboBox.DataSource = CompanyID_intDataTable;
                this.CompanyID_intComboBox.SelectedIndex = -1;

                HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
                DataTable GoodID_intDataTable = new DataTable();
                GoodFactory.GetAll(ref GoodID_intDataTable);
                this.GoodID_intcomboBox.DisplayMember = HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Good_nvc.ToString();
                this.GoodID_intcomboBox.ValueMember = HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString();
                this.GoodID_intcomboBox.DataSource = GoodID_intDataTable;
                this.GoodID_intcomboBox.SelectedIndex = -1;

                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                DataTable PortPlaceID_intDataTable = new DataTable();
                PortPlaceFactory.GetAll(ref PortPlaceID_intDataTable);
                this.PortPlaceID_intcomboBox.DisplayMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString();
                this.PortPlaceID_intcomboBox.ValueMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString();
                this.PortPlaceID_intcomboBox.DataSource = PortPlaceID_intDataTable;
                this.PortPlaceID_intcomboBox.SelectedIndex = -1;

                HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                DataTable DestinationCityID_intDataTable = new DataTable();
                CityFactory.GetAll(ref DestinationCityID_intDataTable);
                this.DestinationCityID_intcomboBox.DisplayMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString();
                this.DestinationCityID_intcomboBox.ValueMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString();
                this.DestinationCityID_intcomboBox.DataSource = DestinationCityID_intDataTable;
                this.DestinationCityID_intcomboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Condition = string.Empty;
                Properties.Settings Setting = new HPS.Properties.Settings();
                Int32? SaloonID_int=null;
                if (Setting.SaloonID_int!=0)
                {
                   SaloonID_int=Setting.SaloonID_int;
                }

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LadeAssignmentDataTable = new DataTable();

                if (string.IsNullOrEmpty(LadeAssingmentID_binttextBox.Text))
                {
                    if (!FromDatefaDatePicker.IsNull)
                    {
                        Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                        if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                            throw new ApplicationException(FromDateValidator.Description);
                        else
                            Condition = string.Format("Date_nvc >= '{0}'", FromDatefaDatePicker.Text);
                    }

                    if (!ToDatefaDatePicker.IsNull)
                    {
                        Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                        if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                            throw new ApplicationException(ToDateValidator.Description);
                        else
                            Condition = string.Format(" {0} And  Date_nvc <='{1}'",Condition, ToDatefaDatePicker.Text);

                    }

                    
                    if (this.CompanyID_intComboBox.SelectedIndex !=-1)
                    {
                        Condition = string.Format("{0} And CompanyID_int = {1}", Condition, CompanyID_intComboBox.SelectedValue.ToString());
                    }
                    if (this.LaderTypeID_intComboBox.SelectedIndex != -1)
                   {
                        Condition = string.Format("{0} And LaderTypeID = {1}", Condition, LaderTypeID_intComboBox.SelectedValue.ToString());
                    }

                    if (GoodID_intcomboBox.SelectedIndex != -1)
                    {
                        Condition = string.Format("{0} And GoodID_int = {1}", Condition, GoodID_intcomboBox.SelectedValue.ToString());
                    }
                    if (PortPlaceID_intcomboBox.SelectedIndex != -1)
                    {
                        Condition = string.Format("{0} And PortPlaceID_int = {1}", Condition, PortPlaceID_intcomboBox.SelectedValue.ToString());
                    }
                    if (DestinationCityID_intcomboBox.SelectedIndex != -1)
                    {
                        Condition = string.Format("{0} And CityID_int = {1} ", Condition, DestinationCityID_intcomboBox.SelectedValue.ToString());
                    }

                    if (Condition.Length > 0)
                    {
                        if (Condition.Substring(0, 4) == " And")
                        {
                            Condition = Condition.Substring(4, Condition.Length - 4);
                        }
                    }
                }
                else
                {
                    DestinationCityID_intcomboBox.SelectedIndex = -1;
                    PortPlaceID_intcomboBox.SelectedIndex=-1;
                    GoodID_intcomboBox.SelectedIndex=-1;
                    LaderTypeID_intComboBox.SelectedIndex=-1;
                    CompanyID_intComboBox.SelectedIndex=-1;
                    this.FromDatefaDatePicker.IsNull=true;
                    //.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LadeAssignmentFactory.ServerJalaliDate);
                    this.ToDatefaDatePicker.IsNull = true;
                        //SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LadeAssignmentFactory.ServerJalaliDate);
                    Condition = string.Format(" LadeAssignmentID_bint = {0} ", LadeAssingmentID_binttextBox.Text);
                }
               
                LadeAssignmentFactory.GetAllByCondition(Condition,SaloonID_int, ref LadeAssignmentDataTable);
                this.LadeAssignmentGridView.AutoGenerateColumns = false;
                this.LadeAssignmentGridView.DataSource = LadeAssignmentDataTable;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromDate_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void ToDateTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void LadeAssignmentGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
          
          
        }

      
    }
}