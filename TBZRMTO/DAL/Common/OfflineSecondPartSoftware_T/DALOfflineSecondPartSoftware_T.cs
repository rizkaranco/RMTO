using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.OfflineSecondPartSoftwareDAL
{
    public partial class DALOfflineSecondPartSoftware_T : DataLayerBase
    {

        public DALOfflineSecondPartSoftware_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Output;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObject.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);

                SqlParameter DisconnectDate_vc = new SqlParameter();
                DisconnectDate_vc.ParameterName = "@DisconnectDate_vc";
                DisconnectDate_vc.SqlDbType = SqlDbType.VarChar;
                DisconnectDate_vc.Direction = ParameterDirection.Input;
                DisconnectDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DisconnectDate_vc))
                {
                    DisconnectDate_vc.Value = DBNull.Value;
                }
                else
                {
                    DisconnectDate_vc.Value = businessObject.DisconnectDate_vc;
                }
                this.Command.Parameters.Add(DisconnectDate_vc);

                SqlParameter DisconnectTime_vc = new SqlParameter();
                DisconnectTime_vc.ParameterName = "@DisconnectTime_vc";
                DisconnectTime_vc.SqlDbType = SqlDbType.VarChar;
                DisconnectTime_vc.Direction = ParameterDirection.Input;
                DisconnectTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DisconnectTime_vc))
                {
                    DisconnectTime_vc.Value = DBNull.Value;
                }
                else
                {
                    DisconnectTime_vc.Value = businessObject.DisconnectTime_vc;
                }
                this.Command.Parameters.Add(DisconnectTime_vc);

                SqlParameter ConnectDate_vc = new SqlParameter();
                ConnectDate_vc.ParameterName = "@ConnectDate_vc";
                ConnectDate_vc.SqlDbType = SqlDbType.VarChar;
                ConnectDate_vc.Direction = ParameterDirection.Input;
                ConnectDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ConnectDate_vc))
                {
                    ConnectDate_vc.Value = DBNull.Value;
                }
                else
                {
                    ConnectDate_vc.Value = businessObject.ConnectDate_vc;
                }
                this.Command.Parameters.Add(ConnectDate_vc);

                SqlParameter ConnectTime_vc = new SqlParameter();
                ConnectTime_vc.ParameterName = "@ConnectTime_vc";
                ConnectTime_vc.SqlDbType = SqlDbType.VarChar;
                ConnectTime_vc.Direction = ParameterDirection.Input;
                ConnectTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ConnectTime_vc))
                {
                    ConnectTime_vc.Value = DBNull.Value;
                }
                else
                {
                    ConnectTime_vc.Value = businessObject.ConnectTime_vc;
                }
                this.Command.Parameters.Add(ConnectTime_vc);

                SqlParameter SoftwareCode_int = new SqlParameter();
                SoftwareCode_int.ParameterName = "@SoftwareCode_int";
                SoftwareCode_int.SqlDbType = SqlDbType.Int;
                SoftwareCode_int.Direction = ParameterDirection.Input;
                SoftwareCode_int.IsNullable = false;
                SoftwareCode_int.Value = businessObject.SoftwareCode_int;
                this.Command.Parameters.Add(SoftwareCode_int);

                SqlParameter SensorIsOff_bitParam = new SqlParameter();
                SensorIsOff_bitParam.ParameterName = "@SensorIsOff_bit";
                SensorIsOff_bitParam.SqlDbType = SqlDbType.Bit;
                SensorIsOff_bitParam.Direction = ParameterDirection.Input;
                SensorIsOff_bitParam.IsNullable = false;
                SensorIsOff_bitParam.Value = businessObject.SensorIsOff_bit;
                this.Command.Parameters.Add(SensorIsOff_bitParam);

                SqlParameter inCameraDisconnected_bitParam = new SqlParameter();
                inCameraDisconnected_bitParam.ParameterName = "@inCameraDisconnected_bit";
                inCameraDisconnected_bitParam.SqlDbType = SqlDbType.Bit;
                inCameraDisconnected_bitParam.Direction = ParameterDirection.Input;
                inCameraDisconnected_bitParam.IsNullable = false;
                inCameraDisconnected_bitParam.Value = businessObject.inCameraDisconnected_bit;
                this.Command.Parameters.Add(inCameraDisconnected_bitParam);

                SqlParameter outCameraDisconnected_bitParam = new SqlParameter();
                outCameraDisconnected_bitParam.ParameterName = "@outCameraDisconnected_bit";
                outCameraDisconnected_bitParam.SqlDbType = SqlDbType.Bit;
                outCameraDisconnected_bitParam.Direction = ParameterDirection.Input;
                outCameraDisconnected_bitParam.IsNullable = false;
                outCameraDisconnected_bitParam.Value =businessObject.outCameraDisconnected_bit;
                this.Command.Parameters.Add(outCameraDisconnected_bitParam);
                    

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.OfflineSecondPartSoftwareID_int = (Int32)(this.Command.Parameters["@OfflineSecondPartSoftwareID_int"].Value);

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

        public void Update( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T businessObject,  HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter DisconnectDate_vc = new SqlParameter();
                DisconnectDate_vc.ParameterName = "@DisconnectDate_vc";
                DisconnectDate_vc.SqlDbType = SqlDbType.VarChar;
                DisconnectDate_vc.Direction = ParameterDirection.Input;
                DisconnectDate_vc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.DisconnectDate_vc))
                {
                    DisconnectDate_vc.Value = DBNull.Value;
                }
                else
                {
                    DisconnectDate_vc.Value = businessObject.DisconnectDate_vc;
                }
                this.Command.Parameters.Add(DisconnectDate_vc);

                SqlParameter DisconnectTime_vc = new SqlParameter();
                DisconnectTime_vc.ParameterName = "@DisconnectTime_vc";
                DisconnectTime_vc.SqlDbType = SqlDbType.VarChar;
                DisconnectTime_vc.Direction = ParameterDirection.Input;
                DisconnectTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DisconnectTime_vc))
                {
                    DisconnectTime_vc.Value = DBNull.Value;
                }
                else
                {
                    DisconnectTime_vc.Value = businessObject.DisconnectTime_vc;
                }
                this.Command.Parameters.Add(DisconnectTime_vc);

                SqlParameter ConnectDate_vc = new SqlParameter();
                ConnectDate_vc.ParameterName = "@ConnectDate_vc";
                ConnectDate_vc.SqlDbType = SqlDbType.VarChar;
                ConnectDate_vc.Direction = ParameterDirection.Input;
                ConnectDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ConnectDate_vc))
                {
                    ConnectDate_vc.Value = DBNull.Value;
                }
                else
                {
                    ConnectDate_vc.Value = businessObject.ConnectDate_vc;
                }
                this.Command.Parameters.Add(ConnectDate_vc);

                SqlParameter ConnectTime_vc = new SqlParameter();
                ConnectTime_vc.ParameterName = "@ConnectTime_vc";
                ConnectTime_vc.SqlDbType = SqlDbType.VarChar;
                ConnectTime_vc.Direction = ParameterDirection.Input;
                ConnectTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ConnectTime_vc))
                {
                    ConnectTime_vc.Value = DBNull.Value;
                }
                else
                {
                    ConnectTime_vc.Value = businessObject.ConnectTime_vc;
                }
                this.Command.Parameters.Add(ConnectTime_vc);

                SqlParameter SoftwareCode_int = new SqlParameter();
                SoftwareCode_int.ParameterName = "@SoftwareCode_int";
                SoftwareCode_int.SqlDbType = SqlDbType.Int;
                SoftwareCode_int.Direction = ParameterDirection.Input;
                SoftwareCode_int.IsNullable = true;
                SoftwareCode_int.Value = businessObject.SoftwareCode_int;
                this.Command.Parameters.Add(SoftwareCode_int);


                SqlParameter pk_OfflineSecondPartSoftwareID_int = new SqlParameter();
                pk_OfflineSecondPartSoftwareID_int.ParameterName = "@pk_OfflineSecondPartSoftwareID_int";
                pk_OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                pk_OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                pk_OfflineSecondPartSoftwareID_int.IsNullable = false;
                pk_OfflineSecondPartSoftwareID_int.Value = businessObjectKey.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(pk_OfflineSecondPartSoftwareID_int);

                SqlParameter SensorIsOff_bitParam = new SqlParameter();
                SensorIsOff_bitParam.ParameterName = "@SensorIsOff_bit";
                SensorIsOff_bitParam.SqlDbType = SqlDbType.Bit;
                SensorIsOff_bitParam.Direction = ParameterDirection.Input;
                SensorIsOff_bitParam.IsNullable = false;
                SensorIsOff_bitParam.Value = businessObject.SensorIsOff_bit;
                this.Command.Parameters.Add(SensorIsOff_bitParam);

                SqlParameter inCameraDisconnected_bitParam = new SqlParameter();
                inCameraDisconnected_bitParam.ParameterName = "@inCameraDisconnected_bit";
                inCameraDisconnected_bitParam.SqlDbType = SqlDbType.Bit;
                inCameraDisconnected_bitParam.Direction = ParameterDirection.Input;
                inCameraDisconnected_bitParam.IsNullable = false;
                inCameraDisconnected_bitParam.Value =businessObject. inCameraDisconnected_bit;
                this.Command.Parameters.Add(inCameraDisconnected_bitParam);

                SqlParameter outCameraDisconnected_bitParam = new SqlParameter();
                outCameraDisconnected_bitParam.ParameterName = "@outCameraDisconnected_bit";
                outCameraDisconnected_bitParam.SqlDbType = SqlDbType.Bit;
                outCameraDisconnected_bitParam.Direction = ParameterDirection.Input;
                outCameraDisconnected_bitParam.IsNullable = false;
                outCameraDisconnected_bitParam.Value = businessObject.outCameraDisconnected_bit;
                this.Command.Parameters.Add(outCameraDisconnected_bitParam);

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

        public List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> Result = new List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T>();
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectAll]";
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

        public  HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T SelectByPrimaryKey( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObjectKey.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                 HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T businessObject = new  HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();
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

        public void SelectByPrimaryKey( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObjectKey.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);


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

        public void SelectByPrimaryKey( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObjectKey.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);


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

        public void SelectByPrimaryKey( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObjectKey.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);



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

        public List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OfflineSecondPartSoftware_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> Result = new List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T>();
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OfflineSecondPartSoftware_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OfflineSecondPartSoftware_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OfflineSecondPartSoftware_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
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
                List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> Result = new List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T>();
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectCondition]";
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

        public void Delete( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OfflineSecondPartSoftwareID_int = new SqlParameter();
                OfflineSecondPartSoftwareID_int.ParameterName = "@OfflineSecondPartSoftwareID_int";
                OfflineSecondPartSoftwareID_int.SqlDbType = SqlDbType.Int;
                OfflineSecondPartSoftwareID_int.Direction = ParameterDirection.Input;
                OfflineSecondPartSoftwareID_int.IsNullable = false;
                OfflineSecondPartSoftwareID_int.Value = businessObjectKey.OfflineSecondPartSoftwareID_int;
                this.Command.Parameters.Add(OfflineSecondPartSoftwareID_int);


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
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.OfflineSecondPartSoftwareID_int = dataReader.GetInt32(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.OfflineSecondPartSoftwareID_int.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.DisconnectDate_vc.ToString())) == false)
                {
                    businessObject.DisconnectDate_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.DisconnectDate_vc.ToString()));
                }
                else
                {
                    businessObject.DisconnectDate_vc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.DisconnectTime_vc.ToString())) == false)
                {
                    businessObject.DisconnectTime_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.DisconnectTime_vc.ToString()));
                }
                else
                {
                    businessObject.DisconnectTime_vc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.ConnectDate_vc.ToString())) == false)
                {
                    businessObject.ConnectDate_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.ConnectDate_vc.ToString()));
                }
                else
                {
                    businessObject.ConnectDate_vc = String.Empty;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.ConnectTime_vc.ToString())) == false)
                {
                    businessObject.ConnectTime_vc = dataReader.GetString(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.ConnectTime_vc.ToString()));
                }
                else
                {
                    businessObject.ConnectTime_vc = String.Empty;
                }

                businessObject.SoftwareCode_int = dataReader.GetInt32(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.SoftwareCode_int.ToString()));
                businessObject.SensorIsOff_bit = dataReader.GetBoolean(dataReader.GetOrdinal( HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.SensorIsOff_bit.ToString()));
                businessObject.inCameraDisconnected_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.inCameraDisconnected_bit.ToString()));
                businessObject.outCameraDisconnected_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.OfflineSecondPartSoftware_TField.outCameraDisconnected_bit.ToString()));

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T> list = new List< HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T>();
                while (dataReader.Read())
                {
                     HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T businessObject = new  HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();
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

        public HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T SelectOfflineSoftwares(Int32 SoftwareCode_int, bool SensorIsOff_bit, bool inCameraDisconnected_bit, bool outCameraDisconnected_bit)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            if (!ControlConnection)
            {
                BeginTransaction();
            }
            this.Command.CommandText = "[sp_OfflineSecondPartSoftware_T_SelectOfflineSoftwares]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SoftwareCode_intParam = new SqlParameter();
                SoftwareCode_intParam.ParameterName = "@SoftwareCode_int";
                SoftwareCode_intParam.SqlDbType = SqlDbType.Int;
                SoftwareCode_intParam.Direction = ParameterDirection.Input;
                SoftwareCode_intParam.IsNullable = false;
                SoftwareCode_intParam.Value = SoftwareCode_int;
                this.Command.Parameters.Add(SoftwareCode_intParam);

                SqlParameter SensorIsOff_bitParam = new SqlParameter();
                SensorIsOff_bitParam.ParameterName = "@SensorIsOff_bit";
                SensorIsOff_bitParam.SqlDbType = SqlDbType.Bit;
                SensorIsOff_bitParam.Direction = ParameterDirection.Input;
                SensorIsOff_bitParam.IsNullable = false;
                SensorIsOff_bitParam.Value = SensorIsOff_bit;
                this.Command.Parameters.Add(SensorIsOff_bitParam);

                SqlParameter inCameraDisconnected_bitParam = new SqlParameter();
                inCameraDisconnected_bitParam.ParameterName = "@inCameraDisconnected_bit";
                inCameraDisconnected_bitParam.SqlDbType = SqlDbType.Bit;
                inCameraDisconnected_bitParam.Direction = ParameterDirection.Input;
                inCameraDisconnected_bitParam.IsNullable = false;
                inCameraDisconnected_bitParam.Value = inCameraDisconnected_bit;
                this.Command.Parameters.Add(inCameraDisconnected_bitParam);

                SqlParameter outCameraDisconnected_bitParam = new SqlParameter();
                outCameraDisconnected_bitParam.ParameterName = "@outCameraDisconnected_bit";
                outCameraDisconnected_bitParam.SqlDbType = SqlDbType.Bit;
                outCameraDisconnected_bitParam.Direction = ParameterDirection.Input;
                outCameraDisconnected_bitParam.IsNullable = false;
                outCameraDisconnected_bitParam.Value = outCameraDisconnected_bit;
                this.Command.Parameters.Add(outCameraDisconnected_bitParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T businessObject = new HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();
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


    }
}