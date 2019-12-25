using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using HPS.Present.Car;
using System.Threading.Tasks;
using HPS.BLL;
using HPS.BLL.TrafficPicturesBLL;

namespace HPS.Present.Traffic
{
    public partial class IranianCarsForm : Hepsa.Core.PL.BaseEntityForm2
    {
        HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
        HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
        HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
        HPS.Common.OnlineInformation webService = new HPS.Common.OnlineInformation();
        //CheckOnlineRefrence.OnlineInformationChecking webService = new CheckOnlineRefrence.OnlineInformationChecking();
        byte[] szBuffer = new byte[1000000];
        public byte[] PictureDataUserdEdit;
        Image img = null;
        string ip = string.Empty;
        HPS.Common.PlateReaderApi api = new HPS.Common.PlateReaderApi();
        List<byte[]> Inimgs = new List<byte[]>();
        public string numberPlateByCam { get; set; }
        DataTable ServicesDataTable = new DataTable();
        List<object> driverObject = null;
        List<object> CarObject = null;
        public IranianCarsForm() : base(null)
        {
            InitializeComponent();
            this.EditAndClose = false;
        }



        HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
        public IranianCarsForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.TrafficBLL.BLLTraffic_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
            TrafficKey = Key;
            this.EditAndClose = true;
            this.ConfirmOnClose = false;
        }


        StringBuilder ErrorString = new StringBuilder();
        string CarCondition = string.Empty;
        private bool _EditWithPrint = false;
        bool stopReadProcess = false;
        string PublicDriverNumber = string.Empty;
        HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
        HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = new HPS.BLL.DriverBLL.BLLDriver_T();
        List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList = null;
        List<HPS.BLL.CarBLL.BLLCar_T> CarList = null;
        HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
        HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
        HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
        DataTable LaderTypeID_intDataTable = new DataTable();
        DataTable PlateCityID_intDataTable = new DataTable();
        bool _CardReading = false;

        HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
        HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
        HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();

        List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
        ToolTip tooltip1 = new ToolTip();
        string tCondition = string.Empty;

        private void IranianTruckEntityForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (this.State == enmFormState.Add)
            {
                FillCombo();
                //////////FormCollection fc = Application.OpenForms;

                //////////foreach (Form frm in fc)
                //////////{
                //////////    if (frm.Text == "")
                //////////    {
                //////////      //  return true;
                //////////    }
                //////////}
                //HPS.Present.Traffic.PlateNumberRecognitionForm numberFrm = new PlateNumberRecognitionForm();
                //numberFrm.Show();
                //  trafficNumber_bint = TrafficFactory.GetLastTrafficNumber();
                //captureCameraTimer.Start();
            }

            ///========connect to Vivotek camera
            //////////////axVitaminCtrl1.Url = "http://169.254.0.99";
            //////////////axVitaminCtrl1.ViewStream = VITAMINDECODERLib.EDualStreamOption.eStream1;
            //////////////axVitaminCtrl1.ConnectionProtocol = VITAMINDECODERLib.EConnProtocol.eProtTCP;
            //////////////axVitaminCtrl1.MediaType = VITAMINDECODERLib.EMediaType.eMediaVideo;
            //////////////axVitaminCtrl1.Connect();
            //////////////axVitaminCtrl1.StretchFullScreen = false;

            ///=========================




            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 100;
            tooltip1.ReshowDelay = 100;
            tooltip1.ShowAlways = true;
            if (PriceWithTax_decNumericTextBox.Text == "")
            {
                PriceCorrectButon.Enabled = false;
            }



