using HPS.ir.rmto.smartcard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPS.Common
{
    class OnlineService
    {
        bool HasInternet()
        {
            System.Net.IPAddress[] ipv4Addresses = Array.FindAll(
                System.Net.Dns.GetHostEntry(string.Empty).AddressList,
                a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            foreach (var item in ipv4Addresses)
            {
                if (item.ToString().StartsWith("192.168"))
                {
                    return true;
                }
            }

            return false;

        }
        public Func<string, double, string, string, string, string, string, string, string, string, string, string, string, string> RMTO_WEB_SERVICES
        {
            get
            {
                if (HasInternet())
                {
                    return new OnlineReference.PKG_RMTO_WSService().RMTO_WEB_SERVICES;

                }
                else
                {
                    return new PKG_RMTO_WSService().RMTO_WEB_SERVICES;
                }
            }
        }

    }
    class OnlineInformation
    {
        OnlineService localReference = new OnlineService();

        public object[] GetCarInformation(string carCardNumber)
        {
            var returnList = new List<object>();
            //authentication();
            //localReference = new PKG_RMTO_WSService();
            //// Get Car Information
            try
            {
                string Carinfo = localReference.RMTO_WEB_SERVICES("RZK_RMTO", 4, "3098791", "", "", "", "", "", "", "", "", "", carCardNumber);
                string[] Carinfosplited = Carinfo.Split(';');
                var carList = new List<object>();
                //0-is_active_code
                if (Carinfosplited[0] == "-1")
                {
                    return null;
                }
                carList.Add(Carinfosplited[8].Substring(Carinfosplited[8].ToString().IndexOf(':') + 1, Carinfosplited[8].ToString().Length - Carinfosplited[8].ToString().IndexOf(':') - 1));
                //1-PlaqueNumber=NumberPlate_nvc
                string plq1 = Carinfosplited[5].Substring(Carinfosplited[5].ToString().IndexOf(':') + 1, Carinfosplited[5].ToString().Length - Carinfosplited[5].ToString().IndexOf(':') - 1);
                string plq2 = Carinfosplited[6].Substring(Carinfosplited[6].ToString().IndexOf(':') + 1, Carinfosplited[6].ToString().Length - Carinfosplited[6].ToString().IndexOf(':') - 1);
                string plq3 = Carinfosplited[7].Substring(Carinfosplited[7].ToString().IndexOf(':') + 1, Carinfosplited[7].ToString().Length - Carinfosplited[7].ToString().IndexOf(':') - 1);

                carList.Add(plq3 + plq2 + plq1);

                //2-shomare_serial_plaque=SerialPlate_nvc
                carList.Add(Carinfosplited[3].Substring(Carinfosplited[3].ToString().IndexOf(':') + 1, Carinfosplited[3].ToString().Length - Carinfosplited[3].ToString().IndexOf(':') - 1));
                //3-sal_sakht=ProductionYear_int
                carList.Add(Carinfosplited[9].Substring(Carinfosplited[9].ToString().IndexOf(':') + 1, Carinfosplited[9].ToString().Length - Carinfosplited[9].ToString().IndexOf(':') - 1));
                //4-PlaqueType
                carList.Add(Carinfosplited[11].Substring(Carinfosplited[11].ToString().IndexOf(':') + 1, Carinfosplited[11].ToString().Length - Carinfosplited[11].ToString().IndexOf(':') - 1));
                carList.Add(Carinfosplited[16].Substring(Carinfosplited[16].ToString().IndexOf(':') + 1, Carinfosplited[16].ToString().Length - Carinfosplited[16].ToString().IndexOf(':') - 1));
                carList.Add(Carinfosplited[12].Substring(Carinfosplited[12].ToString().IndexOf(':') + 1, Carinfosplited[12].ToString().Length - Carinfosplited[12].ToString().IndexOf(':') - 1));

                //PlaqueCityCode
                carList.Add("");
                //tarikh_sodor
                //carList.Add( Carinfosplited[16].Substring(Carinfosplited[16].ToString().IndexOf(':') + 1, Carinfosplited[16].ToString().Length - Carinfosplited[16].ToString().IndexOf(':') - 1));

                returnList.Add(carList);
                return returnList.ToArray();
            }
            catch (Exception)
            {
                returnList = new List<object>();
                returnList.Add("-2");
                return returnList.ToArray();
            }
        }
        public object[] GetCarInformation(string plq01, string plq02, string plq03, string serial_plq)
        {
            var returnList = new List<object>();
            //authentication();
            localReference = new OnlineService();
            //// Get Car Information
            string Carinfo = localReference.RMTO_WEB_SERVICES("RZK_RMTO", 50, "3098791", "", "", "", "", "", "", serial_plq, plq03, plq02, plq01);
            string[] Carinfosplited = Carinfo.Split(';');
            var carList = new List<object>();
            //0-is_active_code
            if (Carinfosplited[0] == "-1")
            {
                return null;
            }
            carList.Add(Carinfosplited[8].Substring(Carinfosplited[8].ToString().IndexOf(':') + 1, Carinfosplited[8].ToString().Length - Carinfosplited[8].ToString().IndexOf(':') - 1));
            //1-PlaqueNumber=NumberPlate_nvc
            string plq1 = Carinfosplited[5].Substring(Carinfosplited[5].ToString().IndexOf(':') + 1, Carinfosplited[5].ToString().Length - Carinfosplited[5].ToString().IndexOf(':') - 1);
            string plq2 = Carinfosplited[6].Substring(Carinfosplited[6].ToString().IndexOf(':') + 1, Carinfosplited[6].ToString().Length - Carinfosplited[6].ToString().IndexOf(':') - 1);
            string plq3 = Carinfosplited[7].Substring(Carinfosplited[7].ToString().IndexOf(':') + 1, Carinfosplited[7].ToString().Length - Carinfosplited[7].ToString().IndexOf(':') - 1);

            carList.Add(plq3 + plq2 + plq1);

            //2-shomare_serial_plaque=SerialPlate_nvc
            carList.Add(Carinfosplited[3].Substring(Carinfosplited[3].ToString().IndexOf(':') + 1, Carinfosplited[3].ToString().Length - Carinfosplited[3].ToString().IndexOf(':') - 1));
            //3-sal_sakht=ProductionYear_int
            carList.Add(Carinfosplited[9].Substring(Carinfosplited[9].ToString().IndexOf(':') + 1, Carinfosplited[9].ToString().Length - Carinfosplited[9].ToString().IndexOf(':') - 1));
            //4-PlaqueType
            carList.Add(Carinfosplited[11].Substring(Carinfosplited[11].ToString().IndexOf(':') + 1, Carinfosplited[11].ToString().Length - Carinfosplited[11].ToString().IndexOf(':') - 1));
            carList.Add(Carinfosplited[16].Substring(Carinfosplited[16].ToString().IndexOf(':') + 1, Carinfosplited[16].ToString().Length - Carinfosplited[16].ToString().IndexOf(':') - 1));
            carList.Add(Carinfosplited[12].Substring(Carinfosplited[12].ToString().IndexOf(':') + 1, Carinfosplited[12].ToString().Length - Carinfosplited[12].ToString().IndexOf(':') - 1));

            //PlaqueCityCode
            carList.Add("");
            //tarikh_sodor
            //carList.Add( Carinfosplited[16].Substring(Carinfosplited[16].ToString().IndexOf(':') + 1, Carinfosplited[16].ToString().Length - Carinfosplited[16].ToString().IndexOf(':') - 1));

            returnList.Add(carList);
            return returnList.ToArray();
        }

        public List<object> GetDriverInformation(string driverCardNumber)
        {
            var returnList = new List<object>();

            //authentication();
            try
            {
                string driverinfo = localReference.RMTO_WEB_SERVICES("RZK_RMTO", 41, "3098791", "", "", "", "", "", "", "", "", "", driverCardNumber);
                string[] driverinfosplited = driverinfo.Split(';');
                if (driverinfosplited[0] == "-1")
                {
                    return null;
                }
                var driverList = new List<object>();
                //0-name
                driverList.Add(driverinfosplited[4].Substring(driverinfosplited[4].ToString().IndexOf(':') + 1, driverinfosplited[4].ToString().Length - driverinfosplited[4].ToString().IndexOf(':') - 1));
                //1-Family
                driverList.Add(driverinfosplited[5].Substring(driverinfosplited[5].ToString().IndexOf(':') + 1, driverinfosplited[5].ToString().Length - driverinfosplited[5].ToString().IndexOf(':') - 1));
                //2-Code_melli
                driverList.Add(Convert.ToInt64(driverinfosplited[3].Substring(driverinfosplited[3].ToString().IndexOf(':') + 1, driverinfosplited[3].ToString().Length - driverinfosplited[3].ToString().IndexOf(':') - 1)));
                //3-shomaro_bime
                driverList.Add(driverinfosplited[10].Substring(driverinfosplited[10].ToString().IndexOf(':') + 1, driverinfosplited[10].ToString().Length - driverinfosplited[10].ToString().IndexOf(':') - 1));
                //4-CertifcateNumber=shomare_gavahinameh
                driverList.Add(driverinfosplited[9].Substring(driverinfosplited[9].ToString().IndexOf(':') + 1, driverinfosplited[9].ToString().Length - driverinfosplited[9].ToString().IndexOf(':') - 1));
                //5-CardNumber=Null
                driverList.Add(driverinfosplited[1].Substring(driverinfosplited[1].ToString().IndexOf(':') + 1, driverinfosplited[1].ToString().Length - driverinfosplited[1].ToString().IndexOf(':') - 1));
                //6-tarikh_payanetebar=DriverCardDate_nvc
                driverList.Add(driverinfosplited[12].Substring(driverinfosplited[12].ToString().IndexOf(':') + 1, driverinfosplited[12].ToString().Length - driverinfosplited[12].ToString().IndexOf(':') - 1));
                //7-salamat_date
                driverList.Add(driverinfosplited[18].Substring(driverinfosplited[18].ToString().IndexOf(':') + 1, driverinfosplited[18].ToString().Length - driverinfosplited[18].ToString().IndexOf(':') - 1));
                //8- IsActive
                driverList.Add(driverinfosplited[11].Substring(driverinfosplited[11].ToString().IndexOf(':') + 1, driverinfosplited[11].ToString().Length - driverinfosplited[11].ToString().IndexOf(':') - 1));
                //9-tarikh-Sodor
                driverList.Add(driverinfosplited[2].Substring(driverinfosplited[2].ToString().IndexOf(':') + 1, driverinfosplited[2].ToString().Length - driverinfosplited[2].ToString().IndexOf(':') - 1));
                //10-sharhe_mahale_sukunat
                driverList.Add(driverinfosplited[13].Substring(driverinfosplited[13].ToString().IndexOf(':') + 1, driverinfosplited[13].ToString().Length - driverinfosplited[13].ToString().IndexOf(':') - 1));
                //11-shomare-parvande
                driverList.Add(driverinfosplited[0].Substring(driverinfosplited[0].ToString().IndexOf(':') + 1, driverinfosplited[0].ToString().Length - driverinfosplited[0].ToString().IndexOf(':') - 1));

                returnList.Add(driverList);

                return returnList;

            }
            catch (Exception)
            {
                returnList = new List<object>();
                returnList.Add("-2");
                return returnList;
            }
        }
        public object[] GetInformation(string driverCardNumber, string carCardNumber)
        {
            var returnList = new List<object>();
            //authentication();
            string driverinfo = localReference.RMTO_WEB_SERVICES("RZK_RMTO", 41, "3098791", "", "", "", "", "", "", "", "", "", driverCardNumber);
            string[] driverinfosplited = driverinfo.Split(';');
            var driverList = new List<object>();
            //0-name
            driverList.Add(driverinfosplited[4].Substring(driverinfosplited[4].ToString().IndexOf(':') + 1, driverinfosplited[4].ToString().Length - driverinfosplited[4].ToString().IndexOf(':') - 1));
            //1-Family
            driverList.Add(driverinfosplited[5].Substring(driverinfosplited[5].ToString().IndexOf(':') + 1, driverinfosplited[5].ToString().Length - driverinfosplited[5].ToString().IndexOf(':') - 1));
            //2-Code_melli
            driverList.Add(Convert.ToInt64(driverinfosplited[3].Substring(driverinfosplited[3].ToString().IndexOf(':') + 1, driverinfosplited[3].ToString().Length - driverinfosplited[3].ToString().IndexOf(':') - 1)));
            //3-shomaro_bime
            driverList.Add(driverinfosplited[10].Substring(driverinfosplited[10].ToString().IndexOf(':') + 1, driverinfosplited[10].ToString().Length - driverinfosplited[10].ToString().IndexOf(':') - 1));
            //4-CertifcateNumber=shomare_gavahinameh
            driverList.Add(driverinfosplited[9].Substring(driverinfosplited[9].ToString().IndexOf(':') + 1, driverinfosplited[9].ToString().Length - driverinfosplited[9].ToString().IndexOf(':') - 1));
            //5-CardNumber=Null
            driverList.Add(driverinfosplited[1].Substring(driverinfosplited[1].ToString().IndexOf(':') + 1, driverinfosplited[1].ToString().Length - driverinfosplited[1].ToString().IndexOf(':') - 1));
            //6-tarikh_payanetebar=DriverCardDate_nvc
            driverList.Add(driverinfosplited[12].Substring(driverinfosplited[12].ToString().IndexOf(':') + 1, driverinfosplited[12].ToString().Length - driverinfosplited[12].ToString().IndexOf(':') - 1));
            //7-salamat_date
            driverList.Add(driverinfosplited[18].Substring(driverinfosplited[18].ToString().IndexOf(':') + 1, driverinfosplited[18].ToString().Length - driverinfosplited[18].ToString().IndexOf(':') - 1));
            //8- IsActive
            driverList.Add(driverinfosplited[11].Substring(driverinfosplited[11].ToString().IndexOf(':') + 1, driverinfosplited[11].ToString().Length - driverinfosplited[11].ToString().IndexOf(':') - 1));
            //9-tarikh-Sodor
            driverList.Add(driverinfosplited[2].Substring(driverinfosplited[2].ToString().IndexOf(':') + 1, driverinfosplited[2].ToString().Length - driverinfosplited[2].ToString().IndexOf(':') - 1));
            //10-sharhe_mahale_sukunat
            driverList.Add(driverinfosplited[13].Substring(driverinfosplited[13].ToString().IndexOf(':') + 1, driverinfosplited[13].ToString().Length - driverinfosplited[13].ToString().IndexOf(':') - 1));
            //11-shomare-parvande
            driverList.Add(driverinfosplited[0].Substring(driverinfosplited[0].ToString().IndexOf(':') + 1, driverinfosplited[0].ToString().Length - driverinfosplited[0].ToString().IndexOf(':') - 1));

            returnList.Add(driverList);
            localReference = new OnlineService();
            //// Get Car Information
            string Carinfo = localReference.RMTO_WEB_SERVICES("RZK_RMTO", 4, "3098791", "", "", "", "", "", "", "", "", "", carCardNumber);
            string[] Carinfosplited = Carinfo.Split(';');
            var carList = new List<object>();
            //0-is_active_code
            carList.Add(Carinfosplited[8].Substring(Carinfosplited[8].ToString().IndexOf(':') + 1, Carinfosplited[8].ToString().Length - Carinfosplited[8].ToString().IndexOf(':') - 1));
            //1-PlaqueNumber=NumberPlate_nvc
            string plq1 = Carinfosplited[5].Substring(Carinfosplited[5].ToString().IndexOf(':') + 1, Carinfosplited[5].ToString().Length - Carinfosplited[5].ToString().IndexOf(':') - 1);
            string plq2 = Carinfosplited[6].Substring(Carinfosplited[6].ToString().IndexOf(':') + 1, Carinfosplited[6].ToString().Length - Carinfosplited[6].ToString().IndexOf(':') - 1);
            string plq3 = Carinfosplited[7].Substring(Carinfosplited[7].ToString().IndexOf(':') + 1, Carinfosplited[7].ToString().Length - Carinfosplited[7].ToString().IndexOf(':') - 1);
            carList.Add(plq3 + plq2 + plq1);

            //2-shomare_serial_plaque=SerialPlate_nvc
            carList.Add(Carinfosplited[3].Substring(Carinfosplited[3].ToString().IndexOf(':') + 1, Carinfosplited[3].ToString().Length - Carinfosplited[3].ToString().IndexOf(':') - 1));
            //3-sal_sakht=ProductionYear_int
            carList.Add(Carinfosplited[9].Substring(Carinfosplited[9].ToString().IndexOf(':') + 1, Carinfosplited[9].ToString().Length - Carinfosplited[9].ToString().IndexOf(':') - 1));
            //4-PlaqueType
            carList.Add(Carinfosplited[11].Substring(Carinfosplited[11].ToString().IndexOf(':') + 1, Carinfosplited[11].ToString().Length - Carinfosplited[11].ToString().IndexOf(':') - 1));

            //PlaqueCityCode
            carList.Add("");
            //tarikh_sodor
            //carList.Add( Carinfosplited[16].Substring(Carinfosplited[16].ToString().IndexOf(':') + 1, Carinfosplited[16].ToString().Length - Carinfosplited[16].ToString().IndexOf(':') - 1));

            returnList.Add(carList);
            return returnList.ToArray();


        }
    }
}
