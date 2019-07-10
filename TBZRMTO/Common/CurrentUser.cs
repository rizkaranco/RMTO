using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPS.Common
{
    public class CurrentUser
    {
        private static BLL.UserBLL.BLLUser_T _user = null;

        public static BLL.UserBLL.BLLUser_T user
        {
            get
            {
                return _user;
            }
            set
            {
                HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
                HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys UserGroupKey = new HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys();
                HPS.BLL.PermissionBLL.BLLPermission_TFactory PermissionFactory = new HPS.BLL.PermissionBLL.BLLPermission_TFactory();

                try
                {
                    _user = value;
                    if (value != null)
                    {
                        if (Hepsa.Core.Common.CurrentUser.User == null)
                            Hepsa.Core.Common.CurrentUser.User = new Hepsa.Core.BLL.BLLUser_T();
                        Hepsa.Core.Common.CurrentUser.User.UserName_nvc = value.UserName_nvc;
                        Hepsa.Core.Common.CurrentUser.User.Password_nvc = value.Password_nvc;
                        Hepsa.Core.Common.CurrentUser.User.FullName_nvc = value.FullName_nvc;
                        Hepsa.Core.Common.CurrentUser.User.Picture_img = value.Picture_img;
                        if (value.UserGroupID_int.HasValue)
                        {
                            UserGroupKey.UserGroupID_int = value.UserGroupID_int;
                            HPS.BLL.UserGroupBLL.BLLUserGroup_T UserGroupEntity = UserGroupFactory.GetBy(UserGroupKey);
                            if (UserGroupEntity != null)
                                Hepsa.Core.Common.CurrentUser.User.Permissions_vc = UserGroupEntity.Permission_nvc;
                            List<HPS.BLL.PermissionBLL.BLLPermission_T> PermissionList = PermissionFactory.GetAllByCondition(string.Format("[Permission_T].[PermissionID_bint] In ({0})", (string.IsNullOrEmpty(UserGroupEntity.Permission_nvc) ? "-1" : UserGroupEntity.Permission_nvc.Replace("$", ","))));

                            Hepsa.Core.Common.CurrentUser.User.Permissions.Clear();
                            if (PermissionList != null && PermissionList.Count > 0)
                                foreach (HPS.BLL.PermissionBLL.BLLPermission_T p in PermissionList)
                                {
                                    Hepsa.Core.BLL.BLLPermission_T PermissionEntity = new Hepsa.Core.BLL.BLLPermission_T();
                                    PermissionEntity.PermissionID_bint = p.PermissionID_bint;
                                    PermissionEntity.Permission_nvc = p.Permission_nvc;
                                    PermissionEntity.PropertyName_nvc = p.PropertyName_nvc;
                                    PermissionEntity.FormName_nvc = p.FormName_nvc;
                                    PermissionEntity.ControlName_nvc = p.ControlName_nvc;
                                    PermissionEntity.ColumnName_nvc = p.ColumnName_nvc;
                                    PermissionEntity.Value_nvc = p.Value_nvc;
                                    Hepsa.Core.Common.CurrentUser.User.Permissions.Add(PermissionEntity);
                                }
                        }
                    }
                    else
                    {
                        Hepsa.Core.Common.CurrentUser.User = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        public static List<string> ExceptSMSList = new List<string>();

        private static string _ANPRProcessProcessName;
        public static string ANPRServiceProcessName
        {
            get
            {
                _ANPRProcessProcessName = "AnprServiceRizkaran.exe";
                return _ANPRProcessProcessName;
            }
            set
            {
                _ANPRProcessProcessName = value;
            }

        }

        private static string _SMSControllerServiceProcessName;

        public static string SMSControllerServiceProcessName
        {
            get
            {
                _SMSControllerServiceProcessName = "SMSServiceRizkaran.exe";
                return _SMSControllerServiceProcessName;
            }
            set
            {
                _SMSControllerServiceProcessName = value;
            }
        }

        private static  BLL.BLLYear_T _Year ;

        public static BLL.BLLYear_T Year
        {
            get { return _Year; }
            set
            {
                _Year = value;

            }
        }

    }
}