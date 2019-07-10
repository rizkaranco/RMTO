using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CardCheckingLogDAL
{
    public partial class DALCardCheckingLog_T : DataLayerBase
    {

        public DALCardCheckingLog_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardCheckingLogID_int = new SqlParameter();
                CardCheckingLogID_int.ParameterName = "@CardCheckingLogID_int";
                CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                CardCheckingLogID_int.Direction = ParameterDirection.Output;
                CardCheckingLogID_int.IsNullable = false;
                CardCheckingLogID_int.Value = businessObject.CardCheckingLogID_int;
                this.Command.Parameters.Add(CardCheckingLogID_int);

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = false;
                Date_vc.Value = businessObject.Date_vc;
                this.Command.Parameters.Add(Date_vc);

                SqlParameter Time_vc = new SqlParameter();
                Time_vc.ParameterName = "@Time_vc";
                Time_vc.SqlDbType = SqlDbType.VarChar;
                Time_vc.Direction = ParameterDirection.Input;
                Time_vc.IsNullable = false;
                Time_vc.Value = businessObject.Time_vc;
                this.Command.Parameters.Add(Time_vc);

                SqlParameter OperationType_nvc = new SqlParameter();
                OperationType_nvc.ParameterName = "@OperationType_nvc";
                OperationType_nvc.SqlDbType = SqlDbType.NVarChar;
                OperationType_nvc.Direction = ParameterDirection.Input;
                OperationType_nvc.IsNullable = false;
                OperationType_nvc.Value = businessObject.OperationType_nvc;
                this.Command.Parameters.Add(OperationType_nvc);

                SqlParameter AcceptTurn_bit = new SqlParameter();
                AcceptTurn_bit.ParameterName = "@AcceptTurn_bit";
                AcceptTurn_bit.SqlDbType = SqlDbType.Bit;
                AcceptTurn_bit.Direction = ParameterDirection.Input;
                AcceptTurn_bit.IsNullable = false;
                AcceptTurn_bit.Value = businessObject.AcceptTurn_bit;
                this.Command.Parameters.Add(AcceptTurn_bit);


                SqlParameter userName_nvc = new SqlParameter();
                userName_nvc.ParameterName = "@userName_nvc";
                userName_nvc.SqlDbType = SqlDbType.NVarChar;
                userName_nvc.Direction = ParameterDirection.Input;
                userName_nvc.IsNullable = false;
                userName_nvc.Value = businessObject.userName_nvc;
                this.Command.Parameters.Add(userName_nvc);

                SqlParameter macAddress_nvc = new SqlParameter();
                macAddress_nvc.ParameterName = "@macAddress_nvc";
                macAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                macAddress_nvc.Direction = ParameterDirection.Input;
                macAddress_nvc.IsNullable = false;
                macAddress_nvc.Value = businessObject.macAddress_nvc;
                this.Command.Parameters.Add(macAddress_nvc);

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = false;
                DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = false;
                CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvc);
                
	 

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.CardCheckingLogID_int = (Int64)(this.Command.Parameters["@CardCheckingLogID_int"].Value);

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

        public void Update(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject, HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = false;
                Date_vc.Value = businessObject.Date_vc;
                this.Command.Parameters.Add(Date_vc);

                SqlParameter Time_vc = new SqlParameter();
                Time_vc.ParameterName = "@Time_vc";
                Time_vc.SqlDbType = SqlDbType.VarChar;
                Time_vc.Direction = ParameterDirection.Input;
                Time_vc.IsNullable = false;
                Time_vc.Value = businessObject.Time_vc;
                this.Command.Parameters.Add(Time_vc);

                SqlParameter OperationType_nvc = new SqlParameter();
                OperationType_nvc.ParameterName = "@OperationType_nvc";
                OperationType_nvc.SqlDbType = SqlDbType.NVarChar;
                OperationType_nvc.Direction = ParameterDirection.Input;
                OperationType_nvc.IsNullable = false;
                OperationType_nvc.Value = businessObject.OperationType_nvc;
                this.Command.Parameters.Add(OperationType_nvc);

                SqlParameter AcceptTurn_bit = new SqlParameter();
                AcceptTurn_bit.ParameterName = "@AcceptTurn_bit";
                AcceptTurn_bit.SqlDbType = SqlDbType.Bit;
                AcceptTurn_bit.Direction = ParameterDirection.Input;
                AcceptTurn_bit.IsNullable = false;
                AcceptTurn_bit.Value = businessObject.AcceptTurn_bit;
                this.Command.Parameters.Add(AcceptTurn_bit);

                SqlParameter userName_nvc = new SqlParameter();
                userName_nvc.ParameterName = "@userName_nvc";
                userName_nvc.SqlDbType = SqlDbType.NVarChar;
                userName_nvc.Direction = ParameterDirection.Input;
                userName_nvc.IsNullable = false;
                userName_nvc.Value = businessObject.userName_nvc;
                this.Command.Parameters.Add(userName_nvc);

                SqlParameter macAddress_nvc = new SqlParameter();
                macAddress_nvc.ParameterName = "@macAddress_nvc";
                macAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                macAddress_nvc.Direction = ParameterDirection.Input;
                macAddress_nvc.IsNullable = false;
                macAddress_nvc.Value = businessObject.macAddress_nvc;
                this.Command.Parameters.Add(macAddress_nvc);

                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = false;
                DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = false;
                CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvc);

                SqlParameter pk_CardCheckingLogID_int = new SqlParameter();
                pk_CardCheckingLogID_int.ParameterName = "@pk_CardCheckingLogID_int";
                pk_CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                pk_CardCheckingLogID_int.Direction = ParameterDirection.Input;
                pk_CardCheckingLogID_int.IsNullable = false;
                pk_CardCheckingLogID_int.Value = businessObjectKey.CardCheckingLogID_int;
                this.Command.Parameters.Add(pk_CardCheckingLogID_int);



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

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> Result = new List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T>();
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectAll]";
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

        public HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T SelectByPrimaryKey(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardCheckingLogID_int = new SqlParameter();
                CardCheckingLogID_int.ParameterName = "@CardCheckingLogID_int";
                CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                CardCheckingLogID_int.Direction = ParameterDirection.Input;
                CardCheckingLogID_int.IsNullable = false;
                CardCheckingLogID_int.Value = businessObjectKey.CardCheckingLogID_int;
                this.Command.Parameters.Add(CardCheckingLogID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject = new HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
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

        public void SelectByPrimaryKey(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardCheckingLogID_int = new SqlParameter();
                CardCheckingLogID_int.ParameterName = "@CardCheckingLogID_int";
                CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                CardCheckingLogID_int.Direction = ParameterDirection.Input;
                CardCheckingLogID_int.IsNullable = false;
                CardCheckingLogID_int.Value = businessObjectKey.CardCheckingLogID_int;
                this.Command.Parameters.Add(CardCheckingLogID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardCheckingLogID_int = new SqlParameter();
                CardCheckingLogID_int.ParameterName = "@CardCheckingLogID_int";
                CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                CardCheckingLogID_int.Direction = ParameterDirection.Input;
                CardCheckingLogID_int.IsNullable = false;
                CardCheckingLogID_int.Value = businessObjectKey.CardCheckingLogID_int;
                this.Command.Parameters.Add(CardCheckingLogID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardCheckingLogID_int = new SqlParameter();
                CardCheckingLogID_int.ParameterName = "@CardCheckingLogID_int";
                CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                CardCheckingLogID_int.Direction = ParameterDirection.Input;
                CardCheckingLogID_int.IsNullable = false;
                CardCheckingLogID_int.Value = businessObjectKey.CardCheckingLogID_int;
                this.Command.Parameters.Add(CardCheckingLogID_int);



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

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CardCheckingLog_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> Result = new List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T>();
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CardCheckingLog_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CardCheckingLog_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CardCheckingLog_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
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
                List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> Result = new List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T>();
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CardCheckingLog_T_SelectCondition]";
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

        public void Delete(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CardCheckingLog_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CardCheckingLogID_int = new SqlParameter();
                CardCheckingLogID_int.ParameterName = "@CardCheckingLogID_int";
                CardCheckingLogID_int.SqlDbType = SqlDbType.BigInt;
                CardCheckingLogID_int.Direction = ParameterDirection.Input;
                CardCheckingLogID_int.IsNullable = false;
                CardCheckingLogID_int.Value = businessObjectKey.CardCheckingLogID_int;
                this.Command.Parameters.Add(CardCheckingLogID_int);


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
            this.Command.CommandText = "[sp_CardCheckingLog_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject, IDataReader dataReader)
        {
            businessObject.CardCheckingLogID_int = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.CardCheckingLogID_int.ToString()));
            businessObject.Date_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.Date_vc.ToString()));
            businessObject.Time_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.Time_vc.ToString()));
            businessObject.OperationType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.OperationType_nvc.ToString()));
            businessObject.AcceptTurn_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.AcceptTurn_bit.ToString()));
            businessObject.userName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.userName_nvc.ToString()));
            businessObject.macAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.macAddress_nvc.ToString()));
            businessObject.DriverCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.DriverCardNumber_nvc.ToString()));
            businessObject.CarCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField.CarCardNumber_nvc.ToString()));
        }

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> list = new List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T>();
            while (dataReader.Read())
            {
                HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject = new HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}