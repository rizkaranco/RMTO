using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadBillCreditCancelCommentDAL
{
    class DALLadBillCreditCancelComment_T : DataLayerBase
    {

        public DALLadBillCreditCancelComment_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelCommentID_int = new SqlParameter();
                LadBillCreditCancelCommentID_int.ParameterName = "@LadBillCreditCancelCommentID_int";
                LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Output;
                LadBillCreditCancelCommentID_int.IsNullable = false;
                LadBillCreditCancelCommentID_int.Value = businessObject.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCreditCancelCommentID_int);

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObject.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
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



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LadBillCreditCancelCommentID_int = (Int32)(this.Command.Parameters["@LadBillCreditCancelCommentID_int"].Value);

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

        public void Update(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T businessObject, HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObject.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

                SqlParameter LadBillCancelCommentID_int = new SqlParameter();
                LadBillCancelCommentID_int.ParameterName = "@LadBillCancelCommentID_int";
                LadBillCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCancelCommentID_int.Direction = ParameterDirection.Input;
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


                SqlParameter pk_LadBillCreditCancelCommentID_int = new SqlParameter();
                pk_LadBillCreditCancelCommentID_int.ParameterName = "@pk_LadBillCreditCancelCommentID_int";
                pk_LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                pk_LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Input;
                pk_LadBillCreditCancelCommentID_int.IsNullable = false;
                pk_LadBillCreditCancelCommentID_int.Value = businessObjectKey.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(pk_LadBillCreditCancelCommentID_int);



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

        public List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> Result = new List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T>();
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectAll]";
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

        public HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelCommentID_int = new SqlParameter();
                LadBillCreditCancelCommentID_int.ParameterName = "@LadBillCreditCancelCommentID_int";
                LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelCommentID_int.IsNullable = false;
                LadBillCreditCancelCommentID_int.Value = businessObjectKey.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCreditCancelCommentID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T businessObject = new HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelCommentID_int = new SqlParameter();
                LadBillCreditCancelCommentID_int.ParameterName = "@LadBillCreditCancelCommentID_int";
                LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelCommentID_int.IsNullable = false;
                LadBillCreditCancelCommentID_int.Value = businessObjectKey.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCreditCancelCommentID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelCommentID_int = new SqlParameter();
                LadBillCreditCancelCommentID_int.ParameterName = "@LadBillCreditCancelCommentID_int";
                LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelCommentID_int.IsNullable = false;
                LadBillCreditCancelCommentID_int.Value = businessObjectKey.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCreditCancelCommentID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelCommentID_int = new SqlParameter();
                LadBillCreditCancelCommentID_int.ParameterName = "@LadBillCreditCancelCommentID_int";
                LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelCommentID_int.IsNullable = false;
                LadBillCreditCancelCommentID_int.Value = businessObjectKey.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCreditCancelCommentID_int);



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

        public List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancelComment_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> Result = new List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T>();
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancelComment_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancelComment_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancelComment_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
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
                List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> Result = new List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T>();
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelCommentID_int = new SqlParameter();
                LadBillCreditCancelCommentID_int.ParameterName = "@LadBillCreditCancelCommentID_int";
                LadBillCreditCancelCommentID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelCommentID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelCommentID_int.IsNullable = false;
                LadBillCreditCancelCommentID_int.Value = businessObjectKey.LadBillCreditCancelCommentID_int;
                this.Command.Parameters.Add(LadBillCreditCancelCommentID_int);


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
            this.Command.CommandText = "[sp_LadBillCreditCancelComment_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T businessObject, IDataReader dataReader)
        {
            businessObject.LadBillCreditCancelCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T.LadBillCreditCancelComment_TField.LadBillCreditCancelCommentID_int.ToString()));
            businessObject.LadBillCreditID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T.LadBillCreditCancelComment_TField.LadBillCreditID_int.ToString()));
            businessObject.LadBillCancelCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T.LadBillCreditCancelComment_TField.LadBillCancelCommentID_int.ToString()));
            businessObject.LadbillCancelComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T.LadBillCreditCancelComment_TField.LadbillCancelComment_nvc.ToString()));
        }

        public List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T> list = new List<HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T businessObject = new HPS.BLL.LadBillCreditCancelCommentBLL.BLLLadBillCreditCancelComment_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}