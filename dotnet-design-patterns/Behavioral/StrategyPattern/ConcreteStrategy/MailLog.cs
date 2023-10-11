namespace StrategyPattern.ConcreteStrategy
{
    public class MailLog : ILoggingStrategy
    {
        public void Error(Exception ex, LogInformation logInformation)
        {
            Console.WriteLine($"Logged to mail as error");
        }

        public void Information(LogInformation logInformation)
        {
            Console.WriteLine($"Logged to mail as information");
        }

        public void Warning(LogInformation logInformation)
        {
            Console.WriteLine($"Logged to mail as warning");
        }
    }
}
