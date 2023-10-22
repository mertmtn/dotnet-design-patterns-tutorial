namespace DecoratorPattern.RealLifeScenario.Logging
{
    public class MailLogDecorator : LogDecorator
    {
        public MailLogDecorator(ILog log) : base(log)
        {
        }

        public void Information(LogInformation logInformation)
        {
            base.Information(logInformation);
            Console.WriteLine($"Logged to {logInformation.LogSource} and send to mail");
        }

        public void Error(Exception ex, LogInformation logInformation)
        {
            base.Error(ex,logInformation);
            Console.WriteLine($"Logged to {logInformation.LogSource} and send to mail"); 
        }

        public void Warning(LogInformation logInformation)
        {
            base.Warning(logInformation);
            Console.WriteLine($"Logged to {logInformation.LogSource} and send to mail");
        }
    }
}
 