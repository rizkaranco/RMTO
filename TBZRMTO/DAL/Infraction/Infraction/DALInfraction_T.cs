using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.InfractionDAL
{
    class DALInfraction_T : DataLayerBase
    {

        public DALInfraction_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.InfractionBLL.BLLInfraction_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionID_int = new SqlParameter();
                InfractionID_int.ParameterName = "@InfractionID_int";
                InfractionID_int.SqlDbType = SqlDbType.Int;
                InfractionID_int.Direction = ParameterDirection.Output;
                InfractionID_int.IsNullable = false;
                InfractionID_int.Value = businessObject.InfractionID_int;
                this.Command.Parameters.Add(InfractionID_int);

                SqlParameter InfractionTypeID_int = new SqlParameter();
                InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
                InfractionTypeID_int.SqlDbType = SqlDbType.Int;
                InfractionTypeID_int.Direction = ParameterDirection.Input;
                InfractionTypeID_int.IsNullable = false;
                InfractionTypeID_int.Value = businessObject.InfractionTypeID_int;
                this.Command.Parameters.Add(InfractionTypeID_int);

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

                SqlParameter DriverFirstName_nvc = new SqlParameter();
                DriverFirstName_nvc.ParameterName = "@DriverFirstName_nvc";
                DriverFirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverFirstName_nvc.Direction = ParameterDirection.Input;
                DriverFirstName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverFirstName_nvc))
                {
                    DriverFirstName_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverFirstName_nvc.Value = businessObject.DriverFirstName_nvc;
                }
                this.Command.Parameters.Add(DriverFirstName_nvc);

                SqlParameter DriverLastName_nvc = new SqlParameter();
                DriverLastName_nvc.ParameterName = "@DriverLastName_nvc";
                DriverLastName_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverLastName_nvc.Direction = ParameterDirection.Input;
                DriverLastName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverLastName_nvc))
                {
                    DriverLastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverLastName_nvc.Value = businessObject.DriverLastName_nvc;
                }
                this.Command.Parameters.Add(DriverLastName_nvc);

                SqlParameter DriverLicenceNumber_int = new SqlParameter();
                DriverLicenceNumber_int.ParameterName = "@DriverLicenceNumber_int";
                DriverLicenceNumber_int.SqlDbType = SqlDbType.BigInt;
                DriverLicenceNumber_int.Direction = ParameterDirection.Input;
                DriverLicenceNumber_int.IsNullable = true;
                if (businessObject.DriverLicenceNumber_int.HasValue == false)
                {
                    DriverLicenceNumber_int.Value = DBNull.Value;
                }
                else
                {
                    DriverLicenceNumber_int.Value = businessObject.DriverLicenceNumber_int;
                }
                this.Command.Parameters.Add(DriverLicenceNumber_int);

                SqlParameter DriverNationalCode_bint = new SqlParameter();
                DriverNationalCode_bint.ParameterName = "@DriverNationalCode_bint";
                DriverNationalCode_bint.SqlDbType = SqlDbType.BigInt;
                DriverNationalCode_bint.Direction = ParameterDirection.Input;
                DriverNationalCode_bint.IsNullable = true;
                if (businessObject.DriverNationalCode_bint.HasValue == false)
                {
                    DriverNationalCode_bint.Value = DBNull.Value;
                }
                else
                {
                    DriverNationalCode_bint.Value = businessObject.DriverNationalCode_bint;
                }
                this.Command.Parameters.Add(DriverNationalCode_bint);

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

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.NumberPlate_nvc))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                }
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

                SqlParameter PlateCityCode_nvc = new SqlParameter();
                PlateCityCode_nvc.ParameterName = "@PlateCityCode_nvc";
                PlateCityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateCityCode_nvc.Direction = ParameterDirection.Input;
                PlateCityCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.PlateCityCode_nvc))
                {
                    PlateCityCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    PlateCityCode_nvc.Value = businessObject.PlateCityCode_nvc;
                }
                this.Command.Parameters.Add(PlateCityCode_nvc);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                if (businessObject.CompanyID_int.HasValue == false)
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = businessObject.CompanyID_int;
                }
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter CompanyCode_nvc = new SqlParameter();
                CompanyCode_nvc.ParameterName = "@CompanyCode_nvc";
                CompanyCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyCode_nvc.Direction = ParameterDirection.Input;
                CompanyCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CompanyCode_nvc))
                {
                    CompanyCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CompanyCode_nvc.Value = businessObject.CompanyCode_nvc;
                }
                this.Command.Parameters.Add(CompanyCode_nvc);

                SqlParameter CompanyName_nvc = new SqlParameter();
                CompanyName_nvc.ParameterName = "@CompanyName_nvc";
                CompanyName_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyName_nvc.Direction = ParameterDirection.Input;
                CompanyName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CompanyName_nvc))
                {
                    CompanyName_nvc.Value = DBNull.Value;
                }
                else
                {
                    CompanyName_nvc.Value = businessObject.CompanyName_nvc;
                }
                this.Command.Parameters.Add(CompanyName_nvc);

                SqlParameter RegisterUserName_nvc = new SqlParameter();
                RegisterUserName_nvc.ParameterName = "@RegisterUserName_nvc";
                RegisterUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                RegisterUserName_nvc.Direction = ParameterDirection.Input;
                RegisterUserName_nvc.IsNullable = false;
                RegisterUserName_nvc.Value = businessObject.RegisterUserName_nvc;
                this.Command.Parameters.Add(RegisterUserName_nvc);

                SqlParameter RegisterDate_nvc = new SqlParameter();
                RegisterDate_nvc.ParameterName = "@RegisterDate_nvc";
                RegisterDate_nvc.SqlDbType = SqlDbType.NVarChar;
                RegisterDate_nvc.Direction = ParameterDirection.Input;
                RegisterDate_nvc.IsNullable = false;
                RegisterDate_nvc.Value = businessObject.RegisterDate_nvc;
                this.Command.Parameters.Add(RegisterDate_nvc);

                SqlParameter RegisterTime_nvc = new SqlParameter();
                RegisterTime_nvc.ParameterName = "@RegisterTime_nvc";
                RegisterTime_nvc.SqlDbType = SqlDbType.NVarChar;
                RegisterTime_nvc.Direction = ParameterDirection.Input;
                RegisterTime_nvc.IsNullable = false;
                RegisterTime_nvc.Value = businessObject.RegisterTime_nvc;
                this.Command.Parameters.Add(RegisterTime_nvc);

                SqlParameter RegiaterComment_nvc = new SqlParameter();
                RegiaterComment_nvc.ParameterName = "@RegiaterComment_nvc";
                RegiaterComment_nvc.SqlDbType = SqlDbType.NVarChar;
                RegiaterComment_nvc.Direction = ParameterDirection.Input;
                RegiaterComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.RegiaterComment_nvc))
                {
                    RegiaterComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    RegiaterComment_nvc.Value = businessObject.RegiaterComment_nvc;
                }
                this.Command.Parameters.Add(RegiaterComment_nvc);

                SqlParameter SolverUserName_nvc = new SqlParameter();
                SolverUserName_nvc.ParameterName = "@SolverUserName_nvc";
                SolverUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                SolverUserName_nvc.Direction = ParameterDirection.Input;
                SolverUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolverUserName_nvc))
                {
                    SolverUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolverUserName_nvc.Value = businessObject.SolverUserName_nvc;
                }
                this.Command.Parameters.Add(SolverUserName_nvc);

                SqlParameter SolveDate_nvc = new SqlParameter();
                SolveDate_nvc.ParameterName = "@SolveDate_nvc";
                SolveDate_nvc.SqlDbType = SqlDbType.NVarChar;
                SolveDate_nvc.Direction = ParameterDirection.Input;
                SolveDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolveDate_nvc))
                {
                    SolveDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolveDate_nvc.Value = businessObject.SolveDate_nvc;
                }
                this.Command.Parameters.Add(SolveDate_nvc);

                SqlParameter SolveTime_nvc = new SqlParameter();
                SolveTime_nvc.ParameterName = "@SolveTime_nvc";
                SolveTime_nvc.SqlDbType = SqlDbType.NVarChar;
                SolveTime_nvc.Direction = ParameterDirection.Input;
                SolveTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolveTime_nvc))
                {
                    SolveTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolveTime_nvc.Value = businessObject.SolveTime_nvc;
                }
                this.Command.Parameters.Add(SolveTime_nvc);

                SqlParameter SolveComment_nvc = new SqlParameter();
                SolveComment_nvc.ParameterName = "@SolveComment_nvc";
                SolveComment_nvc.SqlDbType = SqlDbType.NVarChar;
                SolveComment_nvc.Direction = ParameterDirection.Input;
                SolveComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolveComment_nvc))
                {
                    SolveComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolveComment_nvc.Value = businessObject.SolveComment_nvc;
                }
                this.Command.Parameters.Add(SolveComment_nvc);

                SqlParameter PenaltyFee_dec = new SqlParameter();
                PenaltyFee_dec.ParameterName = "@PenaltyFee_dec";
                PenaltyFee_dec.SqlDbType = SqlDbType.Decimal;
                PenaltyFee_dec.Direction = ParameterDirection.Input;
                PenaltyFee_dec.IsNullable = true;
                if (businessObject.PenaltyFee_dec.HasValue == false)
                {
                    PenaltyFee_dec.Value = DBNull.Value;
                }
                else
                {
                    PenaltyFee_dec.Value = businessObject.PenaltyFee_dec;
                }
                this.Command.Parameters.Add(PenaltyFee_dec);

                SqlParameter OtherOffender_nvc = new SqlParameter();
                OtherOffender_nvc.ParameterName = "@OtherOffender_nvc";
                OtherOffender_nvc.SqlDbType = SqlDbType.NVarChar;
                OtherOffender_nvc.Direction = ParameterDirection.Input;
                OtherOffender_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.OtherOffender_nvc))
                {
                    OtherOffender_nvc.Value = DBNull.Value;
                }
                else
                {
                    OtherOffender_nvc.Value = businessObject.OtherOffender_nvc;
                }
                this.Command.Parameters.Add(OtherOffender_nvc);

                SqlParameter Traffic_bit = new SqlParameter();
                Traffic_bit.ParameterName = "@Traffic_bit";
                Traffic_bit.SqlDbType = SqlDbType.Bit;
                Traffic_bit.Direction = ParameterDirection.Input;
                Traffic_bit.IsNullable = false;
                Traffic_bit.Value = businessObject.Traffic_bit;
                this.Command.Parameters.Add(Traffic_bit);

                SqlParameter TurnAccept_bit = new SqlParameter();
                TurnAccept_bit.ParameterName = "@TurnAccept_bit";
                TurnAccept_bit.SqlDbType = SqlDbType.Bit;
                TurnAccept_bit.Direction = ParameterDirection.Input;
                TurnAccept_bit.IsNullable = false;
                TurnAccept_bit.Value = businessObject.TurnAccept_bit;
                this.Command.Parameters.Add(TurnAccept_bit);

                SqlParameter TurnSave_bit = new SqlParameter();
                TurnSave_bit.ParameterName = "@TurnSave_bit";
                TurnSave_bit.SqlDbType = SqlDbType.Bit;
                TurnSave_bit.Direction = ParameterDirection.Input;
                TurnSave_bit.IsNullable = false;
                TurnSave_bit.Value = businessObject.TurnSave_bit;
                this.Command.Parameters.Add(TurnSave_bit);

                SqlParameter Exit_bit = new SqlParameter();
                Exit_bit.ParameterName = "@Exit_bit";
                Exit_bit.SqlDbType = SqlDbType.Bit;
                Exit_bit.Direction = ParameterDirection.Input;
                Exit_bit.IsNullable = false;
                Exit_bit.Value = businessObject.Exit_bit;
                this.Command.Parameters.Add(Exit_bit);

                SqlParameter CommentControl_nvc = new SqlParameter();
                CommentControl_nvc.ParameterName = "@CommentControl_nvc";
                CommentControl_nvc.SqlDbType = SqlDbType.NVarChar;
                CommentControl_nvc.Direction = ParameterDirection.Input;
                CommentControl_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CommentControl_nvc))
                {
                    CommentControl_nvc.Value = DBNull.Value;
                }
                else
                {
                    CommentControl_nvc.Value = businessObject.CommentControl_nvc;
                }
                this.Command.Parameters.Add(CommentControl_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.InfractionID_int = (Int32)(this.Command.Parameters["@InfractionID_int"].Value);

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

        public void Update(HPS.BLL.InfractionBLL.BLLInfraction_T businessObject, HPS.BLL.InfractionBLL.BLLInfraction_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionTypeID_int = new SqlParameter();
                InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
                InfractionTypeID_int.SqlDbType = SqlDbType.Int;
                InfractionTypeID_int.Direction = ParameterDirection.Input;
                InfractionTypeID_int.IsNullable = false;
                InfractionTypeID_int.Value = businessObject.InfractionTypeID_int;
                this.Command.Parameters.Add(InfractionTypeID_int);

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

                SqlParameter DriverFirstName_nvc = new SqlParameter();
                DriverFirstName_nvc.ParameterName = "@DriverFirstName_nvc";
                DriverFirstName_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverFirstName_nvc.Direction = ParameterDirection.Input;
                DriverFirstName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverFirstName_nvc))
                {
                    DriverFirstName_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverFirstName_nvc.Value = businessObject.DriverFirstName_nvc;
                }
                this.Command.Parameters.Add(DriverFirstName_nvc);

                SqlParameter DriverLastName_nvc = new SqlParameter();
                DriverLastName_nvc.ParameterName = "@DriverLastName_nvc";
                DriverLastName_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverLastName_nvc.Direction = ParameterDirection.Input;
                DriverLastName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DriverLastName_nvc))
                {
                    DriverLastName_nvc.Value = DBNull.Value;
                }
                else
                {
                    DriverLastName_nvc.Value = businessObject.DriverLastName_nvc;
                }
                this.Command.Parameters.Add(DriverLastName_nvc);

                SqlParameter DriverLicenceNumber_int = new SqlParameter();
                DriverLicenceNumber_int.ParameterName = "@DriverLicenceNumber_int";
                DriverLicenceNumber_int.SqlDbType = SqlDbType.BigInt;
                DriverLicenceNumber_int.Direction = ParameterDirection.Input;
                DriverLicenceNumber_int.IsNullable = true;
                if (businessObject.DriverLicenceNumber_int.HasValue == false)
                {
                    DriverLicenceNumber_int.Value = DBNull.Value;
                }
                else
                {
                    DriverLicenceNumber_int.Value = businessObject.DriverLicenceNumber_int;
                }
                this.Command.Parameters.Add(DriverLicenceNumber_int);

                SqlParameter DriverNationalCode_bint = new SqlParameter();
                DriverNationalCode_bint.ParameterName = "@DriverNationalCode_bint";
                DriverNationalCode_bint.SqlDbType = SqlDbType.BigInt;
                DriverNationalCode_bint.Direction = ParameterDirection.Input;
                DriverNationalCode_bint.IsNullable = true;
                if (businessObject.DriverNationalCode_bint.HasValue == false)
                {
                    DriverNationalCode_bint.Value = DBNull.Value;
                }
                else
                {
                    DriverNationalCode_bint.Value = businessObject.DriverNationalCode_bint;
                }
                this.Command.Parameters.Add(DriverNationalCode_bint);

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

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.NumberPlate_nvc))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                }
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

                SqlParameter PlateCityCode_nvc = new SqlParameter();
                PlateCityCode_nvc.ParameterName = "@PlateCityCode_nvc";
                PlateCityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateCityCode_nvc.Direction = ParameterDirection.Input;
                PlateCityCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.PlateCityCode_nvc))
                {
                    PlateCityCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    PlateCityCode_nvc.Value = businessObject.PlateCityCode_nvc;
                }
                this.Command.Parameters.Add(PlateCityCode_nvc);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                if (businessObject.CompanyID_int.HasValue == false)
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = businessObject.CompanyID_int;
                }
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter CompanyCode_nvc = new SqlParameter();
                CompanyCode_nvc.ParameterName = "@CompanyCode_nvc";
                CompanyCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyCode_nvc.Direction = ParameterDirection.Input;
                CompanyCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CompanyCode_nvc))
                {
                    CompanyCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CompanyCode_nvc.Value = businessObject.CompanyCode_nvc;
                }
                this.Command.Parameters.Add(CompanyCode_nvc);

                SqlParameter CompanyName_nvc = new SqlParameter();
                CompanyName_nvc.ParameterName = "@CompanyName_nvc";
                CompanyName_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyName_nvc.Direction = ParameterDirection.Input;
                CompanyName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CompanyName_nvc))
                {
                    CompanyName_nvc.Value = DBNull.Value;
                }
                else
                {
                    CompanyName_nvc.Value = businessObject.CompanyName_nvc;
                }
                this.Command.Parameters.Add(CompanyName_nvc);

                SqlParameter RegisterUserName_nvc = new SqlParameter();
                RegisterUserName_nvc.ParameterName = "@RegisterUserName_nvc";
                RegisterUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                RegisterUserName_nvc.Direction = ParameterDirection.Input;
                RegisterUserName_nvc.IsNullable = true;
                RegisterUserName_nvc.Value = businessObject.RegisterUserName_nvc;
                this.Command.Parameters.Add(RegisterUserName_nvc);

                SqlParameter RegisterDate_nvc = new SqlParameter();
                RegisterDate_nvc.ParameterName = "@RegisterDate_nvc";
                RegisterDate_nvc.SqlDbType = SqlDbType.NVarChar;
                RegisterDate_nvc.Direction = ParameterDirection.Input;
                RegisterDate_nvc.IsNullable = false;
                RegisterDate_nvc.Value = businessObject.RegisterDate_nvc;
                this.Command.Parameters.Add(RegisterDate_nvc);

                SqlParameter RegisterTime_nvc = new SqlParameter();
                RegisterTime_nvc.ParameterName = "@RegisterTime_nvc";
                RegisterTime_nvc.SqlDbType = SqlDbType.NVarChar;
                RegisterTime_nvc.Direction = ParameterDirection.Input;
                RegisterTime_nvc.IsNullable = false;
                RegisterTime_nvc.Value = businessObject.RegisterTime_nvc;
                this.Command.Parameters.Add(RegisterTime_nvc);

                SqlParameter RegiaterComment_nvc = new SqlParameter();
                RegiaterComment_nvc.ParameterName = "@RegiaterComment_nvc";
                RegiaterComment_nvc.SqlDbType = SqlDbType.NVarChar;
                RegiaterComment_nvc.Direction = ParameterDirection.Input;
                RegiaterComment_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.RegiaterComment_nvc))
                {
                    RegiaterComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    RegiaterComment_nvc.Value = businessObject.RegiaterComment_nvc;
                }
                this.Command.Parameters.Add(RegiaterComment_nvc);

                SqlParameter SolverUserName_nvc = new SqlParameter();
                SolverUserName_nvc.ParameterName = "@SolverUserName_nvc";
                SolverUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                SolverUserName_nvc.Direction = ParameterDirection.Input;
                SolverUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolverUserName_nvc))
                {
                    SolverUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolverUserName_nvc.Value = businessObject.SolverUserName_nvc;
                }
                this.Command.Parameters.Add(SolverUserName_nvc);

                SqlParameter SolveDate_nvc = new SqlParameter();
                SolveDate_nvc.ParameterName = "@SolveDate_nvc";
                SolveDate_nvc.SqlDbType = SqlDbType.NVarChar;
                SolveDate_nvc.Direction = ParameterDirection.Input;
                SolveDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolveDate_nvc))
                {
                    SolveDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolveDate_nvc.Value = businessObject.SolveDate_nvc;
                }
                this.Command.Parameters.Add(SolveDate_nvc);

                SqlParameter SolveTime_nvc = new SqlParameter();
                SolveTime_nvc.ParameterName = "@SolveTime_nvc";
                SolveTime_nvc.SqlDbType = SqlDbType.NVarChar;
                SolveTime_nvc.Direction = ParameterDirection.Input;
                SolveTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolveTime_nvc))
                {
                    SolveTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolveTime_nvc.Value = businessObject.SolveTime_nvc;
                }
                this.Command.Parameters.Add(SolveTime_nvc);

                SqlParameter SolveComment_nvc = new SqlParameter();
                SolveComment_nvc.ParameterName = "@SolveComment_nvc";
                SolveComment_nvc.SqlDbType = SqlDbType.NVarChar;
                SolveComment_nvc.Direction = ParameterDirection.Input;
                SolveComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SolveComment_nvc))
                {
                    SolveComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    SolveComment_nvc.Value = businessObject.SolveComment_nvc;
                }
                this.Command.Parameters.Add(SolveComment_nvc);

                SqlParameter PenaltyFee_dec = new SqlParameter();
                PenaltyFee_dec.ParameterName = "@PenaltyFee_dec";
                PenaltyFee_dec.SqlDbType = SqlDbType.Decimal;
                PenaltyFee_dec.Direction = ParameterDirection.Input;
                PenaltyFee_dec.IsNullable = true;
                if (businessObject.PenaltyFee_dec.HasValue == false)
                {
                    PenaltyFee_dec.Value = DBNull.Value;
                }
                else
                {
                    PenaltyFee_dec.Value = businessObject.PenaltyFee_dec;
                }
                this.Command.Parameters.Add(PenaltyFee_dec);

                SqlParameter OtherOffender_nvc = new SqlParameter();
                OtherOffender_nvc.ParameterName = "@OtherOffender_nvc";
                OtherOffender_nvc.SqlDbType = SqlDbType.NVarChar;
                OtherOffender_nvc.Direction = ParameterDirection.Input;
                OtherOffender_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.OtherOffender_nvc))
                {
                    OtherOffender_nvc.Value = DBNull.Value;
                }
                else
                {
                    OtherOffender_nvc.Value = businessObject.OtherOffender_nvc;
                }
                this.Command.Parameters.Add(OtherOffender_nvc);

                SqlParameter Traffic_bit = new SqlParameter();
                Traffic_bit.ParameterName = "@Traffic_bit";
                Traffic_bit.SqlDbType = SqlDbType.Bit;
                Traffic_bit.Direction = ParameterDirection.Input;
                Traffic_bit.IsNullable = false;
                Traffic_bit.Value = businessObject.Traffic_bit;
                this.Command.Parameters.Add(Traffic_bit);

                SqlParameter TurnAccept_bit = new SqlParameter();
                TurnAccept_bit.ParameterName = "@TurnAccept_bit";
                TurnAccept_bit.SqlDbType = SqlDbType.Bit;
                TurnAccept_bit.Direction = ParameterDirection.Input;
                TurnAccept_bit.IsNullable = false;
                TurnAccept_bit.Value = businessObject.TurnAccept_bit;
                this.Command.Parameters.Add(TurnAccept_bit);

                SqlParameter TurnSave_bit = new SqlParameter();
                TurnSave_bit.ParameterName = "@TurnSave_bit";
                TurnSave_bit.SqlDbType = SqlDbType.Bit;
                TurnSave_bit.Direction = ParameterDirection.Input;
                TurnSave_bit.IsNullable = false;
                TurnSave_bit.Value = businessObject.TurnSave_bit;
                this.Command.Parameters.Add(TurnSave_bit);

                SqlParameter Exit_bit = new SqlParameter();
                Exit_bit.ParameterName = "@Exit_bit";
                Exit_bit.SqlDbType = SqlDbType.Bit;
                Exit_bit.Direction = ParameterDirection.Input;
                Exit_bit.IsNullable = false;
                Exit_bit.Value = businessObject.Exit_bit;
                this.Command.Parameters.Add(Exit_bit);

                SqlParameter pk_InfractionID_int = new SqlParameter();
                pk_InfractionID_int.ParameterName = "@pk_InfractionID_int";
                pk_InfractionID_int.SqlDbType = SqlDbType.Int;
                pk_InfractionID_int.Direction = ParameterDirection.Input;
                pk_InfractionID_int.IsNullable = false;
                pk_InfractionID_int.Value = businessObjectKey.InfractionID_int;
                this.Command.Parameters.Add(pk_InfractionID_int);

                SqlParameter CommentControl_nvc = new SqlParameter();
                CommentControl_nvc.ParameterName = "@CommentControl_nvc";
                CommentControl_nvc.SqlDbType = SqlDbType.NVarChar;
                CommentControl_nvc.Direction = ParameterDirection.Input;
                CommentControl_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CommentControl_nvc))
                {
                    CommentControl_nvc.Value = DBNull.Value;
                }
                else
                {
                    CommentControl_nvc.Value = businessObject.CommentControl_nvc;
                }
                this.Command.Parameters.Add(CommentControl_nvc);

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

        public List<HPS.BLL.InfractionBLL.BLLInfraction_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> Result = new List<HPS.BLL.InfractionBLL.BLLInfraction_T>();
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
            this.Command.CommandText = "[sp_Infraction_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Infraction_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Infraction_T_SelectAll]";
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

        public HPS.BLL.InfractionBLL.BLLInfraction_T SelectByPrimaryKey(HPS.BLL.InfractionBLL.BLLInfraction_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionID_int = new SqlParameter();
                InfractionID_int.ParameterName = "@InfractionID_int";
                InfractionID_int.SqlDbType = SqlDbType.Int;
                InfractionID_int.Direction = ParameterDirection.Input;
                InfractionID_int.IsNullable = false;
                InfractionID_int.Value = businessObjectKey.InfractionID_int;
                this.Command.Parameters.Add(InfractionID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.InfractionBLL.BLLInfraction_T businessObject = new HPS.BLL.InfractionBLL.BLLInfraction_T();
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

        public void SelectByPrimaryKey(HPS.BLL.InfractionBLL.BLLInfraction_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Infraction_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionID_int = new SqlParameter();
                InfractionID_int.ParameterName = "@InfractionID_int";
                InfractionID_int.SqlDbType = SqlDbType.Int;
                InfractionID_int.Direction = ParameterDirection.Input;
                InfractionID_int.IsNullable = false;
                InfractionID_int.Value = businessObjectKey.InfractionID_int;
                this.Command.Parameters.Add(InfractionID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.InfractionBLL.BLLInfraction_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Infraction_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionID_int = new SqlParameter();
                InfractionID_int.ParameterName = "@InfractionID_int";
                InfractionID_int.SqlDbType = SqlDbType.Int;
                InfractionID_int.Direction = ParameterDirection.Input;
                InfractionID_int.IsNullable = false;
                InfractionID_int.Value = businessObjectKey.InfractionID_int;
                this.Command.Parameters.Add(InfractionID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.InfractionBLL.BLLInfraction_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Infraction_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionID_int = new SqlParameter();
                InfractionID_int.ParameterName = "@InfractionID_int";
                InfractionID_int.SqlDbType = SqlDbType.Int;
                InfractionID_int.Direction = ParameterDirection.Input;
                InfractionID_int.IsNullable = false;
                InfractionID_int.Value = businessObjectKey.InfractionID_int;
                this.Command.Parameters.Add(InfractionID_int);



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





        public List<HPS.BLL.InfractionBLL.BLLInfraction_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Infraction_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> Result = new List<HPS.BLL.InfractionBLL.BLLInfraction_T>();
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
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Infraction_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Infraction_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Infraction_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.InfractionBLL.BLLInfraction_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
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
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> Result = new List<HPS.BLL.InfractionBLL.BLLInfraction_T>();
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
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Infraction_T_SelectCondition]";
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

        public void Delete(HPS.BLL.InfractionBLL.BLLInfraction_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Infraction_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InfractionID_int = new SqlParameter();
                InfractionID_int.ParameterName = "@InfractionID_int";
                InfractionID_int.SqlDbType = SqlDbType.Int;
                InfractionID_int.Direction = ParameterDirection.Input;
                InfractionID_int.IsNullable = false;
                InfractionID_int.Value = businessObjectKey.InfractionID_int;
                this.Command.Parameters.Add(InfractionID_int);


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
            this.Command.CommandText = "[sp_Infraction_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.InfractionBLL.BLLInfraction_T businessObject, IDataReader dataReader)
        {
            businessObject.InfractionID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionID_int.ToString()));
            businessObject.InfractionTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionTypeID_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverID_bint.ToString())) == false)
            {
                businessObject.DriverID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverID_bint.ToString()));
            }
            else
            {
                businessObject.DriverID_bint = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverFirstName_nvc.ToString())) == false)
            {
                businessObject.DriverFirstName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverFirstName_nvc.ToString()));
            }
            else
            {
                businessObject.DriverFirstName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLastName_nvc.ToString())) == false)
            {
                businessObject.DriverLastName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLastName_nvc.ToString()));
            }
            else
            {
                businessObject.DriverLastName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLicenceNumber_int.ToString())) == false)
            {
                businessObject.DriverLicenceNumber_int = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLicenceNumber_int.ToString()));
            }
            else
            {
                businessObject.DriverLicenceNumber_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverNationalCode_bint.ToString())) == false)
            {
                businessObject.DriverNationalCode_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverNationalCode_bint.ToString()));
            }
            else
            {
                businessObject.DriverNationalCode_bint = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CarID_int.ToString())) == false)
            {
                businessObject.CarID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CarID_int.ToString()));
            }
            else
            {
                businessObject.CarID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.NumberPlate_nvc.ToString())) == false)
            {
                businessObject.NumberPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.NumberPlate_nvc.ToString()));
            }
            else
            {
                businessObject.NumberPlate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SerialPlate_nvc.ToString())) == false)
            {
                businessObject.SerialPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SerialPlate_nvc.ToString()));
            }
            else
            {
                businessObject.SerialPlate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PlateCityCode_nvc.ToString())) == false)
            {
                businessObject.PlateCityCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PlateCityCode_nvc.ToString()));
            }
            else
            {
                businessObject.PlateCityCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyID_int.ToString())) == false)
            {
                businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyID_int.ToString()));
            }
            else
            {
                businessObject.CompanyID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyCode_nvc.ToString())) == false)
            {
                businessObject.CompanyCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyCode_nvc.ToString()));
            }
            else
            {
                businessObject.CompanyCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyName_nvc.ToString())) == false)
            {
                businessObject.CompanyName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyName_nvc.ToString()));
            }
            else
            {
                businessObject.CompanyName_nvc = String.Empty;
            }

            businessObject.RegisterUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterUserName_nvc.ToString()));
            businessObject.RegisterDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterDate_nvc.ToString()));
            businessObject.RegisterTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterTime_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegiaterComment_nvc.ToString())) == false)
            {
                businessObject.RegiaterComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegiaterComment_nvc.ToString()));
            }
            else
            {
                businessObject.RegiaterComment_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolverUserName_nvc.ToString())) == false)
            {
                businessObject.SolverUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolverUserName_nvc.ToString()));
            }
            else
            {
                businessObject.SolverUserName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveDate_nvc.ToString())) == false)
            {
                businessObject.SolveDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveDate_nvc.ToString()));
            }
            else
            {
                businessObject.SolveDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveTime_nvc.ToString())) == false)
            {
                businessObject.SolveTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveTime_nvc.ToString()));
            }
            else
            {
                businessObject.SolveTime_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveComment_nvc.ToString())) == false)
            {
                businessObject.SolveComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveComment_nvc.ToString()));
            }
            else
            {
                businessObject.SolveComment_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PenaltyFee_dec.ToString())) == false)
            {
                businessObject.PenaltyFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PenaltyFee_dec.ToString()));
            }
            else
            {
                businessObject.PenaltyFee_dec = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.OtherOffender_nvc.ToString())) == false)
            {
                businessObject.OtherOffender_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.OtherOffender_nvc.ToString()));
            }
            else
            {
                businessObject.OtherOffender_nvc = String.Empty;
            }
           
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionGroupID_int.ToString())) == false)
            {
                businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionGroupID_int.ToString()));
            }
            else
            {
                businessObject.InfractionGroupID_int = null;
            }
            businessObject.Traffic_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.Traffic_bit.ToString()));
            businessObject.TurnAccept_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.TurnAccept_bit.ToString()));
            businessObject.TurnSave_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.TurnSave_bit.ToString()));
            businessObject.Exit_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.Exit_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CommentControl_nvc.ToString())) == false)
            {
                businessObject.CommentControl_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CommentControl_nvc.ToString()));
            }
            else
            {
                businessObject.CommentControl_nvc = String.Empty;
            }
        }

        public List<HPS.BLL.InfractionBLL.BLLInfraction_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.InfractionBLL.BLLInfraction_T> list = new List<HPS.BLL.InfractionBLL.BLLInfraction_T>();
            while (dataReader.Read())
            {
                HPS.BLL.InfractionBLL.BLLInfraction_T businessObject = new HPS.BLL.InfractionBLL.BLLInfraction_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void SelectInfraction(Nullable< Int64> AcceptedTurnNumber_bint,Nullable < Int64> TrafficNumber_bint, String NumberPlate_nvc, String SerialPlate_nvc, ref DataTable DataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InfractionSelect]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AcceptedTurnNumber = new SqlParameter();
                AcceptedTurnNumber.ParameterName = "@AcceptedTurnNumber_bint";
                AcceptedTurnNumber.Direction = ParameterDirection.Input;
                AcceptedTurnNumber.SqlDbType = SqlDbType.BigInt;
                AcceptedTurnNumber.IsNullable = true;
                if (AcceptedTurnNumber_bint != null)
                {
                    AcceptedTurnNumber.Value = AcceptedTurnNumber_bint;
                }
                else
                {
                    AcceptedTurnNumber.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(AcceptedTurnNumber);

                SqlParameter TrafficNumber = new SqlParameter();
                TrafficNumber.ParameterName = "@TrafficNumber_bint";
                TrafficNumber.Direction = ParameterDirection.Input;
                TrafficNumber.SqlDbType = SqlDbType.BigInt;
                TrafficNumber.IsNullable = true;
                if (TrafficNumber_bint != null)
                {
                    TrafficNumber.Value = TrafficNumber_bint;
                }
                else
                {
                    TrafficNumber.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(TrafficNumber);

                SqlParameter NumberPlate= new SqlParameter();
                NumberPlate.ParameterName = "@NumberPlate_nvc";
                NumberPlate.Direction = ParameterDirection.Input;
                NumberPlate.SqlDbType = SqlDbType.NVarChar ;
                NumberPlate.IsNullable = true;
                if (string.IsNullOrEmpty(NumberPlate_nvc)==false )
                {
                    NumberPlate.Value = NumberPlate_nvc;
                }
                else
                {
                    NumberPlate.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(NumberPlate);

                SqlParameter SerialPlate = new SqlParameter();
                SerialPlate.ParameterName = "@SerialPlate_nvc";
                SerialPlate.Direction = ParameterDirection.Input;
                SerialPlate.SqlDbType = SqlDbType.NVarChar ;
                SerialPlate.IsNullable = true;
                if (string.IsNullOrEmpty(SerialPlate_nvc)==false )
                {
                    SerialPlate.Value = SerialPlate_nvc;
                }
                else
                {
                    SerialPlate.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(SerialPlate);

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
    }
}