using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace HPS.Present.LadBillCredit
{
    public partial class LadBillCreditListForm : Hepsa.Core.PL.BaseListForm
    {
        StringBuilder Eroorbuilder = new StringBuilder();
        List<string> DateEroorList = new List<string>();
        private bool ChechActiveDriver = true;
        private bool ChechActiveCare = true;
        string ErrorMessage = string.Empty;
        private Int64 LadeAssignmentID;
        string ErrorMessage_nvc = string.Empty;

        public LadBillCreditListForm()
        {
            InitializeComponent();
            LaderTypeGridView.AutoGenerateColumns = false;
            LadeAssignmentGridView.AutoGenerateColumns = false;
            Hepsa.Core.PL.BaseListForm.Group LadeAssignmentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeAssignmentGroup.GroupName = "LadeAssignmentGroup";
            LadeAssignmentGroup.AddButton = null;
            LadeAssignmentGroup.DeleteButton = null;
            LadeAssignmentGroup.EditButton = null;
            LadeAssignmentGroup.RefreshButton = this.RefreshButton;
            LadeAssignmentGroup.set_Grid(false, false, true, this.LadeAssignmentGridView);
            LadeAssignmentGroup.ToolStrip = this.LadeAssignmentToolStrip;
            LadeAssignmentGroup.HasFilterControl = true;
            this.Groups.Add(LadeAssignmentGroup);
            // LadeAssignmentGridView.ReadOnly = false;
            //  Choose_bit.ReadOnly = false;


            //Hepsa.Core.PL.BaseListForm.Group TurnGroup = new Hepsa.Core.PL.BaseListForm.Group();
            //TurnGroup.GroupName = "TurnGroup";
            //TurnGroup.set_Grid(true, false, true, this.AcceptedTurnGridView);
            //TurnGroup.ToolStrip = this.AcceptedTurnToolStrip;
            //TurnGroup.HasFilterControl = false;
            //this.Groups.Add(TurnGroup);


            Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LaderTypeGroup.GroupName = "LaderTypeGroup";
            LaderTypeGroup.AddButton = null;
            LaderTypeGroup.DeleteButton = null;
            LaderTypeGroup.EditButton = null;
            LaderTypeGroup.RefreshButton = null;
            LaderTypeGroup.set_Grid(false, false, true, this.LaderTypeGridView);
            this.Groups.Add(LaderTypeGroup);

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

        private void LadBillCreditListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadLadeAssignment();
                // غیر فعال سازی پیشفرض چاپ
                // در صورت ورود اطلاعات مجاز چاپ فعال می شود
                LadBillCredittoolStripButton.Enabled = false;
                foreach (ToolStripItem item in this.Groups.get_Item("LadeAssignmentGroup").ToolStrip.Items)
                {
                    if (item is ToolStripTextBox)
                        ((ToolStripTextBox)item).KeyDown += new KeyEventHandler(LadeAssignmenToolStrip_KeyDown);
                    else if (item is ToolStripComboBox)
                        ((ToolStripComboBox)item).KeyDown += new KeyEventHandler(LadeAssignmenToolStrip_KeyDown);
                }
                this.Groups.get_Item("LadeAssignmentGroup").FilterTextBosFocus();
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
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeassignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LADatatable = new DataTable();
                Properties.Settings Setting = new HPS.Properties.Settings();
                LadeassignmentFactory.GetAllLadBillCount(LadeassignmentFactory.ServerJalaliDate, Setting.SaloonID_int, ref LADatatable);
                this.LadeAssignmentGridView.SelectionChanged -= new System.EventHandler(this.LadeAssignmentGridView_SelectionChanged);
                LadeAssignmentGridView.DataSource = LADatatable;
                this.LadeAssignmentGridView.SelectionChanged += new System.EventHandler(this.LadeAssignmentGridView_SelectionChanged);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void AllLatoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                DataTable LadeAssignmentDataTable = new DataTable();
                Properties.Settings Setting = new HPS.Properties.Settings();
                LadeAssignmentFactory.GetAllLadBillCount(null, Setting.SaloonID_int, ref LadeAssignmentDataTable);
                this.LadeAssignmentGridView.SelectionChanged -= new System.EventHandler(this.LadeAssignmentGridView_SelectionChanged);
                this.LadeAssignmentGridView.DataSource = LadeAssignmentDataTable;
                this.LadeAssignmentGridView.SelectionChanged += new System.EventHandler(this.LadeAssignmentGridView_SelectionChanged);
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

        private void LadBillCredittoolStripButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBilFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T LadBillEntity = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T();

            try
            {
                if (ChechActiveDriver == false || ChechActiveCare == false)
                {
                    return;
                }

                LadBillCredittoolStripButton.Enabled = false;
                //if (DateEroorList != null && DateEroorList.Count > 0)
                //{
                //    throw new ApplicationException("DateEroorList.Aggregate((i, j) => i + j)");
                //}

                if (AcceptedTurnGridView.CurrentRow == null || LadeAssignmentGridView.CurrentRow == null)
                {
                    throw new ApplicationException("جداول خالیست");
                }
                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1004;
                string CompareDate = string.Empty;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                if (SettingEntity != null)
                {

                    DateTime LadeDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(Convert.ToString(LadeAssignmentGridView.CurrentRow.Cells[colDate_nvc.Name].Value))).MyDate.ToString("yyyy/MM/dd") + " " + Convert.ToString(LadeAssignmentGridView.CurrentRow.Cells[colTime_nvc.Name].Value));
                    LadeDate.AddHours(Convert.ToInt32(SettingEntity.Value_nvc));
                    CompareDate = new Hepsa.Core.Common.MyDateTime(LadeDate).ConvertToPersianShortDate();
                }
                if (SettingFactory.ServerJalaliDate.CompareTo(CompareDate) > 0)
                {
                    throw new ApplicationException("امکان اختصاص اطلاع رسانی بار پس از " + SettingEntity.Value_nvc + "ساعت وجود ندارد");
                }


                if (LadeAssignmentGridView.SelectedRows.Count == 1 && AcceptedTurnGridView.CurrentRow != null)
                {
                    LadeAssignmentID = Convert.ToInt64(LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value);
                    //foreach (Janus.Windows.GridEX.GridEXRow row in AcceptedTurnGridView.GetRow)
                    //{
                    Janus.Windows.GridEX.GridEXRow row = AcceptedTurnGridView.GetRow();
                    LadBillEntity.LadeAssignmentID_bint = LadeAssignmentID;
                    LadBillEntity.Date_nvc = LadBilFactory.ServerJalaliDate;
                    LadBillEntity.Time_nvc = LadBilFactory.ServerTime;
                    LadBillEntity.TrafficID_bint = Convert.ToInt64(row.Cells["LadBillTrafficID_bint"].Value);
                    LadBillEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    LadBillEntity.Comment_nvc = Convert.ToString(row.Cells["LadBillComment"].Value);

                    /// تخلف
                    #region
                    Int32? CarID = null;
                    Int64? DriverID = null;
                    string FirstName = string.Empty;
                    string LastName = string.Empty;
                    Int64? NationaCode = null;
                    string NumberPlate = string.Empty;
                    string SerialPlate = string.Empty;
                    string PlateCityCode = string.Empty;

                    //if (AcceptedTurnGridView.GetCheckedRows().Length >= 1)
                    //{
                    if ((Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["CarID_int"].Value, TypeCode.Int32)) != null)
                    {
                        CarID = (Int32?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["CarID_int"].Value, TypeCode.Int32));
                    }
                    if (AcceptedTurnGridView.CurrentRow.Cells["DriverID_bint"].Value != null)
                    {
                        DriverID = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["DriverID_bint"].Value, TypeCode.Int64));
                    }
                    FirstName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["FirstName_nvc"].Value, TypeCode.String));
                    LastName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["LastName_nvc"].Value, TypeCode.String));
                    NationaCode = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NationalCode_int"].Value, TypeCode.Int64));
                    NumberPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NumberPlate_nvc"].Value, TypeCode.String));
                    SerialPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["SerialPlate_nvc"].Value, TypeCode.String));
                    PlateCityCode = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["PlateCityCode_nvc"].Value, TypeCode.String));

                    HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                    string InfractionCondition = string.Format("[Infraction_T].NumberPlate_nvc='{0}'  AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}' AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", NumberPlate, SerialPlate, PlateCityCode);
                    List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                    if (InfractionList != null && InfractionList.Count > 0)
                    {
                        throw new ApplicationException("ناوگان متخلف است");
                    }

                    if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || !NationaCode.HasValue)
                    {
                        throw new ApplicationException("نام، نام خانوادگی یا کد ملی راننده خالی است");
                    }

                    InfractionCondition = string.Format("[Infraction_T].DriverFirstName_nvc='{0}'  AND Infraction_T.DriverLastName_nvc='{1}' AND DriverNationalCode_bint={2} AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", FirstName, LastName, NationaCode);
                    InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                    if (InfractionList != null && InfractionList.Count > 0)
                    {
                        throw new ApplicationException("جهت ادامه کار به مسئول کامپیوتر مراجعه کنید");
                    }
                    //}
                    #endregion

                    ///

                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                    LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value;
                    HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                    string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64) + "' AND LadBillCredit_T.Canceled_bit=0";
                    List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
                    int LadBillCreditCount = 0;
                    if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                        LadBillCreditCount = LadBillCreditList.Count;

                    ////چک کردن اینکه بار باطل شده است یا نه
                    BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
                    List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelAssignmentList = LadeCancelAssignmentFactory.GetAllBy(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint);
                    int CarCount = (int)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colCarCount_int.Name].Value, TypeCode.Int32);
                    int? CountedCar = 0;
                    if (LadeCancelAssignmentList != null && LadeCancelAssignmentList.Count > 0)
                    {
                        CountedCar = CarCount - LadBillCreditCount - LadeCancelAssignmentList[0].Count_int;
                    }
                    else
                    {
                        CountedCar = CarCount - LadBillCreditCount;
                    }
                    if (CountedCar<=0)
                    {
                        throw new ApplicationException(" بار مورد نظر باطل شده است");
                    }
                    //foreach (Janus.Windows.GridEX.GridEXRow item in AcceptedTurnGridView.GetCheckedRows())
                    //{
                    //    int count = AcceptedTurnGridView.GetCheckedRows().Length;
                    //    if (count > CountedCar)
                    //    {

                    //        throw new ApplicationException("تعداد بارگیرانتخاب شده از تعداد بارگیر مورد نیاز بیشتر می باشد");
                    //    }
                    //}

                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory MultiLaderTypeFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
                    HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T MultiLaderTypeEntity = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                    List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> MultiLaderTypeList = MultiLaderTypeFactory.GetAllBy(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LadeAssignmentID_bint, LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value);
                    if (MultiLaderTypeList != null && MultiLaderTypeList.Count > 0)
                    {
                        HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                        HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeitem = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                        List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
                        int LaderTypeID_int = 0;
                        bool flag = false;
                        //if (AcceptedTurnGridView.GetCheckedRows().Length > 0)
                        //{
                        //    if (AcceptedTurnGridView.CurrentRow.CheckState == Janus.Windows.GridEX.RowCheckState.Checked)
                        //    {
                        LaderTypeID_int = (Int32)AcceptedTurnGridView.CurrentRow.Cells["LaderTypeID_int"].Value;
                        foreach (HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T itm in MultiLaderTypeList)
                        {
                            if (itm.LaderTypeID_int == LaderTypeID_int)
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag == false)
                        {
                            throw new ApplicationException("بارگیر انتخاب شده با نوع بارگیر اطلاع رسانی بار هماهنگ نیست");
                        }
                        //    }
                        //}
                    }
                    if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آيا مايل به تخصيص بار به كاميون مورد نظر مي باشيد") == true)
                    {
                        LadBilFactory.BeginProc();
                        LadBilFactory.Insert(LadBillEntity);
                        LadBilFactory.CommitProc();

                        //////////Print LadbillCreditReport

                        HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys LadBillKey = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys();
                        LadBillKey.LadBillCreditID_int = (Int32)LadBillEntity.LadBillCreditID_int;
                        DataTable LadBillLadeAssignmentDataTable = new DataTable();
                        LadBillCreditFactory.GetAllLadeAssignment(LadBillKey, ref LadBillLadeAssignmentDataTable);
                        Stimulsoft.Report.StiReport LadBillReportstiReport = new Stimulsoft.Report.StiReport();
                        LadBillReportstiReport.Load(Application.StartupPath + "\\LadBillCredit.mrt");
                        LadBillReportstiReport.Dictionary.Synchronize();
                        LadBillReportstiReport.Dictionary.Databases.Clear();
                        LadBillReportstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                        LadBillReportstiReport.Compile();
                        LadBillReportstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString() ;
                        if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["NationalCode_int"].ToString()))
                        {
                            LadBillReportstiReport["NationalCode_int"] = " كدملي راننده: " + LadBillLadeAssignmentDataTable.Rows[0]["NationalCode_int"].ToString();
                        }
                        else
                        {
                            LadBillReportstiReport["NationalCode_int"] = " کدملی راننده:فاقد كارت ";
                        }
                        if (!string.IsNullOrEmpty(LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString()))
                        {
                            LadBillReportstiReport["CarCardNumber_vc"] = " کارت هوشمند کامیون : " + LadBillLadeAssignmentDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                        }
                        else
                        {
                            LadBillReportstiReport["CarCardNumber_vc"] = " کارت هوشمند کامیون :فاقد كارت ";
                        }

                        LadBillReportstiReport["MobileNumber_vc"] = string.Format("موبایل راننده: {0}", LadBillLadeAssignmentDataTable.Rows[0]["DriverMobileNumber_nvc"].ToString());
                        LadBillReportstiReport["Company_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["CompanyID_intCompany_nvc"].ToString() + "(" + LadBillLadeAssignmentDataTable.Rows[0]["CompanyCode_nvc"].ToString() + ")" + "(" + LadBillLadeAssignmentDataTable.Rows[0]["Phone_nvc"].ToString() + ")"; //Cmp_nvc
                        LadBillReportstiReport["LaderType_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["LaderTypeID_intLaderType_nvc"].ToString();
                        LadBillReportstiReport["Boxing_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["BoxingID_intBoxingType_nvc"].ToString(); //LaderType
                        LadBillReportstiReport["PlateNumber_nvc"] = Hepsa.Core.Common.PersentationController.CorrectNumberPlate(LadBillLadeAssignmentDataTable.Rows[0]["NumberPlate_nvc"].ToString()) + " - " + LadBillLadeAssignmentDataTable.Rows[0]["PlateCity_nvc"].ToString() + LadBillLadeAssignmentDataTable.Rows[0]["SerialPlate_nvc"].ToString(); //Plaque
                        LadBillReportstiReport["DriverName_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["DriverName"].ToString(); //Driver
                        LadBillReportstiReport["LicenceNumber_bint"] = (LadBillLadeAssignmentDataTable.Rows[0]["licenceNumber_int"] != DBNull.Value ? Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["licenceNumber_int"]) : 0); //LicenceNumber
                        LadBillReportstiReport["LicenceCity_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["LicenceCityID_intCity_nvc"].ToString(); //LicenceCity
                        LadBillReportstiReport["Good_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["GoodID_intGood_nvc"].ToString(); //Good
                        LadBillReportstiReport["Date_vc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadingDate_nvc"].ToString(); //
                        LadBillReportstiReport["Destination_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["CityID_intCity_nvc"].ToString() + "-" + LadBillLadeAssignmentDataTable.Rows[0]["Address_nvc"].ToString();
                        LadBillReportstiReport["PortajeFee_dec"] = LadBillLadeAssignmentDataTable.Rows[0]["PortageFee_dec"].ToString();
                        LadBillReportstiReport["AssignmentComment_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["AssignmentComment_nvc"].ToString();
                        LadBillReportstiReport["Date_vc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadBillDate"].ToString();
                        LadBillReportstiReport["Time_vc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadBillTime"].ToString();
                        LadBillReportstiReport["TurnNumber_bint"] = Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["AcceptedTurnNumber_bint"]);
                        LadBillReportstiReport["LadBillNumber_bint"] = Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["LadBillCreditID_int"]);
                        LadBillReportstiReport["UserName_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["LadBillUser"].ToString();
                        LadBillReportstiReport["PortPlace_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["PortPlaceID_intPortPlaces_nvc"].ToString();
                        LadBillReportstiReport["MinWeight_nvc"] = "از وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MinWeight_dec"];
                        LadBillReportstiReport["MaxWeight_nvc"] = "تا وزن: " + LadBillLadeAssignmentDataTable.Rows[0]["MaxWeight_dec"];
                        LadBillReportstiReport["TrafficNumber_bint"] = Convert.ToInt64(LadBillLadeAssignmentDataTable.Rows[0]["TrafficNumber_bint"]);
                        LadBillReportstiReport["System_nvc"] = LadBillLadeAssignmentDataTable.Rows[0]["System_nvc"].ToString();
                        LadBillReportstiReport["NationalCode_int"] = LadBillLadeAssignmentDataTable.Rows[0]["NationalCode_int"].ToString();
                        HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessage_TFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                        IList<BLL.BillMessageBLL.BLLBillMessage_T> BillMessage_TList = new List<BLL.BillMessageBLL.BLLBillMessage_T>();
                        string Condition = string.Format("TrafficType_T.TrafficTypeID_int=9 AND [BillMessage_T].StartDate_nvc<='{0}' AND [BillMessage_T].[EndDate_nvc]>='{0}' ", BillMessage_TFactory.ServerJalaliDate);
                        BillMessage_TList = BillMessage_TFactory.GetAllByCondition(Condition);
                        if (BillMessage_TList != null && BillMessage_TList.Count > 0)
                        {
                            LadBillReportstiReport["BillMessage_nvc"] = BillMessage_TList[0].Message_nvc;
                        }

                        if (LadBillLadeAssignmentDataTable.Rows[0]["LadeDate"].ToString().CompareTo(LadBillCreditFactory.ServerJalaliDate) < 0)
                        {
                            LadBillReportstiReport["Remained_bit"] = true;
                        }
                        else
                            LadBillReportstiReport["Remained_bit"] = false;


                        LadBillReportstiReport["Again_bit"] = false;
                        LadBillReportstiReport.Render();
                        Properties.Settings s = new HPS.Properties.Settings();
                        System.Drawing.Printing.PrinterSettings PrinterSetting = new System.Drawing.Printing.PrinterSettings();
                        if (string.IsNullOrEmpty(s.PrinterName))
                        {
                            LadBillReportstiReport.PrinterSettings.Copies = 2;
                            LadBillReportstiReport.Print(true);

                        }
                        else
                        {
                            LadBillReportstiReport.PrinterSettings.Copies = 2;
                            PrinterSetting.PrinterName = s.PrinterName;
                            PrinterSetting.Copies = 2;
                            LadBillReportstiReport.Print(false, PrinterSetting);
                        }
                        //HPS.Reports.ReportDoc.LadBillReport rpt = new HPS.Reports.ReportDoc.LadBillReport((Int32)LadBillEntity.LadBillCreditID_int, 0);
                        //rpt.Document.Printer.PrinterName = string.Empty;
                        //rpt.Document.Printer.PaperSize.Height = 14;
                        //rpt.Document.Printer.PaperSize.Width = 17;
                        //rpt.Run();
                        //rpt.Document.Printer.PrinterSettings.Copies = 3;
                        //Properties.Settings s = new HPS.Properties.Settings();
                        //if (string.IsNullOrEmpty(s.PrinterName))
                        //{
                        //    rpt.Document.Print(true, true, true);
                        //}
                        //else
                        //{
                        //    rpt.Document.Printer.PrinterName = s.PrinterName;
                        //    rpt.Document.Print(false, true, true);
                        //}

                    }
                    //}

                    this.LoadLadeAssignment();
                    AcceptedTurnGridView.SetDataBinding(null, "LadeAssignmentDataTable");
                    TurnNumberTextBox.Text = string.Empty;
                    TrafficNumberTextBox.Text = string.Empty;
                    TurnDateTextBox.Text = string.Empty;
                    NumberPlateTextBox.Text = string.Empty;
                    TrafficNumberTextBox.Focus();
                    LaderTypeGridView.DataSource = null;
                }
                LadBillCredittoolStripButton.Enabled = true;
                AcceptedTurnGridView.SetDataBinding(null, "LadeAssignmentDataTable");
                TrafficNumberTextBox.Focus();
            }

            catch (Exception ex)
            {
                LadBilFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private int CarCount = 0;

        private void LadBillCreditGridView_RowCheckStateChanged(object sender, Janus.Windows.GridEX.RowCheckStateChangeEventArgs e)
        {
            if (this.LadeAssignmentGridView.SelectedRows.Count < 1)
            {
                e.Row.BeginEdit();
                e.Row.CheckState = e.OldCheckState;
                e.Row.EndEdit();
                Hepsa.Core.Common.MessageBox.InformationMessage("اطلاع رسانی بار انتخاب نشده است");
                return;
            }
            if (AcceptedTurnGridView.CurrentRow == null)
            {
                e.Row.BeginEdit();
                e.Row.CheckState = e.OldCheckState;
                e.Row.EndEdit();
                return;
            }
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
            LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value;
            HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            string condition = "LadBillCredit_T.LadeAssignmentID_bint='" + Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64) + "' AND LadBillCredit_T.Canceled_bit=0";
            List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
            int LadBillCreditCount = 0;
            if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                LadBillCreditCount = LadBillCreditList.Count;
            HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
            List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelAssignmentList = LadeCancelAssignmentFactory.GetAllBy(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint);
            int CarCount = (int)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells[colCarCount_int.Name].Value, TypeCode.Int32);
            int? CountedCar = 0;
            if (LadeCancelAssignmentList != null && LadeCancelAssignmentList.Count > 0)
            {
                CountedCar = CarCount - LadBillCreditCount - LadeCancelAssignmentList[0].Count_int;
            }
            else
            {
                CountedCar = CarCount - LadBillCreditCount;
            }
            try
            {
                //if (LadeCancelAssignmentList != null && LadeCancelAssignmentList.Count > 0)
                //{
                foreach (Janus.Windows.GridEX.GridEXRow item in AcceptedTurnGridView.GetCheckedRows())
                {
                    int count = AcceptedTurnGridView.GetCheckedRows().Length;
                    if (count > CountedCar)
                    {
                        e.Row.BeginEdit();
                        e.Row.CheckState = e.OldCheckState;
                        e.Row.EndEdit();
                        throw new ApplicationException("تعداد بارگیرانتخاب شده از تعداد بارگیر مورد نیاز بیشتر می باشد");
                    }

                }

                HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory MultiLaderTypeFactory = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TFactory();
                HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T MultiLaderTypeEntity = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> MultiLaderTypeList = MultiLaderTypeFactory.GetAllBy(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LadeAssignmentID_bint, LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value);
                if (MultiLaderTypeList != null && MultiLaderTypeList.Count > 0)
                {
                    HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                    HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                    HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeitem = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                    List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeLst = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
                    int LaderTypeID_int = 0;
                    bool flag = false;
                    if (AcceptedTurnGridView.CurrentRow.CheckState == Janus.Windows.GridEX.RowCheckState.Checked)
                    {
                        LaderTypeID_int = (Int32)e.Row.Cells["LaderTypeID_int"].Value;
                        foreach (HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T itm in MultiLaderTypeList)
                        {
                            if (itm.LaderTypeID_int == LaderTypeID_int)
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag == false)
                        {
                            e.Row.BeginEdit();
                            e.Row.CheckState = e.OldCheckState;
                            e.Row.EndEdit();
                            throw new ApplicationException("بارگیر انتخاب شده با نوع بارگیر اطلاع رسانی بار هماهنگ نیست");
                        }

                        /*if (MultiLaderTypeList.Exists(itm => itm.LaderTypeID_int == LaderTypeID_int) == false)
                        {
                            e.Row.BeginEdit();
                            e.Row.CheckState = e.OldCheckState;
                            e.Row.EndEdit();
                            throw new ApplicationException("بارگیر انتخاب شده با نوع بارگیر اطلاع رسانی بار هماهنگ نیست");
                        }*/
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }



        }

        private void LadBillCreditGridView_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.LadeAssignmentGridView.CurrentRow == null)
            //{
            //    return;
            //}
            //if (LadBillCreditGridView.CurrentRow==null)
            //{
            //    return;
            //}
            //HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
            //LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells["LadeAssignmentID_bint"].Value;
            //HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
            //List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint);
            //int LadBillCreditCount = 0;
            //if (LadBillCreditList != null && LadBillCreditList.Count > 0)
            //    LadBillCreditCount = LadBillCreditList.Count;
            //HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory LadeCancelAssignmentFactory = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TFactory();
            //List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> LadeCancelAssignmentList = LadeCancelAssignmentFactory.GetAllBy(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint, LadeAssignmentKey.LadeAssignmentID_bint);
            //int CarCount = (int)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LadeAssignmentGridView.CurrentRow.Cells["CarCount_int"].Value, TypeCode.Int32);
            //if (LadeCancelAssignmentList.Count > 0 && LadeCancelAssignmentList != null)
            //{
            //    int? CountedCar = CarCount - LadBillCreditCount - LadeCancelAssignmentList[0].Count_int;
            //    try
            //    {
            //        if (LadeCancelAssignmentList != null && LadeCancelAssignmentList.Count > 0)
            //        {
            //            //foreach (Janus.Windows.GridEX. item in LadBillCreditGridView.SelectedItems)
            //            //{
            //                int count = LadBillCreditGridView.SelectedItems.Count;
            //                if (count > CountedCar)
            //                {
            //                    throw new ApplicationException("تعداد بارگیر اانتخاب شده از تعداد بارگیر مورد نیاز بیشتر می باشد");
            //                }
            //            //}
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            //    }

            //}
        }

        private void LadeAssignmentGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (LadeAssignmentGridView.CurrentRow == null)
                {
                    return;
                }
                DataGridViewCellStyle cellstyle = new DataGridViewCellStyle();
                cellstyle.SelectionBackColor = System.Drawing.Color.DarkGray;
                if (LadeAssignmentGridView.SelectedRows.Count == 1)
                {
                    LadeAssignmentGridView.DefaultCellStyle = cellstyle;
                }
                if (LadeAssignmentGridView.SelectedRows.Count > 1)
                {
                    //e.Row.BeginEdit();
                    //e.Row.CheckState = e.OldCheckState;
                    //e.Row.EndEdit();
                    throw new ApplicationException("اطلاع رسانی بار نمی تواند بیشتر از یک مورد انتخاب شود");
                    return;

                }


                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1004;
                string CompareDate = string.Empty;
                SettingEntity = SettingFactory.GetBy(SettingKey);

                //if (SettingFactory.ServerJalaliDate.CompareTo(CompareDate) > 0)
                //{
                //    throw new ApplicationException("امکان اختصاص اطلاع رسانی بار پس از " + SettingEntity.Value_nvc + "ساعت وجود ندارد");
                //}

                HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
                HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T LadeAssignmentCacelRequestEntity = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();
                List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> List = LadeAssignmentCacelRequestFactory.GetAllBy(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint, Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64));
                if (List != null && List.Count > 0)
                {
                    LadeAssignmentEdittoolStripButton.Enabled = true;
                }
                else
                    LadeAssignmentEdittoolStripButton.Enabled = false;
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadBillCreditListForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                if (LadBillCredittoolStripButton.Visible)
                {
                    LadBillCredittoolStripButton.PerformClick();
                }
            }
            if (e.KeyCode == Keys.F8)
            {
                RefreshButton.PerformClick();
            }
        }

        private void PrinterChooseStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings s = new HPS.Properties.Settings();
                s.PrinterName = dlg.PrinterSettings.PrinterName;
                s.Save();
            }
        }

        private void TurnNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(TurnNumberTextBox.Text))
                    {
                        HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                        DataTable DataTable = new DataTable();
                        InfractionFactory.GetInfaraction(Convert.ToInt64(TurnNumberTextBox.Text), null, string.Empty, String.Empty, ref DataTable);
                        if (DataTable != null)
                        {
                            if (DataTable.Rows.Count > 0)
                            {
                                AcceptedTurnGridView.DataSource = null;
                                throw new ApplicationException("ناوگان متخلف است");
                            }
                        }

                        #region
                        string FirstName = string.Empty;
                        string LastName = string.Empty;
                        Int64? NationaCode = null;
                        string NumberPlate = string.Empty;
                        string SerialPlate = string.Empty;
                        string PlateCityCode = string.Empty;

                        if (AcceptedTurnGridView.GetCheckedRows().Length >= 1)
                        {

                            FirstName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["FirstName_nvc"].Value, TypeCode.String));
                            LastName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["LastName_nvc"].Value, TypeCode.String));
                            NationaCode = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NationalCode_int"].Value, TypeCode.Int64));
                            NumberPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NumberPlate_nvc"].Value, TypeCode.String));
                            SerialPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["SerialPlate_nvc"].Value, TypeCode.String));
                            PlateCityCode = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["PlateCityCode_nvc"].Value, TypeCode.String));

                            // HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                            string InfractionCondition = string.Format("[Infraction_T].NumberPlate_nvc='{0}'  AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}' AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", NumberPlate, SerialPlate, PlateCityCode);
                            List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                            if (InfractionList != null && InfractionList.Count > 0)
                            {
                                throw new ApplicationException("ناوگان متخلف است");
                            }

                            InfractionCondition = string.Format("[Infraction_T].DriverFirstName_nvc='{0}'  AND Infraction_T.DriverLastName_nvc='{1}' AND DriverNationalCode_bint={2} AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", FirstName, LastName, NationaCode);
                            InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                            if (InfractionList != null && InfractionList.Count > 0)
                            {
                                throw new ApplicationException("جهت ادامه کار به مسئول کامپیوتر مراجعه کنید");
                            }
                        }
                        #endregion
                        Search();
                        TrafficNumberTextBox.Focus();
                        this.RaiseKeyDownEvent = false;
                    }
                    else
                        AcceptedTurnGridView.SetDataBinding(null, "");
                }

                if (e.Control && e.KeyCode == Keys.D)
                {
                    this.Groups.get_Item("LadeAssignmentGroup").FilterTextBosFocus();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadeAssignmentGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                TrafficNumberTextBox.Focus();
            }
        }

        private void Search()
        {
            try
            {
                AcceptedTurnGridView.SetDataBinding(null, null);
                TurnStatus();
                DataTable TrafficDataTable = new DataTable();
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                TrafficFactory.SelectTurnAcceptedWithoutLadBill(ref TrafficDataTable, TurnNumberTextBox.Text, TrafficNumberTextBox.Text, NumberPlateTextBox.Text, SerialPlateTextBox.Text, Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(TurnDateTextBox), "", "");
                if (TrafficDataTable.Rows.Count > 0)
                {
                    if ((bool)TrafficDataTable.Rows[TrafficDataTable.Rows.Count - 1]["DriverOffline_bit"])
                    {
                        try
                        {
                            ////Check if it was offline and check from main db
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                            CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                            CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                            CardCheckingLogEntity.DriverCardNumber_nvc = TrafficDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                            CardCheckingLogEntity.CarCardNumber_nvc = TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                            CardCheckingLogEntity.OperationType_nvc = "ارسال";
                            CardCheckingLogEntity.AcceptTurn_bit = false;
                            CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                            CardCheckingLogFactory.Insert(CardCheckingLogEntity);

                            GetDriverAndTruckInformation(TrafficDataTable.Rows[0]["NationalCode_int"].ToString(),
                               TrafficDataTable.Rows[0]["FirstName_nvc"].ToString(),
                               TrafficDataTable.Rows[0]["LastName_nvc"].ToString(),
                               (Int64)TrafficDataTable.Rows[0]["NationalCode_int"],
                               TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString(),
                               TrafficDataTable.Rows[0]["NumberPlate_nvc"].ToString(),
                               TrafficDataTable.Rows[0]["SerialPlate_nvc"].ToString());

                            if (ChechActiveCare == false || ChechActiveDriver == false)
                            { return; }
                            this.AcceptedTurnGridView.SetDataBinding(TrafficDataTable, "TrafficDataTable");

                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingFoundLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                            CardCheckingFoundLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                            CardCheckingFoundLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                            CardCheckingFoundLogEntity.DriverCardNumber_nvc = TrafficDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                            CardCheckingFoundLogEntity.CarCardNumber_nvc = TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                            CardCheckingFoundLogEntity.OperationType_nvc = "دریافت" + ErrorMessage;
                            CardCheckingFoundLogEntity.AcceptTurn_bit = false;
                            CardCheckingFoundLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            CardCheckingFoundLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                            CardCheckingLogFactory.Insert(CardCheckingFoundLogEntity);
                        }
                        catch (Exception ex)
                        {
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingNotFoundLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                            CardCheckingNotFoundLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                            CardCheckingNotFoundLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                            CardCheckingNotFoundLogEntity.DriverCardNumber_nvc = TrafficDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                            CardCheckingNotFoundLogEntity.CarCardNumber_nvc = TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                            CardCheckingNotFoundLogEntity.OperationType_nvc = " عدم دریافت" + ErrorMessage;
                            CardCheckingNotFoundLogEntity.AcceptTurn_bit = false;
                            CardCheckingNotFoundLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            CardCheckingNotFoundLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                            CardCheckingLogFactory.Insert(CardCheckingNotFoundLogEntity);

                            this.AcceptedTurnGridView.SetDataBinding(TrafficDataTable, "TrafficDataTable");
                            GetDriverAndTruckInformation(TrafficDataTable.Rows[0]["NationalCode_int"].ToString(),
                           TrafficDataTable.Rows[0]["FirstName_nvc"].ToString(),
                           TrafficDataTable.Rows[0]["LastName_nvc"].ToString(),
                           (Int64)TrafficDataTable.Rows[0]["NationalCode_int"],
                           TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString(),
                           TrafficDataTable.Rows[0]["NumberPlate_nvc"].ToString(),
                           TrafficDataTable.Rows[0]["SerialPlate_nvc"].ToString());
                        }
                    }
                    else
                    {
                        this.AcceptedTurnGridView.SetDataBinding(TrafficDataTable, "TrafficDataTable");
                        
                      int res =  GetDriverAndTruckInformation(TrafficDataTable.Rows[0]["NationalCode_int"].ToString(),
                           TrafficDataTable.Rows[0]["FirstName_nvc"].ToString(),
                           TrafficDataTable.Rows[0]["LastName_nvc"].ToString(),
                           (Int64)TrafficDataTable.Rows[0]["NationalCode_int"],
                           TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString(),
                           TrafficDataTable.Rows[0]["NumberPlate_nvc"].ToString(),
                           TrafficDataTable.Rows[0]["SerialPlate_nvc"].ToString());

                        bool isApiLimitend = res == -2;

                        // this is is duplicated from above part,
                        // if GetDriverAndTruckInformation return -2, so api limit end and system react like without api. 
                        if ((bool)TrafficDataTable.Rows[TrafficDataTable.Rows.Count - 1]["DriverOffline_bit"] && isApiLimitend)
                        {
                            try
                            {
                                ////Check if it was offline and check from main db
                                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                                CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                                CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                                CardCheckingLogEntity.DriverCardNumber_nvc = TrafficDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                                CardCheckingLogEntity.CarCardNumber_nvc = TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                                CardCheckingLogEntity.OperationType_nvc = "ارسال";
                                CardCheckingLogEntity.AcceptTurn_bit = false;
                                CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                                CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                                CardCheckingLogFactory.Insert(CardCheckingLogEntity);

                                GetDriverAndTruckInformation(TrafficDataTable.Rows[0]["NationalCode_int"].ToString(),
                                   TrafficDataTable.Rows[0]["FirstName_nvc"].ToString(),
                                   TrafficDataTable.Rows[0]["LastName_nvc"].ToString(),
                                   (Int64)TrafficDataTable.Rows[0]["NationalCode_int"],
                                   TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString(),
                                   TrafficDataTable.Rows[0]["NumberPlate_nvc"].ToString(),
                                   TrafficDataTable.Rows[0]["SerialPlate_nvc"].ToString());

                                if (ChechActiveCare == false || ChechActiveDriver == false)
                                { return; }
                                this.AcceptedTurnGridView.SetDataBinding(TrafficDataTable, "TrafficDataTable");

                                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingFoundLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                                CardCheckingFoundLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                                CardCheckingFoundLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                                CardCheckingFoundLogEntity.DriverCardNumber_nvc = TrafficDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                                CardCheckingFoundLogEntity.CarCardNumber_nvc = TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                                CardCheckingFoundLogEntity.OperationType_nvc = "دریافت" + ErrorMessage;
                                CardCheckingFoundLogEntity.AcceptTurn_bit = false;
                                CardCheckingFoundLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                                CardCheckingFoundLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                                CardCheckingLogFactory.Insert(CardCheckingFoundLogEntity);
                            }
                            catch (Exception ex)
                            {
                                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingNotFoundLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                                CardCheckingNotFoundLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                                CardCheckingNotFoundLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                                CardCheckingNotFoundLogEntity.DriverCardNumber_nvc = TrafficDataTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                                CardCheckingNotFoundLogEntity.CarCardNumber_nvc = TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString();
                                CardCheckingNotFoundLogEntity.OperationType_nvc = " عدم دریافت" + ErrorMessage;
                                CardCheckingNotFoundLogEntity.AcceptTurn_bit = false;
                                CardCheckingNotFoundLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                                CardCheckingNotFoundLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                                CardCheckingLogFactory.Insert(CardCheckingNotFoundLogEntity);

                                this.AcceptedTurnGridView.SetDataBinding(TrafficDataTable, "TrafficDataTable");
                                GetDriverAndTruckInformation(TrafficDataTable.Rows[0]["NationalCode_int"].ToString(),
                               TrafficDataTable.Rows[0]["FirstName_nvc"].ToString(),
                               TrafficDataTable.Rows[0]["LastName_nvc"].ToString(),
                               (Int64)TrafficDataTable.Rows[0]["NationalCode_int"],
                               TrafficDataTable.Rows[0]["CarCardNumber_nvc"].ToString(),
                               TrafficDataTable.Rows[0]["NumberPlate_nvc"].ToString(),
                               TrafficDataTable.Rows[0]["SerialPlate_nvc"].ToString());
                            }
                        }

                    }
                }
                else
                {
                    this.AcceptedTurnGridView.SetDataBinding(null, "");
                }
                if (TrafficDataTable.Rows.Count < 1)
                {
                    LadBillCredittoolStripButton.Enabled = false;
                    throw new ApplicationException("ناوگان مورد نظر یافت نشد");
                }

            }
            catch (System.Exception ex)
            {
                LadBillCredittoolStripButton.Enabled = false;
                if (ex.Message == "Unable to connect to the remote server")
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(" ارتباط با سیستم استعلام کارت هوشمند برقرار نیست ");
                }

                else if (ex.Message == "Error processing input" || ex.Message == "Index was outside the bounds of the array.")
                {
                    ErrorMessage_nvc = " شماره کارت راننده یا شماره کارت ماشین در سیستم استعلام کارت هوشمند موجود نمی باشد ";
                    ChechActiveCare = false;
                }
                else
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }


        private void NumberPlateTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AcceptedTurnGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.Groups.get_Item("LadeAssignmentGroup").FilterTextBosFocus();
            }
            if (e.Control && e.KeyCode == Keys.G)
            {
                LadeAssignmentGridView.Focus();
            }
        }

        private void LadeAssignmenToolStrip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                TrafficNumberTextBox.Focus();
            }
        }

        private void TurnDateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(TurnDateTextBox)))
                {
                    Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                    if (FromDateValidator.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(TurnDateTextBox)) == false)
                        throw new ApplicationException(FromDateValidator.Description);
                    Search();
                }
                else
                {
                    this.AcceptedTurnGridView.SetDataBinding(null, "");
                }
                TurnDateTextBox.Focus();
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                this.Groups.get_Item("LadeAssignmentGroup").FilterTextBosFocus();
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
                        HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                        DataTable DataTable = new DataTable();
                        InfractionFactory.GetInfaraction(null, Convert.ToInt64(TrafficNumberTextBox.Text), string.Empty, String.Empty, ref DataTable);
                        if (DataTable != null)
                        {
                            if (DataTable.Rows.Count > 0)
                            {
                                LadBillCredittoolStripButton.Enabled = false;
                                throw new ApplicationException("ناوگان متخلف است");
                            }
                        }
                        ErrorMessage_nvc = string.Empty;
                        Search();

                        if (ErrorMessage_nvc != string.Empty)
                        {
                            LadBillCredittoolStripButton.Enabled = false;
                            throw new ApplicationException(ErrorMessage_nvc);
                        }
                        #region
                        Int32? CarID = null;
                        Int64? DriverID = null;
                        string FirstName = string.Empty;
                        string LastName = string.Empty;
                        Int64? NationaCode = null;
                        string NumberPlate = string.Empty;
                        string SerialPlate = string.Empty;
                        string PlateCityCode = string.Empty;

                        if (AcceptedTurnGridView.CurrentRow != null)
                        {
                            if ((Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["CarID_int"].Value, TypeCode.Int32)) != null)
                            {
                                CarID = (Int32?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["CarID_int"].Value, TypeCode.Int32));
                            }
                            if (AcceptedTurnGridView.CurrentRow.Cells["DriverID_bint"].Value != null)
                            {
                                DriverID = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["DriverID_bint"].Value, TypeCode.Int64));
                            }
                            FirstName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["FirstName_nvc"].Value, TypeCode.String));
                            LastName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["LastName_nvc"].Value, TypeCode.String));
                            NationaCode = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NationalCode_int"].Value, TypeCode.Int64));
                            NumberPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NumberPlate_nvc"].Value, TypeCode.String));
                            SerialPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["SerialPlate_nvc"].Value, TypeCode.String));
                            PlateCityCode = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["PlateCityCode_nvc"].Value, TypeCode.String));

                            //HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                            string InfractionCondition = string.Format("[Infraction_T].NumberPlate_nvc='{0}'  AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}' AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", NumberPlate, SerialPlate, PlateCityCode);
                            List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                            if (InfractionList != null && InfractionList.Count > 0)
                            {
                                LadBillCredittoolStripButton.Enabled = false;
                                throw new ApplicationException("ناوگان متخلف است");
                            }

                            InfractionCondition = string.Format("[Infraction_T].DriverFirstName_nvc='{0}'  AND Infraction_T.DriverLastName_nvc='{1}' AND DriverNationalCode_bint={2} AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", FirstName, LastName, NationaCode);
                            InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                            if (InfractionList != null && InfractionList.Count > 0)
                            {
                                LadBillCredittoolStripButton.Enabled = false;
                                throw new ApplicationException("جهت ادامه کار به مسئول کامپیوتر مراجعه کنید");
                            }
                        }
                        #endregion
                        //TrafficNumberTextBox.Focus();
                        // در اتمام مراحل بدون خطا چاپ فعال شود 
                        LadBillCredittoolStripButton.Enabled = true;

                    }
                    else
                    {
                        this.AcceptedTurnGridView.SetDataBinding(null, "");
                    }
                    LadeAssignmentGridView.Focus();
                }


                if (e.Control && e.KeyCode == Keys.D)
                {
                    this.Groups.get_Item("LadeAssignmentGroup").FilterTextBosFocus();
                }

            }
            catch (Exception ex)
            {
                // در صورت بروز خطا چاپ غیر فعال شود
                LadBillCredittoolStripButton.Enabled = false;
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }


        private void LadeCanelRequesttoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LadeAssignmentGridView.CurrentRow == null)
                {
                    throw new ApplicationException("اطلاع رسانی بار انتخاب نشده است");
                }
                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1004;
                string CompareDate = string.Empty;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                DateTime LadeDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(Convert.ToString(LadeAssignmentGridView.CurrentRow.Cells[colDate_nvc.Name].Value))).MyDate.ToString("yyyy/MM/dd") + " " + Convert.ToString(LadeAssignmentGridView.CurrentRow.Cells[colTime_nvc.Name].Value));
                LadeDate.AddHours(Convert.ToInt32(SettingEntity.Value_nvc));
                CompareDate = new Hepsa.Core.Common.MyDateTime(LadeDate).ConvertToPersianShortDate();
                if (SettingFactory.ServerJalaliDate.CompareTo(CompareDate) > 0)
                {
                    throw new ApplicationException("امکان ثبت درخواست تغییر اطلاع رسانی بار پس از " + SettingEntity.Value_nvc + "ساعت وجود ندارد");
                }
                if (LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value != null && (Int64)LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value != 0)
                {


                    HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory LadeAssignmentCacelRequestFactory = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TFactory();
                    HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T LadeAssignmentCacelRequestEntity = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();
                    List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> List = LadeAssignmentCacelRequestFactory.GetAllBy(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint, Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value, TypeCode.Int64));
                    if (List != null && List.Count > 0)
                    {
                        throw new ApplicationException("قبلاً درخواست ثبت شده است");
                    }

                    else
                    {
                        if (SettingEntity != null)
                        {

                            LadeDate.AddHours(Convert.ToInt32(SettingEntity.Value_nvc));
                            CompareDate = new Hepsa.Core.Common.MyDateTime(LadeDate).ConvertToPersianShortDate();
                        }
                        if (SettingFactory.ServerJalaliDate.CompareTo(CompareDate) > 0)
                        {
                            throw new ApplicationException("امکان تغییر اطلاع رسانی بار پس از " + SettingEntity.Value_nvc + "ساعت وجود ندارد");
                        }
                        else
                        {

                            LadeAssignmentCacelRequestEntity.ResuestDate_nvc = LadeAssignmentCacelRequestFactory.ServerJalaliDate;
                            LadeAssignmentCacelRequestEntity.RequestTime_nvc = LadeAssignmentCacelRequestFactory.ServerTime;
                            LadeAssignmentCacelRequestEntity.RequestUserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            LadeAssignmentCacelRequestEntity.AcceptedDate_nvc = LadeAssignmentCacelRequestFactory.ServerJalaliDate;
                            LadeAssignmentCacelRequestEntity.AcceptedTime_nvc = LadeAssignmentCacelRequestFactory.ServerTime;
                            LadeAssignmentCacelRequestEntity.AcceptedUserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            LadeAssignmentCacelRequestEntity.Comment_nvc = "ثبت درخواست و قبول درخواست از قسمت اعطای مجوز بارگیری";
                            LadeAssignmentCacelRequestEntity.LadeAssignmentID_bint = (Int64)LadeAssignmentGridView.CurrentRow.Cells[colLadeAssignmentID_bint.Name].Value;
                            LadeAssignmentCacelRequestFactory.BeginProc();
                            LadeAssignmentCacelRequestFactory.Insert(LadeAssignmentCacelRequestEntity);
                            if (LadeAssignmentCacelRequestEntity.LadeAssignmentCancelRequestID_int != 0)
                            {
                                LadeAssignmentEdittoolStripButton.Enabled = true;
                            }
                            else
                            {
                                LadeAssignmentEdittoolStripButton.Enabled = false;
                            }
                            LadeAssignmentCacelRequestFactory.CommitProc();
                            Hepsa.Core.Common.MessageBox.InformationMessage("درخواست انصراف از اطلاع رسانی بار ثبت شد");
                        }
                    }
                }
                else
                    throw new ApplicationException("اطلاع رسانی بار انتخاب نشده است");

            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadeAssignmentEdittoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1004;
                string CompareDate = string.Empty;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                if (SettingEntity != null)
                {

                    DateTime LadeDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(Convert.ToString(LadeAssignmentGridView.CurrentRow.Cells[colDate_nvc.Name].Value))).MyDate.ToString("yyyy/MM/dd") + " " + Convert.ToString(LadeAssignmentGridView.CurrentRow.Cells[colTime_nvc.Name].Value));
                    LadeDate.AddHours(Convert.ToInt32(SettingEntity.Value_nvc));
                    CompareDate = new Hepsa.Core.Common.MyDateTime(LadeDate).ConvertToPersianShortDate();
                }
                if (SettingFactory.ServerJalaliDate.CompareTo(CompareDate) > 0)
                {
                    throw new ApplicationException("امکان تغییر اطلاع رسانی بار پس از " + SettingEntity.Value_nvc + "ساعت وجود ندارد");
                }
                else
                {
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                    LadeAssignmentKey.LadeAssignmentID_bint = (Int64?)this.LadeAssignmentGridView.CurrentRow.Cells["colLadeAssignmentID_bint"].Value;
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                    LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKey);
                    bool CanNotChangeCount = false;
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

                        if (LadeCancelList != null && LadeCancelList.Count > 0)
                        {

                            if (remainedLadeAssignmentTable != null && remainedLadeAssignmentTable.Rows.Count > 0)
                            {
                                remaindCount_int = (Int32)remainedLadeAssignmentTable.Rows[remainedLadeAssignmentTable.Rows.Count - 1]["RemainderCount_int"];
                            }
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
                    HPS.Present.LadeAssignment.LadeAssignmentEntityForm LadeAssignment = new HPS.Present.LadeAssignment.LadeAssignmentEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.LadeAssignmentGridView.DataSource, LadeAssignmentKey, CanNotChangeCount, true);
                    LadeAssignment.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void TurnStatus()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable TafficStatusDataTable = new DataTable();
            TrafficFactory.CheckWithLadBillCreditAndTurnStatus(TurnNumberTextBox.Text, TrafficNumberTextBox.Text, NumberPlateTextBox.Text, Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(TurnDateTextBox), TafficStatusDataTable);
            if (TafficStatusDataTable != null && TafficStatusDataTable.Rows.Count >= 1)
            {


                if ((Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["LadBillCreditID_int"], TypeCode.Int32) != null && (Int32)TafficStatusDataTable.Rows[0]["LadBillCreditID_int"] != 0))
                {
                    if ((bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Canceled_bit"], TypeCode.Boolean) == true && (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Turn_bit"], TypeCode.Boolean) == false)//&& (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Return_bit"], TypeCode.Boolean) == false)
                    {
                        throw new ApplicationException("این نوبت همراه مجوز باطل شده است");
                    }
                    else //if ((bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Canceled_bit"], TypeCode.Boolean) == true || ((bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Canceled_bit"], TypeCode.Boolean) == true && (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Turn_bit"], TypeCode.Boolean) == true) )
                        throw new ApplicationException("این نوبت مجوز گرفته است");
                }
                else if (Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["TurnCancelCommantID_int"], TypeCode.Int32) != null && (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TafficStatusDataTable.Rows[0]["Return_bit"], TypeCode.Boolean) == false)
                {
                    throw new ApplicationException("این نوبت باطل شده است");
                }
            }
        }

        private void SerialPlateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(NumberPlateTextBox.Text) && !string.IsNullOrEmpty(SerialPlateTextBox.Text))
                    {
                        HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                        DataTable DataTable = new DataTable();
                        InfractionFactory.GetInfaraction(null, null, NumberPlateTextBox.Text, SerialPlateTextBox.Text, ref DataTable);
                        if (DataTable != null)
                        {
                            if (DataTable.Rows.Count > 0)
                            {
                                throw new ApplicationException("ناوگان متخلف است");
                            }
                        }
                        Search();
                        #region
                        Int32? CarID = null;
                        Int64? DriverID = null;
                        string FirstName = string.Empty;
                        string LastName = string.Empty;
                        Int64? NationaCode = null;
                        string NumberPlate = string.Empty;
                        string SerialPlate = string.Empty;
                        string PlateCityCode = string.Empty;

                        if (AcceptedTurnGridView.GetCheckedRows().Length >= 1)
                        {
                            if ((Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["CarID_int"].Value, TypeCode.Int32)) != null)
                            {
                                CarID = (Int32?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["CarID_int"].Value, TypeCode.Int32));
                            }
                            if (AcceptedTurnGridView.CurrentRow.Cells["DriverID_bint"].Value != null)
                            {
                                DriverID = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["DriverID_bint"].Value, TypeCode.Int64));
                            }
                            FirstName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["FirstName_nvc"].Value, TypeCode.String));
                            LastName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["LastName_nvc"].Value, TypeCode.String));
                            NationaCode = (Int64?)(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NationalCode_int"].Value, TypeCode.Int64));
                            NumberPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["NumberPlate_nvc"].Value, TypeCode.String));
                            SerialPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["SerialPlate_nvc"].Value, TypeCode.String));
                            PlateCityCode = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(AcceptedTurnGridView.CurrentRow.Cells["PlateCityCode_nvc"].Value, TypeCode.String));

                            //HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                            string InfractionCondition = string.Format("[Infraction_T].NumberPlate_nvc='{0}'  AND Infraction_T.SerialPlate_nvc='{1}' AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", NumberPlate, SerialPlate, PlateCityCode);
                            List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                            if (InfractionList != null && InfractionList.Count > 0)
                            {
                                throw new ApplicationException("ناوگان متخلف است");
                            }

                            InfractionCondition = string.Format("[Infraction_T].DriverFirstName_nvc='{0}'  AND Infraction_T.DriverLastName_nvc='{1}' AND DriverNationalCode_bint={2} AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", FirstName, LastName, NationaCode);
                            InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                            if (InfractionList != null && InfractionList.Count > 0)
                            {
                                throw new ApplicationException("جهت ادامه کار به مسئول کامپیوتر مراجعه کنید");
                            }
                        }
                        #endregion
                        NumberPlateTextBox.Focus();
                    }
                    else
                    {
                        this.AcceptedTurnGridView.SetDataBinding(null, "");
                    }
                }

                if (e.Control && e.KeyCode == Keys.D)
                {
                    this.Groups.get_Item("LadeAssignmentGroup").FilterTextBosFocus();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private int GetDriverAndTruckInformation(string NationCode, string FirstName_nvc, string LastName_nvc, Int64 NationalCode_bint, string CarCardNumber_nvc, string NumberPlate_nvc, string SerialPlate_nvc)
        {
            ChechActiveCare = true;
            ChechActiveDriver = true;
            List<object> driverObject = null;
            List<object> carObject = null;

            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1010;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            if (SettingEntity.Value_nvc.ToString() == "1")
            {
                //var webService = new CheckOnlineRefrence.OnlineInformationChecking();
                var webService = new HPS.Common.OnlineInformation();
                //var webService = new WebReference3.OnlineInformationChecking();
                var RecivedObject = webService.GetInformation(NationCode, CarCardNumber_nvc);
                if (RecivedObject != null)
                {
                    driverObject = (List<object>)RecivedObject[0];
                    carObject = (List<object>)RecivedObject[1];
                }

                HPS.BLL.DriverBLL.BLLDriver_T driverEntity = new BLL.DriverBLL.BLLDriver_T();
                HPS.BLL.CarBLL.BLLCar_T carEntity = new BLL.CarBLL.BLLCar_T();

                if (driverObject != null)
                {
                    if (driverObject[0].ToString() == "-2")
                    {
                        return -2;
                    }
                    
                    if (driverObject[8].ToString() == "0")
                    {
                        ErrorMessage = string.Format("کدملی راننده به شماره <{0}>وارد شده در سیستم استعلام کدملی غیر فعال می باشد. جهت رفع مشکل به مسئول مربوطه مراجعه نمایید ", NationCode);
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ErrorMessage);
                        ChechActiveDriver = false;

                        return 0;
                    }
                    if (driverObject[2].ToString() != NationalCode_bint.ToString())
                    {
                        ErrorMessage = ErrorMessage_nvc = "کارت هوشمند متعلق به این راننده نمی باشد";
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ErrorMessage);
                        return 0;
                    }
                
                }

                if (carObject != null)
                {
                    if (carObject[0].ToString() == "-2")
                    {
                        return -2;
                    }
                        if (carObject[0].ToString() == "0")
                        {
                            ErrorMessage = string.Format("کارت هوشمند ناوگان به شماره <{0}> وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مسئول مربوطه مراجعه نمایید ", CarCardNumber_nvc);
                            Hepsa.Core.Common.MessageBox.ErrorMessage(ErrorMessage);
                            ChechActiveCare = false;
                            return 0;
                        }
                        if (!(carObject[1].ToString() == NumberPlate_nvc && carObject[2].ToString() == SerialPlate_nvc))
                        {
                            ErrorMessage = string.Format("اطلاعات کارت هوشمند ناوگان به شماره <{0}> وارد شده در سیستم استعلام کارت هوشمند مغایر یا شماره پلاک می باشد. جهت رفع مشکل به مسئول مربوطه مراجعه نمایید ", CarCardNumber_nvc);
                            Hepsa.Core.Common.MessageBox.ErrorMessage(ErrorMessage);
                            ChechActiveCare = false;
                            return 0;
                        }
                    
                }
            }
            else if (SettingEntity.Value_nvc.ToString() == "0")
            {
                DateEroorList = new List<string>();

                Eroorbuilder = LoadWithCarCardNumber(NationCode, CarCardNumber_nvc);

                //if (DateEroorList != null && DateEroorList.Count > 0)
                //{
                //    throw new ApplicationException("DateEroorList.Aggregate((i, j) => i + j)");
                //}
                if (!string.IsNullOrEmpty(Eroorbuilder.ToString()))
                {
                    throw new ApplicationException(string.Format(Eroorbuilder.ToString()));
                }
            }

            return 1;

        }

        public bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }


        private StringBuilder LoadWithCarCardNumber(string NationCode, string CarCardNumber_nvc)
        {
            List<string> DateEroorList = new List<string>();
            StringBuilder EroorStringBuilder = new StringBuilder();
            int Index = new int();
            Index = 0;
            if (!string.IsNullOrEmpty(NationCode))
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> DriverSpecificationList = DriverSpecificationFactory.GetAllBy(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.NationalCode_int, NationCode);
                //DriverSpecificationList = DriverSpecificationFactory.GetAllByCondition(string.Format(" CarCardNumber_nvc='{0}' ", DriverCardNumber_nvc));
                if (DriverSpecificationList != null && DriverSpecificationList.Count > 0)
                {
                    {
                        //Hepsa.Core.Validation.TodayDateRule lisenceEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("LicenceEnd_nvc", "تاريخ پایان گواهینامه");
                        //if (string.IsNullOrEmpty(DriverSpecificationList[0].LicenceEnd_nvc.ToString()) || lisenceEndTodayDateRule.Validate(DriverSpecificationList[0].LicenceEnd_nvc.ToString()) == false)
                        //{
                        //    DateEroorList.Add(lisenceEndTodayDateRule.FriendlyName  + "\n");
                        //    Index+=1;
                        //    EroorStringBuilder.Append(Index).Append(lisenceEndTodayDateRule.FriendlyName + "\n");
                        //}

                        Hepsa.Core.Validation.NotNullRule DriverCardSharjeStartDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
                        if (string.IsNullOrEmpty(DriverSpecificationList[0].DriverCardSharjeEndDate_nvc.ToString()) || DriverCardSharjeStartDateNotNullRule.Validate(DriverSpecificationList[0].DriverCardSharjeEndDate_nvc.ToString()) == false)
                        {
                            DateEroorList.Add(DriverCardSharjeStartDateNotNullRule.FriendlyName + "\n");
                            Index += 1;
                            EroorStringBuilder.Append(Index).Append(DriverCardSharjeStartDateNotNullRule.FriendlyName + "\n");
                        }

                        Hepsa.Core.Validation.NotNullRule HealthCardEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
                        if (string.IsNullOrEmpty(DriverSpecificationList[0].HealthCardEndDate_nvc.ToString()) || HealthCardEndDateNotNullRule.Validate(DriverSpecificationList[0].HealthCardEndDate_nvc.ToString()) == false)
                        {
                            DateEroorList.Add(HealthCardEndDateNotNullRule.FriendlyName + "\n");
                            Index += 1;
                            EroorStringBuilder.Append(Index).Append(HealthCardEndDateNotNullRule.FriendlyName + "\n");
                        }


                        //Hepsa.Core.Validation.NotNullRule InsuranceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
                        //if (string.IsNullOrEmpty(DriverSpecificationList[0].InsuranceEndDate_nvc.ToString()) || InsuranceEndDateNotNullRule.Validate(DriverSpecificationList[0].InsuranceEndDate_nvc.ToString()) == false)
                        //{
                        //    DateEroorList.Add(InsuranceEndDateNotNullRule.FriendlyName + "\n");
                        //    Index += 1;
                        //    EroorStringBuilder.Append(Index).Append(InsuranceEndDateNotNullRule.FriendlyName + "\n");
                        //}

                        Hepsa.Core.Validation.NotNullRule CarExaminationEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
                        if (string.IsNullOrEmpty(DriverSpecificationList[0].CarExaminationEndDate_nvc.ToString()) || CarExaminationEndDateNotNullRule.Validate(DriverSpecificationList[0].CarExaminationEndDate_nvc.ToString()) == false)
                        {
                            DateEroorList.Add(CarExaminationEndDateNotNullRule.FriendlyName + "\n");
                            Index += 1;
                            EroorStringBuilder.Append(Index).Append(CarExaminationEndDateNotNullRule.FriendlyName + "\n");
                        }

                        //Hepsa.Core.Validation.NotNullRule licenceNumberNotNullRule = new Hepsa.Core.Validation.NotNullRule("licenceNumber_int", "شماره گواهینامه");
                        //if (string.IsNullOrEmpty(DriverSpecificationList[0].licenceNumber_nvc.ToString()) || licenceNumberNotNullRule.Validate(DriverSpecificationList[0].licenceNumber_nvc.ToString()) == false)
                        //{
                        //    DateEroorList.Add(licenceNumberNotNullRule.FriendlyName + "\n");
                        //    Index += 1;
                        //    EroorStringBuilder.Append(Index).Append(licenceNumberNotNullRule.FriendlyName + "\n");
                        //}

                        //////////////add date rule
                        //Hepsa.Core.Validation.DateRule<string> LicenceEndDateRule = new Hepsa.Core.Validation.DateRule<string>("LicenceEnd_nvc", "تاريخ اتمام گواهینامه", null, null);
                        //if (string.IsNullOrEmpty(DriverSpecificationList[0].LicenceEnd_nvc.ToString()) || LicenceEndDateRule.Validate(DriverSpecificationList[0].LicenceEnd_nvc.ToString()) == false)
                        //{
                        //    DateEroorList.Add(LicenceEndDateRule.FriendlyName + "\n");
                        //    Index += 1;
                        //    EroorStringBuilder.Append(Index).Append(LicenceEndDateRule.FriendlyName + "\n");
                        //}



                        //Hepsa.Core.Validation.DateRule<string> InsuranceEndDateaDateRule = new Hepsa.Core.Validation.DateRule<string>("InsuranceEndDate_nvc", "تاريخ اتمام بيمه", null, null);
                        //if (InsuranceEndDateaDateRule.Validate(DriverSpecificationList[0].InsuranceEndDate_nvc.ToString()) == false)
                        //{
                        //    DateEroorList.Add(InsuranceEndDateaDateRule.FriendlyName + "\n");
                        //    Index += 1;
                        //    EroorStringBuilder.Append(Index).Append(InsuranceEndDateaDateRule.FriendlyName + "\n");
                        //}

                        //Hepsa.Core.Validation.DateRule<string> CarExaminationEndDateRule = new Hepsa.Core.Validation.DateRule<string>("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه", null, null);
                        //if (string.IsNullOrEmpty(DriverSpecificationList[0].CarExaminationEndDate_nvc.ToString()) || CarExaminationEndDateRule.Validate(DriverSpecificationList[0].CarExaminationEndDate_nvc.ToString()) == false)
                        //{
                        //    DateEroorList.Add(CarExaminationEndDateRule.FriendlyName + "\n");
                        //    Index += 1;
                        //    EroorStringBuilder.Append(Index).Append(CarExaminationEndDateRule.FriendlyName + "\n");
                        //}



                        BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory1 = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                        var DriverSpecificationTable = new DataTable();
                        //DriverSpecificationFactory1.GetAllByCondition(string.Format(" DriverSpecification_T.DriverCardNumber_nvc='{0}' ", DriverCardNumber_nvc ), ref DriverSpecificationTable);
                        //if (DriverSpecificationTable == null || DriverSpecificationTable.Rows.Count == 0)
                        //{
                        //    DateEroorList.Add("کنترل مدارک راننده ثبت نشده است" + "\n");
                        //    Index += 1;
                        //    EroorStringBuilder.Append(Index).Append("کنترل مدارک راننده ثبت نشده است" + "\n");
                        //}

                        DriverSpecificationTable = new DataTable();
                        DriverSpecificationFactory.GetAllByCondition(string.Format(" DriverSpecification_T.CarCardNumber_nvc='{0}' ", CarCardNumber_nvc), ref DriverSpecificationTable);
                        if (DriverSpecificationTable == null || DriverSpecificationTable.Rows.Count == 0)
                        {
                            DateEroorList.Add("کنترل مدارک ناوگان ثبت نشده است" + "\n");
                            Index += 1;
                            EroorStringBuilder.Append(Index).Append("کنترل مدارک ناوگان ثبت نشده است" + "\n");
                        }
                    }
                }
            }
            return EroorStringBuilder;
        }
    }

}
