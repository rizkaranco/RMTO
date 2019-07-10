using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeAssignmentCacelRequestDAL
{
    class DALLadeAssignmentCacelRequest_T : DataLayerBase
    {

        public DALLadeAssignmentCacelRequest_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentCancelRequestID_int = new SqlParameter();
                LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
                LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Output;
                LadeAssignmentCancelRequestID_int.IsNullable = false;
                LadeAssignmentCancelRequestID_int.Value = businessObject.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);

                SqlParameter ResuestDate_nvc = new SqlParameter();
                ResuestDate_nvc.ParameterName = "@ResuestDate_nvc";
                ResuestDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ResuestDate_nvc.Direction = ParameterDirection.Input;
                ResuestDate_nvc.IsNullable = false;
                ResuestDate_nvc.Value = businessObject.ResuestDate_nvc;
                this.Command.Parameters.Add(ResuestDate_nvc);

                SqlParameter RequestTime_nvc = new SqlParameter();
                RequestTime_nvc.ParameterName = "@RequestTime_nvc";
                RequestTime_nvc.SqlDbType = SqlDbType.NVarChar;
                RequestTime_nvc.Direction = ParameterDirection.Input;
                RequestTime_nvc.IsNullable = false;
                RequestTime_nvc.Value = businessObject.RequestTime_nvc;
                this.Command.Parameters.Add(RequestTime_nvc);

                SqlParameter RequestUserName_nvc = new SqlParameter();
                RequestUserName_nvc.ParameterName = "@RequestUserName_nvc";
                RequestUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                RequestUserName_nvc.Direction = ParameterDirection.Input;
                RequestUserName_nvc.IsNullable = false;
                RequestUserName_nvc.Value = businessObject.RequestUserName_nvc;
                this.Command.Parameters.Add(RequestUserName_nvc);

                SqlParameter AcceptedDate_nvc = new SqlParameter();
                AcceptedDate_nvc.ParameterName = "@AcceptedDate_nvc";
                AcceptedDate_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedDate_nvc.Direction = ParameterDirection.Input;
                AcceptedDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedDate_nvc))
                {
                    AcceptedDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedDate_nvc.Value = businessObject.AcceptedDate_nvc;
                }
                this.Command.Parameters.Add(AcceptedDate_nvc);

                SqlParameter AcceptedTime_nvc = new SqlParameter();
                AcceptedTime_nvc.ParameterName = "@AcceptedTime_nvc";
                AcceptedTime_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTime_nvc.Direction = ParameterDirection.Input;
                AcceptedTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedTime_nvc))
                {
                    AcceptedTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTime_nvc.Value = businessObject.AcceptedTime_nvc;
                }
                this.Command.Parameters.Add(AcceptedTime_nvc);

                SqlParameter AcceptedUserName_nvc = new SqlParameter();
                AcceptedUserName_nvc.ParameterName = "@AcceptedUserName_nvc";
                AcceptedUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedUserName_nvc.Direction = ParameterDirection.Input;
                AcceptedUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedUserName_nvc))
                {
                    AcceptedUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedUserName_nvc.Value = businessObject.AcceptedUserName_nvc;
                }
                this.Command.Parameters.Add(AcceptedUserName_nvc);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LadeAssignmentCancelRequestID_int = (Int32)(this.Command.Parameters["@LadeAssignmentCancelRequestID_int"].Value);

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

        public void Update(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T businessObject, HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ResuestDate_nvc = new SqlParameter();
                ResuestDate_nvc.ParameterName = "@ResuestDate_nvc";
                ResuestDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ResuestDate_nvc.Direction = ParameterDirection.Input;
                ResuestDate_nvc.IsNullable = false;
                ResuestDate_nvc.Value = businessObject.ResuestDate_nvc;
                this.Command.Parameters.Add(ResuestDate_nvc);

                SqlParameter RequestTime_nvc = new SqlParameter();
                RequestTime_nvc.ParameterName = "@RequestTime_nvc";
                RequestTime_nvc.SqlDbType = SqlDbType.NVarChar;
                RequestTime_nvc.Direction = ParameterDirection.Input;
                RequestTime_nvc.IsNullable = false;
                RequestTime_nvc.Value = businessObject.RequestTime_nvc;
                this.Command.Parameters.Add(RequestTime_nvc);

                SqlParameter RequestUserName_nvc = new SqlParameter();
                RequestUserName_nvc.ParameterName = "@RequestUserName_nvc";
                RequestUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                RequestUserName_nvc.Direction = ParameterDirection.Input;
                RequestUserName_nvc.IsNullable = false;
                RequestUserName_nvc.Value = businessObject.RequestUserName_nvc;
                this.Command.Parameters.Add(RequestUserName_nvc);

                SqlParameter AcceptedDate_nvc = new SqlParameter();
                AcceptedDate_nvc.ParameterName = "@AcceptedDate_nvc";
                AcceptedDate_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedDate_nvc.Direction = ParameterDirection.Input;
                AcceptedDate_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.AcceptedDate_nvc))
                {
                    AcceptedDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedDate_nvc.Value = businessObject.AcceptedDate_nvc;
                }
                this.Command.Parameters.Add(AcceptedDate_nvc);

                SqlParameter AcceptedTime_nvc = new SqlParameter();
                AcceptedTime_nvc.ParameterName = "@AcceptedTime_nvc";
                AcceptedTime_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedTime_nvc.Direction = ParameterDirection.Input;
                AcceptedTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedTime_nvc))
                {
                    AcceptedTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedTime_nvc.Value = businessObject.AcceptedTime_nvc;
                }
                this.Command.Parameters.Add(AcceptedTime_nvc);

                SqlParameter AcceptedUserName_nvc = new SqlParameter();
                AcceptedUserName_nvc.ParameterName = "@AcceptedUserName_nvc";
                AcceptedUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptedUserName_nvc.Direction = ParameterDirection.Input;
                AcceptedUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptedUserName_nvc))
                {
                    AcceptedUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptedUserName_nvc.Value = businessObject.AcceptedUserName_nvc;
                }
                this.Command.Parameters.Add(AcceptedUserName_nvc);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = true;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);


                SqlParameter pk_LadeAssignmentCancelRequestID_int = new SqlParameter();
                pk_LadeAssignmentCancelRequestID_int.ParameterName = "@pk_LadeAssignmentCancelRequestID_int";
                pk_LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                pk_LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
                pk_LadeAssignmentCancelRequestID_int.IsNullable = false;
                pk_LadeAssignmentCancelRequestID_int.Value = businessObjectKey.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(pk_LadeAssignmentCancelRequestID_int);



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

        public List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> Result = new List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T>();
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectAll]";
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

        public HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T SelectByPrimaryKey(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentCancelRequestID_int = new SqlParameter();
                LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
                LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
                LadeAssignmentCancelRequestID_int.IsNullable = false;
                LadeAssignmentCancelRequestID_int.Value = businessObjectKey.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T businessObject = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentCancelRequestID_int = new SqlParameter();
                LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
                LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
                LadeAssignmentCancelRequestID_int.IsNullable = false;
                LadeAssignmentCancelRequestID_int.Value = businessObjectKey.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentCancelRequestID_int = new SqlParameter();
                LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
                LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
                LadeAssignmentCancelRequestID_int.IsNullable = false;
                LadeAssignmentCancelRequestID_int.Value = businessObjectKey.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentCancelRequestID_int = new SqlParameter();
                LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
                LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
                LadeAssignmentCancelRequestID_int.IsNullable = false;
                LadeAssignmentCancelRequestID_int.Value = businessObjectKey.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);



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





        public List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignmentCacelRequest_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> Result = new List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T>();
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignmentCacelRequest_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignmentCacelRequest_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignmentCacelRequest_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
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
                List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> Result = new List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T>();
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentCancelRequestID_int = new SqlParameter();
                LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
                LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
                LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
                LadeAssignmentCancelRequestID_int.IsNullable = false;
                LadeAssignmentCancelRequestID_int.Value = businessObjectKey.LadeAssignmentCancelRequestID_int;
                this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);


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
            this.Command.CommandText = "[sp_LadeAssignmentCacelRequest_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T businessObject, IDataReader dataReader)
        {
            businessObject.LadeAssignmentCancelRequestID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentCancelRequestID_int.ToString()));
            businessObject.ResuestDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.ResuestDate_nvc.ToString()));
            businessObject.RequestTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.RequestTime_nvc.ToString()));
            businessObject.RequestUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.RequestUserName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedDate_nvc.ToString())) == false)
            {
                businessObject.AcceptedDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedDate_nvc.ToString()));
            }
            else
            {
                businessObject.AcceptedDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedTime_nvc.ToString())) == false)
            {
                businessObject.AcceptedTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedTime_nvc.ToString()));
            }
            else
            {
                businessObject.AcceptedTime_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedUserName_nvc.ToString())) == false)
            {
                businessObject.AcceptedUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.AcceptedUserName_nvc.ToString()));
            }
            else
            {
                businessObject.AcceptedUserName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.Comment_nvc.ToString())) == false)
            {
                businessObject.Comment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.Comment_nvc.ToString()));
            }
            else
            {
                businessObject.Comment_nvc = String.Empty;
            }

            businessObject.LadeAssignmentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T.LadeAssignmentCacelRequest_TField.LadeAssignmentID_bint.ToString()));
        }

        public List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T> list = new List<HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T businessObject = new HPS.BLL.LadeAssignmentCacelRequestBLL.BLLLadeAssignmentCacelRequest_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}