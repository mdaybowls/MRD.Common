using System;
using NLog;

namespace MRD.Common.Logging
{
    public class LoggerService : ILoggerService
    {
        private static readonly NLog.ILogger LocalLogger = LogManager.GetLogger(Environment.MachineName);

        public NLog.ILogger GetLogger()
        {
            return LocalLogger;
        }
    }
}
