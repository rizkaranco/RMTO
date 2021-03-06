using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadeCancelAssignment
{
    public partial class LadeCancelAssignmentEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
       
        public LadeCancelAssignmentEntityForm(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys key)
            : base(null)
        {
            InitializeComponent();
            this.LadeAssignmentKey = key;
        }

        private void LadeCancelAssignmentEntityForm_Load(object sender, EventArgs e)
        {
            this.SaveAndNextButton.Visible = false;
            HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();

            try
            {
                //this.FillCheckListBox();
                this.FillCombo();
                List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelAssignmentList = LadeCancelAssignmentFactory.GetAllBy(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint, this.LadeAssignmentKey.LadeAssignmentID_bint);
                if (LadeCancelAssignmentList != null && LadeCancelAssignmentList.Count > 0)
                {
                    this.Count_intNumericTextBox.Text = Convert.ToString(LadeCancelAssignmentList[0].Count_int);
                    //for (int i = 0; i < LadeCancelCommentID_intCheckList.Items.Count; i++)
                    //{

                    //    if (LadeCancelAssignmentList.FindAll(lca => lca.LadeCancelCommentID_int == ((HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T)LadeCancelCommentID_intCheckList.Items[i]).LadeCanceltCommentID_int).Count > 0)
                    //    {
                    //        LadeCancelCommentID_intCheckList.SetItemChecked(i, true);
                    //    }
                    //}
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LadeCancelCommentID_intComboBox, LadeCancelAssignmentList[0].LadeCancelCommentID_int, TypeCode.Int32);
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void FillCombo()
        {
            HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory LadeCancelCommentFactory = new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TFactory();
            DataTable LadeCancelCommentID_intDataTable = new DataTable();
            LadeCancelCommentFactory.GetAll(ref LadeCancelCommentID_intDataTable);
            DataRow LadeCancelCommentdr = LadeCancelCommentID_intDataTable.NewRow();
            LadeCancelCommentdr["LadeCanceltCommentID_int"] = 0;
            DataRow[] dr = LadeCancelCommentID_intDataTable.Select("LadeCanceltCommentID_int=6");
            if (dr != null)
            {
                LadeCancelCommentID_intDataTable.Rows.Remove(dr[0]);
            }
            LadeCancelCommentID_intDataTable.Rows.InsertAt(LadeCancelCommentdr, 0);
            this.LadeCancelCommentID_intComboBox.DisplayMember = HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCancelComment_nvc.ToString();
            this.LadeCancelCommentID_intComboBox.ValueMember = HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString();
            this.LadeCancelCommentID_intComboBox.DataSource = LadeCancelCommentID_intDataTable;
            this.LadeCancelCommentID_intComboBox.SelectedIndex = -1;
        }

        protected override void Insert()
        {
            HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
            try
            {
                HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T LadeCancelAssignmentEntity = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T();

                //LadeCancelAssignmentFactory.Delete(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint, this.LadeAssignmentKey.LadeAssignmentID_bint);

                if (LadeCancelCommentID_intComboBox.SelectedIndex == 0)
                {
                    throw new ApplicationException("موردی از توضیحات انتخاب نشده است");
                }
                else
                {
                    BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                    DataTable remainedLadeAssignmentTable = new DataTable();
                    string condition = string.Format("LadeAssignmentID_bint={0}", LadeAssignmentKey.LadeAssignmentID_bint.Value);
                    LadeAssignmentFactory.SelectRemainedDetailSelectByCondition(condition, remainedLadeAssignmentTable);
                    int remaindCount_int = 0;
                    if (remainedLadeAssignmentTable!=null && remainedLadeAssignmentTable.Rows.Count>0)
                    {
                        remaindCount_int = (Int32)remainedLadeAssignmentTable.Rows[remainedLadeAssignmentTable.Rows.Count - 1]["RemainderCount_int"];
                    }
                    LadeCancelAssignmentEntity.LadeAssignmentID_bint = this.LadeAssignmentKey.LadeAssignmentID_bint.Value;
                    LadeCancelAssignmentEntity.LadeCancelCommentID_int = (Int32)LadeCancelCommentID_intComboBox.SelectedValue;
                    LadeCancelAssignmentEntity.LadeCancelComment_nvc = LadeCancelCommentID_intComboBox.Text;
                    LadeCancelAssignmentEntity.Count_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(Count_intNumericTextBox.NumericText, TypeCode.Int32);
                    if (remaindCount_int - LadeCancelAssignmentEntity.Count_int < 0)
                    {
                        throw new ApplicationException(string.Format("تعداد ماشین حذفی از تعداد مانده <{0}عدد> بیشتر است", remaindCount_int));
                    }
                    if (LadeCancelAssignmentEntity.Count_int==0)
                    {
                        throw new ApplicationException("تعداد حذفی نمیتواند برابر 0 باشد");
                    }
                    LadeCancelAssignmentEntity.Date_nvc = LadeCancelAssignmentFactory.ServerJalaliDate;
                    LadeCancelAssignmentEntity.Time_nvc = LadeCancelAssignmentFactory.ServerTime;
                    LadeCancelAssignmentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    LadeCancelAssignmentFactory.BeginProc();
                    LadeCancelAssignmentFactory.Insert(LadeCancelAssignmentEntity);
                    LadeCancelAssignmentFactory.CommitProc();
                }
            }
            catch (Exception ex)
            {
                LadeCancelAssignmentFactory.RollBackProc();
                throw ex;
            }
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
                        if (item.LadeCanceltCommentID_int != 6)
                        {
                            LadeCancelCommentID_intCheckList.Items.Add(item, false);
                        }     
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