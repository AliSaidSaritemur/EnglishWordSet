using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.MyTools
{
    public class DataEncryption
    {

        public string Encrypt(string Value)
        {
            string result = null;
            char[] _Value = Value.ToCharArray();

            foreach (char item in _Value)
            {
                result += Convert.ToChar(item + 3).ToString();
            }
            foreach (char item in _Value)
            {
                result += Convert.ToChar(item - 8).ToString();
            }
            foreach (char item in _Value)
            {
                result += Convert.ToChar(item +6).ToString();
            }
            return result;
        }
    }
}
