using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.BillMessageDAL
{
    class DALBillMessage_T : DataLayerBase
    {

        public DALBillMessage_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.BillMessageBLL.BLLBillMessage_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Output;
                BillMessageID_int.IsNullable = false;
                BillMessageID_int.Value = businessObject.BillMessageID_int;
                this.Command.Parameters.Add(BillMessageID_int);

                SqlParameter BillID_int = new SqlParameter();
                BillID_int.ParameterName = "@BillID_int";
                BillID_int.SqlDbType = SqlDbType.Int;
                BillID_int.Direction = ParameterDirection.Input;
                BillID_int.IsNullable = true;
                if (businessObject.BillID_int.HasValue)
                {
                    BillID_int.Value = businessObject.BillID_int;
                }
                else
                {
                    BillID_int.Value = DBNull.Value;
                }
              
                this.Command.Parameters.Add(BillID_int);

                SqlParameter Message_nvc = new SqlParameter();
                Message_nvc.ParameterName = "@Message_nvc";
                Message_nvc.SqlDbType = SqlDbType.NVarChar;
                Message_nvc.Direction = ParameterDirection.Input;
                Message_nvc.IsNullable = false;
                Message_nvc.Value = businessObject.Message_nvc;
                this.Command.Parameters.Add(Message_nvc);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = false;
                StartDate_nvc.Value = businessObject.StartDate_nvc;
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = false;
                EndDate_nvc.Value = businessObject.EndDate_nvc;
                this.Command.Parameters.Add(EndDate_nvc);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter SaloonID_intParam = new SqlParameter();
                SaloonID_intParam.ParameterName = "@SaloonID_int";
                SaloonID_intParam.SqlDbType = SqlDbType.Int;
                SaloonID_intParam.Direction = ParameterDirection.Input;
                SaloonID_intParam.IsNullable = true;
                if (businessObject.SaloonID_int.HasValue)
                {
                    SaloonID_intParam.Value = businessObject.SaloonID_int;
                }
                else
                {
                    SaloonID_intParam.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(SaloonID_intParam);

                SqlParameter ShowInLadeAssignmentRepetation_bitParam = new SqlParameter();
                ShowInLadeAssignmentRepetation_bitParam.ParameterName = "@ShowInLadeAssignmentRepetation_bit";
                ShowInLadeAssignmentRepetation_bitParam.SqlDbType = SqlDbType.Bit;
                ShowInLadeAssignmentRepetation_bitParam.Direction = ParameterDirection.Input;
                ShowInLadeAssignmentRepetation_bitParam.IsNullable = false;
                ShowInLadeAssignmentRepetation_bitParam.Value = businessObject.ShowInLadeAssignmentRepetation_bit;
                this.Command.Parameters.Add(ShowInLadeAssignmentRepetation_bitParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.BillMessageID_int = (Int32?)(this.Command.Parameters["@BillMessageID_int"].Value);

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

        public void Update(HPS.BLL.BillMessageBLL.BLLBillMessage_T businessObject, HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillID_int = new SqlParameter();
                BillID_int.ParameterName = "@BillID_int";
                BillID_int.SqlDbType = SqlDbType.Int;
                BillID_int.Direction = ParameterDirection.Input;
                BillID_int.IsNullable = true;
                if (businessObject.BillID_int.HasValue)
                {
                    BillID_int.Value = businessObject.BillID_int;
                }
                else
                {
                    BillID_int.Value = DBNull.Value;
                }
                this.Command.Parameters.Add(BillID_int);
                SqlParameter Message_nvc = new SqlParameter();
                Message_nvc.ParameterName = "@Message_nvc";
                Message_nvc.SqlDbType = SqlDbType.NVarChar;
                Message_nvc.Direction = ParameterDirection.Input;
                Message_nvc.IsNullable = false;
                Message_nvc.Value = businessObject.Message_nvc;
                this.Command.Parameters.Add(Message_nvc);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = false;
                StartDate_nvc.Value = businessObject.StartDate_nvc;
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = false;
                EndDate_nvc.Value = businessObject.EndDate_nvc;
                this.Command.Parameters.Add(EndDate_nvc);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter SaloonID_intParam = new SqlParameter();
                SaloonID_intParam.ParameterName = "@SaloonID_int";
                SaloonID_intParam.SqlDbType = SqlDbType.Int;
                SaloonID_intParam.Direction = ParameterDirection.Input;
                SaloonID_intParam.IsNullable = true;
                if (businessObject.SaloonID_int.HasValue)
                {
                    SaloonID_intParam.Value = businessObject.SaloonID_int;
                }
                else
                {
                    SaloonID_intParam.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(SaloonID_intParam);

                SqlParameter ShowInLadeAssignmentRepetation_bitParam = new SqlParameter();
                ShowInLadeAssignmentRepetation_bitParam.ParameterName = "@ShowInLadeAssignmentRepetation_bit";
                ShowInLadeAssignmentRepetation_bitParam.SqlDbType = SqlDbType.Bit;
                ShowInLadeAssignmentRepetation_bitParam.Direction = ParameterDirection.Input;
                ShowInLadeAssignmentRepetation_bitParam.IsNullable = false;
                ShowInLadeAssignmentRepetation_bitParam.Value = businessObject.ShowInLadeAssignmentRepetation_bit;
                this.Command.Parameters.Add(ShowInLadeAssignmentRepetation_bitParam);

                SqlParameter pk_BillMessageID_int = new SqlParameter();
                pk_BillMessageID_int.ParameterName = "@pk_BillMessageID_int";
                pk_BillMessageID_int.SqlDbType = SqlDbType.Int;
                pk_BillMessageID_int.Direction = ParameterDirection.Input;
                pk_BillMessageID_int.IsNullable = false;
                pk_BillMessageID_int.Value = businessObjectKey.BillMessageID_int;
                this.Command.Parameters.Add(pk_BillMessageID_int);



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

        public List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> Result = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectAll]";
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectAll]";
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectAll]";
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

        public HPS.BLL.BillMessageBLL.BLLBillMessage_T SelectByPrimaryKey(HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = false;
                BillMessageID_int.Value = businessObjectKey.BillMessageID_int;
                this.Command.Parameters.Add(BillMessageID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.BillMessageBLL.BLLBillMessage_T businessObject = new HPS.BLL.BillMessageBLL.BLLBillMessage_T();
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

        public void SelectByPrimaryKey(HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_BillMessage_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = false;
                BillMessageID_int.Value = businessObjectKey.BillMessageID_int;
                this.Command.Parameters.Add(BillMessageID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_BillMessage_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = false;
                BillMessageID_int.Value = businessObjectKey.BillMessageID_int;
                this.Command.Parameters.Add(BillMessageID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_BillMessage_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = false;
                BillMessageID_int.Value = businessObjectKey.BillMessageID_int;
                this.Command.Parameters.Add(BillMessageID_int);



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





        public List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[BillMessage_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> Result = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[BillMessage_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[BillMessage_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[BillMessage_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
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
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> Result = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_BillMessage_T_SelectCondition]";
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

        public void Delete(HPS.BLL.BillMessageBLL.BLLBillMessage_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_BillMessage_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BillMessageID_int = new SqlParameter();
                BillMessageID_int.ParameterName = "@BillMessageID_int";
                BillMessageID_int.SqlDbType = SqlDbType.Int;
                BillMessageID_int.Direction = ParameterDirection.Input;
                BillMessageID_int.IsNullable = false;
                BillMessageID_int.Value = businessObjectKey.BillMessageID_int;
                this.Command.Parameters.Add(BillMessageID_int);


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
            this.Command.CommandText = "[sp_BillMessage_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.BillMessageBLL.BLLBillMessage_T businessObject, IDataReader dataReader)
        {
            businessObject.BillMessageID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillMessageID_int.ToString()));
            businessObject.ShowInLadeAssignmentRepetation_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.ShowInLadeAssignmentRepetation_bit.ToString()));
            businessObject.Message_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.Message_nvc.ToString()));
            businessObject.StartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.StartDate_nvc.ToString()));
            businessObject.EndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.EndDate_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.UserName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillID_int.ToString())) == false)
            {
                businessObject.BillID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.BillID_int.ToString()));
            }
            else
            {
                businessObject.BillID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.SaloonID_int.ToString())) == false)
            {
                businessObject.SaloonID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BillMessageBLL.BLLBillMessage_T.BillMessage_TField.SaloonID_int.ToString()));
            }
            else
            {
                businessObject.SaloonID_int = null;
            }
        }

        public List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> list = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
            while (dataReader.Read())
            {
                HPS.BLL.BillMessageBLL.BLLBillMessage_T businessObject = new HPS.BLL.BillMessageBLL.BLLBillMessage_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}