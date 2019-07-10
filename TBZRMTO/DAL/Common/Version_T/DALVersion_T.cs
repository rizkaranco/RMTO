using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using HPS.DAL.DataLayerMain;

namespace HPS.DAL.VersionDAL
{
    class DALVersion_T: DataLayerBase
    {

        public DALVersion_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.VersionBLL.BLLVersion_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Version_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter VersionID_int = new SqlParameter();
                VersionID_int.ParameterName = "@VersionID_int";
                VersionID_int.SqlDbType = SqlDbType.Int;
                VersionID_int.Direction = ParameterDirection.Output;
                VersionID_int.IsNullable = false;
                this.Command.Parameters.Add(VersionID_int);

                SqlParameter Version_nvc = new SqlParameter();
                Version_nvc.ParameterName = "@Version_nvc";
                Version_nvc.SqlDbType = SqlDbType.NVarChar;
                Version_nvc.Direction = ParameterDirection.Input;
                Version_nvc.IsNullable = false;
                Version_nvc.Value = businessObject.Version_nvc;
                this.Command.Parameters.Add(Version_nvc);

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


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.VersionID_int = (Int32?)(this.Command.Parameters["@VersionID_int"].Value);

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

        public void SelectLastOldVersion(out string Version_nvc)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Version_T_SelectLastVersion]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                SqlParameter Version_nvcParam = new SqlParameter();
                Version_nvcParam.ParameterName = "@Version_nvc";
                Version_nvcParam.SqlDbType = SqlDbType.NVarChar;
                Version_nvcParam.Direction = ParameterDirection.Output;
                Version_nvcParam.Size = 40;
                Version_nvcParam.IsNullable = false;
                this.Command.Parameters.Add(Version_nvcParam);

                Version_nvc = string.Empty;
                this.Command.ExecuteNonQuery();
                Version_nvc = (string)Hepsa.Core.Common.PersentationController.GetEntityValue(Version_nvcParam.Value, TypeCode.String);


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

        public void PopulateBusinessObjectFromReader(HPS.BLL.VersionBLL.BLLVersion_T businessObject, IDataReader dataReader)
        {
            businessObject.VersionID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.VersionBLL.BLLVersion_T.Version_TField.VersionID_int.ToString()));
            businessObject.Version_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VersionBLL.BLLVersion_T.Version_TField.Version_nvc.ToString()));
            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VersionBLL.BLLVersion_T.Version_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.VersionBLL.BLLVersion_T.Version_TField.Time_nvc.ToString()));
        }

        public List<HPS.BLL.VersionBLL.BLLVersion_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.VersionBLL.BLLVersion_T> list = new List<HPS.BLL.VersionBLL.BLLVersion_T>();
            while (dataReader.Read())
            {
                HPS.BLL.VersionBLL.BLLVersion_T businessObject = new HPS.BLL.VersionBLL.BLLVersion_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }


    }
}
