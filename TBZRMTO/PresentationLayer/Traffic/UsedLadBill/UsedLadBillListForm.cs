using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.UsedLadBill
{
    public partial class UsedLadBillListForm : Hepsa.Core.PL.BaseListForm
    {
        public UsedLadBillListForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group UsedCreditAssignmentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            UsedCreditAssignmentGroup.DeleteButton = this.DeleteButton;
            UsedCreditAssignmentGroup.RefreshButton = this.RefreshButton;
            UsedCreditAssignmentGroup.AddButton = this.UsedLadBillStripButton;
            UsedCreditAssignmentGroup.ToolStrip = this.UsedLadBillToolStrip;
            UsedCreditAssignmentGroup.set_Grid(true, false, true, this.LadBillWithTrafficGridView);
            UsedCreditAssignmentGroup.HasFilterControl = true;
            this.Groups.Add(UsedCreditAssignmentGroup);

            Hepsa.Core.PL.BaseListForm.Group UsedLadBillGroup = new Hepsa.Core.PL.BaseListForm.Group();
            UsedLadBillGroup.set_Grid(true, false, true, this.CompanyLadBillGridView);
            UsedLadBillGroup.ToolStrip = this.CompanyLadBillToolStrip;
            UsedLadBillGroup.HasFilterControl = true;

            this.Groups.Add(UsedLadBillGroup);       
        }

        private void UsedLadBillListForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllLadBill();
                LoadCompanyLadBill();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
  
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAllLadBill();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void UsedLadBillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.LadBillWithTrafficGridView.CurrentRow != null && CompanyLadBillGridView.CurrentRow != null)
                {

                    if (this.LadBillWithTrafficGridView.CurrentRow.Cells["LadBillCreditID_int"].Value != null && this.CompanyLadBillGridView.CurrentRow.Cells["CompanyLadBillID_bint"].Value != null)
                    {
                        HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T UsedLadBillEntity = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T();
                        UsedLadBillEntity.LadBillCreditID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadBillWithTrafficGridView.CurrentRow.Cells["LadBillCreditID_int"].Value, TypeCode.Int32);
                        HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys CompanyLadBillKey = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys();
                        CompanyLadBillKey.CompanyLadBillID_bint = (Int64)this.CompanyLadBillGridView.CurrentRow.Cells["CompanyLadBillID_bint"].Value;
                        //////////////

                        HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLaddBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
                        HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T CompanyLadBillEntity = CompanyLaddBillFactory.GetBy((HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)CompanyLadBillKey);

                        HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory UsedLadBillFactory = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory();
                        string Condition = "(CompanyLadBill_T.StartNumber_int=N'" + CompanyLadBillEntity.StartNumber_int + "') AND (UsedLadBill_T.Serial_nvc =N'" + CompanyLadBillEntity.Serial_nvc + "') ";
                        DataTable LadBillCountDataTable = new DataTable();
                        UsedLadBillFactory.GetCountByCondition(Condition, ref LadBillCountDataTable);
                        int LadBillCount = 0;
                        if (LadBillCountDataTable != null && LadBillCountDataTable.Rows.Count > 0)
                        {
                            LadBillCount = Convert.ToInt32(LadBillCountDataTable.Rows[0]["UsedLadbBillCount"].ToString());

                        }
                        int Count = (CompanyLadBillEntity.EndNumber_int - CompanyLadBillEntity.StartNumber_int);
                        if (!(Count - LadBillCount > 0))
                        {
                            throw new ApplicationException("تعداد بارنامه های داده شده به این شرکت به اتمام رسیده است");

                        }
                        else
                        {
                            UsedLadBillEntityForm UsedLadBill = new UsedLadBillEntityForm((DataTable)this.CompanyLadBillGridView.DataSource,(DataTable)LadBillWithTrafficGridView.DataSource, UsedLadBillEntity.LadBillCreditID_int, CompanyLadBillKey, Convert.ToString(this.LadBillWithTrafficGridView.CurrentRow.Cells["DriverName"].Value), Convert.ToString(this.LadBillWithTrafficGridView.CurrentRow.Cells["NumberPlate"].Value));
                            UsedLadBill.ShowDialog();
                        }


                        
                    }
                    //LoadAllLadBill();
                }
                else
                {
                    throw new ApplicationException("اطلاع رسانی بار و اختصاص بارنامه مربوط خالی است");
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshCmpanyLadBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadCompanyLadBill();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
       
        DataTable LadBillWithTrafficDataTable = new DataTable();
        private void LoadAllLadBill()
        {
            try
            {
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                LadBillWithTrafficDataTable = new DataTable();
                LadBillCreditFactory.GetActives(ref LadBillWithTrafficDataTable);
                this.LadBillWithTrafficGridView.DataSource = LadBillWithTrafficDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
       
        private void LoadCompanyLadBill()
        {
            try
            {
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
                DataTable CompanyLadBillDataTable = new DataTable();
                string Condition = string.Empty;
                if (HPS.Common.CurrentUser.user.CompanyID_int.HasValue)
                    Condition = "User_T.UserName_nvc = N'" + HPS.Common.CurrentUser.user.UserName_nvc + "'";
                CompanyLadBillFactory.GetAllWithCompanyUser(Condition,ref CompanyLadBillDataTable);
                this.CompanyLadBillGridView.DataSource = CompanyLadBillDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void LadBillWithTrafficGridView_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.LadBillGridView.CurrentRow.Cells[colLadBillCreditID_int.Name].Value != null && this.LadBillGridView.CurrentRow.Cells[UsedCreditCompanyLadBillID_bint.Name].Value != null)
            //{
            //    UsedLadBillToolStripButton.Enabled = true;
            //}
        }
    }
}