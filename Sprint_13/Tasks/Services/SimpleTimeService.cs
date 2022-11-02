namespace Tasks.Services
{
    public class SimpleTimeService : ITimeService
    {
        public DateTime GetTimeForTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
