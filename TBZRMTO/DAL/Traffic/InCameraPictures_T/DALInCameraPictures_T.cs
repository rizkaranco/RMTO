using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DALInCameraPictures
{
    public partial class DALInCameraPictures_T : DataLayerBase
    {

        public DALInCameraPictures_T()
            : base(HPS.BLL.CameraConnection.DefaultConnectionString)
        {
        }

        public void Insert(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Output;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObject.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = false;
                Date_vc.Value = businessObject.Date_vc;
                this.Command.Parameters.Add(Date_vc);

                SqlParameter Time_vc = new SqlParameter();
                Time_vc.ParameterName = "@Time_vc";
                Time_vc.SqlDbType = SqlDbType.VarChar;
                Time_vc.Direction = ParameterDirection.Input;
                Time_vc.IsNullable = false;
                Time_vc.Value = businessObject.Time_vc;
                this.Command.Parameters.Add(Time_vc);

                SqlParameter Picture_img = new SqlParameter();
                Picture_img.ParameterName = "@Picture_img";
                Picture_img.SqlDbType = SqlDbType.Image;
                Picture_img.Direction = ParameterDirection.Input;
                Picture_img.IsNullable = false;
                Picture_img.Value = businessObject.Picture_img;
                this.Command.Parameters.Add(Picture_img);

                SqlParameter PlateNumber_nvc = new SqlParameter();
                PlateNumber_nvc.ParameterName = "@PlateNumber_nvc";
                PlateNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateNumber_nvc.Direction = ParameterDirection.Input;
                PlateNumber_nvc.IsNullable = false;
                PlateNumber_nvc.Value = businessObject.PlateNumber_nvc;
                this.Command.Parameters.Add(PlateNumber_nvc);

                SqlParameter PlateSerial_vc = new SqlParameter();
                PlateSerial_vc.ParameterName = "@PlateSerial_vc";
                PlateSerial_vc.SqlDbType = SqlDbType.VarChar;
                PlateSerial_vc.Direction = ParameterDirection.Input;
                PlateSerial_vc.IsNullable = false;
                PlateSerial_vc.Value = businessObject.PlateSerial_vc;
                this.Command.Parameters.Add(PlateSerial_vc);

                SqlParameter TrafficTypeID_int = new SqlParameter();
                TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_int.SqlDbType = SqlDbType.Int;
                TrafficTypeID_int.Direction = ParameterDirection.Input;
                TrafficTypeID_int.IsNullable = true;
                if (businessObject.TrafficTypeID_int.HasValue == false)
                {
                    TrafficTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    TrafficTypeID_int.Value = businessObject.TrafficTypeID_int;
                }
                this.Command.Parameters.Add(TrafficTypeID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.InCameraPicturesID_bint = (Int64)(this.Command.Parameters["@InCameraPicturesID_bint"].Value);
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

        public void Update(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T businessObject, HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObject.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);

                SqlParameter Date_vc = new SqlParameter();
                Date_vc.ParameterName = "@Date_vc";
                Date_vc.SqlDbType = SqlDbType.VarChar;
                Date_vc.Direction = ParameterDirection.Input;
                Date_vc.IsNullable = false;
                Date_vc.Value = businessObject.Date_vc;
                this.Command.Parameters.Add(Date_vc);

                SqlParameter Time_vc = new SqlParameter();
                Time_vc.ParameterName = "@Time_vc";
                Time_vc.SqlDbType = SqlDbType.VarChar;
                Time_vc.Direction = ParameterDirection.Input;
                Time_vc.IsNullable = false;
                Time_vc.Value = businessObject.Time_vc;
                this.Command.Parameters.Add(Time_vc);

                SqlParameter Picture_img = new SqlParameter();
                Picture_img.ParameterName = "@Picture_img";
                Picture_img.SqlDbType = SqlDbType.Image;
                Picture_img.Direction = ParameterDirection.Input;
                Picture_img.IsNullable = false;
                Picture_img.Value = businessObject.Picture_img;
                this.Command.Parameters.Add(Picture_img);

                SqlParameter PlateNumber_nvc = new SqlParameter();
                PlateNumber_nvc.ParameterName = "@PlateNumber_nvc";
                PlateNumber_nvc.SqlDbType = SqlDbType.NVarChar;
                PlateNumber_nvc.Direction = ParameterDirection.Input;
                PlateNumber_nvc.IsNullable = false;
                PlateNumber_nvc.Value = businessObject.PlateNumber_nvc;
                this.Command.Parameters.Add(PlateNumber_nvc);

                SqlParameter PlateSerial_vc = new SqlParameter();
                PlateSerial_vc.ParameterName = "@PlateSerial_vc";
                PlateSerial_vc.SqlDbType = SqlDbType.VarChar;
                PlateSerial_vc.Direction = ParameterDirection.Input;
                PlateSerial_vc.IsNullable = false;
                PlateSerial_vc.Value = businessObject.PlateSerial_vc;
                this.Command.Parameters.Add(PlateSerial_vc);

                SqlParameter TrafficTypeID_int = new SqlParameter();
                TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
                TrafficTypeID_int.SqlDbType = SqlDbType.Int;
                TrafficTypeID_int.Direction = ParameterDirection.Input;
                TrafficTypeID_int.IsNullable = true;
                if (businessObject.TrafficTypeID_int.HasValue == false)
                {
                    TrafficTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    TrafficTypeID_int.Value = businessObject.TrafficTypeID_int;
                }
                this.Command.Parameters.Add(TrafficTypeID_int);


                SqlParameter pk_InCameraPicturesID_bint = new SqlParameter();
                pk_InCameraPicturesID_bint.ParameterName = "@pk_InCameraPicturesID_bint";
                pk_InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                pk_InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                pk_InCameraPicturesID_bint.IsNullable = false;
                pk_InCameraPicturesID_bint.Value = businessObjectKey.InCameraPicturesID_bint;
                this.Command.Parameters.Add(pk_InCameraPicturesID_bint);



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

        public List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> Result = new List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T>();
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectAll]";
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectAll]";
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectAll]";
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

        public HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T SelectByPrimaryKey(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObjectKey.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T businessObject = new HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T();
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

        public void SelectByPrimaryKey(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObjectKey.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObjectKey.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObjectKey.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);



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





        public List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> Result = new List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T>();
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
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
                List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> Result = new List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T>();
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_InCameraPictures_T_SelectCondition]";
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

        public void Delete(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InCameraPictures_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter InCameraPicturesID_bint = new SqlParameter();
                InCameraPicturesID_bint.ParameterName = "@InCameraPicturesID_bint";
                InCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                InCameraPicturesID_bint.Direction = ParameterDirection.Input;
                InCameraPicturesID_bint.IsNullable = false;
                InCameraPicturesID_bint.Value = businessObjectKey.InCameraPicturesID_bint;
                this.Command.Parameters.Add(InCameraPicturesID_bint);


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
            this.Command.CommandText = "[sp_InCameraPictures_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.InCameraPicturesID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.InCameraPicturesID_bint.ToString()));
                businessObject.Date_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.Date_vc.ToString()));
                businessObject.Time_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.Time_vc.ToString()));
                businessObject.Picture_img = (Byte[])dataReader.GetValue(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.Picture_img.ToString()));
                businessObject.PlateNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.PlateNumber_nvc.ToString()));
                businessObject.PlateSerial_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.PlateSerial_vc.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.TrafficTypeID_int.ToString())) == false)
                {
                    businessObject.TrafficTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T.InCameraPictures_TField.TrafficTypeID_int.ToString()));
                }
                else
                {
                    businessObject.TrafficTypeID_int = null;
                }

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T> list = new List<HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T businessObject = new HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_T();
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