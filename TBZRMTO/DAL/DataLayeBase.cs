
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace HPS.DAL.DataLayerMain
{


    public class DataLayerBase : IDisposable
    {
        private string _ConnectionString;
        private static SqlConnection _mainConnection;
        private static SqlTransaction _mainTransaction;
        private static SqlCommand _mainCommand;

        protected SqlConnection Connection
        {
            get
            {
                if (_mainConnection == null)
                    _mainConnection = new System.Data.SqlClient.SqlConnection(_ConnectionString);
                return _mainConnection;
            }
        }

        public System.Data.ConnectionState ConnectionState
        {
            get
            {
                return Connection.State;
            }
        }

        protected SqlCommand Command
        {
            get
            {
                if (_mainCommand == null)
                {
                    _mainCommand = new System.Data.SqlClient.SqlCommand();
                    _mainCommand.Connection = Connection;
                }
                _mainCommand.CommandTimeout = 1000;
                return _mainCommand;
            }
        }

        public DataLayerBase(String ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public void BeginTransaction()
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    _mainTransaction = Connection.BeginTransaction();
                    Command.Transaction = _mainTransaction;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Commit()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    _mainTransaction.Commit();
                    this.Connection.Close();
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                Dispose(true);
            }
        }


        public void RollBack()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    _mainTransaction.Rollback();
                    this.Connection.Close();
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                Dispose(true);
            }
        }

        public Int64? TableID(string TableName)
        {

            Int64? Res;
            Boolean ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_GetTableID]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TableName_nvc = new SqlParameter();
                TableName_nvc.ParameterName = "@TableName_nvc";
                TableName_nvc.SqlDbType = SqlDbType.NVarChar;
                TableName_nvc.Direction = ParameterDirection.Input;
                TableName_nvc.IsNullable = false;
                TableName_nvc.Value = TableName;
                this.Command.Parameters.Add(TableName_nvc);

                SqlParameter TableID_bint = new SqlParameter();
                TableID_bint.ParameterName = "@TableID_bint";
                TableID_bint.SqlDbType = SqlDbType.BigInt;
                TableID_bint.Direction = ParameterDirection.Output;
                TableID_bint.IsNullable = false;
                this.Command.Parameters.Add(TableID_bint);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                Res = (Int64?)(this.Command.Parameters["@TableID_bint"].Value);

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Res;
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

        public String TablePersianName(Int64? TableID)
        {
            String Res;
            Boolean ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_GetTablePersianName]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter TableID_bint = new SqlParameter();
                TableID_bint.ParameterName = "@TableID_bint";
                TableID_bint.SqlDbType = SqlDbType.BigInt;
                TableID_bint.Direction = ParameterDirection.Input;
                TableID_bint.IsNullable = false;
                TableID_bint.Value = TableID;
                this.Command.Parameters.Add(TableID_bint);

                SqlParameter TableName_nvc = new SqlParameter();
                TableName_nvc.ParameterName = "@TableName_nvc";
                TableName_nvc.SqlDbType = SqlDbType.NVarChar;
                TableName_nvc.Size = 100;
                TableName_nvc.Direction = ParameterDirection.Output;
                TableName_nvc.IsNullable = true;
                this.Command.Parameters.Add(TableName_nvc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                Res = this.Command.Parameters["@TableName_nvc"].Value.ToString();

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Res;
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


        public DateTime ServerDate
        {
            get
            {
                DateTime Result = new DateTime();
                Boolean ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
                this.Command.CommandText = "select getdate()";
                this.Command.CommandType = CommandType.Text;

                try
                {
                    this.Command.Parameters.Clear();

                    if (ControlConnection)
                    {
                        this.BeginTransaction();
                    }
                    Hepsa.Core.Common.MyDateTime mdt = new Hepsa.Core.Common.MyDateTime((DateTime)this.Command.ExecuteScalar());
                    Result = mdt.MyDate;

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
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool bIsDisposing)
        {
            if (bIsDisposing)
            {
                if (_mainConnection.State == System.Data.ConnectionState.Open)
                {
                    _mainConnection.Close();
                }
                if (_mainCommand != null)
                {
                    _mainCommand.Dispose();
                    _mainCommand = null;
                }
                if (_mainConnection != null)
                {
                    _mainConnection.Dispose();
                    _mainConnection = null;
                }
                if (_mainTransaction != null)
                {
                    _mainTransaction.Dispose();
                    _mainTransaction = null;
                }
            }
        }

    }

}

