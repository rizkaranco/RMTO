using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.TurnManagementDAL
{
    class DALTurnManagement_T : DataLayerBase
    {

        public DALTurnManagement_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnManagementID_int = new SqlParameter();
                TurnManagementID_int.ParameterName = "@TurnManagementID_int";
                TurnManagementID_int.SqlDbType = SqlDbType.Int;
                TurnManagementID_int.Direction = ParameterDirection.Output;
                TurnManagementID_int.IsNullable = false;
                TurnManagementID_int.Value = businessObject.TurnManagementID_int;
                this.Command.Parameters.Add(TurnManagementID_int);

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter TurnCancelCommantID_int = new SqlParameter();
                TurnCancelCommantID_int.ParameterName = "@TurnCancelCommantID_int";
                TurnCancelCommantID_int.SqlDbType = SqlDbType.Int;
                TurnCancelCommantID_int.Direction = ParameterDirection.Input;
                TurnCancelCommantID_int.IsNullable = true;
                if (businessObject.TurnCancelCommantID_int.HasValue == false)
                {
                    TurnCancelCommantID_int.Value = DBNull.Value;
                }
                else
                {
                    TurnCancelCommantID_int.Value = businessObject.TurnCancelCommantID_int;
                }
                this.Command.Parameters.Add(TurnCancelCommantID_int);

                SqlParameter TurnCancelCommment_nvc = new SqlParameter();
                TurnCancelCommment_nvc.ParameterName = "@TurnCancelCommment_nvc";
                TurnCancelCommment_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnCancelCommment_nvc.Direction = ParameterDirection.Input;
                TurnCancelCommment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnCancelCommment_nvc))
                {
                    TurnCancelCommment_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnCancelCommment_nvc.Value = businessObject.TurnCancelCommment_nvc;
                }
                this.Command.Parameters.Add(TurnCancelCommment_nvc);

                SqlParameter Return_bit = new SqlParameter();
                Return_bit.ParameterName = "@Return_bit";
                Return_bit.SqlDbType = SqlDbType.Bit;
                Return_bit.Direction = ParameterDirection.Input;
                Return_bit.IsNullable = true;
                if (businessObject.Return_bit.HasValue == false)
                {
                    Return_bit.Value = DBNull.Value;
                }
                else
                {
                    Return_bit.Value = businessObject.Return_bit;
                }
                this.Command.Parameters.Add(Return_bit);

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



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.TurnManagementID_int = (Int32?)(this.Command.Parameters["@TurnManagementID_int"].Value);

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

        public void Update(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject, HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter TurnCancelCommantID_int = new SqlParameter();
                TurnCancelCommantID_int.ParameterName = "@TurnCancelCommantID_int";
                TurnCancelCommantID_int.SqlDbType = SqlDbType.Int;
                TurnCancelCommantID_int.Direction = ParameterDirection.Input;
                TurnCancelCommantID_int.IsNullable = false;
                if (businessObject.TurnCancelCommantID_int.HasValue == false)
                {
                    TurnCancelCommantID_int.Value = DBNull.Value;
                }
                else
                {
                    TurnCancelCommantID_int.Value = businessObject.TurnCancelCommantID_int;
                }
                this.Command.Parameters.Add(TurnCancelCommantID_int);

                SqlParameter TurnCancelCommment_nvc = new SqlParameter();
                TurnCancelCommment_nvc.ParameterName = "@TurnCancelCommment_nvc";
                TurnCancelCommment_nvc.SqlDbType = SqlDbType.NVarChar;
                TurnCancelCommment_nvc.Direction = ParameterDirection.Input;
                TurnCancelCommment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.TurnCancelCommment_nvc))
                {
                    TurnCancelCommment_nvc.Value = DBNull.Value;
                }
                else
                {
                    TurnCancelCommment_nvc.Value = businessObject.TurnCancelCommment_nvc;
                }
                this.Command.Parameters.Add(TurnCancelCommment_nvc);

                SqlParameter Return_bit = new SqlParameter();
                Return_bit.ParameterName = "@Return_bit";
                Return_bit.SqlDbType = SqlDbType.Bit;
                Return_bit.Direction = ParameterDirection.Input;
                Return_bit.IsNullable = true;
                if (businessObject.Return_bit.HasValue == false)
                {
                    Return_bit.Value = DBNull.Value;
                }
                else
                {
                    Return_bit.Value = businessObject.Return_bit;
                }
                this.Command.Parameters.Add(Return_bit);

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


                SqlParameter pk_TurnManagementID_int = new SqlParameter();
                pk_TurnManagementID_int.ParameterName = "@pk_TurnManagementID_int";
                pk_TurnManagementID_int.SqlDbType = SqlDbType.Int;
                pk_TurnManagementID_int.Direction = ParameterDirection.Input;
                pk_TurnManagementID_int.IsNullable = false;
                pk_TurnManagementID_int.Value = businessObjectKey.TurnManagementID_int;
                this.Command.Parameters.Add(pk_TurnManagementID_int);



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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> Result = new List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T>();
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAll]";
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAll]";
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAll]";
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

        public HPS.BLL.TurnManagementBLL.BLLTurnManagement_T SelectByPrimaryKey(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnManagementID_int = new SqlParameter();
                TurnManagementID_int.ParameterName = "@TurnManagementID_int";
                TurnManagementID_int.SqlDbType = SqlDbType.Int;
                TurnManagementID_int.Direction = ParameterDirection.Input;
                TurnManagementID_int.IsNullable = false;
                TurnManagementID_int.Value = businessObjectKey.TurnManagementID_int;
                this.Command.Parameters.Add(TurnManagementID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
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

        public void SelectByPrimaryKey(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnManagementID_int = new SqlParameter();
                TurnManagementID_int.ParameterName = "@TurnManagementID_int";
                TurnManagementID_int.SqlDbType = SqlDbType.Int;
                TurnManagementID_int.Direction = ParameterDirection.Input;
                TurnManagementID_int.IsNullable = false;
                TurnManagementID_int.Value = businessObjectKey.TurnManagementID_int;
                this.Command.Parameters.Add(TurnManagementID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnManagementID_int = new SqlParameter();
                TurnManagementID_int.ParameterName = "@TurnManagementID_int";
                TurnManagementID_int.SqlDbType = SqlDbType.Int;
                TurnManagementID_int.Direction = ParameterDirection.Input;
                TurnManagementID_int.IsNullable = false;
                TurnManagementID_int.Value = businessObjectKey.TurnManagementID_int;
                this.Command.Parameters.Add(TurnManagementID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnManagementID_int = new SqlParameter();
                TurnManagementID_int.ParameterName = "@TurnManagementID_int";
                TurnManagementID_int.SqlDbType = SqlDbType.Int;
                TurnManagementID_int.Direction = ParameterDirection.Input;
                TurnManagementID_int.IsNullable = false;
                TurnManagementID_int.Value = businessObjectKey.TurnManagementID_int;
                this.Command.Parameters.Add(TurnManagementID_int);



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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[TurnManagement_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> Result = new List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T>();
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[TurnManagement_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[TurnManagement_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[TurnManagement_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
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
                List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> Result = new List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T>();
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_TurnManagement_T_SelectCondition]";
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

        public void Delete(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TurnManagementID_int = new SqlParameter();
                TurnManagementID_int.ParameterName = "@TurnManagementID_int";
                TurnManagementID_int.SqlDbType = SqlDbType.Int;
                TurnManagementID_int.Direction = ParameterDirection.Input;
                TurnManagementID_int.IsNullable = false;
                TurnManagementID_int.Value = businessObjectKey.TurnManagementID_int;
                this.Command.Parameters.Add(TurnManagementID_int);


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
            this.Command.CommandText = "[sp_TurnManagement_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject, IDataReader dataReader)
        {
            businessObject.TurnManagementID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnManagementID_int.ToString()));
            businessObject.TrafficID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TrafficID_bint.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnCancelCommantID_int.ToString())) == false)
            {
                businessObject.TurnCancelCommantID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnCancelCommantID_int.ToString()));
            }
            else
            {
                businessObject.TurnCancelCommantID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnCancelCommment_nvc.ToString())) == false)
            {
                businessObject.TurnCancelCommment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnCancelCommment_nvc.ToString()));
            }
            else
            {
                businessObject.TurnCancelCommment_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Return_bit.ToString())) == false)
            {
                businessObject.Return_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Return_bit.ToString()));
            }
            else
            {
                businessObject.Return_bit = null;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.UserName_nvc.ToString()));
        }

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> list = new List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T>();
            while (dataReader.Read())
            {
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        //Lader Added

        public void SelectAllWithTrafficForCancelTurn(Int64? TrafficNumber_bint,Int64? AcceptedturnNumber_bint,string NumberPlate_nvc,string SerialPlate_nvc,string FromDate_nvc,string ToDate_nvc ,ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAllWihtTrafficForCancelTurn]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficNumber_bintParam = new SqlParameter();
                TrafficNumber_bintParam.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bintParam.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bintParam.Direction = ParameterDirection.Input;
                TrafficNumber_bintParam.IsNullable = true;
                if (TrafficNumber_bint.HasValue)
                {
                    TrafficNumber_bintParam.Value = TrafficNumber_bint;
                }
                else
                    TrafficNumber_bintParam.Value = DBNull.Value;
                this.Command.Parameters.Add(TrafficNumber_bintParam);

                SqlParameter AcceptedturnNumber_bintParam = new SqlParameter();
                AcceptedturnNumber_bintParam.ParameterName = "@AcceptedTurnNumber_bint";
                AcceptedturnNumber_bintParam.SqlDbType = SqlDbType.BigInt;
                AcceptedturnNumber_bintParam.Direction = ParameterDirection.Input;
                AcceptedturnNumber_bintParam.IsNullable = true;
                if (AcceptedturnNumber_bint.HasValue)
                {
                    AcceptedturnNumber_bintParam.Value = AcceptedturnNumber_bint;
                }
                else
                    AcceptedturnNumber_bintParam.Value = DBNull.Value;
                this.Command.Parameters.Add(AcceptedturnNumber_bintParam);

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(NumberPlate_nvc))
                {
                    NumberPlate_nvcParam.Value = NumberPlate_nvc;
                }
                else
                    NumberPlate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(SerialPlate_nvc))
                {
                    SerialPlate_nvcParam.Value = SerialPlate_nvc;
                }
                else
                    SerialPlate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter FromDate_nvcParam = new SqlParameter();
                FromDate_nvcParam.ParameterName = "@FromDate_nvc";
                FromDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvcParam.Direction = ParameterDirection.Input;
                FromDate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(FromDate_nvc))
                {
                    FromDate_nvcParam.Value = FromDate_nvc;
                }
                else
                    FromDate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(FromDate_nvcParam);

                SqlParameter ToDate_nvcParam = new SqlParameter();
                ToDate_nvcParam.ParameterName = "@ToDate_nvc";
                ToDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvcParam.Direction = ParameterDirection.Input;
                ToDate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(ToDate_nvc))
                {
                    ToDate_nvcParam.Value = ToDate_nvc;
                }
                else
                    ToDate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(ToDate_nvcParam);


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

        public void SelectAllWithTrafficForReturnTurn(string Date,string Time,Int64? TrafficNumber_bint,Int64? AcceptedturnNumber_bint,string NumberPlate_nvc,string SerialPlate_nvc,string FromDate_nvc,string ToDate_nvc ,ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAllWihtTrafficForReturnTurn]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

              

                SqlParameter Date_nvcParam = new SqlParameter();
                Date_nvcParam.ParameterName = "@Date_nvc";
                Date_nvcParam.SqlDbType = SqlDbType.NVarChar;
                Date_nvcParam.Direction = ParameterDirection.Input;
                Date_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(Date))
                {
                    Date_nvcParam.Value = Date;
                }
                else
                    Date_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(Date_nvcParam);

                SqlParameter Time_nvcParam = new SqlParameter();
                Time_nvcParam.ParameterName = "@Time_nvc";
                Time_nvcParam.SqlDbType = SqlDbType.NVarChar;
                Time_nvcParam.Direction = ParameterDirection.Input;
                Time_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(Time))
                {
                    Time_nvcParam.Value = Time;
                }
                else
                    Time_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(Time_nvcParam);

                SqlParameter TrafficNumber_bintParam = new SqlParameter();
                TrafficNumber_bintParam.ParameterName = "@TrafficNumber_bint";
                TrafficNumber_bintParam.SqlDbType = SqlDbType.BigInt;
                TrafficNumber_bintParam.Direction = ParameterDirection.Input;
                TrafficNumber_bintParam.IsNullable = true;
                if (TrafficNumber_bint.HasValue)
                {
                    TrafficNumber_bintParam.Value = TrafficNumber_bint;
                }
                else
                    TrafficNumber_bintParam.Value = DBNull.Value;
                this.Command.Parameters.Add(TrafficNumber_bintParam);

                SqlParameter AcceptedturnNumber_bintParam = new SqlParameter();
                AcceptedturnNumber_bintParam.ParameterName = "@AcceptedTurnNumber_bint";
                AcceptedturnNumber_bintParam.SqlDbType = SqlDbType.BigInt;
                AcceptedturnNumber_bintParam.Direction = ParameterDirection.Input;
                AcceptedturnNumber_bintParam.IsNullable = true;
                if (AcceptedturnNumber_bint.HasValue)
                {
                    AcceptedturnNumber_bintParam.Value = AcceptedturnNumber_bint;
                }
                else
                    AcceptedturnNumber_bintParam.Value = DBNull.Value;
                this.Command.Parameters.Add(AcceptedturnNumber_bintParam);

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(NumberPlate_nvc))
                {
                    NumberPlate_nvcParam.Value = NumberPlate_nvc;
                }
                else
                    NumberPlate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(SerialPlate_nvc))
                {
                    SerialPlate_nvcParam.Value = SerialPlate_nvc;
                }
                else
                    SerialPlate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter FromDate_nvcParam = new SqlParameter();
                FromDate_nvcParam.ParameterName = "@FromDate_nvc";
                FromDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvcParam.Direction = ParameterDirection.Input;
                FromDate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(FromDate_nvc))
                {
                    FromDate_nvcParam.Value = FromDate_nvc;
                }
                else
                    FromDate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(FromDate_nvcParam);

                SqlParameter ToDate_nvcParam = new SqlParameter();
                ToDate_nvcParam.ParameterName = "@ToDate_nvc";
                ToDate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvcParam.Direction = ParameterDirection.Input;
                ToDate_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(ToDate_nvc))
                {
                    ToDate_nvcParam.Value = ToDate_nvc;
                }
                else
                    ToDate_nvcParam.Value = DBNull.Value;
                this.Command.Parameters.Add(ToDate_nvcParam);

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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> SelectByConditionWithTraffic(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAllWihtConditionTraffic]";
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
                List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> Result = new List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T>();
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

        public void SelectByConditionWithTraffic(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_TurnManagement_T_SelectAllWihtConditionTraffic]";
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
       
        public void SelectCanceledTurn(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CanceledLadBillCredit_T_SelectAllwithTraffic]";
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

        public void SelectSMSInfo(Int32 LaderTypeID_bint, String Date_nvc, ref Int64 LastAcceptedTurnNumber_bint, ref Int32 LaderTypeCount_int, ref Int32 RemaindLaderTypeCount_int)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SelectSMSInfo]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID = new SqlParameter();
                LaderTypeID.ParameterName = "@LaderTypeID_int";
                LaderTypeID.SqlDbType = SqlDbType.Int ;
                LaderTypeID.Direction = ParameterDirection.Input;
                LaderTypeID.IsNullable = false;
                LaderTypeID.Value = LaderTypeID_bint;
                this.Command.Parameters.Add(LaderTypeID);

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_nvc";
                Date_vc.SqlDbType = SqlDbType.NVarChar ;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = false;
                Date_vc.Value = Date_nvc ;
                this.Command.Parameters.Add(Date_vc);

                SqlParameter LastAcceptedTurnNumber = new SqlParameter();
                LastAcceptedTurnNumber.ParameterName = "@LastAcceptedTurnNumber_bint";
                LastAcceptedTurnNumber.SqlDbType = SqlDbType.BigInt ;
                LastAcceptedTurnNumber.Direction = ParameterDirection.Output ;
                LastAcceptedTurnNumber.IsNullable = true ;
                LastAcceptedTurnNumber.Value = DBNull.Value;
                this.Command.Parameters.Add(LastAcceptedTurnNumber);

                SqlParameter LaderTypeCount = new SqlParameter();
                LaderTypeCount.ParameterName = "@LaderTypeCount_int";
                LaderTypeCount.SqlDbType = SqlDbType.Int ;
                LaderTypeCount.Direction = ParameterDirection.Output;
                LaderTypeCount.IsNullable = true;
                LaderTypeCount.Value = DBNull.Value;
                this.Command.Parameters.Add(LaderTypeCount);

                SqlParameter RemaindLaderTypeCount = new SqlParameter();
                RemaindLaderTypeCount.ParameterName = "@RemaindLaderTypeCount_int";
                RemaindLaderTypeCount.SqlDbType = SqlDbType.Int;
                RemaindLaderTypeCount.Direction = ParameterDirection.Output;
                RemaindLaderTypeCount.IsNullable = true;
                RemaindLaderTypeCount.Value = DBNull.Value;
                this.Command.Parameters.Add(RemaindLaderTypeCount);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (this.Command.Parameters["@LastAcceptedTurnNumber_bint"].Value != DBNull.Value )
                {
                    LastAcceptedTurnNumber_bint = (Int64)(this.Command.Parameters["@LastAcceptedTurnNumber_bint"].Value);
                }
                LaderTypeCount_int = (Int32)(this.Command.Parameters["@LaderTypeCount_int"].Value);
                RemaindLaderTypeCount_int = (Int32)(this.Command.Parameters["@RemaindLaderTypeCount_int"].Value);

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

        public void SelectCanceledTurn(String Date_nvc, ref DataTable DataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SelectCanceledTurn]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Date_nvcParam = new SqlParameter();
                Date_nvcParam.ParameterName = "@Date_nvc";
                Date_nvcParam.Direction = ParameterDirection.Input;
                Date_nvcParam.SqlDbType = SqlDbType.NVarChar;
                Date_nvcParam.IsNullable = false;
                Date_nvcParam.Value = Date_nvc;
                this.Command.Parameters.Add(Date_nvcParam);

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