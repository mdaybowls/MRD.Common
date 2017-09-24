using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MRD.Common.Services.DateTimeServices;

namespace MRD.Common.Services.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TimeService_GetCurrentDateTime_ReturnsDateTimeNow()
        {
            var timeService = new TimeService();
            var timeSpan = DateTime.Now - timeService.GetCurrentDateTime();
            Console.WriteLine(timeSpan.TotalMilliseconds);
            Assert.AreEqual(DateTime.Now, timeService.GetCurrentDateTime());

        }
    }
}
