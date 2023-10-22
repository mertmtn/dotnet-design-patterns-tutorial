namespace DecoratorPattern.RealLifeScenario.Logging
{
    public class GraylogLog:ILog
    {
        public void Error(Exception ex, LogInformation logInformation)
        {
            Console.WriteLine(logInformation.Message);
            Console.WriteLine(ex.Message);
        }

        public void Information(LogInformation logInformation)
        {
            Console.WriteLine(logInformation.Message);
        }

        public void Warning(LogInformation logInformation)
        {
            Console.WriteLine(logInformation.Message);
        }
    }
}
