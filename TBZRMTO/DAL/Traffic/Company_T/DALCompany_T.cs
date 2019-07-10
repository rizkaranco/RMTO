using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CompanyDAL
{
    class DALCompany_T : DataLayerBase
    {

        public DALCompany_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.CompanyBLL.BLLCompany_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Output;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObject.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter CompanyCode_nvc = new SqlParameter();
                CompanyCode_nvc.ParameterName = "@CompanyCode_nvc";
                CompanyCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyCode_nvc.Direction = ParameterDirection.Input;
                CompanyCode_nvc.IsNullable = false;
                CompanyCode_nvc.Value = businessObject.CompanyCode_nvc;
                this.Command.Parameters.Add(CompanyCode_nvc);

                SqlParameter Company_nvc = new SqlParameter();
                Company_nvc.ParameterName = "@Company_nvc";
                Company_nvc.SqlDbType = SqlDbType.NVarChar;
                Company_nvc.Direction = ParameterDirection.Input;
                Company_nvc.IsNullable = false;
                Company_nvc.Value = businessObject.Company_nvc;
                this.Command.Parameters.Add(Company_nvc);

                SqlParameter DirectorName_nvc = new SqlParameter();
                DirectorName_nvc.ParameterName = "@DirectorName_nvc";
                DirectorName_nvc.SqlDbType = SqlDbType.NVarChar;
                DirectorName_nvc.Direction = ParameterDirection.Input;
                DirectorName_nvc.IsNullable = false;
                DirectorName_nvc.Value = businessObject.DirectorName_nvc;
                this.Command.Parameters.Add(DirectorName_nvc);

                SqlParameter DirectorMobile_nvc = new SqlParameter();
                DirectorMobile_nvc.ParameterName = "@DirectorMobile_nvc";
                DirectorMobile_nvc.SqlDbType = SqlDbType.NVarChar;
                DirectorMobile_nvc.Direction = ParameterDirection.Input;
                DirectorMobile_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.DirectorMobile_nvc))
                {
                    DirectorMobile_nvc.Value = DBNull.Value;
                }
                else
                {
                    DirectorMobile_nvc.Value = businessObject.DirectorMobile_nvc;
                }
                this.Command.Parameters.Add(DirectorMobile_nvc);

                SqlParameter Phone_nvc = new SqlParameter();
                Phone_nvc.ParameterName = "@Phone_nvc";
                Phone_nvc.SqlDbType = SqlDbType.NVarChar;
                Phone_nvc.Direction = ParameterDirection.Input;
                Phone_nvc.IsNullable = false;
                Phone_nvc.Value = businessObject.Phone_nvc;
                this.Command.Parameters.Add(Phone_nvc);

                SqlParameter Fax_nvc = new SqlParameter();
                Fax_nvc.ParameterName = "@Fax_nvc";
                Fax_nvc.SqlDbType = SqlDbType.NVarChar;
                Fax_nvc.Direction = ParameterDirection.Input;
                Fax_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Fax_nvc))
                {
                    Fax_nvc.Value = DBNull.Value;
                }
                else
                {
                    Fax_nvc.Value = businessObject.Fax_nvc;
                }
                this.Command.Parameters.Add(Fax_nvc);

                SqlParameter Email_nvc = new SqlParameter();
                Email_nvc.ParameterName = "@Email_nvc";
                Email_nvc.SqlDbType = SqlDbType.NVarChar;
                Email_nvc.Direction = ParameterDirection.Input;
                Email_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Email_nvc))
                {
                    Email_nvc.Value = DBNull.Value;
                }
                else
                {
                    Email_nvc.Value = businessObject.Email_nvc;
                }
                this.Command.Parameters.Add(Email_nvc);

                SqlParameter WebAddress_nvc = new SqlParameter();
                WebAddress_nvc.ParameterName = "@WebAddress_nvc";
                WebAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                WebAddress_nvc.Direction = ParameterDirection.Input;
                WebAddress_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.WebAddress_nvc))
                {
                    WebAddress_nvc.Value = DBNull.Value;
                }
                else
                {
                    WebAddress_nvc.Value = businessObject.WebAddress_nvc;
                }
                this.Command.Parameters.Add(WebAddress_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = false;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

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

                SqlParameter Address_nvc = new SqlParameter();
                Address_nvc.ParameterName = "@Address_nvc";
                Address_nvc.SqlDbType = SqlDbType.NVarChar;
                Address_nvc.Direction = ParameterDirection.Input;
                Address_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Address_nvc))
                {
                    Address_nvc.Value = DBNull.Value;
                }
                else
                {
                    Address_nvc.Value = businessObject.Address_nvc;
                }
                this.Command.Parameters.Add(Address_nvc);

                SqlParameter CityID_int = new SqlParameter();
                CityID_int.ParameterName = "@CityID_int";
                CityID_int.SqlDbType = SqlDbType.Int;
                CityID_int.Direction = ParameterDirection.Input;
                CityID_int.IsNullable = true;
                if (businessObject.CityID_int.HasValue == false)
                {
                    CityID_int.Value = DBNull.Value;
                }
                else
                {
                    CityID_int.Value = businessObject.CityID_int;
                }
                this.Command.Parameters.Add(CityID_int);

                SqlParameter CityCode_nvc = new SqlParameter();
                CityCode_nvc.ParameterName = "@CityCode_nvc";
                CityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CityCode_nvc.Direction = ParameterDirection.Input;
                CityCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CityCode_nvc))
                {
                    CityCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CityCode_nvc.Value = businessObject.CityCode_nvc;
                }
                this.Command.Parameters.Add(CityCode_nvc);


                SqlParameter GroupID_intParam = new SqlParameter();
                GroupID_intParam.ParameterName = "@GroupID_int";
                GroupID_intParam.SqlDbType = SqlDbType.Int;
                GroupID_intParam.Direction = ParameterDirection.Input;
                GroupID_intParam.IsNullable = true;
                if (!businessObject.GroupID_int.HasValue)
                {
                    GroupID_intParam.Value = DBNull.Value;
                }
                else
                {
                    GroupID_intParam.Value = businessObject.GroupID_int;
                }
                this.Command.Parameters.Add(GroupID_intParam);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.CompanyID_int = (Int32)(this.Command.Parameters["@CompanyID_int"].Value);

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

        public void Update(HPS.BLL.CompanyBLL.BLLCompany_T businessObject, HPS.BLL.CompanyBLL.BLLCompany_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyCode_nvc = new SqlParameter();
                CompanyCode_nvc.ParameterName = "@CompanyCode_nvc";
                CompanyCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CompanyCode_nvc.Direction = ParameterDirection.Input;
                CompanyCode_nvc.IsNullable = false;
                CompanyCode_nvc.Value = businessObject.CompanyCode_nvc;
                this.Command.Parameters.Add(CompanyCode_nvc);

                SqlParameter Company_nvc = new SqlParameter();
                Company_nvc.ParameterName = "@Company_nvc";
                Company_nvc.SqlDbType = SqlDbType.NVarChar;
                Company_nvc.Direction = ParameterDirection.Input;
                Company_nvc.IsNullable = false;
                Company_nvc.Value = businessObject.Company_nvc;
                this.Command.Parameters.Add(Company_nvc);

                SqlParameter DirectorName_nvc = new SqlParameter();
                DirectorName_nvc.ParameterName = "@DirectorName_nvc";
                DirectorName_nvc.SqlDbType = SqlDbType.NVarChar;
                DirectorName_nvc.Direction = ParameterDirection.Input;
                DirectorName_nvc.IsNullable = false;
                DirectorName_nvc.Value = businessObject.DirectorName_nvc;
                this.Command.Parameters.Add(DirectorName_nvc);

                SqlParameter DirectorMobile_nvc = new SqlParameter();
                DirectorMobile_nvc.ParameterName = "@DirectorMobile_nvc";
                DirectorMobile_nvc.SqlDbType = SqlDbType.NVarChar;
                DirectorMobile_nvc.Direction = ParameterDirection.Input;
                DirectorMobile_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.DirectorMobile_nvc))
                {
                    DirectorMobile_nvc.Value = DBNull.Value;
                }
                else
                {
                    DirectorMobile_nvc.Value = businessObject.DirectorMobile_nvc;
                }
                this.Command.Parameters.Add(DirectorMobile_nvc);

                SqlParameter Phone_nvc = new SqlParameter();
                Phone_nvc.ParameterName = "@Phone_nvc";
                Phone_nvc.SqlDbType = SqlDbType.NVarChar;
                Phone_nvc.Direction = ParameterDirection.Input;
                Phone_nvc.IsNullable = true;
                Phone_nvc.Value = businessObject.Phone_nvc;
                this.Command.Parameters.Add(Phone_nvc);

                SqlParameter Fax_nvc = new SqlParameter();
                Fax_nvc.ParameterName = "@Fax_nvc";
                Fax_nvc.SqlDbType = SqlDbType.NVarChar;
                Fax_nvc.Direction = ParameterDirection.Input;
                Fax_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.Fax_nvc))
                {
                    Fax_nvc.Value = DBNull.Value;
                }
                else
                {
                    Fax_nvc.Value = businessObject.Fax_nvc;
                }
                this.Command.Parameters.Add(Fax_nvc);

                SqlParameter Email_nvc = new SqlParameter();
                Email_nvc.ParameterName = "@Email_nvc";
                Email_nvc.SqlDbType = SqlDbType.NVarChar;
                Email_nvc.Direction = ParameterDirection.Input;
                Email_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Email_nvc))
                {
                    Email_nvc.Value = DBNull.Value;
                }
                else
                {
                    Email_nvc.Value = businessObject.Email_nvc;
                }
                this.Command.Parameters.Add(Email_nvc);

                SqlParameter WebAddress_nvc = new SqlParameter();
                WebAddress_nvc.ParameterName = "@WebAddress_nvc";
                WebAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                WebAddress_nvc.Direction = ParameterDirection.Input;
                WebAddress_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.WebAddress_nvc))
                {
                    WebAddress_nvc.Value = DBNull.Value;
                }
                else
                {
                    WebAddress_nvc.Value = businessObject.WebAddress_nvc;
                }
                this.Command.Parameters.Add(WebAddress_nvc);

                SqlParameter Active_bit = new SqlParameter();
                Active_bit.ParameterName = "@Active_bit";
                Active_bit.SqlDbType = SqlDbType.Bit;
                Active_bit.Direction = ParameterDirection.Input;
                Active_bit.IsNullable = true;
                Active_bit.Value = businessObject.Active_bit;
                this.Command.Parameters.Add(Active_bit);

                SqlParameter InfractionGroupID_int = new SqlParameter();
                InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
                InfractionGroupID_int.SqlDbType = SqlDbType.Int;
                InfractionGroupID_int.Direction = ParameterDirection.Input;
                InfractionGroupID_int.IsNullable = false;
                if (businessObject.InfractionGroupID_int.HasValue == false)
                {
                    InfractionGroupID_int.Value = DBNull.Value;
                }
                else
                {
                    InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
                }
                this.Command.Parameters.Add(InfractionGroupID_int);

                SqlParameter Address_nvc = new SqlParameter();
                Address_nvc.ParameterName = "@Address_nvc";
                Address_nvc.SqlDbType = SqlDbType.NVarChar;
                Address_nvc.Direction = ParameterDirection.Input;
                Address_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Address_nvc))
                {
                    Address_nvc.Value = DBNull.Value;
                }
                else
                {
                    Address_nvc.Value = businessObject.Address_nvc;
                }
                this.Command.Parameters.Add(Address_nvc);

                SqlParameter CityID_int = new SqlParameter();
                CityID_int.ParameterName = "@CityID_int";
                CityID_int.SqlDbType = SqlDbType.Int;
                CityID_int.Direction = ParameterDirection.Input;
                CityID_int.IsNullable = true;
                if (businessObject.CityID_int.HasValue == false)
                {
                    CityID_int.Value = DBNull.Value;
                }
                else
                {
                    CityID_int.Value = businessObject.CityID_int;
                }
                this.Command.Parameters.Add(CityID_int);

                SqlParameter CityCode_nvc = new SqlParameter();
                CityCode_nvc.ParameterName = "@CityCode_nvc";
                CityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CityCode_nvc.Direction = ParameterDirection.Input;
                CityCode_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.CityCode_nvc))
                {
                    CityCode_nvc.Value = DBNull.Value;
                }
                else
                {
                    CityCode_nvc.Value = businessObject.CityCode_nvc;
                }
                this.Command.Parameters.Add(CityCode_nvc);


                SqlParameter pk_CompanyID_int = new SqlParameter();
                pk_CompanyID_int.ParameterName = "@pk_CompanyID_int";
                pk_CompanyID_int.SqlDbType = SqlDbType.Int;
                pk_CompanyID_int.Direction = ParameterDirection.Input;
                pk_CompanyID_int.IsNullable = false;
                pk_CompanyID_int.Value = businessObjectKey.CompanyID_int;
                this.Command.Parameters.Add(pk_CompanyID_int);


                SqlParameter GroupID_intParam = new SqlParameter();
                GroupID_intParam.ParameterName = "@GroupID_int";
                GroupID_intParam.SqlDbType = SqlDbType.Int;
                GroupID_intParam.Direction = ParameterDirection.Input;
                GroupID_intParam.IsNullable = true;
                if (!businessObject.GroupID_int.HasValue)
                {
                    GroupID_intParam.Value = DBNull.Value;
                }
                else
                {
                    GroupID_intParam.Value = businessObject.GroupID_int;
                }
                this.Command.Parameters.Add(GroupID_intParam);


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

        public List<HPS.BLL.CompanyBLL.BLLCompany_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CompanyBLL.BLLCompany_T> Result = new List<HPS.BLL.CompanyBLL.BLLCompany_T>();
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
            this.Command.CommandText = "[sp_Company_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Company_T_SelectAll]";
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
            this.Command.CommandText = "[sp_Company_T_SelectAll]";
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

        public HPS.BLL.CompanyBLL.BLLCompany_T SelectByPrimaryKey(HPS.BLL.CompanyBLL.BLLCompany_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObjectKey.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.CompanyBLL.BLLCompany_T businessObject = new HPS.BLL.CompanyBLL.BLLCompany_T();
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

        public void SelectByPrimaryKey(HPS.BLL.CompanyBLL.BLLCompany_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Company_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObjectKey.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CompanyBLL.BLLCompany_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Company_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObjectKey.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);


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

        public void SelectByPrimaryKey(HPS.BLL.CompanyBLL.BLLCompany_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Company_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObjectKey.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);



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

        public List<HPS.BLL.CompanyBLL.BLLCompany_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Company_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.CompanyBLL.BLLCompany_T> Result = new List<HPS.BLL.CompanyBLL.BLLCompany_T>();
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
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Company_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Company_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Company_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.CompanyBLL.BLLCompany_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
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
                List<HPS.BLL.CompanyBLL.BLLCompany_T> Result = new List<HPS.BLL.CompanyBLL.BLLCompany_T>();
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
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_Company_T_SelectCondition]";
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

        public void Delete(HPS.BLL.CompanyBLL.BLLCompany_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObjectKey.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);


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
            this.Command.CommandText = "[sp_Company_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.CompanyBLL.BLLCompany_T businessObject, IDataReader dataReader)
        {
            businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString()));
            businessObject.CompanyCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyCode_nvc.ToString()));
            businessObject.Company_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString()));
            businessObject.DirectorName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorMobile_nvc.ToString())) == false)
            {
                businessObject.DirectorMobile_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.DirectorMobile_nvc.ToString()));
            }
            else
            {
                businessObject.DirectorMobile_nvc = String.Empty;
            }

            businessObject.Phone_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Phone_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Fax_nvc.ToString())) == false)
            {
                businessObject.Fax_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Fax_nvc.ToString()));
            }
            else
            {
                businessObject.Fax_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Email_nvc.ToString())) == false)
            {
                businessObject.Email_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Email_nvc.ToString()));
            }
            else
            {
                businessObject.Email_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.WebAddress_nvc.ToString())) == false)
            {
                businessObject.WebAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.WebAddress_nvc.ToString()));
            }
            else
            {
                businessObject.WebAddress_nvc = String.Empty;
            }

            businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Active_bit.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.InfractionGroupID_int.ToString())) == false)
            {
                businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.InfractionGroupID_int.ToString()));
            }
            else
            {
                businessObject.InfractionGroupID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Address_nvc.ToString())) == false)
            {
                businessObject.Address_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Address_nvc.ToString()));
            }
            else
            {
                businessObject.Address_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityID_int.ToString())) == false)
            {
                businessObject.CityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityID_int.ToString()));
            }
            else
            {
                businessObject.CityID_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityCode_nvc.ToString())) == false)
            {
                businessObject.CityCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CityCode_nvc.ToString()));
            }
            else
            {
                businessObject.CityCode_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.GroupID_int.ToString())) == false)
            {
                businessObject.GroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.GroupID_int.ToString()));
            }
            else
            {
                businessObject.GroupID_int = null;
            }

        }

        public List<HPS.BLL.CompanyBLL.BLLCompany_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.CompanyBLL.BLLCompany_T> list = new List<HPS.BLL.CompanyBLL.BLLCompany_T>();
            while (dataReader.Read())
            {
                HPS.BLL.CompanyBLL.BLLCompany_T businessObject = new HPS.BLL.CompanyBLL.BLLCompany_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        public void TransferData(string SourcePath, string SourceTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Company_T_TransferData]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@SourcePath", SourcePath));
                this.Command.Parameters.Add(new SqlParameter("@SourceTable", SourceTable));

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
    }
}