using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.UserDAL
{
    class DALUser_T : DataLayerBase
    {

        public DALUser_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.UserBLL.BLLUser_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter FullName_nvc = new SqlParameter();
                FullName_nvc.ParameterName = "@FullName_nvc";
                FullName_nvc.SqlDbType = SqlDbType.NVarChar;
                FullName_nvc.Direction = ParameterDirection.Input;
                FullName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.FullName_nvc))
                {
                    FullName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FullName_nvc.Value = businessObject.FullName_nvc;
                }
                this.Command.Parameters.Add(FullName_nvc);

                SqlParameter Password_nvc = new SqlParameter();
                Password_nvc.ParameterName = "@Password_nvc";
                Password_nvc.SqlDbType = SqlDbType.NVarChar;
                Password_nvc.Direction = ParameterDirection.Input;
                Password_nvc.IsNullable = false;
                Password_nvc.Value = businessObject.Password_nvc;
                this.Command.Parameters.Add(Password_nvc);

                SqlParameter StartDate_vc = new SqlParameter();
                StartDate_vc.ParameterName = "@StartDate_vc";
                StartDate_vc.SqlDbType = SqlDbType.VarChar;
                StartDate_vc.Direction = ParameterDirection.Input;
                StartDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.StartDate_vc))
                {
                    StartDate_vc.Value = DBNull.Value;
                }
                else
                {
                    StartDate_vc.Value = businessObject.StartDate_vc;
                }
                this.Command.Parameters.Add(StartDate_vc);

                SqlParameter ExpireDate_vc = new SqlParameter();
                ExpireDate_vc.ParameterName = "@ExpireDate_vc";
                ExpireDate_vc.SqlDbType = SqlDbType.VarChar;
                ExpireDate_vc.Direction = ParameterDirection.Input;
                ExpireDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ExpireDate_vc))
                {
                    ExpireDate_vc.Value = DBNull.Value;
                }
                else
                {
                    ExpireDate_vc.Value = businessObject.ExpireDate_vc;
                }
                this.Command.Parameters.Add(ExpireDate_vc);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = true;
                if (businessObject.UserGroupID_int.HasValue == false)
                {
                    UserGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    UserGroupID_int.Value = businessObject.UserGroupID_int;
                }
                this.Command.Parameters.Add(UserGroupID_int);

                SqlParameter Picture_img = new SqlParameter();
                Picture_img.ParameterName = "@Picture_img";
                Picture_img.SqlDbType = SqlDbType.Image;
                Picture_img.Direction = ParameterDirection.Input;
                Picture_img.IsNullable = true;
                if (businessObject.Picture_img == null || businessObject.Picture_img.Length == 0)
                {
                    Picture_img.Value = DBNull.Value;
                }
                else
                {
                    Picture_img.Value = businessObject.Picture_img;
                }
                this.Command.Parameters.Add(Picture_img);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter CreateDate_nvc = new SqlParameter();
                CreateDate_nvc.ParameterName = "@CreateDate_nvc";
                CreateDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CreateDate_nvc.Direction = ParameterDirection.Input;
                CreateDate_nvc.IsNullable = false;
                CreateDate_nvc.Value = businessObject.CreateDate_nvc;
                this.Command.Parameters.Add(CreateDate_nvc);

                SqlParameter CreateTime_nvc = new SqlParameter();
                CreateTime_nvc.ParameterName = "@CreateTime_nvc";
                CreateTime_nvc.SqlDbType = SqlDbType.NVarChar;
                CreateTime_nvc.Direction = ParameterDirection.Input;
                CreateTime_nvc.IsNullable = false;
                CreateTime_nvc.Value = businessObject.CreateTime_nvc;
                this.Command.Parameters.Add(CreateTime_nvc);

                SqlParameter InfractionGroupID_int = new SqlParameter();
                InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
                InfractionGroupID_int.SqlDbType = SqlDbType.Int;
                InfractionGroupID_int.Direction = ParameterDirection.Input;
                InfractionGroupID_int.IsNullable = true;
                if (businessObject.InfractionGroupID_int.HasValue == false)
                {
                    InfractionGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
                }
                this.Command.Parameters.Add(InfractionGroupID_int);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                if (businessObject.CompanyID_int.HasValue == false)
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = businessObject.CompanyID_int;
                }
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter Mobile_nvc = new SqlParameter();
                Mobile_nvc.ParameterName = "Mobile_nvc";
                Mobile_nvc.Direction = ParameterDirection.Input;
                Mobile_nvc.SqlDbType = SqlDbType.NVarChar;
                Mobile_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Mobile_nvc))
                {
                    Mobile_nvc.Value = DBNull.Value;
                }
                else
                {
                    Mobile_nvc.Value = businessObject.Mobile_nvc;
                }
                this.Command.Parameters.Add(Mobile_nvc);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                //--hp>
                //MultiAccess_bit
                SqlParameter MultiAccess_bit = new SqlParameter();
                MultiAccess_bit.ParameterName = "@MultiAccess_bit";
                MultiAccess_bit.SqlDbType = SqlDbType.Bit;
                MultiAccess_bit.Direction = ParameterDirection.Input;
                MultiAccess_bit.IsNullable = false;
                MultiAccess_bit.Value = businessObject.MultiAccess_bit;
                this.Command.Parameters.Add(MultiAccess_bit);
                //--<hp

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

        public void Update(HPS.BLL.UserBLL.BLLUser_T businessObject, HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter FullName_nvc = new SqlParameter();
                FullName_nvc.ParameterName = "@FullName_nvc";
                FullName_nvc.SqlDbType = SqlDbType.NVarChar;
                FullName_nvc.Direction = ParameterDirection.Input;
                FullName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.FullName_nvc))
                {
                    FullName_nvc.Value = DBNull.Value;
                }
                else
                {
                    FullName_nvc.Value = businessObject.FullName_nvc;
                }
                this.Command.Parameters.Add(FullName_nvc);

                SqlParameter Password_nvc = new SqlParameter();
                Password_nvc.ParameterName = "@Password_nvc";
                Password_nvc.SqlDbType = SqlDbType.NVarChar;
                Password_nvc.Direction = ParameterDirection.Input;
                Password_nvc.IsNullable = false;
                Password_nvc.Value = businessObject.Password_nvc;
                this.Command.Parameters.Add(Password_nvc);

                SqlParameter StartDate_vc = new SqlParameter();
                StartDate_vc.ParameterName = "@StartDate_vc";
                StartDate_vc.SqlDbType = SqlDbType.VarChar;
                StartDate_vc.Direction = ParameterDirection.Input;
                StartDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.StartDate_vc))
                {
                    StartDate_vc.Value = DBNull.Value;
                }
                else
                {
                    StartDate_vc.Value = businessObject.StartDate_vc;
                }
                this.Command.Parameters.Add(StartDate_vc);

                SqlParameter ExpireDate_vc = new SqlParameter();
                ExpireDate_vc.ParameterName = "@ExpireDate_vc";
                ExpireDate_vc.SqlDbType = SqlDbType.VarChar;
                ExpireDate_vc.Direction = ParameterDirection.Input;
                ExpireDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.ExpireDate_vc))
                {
                    ExpireDate_vc.Value = DBNull.Value;
                }
                else
                {
                    ExpireDate_vc.Value = businessObject.ExpireDate_vc;
                }
                this.Command.Parameters.Add(ExpireDate_vc);

                SqlParameter UserGroupID_int = new SqlParameter();
                UserGroupID_int.ParameterName = "@UserGroupID_int";
                UserGroupID_int.SqlDbType = SqlDbType.Int;
                UserGroupID_int.Direction = ParameterDirection.Input;
                UserGroupID_int.IsNullable = true;
                if (businessObject.UserGroupID_int.HasValue == false)
                {
                    UserGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    UserGroupID_int.Value = businessObject.UserGroupID_int;
                }
                this.Command.Parameters.Add(UserGroupID_int);

                SqlParameter Picture_img = new SqlParameter();
                Picture_img.ParameterName = "@Picture_img";
                Picture_img.SqlDbType = SqlDbType.Image;
                Picture_img.Direction = ParameterDirection.Input;
                Picture_img.IsNullable = true;
                if (businessObject.Picture_img == null || businessObject.Picture_img.Length == 0)
                {
                    Picture_img.Value = DBNull.Value;
                }
                else
                {
                    Picture_img.Value = businessObject.Picture_img;
                }
                this.Command.Parameters.Add(Picture_img);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter CreateDate_nvc = new SqlParameter();
                CreateDate_nvc.ParameterName = "@CreateDate_nvc";
                CreateDate_nvc.SqlDbType = SqlDbType.NVarChar;
                CreateDate_nvc.Direction = ParameterDirection.Input;
                CreateDate_nvc.IsNullable = false;
                CreateDate_nvc.Value = businessObject.CreateDate_nvc;
                this.Command.Parameters.Add(CreateDate_nvc);

                SqlParameter CreateTime_nvc = new SqlParameter();
                CreateTime_nvc.ParameterName = "@CreateTime_nvc";
                CreateTime_nvc.SqlDbType = SqlDbType.NVarChar;
                CreateTime_nvc.Direction = ParameterDirection.Input;
                CreateTime_nvc.IsNullable = false;
                CreateTime_nvc.Value = businessObject.CreateTime_nvc;
                this.Command.Parameters.Add(CreateTime_nvc);

                SqlParameter InfractionGroupID_int = new SqlParameter();
                InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
                InfractionGroupID_int.SqlDbType = SqlDbType.Int;
                InfractionGroupID_int.Direction = ParameterDirection.Input;
                InfractionGroupID_int.IsNullable = true;
                if (businessObject.InfractionGroupID_int.HasValue == false)
                {
                    InfractionGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
                }
                this.Command.Parameters.Add(InfractionGroupID_int);


                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                if (businessObject.CompanyID_int.HasValue == false)
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = businessObject.CompanyID_int;
                }
                this.Command.Parameters.Add(CompanyID_int);


                SqlParameter pk_UserName_nvc = new SqlParameter();
                pk_UserName_nvc.ParameterName = "@pk_UserName_nvc";
                pk_UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                pk_UserName_nvc.Direction = ParameterDirection.Input;
                pk_UserName_nvc.IsNullable = false;
                pk_UserName_nvc.Value = businessObjectKey.UserName_nvc;
                this.Command.Parameters.Add(pk_UserName_nvc);

                SqlParameter Mobile_nvc = new SqlParameter();
                Mobile_nvc.ParameterName = "Mobile_nvc";
                Mobile_nvc.Direction = ParameterDirection.Input;
                Mobile_nvc.SqlDbType = SqlDbType.NVarChar;
                Mobile_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(businessObject.Mobile_nvc))
                {
                    Mobile_nvc.Value = DBNull.Value;
                }
                else
                {
                    Mobile_nvc.Value = businessObject.Mobile_nvc;
                }
                this.Command.Parameters.Add(Mobile_nvc);

                //--hp>
                //MultiAccess_bit
                SqlParameter MultiAccess_bit = new SqlParameter();
                MultiAccess_bit.ParameterName = "@MultiAccess_bit";
                MultiAccess_bit.SqlDbType = SqlDbType.Bit;
                MultiAccess_bit.Direction = ParameterDirection.Input;
                MultiAccess_bit.IsNullable = false;
                MultiAccess_bit.Value = businessObject.MultiAccess_bit;
                this.Command.Parameters.Add(MultiAccess_bit);
                //--<hp


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

        public List<HPS.BLL.UserBLL.BLLUser_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.UserBLL.BLLUser_T> Result = new List<HPS.BLL.UserBLL.BLLUser_T>();
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
            this.Command.CommandText = "[sp_User_T_SelectAll]";
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
            this.Command.CommandText = "[sp_User_T_SelectAll]";
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
            this.Command.CommandText = "[sp_User_T_SelectAll]";
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

        public HPS.BLL.UserBLL.BLLUser_T SelectByPrimaryKey(HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObjectKey.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.UserBLL.BLLUser_T businessObject = new HPS.BLL.UserBLL.BLLUser_T();
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

        public void SelectByPrimaryKey(HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObjectKey.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);


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

        public void SelectByPrimaryKey(HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObjectKey.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);


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

        public void SelectByPrimaryKey(HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObjectKey.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);



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

        public List<HPS.BLL.UserBLL.BLLUser_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.UserBLL.BLLUser_T> Result = new List<HPS.BLL.UserBLL.BLLUser_T>();
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
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.UserBLL.BLLUser_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
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
                List<HPS.BLL.UserBLL.BLLUser_T> Result = new List<HPS.BLL.UserBLL.BLLUser_T>();
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
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_User_T_SelectCondition]";
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

        public void Delete(HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_User_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObjectKey.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);


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
            this.Command.CommandText = "[sp_User_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.UserBLL.BLLUser_T businessObject, IDataReader dataReader)
        {
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.FullName_nvc.ToString())) == false)
            {
                businessObject.FullName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.FullName_nvc.ToString()));
            }
            else
            {
                businessObject.FullName_nvc = String.Empty;
            }

            businessObject.Password_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.Password_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.StartDate_vc.ToString())) == false)
            {
                businessObject.StartDate_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.StartDate_vc.ToString()));
            }
            else
            {
                businessObject.StartDate_vc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.ExpireDate_vc.ToString())) == false)
            {
                businessObject.ExpireDate_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.ExpireDate_vc.ToString()));
            }
            else
            {
                businessObject.ExpireDate_vc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.UserGroupID_int.ToString())) == false)
            {
                businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.UserGroupID_int.ToString()));
            }
            else
            {
                businessObject.UserGroupID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.Picture_img.ToString())) == false)
            {
                businessObject.Picture_img = (Byte[])dataReader.GetValue(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.Picture_img.ToString()));
            }
            else
            {
                businessObject.Picture_img = null;
            }

            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.Active_bit.ToString()));
            businessObject.CreateDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.CreateDate_nvc.ToString()));
            businessObject.CreateTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.CreateTime_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.InfractionGroupID_int.ToString())) == false)
            {
                businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.InfractionGroupID_int.ToString()));
            }
            else
            {
                businessObject.InfractionGroupID_int = null;
            }
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.CompanyID_int.ToString())) == false)
            {
                businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.CompanyID_int.ToString()));
            }
            else
            {
                businessObject.CompanyID_int = null;
            }
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.Mobile_nvc.ToString())) == false)
            {
                businessObject.Mobile_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.Mobile_nvc.ToString()));
            }
            else
            {
                businessObject.Mobile_nvc = string.Empty;
            }
            businessObject.MultiAccess_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.UserBLL.BLLUser_T.User_TField.MultiAccess_bit.ToString()));
        }

        public List<HPS.BLL.UserBLL.BLLUser_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.UserBLL.BLLUser_T> list = new List<HPS.BLL.UserBLL.BLLUser_T>();
            while (dataReader.Read())
            {
                HPS.BLL.UserBLL.BLLUser_T businessObject = new HPS.BLL.UserBLL.BLLUser_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

    }
}