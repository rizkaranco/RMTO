using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.StopFeeDAL
{
    class DALStopFee_T : DataLayerBase
    {

        public DALStopFee_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.StopFeeBLL.BLLStopFee_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Output;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObject.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);

                SqlParameter AllowedHoure_int = new SqlParameter();
                AllowedHoure_int.ParameterName = "@AllowedHoure_int";
                AllowedHoure_int.SqlDbType = SqlDbType.Int;
                AllowedHoure_int.Direction = ParameterDirection.Input;
                AllowedHoure_int.IsNullable = false;
                AllowedHoure_int.Value = businessObject.AllowedHoure_int;
                this.Command.Parameters.Add(AllowedHoure_int);

                SqlParameter Fee_dec = new SqlParameter();
                Fee_dec.ParameterName = "@Fee_dec";
                Fee_dec.SqlDbType = SqlDbType.Decimal;
                Fee_dec.Direction = ParameterDirection.Input;
                Fee_dec.IsNullable = false;
                Fee_dec.Value = businessObject.Fee_dec;
                this.Command.Parameters.Add(Fee_dec);

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
                ExtraHourFee_dec.IsNullable = true;
                if (businessObject.ExtraHourFee_dec.HasValue == false)
                {
                    ExtraHourFee_dec.Value = DBNull.Value;
                }
                else
                {
                    ExtraHourFee_dec.Value = businessObject.ExtraHourFee_dec;
                }
                this.Command.Parameters.Add(ExtraHourFee_dec);

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

                SqlParameter LaderPivotGroupID_int = new SqlParameter();
                LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
                LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
                LaderPivotGroupID_int.Direction = ParameterDirection.Input;
                LaderPivotGroupID_int.IsNullable = true;
                if (businessObject.LaderPivotGroupID_int.HasValue == false)
                {
                    LaderPivotGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderPivotGroupID_int.Value = businessObject.LaderPivotGroupID_int;
                }
                this.Command.Parameters.Add(LaderPivotGroupID_int);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.StartDate_nvc))
                {
                    StartDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    StartDate_nvc.Value = businessObject.StartDate_nvc;
                }
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EndDate_nvc))
                {
                    EndDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    EndDate_nvc.Value = businessObject.EndDate_nvc;
                }
                this.Command.Parameters.Add(EndDate_nvc);

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

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter WithLadeExtraHourFee_dec = new SqlParameter();
                WithLadeExtraHourFee_dec.ParameterName = "@WithLadeExtraHourFee_dec";
                WithLadeExtraHourFee_dec.SqlDbType = SqlDbType.Decimal;
                WithLadeExtraHourFee_dec.Direction = ParameterDirection.Input;
                WithLadeExtraHourFee_dec.IsNullable = true;
                if (businessObject.WithLadeExtraHourFee_dec.HasValue == false)
                {
                    WithLadeExtraHourFee_dec.Value = DBNull.Value;
                }
                else
                {
                    WithLadeExtraHourFee_dec.Value = businessObject.WithLadeExtraHourFee_dec;
                }
                this.Command.Parameters.Add(WithLadeExtraHourFee_dec);

                SqlParameter ServicesID_int = new SqlParameter();
                ServicesID_int.ParameterName = "@ServicesID_int";
                ServicesID_int.SqlDbType = SqlDbType.Int;
                ServicesID_int.Direction = ParameterDirection.Input;
                ServicesID_int.IsNullable = true;
                if (businessObject.ServicesID_int.HasValue == false)
                {
                    ServicesID_int.Value = DBNull.Value;
                }
                else
                {
                    ServicesID_int.Value = businessObject.ServicesID_int;
                }
                this.Command.Parameters.Add(ServicesID_int);

                SqlParameter Tax_bit = new SqlParameter();
                Tax_bit.ParameterName = "@Tax_bit";
                Tax_bit.SqlDbType = SqlDbType.Bit;
                Tax_bit.Direction = ParameterDirection.Input;
                Tax_bit.IsNullable = false;
                Tax_bit.Value = businessObject.Tax_bit;
                this.Command.Parameters.Add(Tax_bit);

                SqlParameter TurnNotLadBillExtraHour_int = new SqlParameter();
                TurnNotLadBillExtraHour_int.ParameterName = "@TurnNotLadBillExtraHour_int";
                TurnNotLadBillExtraHour_int.SqlDbType = SqlDbType.Int;
                TurnNotLadBillExtraHour_int.Direction = ParameterDirection.Input;
                TurnNotLadBillExtraHour_int.IsNullable = false;
                if (businessObject.TurnNotLadBillExtraHour_int.HasValue == false)
                {
                    TurnNotLadBillExtraHour_int.Value = DBNull.Value;
                }
                else
                {
                    TurnNotLadBillExtraHour_int.Value = businessObject.TurnNotLadBillExtraHour_int;
                }
                this.Command.Parameters.Add(TurnNotLadBillExtraHour_int);

                SqlParameter TurnNotLadBillExtraHourFee_dec = new SqlParameter();
                TurnNotLadBillExtraHourFee_dec.ParameterName = "@TurnNotLadBillExtraHourFee_dec";
                TurnNotLadBillExtraHourFee_dec.SqlDbType = SqlDbType.Decimal;
                TurnNotLadBillExtraHourFee_dec.Direction = ParameterDirection.Input;
                TurnNotLadBillExtraHourFee_dec.IsNullable = true;
                if (businessObject.TurnNotLadBillExtraHourFee_dec.HasValue == false)
                {
                    TurnNotLadBillExtraHourFee_dec.Value = DBNull.Value;
                }
                else
                {
                    TurnNotLadBillExtraHourFee_dec.Value = businessObject.TurnNotLadBillExtraHourFee_dec;
                }
                this.Command.Parameters.Add(TurnNotLadBillExtraHourFee_dec);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.StopFeeID_int = (Int32)(this.Command.Parameters["@StopFeeID_int"].Value);

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

        public void Update(HPS.BLL.StopFeeBLL.BLLStopFee_T businessObject, HPS.BLL.StopFeeBLL.BLLStopFee_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AllowedHoure_int = new SqlParameter();
                AllowedHoure_int.ParameterName = "@AllowedHoure_int";
                AllowedHoure_int.SqlDbType = SqlDbType.Int;
                AllowedHoure_int.Direction = ParameterDirection.Input;
                AllowedHoure_int.IsNullable = false;
                AllowedHoure_int.Value = businessObject.AllowedHoure_int;
                this.Command.Parameters.Add(AllowedHoure_int);

                SqlParameter Fee_dec = new SqlParameter();
                Fee_dec.ParameterName = "@Fee_dec";
                Fee_dec.SqlDbType = SqlDbType.Decimal;
                Fee_dec.Direction = ParameterDirection.Input;
                Fee_dec.IsNullable = false;
                Fee_dec.Value = businessObject.Fee_dec;
                this.Command.Parameters.Add(Fee_dec);

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
                if (businessObject.ExtraHourFee_dec.HasValue == false)
                {
                    ExtraHourFee_dec.Value = DBNull.Value;
                }
                else
                {
                    ExtraHourFee_dec.Value = businessObject.ExtraHourFee_dec;
                }
                this.Command.Parameters.Add(ExtraHourFee_dec);

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

                SqlParameter LaderPivotGroupID_int = new SqlParameter();
                LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
                LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
                LaderPivotGroupID_int.Direction = ParameterDirection.Input;
                LaderPivotGroupID_int.IsNullable = true;
                if (businessObject.LaderPivotGroupID_int.HasValue == false)
                {
                    LaderPivotGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderPivotGroupID_int.Value = businessObject.LaderPivotGroupID_int;
                }
                this.Command.Parameters.Add(LaderPivotGroupID_int);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.StartDate_nvc))
                {
                    StartDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    StartDate_nvc.Value = businessObject.StartDate_nvc;
                }
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EndDate_nvc))
                {
                    EndDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    EndDate_nvc.Value = businessObject.EndDate_nvc;
                }
                this.Command.Parameters.Add(EndDate_nvc);

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

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter WithLadeExtraHourFee_dec = new SqlParameter();
                WithLadeExtraHourFee_dec.ParameterName = "@WithLadeExtraHourFee_dec";
                WithLadeExtraHourFee_dec.SqlDbType = SqlDbType.Decimal;
                WithLadeExtraHourFee_dec.Direction = ParameterDirection.Input;
                WithLadeExtraHourFee_dec.IsNullable = true;
                if (businessObject.WithLadeExtraHourFee_dec.HasValue == false)
                {
                    WithLadeExtraHourFee_dec.Value = DBNull.Value;
                }
                else
                {
                    WithLadeExtraHourFee_dec.Value = businessObject.WithLadeExtraHourFee_dec;
                }
                this.Command.Parameters.Add(WithLadeExtraHourFee_dec);

                SqlParameter ServicesID_int = new SqlParameter();
                ServicesID_int.ParameterName = "@ServicesID_int";
                ServicesID_int.SqlDbType = SqlDbType.Int;
                ServicesID_int.Direction = ParameterDirection.Input;
                ServicesID_int.IsNullable = true;
                if (businessObject.ServicesID_int.HasValue == false)
                {
                    ServicesID_int.Value = DBNull.Value;
                }
                else
                {
                    ServicesID_int.Value = businessObject.ServicesID_int;
                }
                this.Command.Parameters.Add(ServicesID_int);

                SqlParameter Tax_bit = new SqlParameter();
                Tax_bit.ParameterName = "@Tax_bit";
                Tax_bit.SqlDbType = SqlDbType.Bit;
                Tax_bit.Direction = ParameterDirection.Input;
                Tax_bit.IsNullable = false;
                Tax_bit.Value = businessObject.Tax_bit;
                this.Command.Parameters.Add(Tax_bit);


                SqlParameter pk_StopFeeID_int = new SqlParameter();
                pk_StopFeeID_int.ParameterName = "@pk_StopFeeID_int";
                pk_StopFeeID_int.SqlDbType = SqlDbType.Int;
                pk_StopFeeID_int.Direction = ParameterDirection.Input;
                pk_StopFeeID_int.IsNullable = false;
                pk_StopFeeID_int.Value = businessObjectKey.StopFeeID_int;
                this.Command.Parameters.Add(pk_StopFeeID_int);

                SqlParameter TurnNotLadBillExtraHour_int = new SqlParameter();
                TurnNotLadBillExtraHour_int.ParameterName = "@TurnNotLadBillExtraHour_int";
                TurnNotLadBillExtraHour_int.SqlDbType = SqlDbType.Int;
                TurnNotLadBillExtraHour_int.Direction = ParameterDirection.Input;
                TurnNotLadBillExtraHour_int.IsNullable = false;
                if (businessObject.TurnNotLadBillExtraHour_int.HasValue == false)
                {
                    TurnNotLadBillExtraHour_int.Value = DBNull.Value;
                }
                else
                {
                    TurnNotLadBillExtraHour_int.Value = businessObject.TurnNotLadBillExtraHour_int;
                }
                this.Command.Parameters.Add(TurnNotLadBillExtraHour_int);

                SqlParameter TurnNotLadBillExtraHourFee_dec = new SqlParameter();
                TurnNotLadBillExtraHourFee_dec.ParameterName = "@TurnNotLadBillExtraHourFee_dec";
                TurnNotLadBillExtraHourFee_dec.SqlDbType = SqlDbType.Decimal;
                TurnNotLadBillExtraHourFee_dec.Direction = ParameterDirection.Input;
                TurnNotLadBillExtraHourFee_dec.IsNullable = true;
                if (businessObject.TurnNotLadBillExtraHourFee_dec.HasValue == false)
                {
                    TurnNotLadBillExtraHourFee_dec.Value = DBNull.Value;
                }
                else
                {
                    TurnNotLadBillExtraHourFee_dec.Value = businessObject.TurnNotLadBillExtraHourFee_dec;
                }
                this.Command.Parameters.Add(TurnNotLadBillExtraHourFee_dec);

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

        public List<HPS.BLL.StopFeeBLL.BLLStopFee_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> Result = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
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
            this.Command.CommandText = "[sp_StopFee_T_SelectAll]";
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
            this.Command.CommandText = "[sp_StopFee_T_SelectAll]";
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
            this.Command.CommandText = "[sp_StopFee_T_SelectAll]";
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

        public HPS.BLL.StopFeeBLL.BLLStopFee_T SelectByPrimaryKey(HPS.BLL.StopFeeBLL.BLLStopFee_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObjectKey.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.StopFeeBLL.BLLStopFee_T businessObject = new HPS.BLL.StopFeeBLL.BLLStopFee_T();
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

        public void SelectByPrimaryKey(HPS.BLL.StopFeeBLL.BLLStopFee_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_StopFee_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObjectKey.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.StopFeeBLL.BLLStopFee_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_StopFee_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObjectKey.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.StopFeeBLL.BLLStopFee_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_StopFee_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObjectKey.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);



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





        public List<HPS.BLL.StopFeeBLL.BLLStopFee_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[StopFee_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> Result = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
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
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[StopFee_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[StopFee_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[StopFee_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.StopFeeBLL.BLLStopFee_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
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
                List<HPS.BLL.StopFeeBLL.BLLStopFee_T> Result = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
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
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_StopFee_T_SelectCondition]";
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

        public void Delete(HPS.BLL.StopFeeBLL.BLLStopFee_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_StopFee_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter StopFeeID_int = new SqlParameter();
                StopFeeID_int.ParameterName = "@StopFeeID_int";
                StopFeeID_int.SqlDbType = SqlDbType.Int;
                StopFeeID_int.Direction = ParameterDirection.Input;
                StopFeeID_int.IsNullable = false;
                StopFeeID_int.Value = businessObjectKey.StopFeeID_int;
                this.Command.Parameters.Add(StopFeeID_int);


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
            this.Command.CommandText = "[sp_StopFee_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.StopFeeBLL.BLLStopFee_T businessObject, IDataReader dataReader)
        {
            businessObject.StopFeeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StopFeeID_int.ToString()));
            businessObject.AllowedHoure_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.AllowedHoure_int.ToString()));
            businessObject.Fee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Fee_dec.ToString()));
            businessObject.ExtraHour_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHour_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHourFee_dec.ToString())) == false)
            {
                businessObject.ExtraHourFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ExtraHourFee_dec.ToString()));
            }
            else
            {
                businessObject.ExtraHourFee_dec = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TrafficTypeID_int.ToString())) == false)
            {
                businessObject.TrafficTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TrafficTypeID_int.ToString()));
            }
            else
            {
                businessObject.TrafficTypeID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.LaderPivotGroupID_int.ToString())) == false)
            {
                businessObject.LaderPivotGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.LaderPivotGroupID_int.ToString()));
            }
            else
            {
                businessObject.LaderPivotGroupID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StartDate_nvc.ToString())) == false)
            {
                businessObject.StartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.StartDate_nvc.ToString()));
            }
            else
            {
                businessObject.StartDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.EndDate_nvc.ToString())) == false)
            {
                businessObject.EndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.EndDate_nvc.ToString()));
            }
            else
            {
                businessObject.EndDate_nvc = String.Empty;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.UserName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.WithLadeExtraHourFee_dec.ToString())) == false)
            {
                businessObject.WithLadeExtraHourFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.WithLadeExtraHourFee_dec.ToString()));
            }
            else
            {
                businessObject.WithLadeExtraHourFee_dec = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ServicesID_int.ToString())) == false)
            {
                businessObject.ServicesID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.ServicesID_int.ToString()));
            }
            else
            {
                businessObject.ServicesID_int = null;
            }
            businessObject.Tax_bit = dataReader.GetBoolean (dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.Tax_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHour_int.ToString())) == false)
            {
                businessObject.TurnNotLadBillExtraHour_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHour_int.ToString()));
            }
            else
            {
                businessObject.TurnNotLadBillExtraHour_int = null;
            }
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHourFee_dec.ToString())) == false)
            {
                businessObject.TurnNotLadBillExtraHourFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.StopFeeBLL.BLLStopFee_T.StopFee_TField.TurnNotLadBillExtraHourFee_dec.ToString()));
            }
            else
            {
                businessObject.TurnNotLadBillExtraHourFee_dec = null;
            }
        }

        public List<HPS.BLL.StopFeeBLL.BLLStopFee_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.StopFeeBLL.BLLStopFee_T> list = new List<HPS.BLL.StopFeeBLL.BLLStopFee_T>();
            while (dataReader.Read())
            {
                HPS.BLL.StopFeeBLL.BLLStopFee_T businessObject = new HPS.BLL.StopFeeBLL.BLLStopFee_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}