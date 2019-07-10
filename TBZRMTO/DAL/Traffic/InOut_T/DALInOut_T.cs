using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL
{
    public partial class DALInOut_T : DataLayerBase
    {

        public DALInOut_T()
            : base(HPS.BLL.CameraConnection.DefaultConnectionString)
        {
        }

        public void Insert(HPS.BLL.BLLInOut_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Output;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObject.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObject.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);

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

                SqlParameter gate_tint = new SqlParameter();
                gate_tint.ParameterName = "@gate_tint";
                gate_tint.SqlDbType = SqlDbType.TinyInt;
                gate_tint.Direction = ParameterDirection.Input;
                gate_tint.IsNullable = false;
                gate_tint.Value = businessObject.gate_tint;
                this.Command.Parameters.Add(gate_tint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.inOutID_bint = (Int64)(this.Command.Parameters["@inOutID_bint"].Value);

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

        public void Update(HPS.BLL.BLLInOut_T businessObject, HPS.BLL.BLLInOut_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter cameraPicturesID_bint = new SqlParameter();
                cameraPicturesID_bint.ParameterName = "@cameraPicturesID_bint";
                cameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                cameraPicturesID_bint.Direction = ParameterDirection.Input;
                cameraPicturesID_bint.IsNullable = false;
                cameraPicturesID_bint.Value = businessObject.cameraPicturesID_bint;
                this.Command.Parameters.Add(cameraPicturesID_bint);

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

                SqlParameter gate_tint = new SqlParameter();
                gate_tint.ParameterName = "@gate_tint";
                gate_tint.SqlDbType = SqlDbType.TinyInt;
                gate_tint.Direction = ParameterDirection.Input;
                gate_tint.IsNullable = false;
                gate_tint.Value = businessObject.gate_tint;
                this.Command.Parameters.Add(gate_tint);


                SqlParameter pk_inOutID_bint = new SqlParameter();
                pk_inOutID_bint.ParameterName = "@pk_inOutID_bint";
                pk_inOutID_bint.SqlDbType = SqlDbType.BigInt;
                pk_inOutID_bint.Direction = ParameterDirection.Input;
                pk_inOutID_bint.IsNullable = false;
                pk_inOutID_bint.Value = businessObjectKey.inOutID_bint;
                this.Command.Parameters.Add(pk_inOutID_bint);



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

        public List<HPS.BLL.BLLInOut_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLInOut_T> Result = new List<HPS.BLL.BLLInOut_T>();
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
            this.Command.CommandText = "[sp_InOut_T_SelectAll]";
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
            this.Command.CommandText = "[sp_InOut_T_SelectAll]";
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
            this.Command.CommandText = "[sp_InOut_T_SelectAll]";
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

        public HPS.BLL.BLLInOut_T SelectByPrimaryKey(HPS.BLL.BLLInOut_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObjectKey.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.BLLInOut_T businessObject = new HPS.BLL.BLLInOut_T();
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

        public void SelectByPrimaryKey(HPS.BLL.BLLInOut_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InOut_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObjectKey.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLInOut_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InOut_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObjectKey.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.BLLInOut_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InOut_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObjectKey.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);



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





        public List<HPS.BLL.BLLInOut_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOut_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.BLLInOut_T> Result = new List<HPS.BLL.BLLInOut_T>();
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
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOut_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOut_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOut_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.BLLInOut_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
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
                List<HPS.BLL.BLLInOut_T> Result = new List<HPS.BLL.BLLInOut_T>();
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
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_InOut_T_SelectCondition]";
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

        public void Delete(HPS.BLL.BLLInOut_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOut_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObjectKey.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);


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
            this.Command.CommandText = "[sp_InOut_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.BLLInOut_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.inOutID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.BLLInOut_T.InOut_TField.inOutID_bint.ToString()));
                businessObject.cameraPicturesID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.BLLInOut_T.InOut_TField.cameraPicturesID_bint.ToString()));
                businessObject.date_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLInOut_T.InOut_TField.date_vc.ToString()));
                businessObject.time_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BLLInOut_T.InOut_TField.time_vc.ToString()));
                businessObject.gate_tint = dataReader.GetByte(dataReader.GetOrdinal(HPS.BLL.BLLInOut_T.InOut_TField.gate_tint.ToString()));
            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.BLLInOut_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.BLLInOut_T> list = new List<HPS.BLL.BLLInOut_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.BLLInOut_T businessObject = new HPS.BLL.BLLInOut_T();
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