using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.TurnManagement
{
    public partial class TurnManagementEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        Int32 _TurnStatus = 0;
        Int32? _LadBillCreditID_int;
        private HPS.BLL.TrafficBLL.BLLTraffic_TKeys _TrafficKey;

        public TurnManagementEntityForm(DataTable DataTable, Int32 TurnStatus)
            : base(DataTable)
        {
            InitializeComponent();
            this.State = enmFormState.Edit;
            this._TurnStatus = TurnStatus;
            LoadForm();
        }

        public TurnManagementEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.TrafficBLL.BLLTraffic_TKeys Key, Int32 TurnStatus, Int32? LadBillCreditID_int)
            : base(State, DataTable, null)
        {
            InitializeComponent();
            this._TurnStatus = TurnStatus;
            this._TrafficKey = Key;
            _LadBillCreditID_int = LadBillCreditID_int;
            LoadForm();
        }

        private void TurnManagementEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.FillCombo();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void Edit()
        {
            HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
            try
            {
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_T TurnManagementEntity = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
                TurnManagementEntity.TrafficID_bint = this._TrafficKey.TrafficID_bint;
                if (_TurnStatus == 1)
                {
                    if (TurnManagementEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DuplicateTurnNumberInUpdateRule") == false)
                    {
                        Hepsa.Core.Validation.InvalidBusinessObjectException exception = new Hepsa.Core.Validation.InvalidBusinessObjectException(TurnManagementEntity.BrokenRulesList().ToString());
                        throw new ApplicationException(exception.Message);
                    }
                }
                //if (_LadBillCreditID_int!=null&&_LadBillCreditID_int != 0)
                //{
                //    var LadBillFactory = new BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                //    var LadBillEntity = new BLL.LadBillCreditBLL.BLLLadBillCredit_T();
                //    var LadBillKey = new BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
                //    LadBillKey.LadBillCreditID_int=_LadBillCreditID_int.Value;
                //    LadBillEntity = LadBillFactory.GetBy(LadBillKey);
                //    if (LadBillEntity != null )
                //    {
                //        LadBillEntity.Turn_bit = true;
                //        LadBillFactory.Update(LadBillEntity, LadBillKey);
                //    }
                //    else
                //        throw new ApplicationException("مجوز مورد نظر یافت نشد");
                //}
                //else 
                if (_LadBillCreditID_int == 0)
                {
                    TurnManagementEntity.TurnCancelCommantID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnCancelCommantID_intComboBox.SelectedValue, TypeCode.Int32);
                    TurnManagementEntity.TurnCancelCommment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(TurnCancelCommantID_intComboBox.Text, TypeCode.String).ToString();
                    TurnManagementEntity.Return_bit = Return_bitCheckBox.Checked;
                    TurnManagementEntity.Date_nvc = TurnManagementFactory.ServerJalaliDate;
                    TurnManagementEntity.Time_nvc = TurnManagementFactory.ServerTime;
                    TurnManagementEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    TurnManagementEntity.TrafficID_bint = this._TrafficKey.TrafficID_bint;
                    if (TurnManagementEntity.TurnCancelCommantID_int.HasValue && TurnManagementEntity.Return_bit == true)
                    {
                        throw new ApplicationException("امکان ابطال نوبت و احیا همزمان وجود ندارد");
                    }
                    if (TurnManagementEntity.TurnCancelCommantID_int.HasValue == false && TurnManagementEntity.Return_bit == false)
                    {
                        throw new ApplicationException("هیچ موردی انتخاب نشده است");
                    }
                    TurnManagementFactory.BeginProc();
                    TurnManagementFactory.Insert(TurnManagementEntity);
                    TurnManagementFactory.CommitProc();


                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TrafficID_bint.ToString() + "='" + this._TrafficKey.TrafficID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnManagementID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.TurnManagementID_int, TypeCode.Int32);
                            dr[0]["TrafficID_bint"] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.TrafficID_bint, TypeCode.Int64);
                            dr[0][HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnCancelCommantID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.TurnCancelCommantID_int, TypeCode.Int32);
                            dr[0]["TurnCancelCommantID_intTurnCancelCommant_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(TurnCancelCommantID_intComboBox);
                            dr[0][HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Return_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.Return_bit, TypeCode.Boolean);
                            dr[0][HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.Time_nvc, TypeCode.String);
                            dr[0]["TMUser"] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TurnManagementEntity.UserName_nvc, TypeCode.String);
                        }

                        DataTable.AcceptChanges();
                    }
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                TurnManagementFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Delete()
        {
            HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    TurnManagementFactory.BeginProc();
                    TurnManagementFactory.Delete((HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys)Key);
                    TurnManagementFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnManagementID_int.ToString() + "='" + ((HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys)Key).TurnManagementID_int.ToString() + "'");
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
                TurnManagementFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommantID_intFactory = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
                DataTable TurnCancelCommantID_intDataTable = new DataTable();
                TurnCancelCommantID_intFactory.GetAll(ref TurnCancelCommantID_intDataTable);
                this.TurnCancelCommantID_intComboBox.DisplayMember = HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelComment_nvc.ToString();
                DataRow[] rows;

                if (HPS.Common.CurrentUser.user.UserGroupID_int != 16)
                {
                    rows = TurnCancelCommantID_intDataTable.Select(" TurnCancelCommentID_int=57");
                    foreach (DataRow row in rows)
                        TurnCancelCommantID_intDataTable.Rows.Remove(row);
                }
                this.TurnCancelCommantID_intComboBox.ValueMember = HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelCommentID_int.ToString();
                this.TurnCancelCommantID_intComboBox.DataSource = TurnCancelCommantID_intDataTable;
                this.TurnCancelCommantID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TurnCancelCommantID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnCancelComment.TurnCancelCommentEntityForm frm = new HPS.Present.TurnCancelComment.TurnCancelCommentEntityForm((DataTable)TurnCancelCommantID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void LoadForm()
        {
            if (_TurnStatus == 1)//return
            {
                TurnCancelCommantID_intComboBox.Visible = false;
                TurnCancelCommantID_intNewButton.Visible = false;
                TurnCancelCommantID_intLabel.Visible = false;
                Return_bitCheckBox.Visible = true;
                this.Return_bitCheckBox.Location = new System.Drawing.Point(360, 35);
                this.Text = "احیای نوبت";
            }
            else
            {
                TurnCancelCommantID_intComboBox.Visible = true;
                TurnCancelCommantID_intNewButton.Visible = true;
                TurnCancelCommantID_intLabel.Visible = true;
                Return_bitCheckBox.Visible = false;
                this.Text = "ابطال نوبت";
            }
        }

    }
}