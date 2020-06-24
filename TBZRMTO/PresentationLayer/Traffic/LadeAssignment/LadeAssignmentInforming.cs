using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HPS.BLL.SettingsBLL;

namespace HPS.Present.LadeAssignment
{
    public partial class LadeAssignmentInforming : Hepsa.Core.PL.BaseEntityForm1
    {
        private Int64 _LastLadeAssignmentID_bint = 0;
        private bool _CanNotChangeCount = false;
        private bool _DonePrevius = false;

        public LadeAssignmentInforming(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        ToolTip tool = new ToolTip();
        HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();

        public LadeAssignmentInforming(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys Key, bool CanNotChangeCount)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
            LadeAssignmentKey = Key;
            _CanNotChangeCount = CanNotChangeCount;

            // غیر فعال سازی نوع بارگیر و ایکن جستجو در حالت ویرایش برای همه بجز مدیر
            // غیر فعال سازی نوع بارگیر و ایکن جستجو در حالت ویرایش برای همه بجز مدیر
            if (HPS.Common.CurrentUser.user.UserGroupID_int != 1)
            {
                LaderTypeID_intComboBox.Enabled = false;
                LaderTypeID_intNewButton.Visible = false;
               // CompanyID_intComboBox.Enabled = false;
               // CompanyID_intNewButton.Visible = false;
                CarCount_intNumericTextBox.Enabled = false;
            }
        }
        private bool TimeBetween(TimeSpan start, TimeSpan end)
        {
            // convert datetime to a TimeSpan
            var now = new BLLSetting_TFactory().ServerDate.TimeOfDay;
            // see if start comes before end
            if (start < end)
                return start <= now && now <= end;
            // start is after end, so do the inverse comparison
            return !(end < now && now < start);
        }
        private void LadeAssignmentInforming_Load(object sender, EventArgs e)
        {
            if (HPS.Common.CurrentUser.user.CompanyID_int != null)
            {
                BLL.CompanyBLL.BLLCompany_TKeys key = new BLL.CompanyBLL.BLLCompany_TKeys();
                key.CompanyID_int = int.Parse(HPS.Common.CurrentUser.user.CompanyID_int.ToString());
                BLL.CompanyBLL.BLLCompany_TFactory CompanyFactory = new BLL.CompanyBLL.BLLCompany_TFactory();
                var Company = CompanyFactory.GetBy(key);

                CompanyID_textbox.Text = Company.Company_nvc;
            }
            else
            {
                CompanyID_textbox.Text = "فاقد شرکت ثبت شده";
            }

            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                LadeAssignmentFactory.GetLastLadeAssignmentID(out _LastLadeAssignmentID_bint);
                if (this.State == Hepsa.Core.PL.BaseEntityParentForm.enmFormState.Add)
                {
                    this.FillCombo();
                    this.FillCheckListBox();
                }
                tool.AutoPopDelay = 5000;
                tool.InitialDelay = 100;
                tool.ReshowDelay = 100;
                tool.ShowAlways = true;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
            if (this.SaveAndNextButton.Visible == true)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (this.SaveAndCloseButton.Visible == true)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }

            label6.Location = new Point(label4.Location.X, this.CloseFormButton.Location.Y + 10);

        }
        protected override void ShowForm()
        {
            ThisShowForm(null);
        }

