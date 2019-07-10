using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.BoxingDAL
{
    class DALBoxing_T : DataLayerBase
    {

        public DALBoxing_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.BoxingBLL.BLLBoxing_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Output;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObject.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);

                SqlParameter BoxingCode_nvc = new SqlParameter();
                BoxingCode_nvc.ParameterName = "@BoxingCode_nvc";
                BoxingCode_nvc.SqlDbType = SqlDbType.NVarChar;
                BoxingCode_nvc.Direction = ParameterDirection.Input;
                BoxingCode_nvc.IsNullable = false;
                BoxingCode_nvc.Value = businessObject.BoxingCode_nvc;
                this.Command.Parameters.Add(BoxingCode_nvc);

                SqlParameter BoxingType_nvc = new SqlParameter();
                BoxingType_nvc.ParameterName = "@BoxingType_nvc";
                BoxingType_nvc.SqlDbType = SqlDbType.NVarChar;
                BoxingType_nvc.Direction = ParameterDirection.Input;
                BoxingType_nvc.IsNullable = false;
                BoxingType_nvc.Value = businessObject.BoxingType_nvc;
                this.Command.Parameters.Add(BoxingType_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.BoxingID_int = (Int32?)(this.Command.Parameters["@BoxingID_int"].Value);

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

        public void Update(HPS.BLL.BoxingBLL.BLLBoxing_T businessObject, HPS.BLL.BoxingBLL.BLLBoxing_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingCode_nvc = new SqlParameter();
                BoxingCode_nvc.ParameterName = "@BoxingCode_nvc";
                BoxingCode_nvc.SqlDbType = SqlDbType.NVarChar;
                BoxingCode_nvc.Direction = ParameterDirection.Input;
                BoxingCode_nvc.IsNullable = false;
                BoxingCode_nvc.Value = businessObject.BoxingCode_nvc;
                this.Command.Parameters.Add(BoxingCode_nvc);

                SqlParameter BoxingType_nvc = new SqlParameter();
                BoxingType_nvc.ParameterName = "@BoxingType_nvc";
                BoxingType_nvc.SqlDbType = SqlDbType.NVarChar;
                BoxingType_nvc.Direction = ParameterDirection.Input;
                BoxingType_nvc.IsNullable = false;
                BoxingType_nvc.Value = businessObject.BoxingType_nvc;
                this.Command.Parameters.Add(BoxingType_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);


                SqlParameter pk_BoxingID_int = new SqlParameter();
                pk_BoxingID_int.ParameterName = "@pk_BoxingID_int";
                pk_BoxingID_int.SqlDbType = SqlDbType.Int;
                pk_BoxingID_int.Direction = ParameterDirection.Input;
                pk_BoxingID_int.IsNullable = false;
                pk_BoxingID_int.Value = businessObjectKey.BoxingID_int;
                this.Command.Parameters.Add(pk_BoxingID_int);



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

        public List<HPS.BLL.BoxingBLL.BLLBoxing_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BoxingBLL.BLLBoxing_T> Result = new List<HPS.BLL.BoxingBLL.BLLBoxing_T>();
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
            this.Command.CommandText = "[sp_Boxing_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Boxing_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Boxing_T_SelectAll]";
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

        public HPS.BLL.BoxingBLL.BLLBoxing_T SelectByPrimaryKey(HPS.BLL.BoxingBLL.BLLBoxing_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObjectKey.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.BoxingBLL.BLLBoxing_T businessObject = new HPS.BLL.BoxingBLL.BLLBoxing_T();
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

        public void SelectByPrimaryKey(HPS.BLL.BoxingBLL.BLLBoxing_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Boxing_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObjectKey.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BoxingBLL.BLLBoxing_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Boxing_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObjectKey.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.BoxingBLL.BLLBoxing_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Boxing_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObjectKey.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);



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

        public List<HPS.BLL.BoxingBLL.BLLBoxing_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Boxing_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BoxingBLL.BLLBoxing_T> Result = new List<HPS.BLL.BoxingBLL.BLLBoxing_T>();
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
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Boxing_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Boxing_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Boxing_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.BoxingBLL.BLLBoxing_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
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
                List<HPS.BLL.BoxingBLL.BLLBoxing_T> Result = new List<HPS.BLL.BoxingBLL.BLLBoxing_T>();
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
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Boxing_T_SelectCondition]";
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

        public void Delete(HPS.BLL.BoxingBLL.BLLBoxing_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObjectKey.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);


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
            this.Command.CommandText = "[sp_Boxing_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.BoxingBLL.BLLBoxing_T businessObject, IDataReader dataReader)
        {
            businessObject.BoxingID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingID_int.ToString()));
            businessObject.BoxingCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingCode_nvc.ToString()));
            businessObject.BoxingType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.BoxingType_nvc.ToString()));
            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.BoxingBLL.BLLBoxing_T.Boxing_TField.Active_bit.ToString()));
        }

        public List<HPS.BLL.BoxingBLL.BLLBoxing_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.BoxingBLL.BLLBoxing_T> list = new List<HPS.BLL.BoxingBLL.BLLBoxing_T>();
            while (dataReader.Read())
            {
                HPS.BLL.BoxingBLL.BLLBoxing_T businessObject = new HPS.BLL.BoxingBLL.BLLBoxing_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void TransferData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Boxing_T_TransferData]";
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