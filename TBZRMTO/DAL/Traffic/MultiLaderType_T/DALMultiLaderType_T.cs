using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.MultiLaderTypeDAL
{
    class DALMultiLaderType_T : DataLayerBase
    {

        public DALMultiLaderType_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MultiLaderTypeID_int = new SqlParameter();
                MultiLaderTypeID_int.ParameterName = "@MultiLaderTypeID_int";
                MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                MultiLaderTypeID_int.Direction = ParameterDirection.Output;
                MultiLaderTypeID_int.IsNullable = false;
                MultiLaderTypeID_int.Value = businessObject.MultiLaderTypeID_int;
                this.Command.Parameters.Add(MultiLaderTypeID_int);

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObject.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.MultiLaderTypeID_int = (Int32)(this.Command.Parameters["@MultiLaderTypeID_int"].Value);

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

        public void Update(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T businessObject, HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.SqlDbType = SqlDbType.Int;
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.IsNullable = false;
                LaderTypeID_int.Value = businessObject.LaderTypeID_int;
                this.Command.Parameters.Add(LaderTypeID_int);


                SqlParameter pk_MultiLaderTypeID_int = new SqlParameter();
                pk_MultiLaderTypeID_int.ParameterName = "@pk_MultiLaderTypeID_int";
                pk_MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                pk_MultiLaderTypeID_int.Direction = ParameterDirection.Input;
                pk_MultiLaderTypeID_int.IsNullable = false;
                pk_MultiLaderTypeID_int.Value = businessObjectKey.MultiLaderTypeID_int;
                this.Command.Parameters.Add(pk_MultiLaderTypeID_int);



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

        public List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> Result = new List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T>();
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectAll]";
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectAll]";
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectAll]";
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

        public HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T SelectByPrimaryKey(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MultiLaderTypeID_int = new SqlParameter();
                MultiLaderTypeID_int.ParameterName = "@MultiLaderTypeID_int";
                MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                MultiLaderTypeID_int.Direction = ParameterDirection.Input;
                MultiLaderTypeID_int.IsNullable = false;
                MultiLaderTypeID_int.Value = businessObjectKey.MultiLaderTypeID_int;
                this.Command.Parameters.Add(MultiLaderTypeID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T businessObject = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
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

        public void SelectByPrimaryKey(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MultiLaderTypeID_int = new SqlParameter();
                MultiLaderTypeID_int.ParameterName = "@MultiLaderTypeID_int";
                MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                MultiLaderTypeID_int.Direction = ParameterDirection.Input;
                MultiLaderTypeID_int.IsNullable = false;
                MultiLaderTypeID_int.Value = businessObjectKey.MultiLaderTypeID_int;
                this.Command.Parameters.Add(MultiLaderTypeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MultiLaderTypeID_int = new SqlParameter();
                MultiLaderTypeID_int.ParameterName = "@MultiLaderTypeID_int";
                MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                MultiLaderTypeID_int.Direction = ParameterDirection.Input;
                MultiLaderTypeID_int.IsNullable = false;
                MultiLaderTypeID_int.Value = businessObjectKey.MultiLaderTypeID_int;
                this.Command.Parameters.Add(MultiLaderTypeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MultiLaderTypeID_int = new SqlParameter();
                MultiLaderTypeID_int.ParameterName = "@MultiLaderTypeID_int";
                MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                MultiLaderTypeID_int.Direction = ParameterDirection.Input;
                MultiLaderTypeID_int.IsNullable = false;
                MultiLaderTypeID_int.Value = businessObjectKey.MultiLaderTypeID_int;
                this.Command.Parameters.Add(MultiLaderTypeID_int);



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





        public List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MultiLaderType_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> Result = new List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T>();
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MultiLaderType_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MultiLaderType_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[MultiLaderType_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
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
                List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> Result = new List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T>();
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_MultiLaderType_T_SelectCondition]";
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

        public void Delete(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_MultiLaderType_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter MultiLaderTypeID_int = new SqlParameter();
                MultiLaderTypeID_int.ParameterName = "@MultiLaderTypeID_int";
                MultiLaderTypeID_int.SqlDbType = SqlDbType.Int;
                MultiLaderTypeID_int.Direction = ParameterDirection.Input;
                MultiLaderTypeID_int.IsNullable = false;
                MultiLaderTypeID_int.Value = businessObjectKey.MultiLaderTypeID_int;
                this.Command.Parameters.Add(MultiLaderTypeID_int);


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
            this.Command.CommandText = "[sp_MultiLaderType_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T businessObject, IDataReader dataReader)
        {
            businessObject.MultiLaderTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.MultiLaderTypeID_int.ToString()));
            businessObject.LadeAssignmentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LadeAssignmentID_bint.ToString()));
            businessObject.LaderTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T.MultiLaderType_TField.LaderTypeID_int.ToString()));
         
        }

        public List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T> list = new List<HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T>();
            while (dataReader.Read())
            {
                HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T businessObject = new HPS.BLL.MultiLaderTypeBLL.BLLMultiLaderType_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}