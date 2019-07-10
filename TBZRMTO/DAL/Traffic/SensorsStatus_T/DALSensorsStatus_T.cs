using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DALSensorsStatus
{
    public partial class DALSensorsStatus_T : DataLayerBase
    {

        public DALSensorsStatus_T()
            : base(HPS.BLL.CameraConnection.DefaultConnectionString)
        {
        }

        public void Insert(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter sensorsStatusID_int = new SqlParameter();
                sensorsStatusID_int.ParameterName = "@sensorsStatusID_int";
                sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                sensorsStatusID_int.Direction = ParameterDirection.Output;
                sensorsStatusID_int.IsNullable = false;
                sensorsStatusID_int.Value = businessObject.sensorsStatusID_int;
                this.Command.Parameters.Add(sensorsStatusID_int);

                SqlParameter inSensor_bit = new SqlParameter();
                inSensor_bit.ParameterName = "@inSensor_bit";
                inSensor_bit.SqlDbType = SqlDbType.Bit;
                inSensor_bit.Direction = ParameterDirection.Input;
                inSensor_bit.IsNullable = true;
                if (businessObject.inSensor_bit.HasValue == false)
                {
                    inSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    inSensor_bit.Value = businessObject.inSensor_bit;
                }
                this.Command.Parameters.Add(inSensor_bit);

                SqlParameter inGateSensor_bit = new SqlParameter();
                inGateSensor_bit.ParameterName = "@inGateSensor_bit";
                inGateSensor_bit.SqlDbType = SqlDbType.Bit;
                inGateSensor_bit.Direction = ParameterDirection.Input;
                inGateSensor_bit.IsNullable = true;
                if (businessObject.inGateSensor_bit.HasValue == false)
                {
                    inGateSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    inGateSensor_bit.Value = businessObject.inGateSensor_bit;
                }
                this.Command.Parameters.Add(inGateSensor_bit);

                SqlParameter outSensor_bit = new SqlParameter();
                outSensor_bit.ParameterName = "@outSensor_bit";
                outSensor_bit.SqlDbType = SqlDbType.Bit;
                outSensor_bit.Direction = ParameterDirection.Input;
                outSensor_bit.IsNullable = true;
                if (businessObject.outSensor_bit.HasValue == false)
                {
                    outSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    outSensor_bit.Value = businessObject.outSensor_bit;
                }
                this.Command.Parameters.Add(outSensor_bit);

                SqlParameter outGateSensor_bit = new SqlParameter();
                outGateSensor_bit.ParameterName = "@outGateSensor_bit";
                outGateSensor_bit.SqlDbType = SqlDbType.Bit;
                outGateSensor_bit.Direction = ParameterDirection.Input;
                outGateSensor_bit.IsNullable = true;
                if (businessObject.outGateSensor_bit.HasValue == false)
                {
                    outGateSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    outGateSensor_bit.Value = businessObject.outGateSensor_bit;
                }
                this.Command.Parameters.Add(outGateSensor_bit);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.sensorsStatusID_int = (Int32)(this.Command.Parameters["@sensorsStatusID_int"].Value);

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

        public void Update(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T businessObject, HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inSensor_bit = new SqlParameter();
                inSensor_bit.ParameterName = "@inSensor_bit";
                inSensor_bit.SqlDbType = SqlDbType.Bit;
                inSensor_bit.Direction = ParameterDirection.Input;
                inSensor_bit.IsNullable = false;
                if (businessObject.inSensor_bit.HasValue == false)
                {
                    inSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    inSensor_bit.Value = businessObject.inSensor_bit;
                }
                this.Command.Parameters.Add(inSensor_bit);

                SqlParameter inGateSensor_bit = new SqlParameter();
                inGateSensor_bit.ParameterName = "@inGateSensor_bit";
                inGateSensor_bit.SqlDbType = SqlDbType.Bit;
                inGateSensor_bit.Direction = ParameterDirection.Input;
                inGateSensor_bit.IsNullable = true;
                if (businessObject.inGateSensor_bit.HasValue == false)
                {
                    inGateSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    inGateSensor_bit.Value = businessObject.inGateSensor_bit;
                }
                this.Command.Parameters.Add(inGateSensor_bit);

                SqlParameter outSensor_bit = new SqlParameter();
                outSensor_bit.ParameterName = "@outSensor_bit";
                outSensor_bit.SqlDbType = SqlDbType.Bit;
                outSensor_bit.Direction = ParameterDirection.Input;
                outSensor_bit.IsNullable = true;
                if (businessObject.outSensor_bit.HasValue == false)
                {
                    outSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    outSensor_bit.Value = businessObject.outSensor_bit;
                }
                this.Command.Parameters.Add(outSensor_bit);

                SqlParameter outGateSensor_bit = new SqlParameter();
                outGateSensor_bit.ParameterName = "@outGateSensor_bit";
                outGateSensor_bit.SqlDbType = SqlDbType.Bit;
                outGateSensor_bit.Direction = ParameterDirection.Input;
                outGateSensor_bit.IsNullable = true;
                if (businessObject.outGateSensor_bit.HasValue == false)
                {
                    outGateSensor_bit.Value = DBNull.Value;
                }
                else
                {
                    outGateSensor_bit.Value = businessObject.outGateSensor_bit;
                }
                this.Command.Parameters.Add(outGateSensor_bit);


                SqlParameter pk_sensorsStatusID_int = new SqlParameter();
                pk_sensorsStatusID_int.ParameterName = "@pk_sensorsStatusID_int";
                pk_sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                pk_sensorsStatusID_int.Direction = ParameterDirection.Input;
                pk_sensorsStatusID_int.IsNullable = false;
                pk_sensorsStatusID_int.Value = businessObjectKey.sensorsStatusID_int;
                this.Command.Parameters.Add(pk_sensorsStatusID_int);



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

        public List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> Result = new List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T>();
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectAll]";
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectAll]";
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectAll]";
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

        public HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T SelectByPrimaryKey(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter sensorsStatusID_int = new SqlParameter();
                sensorsStatusID_int.ParameterName = "@sensorsStatusID_int";
                sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                sensorsStatusID_int.Direction = ParameterDirection.Input;
                sensorsStatusID_int.IsNullable = false;
                sensorsStatusID_int.Value = businessObjectKey.sensorsStatusID_int;
                this.Command.Parameters.Add(sensorsStatusID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T businessObject = new HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T();
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

        public void SelectByPrimaryKey(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter sensorsStatusID_int = new SqlParameter();
                sensorsStatusID_int.ParameterName = "@sensorsStatusID_int";
                sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                sensorsStatusID_int.Direction = ParameterDirection.Input;
                sensorsStatusID_int.IsNullable = false;
                sensorsStatusID_int.Value = businessObjectKey.sensorsStatusID_int;
                this.Command.Parameters.Add(sensorsStatusID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter sensorsStatusID_int = new SqlParameter();
                sensorsStatusID_int.ParameterName = "@sensorsStatusID_int";
                sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                sensorsStatusID_int.Direction = ParameterDirection.Input;
                sensorsStatusID_int.IsNullable = false;
                sensorsStatusID_int.Value = businessObjectKey.sensorsStatusID_int;
                this.Command.Parameters.Add(sensorsStatusID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter sensorsStatusID_int = new SqlParameter();
                sensorsStatusID_int.ParameterName = "@sensorsStatusID_int";
                sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                sensorsStatusID_int.Direction = ParameterDirection.Input;
                sensorsStatusID_int.IsNullable = false;
                sensorsStatusID_int.Value = businessObjectKey.sensorsStatusID_int;
                this.Command.Parameters.Add(sensorsStatusID_int);



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

        public List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[SensorsStatus_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> Result = new List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T>();
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[SensorsStatus_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[SensorsStatus_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[SensorsStatus_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
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
                List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> Result = new List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T>();
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_SensorsStatus_T_SelectCondition]";
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

        public void Delete(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_SensorsStatus_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter sensorsStatusID_int = new SqlParameter();
                sensorsStatusID_int.ParameterName = "@sensorsStatusID_int";
                sensorsStatusID_int.SqlDbType = SqlDbType.Int;
                sensorsStatusID_int.Direction = ParameterDirection.Input;
                sensorsStatusID_int.IsNullable = false;
                sensorsStatusID_int.Value = businessObjectKey.sensorsStatusID_int;
                this.Command.Parameters.Add(sensorsStatusID_int);


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
            this.Command.CommandText = "[sp_SensorsStatus_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.sensorsStatusID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.sensorsStatusID_int.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.inSensor_bit.ToString())) == false)
                {
                    businessObject.inSensor_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.inSensor_bit.ToString()));
                }
                else
                {
                    businessObject.inSensor_bit = null;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.inGateSensor_bit.ToString())) == false)
                {
                    businessObject.inGateSensor_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.inGateSensor_bit.ToString()));
                }
                else
                {
                    businessObject.inGateSensor_bit = null;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.outSensor_bit.ToString())) == false)
                {
                    businessObject.outSensor_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.outSensor_bit.ToString()));
                }
                else
                {
                    businessObject.outSensor_bit = null;
                }

                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.outGateSensor_bit.ToString())) == false)
                {
                    businessObject.outGateSensor_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T.SensorsStatus_TField.outGateSensor_bit.ToString()));
                }
                else
                {
                    businessObject.outGateSensor_bit = null;
                }

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T> list = new List<HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T businessObject = new HPS.BLL.BLLSensorsStatus.BLLSensorsStatus_T();
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