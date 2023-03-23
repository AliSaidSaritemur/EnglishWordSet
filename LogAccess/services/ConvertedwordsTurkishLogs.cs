using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAccess.services
{
    public class ConvertedwordsTurkishLogs :Logs
    {
        public ConvertedwordsTurkishLogs()
        {
            logger = LogManager.GetLogger("ConvertedWordsTurkish");
        }
        public override void Info(string message)
        {
            logger.Info("\n" + message);
        }
        public override void Trace(string message)
        {
            logger.Trace("\n" + message);
        }
    }
}
