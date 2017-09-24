using System;
using NLog;

namespace MRD.Common.Logging
{
    public class Logger : ILogger
    {
        private static readonly NLog.Logger LocalLogger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message)
        {
            LocalLogger.Debug(message);
        }

        public void LogDebug(string messageFormat, params object[] values)
        {
            LocalLogger.Debug(messageFormat, values);
        }

        public void LogError(string messageFormat, params object[] values)
        {
            LocalLogger.Error(messageFormat, values);
        }

        public void LogError(Exception ex, string message)
        {
            LocalLogger.Error(ex, message);
        }

        public void LogError(Exception ex, string messageFormat, params object[] values)
        {
            LocalLogger.Error(ex, messageFormat, values);
        }

        public void LogInfo(string message)
        {
            LocalLogger.Info(message);
        }

        public void LogInfo(string messageFormat, params object[] values)
        {
            LocalLogger.Info(messageFormat, values);
        }

        public void LogWarning(string message)
        {
            LocalLogger.Warn(message);
        }

        public void LogWarning(string messageFormat, params object[] values)
        {
            LocalLogger.Warn(messageFormat, values);
        }
    }
}