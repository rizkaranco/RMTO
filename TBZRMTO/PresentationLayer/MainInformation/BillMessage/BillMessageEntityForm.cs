using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.BillMessage
{
    public partial class BillMessageEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public BillMessageEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public BillMessageEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void BillMessageEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            HPS.BLL.BillMessageBLL.BLLBillMessage_T BillMessageEntity = BillMessageFactory.GetBy((HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys)Key);
            if (BillMessageEntity == null)
            {
                throw new HPS.Exceptions.BillMessageNotFound();
            }
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref BillID_intComboBox, BillMessageEntity.BillID_int, TypeCode.Int32);
            Message_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageEntity.Message_nvc, TypeCode.String).ToString();
            StartDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageEntity.StartDate_nvc, TypeCode.String).ToString();
            EndDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageEntity.EndDate_nvc, TypeCode.String).ToString();
            ShowInSaloncheckBox.Checked = BillMessageEntity.ShowInLadeAssignmentRepetation_bit.Value;
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref SaloonID_intComboBox, BillMessageEntity.SaloonID_int, TypeCode.Int32);

            

        }

        protected override void Insert()
        {
            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            try
            {
                HPS.BLL.BillMessageBLL.BLLBillMessage_T BillMessageEntity = new HPS.BLL.BillMessageBLL.BLLBillMessage_T();
                BillMessageEntity.BillID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(BillID_intComboBox.SelectedValue, TypeCode.Int32);
                BillMessageEntity.Message_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Message_nvcTextBox.Text, TypeCode.String).ToString();
                BillMessageEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                BillMessageEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
                BillMessageEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                BillMessageEntity.ShowInLadeAssignmentRepetation_bit = ShowInSaloncheckBox.Checked;
                BillMessageEntity.SaloonID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonID_intComboBox.SelectedValue, TypeCode.Int32);
               
                if (ShowInSaloncheckBox.Checked)
                {
                    BillMessageEntity.BillID_int = null;
                    BillID_intComboBox.SelectedIndex = -1;
                }

                if (BillMessageEntity.EndDate_nvc.CompareTo(BillMessageEntity.StartDate_nvc) < 0)
                {
                    throw new ApplicationException(HPS.Exceptions.ExceptionCs.EndDateMoreThanStartDate);
                }

                if (string.Compare(StartDate_nvcTextBox.Text, BillMessageFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ شروع نمی تواند کوچکتر از تاریخ جاری باشد");
                }
                if (EndDate_nvcTextBox.Text.CompareTo(BillMessageFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ اتمام نمی تواند کوچکتر از تاریخ جاری باشد");
                }
                

                if (BillID_intComboBox.SelectedIndex != -1)
                {
                    string Condition = string.Format("BillMessage_T.Message_nvc=N'{0}' AND BillMessage_T.BillID_int='{1}'", BillMessageEntity.Message_nvc, BillMessageEntity.BillID_int);
                    List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillmessageList = BillMessageFactory.GetAllByCondition(Condition);
                    if (BillmessageList != null && BillmessageList.Count > 0)
                    {
                        foreach (HPS.BLL.BillMessageBLL.BLLBillMessage_T item in BillmessageList)
                        {
                            if (!(StartDate_nvcTextBox.Text.CompareTo(item.EndDate_nvc) > 0 || EndDate_nvcTextBox.Text.CompareTo(item.StartDate_nvc) < 0))
                            {
                                throw new ApplicationException("براي تاريخ وارد شده پیام تعريف شده است");
                            }
                        }

                    }
                }
               
                BillMessageFactory.BeginProc();
                BillMessageFactory.Insert(BillMessageEntity);
                BillMessageFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillMessageID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.BillMessageID_int, TypeCode.Int32);
                    dr[HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.BillID_int, TypeCode.Int32);
                    dr["BillID_intBillType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(BillID_intComboBox);
                    dr[HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.Message_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.Message_nvc, TypeCode.String);
                    dr[HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.StartDate_nvc, TypeCode.String);
                    dr[HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.EndDate_nvc, TypeCode.String);
                    dr[HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.UserName_nvc, TypeCode.String);
                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                BillMessageFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            try
            {

                HPS.BLL.BillMessageBLL.BLLBillMessage_T BillMessageEntity = new HPS.BLL.BillMessageBLL.BLLBillMessage_T();
                BillMessageEntity.BillID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(BillID_intComboBox.SelectedValue, TypeCode.Int32);
                BillMessageEntity.Message_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Message_nvcTextBox.Text, TypeCode.String).ToString();


                if (ShowInSaloncheckBox.Checked)
                {
                    BillMessageEntity.BillID_int = null;
                    BillID_intComboBox.SelectedIndex = -1;
                }

                if (BillID_intComboBox.SelectedIndex != -1)
                {
                    string Condition = string.Format("BillMessage_T.Message_nvc=N'{0}' AND BillMessage_T.BillID_int='{1}' And BillMessage_T.BillMessageID_int<>{2}", BillMessageEntity.Message_nvc, BillMessageEntity.BillID_int, ((HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys)Key).BillMessageID_int.ToString());
                    List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(Condition);
                    if (BillMessageList != null && BillMessageList.Count > 0)
                    {
                        foreach (HPS.BLL.BillMessageBLL.BLLBillMessage_T item in BillMessageList)
                        {
                            if (!(StartDate_nvcTextBox.Text.CompareTo(item.EndDate_nvc) > 0 || EndDate_nvcTextBox.Text.CompareTo(item.StartDate_nvc) < 0))
                            {
                                throw new ApplicationException("براي تاريخ وارد شده پیام تعريف شده است");
                            }
                        }
                    }
                }
                BillMessageEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                BillMessageEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
                BillMessageEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                BillMessageEntity.ShowInLadeAssignmentRepetation_bit = ShowInSaloncheckBox.Checked;
                BillMessageEntity.SaloonID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonID_intComboBox.SelectedValue, TypeCode.Int32);

                if (EndDate_nvcTextBox.Text.CompareTo(BillMessageFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException("تاریخ اتمام نمی تواند کوچکتر از تاریخ جاری باشد");
                }

                if (BillMessageEntity.EndDate_nvc.CompareTo(BillMessageEntity.StartDate_nvc) < 0)
                {
                    throw new ApplicationException(HPS.Exceptions.ExceptionCs.EndDateMoreThanStartDate);
                }

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    BillMessageFactory.BeginProc();
                    BillMessageFactory.Update(BillMessageEntity, (HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys)Key);
                    BillMessageFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillMessageID_int.ToString() + "='" + ((HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys)Key).BillMessageID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["BillID_intBillType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(BillID_intComboBox);
                            dr[0][HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.Message_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.Message_nvc, TypeCode.String);
                            dr[0][HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.StartDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.EndDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(BillMessageEntity.UserName_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                BillMessageFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    BillMessageFactory.BeginProc();
                    BillMessageFactory.Delete((HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys)Key);
                    BillMessageFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillMessageID_int.ToString() + "='" + ((HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys)Key).BillMessageID_int.ToString() + "'");
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
                BillMessageFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.BillBLL.BLLBill_TFactory BillID_intFactory = new HPS.BLL.BillBLL.BLLBill_TFactory();
                DataTable BillID_intDataTable = new DataTable();
                BillID_intFactory.GetAll(ref BillID_intDataTable);
                this.BillID_intComboBox.DisplayMember = HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillType_nvc.ToString();
                this.BillID_intComboBox.ValueMember = HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillID_int.ToString();
                this.BillID_intComboBox.DataSource = BillID_intDataTable;
                this.BillID_intComboBox.SelectedIndex = -1;

                HPS.BLL.SaloonBLL.BLLSaloon_TFactory Saloon_TFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
                DataTable Saloon_TDataTable = new DataTable();
                Saloon_TFactory.GetAll(ref Saloon_TDataTable);
                this.SaloonID_intComboBox.DisplayMember = HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.Saloon_nvc.ToString();
                this.SaloonID_intComboBox.ValueMember = HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString();
                this.SaloonID_intComboBox.DataSource = Saloon_TDataTable;
                this.SaloonID_intComboBox.SelectedIndex = -1;
         
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BillID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Bill.BillEntityForm frm = new HPS.Present.Bill.BillEntityForm((DataTable)BillID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void StartDate_nvcTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ShowInSaloncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowInSaloncheckBox.Checked)
            {
                SaloonID_intComboBox.Visible = true;
                LaderPivotGroupID_intLabel.Visible = true;
                BillID_intComboBox.Enabled = false;
                //BillID_intComboBox.SelectedIndex = -1;
            }
            else
            {
                SaloonID_intComboBox.Visible = false;
                LaderPivotGroupID_intLabel.Visible = false;
                BillID_intComboBox.Enabled = true;
            }
        }



    }
}