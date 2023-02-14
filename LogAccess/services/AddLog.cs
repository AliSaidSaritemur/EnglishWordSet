using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAccess.services
{
    public static class AddLog
    {
        private static SystemLogs tempSystemLogs;
        private static ConvertedWordsLogs tempConvertedWordsLogs;
        private static WrongWords tempWrongWords;

        public static SystemLogs systemLogs { get {
                tempSystemLogs = (tempSystemLogs == null) ? new SystemLogs() : tempSystemLogs;
                return tempSystemLogs;
            } }
       
        public static ConvertedWordsLogs ConvertedWordsLogs
        {
            get
            {
                tempConvertedWordsLogs = (tempConvertedWordsLogs == null) ? new ConvertedWordsLogs() : tempConvertedWordsLogs;
                return tempConvertedWordsLogs;
            }
        }
        public static WrongWords WrongWordsLogs
        {
            get
            {
                tempWrongWords = (tempWrongWords == null) ? new WrongWords() : tempWrongWords;
                return tempWrongWords;
            }
        }
    }
}
