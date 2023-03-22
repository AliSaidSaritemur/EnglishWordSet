using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class StringTransactionsWithFunc
    {
       public static string ReadStringWithAction(string inputText, Func<string,string> delegeteToLine)
        {
            StringReader stringReader = new(inputText);
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

