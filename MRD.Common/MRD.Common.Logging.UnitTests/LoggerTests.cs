using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MRD.Common.Logging.UnitTests
{
    [TestClass]
    public class LoggerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            
        }

        private Mock<NLog.ILogger> GetMockLogger()
        {
            var mockLogger = new Mock<NLog.ILogger>();
            return mockLogger;
        }

        public Mock<ILoggerService> GetMockLoggerService(Mock<NLog.ILogger> mockLogger)
        {
            var mockLoggerService = new Mock<ILoggerService>();
            mockLoggerService.Setup(s => s.GetLogger()).Returns(mockLogger.Object);
            return mockLoggerService;
        }

        [TestMethod]
        public void Logger_LogDebug_CallsDebug()
        {
            var message = "Logging Debug";
            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogDebug(message);

            mockLoggerService.Verify(v=>v.GetLogger(), Times.Once);
            mockLogger.Verify(v=>v.Debug(message), Times.Once);
        }

        [TestMethod]
        public void Logger_LogDebugFormat_CallsDebugFormat()
        {
            var messageFormat = "{0}";
            var parms = new object[] { "Logging Debug" };

            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogDebug(messageFormat, parms);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Debug(messageFormat, parms), Times.Once);
        }


        [TestMethod]
        public void Logger_LogInfo_CallsInfo()
        {
            var message = "Logging Info";
            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogInfo(message);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Info(message), Times.Once);
        }

        [TestMethod]
        public void Logger_LogInfoFormat_CallsInfoFormat()
        {
            var messageFormat = "{0}";
            var parms = new object[] { "Logging Info" };

            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogInfo(messageFormat, parms);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Info(messageFormat, parms), Times.Once);
        }

        [TestMethod]
        public void Logger_LogWarning_CallsWarn()
        {
            var message = "Logging Warning";
            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogWarning(message);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Warn(message), Times.Once);
        }

        [TestMethod]
        public void Logger_LogWarningWithParms_CallsWarnWithParms()
        {
            var messageFormat = "{0}";
            var parms = new object[] { "Logging Info" };

            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogWarning(messageFormat, parms);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Warn(messageFormat, parms), Times.Once);
        }

        [TestMethod]
        public void Logger_LogError_CallsError()
        {
            var ex = new ArgumentException();
            var message = "Logging Warning";
            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogError(ex, message);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Error(ex, message), Times.Once);
        }

        [TestMethod]
        public void Logger_LogErrorWithParms_CallsErrorWithParms()
        {
            var messageFormat = "{0}";
            var parms = new object[] { "Logging Error" };

            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogError(messageFormat, parms);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Error(messageFormat, parms), Times.Once);
        }

        [TestMethod]
        public void Logger_LogErrorExceptionWithParms_CallsErrorExceptionWithParms()
        {
            var ex = new Exception();
            var messageFormat = "{0}";
            var parms = new object[] { "Logging Error" };

            var mockLogger = GetMockLogger();

            var mockLoggerService = GetMockLoggerService(mockLogger);

            var sut = new Logger(mockLoggerService.Object);
            sut.LogError(ex, messageFormat, parms);

            mockLoggerService.Verify(v => v.GetLogger(), Times.Once);
            mockLogger.Verify(v => v.Error(ex, messageFormat, parms), Times.Once);
        }

        [TestMethod]
        public void LoggerService_GetLogger_ReturnsLogger()
        {
            var sut = new LoggerService();
            var logger = sut.GetLogger();            
            Assert.IsTrue(logger.GetType() == typeof(NLog.Logger));
        }
    }
}
