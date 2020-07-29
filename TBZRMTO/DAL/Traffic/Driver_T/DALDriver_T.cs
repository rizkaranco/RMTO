using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DriverDAL
{
    class DALDriver_T : DataLayerBase
    {

        public DALDriver_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.DriverBLL.BLLDriver_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Output;
                DriverID_bint.IsNullable = false;
                DriverID_bint.Value = businessObject.DriverID_bint;
                this.Command.Parameters.Add(DriverID_bint);

                SqlParameter DriverCardDate_nvc = new SqlParameter();
                DriverCardDate_nvc.ParameterName = "@DriverCardDate_nvc";
                DriverCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardDate_nvc.Direction = ParameterDirection.Input;
                DriverCardDate_nvc.IsNullable = false;
                DriverCardDate_nvc.Value = businessObject.DriverCardDate_nvc;
                this.Command.Parameters.Add(DriverCardDate_nvc);

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = false;
                DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
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
                FirstName_nvc.IsNullable = false;
                FirstName_nvc.Value = businessObject.FirstName_nvc;
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = false;
                LastName_nvc.Value = businessObject.LastName_nvc;
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

                SqlParameter licenceNumber_nvc = new SqlParameter();
                licenceNumber_nvc.ParameterName = "@licenceNumber_nvc";
                licenceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                licenceNumber_nvc.Direction = ParameterDirection.Input;
                licenceNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.licenceNumber_nvc))
                {
                    licenceNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    licenceNumber_nvc.Value = businessObject.licenceNumber_nvc;
                }
                this.Command.Parameters.Add(licenceNumber_nvc);

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

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

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

                SqlParameter DocNumber_nvc = new SqlParameter();
                DocNumber_nvc.ParameterName = "@DocNumber_nvc";
                DocNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DocNumber_nvc.Direction = ParameterDirection.Input;
                DocNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DocNumber_nvc))
                {
                    DocNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DocNumber_nvc.Value = businessObject.DocNumber_nvc;
                }
                this.Command.Parameters.Add(DocNumber_nvc);

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

                SqlParameter Deleted_bit = new SqlParameter();
                Deleted_bit.ParameterName = "@Deleted_bit";
                Deleted_bit.SqlDbType = SqlDbType.Bit;
                Deleted_bit.Direction = ParameterDirection.Input;
                Deleted_bit.IsNullable = false;
                Deleted_bit.Value = businessObject.Deleted_bit;
                this.Command.Parameters.Add(Deleted_bit);


                SqlParameter Mobile_nvc = new SqlParameter();
                Mobile_nvc.ParameterName = "@Mobile_nvc";
                Mobile_nvc.SqlDbType = SqlDbType.NVarChar ;
                Mobile_nvc.Direction = ParameterDirection.Input;
                Mobile_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Mobile_nvc))
                {
                    Mobile_nvc.Value = DBNull.Value;
                }
                else
                {
                    Mobile_nvc.Value = businessObject.Mobile_nvc;

                }
                this.Command.Parameters.Add(Mobile_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.DriverID_bint = (Int64)(this.Command.Parameters["@DriverID_bint"].Value);

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

        public void Update(HPS.BLL.DriverBLL.BLLDriver_T businessObject, HPS.BLL.DriverBLL.BLLDriver_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverCardDate_nvc = new SqlParameter();
                DriverCardDate_nvc.ParameterName = "@DriverCardDate_nvc";
                DriverCardDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardDate_nvc.Direction = ParameterDirection.Input;
                DriverCardDate_nvc.IsNullable = false;
                DriverCardDate_nvc.Value = businessObject.DriverCardDate_nvc;
                this.Command.Parameters.Add(DriverCardDate_nvc);

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = false;
                DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                SqlParameter DriverType_nvc = new SqlParameter();
                DriverType_nvc.ParameterName = "@DriverType_nvc";
                DriverType_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverType_nvc.Direction = ParameterDirection.Input;
                DriverType_nvc.IsNullable = false;
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
                FirstName_nvc.Value = businessObject.FirstName_nvc;
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = false;
                LastName_nvc.Value = businessObject.LastName_nvc;
                this.Command.Parameters.Add(LastName_nvc);

                SqlParameter InsuranceNumber_nvc = new SqlParameter();
                InsuranceNumber_nvc.ParameterName = "@InsuranceNumber_nvc";
                InsuranceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceNumber_nvc.Direction = ParameterDirection.Input;
                InsuranceNumber_nvc.IsNullable = false;
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

                SqlParameter licenceNumber_nvc = new SqlParameter();
                licenceNumber_nvc.ParameterName = "@licenceNumber_nvc";
                licenceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                licenceNumber_nvc.Direction = ParameterDirection.Input;
                licenceNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.licenceNumber_nvc))
                {
                    licenceNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    licenceNumber_nvc.Value = businessObject.licenceNumber_nvc;
                }
                this.Command.Parameters.Add(licenceNumber_nvc);

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

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = true;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter InfractionGroupID_int = new SqlParameter();
                InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
                InfractionGroupID_int.SqlDbType = SqlDbType.Int;
                InfractionGroupID_int.Direction = ParameterDirection.Input;
                InfractionGroupID_int.IsNullable = false;
                if (businessObject.InfractionGroupID_int.HasValue == false)
                {
                    InfractionGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
                }
                this.Command.Parameters.Add(InfractionGroupID_int);

                SqlParameter DocNumber_nvc = new SqlParameter();
                DocNumber_nvc.ParameterName = "@DocNumber_nvc";
                DocNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DocNumber_nvc.Direction = ParameterDirection.Input;
                DocNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DocNumber_nvc))
                {
                    DocNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DocNumber_nvc.Value = businessObject.DocNumber_nvc;
                }
                this.Command.Parameters.Add(DocNumber_nvc);

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

                SqlParameter Deleted_bit = new SqlParameter();
                Deleted_bit.ParameterName = "@Deleted_bit";
                Deleted_bit.SqlDbType = SqlDbType.Bit;
                Deleted_bit.Direction = ParameterDirection.Input;
                Deleted_bit.IsNullable = true;
                Deleted_bit.Value = businessObject.Deleted_bit;
                this.Command.Parameters.Add(Deleted_bit);


                SqlParameter pk_DriverID_bint = new SqlParameter();
                pk_DriverID_bint.ParameterName = "@pk_DriverID_bint";
                pk_DriverID_bint.SqlDbType = SqlDbType.BigInt;
                pk_DriverID_bint.Direction = ParameterDirection.Input;
                pk_DriverID_bint.IsNullable = false;
                pk_DriverID_bint.Value = businessObjectKey.DriverID_bint;
                this.Command.Parameters.Add(pk_DriverID_bint);

                SqlParameter Mobile_nvc = new SqlParameter();
                Mobile_nvc.ParameterName = "@Mobile_nvc";
                Mobile_nvc.SqlDbType = SqlDbType.NVarChar;
                Mobile_nvc.Direction = ParameterDirection.Input;
                Mobile_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Mobile_nvc))
                {
                    Mobile_nvc.Value = DBNull.Value;
                }
                else
                {
                    Mobile_nvc.Value = businessObject.Mobile_nvc;

                }
                this.Command.Parameters.Add(Mobile_nvc);

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

        public List<HPS.BLL.DriverBLL.BLLDriver_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.DriverBLL.BLLDriver_T> Result = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
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
            this.Command.CommandText = "[sp_Driver_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Driver_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Driver_T_SelectAll]";
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

        public HPS.BLL.DriverBLL.BLLDriver_T SelectByPrimaryKey(HPS.BLL.DriverBLL.BLLDriver_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = false;
                DriverID_bint.Value = businessObjectKey.DriverID_bint;
                this.Command.Parameters.Add(DriverID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.DriverBLL.BLLDriver_T businessObject = new HPS.BLL.DriverBLL.BLLDriver_T();
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

        public void SelectByPrimaryKey(HPS.BLL.DriverBLL.BLLDriver_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Driver_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = false;
                DriverID_bint.Value = businessObjectKey.DriverID_bint;
                this.Command.Parameters.Add(DriverID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.DriverBLL.BLLDriver_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Driver_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = false;
                DriverID_bint.Value = businessObjectKey.DriverID_bint;
                this.Command.Parameters.Add(DriverID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.DriverBLL.BLLDriver_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Driver_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = false;
                DriverID_bint.Value = businessObjectKey.DriverID_bint;
                this.Command.Parameters.Add(DriverID_bint);



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

        public List<HPS.BLL.DriverBLL.BLLDriver_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }
                if(fieldName.EndsWith("_int"))
                {
                    this.Command.Parameters.Add(new SqlParameter("@Condition", "[Driver_T]." + fieldName + " = "+  Convert.ToString(value) ));
                }
                else
                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Driver_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.DriverBLL.BLLDriver_T> Result = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
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
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Driver_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Driver_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Driver_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.DriverBLL.BLLDriver_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
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
                List<HPS.BLL.DriverBLL.BLLDriver_T> Result = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
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
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Driver_T_SelectCondition]";
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

        public void Delete(HPS.BLL.DriverBLL.BLLDriver_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = false;
                DriverID_bint.Value = businessObjectKey.DriverID_bint;
                this.Command.Parameters.Add(DriverID_bint);


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
            this.Command.CommandText = "[sp_Driver_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.DriverBLL.BLLDriver_T businessObject, IDataReader dataReader)
        {
            businessObject.DriverID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverID_bint.ToString()));
            businessObject.DriverCardDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardDate_nvc.ToString()));
            businessObject.DriverCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverType_nvc.ToString())) == false)
            {
                businessObject.DriverType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverType_nvc.ToString()));
            }
            else
            {
                businessObject.DriverType_nvc = String.Empty;
            }

            businessObject.FirstName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.FirstName_nvc.ToString()));
            businessObject.LastName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LastName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsuranceNumber_nvc.ToString())) == false)
            {
                businessObject.InsuranceNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsuranceNumber_nvc.ToString()));
            }
            else
            {
                businessObject.InsuranceNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityID_int.ToString())) == false)
            {
                businessObject.CityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityID_int.ToString()));
            }
            else
            {
                businessObject.CityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityCode_nvc.ToString())) == false)
            {
                businessObject.CityCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityCode_nvc.ToString()));
            }
            else
            {
                businessObject.CityCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.licenceNumber_nvc.ToString())) == false)
            {
                businessObject.licenceNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.licenceNumber_nvc.ToString()));
            }
            else
            {
                businessObject.licenceNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceCityID_int.ToString())) == false)
            {
                businessObject.LicenceCityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceCityID_int.ToString()));
            }
            else
            {
                businessObject.LicenceCityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceType_nvc.ToString())) == false)
            {
                businessObject.LicenceType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceType_nvc.ToString()));
            }
            else
            {
                businessObject.LicenceType_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LiceniceDate_nvc.ToString())) == false)
            {
                businessObject.LiceniceDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LiceniceDate_nvc.ToString()));
            }
            else
            {
                businessObject.LiceniceDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.ActivityScope_nvc.ToString())) == false)
            {
                businessObject.ActivityScope_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.ActivityScope_nvc.ToString()));
            }
            else
            {
                businessObject.ActivityScope_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.NationalCode_int.ToString())) == false)
            {
                businessObject.NationalCode_int = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.NationalCode_int.ToString()));
            }
            else
            {
                businessObject.NationalCode_int = null;
            }

            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Active_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InfractionGroupID_int.ToString())) == false)
            {
                businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InfractionGroupID_int.ToString()));
            }
            else
            {
                businessObject.InfractionGroupID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DocNumber_nvc.ToString())) == false)
            {
                businessObject.DocNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DocNumber_nvc.ToString()));
            }
            else
            {
                businessObject.DocNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsertDate_nvc.ToString())) == false)
            {
                businessObject.InsertDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsertDate_nvc.ToString()));
            }
            else
            {
                businessObject.InsertDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.UpdateDate_nvc.ToString())) == false)
            {
                businessObject.UpdateDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.UpdateDate_nvc.ToString()));
            }
            else
            {
                businessObject.UpdateDate_nvc = String.Empty;
            }

            businessObject.Deleted_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Deleted_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Mobile_nvc.ToString())) == false)
            {
                businessObject.Mobile_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Mobile_nvc.ToString()));
            }
            else
            {
                businessObject.Mobile_nvc = string.Empty;
            }
        }

        public List<HPS.BLL.DriverBLL.BLLDriver_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.DriverBLL.BLLDriver_T> list = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
            while (dataReader.Read())
            {
                HPS.BLL.DriverBLL.BLLDriver_T businessObject = new HPS.BLL.DriverBLL.BLLDriver_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        //Later Added
        public void SelectByCardNumber(string CardNumber, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Driver_T_SelectByCardNumber]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(CardNumber))
                {
                    DriverCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverCardNumber_nvc.Value = CardNumber;
                }
                this.Command.Parameters.Add(DriverCardNumber_nvc);


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

        public void SelectByConditionSearch(string DriverCardNumber, string DocNumber, Int64? NationalCode, string LastName, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Driver_T_SelectConditionSearch]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(DriverCardNumber))
                {
                    DriverCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverCardNumber_nvc.Value = DriverCardNumber;
                }
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                SqlParameter DocNumber_nvc = new SqlParameter();
                DocNumber_nvc.ParameterName = "@DocNumber_nvc";
                DocNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DocNumber_nvc.Direction = ParameterDirection.Input;
                DocNumber_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(DocNumber))
                {
                    DocNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    DocNumber_nvc.Value = DocNumber;
                }
                this.Command.Parameters.Add(DocNumber_nvc);


                SqlParameter NationalCode_bint = new SqlParameter();
                NationalCode_bint.ParameterName = "@NationalCode_bint";
                NationalCode_bint.SqlDbType = SqlDbType.BigInt;
                NationalCode_bint.Direction = ParameterDirection.Input;
                NationalCode_bint.IsNullable = true;
                if (NationalCode.HasValue==false)
                {
                    NationalCode_bint.Value = DBNull.Value;
                }
                else
                {
                    NationalCode_bint.Value = NationalCode;
                }
                this.Command.Parameters.Add(NationalCode_bint);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(LastName))
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

        public void TransferData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_TransferData]";
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 500000;

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

        public void DeleteTransferData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Driver_T_DeleteTransferData]";
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 500000;

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