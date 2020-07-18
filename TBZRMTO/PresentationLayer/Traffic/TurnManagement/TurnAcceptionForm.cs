using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Linq;

namespace HPS.Present.TurnManagement
{
    public partial class TurnAcceptionForm : Hepsa.Core.PL.BaseForm
    {
        private Int64 _TrafficID_bint;
        private DataTable _DataTable;
        private String DriverMobile_nvc;
        private Int32 _TurnHour = 0;
        private Int64 _DriverID_bint = 0;
        private bool DriverOffline_bit = false;
        private bool CarOffline_bit = false;
        private string ErroeMessage = string.Empty;
        private List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList = null;
        private int _DriverSpecificationID = 0;
        private int _CarDriverSpecificationID = 0;
        private bool Print_bit = false;
        private bool? ExpiredTimeAcceptTurn_bit = null;
        private bool ChechActiveDriver = true;
        private bool ChechActiveCare = true;
        private String ErrorMessage_nvc = string.Empty;

        public TurnAcceptionForm(Int64 TrafficID_bint, DataTable dataTable)
            : base()
        {
            InitializeComponent();
            this._TrafficID_bint = TrafficID_bint;
            this._DataTable = dataTable;

        }
        bool _CardReading = false;

        private void IranianTruckEntityForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
            HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
            HPS.BLL.ServicesBLL.BLLServices_TKeys ServicesKey = new HPS.BLL.ServicesBLL.BLLServices_TKeys();
            HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();

            TrafficKey.TrafficID_bint = this._TrafficID_bint;


            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = TrafficFactory.GetBy(TrafficKey);
                if (TrafficEntity == null)
                {
                    throw new HPS.Exceptions.TrafficNotFound();
                }
                LaderTypeKey.LaderTypeID_int = TrafficEntity.LaderTypeID_int;
                LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                FirstName_nvcTextBox.Text = TrafficEntity.FirstName_nvc;
                LastName_nvcTextBox.Text = TrafficEntity.LastName_nvc;
                DriverCardDate_nvcTextBox.Text = TrafficEntity.DriverCardDate_nvc;
                DriverType_nvc.Text = TrafficEntity.DriverType_nvc;
                NationalCode_intNumericTextBox.Text = TrafficEntity.NationalCode_int.ToString();
                //licenceNumber_intNumericTextBox.Text = TrafficEntity.licenceNumber_int.ToString();
                DriverCardNumber_bintNumericTextBox.Text = TrafficEntity.DriverCardNumber_nvc;
                TrafficNumbertextBox.Text = Convert.ToString(TrafficEntity.TrafficNumber_bint);
                CarCardNumber_nvcTextBox.Text = TrafficEntity.CarCardNumber_nvc;
                CarCardDate_nvcTextBox.Text = TrafficEntity.CarCardDate_nvc;
                NumberPlate_nvcTextBox.Text = TrafficEntity.NumberPlate_nvc;
                SerialPlate_nvcTextBox.Text = TrafficEntity.SerialPlate_nvc;
                //
                Mobile_nvcnumericTextBox.Text = TrafficEntity.DriverMobileNumber_nvc;
                //
                ProductionYear_intNumericTextBox.Text = TrafficEntity.ProductionYear_int.ToString();
                System_nvcTextBox.Text = TrafficEntity.System_nvc;
                YearType_nvcTextBox.Text = TrafficEntity.YearType_nvc;

                PlateCityKey.PlateCityID_int = TrafficEntity.PlateCityID_int;

                if (PlateCityKey.PlateCityID_int.HasValue)
                {
                    HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);
                    if (PlateCityEntity != null)
                    {
                        PlateCityID_intTextBox.Text = PlateCityEntity.PlateCity_nvc;
                        PlateCityCode_nvcTextBox.Text = PlateCityEntity.PlateCityCode_nvc;
                    }
                }
                ServicesKey.ServicesID_int = TrafficEntity.ServiceID_int;
                HPS.BLL.ServicesBLL.BLLServices_T ServiceEntity = ServicesFactory.GetBy(ServicesKey);
                if (ServiceEntity != null)
                    ServicesID_intTextBox.Text = ServiceEntity.ServicesType_nvc;



                if (LaderTypeEntity != null)
                {
                    LaderTypeID_intTextBox.Text = LaderTypeEntity.LaderType_nvc;
                    LaderTypeCode_nvcTextBox.Text = LaderTypeEntity.LaderTypeCode_nvc;
                }
                WithLade_bitRadioButton.Checked = TrafficEntity.WithLade_bit;
                WithFlatRadioButton.Checked = TrafficEntity.WithFlat_bit;
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
                if (TrafficEntity.LaderTypeID_int != null && TrafficEntity.LaderTypeID_int != 0)
                {
                    LaderTypeKey.LaderTypeID_int = TrafficEntity.LaderTypeID_int;
                    LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                    if (LaderTypeEntity == null)
                    {
                        throw new ApplicationException("نوع بارگیر خالی است");
                    }
                    // StopFeeList = this.GetStopFee(TrafficFactory.ServerJalaliDate, LaderTypeEntity.LaderPivotGroupID_int, TrafficEntity.ServiceID_int);
                }
                //if (StopFeeList != null && StopFeeList.Count > 0)
                //{
                //    Price_decNumericTextBox.Text = Convert.ToString(StopFeeList[0].Fee_dec);
                //}

