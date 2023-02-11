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
            logger.Fatal(message);  
        }
        public virtual void Info(string message)
        {
            logger.Info(message);
        }
        public virtual void Warn(string message)
        {
            logger.Warn(message);
        }
        public virtual void Debug(string message)
        {
            logger.Debug(message);
        }
        public virtual  void Error(string message)
        {
            logger.Error(message);
        }
        public virtual void Trace(string message)
        {
            logger.Trace(message);
        }
        
    }
}
