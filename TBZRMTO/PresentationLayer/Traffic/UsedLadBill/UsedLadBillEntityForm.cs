using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.UsedLadBill
{
    public partial class UsedLadBillEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys LadBillCreditKey = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
        HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys _CompanyLadBillKey = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys();
        private string _DriverName = string.Empty;
        private string _NumberPlate = string.Empty;
        DataTable _LadBillWithTrafficDataTable = new DataTable();
        public UsedLadBillEntityForm(DataTable DataTable,DataTable dt, Int32 LadBillCreditID, HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys CompanyLadBillKey,string DriverName,string NumberPlate)
            : base(DataTable)
        {
            InitializeComponent();
            this.LadBillCreditKey.LadBillCreditID_int = LadBillCreditID;
            this._CompanyLadBillKey = CompanyLadBillKey;
            this._DriverName = DriverName;
            this._NumberPlate = NumberPlate;
            this._LadBillWithTrafficDataTable = dt;
            this.SaveAndCloseButton.Visible = false;
            
        }

        public UsedLadBillEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void UsedLadBillEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                Show();
                
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void Show()
        {
            try
            {
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLaddBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T CompanyLadBillEntity = CompanyLaddBillFactory.GetBy((HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys)_CompanyLadBillKey);
                Serial_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.Serial_nvc, TypeCode.String).ToString();
                StartNumber_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyLadBillEntity.StartNumber_int, TypeCode.Int64));
                DriverName_nvcTextBox.Text = _DriverName;
                NumberPlate_nvcTextBox.Text = _NumberPlate;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        protected override void Insert()
        {
            HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory UsedLadBillFactory = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory();
            try
            {
                HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T UsedLadBillEntity = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T();
                UsedLadBillEntity.Serial_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Serial_nvcTextBox.Text, TypeCode.String).ToString();
                UsedLadBillEntity.LadBillNumber_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillNumber_intNumericTextBox.NumericText, TypeCode.Int32);
                UsedLadBillEntity.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                UsedLadBillEntity.Date_nvc = UsedLadBillFactory.ServerJalaliDate;
                UsedLadBillEntity.Time_nvc = UsedLadBillFactory.ServerTime;
                UsedLadBillEntity.UserName_nvc=HPS.Common.CurrentUser.user.UserName_nvc;
                UsedLadBillEntity.LadBillCreditID_int =(Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillCreditKey.LadBillCreditID_int,TypeCode.Int32);
                UsedLadBillEntity.CompanyLadBillID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(_CompanyLadBillKey.CompanyLadBillID_bint,TypeCode.Int64);

                ////Check if number exist
                List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> UsedLadBillList = UsedLadBillFactory.GetAllBy(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.LadBillNumber_int, UsedLadBillEntity.LadBillNumber_int);
                if (UsedLadBillList.Count>0)
                {
                    throw new ApplicationException("این شماره قبلاً اختصاص داده شده است");
                }

                string CompanyLadBilCondition = "[CompanyLadBill_T].[StartNumber_int]<=N'" + UsedLadBillEntity.LadBillNumber_int + "' and [CompanyLadBill_T].[EndNumber_int]>=N'" + UsedLadBillEntity.LadBillNumber_int + "' AND [CompanyLadBill_T].[Serial_nvc]='"+Serial_nvcTextBox.Text+"'";
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory CompanyLadBillFactory = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TFactory();
                List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> CompanyLadBillList = CompanyLadBillFactory.GetAllByCondition(CompanyLadBilCondition);
                if (CompanyLadBillList.Count==0)
                {
                    throw new ApplicationException("این شماره مابین شماره های اختصاص داده شده به شرکت نمی باشد");
                }
                UsedLadBillFactory.BeginProc();
                UsedLadBillFactory.Insert(UsedLadBillEntity);
                UsedLadBillFactory.CommitProc();

                if (this._LadBillWithTrafficDataTable != null)
                {
                    DataRow[] dr = this._LadBillWithTrafficDataTable.Select("LadBillCreditID_int=" + Convert.ToString(LadBillCreditKey.LadBillCreditID_int));
                    if (dr != null && dr.Length > 0)
                    {
                        dr[0].Delete();
                        this._LadBillWithTrafficDataTable.AcceptChanges();
                    }
                }
               
                LadBillNumber_intNumericTextBox.Text = string.Empty;
                Comment_nvcTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                UsedLadBillFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory UsedLadBillFactory = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory();
            try
            {
                HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T UsedLadBillEntity = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T();
                UsedLadBillEntity.Serial_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Serial_nvcTextBox.Text, TypeCode.String).ToString();
                UsedLadBillEntity.LadBillNumber_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillNumber_intNumericTextBox.NumericText, TypeCode.Int32);
                UsedLadBillEntity.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                UsedLadBillEntity.Date_nvc = UsedLadBillFactory.ServerJalaliDate;
                UsedLadBillEntity.Time_nvc = UsedLadBillFactory.ServerTime;
                UsedLadBillEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                UsedLadBillEntity.LadBillCreditID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillCreditKey.LadBillCreditID_int, TypeCode.Int64);
                UsedLadBillEntity.CompanyLadBillID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(_CompanyLadBillKey.CompanyLadBillID_bint, TypeCode.Int64);

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    UsedLadBillFactory.BeginProc();
                    UsedLadBillFactory.Update(UsedLadBillEntity, (HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys)Key);
                    UsedLadBillFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.UsedLadBillID_int.ToString() + "='" + ((HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys)Key).UsedLadBillID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Serial_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UsedLadBillEntity.Serial_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.LadBillNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UsedLadBillEntity.LadBillNumber_int, TypeCode.Int32);
                            dr[0][HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Comment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UsedLadBillEntity.Comment_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UsedLadBillEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UsedLadBillEntity.Time_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                UsedLadBillFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory UsedLadBillFactory = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    UsedLadBillFactory.BeginProc();
                    UsedLadBillFactory.Delete((HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys)Key);
                    UsedLadBillFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.UsedLadBillID_int.ToString() + "='" + ((HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys)Key).UsedLadBillID_int.ToString() + "'");
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
                UsedLadBillFactory.RollBackProc();
                throw ex;
            }
        }
    }
}