namespace StrategyPattern.ConcreteStrategy
{
    public class MailLog : ILoggingStrategy
    {
        public void LogSomething(string logDetails)
        {
            Console.WriteLine($"Logged with mail. Message is {logDetails}");
        }
    }
}
