using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.AnnouncementTimeDAL
{
    class DALAnnouncementTime_T : DataLayerBase
    {

        public DALAnnouncementTime_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Output;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObject.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);

                SqlParameter AnnouncementTime_nvc = new SqlParameter();
                AnnouncementTime_nvc.ParameterName = "@AnnouncementTime_nvc";
                AnnouncementTime_nvc.SqlDbType = SqlDbType.NVarChar;
                AnnouncementTime_nvc.Direction = ParameterDirection.Input;
                AnnouncementTime_nvc.IsNullable = false;
                AnnouncementTime_nvc.Value = businessObject.AnnouncementTime_nvc;
                this.Command.Parameters.Add(AnnouncementTime_nvc);

                SqlParameter StartTime_nvc = new SqlParameter();
                StartTime_nvc.ParameterName = "@StartTime_nvc";
                StartTime_nvc.SqlDbType = SqlDbType.NVarChar;
                StartTime_nvc.Direction = ParameterDirection.Input;
                StartTime_nvc.IsNullable = false;
                StartTime_nvc.Value = businessObject.StartTime_nvc;
                this.Command.Parameters.Add(StartTime_nvc);

                SqlParameter EndTime_nvc = new SqlParameter();
                EndTime_nvc.ParameterName = "@EndTime_nvc";
                EndTime_nvc.SqlDbType = SqlDbType.NVarChar;
                EndTime_nvc.Direction = ParameterDirection.Input;
                EndTime_nvc.IsNullable = false;
                EndTime_nvc.Value = businessObject.EndTime_nvc;
                this.Command.Parameters.Add(EndTime_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.AnnouncementTimeID_int = (Int32?)(this.Command.Parameters["@AnnouncementTimeID_int"].Value);

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

        public void Update(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T businessObject, HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTime_nvc = new SqlParameter();
                AnnouncementTime_nvc.ParameterName = "@AnnouncementTime_nvc";
                AnnouncementTime_nvc.SqlDbType = SqlDbType.NVarChar;
                AnnouncementTime_nvc.Direction = ParameterDirection.Input;
                AnnouncementTime_nvc.IsNullable = false;
                AnnouncementTime_nvc.Value = businessObject.AnnouncementTime_nvc;
                this.Command.Parameters.Add(AnnouncementTime_nvc);

                SqlParameter StartTime_nvc = new SqlParameter();
                StartTime_nvc.ParameterName = "@StartTime_nvc";
                StartTime_nvc.SqlDbType = SqlDbType.NVarChar;
                StartTime_nvc.Direction = ParameterDirection.Input;
                StartTime_nvc.IsNullable = false;
                StartTime_nvc.Value = businessObject.StartTime_nvc;
                this.Command.Parameters.Add(StartTime_nvc);

                SqlParameter EndTime_nvc = new SqlParameter();
                EndTime_nvc.ParameterName = "@EndTime_nvc";
                EndTime_nvc.SqlDbType = SqlDbType.NVarChar;
                EndTime_nvc.Direction = ParameterDirection.Input;
                EndTime_nvc.IsNullable = false;
                EndTime_nvc.Value = businessObject.EndTime_nvc;
                this.Command.Parameters.Add(EndTime_nvc);


                SqlParameter pk_AnnouncementTimeID_int = new SqlParameter();
                pk_AnnouncementTimeID_int.ParameterName = "@pk_AnnouncementTimeID_int";
                pk_AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                pk_AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                pk_AnnouncementTimeID_int.IsNullable = false;
                pk_AnnouncementTimeID_int.Value = businessObjectKey.AnnouncementTimeID_int;
                this.Command.Parameters.Add(pk_AnnouncementTimeID_int);



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

        public List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> Result = new List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T>();
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectAll]";
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectAll]";
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectAll]";
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

        public HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T SelectByPrimaryKey(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObjectKey.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T businessObject = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T();
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

        public void SelectByPrimaryKey(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObjectKey.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObjectKey.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObjectKey.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);



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





        public List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[AnnouncementTime_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> Result = new List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T>();
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[AnnouncementTime_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[AnnouncementTime_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[AnnouncementTime_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
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
                List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> Result = new List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T>();
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_AnnouncementTime_T_SelectCondition]";
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

        public void Delete(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_AnnouncementTime_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObjectKey.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);


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
            this.Command.CommandText = "[sp_AnnouncementTime_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T businessObject, IDataReader dataReader)
        {
            businessObject.AnnouncementTimeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTimeID_int.ToString()));
            businessObject.AnnouncementTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTime_nvc.ToString()));
            businessObject.StartTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.StartTime_nvc.ToString()));
            businessObject.EndTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.EndTime_nvc.ToString()));
        }

        public List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T> list = new List<HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T>();
            while (dataReader.Read())
            {
                HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T businessObject = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}