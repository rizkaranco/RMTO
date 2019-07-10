using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace HPS.BLL
{
    public class CameraConnection
    {
        private static bool _IntegratedSecurity = false;

        //private static string _Server = @"172.20.129.180", _DataBase = "TrafficPictures", _UserID = "sa", _Password = "sa.123";
        private static string _Server = @"192.168.1.100", _DataBase = "TrafficPictures", _UserID = "sa", _Password = "wq123";

        public static bool IntegratedSecurity
        {
            get
            {
                return _IntegratedSecurity;
            }
        }

        public static string Password
        {

            get
            {
                return _Password;
            }
            //set
            //{
            //    Hepsa.Core.BLL.BLLUserLogin_T UserLogin = new Hepsa.Core.BLL.BLLUserLogin_T();
            //    value = UserLogin.Password_nvc;
            //    _Password = value;
            //}
        }

        public static string UserID
        {
            get
            {
                return _UserID;
            }
            //set
            //{
            //    Hepsa.Core.BLL.BLLUserLogin_T UserLogin = new Hepsa.Core.BLL.BLLUserLogin_T();
            //    value = UserLogin.UserName_nvc;
            //    _UserID = value;
            //}
        }

        public static string Server
        {
            get
            {
                return _Server;
            }
        }

        public static string DataBase
        {
            get
            {
                return _DataBase;
            }
        }

        public static string DefaultConnectionString
        {
            get
            {
                return ConnectionString();
            }
        }


        public static string ConnectionString()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder MyConnectionString = new System.Data.SqlClient.SqlConnectionStringBuilder();
            MyConnectionString.InitialCatalog = string.Format(DataBase);
            MyConnectionString.DataSource = Server;
            MyConnectionString.ConnectTimeout = 30;
            MyConnectionString.Pooling = true;
            MyConnectionString.MinPoolSize = 1;
            MyConnectionString.MaxPoolSize = 10;
            MyConnectionString.IntegratedSecurity = IntegratedSecurity;
            MyConnectionString.UserID = UserID;
            MyConnectionString.Password = Password;
            return MyConnectionString.ConnectionString;
        }

    }
}
