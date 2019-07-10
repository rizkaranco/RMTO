using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.PortPlacesDAL
{
    class DALPortPlaces_T : DataLayerBase
    {

        public DALPortPlaces_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlacesID_int = new SqlParameter();
                PortPlacesID_int.ParameterName = "@PortPlacesID_int";
                PortPlacesID_int.SqlDbType = SqlDbType.Int;
                PortPlacesID_int.Direction = ParameterDirection.Output;
                PortPlacesID_int.IsNullable = false;
                PortPlacesID_int.Value = businessObject.PortPlacesID_int;
                this.Command.Parameters.Add(PortPlacesID_int);

                SqlParameter PortPlaces_nvc = new SqlParameter();
                PortPlaces_nvc.ParameterName = "@PortPlaces_nvc";
                PortPlaces_nvc.SqlDbType = SqlDbType.NVarChar;
                PortPlaces_nvc.Direction = ParameterDirection.Input;
                PortPlaces_nvc.IsNullable = false;
                PortPlaces_nvc.Value = businessObject.PortPlaces_nvc;
                this.Command.Parameters.Add(PortPlaces_nvc);

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

                businessObject.PortPlacesID_int = (Int32?)(this.Command.Parameters["@PortPlacesID_int"].Value);

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

        public void Update(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T businessObject, HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlaces_nvc = new SqlParameter();
                PortPlaces_nvc.ParameterName = "@PortPlaces_nvc";
                PortPlaces_nvc.SqlDbType = SqlDbType.NVarChar;
                PortPlaces_nvc.Direction = ParameterDirection.Input;
                PortPlaces_nvc.IsNullable = false;
                PortPlaces_nvc.Value = businessObject.PortPlaces_nvc;
                this.Command.Parameters.Add(PortPlaces_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);


                SqlParameter pk_PortPlacesID_int = new SqlParameter();
                pk_PortPlacesID_int.ParameterName = "@pk_PortPlacesID_int";
                pk_PortPlacesID_int.SqlDbType = SqlDbType.Int;
                pk_PortPlacesID_int.Direction = ParameterDirection.Input;
                pk_PortPlacesID_int.IsNullable = false;
                pk_PortPlacesID_int.Value = businessObjectKey.PortPlacesID_int;
                this.Command.Parameters.Add(pk_PortPlacesID_int);



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

        public List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> Result = new List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T>();
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectAll]";
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectAll]";
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectAll]";
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

        public HPS.BLL.PortPlacesBLL.BLLPortPlaces_T SelectByPrimaryKey(HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlacesID_int = new SqlParameter();
                PortPlacesID_int.ParameterName = "@PortPlacesID_int";
                PortPlacesID_int.SqlDbType = SqlDbType.Int;
                PortPlacesID_int.Direction = ParameterDirection.Input;
                PortPlacesID_int.IsNullable = false;
                PortPlacesID_int.Value = businessObjectKey.PortPlacesID_int;
                this.Command.Parameters.Add(PortPlacesID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_T businessObject = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_T();
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

        public void SelectByPrimaryKey(HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlacesID_int = new SqlParameter();
                PortPlacesID_int.ParameterName = "@PortPlacesID_int";
                PortPlacesID_int.SqlDbType = SqlDbType.Int;
                PortPlacesID_int.Direction = ParameterDirection.Input;
                PortPlacesID_int.IsNullable = false;
                PortPlacesID_int.Value = businessObjectKey.PortPlacesID_int;
                this.Command.Parameters.Add(PortPlacesID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlacesID_int = new SqlParameter();
                PortPlacesID_int.ParameterName = "@PortPlacesID_int";
                PortPlacesID_int.SqlDbType = SqlDbType.Int;
                PortPlacesID_int.Direction = ParameterDirection.Input;
                PortPlacesID_int.IsNullable = false;
                PortPlacesID_int.Value = businessObjectKey.PortPlacesID_int;
                this.Command.Parameters.Add(PortPlacesID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlacesID_int = new SqlParameter();
                PortPlacesID_int.ParameterName = "@PortPlacesID_int";
                PortPlacesID_int.SqlDbType = SqlDbType.Int;
                PortPlacesID_int.Direction = ParameterDirection.Input;
                PortPlacesID_int.IsNullable = false;
                PortPlacesID_int.Value = businessObjectKey.PortPlacesID_int;
                this.Command.Parameters.Add(PortPlacesID_int);



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





        public List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PortPlaces_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> Result = new List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T>();
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PortPlaces_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PortPlaces_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[PortPlaces_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
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
                List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> Result = new List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T>();
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_PortPlaces_T_SelectCondition]";
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

        public void Delete(HPS.BLL.PortPlacesBLL.BLLPortPlaces_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_PortPlaces_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter PortPlacesID_int = new SqlParameter();
                PortPlacesID_int.ParameterName = "@PortPlacesID_int";
                PortPlacesID_int.SqlDbType = SqlDbType.Int;
                PortPlacesID_int.Direction = ParameterDirection.Input;
                PortPlacesID_int.IsNullable = false;
                PortPlacesID_int.Value = businessObjectKey.PortPlacesID_int;
                this.Command.Parameters.Add(PortPlacesID_int);


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
            this.Command.CommandText = "[sp_PortPlaces_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T businessObject, IDataReader dataReader)
        {
            businessObject.PortPlacesID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlacesID_int.ToString()));
            businessObject.PortPlaces_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.PortPlaces_nvc.ToString()));
            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.PortPlacesBLL.BLLPortPlaces_T.PortPlaces_TField.Active_bit.ToString()));
        }

        public List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T> list = new List<HPS.BLL.PortPlacesBLL.BLLPortPlaces_T>();
            while (dataReader.Read())
            {
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_T businessObject = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}