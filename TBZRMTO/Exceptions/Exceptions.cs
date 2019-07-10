using System;
using System.Text;

namespace HPS.Exceptions
{
    class Exceptions
    {
    }
    public class ComputerNotFound : System.Exception
    {

        public ComputerNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "رایانه"))
        { }

    }
    public class AnnouncementTimeNotFound : System.Exception
    {

        public AnnouncementTimeNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "زمان اعلام بار"))
        { }

    }
    public class BillMessageNotFound : System.Exception
    {

        public BillMessageNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "پیام قبض"))
        { }

    }
    public class BoundryNotFound : System.Exception
    {

        public BoundryNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "مرز"))
        { }

    }
 
    public class CityNotFound : System.Exception
    {

        public CityNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "شهر"))
        { }

    }
    public class ColorNotFound : System.Exception
    {

        public ColorNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "رنگ"))
        { }

    }
    public class CompanyNotFound : System.Exception
    {

        public CompanyNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "شرکت"))
        { }

    }
    public class CompanyLadBillNotFound : System.Exception
    {

        public CompanyLadBillNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "بارنامه"))
        { }

    }
    public class CountryNotFound : System.Exception
    {

        public CountryNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "کشور"))
        { }

    }
    public class BoxingNotFound : System.Exception
    {

        public BoxingNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "بسته بندی"))
        { }

    }
    public class GoodNotFound : System.Exception
    {

        public GoodNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "کالا"))
        { }

    }
    public class InfractionTypeNotFound : System.Exception
    {

        public InfractionTypeNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "نوع تخلف"))
        { }

    }
    public class LadeCancelCommentNotFound : System.Exception
    {

        public LadeCancelCommentNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "توضیح انصراف از اعلان بار"))
        { }

    }
    public class LadeCommentNotFound : System.Exception
    {

        public LadeCommentNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "توضیحات اعلان بار"))
        { }

    }
    public class PlateCityNotFound : System.Exception
    {

        public PlateCityNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "محل شماره گذاری"))
        { }

    }
    public class PortPlacesNotFound : System.Exception
    {

        public PortPlacesNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "محل بارگیری"))
        { }

    }
    public class LaderTypeNotFound : System.Exception
    {

        public LaderTypeNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "نوع بارگیر"))
        { }

    }
    public class RevokeCommentNotFound : System.Exception
    {

        public RevokeCommentNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "ابطال مجوز"))
        { }

    }
    public class SaloonNotFound : System.Exception
    {

        public SaloonNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "سالن"))
        { }

    }
    public class ServicesNotFound : System.Exception
    {

        public ServicesNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "سرویس"))
        { }

    }
    public class StopFeeNotFound : System.Exception
    {

        public StopFeeNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "هزینه ماندن در پارکینگ"))
        { }

    }
    public class InfractionSurveyGroupNotFound : System.Exception
    {

        public InfractionSurveyGroupNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "گروه بررسی تخلفات"))
        { }

    }
    public class InfractionSurveyUsersNotFound : System.Exception
    {

        public InfractionSurveyUsersNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "کاربران بررسی تخلفات"))
        { }

    }
    public class TrafficTypeNotFound : System.Exception
    {

        public TrafficTypeNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "تردد"))
        { }

    }
    public class TurnCancelCommentNotFound : System.Exception
    {

        public TurnCancelCommentNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "توضیح ابطال نوبت"))
        { }

    }

        public class LaderPivotGroupNotFound : System.Exception
    {

        public LaderPivotGroupNotFound()
            : base(String.Format(ExceptionCs.RecordNotFound, "گروه محور"))
        { }

    }

        public class InfractionGroupNotFound : System.Exception
        {

            public InfractionGroupNotFound()
                : base(String.Format(ExceptionCs.RecordNotFound, "گروه های تخلف"))
            { }

        }

        public class BillNotFound : System.Exception
        {

            public BillNotFound()
                : base(String.Format(ExceptionCs.RecordNotFound, "قبض"))
            { }

        }

        public class UserGroupNotFound : System.Exception
        {

            public UserGroupNotFound()
                : base(String.Format(ExceptionCs.RecordNotFound, "گروه های کاربری"))
            { }

        }

        public class UserNotFound : System.Exception
        {

            public UserNotFound()
                : base(String.Format(ExceptionCs.RecordNotFound, "کاربر"))
            { }

        }
        public class ChargePriceNotFound : System.Exception
        {

            public ChargePriceNotFound()
                : base(String.Format(ExceptionCs.RecordNotFound, "شارژ مالی"))
            { }

        }
     public class DriverNotFound : System.Exception
        {

         public DriverNotFound()
                : base(String.Format(ExceptionCs.RecordNotFound, "راننده"))
            { }

        }
     public class MessageNotFound : System.Exception
     {

         public MessageNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "پیام"))
         { }

     }
     public class NewsNotFound : System.Exception
     {

         public NewsNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "اخبار"))
         { }

     }
     public class MessageRecipientNotFound : System.Exception
     {

         public MessageRecipientNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "گروه دریافت کننده پیام"))
         { }

     }
     public class CarNotFound : System.Exception
     {

         public CarNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "ماشین"))
         { }

     }
     public class ProvinceNotFound : System.Exception
     {

         public ProvinceNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "استان"))
         { }

     }
     public class TurnManagementNotFound : System.Exception
     {

         public TurnManagementNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "مدیریت نوبت"))
         { }

     }
     public class LadeAssignmentNotFound : System.Exception
     {

         public LadeAssignmentNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "اطلاع رسانی بار"))
         { }

     }
     public class LadeAssignmentCommentNotFound : System.Exception
     {

         public LadeAssignmentCommentNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "توضیحات"))
         { }

     }
     public class LadeCancelAssignmentNotFound : System.Exception
     {

         public LadeCancelAssignmentNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "توضیحات انصراف"))
         { }

     }
     public class UsedLadBillNotFound : System.Exception
     {

         public UsedLadBillNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "بارنامه های تحویلی به راننده"))
         { }

     }
     public class PriceNormNotFound : System.Exception
     {

         public PriceNormNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "نرخ عرف"))
         { }

     }
     public class LadBillCreditNotFound : System.Exception
     {

         public LadBillCreditNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "مجوز بارگیری"))
         { }

     }
     public class TrafficNotFound : System.Exception
     {

         public TrafficNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "تردد"))
         { }

     }
     public class InfractionNotFound : System.Exception
     {

         public InfractionNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "تخلف"))
         { }

     }

     public class LadBillCancelCommentNotFound : System.Exception
     {

         public LadBillCancelCommentNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "توضیحات ابطال مجوز"))
         { }

     }

     public class LadeAssignmentCacelRequestNotFound : System.Exception
     {

         public LadeAssignmentCacelRequestNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "درخواست انصراف از اطلاع رسانی بار"))
         { }

     }

     public class LadBillCreditCancelNotFound : System.Exception
     {

         public LadBillCreditCancelNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "حذف مجوز بارگیری"))
         { }

     }

     public class CarSystemNotFound : System.Exception
     {

         public CarSystemNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "سیستم خودرو"))
         { }

     }
    
     public class ClassNotFound : System.Exception
     {

         public ClassNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "کلاس"))
         { }

     }

     public class DriverSpecificationNotFound : System.Exception
     {

         public DriverSpecificationNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "جزئیات راننده"))
         { }

     }

     public class DestinationAddressNotFound : System.Exception
     {

         public DestinationAddressNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "آدرس مقصد"))
         { }

     }
     public class CompanyMobileNotFound : System.Exception
     {
         public CompanyMobileNotFound()
             : base(string.Format(ExceptionCs.RecordNotFound, "شماره موبایل شرکت"))
         { }
     }

     public class CompanyGroupNotFound : System.Exception
     {

         public CompanyGroupNotFound()
             : base(String.Format(ExceptionCs.RecordNotFound, "گروه شرکت"))
         { }

     }
}
