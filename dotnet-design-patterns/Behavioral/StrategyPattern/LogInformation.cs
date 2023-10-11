namespace StrategyPattern
{
    public class LogInformation
    {
        public string Severity { get; set; }
        public string ApplicationName { get; set; }
        public string Environment { get; set; }
        public string IpAddress { get; set; }
        public string Message { get; set; }
        public DateTime LoggedDate { get; set; }
    }
}