using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAccess.services
{
    public class ConvertedWordsLogs :Logs
    {
        public ConvertedWordsLogs()
        {
            logger = LogManager.GetLogger("Convertedwords");
        }
        public override void Info(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Info("\n" + message);
            LogManager.Shutdown();

        }
        public override void Trace(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Trace("\n" + message);
            LogManager.Shutdown();
        }
    }
}
