using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LaderTypeDAL
{
    class DALLaderType_T : DataLayerBase
    {

        public DALLaderType_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LaderTypeBLL.BLLLaderType_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Output;
                LaderTypeID_int.IsNullable = true;
                LaderTypeID_int.Value = businessObject.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);

                SqlParameter LaderTypeCode_nvc = new SqlParameter();
                LaderTypeCode_nvc.ParameterName = "@LaderTypeCode_nvc";
                LaderTypeCode_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeCode_nvc.Direction = ParameterDirection.Input;
                LaderTypeCode_nvc.IsNullable = true;
                LaderTypeCode_nvc.Value = businessObject.LaderTypeCode_nvc;
                this.Command.Parameters.Add(LaderTypeCode_nvc);

                SqlParameter LaderType_nvc = new SqlParameter();
                LaderType_nvc.ParameterName = "@LaderType_nvc";
                LaderType_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderType_nvc.Direction = ParameterDirection.Input;
                LaderType_nvc.IsNullable = true;
                LaderType_nvc.Value = businessObject.LaderType_nvc;
                this.Command.Parameters.Add(LaderType_nvc);

                SqlParameter MinTruckWeight_dec = new SqlParameter();
                MinTruckWeight_dec.ParameterName = "@MinTruckWeight_dec";
                MinTruckWeight_dec.SqlDbType = SqlDbType.Decimal;
                MinTruckWeight_dec.Direction = ParameterDirection.Input;
                MinTruckWeight_dec.IsNullable = true;
                if (businessObject.MinTruckWeight_dec.HasValue == false)
                {
                    MinTruckWeight_dec.Value = DBNull.Value;
                }
                else
                {
                    MinTruckWeight_dec.Value = businessObject.MinTruckWeight_dec;
                }
                this.Command.Parameters.Add(MinTruckWeight_dec);

                SqlParameter MaxTruckWeight_dec = new SqlParameter();
                MaxTruckWeight_dec.ParameterName = "@MaxTruckWeight_dec";
                MaxTruckWeight_dec.SqlDbType = SqlDbType.Decimal;
                MaxTruckWeight_dec.Direction = ParameterDirection.Input;
                MaxTruckWeight_dec.IsNullable = true;
                if (businessObject.MaxTruckWeight_dec.HasValue == false)
                {
                    MaxTruckWeight_dec.Value = DBNull.Value;
                }
                else
                {
                    MaxTruckWeight_dec.Value = businessObject.MaxTruckWeight_dec;
                }
                this.Command.Parameters.Add(MaxTruckWeight_dec);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = true;
                if (businessObject.SaloonID_int.HasValue == false)
                {
                    SaloonID_int.Value = DBNull.Value;
                }
                else
                {
                    SaloonID_int.Value = businessObject.SaloonID_int;
                }
                this.Command.Parameters.Add(SaloonID_int);

                SqlParameter LaderPivotGroupID_int = new SqlParameter();
                LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
                LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
                LaderPivotGroupID_int.Direction = ParameterDirection.Input;
                LaderPivotGroupID_int.IsNullable = true;
                if (businessObject.LaderPivotGroupID_int.HasValue == false)
                {
                    LaderPivotGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderPivotGroupID_int.Value = businessObject.LaderPivotGroupID_int;
                }
                this.Command.Parameters.Add(LaderPivotGroupID_int);

                SqlParameter TurnCancel_bit = new SqlParameter();
                TurnCancel_bit.ParameterName = "@TurnCancel_bit";
                TurnCancel_bit.SqlDbType = SqlDbType.Bit;
                TurnCancel_bit.Direction = ParameterDirection.Input;
                TurnCancel_bit.IsNullable = false;
                TurnCancel_bit.Value = businessObject.TurnCancel_bit;
                this.Command.Parameters.Add(TurnCancel_bit);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LaderTypeID_int = (Int32)(this.Command.Parameters["@LaderTypeID_int"].Value);

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

        public void Update(HPS.BLL.LaderTypeBLL.BLLLaderType_T businessObject, HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeCode_nvc = new SqlParameter();
                LaderTypeCode_nvc.ParameterName = "@LaderTypeCode_nvc";
                LaderTypeCode_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeCode_nvc.Direction = ParameterDirection.Input;
                LaderTypeCode_nvc.IsNullable = false;
                LaderTypeCode_nvc.Value = businessObject.LaderTypeCode_nvc;
                this.Command.Parameters.Add(LaderTypeCode_nvc);

                SqlParameter LaderType_nvc = new SqlParameter();
                LaderType_nvc.ParameterName = "@LaderType_nvc";
                LaderType_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderType_nvc.Direction = ParameterDirection.Input;
                LaderType_nvc.IsNullable = false;
                LaderType_nvc.Value = businessObject.LaderType_nvc;
                this.Command.Parameters.Add(LaderType_nvc);

                SqlParameter MinTruckWeight_dec = new SqlParameter();
                MinTruckWeight_dec.ParameterName = "@MinTruckWeight_dec";
                MinTruckWeight_dec.SqlDbType = SqlDbType.Decimal;
                MinTruckWeight_dec.Direction = ParameterDirection.Input;
                MinTruckWeight_dec.IsNullable = false;
                if (businessObject.MinTruckWeight_dec.HasValue == false)
                {
                    MinTruckWeight_dec.Value = DBNull.Value;
                }
                else
                {
                    MinTruckWeight_dec.Value = businessObject.MinTruckWeight_dec;
                }
                this.Command.Parameters.Add(MinTruckWeight_dec);

                SqlParameter MaxTruckWeight_dec = new SqlParameter();
                MaxTruckWeight_dec.ParameterName = "@MaxTruckWeight_dec";
                MaxTruckWeight_dec.SqlDbType = SqlDbType.Decimal;
                MaxTruckWeight_dec.Direction = ParameterDirection.Input;
                MaxTruckWeight_dec.IsNullable = true;
                if (businessObject.MaxTruckWeight_dec.HasValue == false)
                {
                    MaxTruckWeight_dec.Value = DBNull.Value;
                }
                else
                {
                    MaxTruckWeight_dec.Value = businessObject.MaxTruckWeight_dec;
                }
                this.Command.Parameters.Add(MaxTruckWeight_dec);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = true;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = false;
                if (businessObject.SaloonID_int.HasValue == false)
                {
                    SaloonID_int.Value = DBNull.Value;
                }
                else
                {
                    SaloonID_int.Value = businessObject.SaloonID_int;
                }
                this.Command.Parameters.Add(SaloonID_int);

                SqlParameter LaderPivotGroupID_int = new SqlParameter();
                LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
                LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
                LaderPivotGroupID_int.Direction = ParameterDirection.Input;
                LaderPivotGroupID_int.IsNullable = true;
                if (businessObject.LaderPivotGroupID_int.HasValue == false)
                {
                    LaderPivotGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderPivotGroupID_int.Value = businessObject.LaderPivotGroupID_int;
                }
                this.Command.Parameters.Add(LaderPivotGroupID_int);


                SqlParameter pk_LaderTypeID_int = new SqlParameter();
                pk_LaderTypeID_int.ParameterName = "@pk_LaderTypeID_int";
                pk_LaderTypeID_int.SqlDbType = SqlDbType.Int;
                pk_LaderTypeID_int.Direction = ParameterDirection.Input;
                pk_LaderTypeID_int.IsNullable = false;
                pk_LaderTypeID_int.Value = businessObjectKey.LaderTypeID_int;
                this.Command.Parameters.Add(pk_LaderTypeID_int);

                SqlParameter TurnCancel_bit = new SqlParameter();
                TurnCancel_bit.ParameterName = "@TurnCancel_bit";
                TurnCancel_bit.SqlDbType = SqlDbType.Bit;
                TurnCancel_bit.Direction = ParameterDirection.Input;
                TurnCancel_bit.IsNullable = false;
                TurnCancel_bit.Value = businessObject.TurnCancel_bit;
                this.Command.Parameters.Add(TurnCancel_bit);

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

        public List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> Result = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
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
            this.Command.CommandText = "[sp_LaderType_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LaderType_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LaderType_T_SelectAll]";
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

        public HPS.BLL.LaderTypeBLL.BLLLaderType_T SelectByPrimaryKey(HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObjectKey.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LaderTypeBLL.BLLLaderType_T businessObject = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObjectKey.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObjectKey.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObjectKey.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);



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

        public List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LaderType_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> Result = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
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
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LaderType_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LaderType_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LaderType_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
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
                List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> Result = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
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
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LaderType_T_SelectCondition]";
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

        public void Delete(HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObjectKey.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);


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
            this.Command.CommandText = "[sp_LaderType_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LaderTypeBLL.BLLLaderType_T businessObject, IDataReader dataReader)
        {
            businessObject.LaderTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeID_int.ToString()));
            businessObject.LaderTypeCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderTypeCode_nvc.ToString()));
            businessObject.LaderType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderType_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MinTruckWeight_dec.ToString())) == false)
            {
                businessObject.MinTruckWeight_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MinTruckWeight_dec.ToString()));
            }
            else
            {
                businessObject.MinTruckWeight_dec = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MaxTruckWeight_dec.ToString())) == false)
            {
                businessObject.MaxTruckWeight_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.MaxTruckWeight_dec.ToString()));
            }
            else
            {
                businessObject.MaxTruckWeight_dec = null;
            }

            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.Active_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.SaloonID_int.ToString())) == false)
            {
                businessObject.SaloonID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.SaloonID_int.ToString()));
            }
            else
            {
                businessObject.SaloonID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderPivotGroupID_int.ToString())) == false)
            {
                businessObject.LaderPivotGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.LaderPivotGroupID_int.ToString()));
            }
            else
            {
                businessObject.LaderPivotGroupID_int = null;
            }

            businessObject.TurnCancel_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.LaderTypeBLL.BLLLaderType_T.LaderType_TField.TurnCancel_bit.ToString()));

        }

        public List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> list = new List<HPS.BLL.LaderTypeBLL.BLLLaderType_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_T businessObject = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void TransferData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LaderType_T_TransferData]";
            this.Command.CommandType = CommandType.StoredProcedure;
            this.Command.CommandTimeout = 240000;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@SourcePath", SourcePath));
                this.Command.Parameters.Add(new SqlParameter("@SourceTable", SourceTable));

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

    }
}