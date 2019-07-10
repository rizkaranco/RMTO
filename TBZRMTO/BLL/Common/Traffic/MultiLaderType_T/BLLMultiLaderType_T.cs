using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.MultiLaderTypeBLL
{

    public class BLLMultiLaderType_T
    : BusinessObjectBase
    {

        public enum MultiLaderType_TField
        {
            MultiLaderTypeID_int
            ,
            LadeAssignmentID_bint
                ,
            LaderTypeID_int
                ,
            LaderType_nvc
        }


        private Int32 _MultiLaderTypeID_int;
        public Int32 MultiLaderTypeID_int
        {
            get
            {
                return _MultiLaderTypeID_int;
            }
            set
            {
                this._MultiLaderTypeID_int = value;
            }
        }


        private Int64? _LadeAssignmentID_bint;
        public Int64? LadeAssignmentID_bint
        {
            get
            {
                return _LadeAssignmentID_bint;
            }
            set
            {
                this._LadeAssignmentID_bint = value;
            }
        }


        private Int32? _LaderTypeID_int;
        public Int32? LaderTypeID_int
        {
            get
            {
                return _LaderTypeID_int;
            }
            set
            {
                this._LaderTypeID_int = value;
            }
        }

        private string _LaderType_nvc;
        public string LaderType_nvc
        {
            get
            {
                return _LaderType_nvc;
            }
            set
            {
                this._LaderType_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeAssignmentID_bint", "اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeAssignmentID_bint", "اطلاع رسانی بار", "LadeAssignment_T", "LadeAssignmentID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LaderTypeID_int", " نوع بارگیر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LaderTypeID_int", " نوع بارگیر", "LaderType_T", "LaderTypeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueMultiLaderTypeID_int", "شناسه انتخاب چند بارگیر", "MultiLaderType_T", "MultiLaderTypeID_int"));
        }
    }
}