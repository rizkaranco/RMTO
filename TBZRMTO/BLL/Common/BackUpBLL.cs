using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.BLL.Common
{
    class BackUp_TFactory

    {
        private HPS.DAL.Common.DALBackUp _dataObject = null;

        public BackUp_TFactory()
           
        {
            _dataObject = new HPS.DAL.Common.DALBackUp();
        }
        public void BackUp(string FilePath)
        {
            try
            {
                _dataObject.BackUp(FilePath);
            }
            catch (Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }


        public void Restore(string FileName)
        {
            try
            {
                _dataObject.Restore(FileName);
            }
            catch (Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
    }
}