        protected override void Insert()
        {
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();

            TimeSpan ToHour;
            if (LadeAssignmentFactory.ServerDate.DayOfWeek == DayOfWeek.Thursday)
            {
                ToHour = TimeSpan.Parse(new BLLSetting_TFactory().GetBy(new BLLSetting_TKeys { SettingID_int = 1030 }).Value_nvc);
            }
            else
                ToHour = TimeSpan.Parse(new BLLSetting_TFactory().GetBy(new BLLSetting_TKeys { SettingID_int = 1026 }).Value_nvc);

            if (!(TimeBetween(TimeSpan.Parse(new BLLSetting_TFactory().GetBy(new BLLSetting_TKeys { SettingID_int = 1025 }).Value_nvc), ToHour)))
            {
                throw new ApplicationException("شما در این زمان مجاز برای ثبت نیستید");
            }
            HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory LadeAssignmentCommentFactory = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory();
            HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory MultiLaderTypeFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
            try
            {
                if ((Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CarCount_intNumericTextBox.NumericText, TypeCode.Int32) == 0)
                {
                    throw new ApplicationException("تعداد خودرو مورد نیاز نمیتواند صفر باشد");
                }
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                LadeAssignmentEntity.LadingDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCommentFactory.ServerJalaliDate, TypeCode.String).ToString();
                LadeAssignmentEntity.LadingTime_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCommentFactory.ServerTime, TypeCode.String).ToString();
                LadeAssignmentEntity.AnnouncementTimeID_int = 1;
                LadeAssignmentEntity.CityID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.Address_nvc = DestinationAddressID_intComboBox.Text;
                LadeAssignmentEntity.GoodID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(GoodID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.BoxingID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.MinWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MinWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LadeAssignmentEntity.MaxWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MaxWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LadeAssignmentEntity.PortageFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(PortageFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                LadeAssignmentEntity.PortPlaceID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaceID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.CarCount_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CarCount_intNumericTextBox.NumericText, TypeCode.Int32);
                LadeAssignmentEntity.Conditin_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Conditin_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.CompanyID_int = HPS.Common.CurrentUser.user.CompanyID_int;
                LadeAssignmentEntity.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                LadeAssignmentEntity.PortPlaces_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaceID_intComboBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress;
                LadeAssignmentEntity.Date_nvc = LadeAssignmentFactory.ServerJalaliDate;
                LadeAssignmentEntity.Time_nvc = LadeAssignmentFactory.ServerTime;
                LadeAssignmentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;


                if (LadeAssignmentEntity.LadingDate_nvc.CompareTo(LadeAssignmentFactory.ServerJalaliDate) < 0)
                {
                    throw new ApplicationException(" تاریخ بارگیری نباید کوچکتر از'" + LadeAssignmentFactory.ServerJalaliDate + "' باشد");
                }

                int? ladeAnnouncementtime = LadeAssignmentEntity.AnnouncementTimeID_int;

                ///check Company Infraction
                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                string InfractionCondition = string.Format("[Infraction_T].CompanyID_int='{0}' AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", HPS.Common.CurrentUser.user.CompanyID_int);
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                if (InfractionList != null && InfractionList.Count > 0)
                {
                    throw new ApplicationException("شرکت متخلف است");
                }

                LadeAssignmentFactory.BeginProc();
                LadeAssignmentFactory.Insert(LadeAssignmentEntity);



                if (LaderTypeID_intComboBox.SelectedIndex != -1)
                {

                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T MultiLaderTypeEntity = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                    MultiLaderTypeEntity.LadeAssignmentID_bint = LadeAssignmentEntity.LadeAssignmentID_bint;
                    MultiLaderTypeEntity.LaderTypeID_int = Convert.ToInt32(LaderTypeID_intComboBox.SelectedValue);
                    MultiLaderTypeFactory.Insert(MultiLaderTypeEntity);

                }
                else
                {
                    throw new ApplicationException("نوع بارگیر خالی است");
                }
                LadeAssignmentFactory.CommitProc();


                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.LadeAssignmentID_bint, TypeCode.Int64);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadingDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.LadingDate_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadingTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.LadingTime_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AnnouncementTimeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.AnnouncementTimeID_int, TypeCode.Int32);
                    dr["AnnouncementTimeID_intAnnouncementTime_nvc"] = 1;
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.CityID_int, TypeCode.Int32);
                    dr["CityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CityID_intComboBox);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.CityCode_nvc, TypeCode.String);
                    dr["Address_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(DestinationAddressID_intComboBox);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.GoodID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.GoodID_int, TypeCode.Int32);
                    dr["GoodID_intGood_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(GoodID_intComboBox);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.BoxingID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.BoxingID_int, TypeCode.Int32);
                    dr["BoxingID_intBoxingType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(BoxingID_intComboBox);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MinWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.MinWeight_dec, TypeCode.Decimal);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MaxWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.MaxWeight_dec, TypeCode.Decimal);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortageFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.PortageFee_dec, TypeCode.Decimal);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortPlaceID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.PortPlaceID_int, TypeCode.Int32);
                    dr["PortPlaceID_intPortPlaces_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PortPlaceID_intComboBox);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CarCount_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.CarCount_int, TypeCode.Int32);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Conditin_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Conditin_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CompanyID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.CompanyID_int, TypeCode.Int32);
                    dr["CompanyID_intCompany_nvc"] = HPS.Common.CurrentUser.user.CompanyID_int;
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Comment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Comment_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.UserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.UserName_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MacAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.MacAddress_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.IPAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.IPAddress_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Date_nvc, TypeCode.String);
                    dr[HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Time_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                LadeComments_nvcListBox.DataSource = new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
                Clearform();
                MessageBox.Show("بار مورد نظر ثبت رایانه گردید");
            }
            catch (Exception ex)
            {
                LadeAssignmentFactory.RollBackProc();
                throw;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory LadeAssignmentCommentFactory = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory();
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory MultiLaderTypeFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
            try
            {
                if ((Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CarCount_intNumericTextBox.NumericText, TypeCode.Int32) == 0)
                {
                    throw new ApplicationException("تعداد خودرو مورد نیاز نمیتواند صفر باشد");
                }
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                //HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                //LadeAssignmentKey.LadeAssignmentID_bint = 
                LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKey);
                LadeAssignmentEntity.LadingDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCommentFactory.ServerJalaliDate, TypeCode.String).ToString();
                LadeAssignmentEntity.LadingTime_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentCommentFactory.ServerTime, TypeCode.String).ToString();
                LadeAssignmentEntity.CityID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.Address_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DestinationAddressID_intComboBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.GoodID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(GoodID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.BoxingID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(BoxingID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.MinWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MinWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LadeAssignmentEntity.MaxWeight_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(MaxWeight_decNumericTextBox.NumericText, TypeCode.Decimal);
                LadeAssignmentEntity.PortageFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(PortageFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                LadeAssignmentEntity.PortPlaceID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaceID_intComboBox.SelectedValue, TypeCode.Int32);
                LadeAssignmentEntity.CarCount_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(CarCount_intNumericTextBox.NumericText, TypeCode.Int32);
                LadeAssignmentEntity.Conditin_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Conditin_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                LadeAssignmentEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                LadeAssignmentEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress;
                LadeAssignmentEntity.PortPlaces_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PortPlaceID_intComboBox.Text, TypeCode.String).ToString();
                //LadeAssignmentEntity.Date_nvc = LadeAssignmentFactory.ServerJalaliDate;
                //LadeAssignmentEntity.Time_nvc = LadeAssignmentFactory.ServerTime;
                //LadeAssignmentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                if (LadeAssignmentEntity.Accepted_bit)
                    LadeAssignmentEntity.Accepted_bit = false;
                LadeAssignmentEntity.EditUserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                LadeAssignmentEntity.EditDate_vc = LadeAssignmentFactory.ServerJalaliDate;
                LadeAssignmentEntity.EditTime_vc = LadeAssignmentFactory.ServerTime;

                int? ladeAnnouncementtime = LadeAssignmentEntity.AnnouncementTimeID_int;
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentKey.LadeAssignmentID_bint, TypeCode.Int64) + "' and LadBillCredit_T.Canceled_bit=0 ";
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
                int LadBillCreditCount = 0;
                if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                    LadBillCreditCount = LadBillCreditList.Count;
                if (LadeAssignmentEntity.CarCount_int < LadBillCreditCount)
                {
                    throw new ApplicationException("تعداد ناوگان درخواستی نمی تواند کمتر از تعداد مجوز داده شده باشد");
                }

                ///check Company Infraction
                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                string InfractionCondition = string.Format("[Infraction_T].CompanyID_int='{0}' AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", HPS.Common.CurrentUser.user.CompanyID_int);
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                if (InfractionList != null && InfractionList.Count > 0)
                {
                    throw new ApplicationException("شرکت متخلف است");
                }

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {

                    LadeAssignmentFactory.BeginProc();
                    LadeAssignmentFactory.Update(LadeAssignmentEntity, (HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)Key);

                    LadeAssignmentCommentFactory.Delete(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint);


                    if (LadeComments_nvcListBox.DataSource != null)
                    {


                        foreach (HPS.BLL.LadeCommentBLL.BLLLadeComment_T item in (List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>)LadeComments_nvcListBox.DataSource)
                        {
                            HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T LadeAssignmentCommentEntity = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T();
                            LadeAssignmentCommentEntity.LadeAssignmentID_bint = LadeAssignmentKey.LadeAssignmentID_bint;
                            LadeAssignmentCommentEntity.LadeCommentID_int = item.LadeCommentID_int;
                            LadeAssignmentCommentEntity.LadeComment_nvc = item.LadeComment_nvc;
                            LadeAssignmentCommentEntity.Date_nvc = LadeAssignmentFactory.ServerJalaliDate;
                            LadeAssignmentCommentEntity.Time_nvc = LadeAssignmentFactory.ServerTime;
                            LadeAssignmentCommentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                            LadeAssignmentCommentFactory.Insert(LadeAssignmentCommentEntity);
                        }
                    }

                    MultiLaderTypeFactory.Delete(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint);

                    if (LaderTypeID_intComboBox.SelectedIndex != -1)
                    {

                        HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T MultiLaderTypeEntity = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                        MultiLaderTypeEntity.LadeAssignmentID_bint = LadeAssignmentKey.LadeAssignmentID_bint;
                        MultiLaderTypeEntity.LaderTypeID_int = Convert.ToInt32(LaderTypeID_intComboBox.SelectedValue);

                        MultiLaderTypeEntity.LaderTypeID_int = Convert.ToInt32(LaderTypeID_intComboBox.SelectedValue);
                        MultiLaderTypeFactory.Insert(MultiLaderTypeEntity);

                    }



                    LadeAssignmentFactory.CommitProc();
                    LadeComments_nvcListBox.DataSource = new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
                    //pep            //AnnouncementTimeID_intComboBox.SelectedValue = ladeAnnouncementtime;


                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint.ToString() + "='" + LadeAssignmentKey.LadeAssignmentID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["AnnouncementTimeID_intAnnouncementTime_nvc"] = 1;
                            dr[0]["CityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CityID_intComboBox);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Address_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Address_nvc, TypeCode.String);
                            dr[0]["GoodID_intGood_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(GoodID_intComboBox);
                            dr[0]["BoxingID_intBoxingType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(BoxingID_intComboBox);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MinWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.MinWeight_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MaxWeight_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.MaxWeight_dec, TypeCode.Decimal);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortageFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.PortageFee_dec, TypeCode.Decimal);
                            dr[0]["PortPlaceID_intPortPlaces_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PortPlaceID_intComboBox);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CarCount_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.CarCount_int, TypeCode.Int32);
                            dr[0]["CompanyID_intCompany_nvc"] = HPS.Common.CurrentUser.user.CompanyID_int;
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Comment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Comment_nvc, TypeCode.String);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(LadeAssignmentEntity.Time_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                    Clearform();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                LadeAssignmentFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    LadeAssignmentFactory.BeginProc();
                    LadeAssignmentFactory.Delete((HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)Key);
                    LadeAssignmentFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint.ToString() + "='" + ((HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)Key).LadeAssignmentID_bint.ToString() + "'");
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
                LadeAssignmentFactory.RollBackProc();
                throw ex;
            }
        }
        DataTable CityID_intDataTable = new DataTable();
        DataTable GoodID_intDataTable = new DataTable();
        DataTable BoxingID_intDataTable = new DataTable();
        DataTable PortPlaceID_intDataTable = new DataTable();
        DataTable LaderTypeID_intDataTable = new DataTable();
        DataTable LadeCommentID_intDataTable = new DataTable();
        private void FillCombo()
        {
            try
            {
                HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeID_intFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();

                HPS.BLL.CityBLL.BLLCity_TFactory CityID_intFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();

                string CityCondition = "[City_T].[Active_bit]='true'";
                CityID_intFactory.GetAllByCondition(CityCondition, ref CityID_intDataTable);
                DataRow Citydr = CityID_intDataTable.NewRow();
                Citydr["CityID_int"] = 0;
                CityID_intDataTable.Rows.InsertAt(Citydr, 0);
                this.CityID_intComboBox.DisplayMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString();
                this.CityID_intComboBox.ValueMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString();
                this.CityID_intComboBox.DataSource = CityID_intDataTable;
                this.CityID_intComboBox.SelectedIndex = -1;

                HPS.BLL.GoodBLL.BLLGood_TFactory GoodID_intFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();

                string goodCondition = "[Good_T].[Avtive_bit]='true'";
                GoodID_intFactory.GetAllByCondition(goodCondition, ref GoodID_intDataTable);
                DataRow Gooddr = GoodID_intDataTable.NewRow();
                Gooddr["GoodID_int"] = 0;
                GoodID_intDataTable.Rows.InsertAt(Gooddr, 0);
                this.GoodID_intComboBox.DisplayMember = HPS.BLL.GoodBLL.BLLGood_T.Good_TField.Good_nvc.ToString();
                this.GoodID_intComboBox.ValueMember = HPS.BLL.GoodBLL.BLLGood_T.Good_TField.GoodID_int.ToString();
                this.GoodID_intComboBox.DataSource = GoodID_intDataTable;
                this.GoodID_intComboBox.SelectedIndex = -1;

                HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingID_intFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();

                string BoxingCondition = "[Boxing_T].[Active_bit]='true'";
                BoxingID_intFactory.GetAllByCondition(BoxingCondition, ref BoxingID_intDataTable);
                DataRow Boxingdr = BoxingID_intDataTable.NewRow();
                Boxingdr["BoxingID_int"] = 0;
                BoxingID_intDataTable.Rows.InsertAt(Boxingdr, 0);
                this.BoxingID_intComboBox.DisplayMember = HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingType_nvc.ToString();
                this.BoxingID_intComboBox.ValueMember = HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString();
                this.BoxingID_intComboBox.DataSource = BoxingID_intDataTable;
                this.BoxingID_intComboBox.SelectedIndex = -1;

                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceID_intFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

                string PortPlaceCondition = "[PortPlaces_T].[Active_bit]='true'";
                PortPlaceID_intFactory.GetAllByCondition(PortPlaceCondition, ref PortPlaceID_intDataTable);
                this.PortPlaceID_intComboBox.DisplayMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString();
                this.PortPlaceID_intComboBox.ValueMember = HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString();
                this.PortPlaceID_intComboBox.DataSource = PortPlaceID_intDataTable;
                this.PortPlaceID_intComboBox.SelectedIndex = -1;

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();

                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                DataRow laderdr = LaderTypeID_intDataTable.NewRow();
                laderdr["LaderTypeID_int"] = 0;
                LaderTypeID_intDataTable.Rows.InsertAt(laderdr, 0);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;


                HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory DestinationAddressFactory = new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TFactory();
                DataTable DestinationAddressDataTable = new DataTable();
                DestinationAddressFactory.GetAll(ref DestinationAddressDataTable);
                this.DestinationAddressID_intComboBox.DisplayMember = HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddress_nvc.ToString();
                this.DestinationAddressID_intComboBox.ValueMember = HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddressID_int.ToString();
                this.DestinationAddressID_intComboBox.DataSource = DestinationAddressDataTable;
                this.DestinationAddressID_intComboBox.SelectedIndex = -1;

                //HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
                //LadeCommentFactory.GetAll(ref LadeCommentID_intDataTable);
                //DataRow LadeCommentdr = LadeCommentID_intDataTable.NewRow();
                //LadeCommentdr["LadeCommentID_int"] = 0;
                //LadeCommentID_intDataTable.Rows.InsertAt(LadeCommentdr, 0);
                //this.LadeCommentID_intComboBox.DisplayMember = HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeComment_nvc.ToString();
                //this.LadeCommentID_intComboBox.ValueMember = HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString();
                //this.LadeCommentID_intComboBox.DataSource = LadeCommentID_intDataTable;
                //this.LadeCommentID_intComboBox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        HPS.BLL.CityBLL.BLLCity_T CityEntity = new HPS.BLL.CityBLL.BLLCity_T();

        private void CityID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CitySearch frm = new HPS.Present.SearchForm.CitySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CityEntity = frm.SelectedCity;

                CityID_intComboBox.Text = CityEntity.City_nvc;
                CityCode_nvcTextBox.Text = CityEntity.CityCode_nvc;
            }
        }


        HPS.BLL.GoodBLL.BLLGood_T GoodEntity = new HPS.BLL.GoodBLL.BLLGood_T();


        private void GoodID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.GoodSearch frm = new HPS.Present.SearchForm.GoodSearch();
            frm.ShowDialog();
            if (frm != null)
            {
                GoodEntity = frm.SelectedGoodEntity;

                GoodID_intComboBox.Text = GoodEntity.Good_nvc;
                GoodCode_nvcTextBox.Text = GoodEntity.GoodCode_nvc;
            }
        }


        HPS.BLL.BoxingBLL.BLLBoxing_T BoxingEntity = new HPS.BLL.BoxingBLL.BLLBoxing_T();

        private void BoxingID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.BoxingSearch frm = new HPS.Present.SearchForm.BoxingSearch();
            frm.ShowDialog();
            if (frm != null)
            {
                BoxingEntity = frm.SelectedBoxingEntity;

                BoxingID_intComboBox.Text = BoxingEntity.BoxingType_nvc;

                BoxingCode_nvcTextBox.Text = BoxingEntity.BoxingCode_nvc;
            }
        }


        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();

        List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeList = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();

        private void LaderTypeID_intNewButton_Click(object sender, EventArgs e)
        {
            var frm = new HPS.Present.SearchForm.LaderTypeSearch();
            frm.ShowDialog();
            try
            {
                if (frm != null && frm.SelectedLaderTypeEntity != null)
                {

                    LaderTypeEntity = frm.SelectedLaderTypeEntity;
                    LaderTypeID_intComboBox.Text = LaderTypeEntity.LaderType_nvc;

                }
            }
            catch (Exception)
            {

                throw;
            }



        }


        private void FillCheckListBox()
        {
            HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();

            try
            {
                //List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> LadeCommentList = LadeCommentFactory.GetAll();

                //if (LadeCommentList != null && LadeCommentList.Count > 0)
                //{
                //    foreach (HPS.BLL.LadeCommentBLL.BLLLadeComment_T item in LadeCommentList)
                //    {
                //        LadeCommentID_intCheckedListBox.Items.Add(item, false);
                //    }
                //}
                //this.LadeCommentID_intCheckedListBox.GetType().GetProperty("DisplayMember").SetValue(this.LadeCommentID_intCheckedListBox, HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeComment_nvc.ToString(), null);
                //this.LadeCommentID_intCheckedListBox.GetType().GetProperty("ValueMember").SetValue(this.LadeCommentID_intCheckedListBox, HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString(), null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GoodID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (GoodID_intComboBox.SelectedIndex != -1)
            {

                GoodEntity.GoodID_int = (Int32?)GoodID_intComboBox.SelectedValue;
                GoodEntity.Good_nvc = GoodID_intDataTable.Rows[Convert.ToInt32(GoodID_intComboBox.SelectedIndex)]["Good_nvc"].ToString();
                GoodCode_nvcTextBox.Text = GoodID_intDataTable.Rows[Convert.ToInt32(GoodID_intComboBox.SelectedIndex)]["GoodCode_nvc"].ToString();
            }
        }

        private void BoxingID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (BoxingID_intComboBox.SelectedIndex != -1)
            {

                BoxingEntity.BoxingID_int = (Int32?)BoxingID_intComboBox.SelectedValue;
                BoxingEntity.BoxingType_nvc = BoxingID_intDataTable.Rows[Convert.ToInt32(BoxingID_intComboBox.SelectedIndex)]["BoxingType_nvc"].ToString();
                BoxingCode_nvcTextBox.Text = BoxingID_intDataTable.Rows[Convert.ToInt32(BoxingID_intComboBox.SelectedIndex)]["BoxingCode_nvc"].ToString();
            }
        }

        private void DestinationAddressID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.DestinationAddress.DestinationAddressEntityForm frm = new HPS.Present.DestinationAddress.DestinationAddressEntityForm((DataTable)DestinationAddressID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void MinWeight_decNumericTextBox_TextChanged(object sender, EventArgs e)
        {
            MaxWeight_decNumericTextBox.Text = MinWeight_decNumericTextBox.Text;
        }
        private void CommentSearchbutton_Click(object sender, EventArgs e)
        {
            LadeComments_nvcListBox.DataSource = new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
            HPS.Present.SearchForm.LadeCommentSearchForm frm = new HPS.Present.SearchForm.LadeCommentSearchForm();
            frm.ShowDialog();
            string CommentString = string.Empty;
            if (frm != null)
            {
                foreach (HPS.BLL.LadeCommentBLL.BLLLadeComment_T item in frm.SelectedLadeCommentList)
                {
                    CommentString += item.LadeComment_nvc + ",";
                }
                if (CommentString.EndsWith(","))
                {
                    CommentString = CommentString.Substring(0, CommentString.Length - 1);
                }
                Comment_nvcTextBox.Text = CommentString;
                LadeComments_nvcListBox.DataSource = frm.SelectedLadeCommentList;
                LadeComments_nvcListBox.DisplayMember = "LadeComment_nvc";
                LadeComments_nvcListBox.ValueMember = "LadeCommentID_int";
                //pep      //LadeCommentID_intComboBox.Update();
            }
        }

        private void LadeAssignmentInforming_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F3)
            {
                if (CommentSearchbutton.Visible)
                {
                    CommentSearchbutton.PerformClick();
                }
            }
        }

        private void LaderTypeID_intComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {

                    if (LaderTypeID_intComboBox.SelectedIndex == -1)
                    {
                        string Filter = string.Format("LaderTypeCode_nvc='{0}'", LaderTypeID_intComboBox.Text);
                        DataRow[] dr = LaderTypeID_intDataTable.Select(Filter);

                        LaderTypeID_intComboBox.SelectedValue = dr[0]["LaderTypeID_int"];
                    }




                }
                catch (Exception ex)
                {
                    LaderTypeID_intComboBox.Text = "";
                    //Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
                //LaderTypeID_intComboBox.Focus();
                Comment_nvcTextBox.Focus();
                this.RaiseKeyDownEvent = false;
            }
        }

        private void Clearform()
        {
            CityID_intComboBox.SelectedIndex = -1;
            CityCode_nvcTextBox.Text = string.Empty;
            DestinationAddressID_intComboBox.SelectedIndex = -1;
            BoxingID_intComboBox.SelectedIndex = -1;
            BoxingCode_nvcTextBox.Text = string.Empty;
            MinWeight_decNumericTextBox.Text = string.Empty;
            MaxWeight_decNumericTextBox.Text = string.Empty;
            PortageFee_decNumericTextBox.Text = string.Empty;
            PortPlaceID_intComboBox.SelectedIndex = -1;
            CarCount_intNumericTextBox.Text = string.Empty;
            Comment_nvcTextBox.Text = string.Empty;
            LaderTypeID_intComboBox.SelectedIndex = -1;
            //pep     LaderTypes_nvcListBox.DataSource = null;

        }

        private void BoxingID_intComboBox_Leave(object sender, EventArgs e)
        {
            if (BoxingID_intComboBox.SelectedIndex == -1)
            {
                string Filter = string.Format("BoxingCode_nvc='{0}'", BoxingID_intComboBox.Text);
                DataRow[] dr = BoxingID_intDataTable.Select(Filter);
                if (dr.Length > 0)
                {
                    BoxingID_intComboBox.SelectedValue = dr[0]["BoxingID_int"];
                }
            }

        }
        private void ThisShowForm(Int64? LadeAssignmentID_bint)
        {
            try
            {
                if (_CanNotChangeCount)
                {
                    CarCount_intNumericTextBox.Enabled = false;
                }
                this.SaveAndCloseButton.Visible = true;
                if (LadeAssignmentID_bint.HasValue)
                {
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                    LadeKey.LadeAssignmentID_bint = LadeAssignmentID_bint;
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeKey);
                    if (LadeAssignmentEntity == null)
                    {
                        //pep       //Nextbutton.Enabled = false;
                        //Previousbutton.Enabled = true;
                        throw new ApplicationException("ردیف جاری آخرین مورد می باشد");
                    }
                    //Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref AnnouncementTimeID_intComboBox, LadeAssignmentEntity.AnnouncementTimeID_int, TypeCode.Int32);
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CityID_intComboBox, LadeAssignmentEntity.CityID_int, TypeCode.Int32);
                    CityCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.CityCode_nvc, TypeCode.String).ToString();
                    DestinationAddressID_intComboBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.Address_nvc, TypeCode.String).ToString();
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref GoodID_intComboBox, LadeAssignmentEntity.GoodID_int, TypeCode.Int32);
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref BoxingID_intComboBox, LadeAssignmentEntity.BoxingID_int, TypeCode.Int32);
                    MinWeight_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.MinWeight_dec, TypeCode.Decimal).ToString();
                    MaxWeight_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.MaxWeight_dec, TypeCode.Decimal).ToString();
                    PortageFee_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.PortageFee_dec, TypeCode.Decimal).ToString();
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PortPlaceID_intComboBox, LadeAssignmentEntity.PortPlaceID_int, TypeCode.Int32);
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, LadeAssignmentEntity.LaderTypeID_int, TypeCode.Int32);
                    CarCount_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.CarCount_int, TypeCode.Int32).ToString();
                    Conditin_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.Conditin_nvc, TypeCode.String).ToString();

                    //Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CompanyID_intComboBox, LadeAssignmentEntity.CompanyID_int, TypeCode.Int32);
                    Comment_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.Comment_nvc, TypeCode.String).ToString();

                    HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory LadeAssignmentCommentFactory = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
                    List<HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> LadeAssignmentCommentList = LadeAssignmentCommentFactory.GetAllBy(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeAssignmentID_bint, LadeAssignmentID_bint);
                    List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> LadeCommentListSource = new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntitySource = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys LadeCommentKey = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys();
                    if (LadeAssignmentCommentList != null && LadeAssignmentCommentList.Count > 0)
                    {
                        foreach (HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T item in LadeAssignmentCommentList)
                        {
                            LadeCommentKey.LadeCommentID_int = item.LadeCommentID_int;
                            LadeCommentEntitySource = LadeCommentFactory.GetBy(LadeCommentKey);
                            LadeCommentListSource.Add(LadeCommentEntitySource);
                        }
                        LadeComments_nvcListBox.DataSource = LadeCommentListSource;
                        LadeComments_nvcListBox.DisplayMember = "LadeComment_nvc";
                        LadeComments_nvcListBox.ValueMember = "LadeCommentID_int";
                        //LadeCommentID_intComboBox.Update();

                    }

                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory MultiLaderTypeFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T MultiLaderTypeEntity = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                    List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> MultiLaderTypeList = MultiLaderTypeFactory.GetAllBy(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LadeAssignmentID_bint, LadeAssignmentID_bint);
                    if (MultiLaderTypeList != null && MultiLaderTypeList.Count > 0)
                    {
                        LaderTypeID_intComboBox.SelectedValue = MultiLaderTypeList[0].LaderTypeID_int;

                    }
                }
                else
                {

                    this.FillCombo();
                    this.FillCheckListBox();
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = LadeAssignmentFactory.GetBy((HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)Key);
                    if (LadeAssignmentEntity == null)
                    {

                        throw new HPS.Exceptions.LadeAssignmentNotFound();
                    }
                    //LadingDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.LadingDate_nvc, TypeCode.String));
                    //LadingTime_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.LadingTime_nvc, TypeCode.String).ToString();
                    //Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref AnnouncementTimeID_intComboBox, LadeAssignmentEntity.AnnouncementTimeID_int, TypeCode.Int32);
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CityID_intComboBox, LadeAssignmentEntity.CityID_int, TypeCode.Int32);
                    CityCode_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.CityCode_nvc, TypeCode.String).ToString();
                    DestinationAddressID_intComboBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.Address_nvc, TypeCode.String).ToString();
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref GoodID_intComboBox, LadeAssignmentEntity.GoodID_int, TypeCode.Int32);
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref BoxingID_intComboBox, LadeAssignmentEntity.BoxingID_int, TypeCode.Int32);
                    MinWeight_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.MinWeight_dec, TypeCode.Decimal).ToString();
                    MaxWeight_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.MaxWeight_dec, TypeCode.Decimal).ToString();
                    PortageFee_decNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.PortageFee_dec, TypeCode.Decimal).ToString();
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PortPlaceID_intComboBox, LadeAssignmentEntity.PortPlaceID_int, TypeCode.Int32);
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, LadeAssignmentEntity.LaderTypeID_int, TypeCode.Int32);
                    CarCount_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.CarCount_int, TypeCode.Int32).ToString();
                    Conditin_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.Conditin_nvc, TypeCode.String).ToString();
                    //Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CompanyID_intComboBox, LadeAssignmentEntity.CompanyID_int, TypeCode.Int32);
                    Comment_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentEntity.Comment_nvc, TypeCode.String).ToString();

                    HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory LadeAssignmentCommentFactory = new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TFactory();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
                    List<HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> LadeAssignmentCommentList = LadeAssignmentCommentFactory.GetAllBy(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeAssignmentID_bint, ((HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)Key).LadeAssignmentID_bint);
                    List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> LadeCommentListSource = new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntitySource = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys LadeCommentKey = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys();
                    if (LadeAssignmentCommentList != null && LadeAssignmentCommentList.Count > 0)
                    {
                        foreach (HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T item in LadeAssignmentCommentList)
                        {

                            LadeCommentKey.LadeCommentID_int = item.LadeCommentID_int;
                            LadeCommentEntitySource = LadeCommentFactory.GetBy(LadeCommentKey);
                            LadeCommentListSource.Add(LadeCommentEntitySource);
                        }
                        LadeComments_nvcListBox.DataSource = LadeCommentListSource;
                        LadeComments_nvcListBox.DisplayMember = "LadeComment_nvc";
                        LadeComments_nvcListBox.ValueMember = "LadeCommentID_int";
                        //LadeCommentID_intComboBox.Update();

                    }

                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory MultiLaderTypeFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T MultiLaderTypeEntity = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                    List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> MultiLaderTypeList = MultiLaderTypeFactory.GetAllBy(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LadeAssignmentID_bint, ((HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys)Key).LadeAssignmentID_bint);
                    if (MultiLaderTypeList != null && MultiLaderTypeList.Count > 0)
                    {
                        LaderTypeID_intComboBox.SelectedValue = MultiLaderTypeList[0].LaderTypeID_int;

                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CityID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CityID_intComboBox.SelectedIndex != -1)
            {

                CityEntity.CityID_int = (Int32?)CityID_intComboBox.SelectedValue;
                CityEntity.City_nvc = CityID_intDataTable.Rows[Convert.ToInt32(CityID_intComboBox.SelectedIndex)]["City_nvc"].ToString();
                CityCode_nvcTextBox.Text = CityID_intDataTable.Rows[Convert.ToInt32(CityID_intComboBox.SelectedIndex)]["CityCode_nvc"].ToString();
            }
        }

        private void DestinationAddressID_intComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaderTypeID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (LaderTypeID_intComboBox.SelectedIndex == 0)
                {
                    return;
                }
                else
                {
                    if (LaderTypeID_intComboBox.SelectedValue != null && (bool?)((DataRowView)LaderTypeID_intComboBox.SelectedItem)["TurnCancel_bit"] == false)
                    {
                        LaderTypeID_intComboBox.SelectedIndex = -1;
                        throw new ApplicationException("امکان ثبت نوبت برای این بارگیر وجود ندارد");
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
