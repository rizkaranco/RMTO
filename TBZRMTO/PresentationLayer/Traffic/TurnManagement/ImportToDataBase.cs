using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient; 
using System.Data;

namespace HPS.Present
{  
    class ImportToDataBase
    {
        OracleConnection oracleCon;
        OracleCommand oraclecom;

        private void GetConnectionstring()
        {
           oracleCon = new OracleConnection();
           string connectionstring = "Data Source=oracl3;Persist Security Info=True; User ID=bar;Password=bar3;Unicode=True";
           oracleCon.ConnectionString = connectionstring;
           oraclecom = new OracleCommand();
           oraclecom.Connection = oracleCon;                      
        }

        public void SelectFromPERBARNAME_T(DataTable datatable)
        {          
            oracleCon.Open();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(oraclecom);
            oraclecom.CommandText = "[Sp_BAR.PERBARNAME_Select]";
            oraclecom.CommandType = CommandType.StoredProcedure;
            try
            {
                oraclecom.Parameters.Clear();
                oracleDataAdapter.Fill(datatable);
                oracleCon.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
       
        public void DeleteFromPERBARNAME_T()
        {
            oracleCon.Open();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(oraclecom);
            oraclecom.CommandText = "[Sp_BARPERBARNAME_delete]";
            oraclecom.CommandType = CommandType.StoredProcedure;
            try
            {
                oraclecom.Parameters.Clear();
                oraclecom.ExecuteNonQuery();
                oracleCon.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
       
        public void InsertFromQuery_T_Toperbarname_T()
        {
            oracleCon.Open();
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(oraclecom);
            oraclecom.CommandText = "[SP_BARPERBARNAME_Insert]";
            oraclecom.CommandType = CommandType.StoredProcedure;
            try
            {
                oraclecom.Parameters.Clear();
                oraclecom.ExecuteNonQuery();
                oracleCon.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
