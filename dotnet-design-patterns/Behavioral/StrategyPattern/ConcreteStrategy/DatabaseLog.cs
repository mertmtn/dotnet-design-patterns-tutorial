namespace StrategyPattern.ConcreteStrategy
{
    public class DatabaseLog : ILoggingStrategy
    {
        public void LogSomething(string logDetails)
        {
            Console.WriteLine($"Logged to database Message is {logDetails}");
        }
    }
}
