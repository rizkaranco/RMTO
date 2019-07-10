using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CarDAL
{
    class DALCar_T : DataLayerBase
    {

        public DALCar_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.CarBLL.BLLCar_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Output;
                CarID_int.IsNullable = false;
                CarID_int.Value = businessObject.CarID_int;
                this.Command.Parameters.Add(CarID_int);

                SqlParameter CarCardDate_nvc = new SqlParameter();
                CarCardDate_nvc.ParameterName = "@CarCardDate_nvc";
                CarCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardDate_nvc.Direction = ParameterDirection.Input;
                CarCardDate_nvc.IsNullable = false;
                CarCardDate_nvc.Value = businessObject.CarCardDate_nvc;
                this.Command.Parameters.Add(CarCardDate_nvc);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = false;
                CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvc);

                SqlParameter PlateType_nvc = new SqlParameter();
                PlateType_nvc.ParameterName = "@PlateType_nvc";
                PlateType_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateType_nvc.Direction = ParameterDirection.Input;
                PlateType_nvc.IsNullable = false;
                PlateType_nvc.Value = businessObject.PlateType_nvc;
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
                CountryID_int.IsNullable = false;
                CountryID_int.Value = businessObject.CountryID_int;
                this.Command.Parameters.Add(CountryID_int);

                SqlParameter CountryCode_nvc = new SqlParameter();
                CountryCode_nvc.ParameterName = "@CountryCode_nvc";
                CountryCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CountryCode_nvc.Direction = ParameterDirection.Input;
                CountryCode_nvc.IsNullable = false;
                CountryCode_nvc.Value = businessObject.CountryCode_nvc;
                this.Command.Parameters.Add(CountryCode_nvc);

                SqlParameter Country_nvc = new SqlParameter();
                Country_nvc.ParameterName = "@Country_nvc";
                Country_nvc.SqlDbType = SqlDbType.NVarChar;
                Country_nvc.Direction = ParameterDirection.Input;
                Country_nvc.IsNullable = false;
                Country_nvc.Value = businessObject.Country_nvc;
                this.Command.Parameters.Add(Country_nvc);

                SqlParameter YearType_nvc = new SqlParameter();
                YearType_nvc.ParameterName = "@YearType_nvc";
                YearType_nvc.SqlDbType = SqlDbType.NVarChar;
                YearType_nvc.Direction = ParameterDirection.Input;
                YearType_nvc.IsNullable = false;
                YearType_nvc.Value = businessObject.YearType_nvc;
                this.Command.Parameters.Add(YearType_nvc);

                SqlParameter ProductionYear_int = new SqlParameter();
                ProductionYear_int.ParameterName = "@ProductionYear_int";
                ProductionYear_int.SqlDbType = SqlDbType.Int;
                ProductionYear_int.Direction = ParameterDirection.Input;
                ProductionYear_int.IsNullable = false;
                ProductionYear_int.Value = businessObject.ProductionYear_int;
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
                if (String.IsNullOrEmpty(businessObject.System_nvc))
                {
                    System_nvc.Value = DBNull.Value;
                }
                else
                {
                    System_nvc.Value = businessObject.System_nvc;
                }
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

                SqlParameter InfractionGroupID_int = new SqlParameter();
                InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
                InfractionGroupID_int.SqlDbType = SqlDbType.Int;
                InfractionGroupID_int.Direction = ParameterDirection.Input;
                InfractionGroupID_int.IsNullable = true;
                if (businessObject.InfractionGroupID_int.HasValue == false)
                {
                    InfractionGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
                }
                this.Command.Parameters.Add(InfractionGroupID_int);

                SqlParameter InsertDate_nvc = new SqlParameter();
                InsertDate_nvc.ParameterName = "@InsertDate_nvc";
                InsertDate_nvc.SqlDbType = SqlDbType.NVarChar;
                InsertDate_nvc.Direction = ParameterDirection.Input;
                InsertDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.InsertDate_nvc))
                {
                    InsertDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    InsertDate_nvc.Value = businessObject.InsertDate_nvc;
                }
                this.Command.Parameters.Add(InsertDate_nvc);

                SqlParameter UpdateDate_nvc = new SqlParameter();
                UpdateDate_nvc.ParameterName = "@UpdateDate_nvc";
                UpdateDate_nvc.SqlDbType = SqlDbType.NVarChar;
                UpdateDate_nvc.Direction = ParameterDirection.Input;
                UpdateDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.UpdateDate_nvc))
                {
                    UpdateDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    UpdateDate_nvc.Value = businessObject.UpdateDate_nvc;
                }
                this.Command.Parameters.Add(UpdateDate_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter Deleted_bit = new SqlParameter();
                Deleted_bit.ParameterName = "@Deleted_bit";
                Deleted_bit.SqlDbType = SqlDbType.Bit;
                Deleted_bit.Direction = ParameterDirection.Input;
                Deleted_bit.IsNullable = false;
                Deleted_bit.Value = businessObject.Deleted_bit;
                this.Command.Parameters.Add(Deleted_bit);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.CarID_int = (Int32)(this.Command.Parameters["@CarID_int"].Value);

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

        public void Update(HPS.BLL.CarBLL.BLLCar_T businessObject, HPS.BLL.CarBLL.BLLCar_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarCardDate_nvc = new SqlParameter();
                CarCardDate_nvc.ParameterName = "@CarCardDate_nvc";
                CarCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardDate_nvc.Direction = ParameterDirection.Input;
                CarCardDate_nvc.IsNullable = false;
                CarCardDate_nvc.Value = businessObject.CarCardDate_nvc;
                this.Command.Parameters.Add(CarCardDate_nvc);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = false;
                CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvc);

                SqlParameter PlateType_nvc = new SqlParameter();
                PlateType_nvc.ParameterName = "@PlateType_nvc";
                PlateType_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateType_nvc.Direction = ParameterDirection.Input;
                PlateType_nvc.IsNullable = false;
                PlateType_nvc.Value = businessObject.PlateType_nvc;
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
                CountryID_int.Value = businessObject.CountryID_int;
                this.Command.Parameters.Add(CountryID_int);

                SqlParameter CountryCode_nvc = new SqlParameter();
                CountryCode_nvc.ParameterName = "@CountryCode_nvc";
                CountryCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CountryCode_nvc.Direction = ParameterDirection.Input;
                CountryCode_nvc.IsNullable = false;
                CountryCode_nvc.Value = businessObject.CountryCode_nvc;
                this.Command.Parameters.Add(CountryCode_nvc);

                SqlParameter Country_nvc = new SqlParameter();
                Country_nvc.ParameterName = "@Country_nvc";
                Country_nvc.SqlDbType = SqlDbType.NVarChar;
                Country_nvc.Direction = ParameterDirection.Input;
                Country_nvc.IsNullable = false;
                Country_nvc.Value = businessObject.Country_nvc;
                this.Command.Parameters.Add(Country_nvc);

                SqlParameter YearType_nvc = new SqlParameter();
                YearType_nvc.ParameterName = "@YearType_nvc";
                YearType_nvc.SqlDbType = SqlDbType.NVarChar;
                YearType_nvc.Direction = ParameterDirection.Input;
                YearType_nvc.IsNullable = false;
                YearType_nvc.Value = businessObject.YearType_nvc;
                this.Command.Parameters.Add(YearType_nvc);

                SqlParameter ProductionYear_int = new SqlParameter();
                ProductionYear_int.ParameterName = "@ProductionYear_int";
                ProductionYear_int.SqlDbType = SqlDbType.Int;
                ProductionYear_int.Direction = ParameterDirection.Input;
                ProductionYear_int.IsNullable = false;
                ProductionYear_int.Value = businessObject.ProductionYear_int;
                this.Command.Parameters.Add(ProductionYear_int);

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
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
                if (String.IsNullOrEmpty(businessObject.System_nvc))
                {
                    System_nvc.Value = DBNull.Value;
                }
                else
                {
                    System_nvc.Value = businessObject.System_nvc;
                }
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

                SqlParameter InfractionGroupID_int = new SqlParameter();
                InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
                InfractionGroupID_int.SqlDbType = SqlDbType.Int;
                InfractionGroupID_int.Direction = ParameterDirection.Input;
                InfractionGroupID_int.IsNullable = true;
                if (businessObject.InfractionGroupID_int.HasValue == false)
                {
                    InfractionGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
                }
                this.Command.Parameters.Add(InfractionGroupID_int);

                SqlParameter InsertDate_nvc = new SqlParameter();
                InsertDate_nvc.ParameterName = "@InsertDate_nvc";
                InsertDate_nvc.SqlDbType = SqlDbType.NVarChar;
                InsertDate_nvc.Direction = ParameterDirection.Input;
                InsertDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.InsertDate_nvc))
                {
                    InsertDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    InsertDate_nvc.Value = businessObject.InsertDate_nvc;
                }
                this.Command.Parameters.Add(InsertDate_nvc);

                SqlParameter UpdateDate_nvc = new SqlParameter();
                UpdateDate_nvc.ParameterName = "@UpdateDate_nvc";
                UpdateDate_nvc.SqlDbType = SqlDbType.NVarChar;
                UpdateDate_nvc.Direction = ParameterDirection.Input;
                UpdateDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.UpdateDate_nvc))
                {
                    UpdateDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    UpdateDate_nvc.Value = businessObject.UpdateDate_nvc;
                }
                this.Command.Parameters.Add(UpdateDate_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = true;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter Deleted_bit = new SqlParameter();
                Deleted_bit.ParameterName = "@Deleted_bit";
                Deleted_bit.SqlDbType = SqlDbType.Bit;
                Deleted_bit.Direction = ParameterDirection.Input;
                Deleted_bit.IsNullable = false;
                Deleted_bit.Value = businessObject.Deleted_bit;
                this.Command.Parameters.Add(Deleted_bit);


                SqlParameter pk_CarID_int = new SqlParameter();
                pk_CarID_int.ParameterName = "@pk_CarID_int";
                pk_CarID_int.SqlDbType = SqlDbType.Int;
                pk_CarID_int.Direction = ParameterDirection.Input;
                pk_CarID_int.IsNullable = false;
                pk_CarID_int.Value = businessObjectKey.CarID_int;
                this.Command.Parameters.Add(pk_CarID_int);



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

        public List<HPS.BLL.CarBLL.BLLCar_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CarBLL.BLLCar_T> Result = new List<HPS.BLL.CarBLL.BLLCar_T>();
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
            this.Command.CommandText = "[sp_Car_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Car_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Car_T_SelectAll]";
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

        public HPS.BLL.CarBLL.BLLCar_T SelectByPrimaryKey(HPS.BLL.CarBLL.BLLCar_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = false;
                CarID_int.Value = businessObjectKey.CarID_int;
                this.Command.Parameters.Add(CarID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.CarBLL.BLLCar_T businessObject = new HPS.BLL.CarBLL.BLLCar_T();
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

        public void SelectByPrimaryKey(HPS.BLL.CarBLL.BLLCar_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Car_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = false;
                CarID_int.Value = businessObjectKey.CarID_int;
                this.Command.Parameters.Add(CarID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CarBLL.BLLCar_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Car_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = false;
                CarID_int.Value = businessObjectKey.CarID_int;
                this.Command.Parameters.Add(CarID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CarBLL.BLLCar_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Car_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = false;
                CarID_int.Value = businessObjectKey.CarID_int;
                this.Command.Parameters.Add(CarID_int);



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

        public List<HPS.BLL.CarBLL.BLLCar_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Car_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CarBLL.BLLCar_T> Result = new List<HPS.BLL.CarBLL.BLLCar_T>();
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
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Car_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Car_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Car_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.CarBLL.BLLCar_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
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
                List<HPS.BLL.CarBLL.BLLCar_T> Result = new List<HPS.BLL.CarBLL.BLLCar_T>();
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
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Car_T_SelectCondition]";
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

        public void Delete(HPS.BLL.CarBLL.BLLCar_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CarID_int = new SqlParameter();
                CarID_int.ParameterName = "@CarID_int";
                CarID_int.SqlDbType = SqlDbType.Int;
                CarID_int.Direction = ParameterDirection.Input;
                CarID_int.IsNullable = false;
                CarID_int.Value = businessObjectKey.CarID_int;
                this.Command.Parameters.Add(CarID_int);


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
            this.Command.CommandText = "[sp_Car_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.CarBLL.BLLCar_T businessObject, IDataReader dataReader)
        {
            businessObject.CarID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarID_int.ToString()));
            businessObject.CarCardDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarCardDate_nvc.ToString()));
            businessObject.CarCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CarCardNumber_nvc.ToString()));
            businessObject.PlateType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateType_nvc.ToString()));
            businessObject.NumberPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.NumberPlate_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.SerialPlate_nvc.ToString())) == false)
            {
                businessObject.SerialPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.SerialPlate_nvc.ToString()));
            }
            else
            {
                businessObject.SerialPlate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateCityID_int.ToString())) == false)
            {
                businessObject.PlateCityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateCityID_int.ToString()));
            }
            else
            {
                businessObject.PlateCityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateColorID_int.ToString())) == false)
            {
                businessObject.PlateColorID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.PlateColorID_int.ToString()));
            }
            else
            {
                businessObject.PlateColorID_int = null;
            }

            businessObject.CountryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CountryID_int.ToString()));
            businessObject.CountryCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.CountryCode_nvc.ToString()));
            businessObject.Country_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.Country_nvc.ToString()));
            businessObject.YearType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.YearType_nvc.ToString()));
            businessObject.ProductionYear_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.ProductionYear_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeID_int.ToString())) == false)
            {
                businessObject.LaderTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeID_int.ToString()));
            }
            else
            {
                businessObject.LaderTypeID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeCode_nvc.ToString())) == false)
            {
                businessObject.LaderTypeCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.LaderTypeCode_nvc.ToString()));
            }
            else
            {
                businessObject.LaderTypeCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.SystemCode_nvc.ToString())) == false)
            {
                businessObject.SystemCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.SystemCode_nvc.ToString()));
            }
            else
            {
                businessObject.SystemCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.System_nvc.ToString())) == false)
            {
                businessObject.System_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.System_nvc.ToString()));
            }
            else
            {
                businessObject.System_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.Capacity_flt.ToString())) == false)
            {
                businessObject.Capacity_flt = dataReader.GetDouble(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.Capacity_flt.ToString()));
            }
            else
            {
                businessObject.Capacity_flt = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.InfractionGroupID_int.ToString())) == false)
            {
                businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.InfractionGroupID_int.ToString()));
            }
            else
            {
                businessObject.InfractionGroupID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.InsertDate_nvc.ToString())) == false)
            {
                businessObject.InsertDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.InsertDate_nvc.ToString()));
            }
            else
            {
                businessObject.InsertDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.UpdateDate_nvc.ToString())) == false)
            {
                businessObject.UpdateDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.UpdateDate_nvc.ToString()));
            }
            else
            {
                businessObject.UpdateDate_nvc = String.Empty;
            }

            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.Active_bit.ToString()));
            businessObject.Deleted_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.CarBLL.BLLCar_T.Car_TField.Deleted_bit.ToString()));
        }

        public List<HPS.BLL.CarBLL.BLLCar_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.CarBLL.BLLCar_T> list = new List<HPS.BLL.CarBLL.BLLCar_T>();
            while (dataReader.Read())
            {
                HPS.BLL.CarBLL.BLLCar_T businessObject = new HPS.BLL.CarBLL.BLLCar_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void CarSystemSelectAll(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CarSystem_SelectAll]";
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

        public void SelectByPlate(string PlateNumber, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Car_T_SelectByPlate]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(PlateNumber))
                    NumberPlate_nvc.Value = DBNull.Value;
                else
                    NumberPlate_nvc.Value = PlateNumber;
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

        public void SelectByConditionWithCardReader(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Car_T_SelectConditionbyPlate]";
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

        public void TransferData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_TransferData]";
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout =5000000;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@SourcePath", SourcePath));
                this.Command.Parameters.Add(new SqlParameter("@SourceTable", SourceTable));

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

        public void DeleteTransferCarData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Car_T_DeleteTransferData]";
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 5000000;

            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@SourcePath", SourcePath));
                this.Command.Parameters.Add(new SqlParameter("@SourceTable", SourceTable));

                //if (ControlConnection)
                //{
                //    this.BeginTransaction();
                //}
                this.Connection.Open();
                this.Command.ExecuteNonQuery();
                this.Connection.Close();
                //if (ControlConnection)
                //{
                //    this.Commit();
                //}
            }
            catch (System.Exception ex)
            {
                if (this.Connection.State != ConnectionState.Closed)
                    this.Connection.Close();
                //if (ControlConnection)
                //{
                //    this.RollBack();
                //}
                throw ex;
            }
        }

    }
}