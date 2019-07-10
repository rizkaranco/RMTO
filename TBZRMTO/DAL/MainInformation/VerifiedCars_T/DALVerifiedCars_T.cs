using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DALVerifiedCars
{
    public partial class DALVerifiedCars_T : DataLayerBase
    {

        public DALVerifiedCars_T() : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                if (businessObject.CompanyID_int.HasValue == false)
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = businessObject.CompanyID_int;
                }
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.NumberPlate_nvc))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                }
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SerialPlate_nvc))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = businessObject.SerialPlate_nvc;
                }
                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Date_vc) )
                {
                    Date_vc.Value = DBNull.Value;
                }
                else
                {
                    Date_vc.Value = businessObject.Date_vc;
                }
                this.Command.Parameters.Add(Date_vc);

                SqlParameter FullName_nvc = new SqlParameter();
                FullName_nvc.ParameterName = "@FullName_nvc";
                FullName_nvc.SqlDbType = SqlDbType.NVarChar;
                FullName_nvc.Direction = ParameterDirection.Input;
                FullName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FullName_nvc))
                {
                    FullName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FullName_nvc.Value = businessObject.FullName_nvc;
                }
                this.Command.Parameters.Add(FullName_nvc);

                SqlParameter Unit_nvc = new SqlParameter();
                Unit_nvc.ParameterName = "@Unit_nvc";
                Unit_nvc.SqlDbType = SqlDbType.NVarChar;
                Unit_nvc.Direction = ParameterDirection.Input;
                Unit_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Unit_nvc))
                {
                    Unit_nvc.Value = DBNull.Value;
                }
                else
                {
                    Unit_nvc.Value = businessObject.Unit_nvc;
                }
                this.Command.Parameters.Add(Unit_nvc);

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

        public void Update(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T businessObject, HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                if (businessObject.CompanyID_int.HasValue == false)
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = businessObject.CompanyID_int;
                }
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.NumberPlate_nvc))
                {
                    NumberPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                }
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SerialPlate_nvc))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = businessObject.SerialPlate_nvc;
                }
                this.Command.Parameters.Add(SerialPlate_nvc);

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Date_vc) )
                {
                    Date_vc.Value = DBNull.Value;
                }
                else
                {
                    Date_vc.Value = businessObject.Date_vc;
                }
                this.Command.Parameters.Add(Date_vc);


                SqlParameter pk_VerifiedCarID_int = new SqlParameter();
                pk_VerifiedCarID_int.ParameterName = "@pk_VerifiedCarID_int";
                pk_VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                pk_VerifiedCarID_int.Direction = ParameterDirection.Input;
                pk_VerifiedCarID_int.IsNullable = false;
                pk_VerifiedCarID_int.Value = businessObjectKey.VerifiedCarID_int;
                this.Command.Parameters.Add(pk_VerifiedCarID_int);

                SqlParameter FullName_nvc = new SqlParameter();
                FullName_nvc.ParameterName = "@FullName_nvc";
                FullName_nvc.SqlDbType = SqlDbType.NVarChar;
                FullName_nvc.Direction = ParameterDirection.Input;
                FullName_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FullName_nvc))
                {
                    FullName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FullName_nvc.Value = businessObject.FullName_nvc;
                }
                this.Command.Parameters.Add(FullName_nvc);

                SqlParameter Unit_nvc = new SqlParameter();
                Unit_nvc.ParameterName = "@Unit_nvc";
                Unit_nvc.SqlDbType = SqlDbType.NVarChar;
                Unit_nvc.Direction = ParameterDirection.Input;
                Unit_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Unit_nvc))
                {
                    Unit_nvc.Value = DBNull.Value;
                }
                else
                {
                    Unit_nvc.Value = businessObject.Unit_nvc;
                }
                this.Command.Parameters.Add(Unit_nvc);

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

        public void Update(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_UpdateDate]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Date_vc))
                {
                    Date_vc.Value = DBNull.Value;
                }
                else
                {
                    Date_vc.Value = businessObject.Date_vc;
                }
                this.Command.Parameters.Add(Date_vc);


                SqlParameter pk_VerifiedCarID_int = new SqlParameter();
                pk_VerifiedCarID_int.ParameterName = "@pk_VerifiedCarID_int";
                pk_VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                pk_VerifiedCarID_int.Direction = ParameterDirection.Input;
                pk_VerifiedCarID_int.IsNullable = false;
                pk_VerifiedCarID_int.Value = businessObject.VerifiedCarID_int;
                this.Command.Parameters.Add(pk_VerifiedCarID_int);



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

        public List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> Result = new List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T>();
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectAll]";
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectAll]";
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectAll]";
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

        public HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T SelectByPrimaryKey(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter VerifiedCarID_int = new SqlParameter();
                VerifiedCarID_int.ParameterName = "@VerifiedCarID_int";
                VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                VerifiedCarID_int.Direction = ParameterDirection.Input;
                VerifiedCarID_int.IsNullable = false;
                VerifiedCarID_int.Value = businessObjectKey.VerifiedCarID_int;
                this.Command.Parameters.Add(VerifiedCarID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T businessObject = new HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T();
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

        public void SelectByPrimaryKey(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter VerifiedCarID_int = new SqlParameter();
                VerifiedCarID_int.ParameterName = "@VerifiedCarID_int";
                VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                VerifiedCarID_int.Direction = ParameterDirection.Input;
                VerifiedCarID_int.IsNullable = false;
                VerifiedCarID_int.Value = businessObjectKey.VerifiedCarID_int;
                this.Command.Parameters.Add(VerifiedCarID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter VerifiedCarID_int = new SqlParameter();
                VerifiedCarID_int.ParameterName = "@VerifiedCarID_int";
                VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                VerifiedCarID_int.Direction = ParameterDirection.Input;
                VerifiedCarID_int.IsNullable = false;
                VerifiedCarID_int.Value = businessObjectKey.VerifiedCarID_int;
                this.Command.Parameters.Add(VerifiedCarID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys businessObjectKey, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter VerifiedCarID_int = new SqlParameter();
                VerifiedCarID_int.ParameterName = "@VerifiedCarID_int";
                VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                VerifiedCarID_int.Direction = ParameterDirection.Input;
                VerifiedCarID_int.IsNullable = false;
                VerifiedCarID_int.Value = businessObjectKey.VerifiedCarID_int;
                this.Command.Parameters.Add(VerifiedCarID_int);



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

        public List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[VerifiedCars_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> Result = new List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T>();
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[VerifiedCars_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[VerifiedCars_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public void SelectByField(String fieldName, Object value, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[VerifiedCars_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
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
                List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> Result = new List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T>();
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_VerifiedCars_T_SelectCondition]";
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

        public void Delete(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_VerifiedCars_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter VerifiedCarID_int = new SqlParameter();
                VerifiedCarID_int.ParameterName = "@VerifiedCarID_int";
                VerifiedCarID_int.SqlDbType = SqlDbType.Int;
                VerifiedCarID_int.Direction = ParameterDirection.Input;
                VerifiedCarID_int.IsNullable = false;
                VerifiedCarID_int.Value = businessObjectKey.VerifiedCarID_int;
                this.Command.Parameters.Add(VerifiedCarID_int);


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
            this.Command.CommandText = "[sp_VerifiedCars_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.VerifiedCarID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.VerifiedCarID_int.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.CompanyID_int.ToString())) == false)
                {
                    businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.CompanyID_int.ToString()));
                }
                else
                {
                    businessObject.CompanyID_int = null;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.NumberPlate_nvc.ToString())) == false)
                {
                    businessObject.NumberPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.NumberPlate_nvc.ToString()));
                }
                else
                {
                    businessObject.NumberPlate_nvc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.SerialPlate_nvc.ToString())) == false)
                {
                    businessObject.SerialPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.SerialPlate_nvc.ToString()));
                }
                else
                {
                    businessObject.SerialPlate_nvc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.Date_vc.ToString())) == false)
                {
                    businessObject.Date_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.Date_vc.ToString()));
                }
                else
                {
                    businessObject.Date_vc = null;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.FullName_nvc.ToString())) == false)
                {
                    businessObject.FullName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.FullName_nvc.ToString()));
                }
                else
                {
                    businessObject.FullName_nvc = null;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.Unit_nvc.ToString())) == false)
                {
                    businessObject.Unit_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T.VerifiedCars_TField.Unit_nvc.ToString()));
                }
                else
                {
                    businessObject.Unit_nvc = null;
                }

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T> list = new List<HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T businessObject = new HPS.BLL.VerifiedCarsBLL.BLLVerifiedCars_T();
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