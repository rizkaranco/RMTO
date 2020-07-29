using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DriverSpecificationDAL
{
    class DALDriverSpecification_T : DataLayerBase
    {

        public DALDriverSpecification_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverSpecificationID_int = new SqlParameter();
                DriverSpecificationID_int.ParameterName = "@DriverSpecificationID_int";
                DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                DriverSpecificationID_int.Direction = ParameterDirection.Output;
                DriverSpecificationID_int.IsNullable = false;
                DriverSpecificationID_int.Value = businessObject.DriverSpecificationID_int;
                this.Command.Parameters.Add(DriverSpecificationID_int);

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

                SqlParameter FirstName_nvc = new SqlParameter();
                FirstName_nvc.ParameterName = "@FirstName_nvc";
                FirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvc.Direction = ParameterDirection.Input;
                FirstName_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.FirstName_nvc))
                    FirstName_nvc.Value = businessObject.FirstName_nvc;
                else
                    FirstName_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.LastName_nvc))
                    LastName_nvc.Value = businessObject.LastName_nvc;
                else
                    LastName_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(LastName_nvc);

                SqlParameter NationalCode_int = new SqlParameter();
                NationalCode_int.ParameterName = "@NationalCode_int";
                NationalCode_int.SqlDbType = SqlDbType.BigInt;
                NationalCode_int.Direction = ParameterDirection.Input;
                NationalCode_int.IsNullable = true;
                if (businessObject.NationalCode_int.HasValue)
                    NationalCode_int.Value = businessObject.NationalCode_int;
                else
                    NationalCode_int.Value = DBNull.Value;
                this.Command.Parameters.Add(NationalCode_int);

                SqlParameter licenceNumber_nvc = new SqlParameter();
                licenceNumber_nvc.ParameterName = "@licenceNumber_nvc";
                licenceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                licenceNumber_nvc.Direction = ParameterDirection.Input;
                licenceNumber_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.licenceNumber_nvc))
                    licenceNumber_nvc.Value = businessObject.licenceNumber_nvc;
                else
                    licenceNumber_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(licenceNumber_nvc);

                SqlParameter CarExamination_bit = new SqlParameter();
                CarExamination_bit.ParameterName = "@CarExamination_bit";
                CarExamination_bit.SqlDbType = SqlDbType.Bit;
                CarExamination_bit.Direction = ParameterDirection.Input;
                CarExamination_bit.IsNullable = false;
                CarExamination_bit.Value = businessObject.CarExamination_bit;
                this.Command.Parameters.Add(CarExamination_bit);

                SqlParameter LicenceEnd_nvc = new SqlParameter();
                LicenceEnd_nvc.ParameterName = "@LicenceEnd_nvc";
                LicenceEnd_nvc.SqlDbType = SqlDbType.NVarChar;
                LicenceEnd_nvc.Direction = ParameterDirection.Input;
                LicenceEnd_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.LicenceEnd_nvc))
                    LicenceEnd_nvc.Value = DBNull.Value;
                else
                    LicenceEnd_nvc.Value = businessObject.LicenceEnd_nvc;
                this.Command.Parameters.Add(LicenceEnd_nvc);

                SqlParameter CarExaminationEndDate_nvc = new SqlParameter();
                CarExaminationEndDate_nvc.ParameterName = "@CarExaminationEndDate_nvc";
                CarExaminationEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CarExaminationEndDate_nvc.Direction = ParameterDirection.Input;
                CarExaminationEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CarExaminationEndDate_nvc))
                    CarExaminationEndDate_nvc.Value = DBNull.Value;
                else
                    CarExaminationEndDate_nvc.Value = businessObject.CarExaminationEndDate_nvc;
                this.Command.Parameters.Add(CarExaminationEndDate_nvc);

                SqlParameter Insurance_bit = new SqlParameter();
                Insurance_bit.ParameterName = "@Insurance_bit";
                Insurance_bit.SqlDbType = SqlDbType.Bit;
                Insurance_bit.Direction = ParameterDirection.Input;
                Insurance_bit.IsNullable = false;
                Insurance_bit.Value = businessObject.Insurance_bit;
                this.Command.Parameters.Add(Insurance_bit);

                SqlParameter InsuranceStartDate_nvc = new SqlParameter();
                InsuranceStartDate_nvc.ParameterName = "@InsuranceStartDate_nvc";
                InsuranceStartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceStartDate_nvc.Direction = ParameterDirection.Input;
                InsuranceStartDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.InsuranceStartDate_nvc))
                    InsuranceStartDate_nvc.Value = DBNull.Value;
                else
                    InsuranceStartDate_nvc.Value = businessObject.InsuranceStartDate_nvc;
                this.Command.Parameters.Add(InsuranceStartDate_nvc);

                SqlParameter InsuranceEndDate_nvc = new SqlParameter();
                InsuranceEndDate_nvc.ParameterName = "@InsuranceEndDate_nvc";
                InsuranceEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceEndDate_nvc.Direction = ParameterDirection.Input;
                InsuranceEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.InsuranceEndDate_nvc))
                    InsuranceEndDate_nvc.Value = DBNull.Value;
                else
                    InsuranceEndDate_nvc.Value = businessObject.InsuranceEndDate_nvc;
                this.Command.Parameters.Add(InsuranceEndDate_nvc);

                SqlParameter ClassID_int = new SqlParameter();
                ClassID_int.ParameterName = "@ClassID_int";
                ClassID_int.SqlDbType = SqlDbType.Int;
                ClassID_int.Direction = ParameterDirection.Input;
                ClassID_int.IsNullable = true;
                if (businessObject.ClassID_int.HasValue)
                    ClassID_int.Value = businessObject.ClassID_int;
                else
                    ClassID_int.Value = DBNull.Value;
                this.Command.Parameters.Add(ClassID_int);

                SqlParameter HealthCard_bit = new SqlParameter();
                HealthCard_bit.ParameterName = "@HealthCard_bit";
                HealthCard_bit.SqlDbType = SqlDbType.Bit;
                HealthCard_bit.Direction = ParameterDirection.Input;
                HealthCard_bit.IsNullable = false;
                HealthCard_bit.Value = businessObject.HealthCard_bit;
                this.Command.Parameters.Add(HealthCard_bit);

                SqlParameter HealthCardStartDate_nvc = new SqlParameter();
                HealthCardStartDate_nvc.ParameterName = "@HealthCardStartDate_nvc";
                HealthCardStartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                HealthCardStartDate_nvc.Direction = ParameterDirection.Input;
                HealthCardStartDate_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.HealthCardStartDate_nvc))
                    HealthCardStartDate_nvc.Value = businessObject.HealthCardStartDate_nvc;
                else
                    HealthCardStartDate_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(HealthCardStartDate_nvc);

                SqlParameter HealthCardEndDate_nvc = new SqlParameter();
                HealthCardEndDate_nvc.ParameterName = "@HealthCardEndDate_nvc";
                HealthCardEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                HealthCardEndDate_nvc.Direction = ParameterDirection.Input;
                HealthCardEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.HealthCardEndDate_nvc))
                    HealthCardEndDate_nvc.Value = DBNull.Value;
                else
                    HealthCardEndDate_nvc.Value = businessObject.HealthCardEndDate_nvc;
                this.Command.Parameters.Add(HealthCardEndDate_nvc);

                SqlParameter DriverCardSharje_bit = new SqlParameter();
                DriverCardSharje_bit.ParameterName = "@DriverCardSharje_bit";
                DriverCardSharje_bit.SqlDbType = SqlDbType.Bit;
                DriverCardSharje_bit.Direction = ParameterDirection.Input;
                DriverCardSharje_bit.IsNullable = false;
                DriverCardSharje_bit.Value = businessObject.DriverCardSharje_bit;
                this.Command.Parameters.Add(DriverCardSharje_bit);

                SqlParameter DriverCardSharjeStartDate_nvc = new SqlParameter();
                DriverCardSharjeStartDate_nvc.ParameterName = "@DriverCardSharjeStartDate_nvc";
                DriverCardSharjeStartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardSharjeStartDate_nvc.Direction = ParameterDirection.Input;
                DriverCardSharjeStartDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverCardSharjeStartDate_nvc))
                    DriverCardSharjeStartDate_nvc.Value = DBNull.Value;
                else
                    DriverCardSharjeStartDate_nvc.Value = businessObject.DriverCardSharjeStartDate_nvc;
                this.Command.Parameters.Add(DriverCardSharjeStartDate_nvc);

                SqlParameter DriverCardSharjeEndDate_nvc = new SqlParameter();
                DriverCardSharjeEndDate_nvc.ParameterName = "@DriverCardSharjeEndDate_nvc";
                DriverCardSharjeEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardSharjeEndDate_nvc.Direction = ParameterDirection.Input;
                DriverCardSharjeEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverCardSharjeEndDate_nvc))
                    DriverCardSharjeEndDate_nvc.Value = DBNull.Value;
                else
                    DriverCardSharjeEndDate_nvc.Value = businessObject.DriverCardSharjeEndDate_nvc;
                this.Command.Parameters.Add(DriverCardSharjeEndDate_nvc);

                SqlParameter StatisticCard_bit = new SqlParameter();
                StatisticCard_bit.ParameterName = "@StatisticCard_bit";
                StatisticCard_bit.SqlDbType = SqlDbType.Bit;
                StatisticCard_bit.Direction = ParameterDirection.Input;
                StatisticCard_bit.IsNullable = false;
                StatisticCard_bit.Value = businessObject.StatisticCard_bit;
                this.Command.Parameters.Add(StatisticCard_bit);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CarCardNumber_nvc))
                    CarCardNumber_nvc.Value = DBNull.Value;
                else
                    CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.DriverSpecificationID_int = (Int32)(this.Command.Parameters["@DriverSpecificationID_int"].Value);

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

        public void Update(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T businessObject, HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverID_bint = new SqlParameter();
                DriverID_bint.ParameterName = "@DriverID_bint";
                DriverID_bint.SqlDbType = SqlDbType.BigInt;
                DriverID_bint.Direction = ParameterDirection.Input;
                DriverID_bint.IsNullable = false;
                if (businessObject.DriverID_bint.HasValue == false)
                {
                    DriverID_bint.Value = DBNull.Value;
                }
                else
                {
                    DriverID_bint.Value = businessObject.DriverID_bint;
                }
                this.Command.Parameters.Add(DriverID_bint);

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

                SqlParameter FirstName_nvc = new SqlParameter();
                FirstName_nvc.ParameterName = "@FirstName_nvc";
                FirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvc.Direction = ParameterDirection.Input;
                FirstName_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.FirstName_nvc))
                    FirstName_nvc.Value = businessObject.FirstName_nvc;
                else
                    FirstName_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(FirstName_nvc);

                SqlParameter LastName_nvc = new SqlParameter();
                LastName_nvc.ParameterName = "@LastName_nvc";
                LastName_nvc.SqlDbType = SqlDbType.NVarChar;
                LastName_nvc.Direction = ParameterDirection.Input;
                LastName_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.LastName_nvc))
                    LastName_nvc.Value = businessObject.LastName_nvc;
                else
                    LastName_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(LastName_nvc);

                SqlParameter NationalCode_int = new SqlParameter();
                NationalCode_int.ParameterName = "@NationalCode_int";
                NationalCode_int.SqlDbType = SqlDbType.BigInt;
                NationalCode_int.Direction = ParameterDirection.Input;
                NationalCode_int.IsNullable = true;
                if (businessObject.NationalCode_int.HasValue)
                    NationalCode_int.Value = businessObject.NationalCode_int;
                else
                    NationalCode_int.Value = DBNull.Value;
                this.Command.Parameters.Add(NationalCode_int);

                SqlParameter licenceNumber_nvc = new SqlParameter();
                licenceNumber_nvc.ParameterName = "@licenceNumber_nvc";
                licenceNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                licenceNumber_nvc.Direction = ParameterDirection.Input;
                licenceNumber_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.licenceNumber_nvc))
                    licenceNumber_nvc.Value = businessObject.licenceNumber_nvc;
                else
                    licenceNumber_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(licenceNumber_nvc);

                SqlParameter CarExamination_bit = new SqlParameter();
                CarExamination_bit.ParameterName = "@CarExamination_bit";
                CarExamination_bit.SqlDbType = SqlDbType.Bit;
                CarExamination_bit.Direction = ParameterDirection.Input;
                CarExamination_bit.IsNullable = false;
                CarExamination_bit.Value = businessObject.CarExamination_bit;
                this.Command.Parameters.Add(CarExamination_bit);

                SqlParameter LicenceEnd_nvc = new SqlParameter();
                LicenceEnd_nvc.ParameterName = "@LicenceEnd_nvc";
                LicenceEnd_nvc.SqlDbType = SqlDbType.NVarChar;
                LicenceEnd_nvc.Direction = ParameterDirection.Input;
                LicenceEnd_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.LicenceEnd_nvc))
                    LicenceEnd_nvc.Value = DBNull.Value;
                else
                    LicenceEnd_nvc.Value = businessObject.LicenceEnd_nvc;
                this.Command.Parameters.Add(LicenceEnd_nvc);

                SqlParameter CarExaminationEndDate_nvc = new SqlParameter();
                CarExaminationEndDate_nvc.ParameterName = "@CarExaminationEndDate_nvc";
                CarExaminationEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CarExaminationEndDate_nvc.Direction = ParameterDirection.Input;
                CarExaminationEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CarExaminationEndDate_nvc))
                    CarExaminationEndDate_nvc.Value = DBNull.Value;
                else
                    CarExaminationEndDate_nvc.Value = businessObject.CarExaminationEndDate_nvc;
                this.Command.Parameters.Add(CarExaminationEndDate_nvc);

                SqlParameter Insurance_bit = new SqlParameter();
                Insurance_bit.ParameterName = "@Insurance_bit";
                Insurance_bit.SqlDbType = SqlDbType.Bit;
                Insurance_bit.Direction = ParameterDirection.Input;
                Insurance_bit.IsNullable = false;
                Insurance_bit.Value = businessObject.Insurance_bit;
                this.Command.Parameters.Add(Insurance_bit);

                SqlParameter InsuranceStartDate_nvc = new SqlParameter();
                InsuranceStartDate_nvc.ParameterName = "@InsuranceStartDate_nvc";
                InsuranceStartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceStartDate_nvc.Direction = ParameterDirection.Input;
                InsuranceStartDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.InsuranceStartDate_nvc))
                    InsuranceStartDate_nvc.Value = DBNull.Value;
                else
                    InsuranceStartDate_nvc.Value = businessObject.InsuranceStartDate_nvc;
                this.Command.Parameters.Add(InsuranceStartDate_nvc);

                SqlParameter InsuranceEndDate_nvc = new SqlParameter();
                InsuranceEndDate_nvc.ParameterName = "@InsuranceEndDate_nvc";
                InsuranceEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                InsuranceEndDate_nvc.Direction = ParameterDirection.Input;
                InsuranceEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.InsuranceEndDate_nvc))
                    InsuranceEndDate_nvc.Value = DBNull.Value;
                else
                    InsuranceEndDate_nvc.Value = businessObject.InsuranceEndDate_nvc;
                this.Command.Parameters.Add(InsuranceEndDate_nvc);

                SqlParameter ClassID_int = new SqlParameter();
                ClassID_int.ParameterName = "@ClassID_int";
                ClassID_int.SqlDbType = SqlDbType.Int;
                ClassID_int.Direction = ParameterDirection.Input;
                ClassID_int.IsNullable = true;
                if (businessObject.ClassID_int.HasValue)
                    ClassID_int.Value = businessObject.ClassID_int;
                else
                    ClassID_int.Value = DBNull.Value;
                this.Command.Parameters.Add(ClassID_int);

                SqlParameter HealthCard_bit = new SqlParameter();
                HealthCard_bit.ParameterName = "@HealthCard_bit";
                HealthCard_bit.SqlDbType = SqlDbType.Bit;
                HealthCard_bit.Direction = ParameterDirection.Input;
                HealthCard_bit.IsNullable = false;
                HealthCard_bit.Value = businessObject.HealthCard_bit;
                this.Command.Parameters.Add(HealthCard_bit);

                SqlParameter HealthCardStartDate_nvc = new SqlParameter();
                HealthCardStartDate_nvc.ParameterName = "@HealthCardStartDate_nvc";
                HealthCardStartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                HealthCardStartDate_nvc.Direction = ParameterDirection.Input;
                HealthCardStartDate_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.HealthCardStartDate_nvc))
                    HealthCardStartDate_nvc.Value = businessObject.HealthCardStartDate_nvc;
                else
                    HealthCardStartDate_nvc.Value = DBNull.Value;
                this.Command.Parameters.Add(HealthCardStartDate_nvc);

                SqlParameter HealthCardEndDate_nvc = new SqlParameter();
                HealthCardEndDate_nvc.ParameterName = "@HealthCardEndDate_nvc";
                HealthCardEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                HealthCardEndDate_nvc.Direction = ParameterDirection.Input;
                HealthCardEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.HealthCardEndDate_nvc))
                    HealthCardEndDate_nvc.Value = DBNull.Value;
                else
                    HealthCardEndDate_nvc.Value = businessObject.HealthCardEndDate_nvc;
                this.Command.Parameters.Add(HealthCardEndDate_nvc);

                SqlParameter DriverCardSharje_bit = new SqlParameter();
                DriverCardSharje_bit.ParameterName = "@DriverCardSharje_bit";
                DriverCardSharje_bit.SqlDbType = SqlDbType.Bit;
                DriverCardSharje_bit.Direction = ParameterDirection.Input;
                DriverCardSharje_bit.IsNullable = false;
                DriverCardSharje_bit.Value = businessObject.DriverCardSharje_bit;
                this.Command.Parameters.Add(DriverCardSharje_bit);

                SqlParameter DriverCardSharjeStartDate_nvc = new SqlParameter();
                DriverCardSharjeStartDate_nvc.ParameterName = "@DriverCardSharjeStartDate_nvc";
                DriverCardSharjeStartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardSharjeStartDate_nvc.Direction = ParameterDirection.Input;
                DriverCardSharjeStartDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverCardSharjeStartDate_nvc))
                    DriverCardSharjeStartDate_nvc.Value = DBNull.Value;
                else
                    DriverCardSharjeStartDate_nvc.Value = businessObject.DriverCardSharjeStartDate_nvc;
                this.Command.Parameters.Add(DriverCardSharjeStartDate_nvc);

                SqlParameter DriverCardSharjeEndDate_nvc = new SqlParameter();
                DriverCardSharjeEndDate_nvc.ParameterName = "@DriverCardSharjeEndDate_nvc";
                DriverCardSharjeEndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardSharjeEndDate_nvc.Direction = ParameterDirection.Input;
                DriverCardSharjeEndDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverCardSharjeEndDate_nvc))
                    DriverCardSharjeEndDate_nvc.Value = DBNull.Value;
                else
                    DriverCardSharjeEndDate_nvc.Value = businessObject.DriverCardSharjeEndDate_nvc;
                this.Command.Parameters.Add(DriverCardSharjeEndDate_nvc);

                SqlParameter StatisticCard_bit = new SqlParameter();
                StatisticCard_bit.ParameterName = "@StatisticCard_bit";
                StatisticCard_bit.SqlDbType = SqlDbType.Bit;
                StatisticCard_bit.Direction = ParameterDirection.Input;
                StatisticCard_bit.IsNullable = false;
                StatisticCard_bit.Value = businessObject.StatisticCard_bit;
                this.Command.Parameters.Add(StatisticCard_bit);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CarCardNumber_nvc))
                    CarCardNumber_nvc.Value = DBNull.Value;
                else
                    CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvc);

                SqlParameter pk_DriverSpecificationID_int = new SqlParameter();
                pk_DriverSpecificationID_int.ParameterName = "@pk_DriverSpecificationID_int";
                pk_DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                pk_DriverSpecificationID_int.Direction = ParameterDirection.Input;
                pk_DriverSpecificationID_int.IsNullable = false;
                pk_DriverSpecificationID_int.Value = businessObjectKey.DriverSpecificationID_int;
                this.Command.Parameters.Add(pk_DriverSpecificationID_int);



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

        public List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> Result = new List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T>();
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectAll]";
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectAll]";
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectAll]";
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

        public HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T SelectByPrimaryKey(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverSpecificationID_int = new SqlParameter();
                DriverSpecificationID_int.ParameterName = "@DriverSpecificationID_int";
                DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                DriverSpecificationID_int.Direction = ParameterDirection.Input;
                DriverSpecificationID_int.IsNullable = false;
                DriverSpecificationID_int.Value = businessObjectKey.DriverSpecificationID_int;
                this.Command.Parameters.Add(DriverSpecificationID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T businessObject = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
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

        public void SelectByPrimaryKey(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverSpecificationID_int = new SqlParameter();
                DriverSpecificationID_int.ParameterName = "@DriverSpecificationID_int";
                DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                DriverSpecificationID_int.Direction = ParameterDirection.Input;
                DriverSpecificationID_int.IsNullable = false;
                DriverSpecificationID_int.Value = businessObjectKey.DriverSpecificationID_int;
                this.Command.Parameters.Add(DriverSpecificationID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverSpecificationID_int = new SqlParameter();
                DriverSpecificationID_int.ParameterName = "@DriverSpecificationID_int";
                DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                DriverSpecificationID_int.Direction = ParameterDirection.Input;
                DriverSpecificationID_int.IsNullable = false;
                DriverSpecificationID_int.Value = businessObjectKey.DriverSpecificationID_int;
                this.Command.Parameters.Add(DriverSpecificationID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverSpecificationID_int = new SqlParameter();
                DriverSpecificationID_int.ParameterName = "@DriverSpecificationID_int";
                DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                DriverSpecificationID_int.Direction = ParameterDirection.Input;
                DriverSpecificationID_int.IsNullable = false;
                DriverSpecificationID_int.Value = businessObjectKey.DriverSpecificationID_int;
                this.Command.Parameters.Add(DriverSpecificationID_int);



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

        public List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
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
                    this.Command.Parameters.Add(new SqlParameter("@Condition", "[DriverSpecification_T]." + fieldName + " = "+ Convert.ToString(value)));
                }
                else
                    this.Command.Parameters.Add(new SqlParameter("@Condition", "[DriverSpecification_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> Result = new List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T>();
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[DriverSpecification_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[DriverSpecification_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[DriverSpecification_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
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
                List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> Result = new List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T>();
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectCondition]";
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

        public void Delete(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_DriverSpecification_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DriverSpecificationID_int = new SqlParameter();
                DriverSpecificationID_int.ParameterName = "@DriverSpecificationID_int";
                DriverSpecificationID_int.SqlDbType = SqlDbType.Int;
                DriverSpecificationID_int.Direction = ParameterDirection.Input;
                DriverSpecificationID_int.IsNullable = false;
                DriverSpecificationID_int.Value = businessObjectKey.DriverSpecificationID_int;
                this.Command.Parameters.Add(DriverSpecificationID_int);


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
            this.Command.CommandText = "[sp_DriverSpecification_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T businessObject, IDataReader dataReader)
        {
            businessObject.DriverSpecificationID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverSpecificationID_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverID_bint.ToString())) == false)
            {
                businessObject.DriverID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverID_bint.ToString()));
            }
            else
            {
                businessObject.DriverID_bint = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc.ToString())) == false)
            {
                businessObject.DriverCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc.ToString()));
            }
            else
            {
                businessObject.DriverCardNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.FirstName_nvc.ToString())) == false)
            {
                businessObject.FirstName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.FirstName_nvc.ToString()));
            }
            else
            {
                businessObject.FirstName_nvc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.LastName_nvc.ToString())) == false)
            {
                businessObject.LastName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.LastName_nvc.ToString()));
            }
            else
            {
                businessObject.LastName_nvc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.licenceNumber_nvc.ToString())) == false)
            {
                businessObject.licenceNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.licenceNumber_nvc.ToString()));
            }
            else
            {
                businessObject.licenceNumber_nvc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.LicenceEnd_nvc.ToString())) == false)
            {
                businessObject.LicenceEnd_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.LicenceEnd_nvc.ToString()));
            }
            else
            {
                businessObject.LicenceEnd_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarExaminationEndDate_nvc.ToString())) == false)
            {
                businessObject.CarExaminationEndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarExaminationEndDate_nvc.ToString()));
            }
            else
            {
                businessObject.CarExaminationEndDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.InsuranceStartDate_nvc.ToString())) == false)
            {
                businessObject.InsuranceStartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.InsuranceStartDate_nvc.ToString()));
            }
            else
            {
                businessObject.InsuranceStartDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.InsuranceEndDate_nvc.ToString())) == false)
            {
                businessObject.InsuranceEndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.InsuranceEndDate_nvc.ToString()));
            }
            else
            {
                businessObject.InsuranceEndDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCardStartDate_nvc.ToString())) == false)
            {
                businessObject.HealthCardStartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCardStartDate_nvc.ToString()));
            }
            else
            {
                businessObject.HealthCardStartDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCardEndDate_nvc.ToString())) == false)
            {
                businessObject.HealthCardEndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCardEndDate_nvc.ToString()));
            }
            else
            {
                businessObject.HealthCardEndDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharjeStartDate_nvc.ToString())) == false)
            {
                businessObject.DriverCardSharjeStartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharjeStartDate_nvc.ToString()));
            }
            else
            {
                businessObject.DriverCardSharjeStartDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharjeEndDate_nvc.ToString())) == false)
            {
                businessObject.DriverCardSharjeEndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharjeEndDate_nvc.ToString()));
            }
            else
            {
                businessObject.DriverCardSharjeEndDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.ClassID_int.ToString())) == false)
            {
                businessObject.ClassID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.ClassID_int.ToString()));
            }
            else
            {
                businessObject.ClassID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarCardNumber_nvc.ToString())) == false)
            {
                businessObject.CarCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarCardNumber_nvc.ToString()));
            }
            else
            {
                businessObject.CarCardNumber_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.NationalCode_int.ToString())) == false)
            {
                businessObject.NationalCode_int = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.NationalCode_int.ToString()));
            }
            else
            {
                businessObject.NationalCode_int = null;
            }
        
            businessObject.CarExamination_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarExamination_bit.ToString()));
            businessObject.Insurance_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.Insurance_bit.ToString()));
            businessObject.HealthCard_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCard_bit.ToString()));
            businessObject.DriverCardSharje_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharje_bit.ToString()));
            businessObject.StatisticCard_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.StatisticCard_bit.ToString()));
        }

        public List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> list = new List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T>();
            while (dataReader.Read())
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T businessObject = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void SelectByDriverField(string FirstName, string LastName, Int64 NationalCode, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_DriverSpecification_T_SelectByField]";
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

    }
}