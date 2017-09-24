namespace MRD.Common.Services.DateTime
{
    public class TimeService : ITimeService
    {
        public System.DateTime CurrentDateTime => System.DateTime.Now;
    }
}