                Comment_nvcTextBox.Text = TrafficEntity.Comment_nvc;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void TurnAccepted_bitButton_Click(object sender, EventArgs e)
        {
            Print_bit = true;
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            if (ChechActiveDriver == false || ChechActiveCare == false)
            {
                //ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مدیریت پایانه بار مراجعه نمایید ", DriverCardNumber_bintNumericTextBox.Text);
                //Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                return;
            }
            try
            {
                ExpiredTimeAcceptTurn_bit = false;
                AcceptTurnConditionCheck();
            }
            catch (Exception ex)
            {
                TrafficFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private List<string> ControlRules()
        {
            List<string> DateEroorList = new List<string>();

            Hepsa.Core.Validation.TodayDateRule lisenceEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("LicenceEnd_nvc", "تاريخ پایان گواهینامه");
            if (lisenceEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
            {
                DateEroorList.Add(lisenceEndTodayDateRule.Description + "\n");
            }

            Hepsa.Core.Validation.TodayDateRule DriverCardSharjeStartTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
            if (DriverCardSharjeStartTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(DriverCardSharjeStartTodayDateRule.Description + "\n");
            }

            Hepsa.Core.Validation.TodayDateRule HealthCardEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
            if (HealthCardEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(HealthCardEndTodayDateRule.Description + "\n");
            }


            Hepsa.Core.Validation.TodayDateRule InsuranceEndTodayDate_nvcRule = new Hepsa.Core.Validation.TodayDateRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
            if (InsuranceEndTodayDate_nvcRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(InsuranceEndTodayDate_nvcRule.Description + "\n");
            }

            Hepsa.Core.Validation.TodayDateRule CarExaminationEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
            if (CarExaminationEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(CarExaminationEndTodayDateRule.Description + "\n");
            }

            ////////////add not null rule
            Hepsa.Core.Validation.NotNullRule lisenceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("LicenceEnd_nvc", "تاريخ پایان گواهینامه");
            if (lisenceEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
            {
                DateEroorList.Add(lisenceEndDateNotNullRule.Description + "\n");
            }

            Hepsa.Core.Validation.NotNullRule DriverCardSharjeStartDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
            if (DriverCardSharjeStartDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(DriverCardSharjeStartDateNotNullRule.Description + "\n");
            }

            Hepsa.Core.Validation.NotNullRule HealthCardEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
            if (HealthCardEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(HealthCardEndDateNotNullRule.Description + "\n");
            }


            Hepsa.Core.Validation.NotNullRule InsuranceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
            if (InsuranceEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(InsuranceEndDateNotNullRule.Description + "\n");
            }

            Hepsa.Core.Validation.NotNullRule CarExaminationEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
            if (CarExaminationEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(CarExaminationEndDateNotNullRule.Description + "\n");
            }

            Hepsa.Core.Validation.NotNullRule licenceNumberNotNullRule = new Hepsa.Core.Validation.NotNullRule("licenceNumber_int", "شماره گواهینامه");
            if (licenceNumberNotNullRule.Validate(licenceNumber_intNumericTextBox.NumericText) == false)
            {
                DateEroorList.Add(licenceNumberNotNullRule.Description + "\n");
            }

            ////////////add date rule
            Hepsa.Core.Validation.DateRule<string> LicenceEndDateRule = new Hepsa.Core.Validation.DateRule<string>("LicenceEnd_nvc", "تاريخ اتمام گواهینامه", null, null);
            if (LicenceEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
            {
                DateEroorList.Add(LicenceEndDateRule.Description + "\n");
            }

            Hepsa.Core.Validation.DateRule<string> DriverCardSharjeStartDateRule = new Hepsa.Core.Validation.DateRule<string>("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند", null, null);
            if (DriverCardSharjeStartDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(DriverCardSharjeStartDateRule.Description + "\n");
            }

            Hepsa.Core.Validation.DateRule<string> HealthCardEndDateRule = new Hepsa.Core.Validation.DateRule<string>("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت", null, null);
            if (HealthCardEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(HealthCardEndDateRule.Description + "\n");
            }

            Hepsa.Core.Validation.DateRule<string> InsuranceEndDateaDateRule = new Hepsa.Core.Validation.DateRule<string>("InsuranceEndDate_nvc", "تاريخ اتمام بيمه", null, null);
            if (InsuranceEndDateaDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(InsuranceEndDateaDateRule.Description + "\n");
            }

            Hepsa.Core.Validation.DateRule<string> CarExaminationEndDateRule = new Hepsa.Core.Validation.DateRule<string>("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه", null, null);
            if (CarExaminationEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
            {
                DateEroorList.Add(CarExaminationEndDateRule.Description + "\n");
            }


            var DriverSpecificationFactory = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            var DriverSpecificationTable = new DataTable();
            DriverSpecificationFactory.GetAllByCondition(string.Format(" DriverSpecification_T.NationalCode_int='{0}' ", NationalCode_intNumericTextBox.Text), ref DriverSpecificationTable);
            if (DriverSpecificationTable == null || DriverSpecificationTable.Rows.Count == 0)
            {
                DateEroorList.Add("کنترل مدارک راننده ثبت نشده است" + "\n");
            }

            DriverSpecificationTable = new DataTable();
            DriverSpecificationFactory.GetAllByCondition(string.Format(" DriverSpecification_T.CarCardNumber_nvc='{0}' ", CarCardNumber_nvcTextBox.Text), ref DriverSpecificationTable);
            if (DriverSpecificationTable == null || DriverSpecificationTable.Rows.Count == 0)
            {
                DateEroorList.Add("کنترل مدارک ناوگان ثبت نشده است" + "\n");
            }

            return DateEroorList;
        }

        private void ChoosePrinterButton_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings s = new HPS.Properties.Settings();
                s.PrinterName = dlg.PrinterSettings.PrinterName;
                s.Save();
            }
        }

        private void Controlbutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (ChechActiveDriver == false || ChechActiveCare == false)
                {
                    //ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مدیریت پایانه بار مراجعه نمایید ", DriverCardNumber_bintNumericTextBox.Text);
                    //Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                    return;
                }
                List<string> DateEroorList = new List<string>();

                Hepsa.Core.Validation.TodayDateRule lisenceEndDateRule = new Hepsa.Core.Validation.TodayDateRule("LicenceEnd_nvc", "تاريخ اتمام گواهینامه");
                if (lisenceEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
                {
                    DateEroorList.Add(lisenceEndDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.TodayDateRule DriverCardSharjeStartTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
                if (DriverCardSharjeStartTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(DriverCardSharjeStartTodayDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.TodayDateRule HealthCardEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
                if (HealthCardEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(HealthCardEndTodayDateRule.Description + "\n");
                }

                ////////////add not null rule
                Hepsa.Core.Validation.NotNullRule lisenceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("LicenceEnd_nvc", "تاريخ اتمام گواهینامه");
                if (lisenceEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
                {
                    DateEroorList.Add(lisenceEndDateNotNullRule.Description + "\n");
                }

                Hepsa.Core.Validation.NotNullRule DriverCardSharjeStartDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
                if (DriverCardSharjeStartDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(DriverCardSharjeStartDateNotNullRule.Description + "\n");
                }

                Hepsa.Core.Validation.NotNullRule HealthCardEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
                if (HealthCardEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(HealthCardEndDateNotNullRule.Description + "\n");
                }

                Hepsa.Core.Validation.NotNullRule licenceNumberNotNullRule = new Hepsa.Core.Validation.NotNullRule("licenceNumber_int", "شماره گواهینامه");
                if (licenceNumberNotNullRule.Validate(licenceNumber_intNumericTextBox.NumericText) == false)
                {
                    DateEroorList.Add(licenceNumberNotNullRule.Description + "\n");
                }

                ////////////add date rule
                Hepsa.Core.Validation.DateRule<string> LicenceEndDateRule = new Hepsa.Core.Validation.DateRule<string>("LicenceEnd_nvc", "تاريخ اتمام گواهینامه", null, null);
                if (LicenceEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
                {
                    DateEroorList.Add(LicenceEndDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.DateRule<string> DriverCardSharjeStartDateRule = new Hepsa.Core.Validation.DateRule<string>("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند", null, null);
                if (DriverCardSharjeStartDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(DriverCardSharjeStartDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.DateRule<string> HealthCardEndDateRule = new Hepsa.Core.Validation.DateRule<string>("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت", null, null);
                if (HealthCardEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(HealthCardEndDateRule.Description + "\n");
                }

                if (DateEroorList != null && DateEroorList.Count > 0)
                {
                    throw new ApplicationException(DateEroorList.Aggregate((i, j) => i + j));
                }


                DriverInformationSave();


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        protected void DriverInformationSave()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            try
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
                DriverSpecificationEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_bintNumericTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.NationalCode_int = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
                DriverSpecificationEntity.licenceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_intNumericTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.CarExamination_bit = false;
                DriverSpecificationEntity.LicenceEnd_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceEnd_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.Insurance_bit = false;
                DriverSpecificationEntity.InsuranceStartDate_nvc = string.Empty;
                DriverSpecificationEntity.ClassID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(ClassID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverSpecificationEntity.HealthCard_bit = false;
                DriverSpecificationEntity.HealthCardStartDate_nvc = string.Empty;
                DriverSpecificationEntity.HealthCardEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(HealthCardEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.DriverCardSharje_bit = false;
                DriverSpecificationEntity.DriverCardSharjeStartDate_nvc = string.Empty;
                DriverSpecificationEntity.DriverCardSharjeEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardSharjeEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.StatisticCard_bit = false;

                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys driverSpecificationkey = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                if (_DriverSpecificationID != 0)
                {
                    driverSpecificationkey.DriverSpecificationID_int = _DriverSpecificationID;
                    DriverSpecificationFactory.BeginProc();
                    DriverSpecificationFactory.Update(DriverSpecificationEntity, driverSpecificationkey);
                    DriverSpecificationFactory.CommitProc();
                    Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                }
                else
                {
                    DriverSpecificationFactory.BeginProc();
                    DriverSpecificationFactory.Insert(DriverSpecificationEntity);
                    DriverSpecificationFactory.CommitProc();
                    Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                }

            }
            catch (Exception ex)
            {
                DriverSpecificationFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void NationalCode_intNumericTextBox_Leave(object sender, EventArgs e)
        {
            string DriverCondition = string.Empty;
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
            //if (this._CardReading)
            //    return;
            //if (WithoutCardcheckBox.Checked == false)
            //{
            string TurnNumberCondition = string.Empty;
            try
            {
                CheckOnlineCardNumber();
                LoadWithDriverCardNumber();
                LoadWithCarCardNumber();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            //}
        }

        //private void DriverCardNumber_bintNumericTextBox_Leave(object sender, EventArgs e)
        //{
        //    string DriverCondition = string.Empty;
        //    HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
        //    DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
        //    //if (this._CardReading)
        //    //    return;
        //    //if (WithoutCardcheckBox.Checked == false)
        //    //{
        //    string TurnNumberCondition = string.Empty;
        //    try
        //    {
        //        CheckOnlineCardNumber();
        //        LoadWithDriverCardNumber();
        //        LoadWithCarCardNumber();
        //    }
        //    catch (Exception ex)
        //    {
        //        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
        //    }
        //    //}
        //}

        private void DriverCardReadingButton_Click(object sender, EventArgs e)
        {
            if (this._CardReading)
                return;

            try
            {
                //HPS.Common.CardReader.OmniKey.Driver DriverCardReader = new HPS.Common.CardReader.OmniKey.Driver();
                //this._CardReading = true;
                //DriverCardReader.Read();

                //DriverCardNumber_bintNumericTextBox.Text = DriverCardReader.CardNo;
                //FillDriver();

                //DriverFromcard = true;


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            finally
            {
                this._CardReading = false;
            }
        }

        private void TurnAcceptionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                InTrafficPictureShowButton.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                ShowSpecificationButton.PerformClick();
                CarInfoShowButton.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                TurnAccepted_bitWithoutPrintButton.PerformClick();
            }

            if (e.KeyCode == Keys.F12)
            {
                TurnAccepted_bit_bitButton.PerformClick();
            }
            if (e.KeyCode == Keys.F8)
            {
                ChoosePrinterButton.PerformClick();
            }

            if (e.KeyCode == Keys.F6)
            {
                AcceptTimeExpiredTurnsButton.PerformClick();
            }
            if (e.KeyCode == Keys.PageDown)
            {
                PreviousButton.PerformClick();
            }
            if (e.KeyCode == Keys.PageUp)
            {
                NextButton.PerformClick();
            }
        }

        private void ClearDriver()
        {
            DriverCardNumber_bintNumericTextBox.Text = string.Empty;
            DriverCardDate_nvcTextBox.Text = string.Empty;
            NationalCode_intNumericTextBox.Text = string.Empty;
            licenceNumber_intNumericTextBox.Text = string.Empty;
            DriverType_nvc.Text = string.Empty;
            FirstName_nvcTextBox.Text = string.Empty;
            LastName_nvcTextBox.Text = string.Empty;
            Mobile_nvcnumericTextBox.Text = string.Empty;
        }

        //private void FillDriver()
        //{
        //    try
        //    {
        //        string DriverCondition = string.Empty;
        //        HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
        //        DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
        //        DriverCondition = "([Driver_T].[NationalCode_int]='" + NationalCode_intNumericTextBox.Text + "') ";
        //        DriverList = DriverFactory.GetAllByCondition(DriverCondition);

        //        if (DriverList.Count == 1)
        //        {
        //            DriverFields();
        //        }
        //        else
        //        {

        //            HPS.Present.SearchForm.DriverSearch frm = new HPS.Present.SearchForm.DriverSearch();
        //            DriverList.Clear();
        //            if (frm.ShowDialog() != DialogResult.Cancel)
        //            {

        //                DriverList.Add(frm.SelectedDriver);
        //                DriverFields();
        //            }
        //            else
        //            {
        //                ClearForm();
        //            }
        //        }

        //        if (NationalCode_intNumericTextBox.Text != "" && DriverList.Count == 0)
        //        {
        //            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
        //            string tCondition = "([Traffic_T].[NationalCode_int]='" + NationalCode_intNumericTextBox.Text + "') AND ([Traffic_T].[In_bit]='true')";
        //            List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(tCondition);
        //            if (TrafficList != null && TrafficList.Count > 0)
        //            {
        //                DriverCardNumber_bintNumericTextBox.Text = TrafficList[TrafficList.Count - 1].DriverCardNumber_nvc;
        //                DriverCardDate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].DriverCardDate_nvc;
        //                NationalCode_intNumericTextBox.Text = Convert.ToString(TrafficList[TrafficList.Count - 1].NationalCode_int);
        //                //licenceNumber_intNumericTextBox.Text = Convert.ToString(TrafficList[TrafficList.Count - 1].licenceNumber_int);
        //                DriverType_nvc.Text = TrafficList[TrafficList.Count - 1].DriverType_nvc;
        //                FirstName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].FirstName_nvc;
        //                LastName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LastName_nvc;

        //            }
        //            else
        //            {
        //                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "راننده با مشخصات"));
        //                NationalCode_intNumericTextBox.Focus();
        //            }
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
        //    }

        //}

        private void DriverFields()
        {
            if (DriverList != null && DriverList.Count >= 1)
            {
                if (DriverList[0].DriverID_bint != 0)
                {
                    if (DriverList[0].Active_bit == false)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("اين راننده توسط مديريت غير فعال شده است");
                    }
                    DriverCardNumber_bintNumericTextBox.Text = DriverList[0].DriverCardNumber_nvc;
                    FirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                    LastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                    DriverCardDate_nvcTextBox.Text = DriverList[0].DriverCardDate_nvc;
                    DriverType_nvc.Text = DriverList[0].DriverType_nvc;
                    NationalCode_intNumericTextBox.Text = Convert.ToString(DriverList[0].NationalCode_int);
                    //licenceNumber_intNumericTextBox.Text = Convert.ToString(DriverList[0].licenceNumber_nvc);
                }


            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "راننده با مشخصات"));
                DriverCardNumber_bintNumericTextBox.Focus();
            }
        }

        public void ClearForm()
        {
            this.ClearForm(this);


            DriverList = null;

            bool _CardReading = false;

        }

        private void WithoutCardcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DriverList != null && DriverList.Count > 0)
            {
                DriverList.Clear();
            }
            if (WithoutCardcheckBox.Checked == true)
            {
                NationalCode_intNumericTextBox.Enabled = false;
                DriverCardDate_nvcTextBox.Enabled = false;
                NationalCode_intNumericTextBox.Focus();
                NationalCode_intNumericTextBox.Enabled = true;
                licenceNumber_intNumericTextBox.Enabled = true;

                FirstName_nvcTextBox.Enabled = true;
                LastName_nvcTextBox.Enabled = true;
                NationalCode_intNumericTextBox.Focus();
                DriverType_nvc.Enabled = true;
                ClearDriver();
            }
            else if (WithoutCardcheckBox.Checked == false)
            {
                NationalCode_intNumericTextBox.Enabled = true;
                DriverCardDate_nvcTextBox.Enabled = false;
                NationalCode_intNumericTextBox.Enabled = false;
                licenceNumber_intNumericTextBox.Enabled = false;
                DriverType_nvc.Enabled = false;
                FirstName_nvcTextBox.Enabled = false;
                LastName_nvcTextBox.Enabled = false;
                NationalCode_intNumericTextBox.Focus();
                ClearDriver();
            }
        }

        private long? _CurrentTrafficNumber = null;

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                TrafficFactory.PreviousTurnNavigation(this._CurrentTrafficNumber, TrafficNavigationDataTable);
                if (TrafficNavigationDataTable != null && TrafficNavigationDataTable.Rows.Count > 0)
                {

                    this._CurrentTrafficNumber = (long?)TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"];
                    List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this._CurrentTrafficNumber);
                    NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NumberPlate_nvc"], TypeCode.String));
                    CarCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardDate_nvc"], TypeCode.String));
                    CarCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardNumber_nvc"], TypeCode.String));
                    SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["SerialPlate_nvc"], TypeCode.String));
                    System_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                    LaderTypeID_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderType_nvc"], TypeCode.String));
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderTypeCode_nvc"], TypeCode.String));
                    ProductionYear_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["ProductionYear_int"], TypeCode.Int32));
                    YearType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["YearType_nvc"], TypeCode.String));
                    PlateCityID_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityID_intPlateCity_nvc"], TypeCode.String));
                    PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityCode_nvc"], TypeCode.String));
                    ServicesID_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["ServiceID_intServiceType_nvc"], TypeCode.String));
                    //Price_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));
                    TrafficNumbertextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"], TypeCode.Int64));
                    DriverCardNumber_bintNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardNumber_nvc"], TypeCode.String));
                    FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                    LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                    NationalCode_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NationalCode_int"], TypeCode.Int64));
                    //licenceNumber_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["licenceNumber_int"], TypeCode.Int64));
                    DriverCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardDate_nvc"], TypeCode.String));
                    List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
                    HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                    HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                    if (TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"] != null && (Int32)TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"] != 0)
                    {
                        HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                        LaderTypeKey.LaderTypeID_int = (Int32?)TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"];
                        LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                        if (LaderTypeEntity == null)
                        {
                            throw new ApplicationException("نوع بارگیر خالی است");
                        }
                        //StopFeeList = this.GetStopFee(TrafficFactory.ServerJalaliDate, LaderTypeEntity.LaderPivotGroupID_int, (Int32?)TrafficNavigationDataTable.Rows[0]["ServiceID_int"]);
                        //if (StopFeeList != null && StopFeeList.Count > 0)
                        //{
                        //    Price_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal));
                        //}
                    }
                }
                else
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage("تردد جاری اولین مورداست");

                }
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                TrafficFactory.NextTurnNavigation(this._CurrentTrafficNumber, TrafficNavigationDataTable);
                if (TrafficNavigationDataTable != null && TrafficNavigationDataTable.Rows.Count > 0)
                {

                    this._CurrentTrafficNumber = (long?)TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"];
                    List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this._CurrentTrafficNumber);

                    NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NumberPlate_nvc"], TypeCode.String));
                    CarCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardDate_nvc"], TypeCode.String));
                    CarCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardNumber_nvc"], TypeCode.String));
                    SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["SerialPlate_nvc"], TypeCode.String));
                    System_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                    LaderTypeID_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderType_nvc"], TypeCode.String));
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderTypeCode_nvc"], TypeCode.String));
                    ProductionYear_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["ProductionYear_int"], TypeCode.Int32));
                    YearType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["YearType_nvc"], TypeCode.String));
                    PlateCityID_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityID_intPlateCity_nvc"], TypeCode.String));
                    PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityCode_nvc"], TypeCode.String));
                    ServicesID_intTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["ServiceID_intServiceType_nvc"], TypeCode.String));
                    TrafficNumbertextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"], TypeCode.Int64));
                    DriverCardNumber_bintNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardNumber_nvc"], TypeCode.String));
                    FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                    LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                    NationalCode_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NationalCode_int"], TypeCode.Int64));
                    //licenceNumber_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["licenceNumber_int"], TypeCode.Int64));
                    DriverCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardDate_nvc"], TypeCode.String));
                    HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                    HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                    List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
                    if (TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"] != null && (Int32)TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"] != 0)
                    {
                        HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                        LaderTypeKey.LaderTypeID_int = (Int32?)TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"];
                        LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                        if (LaderTypeEntity == null)
                        {
                            throw new ApplicationException("نوع بارگیر خالی است");
                        }
                        //StopFeeList = this.GetStopFee(TrafficFactory.ServerJalaliDate, LaderTypeEntity.LaderPivotGroupID_int, (Int32?)TrafficNavigationDataTable.Rows[0]["ServiceID_int"]);
                        //if (StopFeeList != null && StopFeeList.Count > 0)
                        //{
                        //    Price_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal));
                        //}

                    }
                }
                else
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage("تردد جاری آخرین مورد است");

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void PriceCorrectButon_Click(object sender, EventArgs e)
        {
            Price_decNumericTextBox.Enabled = true;
        }

        private List<HPS.BLL.StopFeeBLL.BLLStopFee_T> GetStopFee(string Date_nvc, int? LaderPivotGroupID_int, int? ServicesID_int)
        {
            if (string.IsNullOrEmpty(Date_nvc) || !LaderPivotGroupID_int.HasValue)
                return null;

            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            string BaseCondition = string.Format("[StopFee_T].[StartDate_nvc]<='{0}' And [StopFee_T].[EndDate_nvc]>='{0}' And [StopFee_T].[TrafficTypeID_int]=1 And ", Date_nvc);
            BaseCondition += string.Format("[StopFee_T].[LaderPivotGroupID_int]={0} And ", LaderPivotGroupID_int);

            string PrimaryCondition = BaseCondition;

            if (ServicesID_int.HasValue)
                PrimaryCondition += string.Format("[StopFee_T].[ServicesID_int]={0} And ", ServicesID_int);
            else
                PrimaryCondition += "[StopFee_T].[ServicesID_int] Is Null And ";

            if (PrimaryCondition.EndsWith(" And "))
                PrimaryCondition = PrimaryCondition.Substring(0, PrimaryCondition.Length - 5);

            List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = StopFeeFactory.GetAllByCondition(PrimaryCondition);
            if (StopFeeList != null && StopFeeList.Count > 0)
                return StopFeeList;
            if (ServicesID_int.HasValue)
            {
                string AlternativeCondition = BaseCondition;
                AlternativeCondition += "[StopFee_T].[ServicesID_int] Is Null And ";
                AlternativeCondition += "[StopFee_T].[ExtraHourFee_dec] Is Not Null And ";
                if (AlternativeCondition.EndsWith(" And "))
                    AlternativeCondition = AlternativeCondition.Substring(0, AlternativeCondition.Length - 5);
                StopFeeList = StopFeeFactory.GetAllByCondition(AlternativeCondition);
                if (StopFeeList != null && StopFeeList.Count > 0)
                    return StopFeeList;
            }
            return null;
        }

        private void DriverCardNumber_bintNumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.Enter)
            //{

            //if (this._CardReading)
            //    return;
            //if (WithoutCardcheckBox.Checked == false)
            //{
            //    string TurnNumberCondition = string.Empty;
            //    try
            //    {
            //        if (!string.IsNullOrEmpty(DriverCardNumber_bintNumericTextBox.Text))
            //        {

            //            //object driverObject = null;
            //            //object carObject = null;
            //            if (string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
            //            {
            //                throw new ApplicationException("شماره کارت ناوگان خالی است");
            //            }
            //            try
            //            {
            //                GetDriverAndTruckInformation();
            //            }
            //            catch (Exception ex)
            //            {
            //                /////if occures exception read from local db
            //                if (!string.IsNullOrEmpty(ex.Message))
            //                {
            //                    FillDriverInOfflineMode();
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            //    }
            //}
        }

        private void FillDriverInOfflineMode()
        {
            string DriverCondition = string.Empty;
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
            DriverCondition = "[Driver_T].[NationalCode_int]= '" + NationalCode_intNumericTextBox.Text + "'";
            DriverList = DriverFactory.GetAllByCondition(DriverCondition);


            if (ErrorMessage_nvc != string.Empty)
            {
                throw new ApplicationException(ErrorMessage_nvc);
            }
            DriverOffline_bit = true;
            CarOffline_bit = true;
            if (string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text) || string.IsNullOrEmpty(DriverCardDate_nvcTextBox.Text) || string.IsNullOrEmpty(Mobile_nvcnumericTextBox.Text) || string.IsNullOrEmpty(FirstName_nvcTextBox.Text) || string.IsNullOrEmpty(LastName_nvcTextBox.Text) || string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text))
            {

                if (DriverList != null && DriverList.Count > 0)
                {
                    if (DriverList[0].Active_bit == false)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("اين راننده توسط مديريت غير فعال شده است");
                    }
                    FirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                    LastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                    DriverCardDate_nvcTextBox.Text = DriverList[0].DriverCardDate_nvc;
                    DriverType_nvc.Text = DriverList[0].DriverType_nvc;
                    NationalCode_intNumericTextBox.Text = DriverList[0].NationalCode_int.ToString();
                    Mobile_nvcnumericTextBox.Text = DriverList[0].Mobile_nvc.ToString();
                    _DriverID_bint = DriverList[0].DriverID_bint;

                }
                else
                {

                    if (DriverList != null && DriverList.Count > 0)
                    {
                        DriverList.Clear();
                    }
                    NationalCode_intNumericTextBox.Enabled = true;
                    licenceNumber_intNumericTextBox.Enabled = true;
                    DriverType_nvc.Enabled = true;
                    FirstName_nvcTextBox.Enabled = true;
                    LastName_nvcTextBox.Enabled = true;

                }

            }
        }

        private void CarCardNumber_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CarCardNumber_nvcTextBox_Leave(object sender, EventArgs e)
        {
            string TurnNumberCondition = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    try
                    {
                        //if (!DriverOffline_bit)
                        //{
                        HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                        HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                        CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                        CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                        CardCheckingLogEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                        CardCheckingLogEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                        CardCheckingLogEntity.OperationType_nvc = "ارسال";
                        CardCheckingLogEntity.AcceptTurn_bit = true;
                        CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                        CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                        CardCheckingLogFactory.Insert(CardCheckingLogEntity);
                        GetDriverAndTruckInformation();
                        CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                        CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                        CardCheckingLogEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                        CardCheckingLogEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                        CardCheckingLogEntity.OperationType_nvc = "دریافت" + ErroeMessage;
                        CardCheckingLogEntity.AcceptTurn_bit = true;
                        CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                        CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                        CardCheckingLogFactory.Insert(CardCheckingLogEntity);
                        //}
                    }
                    catch (Exception ex)
                    {
                        /////if occures exception read from local db
                        if (!string.IsNullOrEmpty(ex.Message))
                        {

                            FillDriverInOfflineMode();
                        }
                    }

                    LoadWithCarCardNumber();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void TurnAccepted_bitWithoutPrintButton_Click(object sender, EventArgs e)
        {
            Print_bit = false;
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();

            try
            {
                if (ChechActiveDriver == false || ChechActiveCare == false)
                {
                    //ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مدیریت پایانه بار مراجعه نمایید ", DriverCardNumber_bintNumericTextBox.Text);
                    //Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                    return;
                }

                ExpiredTimeAcceptTurn_bit = false;
                AcceptTurnConditionCheck();
            }
            catch (Exception ex)
            {
                TrafficFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CarControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChechActiveDriver == false || ChechActiveCare == false)
                {
                    //ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مدیریت پایانه بار مراجعه نمایید ", DriverCardNumber_bintNumericTextBox.Text);
                    //Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                    return;
                }
                if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    //HPS.Present.DriverSpecification.DriverSpecificationEntityForm frm = new HPS.Present.DriverSpecification.DriverSpecificationEntityForm(CarCardNumber_nvcTextBox.Text,false);
                    //frm.ShowDialog();

                    List<string> DateEroorList = new List<string>();


                    Hepsa.Core.Validation.TodayDateRule InsuranceEndDate_nvcRule = new Hepsa.Core.Validation.TodayDateRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
                    if (InsuranceEndDate_nvcRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(InsuranceEndDate_nvcRule.Description + "\n");
                    }

                    Hepsa.Core.Validation.TodayDateRule CarExaminationEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
                    if (CarExaminationEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(CarExaminationEndTodayDateRule.Description + "\n");
                    }

                    ////////////add not null rule

                    Hepsa.Core.Validation.NotNullRule InsuranceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
                    if (InsuranceEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(InsuranceEndDateNotNullRule.Description + "\n");
                    }

                    Hepsa.Core.Validation.NotNullRule CarExaminationEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
                    if (CarExaminationEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(CarExaminationEndDateNotNullRule.Description + "\n");
                    }

                    ////////////add date rule
                    Hepsa.Core.Validation.DateRule<string> InsuranceEndDateaDateRule = new Hepsa.Core.Validation.DateRule<string>("InsuranceEndDate_nvc", "تاريخ اتمام بيمه", null, null);
                    if (InsuranceEndDateaDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(InsuranceEndDateaDateRule.Description + "\n");
                    }

                    Hepsa.Core.Validation.DateRule<string> CarExaminationEndDateRule = new Hepsa.Core.Validation.DateRule<string>("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه", null, null);
                    if (CarExaminationEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(CarExaminationEndDateRule.Description + "\n");
                    }

                    if (DateEroorList != null && DateEroorList.Count > 0)
                    {
                        throw new ApplicationException(DateEroorList.Aggregate((i, j) => i + j));
                    }

                    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                    try
                    {
                        HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
                        DriverSpecificationEntity.CarExamination_bit = false;
                        DriverSpecificationEntity.Insurance_bit = false;
                        DriverSpecificationEntity.HealthCard_bit = false;
                        DriverSpecificationEntity.DriverCardSharje_bit = false;
                        DriverSpecificationEntity.StatisticCard_bit = false;
                        DriverSpecificationEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                        DriverSpecificationEntity.CarExaminationEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarExaminationEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                        DriverSpecificationEntity.InsuranceEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsuranceEndDate_nvcTextBox.Text, TypeCode.String).ToString();

                        HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys driverSpecificationkey = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                        if (_CarDriverSpecificationID != 0)
                        {
                            driverSpecificationkey.DriverSpecificationID_int = _CarDriverSpecificationID;
                            DriverSpecificationFactory.BeginProc();
                            DriverSpecificationFactory.Update(DriverSpecificationEntity, driverSpecificationkey);
                            DriverSpecificationFactory.CommitProc();
                            Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                        }
                        else
                        {
                            DriverSpecificationFactory.BeginProc();
                            DriverSpecificationFactory.Insert(DriverSpecificationEntity);
                            DriverSpecificationFactory.CommitProc();
                            Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                        }
                    }
                    catch (Exception ex)
                    {
                        DriverSpecificationFactory.RollBackProc();
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                    }


                    //DriverInformationSave();
                }
                else
                    throw new ApplicationException("اطلاعات ناوگان خالی است");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ShowSpecificationButton_Click(object sender, EventArgs e)
        {
            LoadWithDriverCardNumber();
        }

        private void CarInfoShowButton_Click(object sender, EventArgs e)
        {
            LoadWithCarCardNumber();
        }

        private void LoadWithDriverCardNumber()
        {
            if (!string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text))
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> DriverSpecificationList = DriverSpecificationFactory.GetAllBy(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.NationalCode_int, NationalCode_intNumericTextBox.Text);
                if (DriverSpecificationList != null && DriverSpecificationList.Count > 0)
                {
                    _DriverSpecificationID = DriverSpecificationList[0].DriverSpecificationID_int;
                    licenceNumber_intNumericTextBox.Text = DriverSpecificationList[0].licenceNumber_nvc;
                    LicenceEnd_nvcTextBox.Text = DriverSpecificationList[0].LicenceEnd_nvc;
                    //CarExaminationEndDate_nvcTextBox.Text = DriverSpecificationList[0].CarExaminationEndDate_nvc;
                    //InsuranceEndDate_nvcTextBox.Text = DriverSpecificationList[0].InsuranceEndDate_nvc;
                    ClassID_intComboBox.SelectedValue = DriverSpecificationList[0].ClassID_int;
                    HealthCardEndDate_nvcTextBox.Text = DriverSpecificationList[0].HealthCardEndDate_nvc;
                    if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)))
                        DriverCardSharjeEndDate_nvcTextBox.Text = DriverSpecificationList[0].DriverCardSharjeEndDate_nvc;
                }
            }
            else
                throw new ApplicationException("کدملی راننده وارد نشده است");
        }

        private void LoadWithCarCardNumber()
        {
            if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> DriverSpecificationList = DriverSpecificationFactory.GetAllBy(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc, CarCardNumber_nvcTextBox.Text);
                DriverSpecificationList = DriverSpecificationFactory.GetAllByCondition(string.Format(" CarCardNumber_nvc='{0}' ", CarCardNumber_nvcTextBox.Text));
                if (DriverSpecificationList != null && DriverSpecificationList.Count > 0)
                {
                    _CarDriverSpecificationID = DriverSpecificationList[0].DriverSpecificationID_int;
                    CarExaminationEndDate_nvcTextBox.Text = DriverSpecificationList[0].CarExaminationEndDate_nvc;
                    InsuranceEndDate_nvcTextBox.Text = DriverSpecificationList[0].InsuranceEndDate_nvc;

                }
            }

            //else
            //{
            //    throw new ApplicationException("شماره کارت ناوگان وارد نشده است");
            //}
        }

        private void CarCardNumber_nvcTextBox_Leave_1(object sender, EventArgs e)
        {

        }

        private void InTrafficPictureShowButton_Click(object sender, EventArgs e)
        {
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TKeys TrafficPicturesKey = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TKeys();
            TrafficPicturesKey.TrafficID_bint = _TrafficID_bint;
            TrafficPicturesEntity = TrafficPicturesFactory.GetBy(TrafficPicturesKey);

            if (TrafficPicturesEntity != null && TrafficPicturesEntity.Picture_vbnry != null)
            {
                System.IO.MemoryStream pictureMemoryStream = new System.IO.MemoryStream();
                pictureMemoryStream.Write(TrafficPicturesEntity.Picture_vbnry, 0, TrafficPicturesEntity.Picture_vbnry.Length);
                //pictureBox.Image = System.Drawing.Image.FromStream(pictureMemoryStream);

                HPS.Reports.Forms.TrafficPicturesFullScreanForm frm = new HPS.Reports.Forms.TrafficPicturesFullScreanForm(pictureMemoryStream);
                frm.ShowDialog();
            }
        }

        private void CheckOnlineCardNumber()
        {
            string DriverCondition = string.Empty;
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
            string TurnNumberCondition = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text))
                {

                    DriverOffline_bit = false;
                    if (string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                    {
                        throw new ApplicationException("شماره کارت ناوگان خالی است");
                    }
                    try
                    {
                        if (!DriverOffline_bit)
                        {
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                            CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                            CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                            CardCheckingLogEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                            CardCheckingLogEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                            CardCheckingLogEntity.OperationType_nvc = "ارسال";
                            CardCheckingLogEntity.AcceptTurn_bit = true;
                            CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                            CardCheckingLogFactory.Insert(CardCheckingLogEntity);
                            GetDriverAndTruckInformation();
                            CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                            CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                            CardCheckingLogEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                            CardCheckingLogEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                            CardCheckingLogEntity.OperationType_nvc = " دریافت" + ErroeMessage;
                            CardCheckingLogEntity.AcceptTurn_bit = true;
                            CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                            CardCheckingLogFactory.Insert(CardCheckingLogEntity);
                        }
                    }

                    catch (Exception ex)
                    {
                        /////if occures exception read from local db
                        if (!string.IsNullOrEmpty(ex.Message))
                        {
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory CardCheckingLogFactory = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_TFactory();
                            HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T CardCheckingLogEntity = new BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                            CardCheckingLogEntity.Date_vc = CardCheckingLogFactory.ServerJalaliDate;
                            CardCheckingLogEntity.Time_vc = CardCheckingLogFactory.ServerTime;
                            CardCheckingLogEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                            CardCheckingLogEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                            CardCheckingLogEntity.OperationType_nvc = " عدم دریافت  /ارتباط با سیستم استعلام کارت هوشمند برقرار نیست ";
                            ErrorMessage_nvc = string.Empty;
                            if (ex.Message == "Unable to connect to the remote server")
                            { Hepsa.Core.Common.MessageBox.InformationMessage(" ارتباط با سیستم استعلام کارت هوشمند برقرار نیست "); }

                            else if (ex.Message == "Error processing input")
                            {
                                ErrorMessage_nvc = " شماره کارت راننده یا شماره کارت ماشین در سیستم استعلام کارت هوشمند موجود نمی باشد ";
                                ChechActiveCare = false;
                            }
                            else if (ex.Message == "Index was outside the bounds of the array.")
                            {
                                ErrorMessage_nvc = "شماره كارت راننده يا شماره كارت كاميون در سيستم استعلام موجود نمي باشد";
                            }
                            else
                                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                            CardCheckingLogEntity.AcceptTurn_bit = true;
                            CardCheckingLogEntity.userName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                            CardCheckingLogEntity.macAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                            CardCheckingLogFactory.Insert(CardCheckingLogEntity);
                            FillDriverInOfflineMode();
                        }
                    }
                }
                else
                    throw new ApplicationException("شماره کارت راننده خالی است");

                //LoadWithDriverCardNumber();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void GetDriverAndTruckInformation()
        {
            ChechActiveDriver = true;
            ChechActiveCare = true;
            HPS.BLL.DriverBLL.BLLDriver_T driverEntity = new BLL.DriverBLL.BLLDriver_T();
            HPS.BLL.CarBLL.BLLCar_T carEntity = new BLL.CarBLL.BLLCar_T();
            CarCardNumber_nvcTextBox.ReadOnly = true;
            DriverCardNumber_bintNumericTextBox.ReadOnly = true;
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
                var RecivedObject = webService.GetInformation(NationalCode_intNumericTextBox.Text, CarCardNumber_nvcTextBox.Text);
                if (RecivedObject != null)
                {
                    driverObject = (List<object>)RecivedObject[0];
                    carObject = (List<object>)RecivedObject[1];
                }

                if (driverObject != null)
                {
                    if (driverObject[8].ToString() == "0")
                    {
                        ErroeMessage = string.Format("کدملی راننده به شماره <{0}>وارد شده در سیستم استعلام کدملی غیر فعال می باشد. ", NationalCode_intNumericTextBox.Text);
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                        ChechActiveDriver = false;
                        return;
                    }

                    if (!string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text) && driverObject[2].ToString() != NationalCode_intNumericTextBox.Text)
                    {
                        ErroeMessage = string.Format("نام و نام خانوادگی با مشخصات کارت هوشمند مطابقت ندارد");
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                        ChechActiveDriver = false;
                        return;
                    }
                    FirstName_nvcTextBox.Text = driverObject[0].ToString();
                    LastName_nvcTextBox.Text = driverObject[1].ToString();
                    NationalCode_intNumericTextBox.Text = driverObject[2].ToString();
                    licenceNumber_intNumericTextBox.Text = driverObject[4].ToString();
                    DriverCardDate_nvcTextBox.Text = driverObject[9].ToString();
                    HealthCardEndDate_nvcTextBox.Text = driverObject[7].ToString();
                    DriverCardSharjeEndDate_nvcTextBox.Text = driverObject[6].ToString().Substring(0, 4) + "/" + driverObject[6].ToString().Substring(4, 2) + "/" + driverObject[6].ToString().Substring(6, 2);
                    DriverOffline_bit = false;

                    ////////Fill DrivermobileNumber
                    //string DriverCondition = string.Empty;
                    //HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                    //DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
                    //HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = new BLL.DriverBLL.BLLDriver_T();
                    //DriverCondition = "([Driver_T].[DriverCardNumber_nvc]='" + DriverCardNumber_bintNumericTextBox.Text + "') ";
                    //DriverList = DriverFactory.GetAllByCondition(DriverCondition);
                    //if (DriverList != null && DriverList.Count > 0)
                    //{
                    //    Mobile_nvcnumericTextBox.Text = DriverList[0].Mobile_nvc;
                    //}
                }
                else
                {
                    ////Information Not exist
                    ErroeMessage = string.Format("کدملی راننده به شماره <{0}>وارد شده در سیستم استعلام کدملی موجود نمی باشد. ", NationalCode_intNumericTextBox.Text);
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                    ChechActiveCare = false;
                    return;
                }


                if (carObject != null)
                {
                    CarOffline_bit = false;

                    if (carObject[0].ToString() == "0")
                    {
                        ErroeMessage = string.Format("کارت هوشمند ناوگان به شماره <{0}> وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. ", CarCardNumber_nvcTextBox.Text);
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                        ChechActiveDriver = false;
                        return;
                    }
                    if (carObject[1].ToString() != NumberPlate_nvcTextBox.Text || carObject[2].ToString() != SerialPlate_nvcTextBox.Text)
                    {
                        ErroeMessage = string.Format("شماره پلاک و سریال با مشخصات کارت هوشمند مطابقت ندارد");
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                        ChechActiveDriver = false;
                        return;
                    }

                }
                else
                {
                    /////Information not Exist
                    ErroeMessage = string.Format("کارت هوشمند ناوگان به شماره <{0}> وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. ", CarCardNumber_nvcTextBox.Text);
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
                    return;
                }
                // Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات خوانده شد و صحیح می باشد");
            }
            else if (SettingEntity.Value_nvc.ToString() == "0")
                FillDriverInOfflineMode();
        }

        private void AcceptTimeExpiredTurnsButton_Click(object sender, EventArgs e)
        {
            try
            {
                ///به نابر درخواست آقای قیطانچی در 94/12/13 در تایید تاریخ گذشته نوبت جدید داده نخواهد شد بلکه نوبت قبلی تایید میشود
                ExpiredTimeAcceptTurn_bit = true;
                if (ChechActiveDriver == false || ChechActiveCare == false)
                {
                    //ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مدیریت پایانه بار مراجعه نمایید ", DriverCardNumber_bintNumericTextBox.Text);
                    return;
                }
                //95/12/3
                //در این تاریخ پرینت غیر فعال گردید
                Print_bit = false;
                AcceptTurnConditionCheck();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AcceptTurnConditionCheck()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            List<string> DateEroorList = new List<string>();

            DateEroorList = ControlRules();

            if (DateEroorList != null && DateEroorList.Count > 0)
            {
                throw new ApplicationException(DateEroorList.Aggregate((i, j) => i + j));
            }

            HPS.BLL.TrafficBLL.BLLTraffic_T trafficRuleObject = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = null;
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();

            if (string.IsNullOrEmpty(NationalCode_intNumericTextBox.Text))
            {
                throw new ApplicationException("شماره کارت هوشمند راننده وارد نشده است");

            }

            if (string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
            {
                throw new ApplicationException("شماره کارت هوشمند ناوگان وارد نشده است");
            }

            TrafficKey.TrafficID_bint = this._TrafficID_bint;

            SettingKey.SettingID_int = 1001;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            _TurnHour = Convert.ToInt32(SettingEntity.Value_nvc);

            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = TrafficFactory.GetBy(TrafficKey);
            if (TrafficEntity == null)
            {
                throw new HPS.Exceptions.TrafficNotFound();
            }

            if (string.IsNullOrEmpty(FirstName_nvcTextBox.Text.Trim()) || string.IsNullOrEmpty(LastName_nvcTextBox.Text.Trim()) || string.IsNullOrEmpty(NationalCode_intNumericTextBox.NumericText) || string.IsNullOrEmpty(Mobile_nvcnumericTextBox.NumericText))
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("اطلاعات راننده خالی است");
                return;
            }

            string driverSpecificationCondition = string.Format("DriverSpecification_T.NationalCode_int={0} ", NationalCode_intNumericTextBox.Text);
            var driverSpecificationFactory = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            var driverSpecificationTable = new DataTable();
            driverSpecificationFactory.GetAllByCondition(driverSpecificationCondition, ref driverSpecificationTable);
            if (driverSpecificationTable == null && driverSpecificationTable.Rows.Count == 0)
            {
                throw new ApplicationException("کنترل اطلاعات راننده صورت نگرفته است");
            }

            TrafficEntity.TurnAccepted_bit = true;
            TrafficEntity.TurnDate_nvc = TrafficFactory.ServerJalaliDate;
            TrafficEntity.TurnTime_nvc = TrafficFactory.ServerTime;
            TrafficEntity.TurnUser_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
            TrafficEntity.AcceptedTurnComment_nvc = AcceptedTurnComment_nvcTextBox.Text;
            TrafficEntity.DriverCardDate_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardDate_nvcTextBox.Text, TypeCode.String));
            TrafficEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_bintNumericTextBox.Text, TypeCode.String).ToString();
            TrafficEntity.DriverType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverType_nvc.Text, TypeCode.String).ToString();
            TrafficEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
            TrafficEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
            TrafficEntity.licenceNumber_int = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_intNumericTextBox.NumericText, TypeCode.Int64);
            TrafficEntity.NationalCode_int = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
            TrafficEntity.DriverMobileNumber_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_nvcnumericTextBox.NumericText, TypeCode.String));
            //TrafficEntity.Area_bit = Area_bitcheckBox.Checked;
            TrafficEntity.DriverOffline_bit = DriverOffline_bit;
            TrafficEntity.CarOffline_bit = CarOffline_bit;
            if (string.IsNullOrEmpty(TrafficEntity.CarCardNumber_nvc))
            {
                TrafficEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.NumericText;
            }
            if (DriverList != null && DriverList.Count > 0)
            {
                TrafficEntity.DriverID_bint = DriverList[0].DriverID_bint;
            }

            // specify car status
            DataTable TrafficStatusDataTable = new DataTable();
            TrafficFactory.GetLastStatus(TrafficEntity.NumberPlate_nvc, TrafficEntity.SerialPlate_nvc, CarCardNumber_nvcTextBox.Text, TrafficStatusDataTable);
            DateTime TrafficDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficEntity.Date_nvc)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficEntity.Time_nvc);

            #region AcceptTurn Conditions


            if ((Int32)TrafficEntity.ServiceID_int == 2)
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
                    if (HasTurn_bit.HasValue == false || HasTurn_bit == false)
                    {
                        TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                    }
                    else
                    {
                        if (TurnAccepted_bit.HasValue && TurnAccepted_bit == true)
                        {
                            if (TurnCanceled_bit.HasValue && TurnCanceled_bit == true)
                            {
                                DataTable TurnStatusDataTable = new DataTable();
                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                {
                                    throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));

                                }
                                else
                                {
                                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);

                                }

                            }

                            else
                            {
                                if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                                {
                                    if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                                    {
                                        if (LadBillCreditTurn_bit.HasValue && LadBillCreditTurn_bit == true)
                                        {
                                            //محاسبه مدت مجاز سفر
                                            DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                            DataTable TrafficDataTable = new DataTable();
                                            string Condition = string.Format("Traffic_T.TrafficID_bint='{0}'", TrafficEntity.TrafficID_bint);
                                            TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);
                                            if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                            {
                                                Int32 _CityTravelHour = 0;
                                                if (!string.IsNullOrEmpty(TrafficDataTable.Rows[0]["TravelTime_int"].ToString()))
                                                {
                                                    _CityTravelHour = Convert.ToInt32(TrafficDataTable.Rows[0]["TravelTime_int"].ToString());
                                                }
                                                ///////////////
                                                string _OutDate = TrafficDataTable.Rows[0]["Date_nvc"].ToString();
                                                string _OutTime = TrafficDataTable.Rows[0]["Time_nvc"].ToString();
                                                DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);

                                                if (TrafficDataTable.Rows[0]["Out_bit"].ToString() == "False")
                                                {
                                                    TimeSpan date = NowDate - OutDate;
                                                    double remaindedHour = _CityTravelHour - date.TotalHours;
                                                    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                    {
                                                        throw new ApplicationException(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", TrafficDataTable.Rows[0]["LadBillCreditID_int"], TimeSpan.FromDays(remaindedHour)));
                                                    }
                                                    else
                                                    {
                                                        TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                DataTable TurnStatusDataTable = new DataTable();
                                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                {
                                                    throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));

                                                }
                                                else
                                                {
                                                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);

                                                }
                                            }

                                        }
                                        else
                                        {
                                            TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                        }
                                    }
                                    else
                                    {
                                        TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                    }
                                }
                                else
                                {
                                    throw new ApplicationException(string.Format("این ناوگان دارای شماره نوبت تأیید شده {0} می باشد", TrafficStatusDataTable.Rows[TrafficStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                }
                            }
                        }
                        else if (TurnAccepted_bit.HasValue && TurnReturn_bit == true)
                        {
                            DataTable TurnStatusDataTable = new DataTable();
                            TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                            if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                            {
                                throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));

                            }
                            else
                            {
                                //تأیید نوبت با نوبت قبلی 
                                TrafficEntity.AcceptedTurnNumber_bint = TrafficEntity.TurnNumber_bint;
                                //TrafficEntity.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(Price_decNumericTextBox.NumericText, TypeCode.Decimal);
                                if (TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                                {
                                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntity.BrokenRulesList().ToString());
                                }
                                TrafficFactory.BeginProc();
                                TrafficFactory.Update(TrafficEntity, TrafficKey);
                                TrafficFactory.CommitProc();
                                ////چاپ
                                if (this._DataTable != null)
                                {
                                    DataRow[] dr = this._DataTable.Select("TrafficID_bint=" + this._TrafficID_bint.ToString());
                                    if (dr != null && dr.Length > 0)
                                    {
                                        dr[dr.Length - 1].Delete();
                                        this._DataTable.AcceptChanges();
                                    }
                                }
                                this.Close();
                                //HPS.Reports.ReportDoc.AcceptedTurnReport rpt = new HPS.Reports.ReportDoc.AcceptedTurnReport(_TrafficID_bint);
                                //rpt.Document.Printer.PrinterName = string.Empty;
                                //rpt.Run();
                                //Properties.Settings setting = new HPS.Properties.Settings();
                                //if (string.IsNullOrEmpty(setting.PrinterName))
                                //{
                                //    rpt.Document.Print(true, true, true);
                                //}
                                //else
                                //{
                                //    rpt.Document.Printer.PrinterName = setting.PrinterName;
                                //    rpt.Document.Print(false, true, true);
                                //}

                            }
                        }
                        else
                        {
                            //محاسبه مدت مجاز سفر در صورت داشتن مجوز
                            DataTable LadBillDataTable = new DataTable();
                            TrafficFactory.GetTurnStatus(TrafficEntity.NumberPlate_nvc, TrafficEntity.SerialPlate_nvc, LadBillDataTable);
                            if (LadBillDataTable != null && LadBillDataTable.Rows.Count > 0)
                            {
                                if (!string.IsNullOrEmpty(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["LadBillCreditID_int"].ToString()))
                                {

                                    bool? PreviousTurnAccepted_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["TurnAccepted_bit"], TypeCode.Boolean);
                                    Int32? PreviousTurnCancelCommandID_bit = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["TurnCancelCommantID_int"], TypeCode.Int32);
                                    bool? PreviousTurnReturn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["Return_bit"], TypeCode.Boolean);
                                    if (PreviousTurnAccepted_bit.HasValue && PreviousTurnAccepted_bit == true)
                                    {
                                        if (PreviousTurnCancelCommandID_bit.HasValue)
                                        {
                                            if (PreviousTurnReturn_bit.HasValue && PreviousTurnReturn_bit == true)
                                            {
                                                //باطل شده و احیا شده
                                                throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی< {0} >می باشد", LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["AcceptedTurnnumber_bint"]));
                                            }
                                            else
                                            {
                                                //باطل شده و احیا نشده نوبت جدید
                                                TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                            }
                                        }
                                        else
                                        {
                                            //تأیید شده و باطل نشده

                                            DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                            DataTable TrafficDataTable = new DataTable();
                                            string Condition = string.Format("Traffic_T.NumberPlate_nvc='{0}' and SerialPlate_nvc='{1}'", TrafficEntity.NumberPlate_nvc, TrafficEntity.SerialPlate_nvc);
                                            TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);

                                            if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                            {
                                                string filter = "LadeAssignmentId_bint=Max(LadeAssignmentId_bint)";
                                                DataRow[] dr = TrafficDataTable.Select(filter);
                                                if (dr != null && dr.Length > 0)
                                                {

                                                    Int32 _CityTravelHour = 0;
                                                    if (!string.IsNullOrEmpty(dr[dr.Length - 1]["TravelTime_int"].ToString()))
                                                    {
                                                        _CityTravelHour = Convert.ToInt32(dr[dr.Length - 1]["TravelTime_int"].ToString());
                                                    }

                                                    string _OutDate = dr[dr.Length - 1]["LadBillDate"].ToString();
                                                    string _OutTime = dr[dr.Length - 1]["LadBillTime"].ToString();
                                                    DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);
                                                    DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();
                                                    TrafficFactory.GetLastStatusForAcceptTurn((Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["TrafficID_bint"], TypeCode.Int64), TrafficStatusForAcceptTurnDataTable);
                                                    if (TrafficStatusForAcceptTurnDataTable != null && TrafficStatusForAcceptTurnDataTable.Rows.Count > 0 && Convert.ToBoolean(TrafficStatusForAcceptTurnDataTable.Rows[0]["HasTurn_bit"]) == true)
                                                    {
                                                        bool? LadBillCreditCancel = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                                                        bool? LadBillCreditTurn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                                                        bool? TurnReturn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                                                        bool? TurnCanceled = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                                                        bool? TurnAccepted = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);

                                                        if (LadBillCreditCancel.HasValue && LadBillCreditCancel == true)
                                                        {
                                                            if (LadBillCreditTurn.HasValue && LadBillCreditTurn == true)
                                                            {
                                                                throw new ApplicationException(string.Format("این ناوگان دارای شماره نوبت تأیید شده< {0} >می باشد", TrafficStatusForAcceptTurnDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                                            }
                                                            else
                                                            {
                                                                TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                            }
                                                        }
                                                        else
                                                        {

                                                            if (TurnCanceled.HasValue && TurnCanceled == true)
                                                            {
                                                                if (TurnReturn.HasValue && TurnReturn == true)
                                                                {
                                                                    //احیای نوبت در ابطال مجوز پس مدت سفر داره
                                                                    if (dr[dr.Length - 1]["Out_bit"].ToString() == "False")
                                                                    {

                                                                        TimeSpan date = NowDate - OutDate;
                                                                        double remaindedHour = _CityTravelHour - date.TotalHours;
                                                                        string RemaindeHour = TimeSpan.FromDays(remaindedHour).ToString().Substring(0, TimeSpan.FromDays(remaindedHour).ToString().Length - 3);
                                                                        if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                                        {
                                                                            throw new ApplicationException(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", dr[dr.Length - 1]["LadBillCreditID_int"], RemaindeHour));
                                                                        }
                                                                        else
                                                                        {
                                                                            TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                                        }

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    //ابطال نوبت شده و نوبت جدید
                                                                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                // لحاظ نمودن مدت سفر
                                                                if (dr[dr.Length - 1]["Out_bit"].ToString() == "False")
                                                                {

                                                                    TimeSpan date = NowDate - OutDate;
                                                                    double remaindedHour = _CityTravelHour - date.TotalHours;
                                                                    string RemaindeHour = TimeSpan.FromDays(remaindedHour).ToString().Substring(0, TimeSpan.FromDays(remaindedHour).ToString().Length - 3);
                                                                    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                                    {
                                                                        throw new ApplicationException(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", dr[dr.Length - 1]["LadBillCreditID_int"], RemaindeHour));
                                                                    }
                                                                    else
                                                                    {
                                                                        DataTable TurnStatusDataTable = new DataTable();
                                                                        TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                                        if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                                        {
                                                                            throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                                        }
                                                                        else
                                                                        {
                                                                            TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                                        }
                                                                    }

                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                DataTable TurnStatus = new DataTable();
                                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatus);
                                                if (TurnStatus != null && TurnStatus.Rows.Count > 0)
                                                {


                                                    DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();
                                                    TrafficFactory.GetLastStatusForAcceptTurn((Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnStatus.Rows[TurnStatus.Rows.Count - 1]["TrafficID_bint"], TypeCode.Int64), TrafficStatusForAcceptTurnDataTable);
                                                    if (TrafficStatusForAcceptTurnDataTable != null && TrafficStatusForAcceptTurnDataTable.Rows.Count > 0 && Convert.ToBoolean(TrafficStatusForAcceptTurnDataTable.Rows[0]["HasTurn_bit"]) == true)
                                                    {
                                                        bool? LadBillCreditCancel = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                                                        bool? LadBillCreditTurn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                                                        bool? TurnReturn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                                                        bool? TurnCanceled = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                                                        bool? TurnAccepted = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);

                                                        if (LadBillCreditCancel.HasValue && LadBillCreditCancel == true)
                                                        {
                                                            if (LadBillCreditTurn.HasValue && LadBillCreditTurn == true)
                                                            {
                                                                throw new ApplicationException(string.Format("این ناوگان دارای شماره نوبت تأیید شده< {0} >می باشد", TrafficStatusForAcceptTurnDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                                            }
                                                            else
                                                            {
                                                                TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (TurnCanceled.HasValue && TurnCanceled == true)
                                                            {
                                                                if (TurnReturn.HasValue && TurnReturn == true)
                                                                {

                                                                    //حفظ نوبت
                                                                    //تأیید نوبت با نوبت قبلی 
                                                                    DataTable TurnStatusDataTable = new DataTable();
                                                                    TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                                    if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                                    {
                                                                        throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));

                                                                    }
                                                                    else
                                                                    {
                                                                        //تأیید نوبت با نوبت قبلی 
                                                                        TrafficEntity.AcceptedTurnNumber_bint = TrafficEntity.TurnNumber_bint;
                                                                        //TrafficEntity.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(Price_decNumericTextBox.NumericText, TypeCode.Decimal);
                                                                        if (TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                                                                        {
                                                                            throw new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntity.BrokenRulesList().ToString());
                                                                        }
                                                                        TrafficFactory.BeginProc();
                                                                        TrafficFactory.Update(TrafficEntity, TrafficKey);
                                                                        TrafficFactory.CommitProc();
                                                                        ////چاپ
                                                                        if (this._DataTable != null)
                                                                        {
                                                                            DataRow[] dr = this._DataTable.Select("TrafficID_bint=" + this._TrafficID_bint.ToString());
                                                                            if (dr != null && dr.Length > 0)
                                                                            {
                                                                                dr[dr.Length - 1].Delete();
                                                                                this._DataTable.AcceptChanges();
                                                                            }
                                                                        }
                                                                        this.Close();
                                                                        //HPS.Reports.ReportDoc.AcceptedTurnReport rpt = new HPS.Reports.ReportDoc.AcceptedTurnReport(_TrafficID_bint);
                                                                        //rpt.Document.Printer.PrinterName = string.Empty;
                                                                        //rpt.Run();
                                                                        //Properties.Settings setting = new HPS.Properties.Settings();
                                                                        //if (string.IsNullOrEmpty(setting.PrinterName))
                                                                        //{
                                                                        //    rpt.Document.Print(true, true, true);
                                                                        //}
                                                                        //else
                                                                        //{
                                                                        //    rpt.Document.Printer.PrinterName = setting.PrinterName;
                                                                        //    rpt.Document.Print(false, true, true);
                                                                        //}
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    //ابطال نوبت شده و نوبت جدید
                                                                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (TurnAccepted.HasValue && TurnAccepted == false)
                                                                {
                                                                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                                }
                                                                else
                                                                {
                                                                    //بگه نوبت داره
                                                                    throw new ApplicationException(string.Format("اين ناوگان داراي شماره نوبت تأييدي< {0} >مي باشد", TurnStatus.Rows[TurnStatus.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        // تأیید نشده نوبت جدید
                                        TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                    }
                                }
                                else if (!string.IsNullOrEmpty(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["TurnAccepted_bit"].ToString()) && (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["TurnAccepted_bit"], TypeCode.Boolean) == true)
                                {
                                    throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                }
                            }

                            else
                            {
                                DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                DataTable TrafficDataTable = new DataTable();
                                string Condition = string.Format("Traffic_T.NumberPlate_nvc='{0}' and SerialPlate_nvc='{1}'", TrafficEntity.NumberPlate_nvc, TrafficEntity.SerialPlate_nvc);
                                TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);

                                if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                {
                                    string filter = "LadeAssignmentId_bint=Max(LadeAssignmentId_bint)";
                                    DataRow[] dr = TrafficDataTable.Select(filter);
                                    if (dr != null && dr.Length > 0)
                                    {

                                        if (((bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["Turn_bit"], TypeCode.Boolean) == true && (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["Canceled_bit"], TypeCode.Boolean) == true) || (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["Canceled_bit"], TypeCode.Boolean) == false)
                                        {
                                            Int32 _CityTravelHour = 0;
                                            if (!string.IsNullOrEmpty(dr[dr.Length - 1]["TravelTime_int"].ToString()))
                                            {
                                                _CityTravelHour = Convert.ToInt32(dr[dr.Length - 1]["TravelTime_int"].ToString());
                                            }

                                            string _OutDate = dr[dr.Length - 1]["LadBillDate"].ToString();
                                            string _OutTime = dr[dr.Length - 1]["LadBillTime"].ToString();
                                            DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);
                                            DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();

                                            if (dr[dr.Length - 1]["Out_bit"].ToString() == "False")
                                            {

                                                TimeSpan date = NowDate - OutDate;
                                                double remaindedHour = _CityTravelHour - date.TotalHours;
                                                string RemaindeHour = TimeSpan.FromDays(remaindedHour).ToString().Substring(0, TimeSpan.FromDays(remaindedHour).ToString().Length - 3);
                                                if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)
                                                {
                                                    if (!string.IsNullOrEmpty(dr[dr.Length - 1]["Canceled_bit"].ToString()) && dr[dr.Length - 1]["Canceled_bit"].ToString() == "True")
                                                    {
                                                        TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                    }
                                                    else
                                                    {
                                                        throw new ApplicationException(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", dr[dr.Length - 1]["LadBillCreditID_int"], RemaindeHour));
                                                    }
                                                }
                                                else
                                                {
                                                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                                }

                                            }
                                        }
                                        else
                                        {
                                            TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                                        }
                                    }
                                }
                                else
                                {
                                    // مجوز نداره نوبت جدید
                                    DataTable TurnStatusDataTable = new DataTable();
                                    TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                    if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                    {
                                        throw new ApplicationException(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                    }
                                    else
                                    {
                                        TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);

                                    }
                                }

                            }
                        }
                    }
                }
                else
                {
                    TurnAcception(TrafficEntity, TrafficDate, _TurnHour, TrafficKey);
                }
            }
            #endregion

            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = new HPS.BLL.DriverBLL.BLLDriver_T();
            HPS.BLL.DriverBLL.BLLDriver_TKeys DriverKey = new HPS.BLL.DriverBLL.BLLDriver_TKeys();
            if (_DriverID_bint != 0)
            {

                DriverKey.DriverID_bint = _DriverID_bint;
                DriverEntity = DriverFactory.GetBy(DriverKey);
                if (DriverEntity != null)
                {
                    DriverEntity.Mobile_nvc = Mobile_nvcnumericTextBox.Text;
                    DriverFactory.Update(DriverEntity, DriverKey);
                }
            }

            if (DriverList == null)
            {
                ////insert into driver
                DriverEntity.FirstName_nvc = FirstName_nvcTextBox.Text;
                DriverEntity.LastName_nvc = LastName_nvcTextBox.Text;
                DriverEntity.NationalCode_int = Convert.ToInt64(NationalCode_intNumericTextBox.Text);
                DriverEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                DriverEntity.DriverCardDate_nvc = DriverCardDate_nvcTextBox.Text;
                DriverEntity.Mobile_nvc = Mobile_nvcnumericTextBox.Text;
                DriverFactory.Insert(DriverEntity);

            }
            DriverMobile_nvc = Mobile_nvcnumericTextBox.Text;
            DriverOffline_bit = false;
        }

        private void TurnAcception(HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity, DateTime TrafficDate, int _TurnHour, HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            if (TrafficFactory.ServerDate <= TrafficDate.AddHours(_TurnHour) && !ExpiredTimeAcceptTurn_bit.Value)
            {
                //تأیید نوبت با نوبت قبلی 
                TrafficEntity.AcceptedTurnNumber_bint = TrafficEntity.TurnNumber_bint;
                //TrafficEntity.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(Price_decNumericTextBox.NumericText, TypeCode.Decimal);
                if (TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntity.BrokenRulesList().ToString());
                }
                TrafficFactory.BeginProc();
                TrafficFactory.Update(TrafficEntity, TrafficKey);
                TrafficFactory.CommitProc();
                ////چاپ
                if (this._DataTable != null)
                {
                    DataRow[] dr = this._DataTable.Select("TrafficID_bint=" + this._TrafficID_bint.ToString());
                    if (dr != null && dr.Length > 0)
                    {
                        dr[dr.Length - 1].Delete();
                        this._DataTable.AcceptChanges();
                    }
                }
                if (Print_bit)
                {
                    //HPS.Reports.ReportDoc.AcceptedTurnReport rpt = new HPS.Reports.ReportDoc.AcceptedTurnReport(_TrafficID_bint);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //rpt.Run();
                    //Properties.Settings setting = new HPS.Properties.Settings();
                    //if (string.IsNullOrEmpty(setting.PrinterName))
                    //{
                    //    rpt.Document.Print(true, true, true);
                    //}
                    //else
                    //{
                    //    rpt.Document.Printer.PrinterName = setting.PrinterName;
                    //    rpt.Document.Print(false, true, true);
                    //}

                    TrafficEntity.TurnPrinted_bit = true;
                    Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, false, false);
                    frm.ShowDialog();

                }
                this.Close();
            }
            else if (ExpiredTimeAcceptTurn_bit.Value)
            {
                //تأیید نوبت با نوبت جدید
                //if (Hepsa.Core.Common.MessageBox.ConfirmMessage("مدت زمان تأیید نوبت به پایان رسیده و نوبت جدید داده خواهد شد") == true)
                //{
                //    TrafficEntity.AcceptedTurnNumber_bint = TrafficFactory.GetLastTurnNumber();
                //    HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                //    HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                //    HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                //    LaderTypeKey.LaderTypeID_int = TrafficEntity.LaderTypeID_int;
                //    LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                //    if (LaderTypeEntity == null)
                //    {
                //        throw new ApplicationException("نوع بارگیر خالی است");
                //    }
                //    if (TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                //    {
                //        throw new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntity.BrokenRulesList().ToString());
                //    }
                //    TrafficFactory.BeginProc();
                //    TrafficFactory.Update(TrafficEntity, TrafficKey);
                //    TrafficFactory.CommitProc();
                //    ////چاپ
                //    if (this._DataTable != null)
                //    {
                //        DataRow[] dr = this._DataTable.Select("TrafficID_bint=" + this._TrafficID_bint.ToString());
                //        if (dr != null && dr.Length > 0)
                //        {
                //            dr[dr.Length - 1].Delete();
                //            this._DataTable.AcceptChanges();
                //        }
                //    }

                //    if (Print_bit)
                //    {
                //        TrafficEntity.TurnPrinted_bit = true;
                //        Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, false, false);
                //        frm.ShowDialog();
                //    }
                //    this.Close();
                //}
                //به نابر درخواست آقای قیطانچی در 94/12/13 در تایید تاریخ گذشته نوبت جدید داده نخواهد شد بلکه نوبت قبلی تایید میشود
                //تأیید نوبت با نوبت قبلی 
                TrafficEntity.AcceptedTurnNumber_bint = TrafficEntity.TurnNumber_bint;
                //TrafficEntity.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(Price_decNumericTextBox.NumericText, TypeCode.Decimal);
                if (TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntity.BrokenRulesList().ToString());
                }
                TrafficFactory.BeginProc();
                TrafficFactory.Update(TrafficEntity, TrafficKey);
                TrafficFactory.CommitProc();
                ////چاپ
                if (this._DataTable != null)
                {
                    DataRow[] dr = this._DataTable.Select("TrafficID_bint=" + this._TrafficID_bint.ToString());
                    if (dr != null && dr.Length > 0)
                    {
                        dr[dr.Length - 1].Delete();
                        this._DataTable.AcceptChanges();
                    }
                }
                if (Print_bit)
                {
                    TrafficEntity.TurnPrinted_bit = true;
                    Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, false, false);
                    frm.ShowDialog();

                }
                this.Close();
            }
            else
            {
                throw new ApplicationException("مدت زمان مجاز تأیید نوبت گذشته است ");
            }
        }

  
    }
}

