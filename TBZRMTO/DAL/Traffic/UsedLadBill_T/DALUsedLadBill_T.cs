using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.UsedLadBillDAL
{
    public class DALUsedLadBill_T : DataLayerBase
    {

        public DALUsedLadBill_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UsedLadBillID_int = new SqlParameter();
                UsedLadBillID_int.ParameterName = "@UsedLadBillID_int";
                UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                UsedLadBillID_int.Direction = ParameterDirection.Output;
                UsedLadBillID_int.IsNullable = false;
                UsedLadBillID_int.Value = businessObject.UsedLadBillID_int;
                this.Command.Parameters.Add(UsedLadBillID_int);

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObject.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObject.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);

                SqlParameter Serial_nvc = new SqlParameter();
                Serial_nvc.ParameterName = "@Serial_nvc";
                Serial_nvc.SqlDbType = SqlDbType.NVarChar;
                Serial_nvc.Direction = ParameterDirection.Input;
                Serial_nvc.IsNullable = false;
                Serial_nvc.Value = businessObject.Serial_nvc;
                this.Command.Parameters.Add(Serial_nvc);

                SqlParameter LadBillNumber_int = new SqlParameter();
                LadBillNumber_int.ParameterName = "@LadBillNumber_int";
                LadBillNumber_int.SqlDbType = SqlDbType.Int;
                LadBillNumber_int.Direction = ParameterDirection.Input;
                LadBillNumber_int.IsNullable = false;
                LadBillNumber_int.Value = businessObject.LadBillNumber_int;
                this.Command.Parameters.Add(LadBillNumber_int);

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

                businessObject.UsedLadBillID_int = (Int32)(this.Command.Parameters["@UsedLadBillID_int"].Value);

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

        public void Update(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T businessObject, HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_Update]";
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

                SqlParameter CompanyLadBillID_bint = new SqlParameter();
                CompanyLadBillID_bint.ParameterName = "@CompanyLadBillID_bint";
                CompanyLadBillID_bint.SqlDbType = SqlDbType.BigInt;
                CompanyLadBillID_bint.Direction = ParameterDirection.Input;
                CompanyLadBillID_bint.IsNullable = false;
                CompanyLadBillID_bint.Value = businessObject.CompanyLadBillID_bint;
                this.Command.Parameters.Add(CompanyLadBillID_bint);

                SqlParameter Serial_nvc = new SqlParameter();
                Serial_nvc.ParameterName = "@Serial_nvc";
                Serial_nvc.SqlDbType = SqlDbType.NVarChar;
                Serial_nvc.Direction = ParameterDirection.Input;
                Serial_nvc.IsNullable = false;
                Serial_nvc.Value = businessObject.Serial_nvc;
                this.Command.Parameters.Add(Serial_nvc);

                SqlParameter LadBillNumber_int = new SqlParameter();
                LadBillNumber_int.ParameterName = "@LadBillNumber_int";
                LadBillNumber_int.SqlDbType = SqlDbType.Int;
                LadBillNumber_int.Direction = ParameterDirection.Input;
                LadBillNumber_int.IsNullable = false;
                LadBillNumber_int.Value = businessObject.LadBillNumber_int;
                this.Command.Parameters.Add(LadBillNumber_int);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

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


                SqlParameter pk_UsedLadBillID_int = new SqlParameter();
                pk_UsedLadBillID_int.ParameterName = "@pk_UsedLadBillID_int";
                pk_UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                pk_UsedLadBillID_int.Direction = ParameterDirection.Input;
                pk_UsedLadBillID_int.IsNullable = false;
                pk_UsedLadBillID_int.Value = businessObjectKey.UsedLadBillID_int;
                this.Command.Parameters.Add(pk_UsedLadBillID_int);



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

        public List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> Result = new List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T>();
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectAll]";
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectAll]";
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectAll]";
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

        public HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T SelectByPrimaryKey(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UsedLadBillID_int = new SqlParameter();
                UsedLadBillID_int.ParameterName = "@UsedLadBillID_int";
                UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                UsedLadBillID_int.Direction = ParameterDirection.Input;
                UsedLadBillID_int.IsNullable = false;
                UsedLadBillID_int.Value = businessObjectKey.UsedLadBillID_int;
                this.Command.Parameters.Add(UsedLadBillID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T businessObject = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T();
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

        public void SelectByPrimaryKey(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UsedLadBillID_int = new SqlParameter();
                UsedLadBillID_int.ParameterName = "@UsedLadBillID_int";
                UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                UsedLadBillID_int.Direction = ParameterDirection.Input;
                UsedLadBillID_int.IsNullable = false;
                UsedLadBillID_int.Value = businessObjectKey.UsedLadBillID_int;
                this.Command.Parameters.Add(UsedLadBillID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UsedLadBillID_int = new SqlParameter();
                UsedLadBillID_int.ParameterName = "@UsedLadBillID_int";
                UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                UsedLadBillID_int.Direction = ParameterDirection.Input;
                UsedLadBillID_int.IsNullable = false;
                UsedLadBillID_int.Value = businessObjectKey.UsedLadBillID_int;
                this.Command.Parameters.Add(UsedLadBillID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UsedLadBillID_int = new SqlParameter();
                UsedLadBillID_int.ParameterName = "@UsedLadBillID_int";
                UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                UsedLadBillID_int.Direction = ParameterDirection.Input;
                UsedLadBillID_int.IsNullable = false;
                UsedLadBillID_int.Value = businessObjectKey.UsedLadBillID_int;
                this.Command.Parameters.Add(UsedLadBillID_int);



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

        public List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[UsedLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> Result = new List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T>();
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[UsedLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[UsedLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[UsedLadBill_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
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
                List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> Result = new List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T>();
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_UsedLadBill_T_SelectCondition]";
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

        public void Delete(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_UsedLadBill_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UsedLadBillID_int = new SqlParameter();
                UsedLadBillID_int.ParameterName = "@UsedLadBillID_int";
                UsedLadBillID_int.SqlDbType = SqlDbType.Int;
                UsedLadBillID_int.Direction = ParameterDirection.Input;
                UsedLadBillID_int.IsNullable = false;
                UsedLadBillID_int.Value = businessObjectKey.UsedLadBillID_int;
                this.Command.Parameters.Add(UsedLadBillID_int);


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
            this.Command.CommandText = "[sp_UsedLadBill_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T businessObject, IDataReader dataReader)
        {
            businessObject.UsedLadBillID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.UsedLadBillID_int.ToString()));
            businessObject.LadBillCreditID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.LadBillCreditID_int.ToString()));
            businessObject.CompanyLadBillID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.CompanyLadBillID_bint.ToString()));
            businessObject.Serial_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Serial_nvc.ToString()));
            businessObject.LadBillNumber_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.LadBillNumber_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Comment_nvc.ToString())) == false)
            {
                businessObject.Comment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Comment_nvc.ToString()));
            }
            else
            {
                businessObject.Comment_nvc = String.Empty;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T.UsedLadBill_TField.UserName_nvc.ToString()));
        }

        public List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> list = new List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T>();
            while (dataReader.Read())
            {
                HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T businessObject = new HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void SelectAllUsedCreditAssignment(ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_LadeBillCredit_T]";
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

        public void SelectAllUsedCreditAssignment(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_LadeBillCredit_T]";
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

        public List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> SelectAllUsedCreditAssignment()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_LadeBillCredit_T]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T> Result = new List<HPS.BLL.UsedLadBillBLL.BLLUsedLadBill_T>();
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

        public void SelectAllUsedCreditAssignment(ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_LadeBillCredit_T]";
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

        public void SelectReport(HPS.BLL.Reports.LadBillReportBLL businessObject, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Report_UsedLadBill]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                //@ComapnyID_nvc
                SqlParameter ComapnyID_nvc = new SqlParameter();
                ComapnyID_nvc.ParameterName = "@ComapnyID_nvc";
                ComapnyID_nvc.SqlDbType = SqlDbType.NVarChar;
                ComapnyID_nvc.Direction = ParameterDirection.Input;
                ComapnyID_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CompanyID_nvc) == false)
                {
                    ComapnyID_nvc.Value = businessObject.CompanyID_nvc;
                }
                else
                {
                    ComapnyID_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(ComapnyID_nvc);

                //@DriverCardNumber_nvc
                SqlParameter DriverCardNumber_nvc = new SqlParameter();
                DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
                DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                DriverCardNumber_nvc.Direction = ParameterDirection.Input;
                DriverCardNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.DriverCardNumber_nvc) == false)
                {
                    DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
                }
                else
                {
                    DriverCardNumber_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(DriverCardNumber_nvc);

                //@CarCardNumber_nvc
                SqlParameter CarCardNumber_nvc = new SqlParameter();
                CarCardNumber_nvc.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvc.Direction = ParameterDirection.Input;
                CarCardNumber_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CarCardNumber_nvc))
                {
                    CarCardNumber_nvc.Value = DBNull.Value;
                }
                else
                {
                    CarCardNumber_nvc.Value = businessObject.CarCardNumber_nvc;
                }
                this.Command.Parameters.Add(CarCardNumber_nvc);

                //@CityID_nvc
                SqlParameter CityID_nvc = new SqlParameter();
                CityID_nvc.ParameterName = "@CityID_nvc";
                CityID_nvc.SqlDbType = SqlDbType.NVarChar;
                CityID_nvc.Direction = ParameterDirection.Input;
                CityID_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.CityID_nvc) == false)
                {
                    CityID_nvc.Value = businessObject.CityID_nvc;
                }
                else
                {
                    CityID_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(CityID_nvc);

                //@LaderTypeID_nvc

                SqlParameter LaderTypeID_nvc = new SqlParameter();
                LaderTypeID_nvc.ParameterName = "@LaderTypeID_nvc";
                LaderTypeID_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeID_nvc.Direction = ParameterDirection.Input;
                LaderTypeID_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.LaderTypeID_nvc))
                {
                    LaderTypeID_nvc.Value = businessObject.LaderTypeID_nvc;
                }
                else
                {
                    LaderTypeID_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(LaderTypeID_nvc);

                //@BoxingID_nvc
                SqlParameter BoxingID_nvc = new SqlParameter();
                BoxingID_nvc.ParameterName = "@BoxingID_nvc";
                BoxingID_nvc.SqlDbType = SqlDbType.NVarChar;
                BoxingID_nvc.Direction = ParameterDirection.Input;
                BoxingID_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.BoxingID_nvc))
                {
                    BoxingID_nvc.Value = businessObject.BoxingID_nvc;
                }
                else
                {
                    BoxingID_nvc.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(BoxingID_nvc);
                //@GoodID_nvc

                SqlParameter GoodID_nvc = new SqlParameter();
                GoodID_nvc.ParameterName = "@GoodID_nvc";
                GoodID_nvc.SqlDbType = SqlDbType.NVarChar;
                GoodID_nvc.Direction = ParameterDirection.Input;
                GoodID_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.GoodID_nvc))
                {
                    GoodID_nvc.Value = businessObject.GoodID_nvc;
                }
                else
                {
                    GoodID_nvc.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(GoodID_nvc);

                //@TrafficTypeID_nvc

                SqlParameter TrafficTypeID_nvc = new SqlParameter();
                TrafficTypeID_nvc.ParameterName = "@TrafficTypeID_nvc";
                TrafficTypeID_nvc.SqlDbType = SqlDbType.NVarChar;
                TrafficTypeID_nvc.Direction = ParameterDirection.Input;
                TrafficTypeID_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.TrafficTypeID_nvc))
                {
                    TrafficTypeID_nvc.Value = businessObject.TrafficTypeID_nvc;
                }
                else
                {
                    TrafficTypeID_nvc.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(TrafficTypeID_nvc);

                //@AnnouncementTimeID_nvc
                SqlParameter AnnouncementTimeID_nvc = new SqlParameter();
                AnnouncementTimeID_nvc.ParameterName = "@AnnouncementTimeID_nvc";
                AnnouncementTimeID_nvc.SqlDbType = SqlDbType.NVarChar;
                AnnouncementTimeID_nvc.Direction = ParameterDirection.Input;
                AnnouncementTimeID_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.AnnouncementTimeID_nvc))
                {
                    AnnouncementTimeID_nvc.Value = businessObject.AnnouncementTimeID_nvc;
                }
                else
                {
                    AnnouncementTimeID_nvc.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(AnnouncementTimeID_nvc);

                //@LadBillSerialFrom_nvc

                SqlParameter LadBillSerialFrom_nvc = new SqlParameter();
                LadBillSerialFrom_nvc.ParameterName = "@LadBillSerialFrom_nvc";
                LadBillSerialFrom_nvc.SqlDbType = SqlDbType.NVarChar;
                LadBillSerialFrom_nvc.Direction = ParameterDirection.Input;
                LadBillSerialFrom_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FromSerial_nvc))
                {
                    LadBillSerialFrom_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadBillSerialFrom_nvc.Value = businessObject.FromSerial_nvc;
                }

                this.Command.Parameters.Add(LadBillSerialFrom_nvc);

                //@LadBillSerialTo_nvc

                SqlParameter LadBillSerialTo_nvc = new SqlParameter();
                LadBillSerialTo_nvc.ParameterName = "@LadBillSerialTo_nvc";
                LadBillSerialTo_nvc.SqlDbType = SqlDbType.NVarChar;
                LadBillSerialTo_nvc.Direction = ParameterDirection.Input;
                LadBillSerialTo_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.ToSerial_nvc))
                {
                    LadBillSerialTo_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadBillSerialTo_nvc.Value = businessObject.ToSerial_nvc;
                }

                this.Command.Parameters.Add(LadBillSerialTo_nvc);


                //@LadBillNumberFrom_int
                SqlParameter LadBillNumberFrom_int = new SqlParameter();
                LadBillNumberFrom_int.ParameterName = "@LadBillNumberFrom_int";
                LadBillNumberFrom_int.SqlDbType = SqlDbType.Int;
                LadBillNumberFrom_int.Direction = ParameterDirection.Input;
                LadBillNumberFrom_int.IsNullable = true;
                if (businessObject.FromLadBillNumber_int.HasValue)
                {
                    LadBillNumberFrom_int.Value = businessObject.FromLadBillNumber_int;
                }
                else
                {
                    LadBillNumberFrom_int.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(LadBillNumberFrom_int);

                //@LadBillNumberTo_int
                SqlParameter LadBillNumberTo_int = new SqlParameter();
                LadBillNumberTo_int.ParameterName = "@LadBillNumberTo_int";
                LadBillNumberTo_int.SqlDbType = SqlDbType.Int;
                LadBillNumberTo_int.Direction = ParameterDirection.Input;
                LadBillNumberTo_int.IsNullable = true;
                if (businessObject.ToLadBillNumber_int.HasValue)
                {
                    LadBillNumberTo_int.Value = businessObject.ToLadBillNumber_int;
                }
                else
                {
                    LadBillNumberTo_int.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(LadBillNumberTo_int);

                //@PortPlaceID_nvc
                SqlParameter PortPlaceID_nvc = new SqlParameter();
                PortPlaceID_nvc.ParameterName = "@PortPlaceID_nvc";
                PortPlaceID_nvc.SqlDbType = SqlDbType.NVarChar;
                PortPlaceID_nvc.Direction = ParameterDirection.Input;
                PortPlaceID_nvc.IsNullable = true;
                if (!string.IsNullOrEmpty(businessObject.PortPlaceID_nvc))
                {
                    PortPlaceID_nvc.Value = businessObject.PortPlaceID_nvc;
                }
                else
                {
                    PortPlaceID_nvc.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(PortPlaceID_nvc);


                //@LadingDateFrom_nvc
                SqlParameter LadingDateFrom_nvc = new SqlParameter();
                LadingDateFrom_nvc.ParameterName = "@LadingDateFrom_nvc";
                LadingDateFrom_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingDateFrom_nvc.Direction = ParameterDirection.Input;
                LadingDateFrom_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FromLadingDate_nvc))
                {
                    LadingDateFrom_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadingDateFrom_nvc.Value = businessObject.FromLadingDate_nvc;
                }

                this.Command.Parameters.Add(LadingDateFrom_nvc);

                //@LadingDateTo_nvc
                SqlParameter LadingDateTo_nvc = new SqlParameter();
                LadingDateTo_nvc.ParameterName = "@LadingDateTo_nvc";
                LadingDateTo_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingDateTo_nvc.Direction = ParameterDirection.Input;
                LadingDateTo_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.ToLadingDate_nvc))
                {
                    LadingDateTo_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadingDateTo_nvc.Value = businessObject.ToLadingDate_nvc;
                }

                this.Command.Parameters.Add(LadingDateTo_nvc);

                //@LadingTimeFrom_nvc
                SqlParameter LadingTimeFrom_nvc = new SqlParameter();
                LadingTimeFrom_nvc.ParameterName = "@LadingTimeFrom_nvc";
                LadingTimeFrom_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingTimeFrom_nvc.Direction = ParameterDirection.Input;
                LadingTimeFrom_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FromLadingTime_nvc))
                {
                    LadingTimeFrom_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadingTimeFrom_nvc.Value = businessObject.FromLadingTime_nvc;
                }

                this.Command.Parameters.Add(LadingTimeFrom_nvc);

                //@LadingTimeTo_nvc
                SqlParameter LadingTimeTo_nvc = new SqlParameter();
                LadingTimeTo_nvc.ParameterName = "@LadingTimeTo_nvc";
                LadingTimeTo_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingTimeTo_nvc.Direction = ParameterDirection.Input;
                LadingTimeTo_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.ToLadingTime_nvc))
                {
                    LadingTimeTo_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadingTimeTo_nvc.Value = businessObject.ToLadingTime_nvc;
                }

                this.Command.Parameters.Add(LadingTimeTo_nvc);


                //@LadBillDateFrom_nvc
                SqlParameter LadBillDateFrom_nvc = new SqlParameter();
                LadBillDateFrom_nvc.ParameterName = "@LadBillDateFrom_nvc";
                LadBillDateFrom_nvc.SqlDbType = SqlDbType.NVarChar;
                LadBillDateFrom_nvc.Direction = ParameterDirection.Input;
                LadBillDateFrom_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FromLadBillDate_nvc))
                {
                    LadBillDateFrom_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadBillDateFrom_nvc.Value = businessObject.FromLadBillDate_nvc;
                }

                this.Command.Parameters.Add(LadBillDateFrom_nvc);

                //@LadBillDateTo_nvc
                SqlParameter LadBillDateTo_nvc = new SqlParameter();
                LadBillDateTo_nvc.ParameterName = "@LadBillDateTo_nvc";
                LadBillDateTo_nvc.SqlDbType = SqlDbType.NVarChar;
                LadBillDateTo_nvc.Direction = ParameterDirection.Input;
                LadBillDateTo_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.ToLadBillDate_nvc))
                {
                    LadBillDateTo_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadBillDateTo_nvc.Value = businessObject.ToLadBillDate_nvc;
                }
                this.Command.Parameters.Add(LadBillDateTo_nvc);

                //@LadBillTimeFrom_nvc
                SqlParameter LadBillTimeFrom_nvc = new SqlParameter();
                LadBillTimeFrom_nvc.ParameterName = "@LadBillTimeFrom_nvc";
                LadBillTimeFrom_nvc.SqlDbType = SqlDbType.NVarChar;
                LadBillTimeFrom_nvc.Direction = ParameterDirection.Input;
                LadBillTimeFrom_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.FromLadBillTime_nvc))
                {
                    LadBillTimeFrom_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadBillTimeFrom_nvc.Value = businessObject.FromLadBillTime_nvc;
                }

                this.Command.Parameters.Add(LadBillTimeFrom_nvc);

                //@LadBillTimeTo_nvc
                SqlParameter LadBillTimeTo_nvc = new SqlParameter();
                LadBillTimeTo_nvc.ParameterName = "@LadBillTimeTo_nvc";
                LadBillTimeTo_nvc.SqlDbType = SqlDbType.NVarChar;
                LadBillTimeTo_nvc.Direction = ParameterDirection.Input;
                LadBillTimeTo_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.ToLadBillTime_nvc))
                {
                    LadBillTimeTo_nvc.Value = DBNull.Value;
                }
                else
                {
                    LadBillTimeTo_nvc.Value = businessObject.ToLadBillTime_nvc;
                }

                this.Command.Parameters.Add(LadBillTimeTo_nvc);




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

        public void SelectCountByCondition(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_UsedLadBillCount]";
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