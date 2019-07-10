using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL
{
    public partial class DALPlateNumber_T : DataLayerBase
    {

        public DALPlateNumber_T()
            : base(HPS.BLL.CameraConnection.DefaultConnectionString)
        {
        }

        public void Insert(HPS.BLL.BLLPlateNumber_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Output;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObject.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);

                SqlParameter plateNumber_nvc = new SqlParameter();
                plateNumber_nvc.ParameterName = "@plateNumber_nvc";
                plateNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                plateNumber_nvc.Direction = ParameterDirection.Input;
                plateNumber_nvc.IsNullable = false;
                plateNumber_nvc.Value = businessObject.plateNumber_nvc;
                this.Command.Parameters.Add(plateNumber_nvc);

                SqlParameter plateSerial_vc = new SqlParameter();
                plateSerial_vc.ParameterName = "@plateSerial_vc";
                plateSerial_vc.SqlDbType = SqlDbType.VarChar;
                plateSerial_vc.Direction = ParameterDirection.Input;
                plateSerial_vc.IsNullable = false;
                plateSerial_vc.Value = businessObject.plateSerial_vc;
                this.Command.Parameters.Add(plateSerial_vc);

                SqlParameter date_vc = new SqlParameter();
                date_vc.ParameterName = "@date_vc";
                date_vc.SqlDbType = SqlDbType.VarChar;
                date_vc.Direction = ParameterDirection.Input;
                date_vc.IsNullable = false;
                date_vc.Value = businessObject.date_vc;
                this.Command.Parameters.Add(date_vc);

                SqlParameter time_vc = new SqlParameter();
                time_vc.ParameterName = "@time_vc";
                time_vc.SqlDbType = SqlDbType.VarChar;
                time_vc.Direction = ParameterDirection.Input;
                time_vc.IsNullable = false;
                time_vc.Value = businessObject.time_vc;
                this.Command.Parameters.Add(time_vc);

                SqlParameter PlateColor_nvc = new SqlParameter();
                PlateColor_nvc.ParameterName = "@PlateColor_nvc";
                PlateColor_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateColor_nvc.Direction = ParameterDirection.Input;
                PlateColor_nvc.IsNullable = false;
                PlateColor_nvc.Value = businessObject.PlateColor_nvc;
                this.Command.Parameters.Add(PlateColor_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.cameraPicturesID_bint = (Int64)(this.Command.Parameters["@cameraPicturesID_bint"].Value);

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

        public void Update(HPS.BLL.BLLPlateNumber_T businessObject, HPS.BLL.BLLPlateNumber_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter plateNumber_nvc = new SqlParameter();
                plateNumber_nvc.ParameterName = "@plateNumber_nvc";
                plateNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                plateNumber_nvc.Direction = ParameterDirection.Input;
                plateNumber_nvc.IsNullable = false;
                plateNumber_nvc.Value = businessObject.plateNumber_nvc;
                this.Command.Parameters.Add(plateNumber_nvc);

                SqlParameter plateSerial_vc = new SqlParameter();
                plateSerial_vc.ParameterName = "@plateSerial_vc";
                plateSerial_vc.SqlDbType = SqlDbType.VarChar;
                plateSerial_vc.Direction = ParameterDirection.Input;
                plateSerial_vc.IsNullable = false;
                plateSerial_vc.Value = businessObject.plateSerial_vc;
                this.Command.Parameters.Add(plateSerial_vc);

                SqlParameter date_vc = new SqlParameter();
                date_vc.ParameterName = "@date_vc";
                date_vc.SqlDbType = SqlDbType.VarChar;
                date_vc.Direction = ParameterDirection.Input;
                date_vc.IsNullable = false;
                date_vc.Value = businessObject.date_vc;
                this.Command.Parameters.Add(date_vc);

                SqlParameter time_vc = new SqlParameter();
                time_vc.ParameterName = "@time_vc";
                time_vc.SqlDbType = SqlDbType.VarChar;
                time_vc.Direction = ParameterDirection.Input;
                time_vc.IsNullable = false;
                time_vc.Value = businessObject.time_vc;
                this.Command.Parameters.Add(time_vc);

                SqlParameter PlateColor_nvc = new SqlParameter();
                PlateColor_nvc.ParameterName = "@PlateColor_nvc";
                PlateColor_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateColor_nvc.Direction = ParameterDirection.Input;
                PlateColor_nvc.IsNullable = false;
                PlateColor_nvc.Value = businessObject.PlateColor_nvc;
                this.Command.Parameters.Add(PlateColor_nvc);

                SqlParameter pk_cameraPicturesID_bint = new SqlParameter();
                pk_cameraPicturesID_bint.ParameterName = "@pk_cameraPicturesID_bint";
                pk_cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                pk_cameraPicturesID_bint.Direction = ParameterDirection.Input;
                pk_cameraPicturesID_bint.IsNullable = false;
                pk_cameraPicturesID_bint.Value = businessObjectKey.cameraPicturesID_bint;
                this.Command.Parameters.Add(pk_cameraPicturesID_bint);



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

        public List<HPS.BLL.BLLPlateNumber_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLPlateNumber_T> Result = new List<HPS.BLL.BLLPlateNumber_T>();
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectAll]";
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectAll]";
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectAll]";
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

        public HPS.BLL.BLLPlateNumber_T SelectByPrimaryKey(HPS.BLL.BLLPlateNumber_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObjectKey.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.BLLPlateNumber_T businessObject = new HPS.BLL.BLLPlateNumber_T();
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

        public void SelectByPrimaryKey(HPS.BLL.BLLPlateNumber_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObjectKey.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLPlateNumber_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObjectKey.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLPlateNumber_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObjectKey.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);



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

        public List<HPS.BLL.BLLPlateNumber_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PlateNumber_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLPlateNumber_T> Result = new List<HPS.BLL.BLLPlateNumber_T>();
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PlateNumber_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PlateNumber_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PlateNumber_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.BLLPlateNumber_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
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
                List<HPS.BLL.BLLPlateNumber_T> Result = new List<HPS.BLL.BLLPlateNumber_T>();
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_PlateNumber_T_SelectCondition]";
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

        public void Delete(HPS.BLL.BLLPlateNumber_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PlateNumber_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObjectKey.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);


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
            this.Command.CommandText = "[sp_PlateNumber_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.BLLPlateNumber_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.cameraPicturesID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.BLLPlateNumber_T.PlateNumber_TField.cameraPicturesID_bint.ToString()));
                businessObject.plateNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLPlateNumber_T.PlateNumber_TField.plateNumber_nvc.ToString()));
                businessObject.plateSerial_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLPlateNumber_T.PlateNumber_TField.plateSerial_vc.ToString()));
                businessObject.date_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLPlateNumber_T.PlateNumber_TField.date_vc.ToString()));
                businessObject.time_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLPlateNumber_T.PlateNumber_TField.time_vc.ToString()));
                businessObject.PlateColor_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLPlateNumber_T.PlateNumber_TField.PlateColor_nvc.ToString()));
            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.BLLPlateNumber_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.BLLPlateNumber_T> list = new List<HPS.BLL.BLLPlateNumber_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.BLLPlateNumber_T businessObject = new HPS.BLL.BLLPlateNumber_T();
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


        internal DataTable SelectTrafficNotInTraffic_T()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectNotInTraffic_T]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
                return dataTable;
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

        public void SelectInoutTraffic(string FromDate_vc, string FromTime_vc, string ToDate_vc, string ToTime_vc, DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PlateNumber_T_SelectInoutTraffic]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_vcParam = new SqlParameter();
                FromDate_vcParam.ParameterName = "@FromDate_vc";
                FromDate_vcParam.SqlDbType = SqlDbType.VarChar;
                FromDate_vcParam.Direction = ParameterDirection.Input;
                FromDate_vcParam.IsNullable = false;
                FromDate_vcParam.Value = FromDate_vc;
                this.Command.Parameters.Add(FromDate_vcParam);

                SqlParameter ToDate_vcParam = new SqlParameter();
                ToDate_vcParam.ParameterName = "@ToDate_vc";
                ToDate_vcParam.SqlDbType = SqlDbType.VarChar;
                ToDate_vcParam.Direction = ParameterDirection.Input;
                ToDate_vcParam.IsNullable = false;
                ToDate_vcParam.Value = ToDate_vc;
                this.Command.Parameters.Add(ToDate_vcParam);


                SqlParameter FromTime_vcParam = new SqlParameter();
                FromTime_vcParam.ParameterName = "@FromTime_vc";
                FromTime_vcParam.SqlDbType = SqlDbType.VarChar;
                FromTime_vcParam.Direction = ParameterDirection.Input;
                FromTime_vcParam.IsNullable = false;
                FromTime_vcParam.Value = FromTime_vc;
                this.Command.Parameters.Add(FromTime_vcParam);


                SqlParameter ToTime_vcParam = new SqlParameter();
                ToTime_vcParam.ParameterName = "@ToTime_vc";
                ToTime_vcParam.SqlDbType = SqlDbType.VarChar;
                ToTime_vcParam.Direction = ParameterDirection.Input;
                ToTime_vcParam.IsNullable = false;
                ToTime_vcParam.Value = ToTime_vc;
                this.Command.Parameters.Add(ToTime_vcParam);


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