using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadBillCreditCanceDAL
{
    class DALLadBillCreditCancel_T : DataLayerBase
    {

        public DALLadBillCreditCancel_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelID_int = new SqlParameter();
                LadBillCreditCancelID_int.ParameterName = "@LadBillCreditCancelID_int";
                LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelID_int.Direction = ParameterDirection.Output;
                LadBillCreditCancelID_int.IsNullable = false;
                LadBillCreditCancelID_int.Value = businessObject.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(LadBillCreditCancelID_int);

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

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObject.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = false;
                Comment_nvc.Value = businessObject.Comment_nvc;
                this.Command.Parameters.Add(Comment_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LadBillCreditCancelID_int = (Int32)(this.Command.Parameters["@LadBillCreditCancelID_int"].Value);

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

        public void Update(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T businessObject, HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

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

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObject.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = false;
                Comment_nvc.Value = businessObject.Comment_nvc;
                this.Command.Parameters.Add(Comment_nvc);


                SqlParameter pk_LadBillCreditCancelID_int = new SqlParameter();
                pk_LadBillCreditCancelID_int.ParameterName = "@pk_LadBillCreditCancelID_int";
                pk_LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                pk_LadBillCreditCancelID_int.Direction = ParameterDirection.Input;
                pk_LadBillCreditCancelID_int.IsNullable = false;
                pk_LadBillCreditCancelID_int.Value = businessObjectKey.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(pk_LadBillCreditCancelID_int);



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

        public List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> Result = new List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T>();
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectAll]";
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

        public HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelID_int = new SqlParameter();
                LadBillCreditCancelID_int.ParameterName = "@LadBillCreditCancelID_int";
                LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelID_int.IsNullable = false;
                LadBillCreditCancelID_int.Value = businessObjectKey.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(LadBillCreditCancelID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T businessObject = new HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelID_int = new SqlParameter();
                LadBillCreditCancelID_int.ParameterName = "@LadBillCreditCancelID_int";
                LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelID_int.IsNullable = false;
                LadBillCreditCancelID_int.Value = businessObjectKey.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(LadBillCreditCancelID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelID_int = new SqlParameter();
                LadBillCreditCancelID_int.ParameterName = "@LadBillCreditCancelID_int";
                LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelID_int.IsNullable = false;
                LadBillCreditCancelID_int.Value = businessObjectKey.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(LadBillCreditCancelID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelID_int = new SqlParameter();
                LadBillCreditCancelID_int.ParameterName = "@LadBillCreditCancelID_int";
                LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelID_int.IsNullable = false;
                LadBillCreditCancelID_int.Value = businessObjectKey.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(LadBillCreditCancelID_int);



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





        public List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancel_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> Result = new List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T>();
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancel_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancel_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCreditCancel_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
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
                List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> Result = new List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T>();
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditCancelID_int = new SqlParameter();
                LadBillCreditCancelID_int.ParameterName = "@LadBillCreditCancelID_int";
                LadBillCreditCancelID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditCancelID_int.Direction = ParameterDirection.Input;
                LadBillCreditCancelID_int.IsNullable = false;
                LadBillCreditCancelID_int.Value = businessObjectKey.LadBillCreditCancelID_int;
                this.Command.Parameters.Add(LadBillCreditCancelID_int);


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
            this.Command.CommandText = "[sp_LadBillCreditCancel_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T businessObject, IDataReader dataReader)
        {
            businessObject.LadBillCreditCancelID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T.LadBillCreditCancel_TField.LadBillCreditCancelID_int.ToString()));
            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T.LadBillCreditCancel_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T.LadBillCreditCancel_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T.LadBillCreditCancel_TField.UserName_nvc.ToString()));
            businessObject.LadBillCreditID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T.LadBillCreditCancel_TField.LadBillCreditID_int.ToString()));
            businessObject.Comment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T.LadBillCreditCancel_TField.Comment_nvc.ToString()));
        }

        public List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T> list = new List<HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T businessObject = new HPS.BLL.LadBillCreditCancelBLL.BLLLadBillCreditCancel_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}