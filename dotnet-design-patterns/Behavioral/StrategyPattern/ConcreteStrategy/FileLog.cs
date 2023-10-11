namespace StrategyPattern.ConcreteStrategy
{
    public class FileLog : ILoggingStrategy
    {
        public void Error(Exception ex, LogInformation logInformation)
        {
            Console.WriteLine($"Logged to file as error");
        }

        public void Information(LogInformation logInformation)
        {
            Console.WriteLine($"Logged to file as information");
        }

        public void Warning(LogInformation logInformation)
        {
            Console.WriteLine($"Logged to file as warning");
        }
    }
}
