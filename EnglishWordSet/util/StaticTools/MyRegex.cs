using Microsoft.EntityFrameworkCore.Query;
using System.Text.RegularExpressions;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyRegex
    {
        private static bool result;
        public static bool Isthere(string line, string obj)
        {
            Regex rgLine = new (obj);
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

        public static bool IsMail(string line)
        {
            Regex rgLine = new("[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
            Match matchRgL = rgLine.Match(line);
            result = matchRgL.Success;
            return result;
        }
    }
}
