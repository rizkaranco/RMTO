using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HPS.DAL.Common
{
    class DALBackUp//:DataLayerMain.DataLayerBase
    {
        public DALBackUp()
            //: base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
       
        }
        public void BackUp(string FilePath)
        {
            SqlConnection con = new SqlConnection(Hepsa.Core.Common.ConnectionString.ConnectionString);
            SqlCommand Command = new SqlCommand();
            Command.CommandText = "[sp_RmtoBackup]";
            Command.CommandType = CommandType.StoredProcedure;
            try
            {
                Command.Parameters.Clear();
                SqlParameter BackUpPath = new SqlParameter();
                BackUpPath.ParameterName = "@BackUpPath";
                BackUpPath.SqlDbType = SqlDbType.NVarChar;
                BackUpPath.Direction = ParameterDirection.Input;
                BackUpPath.IsNullable = false;
                BackUpPath.Value = FilePath;
                Command.Parameters.Add(BackUpPath);
                Command.Connection = con;
                con.Open();
                Command.CommandTimeout = 100000;
                Command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Restore(string FileName)
        {
            SqlConnection con = new SqlConnection(Hepsa.Core.Common.ConnectionString.ConnectionString);
            SqlCommand Command = new SqlCommand();
            Command.CommandText = "ALTER DATABASE TBZRMTODB SET SINGLE_USER WITH ROLLBACK IMMEDIATE" + " USE master; RESTORE DATABASE TBZRMTODB FROM DISK =N'" + FileName + "'";
            Command.CommandType = CommandType.Text;
            try
            {
                Command.Parameters.Clear();
                Command.Connection = con;
                con.Open();
                Command.CommandTimeout = 180000;
                Command.ExecuteNonQuery();
                Command.CommandText = "ALTER DATABASE TBZRMTODB SET MULTI_USER WITH ROLLBACK IMMEDIATE" + " USE TBZRMTODB;";

                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
