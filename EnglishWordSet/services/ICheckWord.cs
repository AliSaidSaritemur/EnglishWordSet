using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services
{
    internal interface ICheckWord
    {
        bool IsCheck(string word);
    }
}
