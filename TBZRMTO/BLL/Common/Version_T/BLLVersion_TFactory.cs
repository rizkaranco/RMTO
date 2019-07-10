using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.VersionBLL
{
    class BLLVersion_TFactory : BusinessFactoryBase
    {
          private HPS.DAL.VersionDAL.DALVersion_T _dataObject = null;

          public BLLVersion_TFactory()
            : base("Version_T")
        {
            _dataObject = (HPS.DAL.VersionDAL.DALVersion_T)base.DataAccessLayer;
        }

          public void Insert(HPS.BLL.VersionBLL.BLLVersion_T businessObject)
          {
              try
              {
                  if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "VersionID_bint") == false)
                  {
                      throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                  }

                  _dataObject.Insert(businessObject);
              }
              catch (System.Exception ex)
              {
                  throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
              }
          }

          public void SelectLastOldVersion(out string Version_nvc)
          {
              try
              {
                 _dataObject.SelectLastOldVersion(out Version_nvc);
              }
              catch (System.Exception ex)
              {
                  throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
              }
          }


    }
}
