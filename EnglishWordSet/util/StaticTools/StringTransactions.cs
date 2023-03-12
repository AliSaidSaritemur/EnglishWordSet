using DataAccess.Concrete;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.util.StaticTools
{
    public static class StringTransactions
    {
       public static string ReadStringWithAction(string inputTExt, Func<string,string> delegeteToLine)
        {
            StringReader stringReader = new(inputTExt);
            string lineToBeRead;
            string result="";
            while (true)
            {

                lineToBeRead = stringReader.ReadLine();

                if (lineToBeRead != null)
                {
                    result += delegeteToLine(lineToBeRead)+"\n";
                }
                else
                {
                    break;
                }

            }
            return result;
        }

    }
    }

