using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace HPS.Present.Traffic
{
    public partial class OtherCarsForm : Hepsa.Core.PL.BaseEntityForm2
    {
        //private Byte[] ImageArray { get; set; }
        //WebReference4.ServiceRefrence anprService = new WebReference4.ServiceRefrence();
        HPS.Common.PlateReaderApi api = new HPS.Common.PlateReaderApi();
        Image img = null;
        Byte[] szBuffer = new Byte[1000000];
        private byte[] PictureDataUserdEdit;
        DataTable VerificationCarTable;
        DataTable CarSystemDataTable = new DataTable();
        object objData;
        object info;
        byte[] byteData;
        string ip = string.Empty;
        public OtherCarsForm()
            : base(null)
        {
            InitializeComponent();
            //this.PrinterButton = ChoosePrinterButton;
        }
        HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
        BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory VerifyCarsFactory = new BLL.VerifiedCarsBLL.BLLVerifiedCars_TFactory();
        ToolTip tooltip1 = new ToolTip();
        bool sensorIsTrue_bit = false;
        //  Int64 trafficNumber_bint = 0;

        public OtherCarsForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.TrafficBLL.BLLTraffic_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
            TrafficKey = Key;
            this.EditAndClose = true;
            this.ConfirmOnClose = false;
        }

        private void OtherCarsForm_Load(object sender, EventArgs e)
        {
            if (this.State == enmFormState.Add)
            {
                FillCombo();

                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = new List<BLL.TrafficBLL.BLLTraffic_T>();
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new BLL.TrafficBLL.BLLTraffic_TFactory();
                ///========connect to camera
                //////axVitaminCtrl1.Url = "http://169.254.0.99";
                //////axVitaminCtrl1.ViewStream = VITAMINDECODERLib.EDualStreamOption.eStream1;
                //////axVitaminCtrl1.ConnectionProtocol = VITAMINDECODERLib.EConnProtocol.eProtTCP;
                //////axVitaminCtrl1.MediaType = VITAMINDECODERLib.EMediaType.eMediaVideo;
                //////axVitaminCtrl1.Connect();
                //////axVitaminCtrl1.StretchFullScreen = false;


            }

            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 100;
            tooltip1.ReshowDelay = 100;
            tooltip1.ShowAlways = true;
            SerialPlate_nvcTextBox.Text = "15";
            ServicesID_intComboBox.Text = "پاركينگ";
            FirstName_nvcTextBox.Focus();
            PlateCityID_intComboBox.SelectedValue = 311;
        }

        HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = new HPS.BLL.PlateCityBLL.BLLPlateCity_T();
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityInsert = new HPS.BLL.TrafficBLL.BLLTraffic_T();
        HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
        List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = null;
        DataTable PlateCityID_intDataTable = new DataTable();
        private Int64? _CurrentTrafficNumber = null;

        private void PlateNumber_nvcBottun_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.PlateCitySearch frm = new HPS.Present.SearchForm.PlateCitySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                PlateCityID_intComboBox.Text = frm.SelectedPlateCity.PlateCity_nvc;
                PlateCityCode_nvcTextBox.Text = frm.SelectedPlateCity.PlateCityCode_nvc;
                PlateCityEntity.PlateCityID_int = frm.SelectedPlateCity.PlateCityID_int;
            }
        }

        private void FillCombo()
        {

            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityID_intFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            string PlateCityCondition = "[PlateCity_T].[Active_bit]='true'";
            PlateCityID_intFactory.GetAllByCondition(PlateCityCondition, ref PlateCityID_intDataTable);
            DataRow dr = PlateCityID_intDataTable.NewRow();
            dr["PlateCityID_int"] = 0;
            PlateCityID_intDataTable.Rows.InsertAt(dr, 0);
            this.PlateCityID_intComboBox.DisplayMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCity_nvc.ToString();
            this.PlateCityID_intComboBox.ValueMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString();
            this.PlateCityID_intComboBox.DataSource = PlateCityID_intDataTable;
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, 311, TypeCode.Int32);

            HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
            string TrafficTypeCondition = "[TrafficType_T].[TrafficTypeID_int]!=1 And [TrafficType_T].[TrafficTypeID_int]!=2";
            DataTable TrafficTypeDataTable = new DataTable();
            TrafficTypeFactory.GetAllByCondition(TrafficTypeCondition, ref TrafficTypeDataTable);
            ////////////////////////////////////////////////////////////////
            string LadBillCrediteTypeID = "9";
            DataRow[] Row = TrafficTypeDataTable.Select(String.Format("TrafficTypeID_int={0}", LadBillCrediteTypeID));
            if (Row != null && Row.Length > 0)
            {
                Row[0].Delete();
                TrafficTypeDataTable.AcceptChanges();
            }
            /////////////////////////////////////////////////////////////////////
            TrafficTypeID_intComboBox.DataSource = TrafficTypeDataTable;
            TrafficTypeID_intComboBox.DisplayMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString();
            TrafficTypeID_intComboBox.ValueMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString();
            TrafficTypeID_intComboBox.SelectedIndex = 0;

            HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            DataTable ServicesDataTable = new DataTable();
            string Servicecondition = "[Services_T].[Activie_bit]='true'";
            ServicesFactory.GetAllByCondition(Servicecondition, ref ServicesDataTable);
            ServicesID_intComboBox.DataSource = ServicesDataTable;
            ServicesID_intComboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
            ServicesID_intComboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
            ServicesID_intComboBox.SelectedIndex = -1;

            HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory = new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
            CarSystemFactory.GetAll(ref CarSystemDataTable);
            System_nvcCombobox.DataSource = CarSystemDataTable;
            System_nvcCombobox.ValueMember = HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystemID_int.ToString();
            System_nvcCombobox.DisplayMember = HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystem_nvc.ToString();
            SelectSystemByTrafficType();

            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1011;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            string Condition = "([StopFee_T].[StartDate_nvc]<='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[EndDate_nvc]>='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[TrafficTypeID_int]='" + TrafficTypeID_intComboBox.SelectedValue + "')";
            StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
            StopFeeList = StopFeeFactory.GetAllByCondition(Condition);
            if (StopFeeList.Count != 0)
            {
                PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                if (StopFeeList[0].Tax_bit)
                {
                    var tax =RoundNumber( Convert.ToDouble((StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100)));
                    PriceTax_decnumericTextBox.Text =tax.ToString();
                    PriceWithTax_decNumericTextBox.Text = RoundNumber(Convert.ToDouble((StopFeeList[0].Fee_dec +Convert.ToDecimal(tax)))).ToString();
                }
                else
                {
                    PriceTax_decnumericTextBox.Text = "";
                    PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                }

            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("در این تاریخ برای این نوع تردد مبلغ تعریف نشده است");
            }
        }
        private double RoundNumber(double number)
        {
            if (number.ToString().Contains("."))
            {
                number = Convert.ToDouble(number.ToString().Substring(0, number.ToString().IndexOf('.')));

            }
            return number;
        }
        private void PlateCityID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (PlateCityID_intComboBox.SelectedIndex != -1)
            {

                PlateCityEntity.PlateCityID_int = (Int32?)PlateCityID_intComboBox.SelectedValue;
                PlateCityEntity.PlateCity_nvc = PlateCityID_intDataTable.Rows[Convert.ToInt32(PlateCityID_intComboBox.SelectedIndex)]["PlateCity_nvc"].ToString();
                PlateCityCode_nvcTextBox.Text = PlateCityID_intDataTable.Rows[Convert.ToInt32(PlateCityID_intComboBox.SelectedIndex)]["PlateCityCode_nvc"].ToString();
            }
        }

        private void OtherCarsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.P)
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
            else if (e.KeyCode == Keys.F7)
            {
                if (NumberPlateReadingButton.Visible)
                {
                    NumberPlateReadingButton.PerformClick();
                }
            }
        }

        protected override void Insert()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آیا مایل به ثبت ورود هستید ؟") == false)
                    return;

                if (string.IsNullOrEmpty(FirstName_nvcTextBox.Text) || string.IsNullOrEmpty(LastName_nvcTextBox.Text) || string.IsNullOrEmpty(Mobile_vcTextBox.Text) || string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) || PlateCityID_intComboBox.SelectedValue==null || PlateCityID_intComboBox.SelectedIndex==0 || string.IsNullOrEmpty(System_nvcCombobox.Text))
                {
                    throw new ApplicationException("لطفا تمامی مقادیر لازم را وارد نمایید");
                }
                if (!((int?)ServicesID_intComboBox.SelectedValue == 1 || (int?)ServicesID_intComboBox.SelectedValue == 4 || (int?)ServicesID_intComboBox.SelectedValue == 5))
                {
                    throw new ApplicationException("این ثبت تردد مجاز نیست");
                }
                if (!(TrafficTypeID_intComboBox.SelectedIndex > -1))
                {
                    throw new ApplicationException("لطفا تمامی مقادیر لازم را وارد نمایید");
                }
                TrafficEntityInsert.Date_nvc = TrafficFactory.ServerJalaliDate;
                TrafficEntityInsert.Time_nvc = TrafficFactory.ServerTime;
                TrafficEntityInsert.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.PlateCityID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntityInsert.System_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcCombobox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                TrafficEntityInsert.ServiceID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntityInsert.DriverMobileNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_vcTextBox.Text, TypeCode.String).ToString();
                if (TrafficTypeID_intComboBox.SelectedIndex != -1)
                {
                    if (StopFeeList.Count > 0 && StopFeeList != null)
                    {
                        TrafficEntityInsert.StopFeeID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].StopFeeID_int, TypeCode.Int32);
                        TrafficEntityInsert.AllowableHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].AllowedHoure_int, TypeCode.Int32);
                        TrafficEntityInsert.ExtraHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHour_int, TypeCode.Int32);
                        TrafficEntityInsert.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHourFee_dec, TypeCode.Decimal);
                        TrafficEntityInsert.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal);
                    }
                }

                HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
                string ComputerCondition = "[Computer_T].[MacAddress_nvc]='" + Hepsa.Core.Common.ApplicationInfo.MacAddress + "'";
                List<HPS.BLL.ComputerBLL.BLLComputer_T> ComputerList = ComputerFactory.GetAllByCondition(ComputerCondition);
                if (ComputerList.Count > 0 && ComputerList != null)
                {
                    TrafficEntityInsert.ComputerID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerList[0].ComputerID_int, TypeCode.Int32);
                    TrafficEntityInsert.Computer_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerList[0].Computer_nvc, TypeCode.String).ToString();
                }
                TrafficEntityInsert.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress;
                TrafficEntityInsert.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                TrafficEntityInsert.Printed_bit = false;
                TrafficEntityInsert.TrafficTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntityInsert.Date_nvc = TrafficFactory.ServerJalaliDate;
                TrafficEntityInsert.Time_nvc = TrafficFactory.ServerTime;
                string trafficCondition = "[Traffic_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "' AND [Traffic_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "' AND [Traffic_T].[PlateCityID_int]='" + PlateCityID_intComboBox.SelectedValue + "'";
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(trafficCondition);
                if (TrafficList.Count > 0 && TrafficList != null)
                {
                    Int64 LastTrafficNumber = TrafficList.Max(itm => itm.TrafficNumber_bint);
                    List<HPS.BLL.TrafficBLL.BLLTraffic_T> LastTraffic = TrafficList.FindAll(itm => itm.TrafficNumber_bint == LastTrafficNumber);

                    if (LastTraffic.Exists(itm => itm.In_bit == false) == false)
                    {
                        throw new ApplicationException("خودرو به شماره قبض " + LastTrafficNumber + " خارج نشده است");
                    }
                }       

                TrafficEntityInsert.In_bit = true;
                TrafficEntityInsert.Out_bit = false;
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                string BillCondition = "([BillMessage_T].[StartDate_nvc]<='" + BillMessageFactory.ServerJalaliDate + "') AND ([BillMessage_T].[EndDate_nvc]>= '" + BillMessageFactory.ServerJalaliDate + "' ) AND (TrafficType_T.TrafficTypeID_int<>1) AND (TrafficType_T.TrafficTypeID_int<>2)";
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(BillCondition);
                if (BillMessageList != null && BillMessageList.Count > 0)
                {
                    TrafficEntityInsert.BillMessageID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageList[0].BillMessageID_int, TypeCode.Int32);
                }
                TrafficEntityInsert.Price_dec = (Decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(PriceWithTax_decNumericTextBox.NumericText, TypeCode.Decimal);
                TrafficEntityInsert.PriceTax_dec = (Decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(PriceTax_decnumericTextBox.NumericText, TypeCode.Decimal);
                TrafficEntityInsert.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.Services_nvc = ServicesID_intComboBox.Text;
                TrafficEntityInsert.TurnAccepted_bit = false;
                TrafficEntityInsert.CameraPlateNumber_nvc = NumberPlate_nvcTextBoxCamera.Text;

               


                if (string.IsNullOrEmpty(SerialPlate_nvcTextBoxCamera.Text))
                {
                    TrafficEntityInsert.CameraSerialPlate_int = null;
                }
                else
                    TrafficEntityInsert.CameraSerialPlate_int = Convert.ToInt32(SerialPlate_nvcTextBoxCamera.Text);

                if (!TrafficEntityInsert.Price_dec.HasValue || string.IsNullOrEmpty(PriceWithTax_decNumericTextBox.Text) || PriceWithTax_decNumericTextBox.Text=="0")
                {
                    throw new ApplicationException("مبلغ خالی است");
                }

                VerificationCarTable = new DataTable();
                Boolean OtherCars = false;
                BLL.VerifiedCarsBLL.BLLVerifiedCars_T VerifiedCarsEntity = new BLL.VerifiedCarsBLL.BLLVerifiedCars_T();
                VerifyCarsFactory.GetAllByCondition(string.Format(" NumberPlate_nvc='{0}' AND SerialPlate_nvc='{1}' ", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text), ref VerificationCarTable);
                if (VerificationCarTable.Rows.Count > 0)
                {
                    try
                    {
                        if (VerificationCarTable.Rows[0]["Date_vc"] == DBNull.Value || VerificationCarTable.Rows[0]["Date_vc"].ToString() != VerifyCarsFactory.ServerJalaliDate)
                        {
                            VerifiedCarsEntity.Date_vc = VerifyCarsFactory.ServerJalaliDate;
                            VerifiedCarsEntity.VerifiedCarID_int = Convert.ToInt32(VerificationCarTable.Rows[0]["VerifiedCarID_int"]);
                            OtherCars = true;
                            TrafficEntityInsert.Price_dec = 0;
                            TrafficEntityInsert.PriceTax_dec = 0;
                            TrafficEntityInsert.Fee_dec = 0;
                            PriceWithTax_decNumericTextBox.Text = "0";
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage("" + TrafficEntityInsert.Price_dec + "ر یال باید از راننده گرفته شود.  آیا از ثبت اطلاعات اطمینان دارید؟  ") == true)
                {
                    TrafficFactory.BeginProc();
                    TrafficFactory.Insert(TrafficEntityInsert);
                    HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingPictureFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                    HPS.BLL.SettingsBLL.BLLSetting_T SettingPictureEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                    HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingPictureKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                    SettingPictureKey.SettingID_int = 1012;
                    SettingPictureEntity = SettingPictureFactory.GetBy(SettingPictureKey);

                    //////Insert TrafficPicture
                    if (SettingPictureEntity.Value_nvc == "1")
                    {

                        if (szBuffer[0] != 0)
                        {
                            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
                            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
                            TrafficPicturesEntity.TrafficID_bint = TrafficEntityInsert.TrafficID_bint;
                            TrafficPicturesEntity.Picture_vbnry = szBuffer;
                            TrafficPicturesFactory.Insert(TrafficPicturesEntity);
                        }
                        else
                        {
                            throw new ApplicationException("عملیات خواندن پلاک رخ نداده است");
                        }
                    }

                    if (OtherCars)
                    {
                        VerifyCarsFactory.Update(VerifiedCarsEntity);

                    } 

                    TrafficFactory.CommitProc();
                    szBuffer.ToList().Clear();

                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntityInsert, false, true);
                    frm.ShowDialog();
                    clear();
                    NumberPlate_nvcTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                TrafficFactory.RollBackProc();
                throw ex;
            }
        }

        private void TrafficTypeID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1011;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            string Condition = "([StopFee_T].[StartDate_nvc]<='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[EndDate_nvc]>='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[TrafficTypeID_int]='" + TrafficTypeID_intComboBox.SelectedValue + "')";
            StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
            StopFeeList = StopFeeFactory.GetAllByCondition(Condition);
            if (StopFeeList.Count != 0)
            {
                PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                if (StopFeeList[0].Tax_bit)
                {
                    var tax = RoundNumber(Convert.ToDouble(StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100));
                    PriceTax_decnumericTextBox.Text = tax.ToString();
                    PriceWithTax_decNumericTextBox.Text = (StopFeeList[0].Fee_dec + Convert.ToDecimal(tax)).ToString();
                }
                else
                {
                    PriceTax_decnumericTextBox.Text = "";
                    PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                }
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("در این تاریخ برای این نوع تردد مبلغ تعریف نشده است");
            }
            SelectSystemByTrafficType();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            PriceWithTax_decNumericTextBox.Enabled = true;
            PriceWithoutTax_decnumericTextBox.Enabled = true;
            PriceTax_decnumericTextBox.Enabled = true;
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

        //private void TrafficTypeID_intComboBox_SelectedIndexChanged(object sender, EventArgs e)
        private void SelectSystemByTrafficType()
        {
            HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory CarSystemFactory = new HPS.BLL.CarSystemBLL.BLLCarSystem_TFactory();
            var ServiceFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
            DataTable ServiceID = new DataTable();
            ServiceFactory.GetAll(ref ServiceID);
            DataTable SystemTable = new DataTable();
            SystemTable = CarSystemDataTable.Copy();
            if (TrafficTypeID_intComboBox.Text == "سواري")
            {
                if (SystemTable != null)
                {
                    DataRow[] dr = SystemTable.Select("CarSystem_nvc In ('اتوبوس', 'ميني بوس')");
                    if (dr != null && dr.Length > 0)
                    {
                        foreach (DataRow row in dr)
                            row.Delete();
                        SystemTable.AcceptChanges();
                    }
                }
                if (ServiceID != null)
                {
                    ServiceID = ServiceID.Select("ServicesID_int =1 ").CopyToDataTable();

                }
            }
            else if (TrafficTypeID_intComboBox.Text == "متفرقه")
            {
                if (SystemTable != null)
                {
                    DataRow[] dr = SystemTable.Select("CarSystem_nvc not In ('اتوبوس', 'ميني بوس')");
                    if (dr != null && dr.Length > 0)
                    {
                        foreach (DataRow row in dr)
                            row.Delete();
                        SystemTable.AcceptChanges();
                    }
                }
            }
            else if (TrafficTypeID_intComboBox.Text == "امكانات پايانه ")
            {
                if (SystemTable != null)
                {
                    DataRow[] dr = SystemTable.Select("CarSystem_nvc not In ('اتوبوس', 'ميني بوس')");
                    if (dr != null && dr.Length > 0)
                    {
                        foreach (DataRow row in dr)
                            row.Delete();
                        SystemTable.AcceptChanges();
                    }
                }
                if (ServiceID != null)
                {
                    ServiceID = ServiceID.Select("ServicesID_int in (4,5)").CopyToDataTable();
                }
            }

            ServicesID_intComboBox.DataSource = ServiceID;
            ServicesID_intComboBox.SelectedIndex = 0;
            System_nvcCombobox.DataSource = SystemTable;
            System_nvcCombobox.SelectedIndex = -1;
        }

        private void NextButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.NextButton, "Shift+N");
        }

        private void PreviousButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.PreviousButton, "Shift+P");
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
                    List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, _CurrentTrafficNumber);
                    TrafficEntity = TrafficList[0];
                    if (TrafficList.Count > 0 && TrafficList != null)
                    {
                        foreach (HPS.BLL.TrafficBLL.BLLTraffic_T item in TrafficList)
                        {
                            if (item.Out_bit == true)
                            {
                                Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو خارج شده است");
                            }
                        }
                        if (TrafficList.Count == 2)
                        {
                            return;
                        }
                    }
                    TrafficEntity.TurnPrinted_bit = true;
                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, false, true);
                    frm.ShowDialog();
                    //HPS.Reports.ReportDoc.OtherCarReport rpt = new HPS.Reports.ReportDoc.OtherCarReport(TrafficEntity);
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
                }

            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.State = enmFormState.Edit;
                Editbutton.Enabled = true;
                FurtherBillButton.Enabled = true;
                ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
                ((ToolStripButton)this.SaveAndExitButton).Visible = false;
                Trafficnumberlabel.Visible = true;
                TrafficNumbertextBox.Visible = true;
                CorrectButton.Enabled = false;
                PriceWithTax_decNumericTextBox.Enabled = false;
                PriceTax_decnumericTextBox.Enabled = false;
                PriceWithoutTax_decnumericTextBox.Enabled = false;
                NewButton.Enabled = true;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                if (TrafficTypeID_intComboBox.SelectedValue != null && (Int32)TrafficTypeID_intComboBox.SelectedValue != -1 && (Int32)TrafficTypeID_intComboBox.SelectedValue != 0)
                {
                    TrafficFactory.PreviousNavigation((Int32)TrafficTypeID_intComboBox.SelectedValue, this._CurrentTrafficNumber, TrafficNavigationDataTable);
                    if (TrafficNavigationDataTable != null && TrafficNavigationDataTable.Rows.Count > 0)
                    {

                        this._CurrentTrafficNumber = (Int64?)TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"];
                        List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this._CurrentTrafficNumber);


                        if (TrafficList != null && TrafficList.Count > 0)
                        {

                            this.TrafficKey.TrafficID_bint = TrafficList[0].TrafficID_bint;
                        }
                        NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NumberPlate_nvc"], TypeCode.String));
                        SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["SerialPlate_nvc"], TypeCode.String));
                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                        PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));
                        TrafficNumbertextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"], TypeCode.Int64));
                        System_nvcCombobox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, TrafficNavigationDataTable.Rows[0]["PlateCityID_int"], TypeCode.Int32);
                        PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityCode_nvc"], TypeCode.String));
                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                        FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                        LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                        PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PriceTax_dec"], TypeCode.Decimal));

                    }
                    else
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("تردد جاری اولین مورداست");

                    }
                }
                else
                    Hepsa.Core.Common.MessageBox.InformationMessage("نوع تردد را انتخاب نمایید");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (this.State == enmFormState.Edit)
            {
                this.SaveAndContinueButtonEvent(sender, e);
                NewButton.Enabled = false;
                EnableButtons();
                FurtherBillButton.Enabled = false;
            }
        }

        private void EnableButtons()
        {
            Trafficnumberlabel.Visible = false;
            TrafficNumbertextBox.Visible = false;
            CorrectButton.Enabled = true;
            PriceWithTax_decNumericTextBox.Text = string.Empty;
            PriceTax_decnumericTextBox.Text = string.Empty;
            PriceWithoutTax_decnumericTextBox.Text = string.Empty;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.State = enmFormState.Edit;

                Editbutton.Enabled = true;
                FurtherBillButton.Enabled = true;
                ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
                ((ToolStripButton)this.SaveAndExitButton).Visible = false;
                Trafficnumberlabel.Visible = true;
                TrafficNumbertextBox.Visible = true;
                CorrectButton.Enabled = false;
                NewButton.Enabled = true;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();
                if (TrafficTypeID_intComboBox.SelectedValue != null && (Int32)TrafficTypeID_intComboBox.SelectedValue != -1 && (Int32)TrafficTypeID_intComboBox.SelectedValue != 0)
                {
                    TrafficFactory.NextNavigation((Int32)TrafficTypeID_intComboBox.SelectedValue, this._CurrentTrafficNumber, TrafficNavigationDataTable);
                    if (TrafficNavigationDataTable != null && TrafficNavigationDataTable.Rows.Count > 0)
                    {


                        this._CurrentTrafficNumber = (long?)TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"];
                        List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this._CurrentTrafficNumber);
                        if (TrafficList != null && TrafficList.Count > 0)
                        {
                            this.TrafficKey.TrafficID_bint = TrafficList[0].TrafficID_bint;
                        }

                        NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["NumberPlate_nvc"], TypeCode.String));
                        SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["SerialPlate_nvc"], TypeCode.String));
                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                        PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));
                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, TrafficNavigationDataTable.Rows[0]["PlateCityID_int"], TypeCode.Int32);
                        PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PlateCityCode_nvc"], TypeCode.String));
                        System_nvcCombobox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                        Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                        TrafficNumbertextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"], TypeCode.Int64));
                        FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                        LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                        PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PriceTax_dec"], TypeCode.Decimal));
                    }
                    else
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("تردد جاری آخرین مورداست");

                    }
                }
                else
                    Hepsa.Core.Common.MessageBox.InformationMessage("نوع تردد را انتخاب نمایید");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.State = enmFormState.Add;
            Trafficnumberlabel.Visible = false;
            TrafficNumbertextBox.Visible = false;
            CorrectButton.Enabled = false;
            Editbutton.Enabled = false;
            FurtherBillButton.Enabled = false;
            _CurrentTrafficNumber = null;
            clear();
            NewButton.Enabled = false;
        }

        protected override void Edit()
        {
            try
            {
                #region edit
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.TrafficID_bint, TrafficKey.TrafficID_bint);
                if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                {
                    throw new ApplicationException("این راننده و ناوگان مجوز گرفته است");
                }
                else
                {
                    HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                    HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityUpdate = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                    TrafficEntityUpdate = TrafficFactory.GetBy(TrafficKey);
                    TrafficEntityUpdate.FirstName_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String));
                    TrafficEntityUpdate.LastName_nvc = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String));

                    if (string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text.Trim()))
                    {
                        throw new ApplicationException("شماره پلاک خالی است");
                    }
                    else
                    {
                        TrafficEntityUpdate.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                        TrafficEntityUpdate.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                    }
                    TrafficEntityUpdate.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                    TrafficEntityUpdate.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();

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
                    TrafficEntityUpdate.System_nvc = System_nvcCombobox.Text;
                    TrafficEntityUpdate.ServiceID_int = (Int32?)ServicesID_intComboBox.SelectedValue;
                    TrafficEntityUpdate.Services_nvc = ServicesID_intComboBox.Text;
                    TrafficEntityUpdate.TrafficTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                    TrafficEntityUpdate.DriverMobileNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_vcTextBox.Text, TypeCode.String).ToString();
                    TrafficEntityUpdate.Price_dec = (Decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(PriceWithTax_decNumericTextBox.Text, TypeCode.Decimal);
                    TrafficEntityUpdate.PriceTax_dec = (Decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(PriceTax_decnumericTextBox.Text, TypeCode.Decimal);

                    HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                    string BillCondition = "([BillMessage_T].[StartDate_nvc]<='" + BillMessageFactory.ServerJalaliDate + "') AND ([BillMessage_T].[EndDate_nvc]>= '" + BillMessageFactory.ServerJalaliDate + "' ) AND (TrafficType_T.TrafficTypeID_int='" + TrafficTypeID_intComboBox.SelectedValue + "')";
                    List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(BillCondition);
                    if (BillMessageList != null && BillMessageList.Count > 0)
                    {
                        TrafficEntityUpdate.BillMessageID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageList[0].BillMessageID_int, TypeCode.Int32);
                    }

                    TrafficEntityUpdate.EditUserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    TrafficEntityUpdate.EditDate_vc= TrafficFactory.ServerJalaliDate;
                    TrafficEntityUpdate.EditTime_vc = TrafficFactory.ServerTime;

                    if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آیا از ثبت اطلاعات اطمینان دارید؟") == true)
                    {
                        TrafficFactory.BeginProc();
                        TrafficFactory.Update(TrafficEntityUpdate, TrafficKey);
                        TrafficFactory.CommitProc();
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void NewButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.NewButton, "Ctrl+N");
        }

        private void Editbutton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.Editbutton, "Shift+E");
        }

        private void FurtherBillButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.FurtherBillButton, "Ctrl+P");
        }

        private void clear()
        {
            this.ClearForm(this);
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1011;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            SerialPlate_nvcTextBox.Text = "15";
            ServicesID_intComboBox.Text = "پاركينگ";
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityID_intFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            List<HPS.BLL.PlateCityBLL.BLLPlateCity_T> PlatecityList = PlateCityID_intFactory.GetAllBy(HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityCode_nvc, 11320002);
            if (PlatecityList != null && PlatecityList.Count > 0)
            {
                Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, PlatecityList[0].PlateCityID_int, TypeCode.Int32);
            }
            this.TrafficTypeID_intComboBox.SelectedValue = 3;
            HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
            string Condition = "([StopFee_T].[StartDate_nvc]<='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[EndDate_nvc]>='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[TrafficTypeID_int]='" + TrafficTypeID_intComboBox.SelectedValue + "')";
            StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
            StopFeeList = StopFeeFactory.GetAllByCondition(Condition);
            if (StopFeeList.Count != 0)
            {
                PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                if (StopFeeList[0].Tax_bit)
                {
                    var tax =RoundNumber(Convert.ToDouble((StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100)));
                    PriceTax_decnumericTextBox.Text = tax.ToString();
                    PriceWithTax_decNumericTextBox.Text = (StopFeeList[0].Fee_dec + Convert.ToDecimal(tax)).ToString();
                }
                else
                {
                    PriceTax_decnumericTextBox.Text = "";
                    PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                }

            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("در این تاریخ برای این نوع تردد مبلغ تعریف نشده است");
            }
        }

        protected override void ShowForm()
        {
            this.FillCombo();
            Editbutton.Enabled = true;
            NumberPlateReadingButton.Enabled = false;
            ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
            ((ToolStripButton)this.SaveAndExitButton).Visible = false;
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            TrafficEntity = TrafficFactory.GetBy(TrafficKey);
            FirstName_nvcTextBox.Text = TrafficEntity.FirstName_nvc;
            LastName_nvcTextBox.Text = TrafficEntity.LastName_nvc;
            NumberPlate_nvcTextBox.Text = TrafficEntity.NumberPlate_nvc;
            Mobile_vcTextBox.Text = TrafficEntity.DriverMobileNumber_nvc;
            TrafficTypeID_intComboBox.SelectedValue = TrafficEntity.TrafficTypeID_int;
            ServicesID_intComboBox.SelectedValue = TrafficEntity.ServiceID_int;
            System_nvcCombobox.Text = TrafficEntity.System_nvc;
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
            //PriceWithTax_decNumericTextBox.Text = TrafficEntity.Price_dec.ToString();
            //PriceTax_decnumericTextBox.Text = TrafficEntity.PriceTax_dec.ToString();

            PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.Price_dec, TypeCode.String));
            PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.PriceTax_dec, TypeCode.String));
            if (string.IsNullOrEmpty(TrafficEntity.PriceTax_dec.ToString()))
            { PriceWithoutTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.Price_dec, TypeCode.String));
            }
            else
            { PriceWithoutTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficEntity.Price_dec - TrafficEntity.PriceTax_dec, TypeCode.String));
            }


            //show picture
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TKeys _key = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TKeys();
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
                System.IO.MemoryStream pictureMemoryStream = new System.IO.MemoryStream();
                pictureMemoryStream.Write(TrafficPicturesEntity.Picture_vbnry, 0, TrafficPicturesEntity.Picture_vbnry.Length);
                pictureBox.Image = System.Drawing.Image.FromStream(pictureMemoryStream);

                pictureBox.Height = 220;
                pictureBox.Width = 252;
            }
        }

        private async void NumberPlateReadingButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<byte[]> Inimgs = new List<byte[]>();


                NumberPlateReadingButton.Enabled = false;
                string number = string.Empty;
                snapshot();
                //number = anprService.GetPlateNumberByByte(szBuffer);
                number = await api.GetNumberPlate(szBuffer);
                ////////for (int i = 0; i < 7; i++)
                ////////{
                ////////    axVitaminCtrl1.DigitalZoomFactor = 300;
                ////////    axVitaminCtrl1.GetSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, out objData, out info);
                ////////    if (objData != null)
                ////////    {
                ////////        byteData = (byte[])objData;
                ////////        Inimgs.Add(byteData);
                ////////    }
                ////////    if (Inimgs.Count < 7)
                ////////    {
                ////////        i++;
                ////////        axVitaminCtrl1.GetSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, out objData, out info);
                ////////        if (objData != null)
                ////////        {
                ////////            byteData = (byte[])objData;
                ////////            Inimgs.Add(byteData);
                ////////        }
                ////////    }

                ////////}
                ////////if (Inimgs.Count != 0)
                ////////{
                ////////    ImageArray = Inimgs[3];
                ////////}
                //////number = anprService.GetPlateNumber(Inimgs.ToArray());

                NumberPlateReadingButton.Enabled = true;
                ////number = "56ع87615";
                if (!string.IsNullOrEmpty(number))
                {
                    HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new BLL.TruePlate.ConvertToTrueNumber();
                    string plateNumber_nvc = string.Empty;
                    string plateSerial_nvc = string.Empty;

                    //NumberPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 2) + number.Substring(5, 4) + number.Substring(3, 2));
                    //SerialPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(9, 2));

                    //NumberPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 2) + number.Substring(5, 4) + number.Substring(3, 2));
                    //SerialPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(number.Substring(9, 2));

                    NumberPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 9));
                    SerialPlate_nvcTextBoxCamera.Text = trueNumberClass.GetPlateNumber(number.Substring(10, 2));


                    NumberPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(number.Substring(1, 9));
                    SerialPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(number.Substring(10, 2));
                    if (NumberPlate_nvcTextBoxCamera.Text.Contains('ی'))
                    {
                        NumberPlate_nvcTextBoxCamera.Text = NumberPlate_nvcTextBoxCamera.Text.Replace('ی', 'ي');
                        NumberPlate_nvcTextBox.Text = NumberPlate_nvcTextBox.Text.Replace('ی', 'ي');
                    }
                    SelectByPlate(NumberPlate_nvcTextBoxCamera.Text, SerialPlate_nvcTextBoxCamera.Text);
                }
                else
                {
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBoxCamera.Text = string.Empty;
                    SerialPlate_nvcTextBoxCamera.Text = string.Empty;
                }
            }

            catch (Exception ex)
            {
                NumberPlateReadingButton.Enabled = true;
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
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

        public byte[] ConvertImageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void captureOtherTrafficCameraTimer_Tick(object sender, EventArgs e)
        {
            //Mrt.Anpr.Library.dFxCamera cam = new Mrt.Anpr.Library.dFxCamera("172.20.229.202");
            try
            {
                //if (sensorIsTrue_bit == false)
                //{
                //    //Check IF Sensors IS OFF
                //    HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TFactory sensorsStatusFactory = new BLL.BLLSensorsStatus.BLLSensorsStatus_TFactory();
                //    List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> sensortStatusList = new List<BLL.BLLSensorsStatus.BLLSensorsStatus_T>();
                //    sensortStatusList = sensorsStatusFactory.GetAll();
                //    if (sensortStatusList != null && sensortStatusList.Count > 0)
                //    {
                //        if (sensortStatusList[0].inSensor_bit == true)
                //        {
                //            sensorIsTrue_bit = true;
                //            //read from service
                //            string numberPlate_nvc = string.Empty;
                //            string serialPlate_nvc = string.Empty;

                //            WebReference.ServiceRefrence anprService = new WebReference.ServiceRefrence();
                //            string number = string.Empty;
                //            cam.StartCameraService();
                //            //List<Image> images = new List<Image>();
                //            List<byte[]> imgs = new List<byte[]>();
                //            Image img = null;
                //            for (int i = 0; i < 7; i++)
                //            {
                //                img = cam.GetImage();
                //                imgs.Add(ConvertImageToByteArray(img));
                //            }
                //            cam.StopCameraService();
                //            number = anprService.GetPlateNumber(imgs.ToArray());
                //            if (!string.IsNullOrEmpty(number))
                //            {

                //                numberPlate_nvc = number.Substring(0, 3) + number.Substring(3, 3);
                //                serialPlate_nvc = number.Substring(6, 2);
                //                HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new HPS.BLL.TruePlate.ConvertToTrueNumber();
                //                NumberPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(numberPlate_nvc);
                //                SerialPlate_nvcTextBox.Text = trueNumberClass.GetPlateNumber(serialPlate_nvc);

                //                //insert into InCameraTable
                //                HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TFactory InCameraPicturesFactory = new BLL.InCameraPicturesBLL.BLLInCameraPictures_TFactory();
                //                HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T InCameraPicturesEntity = new BLL.InCameraPicturesBLL.BLLInCameraPictures_T();
                //                InCameraPicturesEntity.Date_vc = InCameraPicturesFactory.ServerJalaliDate;
                //                InCameraPicturesEntity.Time_vc = InCameraPicturesFactory.ServerTime;
                //                InCameraPicturesEntity.Picture_img = imgs[0];
                //                InCameraPicturesEntity.PlateNumber_nvc = NumberPlate_nvcTextBox.Text;
                //                InCameraPicturesEntity.PlateSerial_vc = SerialPlate_nvcTextBox.Text;
                //                InCameraPicturesEntity.TrafficTypeID_int = (Int32)TrafficTypeID_intComboBox.SelectedValue;
                //                InCameraPicturesFactory.Insert(InCameraPicturesEntity);

                //            }
                //            else
                //            {
                //                sensorIsTrue_bit = false;
                //                //throw new ApplicationException("شماره پلاک خوانده نشد");
                //            }
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            finally
            {
                //cam.StopCameraService();
            }
        }
        private void SelectByPlate(string numberplate, string serialplate)
        {
            var Traffic = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            var dt = new DataTable();
            try
            {
                Traffic.SelectByPlate(numberplate, serialplate, dt);
                if (dt.Rows.Count > 0)
                {
                    FirstName_nvcTextBox.Text = dt.Rows[0]["FirstName_nvc"].ToString();
                    LastName_nvcTextBox.Text = dt.Rows[0]["LastName_nvc"].ToString();
                    Mobile_vcTextBox.Text = dt.Rows[0]["DriverMobileNumber_nvc"].ToString();
                    TrafficTypeID_intComboBox.SelectedValue = ((Int32?)dt.Rows[0]["TrafficTypeID_int"]).Value;
                    ServicesID_intComboBox.SelectedValue = ((Int32?)dt.Rows[0]["ServiceID_int"]).Value;
                    TrafficTypeID_intComboBox_SelectionChangeCommitted(null, null);
                    System_nvcCombobox.Text = dt.Rows[0]["System_nvc"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void SerialPlate_nvcTextBox_Leave(object sender, EventArgs e)
        {
            SelectByPlate(NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
        }

        private void CarSystemID_intComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
                axVLCPlugin21.Visible = false;
                axVLCPlugin22.Visible = true;

                //////connect to messoa camera
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

        private async void NumberPlateReadingEditStateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number = string.Empty;

                if (PictureDataUserdEdit != null && this.State == enmFormState.Edit)
                {
                    number = await api.GetNumberPlate(PictureDataUserdEdit);
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
        }
    }
}
