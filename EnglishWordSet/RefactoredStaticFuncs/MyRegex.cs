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

        public static bool Isthere(string line, string obj)
        {
            bool result;
            Regex rgLine = new (obj);
            Match matchRgL = rgLine.Match(line);
            result = matchRgL.Success;

            return result;
        }
    }
}
