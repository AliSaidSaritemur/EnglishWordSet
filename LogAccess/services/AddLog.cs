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
        private static ConvertedwordsTurkishLogs tempTurkishLogs;

        public static SystemLogs systemLogs => tempSystemLogs ?? new SystemLogs();
        
        public static ConvertedWordsLogs ConvertedWordsLogs => tempConvertedWordsLogs ?? new ConvertedWordsLogs();

        public static WrongWords WrongWordsLogs => tempWrongWords ?? new WrongWords();

        public static ConvertedwordsTurkishLogs ConvertedwordsTurkih => tempTurkishLogs ?? new ConvertedwordsTurkishLogs();

    }
}
