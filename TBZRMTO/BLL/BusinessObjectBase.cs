using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace HPS.BLL.BusinessObjectMain
{

    public abstract class BusinessObjectBase
    {

        private Hepsa.Core.Validation.ValidationRules _ValidationRules = null;

        public Hepsa.Core.Validation.ValidationRules ValidationRules
        {
            get
            {
                if (_ValidationRules == null)
                {
                    _ValidationRules = new Hepsa.Core.Validation.ValidationRules(this);
                    AddValidationRules();
                }
                return _ValidationRules;
            }
        }

        public Boolean IsValid()
        {

            return this.ValidationRules.IsValid();

        }

        public Boolean IsValid(Hepsa.Core.Validation.ValidationExceptionType ExceptType, params string[] Except)
        {

            return this.ValidationRules.IsValid(ExceptType, Except);

        }

        public Hepsa.Core.Validation.BrokenRulesList BrokenRulesList()
        {

            return ValidationRules.BrokenRules();

        }

        public abstract void AddValidationRules();
        
    }
}

