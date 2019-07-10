using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadBillCancelCommentDAL
{
    class DALLadBillCancelComment_T : DataLayerBase
    {

        public DALLadBillCancelComment_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Output;
                LadBillCancelCommentID_int.IsNullable = false;
                LadBillCancelCommentID_int.Value = businessObject.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCancelCommentID_int);

                SqlParameter LadbillCancelComment_nvc = new SqlParameter();
                LadbillCancelComment_nvc.ParameterName = "@LadbillCancelComment_nvc";
                LadbillCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
                LadbillCancelComment_nvc.Direction = ParameterDirection.Input;
                LadbillCancelComment_nvc.IsNullable = false;
                LadbillCancelComment_nvc.Value = businessObject.LadbillCancelComment_nvc;
                this.Command.Parameters.Add(LadbillCancelComment_nvc);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = true;
                if (businessObject.UserGroupID_int.HasValue == false)
                {
                    UserGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    UserGroupID_int.Value = businessObject.UserGroupID_int;
                }
                this.Command.Parameters.Add(UserGroupID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LadBillCancelCommentID_int = (Int32)(this.Command.Parameters["@LadBillCancelCommentID_int"].Value);

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

        public void Update(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T businessObject, HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadbillCancelComment_nvc = new SqlParameter();
                LadbillCancelComment_nvc.ParameterName = "@LadbillCancelComment_nvc";
                LadbillCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
                LadbillCancelComment_nvc.Direction = ParameterDirection.Input;
                LadbillCancelComment_nvc.IsNullable = false;
                LadbillCancelComment_nvc.Value = businessObject.LadbillCancelComment_nvc;
                this.Command.Parameters.Add(LadbillCancelComment_nvc);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = false;
                if (businessObject.UserGroupID_int.HasValue == false)
                {
                    UserGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    UserGroupID_int.Value = businessObject.UserGroupID_int;
                }
                this.Command.Parameters.Add(UserGroupID_int);


                SqlParameter pk_LadBillCancelCommentID_int = new SqlParameter();
                pk_LadBillCancelCommentID_int.ParameterName = "@pk_LadBillCancelCommentID_int";
                pk_LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                pk_LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
                pk_LadBillCancelCommentID_int.IsNullable = false;
                pk_LadBillCancelCommentID_int.Value = businessObjectKey.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(pk_LadBillCancelCommentID_int);



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

        public List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> Result = new List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T>();
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectAll]";
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

        public HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T SelectByPrimaryKey(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCancelCommentID_int.IsNullable = false;
                LadBillCancelCommentID_int.Value = businessObjectKey.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCancelCommentID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T businessObject = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCancelCommentID_int.IsNullable = false;
                LadBillCancelCommentID_int.Value = businessObjectKey.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCancelCommentID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCancelCommentID_int.IsNullable = false;
                LadBillCancelCommentID_int.Value = businessObjectKey.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCancelCommentID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCancelCommentID_int.IsNullable = false;
                LadBillCancelCommentID_int.Value = businessObjectKey.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCancelCommentID_int);



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

        public List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCancelComment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> Result = new List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T>();
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCancelComment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCancelComment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCancelComment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
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
                List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> Result = new List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T>();
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCancelComment_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCancelCommentID_int.IsNullable = false;
                LadBillCancelCommentID_int.Value = businessObjectKey.LadBillCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCancelCommentID_int);


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
            this.Command.CommandText = "[sp_LadBillCancelComment_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T businessObject, IDataReader dataReader)
        {
            businessObject.LadBillCancelCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadBillCancelCommentID_int.ToString()));
            businessObject.LadbillCancelComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.LadbillCancelComment_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.UserGroupID_int.ToString())) == false)
            {
                businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T.LadBillCancelComment_TField.UserGroupID_int.ToString()));
            }
            else
            {
                businessObject.UserGroupID_int = null;
            }

        }

        public List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T> list = new List<HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T businessObject = new HPS.BLL.LadBillCancelCommentBLL.BLLLadBillCancelComment_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}