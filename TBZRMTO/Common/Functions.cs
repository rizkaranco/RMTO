using System.Globalization;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace System
{
    public static class ExtentionFuncs
    {



        public static string SubString(this string text,int WordCount)
        {
            if (text.Split(' ').Count() >= WordCount)
            {
                string Res = "";
                for (int i = 0; i < WordCount; i++)
                {
                     Res += text.Split(' ')[i] + " ";
                }
                return Res + " ...";
            }
            return text;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        public static string ToPlainText(this string Html,int SubstringWordCount=0)
        {
            string output;
            //get rid of HTML tags
            output = Regex.Replace(Html, "<[^>]*>", string.Empty);
            //get rid of multiple blank lines
            output = Regex.Replace(output, @"^\s*$\n", string.Empty, RegexOptions.Multiline);
            if (SubstringWordCount > 0)
            {
                return output.SubString(50);
            }
            return output;        }
        public static string ToValidBody(this string body,string VideoCode,string Metas,string CurrentPageUrl)
        {
           
            return body.Replace(" alt=\"\"", " alt=\"" + Metas + "\"").Replace("[refer]", CurrentPageUrl).Replace("#video#",VideoCode);
        }
        public static string CodeString(this string txt)
        {

            string tmp = txt.Replace(' ','-').Replace('.','_').Replace("&","and").Replace("#","sharp").Replace("/","and").Replace(":","").Replace("+","به-همراه-");
            return tmp;
        }
        public static string DecodeString(this string txt)
        {

            string tmp = txt.Replace('-', ' ').Replace('_', '.');
            return tmp;
        }

        public static string ToHtmlString(this string txt)
        {
            if (txt.IsNullOrEmpty())
                return "";
            return txt.Replace("\n", "<br />");
        }

        public static long ToLongDate(this string date)
        {
            if (string.IsNullOrEmpty(date))
                return 0;
            string[] DateParts = date.Split(new char[] { ' ', '/', ':' });
            long output = 0;
            if (DateParts.Length > 3)
                long.TryParse(date.ToFixedDate().Replace("/", string.Empty).Replace(" ", string.Empty).Replace(":", string.Empty), out output);
            else
                long.TryParse(date.ToFixedDate().Replace("/", string.Empty) + "000000", out output);
            return output;
        }

        public static string ToFixedDate(this string date)
        {
            string[] part = date.Split(new char[] { '/',':',' '});
            string Result = $"{part[0]}/{(part[1].Length == 1 ? "0" + part[1] : part[1])}/{(part[2].Length == 1 ? "0" + part[2] : part[2])}";
            if(part.Length > 3)
            {
                Result += $" {(part[3].Length == 1 ? "0" + part[3] : part[3])}:{(part[4].Length == 1 ? "0" + part[4] : part[4])}:{(part[5].Length == 1 ? "0" + part[5] : part[5])}";
            }
            return Result;
        }
        public static int ToInt(this object number)
        {
          
                return int.Parse(number.ToString());
            
        }

        public static double ToDouble(this object number)
        {

            return Convert.ToDouble(number.ToString());

        }

        public static decimal ToDecimal(this object number)
        {

            return Convert.ToDecimal(number.ToString());

        }
        public static long ToLong(this object number)
        {
           
                    return long.Parse(number.ToString().Replace("\"", string.Empty));
           
        }
        public static byte ToByte(this object number)
        {
            
                return byte.Parse(number.ToString());
        }
        public static bool? ToBoolean(this object _bool)
        {
            if (_bool == null)
                return null;
            return bool.Parse(_bool.ToString());
        }
        public enum ImageType
        {
            UserIcon,
            CourseImage,
            Header
        }

        public static string LongToStringDate(this long date)
        {

            return date.ToString("####/##/##");
        }

        public static string GetImage(this string img, ImageType imgType)
        {
            string DefaultImage = "/images/DefaultItemLogo.jpg";
            if (imgType == ImageType.UserIcon)
                DefaultImage = "/images/noavatar.png";

            if (img == null)
                return DefaultImage;
            else
                return string.IsNullOrEmpty(img) ? DefaultImage : img;
        }
        public static string GetImage(this byte[] img,ImageType imgType)
        {
            string DefaultImage = "/images/DefaultItemLogo.jpg";
            if (imgType == ImageType.UserIcon)
            DefaultImage = "/images/noavatar.png";

            if (img == null)
                return DefaultImage;
            else
           return (img).Length < 20 ? DefaultImage : "data:image/png;base64," + Convert.ToBase64String(img);
        }
        public static string FormatPrice(this int? price)
        {
            if (price.HasValue)
                return price.Value.ToString("N0");
            else
                return "";
        }

        public static string FormatPrice(this int price)
        {
            try
            {
                return price.ToString("N0");
            }
            catch { return ""; }
        }

        public static string MakeSecureSQLParam(this string str)
        {
            string res = str.Replace("--","");
            res = res.Replace("'","").Replace("\"","");
            return res;
        }


        /// <summary>
        /// [HS] 
        /// Convert Simple Class Or List Of Object To Json String
        /// </summary>
     
     


        public static PersianDate ToPersianDate(this DateTime datetime)
        {
            DateTime dt = datetime;
            PersianCalendar pc = new PersianCalendar();
            return new PersianDate()
            {
                Year = pc.GetYear(dt),
                Month = pc.GetMonth(dt),
                Day = pc.GetDayOfMonth(dt),
            };
        }

    }

    public class Functions
    {
        public static PersianDate FixedShortDate
        {
            get {
                DateTime dt = DateTime.Now;
                PersianCalendar pc = new PersianCalendar();
                return new PersianDate() {
                    Year = pc.GetYear(dt),
                    Month = pc.GetMonth(dt),
                    Day = pc.GetDayOfMonth(dt),
                };
            }
        }

        

        public static PersianDate FixedShortDateTime
        {
            get
            {
                DateTime dt = DateTime.Now;
                PersianCalendar pc = new PersianCalendar();
                return new PersianDate()
                {
                    Year = pc.GetYear(dt),
                    Month = pc.GetMonth(dt),
                    Day = pc.GetDayOfMonth(dt),
                    DisplayTime = true,
                    FixedDate = true
                };
            }
        }


        public static string ShortDateNotFixed
        {
            get
            {
                DateTime dt = DateTime.Now;
                PersianCalendar pc = new PersianCalendar();
                string Res = $"{pc.GetYear(dt)}/{pc.GetMonth(dt)}/{pc.GetDayOfMonth(dt)}";
                return Res;
            }
        }

        public static string DisplayShortDate
        {
            get
            {
                DayOfWeek Day = DateTime.Now.DayOfWeek;
                
                string DayName = "شنبه";
                string MonthName = "فروردین";
                switch (Day)
                {
                    case DayOfWeek.Sunday:
                        DayName = "یکشنبه";
                        break;
                    case DayOfWeek.Monday:
                        DayName = "دوشنبه";
                        break;
                    case DayOfWeek.Tuesday:
                        DayName = "سه شنبه";
                        break;
                    case DayOfWeek.Wednesday:
                        DayName = "چهارشنبه";
                        break;
                    case DayOfWeek.Thursday:
                        DayName = "پنجشنبه";
                        break;
                    case DayOfWeek.Friday:
                        DayName = "جمعه";
                        break;
                }
                switch (FixedShortDate.Month)
                {
                    case 2:
                        MonthName = "اردیبهشت";
                        break;
                    case 3:
                        MonthName = "خرداد";
                        break;
                    case 4:
                        MonthName = "تیر";
                        break;

                    case 5:
                        MonthName = "مرداد";
                        break;
                    case 6:
                        MonthName = "شهریور";
                        break;
                    case 7:
                        MonthName = "مهر";
                        break;
                    case 8:
                        MonthName = "آبان";
                        break;
                    case 9:
                        MonthName = "آدر";
                        break;
                    case 10:
                        MonthName = "دی";
                        break;
                    case 11:
                        MonthName = "بهمن";
                        break;
                    case 12:
                        MonthName = "اسفند";
                        break;
                }

                        return $@"امروز {DayName} {FixedShortDate.Day} {MonthName} {FixedShortDate.Year}";
            }
        }

        public static string FixDate(string Date)
        {
            string[] Parts = Date.Split('/');
            string Res = Parts[0] +"/";
            if (Parts[1].Length < 2)
                Res += "0" + Parts[1];
            else
                Res += Parts[1];

            if (Parts[2].Length < 2)
                Res += "/0" + Parts[2];
            else
                Res += "/" + Parts[2];
            return Res;
        }
        public static int MakeExpire()
        {
            DateTime dt = DateTime.Now;
            return ((dt.Year - 2000) * 365) + (dt.Month * 31) + dt.Day + 8;
        }
        public static bool CheckExpire(int Expire)
        {
            DateTime dt = DateTime.Now;
            int Date = ((dt.Year - 2000) * 365) + (dt.Month * 31) + dt.Day;
            return (Date <= Expire);
        }


        public static string EncryptID(int id)
        {
            string x = GenerateName(12, GenerateType.TextNum);
            int code1 = (id * 25 + 14);
            char[] nums = code1.ToString().ToCharArray();
            string enx = "";
            int i = 0;
            foreach (char n in nums)
            {
                enx += n.ToString() + x[i++].ToString();
            }
            return enx;
        }
        public static int DecryptID(string code)
        {
            char[] chars = code.ToCharArray();
            string num = "";
            for (int i = 0; i < chars.Length; i += 2)
            {
                num += chars[i].ToString();
            }
            int id = int.Parse(num);
            int decode = ((id - 14) / 25);
            return decode;
        }

       


        
        public enum GenerateType {
            Text,
            Num,
            TextNum
        }
        public static string GenerateName(int count=6,GenerateType type= GenerateType.TextNum)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            if (type == GenerateType.Text)
                chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            else if (type == GenerateType.Num)
                chars = "1234567890";

            string res = "";
            Random rd = new Random();
            for (int i = 0; i < count; i++)
            {
                res += chars[rd.Next(0,chars.Length)];
            }
            return res;
        }



       
    }


    public class PersianDate
    {
        public PersianDate() { }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public bool FixedDate { get; set; } = true;
        public bool DisplayTime { get; set; } = false;

        public override string ToString()
        {
            string date = $"{Year}/{Month}/{Day}";
            if (DisplayTime)
            {
                date += $" {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            }
            if (FixedDate)
                date = date.ToFixedDate();

            return date;
        }

        public long LongDate
        {
            get
            {
                DateTime now = DateTime.Now;
                return $"{Year}/{Month}/{Day} {now.Hour}:{now.Minute}:{now.Second}".ToFixedDate().ToLongDate();
            }
        }

        
    }

}