using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.PermissionDAL
{
    class DALPermission_T : DataLayerBase
    {

        public DALPermission_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.PermissionBLL.BLLPermission_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObject.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);

                SqlParameter Permission_nvc = new SqlParameter();
                Permission_nvc.ParameterName = "@Permission_nvc";
                Permission_nvc.SqlDbType = SqlDbType.NVarChar;
                Permission_nvc.Direction = ParameterDirection.Input;
                Permission_nvc.IsNullable = false;
                Permission_nvc.Value = businessObject.Permission_nvc;
                this.Command.Parameters.Add(Permission_nvc);

                SqlParameter PermissionGroupID_int = new SqlParameter();
                PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
                PermissionGroupID_int.SqlDbType = SqlDbType.Int;
                PermissionGroupID_int.Direction = ParameterDirection.Input;
                PermissionGroupID_int.IsNullable = false;
                PermissionGroupID_int.Value = businessObject.PermissionGroupID_int;
                this.Command.Parameters.Add(PermissionGroupID_int);

                SqlParameter FormName_nvc = new SqlParameter();
                FormName_nvc.ParameterName = "@FormName_nvc";
                FormName_nvc.SqlDbType = SqlDbType.NVarChar;
                FormName_nvc.Direction = ParameterDirection.Input;
                FormName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.FormName_nvc))
                {
                    FormName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FormName_nvc.Value = businessObject.FormName_nvc;
                }
                this.Command.Parameters.Add(FormName_nvc);

                SqlParameter ControlName_nvc = new SqlParameter();
                ControlName_nvc.ParameterName = "@ControlName_nvc";
                ControlName_nvc.SqlDbType = SqlDbType.NVarChar;
                ControlName_nvc.Direction = ParameterDirection.Input;
                ControlName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ControlName_nvc))
                {
                    ControlName_nvc.Value = DBNull.Value;
                }
                else
                {
                    ControlName_nvc.Value = businessObject.ControlName_nvc;
                }
                this.Command.Parameters.Add(ControlName_nvc);

                SqlParameter PropertyName_nvc = new SqlParameter();
                PropertyName_nvc.ParameterName = "@PropertyName_nvc";
                PropertyName_nvc.SqlDbType = SqlDbType.NVarChar;
                PropertyName_nvc.Direction = ParameterDirection.Input;
                PropertyName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.PropertyName_nvc))
                {
                    PropertyName_nvc.Value = DBNull.Value;
                }
                else
                {
                    PropertyName_nvc.Value = businessObject.PropertyName_nvc;
                }
                this.Command.Parameters.Add(PropertyName_nvc);

                SqlParameter Value_nvc = new SqlParameter();
                Value_nvc.ParameterName = "@Value_nvc";
                Value_nvc.SqlDbType = SqlDbType.NVarChar;
                Value_nvc.Direction = ParameterDirection.Input;
                Value_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Value_nvc))
                {
                    Value_nvc.Value = DBNull.Value;
                }
                else
                {
                    Value_nvc.Value = businessObject.Value_nvc;
                }
                this.Command.Parameters.Add(Value_nvc);

                SqlParameter ColumnName_nvc = new SqlParameter();
                ColumnName_nvc.ParameterName = "@ColumnName_nvc";
                ColumnName_nvc.SqlDbType = SqlDbType.NVarChar;
                ColumnName_nvc.Direction = ParameterDirection.Input;
                ColumnName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ColumnName_nvc))
                {
                    ColumnName_nvc.Value = DBNull.Value;
                }
                else
                {
                    ColumnName_nvc.Value = businessObject.ColumnName_nvc;
                }
                this.Command.Parameters.Add(ColumnName_nvc);



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

        public void Update(HPS.BLL.PermissionBLL.BLLPermission_T businessObject, HPS.BLL.PermissionBLL.BLLPermission_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObject.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);

                SqlParameter Permission_nvc = new SqlParameter();
                Permission_nvc.ParameterName = "@Permission_nvc";
                Permission_nvc.SqlDbType = SqlDbType.NVarChar;
                Permission_nvc.Direction = ParameterDirection.Input;
                Permission_nvc.IsNullable = false;
                Permission_nvc.Value = businessObject.Permission_nvc;
                this.Command.Parameters.Add(Permission_nvc);

                SqlParameter PermissionGroupID_int = new SqlParameter();
                PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
                PermissionGroupID_int.SqlDbType = SqlDbType.Int;
                PermissionGroupID_int.Direction = ParameterDirection.Input;
                PermissionGroupID_int.IsNullable = false;
                PermissionGroupID_int.Value = businessObject.PermissionGroupID_int;
                this.Command.Parameters.Add(PermissionGroupID_int);

                SqlParameter FormName_nvc = new SqlParameter();
                FormName_nvc.ParameterName = "@FormName_nvc";
                FormName_nvc.SqlDbType = SqlDbType.NVarChar;
                FormName_nvc.Direction = ParameterDirection.Input;
                FormName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.FormName_nvc))
                {
                    FormName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FormName_nvc.Value = businessObject.FormName_nvc;
                }
                this.Command.Parameters.Add(FormName_nvc);

                SqlParameter ControlName_nvc = new SqlParameter();
                ControlName_nvc.ParameterName = "@ControlName_nvc";
                ControlName_nvc.SqlDbType = SqlDbType.NVarChar;
                ControlName_nvc.Direction = ParameterDirection.Input;
                ControlName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ControlName_nvc))
                {
                    ControlName_nvc.Value = DBNull.Value;
                }
                else
                {
                    ControlName_nvc.Value = businessObject.ControlName_nvc;
                }
                this.Command.Parameters.Add(ControlName_nvc);

                SqlParameter PropertyName_nvc = new SqlParameter();
                PropertyName_nvc.ParameterName = "@PropertyName_nvc";
                PropertyName_nvc.SqlDbType = SqlDbType.NVarChar;
                PropertyName_nvc.Direction = ParameterDirection.Input;
                PropertyName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.PropertyName_nvc))
                {
                    PropertyName_nvc.Value = DBNull.Value;
                }
                else
                {
                    PropertyName_nvc.Value = businessObject.PropertyName_nvc;
                }
                this.Command.Parameters.Add(PropertyName_nvc);

                SqlParameter Value_nvc = new SqlParameter();
                Value_nvc.ParameterName = "@Value_nvc";
                Value_nvc.SqlDbType = SqlDbType.NVarChar;
                Value_nvc.Direction = ParameterDirection.Input;
                Value_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Value_nvc))
                {
                    Value_nvc.Value = DBNull.Value;
                }
                else
                {
                    Value_nvc.Value = businessObject.Value_nvc;
                }
                this.Command.Parameters.Add(Value_nvc);

                SqlParameter ColumnName_nvc = new SqlParameter();
                ColumnName_nvc.ParameterName = "@ColumnName_nvc";
                ColumnName_nvc.SqlDbType = SqlDbType.NVarChar;
                ColumnName_nvc.Direction = ParameterDirection.Input;
                ColumnName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ColumnName_nvc))
                {
                    ColumnName_nvc.Value = DBNull.Value;
                }
                else
                {
                    ColumnName_nvc.Value = businessObject.ColumnName_nvc;
                }
                this.Command.Parameters.Add(ColumnName_nvc);


                SqlParameter pk_PermissionID_bint = new SqlParameter();
                pk_PermissionID_bint.ParameterName = "@pk_PermissionID_bint";
                pk_PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                pk_PermissionID_bint.Direction = ParameterDirection.Input;
                pk_PermissionID_bint.IsNullable = false;
                pk_PermissionID_bint.Value = businessObjectKey.PermissionID_bint;
                this.Command.Parameters.Add(pk_PermissionID_bint);



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

        public List<HPS.BLL.PermissionBLL.BLLPermission_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.PermissionBLL.BLLPermission_T> Result = new List<HPS.BLL.PermissionBLL.BLLPermission_T>();
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
            this.Command.CommandText = "[sp_Permission_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Permission_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Permission_T_SelectAll]";
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

        public HPS.BLL.PermissionBLL.BLLPermission_T SelectByPrimaryKey(HPS.BLL.PermissionBLL.BLLPermission_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.PermissionBLL.BLLPermission_T businessObject = new HPS.BLL.PermissionBLL.BLLPermission_T();
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

        public void SelectByPrimaryKey(HPS.BLL.PermissionBLL.BLLPermission_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.PermissionBLL.BLLPermission_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.PermissionBLL.BLLPermission_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);



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

        public List<HPS.BLL.PermissionBLL.BLLPermission_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.PermissionBLL.BLLPermission_T> Result = new List<HPS.BLL.PermissionBLL.BLLPermission_T>();
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
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.PermissionBLL.BLLPermission_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
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
                List<HPS.BLL.PermissionBLL.BLLPermission_T> Result = new List<HPS.BLL.PermissionBLL.BLLPermission_T>();
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
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Permission_T_SelectCondition]";
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

        public void Delete(HPS.BLL.PermissionBLL.BLLPermission_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Permission_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PermissionID_bint = new SqlParameter();
                PermissionID_bint.ParameterName = "@PermissionID_bint";
                PermissionID_bint.SqlDbType = SqlDbType.BigInt;
                PermissionID_bint.Direction = ParameterDirection.Input;
                PermissionID_bint.IsNullable = false;
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint;
                this.Command.Parameters.Add(PermissionID_bint);


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
            this.Command.CommandText = "[sp_Permission_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.PermissionBLL.BLLPermission_T businessObject, IDataReader dataReader)
        {
            businessObject.PermissionID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.PermissionID_bint.ToString()));
            businessObject.Permission_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.Permission_nvc.ToString()));
            businessObject.PermissionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.PermissionGroupID_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.FormName_nvc.ToString())) == false)
            {
                businessObject.FormName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.FormName_nvc.ToString()));
            }
            else
            {
                businessObject.FormName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.ControlName_nvc.ToString())) == false)
            {
                businessObject.ControlName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.ControlName_nvc.ToString()));
            }
            else
            {
                businessObject.ControlName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.PropertyName_nvc.ToString())) == false)
            {
                businessObject.PropertyName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.PropertyName_nvc.ToString()));
            }
            else
            {
                businessObject.PropertyName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.Value_nvc.ToString())) == false)
            {
                businessObject.Value_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.Value_nvc.ToString()));
            }
            else
            {
                businessObject.Value_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.ColumnName_nvc.ToString())) == false)
            {
                businessObject.ColumnName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.ColumnName_nvc.ToString()));
            }
            else
            {
                businessObject.ColumnName_nvc = String.Empty;
            }

        }

        public List<HPS.BLL.PermissionBLL.BLLPermission_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.PermissionBLL.BLLPermission_T> list = new List<HPS.BLL.PermissionBLL.BLLPermission_T>();
            while (dataReader.Read())
            {
                HPS.BLL.PermissionBLL.BLLPermission_T businessObject = new HPS.BLL.PermissionBLL.BLLPermission_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}