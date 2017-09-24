using System;

namespace MRD.Common.Logging
{
    public class Logger : ILogger
    {
        private readonly NLog.ILogger _localLogger;

        public Logger(ILoggerService loggerService)
        {
            _localLogger = loggerService.GetLogger();
        }
        public void LogDebug(string message)
        {
            _localLogger.Debug(message);
        }

        public void LogDebug(string messageFormat, params object[] values)
        {
            _localLogger.Debug(messageFormat, values);
        }

        public void LogError(string messageFormat, params object[] values)
        {
            _localLogger.Error(messageFormat, values);
        }

        public void LogError(Exception ex, string message)
        {
            _localLogger.Error(ex, message);
        }

        public void LogError(Exception ex, string messageFormat, params object[] values)
        {
            _localLogger.Error(ex, messageFormat, values);
        }

        public void LogInfo(string message)
        {
            _localLogger.Info(message);
        }

        public void LogInfo(string messageFormat, params object[] values)
        {
            _localLogger.Info(messageFormat, values);
        }

        public void LogWarning(string message)
        {
            _localLogger.Warn(message);
        }

        public void LogWarning(string messageFormat, params object[] values)
        {
            _localLogger.Warn(messageFormat, values);
        }
    }
}