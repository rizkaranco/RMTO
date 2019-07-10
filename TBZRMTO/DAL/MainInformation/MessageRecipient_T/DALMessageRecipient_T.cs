using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.MessageRecipientDAL
{
    class DALMessageRecipient_T : DataLayerBase
    {

        public DALMessageRecipient_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageRecipientID_int = new SqlParameter();
                MessageRecipientID_int.ParameterName = "@MessageRecipientID_int";
                MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                MessageRecipientID_int.Direction = ParameterDirection.Output;
                MessageRecipientID_int.IsNullable = false;
                MessageRecipientID_int.Value = businessObject.MessageRecipientID_int;
                this.Command.Parameters.Add(MessageRecipientID_int);

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObject.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = false;
                UserGroupID_int.Value = businessObject.UserGroupID_int;
                this.Command.Parameters.Add(UserGroupID_int);

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
                UserName_nvc.IsNullable = true;
                UserName_nvc.Value = businessObject.UserName_nvc;

                this.Command.Parameters.Add(UserName_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.MessageRecipientID_int = (Int32?)(this.Command.Parameters["@MessageRecipientID_int"].Value);

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

        public void Update(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T businessObject, HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObject.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = false;
                UserGroupID_int.Value = businessObject.UserGroupID_int;
                this.Command.Parameters.Add(UserGroupID_int);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = false;
                StartDate_nvc.Value = businessObject.StartDate_nvc;
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = false;
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


                SqlParameter pk_MessageRecipientID_int = new SqlParameter();
                pk_MessageRecipientID_int.ParameterName = "@pk_MessageRecipientID_int";
                pk_MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                pk_MessageRecipientID_int.Direction = ParameterDirection.Input;
                pk_MessageRecipientID_int.IsNullable = false;
                pk_MessageRecipientID_int.Value = businessObjectKey.MessageRecipientID_int;
                this.Command.Parameters.Add(pk_MessageRecipientID_int);



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

        public List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> Result = new List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T>();
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectAll]";
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectAll]";
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectAll]";
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

        public HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T SelectByPrimaryKey(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageRecipientID_int = new SqlParameter();
                MessageRecipientID_int.ParameterName = "@MessageRecipientID_int";
                MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                MessageRecipientID_int.Direction = ParameterDirection.Input;
                MessageRecipientID_int.IsNullable = false;
                MessageRecipientID_int.Value = businessObjectKey.MessageRecipientID_int;
                this.Command.Parameters.Add(MessageRecipientID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T businessObject = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T();
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

        public void SelectByPrimaryKey(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageRecipientID_int = new SqlParameter();
                MessageRecipientID_int.ParameterName = "@MessageRecipientID_int";
                MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                MessageRecipientID_int.Direction = ParameterDirection.Input;
                MessageRecipientID_int.IsNullable = false;
                MessageRecipientID_int.Value = businessObjectKey.MessageRecipientID_int;
                this.Command.Parameters.Add(MessageRecipientID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageRecipientID_int = new SqlParameter();
                MessageRecipientID_int.ParameterName = "@MessageRecipientID_int";
                MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                MessageRecipientID_int.Direction = ParameterDirection.Input;
                MessageRecipientID_int.IsNullable = false;
                MessageRecipientID_int.Value = businessObjectKey.MessageRecipientID_int;
                this.Command.Parameters.Add(MessageRecipientID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageRecipientID_int = new SqlParameter();
                MessageRecipientID_int.ParameterName = "@MessageRecipientID_int";
                MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                MessageRecipientID_int.Direction = ParameterDirection.Input;
                MessageRecipientID_int.IsNullable = false;
                MessageRecipientID_int.Value = businessObjectKey.MessageRecipientID_int;
                this.Command.Parameters.Add(MessageRecipientID_int);



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





        public List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MessageRecipient_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> Result = new List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T>();
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MessageRecipient_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MessageRecipient_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MessageRecipient_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
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
                List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> Result = new List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T>();
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_MessageRecipient_T_SelectCondition]";
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

        public void Delete(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MessageRecipient_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageRecipientID_int = new SqlParameter();
                MessageRecipientID_int.ParameterName = "@MessageRecipientID_int";
                MessageRecipientID_int.SqlDbType = SqlDbType.Int;
                MessageRecipientID_int.Direction = ParameterDirection.Input;
                MessageRecipientID_int.IsNullable = false;
                MessageRecipientID_int.Value = businessObjectKey.MessageRecipientID_int;
                this.Command.Parameters.Add(MessageRecipientID_int);


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
            this.Command.CommandText = "[sp_MessageRecipient_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T businessObject, IDataReader dataReader)
        {
            businessObject.MessageRecipientID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageRecipientID_int.ToString()));
            businessObject.MessageID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.MessageID_bint.ToString()));
            businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.UserGroupID_int.ToString()));
            businessObject.StartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.StartDate_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.EndDate_nvc.ToString())) == false)
            {
                businessObject.EndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.EndDate_nvc.ToString()));
            }
            else
            {
                businessObject.EndDate_nvc = String.Empty;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.Time_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.UserName_nvc.ToString())) == false)
            {
                businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T.MessageRecipient_TField.UserName_nvc.ToString()));
            }
            else
            {
                businessObject.UserName_nvc = String.Empty;
            }

        }

        public List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T> list = new List<HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T>();
            while (dataReader.Read())
            {
                HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T businessObject = new HPS.BLL.MessageRecipientBLL.BLLMessageRecipient_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}