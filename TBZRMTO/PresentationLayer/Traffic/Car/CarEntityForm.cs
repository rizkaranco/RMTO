using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Car
{
    public partial class CarEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public CarEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            this.State = enmFormState.Add;
            InitializeComponent();
        }

        public CarEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.CarBLL.BLLCar_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }
        public bool Online = false;
        public CarEntityForm(bool online)
            :base(null)
        {
            this.Online = online;
            InitializeComponent();
        }
        private void CarEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            HPS.BLL.CarBLL.BLLCar_T CarEntity = CarFactory.GetBy((HPS.BLL.CarBLL.BLLCar_TKeys)Key);
            if (CarEntity == null)
            {
                throw new HPS.Exceptions.CarNotFound();
            }
            CarCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.CarCardDate_nvc, TypeCode.String));
            CarCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.CarCardNumber_nvc, TypeCode.String));
            PlateType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.PlateType_nvc, TypeCode.String));
            NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.NumberPlate_nvc, TypeCode.String));
            SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.SerialPlate_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateCityID_intComboBox, CarEntity.PlateCityID_int, TypeCode.Int32);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref PlateColorID_intComboBox, CarEntity.PlateColorID_int, TypeCode.Int32);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CountryID_intComboBox, CarEntity.CountryID_int, TypeCode.Int32);
            CountryCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.CountryCode_nvc, TypeCode.String));
            YearType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.YearType_nvc, TypeCode.String));
            ProductionYear_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.ProductionYear_int, TypeCode.Int32).ToString();
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LaderTypeID_intComboBox, CarEntity.LaderTypeID_int, TypeCode.Int32);
            Active_bit.Checked = Convert.ToBoolean(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.Active_bit, TypeCode.Boolean));

            if (LaderTypeID_intComboBox.SelectedValue != null)
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                LaderTypeKey.LaderTypeID_int = (Int32?)LaderTypeID_intComboBox.SelectedValue;
                HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                if (LaderTypeEntity.LaderTypeID_int != 0)
                {
                    LaderTypeCode_nvcTextBox.Text = LaderTypeEntity.LaderTypeCode_nvc;
                }
            }
            SystemCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.SystemCode_nvc, TypeCode.String));
            System_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.System_nvc, TypeCode.String));
            Capacity_fltNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.Capacity_flt, TypeCode.Double).ToString();
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionGroupID_intComboBox, CarEntity.InfractionGroupID_int, TypeCode.Int32);
            InsertDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.InsertDate_nvc, TypeCode.String));
            UpdateDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.UpdateDate_nvc, TypeCode.String));
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.Active_bit, TypeCode.Boolean);
            Deleted_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(CarEntity.Deleted_bit, TypeCode.Boolean);

        }

        protected override void Insert()
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            try
            {
                HPS.BLL.CarBLL.BLLCar_T CarEntity = new HPS.BLL.CarBLL.BLLCar_T();
                CarEntity.CarCardDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarCardDate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.CarCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.PlateType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateType_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.PlateCityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.PlateColorID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateColorID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.CountryID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(CountryID_intComboBox.SelectedValue, TypeCode.Int32);

                HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
                HPS.BLL.CountryBLL.BLLCountry_TKeys CountryKey = new HPS.BLL.CountryBLL.BLLCountry_TKeys();
                CountryKey.CountryID_int = (Int32?)CountryID_intComboBox.SelectedValue;
                HPS.BLL.CountryBLL.BLLCountry_T countryEntity = CountryFactory.GetBy(CountryKey);
                if (countryEntity.CountryID_int != 0)
                {
                    CarEntity.Country_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(countryEntity.Country_nvc, TypeCode.String).ToString();
                    CarEntity.CountryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(countryEntity.CountryCode_nvc, TypeCode.String).ToString();

                }
                CarEntity.YearType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(YearType_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.ProductionYear_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ProductionYear_intNumericTextBox.NumericText, TypeCode.Int32);
                CarEntity.LaderTypeID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.SystemCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SystemCode_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.System_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.Capacity_flt = (Nullable<Double>)Hepsa.Core.Common.PersentationController.GetEntityValue(Capacity_fltNumericTextBox.NumericText, TypeCode.Double);
                CarEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.InsertDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsertDate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.UpdateDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UpdateDate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.Active_bit = Active_bitCheckBox.Checked;
                CarEntity.Deleted_bit = Deleted_bitCheckBox.Checked;
                CarEntity.Active_bit = Active_bit.Checked;
                CarFactory.BeginProc();
                CarFactory.Insert(CarEntity);
                CarFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CarID_int, TypeCode.Int32);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarCardDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CarCardDate_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CarCardNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.PlateType_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.NumberPlate_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.SerialPlate_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateCityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.PlateCityID_int, TypeCode.Int32);
                    dr["PlateCityID_intPlateCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PlateCityID_intComboBox);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateColorID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.PlateColorID_int, TypeCode.Int32);
                    dr["PlateColorID_intColor_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PlateColorID_intComboBox);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.CountryID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CountryID_int, TypeCode.Int32);
                    dr["CountryID_intCountry_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CountryID_intComboBox);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.CountryCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CountryCode_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.Country_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Country_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.YearType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.YearType_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.ProductionYear_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.ProductionYear_int, TypeCode.Int32);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.LaderTypeID_int, TypeCode.Int32);
                    dr["LaderTypeID_intLaderType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderTypeID_intComboBox);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.LaderTypeCode_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.SystemCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.SystemCode_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.System_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.System_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.Capacity_flt.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Capacity_flt, TypeCode.Double);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.InfractionGroupID_int, TypeCode.Int32);
                    dr["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.InsertDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.InsertDate_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.UpdateDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.UpdateDate_nvc, TypeCode.String);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Active_bit, TypeCode.Boolean);
                    dr[HPS.BLL.CarBLL.BLLCar_T.Car_TField.Deleted_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Deleted_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                CarFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            try
            {
                HPS.BLL.CarBLL.BLLCar_T CarEntity = new HPS.BLL.CarBLL.BLLCar_T();
                CarEntity.CarCardDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarCardDate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.CarCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.PlateType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateType_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.PlateCityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.PlateColorID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(PlateColorID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.CountryID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(CountryID_intComboBox.SelectedValue, TypeCode.Int32);
                HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
                HPS.BLL.CountryBLL.BLLCountry_TKeys CountryKey = new HPS.BLL.CountryBLL.BLLCountry_TKeys();
                CountryKey.CountryID_int = (Int32?)CountryID_intComboBox.SelectedValue;
                countryEntity = CountryFactory.GetBy(CountryKey);
                if (countryEntity != null && countryEntity.CountryID_int != 0)
                {
                    CarEntity.Country_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(countryEntity.Country_nvc, TypeCode.String).ToString();
                    CarEntity.CountryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(countryEntity.CountryCode_nvc, TypeCode.String).ToString();
                }
                else
                {
                    CountryKey.CountryID_int = 82;
                    countryEntity = CountryFactory.GetBy(CountryKey);

                    CarEntity.Country_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(countryEntity.Country_nvc, TypeCode.String).ToString();
                    CarEntity.CountryCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(countryEntity.CountryCode_nvc, TypeCode.String).ToString();
                }
                CarEntity.YearType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(YearType_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.ProductionYear_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ProductionYear_intNumericTextBox.NumericText, TypeCode.Int32);
                CarEntity.LaderTypeID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.LaderTypeCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeCode_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.SystemCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SystemCode_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.System_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(System_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.Capacity_flt = (Nullable<Double>)Hepsa.Core.Common.PersentationController.GetEntityValue(Capacity_fltNumericTextBox.NumericText, TypeCode.Double);
                CarEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                CarEntity.InsertDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsertDate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.UpdateDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UpdateDate_nvcTextBox.Text, TypeCode.String).ToString();
                CarEntity.Active_bit = Active_bitCheckBox.Checked;
                CarEntity.Deleted_bit = Deleted_bitCheckBox.Checked;
                CarEntity.Active_bit = Active_bit.Checked;

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    CarFactory.BeginProc();
                    CarFactory.Update(CarEntity, (HPS.BLL.CarBLL.BLLCar_TKeys)Key);
                    CarFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarID_int.ToString() + "='" + ((HPS.BLL.CarBLL.BLLCar_TKeys)Key).CarID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarCardDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CarCardDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CarCardNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.PlateType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.NumberPlate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.SerialPlate_nvc, TypeCode.String);
                            dr[0]["PlateCityID_intPlateCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PlateCityID_intComboBox);
                            dr[0]["PlateColorID_intColor_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(PlateColorID_intComboBox);
                            dr[0]["CountryID_intCountry_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CountryID_intComboBox);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.CountryCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.CountryCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.Country_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Country_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.YearType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.YearType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.ProductionYear_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.ProductionYear_int, TypeCode.Int32);
                            dr[0]["LaderTypeID_intLaderType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LaderTypeID_intComboBox);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.LaderTypeCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.SystemCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.SystemCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.System_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.System_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.Capacity_flt.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Capacity_flt, TypeCode.Double);
                            dr[0]["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.InsertDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.InsertDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.UpdateDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.UpdateDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Active_bit, TypeCode.Boolean);
                            dr[0][HPS.BLL.CarBLL.BLLCar_T.Car_TField.Deleted_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(CarEntity.Deleted_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                CarFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    CarFactory.BeginProc();
                    CarFactory.Delete((HPS.BLL.CarBLL.BLLCar_TKeys)Key);
                    CarFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarID_int.ToString() + "='" + ((HPS.BLL.CarBLL.BLLCar_TKeys)Key).CarID_int.ToString() + "'");
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
                CarFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityID_intFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                DataTable PlateCityID_intDataTable = new DataTable();
                PlateCityID_intFactory.GetAll(ref PlateCityID_intDataTable);
                this.PlateCityID_intComboBox.DisplayMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCity_nvc.ToString();
                this.PlateCityID_intComboBox.ValueMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString();
                this.PlateCityID_intComboBox.DataSource = PlateCityID_intDataTable;
                this.PlateCityID_intComboBox.SelectedIndex = -1;

                HPS.BLL.ColorBLL.BLLColor_TFactory PlateColorID_intFactory = new HPS.BLL.ColorBLL.BLLColor_TFactory();
                DataTable PlateColorID_intDataTable = new DataTable();
                PlateColorID_intFactory.GetAll(ref PlateColorID_intDataTable);
                this.PlateColorID_intComboBox.DisplayMember = HPS.BLL.ColorBLL.BLLColor_T.Color_TField.Color_nvc.ToString();
                this.PlateColorID_intComboBox.ValueMember = HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorID_int.ToString();
                this.PlateColorID_intComboBox.DataSource = PlateColorID_intDataTable;
                this.PlateColorID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CountryBLL.BLLCountry_TFactory CountryID_intFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
                DataTable CountryID_intDataTable = new DataTable();
                CountryID_intFactory.GetAll(ref CountryID_intDataTable);
                this.CountryID_intComboBox.DisplayMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString();
                this.CountryID_intComboBox.ValueMember = HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString();
                this.CountryID_intComboBox.DataSource = CountryID_intDataTable;
                this.CountryID_intComboBox.SelectedIndex = -1;

                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeID_intFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                DataTable LaderTypeID_intDataTable = new DataTable();
                LaderTypeID_intFactory.GetAll(ref LaderTypeID_intDataTable);
                this.LaderTypeID_intComboBox.DisplayMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString();
                this.LaderTypeID_intComboBox.ValueMember = HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString();
                this.LaderTypeID_intComboBox.DataSource = LaderTypeID_intDataTable;
                this.LaderTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupID_intFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
                DataTable InfractionGroupID_intDataTable = new DataTable();
                InfractionGroupID_intFactory.GetAll(ref InfractionGroupID_intDataTable);
                this.InfractionGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString();
                this.InfractionGroupID_intComboBox.ValueMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.DataSource = InfractionGroupID_intDataTable;
                this.InfractionGroupID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PlateCityID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.PlateCity.PlateCityEntityForm frm = new HPS.Present.PlateCity.PlateCityEntityForm((DataTable)PlateCityID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void PlateColorID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Color.ColorEntityForm frm = new HPS.Present.Color.ColorEntityForm((DataTable)PlateColorID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void CountryID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Country.CountryEntityForm frm = new HPS.Present.Country.CountryEntityForm((DataTable)CountryID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void LaderTypeID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.LaderType.LaderTypeEntityForm frm = new HPS.Present.LaderType.LaderTypeEntityForm((DataTable)LaderTypeID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void InfractionGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionGroup.InfractionGroupEntityForm frm = new HPS.Present.InfractionGroup.InfractionGroupEntityForm((DataTable)InfractionGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void LaderTypeID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                LaderTypeKey.LaderTypeID_int = (Int32?)LaderTypeID_intComboBox.SelectedValue;
                HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);
                if (LaderTypeEntity.LaderTypeID_int != 0)
                {
                    LaderTypeCode_nvcTextBox.Text = LaderTypeEntity.LaderTypeCode_nvc;
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        HPS.BLL.CountryBLL.BLLCountry_T countryEntity = null;
        private void CountryID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HPS.BLL.CountryBLL.BLLCountry_TFactory CountryFactory = new HPS.BLL.CountryBLL.BLLCountry_TFactory();
            HPS.BLL.CountryBLL.BLLCountry_TKeys CountryKey = new HPS.BLL.CountryBLL.BLLCountry_TKeys();
            CountryKey.CountryID_int = (Int32?)CountryID_intComboBox.SelectedValue;
            countryEntity = CountryFactory.GetBy(CountryKey);
            if (countryEntity != null && countryEntity.CountryID_int != 0)
            {

                CountryCode_nvcTextBox.Text = countryEntity.CountryCode_nvc;
            }

        }

        private void CarCardNumber_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Online)
            {

                try
                {
                    LoadDriverOnlineInformation("", CarCardNumber_nvcTextBox.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void LoadDriverOnlineInformation(string DriverCardNumber, string CarCardNumber)
        {
            if (string.IsNullOrEmpty(DriverCardNumber) || string.IsNullOrEmpty(CarCardNumber))
            {
                throw new ApplicationException("شماره کارت هوشمند خودرو  نامعتبر است");
            }

            List<HPS.BLL.DriverBLL.BLLDriver_T> DriverFactory = (new HPS.BLL.DriverBLL.BLLDriver_TFactory().GetAllBy(BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber));
            HPS.BLL.DriverBLL.BLLDriver_T driverEntity = new BLL.DriverBLL.BLLDriver_T();
            object[] CarObject = null;
            var webService = new CheckOnlineRefrence.OnlineInformationChecking();
            //var webService = new WebReference3.OnlineInformationChecking();
            var RecivedObject = webService.GetInformation(DriverCardNumber, CarCardNumber);
            if (RecivedObject != null)
            {
                //driverObject = (object[])RecivedObject[0];
                CarObject = (object[])RecivedObject[1];
            }


            if (CarObject != null)
            {
                if (CarObject[0].ToString() == "0")
                {
                    string ErroeMessage = string.Format("کارت هوشمند خودرو به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. ", CarCardNumber);
                    throw new ApplicationException(ErroeMessage);
                }
                NumberPlate_nvcTextBox.Text = CarObject[1].ToString();
                SerialPlate_nvcTextBox.Text = CarObject[2].ToString();
            }
            else
            {
                string ErroeMessage = string.Format("کارت هوشمند خودرو به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. ", DriverCardNumber);
                Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
            }


        }




    }
}