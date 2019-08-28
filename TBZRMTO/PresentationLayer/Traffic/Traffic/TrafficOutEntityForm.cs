using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace HPS.Present.TrafficOut
{
    public partial class TrafficOutEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        decimal pricTax = 0;
        private HPS.BLL.TrafficBLL.BLLTraffic_TKeys _TrafficKey;
        HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
        string condition = string.Empty;
        private HPS.BLL.TrafficBLL.BLLTraffic_T _TrafficEntity;
        DataTable VerificationCarTable;
        DataTable TrafficInDatatable;
        DataTable TurnManagementTable;
        DataTable TrafficStatusDataTable;
        private bool fill_bit = true;
        bool CancelTurn_bit = false;
        string ip = string.Empty;
        HPS.Common.PlateReaderApi api = new HPS.Common.PlateReaderApi();

        Image img = null;
        Byte[] szBuffer = new Byte[1000000];

        public TrafficOutEntityForm(HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey)
            : base(null)
        {
            InitializeComponent();
            this._TrafficKey = TrafficKey;
            this._TrafficEntity = null;
        }

        public TrafficOutEntityForm()
            : base(null)
        {
            InitializeComponent();

            this._TrafficKey = null;
            this._TrafficEntity = null;
        }


        private int _TrafficTypeID;
        public int TrafficTypeID
        {
            get
            {
                return _TrafficTypeID;
            }
            set
            {
                _TrafficTypeID = value;
            }
        }
        DataRow[] drin = null;
        protected override void Insert()
        {
            try
            {
                if (this._TrafficEntity == null)
                {
                    throw new HPS.Exceptions.TrafficNotFound();
                }

                TrafficStatusDataTable = new DataTable();
                TrafficFactory.GetLastStatus(_TrafficEntity.NumberPlate_nvc, _TrafficEntity.SerialPlate_nvc, _TrafficEntity.CarCardNumber_nvc, TrafficStatusDataTable);

                #region OUT Conditions
                if ((Int32)_TrafficEntity.ServiceID_int == 2)
                {
                    if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                    {
                        Int64 LastTrafficID_bint = 0;
                        if (Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TrafficID_bint"], TypeCode.Int64) != null)
                        {
                            LastTrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TrafficID_bint"], TypeCode.Int64);
                        }
                        bool? HasTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasTurn_bit"], TypeCode.Boolean);
                        bool? TurnReturn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                        bool? TurnCanceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                        bool? HasLadBillCredit_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasLadBillCredit_bit"], TypeCode.Boolean);
                        bool? LadBillCreditCancel_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                        bool? LadBillCreditTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                        bool? TurnAccepted_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);
                        Int64? AcceptedTurnNumber_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["AcceptedTurnNumber_bint"], TypeCode.Int64);

                        if (HasTurn_bit.HasValue == false || HasTurn_bit == true)
                        {
                            //خروج

                            if (TurnAccepted_bit.HasValue && TurnAccepted_bit == true)
                            {
                                if (TurnCanceled_bit.HasValue && TurnCanceled_bit == true)
                                {
                                    //خروج
                                    this._TrafficEntity.TemporaryOut_bit = false;
                                    this._TrafficEntity.Out_bit = true;
                                }
                                else
                                {
                                    if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                                    {
                                        if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                                        {
                                            if (LadBillCreditTurn_bit.HasValue && LadBillCreditTurn_bit == true)
                                            {
                                                //خروج موقت

                                                BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new BLL.LaderTypeBLL.BLLLaderType_TFactory();
                                                BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new BLL.LaderTypeBLL.BLLLaderType_TKeys();
                                                BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new BLL.LaderTypeBLL.BLLLaderType_T();
                                                LaderTypeKey.LaderTypeID_int = _TrafficEntity.LaderTypeID_int;
                                                LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                                                if (LaderTypeEntity.TurnCancel_bit)
                                                {
                                                    CancelTurn_bit = true;
                                                    this._TrafficEntity.TemporaryOut_bit = false;
                                                    this._TrafficEntity.Out_bit = true;
                                                }
                                                else
                                                {
                                                    this._TrafficEntity.TemporaryOut_bit = true;
                                                    this._TrafficEntity.Out_bit = false;

                                                }
                                            }
                                            else
                                            {
                                                //خروج
                                                this._TrafficEntity.TemporaryOut_bit = false;
                                                this._TrafficEntity.Out_bit = true;
                                            }
                                        }
                                        else
                                        {
                                            //خروج
                                            this._TrafficEntity.TemporaryOut_bit = false;
                                            this._TrafficEntity.Out_bit = true;
                                        }
                                    }
                                    else
                                    //hp>
                                    {
                                        BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new BLL.LaderTypeBLL.BLLLaderType_TFactory();
                                        BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new BLL.LaderTypeBLL.BLLLaderType_TKeys();
                                        BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new BLL.LaderTypeBLL.BLLLaderType_T();
                                        LaderTypeKey.LaderTypeID_int = _TrafficEntity.LaderTypeID_int;
                                        LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                                        if (LaderTypeEntity.TurnCancel_bit)
                                        {
                                            CancelTurn_bit = true;
                                            this._TrafficEntity.TemporaryOut_bit = false;
                                            this._TrafficEntity.Out_bit = true;
                                        }
                                        else
                                        {
                                            this._TrafficEntity.TemporaryOut_bit = true;
                                            this._TrafficEntity.Out_bit = false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //خروج
                                this._TrafficEntity.TemporaryOut_bit = false;
                                this._TrafficEntity.Out_bit = true;
                            }
                        }
                    }
                    else
                    {
                        //خروج
                        this._TrafficEntity.TemporaryOut_bit = false;
                        this._TrafficEntity.Out_bit = true;
                    }
                }
                else
                {
                    // خروج غیر از ثبت نوبت
                    this._TrafficEntity.TemporaryOut_bit = false;
                    this._TrafficEntity.Out_bit = true;
                }
                #endregion
                long TrafficID = _TrafficEntity.TrafficID_bint;

                this._TrafficEntity.TrafficID_bint = 0;
                this._TrafficEntity.Date_nvc = this.Date_nvcTextBox.Text;
                this._TrafficEntity.Time_nvc = this.Time_nvcTextBox.Text;
                this._TrafficEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                this._TrafficEntity.In_bit = false;
                this._TrafficEntity.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.Remainder_decNumericTextBox.NumericText, TypeCode.Decimal);
                this._TrafficEntity.PriceTax_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(pricTax, TypeCode.Decimal);
                #region Infraction
                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                Int32? CarID = null;
                Int64? DriverID = null;
                string FirstName = string.Empty;
                string LastName = string.Empty;
                Int64? NationaCode = null;
                string NumberPlate = string.Empty;
                string SerialPlate = string.Empty;
                string PlateCityCode = string.Empty;

                string InfractionCondition = string.Empty;

                if (TrafficGridView.CurrentRow != null)
                {
                    FirstName = Convert.ToString(TrafficGridView.CurrentRow.Cells["FirstName_nvc"].Value);
                    LastName = Convert.ToString(TrafficGridView.CurrentRow.Cells["LastName_nvc"].Value);
                    NationaCode = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(_TrafficEntity.NationalCode_int, TypeCode.Int64);
                    NumberPlate = Convert.ToString(TrafficGridView.CurrentRow.Cells["NumberPlate_nvc"].Value);
                    SerialPlate = Convert.ToString(TrafficGridView.CurrentRow.Cells["SerialPlate_nvc"].Value);
                    PlateCityCode = Convert.ToString(TrafficGridView.CurrentRow.Cells["PlateCityCode_nvc"].Value);
                    InfractionCondition = string.Format("([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.NumberPlate_nvc='{0}' AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}'", _TrafficEntity.NumberPlate_nvc, _TrafficEntity.SerialPlate_nvc, PlateCityCode);
                    List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                    if (InfractionList != null && InfractionList.Count > 0 && InfractionList[0].Exit_bit)
                    {
                        throw new ApplicationException("ناوگان متخلف است" + "(" + InfractionList[0].CommentControl_nvc + ")");
                        //Hepsa.Core.Common.MessageBox.InformationMessage("ناوگان متخلف است");
                    }
                    InfractionCondition = string.Format("([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.DriverFirstName_nvc='{0}' AND Infraction_T.DriverLastName_nvc='{1}' AND Infraction_T.DriverNationalCode_bint='{2}'", _TrafficEntity.FirstName_nvc, _TrafficEntity.LastName_nvc, _TrafficEntity.NationalCode_int);
                    InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                    if (InfractionList != null && InfractionList.Count > 0)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("جهت ادامه کار به مسئول کامپیوتر مراجعه کنید");
                    }
                    //}
                }
                #endregion

                string conditionTemporaryout = string.Empty;

                //conditionTemporaryout = string.Format("T.TrafficTypeID_int=1 AND T.TrafficNumber_bint={0} ", _TrafficEntity.TrafficNumber_bint);
                //DataTable TempDataTable = new DataTable();
                //TrafficFactory.GetConditionLastTraffic(conditionTemporaryout, ref TempDataTable);
                //if (TempDataTable != null && TempDataTable.Rows.Count > 0)
                //{
                //    if ((bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TempDataTable.Rows[0]["TemporaryOut_bit"], TypeCode.Boolean) == true)
                //    {
                //        throw new ApplicationException("آخرین تردد این ناوگان خروج موقت بوده است");
                //    }
                //}
                if (_TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(_TrafficEntity.BrokenRulesList().ToString());
                }
                //-------------------------------------1394/10/01 برای خروج
                if (string.IsNullOrEmpty(NumberPlate_nvcTextBoxCamera.Text))
                {
                    _TrafficEntity.CameraPlateNumber_nvc = null;
                }
                else
                    _TrafficEntity.CameraPlateNumber_nvc = NumberPlate_nvcTextBoxCamera.Text;

                ////کنترل خوانده شدن پلاک توسط دوربین هنگام خروج برای اینکه صرفا عکس ننداخته باشند
                HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingPictureFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T SettingPictureEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingPictureKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();

                SettingPictureKey.SettingID_int = 1031;
                SettingPictureEntity = SettingPictureFactory.GetBy(SettingPictureKey);
                if (SettingPictureEntity != null && SettingPictureEntity.Value_nvc == "1" && _TrafficEntity.TrafficTypeID_int != 2)
                {
                    if (string.IsNullOrEmpty(NumberPlate_nvcTextBoxCamera.Text))
                    {
                        throw new ApplicationException("شماره پلاک توسط دوربین خوانده نشده است");
                    }

                }

                SettingPictureKey.SettingID_int = 1032;
                SettingPictureEntity = SettingPictureFactory.GetBy(SettingPictureKey);
                if (SettingPictureEntity != null && SettingPictureEntity.Value_nvc == "1" && _TrafficEntity.TrafficTypeID_int != 2)
                {
                    if (NumberPlate_nvcTextBoxCamera.Text != NumberPlate_nvcTextBox.Text)
                    {
                        throw new ApplicationException("شماره پلاک خوانده شده توسط دوربین با شماره پلاک اصلی مغایرت دارد");
                    }
                }

                if (string.IsNullOrEmpty(SerialPlate_nvcTextBoxCamera.Text))
                {
                    _TrafficEntity.CameraSerialPlate_int = null;
                }
                else
                    _TrafficEntity.CameraSerialPlate_int = Convert.ToInt32(SerialPlate_nvcTextBoxCamera.Text);
                //-------------------------------------
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(" مبلغ " + _TrafficEntity.Price_dec + " ريا ل باید از راننده دریافت گردد آیا از ثبت اطلاعات اطمینان دارید؟") == true)
                {
                    TrafficFactory.BeginProc();
                    TrafficFactory.Insert(this._TrafficEntity);
                    SettingPictureKey.SettingID_int = 1013;
                    SettingPictureEntity = SettingPictureFactory.GetBy(SettingPictureKey);

                    //////Insert TrafficPicture
                    if (SettingPictureEntity != null && SettingPictureEntity.Value_nvc == "1")
                    {
                        if (szBuffer != null && szBuffer[0] != 0)
                        {
                            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
                            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
                            TrafficPicturesEntity.TrafficID_bint = _TrafficEntity.TrafficID_bint;
                            TrafficPicturesEntity.Picture_vbnry = szBuffer;
                            TrafficPicturesFactory.Insert(TrafficPicturesEntity);
                        }
                        else
                        {
                            throw new ApplicationException("عملیات گرفتن عکس رخ نداده است");
                        }
                    }


                    if (CancelTurn_bit)
                    {
                        BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                        BLL.TurnManagementBLL.BLLTurnManagement_T TurnManagmentEntity = new BLL.TurnManagementBLL.BLLTurnManagement_T();
                        TurnManagmentEntity.TrafficID_bint = TrafficID;
                        TurnManagmentEntity.Date_nvc = Date_nvcTextBox.Text;
                        TurnManagmentEntity.Time_nvc = Time_nvcTextBox.Text;
                        TurnManagmentEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                        TurnManagmentEntity.Return_bit = false;
                        TurnManagmentEntity.TurnCancelCommantID_int = 48;
                        TurnManagmentEntity.TurnCancelCommment_nvc = "ابطال هنگام خروج";
                        TurnManagementFactory.Insert(TurnManagmentEntity);
                    }
                    this.TrafficNumberTextBox.AutoCompleteCustomSource.Remove(TrafficNumberTextBox.Text);
                    TrafficFactory.CommitProc();
                    CancelTurn_bit = false;
                }

                TrafficNumberTextBox.Text = string.Empty;
                TrafficNumber_bintNumericTextBox.Text = string.Empty;
                NumberPlate_nvcTextBoxCamera.Text = string.Empty;
                SerialPlate_nvcTextBoxCamera.Text = string.Empty;
                TrafficNumberTextBox.Focus();
                TrafficGridView.SetDataBinding(null, "");
                this.ClearForm();
                szBuffer = null;
            }
            catch (Exception ex)
            {
                TrafficFactory.RollBackProc();
                throw ex;
            }
        }

        public void ClearForm()
        {

            try
            {
                this._TrafficEntity = null;
                this.Date_nvcTextBox.Text = TrafficFactory.ServerJalaliDate;
                this.Time_nvcTextBox.Text = TrafficFactory.ServerTime;
                this.UserName_nvcTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                this.TurnNumber_bintNumericTextBox.Clear();
                this.InDate_nvcTextBox.Clear();
                this.InTime_nvcTextBox.Clear();
                this.Driver_nvcTextBox.Clear();
                this.Car_nvcTextBox.Clear();
                this.PlateNo_nvcTextBox.Clear();
                this.Payable_decNumericTextBox.Clear();
                this.Balanced_decNumericTextBox.Clear();
                this.Remainder_decNumericTextBox.Clear();
                TrafficNumber_bintNumericTextBox.Clear();
                TrafficNumberTextBox.Focus();
                pricTax = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TrafficOutEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadTraffic();
                TrafficNumberTextBox.Focus();

                /////========connect to camera
                //axVitaminCtrl1.Url = "http://169.254.199.83";
                //axVitaminCtrl1.ViewStream = VITAMINDECODERLib.EDualStreamOption.eStream1;
                //axVitaminCtrl1.ConnectionProtocol = VITAMINDECODERLib.EConnProtocol.eProtTCP;
                //axVitaminCtrl1.MediaType = VITAMINDECODERLib.EMediaType.eMediaVideo;
                //axVitaminCtrl1.Connect();
                //axVitaminCtrl1.StretchFullScreen = false;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void FillTraffic()
        {

            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
            DataTable LaderTypeDataTable = new DataTable();
            try
            {
                if (this._TrafficEntity == null || this._TrafficEntity.Out_bit == true)
                    throw new HPS.Exceptions.TrafficNotFound();

                this.TrafficNumber_bintNumericTextBox.Text = Convert.ToString(this._TrafficEntity.TrafficNumber_bint);
                this.TurnNumber_bintNumericTextBox.Text = Convert.ToString(this._TrafficEntity.AcceptedTurnNumber_bint);
                this.InDate_nvcTextBox.Text = this._TrafficEntity.Date_nvc;
                this.InTime_nvcTextBox.Text = this._TrafficEntity.Time_nvc;
                this.TurnDate_nvcTextBox.Text = this._TrafficEntity.TurnDate_nvc;
                bool? HasLadBillCredit_bit = null;
                bool? LadBillCreditCancel_bit = null;
                bool? LadBillCreditTurn_bit = null;

                TrafficStatusDataTable = new DataTable();
                TrafficFactory.GetLastStatus(_TrafficEntity.NumberPlate_nvc, _TrafficEntity.SerialPlate_nvc, _TrafficEntity.CarCardNumber_nvc, TrafficStatusDataTable);


                if ((Int32)_TrafficEntity.ServiceID_int == 2)
                {
                    if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                    {
                        Int64 LastTrafficID_bint = 0;
                        if (Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TrafficID_bint"], TypeCode.Int64) != null)
                        {
                            LastTrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TrafficID_bint"], TypeCode.Int64);
                        }
                        //bool? HasTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasTurn_bit"], TypeCode.Boolean);
                        //bool? TurnReturn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                        //bool? TurnCanceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                        HasLadBillCredit_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasLadBillCredit_bit"], TypeCode.Boolean);
                        LadBillCreditCancel_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                        LadBillCreditTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                        //bool? TurnAccepted_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);
                        //Int64? AcceptedTurnNumber_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["AcceptedTurnNumber_bint"], TypeCode.Int64);
                    }
                }


                if (this._TrafficEntity.LaderTypeID_int.HasValue)
                {
                    LaderTypeKey.LaderTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(this._TrafficEntity.LaderTypeID_int.Value, TypeCode.Int32);
                    LaderTypeFactory.GetBy(LaderTypeKey, ref LaderTypeDataTable);
                    if (LaderTypeDataTable != null || LaderTypeDataTable.Rows.Count != 0)
                    {
                        this.Car_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeDataTable.Rows[0]["LaderType_nvc"].ToString(), TypeCode.String));
                    }
                }
                else
                {
                    this.Car_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(_TrafficEntity.System_nvc, TypeCode.String));
                }

                if (string.IsNullOrEmpty(this._TrafficEntity.SerialPlate_nvc))
                {
                    this.PlateNo_nvcTextBox.Text = this._TrafficEntity.NumberPlate_nvc;
                }
                //else
                {
                    this.PlateNo_nvcTextBox.Text = string.Format("{0} -{1}{2}", this._TrafficEntity.NumberPlate_nvc, this._TrafficEntity.PlateType_nvc, this._TrafficEntity.SerialPlate_nvc);
                }
                string stopFeeCondition = string.Empty;
                var stopFeeFactory = new BLL.StopFeeBLL.BLLStopFee_TFactory();
                var oldStopFeeEntity = new BLL.StopFeeBLL.BLLStopFee_T();
                var stopFeeKey = new BLL.StopFeeBLL.BLLStopFee_TKeys();
                var laderTypeEntity = new BLL.LaderTypeBLL.BLLLaderType_T();
                stopFeeKey.StopFeeID_int = _TrafficEntity.StopFeeID_int;
                oldStopFeeEntity = stopFeeFactory.GetBy(stopFeeKey);
                if (_TrafficEntity.TrafficTypeID_int == 1)
                {
                    LaderTypeKey.LaderTypeID_int = _TrafficEntity.LaderTypeID_int;
                    laderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                    string Today = stopFeeFactory.ServerJalaliDate;
                    stopFeeCondition = string.Format(" StartDate_nvc>'{0}' AND StartDate_nvc <= '{1}' AND StopFee_T.TrafficTypeID_int={2} AND StopFee_T.ServicesID_int={3} AND StopFee_T.LaderPivotGroupID_int={4}", oldStopFeeEntity.EndDate_nvc,Today, _TrafficEntity.TrafficTypeID_int, _TrafficEntity.ServiceID_int, laderTypeEntity.LaderPivotGroupID_int);
                    //stopFeeCondition = string.Format("  StartDate_nvc > '{0}' AND StopFee_T.TrafficTypeID_int={1} AND StopFee_T.ServicesID_int={2} AND StopFee_T.LaderPivotGroupID_int={3}", oldStopFeeEntity.EndDate_nvc, _TrafficEntity.TrafficTypeID_int, _TrafficEntity.ServiceID_int, laderTypeEntity.LaderPivotGroupID_int);
                }
                else
                {
                    stopFeeCondition = string.Format(" StartDate_nvc>'{0}' AND StopFee_T.TrafficTypeID_int={1}", oldStopFeeEntity.EndDate_nvc, _TrafficEntity.TrafficTypeID_int);
                }
                var newStopFeeTable = new DataTable();
                stopFeeFactory.GetAllByCondition(stopFeeCondition, ref newStopFeeTable);

                this.Driver_nvcTextBox.Text = string.Format("{0} {1}", this._TrafficEntity.FirstName_nvc, this._TrafficEntity.LastName_nvc);
                Hepsa.Core.Common.MyDateTime InDateTime = new Hepsa.Core.Common.MyDateTime(this.InDate_nvcTextBox.Text);
                Hepsa.Core.Common.MyDateTime OutDateTime = new Hepsa.Core.Common.MyDateTime(this.Date_nvcTextBox.Text);

                string InDate = InDateTime.MyDate.ToString("yyyy/MM/dd");//+ " " + this.InTime_nvcTextBox.Text;
                string OutDate = OutDateTime.MyDate.ToString("yyyy/MM/dd");// + " " + this.Time_nvcTextBox.Text;


                if (InDate.Length == 16)
                    InDate += ":00";
                else if (InDate.Length > 19)
                    InDate = InDate.Substring(0, 19);

                if (OutDate.Length == 16)
                    OutDate += ":00";
                else if (OutDate.Length > 19)
                    OutDate = OutDate.Substring(0, 19);

                HPS.BLL.SettingsBLL.BLLSetting_TFactory TaxSettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_T TaxSettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys TaxSettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                TaxSettingKey.SettingID_int = 1011;
                TaxSettingEntity = TaxSettingFactory.GetBy(TaxSettingKey);
                decimal Price = 0;
                if (oldStopFeeEntity.Tax_bit)
                {
                    Price = _TrafficEntity.Fee_dec * Int32.Parse(TaxSettingEntity.Value_nvc) / 100 + _TrafficEntity.Fee_dec;
                    if (_TrafficEntity.ServiceID_int == 2)
                    {
                        Price = Math.Round((_TrafficEntity.Fee_dec != 0 ? _TrafficEntity.Fee_dec * Int32.Parse(TaxSettingEntity.Value_nvc) / 100 + _TrafficEntity.Fee_dec : 0), 0, MidpointRounding.AwayFromZero);
                    }
                }
                else
                {
                    Price = this._TrafficEntity.Fee_dec;
                    if (_TrafficEntity.ServiceID_int == 2)
                    {
                        Price = Math.Round((_TrafficEntity.Fee_dec != 0 ? _TrafficEntity.Fee_dec : 0), 0, MidpointRounding.AwayFromZero);
                    }
                }
                //TODO: کد موقت تست مبلغ
                Price = this._TrafficEntity.Price_dec.Value;
                string incondition = "Traffic_T.TrafficNumber_bint='" + this.TrafficNumber_bintNumericTextBox.NumericText + "'";
                string Condition = string.Format("Traffic_T.TurnNumber_bint='{0}' And Traffic_T.TrafficNumber_bint<>{1}", this._TrafficEntity.TurnNumber_bint.ToString(), this.TrafficNumber_bintNumericTextBox.NumericText);
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                DataTable TrafficInWithladBillDataTable = new DataTable();
                LadBillFactory.GetAllWithTrafficLadBillCreditByConditon(incondition, ref TrafficInWithladBillDataTable);
                TrafficInDatatable = new DataTable();
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                TurnManagementTable = new DataTable();
                TurnManagementFactory.GetAllByCondition(string.Format(" TurnManagement_T.TrafficID_bint={0} order by TurnManagementID_int desc", _TrafficEntity.TrafficID_bint), ref TurnManagementTable);
                TrafficFactory.GetAllByCondition(Condition, ref TrafficInDatatable);
                HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1001;
                HPS.BLL.SettingsBLL.BLLSetting_T TurnHourSettingEntity = settingsFactory.GetBy(SettingKey);
                if (TrafficInDatatable.Rows.Count > 0)
                {
                    DateTime TrafficDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficInDatatable.Rows[0]["Date_nvc"].ToString())).MyDate.ToString("yyyy/MM/dd") + " " + TrafficInDatatable.Rows[0]["Time_nvc"].ToString());
                    Int32 Allowablehour = Convert.ToInt32(TurnHourSettingEntity.Value_nvc);
                    if (TrafficFactory.ServerDate <= TrafficDate.AddHours(Allowablehour))
                    {
                        if (TrafficInWithladBillDataTable.Rows.Count == 0)
                        {
                            Price = 0;
                        }
                    }
                }

                decimal Balanced = 0;
                TimeSpan ts = new TimeSpan();
                string stopFeeEndDate_nvc = string.Empty;
                Hepsa.Core.Common.MyDateTime stopFeeMiladiEndDate_nvc = null;
                int days = 0;
                #region شامل قیمت جدید می شود
                if (newStopFeeTable != null && newStopFeeTable.Rows.Count > 0)
                {
                    //Hepsa.Core.Common.uMyDateTime stopFeeMiladiEndDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["EndDate_nvc"].ToString());
                    //string stopFeeEndDate_nvc = stopFeeMiladiEndDate_nvc.MyDate.ToString("yyyy/MM/dd");
                    stopFeeMiladiEndDate_nvc = new Hepsa.Core.Common.MyDateTime(oldStopFeeEntity.EndDate_nvc);
                    stopFeeEndDate_nvc = stopFeeMiladiEndDate_nvc.MyDate.ToString("yyyy/MM/dd");
                    ts = DateTime.Parse(stopFeeEndDate_nvc).Subtract(DateTime.Parse(InDate));
                    double ExtraHour = ts.TotalHours;
                    #region اگر دارای نوبت تایید شده است

                    if (Convert.ToBoolean(_TrafficEntity.ServiceID_int == 2))
                    {
                        HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                        //SettingID_int 1002 => مدت اعتبار نوبت جهت اخذ مبلغ بعد از تایید نوبت
                        SettingKey.SettingID_int = 1002;
                        SettingEntity = settingsFactory.GetBy(SettingKey);
                        ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                        ///محاسبه مازاد بر اساس قیمت قبلی از ورود تا شروع قیمت جدید
                        days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                       
                        if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true &&  !(LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit.Value))
                        {
                            if (ExtraHour > 0)
                            {
                                if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                                {
                                    ExtraHour = ts.TotalHours;
                                    ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                    days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                                    Price += Math.Floor(((decimal)(days)) * oldStopFeeEntity.TurnNotLadBillExtraHourFee_dec.Value);
                                }
                                else
                                {
                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(_TrafficEntity.ExtraHourFee_dec));
                                }
                            }
                            else
                                Price += 0;
                        }
                        else if (TurnManagementTable.Rows.Count > 0 && TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] != null && (int)TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] == 57)
                        {
                            if (days >= 0)
                            {
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(_TrafficEntity.ExtraHourFee_dec));
                            }
                            else
                                Price += 0;
                        }
                        else
                        {
                            ExtraHour = ts.TotalHours;
                            
                                ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                            if (days > 0)
                            {
                                Price += Math.Floor(((decimal)(days)) * (oldStopFeeEntity.TurnNotLadBillExtraHourFee_dec.Value));
                            }
                        }



                        Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                        string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");
                        TimeSpan ExtraTS = DateTime.Parse(newStopFeeStartDate_nvc).Subtract(DateTime.Parse(InDate));
                        // Change to NewStopfee.Startdate taaaaa Today
                        double ExtraExtraHour = ExtraTS.TotalHours;
                        if (ExtraExtraHour < Convert.ToDouble(SettingEntity.Value_nvc))
                        {
                            ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                            if (ExtraHour >= 0)
                                ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(InDate));
                            else
                                ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(InDate));


                            ExtraHour = ts.TotalHours - Convert.ToDouble(SettingEntity.Value_nvc);
                            if (ExtraHour > 0)
                            {
                                days = Convert.ToInt32((ExtraHour / Convert.ToInt32(newStopFeeTable.Rows[0]["ExtraHour_int"])));

                                if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                                {
                                    if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                                    {
                                        ExtraHour = ts.TotalHours;
                                        ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                        days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                                        Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["TurnNotLadBillExtraHourFee_dec"]));
                                    }
                                    else
                                    {
                                        Price += Math.Floor((Convert.ToDecimal((days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"])));
                                    }
                                }
                                else if (TurnManagementTable.Rows.Count > 0 && TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] != null && (int)TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] == 57)
                                {
                                    Price += Math.Floor((Convert.ToDecimal((days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"])));
                                }
                                else
                                {
                                    ExtraHour = ts.TotalHours;
                                    ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                    days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                                    if (days > 0)
                                    {
                                        if(!this._TrafficEntity.Date_nvc.Equals("1398/05/31"))
                                            days -= 1;
                                        Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["TurnNotLadBillExtraHourFee_dec"]));
                                    }
                                }
                            }
                            // کد موقت
                            else if (ExtraTS.Days > 1 && ExtraExtraHour < Convert.ToDouble(SettingEntity.Value_nvc))
                            {
                                if (HasLadBillCredit_bit == false)
                                {
                                    Price += Convert.ToDecimal(newStopFeeTable.Rows[0]["TurnNotLadBillExtraHourFee_dec"]);
                                }
                                else if(HasLadBillCredit_bit == null)
                                {
                                    Price += Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"]);
                                }


                            }
                            //TODO : کد موقت برای اینکه در این تاریخ که پایان حق پارکینگ قدیمی است
                            // یک روز کمتر حق پارکینگ حساب میکرد
                            else if (Price == this._TrafficEntity.Price_dec.Value && this._TrafficEntity.Date_nvc.Equals("1398/05/31") && HasLadBillCredit_bit != true)
                            {
                                TimeSpan _ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                                days = _ts.Days;
                                if(days > 0)
                                    Price += days * Convert.ToDecimal(newStopFeeTable.Rows[0]["TurnNotLadBillExtraHourFee_dec"]);
                            }
                        }
                        else
                        {
                            //|| this._TrafficEntity.Date_nvc.Equals("1398/05/28")
                            ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                            if (ExtraHour > 0)
                                ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                            else if (this._TrafficEntity.Date_nvc.Equals("1398/05/28") && HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit.Value)
                            {
                                ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                            }
                            else
                                ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));

                            ExtraHour = ts.TotalHours;
                            if (ExtraHour > 0)
                            {
                                days = Convert.ToInt32((ExtraHour / Convert.ToInt32(newStopFeeTable.Rows[0]["ExtraHour_int"])));

                                if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                                {
                                    if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                                    {
                                        ExtraHour = ts.TotalHours;
                                        // این زمان یکبار در مرحله قبل کم شده است نباید مجددا حذف شود.
                                        //ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                        days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));

                                        Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["TurnNotLadBillExtraHourFee_dec"]));
                                    }
                                    else
                                    {
                                        Price += Math.Floor((Convert.ToDecimal((days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"])));
                                    }
                                }
                                else if (TurnManagementTable.Rows.Count > 0 && TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] != null && (int)TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] == 57)
                                {
                                    Price += Math.Floor((Convert.ToDecimal((days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"])));
                                }
                                else
                                {
                                    ExtraHour = ts.TotalHours;
                                    //ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                    days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));

                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["TurnNotLadBillExtraHourFee_dec"]));
                                }

                            }
                        }
                    }
                    #endregion

                    #region نوبت ندارد، از نوع پارکینگ است یا ...
                    else
                    {
                        


                            if (Convert.ToDecimal(_TrafficEntity.ExtraHourFee_dec) != 0)
                            {
                            ///محاسبه مازاد بر اساس قیمت قبلی از ورود تا شروع قیمت جدید

                               // if (HasLadBillCredit_bit == null || HasLadBillCredit_bit == false)
                               // {
                                  //  ExtraHour = ts.TotalHours - Convert.ToDouble(24);
                               // }
                               // else
                               // {
                                    ExtraHour = ts.TotalHours - Convert.ToDouble(_TrafficEntity.AllowableHour_int);
                               // }
                                if (ExtraHour > 0)
                                {
                                    days = Convert.ToInt32((ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int)));
                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(_TrafficEntity.ExtraHourFee_dec));

                                    ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                                    Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                                    string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");
                                    ts = DateTime.Parse(OutDate).AddDays(1).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));
                                    ExtraHour = ts.TotalHours;
                                    days = (int)(ExtraHour / (int)newStopFeeTable.Rows[0]["ExtraHour_int"]);
                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"]));
                                }
                                else
                                {
                                    ///محاسبه مازاد از شروع تاریخ قیمت جدید تا تاریخ خروج
                                    Hepsa.Core.Common.MyDateTime stopFeeMiladiStartDate_nvc = new Hepsa.Core.Common.MyDateTime(newStopFeeTable.Rows[0]["StartDate_nvc"].ToString());
                                    string newStopFeeStartDate_nvc = stopFeeMiladiStartDate_nvc.MyDate.ToString("yyyy/MM/dd");

                                    ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(newStopFeeStartDate_nvc));

                                    //افزودن 24 ساعت بدلیل اینکه باید روز اغاز قیمت جدید نیز
                                    // یک روز حساب شده و کسر مبلغ شود

                                    ExtraHour = ts.TotalHours;
                                    TimeSpan T = DateTime.Parse(newStopFeeStartDate_nvc).Subtract(DateTime.Parse(InDate));
                                    if (T.Days > 1)
                                    {
                                        ExtraHour += 24;
                                    }

                                    days = days = (int)(ExtraHour / (int)newStopFeeTable.Rows[0]["ExtraHour_int"]);
                                    Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(newStopFeeTable.Rows[0]["ExtraHourFee_dec"]));
                                }
                            }
                        
                    }
                    #endregion
                }
                #endregion

                #region محاسبه با قیمت قدیم
               
                else
                {
                    ts = DateTime.Parse(OutDate).Subtract(DateTime.Parse(InDate));
                    double ExtraHour = 0;

                    //if (ts.TotalHours >= this._TrafficEntity.AllowableHour_int)
                    //{
                    if (this._TrafficEntity.TurnAccepted_bit.HasValue && this._TrafficEntity.TurnAccepted_bit.Value == true)
                    {
                        //if (ExtraHour > 0)
                        //{ 
                        if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                        {
                            // اگر مجوز بارگیری لغو شده است
                            // پس باید با تعرفه پارکینگ حساب شود
                            if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                            {
                                ExtraHour = ts.TotalHours;
                                // جلوگیری از منفی شدن ساعت اضافه و روز
                                if (ExtraHour > 0)
                                {
                                    ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                                }
                                days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));

                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(oldStopFeeEntity.TurnNotLadBillExtraHourFee_dec.Value));
                            }
                            else
                            {
                                ExtraHour = ts.TotalHours;
                                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                                SettingKey.SettingID_int = 1002;
                                SettingEntity = settingsFactory.GetBy(SettingKey);
                                if (_TrafficEntity.Price_dec != 0)
                                {
                                    ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                                }
                                days = (int)(ExtraHour / this._TrafficEntity.ExtraHour_int);
                                if (days > 0)
                                {
                                    Price += Math.Floor((Convert.ToDecimal((days)) * _TrafficEntity.ExtraHourFee_dec));

                                }
                                else
                                    Price += 0;
                            }
                        }
                        else if (TurnManagementTable.Rows.Count > 0 && TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] != null && (int)TurnManagementTable.Rows[0]["TurnCancelCommantID_int"] == 57)
                        {
                            ExtraHour = ts.TotalHours;
                            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                            SettingKey.SettingID_int = 1002;
                            SettingEntity = settingsFactory.GetBy(SettingKey);
                            if (_TrafficEntity.Price_dec != 0)
                            {
                                ExtraHour -= Convert.ToDouble(SettingEntity.Value_nvc);
                            }
                            days = (int)(ExtraHour / this._TrafficEntity.ExtraHour_int);
                            if (days > 0)
                            {
                                Price += Math.Floor((Convert.ToDecimal((days)) * _TrafficEntity.ExtraHourFee_dec));

                            }
                            else
                                Price += 0;
                        }
                        else
                        {
                            ExtraHour = ts.TotalHours;
                            ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                            days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                            if (days > 0)
                            {
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(oldStopFeeEntity.TurnNotLadBillExtraHourFee_dec.Value));
                            }
                        }

                    }
                    else
                    {
                        if (_TrafficEntity.ServiceID_int.Value == 2)
                        {
                            ExtraHour = ts.TotalHours;
                            ExtraHour -= Convert.ToDouble(oldStopFeeEntity.TurnNotLadBillExtraHour_int.Value);
                            days = (int)(ExtraHour / Convert.ToInt32(_TrafficEntity.ExtraHour_int));
                            if (days > 0)
                            {
                                Price += Math.Floor(((decimal)(days)) * Convert.ToDecimal(oldStopFeeEntity.TurnNotLadBillExtraHourFee_dec.Value));

                            }

                        }
                        else if (_TrafficEntity.ExtraHourFee_dec != 0)
                        {

                            ExtraHour = ts.TotalHours - (double)this._TrafficEntity.AllowableHour_int;
                            days = (int)(ExtraHour / this._TrafficEntity.ExtraHour_int);
                            if (days > 0)
                            {
                                Price += Math.Floor(((decimal)(days)) * this._TrafficEntity.ExtraHourFee_dec);
                            }
                        }
                    }

                    //}
                }
                #endregion

                Price = Convert.ToDecimal(RoundNumber(Convert.ToDouble(Price)));
                Balanced = Convert.ToDecimal(RoundNumber(Convert.ToDouble(Balanced)));
                if (this._TrafficEntity.Price_dec.HasValue)
                    Balanced = this._TrafficEntity.Price_dec.Value;

                this.Payable_decNumericTextBox.Text = Convert.ToString(Price);//+ Balanced
                this.Balanced_decNumericTextBox.Text = Convert.ToString(Balanced);
                if (Price == Balanced)
                {
                    this.Remainder_decNumericTextBox.Text = "0";
                }
                else
                {
                    pricTax = 0;
                    if (oldStopFeeEntity.Tax_bit)
                    {
                        this.Remainder_decNumericTextBox.Text = Convert.ToString((Price - Balanced));//
                        pricTax = (Price - Balanced) * Int32.Parse(TaxSettingEntity.Value_nvc) / 100;
                    }
                    else
                        this.Remainder_decNumericTextBox.Text = Convert.ToString((Price - Balanced));//
                }
                if ((Price - Balanced) < 0)
                {
                    pricTax = 0;
                    if (oldStopFeeEntity.Tax_bit)
                    {
                        this.Remainder_decNumericTextBox.Text = Convert.ToString((Price));
                        pricTax = (Price) * Int32.Parse(TaxSettingEntity.Value_nvc) / 100;
                    }
                    else
                        this.Remainder_decNumericTextBox.Text = Convert.ToString((Price));
                }

                ////check verified cars
                BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifyCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();
                VerificationCarTable = new DataTable();

                BLL.VerifiedCarsBLL.BLLVerifiedCars_T VerifiedCarsEntity = new BLL.VerifiedCarsBLL.BLLVerifiedCars_T();
                VerifyCarsFactory.GetAllByCondition(string.Format(" NumberPlate_nvc='{0}' AND SerialPlate_nvc='{1}' ", _TrafficEntity.NumberPlate_nvc, _TrafficEntity.SerialPlate_nvc), ref VerificationCarTable);
                if (VerificationCarTable.Rows.Count > 0)
                {
                    if (VerificationCarTable.Rows[0]["Date_vc"] != DBNull.Value && VerificationCarTable.Rows[0]["Date_vc"].ToString() == VerifyCarsFactory.ServerJalaliDate)
                    {
                        Payable_decNumericTextBox.Text = "0";
                        this.Balanced_decNumericTextBox.Text = "0";
                        Remainder_decNumericTextBox.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        private double RoundNumber(double number)
        {
            number = Math.Round(number);

            if (number > 5000)
            {
                double khord = number % 5000;
                if (khord == 0)
                {
                    return number;
                }
                else if (khord > 0 && khord < 2499)
                {
                    return number - khord;
                }
                else if (khord > 2500 && khord < 5000)
                {
                    return number - khord + 5000;
                }
                else
                {
                    return number;
                }
            }
            else
            {
                return number;
            }
        }
        private void PlateNo_nvcTextBox_Leave(object sender, EventArgs e)
        {
        }

        private void LoadTraffic()
        {

            DataTable CarTrafficDatatable = new DataTable();
            string TrafficCondition = "";
        }

        private void TrafficGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.ClearForm();
                if (TrafficGridView.CurrentRow == null)
                {
                    return;
                }

                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint, (Int64)this.TrafficGridView.CurrentRow.Cells["TrafficID_bint"].Value);
                if (TrafficList == null || TrafficList.Count == 0 || TrafficList[TrafficList.Count - 1].Out_bit == true)
                    throw new HPS.Exceptions.TrafficNotFound();
                this._TrafficEntity = TrafficList[0];

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }
        private void CheckTrafficLadbillCredit()
        {
            DataTable CarTrafficDatatable = new DataTable();
            string TrafficCondition = "LadBillCredit = 0 and TrafficTypeID_int = 1 and ServiceID_int = 2   AND TrafficNumber_bint =" + TrafficNumberTextBox.Text;

            //TrafficFactory.SelectByConditionSelectionTraffic(TrafficCondition, ref CarTrafficDatatable);
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
            if (CarTrafficDatatable.Rows.Count > 0)
            {
                MessageBox.Show("ناوگان فاقد مجوز می باشد هر دو برگ تحویل متصدی گردد");
            }

        }

        private void TrafficNumbertxt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {

                    fill_bit = false;
                    SearchByTrafficNumber();
                    TrafficNumberTextBox.Focus();
                    this.RaiseKeyDownEvent = false;

                    //for Auto select value after Read from Barcode
                    TrafficNumberTextBox.SelectAll();
                    CheckTrafficLadbillCredit();
                }

                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                {
                    TrafficGridView.SetDataBinding(null, "");
                    this.ClearForm();
                    Date_nvcTextBox.Text = string.Empty;
                    Time_nvcTextBox.Text = string.Empty;
                    TurnDate_nvcTextBox.Text = string.Empty;
                    UserName_nvcTextBox.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {
                //TrafficNumberTextBox.Focus();
                //TrafficNumberTextBox.SelectAll();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                TrafficNumberTextBox.Focus();
                this.RaiseKeyDownEvent = false;
                TrafficNumberTextBox.SelectAll();
            }
        }

        private void NumberPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void SerialPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    fill_bit = false;
                    SearchByNumberPlateAndSerialPlate();
                }
                if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                {

                    TrafficGridView.SetDataBinding(null, "");
                    this.ClearForm();
                    Date_nvcTextBox.Text = string.Empty;
                    Time_nvcTextBox.Text = string.Empty;
                    TurnDate_nvcTextBox.Text = string.Empty;
                    UserName_nvcTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AllOutbutton_Click(object sender, EventArgs e)
        {
            HPS.Present.Traffic.AllOutForm frm = new HPS.Present.Traffic.AllOutForm();
            frm.ShowDialog();
            LoadTraffic();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TrafficNumber_bintNumericTextBox.Text))
            {
                SearchByTrafficNumber();
            }
            else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
            {
                SearchByNumberPlateAndSerialPlate();
            }
        }


        private void SearchByTrafficNumber()
        {
            NumberPlate_nvcTextBox.Text = string.Empty;
            SerialPlate_nvcTextBox.Text = string.Empty;

            Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumberRule", "شماره قبض", 1, null, null, 0);
            if (NumericValidator.Validate(TrafficNumberTextBox.Text) == false)
            {
                throw new ApplicationException(NumericValidator.Description);
            }

            DataTable CarTrafficDatatable = new DataTable();
            if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
            {
                string Conditiontrafficnumber = string.Empty;
                Conditiontrafficnumber = "(t1.TrafficNumber_bint='" + TrafficNumberTextBox.Text + "')";
                TrafficFactory.GetAllByConditionAllInForOutTraffic(Conditiontrafficnumber, ref CarTrafficDatatable);
                TrafficGridView.SetDataBinding(CarTrafficDatatable, "CarTrafficDatatable");
                this.ClearForm();

                if (CarTrafficDatatable.Rows.Count >= 1)
                {
                    List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint, (Int64)CarTrafficDatatable.Rows[0]["TrafficID_bint"]);
                    if (TrafficList == null || TrafficList.Count == 0 || TrafficList[TrafficList.Count - 1].Out_bit == true)
                        throw new HPS.Exceptions.TrafficNotFound();
                    this._TrafficEntity = TrafficList[0];
                    this.FillTraffic();
                    TrafficNumberTextBox.Focus();

                }

                else
                    throw new ApplicationException("موردی با مشخصات فوق یافت نشد");

            }
        }

        private void SearchByNumberPlateAndSerialPlate()
        {

            string TrafficCondition = string.Empty;

            if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
            {
                TrafficCondition = "([T1].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "') AND ([T1].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "')";
            }
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            DataTable CarTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllInForOutTraffic(TrafficCondition, ref CarTrafficDatatable);
            this.ClearForm();
            TrafficGridView.SetDataBinding(CarTrafficDatatable, "CarTrafficDatatable");
            if (CarTrafficDatatable.Rows.Count >= 1)
            {
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint, (Int64)CarTrafficDatatable.Rows[0]["TrafficID_bint"]);
                if (TrafficList == null || TrafficList.Count == 0 || TrafficList[TrafficList.Count - 1].Out_bit == true)
                    throw new HPS.Exceptions.TrafficNotFound();
                this._TrafficEntity = TrafficList[0];
                this.FillTraffic();
                TrafficNumberTextBox.Focus();
            }
            else
                throw new ApplicationException("موردی با مشخصات فوق یافت نشد");
        }

        private async void NumberPlateReadingButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number = string.Empty;
                NumberPlateReadingButton.Enabled = false;
                snapshot();
                //   number = anprService.GetPlateNumberByByte(szBuffer);
                number = await api.GetNumberPlate(szBuffer);
                NumberPlateReadingButton.Enabled = true;
                //number = "56ع87615";
                if (!string.IsNullOrEmpty(number))
                {
                    HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new BLL.TruePlate.ConvertToTrueNumber();
                    string plateNumber_nvc = string.Empty;
                    string plateSerial_nvc = string.Empty;
                    //number = " 1234567u15";
                    NumberPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 9));
                    SerialPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(10, 2));
                }
                else
                {
                    NumberPlate_nvcTextBoxCamera.Text = string.Empty;
                    SerialPlate_nvcTextBoxCamera.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void snapshot()
        {
            try
            {
                try
                {
                    HttpWebRequest reqs = (HttpWebRequest)WebRequest.Create("http://" + ip + "/onvif/snapshot.cgi");

                    reqs.Timeout = 4000;
                    reqs.Credentials = new NetworkCredential("admin", "8495162");
                    reqs.PreAuthenticate = true;
                    HttpWebResponse resp = (HttpWebResponse)reqs.GetResponse();
                    if (resp != null)
                    {
                        Stream stm = resp.GetResponseStream();
                        img = new Bitmap(stm);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            szBuffer = ms.ToArray();
                        }

                        stm.Close();
                    }

                }
                catch (System.Exception ex)
                {
                    throw ex;
                }

            }

            catch (System.Exception ex)
            {
                throw ex;
            }

        }


        private void TrafficOutEntityForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Alt && e.KeyCode==Keys.P)
            if (e.KeyCode == Keys.F7)
            {
                NumberPlateReadingButton.PerformClick();
            }
        }

        public byte[] ConvertImageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void TrafficGridView_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            try
            {
                this.ClearForm();
                if (TrafficGridView.CurrentRow == null)
                {
                    return;
                }

                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint, (Int64)this.TrafficGridView.CurrentRow.Cells["TrafficID_bint"].Value);
                if (TrafficList == null || TrafficList.Count == 0 || TrafficList[TrafficList.Count - 1].Out_bit == true)
                    throw new HPS.Exceptions.TrafficNotFound();
                this._TrafficEntity = TrafficList[0];
                this.FillTraffic();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void Cam1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cam1RadioButton.AutoCheck)
            {
                axVLCPlugin21.Visible = true;
                axVLCPlugin22.Visible = false;
                ////connect to messoa camera

                ip = string.Empty;
                ip = "172.24.129.10";
                axVLCPlugin21.Refresh();
                axVLCPlugin21.playlist.add("rtsp://" + ip + ":554/stream1", null, null);
                axVLCPlugin21.playlist.play();
            }
        }

        private void Cam2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cam2RadioButton.AutoCheck)
            {
                axVLCPlugin21.Visible = false;
                axVLCPlugin22.Visible = true;
                ////connect to messoa camera
                ip = string.Empty;
                ip = "172.24.129.15";
                axVLCPlugin22.Refresh();
                axVLCPlugin22.playlist.add("rtsp://" + ip + ":554/stream1", null, null);
                axVLCPlugin22.playlist.play();
            }
        }

        private void ActiveCameraPlateButton_Click(object sender, EventArgs e)
        {
            NumberPlate_nvcTextBoxCamera.ReadOnly = false;
            SerialPlate_nvcTextBoxCamera.ReadOnly = false;
        }
    }
}
