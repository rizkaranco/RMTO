using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HPS.Common
{
    static class FrequentlyUsedData
    {
        private static DataTable _CarDataTable;
        private static DataTable _DriverDataTable;

        public static DataTable CarDataTable
        {
            get 
            {
                if (_CarDataTable == null)
                    LoadData();
                return FrequentlyUsedData._CarDataTable; 
            }
        }
     
        public static DataTable DriverDataTable
        {
            get 
            {
                if (_DriverDataTable == null)
                    LoadData();
                return FrequentlyUsedData._DriverDataTable; 
            }
        }

        public static void LoadData()
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            try
            {
                if (_CarDataTable == null)
                    _CarDataTable = new DataTable();
                CarFactory.GetByPlate(string.Empty, ref _CarDataTable);
                if (_DriverDataTable == null)
                    _DriverDataTable = new DataTable();
                DriverFactory.GetByCardNumber(string.Empty, ref _DriverDataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string IpAddress()
        {
            try
            {
                return System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0].ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static string MacAddress()
        {
            foreach (System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    if (nic.GetIPProperties().UnicastAddresses.Count > 0)
                    {
                        foreach ( System.Net.NetworkInformation.UnicastIPAddressInformation address in nic.GetIPProperties().UnicastAddresses)
                        {
                            if (address.Address.ToString() == IpAddress())
                            {
                                return nic.GetPhysicalAddress().ToString();
                            }
                        }
                    }
                }
            }
            return String.Empty;
    
        }

    }
}
