using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL
{
    public partial class DALCompanyMobile_T : DataLayerBase
    {

        public DALCompanyMobile_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.BLLCompanyMobile_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyMobileID_int = new SqlParameter();
                CompanyMobileID_int.ParameterName = "@CompanyMobileID_int";
                CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                CompanyMobileID_int.Direction = ParameterDirection.Output;
                CompanyMobileID_int.IsNullable = false;
                CompanyMobileID_int.Value = businessObject.CompanyMobileID_int;
                this.Command.Parameters.Add(CompanyMobileID_int);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObject.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter MobileNumber_nvc = new SqlParameter();
                MobileNumber_nvc.ParameterName = "@MobileNumber_nvc";
                MobileNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                MobileNumber_nvc.Direction = ParameterDirection.Input;
                MobileNumber_nvc.IsNullable = false;
                MobileNumber_nvc.Value = businessObject.MobileNumber_nvc;
                this.Command.Parameters.Add(MobileNumber_nvc);

                SqlParameter FirstName_nvcParam = new SqlParameter();
                FirstName_nvcParam.ParameterName = "@FirstName_nvc";
                FirstName_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvcParam.Direction = ParameterDirection.Input;
                FirstName_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FirstName_nvc))
                {
                    FirstName_nvcParam.Value = DBNull.Value;
                }
                else
                {
                FirstName_nvcParam.Value = businessObject.FirstName_nvc;
                }
                this.Command.Parameters.Add(FirstName_nvcParam);

                SqlParameter LastName_nvcParam = new SqlParameter();
                LastName_nvcParam.ParameterName = "@LastName_nvc";
                LastName_nvcParam.SqlDbType = SqlDbType.NVarChar;
                LastName_nvcParam.Direction = ParameterDirection.Input;
                LastName_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.LastName_nvc))
                {
                    LastName_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvcParam.Value = businessObject.LastName_nvc;
                }
                this.Command.Parameters.Add(LastName_nvcParam);

                SqlParameter Active_bitParam = new SqlParameter();
                Active_bitParam.ParameterName = "@Active_bit";
                Active_bitParam.SqlDbType = SqlDbType.Bit;
                Active_bitParam.Direction = ParameterDirection.Input;
                Active_bitParam.IsNullable = false;           
                Active_bitParam.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bitParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.CompanyMobileID_int = (Int32)(this.Command.Parameters["@CompanyMobileID_int"].Value);

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

        public void Update(HPS.BLL.BLLCompanyMobile_T businessObject, HPS.BLL.BLLCompanyMobile_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObject.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter MobileNumber_nvc = new SqlParameter();
                MobileNumber_nvc.ParameterName = "@MobileNumber_nvc";
                MobileNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                MobileNumber_nvc.Direction = ParameterDirection.Input;
                MobileNumber_nvc.IsNullable = false;
                MobileNumber_nvc.Value = businessObject.MobileNumber_nvc;
                this.Command.Parameters.Add(MobileNumber_nvc);

                SqlParameter FirstName_nvcParam = new SqlParameter();
                FirstName_nvcParam.ParameterName = "@FirstName_nvc";
                FirstName_nvcParam.SqlDbType = SqlDbType.NVarChar;
                FirstName_nvcParam.Direction = ParameterDirection.Input;
                FirstName_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FirstName_nvc))
                {
                    FirstName_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    FirstName_nvcParam.Value = businessObject.FirstName_nvc;
                }
                this.Command.Parameters.Add(FirstName_nvcParam);

                SqlParameter LastName_nvcParam = new SqlParameter();
                LastName_nvcParam.ParameterName = "@LastName_nvc";
                LastName_nvcParam.SqlDbType = SqlDbType.NVarChar;
                LastName_nvcParam.Direction = ParameterDirection.Input;
                LastName_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.LastName_nvc))
                {
                    LastName_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    LastName_nvcParam.Value = businessObject.LastName_nvc;
                }
                this.Command.Parameters.Add(LastName_nvcParam);

                SqlParameter Active_bitParam = new SqlParameter();
                Active_bitParam.ParameterName = "@Active_bit";
                Active_bitParam.SqlDbType = SqlDbType.Bit;
                Active_bitParam.Direction = ParameterDirection.Input;
                Active_bitParam.IsNullable = false;
                Active_bitParam.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bitParam);

                SqlParameter pk_CompanyMobileID_int = new SqlParameter();
                pk_CompanyMobileID_int.ParameterName = "@pk_CompanyMobileID_int";
                pk_CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                pk_CompanyMobileID_int.Direction = ParameterDirection.Input;
                pk_CompanyMobileID_int.IsNullable = false;
                pk_CompanyMobileID_int.Value = businessObjectKey.CompanyMobileID_int;
                this.Command.Parameters.Add(pk_CompanyMobileID_int);



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

        public List<HPS.BLL.BLLCompanyMobile_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLCompanyMobile_T> Result = new List<HPS.BLL.BLLCompanyMobile_T>();
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectAll]";
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

        public HPS.BLL.BLLCompanyMobile_T SelectByPrimaryKey(HPS.BLL.BLLCompanyMobile_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyMobileID_int = new SqlParameter();
                CompanyMobileID_int.ParameterName = "@CompanyMobileID_int";
                CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                CompanyMobileID_int.Direction = ParameterDirection.Input;
                CompanyMobileID_int.IsNullable = false;
                CompanyMobileID_int.Value = businessObjectKey.CompanyMobileID_int;
                this.Command.Parameters.Add(CompanyMobileID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.BLLCompanyMobile_T businessObject = new HPS.BLL.BLLCompanyMobile_T();
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

        public void SelectByPrimaryKey(HPS.BLL.BLLCompanyMobile_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyMobileID_int = new SqlParameter();
                CompanyMobileID_int.ParameterName = "@CompanyMobileID_int";
                CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                CompanyMobileID_int.Direction = ParameterDirection.Input;
                CompanyMobileID_int.IsNullable = false;
                CompanyMobileID_int.Value = businessObjectKey.CompanyMobileID_int;
                this.Command.Parameters.Add(CompanyMobileID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLCompanyMobile_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyMobileID_int = new SqlParameter();
                CompanyMobileID_int.ParameterName = "@CompanyMobileID_int";
                CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                CompanyMobileID_int.Direction = ParameterDirection.Input;
                CompanyMobileID_int.IsNullable = false;
                CompanyMobileID_int.Value = businessObjectKey.CompanyMobileID_int;
                this.Command.Parameters.Add(CompanyMobileID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLCompanyMobile_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyMobileID_int = new SqlParameter();
                CompanyMobileID_int.ParameterName = "@CompanyMobileID_int";
                CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                CompanyMobileID_int.Direction = ParameterDirection.Input;
                CompanyMobileID_int.IsNullable = false;
                CompanyMobileID_int.Value = businessObjectKey.CompanyMobileID_int;
                this.Command.Parameters.Add(CompanyMobileID_int);



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





        public List<HPS.BLL.BLLCompanyMobile_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyMobile_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLCompanyMobile_T> Result = new List<HPS.BLL.BLLCompanyMobile_T>();
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyMobile_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyMobile_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyMobile_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.BLLCompanyMobile_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
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
                List<HPS.BLL.BLLCompanyMobile_T> Result = new List<HPS.BLL.BLLCompanyMobile_T>();
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CompanyMobile_T_SelectCondition]";
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

        public void Delete(HPS.BLL.BLLCompanyMobile_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyMobile_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyMobileID_int = new SqlParameter();
                CompanyMobileID_int.ParameterName = "@CompanyMobileID_int";
                CompanyMobileID_int.SqlDbType = SqlDbType.Int;
                CompanyMobileID_int.Direction = ParameterDirection.Input;
                CompanyMobileID_int.IsNullable = false;
                CompanyMobileID_int.Value = businessObjectKey.CompanyMobileID_int;
                this.Command.Parameters.Add(CompanyMobileID_int);


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
            this.Command.CommandText = "[sp_CompanyMobile_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.BLLCompanyMobile_T businessObject, IDataReader dataReader)
        {
            businessObject.CompanyMobileID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyMobileID_int.ToString()));
            businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.CompanyID_int.ToString()));
            businessObject.MobileNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.MobileNumber_nvc.ToString()));
            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.Active_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.FirstName_nvc.ToString())) == false)
            {
                businessObject.FirstName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.FirstName_nvc.ToString()));
            }
            else
            {
                businessObject.FirstName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.LastName_nvc.ToString())) == false)
            {
                businessObject.LastName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLCompanyMobile_T.CompanyMobile_TField.LastName_nvc.ToString()));
            }
            else
            {
                businessObject.LastName_nvc = String.Empty;
            }
        }

        public List<HPS.BLL.BLLCompanyMobile_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.BLLCompanyMobile_T> list = new List<HPS.BLL.BLLCompanyMobile_T>();
            while (dataReader.Read())
            {
                HPS.BLL.BLLCompanyMobile_T businessObject = new HPS.BLL.BLLCompanyMobile_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}