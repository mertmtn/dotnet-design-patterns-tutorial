namespace DecoratorPattern.RealLifeScenario.Logging
{
    public abstract class LogDecorator : ILog
    {
        private readonly ILog _log;

        public LogDecorator(ILog log)
        {
            _log = log;
        }

        public void Error(Exception ex, LogInformation logInformation)
        {
            _log.Error(ex, logInformation);
        }

        public void Information(LogInformation logInformation)
        {
            _log.Information(logInformation);
        }

        public void Warning(LogInformation logInformation)
        {
            _log.Warning(logInformation);
        }
    }
}
