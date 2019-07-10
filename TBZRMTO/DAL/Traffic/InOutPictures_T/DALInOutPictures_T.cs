using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL
{
    public partial class DALInOutPictures_T : DataLayerBase
    {

        public DALInOutPictures_T()
            : base(HPS.BLL.CameraConnection.DefaultConnectionString)
        {
        }

        public void Insert(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutPicturesID_bint = new SqlParameter();
                inOutPicturesID_bint.ParameterName = "@inOutPicturesID_bint";
                inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                inOutPicturesID_bint.Direction = ParameterDirection.Output;
                inOutPicturesID_bint.IsNullable = false;
                inOutPicturesID_bint.Value = businessObject.inOutPicturesID_bint;
                this.Command.Parameters.Add(inOutPicturesID_bint);

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObject.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);

                SqlParameter picture_vbnry = new SqlParameter();
                picture_vbnry.ParameterName = "@picture_vbnry";
                picture_vbnry.SqlDbType = SqlDbType.VarBinary;
                picture_vbnry.Direction = ParameterDirection.Input;
                picture_vbnry.IsNullable = false;
                picture_vbnry.Value = businessObject.picture_vbnry;
                this.Command.Parameters.Add(picture_vbnry);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.inOutPicturesID_bint = (Int64)(this.Command.Parameters["@inOutPicturesID_bint"].Value);

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

        public void Update(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T businessObject, HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutID_bint = new SqlParameter();
                inOutID_bint.ParameterName = "@inOutID_bint";
                inOutID_bint.SqlDbType = SqlDbType.BigInt;
                inOutID_bint.Direction = ParameterDirection.Input;
                inOutID_bint.IsNullable = false;
                inOutID_bint.Value = businessObject.inOutID_bint;
                this.Command.Parameters.Add(inOutID_bint);

                SqlParameter picture_vbnry = new SqlParameter();
                picture_vbnry.ParameterName = "@picture_vbnry";
                picture_vbnry.SqlDbType = SqlDbType.VarBinary;
                picture_vbnry.Direction = ParameterDirection.Input;
                picture_vbnry.IsNullable = false;
                picture_vbnry.Value = businessObject.picture_vbnry;
                this.Command.Parameters.Add(picture_vbnry);


                SqlParameter pk_inOutPicturesID_bint = new SqlParameter();
                pk_inOutPicturesID_bint.ParameterName = "@pk_inOutPicturesID_bint";
                pk_inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                pk_inOutPicturesID_bint.Direction = ParameterDirection.Input;
                pk_inOutPicturesID_bint.IsNullable = false;
                pk_inOutPicturesID_bint.Value = businessObjectKey.inOutPicturesID_bint;
                this.Command.Parameters.Add(pk_inOutPicturesID_bint);



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

        public List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> Result = new List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T>();
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectAll]";
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectAll]";
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectAll]";
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

        public HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T SelectByPrimaryKey(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutPicturesID_bint = new SqlParameter();
                inOutPicturesID_bint.ParameterName = "@inOutPicturesID_bint";
                inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                inOutPicturesID_bint.Direction = ParameterDirection.Input;
                inOutPicturesID_bint.IsNullable = false;
                inOutPicturesID_bint.Value = businessObjectKey.inOutPicturesID_bint;
                this.Command.Parameters.Add(inOutPicturesID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T businessObject = new HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T();
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

        public void SelectByPrimaryKey(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutPicturesID_bint = new SqlParameter();
                inOutPicturesID_bint.ParameterName = "@inOutPicturesID_bint";
                inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                inOutPicturesID_bint.Direction = ParameterDirection.Input;
                inOutPicturesID_bint.IsNullable = false;
                inOutPicturesID_bint.Value = businessObjectKey.inOutPicturesID_bint;
                this.Command.Parameters.Add(inOutPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutPicturesID_bint = new SqlParameter();
                inOutPicturesID_bint.ParameterName = "@inOutPicturesID_bint";
                inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                inOutPicturesID_bint.Direction = ParameterDirection.Input;
                inOutPicturesID_bint.IsNullable = false;
                inOutPicturesID_bint.Value = businessObjectKey.inOutPicturesID_bint;
                this.Command.Parameters.Add(inOutPicturesID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutPicturesID_bint = new SqlParameter();
                inOutPicturesID_bint.ParameterName = "@inOutPicturesID_bint";
                inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                inOutPicturesID_bint.Direction = ParameterDirection.Input;
                inOutPicturesID_bint.IsNullable = false;
                inOutPicturesID_bint.Value = businessObjectKey.inOutPicturesID_bint;
                this.Command.Parameters.Add(inOutPicturesID_bint);



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





        public List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOutPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> Result = new List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T>();
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOutPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOutPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[InOutPictures_T]." + fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

        public List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
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
                List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> Result = new List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T>();
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_InOutPictures_T_SelectCondition]";
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

        public void Delete(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_InOutPictures_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter inOutPicturesID_bint = new SqlParameter();
                inOutPicturesID_bint.ParameterName = "@inOutPicturesID_bint";
                inOutPicturesID_bint.SqlDbType = SqlDbType.BigInt;
                inOutPicturesID_bint.Direction = ParameterDirection.Input;
                inOutPicturesID_bint.IsNullable = false;
                inOutPicturesID_bint.Value = businessObjectKey.inOutPicturesID_bint;
                this.Command.Parameters.Add(inOutPicturesID_bint);


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
            this.Command.CommandText = "[sp_InOutPictures_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T businessObject, IDataReader dataReader)
        {
            try
            {
                businessObject.inOutPicturesID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T.InOutPictures_TField.inOutPicturesID_bint.ToString()));
                businessObject.inOutID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T.InOutPictures_TField.inOutID_bint.ToString()));
                businessObject.picture_vbnry = (Byte[])dataReader.GetValue(dataReader.GetOrdinal(HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T.InOutPictures_TField.picture_vbnry.ToString()));
            }
            catch (System.Exception ex)
            {
                dataReader.Close();
                throw ex;
            }
        }

        public List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            try
            {
                List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T> list = new List<HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T>();
                while (dataReader.Read())
                {
                    HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T businessObject = new HPS.BLL.InOutPicturesBLL.BLLInOutPictures_T();
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