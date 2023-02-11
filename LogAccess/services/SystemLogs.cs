using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAccess.services
{
    public  class SystemLogs : Logs
    {
        public SystemLogs()
        {
            logger = LogManager.GetLogger("systemLog");
        }
       
    }
}
