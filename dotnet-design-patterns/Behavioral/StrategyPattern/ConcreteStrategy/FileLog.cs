namespace StrategyPattern.ConcreteStrategy
{
    public class FileLog : ILoggingStrategy
    {
        public void LogSomething(string logDetails)
        {
            Console.WriteLine($"Logged on file. Message is {logDetails}");
        }
    }
}
