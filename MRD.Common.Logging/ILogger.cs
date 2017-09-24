using System;

namespace MRD.Common.Logging
{
    public interface ILogger
    {
        void LogDebug(string message);
        void LogDebug(string messageFormat, params object[] values);
        void LogInfo(string message);
        void LogInfo(string messageFormat, params object[] values);
        void LogWarning(string message);
        void LogWarning(string messageFormat, params object[] values);
        void LogError(string messageFormat, params object[] values);
        void LogError(Exception ex, string message);
        void LogError(Exception ex, string messageFormat, params object[] values);
    }
}