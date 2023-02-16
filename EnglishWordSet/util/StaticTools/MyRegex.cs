using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using System.Text.RegularExpressions;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyRegex
    {
        private static bool result;
       public static class CheckingValue
        {
            public static bool Isthere(string line, string obj)
            {
                Regex rgLine = new(obj);
                Match matchRgL = rgLine.Match(line);
                result = matchRgL.Success;
                return result;
            }

            public static bool IsName(string line)
            {
                Regex rgLine = new("^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$");
                Match matchRgL = rgLine.Match(line);
                result = matchRgL.Success;
                return result;
            }

            public static bool IsMail(string mail)
            {
                Regex rgLine = new("[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                Match matchRgL = rgLine.Match(mail);
                result = matchRgL.Success;
                return result;
            }
            public static bool IsPhoneNum(string phoneNum)
            {
                Regex rgLine = new("^0?[0-9]{10}$");
                Match matchRgL = rgLine.Match(phoneNum);
                result = matchRgL.Success;
                return result;
            }

            public static bool IsLastCharPunctuation(string text)
            {
                Regex rgLine = new("[.!?\\-]$");
                Match matchRgL = rgLine.Match(text);
                result = matchRgL.Success;
                return result;
            }

        }

       public static class EddittingStringValue
        {
            public static string ReverseString(string text)
            {
                return string.Join("\r\n", text.Split('\r', '\n').Reverse());
            }
            public static string RemoveSpaces(string text)
            {
                return Regex.Replace(text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline); ;
            }         
        }

    }
}
