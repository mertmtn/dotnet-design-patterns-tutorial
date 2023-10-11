namespace StrategyPattern
{
    class LogContext : ILoggingStrategy
    {
        private ILoggingStrategy _loggingStrategy;

        public LogContext(ILoggingStrategy loggingStrategy)
        {
            _loggingStrategy = loggingStrategy;
        }

        public void Error(Exception ex, LogInformation logInformation)
        {
            _loggingStrategy.Error(ex, logInformation);
        }

        public void Information(LogInformation logInformation)
        {
            _loggingStrategy.Information(logInformation);
        }

        public void Warning(LogInformation logInformation)
        {
            _loggingStrategy.Warning(logInformation);
        }
    }
}
