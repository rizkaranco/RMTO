using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.SaloonDAL
{
    class DALSaloon_T : DataLayerBase
    {

        public DALSaloon_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.SaloonBLL.BLLSaloon_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Output;
                SaloonID_int.IsNullable = false;
                SaloonID_int.Value = businessObject.SaloonID_int;
                this.Command.Parameters.Add(SaloonID_int);

                SqlParameter Saloon_nvc = new SqlParameter();
                Saloon_nvc.ParameterName = "@Saloon_nvc";
                Saloon_nvc.SqlDbType = SqlDbType.NVarChar;
                Saloon_nvc.Direction = ParameterDirection.Input;
                Saloon_nvc.IsNullable = false;
                Saloon_nvc.Value = businessObject.Saloon_nvc;
                this.Command.Parameters.Add(Saloon_nvc);

                SqlParameter TurnDistinictAfterCredit_int = new SqlParameter();
                TurnDistinictAfterCredit_int.ParameterName = "@TurnDistinictAfterCredit_int";
                TurnDistinictAfterCredit_int.SqlDbType = SqlDbType.Int;
                TurnDistinictAfterCredit_int.Direction = ParameterDirection.Input;
                TurnDistinictAfterCredit_int.IsNullable = false;
                TurnDistinictAfterCredit_int.Value = businessObject.TurnDistinictAfterCredit_int;
                this.Command.Parameters.Add(TurnDistinictAfterCredit_int);

                SqlParameter TurnNumberInLadeAnnouncement_int = new SqlParameter();
                TurnNumberInLadeAnnouncement_int.ParameterName = "@TurnNumberInLadeAnnouncement_int";
                TurnNumberInLadeAnnouncement_int.SqlDbType = SqlDbType.Int;
                TurnNumberInLadeAnnouncement_int.Direction = ParameterDirection.Input;
                TurnNumberInLadeAnnouncement_int.IsNullable = false;
                TurnNumberInLadeAnnouncement_int.Value = businessObject.TurnNumberInLadeAnnouncement_int;
                this.Command.Parameters.Add(TurnNumberInLadeAnnouncement_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.SaloonID_int = (Int32)(this.Command.Parameters["@SaloonID_int"].Value);

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

        public void Update(HPS.BLL.SaloonBLL.BLLSaloon_T businessObject, HPS.BLL.SaloonBLL.BLLSaloon_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Saloon_nvc = new SqlParameter();
                Saloon_nvc.ParameterName = "@Saloon_nvc";
                Saloon_nvc.SqlDbType = SqlDbType.NVarChar;
                Saloon_nvc.Direction = ParameterDirection.Input;
                Saloon_nvc.IsNullable = false;
                Saloon_nvc.Value = businessObject.Saloon_nvc;
                this.Command.Parameters.Add(Saloon_nvc);

                SqlParameter TurnDistinictAfterCredit_int = new SqlParameter();
                TurnDistinictAfterCredit_int.ParameterName = "@TurnDistinictAfterCredit_int";
                TurnDistinictAfterCredit_int.SqlDbType = SqlDbType.Int;
                TurnDistinictAfterCredit_int.Direction = ParameterDirection.Input;
                TurnDistinictAfterCredit_int.IsNullable = false;
                TurnDistinictAfterCredit_int.Value = businessObject.TurnDistinictAfterCredit_int;
                this.Command.Parameters.Add(TurnDistinictAfterCredit_int);

                SqlParameter TurnNumberInLadeAnnouncement_int = new SqlParameter();
                TurnNumberInLadeAnnouncement_int.ParameterName = "@TurnNumberInLadeAnnouncement_int";
                TurnNumberInLadeAnnouncement_int.SqlDbType = SqlDbType.Int;
                TurnNumberInLadeAnnouncement_int.Direction = ParameterDirection.Input;
                TurnNumberInLadeAnnouncement_int.IsNullable = false;
                TurnNumberInLadeAnnouncement_int.Value = businessObject.TurnNumberInLadeAnnouncement_int;
                this.Command.Parameters.Add(TurnNumberInLadeAnnouncement_int);


                SqlParameter pk_SaloonID_int = new SqlParameter();
                pk_SaloonID_int.ParameterName = "@pk_SaloonID_int";
                pk_SaloonID_int.SqlDbType = SqlDbType.Int;
                pk_SaloonID_int.Direction = ParameterDirection.Input;
                pk_SaloonID_int.IsNullable = false;
                pk_SaloonID_int.Value = businessObjectKey.SaloonID_int;
                this.Command.Parameters.Add(pk_SaloonID_int);



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

        public List<HPS.BLL.SaloonBLL.BLLSaloon_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.SaloonBLL.BLLSaloon_T> Result = new List<HPS.BLL.SaloonBLL.BLLSaloon_T>();
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
            this.Command.CommandText = "[sp_Saloon_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Saloon_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Saloon_T_SelectAll]";
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

        public HPS.BLL.SaloonBLL.BLLSaloon_T SelectByPrimaryKey(HPS.BLL.SaloonBLL.BLLSaloon_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = false;
                SaloonID_int.Value = businessObjectKey.SaloonID_int;
                this.Command.Parameters.Add(SaloonID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.SaloonBLL.BLLSaloon_T businessObject = new HPS.BLL.SaloonBLL.BLLSaloon_T();
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

        public void SelectByPrimaryKey(HPS.BLL.SaloonBLL.BLLSaloon_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Saloon_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = false;
                SaloonID_int.Value = businessObjectKey.SaloonID_int;
                this.Command.Parameters.Add(SaloonID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.SaloonBLL.BLLSaloon_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Saloon_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = false;
                SaloonID_int.Value = businessObjectKey.SaloonID_int;
                this.Command.Parameters.Add(SaloonID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.SaloonBLL.BLLSaloon_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Saloon_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = false;
                SaloonID_int.Value = businessObjectKey.SaloonID_int;
                this.Command.Parameters.Add(SaloonID_int);



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





        public List<HPS.BLL.SaloonBLL.BLLSaloon_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Saloon_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.SaloonBLL.BLLSaloon_T> Result = new List<HPS.BLL.SaloonBLL.BLLSaloon_T>();
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
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Saloon_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Saloon_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Saloon_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.SaloonBLL.BLLSaloon_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
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
                List<HPS.BLL.SaloonBLL.BLLSaloon_T> Result = new List<HPS.BLL.SaloonBLL.BLLSaloon_T>();
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
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Saloon_T_SelectCondition]";
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

        public void Delete(HPS.BLL.SaloonBLL.BLLSaloon_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SaloonID_int = new SqlParameter();
                SaloonID_int.ParameterName = "@SaloonID_int";
                SaloonID_int.SqlDbType = SqlDbType.Int;
                SaloonID_int.Direction = ParameterDirection.Input;
                SaloonID_int.IsNullable = false;
                SaloonID_int.Value = businessObjectKey.SaloonID_int;
                this.Command.Parameters.Add(SaloonID_int);


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
            this.Command.CommandText = "[sp_Saloon_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.SaloonBLL.BLLSaloon_T businessObject, IDataReader dataReader)
        {
            businessObject.SaloonID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString()));
            businessObject.Saloon_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.Saloon_nvc.ToString()));
            businessObject.TurnDistinictAfterCredit_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.TurnDistinictAfterCredit_int.ToString()));
            businessObject.TurnNumberInLadeAnnouncement_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.TurnNumberInLadeAnnouncement_int.ToString()));
        }

        public List<HPS.BLL.SaloonBLL.BLLSaloon_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.SaloonBLL.BLLSaloon_T> list = new List<HPS.BLL.SaloonBLL.BLLSaloon_T>();
            while (dataReader.Read())
            {
                HPS.BLL.SaloonBLL.BLLSaloon_T businessObject = new HPS.BLL.SaloonBLL.BLLSaloon_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }


        public void ShowInLadbillCredit(Int64 LadeAssignmentID_bint,out Int32 SaloonID_int)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Saloon_T_ShowInLadbillCredit]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bintParam = new SqlParameter();
                LadeAssignmentID_bintParam.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bintParam.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bintParam.Direction = ParameterDirection.Input;
                LadeAssignmentID_bintParam.IsNullable = false;
                this.Command.Parameters.Add(LadeAssignmentID_bintParam);

                SqlParameter SaloonID_intParam = new SqlParameter();
                SaloonID_intParam.ParameterName = "@SaloonID_int";
                SaloonID_intParam.SqlDbType = SqlDbType.Int;
                SaloonID_intParam.Direction = ParameterDirection.Output;
                SaloonID_intParam.IsNullable = false;
                this.Command.Parameters.Add(SaloonID_intParam);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();
                SaloonID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonID_intParam.Value, TypeCode.Int32);

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