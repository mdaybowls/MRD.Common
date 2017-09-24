namespace MRD.Common.Logging
{
    public interface ILoggerService
    {
        NLog.ILogger GetLogger();
    }
}