using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.TrafficDAL
{
    class DALTraffic_T : DataLayerBase
    {

        public DALTraffic_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.TrafficBLL.BLLTraffic_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Output;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter TurnHour_int = new SqlParameter();
                TurnHour_int.ParameterName = "@TurnHour_int";
                TurnHour_int.SqlDbType = SqlDbType.Int;
                TurnHour_int.Direction = ParameterDirection.Input;
                TurnHour_int.IsNullable = true;
                if (businessObject.TurnHour_int.HasValue == false)
                {
                    TurnHour_int.Value = DBNull.Value;
                }
                else
                {
                    TurnHour_int.Value = businessObject.TurnHour_int;
                }
                this.Command.Parameters.Add(TurnHour_int);

                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.Direction = ParameterDirection.Output;
                TrafficNumber_bint.IsNullable = true;
                if (businessObject.In_bit)
                {
                    TrafficNumber_bint.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(TrafficNumber_bint);

                SqlParameter OutTrafficNumber_bint = new SqlParameter();
                OutTrafficNumber_bint.ParameterName = "@OutTrafficNumber_bint";
                OutTrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                OutTrafficNumber_bint.Direction = ParameterDirection.Input;
                OutTrafficNumber_bint.IsNullable = true;
                if (businessObject.In_bit)
                {
                    OutTrafficNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    OutTrafficNumber_bint.Value = businessObject.TrafficNumber_bint;
                }
                this.Command.Parameters.Add(OutTrafficNumber_bint);

                SqlParameter TurnNumber_bint = new SqlParameter();
                TurnNumber_bint.ParameterName = "@TurnNumber_bint";
                TurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                TurnNumber_bint.Direction = ParameterDirection.Input;
                TurnNumber_bint.IsNullable = true;
                if (businessObject.TurnNumber_bint.HasValue == false)
                {
                    TurnNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    TurnNumber_bint.Value = businessObject.TurnNumber_bint;
                }
                this.Command.Parameters.Add(TurnNumber_bint);

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = true;
                if (businessObject.DriverID_bint.HasValue == false)
                {
                    DriverID_bint.Value = DBNull.Value;
                }
                else
                {
                    DriverID_bint.Value = businessObject.DriverID_bint;
                }
                this.Command.Parameters.Add(DriverID_bint);

                SqlParameter DriverCardDate_nvc = new SqlParameter();
                DriverCardDate_nvc.ParameterName = "@DriverCardDate_nvc";
                DriverCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardDate_nvc.Direction = ParameterDirection.Input;
                DriverCardDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverCardDate_nvc))
                {
                    DriverCardDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverCardDate_nvc.Value = businessObject.DriverCardDate_nvc;
                }
                this.Command.Parameters.Add(DriverCardDate_nvc);

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverCardNumber_nvc))
                {
                    DriverCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
                }
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                SqlParameter DriverType_nvc = new SqlParameter();
                DriverType_nvc.ParameterName = "@DriverType_nvc";
                DriverType_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverType_nvc.Direction = ParameterDirection.Input;
                DriverType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverType_nvc))
                {
                    DriverType_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverType_nvc.Value = businessObject.DriverType_nvc;
                }
                this.Command.Parameters.Add(DriverType_nvc);

                SqlParameter FirstName_nvc = new SqlParameter();
                FirstName_nvc.ParameterName = "@FirstName_nvc";
                FirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvc.Direction = ParameterDirection.Input;
                FirstName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.FirstName_nvc))
                {
                    FirstName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FirstName_nvc.Value = businessObject.FirstName_nvc;
                }
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LastName_nvc))
                {
                    LastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvc.Value = businessObject.LastName_nvc;
                }
                this.Command.Parameters.Add(LastName_nvc);

                SqlParameter InsuranceNumber_nvc = new SqlParameter();
                InsuranceNumber_nvc.ParameterName = "@InsuranceNumber_nvc";
                InsuranceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceNumber_nvc.Direction = ParameterDirection.Input;
                InsuranceNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.InsuranceNumber_nvc))
                {
                    InsuranceNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    InsuranceNumber_nvc.Value = businessObject.InsuranceNumber_nvc;
                }
                this.Command.Parameters.Add(InsuranceNumber_nvc);

                SqlParameter CityID_int = new SqlParameter();
                CityID_int.ParameterName = "@CityID_int";
                CityID_int.SqlDbType = SqlDbType.Int;
                CityID_int.Direction = ParameterDirection.Input;
                CityID_int.IsNullable = true;
                if (businessObject.CityID_int.HasValue == false)
                {
                    CityID_int.Value = DBNull.Value;
                }
                else
                {
                    CityID_int.Value = businessObject.CityID_int;
                }
                this.Command.Parameters.Add(CityID_int);

                SqlParameter CityCode_nvc = new SqlParameter();
                CityCode_nvc.ParameterName = "@CityCode_nvc";
                CityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CityCode_nvc.Direction = ParameterDirection.Input;
                CityCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CityCode_nvc))
                {
                    CityCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CityCode_nvc.Value = businessObject.CityCode_nvc;
                }
                this.Command.Parameters.Add(CityCode_nvc);

                SqlParameter licenceNumber_int = new SqlParameter();
                licenceNumber_int.ParameterName = "@licenceNumber_int";
                licenceNumber_int.SqlDbType = SqlDbType.BigInt;
                licenceNumber_int.Direction = ParameterDirection.Input;
                licenceNumber_int.IsNullable = true;
                if (businessObject.licenceNumber_int.HasValue == false)
                {
                    licenceNumber_int.Value = DBNull.Value;
                }
                else
                {
                    licenceNumber_int.Value = businessObject.licenceNumber_int;
                }
                this.Command.Parameters.Add(licenceNumber_int);

                SqlParameter LicenceCityID_int = new SqlParameter();
                LicenceCityID_int.ParameterName = "@LicenceCityID_int";
                LicenceCityID_int.SqlDbType = SqlDbType.Int;
                LicenceCityID_int.Direction = ParameterDirection.Input;
                LicenceCityID_int.IsNullable = true;
                if (businessObject.LicenceCityID_int.HasValue == false)
                {
                    LicenceCityID_int.Value = DBNull.Value;
                }
                else
                {
                    LicenceCityID_int.Value = businessObject.LicenceCityID_int;
                }
                this.Command.Parameters.Add(LicenceCityID_int);

                SqlParameter LicenceType_nvc = new SqlParameter();
                LicenceType_nvc.ParameterName = "@LicenceType_nvc";
                LicenceType_nvc.SqlDbType = SqlDbType.NVarChar;
                LicenceType_nvc.Direction = ParameterDirection.Input;
                LicenceType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LicenceType_nvc))
                {
                    LicenceType_nvc.Value = DBNull.Value;
                }
                else
                {
                    LicenceType_nvc.Value = businessObject.LicenceType_nvc;
                }
                this.Command.Parameters.Add(LicenceType_nvc);

                SqlParameter LiceniceDate_nvc = new SqlParameter();
                LiceniceDate_nvc.ParameterName = "@LiceniceDate_nvc";
                LiceniceDate_nvc.SqlDbType = SqlDbType.NVarChar;
                LiceniceDate_nvc.Direction = ParameterDirection.Input;
                LiceniceDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LiceniceDate_nvc))
                {
                    LiceniceDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    LiceniceDate_nvc.Value = businessObject.LiceniceDate_nvc;
                }
                this.Command.Parameters.Add(LiceniceDate_nvc);

                SqlParameter ActivityScope_nvc = new SqlParameter();
                ActivityScope_nvc.ParameterName = "@ActivityScope_nvc";
                ActivityScope_nvc.SqlDbType = SqlDbType.NVarChar;
                ActivityScope_nvc.Direction = ParameterDirection.Input;
                ActivityScope_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ActivityScope_nvc))
                {
                    ActivityScope_nvc.Value = DBNull.Value;
                }
                else
                {
                    ActivityScope_nvc.Value = businessObject.ActivityScope_nvc;
                }
                this.Command.Parameters.Add(ActivityScope_nvc);

                SqlParameter NationalCode_int = new SqlParameter();
                NationalCode_int.ParameterName = "@NationalCode_int";
                NationalCode_int.SqlDbType = SqlDbType.BigInt;
                NationalCode_int.Direction = ParameterDirection.Input;
                NationalCode_int.IsNullable = true;
                if (businessObject.NationalCode_int.HasValue == false)
                {
                    NationalCode_int.Value = DBNull.Value;
                }
                else
                {
                    NationalCode_int.Value = businessObject.NationalCode_int;
                }
                this.Command.Parameters.Add(NationalCode_int);

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = true;
                if (businessObject.CarID_int.HasValue == false)
                {
                    CarID_int.Value = DBNull.Value;
                }
                else
                {
                    CarID_int.Value = businessObject.CarID_int;
                }
                this.Command.Parameters.Add(CarID_int);

                SqlParameter CarCardDate_nvc = new SqlParameter();
                CarCardDate_nvc.ParameterName = "@CarCardDate_nvc";
                CarCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardDate_nvc.Direction = ParameterDirection.Input;
                CarCardDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CarCardDate_nvc))
                {
                    CarCardDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    CarCardDate_nvc.Value = businessObject.CarCardDate_nvc;
                }
                this.Command.Parameters.Add(CarCardDate_nvc);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CarCardNumber_nvc))
                {
                    CarCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                }
                this.Command.Parameters.Add(CarCardNumber_nvc);

                SqlParameter PlateType_nvc = new SqlParameter();
                PlateType_nvc.ParameterName = "@PlateType_nvc";
                PlateType_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateType_nvc.Direction = ParameterDirection.Input;
                PlateType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.PlateType_nvc))
                {
                    PlateType_nvc.Value = DBNull.Value;
                }
                else
                {
                    PlateType_nvc.Value = businessObject.PlateType_nvc;
                }
                this.Command.Parameters.Add(PlateType_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = false;
                NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SerialPlate_nvc))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = businessObject.SerialPlate_nvc;
                }
                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter PlateCityID_int = new SqlParameter();
                PlateCityID_int.ParameterName = "@PlateCityID_int";
                PlateCityID_int.SqlDbType = SqlDbType.Int;
                PlateCityID_int.Direction = ParameterDirection.Input;
                PlateCityID_int.IsNullable = true;
                if (businessObject.PlateCityID_int.HasValue == false)
                {
                    PlateCityID_int.Value = DBNull.Value;
                }
                else
                {
                    PlateCityID_int.Value = businessObject.PlateCityID_int;
                }
                this.Command.Parameters.Add(PlateCityID_int);

                SqlParameter PlateColorID_int = new SqlParameter();
                PlateColorID_int.ParameterName = "@PlateColorID_int";
                PlateColorID_int.SqlDbType = SqlDbType.Int;
                PlateColorID_int.Direction = ParameterDirection.Input;
                PlateColorID_int.IsNullable = true;
                if (businessObject.PlateColorID_int.HasValue == false)
                {
                    PlateColorID_int.Value = DBNull.Value;
                }
                else
                {
                    PlateColorID_int.Value = businessObject.PlateColorID_int;
                }
                this.Command.Parameters.Add(PlateColorID_int);

                SqlParameter CountryID_int = new SqlParameter();
                CountryID_int.ParameterName = "@CountryID_int";
                CountryID_int.SqlDbType = SqlDbType.Int;
                CountryID_int.Direction = ParameterDirection.Input;
                CountryID_int.IsNullable = true;
                if (businessObject.CountryID_int.HasValue == false)
                {
                    CountryID_int.Value = DBNull.Value;
                }
                else
                {
                    CountryID_int.Value = businessObject.CountryID_int;
                }
                this.Command.Parameters.Add(CountryID_int);

                SqlParameter CountryCode_nvc = new SqlParameter();
                CountryCode_nvc.ParameterName = "@CountryCode_nvc";
                CountryCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CountryCode_nvc.Direction = ParameterDirection.Input;
                CountryCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CountryCode_nvc))
                {
                    CountryCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CountryCode_nvc.Value = businessObject.CountryCode_nvc;
                }
                this.Command.Parameters.Add(CountryCode_nvc);

                SqlParameter Country_nvc = new SqlParameter();
                Country_nvc.ParameterName = "@Country_nvc";
                Country_nvc.SqlDbType = SqlDbType.NVarChar;
                Country_nvc.Direction = ParameterDirection.Input;
                Country_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Country_nvc))
                {
                    Country_nvc.Value = DBNull.Value;
                }
                else
                {
                    Country_nvc.Value = businessObject.Country_nvc;
                }
                this.Command.Parameters.Add(Country_nvc);

                SqlParameter YearType_nvc = new SqlParameter();
                YearType_nvc.ParameterName = "@YearType_nvc";
                YearType_nvc.SqlDbType = SqlDbType.NVarChar;
                YearType_nvc.Direction = ParameterDirection.Input;
                YearType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.YearType_nvc))
                {
                    YearType_nvc.Value = DBNull.Value;
                }
                else
                {
                    YearType_nvc.Value = businessObject.YearType_nvc;
                }
                this.Command.Parameters.Add(YearType_nvc);

                SqlParameter ProductionYear_int = new SqlParameter();
                ProductionYear_int.ParameterName = "@ProductionYear_int";
                ProductionYear_int.SqlDbType = SqlDbType.Int;
                ProductionYear_int.Direction = ParameterDirection.Input;
                ProductionYear_int.IsNullable = true;
                if (businessObject.ProductionYear_int.HasValue == false)
                {
                    ProductionYear_int.Value = DBNull.Value;
                }
                else
                {
                    ProductionYear_int.Value = businessObject.ProductionYear_int;
                }
                this.Command.Parameters.Add(ProductionYear_int);

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = true;
                if (businessObject.LaderTypeID_int.HasValue == false)
                {
                    LaderTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeID_int.Value = businessObject.LaderTypeID_int;
                }
                this.Command.Parameters.Add(LaderTypeID_int);

                SqlParameter LaderTypeCode_nvc = new SqlParameter();
                LaderTypeCode_nvc.ParameterName = "@LaderTypeCode_nvc";
                LaderTypeCode_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeCode_nvc.Direction = ParameterDirection.Input;
                LaderTypeCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LaderTypeCode_nvc))
                {
                    LaderTypeCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeCode_nvc.Value = businessObject.LaderTypeCode_nvc;
                }
                this.Command.Parameters.Add(LaderTypeCode_nvc);

                SqlParameter SystemCode_nvc = new SqlParameter();
                SystemCode_nvc.ParameterName = "@SystemCode_nvc";
                SystemCode_nvc.SqlDbType = SqlDbType.NVarChar;
                SystemCode_nvc.Direction = ParameterDirection.Input;
                SystemCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SystemCode_nvc))
                {
                    SystemCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    SystemCode_nvc.Value = businessObject.SystemCode_nvc;
                }
                this.Command.Parameters.Add(SystemCode_nvc);

                SqlParameter System_nvc = new SqlParameter();
                System_nvc.ParameterName = "@System_nvc";
                System_nvc.SqlDbType = SqlDbType.NVarChar;
                System_nvc.Direction = ParameterDirection.Input;
                System_nvc.IsNullable = false;
                System_nvc.Value = businessObject.System_nvc;
                this.Command.Parameters.Add(System_nvc);

                SqlParameter Capacity_flt = new SqlParameter();
                Capacity_flt.ParameterName = "@Capacity_flt";
                Capacity_flt.SqlDbType = SqlDbType.Float;
                Capacity_flt.Direction = ParameterDirection.Input;
                Capacity_flt.IsNullable = true;
                if (businessObject.Capacity_flt.HasValue == false)
                {
                    Capacity_flt.Value = DBNull.Value;
                }
                else
                {
                    Capacity_flt.Value = businessObject.Capacity_flt;
                }
                this.Command.Parameters.Add(Capacity_flt);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObject.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);

                SqlParameter AllowableHour_int = new SqlParameter();
                AllowableHour_int.ParameterName = "@AllowableHour_int";
                AllowableHour_int.SqlDbType = SqlDbType.Int;
                AllowableHour_int.Direction = ParameterDirection.Input;
                AllowableHour_int.IsNullable = false;
                AllowableHour_int.Value = businessObject.AllowableHour_int;
                this.Command.Parameters.Add(AllowableHour_int);

                SqlParameter ExtraHour_int = new SqlParameter();
                ExtraHour_int.ParameterName = "@ExtraHour_int";
                ExtraHour_int.SqlDbType = SqlDbType.Int;
                ExtraHour_int.Direction = ParameterDirection.Input;
                ExtraHour_int.IsNullable = false;
                ExtraHour_int.Value = businessObject.ExtraHour_int;
                this.Command.Parameters.Add(ExtraHour_int);

                SqlParameter ExtraHourFee_dec = new SqlParameter();
                ExtraHourFee_dec.ParameterName = "@ExtraHourFee_dec";
                ExtraHourFee_dec.SqlDbType = SqlDbType.Decimal;
                ExtraHourFee_dec.Direction = ParameterDirection.Input;
                ExtraHourFee_dec.IsNullable = false;
                ExtraHourFee_dec.Value = businessObject.ExtraHourFee_dec;
                this.Command.Parameters.Add(ExtraHourFee_dec);

                SqlParameter Fee_dec = new SqlParameter();
                Fee_dec.ParameterName = "@Fee_dec";
                Fee_dec.SqlDbType = SqlDbType.Decimal;
                Fee_dec.Direction = ParameterDirection.Input;
                Fee_dec.IsNullable = false;
                Fee_dec.Value = businessObject.Fee_dec;
                this.Command.Parameters.Add(Fee_dec);

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObject.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);

                SqlParameter Computer_nvc = new SqlParameter();
                Computer_nvc.ParameterName = "@Computer_nvc";
                Computer_nvc.SqlDbType = SqlDbType.NVarChar;
                Computer_nvc.Direction = ParameterDirection.Input;
                Computer_nvc.IsNullable = false;
                Computer_nvc.Value = businessObject.Computer_nvc;
                this.Command.Parameters.Add(Computer_nvc);

                SqlParameter IPAddress_nvc = new SqlParameter();
                IPAddress_nvc.ParameterName = "@IPAddress_nvc";
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                IPAddress_nvc.Direction = ParameterDirection.Input;
                IPAddress_nvc.IsNullable = false;
                IPAddress_nvc.Value = businessObject.IPAddress_nvc;
                this.Command.Parameters.Add(IPAddress_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter TrafficTypeID_int = new SqlParameter();
                TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_int.SqlDbType = SqlDbType.Int;
                TrafficTypeID_int.Direction = ParameterDirection.Input;
                TrafficTypeID_int.IsNullable = true;
                if (businessObject.TrafficTypeID_int.HasValue == false)
                {
                    TrafficTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    TrafficTypeID_int.Value = businessObject.TrafficTypeID_int;
                }
                this.Command.Parameters.Add(TrafficTypeID_int);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = false;
                Date_nvc.Value = businessObject.Date_nvc;
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Time_nvc = new SqlParameter();
                Time_nvc.ParameterName = "@Time_nvc";
                Time_nvc.SqlDbType = SqlDbType.NVarChar;
                Time_nvc.Direction = ParameterDirection.Input;
                Time_nvc.IsNullable = false;
                Time_nvc.Value = businessObject.Time_nvc;
                this.Command.Parameters.Add(Time_nvc);

                SqlParameter WithFlat_bit = new SqlParameter();
                WithFlat_bit.ParameterName = "@WithFlat_bit";
                WithFlat_bit.SqlDbType = SqlDbType.Bit;
                WithFlat_bit.Direction = ParameterDirection.Input;
                WithFlat_bit.IsNullable = false;
                WithFlat_bit.Value = businessObject.WithFlat_bit;
                this.Command.Parameters.Add(WithFlat_bit);

                SqlParameter NationalityCountryID_int = new SqlParameter();
                NationalityCountryID_int.ParameterName = "@NationalityCountryID_int";
                NationalityCountryID_int.SqlDbType = SqlDbType.Int;
                NationalityCountryID_int.Direction = ParameterDirection.Input;
                NationalityCountryID_int.IsNullable = true;
                if (businessObject.NationalityCountryID_int.HasValue == false)
                {
                    NationalityCountryID_int.Value = DBNull.Value;
                }
                else
                {
                    NationalityCountryID_int.Value = businessObject.NationalityCountryID_int;
                }
                this.Command.Parameters.Add(NationalityCountryID_int);

                SqlParameter OriginCountryID_int = new SqlParameter();
                OriginCountryID_int.ParameterName = "@OriginCountryID_int";
                OriginCountryID_int.SqlDbType = SqlDbType.Int;
                OriginCountryID_int.Direction = ParameterDirection.Input;
                OriginCountryID_int.IsNullable = true;
                if (businessObject.OriginCountryID_int.HasValue == false)
                {
                    OriginCountryID_int.Value = DBNull.Value;
                }
                else
                {
                    OriginCountryID_int.Value = businessObject.OriginCountryID_int;
                }
                this.Command.Parameters.Add(OriginCountryID_int);

                SqlParameter DestinationCountryID_int = new SqlParameter();
                DestinationCountryID_int.ParameterName = "@DestinationCountryID_int";
                DestinationCountryID_int.SqlDbType = SqlDbType.Int;
                DestinationCountryID_int.Direction = ParameterDirection.Input;
                DestinationCountryID_int.IsNullable = true;
                if (businessObject.DestinationCountryID_int.HasValue == false)
                {
                    DestinationCountryID_int.Value = DBNull.Value;
                }
                else
                {
                    DestinationCountryID_int.Value = businessObject.DestinationCountryID_int;
                }
                this.Command.Parameters.Add(DestinationCountryID_int);

                SqlParameter EntranceBoundaryID_int = new SqlParameter();
                EntranceBoundaryID_int.ParameterName = "@EntranceBoundaryID_int";
                EntranceBoundaryID_int.SqlDbType = SqlDbType.Int;
                EntranceBoundaryID_int.Direction = ParameterDirection.Input;
                EntranceBoundaryID_int.IsNullable = true;
                if (businessObject.EntranceBoundaryID_int.HasValue == false)
                {
                    EntranceBoundaryID_int.Value = DBNull.Value;
                }
                else
                {
                    EntranceBoundaryID_int.Value = businessObject.EntranceBoundaryID_int;
                }
                this.Command.Parameters.Add(EntranceBoundaryID_int);

                SqlParameter In_bit = new SqlParameter();
                In_bit.ParameterName = "@In_bit";
                In_bit.SqlDbType = SqlDbType.Bit;
                In_bit.Direction = ParameterDirection.Input;
                In_bit.IsNullable = false;
                In_bit.Value = businessObject.In_bit;
                this.Command.Parameters.Add(In_bit);

                SqlParameter Out_bit = new SqlParameter();
                Out_bit.ParameterName = "@Out_bit";
                Out_bit.SqlDbType = SqlDbType.Bit;
                Out_bit.Direction = ParameterDirection.Input;
                Out_bit.IsNullable = false;
                Out_bit.Value = businessObject.Out_bit;
                this.Command.Parameters.Add(Out_bit);

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = true;
                if (businessObject.BillMessageID_int.HasValue == false)
                {
                    BillMessageID_int.Value = DBNull.Value;
                }
                else
                {
                    BillMessageID_int.Value = businessObject.BillMessageID_int;
                }
                this.Command.Parameters.Add(BillMessageID_int);

                SqlParameter Price_dec = new SqlParameter();
                Price_dec.ParameterName = "@Price_dec";
                Price_dec.SqlDbType = SqlDbType.Decimal;
                Price_dec.Direction = ParameterDirection.Input;
                Price_dec.IsNullable = true;
                if (businessObject.Price_dec.HasValue == false)
                {
                    Price_dec.Value = DBNull.Value;
                }
                else
                {
                    Price_dec.Value = businessObject.Price_dec;
                }
                this.Command.Parameters.Add(Price_dec);

                SqlParameter Hourse_bit = new SqlParameter();
                Hourse_bit.ParameterName = "@Hourse_bit";
                Hourse_bit.SqlDbType = SqlDbType.Bit;
                Hourse_bit.Direction = ParameterDirection.Input;
                Hourse_bit.IsNullable = false;
                Hourse_bit.Value = businessObject.Hourse_bit;
                this.Command.Parameters.Add(Hourse_bit);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

                SqlParameter ServiceID_int = new SqlParameter();
                ServiceID_int.ParameterName = "@ServiceID_int";
                ServiceID_int.SqlDbType = SqlDbType.Int;
                ServiceID_int.Direction = ParameterDirection.Input;
                ServiceID_int.IsNullable = false;
                ServiceID_int.Value = businessObject.ServiceID_int;
                this.Command.Parameters.Add(ServiceID_int);

                SqlParameter WithLade_bit = new SqlParameter();
                WithLade_bit.ParameterName = "@WithLade_bit";
                WithLade_bit.SqlDbType = SqlDbType.Bit;
                WithLade_bit.Direction = ParameterDirection.Input;
                WithLade_bit.IsNullable = false;
                WithLade_bit.Value = businessObject.WithLade_bit;
                this.Command.Parameters.Add(WithLade_bit);

                SqlParameter Printed_bit = new SqlParameter();
                Printed_bit.ParameterName = "@Printed_bit";
                Printed_bit.SqlDbType = SqlDbType.Bit;
                Printed_bit.Direction = ParameterDirection.Input;
                Printed_bit.IsNullable = false;
                Printed_bit.Value = businessObject.Printed_bit;
                this.Command.Parameters.Add(Printed_bit);

                SqlParameter TemporaryOut_bit = new SqlParameter();
                TemporaryOut_bit.ParameterName = "@TemporaryOut_bit";
                TemporaryOut_bit.SqlDbType = SqlDbType.Bit;
                TemporaryOut_bit.Direction = ParameterDirection.Input;
                TemporaryOut_bit.IsNullable = false;
                TemporaryOut_bit.Value = businessObject.TemporaryOut_bit;
                this.Command.Parameters.Add(TemporaryOut_bit);

                SqlParameter AcceptedTurnNumber_bint = new SqlParameter();
                AcceptedTurnNumber_bint.ParameterName = "@AcceptedTurnNumber_bint";
                AcceptedTurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                AcceptedTurnNumber_bint.Direction = ParameterDirection.Input;
                AcceptedTurnNumber_bint.IsNullable = true;
                if (businessObject.AcceptedTurnNumber_bint.HasValue == false)
                {
                    AcceptedTurnNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnNumber_bint.Value = businessObject.AcceptedTurnNumber_bint;
                }
                this.Command.Parameters.Add(AcceptedTurnNumber_bint);

                SqlParameter AcceptedTurnComment_nvc = new SqlParameter();
                AcceptedTurnComment_nvc.ParameterName = "@AcceptedTurnComment_nvc";
                AcceptedTurnComment_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTurnComment_nvc.Direction = ParameterDirection.Input;
                AcceptedTurnComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedTurnComment_nvc))
                {
                    AcceptedTurnComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnComment_nvc.Value = businessObject.AcceptedTurnComment_nvc;
                }
                this.Command.Parameters.Add(AcceptedTurnComment_nvc);

                SqlParameter TurnDate_nvc = new SqlParameter();
                TurnDate_nvc.ParameterName = "@TurnDate_nvc";
                TurnDate_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnDate_nvc.Direction = ParameterDirection.Input;
                TurnDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnDate_nvc))
                {
                    TurnDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnDate_nvc.Value = businessObject.TurnDate_nvc;
                }
                this.Command.Parameters.Add(TurnDate_nvc);

                SqlParameter TurnTime_nvc = new SqlParameter();
                TurnTime_nvc.ParameterName = "@TurnTime_nvc";
                TurnTime_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnTime_nvc.Direction = ParameterDirection.Input;
                TurnTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnTime_nvc))
                {
                    TurnTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnTime_nvc.Value = businessObject.TurnTime_nvc;
                }
                this.Command.Parameters.Add(TurnTime_nvc);

                SqlParameter TurnUser_nvc = new SqlParameter();
                TurnUser_nvc.ParameterName = "@TurnUser_nvc";
                TurnUser_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnUser_nvc.Direction = ParameterDirection.Input;
                TurnUser_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnUser_nvc))
                {
                    TurnUser_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnUser_nvc.Value = businessObject.TurnUser_nvc;
                }
                this.Command.Parameters.Add(TurnUser_nvc);

                SqlParameter TurnAccepted_bit = new SqlParameter();
                TurnAccepted_bit.ParameterName = "@TurnAccepted_bit";
                TurnAccepted_bit.SqlDbType = SqlDbType.Bit;
                TurnAccepted_bit.Direction = ParameterDirection.Input;
                TurnAccepted_bit.IsNullable = true;
                if (businessObject.TurnAccepted_bit.HasValue == false)
                {
                    TurnAccepted_bit.Value = DBNull.Value;
                }
                else
                {
                    TurnAccepted_bit.Value = businessObject.TurnAccepted_bit;
                }
                this.Command.Parameters.Add(TurnAccepted_bit);

                SqlParameter CarCardRead_bit = new SqlParameter();
                CarCardRead_bit.ParameterName = "@CarCardRead_bit";
                CarCardRead_bit.SqlDbType = SqlDbType.Bit;
                CarCardRead_bit.Direction = ParameterDirection.Input;
                CarCardRead_bit.IsNullable = false;
                CarCardRead_bit.Value = businessObject.CarCardRead_bit;
                this.Command.Parameters.Add(CarCardRead_bit);

                SqlParameter DriverCardRead_bit = new SqlParameter();
                DriverCardRead_bit.ParameterName = "@DriverCardRead_bit";
                DriverCardRead_bit.SqlDbType = SqlDbType.Bit;
                DriverCardRead_bit.Direction = ParameterDirection.Input;
                DriverCardRead_bit.IsNullable = false;
                DriverCardRead_bit.Value = businessObject.DriverCardRead_bit;
                this.Command.Parameters.Add(DriverCardRead_bit);

                SqlParameter TurnPrinted_bit = new SqlParameter();
                TurnPrinted_bit.ParameterName = "@TurnPrinted_bit";
                TurnPrinted_bit.SqlDbType = SqlDbType.Bit;
                TurnPrinted_bit.Direction = ParameterDirection.Input;
                TurnPrinted_bit.IsNullable = false;
                TurnPrinted_bit.Value = businessObject.TurnPrinted_bit;
                this.Command.Parameters.Add(TurnPrinted_bit);

                SqlParameter DriverMobileNumber_nvc = new SqlParameter();
                DriverMobileNumber_nvc.ParameterName = "@DriverMobileNumber_nvc";
                DriverMobileNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverMobileNumber_nvc.Direction = ParameterDirection.Input;
                DriverMobileNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverMobileNumber_nvc) == false)
                {
                    DriverMobileNumber_nvc.Value = businessObject.DriverMobileNumber_nvc;
                }
                else
                {
                    DriverMobileNumber_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(DriverMobileNumber_nvc);

                SqlParameter Area_bit = new SqlParameter();
                Area_bit.ParameterName = "@Area_bit";
                Area_bit.SqlDbType = SqlDbType.Bit;
                Area_bit.Direction = ParameterDirection.Input;
                Area_bit.IsNullable = false;
                Area_bit.Value = businessObject.Area_bit;
                this.Command.Parameters.Add(Area_bit);

                SqlParameter CarOffline_bit = new SqlParameter();
                CarOffline_bit.ParameterName = "@CarOffline_bit";
                CarOffline_bit.SqlDbType = SqlDbType.Bit;
                CarOffline_bit.Direction = ParameterDirection.Input;
                CarOffline_bit.IsNullable = false;
                CarOffline_bit.Value = businessObject.CarOffline_bit;
                this.Command.Parameters.Add(CarOffline_bit);

                SqlParameter DriverOffline_bit = new SqlParameter();
                DriverOffline_bit.ParameterName = "@DriverOffline_bit";
                DriverOffline_bit.SqlDbType = SqlDbType.Bit;
                DriverOffline_bit.Direction = ParameterDirection.Input;
                DriverOffline_bit.IsNullable = false;
                DriverOffline_bit.Value = businessObject.DriverOffline_bit;
                this.Command.Parameters.Add(DriverOffline_bit);

                SqlParameter CameraPlateNumber_nvc = new SqlParameter();
                CameraPlateNumber_nvc.ParameterName = "@CameraPlateNumber_nvc";
                CameraPlateNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CameraPlateNumber_nvc.Direction = ParameterDirection.Input;
                CameraPlateNumber_nvc.IsNullable = false;
                if (string.IsNullOrEmpty(businessObject.CameraPlateNumber_nvc))
                    CameraPlateNumber_nvc.Value = DBNull.Value;
                else
                    CameraPlateNumber_nvc.Value = businessObject.CameraPlateNumber_nvc;
                this.Command.Parameters.Add(CameraPlateNumber_nvc);

                SqlParameter CameraSerialPlate_int = new SqlParameter();
                CameraSerialPlate_int.ParameterName = "@CameraSerialPlate_int";
                CameraSerialPlate_int.SqlDbType = SqlDbType.Int;
                CameraSerialPlate_int.Direction = ParameterDirection.Input;
                CameraSerialPlate_int.IsNullable = true;
                if (businessObject.CameraSerialPlate_int.HasValue)
                {
                    CameraSerialPlate_int.Value = businessObject.CameraSerialPlate_int;
                }
                else
                {
                    CameraSerialPlate_int.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(CameraSerialPlate_int);

                SqlParameter EditUserName_nvc = new SqlParameter();
                EditUserName_nvc.ParameterName = "@EditUserName_nvc";
                EditUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                EditUserName_nvc.Direction = ParameterDirection.Input;
                EditUserName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.EditUserName_nvc))
                {
                    EditUserName_nvc.Value = DBNull.Value;
                }
                else
                    EditUserName_nvc.Value = businessObject.EditUserName_nvc;
                this.Command.Parameters.Add(EditUserName_nvc);

                SqlParameter EditDate_vc = new SqlParameter();
                EditDate_vc.ParameterName = "@EditDate_vc";
                EditDate_vc.SqlDbType = SqlDbType.NVarChar;
                EditDate_vc.Direction = ParameterDirection.Input;
                EditDate_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.EditDate_vc))
                {
                    EditDate_vc.Value = DBNull.Value;
                }
                else
                    EditDate_vc.Value = businessObject.EditDate_vc;
                this.Command.Parameters.Add(EditDate_vc);

                SqlParameter EditTime_vc = new SqlParameter();
                EditTime_vc.ParameterName = "@EditTime_vc";
                EditTime_vc.SqlDbType = SqlDbType.NVarChar;
                EditTime_vc.Direction = ParameterDirection.Input;
                EditTime_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.EditTime_vc))
                {
                    EditTime_vc.Value = DBNull.Value;
                }
                else
                    EditTime_vc.Value = businessObject.EditTime_vc;
                this.Command.Parameters.Add(EditTime_vc);

                SqlParameter PriceTax_dec = new SqlParameter();
                PriceTax_dec.ParameterName = "@PriceTax_dec";
                PriceTax_dec.SqlDbType = SqlDbType.Decimal;
                PriceTax_dec.Direction = ParameterDirection.Input;
                PriceTax_dec.IsNullable = true;
                if (businessObject.PriceTax_dec.HasValue == false)
                {
                    PriceTax_dec.Value = DBNull.Value;
                }
                else
                {
                    PriceTax_dec.Value = businessObject.PriceTax_dec;
                }
                this.Command.Parameters.Add(PriceTax_dec);

                SqlParameter LadeReturn_bit = new SqlParameter();
                LadeReturn_bit.ParameterName = "@LadeReturn_bit";
                LadeReturn_bit.SqlDbType = SqlDbType.Bit;
                LadeReturn_bit.Direction = ParameterDirection.Input;
                LadeReturn_bit.IsNullable = true;
                if (businessObject.LadeReturn_bit.HasValue == false)
                {
                    LadeReturn_bit.Value = DBNull.Value;
                }
                else
                {
                    LadeReturn_bit.Value = businessObject.LadeReturn_bit;
                }
                this.Command.Parameters.Add(LadeReturn_bit);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.TrafficID_bint = (Int64)(this.Command.Parameters["@TrafficID_bint"].Value);
                businessObject.TrafficNumber_bint = (Int64)(this.Command.Parameters["@TrafficNumber_bint"].Value);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void Update(HPS.BLL.TrafficBLL.BLLTraffic_T businessObject, HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnHour_int = new SqlParameter();
                TurnHour_int.ParameterName = "@TurnHour_int";
                TurnHour_int.SqlDbType = SqlDbType.Int;
                TurnHour_int.Direction = ParameterDirection.Input;
                TurnHour_int.IsNullable = false;
                if (businessObject.TurnHour_int.HasValue == false)
                {
                    TurnHour_int.Value = DBNull.Value;
                }
                else
                {
                    TurnHour_int.Value = businessObject.TurnHour_int;
                }
                this.Command.Parameters.Add(TurnHour_int);

                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.Direction = ParameterDirection.Input;
                TrafficNumber_bint.IsNullable = true;
                TrafficNumber_bint.Value = businessObject.TrafficNumber_bint;
                this.Command.Parameters.Add(TrafficNumber_bint);

                SqlParameter TurnNumber_bint = new SqlParameter();
                TurnNumber_bint.ParameterName = "@TurnNumber_bint";
                TurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                TurnNumber_bint.Direction = ParameterDirection.Input;
                TurnNumber_bint.IsNullable = false;
                if (businessObject.TurnNumber_bint.HasValue == false)
                {
                    TurnNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    TurnNumber_bint.Value = businessObject.TurnNumber_bint;
                }
                this.Command.Parameters.Add(TurnNumber_bint);

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = true;
                if (businessObject.DriverID_bint.HasValue == false)
                {
                    DriverID_bint.Value = DBNull.Value;
                }
                else
                {
                    DriverID_bint.Value = businessObject.DriverID_bint;
                }
                this.Command.Parameters.Add(DriverID_bint);

                SqlParameter DriverCardDate_nvc = new SqlParameter();
                DriverCardDate_nvc.ParameterName = "@DriverCardDate_nvc";
                DriverCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardDate_nvc.Direction = ParameterDirection.Input;
                DriverCardDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverCardDate_nvc))
                {
                    DriverCardDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverCardDate_nvc.Value = businessObject.DriverCardDate_nvc;
                }
                this.Command.Parameters.Add(DriverCardDate_nvc);

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverCardNumber_nvc))
                {
                    DriverCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
                }
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                SqlParameter DriverType_nvc = new SqlParameter();
                DriverType_nvc.ParameterName = "@DriverType_nvc";
                DriverType_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverType_nvc.Direction = ParameterDirection.Input;
                DriverType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverType_nvc))
                {
                    DriverType_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverType_nvc.Value = businessObject.DriverType_nvc;
                }
                this.Command.Parameters.Add(DriverType_nvc);

                SqlParameter FirstName_nvc = new SqlParameter();
                FirstName_nvc.ParameterName = "@FirstName_nvc";
                FirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvc.Direction = ParameterDirection.Input;
                FirstName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.FirstName_nvc))
                {
                    FirstName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FirstName_nvc.Value = businessObject.FirstName_nvc;
                }
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LastName_nvc))
                {
                    LastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvc.Value = businessObject.LastName_nvc;
                }
                this.Command.Parameters.Add(LastName_nvc);

                SqlParameter InsuranceNumber_nvc = new SqlParameter();
                InsuranceNumber_nvc.ParameterName = "@InsuranceNumber_nvc";
                InsuranceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceNumber_nvc.Direction = ParameterDirection.Input;
                InsuranceNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.InsuranceNumber_nvc))
                {
                    InsuranceNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    InsuranceNumber_nvc.Value = businessObject.InsuranceNumber_nvc;
                }
                this.Command.Parameters.Add(InsuranceNumber_nvc);

                SqlParameter CityID_int = new SqlParameter();
                CityID_int.ParameterName = "@CityID_int";
                CityID_int.SqlDbType = SqlDbType.Int;
                CityID_int.Direction = ParameterDirection.Input;
                CityID_int.IsNullable = true;
                if (businessObject.CityID_int.HasValue == false)
                {
                    CityID_int.Value = DBNull.Value;
                }
                else
                {
                    CityID_int.Value = businessObject.CityID_int;
                }
                this.Command.Parameters.Add(CityID_int);

                SqlParameter CityCode_nvc = new SqlParameter();
                CityCode_nvc.ParameterName = "@CityCode_nvc";
                CityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CityCode_nvc.Direction = ParameterDirection.Input;
                CityCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CityCode_nvc))
                {
                    CityCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CityCode_nvc.Value = businessObject.CityCode_nvc;
                }
                this.Command.Parameters.Add(CityCode_nvc);

                SqlParameter licenceNumber_int = new SqlParameter();
                licenceNumber_int.ParameterName = "@licenceNumber_int";
                licenceNumber_int.SqlDbType = SqlDbType.BigInt;
                licenceNumber_int.Direction = ParameterDirection.Input;
                licenceNumber_int.IsNullable = true;
                if (businessObject.licenceNumber_int.HasValue == false)
                {
                    licenceNumber_int.Value = DBNull.Value;
                }
                else
                {
                    licenceNumber_int.Value = businessObject.licenceNumber_int;
                }
                this.Command.Parameters.Add(licenceNumber_int);

                SqlParameter LicenceCityID_int = new SqlParameter();
                LicenceCityID_int.ParameterName = "@LicenceCityID_int";
                LicenceCityID_int.SqlDbType = SqlDbType.Int;
                LicenceCityID_int.Direction = ParameterDirection.Input;
                LicenceCityID_int.IsNullable = true;
                if (businessObject.LicenceCityID_int.HasValue == false)
                {
                    LicenceCityID_int.Value = DBNull.Value;
                }
                else
                {
                    LicenceCityID_int.Value = businessObject.LicenceCityID_int;
                }
                this.Command.Parameters.Add(LicenceCityID_int);

                SqlParameter LicenceType_nvc = new SqlParameter();
                LicenceType_nvc.ParameterName = "@LicenceType_nvc";
                LicenceType_nvc.SqlDbType = SqlDbType.NVarChar;
                LicenceType_nvc.Direction = ParameterDirection.Input;
                LicenceType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LicenceType_nvc))
                {
                    LicenceType_nvc.Value = DBNull.Value;
                }
                else
                {
                    LicenceType_nvc.Value = businessObject.LicenceType_nvc;
                }
                this.Command.Parameters.Add(LicenceType_nvc);

                SqlParameter LiceniceDate_nvc = new SqlParameter();
                LiceniceDate_nvc.ParameterName = "@LiceniceDate_nvc";
                LiceniceDate_nvc.SqlDbType = SqlDbType.NVarChar;
                LiceniceDate_nvc.Direction = ParameterDirection.Input;
                LiceniceDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LiceniceDate_nvc))
                {
                    LiceniceDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    LiceniceDate_nvc.Value = businessObject.LiceniceDate_nvc;
                }
                this.Command.Parameters.Add(LiceniceDate_nvc);

                SqlParameter ActivityScope_nvc = new SqlParameter();
                ActivityScope_nvc.ParameterName = "@ActivityScope_nvc";
                ActivityScope_nvc.SqlDbType = SqlDbType.NVarChar;
                ActivityScope_nvc.Direction = ParameterDirection.Input;
                ActivityScope_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ActivityScope_nvc))
                {
                    ActivityScope_nvc.Value = DBNull.Value;
                }
                else
                {
                    ActivityScope_nvc.Value = businessObject.ActivityScope_nvc;
                }
                this.Command.Parameters.Add(ActivityScope_nvc);

                SqlParameter NationalCode_int = new SqlParameter();
                NationalCode_int.ParameterName = "@NationalCode_int";
                NationalCode_int.SqlDbType = SqlDbType.BigInt;
                NationalCode_int.Direction = ParameterDirection.Input;
                NationalCode_int.IsNullable = true;
                if (businessObject.NationalCode_int.HasValue == false)
                {
                    NationalCode_int.Value = DBNull.Value;
                }
                else
                {
                    NationalCode_int.Value = businessObject.NationalCode_int;
                }
                this.Command.Parameters.Add(NationalCode_int);

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = true;
                if (businessObject.CarID_int.HasValue == false)
                {
                    CarID_int.Value = DBNull.Value;
                }
                else
                {
                    CarID_int.Value = businessObject.CarID_int;
                }
                this.Command.Parameters.Add(CarID_int);

                SqlParameter CarCardDate_nvc = new SqlParameter();
                CarCardDate_nvc.ParameterName = "@CarCardDate_nvc";
                CarCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardDate_nvc.Direction = ParameterDirection.Input;
                CarCardDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CarCardDate_nvc))
                {
                    CarCardDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    CarCardDate_nvc.Value = businessObject.CarCardDate_nvc;
                }
                this.Command.Parameters.Add(CarCardDate_nvc);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CarCardNumber_nvc))
                {
                    CarCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                }
                this.Command.Parameters.Add(CarCardNumber_nvc);

                SqlParameter PlateType_nvc = new SqlParameter();
                PlateType_nvc.ParameterName = "@PlateType_nvc";
                PlateType_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateType_nvc.Direction = ParameterDirection.Input;
                PlateType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.PlateType_nvc))
                {
                    PlateType_nvc.Value = DBNull.Value;
                }
                else
                {
                    PlateType_nvc.Value = businessObject.PlateType_nvc;
                }
                this.Command.Parameters.Add(PlateType_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.SerialPlate_nvc))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = businessObject.SerialPlate_nvc;
                }
                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter PlateCityID_int = new SqlParameter();
                PlateCityID_int.ParameterName = "@PlateCityID_int";
                PlateCityID_int.SqlDbType = SqlDbType.Int;
                PlateCityID_int.Direction = ParameterDirection.Input;
                PlateCityID_int.IsNullable = true;
                if (businessObject.PlateCityID_int.HasValue == false)
                {
                    PlateCityID_int.Value = DBNull.Value;
                }
                else
                {
                    PlateCityID_int.Value = businessObject.PlateCityID_int;
                }
                this.Command.Parameters.Add(PlateCityID_int);

                SqlParameter PlateColorID_int = new SqlParameter();
                PlateColorID_int.ParameterName = "@PlateColorID_int";
                PlateColorID_int.SqlDbType = SqlDbType.Int;
                PlateColorID_int.Direction = ParameterDirection.Input;
                PlateColorID_int.IsNullable = true;
                if (businessObject.PlateColorID_int.HasValue == false)
                {
                    PlateColorID_int.Value = DBNull.Value;
                }
                else
                {
                    PlateColorID_int.Value = businessObject.PlateColorID_int;
                }
                this.Command.Parameters.Add(PlateColorID_int);

                SqlParameter CountryID_int = new SqlParameter();
                CountryID_int.ParameterName = "@CountryID_int";
                CountryID_int.SqlDbType = SqlDbType.Int;
                CountryID_int.Direction = ParameterDirection.Input;
                CountryID_int.IsNullable = true;
                if (businessObject.CountryID_int.HasValue == false)
                {
                    CountryID_int.Value = DBNull.Value;
                }
                else
                {
                    CountryID_int.Value = businessObject.CountryID_int;
                }
                this.Command.Parameters.Add(CountryID_int);

                SqlParameter CountryCode_nvc = new SqlParameter();
                CountryCode_nvc.ParameterName = "@CountryCode_nvc";
                CountryCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CountryCode_nvc.Direction = ParameterDirection.Input;
                CountryCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CountryCode_nvc))
                {
                    CountryCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CountryCode_nvc.Value = businessObject.CountryCode_nvc;
                }
                this.Command.Parameters.Add(CountryCode_nvc);

                SqlParameter Country_nvc = new SqlParameter();
                Country_nvc.ParameterName = "@Country_nvc";
                Country_nvc.SqlDbType = SqlDbType.NVarChar;
                Country_nvc.Direction = ParameterDirection.Input;
                Country_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Country_nvc))
                {
                    Country_nvc.Value = DBNull.Value;
                }
                else
                {
                    Country_nvc.Value = businessObject.Country_nvc;
                }
                this.Command.Parameters.Add(Country_nvc);

                SqlParameter YearType_nvc = new SqlParameter();
                YearType_nvc.ParameterName = "@YearType_nvc";
                YearType_nvc.SqlDbType = SqlDbType.NVarChar;
                YearType_nvc.Direction = ParameterDirection.Input;
                YearType_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.YearType_nvc))
                {
                    YearType_nvc.Value = DBNull.Value;
                }
                else
                {
                    YearType_nvc.Value = businessObject.YearType_nvc;
                }
                this.Command.Parameters.Add(YearType_nvc);

                SqlParameter ProductionYear_int = new SqlParameter();
                ProductionYear_int.ParameterName = "@ProductionYear_int";
                ProductionYear_int.SqlDbType = SqlDbType.Int;
                ProductionYear_int.Direction = ParameterDirection.Input;
                ProductionYear_int.IsNullable = true;
                if (businessObject.ProductionYear_int.HasValue == false)
                {
                    ProductionYear_int.Value = DBNull.Value;
                }
                else
                {
                    ProductionYear_int.Value = businessObject.ProductionYear_int;
                }
                this.Command.Parameters.Add(ProductionYear_int);

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = true;
                if (businessObject.LaderTypeID_int.HasValue == false)
                {
                    LaderTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeID_int.Value = businessObject.LaderTypeID_int;
                }
                this.Command.Parameters.Add(LaderTypeID_int);

                SqlParameter LaderTypeCode_nvc = new SqlParameter();
                LaderTypeCode_nvc.ParameterName = "@LaderTypeCode_nvc";
                LaderTypeCode_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeCode_nvc.Direction = ParameterDirection.Input;
                LaderTypeCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LaderTypeCode_nvc))
                {
                    LaderTypeCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeCode_nvc.Value = businessObject.LaderTypeCode_nvc;
                }
                this.Command.Parameters.Add(LaderTypeCode_nvc);

                SqlParameter SystemCode_nvc = new SqlParameter();
                SystemCode_nvc.ParameterName = "@SystemCode_nvc";
                SystemCode_nvc.SqlDbType = SqlDbType.NVarChar;
                SystemCode_nvc.Direction = ParameterDirection.Input;
                SystemCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SystemCode_nvc))
                {
                    SystemCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    SystemCode_nvc.Value = businessObject.SystemCode_nvc;
                }
                this.Command.Parameters.Add(SystemCode_nvc);

                SqlParameter System_nvc = new SqlParameter();
                System_nvc.ParameterName = "@System_nvc";
                System_nvc.SqlDbType = SqlDbType.NVarChar;
                System_nvc.Direction = ParameterDirection.Input;
                System_nvc.IsNullable = true;
                System_nvc.Value = businessObject.System_nvc;
                this.Command.Parameters.Add(System_nvc);

                SqlParameter Capacity_flt = new SqlParameter();
                Capacity_flt.ParameterName = "@Capacity_flt";
                Capacity_flt.SqlDbType = SqlDbType.Float;
                Capacity_flt.Direction = ParameterDirection.Input;
                Capacity_flt.IsNullable = false;
                if (businessObject.Capacity_flt.HasValue == false)
                {
                    Capacity_flt.Value = DBNull.Value;
                }
                else
                {
                    Capacity_flt.Value = businessObject.Capacity_flt;
                }
                this.Command.Parameters.Add(Capacity_flt);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = true;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObject.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);

                SqlParameter AllowableHour_int = new SqlParameter();
                AllowableHour_int.ParameterName = "@AllowableHour_int";
                AllowableHour_int.SqlDbType = SqlDbType.Int;
                AllowableHour_int.Direction = ParameterDirection.Input;
                AllowableHour_int.IsNullable = false;
                AllowableHour_int.Value = businessObject.AllowableHour_int;
                this.Command.Parameters.Add(AllowableHour_int);

                SqlParameter ExtraHour_int = new SqlParameter();
                ExtraHour_int.ParameterName = "@ExtraHour_int";
                ExtraHour_int.SqlDbType = SqlDbType.Int;
                ExtraHour_int.Direction = ParameterDirection.Input;
                ExtraHour_int.IsNullable = false;
                ExtraHour_int.Value = businessObject.ExtraHour_int;
                this.Command.Parameters.Add(ExtraHour_int);

                SqlParameter ExtraHourFee_dec = new SqlParameter();
                ExtraHourFee_dec.ParameterName = "@ExtraHourFee_dec";
                ExtraHourFee_dec.SqlDbType = SqlDbType.Decimal;
                ExtraHourFee_dec.Direction = ParameterDirection.Input;
                ExtraHourFee_dec.IsNullable = false;
                ExtraHourFee_dec.Value = businessObject.ExtraHourFee_dec;
                this.Command.Parameters.Add(ExtraHourFee_dec);

                SqlParameter Fee_dec = new SqlParameter();
                Fee_dec.ParameterName = "@Fee_dec";
                Fee_dec.SqlDbType = SqlDbType.Decimal;
                Fee_dec.Direction = ParameterDirection.Input;
                Fee_dec.IsNullable = false;
                Fee_dec.Value = businessObject.Fee_dec;
                this.Command.Parameters.Add(Fee_dec);

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObject.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);

                SqlParameter Computer_nvc = new SqlParameter();
                Computer_nvc.ParameterName = "@Computer_nvc";
                Computer_nvc.SqlDbType = SqlDbType.NVarChar;
                Computer_nvc.Direction = ParameterDirection.Input;
                Computer_nvc.IsNullable = false;
                Computer_nvc.Value = businessObject.Computer_nvc;
                this.Command.Parameters.Add(Computer_nvc);

                SqlParameter IPAddress_nvc = new SqlParameter();
                IPAddress_nvc.ParameterName = "@IPAddress_nvc";
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                IPAddress_nvc.Direction = ParameterDirection.Input;
                IPAddress_nvc.IsNullable = false;
                IPAddress_nvc.Value = businessObject.IPAddress_nvc;
                this.Command.Parameters.Add(IPAddress_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter TrafficTypeID_int = new SqlParameter();
                TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_int.SqlDbType = SqlDbType.Int;
                TrafficTypeID_int.Direction = ParameterDirection.Input;
                TrafficTypeID_int.IsNullable = false;
                if (businessObject.TrafficTypeID_int.HasValue == false)
                {
                    TrafficTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    TrafficTypeID_int.Value = businessObject.TrafficTypeID_int;
                }
                this.Command.Parameters.Add(TrafficTypeID_int);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                Date_nvc.Value = businessObject.Date_nvc;
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Time_nvc = new SqlParameter();
                Time_nvc.ParameterName = "@Time_nvc";
                Time_nvc.SqlDbType = SqlDbType.NVarChar;
                Time_nvc.Direction = ParameterDirection.Input;
                Time_nvc.IsNullable = false;
                Time_nvc.Value = businessObject.Time_nvc;
                this.Command.Parameters.Add(Time_nvc);

                SqlParameter WithFlat_bit = new SqlParameter();
                WithFlat_bit.ParameterName = "@WithFlat_bit";
                WithFlat_bit.SqlDbType = SqlDbType.Bit;
                WithFlat_bit.Direction = ParameterDirection.Input;
                WithFlat_bit.IsNullable = false;
                WithFlat_bit.Value = businessObject.WithFlat_bit;
                this.Command.Parameters.Add(WithFlat_bit);

                SqlParameter NationalityCountryID_int = new SqlParameter();
                NationalityCountryID_int.ParameterName = "@NationalityCountryID_int";
                NationalityCountryID_int.SqlDbType = SqlDbType.Int;
                NationalityCountryID_int.Direction = ParameterDirection.Input;
                NationalityCountryID_int.IsNullable = false;
                if (businessObject.NationalityCountryID_int.HasValue == false)
                {
                    NationalityCountryID_int.Value = DBNull.Value;
                }
                else
                {
                    NationalityCountryID_int.Value = businessObject.NationalityCountryID_int;
                }
                this.Command.Parameters.Add(NationalityCountryID_int);

                SqlParameter OriginCountryID_int = new SqlParameter();
                OriginCountryID_int.ParameterName = "@OriginCountryID_int";
                OriginCountryID_int.SqlDbType = SqlDbType.Int;
                OriginCountryID_int.Direction = ParameterDirection.Input;
                OriginCountryID_int.IsNullable = true;
                if (businessObject.OriginCountryID_int.HasValue == false)
                {
                    OriginCountryID_int.Value = DBNull.Value;
                }
                else
                {
                    OriginCountryID_int.Value = businessObject.OriginCountryID_int;
                }
                this.Command.Parameters.Add(OriginCountryID_int);

                SqlParameter DestinationCountryID_int = new SqlParameter();
                DestinationCountryID_int.ParameterName = "@DestinationCountryID_int";
                DestinationCountryID_int.SqlDbType = SqlDbType.Int;
                DestinationCountryID_int.Direction = ParameterDirection.Input;
                DestinationCountryID_int.IsNullable = true;
                if (businessObject.DestinationCountryID_int.HasValue == false)
                {
                    DestinationCountryID_int.Value = DBNull.Value;
                }
                else
                {
                    DestinationCountryID_int.Value = businessObject.DestinationCountryID_int;
                }
                this.Command.Parameters.Add(DestinationCountryID_int);

                SqlParameter EntranceBoundaryID_int = new SqlParameter();
                EntranceBoundaryID_int.ParameterName = "@EntranceBoundaryID_int";
                EntranceBoundaryID_int.SqlDbType = SqlDbType.Int;
                EntranceBoundaryID_int.Direction = ParameterDirection.Input;
                EntranceBoundaryID_int.IsNullable = true;
                if (businessObject.EntranceBoundaryID_int.HasValue == false)
                {
                    EntranceBoundaryID_int.Value = DBNull.Value;
                }
                else
                {
                    EntranceBoundaryID_int.Value = businessObject.EntranceBoundaryID_int;
                }
                this.Command.Parameters.Add(EntranceBoundaryID_int);

                SqlParameter In_bit = new SqlParameter();
                In_bit.ParameterName = "@In_bit";
                In_bit.SqlDbType = SqlDbType.Bit;
                In_bit.Direction = ParameterDirection.Input;
                In_bit.IsNullable = true;
                In_bit.Value = businessObject.In_bit;
                this.Command.Parameters.Add(In_bit);

                SqlParameter Out_bit = new SqlParameter();
                Out_bit.ParameterName = "@Out_bit";
                Out_bit.SqlDbType = SqlDbType.Bit;
                Out_bit.Direction = ParameterDirection.Input;
                Out_bit.IsNullable = false;
                Out_bit.Value = businessObject.Out_bit;
                this.Command.Parameters.Add(Out_bit);

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = false;
                if (businessObject.BillMessageID_int.HasValue == false)
                {
                    BillMessageID_int.Value = DBNull.Value;
                }
                else
                {
                    BillMessageID_int.Value = businessObject.BillMessageID_int;
                }
                this.Command.Parameters.Add(BillMessageID_int);

                SqlParameter Price_dec = new SqlParameter();
                Price_dec.ParameterName = "@Price_dec";
                Price_dec.SqlDbType = SqlDbType.Decimal;
                Price_dec.Direction = ParameterDirection.Input;
                Price_dec.IsNullable = true;
                if (businessObject.Price_dec.HasValue == false)
                {
                    Price_dec.Value = DBNull.Value;
                }
                else
                {
                    Price_dec.Value = businessObject.Price_dec;
                }
                this.Command.Parameters.Add(Price_dec);

                SqlParameter Hourse_bit = new SqlParameter();
                Hourse_bit.ParameterName = "@Hourse_bit";
                Hourse_bit.SqlDbType = SqlDbType.Bit;
                Hourse_bit.Direction = ParameterDirection.Input;
                Hourse_bit.IsNullable = true;
                Hourse_bit.Value = businessObject.Hourse_bit;
                this.Command.Parameters.Add(Hourse_bit);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

                SqlParameter ServiceID_int = new SqlParameter();
                ServiceID_int.ParameterName = "@ServiceID_int";
                ServiceID_int.SqlDbType = SqlDbType.Int;
                ServiceID_int.Direction = ParameterDirection.Input;
                ServiceID_int.IsNullable = true;
                ServiceID_int.Value = businessObject.ServiceID_int;
                this.Command.Parameters.Add(ServiceID_int);

                SqlParameter WithLade_bit = new SqlParameter();
                WithLade_bit.ParameterName = "@WithLade_bit";
                WithLade_bit.SqlDbType = SqlDbType.Bit;
                WithLade_bit.Direction = ParameterDirection.Input;
                WithLade_bit.IsNullable = false;
                WithLade_bit.Value = businessObject.WithLade_bit;
                this.Command.Parameters.Add(WithLade_bit);

                SqlParameter Printed_bit = new SqlParameter();
                Printed_bit.ParameterName = "@Printed_bit";
                Printed_bit.SqlDbType = SqlDbType.Bit;
                Printed_bit.Direction = ParameterDirection.Input;
                Printed_bit.IsNullable = false;
                Printed_bit.Value = businessObject.Printed_bit;
                this.Command.Parameters.Add(Printed_bit);

                SqlParameter TemporaryOut_bit = new SqlParameter();
                TemporaryOut_bit.ParameterName = "@TemporaryOut_bit";
                TemporaryOut_bit.SqlDbType = SqlDbType.Bit;
                TemporaryOut_bit.Direction = ParameterDirection.Input;
                TemporaryOut_bit.IsNullable = false;
                TemporaryOut_bit.Value = businessObject.TemporaryOut_bit;
                this.Command.Parameters.Add(TemporaryOut_bit);

                SqlParameter AcceptedTurnNumber_bint = new SqlParameter();
                AcceptedTurnNumber_bint.ParameterName = "@AcceptedTurnNumber_bint";
                AcceptedTurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                AcceptedTurnNumber_bint.Direction = ParameterDirection.Input;
                AcceptedTurnNumber_bint.IsNullable = false;
                if (businessObject.AcceptedTurnNumber_bint.HasValue == false)
                {
                    AcceptedTurnNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnNumber_bint.Value = businessObject.AcceptedTurnNumber_bint;
                }
                this.Command.Parameters.Add(AcceptedTurnNumber_bint);

                SqlParameter AcceptedTurnComment_nvc = new SqlParameter();
                AcceptedTurnComment_nvc.ParameterName = "@AcceptedTurnComment_nvc";
                AcceptedTurnComment_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTurnComment_nvc.Direction = ParameterDirection.Input;
                AcceptedTurnComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedTurnComment_nvc))
                {
                    AcceptedTurnComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnComment_nvc.Value = businessObject.AcceptedTurnComment_nvc;
                }
                this.Command.Parameters.Add(AcceptedTurnComment_nvc);

                SqlParameter TurnDate_nvc = new SqlParameter();
                TurnDate_nvc.ParameterName = "@TurnDate_nvc";
                TurnDate_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnDate_nvc.Direction = ParameterDirection.Input;
                TurnDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnDate_nvc))
                {
                    TurnDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnDate_nvc.Value = businessObject.TurnDate_nvc;
                }
                this.Command.Parameters.Add(TurnDate_nvc);

                SqlParameter TurnTime_nvc = new SqlParameter();
                TurnTime_nvc.ParameterName = "@TurnTime_nvc";
                TurnTime_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnTime_nvc.Direction = ParameterDirection.Input;
                TurnTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnTime_nvc))
                {
                    TurnTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnTime_nvc.Value = businessObject.TurnTime_nvc;
                }
                this.Command.Parameters.Add(TurnTime_nvc);

                SqlParameter TurnUser_nvc = new SqlParameter();
                TurnUser_nvc.ParameterName = "@TurnUser_nvc";
                TurnUser_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnUser_nvc.Direction = ParameterDirection.Input;
                TurnUser_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnUser_nvc))
                {
                    TurnUser_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnUser_nvc.Value = businessObject.TurnUser_nvc;
                }
                this.Command.Parameters.Add(TurnUser_nvc);

                SqlParameter TurnAccepted_bit = new SqlParameter();
                TurnAccepted_bit.ParameterName = "@TurnAccepted_bit";
                TurnAccepted_bit.SqlDbType = SqlDbType.Bit;
                TurnAccepted_bit.Direction = ParameterDirection.Input;
                TurnAccepted_bit.IsNullable = true;
                if (businessObject.TurnAccepted_bit.HasValue == false)
                {
                    TurnAccepted_bit.Value = DBNull.Value;
                }
                else
                {
                    TurnAccepted_bit.Value = businessObject.TurnAccepted_bit;
                }
                this.Command.Parameters.Add(TurnAccepted_bit);

                SqlParameter CarCardRead_bit = new SqlParameter();
                CarCardRead_bit.ParameterName = "@CarCardRead_bit";
                CarCardRead_bit.SqlDbType = SqlDbType.Bit;
                CarCardRead_bit.Direction = ParameterDirection.Input;
                CarCardRead_bit.IsNullable = true;
                CarCardRead_bit.Value = businessObject.CarCardRead_bit;
                this.Command.Parameters.Add(CarCardRead_bit);

                SqlParameter DriverCardRead_bit = new SqlParameter();
                DriverCardRead_bit.ParameterName = "@DriverCardRead_bit";
                DriverCardRead_bit.SqlDbType = SqlDbType.Bit;
                DriverCardRead_bit.Direction = ParameterDirection.Input;
                DriverCardRead_bit.IsNullable = false;
                DriverCardRead_bit.Value = businessObject.DriverCardRead_bit;
                this.Command.Parameters.Add(DriverCardRead_bit);

                SqlParameter TurnPrinted_bit = new SqlParameter();
                TurnPrinted_bit.ParameterName = "@TurnPrinted_bit";
                TurnPrinted_bit.SqlDbType = SqlDbType.Bit;
                TurnPrinted_bit.Direction = ParameterDirection.Input;
                TurnPrinted_bit.IsNullable = false;
                TurnPrinted_bit.Value = businessObject.TurnPrinted_bit;
                this.Command.Parameters.Add(TurnPrinted_bit);


                SqlParameter pk_TrafficID_bint = new SqlParameter();
                pk_TrafficID_bint.ParameterName = "@pk_TrafficID_bint";
                pk_TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                pk_TrafficID_bint.Direction = ParameterDirection.Input;
                pk_TrafficID_bint.IsNullable = false;
                pk_TrafficID_bint.Value = businessObjectKey.TrafficID_bint;
                this.Command.Parameters.Add(pk_TrafficID_bint);

                SqlParameter DriverMobileNumber_nvc = new SqlParameter();
                DriverMobileNumber_nvc.ParameterName = "@DriverMobileNumber_nvc";
                DriverMobileNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverMobileNumber_nvc.Direction = ParameterDirection.Input;
                DriverMobileNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverMobileNumber_nvc) == false)
                {
                    DriverMobileNumber_nvc.Value = businessObject.DriverMobileNumber_nvc;
                }
                else
                {
                    DriverMobileNumber_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(DriverMobileNumber_nvc);

                SqlParameter Area_bit = new SqlParameter();
                Area_bit.ParameterName = "@Area_bit";
                Area_bit.SqlDbType = SqlDbType.Bit;
                Area_bit.Direction = ParameterDirection.Input;
                Area_bit.IsNullable = false;
                Area_bit.Value = businessObject.Area_bit;
                this.Command.Parameters.Add(Area_bit);

                SqlParameter CarOffline_bit = new SqlParameter();
                CarOffline_bit.ParameterName = "@CarOffline_bit";
                CarOffline_bit.SqlDbType = SqlDbType.Bit;
                CarOffline_bit.Direction = ParameterDirection.Input;
                CarOffline_bit.IsNullable = false;
                CarOffline_bit.Value = businessObject.CarOffline_bit;
                this.Command.Parameters.Add(CarOffline_bit);

                SqlParameter DriverOffline_bit = new SqlParameter();
                DriverOffline_bit.ParameterName = "@DriverOffline_bit";
                DriverOffline_bit.SqlDbType = SqlDbType.Bit;
                DriverOffline_bit.Direction = ParameterDirection.Input;
                DriverOffline_bit.IsNullable = false;
                DriverOffline_bit.Value = businessObject.DriverOffline_bit;
                this.Command.Parameters.Add(DriverOffline_bit);

                SqlParameter CameraPlateNumber_nvc = new SqlParameter();
                CameraPlateNumber_nvc.ParameterName = "@CameraPlateNumber_nvc";
                CameraPlateNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CameraPlateNumber_nvc.Direction = ParameterDirection.Input;
                CameraPlateNumber_nvc.IsNullable = false;
                if (string.IsNullOrEmpty(businessObject.CameraPlateNumber_nvc))
                    CameraPlateNumber_nvc.Value = DBNull.Value;
                else
                    CameraPlateNumber_nvc.Value = businessObject.CameraPlateNumber_nvc;
                this.Command.Parameters.Add(CameraPlateNumber_nvc);

                SqlParameter CameraSerialPlate_int = new SqlParameter();
                CameraSerialPlate_int.ParameterName = "@CameraSerialPlate_int";
                CameraSerialPlate_int.SqlDbType = SqlDbType.Int;
                CameraSerialPlate_int.Direction = ParameterDirection.Input;
                CameraSerialPlate_int.IsNullable = true;
                if (!businessObject.CameraSerialPlate_int.HasValue)
                {
                    CameraSerialPlate_int.Value = DBNull.Value;
                }
                else
                {
                    CameraSerialPlate_int.Value = businessObject.CameraSerialPlate_int;
                }
                this.Command.Parameters.Add(CameraSerialPlate_int);


                SqlParameter EditUserName_nvc = new SqlParameter();
                EditUserName_nvc.ParameterName = "@EditUserName_nvc";
                EditUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                EditUserName_nvc.Direction = ParameterDirection.Input;
                EditUserName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.EditUserName_nvc))
                {
                    EditUserName_nvc.Value = DBNull.Value;
                }
                else
                    EditUserName_nvc.Value = businessObject.EditUserName_nvc;
                this.Command.Parameters.Add(EditUserName_nvc);

                SqlParameter EditDate_vc = new SqlParameter();
                EditDate_vc.ParameterName = "@EditDate_vc";
                EditDate_vc.SqlDbType = SqlDbType.NVarChar;
                EditDate_vc.Direction = ParameterDirection.Input;
                EditDate_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.EditDate_vc))
                {
                    EditDate_vc.Value = DBNull.Value;
                }
                else
                    EditDate_vc.Value = businessObject.EditDate_vc;
                this.Command.Parameters.Add(EditDate_vc);

                SqlParameter EditTime_vc = new SqlParameter();
                EditTime_vc.ParameterName = "@EditTime_vc";
                EditTime_vc.SqlDbType = SqlDbType.NVarChar;
                EditTime_vc.Direction = ParameterDirection.Input;
                EditTime_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.EditTime_vc))
                {
                    EditTime_vc.Value = DBNull.Value;
                }
                else
                    EditTime_vc.Value = businessObject.EditTime_vc;
                this.Command.Parameters.Add(EditTime_vc);

                SqlParameter PriceTax_dec = new SqlParameter();
                PriceTax_dec.ParameterName = "@PriceTax_dec";
                PriceTax_dec.SqlDbType = SqlDbType.Decimal;
                PriceTax_dec.Direction = ParameterDirection.Input;
                PriceTax_dec.IsNullable = true;
                if (businessObject.PriceTax_dec.HasValue == false)
                {
                    PriceTax_dec.Value = DBNull.Value;
                }
                else
                {
                    PriceTax_dec.Value = businessObject.PriceTax_dec;
                }
                this.Command.Parameters.Add(PriceTax_dec);

                SqlParameter LadeReturn_bit = new SqlParameter();
                LadeReturn_bit.ParameterName = "@LadeReturn_bit";
                LadeReturn_bit.SqlDbType = SqlDbType.Bit;
                LadeReturn_bit.Direction = ParameterDirection.Input;
                LadeReturn_bit.IsNullable = true;
                if (businessObject.LadeReturn_bit.HasValue == false)
                {
                    LadeReturn_bit.Value = DBNull.Value;
                }
                else
                {
                    LadeReturn_bit.Value = businessObject.LadeReturn_bit;
                }

                this.Command.Parameters.Add(LadeReturn_bit);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> Result = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAll(ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAll(ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAll(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public HPS.BLL.TrafficBLL.BLLTraffic_T SelectByPrimaryKey(HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObjectKey.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.TrafficBLL.BLLTraffic_T businessObject = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                if (dataReader.Read())
                {
                    PopulateBusinessObjectFromReader(businessObject, dataReader);
                }
                else
                {
                    businessObject = null;
                }

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }


                if (ControlConnection)
                {
                    this.Commit();
                }
                return businessObject;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByPrimaryKey(HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObjectKey.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByPrimaryKey(HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObjectKey.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByPrimaryKey(HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObjectKey.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Traffic_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> Result = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByField(String fieldName, Object value, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Traffic_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByField(String fieldName, Object value, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Traffic_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByField(String fieldName, Object value, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Traffic_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> Result = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByCondition(String Condition, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByCondition(String Condition, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByCondition(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void Delete(HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObjectKey.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void DeleteByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_DeleteByField]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                this.Command.Parameters.Add(new SqlParameter("@Value", value));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void PopulateBusinessObjectFromReader(HPS.BLL.TrafficBLL.BLLTraffic_T businessObject, IDataReader dataReader)
        {
            businessObject.TrafficID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficID_bint.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnHour_int.ToString())) == false)
            {
                businessObject.TurnHour_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnHour_int.ToString()));
            }
            else
            {
                businessObject.TurnHour_int = null;
            }

            businessObject.TrafficNumber_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnNumber_bint.ToString())) == false)
            {
                businessObject.TurnNumber_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnNumber_bint.ToString()));
            }
            else
            {
                businessObject.TurnNumber_bint = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverID_bint.ToString())) == false)
            {
                businessObject.DriverID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverID_bint.ToString()));
            }
            else
            {
                businessObject.DriverID_bint = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardDate_nvc.ToString())) == false)
            {
                businessObject.DriverCardDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardDate_nvc.ToString()));
            }
            else
            {
                businessObject.DriverCardDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardNumber_nvc.ToString())) == false)
            {
                businessObject.DriverCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardNumber_nvc.ToString()));
            }
            else
            {
                businessObject.DriverCardNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverType_nvc.ToString())) == false)
            {
                businessObject.DriverType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverType_nvc.ToString()));
            }
            else
            {
                businessObject.DriverType_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.FirstName_nvc.ToString())) == false)
            {
                businessObject.FirstName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.FirstName_nvc.ToString()));
            }
            else
            {
                businessObject.FirstName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LastName_nvc.ToString())) == false)
            {
                businessObject.LastName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LastName_nvc.ToString()));
            }
            else
            {
                businessObject.LastName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.InsuranceNumber_nvc.ToString())) == false)
            {
                businessObject.InsuranceNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.InsuranceNumber_nvc.ToString()));
            }
            else
            {
                businessObject.InsuranceNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CityID_int.ToString())) == false)
            {
                businessObject.CityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CityID_int.ToString()));
            }
            else
            {
                businessObject.CityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CityCode_nvc.ToString())) == false)
            {
                businessObject.CityCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CityCode_nvc.ToString()));
            }
            else
            {
                businessObject.CityCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.licenceNumber_int.ToString())) == false)
            {
                businessObject.licenceNumber_int = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.licenceNumber_int.ToString()));
            }
            else
            {
                businessObject.licenceNumber_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LicenceCityID_int.ToString())) == false)
            {
                businessObject.LicenceCityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LicenceCityID_int.ToString()));
            }
            else
            {
                businessObject.LicenceCityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LicenceType_nvc.ToString())) == false)
            {
                businessObject.LicenceType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LicenceType_nvc.ToString()));
            }
            else
            {
                businessObject.LicenceType_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LiceniceDate_nvc.ToString())) == false)
            {
                businessObject.LiceniceDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LiceniceDate_nvc.ToString()));
            }
            else
            {
                businessObject.LiceniceDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ActivityScope_nvc.ToString())) == false)
            {
                businessObject.ActivityScope_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ActivityScope_nvc.ToString()));
            }
            else
            {
                businessObject.ActivityScope_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.NationalCode_int.ToString())) == false)
            {
                businessObject.NationalCode_int = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.NationalCode_int.ToString()));
            }
            else
            {
                businessObject.NationalCode_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarID_int.ToString())) == false)
            {
                businessObject.CarID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarID_int.ToString()));
            }
            else
            {
                businessObject.CarID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarCardDate_nvc.ToString())) == false)
            {
                businessObject.CarCardDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarCardDate_nvc.ToString()));
            }
            else
            {
                businessObject.CarCardDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarCardNumber_nvc.ToString())) == false)
            {
                businessObject.CarCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarCardNumber_nvc.ToString()));
            }
            else
            {
                businessObject.CarCardNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PlateType_nvc.ToString())) == false)
            {
                businessObject.PlateType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PlateType_nvc.ToString()));
            }
            else
            {
                businessObject.PlateType_nvc = String.Empty;
            }

            businessObject.NumberPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.NumberPlate_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.SerialPlate_nvc.ToString())) == false)
            {
                businessObject.SerialPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.SerialPlate_nvc.ToString()));
            }
            else
            {
                businessObject.SerialPlate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PlateCityID_int.ToString())) == false)
            {
                businessObject.PlateCityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PlateCityID_int.ToString()));
            }
            else
            {
                businessObject.PlateCityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PlateColorID_int.ToString())) == false)
            {
                businessObject.PlateColorID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PlateColorID_int.ToString()));
            }
            else
            {
                businessObject.PlateColorID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CountryID_int.ToString())) == false)
            {
                businessObject.CountryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CountryID_int.ToString()));
            }
            else
            {
                businessObject.CountryID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CountryCode_nvc.ToString())) == false)
            {
                businessObject.CountryCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CountryCode_nvc.ToString()));
            }
            else
            {
                businessObject.CountryCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Country_nvc.ToString())) == false)
            {
                businessObject.Country_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Country_nvc.ToString()));
            }
            else
            {
                businessObject.Country_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.YearType_nvc.ToString())) == false)
            {
                businessObject.YearType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.YearType_nvc.ToString()));
            }
            else
            {
                businessObject.YearType_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ProductionYear_int.ToString())) == false)
            {
                businessObject.ProductionYear_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ProductionYear_int.ToString()));
            }
            else
            {
                businessObject.ProductionYear_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LaderTypeID_int.ToString())) == false)
            {
                businessObject.LaderTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LaderTypeID_int.ToString()));
            }
            else
            {
                businessObject.LaderTypeID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LaderTypeCode_nvc.ToString())) == false)
            {
                businessObject.LaderTypeCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LaderTypeCode_nvc.ToString()));
            }
            else
            {
                businessObject.LaderTypeCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.SystemCode_nvc.ToString())) == false)
            {
                businessObject.SystemCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.SystemCode_nvc.ToString()));
            }
            else
            {
                businessObject.SystemCode_nvc = String.Empty;
            }

            businessObject.System_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.System_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Capacity_flt.ToString())) == false)
            {
                businessObject.Capacity_flt = dataReader.GetDouble(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Capacity_flt.ToString()));
            }
            else
            {
                businessObject.Capacity_flt = null;
            }

            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.UserName_nvc.ToString()));
            businessObject.StopFeeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.StopFeeID_int.ToString()));
            businessObject.AllowableHour_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.AllowableHour_int.ToString()));
            businessObject.ExtraHour_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ExtraHour_int.ToString()));
            businessObject.ExtraHourFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ExtraHourFee_dec.ToString()));
            businessObject.Fee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Fee_dec.ToString()));
            businessObject.ComputerID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ComputerID_int.ToString()));
            businessObject.Computer_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Computer_nvc.ToString()));
            businessObject.IPAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.IPAddress_nvc.ToString()));
            businessObject.MacAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.MacAddress_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficTypeID_int.ToString())) == false)
            {
                businessObject.TrafficTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficTypeID_int.ToString()));
            }
            else
            {
                businessObject.TrafficTypeID_int = null;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Time_nvc.ToString()));
            businessObject.WithFlat_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.WithFlat_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.NationalityCountryID_int.ToString())) == false)
            {
                businessObject.NationalityCountryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.NationalityCountryID_int.ToString()));
            }
            else
            {
                businessObject.NationalityCountryID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.OriginCountryID_int.ToString())) == false)
            {
                businessObject.OriginCountryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.OriginCountryID_int.ToString()));
            }
            else
            {
                businessObject.OriginCountryID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DestinationCountryID_int.ToString())) == false)
            {
                businessObject.DestinationCountryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DestinationCountryID_int.ToString()));
            }
            else
            {
                businessObject.DestinationCountryID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EntranceBoundaryID_int.ToString())) == false)
            {
                businessObject.EntranceBoundaryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EntranceBoundaryID_int.ToString()));
            }
            else
            {
                businessObject.EntranceBoundaryID_int = null;
            }

            businessObject.In_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.In_bit.ToString()));
            businessObject.Out_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Out_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.BillMessageID_int.ToString())) == false)
            {
                businessObject.BillMessageID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.BillMessageID_int.ToString()));
            }
            else
            {
                businessObject.BillMessageID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Price_dec.ToString())) == false)
            {
                businessObject.Price_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Price_dec.ToString()));
            }
            else
            {
                businessObject.Price_dec = null;
            }

            businessObject.Hourse_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Hourse_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Comment_nvc.ToString())) == false)
            {
                businessObject.Comment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Comment_nvc.ToString()));
            }
            else
            {
                businessObject.Comment_nvc = String.Empty;
            }

            businessObject.ServiceID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.ServiceID_int.ToString()));
            businessObject.WithLade_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.WithLade_bit.ToString()));
            businessObject.Printed_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.Printed_bit.ToString()));
            businessObject.TemporaryOut_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TemporaryOut_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.AcceptedTurnNumber_bint.ToString())) == false)
            {
                businessObject.AcceptedTurnNumber_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.AcceptedTurnNumber_bint.ToString()));
            }
            else
            {
                businessObject.AcceptedTurnNumber_bint = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.AcceptedTurnComment_nvc.ToString())) == false)
            {
                businessObject.AcceptedTurnComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.AcceptedTurnComment_nvc.ToString()));
            }
            else
            {
                businessObject.AcceptedTurnComment_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnDate_nvc.ToString())) == false)
            {
                businessObject.TurnDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnDate_nvc.ToString()));
            }
            else
            {
                businessObject.TurnDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnTime_nvc.ToString())) == false)
            {
                businessObject.TurnTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnTime_nvc.ToString()));
            }
            else
            {
                businessObject.TurnTime_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnUser_nvc.ToString())) == false)
            {
                businessObject.TurnUser_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnUser_nvc.ToString()));
            }
            else
            {
                businessObject.TurnUser_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnAccepted_bit.ToString())) == false)
            {
                businessObject.TurnAccepted_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnAccepted_bit.ToString()));
            }
            else
            {
                businessObject.TurnAccepted_bit = null;
            }

            businessObject.CarCardRead_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarCardRead_bit.ToString()));
            businessObject.DriverCardRead_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardRead_bit.ToString()));
            businessObject.TurnPrinted_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TurnPrinted_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverMobileNumber_nvc.ToString())) == false)
            {
                businessObject.DriverMobileNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverMobileNumber_nvc.ToString()));
            }
            else
            {
                businessObject.DriverMobileNumber_nvc = string.Empty;
            }
            businessObject.Area_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField. Area_bit.ToString()));
            businessObject.CarOffline_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CarOffline_bit.ToString()));
            businessObject.DriverOffline_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverOffline_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CameraPlateNumber_nvc.ToString())) == false)
            {
                businessObject.CameraPlateNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CameraPlateNumber_nvc.ToString()));
            }
            else
            {
                businessObject.CameraPlateNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CameraSerialPlate_int.ToString())) == false)
            {
                businessObject.CameraSerialPlate_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.CameraSerialPlate_int.ToString()));
            }
            else
            {
                businessObject.CameraSerialPlate_int = null;
            }
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditUserName_nvc.ToString())) == false)
            {
                businessObject.EditUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditUserName_nvc.ToString()));
            }
            else
            {
                businessObject.EditUserName_nvc = string.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditDate_vc.ToString())) == false)
            {
                businessObject.EditDate_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditDate_vc.ToString()));
            }
            else
            {
                businessObject.EditDate_vc = string.Empty;
            }
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditTime_vc.ToString())) == false)
            {
                businessObject.EditTime_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.EditTime_vc.ToString()));
            }
            else
            {
                businessObject.EditTime_vc = string.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PriceTax_dec .ToString())) == false)
            {
                businessObject.PriceTax_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.PriceTax_dec.ToString()));
            }
            else
            {
                businessObject.PriceTax_dec = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LadeReturn_bit.ToString())) == false)
            {
                businessObject.LadeReturn_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.LadeReturn_bit.ToString()));
            }
            else
            {
                businessObject.LadeReturn_bit = null;
            }
           

        }

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.TrafficBLL.BLLTraffic_T> list = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
            while (dataReader.Read())
            {
                HPS.BLL.TrafficBLL.BLLTraffic_T businessObject = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        //later added
        public void SelectByConditionAllTraffic(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionALL]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByConditionAllInTraffic(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionIn]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        public void SelectByConditionAllInTrafficArea(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionInArea]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        public void SelectByConditionAllInTrafficForOut(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionInAutoComplete]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> SelectByConditionAllInTraffic(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionIn]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> Result = new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public Int64 GetLastTurnNumber()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_GetNewTurnNumber]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnNumber_bint = new SqlParameter();
                TurnNumber_bint.ParameterName = "@TurnNumber_bint";
                TurnNumber_bint.Direction = ParameterDirection.Output;
                TurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                TurnNumber_bint.IsNullable = true;
                TurnNumber_bint.Value = DBNull.Value;
                this.Command.Parameters.Add(TurnNumber_bint);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }
                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }

                return (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnNumber_bint.Value, TypeCode.Int64);
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectTurnAccepted(ref System.Data.DataTable dataTable, string Date,Int64 AcceptedTurnNumber)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectInTurnAccepted]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Date))
                {
                    Date_nvc.Value = DBNull.Value;
                }
                else
                {
                    Date_nvc.Value = Date;
                }

                this.Command.Parameters.Add(Date_nvc);

                SqlParameter AcceptedTurnNumber_bint = new SqlParameter();
                AcceptedTurnNumber_bint.ParameterName = "@AcceptedTurnNumber_bint";
                AcceptedTurnNumber_bint.Direction = ParameterDirection.Input;
                AcceptedTurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                AcceptedTurnNumber_bint.IsNullable = false;
                AcceptedTurnNumber_bint.Value = AcceptedTurnNumber;
                this.Command.Parameters.Add(AcceptedTurnNumber_bint);

            
                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllByConditionWithLadBill(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAllLadeAssignmentTrafficCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllTepmoraryOutByCondition(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_TemporaryOutByCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByConditionAllInTrafficNotTemporaryOut(string Condition, ref DataTable dataTable)
        {
            bool ControlConnection = !(ConnectionState == ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(this.Command);
            Command.CommandText = "[sp_Traffic_T_SelectConditionInNotTemporaryOut]";
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    BeginTransaction();
                }

                this.Command.CommandTimeout = 3000;
                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByConditionAllInTrafficForTurnAcception( String Condition,ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionInForTurnAcception]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();
                this.Command.CommandTimeout = 500;

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByFieldReportAllTraffic(string FromDateTimenvc, string ToDateTimenvc, string FromTrafficNumbernvc,string ToTrafficNumbernvc,string LaderPivotGroupIDnvc,string LaderTypeIDnvc,string TrafficTypeIDnvc,string Inbit,string Outbit,string ServicesIDnvc,string TurnAccepted, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_ReportSelectByFieds]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDateTime_nvc = new SqlParameter();
                FromDateTime_nvc.ParameterName = "@FromDateTime_nvc";
                FromDateTime_nvc.Direction = ParameterDirection.Input;
                FromDateTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDateTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDateTimenvc))
                {
                    FromDateTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDateTime_nvc.Value = FromDateTimenvc;
                }
                this.Command.Parameters.Add(FromDateTime_nvc);

                SqlParameter ToDateTime_nvc = new SqlParameter();
                ToDateTime_nvc.ParameterName = "@ToDateTime_nvc";
                ToDateTime_nvc.Direction = ParameterDirection.Input;
                ToDateTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDateTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDateTimenvc))
                {
                    ToDateTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDateTime_nvc.Value = ToDateTimenvc;
                }
                this.Command.Parameters.Add(ToDateTime_nvc);

                SqlParameter FromTrafficNumber_nvc = new SqlParameter();
                FromTrafficNumber_nvc.ParameterName = "@FromTrafficNumber_nvc";
                FromTrafficNumber_nvc.Direction = ParameterDirection.Input;
                FromTrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTrafficNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTrafficNumbernvc))
                {
                    FromTrafficNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTrafficNumber_nvc.Value = FromTrafficNumbernvc;
                }
                this.Command.Parameters.Add(FromTrafficNumber_nvc);

                SqlParameter ToTrafficNumber_nvc = new SqlParameter();
                ToTrafficNumber_nvc.ParameterName = "@ToTrafficNumber_nvc";
                ToTrafficNumber_nvc.Direction = ParameterDirection.Input;
                ToTrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTrafficNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTrafficNumbernvc))
                {
                    ToTrafficNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTrafficNumber_nvc.Value = ToTrafficNumbernvc;
                }
                this.Command.Parameters.Add(ToTrafficNumber_nvc);

                SqlParameter LaderPivotGroupID_nvc = new SqlParameter();
                LaderPivotGroupID_nvc.ParameterName = "@LaderPivotGroupID_nvc";
                LaderPivotGroupID_nvc.Direction = ParameterDirection.Input;
                LaderPivotGroupID_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderPivotGroupID_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(LaderPivotGroupIDnvc))
                {
                    LaderPivotGroupID_nvc.Value = DBNull.Value;
                }
                else
                {
                    LaderPivotGroupID_nvc.Value = LaderPivotGroupIDnvc;
                }
                this.Command.Parameters.Add(LaderPivotGroupID_nvc);

                SqlParameter LaderTypeID_nvc = new SqlParameter();
                LaderTypeID_nvc.ParameterName = "@LaderTypeID_nvc";
                LaderTypeID_nvc.Direction = ParameterDirection.Input;
                LaderTypeID_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeID_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(LaderTypeIDnvc))
                {
                    LaderTypeID_nvc.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeID_nvc.Value = LaderTypeIDnvc;
                }
                this.Command.Parameters.Add(LaderTypeID_nvc);

                SqlParameter TrafficTypeID_nvc = new SqlParameter();
                TrafficTypeID_nvc.ParameterName = "@TrafficTypeID_nvc";
                TrafficTypeID_nvc.Direction = ParameterDirection.Input;
                TrafficTypeID_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficTypeID_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(TrafficTypeIDnvc))
                {
                    TrafficTypeID_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficTypeID_nvc.Value = TrafficTypeIDnvc;
                }
                this.Command.Parameters.Add(TrafficTypeID_nvc);

                SqlParameter TrafficInbit_nvc = new SqlParameter();
                TrafficInbit_nvc.ParameterName = "@TrafficInbit_nvc";
                TrafficInbit_nvc.Direction = ParameterDirection.Input;
                TrafficInbit_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficInbit_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Inbit))
                {
                    TrafficInbit_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficInbit_nvc.Value = Inbit;
                }
                this.Command.Parameters.Add(TrafficInbit_nvc);


                SqlParameter TrafficOutbit_nvc = new SqlParameter();
                TrafficOutbit_nvc.ParameterName = "@TrafficOutbit_nvc";
                TrafficOutbit_nvc.Direction = ParameterDirection.Input;
                TrafficOutbit_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficOutbit_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Outbit))
                {
                    TrafficOutbit_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficOutbit_nvc.Value = Outbit;
                }
                this.Command.Parameters.Add(TrafficOutbit_nvc);

                SqlParameter ServicesID_nvc = new SqlParameter();
                ServicesID_nvc.ParameterName = "@ServiceID_nvc";
                ServicesID_nvc.Direction = ParameterDirection.Input;
                ServicesID_nvc.SqlDbType = SqlDbType.NVarChar;
                ServicesID_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ServicesIDnvc))
                {
                    ServicesID_nvc.Value = DBNull.Value;
                }
                else
                {
                    ServicesID_nvc.Value = ServicesIDnvc;
                }
                this.Command.Parameters.Add(ServicesID_nvc);

                SqlParameter TurnAccepted_bit = new SqlParameter();
                TurnAccepted_bit.ParameterName = "@TurnAccepted_nvc";
                TurnAccepted_bit.Direction = ParameterDirection.Input;
                TurnAccepted_bit.SqlDbType = SqlDbType.NVarChar;
                TurnAccepted_bit.IsNullable = true;
                if  (string.IsNullOrEmpty(TurnAccepted))
                {
                    TurnAccepted_bit.Value = DBNull.Value;
                }
                else
                {
                    TurnAccepted_bit.Value = TurnAccepted;
                }
                this.Command.Parameters.Add(TurnAccepted_bit);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByDriverField(string FirstName, string LastName, Int64 NationalCode, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectByDriverField]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FirstName_nvc = new SqlParameter();
                FirstName_nvc.ParameterName = "@FirstName_nvc";
                FirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvc.Direction = ParameterDirection.Input;
                FirstName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FirstName))
                {
                    FirstName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FirstName_nvc.Value = FirstName;
                }
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(LastName))
                {
                    LastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvc.Value = LastName;
                }
                this.Command.Parameters.Add(LastName_nvc);

                SqlParameter NationalCode_bint = new SqlParameter();
                NationalCode_bint.ParameterName = "@NationalCode_bint";
                NationalCode_bint.SqlDbType = SqlDbType.BigInt;
                NationalCode_bint.Direction = ParameterDirection.Input;
                NationalCode_bint.IsNullable = true;
                if (NationalCode == null || NationalCode == 0)
                {
                    NationalCode_bint.Value = DBNull.Value;
                }
                else
                {
                    NationalCode_bint.Value = NationalCode;
                }
                this.Command.Parameters.Add(NationalCode_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAutoComplete(String Condition, System.Windows.Forms.AutoCompleteStringCollection Collection)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionInAutoComplete]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                SqlDataReader dr;
                dr = Command.ExecuteReader();
                if (dr.HasRows==true)
                {
                    while (dr.Read())
                        Collection.Add(dr["trafficnumber_bint"].ToString());

                }
             
                dr.Close();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllInTrafficReport(string FromDate, string FromTime, string ToDate, string ToTime,ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_InTraffics";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllOutTrafficReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_OutTraffics";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllInServicetypeReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_InServiceType";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllOutServicetypeReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_OutServiceType";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectUsersPriceReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_UsersPrice";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectTurnAcceptedWithFields(ref System.Data.DataTable dataTable, string AcceptedTurnNumber, string TrafficNumber, string NumberPlate, string SerialPlate, string FromDate,string ToDate,string LastName)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectInTurnAcceptedWithFields]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AcceptedTurnNumber_nvc = new SqlParameter();
                AcceptedTurnNumber_nvc.ParameterName = "@AcceptedTurnNumber_nvc";
                AcceptedTurnNumber_nvc.Direction = ParameterDirection.Input;
                AcceptedTurnNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTurnNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(AcceptedTurnNumber))
                {
                    AcceptedTurnNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnNumber_nvc.Value = AcceptedTurnNumber;
                }

                this.Command.Parameters.Add(AcceptedTurnNumber_nvc);


                SqlParameter TrafficNumber_nvc = new SqlParameter();
                TrafficNumber_nvc.ParameterName = "@TrafficNumber_nvc";
                TrafficNumber_nvc.Direction = ParameterDirection.Input;
                TrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(TrafficNumber))
                {
                    TrafficNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_nvc.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(NumberPlate))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = NumberPlate;
                }

                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(SerialPlate))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = SerialPlate;
                }

                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate ))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value =FromDate ;
                }
                this.Command.Parameters.Add(FromDate_nvc);


                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate ))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate ;
                }
                this.Command.Parameters.Add(ToDate_nvc);


                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(LastName))
                {
                    LastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvc.Value = LastName ;
                }
                this.Command.Parameters.Add(LastName_nvc);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void PreviousNavigation(int TrafficTypeID, Int64? TrafficNumber, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_PreviousNavigation]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficTypeID_int = new SqlParameter();
                TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_int.SqlDbType = SqlDbType.Int;
                TrafficTypeID_int.Direction = ParameterDirection.Input;
                TrafficTypeID_int.IsNullable = false;
                TrafficTypeID_int.Value = TrafficTypeID;
                this.Command.Parameters.Add(TrafficTypeID_int);

                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.Direction = ParameterDirection.Input;
                TrafficNumber_bint.IsNullable = true;
                if (TrafficNumber.HasValue == false)
                {
                    TrafficNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_bint.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_bint);

               
                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void NextNavigation(int TrafficTypeID, Int64? TrafficNumber, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_NextNavigation]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficTypeID_int = new SqlParameter();
                TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_int.SqlDbType = SqlDbType.Int;
                TrafficTypeID_int.Direction = ParameterDirection.Input;
                TrafficTypeID_int.IsNullable = false;
                TrafficTypeID_int.Value = TrafficTypeID;
                this.Command.Parameters.Add(TrafficTypeID_int);

                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.Direction = ParameterDirection.Input;
                TrafficNumber_bint.IsNullable = true;
                if (TrafficNumber.HasValue == false)
                {
                    TrafficNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_bint.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllByConditionOut(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionOut]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void PreviousTurnNavigation(Int64? TrafficNumber, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SelectForTurnAcceptionPreviousNavigation]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.Direction = ParameterDirection.Input;
                TrafficNumber_bint.IsNullable = true;
                if (TrafficNumber.HasValue == false)
                {
                    TrafficNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_bint.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void NextTurnNavigation(Int64? TrafficNumber, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SelectForTurnAcceptionNextNavigation]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();


                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.Direction = ParameterDirection.Input;
                TrafficNumber_bint.IsNullable = true;
                if (TrafficNumber.HasValue == false)
                {
                    TrafficNumber_bint.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_bint.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_bint);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void FindLaderTypeInTraffic(string NumberPlate,string SerialPlate,Int32 PlateCityID, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_FindLaderType]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();


                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = false;
                NumberPlate_nvc.Value = NumberPlate;
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.IsNullable = false;
                SerialPlate_nvc.Value = SerialPlate;
                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter PlateCityID_int = new SqlParameter();
                PlateCityID_int.ParameterName = "@PlateCityID_int";
                PlateCityID_int.SqlDbType = SqlDbType.Int;
                PlateCityID_int.Direction = ParameterDirection.Input;
                PlateCityID_int.IsNullable = false;
                PlateCityID_int.Value = PlateCityID;
                this.Command.Parameters.Add(PlateCityID_int);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void CheckWithLadBillCreditAndTurnStatus(string AcceptedTurnNumber,string TrafficNumber,string NumberPlate,string TurnDate, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_CheckWithLadBillCreditAndTurnStatus]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AcceptedTurnNumber_nvc = new SqlParameter();
                AcceptedTurnNumber_nvc.ParameterName = "@AcceptedTurnNumber_nvc";
                AcceptedTurnNumber_nvc.Direction = ParameterDirection.Input;
                AcceptedTurnNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTurnNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(AcceptedTurnNumber))
                {
                    AcceptedTurnNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnNumber_nvc.Value = AcceptedTurnNumber;
                }

                this.Command.Parameters.Add(AcceptedTurnNumber_nvc);


                SqlParameter TrafficNumber_nvc = new SqlParameter();
                TrafficNumber_nvc.ParameterName = "@TrafficNumber_nvc";
                TrafficNumber_nvc.Direction = ParameterDirection.Input;
                TrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(TrafficNumber))
                {
                    TrafficNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_nvc.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(NumberPlate))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = NumberPlate;
                }

                this.Command.Parameters.Add(NumberPlate_nvc);


                SqlParameter TurnDate_nvc = new SqlParameter();
                TurnDate_nvc.ParameterName = "@TurnDate_nvc";
                TurnDate_nvc.Direction = ParameterDirection.Input;
                TurnDate_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(TurnDate))
                {
                    TurnDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnDate_nvc.Value = TurnDate;
                }

                this.Command.Parameters.Add(TurnDate_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
      
        public void CheckWithLadBillCreditAndTurnStatusForInsertOut(string TrafficNumber, string NumberPlate, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_CheckWithLadBillCreditAndTurnStatusForInsertOut]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();


                SqlParameter TrafficNumber_nvc = new SqlParameter();
                TrafficNumber_nvc.ParameterName = "@TrafficNumber_nvc";
                TrafficNumber_nvc.Direction = ParameterDirection.Input;
                TrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(TrafficNumber))
                {
                    TrafficNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_nvc.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(NumberPlate))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = NumberPlate;
                }

                this.Command.Parameters.Add(NumberPlate_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllInReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_AllInTraffics";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public HPS.BLL.TrafficBLL.BLLTraffic_T.TrafficStatus GetCarStatus(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_GetCarStatus]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(CarCardNumber_nvc))
                    CarCardNumber_nvcParam.Value = DBNull.Value;
                else
                    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvcParam);

                SqlParameter Status_int = new SqlParameter();
                Status_int.ParameterName = "@Status_int";
                Status_int.Direction = ParameterDirection.Output;
                Status_int.SqlDbType = SqlDbType.Int;
                Status_int.IsNullable = true;
                Status_int.Value = DBNull.Value;
                this.Command.Parameters.Add(Status_int);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }
                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }

                return (HPS.BLL.TrafficBLL.BLLTraffic_T.TrafficStatus)Status_int.Value;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void GetLastStatus(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_GetLastStatus]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(CarCardNumber_nvc))
                    CarCardNumber_nvcParam.Value = DBNull.Value;
                else
                    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvcParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public Int64 GetLastTrafficNumber()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Traffic_T_GetLastTrafficNumber]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficNumber_bint = new SqlParameter();
                TrafficNumber_bint.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bint.Direction = ParameterDirection.Output;
                TrafficNumber_bint.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bint.IsNullable = true;
                TrafficNumber_bint.Value = DBNull.Value;
                this.Command.Parameters.Add(TrafficNumber_bint);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }
                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }

                return (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficNumber_bint.Value, TypeCode.Int64);
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void GetLastStatusForAcceptTurn(Int64 TrafficID_bint, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_GetLastStatusForAcceptTurn]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                //SqlParameter NumberPlate_nvcParam = new SqlParameter();
                //NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                //NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                //NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                //NumberPlate_nvcParam.IsNullable = false;
                //NumberPlate_nvcParam.Value = NumberPlate_nvc;
                //this.Command.Parameters.Add(NumberPlate_nvcParam);

                //SqlParameter SerialPlate_nvcParam = new SqlParameter();
                //SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                //SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                //SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                //SerialPlate_nvcParam.IsNullable = false;
                //SerialPlate_nvcParam.Value = SerialPlate_nvc;
                //this.Command.Parameters.Add(SerialPlate_nvcParam);

                //SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                //CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                //CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                //CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                //CarCardNumber_nvcParam.IsNullable = true;
                //if (string.IsNullOrEmpty(CarCardNumber_nvc))
                //    CarCardNumber_nvcParam.Value = DBNull.Value;
                //else
                //    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                //this.Command.Parameters.Add(CarCardNumber_nvcParam);

                SqlParameter TrafficID_bintParam = new SqlParameter();
                TrafficID_bintParam.ParameterName = "@TrafficID_bint";
                TrafficID_bintParam.Direction = ParameterDirection.Input;
                TrafficID_bintParam.SqlDbType = SqlDbType.BigInt;
                TrafficID_bintParam.IsNullable = false;
                TrafficID_bintParam.Value = TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bintParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void GetTrafficLadBillCreditStatusForTurnAccepted(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)// string CarCardNumber_nvc,
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_LadBillCreditStatusForTurnAccepted]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                //SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                //CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                //CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                //CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                //CarCardNumber_nvcParam.IsNullable = true;
                //if (string.IsNullOrEmpty(CarCardNumber_nvc))
                //    CarCardNumber_nvcParam.Value = DBNull.Value;
                //else
                //    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                //this.Command.Parameters.Add(CarCardNumber_nvcParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void GetTrafficStatus(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_GetTrafficStatus]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(CarCardNumber_nvc))
                    CarCardNumber_nvcParam.Value = DBNull.Value;
                else
                    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvcParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void GetTurnStatus(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_TurnStatus]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                //SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                //CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                //CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                //CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                //CarCardNumber_nvcParam.IsNullable = true;
                //if (string.IsNullOrEmpty(CarCardNumber_nvc))
                //    CarCardNumber_nvcParam.Value = DBNull.Value;
                //else
                //    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                //this.Command.Parameters.Add(CarCardNumber_nvcParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectLaderTypeTurnReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_LaderTypeTurn]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAllInServiceTypeWithPivotReport(string FromDate, string FromTime, string ToDate, string ToTime, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_InServiceTypeWithPivot";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAvgAgeReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_AgeAvg]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectConditionLastTraffic(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionLastTraffic]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByConditionSelectionTraffic(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectConditionSelection]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }


 public void ReportSelectByFieds(object FromDateTime_nvc, object ToDateTime_nvc,
            object FromTrafficNumber_nvc, object ToTrafficNumber_nvc, object LaderPivotGroupID_nvc,
            object LaderTypeID_nvc, object TrafficTypeID_nvc, object TrafficInbit_nvc, object TrafficOutbit_nvc,
            object ServiceID_nvc, object TurnAccepted_nvc, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_ReportSelectByFieds]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@FromDateTime_nvc", FromDateTime_nvc));
                this.Command.Parameters.Add(new SqlParameter("@ToDateTime_nvc", ToDateTime_nvc));
                this.Command.Parameters.Add(new SqlParameter("@FromTrafficNumber_nvc", FromTrafficNumber_nvc));
                this.Command.Parameters.Add(new SqlParameter("@ToTrafficNumber_nvc", ToTrafficNumber_nvc));
                this.Command.Parameters.Add(new SqlParameter("@LaderPivotGroupID_nvc", LaderPivotGroupID_nvc));
                this.Command.Parameters.Add(new SqlParameter("@LaderTypeID_nvc", LaderTypeID_nvc));
                this.Command.Parameters.Add(new SqlParameter("@TrafficTypeID_nvc", TrafficTypeID_nvc));
                this.Command.Parameters.Add(new SqlParameter("@TrafficInbit_nvc", TrafficInbit_nvc));
                this.Command.Parameters.Add(new SqlParameter("@TrafficOutbit_nvc", TrafficOutbit_nvc));
                this.Command.Parameters.Add(new SqlParameter("@ServiceID_nvc", ServiceID_nvc));
                this.Command.Parameters.Add(new SqlParameter("@TurnAccepted_nvc", TurnAccepted_nvc));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        public void SelectDriverMobile_nvc(String Condition, ref DataTable DataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Driver_T-SelectMobile_nvc]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Condition_nvc = new SqlParameter();
                Condition_nvc.ParameterName = "@Condition";
                Condition_nvc.SqlDbType = SqlDbType.NVarChar;
                Condition_nvc.Direction = ParameterDirection.Input;
                Condition_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Condition) == false)
                {
                    Condition_nvc.Value = Condition;
                }
                else
                {
                    Condition_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(Condition_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }


                sqlDataAdapter.Fill(DataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAcceptedTurnNumber(string DriverMobile_nvc, string LaderTypeID_nvc, ref string lastLadBillCrediteTurnNumber, ref string DriverAcceptedTurnNumber_bint)
        {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T-SelectAcceptTurnNumberByMobile_nvc]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverMobile = new SqlParameter();
                DriverMobile.ParameterName = "@DriverMobile_nvc";
                DriverMobile.SqlDbType = SqlDbType.NVarChar;
                DriverMobile.Direction = ParameterDirection.Input;
                DriverMobile.IsNullable = true;
                if (string.IsNullOrEmpty(DriverMobile_nvc) == false)
                {
                    DriverMobile.Value = DriverMobile_nvc;
                }
                else
                {
                    DriverMobile.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(DriverMobile);


                SqlParameter LaderTypeID = new SqlParameter();
                LaderTypeID.ParameterName = "@LaderTypeID_nvc";
                LaderTypeID.SqlDbType = SqlDbType.NVarChar;
                LaderTypeID.Direction = ParameterDirection.Input;
                LaderTypeID.IsNullable = true;
                if (string.IsNullOrEmpty(LaderTypeID_nvc) == false)
                {
                    LaderTypeID.Value = LaderTypeID_nvc;
                }
                else
                {
                    LaderTypeID.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(LaderTypeID);


                SqlParameter lastLadBillCrediteTurnNumber_bint = new SqlParameter();
                lastLadBillCrediteTurnNumber_bint.ParameterName = "@lastLadBillCrediteTurnNumber";
                lastLadBillCrediteTurnNumber_bint.SqlDbType = SqlDbType.BigInt;
                lastLadBillCrediteTurnNumber_bint.Direction = ParameterDirection.Output ;
                lastLadBillCrediteTurnNumber_bint.IsNullable = true;
                lastLadBillCrediteTurnNumber_bint.Value = DBNull.Value;
                this.Command.Parameters.Add(lastLadBillCrediteTurnNumber_bint);

                SqlParameter DriverAcceptedTurnNumber = new SqlParameter();
                DriverAcceptedTurnNumber.ParameterName = "@DriverAcceptedTurnNumber_bint";
                DriverAcceptedTurnNumber.SqlDbType = SqlDbType.BigInt;
                DriverAcceptedTurnNumber.Direction = ParameterDirection.Output;
                DriverAcceptedTurnNumber.IsNullable = true;
                DriverAcceptedTurnNumber.Value = DBNull.Value;
                this.Command.Parameters.Add(DriverAcceptedTurnNumber);

                
                if (ControlConnection)
                {
                    this.BeginTransaction();
                }


                Command.ExecuteNonQuery();


                if (Command.Parameters["@lastLadBillCrediteTurnNumber"].Value != DBNull.Value)
                {
                    lastLadBillCrediteTurnNumber = Command.Parameters["@lastLadBillCrediteTurnNumber"].Value.ToString();

                }


                if (Command.Parameters["@DriverAcceptedTurnNumber_bint"].Value != DBNull.Value)
                {
                    DriverAcceptedTurnNumber_bint = Command.Parameters["@DriverAcceptedTurnNumber_bint"].Value.ToString();

                }

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectRemainedLaderTypeCountReport(string FromDate, string ToDate,DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_GetRemainedLaderTypeCount";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);


                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);
                this.Command.CommandTimeout = 600;
                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectRemainedAcceptedTurnNumberByLaderTypeReport(string FromDate, string ToDate, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_RemainedAcceptedTurnNumberByLaderType";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);


                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);
                this.Command.CommandTimeout = 300;

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectInTurnAcceptedForDelete(string ToDate,string LaderTypeID_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_SelectInTurnAcceptedForDelete";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = false;
                ToDate_nvc.Value = ToDate;
                this.Command.Parameters.Add(ToDate_nvc);


                SqlParameter LaderTypeID_nvcParam = new SqlParameter();
                LaderTypeID_nvcParam.ParameterName = "@LaderTypeID_nvc";
                LaderTypeID_nvcParam.Direction = ParameterDirection.Input;
                LaderTypeID_nvcParam.SqlDbType = SqlDbType.NVarChar;
                LaderTypeID_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(LaderTypeID_nvc))
                {
                    LaderTypeID_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeID_nvcParam.Value = LaderTypeID_nvc;
                }

                this.Command.Parameters.Add(LaderTypeID_nvcParam);
               
                this.Command.CommandTimeout = 300;

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        public void SelectByPlate(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_SelectByPlate";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter numberPlate_nvc = new SqlParameter();
                numberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                numberPlate_nvc.Direction = ParameterDirection.Input;
                numberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                numberPlate_nvc.IsNullable = false;
                numberPlate_nvc.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(numberPlate_nvc);


                SqlParameter serialPlate_nvc = new SqlParameter();
                serialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                serialPlate_nvc.Direction = ParameterDirection.Input;
                serialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                serialPlate_nvc.IsNullable = false;
                serialPlate_nvc.Value = SerialPlate_nvc;

                this.Command.Parameters.Add(serialPlate_nvc);

                this.Command.CommandTimeout = 300;

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        public void SelectDriverDuplicateNumber(string DriverMobileNumber_nvc, Int64? NationalCode_bint, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_TSelectDuplicateMobileNumber";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverMobileNumber_nvcParam = new SqlParameter();
                DriverMobileNumber_nvcParam.ParameterName = "@DriverMobileNumber_nvc";
                DriverMobileNumber_nvcParam.Direction = ParameterDirection.Input;
                DriverMobileNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                DriverMobileNumber_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(DriverMobileNumber_nvc))
                {
                    DriverMobileNumber_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    DriverMobileNumber_nvcParam.Value = DriverMobileNumber_nvc;
                }
                this.Command.Parameters.Add(DriverMobileNumber_nvcParam);
               
                SqlParameter NationalCode_bintParam = new SqlParameter();
                NationalCode_bintParam.ParameterName = "@NationalCode_bint";
                NationalCode_bintParam.Direction = ParameterDirection.Input;
                NationalCode_bintParam.SqlDbType = SqlDbType.NVarChar;
                NationalCode_bintParam.IsNullable = true;
                if (NationalCode_bint.HasValue==false)
                {
                    NationalCode_bintParam.Value = DBNull.Value;
                }
                else
                {
                    NationalCode_bintParam.Value = NationalCode_bint;
                }
                this.Command.Parameters.Add(NationalCode_bintParam);

                

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectRemainedAcceptedTurnNumberByLaderTypeWithDateReport(string FromDate,string FromTime,string ToTime, string ToDate, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_RemainedAcceptedTurnNumberByLaderTypeWithDate";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);


                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }
                this.Command.Parameters.Add(ToDate_nvc);
                /////////////

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;

                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }
                this.Command.Parameters.Add(FromTime_nvc);


                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                /////////////////


                
                this.Command.CommandTimeout = 300;

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectTurnAcceptedWithoutLadBill(ref System.Data.DataTable dataTable, string AcceptedTurnNumber, string TrafficNumber, string NumberPlate, string SerialPlate, string FromDate, string ToDate, string LastName)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_TurnAcceptedWithoutLadBill]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AcceptedTurnNumber_nvc = new SqlParameter();
                AcceptedTurnNumber_nvc.ParameterName = "@AcceptedTurnNumber_nvc";
                AcceptedTurnNumber_nvc.Direction = ParameterDirection.Input;
                AcceptedTurnNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTurnNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(AcceptedTurnNumber))
                {
                    AcceptedTurnNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTurnNumber_nvc.Value = AcceptedTurnNumber;
                }

                this.Command.Parameters.Add(AcceptedTurnNumber_nvc);


                SqlParameter TrafficNumber_nvc = new SqlParameter();
                TrafficNumber_nvc.ParameterName = "@TrafficNumber_nvc";
                TrafficNumber_nvc.Direction = ParameterDirection.Input;
                TrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(TrafficNumber))
                {
                    TrafficNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    TrafficNumber_nvc.Value = TrafficNumber;
                }

                this.Command.Parameters.Add(TrafficNumber_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(NumberPlate))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = NumberPlate;
                }

                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(SerialPlate))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = SerialPlate;
                }

                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }
                this.Command.Parameters.Add(FromDate_nvc);


                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }
                this.Command.Parameters.Add(ToDate_nvc);


                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(LastName))
                {
                    LastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvc.Value = LastName;
                }
                this.Command.Parameters.Add(LastName_nvc);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void TurnAndLadeAssignmentInfoByLaderTypeReport(string FromDate, string FromTime, string ToDate, string ToTime, Int32? ladertypeID_int, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_TurnAndLadeAssignmentInfoByLaderType]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);
                this.Command.CommandTimeout = 120000;
                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                SqlParameter laderTypeID_intParam = new SqlParameter();
                laderTypeID_intParam.ParameterName = "@LaderTypeID_int";
                laderTypeID_intParam.Direction = ParameterDirection.Input;
                laderTypeID_intParam.SqlDbType = SqlDbType.Int;
                laderTypeID_intParam.IsNullable = true;
                if (ladertypeID_int.HasValue)
                {
                    laderTypeID_intParam.Value = ladertypeID_int;
                }
                else
                {
                    laderTypeID_intParam.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(laderTypeID_intParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void DuplicateTurnsReport(DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_SelectDuplicateTurns";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                //SqlParameter FromDate_nvc = new SqlParameter();
                //FromDate_nvc.ParameterName = "@FromDate_nvc";
                //FromDate_nvc.Direction = ParameterDirection.Input;
                //FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                //FromDate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(FromDate))
                //{
                //    FromDate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    FromDate_nvc.Value = FromDate;
                //}

                //this.Command.Parameters.Add(FromDate_nvc);

                //SqlParameter ToDate_nvc = new SqlParameter();
                //ToDate_nvc.ParameterName = "@ToDate_nvc";
                //ToDate_nvc.Direction = ParameterDirection.Input;
                //ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                //ToDate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(ToDate))
                //{
                //    ToDate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    ToDate_nvc.Value = ToDate;
                //}

                //this.Command.Parameters.Add(ToDate_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        public void SelectDuplicateTurnByDrivers(DataTable dataTable,String NationCode)
        {

            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_Traffic_T_SelectDuplicateTurnByDriver";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardNumber = new SqlParameter();
                CardNumber.ParameterName = "@NationCode";
                CardNumber.Direction = ParameterDirection.Input;
                CardNumber.SqlDbType = SqlDbType.NVarChar;
                CardNumber.IsNullable = true;
                if (string.IsNullOrEmpty(NationCode))
                {
                    CardNumber.Value = DBNull.Value;
                }
                else
                {
                    CardNumber.Value = NationCode;
                }

                this.Command.Parameters.Add(CardNumber);

                //SqlParameter ToDate_nvc = new SqlParameter();
                //ToDate_nvc.ParameterName = "@ToDate_nvc";
                //ToDate_nvc.Direction = ParameterDirection.Input;
                //ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                //ToDate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(ToDate))
                //{
                //    ToDate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    ToDate_nvc.Value = ToDate;
                //}

                //this.Command.Parameters.Add(ToDate_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void WaitingLaderTypesReport(string FromDate, string FromTime, string ToDate, string ToTime, Int32? ladertypeID_int, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_WaitingLaderTypes]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                SqlParameter laderTypeID_intParam = new SqlParameter();
                laderTypeID_intParam.ParameterName = "@LaderTypeID_int";
                laderTypeID_intParam.Direction = ParameterDirection.Input;
                laderTypeID_intParam.SqlDbType = SqlDbType.Int;
                laderTypeID_intParam.IsNullable = true;
                if (ladertypeID_int.HasValue)
                {
                    laderTypeID_intParam.Value = ladertypeID_int;
                }
                else
                {
                    laderTypeID_intParam.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(laderTypeID_intParam);

                this.Command.CommandTimeout = 500;
                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectInNotOutCount(Int32 TrafficTypeID_int, System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_SelectInNotOutCount]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficTypeID_intParam = new SqlParameter();
                TrafficTypeID_intParam.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_intParam.Direction = ParameterDirection.Input;
                TrafficTypeID_intParam.SqlDbType = SqlDbType.Int;
                TrafficTypeID_intParam.IsNullable = false;
                TrafficTypeID_intParam.Value = TrafficTypeID_int;
                this.Command.Parameters.Add(TrafficTypeID_intParam);
                
                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAcceptedTurns(System.Data.DataTable dataTable, string condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_AcceptedTurns]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                //SqlParameter AcceptedTurnNumber_nvc = new SqlParameter();
                //AcceptedTurnNumber_nvc.ParameterName = "@AcceptedTurnNumber_nvc";
                //AcceptedTurnNumber_nvc.Direction = ParameterDirection.Input;
                //AcceptedTurnNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                //AcceptedTurnNumber_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(AcceptedTurnNumber))
                //{
                //    AcceptedTurnNumber_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    AcceptedTurnNumber_nvc.Value = AcceptedTurnNumber;
                //}

                //this.Command.Parameters.Add(AcceptedTurnNumber_nvc);


                //SqlParameter TrafficNumber_nvc = new SqlParameter();
                //TrafficNumber_nvc.ParameterName = "@TrafficNumber_nvc";
                //TrafficNumber_nvc.Direction = ParameterDirection.Input;
                //TrafficNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                //TrafficNumber_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(TrafficNumber))
                //{
                //    TrafficNumber_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    TrafficNumber_nvc.Value = TrafficNumber;
                //}

                //this.Command.Parameters.Add(TrafficNumber_nvc);

                //SqlParameter NumberPlate_nvc = new SqlParameter();
                //NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                //NumberPlate_nvc.Direction = ParameterDirection.Input;
                //NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                //NumberPlate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(NumberPlate))
                //{
                //    NumberPlate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    NumberPlate_nvc.Value = NumberPlate;
                //}

                //this.Command.Parameters.Add(NumberPlate_nvc);

                //SqlParameter SerialPlate_nvc = new SqlParameter();
                //SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                //SerialPlate_nvc.Direction = ParameterDirection.Input;
                //SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                //SerialPlate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(SerialPlate))
                //{
                //    SerialPlate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    SerialPlate_nvc.Value = SerialPlate;
                //}

                //this.Command.Parameters.Add(SerialPlate_nvc);

                //SqlParameter FromDate_nvc = new SqlParameter();
                //FromDate_nvc.ParameterName = "@FromDate_nvc";
                //FromDate_nvc.Direction = ParameterDirection.Input;
                //FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                //FromDate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(FromDate ))
                //{
                //    FromDate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    FromDate_nvc.Value =FromDate ;
                //}
                //this.Command.Parameters.Add(FromDate_nvc);


                //SqlParameter ToDate_nvc = new SqlParameter();
                //ToDate_nvc.ParameterName = "@ToDate_nvc";
                //ToDate_nvc.Direction = ParameterDirection.Input;
                //ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                //ToDate_nvc.IsNullable = true;
                //if (string.IsNullOrEmpty(ToDate ))
                //{
                //    ToDate_nvc.Value = DBNull.Value;
                //}
                //else
                //{
                //    ToDate_nvc.Value = ToDate ;
                //}
                //this.Command.Parameters.Add(ToDate_nvc);


                SqlParameter condition_nvc = new SqlParameter();
                condition_nvc.ParameterName = "@condition_nvc";
                condition_nvc.Direction = ParameterDirection.Input;
                condition_nvc.SqlDbType = SqlDbType.NVarChar;
                condition_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(condition))
                {
                    condition_nvc.Value = DBNull.Value;
                }
                else
                {
                    condition_nvc.Value = condition ;
                }
                this.Command.Parameters.Add(condition_nvc);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
     
        public void SelectCanceledTurns(string FromDate_nvc, string ToDate_nvc, string FromTime_nvc, string ToTime_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_CanceledTurns]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvcParam = new SqlParameter();
                FromDate_nvcParam.ParameterName = "@FromDate_nvc";
                FromDate_nvcParam.Direction = ParameterDirection.Input;
                FromDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate_nvc))
                {
                    FromDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvcParam.Value = FromDate_nvc;
                }

                this.Command.Parameters.Add(FromDate_nvcParam);

                SqlParameter FromTime_nvcParam = new SqlParameter();
                FromTime_nvcParam.ParameterName = "@FromTime_nvc";
                FromTime_nvcParam.Direction = ParameterDirection.Input;
                FromTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime_nvc))
                {
                    FromTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvcParam.Value = FromTime_nvc;
                }

                this.Command.Parameters.Add(FromTime_nvcParam);

                SqlParameter ToDate_nvcParam = new SqlParameter();
                ToDate_nvcParam.ParameterName = "@ToDate_nvc";
                ToDate_nvcParam.Direction = ParameterDirection.Input;
                ToDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate_nvc))
                {
                    ToDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvcParam.Value = ToDate_nvc;
                }

                this.Command.Parameters.Add(ToDate_nvcParam);

                SqlParameter ToTime_nvcParam = new SqlParameter();
                ToTime_nvcParam.ParameterName = "@ToTime_nvc";
                ToTime_nvcParam.Direction = ParameterDirection.Input;
                ToTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime_nvc))
                {
                    ToTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvcParam.Value = ToTime_nvc;
                }

                this.Command.Parameters.Add(ToTime_nvcParam);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        internal void SelectActiveTurns(string FromDate_nvc, string ToDate_nvc, string FromTime_nvc, string ToTime_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_ActiveTurns]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvcParam = new SqlParameter();
                FromDate_nvcParam.ParameterName = "@FromDate_nvc";
                FromDate_nvcParam.Direction = ParameterDirection.Input;
                FromDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate_nvc))
                {
                    FromDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvcParam.Value = FromDate_nvc;
                }

                this.Command.Parameters.Add(FromDate_nvcParam);

                SqlParameter FromTime_nvcParam = new SqlParameter();
                FromTime_nvcParam.ParameterName = "@FromTime_nvc";
                FromTime_nvcParam.Direction = ParameterDirection.Input;
                FromTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime_nvc))
                {
                    FromTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvcParam.Value = FromTime_nvc;
                }

                this.Command.Parameters.Add(FromTime_nvcParam);

                SqlParameter ToDate_nvcParam = new SqlParameter();
                ToDate_nvcParam.ParameterName = "@ToDate_nvc";
                ToDate_nvcParam.Direction = ParameterDirection.Input;
                ToDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate_nvc))
                {
                    ToDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvcParam.Value = ToDate_nvc;
                }

                this.Command.Parameters.Add(ToDate_nvcParam);

                SqlParameter ToTime_nvcParam = new SqlParameter();
                ToTime_nvcParam.ParameterName = "@ToTime_nvc";
                ToTime_nvcParam.Direction = ParameterDirection.Input;
                ToTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime_nvc))
                {
                    ToTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvcParam.Value = ToTime_nvc;
                }

                this.Command.Parameters.Add(ToTime_nvcParam);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        internal void SelectReturnedTurns(string FromDate_nvc, string ToDate_nvc, string FromTime_nvc, string ToTime_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_ReturnedTurns]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvcParam = new SqlParameter();
                FromDate_nvcParam.ParameterName = "@FromDate_nvc";
                FromDate_nvcParam.Direction = ParameterDirection.Input;
                FromDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate_nvc))
                {
                    FromDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvcParam.Value = FromDate_nvc;
                }

                this.Command.Parameters.Add(FromDate_nvcParam);

                SqlParameter FromTime_nvcParam = new SqlParameter();
                FromTime_nvcParam.ParameterName = "@FromTime_nvc";
                FromTime_nvcParam.Direction = ParameterDirection.Input;
                FromTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime_nvc))
                {
                    FromTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvcParam.Value = FromTime_nvc;
                }

                this.Command.Parameters.Add(FromTime_nvcParam);

                SqlParameter ToDate_nvcParam = new SqlParameter();
                ToDate_nvcParam.ParameterName = "@ToDate_nvc";
                ToDate_nvcParam.Direction = ParameterDirection.Input;
                ToDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate_nvc))
                {
                    ToDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvcParam.Value = ToDate_nvc;
                }

                this.Command.Parameters.Add(ToDate_nvcParam);

                SqlParameter ToTime_nvcParam = new SqlParameter();
                ToTime_nvcParam.ParameterName = "@ToTime_nvc";
                ToTime_nvcParam.Direction = ParameterDirection.Input;
                ToTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime_nvc))
                {
                    ToTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvcParam.Value = ToTime_nvc;
                }

                this.Command.Parameters.Add(ToTime_nvcParam);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        internal void SelectActiveTurnsForInTraffic(string NumberPlate_nvc,string SerialPlate_nvc, string FromDate_nvc, string ToDate_nvc, string FromTime_nvc, string ToTime_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_ActiveTurnsForInTraffic]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvcParam = new SqlParameter();
                FromDate_nvcParam.ParameterName = "@FromDate_nvc";
                FromDate_nvcParam.Direction = ParameterDirection.Input;
                FromDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate_nvc))
                {
                    FromDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvcParam.Value = FromDate_nvc;
                }

                this.Command.Parameters.Add(FromDate_nvcParam);

                SqlParameter FromTime_nvcParam = new SqlParameter();
                FromTime_nvcParam.ParameterName = "@FromTime_nvc";
                FromTime_nvcParam.Direction = ParameterDirection.Input;
                FromTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime_nvc))
                {
                    FromTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvcParam.Value = FromTime_nvc;
                }

                this.Command.Parameters.Add(FromTime_nvcParam);

                SqlParameter ToDate_nvcParam = new SqlParameter();
                ToDate_nvcParam.ParameterName = "@ToDate_nvc";
                ToDate_nvcParam.Direction = ParameterDirection.Input;
                ToDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate_nvc))
                {
                    ToDate_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvcParam.Value = ToDate_nvc;
                }

                this.Command.Parameters.Add(ToDate_nvcParam);

                SqlParameter ToTime_nvcParam = new SqlParameter();
                ToTime_nvcParam.ParameterName = "@ToTime_nvc";
                ToTime_nvcParam.Direction = ParameterDirection.Input;
                ToTime_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime_nvc))
                {
                    ToTime_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvcParam.Value = ToTime_nvc;
                }

                this.Command.Parameters.Add(ToTime_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);
               

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }
                if (dataTable == null) dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void LadeAssignmentInfoByLaderType(string FromDate, string FromTime, string ToDate, string ToTime, Int32? ladertypeID_int, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_LadeAssignmentInfoByLaderType]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);
                this.Command.CommandTimeout = 120000;
                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                SqlParameter laderTypeID_intParam = new SqlParameter();
                laderTypeID_intParam.ParameterName = "@LaderTypeID_int";
                laderTypeID_intParam.Direction = ParameterDirection.Input;
                laderTypeID_intParam.SqlDbType = SqlDbType.Int;
                laderTypeID_intParam.IsNullable = true;
                if (ladertypeID_int.HasValue)
                {
                    laderTypeID_intParam.Value = ladertypeID_int;
                }
                else
                {
                    laderTypeID_intParam.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(laderTypeID_intParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        //***********************************نوع و تاریخ آخرین مراجعه به پایانه گزارش 93-06-17
        public void SelectTypeandLasteIn(string FromDate_vc, string ToDate_vc, string FromTime_vc, string ToTime_vc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_TypeandLastInReport]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_vcParam = new SqlParameter();
                FromDate_vcParam.ParameterName = "@FromDate_nvc";
                FromDate_vcParam.SqlDbType = SqlDbType.VarChar;
                FromDate_vcParam.Direction = ParameterDirection.Input;
                FromDate_vcParam.IsNullable = false;
                FromDate_vcParam.Value = FromDate_vc;
                this.Command.Parameters.Add(FromDate_vcParam);

                SqlParameter ToDate_vcParam = new SqlParameter();
                ToDate_vcParam.ParameterName = "@ToDate_nvc";
                ToDate_vcParam.SqlDbType = SqlDbType.VarChar;
                ToDate_vcParam.Direction = ParameterDirection.Input;
                ToDate_vcParam.IsNullable = false;
                ToDate_vcParam.Value = ToDate_vc;
                this.Command.Parameters.Add(ToDate_vcParam);

                SqlParameter FromTime_vcParam = new SqlParameter();
                FromTime_vcParam.ParameterName = "@FromTime_nvc";
                FromTime_vcParam.SqlDbType = SqlDbType.VarChar;
                FromTime_vcParam.Direction = ParameterDirection.Input;
                FromTime_vcParam.IsNullable = false;
                FromTime_vcParam.Value = FromDate_vc;
                this.Command.Parameters.Add(FromTime_vcParam);

                SqlParameter ToTime_vcParam = new SqlParameter();
                ToTime_vcParam.ParameterName = "@ToTime_nvc";
                ToTime_vcParam.SqlDbType = SqlDbType.VarChar;
                ToTime_vcParam.Direction = ParameterDirection.Input;
                ToTime_vcParam.IsNullable = false;
                ToTime_vcParam.Value = ToDate_vc;
                this.Command.Parameters.Add(ToTime_vcParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }
        //***********************************8


       
    }
}