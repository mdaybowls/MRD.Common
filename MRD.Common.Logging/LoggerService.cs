using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace MRD.Common.Logging
{
    public class LoggerService : ILoggerService
    {
        private static readonly NLog.ILogger LocalLogger = LogManager.GetCurrentClassLogger();

        public NLog.ILogger GetLogger()
        {
            return LocalLogger;
        }
    }
}
