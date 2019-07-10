using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CompanyLadBillDAL
{
    class DALCompanyLadBill_T : DataLayerBase
    {

        public DALCompanyLadBill_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Output;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObject.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObject.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter CompanyCode_nvc = new SqlParameter();
                CompanyCode_nvc.ParameterName = "@CompanyCode_nvc";
                CompanyCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyCode_nvc.Direction = ParameterDirection.Input;
                CompanyCode_nvc.IsNullable = false;
                CompanyCode_nvc.Value = businessObject.CompanyCode_nvc;
                this.Command.Parameters.Add(CompanyCode_nvc);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Date_nvc))
                {
                    Date_nvc.Value = DBNull.Value;
                }
                else
                {
                    Date_nvc.Value = businessObject.Date_nvc;
                }
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Serial_nvc = new SqlParameter();
                Serial_nvc.ParameterName = "@Serial_nvc";
                Serial_nvc.SqlDbType = SqlDbType.NVarChar;
                Serial_nvc.Direction = ParameterDirection.Input;
                Serial_nvc.IsNullable = false;
                Serial_nvc.Value = businessObject.Serial_nvc;
                this.Command.Parameters.Add(Serial_nvc);

                SqlParameter StartNumber_int = new SqlParameter();
                StartNumber_int.ParameterName = "@StartNumber_int";
                StartNumber_int.SqlDbType = SqlDbType.Int;
                StartNumber_int.Direction = ParameterDirection.Input;
                StartNumber_int.IsNullable = false;
                StartNumber_int.Value = businessObject.StartNumber_int;
                this.Command.Parameters.Add(StartNumber_int);

                SqlParameter EndNumber_int = new SqlParameter();
                EndNumber_int.ParameterName = "@EndNumber_int";
                EndNumber_int.SqlDbType = SqlDbType.Int;
                EndNumber_int.Direction = ParameterDirection.Input;
                EndNumber_int.IsNullable = false;
                EndNumber_int.Value = businessObject.EndNumber_int;
                this.Command.Parameters.Add(EndNumber_int);

                SqlParameter AssignmentNumber_nvc = new SqlParameter();
                AssignmentNumber_nvc.ParameterName = "@AssignmentNumber_nvc";
                AssignmentNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                AssignmentNumber_nvc.Direction = ParameterDirection.Input;
                AssignmentNumber_nvc.IsNullable = false;
                AssignmentNumber_nvc.Value = businessObject.AssignmentNumber_nvc;
                this.Command.Parameters.Add(AssignmentNumber_nvc);

                SqlParameter DeliveryUserCode_nvc = new SqlParameter();
                DeliveryUserCode_nvc.ParameterName = "@DeliveryUserCode_nvc";
                DeliveryUserCode_nvc.SqlDbType = SqlDbType.NVarChar;
                DeliveryUserCode_nvc.Direction = ParameterDirection.Input;
                DeliveryUserCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DeliveryUserCode_nvc))
                {
                    DeliveryUserCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    DeliveryUserCode_nvc.Value = businessObject.DeliveryUserCode_nvc;
                }
                this.Command.Parameters.Add(DeliveryUserCode_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.CompanyLadBillID_bint = (Int64)(this.Command.Parameters["@CompanyLadBillID_bint"].Value);

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

        public void Update(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T businessObject, HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_Update]";
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

                SqlParameter CompanyCode_nvc = new SqlParameter();
                CompanyCode_nvc.ParameterName = "@CompanyCode_nvc";
                CompanyCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyCode_nvc.Direction = ParameterDirection.Input;
                CompanyCode_nvc.IsNullable = false;
                CompanyCode_nvc.Value = businessObject.CompanyCode_nvc;
                this.Command.Parameters.Add(CompanyCode_nvc);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.Date_nvc))
                {
                    Date_nvc.Value = DBNull.Value;
                }
                else
                {
                    Date_nvc.Value = businessObject.Date_nvc;
                }
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Serial_nvc = new SqlParameter();
                Serial_nvc.ParameterName = "@Serial_nvc";
                Serial_nvc.SqlDbType = SqlDbType.NVarChar;
                Serial_nvc.Direction = ParameterDirection.Input;
                Serial_nvc.IsNullable = true;
                Serial_nvc.Value = businessObject.Serial_nvc;
                this.Command.Parameters.Add(Serial_nvc);

                SqlParameter StartNumber_int = new SqlParameter();
                StartNumber_int.ParameterName = "@StartNumber_int";
                StartNumber_int.SqlDbType = SqlDbType.Int;
                StartNumber_int.Direction = ParameterDirection.Input;
                StartNumber_int.IsNullable = false;
                StartNumber_int.Value = businessObject.StartNumber_int;
                this.Command.Parameters.Add(StartNumber_int);

                SqlParameter EndNumber_int = new SqlParameter();
                EndNumber_int.ParameterName = "@EndNumber_int";
                EndNumber_int.SqlDbType = SqlDbType.Int;
                EndNumber_int.Direction = ParameterDirection.Input;
                EndNumber_int.IsNullable = false;
                EndNumber_int.Value = businessObject.EndNumber_int;
                this.Command.Parameters.Add(EndNumber_int);

                SqlParameter AssignmentNumber_nvc = new SqlParameter();
                AssignmentNumber_nvc.ParameterName = "@AssignmentNumber_nvc";
                AssignmentNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                AssignmentNumber_nvc.Direction = ParameterDirection.Input;
                AssignmentNumber_nvc.IsNullable = false;
                AssignmentNumber_nvc.Value = businessObject.AssignmentNumber_nvc;
                this.Command.Parameters.Add(AssignmentNumber_nvc);

                SqlParameter DeliveryUserCode_nvc = new SqlParameter();
                DeliveryUserCode_nvc.ParameterName = "@DeliveryUserCode_nvc";
                DeliveryUserCode_nvc.SqlDbType = SqlDbType.NVarChar;
                DeliveryUserCode_nvc.Direction = ParameterDirection.Input;
                DeliveryUserCode_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.DeliveryUserCode_nvc))
                {
                    DeliveryUserCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    DeliveryUserCode_nvc.Value = businessObject.DeliveryUserCode_nvc;
                }
                this.Command.Parameters.Add(DeliveryUserCode_nvc);


                SqlParameter pk_CompanyLadBillID_bint = new SqlParameter();
                pk_CompanyLadBillID_bint.ParameterName = "@pk_CompanyLadBillID_bint";
                pk_CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                pk_CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                pk_CompanyLadBillID_bint.IsNullable = false;
                pk_CompanyLadBillID_bint.Value = businessObjectKey.CompanyLadBillID_bint;
                this.Command.Parameters.Add(pk_CompanyLadBillID_bint);



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

        public List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> Result = new List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T>();
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectAll]";
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectAll]";
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

        public HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T SelectByPrimaryKey(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObjectKey.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T businessObject = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T();
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

        public void SelectByPrimaryKey(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObjectKey.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObjectKey.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObjectKey.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);



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

        public List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> Result = new List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T>();
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[CompanyLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
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
                List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> Result = new List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T>();
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectCondition]";
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

        public void Delete(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_CompanyLadBill_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObjectKey.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);


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
            this.Command.CommandText = "[sp_CompanyLadBill_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T businessObject, IDataReader dataReader)
        {
            businessObject.CompanyLadBillID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyLadBillID_bint.ToString()));
            businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyID_int.ToString()));
            businessObject.CompanyCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.CompanyCode_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Date_nvc.ToString())) == false)
            {
                businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Date_nvc.ToString()));
            }
            else
            {
                businessObject.Date_nvc = String.Empty;
            }

            businessObject.Serial_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.Serial_nvc.ToString()));
            businessObject.StartNumber_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.StartNumber_int.ToString()));
            businessObject.EndNumber_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.EndNumber_int.ToString()));
            businessObject.AssignmentNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.AssignmentNumber_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.DeliveryUserCode_nvc.ToString())) == false)
            {
                businessObject.DeliveryUserCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T.CompanyLadBill_TField.DeliveryUserCode_nvc.ToString()));
            }
            else
            {
                businessObject.DeliveryUserCode_nvc = String.Empty;
            }

        }

        public List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T> list = new List<HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T>();
            while (dataReader.Read())
            {
                HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T businessObject = new HPS.BLL.CompanyLadBillBLL.BLLCompanyLadBill_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void SelectInExportFormat(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectInExportFormat]";
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

        public void SelectAllWithCompanyUser(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_CompanyLadBill_T_SelectAllByCompanyUser]";
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
    }
}