using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CompanyGroupDAL
{
    public partial class DALCompanyGroup_T : DataLayerBase
    {

        public DALCompanyGroup_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Output;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObject.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);

                SqlParameter GroupName_nvc = new SqlParameter();
                GroupName_nvc.ParameterName = "@GroupName_nvc";
                GroupName_nvc.SqlDbType = SqlDbType.NVarChar;
                GroupName_nvc.Direction = ParameterDirection.Input;
                GroupName_nvc.IsNullable = false;
                GroupName_nvc.Value = businessObject.GroupName_nvc;
                this.Command.Parameters.Add(GroupName_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.GroupID_int = (Int32)(this.Command.Parameters["@GroupID_int"].Value);

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

        public void Update(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject, HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();
                SqlParameter GroupName_nvc = new SqlParameter();
                GroupName_nvc.ParameterName = "@GroupName_nvc";
                GroupName_nvc.SqlDbType = SqlDbType.NVarChar;
                GroupName_nvc.Direction = ParameterDirection.Input;
                GroupName_nvc.IsNullable = false;
                GroupName_nvc.Value = businessObject.GroupName_nvc;
                this.Command.Parameters.Add(GroupName_nvc);


                SqlParameter pk_GroupID_int = new SqlParameter();
                pk_GroupID_int.ParameterName = "@pk_GroupID_int";
                pk_GroupID_int.SqlDbType = SqlDbType.Int;
                pk_GroupID_int.Direction = ParameterDirection.Input;
                pk_GroupID_int.IsNullable = false;
                pk_GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(pk_GroupID_int);



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

        public void Update(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys();
                businessObjectKey.GroupID_int = (Int32)businessObject.GroupID_int;
                this.Command.Parameters.Clear();
                SqlParameter GroupName_nvc = new SqlParameter();
                GroupName_nvc.ParameterName = "@GroupName_nvc";
                GroupName_nvc.SqlDbType = SqlDbType.NVarChar;
                GroupName_nvc.Direction = ParameterDirection.Input;
                GroupName_nvc.IsNullable = false;
                GroupName_nvc.Value = businessObject.GroupName_nvc;
                this.Command.Parameters.Add(GroupName_nvc);


                SqlParameter pk_GroupID_int = new SqlParameter();
                pk_GroupID_int.ParameterName = "@pk_GroupID_int";
                pk_GroupID_int.SqlDbType = SqlDbType.Int;
                pk_GroupID_int.Direction = ParameterDirection.Input;
                pk_GroupID_int.IsNullable = false;
                pk_GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(pk_GroupID_int);



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

        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> Result = new List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T>();
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

        public DataTable SelectAllToDataTable()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            DataTable resultDataTable = new System.Data.DataTable();
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(resultDataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
                return resultDataTable;
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectAll]";
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

        public HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T SelectByPrimaryKey(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Input;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T();
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

        public void SelectByPrimaryKey(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Input;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Input;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Input;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);



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





        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyGroup_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> Result = new List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T>();
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyGroup_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyGroup_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyGroup_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
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
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> Result = new List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T>();
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CompanyGroup_T_SelectCondition]";
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

        public void Delete(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Input;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);


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

        public void Delete(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyGroup_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys();
                businessObjectKey.GroupID_int = (Int32)businessObject.GroupID_int;
                this.Command.Parameters.Clear();

                SqlParameter GroupID_int = new SqlParameter();
                GroupID_int.ParameterName = "@GroupID_int";
                GroupID_int.SqlDbType = SqlDbType.Int;
                GroupID_int.Direction = ParameterDirection.Input;
                GroupID_int.IsNullable = false;
                GroupID_int.Value = businessObjectKey.GroupID_int;
                this.Command.Parameters.Add(GroupID_int);


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
            this.Command.CommandText = "[sp_CompanyGroup_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.GroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupID_int.ToString()));
                businessObject.GroupName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField.GroupName_nvc.ToString()));
            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> list = new List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject = new HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T();
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