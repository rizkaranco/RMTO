using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.OnlineUserDAL
{
    public partial class DALOnlineUser_T : DataLayerBase
    {

        public DALOnlineUser_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Output;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObject.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter LoginDate_vc = new SqlParameter();
                LoginDate_vc.ParameterName = "@LoginDate_vc";
                LoginDate_vc.SqlDbType = SqlDbType.VarChar;
                LoginDate_vc.Direction = ParameterDirection.Input;
                LoginDate_vc.IsNullable = false;
                LoginDate_vc.Value = businessObject.LoginDate_vc;
                this.Command.Parameters.Add(LoginDate_vc);

                SqlParameter LoginTime_vc = new SqlParameter();
                LoginTime_vc.ParameterName = "@LoginTime_vc";
                LoginTime_vc.SqlDbType = SqlDbType.VarChar;
                LoginTime_vc.Direction = ParameterDirection.Input;
                LoginTime_vc.IsNullable = false;
                LoginTime_vc.Value = businessObject.LoginTime_vc;
                this.Command.Parameters.Add(LoginTime_vc);

                SqlParameter LogOutDate_vc = new SqlParameter();
                LogOutDate_vc.ParameterName = "@LogOutDate_vc";
                LogOutDate_vc.SqlDbType = SqlDbType.VarChar;
                LogOutDate_vc.Direction = ParameterDirection.Input;
                LogOutDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LogOutDate_vc))
                {
                    LogOutDate_vc.Value = DBNull.Value;
                }
                else
                {
                    LogOutDate_vc.Value = businessObject.LogOutDate_vc;
                }
                this.Command.Parameters.Add(LogOutDate_vc);

                SqlParameter LogOutTime_vc = new SqlParameter();
                LogOutTime_vc.ParameterName = "@LogOutTime_vc";
                LogOutTime_vc.SqlDbType = SqlDbType.VarChar;
                LogOutTime_vc.Direction = ParameterDirection.Input;
                LogOutTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LogOutTime_vc))
                {
                    LogOutTime_vc.Value = DBNull.Value;
                }
                else
                {
                    LogOutTime_vc.Value = businessObject.LogOutTime_vc;
                }
                this.Command.Parameters.Add(LogOutTime_vc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.OnlineUserID_int = (Int32)(this.Command.Parameters["@OnlineUserID_int"].Value);

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

        public void Update( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T businessObject,  HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter LoginDate_vc = new SqlParameter();
                LoginDate_vc.ParameterName = "@LoginDate_vc";
                LoginDate_vc.SqlDbType = SqlDbType.VarChar;
                LoginDate_vc.Direction = ParameterDirection.Input;
                LoginDate_vc.IsNullable = false;
                LoginDate_vc.Value = businessObject.LoginDate_vc;
                this.Command.Parameters.Add(LoginDate_vc);

                SqlParameter LoginTime_vc = new SqlParameter();
                LoginTime_vc.ParameterName = "@LoginTime_vc";
                LoginTime_vc.SqlDbType = SqlDbType.VarChar;
                LoginTime_vc.Direction = ParameterDirection.Input;
                LoginTime_vc.IsNullable = false;
                LoginTime_vc.Value = businessObject.LoginTime_vc;
                this.Command.Parameters.Add(LoginTime_vc);

                SqlParameter LogOutDate_vc = new SqlParameter();
                LogOutDate_vc.ParameterName = "@LogOutDate_vc";
                LogOutDate_vc.SqlDbType = SqlDbType.VarChar;
                LogOutDate_vc.Direction = ParameterDirection.Input;
                LogOutDate_vc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.LogOutDate_vc))
                {
                    LogOutDate_vc.Value = DBNull.Value;
                }
                else
                {
                    LogOutDate_vc.Value = businessObject.LogOutDate_vc;
                }
                this.Command.Parameters.Add(LogOutDate_vc);

                SqlParameter LogOutTime_vc = new SqlParameter();
                LogOutTime_vc.ParameterName = "@LogOutTime_vc";
                LogOutTime_vc.SqlDbType = SqlDbType.VarChar;
                LogOutTime_vc.Direction = ParameterDirection.Input;
                LogOutTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.LogOutTime_vc))
                {
                    LogOutTime_vc.Value = DBNull.Value;
                }
                else
                {
                    LogOutTime_vc.Value = businessObject.LogOutTime_vc;
                }
                this.Command.Parameters.Add(LogOutTime_vc);


                SqlParameter pk_OnlineUserID_int = new SqlParameter();
                pk_OnlineUserID_int.ParameterName = "@pk_OnlineUserID_int";
                pk_OnlineUserID_int.SqlDbType = SqlDbType.Int;
                pk_OnlineUserID_int.Direction = ParameterDirection.Input;
                pk_OnlineUserID_int.IsNullable = false;
                pk_OnlineUserID_int.Value = businessObjectKey.OnlineUserID_int;
                this.Command.Parameters.Add(pk_OnlineUserID_int);



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

        public List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> Result = new List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T>();
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectAll]";
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

        public  HPS.BLL.OnlineUserBLL.BLLOnlineUser_T SelectByPrimaryKey( HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObjectKey.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                 HPS.BLL.OnlineUserBLL.BLLOnlineUser_T businessObject = new  HPS.BLL.OnlineUserBLL.BLLOnlineUser_T();
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

        public void SelectByPrimaryKey( HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObjectKey.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);


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

        public void SelectByPrimaryKey( HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObjectKey.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);


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

        public void SelectByPrimaryKey( HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObjectKey.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);



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





        public List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUser_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> Result = new List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T>();
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUser_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUser_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUser_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
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
                List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> Result = new List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T>();
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OnlineUser_T_SelectCondition]";
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

        public void Delete( HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUser_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObjectKey.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);


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
            this.Command.CommandText = "[sp_OnlineUser_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.OnlineUserID_int = dataReader.GetInt32(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.OnlineUserID_int.ToString()));
                businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.UserName_nvc.ToString()));
                businessObject.MacAddress_nvc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.MacAddress_nvc.ToString()));
                businessObject.LoginDate_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.LoginDate_vc.ToString()));
                businessObject.LoginTime_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.LoginTime_vc.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.LogOutDate_vc.ToString())) == false)
                {
                    businessObject.LogOutDate_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.LogOutDate_vc.ToString()));
                }
                else
                {
                    businessObject.LogOutDate_vc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.LogOutTime_vc.ToString())) == false)
                {
                    businessObject.LogOutTime_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OnlineUserBLL.BLLOnlineUser_T.OnlineUser_TField.LogOutTime_vc.ToString()));
                }
                else
                {
                    businessObject.LogOutTime_vc = String.Empty;
                }

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T> list = new List< HPS.BLL.OnlineUserBLL.BLLOnlineUser_T>();
                while (dataReader.Read())
                {
                     HPS.BLL.OnlineUserBLL.BLLOnlineUser_T businessObject = new  HPS.BLL.OnlineUserBLL.BLLOnlineUser_T();
                    PopulateBusinessObjectFromReader(businessObject, dataReader);
                    list.Add(businessObject);
                }
                return list;
            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

    }
}