using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DALOutCameraPictures
{
    public partial class DALOutCameraPictures_T : DataLayerBase
    {

        public DALOutCameraPictures_T()
            : base(HPS.BLL.CameraConnection.DefaultConnectionString)
        {
        }

        public void Insert(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Output;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObject.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);

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

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = true;
                if (businessObject.TrafficID_bint.HasValue == false)
                {
                    TrafficID_bint.Value = DBNull.Value;
                }
                else
                {
                    TrafficID_bint.Value = businessObject.TrafficID_bint;
                }
                this.Command.Parameters.Add(TrafficID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();
                businessObject.OutCameraPicturesID_bint = (Int64)(this.Command.Parameters["@OutCameraPicturesID_bint"].Value);

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

        public void Update(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T businessObject, HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObject.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);

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

                SqlParameter TrafficID_bint = new SqlParameter();
                TrafficID_bint.ParameterName = "@TrafficID_bint";
                TrafficID_bint.SqlDbType = SqlDbType.BigInt;
                TrafficID_bint.Direction = ParameterDirection.Input;
                TrafficID_bint.IsNullable = true;
                if (businessObject.TrafficID_bint.HasValue == false)
                {
                    TrafficID_bint.Value = DBNull.Value;
                }
                else
                {
                    TrafficID_bint.Value = businessObject.TrafficID_bint;
                }
                this.Command.Parameters.Add(TrafficID_bint);


                SqlParameter pk_OutCameraPicturesID_bint = new SqlParameter();
                pk_OutCameraPicturesID_bint.ParameterName = "@pk_OutCameraPicturesID_bint";
                pk_OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                pk_OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                pk_OutCameraPicturesID_bint.IsNullable = false;
                pk_OutCameraPicturesID_bint.Value = businessObjectKey.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(pk_OutCameraPicturesID_bint);



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

        public List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> Result = new List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T>();
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectAll]";
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectAll]";
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

        public HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T SelectByPrimaryKey(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObjectKey.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T businessObject = new HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T();
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

        public void SelectByPrimaryKey(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObjectKey.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObjectKey.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObjectKey.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);



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





        public List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OutCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> Result = new List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T>();
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OutCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OutCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[OutCameraPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
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
                List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> Result = new List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T>();
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_OutCameraPictures_T_SelectCondition]";
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

        public void Delete(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_OutCameraPictures_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter OutCameraPicturesID_bint = new SqlParameter();
                OutCameraPicturesID_bint.ParameterName = "@OutCameraPicturesID_bint";
                OutCameraPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                OutCameraPicturesID_bint.Direction = ParameterDirection.Input;
                OutCameraPicturesID_bint.IsNullable = false;
                OutCameraPicturesID_bint.Value = businessObjectKey.OutCameraPicturesID_bint;
                this.Command.Parameters.Add(OutCameraPicturesID_bint);


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
            this.Command.CommandText = "[sp_OutCameraPictures_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.OutCameraPicturesID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.OutCameraPicturesID_bint.ToString()));
                businessObject.Date_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.Date_vc.ToString()));
                businessObject.Time_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.Time_vc.ToString()));
                businessObject.Picture_img = (Byte[])dataReader.GetValue(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.Picture_img.ToString()));
                businessObject.PlateNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.PlateNumber_nvc.ToString()));
                businessObject.PlateSerial_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.PlateSerial_vc.ToString()));
                if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.TrafficID_bint.ToString())) == false)
                {
                    businessObject.TrafficID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T.OutCameraPictures_TField.TrafficID_bint.ToString()));
                }
                else
                {
                    businessObject.TrafficID_bint = null;
                }

            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T> list = new List<HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T businessObject = new HPS.BLL.OutCameraPicturesBLL.BLLOutCameraPictures_T();
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