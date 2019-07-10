using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadBillCreditDAL
{
    class DALLadBillCredit_T : DataLayerBase
    {

        public DALLadBillCredit_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Output;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObject.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

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

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter Printed_bit = new SqlParameter();
                Printed_bit.ParameterName = "@Printed_bit";
                Printed_bit.SqlDbType = SqlDbType.Bit;
                Printed_bit.Direction = ParameterDirection.Input;
                Printed_bit.IsNullable = false;
                Printed_bit.Value = businessObject.Printed_bit;
                this.Command.Parameters.Add(Printed_bit);

                SqlParameter Canceled_bit = new SqlParameter();
                Canceled_bit.ParameterName = "@Canceled_bit";
                Canceled_bit.SqlDbType = SqlDbType.Bit;
                Canceled_bit.Direction = ParameterDirection.Input;
                Canceled_bit.IsNullable = false;
                Canceled_bit.Value = businessObject.Canceled_bit;
                this.Command.Parameters.Add(Canceled_bit);

                SqlParameter CanceledDate_nvc = new SqlParameter();
                CanceledDate_nvc.ParameterName = "@CanceledDate_nvc";
                CanceledDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledDate_nvc.Direction = ParameterDirection.Input;
                CanceledDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledDate_nvc))
                {
                    CanceledDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledDate_nvc.Value = businessObject.CanceledDate_nvc;
                }
                this.Command.Parameters.Add(CanceledDate_nvc);

                SqlParameter CanceledTime_nvc = new SqlParameter();
                CanceledTime_nvc.ParameterName = "@CanceledTime_nvc";
                CanceledTime_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledTime_nvc.Direction = ParameterDirection.Input;
                CanceledTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledTime_nvc))
                {
                    CanceledTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledTime_nvc.Value = businessObject.CanceledTime_nvc;
                }
                this.Command.Parameters.Add(CanceledTime_nvc);

                SqlParameter CanceledUserName_nvc = new SqlParameter();
                CanceledUserName_nvc.ParameterName = "@CanceledUserName_nvc";
                CanceledUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledUserName_nvc.Direction = ParameterDirection.Input;
                CanceledUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledUserName_nvc))
                {
                    CanceledUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledUserName_nvc.Value = businessObject.CanceledUserName_nvc;
                }
                this.Command.Parameters.Add(CanceledUserName_nvc);

                SqlParameter CanceledComment_nvc = new SqlParameter();
                CanceledComment_nvc.ParameterName = "@CanceledComment_nvc";
                CanceledComment_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledComment_nvc.Direction = ParameterDirection.Input;
                CanceledComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledComment_nvc))
                {
                    CanceledComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledComment_nvc.Value = businessObject.CanceledComment_nvc;
                }
                this.Command.Parameters.Add(CanceledComment_nvc);

                SqlParameter Turn_bit = new SqlParameter();
                Turn_bit.ParameterName = "@Turn_bit";
                Turn_bit.SqlDbType = SqlDbType.Bit;
                Turn_bit.Direction = ParameterDirection.Input;
                Turn_bit.IsNullable = true;
                if (businessObject.Turn_bit.HasValue==false)
                {
                    Turn_bit.Value = DBNull.Value;
                }
                else
                {
                    Turn_bit.Value = businessObject.Turn_bit;
                }
                
                this.Command.Parameters.Add(Turn_bit);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LadBillCreditID_int = (Int32)(this.Command.Parameters["@LadBillCreditID_int"].Value);

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

        public void Update(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject, HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_Update]";
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

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = true;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter Printed_bit = new SqlParameter();
                Printed_bit.ParameterName = "@Printed_bit";
                Printed_bit.SqlDbType = SqlDbType.Bit;
                Printed_bit.Direction = ParameterDirection.Input;
                Printed_bit.IsNullable = false;
                Printed_bit.Value = businessObject.Printed_bit;
                this.Command.Parameters.Add(Printed_bit);

                SqlParameter Canceled_bit = new SqlParameter();
                Canceled_bit.ParameterName = "@Canceled_bit";
                Canceled_bit.SqlDbType = SqlDbType.Bit;
                Canceled_bit.Direction = ParameterDirection.Input;
                Canceled_bit.IsNullable = false;
                Canceled_bit.Value = businessObject.Canceled_bit;
                this.Command.Parameters.Add(Canceled_bit);

                SqlParameter CanceledDate_nvc = new SqlParameter();
                CanceledDate_nvc.ParameterName = "@CanceledDate_nvc";
                CanceledDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledDate_nvc.Direction = ParameterDirection.Input;
                CanceledDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledDate_nvc))
                {
                    CanceledDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledDate_nvc.Value = businessObject.CanceledDate_nvc;
                }
                this.Command.Parameters.Add(CanceledDate_nvc);

                SqlParameter CanceledTime_nvc = new SqlParameter();
                CanceledTime_nvc.ParameterName = "@CanceledTime_nvc";
                CanceledTime_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledTime_nvc.Direction = ParameterDirection.Input;
                CanceledTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledTime_nvc))
                {
                    CanceledTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledTime_nvc.Value = businessObject.CanceledTime_nvc;
                }
                this.Command.Parameters.Add(CanceledTime_nvc);

                SqlParameter CanceledUserName_nvc = new SqlParameter();
                CanceledUserName_nvc.ParameterName = "@CanceledUserName_nvc";
                CanceledUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledUserName_nvc.Direction = ParameterDirection.Input;
                CanceledUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledUserName_nvc))
                {
                    CanceledUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledUserName_nvc.Value = businessObject.CanceledUserName_nvc;
                }
                this.Command.Parameters.Add(CanceledUserName_nvc);

                SqlParameter CanceledComment_nvc = new SqlParameter();
                CanceledComment_nvc.ParameterName = "@CanceledComment_nvc";
                CanceledComment_nvc.SqlDbType = SqlDbType.NVarChar;
                CanceledComment_nvc.Direction = ParameterDirection.Input;
                CanceledComment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CanceledComment_nvc))
                {
                    CanceledComment_nvc.Value = DBNull.Value;
                }
                else
                {
                    CanceledComment_nvc.Value = businessObject.CanceledComment_nvc;
                }
                this.Command.Parameters.Add(CanceledComment_nvc);

                SqlParameter Turn_bit = new SqlParameter();
                Turn_bit.ParameterName = "@Turn_bit";
                Turn_bit.SqlDbType = SqlDbType.Bit;
                Turn_bit.Direction = ParameterDirection.Input;
                Turn_bit.IsNullable = true;
                if (businessObject.Turn_bit.HasValue==false)
                {
                    Turn_bit.Value = DBNull.Value;
                }
                else
                {
                    Turn_bit.Value = businessObject.Turn_bit;
                }

                this.Command.Parameters.Add(Turn_bit);


                SqlParameter pk_LadBillCreditID_int = new SqlParameter();
                pk_LadBillCreditID_int.ParameterName = "@pk_LadBillCreditID_int";
                pk_LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                pk_LadBillCreditID_int.Direction = ParameterDirection.Input;
                pk_LadBillCreditID_int.IsNullable = false;
                pk_LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(pk_LadBillCreditID_int);



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

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> Result = new List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T>();
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAll]";
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

        public HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T SelectByPrimaryKey(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);



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

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCredit_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> Result = new List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T>();
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCredit_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCredit_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadBillCredit_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
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
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> Result = new List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T>();
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadBillCredit_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);


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
            this.Command.CommandText = "[sp_LadBillCredit_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject, IDataReader dataReader)
        {
            businessObject.LadBillCreditID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.LadBillCreditID_int.ToString()));
            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.UserName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Comment_nvc.ToString())) == false)
            {
                businessObject.Comment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Comment_nvc.ToString()));
            }
            else
            {
                businessObject.Comment_nvc = String.Empty;
            }

            businessObject.LadeAssignmentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.LadeAssignmentID_bint.ToString()));
            businessObject.TrafficID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.TrafficID_bint.ToString()));
            businessObject.Printed_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Printed_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Canceled_bit.ToString())) == false)
            {
                businessObject.Canceled_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Canceled_bit.ToString()));
            }
            else
            {
                businessObject.Canceled_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledDate_nvc.ToString())) == false)
            {
                businessObject.CanceledDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledDate_nvc.ToString()));
            }
            else
            {
                businessObject.CanceledDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledTime_nvc.ToString())) == false)
            {
                businessObject.CanceledTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledTime_nvc.ToString()));
            }
            else
            {
                businessObject.CanceledTime_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledUserName_nvc.ToString())) == false)
            {
                businessObject.CanceledUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledUserName_nvc.ToString()));
            }
            else
            {
                businessObject.CanceledUserName_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledComment_nvc.ToString())) == false)
            {
                businessObject.CanceledComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.CanceledComment_nvc.ToString()));
            }
            else
            {
                businessObject.CanceledComment_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Turn_bit.ToString())) == false)
            {
                businessObject.Turn_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.Turn_bit.ToString()));
            }
            else
            {
                businessObject.Turn_bit = null;
            }

        }

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> list = new List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        ////LaterAdded
        public void SelectAllLadeAssignment(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAllLadeAssignmentTraffic]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadBillCreditID_int = new SqlParameter();
                LadBillCreditID_int.ParameterName = "@LadBillCreditID_int";
                LadBillCreditID_int.SqlDbType = SqlDbType.Int;
                LadBillCreditID_int.Direction = ParameterDirection.Input;
                LadBillCreditID_int.IsNullable = false;
                LadBillCreditID_int.Value = businessObjectKey.LadBillCreditID_int;
                this.Command.Parameters.Add(LadBillCreditID_int);

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
     
        public void SelectAllWithTrafficLadBillCredit(ref System.Data.DataTable dataTable, string Date)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAllwithTraffic]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();
                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Date))
                {
                    Date_nvc.Value = DBNull.Value;
                }
                else
                {
                    Date_nvc.Value = Date;
                }
                this.Command.Parameters.Add(@Date_nvc);

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

        public void SelectAllWithTrafficLadBillCreditByConditon(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectAllwithTrafficByCondition]";
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
        
        public void SelectActives(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectActives]";
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

        public void GetLastStatusForCancelLadBillCredit(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Traffic_T_GetLastStatusForCancelLadBillCredit]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                CarCardNumber_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(CarCardNumber_nvc))
                    CarCardNumber_nvcParam.Value = DBNull.Value;
                else
                    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                this.Command.Parameters.Add(CarCardNumber_nvcParam);

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

        public void GetLadBillCreditTrafficStatus(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)// string CarCardNumber_nvc,
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_TrafficStatus]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NumberPlate_nvcParam = new SqlParameter();
                NumberPlate_nvcParam.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvcParam.Direction = ParameterDirection.Input;
                NumberPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvcParam.IsNullable = false;
                NumberPlate_nvcParam.Value = NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvcParam);

                SqlParameter SerialPlate_nvcParam = new SqlParameter();
                SerialPlate_nvcParam.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvcParam.Direction = ParameterDirection.Input;
                SerialPlate_nvcParam.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvcParam.IsNullable = false;
                SerialPlate_nvcParam.Value = SerialPlate_nvc;
                this.Command.Parameters.Add(SerialPlate_nvcParam);

                //SqlParameter CarCardNumber_nvcParam = new SqlParameter();
                //CarCardNumber_nvcParam.ParameterName = "@CarCardNumber_nvc";
                //CarCardNumber_nvcParam.Direction = ParameterDirection.Input;
                //CarCardNumber_nvcParam.SqlDbType = SqlDbType.NVarChar;
                //CarCardNumber_nvcParam.IsNullable = true;
                //if (string.IsNullOrEmpty(CarCardNumber_nvc))
                //    CarCardNumber_nvcParam.Value = DBNull.Value;
                //else
                //    CarCardNumber_nvcParam.Value = CarCardNumber_nvc;
                //this.Command.Parameters.Add(CarCardNumber_nvcParam);

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

        public void SelectLadBillCreditByLaderType(String Date_nvc, ref DataTable DataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp-SelectLadBillCreditByLaderType]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Date_nvcParam = new SqlParameter();
                Date_nvcParam.ParameterName = "@Date_nvc";
                Date_nvcParam.Direction = ParameterDirection.Input;
                Date_nvcParam.SqlDbType = SqlDbType.NVarChar;
                Date_nvcParam.IsNullable = false;
                Date_nvcParam.Value = Date_nvc;
                this.Command.Parameters.Add(Date_nvcParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(DataTable);

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

        public void SelectLadBillCreditOrderColumn( System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectReportOrderColumns]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
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

        public void SelectCompanyRemainedLadBillReportOrderColumns(System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_T_SelectCompanyRemainedLadBillReportOrderColumns]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
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