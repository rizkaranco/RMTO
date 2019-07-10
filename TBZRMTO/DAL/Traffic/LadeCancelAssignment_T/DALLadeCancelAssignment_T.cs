using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeCancelAssignmentDAL
{
    class DALLadeCancelAssignment_T : DataLayerBase
    {

        public DALLadeCancelAssignment_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelAssignmentID_int = new SqlParameter();
                LadeCancelAssignmentID_int.ParameterName = "@LadeCancelAssignmentID_int";
                LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelAssignmentID_int.Direction = ParameterDirection.Output;
                LadeCancelAssignmentID_int.IsNullable = false;
                LadeCancelAssignmentID_int.Value = businessObject.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(LadeCancelAssignmentID_int);

                SqlParameter LadeCancelCommentID_int = new SqlParameter();
                LadeCancelCommentID_int.ParameterName = "@LadeCancelCommentID_int";
                LadeCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelCommentID_int.Direction = ParameterDirection.Input;
                LadeCancelCommentID_int.IsNullable = false;
                LadeCancelCommentID_int.Value = businessObject.LadeCancelCommentID_int;
                this.Command.Parameters.Add(LadeCancelCommentID_int);

                SqlParameter LadeCancelComment_nvc = new SqlParameter();
                LadeCancelComment_nvc.ParameterName = "@LadeCancelComment_nvc";
                LadeCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
                LadeCancelComment_nvc.Direction = ParameterDirection.Input;
                LadeCancelComment_nvc.IsNullable = false;
                LadeCancelComment_nvc.Value = businessObject.LadeCancelComment_nvc;
                this.Command.Parameters.Add(LadeCancelComment_nvc);

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter Count_int = new SqlParameter();
                Count_int.ParameterName = "@Count_int";
                Count_int.SqlDbType = SqlDbType.Int;
                Count_int.Direction = ParameterDirection.Input;
                Count_int.IsNullable = true;
                if (businessObject.Count_int.HasValue == false)
                {
                    Count_int.Value = DBNull.Value;
                }
                else
                {
                    Count_int.Value = businessObject.Count_int;
                }
                this.Command.Parameters.Add(Count_int);

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

                businessObject.LadeCancelAssignmentID_int = (Int32)(this.Command.Parameters["@LadeCancelAssignmentID_int"].Value);

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

        public void Update(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T businessObject, HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelCommentID_int = new SqlParameter();
                LadeCancelCommentID_int.ParameterName = "@LadeCancelCommentID_int";
                LadeCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelCommentID_int.Direction = ParameterDirection.Input;
                LadeCancelCommentID_int.IsNullable = false;
                LadeCancelCommentID_int.Value = businessObject.LadeCancelCommentID_int;
                this.Command.Parameters.Add(LadeCancelCommentID_int);

                SqlParameter LadeCancelComment_nvc = new SqlParameter();
                LadeCancelComment_nvc.ParameterName = "@LadeCancelComment_nvc";
                LadeCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
                LadeCancelComment_nvc.Direction = ParameterDirection.Input;
                LadeCancelComment_nvc.IsNullable = false;
                LadeCancelComment_nvc.Value = businessObject.LadeCancelComment_nvc;
                this.Command.Parameters.Add(LadeCancelComment_nvc);

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter Count_int = new SqlParameter();
                Count_int.ParameterName = "@Count_int";
                Count_int.SqlDbType = SqlDbType.Int;
                Count_int.Direction = ParameterDirection.Input;
                Count_int.IsNullable = false;
                if (businessObject.Count_int.HasValue == false)
                {
                    Count_int.Value = DBNull.Value;
                }
                else
                {
                    Count_int.Value = businessObject.Count_int;
                }
                this.Command.Parameters.Add(Count_int);

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


                SqlParameter pk_LadeCancelAssignmentID_int = new SqlParameter();
                pk_LadeCancelAssignmentID_int.ParameterName = "@pk_LadeCancelAssignmentID_int";
                pk_LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                pk_LadeCancelAssignmentID_int.Direction = ParameterDirection.Input;
                pk_LadeCancelAssignmentID_int.IsNullable = false;
                pk_LadeCancelAssignmentID_int.Value = businessObjectKey.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(pk_LadeCancelAssignmentID_int);



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

        public List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> Result = new List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T>();
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectAll]";
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

        public HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T SelectByPrimaryKey(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelAssignmentID_int = new SqlParameter();
                LadeCancelAssignmentID_int.ParameterName = "@LadeCancelAssignmentID_int";
                LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelAssignmentID_int.Direction = ParameterDirection.Input;
                LadeCancelAssignmentID_int.IsNullable = false;
                LadeCancelAssignmentID_int.Value = businessObjectKey.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(LadeCancelAssignmentID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T businessObject = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelAssignmentID_int = new SqlParameter();
                LadeCancelAssignmentID_int.ParameterName = "@LadeCancelAssignmentID_int";
                LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelAssignmentID_int.Direction = ParameterDirection.Input;
                LadeCancelAssignmentID_int.IsNullable = false;
                LadeCancelAssignmentID_int.Value = businessObjectKey.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(LadeCancelAssignmentID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelAssignmentID_int = new SqlParameter();
                LadeCancelAssignmentID_int.ParameterName = "@LadeCancelAssignmentID_int";
                LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelAssignmentID_int.Direction = ParameterDirection.Input;
                LadeCancelAssignmentID_int.IsNullable = false;
                LadeCancelAssignmentID_int.Value = businessObjectKey.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(LadeCancelAssignmentID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelAssignmentID_int = new SqlParameter();
                LadeCancelAssignmentID_int.ParameterName = "@LadeCancelAssignmentID_int";
                LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelAssignmentID_int.Direction = ParameterDirection.Input;
                LadeCancelAssignmentID_int.IsNullable = false;
                LadeCancelAssignmentID_int.Value = businessObjectKey.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(LadeCancelAssignmentID_int);



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





        public List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeCancelAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> Result = new List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T>();
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeCancelAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeCancelAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeCancelAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
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
                List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> Result = new List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T>();
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeCancelAssignmentID_int = new SqlParameter();
                LadeCancelAssignmentID_int.ParameterName = "@LadeCancelAssignmentID_int";
                LadeCancelAssignmentID_int.SqlDbType = SqlDbType.Int;
                LadeCancelAssignmentID_int.Direction = ParameterDirection.Input;
                LadeCancelAssignmentID_int.IsNullable = false;
                LadeCancelAssignmentID_int.Value = businessObjectKey.LadeCancelAssignmentID_int;
                this.Command.Parameters.Add(LadeCancelAssignmentID_int);


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
            this.Command.CommandText = "[sp_LadeCancelAssignment_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T businessObject, IDataReader dataReader)
        {
            businessObject.LadeCancelAssignmentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeCancelAssignmentID_int.ToString()));
            businessObject.LadeCancelCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeCancelCommentID_int.ToString()));
            businessObject.LadeCancelComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeCancelComment_nvc.ToString()));
            businessObject.LadeAssignmentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.LadeAssignmentID_bint.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.Count_int.ToString())) == false)
            {
                businessObject.Count_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.Count_int.ToString()));
            }
            else
            {
                businessObject.Count_int = null;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T.LadeCancelAssignment_TField.UserName_nvc.ToString()));
        }

        public List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T> list = new List<HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T businessObject = new HPS.BLL.LadeCancelAssignmentBLL.BLLLadeCancelAssignment_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}