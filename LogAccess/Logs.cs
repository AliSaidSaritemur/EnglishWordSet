using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAccess
{
    public static class Logs
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Fatal(string message)
        {
            logger.Fatal(message);  
        }
        public static void Info(string message)
        {
            logger.Info(message);
        }
        public static void Warn(string message)
        {
            logger.Warn(message);
        }
        public static void Debug(string message)
        {
            logger.Debug(message);
        }
        public static void Error(string message)
        {
            logger.Error(message);
        }
    }
}