            if (this.State == enmFormState.Edit)
            {
                var dt = this.DataTable.Select("TrafficID_bint=" + TrafficKey.TrafficID_bint.ToString()).CopyToDataTable();
                if ((dt.Rows[0]["ladereturn_bit"].ToString().ToLower()) == "true" && !(HPS.Common.CurrentUser.user.UserGroupID_int == 1))
                {
                    LadeReturnCheckBox.Enabled = false;
                }
            }
        }

        private void DublicateTurn(string DriverNumber)
        {


            if (ServicesID_intComboBox.SelectedIndex == 1)
            {
                var dt = new DataTable();
                var DriverTurn = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DriverTurn.SelectDuplicateTurnByDrivers(dt, DriverNumber);
                var Count = dt.Select("DriverCardNumber_nvc='" + DriverNumber + "'").Count();
                if (Count > 0)
                {
                    throw new ApplicationException("برای شماره کارت راننده وارد شده نوبت فعال وجود دارد");
                }
            }

        }

        private void DublicateTurnOnEdit(string DriverNumber)
        {
            if (!(PublicDriverNumber == DriverCardNumber_bintNumericTextBox.Text))
            {
                if (ServicesID_intComboBox.SelectedIndex == 1)
                {
                    var dt = new DataTable();
                    var DriverTurn = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                    DriverTurn.SelectDuplicateTurnByDrivers(dt, DriverNumber);
                    var Count = dt.Select("DriverCardNumber_nvc=" + DriverNumber).Count();
                    if (Count > 0)
                    {
                        throw new ApplicationException("برای شماره کارت راننده وارد شده نوبت فعال وجود دارد");
                    }
                }
            }
        }

        private void DriverCardNumber_bintNumericTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ClearDriver();
                if (!(this.State == enmFormState.Edit))
                {
                    DublicateTurn(DriverCardNumber_bintNumericTextBox.Text);
                }
                else
                {
                    DublicateTurnOnEdit(DriverCardNumber_bintNumericTextBox.Text);
                }

                LoadDriver(DriverCardNumber_bintNumericTextBox.Text);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        string DriverCondition = string.Empty;

        private void LastDriverTrafficButoon_Click(object sender, EventArgs e)
        {
            WithoutCardcheckBox.Checked = false;
            string TrafficCondition = "[Traffic_T].[DriverCardNumber_nvc]= '" + DriverCardNumber_bintNumericTextBox.Text + "'";
            TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
            TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);


            string TurnNumberCondition = string.Empty;
            if (DriverCardNumber_bintNumericTextBox.Text != "")
            {
                TrafficCondition = "[Traffic_T].[DriverCardNumber_nvc]= '" + DriverCardNumber_bintNumericTextBox.Text + "'";

            }
            if (TrafficCondition != null && TrafficList != null && TrafficList.Count > 0 && TrafficCondition != "")
            {
                LastDriverTraffic frm = new LastDriverTraffic(DriverCardNumber_bintNumericTextBox.Text);
                frm.Show();
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "ترددی با مشخصات"));
            }

        }

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
                    licenceNumber_intNumericTextBox.Text = Convert.ToString(DriverList[0].licenceNumber_nvc);
                }
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "راننده با مشخصات"));

                DriverCardNumber_bintNumericTextBox.Focus();
            }
        }

        private void FillCarByCarList()
        {

            if (CarList != null && CarList.Count >= 1)
            {

                if (CarList[0].CarID_int != 0)
                {
                    if (CarList[0].Active_bit == false)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("اين خودرو توسط مديريت غير فعال شده است");
                    }

                    CarCardNumber_nvcTextBox.Text = CarList[0].CarCardNumber_nvc;
                    CarCardDate_nvcTextBox.Text = CarList[0].CarCardDate_nvc;
                    NumberPlate_nvcTextBox.Text = CarList[0].NumberPlate_nvc;
                    SerialPlate_nvcTextBox.Text = CarList[0].SerialPlate_nvc;

                    HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                    if (CarList[0].PlateCityID_int != null)
                    {
                        string PlateCityCondition = "[PlateCity_T].[PlateCityID_int] = '" + CarList[0].PlateCityID_int + "'";
                        List<HPS.BLL.PlateCityBLL.BLLPlateCity_T> PlateCityList = PlateCityFactory.GetAllByCondition(PlateCityCondition);
                        if (PlateCityList != null)
                        {
                            //PlateCityID_intComboBox.Text = PlateCityList[0].PlateCity_nvc;
                            PlateCityID_intComboBox.Text = "ایران";
                            PlateCityCode_nvcTextBox.Text = PlateCityList[0].PlateCityCode_nvc;
                        }
                    }


                    HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory = new HPS.BLL.ColorBLL.BLLColor_TFactory();
                    if (CarList[0].PlateColorID_int != null)
                    {
                        string ColorCondition = "[Color_T].[ColorID_int] = '" + CarList[0].PlateColorID_int + "'";
                        List<HPS.BLL.ColorBLL.BLLColor_T> ColorList = ColorFactory.GetAllByCondition(ColorCondition);
                        if (ColorList != null && ColorList.Count > 0)
                        {
                        }
                    }
                    ProductionYear_intNumericTextBox.Text = CarList[0].ProductionYear_int.ToString();
                    System_nvcCombobox.Text = CarList[0].System_nvc;
                    YearType_nvcTextBox.Text = CarList[0].YearType_nvc;
                }
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "کامیون با مشخصات"));
                NumberPlate_nvcTextBox.Focus();
            }
        }

        private void DriverCardReadingButton_Click(object sender, EventArgs e)
        {
            if (this._CardReading)
                return;
            WithoutCardcheckBox.Checked = false;
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
        }

        private void PlateCity_nvcBottun_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.PlateCitySearch frm = new HPS.Present.SearchForm.PlateCitySearch();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                PlateCityID_intComboBox.Text = frm.SelectedPlateCity.PlateCity_nvc;
                PlateCityCode_nvcTextBox.Text = frm.SelectedPlateCity.PlateCityCode_nvc;
                PlateCityEntity.PlateCityID_int = frm.SelectedPlateCity.PlateCityID_int;
            }
        }

        private void LaderType_nvcSearchButton_Click(object sender, EventArgs e)
        {
            SettingKey.SettingID_int = 1011;
            string CompareDate = string.Empty;
            SettingEntity = SettingFactory.GetBy(SettingKey);

            HPS.Present.SearchForm.LaderTypeSearch frm = new HPS.Present.SearchForm.LaderTypeSearch();
            frm.ShowDialog();
            try
            {
                if (frm != null && frm.SelectedLaderTypeEntity != null)
                {
                    LaderTypeID_intComboBox.Text = frm.SelectedLaderTypeEntity.LaderType_nvc;
                    LaderTypeCode_nvcTextBox.Text = frm.SelectedLaderTypeEntity.LaderTypeCode_nvc;
                }
                if (LaderTypeID_intComboBox.SelectedIndex != -1)
                {
                    if (LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"] == null || LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"].ToString() == "")
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("برای بارگیر محور تعیین نشده است");
                        PriceWithTax_decNumericTextBox.Text = "";
                        PriceWithoutTax_decnumericTextBox.Text = "";
                        PriceTax_decnumericTextBox.Text = "";
                    }
                    else
                    {
                        List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = this.GetStopFee(StopFeeFactory.ServerJalaliDate, (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"], TypeCode.Int32), (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32), this.WithLade_bitRadioButton.Checked);

                        if (StopFeeList != null && StopFeeList.Count > 0)
                        {
                            PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                            if (StopFeeList[0].Tax_bit)
                            {
                                PriceTax_decnumericTextBox.Text = (StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100).ToString();
                                PriceWithTax_decNumericTextBox.Text = (StopFeeList[0].Fee_dec + StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100).ToString();
                            }
                            else
                            {
                                PriceTax_decnumericTextBox.Text = "";
                                PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void LoadDriverAndCarOnlineInformation(string DriverCardNumber, string CarCardNumber)
        {
            if (ServicesID_intComboBox.SelectedValue == null)
            {
                throw new ApplicationException("مراجعه به خالی است");
            }
            if (Convert.ToInt32(ServicesID_intComboBox.SelectedValue) == 2 && string.IsNullOrEmpty(DriverCardNumber) || string.IsNullOrEmpty(CarCardNumber))
            {
                throw new ApplicationException("شماره کارت هوشمند خودرو یا راننده خالی است");
            }

            var RecivedObject = webService.GetInformation(DriverCardNumber, CarCardNumber);

            if (RecivedObject != null)
            {
                driverObject = (List<object>)RecivedObject[0];
                CarObject = (List<object>)RecivedObject[1];
            }

            if (driverObject != null)
            {
                if (driverObject[8].ToString() == "0")
                {

                    string ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. ", DriverCardNumber);
                    MessageBox.Show(ErroeMessage);

                    // throw new ApplicationException(ErroeMessage);
                }
                FirstName_nvcTextBox.Text = driverObject[0].ToString();
                LastName_nvcTextBox.Text = driverObject[1].ToString();
                NationalCode_intNumericTextBox.Text = driverObject[2].ToString();
                licenceNumber_intNumericTextBox.Text = driverObject[4].ToString();
                DriverCardDate_nvcTextBox.Text = driverObject[9].ToString();
                //online = true;
            }

            else
            {
                ////Information Not exist
                string ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. ", DriverCardNumber);
                Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
            }
            if (CarObject != null)
            {
                if (CarObject[0].ToString() == "0")
                {
                    string ErroeMessage = string.Format("کارت هوشمند خودرو به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. ", CarCardNumber);
                    //throw new ApplicationException(ErroeMessage);
                    MessageBox.Show(ErroeMessage);
                }
                NumberPlate_nvcTextBox.Text = CarObject[1].ToString();
                SerialPlate_nvcTextBox.Text = CarObject[2].ToString();
                if ((NumberPlate_nvcTextBoxCamera.Text != CarObject[1].ToString() || SerialPlate_nvcTextBoxCamera.Text != CarObject[2].ToString()) && (new HPS.BLL.SettingsBLL.BLLSetting_TFactory()).GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1027 }).Value_nvc == "1")
                {
                    throw new ApplicationException("شماره پلاک دوربین با شماره پلاک ثبت شده مطابقت ندارد");
                }
            }
            else
            {
                string ErroeMessage = string.Format("کارت هوشمند خودرو به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. ", DriverCardNumber);
                Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
            }


        }

        private void LoadDriver(string DriverCardNumber)
        {
            try
            {
                SettingKey.SettingID_int = 1010;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                if (SettingEntity.Value_nvc.ToString() == "1")
                {
                    if (!string.IsNullOrEmpty(DriverCardNumber))
                    {
                        if (ServicesID_intComboBox.SelectedValue != null && (Int32)ServicesID_intComboBox.SelectedValue == 2)
                        {

                            driverObject = null;

                            var RecivedObject = webService.GetDriverInformation(DriverCardNumber);

                            if (RecivedObject != null)
                            {
                                driverObject = (List<object>)RecivedObject[0];
                            }

                            if (driverObject != null)
                            {
                                if (driverObject[8].ToString() == "0")
                                {
                                    Hepsa.Core.Common.MessageBox.InformationMessage(string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. ", DriverCardNumber));

                                }
                                if (driverObject[0].ToString() == "-2")
                                {
                                    FillDriverFields();
                                    return;
                                }

                                FirstName_nvcTextBox.Text = driverObject[0].ToString();
                                LastName_nvcTextBox.Text = driverObject[1].ToString();
                                NationalCode_intNumericTextBox.Text = driverObject[2].ToString();
                                licenceNumber_intNumericTextBox.Text = driverObject[4].ToString();
                                DriverCardDate_nvcTextBox.Text = driverObject[9].ToString();
                                //برای پر کردن شماره موبایل
                                tCondition = "([Traffic_T].[DriverCardNumber_nvc]='" + DriverCardNumber_bintNumericTextBox.Text + "') AND ([Traffic_T].[In_bit]='true') ORDER BY TrafficID_bint DESC";
                                TrafficList.Clear();
                                TrafficList = TrafficFactory.GetAllByCondition(tCondition);
                                if (TrafficList != null && TrafficList.Count > 0)
                                {
                                    Mobile_nvcnumericTextBox.Text = TrafficList[0].DriverMobileNumber_nvc;
                                }
                            }

                            else
                            {
                                ////Information Not exist
                                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. ", DriverCardNumber));
                                return;
                            }

                        }
                        else
                        {
                            FillDriverFields();
                        }
                    }
                    else
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("شماره کارت  راننده خالی است");
                        return;
                    }
                }
                else
                {
                    FillDriverFields();
                }
            }
            catch (Exception ex)
            {
                //Hepsa.Core.Common.MessageBox.ErrorMessage("ارتباط با سیستم استعلام کارت هوشمند برقرار نیست");
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                FillDriverFields();
            }

        }

        private void LoadCar(string CarCardNumber)
        {
            try
            {
                SettingKey.SettingID_int = 1010;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                if (SettingEntity.Value_nvc.ToString() == "1")
                {
                    if (ServicesID_intComboBox.SelectedValue == null)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("مراجعه به خالی است");
                        return;
                    }

                    if (!string.IsNullOrEmpty(CarCardNumber))
                    {
                        if ((Int32)ServicesID_intComboBox.SelectedValue == 2)
                        {
                            CarObject = null;
                            object[] RecivedObject = webService.GetCarInformation(CarCardNumber);

                            if (RecivedObject != null)
                            {
                                CarObject = (List<object>)RecivedObject[0];
                            }
                            if (CarObject != null)
                            {
                                if (CarObject[0].ToString() == "0")
                                {
                                    Hepsa.Core.Common.MessageBox.InformationMessage(string.Format("کارت هوشمند خودرو به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. ", CarCardNumber));
                                }
                                if (CarObject[0].ToString() == "-2")
                                {
                                    FillCar();
                                    return;
                                }
                                NumberPlate_nvcTextBox.Text = CarObject[1].ToString();
                                SerialPlate_nvcTextBox.Text = CarObject[2].ToString();
                                ProductionYear_intNumericTextBox.Text = CarObject[3].ToString();
                                CarCardDate_nvcTextBox.Text = CarObject[5].ToString();

                                if (CarObject[3].ToString().StartsWith("13"))
                                {
                                    YearType_nvcTextBox.Text = "شمسی";
                                }
                                else
                                {
                                    YearType_nvcTextBox.Text = "میلادی";
                                }

                            }
                            else
                            {
                                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format("کارت هوشمند خودرو به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. ", CarCardNumber));
                                ClearCar();
                                return;
                            }

                        }
                        else
                        {
                            if (string.IsNullOrEmpty(CarCardNumber))
                            {
                                Hepsa.Core.Common.MessageBox.InformationMessage("شماره کارت ناوگان خالی است");
                            }
                            FillCar();
                        }
                    }
                    else if ((Int32)ServicesID_intComboBox.SelectedValue == 2)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("شماره کارت ناوگان خالی است");
                        return;
                    }
                    else
                        FillCar();
                }
                else
                {
                    if (string.IsNullOrEmpty(CarCardNumber))
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("شماره کارت ناوگان خالی است");
                    }
                    else
                        stopReadProcess = true;
                    FillCar();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("ارتباط با سیستم استعلام کارت هوشمند برقرار نیست");
                stopReadProcess = true;
                FillCar();
            }
        }

        private void DriverInsertOrUpdate(string DriverCardNumber)
        {
            if (Convert.ToInt32(ServicesID_intComboBox.SelectedValue) == 2)
            {
                var DriverEntity = new BLL.DriverBLL.BLLDriver_T();
                var DriverFactory = new BLL.DriverBLL.BLLDriver_TFactory();
                var dt = DriverFactory.GetAllBy(BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber);

                if (dt.Count == 0)
                {
                    DriverEntity.FirstName_nvc = FirstName_nvcTextBox.Text;
                    DriverEntity.LastName_nvc = LastName_nvcTextBox.Text;
                    DriverEntity.licenceNumber_nvc = licenceNumber_intNumericTextBox.Text;
                    //DriverEntity.LiceniceDate_nvc = DriverCardDate_nvcTextBox.Text;
                    DriverEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                    DriverEntity.Mobile_nvc = Mobile_nvcnumericTextBox.Text;
                    DriverEntity.DriverCardDate_nvc = DriverCardDate_nvcTextBox.Text;
                    DriverEntity.NationalCode_int = Convert.ToInt64(NationalCode_intNumericTextBox.Text);
                    DriverEntity.Active_bit = true;
                    DriverFactory.Insert(DriverEntity);
                    // return;
                }
                else if (dt.Count > 0)
                {
                    DriverEntity.FirstName_nvc = FirstName_nvcTextBox.Text;
                    DriverEntity.LastName_nvc = LastName_nvcTextBox.Text;
                    DriverEntity.licenceNumber_nvc = licenceNumber_intNumericTextBox.Text;
                    //DriverEntity.LiceniceDate_nvc = DriverCardDate_nvcTextBox.Text;
                    DriverEntity.DriverCardNumber_nvc = DriverCardNumber_bintNumericTextBox.Text;
                    DriverEntity.Mobile_nvc = Mobile_nvcnumericTextBox.Text;
                    DriverEntity.DriverCardDate_nvc = DriverCardDate_nvcTextBox.Text;
                    DriverEntity.NationalCode_int = Convert.ToInt64(NationalCode_intNumericTextBox.Text);
                    DriverEntity.Active_bit = true;
                    DriverFactory.Update(DriverEntity, new BLL.DriverBLL.BLLDriver_TKeys { DriverID_bint = DriverFactory.GetAllBy(BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber).FirstOrDefault().DriverID_bint });
                }

            }


        }

        private void CarInsertOrUpdate(string CarCardNumber)
        {
            if (Convert.ToInt32(ServicesID_intComboBox.SelectedValue) == 2)
            {
                var CarEntity = new BLL.CarBLL.BLLCar_T();
                var CarFactory = new BLL.CarBLL.BLLCar_TFactory();
                var dt = CarFactory.GetAllBy(BLL.CarBLL.BLLCar_T.Car_TField.CarCardNumber_nvc, CarCardNumber);

                if (dt.Count == 0)
                {
                    CarEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                    CarEntity.NumberPlate_nvc = NumberPlate_nvcTextBox.Text;
                    CarEntity.SerialPlate_nvc = SerialPlate_nvcTextBox.Text;
                    CarEntity.PlateCityID_int = 311;
                    CarEntity.CarCardDate_nvc = CarCardDate_nvcTextBox.Text;
                    CarEntity.System_nvc = System_nvcCombobox.Text;
                    CarEntity.Active_bit = true;
                    CarEntity.PlateType_nvc = "ايران";
                    CarEntity.YearType_nvc = "شمسی";
                    CarEntity.CountryID_int = 82;
                    CarEntity.Country_nvc = "ایران";
                    CarEntity.CountryCode_nvc = "115";
                    CarFactory.Insert(CarEntity);

                }
                else if (dt.Count > 0)
                {
                    CarEntity = dt.FirstOrDefault();
                    CarEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                    CarEntity.NumberPlate_nvc = NumberPlate_nvcTextBox.Text;
                    CarEntity.SerialPlate_nvc = SerialPlate_nvcTextBox.Text;
                    CarEntity.PlateCityID_int = 311;
                    CarEntity.CarCardDate_nvc = CarCardDate_nvcTextBox.Text;
                    CarEntity.System_nvc = System_nvcCombobox.Text;
                    CarEntity.Active_bit = true;
                    CarFactory.Update(CarEntity, new BLL.CarBLL.BLLCar_TKeys() { CarID_int = CarFactory.GetAllBy(BLL.CarBLL.BLLCar_T.Car_TField.CarCardNumber_nvc, CarCardNumber).FirstOrDefault().CarID_int });
                }

            }


        }

        private void LastCarTrafficButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string TrafficCondition = string.Empty;
            TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
            TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);

            string TurnNumberCondition = string.Empty;
            if (PlateCityCode_nvcTextBox.Text != "" || NumberPlate_nvcTextBox.Text != "")
            {
                TrafficCondition = "([Traffic_T].[NumberPlate_nvc]= '" + NumberPlate_nvcTextBox.Text + "')  AND ([Traffic_T].[PlateCityID_int]=" + (Int32?)PlateCityEntity.PlateCityID_int + ")";


                if (TrafficCondition != null && TrafficList != null && TrafficList.Count > 0 && TrafficCondition != "")
                {
                    HPS.Present.Traffic.LastCarTraffic frm = new HPS.Present.Traffic.LastCarTraffic(NumberPlate_nvcTextBox.Text, (Int32?)PlateCityEntity.PlateCityID_int);
                    if (frm != null)
                    {
                        frm.Show();
                    }

                }
                else
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "کامیون با مشخصات"));
                }
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "کامیون با مشخصات"));
            }
        }

        private void CarSearchButton_Click(object sender, EventArgs e)
        {
            //CarWithoutCardcheckBox.Checked = false;
            HPS.Present.SearchForm.CarSearchForTraffic frm = new HPS.Present.SearchForm.CarSearchForTraffic();
            CarList = new List<HPS.BLL.CarBLL.BLLCar_T>();
            if (frm.ShowDialog() != DialogResult.Cancel)
            {
                CarList.Add(frm.SelectedCar);
                FillCarByCarList();
            }
        }


        private void FillCar()
        {
            try
            {
                //CarList = new List<HPS.BLL.CarBLL.BLLCar_T>();
                //CarCondition = "([Car_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "') AND ([Car_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "')";
                //CarList = CarFactory.GetAllByCondition(CarCondition);

                //if (CarList.Count == 1)
                //{
                //    FillCarByCarList();
                //}
                //else
                //{
                //    HPS.Present.SearchForm.CarSearch frm = new HPS.Present.SearchForm.CarSearch(NumberPlate_nvcTextBox.Text);
                //    CarList.Clear();
                //    if (frm.ShowDialog() != DialogResult.Cancel)
                //    {
                //        CarList.Add(frm.SelectedCar);
                //        FillCarByCarList();
                //    }

                //    else
                //    {
                //        ClearForm();
                //    }
                //}

                //if ( CarList.Count == 0)
                //{
                tCondition = string.Empty;

                if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    tCondition = "([Traffic_T].TrafficTypeID_int=1 AND [Traffic_T].[CarCardNumber_nvc]='" + CarCardNumber_nvcTextBox.Text + "') AND ([Traffic_T].[In_bit]='true')  ORDER BY TrafficID_bint  ";

                }
                else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                {
                    tCondition = "([Traffic_T].TrafficTypeID_int=1 AND [Traffic_T].[NumberPlate_nvc]=N'" + NumberPlate_nvcTextBox.Text + "') AND ([Traffic_T].[In_bit]='true') AND ([Traffic_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "') ORDER BY TrafficID_bint ";
                }

                TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
                if (!string.IsNullOrEmpty(tCondition))
                {
                    TrafficList = TrafficFactory.GetAllByCondition(tCondition);
                    if (TrafficList != null && TrafficList.Count > 0)
                    {
                        if (!stopReadProcess)
                        {
                            ClearCar();
                        }
                        CarCardNumber_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].CarCardNumber_nvc;
                        CarCardDate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].CarCardDate_nvc;
                        NumberPlate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].NumberPlate_nvc;
                        SerialPlate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].SerialPlate_nvc;

                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficList[TrafficList.Count - 1].LaderTypeID_int, TypeCode.Int32);

                        if (TrafficList[TrafficList.Count - 1].LaderTypeID_int != null && TrafficList[TrafficList.Count - 1].LaderTypeID_int != 0)
                        {
                            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                            HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                            LaderKey.LaderTypeID_int = TrafficList[TrafficList.Count - 1].LaderTypeID_int;
                            HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderEntity = LaderTypeFactory.GetBy(LaderKey);
                            LaderTypeCode_nvcTextBox.Text = LaderEntity.LaderTypeCode_nvc;
                        }
                        ProductionYear_intNumericTextBox.Text = TrafficList[TrafficList.Count - 1].ProductionYear_int.ToString();
                        System_nvcCombobox.Text = TrafficList[TrafficList.Count - 1].System_nvc;
                        YearType_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].YearType_nvc;
                    }
                    else
                    {
                        //if (!string.IsNullOrEmpty(NumberPlate_nvcTextBoxCamera.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBoxCamera.Text))
                        //{
                        //    NumberPlate_nvcTextBox.Text = NumberPlate_nvcTextBoxCamera.Text;
                        //    SerialPlate_nvcTextBox.Text = SerialPlate_nvcTextBoxCamera.Text;

                        //}
                        if (!stopReadProcess)
                        {
                            Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "کامیون با مشخصات"));
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(NumberPlate_nvcTextBoxCamera.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBoxCamera.Text))
                    {
                        NumberPlate_nvcTextBox.Text = NumberPlate_nvcTextBoxCamera.Text;
                        SerialPlate_nvcTextBox.Text = SerialPlate_nvcTextBoxCamera.Text;

                    }
                    Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "کامیون با مشخصات"));
                    //CarCardNumber_nvcTextBox.Focus();
                }
                //}
            }
            catch (Exception ex)
            {
                //Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                Hepsa.Core.Common.MessageBox.ErrorMessage("داده ای برای آخرین تردد یافت نشد");
            }
        }

        ////////////***************************************************************************************************
        /// /////////*************************************** INSERT*******************************************************
        /////////////******************************************************************************************************
        protected override void Insert()
        {
            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آیا مایل به ثبت ورود هستید ؟") == false)
                    return;

                DublicateTurn(DriverCardNumber_bintNumericTextBox.Text);

                if (this.LaderTypeID_intComboBox.SelectedValue == null)
                    throw new ApplicationException("بارگیر انتخاب نشده است");
                if (this.ServicesID_intComboBox.SelectedValue == null)
                    throw new ApplicationException("مراجعه به انتخاب نشده است");
                if (string.IsNullOrEmpty(this.NumberPlate_nvcTextBox.Text.Trim()) || string.IsNullOrEmpty(this.SerialPlate_nvcTextBox.Text.Trim()))
                    throw new ApplicationException("اطلاعات خودرو خالی است");
                if (this.PriceWithTax_decNumericTextBox == null || string.IsNullOrEmpty(this.PriceWithTax_decNumericTextBox.Text.Trim()) || string.IsNullOrEmpty(this.PriceWithTax_decNumericTextBox.Text.Trim()))
                    throw new ApplicationException("مبلغ دریافتی خالی است");


                HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();

                ErrorString.Clear();


                if ((Int32)ServicesID_intComboBox.SelectedValue == 2)
                {
                    if (String.IsNullOrEmpty(FirstName_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("نام راننده خالی است");
                    }
                    if (String.IsNullOrEmpty(LastName_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("نام خانوادگی راننده خالی است");
                    }
                    if (String.IsNullOrEmpty(DriverCardNumber_bintNumericTextBox.Text))
                    {
                        ErrorString.AppendLine("شماره کارت هوشمند راننده خالی است");
                    }
                    if (String.IsNullOrEmpty(DriverCardDate_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("تاریخ کارت هوشمند راننده خالی است");
                    }
                    string regex = @"(?:1[23]\d{2})\/(?:0?[1-9]|1[0-2])\/(?:0?[1-9]|[12][0-9]|3[01])$";
                    if (!Regex.IsMatch(DriverCardDate_nvcTextBox.Text, regex))
                    {
                        ErrorString.AppendLine("فرمت تاریخ کارت هوشمند صحیح نمی باشد");
                    }
                    if (String.IsNullOrEmpty(NationalCode_intNumericTextBox.Text))
                    {
                        ErrorString.AppendLine("شماره ملی راننده خالی است");
                    }
                    if (String.IsNullOrEmpty(Mobile_nvcnumericTextBox.Text))
                    {
                        ErrorString.AppendLine("شماره موبایل راننده خالی است");
                    }

                    if (String.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("شماره کارت هوشمند ناوگان خالی است");
                    }

                    if (System_nvcCombobox.SelectedValue == null)
                    {
                        ErrorString.AppendLine("نوع وسیله ناوگان خالی است");
                    }
                    if (LaderTypeID_intComboBox.SelectedValue == null)
                    {
                        ErrorString.AppendLine("نوع بارگیر ناوگان خالی است");
                    }
                    if (String.IsNullOrEmpty(ProductionYear_intNumericTextBox.Text))
                    {
                        ErrorString.AppendLine("سال ساخت ناوگان خالی است");
                    }
                    if (String.IsNullOrEmpty(YearType_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("نوع سال ناوگان خالی است");
                    }
                    if (String.IsNullOrEmpty(CarCardDate_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("تاریخ کارت هوشمند ناوگان خالی است");
                    }
                    if (String.IsNullOrEmpty(PlateCityCode_nvcTextBox.Text))
                    {
                        ErrorString.AppendLine("کد شهر ناوگان خالی است");
                    }



                    HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                    HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                    HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = null;

                    //نوبت جدید
                    TrafficEntity.TurnNumber_bint = TrafficFactory.GetLastTurnNumber();

                    SettingKey.SettingID_int = 1001;
                    SettingEntity = SettingsFactory.GetBy(SettingKey);
                    if (SettingEntity != null)
                    {
                        TrafficEntity.TurnHour_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(SettingEntity.Value_nvc, TypeCode.Int32);
                    }
                    //}
                }
                if (String.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
                {
                    ErrorString.AppendLine("شماره پلاک ناوگان خالی است");
                }
                if (String.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                {
                    ErrorString.AppendLine("سری ناوگان خالی است");
                }
                if (PlateCityID_intComboBox.SelectedValue == null)
                {
                    ErrorString.AppendLine(" شهر شماره گذاری ناوگان خالی است");
                }
                if (ErrorString.Length > 0)
                {
                    throw new ApplicationException(ErrorString.ToString());
                }
                //Common Informations
                TrafficEntity.In_bit = true;
                TrafficEntity.Out_bit = false;
                TrafficEntity.TemporaryOut_bit = false;
                TrafficEntity.TrafficTypeID_int = 1;
                TrafficEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                TrafficEntity.Date_nvc = TrafficFactory.ServerJalaliDate;
                TrafficEntity.Time_nvc = TrafficFactory.ServerTime;
                TrafficEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress;
                TrafficEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                TrafficEntity.Printed_bit = false;
                TrafficEntity.FirstName_nvc = FirstName_nvcTextBox.Text;
                TrafficEntity.LastName_nvc = LastName_nvcTextBox.Text;
                TrafficEntity.TurnPrinted_bit = false;
                TrafficEntity.ServiceID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntity.Services_nvc = (string)Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(this.ServicesID_intComboBox);
                TrafficEntity.WithFlat_bit = this.WithFlatRadioButton.Checked;
                TrafficEntity.WithLade_bit = this.WithLade_bitRadioButton.Checked;
                TrafficEntity.Hourse_bit = this.HorseRradioButton.Checked;
                TrafficEntity.Area_bit = AreacheckBox.Checked;
                TrafficEntity.LadeReturn_bit = LadeReturnCheckBox.Checked;
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                string BillCondition = "([BillMessage_T].[StartDate_nvc]<='" + BillMessageFactory.ServerJalaliDate + "') AND ([BillMessage_T].[EndDate_nvc]>= '" + BillMessageFactory.ServerJalaliDate + "') AND (TrafficType_T.TrafficTypeID_int=1)";
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(BillCondition);
                if (BillMessageList != null && BillMessageList.Count > 0)
                {
                    TrafficEntity.BillMessageID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageList[0].BillMessageID_int, TypeCode.Int32);
                }

                TrafficEntity.Comment_nvc = this.Comment_nvcTextBox.Text;
                string ComputerCondition = "[Computer_T].[MacAddress_nvc]='" + Hepsa.Core.Common.ApplicationInfo.MacAddress + "'";
                List<HPS.BLL.ComputerBLL.BLLComputer_T> ComputerList = ComputerFactory.GetAllByCondition(ComputerCondition);
                if (ComputerList != null && ComputerList.Count > 0)
                {
                    TrafficEntity.ComputerID_int = (int)Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerList[0].ComputerID_int, TypeCode.Int32);
                    TrafficEntity.Computer_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerList[0].Computer_nvc, TypeCode.String));
                }
                //بررسی درستی شماره پلاک--94-12-19--
                if (NumberPlate_nvcTextBox.Text.Length > 6)
                {
                    string numberplate_nvc = NumberPlate_nvcTextBox.Text.Substring(2, 3);

                    if (numberplate_nvc.Contains("0"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("1"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("2"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("3"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("4"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("5"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("6"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("7"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("8"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }
                    else if (numberplate_nvc.Contains("9"))
                    {
                        throw new ApplicationException("پلاک ورودی اشتباه است");
                    }

                }


                //Car Informations

                TrafficEntity.NumberPlate_nvc = this.NumberPlate_nvcTextBox.Text;
                TrafficEntity.SerialPlate_nvc = this.SerialPlate_nvcTextBox.Text;
                TrafficEntity.SystemCode_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(this.System_nvcCombobox.SelectedValue, TypeCode.String);
                TrafficEntity.System_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(this.System_nvcCombobox), TypeCode.String);
                TrafficEntity.LaderTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.LaderTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntity.LaderTypeCode_nvc = this.LaderTypeCode_nvcTextBox.Text;
                TrafficEntity.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                TrafficEntity.CarCardDate_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(CarCardDate_nvcTextBox.Text, TypeCode.String);
                TrafficEntity.CarCardRead_bit = false;


                TrafficEntity.CarID_int = null;
                TrafficEntity.Capacity_flt = null;
                int convertableyearType = 0;
                Int32.TryParse(Hepsa.Core.Common.PersentationController.GetEntityValue(this.ProductionYear_intNumericTextBox.Text, TypeCode.Int32).ToString(), out convertableyearType);
                if (convertableyearType > 0)
                {
                    TrafficEntity.ProductionYear_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ProductionYear_intNumericTextBox.NumericText, TypeCode.Int32);
                }
                TrafficEntity.YearType_nvc = this.YearType_nvcTextBox.Text;
                TrafficEntity.PlateCityID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.PlateCityID_intComboBox.SelectedValue, TypeCode.Int32);

                //Driver Informations
                TrafficEntity.DriverCardDate_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardDate_nvcTextBox.Text, TypeCode.String));
                TrafficEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_bintNumericTextBox.Text, TypeCode.String).ToString();
                TrafficEntity.DriverType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverType_nvc.Text, TypeCode.String).ToString();
                TrafficEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntity.licenceNumber_int = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_intNumericTextBox.NumericText, TypeCode.Int64);
                TrafficEntity.NationalCode_int = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
                TrafficEntity.DriverCardRead_bit = false;
                TrafficEntity.DriverMobileNumber_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_nvcnumericTextBox.Text, TypeCode.String));


                //تخلف
                #region
                string InfractionCondition = string.Format("[Infraction_T].NumberPlate_nvc='{0}'  AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}' AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, PlateCityCode_nvcTextBox.Text);
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                if (InfractionList != null && InfractionList.Count > 0)
                {
                    //جلوگیری از ثبت نوبت
                    if (TrafficEntity.ServiceID_int == 2 && InfractionList[0].TurnSave_bit)
                    {
                        throw new ApplicationException("ناوگان متخلف است" + "(" + InfractionList[0].CommentControl_nvc + ")");
                    }
                    else if (TrafficEntity.ServiceID_int == 1 && InfractionList[0].Traffic_bit)//خطا در هنگام ورود به پارکینگ
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("ناوگان متخلف است" + " (" + InfractionList[0].CommentControl_nvc + ")");
                    }
                    else
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("ناوگان متخلف است");
                    }
                }

                Int32? CarID = null;
                if (CarList != null && CarList.Count > 0)
                {
                    CarID = CarList[0].CarID_int;
                }

                string FirstName = string.Empty;
                string LastName = string.Empty;

                if (TrafficEntity.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DriverInfractionRule") == false)
                {
                    Hepsa.Core.Validation.InvalidBusinessObjectException exception = new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntity.BrokenRulesList().ToString());
                    Hepsa.Core.Common.MessageBox.InformationMessage(exception.Message);
                }

                #endregion
                //Turn Information
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = this.GetStopFee(StopFeeFactory.ServerJalaliDate, (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"], TypeCode.Int32), (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32), this.WithLade_bitRadioButton.Checked);
                if (StopFeeList != null && StopFeeList.Count > 0)
                {
                    TrafficEntity.StopFeeID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].StopFeeID_int, TypeCode.Int32);
                    TrafficEntity.AllowableHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].AllowedHoure_int, TypeCode.Int32);
                    TrafficEntity.ExtraHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHour_int, TypeCode.Int32);
                    if (WithLade_bitRadioButton.Checked)
                    {
                        TrafficEntity.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].WithLadeExtraHourFee_dec, TypeCode.Decimal);
                        TrafficEntity.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal);
                    }
                    else
                    {
                        TrafficEntity.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHourFee_dec, TypeCode.Decimal);
                        TrafficEntity.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal);
                    }
                }
                else
                {
                    throw new ApplicationException(HPS.Exceptions.ExceptionCs.StopFeeNotExist);
                }

                if ((NumberPlate_nvcTextBox.Text != NumberPlate_nvcTextBoxCamera.Text || SerialPlate_nvcTextBox.Text != SerialPlate_nvcTextBoxCamera.Text) && (new HPS.BLL.SettingsBLL.BLLSetting_TFactory()).GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1027 }).Value_nvc == "1")
                {
                    Hepsa.Core.Common.MessageBox.InformationMessage("شماره پلاک و سری دوربین با شماره پلاک و سری ثبت شده مطابقت ندارد");
                }
                SettingKey.SettingID_int = 1010;
                SettingEntity = SettingFactory.GetBy(SettingKey);
                if (SettingEntity.Value_nvc.ToString() == "1")
                {
                    if (TrafficEntity.ServiceID_int == 2 && CarObject != null && (CarObject[1].ToString() != NumberPlate_nvcTextBox.Text || CarObject[2].ToString() != SerialPlate_nvcTextBox.Text))
                    {
                        throw new ApplicationException("شماره پلاک و سریال با مشخصات کارت هوشمند مطابقت ندارد. لطفاً عملیات استعلام شماره کارت هوشمند را انجام دهید");
                    }
                }

                TrafficEntity.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.PriceWithTax_decNumericTextBox.NumericText, TypeCode.Decimal);
                TrafficEntity.PriceTax_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.PriceTax_decnumericTextBox.NumericText, TypeCode.Decimal);
                HPS.BLL.TrafficBLL.BLLTraffic_T.TrafficStatus CarStatus = TrafficFactory.GetCarStatus(TrafficEntity.NumberPlate_nvc, TrafficEntity.SerialPlate_nvc, TrafficEntity.CarCardNumber_nvc);
                DataTable TrafficStatusDataTable = new DataTable();
                TrafficFactory.GetTrafficStatus(TrafficEntity.NumberPlate_nvc, TrafficEntity.SerialPlate_nvc, TrafficEntity.CarCardNumber_nvc, TrafficStatusDataTable);
                if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                {
                    if ((int)TrafficStatusDataTable.Rows[0]["Status"] == 1)
                    {
                        throw new ApplicationException(string.Format("ناوگان به شماره قبض {0} خارج نشده است", TrafficStatusDataTable.Rows[0]["TrafficNumber_bint"]));
                    }
                }


                TrafficEntity.CameraPlateNumber_nvc = NumberPlate_nvcTextBoxCamera.Text;

                if (string.IsNullOrEmpty(SerialPlate_nvcTextBoxCamera.Text))
                {
                    TrafficEntity.CameraSerialPlate_int = null;
                }
                else
                    TrafficEntity.CameraSerialPlate_int = Convert.ToInt32(SerialPlate_nvcTextBoxCamera.Text);

                if (!TrafficEntity.Price_dec.HasValue || string.IsNullOrEmpty(PriceWithTax_decNumericTextBox.Text))
                {
                    throw new ApplicationException("مبلغ خالی است");
                }
                if (TrafficEntity.ServiceID_int == 2)
                {

                    CheckTravelTimePassed(TrafficEntity.CarCardNumber_nvc);
                    if (!IsTravelTimePassedVariable)
                    {
                        return;
                    }
                }
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(" " + TrafficEntity.Price_dec + "ر يا ل باید از راننده گرفته شود.  آیا از ثبت اطلاعات اطمینان دارید؟  ") == true)
                {
                    TrafficFactory.BeginProc();
                    TrafficFactory.Insert(TrafficEntity);

                    // بروز رسانی اطلاعات راننده
                    UpdateDriverSpecification(DriverCardNumber_bintNumericTextBox.Text);
                    //SettingID_int = 1012 => خواندن پلاک در هنگام ورود
                    SettingKey.SettingID_int = 1012;
                    SettingEntity = SettingFactory.GetBy(SettingKey);

                    //////Insert TrafficPicture
                    if (SettingEntity.Value_nvc == "1")
                    {
                        if (szBuffer[0] != 0)
                        {
                            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
                            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
                            TrafficPicturesEntity.TrafficID_bint = TrafficEntity.TrafficID_bint;
                            TrafficPicturesEntity.Picture_vbnry = szBuffer;
                            TrafficPicturesFactory.Insert(TrafficPicturesEntity);
                        }
                        else
                        {
                            throw new ApplicationException("عملیات خواندن پلاک رخ نداده است");
                        }
                    }

                    TrafficFactory.CommitProc();
                    szBuffer.ToList().Clear();
                    NumberPlateReadingButton.Enabled = true;
                    var trafficToPrint = TrafficFactory.GetBy(new BLL.TrafficBLL.BLLTraffic_TKeys() { TrafficID_bint = TrafficEntity.TrafficID_bint });
                    if (trafficToPrint != null)
                    {
                        if (TrafficEntity.ServiceID_int == 2)
                        {
                            HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(trafficToPrint, false, false);
                            frm.ShowDialog();
                        }
                        else
                        {
                            HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(trafficToPrint, true, false);
                            frm.ShowDialog();
                        }
                    }


                    if (!string.IsNullOrEmpty(DriverCardNumber_bintNumericTextBox.Text))
                    {
                        DriverInsertOrUpdate(DriverCardNumber_bintNumericTextBox.Text);
                        CarInsertOrUpdate(CarCardNumber_nvcTextBox.Text);
                    }
                    this.ClearForm();
                    CarFromcard = false;
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, 11320002, TypeCode.Int32);
                    TrafficEntity.DriverCardRead_bit = false;
                    TrafficEntity.CarCardRead_bit = false;
                    WithFlatRadioButton.Checked = true;
                    WithoutLade_bitRadioButton.Checked = true;
                    DriverList = null;
                    stopReadProcess = false;
                }
                //   }
                // }
            }
            catch (Exception ex)
            {
                TrafficFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        protected override void Edit()
        {
            try
            {
                DublicateTurnOnEdit(DriverCardNumber_bintNumericTextBox.Text);
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.TrafficID_bint, TrafficKey.TrafficID_bint);
                if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                {

                    if (LadBillCreditList[LadBillCreditList.Count - 1].Canceled_bit == false)
                    {
                        //pep
                        if (HPS.Common.CurrentUser.user.UserGroupID_int != 1)
                        {
                            throw new ApplicationException("این راننده و ناوگان مجوز گرفته است");
                        }

                    }
                }
                if (this.LaderTypeID_intComboBox.SelectedValue == null)
                    throw new ApplicationException("بارگیر انتخاب نشده است");
                if (this.ServicesID_intComboBox.SelectedValue == null)
                    throw new ApplicationException("مراجعه به انتخاب نشده است");
                if (string.IsNullOrEmpty(this.NumberPlate_nvcTextBox.Text.Trim()) || string.IsNullOrEmpty(this.SerialPlate_nvcTextBox.Text.Trim()))
                    throw new ApplicationException("اطلاعات خودرو خالی است");

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityUpdate = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityUpdateBeforeChanges = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                TrafficEntityUpdateBeforeChanges = TrafficFactory.GetBy(TrafficKey);
                TrafficEntityUpdate = TrafficFactory.GetBy(TrafficKey);
                if (TrafficEntityUpdate.ServiceID_int != 2 && (Int32)ServicesID_intComboBox.SelectedValue == 2)
                {
                    throw new Exception("امکان تغییر نوع مراجعه از غیر ثبت نوبت به این نوع وجود ندارد");
                }

                if (TrafficEntityUpdate.ServiceID_int == 2 && (Int32)ServicesID_intComboBox.SelectedValue != 2)
                {
                    throw new Exception("امکان تغییر نوع مراجعه از  ثبت نوبت به این نوع وجود ندارد");
                }

                if (TrafficEntityUpdate.NumberPlate_nvc != NumberPlate_nvcTextBox.Text && TrafficEntityUpdate.SerialPlate_nvc != SerialPlate_nvcTextBox.Text)
                {
                    DataTable TrafficStatusDataTable = new DataTable();
                    TrafficFactory.GetTrafficStatus(NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, string.Empty, TrafficStatusDataTable);

                    DataTable TrafficDataTable = new DataTable();
                    if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                    {
                        if ((int)TrafficStatusDataTable.Rows[0]["Status"] == 1)
                        {
                            throw new ApplicationException(string.Format("ناوگان به شماره قبض {0} خارج نشده است", TrafficStatusDataTable.Rows[0]["TrafficNumber_bint"]));
                        }
                    }
                }
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
                PlateCityKey.PlateCityID_int = TrafficEntityUpdate.PlateCityID_int;
                PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);

                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                string InfractionCondition = string.Format("([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.NumberPlate_nvc='{0}' AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}'", TrafficEntityUpdate.NumberPlate_nvc, TrafficEntityUpdate.SerialPlate_nvc, PlateCityEntity.PlateCityCode_nvc);
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                if (InfractionList != null && InfractionList.Count > 0)
                {
                    throw new ApplicationException("این ناوگان متخلف است امکان ثبت تغییرات وجود ندارد");
                }
                decimal Fee = TrafficEntityUpdate.Price_dec.Value;
                TrafficEntityUpdate.Area_bit = AreacheckBox.Checked;
                TrafficEntityUpdate.LadeReturn_bit = LadeReturnCheckBox.Checked;
                TrafficEntityUpdate.DriverCardDate_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardDate_nvcTextBox.Text, TypeCode.String));
                TrafficEntityUpdate.DriverCardNumber_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_bintNumericTextBox.Text, TypeCode.String));
                TrafficEntityUpdate.FirstName_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String));
                TrafficEntityUpdate.LastName_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String));
                if (!string.IsNullOrEmpty(licenceNumber_intNumericTextBox.NumericText))
                {
                    TrafficEntityUpdate.licenceNumber_int = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_intNumericTextBox.NumericText, TypeCode.Int64);
                }
                TrafficEntityUpdate.NationalCode_int = Convert.ToInt64(string.IsNullOrEmpty(NationalCode_intNumericTextBox.NumericText) ? null : NationalCode_intNumericTextBox.NumericText);
                TrafficEntityUpdate.WithLade_bit = WithLade_bitRadioButton.Checked;
                TrafficEntityUpdate.DriverMobileNumber_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_nvcnumericTextBox.Text, TypeCode.String));
                if (string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text.Trim()) || string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text.Trim()))
                {
                    throw new ApplicationException("شماره یا سری پلاک خالی است");
                }
                else
                {
                    TrafficEntityUpdate.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                    TrafficEntityUpdate.CarCardNumber_nvc = CarCardNumber_nvcTextBox.Text;
                    TrafficEntityUpdate.CarCardDate_nvc = CarCardDate_nvcTextBox.Text;
                    TrafficEntityUpdate.ProductionYear_int = Convert.ToInt32(ProductionYear_intNumericTextBox.NumericText);
                    TrafficEntityUpdate.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                    TrafficEntityUpdate.PlateCityID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityID_intComboBox.SelectedValue, TypeCode.Int32);
                }
                TrafficEntityUpdate.System_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcCombobox.Text, TypeCode.String).ToString();
                //TrafficEntityUpdate.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                if (LaderTypeID_intComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("بارگیر انتخاب نشده است");
                }
                else
                {
                    TrafficEntityUpdate.LaderTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                    TrafficEntityUpdate.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();

                }

                TrafficEntityUpdate.Printed_bit = false;
                HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
                string ComputerCondition = "[Computer_T].[IPAddress_nvc]='" + Hepsa.Core.Common.ApplicationInfo.IpAddress + "' AND [Computer_T].[MacAddress_nvc]='" + Hepsa.Core.Common.ApplicationInfo.MacAddress + "'";
                List<HPS.BLL.ComputerBLL.BLLComputer_T> ComputerList = ComputerFactory.GetAllByCondition(ComputerCondition);
                if (ComputerList.Count > 0 && ComputerList != null)
                {
                    TrafficEntityUpdate.ComputerID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerList[0].ComputerID_int, TypeCode.Int32);
                    TrafficEntityUpdate.Computer_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerList[0].Computer_nvc, TypeCode.String).ToString();
                }
                TrafficEntityUpdate.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress;
                TrafficEntityUpdate.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;

                TrafficEntityUpdate.TrafficTypeID_int = 1;

                HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1001;
                Int32 _TurnHour = 0;
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = settingsFactory.GetBy(SettingKey);
                if (SettingEntity != null)
                {
                    _TurnHour = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(SettingEntity.Value_nvc, TypeCode.Int32);
                }


                TrafficEntityUpdate.ServiceID_int = (Int32)ServicesID_intComboBox.SelectedValue;
                //Turn Information
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = this.GetStopFee(StopFeeFactory.ServerJalaliDate, (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"], TypeCode.Int32), (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32), this.WithLade_bitRadioButton.Checked);
                if (StopFeeList != null && StopFeeList.Count > 0)
                {
                    TrafficEntityUpdate.StopFeeID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].StopFeeID_int, TypeCode.Int32);
                    TrafficEntityUpdate.AllowableHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].AllowedHoure_int, TypeCode.Int32);
                    TrafficEntityUpdate.ExtraHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHour_int, TypeCode.Int32);
                    //if ((Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32) != 2)
                    //{
                    if (WithLade_bitRadioButton.Checked)
                    {
                        TrafficEntityUpdate.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].WithLadeExtraHourFee_dec, TypeCode.Decimal);
                        TrafficEntityUpdate.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal);
                    }
                    else
                    {
                        TrafficEntityUpdate.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHourFee_dec, TypeCode.Decimal);
                        TrafficEntityUpdate.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal);
                    }
                    //}
                    //else
                    //{
                    //    TrafficEntityUpdate.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHourFee_dec, TypeCode.Decimal);
                    //    TrafficEntityUpdate.Fee_dec = 0;
                    //}
                }
                TrafficEntityUpdate.Price_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.PriceWithTax_decNumericTextBox.NumericText, TypeCode.Decimal);
                TrafficEntityUpdate.PriceTax_dec = (decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.PriceTax_decnumericTextBox.NumericText, TypeCode.Decimal);
                if (LaderTypeID_intComboBox.SelectedIndex == -1)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage("بارگیر انتخاب نشده است");
                    return;
                }


                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                string BillCondition = "([BillMessage_T].[StartDate_nvc]<='" + BillMessageFactory.ServerJalaliDate + "') AND ([BillMessage_T].[EndDate_nvc]>= '" + BillMessageFactory.ServerJalaliDate + "' ) AND (TrafficType_T.TrafficTypeID_int=1)";
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(BillCondition);
                if (BillMessageList != null && BillMessageList.Count > 0)
                {
                    TrafficEntityUpdate.BillMessageID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageList[0].BillMessageID_int, TypeCode.Int32);
                }

                //  TrafficEntityUpdate.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                TrafficEntityUpdate.EditUserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                TrafficEntityUpdate.EditDate_vc = BillMessageFactory.ServerJalaliDate;
                TrafficEntityUpdate.EditTime_vc = BillMessageFactory.ServerTime;



                #region Infraction

                PlateCityKey.PlateCityID_int = TrafficEntityUpdate.PlateCityID_int;
                PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);

                InfractionCondition = string.Format("([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.NumberPlate_nvc='{0}' AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}'", TrafficEntityUpdate.NumberPlate_nvc, TrafficEntityUpdate.SerialPlate_nvc, PlateCityEntity.PlateCityCode_nvc);
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionListAfterchange = InfractionFactory.GetAllByCondition(InfractionCondition);
                if (InfractionListAfterchange != null && InfractionListAfterchange.Count > 0)
                {
                    throw new ApplicationException("این ناوگان متخلف است امکان ثبت تغییرات وجود ندارد");
                }
                #endregion

                #region HasNot Out Check

                //string ConditionOut = string.Empty;
                //if (!string.IsNullOrEmpty(TrafficEntityUpdate.CarCardNumber_nvc))
                //{
                //    ConditionOut = string.Format("T.TrafficTypeID_int=1 AND T.NumberPlate_nvc='{0}' AND T.SerialPlate_nvc='{1}' AND T.CarCardNumber_nvc=N'{2}'", TrafficEntityUpdate.NumberPlate_nvc, TrafficEntityUpdate.SerialPlate_nvc, TrafficEntityUpdate.CarCardNumber_nvc);
                //}
                //else
                //{
                //    ConditionOut = string.Format("T.TrafficTypeID_int=1 AND T.NumberPlate_nvc='{0}' AND T.SerialPlate_nvc='{1}'", TrafficEntityUpdate.NumberPlate_nvc, TrafficEntityUpdate.SerialPlate_nvc);
                //}
                //DataTable TempDataTable = new DataTable();
                //TrafficFactory.GetConditionLastTraffic(ConditionOut, ref TempDataTable);

                //if (TempDataTable != null && TempDataTable.Rows.Count>0)
                //{
                //    if ((bool)Hepsa.Core.Common.PersentationController.GetEntityValue(TempDataTable.Rows[TempDataTable.Rows.Count - 1]["Out_bit"], TypeCode.Boolean) == false)
                //    {
                //        if (TempDataTable.Rows.Count >1)
                //        {

                //            throw new ApplicationException(string.Format("ناوگان به شماره پلاک <{1}-{0}> قبل از خروج ورود داشته است امکان تغییرات وجود ندارد", TrafficEntityUpdate.NumberPlate_nvc, TrafficEntityUpdate.SerialPlate_nvc));//("این ناوگان قبل از خروج ورود داشته است امکان تغییرات وجود ندارد");
                //        }
                //    }
                //}
                #endregion

                //////////////////////////////////////////////////////////////
                if (TrafficEntityUpdate.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Validate, "DuplicateTurnNumberInUpdateRule") == false)
                {
                    Hepsa.Core.Validation.InvalidBusinessObjectException exception = new Hepsa.Core.Validation.InvalidBusinessObjectException(TrafficEntityUpdate.BrokenRulesList().ToString());
                    if (HPS.Common.CurrentUser.user.UserGroupID_int != 1)
                    {
                        throw new ApplicationException(exception.Message);
                    }
                    else
                    {
                        MessageBox.Show(exception.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if ((NumberPlate_nvcTextBox.Text != NumberPlate_nvcTextBoxCamera.Text || SerialPlate_nvcTextBox.Text != SerialPlate_nvcTextBoxCamera.Text) && (new HPS.BLL.SettingsBLL.BLLSetting_TFactory()).GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1027 }).Value_nvc == "1")
                {
                    Hepsa.Core.Common.MessageBox.InformationMessage("شماره پلاک و سری دوربین با شماره پلاک و سری ثبت شده مطابقت ندارد");
                }
                //////////////////////////////////////////////////////////////
                string priceConfirnMessage = string.Empty;
                if (TrafficEntityUpdate.Price_dec - Fee > 0)
                {
                    priceConfirnMessage = string.Format("{0}ريا ل باید از راننده گرفته شود.  ", TrafficEntityUpdate.Price_dec.Value - Fee);
                }
                if (TrafficEntityUpdate.Price_dec.Value - Fee < 0)
                {
                    priceConfirnMessage = string.Format("{0}ريا ل باید به راننده داده شود.  ", Fee - TrafficEntityUpdate.Price_dec.Value);
                }

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(priceConfirnMessage + "آیا از ثبت اطلاعات اطمینان دارید؟") == true)
                {

                    TrafficFactory.BeginProc();
                    TrafficFactory.Update(TrafficEntityUpdate, TrafficKey);
                    TrafficFactory.CommitProc();

                    if (_EditWithPrint == true)
                    {
                        //HPS.Reports.ReportDoc.TrafficReport  rpt = new HPS.Reports.ReportDoc.TrafficReport(TrafficEntityUpdate );
                        //rpt.Document.Printer.PrinterName = string.Empty;
                        //rpt.Run();
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



                        if (TrafficEntityUpdate.ServiceID_int == 2)
                        {

                            HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntityUpdate, false, false);
                            frm.ShowDialog();
                            //
                        }
                        else
                        {

                            HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntityUpdate, true, false);
                            frm.ShowDialog();
                        }
                    }

                    CarInsertOrUpdate(CarCardNumber_nvcTextBox.Text);
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint.ToString() + "='" + ((HPS.BLL.TrafficBLL.BLLTraffic_TKeys)Key).TrafficID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {

                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.Time_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.TrafficNumber_bint, TypeCode.Int64);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.NumberPlate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.SerialPlate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Date_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.Date_nvc, TypeCode.String);
                            dr[0][HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Time_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.Time_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.System_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.System_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.TrafficNumber_bint, TypeCode.Int64);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.DriverCardNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.CarCardNumber_nvc, TypeCode.String);
                            dr[0]["ServiceID_intServiceType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(ServicesID_intComboBox);
                            dr[0]["LaderTypeID_intLaderType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderTypeID_intComboBox);
                            dr[0]["PlateCityID_intPlateCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PlateCityID_intComboBox);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditUserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.EditUserName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditDate_vc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.EditDate_vc, TypeCode.String);
                            dr[0][HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditTime_vc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(TrafficEntityUpdate.EditTime_vc, TypeCode.String);
                        }
                        DataTable.AcceptChanges();
                    }

                    this.ClearForm();
                    NumberPlate_nvcTextBox.Focus();
                    this.State = enmFormState.Add;
                    Editbutton.Enabled = false;
                    EditAndPrintbutton.Enabled = false;
                    NewButton.Enabled = true;
                }

                if (this.EditAndClose)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FillCombo()
        {
            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();

            string condition = "[Services_T].[Activie_bit]='true'";
            ServicesFactory.GetAllByCondition(condition, ref ServicesDataTable);
            if (ServicesDataTable != null)
            {
                DataRow[] dr1 = ServicesDataTable.Select("ServicesType_nvc In ('تير پارك')");
                if (dr1 != null && dr1.Length > 0)
                {
                    foreach (DataRow row in dr1)
                        row.Delete();
                    ServicesDataTable.AcceptChanges();
                }
            }
            ServicesID_intComboBox.SelectedValueChanged -= new EventHandler(ServicesID_intComboBox_SelectedValueChanged);
            ServicesID_intComboBox.DataSource = ServicesDataTable;
            ServicesID_intComboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
            ServicesID_intComboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
            ServicesID_intComboBox.SelectedIndex = -1;
            ServicesID_intComboBox.SelectedValueChanged += new EventHandler(ServicesID_intComboBox_SelectedValueChanged);


            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityID_intFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            string PlateCityCondition = "[PlateCity_T].[Active_bit]='true'";
            PlateCityID_intFactory.GetAllByCondition(PlateCityCondition, ref PlateCityID_intDataTable);
            this.PlateCityID_intComboBox.DisplayMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCity_nvc.ToString();
            this.PlateCityID_intComboBox.ValueMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString();
            this.PlateCityID_intComboBox.DataSource = PlateCityID_intDataTable;
            PlateCityID_intComboBox.SelectedValue = 311;



            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();

            string laderCondition = "[LaderType_T].[Active_bit]='true'";
            LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
            this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
            this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
            LaderTypeID_intComboBox.SelectedValueChanged -= new EventHandler(LaderTypeID_intComboBox_SelectedValueChanged);
            this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
            this.LaderTypeID_intComboBox.SelectedIndex = -1;
            LaderTypeID_intComboBox.SelectedValueChanged += new EventHandler(LaderTypeID_intComboBox_SelectedValueChanged);

            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            DataTable CarSystemDataTable = new DataTable();
            CarFactory.CarSystemGetAll(ref CarSystemDataTable);
            System_nvcCombobox.DataSource = CarSystemDataTable;
            System_nvcCombobox.DisplayMember = HPS.BLL.CarBLL.BLLCar_T.Car_TField.System_nvc.ToString();
            System_nvcCombobox.ValueMember = HPS.BLL.CarBLL.BLLCar_T.Car_TField.SystemCode_nvc.ToString();
            System_nvcCombobox.SelectedIndex = -1;


        }

        private void DriverSearch_Click(object sender, EventArgs e)
        {
            try
            {
                WithoutCardcheckBox.Checked = false;
                HPS.Present.SearchForm.DriverSearchForTraffic frm = new HPS.Present.SearchForm.DriverSearchForTraffic();
                DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
                if (frm.ShowDialog() != DialogResult.Cancel)
                {
                    DriverList.Add(frm.SelectedDriver);
                    DriverFields();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FillDriverFields()
        {

            try
            {
                //DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
                //DriverCondition = "([Driver_T].[DriverCardNumber_nvc]='" + DriverCardNumber_bintNumericTextBox.Text + "') ";
                //DriverList = DriverFactory.GetAllByCondition(DriverCondition);

                //if (DriverList.Count == 1)
                //{
                //    DriverFields();
                //}
                //else
                //{

                //    HPS.Present.SearchForm.DriverSearch frm = new HPS.Present.SearchForm.DriverSearch();
                //    DriverList.Clear();
                //    if (frm.ShowDialog() != DialogResult.Cancel)
                //    {
                //        DriverList.Add(frm.SelectedDriver);
                //        DriverFields();
                //    }
                //    else
                //    {
                //        ClearForm();
                //    }
                //}

                //if (DriverCardNumber_bintNumericTextBox.Text != "" && DriverList.Count == 0)
                //{
                tCondition = "([Traffic_T].[DriverCardNumber_nvc]='" + DriverCardNumber_bintNumericTextBox.Text + "') AND ([Traffic_T].[In_bit]='true') order by trafficID_bint desc";
                TrafficList.Clear();
                TrafficList = TrafficFactory.GetAllByCondition(tCondition);
                if (TrafficList != null && TrafficList.Count > 0)
                {
                    DriverCardNumber_bintNumericTextBox.Text = TrafficList[0].DriverCardNumber_nvc;
                    DriverCardDate_nvcTextBox.Text = TrafficList[0].DriverCardDate_nvc;
                    NationalCode_intNumericTextBox.Text = Convert.ToString(TrafficList[0].NationalCode_int);
                    licenceNumber_intNumericTextBox.Text = Convert.ToString(TrafficList[0].licenceNumber_int);
                    DriverType_nvc.Text = TrafficList[0].DriverType_nvc;
                    FirstName_nvcTextBox.Text = TrafficList[0].FirstName_nvc;
                    LastName_nvcTextBox.Text = TrafficList[0].LastName_nvc;
                    Mobile_nvcnumericTextBox.Text = TrafficList[0].DriverMobileNumber_nvc;
                }
                //else
                //{
                //    Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "راننده با مشخصات"));
                //    DriverCardNumber_bintNumericTextBox.Focus();
                //}
                //}
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void DriverCorrectButton_Click(object sender, EventArgs e)
        {
            WithoutCardcheckBox.Checked = false;
            if (!string.IsNullOrEmpty(DriverCardNumber_bintNumericTextBox.Text) || !(string.IsNullOrEmpty(NationalCode_intNumericTextBox.NumericText) && string.IsNullOrEmpty(LastName_nvcTextBox.Text)))
            {
                DriverCardDate_nvcTextBox.Enabled = true;
                NationalCode_intNumericTextBox.Enabled = true;
                licenceNumber_intNumericTextBox.Enabled = true;
                DriverType_nvc.Enabled = true;
                FirstName_nvcTextBox.Enabled = true;
                LastName_nvcTextBox.Enabled = true;
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(HPS.Exceptions.ExceptionCs.DriverIsNotChosen);
            }

        }

        private void CarCorrectButton_Click(object sender, EventArgs e)
        {
            //CarWithoutCardcheckBox.Checked = false;
            if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) || !string.IsNullOrEmpty(PlateCityCode_nvcTextBox.Text) || !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
            {
                PlateCityID_intComboBox.Enabled = true;
                PlateCity_nvcBottun.Enabled = true;
                ProductionYear_intNumericTextBox.Enabled = true;
                YearType_nvcTextBox.Enabled = true;
                CarCardNumber_nvcTextBox.Enabled = true;
                CarCardDate_nvcTextBox.Enabled = true;
                System_nvcCombobox.Enabled = true;
                SerialPlate_nvcTextBox.Enabled = true;
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(HPS.Exceptions.ExceptionCs.CarIsNotChosen);
            }
        }

        private void PriceCorrectButton_Click(object sender, EventArgs e)
        {
            PriceTax_decnumericTextBox.Enabled = true;
            PriceWithoutTax_decnumericTextBox.Enabled = true;
            PriceWithTax_decNumericTextBox.Enabled = true;
        }

        private void AllDriverTrafficButoon_Click(object sender, EventArgs e)
        {
            WithoutCardcheckBox.Checked = false;
            HPS.Present.Traffic.AllDriverTrafficsFrom AllDriverTraffics = new HPS.Present.Traffic.AllDriverTrafficsFrom(DriverCardNumber_bintNumericTextBox.NumericText);
            AllDriverTraffics.ShowDialog();
        }

        private void AllCarTrafficButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Present.Traffic.AllCarTrafficsForm CarFrm = new HPS.Present.Traffic.AllCarTrafficsForm(NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, (Int32?)PlateCityEntity.PlateCityID_int);
                CarFrm.ShowDialog();
            }
            catch (Exception)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(HPS.Exceptions.ExceptionCs.CarIsNotChosen);
            }
            //CarWithoutCardcheckBox.Checked = false;
        }

        private void PlateCityID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this._CardReading)
                return;
            if (PlateCityID_intComboBox.SelectedIndex != -1)
            {
                PlateCityEntity.PlateCityID_int = (Int32?)PlateCityID_intComboBox.SelectedValue;
                PlateCityEntity.PlateCity_nvc = PlateCityID_intDataTable.Rows[Convert.ToInt32(PlateCityID_intComboBox.SelectedIndex)]["PlateCity_nvc"].ToString();
                PlateCityCode_nvcTextBox.Text = PlateCityID_intDataTable.Rows[Convert.ToInt32(PlateCityID_intComboBox.SelectedIndex)]["PlateCityCode_nvc"].ToString();
            }
            else
            {
                PlateCityEntity.PlateCityID_int = null;
                PlateCityEntity.PlateCity_nvc = string.Empty;
                PlateCityCode_nvcTextBox.Text = string.Empty;
            }
        }

        private void AllDriverTrafficButoon_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.AllDriverTrafficButoon, "ctrl+D");
        }

        private void AllCarTrafficButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.AllCarTrafficButton, "ctrl+A");
        }

        private void LastCarTrafficButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.LastCarTrafficButton, "ctrl+S");
        }

        private void LastDriverTrafficButoon_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.LastDriverTrafficButoon, "ctrl+F5");
        }

        private void IranianCarsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                if (AllDriverTrafficButoon.Visible)
                {
                    this.AllDriverTrafficButoon.PerformClick();
                }
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                if (AllCarTrafficButton.Visible)
                {
                    this.AllCarTrafficButton.PerformClick();
                }
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                if (LastDriverTrafficButoon.Visible)
                {
                    this.LastDriverTrafficButoon.PerformClick();
                }
            }
            else if (e.Alt && e.KeyCode == Keys.R)
            {
                if (DriverCardReadingButton.Visible)
                {
                    DriverCardReadingButton.PerformClick();
                }
            }
            //else if (e.Alt && e.KeyCode == Keys.P)
            else if (e.KeyCode == Keys.F7)
            {
                if (NumberPlateReadingButton.Visible)
                {
                    NumberPlateReadingButton.PerformClick();
                }
            }
            else if (e.Shift && e.KeyCode == Keys.P)
            {
                if (PreviousButton.Visible)
                {
                    PreviousButton.PerformClick();
                }
            }
            else if (e.Shift && e.KeyCode == Keys.N)
            {
                if (NextButton.Visible)
                {
                    NextButton.PerformClick();
                }
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                if (NewButton.Visible)
                {
                    NewButton.PerformClick();
                }
            }
            else if (e.Shift && e.KeyCode == Keys.E)
            {
                if (Editbutton.Visible)
                {
                    Editbutton.PerformClick();
                }
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                if (FurtherBillButton.Visible)
                {
                    FurtherBillButton.PerformClick();
                }
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                if (EditAndPrintbutton.Visible)
                {
                    EditAndPrintbutton.PerformClick();
                }
            }

        }

        private void LaderTypeID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            if (this._CardReading)
                return;
            try
            {

                if (LaderTypeID_intComboBox.SelectedIndex != -1)
                {
                    LaderTypeEntity.LaderTypeID_int = (Int32)LaderTypeID_intComboBox.SelectedValue;
                    LaderTypeEntity.LaderType_nvc = LaderTypeID_intDataTable.Rows[Convert.ToInt32(LaderTypeID_intComboBox.SelectedIndex)]["LaderType_nvc"].ToString();
                    LaderTypeCode_nvcTextBox.Text = LaderTypeID_intDataTable.Rows[Convert.ToInt32(LaderTypeID_intComboBox.SelectedIndex)]["LaderTypeCode_nvc"].ToString();
                    if (LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"] == null || LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"].ToString() == "")
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("برای بارگیر محور تعیین نشده است");
                        PriceWithTax_decNumericTextBox.Text = "";
                        PriceWithoutTax_decnumericTextBox.Text = "";
                        PriceWithTax_decNumericTextBox.Text = "";
                    }
                    else
                    {
                        SettingKey.SettingID_int = 1011;
                        string CompareDate = string.Empty;
                        SettingEntity = SettingFactory.GetBy(SettingKey);
                        List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = this.GetStopFee(StopFeeFactory.ServerJalaliDate, (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"], TypeCode.Int32), (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32), this.WithLade_bitRadioButton.Checked);
                        if (StopFeeList != null && StopFeeList.Count > 0)
                        { //PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                            PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                            if (StopFeeList[0].Tax_bit)
                            {
                                PriceTax_decnumericTextBox.Text = RoundNumber((double)(StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100)).ToString();
                                PriceWithTax_decNumericTextBox.Text = RoundNumber(Convert.ToDouble(StopFeeList[0].Fee_dec + StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100)).ToString();
                            }
                            else
                            {
                                PriceTax_decnumericTextBox.Text = "";
                                PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                            }
                        }
                        else if (ServicesID_intComboBox.SelectedValue != null)
                        {
                            throw new ApplicationException(HPS.Exceptions.ExceptionCs.StopFeeNotExist);
                        }
                    }
                }
                else
                {
                    LaderTypeEntity.LaderTypeID_int = null;
                    LaderTypeEntity.LaderType_nvc = string.Empty;
                    LaderTypeCode_nvcTextBox.Text = string.Empty;
                    PriceWithTax_decNumericTextBox.Text = string.Empty;
                    PriceWithoutTax_decnumericTextBox.Text = string.Empty;
                    PriceTax_decnumericTextBox.Text = string.Empty;
                }
                if (this.State == enmFormState.Add)
                {
                    // PriceCorrectButon.Enabled = true;
                }
                if (ServicesID_intComboBox.SelectedValue != null)
                {
                    if ((int)ServicesID_intComboBox.SelectedValue == 2)
                    {
                        ServicesID_intComboBox_SelectedValueChanged(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
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

        private bool CarFromcard = false;

        private async void NumberPlateReadingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServicesID_intComboBox.SelectedValue == null)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage("مراجعه به انتخاب نشده است");
                    return;
                }
                NumberPlateReadingButton.Enabled = false;
                string number = string.Empty;
                snapshot();
                //number = anprService.GetPlateNumberByByte(szBuffer);
                number = await api.GetNumberPlate(szBuffer);

                if (!string.IsNullOrEmpty(number) && number.Length > 7)
                {
                    HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new BLL.TruePlate.ConvertToTrueNumber();
                    string plateNumber_nvc = string.Empty;
                    string plateSerial_nvc = string.Empty;
                    NumberPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 9));
                    SerialPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(10, 2));

                    NumberPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 9));
                    SerialPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(number.Substring(10, 2));
                    // LoadCarOnline(CarCardNumber_nvcTextBox.Text);
                    FillCar();
                }
                else
                {
                    ClearCar();
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBoxCamera.Text = string.Empty;
                    SerialPlate_nvcTextBoxCamera.Text = string.Empty;
                    stopReadProcess = true;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(" خواندن پلاک مقدور نمی باشد");
            }
            finally
            {
                this._CardReading = false;
                await System.Threading.Tasks.Task.Run(() => {
                    System.Threading.Thread.Sleep(1500);
                    NumberPlateReadingButton.Enabled = true;
                });
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

        private void ClearDriver()
        {
            //DriverCardNumber_bintNumericTextBox.Text = string.Empty;
            DriverCardDate_nvcTextBox.Text = string.Empty;
            NationalCode_intNumericTextBox.Text = string.Empty;
            licenceNumber_intNumericTextBox.Text = string.Empty;
            DriverType_nvc.Text = string.Empty;
            FirstName_nvcTextBox.Text = string.Empty;
            LastName_nvcTextBox.Text = string.Empty;
            Mobile_nvcnumericTextBox.Text = string.Empty;
        }

        private void ClearCar()
        {
            NumberPlate_nvcTextBox.Text = string.Empty;
            SerialPlate_nvcTextBox.Text = string.Empty;
            ProductionYear_intNumericTextBox.Text = string.Empty;
            PlateCityCode_nvcTextBox.Text = string.Empty;

            ProductionYear_intNumericTextBox.Text = string.Empty;
            YearType_nvcTextBox.Text = string.Empty;
            CarCardNumber_nvcTextBox.Text = string.Empty;
            CarCardDate_nvcTextBox.Text = string.Empty;
            LaderTypeCode_nvcTextBox.Text = string.Empty;
            LaderTypeID_intComboBox.SelectedIndex = -1;
            System_nvcCombobox.SelectedIndex = -1;
            PlateCityID_intComboBox.SelectedValue = 311;
            PlateCityID_intComboBox_SelectedValueChanged(null, null);


        }

        private void NumberPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void LadeChooseButton_Click(object sender, EventArgs e)
        {
            if (this._CardReading)
                return;
            if (WithLade_bitRadioButton.Checked)
            {
                HPS.Present.SearchForm.GoodSearch frm = new HPS.Present.SearchForm.GoodSearch();
                frm.ShowDialog();
                if (frm != null)
                {
                    if (frm.SelectedGoodEntity.GoodID_int == null || frm.SelectedGoodEntity.GoodID_int == 0)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("گزینه ای انتخاب نشده است");
                        frm.ShowDialog();
                        Comment_nvcTextBox.Text = frm.SelectedGoodEntity.Good_nvc;
                    }
                    else
                    {
                        Comment_nvcTextBox.Text = frm.SelectedGoodEntity.Good_nvc;
                    }
                }
            }
        }

        public void ClearForm()
        {
            this.ClearForm(this);

            DriverEntity = null;
            DriverList = null;
            CarList = null;
            // StopFeeList = null;
            bool _CardReading = false;
            NumberPlate_nvcTextBox.Focus();

        }

        private long? _CurrentTrafficNumber = null;

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.State = enmFormState.Edit;
                Editbutton.Enabled = true;
                EditAndPrintbutton.Enabled = true;
                FurtherBillButton.Enabled = true;
                PriceWithTax_decNumericTextBox.Enabled = false;
                PriceTax_decnumericTextBox.Enabled = false;
                PriceWithoutTax_decnumericTextBox.Enabled = false;
                ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
                ((ToolStripButton)this.SaveAndExitButton).Visible = false;
                //////////////NumberPlateReadingButton.Enabled = false;
                DriverCardReadingButton.Enabled = false;
                CarSearchButton.Enabled = false;
                DriverSearch.Enabled = false;
                //Trafficnumberlabel.Visible = true;
                //TrafficNumbertextBox.Visible = true;
                //PriceCorrectButon.Enabled = false;
                NewButton.Enabled = true;
                SearchButton.Enabled = true;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                TrafficFactory.PreviousNavigation(1, this._CurrentTrafficNumber, TrafficNavigationDataTable);
                if (TrafficNavigationDataTable != null && TrafficNavigationDataTable.Rows.Count > 0)
                {

                    this._CurrentTrafficNumber = (long?)TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"];
                    TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
                    TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this._CurrentTrafficNumber);
                    if (TrafficList != null && TrafficList.Count > 0)
                    {
                        this.TrafficKey.TrafficID_bint = TrafficList[0].TrafficID_bint;
                    }
                    NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NumberPlate_nvc"], TypeCode.String));
                    CarCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardDate_nvc"], TypeCode.String));
                    CarCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardNumber_nvc"], TypeCode.String));
                    SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["SerialPlate_nvc"], TypeCode.String));
                    System_nvcCombobox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"], TypeCode.Int32);
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderTypeCode_nvc"], TypeCode.String));
                    ProductionYear_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["ProductionYear_int"], TypeCode.Int32));
                    YearType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["YearType_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, TrafficNavigationDataTable.Rows[0]["PlateCityID_int"], TypeCode.Int32);
                    PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityCode_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                    DriverCardNumber_bintNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardNumber_nvc"], TypeCode.String));
                    FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                    LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                    NationalCode_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NationalCode_int"], TypeCode.Int64));
                    licenceNumber_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["licenceNumber_int"], TypeCode.Int64));
                    DriverCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardDate_nvc"], TypeCode.String));
                    PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PriceTax_dec"], TypeCode.Decimal));
                    PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));

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
            //TrafficNavigationDataTable.Rows[0]["
            //Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue("",""));


        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.State = enmFormState.Edit;
                Editbutton.Enabled = true;
                EditAndPrintbutton.Enabled = true;
                FurtherBillButton.Enabled = true;
                ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
                ((ToolStripButton)this.SaveAndExitButton).Visible = false;
                ////////////NumberPlateReadingButton.Enabled = false;
                DriverCardReadingButton.Enabled = false;
                CarSearchButton.Enabled = false;
                DriverSearch.Enabled = false;
                //Trafficnumberlabel.Visible = true;
                //TrafficNumbertextBox.Visible = true;
                //PriceCorrectButon.Enabled = false;
                NewButton.Enabled = true;
                SearchButton.Enabled = true;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                TrafficFactory.NextNavigation(1, this._CurrentTrafficNumber, TrafficNavigationDataTable);
                if (TrafficNavigationDataTable != null && TrafficNavigationDataTable.Rows.Count > 0)
                {

                    this._CurrentTrafficNumber = (long?)TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"];
                    TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
                    TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this._CurrentTrafficNumber);
                    if (TrafficList != null && TrafficList.Count > 0)
                    {
                        this.TrafficKey.TrafficID_bint = TrafficList[0].TrafficID_bint;
                    }

                    NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NumberPlate_nvc"], TypeCode.String));
                    CarCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardDate_nvc"], TypeCode.String));
                    CarCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["CarCardNumber_nvc"], TypeCode.String));
                    SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["SerialPlate_nvc"], TypeCode.String));
                    System_nvcCombobox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"], TypeCode.Int32);
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderTypeCode_nvc"], TypeCode.String));
                    ProductionYear_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["ProductionYear_int"], TypeCode.Int32));
                    YearType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["YearType_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, TrafficNavigationDataTable.Rows[0]["PlateCityID_int"], TypeCode.Int32);
                    PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityCode_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                    DriverCardNumber_bintNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardNumber_nvc"], TypeCode.String));
                    FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                    LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                    NationalCode_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NationalCode_int"], TypeCode.Int64));
                    licenceNumber_intNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["licenceNumber_int"], TypeCode.Int64));
                    DriverCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["DriverCardDate_nvc"], TypeCode.String));
                    PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PriceTax_dec"], TypeCode.Decimal));
                    PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));

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
            //TrafficNavigationDataTable.Rows[0]["
            //Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue("",""));

        }

        private void EnableButtons()
        {
            ////////NumberPlateReadingButton.Enabled = true;
            DriverCardReadingButton.Enabled = true;
            CarCorrectButton.Enabled = true;
            DriverCorrectButton.Enabled = true;
            CarSearchButton.Enabled = true;
            //Trafficnumberlabel.Visible = false;
            //TrafficNumbertextBox.Visible = false;
            DriverSearch.Enabled = true;
            PriceCorrectButon.Enabled = true;
            ServicesID_intComboBox.SelectedIndex = -1;
            PriceWithTax_decNumericTextBox.Text = string.Empty;
            PriceTax_decnumericTextBox.Text = string.Empty;
            PriceWithoutTax_decnumericTextBox.Text = string.Empty;
            CarCardNumber_nvcTextBox.Enabled = true;
        }

        private void FurtherBillButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();

            try
            {
                if (_CurrentTrafficNumber.HasValue == true)
                {
                    HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                    TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
                    TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, _CurrentTrafficNumber);
                    TrafficEntity = TrafficList[0];
                    if (TrafficList.Count > 0 && TrafficList != null)
                    {
                        foreach (HPS.BLL.TrafficBLL.BLLTraffic_T item in TrafficList)
                        {
                            if (item.Out_bit == true)
                            {
                                Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو خارج شده است");
                                return;

                            }
                        }

                        if (TrafficList.Count == 2)
                        {
                            return;
                        }
                    }

                    if (TrafficEntity.ServiceID_int == 2)
                    {
                        //HPS.Reports.ReportDoc.AcceptedTurnReport rpt = new HPS.Reports.ReportDoc.AcceptedTurnReport(TrafficEntity);
                        //rpt.Document.Printer.PrinterName = string.Empty;
                        //rpt.Run();
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
                        TrafficEntity.TurnPrinted_bit = true;
                        HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, false, false);
                        frm.ShowDialog();
                        //
                    }
                    else
                    {
                        //HPS.Reports.ReportDoc.TrafficReport rpt = new HPS.Reports.ReportDoc.TrafficReport(TrafficEntity);
                        //rpt.Document.Printer.PrinterName = string.Empty;
                        //rpt.Run();
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
                        TrafficEntity.TurnPrinted_bit = true;
                        HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, true, false);
                        frm.ShowDialog();
                    }

                    //HPS.Reports.ReportDoc.TrafficReport rpt = new HPS.Reports.ReportDoc.TrafficReport(TrafficEntity);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //rpt.Run();
                    //Properties.Settings s = new HPS.Properties.Settings();
                    //if (string.IsNullOrEmpty(s.PrinterName))
                    //{
                    //    rpt.Document.Print(true, true, true);
                    //}
                    //else
                    //{
                    //    rpt.Document.Printer.PrinterName = s.PrinterName;
                    //    rpt.Document.Print(false, true,true);
                    //}
                }

            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void NextButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.NextButton, "Shift+N");
        }

        private void PreviousButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.PreviousButton, "Shift+P");
        }

        private void FurtherBillButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.FurtherBillButton, "Ctrl+P");
        }

        private void FurtherBillButton_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Alt && e.KeyCode == Keys.P)
            {
                FurtherBillButton.PerformClick();
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {

            if (this.State == enmFormState.Edit)
            {
                this.SaveAndContinueButtonEvent(sender, e);
                NewButton.Enabled = false;
                this.EnableButtons();
                FurtherBillButton.Enabled = false;
                //Editbutton.Enabled = false;
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.State = enmFormState.Add;
            this.EnableButtons();
            //Trafficnumberlabel.Visible = false;
            //TrafficNumbertextBox.Visible = false;
            //PriceCorrectButon.Enabled = false;
            Editbutton.Enabled = false;
            EditAndPrintbutton.Enabled = false;
            _CurrentTrafficNumber = null;
            FurtherBillButton.Enabled = false;
            ClearForm(this);
            NewButton.Enabled = false;
            SearchButton.Enabled = false;
        }

        private void Editbutton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.Editbutton, "Shift+E");
        }

        private void NewButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.NewButton, "Ctrl+N");
        }

        DataTable HastTurnDataTable = new DataTable();
        private void ServicesID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (LaderTypeID_intComboBox.SelectedIndex == -1 || LaderTypeID_intComboBox.SelectedValue == null)
                    return;
                if (ServicesID_intComboBox.SelectedIndex == -1 || ServicesID_intComboBox.SelectedValue == null)
                {
                    return;
                }
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = this.GetStopFee(StopFeeFactory.ServerJalaliDate, (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"], TypeCode.Int32), (int?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.ServicesID_intComboBox.SelectedValue, TypeCode.Int32), this.WithLade_bitRadioButton.Checked);
                BLL.SettingsBLL.BLLSetting_TFactory SettingsFactory = new BLL.SettingsBLL.BLLSetting_TFactory();
                SettingKey.SettingID_int = 1011;
                SettingEntity = SettingsFactory.GetBy(SettingKey);

                if (StopFeeList != null && StopFeeList.Count > 0)
                {
                    if ((Int32)ServicesID_intComboBox.SelectedValue == 2)
                    {
                        if (LaderTypeID_intComboBox.SelectedValue != null && (bool)((DataRowView)LaderTypeID_intComboBox.SelectedItem)["TurnCancel_bit"] == false)
                        {
                            LaderTypeID_intComboBox.SelectedIndex = -1;
                            throw new ApplicationException("امکان ثبت نوبت برای این بارگیر وجود ندارد");
                        }
                        PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                        if (StopFeeList[0].Tax_bit)
                        {
                            var tax = RoundNumber(Convert.ToDouble((StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100)));
                            PriceTax_decnumericTextBox.Text = tax.ToString();
                            PriceWithTax_decNumericTextBox.Text = RoundNumber(Convert.ToDouble(StopFeeList[0].Fee_dec) + tax).ToString();
                        }
                        else
                        {
                            PriceTax_decnumericTextBox.Text = "";
                            PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                        }
                    }
                    else
                    {
                        PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                        if (StopFeeList[0].Tax_bit)
                        {
                            var tax = RoundNumber(Convert.ToDouble(StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100));
                            PriceTax_decnumericTextBox.Text = tax.ToString();
                            PriceWithTax_decNumericTextBox.Text = (RoundNumber(Convert.ToDouble(StopFeeList[0].Fee_dec) + tax)).ToString();
                        }
                        else
                        {
                            PriceTax_decnumericTextBox.Text = "";
                            PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                        }
                    }
                }
                else if (LaderTypeID_intComboBox.SelectedValue != null)
                {
                    PriceWithoutTax_decnumericTextBox.Text = null;
                    PriceTax_decnumericTextBox.Text = null;
                    PriceWithTax_decNumericTextBox.Text = null;

                    throw new ApplicationException(HPS.Exceptions.ExceptionCs.StopFeeNotExist);

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private double RoundNumber(double number)
        {
            if (number.ToString().Contains("."))
            {
                number = Convert.ToDouble(number.ToString().Substring(0, number.ToString().IndexOf('.')));

            }

            //if (number > 5000)
            //{
            //    double khord = number % 5000;
            //    if (khord == 0)
            //    {
            //        return number;
            //    }
            //    else if (khord > 0 && khord < 2499)
            //    {
            //        return number - khord;
            //    }
            //    else if (khord > 2500 && khord < 5000)
            //    {
            //        return number - khord + 5000;
            //    }
            //    else
            //    {
            //        return number;
            //    }
            //}
            //else
            //{
            //   
            //}
            return number;
        }

        private List<HPS.BLL.StopFeeBLL.BLLStopFee_T> GetStopFee(string Date_nvc, int? LaderPivotGroupID_int, int? ServicesID_int, bool WithLadeExtraHourFee_bit)
        {
            if (string.IsNullOrEmpty(Date_nvc) || !LaderPivotGroupID_int.HasValue)
                return null;
            string BaseCondition = string.Format("[StopFee_T].[StartDate_nvc]<='{0}' And [StopFee_T].[EndDate_nvc]>='{0}' And [StopFee_T].[TrafficTypeID_int]=1 And ", Date_nvc);
            BaseCondition += string.Format("[StopFee_T].[LaderPivotGroupID_int]={0} And ", LaderPivotGroupID_int);
            if (WithLadeExtraHourFee_bit)
                BaseCondition += "[StopFee_T].[WithLadeExtraHourFee_dec] Is Not Null And ";

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

        protected override void ShowForm()
        {
            FillCombo();
            Editbutton.Enabled = true;
            EditAndPrintbutton.Enabled = true;
            PriceWithTax_decNumericTextBox.Enabled = false;
            PriceWithoutTax_decnumericTextBox.Enabled = false;
            PriceTax_decnumericTextBox.Enabled = false;
            NumberPlateReadingButton.Enabled = false;
            ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
            ((ToolStripButton)this.SaveAndExitButton).Visible = false;
            //Trafficnumberlabel.Visible = true;
            //TrafficNumbertextBox.Visible = true;
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            TrafficEntity = TrafficFactory.GetBy(TrafficKey);
            DriverCardNumber_bintNumericTextBox.Text = TrafficEntity.DriverCardNumber_nvc;
            DriverCardDate_nvcTextBox.Text = TrafficEntity.DriverCardDate_nvc;
            NationalCode_intNumericTextBox.Text = Convert.ToString(TrafficEntity.NationalCode_int);
            FirstName_nvcTextBox.Text = TrafficEntity.FirstName_nvc;
            LastName_nvcTextBox.Text = TrafficEntity.LastName_nvc;
            licenceNumber_intNumericTextBox.Text = Convert.ToString(TrafficEntity.licenceNumber_int);
            NumberPlate_nvcTextBox.Text = TrafficEntity.NumberPlate_nvc;
            CarCardNumber_nvcTextBox.Text = TrafficEntity.CarCardNumber_nvc;
            CarCardDate_nvcTextBox.Text = TrafficEntity.CarCardDate_nvc;
            Mobile_nvcnumericTextBox.Text = TrafficEntity.DriverMobileNumber_nvc;
            //TrafficNumbertextBox.Text = TrafficEntity.TrafficNumber_bint.ToString();
            if (TrafficEntity.PlateCityID_int.HasValue == true)
            {
                PlateCityID_intComboBox.SelectedValue = TrafficEntity.PlateCityID_int;
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                PlateKey.PlateCityID_int = TrafficEntity.PlateCityID_int;
                HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateEntity = PlateCityFactory.GetBy(PlateKey);
                PlateCityCode_nvcTextBox.Text = PlateEntity.PlateCityCode_nvc;

            }
            SerialPlate_nvcTextBox.Text = TrafficEntity.SerialPlate_nvc;
            ProductionYear_intNumericTextBox.Text = Convert.ToString(TrafficEntity.ProductionYear_int);
            YearType_nvcTextBox.Text = TrafficEntity.YearType_nvc;
            if (TrafficEntity.LaderTypeID_int.HasValue == true)
            {
                Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficEntity.LaderTypeID_int, TypeCode.Int32);
                LaderTypeCode_nvcTextBox.Text = TrafficEntity.LaderTypeCode_nvc;
            }
            System_nvcCombobox.Text = TrafficEntity.System_nvc;
            WithLade_bitRadioButton.Checked = TrafficEntity.WithLade_bit;
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficEntity.ServiceID_int, TypeCode.Int32);
            PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.Price_dec, TypeCode.String));
            PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.PriceTax_dec, TypeCode.String));
            if (string.IsNullOrEmpty(TrafficEntity.PriceTax_dec.ToString()))
            {
                PriceWithoutTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.Price_dec, TypeCode.String));
            }
            else
            {
                PriceWithoutTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.Price_dec - TrafficEntity.PriceTax_dec, TypeCode.String));
            }

            if (!(TrafficEntity.LadeReturn_bit == null))
            {
                if (TrafficEntity.LadeReturn_bit == true)
                    LadeReturnCheckBox.Checked = true;
                else
                {
                    LadeReturnCheckBox.Checked = false;
                }

            }
            if (TrafficEntity.CameraSerialPlate_int.HasValue)
            {
                NumberPlate_nvcTextBoxCamera.Text = TrafficEntity.CameraPlateNumber_nvc;
                SerialPlate_nvcTextBoxCamera.Text = TrafficEntity.CameraSerialPlate_int.ToString();
            }
            //else
            //{
            NumberPlateReadingButton.Enabled = true;
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
            BLLTrafficPictures_TKeys _key = new BLLTrafficPictures_TKeys();
            _key.TrafficID_bint = TrafficEntity.TrafficID_bint;
            TrafficPicturesEntity = TrafficPicturesFactory.GetBy(_key);

            if (TrafficPicturesEntity != null)
            {
                NumberPlateReadingButton.Visible = false;
                NumberPlateReadingEditStateButton.Visible = true;
                pictureBox.Visible = true;
                axVLCPlugin21.Visible = false;
                axVLCPlugin22.Visible = false;
                CameraGroupBox.Visible = false;
                PictureDataUserdEdit = TrafficPicturesEntity.Picture_vbnry;
                pictureBox.Image = TrafficPicturesEntity.GetTrafficPicture;
                pictureBox.Height = 220;
                pictureBox.Width = 252;
            }
            //}
            PublicDriverNumber = DriverCardNumber_bintNumericTextBox.Text;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllTrafficForm frm = new HPS.Reports.Forms.AllTrafficForm(1);
            frm.Show();

        }

        private void EditAndPrintbutton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.EditAndPrintbutton, "Ctrl+E");
        }

        private void EditAndPrintbutton_Click(object sender, EventArgs e)
        {
            if (this.State == enmFormState.Edit)
            {
                _EditWithPrint = true;
                this.SaveAndContinueButtonEvent(sender, e);
                NewButton.Enabled = false;
                this.EnableButtons();
                FurtherBillButton.Enabled = false;

            }
        }


        protected void FillTrafficByNumberPlateAndSerialPlate()
        {
            BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();

            //Fill Traffic Information
            if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
            {
                if (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                {
                    TrafficList = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                    string trafficCondition = string.Empty;
                    trafficCondition = "[Traffic_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "' AND [Traffic_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "'";
                    TrafficList = TrafficFactory.GetAllByCondition(trafficCondition);

                    if (TrafficList != null && TrafficList.Count > 0)
                    {
                        Int64 LastTrafficNumber = TrafficList.Max(itm => itm.TrafficNumber_bint);
                        List<HPS.BLL.TrafficBLL.BLLTraffic_T> LastTraffic = TrafficList.FindAll(itm => itm.TrafficNumber_bint == LastTrafficNumber);
                        if (LastTraffic != null && LastTraffic.Count > 0)
                        {
                            CarCardNumber_nvcTextBox.Text = LastTraffic[0].CarCardNumber_nvc;
                            CarCardDate_nvcTextBox.Text = LastTraffic[0].CarCardDate_nvc;
                            NumberPlate_nvcTextBox.Text = LastTraffic[0].NumberPlate_nvc;
                            SerialPlate_nvcTextBox.Text = LastTraffic[0].SerialPlate_nvc;

                            if (LastTraffic[0].PlateCityID_int != null)
                            {
                                string PlateCityCondition = "[PlateCity_T].[PlateCityID_int] = '" + LastTraffic[0].PlateCityID_int + "'";
                                List<HPS.BLL.PlateCityBLL.BLLPlateCity_T> PlateCityList = PlateCityFactory.GetAllByCondition(PlateCityCondition);
                                if (PlateCityList != null)
                                {
                                    PlateCityID_intComboBox.Text = PlateCityList[0].PlateCity_nvc;
                                    PlateCityCode_nvcTextBox.Text = PlateCityList[0].PlateCityCode_nvc;
                                }
                            }
                            ProductionYear_intNumericTextBox.Text = LastTraffic[0].ProductionYear_int.ToString();
                            YearType_nvcTextBox.Text = LastTraffic[0].YearType_nvc;
                            System_nvcCombobox.Text = LastTraffic[0].System_nvc;
                        }
                    }

                    else
                    {
                        ///////////////////////
                        CarList = new List<HPS.BLL.CarBLL.BLLCar_T>();
                        CarCondition = "([Car_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "') ";
                        CarList = CarFactory.GetAllByCondition(CarCondition);
                        if (CarList.Count == 1)
                        {
                            FillCarByCarList();
                        }
                        else if (CarList.Count > 1)
                        {
                            string rs = NumberPlate_nvcTextBox.Text;
                            HPS.Present.SearchForm.CarSearch frm = new HPS.Present.SearchForm.CarSearch(rs);
                            CarList.Clear();
                            if (frm.ShowDialog() != DialogResult.Cancel)
                            {
                                CarList.Add(frm.SelectedCar);
                                FillCarByCarList();
                            }

                            if (frm.SelectedCar.CarID_int == 0)
                            {
                                ClearCar();
                                NumberPlate_nvcTextBox.Focus();
                                this.RaiseKeyDownEvent = false;
                            }
                        }
                        else
                        {
                            string tCondition = "([Traffic_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "') AND ([Traffic_T].[In_bit]='true') ORDER BY TrafficID_bint DESC";
                            TrafficList = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                            TrafficList = TrafficFactory.GetAllByCondition(tCondition);
                            if (TrafficList != null && TrafficList.Count > 0)
                            {
                                CarCardNumber_nvcTextBox.Text = TrafficList[0].CarCardNumber_nvc;
                                CarCardDate_nvcTextBox.Text = TrafficList[0].CarCardDate_nvc;
                                NumberPlate_nvcTextBox.Text = TrafficList[0].NumberPlate_nvc;
                                SerialPlate_nvcTextBox.Text = TrafficList[0].SerialPlate_nvc;

                                if (TrafficList[0].PlateCityID_int != null)
                                {
                                    string PlateCityCondition = "[PlateCity_T].[PlateCityID_int] = '" + TrafficList[0].PlateCityID_int + "'";
                                    List<HPS.BLL.PlateCityBLL.BLLPlateCity_T> PlateCityList = PlateCityFactory.GetAllByCondition(PlateCityCondition);
                                    if (PlateCityList != null)
                                    {
                                        PlateCityID_intComboBox.Text = PlateCityList[0].PlateCity_nvc;
                                        PlateCityCode_nvcTextBox.Text = PlateCityList[0].PlateCityCode_nvc;
                                    }
                                }
                                ProductionYear_intNumericTextBox.Text = TrafficList[0].ProductionYear_int.ToString();
                                YearType_nvcTextBox.Text = TrafficList[0].YearType_nvc;
                                System_nvcCombobox.Text = TrafficList[0].System_nvc;
                            }
                            else
                            {
                                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "کامیون با مشخصات"));
                                NumberPlate_nvcTextBox.Text = string.Empty;
                                NumberPlate_nvcTextBox.Focus();
                                this.RaiseKeyDownEvent = false;
                            }
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && ((PlateCityID_intComboBox.SelectedValue != null && (Int32)PlateCityID_intComboBox.SelectedValue != 0) || PlateCityID_intComboBox.SelectedIndex != -1))
            {
                DataTable LaderTypeFindDataTable = new DataTable();
                TrafficFactory.FindLaderTypeInTraffic(NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, (Int32)PlateCityID_intComboBox.SelectedValue, LaderTypeFindDataTable);
                if (LaderTypeFindDataTable != null && LaderTypeFindDataTable.Rows.Count > 0)
                {
                    LaderTypeID_intComboBox.SelectedValue = LaderTypeFindDataTable.Rows[0]["LaderTypeID_int"];
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(LaderTypeFindDataTable.Rows[0]["LaderTypeCode_nvc"]);
                }
                else
                {
                    LaderTypeID_intComboBox.SelectedIndex = -1;
                }
            }
        }

        private async void NumberPlateReadingEditStateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number = string.Empty;

                if (PictureDataUserdEdit != null && this.State == enmFormState.Edit)
                {
                    //number = anprService.GetPlateNumberByByte(PictureDataUserdEdit);
                    number = await api.GetNumberPlate(PictureDataUserdEdit);
                    //number = "56ع87615";
                    NumberPlateReadingButton.Enabled = true;
                    if (!string.IsNullOrEmpty(number))
                    {
                        HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new BLL.TruePlate.ConvertToTrueNumber();
                        string plateNumber_nvc = string.Empty;
                        string plateSerial_nvc = string.Empty;

                        NumberPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 9));
                        SerialPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(10, 2));


                        if (NumberPlate_nvcTextBoxCamera.Text == NumberPlate_nvcTextBox.Text && SerialPlate_nvcTextBoxCamera.Text == SerialPlate_nvcTextBox.Text)
                        {
                            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityUpdate = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                            TrafficEntityUpdate = TrafficFactory.GetBy(TrafficKey);

                            if (string.IsNullOrEmpty(NumberPlate_nvcTextBoxCamera.Text))
                            {
                                TrafficEntityUpdate.CameraPlateNumber_nvc = null;
                            }
                            else
                                TrafficEntityUpdate.CameraPlateNumber_nvc = NumberPlate_nvcTextBoxCamera.Text;
                            if (string.IsNullOrEmpty(SerialPlate_nvcTextBoxCamera.Text))
                            {
                                TrafficEntityUpdate.CameraSerialPlate_int = null;
                            }
                            else
                                TrafficEntityUpdate.CameraSerialPlate_int = Convert.ToInt32(SerialPlate_nvcTextBoxCamera.Text);

                            TrafficFactory.BeginProc();
                            TrafficFactory.Update(TrafficEntityUpdate, TrafficKey);
                            TrafficFactory.CommitProc();
                        }
                    }
                }
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

        private void SetLaderTypeID_intComboBoxValue()
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
                LaderTypeID_intComboBox.Focus();
                this.RaiseKeyDownEvent = false;
            }
        }

        private void NewDriverButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDriverAndCarOnlineInformation(DriverCardNumber_bintNumericTextBox.Text, CarCardNumber_nvcTextBox.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NewCarButton_Click(object sender, EventArgs e)
        {
            var frm = new CarEntityForm(true);
            frm.ShowDialog();
        }

        private void ServicesID_intComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    if (ServicesID_intComboBox.SelectedIndex == -1)
                    {
                        string Filter = string.Format("ServicesID_int='{0}'", ServicesID_intComboBox.Text);
                        DataRow[] dr = ServicesDataTable.Select(Filter);

                        ServicesID_intComboBox.SelectedValue = dr[0]["ServicesID_int"];
                    }
                }
                catch (Exception)
                {
                    ServicesID_intComboBox.Text = "";
                    //Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
                ServicesID_intComboBox.Focus();
                this.RaiseKeyDownEvent = false;
            }
        }

        private void Cam1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cam1RadioButton.Checked)
            {

                axVLCPlugin21.Visible = true;
                axVLCPlugin22.Visible = false;

                ////connect to messoa camera
                ip = string.Empty;
                ip = "172.24.129.9";
                axVLCPlugin21.Refresh();
                axVLCPlugin21.playlist.add("rtsp://" + ip + ":554/stream1", null, null);
                if (this.State == enmFormState.Add)
                {
                    axVLCPlugin21.playlist.play();
                }
            }
        }

        private void Cam2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cam2RadioButton.Checked)
            {
                ////connect to messoa camera

                axVLCPlugin21.Visible = false;
                axVLCPlugin22.Visible = true;
                ip = string.Empty;
                ip = "172.24.129.7";
                axVLCPlugin22.Refresh();
                axVLCPlugin22.playlist.add("rtsp://" + ip + ":554/stream1", null, null);
                if (this.State == enmFormState.Add)
                {
                    axVLCPlugin22.playlist.play();
                }

            }
        }

        private void CarCardNumber_nvcTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                LoadCar(CarCardNumber_nvcTextBox.Text);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);

            }

        }

        private void SerialPlate_nvcTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!stopReadProcess)
                {
                    CarCardNumber_nvcTextBox.Text = string.Empty;
                }
                FillCar();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }


        /// <summary>
        /// آیا مدت زمان تعیین شده برای مقصد رد شده است که از اول به آن نوبیت دهیم ؟
        /// </summary>
        private bool IsTravelTimePassedVariable = true;

        /// <summary>
        ///  بررسی مدت زمان تعیین شده برای مقصد
        ///  **Set 'IsTravelTimePassedVariable' value**
        /// </summary>
        /// <param name="CarCardNumber"></param>
        private void CheckTravelTimePassed(string CarCardNumber)
        {
            // Found Last Traffic 
            // if traffic.servicetype == 2  : نوبت
            // check travel Time

            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = TrafficFactory.GetAllByCondition(string.Format(" [Traffic_T].[CarCardNumber_nvc] = '{0}' and [Traffic_T].[ServiceID_int]=2 and in_bit=1", CarCardNumber)).OrderByDescending(a => a.TrafficID_bint).FirstOrDefault();
            HPS.BLL.TrafficBLL.BLLTraffic_T OutTrafficEntity = TrafficFactory.GetAllByCondition(string.Format(" [Traffic_T].[CarCardNumber_nvc] = '{0}' and [Traffic_T].[ServiceID_int]=2 and Out_bit=1", CarCardNumber)).OrderByDescending(a => a.TrafficID_bint).FirstOrDefault();
            if (TrafficEntity == null)
            {
                return;
            }
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
                // string _OutDate = TrafficDataTable.Rows[0]["Date_nvc"].ToString();
                // string _OutTime = TrafficDataTable.Rows[0]["Time_nvc"].ToString();

                string _OutDate = OutTrafficEntity.Date_nvc;
                string _OutTime = OutTrafficEntity.Time_nvc;
                DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);

                if (TrafficDataTable.Rows[0]["Out_bit"].ToString() == "False")
                {
                    TimeSpan date = NowDate - OutDate;
                    double remaindedHour = _CityTravelHour - date.TotalHours;
                    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                    {
                        // برای گروه کاربری مدیر فقط خطا را نمایش دهد و برای سایر نمایش و ادامه را لغو کند
                        //if (HPS.Common.CurrentUser.user.UserGroupID_int != 1 && HPS.Common.CurrentUser.user.UserGroupID_int != 13)
                        //{
                        //   IsTravelTimePassedVariable = false;
                        // }
                        // MessageBox.Show(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", TrafficDataTable.Rows[0]["LadBillCreditID_int"], TimeSpan.FromHours(remaindedHour)),"اخطار",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        MessageBox.Show(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده است", TrafficDataTable.Rows[0]["LadBillCreditID_int"]), "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // throw new ApplicationException(string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", TrafficDataTable.Rows[0]["LadBillCreditID_int"], TimeSpan.FromDays(remaindedHour)));
                    }

                }
            }



        }

        private void UpdateDriverSpecification(string DriverCardNumber)
        {
            try
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> DriverSpecificationList = DriverSpecificationFactory.GetAllBy(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc, DriverCardNumber);
                if (DriverSpecificationList != null && DriverSpecificationList.Count > 0)
                {
                    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys _key = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                    _key.DriverSpecificationID_int = DriverSpecificationList.FirstOrDefault().DriverSpecificationID_int;
                    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T CurrentDriverInfo = DriverSpecificationList.FirstOrDefault();
                    long NationalCode_intNumeric;
                    long.TryParse(NationalCode_intNumericTextBox.Text,out NationalCode_intNumeric);
                    CurrentDriverInfo.NationalCode_int = NationalCode_intNumeric;
                    CurrentDriverInfo.licenceNumber_nvc = licenceNumber_intNumericTextBox.Text;
                    DriverSpecificationFactory.BeginProc();
                    DriverSpecificationFactory.Update(CurrentDriverInfo, _key);
                    DriverSpecificationFactory.CommitProc();

                }
                else
                {
                    HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                    List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList = DriverFactory.GetAllBy(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber);
                    if (DriverList != null && DriverList.Count > 0)
                    {
                        HPS.BLL.DriverBLL.BLLDriver_T CurrentDriver = DriverList.FirstOrDefault();
                        HPS.BLL.DriverBLL.BLLDriver_TKeys _key = new HPS.BLL.DriverBLL.BLLDriver_TKeys();
                        _key.DriverID_bint = CurrentDriver.DriverID_bint;
                        CurrentDriver.NationalCode_int = Convert.ToInt32(NationalCode_intNumericTextBox.Text);
                        CurrentDriver.licenceNumber_nvc = licenceNumber_intNumericTextBox.Text;
                        DriverFactory.BeginProc();
                        DriverFactory.Update(CurrentDriver, _key);
                        DriverFactory.CommitProc();
                    }


                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
