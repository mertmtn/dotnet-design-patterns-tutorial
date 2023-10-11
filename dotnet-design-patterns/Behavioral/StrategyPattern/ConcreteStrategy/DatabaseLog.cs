namespace StrategyPattern.ConcreteStrategy
{
    public class DatabaseLog : ILoggingStrategy
    {
        public void Error(Exception ex, LogInformation logInformation)
        {
            Console.WriteLine($"Logged to database as error");
        }

        public void Information(LogInformation logInformation)
        {
            Console.WriteLine($"Logged to database as information");
        } 

        public void Warning(LogInformation logInformation)
        {
            Console.WriteLine($"Logged to database as warning");
        }
    }
}
