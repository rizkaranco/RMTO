using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace HPS.BLL.Common
{
    class RemoteProccessControl
    {
        //private const string UserName = "admin100";
        //private const string Password = "admin100pass";
        //private const string MachineName = "ADMIN100-PC";
        //private const string MyDomain = "WORKGROUP";
        const bool ChkUseDomain = false;
        private ManagementScope _myScope;
        private ConnectionOptions _connOptions;
        private ManagementObjectSearcher _objSearcher;

        public bool ConnectToRemoteMachine(string proccessname, string UserName, string Password, string MachineName, string MyDomain)
        {
            bool result = false;
            try
            {
                _connOptions = new ConnectionOptions { Impersonation = ImpersonationLevel.Impersonate, EnablePrivileges = true };
                if (MachineName.ToUpper() == Environment.MachineName.ToUpper())
                {
                    _myScope = new ManagementScope(@"\ROOT\CIMV2", _connOptions);
                }
                else
                {
                    if (ChkUseDomain)
                    {
                        _connOptions.Username = MyDomain + "\\" + UserName;
                    }
                    else
                    {
                        _connOptions.Username = MachineName + "\\" + UserName;
                    }
                    _connOptions.Password = Password;
                    _myScope = new ManagementScope(@"\\" + MachineName + @"\ROOT\CIMV2", _connOptions);
                }

                _myScope.Connect();
                _objSearcher = new ManagementObjectSearcher(string.Format("SELECT * FROM Win32_Process WHERE name='{0}'", proccessname));
                _objSearcher.Scope = _myScope;
                string[] sep = { "\n", "\t" };

                String message = "";

                foreach (ManagementObject obj in _objSearcher.Get())
                {
                    string caption = obj.GetText(TextFormat.Mof);
                    string[] split = caption.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                    // Iterate through the splitter


                    foreach (string t in split)
                    {
                        if (t.Split('=').Length > 1)
                        {
                            string[] procDetails = t.Split('=');
                            procDetails[1] = procDetails[1].Replace(@"""", "");
                            procDetails[1] = procDetails[1].Replace(';', ' ');
                            switch (procDetails[0].Trim().ToLower())
                            {
                                case "caption":
                                    break;
                                case "csname":

                                    message = "Proccess Running";
                                    break;
                                case "name":
                                    break;

                            }
                        }
                    }
                }
               
                if (string.IsNullOrEmpty(message))
                {
                    result = false;
                }
                else
                {
                    //label1.Text = "Proccess Running";
                    //pictureBox1.Image = Properties.Resources.yes;
                    result = true;
                }
             
            }
          catch (Exception ex)
            {

            }
            return result;

        }
    }
}