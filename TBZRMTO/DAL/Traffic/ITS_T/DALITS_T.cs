using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;
using HPS.BLL.BusinessFactoryMain;


namespace HPS.DAL.ITS
{
    public partial class DALITS_T : DataLayerBase
    {

        public DALITS_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.ITS.BLLITS_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ITSID_bint = new SqlParameter();
                ITSID_bint.ParameterName = "@ITSID_bint";
                ITSID_bint.SqlDbType = SqlDbType.BigInt;
                ITSID_bint.Direction = ParameterDirection.Output;
                ITSID_bint.IsNullable = false;
                ITSID_bint.Value = businessObject.ITSID_bint;
                this.Command.Parameters.Add(ITSID_bint);

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter SendToITSDate_nvc = new SqlParameter();
                SendToITSDate_nvc.ParameterName = "@SendToITSDate_nvc";
                SendToITSDate_nvc.SqlDbType = SqlDbType.NVarChar;
                SendToITSDate_nvc.Direction = ParameterDirection.Input;
                SendToITSDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SendToITSDate_nvc))
                {
                    SendToITSDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SendToITSDate_nvc.Value = businessObject.SendToITSDate_nvc;
                }
                this.Command.Parameters.Add(SendToITSDate_nvc);

                SqlParameter SendToITSTime_nvc = new SqlParameter();
                SendToITSTime_nvc.ParameterName = "@SendToITSTime_nvc";
                SendToITSTime_nvc.SqlDbType = SqlDbType.NVarChar;
                SendToITSTime_nvc.Direction = ParameterDirection.Input;
                SendToITSTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SendToITSTime_nvc))
                {
                    SendToITSTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    SendToITSTime_nvc.Value = businessObject.SendToITSTime_nvc;
                }
                this.Command.Parameters.Add(SendToITSTime_nvc);

                SqlParameter ResiveTimeStamp_nvc = new SqlParameter();
                ResiveTimeStamp_nvc.ParameterName = "@ResiveTimeStamp_nvc";
                ResiveTimeStamp_nvc.SqlDbType = SqlDbType.NVarChar;
                ResiveTimeStamp_nvc.Direction = ParameterDirection.Input;
                ResiveTimeStamp_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ResiveTimeStamp_nvc))
                {
                    ResiveTimeStamp_nvc.Value = DBNull.Value;
                }
                else
                {
                    ResiveTimeStamp_nvc.Value = businessObject.ResiveTimeStamp_nvc;
                }
                this.Command.Parameters.Add(ResiveTimeStamp_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = false;
                NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter StationCode_int = new SqlParameter();
                StationCode_int.ParameterName = "@StationCode_int";
                StationCode_int.SqlDbType = SqlDbType.Int;
                StationCode_int.Direction = ParameterDirection.Input;
                StationCode_int.IsNullable = false;
                StationCode_int.Value = businessObject.StationCode_int;
                this.Command.Parameters.Add(StationCode_int);

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



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.ITSID_bint = (Int64)(this.Command.Parameters["@ITSID_bint"].Value);

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






        public void Update(HPS.BLL.ITS.BLLITS_T businessObject, HPS.BLL.ITS.BLLITS_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = false;
                TrafficID_bint.Value = businessObject.TrafficID_bint;
                this.Command.Parameters.Add(TrafficID_bint);

                SqlParameter SendToITSDate_nvc = new SqlParameter();
                SendToITSDate_nvc.ParameterName = "@SendToITSDate_nvc";
                SendToITSDate_nvc.SqlDbType = SqlDbType.NVarChar;
                SendToITSDate_nvc.Direction = ParameterDirection.Input;
                SendToITSDate_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.SendToITSDate_nvc))
                {
                    SendToITSDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SendToITSDate_nvc.Value = businessObject.SendToITSDate_nvc;
                }
                this.Command.Parameters.Add(SendToITSDate_nvc);

                SqlParameter SendToITSTime_nvc = new SqlParameter();
                SendToITSTime_nvc.ParameterName = "@SendToITSTime_nvc";
                SendToITSTime_nvc.SqlDbType = SqlDbType.NVarChar;
                SendToITSTime_nvc.Direction = ParameterDirection.Input;
                SendToITSTime_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SendToITSTime_nvc))
                {
                    SendToITSTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    SendToITSTime_nvc.Value = businessObject.SendToITSTime_nvc;
                }
                this.Command.Parameters.Add(SendToITSTime_nvc);

                SqlParameter ResiveTimeStamp_nvc = new SqlParameter();
                ResiveTimeStamp_nvc.ParameterName = "@ResiveTimeStamp_nvc";
                ResiveTimeStamp_nvc.SqlDbType = SqlDbType.NVarChar;
                ResiveTimeStamp_nvc.Direction = ParameterDirection.Input;
                ResiveTimeStamp_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ResiveTimeStamp_nvc))
                {
                    ResiveTimeStamp_nvc.Value = DBNull.Value;
                }
                else
                {
                    ResiveTimeStamp_nvc.Value = businessObject.ResiveTimeStamp_nvc;
                }
                this.Command.Parameters.Add(ResiveTimeStamp_nvc);

                SqlParameter NumberPlate_nvc = new SqlParameter();
                NumberPlate_nvc.ParameterName = "@NumberPlate_nvc";
                NumberPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                NumberPlate_nvc.Direction = ParameterDirection.Input;
                NumberPlate_nvc.IsNullable = true;
                NumberPlate_nvc.Value = businessObject.NumberPlate_nvc;
                this.Command.Parameters.Add(NumberPlate_nvc);

                SqlParameter SerialPlate_nvc = new SqlParameter();
                SerialPlate_nvc.ParameterName = "@SerialPlate_nvc";
                SerialPlate_nvc.SqlDbType = SqlDbType.NVarChar;
                SerialPlate_nvc.Direction = ParameterDirection.Input;
                SerialPlate_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.SerialPlate_nvc))
                {
                    SerialPlate_nvc.Value = DBNull.Value;
                }
                else
                {
                    SerialPlate_nvc.Value = businessObject.SerialPlate_nvc;
                }
                this.Command.Parameters.Add(SerialPlate_nvc);


                SqlParameter pk_ITSID_bint = new SqlParameter();
                pk_ITSID_bint.ParameterName = "@pk_ITSID_bint";
                pk_ITSID_bint.SqlDbType = SqlDbType.BigInt;
                pk_ITSID_bint.Direction = ParameterDirection.Input;
                pk_ITSID_bint.IsNullable = false;
                pk_ITSID_bint.Value = businessObjectKey.ITSID_bint;
                this.Command.Parameters.Add(pk_ITSID_bint);



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

        public List<HPS.BLL.ITS.BLLITS_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.ITS.BLLITS_T> Result = new List<HPS.BLL.ITS.BLLITS_T>();
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
            this.Command.CommandText = "[sp_ITS_T_SelectAll]";
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
            this.Command.CommandText = "[sp_ITS_T_SelectAll]";
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
            this.Command.CommandText = "[sp_ITS_T_SelectAll]";
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

        public HPS.BLL.ITS.BLLITS_T SelectByPrimaryKey(HPS.BLL.ITS.BLLITS_T businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ITSID_bint = new SqlParameter();
                ITSID_bint.ParameterName = "@ITSID_bint";
                ITSID_bint.SqlDbType = SqlDbType.BigInt;
                ITSID_bint.Direction = ParameterDirection.Input;
                ITSID_bint.IsNullable = false;
                ITSID_bint.Value = businessObjectKey.ITSID_bint;
                this.Command.Parameters.Add(ITSID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.ITS.BLLITS_T businessObject = new HPS.BLL.ITS.BLLITS_T();
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

        public void SelectByPrimaryKey(HPS.BLL.ITS.BLLITS_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_ITS_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ITSID_bint = new SqlParameter();
                ITSID_bint.ParameterName = "@ITSID_bint";
                ITSID_bint.SqlDbType = SqlDbType.BigInt;
                ITSID_bint.Direction = ParameterDirection.Input;
                ITSID_bint.IsNullable = false;
                ITSID_bint.Value = businessObjectKey.ITSID_bint;
                this.Command.Parameters.Add(ITSID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.ITS.BLLITS_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_ITS_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ITSID_bint = new SqlParameter();
                ITSID_bint.ParameterName = "@ITSID_bint";
                ITSID_bint.SqlDbType = SqlDbType.BigInt;
                ITSID_bint.Direction = ParameterDirection.Input;
                ITSID_bint.IsNullable = false;
                ITSID_bint.Value = businessObjectKey.ITSID_bint;
                this.Command.Parameters.Add(ITSID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.ITS.BLLITS_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_ITS_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ITSID_bint = new SqlParameter();
                ITSID_bint.ParameterName = "@ITSID_bint";
                ITSID_bint.SqlDbType = SqlDbType.BigInt;
                ITSID_bint.Direction = ParameterDirection.Input;
                ITSID_bint.IsNullable = false;
                ITSID_bint.Value = businessObjectKey.ITSID_bint;
                this.Command.Parameters.Add(ITSID_bint);



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





        public List<HPS.BLL.ITS.BLLITS_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[ITS_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.ITS.BLLITS_T> Result = new List<HPS.BLL.ITS.BLLITS_T>();
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
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[ITS_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[ITS_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[ITS_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.ITS.BLLITS_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
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
                List<HPS.BLL.ITS.BLLITS_T> Result = new List<HPS.BLL.ITS.BLLITS_T>();
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
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_ITS_T_SelectCondition]";
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

        public void Delete(HPS.BLL.ITS.BLLITS_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_ITS_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ITSID_bint = new SqlParameter();
                ITSID_bint.ParameterName = "@ITSID_bint";
                ITSID_bint.SqlDbType = SqlDbType.BigInt;
                ITSID_bint.Direction = ParameterDirection.Input;
                ITSID_bint.IsNullable = false;
                ITSID_bint.Value = businessObjectKey.ITSID_bint;
                this.Command.Parameters.Add(ITSID_bint);


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
            this.Command.CommandText = "[sp_ITS_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.ITS.BLLITS_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.ITSID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.ITSID_bint.ToString()));
                businessObject.TrafficID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.TrafficID_bint.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.SendToITSDate_nvc.ToString())) == false)
                {
                    businessObject.SendToITSDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.SendToITSDate_nvc.ToString()));
                }
                else
                {
                    businessObject.SendToITSDate_nvc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.SendToITSTime_nvc.ToString())) == false)
                {
                    businessObject.SendToITSTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.SendToITSTime_nvc.ToString()));
                }
                else
                {
                    businessObject.SendToITSTime_nvc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.ResiveTimeStamp_nvc.ToString())) == false)
                {
                    businessObject.ResiveTimeStamp_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.ResiveTimeStamp_nvc.ToString()));
                }
                else
                {
                    businessObject.ResiveTimeStamp_nvc = String.Empty;
                }

                businessObject.NumberPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.NumberPlate_nvc.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.SerialPlate_nvc.ToString())) == false)
                {
                    businessObject.SerialPlate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ITS.BLLITS_T.ITS_TField.SerialPlate_nvc.ToString()));
                }
                else
                {
                    businessObject.SerialPlate_nvc = String.Empty;
                }

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.ITS.BLLITS_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.ITS.BLLITS_T> list = new List<HPS.BLL.ITS.BLLITS_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.ITS.BLLITS_T businessObject = new HPS.BLL.ITS.BLLITS_T();
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