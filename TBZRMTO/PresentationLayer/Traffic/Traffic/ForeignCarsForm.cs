using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace HPS.Present.Traffic
{
    public partial class ForeignCarsForm : Hepsa.Core.PL.BaseEntityForm2
    {
        public ForeignCarsForm()
            : base(null)
        {
            InitializeComponent();
            this.EnglishControls.Add("NumberPlate_nvcTextBox", this.NumberPlate_nvcTextBox);
        }

        HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
        public ForeignCarsForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.TrafficBLL.BLLTraffic_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
            TrafficKey = Key;
        }
        ToolTip tooltip1 = new ToolTip();
        private void ForeignCarsForm_Load(object sender, EventArgs e)
        {
            if (this.State == enmFormState.Add)
            {
                FillCombo();

            }
            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 100;
            tooltip1.ReshowDelay = 100;
            tooltip1.ShowAlways = true;
            if (PriceWithTax_decNumericTextBox.Text == "")
            {
                PriceCorrectButon.Enabled = false;
            }
        }

        private Int64? _CurrentTrafficNumber = null;

        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntityInsert = new HPS.BLL.TrafficBLL.BLLTraffic_T();
        HPS.BLL.StopFeeBLL.BLLStopFee_TFactory StopFeeFactory = new HPS.BLL.StopFeeBLL.BLLStopFee_TFactory();
        List<HPS.BLL.StopFeeBLL.BLLStopFee_T> StopFeeList = null;
        DataTable LaderTypeID_intDataTable = new DataTable();

        private void FillCombo()
        {
            try
            {
                HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
                string countryCondition = "[Country_T].[Active_bit]='true'";
                DataTable CountryDataTable = new DataTable();
                CountryFactory.GetAllByCondition(countryCondition, ref CountryDataTable);
                NationalityCountryID_intComboBox.DataSource = CountryDataTable;
                NationalityCountryID_intComboBox.DisplayMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString();
                NationalityCountryID_intComboBox.ValueMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString();
                NationalityCountryID_intComboBox.SelectedIndex = -1;
                HPS.BLL.BoundryBLL.BLLBoundry_TFactory BoundryFactory = new HPS.BLL.BoundryBLL.BLLBoundry_TFactory();
                DataTable BoundryDataTable = new DataTable();
                BoundryFactory.GetAll(ref BoundryDataTable);
                EntranceBoundaryID_intComboBox.DataSource = BoundryDataTable;
                EntranceBoundaryID_intComboBox.DisplayMember = HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.Boundry_nvc.ToString();
                EntranceBoundaryID_intComboBox.ValueMember = HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField.BoundryID_int.ToString();
                EntranceBoundaryID_intComboBox.SelectedIndex = -1;

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();

                string laderCondition = "[LaderType_T].[Active_bit]='true'";
                LaderTypeID_intFactory.GetAllByCondition(laderCondition, ref LaderTypeID_intDataTable);
                DataRow drLaderType = LaderTypeID_intDataTable.NewRow();
                drLaderType["LaderTypeID_int"] = 0;
                LaderTypeID_intDataTable.Rows.InsertAt(drLaderType, 0);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory TrafficTypeFactory = new HPS.BLL.TrafficTypeBLL.BLLTrafficType_TFactory();
                DataTable TrafficTypeDataTable = new DataTable();
                TrafficTypeFactory.GetAll(ref TrafficTypeDataTable);
                TrafficTypeID_intComboBox.DataSource = TrafficTypeDataTable;
                TrafficTypeID_intComboBox.DisplayMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficType_nvc.ToString();
                TrafficTypeID_intComboBox.ValueMember = HPS.BLL.TrafficTypeBLL.BLLTrafficType_T.TrafficType_TField.TrafficTypeID_int.ToString();
                TrafficTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.ServicesBLL.BLLServices_TFactory ServicesFactory = new HPS.BLL.ServicesBLL.BLLServices_TFactory();
                DataTable ServicesDataTable = new DataTable();
                string condition = " [Services_T].[ServicesID_int]=3 and [Services_T].[Activie_bit]='true'";
                ServicesFactory.GetAllByCondition(condition, ref ServicesDataTable);
                ServicesID_intComboBox.DataSource = ServicesDataTable;
                ServicesID_intComboBox.DisplayMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesType_nvc.ToString();
                ServicesID_intComboBox.ValueMember = HPS.BLL.ServicesBLL.BLLServices_T.Services_TField.ServicesID_int.ToString();
                //ServicesID_intComboBox.SelectedIndex = -1;

                DataTable OriginCountryID_intDataTable = new DataTable();
                CountryFactory.GetAllByCondition(countryCondition, ref OriginCountryID_intDataTable);
                this.OriginCountryID_intComboBox.DisplayMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString();
                this.OriginCountryID_intComboBox.ValueMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString();
                this.OriginCountryID_intComboBox.DataSource = OriginCountryID_intDataTable;
                this.OriginCountryID_intComboBox.SelectedIndex = -1;

                DataTable DestinationCountryID_intDataTable = new DataTable();
                CountryFactory.GetAllByCondition(countryCondition, ref DestinationCountryID_intDataTable);
                this.DestinationCountryID_intComboBox.DisplayMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString();
                this.DestinationCountryID_intComboBox.ValueMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString();
                this.DestinationCountryID_intComboBox.DataSource = DestinationCountryID_intDataTable;
                this.DestinationCountryID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                DataTable CarSystemDataTable = new DataTable();
                CarFactory.CarSystemGetAll(ref CarSystemDataTable);
                System_nvcCombobox.DataSource = CarSystemDataTable;
                System_nvcCombobox.DisplayMember = HPS.BLL.CarBLL.BLLCar_T.Car_TField.System_nvc.ToString();
                System_nvcCombobox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LaderType_nvcSearchButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1011;
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
                    if (LaderTypeID_intComboBox.SelectedIndex != 0)
                    {
                        if (LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"] == null || LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"].ToString() == "")
                        {
                            Hepsa.Core.Common.MessageBox.ErrorMessage("برای بارگیر محور تعیین نشده است");
                            PriceWithTax_decNumericTextBox.Text = "";
                            PriceTax_decnumericTextBox.Text = "";
                            PriceWithoutTax_decnumericTextBox.Text = "";
                        }
                        else
                        {
                            string Condition = "([StopFee_T].[StartDate_nvc]<='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[EndDate_nvc]>='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[LaderPivotGroupID_int]=" + Convert.ToInt32(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"]) + ") AND ([StopFee_T].[TrafficTypeID_int]=2)";
                            StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
                            StopFeeList = StopFeeFactory.GetAllByCondition(Condition);
                            if (StopFeeList.Count != 0)
                            {
                                PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                                if (StopFeeList[0].Tax_bit)
                                {
                                    PriceTax_decnumericTextBox.Text = (StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100).ToString();
                                    PriceWithTax_decNumericTextBox.Text = RoundNumber(Convert.ToDouble((StopFeeList[0].Fee_dec + StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100))).ToString();
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
            return number;
        }
        //private double RoundNumber(double number)
        //{
        //    number = Math.Round(number);

        //    if (number > 5000)
        //    {
        //        double khord = number % 5000;
        //        if (khord == 0)
        //        {
        //            return number;
        //        }
        //        else if (khord > 0 && khord < 2499)
        //        {
        //            return number - khord;
        //        }
        //        else if (khord > 2500 && khord < 5000)
        //        {
        //            return number - khord + 5000;
        //        }
        //        else
        //        {
        //            return number;
        //        }
        //    }
        //    else
        //    {
        //        return number;
        //    }
        //}
        private void LastDriverTrafficButoon_Click(object sender, EventArgs e)
        {
        }

        private void LastCarTrafficButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string TrafficCondition = string.Empty;
            List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);

            string TurnNumberCondition = string.Empty;
            if (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) || !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
            {
                TrafficCondition = "(([Traffic_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "')";

            }
            if (TrafficCondition != null && TrafficList != null && TrafficList.Count > 0 && TrafficCondition != "")
            {
                HPS.Present.Traffic.LastCarTraffic frm = new HPS.Present.Traffic.LastCarTraffic(NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                frm.Show();
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "ترددی با مشخصات"));
            }
        }

        private void WithLade_bitRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LaderTypeID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (LaderTypeID_intComboBox.SelectedIndex != -1)
                {
                    HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                    HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                    HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                    SettingKey.SettingID_int = 1011;
                    SettingEntity = SettingFactory.GetBy(SettingKey);
                    LaderTypeEntity.LaderTypeID_int = (Int32)LaderTypeID_intComboBox.SelectedValue;
                    LaderTypeEntity.LaderType_nvc = LaderTypeID_intDataTable.Rows[Convert.ToInt32(LaderTypeID_intComboBox.SelectedIndex)]["LaderType_nvc"].ToString();
                    LaderTypeCode_nvcTextBox.Text = LaderTypeID_intDataTable.Rows[Convert.ToInt32(LaderTypeID_intComboBox.SelectedIndex)]["LaderTypeCode_nvc"].ToString();

                    if (LaderTypeID_intComboBox.SelectedIndex != 0)
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
                            string Condition = "([StopFee_T].[StartDate_nvc]<='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[EndDate_nvc]>='" + StopFeeFactory.ServerJalaliDate + "') AND ([StopFee_T].[LaderPivotGroupID_int]=" + Convert.ToInt32(LaderTypeID_intDataTable.Rows[LaderTypeID_intComboBox.SelectedIndex]["LaderPivotGroupID_int"]) + ") AND ([StopFee_T].[TrafficTypeID_int]=2)";
                            StopFeeList = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
                            StopFeeList = StopFeeFactory.GetAllByCondition(Condition);
                            if (StopFeeList.Count != 0)
                            {
                                PriceWithoutTax_decnumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                                if (StopFeeList[0].Tax_bit)
                                {
                                    var tax = RoundNumber(Convert.ToDouble((StopFeeList[0].Fee_dec * Int32.Parse(SettingEntity.Value_nvc) / 100)));
                                    PriceTax_decnumericTextBox.Text =tax.ToString();
                                    PriceWithTax_decNumericTextBox.Text = (StopFeeList[0].Fee_dec +Convert.ToDecimal(tax)).ToString();
                                }
                                else
                                {
                                    PriceTax_decnumericTextBox.Text = "";
                                    PriceWithTax_decNumericTextBox.Text = StopFeeList[0].Fee_dec.ToString();
                                }

                            }
                            else
                            {
                                throw new ApplicationException(HPS.Exceptions.ExceptionCs.StopFeeNotExist);
                            }
                        }
                    }
                }
                if (this.State == enmFormState.Add)
                {
                    PriceCorrectButon.Enabled = true;
                }
                else
                {
                    PriceCorrectButon.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        protected override void Insert()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آیا مایل به ثبت ورود هستید ؟") == false)
                    return;

                TrafficEntityInsert.Date_nvc = TrafficFactory.ServerJalaliDate;
                TrafficEntityInsert.Time_nvc = TrafficFactory.ServerTime;
                TrafficEntityInsert.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.OriginCountryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(OriginCountryID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntityInsert.NationalityCountryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalityCountryID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntityInsert.EntranceBoundaryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(EntranceBoundaryID_intComboBox.SelectedValue, TypeCode.Int32);
                TrafficEntityInsert.DestinationCountryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(DestinationCountryID_intComboBox.SelectedValue, TypeCode.Int32);

                TrafficEntityInsert.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.SystemCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcCombobox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.System_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcCombobox.Text, TypeCode.String).ToString();
                TrafficEntityInsert.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                if (ServicesID_intComboBox.SelectedIndex != -1)
                {
                    TrafficEntityInsert.ServiceID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ServicesID_intComboBox.SelectedValue, TypeCode.Int32);

                }
                if (LaderTypeID_intComboBox.SelectedIndex == -1)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage("بارگیر انتخاب نشده است");
                }
                else
                {
                    TrafficEntityInsert.LaderTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                    TrafficEntityInsert.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();


                    if (StopFeeList.Count > 0 && StopFeeList != null)
                    {
                        TrafficEntityInsert.StopFeeID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].StopFeeID_int, TypeCode.Int32);
                        TrafficEntityInsert.AllowableHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].AllowedHoure_int, TypeCode.Int32);
                        TrafficEntityInsert.ExtraHour_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHour_int, TypeCode.Int32);
                        TrafficEntityInsert.ExtraHourFee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].ExtraHourFee_dec, TypeCode.Decimal);
                        TrafficEntityInsert.Fee_dec = (Decimal)Hepsa.Core.Common.PersentationController.GetEntityValue(StopFeeList[0].Fee_dec, TypeCode.Decimal);
                    }
                }

                TrafficEntityInsert.Printed_bit = false;
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

                TrafficEntityInsert.TrafficTypeID_int = 2;
                TrafficEntityInsert.Date_nvc = TrafficFactory.ServerJalaliDate;
                TrafficEntityInsert.Time_nvc = TrafficFactory.ServerTime;
                if (WithFlatRadioButton.Checked == false)
                {
                    TrafficEntityInsert.WithFlat_bit = false;
                }
                else
                {
                    TrafficEntityInsert.WithFlat_bit = true;
                }


                string trafficCondition = "[Traffic_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "' AND [Traffic_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "'";
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(trafficCondition);
                if (TrafficList.Count > 0 && TrafficList != null)
                {
                    Int64 LastTrafficNumber = TrafficList.Max(itm => itm.TrafficNumber_bint);
                    List<HPS.BLL.TrafficBLL.BLLTraffic_T> LastTraffic = TrafficList.FindAll(itm => itm.TrafficNumber_bint == LastTrafficNumber);

                    if (LastTraffic.Exists(itm => itm.In_bit == false) == false)
                    {
                        throw new ApplicationException("کامیون به شماره قبض " + LastTrafficNumber + " خارج نشده است");
                    }
                }

                TrafficEntityInsert.In_bit = true;
                TrafficEntityInsert.Out_bit = false;

                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                string BillCondition = "([BillMessage_T].[StartDate_nvc]<='" + BillMessageFactory.ServerJalaliDate + "') AND ([BillMessage_T].[EndDate_nvc]>= '" + BillMessageFactory.ServerJalaliDate + "' ) AND (TrafficType_T.TrafficTypeID_int=2)";
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(BillCondition);
                if (BillMessageList != null && BillMessageList.Count > 0)
                {
                    TrafficEntityInsert.BillMessageID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageList[0].BillMessageID_int, TypeCode.Int32);
                }
                TrafficEntityInsert.Price_dec = (Decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(PriceWithTax_decNumericTextBox.NumericText, TypeCode.Decimal);
                TrafficEntityInsert.PriceTax_dec = (Decimal?)Hepsa.Core.Common.PersentationController.GetEntityValue(PriceTax_decnumericTextBox.NumericText, TypeCode.Decimal);
                TrafficEntityInsert.Hourse_bit = HorseRradioButton.Checked;
                TrafficEntityInsert.Comment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Comment_nvcTextBox.Text, TypeCode.String).ToString();

                if (WithLade_bitRadioButton.Checked)
                {
                    TrafficEntityInsert.WithLade_bit = true;
                }
                else
                {
                    TrafficEntityInsert.WithLade_bit = false;
                }
                TrafficEntityInsert.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                TrafficEntityInsert.Services_nvc = ServicesID_intComboBox.Text;
                TrafficEntityInsert.TurnAccepted_bit = false;
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage("" + TrafficEntityInsert.Price_dec + "ر یال باید از راننده گرفته شود.  آیا از ثبت اطلاعات اطمینان دارید؟  ") == true)
                {
                    TrafficFactory.BeginProc();
                    TrafficFactory.Insert(TrafficEntityInsert);
                    TrafficFactory.CommitProc();


                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntityInsert, true, true);
                    frm.ShowDialog();
                    //

                    //HPS.Reports.ReportDoc.ForeignCarsReport rpt = new HPS.Reports.ReportDoc.ForeignCarsReport(TrafficEntityInsert);
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
                    this.ClearForm(this);
                    WithoutLade_bitRadioButton.Checked = true;
                    WithFlatRadioButton.Checked = true;
                }
            }
            catch (Exception ex)
            {
                TrafficFactory.RollBackProc();
                throw ex;
            }
        }

        private void EntranceBoundryID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Boundry.BoundryEntityForm frm = new HPS.Present.Boundry.BoundryEntityForm((DataTable)EntranceBoundaryID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void PriceCorrectButon_Click(object sender, EventArgs e)
        {
            PriceWithTax_decNumericTextBox.Enabled = true;
            PriceTax_decnumericTextBox.Enabled = true;
            PriceWithoutTax_decnumericTextBox.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void WithoutLade_bitRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LadeChooseButton_Click(object sender, EventArgs e)
        {
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
                                return;
                            }
                        }
                        if (TrafficList.Count == 2)
                        {
                            return;
                        }
                    }

                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntity, true, true);
                    frm.ShowDialog();
                    //HPS.Reports.ReportDoc.ForeignCarsReport rpt = new HPS.Reports.ReportDoc.ForeignCarsReport(TrafficEntity);
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
                PriceCorrectButon.Enabled = false;
                PriceWithTax_decNumericTextBox.Enabled = false;
                PriceTax_decnumericTextBox.Enabled = false;
                PriceWithoutTax_decnumericTextBox.Enabled = false;
                NewButton.Enabled = true;

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                TrafficFactory.PreviousNavigation(2, this._CurrentTrafficNumber, TrafficNavigationDataTable);
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
                    System_nvcCombobox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"], TypeCode.Int32);
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderTypeCode_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                    PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));
                    TrafficNumbertextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["TrafficNumber_bint"], TypeCode.Int64));
                    FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["FirstName_nvc"], TypeCode.String));
                    LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LastName_nvc"], TypeCode.String));
                    PriceTax_decnumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["PriceTax_dec"], TypeCode.Decimal));
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
                this.State = enmFormState.Edit;
                Editbutton.Enabled = true;
                FurtherBillButton.Enabled = true;
                ((ToolStripButton)this.SaveAndContinueButton).Visible = false;
                ((ToolStripButton)this.SaveAndExitButton).Visible = false;
                Trafficnumberlabel.Visible = true;
                TrafficNumbertextBox.Visible = true;
                PriceCorrectButon.Enabled = false;
                NewButton.Enabled = true;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TrafficNavigationDataTable = new DataTable();

                TrafficFactory.NextNavigation(2, this._CurrentTrafficNumber, TrafficNavigationDataTable);
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
                    System_nvcCombobox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["System_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficNavigationDataTable.Rows[0]["LaderTypeID_int"], TypeCode.Int32);
                    LaderTypeCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["LaderTypeCode_nvc"], TypeCode.String));
                    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ServicesID_intComboBox, TrafficNavigationDataTable.Rows[0]["ServiceID_int"], TypeCode.Int32);
                    PriceWithTax_decNumericTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNavigationDataTable.Rows[0]["Price_dec"], TypeCode.Decimal));
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
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            this.SaveAndContinueButtonEvent(sender, e);
            NewButton.Enabled = false;
            FurtherBillButton.Enabled = false;
        }

        protected override void Edit()
        {
            try
            {
                #region edit

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
                TrafficEntityUpdate.System_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcCombobox.Text, TypeCode.String).ToString();
                TrafficEntityUpdate.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                if (LaderTypeID_intComboBox.SelectedIndex == -1 || LaderTypeID_intComboBox.SelectedIndex == 0)
                {
                    throw new ApplicationException("بارگیر انتخاب نشده است");
                }
                else
                {
                    TrafficEntityUpdate.LaderTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                    TrafficEntityUpdate.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();

                }
                if (NationalityCountryID_intComboBox.SelectedIndex != -1 || NationalityCountryID_intComboBox.SelectedIndex != 0)
                {
                    TrafficEntityUpdate.NationalityCountryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalityCountryID_intComboBox.SelectedValue, TypeCode.Int32);
                }
                if (OriginCountryID_intComboBox.SelectedIndex != -1 || OriginCountryID_intComboBox.SelectedIndex != 0)
                {
                    TrafficEntityUpdate.OriginCountryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(OriginCountryID_intComboBox.SelectedValue, TypeCode.Int32);
                }
                if (DestinationCountryID_intComboBox.SelectedIndex != -1 || DestinationCountryID_intComboBox.SelectedIndex != 0)
                {
                    TrafficEntityUpdate.DestinationCountryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(DestinationCountryID_intComboBox.SelectedValue, TypeCode.Int32);
                }
                if (EntranceBoundaryID_intComboBox.SelectedIndex != -1 || EntranceBoundaryID_intComboBox.SelectedIndex != 0)
                {
                    TrafficEntityUpdate.EntranceBoundaryID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(EntranceBoundaryID_intComboBox.SelectedValue, TypeCode.Int32);
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

                TrafficEntityUpdate.TrafficTypeID_int = 2;


                string trafficCondition = "[Traffic_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "' AND [Traffic_T].[SerialPlate_nvc]='" + SerialPlate_nvcTextBox.Text + "'";
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(trafficCondition);//HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint, TrafficKey.TrafficID_bint);
                if (TrafficList.Count > 0 && TrafficList != null)
                {
                    if (TrafficList[TrafficList.Count - 1].Out_bit == true)
                    {
                        throw new ApplicationException("این کامیون خارج شده است");
                    }
                }
                HPS.BLL.SettingsBLL.BLLSetting_TFactory settingsFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                SettingKey.SettingID_int = 1001;
                Int32 _TurnHour = 0;
                HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = settingsFactory.GetBy(SettingKey);
                if (SettingEntity != null)
                {
                    _TurnHour = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(SettingEntity.Value_nvc, TypeCode.Int32);
                }


                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BillMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                string BillCondition = "([BillMessage_T].[StartDate_nvc]<='" + BillMessageFactory.ServerJalaliDate + "') AND ([BillMessage_T].[EndDate_nvc]>= '" + BillMessageFactory.ServerJalaliDate + "' ) AND (TrafficType_T.TrafficTypeID_int=2)";
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = BillMessageFactory.GetAllByCondition(BillCondition);
                if (BillMessageList != null && BillMessageList.Count > 0)
                {
                    TrafficEntityUpdate.BillMessageID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(BillMessageList[0].BillMessageID_int, TypeCode.Int32);
                }

                TrafficEntityUpdate.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آیا از ثبت اطلاعات اطمینان دارید؟") == true)
                {
                    TrafficFactory.BeginProc();
                    TrafficFactory.Update(TrafficEntityUpdate, TrafficKey);
                    TrafficFactory.CommitProc();
                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(TrafficEntityUpdate, true, true);
                    frm.ShowDialog();

                    //HPS.Reports.ReportDoc.ForeignCarsReport rpt = new HPS.Reports.ReportDoc.ForeignCarsReport(TrafficEntityUpdate);
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
                    ClearForm(this);
                }

                #endregion
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void Price_decNumericTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PreviousButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.PreviousButton, "Shift+P");
        }

        private void NextButton_MouseHover(object sender, EventArgs e)
        {
            tooltip1.SetToolTip(this.NextButton, "Shift+N");
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.State = enmFormState.Add;
            Trafficnumberlabel.Visible = false;
            TrafficNumbertextBox.Visible = false;
            PriceCorrectButon.Enabled = false;
            Editbutton.Enabled = false;
            FurtherBillButton.Enabled = false;
            _CurrentTrafficNumber = null;
            ClearForm(this);
            NewButton.Enabled = false;
        }

        private void ForeignCarsForm_KeyDown(object sender, KeyEventArgs e)
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

        protected override void ShowForm() 
        {
            FillCombo();
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
            TrafficEntity = TrafficFactory.GetBy(TrafficKey);
            FirstName_nvcTextBox.Text = TrafficEntity.FirstName_nvc;
            LastName_nvcTextBox.Text = TrafficEntity.LastName_nvc;
            NumberPlate_nvcTextBox.Text = TrafficEntity.NumberPlate_nvc;
            //PriceTax_decnumericTextBox.Text = Convert.ToString(TrafficEntity.PriceTax_dec);
            //PriceWithTax_decNumericTextBox.Text = Convert.ToString(TrafficEntity.Price_dec );
            //platecitycode
            SerialPlate_nvcTextBox.Text = TrafficEntity.SerialPlate_nvc;
            if (TrafficEntity.LaderTypeID_int.HasValue == true)
            {
                Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, TrafficEntity.LaderTypeID_int, TypeCode.Int32);
                LaderTypeCode_nvcTextBox.Text = TrafficEntity.LaderTypeCode_nvc;
            }
            System_nvcCombobox.Text = TrafficEntity.System_nvc;
            if (TrafficEntity.NationalityCountryID_int.HasValue == true)
            {
                NationalityCountryID_intComboBox.SelectedValue = TrafficEntity.NationalityCountryID_int;
            }
            if (TrafficEntity.OriginCountryID_int.HasValue == true)
            {
                OriginCountryID_intComboBox.SelectedValue = TrafficEntity.OriginCountryID_int;
                OriginCountryID_intComboBox.SelectedValue = 141;
            }
            if (TrafficEntity.DestinationCountryID_int.HasValue == true)
            {
                DestinationCountryID_intComboBox.SelectedValue = TrafficEntity.DestinationCountryID_int;
            }
            if (TrafficEntity.EntranceBoundaryID_int.HasValue == true)
            {
                EntranceBoundaryID_intComboBox.SelectedValue = TrafficEntity.EntranceBoundaryID_int;
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
    }
}
