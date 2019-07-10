using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.OnlineUsersWhenConnectionOrNotDAL
{
    public partial class DALOnlineUsersWhenConnectionOrNot_T : DataLayerBase
    {

        public DALOnlineUsersWhenConnectionOrNot_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@OnlineUsersWhenConnectionOrNotID_bint";
                OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Output;
                OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                OnlineUsersWhenConnectionOrNotID_bint.Value = businessObject.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(OnlineUsersWhenConnectionOrNotID_bint);

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObject.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObject.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);

                SqlParameter OffOrOn_nvc = new SqlParameter();
                OffOrOn_nvc.ParameterName = "@OffOrOn_nvc";
                OffOrOn_nvc.SqlDbType = SqlDbType.NVarChar;
                OffOrOn_nvc.Direction = ParameterDirection.Input;
                OffOrOn_nvc.IsNullable = false;
                OffOrOn_nvc.Value = businessObject.OffOrOn_nvc;
                this.Command.Parameters.Add(OffOrOn_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.OnlineUsersWhenConnectionOrNotID_bint = (Int64)(this.Command.Parameters["@OnlineUsersWhenConnectionOrNotID_bint"].Value);

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

        public void Update(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T businessObject, HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObject.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);

                SqlParameter OnlineUserID_int = new SqlParameter();
                OnlineUserID_int.ParameterName = "@OnlineUserID_int";
                OnlineUserID_int.SqlDbType = SqlDbType.Int;
                OnlineUserID_int.Direction = ParameterDirection.Input;
                OnlineUserID_int.IsNullable = false;
                OnlineUserID_int.Value = businessObject.OnlineUserID_int;
                this.Command.Parameters.Add(OnlineUserID_int);


                SqlParameter pk_OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                pk_OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@pk_OnlineUsersWhenConnectionOrNotID_bint";
                pk_OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                pk_OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Input;
                pk_OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                pk_OnlineUsersWhenConnectionOrNotID_bint.Value = businessObjectKey.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(pk_OnlineUsersWhenConnectionOrNotID_bint);

                SqlParameter OffOrOn_nvc = new SqlParameter();
                OffOrOn_nvc.ParameterName = "@OffOrOn_nvc";
                OffOrOn_nvc.SqlDbType = SqlDbType.NVarChar;
                OffOrOn_nvc.Direction = ParameterDirection.Input;
                OffOrOn_nvc.IsNullable = false;
                OffOrOn_nvc.Value = businessObject.OffOrOn_nvc;
                this.Command.Parameters.Add(OffOrOn_nvc);

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

        public List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> Result = new List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T>();
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectAll]";
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

        public HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T SelectByPrimaryKey(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@OnlineUsersWhenConnectionOrNotID_bint";
                OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Input;
                OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                OnlineUsersWhenConnectionOrNotID_bint.Value = businessObjectKey.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(OnlineUsersWhenConnectionOrNotID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T businessObject = new HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T();
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

        public void SelectByPrimaryKey(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@OnlineUsersWhenConnectionOrNotID_bint";
                OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Input;
                OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                OnlineUsersWhenConnectionOrNotID_bint.Value = businessObjectKey.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(OnlineUsersWhenConnectionOrNotID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@OnlineUsersWhenConnectionOrNotID_bint";
                OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Input;
                OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                OnlineUsersWhenConnectionOrNotID_bint.Value = businessObjectKey.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(OnlineUsersWhenConnectionOrNotID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@OnlineUsersWhenConnectionOrNotID_bint";
                OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Input;
                OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                OnlineUsersWhenConnectionOrNotID_bint.Value = businessObjectKey.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(OnlineUsersWhenConnectionOrNotID_bint);



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





        public List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUsersWhenConnectionOrNot_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> Result = new List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T>();
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUsersWhenConnectionOrNot_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUsersWhenConnectionOrNot_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OnlineUsersWhenConnectionOrNot_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
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
                List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> Result = new List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T>();
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_SelectCondition]";
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

        public void Delete(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OnlineUsersWhenConnectionOrNotID_bint = new SqlParameter();
                OnlineUsersWhenConnectionOrNotID_bint.ParameterName = "@OnlineUsersWhenConnectionOrNotID_bint";
                OnlineUsersWhenConnectionOrNotID_bint.SqlDbType = SqlDbType.BigInt;
                OnlineUsersWhenConnectionOrNotID_bint.Direction = ParameterDirection.Input;
                OnlineUsersWhenConnectionOrNotID_bint.IsNullable = false;
                OnlineUsersWhenConnectionOrNotID_bint.Value = businessObjectKey.OnlineUsersWhenConnectionOrNotID_bint;
                this.Command.Parameters.Add(OnlineUsersWhenConnectionOrNotID_bint);


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
            this.Command.CommandText = "[sp_OnlineUsersWhenConnectionOrNot_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T businessObject, IDataReader dataReader)
        {
            businessObject.OnlineUsersWhenConnectionOrNotID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T.OnlineUsersWhenConnectionOrNot_TField.OnlineUsersWhenConnectionOrNotID_bint.ToString()));
            businessObject.OfflineSecondPartSoftwareID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T.OnlineUsersWhenConnectionOrNot_TField.OfflineSecondPartSoftwareID_int.ToString()));
            businessObject.OnlineUserID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T.OnlineUsersWhenConnectionOrNot_TField.OnlineUserID_int.ToString()));
            businessObject.OffOrOn_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T.OnlineUsersWhenConnectionOrNot_TField.OffOrOn_nvc.ToString()));

        }

        public List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T> list = new List<HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T>();
            while (dataReader.Read())
            {
                HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T businessObject = new HPS.BLL.OnlineUsersWhenConnectionOrNotBLL.BLLOnlineUsersWhenConnectionOrNot_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}