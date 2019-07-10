using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPS.BLL.TruePlate
{
    class ConvertToTrueNumber
    {
        public string GetPlateNumber(string plateNumber)
        {
            try
            //{
            //    //۹۴ع۱۱۹
            //    string firstPart = plateNumber.Substring(0, 2);
            //    string trueFirstPart = string.Empty;
            //    string character = string.Empty;
            //    string endPart = string.Empty;
            //    string trueEndPart = string.Empty;
            //    if (plateNumber.Length > 3)
            //    {
            //        character = plateNumber.Substring(7, 1);
            //        endPart=plateNumber.Substring(3, 3);
            //        if (character == "ا")
            //        {
            //            character = "الف";
            //        }
            //        for (int i = 0; i < endPart.Length; i++)
            //        {
            //            trueEndPart += GetTrueNumber(endPart.Substring(i, 1)); ;
            //        }
            //    }

            //    for (int i = 0; i < firstPart.Length; i++)
            //    {
            //        trueFirstPart += GetTrueNumber(firstPart.Substring(i, 1));
            //    }

            //    plateNumber = trueFirstPart + character + trueEndPart;
            {
                //۹۴ع۱۱۹
                string firstPart = plateNumber.Substring(0, 2);
                string trueFirstPart = string.Empty;
                string character = string.Empty;
                string endPart = string.Empty;
                string trueEndPart = string.Empty;
                if (plateNumber.Length > 3)
                {

                    character = plateNumber.Substring(4, 1);
                    if (character == "ا")
                    {
                        character = "الف";
                    }
                    if (character == "ى")
                    {
                        character = "ی";
                    }
                    if (character == "ي")
                    {
                        character = "ی";
                    }
                    endPart = plateNumber.Substring(6, 3);

                    for (int i = 0; i < endPart.Length; i++)
                    {
                        trueEndPart += GetTrueNumber(endPart.Substring(i, 1)); ;
                    }
                }

                for (int i = 0; i < firstPart.Length; i++)
                {
                    trueFirstPart += GetTrueNumber(firstPart.Substring(i, 1));
                }

                plateNumber = trueFirstPart + character + trueEndPart;
            }
            catch (Exception ex)
            {

                throw;
            }
            return plateNumber;
        }

        private string GetTrueNumber(string number)
        {
            switch (number)
            {
                case "۰":
                    number = "0";
                    break;
                case "۱":
                    number = "1";
                    break;
                case "۲":
                    number = "2";
                    break;
                case "۳":
                    number = "3";
                    break;
                case "۴":
                    number = "4";
                    break;
                case "۵":
                    number = "5";
                    break;
                case "۶":
                    number = "6";
                    break;
                case "۷":
                    number = "7";
                    break;
                case "۸":
                    number = "8";
                    break;
                case "۹":
                    number = "9";
                    break;
            }

            return number;
        }

    }
}
