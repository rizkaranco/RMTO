using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.MessageDAL
{
    class DALMessage_T : DataLayerBase
    {

        public DALMessage_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.MessageBLL.BLLMessage_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Output;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObject.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);

                SqlParameter MessageTitle_nvc = new SqlParameter();
                MessageTitle_nvc.ParameterName = "@MessageTitle_nvc";
                MessageTitle_nvc.SqlDbType = SqlDbType.NVarChar;
                MessageTitle_nvc.Direction = ParameterDirection.Input;
                MessageTitle_nvc.IsNullable = false;
                MessageTitle_nvc.Value = businessObject.MessageTitle_nvc;
                this.Command.Parameters.Add(MessageTitle_nvc);

                SqlParameter Message_nvc = new SqlParameter();
                Message_nvc.ParameterName = "@Message_nvc";
                Message_nvc.SqlDbType = SqlDbType.NVarChar;
                Message_nvc.Direction = ParameterDirection.Input;
                Message_nvc.IsNullable = false;
                Message_nvc.Value = businessObject.Message_nvc;
                this.Command.Parameters.Add(Message_nvc);

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

                SqlParameter Visited_bit = new SqlParameter();
                Visited_bit.ParameterName = "@Visited_bit";
                Visited_bit.SqlDbType = SqlDbType.Bit;
                Visited_bit.Direction = ParameterDirection.Input;
                Visited_bit.IsNullable = false;
                Visited_bit.Value = businessObject.Visited_bit;
                this.Command.Parameters.Add(Visited_bit);

                SqlParameter RecipientUserName_nvc = new SqlParameter();
                RecipientUserName_nvc.ParameterName = "@RecipientUserName_nvc";
                RecipientUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                RecipientUserName_nvc.Direction = ParameterDirection.Input;
                RecipientUserName_nvc.IsNullable = true;
                if ( string.IsNullOrEmpty(businessObject.RecipientUserName_nvc))
                {
                    RecipientUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    RecipientUserName_nvc.Value = businessObject.RecipientUserName_nvc;
                }
                this.Command.Parameters.Add(RecipientUserName_nvc);

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

                businessObject.MessageID_bint = (Int64?)(this.Command.Parameters["@MessageID_bint"].Value);

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

        public void Update(HPS.BLL.MessageBLL.BLLMessage_T businessObject, HPS.BLL.MessageBLL.BLLMessage_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageTitle_nvc = new SqlParameter();
                MessageTitle_nvc.ParameterName = "@MessageTitle_nvc";
                MessageTitle_nvc.SqlDbType = SqlDbType.NVarChar;
                MessageTitle_nvc.Direction = ParameterDirection.Input;
                MessageTitle_nvc.IsNullable = false;
                MessageTitle_nvc.Value = businessObject.MessageTitle_nvc;
                this.Command.Parameters.Add(MessageTitle_nvc);

                SqlParameter Message_nvc = new SqlParameter();
                Message_nvc.ParameterName = "@Message_nvc";
                Message_nvc.SqlDbType = SqlDbType.NVarChar;
                Message_nvc.Direction = ParameterDirection.Input;
                Message_nvc.IsNullable = false;
                Message_nvc.Value = businessObject.Message_nvc;
                this.Command.Parameters.Add(Message_nvc);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = false;
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

                SqlParameter Visited_bit = new SqlParameter();
                Visited_bit.ParameterName = "@Visited_bit";
                Visited_bit.SqlDbType = SqlDbType.Bit;
                Visited_bit.Direction = ParameterDirection.Input;
                Visited_bit.IsNullable = true;
                Visited_bit.Value = businessObject.Visited_bit;
                this.Command.Parameters.Add(Visited_bit);

                SqlParameter RecipientUserName_nvc = new SqlParameter();
                RecipientUserName_nvc.ParameterName = "@RecipientUserName_nvc";
                RecipientUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                RecipientUserName_nvc.Direction = ParameterDirection.Input;
                RecipientUserName_nvc.IsNullable = false;
                if (string.IsNullOrEmpty(businessObject.RecipientUserName_nvc))
                {
                    RecipientUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    RecipientUserName_nvc.Value = businessObject.RecipientUserName_nvc;
                }
                this.Command.Parameters.Add(RecipientUserName_nvc);

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


                SqlParameter pk_MessageID_bint = new SqlParameter();
                pk_MessageID_bint.ParameterName = "@pk_MessageID_bint";
                pk_MessageID_bint.SqlDbType = SqlDbType.BigInt;
                pk_MessageID_bint.Direction = ParameterDirection.Input;
                pk_MessageID_bint.IsNullable = false;
                pk_MessageID_bint.Value = businessObjectKey.MessageID_bint;
                this.Command.Parameters.Add(pk_MessageID_bint);



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

        public List<HPS.BLL.MessageBLL.BLLMessage_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.MessageBLL.BLLMessage_T> Result = new List<HPS.BLL.MessageBLL.BLLMessage_T>();
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
            this.Command.CommandText = "[sp_Message_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Message_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Message_T_SelectAll]";
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

        public HPS.BLL.MessageBLL.BLLMessage_T SelectByPrimaryKey(HPS.BLL.MessageBLL.BLLMessage_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObjectKey.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.MessageBLL.BLLMessage_T businessObject = new HPS.BLL.MessageBLL.BLLMessage_T();
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

        public void SelectByPrimaryKey(HPS.BLL.MessageBLL.BLLMessage_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Message_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObjectKey.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.MessageBLL.BLLMessage_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Message_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObjectKey.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.MessageBLL.BLLMessage_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Message_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObjectKey.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);



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

        public List<HPS.BLL.MessageBLL.BLLMessage_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Message_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.MessageBLL.BLLMessage_T> Result = new List<HPS.BLL.MessageBLL.BLLMessage_T>();
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
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Message_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Message_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Message_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.MessageBLL.BLLMessage_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
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
                List<HPS.BLL.MessageBLL.BLLMessage_T> Result = new List<HPS.BLL.MessageBLL.BLLMessage_T>();
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
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Message_T_SelectCondition]";
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

        public void Delete(HPS.BLL.MessageBLL.BLLMessage_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Message_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MessageID_bint = new SqlParameter();
                MessageID_bint.ParameterName = "@MessageID_bint";
                MessageID_bint.SqlDbType = SqlDbType.BigInt;
                MessageID_bint.Direction = ParameterDirection.Input;
                MessageID_bint.IsNullable = false;
                MessageID_bint.Value = businessObjectKey.MessageID_bint;
                this.Command.Parameters.Add(MessageID_bint);


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
            this.Command.CommandText = "[sp_Message_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.MessageBLL.BLLMessage_T businessObject, IDataReader dataReader)
        {
            businessObject.MessageID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageID_bint.ToString()));
            businessObject.MessageTitle_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.MessageTitle_nvc.ToString()));
            businessObject.Message_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Message_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.StartDate_nvc.ToString())) == false)
            {
                businessObject.StartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.StartDate_nvc.ToString()));
            }
            else
            {
                businessObject.StartDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.EndDate_nvc.ToString())) == false)
            {
                businessObject.EndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.EndDate_nvc.ToString()));
            }
            else
            {
                businessObject.EndDate_nvc = String.Empty;
            }

            businessObject.Visited_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Visited_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.RecipientUserName_nvc.ToString())) == false)
            {
                businessObject.RecipientUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.RecipientUserName_nvc.ToString()));
            }
            else
            {
                businessObject.RecipientUserName_nvc = String.Empty;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.MessageBLL.BLLMessage_T.Message_TField.UserName_nvc.ToString()));
        }

        public List<HPS.BLL.MessageBLL.BLLMessage_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.MessageBLL.BLLMessage_T> list = new List<HPS.BLL.MessageBLL.BLLMessage_T>();
            while (dataReader.Read())
            {
                HPS.BLL.MessageBLL.BLLMessage_T businessObject = new HPS.BLL.MessageBLL.BLLMessage_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}