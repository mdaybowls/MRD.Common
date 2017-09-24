namespace MRD.Common.Services.DateTimeServices
{
    public class TimeService : ITimeService
    {
        public System.DateTime GetCurrentDateTime()
        {
            return System.DateTime.Now;
        }
    }
}
