using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.News
{
    public partial class NewsEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public NewsEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public NewsEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.NewsBLL.BLLNews_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void NewsEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
            HPS.BLL.NewsBLL.BLLNews_T NewsEntity = NewsFactory.GetBy((HPS.BLL.NewsBLL.BLLNews_TKeys)Key);
            if (NewsEntity == null)
            {
                throw new HPS.Exceptions.NewsNotFound();
            }
            Title_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(NewsEntity.Title_nvc, TypeCode.String).ToString();
            News_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(NewsEntity.News_nvc, TypeCode.String).ToString();
            StartDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(NewsEntity.StartDate_nvc, TypeCode.String).ToString();
            EndDate_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(NewsEntity.EndDate_nvc, TypeCode.String).ToString();

        }

        protected override void Insert()
        {
            HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
            try
            {
                HPS.BLL.NewsBLL.BLLNews_T NewsEntity = new HPS.BLL.NewsBLL.BLLNews_T();
                NewsEntity.Title_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Title_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.News_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(News_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.Date_nvc = NewsFactory.ServerJalaliDate;
                NewsEntity.Time_nvc = NewsFactory.ServerTime;
                NewsEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                if (NewsFactory.ServerJalaliDate.CompareTo(StartDate_nvcTextBox.Text)>0)
                {
                    throw new ApplicationException("از تاریخ نباید کوچکتر از <" + NewsFactory.ServerJalaliDate + "> باشد");

                }
                if (EndDate_nvcTextBox.Text.CompareTo(StartDate_nvcTextBox.Text)<0)
                {
                    throw new ApplicationException(HPS.Exceptions.ExceptionCs.EndDateMoreThanStartDate);
                }
                NewsFactory.BeginProc();
                NewsFactory.Insert(NewsEntity);
                NewsFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.NewsID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.NewsID_bint, TypeCode.Int64);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.Title_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.Title_nvc, TypeCode.String);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.News_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.News_nvc, TypeCode.String);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.StartDate_nvc, TypeCode.String);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.EndDate_nvc, TypeCode.String);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.Time_nvc, TypeCode.String);
                    dr[HPS.BLL.NewsBLL.BLLNews_T.News_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.UserName_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                NewsFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
            try
            {
                HPS.BLL.NewsBLL.BLLNews_T NewsEntity = new HPS.BLL.NewsBLL.BLLNews_T();
                NewsEntity.Title_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Title_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.News_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(News_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.StartDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(StartDate_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.EndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(EndDate_nvcTextBox.Text, TypeCode.String).ToString();
                NewsEntity.Date_nvc = NewsFactory.ServerJalaliDate;
                NewsEntity.Time_nvc = NewsFactory.ServerTime;
                NewsEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    NewsFactory.BeginProc();
                    NewsFactory.Update(NewsEntity, (HPS.BLL.NewsBLL.BLLNews_TKeys)Key);
                    NewsFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.NewsBLL.BLLNews_T.News_TField.NewsID_bint.ToString() + "='" + ((HPS.BLL.NewsBLL.BLLNews_TKeys)Key).NewsID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.NewsBLL.BLLNews_T.News_TField.Title_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.Title_nvc, TypeCode.String);
                            dr[0][HPS.BLL.NewsBLL.BLLNews_T.News_TField.News_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.News_nvc, TypeCode.String);
                            dr[0][HPS.BLL.NewsBLL.BLLNews_T.News_TField.StartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.StartDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.NewsBLL.BLLNews_T.News_TField.EndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.EndDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.NewsBLL.BLLNews_T.News_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.NewsBLL.BLLNews_T.News_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(NewsEntity.Time_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                NewsFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    NewsFactory.BeginProc();
                    NewsFactory.Delete((HPS.BLL.NewsBLL.BLLNews_TKeys)Key);
                    NewsFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.NewsBLL.BLLNews_T.News_TField.NewsID_bint.ToString() + "='" + ((HPS.BLL.NewsBLL.BLLNews_TKeys)Key).NewsID_bint.ToString() + "'");
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
                NewsFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}