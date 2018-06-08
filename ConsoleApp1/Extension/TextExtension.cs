using ConsoleApp1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extension
{
   public static class TextExtension
    {
        public static bool IsTextEmptyOrNull(this string text) => String.IsNullOrEmpty(text);
               
        public static string ConvertToLower(this string text) => text.ToLower();

        public static List<string> GetDistinctItems(this string subText)
        {
            return subText.ToLower().Split(Constant.Seperator).ToList().Distinct() as List<string>;
        }

        public static string CheckCaseSensitive(this string result, string text)
        {
            foreach (string s in text.Split(Constant.Seperator).ToList())
            {
               result= result.Replace(s.ToLower(), s);
            }

            return result;

        }
    }
}
