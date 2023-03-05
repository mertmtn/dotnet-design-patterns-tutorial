namespace StrategyPattern
{
    class LogContext : ILoggingStrategy
    {
        ILoggingStrategy _LoggingStrategy;

        public LogContext(ILoggingStrategy loggingStrategy)
        {
            _LoggingStrategy = loggingStrategy;
        } 

        public void LogSomething(string logDetails)
        {
            _LoggingStrategy.LogSomething(logDetails);
        }
    }


}
