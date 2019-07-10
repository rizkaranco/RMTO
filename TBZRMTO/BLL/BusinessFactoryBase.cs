using System;
using System.Data;

namespace HPS.BLL.BusinessFactoryMain
{

    public abstract class BusinessFactoryBase
    {
        private String _TableName;
        private HPS.DAL.DataLayerMain.DataLayerBase _dataObject;

        public BusinessFactoryBase(String TableName)
        {
            this._TableName = TableName;

            if (TableName == "User_T")
            {
                _dataObject = (HPS.DAL.DataLayerMain.DataLayerBase)Activator.CreateInstance(Type.GetType("HPS.DAL.UserDAL.DALUser_T"));
            }
            else if (TableName == "Permission_T")
            {
                _dataObject = (HPS.DAL.DataLayerMain.DataLayerBase)Activator.CreateInstance(Type.GetType("HPS.DAL.PermissionDAL.DALPermission_T"));

            }
            else if (TableName == "Action_T")
            {
                _dataObject = (HPS.DAL.DataLayerMain.DataLayerBase)Activator.CreateInstance(Type.GetType("HPS.DAL.DALAction_T"));
            }
            else if (TableName == "PermissionGroup_T")
            {
                _dataObject = (HPS.DAL.DataLayerMain.DataLayerBase)Activator.CreateInstance(Type.GetType("HPS.DAL.PermissionGroupDAL.DALPermissionGroup_T"));
            }
            else if (TableName == "UserGroup_T")
            {
                _dataObject = (HPS.DAL.DataLayerMain.DataLayerBase)Activator.CreateInstance(Type.GetType("HPS.DAL.UserGroupDAL.DALUserGroup_T"));
            }
            else
            {

                Hepsa.Core.Common.ApplicationInfo AppInfo = new Hepsa.Core.Common.ApplicationInfo(TableName);
                _dataObject = (HPS.DAL.DataLayerMain.DataLayerBase)Activator.CreateInstance(Type.GetType(AppInfo.DataAccessLayer));
            }
        }

        public Object DataAccessLayer
        {
            get
            {
                return _dataObject;
            }
        }

        public Int64? TableID
        {
            get
            {
                try
                {
                    return this._dataObject.TableID(this._TableName);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

        public String TablePersianName
        {
            get
            {
                try
                {
                    return this._dataObject.TablePersianName(this.TableID);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

        public String GetTablePersianName(String TableName)
        {
            try
            {
                return this._dataObject.TablePersianName(this._dataObject.TableID(TableName));
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public String TableName
        {
            get
            {
                try
                {
                    return this._TableName;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void BeginProc()
        {
            try
            {
                this._dataObject.BeginTransaction();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void CommitProc()
        {
            try
            {
                this._dataObject.Commit();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void RollBackProc()
        {
            try
            {
                this._dataObject.RollBack();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public string ServerJalaliDate
        {
            get
            {
                try
                {
                    return this.ConvertDate(this.ServerDate);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

        //public  string ServerJalaliDate
        //{
        //    get
        //    {

        //        System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
        //        string Year, Month, Day;
        //        Year = pc.GetYear(DateTime.Now).ToString();
        //        Month = pc.GetMonth(DateTime.Now).ToString();
        //        Day = pc.GetDayOfMonth(DateTime.Now).ToString();
        //        if (Day.Length < 2)
        //            Day = string.Format("0{0}", Day);
        //        if (Month.Length < 2)
        //            Month = string.Format("0{0}", Month);
        //        return string.Format("{0}/{1}/{2}", Year, Month, Day);

        //    }
        //}


        public DateTime ServerDate
        {
            get
            {
                try
                {
                    return _dataObject.ServerDate;
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
        }

        public String ServerTime
        {
            get
            {
                try
                {
                    TimeSpan time = new TimeSpan();
                    time = _dataObject.ServerDate.TimeOfDay;
                    return time.ToString().Substring(0, 8);
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
            }
            //get
            //{

            //    System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            //    string hour, minute, Second;
            //    hour = pc.GetHour(DateTime.Now).ToString();
            //    minute = pc.GetMinute(DateTime.Now).ToString();
            //    Second = pc.GetSecond(DateTime.Now).ToString();
            //    if (hour.Length < 2)
            //        hour = string.Format("0{0}", hour);
            //    if (Second.Length < 2)
            //        Second = string.Format("0{0}", Second);
            //    if (minute.Length < 2)
            //        minute = string.Format("0{0}", minute);
            //    return string.Format("{0}:{1}:{2}", hour, minute, Second);

            //}
        }

        private String ConvertDate(DateTime InputDate)
        {
            try
            {
                String Result = String.Empty;
                System.Globalization.PersianCalendar PersianCalender = new System.Globalization.PersianCalendar();
                int Year = PersianCalender.GetYear(InputDate);
                int Month = PersianCalender.GetMonth(InputDate);
                int Day = PersianCalender.GetDayOfMonth(InputDate);
                Result += Year.ToString() + "/";
                if (Month < 10)
                    Result += "0" + Month.ToString() + "/";
                else
                    Result += Month.ToString() + "/";

                if (Day < 10)
                    Result += "0" + Day.ToString();
                else
                    Result += Day.ToString();

                return Result;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

    }

}