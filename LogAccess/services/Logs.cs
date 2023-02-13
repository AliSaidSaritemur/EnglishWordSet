using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAccess
{
     public abstract  class Logs 
    {
        public  Logger logger;

        public virtual void Fatal(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Fatal(message);
            LogManager.Shutdown();
        }
        public virtual void Info(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Info(message);
            LogManager.Shutdown();
        }
        public virtual void Warn(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Warn(message);
            LogManager.Shutdown();
        }
        public virtual void Debug(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Debug(message);
            LogManager.Shutdown();
        }
        public virtual  void Error(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Error(message);
            LogManager.Shutdown();
        }
        public virtual void Trace(string message)
        {
            LogManager.IsLoggingEnabled();
            logger.Trace(message);
            LogManager.Shutdown();
        }
        
    }
}
