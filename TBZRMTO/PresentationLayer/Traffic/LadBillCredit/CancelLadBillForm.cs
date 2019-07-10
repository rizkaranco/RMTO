using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present
{
    public partial class CancelLadBillForm : Hepsa.Core.PL.BaseListForm
    {
        private int LastRowIndex = -1;

        public CancelLadBillForm()
        {
            InitializeComponent();

            Group LadBillCreditGroup = new Group();
            LadBillCreditGroup.GroupName = "LadBillCreditGroup";
            LadBillCreditGroup.set_Grid(true, true, true, this.LadBillWithTrafficGridView);
            LadBillCreditGroup.ToolStrip = this.LadBillCreditToolStrip;
            LadBillCreditGroup.HasFilterControl = true;
            LadBillCreditGroup.RefreshButton = this.RefreshButton;
            this.Groups.Add(LadBillCreditGroup);

            Group LadBillCreditCancelCommentGroup = new Group();
            LadBillCreditCancelCommentGroup.GroupName = "LadBillCreditCancelCommentGroup";
            LadBillCreditCancelCommentGroup.set_Grid(true, true, true, this.LadBillCreditCancelCommentGridView);
            this.Groups.Add(LadBillCreditCancelCommentGroup);

            Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure LadebillCreditCancelRelation = new Hepsa.Core.PL.BaseListForm.GroupRelation.RelationStructure();
            LadebillCreditCancelRelation.Group1 = LadBillCreditGroup;
            LadebillCreditCancelRelation.HasGroup1ChangeEvent = true;
            LadebillCreditCancelRelation.Group1FilterColumn = LadBillCreditID_int.Name;
            LadebillCreditCancelRelation.Group1ChildDataShowType = GroupRelation.enmChildDataShowType.Filter;
            LadebillCreditCancelRelation.Group1RelationType = GroupRelation.enmRelationType.Eual;
            LadebillCreditCancelRelation.Group1BusinessFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();

            LadebillCreditCancelRelation.Group2 = LadBillCreditCancelCommentGroup;
            LadebillCreditCancelRelation.HasGroup2ChangeEvent = false;
            LadebillCreditCancelRelation.Group2FilterColumn = LadBillCreditID_int.DataPropertyName;
            LadebillCreditCancelRelation.Group2BusinessFactory = new HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TFactory();
            LadebillCreditCancelRelation.Group2ConnectionType = GroupRelation.enmConnectionType.Online;
            this.Relation.Add(ref LadebillCreditCancelRelation);
        }

        private void CancelLadBillForm_Load(object sender, EventArgs e)
        {
            LadBillCreditTextBox.Focus();
            if (HPS.Common.CurrentUser.user.UserGroupID_int != 1)
            {

                LadBillWithTrafficGridView.Columns["LadeUser"].Visible = false;
                LadBillWithTrafficGridView.Columns["CanceledUserName"].Visible = false;
                LadBillWithTrafficGridView.Columns["colUserName_nvc"].Visible = false;
            }
        }

        private void LadBillWithTrafficGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void LoadLadBillCreditGrid()
        {
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            DataTable LadeAssignmentDataTable = new DataTable();
            try
            {
                //LadBillCreditFactory.GetActives(ref LadeAssignmentDataTable);
                LadBillFactory.GetAllWithTrafficLadBillCredit(ref LadeAssignmentDataTable, LadBillFactory.ServerJalaliDate);
                this.LadBillWithTrafficGridView.DataSource = LadeAssignmentDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void CancelationButton_Click(object sender, EventArgs e)
        {
            Int64? TrafficID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillWithTrafficGridView.CurrentRow.Cells["colTrafficID_bint"].Value, TypeCode.Int64);
            DataTable OutDatatable = new DataTable();
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            try
            {
                if (LadBillWithTrafficGridView.CurrentRow != null)
                {
                    bool? Canceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillWithTrafficGridView.CurrentRow.Cells["colCanceled_bit"].Value, TypeCode.Boolean);
                    if (Canceled_bit.HasValue && Canceled_bit == true)
                    {
                        throw new ApplicationException("این مجوز باطل شده است");
                    }
                    else
                    {
                        //TrafficFactory.GetAllByCondition(string.Format("[Traffic_T].Out_bit=1 and [Traffic_T].TrafficNumber_bint={0}", LadBillWithTrafficGridView.CurrentRow.Cells["TrafficNumber_bint"].Value), ref OutDatatable);
                        //if (OutDatatable.Rows.Count == 0)
                        //{
                        //    //throw new ApplicationException("این خودرو خارج نشده است");
                        //    Hepsa.Core.Common.MessageBox.ErrorMessage("این خودرو خارج نشده است");
                        //}
                        this.LastRowIndex = LadBillWithTrafficGridView.CurrentRow.Index;
                        int? LadBillCreditID_int = (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillWithTrafficGridView.CurrentRow.Cells["LadBillCreditID_int"].Value, TypeCode.Int32);
                        if (LadBillCreditID_int.HasValue)
                        {
                            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys key = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
                            key.LadBillCreditID_int = LadBillCreditID_int.Value;
                            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LaKey = new BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                            TrafficKey.TrafficID_bint = Convert.ToInt64(this.LadBillWithTrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value);
                            LaKey.LadeAssignmentID_bint = Convert.ToInt64(this.LadBillWithTrafficGridView.CurrentRow.Cells["LadeAssignmentID_bint"].Value);
                            HPS.Present.CancelLadBillCreditComment.CancelLadBillCreditCommentForm CancelLadBillCreditCommentForm = new HPS.Present.CancelLadBillCreditComment.CancelLadBillCreditCommentForm((DataTable)this.LadBillWithTrafficGridView.DataSource, key, LaKey, TrafficKey);
                            CancelLadBillCreditCommentForm.ShowDialog();
                        }
                    }
                }
                LadBillCreditTextBox.Focus();
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
                ClearTextBoxes();
                this.LadBillWithTrafficGridView.SelectionChanged -= new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);
                this.LoadLadBillCreditGrid();
                this.LadBillWithTrafficGridView.SelectionChanged += new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AllLadeBilltoolStripButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            DataTable LadeAssignmentDataTable = new DataTable();
            try
            {
                this.LadBillWithTrafficGridView.SelectionChanged -= new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);
                LadBillFactory.GetAllWithTrafficLadBillCredit(ref LadeAssignmentDataTable, null);
                this.LadBillWithTrafficGridView.DataSource = LadeAssignmentDataTable;
                this.LadBillWithTrafficGridView.SelectionChanged += new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);

            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void LadBillWithTrafficGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            bool? Canceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadBillWithTrafficGridView.Rows[e.RowIndex].Cells[this.colCanceled_bit.Name].Value, TypeCode.Boolean);
            if (Canceled_bit.HasValue && Canceled_bit == true)
            {
                e.CellStyle.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void TrafficNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumberRule", "شماره قبض", 1, null, null, 0);
                        if (NumericValidator.Validate(TrafficNumberTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        AcceptedTurnNumberTextBox.Text = string.Empty;
                        NumberPlate_nvcTextBox.Text = string.Empty;
                        SerialPlate_nvcTextBox.Text = string.Empty;
                        LadeAssignmentIDTextBox.Text = string.Empty;
                        LadBillCreditTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        this.LadBillWithTrafficGridView.DataSource = null;
                    }

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AcceptedTurnNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("AcceptedTurnNumberRule", "شماره نوبت تأییدی", 1, null, null, 0);
                        if (NumericValidator.Validate(AcceptedTurnNumberTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        TrafficNumberTextBox.Text = string.Empty;
                        LadeAssignmentIDTextBox.Text = string.Empty;
                        LadBillCreditTextBox.Text = string.Empty;
                        NumberPlate_nvcTextBox.Text = string.Empty;
                        SerialPlate_nvcTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        this.LadBillWithTrafficGridView.DataSource = null;
                    }

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void SerialPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        AcceptedTurnNumberTextBox.Text = string.Empty;
                        TrafficNumberTextBox.Text = string.Empty;
                        LadeAssignmentIDTextBox.Text = string.Empty;
                        LadBillCreditTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        this.LadBillWithTrafficGridView.DataSource = null;
                    }

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadBillCreditTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(LadBillCreditTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("LadBillCreditIDNumberRule", "شماره مجوز", 1, null, null, 0);

                        if (NumericValidator.Validate(LadBillCreditTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        TrafficNumberTextBox.Text = string.Empty;
                        AcceptedTurnNumberTextBox.Text = string.Empty;
                        NumberPlate_nvcTextBox.Text = string.Empty;
                        SerialPlate_nvcTextBox.Text = string.Empty;
                        LadeAssignmentIDTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        this.LadBillWithTrafficGridView.DataSource = null;
                    }

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadeAssignmentIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(LadeAssignmentIDTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("LadeAssignmentIDNumberRule", "شماره بار", 1, null, null, 0);
                        if (NumericValidator.Validate(AcceptedTurnNumberTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        TrafficNumberTextBox.Text = string.Empty;
                        AcceptedTurnNumberTextBox.Text = string.Empty;
                        NumberPlate_nvcTextBox.Text = string.Empty;
                        SerialPlate_nvcTextBox.Text = string.Empty;
                        LadBillCreditTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        this.LadBillWithTrafficGridView.DataSource = null;
                    }

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void Search()
        {
            try
            {
                LadBillWithTrafficGridView.DataSource = null;

                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                DataTable LadeBillCreditDataTable = new DataTable();
                try
                {
                    string Condition = string.Empty;
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        Condition = string.Format(" Traffic_T.TrafficNumber_bint={0}", TrafficNumberTextBox.Text);
                    }
                    else if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        Condition = string.Format(" Traffic_T.AcceptedTurnNumber_bint={0}", AcceptedTurnNumberTextBox.Text);
                    }
                    else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        Condition = string.Format(" Traffic_T.NumberPlate_nvc='{0}' AND Traffic_T.SerialPlate_nvc='{1}' ", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                    }
                    else if (!string.IsNullOrEmpty(LadBillCreditTextBox.Text))
                    {
                        Condition = string.Format(" LadBillCredit_T.LadBillCreditID_int={0}", LadBillCreditTextBox.Text);
                    }
                    else if (!string.IsNullOrEmpty(LadeAssignmentIDTextBox.Text))
                    {
                        Condition = string.Format(" LadeAssignment_T.LadeAssignmentID_bint={0}", LadeAssignmentIDTextBox.Text);
                    }
                    LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(Condition, ref LadeBillCreditDataTable);
                    this.LadBillWithTrafficGridView.DataSource = LadeBillCreditDataTable;
                }
                catch (System.Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            TrafficNumberTextBox.Text = string.Empty;
            AcceptedTurnNumberTextBox.Text = string.Empty;
            NumberPlate_nvcTextBox.Text = string.Empty;
            SerialPlate_nvcTextBox.Text = string.Empty;

        }

        private void CurrentLadBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LadBillWithTrafficGridView.SelectionChanged -= new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);
                this.LoadLadBillCreditGrid();
                this.LadBillWithTrafficGridView.SelectionChanged += new System.EventHandler(this.LadBillWithTrafficGridView_SelectionChanged);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }


    }
}
