using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyRegex
    {
      private  static readonly IDictionary<string, string> regexQueries= new Dictionary<string, string>();

       static MyRegex()
        {
            regexQueries.Add("name", "^[\\w'\\-,.][^0-9_!¡?÷?¿/\\\\+=@#$%ˆ&*(){}|~<>;:[\\]]{2,}$");
            regexQueries.Add("mail", "[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
        }

        public static bool Isthere(string line, string obj)
        {
            bool result;
            Regex rgLine = new (obj);
            Match matchRgL = rgLine.Match(line);
            result = matchRgL.Success;
            return result;
        }

        public static bool IsName(string line)
        {
            bool result;
            Regex rgLine = new(regexQueries["name"]);
            Match matchRgL = rgLine.Match(line);
            result = matchRgL.Success;
            return result;
        }

        public static bool IsMail(string line)
        {
            bool result;
            Regex rgLine = new(regexQueries["mail"]);
            Match matchRgL = rgLine.Match(line);
            result = matchRgL.Success;
            return result;
        }
    }
}
