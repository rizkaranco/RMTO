using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.ComputerDAL
{
    class DALComputer_T : DataLayerBase
    {

        public DALComputer_T() : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.ComputerBLL.BLLComputer_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Output;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObject.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);

                SqlParameter Computer_nvc = new SqlParameter();
                Computer_nvc.ParameterName = "@Computer_nvc";
                Computer_nvc.SqlDbType = SqlDbType.NVarChar;
                Computer_nvc.Direction = ParameterDirection.Input;
                Computer_nvc.IsNullable = false;
                Computer_nvc.Value = businessObject.Computer_nvc;
                this.Command.Parameters.Add(Computer_nvc);

                SqlParameter IPAddress_nvc = new SqlParameter();
                IPAddress_nvc.ParameterName = "@IPAddress_nvc";
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                IPAddress_nvc.Direction = ParameterDirection.Input;
                IPAddress_nvc.IsNullable = false;
                IPAddress_nvc.Value = businessObject.IPAddress_nvc;
                this.Command.Parameters.Add(IPAddress_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter MessageLED_nvc = new SqlParameter();
                MessageLED_nvc.ParameterName = "@MessageLED_nvc";
                MessageLED_nvc.SqlDbType = SqlDbType.NVarChar;
                MessageLED_nvc.Direction = ParameterDirection.Input;
                MessageLED_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.MessageLED_nvc))
                {
                    MessageLED_nvc.Value = DBNull.Value;
                }
                else
                {
                    MessageLED_nvc.Value = businessObject.MessageLED_nvc;
                }
                this.Command.Parameters.Add(MessageLED_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = false;
                UserGroupID_int.Value = businessObject.UserGroupID_int;
                this.Command.Parameters.Add(UserGroupID_int);

                SqlParameter Deleted_bit = new SqlParameter();
                Deleted_bit.ParameterName = "@Deleted_bit";
                Deleted_bit.SqlDbType = SqlDbType.Bit;
                Deleted_bit.Direction = ParameterDirection.Input;
                Deleted_bit.IsNullable = false;
                Deleted_bit.Value = businessObject.Deleted_bit;
                this.Command.Parameters.Add(Deleted_bit);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.ComputerID_int = (Int32?)(this.Command.Parameters["@ComputerID_int"].Value);

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

        public void Update(HPS.BLL.ComputerBLL.BLLComputer_T businessObject, HPS.BLL.ComputerBLL.BLLComputer_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Computer_nvc = new SqlParameter();
                Computer_nvc.ParameterName = "@Computer_nvc";
                Computer_nvc.SqlDbType = SqlDbType.NVarChar;
                Computer_nvc.Direction = ParameterDirection.Input;
                Computer_nvc.IsNullable = false;
                Computer_nvc.Value = businessObject.Computer_nvc;
                this.Command.Parameters.Add(Computer_nvc);

                SqlParameter IPAddress_nvc = new SqlParameter();
                IPAddress_nvc.ParameterName = "@IPAddress_nvc";
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                IPAddress_nvc.Direction = ParameterDirection.Input;
                IPAddress_nvc.IsNullable = false;
                IPAddress_nvc.Value = businessObject.IPAddress_nvc;
                this.Command.Parameters.Add(IPAddress_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter MessageLED_nvc = new SqlParameter();
                MessageLED_nvc.ParameterName = "@MessageLED_nvc";
                MessageLED_nvc.SqlDbType = SqlDbType.NVarChar;
                MessageLED_nvc.Direction = ParameterDirection.Input;
                MessageLED_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.MessageLED_nvc))
                {
                    MessageLED_nvc.Value = DBNull.Value;
                }
                else
                {
                    MessageLED_nvc.Value = businessObject.MessageLED_nvc;
                }
                this.Command.Parameters.Add(MessageLED_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = true;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = false;
                UserGroupID_int.Value = businessObject.UserGroupID_int;
                this.Command.Parameters.Add(UserGroupID_int);

                SqlParameter Deleted_bit = new SqlParameter();
                Deleted_bit.ParameterName = "@Deleted_bit";
                Deleted_bit.SqlDbType = SqlDbType.Bit;
                Deleted_bit.Direction = ParameterDirection.Input;
                Deleted_bit.IsNullable = false;
                Deleted_bit.Value = businessObject.Deleted_bit;
                this.Command.Parameters.Add(Deleted_bit);

                SqlParameter pk_ComputerID_int = new SqlParameter();
                pk_ComputerID_int.ParameterName = "@pk_ComputerID_int";
                pk_ComputerID_int.SqlDbType = SqlDbType.Int;
                pk_ComputerID_int.Direction = ParameterDirection.Input;
                pk_ComputerID_int.IsNullable = false;
                pk_ComputerID_int.Value = businessObjectKey.ComputerID_int;
                this.Command.Parameters.Add(pk_ComputerID_int);



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

        public List<HPS.BLL.ComputerBLL.BLLComputer_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.ComputerBLL.BLLComputer_T> Result = new List<HPS.BLL.ComputerBLL.BLLComputer_T>();
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
            this.Command.CommandText = "[sp_Computer_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Computer_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Computer_T_SelectAll]";
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

        public HPS.BLL.ComputerBLL.BLLComputer_T SelectByPrimaryKey(HPS.BLL.ComputerBLL.BLLComputer_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObjectKey.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.ComputerBLL.BLLComputer_T businessObject = new HPS.BLL.ComputerBLL.BLLComputer_T();
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

        public void SelectByPrimaryKey(HPS.BLL.ComputerBLL.BLLComputer_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Computer_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObjectKey.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.ComputerBLL.BLLComputer_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Computer_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObjectKey.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.ComputerBLL.BLLComputer_TKeys businessObjectKey, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Computer_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObjectKey.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);



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





        public List<HPS.BLL.ComputerBLL.BLLComputer_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Computer_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.ComputerBLL.BLLComputer_T> Result = new List<HPS.BLL.ComputerBLL.BLLComputer_T>();
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
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Computer_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Computer_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public void SelectByField(String fieldName, Object value, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Computer_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.ComputerBLL.BLLComputer_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
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
                List<HPS.BLL.ComputerBLL.BLLComputer_T> Result = new List<HPS.BLL.ComputerBLL.BLLComputer_T>();
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
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Computer_T_SelectCondition]";
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

        public void Delete(HPS.BLL.ComputerBLL.BLLComputer_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Computer_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter ComputerID_int = new SqlParameter();
                ComputerID_int.ParameterName = "@ComputerID_int";
                ComputerID_int.SqlDbType = SqlDbType.Int;
                ComputerID_int.Direction = ParameterDirection.Input;
                ComputerID_int.IsNullable = false;
                ComputerID_int.Value = businessObjectKey.ComputerID_int;
                this.Command.Parameters.Add(ComputerID_int);


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
            this.Command.CommandText = "[sp_Computer_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.ComputerBLL.BLLComputer_T businessObject, IDataReader dataReader)
        {
            businessObject.ComputerID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.ComputerID_int.ToString()));
            businessObject.Computer_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.Computer_nvc.ToString()));
            businessObject.IPAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.IPAddress_nvc.ToString()));
            businessObject.MacAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.MacAddress_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.MessageLED_nvc.ToString())) == false)
            {
                businessObject.MessageLED_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.MessageLED_nvc.ToString()));
            }
            else
            {
                businessObject.MessageLED_nvc = String.Empty;
            }

            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.Active_bit.ToString()));
            businessObject.Deleted_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.Deleted_bit.ToString()));

            businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.UserGroupID_int.ToString()));
        }

        public List<HPS.BLL.ComputerBLL.BLLComputer_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.ComputerBLL.BLLComputer_T> list = new List<HPS.BLL.ComputerBLL.BLLComputer_T>();
            while (dataReader.Read())
            {
                HPS.BLL.ComputerBLL.BLLComputer_T businessObject = new HPS.BLL.ComputerBLL.BLLComputer_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}