using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.NewsDAL
{
    class DALNews_T : DataLayerBase
    {

        public DALNews_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.NewsBLL.BLLNews_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NewsID_bint = new SqlParameter();
                NewsID_bint.ParameterName = "@NewsID_bint";
                NewsID_bint.SqlDbType = SqlDbType.BigInt;
                NewsID_bint.Direction = ParameterDirection.Output;
                NewsID_bint.IsNullable = false;
                NewsID_bint.Value = businessObject.NewsID_bint;
                this.Command.Parameters.Add(NewsID_bint);

                SqlParameter Title_nvc = new SqlParameter();
                Title_nvc.ParameterName = "@Title_nvc";
                Title_nvc.SqlDbType = SqlDbType.NVarChar;
                Title_nvc.Direction = ParameterDirection.Input;
                Title_nvc.IsNullable = false;
                Title_nvc.Value = businessObject.Title_nvc;
                this.Command.Parameters.Add(Title_nvc);

                SqlParameter News_nvc = new SqlParameter();
                News_nvc.ParameterName = "@News_nvc";
                News_nvc.SqlDbType = SqlDbType.NVarChar;
                News_nvc.Direction = ParameterDirection.Input;
                News_nvc.IsNullable = false;
                News_nvc.Value = businessObject.News_nvc;
                this.Command.Parameters.Add(News_nvc);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.StartDate_nvc))
                {
                    StartDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    StartDate_nvc.Value = businessObject.StartDate_nvc;
                }
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EndDate_nvc))
                {
                    EndDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    EndDate_nvc.Value = businessObject.EndDate_nvc;
                }
                this.Command.Parameters.Add(EndDate_nvc);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = false;
                Date_nvc.Value = businessObject.Date_nvc;
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Time_nvc = new SqlParameter();
                Time_nvc.ParameterName = "@Time_nvc";
                Time_nvc.SqlDbType = SqlDbType.NVarChar;
                Time_nvc.Direction = ParameterDirection.Input;
                Time_nvc.IsNullable = false;
                Time_nvc.Value = businessObject.Time_nvc;
                this.Command.Parameters.Add(Time_nvc);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.NewsID_bint = (Int64?)(this.Command.Parameters["@NewsID_bint"].Value);

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

        public void Update(HPS.BLL.NewsBLL.BLLNews_T businessObject, HPS.BLL.NewsBLL.BLLNews_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter Title_nvc = new SqlParameter();
                Title_nvc.ParameterName = "@Title_nvc";
                Title_nvc.SqlDbType = SqlDbType.NVarChar;
                Title_nvc.Direction = ParameterDirection.Input;
                Title_nvc.IsNullable = false;
                Title_nvc.Value = businessObject.Title_nvc;
                this.Command.Parameters.Add(Title_nvc);

                SqlParameter News_nvc = new SqlParameter();
                News_nvc.ParameterName = "@News_nvc";
                News_nvc.SqlDbType = SqlDbType.NVarChar;
                News_nvc.Direction = ParameterDirection.Input;
                News_nvc.IsNullable = false;
                News_nvc.Value = businessObject.News_nvc;
                this.Command.Parameters.Add(News_nvc);

                SqlParameter StartDate_nvc = new SqlParameter();
                StartDate_nvc.ParameterName = "@StartDate_nvc";
                StartDate_nvc.SqlDbType = SqlDbType.NVarChar;
                StartDate_nvc.Direction = ParameterDirection.Input;
                StartDate_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.StartDate_nvc))
                {
                    StartDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    StartDate_nvc.Value = businessObject.StartDate_nvc;
                }
                this.Command.Parameters.Add(StartDate_nvc);

                SqlParameter EndDate_nvc = new SqlParameter();
                EndDate_nvc.ParameterName = "@EndDate_nvc";
                EndDate_nvc.SqlDbType = SqlDbType.NVarChar;
                EndDate_nvc.Direction = ParameterDirection.Input;
                EndDate_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EndDate_nvc))
                {
                    EndDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    EndDate_nvc.Value = businessObject.EndDate_nvc;
                }
                this.Command.Parameters.Add(EndDate_nvc);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                Date_nvc.Value = businessObject.Date_nvc;
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Time_nvc = new SqlParameter();
                Time_nvc.ParameterName = "@Time_nvc";
                Time_nvc.SqlDbType = SqlDbType.NVarChar;
                Time_nvc.Direction = ParameterDirection.Input;
                Time_nvc.IsNullable = false;
                Time_nvc.Value = businessObject.Time_nvc;
                this.Command.Parameters.Add(Time_nvc);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);


                SqlParameter pk_NewsID_bint = new SqlParameter();
                pk_NewsID_bint.ParameterName = "@pk_NewsID_bint";
                pk_NewsID_bint.SqlDbType = SqlDbType.BigInt;
                pk_NewsID_bint.Direction = ParameterDirection.Input;
                pk_NewsID_bint.IsNullable = false;
                pk_NewsID_bint.Value = businessObjectKey.NewsID_bint;
                this.Command.Parameters.Add(pk_NewsID_bint);



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

        public List<HPS.BLL.NewsBLL.BLLNews_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.NewsBLL.BLLNews_T> Result = new List<HPS.BLL.NewsBLL.BLLNews_T>();
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
            this.Command.CommandText = "[sp_News_T_SelectAll]";
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
            this.Command.CommandText = "[sp_News_T_SelectAll]";
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
            this.Command.CommandText = "[sp_News_T_SelectAll]";
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

        public HPS.BLL.NewsBLL.BLLNews_T SelectByPrimaryKey(HPS.BLL.NewsBLL.BLLNews_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NewsID_bint = new SqlParameter();
                NewsID_bint.ParameterName = "@NewsID_bint";
                NewsID_bint.SqlDbType = SqlDbType.BigInt;
                NewsID_bint.Direction = ParameterDirection.Input;
                NewsID_bint.IsNullable = false;
                NewsID_bint.Value = businessObjectKey.NewsID_bint;
                this.Command.Parameters.Add(NewsID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.NewsBLL.BLLNews_T businessObject = new HPS.BLL.NewsBLL.BLLNews_T();
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

        public void SelectByPrimaryKey(HPS.BLL.NewsBLL.BLLNews_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_News_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NewsID_bint = new SqlParameter();
                NewsID_bint.ParameterName = "@NewsID_bint";
                NewsID_bint.SqlDbType = SqlDbType.BigInt;
                NewsID_bint.Direction = ParameterDirection.Input;
                NewsID_bint.IsNullable = false;
                NewsID_bint.Value = businessObjectKey.NewsID_bint;
                this.Command.Parameters.Add(NewsID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.NewsBLL.BLLNews_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_News_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NewsID_bint = new SqlParameter();
                NewsID_bint.ParameterName = "@NewsID_bint";
                NewsID_bint.SqlDbType = SqlDbType.BigInt;
                NewsID_bint.Direction = ParameterDirection.Input;
                NewsID_bint.IsNullable = false;
                NewsID_bint.Value = businessObjectKey.NewsID_bint;
                this.Command.Parameters.Add(NewsID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.NewsBLL.BLLNews_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_News_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NewsID_bint = new SqlParameter();
                NewsID_bint.ParameterName = "@NewsID_bint";
                NewsID_bint.SqlDbType = SqlDbType.BigInt;
                NewsID_bint.Direction = ParameterDirection.Input;
                NewsID_bint.IsNullable = false;
                NewsID_bint.Value = businessObjectKey.NewsID_bint;
                this.Command.Parameters.Add(NewsID_bint);



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





        public List<HPS.BLL.NewsBLL.BLLNews_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[News_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.NewsBLL.BLLNews_T> Result = new List<HPS.BLL.NewsBLL.BLLNews_T>();
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
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[News_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[News_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[News_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.NewsBLL.BLLNews_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
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
                List<HPS.BLL.NewsBLL.BLLNews_T> Result = new List<HPS.BLL.NewsBLL.BLLNews_T>();
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
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_News_T_SelectCondition]";
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

        public void Delete(HPS.BLL.NewsBLL.BLLNews_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_News_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter NewsID_bint = new SqlParameter();
                NewsID_bint.ParameterName = "@NewsID_bint";
                NewsID_bint.SqlDbType = SqlDbType.BigInt;
                NewsID_bint.Direction = ParameterDirection.Input;
                NewsID_bint.IsNullable = false;
                NewsID_bint.Value = businessObjectKey.NewsID_bint;
                this.Command.Parameters.Add(NewsID_bint);


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
            this.Command.CommandText = "[sp_News_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.NewsBLL.BLLNews_T businessObject, IDataReader dataReader)
        {
            businessObject.NewsID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.NewsID_bint.ToString()));
            businessObject.Title_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.Title_nvc.ToString()));
            businessObject.News_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.News_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.StartDate_nvc.ToString())) == false)
            {
                businessObject.StartDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.StartDate_nvc.ToString()));
            }
            else
            {
                businessObject.StartDate_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.EndDate_nvc.ToString())) == false)
            {
                businessObject.EndDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.EndDate_nvc.ToString()));
            }
            else
            {
                businessObject.EndDate_nvc = String.Empty;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.Time_nvc.ToString()));
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.NewsBLL.BLLNews_T.News_TField.UserName_nvc.ToString()));
        }

        public List<HPS.BLL.NewsBLL.BLLNews_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.NewsBLL.BLLNews_T> list = new List<HPS.BLL.NewsBLL.BLLNews_T>();
            while (dataReader.Read())
            {
                HPS.BLL.NewsBLL.BLLNews_T businessObject = new HPS.BLL.NewsBLL.BLLNews_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}